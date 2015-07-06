using System;
using System.Reflection;
using System.Windows.Forms;

namespace SqlIndexConsole
{
    public partial class AboutBox : Form
    {
        public AboutBox()
        {
            InitializeComponent();
        }

        private void AboutBox_Load(object sender, EventArgs e)
        {
            // Name
            var productAtt = GetCustomAttribute<AssemblyProductAttribute>();
            var product = productAtt == null ? string.Empty : productAtt.Product;
            Text = string.Concat("About ", product);
            TitleLabel.Text = product;
            NameLabel.Text = product;

            // Copyright
            var copyrightAtt = GetCustomAttribute<AssemblyCopyrightAttribute>();
            var copyright = copyrightAtt == null ? string.Empty : copyrightAtt.Copyright;
            var companyAtt = GetCustomAttribute<AssemblyCompanyAttribute>();
            var company = companyAtt == null ? string.Empty : companyAtt.Company;
            CopyrightLabel.Text = string.Concat(copyright, ", ", company);

            // Version
            var assemblyVersion = Assembly.GetExecutingAssembly().GetName().Version;
            VersionLabel.Text = string.Concat("Version ", assemblyVersion);

            // Operating System
            var osVersion = Environment.OSVersion.VersionString;
            OperatingSystemLabel.Text = string.Concat("Operating System: ", osVersion);            
        }

        private T GetCustomAttribute<T>() where T : class
        {
            object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(T), false);
            if (attributes.Length == 0)
            {
                return null;
            }

            return (T)attributes[0];
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
