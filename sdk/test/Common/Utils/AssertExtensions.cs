﻿/*
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
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Text.RegularExpressions;
using System.Security.Cryptography;
using System.IO;
using Xunit;

namespace AWSSDK_DotNet.IntegrationTests.Utils
{
    public static class AssertExtensions
    {
        #region ExpectException
        public static T ExpectException<T>(Action action) where T : Exception
        {
            var exceptionType = typeof(T);
            return (T)ExpectException(action, exceptionType, (Action<string>)null);
        }

        public static Exception ExpectException(Action action)
        {
            return ExpectException(action, null, (Action<string>)null);
        }

        public static Exception ExpectException(Action action, Type exceptionType)
        {
            return ExpectException(action, exceptionType, (Action<string>)null);
        }

        public static Exception ExpectException(Action action, Type exceptionType, String expectedMessage)
        {
            Action<string> validateMessage = expectedMessage == null ? (Action<string>)null :
                (message) =>
                {
                    Assert.Equal(expectedMessage, message);
                };
            return ExpectException(action, exceptionType, validateMessage);
        }

        public static Exception ExpectException(Action action, Type exceptionType, Regex messageRegex)
        {
            Action<string> validateMessage = messageRegex == null ? (Action<string>)null :
                (message) =>
                {
                    Assert.True(messageRegex.IsMatch(message),
                        string.Format("Expected exception message <{0}> to match regular expression <{1}>", message, messageRegex));
                };
            return ExpectException(action, exceptionType, validateMessage);
        }

        public static Exception ExpectException(Action action, Type exceptionType, Action<string> validateMessage)
        {
            bool gotException = false;
            Exception exception = null;
            try
            {
                action();
            }
            catch (Exception e)
            {
                exception = e;

                if (exceptionType != null)
                {
                    Assert.True(exceptionType == e.GetType(), e.ToString());
                }

                if (validateMessage != null)
                {
                    validateMessage(e.Message);
                }
                gotException = true;
            }

            string message = (exceptionType == null) ?
                "Failed to get an exception." :
                String.Format("Failed to get expected exception: {0}", exceptionType.FullName);

            Assert.True(gotException, message);

            return exception;
        }
        #endregion

        /// <summary>
        /// Assert that the actual DateTime provided is equal to the expected DateTime provided, down to the second.
        /// </summary>
        /// <param name="expected"></param>
        /// <param name="actual"></param>
        public static void AssertDateTimesAreEqualToTheSecond(DateTime expected, DateTime actual)
        {
            Assert.Equal(expected.Kind, actual.Kind);
            Assert.Equal(expected.Year, actual.Year);
            Assert.Equal(expected.Month, actual.Month);
            Assert.Equal(expected.Day, actual.Day);
            Assert.Equal(expected.Hour, actual.Hour);
            Assert.Equal(expected.Minute, actual.Minute);
            Assert.Equal(expected.Second, actual.Second);
        }

        /// <summary>
        /// Checks if properties have been added, removed, or changed on a type since the previous run.
        /// The check works by comparing a hard-coded hash to the current hash of the type's property names.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="expectedHash"></param>
        /// <param name="notes"></param>
        public static void AssertPropertiesUnchanged(Type type, string expectedHash, string notes)
        {
            AssertStringListUnchanged(type.GetProperties().Select((p) => p.Name).ToList(), expectedHash,
                "The " + type.Name + " class has added, removed, or changed properties.", notes);
        }

        /// <summary>
        /// Checks if enumeration values have been added, removed, or changed on an enum since the previous run.
        /// The check works by comparing a hard-coded hash to the current hash of the enum's values' names.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="expectedHash"></param>
        /// <param name="notes"></param>
        public static void AssertEnumUnchanged(Type type, string expectedHash, string notes)
        {
            AssertStringListUnchanged(Enum.GetNames(type).ToList(), expectedHash,
                "The enumeration " + type.Name + " has added, removed, or changed values.", notes);
        }

        private static void AssertStringListUnchanged(List<string> list, string expectedHash, string whatChanged, string notes)
        {
            SHA256 provider = SHA256.Create();
            // make sure string to hash is repeatable
            list.Sort();
            var stringToHash = string.Join("::", list.ToArray());
            var actualHash = BitConverter.ToString(provider.ComputeHash(Encoding.Default.GetBytes(stringToHash))).Replace("-", "");

            Assert.True(expectedHash == actualHash, whatChanged + "  Please read the following notes and " +
                "make any necessary changes.  Once the changes have been made use the value " + actualHash + " as the new expectedHash.\n" +
                "NOTES:\n" + notes);
        }

        public static void AssertSourceCodeUnchanged(List<string> srcRelativeFilenames, string expectedHash, string message)
        {
            // find the src directory
            var sourceRoot = Directory.GetCurrentDirectory();
            while (sourceRoot != null && !sourceRoot.EndsWith("\\sdk"))
            {
                sourceRoot = Path.GetDirectoryName(sourceRoot);
            }
            Assert.True(sourceRoot!=null, "Unable to find the src directory to check for source file changes.");
            sourceRoot = Path.Combine(sourceRoot, "src");

            // calculate the hash of the files' contents
            StringBuilder sourceCodeSB = new StringBuilder();
            foreach (var srcRelativeFilename in srcRelativeFilenames)
            {
                sourceCodeSB.Append(File.ReadAllText(Path.Combine(sourceRoot, srcRelativeFilename)));
            }
            SHA256 provider = SHA256.Create();
            var actualHash = BitConverter.ToString(provider.ComputeHash(Encoding.Default.GetBytes(sourceCodeSB.ToString()))).Replace("-", "");

            // compare the hash to the expected hash
            StringBuilder messageBuilder = new StringBuilder();
            messageBuilder.AppendLine("One or more of the following source files has changed:");
            foreach (var sourceShortFilename in srcRelativeFilenames)
            {
                messageBuilder.AppendLine(sourceShortFilename);
            }
            messageBuilder.AppendLine("This requires manual testing.  Once the testing is complete use " + actualHash + " as expectedHash.");
            messageBuilder.AppendLine("Manual testing required:");
            messageBuilder.AppendLine(message);
            Assert.True(expectedHash == actualHash, messageBuilder.ToString());
        }

        /// <summary>
        /// Asserts that <paramref name="actual"/> contains every word from <paramref name="expected"/>
        /// and in the same order, but allows <paramref name="actual"/> to contain additional words.
        /// </summary>
        public static void AssertAreSameWithEmbellishments(string expected, string actual, StringComparison comparison = StringComparison.OrdinalIgnoreCase)
        {
            var expectedWords = 
                expected
                    .Split(' ')
                    // remove punctuation
                    .Select(s => new string(s.ToCharArray().Where(char.IsLetterOrDigit).ToArray()))
                    // remove empty elements
                    .Where(s => !string.IsNullOrEmpty(s))
                    .ToArray();

            var actualSlice = actual;
            for (var i = 0; i < expectedWords.Length; i++)
            {
                var index = actualSlice.IndexOf(expectedWords[i], comparison);

                Assert.False(index < 0, $"Failed to match word {i+1}: {expectedWords[i]}.  Expected:<{expected}>.  Actual:<{actual}>");

                actualSlice = actualSlice.Substring(expectedWords[i].Length + index, actualSlice.Length - index - expectedWords[i].Length);
            }
        }

        public static void UrlSuffixMatches(
            string expectedUrl, 
            Uri actualUri,
            StringComparison comparison = StringComparison.OrdinalIgnoreCase)
        {
            var actualUrl = actualUri.ToString();
            expectedUrl = expectedUrl.Trim();

            // cleanup trailing slash
            if (!expectedUrl.EndsWith("/") && actualUrl.EndsWith("/"))
                actualUrl = actualUrl.Substring(0, actualUrl.Length - 1);


            // expectedUrl could be templated, remove templating
            // ie {accountId field value}.s3-control.us-west-2.amazonaws.com 
            expectedUrl = Regex.Replace(expectedUrl, @"\{.*\}", "");

            Assert.True(actualUrl.EndsWith(expectedUrl, comparison), $"Expected <{actualUrl}> to end with <{expectedUrl}>.");
        }

        public static void ContainsHeaders(
            IDictionary<string, string> expectedHeaders, 
            IDictionary<string, string> actualHeaders, 
            StringComparison comparison = StringComparison.OrdinalIgnoreCase)
        {
            foreach (var expected in expectedHeaders)
            {
                // ignore templated headers
                // ie x-amz-account-id: "{accountId field value}"
                if (expected.Value.StartsWith("{"))
                    continue;

                var key = expected.Key.Trim();
                Assert.True(actualHeaders.ContainsKey(key), $"Expected to find Header {key}.  Found {string.Join(", ", actualHeaders.Keys)}");

                Assert.True(string.Equals(expected.Value, actualHeaders[key], comparison), $"Expected <{expected.Value}>. Actual <{actualHeaders[key]}>.");
            }
        }
    }
}
