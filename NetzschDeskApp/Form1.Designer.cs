namespace NetzschDeskApp;

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
        btnSendMessage = new Button();
        btnRefreshMessage = new Button();
        label2 = new Label();
        label3 = new Label();
        txtUserName = new TextBox();
        txtMessage = new TextBox();
        txtMessages = new TextBox();
        label4 = new Label();
        label1 = new Label();
        SuspendLayout();
        // 
        // btnSendMessage
        // 
        btnSendMessage.Location = new Point(300, 214);
        btnSendMessage.Name = "btnSendMessage";
        btnSendMessage.Size = new Size(75, 23);
        btnSendMessage.TabIndex = 0;
        btnSendMessage.Text = "Send";
        btnSendMessage.UseVisualStyleBackColor = true;
        btnSendMessage.Click += btnSendMessage_Click;
        // 
        // btnRefreshMessage
        // 
        btnRefreshMessage.Location = new Point(652, 287);
        btnRefreshMessage.Name = "btnRefreshMessage";
        btnRefreshMessage.Size = new Size(120, 23);
        btnRefreshMessage.TabIndex = 1;
        btnRefreshMessage.Text = "Refresh Message";
        btnRefreshMessage.UseVisualStyleBackColor = true;
        btnRefreshMessage.Click += btnRefreshMessage_Click;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(68, 110);
        label2.Name = "label2";
        label2.Size = new Size(53, 15);
        label2.TabIndex = 3;
        label2.Text = "Message";
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new Point(68, 57);
        label3.Name = "label3";
        label3.Size = new Size(62, 15);
        label3.TabIndex = 4;
        label3.Text = "UserName";
        // 
        // txtUserName
        // 
        txtUserName.Location = new Point(68, 75);
        txtUserName.Name = "txtUserName";
        txtUserName.Size = new Size(307, 23);
        txtUserName.TabIndex = 5;
        // 
        // txtMessage
        // 
        txtMessage.Location = new Point(68, 128);
        txtMessage.Multiline = true;
        txtMessage.Name = "txtMessage";
        txtMessage.Size = new Size(307, 75);
        txtMessage.TabIndex = 6;
        // 
        // txtMessages
        // 
        txtMessages.Location = new Point(68, 316);
        txtMessages.Multiline = true;
        txtMessages.Name = "txtMessages";
        txtMessages.ScrollBars = ScrollBars.Vertical;
        txtMessages.Size = new Size(704, 142);
        txtMessages.TabIndex = 7;
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
        label4.ForeColor = Color.FromArgb(1, 113, 103);
        label4.Location = new Point(346, 281);
        label4.Name = "label4";
        label4.Size = new Size(118, 32);
        label4.TabIndex = 8;
        label4.Text = "Messages";
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
        label1.ForeColor = Color.FromArgb(1, 113, 103);
        label1.Location = new Point(336, 9);
        label1.Name = "label1";
        label1.Size = new Size(169, 32);
        label1.TabIndex = 9;
        label1.Text = "Send Message";
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 470);
        Controls.Add(label1);
        Controls.Add(label4);
        Controls.Add(txtMessages);
        Controls.Add(txtMessage);
        Controls.Add(txtUserName);
        Controls.Add(label3);
        Controls.Add(label2);
        Controls.Add(btnRefreshMessage);
        Controls.Add(btnSendMessage);
        Name = "Form1";
        Text = "Form1";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Button btnSendMessage;
    private Button btnRefreshMessage;
    private Label label2;
    private Label label3;
    private TextBox txtUserName;
    private TextBox txtMessage;
    private TextBox txtMessages;
    private Label label4;
    private Label label1;
}
