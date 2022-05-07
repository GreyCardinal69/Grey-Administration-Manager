using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using GreyCrammedContainer;

namespace GreyAdministrationManager
{
    public partial class Form1 : Form
    {
        private static List<Executable> _applications;
        private static bool _gamStart;
        private int _pageOffset;

        public Form1 ()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = true;
            this.StartPosition = FormStartPosition.CenterScreen;

            if (File.Exists( Application.StartupPath + "Settings.gcc" )){
                _gamStart = GccConverter.Deserialize<bool>( Application.StartupPath + "Settings.gcc" );
            }else{
                _gamStart = false;
                GccConverter.Serialize( Application.StartupPath + "Settings.gcc", _gamStart );
            }

            if (_gamStart){
                Microsoft.Win32.RegistryKey key = Microsoft.Win32.Registry.CurrentUser.OpenSubKey( "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true );
                key.SetValue( "GAM", Application.ExecutablePath );
                GAMStartUp.Text = "GAM StartUp Y";
            }else{
                Microsoft.Win32.RegistryKey key = Microsoft.Win32.Registry.CurrentUser.OpenSubKey( "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true );
                var Keys = key.GetSubKeyNames();
                if (Keys.Contains( "GAM" )){
                    key.DeleteValue( "GAM" );
                }
                GAMStartUp.Text = "GAM StartUp N";
            }

            if (File.Exists( Application.StartupPath + "Data.gcc" )){
                if (File.ReadAllText( Application.StartupPath + "Data.gcc" ).Length < 10){
                    _applications = new();
                }else{
                    _applications = GccConverter.Deserialize<List<Executable>>( Application.StartupPath + "Data.gcc" );
                }
            }else{
                _applications = new();
                File.Create( Application.StartupPath + "Data.gcc" );
            }

            int FirstPageContentCount = 0;

            foreach (var item in _applications.Where(X => X != null))
            {
                if (FirstPageContentCount < 39){
                    ApplicationsList.Items.Add( item.Name );
                    FirstPageContentCount++;
                }else{
                    break;
                }
            }
        }

        private void AddApp_Click ( object sender, EventArgs e )
        {
            if (ApplicationsList.Items.Count == 39){
                while (_pageOffset + 77 < _applications.Count)
                {
                    ApplicationsList.Items.Clear();
                    _pageOffset += 39;
                }
                NextPage_Click(new object(), new EventArgs());
            }

            Executable NewApp = new()
            {
                Name = ApplicationName.Text,
                Path = PathText.Text,
                LaunchOnStartup = StartUpSwitch.Text == "On"
            };

            if (NewApp.Name == "" || NewApp.Path == ""){
                EventMgr.ForeColor = Color.FromArgb( 1, 255, 0, 89 );
                EventMgr.Text = "Entry Value(s) Empty, Aborting.";
                return;
            }

            if (_applications.Count < 1){
                _applications.Add( NewApp );
                GccConverter.Serialize( Application.StartupPath + "Data.gcc", _applications );
                EventMgr.ForeColor = Color.FromArgb( 1, 52, 189, 235 );
                EventMgr.Text = "New Entry Added.";
                ApplicationsList.Items.Add( NewApp.Name );
                return;
            }else{
                List<string> Names = new();
                for (int i = 0; i < _applications.Count; i++)
                {
                    Names.Add( _applications[i].Name);
                }
                if (!Names.Contains(NewApp.Name)){
                    _applications.Add( NewApp );
                    GccConverter.Serialize( Application.StartupPath + "Data.gcc", _applications );
                    EventMgr.ForeColor = Color.FromArgb( 1, 52, 189, 235 );
                    EventMgr.Text = "New Entry Added.";
                    ApplicationsList.Items.Add(NewApp.Name);
                    return;
                }else{
                    EventMgr.ForeColor = Color.FromArgb( 1, 255, 0, 89 );
                    EventMgr.Text = "Duplicate Entry, aborting.";
                }
            }
        }

        private void StartUpSwitch_Click ( object sender, EventArgs e )
        {
            var Val = StartUpSwitch.Text;

            switch (Val)
            {
                case "Y\\N":
                    StartUpSwitch.Text = "On";
                    break;
                case "On":
                    StartUpSwitch.Text = "Off";
                    break;
                case "Off":
                    StartUpSwitch.Text = "On";
                    break;
            }
        }

        private void Launch_Click ( object sender, EventArgs e )
        {
            if (!File.Exists( PathText.Text )){
                EventMgr.ForeColor = Color.FromArgb( 1, 255, 0, 89 );
                EventMgr.Text = "Could not find an executable.";
                return;
            }

            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new()
            {
                WindowStyle = System.Diagnostics.ProcessWindowStyle.Normal,
                FileName = PathText.Text
            };
            process.StartInfo = startInfo;
            process.Start();
        }

        private void ApplicationsList_MouseClick ( object sender, MouseEventArgs e )
        {
            if (ApplicationsList.SelectedIndex > ApplicationsList.Items.Count) return;
            if (_applications.Count < 1) return;
            if (ApplicationsList.SelectedIndex > _applications.Count) return;
            if (ApplicationsList.SelectedIndex < 0) return;

            EventMgr.Text = "";

            ApplicationName.Text = _applications[ApplicationsList.SelectedIndex + _pageOffset].Name;
            PathText.Text = _applications[ApplicationsList.SelectedIndex + _pageOffset].Path;
            StartUpSwitch.Text = _applications[ApplicationsList.SelectedIndex + _pageOffset].LaunchOnStartup == true ? "On" : "Off";
        }

        private void ApplicationsList_DrawItem ( object sender, DrawItemEventArgs e )
        {
            if (e.Index < 0) return;
            if (( e.State & DrawItemState.Selected ) == DrawItemState.Selected)
                e = new DrawItemEventArgs(e.Graphics,
                                          e.Font,
                                          e.Bounds,
                                          e.Index,
                                          e.State ^ DrawItemState.Selected,
                                          e.ForeColor,
                                          Color.FromArgb(90,45,45,45) );
            e.DrawBackground();
            e.Graphics.DrawString( ApplicationsList.Items[e.Index].ToString(), e.Font, Brushes.DeepSkyBlue, e.Bounds, StringFormat.GenericDefault );
            e.DrawFocusRectangle();
        }

        private void RemoveEntry_MouseClick ( object sender, MouseEventArgs e )
        {
            if (ApplicationsList.SelectedIndex > ApplicationsList.Items.Count) return;
            if (_applications.Count < 1) return;
            if (ApplicationsList.SelectedIndex > _applications.Count) return;
            if (ApplicationsList.SelectedIndex < 0) return;

            _applications.RemoveAt(ApplicationsList.SelectedIndex + _pageOffset );
            ApplicationsList.Items.RemoveAt( ApplicationsList.SelectedIndex );

            ApplicationName.Text = "";
            PathText.Text = "";
            StartUpSwitch.Text = "Y\\N";

            GccConverter.Serialize( Application.StartupPath + "Data.gcc", _applications );
            ApplicationsList.Update();

            EventMgr.ForeColor = Color.FromArgb( 1, 52, 189, 235 );
            EventMgr.Text = "Removed The Entry";

            if (ApplicationsList.Items.Count == 0){
                PreviousPage_Click(new object(), new EventArgs());
            }
        }

        private void Save_MouseClick ( object sender, MouseEventArgs e )
        {
            if (_applications.Count < 1) return;
            if (ApplicationsList.SelectedIndex < 0) return;

            _applications[ApplicationsList.SelectedIndex + _pageOffset] = new()
            {
                Name = ApplicationName.Text,
                Path = PathText.Text,
                LaunchOnStartup = StartUpSwitch.Text == "On"
            };

            GccConverter.Serialize( Application.StartupPath + "Data.gcc", _applications );

            EventMgr.ForeColor = Color.FromArgb( 1, 52, 189, 235 );
            EventMgr.Text = "Updated The Entry";

            ApplicationsList.Items[ApplicationsList.SelectedIndex] = ApplicationName.Text;
        }

        private void LaunchStartups_Click ( object sender, EventArgs e )
        {
            int sum = 0;
            for (int i = 0; i < _applications.Count; i++)
            {
                if (File.Exists( _applications[i].Path )){
                    if (_applications[i].LaunchOnStartup){
                        System.Diagnostics.Process process = new();
                        System.Diagnostics.ProcessStartInfo startInfo = new()
                        {
                            WindowStyle = System.Diagnostics.ProcessWindowStyle.Normal,
                            FileName = _applications[i].Path
                        };
                        process.StartInfo = startInfo;
                        process.Start();
                        sum++;
                    }
                }
            }
            if (sum == 0){
                EventMgr.ForeColor = Color.FromArgb( 1, 255, 0, 89 );
                EventMgr.Text = "No StartUps found.";
            }else{
                EventMgr.ForeColor = Color.FromArgb( 1, 52, 189, 235 );
                EventMgr.Text = "Launched StartUps";
            }
        }

        private void GAMStartUp_Click ( object sender, EventArgs e )
        {
            var Val = GAMStartUp.Text;
            Microsoft.Win32.RegistryKey key;

            switch (Val)
            {
                case "GAM StartUp Y\\N":
                    GAMStartUp.Text = "GAM StartUp Y";
                    _gamStart = true;
                    key = Microsoft.Win32.Registry.CurrentUser.OpenSubKey( "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true );
                    key.SetValue( "GAM", Application.ExecutablePath );
                    GccConverter.Serialize( Application.StartupPath + "Settings.gcc", _gamStart );
                    break;
                case "GAM StartUp Y":
                    GAMStartUp.Text = "GAM StartUp N";
                    _gamStart = false;
                    key = Microsoft.Win32.Registry.CurrentUser.OpenSubKey( "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true );
                    key.DeleteValue( "GAM" );
                    GccConverter.Serialize( Application.StartupPath + "Settings.gcc", _gamStart );
                    break;
                case "GAM StartUp N":
                    GAMStartUp.Text = "GAM StartUp Y";
                    _gamStart = true;
                    key = Microsoft.Win32.Registry.CurrentUser.OpenSubKey( "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true );
                    key.SetValue( "GAM", Application.ExecutablePath );
                    GccConverter.Serialize( Application.StartupPath + "Settings.gcc", _gamStart );
                    break;
            }
        }

        private void NextPage_Click ( object sender, EventArgs e )
        {
            if (_pageOffset + 39 > _applications.Count)
                return;

            ApplicationsList.Items.Clear();
            int sum = 0;
            _pageOffset += 39;

            for (int i = _pageOffset; i < _applications.Count; i++)
            {
                if (sum < 39){
                    ApplicationsList.Items.Add( _applications[i].Name );
                    sum++;
                }else{
                    break;
                }
            }
        }

        private void PreviousPage_Click ( object sender, EventArgs e )
        {
            if (_pageOffset - 39 < 0)
                return;

            ApplicationsList.Items.Clear();
            int sum = 0;

            for (int i = _pageOffset - 39; i < _pageOffset; i++)
            {
                if (sum < 39){
                    ApplicationsList.Items.Add( _applications[i].Name );
                    sum++;
                }else{
                    break;
                }
            }
            _pageOffset -= 39;
        }
    }
}