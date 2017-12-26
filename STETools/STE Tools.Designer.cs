namespace STETools
{
    partial class STE_Tools : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public STE_Tools()
            : base(Globals.Factory.GetRibbonFactory())
        {
            InitializeComponent();
        }

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(STE_Tools));
            this.steToolsTab = this.Factory.CreateRibbonTab();
            this.serialGeneratorGroup = this.Factory.CreateRibbonGroup();
            this.generateButton = this.Factory.CreateRibbonButton();
            this.steToolsTab.SuspendLayout();
            this.serialGeneratorGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // steToolsTab
            // 
            this.steToolsTab.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
            this.steToolsTab.Groups.Add(this.serialGeneratorGroup);
            this.steToolsTab.Label = "STE Tools";
            this.steToolsTab.Name = "steToolsTab";
            // 
            // serialGeneratorGroup
            // 
            this.serialGeneratorGroup.Items.Add(this.generateButton);
            this.serialGeneratorGroup.Label = "Serial Generator";
            this.serialGeneratorGroup.Name = "serialGeneratorGroup";
            // 
            // generateButton
            // 
            this.generateButton.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.generateButton.Image = ((System.Drawing.Image)(resources.GetObject("generateButton.Image")));
            this.generateButton.Label = "Generate";
            this.generateButton.Name = "generateButton";
            this.generateButton.ShowImage = true;
            this.generateButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.generateButton_Click);
            // 
            // STE_Tools
            // 
            this.Name = "STE_Tools";
            this.RibbonType = "Microsoft.Excel.Workbook";
            this.Tabs.Add(this.steToolsTab);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.STE_Tools_Load);
            this.steToolsTab.ResumeLayout(false);
            this.steToolsTab.PerformLayout();
            this.serialGeneratorGroup.ResumeLayout(false);
            this.serialGeneratorGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab steToolsTab;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup serialGeneratorGroup;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton generateButton;
    }

    partial class ThisRibbonCollection
    {
        internal STE_Tools STE_Tools
        {
            get { return this.GetRibbon<STE_Tools>(); }
        }
    }
}
