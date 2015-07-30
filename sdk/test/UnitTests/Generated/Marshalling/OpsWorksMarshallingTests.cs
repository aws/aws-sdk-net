/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

/*
 * Do not modify this file. This file is generated from the opsworks-2013-02-18.normal.json service model.
 */


using System;
using System.IO;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Amazon.OpsWorks;
using Amazon.OpsWorks.Model;
using Amazon.OpsWorks.Model.Internal.MarshallTransformations;
using Amazon.Runtime.Internal.Transform;

using ServiceClientGenerator;

using AWSSDK_DotNet35.UnitTests.TestTools;

namespace AWSSDK_DotNet35.UnitTests.Marshalling
{
    [TestClass]
    public class OpsWorksMarshallingTests
    {
        static readonly ServiceModel service_model = Utils.LoadServiceModel("opsworks-2013-02-18.normal.json", "opsworks.customizations.json");
        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("OpsWorks")]
        public void AssignInstanceMarshallTest()
        {
            var request = InstantiateClassGenerator.Execute<AssignInstanceRequest>();
            var marshaller = new AssignInstanceRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);                        
            Comparer.CompareObjectToJson<AssignInstanceRequest>(request,jsonRequest);

        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("OpsWorks")]
        public void AssignVolumeMarshallTest()
        {
            var request = InstantiateClassGenerator.Execute<AssignVolumeRequest>();
            var marshaller = new AssignVolumeRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);                        
            Comparer.CompareObjectToJson<AssignVolumeRequest>(request,jsonRequest);

        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("OpsWorks")]
        public void AssociateElasticIpMarshallTest()
        {
            var request = InstantiateClassGenerator.Execute<AssociateElasticIpRequest>();
            var marshaller = new AssociateElasticIpRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);                        
            Comparer.CompareObjectToJson<AssociateElasticIpRequest>(request,jsonRequest);

        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("OpsWorks")]
        public void AttachElasticLoadBalancerMarshallTest()
        {
            var request = InstantiateClassGenerator.Execute<AttachElasticLoadBalancerRequest>();
            var marshaller = new AttachElasticLoadBalancerRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);                        
            Comparer.CompareObjectToJson<AttachElasticLoadBalancerRequest>(request,jsonRequest);

        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("OpsWorks")]
        public void CloneStackMarshallTest()
        {
            var request = InstantiateClassGenerator.Execute<CloneStackRequest>();
            var marshaller = new CloneStackRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);                        
            Comparer.CompareObjectToJson<CloneStackRequest>(request,jsonRequest);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            var jsonResponse = new JsonSampleGenerator(service_model, service_model.FindOperation("CloneStack").ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString());
            UnmarshallerContext context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), false, webResponse);
            var response = CloneStackResponseUnmarshaller.Instance.Unmarshall(context)
                as CloneStackResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("OpsWorks")]
        public void CreateAppMarshallTest()
        {
            var request = InstantiateClassGenerator.Execute<CreateAppRequest>();
            var marshaller = new CreateAppRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);                        
            Comparer.CompareObjectToJson<CreateAppRequest>(request,jsonRequest);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            var jsonResponse = new JsonSampleGenerator(service_model, service_model.FindOperation("CreateApp").ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString());
            UnmarshallerContext context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), false, webResponse);
            var response = CreateAppResponseUnmarshaller.Instance.Unmarshall(context)
                as CreateAppResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("OpsWorks")]
        public void CreateDeploymentMarshallTest()
        {
            var request = InstantiateClassGenerator.Execute<CreateDeploymentRequest>();
            var marshaller = new CreateDeploymentRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);                        
            Comparer.CompareObjectToJson<CreateDeploymentRequest>(request,jsonRequest);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            var jsonResponse = new JsonSampleGenerator(service_model, service_model.FindOperation("CreateDeployment").ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString());
            UnmarshallerContext context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), false, webResponse);
            var response = CreateDeploymentResponseUnmarshaller.Instance.Unmarshall(context)
                as CreateDeploymentResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("OpsWorks")]
        public void CreateInstanceMarshallTest()
        {
            var request = InstantiateClassGenerator.Execute<CreateInstanceRequest>();
            var marshaller = new CreateInstanceRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);                        
            Comparer.CompareObjectToJson<CreateInstanceRequest>(request,jsonRequest);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            var jsonResponse = new JsonSampleGenerator(service_model, service_model.FindOperation("CreateInstance").ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString());
            UnmarshallerContext context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), false, webResponse);
            var response = CreateInstanceResponseUnmarshaller.Instance.Unmarshall(context)
                as CreateInstanceResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("OpsWorks")]
        public void CreateLayerMarshallTest()
        {
            var request = InstantiateClassGenerator.Execute<CreateLayerRequest>();
            var marshaller = new CreateLayerRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);                        
            Comparer.CompareObjectToJson<CreateLayerRequest>(request,jsonRequest);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            var jsonResponse = new JsonSampleGenerator(service_model, service_model.FindOperation("CreateLayer").ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString());
            UnmarshallerContext context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), false, webResponse);
            var response = CreateLayerResponseUnmarshaller.Instance.Unmarshall(context)
                as CreateLayerResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("OpsWorks")]
        public void CreateStackMarshallTest()
        {
            var request = InstantiateClassGenerator.Execute<CreateStackRequest>();
            var marshaller = new CreateStackRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);                        
            Comparer.CompareObjectToJson<CreateStackRequest>(request,jsonRequest);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            var jsonResponse = new JsonSampleGenerator(service_model, service_model.FindOperation("CreateStack").ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString());
            UnmarshallerContext context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), false, webResponse);
            var response = CreateStackResponseUnmarshaller.Instance.Unmarshall(context)
                as CreateStackResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("OpsWorks")]
        public void CreateUserProfileMarshallTest()
        {
            var request = InstantiateClassGenerator.Execute<CreateUserProfileRequest>();
            var marshaller = new CreateUserProfileRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);                        
            Comparer.CompareObjectToJson<CreateUserProfileRequest>(request,jsonRequest);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            var jsonResponse = new JsonSampleGenerator(service_model, service_model.FindOperation("CreateUserProfile").ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString());
            UnmarshallerContext context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), false, webResponse);
            var response = CreateUserProfileResponseUnmarshaller.Instance.Unmarshall(context)
                as CreateUserProfileResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("OpsWorks")]
        public void DeleteAppMarshallTest()
        {
            var request = InstantiateClassGenerator.Execute<DeleteAppRequest>();
            var marshaller = new DeleteAppRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);                        
            Comparer.CompareObjectToJson<DeleteAppRequest>(request,jsonRequest);

        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("OpsWorks")]
        public void DeleteInstanceMarshallTest()
        {
            var request = InstantiateClassGenerator.Execute<DeleteInstanceRequest>();
            var marshaller = new DeleteInstanceRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);                        
            Comparer.CompareObjectToJson<DeleteInstanceRequest>(request,jsonRequest);

        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("OpsWorks")]
        public void DeleteLayerMarshallTest()
        {
            var request = InstantiateClassGenerator.Execute<DeleteLayerRequest>();
            var marshaller = new DeleteLayerRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);                        
            Comparer.CompareObjectToJson<DeleteLayerRequest>(request,jsonRequest);

        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("OpsWorks")]
        public void DeleteStackMarshallTest()
        {
            var request = InstantiateClassGenerator.Execute<DeleteStackRequest>();
            var marshaller = new DeleteStackRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);                        
            Comparer.CompareObjectToJson<DeleteStackRequest>(request,jsonRequest);

        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("OpsWorks")]
        public void DeleteUserProfileMarshallTest()
        {
            var request = InstantiateClassGenerator.Execute<DeleteUserProfileRequest>();
            var marshaller = new DeleteUserProfileRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);                        
            Comparer.CompareObjectToJson<DeleteUserProfileRequest>(request,jsonRequest);

        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("OpsWorks")]
        public void DeregisterEcsClusterMarshallTest()
        {
            var request = InstantiateClassGenerator.Execute<DeregisterEcsClusterRequest>();
            var marshaller = new DeregisterEcsClusterRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);                        
            Comparer.CompareObjectToJson<DeregisterEcsClusterRequest>(request,jsonRequest);

        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("OpsWorks")]
        public void DeregisterElasticIpMarshallTest()
        {
            var request = InstantiateClassGenerator.Execute<DeregisterElasticIpRequest>();
            var marshaller = new DeregisterElasticIpRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);                        
            Comparer.CompareObjectToJson<DeregisterElasticIpRequest>(request,jsonRequest);

        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("OpsWorks")]
        public void DeregisterInstanceMarshallTest()
        {
            var request = InstantiateClassGenerator.Execute<DeregisterInstanceRequest>();
            var marshaller = new DeregisterInstanceRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);                        
            Comparer.CompareObjectToJson<DeregisterInstanceRequest>(request,jsonRequest);

        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("OpsWorks")]
        public void DeregisterRdsDbInstanceMarshallTest()
        {
            var request = InstantiateClassGenerator.Execute<DeregisterRdsDbInstanceRequest>();
            var marshaller = new DeregisterRdsDbInstanceRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);                        
            Comparer.CompareObjectToJson<DeregisterRdsDbInstanceRequest>(request,jsonRequest);

        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("OpsWorks")]
        public void DeregisterVolumeMarshallTest()
        {
            var request = InstantiateClassGenerator.Execute<DeregisterVolumeRequest>();
            var marshaller = new DeregisterVolumeRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);                        
            Comparer.CompareObjectToJson<DeregisterVolumeRequest>(request,jsonRequest);

        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("OpsWorks")]
        public void DescribeAgentVersionsMarshallTest()
        {
            var request = InstantiateClassGenerator.Execute<DescribeAgentVersionsRequest>();
            var marshaller = new DescribeAgentVersionsRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);                        
            Comparer.CompareObjectToJson<DescribeAgentVersionsRequest>(request,jsonRequest);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            var jsonResponse = new JsonSampleGenerator(service_model, service_model.FindOperation("DescribeAgentVersions").ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString());
            UnmarshallerContext context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), false, webResponse);
            var response = DescribeAgentVersionsResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeAgentVersionsResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("OpsWorks")]
        public void DescribeAppsMarshallTest()
        {
            var request = InstantiateClassGenerator.Execute<DescribeAppsRequest>();
            var marshaller = new DescribeAppsRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);                        
            Comparer.CompareObjectToJson<DescribeAppsRequest>(request,jsonRequest);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            var jsonResponse = new JsonSampleGenerator(service_model, service_model.FindOperation("DescribeApps").ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString());
            UnmarshallerContext context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), false, webResponse);
            var response = DescribeAppsResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeAppsResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("OpsWorks")]
        public void DescribeCommandsMarshallTest()
        {
            var request = InstantiateClassGenerator.Execute<DescribeCommandsRequest>();
            var marshaller = new DescribeCommandsRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);                        
            Comparer.CompareObjectToJson<DescribeCommandsRequest>(request,jsonRequest);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            var jsonResponse = new JsonSampleGenerator(service_model, service_model.FindOperation("DescribeCommands").ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString());
            UnmarshallerContext context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), false, webResponse);
            var response = DescribeCommandsResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeCommandsResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("OpsWorks")]
        public void DescribeDeploymentsMarshallTest()
        {
            var request = InstantiateClassGenerator.Execute<DescribeDeploymentsRequest>();
            var marshaller = new DescribeDeploymentsRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);                        
            Comparer.CompareObjectToJson<DescribeDeploymentsRequest>(request,jsonRequest);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            var jsonResponse = new JsonSampleGenerator(service_model, service_model.FindOperation("DescribeDeployments").ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString());
            UnmarshallerContext context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), false, webResponse);
            var response = DescribeDeploymentsResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeDeploymentsResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("OpsWorks")]
        public void DescribeEcsClustersMarshallTest()
        {
            var request = InstantiateClassGenerator.Execute<DescribeEcsClustersRequest>();
            var marshaller = new DescribeEcsClustersRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);                        
            Comparer.CompareObjectToJson<DescribeEcsClustersRequest>(request,jsonRequest);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            var jsonResponse = new JsonSampleGenerator(service_model, service_model.FindOperation("DescribeEcsClusters").ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString());
            UnmarshallerContext context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), false, webResponse);
            var response = DescribeEcsClustersResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeEcsClustersResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("OpsWorks")]
        public void DescribeElasticIpsMarshallTest()
        {
            var request = InstantiateClassGenerator.Execute<DescribeElasticIpsRequest>();
            var marshaller = new DescribeElasticIpsRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);                        
            Comparer.CompareObjectToJson<DescribeElasticIpsRequest>(request,jsonRequest);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            var jsonResponse = new JsonSampleGenerator(service_model, service_model.FindOperation("DescribeElasticIps").ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString());
            UnmarshallerContext context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), false, webResponse);
            var response = DescribeElasticIpsResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeElasticIpsResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("OpsWorks")]
        public void DescribeElasticLoadBalancersMarshallTest()
        {
            var request = InstantiateClassGenerator.Execute<DescribeElasticLoadBalancersRequest>();
            var marshaller = new DescribeElasticLoadBalancersRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);                        
            Comparer.CompareObjectToJson<DescribeElasticLoadBalancersRequest>(request,jsonRequest);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            var jsonResponse = new JsonSampleGenerator(service_model, service_model.FindOperation("DescribeElasticLoadBalancers").ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString());
            UnmarshallerContext context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), false, webResponse);
            var response = DescribeElasticLoadBalancersResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeElasticLoadBalancersResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("OpsWorks")]
        public void DescribeInstancesMarshallTest()
        {
            var request = InstantiateClassGenerator.Execute<DescribeInstancesRequest>();
            var marshaller = new DescribeInstancesRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);                        
            Comparer.CompareObjectToJson<DescribeInstancesRequest>(request,jsonRequest);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            var jsonResponse = new JsonSampleGenerator(service_model, service_model.FindOperation("DescribeInstances").ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString());
            UnmarshallerContext context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), false, webResponse);
            var response = DescribeInstancesResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeInstancesResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("OpsWorks")]
        public void DescribeLayersMarshallTest()
        {
            var request = InstantiateClassGenerator.Execute<DescribeLayersRequest>();
            var marshaller = new DescribeLayersRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);                        
            Comparer.CompareObjectToJson<DescribeLayersRequest>(request,jsonRequest);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            var jsonResponse = new JsonSampleGenerator(service_model, service_model.FindOperation("DescribeLayers").ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString());
            UnmarshallerContext context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), false, webResponse);
            var response = DescribeLayersResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeLayersResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("OpsWorks")]
        public void DescribeLoadBasedAutoScalingMarshallTest()
        {
            var request = InstantiateClassGenerator.Execute<DescribeLoadBasedAutoScalingRequest>();
            var marshaller = new DescribeLoadBasedAutoScalingRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);                        
            Comparer.CompareObjectToJson<DescribeLoadBasedAutoScalingRequest>(request,jsonRequest);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            var jsonResponse = new JsonSampleGenerator(service_model, service_model.FindOperation("DescribeLoadBasedAutoScaling").ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString());
            UnmarshallerContext context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), false, webResponse);
            var response = DescribeLoadBasedAutoScalingResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeLoadBasedAutoScalingResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("OpsWorks")]
        public void DescribeMyUserProfileMarshallTest()
        {
            var request = InstantiateClassGenerator.Execute<DescribeMyUserProfileRequest>();
            var marshaller = new DescribeMyUserProfileRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            var jsonResponse = new JsonSampleGenerator(service_model, service_model.FindOperation("DescribeMyUserProfile").ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString());
            UnmarshallerContext context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), false, webResponse);
            var response = DescribeMyUserProfileResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeMyUserProfileResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("OpsWorks")]
        public void DescribePermissionsMarshallTest()
        {
            var request = InstantiateClassGenerator.Execute<DescribePermissionsRequest>();
            var marshaller = new DescribePermissionsRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);                        
            Comparer.CompareObjectToJson<DescribePermissionsRequest>(request,jsonRequest);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            var jsonResponse = new JsonSampleGenerator(service_model, service_model.FindOperation("DescribePermissions").ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString());
            UnmarshallerContext context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), false, webResponse);
            var response = DescribePermissionsResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribePermissionsResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("OpsWorks")]
        public void DescribeRaidArraysMarshallTest()
        {
            var request = InstantiateClassGenerator.Execute<DescribeRaidArraysRequest>();
            var marshaller = new DescribeRaidArraysRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);                        
            Comparer.CompareObjectToJson<DescribeRaidArraysRequest>(request,jsonRequest);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            var jsonResponse = new JsonSampleGenerator(service_model, service_model.FindOperation("DescribeRaidArrays").ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString());
            UnmarshallerContext context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), false, webResponse);
            var response = DescribeRaidArraysResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeRaidArraysResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("OpsWorks")]
        public void DescribeRdsDbInstancesMarshallTest()
        {
            var request = InstantiateClassGenerator.Execute<DescribeRdsDbInstancesRequest>();
            var marshaller = new DescribeRdsDbInstancesRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);                        
            Comparer.CompareObjectToJson<DescribeRdsDbInstancesRequest>(request,jsonRequest);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            var jsonResponse = new JsonSampleGenerator(service_model, service_model.FindOperation("DescribeRdsDbInstances").ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString());
            UnmarshallerContext context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), false, webResponse);
            var response = DescribeRdsDbInstancesResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeRdsDbInstancesResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("OpsWorks")]
        public void DescribeServiceErrorsMarshallTest()
        {
            var request = InstantiateClassGenerator.Execute<DescribeServiceErrorsRequest>();
            var marshaller = new DescribeServiceErrorsRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);                        
            Comparer.CompareObjectToJson<DescribeServiceErrorsRequest>(request,jsonRequest);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            var jsonResponse = new JsonSampleGenerator(service_model, service_model.FindOperation("DescribeServiceErrors").ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString());
            UnmarshallerContext context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), false, webResponse);
            var response = DescribeServiceErrorsResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeServiceErrorsResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("OpsWorks")]
        public void DescribeStackProvisioningParametersMarshallTest()
        {
            var request = InstantiateClassGenerator.Execute<DescribeStackProvisioningParametersRequest>();
            var marshaller = new DescribeStackProvisioningParametersRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);                        
            Comparer.CompareObjectToJson<DescribeStackProvisioningParametersRequest>(request,jsonRequest);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            var jsonResponse = new JsonSampleGenerator(service_model, service_model.FindOperation("DescribeStackProvisioningParameters").ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString());
            UnmarshallerContext context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), false, webResponse);
            var response = DescribeStackProvisioningParametersResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeStackProvisioningParametersResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("OpsWorks")]
        public void DescribeStacksMarshallTest()
        {
            var request = InstantiateClassGenerator.Execute<DescribeStacksRequest>();
            var marshaller = new DescribeStacksRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);                        
            Comparer.CompareObjectToJson<DescribeStacksRequest>(request,jsonRequest);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            var jsonResponse = new JsonSampleGenerator(service_model, service_model.FindOperation("DescribeStacks").ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString());
            UnmarshallerContext context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), false, webResponse);
            var response = DescribeStacksResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeStacksResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("OpsWorks")]
        public void DescribeStackSummaryMarshallTest()
        {
            var request = InstantiateClassGenerator.Execute<DescribeStackSummaryRequest>();
            var marshaller = new DescribeStackSummaryRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);                        
            Comparer.CompareObjectToJson<DescribeStackSummaryRequest>(request,jsonRequest);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            var jsonResponse = new JsonSampleGenerator(service_model, service_model.FindOperation("DescribeStackSummary").ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString());
            UnmarshallerContext context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), false, webResponse);
            var response = DescribeStackSummaryResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeStackSummaryResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("OpsWorks")]
        public void DescribeTimeBasedAutoScalingMarshallTest()
        {
            var request = InstantiateClassGenerator.Execute<DescribeTimeBasedAutoScalingRequest>();
            var marshaller = new DescribeTimeBasedAutoScalingRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);                        
            Comparer.CompareObjectToJson<DescribeTimeBasedAutoScalingRequest>(request,jsonRequest);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            var jsonResponse = new JsonSampleGenerator(service_model, service_model.FindOperation("DescribeTimeBasedAutoScaling").ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString());
            UnmarshallerContext context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), false, webResponse);
            var response = DescribeTimeBasedAutoScalingResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeTimeBasedAutoScalingResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("OpsWorks")]
        public void DescribeUserProfilesMarshallTest()
        {
            var request = InstantiateClassGenerator.Execute<DescribeUserProfilesRequest>();
            var marshaller = new DescribeUserProfilesRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);                        
            Comparer.CompareObjectToJson<DescribeUserProfilesRequest>(request,jsonRequest);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            var jsonResponse = new JsonSampleGenerator(service_model, service_model.FindOperation("DescribeUserProfiles").ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString());
            UnmarshallerContext context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), false, webResponse);
            var response = DescribeUserProfilesResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeUserProfilesResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("OpsWorks")]
        public void DescribeVolumesMarshallTest()
        {
            var request = InstantiateClassGenerator.Execute<DescribeVolumesRequest>();
            var marshaller = new DescribeVolumesRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);                        
            Comparer.CompareObjectToJson<DescribeVolumesRequest>(request,jsonRequest);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            var jsonResponse = new JsonSampleGenerator(service_model, service_model.FindOperation("DescribeVolumes").ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString());
            UnmarshallerContext context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), false, webResponse);
            var response = DescribeVolumesResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeVolumesResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("OpsWorks")]
        public void DetachElasticLoadBalancerMarshallTest()
        {
            var request = InstantiateClassGenerator.Execute<DetachElasticLoadBalancerRequest>();
            var marshaller = new DetachElasticLoadBalancerRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);                        
            Comparer.CompareObjectToJson<DetachElasticLoadBalancerRequest>(request,jsonRequest);

        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("OpsWorks")]
        public void DisassociateElasticIpMarshallTest()
        {
            var request = InstantiateClassGenerator.Execute<DisassociateElasticIpRequest>();
            var marshaller = new DisassociateElasticIpRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);                        
            Comparer.CompareObjectToJson<DisassociateElasticIpRequest>(request,jsonRequest);

        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("OpsWorks")]
        public void GetHostnameSuggestionMarshallTest()
        {
            var request = InstantiateClassGenerator.Execute<GetHostnameSuggestionRequest>();
            var marshaller = new GetHostnameSuggestionRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);                        
            Comparer.CompareObjectToJson<GetHostnameSuggestionRequest>(request,jsonRequest);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            var jsonResponse = new JsonSampleGenerator(service_model, service_model.FindOperation("GetHostnameSuggestion").ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString());
            UnmarshallerContext context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), false, webResponse);
            var response = GetHostnameSuggestionResponseUnmarshaller.Instance.Unmarshall(context)
                as GetHostnameSuggestionResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("OpsWorks")]
        public void GrantAccessMarshallTest()
        {
            var request = InstantiateClassGenerator.Execute<GrantAccessRequest>();
            var marshaller = new GrantAccessRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);                        
            Comparer.CompareObjectToJson<GrantAccessRequest>(request,jsonRequest);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            var jsonResponse = new JsonSampleGenerator(service_model, service_model.FindOperation("GrantAccess").ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString());
            UnmarshallerContext context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), false, webResponse);
            var response = GrantAccessResponseUnmarshaller.Instance.Unmarshall(context)
                as GrantAccessResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("OpsWorks")]
        public void RebootInstanceMarshallTest()
        {
            var request = InstantiateClassGenerator.Execute<RebootInstanceRequest>();
            var marshaller = new RebootInstanceRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);                        
            Comparer.CompareObjectToJson<RebootInstanceRequest>(request,jsonRequest);

        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("OpsWorks")]
        public void RegisterEcsClusterMarshallTest()
        {
            var request = InstantiateClassGenerator.Execute<RegisterEcsClusterRequest>();
            var marshaller = new RegisterEcsClusterRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);                        
            Comparer.CompareObjectToJson<RegisterEcsClusterRequest>(request,jsonRequest);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            var jsonResponse = new JsonSampleGenerator(service_model, service_model.FindOperation("RegisterEcsCluster").ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString());
            UnmarshallerContext context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), false, webResponse);
            var response = RegisterEcsClusterResponseUnmarshaller.Instance.Unmarshall(context)
                as RegisterEcsClusterResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("OpsWorks")]
        public void RegisterElasticIpMarshallTest()
        {
            var request = InstantiateClassGenerator.Execute<RegisterElasticIpRequest>();
            var marshaller = new RegisterElasticIpRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);                        
            Comparer.CompareObjectToJson<RegisterElasticIpRequest>(request,jsonRequest);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            var jsonResponse = new JsonSampleGenerator(service_model, service_model.FindOperation("RegisterElasticIp").ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString());
            UnmarshallerContext context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), false, webResponse);
            var response = RegisterElasticIpResponseUnmarshaller.Instance.Unmarshall(context)
                as RegisterElasticIpResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("OpsWorks")]
        public void RegisterInstanceMarshallTest()
        {
            var request = InstantiateClassGenerator.Execute<RegisterInstanceRequest>();
            var marshaller = new RegisterInstanceRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);                        
            Comparer.CompareObjectToJson<RegisterInstanceRequest>(request,jsonRequest);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            var jsonResponse = new JsonSampleGenerator(service_model, service_model.FindOperation("RegisterInstance").ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString());
            UnmarshallerContext context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), false, webResponse);
            var response = RegisterInstanceResponseUnmarshaller.Instance.Unmarshall(context)
                as RegisterInstanceResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("OpsWorks")]
        public void RegisterRdsDbInstanceMarshallTest()
        {
            var request = InstantiateClassGenerator.Execute<RegisterRdsDbInstanceRequest>();
            var marshaller = new RegisterRdsDbInstanceRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);                        
            Comparer.CompareObjectToJson<RegisterRdsDbInstanceRequest>(request,jsonRequest);

        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("OpsWorks")]
        public void RegisterVolumeMarshallTest()
        {
            var request = InstantiateClassGenerator.Execute<RegisterVolumeRequest>();
            var marshaller = new RegisterVolumeRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);                        
            Comparer.CompareObjectToJson<RegisterVolumeRequest>(request,jsonRequest);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            var jsonResponse = new JsonSampleGenerator(service_model, service_model.FindOperation("RegisterVolume").ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString());
            UnmarshallerContext context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), false, webResponse);
            var response = RegisterVolumeResponseUnmarshaller.Instance.Unmarshall(context)
                as RegisterVolumeResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("OpsWorks")]
        public void SetLoadBasedAutoScalingMarshallTest()
        {
            var request = InstantiateClassGenerator.Execute<SetLoadBasedAutoScalingRequest>();
            var marshaller = new SetLoadBasedAutoScalingRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);                        
            Comparer.CompareObjectToJson<SetLoadBasedAutoScalingRequest>(request,jsonRequest);

        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("OpsWorks")]
        public void SetPermissionMarshallTest()
        {
            var request = InstantiateClassGenerator.Execute<SetPermissionRequest>();
            var marshaller = new SetPermissionRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);                        
            Comparer.CompareObjectToJson<SetPermissionRequest>(request,jsonRequest);

        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("OpsWorks")]
        public void SetTimeBasedAutoScalingMarshallTest()
        {
            var request = InstantiateClassGenerator.Execute<SetTimeBasedAutoScalingRequest>();
            var marshaller = new SetTimeBasedAutoScalingRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);                        
            Comparer.CompareObjectToJson<SetTimeBasedAutoScalingRequest>(request,jsonRequest);

        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("OpsWorks")]
        public void StartInstanceMarshallTest()
        {
            var request = InstantiateClassGenerator.Execute<StartInstanceRequest>();
            var marshaller = new StartInstanceRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);                        
            Comparer.CompareObjectToJson<StartInstanceRequest>(request,jsonRequest);

        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("OpsWorks")]
        public void StartStackMarshallTest()
        {
            var request = InstantiateClassGenerator.Execute<StartStackRequest>();
            var marshaller = new StartStackRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);                        
            Comparer.CompareObjectToJson<StartStackRequest>(request,jsonRequest);

        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("OpsWorks")]
        public void StopInstanceMarshallTest()
        {
            var request = InstantiateClassGenerator.Execute<StopInstanceRequest>();
            var marshaller = new StopInstanceRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);                        
            Comparer.CompareObjectToJson<StopInstanceRequest>(request,jsonRequest);

        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("OpsWorks")]
        public void StopStackMarshallTest()
        {
            var request = InstantiateClassGenerator.Execute<StopStackRequest>();
            var marshaller = new StopStackRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);                        
            Comparer.CompareObjectToJson<StopStackRequest>(request,jsonRequest);

        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("OpsWorks")]
        public void UnassignInstanceMarshallTest()
        {
            var request = InstantiateClassGenerator.Execute<UnassignInstanceRequest>();
            var marshaller = new UnassignInstanceRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);                        
            Comparer.CompareObjectToJson<UnassignInstanceRequest>(request,jsonRequest);

        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("OpsWorks")]
        public void UnassignVolumeMarshallTest()
        {
            var request = InstantiateClassGenerator.Execute<UnassignVolumeRequest>();
            var marshaller = new UnassignVolumeRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);                        
            Comparer.CompareObjectToJson<UnassignVolumeRequest>(request,jsonRequest);

        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("OpsWorks")]
        public void UpdateAppMarshallTest()
        {
            var request = InstantiateClassGenerator.Execute<UpdateAppRequest>();
            var marshaller = new UpdateAppRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);                        
            Comparer.CompareObjectToJson<UpdateAppRequest>(request,jsonRequest);

        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("OpsWorks")]
        public void UpdateElasticIpMarshallTest()
        {
            var request = InstantiateClassGenerator.Execute<UpdateElasticIpRequest>();
            var marshaller = new UpdateElasticIpRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);                        
            Comparer.CompareObjectToJson<UpdateElasticIpRequest>(request,jsonRequest);

        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("OpsWorks")]
        public void UpdateInstanceMarshallTest()
        {
            var request = InstantiateClassGenerator.Execute<UpdateInstanceRequest>();
            var marshaller = new UpdateInstanceRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);                        
            Comparer.CompareObjectToJson<UpdateInstanceRequest>(request,jsonRequest);

        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("OpsWorks")]
        public void UpdateLayerMarshallTest()
        {
            var request = InstantiateClassGenerator.Execute<UpdateLayerRequest>();
            var marshaller = new UpdateLayerRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);                        
            Comparer.CompareObjectToJson<UpdateLayerRequest>(request,jsonRequest);

        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("OpsWorks")]
        public void UpdateMyUserProfileMarshallTest()
        {
            var request = InstantiateClassGenerator.Execute<UpdateMyUserProfileRequest>();
            var marshaller = new UpdateMyUserProfileRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);                        
            Comparer.CompareObjectToJson<UpdateMyUserProfileRequest>(request,jsonRequest);

        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("OpsWorks")]
        public void UpdateRdsDbInstanceMarshallTest()
        {
            var request = InstantiateClassGenerator.Execute<UpdateRdsDbInstanceRequest>();
            var marshaller = new UpdateRdsDbInstanceRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);                        
            Comparer.CompareObjectToJson<UpdateRdsDbInstanceRequest>(request,jsonRequest);

        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("OpsWorks")]
        public void UpdateStackMarshallTest()
        {
            var request = InstantiateClassGenerator.Execute<UpdateStackRequest>();
            var marshaller = new UpdateStackRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);                        
            Comparer.CompareObjectToJson<UpdateStackRequest>(request,jsonRequest);

        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("OpsWorks")]
        public void UpdateUserProfileMarshallTest()
        {
            var request = InstantiateClassGenerator.Execute<UpdateUserProfileRequest>();
            var marshaller = new UpdateUserProfileRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);                        
            Comparer.CompareObjectToJson<UpdateUserProfileRequest>(request,jsonRequest);

        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("OpsWorks")]
        public void UpdateVolumeMarshallTest()
        {
            var request = InstantiateClassGenerator.Execute<UpdateVolumeRequest>();
            var marshaller = new UpdateVolumeRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);                        
            Comparer.CompareObjectToJson<UpdateVolumeRequest>(request,jsonRequest);

        }

            }
}