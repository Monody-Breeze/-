namespace 测试温湿度
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.cb_fs = new System.Windows.Forms.CheckBox();
            this.cb_yq = new System.Windows.Forms.CheckBox();
            this.cb_sd = new System.Windows.Forms.CheckBox();
            this.cb_wd = new System.Windows.Forms.CheckBox();
            this.btn_history = new System.Windows.Forms.Button();
            this.btn_StartOrStop = new System.Windows.Forms.Button();
            this.btn_settimerinterval = new System.Windows.Forms.Button();
            this.ipt_interval = new System.Windows.Forms.TextBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // cb_fs
            // 
            this.cb_fs.AutoSize = true;
            this.cb_fs.Location = new System.Drawing.Point(227, 55);
            this.cb_fs.Name = "cb_fs";
            this.cb_fs.Size = new System.Drawing.Size(48, 16);
            this.cb_fs.TabIndex = 15;
            this.cb_fs.Text = "风速";
            this.cb_fs.UseVisualStyleBackColor = true;
            // 
            // cb_yq
            // 
            this.cb_yq.AutoSize = true;
            this.cb_yq.Location = new System.Drawing.Point(155, 55);
            this.cb_yq.Name = "cb_yq";
            this.cb_yq.Size = new System.Drawing.Size(48, 16);
            this.cb_yq.TabIndex = 14;
            this.cb_yq.Text = "氧气";
            this.cb_yq.UseVisualStyleBackColor = true;
            // 
            // cb_sd
            // 
            this.cb_sd.AutoSize = true;
            this.cb_sd.Location = new System.Drawing.Point(86, 55);
            this.cb_sd.Name = "cb_sd";
            this.cb_sd.Size = new System.Drawing.Size(48, 16);
            this.cb_sd.TabIndex = 13;
            this.cb_sd.Text = "湿度";
            this.cb_sd.UseVisualStyleBackColor = true;
            // 
            // cb_wd
            // 
            this.cb_wd.AutoSize = true;
            this.cb_wd.Location = new System.Drawing.Point(17, 55);
            this.cb_wd.Name = "cb_wd";
            this.cb_wd.Size = new System.Drawing.Size(48, 16);
            this.cb_wd.TabIndex = 12;
            this.cb_wd.Text = "温度";
            this.cb_wd.UseVisualStyleBackColor = true;
            // 
            // btn_history
            // 
            this.btn_history.Location = new System.Drawing.Point(708, 12);
            this.btn_history.Name = "btn_history";
            this.btn_history.Size = new System.Drawing.Size(82, 23);
            this.btn_history.TabIndex = 11;
            this.btn_history.Text = "历史查询";
            this.btn_history.UseVisualStyleBackColor = true;
            // 
            // btn_StartOrStop
            // 
            this.btn_StartOrStop.Location = new System.Drawing.Point(578, 12);
            this.btn_StartOrStop.Name = "btn_StartOrStop";
            this.btn_StartOrStop.Size = new System.Drawing.Size(124, 23);
            this.btn_StartOrStop.TabIndex = 10;
            this.btn_StartOrStop.Text = "开始/停止";
            this.btn_StartOrStop.UseVisualStyleBackColor = true;
            // 
            // btn_settimerinterval
            // 
            this.btn_settimerinterval.Location = new System.Drawing.Point(140, 12);
            this.btn_settimerinterval.Name = "btn_settimerinterval";
            this.btn_settimerinterval.Size = new System.Drawing.Size(135, 23);
            this.btn_settimerinterval.TabIndex = 9;
            this.btn_settimerinterval.Text = "设置时间间隔";
            this.btn_settimerinterval.UseVisualStyleBackColor = true;
            // 
            // ipt_interval
            // 
            this.ipt_interval.Location = new System.Drawing.Point(17, 14);
            this.ipt_interval.Name = "ipt_interval";
            this.ipt_interval.Size = new System.Drawing.Size(117, 21);
            this.ipt_interval.TabIndex = 8;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(17, 86);
            this.chart1.Name = "chart1";
            this.chart1.Size = new System.Drawing.Size(773, 352);
            this.chart1.TabIndex = 16;
            this.chart1.Tag = "";
            this.chart1.Text = "chart1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.cb_fs);
            this.Controls.Add(this.cb_yq);
            this.Controls.Add(this.cb_sd);
            this.Controls.Add(this.cb_wd);
            this.Controls.Add(this.btn_history);
            this.Controls.Add(this.btn_StartOrStop);
            this.Controls.Add(this.btn_settimerinterval);
            this.Controls.Add(this.ipt_interval);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cb_fs;
        private System.Windows.Forms.CheckBox cb_yq;
        private System.Windows.Forms.CheckBox cb_sd;
        private System.Windows.Forms.CheckBox cb_wd;
        private System.Windows.Forms.Button btn_history;
        private System.Windows.Forms.Button btn_StartOrStop;
        private System.Windows.Forms.Button btn_settimerinterval;
        private System.Windows.Forms.TextBox ipt_interval;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}

