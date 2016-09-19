using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.ConfigurationManagement.ApplicationManagement;

namespace Microsoft.ConfigurationManagement.ApplicationManagement
{
    class Program
    {
        public static void Main(string[] args)
        {

            if (args.Length != 2)
            {
                Console.WriteLine("Usage: Create-Cmdtx pathtocmdtxfolder c:\\temp\\rdp.cmdtx");
            }
            else
            {
                cmdtxcreator temp = new cmdtxcreator();
                temp.CreateDeploymentTypeExtensionFile(args[0], args[1]);
            }
        }



    }
    class cmdtxcreator
    {
        // Summarizes progress from CreateExtension method to a log file or the console.
        // <param name="summaryText">Summary text to be presented</param>
        public void Summarize(string summaryText)
        {
            System.Console.WriteLine(summaryText);

            return;
        }

        // Creates a new Deployment Type Extension using the specified source path
        // <param name="sourcePath">Source path used to create the Deployment Type Extension</param>
        // <param name="deploymentTypeExtensionFilePath">Resulting Deployment Type Extension file</param>
        public void CreateDeploymentTypeExtensionFile(string sourcePath, string deploymentTypeExtensionFilePath)
        {
            DeploymentTypeExtender.CreateExtension(sourcePath, deploymentTypeExtensionFilePath, this.Summarize);

            return;
        }
    
    }
}
