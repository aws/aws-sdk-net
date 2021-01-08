/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
 *
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 *
 *  http://aws.amazon.com/apache2.0
 *
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */
using Amazon.Runtime.Internal.Util;
using AWSSDK_DotNet.IntegrationTests.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using System.Threading;


namespace AWSSDK.UnitTests
{
    [TestClass]
    public class OptimisticLockedFileTest
    {
        private const string FileChangedMessageFormat = "Cannot write to file {0}. The file has been modified since it was last read.";
        private const string FileLockedMessageFormat = "The process cannot access the file '{0}' because it is being used by another process.";

        private const string UnixNewLine = "\r";
        private const string WindowsNewLine = "\r\n";

        private const string Line = "hello";
        private const string UnixLine = Line + UnixNewLine;
        private const string WindowsLine = Line + WindowsNewLine;

        [TestMethod]
        public void ReadUnixNewLine()
        {
            using (var tester = new OptimisticLockedTextFileTester(UnixNewLine))
            {
                tester.AssertLines(UnixNewLine);
            }
        }

        [TestMethod]
        public void ReadWindowsNewLine()
        {
            using (var tester = new OptimisticLockedTextFileTester(WindowsNewLine))
            {
                tester.AssertLines(WindowsNewLine);
            }
        }

        [TestMethod]
        public void ReadMixedNewLines1()
        {
            using (var tester = new OptimisticLockedTextFileTester(WindowsNewLine + UnixNewLine))
            {
                tester.AssertLines(WindowsNewLine, UnixNewLine);
            }
        }

        [TestMethod]
        public void ReadMixedNewLines2()
        {
            using (var tester = new OptimisticLockedTextFileTester(UnixNewLine + WindowsNewLine))
            {
                tester.AssertLines(UnixNewLine, WindowsNewLine);
            }
        }

        [TestMethod]
        public void ReadLine()
        {
            using (var tester = new OptimisticLockedTextFileTester(Line))
            {
                tester.AssertLines(Line);
            }
        }

        [TestMethod]
        public void ReadUnixLine()
        {
            using (var tester = new OptimisticLockedTextFileTester(UnixLine))
            {
                tester.AssertLines(UnixLine);
            }
        }

        [TestMethod]
        public void ReadWindowsLine()
        {
            using (var tester = new OptimisticLockedTextFileTester(WindowsLine))
            {
                tester.AssertLines(WindowsLine);
            }
        }


        [TestMethod]
        public void ReadMixedlines1()
        {
            using (var tester = new OptimisticLockedTextFileTester(UnixLine + Line))
            {
                tester.AssertLines(UnixLine, Line);
            }
        }

        [TestMethod]
        public void ReadMixedlines2()
        {
            using (var tester = new OptimisticLockedTextFileTester(WindowsLine + Line))
            {
                tester.AssertLines(WindowsLine, Line);
            }
        }

        [TestMethod]
        public void ReadMixedlines3()
        {
            using (var tester = new OptimisticLockedTextFileTester(Line + UnixLine))
            {
                tester.AssertLines(Line + UnixLine);
            }
        }

        [TestMethod]
        public void ReadMixedlines4()
        {
            using (var tester = new OptimisticLockedTextFileTester(Line + WindowsLine))
            {
                tester.AssertLines(Line + WindowsLine);
            }
        }

        [TestMethod]
        public void PersistNewFile()
        {
            using (var tester = new OptimisticLockedTextFileTester())
            {
                tester.TextFile.Persist();
                tester.AssertFileContents(String.Empty);
            }
        }

        [TestMethod]
        public void PersistEmpty()
        {
            using (var tester = new OptimisticLockedTextFileTester(true))
            {
                tester.TextFile.Persist();
                tester.AssertFileContents(String.Empty);
            }
        }

        [TestMethod]
        public void PersistLine()
        {
            using (var tester = new OptimisticLockedTextFileTester(true))
            {
                tester.AssertPersist(Line, Line);
            }
        }

        [TestMethod]
        public void PersistAddsLineEnding()
        {
            using (var tester = new OptimisticLockedTextFileTester(true))
            {
                tester.AssertPersist(Line + Environment.NewLine + Line, Line, Line);
            }
        }

        [TestMethod]
        public void PersistTwice()
        {
            using (var tester = new OptimisticLockedTextFileTester(true))
            {
                tester.AssertPersist(WindowsLine, WindowsLine);
                tester.AssertPersist(WindowsLine + WindowsLine, WindowsLine);
            }
        }

        [TestMethod]
        public void ProperTruncation()
        {
            using (var tester = new OptimisticLockedTextFileTester())
            {
                tester.AssertPersist(UnixLine + UnixLine, UnixLine, UnixLine);
                tester.TextFile.Lines.RemoveAt(0);
                tester.TextFile.Persist();
                tester.AssertFileContents(UnixLine);
            }
        }

        [TestMethod]
        public void FileChanged()
        {
            using (var tester = new OptimisticLockedTextFileTester(true))
            {
                tester.TextFile.Lines.Add(Line);
                using (var streamWriter = File.AppendText(tester.TextFile.FilePath))
                {
                    streamWriter.Write("changed");
                }
                AssertExtensions.ExpectException(() =>
                {
                    tester.TextFile.Persist();
                }, typeof(IOException), string.Format(FileChangedMessageFormat, tester.TextFile.FilePath));
            }
        }

        [TestMethod]
        public void FileLockedByAnotherProcess()
        {
            using (var tester = new OptimisticLockedTextFileTester())
            {
                tester.TextFile.Lines.Add(Line);
                using (var streamWriter = File.AppendText(tester.TextFile.FilePath))
                {
                    AssertExtensions.ExpectException(() =>
                    {
                        tester.TextFile.Persist();
                    }, typeof(IOException), string.Format(FileLockedMessageFormat, tester.TextFile.FilePath));
                }
            }
        }

        /// <summary>
        /// This test needs to be run manually since it relies on a race condition and a manual code change.
        /// It's been run as part of development but it won't be run in the normal build process.
        ///
        /// This test makes sure that the OptimisticLockedTextFile.Persist() method locks the file properly while it's being written.
        /// To run this test:
        /// 1.  temporarily add System.Threading.Thread.Sleep(5000); to OptimisticLockedTextFile.Persist() just after the file is opened
        /// 2.  uncomment the [TestMethod] attribute on this method
        /// 3.  run the test
        /// 4.  REVERT YOUR CHANGES FROM STEPS 1 AND 2
        /// </summary>
        //[TestMethod]
        public void FileLockedByThisProcess()
        {
            using (var tester = new OptimisticLockedTextFileTester(true))
            {
                // start the persist thread
                Thread thread = new Thread(new ThreadStart(() => { tester.TextFile.Persist(); }));
                thread.Start();

                // give it time to open the file
                Thread.Sleep(2000);

                // try something that requires minimal access to the file and make sure the correct exception is thrown
                AssertExtensions.ExpectException(() =>
                {
                    using (File.Open(tester.TextFile.FilePath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                    {
                    }
                }, typeof(IOException), string.Format(FileLockedMessageFormat, tester.TextFile.FilePath));

                // wait for the persist to complete
                thread.Join();
            }
        }

        private class OptimisticLockedTextFileTester : IDisposable
        {
            private string FilePath { get; set; }
            public OptimisticLockedTextFile TextFile { get; private set; }

            public OptimisticLockedTextFileTester(string fileContents)
            {
                FilePath = Path.GetTempFileName();
                File.WriteAllText(FilePath, fileContents);
                TextFile = new OptimisticLockedTextFile(FilePath);
            }

            public OptimisticLockedTextFileTester(bool createFile = false)
            {
                if (createFile)
                {
                    FilePath = Path.GetTempFileName();
                }
                else
                {
                    FilePath = Path.Combine(Path.GetTempPath(), Path.GetRandomFileName());
                }
                TextFile = new OptimisticLockedTextFile(FilePath);
            }

            public void AssertLines(params string[] expectedLines)
            {
                Assert.AreEqual(expectedLines.Length, TextFile.Lines.Count);
                for (int i = 0; i < expectedLines.Length; i++)
                {
                    Assert.AreEqual(expectedLines[i], TextFile.Lines[i]);
                }
            }

            internal void AssertPersist(string expectedContents, params string[] lines)
            {
                foreach (var line in lines)
                {
                    TextFile.Lines.Add(line);
                }
                TextFile.Persist();
                AssertFileContents(expectedContents);
            }

            public void AssertFileContents(string expectedContents)
            {
                Assert.AreEqual(expectedContents, File.ReadAllText(FilePath));
            }

            public void Dispose()
            {
                File.Delete(FilePath);
            }
        }
    }
}

