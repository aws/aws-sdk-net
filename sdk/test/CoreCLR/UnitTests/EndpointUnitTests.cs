using Amazon;

using Xunit;
using Amazon.S3;
using System;
using System.IO;
using System.Diagnostics;
using System.Reflection;
using System.Collections.Generic;
using Amazon.Internal;

namespace AWSSDK_CoreCLR.UnitTests
{
    public class RegionEndpointV3Tests
    {
        [Fact]
        [Trait("Category", "Core")]
        public void CustomServicesTest()
        {
            RegionEndpoint.EUCentral1.GetEndpointForService("data.iot");

            string t = RegionEndpoint.EUCentral1.GetEndpointForService("iotdata").Hostname;
            Assert.Equal("data.iot.eu-central-1.amazonaws.com", t);
            Assert.Equal("iot.ap-southeast-2.amazonaws.com", RegionEndpoint.APSoutheast2.GetEndpointForService("execute-api").Hostname);

            RegionEndpoint.USEast1.GetEndpointForService("importexport");

            Assert.Equal("importexport.amazonaws.com", RegionEndpoint.APSoutheast2.GetEndpointForService("IngestionService").Hostname);
        }

        [Fact]
        [Trait("Category", "Core")]
        public void V2RegressionTest()
        {
            Assert.Equal("autoscaling.us-east-1.amazonaws.com", RegionEndpoint.USEast1.GetEndpointForService("application-autoscaling").Hostname);
            Assert.Equal("autoscaling.us-west-2.amazonaws.com", RegionEndpoint.USWest2.GetEndpointForService("application-autoscaling").Hostname);
            Assert.Equal("autoscaling.eu-west-1.amazonaws.com", RegionEndpoint.EUWest1.GetEndpointForService("application-autoscaling").Hostname);

            Assert.Equal("sts.ap-northeast-2.amazonaws.com", RegionEndpoint.APNortheast2.GetEndpointForService("sts").Hostname);
        }
    }

    public class EndpointCustomizationTestClass : IDisposable
    {
        private FileInfo tempEndpointCutomizationFile;
        public EndpointCustomizationTestClass()
        {
            tempEndpointCutomizationFile = CreateEndpointCustomizationFile();
            RegionEndpointProviderV2.RegionEndpoint.LoadEndpointDefinitions(tempEndpointCutomizationFile.FullName);
        }

        public void Dispose()
        {
            File.Delete(tempEndpointCutomizationFile.FullName);
            RegionEndpointProviderV2.RegionEndpoint.UnloadEndpointDefinitions();
        }
        
        [Fact]
        [Trait("Category", "Core")]
        public void EndpointCustomizationTest()
        {
            IRegionEndpointProvider provider = new RegionEndpointProviderV2();
            var useast1 = provider.GetRegionEndpoint("us-east-1");
            var uswest2 = provider.GetRegionEndpoint("us-west-2");
            var euwest1 = provider.GetRegionEndpoint("eu-west-1");
            Assert.Equal("application-autoscaling.us-east-1.amazonaws.com", useast1.GetEndpointForService("application-autoscaling", false).Hostname);
            Assert.Equal("application-autoscaling.us-west-2.amazonaws.com", uswest2.GetEndpointForService("application-autoscaling", false).Hostname);
            Assert.Equal("application-autoscaling.eu-west-1.amazonaws.com", euwest1.GetEndpointForService("application-autoscaling", false).Hostname);

            var apne2 = provider.GetRegionEndpoint("ap-northeast-2");
            Assert.Equal("sts.amazonaws.com", apne2.GetEndpointForService("sts", false).Hostname);
        }

        private FileInfo CreateEndpointCustomizationFile()
        {
            string customizationResourceName = "UnitTests.endpoint.customization.json";
            FileInfo fi = new FileInfo(Path.Combine(Path.GetTempPath(), Path.GetTempFileName()));

            using (StreamReader resStream = new StreamReader(Utils.GetAssemblyResourceStream(customizationResourceName)))
            using (Stream stream = new FileStream(fi.FullName, FileMode.OpenOrCreate))
            using (StreamWriter fileStreamWriter = new StreamWriter(stream))
            {
                while (!resStream.EndOfStream)
                { 
                    fileStreamWriter.WriteLine(resStream.ReadLine());
                }
            }

            return fi;
        }

        [Fact]
        [Trait("Category", "Core")]
        public void UnknownEndpointTest()
        {
            Assert.Equal("someservice.cn-north-1.amazonaws.com.cn",         RegionEndpoint.CNNorth1.GetEndpointForService("someservice").Hostname);
            Assert.Equal("amazingservice.ap-southeast-2.amazonaws.com",     RegionEndpoint.APSoutheast2.GetEndpointForService("amazingservice").Hostname);
            Assert.Equal("mediocreservice.us-gov-west-1.amazonaws.com",     RegionEndpoint.USGovCloudWest1.GetEndpointForService("mediocreservice").Hostname);
        }

        [Fact]
        [Trait("Category", "Core")]
        public void S3SignatureTest()
        {
            Assert.Equal("4", RegionEndpoint.APNortheast2.GetEndpointForService("s3").SignatureVersionOverride);
            Assert.Equal("4", RegionEndpoint.CNNorth1.GetEndpointForService("s3").SignatureVersionOverride);
            Assert.Equal("2", RegionEndpoint.SAEast1.GetEndpointForService("s3").SignatureVersionOverride);
            Assert.Equal("2", RegionEndpoint.USEast1.GetEndpointForService("s3").SignatureVersionOverride);
            Assert.Equal("2", RegionEndpoint.EUWest1.GetEndpointForService("s3").SignatureVersionOverride);
        }
    }
}