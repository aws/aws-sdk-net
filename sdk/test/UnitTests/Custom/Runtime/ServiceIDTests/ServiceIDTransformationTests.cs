using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Security.Cryptography;
using System.IO;
using static AWSSDK.UnitTests.ServiceIDTransformationTests;
using Amazon.Runtime.Internal.Util;

namespace AWSSDK.UnitTests
{
    [TestClass]
    public class ServiceIDTransformationTests
    {
        const string ServiceIdKey = "service_id";
        const string ServiceSectionNameKey = "services_section_name";
        const string ServiceEnvVarNameKey = "service_envvar_name";
        const string ServiceIdJsonFileName = "service-id-transformations.json";
        const string ServiceIdDirectoryName = "ServiceIDTests";
        private class Service
        {
            public string ServiceId { get; set; }
            public string ServicesSectionName { get; set; }
            public string ServiceEnvVarName { get; set; }
        }
        Dictionary<string, string> EnvironmentVariableNames = new Dictionary<string, string>();
        Dictionary<string, string> ConfigVariableNames = new Dictionary<string, string>();
        List<Service> Services = new List<Service>();

        [TestInitialize]
        public void Initialize() 
        {
            var workingDirectory = Environment.CurrentDirectory;
            var projectDirectory = Directory.GetParent(workingDirectory).Parent.Parent.FullName;
            var pathToJsonFile = Path.Combine(projectDirectory, "Custom","Runtime",ServiceIdDirectoryName, ServiceIdJsonFileName);
            PopulateServiceList(Services, pathToJsonFile);
            foreach (var service in Services)
            {
                try
                {
                    EnvironmentVariableNames.Add(service.ServiceId, service.ServiceEnvVarName);
                    ConfigVariableNames.Add(service.ServiceId, service.ServicesSectionName);
                }
                //This catch is here because there was a duplicate service ID entry.
                catch 
                {
                }
            }
        }
        private void PopulateServiceList(List<Service> services, string pathToJsonFile)
        {
            using (var reader = new StreamReader(pathToJsonFile))
            {
                JsonDocument data = JsonDocument.Parse(reader.ReadToEnd());
                foreach (var serviceData in data.RootElement.EnumerateArray())
                {
                    Service service = new Service();
                    service.ServiceId = serviceData.GetProperty(ServiceIdKey).GetString();
                    service.ServicesSectionName = serviceData.GetProperty(ServiceSectionNameKey).GetString();
                    service.ServiceEnvVarName = serviceData.GetProperty(ServiceEnvVarNameKey).GetString();
                    services.Add(service);
                }
            }
        }
        [TestMethod]
        public void TransformServiceIdToEnvironmentVariableTests()
        {
            foreach (var keyValuePair in EnvironmentVariableNames)
            {
                var actualTransformedServiceId = TransformServiceId.TransformServiceIdToEnvVariable(keyValuePair.Key);
                var expectedTransformedServiceId = keyValuePair.Value;
                Assert.AreEqual(expectedTransformedServiceId, actualTransformedServiceId);
            }
        }
        [TestMethod]
        public void TransformServiceIdToConfigVariableTests()
        {
            foreach (var keyValuePair in ConfigVariableNames)
            {
                var actualTransformedServiceId = TransformServiceId.TransformServiceIdToConfigVariable(keyValuePair.Key);
                var expectedTransformedServiceId = keyValuePair.Value;
                Assert.AreEqual(expectedTransformedServiceId, actualTransformedServiceId);
            }
        }
    }
}
