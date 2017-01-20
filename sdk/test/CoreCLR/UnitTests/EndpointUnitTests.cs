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

        [Fact]
        [Trait("Category", "Core")]
        public void EnumerableAllRegionsTest()
        {
            int count = 0;
            foreach (var endpoint in RegionEndpoint.EnumerableAllRegions)
            {
                if      (endpoint == RegionEndpoint.CNNorth1) count++;
                else if (endpoint == RegionEndpoint.APNortheast1) count++;
                else if (endpoint == RegionEndpoint.APNortheast2) count++;
                else if (endpoint == RegionEndpoint.APSoutheast1) count++;
                else if (endpoint == RegionEndpoint.APSoutheast2) count++;
                else if (endpoint == RegionEndpoint.EUCentral1) count++;
                else if (endpoint == RegionEndpoint.EUWest1) count++;
                else if (endpoint == RegionEndpoint.USGovCloudWest1) count++;
                else if (endpoint == RegionEndpoint.USEast1) count++;
                else if (endpoint == RegionEndpoint.USWest1) count++;
                else if (endpoint == RegionEndpoint.USWest2) count++;
                else if (endpoint == RegionEndpoint.SAEast1) count++;
            }

            Assert.Equal(12, count);
        }

        [Fact]
        [Trait("Category", "Core")]
        public void NonstandardRegionTest()
        {
            Assert.Equal("s3-external-1.amazonaws.com", RegionEndpoint.GetBySystemName("s3-external-1").GetEndpointForService("s3").Hostname);
            Assert.Equal("budgets.amazonaws.com", RegionEndpoint.GetBySystemName("aws-global").GetEndpointForService("budgets").Hostname);
            Assert.Equal("s3-fips-us-gov-west-1.amazonaws.com", RegionEndpoint.GetBySystemName("fips-us-gov-west-1").GetEndpointForService("s3").Hostname);
            Assert.Equal("iam.us-gov.amazonaws.com", RegionEndpoint.GetBySystemName("aws-us-gov-global").GetEndpointForService("iam").Hostname);
        }

        [Fact]
        [Trait("Category", "Core")]
        public void UnknownEndpointTest()
        {
            Assert.Equal("someservice.cn-north-1.amazonaws.com.cn", RegionEndpoint.CNNorth1.GetEndpointForService("someservice").Hostname);
            Assert.Equal("amazingservice.ap-southeast-2.amazonaws.com", RegionEndpoint.APSoutheast2.GetEndpointForService("amazingservice").Hostname);
            Assert.Equal("coolservice.us-gov-west-1.amazonaws.com", RegionEndpoint.USGovCloudWest1.GetEndpointForService("coolservice").Hostname);

            Assert.Equal("s3.us-east-12.amazonaws.com", RegionEndpoint.GetBySystemName("us-east-12").GetEndpointForService("s3").Hostname);
            Assert.Equal("newservice.us-gov-10.amazonaws.com", RegionEndpoint.GetBySystemName("us-gov-10").GetEndpointForService("newservice").Hostname);
            Assert.Equal("specialservice.cn-east-3.amazonaws.com.cn", RegionEndpoint.GetBySystemName("cn-east-3").GetEndpointForService("specialservice").Hostname);

            Assert.Equal("Unknown", RegionEndpoint.GetBySystemName("us-gov-10").DisplayName);
            Assert.Equal("China (Unknown)", RegionEndpoint.GetBySystemName("cn-east-10").DisplayName);
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
    }
}