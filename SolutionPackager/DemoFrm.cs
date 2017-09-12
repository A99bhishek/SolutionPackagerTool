using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using XrmToolBox.Extensibility;
using XrmToolBox.Extensibility.Interfaces;

namespace SolutionPackagerTool
{
    public partial class DemoFrm : PluginControlBase
    {
        public DemoFrm()
        {
            InitializeComponent();
        }


        private void DemoFrm_Load(object sender, EventArgs e)
        {
        }

        private void btnSolutionPackagerExeFinder_Click(object sender, EventArgs e)
        {
            openFileDialogForExe.FileName = "SolutionPackager";
            openFileDialogForExe.Filter = "executable (*.exe)|*.exe";
            openFileDialogForExe.FilterIndex = 0;

            DialogResult dr = openFileDialogForExe.ShowDialog();

            if (dr == DialogResult.OK)
            {
                txtSolutionPackagerExe.Text = openFileDialogForExe.FileName;
            }
        }
       

    

        private void btnUnmanagedSolution_Click(object sender, EventArgs e)
        {
            //openFileDlg.Filter = "Zip File (*.zip)|*.zip";
            //openFileDlg.FilterIndex = 0;

            //DialogResult dr = openFileDlg.ShowDialog();

            //if (dr == DialogResult.OK)
            //{
            //    txtUnmanagedSolutionZip.Text = openFileDlg.FileName;
            //}
        }

        private void cmbPackage_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (cmbPackage.SelectedItem.ToString().ToUpper() == "MANAGED")
            //{
            //    txtManagedSolutionZip.Enabled = true;
            //    btnManagedSolution.Enabled = true;
            //    txtUnmanagedSolutionZip.Enabled = false;
            //    btnUnmanagedSolution.Enabled = false;
            //}
            //else if (cmbPackage.SelectedItem.ToString().ToUpper() == "UNMANAGED")
            //{
            //    txtManagedSolutionZip.Enabled = false;
            //    btnManagedSolution.Enabled = false;
            //    txtUnmanagedSolutionZip.Enabled = true;
            //    btnUnmanagedSolution.Enabled = true;
            //}
            //else
            //{
            //    txtManagedSolutionZip.Enabled = true;
            //    btnManagedSolution.Enabled = true;
            //    txtUnmanagedSolutionZip.Enabled = true;
            //    btnUnmanagedSolution.Enabled = true;

            //}
        }

        private void cmbErrorLevel_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbAllowDelete_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            CloseTool();
        }

        private void llissue_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("mailto:engineerabhishek@outlook.com");
        }

        private bool ValidateInput()
        {
            if (radExtract.Checked == false && radPack.Checked == false)
            {
                eProvider.SetError(lblAction, "Please select an action.");
                return false;
            }
            else
            {
                eProvider.SetError(lblAction, "");
            }

            //if (cmbPackage.SelectedIndex == -1)
            //{
            //    eProvider.SetError(lblPackage, "Please select solution type.");
            //    return false;
            //}

            if (txtSolutionZip.TextLength == 0)
            {
                eProvider.SetError(lblZip, "Please select solution file.");
                return false;
            }
            else
            {
                eProvider.SetError(lblZip, "");
            }

            if (txtFolder.TextLength == 0)
            {
                eProvider.SetError(lblFolder, "Please locate source folder.");
                return false;
            }
            else
            {
                eProvider.SetError(lblFolder, "");
            }

            return true;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (!ValidateInput())
                return;


            string ToolFileName = txtSolutionPackagerExe.Text;
            string args = string.Empty;
            args += radExtract.Checked == true ? " /action:Extract" : "/action:Pack";
            args += " /zipfile:" + txtSolutionZip.Text;

            if (cmbPackage.SelectedIndex != -1)
                args += " /packagetype:" + cmbPackage.SelectedItem.ToString();

            if (!chkAllowWrite.Checked)
                args += " /allowWrite:No";

            if (cmbAllowDelete.SelectedIndex != -1)
                args += " /allowDelete:" + cmbAllowDelete.SelectedItem.ToString();

            if (chkClobber.Checked)
                args += " /clobber";

            if (chkLogo.Checked)
                args += " /nologo";

            if (cmbErrorLevel.SelectedIndex != -1)
                args += " /errorlevel:" + cmbErrorLevel.SelectedItem.ToString();

            if (txtMapFile.TextLength != 0)
                args += " /map:" + txtMapFile.Text;

            if (txtLogFile.TextLength != 0)
                args += " /log:" + txtLogFile.Text;

            if (txtSource.TextLength != 0)
                args += " /sourceLoc:" + txtSource.Text;

            if (txtLocalize.TextLength != 0)
                args += " /localize:" + txtLocalize.Text;

            args += " /folder:" + txtFolder.Text;
            //txtStatus.Text = RunExternalExe(ToolFileName, args);

            //if (cControl != null)
            //{
            //    cControl.Dispose();
            //    this.Controls.Remove(cControl);
            //}

            //cControl = new ConsoleControl.ConsoleControl();

            //cControl.IsInputEnabled = true;
            //cControl.Location = new System.Drawing.Point(818, 61);
            //cControl.Name = "consoleControl";
            //cControl.SendKeyboardCommandsToProcess = false;
            //cControl.ShowDiagnostics = false;
            //cControl.Size = new System.Drawing.Size(537, 476);
            //cControl.TabIndex = 46;

            consoleControl.ProcessExist += new EventHandler(EnableControl);

            //this.Controls.Add(cControl);
            consoleControl.ClearOutput();
            consoleControl.StartProcess(ToolFileName, args);
            btnSubmit.Enabled = false;
            btnAbort.Enabled = true;

        }

        public void EnableControl(object obj, EventArgs e)
        {
            Invoke((Action)(() =>
            {
                btnSubmit.Enabled = true;
                btnAbort.Enabled = false;
            }));
            
        }


        private void btnAbort_Click(object sender, EventArgs e)
        {
            if (consoleControl != null)
            {
                consoleControl.ClearOutput();
                consoleControl.StopProcess();
            }
        }

        //ConsoleControl.ConsoleControl cControl;

        //public string RunExternalExe(string filename, string arguments = null)
        //{
        //    //txtStatus.Text = "";

        //    var process = new Process();

        //    process.StartInfo.FileName = filename;
        //    if (!string.IsNullOrEmpty(arguments))
        //    {
        //        process.StartInfo.Arguments = arguments;
        //    }



        //    //process.StartInfo.CreateNoWindow = false;
        //    //process.StartInfo.WindowStyle = ProcessWindowStyle.Normal;
        //    process.StartInfo.UseShellExecute = false;

        //    process.StartInfo.RedirectStandardError = true;
        //    process.StartInfo.RedirectStandardOutput = true;
        //    var stdOutput = new StringBuilder();
        //    process.OutputDataReceived += (sender, args) => stdOutput.AppendLine(args.Data); // Use AppendLine rather than Append since args.Data is one line of output, not including the newline character.

        //    string stdError = null;
        //    try
        //    {
        //        process.Start();
        //        process.BeginOutputReadLine();
        //        stdError = process.StandardError.ReadToEnd();
        //        //process.WaitForExit();
        //    }
        //    catch (Exception e)
        //    {
        //        throw new Exception("OS error while executing " + Format(filename, arguments) + ": " + e.Message, e);
        //    }

        //    if (process.ExitCode == 0)
        //    {
        //        return stdOutput.ToString();
        //    }
        //    else
        //    {
        //        var message = new StringBuilder();

        //        if (!string.IsNullOrEmpty(stdError))
        //        {
        //            message.AppendLine(stdError);
        //        }

        //        if (stdOutput.Length != 0)
        //        {
        //            message.AppendLine("Std output:");
        //            message.AppendLine(stdOutput.ToString());
        //        }

        //        //throw new Exception(Format(filename, arguments) + " finished with exit code = " + process.ExitCode + ": " + message);
        //        return Format(filename, arguments) + " finished with exit code = " + process.ExitCode + ": " + message;
        //    }
        //}

        //private string Format(string filename, string arguments)
        //{
        //    return "'" + filename +
        //        ((string.IsNullOrEmpty(arguments)) ? string.Empty : " " + arguments) +
        //        "'";
        //}

        private void btnSolutionZip_Click(object sender, EventArgs e)
        {
            if (radExtract.Checked)
            {
                openFileDlg.Filter = "Zip File (*.zip)|*.zip";
                openFileDlg.FilterIndex = 0;

                DialogResult dr = openFileDlg.ShowDialog();

                if (dr == DialogResult.OK)
                {
                    txtSolutionZip.Text = openFileDlg.FileName;
                }
            }
            else
            {
                saveFileDlg.Filter = "Zip File (*.zip)|*.zip";
                saveFileDlg.FilterIndex = 0;

                DialogResult dr = saveFileDlg.ShowDialog();

                if (dr == DialogResult.OK)
                {
                    txtSolutionZip.Text = saveFileDlg.FileName;
                }
            }
        }

        private void btnFolderFinder_Click(object sender, EventArgs e)
        {
            DialogResult dr = folderBrowserDlg.ShowDialog();
            if (dr == DialogResult.OK)
            {
                txtFolder.Text = folderBrowserDlg.SelectedPath;
            }
        }

        private void btnMapFileFinder_Click(object sender, EventArgs e)
        {
            openFileDlg.Filter = "XML File (*.xml)|*.xml";
            openFileDlg.FilterIndex = 0;

            DialogResult dr = openFileDlg.ShowDialog();

            if (dr == DialogResult.OK)
            {
                txtMapFile.Text = openFileDlg.FileName;
            }
        }

        private void btnLogFile_Click(object sender, EventArgs e)
        {
            saveFileDlg.Filter = "Text File (*.txt)|*.txt|All files (*.*)|*.*";
            DialogResult dr = saveFileDlg.ShowDialog();
            if (dr == DialogResult.OK)
            {
                txtLogFile.Text = saveFileDlg.FileName;
            }
        }

        private void radPack_CheckedChanged_1(object sender, EventArgs e)
        {
            chkAllowWrite.Enabled = false;
            cmbAllowDelete.Enabled = false;
            chkClobber.Enabled = false;
            //txtSource.Enabled = false;
            //txtLocalize.Enabled = false;
        }

        private void radExtract_CheckedChanged_1(object sender, EventArgs e)
        {
            chkAllowWrite.Enabled = true;
            cmbAllowDelete.Enabled = true;
            chkClobber.Enabled = true;
            //txtSource.Enabled = true;
            //txtLocalize.Enabled = true;
        }

        private void btnResetPackageType_Click(object sender, EventArgs e)
        {
            cmbPackage.SelectedIndex = -1;
        }

        private void btnAllowDeleteReset_Click(object sender, EventArgs e)
        {
            cmbAllowDelete.SelectedIndex = -1;

        }

        private void btnErrorLevelReset_Click(object sender, EventArgs e)
        {
            cmbErrorLevel.SelectedIndex = -1;
        }



    }
}
