/*
 * Copyright 2018 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using Amazon.Internal;
using Amazon.Runtime.Internal.Util;
using AWSSDK_DotNet.IntegrationTests.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ThirdParty.Json.LitJson;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace AWSSDK.UnitTests
{
    [TestClass]
    public class RegionEndpointProviderV3Test
    {
        private const string partitionJson = @"{
            ""defaults"": {
                ""hostname"": ""{service}.{region}.{dnsSuffix}"",
                ""protocols"": [
                    ""https""
                ],
                ""signatureVersions"": [
                    ""v4""
                ]
            },
            ""dnsSuffix"": ""amazonaws.com"",
            ""partition"": ""aws"",
            ""partitionName"": ""AWS Standard"",
            ""regionRegex"": ""^(us|eu|ap|sa|ca)\\-\\w+\\-\\d+$""
        }";

        private const string servicesJson = @"{
            ""svc"": {
                ""endpoints"": {
                    ""xx-northeast-1"": {},
                    ""xx-east-1-fips"": {
                        ""credentialScope"": {
                            ""region"": ""xx-east-1""
                        },
                        ""hostname"": ""svc-fips.xx-east-1.amazonaws.com""
                    }
                }
            },
            ""s3"": {
                ""endpoints"": {
                    ""xx-northeast-1"": {},
                    ""xx-east-1"": {
                        ""hostname"": ""s3.xx-east-1.amazonaws.com""
                    },
                    ""xx-west-1"": {
                        ""hostname"": ""s3-xx-west-1.amazonaws.com""
                    },
                    ""us-east-1"": {
                        ""hostname"": ""s3.amazonaws.com""
                    },
                    ""xx-east-1-fips"": {
                        ""credentialScope"": {
                            ""region"": ""xx-east-1""
                        },
                        ""hostname"": ""s3-fips.xx-east-1.amazonaws.com""
                    }
                },
                ""isRegionalized"": true,
                ""partitionEndpoint"": ""us-east-1""
            },
            ""s3-control"": {
                ""endpoints"": {
                    ""xx-northeast-1"": {},
                    ""xx-east-1-fips"": {
                        ""credentialScope"": {
                            ""region"": ""xx-east-1""
                        },
                        ""hostname"": ""s3-control-fips.xx-east-1.amazonaws.com""
                    }
                },
                ""isRegionalized"": true
            }
        }";

        [TestMethod]
        public void GetEndpointForService()
        {
            var partition = JsonMapper.ToObject(new StringReader(partitionJson));
            var services = JsonMapper.ToObject(new StringReader(servicesJson));

            {
                var regionEndpoint = new RegionEndpointV3("xx-northeast-1", "", partition, services);
                var endpoint = regionEndpoint.GetEndpointForService("svc", false);
                Assert.AreEqual(endpoint.Hostname, "svc.xx-northeast-1.amazonaws.com");
            }

            {
                var regionEndpoint = new RegionEndpointV3("xx-northeast-1", "", partition, services);
                var endpoint = regionEndpoint.GetEndpointForService("svc", true);
                Assert.AreEqual(endpoint.Hostname, "svc.dualstack.xx-northeast-1.amazonaws.com");
            }

            {
                var regionEndpoint = new RegionEndpointV3("xx-east-1-fips", "", partition, services);
                var endpoint = regionEndpoint.GetEndpointForService("svc", false);
                Assert.AreEqual(endpoint.Hostname, "svc-fips.xx-east-1.amazonaws.com");
            }

            {
                var regionEndpoint = new RegionEndpointV3("xx-east-1-fips", "", partition, services);
                var endpoint = regionEndpoint.GetEndpointForService("svc", true);
                Assert.AreEqual(endpoint.Hostname, "svc.dualstack.xx-east-1-fips.amazonaws.com");
            }

            {
                var regionEndpoint = new RegionEndpointV3("xx-northeast-1", "", partition, services);
                var endpoint = regionEndpoint.GetEndpointForService("s3", false);
                Assert.AreEqual(endpoint.Hostname, "s3.xx-northeast-1.amazonaws.com");
            }

            {
                var regionEndpoint = new RegionEndpointV3("xx-northeast-1", "", partition, services);
                var endpoint = regionEndpoint.GetEndpointForService("s3", true);
                Assert.AreEqual(endpoint.Hostname, "s3.dualstack.xx-northeast-1.amazonaws.com");
            }

            {
                var regionEndpoint = new RegionEndpointV3("xx-west-1", "", partition, services);
                var endpoint = regionEndpoint.GetEndpointForService("s3", false);
                Assert.AreEqual(endpoint.Hostname, "s3-xx-west-1.amazonaws.com");
            }

            {
                var regionEndpoint = new RegionEndpointV3("xx-west-1", "", partition, services);
                var endpoint = regionEndpoint.GetEndpointForService("s3", true);
                Assert.AreEqual(endpoint.Hostname, "s3.dualstack.xx-west-1.amazonaws.com");
            }

            {
                var regionEndpoint = new RegionEndpointV3("xx-east-1", "", partition, services);
                var endpoint = regionEndpoint.GetEndpointForService("s3", false);
                Assert.AreEqual(endpoint.Hostname, "s3.xx-east-1.amazonaws.com");
            }

            {
                var regionEndpoint = new RegionEndpointV3("xx-east-1", "", partition, services);
                var endpoint = regionEndpoint.GetEndpointForService("s3", true);
                Assert.AreEqual(endpoint.Hostname, "s3.dualstack.xx-east-1.amazonaws.com");
            }

            {
                var regionEndpoint = new RegionEndpointV3("us-east-1", "", partition, services);
                var endpoint = regionEndpoint.GetEndpointForService("s3", false);
                Assert.AreEqual(endpoint.Hostname, "s3.amazonaws.com");
            }

            {
                var regionEndpoint = new RegionEndpointV3("us-east-1", "", partition, services);
                var endpoint = regionEndpoint.GetEndpointForService("s3", true);
                Assert.AreEqual(endpoint.Hostname, "s3.dualstack.us-east-1.amazonaws.com");
            }

            {
                var regionEndpoint = new RegionEndpointV3("xx-east-1-fips", "", partition, services);
                var endpoint = regionEndpoint.GetEndpointForService("s3", false);
                Assert.AreEqual(endpoint.Hostname, "s3-fips.xx-east-1.amazonaws.com");
            }

            {
                var regionEndpoint = new RegionEndpointV3("xx-east-1-fips", "", partition, services);
                var endpoint = regionEndpoint.GetEndpointForService("s3", true);
                Assert.AreEqual(endpoint.Hostname, "s3.dualstack.fips.xx-east-1.amazonaws.com");
            }

            {
                var regionEndpoint = new RegionEndpointV3("xx-northeast-1", "", partition, services);
                var endpoint = regionEndpoint.GetEndpointForService("s3-control", false);
                Assert.AreEqual(endpoint.Hostname, "s3-control.xx-northeast-1.amazonaws.com");
            }

            {
                var regionEndpoint = new RegionEndpointV3("xx-northeast-1", "", partition, services);
                var endpoint = regionEndpoint.GetEndpointForService("s3-control", true);
                Assert.AreEqual(endpoint.Hostname, "s3-control.dualstack.xx-northeast-1.amazonaws.com");
            }

            {
                var regionEndpoint = new RegionEndpointV3("xx-east-1-fips", "", partition, services);
                var endpoint = regionEndpoint.GetEndpointForService("s3-control", false);
                Assert.AreEqual(endpoint.Hostname, "s3-control-fips.xx-east-1.amazonaws.com");
            }

            {
                var regionEndpoint = new RegionEndpointV3("xx-east-1-fips", "", partition, services);
                var endpoint = regionEndpoint.GetEndpointForService("s3-control", true);
                Assert.AreEqual(endpoint.Hostname, "s3-control-fips.dualstack.xx-east-1.amazonaws.com");
            }
        }
    }
}
