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
 * Do not modify this file. This file is generated from the cloudfront-2017-10-30.normal.json service model.
 */


using System;
using System.Globalization;
using System.IO;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Amazon.CloudFront;
using Amazon.CloudFront.Model;
using Amazon.CloudFront.Model.Internal.MarshallTransformations;
using Amazon.Runtime.Internal.Transform;
using Amazon.Util;
using ServiceClientGenerator;

using AWSSDK_DotNet35.UnitTests.TestTools;

namespace AWSSDK_DotNet35.UnitTests.Marshalling
{
    [TestClass]
    public partial class CloudFrontMarshallingTests
    {
        static readonly ServiceModel service_model = Utils.LoadServiceModel("cloudfront");
        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void CreateCloudFrontOriginAccessIdentityMarshallTest()
        {
            var operation = service_model.FindOperation("CreateCloudFrontOriginAccessIdentity");

            var request = InstantiateClassGenerator.Execute<CreateCloudFrontOriginAccessIdentityRequest>();
            var marshaller = new CreateCloudFrontOriginAccessIdentityRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("CreateCloudFrontOriginAccessIdentity", request, internalRequest, service_model);            

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"Location","Location_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();            
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = CreateCloudFrontOriginAccessIdentityResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as CreateCloudFrontOriginAccessIdentityResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void CreateDistributionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateDistribution");

            var request = InstantiateClassGenerator.Execute<CreateDistributionRequest>();
            var marshaller = new CreateDistributionRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("CreateDistribution", request, internalRequest, service_model);            

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"Location","Location_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();            
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = CreateDistributionResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as CreateDistributionResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void CreateDistributionWithTagsMarshallTest()
        {
            var operation = service_model.FindOperation("CreateDistributionWithTags");

            var request = InstantiateClassGenerator.Execute<CreateDistributionWithTagsRequest>();
            var marshaller = new CreateDistributionWithTagsRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("CreateDistributionWithTags", request, internalRequest, service_model);            

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"Location","Location_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();            
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = CreateDistributionWithTagsResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as CreateDistributionWithTagsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void CreateFieldLevelEncryptionConfigMarshallTest()
        {
            var operation = service_model.FindOperation("CreateFieldLevelEncryptionConfig");

            var request = InstantiateClassGenerator.Execute<CreateFieldLevelEncryptionConfigRequest>();
            var marshaller = new CreateFieldLevelEncryptionConfigRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("CreateFieldLevelEncryptionConfig", request, internalRequest, service_model);            

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"Location","Location_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();            
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = CreateFieldLevelEncryptionConfigResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as CreateFieldLevelEncryptionConfigResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void CreateFieldLevelEncryptionProfileMarshallTest()
        {
            var operation = service_model.FindOperation("CreateFieldLevelEncryptionProfile");

            var request = InstantiateClassGenerator.Execute<CreateFieldLevelEncryptionProfileRequest>();
            var marshaller = new CreateFieldLevelEncryptionProfileRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("CreateFieldLevelEncryptionProfile", request, internalRequest, service_model);            

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"Location","Location_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();            
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = CreateFieldLevelEncryptionProfileResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as CreateFieldLevelEncryptionProfileResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void CreateInvalidationMarshallTest()
        {
            var operation = service_model.FindOperation("CreateInvalidation");

            var request = InstantiateClassGenerator.Execute<CreateInvalidationRequest>();
            var marshaller = new CreateInvalidationRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("CreateInvalidation", request, internalRequest, service_model);            

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"Location","Location_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();            
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = CreateInvalidationResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as CreateInvalidationResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void CreatePublicKeyMarshallTest()
        {
            var operation = service_model.FindOperation("CreatePublicKey");

            var request = InstantiateClassGenerator.Execute<CreatePublicKeyRequest>();
            var marshaller = new CreatePublicKeyRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("CreatePublicKey", request, internalRequest, service_model);            

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"Location","Location_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();            
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = CreatePublicKeyResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as CreatePublicKeyResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void CreateStreamingDistributionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateStreamingDistribution");

            var request = InstantiateClassGenerator.Execute<CreateStreamingDistributionRequest>();
            var marshaller = new CreateStreamingDistributionRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("CreateStreamingDistribution", request, internalRequest, service_model);            

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"Location","Location_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();            
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = CreateStreamingDistributionResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as CreateStreamingDistributionResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void CreateStreamingDistributionWithTagsMarshallTest()
        {
            var operation = service_model.FindOperation("CreateStreamingDistributionWithTags");

            var request = InstantiateClassGenerator.Execute<CreateStreamingDistributionWithTagsRequest>();
            var marshaller = new CreateStreamingDistributionWithTagsRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("CreateStreamingDistributionWithTags", request, internalRequest, service_model);            

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"Location","Location_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();            
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = CreateStreamingDistributionWithTagsResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as CreateStreamingDistributionWithTagsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void DeleteCloudFrontOriginAccessIdentityMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteCloudFrontOriginAccessIdentity");

            var request = InstantiateClassGenerator.Execute<DeleteCloudFrontOriginAccessIdentityRequest>();
            var marshaller = new DeleteCloudFrontOriginAccessIdentityRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("DeleteCloudFrontOriginAccessIdentity", request, internalRequest, service_model);            

        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void DeleteDistributionMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteDistribution");

            var request = InstantiateClassGenerator.Execute<DeleteDistributionRequest>();
            var marshaller = new DeleteDistributionRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("DeleteDistribution", request, internalRequest, service_model);            

        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void DeleteFieldLevelEncryptionConfigMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteFieldLevelEncryptionConfig");

            var request = InstantiateClassGenerator.Execute<DeleteFieldLevelEncryptionConfigRequest>();
            var marshaller = new DeleteFieldLevelEncryptionConfigRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("DeleteFieldLevelEncryptionConfig", request, internalRequest, service_model);            

        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void DeleteFieldLevelEncryptionProfileMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteFieldLevelEncryptionProfile");

            var request = InstantiateClassGenerator.Execute<DeleteFieldLevelEncryptionProfileRequest>();
            var marshaller = new DeleteFieldLevelEncryptionProfileRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("DeleteFieldLevelEncryptionProfile", request, internalRequest, service_model);            

        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void DeletePublicKeyMarshallTest()
        {
            var operation = service_model.FindOperation("DeletePublicKey");

            var request = InstantiateClassGenerator.Execute<DeletePublicKeyRequest>();
            var marshaller = new DeletePublicKeyRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("DeletePublicKey", request, internalRequest, service_model);            

        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void DeleteServiceLinkedRoleMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteServiceLinkedRole");

            var request = InstantiateClassGenerator.Execute<DeleteServiceLinkedRoleRequest>();
            var marshaller = new DeleteServiceLinkedRoleRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("DeleteServiceLinkedRole", request, internalRequest, service_model);            

        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void DeleteStreamingDistributionMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteStreamingDistribution");

            var request = InstantiateClassGenerator.Execute<DeleteStreamingDistributionRequest>();
            var marshaller = new DeleteStreamingDistributionRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("DeleteStreamingDistribution", request, internalRequest, service_model);            

        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void GetCloudFrontOriginAccessIdentityMarshallTest()
        {
            var operation = service_model.FindOperation("GetCloudFrontOriginAccessIdentity");

            var request = InstantiateClassGenerator.Execute<GetCloudFrontOriginAccessIdentityRequest>();
            var marshaller = new GetCloudFrontOriginAccessIdentityRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("GetCloudFrontOriginAccessIdentity", request, internalRequest, service_model);            

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();            
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = GetCloudFrontOriginAccessIdentityResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as GetCloudFrontOriginAccessIdentityResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void GetCloudFrontOriginAccessIdentityConfigMarshallTest()
        {
            var operation = service_model.FindOperation("GetCloudFrontOriginAccessIdentityConfig");

            var request = InstantiateClassGenerator.Execute<GetCloudFrontOriginAccessIdentityConfigRequest>();
            var marshaller = new GetCloudFrontOriginAccessIdentityConfigRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("GetCloudFrontOriginAccessIdentityConfig", request, internalRequest, service_model);            

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();            
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = GetCloudFrontOriginAccessIdentityConfigResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as GetCloudFrontOriginAccessIdentityConfigResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void GetDistributionMarshallTest()
        {
            var operation = service_model.FindOperation("GetDistribution");

            var request = InstantiateClassGenerator.Execute<GetDistributionRequest>();
            var marshaller = new GetDistributionRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("GetDistribution", request, internalRequest, service_model);            

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();            
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = GetDistributionResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as GetDistributionResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void GetDistributionConfigMarshallTest()
        {
            var operation = service_model.FindOperation("GetDistributionConfig");

            var request = InstantiateClassGenerator.Execute<GetDistributionConfigRequest>();
            var marshaller = new GetDistributionConfigRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("GetDistributionConfig", request, internalRequest, service_model);            

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();            
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = GetDistributionConfigResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as GetDistributionConfigResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void GetFieldLevelEncryptionMarshallTest()
        {
            var operation = service_model.FindOperation("GetFieldLevelEncryption");

            var request = InstantiateClassGenerator.Execute<GetFieldLevelEncryptionRequest>();
            var marshaller = new GetFieldLevelEncryptionRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("GetFieldLevelEncryption", request, internalRequest, service_model);            

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();            
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = GetFieldLevelEncryptionResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as GetFieldLevelEncryptionResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void GetFieldLevelEncryptionConfigMarshallTest()
        {
            var operation = service_model.FindOperation("GetFieldLevelEncryptionConfig");

            var request = InstantiateClassGenerator.Execute<GetFieldLevelEncryptionConfigRequest>();
            var marshaller = new GetFieldLevelEncryptionConfigRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("GetFieldLevelEncryptionConfig", request, internalRequest, service_model);            

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();            
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = GetFieldLevelEncryptionConfigResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as GetFieldLevelEncryptionConfigResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void GetFieldLevelEncryptionProfileMarshallTest()
        {
            var operation = service_model.FindOperation("GetFieldLevelEncryptionProfile");

            var request = InstantiateClassGenerator.Execute<GetFieldLevelEncryptionProfileRequest>();
            var marshaller = new GetFieldLevelEncryptionProfileRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("GetFieldLevelEncryptionProfile", request, internalRequest, service_model);            

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();            
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = GetFieldLevelEncryptionProfileResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as GetFieldLevelEncryptionProfileResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void GetFieldLevelEncryptionProfileConfigMarshallTest()
        {
            var operation = service_model.FindOperation("GetFieldLevelEncryptionProfileConfig");

            var request = InstantiateClassGenerator.Execute<GetFieldLevelEncryptionProfileConfigRequest>();
            var marshaller = new GetFieldLevelEncryptionProfileConfigRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("GetFieldLevelEncryptionProfileConfig", request, internalRequest, service_model);            

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();            
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = GetFieldLevelEncryptionProfileConfigResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as GetFieldLevelEncryptionProfileConfigResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void GetInvalidationMarshallTest()
        {
            var operation = service_model.FindOperation("GetInvalidation");

            var request = InstantiateClassGenerator.Execute<GetInvalidationRequest>();
            var marshaller = new GetInvalidationRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("GetInvalidation", request, internalRequest, service_model);            

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();            
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = GetInvalidationResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as GetInvalidationResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void GetPublicKeyMarshallTest()
        {
            var operation = service_model.FindOperation("GetPublicKey");

            var request = InstantiateClassGenerator.Execute<GetPublicKeyRequest>();
            var marshaller = new GetPublicKeyRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("GetPublicKey", request, internalRequest, service_model);            

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();            
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = GetPublicKeyResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as GetPublicKeyResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void GetPublicKeyConfigMarshallTest()
        {
            var operation = service_model.FindOperation("GetPublicKeyConfig");

            var request = InstantiateClassGenerator.Execute<GetPublicKeyConfigRequest>();
            var marshaller = new GetPublicKeyConfigRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("GetPublicKeyConfig", request, internalRequest, service_model);            

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();            
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = GetPublicKeyConfigResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as GetPublicKeyConfigResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void GetStreamingDistributionMarshallTest()
        {
            var operation = service_model.FindOperation("GetStreamingDistribution");

            var request = InstantiateClassGenerator.Execute<GetStreamingDistributionRequest>();
            var marshaller = new GetStreamingDistributionRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("GetStreamingDistribution", request, internalRequest, service_model);            

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();            
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = GetStreamingDistributionResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as GetStreamingDistributionResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void GetStreamingDistributionConfigMarshallTest()
        {
            var operation = service_model.FindOperation("GetStreamingDistributionConfig");

            var request = InstantiateClassGenerator.Execute<GetStreamingDistributionConfigRequest>();
            var marshaller = new GetStreamingDistributionConfigRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("GetStreamingDistributionConfig", request, internalRequest, service_model);            

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();            
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = GetStreamingDistributionConfigResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as GetStreamingDistributionConfigResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void ListCloudFrontOriginAccessIdentitiesMarshallTest()
        {
            var operation = service_model.FindOperation("ListCloudFrontOriginAccessIdentities");

            var request = InstantiateClassGenerator.Execute<ListCloudFrontOriginAccessIdentitiesRequest>();
            var marshaller = new ListCloudFrontOriginAccessIdentitiesRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("ListCloudFrontOriginAccessIdentities", request, internalRequest, service_model);            

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();            
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = ListCloudFrontOriginAccessIdentitiesResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as ListCloudFrontOriginAccessIdentitiesResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void ListDistributionsMarshallTest()
        {
            var operation = service_model.FindOperation("ListDistributions");

            var request = InstantiateClassGenerator.Execute<ListDistributionsRequest>();
            var marshaller = new ListDistributionsRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("ListDistributions", request, internalRequest, service_model);            

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();            
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = ListDistributionsResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as ListDistributionsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void ListDistributionsByWebACLIdMarshallTest()
        {
            var operation = service_model.FindOperation("ListDistributionsByWebACLId");

            var request = InstantiateClassGenerator.Execute<ListDistributionsByWebACLIdRequest>();
            var marshaller = new ListDistributionsByWebACLIdRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("ListDistributionsByWebACLId", request, internalRequest, service_model);            

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();            
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = ListDistributionsByWebACLIdResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as ListDistributionsByWebACLIdResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void ListFieldLevelEncryptionConfigsMarshallTest()
        {
            var operation = service_model.FindOperation("ListFieldLevelEncryptionConfigs");

            var request = InstantiateClassGenerator.Execute<ListFieldLevelEncryptionConfigsRequest>();
            var marshaller = new ListFieldLevelEncryptionConfigsRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("ListFieldLevelEncryptionConfigs", request, internalRequest, service_model);            

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();            
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = ListFieldLevelEncryptionConfigsResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as ListFieldLevelEncryptionConfigsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void ListFieldLevelEncryptionProfilesMarshallTest()
        {
            var operation = service_model.FindOperation("ListFieldLevelEncryptionProfiles");

            var request = InstantiateClassGenerator.Execute<ListFieldLevelEncryptionProfilesRequest>();
            var marshaller = new ListFieldLevelEncryptionProfilesRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("ListFieldLevelEncryptionProfiles", request, internalRequest, service_model);            

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();            
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = ListFieldLevelEncryptionProfilesResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as ListFieldLevelEncryptionProfilesResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void ListInvalidationsMarshallTest()
        {
            var operation = service_model.FindOperation("ListInvalidations");

            var request = InstantiateClassGenerator.Execute<ListInvalidationsRequest>();
            var marshaller = new ListInvalidationsRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("ListInvalidations", request, internalRequest, service_model);            

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();            
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = ListInvalidationsResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as ListInvalidationsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void ListPublicKeysMarshallTest()
        {
            var operation = service_model.FindOperation("ListPublicKeys");

            var request = InstantiateClassGenerator.Execute<ListPublicKeysRequest>();
            var marshaller = new ListPublicKeysRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("ListPublicKeys", request, internalRequest, service_model);            

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();            
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = ListPublicKeysResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as ListPublicKeysResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void ListStreamingDistributionsMarshallTest()
        {
            var operation = service_model.FindOperation("ListStreamingDistributions");

            var request = InstantiateClassGenerator.Execute<ListStreamingDistributionsRequest>();
            var marshaller = new ListStreamingDistributionsRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("ListStreamingDistributions", request, internalRequest, service_model);            

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();            
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = ListStreamingDistributionsResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as ListStreamingDistributionsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void ListTagsForResourceMarshallTest()
        {
            var operation = service_model.FindOperation("ListTagsForResource");

            var request = InstantiateClassGenerator.Execute<ListTagsForResourceRequest>();
            var marshaller = new ListTagsForResourceRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("ListTagsForResource", request, internalRequest, service_model);            

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();            
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as ListTagsForResourceResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void TagResourceMarshallTest()
        {
            var operation = service_model.FindOperation("TagResource");

            var request = InstantiateClassGenerator.Execute<TagResourceRequest>();
            var marshaller = new TagResourceRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("TagResource", request, internalRequest, service_model);            

        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void UntagResourceMarshallTest()
        {
            var operation = service_model.FindOperation("UntagResource");

            var request = InstantiateClassGenerator.Execute<UntagResourceRequest>();
            var marshaller = new UntagResourceRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("UntagResource", request, internalRequest, service_model);            

        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void UpdateCloudFrontOriginAccessIdentityMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateCloudFrontOriginAccessIdentity");

            var request = InstantiateClassGenerator.Execute<UpdateCloudFrontOriginAccessIdentityRequest>();
            var marshaller = new UpdateCloudFrontOriginAccessIdentityRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("UpdateCloudFrontOriginAccessIdentity", request, internalRequest, service_model);            

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();            
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = UpdateCloudFrontOriginAccessIdentityResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as UpdateCloudFrontOriginAccessIdentityResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void UpdateDistributionMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateDistribution");

            var request = InstantiateClassGenerator.Execute<UpdateDistributionRequest>();
            var marshaller = new UpdateDistributionRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("UpdateDistribution", request, internalRequest, service_model);            

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();            
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = UpdateDistributionResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as UpdateDistributionResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void UpdateFieldLevelEncryptionConfigMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateFieldLevelEncryptionConfig");

            var request = InstantiateClassGenerator.Execute<UpdateFieldLevelEncryptionConfigRequest>();
            var marshaller = new UpdateFieldLevelEncryptionConfigRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("UpdateFieldLevelEncryptionConfig", request, internalRequest, service_model);            

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();            
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = UpdateFieldLevelEncryptionConfigResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as UpdateFieldLevelEncryptionConfigResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void UpdateFieldLevelEncryptionProfileMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateFieldLevelEncryptionProfile");

            var request = InstantiateClassGenerator.Execute<UpdateFieldLevelEncryptionProfileRequest>();
            var marshaller = new UpdateFieldLevelEncryptionProfileRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("UpdateFieldLevelEncryptionProfile", request, internalRequest, service_model);            

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();            
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = UpdateFieldLevelEncryptionProfileResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as UpdateFieldLevelEncryptionProfileResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void UpdatePublicKeyMarshallTest()
        {
            var operation = service_model.FindOperation("UpdatePublicKey");

            var request = InstantiateClassGenerator.Execute<UpdatePublicKeyRequest>();
            var marshaller = new UpdatePublicKeyRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("UpdatePublicKey", request, internalRequest, service_model);            

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();            
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = UpdatePublicKeyResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as UpdatePublicKeyResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void UpdateStreamingDistributionMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateStreamingDistribution");

            var request = InstantiateClassGenerator.Execute<UpdateStreamingDistributionRequest>();
            var marshaller = new UpdateStreamingDistributionRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("UpdateStreamingDistribution", request, internalRequest, service_model);            

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();            
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = UpdateStreamingDistributionResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as UpdateStreamingDistributionResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

            }
}