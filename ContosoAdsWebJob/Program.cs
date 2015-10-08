using ContosoAdsCommon;
using Microsoft.Azure.WebJobs;
using Microsoft.WindowsAzure;
using Microsoft.WindowsAzure.Storage.Blob;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContosoAdsWebJob
{
    class Program
    {
        static void Main(string[] args)
        {
            var _storageConn = ConfigurationManager
                .ConnectionStrings["AzureWebJobsStorage"].ConnectionString;

            var _dashboardConn = ConfigurationManager
                .ConnectionStrings["AzureWebJobsDashboard"].ConnectionString;

            JobHostConfiguration config = new JobHostConfiguration();
            config.StorageConnectionString = _storageConn;
            config.DashboardConnectionString = _dashboardConn;

            JobHost host = new JobHost();
            host.RunAndBlock();
        }
    }
}
