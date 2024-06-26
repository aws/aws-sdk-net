using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Amazon;
using Amazon.RuntimeDependencies;
using Amazon.SecurityToken;
using Moq;
using Amazon.Runtime.SharedInterfaces;
using Amazon.Runtime.Internal;
using Amazon.Runtime.SharedInterfaces.Internal;
using AWSSDK.Runtime.Internal.Util;
using Amazon.Runtime.Internal.Auth;
using Amazon.KeyManagementService;
using Amazon.SSO;
using Amazon.SSOOIDC;

namespace AWSSDK.UnitTests
{
    [TestClass]
    public class RuntimeDependencyRegistryTests
    {
        [TestMethod]
        public void RegisterSTSInstance()
        {
            var expectedInstance = new Mock<IAmazonSecurityTokenService>().Object;
            var registry = new GlobalRuntimeDependencyRegistry();
            registry.RegisterSecurityTokenServiceClient(expectedInstance);


            var registeredInstance = registry.GetInstance<IAmazonSecurityTokenService>(
                ServiceClientHelpers.STS_ASSEMBLY_NAME, ServiceClientHelpers.STS_SERVICE_CLASS_NAME, 
                new CreateInstanceContext(new SecurityTokenServiceClientContext { Action = SecurityTokenServiceClientContext.ActionContext.AssumeRoleAWSCredentials, Region = RegionEndpoint.USWest2 }));

            Assert.AreSame(expectedInstance, registeredInstance);
        }

        [TestMethod]
        public void RegisterSTSWithFactory()
        {
            var expectedInstance = new Mock<IAmazonSecurityTokenService>().Object;
            var registry = new GlobalRuntimeDependencyRegistry();

            var factoryCalled = false;
            registry.RegisterSecurityTokenServiceClient((context) =>
            {
                factoryCalled = true;
                Assert.AreEqual(RegionEndpoint.USWest2, context.SecurityTokenServiceClientContextData.Region);
                return expectedInstance;
            });


            var registeredInstance = registry.GetInstance<IAmazonSecurityTokenService>(
                ServiceClientHelpers.STS_ASSEMBLY_NAME, ServiceClientHelpers.STS_SERVICE_CLASS_NAME,
                new CreateInstanceContext(new SecurityTokenServiceClientContext { Action = SecurityTokenServiceClientContext.ActionContext.AssumeRoleAWSCredentials, Region = RegionEndpoint.USWest2 }));

            Assert.IsTrue(factoryCalled);
            Assert.AreSame(expectedInstance, registeredInstance);
        }

        [TestMethod]
        public void RegisterChecksumProviderTest()
        {
            var expectedInstance = new Mock<IChecksumProvider>().Object;
            var registry = new GlobalRuntimeDependencyRegistry();
            registry.RegisterChecksumProvider(expectedInstance);

            var registeredInstance = registry.GetInstance<IChecksumProvider>(ChecksumCRTWrapper.CRT_WRAPPER_ASSEMBLY_NAME, ChecksumCRTWrapper.CRT_WRAPPER_CLASS_NAME,
                                        new CreateInstanceContext(new CheckSumProviderContext()));
            Assert.AreSame(expectedInstance, registeredInstance);
        }

        [TestMethod]
        public void RegisterSigV4aProviderTest()
        {
            var expectedInstance = new Mock<IAWSSigV4aProvider>().Object;
            var registry = new GlobalRuntimeDependencyRegistry();
            registry.RegisterSigV4aProvider((context) =>
            {
                Assert.IsTrue(context.SigV4aCrtSignerContextData.SignPayload);
                return expectedInstance;
            });

            var registeredInstance = registry.GetInstance<IAWSSigV4aProvider>(AWS4aSignerCRTWrapper.CRT_WRAPPER_ASSEMBLY_NAME, AWS4aSignerCRTWrapper.CRT_WRAPPER_CLASS_NAME,
                                        new CreateInstanceContext(new SigV4aCrtSignerContext(true)));
            Assert.AreSame(expectedInstance, registeredInstance);
        }

        [TestMethod]
        public void RegisterSSOInstance()
        {
            var expectedInstance = new Mock<IAmazonSSO>().Object;
            var registry = new GlobalRuntimeDependencyRegistry();
            registry.RegisterSSOClient(expectedInstance);


            var registeredInstance = registry.GetInstance<IAmazonSSO>(
                ServiceClientHelpers.SSO_ASSEMBLY_NAME, ServiceClientHelpers.SSO_SERVICE_CLASS_NAME,
                new CreateInstanceContext(new SSOClientContext { Region = RegionEndpoint.USWest2 }));

            Assert.AreSame(expectedInstance, registeredInstance);
        }

        [TestMethod]
        public void RegisterSSOWithFactory()
        {
            var expectedInstance = new Mock<IAmazonSSO>().Object;
            var registry = new GlobalRuntimeDependencyRegistry();

            var factoryCalled = false;
            registry.RegisterSSOClient((context) =>
            {
                factoryCalled = true;
                Assert.AreEqual(RegionEndpoint.USWest2, context.SSOClientContextData.Region);
                return expectedInstance;
            });


            var registeredInstance = registry.GetInstance<IAmazonSSO>(
                ServiceClientHelpers.SSO_ASSEMBLY_NAME, ServiceClientHelpers.SSO_SERVICE_CLASS_NAME,
                new CreateInstanceContext(new SSOClientContext { Region = RegionEndpoint.USWest2 }));

            Assert.IsTrue(factoryCalled);
            Assert.AreSame(expectedInstance, registeredInstance);
        }

        [TestMethod]
        public void RegisterSSOOIDCInstance()
        {
            var expectedInstance = new Mock<IAmazonSSOOIDC>().Object;
            var registry = new GlobalRuntimeDependencyRegistry();
            registry.RegisterSSOOIDCClient(expectedInstance);


            var registeredInstance = registry.GetInstance<IAmazonSSOOIDC>(
                ServiceClientHelpers.SSO_OIDC_ASSEMBLY_NAME, ServiceClientHelpers.SSO_OIDC_SERVICE_CLASS_NAME,
                new CreateInstanceContext(new SSOOIDCClientContext { Region = RegionEndpoint.USWest2 }));

            Assert.AreSame(expectedInstance, registeredInstance);
        }

        [TestMethod]
        public void RegisterSSOOIDCWithFactory()
        {
            var expectedInstance = new Mock<IAmazonSSOOIDC>().Object;
            var registry = new GlobalRuntimeDependencyRegistry();

            var factoryCalled = false;
            registry.RegisterSSOOIDCClient((context) =>
            {
                factoryCalled = true;
                Assert.AreEqual(RegionEndpoint.USWest2, context.SSOOIDCClientContextData.Region);
                return expectedInstance;
            });


            var registeredInstance = registry.GetInstance<IAmazonSSOOIDC>(
                ServiceClientHelpers.SSO_OIDC_ASSEMBLY_NAME, ServiceClientHelpers.SSO_OIDC_SERVICE_CLASS_NAME,
                new CreateInstanceContext(new SSOOIDCClientContext { Region = RegionEndpoint.USWest2 }));

            Assert.IsTrue(factoryCalled);
            Assert.AreSame(expectedInstance, registeredInstance);
        }

        [TestMethod]
        public void CheckMissingRuntimeDependencyExceptionConstructor()
        {
            var e = new MissingRuntimeDependencyException("package", "class", "registerMethod");
            Assert.AreEqual(e.PackageName, "package");
            Assert.AreEqual(e.ClassName, "class");
            Assert.AreEqual(e.RegisterMethod, "registerMethod");
        }
    }
}
