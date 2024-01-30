namespace RobloxExternalExplorer
{
    partial class Explorer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Explorer));
            this.TopBarDrag = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.TopBar = new System.Windows.Forms.Panel();
            this.Exit = new System.Windows.Forms.Button();
            this.ExplorerTree = new System.Windows.Forms.TreeView();
            this.TopBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // TopBarDrag
            // 
            this.TopBarDrag.Fixed = true;
            this.TopBarDrag.Horizontal = true;
            this.TopBarDrag.TargetControl = this.TopBar;
            this.TopBarDrag.Vertical = true;
            // 
            // TopBar
            // 
            this.TopBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.TopBar.Controls.Add(this.Exit);
            this.TopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopBar.Location = new System.Drawing.Point(0, 0);
            this.TopBar.Name = "TopBar";
            this.TopBar.Size = new System.Drawing.Size(958, 33);
            this.TopBar.TabIndex = 0;
            // 
            // Exit
            // 
            this.Exit.Dock = System.Windows.Forms.DockStyle.Right;
            this.Exit.FlatAppearance.BorderSize = 0;
            this.Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.ForeColor = System.Drawing.Color.Red;
            this.Exit.Location = new System.Drawing.Point(916, 0);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(42, 33);
            this.Exit.TabIndex = 0;
            this.Exit.Text = "X";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // ExplorerTree
            // 
            this.ExplorerTree.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ExplorerTree.Dock = System.Windows.Forms.DockStyle.Top;
            this.ExplorerTree.Location = new System.Drawing.Point(0, 33);
            this.ExplorerTree.Name = "ExplorerTree";
            this.ExplorerTree.Size = new System.Drawing.Size(958, 202);
            this.ExplorerTree.TabIndex = 1;
            this.ExplorerTree.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseDoubleClick);
            // 
            // Explorer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(958, 287);
            this.Controls.Add(this.ExplorerTree);
            this.Controls.Add(this.TopBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Explorer";
            this.Text = "Explorer";
            this.TopBar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuDragControl TopBarDrag;
        private System.Windows.Forms.Panel TopBar;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.TreeView ExplorerTree;
    }
}

