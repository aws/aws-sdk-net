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
 * Do not modify this file. This file is generated from the trustedadvisor-2022-09-15.normal.json service model.
 */


using System;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Amazon.TrustedAdvisor;
using Amazon.TrustedAdvisor.Model;
using Amazon.TrustedAdvisor.Model.Internal.MarshallTransformations;
using Amazon.Runtime.Internal.Transform;
using Amazon.Util;
using ServiceClientGenerator;

using AWSSDK_DotNet.UnitTests.TestTools;

namespace AWSSDK_DotNet.UnitTests.Marshalling
{
    [TestClass]
    public partial class TrustedAdvisorMarshallingTests
    {
        static readonly ServiceModel service_model = Utils.LoadServiceModel("trustedadvisor");
        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("TrustedAdvisor")]
        public void GetOrganizationRecommendationMarshallTest()
        {
            var operation = service_model.FindOperation("GetOrganizationRecommendation");

            var request = InstantiateClassGenerator.Execute<GetOrganizationRecommendationRequest>(operation);
            var marshaller = new GetOrganizationRecommendationRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("GetOrganizationRecommendation", request, internalRequest, service_model);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            
            var payloadResponse = new JsonSampleGenerator(service_model, operation.ResponseStructure).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = GetOrganizationRecommendationResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context) as GetOrganizationRecommendationResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("TrustedAdvisor")]
        public void GetOrganizationRecommendation_AccessDeniedExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("GetOrganizationRecommendation");

            var request = InstantiateClassGenerator.Execute<GetOrganizationRecommendationRequest>(operation);
            var marshaller = new GetOrganizationRecommendationRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("GetOrganizationRecommendation", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("AccessDeniedException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","AccessDeniedException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = GetOrganizationRecommendationResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("TrustedAdvisor")]
        public void GetOrganizationRecommendation_InternalServerExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("GetOrganizationRecommendation");

            var request = InstantiateClassGenerator.Execute<GetOrganizationRecommendationRequest>(operation);
            var marshaller = new GetOrganizationRecommendationRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("GetOrganizationRecommendation", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InternalServerException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","InternalServerException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = GetOrganizationRecommendationResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("TrustedAdvisor")]
        public void GetOrganizationRecommendation_ResourceNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("GetOrganizationRecommendation");

            var request = InstantiateClassGenerator.Execute<GetOrganizationRecommendationRequest>(operation);
            var marshaller = new GetOrganizationRecommendationRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("GetOrganizationRecommendation", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("ResourceNotFoundException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","ResourceNotFoundException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = GetOrganizationRecommendationResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("TrustedAdvisor")]
        public void GetOrganizationRecommendation_ThrottlingExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("GetOrganizationRecommendation");

            var request = InstantiateClassGenerator.Execute<GetOrganizationRecommendationRequest>(operation);
            var marshaller = new GetOrganizationRecommendationRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("GetOrganizationRecommendation", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("ThrottlingException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","ThrottlingException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = GetOrganizationRecommendationResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("TrustedAdvisor")]
        public void GetOrganizationRecommendation_ValidationExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("GetOrganizationRecommendation");

            var request = InstantiateClassGenerator.Execute<GetOrganizationRecommendationRequest>(operation);
            var marshaller = new GetOrganizationRecommendationRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("GetOrganizationRecommendation", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("ValidationException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","ValidationException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = GetOrganizationRecommendationResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("TrustedAdvisor")]
        public void GetRecommendationMarshallTest()
        {
            var operation = service_model.FindOperation("GetRecommendation");

            var request = InstantiateClassGenerator.Execute<GetRecommendationRequest>(operation);
            var marshaller = new GetRecommendationRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("GetRecommendation", request, internalRequest, service_model);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            
            var payloadResponse = new JsonSampleGenerator(service_model, operation.ResponseStructure).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = GetRecommendationResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context) as GetRecommendationResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("TrustedAdvisor")]
        public void GetRecommendation_AccessDeniedExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("GetRecommendation");

            var request = InstantiateClassGenerator.Execute<GetRecommendationRequest>(operation);
            var marshaller = new GetRecommendationRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("GetRecommendation", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("AccessDeniedException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","AccessDeniedException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = GetRecommendationResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("TrustedAdvisor")]
        public void GetRecommendation_InternalServerExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("GetRecommendation");

            var request = InstantiateClassGenerator.Execute<GetRecommendationRequest>(operation);
            var marshaller = new GetRecommendationRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("GetRecommendation", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InternalServerException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","InternalServerException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = GetRecommendationResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("TrustedAdvisor")]
        public void GetRecommendation_ResourceNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("GetRecommendation");

            var request = InstantiateClassGenerator.Execute<GetRecommendationRequest>(operation);
            var marshaller = new GetRecommendationRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("GetRecommendation", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("ResourceNotFoundException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","ResourceNotFoundException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = GetRecommendationResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("TrustedAdvisor")]
        public void GetRecommendation_ThrottlingExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("GetRecommendation");

            var request = InstantiateClassGenerator.Execute<GetRecommendationRequest>(operation);
            var marshaller = new GetRecommendationRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("GetRecommendation", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("ThrottlingException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","ThrottlingException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = GetRecommendationResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("TrustedAdvisor")]
        public void GetRecommendation_ValidationExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("GetRecommendation");

            var request = InstantiateClassGenerator.Execute<GetRecommendationRequest>(operation);
            var marshaller = new GetRecommendationRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("GetRecommendation", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("ValidationException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","ValidationException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = GetRecommendationResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("TrustedAdvisor")]
        public void ListChecksMarshallTest()
        {
            var operation = service_model.FindOperation("ListChecks");

            var request = InstantiateClassGenerator.Execute<ListChecksRequest>(operation);
            var marshaller = new ListChecksRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("ListChecks", request, internalRequest, service_model);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            
            var payloadResponse = new JsonSampleGenerator(service_model, operation.ResponseStructure).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = ListChecksResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context) as ListChecksResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("TrustedAdvisor")]
        public void ListChecks_AccessDeniedExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ListChecks");

            var request = InstantiateClassGenerator.Execute<ListChecksRequest>(operation);
            var marshaller = new ListChecksRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("ListChecks", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("AccessDeniedException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","AccessDeniedException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = ListChecksResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("TrustedAdvisor")]
        public void ListChecks_InternalServerExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ListChecks");

            var request = InstantiateClassGenerator.Execute<ListChecksRequest>(operation);
            var marshaller = new ListChecksRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("ListChecks", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InternalServerException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","InternalServerException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = ListChecksResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("TrustedAdvisor")]
        public void ListChecks_ThrottlingExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ListChecks");

            var request = InstantiateClassGenerator.Execute<ListChecksRequest>(operation);
            var marshaller = new ListChecksRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("ListChecks", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("ThrottlingException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","ThrottlingException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = ListChecksResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("TrustedAdvisor")]
        public void ListChecks_ValidationExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ListChecks");

            var request = InstantiateClassGenerator.Execute<ListChecksRequest>(operation);
            var marshaller = new ListChecksRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("ListChecks", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("ValidationException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","ValidationException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = ListChecksResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("TrustedAdvisor")]
        public void ListOrganizationRecommendationAccountsMarshallTest()
        {
            var operation = service_model.FindOperation("ListOrganizationRecommendationAccounts");

            var request = InstantiateClassGenerator.Execute<ListOrganizationRecommendationAccountsRequest>(operation);
            var marshaller = new ListOrganizationRecommendationAccountsRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("ListOrganizationRecommendationAccounts", request, internalRequest, service_model);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            
            var payloadResponse = new JsonSampleGenerator(service_model, operation.ResponseStructure).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = ListOrganizationRecommendationAccountsResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context) as ListOrganizationRecommendationAccountsResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("TrustedAdvisor")]
        public void ListOrganizationRecommendationAccounts_AccessDeniedExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ListOrganizationRecommendationAccounts");

            var request = InstantiateClassGenerator.Execute<ListOrganizationRecommendationAccountsRequest>(operation);
            var marshaller = new ListOrganizationRecommendationAccountsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("ListOrganizationRecommendationAccounts", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("AccessDeniedException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","AccessDeniedException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = ListOrganizationRecommendationAccountsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("TrustedAdvisor")]
        public void ListOrganizationRecommendationAccounts_InternalServerExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ListOrganizationRecommendationAccounts");

            var request = InstantiateClassGenerator.Execute<ListOrganizationRecommendationAccountsRequest>(operation);
            var marshaller = new ListOrganizationRecommendationAccountsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("ListOrganizationRecommendationAccounts", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InternalServerException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","InternalServerException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = ListOrganizationRecommendationAccountsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("TrustedAdvisor")]
        public void ListOrganizationRecommendationAccounts_ResourceNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ListOrganizationRecommendationAccounts");

            var request = InstantiateClassGenerator.Execute<ListOrganizationRecommendationAccountsRequest>(operation);
            var marshaller = new ListOrganizationRecommendationAccountsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("ListOrganizationRecommendationAccounts", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("ResourceNotFoundException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","ResourceNotFoundException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = ListOrganizationRecommendationAccountsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("TrustedAdvisor")]
        public void ListOrganizationRecommendationAccounts_ThrottlingExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ListOrganizationRecommendationAccounts");

            var request = InstantiateClassGenerator.Execute<ListOrganizationRecommendationAccountsRequest>(operation);
            var marshaller = new ListOrganizationRecommendationAccountsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("ListOrganizationRecommendationAccounts", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("ThrottlingException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","ThrottlingException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = ListOrganizationRecommendationAccountsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("TrustedAdvisor")]
        public void ListOrganizationRecommendationAccounts_ValidationExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ListOrganizationRecommendationAccounts");

            var request = InstantiateClassGenerator.Execute<ListOrganizationRecommendationAccountsRequest>(operation);
            var marshaller = new ListOrganizationRecommendationAccountsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("ListOrganizationRecommendationAccounts", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("ValidationException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","ValidationException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = ListOrganizationRecommendationAccountsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("TrustedAdvisor")]
        public void ListOrganizationRecommendationResourcesMarshallTest()
        {
            var operation = service_model.FindOperation("ListOrganizationRecommendationResources");

            var request = InstantiateClassGenerator.Execute<ListOrganizationRecommendationResourcesRequest>(operation);
            var marshaller = new ListOrganizationRecommendationResourcesRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("ListOrganizationRecommendationResources", request, internalRequest, service_model);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            
            var payloadResponse = new JsonSampleGenerator(service_model, operation.ResponseStructure).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = ListOrganizationRecommendationResourcesResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context) as ListOrganizationRecommendationResourcesResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("TrustedAdvisor")]
        public void ListOrganizationRecommendationResources_AccessDeniedExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ListOrganizationRecommendationResources");

            var request = InstantiateClassGenerator.Execute<ListOrganizationRecommendationResourcesRequest>(operation);
            var marshaller = new ListOrganizationRecommendationResourcesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("ListOrganizationRecommendationResources", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("AccessDeniedException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","AccessDeniedException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = ListOrganizationRecommendationResourcesResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("TrustedAdvisor")]
        public void ListOrganizationRecommendationResources_InternalServerExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ListOrganizationRecommendationResources");

            var request = InstantiateClassGenerator.Execute<ListOrganizationRecommendationResourcesRequest>(operation);
            var marshaller = new ListOrganizationRecommendationResourcesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("ListOrganizationRecommendationResources", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InternalServerException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","InternalServerException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = ListOrganizationRecommendationResourcesResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("TrustedAdvisor")]
        public void ListOrganizationRecommendationResources_ResourceNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ListOrganizationRecommendationResources");

            var request = InstantiateClassGenerator.Execute<ListOrganizationRecommendationResourcesRequest>(operation);
            var marshaller = new ListOrganizationRecommendationResourcesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("ListOrganizationRecommendationResources", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("ResourceNotFoundException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","ResourceNotFoundException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = ListOrganizationRecommendationResourcesResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("TrustedAdvisor")]
        public void ListOrganizationRecommendationResources_ThrottlingExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ListOrganizationRecommendationResources");

            var request = InstantiateClassGenerator.Execute<ListOrganizationRecommendationResourcesRequest>(operation);
            var marshaller = new ListOrganizationRecommendationResourcesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("ListOrganizationRecommendationResources", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("ThrottlingException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","ThrottlingException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = ListOrganizationRecommendationResourcesResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("TrustedAdvisor")]
        public void ListOrganizationRecommendationResources_ValidationExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ListOrganizationRecommendationResources");

            var request = InstantiateClassGenerator.Execute<ListOrganizationRecommendationResourcesRequest>(operation);
            var marshaller = new ListOrganizationRecommendationResourcesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("ListOrganizationRecommendationResources", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("ValidationException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","ValidationException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = ListOrganizationRecommendationResourcesResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("TrustedAdvisor")]
        public void ListOrganizationRecommendationsMarshallTest()
        {
            var operation = service_model.FindOperation("ListOrganizationRecommendations");

            var request = InstantiateClassGenerator.Execute<ListOrganizationRecommendationsRequest>(operation);
            var marshaller = new ListOrganizationRecommendationsRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("ListOrganizationRecommendations", request, internalRequest, service_model);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            
            var payloadResponse = new JsonSampleGenerator(service_model, operation.ResponseStructure).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = ListOrganizationRecommendationsResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context) as ListOrganizationRecommendationsResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("TrustedAdvisor")]
        public void ListOrganizationRecommendations_AccessDeniedExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ListOrganizationRecommendations");

            var request = InstantiateClassGenerator.Execute<ListOrganizationRecommendationsRequest>(operation);
            var marshaller = new ListOrganizationRecommendationsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("ListOrganizationRecommendations", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("AccessDeniedException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","AccessDeniedException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = ListOrganizationRecommendationsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("TrustedAdvisor")]
        public void ListOrganizationRecommendations_InternalServerExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ListOrganizationRecommendations");

            var request = InstantiateClassGenerator.Execute<ListOrganizationRecommendationsRequest>(operation);
            var marshaller = new ListOrganizationRecommendationsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("ListOrganizationRecommendations", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InternalServerException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","InternalServerException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = ListOrganizationRecommendationsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("TrustedAdvisor")]
        public void ListOrganizationRecommendations_ThrottlingExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ListOrganizationRecommendations");

            var request = InstantiateClassGenerator.Execute<ListOrganizationRecommendationsRequest>(operation);
            var marshaller = new ListOrganizationRecommendationsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("ListOrganizationRecommendations", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("ThrottlingException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","ThrottlingException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = ListOrganizationRecommendationsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("TrustedAdvisor")]
        public void ListOrganizationRecommendations_ValidationExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ListOrganizationRecommendations");

            var request = InstantiateClassGenerator.Execute<ListOrganizationRecommendationsRequest>(operation);
            var marshaller = new ListOrganizationRecommendationsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("ListOrganizationRecommendations", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("ValidationException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","ValidationException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = ListOrganizationRecommendationsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("TrustedAdvisor")]
        public void ListRecommendationResourcesMarshallTest()
        {
            var operation = service_model.FindOperation("ListRecommendationResources");

            var request = InstantiateClassGenerator.Execute<ListRecommendationResourcesRequest>(operation);
            var marshaller = new ListRecommendationResourcesRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("ListRecommendationResources", request, internalRequest, service_model);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            
            var payloadResponse = new JsonSampleGenerator(service_model, operation.ResponseStructure).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = ListRecommendationResourcesResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context) as ListRecommendationResourcesResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("TrustedAdvisor")]
        public void ListRecommendationResources_AccessDeniedExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ListRecommendationResources");

            var request = InstantiateClassGenerator.Execute<ListRecommendationResourcesRequest>(operation);
            var marshaller = new ListRecommendationResourcesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("ListRecommendationResources", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("AccessDeniedException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","AccessDeniedException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = ListRecommendationResourcesResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("TrustedAdvisor")]
        public void ListRecommendationResources_InternalServerExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ListRecommendationResources");

            var request = InstantiateClassGenerator.Execute<ListRecommendationResourcesRequest>(operation);
            var marshaller = new ListRecommendationResourcesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("ListRecommendationResources", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InternalServerException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","InternalServerException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = ListRecommendationResourcesResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("TrustedAdvisor")]
        public void ListRecommendationResources_ResourceNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ListRecommendationResources");

            var request = InstantiateClassGenerator.Execute<ListRecommendationResourcesRequest>(operation);
            var marshaller = new ListRecommendationResourcesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("ListRecommendationResources", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("ResourceNotFoundException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","ResourceNotFoundException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = ListRecommendationResourcesResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("TrustedAdvisor")]
        public void ListRecommendationResources_ThrottlingExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ListRecommendationResources");

            var request = InstantiateClassGenerator.Execute<ListRecommendationResourcesRequest>(operation);
            var marshaller = new ListRecommendationResourcesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("ListRecommendationResources", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("ThrottlingException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","ThrottlingException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = ListRecommendationResourcesResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("TrustedAdvisor")]
        public void ListRecommendationResources_ValidationExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ListRecommendationResources");

            var request = InstantiateClassGenerator.Execute<ListRecommendationResourcesRequest>(operation);
            var marshaller = new ListRecommendationResourcesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("ListRecommendationResources", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("ValidationException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","ValidationException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = ListRecommendationResourcesResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("TrustedAdvisor")]
        public void ListRecommendationsMarshallTest()
        {
            var operation = service_model.FindOperation("ListRecommendations");

            var request = InstantiateClassGenerator.Execute<ListRecommendationsRequest>(operation);
            var marshaller = new ListRecommendationsRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("ListRecommendations", request, internalRequest, service_model);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            
            var payloadResponse = new JsonSampleGenerator(service_model, operation.ResponseStructure).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = ListRecommendationsResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context) as ListRecommendationsResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("TrustedAdvisor")]
        public void ListRecommendations_AccessDeniedExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ListRecommendations");

            var request = InstantiateClassGenerator.Execute<ListRecommendationsRequest>(operation);
            var marshaller = new ListRecommendationsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("ListRecommendations", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("AccessDeniedException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","AccessDeniedException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = ListRecommendationsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("TrustedAdvisor")]
        public void ListRecommendations_InternalServerExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ListRecommendations");

            var request = InstantiateClassGenerator.Execute<ListRecommendationsRequest>(operation);
            var marshaller = new ListRecommendationsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("ListRecommendations", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InternalServerException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","InternalServerException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = ListRecommendationsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("TrustedAdvisor")]
        public void ListRecommendations_ThrottlingExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ListRecommendations");

            var request = InstantiateClassGenerator.Execute<ListRecommendationsRequest>(operation);
            var marshaller = new ListRecommendationsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("ListRecommendations", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("ThrottlingException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","ThrottlingException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = ListRecommendationsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("TrustedAdvisor")]
        public void ListRecommendations_ValidationExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ListRecommendations");

            var request = InstantiateClassGenerator.Execute<ListRecommendationsRequest>(operation);
            var marshaller = new ListRecommendationsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("ListRecommendations", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("ValidationException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","ValidationException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = ListRecommendationsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("TrustedAdvisor")]
        public void UpdateOrganizationRecommendationLifecycleMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateOrganizationRecommendationLifecycle");

            var request = InstantiateClassGenerator.Execute<UpdateOrganizationRecommendationLifecycleRequest>(operation);
            var marshaller = new UpdateOrganizationRecommendationLifecycleRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("UpdateOrganizationRecommendationLifecycle", request, internalRequest, service_model);

        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("TrustedAdvisor")]
        public void UpdateOrganizationRecommendationLifecycle_AccessDeniedExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateOrganizationRecommendationLifecycle");

            var request = InstantiateClassGenerator.Execute<UpdateOrganizationRecommendationLifecycleRequest>(operation);
            var marshaller = new UpdateOrganizationRecommendationLifecycleRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("UpdateOrganizationRecommendationLifecycle", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("AccessDeniedException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","AccessDeniedException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = UpdateOrganizationRecommendationLifecycleResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("TrustedAdvisor")]
        public void UpdateOrganizationRecommendationLifecycle_ConflictExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateOrganizationRecommendationLifecycle");

            var request = InstantiateClassGenerator.Execute<UpdateOrganizationRecommendationLifecycleRequest>(operation);
            var marshaller = new UpdateOrganizationRecommendationLifecycleRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("UpdateOrganizationRecommendationLifecycle", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("ConflictException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","ConflictException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = UpdateOrganizationRecommendationLifecycleResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("TrustedAdvisor")]
        public void UpdateOrganizationRecommendationLifecycle_InternalServerExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateOrganizationRecommendationLifecycle");

            var request = InstantiateClassGenerator.Execute<UpdateOrganizationRecommendationLifecycleRequest>(operation);
            var marshaller = new UpdateOrganizationRecommendationLifecycleRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("UpdateOrganizationRecommendationLifecycle", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InternalServerException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","InternalServerException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = UpdateOrganizationRecommendationLifecycleResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("TrustedAdvisor")]
        public void UpdateOrganizationRecommendationLifecycle_ResourceNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateOrganizationRecommendationLifecycle");

            var request = InstantiateClassGenerator.Execute<UpdateOrganizationRecommendationLifecycleRequest>(operation);
            var marshaller = new UpdateOrganizationRecommendationLifecycleRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("UpdateOrganizationRecommendationLifecycle", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("ResourceNotFoundException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","ResourceNotFoundException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = UpdateOrganizationRecommendationLifecycleResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("TrustedAdvisor")]
        public void UpdateOrganizationRecommendationLifecycle_ThrottlingExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateOrganizationRecommendationLifecycle");

            var request = InstantiateClassGenerator.Execute<UpdateOrganizationRecommendationLifecycleRequest>(operation);
            var marshaller = new UpdateOrganizationRecommendationLifecycleRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("UpdateOrganizationRecommendationLifecycle", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("ThrottlingException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","ThrottlingException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = UpdateOrganizationRecommendationLifecycleResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("TrustedAdvisor")]
        public void UpdateOrganizationRecommendationLifecycle_ValidationExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateOrganizationRecommendationLifecycle");

            var request = InstantiateClassGenerator.Execute<UpdateOrganizationRecommendationLifecycleRequest>(operation);
            var marshaller = new UpdateOrganizationRecommendationLifecycleRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("UpdateOrganizationRecommendationLifecycle", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("ValidationException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","ValidationException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = UpdateOrganizationRecommendationLifecycleResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("TrustedAdvisor")]
        public void UpdateRecommendationLifecycleMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateRecommendationLifecycle");

            var request = InstantiateClassGenerator.Execute<UpdateRecommendationLifecycleRequest>(operation);
            var marshaller = new UpdateRecommendationLifecycleRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("UpdateRecommendationLifecycle", request, internalRequest, service_model);

        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("TrustedAdvisor")]
        public void UpdateRecommendationLifecycle_AccessDeniedExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateRecommendationLifecycle");

            var request = InstantiateClassGenerator.Execute<UpdateRecommendationLifecycleRequest>(operation);
            var marshaller = new UpdateRecommendationLifecycleRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("UpdateRecommendationLifecycle", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("AccessDeniedException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","AccessDeniedException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = UpdateRecommendationLifecycleResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("TrustedAdvisor")]
        public void UpdateRecommendationLifecycle_ConflictExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateRecommendationLifecycle");

            var request = InstantiateClassGenerator.Execute<UpdateRecommendationLifecycleRequest>(operation);
            var marshaller = new UpdateRecommendationLifecycleRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("UpdateRecommendationLifecycle", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("ConflictException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","ConflictException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = UpdateRecommendationLifecycleResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("TrustedAdvisor")]
        public void UpdateRecommendationLifecycle_InternalServerExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateRecommendationLifecycle");

            var request = InstantiateClassGenerator.Execute<UpdateRecommendationLifecycleRequest>(operation);
            var marshaller = new UpdateRecommendationLifecycleRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("UpdateRecommendationLifecycle", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InternalServerException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","InternalServerException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = UpdateRecommendationLifecycleResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("TrustedAdvisor")]
        public void UpdateRecommendationLifecycle_ResourceNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateRecommendationLifecycle");

            var request = InstantiateClassGenerator.Execute<UpdateRecommendationLifecycleRequest>(operation);
            var marshaller = new UpdateRecommendationLifecycleRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("UpdateRecommendationLifecycle", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("ResourceNotFoundException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","ResourceNotFoundException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = UpdateRecommendationLifecycleResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("TrustedAdvisor")]
        public void UpdateRecommendationLifecycle_ThrottlingExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateRecommendationLifecycle");

            var request = InstantiateClassGenerator.Execute<UpdateRecommendationLifecycleRequest>(operation);
            var marshaller = new UpdateRecommendationLifecycleRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("UpdateRecommendationLifecycle", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("ThrottlingException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","ThrottlingException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = UpdateRecommendationLifecycleResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("TrustedAdvisor")]
        public void UpdateRecommendationLifecycle_ValidationExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateRecommendationLifecycle");

            var request = InstantiateClassGenerator.Execute<UpdateRecommendationLifecycleRequest>(operation);
            var marshaller = new UpdateRecommendationLifecycleRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            TestTools.RequestValidator.Validate("UpdateRecommendationLifecycle", request, internalRequest, service_model);

            var exception = operation.Exceptions.First(e => e.Name.Equals("ValidationException"));
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","ValidationException"},
                }
            };

            var payloadResponse = new JsonSampleGenerator(service_model, exception).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, webResponse, true);
            var response = UpdateRecommendationLifecycleResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }
    }
}