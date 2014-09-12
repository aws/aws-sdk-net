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
 * Do not modify this file. This file is generated from the support-2013-04-15.normal.json service model.
 */


using System;
using System.IO;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Amazon.AWSSupport;
using Amazon.AWSSupport.Model;
using Amazon.AWSSupport.Model.Internal.MarshallTransformations;
using Amazon.Runtime.Internal.Transform;

using ServiceClientGenerator;

using AWSSDK_DotNet35.UnitTests.TestTools;

namespace AWSSDK_DotNet35.UnitTests.Marshalling
{
    [TestClass]
    public class AWSSupportMarshallingTests
    {
        static readonly ServiceModel service_model = Utils.LoadServiceModel("support-2013-04-15.normal.json", "support.customizations.json");
        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("AWSSupport")]
        public void AddAttachmentsToSetMarshallTest()
        {
            var request = InstantiateClassGenerator.Execute<AddAttachmentsToSetRequest>();
            var marshaller = new AddAttachmentsToSetRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);                        
            Comparer.CompareObjectToJson<AddAttachmentsToSetRequest>(request,jsonRequest);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            var jsonResponse = new JsonSampleGenerator(service_model, service_model.FindOperation("AddAttachmentsToSet").ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString());
            UnmarshallerContext context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), false, webResponse);
            var response = AddAttachmentsToSetResponseUnmarshaller.Instance.Unmarshall(context)
                as AddAttachmentsToSetResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("AWSSupport")]
        public void AddCommunicationToCaseMarshallTest()
        {
            var request = InstantiateClassGenerator.Execute<AddCommunicationToCaseRequest>();
            var marshaller = new AddCommunicationToCaseRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);                        
            Comparer.CompareObjectToJson<AddCommunicationToCaseRequest>(request,jsonRequest);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            var jsonResponse = new JsonSampleGenerator(service_model, service_model.FindOperation("AddCommunicationToCase").ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString());
            UnmarshallerContext context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), false, webResponse);
            var response = AddCommunicationToCaseResponseUnmarshaller.Instance.Unmarshall(context)
                as AddCommunicationToCaseResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("AWSSupport")]
        public void CreateCaseMarshallTest()
        {
            var request = InstantiateClassGenerator.Execute<CreateCaseRequest>();
            var marshaller = new CreateCaseRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);                        
            Comparer.CompareObjectToJson<CreateCaseRequest>(request,jsonRequest);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            var jsonResponse = new JsonSampleGenerator(service_model, service_model.FindOperation("CreateCase").ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString());
            UnmarshallerContext context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), false, webResponse);
            var response = CreateCaseResponseUnmarshaller.Instance.Unmarshall(context)
                as CreateCaseResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("AWSSupport")]
        public void DescribeAttachmentMarshallTest()
        {
            var request = InstantiateClassGenerator.Execute<DescribeAttachmentRequest>();
            var marshaller = new DescribeAttachmentRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);                        
            Comparer.CompareObjectToJson<DescribeAttachmentRequest>(request,jsonRequest);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            var jsonResponse = new JsonSampleGenerator(service_model, service_model.FindOperation("DescribeAttachment").ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString());
            UnmarshallerContext context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), false, webResponse);
            var response = DescribeAttachmentResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeAttachmentResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("AWSSupport")]
        public void DescribeCasesMarshallTest()
        {
            var request = InstantiateClassGenerator.Execute<DescribeCasesRequest>();
            var marshaller = new DescribeCasesRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);                        
            Comparer.CompareObjectToJson<DescribeCasesRequest>(request,jsonRequest);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            var jsonResponse = new JsonSampleGenerator(service_model, service_model.FindOperation("DescribeCases").ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString());
            UnmarshallerContext context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), false, webResponse);
            var response = DescribeCasesResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeCasesResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("AWSSupport")]
        public void DescribeCommunicationsMarshallTest()
        {
            var request = InstantiateClassGenerator.Execute<DescribeCommunicationsRequest>();
            var marshaller = new DescribeCommunicationsRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);                        
            Comparer.CompareObjectToJson<DescribeCommunicationsRequest>(request,jsonRequest);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            var jsonResponse = new JsonSampleGenerator(service_model, service_model.FindOperation("DescribeCommunications").ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString());
            UnmarshallerContext context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), false, webResponse);
            var response = DescribeCommunicationsResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeCommunicationsResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("AWSSupport")]
        public void DescribeServicesMarshallTest()
        {
            var request = InstantiateClassGenerator.Execute<DescribeServicesRequest>();
            var marshaller = new DescribeServicesRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);                        
            Comparer.CompareObjectToJson<DescribeServicesRequest>(request,jsonRequest);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            var jsonResponse = new JsonSampleGenerator(service_model, service_model.FindOperation("DescribeServices").ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString());
            UnmarshallerContext context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), false, webResponse);
            var response = DescribeServicesResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeServicesResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("AWSSupport")]
        public void DescribeSeverityLevelsMarshallTest()
        {
            var request = InstantiateClassGenerator.Execute<DescribeSeverityLevelsRequest>();
            var marshaller = new DescribeSeverityLevelsRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);                        
            Comparer.CompareObjectToJson<DescribeSeverityLevelsRequest>(request,jsonRequest);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            var jsonResponse = new JsonSampleGenerator(service_model, service_model.FindOperation("DescribeSeverityLevels").ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString());
            UnmarshallerContext context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), false, webResponse);
            var response = DescribeSeverityLevelsResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeSeverityLevelsResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("AWSSupport")]
        public void DescribeTrustedAdvisorCheckRefreshStatusesMarshallTest()
        {
            var request = InstantiateClassGenerator.Execute<DescribeTrustedAdvisorCheckRefreshStatusesRequest>();
            var marshaller = new DescribeTrustedAdvisorCheckRefreshStatusesRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);                        
            Comparer.CompareObjectToJson<DescribeTrustedAdvisorCheckRefreshStatusesRequest>(request,jsonRequest);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            var jsonResponse = new JsonSampleGenerator(service_model, service_model.FindOperation("DescribeTrustedAdvisorCheckRefreshStatuses").ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString());
            UnmarshallerContext context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), false, webResponse);
            var response = DescribeTrustedAdvisorCheckRefreshStatusesResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeTrustedAdvisorCheckRefreshStatusesResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("AWSSupport")]
        public void DescribeTrustedAdvisorCheckResultMarshallTest()
        {
            var request = InstantiateClassGenerator.Execute<DescribeTrustedAdvisorCheckResultRequest>();
            var marshaller = new DescribeTrustedAdvisorCheckResultRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);                        
            Comparer.CompareObjectToJson<DescribeTrustedAdvisorCheckResultRequest>(request,jsonRequest);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            var jsonResponse = new JsonSampleGenerator(service_model, service_model.FindOperation("DescribeTrustedAdvisorCheckResult").ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString());
            UnmarshallerContext context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), false, webResponse);
            var response = DescribeTrustedAdvisorCheckResultResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeTrustedAdvisorCheckResultResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("AWSSupport")]
        public void DescribeTrustedAdvisorChecksMarshallTest()
        {
            var request = InstantiateClassGenerator.Execute<DescribeTrustedAdvisorChecksRequest>();
            var marshaller = new DescribeTrustedAdvisorChecksRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);                        
            Comparer.CompareObjectToJson<DescribeTrustedAdvisorChecksRequest>(request,jsonRequest);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            var jsonResponse = new JsonSampleGenerator(service_model, service_model.FindOperation("DescribeTrustedAdvisorChecks").ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString());
            UnmarshallerContext context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), false, webResponse);
            var response = DescribeTrustedAdvisorChecksResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeTrustedAdvisorChecksResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("AWSSupport")]
        public void DescribeTrustedAdvisorCheckSummariesMarshallTest()
        {
            var request = InstantiateClassGenerator.Execute<DescribeTrustedAdvisorCheckSummariesRequest>();
            var marshaller = new DescribeTrustedAdvisorCheckSummariesRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);                        
            Comparer.CompareObjectToJson<DescribeTrustedAdvisorCheckSummariesRequest>(request,jsonRequest);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            var jsonResponse = new JsonSampleGenerator(service_model, service_model.FindOperation("DescribeTrustedAdvisorCheckSummaries").ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString());
            UnmarshallerContext context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), false, webResponse);
            var response = DescribeTrustedAdvisorCheckSummariesResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeTrustedAdvisorCheckSummariesResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("AWSSupport")]
        public void RefreshTrustedAdvisorCheckMarshallTest()
        {
            var request = InstantiateClassGenerator.Execute<RefreshTrustedAdvisorCheckRequest>();
            var marshaller = new RefreshTrustedAdvisorCheckRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);                        
            Comparer.CompareObjectToJson<RefreshTrustedAdvisorCheckRequest>(request,jsonRequest);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            var jsonResponse = new JsonSampleGenerator(service_model, service_model.FindOperation("RefreshTrustedAdvisorCheck").ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString());
            UnmarshallerContext context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), false, webResponse);
            var response = RefreshTrustedAdvisorCheckResponseUnmarshaller.Instance.Unmarshall(context)
                as RefreshTrustedAdvisorCheckResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("AWSSupport")]
        public void ResolveCaseMarshallTest()
        {
            var request = InstantiateClassGenerator.Execute<ResolveCaseRequest>();
            var marshaller = new ResolveCaseRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);                        
            Comparer.CompareObjectToJson<ResolveCaseRequest>(request,jsonRequest);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            var jsonResponse = new JsonSampleGenerator(service_model, service_model.FindOperation("ResolveCase").ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString());
            UnmarshallerContext context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), false, webResponse);
            var response = ResolveCaseResponseUnmarshaller.Instance.Unmarshall(context)
                as ResolveCaseResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

            }
}