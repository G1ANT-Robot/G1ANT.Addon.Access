﻿namespace G1ANT.Addon.Access.Panels
{
    partial class AccessControlsTreePanel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccessControlsTreePanel));
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.insertWPathButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.refreshButton = new System.Windows.Forms.ToolStripButton();
            this.controlsTree = new System.Windows.Forms.TreeView();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.highlightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copynameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyNodeDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acNormalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acDesignToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.viewDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip.SuspendLayout();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip
            // 
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.insertWPathButton,
            this.toolStripSeparator1,
            this.toolStripButton1,
            this.toolStripSeparator2,
            this.refreshButton});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(222, 25);
            this.toolStrip.TabIndex = 0;
            this.toolStrip.Text = "toolStrip1";
            // 
            // insertWPathButton
            // 
            this.insertWPathButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.insertWPathButton.Image = global::G1ANT.Addon.Access.Properties.Resources.insert_into;
            this.insertWPathButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.insertWPathButton.Name = "insertWPathButton";
            this.insertWPathButton.Size = new System.Drawing.Size(23, 22);
            this.insertWPathButton.Text = "Insert WPath";
            this.insertWPathButton.ToolTipText = "Insert path of selected control (also, you can double click at the node)";
            this.insertWPathButton.Click += new System.EventHandler(this.insertWPathButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.ToolTipText = "Highlight selected node";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // refreshButton
            // 
            this.refreshButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.refreshButton.Image = global::G1ANT.Addon.Access.Properties.Resources.refresh;
            this.refreshButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(23, 22);
            this.refreshButton.Text = "Refresh controls";
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // controlsTree
            // 
            this.controlsTree.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.controlsTree.Location = new System.Drawing.Point(0, 55);
            this.controlsTree.Name = "controlsTree";
            this.controlsTree.ShowNodeToolTips = true;
            this.controlsTree.Size = new System.Drawing.Size(222, 362);
            this.controlsTree.TabIndex = 2;
            this.controlsTree.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.controlsTree_BeforeExpand);
            this.controlsTree.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.controlsTree_ElementMouseClick);
            this.controlsTree.DoubleClick += new System.EventHandler(this.controlsTree_DoubleClick);
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.highlightToolStripMenuItem,
            this.copynameToolStripMenuItem,
            this.copyNodeDetailsToolStripMenuItem,
            this.loadFormToolStripMenuItem,
            this.openToolStripMenuItem,
            this.viewDataToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(181, 158);
            this.contextMenuStrip.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip_Opening);
            // 
            // highlightToolStripMenuItem
            // 
            this.highlightToolStripMenuItem.Name = "highlightToolStripMenuItem";
            this.highlightToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.highlightToolStripMenuItem.Text = "&Highlight";
            this.highlightToolStripMenuItem.Click += new System.EventHandler(this.highlightToolStripMenuItem_Click);
            // 
            // copynameToolStripMenuItem
            // 
            this.copynameToolStripMenuItem.Name = "copynameToolStripMenuItem";
            this.copynameToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.copynameToolStripMenuItem.Text = "&Copy to clipboard";
            this.copynameToolStripMenuItem.Click += new System.EventHandler(this.copynameToolStripMenuItem_Click);
            // 
            // copyNodeDetailsToolStripMenuItem
            // 
            this.copyNodeDetailsToolStripMenuItem.Name = "copyNodeDetailsToolStripMenuItem";
            this.copyNodeDetailsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.copyNodeDetailsToolStripMenuItem.Text = "Copy &node details";
            this.copyNodeDetailsToolStripMenuItem.Click += new System.EventHandler(this.copyNodeDetailsToolStripMenuItem_Click);
            // 
            // loadFormToolStripMenuItem
            // 
            this.loadFormToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acNormalToolStripMenuItem,
            this.acDesignToolStripMenuItem});
            this.loadFormToolStripMenuItem.Name = "loadFormToolStripMenuItem";
            this.loadFormToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.loadFormToolStripMenuItem.Text = "&Load form";
            this.loadFormToolStripMenuItem.Visible = false;
            // 
            // acNormalToolStripMenuItem
            // 
            this.acNormalToolStripMenuItem.Name = "acNormalToolStripMenuItem";
            this.acNormalToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.acNormalToolStripMenuItem.Text = "acNormal";
            this.acNormalToolStripMenuItem.Click += new System.EventHandler(this.acNormalToolStripMenuItem_Click);
            // 
            // acDesignToolStripMenuItem
            // 
            this.acDesignToolStripMenuItem.Name = "acDesignToolStripMenuItem";
            this.acDesignToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.acDesignToolStripMenuItem.Text = "acDesign";
            this.acDesignToolStripMenuItem.Click += new System.EventHandler(this.acDesignToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openToolStripMenuItem.Text = "&Open/Execute";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox1.CausesValidation = false;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Location = new System.Drawing.Point(0, 28);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(222, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // viewDataToolStripMenuItem
            // 
            this.viewDataToolStripMenuItem.Name = "viewDataToolStripMenuItem";
            this.viewDataToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.viewDataToolStripMenuItem.Text = "&View data";
            this.viewDataToolStripMenuItem.Click += new System.EventHandler(this.viewDataToolStripMenuItem_Click);
            // 
            // AccessControlsTreePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.controlsTree);
            this.Controls.Add(this.toolStrip);
            this.Name = "AccessControlsTreePanel";
            this.Size = new System.Drawing.Size(222, 420);
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.TreeView controlsTree;
        private System.Windows.Forms.ToolStripButton insertWPathButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton refreshButton;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem highlightToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem copyNodeDetailsToolStripMenuItem;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ToolStripMenuItem loadFormToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acNormalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acDesignToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copynameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewDataToolStripMenuItem;
    }
}
