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
 * Do not modify this file. This file is generated from the cloudtrail-2013-11-01.normal.json service model.
 */


using System;
using System.IO;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Amazon.CloudTrail;
using Amazon.CloudTrail.Model;
using Amazon.CloudTrail.Model.Internal.MarshallTransformations;
using Amazon.Runtime.Internal.Transform;

using ServiceClientGenerator;

using AWSSDK_DotNet35.UnitTests.TestTools;

namespace AWSSDK_DotNet35.UnitTests.Marshalling
{
    [TestClass]
    public class CloudTrailMarshallingTests
    {
        static readonly ServiceModel service_model = Utils.LoadServiceModel("cloudtrail");
        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void AddTagsMarshallTest()
        {
            var request = InstantiateClassGenerator.Execute<AddTagsRequest>();
            var marshaller = new AddTagsRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);
            Comparer.CompareObjectToJson<AddTagsRequest>(request,jsonRequest);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            var jsonResponse = new JsonSampleGenerator(service_model, service_model.FindOperation("AddTags").ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString());
            UnmarshallerContext context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), false, webResponse);
            var response = AddTagsResponseUnmarshaller.Instance.Unmarshall(context) as AddTagsResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void AddTags_ChannelNotFoundExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("AddTags");

            var request = InstantiateClassGenerator.Execute<AddTagsRequest>();
            var marshaller = new AddTagsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<AddTagsRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("ChannelNotFoundException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","ChannelNotFoundException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = AddTagsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void AddTags_CloudTrailARNInvalidExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("AddTags");

            var request = InstantiateClassGenerator.Execute<AddTagsRequest>();
            var marshaller = new AddTagsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<AddTagsRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("CloudTrailARNInvalidException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","CloudTrailARNInvalidException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = AddTagsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void AddTags_ConflictExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("AddTags");

            var request = InstantiateClassGenerator.Execute<AddTagsRequest>();
            var marshaller = new AddTagsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<AddTagsRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("ConflictException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","ConflictException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = AddTagsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void AddTags_EventDataStoreNotFoundExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("AddTags");

            var request = InstantiateClassGenerator.Execute<AddTagsRequest>();
            var marshaller = new AddTagsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<AddTagsRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("EventDataStoreNotFoundException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","EventDataStoreNotFoundException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = AddTagsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void AddTags_InactiveEventDataStoreExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("AddTags");

            var request = InstantiateClassGenerator.Execute<AddTagsRequest>();
            var marshaller = new AddTagsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<AddTagsRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InactiveEventDataStoreException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","InactiveEventDataStoreException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = AddTagsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void AddTags_InvalidTagParameterExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("AddTags");

            var request = InstantiateClassGenerator.Execute<AddTagsRequest>();
            var marshaller = new AddTagsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<AddTagsRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidTagParameterException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","InvalidTagParameterException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = AddTagsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void AddTags_InvalidTrailNameExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("AddTags");

            var request = InstantiateClassGenerator.Execute<AddTagsRequest>();
            var marshaller = new AddTagsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<AddTagsRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidTrailNameException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","InvalidTrailNameException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = AddTagsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void AddTags_NoManagementAccountSLRExistsExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("AddTags");

            var request = InstantiateClassGenerator.Execute<AddTagsRequest>();
            var marshaller = new AddTagsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<AddTagsRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("NoManagementAccountSLRExistsException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","NoManagementAccountSLRExistsException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = AddTagsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void AddTags_NotOrganizationMasterAccountExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("AddTags");

            var request = InstantiateClassGenerator.Execute<AddTagsRequest>();
            var marshaller = new AddTagsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<AddTagsRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("NotOrganizationMasterAccountException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","NotOrganizationMasterAccountException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = AddTagsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void AddTags_OperationNotPermittedExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("AddTags");

            var request = InstantiateClassGenerator.Execute<AddTagsRequest>();
            var marshaller = new AddTagsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<AddTagsRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("OperationNotPermittedException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","OperationNotPermittedException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = AddTagsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void AddTags_ResourceNotFoundExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("AddTags");

            var request = InstantiateClassGenerator.Execute<AddTagsRequest>();
            var marshaller = new AddTagsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<AddTagsRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("ResourceNotFoundException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","ResourceNotFoundException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = AddTagsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void AddTags_ResourceTypeNotSupportedExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("AddTags");

            var request = InstantiateClassGenerator.Execute<AddTagsRequest>();
            var marshaller = new AddTagsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<AddTagsRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("ResourceTypeNotSupportedException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","ResourceTypeNotSupportedException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = AddTagsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void AddTags_TagsLimitExceededExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("AddTags");

            var request = InstantiateClassGenerator.Execute<AddTagsRequest>();
            var marshaller = new AddTagsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<AddTagsRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("TagsLimitExceededException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","TagsLimitExceededException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = AddTagsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void AddTags_UnsupportedOperationExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("AddTags");

            var request = InstantiateClassGenerator.Execute<AddTagsRequest>();
            var marshaller = new AddTagsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<AddTagsRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("UnsupportedOperationException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","UnsupportedOperationException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = AddTagsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void CancelQueryMarshallTest()
        {
            var request = InstantiateClassGenerator.Execute<CancelQueryRequest>();
            var marshaller = new CancelQueryRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);
            Comparer.CompareObjectToJson<CancelQueryRequest>(request,jsonRequest);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            var jsonResponse = new JsonSampleGenerator(service_model, service_model.FindOperation("CancelQuery").ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString());
            UnmarshallerContext context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), false, webResponse);
            var response = CancelQueryResponseUnmarshaller.Instance.Unmarshall(context) as CancelQueryResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void CancelQuery_ConflictExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("CancelQuery");

            var request = InstantiateClassGenerator.Execute<CancelQueryRequest>();
            var marshaller = new CancelQueryRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<CancelQueryRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("ConflictException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","ConflictException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = CancelQueryResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void CancelQuery_EventDataStoreARNInvalidExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("CancelQuery");

            var request = InstantiateClassGenerator.Execute<CancelQueryRequest>();
            var marshaller = new CancelQueryRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<CancelQueryRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("EventDataStoreARNInvalidException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","EventDataStoreARNInvalidException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = CancelQueryResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void CancelQuery_EventDataStoreNotFoundExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("CancelQuery");

            var request = InstantiateClassGenerator.Execute<CancelQueryRequest>();
            var marshaller = new CancelQueryRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<CancelQueryRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("EventDataStoreNotFoundException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","EventDataStoreNotFoundException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = CancelQueryResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void CancelQuery_InactiveEventDataStoreExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("CancelQuery");

            var request = InstantiateClassGenerator.Execute<CancelQueryRequest>();
            var marshaller = new CancelQueryRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<CancelQueryRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InactiveEventDataStoreException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","InactiveEventDataStoreException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = CancelQueryResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void CancelQuery_InactiveQueryExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("CancelQuery");

            var request = InstantiateClassGenerator.Execute<CancelQueryRequest>();
            var marshaller = new CancelQueryRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<CancelQueryRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InactiveQueryException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","InactiveQueryException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = CancelQueryResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void CancelQuery_InvalidParameterExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("CancelQuery");

            var request = InstantiateClassGenerator.Execute<CancelQueryRequest>();
            var marshaller = new CancelQueryRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<CancelQueryRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidParameterException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","InvalidParameterException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = CancelQueryResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void CancelQuery_NoManagementAccountSLRExistsExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("CancelQuery");

            var request = InstantiateClassGenerator.Execute<CancelQueryRequest>();
            var marshaller = new CancelQueryRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<CancelQueryRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("NoManagementAccountSLRExistsException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","NoManagementAccountSLRExistsException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = CancelQueryResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void CancelQuery_OperationNotPermittedExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("CancelQuery");

            var request = InstantiateClassGenerator.Execute<CancelQueryRequest>();
            var marshaller = new CancelQueryRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<CancelQueryRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("OperationNotPermittedException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","OperationNotPermittedException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = CancelQueryResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void CancelQuery_QueryIdNotFoundExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("CancelQuery");

            var request = InstantiateClassGenerator.Execute<CancelQueryRequest>();
            var marshaller = new CancelQueryRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<CancelQueryRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("QueryIdNotFoundException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","QueryIdNotFoundException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = CancelQueryResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void CancelQuery_UnsupportedOperationExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("CancelQuery");

            var request = InstantiateClassGenerator.Execute<CancelQueryRequest>();
            var marshaller = new CancelQueryRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<CancelQueryRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("UnsupportedOperationException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","UnsupportedOperationException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = CancelQueryResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void CreateChannelMarshallTest()
        {
            var request = InstantiateClassGenerator.Execute<CreateChannelRequest>();
            var marshaller = new CreateChannelRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);
            Comparer.CompareObjectToJson<CreateChannelRequest>(request,jsonRequest);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            var jsonResponse = new JsonSampleGenerator(service_model, service_model.FindOperation("CreateChannel").ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString());
            UnmarshallerContext context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), false, webResponse);
            var response = CreateChannelResponseUnmarshaller.Instance.Unmarshall(context) as CreateChannelResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void CreateChannel_ChannelAlreadyExistsExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("CreateChannel");

            var request = InstantiateClassGenerator.Execute<CreateChannelRequest>();
            var marshaller = new CreateChannelRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<CreateChannelRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("ChannelAlreadyExistsException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","ChannelAlreadyExistsException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = CreateChannelResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void CreateChannel_ChannelMaxLimitExceededExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("CreateChannel");

            var request = InstantiateClassGenerator.Execute<CreateChannelRequest>();
            var marshaller = new CreateChannelRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<CreateChannelRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("ChannelMaxLimitExceededException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","ChannelMaxLimitExceededException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = CreateChannelResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void CreateChannel_EventDataStoreARNInvalidExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("CreateChannel");

            var request = InstantiateClassGenerator.Execute<CreateChannelRequest>();
            var marshaller = new CreateChannelRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<CreateChannelRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("EventDataStoreARNInvalidException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","EventDataStoreARNInvalidException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = CreateChannelResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void CreateChannel_EventDataStoreNotFoundExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("CreateChannel");

            var request = InstantiateClassGenerator.Execute<CreateChannelRequest>();
            var marshaller = new CreateChannelRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<CreateChannelRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("EventDataStoreNotFoundException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","EventDataStoreNotFoundException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = CreateChannelResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void CreateChannel_InactiveEventDataStoreExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("CreateChannel");

            var request = InstantiateClassGenerator.Execute<CreateChannelRequest>();
            var marshaller = new CreateChannelRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<CreateChannelRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InactiveEventDataStoreException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","InactiveEventDataStoreException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = CreateChannelResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void CreateChannel_InvalidEventDataStoreCategoryExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("CreateChannel");

            var request = InstantiateClassGenerator.Execute<CreateChannelRequest>();
            var marshaller = new CreateChannelRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<CreateChannelRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidEventDataStoreCategoryException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","InvalidEventDataStoreCategoryException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = CreateChannelResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void CreateChannel_InvalidParameterExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("CreateChannel");

            var request = InstantiateClassGenerator.Execute<CreateChannelRequest>();
            var marshaller = new CreateChannelRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<CreateChannelRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidParameterException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","InvalidParameterException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = CreateChannelResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void CreateChannel_InvalidSourceExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("CreateChannel");

            var request = InstantiateClassGenerator.Execute<CreateChannelRequest>();
            var marshaller = new CreateChannelRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<CreateChannelRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidSourceException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","InvalidSourceException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = CreateChannelResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void CreateChannel_InvalidTagParameterExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("CreateChannel");

            var request = InstantiateClassGenerator.Execute<CreateChannelRequest>();
            var marshaller = new CreateChannelRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<CreateChannelRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidTagParameterException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","InvalidTagParameterException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = CreateChannelResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void CreateChannel_OperationNotPermittedExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("CreateChannel");

            var request = InstantiateClassGenerator.Execute<CreateChannelRequest>();
            var marshaller = new CreateChannelRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<CreateChannelRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("OperationNotPermittedException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","OperationNotPermittedException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = CreateChannelResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void CreateChannel_TagsLimitExceededExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("CreateChannel");

            var request = InstantiateClassGenerator.Execute<CreateChannelRequest>();
            var marshaller = new CreateChannelRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<CreateChannelRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("TagsLimitExceededException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","TagsLimitExceededException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = CreateChannelResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void CreateChannel_UnsupportedOperationExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("CreateChannel");

            var request = InstantiateClassGenerator.Execute<CreateChannelRequest>();
            var marshaller = new CreateChannelRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<CreateChannelRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("UnsupportedOperationException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","UnsupportedOperationException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = CreateChannelResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void CreateEventDataStoreMarshallTest()
        {
            var request = InstantiateClassGenerator.Execute<CreateEventDataStoreRequest>();
            var marshaller = new CreateEventDataStoreRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);
            Comparer.CompareObjectToJson<CreateEventDataStoreRequest>(request,jsonRequest);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            var jsonResponse = new JsonSampleGenerator(service_model, service_model.FindOperation("CreateEventDataStore").ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString());
            UnmarshallerContext context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), false, webResponse);
            var response = CreateEventDataStoreResponseUnmarshaller.Instance.Unmarshall(context) as CreateEventDataStoreResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void CreateEventDataStore_CloudTrailAccessNotEnabledExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("CreateEventDataStore");

            var request = InstantiateClassGenerator.Execute<CreateEventDataStoreRequest>();
            var marshaller = new CreateEventDataStoreRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<CreateEventDataStoreRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("CloudTrailAccessNotEnabledException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","CloudTrailAccessNotEnabledException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = CreateEventDataStoreResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void CreateEventDataStore_ConflictExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("CreateEventDataStore");

            var request = InstantiateClassGenerator.Execute<CreateEventDataStoreRequest>();
            var marshaller = new CreateEventDataStoreRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<CreateEventDataStoreRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("ConflictException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","ConflictException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = CreateEventDataStoreResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void CreateEventDataStore_EventDataStoreAlreadyExistsExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("CreateEventDataStore");

            var request = InstantiateClassGenerator.Execute<CreateEventDataStoreRequest>();
            var marshaller = new CreateEventDataStoreRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<CreateEventDataStoreRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("EventDataStoreAlreadyExistsException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","EventDataStoreAlreadyExistsException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = CreateEventDataStoreResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void CreateEventDataStore_EventDataStoreMaxLimitExceededExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("CreateEventDataStore");

            var request = InstantiateClassGenerator.Execute<CreateEventDataStoreRequest>();
            var marshaller = new CreateEventDataStoreRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<CreateEventDataStoreRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("EventDataStoreMaxLimitExceededException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","EventDataStoreMaxLimitExceededException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = CreateEventDataStoreResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void CreateEventDataStore_InsufficientDependencyServiceAccessPermissionExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("CreateEventDataStore");

            var request = InstantiateClassGenerator.Execute<CreateEventDataStoreRequest>();
            var marshaller = new CreateEventDataStoreRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<CreateEventDataStoreRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InsufficientDependencyServiceAccessPermissionException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","InsufficientDependencyServiceAccessPermissionException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = CreateEventDataStoreResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void CreateEventDataStore_InsufficientEncryptionPolicyExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("CreateEventDataStore");

            var request = InstantiateClassGenerator.Execute<CreateEventDataStoreRequest>();
            var marshaller = new CreateEventDataStoreRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<CreateEventDataStoreRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InsufficientEncryptionPolicyException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","InsufficientEncryptionPolicyException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = CreateEventDataStoreResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void CreateEventDataStore_InvalidEventSelectorsExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("CreateEventDataStore");

            var request = InstantiateClassGenerator.Execute<CreateEventDataStoreRequest>();
            var marshaller = new CreateEventDataStoreRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<CreateEventDataStoreRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidEventSelectorsException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","InvalidEventSelectorsException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = CreateEventDataStoreResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void CreateEventDataStore_InvalidKmsKeyIdExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("CreateEventDataStore");

            var request = InstantiateClassGenerator.Execute<CreateEventDataStoreRequest>();
            var marshaller = new CreateEventDataStoreRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<CreateEventDataStoreRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidKmsKeyIdException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","InvalidKmsKeyIdException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = CreateEventDataStoreResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void CreateEventDataStore_InvalidParameterExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("CreateEventDataStore");

            var request = InstantiateClassGenerator.Execute<CreateEventDataStoreRequest>();
            var marshaller = new CreateEventDataStoreRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<CreateEventDataStoreRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidParameterException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","InvalidParameterException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = CreateEventDataStoreResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void CreateEventDataStore_InvalidTagParameterExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("CreateEventDataStore");

            var request = InstantiateClassGenerator.Execute<CreateEventDataStoreRequest>();
            var marshaller = new CreateEventDataStoreRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<CreateEventDataStoreRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidTagParameterException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","InvalidTagParameterException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = CreateEventDataStoreResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void CreateEventDataStore_KmsExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("CreateEventDataStore");

            var request = InstantiateClassGenerator.Execute<CreateEventDataStoreRequest>();
            var marshaller = new CreateEventDataStoreRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<CreateEventDataStoreRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("KmsException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","KmsException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = CreateEventDataStoreResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void CreateEventDataStore_KmsKeyNotFoundExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("CreateEventDataStore");

            var request = InstantiateClassGenerator.Execute<CreateEventDataStoreRequest>();
            var marshaller = new CreateEventDataStoreRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<CreateEventDataStoreRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("KmsKeyNotFoundException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","KmsKeyNotFoundException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = CreateEventDataStoreResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void CreateEventDataStore_NoManagementAccountSLRExistsExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("CreateEventDataStore");

            var request = InstantiateClassGenerator.Execute<CreateEventDataStoreRequest>();
            var marshaller = new CreateEventDataStoreRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<CreateEventDataStoreRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("NoManagementAccountSLRExistsException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","NoManagementAccountSLRExistsException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = CreateEventDataStoreResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void CreateEventDataStore_NotOrganizationMasterAccountExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("CreateEventDataStore");

            var request = InstantiateClassGenerator.Execute<CreateEventDataStoreRequest>();
            var marshaller = new CreateEventDataStoreRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<CreateEventDataStoreRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("NotOrganizationMasterAccountException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","NotOrganizationMasterAccountException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = CreateEventDataStoreResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void CreateEventDataStore_OperationNotPermittedExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("CreateEventDataStore");

            var request = InstantiateClassGenerator.Execute<CreateEventDataStoreRequest>();
            var marshaller = new CreateEventDataStoreRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<CreateEventDataStoreRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("OperationNotPermittedException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","OperationNotPermittedException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = CreateEventDataStoreResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void CreateEventDataStore_OrganizationNotInAllFeaturesModeExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("CreateEventDataStore");

            var request = InstantiateClassGenerator.Execute<CreateEventDataStoreRequest>();
            var marshaller = new CreateEventDataStoreRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<CreateEventDataStoreRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("OrganizationNotInAllFeaturesModeException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","OrganizationNotInAllFeaturesModeException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = CreateEventDataStoreResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void CreateEventDataStore_OrganizationsNotInUseExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("CreateEventDataStore");

            var request = InstantiateClassGenerator.Execute<CreateEventDataStoreRequest>();
            var marshaller = new CreateEventDataStoreRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<CreateEventDataStoreRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("OrganizationsNotInUseException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","OrganizationsNotInUseException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = CreateEventDataStoreResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void CreateEventDataStore_UnsupportedOperationExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("CreateEventDataStore");

            var request = InstantiateClassGenerator.Execute<CreateEventDataStoreRequest>();
            var marshaller = new CreateEventDataStoreRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<CreateEventDataStoreRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("UnsupportedOperationException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","UnsupportedOperationException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = CreateEventDataStoreResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void CreateTrailMarshallTest()
        {
            var request = InstantiateClassGenerator.Execute<CreateTrailRequest>();
            var marshaller = new CreateTrailRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);
            Comparer.CompareObjectToJson<CreateTrailRequest>(request,jsonRequest);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            var jsonResponse = new JsonSampleGenerator(service_model, service_model.FindOperation("CreateTrail").ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString());
            UnmarshallerContext context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), false, webResponse);
            var response = CreateTrailResponseUnmarshaller.Instance.Unmarshall(context) as CreateTrailResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void CreateTrail_CloudTrailAccessNotEnabledExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("CreateTrail");

            var request = InstantiateClassGenerator.Execute<CreateTrailRequest>();
            var marshaller = new CreateTrailRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<CreateTrailRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("CloudTrailAccessNotEnabledException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","CloudTrailAccessNotEnabledException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = CreateTrailResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void CreateTrail_CloudTrailInvalidClientTokenIdExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("CreateTrail");

            var request = InstantiateClassGenerator.Execute<CreateTrailRequest>();
            var marshaller = new CreateTrailRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<CreateTrailRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("CloudTrailInvalidClientTokenIdException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","CloudTrailInvalidClientTokenIdException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = CreateTrailResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void CreateTrail_CloudWatchLogsDeliveryUnavailableExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("CreateTrail");

            var request = InstantiateClassGenerator.Execute<CreateTrailRequest>();
            var marshaller = new CreateTrailRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<CreateTrailRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("CloudWatchLogsDeliveryUnavailableException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","CloudWatchLogsDeliveryUnavailableException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = CreateTrailResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void CreateTrail_ConflictExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("CreateTrail");

            var request = InstantiateClassGenerator.Execute<CreateTrailRequest>();
            var marshaller = new CreateTrailRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<CreateTrailRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("ConflictException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","ConflictException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = CreateTrailResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void CreateTrail_InsufficientDependencyServiceAccessPermissionExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("CreateTrail");

            var request = InstantiateClassGenerator.Execute<CreateTrailRequest>();
            var marshaller = new CreateTrailRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<CreateTrailRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InsufficientDependencyServiceAccessPermissionException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","InsufficientDependencyServiceAccessPermissionException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = CreateTrailResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void CreateTrail_InsufficientEncryptionPolicyExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("CreateTrail");

            var request = InstantiateClassGenerator.Execute<CreateTrailRequest>();
            var marshaller = new CreateTrailRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<CreateTrailRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InsufficientEncryptionPolicyException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","InsufficientEncryptionPolicyException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = CreateTrailResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void CreateTrail_InsufficientS3BucketPolicyExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("CreateTrail");

            var request = InstantiateClassGenerator.Execute<CreateTrailRequest>();
            var marshaller = new CreateTrailRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<CreateTrailRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InsufficientS3BucketPolicyException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","InsufficientS3BucketPolicyException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = CreateTrailResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void CreateTrail_InsufficientSnsTopicPolicyExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("CreateTrail");

            var request = InstantiateClassGenerator.Execute<CreateTrailRequest>();
            var marshaller = new CreateTrailRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<CreateTrailRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InsufficientSnsTopicPolicyException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","InsufficientSnsTopicPolicyException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = CreateTrailResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void CreateTrail_InvalidCloudWatchLogsLogGroupArnExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("CreateTrail");

            var request = InstantiateClassGenerator.Execute<CreateTrailRequest>();
            var marshaller = new CreateTrailRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<CreateTrailRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidCloudWatchLogsLogGroupArnException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","InvalidCloudWatchLogsLogGroupArnException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = CreateTrailResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void CreateTrail_InvalidCloudWatchLogsRoleArnExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("CreateTrail");

            var request = InstantiateClassGenerator.Execute<CreateTrailRequest>();
            var marshaller = new CreateTrailRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<CreateTrailRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidCloudWatchLogsRoleArnException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","InvalidCloudWatchLogsRoleArnException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = CreateTrailResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void CreateTrail_InvalidKmsKeyIdExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("CreateTrail");

            var request = InstantiateClassGenerator.Execute<CreateTrailRequest>();
            var marshaller = new CreateTrailRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<CreateTrailRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidKmsKeyIdException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","InvalidKmsKeyIdException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = CreateTrailResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void CreateTrail_InvalidParameterCombinationExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("CreateTrail");

            var request = InstantiateClassGenerator.Execute<CreateTrailRequest>();
            var marshaller = new CreateTrailRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<CreateTrailRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidParameterCombinationException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","InvalidParameterCombinationException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = CreateTrailResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void CreateTrail_InvalidS3BucketNameExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("CreateTrail");

            var request = InstantiateClassGenerator.Execute<CreateTrailRequest>();
            var marshaller = new CreateTrailRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<CreateTrailRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidS3BucketNameException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","InvalidS3BucketNameException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = CreateTrailResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void CreateTrail_InvalidS3PrefixExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("CreateTrail");

            var request = InstantiateClassGenerator.Execute<CreateTrailRequest>();
            var marshaller = new CreateTrailRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<CreateTrailRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidS3PrefixException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","InvalidS3PrefixException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = CreateTrailResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void CreateTrail_InvalidSnsTopicNameExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("CreateTrail");

            var request = InstantiateClassGenerator.Execute<CreateTrailRequest>();
            var marshaller = new CreateTrailRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<CreateTrailRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidSnsTopicNameException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","InvalidSnsTopicNameException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = CreateTrailResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void CreateTrail_InvalidTagParameterExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("CreateTrail");

            var request = InstantiateClassGenerator.Execute<CreateTrailRequest>();
            var marshaller = new CreateTrailRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<CreateTrailRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidTagParameterException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","InvalidTagParameterException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = CreateTrailResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void CreateTrail_InvalidTrailNameExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("CreateTrail");

            var request = InstantiateClassGenerator.Execute<CreateTrailRequest>();
            var marshaller = new CreateTrailRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<CreateTrailRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidTrailNameException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","InvalidTrailNameException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = CreateTrailResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void CreateTrail_KmsExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("CreateTrail");

            var request = InstantiateClassGenerator.Execute<CreateTrailRequest>();
            var marshaller = new CreateTrailRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<CreateTrailRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("KmsException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","KmsException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = CreateTrailResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void CreateTrail_KmsKeyDisabledExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("CreateTrail");

            var request = InstantiateClassGenerator.Execute<CreateTrailRequest>();
            var marshaller = new CreateTrailRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<CreateTrailRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("KmsKeyDisabledException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","KmsKeyDisabledException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = CreateTrailResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void CreateTrail_KmsKeyNotFoundExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("CreateTrail");

            var request = InstantiateClassGenerator.Execute<CreateTrailRequest>();
            var marshaller = new CreateTrailRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<CreateTrailRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("KmsKeyNotFoundException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","KmsKeyNotFoundException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = CreateTrailResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void CreateTrail_MaximumNumberOfTrailsExceededExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("CreateTrail");

            var request = InstantiateClassGenerator.Execute<CreateTrailRequest>();
            var marshaller = new CreateTrailRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<CreateTrailRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("MaximumNumberOfTrailsExceededException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","MaximumNumberOfTrailsExceededException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = CreateTrailResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void CreateTrail_NoManagementAccountSLRExistsExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("CreateTrail");

            var request = InstantiateClassGenerator.Execute<CreateTrailRequest>();
            var marshaller = new CreateTrailRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<CreateTrailRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("NoManagementAccountSLRExistsException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","NoManagementAccountSLRExistsException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = CreateTrailResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void CreateTrail_NotOrganizationMasterAccountExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("CreateTrail");

            var request = InstantiateClassGenerator.Execute<CreateTrailRequest>();
            var marshaller = new CreateTrailRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<CreateTrailRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("NotOrganizationMasterAccountException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","NotOrganizationMasterAccountException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = CreateTrailResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void CreateTrail_OperationNotPermittedExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("CreateTrail");

            var request = InstantiateClassGenerator.Execute<CreateTrailRequest>();
            var marshaller = new CreateTrailRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<CreateTrailRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("OperationNotPermittedException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","OperationNotPermittedException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = CreateTrailResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void CreateTrail_OrganizationNotInAllFeaturesModeExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("CreateTrail");

            var request = InstantiateClassGenerator.Execute<CreateTrailRequest>();
            var marshaller = new CreateTrailRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<CreateTrailRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("OrganizationNotInAllFeaturesModeException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","OrganizationNotInAllFeaturesModeException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = CreateTrailResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void CreateTrail_OrganizationsNotInUseExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("CreateTrail");

            var request = InstantiateClassGenerator.Execute<CreateTrailRequest>();
            var marshaller = new CreateTrailRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<CreateTrailRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("OrganizationsNotInUseException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","OrganizationsNotInUseException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = CreateTrailResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void CreateTrail_S3BucketDoesNotExistExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("CreateTrail");

            var request = InstantiateClassGenerator.Execute<CreateTrailRequest>();
            var marshaller = new CreateTrailRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<CreateTrailRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("S3BucketDoesNotExistException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","S3BucketDoesNotExistException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = CreateTrailResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void CreateTrail_TagsLimitExceededExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("CreateTrail");

            var request = InstantiateClassGenerator.Execute<CreateTrailRequest>();
            var marshaller = new CreateTrailRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<CreateTrailRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("TagsLimitExceededException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","TagsLimitExceededException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = CreateTrailResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void CreateTrail_TrailAlreadyExistsExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("CreateTrail");

            var request = InstantiateClassGenerator.Execute<CreateTrailRequest>();
            var marshaller = new CreateTrailRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<CreateTrailRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("TrailAlreadyExistsException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","TrailAlreadyExistsException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = CreateTrailResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void CreateTrail_TrailNotProvidedExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("CreateTrail");

            var request = InstantiateClassGenerator.Execute<CreateTrailRequest>();
            var marshaller = new CreateTrailRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<CreateTrailRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("TrailNotProvidedException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","TrailNotProvidedException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = CreateTrailResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void CreateTrail_UnsupportedOperationExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("CreateTrail");

            var request = InstantiateClassGenerator.Execute<CreateTrailRequest>();
            var marshaller = new CreateTrailRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<CreateTrailRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("UnsupportedOperationException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","UnsupportedOperationException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = CreateTrailResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void DeleteChannelMarshallTest()
        {
            var request = InstantiateClassGenerator.Execute<DeleteChannelRequest>();
            var marshaller = new DeleteChannelRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);
            Comparer.CompareObjectToJson<DeleteChannelRequest>(request,jsonRequest);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            var jsonResponse = new JsonSampleGenerator(service_model, service_model.FindOperation("DeleteChannel").ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString());
            UnmarshallerContext context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), false, webResponse);
            var response = DeleteChannelResponseUnmarshaller.Instance.Unmarshall(context) as DeleteChannelResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void DeleteChannel_ChannelARNInvalidExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("DeleteChannel");

            var request = InstantiateClassGenerator.Execute<DeleteChannelRequest>();
            var marshaller = new DeleteChannelRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<DeleteChannelRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("ChannelARNInvalidException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","ChannelARNInvalidException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = DeleteChannelResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void DeleteChannel_ChannelNotFoundExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("DeleteChannel");

            var request = InstantiateClassGenerator.Execute<DeleteChannelRequest>();
            var marshaller = new DeleteChannelRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<DeleteChannelRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("ChannelNotFoundException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","ChannelNotFoundException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = DeleteChannelResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void DeleteChannel_OperationNotPermittedExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("DeleteChannel");

            var request = InstantiateClassGenerator.Execute<DeleteChannelRequest>();
            var marshaller = new DeleteChannelRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<DeleteChannelRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("OperationNotPermittedException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","OperationNotPermittedException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = DeleteChannelResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void DeleteChannel_UnsupportedOperationExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("DeleteChannel");

            var request = InstantiateClassGenerator.Execute<DeleteChannelRequest>();
            var marshaller = new DeleteChannelRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<DeleteChannelRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("UnsupportedOperationException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","UnsupportedOperationException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = DeleteChannelResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void DeleteEventDataStoreMarshallTest()
        {
            var request = InstantiateClassGenerator.Execute<DeleteEventDataStoreRequest>();
            var marshaller = new DeleteEventDataStoreRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);
            Comparer.CompareObjectToJson<DeleteEventDataStoreRequest>(request,jsonRequest);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            var jsonResponse = new JsonSampleGenerator(service_model, service_model.FindOperation("DeleteEventDataStore").ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString());
            UnmarshallerContext context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), false, webResponse);
            var response = DeleteEventDataStoreResponseUnmarshaller.Instance.Unmarshall(context) as DeleteEventDataStoreResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void DeleteEventDataStore_ChannelExistsForEDSExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("DeleteEventDataStore");

            var request = InstantiateClassGenerator.Execute<DeleteEventDataStoreRequest>();
            var marshaller = new DeleteEventDataStoreRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<DeleteEventDataStoreRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("ChannelExistsForEDSException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","ChannelExistsForEDSException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = DeleteEventDataStoreResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void DeleteEventDataStore_EventDataStoreARNInvalidExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("DeleteEventDataStore");

            var request = InstantiateClassGenerator.Execute<DeleteEventDataStoreRequest>();
            var marshaller = new DeleteEventDataStoreRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<DeleteEventDataStoreRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("EventDataStoreARNInvalidException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","EventDataStoreARNInvalidException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = DeleteEventDataStoreResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void DeleteEventDataStore_EventDataStoreHasOngoingImportExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("DeleteEventDataStore");

            var request = InstantiateClassGenerator.Execute<DeleteEventDataStoreRequest>();
            var marshaller = new DeleteEventDataStoreRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<DeleteEventDataStoreRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("EventDataStoreHasOngoingImportException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","EventDataStoreHasOngoingImportException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = DeleteEventDataStoreResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void DeleteEventDataStore_EventDataStoreNotFoundExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("DeleteEventDataStore");

            var request = InstantiateClassGenerator.Execute<DeleteEventDataStoreRequest>();
            var marshaller = new DeleteEventDataStoreRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<DeleteEventDataStoreRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("EventDataStoreNotFoundException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","EventDataStoreNotFoundException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = DeleteEventDataStoreResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void DeleteEventDataStore_EventDataStoreTerminationProtectedExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("DeleteEventDataStore");

            var request = InstantiateClassGenerator.Execute<DeleteEventDataStoreRequest>();
            var marshaller = new DeleteEventDataStoreRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<DeleteEventDataStoreRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("EventDataStoreTerminationProtectedException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","EventDataStoreTerminationProtectedException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = DeleteEventDataStoreResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void DeleteEventDataStore_InactiveEventDataStoreExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("DeleteEventDataStore");

            var request = InstantiateClassGenerator.Execute<DeleteEventDataStoreRequest>();
            var marshaller = new DeleteEventDataStoreRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<DeleteEventDataStoreRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InactiveEventDataStoreException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","InactiveEventDataStoreException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = DeleteEventDataStoreResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void DeleteEventDataStore_InsufficientDependencyServiceAccessPermissionExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("DeleteEventDataStore");

            var request = InstantiateClassGenerator.Execute<DeleteEventDataStoreRequest>();
            var marshaller = new DeleteEventDataStoreRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<DeleteEventDataStoreRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InsufficientDependencyServiceAccessPermissionException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","InsufficientDependencyServiceAccessPermissionException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = DeleteEventDataStoreResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void DeleteEventDataStore_InvalidParameterExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("DeleteEventDataStore");

            var request = InstantiateClassGenerator.Execute<DeleteEventDataStoreRequest>();
            var marshaller = new DeleteEventDataStoreRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<DeleteEventDataStoreRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidParameterException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","InvalidParameterException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = DeleteEventDataStoreResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void DeleteEventDataStore_NoManagementAccountSLRExistsExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("DeleteEventDataStore");

            var request = InstantiateClassGenerator.Execute<DeleteEventDataStoreRequest>();
            var marshaller = new DeleteEventDataStoreRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<DeleteEventDataStoreRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("NoManagementAccountSLRExistsException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","NoManagementAccountSLRExistsException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = DeleteEventDataStoreResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void DeleteEventDataStore_NotOrganizationMasterAccountExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("DeleteEventDataStore");

            var request = InstantiateClassGenerator.Execute<DeleteEventDataStoreRequest>();
            var marshaller = new DeleteEventDataStoreRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<DeleteEventDataStoreRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("NotOrganizationMasterAccountException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","NotOrganizationMasterAccountException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = DeleteEventDataStoreResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void DeleteEventDataStore_OperationNotPermittedExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("DeleteEventDataStore");

            var request = InstantiateClassGenerator.Execute<DeleteEventDataStoreRequest>();
            var marshaller = new DeleteEventDataStoreRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<DeleteEventDataStoreRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("OperationNotPermittedException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","OperationNotPermittedException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = DeleteEventDataStoreResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void DeleteEventDataStore_UnsupportedOperationExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("DeleteEventDataStore");

            var request = InstantiateClassGenerator.Execute<DeleteEventDataStoreRequest>();
            var marshaller = new DeleteEventDataStoreRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<DeleteEventDataStoreRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("UnsupportedOperationException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","UnsupportedOperationException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = DeleteEventDataStoreResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void DeleteResourcePolicyMarshallTest()
        {
            var request = InstantiateClassGenerator.Execute<DeleteResourcePolicyRequest>();
            var marshaller = new DeleteResourcePolicyRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);
            Comparer.CompareObjectToJson<DeleteResourcePolicyRequest>(request,jsonRequest);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            var jsonResponse = new JsonSampleGenerator(service_model, service_model.FindOperation("DeleteResourcePolicy").ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString());
            UnmarshallerContext context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), false, webResponse);
            var response = DeleteResourcePolicyResponseUnmarshaller.Instance.Unmarshall(context) as DeleteResourcePolicyResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void DeleteResourcePolicy_OperationNotPermittedExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("DeleteResourcePolicy");

            var request = InstantiateClassGenerator.Execute<DeleteResourcePolicyRequest>();
            var marshaller = new DeleteResourcePolicyRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<DeleteResourcePolicyRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("OperationNotPermittedException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","OperationNotPermittedException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = DeleteResourcePolicyResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void DeleteResourcePolicy_ResourceARNNotValidExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("DeleteResourcePolicy");

            var request = InstantiateClassGenerator.Execute<DeleteResourcePolicyRequest>();
            var marshaller = new DeleteResourcePolicyRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<DeleteResourcePolicyRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("ResourceARNNotValidException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","ResourceARNNotValidException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = DeleteResourcePolicyResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void DeleteResourcePolicy_ResourceNotFoundExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("DeleteResourcePolicy");

            var request = InstantiateClassGenerator.Execute<DeleteResourcePolicyRequest>();
            var marshaller = new DeleteResourcePolicyRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<DeleteResourcePolicyRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("ResourceNotFoundException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","ResourceNotFoundException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = DeleteResourcePolicyResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void DeleteResourcePolicy_ResourcePolicyNotFoundExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("DeleteResourcePolicy");

            var request = InstantiateClassGenerator.Execute<DeleteResourcePolicyRequest>();
            var marshaller = new DeleteResourcePolicyRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<DeleteResourcePolicyRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("ResourcePolicyNotFoundException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","ResourcePolicyNotFoundException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = DeleteResourcePolicyResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void DeleteResourcePolicy_ResourceTypeNotSupportedExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("DeleteResourcePolicy");

            var request = InstantiateClassGenerator.Execute<DeleteResourcePolicyRequest>();
            var marshaller = new DeleteResourcePolicyRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<DeleteResourcePolicyRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("ResourceTypeNotSupportedException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","ResourceTypeNotSupportedException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = DeleteResourcePolicyResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void DeleteResourcePolicy_UnsupportedOperationExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("DeleteResourcePolicy");

            var request = InstantiateClassGenerator.Execute<DeleteResourcePolicyRequest>();
            var marshaller = new DeleteResourcePolicyRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<DeleteResourcePolicyRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("UnsupportedOperationException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","UnsupportedOperationException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = DeleteResourcePolicyResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void DeleteTrailMarshallTest()
        {
            var request = InstantiateClassGenerator.Execute<DeleteTrailRequest>();
            var marshaller = new DeleteTrailRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);
            Comparer.CompareObjectToJson<DeleteTrailRequest>(request,jsonRequest);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            var jsonResponse = new JsonSampleGenerator(service_model, service_model.FindOperation("DeleteTrail").ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString());
            UnmarshallerContext context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), false, webResponse);
            var response = DeleteTrailResponseUnmarshaller.Instance.Unmarshall(context) as DeleteTrailResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void DeleteTrail_CloudTrailARNInvalidExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("DeleteTrail");

            var request = InstantiateClassGenerator.Execute<DeleteTrailRequest>();
            var marshaller = new DeleteTrailRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<DeleteTrailRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("CloudTrailARNInvalidException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","CloudTrailARNInvalidException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = DeleteTrailResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void DeleteTrail_ConflictExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("DeleteTrail");

            var request = InstantiateClassGenerator.Execute<DeleteTrailRequest>();
            var marshaller = new DeleteTrailRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<DeleteTrailRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("ConflictException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","ConflictException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = DeleteTrailResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void DeleteTrail_InsufficientDependencyServiceAccessPermissionExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("DeleteTrail");

            var request = InstantiateClassGenerator.Execute<DeleteTrailRequest>();
            var marshaller = new DeleteTrailRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<DeleteTrailRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InsufficientDependencyServiceAccessPermissionException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","InsufficientDependencyServiceAccessPermissionException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = DeleteTrailResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void DeleteTrail_InvalidHomeRegionExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("DeleteTrail");

            var request = InstantiateClassGenerator.Execute<DeleteTrailRequest>();
            var marshaller = new DeleteTrailRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<DeleteTrailRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidHomeRegionException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","InvalidHomeRegionException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = DeleteTrailResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void DeleteTrail_InvalidTrailNameExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("DeleteTrail");

            var request = InstantiateClassGenerator.Execute<DeleteTrailRequest>();
            var marshaller = new DeleteTrailRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<DeleteTrailRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidTrailNameException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","InvalidTrailNameException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = DeleteTrailResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void DeleteTrail_NoManagementAccountSLRExistsExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("DeleteTrail");

            var request = InstantiateClassGenerator.Execute<DeleteTrailRequest>();
            var marshaller = new DeleteTrailRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<DeleteTrailRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("NoManagementAccountSLRExistsException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","NoManagementAccountSLRExistsException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = DeleteTrailResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void DeleteTrail_NotOrganizationMasterAccountExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("DeleteTrail");

            var request = InstantiateClassGenerator.Execute<DeleteTrailRequest>();
            var marshaller = new DeleteTrailRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<DeleteTrailRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("NotOrganizationMasterAccountException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","NotOrganizationMasterAccountException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = DeleteTrailResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void DeleteTrail_OperationNotPermittedExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("DeleteTrail");

            var request = InstantiateClassGenerator.Execute<DeleteTrailRequest>();
            var marshaller = new DeleteTrailRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<DeleteTrailRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("OperationNotPermittedException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","OperationNotPermittedException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = DeleteTrailResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void DeleteTrail_TrailNotFoundExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("DeleteTrail");

            var request = InstantiateClassGenerator.Execute<DeleteTrailRequest>();
            var marshaller = new DeleteTrailRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<DeleteTrailRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("TrailNotFoundException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","TrailNotFoundException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = DeleteTrailResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void DeleteTrail_UnsupportedOperationExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("DeleteTrail");

            var request = InstantiateClassGenerator.Execute<DeleteTrailRequest>();
            var marshaller = new DeleteTrailRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<DeleteTrailRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("UnsupportedOperationException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","UnsupportedOperationException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = DeleteTrailResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void DeregisterOrganizationDelegatedAdminMarshallTest()
        {
            var request = InstantiateClassGenerator.Execute<DeregisterOrganizationDelegatedAdminRequest>();
            var marshaller = new DeregisterOrganizationDelegatedAdminRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);
            Comparer.CompareObjectToJson<DeregisterOrganizationDelegatedAdminRequest>(request,jsonRequest);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            var jsonResponse = new JsonSampleGenerator(service_model, service_model.FindOperation("DeregisterOrganizationDelegatedAdmin").ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString());
            UnmarshallerContext context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), false, webResponse);
            var response = DeregisterOrganizationDelegatedAdminResponseUnmarshaller.Instance.Unmarshall(context) as DeregisterOrganizationDelegatedAdminResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void DeregisterOrganizationDelegatedAdmin_AccountNotFoundExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("DeregisterOrganizationDelegatedAdmin");

            var request = InstantiateClassGenerator.Execute<DeregisterOrganizationDelegatedAdminRequest>();
            var marshaller = new DeregisterOrganizationDelegatedAdminRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<DeregisterOrganizationDelegatedAdminRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("AccountNotFoundException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","AccountNotFoundException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = DeregisterOrganizationDelegatedAdminResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void DeregisterOrganizationDelegatedAdmin_AccountNotRegisteredExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("DeregisterOrganizationDelegatedAdmin");

            var request = InstantiateClassGenerator.Execute<DeregisterOrganizationDelegatedAdminRequest>();
            var marshaller = new DeregisterOrganizationDelegatedAdminRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<DeregisterOrganizationDelegatedAdminRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("AccountNotRegisteredException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","AccountNotRegisteredException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = DeregisterOrganizationDelegatedAdminResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void DeregisterOrganizationDelegatedAdmin_CloudTrailAccessNotEnabledExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("DeregisterOrganizationDelegatedAdmin");

            var request = InstantiateClassGenerator.Execute<DeregisterOrganizationDelegatedAdminRequest>();
            var marshaller = new DeregisterOrganizationDelegatedAdminRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<DeregisterOrganizationDelegatedAdminRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("CloudTrailAccessNotEnabledException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","CloudTrailAccessNotEnabledException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = DeregisterOrganizationDelegatedAdminResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void DeregisterOrganizationDelegatedAdmin_ConflictExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("DeregisterOrganizationDelegatedAdmin");

            var request = InstantiateClassGenerator.Execute<DeregisterOrganizationDelegatedAdminRequest>();
            var marshaller = new DeregisterOrganizationDelegatedAdminRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<DeregisterOrganizationDelegatedAdminRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("ConflictException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","ConflictException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = DeregisterOrganizationDelegatedAdminResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void DeregisterOrganizationDelegatedAdmin_InsufficientDependencyServiceAccessPermissionExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("DeregisterOrganizationDelegatedAdmin");

            var request = InstantiateClassGenerator.Execute<DeregisterOrganizationDelegatedAdminRequest>();
            var marshaller = new DeregisterOrganizationDelegatedAdminRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<DeregisterOrganizationDelegatedAdminRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InsufficientDependencyServiceAccessPermissionException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","InsufficientDependencyServiceAccessPermissionException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = DeregisterOrganizationDelegatedAdminResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void DeregisterOrganizationDelegatedAdmin_InvalidParameterExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("DeregisterOrganizationDelegatedAdmin");

            var request = InstantiateClassGenerator.Execute<DeregisterOrganizationDelegatedAdminRequest>();
            var marshaller = new DeregisterOrganizationDelegatedAdminRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<DeregisterOrganizationDelegatedAdminRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidParameterException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","InvalidParameterException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = DeregisterOrganizationDelegatedAdminResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void DeregisterOrganizationDelegatedAdmin_NotOrganizationManagementAccountExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("DeregisterOrganizationDelegatedAdmin");

            var request = InstantiateClassGenerator.Execute<DeregisterOrganizationDelegatedAdminRequest>();
            var marshaller = new DeregisterOrganizationDelegatedAdminRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<DeregisterOrganizationDelegatedAdminRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("NotOrganizationManagementAccountException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","NotOrganizationManagementAccountException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = DeregisterOrganizationDelegatedAdminResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void DeregisterOrganizationDelegatedAdmin_OperationNotPermittedExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("DeregisterOrganizationDelegatedAdmin");

            var request = InstantiateClassGenerator.Execute<DeregisterOrganizationDelegatedAdminRequest>();
            var marshaller = new DeregisterOrganizationDelegatedAdminRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<DeregisterOrganizationDelegatedAdminRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("OperationNotPermittedException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","OperationNotPermittedException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = DeregisterOrganizationDelegatedAdminResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void DeregisterOrganizationDelegatedAdmin_OrganizationNotInAllFeaturesModeExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("DeregisterOrganizationDelegatedAdmin");

            var request = InstantiateClassGenerator.Execute<DeregisterOrganizationDelegatedAdminRequest>();
            var marshaller = new DeregisterOrganizationDelegatedAdminRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<DeregisterOrganizationDelegatedAdminRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("OrganizationNotInAllFeaturesModeException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","OrganizationNotInAllFeaturesModeException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = DeregisterOrganizationDelegatedAdminResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void DeregisterOrganizationDelegatedAdmin_OrganizationsNotInUseExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("DeregisterOrganizationDelegatedAdmin");

            var request = InstantiateClassGenerator.Execute<DeregisterOrganizationDelegatedAdminRequest>();
            var marshaller = new DeregisterOrganizationDelegatedAdminRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<DeregisterOrganizationDelegatedAdminRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("OrganizationsNotInUseException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","OrganizationsNotInUseException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = DeregisterOrganizationDelegatedAdminResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void DeregisterOrganizationDelegatedAdmin_UnsupportedOperationExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("DeregisterOrganizationDelegatedAdmin");

            var request = InstantiateClassGenerator.Execute<DeregisterOrganizationDelegatedAdminRequest>();
            var marshaller = new DeregisterOrganizationDelegatedAdminRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<DeregisterOrganizationDelegatedAdminRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("UnsupportedOperationException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","UnsupportedOperationException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = DeregisterOrganizationDelegatedAdminResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void DescribeQueryMarshallTest()
        {
            var request = InstantiateClassGenerator.Execute<DescribeQueryRequest>();
            var marshaller = new DescribeQueryRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);
            Comparer.CompareObjectToJson<DescribeQueryRequest>(request,jsonRequest);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            var jsonResponse = new JsonSampleGenerator(service_model, service_model.FindOperation("DescribeQuery").ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString());
            UnmarshallerContext context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), false, webResponse);
            var response = DescribeQueryResponseUnmarshaller.Instance.Unmarshall(context) as DescribeQueryResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void DescribeQuery_EventDataStoreARNInvalidExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("DescribeQuery");

            var request = InstantiateClassGenerator.Execute<DescribeQueryRequest>();
            var marshaller = new DescribeQueryRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<DescribeQueryRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("EventDataStoreARNInvalidException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","EventDataStoreARNInvalidException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = DescribeQueryResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void DescribeQuery_EventDataStoreNotFoundExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("DescribeQuery");

            var request = InstantiateClassGenerator.Execute<DescribeQueryRequest>();
            var marshaller = new DescribeQueryRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<DescribeQueryRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("EventDataStoreNotFoundException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","EventDataStoreNotFoundException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = DescribeQueryResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void DescribeQuery_InactiveEventDataStoreExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("DescribeQuery");

            var request = InstantiateClassGenerator.Execute<DescribeQueryRequest>();
            var marshaller = new DescribeQueryRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<DescribeQueryRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InactiveEventDataStoreException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","InactiveEventDataStoreException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = DescribeQueryResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void DescribeQuery_InvalidParameterExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("DescribeQuery");

            var request = InstantiateClassGenerator.Execute<DescribeQueryRequest>();
            var marshaller = new DescribeQueryRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<DescribeQueryRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidParameterException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","InvalidParameterException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = DescribeQueryResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void DescribeQuery_NoManagementAccountSLRExistsExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("DescribeQuery");

            var request = InstantiateClassGenerator.Execute<DescribeQueryRequest>();
            var marshaller = new DescribeQueryRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<DescribeQueryRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("NoManagementAccountSLRExistsException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","NoManagementAccountSLRExistsException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = DescribeQueryResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void DescribeQuery_OperationNotPermittedExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("DescribeQuery");

            var request = InstantiateClassGenerator.Execute<DescribeQueryRequest>();
            var marshaller = new DescribeQueryRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<DescribeQueryRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("OperationNotPermittedException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","OperationNotPermittedException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = DescribeQueryResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void DescribeQuery_QueryIdNotFoundExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("DescribeQuery");

            var request = InstantiateClassGenerator.Execute<DescribeQueryRequest>();
            var marshaller = new DescribeQueryRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<DescribeQueryRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("QueryIdNotFoundException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","QueryIdNotFoundException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = DescribeQueryResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void DescribeQuery_UnsupportedOperationExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("DescribeQuery");

            var request = InstantiateClassGenerator.Execute<DescribeQueryRequest>();
            var marshaller = new DescribeQueryRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<DescribeQueryRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("UnsupportedOperationException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","UnsupportedOperationException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = DescribeQueryResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void DescribeTrailsMarshallTest()
        {
            var request = InstantiateClassGenerator.Execute<DescribeTrailsRequest>();
            var marshaller = new DescribeTrailsRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);
            Comparer.CompareObjectToJson<DescribeTrailsRequest>(request,jsonRequest);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            var jsonResponse = new JsonSampleGenerator(service_model, service_model.FindOperation("DescribeTrails").ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString());
            UnmarshallerContext context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), false, webResponse);
            var response = DescribeTrailsResponseUnmarshaller.Instance.Unmarshall(context) as DescribeTrailsResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void DescribeTrails_InvalidTrailNameExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("DescribeTrails");

            var request = InstantiateClassGenerator.Execute<DescribeTrailsRequest>();
            var marshaller = new DescribeTrailsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<DescribeTrailsRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidTrailNameException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","InvalidTrailNameException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = DescribeTrailsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void DescribeTrails_NoManagementAccountSLRExistsExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("DescribeTrails");

            var request = InstantiateClassGenerator.Execute<DescribeTrailsRequest>();
            var marshaller = new DescribeTrailsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<DescribeTrailsRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("NoManagementAccountSLRExistsException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","NoManagementAccountSLRExistsException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = DescribeTrailsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void DescribeTrails_OperationNotPermittedExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("DescribeTrails");

            var request = InstantiateClassGenerator.Execute<DescribeTrailsRequest>();
            var marshaller = new DescribeTrailsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<DescribeTrailsRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("OperationNotPermittedException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","OperationNotPermittedException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = DescribeTrailsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void DescribeTrails_UnsupportedOperationExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("DescribeTrails");

            var request = InstantiateClassGenerator.Execute<DescribeTrailsRequest>();
            var marshaller = new DescribeTrailsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<DescribeTrailsRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("UnsupportedOperationException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","UnsupportedOperationException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = DescribeTrailsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void GetChannelMarshallTest()
        {
            var request = InstantiateClassGenerator.Execute<GetChannelRequest>();
            var marshaller = new GetChannelRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);
            Comparer.CompareObjectToJson<GetChannelRequest>(request,jsonRequest);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            var jsonResponse = new JsonSampleGenerator(service_model, service_model.FindOperation("GetChannel").ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString());
            UnmarshallerContext context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), false, webResponse);
            var response = GetChannelResponseUnmarshaller.Instance.Unmarshall(context) as GetChannelResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void GetChannel_ChannelARNInvalidExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("GetChannel");

            var request = InstantiateClassGenerator.Execute<GetChannelRequest>();
            var marshaller = new GetChannelRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<GetChannelRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("ChannelARNInvalidException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","ChannelARNInvalidException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = GetChannelResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void GetChannel_ChannelNotFoundExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("GetChannel");

            var request = InstantiateClassGenerator.Execute<GetChannelRequest>();
            var marshaller = new GetChannelRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<GetChannelRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("ChannelNotFoundException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","ChannelNotFoundException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = GetChannelResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void GetChannel_OperationNotPermittedExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("GetChannel");

            var request = InstantiateClassGenerator.Execute<GetChannelRequest>();
            var marshaller = new GetChannelRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<GetChannelRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("OperationNotPermittedException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","OperationNotPermittedException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = GetChannelResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void GetChannel_UnsupportedOperationExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("GetChannel");

            var request = InstantiateClassGenerator.Execute<GetChannelRequest>();
            var marshaller = new GetChannelRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<GetChannelRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("UnsupportedOperationException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","UnsupportedOperationException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = GetChannelResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void GetEventDataStoreMarshallTest()
        {
            var request = InstantiateClassGenerator.Execute<GetEventDataStoreRequest>();
            var marshaller = new GetEventDataStoreRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);
            Comparer.CompareObjectToJson<GetEventDataStoreRequest>(request,jsonRequest);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            var jsonResponse = new JsonSampleGenerator(service_model, service_model.FindOperation("GetEventDataStore").ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString());
            UnmarshallerContext context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), false, webResponse);
            var response = GetEventDataStoreResponseUnmarshaller.Instance.Unmarshall(context) as GetEventDataStoreResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void GetEventDataStore_EventDataStoreARNInvalidExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("GetEventDataStore");

            var request = InstantiateClassGenerator.Execute<GetEventDataStoreRequest>();
            var marshaller = new GetEventDataStoreRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<GetEventDataStoreRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("EventDataStoreARNInvalidException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","EventDataStoreARNInvalidException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = GetEventDataStoreResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void GetEventDataStore_EventDataStoreNotFoundExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("GetEventDataStore");

            var request = InstantiateClassGenerator.Execute<GetEventDataStoreRequest>();
            var marshaller = new GetEventDataStoreRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<GetEventDataStoreRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("EventDataStoreNotFoundException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","EventDataStoreNotFoundException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = GetEventDataStoreResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void GetEventDataStore_InvalidParameterExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("GetEventDataStore");

            var request = InstantiateClassGenerator.Execute<GetEventDataStoreRequest>();
            var marshaller = new GetEventDataStoreRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<GetEventDataStoreRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidParameterException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","InvalidParameterException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = GetEventDataStoreResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void GetEventDataStore_NoManagementAccountSLRExistsExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("GetEventDataStore");

            var request = InstantiateClassGenerator.Execute<GetEventDataStoreRequest>();
            var marshaller = new GetEventDataStoreRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<GetEventDataStoreRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("NoManagementAccountSLRExistsException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","NoManagementAccountSLRExistsException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = GetEventDataStoreResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void GetEventDataStore_OperationNotPermittedExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("GetEventDataStore");

            var request = InstantiateClassGenerator.Execute<GetEventDataStoreRequest>();
            var marshaller = new GetEventDataStoreRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<GetEventDataStoreRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("OperationNotPermittedException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","OperationNotPermittedException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = GetEventDataStoreResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void GetEventDataStore_UnsupportedOperationExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("GetEventDataStore");

            var request = InstantiateClassGenerator.Execute<GetEventDataStoreRequest>();
            var marshaller = new GetEventDataStoreRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<GetEventDataStoreRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("UnsupportedOperationException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","UnsupportedOperationException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = GetEventDataStoreResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void GetEventSelectorsMarshallTest()
        {
            var request = InstantiateClassGenerator.Execute<GetEventSelectorsRequest>();
            var marshaller = new GetEventSelectorsRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);
            Comparer.CompareObjectToJson<GetEventSelectorsRequest>(request,jsonRequest);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            var jsonResponse = new JsonSampleGenerator(service_model, service_model.FindOperation("GetEventSelectors").ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString());
            UnmarshallerContext context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), false, webResponse);
            var response = GetEventSelectorsResponseUnmarshaller.Instance.Unmarshall(context) as GetEventSelectorsResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void GetEventSelectors_CloudTrailARNInvalidExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("GetEventSelectors");

            var request = InstantiateClassGenerator.Execute<GetEventSelectorsRequest>();
            var marshaller = new GetEventSelectorsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<GetEventSelectorsRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("CloudTrailARNInvalidException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","CloudTrailARNInvalidException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = GetEventSelectorsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void GetEventSelectors_InvalidTrailNameExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("GetEventSelectors");

            var request = InstantiateClassGenerator.Execute<GetEventSelectorsRequest>();
            var marshaller = new GetEventSelectorsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<GetEventSelectorsRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidTrailNameException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","InvalidTrailNameException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = GetEventSelectorsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void GetEventSelectors_NoManagementAccountSLRExistsExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("GetEventSelectors");

            var request = InstantiateClassGenerator.Execute<GetEventSelectorsRequest>();
            var marshaller = new GetEventSelectorsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<GetEventSelectorsRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("NoManagementAccountSLRExistsException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","NoManagementAccountSLRExistsException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = GetEventSelectorsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void GetEventSelectors_OperationNotPermittedExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("GetEventSelectors");

            var request = InstantiateClassGenerator.Execute<GetEventSelectorsRequest>();
            var marshaller = new GetEventSelectorsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<GetEventSelectorsRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("OperationNotPermittedException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","OperationNotPermittedException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = GetEventSelectorsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void GetEventSelectors_TrailNotFoundExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("GetEventSelectors");

            var request = InstantiateClassGenerator.Execute<GetEventSelectorsRequest>();
            var marshaller = new GetEventSelectorsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<GetEventSelectorsRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("TrailNotFoundException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","TrailNotFoundException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = GetEventSelectorsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void GetEventSelectors_UnsupportedOperationExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("GetEventSelectors");

            var request = InstantiateClassGenerator.Execute<GetEventSelectorsRequest>();
            var marshaller = new GetEventSelectorsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<GetEventSelectorsRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("UnsupportedOperationException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","UnsupportedOperationException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = GetEventSelectorsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void GetImportMarshallTest()
        {
            var request = InstantiateClassGenerator.Execute<GetImportRequest>();
            var marshaller = new GetImportRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);
            Comparer.CompareObjectToJson<GetImportRequest>(request,jsonRequest);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            var jsonResponse = new JsonSampleGenerator(service_model, service_model.FindOperation("GetImport").ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString());
            UnmarshallerContext context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), false, webResponse);
            var response = GetImportResponseUnmarshaller.Instance.Unmarshall(context) as GetImportResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void GetImport_ImportNotFoundExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("GetImport");

            var request = InstantiateClassGenerator.Execute<GetImportRequest>();
            var marshaller = new GetImportRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<GetImportRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("ImportNotFoundException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","ImportNotFoundException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = GetImportResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void GetImport_InvalidParameterExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("GetImport");

            var request = InstantiateClassGenerator.Execute<GetImportRequest>();
            var marshaller = new GetImportRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<GetImportRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidParameterException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","InvalidParameterException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = GetImportResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void GetImport_OperationNotPermittedExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("GetImport");

            var request = InstantiateClassGenerator.Execute<GetImportRequest>();
            var marshaller = new GetImportRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<GetImportRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("OperationNotPermittedException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","OperationNotPermittedException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = GetImportResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void GetImport_UnsupportedOperationExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("GetImport");

            var request = InstantiateClassGenerator.Execute<GetImportRequest>();
            var marshaller = new GetImportRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<GetImportRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("UnsupportedOperationException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","UnsupportedOperationException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = GetImportResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void GetInsightSelectorsMarshallTest()
        {
            var request = InstantiateClassGenerator.Execute<GetInsightSelectorsRequest>();
            var marshaller = new GetInsightSelectorsRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);
            Comparer.CompareObjectToJson<GetInsightSelectorsRequest>(request,jsonRequest);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            var jsonResponse = new JsonSampleGenerator(service_model, service_model.FindOperation("GetInsightSelectors").ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString());
            UnmarshallerContext context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), false, webResponse);
            var response = GetInsightSelectorsResponseUnmarshaller.Instance.Unmarshall(context) as GetInsightSelectorsResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void GetInsightSelectors_CloudTrailARNInvalidExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("GetInsightSelectors");

            var request = InstantiateClassGenerator.Execute<GetInsightSelectorsRequest>();
            var marshaller = new GetInsightSelectorsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<GetInsightSelectorsRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("CloudTrailARNInvalidException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","CloudTrailARNInvalidException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = GetInsightSelectorsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void GetInsightSelectors_InsightNotEnabledExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("GetInsightSelectors");

            var request = InstantiateClassGenerator.Execute<GetInsightSelectorsRequest>();
            var marshaller = new GetInsightSelectorsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<GetInsightSelectorsRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InsightNotEnabledException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","InsightNotEnabledException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = GetInsightSelectorsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void GetInsightSelectors_InvalidTrailNameExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("GetInsightSelectors");

            var request = InstantiateClassGenerator.Execute<GetInsightSelectorsRequest>();
            var marshaller = new GetInsightSelectorsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<GetInsightSelectorsRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidTrailNameException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","InvalidTrailNameException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = GetInsightSelectorsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void GetInsightSelectors_NoManagementAccountSLRExistsExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("GetInsightSelectors");

            var request = InstantiateClassGenerator.Execute<GetInsightSelectorsRequest>();
            var marshaller = new GetInsightSelectorsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<GetInsightSelectorsRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("NoManagementAccountSLRExistsException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","NoManagementAccountSLRExistsException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = GetInsightSelectorsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void GetInsightSelectors_OperationNotPermittedExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("GetInsightSelectors");

            var request = InstantiateClassGenerator.Execute<GetInsightSelectorsRequest>();
            var marshaller = new GetInsightSelectorsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<GetInsightSelectorsRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("OperationNotPermittedException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","OperationNotPermittedException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = GetInsightSelectorsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void GetInsightSelectors_TrailNotFoundExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("GetInsightSelectors");

            var request = InstantiateClassGenerator.Execute<GetInsightSelectorsRequest>();
            var marshaller = new GetInsightSelectorsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<GetInsightSelectorsRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("TrailNotFoundException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","TrailNotFoundException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = GetInsightSelectorsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void GetInsightSelectors_UnsupportedOperationExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("GetInsightSelectors");

            var request = InstantiateClassGenerator.Execute<GetInsightSelectorsRequest>();
            var marshaller = new GetInsightSelectorsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<GetInsightSelectorsRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("UnsupportedOperationException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","UnsupportedOperationException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = GetInsightSelectorsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void GetQueryResultsMarshallTest()
        {
            var request = InstantiateClassGenerator.Execute<GetQueryResultsRequest>();
            var marshaller = new GetQueryResultsRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);
            Comparer.CompareObjectToJson<GetQueryResultsRequest>(request,jsonRequest);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            var jsonResponse = new JsonSampleGenerator(service_model, service_model.FindOperation("GetQueryResults").ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString());
            UnmarshallerContext context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), false, webResponse);
            var response = GetQueryResultsResponseUnmarshaller.Instance.Unmarshall(context) as GetQueryResultsResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void GetQueryResults_EventDataStoreARNInvalidExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("GetQueryResults");

            var request = InstantiateClassGenerator.Execute<GetQueryResultsRequest>();
            var marshaller = new GetQueryResultsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<GetQueryResultsRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("EventDataStoreARNInvalidException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","EventDataStoreARNInvalidException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = GetQueryResultsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void GetQueryResults_EventDataStoreNotFoundExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("GetQueryResults");

            var request = InstantiateClassGenerator.Execute<GetQueryResultsRequest>();
            var marshaller = new GetQueryResultsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<GetQueryResultsRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("EventDataStoreNotFoundException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","EventDataStoreNotFoundException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = GetQueryResultsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void GetQueryResults_InactiveEventDataStoreExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("GetQueryResults");

            var request = InstantiateClassGenerator.Execute<GetQueryResultsRequest>();
            var marshaller = new GetQueryResultsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<GetQueryResultsRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InactiveEventDataStoreException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","InactiveEventDataStoreException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = GetQueryResultsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void GetQueryResults_InsufficientEncryptionPolicyExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("GetQueryResults");

            var request = InstantiateClassGenerator.Execute<GetQueryResultsRequest>();
            var marshaller = new GetQueryResultsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<GetQueryResultsRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InsufficientEncryptionPolicyException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","InsufficientEncryptionPolicyException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = GetQueryResultsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void GetQueryResults_InvalidMaxResultsExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("GetQueryResults");

            var request = InstantiateClassGenerator.Execute<GetQueryResultsRequest>();
            var marshaller = new GetQueryResultsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<GetQueryResultsRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidMaxResultsException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","InvalidMaxResultsException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = GetQueryResultsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void GetQueryResults_InvalidNextTokenExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("GetQueryResults");

            var request = InstantiateClassGenerator.Execute<GetQueryResultsRequest>();
            var marshaller = new GetQueryResultsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<GetQueryResultsRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidNextTokenException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","InvalidNextTokenException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = GetQueryResultsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void GetQueryResults_InvalidParameterExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("GetQueryResults");

            var request = InstantiateClassGenerator.Execute<GetQueryResultsRequest>();
            var marshaller = new GetQueryResultsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<GetQueryResultsRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidParameterException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","InvalidParameterException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = GetQueryResultsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void GetQueryResults_NoManagementAccountSLRExistsExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("GetQueryResults");

            var request = InstantiateClassGenerator.Execute<GetQueryResultsRequest>();
            var marshaller = new GetQueryResultsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<GetQueryResultsRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("NoManagementAccountSLRExistsException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","NoManagementAccountSLRExistsException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = GetQueryResultsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void GetQueryResults_OperationNotPermittedExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("GetQueryResults");

            var request = InstantiateClassGenerator.Execute<GetQueryResultsRequest>();
            var marshaller = new GetQueryResultsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<GetQueryResultsRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("OperationNotPermittedException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","OperationNotPermittedException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = GetQueryResultsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void GetQueryResults_QueryIdNotFoundExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("GetQueryResults");

            var request = InstantiateClassGenerator.Execute<GetQueryResultsRequest>();
            var marshaller = new GetQueryResultsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<GetQueryResultsRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("QueryIdNotFoundException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","QueryIdNotFoundException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = GetQueryResultsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void GetQueryResults_UnsupportedOperationExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("GetQueryResults");

            var request = InstantiateClassGenerator.Execute<GetQueryResultsRequest>();
            var marshaller = new GetQueryResultsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<GetQueryResultsRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("UnsupportedOperationException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","UnsupportedOperationException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = GetQueryResultsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void GetResourcePolicyMarshallTest()
        {
            var request = InstantiateClassGenerator.Execute<GetResourcePolicyRequest>();
            var marshaller = new GetResourcePolicyRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);
            Comparer.CompareObjectToJson<GetResourcePolicyRequest>(request,jsonRequest);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            var jsonResponse = new JsonSampleGenerator(service_model, service_model.FindOperation("GetResourcePolicy").ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString());
            UnmarshallerContext context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), false, webResponse);
            var response = GetResourcePolicyResponseUnmarshaller.Instance.Unmarshall(context) as GetResourcePolicyResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void GetResourcePolicy_OperationNotPermittedExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("GetResourcePolicy");

            var request = InstantiateClassGenerator.Execute<GetResourcePolicyRequest>();
            var marshaller = new GetResourcePolicyRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<GetResourcePolicyRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("OperationNotPermittedException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","OperationNotPermittedException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = GetResourcePolicyResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void GetResourcePolicy_ResourceARNNotValidExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("GetResourcePolicy");

            var request = InstantiateClassGenerator.Execute<GetResourcePolicyRequest>();
            var marshaller = new GetResourcePolicyRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<GetResourcePolicyRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("ResourceARNNotValidException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","ResourceARNNotValidException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = GetResourcePolicyResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void GetResourcePolicy_ResourceNotFoundExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("GetResourcePolicy");

            var request = InstantiateClassGenerator.Execute<GetResourcePolicyRequest>();
            var marshaller = new GetResourcePolicyRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<GetResourcePolicyRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("ResourceNotFoundException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","ResourceNotFoundException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = GetResourcePolicyResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void GetResourcePolicy_ResourcePolicyNotFoundExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("GetResourcePolicy");

            var request = InstantiateClassGenerator.Execute<GetResourcePolicyRequest>();
            var marshaller = new GetResourcePolicyRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<GetResourcePolicyRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("ResourcePolicyNotFoundException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","ResourcePolicyNotFoundException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = GetResourcePolicyResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void GetResourcePolicy_ResourceTypeNotSupportedExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("GetResourcePolicy");

            var request = InstantiateClassGenerator.Execute<GetResourcePolicyRequest>();
            var marshaller = new GetResourcePolicyRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<GetResourcePolicyRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("ResourceTypeNotSupportedException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","ResourceTypeNotSupportedException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = GetResourcePolicyResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void GetResourcePolicy_UnsupportedOperationExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("GetResourcePolicy");

            var request = InstantiateClassGenerator.Execute<GetResourcePolicyRequest>();
            var marshaller = new GetResourcePolicyRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<GetResourcePolicyRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("UnsupportedOperationException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","UnsupportedOperationException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = GetResourcePolicyResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void GetTrailMarshallTest()
        {
            var request = InstantiateClassGenerator.Execute<GetTrailRequest>();
            var marshaller = new GetTrailRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);
            Comparer.CompareObjectToJson<GetTrailRequest>(request,jsonRequest);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            var jsonResponse = new JsonSampleGenerator(service_model, service_model.FindOperation("GetTrail").ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString());
            UnmarshallerContext context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), false, webResponse);
            var response = GetTrailResponseUnmarshaller.Instance.Unmarshall(context) as GetTrailResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void GetTrail_CloudTrailARNInvalidExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("GetTrail");

            var request = InstantiateClassGenerator.Execute<GetTrailRequest>();
            var marshaller = new GetTrailRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<GetTrailRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("CloudTrailARNInvalidException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","CloudTrailARNInvalidException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = GetTrailResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void GetTrail_InvalidTrailNameExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("GetTrail");

            var request = InstantiateClassGenerator.Execute<GetTrailRequest>();
            var marshaller = new GetTrailRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<GetTrailRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidTrailNameException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","InvalidTrailNameException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = GetTrailResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void GetTrail_OperationNotPermittedExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("GetTrail");

            var request = InstantiateClassGenerator.Execute<GetTrailRequest>();
            var marshaller = new GetTrailRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<GetTrailRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("OperationNotPermittedException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","OperationNotPermittedException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = GetTrailResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void GetTrail_TrailNotFoundExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("GetTrail");

            var request = InstantiateClassGenerator.Execute<GetTrailRequest>();
            var marshaller = new GetTrailRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<GetTrailRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("TrailNotFoundException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","TrailNotFoundException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = GetTrailResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void GetTrail_UnsupportedOperationExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("GetTrail");

            var request = InstantiateClassGenerator.Execute<GetTrailRequest>();
            var marshaller = new GetTrailRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<GetTrailRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("UnsupportedOperationException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","UnsupportedOperationException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = GetTrailResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void GetTrailStatusMarshallTest()
        {
            var request = InstantiateClassGenerator.Execute<GetTrailStatusRequest>();
            var marshaller = new GetTrailStatusRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);
            Comparer.CompareObjectToJson<GetTrailStatusRequest>(request,jsonRequest);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            var jsonResponse = new JsonSampleGenerator(service_model, service_model.FindOperation("GetTrailStatus").ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString());
            UnmarshallerContext context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), false, webResponse);
            var response = GetTrailStatusResponseUnmarshaller.Instance.Unmarshall(context) as GetTrailStatusResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void GetTrailStatus_CloudTrailARNInvalidExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("GetTrailStatus");

            var request = InstantiateClassGenerator.Execute<GetTrailStatusRequest>();
            var marshaller = new GetTrailStatusRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<GetTrailStatusRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("CloudTrailARNInvalidException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","CloudTrailARNInvalidException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = GetTrailStatusResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void GetTrailStatus_InvalidTrailNameExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("GetTrailStatus");

            var request = InstantiateClassGenerator.Execute<GetTrailStatusRequest>();
            var marshaller = new GetTrailStatusRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<GetTrailStatusRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidTrailNameException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","InvalidTrailNameException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = GetTrailStatusResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void GetTrailStatus_OperationNotPermittedExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("GetTrailStatus");

            var request = InstantiateClassGenerator.Execute<GetTrailStatusRequest>();
            var marshaller = new GetTrailStatusRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<GetTrailStatusRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("OperationNotPermittedException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","OperationNotPermittedException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = GetTrailStatusResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void GetTrailStatus_TrailNotFoundExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("GetTrailStatus");

            var request = InstantiateClassGenerator.Execute<GetTrailStatusRequest>();
            var marshaller = new GetTrailStatusRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<GetTrailStatusRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("TrailNotFoundException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","TrailNotFoundException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = GetTrailStatusResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void GetTrailStatus_UnsupportedOperationExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("GetTrailStatus");

            var request = InstantiateClassGenerator.Execute<GetTrailStatusRequest>();
            var marshaller = new GetTrailStatusRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<GetTrailStatusRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("UnsupportedOperationException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","UnsupportedOperationException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = GetTrailStatusResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void ListChannelsMarshallTest()
        {
            var request = InstantiateClassGenerator.Execute<ListChannelsRequest>();
            var marshaller = new ListChannelsRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);
            Comparer.CompareObjectToJson<ListChannelsRequest>(request,jsonRequest);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            var jsonResponse = new JsonSampleGenerator(service_model, service_model.FindOperation("ListChannels").ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString());
            UnmarshallerContext context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), false, webResponse);
            var response = ListChannelsResponseUnmarshaller.Instance.Unmarshall(context) as ListChannelsResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void ListChannels_InvalidNextTokenExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("ListChannels");

            var request = InstantiateClassGenerator.Execute<ListChannelsRequest>();
            var marshaller = new ListChannelsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<ListChannelsRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidNextTokenException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","InvalidNextTokenException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = ListChannelsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void ListChannels_OperationNotPermittedExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("ListChannels");

            var request = InstantiateClassGenerator.Execute<ListChannelsRequest>();
            var marshaller = new ListChannelsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<ListChannelsRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("OperationNotPermittedException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","OperationNotPermittedException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = ListChannelsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void ListChannels_UnsupportedOperationExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("ListChannels");

            var request = InstantiateClassGenerator.Execute<ListChannelsRequest>();
            var marshaller = new ListChannelsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<ListChannelsRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("UnsupportedOperationException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","UnsupportedOperationException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = ListChannelsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void ListEventDataStoresMarshallTest()
        {
            var request = InstantiateClassGenerator.Execute<ListEventDataStoresRequest>();
            var marshaller = new ListEventDataStoresRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);
            Comparer.CompareObjectToJson<ListEventDataStoresRequest>(request,jsonRequest);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            var jsonResponse = new JsonSampleGenerator(service_model, service_model.FindOperation("ListEventDataStores").ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString());
            UnmarshallerContext context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), false, webResponse);
            var response = ListEventDataStoresResponseUnmarshaller.Instance.Unmarshall(context) as ListEventDataStoresResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void ListEventDataStores_InvalidMaxResultsExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("ListEventDataStores");

            var request = InstantiateClassGenerator.Execute<ListEventDataStoresRequest>();
            var marshaller = new ListEventDataStoresRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<ListEventDataStoresRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidMaxResultsException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","InvalidMaxResultsException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = ListEventDataStoresResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void ListEventDataStores_InvalidNextTokenExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("ListEventDataStores");

            var request = InstantiateClassGenerator.Execute<ListEventDataStoresRequest>();
            var marshaller = new ListEventDataStoresRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<ListEventDataStoresRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidNextTokenException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","InvalidNextTokenException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = ListEventDataStoresResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void ListEventDataStores_NoManagementAccountSLRExistsExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("ListEventDataStores");

            var request = InstantiateClassGenerator.Execute<ListEventDataStoresRequest>();
            var marshaller = new ListEventDataStoresRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<ListEventDataStoresRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("NoManagementAccountSLRExistsException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","NoManagementAccountSLRExistsException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = ListEventDataStoresResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void ListEventDataStores_OperationNotPermittedExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("ListEventDataStores");

            var request = InstantiateClassGenerator.Execute<ListEventDataStoresRequest>();
            var marshaller = new ListEventDataStoresRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<ListEventDataStoresRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("OperationNotPermittedException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","OperationNotPermittedException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = ListEventDataStoresResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void ListEventDataStores_UnsupportedOperationExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("ListEventDataStores");

            var request = InstantiateClassGenerator.Execute<ListEventDataStoresRequest>();
            var marshaller = new ListEventDataStoresRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<ListEventDataStoresRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("UnsupportedOperationException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","UnsupportedOperationException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = ListEventDataStoresResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void ListImportFailuresMarshallTest()
        {
            var request = InstantiateClassGenerator.Execute<ListImportFailuresRequest>();
            var marshaller = new ListImportFailuresRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);
            Comparer.CompareObjectToJson<ListImportFailuresRequest>(request,jsonRequest);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            var jsonResponse = new JsonSampleGenerator(service_model, service_model.FindOperation("ListImportFailures").ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString());
            UnmarshallerContext context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), false, webResponse);
            var response = ListImportFailuresResponseUnmarshaller.Instance.Unmarshall(context) as ListImportFailuresResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void ListImportFailures_InvalidNextTokenExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("ListImportFailures");

            var request = InstantiateClassGenerator.Execute<ListImportFailuresRequest>();
            var marshaller = new ListImportFailuresRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<ListImportFailuresRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidNextTokenException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","InvalidNextTokenException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = ListImportFailuresResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void ListImportFailures_OperationNotPermittedExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("ListImportFailures");

            var request = InstantiateClassGenerator.Execute<ListImportFailuresRequest>();
            var marshaller = new ListImportFailuresRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<ListImportFailuresRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("OperationNotPermittedException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","OperationNotPermittedException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = ListImportFailuresResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void ListImportFailures_UnsupportedOperationExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("ListImportFailures");

            var request = InstantiateClassGenerator.Execute<ListImportFailuresRequest>();
            var marshaller = new ListImportFailuresRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<ListImportFailuresRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("UnsupportedOperationException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","UnsupportedOperationException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = ListImportFailuresResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void ListImportsMarshallTest()
        {
            var request = InstantiateClassGenerator.Execute<ListImportsRequest>();
            var marshaller = new ListImportsRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);
            Comparer.CompareObjectToJson<ListImportsRequest>(request,jsonRequest);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            var jsonResponse = new JsonSampleGenerator(service_model, service_model.FindOperation("ListImports").ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString());
            UnmarshallerContext context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), false, webResponse);
            var response = ListImportsResponseUnmarshaller.Instance.Unmarshall(context) as ListImportsResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void ListImports_EventDataStoreARNInvalidExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("ListImports");

            var request = InstantiateClassGenerator.Execute<ListImportsRequest>();
            var marshaller = new ListImportsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<ListImportsRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("EventDataStoreARNInvalidException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","EventDataStoreARNInvalidException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = ListImportsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void ListImports_InvalidNextTokenExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("ListImports");

            var request = InstantiateClassGenerator.Execute<ListImportsRequest>();
            var marshaller = new ListImportsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<ListImportsRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidNextTokenException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","InvalidNextTokenException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = ListImportsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void ListImports_InvalidParameterExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("ListImports");

            var request = InstantiateClassGenerator.Execute<ListImportsRequest>();
            var marshaller = new ListImportsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<ListImportsRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidParameterException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","InvalidParameterException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = ListImportsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void ListImports_OperationNotPermittedExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("ListImports");

            var request = InstantiateClassGenerator.Execute<ListImportsRequest>();
            var marshaller = new ListImportsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<ListImportsRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("OperationNotPermittedException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","OperationNotPermittedException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = ListImportsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void ListImports_UnsupportedOperationExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("ListImports");

            var request = InstantiateClassGenerator.Execute<ListImportsRequest>();
            var marshaller = new ListImportsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<ListImportsRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("UnsupportedOperationException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","UnsupportedOperationException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = ListImportsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void ListPublicKeysMarshallTest()
        {
            var request = InstantiateClassGenerator.Execute<ListPublicKeysRequest>();
            var marshaller = new ListPublicKeysRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);
            Comparer.CompareObjectToJson<ListPublicKeysRequest>(request,jsonRequest);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            var jsonResponse = new JsonSampleGenerator(service_model, service_model.FindOperation("ListPublicKeys").ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString());
            UnmarshallerContext context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), false, webResponse);
            var response = ListPublicKeysResponseUnmarshaller.Instance.Unmarshall(context) as ListPublicKeysResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void ListPublicKeys_InvalidTimeRangeExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("ListPublicKeys");

            var request = InstantiateClassGenerator.Execute<ListPublicKeysRequest>();
            var marshaller = new ListPublicKeysRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<ListPublicKeysRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidTimeRangeException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","InvalidTimeRangeException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = ListPublicKeysResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void ListPublicKeys_InvalidTokenExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("ListPublicKeys");

            var request = InstantiateClassGenerator.Execute<ListPublicKeysRequest>();
            var marshaller = new ListPublicKeysRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<ListPublicKeysRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidTokenException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","InvalidTokenException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = ListPublicKeysResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void ListPublicKeys_OperationNotPermittedExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("ListPublicKeys");

            var request = InstantiateClassGenerator.Execute<ListPublicKeysRequest>();
            var marshaller = new ListPublicKeysRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<ListPublicKeysRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("OperationNotPermittedException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","OperationNotPermittedException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = ListPublicKeysResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void ListPublicKeys_UnsupportedOperationExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("ListPublicKeys");

            var request = InstantiateClassGenerator.Execute<ListPublicKeysRequest>();
            var marshaller = new ListPublicKeysRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<ListPublicKeysRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("UnsupportedOperationException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","UnsupportedOperationException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = ListPublicKeysResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void ListQueriesMarshallTest()
        {
            var request = InstantiateClassGenerator.Execute<ListQueriesRequest>();
            var marshaller = new ListQueriesRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);
            Comparer.CompareObjectToJson<ListQueriesRequest>(request,jsonRequest);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            var jsonResponse = new JsonSampleGenerator(service_model, service_model.FindOperation("ListQueries").ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString());
            UnmarshallerContext context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), false, webResponse);
            var response = ListQueriesResponseUnmarshaller.Instance.Unmarshall(context) as ListQueriesResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void ListQueries_EventDataStoreARNInvalidExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("ListQueries");

            var request = InstantiateClassGenerator.Execute<ListQueriesRequest>();
            var marshaller = new ListQueriesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<ListQueriesRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("EventDataStoreARNInvalidException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","EventDataStoreARNInvalidException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = ListQueriesResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void ListQueries_EventDataStoreNotFoundExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("ListQueries");

            var request = InstantiateClassGenerator.Execute<ListQueriesRequest>();
            var marshaller = new ListQueriesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<ListQueriesRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("EventDataStoreNotFoundException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","EventDataStoreNotFoundException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = ListQueriesResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void ListQueries_InactiveEventDataStoreExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("ListQueries");

            var request = InstantiateClassGenerator.Execute<ListQueriesRequest>();
            var marshaller = new ListQueriesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<ListQueriesRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InactiveEventDataStoreException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","InactiveEventDataStoreException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = ListQueriesResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void ListQueries_InvalidDateRangeExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("ListQueries");

            var request = InstantiateClassGenerator.Execute<ListQueriesRequest>();
            var marshaller = new ListQueriesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<ListQueriesRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidDateRangeException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","InvalidDateRangeException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = ListQueriesResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void ListQueries_InvalidMaxResultsExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("ListQueries");

            var request = InstantiateClassGenerator.Execute<ListQueriesRequest>();
            var marshaller = new ListQueriesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<ListQueriesRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidMaxResultsException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","InvalidMaxResultsException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = ListQueriesResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void ListQueries_InvalidNextTokenExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("ListQueries");

            var request = InstantiateClassGenerator.Execute<ListQueriesRequest>();
            var marshaller = new ListQueriesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<ListQueriesRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidNextTokenException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","InvalidNextTokenException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = ListQueriesResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void ListQueries_InvalidParameterExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("ListQueries");

            var request = InstantiateClassGenerator.Execute<ListQueriesRequest>();
            var marshaller = new ListQueriesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<ListQueriesRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidParameterException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","InvalidParameterException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = ListQueriesResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void ListQueries_InvalidQueryStatusExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("ListQueries");

            var request = InstantiateClassGenerator.Execute<ListQueriesRequest>();
            var marshaller = new ListQueriesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<ListQueriesRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidQueryStatusException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","InvalidQueryStatusException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = ListQueriesResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void ListQueries_NoManagementAccountSLRExistsExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("ListQueries");

            var request = InstantiateClassGenerator.Execute<ListQueriesRequest>();
            var marshaller = new ListQueriesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<ListQueriesRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("NoManagementAccountSLRExistsException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","NoManagementAccountSLRExistsException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = ListQueriesResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void ListQueries_OperationNotPermittedExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("ListQueries");

            var request = InstantiateClassGenerator.Execute<ListQueriesRequest>();
            var marshaller = new ListQueriesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<ListQueriesRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("OperationNotPermittedException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","OperationNotPermittedException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = ListQueriesResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void ListQueries_UnsupportedOperationExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("ListQueries");

            var request = InstantiateClassGenerator.Execute<ListQueriesRequest>();
            var marshaller = new ListQueriesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<ListQueriesRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("UnsupportedOperationException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","UnsupportedOperationException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = ListQueriesResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void ListTagsMarshallTest()
        {
            var request = InstantiateClassGenerator.Execute<ListTagsRequest>();
            var marshaller = new ListTagsRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);
            Comparer.CompareObjectToJson<ListTagsRequest>(request,jsonRequest);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            var jsonResponse = new JsonSampleGenerator(service_model, service_model.FindOperation("ListTags").ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString());
            UnmarshallerContext context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), false, webResponse);
            var response = ListTagsResponseUnmarshaller.Instance.Unmarshall(context) as ListTagsResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void ListTags_CloudTrailARNInvalidExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("ListTags");

            var request = InstantiateClassGenerator.Execute<ListTagsRequest>();
            var marshaller = new ListTagsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<ListTagsRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("CloudTrailARNInvalidException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","CloudTrailARNInvalidException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = ListTagsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void ListTags_EventDataStoreNotFoundExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("ListTags");

            var request = InstantiateClassGenerator.Execute<ListTagsRequest>();
            var marshaller = new ListTagsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<ListTagsRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("EventDataStoreNotFoundException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","EventDataStoreNotFoundException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = ListTagsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void ListTags_InactiveEventDataStoreExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("ListTags");

            var request = InstantiateClassGenerator.Execute<ListTagsRequest>();
            var marshaller = new ListTagsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<ListTagsRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InactiveEventDataStoreException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","InactiveEventDataStoreException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = ListTagsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void ListTags_InvalidTokenExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("ListTags");

            var request = InstantiateClassGenerator.Execute<ListTagsRequest>();
            var marshaller = new ListTagsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<ListTagsRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidTokenException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","InvalidTokenException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = ListTagsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void ListTags_InvalidTrailNameExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("ListTags");

            var request = InstantiateClassGenerator.Execute<ListTagsRequest>();
            var marshaller = new ListTagsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<ListTagsRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidTrailNameException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","InvalidTrailNameException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = ListTagsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void ListTags_NoManagementAccountSLRExistsExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("ListTags");

            var request = InstantiateClassGenerator.Execute<ListTagsRequest>();
            var marshaller = new ListTagsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<ListTagsRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("NoManagementAccountSLRExistsException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","NoManagementAccountSLRExistsException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = ListTagsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void ListTags_OperationNotPermittedExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("ListTags");

            var request = InstantiateClassGenerator.Execute<ListTagsRequest>();
            var marshaller = new ListTagsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<ListTagsRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("OperationNotPermittedException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","OperationNotPermittedException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = ListTagsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void ListTags_ResourceNotFoundExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("ListTags");

            var request = InstantiateClassGenerator.Execute<ListTagsRequest>();
            var marshaller = new ListTagsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<ListTagsRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("ResourceNotFoundException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","ResourceNotFoundException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = ListTagsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void ListTags_ResourceTypeNotSupportedExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("ListTags");

            var request = InstantiateClassGenerator.Execute<ListTagsRequest>();
            var marshaller = new ListTagsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<ListTagsRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("ResourceTypeNotSupportedException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","ResourceTypeNotSupportedException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = ListTagsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void ListTags_UnsupportedOperationExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("ListTags");

            var request = InstantiateClassGenerator.Execute<ListTagsRequest>();
            var marshaller = new ListTagsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<ListTagsRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("UnsupportedOperationException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","UnsupportedOperationException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = ListTagsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void ListTrailsMarshallTest()
        {
            var request = InstantiateClassGenerator.Execute<ListTrailsRequest>();
            var marshaller = new ListTrailsRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);
            Comparer.CompareObjectToJson<ListTrailsRequest>(request,jsonRequest);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            var jsonResponse = new JsonSampleGenerator(service_model, service_model.FindOperation("ListTrails").ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString());
            UnmarshallerContext context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), false, webResponse);
            var response = ListTrailsResponseUnmarshaller.Instance.Unmarshall(context) as ListTrailsResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void ListTrails_OperationNotPermittedExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("ListTrails");

            var request = InstantiateClassGenerator.Execute<ListTrailsRequest>();
            var marshaller = new ListTrailsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<ListTrailsRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("OperationNotPermittedException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","OperationNotPermittedException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = ListTrailsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void ListTrails_UnsupportedOperationExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("ListTrails");

            var request = InstantiateClassGenerator.Execute<ListTrailsRequest>();
            var marshaller = new ListTrailsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<ListTrailsRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("UnsupportedOperationException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","UnsupportedOperationException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = ListTrailsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void LookupEventsMarshallTest()
        {
            var request = InstantiateClassGenerator.Execute<LookupEventsRequest>();
            var marshaller = new LookupEventsRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);
            Comparer.CompareObjectToJson<LookupEventsRequest>(request,jsonRequest);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            var jsonResponse = new JsonSampleGenerator(service_model, service_model.FindOperation("LookupEvents").ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString());
            UnmarshallerContext context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), false, webResponse);
            var response = LookupEventsResponseUnmarshaller.Instance.Unmarshall(context) as LookupEventsResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void LookupEvents_InvalidEventCategoryExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("LookupEvents");

            var request = InstantiateClassGenerator.Execute<LookupEventsRequest>();
            var marshaller = new LookupEventsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<LookupEventsRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidEventCategoryException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","InvalidEventCategoryException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = LookupEventsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void LookupEvents_InvalidLookupAttributesExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("LookupEvents");

            var request = InstantiateClassGenerator.Execute<LookupEventsRequest>();
            var marshaller = new LookupEventsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<LookupEventsRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidLookupAttributesException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","InvalidLookupAttributesException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = LookupEventsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void LookupEvents_InvalidMaxResultsExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("LookupEvents");

            var request = InstantiateClassGenerator.Execute<LookupEventsRequest>();
            var marshaller = new LookupEventsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<LookupEventsRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidMaxResultsException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","InvalidMaxResultsException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = LookupEventsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void LookupEvents_InvalidNextTokenExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("LookupEvents");

            var request = InstantiateClassGenerator.Execute<LookupEventsRequest>();
            var marshaller = new LookupEventsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<LookupEventsRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidNextTokenException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","InvalidNextTokenException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = LookupEventsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void LookupEvents_InvalidTimeRangeExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("LookupEvents");

            var request = InstantiateClassGenerator.Execute<LookupEventsRequest>();
            var marshaller = new LookupEventsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<LookupEventsRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidTimeRangeException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","InvalidTimeRangeException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = LookupEventsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void LookupEvents_OperationNotPermittedExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("LookupEvents");

            var request = InstantiateClassGenerator.Execute<LookupEventsRequest>();
            var marshaller = new LookupEventsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<LookupEventsRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("OperationNotPermittedException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","OperationNotPermittedException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = LookupEventsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void LookupEvents_UnsupportedOperationExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("LookupEvents");

            var request = InstantiateClassGenerator.Execute<LookupEventsRequest>();
            var marshaller = new LookupEventsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<LookupEventsRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("UnsupportedOperationException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","UnsupportedOperationException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = LookupEventsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void PutEventSelectorsMarshallTest()
        {
            var request = InstantiateClassGenerator.Execute<PutEventSelectorsRequest>();
            var marshaller = new PutEventSelectorsRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);
            Comparer.CompareObjectToJson<PutEventSelectorsRequest>(request,jsonRequest);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            var jsonResponse = new JsonSampleGenerator(service_model, service_model.FindOperation("PutEventSelectors").ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString());
            UnmarshallerContext context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), false, webResponse);
            var response = PutEventSelectorsResponseUnmarshaller.Instance.Unmarshall(context) as PutEventSelectorsResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void PutEventSelectors_CloudTrailARNInvalidExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("PutEventSelectors");

            var request = InstantiateClassGenerator.Execute<PutEventSelectorsRequest>();
            var marshaller = new PutEventSelectorsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<PutEventSelectorsRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("CloudTrailARNInvalidException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","CloudTrailARNInvalidException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = PutEventSelectorsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void PutEventSelectors_InsufficientDependencyServiceAccessPermissionExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("PutEventSelectors");

            var request = InstantiateClassGenerator.Execute<PutEventSelectorsRequest>();
            var marshaller = new PutEventSelectorsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<PutEventSelectorsRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InsufficientDependencyServiceAccessPermissionException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","InsufficientDependencyServiceAccessPermissionException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = PutEventSelectorsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void PutEventSelectors_InvalidEventSelectorsExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("PutEventSelectors");

            var request = InstantiateClassGenerator.Execute<PutEventSelectorsRequest>();
            var marshaller = new PutEventSelectorsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<PutEventSelectorsRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidEventSelectorsException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","InvalidEventSelectorsException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = PutEventSelectorsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void PutEventSelectors_InvalidHomeRegionExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("PutEventSelectors");

            var request = InstantiateClassGenerator.Execute<PutEventSelectorsRequest>();
            var marshaller = new PutEventSelectorsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<PutEventSelectorsRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidHomeRegionException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","InvalidHomeRegionException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = PutEventSelectorsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void PutEventSelectors_InvalidTrailNameExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("PutEventSelectors");

            var request = InstantiateClassGenerator.Execute<PutEventSelectorsRequest>();
            var marshaller = new PutEventSelectorsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<PutEventSelectorsRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidTrailNameException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","InvalidTrailNameException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = PutEventSelectorsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void PutEventSelectors_NoManagementAccountSLRExistsExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("PutEventSelectors");

            var request = InstantiateClassGenerator.Execute<PutEventSelectorsRequest>();
            var marshaller = new PutEventSelectorsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<PutEventSelectorsRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("NoManagementAccountSLRExistsException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","NoManagementAccountSLRExistsException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = PutEventSelectorsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void PutEventSelectors_NotOrganizationMasterAccountExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("PutEventSelectors");

            var request = InstantiateClassGenerator.Execute<PutEventSelectorsRequest>();
            var marshaller = new PutEventSelectorsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<PutEventSelectorsRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("NotOrganizationMasterAccountException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","NotOrganizationMasterAccountException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = PutEventSelectorsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void PutEventSelectors_OperationNotPermittedExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("PutEventSelectors");

            var request = InstantiateClassGenerator.Execute<PutEventSelectorsRequest>();
            var marshaller = new PutEventSelectorsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<PutEventSelectorsRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("OperationNotPermittedException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","OperationNotPermittedException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = PutEventSelectorsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void PutEventSelectors_TrailNotFoundExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("PutEventSelectors");

            var request = InstantiateClassGenerator.Execute<PutEventSelectorsRequest>();
            var marshaller = new PutEventSelectorsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<PutEventSelectorsRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("TrailNotFoundException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","TrailNotFoundException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = PutEventSelectorsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void PutEventSelectors_UnsupportedOperationExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("PutEventSelectors");

            var request = InstantiateClassGenerator.Execute<PutEventSelectorsRequest>();
            var marshaller = new PutEventSelectorsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<PutEventSelectorsRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("UnsupportedOperationException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","UnsupportedOperationException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = PutEventSelectorsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void PutInsightSelectorsMarshallTest()
        {
            var request = InstantiateClassGenerator.Execute<PutInsightSelectorsRequest>();
            var marshaller = new PutInsightSelectorsRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);
            Comparer.CompareObjectToJson<PutInsightSelectorsRequest>(request,jsonRequest);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            var jsonResponse = new JsonSampleGenerator(service_model, service_model.FindOperation("PutInsightSelectors").ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString());
            UnmarshallerContext context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), false, webResponse);
            var response = PutInsightSelectorsResponseUnmarshaller.Instance.Unmarshall(context) as PutInsightSelectorsResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void PutInsightSelectors_CloudTrailARNInvalidExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("PutInsightSelectors");

            var request = InstantiateClassGenerator.Execute<PutInsightSelectorsRequest>();
            var marshaller = new PutInsightSelectorsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<PutInsightSelectorsRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("CloudTrailARNInvalidException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","CloudTrailARNInvalidException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = PutInsightSelectorsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void PutInsightSelectors_InsufficientEncryptionPolicyExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("PutInsightSelectors");

            var request = InstantiateClassGenerator.Execute<PutInsightSelectorsRequest>();
            var marshaller = new PutInsightSelectorsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<PutInsightSelectorsRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InsufficientEncryptionPolicyException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","InsufficientEncryptionPolicyException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = PutInsightSelectorsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void PutInsightSelectors_InsufficientS3BucketPolicyExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("PutInsightSelectors");

            var request = InstantiateClassGenerator.Execute<PutInsightSelectorsRequest>();
            var marshaller = new PutInsightSelectorsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<PutInsightSelectorsRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InsufficientS3BucketPolicyException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","InsufficientS3BucketPolicyException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = PutInsightSelectorsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void PutInsightSelectors_InvalidHomeRegionExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("PutInsightSelectors");

            var request = InstantiateClassGenerator.Execute<PutInsightSelectorsRequest>();
            var marshaller = new PutInsightSelectorsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<PutInsightSelectorsRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidHomeRegionException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","InvalidHomeRegionException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = PutInsightSelectorsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void PutInsightSelectors_InvalidInsightSelectorsExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("PutInsightSelectors");

            var request = InstantiateClassGenerator.Execute<PutInsightSelectorsRequest>();
            var marshaller = new PutInsightSelectorsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<PutInsightSelectorsRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidInsightSelectorsException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","InvalidInsightSelectorsException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = PutInsightSelectorsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void PutInsightSelectors_InvalidTrailNameExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("PutInsightSelectors");

            var request = InstantiateClassGenerator.Execute<PutInsightSelectorsRequest>();
            var marshaller = new PutInsightSelectorsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<PutInsightSelectorsRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidTrailNameException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","InvalidTrailNameException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = PutInsightSelectorsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void PutInsightSelectors_KmsExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("PutInsightSelectors");

            var request = InstantiateClassGenerator.Execute<PutInsightSelectorsRequest>();
            var marshaller = new PutInsightSelectorsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<PutInsightSelectorsRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("KmsException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","KmsException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = PutInsightSelectorsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void PutInsightSelectors_NoManagementAccountSLRExistsExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("PutInsightSelectors");

            var request = InstantiateClassGenerator.Execute<PutInsightSelectorsRequest>();
            var marshaller = new PutInsightSelectorsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<PutInsightSelectorsRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("NoManagementAccountSLRExistsException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","NoManagementAccountSLRExistsException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = PutInsightSelectorsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void PutInsightSelectors_NotOrganizationMasterAccountExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("PutInsightSelectors");

            var request = InstantiateClassGenerator.Execute<PutInsightSelectorsRequest>();
            var marshaller = new PutInsightSelectorsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<PutInsightSelectorsRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("NotOrganizationMasterAccountException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","NotOrganizationMasterAccountException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = PutInsightSelectorsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void PutInsightSelectors_OperationNotPermittedExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("PutInsightSelectors");

            var request = InstantiateClassGenerator.Execute<PutInsightSelectorsRequest>();
            var marshaller = new PutInsightSelectorsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<PutInsightSelectorsRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("OperationNotPermittedException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","OperationNotPermittedException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = PutInsightSelectorsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void PutInsightSelectors_S3BucketDoesNotExistExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("PutInsightSelectors");

            var request = InstantiateClassGenerator.Execute<PutInsightSelectorsRequest>();
            var marshaller = new PutInsightSelectorsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<PutInsightSelectorsRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("S3BucketDoesNotExistException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","S3BucketDoesNotExistException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = PutInsightSelectorsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void PutInsightSelectors_TrailNotFoundExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("PutInsightSelectors");

            var request = InstantiateClassGenerator.Execute<PutInsightSelectorsRequest>();
            var marshaller = new PutInsightSelectorsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<PutInsightSelectorsRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("TrailNotFoundException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","TrailNotFoundException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = PutInsightSelectorsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void PutInsightSelectors_UnsupportedOperationExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("PutInsightSelectors");

            var request = InstantiateClassGenerator.Execute<PutInsightSelectorsRequest>();
            var marshaller = new PutInsightSelectorsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<PutInsightSelectorsRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("UnsupportedOperationException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","UnsupportedOperationException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = PutInsightSelectorsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void PutResourcePolicyMarshallTest()
        {
            var request = InstantiateClassGenerator.Execute<PutResourcePolicyRequest>();
            var marshaller = new PutResourcePolicyRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);
            Comparer.CompareObjectToJson<PutResourcePolicyRequest>(request,jsonRequest);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            var jsonResponse = new JsonSampleGenerator(service_model, service_model.FindOperation("PutResourcePolicy").ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString());
            UnmarshallerContext context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), false, webResponse);
            var response = PutResourcePolicyResponseUnmarshaller.Instance.Unmarshall(context) as PutResourcePolicyResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void PutResourcePolicy_OperationNotPermittedExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("PutResourcePolicy");

            var request = InstantiateClassGenerator.Execute<PutResourcePolicyRequest>();
            var marshaller = new PutResourcePolicyRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<PutResourcePolicyRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("OperationNotPermittedException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","OperationNotPermittedException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = PutResourcePolicyResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void PutResourcePolicy_ResourceARNNotValidExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("PutResourcePolicy");

            var request = InstantiateClassGenerator.Execute<PutResourcePolicyRequest>();
            var marshaller = new PutResourcePolicyRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<PutResourcePolicyRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("ResourceARNNotValidException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","ResourceARNNotValidException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = PutResourcePolicyResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void PutResourcePolicy_ResourceNotFoundExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("PutResourcePolicy");

            var request = InstantiateClassGenerator.Execute<PutResourcePolicyRequest>();
            var marshaller = new PutResourcePolicyRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<PutResourcePolicyRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("ResourceNotFoundException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","ResourceNotFoundException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = PutResourcePolicyResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void PutResourcePolicy_ResourcePolicyNotValidExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("PutResourcePolicy");

            var request = InstantiateClassGenerator.Execute<PutResourcePolicyRequest>();
            var marshaller = new PutResourcePolicyRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<PutResourcePolicyRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("ResourcePolicyNotValidException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","ResourcePolicyNotValidException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = PutResourcePolicyResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void PutResourcePolicy_ResourceTypeNotSupportedExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("PutResourcePolicy");

            var request = InstantiateClassGenerator.Execute<PutResourcePolicyRequest>();
            var marshaller = new PutResourcePolicyRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<PutResourcePolicyRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("ResourceTypeNotSupportedException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","ResourceTypeNotSupportedException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = PutResourcePolicyResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void PutResourcePolicy_UnsupportedOperationExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("PutResourcePolicy");

            var request = InstantiateClassGenerator.Execute<PutResourcePolicyRequest>();
            var marshaller = new PutResourcePolicyRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<PutResourcePolicyRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("UnsupportedOperationException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","UnsupportedOperationException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = PutResourcePolicyResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void RegisterOrganizationDelegatedAdminMarshallTest()
        {
            var request = InstantiateClassGenerator.Execute<RegisterOrganizationDelegatedAdminRequest>();
            var marshaller = new RegisterOrganizationDelegatedAdminRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);
            Comparer.CompareObjectToJson<RegisterOrganizationDelegatedAdminRequest>(request,jsonRequest);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            var jsonResponse = new JsonSampleGenerator(service_model, service_model.FindOperation("RegisterOrganizationDelegatedAdmin").ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString());
            UnmarshallerContext context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), false, webResponse);
            var response = RegisterOrganizationDelegatedAdminResponseUnmarshaller.Instance.Unmarshall(context) as RegisterOrganizationDelegatedAdminResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void RegisterOrganizationDelegatedAdmin_AccountNotFoundExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("RegisterOrganizationDelegatedAdmin");

            var request = InstantiateClassGenerator.Execute<RegisterOrganizationDelegatedAdminRequest>();
            var marshaller = new RegisterOrganizationDelegatedAdminRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<RegisterOrganizationDelegatedAdminRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("AccountNotFoundException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","AccountNotFoundException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = RegisterOrganizationDelegatedAdminResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void RegisterOrganizationDelegatedAdmin_AccountRegisteredExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("RegisterOrganizationDelegatedAdmin");

            var request = InstantiateClassGenerator.Execute<RegisterOrganizationDelegatedAdminRequest>();
            var marshaller = new RegisterOrganizationDelegatedAdminRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<RegisterOrganizationDelegatedAdminRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("AccountRegisteredException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","AccountRegisteredException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = RegisterOrganizationDelegatedAdminResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void RegisterOrganizationDelegatedAdmin_CannotDelegateManagementAccountExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("RegisterOrganizationDelegatedAdmin");

            var request = InstantiateClassGenerator.Execute<RegisterOrganizationDelegatedAdminRequest>();
            var marshaller = new RegisterOrganizationDelegatedAdminRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<RegisterOrganizationDelegatedAdminRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("CannotDelegateManagementAccountException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","CannotDelegateManagementAccountException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = RegisterOrganizationDelegatedAdminResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void RegisterOrganizationDelegatedAdmin_CloudTrailAccessNotEnabledExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("RegisterOrganizationDelegatedAdmin");

            var request = InstantiateClassGenerator.Execute<RegisterOrganizationDelegatedAdminRequest>();
            var marshaller = new RegisterOrganizationDelegatedAdminRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<RegisterOrganizationDelegatedAdminRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("CloudTrailAccessNotEnabledException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","CloudTrailAccessNotEnabledException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = RegisterOrganizationDelegatedAdminResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void RegisterOrganizationDelegatedAdmin_ConflictExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("RegisterOrganizationDelegatedAdmin");

            var request = InstantiateClassGenerator.Execute<RegisterOrganizationDelegatedAdminRequest>();
            var marshaller = new RegisterOrganizationDelegatedAdminRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<RegisterOrganizationDelegatedAdminRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("ConflictException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","ConflictException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = RegisterOrganizationDelegatedAdminResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void RegisterOrganizationDelegatedAdmin_DelegatedAdminAccountLimitExceededExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("RegisterOrganizationDelegatedAdmin");

            var request = InstantiateClassGenerator.Execute<RegisterOrganizationDelegatedAdminRequest>();
            var marshaller = new RegisterOrganizationDelegatedAdminRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<RegisterOrganizationDelegatedAdminRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("DelegatedAdminAccountLimitExceededException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","DelegatedAdminAccountLimitExceededException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = RegisterOrganizationDelegatedAdminResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void RegisterOrganizationDelegatedAdmin_InsufficientDependencyServiceAccessPermissionExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("RegisterOrganizationDelegatedAdmin");

            var request = InstantiateClassGenerator.Execute<RegisterOrganizationDelegatedAdminRequest>();
            var marshaller = new RegisterOrganizationDelegatedAdminRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<RegisterOrganizationDelegatedAdminRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InsufficientDependencyServiceAccessPermissionException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","InsufficientDependencyServiceAccessPermissionException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = RegisterOrganizationDelegatedAdminResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void RegisterOrganizationDelegatedAdmin_InvalidParameterExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("RegisterOrganizationDelegatedAdmin");

            var request = InstantiateClassGenerator.Execute<RegisterOrganizationDelegatedAdminRequest>();
            var marshaller = new RegisterOrganizationDelegatedAdminRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<RegisterOrganizationDelegatedAdminRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidParameterException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","InvalidParameterException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = RegisterOrganizationDelegatedAdminResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void RegisterOrganizationDelegatedAdmin_NotOrganizationManagementAccountExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("RegisterOrganizationDelegatedAdmin");

            var request = InstantiateClassGenerator.Execute<RegisterOrganizationDelegatedAdminRequest>();
            var marshaller = new RegisterOrganizationDelegatedAdminRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<RegisterOrganizationDelegatedAdminRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("NotOrganizationManagementAccountException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","NotOrganizationManagementAccountException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = RegisterOrganizationDelegatedAdminResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void RegisterOrganizationDelegatedAdmin_OperationNotPermittedExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("RegisterOrganizationDelegatedAdmin");

            var request = InstantiateClassGenerator.Execute<RegisterOrganizationDelegatedAdminRequest>();
            var marshaller = new RegisterOrganizationDelegatedAdminRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<RegisterOrganizationDelegatedAdminRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("OperationNotPermittedException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","OperationNotPermittedException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = RegisterOrganizationDelegatedAdminResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void RegisterOrganizationDelegatedAdmin_OrganizationNotInAllFeaturesModeExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("RegisterOrganizationDelegatedAdmin");

            var request = InstantiateClassGenerator.Execute<RegisterOrganizationDelegatedAdminRequest>();
            var marshaller = new RegisterOrganizationDelegatedAdminRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<RegisterOrganizationDelegatedAdminRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("OrganizationNotInAllFeaturesModeException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","OrganizationNotInAllFeaturesModeException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = RegisterOrganizationDelegatedAdminResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void RegisterOrganizationDelegatedAdmin_OrganizationsNotInUseExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("RegisterOrganizationDelegatedAdmin");

            var request = InstantiateClassGenerator.Execute<RegisterOrganizationDelegatedAdminRequest>();
            var marshaller = new RegisterOrganizationDelegatedAdminRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<RegisterOrganizationDelegatedAdminRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("OrganizationsNotInUseException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","OrganizationsNotInUseException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = RegisterOrganizationDelegatedAdminResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void RegisterOrganizationDelegatedAdmin_UnsupportedOperationExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("RegisterOrganizationDelegatedAdmin");

            var request = InstantiateClassGenerator.Execute<RegisterOrganizationDelegatedAdminRequest>();
            var marshaller = new RegisterOrganizationDelegatedAdminRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<RegisterOrganizationDelegatedAdminRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("UnsupportedOperationException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","UnsupportedOperationException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = RegisterOrganizationDelegatedAdminResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void RemoveTagsMarshallTest()
        {
            var request = InstantiateClassGenerator.Execute<RemoveTagsRequest>();
            var marshaller = new RemoveTagsRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);
            Comparer.CompareObjectToJson<RemoveTagsRequest>(request,jsonRequest);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            var jsonResponse = new JsonSampleGenerator(service_model, service_model.FindOperation("RemoveTags").ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString());
            UnmarshallerContext context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), false, webResponse);
            var response = RemoveTagsResponseUnmarshaller.Instance.Unmarshall(context) as RemoveTagsResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void RemoveTags_ChannelNotFoundExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("RemoveTags");

            var request = InstantiateClassGenerator.Execute<RemoveTagsRequest>();
            var marshaller = new RemoveTagsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<RemoveTagsRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("ChannelNotFoundException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","ChannelNotFoundException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = RemoveTagsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void RemoveTags_CloudTrailARNInvalidExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("RemoveTags");

            var request = InstantiateClassGenerator.Execute<RemoveTagsRequest>();
            var marshaller = new RemoveTagsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<RemoveTagsRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("CloudTrailARNInvalidException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","CloudTrailARNInvalidException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = RemoveTagsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void RemoveTags_EventDataStoreNotFoundExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("RemoveTags");

            var request = InstantiateClassGenerator.Execute<RemoveTagsRequest>();
            var marshaller = new RemoveTagsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<RemoveTagsRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("EventDataStoreNotFoundException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","EventDataStoreNotFoundException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = RemoveTagsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void RemoveTags_InactiveEventDataStoreExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("RemoveTags");

            var request = InstantiateClassGenerator.Execute<RemoveTagsRequest>();
            var marshaller = new RemoveTagsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<RemoveTagsRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InactiveEventDataStoreException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","InactiveEventDataStoreException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = RemoveTagsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void RemoveTags_InvalidTagParameterExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("RemoveTags");

            var request = InstantiateClassGenerator.Execute<RemoveTagsRequest>();
            var marshaller = new RemoveTagsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<RemoveTagsRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidTagParameterException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","InvalidTagParameterException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = RemoveTagsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void RemoveTags_InvalidTrailNameExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("RemoveTags");

            var request = InstantiateClassGenerator.Execute<RemoveTagsRequest>();
            var marshaller = new RemoveTagsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<RemoveTagsRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidTrailNameException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","InvalidTrailNameException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = RemoveTagsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void RemoveTags_NoManagementAccountSLRExistsExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("RemoveTags");

            var request = InstantiateClassGenerator.Execute<RemoveTagsRequest>();
            var marshaller = new RemoveTagsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<RemoveTagsRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("NoManagementAccountSLRExistsException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","NoManagementAccountSLRExistsException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = RemoveTagsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void RemoveTags_NotOrganizationMasterAccountExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("RemoveTags");

            var request = InstantiateClassGenerator.Execute<RemoveTagsRequest>();
            var marshaller = new RemoveTagsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<RemoveTagsRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("NotOrganizationMasterAccountException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","NotOrganizationMasterAccountException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = RemoveTagsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void RemoveTags_OperationNotPermittedExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("RemoveTags");

            var request = InstantiateClassGenerator.Execute<RemoveTagsRequest>();
            var marshaller = new RemoveTagsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<RemoveTagsRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("OperationNotPermittedException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","OperationNotPermittedException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = RemoveTagsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void RemoveTags_ResourceNotFoundExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("RemoveTags");

            var request = InstantiateClassGenerator.Execute<RemoveTagsRequest>();
            var marshaller = new RemoveTagsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<RemoveTagsRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("ResourceNotFoundException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","ResourceNotFoundException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = RemoveTagsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void RemoveTags_ResourceTypeNotSupportedExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("RemoveTags");

            var request = InstantiateClassGenerator.Execute<RemoveTagsRequest>();
            var marshaller = new RemoveTagsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<RemoveTagsRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("ResourceTypeNotSupportedException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","ResourceTypeNotSupportedException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = RemoveTagsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void RemoveTags_UnsupportedOperationExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("RemoveTags");

            var request = InstantiateClassGenerator.Execute<RemoveTagsRequest>();
            var marshaller = new RemoveTagsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<RemoveTagsRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("UnsupportedOperationException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","UnsupportedOperationException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = RemoveTagsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void RestoreEventDataStoreMarshallTest()
        {
            var request = InstantiateClassGenerator.Execute<RestoreEventDataStoreRequest>();
            var marshaller = new RestoreEventDataStoreRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);
            Comparer.CompareObjectToJson<RestoreEventDataStoreRequest>(request,jsonRequest);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            var jsonResponse = new JsonSampleGenerator(service_model, service_model.FindOperation("RestoreEventDataStore").ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString());
            UnmarshallerContext context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), false, webResponse);
            var response = RestoreEventDataStoreResponseUnmarshaller.Instance.Unmarshall(context) as RestoreEventDataStoreResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void RestoreEventDataStore_CloudTrailAccessNotEnabledExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("RestoreEventDataStore");

            var request = InstantiateClassGenerator.Execute<RestoreEventDataStoreRequest>();
            var marshaller = new RestoreEventDataStoreRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<RestoreEventDataStoreRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("CloudTrailAccessNotEnabledException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","CloudTrailAccessNotEnabledException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = RestoreEventDataStoreResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void RestoreEventDataStore_EventDataStoreARNInvalidExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("RestoreEventDataStore");

            var request = InstantiateClassGenerator.Execute<RestoreEventDataStoreRequest>();
            var marshaller = new RestoreEventDataStoreRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<RestoreEventDataStoreRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("EventDataStoreARNInvalidException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","EventDataStoreARNInvalidException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = RestoreEventDataStoreResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void RestoreEventDataStore_EventDataStoreMaxLimitExceededExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("RestoreEventDataStore");

            var request = InstantiateClassGenerator.Execute<RestoreEventDataStoreRequest>();
            var marshaller = new RestoreEventDataStoreRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<RestoreEventDataStoreRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("EventDataStoreMaxLimitExceededException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","EventDataStoreMaxLimitExceededException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = RestoreEventDataStoreResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void RestoreEventDataStore_EventDataStoreNotFoundExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("RestoreEventDataStore");

            var request = InstantiateClassGenerator.Execute<RestoreEventDataStoreRequest>();
            var marshaller = new RestoreEventDataStoreRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<RestoreEventDataStoreRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("EventDataStoreNotFoundException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","EventDataStoreNotFoundException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = RestoreEventDataStoreResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void RestoreEventDataStore_InsufficientDependencyServiceAccessPermissionExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("RestoreEventDataStore");

            var request = InstantiateClassGenerator.Execute<RestoreEventDataStoreRequest>();
            var marshaller = new RestoreEventDataStoreRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<RestoreEventDataStoreRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InsufficientDependencyServiceAccessPermissionException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","InsufficientDependencyServiceAccessPermissionException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = RestoreEventDataStoreResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void RestoreEventDataStore_InvalidEventDataStoreStatusExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("RestoreEventDataStore");

            var request = InstantiateClassGenerator.Execute<RestoreEventDataStoreRequest>();
            var marshaller = new RestoreEventDataStoreRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<RestoreEventDataStoreRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidEventDataStoreStatusException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","InvalidEventDataStoreStatusException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = RestoreEventDataStoreResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void RestoreEventDataStore_InvalidParameterExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("RestoreEventDataStore");

            var request = InstantiateClassGenerator.Execute<RestoreEventDataStoreRequest>();
            var marshaller = new RestoreEventDataStoreRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<RestoreEventDataStoreRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidParameterException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","InvalidParameterException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = RestoreEventDataStoreResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void RestoreEventDataStore_NoManagementAccountSLRExistsExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("RestoreEventDataStore");

            var request = InstantiateClassGenerator.Execute<RestoreEventDataStoreRequest>();
            var marshaller = new RestoreEventDataStoreRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<RestoreEventDataStoreRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("NoManagementAccountSLRExistsException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","NoManagementAccountSLRExistsException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = RestoreEventDataStoreResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void RestoreEventDataStore_NotOrganizationMasterAccountExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("RestoreEventDataStore");

            var request = InstantiateClassGenerator.Execute<RestoreEventDataStoreRequest>();
            var marshaller = new RestoreEventDataStoreRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<RestoreEventDataStoreRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("NotOrganizationMasterAccountException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","NotOrganizationMasterAccountException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = RestoreEventDataStoreResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void RestoreEventDataStore_OperationNotPermittedExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("RestoreEventDataStore");

            var request = InstantiateClassGenerator.Execute<RestoreEventDataStoreRequest>();
            var marshaller = new RestoreEventDataStoreRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<RestoreEventDataStoreRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("OperationNotPermittedException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","OperationNotPermittedException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = RestoreEventDataStoreResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void RestoreEventDataStore_OrganizationNotInAllFeaturesModeExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("RestoreEventDataStore");

            var request = InstantiateClassGenerator.Execute<RestoreEventDataStoreRequest>();
            var marshaller = new RestoreEventDataStoreRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<RestoreEventDataStoreRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("OrganizationNotInAllFeaturesModeException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","OrganizationNotInAllFeaturesModeException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = RestoreEventDataStoreResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void RestoreEventDataStore_OrganizationsNotInUseExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("RestoreEventDataStore");

            var request = InstantiateClassGenerator.Execute<RestoreEventDataStoreRequest>();
            var marshaller = new RestoreEventDataStoreRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<RestoreEventDataStoreRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("OrganizationsNotInUseException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","OrganizationsNotInUseException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = RestoreEventDataStoreResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void RestoreEventDataStore_UnsupportedOperationExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("RestoreEventDataStore");

            var request = InstantiateClassGenerator.Execute<RestoreEventDataStoreRequest>();
            var marshaller = new RestoreEventDataStoreRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<RestoreEventDataStoreRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("UnsupportedOperationException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","UnsupportedOperationException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = RestoreEventDataStoreResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void StartImportMarshallTest()
        {
            var request = InstantiateClassGenerator.Execute<StartImportRequest>();
            var marshaller = new StartImportRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);
            Comparer.CompareObjectToJson<StartImportRequest>(request,jsonRequest);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            var jsonResponse = new JsonSampleGenerator(service_model, service_model.FindOperation("StartImport").ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString());
            UnmarshallerContext context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), false, webResponse);
            var response = StartImportResponseUnmarshaller.Instance.Unmarshall(context) as StartImportResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void StartImport_AccountHasOngoingImportExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("StartImport");

            var request = InstantiateClassGenerator.Execute<StartImportRequest>();
            var marshaller = new StartImportRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<StartImportRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("AccountHasOngoingImportException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","AccountHasOngoingImportException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = StartImportResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void StartImport_EventDataStoreARNInvalidExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("StartImport");

            var request = InstantiateClassGenerator.Execute<StartImportRequest>();
            var marshaller = new StartImportRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<StartImportRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("EventDataStoreARNInvalidException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","EventDataStoreARNInvalidException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = StartImportResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void StartImport_EventDataStoreNotFoundExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("StartImport");

            var request = InstantiateClassGenerator.Execute<StartImportRequest>();
            var marshaller = new StartImportRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<StartImportRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("EventDataStoreNotFoundException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","EventDataStoreNotFoundException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = StartImportResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void StartImport_ImportNotFoundExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("StartImport");

            var request = InstantiateClassGenerator.Execute<StartImportRequest>();
            var marshaller = new StartImportRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<StartImportRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("ImportNotFoundException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","ImportNotFoundException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = StartImportResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void StartImport_InactiveEventDataStoreExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("StartImport");

            var request = InstantiateClassGenerator.Execute<StartImportRequest>();
            var marshaller = new StartImportRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<StartImportRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InactiveEventDataStoreException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","InactiveEventDataStoreException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = StartImportResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void StartImport_InvalidEventDataStoreCategoryExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("StartImport");

            var request = InstantiateClassGenerator.Execute<StartImportRequest>();
            var marshaller = new StartImportRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<StartImportRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidEventDataStoreCategoryException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","InvalidEventDataStoreCategoryException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = StartImportResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void StartImport_InvalidEventDataStoreStatusExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("StartImport");

            var request = InstantiateClassGenerator.Execute<StartImportRequest>();
            var marshaller = new StartImportRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<StartImportRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidEventDataStoreStatusException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","InvalidEventDataStoreStatusException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = StartImportResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void StartImport_InvalidImportSourceExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("StartImport");

            var request = InstantiateClassGenerator.Execute<StartImportRequest>();
            var marshaller = new StartImportRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<StartImportRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidImportSourceException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","InvalidImportSourceException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = StartImportResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void StartImport_InvalidParameterExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("StartImport");

            var request = InstantiateClassGenerator.Execute<StartImportRequest>();
            var marshaller = new StartImportRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<StartImportRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidParameterException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","InvalidParameterException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = StartImportResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void StartImport_OperationNotPermittedExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("StartImport");

            var request = InstantiateClassGenerator.Execute<StartImportRequest>();
            var marshaller = new StartImportRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<StartImportRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("OperationNotPermittedException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","OperationNotPermittedException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = StartImportResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void StartImport_UnsupportedOperationExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("StartImport");

            var request = InstantiateClassGenerator.Execute<StartImportRequest>();
            var marshaller = new StartImportRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<StartImportRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("UnsupportedOperationException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","UnsupportedOperationException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = StartImportResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void StartLoggingMarshallTest()
        {
            var request = InstantiateClassGenerator.Execute<StartLoggingRequest>();
            var marshaller = new StartLoggingRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);
            Comparer.CompareObjectToJson<StartLoggingRequest>(request,jsonRequest);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            var jsonResponse = new JsonSampleGenerator(service_model, service_model.FindOperation("StartLogging").ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString());
            UnmarshallerContext context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), false, webResponse);
            var response = StartLoggingResponseUnmarshaller.Instance.Unmarshall(context) as StartLoggingResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void StartLogging_CloudTrailARNInvalidExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("StartLogging");

            var request = InstantiateClassGenerator.Execute<StartLoggingRequest>();
            var marshaller = new StartLoggingRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<StartLoggingRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("CloudTrailARNInvalidException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","CloudTrailARNInvalidException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = StartLoggingResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void StartLogging_ConflictExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("StartLogging");

            var request = InstantiateClassGenerator.Execute<StartLoggingRequest>();
            var marshaller = new StartLoggingRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<StartLoggingRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("ConflictException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","ConflictException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = StartLoggingResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void StartLogging_InsufficientDependencyServiceAccessPermissionExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("StartLogging");

            var request = InstantiateClassGenerator.Execute<StartLoggingRequest>();
            var marshaller = new StartLoggingRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<StartLoggingRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InsufficientDependencyServiceAccessPermissionException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","InsufficientDependencyServiceAccessPermissionException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = StartLoggingResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void StartLogging_InvalidHomeRegionExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("StartLogging");

            var request = InstantiateClassGenerator.Execute<StartLoggingRequest>();
            var marshaller = new StartLoggingRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<StartLoggingRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidHomeRegionException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","InvalidHomeRegionException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = StartLoggingResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void StartLogging_InvalidTrailNameExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("StartLogging");

            var request = InstantiateClassGenerator.Execute<StartLoggingRequest>();
            var marshaller = new StartLoggingRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<StartLoggingRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidTrailNameException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","InvalidTrailNameException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = StartLoggingResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void StartLogging_NoManagementAccountSLRExistsExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("StartLogging");

            var request = InstantiateClassGenerator.Execute<StartLoggingRequest>();
            var marshaller = new StartLoggingRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<StartLoggingRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("NoManagementAccountSLRExistsException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","NoManagementAccountSLRExistsException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = StartLoggingResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void StartLogging_NotOrganizationMasterAccountExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("StartLogging");

            var request = InstantiateClassGenerator.Execute<StartLoggingRequest>();
            var marshaller = new StartLoggingRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<StartLoggingRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("NotOrganizationMasterAccountException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","NotOrganizationMasterAccountException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = StartLoggingResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void StartLogging_OperationNotPermittedExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("StartLogging");

            var request = InstantiateClassGenerator.Execute<StartLoggingRequest>();
            var marshaller = new StartLoggingRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<StartLoggingRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("OperationNotPermittedException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","OperationNotPermittedException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = StartLoggingResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void StartLogging_TrailNotFoundExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("StartLogging");

            var request = InstantiateClassGenerator.Execute<StartLoggingRequest>();
            var marshaller = new StartLoggingRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<StartLoggingRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("TrailNotFoundException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","TrailNotFoundException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = StartLoggingResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void StartLogging_UnsupportedOperationExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("StartLogging");

            var request = InstantiateClassGenerator.Execute<StartLoggingRequest>();
            var marshaller = new StartLoggingRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<StartLoggingRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("UnsupportedOperationException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","UnsupportedOperationException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = StartLoggingResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void StartQueryMarshallTest()
        {
            var request = InstantiateClassGenerator.Execute<StartQueryRequest>();
            var marshaller = new StartQueryRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);
            Comparer.CompareObjectToJson<StartQueryRequest>(request,jsonRequest);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            var jsonResponse = new JsonSampleGenerator(service_model, service_model.FindOperation("StartQuery").ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString());
            UnmarshallerContext context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), false, webResponse);
            var response = StartQueryResponseUnmarshaller.Instance.Unmarshall(context) as StartQueryResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void StartQuery_EventDataStoreARNInvalidExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("StartQuery");

            var request = InstantiateClassGenerator.Execute<StartQueryRequest>();
            var marshaller = new StartQueryRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<StartQueryRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("EventDataStoreARNInvalidException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","EventDataStoreARNInvalidException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = StartQueryResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void StartQuery_EventDataStoreNotFoundExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("StartQuery");

            var request = InstantiateClassGenerator.Execute<StartQueryRequest>();
            var marshaller = new StartQueryRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<StartQueryRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("EventDataStoreNotFoundException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","EventDataStoreNotFoundException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = StartQueryResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void StartQuery_InactiveEventDataStoreExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("StartQuery");

            var request = InstantiateClassGenerator.Execute<StartQueryRequest>();
            var marshaller = new StartQueryRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<StartQueryRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InactiveEventDataStoreException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","InactiveEventDataStoreException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = StartQueryResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void StartQuery_InsufficientEncryptionPolicyExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("StartQuery");

            var request = InstantiateClassGenerator.Execute<StartQueryRequest>();
            var marshaller = new StartQueryRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<StartQueryRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InsufficientEncryptionPolicyException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","InsufficientEncryptionPolicyException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = StartQueryResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void StartQuery_InsufficientS3BucketPolicyExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("StartQuery");

            var request = InstantiateClassGenerator.Execute<StartQueryRequest>();
            var marshaller = new StartQueryRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<StartQueryRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InsufficientS3BucketPolicyException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","InsufficientS3BucketPolicyException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = StartQueryResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void StartQuery_InvalidParameterExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("StartQuery");

            var request = InstantiateClassGenerator.Execute<StartQueryRequest>();
            var marshaller = new StartQueryRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<StartQueryRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidParameterException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","InvalidParameterException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = StartQueryResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void StartQuery_InvalidQueryStatementExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("StartQuery");

            var request = InstantiateClassGenerator.Execute<StartQueryRequest>();
            var marshaller = new StartQueryRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<StartQueryRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidQueryStatementException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","InvalidQueryStatementException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = StartQueryResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void StartQuery_InvalidS3BucketNameExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("StartQuery");

            var request = InstantiateClassGenerator.Execute<StartQueryRequest>();
            var marshaller = new StartQueryRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<StartQueryRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidS3BucketNameException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","InvalidS3BucketNameException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = StartQueryResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void StartQuery_InvalidS3PrefixExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("StartQuery");

            var request = InstantiateClassGenerator.Execute<StartQueryRequest>();
            var marshaller = new StartQueryRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<StartQueryRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidS3PrefixException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","InvalidS3PrefixException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = StartQueryResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void StartQuery_MaxConcurrentQueriesExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("StartQuery");

            var request = InstantiateClassGenerator.Execute<StartQueryRequest>();
            var marshaller = new StartQueryRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<StartQueryRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("MaxConcurrentQueriesException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","MaxConcurrentQueriesException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = StartQueryResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void StartQuery_NoManagementAccountSLRExistsExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("StartQuery");

            var request = InstantiateClassGenerator.Execute<StartQueryRequest>();
            var marshaller = new StartQueryRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<StartQueryRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("NoManagementAccountSLRExistsException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","NoManagementAccountSLRExistsException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = StartQueryResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void StartQuery_OperationNotPermittedExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("StartQuery");

            var request = InstantiateClassGenerator.Execute<StartQueryRequest>();
            var marshaller = new StartQueryRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<StartQueryRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("OperationNotPermittedException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","OperationNotPermittedException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = StartQueryResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void StartQuery_S3BucketDoesNotExistExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("StartQuery");

            var request = InstantiateClassGenerator.Execute<StartQueryRequest>();
            var marshaller = new StartQueryRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<StartQueryRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("S3BucketDoesNotExistException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","S3BucketDoesNotExistException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = StartQueryResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void StartQuery_UnsupportedOperationExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("StartQuery");

            var request = InstantiateClassGenerator.Execute<StartQueryRequest>();
            var marshaller = new StartQueryRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<StartQueryRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("UnsupportedOperationException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","UnsupportedOperationException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = StartQueryResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void StopImportMarshallTest()
        {
            var request = InstantiateClassGenerator.Execute<StopImportRequest>();
            var marshaller = new StopImportRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);
            Comparer.CompareObjectToJson<StopImportRequest>(request,jsonRequest);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            var jsonResponse = new JsonSampleGenerator(service_model, service_model.FindOperation("StopImport").ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString());
            UnmarshallerContext context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), false, webResponse);
            var response = StopImportResponseUnmarshaller.Instance.Unmarshall(context) as StopImportResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void StopImport_ImportNotFoundExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("StopImport");

            var request = InstantiateClassGenerator.Execute<StopImportRequest>();
            var marshaller = new StopImportRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<StopImportRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("ImportNotFoundException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","ImportNotFoundException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = StopImportResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void StopImport_InvalidParameterExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("StopImport");

            var request = InstantiateClassGenerator.Execute<StopImportRequest>();
            var marshaller = new StopImportRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<StopImportRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidParameterException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","InvalidParameterException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = StopImportResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void StopImport_OperationNotPermittedExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("StopImport");

            var request = InstantiateClassGenerator.Execute<StopImportRequest>();
            var marshaller = new StopImportRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<StopImportRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("OperationNotPermittedException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","OperationNotPermittedException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = StopImportResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void StopImport_UnsupportedOperationExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("StopImport");

            var request = InstantiateClassGenerator.Execute<StopImportRequest>();
            var marshaller = new StopImportRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<StopImportRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("UnsupportedOperationException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","UnsupportedOperationException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = StopImportResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void StopLoggingMarshallTest()
        {
            var request = InstantiateClassGenerator.Execute<StopLoggingRequest>();
            var marshaller = new StopLoggingRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);
            Comparer.CompareObjectToJson<StopLoggingRequest>(request,jsonRequest);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            var jsonResponse = new JsonSampleGenerator(service_model, service_model.FindOperation("StopLogging").ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString());
            UnmarshallerContext context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), false, webResponse);
            var response = StopLoggingResponseUnmarshaller.Instance.Unmarshall(context) as StopLoggingResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void StopLogging_CloudTrailARNInvalidExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("StopLogging");

            var request = InstantiateClassGenerator.Execute<StopLoggingRequest>();
            var marshaller = new StopLoggingRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<StopLoggingRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("CloudTrailARNInvalidException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","CloudTrailARNInvalidException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = StopLoggingResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void StopLogging_ConflictExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("StopLogging");

            var request = InstantiateClassGenerator.Execute<StopLoggingRequest>();
            var marshaller = new StopLoggingRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<StopLoggingRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("ConflictException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","ConflictException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = StopLoggingResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void StopLogging_InsufficientDependencyServiceAccessPermissionExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("StopLogging");

            var request = InstantiateClassGenerator.Execute<StopLoggingRequest>();
            var marshaller = new StopLoggingRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<StopLoggingRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InsufficientDependencyServiceAccessPermissionException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","InsufficientDependencyServiceAccessPermissionException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = StopLoggingResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void StopLogging_InvalidHomeRegionExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("StopLogging");

            var request = InstantiateClassGenerator.Execute<StopLoggingRequest>();
            var marshaller = new StopLoggingRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<StopLoggingRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidHomeRegionException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","InvalidHomeRegionException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = StopLoggingResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void StopLogging_InvalidTrailNameExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("StopLogging");

            var request = InstantiateClassGenerator.Execute<StopLoggingRequest>();
            var marshaller = new StopLoggingRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<StopLoggingRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidTrailNameException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","InvalidTrailNameException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = StopLoggingResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void StopLogging_NoManagementAccountSLRExistsExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("StopLogging");

            var request = InstantiateClassGenerator.Execute<StopLoggingRequest>();
            var marshaller = new StopLoggingRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<StopLoggingRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("NoManagementAccountSLRExistsException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","NoManagementAccountSLRExistsException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = StopLoggingResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void StopLogging_NotOrganizationMasterAccountExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("StopLogging");

            var request = InstantiateClassGenerator.Execute<StopLoggingRequest>();
            var marshaller = new StopLoggingRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<StopLoggingRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("NotOrganizationMasterAccountException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","NotOrganizationMasterAccountException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = StopLoggingResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void StopLogging_OperationNotPermittedExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("StopLogging");

            var request = InstantiateClassGenerator.Execute<StopLoggingRequest>();
            var marshaller = new StopLoggingRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<StopLoggingRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("OperationNotPermittedException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","OperationNotPermittedException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = StopLoggingResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void StopLogging_TrailNotFoundExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("StopLogging");

            var request = InstantiateClassGenerator.Execute<StopLoggingRequest>();
            var marshaller = new StopLoggingRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<StopLoggingRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("TrailNotFoundException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","TrailNotFoundException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = StopLoggingResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void StopLogging_UnsupportedOperationExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("StopLogging");

            var request = InstantiateClassGenerator.Execute<StopLoggingRequest>();
            var marshaller = new StopLoggingRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<StopLoggingRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("UnsupportedOperationException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","UnsupportedOperationException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = StopLoggingResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void UpdateChannelMarshallTest()
        {
            var request = InstantiateClassGenerator.Execute<UpdateChannelRequest>();
            var marshaller = new UpdateChannelRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);
            Comparer.CompareObjectToJson<UpdateChannelRequest>(request,jsonRequest);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            var jsonResponse = new JsonSampleGenerator(service_model, service_model.FindOperation("UpdateChannel").ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString());
            UnmarshallerContext context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), false, webResponse);
            var response = UpdateChannelResponseUnmarshaller.Instance.Unmarshall(context) as UpdateChannelResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void UpdateChannel_ChannelAlreadyExistsExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("UpdateChannel");

            var request = InstantiateClassGenerator.Execute<UpdateChannelRequest>();
            var marshaller = new UpdateChannelRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<UpdateChannelRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("ChannelAlreadyExistsException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","ChannelAlreadyExistsException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = UpdateChannelResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void UpdateChannel_ChannelARNInvalidExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("UpdateChannel");

            var request = InstantiateClassGenerator.Execute<UpdateChannelRequest>();
            var marshaller = new UpdateChannelRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<UpdateChannelRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("ChannelARNInvalidException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","ChannelARNInvalidException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = UpdateChannelResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void UpdateChannel_ChannelNotFoundExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("UpdateChannel");

            var request = InstantiateClassGenerator.Execute<UpdateChannelRequest>();
            var marshaller = new UpdateChannelRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<UpdateChannelRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("ChannelNotFoundException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","ChannelNotFoundException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = UpdateChannelResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void UpdateChannel_EventDataStoreARNInvalidExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("UpdateChannel");

            var request = InstantiateClassGenerator.Execute<UpdateChannelRequest>();
            var marshaller = new UpdateChannelRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<UpdateChannelRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("EventDataStoreARNInvalidException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","EventDataStoreARNInvalidException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = UpdateChannelResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void UpdateChannel_EventDataStoreNotFoundExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("UpdateChannel");

            var request = InstantiateClassGenerator.Execute<UpdateChannelRequest>();
            var marshaller = new UpdateChannelRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<UpdateChannelRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("EventDataStoreNotFoundException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","EventDataStoreNotFoundException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = UpdateChannelResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void UpdateChannel_InactiveEventDataStoreExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("UpdateChannel");

            var request = InstantiateClassGenerator.Execute<UpdateChannelRequest>();
            var marshaller = new UpdateChannelRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<UpdateChannelRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InactiveEventDataStoreException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","InactiveEventDataStoreException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = UpdateChannelResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void UpdateChannel_InvalidEventDataStoreCategoryExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("UpdateChannel");

            var request = InstantiateClassGenerator.Execute<UpdateChannelRequest>();
            var marshaller = new UpdateChannelRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<UpdateChannelRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidEventDataStoreCategoryException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","InvalidEventDataStoreCategoryException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = UpdateChannelResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void UpdateChannel_InvalidParameterExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("UpdateChannel");

            var request = InstantiateClassGenerator.Execute<UpdateChannelRequest>();
            var marshaller = new UpdateChannelRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<UpdateChannelRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidParameterException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","InvalidParameterException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = UpdateChannelResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void UpdateChannel_OperationNotPermittedExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("UpdateChannel");

            var request = InstantiateClassGenerator.Execute<UpdateChannelRequest>();
            var marshaller = new UpdateChannelRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<UpdateChannelRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("OperationNotPermittedException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","OperationNotPermittedException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = UpdateChannelResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void UpdateChannel_UnsupportedOperationExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("UpdateChannel");

            var request = InstantiateClassGenerator.Execute<UpdateChannelRequest>();
            var marshaller = new UpdateChannelRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<UpdateChannelRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("UnsupportedOperationException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","UnsupportedOperationException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = UpdateChannelResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void UpdateEventDataStoreMarshallTest()
        {
            var request = InstantiateClassGenerator.Execute<UpdateEventDataStoreRequest>();
            var marshaller = new UpdateEventDataStoreRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);
            Comparer.CompareObjectToJson<UpdateEventDataStoreRequest>(request,jsonRequest);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            var jsonResponse = new JsonSampleGenerator(service_model, service_model.FindOperation("UpdateEventDataStore").ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString());
            UnmarshallerContext context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), false, webResponse);
            var response = UpdateEventDataStoreResponseUnmarshaller.Instance.Unmarshall(context) as UpdateEventDataStoreResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void UpdateEventDataStore_CloudTrailAccessNotEnabledExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("UpdateEventDataStore");

            var request = InstantiateClassGenerator.Execute<UpdateEventDataStoreRequest>();
            var marshaller = new UpdateEventDataStoreRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<UpdateEventDataStoreRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("CloudTrailAccessNotEnabledException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","CloudTrailAccessNotEnabledException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = UpdateEventDataStoreResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void UpdateEventDataStore_EventDataStoreARNInvalidExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("UpdateEventDataStore");

            var request = InstantiateClassGenerator.Execute<UpdateEventDataStoreRequest>();
            var marshaller = new UpdateEventDataStoreRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<UpdateEventDataStoreRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("EventDataStoreARNInvalidException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","EventDataStoreARNInvalidException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = UpdateEventDataStoreResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void UpdateEventDataStore_EventDataStoreHasOngoingImportExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("UpdateEventDataStore");

            var request = InstantiateClassGenerator.Execute<UpdateEventDataStoreRequest>();
            var marshaller = new UpdateEventDataStoreRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<UpdateEventDataStoreRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("EventDataStoreHasOngoingImportException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","EventDataStoreHasOngoingImportException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = UpdateEventDataStoreResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void UpdateEventDataStore_EventDataStoreNotFoundExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("UpdateEventDataStore");

            var request = InstantiateClassGenerator.Execute<UpdateEventDataStoreRequest>();
            var marshaller = new UpdateEventDataStoreRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<UpdateEventDataStoreRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("EventDataStoreNotFoundException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","EventDataStoreNotFoundException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = UpdateEventDataStoreResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void UpdateEventDataStore_InactiveEventDataStoreExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("UpdateEventDataStore");

            var request = InstantiateClassGenerator.Execute<UpdateEventDataStoreRequest>();
            var marshaller = new UpdateEventDataStoreRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<UpdateEventDataStoreRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InactiveEventDataStoreException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","InactiveEventDataStoreException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = UpdateEventDataStoreResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void UpdateEventDataStore_InsufficientDependencyServiceAccessPermissionExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("UpdateEventDataStore");

            var request = InstantiateClassGenerator.Execute<UpdateEventDataStoreRequest>();
            var marshaller = new UpdateEventDataStoreRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<UpdateEventDataStoreRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InsufficientDependencyServiceAccessPermissionException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","InsufficientDependencyServiceAccessPermissionException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = UpdateEventDataStoreResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void UpdateEventDataStore_InsufficientEncryptionPolicyExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("UpdateEventDataStore");

            var request = InstantiateClassGenerator.Execute<UpdateEventDataStoreRequest>();
            var marshaller = new UpdateEventDataStoreRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<UpdateEventDataStoreRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InsufficientEncryptionPolicyException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","InsufficientEncryptionPolicyException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = UpdateEventDataStoreResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void UpdateEventDataStore_InvalidEventSelectorsExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("UpdateEventDataStore");

            var request = InstantiateClassGenerator.Execute<UpdateEventDataStoreRequest>();
            var marshaller = new UpdateEventDataStoreRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<UpdateEventDataStoreRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidEventSelectorsException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","InvalidEventSelectorsException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = UpdateEventDataStoreResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void UpdateEventDataStore_InvalidKmsKeyIdExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("UpdateEventDataStore");

            var request = InstantiateClassGenerator.Execute<UpdateEventDataStoreRequest>();
            var marshaller = new UpdateEventDataStoreRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<UpdateEventDataStoreRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidKmsKeyIdException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","InvalidKmsKeyIdException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = UpdateEventDataStoreResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void UpdateEventDataStore_InvalidParameterExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("UpdateEventDataStore");

            var request = InstantiateClassGenerator.Execute<UpdateEventDataStoreRequest>();
            var marshaller = new UpdateEventDataStoreRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<UpdateEventDataStoreRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidParameterException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","InvalidParameterException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = UpdateEventDataStoreResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void UpdateEventDataStore_KmsExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("UpdateEventDataStore");

            var request = InstantiateClassGenerator.Execute<UpdateEventDataStoreRequest>();
            var marshaller = new UpdateEventDataStoreRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<UpdateEventDataStoreRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("KmsException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","KmsException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = UpdateEventDataStoreResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void UpdateEventDataStore_KmsKeyNotFoundExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("UpdateEventDataStore");

            var request = InstantiateClassGenerator.Execute<UpdateEventDataStoreRequest>();
            var marshaller = new UpdateEventDataStoreRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<UpdateEventDataStoreRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("KmsKeyNotFoundException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","KmsKeyNotFoundException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = UpdateEventDataStoreResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void UpdateEventDataStore_NoManagementAccountSLRExistsExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("UpdateEventDataStore");

            var request = InstantiateClassGenerator.Execute<UpdateEventDataStoreRequest>();
            var marshaller = new UpdateEventDataStoreRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<UpdateEventDataStoreRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("NoManagementAccountSLRExistsException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","NoManagementAccountSLRExistsException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = UpdateEventDataStoreResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void UpdateEventDataStore_NotOrganizationMasterAccountExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("UpdateEventDataStore");

            var request = InstantiateClassGenerator.Execute<UpdateEventDataStoreRequest>();
            var marshaller = new UpdateEventDataStoreRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<UpdateEventDataStoreRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("NotOrganizationMasterAccountException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","NotOrganizationMasterAccountException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = UpdateEventDataStoreResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void UpdateEventDataStore_OperationNotPermittedExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("UpdateEventDataStore");

            var request = InstantiateClassGenerator.Execute<UpdateEventDataStoreRequest>();
            var marshaller = new UpdateEventDataStoreRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<UpdateEventDataStoreRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("OperationNotPermittedException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","OperationNotPermittedException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = UpdateEventDataStoreResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void UpdateEventDataStore_OrganizationNotInAllFeaturesModeExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("UpdateEventDataStore");

            var request = InstantiateClassGenerator.Execute<UpdateEventDataStoreRequest>();
            var marshaller = new UpdateEventDataStoreRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<UpdateEventDataStoreRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("OrganizationNotInAllFeaturesModeException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","OrganizationNotInAllFeaturesModeException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = UpdateEventDataStoreResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void UpdateEventDataStore_OrganizationsNotInUseExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("UpdateEventDataStore");

            var request = InstantiateClassGenerator.Execute<UpdateEventDataStoreRequest>();
            var marshaller = new UpdateEventDataStoreRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<UpdateEventDataStoreRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("OrganizationsNotInUseException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","OrganizationsNotInUseException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = UpdateEventDataStoreResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void UpdateEventDataStore_UnsupportedOperationExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("UpdateEventDataStore");

            var request = InstantiateClassGenerator.Execute<UpdateEventDataStoreRequest>();
            var marshaller = new UpdateEventDataStoreRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<UpdateEventDataStoreRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("UnsupportedOperationException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","UnsupportedOperationException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = UpdateEventDataStoreResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void UpdateTrailMarshallTest()
        {
            var request = InstantiateClassGenerator.Execute<UpdateTrailRequest>();
            var marshaller = new UpdateTrailRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);
            Comparer.CompareObjectToJson<UpdateTrailRequest>(request,jsonRequest);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            var jsonResponse = new JsonSampleGenerator(service_model, service_model.FindOperation("UpdateTrail").ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString());
            UnmarshallerContext context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), false, webResponse);
            var response = UpdateTrailResponseUnmarshaller.Instance.Unmarshall(context) as UpdateTrailResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void UpdateTrail_CloudTrailAccessNotEnabledExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("UpdateTrail");

            var request = InstantiateClassGenerator.Execute<UpdateTrailRequest>();
            var marshaller = new UpdateTrailRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<UpdateTrailRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("CloudTrailAccessNotEnabledException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","CloudTrailAccessNotEnabledException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = UpdateTrailResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void UpdateTrail_CloudTrailARNInvalidExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("UpdateTrail");

            var request = InstantiateClassGenerator.Execute<UpdateTrailRequest>();
            var marshaller = new UpdateTrailRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<UpdateTrailRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("CloudTrailARNInvalidException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","CloudTrailARNInvalidException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = UpdateTrailResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void UpdateTrail_CloudTrailInvalidClientTokenIdExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("UpdateTrail");

            var request = InstantiateClassGenerator.Execute<UpdateTrailRequest>();
            var marshaller = new UpdateTrailRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<UpdateTrailRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("CloudTrailInvalidClientTokenIdException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","CloudTrailInvalidClientTokenIdException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = UpdateTrailResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void UpdateTrail_CloudWatchLogsDeliveryUnavailableExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("UpdateTrail");

            var request = InstantiateClassGenerator.Execute<UpdateTrailRequest>();
            var marshaller = new UpdateTrailRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<UpdateTrailRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("CloudWatchLogsDeliveryUnavailableException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","CloudWatchLogsDeliveryUnavailableException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = UpdateTrailResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void UpdateTrail_ConflictExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("UpdateTrail");

            var request = InstantiateClassGenerator.Execute<UpdateTrailRequest>();
            var marshaller = new UpdateTrailRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<UpdateTrailRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("ConflictException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","ConflictException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = UpdateTrailResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void UpdateTrail_InsufficientDependencyServiceAccessPermissionExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("UpdateTrail");

            var request = InstantiateClassGenerator.Execute<UpdateTrailRequest>();
            var marshaller = new UpdateTrailRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<UpdateTrailRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InsufficientDependencyServiceAccessPermissionException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","InsufficientDependencyServiceAccessPermissionException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = UpdateTrailResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void UpdateTrail_InsufficientEncryptionPolicyExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("UpdateTrail");

            var request = InstantiateClassGenerator.Execute<UpdateTrailRequest>();
            var marshaller = new UpdateTrailRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<UpdateTrailRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InsufficientEncryptionPolicyException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","InsufficientEncryptionPolicyException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = UpdateTrailResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void UpdateTrail_InsufficientS3BucketPolicyExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("UpdateTrail");

            var request = InstantiateClassGenerator.Execute<UpdateTrailRequest>();
            var marshaller = new UpdateTrailRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<UpdateTrailRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InsufficientS3BucketPolicyException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","InsufficientS3BucketPolicyException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = UpdateTrailResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void UpdateTrail_InsufficientSnsTopicPolicyExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("UpdateTrail");

            var request = InstantiateClassGenerator.Execute<UpdateTrailRequest>();
            var marshaller = new UpdateTrailRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<UpdateTrailRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InsufficientSnsTopicPolicyException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","InsufficientSnsTopicPolicyException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = UpdateTrailResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void UpdateTrail_InvalidCloudWatchLogsLogGroupArnExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("UpdateTrail");

            var request = InstantiateClassGenerator.Execute<UpdateTrailRequest>();
            var marshaller = new UpdateTrailRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<UpdateTrailRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidCloudWatchLogsLogGroupArnException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","InvalidCloudWatchLogsLogGroupArnException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = UpdateTrailResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void UpdateTrail_InvalidCloudWatchLogsRoleArnExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("UpdateTrail");

            var request = InstantiateClassGenerator.Execute<UpdateTrailRequest>();
            var marshaller = new UpdateTrailRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<UpdateTrailRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidCloudWatchLogsRoleArnException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","InvalidCloudWatchLogsRoleArnException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = UpdateTrailResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void UpdateTrail_InvalidEventSelectorsExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("UpdateTrail");

            var request = InstantiateClassGenerator.Execute<UpdateTrailRequest>();
            var marshaller = new UpdateTrailRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<UpdateTrailRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidEventSelectorsException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","InvalidEventSelectorsException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = UpdateTrailResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void UpdateTrail_InvalidHomeRegionExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("UpdateTrail");

            var request = InstantiateClassGenerator.Execute<UpdateTrailRequest>();
            var marshaller = new UpdateTrailRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<UpdateTrailRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidHomeRegionException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","InvalidHomeRegionException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = UpdateTrailResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void UpdateTrail_InvalidKmsKeyIdExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("UpdateTrail");

            var request = InstantiateClassGenerator.Execute<UpdateTrailRequest>();
            var marshaller = new UpdateTrailRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<UpdateTrailRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidKmsKeyIdException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","InvalidKmsKeyIdException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = UpdateTrailResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void UpdateTrail_InvalidParameterCombinationExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("UpdateTrail");

            var request = InstantiateClassGenerator.Execute<UpdateTrailRequest>();
            var marshaller = new UpdateTrailRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<UpdateTrailRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidParameterCombinationException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","InvalidParameterCombinationException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = UpdateTrailResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void UpdateTrail_InvalidParameterExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("UpdateTrail");

            var request = InstantiateClassGenerator.Execute<UpdateTrailRequest>();
            var marshaller = new UpdateTrailRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<UpdateTrailRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidParameterException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","InvalidParameterException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = UpdateTrailResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void UpdateTrail_InvalidS3BucketNameExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("UpdateTrail");

            var request = InstantiateClassGenerator.Execute<UpdateTrailRequest>();
            var marshaller = new UpdateTrailRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<UpdateTrailRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidS3BucketNameException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","InvalidS3BucketNameException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = UpdateTrailResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void UpdateTrail_InvalidS3PrefixExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("UpdateTrail");

            var request = InstantiateClassGenerator.Execute<UpdateTrailRequest>();
            var marshaller = new UpdateTrailRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<UpdateTrailRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidS3PrefixException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","InvalidS3PrefixException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = UpdateTrailResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void UpdateTrail_InvalidSnsTopicNameExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("UpdateTrail");

            var request = InstantiateClassGenerator.Execute<UpdateTrailRequest>();
            var marshaller = new UpdateTrailRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<UpdateTrailRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidSnsTopicNameException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","InvalidSnsTopicNameException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = UpdateTrailResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void UpdateTrail_InvalidTrailNameExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("UpdateTrail");

            var request = InstantiateClassGenerator.Execute<UpdateTrailRequest>();
            var marshaller = new UpdateTrailRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<UpdateTrailRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidTrailNameException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","InvalidTrailNameException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = UpdateTrailResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void UpdateTrail_KmsExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("UpdateTrail");

            var request = InstantiateClassGenerator.Execute<UpdateTrailRequest>();
            var marshaller = new UpdateTrailRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<UpdateTrailRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("KmsException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","KmsException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = UpdateTrailResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void UpdateTrail_KmsKeyDisabledExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("UpdateTrail");

            var request = InstantiateClassGenerator.Execute<UpdateTrailRequest>();
            var marshaller = new UpdateTrailRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<UpdateTrailRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("KmsKeyDisabledException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","KmsKeyDisabledException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = UpdateTrailResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void UpdateTrail_KmsKeyNotFoundExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("UpdateTrail");

            var request = InstantiateClassGenerator.Execute<UpdateTrailRequest>();
            var marshaller = new UpdateTrailRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<UpdateTrailRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("KmsKeyNotFoundException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","KmsKeyNotFoundException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = UpdateTrailResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void UpdateTrail_NoManagementAccountSLRExistsExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("UpdateTrail");

            var request = InstantiateClassGenerator.Execute<UpdateTrailRequest>();
            var marshaller = new UpdateTrailRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<UpdateTrailRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("NoManagementAccountSLRExistsException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","NoManagementAccountSLRExistsException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = UpdateTrailResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void UpdateTrail_NotOrganizationMasterAccountExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("UpdateTrail");

            var request = InstantiateClassGenerator.Execute<UpdateTrailRequest>();
            var marshaller = new UpdateTrailRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<UpdateTrailRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("NotOrganizationMasterAccountException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","NotOrganizationMasterAccountException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = UpdateTrailResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void UpdateTrail_OperationNotPermittedExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("UpdateTrail");

            var request = InstantiateClassGenerator.Execute<UpdateTrailRequest>();
            var marshaller = new UpdateTrailRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<UpdateTrailRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("OperationNotPermittedException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","OperationNotPermittedException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = UpdateTrailResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void UpdateTrail_OrganizationNotInAllFeaturesModeExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("UpdateTrail");

            var request = InstantiateClassGenerator.Execute<UpdateTrailRequest>();
            var marshaller = new UpdateTrailRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<UpdateTrailRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("OrganizationNotInAllFeaturesModeException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","OrganizationNotInAllFeaturesModeException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = UpdateTrailResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void UpdateTrail_OrganizationsNotInUseExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("UpdateTrail");

            var request = InstantiateClassGenerator.Execute<UpdateTrailRequest>();
            var marshaller = new UpdateTrailRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<UpdateTrailRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("OrganizationsNotInUseException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","OrganizationsNotInUseException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = UpdateTrailResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void UpdateTrail_S3BucketDoesNotExistExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("UpdateTrail");

            var request = InstantiateClassGenerator.Execute<UpdateTrailRequest>();
            var marshaller = new UpdateTrailRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<UpdateTrailRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("S3BucketDoesNotExistException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","S3BucketDoesNotExistException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = UpdateTrailResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void UpdateTrail_TrailNotFoundExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("UpdateTrail");

            var request = InstantiateClassGenerator.Execute<UpdateTrailRequest>();
            var marshaller = new UpdateTrailRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<UpdateTrailRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("TrailNotFoundException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","TrailNotFoundException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = UpdateTrailResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void UpdateTrail_TrailNotProvidedExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("UpdateTrail");

            var request = InstantiateClassGenerator.Execute<UpdateTrailRequest>();
            var marshaller = new UpdateTrailRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<UpdateTrailRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("TrailNotProvidedException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","TrailNotProvidedException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = UpdateTrailResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("CloudTrail")]
        public void UpdateTrail_UnsupportedOperationExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("UpdateTrail");

            var request = InstantiateClassGenerator.Execute<UpdateTrailRequest>();
            var marshaller = new UpdateTrailRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<UpdateTrailRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("UnsupportedOperationException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","UnsupportedOperationException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = UpdateTrailResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }
    }
}