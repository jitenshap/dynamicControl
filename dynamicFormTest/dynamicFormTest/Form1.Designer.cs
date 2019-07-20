namespace dynamicFormTest
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.addPanelButton = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.削除ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.種類ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.細長ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.正方形ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Location = new System.Drawing.Point(10, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(50, 200);
            this.panel1.TabIndex = 1;
            // 
            // addPanelButton
            // 
            this.addPanelButton.Location = new System.Drawing.Point(12, 415);
            this.addPanelButton.Name = "addPanelButton";
            this.addPanelButton.Size = new System.Drawing.Size(75, 23);
            this.addPanelButton.TabIndex = 1;
            this.addPanelButton.Text = "+";
            this.addPanelButton.UseVisualStyleBackColor = true;
            this.addPanelButton.Click += new System.EventHandler(this.AddPanelButton_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.削除ToolStripMenuItem,
            this.種類ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(99, 48);
            // 
            // 削除ToolStripMenuItem
            // 
            this.削除ToolStripMenuItem.Name = "削除ToolStripMenuItem";
            this.削除ToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.削除ToolStripMenuItem.Text = "削除";
            this.削除ToolStripMenuItem.Click += new System.EventHandler(this.削除ToolStripMenuItem_Click);
            // 
            // 種類ToolStripMenuItem
            // 
            this.種類ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.細長ToolStripMenuItem,
            this.正方形ToolStripMenuItem});
            this.種類ToolStripMenuItem.Name = "種類ToolStripMenuItem";
            this.種類ToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.種類ToolStripMenuItem.Text = "種類";
            // 
            // 細長ToolStripMenuItem
            // 
            this.細長ToolStripMenuItem.Name = "細長ToolStripMenuItem";
            this.細長ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.細長ToolStripMenuItem.Text = "細長";
            this.細長ToolStripMenuItem.Click += new System.EventHandler(this.細長ToolStripMenuItem_Click);
            // 
            // 正方形ToolStripMenuItem
            // 
            this.正方形ToolStripMenuItem.Name = "正方形ToolStripMenuItem";
            this.正方形ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.正方形ToolStripMenuItem.Text = "正方形";
            this.正方形ToolStripMenuItem.Click += new System.EventHandler(this.正方形ToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.addPanelButton);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button addPanelButton;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 削除ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 種類ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 細長ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 正方形ToolStripMenuItem;
    }
}

