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
 * Do not modify this file. This file is generated from the cloudfront-2016-01-28.normal.json service model.
 */


using System;
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
        static readonly ServiceModel service_model = Utils.LoadServiceModel("cloudfront-2016-01-28.normal.json", "cloudfront.customizations.json");
        
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
            RequestValidator.Validate("CreateCloudFrontOriginAccessIdentity", request, internalRequest, service_model);            

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
            RequestValidator.Validate("CreateDistribution", request, internalRequest, service_model);            

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
        public void CreateInvalidationMarshallTest()
        {
            var operation = service_model.FindOperation("CreateInvalidation");

            var request = InstantiateClassGenerator.Execute<CreateInvalidationRequest>();
            var marshaller = new CreateInvalidationRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            RequestValidator.Validate("CreateInvalidation", request, internalRequest, service_model);            

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
        public void CreateStreamingDistributionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateStreamingDistribution");

            var request = InstantiateClassGenerator.Execute<CreateStreamingDistributionRequest>();
            var marshaller = new CreateStreamingDistributionRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            RequestValidator.Validate("CreateStreamingDistribution", request, internalRequest, service_model);            

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
        public void DeleteCloudFrontOriginAccessIdentityMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteCloudFrontOriginAccessIdentity");

            var request = InstantiateClassGenerator.Execute<DeleteCloudFrontOriginAccessIdentityRequest>();
            var marshaller = new DeleteCloudFrontOriginAccessIdentityRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            RequestValidator.Validate("DeleteCloudFrontOriginAccessIdentity", request, internalRequest, service_model);            

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
            RequestValidator.Validate("DeleteDistribution", request, internalRequest, service_model);            

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
            RequestValidator.Validate("DeleteStreamingDistribution", request, internalRequest, service_model);            

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
            RequestValidator.Validate("GetCloudFrontOriginAccessIdentity", request, internalRequest, service_model);            

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
            RequestValidator.Validate("GetCloudFrontOriginAccessIdentityConfig", request, internalRequest, service_model);            

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
            RequestValidator.Validate("GetDistribution", request, internalRequest, service_model);            

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
            RequestValidator.Validate("GetDistributionConfig", request, internalRequest, service_model);            

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
        public void GetInvalidationMarshallTest()
        {
            var operation = service_model.FindOperation("GetInvalidation");

            var request = InstantiateClassGenerator.Execute<GetInvalidationRequest>();
            var marshaller = new GetInvalidationRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            RequestValidator.Validate("GetInvalidation", request, internalRequest, service_model);            

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
        public void GetStreamingDistributionMarshallTest()
        {
            var operation = service_model.FindOperation("GetStreamingDistribution");

            var request = InstantiateClassGenerator.Execute<GetStreamingDistributionRequest>();
            var marshaller = new GetStreamingDistributionRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            RequestValidator.Validate("GetStreamingDistribution", request, internalRequest, service_model);            

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
            RequestValidator.Validate("GetStreamingDistributionConfig", request, internalRequest, service_model);            

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
            RequestValidator.Validate("ListCloudFrontOriginAccessIdentities", request, internalRequest, service_model);            

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
            RequestValidator.Validate("ListDistributions", request, internalRequest, service_model);            

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
            RequestValidator.Validate("ListDistributionsByWebACLId", request, internalRequest, service_model);            

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
        public void ListInvalidationsMarshallTest()
        {
            var operation = service_model.FindOperation("ListInvalidations");

            var request = InstantiateClassGenerator.Execute<ListInvalidationsRequest>();
            var marshaller = new ListInvalidationsRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            RequestValidator.Validate("ListInvalidations", request, internalRequest, service_model);            

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
        public void ListStreamingDistributionsMarshallTest()
        {
            var operation = service_model.FindOperation("ListStreamingDistributions");

            var request = InstantiateClassGenerator.Execute<ListStreamingDistributionsRequest>();
            var marshaller = new ListStreamingDistributionsRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            RequestValidator.Validate("ListStreamingDistributions", request, internalRequest, service_model);            

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
        public void UpdateCloudFrontOriginAccessIdentityMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateCloudFrontOriginAccessIdentity");

            var request = InstantiateClassGenerator.Execute<UpdateCloudFrontOriginAccessIdentityRequest>();
            var marshaller = new UpdateCloudFrontOriginAccessIdentityRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            RequestValidator.Validate("UpdateCloudFrontOriginAccessIdentity", request, internalRequest, service_model);            

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
            RequestValidator.Validate("UpdateDistribution", request, internalRequest, service_model);            

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
        public void UpdateStreamingDistributionMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateStreamingDistribution");

            var request = InstantiateClassGenerator.Execute<UpdateStreamingDistributionRequest>();
            var marshaller = new UpdateStreamingDistributionRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            RequestValidator.Validate("UpdateStreamingDistribution", request, internalRequest, service_model);            

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