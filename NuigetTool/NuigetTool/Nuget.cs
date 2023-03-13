using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaGet.Protocol.Models;
using BaGet.Protocol;
using DevExpress.XtraEditors;
using NuGet.Versioning;

namespace NuigetTool
{
    internal class Nuget
    {
        private async Task DownloadAsync()
        {
            var result = this.grvPackages.GetFocusedRow() as SearchResult;
            var version = this.grvVersions.GetFocusedRow() as SearchResultVersion;
            var packageVersion = new NuGetVersion(version.Version);
            var client = new NuGetClient("https://api.nuget.org/v3/index.json");
            var downloadPath = ConfigurationManager.AppSettings["DownloadPath"];

            var isExists = await client.ExistsAsync(result.PackageId, packageVersion);

            if (isExists)
            {
                var packagePath = Path.Combine(downloadPath, $"{result.PackageId}.{version}.nupkg");

                if (!Directory.Exists(downloadPath))
                    Directory.CreateDirectory(downloadPath);

                if (File.Exists(packagePath))
                {
                    WriteLog($"Package [{packageId} {version}] already exists...");
                    return;
                }


                WriteLog($"Start Download package [{packageId} {version}] ...");

                var isExists = Task.Factory.StartNew(() => client.ExistsAsync(packageId, packageVersion).Result).Result;

                if (isExists)
                {
                    var packageStream = Task.Factory.StartNew(() => client.DownloadPackageAsync(packageId, packageVersion).Result).Result;

                    using (packageStream)
                    {
                        using (var fs = new FileStream(packagePath, FileMode.OpenOrCreate, FileAccess.ReadWrite))
                        {
                            packageStream.CopyTo(fs);
                            fs.Close();
                            WriteLog($"Downloaded package [{packageId} {version}] ...");
                        }
                    }
                }
                else
                {
                    WriteLog($"NotFound package [{packageId} {version}] ...");
                }
            }
            else
            {
                XtraMessageBox.Show("Not Found");
            }
        }
    }
}
