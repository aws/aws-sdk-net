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
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

namespace AWSSDK.UnitTests
{
    [TestClass]
    public class IniFileTest
    {
        private const string ErrorFormat = "Line {0}:<{1}> in file .* does not contain a section, property or comment.";
        private const string InvalidIniFile = "@#^@#@%@2345";

        private static readonly string ValidSection1 = new StringBuilder()
            .AppendLine("[section]")
            .AppendLine("property=value")
            .ToString();

        private static readonly string ValidSection2 = new StringBuilder()
            .AppendLine("[section2]")
            .AppendLine()
            .AppendLine("; seimcolon comment")
            .AppendLine("# hash comment")
            .AppendLine("property=value")
            .ToString();

        private static readonly string ValidSection3 = new StringBuilder()
            .AppendLine("[section3]")
            .AppendLine()
            .AppendLine("; seimcolon comment")
            .AppendLine("# hash comment")
            .AppendLine("property=value")
            .ToString();

        private static readonly string DuplicatePropertySection = new StringBuilder()
            .AppendLine("[section]")
            .AppendLine("property=value")
            .AppendLine("property=value")
            .ToString();

        private static readonly string DuplicateCommentPropertySection = new StringBuilder()
            .AppendLine("[section]")
            .AppendLine("#property=value")
            .AppendLine("#property=value")
            .ToString();

        [TestMethod]
        public void ReadInvalid()
        {
            AssertExtensions.ExpectException(() =>
            {
                using(var tester = new IniFileTester(InvalidIniFile))
                {
                }
            }, typeof(InvalidDataException), new Regex(String.Format(ErrorFormat, 1, Regex.Escape(InvalidIniFile))));
        }

        [TestMethod]
        public void SectionExistsFalse()
        {
            using (var tester = new IniFileTester(ValidSection1))
            {
                Assert.IsFalse(tester.TestFile.SectionExists("blah"));
            }
        }

        [TestMethod]
        public void SectionExistsTrue()
        {
            using (var tester = new IniFileTester(ValidSection1))
            {
                Assert.IsTrue(tester.TestFile.SectionExists("section"));
            }
        }

        [TestMethod]
        public void TryGetSection()
        {
            using (var tester = new IniFileTester(ValidSection1))
            {
                tester.AssertSection("section", "property", "value");
            }
        }

        [TestMethod]
        public void TryGetSectionCommentsAreNotProperties()
        {
            using (var tester = new IniFileTester(DuplicateCommentPropertySection))
            {
                Dictionary<string, string> properties;
                Assert.IsTrue(tester.TestFile.TryGetSection("section", out properties));
                Assert.AreEqual(0, properties.Count);
            }
        }

        [TestMethod]
        public void TryGetSectionDuplicateProperty()
        {
            using (var tester = new IniFileTester(DuplicatePropertySection))
            {
                Dictionary<string, string> properties;
                Assert.IsFalse(tester.TestFile.TryGetSection("section", out properties));
            }
        }

        [TestMethod]
        public void TryGetSectionDuplicatePropertyRegex()
        {
            using (var tester = new IniFileTester(DuplicatePropertySection))
            {
                Dictionary<string, string> properties;
                Assert.IsFalse(tester.TestFile.TryGetSection(new Regex("ectio"), out properties));
            }
        }

        [TestMethod]
        public void DeleteSection()
        {
            using (var tester = new IniFileTester(ValidSection1))
            {
                tester.TestFile.DeleteSection("section");
                Assert.IsFalse(tester.TestFile.SectionExists("section"));
                tester.TestFile.Persist();
                tester.AssertFileContents(String.Empty);
            }
        }

        [TestMethod]
        public void DeleteSection_Middle()
        {
            using (var tester = new IniFileTester(ValidSection1 + ValidSection2 + ValidSection3))
            {
                tester.TestFile.DeleteSection("section2");
                Assert.IsFalse(tester.TestFile.SectionExists("section2"));
                tester.TestFile.Persist();
                tester.AssertFileContents(ValidSection1 + ValidSection3);
            }
        }

        [TestMethod]
        public void EnsureSectionExists_AlreadyExists()
        {
            using (var tester = new IniFileTester(ValidSection1))
            {
                tester.TestFile.EnsureSectionExists("section");
                tester.AssertSection("section", "property", "value");
                tester.TestFile.Persist();
                tester.AssertFileContents(ValidSection1);
            }
        }

        [TestMethod]
        public void EnsureSectionExists_New()
        {
            using (var tester = new IniFileTester(ValidSection1))
            {
                tester.TestFile.EnsureSectionExists("section2");
                tester.AssertSection("section2");
                tester.TestFile.Persist();
                tester.AssertFileContents(ValidSection1 + "[section2]");
            }
        }

        [TestMethod]
        public void AddProperty()
        {
            var properties = new SortedDictionary<string, string>();
            properties.Add("property", "value");
            properties.Add("property2", "value2");

            using (var tester = new IniFileTester(ValidSection1))
            {
                tester.TestFile.EditSection("section", properties);
                tester.AssertSection("section", "property", "value", "property2", "value2");
                tester.TestFile.Persist();
                tester.AssertFileContents(ValidSection1 + "property2=value2");
            }
        }

        [TestMethod]
        public void EditProperty()
        {
            var properties = new SortedDictionary<string, string>();
            properties.Add("property", "value2");

            using (var tester = new IniFileTester(ValidSection1))
            {
                tester.TestFile.EditSection("section", properties);
                tester.AssertSection("section", "property", "value2");
                tester.TestFile.Persist();
                tester.AssertFileContents("[section]" + Environment.NewLine + "property=value2");
            }
        }

        [TestMethod]
        public void AddAndEditProperties()
        {
            var properties = new SortedDictionary<string, string>();
            properties.Add("property", "value3");
            properties.Add("property2", "value2");

            using (var tester = new IniFileTester(ValidSection1))
            {
                tester.TestFile.EditSection("section", properties);
                tester.AssertSection("section", "property", "value3", "property2", "value2");
                tester.TestFile.Persist();
                tester.AssertFileContents("[section]" + Environment.NewLine +
                    "property=value3" + Environment.NewLine +
                    "property2=value2");
            }
        }

        [TestMethod]
        public void DeleteProperty()
        {
            var properties = new SortedDictionary<string, string>();
            properties.Add("property", null);

            using (var tester = new IniFileTester(ValidSection1))
            {
                tester.TestFile.EditSection("section", properties);
                tester.AssertSection("section");
                tester.TestFile.Persist();
                tester.AssertFileContents("[section]" + Environment.NewLine);
            }
        }

        private class IniFileTester : IDisposable
        {
            private string FilePath { get; set; }
            public IniFile TestFile { get; private set; }

            public IniFileTester(string fileContents)
            {
                FilePath = Path.GetTempFileName();
                File.WriteAllText(FilePath, fileContents);
                TestFile = new IniFile(FilePath);
            }

            public IniFileTester(bool createFile = false)
            {
                if (createFile)
                {
                    FilePath = Path.GetTempFileName();
                }
                else
                {
                    FilePath = Path.Combine(Path.GetTempPath(), Path.GetRandomFileName());
                }
                TestFile = new IniFile(FilePath);
            }

            public void AssertSection(string expectedSectionName, params string[] expectedProperties)
            {
                expectedProperties = expectedProperties ?? new string[0];
                Dictionary<string, string> properties;

                Assert.IsTrue(TestFile.TryGetSection(expectedSectionName, out properties),
                    string.Format("Unable to get section '{0}'", expectedSectionName));

                Assert.IsTrue(expectedProperties.Length % 2 == 0,
                    "expectedProperties must have an even number of elements");

                Assert.AreEqual(expectedProperties.Length / 2, properties.Count,
                    "The number of properties is incorrect");

                for (int i = 0; i < expectedProperties.Length; i += 2)
                {
                    Assert.IsTrue(properties.ContainsKey(expectedProperties[i]),
                        string.Format("The section properties doesn't contain the key '{0}'", expectedProperties[i]));
                    Assert.AreEqual(expectedProperties[i + 1], properties[expectedProperties[i]]);
                }
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
