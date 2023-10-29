#region License
/******************************************************************************
 * PcapKeyInjector
 * 
 * Copyright (C) 2023 Thomas Wiens, th.wiens@gmx.de
 *
 * This file is part of PcapKeyInjector.
 *
 * PcapKeyInjector is free software: you can redistribute it and/or modify
 * it under the terms of the GNU Lesser General Public License as
 * published by the Free Software Foundation, either version 3 of the
 * License, or (at your option) any later version.
 /****************************************************************************/
#endregion
using System;
using System.Diagnostics;
using System.Media;
using System.Windows.Forms;

namespace PcapKeyInjector
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void tbInputPcap_DragDrop(object sender, DragEventArgs e)
        {
            string[] filePaths = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            if (filePaths.Length > 0)
            {
                string name = filePaths[0];
                if (name.EndsWith(".pcapng"))
                {
                    tbInputPcap.Text = name;
                    toolStripStatusLabel1.Text = "Wireshark capture pcapng file dropped.";
                }
                else
                {
                    toolStripStatusLabel1.Text = "Dropped file does not end with .pcapng";
                    SystemSounds.Exclamation.Play();
                }
            }
        }

        private void tbInputPcap_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void tbInputKeylog_DragDrop(object sender, DragEventArgs e)
        {
            string[] filePaths = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            if (filePaths.Length > 0)
            {
                string name = filePaths[0];
                if (name.EndsWith(".log"))
                {
                    tbInputKeylog.Text = name;
                    toolStripStatusLabel1.Text = "Keylog file dropped.";
                }
                else
                {
                    toolStripStatusLabel1.Text = "Dropped file does not end with .log.";
                    SystemSounds.Exclamation.Play();
                }
            }
        }

        private void tbInputKeylog_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void RefreshOutputFilename()
        {
            if ((tbInputPcap.Text == String.Empty) || tbInputKeylog.Text == String.Empty)
            {
                tbOutputFilename.Text = String.Empty;
                btnDoInject.Enabled = false;
                return;
            }
            try
            {
                string pcap_filename = tbInputPcap.Text;
                string key_filename = tbInputKeylog.Text;

                string filename = tbOutputFilenamePattern.Text;

                // Remove path and file ending to get the raw filename
                pcap_filename = pcap_filename.Substring(pcap_filename.LastIndexOf("\\") + 1);
                pcap_filename = pcap_filename.Substring(0, pcap_filename.LastIndexOf("."));

                key_filename = key_filename.Substring(key_filename.LastIndexOf("\\") + 1);
                key_filename = key_filename.Substring(0, key_filename.LastIndexOf("."));

                filename = filename.Replace("{1}", pcap_filename);
                filename = filename.Replace("{2}", key_filename);
                filename = tbOutputDirectory.Text + @"\" + filename + ".pcapng";

                tbOutputFilename.Text = filename;
                btnDoInject.Enabled = true;
            }
            catch
            {
                tbOutputFilename.Text = String.Empty;
                btnDoInject.Enabled = false;
            }
        }
        private void btnDoInject_Click(object sender, EventArgs e)
        {
            RefreshOutputFilename();
            if (tbOutputFilename.Text == String.Empty)
            {
                toolStripStatusLabel1.Text = "Please add Wireshark pcapng and keylog file!";
                SystemSounds.Exclamation.Play();
                return;
            }
            string pcap_filename = tbInputPcap.Text;
            string key_filename = tbInputKeylog.Text;
            string dest_filename = tbOutputFilename.Text;

            string pars = "--inject-secrets tls,";
            pars += "\"" + key_filename + "\" ";
            pars += "\"" + pcap_filename + "\" ";
            pars += "\"" + dest_filename + "\" ";

            string editcap = tbPathToEditcap.Text;

            ProcessStartInfo psi = new ProcessStartInfo();
            psi.RedirectStandardOutput = true;
            psi.UseShellExecute = false;
            psi.CreateNoWindow = true;

            psi.FileName = editcap;
            psi.Arguments = pars;

            Process p = Process.Start(psi);
            p.WaitForExit();
            int result = p.ExitCode;
            if (result == 0)
            {
                toolStripStatusLabel1.Text = "File with keys was saved to " + dest_filename;
            }
            else
            {
                toolStripStatusLabel1.Text = "Error! Inject was not successful.";
                SystemSounds.Exclamation.Play();
            }
        }

        private void tbInputPcap_TextChanged(object sender, EventArgs e)
        {
            RefreshOutputFilename();
        }

        private void tbInputKeylog_TextChanged(object sender, EventArgs e)
        {
            RefreshOutputFilename();
        }

        private void tbOutputFilenameScheme_TextChanged(object sender, EventArgs e)
        {
            RefreshOutputFilename();
        }

        private void tbOutputDirectory_TextChanged(object sender, EventArgs e)
        {
            RefreshOutputFilename();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            tbPathToEditcap.Text = Properties.Settings.Default.PathToEditcap;
            tbOutputFilenamePattern.Text = Properties.Settings.Default.OutputFilenamePattern;
            tbOutputDirectory.Text = Properties.Settings.Default.OutputDirectory;
        }

        private void btnSaveSettings_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.PathToEditcap = tbPathToEditcap.Text;
            Properties.Settings.Default.OutputFilenamePattern = tbOutputFilenamePattern.Text;
            Properties.Settings.Default.OutputDirectory = tbOutputDirectory.Text;
            Properties.Settings.Default.Save();
            toolStripStatusLabel1.Text = "User settings saved.";
        }

        private void btnBrowseInputPcap_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Title = "Browse Wireshark capture files (*.pcapng)";
            dlg.DefaultExt = "pcapng";
            dlg.Filter = "Wireshark capture files (*.pcapng)|*.pcapng|All files (*.*)|*.*";
            dlg.FilterIndex = 1;
            dlg.RestoreDirectory = true;
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                tbInputPcap.Text = dlg.FileName;
            }
        }

        private void btnBrowseInputKeylog_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Title = "Browse logfile with TLS secrets to insert (.log)";
            dlg.DefaultExt = "log";
            dlg.Filter = "Keylog files (*.log)|*.log|All files (*.*)|*.*";
            dlg.FilterIndex = 1;
            dlg.RestoreDirectory = true;
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                tbInputKeylog.Text = dlg.FileName;
            }
        }
    }
}
