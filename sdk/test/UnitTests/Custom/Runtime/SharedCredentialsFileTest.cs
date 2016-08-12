/*
 * Copyright 2016 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using Amazon.Runtime.Internal.Auth;
using AWSSDK_DotNet.IntegrationTests.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AWSSDK.UnitTests
{
    [TestClass]
    public class SharedCredentialsFileTest
    {
        private const string FileChangedMessageFormat = "Cannot write to credentials file {0}.  The file has been modified since it was last read.";
        private const string FileLockedMessageFormat = "The process cannot access the file '{0}' because it is being used by another process.";
        private const string InvalidSectionMessageFormat = "Credential profile [{0}] does not contain valid access and/or secret key materials.";

        private static readonly string BasicProfileText =
            "[basic_profile]" + Environment.NewLine +
            "aws_access_key_id=basic_aws_access_key_id" + Environment.NewLine +
            "aws_secret_access_key=basic_aws_secret_access_key" + Environment.NewLine;

        private static readonly string SessionTokenProfileText =
            "[token_profile]" + Environment.NewLine +
            "aws_access_key_id=token_aws_access_key_id" + Environment.NewLine +
            "aws_secret_access_key=token_aws_secret_access_key" + Environment.NewLine +
            "aws_session_token=token_aws_session_token" + Environment.NewLine;

        private readonly string ShortProfileText =
            "[s]" + Environment.NewLine +
            "aws_access_key_id=s" + Environment.NewLine +
            "aws_secret_access_key=s" + Environment.NewLine;

        private static readonly string InvalidProfileText =
            "[invalid]" + Environment.NewLine;

        private static readonly CredentialsSection BasicProfileSection =
            new CredentialsSection("basic_profile")
            {
                AccessKey = "basic_aws_access_key_id",
                SecretKey = "basic_aws_secret_access_key"
            };

        private static readonly CredentialsSection SessionTokenProfileSection =
            new CredentialsSection("token_profile")
            {
                AccessKey = "token_aws_access_key_id",
                SecretKey = "token_aws_secret_access_key",
                Token = "token_aws_session_token"
            };

        private static readonly CredentialsSection ShortProfileSection =
            new CredentialsSection("s")
            {
                AccessKey = "s",
                SecretKey = "s"
            };

        private static readonly CredentialsSection InvalidProfileSection =
            new CredentialsSection("invalid");

        [TestMethod]
        public void DoesNotExist()
        {
            using (var tester = new TempCredentialsFileTester())
            {
                tester.CredentialsFile.Persist();
                tester.AssertFileContents(String.Empty);
            }
        }

        [TestMethod]
        public void Empty()
        {
            using (var tester = new TempCredentialsFileTester(true))
            {
                tester.CredentialsFile.Persist();
                tester.AssertFileContents(String.Empty);
            }
        }

        [TestMethod]
        public void OneNew()
        {
            using (var tester = new TempCredentialsFileTester())
            {
                tester.CredentialsFile.AddOrUpdateSection(BasicProfileSection);
                tester.CredentialsFile.Persist();
                tester.AssertFileContents(BasicProfileText);
            }
        }

        [TestMethod]
        public void TwoPersists()
        {
            using (var tester = new TempCredentialsFileTester())
            {
                tester.CredentialsFile.AddOrUpdateSection(BasicProfileSection);
                tester.CredentialsFile.Persist();

                tester.CredentialsFile.AddOrUpdateSection(ShortProfileSection);
                tester.CredentialsFile.Persist();

                tester.AssertFileContents(BasicProfileText + ShortProfileText);
            }
        }

        [TestMethod]
        public void ProperTruncation()
        {
            using (var tester = new TempCredentialsFileTester())
            {
                tester.CredentialsFile.AddOrUpdateSection(BasicProfileSection);
                tester.CredentialsFile.Persist();
                var basicLength = File.ReadAllText(tester.CredentialsFile.FilePath).Length;

                tester.CredentialsFile.DeleteSection(BasicProfileSection.ProfileName);
                tester.CredentialsFile.AddOrUpdateSection(ShortProfileSection);
                tester.CredentialsFile.Persist();
                var shortLength = File.ReadAllText(tester.CredentialsFile.FilePath).Length;

                Assert.AreEqual(BasicProfileText.Length, basicLength);
                Assert.AreEqual(ShortProfileText.Length, shortLength);
                Assert.IsTrue(shortLength < basicLength);
            }
        }

        [TestMethod]
        public void AddTokenProfile()
        {
            using (var tester = new TempCredentialsFileTester())
            {
                tester.CredentialsFile.AddOrUpdateSection(SessionTokenProfileSection);
                tester.CredentialsFile.Persist();
                tester.AssertFileContents(SessionTokenProfileText);
            }
        }

        [TestMethod]
        public void ParseTokenProfile()
        {
            using (var tester = new TempCredentialsFileTester(SessionTokenProfileText))
            {
                Assert.AreEqual(1, tester.CredentialsFile.Count);
                var tokenSection = tester.CredentialsFile[SessionTokenProfileSection.ProfileName];
                Assert.IsNotNull(tokenSection);
                Assert.AreEqual(tokenSection.AccessKey, SessionTokenProfileSection.AccessKey);
                Assert.AreEqual(tokenSection.SecretKey, SessionTokenProfileSection.SecretKey);
                Assert.AreEqual(tokenSection.Token, SessionTokenProfileSection.Token);
            }
        }

        [TestMethod]
        public void AddInvalid()
        {
            using (var tester = new TempCredentialsFileTester())
            {
                AssertExtensions.ExpectException(() =>
                {
                    tester.CredentialsFile.AddOrUpdateSection(InvalidProfileSection);
                }, typeof(InvalidDataException), String.Format(InvalidSectionMessageFormat, InvalidProfileSection.ProfileName));
            }
        }

        [TestMethod]
        public void ParseInvalid()
        {
            var filePath = Path.Combine(Path.GetTempPath(), Path.GetRandomFileName());
            try
            {
                File.WriteAllText(filePath, InvalidProfileText);
                AssertExtensions.ExpectException(() =>
                {
                    var credentialsFile = new SharedCredentialsFile(filePath);
                }, typeof(InvalidDataException), String.Format(InvalidSectionMessageFormat, InvalidProfileSection.ProfileName));
            }
            finally
            {
                File.Delete(filePath);
            }
        }

        [TestMethod]
        public void FileChanged()
        {
            using (var tester = new TempCredentialsFileTester())
            {
                tester.CredentialsFile.AddOrUpdateSection(BasicProfileSection);
                using (var streamWriter = File.AppendText(tester.CredentialsFile.FilePath))
                {
                    streamWriter.Write("changed");
                }
                AssertExtensions.ExpectException(() => {
                    tester.CredentialsFile.Persist();
                }, typeof(IOException), string.Format(FileChangedMessageFormat, tester.CredentialsFile.FilePath));
            }
        }

        [TestMethod]
        public void FileLockedByAnotherProcess()
        {
            using (var tester = new TempCredentialsFileTester())
            {
                tester.CredentialsFile.AddOrUpdateSection(BasicProfileSection);
                using (var streamWriter = File.AppendText(tester.CredentialsFile.FilePath))
                {
                    AssertExtensions.ExpectException(() => {
                        tester.CredentialsFile.Persist();
                    }, typeof(IOException), string.Format(FileLockedMessageFormat, tester.CredentialsFile.FilePath));
                }
            }
        }

        /// <summary>
        /// This test needs to be run manually since it relies on a race condition and a manual code change.
        /// It's been run as part of development but it won't be run in the normal build process.
        ///
        /// This test makes sure that the CredentialsFile.Persist() method locks the file properly while it's being written.
        /// To run this test:
        /// 1.  temporarily add System.Threading.Thread.Sleep(5000); to CredentialsFile.Persist() just after the file is opened
        /// 2.  uncomment the [TestMethod] attribute on this method
        /// 3.  run the test
        /// 4.  REVERT YOUR CHANGES FROM STEPS 1 AND 2
        /// </summary>
        //[TestMethod]
        public void FileLockedByThisProcess()
        {
            using (var tester = new TempCredentialsFileTester(true))
            {
                // start the persist thread
                Thread thread = new Thread(new ThreadStart(() => { tester.CredentialsFile.Persist(); }));
                thread.Start();

                // give it time to open the file
                Thread.Sleep(2000);

                // try something that requires minimal access to the file and make sure the correct exception is thrown
                AssertExtensions.ExpectException(() =>
                {
                    using (File.Open(tester.CredentialsFile.FilePath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                    {
                    }
                }, typeof(IOException), string.Format(FileLockedMessageFormat, tester.CredentialsFile.FilePath));

                // wait for the persist to complete
                thread.Join();
            }
        }

        private class TempCredentialsFileTester : IDisposable
        {
            private string FilePath { get; set; }
            public SharedCredentialsFile CredentialsFile { get; private set; }

            public TempCredentialsFileTester(string fileContents)
            {
                FilePath = Path.GetTempFileName();
                File.WriteAllText(FilePath, fileContents);
                CredentialsFile = new SharedCredentialsFile(FilePath);
            }

            public TempCredentialsFileTester(bool createFile = false)
            {
                if (createFile)
                {
                    FilePath = Path.GetTempFileName();
                }
                else
                {
                    FilePath = Path.Combine(Path.GetTempPath(), Path.GetRandomFileName());
                }
                CredentialsFile = new SharedCredentialsFile(FilePath);
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
