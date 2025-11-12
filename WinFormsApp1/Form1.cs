using cpupc;
using Microsoft.Win32;
using System.Diagnostics;
using System.Management;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;


namespace WinFormsApp1
{
    public partial class Form1 : Form
    {

        public string base_reg = "SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Image File Execution Options\\";
        public string mk_current_reg = "";
        public string sk_current_reg = "";
        public string selected;
        public string[] sp;
        public string pid;
        public int pid_int;
        public Form1()
        {

            InitializeComponent();
            var wmiQueryString = "SELECT ProcessId, ExecutablePath, CommandLine FROM Win32_Process";
            using (var searcher = new ManagementObjectSearcher(wmiQueryString))
            using (var results = searcher.Get())

            {
                var query = from p in Process.GetProcesses()
                            join mo in results.Cast<ManagementObject>()
                            on p.Id equals (int)(uint)mo["ProcessId"]
                            select new
                            {
                                Process = p,
                                PID = p.Id,
                                Path = (string)mo["ExecutablePath"],
                                CommandLine = (string)mo["CommandLine"],

                            };
                foreach (var item in query)
                {
                    if (item.Path is string path && path.Length > 0)
                    {
                        var sp = item.Path.Split(Path.DirectorySeparatorChar);
                        var name = sp[sp.Length - 1];
                        if (listBox1.Items.Contains(name)) { }
                        else
                        {
                            listBox1.Items.Add(name + " (" + item.PID.ToString() + ") ");
                        }

                    }
                }
                listBox1.SelectedIndex = 0;

            }
        }

        public void load_processes()
        {
            listBox1.Items.Clear();

            var wmiQueryString = "SELECT ProcessId, ExecutablePath, CommandLine FROM Win32_Process";
            using (var searcher = new ManagementObjectSearcher(wmiQueryString))
            using (var results = searcher.Get())

            {
                var query = from p in Process.GetProcesses()
                            join mo in results.Cast<ManagementObject>()
                            on p.Id equals (int)(uint)mo["ProcessId"]
                            select new
                            {
                                Process = p,
                                PID = p.Id,
                                Path = (string)mo["ExecutablePath"],
                                CommandLine = (string)mo["CommandLine"],

                            };
                foreach (var item in query)
                {
                    if (item.Path is string path && path.Length > 0)
                    {
                        var sp = item.Path.Split(Path.DirectorySeparatorChar);
                        var name = sp[sp.Length - 1];
                        if (listBox1.Items.Contains(name)) { }
                        else
                        {
                            listBox1.Items.Add(name + " (" + item.PID.ToString() + ") ");
                        }

                    }
                }
            }
            listBox1.SelectedIndex = 0;
        }
        public void load()
        {
            selected_tb1.Text = sp[0];
            current_PIDTB.Text = pid;
            Process p = Process.GetProcessById(pid_int);
            int pclass = (int)p.PriorityClass;
            if (p != null)
            {
                switch (pclass)
                {
                    case 32:
                        selected_PriorityTB.Text = "Normal";
                        break;
                    case 64:
                        selected_PriorityTB.Text = "Idle";
                        break;
                    case 128:
                        selected_PriorityTB.Text = "High";
                        break;
                    case 256:
                        selected_PriorityTB.Text = "RealTime";
                        break;
                    case 16384:
                        selected_PriorityTB.Text = "BelowNormal";
                        break;
                    case 32768:
                        selected_PriorityTB.Text = "AboveNormal";
                        break;

                }
                try
                {
                    reg_mkTB.Text = "";
                    sk_statusLB.Text = "";
                    mk_statusLB.Text = "";
                    cpupriclassLB.Text = "";

                    mk_current_reg = base_reg + sp[0];
                    reg_mkTB.Text = mk_current_reg;
                    sk_current_reg = base_reg + sp[0] + "\\PerfOptions";
                    using (RegistryKey key = Registry.LocalMachine.OpenSubKey(mk_current_reg))
                    {

                        if (key != null)
                        {
                            mk_statusLB.Text = "SET";
                            using (RegistryKey key2 = Registry.LocalMachine.OpenSubKey(sk_current_reg))
                            {
                                if (key2 != null)
                                {
                                    sk_statusLB.Text = "SET";
                                    Object o = key2.GetValue("CpuPriorityClass");
                                    if (o != null)
                                    {
                                        var object_value = o.ToString();
                                        switch (o.ToString())
                                        {
                                            case "1":
                                                cpupriclassLB.Text = "IDLE";
                                                break;
                                            case "2":
                                                cpupriclassLB.Text = "NORMAL";
                                                break;
                                            case "3":
                                                cpupriclassLB.Text = "HIGH";
                                                break;
                                            case "4":
                                                cpupriclassLB.Text = "REALTIME";
                                                break;
                                            case "5":
                                                cpupriclassLB.Text = "BELOWNORMAL";
                                                break;
                                            case "6":
                                                cpupriclassLB.Text = "ABOVE_NORMAL";
                                                break;
                                        }
                                    }
                                    else
                                    {
                                        cpupriclassLB.Text = "NOT_SET";
                                    }
                                }
                                else
                                {
                                    //reg_statusTB.Text = "NOT_SET: " + reg_path2;
                                    sk_statusLB.Text = "NOT_SET";
                                    cpupriclassLB.Text = "NOT_SET";
                                }
                            }
                        }
                        else
                        {
                            mk_statusLB.Text = "NOT_SET";
                            sk_statusLB.Text = "NOT_SET";
                            cpupriclassLB.Text = "NOT_SET";
                        }
                    }
                }
                catch
                {
                    reg_mkTB.Text = "ERROR";
                }

            }

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            selected = listBox1.SelectedItem.ToString();
            sp = selected.Split(" (");
            pid = sp[1].Split(")")[0];
            pid_int = int.Parse(pid);
            selected_priCB.SelectedIndex = -1;
            // from p in 
            load();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void set_subkey(string priority)
        {
            Registry.LocalMachine.CreateSubKey(sk_current_reg, true);
            using RegistryKey myKey = Registry.LocalMachine.OpenSubKey(sk_current_reg, true);
            myKey.SetValue("CpuPriorityClass", priority, RegistryValueKind.DWord);
            myKey.Close();
        }
        private void setButton_Click(object sender, EventArgs e)
        {
            var priority = "";
            switch (selected_priCB.SelectedIndex)
            {
                case -1:
                    MessageBox.Show("No priority selected, please select a priority before continuing", "No Priority Selected",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case 0:
                    priority = "00000003";
                    break;
                case 1:
                    priority = "00000006";
                    break;
                case 2:
                    priority = "00000002";
                    break;
                case 3:
                    priority = "00000005";
                    break;
                case 4:
                    priority = "00000001";
                    break;
            }
            if (priority != "")
            {
                if (cpupriclassLB.Text != "NOT_SET")
                {
                    using RegistryKey myKey = Registry.LocalMachine.OpenSubKey(sk_current_reg, true);
                    myKey.SetValue("CpuPriorityClass", priority, RegistryValueKind.DWord);
                    myKey.Close();
                }
                else
                {
                    if (mk_statusLB.Text == "NOT_SET")
                    {
                        Registry.LocalMachine.CreateSubKey(@sk_current_reg, true);
                        using RegistryKey myKey = Registry.LocalMachine.OpenSubKey(sk_current_reg, true);
                        myKey.SetValue("CpuPriorityClass", priority, RegistryValueKind.DWord);
                        myKey.Close();

                    }
                    else
                    {
                        if (sk_statusLB.Text == "NOT_SET")
                        {
                            Registry.LocalMachine.CreateSubKey(sk_current_reg, true);
                            using RegistryKey myKey = Registry.LocalMachine.OpenSubKey(sk_current_reg, true);
                            myKey.SetValue("CpuPriorityClass", priority, RegistryValueKind.DWord);
                            myKey.Close();
                        }
                        else
                        {
                            using RegistryKey myKey = Registry.LocalMachine.OpenSubKey(sk_current_reg, true);
                            myKey.SetValue("CpuPriorityClass", priority, RegistryValueKind.DWord);
                            myKey.Close();
                        }
                    }

                }
            }
            load();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void openRegeditToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            load_processes();
            load();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Thread(() => new AboutBox1().ShowDialog()).Start();
        }

        private void howToUseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Thread(() => new howto().ShowDialog()).Start();

        }
    }
}
