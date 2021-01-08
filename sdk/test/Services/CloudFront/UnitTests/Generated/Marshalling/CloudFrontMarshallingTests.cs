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

/*
 * Do not modify this file. This file is generated from the cloudfront-2020-05-31.normal.json service model.
 */


using System;
using System.Globalization;
using System.IO;
using System.Linq;
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
        public void CreateCachePolicyMarshallTest()
        {
            var operation = service_model.FindOperation("CreateCachePolicy");

            var request = InstantiateClassGenerator.Execute<CreateCachePolicyRequest>();
            var marshaller = new CreateCachePolicyRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("CreateCachePolicy", request, internalRequest, service_model);            

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
            webResponse.ContentLength = payloadResponse.Length;
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = CreateCachePolicyResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as CreateCachePolicyResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void CreateCachePolicy_AccessDeniedExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateCachePolicy");

            var request = InstantiateClassGenerator.Execute<CreateCachePolicyRequest>();
            var marshaller = new CreateCachePolicyRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("CreateCachePolicy", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("AccessDeniedException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"Location","Location_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = CreateCachePolicyResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void CreateCachePolicy_CachePolicyAlreadyExistsExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateCachePolicy");

            var request = InstantiateClassGenerator.Execute<CreateCachePolicyRequest>();
            var marshaller = new CreateCachePolicyRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("CreateCachePolicy", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("CachePolicyAlreadyExistsException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"Location","Location_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = CreateCachePolicyResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void CreateCachePolicy_InconsistentQuantitiesExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateCachePolicy");

            var request = InstantiateClassGenerator.Execute<CreateCachePolicyRequest>();
            var marshaller = new CreateCachePolicyRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("CreateCachePolicy", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InconsistentQuantitiesException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"Location","Location_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = CreateCachePolicyResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void CreateCachePolicy_InvalidArgumentExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateCachePolicy");

            var request = InstantiateClassGenerator.Execute<CreateCachePolicyRequest>();
            var marshaller = new CreateCachePolicyRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("CreateCachePolicy", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidArgumentException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"Location","Location_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = CreateCachePolicyResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void CreateCachePolicy_TooManyCachePoliciesExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateCachePolicy");

            var request = InstantiateClassGenerator.Execute<CreateCachePolicyRequest>();
            var marshaller = new CreateCachePolicyRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("CreateCachePolicy", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("TooManyCachePoliciesException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"Location","Location_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = CreateCachePolicyResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void CreateCachePolicy_TooManyCookiesInCachePolicyExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateCachePolicy");

            var request = InstantiateClassGenerator.Execute<CreateCachePolicyRequest>();
            var marshaller = new CreateCachePolicyRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("CreateCachePolicy", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("TooManyCookiesInCachePolicyException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"Location","Location_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = CreateCachePolicyResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void CreateCachePolicy_TooManyHeadersInCachePolicyExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateCachePolicy");

            var request = InstantiateClassGenerator.Execute<CreateCachePolicyRequest>();
            var marshaller = new CreateCachePolicyRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("CreateCachePolicy", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("TooManyHeadersInCachePolicyException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"Location","Location_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = CreateCachePolicyResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void CreateCachePolicy_TooManyQueryStringsInCachePolicyExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateCachePolicy");

            var request = InstantiateClassGenerator.Execute<CreateCachePolicyRequest>();
            var marshaller = new CreateCachePolicyRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("CreateCachePolicy", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("TooManyQueryStringsInCachePolicyException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"Location","Location_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = CreateCachePolicyResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

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
            webResponse.ContentLength = payloadResponse.Length;
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
        public void CreateCloudFrontOriginAccessIdentity_CloudFrontOriginAccessIdentityAlreadyExistsExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateCloudFrontOriginAccessIdentity");

            var request = InstantiateClassGenerator.Execute<CreateCloudFrontOriginAccessIdentityRequest>();
            var marshaller = new CreateCloudFrontOriginAccessIdentityRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("CreateCloudFrontOriginAccessIdentity", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("CloudFrontOriginAccessIdentityAlreadyExistsException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"Location","Location_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = CreateCloudFrontOriginAccessIdentityResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void CreateCloudFrontOriginAccessIdentity_InconsistentQuantitiesExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateCloudFrontOriginAccessIdentity");

            var request = InstantiateClassGenerator.Execute<CreateCloudFrontOriginAccessIdentityRequest>();
            var marshaller = new CreateCloudFrontOriginAccessIdentityRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("CreateCloudFrontOriginAccessIdentity", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InconsistentQuantitiesException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"Location","Location_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = CreateCloudFrontOriginAccessIdentityResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void CreateCloudFrontOriginAccessIdentity_InvalidArgumentExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateCloudFrontOriginAccessIdentity");

            var request = InstantiateClassGenerator.Execute<CreateCloudFrontOriginAccessIdentityRequest>();
            var marshaller = new CreateCloudFrontOriginAccessIdentityRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("CreateCloudFrontOriginAccessIdentity", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidArgumentException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"Location","Location_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = CreateCloudFrontOriginAccessIdentityResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void CreateCloudFrontOriginAccessIdentity_MissingBodyExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateCloudFrontOriginAccessIdentity");

            var request = InstantiateClassGenerator.Execute<CreateCloudFrontOriginAccessIdentityRequest>();
            var marshaller = new CreateCloudFrontOriginAccessIdentityRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("CreateCloudFrontOriginAccessIdentity", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("MissingBodyException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"Location","Location_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = CreateCloudFrontOriginAccessIdentityResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void CreateCloudFrontOriginAccessIdentity_TooManyCloudFrontOriginAccessIdentitiesExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateCloudFrontOriginAccessIdentity");

            var request = InstantiateClassGenerator.Execute<CreateCloudFrontOriginAccessIdentityRequest>();
            var marshaller = new CreateCloudFrontOriginAccessIdentityRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("CreateCloudFrontOriginAccessIdentity", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("TooManyCloudFrontOriginAccessIdentitiesException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"Location","Location_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = CreateCloudFrontOriginAccessIdentityResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

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
            webResponse.ContentLength = payloadResponse.Length;
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
        public void CreateDistribution_AccessDeniedExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateDistribution");

            var request = InstantiateClassGenerator.Execute<CreateDistributionRequest>();
            var marshaller = new CreateDistributionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("CreateDistribution", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("AccessDeniedException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"Location","Location_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = CreateDistributionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void CreateDistribution_CNAMEAlreadyExistsExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateDistribution");

            var request = InstantiateClassGenerator.Execute<CreateDistributionRequest>();
            var marshaller = new CreateDistributionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("CreateDistribution", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("CNAMEAlreadyExistsException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"Location","Location_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = CreateDistributionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void CreateDistribution_DistributionAlreadyExistsExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateDistribution");

            var request = InstantiateClassGenerator.Execute<CreateDistributionRequest>();
            var marshaller = new CreateDistributionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("CreateDistribution", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("DistributionAlreadyExistsException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"Location","Location_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = CreateDistributionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void CreateDistribution_IllegalFieldLevelEncryptionConfigAssociationWithCacheBehaviorExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateDistribution");

            var request = InstantiateClassGenerator.Execute<CreateDistributionRequest>();
            var marshaller = new CreateDistributionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("CreateDistribution", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("IllegalFieldLevelEncryptionConfigAssociationWithCacheBehaviorException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"Location","Location_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = CreateDistributionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void CreateDistribution_InconsistentQuantitiesExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateDistribution");

            var request = InstantiateClassGenerator.Execute<CreateDistributionRequest>();
            var marshaller = new CreateDistributionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("CreateDistribution", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InconsistentQuantitiesException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"Location","Location_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = CreateDistributionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void CreateDistribution_InvalidArgumentExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateDistribution");

            var request = InstantiateClassGenerator.Execute<CreateDistributionRequest>();
            var marshaller = new CreateDistributionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("CreateDistribution", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidArgumentException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"Location","Location_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = CreateDistributionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void CreateDistribution_InvalidDefaultRootObjectExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateDistribution");

            var request = InstantiateClassGenerator.Execute<CreateDistributionRequest>();
            var marshaller = new CreateDistributionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("CreateDistribution", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidDefaultRootObjectException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"Location","Location_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = CreateDistributionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void CreateDistribution_InvalidErrorCodeExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateDistribution");

            var request = InstantiateClassGenerator.Execute<CreateDistributionRequest>();
            var marshaller = new CreateDistributionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("CreateDistribution", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidErrorCodeException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"Location","Location_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = CreateDistributionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void CreateDistribution_InvalidForwardCookiesExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateDistribution");

            var request = InstantiateClassGenerator.Execute<CreateDistributionRequest>();
            var marshaller = new CreateDistributionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("CreateDistribution", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidForwardCookiesException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"Location","Location_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = CreateDistributionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void CreateDistribution_InvalidGeoRestrictionParameterExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateDistribution");

            var request = InstantiateClassGenerator.Execute<CreateDistributionRequest>();
            var marshaller = new CreateDistributionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("CreateDistribution", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidGeoRestrictionParameterException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"Location","Location_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = CreateDistributionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void CreateDistribution_InvalidHeadersForS3OriginExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateDistribution");

            var request = InstantiateClassGenerator.Execute<CreateDistributionRequest>();
            var marshaller = new CreateDistributionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("CreateDistribution", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidHeadersForS3OriginException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"Location","Location_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = CreateDistributionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void CreateDistribution_InvalidLambdaFunctionAssociationExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateDistribution");

            var request = InstantiateClassGenerator.Execute<CreateDistributionRequest>();
            var marshaller = new CreateDistributionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("CreateDistribution", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidLambdaFunctionAssociationException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"Location","Location_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = CreateDistributionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void CreateDistribution_InvalidLocationCodeExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateDistribution");

            var request = InstantiateClassGenerator.Execute<CreateDistributionRequest>();
            var marshaller = new CreateDistributionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("CreateDistribution", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidLocationCodeException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"Location","Location_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = CreateDistributionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void CreateDistribution_InvalidMinimumProtocolVersionExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateDistribution");

            var request = InstantiateClassGenerator.Execute<CreateDistributionRequest>();
            var marshaller = new CreateDistributionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("CreateDistribution", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidMinimumProtocolVersionException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"Location","Location_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = CreateDistributionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void CreateDistribution_InvalidOriginAccessIdentityExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateDistribution");

            var request = InstantiateClassGenerator.Execute<CreateDistributionRequest>();
            var marshaller = new CreateDistributionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("CreateDistribution", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidOriginAccessIdentityException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"Location","Location_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = CreateDistributionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void CreateDistribution_InvalidOriginExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateDistribution");

            var request = InstantiateClassGenerator.Execute<CreateDistributionRequest>();
            var marshaller = new CreateDistributionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("CreateDistribution", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidOriginException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"Location","Location_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = CreateDistributionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void CreateDistribution_InvalidOriginKeepaliveTimeoutExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateDistribution");

            var request = InstantiateClassGenerator.Execute<CreateDistributionRequest>();
            var marshaller = new CreateDistributionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("CreateDistribution", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidOriginKeepaliveTimeoutException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"Location","Location_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = CreateDistributionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void CreateDistribution_InvalidOriginReadTimeoutExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateDistribution");

            var request = InstantiateClassGenerator.Execute<CreateDistributionRequest>();
            var marshaller = new CreateDistributionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("CreateDistribution", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidOriginReadTimeoutException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"Location","Location_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = CreateDistributionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void CreateDistribution_InvalidProtocolSettingsExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateDistribution");

            var request = InstantiateClassGenerator.Execute<CreateDistributionRequest>();
            var marshaller = new CreateDistributionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("CreateDistribution", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidProtocolSettingsException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"Location","Location_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = CreateDistributionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void CreateDistribution_InvalidQueryStringParametersExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateDistribution");

            var request = InstantiateClassGenerator.Execute<CreateDistributionRequest>();
            var marshaller = new CreateDistributionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("CreateDistribution", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidQueryStringParametersException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"Location","Location_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = CreateDistributionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void CreateDistribution_InvalidRelativePathExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateDistribution");

            var request = InstantiateClassGenerator.Execute<CreateDistributionRequest>();
            var marshaller = new CreateDistributionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("CreateDistribution", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidRelativePathException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"Location","Location_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = CreateDistributionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void CreateDistribution_InvalidRequiredProtocolExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateDistribution");

            var request = InstantiateClassGenerator.Execute<CreateDistributionRequest>();
            var marshaller = new CreateDistributionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("CreateDistribution", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidRequiredProtocolException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"Location","Location_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = CreateDistributionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void CreateDistribution_InvalidResponseCodeExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateDistribution");

            var request = InstantiateClassGenerator.Execute<CreateDistributionRequest>();
            var marshaller = new CreateDistributionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("CreateDistribution", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidResponseCodeException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"Location","Location_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = CreateDistributionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void CreateDistribution_InvalidTTLOrderExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateDistribution");

            var request = InstantiateClassGenerator.Execute<CreateDistributionRequest>();
            var marshaller = new CreateDistributionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("CreateDistribution", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidTTLOrderException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"Location","Location_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = CreateDistributionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void CreateDistribution_InvalidViewerCertificateExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateDistribution");

            var request = InstantiateClassGenerator.Execute<CreateDistributionRequest>();
            var marshaller = new CreateDistributionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("CreateDistribution", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidViewerCertificateException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"Location","Location_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = CreateDistributionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void CreateDistribution_InvalidWebACLIdExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateDistribution");

            var request = InstantiateClassGenerator.Execute<CreateDistributionRequest>();
            var marshaller = new CreateDistributionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("CreateDistribution", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidWebACLIdException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"Location","Location_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = CreateDistributionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void CreateDistribution_MissingBodyExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateDistribution");

            var request = InstantiateClassGenerator.Execute<CreateDistributionRequest>();
            var marshaller = new CreateDistributionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("CreateDistribution", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("MissingBodyException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"Location","Location_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = CreateDistributionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void CreateDistribution_NoSuchCachePolicyExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateDistribution");

            var request = InstantiateClassGenerator.Execute<CreateDistributionRequest>();
            var marshaller = new CreateDistributionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("CreateDistribution", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("NoSuchCachePolicyException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"Location","Location_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = CreateDistributionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void CreateDistribution_NoSuchFieldLevelEncryptionConfigExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateDistribution");

            var request = InstantiateClassGenerator.Execute<CreateDistributionRequest>();
            var marshaller = new CreateDistributionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("CreateDistribution", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("NoSuchFieldLevelEncryptionConfigException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"Location","Location_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = CreateDistributionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void CreateDistribution_NoSuchOriginExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateDistribution");

            var request = InstantiateClassGenerator.Execute<CreateDistributionRequest>();
            var marshaller = new CreateDistributionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("CreateDistribution", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("NoSuchOriginException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"Location","Location_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = CreateDistributionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void CreateDistribution_NoSuchOriginRequestPolicyExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateDistribution");

            var request = InstantiateClassGenerator.Execute<CreateDistributionRequest>();
            var marshaller = new CreateDistributionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("CreateDistribution", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("NoSuchOriginRequestPolicyException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"Location","Location_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = CreateDistributionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void CreateDistribution_TooManyCacheBehaviorsExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateDistribution");

            var request = InstantiateClassGenerator.Execute<CreateDistributionRequest>();
            var marshaller = new CreateDistributionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("CreateDistribution", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("TooManyCacheBehaviorsException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"Location","Location_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = CreateDistributionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void CreateDistribution_TooManyCertificatesExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateDistribution");

            var request = InstantiateClassGenerator.Execute<CreateDistributionRequest>();
            var marshaller = new CreateDistributionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("CreateDistribution", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("TooManyCertificatesException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"Location","Location_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = CreateDistributionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void CreateDistribution_TooManyCookieNamesInWhiteListExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateDistribution");

            var request = InstantiateClassGenerator.Execute<CreateDistributionRequest>();
            var marshaller = new CreateDistributionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("CreateDistribution", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("TooManyCookieNamesInWhiteListException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"Location","Location_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = CreateDistributionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void CreateDistribution_TooManyDistributionCNAMEsExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateDistribution");

            var request = InstantiateClassGenerator.Execute<CreateDistributionRequest>();
            var marshaller = new CreateDistributionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("CreateDistribution", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("TooManyDistributionCNAMEsException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"Location","Location_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = CreateDistributionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void CreateDistribution_TooManyDistributionsAssociatedToCachePolicyExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateDistribution");

            var request = InstantiateClassGenerator.Execute<CreateDistributionRequest>();
            var marshaller = new CreateDistributionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("CreateDistribution", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("TooManyDistributionsAssociatedToCachePolicyException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"Location","Location_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = CreateDistributionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void CreateDistribution_TooManyDistributionsAssociatedToFieldLevelEncryptionConfigExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateDistribution");

            var request = InstantiateClassGenerator.Execute<CreateDistributionRequest>();
            var marshaller = new CreateDistributionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("CreateDistribution", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("TooManyDistributionsAssociatedToFieldLevelEncryptionConfigException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"Location","Location_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = CreateDistributionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void CreateDistribution_TooManyDistributionsAssociatedToKeyGroupExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateDistribution");

            var request = InstantiateClassGenerator.Execute<CreateDistributionRequest>();
            var marshaller = new CreateDistributionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("CreateDistribution", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("TooManyDistributionsAssociatedToKeyGroupException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"Location","Location_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = CreateDistributionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void CreateDistribution_TooManyDistributionsAssociatedToOriginRequestPolicyExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateDistribution");

            var request = InstantiateClassGenerator.Execute<CreateDistributionRequest>();
            var marshaller = new CreateDistributionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("CreateDistribution", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("TooManyDistributionsAssociatedToOriginRequestPolicyException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"Location","Location_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = CreateDistributionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void CreateDistribution_TooManyDistributionsExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateDistribution");

            var request = InstantiateClassGenerator.Execute<CreateDistributionRequest>();
            var marshaller = new CreateDistributionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("CreateDistribution", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("TooManyDistributionsException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"Location","Location_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = CreateDistributionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void CreateDistribution_TooManyDistributionsWithLambdaAssociationsExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateDistribution");

            var request = InstantiateClassGenerator.Execute<CreateDistributionRequest>();
            var marshaller = new CreateDistributionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("CreateDistribution", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("TooManyDistributionsWithLambdaAssociationsException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"Location","Location_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = CreateDistributionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void CreateDistribution_TooManyDistributionsWithSingleFunctionARNExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateDistribution");

            var request = InstantiateClassGenerator.Execute<CreateDistributionRequest>();
            var marshaller = new CreateDistributionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("CreateDistribution", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("TooManyDistributionsWithSingleFunctionARNException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"Location","Location_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = CreateDistributionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void CreateDistribution_TooManyHeadersInForwardedValuesExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateDistribution");

            var request = InstantiateClassGenerator.Execute<CreateDistributionRequest>();
            var marshaller = new CreateDistributionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("CreateDistribution", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("TooManyHeadersInForwardedValuesException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"Location","Location_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = CreateDistributionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void CreateDistribution_TooManyKeyGroupsAssociatedToDistributionExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateDistribution");

            var request = InstantiateClassGenerator.Execute<CreateDistributionRequest>();
            var marshaller = new CreateDistributionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("CreateDistribution", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("TooManyKeyGroupsAssociatedToDistributionException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"Location","Location_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = CreateDistributionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void CreateDistribution_TooManyLambdaFunctionAssociationsExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateDistribution");

            var request = InstantiateClassGenerator.Execute<CreateDistributionRequest>();
            var marshaller = new CreateDistributionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("CreateDistribution", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("TooManyLambdaFunctionAssociationsException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"Location","Location_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = CreateDistributionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void CreateDistribution_TooManyOriginCustomHeadersExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateDistribution");

            var request = InstantiateClassGenerator.Execute<CreateDistributionRequest>();
            var marshaller = new CreateDistributionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("CreateDistribution", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("TooManyOriginCustomHeadersException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"Location","Location_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = CreateDistributionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void CreateDistribution_TooManyOriginGroupsPerDistributionExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateDistribution");

            var request = InstantiateClassGenerator.Execute<CreateDistributionRequest>();
            var marshaller = new CreateDistributionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("CreateDistribution", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("TooManyOriginGroupsPerDistributionException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"Location","Location_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = CreateDistributionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void CreateDistribution_TooManyOriginsExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateDistribution");

            var request = InstantiateClassGenerator.Execute<CreateDistributionRequest>();
            var marshaller = new CreateDistributionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("CreateDistribution", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("TooManyOriginsException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"Location","Location_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = CreateDistributionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void CreateDistribution_TooManyQueryStringParametersExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateDistribution");

            var request = InstantiateClassGenerator.Execute<CreateDistributionRequest>();
            var marshaller = new CreateDistributionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("CreateDistribution", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("TooManyQueryStringParametersException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"Location","Location_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = CreateDistributionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void CreateDistribution_TooManyTrustedSignersExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateDistribution");

            var request = InstantiateClassGenerator.Execute<CreateDistributionRequest>();
            var marshaller = new CreateDistributionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("CreateDistribution", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("TooManyTrustedSignersException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"Location","Location_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = CreateDistributionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void CreateDistribution_TrustedKeyGroupDoesNotExistExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateDistribution");

            var request = InstantiateClassGenerator.Execute<CreateDistributionRequest>();
            var marshaller = new CreateDistributionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("CreateDistribution", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("TrustedKeyGroupDoesNotExistException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"Location","Location_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = CreateDistributionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void CreateDistribution_TrustedSignerDoesNotExistExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateDistribution");

            var request = InstantiateClassGenerator.Execute<CreateDistributionRequest>();
            var marshaller = new CreateDistributionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("CreateDistribution", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("TrustedSignerDoesNotExistException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"Location","Location_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = CreateDistributionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

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
            webResponse.ContentLength = payloadResponse.Length;
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
        public void CreateDistributionWithTags_AccessDeniedExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateDistributionWithTags");

            var request = InstantiateClassGenerator.Execute<CreateDistributionWithTagsRequest>();
            var marshaller = new CreateDistributionWithTagsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("CreateDistributionWithTags", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("AccessDeniedException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"Location","Location_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = CreateDistributionWithTagsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void CreateDistributionWithTags_CNAMEAlreadyExistsExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateDistributionWithTags");

            var request = InstantiateClassGenerator.Execute<CreateDistributionWithTagsRequest>();
            var marshaller = new CreateDistributionWithTagsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("CreateDistributionWithTags", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("CNAMEAlreadyExistsException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"Location","Location_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = CreateDistributionWithTagsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void CreateDistributionWithTags_DistributionAlreadyExistsExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateDistributionWithTags");

            var request = InstantiateClassGenerator.Execute<CreateDistributionWithTagsRequest>();
            var marshaller = new CreateDistributionWithTagsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("CreateDistributionWithTags", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("DistributionAlreadyExistsException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"Location","Location_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = CreateDistributionWithTagsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void CreateDistributionWithTags_IllegalFieldLevelEncryptionConfigAssociationWithCacheBehaviorExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateDistributionWithTags");

            var request = InstantiateClassGenerator.Execute<CreateDistributionWithTagsRequest>();
            var marshaller = new CreateDistributionWithTagsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("CreateDistributionWithTags", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("IllegalFieldLevelEncryptionConfigAssociationWithCacheBehaviorException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"Location","Location_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = CreateDistributionWithTagsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void CreateDistributionWithTags_InconsistentQuantitiesExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateDistributionWithTags");

            var request = InstantiateClassGenerator.Execute<CreateDistributionWithTagsRequest>();
            var marshaller = new CreateDistributionWithTagsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("CreateDistributionWithTags", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InconsistentQuantitiesException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"Location","Location_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = CreateDistributionWithTagsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void CreateDistributionWithTags_InvalidArgumentExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateDistributionWithTags");

            var request = InstantiateClassGenerator.Execute<CreateDistributionWithTagsRequest>();
            var marshaller = new CreateDistributionWithTagsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("CreateDistributionWithTags", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidArgumentException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"Location","Location_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = CreateDistributionWithTagsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void CreateDistributionWithTags_InvalidDefaultRootObjectExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateDistributionWithTags");

            var request = InstantiateClassGenerator.Execute<CreateDistributionWithTagsRequest>();
            var marshaller = new CreateDistributionWithTagsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("CreateDistributionWithTags", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidDefaultRootObjectException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"Location","Location_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = CreateDistributionWithTagsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void CreateDistributionWithTags_InvalidErrorCodeExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateDistributionWithTags");

            var request = InstantiateClassGenerator.Execute<CreateDistributionWithTagsRequest>();
            var marshaller = new CreateDistributionWithTagsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("CreateDistributionWithTags", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidErrorCodeException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"Location","Location_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = CreateDistributionWithTagsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void CreateDistributionWithTags_InvalidForwardCookiesExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateDistributionWithTags");

            var request = InstantiateClassGenerator.Execute<CreateDistributionWithTagsRequest>();
            var marshaller = new CreateDistributionWithTagsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("CreateDistributionWithTags", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidForwardCookiesException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"Location","Location_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = CreateDistributionWithTagsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void CreateDistributionWithTags_InvalidGeoRestrictionParameterExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateDistributionWithTags");

            var request = InstantiateClassGenerator.Execute<CreateDistributionWithTagsRequest>();
            var marshaller = new CreateDistributionWithTagsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("CreateDistributionWithTags", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidGeoRestrictionParameterException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"Location","Location_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = CreateDistributionWithTagsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void CreateDistributionWithTags_InvalidHeadersForS3OriginExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateDistributionWithTags");

            var request = InstantiateClassGenerator.Execute<CreateDistributionWithTagsRequest>();
            var marshaller = new CreateDistributionWithTagsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("CreateDistributionWithTags", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidHeadersForS3OriginException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"Location","Location_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = CreateDistributionWithTagsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void CreateDistributionWithTags_InvalidLambdaFunctionAssociationExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateDistributionWithTags");

            var request = InstantiateClassGenerator.Execute<CreateDistributionWithTagsRequest>();
            var marshaller = new CreateDistributionWithTagsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("CreateDistributionWithTags", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidLambdaFunctionAssociationException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"Location","Location_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = CreateDistributionWithTagsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void CreateDistributionWithTags_InvalidLocationCodeExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateDistributionWithTags");

            var request = InstantiateClassGenerator.Execute<CreateDistributionWithTagsRequest>();
            var marshaller = new CreateDistributionWithTagsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("CreateDistributionWithTags", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidLocationCodeException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"Location","Location_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = CreateDistributionWithTagsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void CreateDistributionWithTags_InvalidMinimumProtocolVersionExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateDistributionWithTags");

            var request = InstantiateClassGenerator.Execute<CreateDistributionWithTagsRequest>();
            var marshaller = new CreateDistributionWithTagsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("CreateDistributionWithTags", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidMinimumProtocolVersionException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"Location","Location_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = CreateDistributionWithTagsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void CreateDistributionWithTags_InvalidOriginAccessIdentityExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateDistributionWithTags");

            var request = InstantiateClassGenerator.Execute<CreateDistributionWithTagsRequest>();
            var marshaller = new CreateDistributionWithTagsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("CreateDistributionWithTags", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidOriginAccessIdentityException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"Location","Location_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = CreateDistributionWithTagsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void CreateDistributionWithTags_InvalidOriginExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateDistributionWithTags");

            var request = InstantiateClassGenerator.Execute<CreateDistributionWithTagsRequest>();
            var marshaller = new CreateDistributionWithTagsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("CreateDistributionWithTags", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidOriginException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"Location","Location_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = CreateDistributionWithTagsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void CreateDistributionWithTags_InvalidOriginKeepaliveTimeoutExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateDistributionWithTags");

            var request = InstantiateClassGenerator.Execute<CreateDistributionWithTagsRequest>();
            var marshaller = new CreateDistributionWithTagsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("CreateDistributionWithTags", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidOriginKeepaliveTimeoutException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"Location","Location_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = CreateDistributionWithTagsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void CreateDistributionWithTags_InvalidOriginReadTimeoutExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateDistributionWithTags");

            var request = InstantiateClassGenerator.Execute<CreateDistributionWithTagsRequest>();
            var marshaller = new CreateDistributionWithTagsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("CreateDistributionWithTags", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidOriginReadTimeoutException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"Location","Location_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = CreateDistributionWithTagsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void CreateDistributionWithTags_InvalidProtocolSettingsExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateDistributionWithTags");

            var request = InstantiateClassGenerator.Execute<CreateDistributionWithTagsRequest>();
            var marshaller = new CreateDistributionWithTagsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("CreateDistributionWithTags", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidProtocolSettingsException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"Location","Location_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = CreateDistributionWithTagsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void CreateDistributionWithTags_InvalidQueryStringParametersExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateDistributionWithTags");

            var request = InstantiateClassGenerator.Execute<CreateDistributionWithTagsRequest>();
            var marshaller = new CreateDistributionWithTagsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("CreateDistributionWithTags", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidQueryStringParametersException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"Location","Location_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = CreateDistributionWithTagsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void CreateDistributionWithTags_InvalidRelativePathExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateDistributionWithTags");

            var request = InstantiateClassGenerator.Execute<CreateDistributionWithTagsRequest>();
            var marshaller = new CreateDistributionWithTagsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("CreateDistributionWithTags", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidRelativePathException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"Location","Location_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = CreateDistributionWithTagsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void CreateDistributionWithTags_InvalidRequiredProtocolExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateDistributionWithTags");

            var request = InstantiateClassGenerator.Execute<CreateDistributionWithTagsRequest>();
            var marshaller = new CreateDistributionWithTagsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("CreateDistributionWithTags", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidRequiredProtocolException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"Location","Location_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = CreateDistributionWithTagsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void CreateDistributionWithTags_InvalidResponseCodeExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateDistributionWithTags");

            var request = InstantiateClassGenerator.Execute<CreateDistributionWithTagsRequest>();
            var marshaller = new CreateDistributionWithTagsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("CreateDistributionWithTags", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidResponseCodeException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"Location","Location_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = CreateDistributionWithTagsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void CreateDistributionWithTags_InvalidTaggingExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateDistributionWithTags");

            var request = InstantiateClassGenerator.Execute<CreateDistributionWithTagsRequest>();
            var marshaller = new CreateDistributionWithTagsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("CreateDistributionWithTags", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidTaggingException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"Location","Location_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = CreateDistributionWithTagsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void CreateDistributionWithTags_InvalidTTLOrderExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateDistributionWithTags");

            var request = InstantiateClassGenerator.Execute<CreateDistributionWithTagsRequest>();
            var marshaller = new CreateDistributionWithTagsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("CreateDistributionWithTags", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidTTLOrderException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"Location","Location_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = CreateDistributionWithTagsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void CreateDistributionWithTags_InvalidViewerCertificateExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateDistributionWithTags");

            var request = InstantiateClassGenerator.Execute<CreateDistributionWithTagsRequest>();
            var marshaller = new CreateDistributionWithTagsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("CreateDistributionWithTags", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidViewerCertificateException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"Location","Location_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = CreateDistributionWithTagsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void CreateDistributionWithTags_InvalidWebACLIdExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateDistributionWithTags");

            var request = InstantiateClassGenerator.Execute<CreateDistributionWithTagsRequest>();
            var marshaller = new CreateDistributionWithTagsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("CreateDistributionWithTags", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidWebACLIdException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"Location","Location_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = CreateDistributionWithTagsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void CreateDistributionWithTags_MissingBodyExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateDistributionWithTags");

            var request = InstantiateClassGenerator.Execute<CreateDistributionWithTagsRequest>();
            var marshaller = new CreateDistributionWithTagsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("CreateDistributionWithTags", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("MissingBodyException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"Location","Location_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = CreateDistributionWithTagsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void CreateDistributionWithTags_NoSuchCachePolicyExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateDistributionWithTags");

            var request = InstantiateClassGenerator.Execute<CreateDistributionWithTagsRequest>();
            var marshaller = new CreateDistributionWithTagsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("CreateDistributionWithTags", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("NoSuchCachePolicyException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"Location","Location_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = CreateDistributionWithTagsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void CreateDistributionWithTags_NoSuchFieldLevelEncryptionConfigExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateDistributionWithTags");

            var request = InstantiateClassGenerator.Execute<CreateDistributionWithTagsRequest>();
            var marshaller = new CreateDistributionWithTagsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("CreateDistributionWithTags", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("NoSuchFieldLevelEncryptionConfigException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"Location","Location_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = CreateDistributionWithTagsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void CreateDistributionWithTags_NoSuchOriginExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateDistributionWithTags");

            var request = InstantiateClassGenerator.Execute<CreateDistributionWithTagsRequest>();
            var marshaller = new CreateDistributionWithTagsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("CreateDistributionWithTags", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("NoSuchOriginException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"Location","Location_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = CreateDistributionWithTagsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void CreateDistributionWithTags_NoSuchOriginRequestPolicyExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateDistributionWithTags");

            var request = InstantiateClassGenerator.Execute<CreateDistributionWithTagsRequest>();
            var marshaller = new CreateDistributionWithTagsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("CreateDistributionWithTags", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("NoSuchOriginRequestPolicyException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"Location","Location_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = CreateDistributionWithTagsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void CreateDistributionWithTags_TooManyCacheBehaviorsExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateDistributionWithTags");

            var request = InstantiateClassGenerator.Execute<CreateDistributionWithTagsRequest>();
            var marshaller = new CreateDistributionWithTagsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("CreateDistributionWithTags", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("TooManyCacheBehaviorsException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"Location","Location_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = CreateDistributionWithTagsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void CreateDistributionWithTags_TooManyCertificatesExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateDistributionWithTags");

            var request = InstantiateClassGenerator.Execute<CreateDistributionWithTagsRequest>();
            var marshaller = new CreateDistributionWithTagsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("CreateDistributionWithTags", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("TooManyCertificatesException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"Location","Location_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = CreateDistributionWithTagsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void CreateDistributionWithTags_TooManyCookieNamesInWhiteListExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateDistributionWithTags");

            var request = InstantiateClassGenerator.Execute<CreateDistributionWithTagsRequest>();
            var marshaller = new CreateDistributionWithTagsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("CreateDistributionWithTags", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("TooManyCookieNamesInWhiteListException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"Location","Location_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = CreateDistributionWithTagsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void CreateDistributionWithTags_TooManyDistributionCNAMEsExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateDistributionWithTags");

            var request = InstantiateClassGenerator.Execute<CreateDistributionWithTagsRequest>();
            var marshaller = new CreateDistributionWithTagsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("CreateDistributionWithTags", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("TooManyDistributionCNAMEsException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"Location","Location_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = CreateDistributionWithTagsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void CreateDistributionWithTags_TooManyDistributionsAssociatedToCachePolicyExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateDistributionWithTags");

            var request = InstantiateClassGenerator.Execute<CreateDistributionWithTagsRequest>();
            var marshaller = new CreateDistributionWithTagsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("CreateDistributionWithTags", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("TooManyDistributionsAssociatedToCachePolicyException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"Location","Location_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = CreateDistributionWithTagsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void CreateDistributionWithTags_TooManyDistributionsAssociatedToFieldLevelEncryptionConfigExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateDistributionWithTags");

            var request = InstantiateClassGenerator.Execute<CreateDistributionWithTagsRequest>();
            var marshaller = new CreateDistributionWithTagsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("CreateDistributionWithTags", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("TooManyDistributionsAssociatedToFieldLevelEncryptionConfigException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"Location","Location_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = CreateDistributionWithTagsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void CreateDistributionWithTags_TooManyDistributionsAssociatedToKeyGroupExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateDistributionWithTags");

            var request = InstantiateClassGenerator.Execute<CreateDistributionWithTagsRequest>();
            var marshaller = new CreateDistributionWithTagsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("CreateDistributionWithTags", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("TooManyDistributionsAssociatedToKeyGroupException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"Location","Location_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = CreateDistributionWithTagsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void CreateDistributionWithTags_TooManyDistributionsAssociatedToOriginRequestPolicyExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateDistributionWithTags");

            var request = InstantiateClassGenerator.Execute<CreateDistributionWithTagsRequest>();
            var marshaller = new CreateDistributionWithTagsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("CreateDistributionWithTags", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("TooManyDistributionsAssociatedToOriginRequestPolicyException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"Location","Location_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = CreateDistributionWithTagsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void CreateDistributionWithTags_TooManyDistributionsExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateDistributionWithTags");

            var request = InstantiateClassGenerator.Execute<CreateDistributionWithTagsRequest>();
            var marshaller = new CreateDistributionWithTagsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("CreateDistributionWithTags", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("TooManyDistributionsException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"Location","Location_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = CreateDistributionWithTagsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void CreateDistributionWithTags_TooManyDistributionsWithLambdaAssociationsExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateDistributionWithTags");

            var request = InstantiateClassGenerator.Execute<CreateDistributionWithTagsRequest>();
            var marshaller = new CreateDistributionWithTagsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("CreateDistributionWithTags", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("TooManyDistributionsWithLambdaAssociationsException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"Location","Location_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = CreateDistributionWithTagsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void CreateDistributionWithTags_TooManyDistributionsWithSingleFunctionARNExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateDistributionWithTags");

            var request = InstantiateClassGenerator.Execute<CreateDistributionWithTagsRequest>();
            var marshaller = new CreateDistributionWithTagsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("CreateDistributionWithTags", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("TooManyDistributionsWithSingleFunctionARNException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"Location","Location_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = CreateDistributionWithTagsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void CreateDistributionWithTags_TooManyHeadersInForwardedValuesExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateDistributionWithTags");

            var request = InstantiateClassGenerator.Execute<CreateDistributionWithTagsRequest>();
            var marshaller = new CreateDistributionWithTagsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("CreateDistributionWithTags", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("TooManyHeadersInForwardedValuesException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"Location","Location_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = CreateDistributionWithTagsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void CreateDistributionWithTags_TooManyKeyGroupsAssociatedToDistributionExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateDistributionWithTags");

            var request = InstantiateClassGenerator.Execute<CreateDistributionWithTagsRequest>();
            var marshaller = new CreateDistributionWithTagsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("CreateDistributionWithTags", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("TooManyKeyGroupsAssociatedToDistributionException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"Location","Location_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = CreateDistributionWithTagsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void CreateDistributionWithTags_TooManyLambdaFunctionAssociationsExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateDistributionWithTags");

            var request = InstantiateClassGenerator.Execute<CreateDistributionWithTagsRequest>();
            var marshaller = new CreateDistributionWithTagsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("CreateDistributionWithTags", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("TooManyLambdaFunctionAssociationsException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"Location","Location_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = CreateDistributionWithTagsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void CreateDistributionWithTags_TooManyOriginCustomHeadersExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateDistributionWithTags");

            var request = InstantiateClassGenerator.Execute<CreateDistributionWithTagsRequest>();
            var marshaller = new CreateDistributionWithTagsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("CreateDistributionWithTags", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("TooManyOriginCustomHeadersException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"Location","Location_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = CreateDistributionWithTagsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void CreateDistributionWithTags_TooManyOriginGroupsPerDistributionExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateDistributionWithTags");

            var request = InstantiateClassGenerator.Execute<CreateDistributionWithTagsRequest>();
            var marshaller = new CreateDistributionWithTagsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("CreateDistributionWithTags", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("TooManyOriginGroupsPerDistributionException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"Location","Location_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = CreateDistributionWithTagsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void CreateDistributionWithTags_TooManyOriginsExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateDistributionWithTags");

            var request = InstantiateClassGenerator.Execute<CreateDistributionWithTagsRequest>();
            var marshaller = new CreateDistributionWithTagsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("CreateDistributionWithTags", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("TooManyOriginsException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"Location","Location_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = CreateDistributionWithTagsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void CreateDistributionWithTags_TooManyQueryStringParametersExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateDistributionWithTags");

            var request = InstantiateClassGenerator.Execute<CreateDistributionWithTagsRequest>();
            var marshaller = new CreateDistributionWithTagsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("CreateDistributionWithTags", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("TooManyQueryStringParametersException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"Location","Location_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = CreateDistributionWithTagsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void CreateDistributionWithTags_TooManyTrustedSignersExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateDistributionWithTags");

            var request = InstantiateClassGenerator.Execute<CreateDistributionWithTagsRequest>();
            var marshaller = new CreateDistributionWithTagsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("CreateDistributionWithTags", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("TooManyTrustedSignersException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"Location","Location_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = CreateDistributionWithTagsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void CreateDistributionWithTags_TrustedKeyGroupDoesNotExistExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateDistributionWithTags");

            var request = InstantiateClassGenerator.Execute<CreateDistributionWithTagsRequest>();
            var marshaller = new CreateDistributionWithTagsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("CreateDistributionWithTags", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("TrustedKeyGroupDoesNotExistException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"Location","Location_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = CreateDistributionWithTagsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void CreateDistributionWithTags_TrustedSignerDoesNotExistExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateDistributionWithTags");

            var request = InstantiateClassGenerator.Execute<CreateDistributionWithTagsRequest>();
            var marshaller = new CreateDistributionWithTagsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("CreateDistributionWithTags", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("TrustedSignerDoesNotExistException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"Location","Location_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = CreateDistributionWithTagsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

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
            webResponse.ContentLength = payloadResponse.Length;
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
        public void CreateFieldLevelEncryptionConfig_FieldLevelEncryptionConfigAlreadyExistsExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateFieldLevelEncryptionConfig");

            var request = InstantiateClassGenerator.Execute<CreateFieldLevelEncryptionConfigRequest>();
            var marshaller = new CreateFieldLevelEncryptionConfigRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("CreateFieldLevelEncryptionConfig", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("FieldLevelEncryptionConfigAlreadyExistsException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"Location","Location_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = CreateFieldLevelEncryptionConfigResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void CreateFieldLevelEncryptionConfig_InconsistentQuantitiesExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateFieldLevelEncryptionConfig");

            var request = InstantiateClassGenerator.Execute<CreateFieldLevelEncryptionConfigRequest>();
            var marshaller = new CreateFieldLevelEncryptionConfigRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("CreateFieldLevelEncryptionConfig", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InconsistentQuantitiesException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"Location","Location_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = CreateFieldLevelEncryptionConfigResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void CreateFieldLevelEncryptionConfig_InvalidArgumentExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateFieldLevelEncryptionConfig");

            var request = InstantiateClassGenerator.Execute<CreateFieldLevelEncryptionConfigRequest>();
            var marshaller = new CreateFieldLevelEncryptionConfigRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("CreateFieldLevelEncryptionConfig", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidArgumentException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"Location","Location_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = CreateFieldLevelEncryptionConfigResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void CreateFieldLevelEncryptionConfig_NoSuchFieldLevelEncryptionProfileExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateFieldLevelEncryptionConfig");

            var request = InstantiateClassGenerator.Execute<CreateFieldLevelEncryptionConfigRequest>();
            var marshaller = new CreateFieldLevelEncryptionConfigRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("CreateFieldLevelEncryptionConfig", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("NoSuchFieldLevelEncryptionProfileException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"Location","Location_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = CreateFieldLevelEncryptionConfigResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void CreateFieldLevelEncryptionConfig_QueryArgProfileEmptyExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateFieldLevelEncryptionConfig");

            var request = InstantiateClassGenerator.Execute<CreateFieldLevelEncryptionConfigRequest>();
            var marshaller = new CreateFieldLevelEncryptionConfigRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("CreateFieldLevelEncryptionConfig", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("QueryArgProfileEmptyException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"Location","Location_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = CreateFieldLevelEncryptionConfigResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void CreateFieldLevelEncryptionConfig_TooManyFieldLevelEncryptionConfigsExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateFieldLevelEncryptionConfig");

            var request = InstantiateClassGenerator.Execute<CreateFieldLevelEncryptionConfigRequest>();
            var marshaller = new CreateFieldLevelEncryptionConfigRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("CreateFieldLevelEncryptionConfig", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("TooManyFieldLevelEncryptionConfigsException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"Location","Location_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = CreateFieldLevelEncryptionConfigResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void CreateFieldLevelEncryptionConfig_TooManyFieldLevelEncryptionContentTypeProfilesExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateFieldLevelEncryptionConfig");

            var request = InstantiateClassGenerator.Execute<CreateFieldLevelEncryptionConfigRequest>();
            var marshaller = new CreateFieldLevelEncryptionConfigRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("CreateFieldLevelEncryptionConfig", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("TooManyFieldLevelEncryptionContentTypeProfilesException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"Location","Location_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = CreateFieldLevelEncryptionConfigResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void CreateFieldLevelEncryptionConfig_TooManyFieldLevelEncryptionQueryArgProfilesExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateFieldLevelEncryptionConfig");

            var request = InstantiateClassGenerator.Execute<CreateFieldLevelEncryptionConfigRequest>();
            var marshaller = new CreateFieldLevelEncryptionConfigRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("CreateFieldLevelEncryptionConfig", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("TooManyFieldLevelEncryptionQueryArgProfilesException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"Location","Location_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = CreateFieldLevelEncryptionConfigResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

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
            webResponse.ContentLength = payloadResponse.Length;
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
        public void CreateFieldLevelEncryptionProfile_FieldLevelEncryptionProfileAlreadyExistsExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateFieldLevelEncryptionProfile");

            var request = InstantiateClassGenerator.Execute<CreateFieldLevelEncryptionProfileRequest>();
            var marshaller = new CreateFieldLevelEncryptionProfileRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("CreateFieldLevelEncryptionProfile", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("FieldLevelEncryptionProfileAlreadyExistsException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"Location","Location_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = CreateFieldLevelEncryptionProfileResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void CreateFieldLevelEncryptionProfile_FieldLevelEncryptionProfileSizeExceededExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateFieldLevelEncryptionProfile");

            var request = InstantiateClassGenerator.Execute<CreateFieldLevelEncryptionProfileRequest>();
            var marshaller = new CreateFieldLevelEncryptionProfileRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("CreateFieldLevelEncryptionProfile", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("FieldLevelEncryptionProfileSizeExceededException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"Location","Location_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = CreateFieldLevelEncryptionProfileResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void CreateFieldLevelEncryptionProfile_InconsistentQuantitiesExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateFieldLevelEncryptionProfile");

            var request = InstantiateClassGenerator.Execute<CreateFieldLevelEncryptionProfileRequest>();
            var marshaller = new CreateFieldLevelEncryptionProfileRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("CreateFieldLevelEncryptionProfile", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InconsistentQuantitiesException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"Location","Location_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = CreateFieldLevelEncryptionProfileResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void CreateFieldLevelEncryptionProfile_InvalidArgumentExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateFieldLevelEncryptionProfile");

            var request = InstantiateClassGenerator.Execute<CreateFieldLevelEncryptionProfileRequest>();
            var marshaller = new CreateFieldLevelEncryptionProfileRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("CreateFieldLevelEncryptionProfile", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidArgumentException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"Location","Location_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = CreateFieldLevelEncryptionProfileResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void CreateFieldLevelEncryptionProfile_NoSuchPublicKeyExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateFieldLevelEncryptionProfile");

            var request = InstantiateClassGenerator.Execute<CreateFieldLevelEncryptionProfileRequest>();
            var marshaller = new CreateFieldLevelEncryptionProfileRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("CreateFieldLevelEncryptionProfile", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("NoSuchPublicKeyException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"Location","Location_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = CreateFieldLevelEncryptionProfileResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void CreateFieldLevelEncryptionProfile_TooManyFieldLevelEncryptionEncryptionEntitiesExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateFieldLevelEncryptionProfile");

            var request = InstantiateClassGenerator.Execute<CreateFieldLevelEncryptionProfileRequest>();
            var marshaller = new CreateFieldLevelEncryptionProfileRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("CreateFieldLevelEncryptionProfile", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("TooManyFieldLevelEncryptionEncryptionEntitiesException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"Location","Location_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = CreateFieldLevelEncryptionProfileResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void CreateFieldLevelEncryptionProfile_TooManyFieldLevelEncryptionFieldPatternsExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateFieldLevelEncryptionProfile");

            var request = InstantiateClassGenerator.Execute<CreateFieldLevelEncryptionProfileRequest>();
            var marshaller = new CreateFieldLevelEncryptionProfileRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("CreateFieldLevelEncryptionProfile", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("TooManyFieldLevelEncryptionFieldPatternsException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"Location","Location_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = CreateFieldLevelEncryptionProfileResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void CreateFieldLevelEncryptionProfile_TooManyFieldLevelEncryptionProfilesExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateFieldLevelEncryptionProfile");

            var request = InstantiateClassGenerator.Execute<CreateFieldLevelEncryptionProfileRequest>();
            var marshaller = new CreateFieldLevelEncryptionProfileRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("CreateFieldLevelEncryptionProfile", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("TooManyFieldLevelEncryptionProfilesException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"Location","Location_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = CreateFieldLevelEncryptionProfileResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

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
            webResponse.ContentLength = payloadResponse.Length;
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
        public void CreateInvalidation_AccessDeniedExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateInvalidation");

            var request = InstantiateClassGenerator.Execute<CreateInvalidationRequest>();
            var marshaller = new CreateInvalidationRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("CreateInvalidation", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("AccessDeniedException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"Location","Location_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = CreateInvalidationResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void CreateInvalidation_BatchTooLargeExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateInvalidation");

            var request = InstantiateClassGenerator.Execute<CreateInvalidationRequest>();
            var marshaller = new CreateInvalidationRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("CreateInvalidation", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("BatchTooLargeException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"Location","Location_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = CreateInvalidationResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void CreateInvalidation_InconsistentQuantitiesExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateInvalidation");

            var request = InstantiateClassGenerator.Execute<CreateInvalidationRequest>();
            var marshaller = new CreateInvalidationRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("CreateInvalidation", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InconsistentQuantitiesException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"Location","Location_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = CreateInvalidationResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void CreateInvalidation_InvalidArgumentExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateInvalidation");

            var request = InstantiateClassGenerator.Execute<CreateInvalidationRequest>();
            var marshaller = new CreateInvalidationRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("CreateInvalidation", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidArgumentException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"Location","Location_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = CreateInvalidationResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void CreateInvalidation_MissingBodyExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateInvalidation");

            var request = InstantiateClassGenerator.Execute<CreateInvalidationRequest>();
            var marshaller = new CreateInvalidationRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("CreateInvalidation", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("MissingBodyException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"Location","Location_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = CreateInvalidationResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void CreateInvalidation_NoSuchDistributionExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateInvalidation");

            var request = InstantiateClassGenerator.Execute<CreateInvalidationRequest>();
            var marshaller = new CreateInvalidationRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("CreateInvalidation", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("NoSuchDistributionException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"Location","Location_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = CreateInvalidationResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void CreateInvalidation_TooManyInvalidationsInProgressExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateInvalidation");

            var request = InstantiateClassGenerator.Execute<CreateInvalidationRequest>();
            var marshaller = new CreateInvalidationRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("CreateInvalidation", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("TooManyInvalidationsInProgressException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"Location","Location_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = CreateInvalidationResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void CreateKeyGroupMarshallTest()
        {
            var operation = service_model.FindOperation("CreateKeyGroup");

            var request = InstantiateClassGenerator.Execute<CreateKeyGroupRequest>();
            var marshaller = new CreateKeyGroupRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("CreateKeyGroup", request, internalRequest, service_model);            

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
            webResponse.ContentLength = payloadResponse.Length;
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = CreateKeyGroupResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as CreateKeyGroupResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void CreateKeyGroup_InvalidArgumentExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateKeyGroup");

            var request = InstantiateClassGenerator.Execute<CreateKeyGroupRequest>();
            var marshaller = new CreateKeyGroupRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("CreateKeyGroup", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidArgumentException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"Location","Location_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = CreateKeyGroupResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void CreateKeyGroup_KeyGroupAlreadyExistsExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateKeyGroup");

            var request = InstantiateClassGenerator.Execute<CreateKeyGroupRequest>();
            var marshaller = new CreateKeyGroupRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("CreateKeyGroup", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("KeyGroupAlreadyExistsException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"Location","Location_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = CreateKeyGroupResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void CreateKeyGroup_TooManyKeyGroupsExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateKeyGroup");

            var request = InstantiateClassGenerator.Execute<CreateKeyGroupRequest>();
            var marshaller = new CreateKeyGroupRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("CreateKeyGroup", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("TooManyKeyGroupsException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"Location","Location_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = CreateKeyGroupResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void CreateKeyGroup_TooManyPublicKeysInKeyGroupExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateKeyGroup");

            var request = InstantiateClassGenerator.Execute<CreateKeyGroupRequest>();
            var marshaller = new CreateKeyGroupRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("CreateKeyGroup", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("TooManyPublicKeysInKeyGroupException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"Location","Location_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = CreateKeyGroupResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void CreateMonitoringSubscriptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateMonitoringSubscription");

            var request = InstantiateClassGenerator.Execute<CreateMonitoringSubscriptionRequest>();
            var marshaller = new CreateMonitoringSubscriptionRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("CreateMonitoringSubscription", request, internalRequest, service_model);            

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            webResponse.ContentLength = payloadResponse.Length;
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = CreateMonitoringSubscriptionResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as CreateMonitoringSubscriptionResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void CreateMonitoringSubscription_AccessDeniedExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateMonitoringSubscription");

            var request = InstantiateClassGenerator.Execute<CreateMonitoringSubscriptionRequest>();
            var marshaller = new CreateMonitoringSubscriptionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("CreateMonitoringSubscription", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("AccessDeniedException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = CreateMonitoringSubscriptionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void CreateMonitoringSubscription_NoSuchDistributionExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateMonitoringSubscription");

            var request = InstantiateClassGenerator.Execute<CreateMonitoringSubscriptionRequest>();
            var marshaller = new CreateMonitoringSubscriptionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("CreateMonitoringSubscription", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("NoSuchDistributionException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = CreateMonitoringSubscriptionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void CreateOriginRequestPolicyMarshallTest()
        {
            var operation = service_model.FindOperation("CreateOriginRequestPolicy");

            var request = InstantiateClassGenerator.Execute<CreateOriginRequestPolicyRequest>();
            var marshaller = new CreateOriginRequestPolicyRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("CreateOriginRequestPolicy", request, internalRequest, service_model);            

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
            webResponse.ContentLength = payloadResponse.Length;
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = CreateOriginRequestPolicyResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as CreateOriginRequestPolicyResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void CreateOriginRequestPolicy_AccessDeniedExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateOriginRequestPolicy");

            var request = InstantiateClassGenerator.Execute<CreateOriginRequestPolicyRequest>();
            var marshaller = new CreateOriginRequestPolicyRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("CreateOriginRequestPolicy", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("AccessDeniedException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"Location","Location_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = CreateOriginRequestPolicyResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void CreateOriginRequestPolicy_InconsistentQuantitiesExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateOriginRequestPolicy");

            var request = InstantiateClassGenerator.Execute<CreateOriginRequestPolicyRequest>();
            var marshaller = new CreateOriginRequestPolicyRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("CreateOriginRequestPolicy", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InconsistentQuantitiesException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"Location","Location_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = CreateOriginRequestPolicyResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void CreateOriginRequestPolicy_InvalidArgumentExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateOriginRequestPolicy");

            var request = InstantiateClassGenerator.Execute<CreateOriginRequestPolicyRequest>();
            var marshaller = new CreateOriginRequestPolicyRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("CreateOriginRequestPolicy", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidArgumentException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"Location","Location_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = CreateOriginRequestPolicyResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void CreateOriginRequestPolicy_OriginRequestPolicyAlreadyExistsExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateOriginRequestPolicy");

            var request = InstantiateClassGenerator.Execute<CreateOriginRequestPolicyRequest>();
            var marshaller = new CreateOriginRequestPolicyRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("CreateOriginRequestPolicy", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("OriginRequestPolicyAlreadyExistsException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"Location","Location_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = CreateOriginRequestPolicyResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void CreateOriginRequestPolicy_TooManyCookiesInOriginRequestPolicyExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateOriginRequestPolicy");

            var request = InstantiateClassGenerator.Execute<CreateOriginRequestPolicyRequest>();
            var marshaller = new CreateOriginRequestPolicyRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("CreateOriginRequestPolicy", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("TooManyCookiesInOriginRequestPolicyException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"Location","Location_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = CreateOriginRequestPolicyResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void CreateOriginRequestPolicy_TooManyHeadersInOriginRequestPolicyExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateOriginRequestPolicy");

            var request = InstantiateClassGenerator.Execute<CreateOriginRequestPolicyRequest>();
            var marshaller = new CreateOriginRequestPolicyRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("CreateOriginRequestPolicy", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("TooManyHeadersInOriginRequestPolicyException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"Location","Location_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = CreateOriginRequestPolicyResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void CreateOriginRequestPolicy_TooManyOriginRequestPoliciesExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateOriginRequestPolicy");

            var request = InstantiateClassGenerator.Execute<CreateOriginRequestPolicyRequest>();
            var marshaller = new CreateOriginRequestPolicyRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("CreateOriginRequestPolicy", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("TooManyOriginRequestPoliciesException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"Location","Location_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = CreateOriginRequestPolicyResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void CreateOriginRequestPolicy_TooManyQueryStringsInOriginRequestPolicyExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateOriginRequestPolicy");

            var request = InstantiateClassGenerator.Execute<CreateOriginRequestPolicyRequest>();
            var marshaller = new CreateOriginRequestPolicyRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("CreateOriginRequestPolicy", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("TooManyQueryStringsInOriginRequestPolicyException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"Location","Location_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = CreateOriginRequestPolicyResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

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
            webResponse.ContentLength = payloadResponse.Length;
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
        public void CreatePublicKey_InvalidArgumentExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreatePublicKey");

            var request = InstantiateClassGenerator.Execute<CreatePublicKeyRequest>();
            var marshaller = new CreatePublicKeyRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("CreatePublicKey", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidArgumentException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"Location","Location_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = CreatePublicKeyResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void CreatePublicKey_PublicKeyAlreadyExistsExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreatePublicKey");

            var request = InstantiateClassGenerator.Execute<CreatePublicKeyRequest>();
            var marshaller = new CreatePublicKeyRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("CreatePublicKey", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("PublicKeyAlreadyExistsException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"Location","Location_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = CreatePublicKeyResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void CreatePublicKey_TooManyPublicKeysExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreatePublicKey");

            var request = InstantiateClassGenerator.Execute<CreatePublicKeyRequest>();
            var marshaller = new CreatePublicKeyRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("CreatePublicKey", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("TooManyPublicKeysException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"Location","Location_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = CreatePublicKeyResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void CreateRealtimeLogConfigMarshallTest()
        {
            var operation = service_model.FindOperation("CreateRealtimeLogConfig");

            var request = InstantiateClassGenerator.Execute<CreateRealtimeLogConfigRequest>();
            var marshaller = new CreateRealtimeLogConfigRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("CreateRealtimeLogConfig", request, internalRequest, service_model);            

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            webResponse.ContentLength = payloadResponse.Length;
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = CreateRealtimeLogConfigResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as CreateRealtimeLogConfigResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void CreateRealtimeLogConfig_AccessDeniedExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateRealtimeLogConfig");

            var request = InstantiateClassGenerator.Execute<CreateRealtimeLogConfigRequest>();
            var marshaller = new CreateRealtimeLogConfigRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("CreateRealtimeLogConfig", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("AccessDeniedException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = CreateRealtimeLogConfigResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void CreateRealtimeLogConfig_InvalidArgumentExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateRealtimeLogConfig");

            var request = InstantiateClassGenerator.Execute<CreateRealtimeLogConfigRequest>();
            var marshaller = new CreateRealtimeLogConfigRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("CreateRealtimeLogConfig", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidArgumentException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = CreateRealtimeLogConfigResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void CreateRealtimeLogConfig_RealtimeLogConfigAlreadyExistsExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateRealtimeLogConfig");

            var request = InstantiateClassGenerator.Execute<CreateRealtimeLogConfigRequest>();
            var marshaller = new CreateRealtimeLogConfigRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("CreateRealtimeLogConfig", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("RealtimeLogConfigAlreadyExistsException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = CreateRealtimeLogConfigResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void CreateRealtimeLogConfig_TooManyRealtimeLogConfigsExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateRealtimeLogConfig");

            var request = InstantiateClassGenerator.Execute<CreateRealtimeLogConfigRequest>();
            var marshaller = new CreateRealtimeLogConfigRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("CreateRealtimeLogConfig", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("TooManyRealtimeLogConfigsException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = CreateRealtimeLogConfigResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

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
            webResponse.ContentLength = payloadResponse.Length;
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
        public void CreateStreamingDistribution_AccessDeniedExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateStreamingDistribution");

            var request = InstantiateClassGenerator.Execute<CreateStreamingDistributionRequest>();
            var marshaller = new CreateStreamingDistributionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("CreateStreamingDistribution", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("AccessDeniedException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"Location","Location_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = CreateStreamingDistributionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void CreateStreamingDistribution_CNAMEAlreadyExistsExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateStreamingDistribution");

            var request = InstantiateClassGenerator.Execute<CreateStreamingDistributionRequest>();
            var marshaller = new CreateStreamingDistributionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("CreateStreamingDistribution", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("CNAMEAlreadyExistsException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"Location","Location_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = CreateStreamingDistributionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void CreateStreamingDistribution_InconsistentQuantitiesExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateStreamingDistribution");

            var request = InstantiateClassGenerator.Execute<CreateStreamingDistributionRequest>();
            var marshaller = new CreateStreamingDistributionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("CreateStreamingDistribution", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InconsistentQuantitiesException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"Location","Location_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = CreateStreamingDistributionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void CreateStreamingDistribution_InvalidArgumentExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateStreamingDistribution");

            var request = InstantiateClassGenerator.Execute<CreateStreamingDistributionRequest>();
            var marshaller = new CreateStreamingDistributionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("CreateStreamingDistribution", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidArgumentException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"Location","Location_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = CreateStreamingDistributionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void CreateStreamingDistribution_InvalidOriginAccessIdentityExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateStreamingDistribution");

            var request = InstantiateClassGenerator.Execute<CreateStreamingDistributionRequest>();
            var marshaller = new CreateStreamingDistributionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("CreateStreamingDistribution", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidOriginAccessIdentityException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"Location","Location_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = CreateStreamingDistributionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void CreateStreamingDistribution_InvalidOriginExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateStreamingDistribution");

            var request = InstantiateClassGenerator.Execute<CreateStreamingDistributionRequest>();
            var marshaller = new CreateStreamingDistributionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("CreateStreamingDistribution", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidOriginException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"Location","Location_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = CreateStreamingDistributionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void CreateStreamingDistribution_MissingBodyExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateStreamingDistribution");

            var request = InstantiateClassGenerator.Execute<CreateStreamingDistributionRequest>();
            var marshaller = new CreateStreamingDistributionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("CreateStreamingDistribution", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("MissingBodyException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"Location","Location_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = CreateStreamingDistributionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void CreateStreamingDistribution_StreamingDistributionAlreadyExistsExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateStreamingDistribution");

            var request = InstantiateClassGenerator.Execute<CreateStreamingDistributionRequest>();
            var marshaller = new CreateStreamingDistributionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("CreateStreamingDistribution", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("StreamingDistributionAlreadyExistsException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"Location","Location_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = CreateStreamingDistributionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void CreateStreamingDistribution_TooManyStreamingDistributionCNAMEsExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateStreamingDistribution");

            var request = InstantiateClassGenerator.Execute<CreateStreamingDistributionRequest>();
            var marshaller = new CreateStreamingDistributionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("CreateStreamingDistribution", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("TooManyStreamingDistributionCNAMEsException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"Location","Location_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = CreateStreamingDistributionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void CreateStreamingDistribution_TooManyStreamingDistributionsExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateStreamingDistribution");

            var request = InstantiateClassGenerator.Execute<CreateStreamingDistributionRequest>();
            var marshaller = new CreateStreamingDistributionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("CreateStreamingDistribution", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("TooManyStreamingDistributionsException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"Location","Location_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = CreateStreamingDistributionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void CreateStreamingDistribution_TooManyTrustedSignersExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateStreamingDistribution");

            var request = InstantiateClassGenerator.Execute<CreateStreamingDistributionRequest>();
            var marshaller = new CreateStreamingDistributionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("CreateStreamingDistribution", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("TooManyTrustedSignersException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"Location","Location_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = CreateStreamingDistributionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void CreateStreamingDistribution_TrustedSignerDoesNotExistExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateStreamingDistribution");

            var request = InstantiateClassGenerator.Execute<CreateStreamingDistributionRequest>();
            var marshaller = new CreateStreamingDistributionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("CreateStreamingDistribution", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("TrustedSignerDoesNotExistException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"Location","Location_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = CreateStreamingDistributionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

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
            webResponse.ContentLength = payloadResponse.Length;
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
        public void CreateStreamingDistributionWithTags_AccessDeniedExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateStreamingDistributionWithTags");

            var request = InstantiateClassGenerator.Execute<CreateStreamingDistributionWithTagsRequest>();
            var marshaller = new CreateStreamingDistributionWithTagsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("CreateStreamingDistributionWithTags", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("AccessDeniedException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"Location","Location_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = CreateStreamingDistributionWithTagsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void CreateStreamingDistributionWithTags_CNAMEAlreadyExistsExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateStreamingDistributionWithTags");

            var request = InstantiateClassGenerator.Execute<CreateStreamingDistributionWithTagsRequest>();
            var marshaller = new CreateStreamingDistributionWithTagsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("CreateStreamingDistributionWithTags", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("CNAMEAlreadyExistsException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"Location","Location_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = CreateStreamingDistributionWithTagsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void CreateStreamingDistributionWithTags_InconsistentQuantitiesExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateStreamingDistributionWithTags");

            var request = InstantiateClassGenerator.Execute<CreateStreamingDistributionWithTagsRequest>();
            var marshaller = new CreateStreamingDistributionWithTagsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("CreateStreamingDistributionWithTags", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InconsistentQuantitiesException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"Location","Location_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = CreateStreamingDistributionWithTagsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void CreateStreamingDistributionWithTags_InvalidArgumentExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateStreamingDistributionWithTags");

            var request = InstantiateClassGenerator.Execute<CreateStreamingDistributionWithTagsRequest>();
            var marshaller = new CreateStreamingDistributionWithTagsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("CreateStreamingDistributionWithTags", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidArgumentException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"Location","Location_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = CreateStreamingDistributionWithTagsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void CreateStreamingDistributionWithTags_InvalidOriginAccessIdentityExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateStreamingDistributionWithTags");

            var request = InstantiateClassGenerator.Execute<CreateStreamingDistributionWithTagsRequest>();
            var marshaller = new CreateStreamingDistributionWithTagsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("CreateStreamingDistributionWithTags", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidOriginAccessIdentityException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"Location","Location_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = CreateStreamingDistributionWithTagsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void CreateStreamingDistributionWithTags_InvalidOriginExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateStreamingDistributionWithTags");

            var request = InstantiateClassGenerator.Execute<CreateStreamingDistributionWithTagsRequest>();
            var marshaller = new CreateStreamingDistributionWithTagsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("CreateStreamingDistributionWithTags", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidOriginException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"Location","Location_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = CreateStreamingDistributionWithTagsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void CreateStreamingDistributionWithTags_InvalidTaggingExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateStreamingDistributionWithTags");

            var request = InstantiateClassGenerator.Execute<CreateStreamingDistributionWithTagsRequest>();
            var marshaller = new CreateStreamingDistributionWithTagsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("CreateStreamingDistributionWithTags", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidTaggingException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"Location","Location_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = CreateStreamingDistributionWithTagsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void CreateStreamingDistributionWithTags_MissingBodyExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateStreamingDistributionWithTags");

            var request = InstantiateClassGenerator.Execute<CreateStreamingDistributionWithTagsRequest>();
            var marshaller = new CreateStreamingDistributionWithTagsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("CreateStreamingDistributionWithTags", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("MissingBodyException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"Location","Location_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = CreateStreamingDistributionWithTagsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void CreateStreamingDistributionWithTags_StreamingDistributionAlreadyExistsExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateStreamingDistributionWithTags");

            var request = InstantiateClassGenerator.Execute<CreateStreamingDistributionWithTagsRequest>();
            var marshaller = new CreateStreamingDistributionWithTagsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("CreateStreamingDistributionWithTags", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("StreamingDistributionAlreadyExistsException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"Location","Location_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = CreateStreamingDistributionWithTagsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void CreateStreamingDistributionWithTags_TooManyStreamingDistributionCNAMEsExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateStreamingDistributionWithTags");

            var request = InstantiateClassGenerator.Execute<CreateStreamingDistributionWithTagsRequest>();
            var marshaller = new CreateStreamingDistributionWithTagsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("CreateStreamingDistributionWithTags", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("TooManyStreamingDistributionCNAMEsException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"Location","Location_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = CreateStreamingDistributionWithTagsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void CreateStreamingDistributionWithTags_TooManyStreamingDistributionsExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateStreamingDistributionWithTags");

            var request = InstantiateClassGenerator.Execute<CreateStreamingDistributionWithTagsRequest>();
            var marshaller = new CreateStreamingDistributionWithTagsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("CreateStreamingDistributionWithTags", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("TooManyStreamingDistributionsException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"Location","Location_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = CreateStreamingDistributionWithTagsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void CreateStreamingDistributionWithTags_TooManyTrustedSignersExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateStreamingDistributionWithTags");

            var request = InstantiateClassGenerator.Execute<CreateStreamingDistributionWithTagsRequest>();
            var marshaller = new CreateStreamingDistributionWithTagsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("CreateStreamingDistributionWithTags", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("TooManyTrustedSignersException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"Location","Location_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = CreateStreamingDistributionWithTagsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void CreateStreamingDistributionWithTags_TrustedSignerDoesNotExistExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateStreamingDistributionWithTags");

            var request = InstantiateClassGenerator.Execute<CreateStreamingDistributionWithTagsRequest>();
            var marshaller = new CreateStreamingDistributionWithTagsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("CreateStreamingDistributionWithTags", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("TrustedSignerDoesNotExistException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"Location","Location_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = CreateStreamingDistributionWithTagsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void DeleteCachePolicyMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteCachePolicy");

            var request = InstantiateClassGenerator.Execute<DeleteCachePolicyRequest>();
            var marshaller = new DeleteCachePolicyRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("DeleteCachePolicy", request, internalRequest, service_model);            

        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void DeleteCachePolicy_AccessDeniedExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteCachePolicy");

            var request = InstantiateClassGenerator.Execute<DeleteCachePolicyRequest>();
            var marshaller = new DeleteCachePolicyRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("DeleteCachePolicy", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("AccessDeniedException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = DeleteCachePolicyResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void DeleteCachePolicy_CachePolicyInUseExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteCachePolicy");

            var request = InstantiateClassGenerator.Execute<DeleteCachePolicyRequest>();
            var marshaller = new DeleteCachePolicyRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("DeleteCachePolicy", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("CachePolicyInUseException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = DeleteCachePolicyResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void DeleteCachePolicy_IllegalDeleteExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteCachePolicy");

            var request = InstantiateClassGenerator.Execute<DeleteCachePolicyRequest>();
            var marshaller = new DeleteCachePolicyRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("DeleteCachePolicy", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("IllegalDeleteException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = DeleteCachePolicyResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void DeleteCachePolicy_InvalidIfMatchVersionExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteCachePolicy");

            var request = InstantiateClassGenerator.Execute<DeleteCachePolicyRequest>();
            var marshaller = new DeleteCachePolicyRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("DeleteCachePolicy", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidIfMatchVersionException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = DeleteCachePolicyResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void DeleteCachePolicy_NoSuchCachePolicyExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteCachePolicy");

            var request = InstantiateClassGenerator.Execute<DeleteCachePolicyRequest>();
            var marshaller = new DeleteCachePolicyRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("DeleteCachePolicy", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("NoSuchCachePolicyException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = DeleteCachePolicyResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void DeleteCachePolicy_PreconditionFailedExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteCachePolicy");

            var request = InstantiateClassGenerator.Execute<DeleteCachePolicyRequest>();
            var marshaller = new DeleteCachePolicyRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("DeleteCachePolicy", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("PreconditionFailedException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = DeleteCachePolicyResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

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
        public void DeleteCloudFrontOriginAccessIdentity_AccessDeniedExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteCloudFrontOriginAccessIdentity");

            var request = InstantiateClassGenerator.Execute<DeleteCloudFrontOriginAccessIdentityRequest>();
            var marshaller = new DeleteCloudFrontOriginAccessIdentityRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("DeleteCloudFrontOriginAccessIdentity", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("AccessDeniedException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = DeleteCloudFrontOriginAccessIdentityResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void DeleteCloudFrontOriginAccessIdentity_CloudFrontOriginAccessIdentityInUseExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteCloudFrontOriginAccessIdentity");

            var request = InstantiateClassGenerator.Execute<DeleteCloudFrontOriginAccessIdentityRequest>();
            var marshaller = new DeleteCloudFrontOriginAccessIdentityRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("DeleteCloudFrontOriginAccessIdentity", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("CloudFrontOriginAccessIdentityInUseException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = DeleteCloudFrontOriginAccessIdentityResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void DeleteCloudFrontOriginAccessIdentity_InvalidIfMatchVersionExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteCloudFrontOriginAccessIdentity");

            var request = InstantiateClassGenerator.Execute<DeleteCloudFrontOriginAccessIdentityRequest>();
            var marshaller = new DeleteCloudFrontOriginAccessIdentityRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("DeleteCloudFrontOriginAccessIdentity", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidIfMatchVersionException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = DeleteCloudFrontOriginAccessIdentityResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void DeleteCloudFrontOriginAccessIdentity_NoSuchCloudFrontOriginAccessIdentityExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteCloudFrontOriginAccessIdentity");

            var request = InstantiateClassGenerator.Execute<DeleteCloudFrontOriginAccessIdentityRequest>();
            var marshaller = new DeleteCloudFrontOriginAccessIdentityRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("DeleteCloudFrontOriginAccessIdentity", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("NoSuchCloudFrontOriginAccessIdentityException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = DeleteCloudFrontOriginAccessIdentityResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void DeleteCloudFrontOriginAccessIdentity_PreconditionFailedExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteCloudFrontOriginAccessIdentity");

            var request = InstantiateClassGenerator.Execute<DeleteCloudFrontOriginAccessIdentityRequest>();
            var marshaller = new DeleteCloudFrontOriginAccessIdentityRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("DeleteCloudFrontOriginAccessIdentity", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("PreconditionFailedException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = DeleteCloudFrontOriginAccessIdentityResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
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
        public void DeleteDistribution_AccessDeniedExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteDistribution");

            var request = InstantiateClassGenerator.Execute<DeleteDistributionRequest>();
            var marshaller = new DeleteDistributionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("DeleteDistribution", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("AccessDeniedException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = DeleteDistributionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void DeleteDistribution_DistributionNotDisabledExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteDistribution");

            var request = InstantiateClassGenerator.Execute<DeleteDistributionRequest>();
            var marshaller = new DeleteDistributionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("DeleteDistribution", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("DistributionNotDisabledException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = DeleteDistributionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void DeleteDistribution_InvalidIfMatchVersionExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteDistribution");

            var request = InstantiateClassGenerator.Execute<DeleteDistributionRequest>();
            var marshaller = new DeleteDistributionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("DeleteDistribution", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidIfMatchVersionException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = DeleteDistributionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void DeleteDistribution_NoSuchDistributionExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteDistribution");

            var request = InstantiateClassGenerator.Execute<DeleteDistributionRequest>();
            var marshaller = new DeleteDistributionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("DeleteDistribution", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("NoSuchDistributionException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = DeleteDistributionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void DeleteDistribution_PreconditionFailedExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteDistribution");

            var request = InstantiateClassGenerator.Execute<DeleteDistributionRequest>();
            var marshaller = new DeleteDistributionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("DeleteDistribution", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("PreconditionFailedException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = DeleteDistributionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
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
        public void DeleteFieldLevelEncryptionConfig_AccessDeniedExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteFieldLevelEncryptionConfig");

            var request = InstantiateClassGenerator.Execute<DeleteFieldLevelEncryptionConfigRequest>();
            var marshaller = new DeleteFieldLevelEncryptionConfigRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("DeleteFieldLevelEncryptionConfig", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("AccessDeniedException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = DeleteFieldLevelEncryptionConfigResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void DeleteFieldLevelEncryptionConfig_FieldLevelEncryptionConfigInUseExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteFieldLevelEncryptionConfig");

            var request = InstantiateClassGenerator.Execute<DeleteFieldLevelEncryptionConfigRequest>();
            var marshaller = new DeleteFieldLevelEncryptionConfigRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("DeleteFieldLevelEncryptionConfig", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("FieldLevelEncryptionConfigInUseException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = DeleteFieldLevelEncryptionConfigResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void DeleteFieldLevelEncryptionConfig_InvalidIfMatchVersionExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteFieldLevelEncryptionConfig");

            var request = InstantiateClassGenerator.Execute<DeleteFieldLevelEncryptionConfigRequest>();
            var marshaller = new DeleteFieldLevelEncryptionConfigRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("DeleteFieldLevelEncryptionConfig", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidIfMatchVersionException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = DeleteFieldLevelEncryptionConfigResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void DeleteFieldLevelEncryptionConfig_NoSuchFieldLevelEncryptionConfigExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteFieldLevelEncryptionConfig");

            var request = InstantiateClassGenerator.Execute<DeleteFieldLevelEncryptionConfigRequest>();
            var marshaller = new DeleteFieldLevelEncryptionConfigRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("DeleteFieldLevelEncryptionConfig", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("NoSuchFieldLevelEncryptionConfigException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = DeleteFieldLevelEncryptionConfigResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void DeleteFieldLevelEncryptionConfig_PreconditionFailedExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteFieldLevelEncryptionConfig");

            var request = InstantiateClassGenerator.Execute<DeleteFieldLevelEncryptionConfigRequest>();
            var marshaller = new DeleteFieldLevelEncryptionConfigRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("DeleteFieldLevelEncryptionConfig", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("PreconditionFailedException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = DeleteFieldLevelEncryptionConfigResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
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
        public void DeleteFieldLevelEncryptionProfile_AccessDeniedExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteFieldLevelEncryptionProfile");

            var request = InstantiateClassGenerator.Execute<DeleteFieldLevelEncryptionProfileRequest>();
            var marshaller = new DeleteFieldLevelEncryptionProfileRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("DeleteFieldLevelEncryptionProfile", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("AccessDeniedException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = DeleteFieldLevelEncryptionProfileResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void DeleteFieldLevelEncryptionProfile_FieldLevelEncryptionProfileInUseExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteFieldLevelEncryptionProfile");

            var request = InstantiateClassGenerator.Execute<DeleteFieldLevelEncryptionProfileRequest>();
            var marshaller = new DeleteFieldLevelEncryptionProfileRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("DeleteFieldLevelEncryptionProfile", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("FieldLevelEncryptionProfileInUseException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = DeleteFieldLevelEncryptionProfileResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void DeleteFieldLevelEncryptionProfile_InvalidIfMatchVersionExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteFieldLevelEncryptionProfile");

            var request = InstantiateClassGenerator.Execute<DeleteFieldLevelEncryptionProfileRequest>();
            var marshaller = new DeleteFieldLevelEncryptionProfileRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("DeleteFieldLevelEncryptionProfile", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidIfMatchVersionException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = DeleteFieldLevelEncryptionProfileResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void DeleteFieldLevelEncryptionProfile_NoSuchFieldLevelEncryptionProfileExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteFieldLevelEncryptionProfile");

            var request = InstantiateClassGenerator.Execute<DeleteFieldLevelEncryptionProfileRequest>();
            var marshaller = new DeleteFieldLevelEncryptionProfileRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("DeleteFieldLevelEncryptionProfile", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("NoSuchFieldLevelEncryptionProfileException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = DeleteFieldLevelEncryptionProfileResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void DeleteFieldLevelEncryptionProfile_PreconditionFailedExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteFieldLevelEncryptionProfile");

            var request = InstantiateClassGenerator.Execute<DeleteFieldLevelEncryptionProfileRequest>();
            var marshaller = new DeleteFieldLevelEncryptionProfileRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("DeleteFieldLevelEncryptionProfile", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("PreconditionFailedException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = DeleteFieldLevelEncryptionProfileResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void DeleteKeyGroupMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteKeyGroup");

            var request = InstantiateClassGenerator.Execute<DeleteKeyGroupRequest>();
            var marshaller = new DeleteKeyGroupRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("DeleteKeyGroup", request, internalRequest, service_model);            

        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void DeleteKeyGroup_InvalidIfMatchVersionExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteKeyGroup");

            var request = InstantiateClassGenerator.Execute<DeleteKeyGroupRequest>();
            var marshaller = new DeleteKeyGroupRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("DeleteKeyGroup", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidIfMatchVersionException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = DeleteKeyGroupResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void DeleteKeyGroup_NoSuchResourceExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteKeyGroup");

            var request = InstantiateClassGenerator.Execute<DeleteKeyGroupRequest>();
            var marshaller = new DeleteKeyGroupRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("DeleteKeyGroup", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("NoSuchResourceException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = DeleteKeyGroupResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void DeleteKeyGroup_PreconditionFailedExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteKeyGroup");

            var request = InstantiateClassGenerator.Execute<DeleteKeyGroupRequest>();
            var marshaller = new DeleteKeyGroupRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("DeleteKeyGroup", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("PreconditionFailedException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = DeleteKeyGroupResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void DeleteKeyGroup_ResourceInUseExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteKeyGroup");

            var request = InstantiateClassGenerator.Execute<DeleteKeyGroupRequest>();
            var marshaller = new DeleteKeyGroupRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("DeleteKeyGroup", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("ResourceInUseException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = DeleteKeyGroupResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void DeleteMonitoringSubscriptionMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteMonitoringSubscription");

            var request = InstantiateClassGenerator.Execute<DeleteMonitoringSubscriptionRequest>();
            var marshaller = new DeleteMonitoringSubscriptionRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("DeleteMonitoringSubscription", request, internalRequest, service_model);            

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            webResponse.ContentLength = payloadResponse.Length;
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = DeleteMonitoringSubscriptionResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as DeleteMonitoringSubscriptionResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void DeleteMonitoringSubscription_AccessDeniedExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteMonitoringSubscription");

            var request = InstantiateClassGenerator.Execute<DeleteMonitoringSubscriptionRequest>();
            var marshaller = new DeleteMonitoringSubscriptionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("DeleteMonitoringSubscription", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("AccessDeniedException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = DeleteMonitoringSubscriptionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void DeleteMonitoringSubscription_NoSuchDistributionExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteMonitoringSubscription");

            var request = InstantiateClassGenerator.Execute<DeleteMonitoringSubscriptionRequest>();
            var marshaller = new DeleteMonitoringSubscriptionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("DeleteMonitoringSubscription", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("NoSuchDistributionException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = DeleteMonitoringSubscriptionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void DeleteOriginRequestPolicyMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteOriginRequestPolicy");

            var request = InstantiateClassGenerator.Execute<DeleteOriginRequestPolicyRequest>();
            var marshaller = new DeleteOriginRequestPolicyRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("DeleteOriginRequestPolicy", request, internalRequest, service_model);            

        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void DeleteOriginRequestPolicy_AccessDeniedExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteOriginRequestPolicy");

            var request = InstantiateClassGenerator.Execute<DeleteOriginRequestPolicyRequest>();
            var marshaller = new DeleteOriginRequestPolicyRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("DeleteOriginRequestPolicy", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("AccessDeniedException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = DeleteOriginRequestPolicyResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void DeleteOriginRequestPolicy_IllegalDeleteExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteOriginRequestPolicy");

            var request = InstantiateClassGenerator.Execute<DeleteOriginRequestPolicyRequest>();
            var marshaller = new DeleteOriginRequestPolicyRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("DeleteOriginRequestPolicy", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("IllegalDeleteException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = DeleteOriginRequestPolicyResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void DeleteOriginRequestPolicy_InvalidIfMatchVersionExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteOriginRequestPolicy");

            var request = InstantiateClassGenerator.Execute<DeleteOriginRequestPolicyRequest>();
            var marshaller = new DeleteOriginRequestPolicyRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("DeleteOriginRequestPolicy", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidIfMatchVersionException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = DeleteOriginRequestPolicyResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void DeleteOriginRequestPolicy_NoSuchOriginRequestPolicyExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteOriginRequestPolicy");

            var request = InstantiateClassGenerator.Execute<DeleteOriginRequestPolicyRequest>();
            var marshaller = new DeleteOriginRequestPolicyRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("DeleteOriginRequestPolicy", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("NoSuchOriginRequestPolicyException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = DeleteOriginRequestPolicyResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void DeleteOriginRequestPolicy_OriginRequestPolicyInUseExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteOriginRequestPolicy");

            var request = InstantiateClassGenerator.Execute<DeleteOriginRequestPolicyRequest>();
            var marshaller = new DeleteOriginRequestPolicyRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("DeleteOriginRequestPolicy", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("OriginRequestPolicyInUseException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = DeleteOriginRequestPolicyResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void DeleteOriginRequestPolicy_PreconditionFailedExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteOriginRequestPolicy");

            var request = InstantiateClassGenerator.Execute<DeleteOriginRequestPolicyRequest>();
            var marshaller = new DeleteOriginRequestPolicyRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("DeleteOriginRequestPolicy", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("PreconditionFailedException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = DeleteOriginRequestPolicyResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
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
        public void DeletePublicKey_AccessDeniedExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DeletePublicKey");

            var request = InstantiateClassGenerator.Execute<DeletePublicKeyRequest>();
            var marshaller = new DeletePublicKeyRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("DeletePublicKey", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("AccessDeniedException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = DeletePublicKeyResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void DeletePublicKey_InvalidIfMatchVersionExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DeletePublicKey");

            var request = InstantiateClassGenerator.Execute<DeletePublicKeyRequest>();
            var marshaller = new DeletePublicKeyRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("DeletePublicKey", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidIfMatchVersionException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = DeletePublicKeyResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void DeletePublicKey_NoSuchPublicKeyExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DeletePublicKey");

            var request = InstantiateClassGenerator.Execute<DeletePublicKeyRequest>();
            var marshaller = new DeletePublicKeyRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("DeletePublicKey", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("NoSuchPublicKeyException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = DeletePublicKeyResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void DeletePublicKey_PreconditionFailedExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DeletePublicKey");

            var request = InstantiateClassGenerator.Execute<DeletePublicKeyRequest>();
            var marshaller = new DeletePublicKeyRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("DeletePublicKey", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("PreconditionFailedException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = DeletePublicKeyResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void DeletePublicKey_PublicKeyInUseExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DeletePublicKey");

            var request = InstantiateClassGenerator.Execute<DeletePublicKeyRequest>();
            var marshaller = new DeletePublicKeyRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("DeletePublicKey", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("PublicKeyInUseException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = DeletePublicKeyResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void DeleteRealtimeLogConfigMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteRealtimeLogConfig");

            var request = InstantiateClassGenerator.Execute<DeleteRealtimeLogConfigRequest>();
            var marshaller = new DeleteRealtimeLogConfigRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("DeleteRealtimeLogConfig", request, internalRequest, service_model);            

        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void DeleteRealtimeLogConfig_AccessDeniedExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteRealtimeLogConfig");

            var request = InstantiateClassGenerator.Execute<DeleteRealtimeLogConfigRequest>();
            var marshaller = new DeleteRealtimeLogConfigRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("DeleteRealtimeLogConfig", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("AccessDeniedException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = DeleteRealtimeLogConfigResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void DeleteRealtimeLogConfig_InvalidArgumentExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteRealtimeLogConfig");

            var request = InstantiateClassGenerator.Execute<DeleteRealtimeLogConfigRequest>();
            var marshaller = new DeleteRealtimeLogConfigRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("DeleteRealtimeLogConfig", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidArgumentException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = DeleteRealtimeLogConfigResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void DeleteRealtimeLogConfig_NoSuchRealtimeLogConfigExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteRealtimeLogConfig");

            var request = InstantiateClassGenerator.Execute<DeleteRealtimeLogConfigRequest>();
            var marshaller = new DeleteRealtimeLogConfigRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("DeleteRealtimeLogConfig", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("NoSuchRealtimeLogConfigException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = DeleteRealtimeLogConfigResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void DeleteRealtimeLogConfig_RealtimeLogConfigInUseExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteRealtimeLogConfig");

            var request = InstantiateClassGenerator.Execute<DeleteRealtimeLogConfigRequest>();
            var marshaller = new DeleteRealtimeLogConfigRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("DeleteRealtimeLogConfig", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("RealtimeLogConfigInUseException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = DeleteRealtimeLogConfigResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
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
        public void DeleteStreamingDistribution_AccessDeniedExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteStreamingDistribution");

            var request = InstantiateClassGenerator.Execute<DeleteStreamingDistributionRequest>();
            var marshaller = new DeleteStreamingDistributionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("DeleteStreamingDistribution", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("AccessDeniedException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = DeleteStreamingDistributionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void DeleteStreamingDistribution_InvalidIfMatchVersionExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteStreamingDistribution");

            var request = InstantiateClassGenerator.Execute<DeleteStreamingDistributionRequest>();
            var marshaller = new DeleteStreamingDistributionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("DeleteStreamingDistribution", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidIfMatchVersionException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = DeleteStreamingDistributionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void DeleteStreamingDistribution_NoSuchStreamingDistributionExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteStreamingDistribution");

            var request = InstantiateClassGenerator.Execute<DeleteStreamingDistributionRequest>();
            var marshaller = new DeleteStreamingDistributionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("DeleteStreamingDistribution", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("NoSuchStreamingDistributionException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = DeleteStreamingDistributionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void DeleteStreamingDistribution_PreconditionFailedExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteStreamingDistribution");

            var request = InstantiateClassGenerator.Execute<DeleteStreamingDistributionRequest>();
            var marshaller = new DeleteStreamingDistributionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("DeleteStreamingDistribution", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("PreconditionFailedException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = DeleteStreamingDistributionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void DeleteStreamingDistribution_StreamingDistributionNotDisabledExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteStreamingDistribution");

            var request = InstantiateClassGenerator.Execute<DeleteStreamingDistributionRequest>();
            var marshaller = new DeleteStreamingDistributionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("DeleteStreamingDistribution", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("StreamingDistributionNotDisabledException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = DeleteStreamingDistributionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void GetCachePolicyMarshallTest()
        {
            var operation = service_model.FindOperation("GetCachePolicy");

            var request = InstantiateClassGenerator.Execute<GetCachePolicyRequest>();
            var marshaller = new GetCachePolicyRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("GetCachePolicy", request, internalRequest, service_model);            

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            webResponse.ContentLength = payloadResponse.Length;
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = GetCachePolicyResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as GetCachePolicyResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void GetCachePolicy_AccessDeniedExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("GetCachePolicy");

            var request = InstantiateClassGenerator.Execute<GetCachePolicyRequest>();
            var marshaller = new GetCachePolicyRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("GetCachePolicy", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("AccessDeniedException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = GetCachePolicyResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void GetCachePolicy_NoSuchCachePolicyExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("GetCachePolicy");

            var request = InstantiateClassGenerator.Execute<GetCachePolicyRequest>();
            var marshaller = new GetCachePolicyRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("GetCachePolicy", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("NoSuchCachePolicyException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = GetCachePolicyResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void GetCachePolicyConfigMarshallTest()
        {
            var operation = service_model.FindOperation("GetCachePolicyConfig");

            var request = InstantiateClassGenerator.Execute<GetCachePolicyConfigRequest>();
            var marshaller = new GetCachePolicyConfigRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("GetCachePolicyConfig", request, internalRequest, service_model);            

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            webResponse.ContentLength = payloadResponse.Length;
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = GetCachePolicyConfigResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as GetCachePolicyConfigResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void GetCachePolicyConfig_AccessDeniedExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("GetCachePolicyConfig");

            var request = InstantiateClassGenerator.Execute<GetCachePolicyConfigRequest>();
            var marshaller = new GetCachePolicyConfigRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("GetCachePolicyConfig", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("AccessDeniedException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = GetCachePolicyConfigResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void GetCachePolicyConfig_NoSuchCachePolicyExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("GetCachePolicyConfig");

            var request = InstantiateClassGenerator.Execute<GetCachePolicyConfigRequest>();
            var marshaller = new GetCachePolicyConfigRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("GetCachePolicyConfig", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("NoSuchCachePolicyException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = GetCachePolicyConfigResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
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
            webResponse.ContentLength = payloadResponse.Length;
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
        public void GetCloudFrontOriginAccessIdentity_AccessDeniedExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("GetCloudFrontOriginAccessIdentity");

            var request = InstantiateClassGenerator.Execute<GetCloudFrontOriginAccessIdentityRequest>();
            var marshaller = new GetCloudFrontOriginAccessIdentityRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("GetCloudFrontOriginAccessIdentity", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("AccessDeniedException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = GetCloudFrontOriginAccessIdentityResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void GetCloudFrontOriginAccessIdentity_NoSuchCloudFrontOriginAccessIdentityExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("GetCloudFrontOriginAccessIdentity");

            var request = InstantiateClassGenerator.Execute<GetCloudFrontOriginAccessIdentityRequest>();
            var marshaller = new GetCloudFrontOriginAccessIdentityRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("GetCloudFrontOriginAccessIdentity", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("NoSuchCloudFrontOriginAccessIdentityException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = GetCloudFrontOriginAccessIdentityResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

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
            webResponse.ContentLength = payloadResponse.Length;
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
        public void GetCloudFrontOriginAccessIdentityConfig_AccessDeniedExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("GetCloudFrontOriginAccessIdentityConfig");

            var request = InstantiateClassGenerator.Execute<GetCloudFrontOriginAccessIdentityConfigRequest>();
            var marshaller = new GetCloudFrontOriginAccessIdentityConfigRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("GetCloudFrontOriginAccessIdentityConfig", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("AccessDeniedException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = GetCloudFrontOriginAccessIdentityConfigResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void GetCloudFrontOriginAccessIdentityConfig_NoSuchCloudFrontOriginAccessIdentityExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("GetCloudFrontOriginAccessIdentityConfig");

            var request = InstantiateClassGenerator.Execute<GetCloudFrontOriginAccessIdentityConfigRequest>();
            var marshaller = new GetCloudFrontOriginAccessIdentityConfigRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("GetCloudFrontOriginAccessIdentityConfig", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("NoSuchCloudFrontOriginAccessIdentityException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = GetCloudFrontOriginAccessIdentityConfigResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

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
            webResponse.ContentLength = payloadResponse.Length;
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
        public void GetDistribution_AccessDeniedExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("GetDistribution");

            var request = InstantiateClassGenerator.Execute<GetDistributionRequest>();
            var marshaller = new GetDistributionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("GetDistribution", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("AccessDeniedException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = GetDistributionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void GetDistribution_NoSuchDistributionExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("GetDistribution");

            var request = InstantiateClassGenerator.Execute<GetDistributionRequest>();
            var marshaller = new GetDistributionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("GetDistribution", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("NoSuchDistributionException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = GetDistributionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

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
            webResponse.ContentLength = payloadResponse.Length;
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
        public void GetDistributionConfig_AccessDeniedExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("GetDistributionConfig");

            var request = InstantiateClassGenerator.Execute<GetDistributionConfigRequest>();
            var marshaller = new GetDistributionConfigRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("GetDistributionConfig", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("AccessDeniedException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = GetDistributionConfigResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void GetDistributionConfig_NoSuchDistributionExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("GetDistributionConfig");

            var request = InstantiateClassGenerator.Execute<GetDistributionConfigRequest>();
            var marshaller = new GetDistributionConfigRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("GetDistributionConfig", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("NoSuchDistributionException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = GetDistributionConfigResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

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
            webResponse.ContentLength = payloadResponse.Length;
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
        public void GetFieldLevelEncryption_AccessDeniedExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("GetFieldLevelEncryption");

            var request = InstantiateClassGenerator.Execute<GetFieldLevelEncryptionRequest>();
            var marshaller = new GetFieldLevelEncryptionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("GetFieldLevelEncryption", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("AccessDeniedException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = GetFieldLevelEncryptionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void GetFieldLevelEncryption_NoSuchFieldLevelEncryptionConfigExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("GetFieldLevelEncryption");

            var request = InstantiateClassGenerator.Execute<GetFieldLevelEncryptionRequest>();
            var marshaller = new GetFieldLevelEncryptionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("GetFieldLevelEncryption", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("NoSuchFieldLevelEncryptionConfigException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = GetFieldLevelEncryptionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

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
            webResponse.ContentLength = payloadResponse.Length;
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
        public void GetFieldLevelEncryptionConfig_AccessDeniedExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("GetFieldLevelEncryptionConfig");

            var request = InstantiateClassGenerator.Execute<GetFieldLevelEncryptionConfigRequest>();
            var marshaller = new GetFieldLevelEncryptionConfigRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("GetFieldLevelEncryptionConfig", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("AccessDeniedException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = GetFieldLevelEncryptionConfigResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void GetFieldLevelEncryptionConfig_NoSuchFieldLevelEncryptionConfigExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("GetFieldLevelEncryptionConfig");

            var request = InstantiateClassGenerator.Execute<GetFieldLevelEncryptionConfigRequest>();
            var marshaller = new GetFieldLevelEncryptionConfigRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("GetFieldLevelEncryptionConfig", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("NoSuchFieldLevelEncryptionConfigException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = GetFieldLevelEncryptionConfigResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

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
            webResponse.ContentLength = payloadResponse.Length;
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
        public void GetFieldLevelEncryptionProfile_AccessDeniedExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("GetFieldLevelEncryptionProfile");

            var request = InstantiateClassGenerator.Execute<GetFieldLevelEncryptionProfileRequest>();
            var marshaller = new GetFieldLevelEncryptionProfileRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("GetFieldLevelEncryptionProfile", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("AccessDeniedException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = GetFieldLevelEncryptionProfileResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void GetFieldLevelEncryptionProfile_NoSuchFieldLevelEncryptionProfileExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("GetFieldLevelEncryptionProfile");

            var request = InstantiateClassGenerator.Execute<GetFieldLevelEncryptionProfileRequest>();
            var marshaller = new GetFieldLevelEncryptionProfileRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("GetFieldLevelEncryptionProfile", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("NoSuchFieldLevelEncryptionProfileException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = GetFieldLevelEncryptionProfileResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

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
            webResponse.ContentLength = payloadResponse.Length;
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
        public void GetFieldLevelEncryptionProfileConfig_AccessDeniedExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("GetFieldLevelEncryptionProfileConfig");

            var request = InstantiateClassGenerator.Execute<GetFieldLevelEncryptionProfileConfigRequest>();
            var marshaller = new GetFieldLevelEncryptionProfileConfigRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("GetFieldLevelEncryptionProfileConfig", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("AccessDeniedException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = GetFieldLevelEncryptionProfileConfigResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void GetFieldLevelEncryptionProfileConfig_NoSuchFieldLevelEncryptionProfileExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("GetFieldLevelEncryptionProfileConfig");

            var request = InstantiateClassGenerator.Execute<GetFieldLevelEncryptionProfileConfigRequest>();
            var marshaller = new GetFieldLevelEncryptionProfileConfigRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("GetFieldLevelEncryptionProfileConfig", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("NoSuchFieldLevelEncryptionProfileException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = GetFieldLevelEncryptionProfileConfigResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

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
            webResponse.ContentLength = payloadResponse.Length;
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
        public void GetInvalidation_AccessDeniedExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("GetInvalidation");

            var request = InstantiateClassGenerator.Execute<GetInvalidationRequest>();
            var marshaller = new GetInvalidationRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("GetInvalidation", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("AccessDeniedException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = GetInvalidationResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void GetInvalidation_NoSuchDistributionExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("GetInvalidation");

            var request = InstantiateClassGenerator.Execute<GetInvalidationRequest>();
            var marshaller = new GetInvalidationRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("GetInvalidation", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("NoSuchDistributionException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = GetInvalidationResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void GetInvalidation_NoSuchInvalidationExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("GetInvalidation");

            var request = InstantiateClassGenerator.Execute<GetInvalidationRequest>();
            var marshaller = new GetInvalidationRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("GetInvalidation", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("NoSuchInvalidationException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = GetInvalidationResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void GetKeyGroupMarshallTest()
        {
            var operation = service_model.FindOperation("GetKeyGroup");

            var request = InstantiateClassGenerator.Execute<GetKeyGroupRequest>();
            var marshaller = new GetKeyGroupRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("GetKeyGroup", request, internalRequest, service_model);            

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            webResponse.ContentLength = payloadResponse.Length;
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = GetKeyGroupResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as GetKeyGroupResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void GetKeyGroup_NoSuchResourceExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("GetKeyGroup");

            var request = InstantiateClassGenerator.Execute<GetKeyGroupRequest>();
            var marshaller = new GetKeyGroupRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("GetKeyGroup", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("NoSuchResourceException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = GetKeyGroupResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void GetKeyGroupConfigMarshallTest()
        {
            var operation = service_model.FindOperation("GetKeyGroupConfig");

            var request = InstantiateClassGenerator.Execute<GetKeyGroupConfigRequest>();
            var marshaller = new GetKeyGroupConfigRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("GetKeyGroupConfig", request, internalRequest, service_model);            

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            webResponse.ContentLength = payloadResponse.Length;
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = GetKeyGroupConfigResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as GetKeyGroupConfigResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void GetKeyGroupConfig_NoSuchResourceExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("GetKeyGroupConfig");

            var request = InstantiateClassGenerator.Execute<GetKeyGroupConfigRequest>();
            var marshaller = new GetKeyGroupConfigRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("GetKeyGroupConfig", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("NoSuchResourceException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = GetKeyGroupConfigResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void GetMonitoringSubscriptionMarshallTest()
        {
            var operation = service_model.FindOperation("GetMonitoringSubscription");

            var request = InstantiateClassGenerator.Execute<GetMonitoringSubscriptionRequest>();
            var marshaller = new GetMonitoringSubscriptionRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("GetMonitoringSubscription", request, internalRequest, service_model);            

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            webResponse.ContentLength = payloadResponse.Length;
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = GetMonitoringSubscriptionResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as GetMonitoringSubscriptionResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void GetMonitoringSubscription_AccessDeniedExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("GetMonitoringSubscription");

            var request = InstantiateClassGenerator.Execute<GetMonitoringSubscriptionRequest>();
            var marshaller = new GetMonitoringSubscriptionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("GetMonitoringSubscription", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("AccessDeniedException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = GetMonitoringSubscriptionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void GetMonitoringSubscription_NoSuchDistributionExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("GetMonitoringSubscription");

            var request = InstantiateClassGenerator.Execute<GetMonitoringSubscriptionRequest>();
            var marshaller = new GetMonitoringSubscriptionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("GetMonitoringSubscription", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("NoSuchDistributionException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = GetMonitoringSubscriptionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void GetOriginRequestPolicyMarshallTest()
        {
            var operation = service_model.FindOperation("GetOriginRequestPolicy");

            var request = InstantiateClassGenerator.Execute<GetOriginRequestPolicyRequest>();
            var marshaller = new GetOriginRequestPolicyRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("GetOriginRequestPolicy", request, internalRequest, service_model);            

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            webResponse.ContentLength = payloadResponse.Length;
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = GetOriginRequestPolicyResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as GetOriginRequestPolicyResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void GetOriginRequestPolicy_AccessDeniedExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("GetOriginRequestPolicy");

            var request = InstantiateClassGenerator.Execute<GetOriginRequestPolicyRequest>();
            var marshaller = new GetOriginRequestPolicyRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("GetOriginRequestPolicy", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("AccessDeniedException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = GetOriginRequestPolicyResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void GetOriginRequestPolicy_NoSuchOriginRequestPolicyExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("GetOriginRequestPolicy");

            var request = InstantiateClassGenerator.Execute<GetOriginRequestPolicyRequest>();
            var marshaller = new GetOriginRequestPolicyRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("GetOriginRequestPolicy", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("NoSuchOriginRequestPolicyException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = GetOriginRequestPolicyResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void GetOriginRequestPolicyConfigMarshallTest()
        {
            var operation = service_model.FindOperation("GetOriginRequestPolicyConfig");

            var request = InstantiateClassGenerator.Execute<GetOriginRequestPolicyConfigRequest>();
            var marshaller = new GetOriginRequestPolicyConfigRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("GetOriginRequestPolicyConfig", request, internalRequest, service_model);            

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            webResponse.ContentLength = payloadResponse.Length;
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = GetOriginRequestPolicyConfigResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as GetOriginRequestPolicyConfigResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void GetOriginRequestPolicyConfig_AccessDeniedExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("GetOriginRequestPolicyConfig");

            var request = InstantiateClassGenerator.Execute<GetOriginRequestPolicyConfigRequest>();
            var marshaller = new GetOriginRequestPolicyConfigRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("GetOriginRequestPolicyConfig", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("AccessDeniedException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = GetOriginRequestPolicyConfigResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void GetOriginRequestPolicyConfig_NoSuchOriginRequestPolicyExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("GetOriginRequestPolicyConfig");

            var request = InstantiateClassGenerator.Execute<GetOriginRequestPolicyConfigRequest>();
            var marshaller = new GetOriginRequestPolicyConfigRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("GetOriginRequestPolicyConfig", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("NoSuchOriginRequestPolicyException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = GetOriginRequestPolicyConfigResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

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
            webResponse.ContentLength = payloadResponse.Length;
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
        public void GetPublicKey_AccessDeniedExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("GetPublicKey");

            var request = InstantiateClassGenerator.Execute<GetPublicKeyRequest>();
            var marshaller = new GetPublicKeyRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("GetPublicKey", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("AccessDeniedException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = GetPublicKeyResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void GetPublicKey_NoSuchPublicKeyExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("GetPublicKey");

            var request = InstantiateClassGenerator.Execute<GetPublicKeyRequest>();
            var marshaller = new GetPublicKeyRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("GetPublicKey", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("NoSuchPublicKeyException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = GetPublicKeyResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

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
            webResponse.ContentLength = payloadResponse.Length;
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
        public void GetPublicKeyConfig_AccessDeniedExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("GetPublicKeyConfig");

            var request = InstantiateClassGenerator.Execute<GetPublicKeyConfigRequest>();
            var marshaller = new GetPublicKeyConfigRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("GetPublicKeyConfig", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("AccessDeniedException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = GetPublicKeyConfigResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void GetPublicKeyConfig_NoSuchPublicKeyExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("GetPublicKeyConfig");

            var request = InstantiateClassGenerator.Execute<GetPublicKeyConfigRequest>();
            var marshaller = new GetPublicKeyConfigRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("GetPublicKeyConfig", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("NoSuchPublicKeyException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = GetPublicKeyConfigResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void GetRealtimeLogConfigMarshallTest()
        {
            var operation = service_model.FindOperation("GetRealtimeLogConfig");

            var request = InstantiateClassGenerator.Execute<GetRealtimeLogConfigRequest>();
            var marshaller = new GetRealtimeLogConfigRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("GetRealtimeLogConfig", request, internalRequest, service_model);            

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            webResponse.ContentLength = payloadResponse.Length;
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = GetRealtimeLogConfigResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as GetRealtimeLogConfigResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void GetRealtimeLogConfig_AccessDeniedExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("GetRealtimeLogConfig");

            var request = InstantiateClassGenerator.Execute<GetRealtimeLogConfigRequest>();
            var marshaller = new GetRealtimeLogConfigRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("GetRealtimeLogConfig", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("AccessDeniedException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = GetRealtimeLogConfigResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void GetRealtimeLogConfig_InvalidArgumentExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("GetRealtimeLogConfig");

            var request = InstantiateClassGenerator.Execute<GetRealtimeLogConfigRequest>();
            var marshaller = new GetRealtimeLogConfigRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("GetRealtimeLogConfig", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidArgumentException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = GetRealtimeLogConfigResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void GetRealtimeLogConfig_NoSuchRealtimeLogConfigExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("GetRealtimeLogConfig");

            var request = InstantiateClassGenerator.Execute<GetRealtimeLogConfigRequest>();
            var marshaller = new GetRealtimeLogConfigRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("GetRealtimeLogConfig", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("NoSuchRealtimeLogConfigException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = GetRealtimeLogConfigResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

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
            webResponse.ContentLength = payloadResponse.Length;
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
        public void GetStreamingDistribution_AccessDeniedExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("GetStreamingDistribution");

            var request = InstantiateClassGenerator.Execute<GetStreamingDistributionRequest>();
            var marshaller = new GetStreamingDistributionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("GetStreamingDistribution", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("AccessDeniedException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = GetStreamingDistributionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void GetStreamingDistribution_NoSuchStreamingDistributionExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("GetStreamingDistribution");

            var request = InstantiateClassGenerator.Execute<GetStreamingDistributionRequest>();
            var marshaller = new GetStreamingDistributionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("GetStreamingDistribution", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("NoSuchStreamingDistributionException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = GetStreamingDistributionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

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
            webResponse.ContentLength = payloadResponse.Length;
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
        public void GetStreamingDistributionConfig_AccessDeniedExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("GetStreamingDistributionConfig");

            var request = InstantiateClassGenerator.Execute<GetStreamingDistributionConfigRequest>();
            var marshaller = new GetStreamingDistributionConfigRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("GetStreamingDistributionConfig", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("AccessDeniedException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = GetStreamingDistributionConfigResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void GetStreamingDistributionConfig_NoSuchStreamingDistributionExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("GetStreamingDistributionConfig");

            var request = InstantiateClassGenerator.Execute<GetStreamingDistributionConfigRequest>();
            var marshaller = new GetStreamingDistributionConfigRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("GetStreamingDistributionConfig", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("NoSuchStreamingDistributionException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = GetStreamingDistributionConfigResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void ListCachePoliciesMarshallTest()
        {
            var operation = service_model.FindOperation("ListCachePolicies");

            var request = InstantiateClassGenerator.Execute<ListCachePoliciesRequest>();
            var marshaller = new ListCachePoliciesRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("ListCachePolicies", request, internalRequest, service_model);            

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            webResponse.ContentLength = payloadResponse.Length;
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = ListCachePoliciesResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as ListCachePoliciesResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void ListCachePolicies_AccessDeniedExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ListCachePolicies");

            var request = InstantiateClassGenerator.Execute<ListCachePoliciesRequest>();
            var marshaller = new ListCachePoliciesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("ListCachePolicies", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("AccessDeniedException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = ListCachePoliciesResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void ListCachePolicies_InvalidArgumentExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ListCachePolicies");

            var request = InstantiateClassGenerator.Execute<ListCachePoliciesRequest>();
            var marshaller = new ListCachePoliciesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("ListCachePolicies", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidArgumentException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = ListCachePoliciesResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void ListCachePolicies_NoSuchCachePolicyExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ListCachePolicies");

            var request = InstantiateClassGenerator.Execute<ListCachePoliciesRequest>();
            var marshaller = new ListCachePoliciesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("ListCachePolicies", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("NoSuchCachePolicyException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = ListCachePoliciesResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

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
            webResponse.ContentLength = payloadResponse.Length;
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
        public void ListCloudFrontOriginAccessIdentities_InvalidArgumentExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ListCloudFrontOriginAccessIdentities");

            var request = InstantiateClassGenerator.Execute<ListCloudFrontOriginAccessIdentitiesRequest>();
            var marshaller = new ListCloudFrontOriginAccessIdentitiesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("ListCloudFrontOriginAccessIdentities", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidArgumentException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = ListCloudFrontOriginAccessIdentitiesResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

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
            webResponse.ContentLength = payloadResponse.Length;
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
        public void ListDistributions_InvalidArgumentExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ListDistributions");

            var request = InstantiateClassGenerator.Execute<ListDistributionsRequest>();
            var marshaller = new ListDistributionsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("ListDistributions", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidArgumentException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = ListDistributionsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void ListDistributionsByCachePolicyIdMarshallTest()
        {
            var operation = service_model.FindOperation("ListDistributionsByCachePolicyId");

            var request = InstantiateClassGenerator.Execute<ListDistributionsByCachePolicyIdRequest>();
            var marshaller = new ListDistributionsByCachePolicyIdRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("ListDistributionsByCachePolicyId", request, internalRequest, service_model);            

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            webResponse.ContentLength = payloadResponse.Length;
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = ListDistributionsByCachePolicyIdResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as ListDistributionsByCachePolicyIdResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void ListDistributionsByCachePolicyId_AccessDeniedExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ListDistributionsByCachePolicyId");

            var request = InstantiateClassGenerator.Execute<ListDistributionsByCachePolicyIdRequest>();
            var marshaller = new ListDistributionsByCachePolicyIdRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("ListDistributionsByCachePolicyId", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("AccessDeniedException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = ListDistributionsByCachePolicyIdResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void ListDistributionsByCachePolicyId_InvalidArgumentExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ListDistributionsByCachePolicyId");

            var request = InstantiateClassGenerator.Execute<ListDistributionsByCachePolicyIdRequest>();
            var marshaller = new ListDistributionsByCachePolicyIdRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("ListDistributionsByCachePolicyId", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidArgumentException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = ListDistributionsByCachePolicyIdResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void ListDistributionsByCachePolicyId_NoSuchCachePolicyExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ListDistributionsByCachePolicyId");

            var request = InstantiateClassGenerator.Execute<ListDistributionsByCachePolicyIdRequest>();
            var marshaller = new ListDistributionsByCachePolicyIdRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("ListDistributionsByCachePolicyId", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("NoSuchCachePolicyException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = ListDistributionsByCachePolicyIdResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void ListDistributionsByKeyGroupMarshallTest()
        {
            var operation = service_model.FindOperation("ListDistributionsByKeyGroup");

            var request = InstantiateClassGenerator.Execute<ListDistributionsByKeyGroupRequest>();
            var marshaller = new ListDistributionsByKeyGroupRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("ListDistributionsByKeyGroup", request, internalRequest, service_model);            

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            webResponse.ContentLength = payloadResponse.Length;
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = ListDistributionsByKeyGroupResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as ListDistributionsByKeyGroupResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void ListDistributionsByKeyGroup_InvalidArgumentExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ListDistributionsByKeyGroup");

            var request = InstantiateClassGenerator.Execute<ListDistributionsByKeyGroupRequest>();
            var marshaller = new ListDistributionsByKeyGroupRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("ListDistributionsByKeyGroup", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidArgumentException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = ListDistributionsByKeyGroupResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void ListDistributionsByKeyGroup_NoSuchResourceExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ListDistributionsByKeyGroup");

            var request = InstantiateClassGenerator.Execute<ListDistributionsByKeyGroupRequest>();
            var marshaller = new ListDistributionsByKeyGroupRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("ListDistributionsByKeyGroup", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("NoSuchResourceException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = ListDistributionsByKeyGroupResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void ListDistributionsByOriginRequestPolicyIdMarshallTest()
        {
            var operation = service_model.FindOperation("ListDistributionsByOriginRequestPolicyId");

            var request = InstantiateClassGenerator.Execute<ListDistributionsByOriginRequestPolicyIdRequest>();
            var marshaller = new ListDistributionsByOriginRequestPolicyIdRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("ListDistributionsByOriginRequestPolicyId", request, internalRequest, service_model);            

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            webResponse.ContentLength = payloadResponse.Length;
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = ListDistributionsByOriginRequestPolicyIdResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as ListDistributionsByOriginRequestPolicyIdResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void ListDistributionsByOriginRequestPolicyId_AccessDeniedExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ListDistributionsByOriginRequestPolicyId");

            var request = InstantiateClassGenerator.Execute<ListDistributionsByOriginRequestPolicyIdRequest>();
            var marshaller = new ListDistributionsByOriginRequestPolicyIdRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("ListDistributionsByOriginRequestPolicyId", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("AccessDeniedException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = ListDistributionsByOriginRequestPolicyIdResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void ListDistributionsByOriginRequestPolicyId_InvalidArgumentExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ListDistributionsByOriginRequestPolicyId");

            var request = InstantiateClassGenerator.Execute<ListDistributionsByOriginRequestPolicyIdRequest>();
            var marshaller = new ListDistributionsByOriginRequestPolicyIdRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("ListDistributionsByOriginRequestPolicyId", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidArgumentException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = ListDistributionsByOriginRequestPolicyIdResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void ListDistributionsByOriginRequestPolicyId_NoSuchOriginRequestPolicyExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ListDistributionsByOriginRequestPolicyId");

            var request = InstantiateClassGenerator.Execute<ListDistributionsByOriginRequestPolicyIdRequest>();
            var marshaller = new ListDistributionsByOriginRequestPolicyIdRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("ListDistributionsByOriginRequestPolicyId", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("NoSuchOriginRequestPolicyException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = ListDistributionsByOriginRequestPolicyIdResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void ListDistributionsByRealtimeLogConfigMarshallTest()
        {
            var operation = service_model.FindOperation("ListDistributionsByRealtimeLogConfig");

            var request = InstantiateClassGenerator.Execute<ListDistributionsByRealtimeLogConfigRequest>();
            var marshaller = new ListDistributionsByRealtimeLogConfigRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("ListDistributionsByRealtimeLogConfig", request, internalRequest, service_model);            

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            webResponse.ContentLength = payloadResponse.Length;
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = ListDistributionsByRealtimeLogConfigResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as ListDistributionsByRealtimeLogConfigResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void ListDistributionsByRealtimeLogConfig_InvalidArgumentExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ListDistributionsByRealtimeLogConfig");

            var request = InstantiateClassGenerator.Execute<ListDistributionsByRealtimeLogConfigRequest>();
            var marshaller = new ListDistributionsByRealtimeLogConfigRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("ListDistributionsByRealtimeLogConfig", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidArgumentException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = ListDistributionsByRealtimeLogConfigResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

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
            webResponse.ContentLength = payloadResponse.Length;
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
        public void ListDistributionsByWebACLId_InvalidArgumentExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ListDistributionsByWebACLId");

            var request = InstantiateClassGenerator.Execute<ListDistributionsByWebACLIdRequest>();
            var marshaller = new ListDistributionsByWebACLIdRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("ListDistributionsByWebACLId", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidArgumentException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = ListDistributionsByWebACLIdResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void ListDistributionsByWebACLId_InvalidWebACLIdExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ListDistributionsByWebACLId");

            var request = InstantiateClassGenerator.Execute<ListDistributionsByWebACLIdRequest>();
            var marshaller = new ListDistributionsByWebACLIdRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("ListDistributionsByWebACLId", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidWebACLIdException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = ListDistributionsByWebACLIdResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

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
            webResponse.ContentLength = payloadResponse.Length;
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
        public void ListFieldLevelEncryptionConfigs_InvalidArgumentExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ListFieldLevelEncryptionConfigs");

            var request = InstantiateClassGenerator.Execute<ListFieldLevelEncryptionConfigsRequest>();
            var marshaller = new ListFieldLevelEncryptionConfigsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("ListFieldLevelEncryptionConfigs", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidArgumentException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = ListFieldLevelEncryptionConfigsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

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
            webResponse.ContentLength = payloadResponse.Length;
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
        public void ListFieldLevelEncryptionProfiles_InvalidArgumentExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ListFieldLevelEncryptionProfiles");

            var request = InstantiateClassGenerator.Execute<ListFieldLevelEncryptionProfilesRequest>();
            var marshaller = new ListFieldLevelEncryptionProfilesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("ListFieldLevelEncryptionProfiles", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidArgumentException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = ListFieldLevelEncryptionProfilesResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

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
            webResponse.ContentLength = payloadResponse.Length;
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
        public void ListInvalidations_AccessDeniedExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ListInvalidations");

            var request = InstantiateClassGenerator.Execute<ListInvalidationsRequest>();
            var marshaller = new ListInvalidationsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("ListInvalidations", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("AccessDeniedException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = ListInvalidationsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void ListInvalidations_InvalidArgumentExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ListInvalidations");

            var request = InstantiateClassGenerator.Execute<ListInvalidationsRequest>();
            var marshaller = new ListInvalidationsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("ListInvalidations", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidArgumentException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = ListInvalidationsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void ListInvalidations_NoSuchDistributionExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ListInvalidations");

            var request = InstantiateClassGenerator.Execute<ListInvalidationsRequest>();
            var marshaller = new ListInvalidationsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("ListInvalidations", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("NoSuchDistributionException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = ListInvalidationsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void ListKeyGroupsMarshallTest()
        {
            var operation = service_model.FindOperation("ListKeyGroups");

            var request = InstantiateClassGenerator.Execute<ListKeyGroupsRequest>();
            var marshaller = new ListKeyGroupsRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("ListKeyGroups", request, internalRequest, service_model);            

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            webResponse.ContentLength = payloadResponse.Length;
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = ListKeyGroupsResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as ListKeyGroupsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void ListKeyGroups_InvalidArgumentExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ListKeyGroups");

            var request = InstantiateClassGenerator.Execute<ListKeyGroupsRequest>();
            var marshaller = new ListKeyGroupsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("ListKeyGroups", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidArgumentException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = ListKeyGroupsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void ListOriginRequestPoliciesMarshallTest()
        {
            var operation = service_model.FindOperation("ListOriginRequestPolicies");

            var request = InstantiateClassGenerator.Execute<ListOriginRequestPoliciesRequest>();
            var marshaller = new ListOriginRequestPoliciesRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("ListOriginRequestPolicies", request, internalRequest, service_model);            

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            webResponse.ContentLength = payloadResponse.Length;
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = ListOriginRequestPoliciesResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as ListOriginRequestPoliciesResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void ListOriginRequestPolicies_AccessDeniedExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ListOriginRequestPolicies");

            var request = InstantiateClassGenerator.Execute<ListOriginRequestPoliciesRequest>();
            var marshaller = new ListOriginRequestPoliciesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("ListOriginRequestPolicies", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("AccessDeniedException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = ListOriginRequestPoliciesResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void ListOriginRequestPolicies_InvalidArgumentExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ListOriginRequestPolicies");

            var request = InstantiateClassGenerator.Execute<ListOriginRequestPoliciesRequest>();
            var marshaller = new ListOriginRequestPoliciesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("ListOriginRequestPolicies", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidArgumentException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = ListOriginRequestPoliciesResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void ListOriginRequestPolicies_NoSuchOriginRequestPolicyExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ListOriginRequestPolicies");

            var request = InstantiateClassGenerator.Execute<ListOriginRequestPoliciesRequest>();
            var marshaller = new ListOriginRequestPoliciesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("ListOriginRequestPolicies", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("NoSuchOriginRequestPolicyException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = ListOriginRequestPoliciesResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

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
            webResponse.ContentLength = payloadResponse.Length;
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
        public void ListPublicKeys_InvalidArgumentExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ListPublicKeys");

            var request = InstantiateClassGenerator.Execute<ListPublicKeysRequest>();
            var marshaller = new ListPublicKeysRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("ListPublicKeys", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidArgumentException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = ListPublicKeysResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void ListRealtimeLogConfigsMarshallTest()
        {
            var operation = service_model.FindOperation("ListRealtimeLogConfigs");

            var request = InstantiateClassGenerator.Execute<ListRealtimeLogConfigsRequest>();
            var marshaller = new ListRealtimeLogConfigsRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("ListRealtimeLogConfigs", request, internalRequest, service_model);            

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            webResponse.ContentLength = payloadResponse.Length;
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = ListRealtimeLogConfigsResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as ListRealtimeLogConfigsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void ListRealtimeLogConfigs_AccessDeniedExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ListRealtimeLogConfigs");

            var request = InstantiateClassGenerator.Execute<ListRealtimeLogConfigsRequest>();
            var marshaller = new ListRealtimeLogConfigsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("ListRealtimeLogConfigs", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("AccessDeniedException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = ListRealtimeLogConfigsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void ListRealtimeLogConfigs_InvalidArgumentExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ListRealtimeLogConfigs");

            var request = InstantiateClassGenerator.Execute<ListRealtimeLogConfigsRequest>();
            var marshaller = new ListRealtimeLogConfigsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("ListRealtimeLogConfigs", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidArgumentException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = ListRealtimeLogConfigsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void ListRealtimeLogConfigs_NoSuchRealtimeLogConfigExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ListRealtimeLogConfigs");

            var request = InstantiateClassGenerator.Execute<ListRealtimeLogConfigsRequest>();
            var marshaller = new ListRealtimeLogConfigsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("ListRealtimeLogConfigs", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("NoSuchRealtimeLogConfigException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = ListRealtimeLogConfigsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

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
            webResponse.ContentLength = payloadResponse.Length;
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
        public void ListStreamingDistributions_InvalidArgumentExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ListStreamingDistributions");

            var request = InstantiateClassGenerator.Execute<ListStreamingDistributionsRequest>();
            var marshaller = new ListStreamingDistributionsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("ListStreamingDistributions", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidArgumentException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = ListStreamingDistributionsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

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
            webResponse.ContentLength = payloadResponse.Length;
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
        public void ListTagsForResource_AccessDeniedExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ListTagsForResource");

            var request = InstantiateClassGenerator.Execute<ListTagsForResourceRequest>();
            var marshaller = new ListTagsForResourceRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("ListTagsForResource", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("AccessDeniedException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = ListTagsForResourceResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void ListTagsForResource_InvalidArgumentExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ListTagsForResource");

            var request = InstantiateClassGenerator.Execute<ListTagsForResourceRequest>();
            var marshaller = new ListTagsForResourceRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("ListTagsForResource", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidArgumentException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = ListTagsForResourceResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void ListTagsForResource_InvalidTaggingExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ListTagsForResource");

            var request = InstantiateClassGenerator.Execute<ListTagsForResourceRequest>();
            var marshaller = new ListTagsForResourceRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("ListTagsForResource", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidTaggingException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = ListTagsForResourceResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void ListTagsForResource_NoSuchResourceExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ListTagsForResource");

            var request = InstantiateClassGenerator.Execute<ListTagsForResourceRequest>();
            var marshaller = new ListTagsForResourceRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("ListTagsForResource", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("NoSuchResourceException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = ListTagsForResourceResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

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
        public void TagResource_AccessDeniedExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("TagResource");

            var request = InstantiateClassGenerator.Execute<TagResourceRequest>();
            var marshaller = new TagResourceRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("TagResource", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("AccessDeniedException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = TagResourceResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void TagResource_InvalidArgumentExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("TagResource");

            var request = InstantiateClassGenerator.Execute<TagResourceRequest>();
            var marshaller = new TagResourceRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("TagResource", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidArgumentException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = TagResourceResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void TagResource_InvalidTaggingExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("TagResource");

            var request = InstantiateClassGenerator.Execute<TagResourceRequest>();
            var marshaller = new TagResourceRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("TagResource", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidTaggingException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = TagResourceResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void TagResource_NoSuchResourceExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("TagResource");

            var request = InstantiateClassGenerator.Execute<TagResourceRequest>();
            var marshaller = new TagResourceRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("TagResource", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("NoSuchResourceException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = TagResourceResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
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
        public void UntagResource_AccessDeniedExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("UntagResource");

            var request = InstantiateClassGenerator.Execute<UntagResourceRequest>();
            var marshaller = new UntagResourceRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("UntagResource", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("AccessDeniedException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = UntagResourceResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void UntagResource_InvalidArgumentExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("UntagResource");

            var request = InstantiateClassGenerator.Execute<UntagResourceRequest>();
            var marshaller = new UntagResourceRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("UntagResource", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidArgumentException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = UntagResourceResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void UntagResource_InvalidTaggingExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("UntagResource");

            var request = InstantiateClassGenerator.Execute<UntagResourceRequest>();
            var marshaller = new UntagResourceRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("UntagResource", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidTaggingException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = UntagResourceResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void UntagResource_NoSuchResourceExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("UntagResource");

            var request = InstantiateClassGenerator.Execute<UntagResourceRequest>();
            var marshaller = new UntagResourceRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("UntagResource", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("NoSuchResourceException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = UntagResourceResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void UpdateCachePolicyMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateCachePolicy");

            var request = InstantiateClassGenerator.Execute<UpdateCachePolicyRequest>();
            var marshaller = new UpdateCachePolicyRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("UpdateCachePolicy", request, internalRequest, service_model);            

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            webResponse.ContentLength = payloadResponse.Length;
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = UpdateCachePolicyResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as UpdateCachePolicyResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void UpdateCachePolicy_AccessDeniedExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateCachePolicy");

            var request = InstantiateClassGenerator.Execute<UpdateCachePolicyRequest>();
            var marshaller = new UpdateCachePolicyRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("UpdateCachePolicy", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("AccessDeniedException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = UpdateCachePolicyResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void UpdateCachePolicy_CachePolicyAlreadyExistsExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateCachePolicy");

            var request = InstantiateClassGenerator.Execute<UpdateCachePolicyRequest>();
            var marshaller = new UpdateCachePolicyRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("UpdateCachePolicy", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("CachePolicyAlreadyExistsException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = UpdateCachePolicyResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void UpdateCachePolicy_IllegalUpdateExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateCachePolicy");

            var request = InstantiateClassGenerator.Execute<UpdateCachePolicyRequest>();
            var marshaller = new UpdateCachePolicyRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("UpdateCachePolicy", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("IllegalUpdateException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = UpdateCachePolicyResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void UpdateCachePolicy_InconsistentQuantitiesExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateCachePolicy");

            var request = InstantiateClassGenerator.Execute<UpdateCachePolicyRequest>();
            var marshaller = new UpdateCachePolicyRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("UpdateCachePolicy", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InconsistentQuantitiesException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = UpdateCachePolicyResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void UpdateCachePolicy_InvalidArgumentExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateCachePolicy");

            var request = InstantiateClassGenerator.Execute<UpdateCachePolicyRequest>();
            var marshaller = new UpdateCachePolicyRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("UpdateCachePolicy", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidArgumentException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = UpdateCachePolicyResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void UpdateCachePolicy_InvalidIfMatchVersionExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateCachePolicy");

            var request = InstantiateClassGenerator.Execute<UpdateCachePolicyRequest>();
            var marshaller = new UpdateCachePolicyRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("UpdateCachePolicy", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidIfMatchVersionException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = UpdateCachePolicyResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void UpdateCachePolicy_NoSuchCachePolicyExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateCachePolicy");

            var request = InstantiateClassGenerator.Execute<UpdateCachePolicyRequest>();
            var marshaller = new UpdateCachePolicyRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("UpdateCachePolicy", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("NoSuchCachePolicyException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = UpdateCachePolicyResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void UpdateCachePolicy_PreconditionFailedExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateCachePolicy");

            var request = InstantiateClassGenerator.Execute<UpdateCachePolicyRequest>();
            var marshaller = new UpdateCachePolicyRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("UpdateCachePolicy", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("PreconditionFailedException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = UpdateCachePolicyResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void UpdateCachePolicy_TooManyCookiesInCachePolicyExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateCachePolicy");

            var request = InstantiateClassGenerator.Execute<UpdateCachePolicyRequest>();
            var marshaller = new UpdateCachePolicyRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("UpdateCachePolicy", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("TooManyCookiesInCachePolicyException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = UpdateCachePolicyResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void UpdateCachePolicy_TooManyHeadersInCachePolicyExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateCachePolicy");

            var request = InstantiateClassGenerator.Execute<UpdateCachePolicyRequest>();
            var marshaller = new UpdateCachePolicyRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("UpdateCachePolicy", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("TooManyHeadersInCachePolicyException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = UpdateCachePolicyResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void UpdateCachePolicy_TooManyQueryStringsInCachePolicyExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateCachePolicy");

            var request = InstantiateClassGenerator.Execute<UpdateCachePolicyRequest>();
            var marshaller = new UpdateCachePolicyRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("UpdateCachePolicy", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("TooManyQueryStringsInCachePolicyException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = UpdateCachePolicyResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

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
            webResponse.ContentLength = payloadResponse.Length;
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
        public void UpdateCloudFrontOriginAccessIdentity_AccessDeniedExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateCloudFrontOriginAccessIdentity");

            var request = InstantiateClassGenerator.Execute<UpdateCloudFrontOriginAccessIdentityRequest>();
            var marshaller = new UpdateCloudFrontOriginAccessIdentityRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("UpdateCloudFrontOriginAccessIdentity", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("AccessDeniedException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = UpdateCloudFrontOriginAccessIdentityResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void UpdateCloudFrontOriginAccessIdentity_IllegalUpdateExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateCloudFrontOriginAccessIdentity");

            var request = InstantiateClassGenerator.Execute<UpdateCloudFrontOriginAccessIdentityRequest>();
            var marshaller = new UpdateCloudFrontOriginAccessIdentityRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("UpdateCloudFrontOriginAccessIdentity", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("IllegalUpdateException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = UpdateCloudFrontOriginAccessIdentityResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void UpdateCloudFrontOriginAccessIdentity_InconsistentQuantitiesExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateCloudFrontOriginAccessIdentity");

            var request = InstantiateClassGenerator.Execute<UpdateCloudFrontOriginAccessIdentityRequest>();
            var marshaller = new UpdateCloudFrontOriginAccessIdentityRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("UpdateCloudFrontOriginAccessIdentity", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InconsistentQuantitiesException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = UpdateCloudFrontOriginAccessIdentityResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void UpdateCloudFrontOriginAccessIdentity_InvalidArgumentExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateCloudFrontOriginAccessIdentity");

            var request = InstantiateClassGenerator.Execute<UpdateCloudFrontOriginAccessIdentityRequest>();
            var marshaller = new UpdateCloudFrontOriginAccessIdentityRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("UpdateCloudFrontOriginAccessIdentity", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidArgumentException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = UpdateCloudFrontOriginAccessIdentityResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void UpdateCloudFrontOriginAccessIdentity_InvalidIfMatchVersionExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateCloudFrontOriginAccessIdentity");

            var request = InstantiateClassGenerator.Execute<UpdateCloudFrontOriginAccessIdentityRequest>();
            var marshaller = new UpdateCloudFrontOriginAccessIdentityRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("UpdateCloudFrontOriginAccessIdentity", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidIfMatchVersionException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = UpdateCloudFrontOriginAccessIdentityResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void UpdateCloudFrontOriginAccessIdentity_MissingBodyExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateCloudFrontOriginAccessIdentity");

            var request = InstantiateClassGenerator.Execute<UpdateCloudFrontOriginAccessIdentityRequest>();
            var marshaller = new UpdateCloudFrontOriginAccessIdentityRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("UpdateCloudFrontOriginAccessIdentity", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("MissingBodyException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = UpdateCloudFrontOriginAccessIdentityResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void UpdateCloudFrontOriginAccessIdentity_NoSuchCloudFrontOriginAccessIdentityExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateCloudFrontOriginAccessIdentity");

            var request = InstantiateClassGenerator.Execute<UpdateCloudFrontOriginAccessIdentityRequest>();
            var marshaller = new UpdateCloudFrontOriginAccessIdentityRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("UpdateCloudFrontOriginAccessIdentity", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("NoSuchCloudFrontOriginAccessIdentityException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = UpdateCloudFrontOriginAccessIdentityResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void UpdateCloudFrontOriginAccessIdentity_PreconditionFailedExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateCloudFrontOriginAccessIdentity");

            var request = InstantiateClassGenerator.Execute<UpdateCloudFrontOriginAccessIdentityRequest>();
            var marshaller = new UpdateCloudFrontOriginAccessIdentityRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("UpdateCloudFrontOriginAccessIdentity", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("PreconditionFailedException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = UpdateCloudFrontOriginAccessIdentityResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

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
            webResponse.ContentLength = payloadResponse.Length;
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
        public void UpdateDistribution_AccessDeniedExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateDistribution");

            var request = InstantiateClassGenerator.Execute<UpdateDistributionRequest>();
            var marshaller = new UpdateDistributionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("UpdateDistribution", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("AccessDeniedException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = UpdateDistributionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void UpdateDistribution_CNAMEAlreadyExistsExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateDistribution");

            var request = InstantiateClassGenerator.Execute<UpdateDistributionRequest>();
            var marshaller = new UpdateDistributionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("UpdateDistribution", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("CNAMEAlreadyExistsException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = UpdateDistributionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void UpdateDistribution_IllegalFieldLevelEncryptionConfigAssociationWithCacheBehaviorExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateDistribution");

            var request = InstantiateClassGenerator.Execute<UpdateDistributionRequest>();
            var marshaller = new UpdateDistributionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("UpdateDistribution", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("IllegalFieldLevelEncryptionConfigAssociationWithCacheBehaviorException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = UpdateDistributionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void UpdateDistribution_IllegalUpdateExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateDistribution");

            var request = InstantiateClassGenerator.Execute<UpdateDistributionRequest>();
            var marshaller = new UpdateDistributionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("UpdateDistribution", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("IllegalUpdateException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = UpdateDistributionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void UpdateDistribution_InconsistentQuantitiesExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateDistribution");

            var request = InstantiateClassGenerator.Execute<UpdateDistributionRequest>();
            var marshaller = new UpdateDistributionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("UpdateDistribution", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InconsistentQuantitiesException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = UpdateDistributionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void UpdateDistribution_InvalidArgumentExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateDistribution");

            var request = InstantiateClassGenerator.Execute<UpdateDistributionRequest>();
            var marshaller = new UpdateDistributionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("UpdateDistribution", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidArgumentException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = UpdateDistributionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void UpdateDistribution_InvalidDefaultRootObjectExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateDistribution");

            var request = InstantiateClassGenerator.Execute<UpdateDistributionRequest>();
            var marshaller = new UpdateDistributionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("UpdateDistribution", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidDefaultRootObjectException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = UpdateDistributionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void UpdateDistribution_InvalidErrorCodeExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateDistribution");

            var request = InstantiateClassGenerator.Execute<UpdateDistributionRequest>();
            var marshaller = new UpdateDistributionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("UpdateDistribution", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidErrorCodeException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = UpdateDistributionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void UpdateDistribution_InvalidForwardCookiesExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateDistribution");

            var request = InstantiateClassGenerator.Execute<UpdateDistributionRequest>();
            var marshaller = new UpdateDistributionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("UpdateDistribution", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidForwardCookiesException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = UpdateDistributionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void UpdateDistribution_InvalidGeoRestrictionParameterExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateDistribution");

            var request = InstantiateClassGenerator.Execute<UpdateDistributionRequest>();
            var marshaller = new UpdateDistributionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("UpdateDistribution", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidGeoRestrictionParameterException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = UpdateDistributionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void UpdateDistribution_InvalidHeadersForS3OriginExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateDistribution");

            var request = InstantiateClassGenerator.Execute<UpdateDistributionRequest>();
            var marshaller = new UpdateDistributionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("UpdateDistribution", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidHeadersForS3OriginException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = UpdateDistributionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void UpdateDistribution_InvalidIfMatchVersionExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateDistribution");

            var request = InstantiateClassGenerator.Execute<UpdateDistributionRequest>();
            var marshaller = new UpdateDistributionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("UpdateDistribution", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidIfMatchVersionException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = UpdateDistributionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void UpdateDistribution_InvalidLambdaFunctionAssociationExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateDistribution");

            var request = InstantiateClassGenerator.Execute<UpdateDistributionRequest>();
            var marshaller = new UpdateDistributionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("UpdateDistribution", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidLambdaFunctionAssociationException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = UpdateDistributionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void UpdateDistribution_InvalidLocationCodeExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateDistribution");

            var request = InstantiateClassGenerator.Execute<UpdateDistributionRequest>();
            var marshaller = new UpdateDistributionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("UpdateDistribution", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidLocationCodeException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = UpdateDistributionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void UpdateDistribution_InvalidMinimumProtocolVersionExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateDistribution");

            var request = InstantiateClassGenerator.Execute<UpdateDistributionRequest>();
            var marshaller = new UpdateDistributionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("UpdateDistribution", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidMinimumProtocolVersionException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = UpdateDistributionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void UpdateDistribution_InvalidOriginAccessIdentityExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateDistribution");

            var request = InstantiateClassGenerator.Execute<UpdateDistributionRequest>();
            var marshaller = new UpdateDistributionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("UpdateDistribution", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidOriginAccessIdentityException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = UpdateDistributionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void UpdateDistribution_InvalidOriginKeepaliveTimeoutExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateDistribution");

            var request = InstantiateClassGenerator.Execute<UpdateDistributionRequest>();
            var marshaller = new UpdateDistributionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("UpdateDistribution", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidOriginKeepaliveTimeoutException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = UpdateDistributionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void UpdateDistribution_InvalidOriginReadTimeoutExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateDistribution");

            var request = InstantiateClassGenerator.Execute<UpdateDistributionRequest>();
            var marshaller = new UpdateDistributionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("UpdateDistribution", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidOriginReadTimeoutException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = UpdateDistributionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void UpdateDistribution_InvalidQueryStringParametersExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateDistribution");

            var request = InstantiateClassGenerator.Execute<UpdateDistributionRequest>();
            var marshaller = new UpdateDistributionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("UpdateDistribution", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidQueryStringParametersException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = UpdateDistributionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void UpdateDistribution_InvalidRelativePathExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateDistribution");

            var request = InstantiateClassGenerator.Execute<UpdateDistributionRequest>();
            var marshaller = new UpdateDistributionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("UpdateDistribution", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidRelativePathException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = UpdateDistributionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void UpdateDistribution_InvalidRequiredProtocolExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateDistribution");

            var request = InstantiateClassGenerator.Execute<UpdateDistributionRequest>();
            var marshaller = new UpdateDistributionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("UpdateDistribution", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidRequiredProtocolException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = UpdateDistributionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void UpdateDistribution_InvalidResponseCodeExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateDistribution");

            var request = InstantiateClassGenerator.Execute<UpdateDistributionRequest>();
            var marshaller = new UpdateDistributionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("UpdateDistribution", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidResponseCodeException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = UpdateDistributionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void UpdateDistribution_InvalidTTLOrderExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateDistribution");

            var request = InstantiateClassGenerator.Execute<UpdateDistributionRequest>();
            var marshaller = new UpdateDistributionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("UpdateDistribution", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidTTLOrderException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = UpdateDistributionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void UpdateDistribution_InvalidViewerCertificateExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateDistribution");

            var request = InstantiateClassGenerator.Execute<UpdateDistributionRequest>();
            var marshaller = new UpdateDistributionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("UpdateDistribution", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidViewerCertificateException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = UpdateDistributionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void UpdateDistribution_InvalidWebACLIdExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateDistribution");

            var request = InstantiateClassGenerator.Execute<UpdateDistributionRequest>();
            var marshaller = new UpdateDistributionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("UpdateDistribution", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidWebACLIdException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = UpdateDistributionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void UpdateDistribution_MissingBodyExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateDistribution");

            var request = InstantiateClassGenerator.Execute<UpdateDistributionRequest>();
            var marshaller = new UpdateDistributionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("UpdateDistribution", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("MissingBodyException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = UpdateDistributionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void UpdateDistribution_NoSuchCachePolicyExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateDistribution");

            var request = InstantiateClassGenerator.Execute<UpdateDistributionRequest>();
            var marshaller = new UpdateDistributionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("UpdateDistribution", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("NoSuchCachePolicyException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = UpdateDistributionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void UpdateDistribution_NoSuchDistributionExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateDistribution");

            var request = InstantiateClassGenerator.Execute<UpdateDistributionRequest>();
            var marshaller = new UpdateDistributionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("UpdateDistribution", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("NoSuchDistributionException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = UpdateDistributionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void UpdateDistribution_NoSuchFieldLevelEncryptionConfigExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateDistribution");

            var request = InstantiateClassGenerator.Execute<UpdateDistributionRequest>();
            var marshaller = new UpdateDistributionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("UpdateDistribution", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("NoSuchFieldLevelEncryptionConfigException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = UpdateDistributionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void UpdateDistribution_NoSuchOriginExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateDistribution");

            var request = InstantiateClassGenerator.Execute<UpdateDistributionRequest>();
            var marshaller = new UpdateDistributionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("UpdateDistribution", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("NoSuchOriginException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = UpdateDistributionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void UpdateDistribution_NoSuchOriginRequestPolicyExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateDistribution");

            var request = InstantiateClassGenerator.Execute<UpdateDistributionRequest>();
            var marshaller = new UpdateDistributionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("UpdateDistribution", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("NoSuchOriginRequestPolicyException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = UpdateDistributionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void UpdateDistribution_PreconditionFailedExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateDistribution");

            var request = InstantiateClassGenerator.Execute<UpdateDistributionRequest>();
            var marshaller = new UpdateDistributionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("UpdateDistribution", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("PreconditionFailedException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = UpdateDistributionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void UpdateDistribution_TooManyCacheBehaviorsExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateDistribution");

            var request = InstantiateClassGenerator.Execute<UpdateDistributionRequest>();
            var marshaller = new UpdateDistributionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("UpdateDistribution", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("TooManyCacheBehaviorsException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = UpdateDistributionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void UpdateDistribution_TooManyCertificatesExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateDistribution");

            var request = InstantiateClassGenerator.Execute<UpdateDistributionRequest>();
            var marshaller = new UpdateDistributionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("UpdateDistribution", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("TooManyCertificatesException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = UpdateDistributionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void UpdateDistribution_TooManyCookieNamesInWhiteListExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateDistribution");

            var request = InstantiateClassGenerator.Execute<UpdateDistributionRequest>();
            var marshaller = new UpdateDistributionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("UpdateDistribution", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("TooManyCookieNamesInWhiteListException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = UpdateDistributionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void UpdateDistribution_TooManyDistributionCNAMEsExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateDistribution");

            var request = InstantiateClassGenerator.Execute<UpdateDistributionRequest>();
            var marshaller = new UpdateDistributionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("UpdateDistribution", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("TooManyDistributionCNAMEsException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = UpdateDistributionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void UpdateDistribution_TooManyDistributionsAssociatedToCachePolicyExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateDistribution");

            var request = InstantiateClassGenerator.Execute<UpdateDistributionRequest>();
            var marshaller = new UpdateDistributionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("UpdateDistribution", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("TooManyDistributionsAssociatedToCachePolicyException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = UpdateDistributionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void UpdateDistribution_TooManyDistributionsAssociatedToFieldLevelEncryptionConfigExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateDistribution");

            var request = InstantiateClassGenerator.Execute<UpdateDistributionRequest>();
            var marshaller = new UpdateDistributionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("UpdateDistribution", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("TooManyDistributionsAssociatedToFieldLevelEncryptionConfigException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = UpdateDistributionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void UpdateDistribution_TooManyDistributionsAssociatedToKeyGroupExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateDistribution");

            var request = InstantiateClassGenerator.Execute<UpdateDistributionRequest>();
            var marshaller = new UpdateDistributionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("UpdateDistribution", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("TooManyDistributionsAssociatedToKeyGroupException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = UpdateDistributionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void UpdateDistribution_TooManyDistributionsAssociatedToOriginRequestPolicyExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateDistribution");

            var request = InstantiateClassGenerator.Execute<UpdateDistributionRequest>();
            var marshaller = new UpdateDistributionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("UpdateDistribution", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("TooManyDistributionsAssociatedToOriginRequestPolicyException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = UpdateDistributionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void UpdateDistribution_TooManyDistributionsWithLambdaAssociationsExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateDistribution");

            var request = InstantiateClassGenerator.Execute<UpdateDistributionRequest>();
            var marshaller = new UpdateDistributionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("UpdateDistribution", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("TooManyDistributionsWithLambdaAssociationsException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = UpdateDistributionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void UpdateDistribution_TooManyDistributionsWithSingleFunctionARNExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateDistribution");

            var request = InstantiateClassGenerator.Execute<UpdateDistributionRequest>();
            var marshaller = new UpdateDistributionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("UpdateDistribution", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("TooManyDistributionsWithSingleFunctionARNException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = UpdateDistributionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void UpdateDistribution_TooManyHeadersInForwardedValuesExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateDistribution");

            var request = InstantiateClassGenerator.Execute<UpdateDistributionRequest>();
            var marshaller = new UpdateDistributionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("UpdateDistribution", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("TooManyHeadersInForwardedValuesException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = UpdateDistributionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void UpdateDistribution_TooManyKeyGroupsAssociatedToDistributionExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateDistribution");

            var request = InstantiateClassGenerator.Execute<UpdateDistributionRequest>();
            var marshaller = new UpdateDistributionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("UpdateDistribution", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("TooManyKeyGroupsAssociatedToDistributionException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = UpdateDistributionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void UpdateDistribution_TooManyLambdaFunctionAssociationsExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateDistribution");

            var request = InstantiateClassGenerator.Execute<UpdateDistributionRequest>();
            var marshaller = new UpdateDistributionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("UpdateDistribution", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("TooManyLambdaFunctionAssociationsException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = UpdateDistributionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void UpdateDistribution_TooManyOriginCustomHeadersExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateDistribution");

            var request = InstantiateClassGenerator.Execute<UpdateDistributionRequest>();
            var marshaller = new UpdateDistributionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("UpdateDistribution", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("TooManyOriginCustomHeadersException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = UpdateDistributionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void UpdateDistribution_TooManyOriginGroupsPerDistributionExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateDistribution");

            var request = InstantiateClassGenerator.Execute<UpdateDistributionRequest>();
            var marshaller = new UpdateDistributionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("UpdateDistribution", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("TooManyOriginGroupsPerDistributionException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = UpdateDistributionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void UpdateDistribution_TooManyOriginsExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateDistribution");

            var request = InstantiateClassGenerator.Execute<UpdateDistributionRequest>();
            var marshaller = new UpdateDistributionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("UpdateDistribution", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("TooManyOriginsException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = UpdateDistributionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void UpdateDistribution_TooManyQueryStringParametersExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateDistribution");

            var request = InstantiateClassGenerator.Execute<UpdateDistributionRequest>();
            var marshaller = new UpdateDistributionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("UpdateDistribution", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("TooManyQueryStringParametersException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = UpdateDistributionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void UpdateDistribution_TooManyTrustedSignersExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateDistribution");

            var request = InstantiateClassGenerator.Execute<UpdateDistributionRequest>();
            var marshaller = new UpdateDistributionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("UpdateDistribution", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("TooManyTrustedSignersException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = UpdateDistributionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void UpdateDistribution_TrustedKeyGroupDoesNotExistExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateDistribution");

            var request = InstantiateClassGenerator.Execute<UpdateDistributionRequest>();
            var marshaller = new UpdateDistributionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("UpdateDistribution", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("TrustedKeyGroupDoesNotExistException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = UpdateDistributionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void UpdateDistribution_TrustedSignerDoesNotExistExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateDistribution");

            var request = InstantiateClassGenerator.Execute<UpdateDistributionRequest>();
            var marshaller = new UpdateDistributionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("UpdateDistribution", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("TrustedSignerDoesNotExistException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = UpdateDistributionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

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
            webResponse.ContentLength = payloadResponse.Length;
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
        public void UpdateFieldLevelEncryptionConfig_AccessDeniedExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateFieldLevelEncryptionConfig");

            var request = InstantiateClassGenerator.Execute<UpdateFieldLevelEncryptionConfigRequest>();
            var marshaller = new UpdateFieldLevelEncryptionConfigRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("UpdateFieldLevelEncryptionConfig", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("AccessDeniedException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = UpdateFieldLevelEncryptionConfigResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void UpdateFieldLevelEncryptionConfig_IllegalUpdateExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateFieldLevelEncryptionConfig");

            var request = InstantiateClassGenerator.Execute<UpdateFieldLevelEncryptionConfigRequest>();
            var marshaller = new UpdateFieldLevelEncryptionConfigRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("UpdateFieldLevelEncryptionConfig", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("IllegalUpdateException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = UpdateFieldLevelEncryptionConfigResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void UpdateFieldLevelEncryptionConfig_InconsistentQuantitiesExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateFieldLevelEncryptionConfig");

            var request = InstantiateClassGenerator.Execute<UpdateFieldLevelEncryptionConfigRequest>();
            var marshaller = new UpdateFieldLevelEncryptionConfigRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("UpdateFieldLevelEncryptionConfig", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InconsistentQuantitiesException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = UpdateFieldLevelEncryptionConfigResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void UpdateFieldLevelEncryptionConfig_InvalidArgumentExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateFieldLevelEncryptionConfig");

            var request = InstantiateClassGenerator.Execute<UpdateFieldLevelEncryptionConfigRequest>();
            var marshaller = new UpdateFieldLevelEncryptionConfigRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("UpdateFieldLevelEncryptionConfig", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidArgumentException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = UpdateFieldLevelEncryptionConfigResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void UpdateFieldLevelEncryptionConfig_InvalidIfMatchVersionExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateFieldLevelEncryptionConfig");

            var request = InstantiateClassGenerator.Execute<UpdateFieldLevelEncryptionConfigRequest>();
            var marshaller = new UpdateFieldLevelEncryptionConfigRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("UpdateFieldLevelEncryptionConfig", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidIfMatchVersionException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = UpdateFieldLevelEncryptionConfigResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void UpdateFieldLevelEncryptionConfig_NoSuchFieldLevelEncryptionConfigExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateFieldLevelEncryptionConfig");

            var request = InstantiateClassGenerator.Execute<UpdateFieldLevelEncryptionConfigRequest>();
            var marshaller = new UpdateFieldLevelEncryptionConfigRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("UpdateFieldLevelEncryptionConfig", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("NoSuchFieldLevelEncryptionConfigException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = UpdateFieldLevelEncryptionConfigResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void UpdateFieldLevelEncryptionConfig_NoSuchFieldLevelEncryptionProfileExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateFieldLevelEncryptionConfig");

            var request = InstantiateClassGenerator.Execute<UpdateFieldLevelEncryptionConfigRequest>();
            var marshaller = new UpdateFieldLevelEncryptionConfigRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("UpdateFieldLevelEncryptionConfig", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("NoSuchFieldLevelEncryptionProfileException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = UpdateFieldLevelEncryptionConfigResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void UpdateFieldLevelEncryptionConfig_PreconditionFailedExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateFieldLevelEncryptionConfig");

            var request = InstantiateClassGenerator.Execute<UpdateFieldLevelEncryptionConfigRequest>();
            var marshaller = new UpdateFieldLevelEncryptionConfigRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("UpdateFieldLevelEncryptionConfig", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("PreconditionFailedException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = UpdateFieldLevelEncryptionConfigResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void UpdateFieldLevelEncryptionConfig_QueryArgProfileEmptyExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateFieldLevelEncryptionConfig");

            var request = InstantiateClassGenerator.Execute<UpdateFieldLevelEncryptionConfigRequest>();
            var marshaller = new UpdateFieldLevelEncryptionConfigRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("UpdateFieldLevelEncryptionConfig", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("QueryArgProfileEmptyException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = UpdateFieldLevelEncryptionConfigResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void UpdateFieldLevelEncryptionConfig_TooManyFieldLevelEncryptionContentTypeProfilesExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateFieldLevelEncryptionConfig");

            var request = InstantiateClassGenerator.Execute<UpdateFieldLevelEncryptionConfigRequest>();
            var marshaller = new UpdateFieldLevelEncryptionConfigRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("UpdateFieldLevelEncryptionConfig", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("TooManyFieldLevelEncryptionContentTypeProfilesException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = UpdateFieldLevelEncryptionConfigResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void UpdateFieldLevelEncryptionConfig_TooManyFieldLevelEncryptionQueryArgProfilesExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateFieldLevelEncryptionConfig");

            var request = InstantiateClassGenerator.Execute<UpdateFieldLevelEncryptionConfigRequest>();
            var marshaller = new UpdateFieldLevelEncryptionConfigRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("UpdateFieldLevelEncryptionConfig", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("TooManyFieldLevelEncryptionQueryArgProfilesException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = UpdateFieldLevelEncryptionConfigResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

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
            webResponse.ContentLength = payloadResponse.Length;
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
        public void UpdateFieldLevelEncryptionProfile_AccessDeniedExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateFieldLevelEncryptionProfile");

            var request = InstantiateClassGenerator.Execute<UpdateFieldLevelEncryptionProfileRequest>();
            var marshaller = new UpdateFieldLevelEncryptionProfileRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("UpdateFieldLevelEncryptionProfile", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("AccessDeniedException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = UpdateFieldLevelEncryptionProfileResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void UpdateFieldLevelEncryptionProfile_FieldLevelEncryptionProfileAlreadyExistsExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateFieldLevelEncryptionProfile");

            var request = InstantiateClassGenerator.Execute<UpdateFieldLevelEncryptionProfileRequest>();
            var marshaller = new UpdateFieldLevelEncryptionProfileRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("UpdateFieldLevelEncryptionProfile", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("FieldLevelEncryptionProfileAlreadyExistsException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = UpdateFieldLevelEncryptionProfileResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void UpdateFieldLevelEncryptionProfile_FieldLevelEncryptionProfileSizeExceededExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateFieldLevelEncryptionProfile");

            var request = InstantiateClassGenerator.Execute<UpdateFieldLevelEncryptionProfileRequest>();
            var marshaller = new UpdateFieldLevelEncryptionProfileRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("UpdateFieldLevelEncryptionProfile", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("FieldLevelEncryptionProfileSizeExceededException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = UpdateFieldLevelEncryptionProfileResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void UpdateFieldLevelEncryptionProfile_IllegalUpdateExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateFieldLevelEncryptionProfile");

            var request = InstantiateClassGenerator.Execute<UpdateFieldLevelEncryptionProfileRequest>();
            var marshaller = new UpdateFieldLevelEncryptionProfileRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("UpdateFieldLevelEncryptionProfile", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("IllegalUpdateException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = UpdateFieldLevelEncryptionProfileResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void UpdateFieldLevelEncryptionProfile_InconsistentQuantitiesExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateFieldLevelEncryptionProfile");

            var request = InstantiateClassGenerator.Execute<UpdateFieldLevelEncryptionProfileRequest>();
            var marshaller = new UpdateFieldLevelEncryptionProfileRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("UpdateFieldLevelEncryptionProfile", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InconsistentQuantitiesException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = UpdateFieldLevelEncryptionProfileResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void UpdateFieldLevelEncryptionProfile_InvalidArgumentExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateFieldLevelEncryptionProfile");

            var request = InstantiateClassGenerator.Execute<UpdateFieldLevelEncryptionProfileRequest>();
            var marshaller = new UpdateFieldLevelEncryptionProfileRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("UpdateFieldLevelEncryptionProfile", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidArgumentException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = UpdateFieldLevelEncryptionProfileResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void UpdateFieldLevelEncryptionProfile_InvalidIfMatchVersionExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateFieldLevelEncryptionProfile");

            var request = InstantiateClassGenerator.Execute<UpdateFieldLevelEncryptionProfileRequest>();
            var marshaller = new UpdateFieldLevelEncryptionProfileRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("UpdateFieldLevelEncryptionProfile", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidIfMatchVersionException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = UpdateFieldLevelEncryptionProfileResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void UpdateFieldLevelEncryptionProfile_NoSuchFieldLevelEncryptionProfileExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateFieldLevelEncryptionProfile");

            var request = InstantiateClassGenerator.Execute<UpdateFieldLevelEncryptionProfileRequest>();
            var marshaller = new UpdateFieldLevelEncryptionProfileRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("UpdateFieldLevelEncryptionProfile", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("NoSuchFieldLevelEncryptionProfileException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = UpdateFieldLevelEncryptionProfileResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void UpdateFieldLevelEncryptionProfile_NoSuchPublicKeyExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateFieldLevelEncryptionProfile");

            var request = InstantiateClassGenerator.Execute<UpdateFieldLevelEncryptionProfileRequest>();
            var marshaller = new UpdateFieldLevelEncryptionProfileRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("UpdateFieldLevelEncryptionProfile", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("NoSuchPublicKeyException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = UpdateFieldLevelEncryptionProfileResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void UpdateFieldLevelEncryptionProfile_PreconditionFailedExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateFieldLevelEncryptionProfile");

            var request = InstantiateClassGenerator.Execute<UpdateFieldLevelEncryptionProfileRequest>();
            var marshaller = new UpdateFieldLevelEncryptionProfileRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("UpdateFieldLevelEncryptionProfile", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("PreconditionFailedException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = UpdateFieldLevelEncryptionProfileResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void UpdateFieldLevelEncryptionProfile_TooManyFieldLevelEncryptionEncryptionEntitiesExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateFieldLevelEncryptionProfile");

            var request = InstantiateClassGenerator.Execute<UpdateFieldLevelEncryptionProfileRequest>();
            var marshaller = new UpdateFieldLevelEncryptionProfileRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("UpdateFieldLevelEncryptionProfile", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("TooManyFieldLevelEncryptionEncryptionEntitiesException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = UpdateFieldLevelEncryptionProfileResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void UpdateFieldLevelEncryptionProfile_TooManyFieldLevelEncryptionFieldPatternsExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateFieldLevelEncryptionProfile");

            var request = InstantiateClassGenerator.Execute<UpdateFieldLevelEncryptionProfileRequest>();
            var marshaller = new UpdateFieldLevelEncryptionProfileRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("UpdateFieldLevelEncryptionProfile", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("TooManyFieldLevelEncryptionFieldPatternsException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = UpdateFieldLevelEncryptionProfileResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void UpdateKeyGroupMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateKeyGroup");

            var request = InstantiateClassGenerator.Execute<UpdateKeyGroupRequest>();
            var marshaller = new UpdateKeyGroupRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("UpdateKeyGroup", request, internalRequest, service_model);            

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            webResponse.ContentLength = payloadResponse.Length;
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = UpdateKeyGroupResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as UpdateKeyGroupResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void UpdateKeyGroup_InvalidArgumentExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateKeyGroup");

            var request = InstantiateClassGenerator.Execute<UpdateKeyGroupRequest>();
            var marshaller = new UpdateKeyGroupRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("UpdateKeyGroup", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidArgumentException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = UpdateKeyGroupResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void UpdateKeyGroup_InvalidIfMatchVersionExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateKeyGroup");

            var request = InstantiateClassGenerator.Execute<UpdateKeyGroupRequest>();
            var marshaller = new UpdateKeyGroupRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("UpdateKeyGroup", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidIfMatchVersionException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = UpdateKeyGroupResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void UpdateKeyGroup_KeyGroupAlreadyExistsExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateKeyGroup");

            var request = InstantiateClassGenerator.Execute<UpdateKeyGroupRequest>();
            var marshaller = new UpdateKeyGroupRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("UpdateKeyGroup", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("KeyGroupAlreadyExistsException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = UpdateKeyGroupResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void UpdateKeyGroup_NoSuchResourceExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateKeyGroup");

            var request = InstantiateClassGenerator.Execute<UpdateKeyGroupRequest>();
            var marshaller = new UpdateKeyGroupRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("UpdateKeyGroup", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("NoSuchResourceException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = UpdateKeyGroupResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void UpdateKeyGroup_PreconditionFailedExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateKeyGroup");

            var request = InstantiateClassGenerator.Execute<UpdateKeyGroupRequest>();
            var marshaller = new UpdateKeyGroupRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("UpdateKeyGroup", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("PreconditionFailedException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = UpdateKeyGroupResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void UpdateKeyGroup_TooManyPublicKeysInKeyGroupExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateKeyGroup");

            var request = InstantiateClassGenerator.Execute<UpdateKeyGroupRequest>();
            var marshaller = new UpdateKeyGroupRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("UpdateKeyGroup", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("TooManyPublicKeysInKeyGroupException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = UpdateKeyGroupResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void UpdateOriginRequestPolicyMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateOriginRequestPolicy");

            var request = InstantiateClassGenerator.Execute<UpdateOriginRequestPolicyRequest>();
            var marshaller = new UpdateOriginRequestPolicyRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("UpdateOriginRequestPolicy", request, internalRequest, service_model);            

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            webResponse.ContentLength = payloadResponse.Length;
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = UpdateOriginRequestPolicyResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as UpdateOriginRequestPolicyResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void UpdateOriginRequestPolicy_AccessDeniedExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateOriginRequestPolicy");

            var request = InstantiateClassGenerator.Execute<UpdateOriginRequestPolicyRequest>();
            var marshaller = new UpdateOriginRequestPolicyRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("UpdateOriginRequestPolicy", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("AccessDeniedException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = UpdateOriginRequestPolicyResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void UpdateOriginRequestPolicy_IllegalUpdateExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateOriginRequestPolicy");

            var request = InstantiateClassGenerator.Execute<UpdateOriginRequestPolicyRequest>();
            var marshaller = new UpdateOriginRequestPolicyRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("UpdateOriginRequestPolicy", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("IllegalUpdateException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = UpdateOriginRequestPolicyResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void UpdateOriginRequestPolicy_InconsistentQuantitiesExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateOriginRequestPolicy");

            var request = InstantiateClassGenerator.Execute<UpdateOriginRequestPolicyRequest>();
            var marshaller = new UpdateOriginRequestPolicyRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("UpdateOriginRequestPolicy", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InconsistentQuantitiesException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = UpdateOriginRequestPolicyResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void UpdateOriginRequestPolicy_InvalidArgumentExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateOriginRequestPolicy");

            var request = InstantiateClassGenerator.Execute<UpdateOriginRequestPolicyRequest>();
            var marshaller = new UpdateOriginRequestPolicyRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("UpdateOriginRequestPolicy", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidArgumentException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = UpdateOriginRequestPolicyResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void UpdateOriginRequestPolicy_InvalidIfMatchVersionExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateOriginRequestPolicy");

            var request = InstantiateClassGenerator.Execute<UpdateOriginRequestPolicyRequest>();
            var marshaller = new UpdateOriginRequestPolicyRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("UpdateOriginRequestPolicy", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidIfMatchVersionException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = UpdateOriginRequestPolicyResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void UpdateOriginRequestPolicy_NoSuchOriginRequestPolicyExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateOriginRequestPolicy");

            var request = InstantiateClassGenerator.Execute<UpdateOriginRequestPolicyRequest>();
            var marshaller = new UpdateOriginRequestPolicyRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("UpdateOriginRequestPolicy", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("NoSuchOriginRequestPolicyException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = UpdateOriginRequestPolicyResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void UpdateOriginRequestPolicy_OriginRequestPolicyAlreadyExistsExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateOriginRequestPolicy");

            var request = InstantiateClassGenerator.Execute<UpdateOriginRequestPolicyRequest>();
            var marshaller = new UpdateOriginRequestPolicyRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("UpdateOriginRequestPolicy", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("OriginRequestPolicyAlreadyExistsException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = UpdateOriginRequestPolicyResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void UpdateOriginRequestPolicy_PreconditionFailedExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateOriginRequestPolicy");

            var request = InstantiateClassGenerator.Execute<UpdateOriginRequestPolicyRequest>();
            var marshaller = new UpdateOriginRequestPolicyRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("UpdateOriginRequestPolicy", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("PreconditionFailedException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = UpdateOriginRequestPolicyResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void UpdateOriginRequestPolicy_TooManyCookiesInOriginRequestPolicyExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateOriginRequestPolicy");

            var request = InstantiateClassGenerator.Execute<UpdateOriginRequestPolicyRequest>();
            var marshaller = new UpdateOriginRequestPolicyRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("UpdateOriginRequestPolicy", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("TooManyCookiesInOriginRequestPolicyException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = UpdateOriginRequestPolicyResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void UpdateOriginRequestPolicy_TooManyHeadersInOriginRequestPolicyExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateOriginRequestPolicy");

            var request = InstantiateClassGenerator.Execute<UpdateOriginRequestPolicyRequest>();
            var marshaller = new UpdateOriginRequestPolicyRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("UpdateOriginRequestPolicy", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("TooManyHeadersInOriginRequestPolicyException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = UpdateOriginRequestPolicyResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void UpdateOriginRequestPolicy_TooManyQueryStringsInOriginRequestPolicyExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateOriginRequestPolicy");

            var request = InstantiateClassGenerator.Execute<UpdateOriginRequestPolicyRequest>();
            var marshaller = new UpdateOriginRequestPolicyRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("UpdateOriginRequestPolicy", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("TooManyQueryStringsInOriginRequestPolicyException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = UpdateOriginRequestPolicyResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

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
            webResponse.ContentLength = payloadResponse.Length;
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
        public void UpdatePublicKey_AccessDeniedExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("UpdatePublicKey");

            var request = InstantiateClassGenerator.Execute<UpdatePublicKeyRequest>();
            var marshaller = new UpdatePublicKeyRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("UpdatePublicKey", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("AccessDeniedException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = UpdatePublicKeyResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void UpdatePublicKey_CannotChangeImmutablePublicKeyFieldsExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("UpdatePublicKey");

            var request = InstantiateClassGenerator.Execute<UpdatePublicKeyRequest>();
            var marshaller = new UpdatePublicKeyRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("UpdatePublicKey", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("CannotChangeImmutablePublicKeyFieldsException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = UpdatePublicKeyResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void UpdatePublicKey_IllegalUpdateExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("UpdatePublicKey");

            var request = InstantiateClassGenerator.Execute<UpdatePublicKeyRequest>();
            var marshaller = new UpdatePublicKeyRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("UpdatePublicKey", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("IllegalUpdateException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = UpdatePublicKeyResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void UpdatePublicKey_InvalidArgumentExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("UpdatePublicKey");

            var request = InstantiateClassGenerator.Execute<UpdatePublicKeyRequest>();
            var marshaller = new UpdatePublicKeyRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("UpdatePublicKey", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidArgumentException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = UpdatePublicKeyResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void UpdatePublicKey_InvalidIfMatchVersionExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("UpdatePublicKey");

            var request = InstantiateClassGenerator.Execute<UpdatePublicKeyRequest>();
            var marshaller = new UpdatePublicKeyRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("UpdatePublicKey", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidIfMatchVersionException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = UpdatePublicKeyResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void UpdatePublicKey_NoSuchPublicKeyExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("UpdatePublicKey");

            var request = InstantiateClassGenerator.Execute<UpdatePublicKeyRequest>();
            var marshaller = new UpdatePublicKeyRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("UpdatePublicKey", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("NoSuchPublicKeyException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = UpdatePublicKeyResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void UpdatePublicKey_PreconditionFailedExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("UpdatePublicKey");

            var request = InstantiateClassGenerator.Execute<UpdatePublicKeyRequest>();
            var marshaller = new UpdatePublicKeyRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("UpdatePublicKey", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("PreconditionFailedException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = UpdatePublicKeyResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void UpdateRealtimeLogConfigMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateRealtimeLogConfig");

            var request = InstantiateClassGenerator.Execute<UpdateRealtimeLogConfigRequest>();
            var marshaller = new UpdateRealtimeLogConfigRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("UpdateRealtimeLogConfig", request, internalRequest, service_model);            

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            webResponse.ContentLength = payloadResponse.Length;
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = UpdateRealtimeLogConfigResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as UpdateRealtimeLogConfigResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void UpdateRealtimeLogConfig_AccessDeniedExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateRealtimeLogConfig");

            var request = InstantiateClassGenerator.Execute<UpdateRealtimeLogConfigRequest>();
            var marshaller = new UpdateRealtimeLogConfigRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("UpdateRealtimeLogConfig", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("AccessDeniedException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = UpdateRealtimeLogConfigResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void UpdateRealtimeLogConfig_InvalidArgumentExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateRealtimeLogConfig");

            var request = InstantiateClassGenerator.Execute<UpdateRealtimeLogConfigRequest>();
            var marshaller = new UpdateRealtimeLogConfigRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("UpdateRealtimeLogConfig", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidArgumentException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = UpdateRealtimeLogConfigResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void UpdateRealtimeLogConfig_NoSuchRealtimeLogConfigExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateRealtimeLogConfig");

            var request = InstantiateClassGenerator.Execute<UpdateRealtimeLogConfigRequest>();
            var marshaller = new UpdateRealtimeLogConfigRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("UpdateRealtimeLogConfig", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("NoSuchRealtimeLogConfigException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = UpdateRealtimeLogConfigResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

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
            webResponse.ContentLength = payloadResponse.Length;
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = UpdateStreamingDistributionResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as UpdateStreamingDistributionResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void UpdateStreamingDistribution_AccessDeniedExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateStreamingDistribution");

            var request = InstantiateClassGenerator.Execute<UpdateStreamingDistributionRequest>();
            var marshaller = new UpdateStreamingDistributionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("UpdateStreamingDistribution", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("AccessDeniedException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = UpdateStreamingDistributionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void UpdateStreamingDistribution_CNAMEAlreadyExistsExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateStreamingDistribution");

            var request = InstantiateClassGenerator.Execute<UpdateStreamingDistributionRequest>();
            var marshaller = new UpdateStreamingDistributionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("UpdateStreamingDistribution", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("CNAMEAlreadyExistsException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = UpdateStreamingDistributionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void UpdateStreamingDistribution_IllegalUpdateExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateStreamingDistribution");

            var request = InstantiateClassGenerator.Execute<UpdateStreamingDistributionRequest>();
            var marshaller = new UpdateStreamingDistributionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("UpdateStreamingDistribution", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("IllegalUpdateException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = UpdateStreamingDistributionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void UpdateStreamingDistribution_InconsistentQuantitiesExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateStreamingDistribution");

            var request = InstantiateClassGenerator.Execute<UpdateStreamingDistributionRequest>();
            var marshaller = new UpdateStreamingDistributionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("UpdateStreamingDistribution", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InconsistentQuantitiesException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = UpdateStreamingDistributionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void UpdateStreamingDistribution_InvalidArgumentExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateStreamingDistribution");

            var request = InstantiateClassGenerator.Execute<UpdateStreamingDistributionRequest>();
            var marshaller = new UpdateStreamingDistributionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("UpdateStreamingDistribution", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidArgumentException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = UpdateStreamingDistributionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void UpdateStreamingDistribution_InvalidIfMatchVersionExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateStreamingDistribution");

            var request = InstantiateClassGenerator.Execute<UpdateStreamingDistributionRequest>();
            var marshaller = new UpdateStreamingDistributionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("UpdateStreamingDistribution", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidIfMatchVersionException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = UpdateStreamingDistributionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void UpdateStreamingDistribution_InvalidOriginAccessIdentityExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateStreamingDistribution");

            var request = InstantiateClassGenerator.Execute<UpdateStreamingDistributionRequest>();
            var marshaller = new UpdateStreamingDistributionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("UpdateStreamingDistribution", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidOriginAccessIdentityException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = UpdateStreamingDistributionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void UpdateStreamingDistribution_MissingBodyExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateStreamingDistribution");

            var request = InstantiateClassGenerator.Execute<UpdateStreamingDistributionRequest>();
            var marshaller = new UpdateStreamingDistributionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("UpdateStreamingDistribution", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("MissingBodyException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = UpdateStreamingDistributionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void UpdateStreamingDistribution_NoSuchStreamingDistributionExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateStreamingDistribution");

            var request = InstantiateClassGenerator.Execute<UpdateStreamingDistributionRequest>();
            var marshaller = new UpdateStreamingDistributionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("UpdateStreamingDistribution", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("NoSuchStreamingDistributionException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = UpdateStreamingDistributionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void UpdateStreamingDistribution_PreconditionFailedExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateStreamingDistribution");

            var request = InstantiateClassGenerator.Execute<UpdateStreamingDistributionRequest>();
            var marshaller = new UpdateStreamingDistributionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("UpdateStreamingDistribution", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("PreconditionFailedException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = UpdateStreamingDistributionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void UpdateStreamingDistribution_TooManyStreamingDistributionCNAMEsExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateStreamingDistribution");

            var request = InstantiateClassGenerator.Execute<UpdateStreamingDistributionRequest>();
            var marshaller = new UpdateStreamingDistributionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("UpdateStreamingDistribution", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("TooManyStreamingDistributionCNAMEsException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = UpdateStreamingDistributionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void UpdateStreamingDistribution_TooManyTrustedSignersExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateStreamingDistribution");

            var request = InstantiateClassGenerator.Execute<UpdateStreamingDistributionRequest>();
            var marshaller = new UpdateStreamingDistributionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("UpdateStreamingDistribution", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("TooManyTrustedSignersException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = UpdateStreamingDistributionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("CloudFront")]
        public void UpdateStreamingDistribution_TrustedSignerDoesNotExistExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateStreamingDistribution");

            var request = InstantiateClassGenerator.Execute<UpdateStreamingDistributionRequest>();
            var marshaller = new UpdateStreamingDistributionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("UpdateStreamingDistribution", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("TrustedSignerDoesNotExistException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"ETag","ETag_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                }
            };

            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = UpdateStreamingDistributionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }
    }
}