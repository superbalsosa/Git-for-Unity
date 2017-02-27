using System;
using System.IO;
using GitHub.Unity;
using Ionic.Zip;
using NUnit.Framework;

namespace IntegrationTests
{
    class BaseGitIntegrationTest: BaseIntegrationTest
    {
        private static string SolutionDirectory => TestContext.CurrentContext.TestDirectory;

        private static string TestZipFilePath => Path.Combine(SolutionDirectory, "IOTestsRepo.zip");

        protected override void OnSetup()
        {
            base.OnSetup();

            using (var zipFile = new ZipFile(TestZipFilePath))
            {
                zipFile.ExtractAll(TestBasePath.ToString(), ExtractExistingFileAction.OverwriteSilently);
            }
        }
    }
}