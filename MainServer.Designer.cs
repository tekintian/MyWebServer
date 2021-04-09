
namespace MyWebServer
{
    partial class MainServer
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainServer));
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label_online = new System.Windows.Forms.Label();
            this.server_status = new System.Windows.Forms.Label();
            this.btn_selectPath = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_basePath = new System.Windows.Forms.TextBox();
            this.textBox_log = new System.Windows.Forms.TextBox();
            this.btn_start = new System.Windows.Forms.Button();
            this.textBox_port = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_ip = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.linkLabel_helloworld = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(418, 455);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(59, 12);
            this.linkLabel1.TabIndex = 29;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "My Github";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label_online
            // 
            this.label_online.AutoSize = true;
            this.label_online.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label_online.Location = new System.Drawing.Point(203, 417);
            this.label_online.Name = "label_online";
            this.label_online.Size = new System.Drawing.Size(47, 12);
            this.label_online.TabIndex = 28;
            this.label_online.Text = "在线0人";
            // 
            // server_status
            // 
            this.server_status.AutoSize = true;
            this.server_status.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.server_status.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.server_status.Location = new System.Drawing.Point(195, 108);
            this.server_status.Name = "server_status";
            this.server_status.Size = new System.Drawing.Size(0, 14);
            this.server_status.TabIndex = 27;
            // 
            // btn_selectPath
            // 
            this.btn_selectPath.Location = new System.Drawing.Point(364, 38);
            this.btn_selectPath.Name = "btn_selectPath";
            this.btn_selectPath.Size = new System.Drawing.Size(75, 23);
            this.btn_selectPath.TabIndex = 26;
            this.btn_selectPath.Text = "选择";
            this.btn_selectPath.UseVisualStyleBackColor = true;
            this.btn_selectPath.Click += new System.EventHandler(this.btn_selectPath_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 12);
            this.label3.TabIndex = 25;
            this.label3.Text = "Web服务路径:";
            // 
            // textBox_basePath
            // 
            this.textBox_basePath.Location = new System.Drawing.Point(145, 38);
            this.textBox_basePath.Name = "textBox_basePath";
            this.textBox_basePath.Size = new System.Drawing.Size(213, 21);
            this.textBox_basePath.TabIndex = 24;
            // 
            // textBox_log
            // 
            this.textBox_log.Location = new System.Drawing.Point(37, 150);
            this.textBox_log.Multiline = true;
            this.textBox_log.Name = "textBox_log";
            this.textBox_log.Size = new System.Drawing.Size(418, 239);
            this.textBox_log.TabIndex = 23;
            // 
            // btn_start
            // 
            this.btn_start.Location = new System.Drawing.Point(364, 77);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(75, 23);
            this.btn_start.TabIndex = 22;
            this.btn_start.Text = "开启服务";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // textBox_port
            // 
            this.textBox_port.Location = new System.Drawing.Point(274, 77);
            this.textBox_port.Name = "textBox_port";
            this.textBox_port.Size = new System.Drawing.Size(70, 21);
            this.textBox_port.TabIndex = 21;
            this.textBox_port.Text = "88";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(233, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 20;
            this.label2.Text = "Port:";
            // 
            // textBox_ip
            // 
            this.textBox_ip.Location = new System.Drawing.Point(64, 76);
            this.textBox_ip.Name = "textBox_ip";
            this.textBox_ip.Size = new System.Drawing.Size(151, 21);
            this.textBox_ip.TabIndex = 19;
            this.textBox_ip.Text = "127.0.0.1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 12);
            this.label1.TabIndex = 18;
            this.label1.Text = "IP:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(143, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(203, 12);
            this.label4.TabIndex = 30;
            this.label4.Text = "企业软件定制开发咨询QQ: 932256355";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label5.Location = new System.Drawing.Point(49, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(377, 12);
            this.label5.TabIndex = 31;
            this.label5.Text = "访问地址: 相对于你设定的web服务路径的地址,前面加上你的ip和端口";
            // 
            // linkLabel_helloworld
            // 
            this.linkLabel_helloworld.AutoSize = true;
            this.linkLabel_helloworld.Location = new System.Drawing.Point(75, 455);
            this.linkLabel_helloworld.Name = "linkLabel_helloworld";
            this.linkLabel_helloworld.Size = new System.Drawing.Size(149, 12);
            this.linkLabel_helloworld.TabIndex = 32;
            this.linkLabel_helloworld.TabStop = true;
            this.linkLabel_helloworld.Text = "点此访问 HelloWorld.aspx";
            this.linkLabel_helloworld.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_helloworld_LinkClicked);
            // 
            // MainServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 490);
            this.Controls.Add(this.linkLabel_helloworld);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label_online);
            this.Controls.Add(this.server_status);
            this.Controls.Add(this.btn_selectPath);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_basePath);
            this.Controls.Add(this.textBox_log);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.textBox_port);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_ip);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainServer";
            this.Text = "MyWebServer By TekinTian";
            this.Load += new System.EventHandler(this.MainServer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label_online;
        private System.Windows.Forms.Label server_status;
        private System.Windows.Forms.Button btn_selectPath;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_basePath;
        private System.Windows.Forms.TextBox textBox_log;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.TextBox textBox_port;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_ip;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.LinkLabel linkLabel_helloworld;
    }
}

