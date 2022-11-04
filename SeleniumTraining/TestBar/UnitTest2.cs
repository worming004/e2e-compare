using System;
using System.Diagnostics;
using Xunit;

namespace TestBar
{
    public class UnitTest2
    {
        [Fact]
        public void Print()
        {
            var str = Environment.GetEnvironmentVariable("PATH");
        }

        [Fact]
        public void GetEnv()
        {
            using (Process process = new Process())
            {
                process.StartInfo.FileName = "uname";
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.RedirectStandardOutput = true;
                process.Start();
                process.WaitForExit(1000);
                var name = process.StandardOutput.ReadToEnd().ToLowerInvariant();
                Assert.Equal("linux\n", name);
            }
        }
    }
}