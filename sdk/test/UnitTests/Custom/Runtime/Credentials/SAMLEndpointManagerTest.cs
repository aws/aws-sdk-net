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
using Amazon.Runtime;
using Amazon.Runtime.CredentialManagement;
using Amazon.Runtime.Internal.Settings;
using Amazon.Util;
using AWSSDK_DotNet.IntegrationTests.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Text.RegularExpressions;

namespace AWSSDK.UnitTests
{
    [TestClass]
    public class SAMLEndpointManagerTest
    {
        private const string EndpointsFilename = SettingsConstants.RegisteredSAMLEndpoints + ".json";

        private const string EndpointName = "EndpointName";

        private const string EmptyNameSAMLEndpointText =
            "{" +
            "   \"6df80b45-ac10-4916-a23a-8861cbed8fbe\" : {" +
            "       \"DisplayName\" : \"\"," +
            "       \"Endpoint\"    : \"https://someendpoint.com/\"," +
            "       \"AuthenticationType\" : \"Kerberos\"" +
            "   }" +
            "}";

        private const string InvalidUriSAMLEndpointText =
            "{" +
            "   \"6df80b45-ac10-4916-a23a-8861cbed8fbe\" : {" +
            "       \"DisplayName\" : \"EndpointName\"," +
            "       \"Endpoint\"    : \"http://nothttps.com/\"," +
            "       \"AuthenticationType\" : \"Kerberos\"" +
            "   }" +
            "}";

        private const string InvalidAuthenticationTypeSAMLEndpointText =
            "{" +
            "   \"6df80b45-ac10-4916-a23a-8861cbed8fbe\" : {" +
            "       \"DisplayName\" : \"EndpointName\"," +
            "       \"Endpoint\"    : \"https://someendpoint.com/\"," +
            "       \"AuthenticationType\" : \"BLAH!\"" +
            "   }" +
            "}";

        private static readonly Uri EndpointUri = new Uri("https://someendpoint.com", UriKind.RelativeOrAbsolute);
        private static readonly Uri OtherEndpointUri = new Uri("https://someotherendpoint.com", UriKind.RelativeOrAbsolute);

        private static readonly SAMLEndpoint DefaultAuthSamlEndpoint = new SAMLEndpoint(EndpointName, EndpointUri);
        private static readonly SAMLEndpoint ExplicitAuthSamlEndpoint = new SAMLEndpoint(EndpointName, OtherEndpointUri, SAMLAuthenticationType.NTLM);

        private EncryptedStoreTestFixture fixture;
        private SAMLEndpointManager manager;

        [TestInitialize]
        public void CreateFixture()
        {
            fixture = new EncryptedStoreTestFixture(EndpointsFilename);
            manager = new SAMLEndpointManager();
        }

        [TestCleanup]
        public void DisposeFixture()
        {
            fixture.Dispose();
        }

        [TestMethod]
        public void RegisterEndpointDefaultAuth()
        {
            manager.RegisterEndpoint(DefaultAuthSamlEndpoint);
            fixture.AssertJsonProperty(EndpointName, SettingsConstants.EndpointField, EndpointUri.ToString());
            fixture.AssertJsonProperty(EndpointName, SettingsConstants.AuthenticationTypeField, SAMLAuthenticationType.Kerberos.ToString());
        }

        [TestMethod]
        public void RegisterEndpointExplicitAuth()
        {
            manager.RegisterEndpoint(ExplicitAuthSamlEndpoint);
            fixture.AssertJsonProperty(EndpointName, SettingsConstants.EndpointField, OtherEndpointUri.ToString());
            fixture.AssertJsonProperty(EndpointName, SettingsConstants.AuthenticationTypeField, SAMLAuthenticationType.NTLM.ToString());
        }


        [TestMethod]
        public void RegisterEndpointUdpateExisting()
        {
            manager.RegisterEndpoint(DefaultAuthSamlEndpoint);
            fixture.AssertObjectCount(1);
            fixture.AssertJsonProperty(EndpointName, SettingsConstants.EndpointField, EndpointUri.ToString());
            fixture.AssertJsonProperty(EndpointName, SettingsConstants.AuthenticationTypeField, SAMLAuthenticationType.Kerberos.ToString());
            manager.RegisterEndpoint(ExplicitAuthSamlEndpoint);
            fixture.AssertObjectCount(1);
            fixture.AssertJsonProperty(EndpointName, SettingsConstants.EndpointField, OtherEndpointUri.ToString());
            fixture.AssertJsonProperty(EndpointName, SettingsConstants.AuthenticationTypeField, SAMLAuthenticationType.NTLM.ToString());
        }

        [TestMethod]
        public void TryGetEndpointExists()
        {
            manager.RegisterEndpoint(DefaultAuthSamlEndpoint);
            SAMLEndpoint samlEndpoint;
            Assert.IsTrue(manager.TryGetEndpoint(EndpointName, out samlEndpoint));
            Assert.IsNotNull(samlEndpoint);
        }

        [TestMethod]
        public void TryGetEndpointDoesNotExist()
        {
            SAMLEndpoint samlEndpoint;
            Assert.IsFalse(manager.TryGetEndpoint(EndpointName, out samlEndpoint));
            Assert.IsNull(samlEndpoint);
        }

        [TestMethod]
        public void TryGetEndpointInvalidName()
        {
            fixture.SetFileContents(EmptyNameSAMLEndpointText);
            SAMLEndpoint samlEndpoint;
            Assert.IsFalse(manager.TryGetEndpoint("", out samlEndpoint));
            Assert.IsNull(samlEndpoint);
        }

        [TestMethod]
        public void GetEndpointExists()
        {
            manager.RegisterEndpoint(DefaultAuthSamlEndpoint);
            SAMLEndpoint samlEndpoint = manager.GetEndpoint(EndpointName);
            Assert.IsNotNull(samlEndpoint);
        }

        [TestMethod]
        public void GetEndpointDoesNotExist()
        {
            AssertExtensions.ExpectException(() =>
            {
                manager.GetEndpoint(EndpointName);
            }, typeof(AmazonClientException), new Regex("There is no SAML endpoint registered with name"));
        }

        [TestMethod]
        public void GetEndpointInvalidName()
        {
            fixture.SetFileContents(EmptyNameSAMLEndpointText);
            AssertExtensions.ExpectException(() =>
            {
                throw AssertExtensions.ExpectException(() =>
                {
                    manager.GetEndpoint("");
                }, typeof(AmazonClientException), new Regex("Error reading A SAML endpoint with name")).InnerException;
            }, typeof(ArgumentException), "Name is null or empty.");
        }

        [TestMethod]
        public void GetEndpointInvalidUri()
        {
            fixture.SetFileContents(InvalidUriSAMLEndpointText);
            AssertExtensions.ExpectException(() =>
            {
                throw AssertExtensions.ExpectException(() =>
                {
                    manager.GetEndpoint(EndpointName);
                }, typeof(AmazonClientException), new Regex("Error reading A SAML endpoint with name")).InnerException;
            }, typeof(ArgumentException), "EndpointUri is not Https protocol.");
        }

        [TestMethod]
        public void GetEndpointInvalidAuthenticationType()
        {
            fixture.SetFileContents(InvalidAuthenticationTypeSAMLEndpointText);
            AssertExtensions.ExpectException(() =>
            {
                throw AssertExtensions.ExpectException(() =>
                {
                    manager.GetEndpoint(EndpointName);
                }, typeof(AmazonClientException), new Regex("Error reading A SAML endpoint with name")).InnerException;
            }, typeof(ArgumentException), "Requested value 'BLAH!' was not found.");
        }
    }
}
