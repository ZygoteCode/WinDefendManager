using System.IO;
using System.Windows.Forms;

public class WinDefendControl
{
    public static void EnableWindowsDefender()
    {
        try
        {
            if (System.IO.File.Exists("EnableWD.bat"))
            {
                System.IO.File.Delete("EnableWD.bat");
            }
        }
        catch
        {
            MessageBox.Show("Please, ensure that the file 'EnableWD.bat' is not used by another process.", "WinDefendManager", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        System.IO.File.WriteAllText("EnableWD.bat", WinDefendManager.Properties.Resources.EnableWD);
        File.SetAttributes("EnableWD.bat", FileAttributes.Hidden | FileAttributes.ReadOnly);
        WindowsUtils.RunBatchFile("EnableWD.bat");

        while (true)
        {
            try
            {
                System.IO.File.Delete("EnableWD.bat");
                break;
            }
            catch
            {

            }
        }
    }

    public static void DisableWindowsDefender()
    {
        try
        {
            if (System.IO.File.Exists("DisableWD.bat"))
            {
                System.IO.File.Delete("DisableWD.bat");
            }
        }
        catch
        {
            MessageBox.Show("Please, ensure that the file 'DisableWD.bat' is not used by another process.", "WinDefendManager", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        System.IO.File.WriteAllText("DisableWD.bat", WinDefendManager.Properties.Resources.DisableWD);
        File.SetAttributes("DisableWD.bat", FileAttributes.Hidden | FileAttributes.ReadOnly);
        WindowsUtils.RunBatchFile("DisableWD.bat");

        while (true)
        {
            try
            {
                System.IO.File.Delete("DisableWD.bat");
                break;
            }
            catch
            {

            }
        }
    }
}