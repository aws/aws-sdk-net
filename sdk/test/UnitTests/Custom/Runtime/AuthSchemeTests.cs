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
using Amazon.Runtime;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK.UnitTests
{
    [TestClass]
    public class AuthSchemeTests
    {
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        [TestMethod]
        public void Constructor_ValidParameters_CreatesInstance()
        {
            // Arrange
            var schemeId = "test.scheme#id";
            var name = "testScheme";
            var type = AuthSchemeType.SigV4;

            // Act
            var authScheme = new AuthScheme(schemeId, name, type);

            // Assert
            Assert.AreEqual(schemeId, authScheme.SchemeId);
            Assert.AreEqual(name, authScheme.Name);
            Assert.AreEqual(type, authScheme.Type);
        }

        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Constructor_NullSchemeId_ThrowsArgumentNullException()
        {
            // Act & Assert
            new AuthScheme(null, "testScheme", AuthSchemeType.SigV4);
        }

        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Constructor_NullName_ThrowsArgumentNullException()
        {
            // Act & Assert
            new AuthScheme("test.scheme#id", null, AuthSchemeType.SigV4);
        }

        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        [TestMethod]
        public void PredefinedSchemes_HaveCorrectValues()
        {
            // Assert SigV4
            Assert.AreEqual("aws.auth#sigv4", AuthScheme.SigV4.SchemeId);
            Assert.AreEqual("sigv4", AuthScheme.SigV4.Name);
            Assert.AreEqual(AuthSchemeType.SigV4, AuthScheme.SigV4.Type);

            // Assert SigV4a
            Assert.AreEqual("aws.auth#sigv4a", AuthScheme.SigV4a.SchemeId);
            Assert.AreEqual("sigv4a", AuthScheme.SigV4a.Name);
            Assert.AreEqual(AuthSchemeType.SigV4a, AuthScheme.SigV4a.Type);

            // Assert HttpBearerAuth
            Assert.AreEqual("smithy.api#httpBearerAuth", AuthScheme.HttpBearerAuth.SchemeId);
            Assert.AreEqual("httpBearerAuth", AuthScheme.HttpBearerAuth.Name);
            Assert.AreEqual(AuthSchemeType.HttpBearer, AuthScheme.HttpBearerAuth.Type);

            // Assert NoAuth
            Assert.AreEqual("smithy.api#noAuth", AuthScheme.NoAuth.SchemeId);
            Assert.AreEqual("noAuth", AuthScheme.NoAuth.Name);
            Assert.AreEqual(AuthSchemeType.NoAuth, AuthScheme.NoAuth.Type);
        }

        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        [TestMethod]
        public void Equals_SameValues_ReturnsTrue()
        {
            // Arrange
            var scheme1 = new AuthScheme("test.scheme#id", "testScheme", AuthSchemeType.SigV4);
            var scheme2 = new AuthScheme("test.scheme#id", "testScheme", AuthSchemeType.SigV4);

            // Act & Assert
            Assert.IsTrue(scheme1.Equals(scheme2));
            Assert.IsTrue(scheme1 == scheme2);
            Assert.IsFalse(scheme1 != scheme2);
        }

        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        [TestMethod]
        public void Equals_DifferentValues_ReturnsFalse()
        {
            // Arrange
            var scheme1 = new AuthScheme("test.scheme#id1", "testScheme1", AuthSchemeType.SigV4);
            var scheme2 = new AuthScheme("test.scheme#id2", "testScheme2", AuthSchemeType.SigV4a);

            // Act & Assert
            Assert.IsFalse(scheme1.Equals(scheme2));
            Assert.IsFalse(scheme1 == scheme2);
            Assert.IsTrue(scheme1 != scheme2);
        }

        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        [TestMethod]
        public void Equals_NullObject_ReturnsFalse()
        {
            // Arrange
            var scheme = new AuthScheme("test.scheme#id", "testScheme", AuthSchemeType.SigV4);

            // Act & Assert
            Assert.IsFalse(scheme.Equals(null));
            Assert.IsFalse(scheme == null);
            Assert.IsTrue(scheme != null);
        }

        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        [TestMethod]
        public void GetHashCode_SameValues_ReturnsSameHashCode()
        {
            // Arrange
            var scheme1 = new AuthScheme("test.scheme#id", "testScheme", AuthSchemeType.SigV4);
            var scheme2 = new AuthScheme("test.scheme#id", "testScheme", AuthSchemeType.SigV4);

            // Act & Assert
            Assert.AreEqual(scheme1.GetHashCode(), scheme2.GetHashCode());
        }

        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        [TestMethod]
        public void ToString_ReturnsFormattedString()
        {
            // Arrange
            var scheme = new AuthScheme("test.scheme#id", "testScheme", AuthSchemeType.SigV4);

            // Act
            var result = scheme.ToString();

            // Assert
            Assert.AreEqual("AuthScheme(SchemeId=test.scheme#id, Name=testScheme, Type=SigV4)", result);
        }
    }
}