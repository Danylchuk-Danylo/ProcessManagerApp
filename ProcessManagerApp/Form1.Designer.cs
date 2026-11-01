namespace ProcessManagerApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            buttonUpdate = new Button();
            buttonStop = new Button();
            listBoxProcesses = new ListBox();
            textBoxInfo = new TextBox();
            label1 = new Label();
            listBoxBlackList = new ListBox();
            buttonToggleDetection = new Button();
            buttonRemoveBlackList = new Button();
            buttonAddBlackList = new Button();
            textBoxBlackListInput = new TextBox();
            detectionTimer = new System.Windows.Forms.Timer(components);
            textBoxInput = new TextBox();
            buttonStart = new Button();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // buttonUpdate
            // 
            buttonUpdate.Location = new Point(28, 20);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(150, 46);
            buttonUpdate.TabIndex = 0;
            buttonUpdate.Text = "Update";
            buttonUpdate.UseVisualStyleBackColor = true;
            // 
            // buttonStop
            // 
            buttonStop.Location = new Point(206, 20);
            buttonStop.Name = "buttonStop";
            buttonStop.Size = new Size(150, 46);
            buttonStop.TabIndex = 1;
            buttonStop.Text = "Stop";
            buttonStop.UseVisualStyleBackColor = true;
            // 
            // listBoxProcesses
            // 
            listBoxProcesses.FormattingEnabled = true;
            listBoxProcesses.Location = new Point(28, 95);
            listBoxProcesses.Name = "listBoxProcesses";
            listBoxProcesses.Size = new Size(328, 644);
            listBoxProcesses.TabIndex = 2;
            // 
            // textBoxInfo
            // 
            textBoxInfo.Location = new Point(382, 95);
            textBoxInfo.Multiline = true;
            textBoxInfo.Name = "textBoxInfo";
            textBoxInfo.Size = new Size(792, 285);
            textBoxInfo.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(382, 50);
            label1.Name = "label1";
            label1.Size = new Size(225, 32);
            label1.TabIndex = 4;
            label1.Text = "Process information";
            // 
            // listBoxBlackList
            // 
            listBoxBlackList.FormattingEnabled = true;
            listBoxBlackList.Location = new Point(391, 447);
            listBoxBlackList.Name = "listBoxBlackList";
            listBoxBlackList.Size = new Size(240, 164);
            listBoxBlackList.TabIndex = 5;
            // 
            // buttonToggleDetection
            // 
            buttonToggleDetection.Location = new Point(656, 447);
            buttonToggleDetection.Name = "buttonToggleDetection";
            buttonToggleDetection.Size = new Size(266, 112);
            buttonToggleDetection.TabIndex = 6;
            buttonToggleDetection.Text = "Start apps detection";
            buttonToggleDetection.UseVisualStyleBackColor = true;
            // 
            // buttonRemoveBlackList
            // 
            buttonRemoveBlackList.Location = new Point(1024, 447);
            buttonRemoveBlackList.Name = "buttonRemoveBlackList";
            buttonRemoveBlackList.Size = new Size(150, 46);
            buttonRemoveBlackList.TabIndex = 7;
            buttonRemoveBlackList.Text = "Remove";
            buttonRemoveBlackList.UseVisualStyleBackColor = true;
            // 
            // buttonAddBlackList
            // 
            buttonAddBlackList.Location = new Point(1024, 513);
            buttonAddBlackList.Name = "buttonAddBlackList";
            buttonAddBlackList.Size = new Size(150, 46);
            buttonAddBlackList.TabIndex = 8;
            buttonAddBlackList.Text = "Add";
            buttonAddBlackList.UseVisualStyleBackColor = true;
            // 
            // textBoxBlackListInput
            // 
            textBoxBlackListInput.Location = new Point(656, 572);
            textBoxBlackListInput.Name = "textBoxBlackListInput";
            textBoxBlackListInput.Size = new Size(518, 39);
            textBoxBlackListInput.TabIndex = 9;
            // 
            // textBoxInput
            // 
            textBoxInput.Location = new Point(391, 700);
            textBoxInput.Name = "textBoxInput";
            textBoxInput.Size = new Size(601, 39);
            textBoxInput.TabIndex = 10;
            // 
            // buttonStart
            // 
            buttonStart.Location = new Point(1024, 696);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new Size(150, 46);
            buttonStart.TabIndex = 11;
            buttonStart.Text = "Start";
            buttonStart.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(391, 396);
            label2.Name = "label2";
            label2.Size = new Size(106, 32);
            label2.TabIndex = 12;
            label2.Text = "Black list";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(391, 654);
            label3.Name = "label3";
            label3.Size = new Size(284, 32);
            label3.TabIndex = 13;
            label3.Text = "Process name of file path";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1186, 759);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(buttonStart);
            Controls.Add(textBoxInput);
            Controls.Add(textBoxBlackListInput);
            Controls.Add(buttonAddBlackList);
            Controls.Add(buttonRemoveBlackList);
            Controls.Add(buttonToggleDetection);
            Controls.Add(listBoxBlackList);
            Controls.Add(label1);
            Controls.Add(textBoxInfo);
            Controls.Add(listBoxProcesses);
            Controls.Add(buttonStop);
            Controls.Add(buttonUpdate);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonUpdate;
        private Button buttonStop;
        private ListBox listBoxProcesses;
        private TextBox textBoxInfo;
        private Label label1;
        private ListBox listBoxBlackList;
        private Button buttonToggleDetection;
        private Button buttonRemoveBlackList;
        private Button buttonAddBlackList;
        private TextBox textBoxBlackListInput;
        private System.Windows.Forms.Timer detectionTimer;
        private TextBox textBoxInput;
        private Button buttonStart;
        private Label label2;
        private Label label3;
    }
}
