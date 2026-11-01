using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows.Forms;

namespace ProcessManagerApp
{
    public partial class Form1 : Form
    {
        private bool isDetecting = false;

        public Form1()
        {
            InitializeComponent();

            detectionTimer.Interval = 2000;
            detectionTimer.Tick += new EventHandler(detectionTimer_Tick);

            buttonUpdate.Click += new EventHandler(buttonUpdate_Click);
            buttonStop.Click += new EventHandler(buttonStop_Click);
            buttonStart.Click += new EventHandler(buttonStart_Click);
            listBoxProcesses.SelectedIndexChanged += new EventHandler(listBoxProcesses_SelectedIndexChanged);

            buttonAddBlackList.Click += new EventHandler(buttonAddBlackList_Click);
            buttonRemoveBlackList.Click += new EventHandler(buttonRemoveBlackList_Click);
            buttonToggleDetection.Click += new EventHandler(buttonToggleDetection_Click);
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            ProcessHelper.Start(textBoxInput.Text);
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            if (GetActualSelected() is ProcessWraper processWraper)
            {
                ProcessHelper.Stop(processWraper.GetInnerProcess().ProcessName);
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            listBoxProcesses.Items.Clear();
            Process[] allProcesses = Process.GetProcesses();

            for (int i = 0; i < allProcesses.Length; i++)
            {
                listBoxProcesses.Items.Add(new ProcessWraper(allProcesses[i]));
            }
        }

        private void listBoxProcesses_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxInfo.Text = GetActualSelected()?.GetProcessInfo() ?? string.Empty;
        }

        private ProcessWraper GetActualSelected()
        {
            if (listBoxProcesses.SelectedIndex >= 0)
            {
                if (listBoxProcesses.SelectedItem is ProcessWraper processWraper)
                {
                    return processWraper;
                }
            }
            return null;
        }

        private void buttonAddBlackList_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBoxBlackListInput.Text))
            {
                listBoxBlackList.Items.Add(textBoxBlackListInput.Text.Trim().ToLower());
                textBoxBlackListInput.Clear();
            }
        }

        private void buttonRemoveBlackList_Click(object sender, EventArgs e)
        {
            if (listBoxBlackList.SelectedIndex >= 0)
            {
                listBoxBlackList.Items.RemoveAt(listBoxBlackList.SelectedIndex);
            }
        }

        private void buttonToggleDetection_Click(object sender, EventArgs e)
        {
            isDetecting = !isDetecting;
            if (isDetecting)
            {
                buttonToggleDetection.Text = "Stop apps detection";
                detectionTimer.Start();
            }
            else
            {
                buttonToggleDetection.Text = "Start apps detection";
                detectionTimer.Stop();
            }
        }

        private void detectionTimer_Tick(object sender, EventArgs e)
        {
            foreach (var item in listBoxBlackList.Items)
            {
                string bannedProcess = item.ToString();
                ProcessHelper.Stop(bannedProcess, true);
            }
        }
    }

    internal class ProcessWraper
    {
        private Process process;

        public ProcessWraper(Process process)
        {
            this.process = process;
        }

        public Process GetInnerProcess() => process;

        public string GetProcessInfo()
        {
            try
            {
                return $"Process Name: {process.ProcessName}\r\n" +
                    $"ID: {process.Id}\r\n" +
                    $"Start Time: {process.StartTime}\r\n" +
                    $"Memory Usage: {process.WorkingSet64 / 1024 / 1024} MB\r\n" +
                    $"Priority: {process.BasePriority}\r\n" +
                    $"Threads: {process.Threads.Count}\r\n";
            }
            catch (Win32Exception)
            {
                return "Access denied to some process information.";
            }
            catch (Exception)
            {
                return "Process has been terminated.";
            }
        }

        public override string ToString() => process?.ProcessName ?? "Unknown process";
    }

    internal static class ProcessHelper
    {
        private const string unknownProcessName = "Unknown process";

        public static bool Start(string nameOrPath)
        {
            try
            {
                if (!string.IsNullOrEmpty(nameOrPath))
                {
                    ProcessStartInfo startInfo = new ProcessStartInfo()
                    {
                        FileName = nameOrPath,
                        UseShellExecute = true
                    };
                    Process.Start(startInfo);
                    return true;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Process cannot be started. Message={ex.Message}");
            }
            return false;
        }

        public static bool Stop(string name, bool all = false)
        {
            if (!string.IsNullOrEmpty(name))
            {
                name = name.ToLower();
                Process[] processes = Process.GetProcesses();

                for (int i = 0; i < processes.Length; i++)
                {
                    string processName = processes[i].ProcessName ?? string.Empty;
                    if (!string.IsNullOrEmpty(processName) && processName.ToLower().Contains(name))
                    {
                        Stop(processes[i]);
                        if (!all)
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }

        public static bool Stop(Process process)
        {
            try
            {
                if (process != null)
                {
                    process.Kill();
                    return true;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Process cannot be stopped. Message={ex.Message}");
            }
            return false;
        }
    }
}