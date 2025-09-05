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

using System;
using System.Linq;
using Amazon.Runtime;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK.UnitTests
{
    [TestClass]
    public class AuthSchemePreferenceTests
    {
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        [TestMethod]
        public void Constructor_ValidSchemes_CreatesInstance()
        {
            // Arrange
            var schemes = new[] { "sigv4", "sigv4a", "httpBearerAuth" };

            // Act
            var preference = new AuthSchemePreference(schemes);

            // Assert
            Assert.AreEqual(3, preference.PreferenceList.Count);
            Assert.AreEqual("sigv4", preference.PreferenceList[0]);
            Assert.AreEqual("sigv4a", preference.PreferenceList[1]);
            Assert.AreEqual("httpBearerAuth", preference.PreferenceList[2]);
        }

        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Constructor_NullSchemes_ThrowsArgumentNullException()
        {
            // Act & Assert
            new AuthSchemePreference(null);
        }

        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        [TestMethod]
        public void Constructor_SchemesWithWhitespace_TrimsWhitespace()
        {
            // Arrange
            var schemes = new[] { "  sigv4  ", "\tsigv4a\t", " httpBearerAuth " };

            // Act
            var preference = new AuthSchemePreference(schemes);

            // Assert
            Assert.AreEqual(3, preference.PreferenceList.Count);
            Assert.AreEqual("sigv4", preference.PreferenceList[0]);
            Assert.AreEqual("sigv4a", preference.PreferenceList[1]);
            Assert.AreEqual("httpBearerAuth", preference.PreferenceList[2]);
        }

        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        [TestMethod]
        public void Parse_ValidCommaSeparatedString_CreatesPreference()
        {
            // Arrange
            var commaSeparatedSchemes = "sigv4,sigv4a,httpBearerAuth";

            // Act
            var preference = AuthSchemePreference.Parse(commaSeparatedSchemes);

            // Assert
            Assert.AreEqual(3, preference.PreferenceList.Count);
            Assert.AreEqual("sigv4", preference.PreferenceList[0]);
            Assert.AreEqual("sigv4a", preference.PreferenceList[1]);
            Assert.AreEqual("httpBearerAuth", preference.PreferenceList[2]);
        }

        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        [TestMethod]
        public void Parse_StringWithWhitespace_TrimsWhitespace()
        {
            // Arrange
            var commaSeparatedSchemes = "  sigv4  , \tsigv4a\t , httpBearerAuth ";

            // Act
            var preference = AuthSchemePreference.Parse(commaSeparatedSchemes);

            // Assert
            Assert.AreEqual(3, preference.PreferenceList.Count);
            Assert.AreEqual("sigv4", preference.PreferenceList[0]);
            Assert.AreEqual("sigv4a", preference.PreferenceList[1]);
            Assert.AreEqual("httpBearerAuth", preference.PreferenceList[2]);
        }

        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Parse_NullString_ThrowsArgumentNullException()
        {
            // Act & Assert
            AuthSchemePreference.Parse(null);
        }

        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        [TestMethod]
        public void Parse_EmptyString_CreatesEmptyPreference()
        {
            // Act
            var preference = AuthSchemePreference.Parse("");

            // Assert
            Assert.AreEqual(0, preference.PreferenceList.Count);
            Assert.IsTrue(preference.IsEmpty);
        }

        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        [TestMethod]
        public void Contains_ExistingScheme_ReturnsTrue()
        {
            // Arrange
            var preference = new AuthSchemePreference(new[] { "sigv4", "sigv4a", "httpBearerAuth" });

            // Act & Assert
            Assert.IsTrue(preference.Contains("sigv4"));
            Assert.IsTrue(preference.Contains("sigv4a"));
            Assert.IsTrue(preference.Contains("httpBearerAuth"));
        }

        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        [TestMethod]
        public void Contains_CaseSensitive_ReturnsCorrectResult()
        {
            // Arrange - Per Multi-auth spec section 3.5.2: auth scheme names are case-sensitive
            var preference = new AuthSchemePreference(new[] { "sigv4", "SigV4a", "HttpBearerAuth" });

            // Act & Assert - Only exact case matches should return true
            Assert.IsTrue(preference.Contains("sigv4"));
            Assert.IsTrue(preference.Contains("SigV4a"));
            Assert.IsTrue(preference.Contains("HttpBearerAuth"));
            // Incorrect case should return false
            Assert.IsFalse(preference.Contains("SIGV4"));
            Assert.IsFalse(preference.Contains("sigv4a"));
            Assert.IsFalse(preference.Contains("httpbearerauth"));
        }

        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        [TestMethod]
        public void IndexOf_ExistingScheme_ReturnsCorrectIndex()
        {
            // Arrange
            var preference = new AuthSchemePreference(new[] { "sigv4", "sigv4a", "httpBearerAuth" });

            // Act & Assert
            Assert.AreEqual(0, preference.IndexOf("sigv4"));
            Assert.AreEqual(1, preference.IndexOf("sigv4a"));
            Assert.AreEqual(2, preference.IndexOf("httpBearerAuth"));
        }

        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        [TestMethod]
        public void ToString_ReturnsCommaSeparatedString()
        {
            // Arrange
            var preference = new AuthSchemePreference(new[] { "sigv4", "sigv4a", "httpBearerAuth" });

            // Act
            var result = preference.ToString();

            // Assert
            Assert.AreEqual("sigv4, sigv4a, httpBearerAuth", result);
        }

        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        [TestMethod]
        public void Equals_SamePreferences_ReturnsTrue()
        {
            // Arrange
            var preference1 = new AuthSchemePreference(new[] { "sigv4", "sigv4a" });
            var preference2 = new AuthSchemePreference(new[] { "sigv4", "sigv4a" });

            // Act & Assert
            Assert.IsTrue(preference1.Equals(preference2));
        }

        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        [TestMethod]
        public void Equals_CaseSensitive_ReturnsFalseForDifferentCase()
        {
            // Arrange - Per Multi-auth spec: auth scheme names are case-sensitive
            var preference1 = new AuthSchemePreference(new[] { "sigv4", "SigV4a" });
            var preference2 = new AuthSchemePreference(new[] { "SIGV4", "sigv4a" });

            // Act & Assert - Different case means not equal
            Assert.IsFalse(preference1.Equals(preference2));
        }
    }
}