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
 * Do not modify this file. This file is generated from the wafv2-2019-07-29.normal.json service model.
 */


using System;
using System.IO;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Amazon.WAFV2;
using Amazon.WAFV2.Model;
using Amazon.WAFV2.Model.Internal.MarshallTransformations;
using Amazon.Runtime.Internal.Transform;

using ServiceClientGenerator;

using AWSSDK_DotNet35.UnitTests.TestTools;

namespace AWSSDK_DotNet35.UnitTests.Marshalling
{
    [TestClass]
    public class WAFV2MarshallingTests
    {
        static readonly ServiceModel service_model = Utils.LoadServiceModel("wafv2");
        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void AssociateWebACLMarshallTest()
        {
            var request = InstantiateClassGenerator.Execute<AssociateWebACLRequest>();
            var marshaller = new AssociateWebACLRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);
            Comparer.CompareObjectToJson<AssociateWebACLRequest>(request,jsonRequest);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            var jsonResponse = new JsonSampleGenerator(service_model, service_model.FindOperation("AssociateWebACL").ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString());
            UnmarshallerContext context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), false, webResponse);
            var response = AssociateWebACLResponseUnmarshaller.Instance.Unmarshall(context) as AssociateWebACLResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void AssociateWebACL_WAFInternalErrorExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("AssociateWebACL");

            var request = InstantiateClassGenerator.Execute<AssociateWebACLRequest>();
            var marshaller = new AssociateWebACLRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<AssociateWebACLRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("WAFInternalErrorException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","WAFInternalErrorException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = AssociateWebACLResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void AssociateWebACL_WAFInvalidOperationExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("AssociateWebACL");

            var request = InstantiateClassGenerator.Execute<AssociateWebACLRequest>();
            var marshaller = new AssociateWebACLRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<AssociateWebACLRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("WAFInvalidOperationException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","WAFInvalidOperationException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = AssociateWebACLResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void AssociateWebACL_WAFInvalidParameterExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("AssociateWebACL");

            var request = InstantiateClassGenerator.Execute<AssociateWebACLRequest>();
            var marshaller = new AssociateWebACLRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<AssociateWebACLRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("WAFInvalidParameterException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","WAFInvalidParameterException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = AssociateWebACLResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void AssociateWebACL_WAFNonexistentItemExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("AssociateWebACL");

            var request = InstantiateClassGenerator.Execute<AssociateWebACLRequest>();
            var marshaller = new AssociateWebACLRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<AssociateWebACLRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("WAFNonexistentItemException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","WAFNonexistentItemException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = AssociateWebACLResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void AssociateWebACL_WAFUnavailableEntityExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("AssociateWebACL");

            var request = InstantiateClassGenerator.Execute<AssociateWebACLRequest>();
            var marshaller = new AssociateWebACLRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<AssociateWebACLRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("WAFUnavailableEntityException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","WAFUnavailableEntityException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = AssociateWebACLResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void CheckCapacityMarshallTest()
        {
            var request = InstantiateClassGenerator.Execute<CheckCapacityRequest>();
            var marshaller = new CheckCapacityRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);
            Comparer.CompareObjectToJson<CheckCapacityRequest>(request,jsonRequest);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            var jsonResponse = new JsonSampleGenerator(service_model, service_model.FindOperation("CheckCapacity").ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString());
            UnmarshallerContext context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), false, webResponse);
            var response = CheckCapacityResponseUnmarshaller.Instance.Unmarshall(context) as CheckCapacityResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void CheckCapacity_WAFExpiredManagedRuleGroupVersionExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("CheckCapacity");

            var request = InstantiateClassGenerator.Execute<CheckCapacityRequest>();
            var marshaller = new CheckCapacityRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<CheckCapacityRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("WAFExpiredManagedRuleGroupVersionException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","WAFExpiredManagedRuleGroupVersionException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = CheckCapacityResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void CheckCapacity_WAFInternalErrorExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("CheckCapacity");

            var request = InstantiateClassGenerator.Execute<CheckCapacityRequest>();
            var marshaller = new CheckCapacityRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<CheckCapacityRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("WAFInternalErrorException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","WAFInternalErrorException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = CheckCapacityResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void CheckCapacity_WAFInvalidOperationExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("CheckCapacity");

            var request = InstantiateClassGenerator.Execute<CheckCapacityRequest>();
            var marshaller = new CheckCapacityRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<CheckCapacityRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("WAFInvalidOperationException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","WAFInvalidOperationException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = CheckCapacityResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void CheckCapacity_WAFInvalidParameterExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("CheckCapacity");

            var request = InstantiateClassGenerator.Execute<CheckCapacityRequest>();
            var marshaller = new CheckCapacityRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<CheckCapacityRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("WAFInvalidParameterException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","WAFInvalidParameterException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = CheckCapacityResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void CheckCapacity_WAFInvalidResourceExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("CheckCapacity");

            var request = InstantiateClassGenerator.Execute<CheckCapacityRequest>();
            var marshaller = new CheckCapacityRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<CheckCapacityRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("WAFInvalidResourceException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","WAFInvalidResourceException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = CheckCapacityResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void CheckCapacity_WAFLimitsExceededExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("CheckCapacity");

            var request = InstantiateClassGenerator.Execute<CheckCapacityRequest>();
            var marshaller = new CheckCapacityRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<CheckCapacityRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("WAFLimitsExceededException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","WAFLimitsExceededException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = CheckCapacityResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void CheckCapacity_WAFNonexistentItemExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("CheckCapacity");

            var request = InstantiateClassGenerator.Execute<CheckCapacityRequest>();
            var marshaller = new CheckCapacityRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<CheckCapacityRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("WAFNonexistentItemException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","WAFNonexistentItemException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = CheckCapacityResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void CheckCapacity_WAFSubscriptionNotFoundExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("CheckCapacity");

            var request = InstantiateClassGenerator.Execute<CheckCapacityRequest>();
            var marshaller = new CheckCapacityRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<CheckCapacityRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("WAFSubscriptionNotFoundException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","WAFSubscriptionNotFoundException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = CheckCapacityResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void CheckCapacity_WAFUnavailableEntityExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("CheckCapacity");

            var request = InstantiateClassGenerator.Execute<CheckCapacityRequest>();
            var marshaller = new CheckCapacityRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<CheckCapacityRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("WAFUnavailableEntityException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","WAFUnavailableEntityException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = CheckCapacityResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void CreateIPSetMarshallTest()
        {
            var request = InstantiateClassGenerator.Execute<CreateIPSetRequest>();
            var marshaller = new CreateIPSetRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);
            Comparer.CompareObjectToJson<CreateIPSetRequest>(request,jsonRequest);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            var jsonResponse = new JsonSampleGenerator(service_model, service_model.FindOperation("CreateIPSet").ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString());
            UnmarshallerContext context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), false, webResponse);
            var response = CreateIPSetResponseUnmarshaller.Instance.Unmarshall(context) as CreateIPSetResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void CreateIPSet_WAFDuplicateItemExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("CreateIPSet");

            var request = InstantiateClassGenerator.Execute<CreateIPSetRequest>();
            var marshaller = new CreateIPSetRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<CreateIPSetRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("WAFDuplicateItemException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","WAFDuplicateItemException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = CreateIPSetResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void CreateIPSet_WAFInternalErrorExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("CreateIPSet");

            var request = InstantiateClassGenerator.Execute<CreateIPSetRequest>();
            var marshaller = new CreateIPSetRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<CreateIPSetRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("WAFInternalErrorException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","WAFInternalErrorException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = CreateIPSetResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void CreateIPSet_WAFInvalidOperationExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("CreateIPSet");

            var request = InstantiateClassGenerator.Execute<CreateIPSetRequest>();
            var marshaller = new CreateIPSetRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<CreateIPSetRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("WAFInvalidOperationException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","WAFInvalidOperationException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = CreateIPSetResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void CreateIPSet_WAFInvalidParameterExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("CreateIPSet");

            var request = InstantiateClassGenerator.Execute<CreateIPSetRequest>();
            var marshaller = new CreateIPSetRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<CreateIPSetRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("WAFInvalidParameterException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","WAFInvalidParameterException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = CreateIPSetResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void CreateIPSet_WAFLimitsExceededExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("CreateIPSet");

            var request = InstantiateClassGenerator.Execute<CreateIPSetRequest>();
            var marshaller = new CreateIPSetRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<CreateIPSetRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("WAFLimitsExceededException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","WAFLimitsExceededException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = CreateIPSetResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void CreateIPSet_WAFOptimisticLockExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("CreateIPSet");

            var request = InstantiateClassGenerator.Execute<CreateIPSetRequest>();
            var marshaller = new CreateIPSetRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<CreateIPSetRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("WAFOptimisticLockException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","WAFOptimisticLockException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = CreateIPSetResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void CreateIPSet_WAFTagOperationExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("CreateIPSet");

            var request = InstantiateClassGenerator.Execute<CreateIPSetRequest>();
            var marshaller = new CreateIPSetRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<CreateIPSetRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("WAFTagOperationException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","WAFTagOperationException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = CreateIPSetResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void CreateIPSet_WAFTagOperationInternalErrorExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("CreateIPSet");

            var request = InstantiateClassGenerator.Execute<CreateIPSetRequest>();
            var marshaller = new CreateIPSetRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<CreateIPSetRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("WAFTagOperationInternalErrorException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","WAFTagOperationInternalErrorException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = CreateIPSetResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void CreateRegexPatternSetMarshallTest()
        {
            var request = InstantiateClassGenerator.Execute<CreateRegexPatternSetRequest>();
            var marshaller = new CreateRegexPatternSetRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);
            Comparer.CompareObjectToJson<CreateRegexPatternSetRequest>(request,jsonRequest);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            var jsonResponse = new JsonSampleGenerator(service_model, service_model.FindOperation("CreateRegexPatternSet").ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString());
            UnmarshallerContext context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), false, webResponse);
            var response = CreateRegexPatternSetResponseUnmarshaller.Instance.Unmarshall(context) as CreateRegexPatternSetResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void CreateRegexPatternSet_WAFDuplicateItemExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("CreateRegexPatternSet");

            var request = InstantiateClassGenerator.Execute<CreateRegexPatternSetRequest>();
            var marshaller = new CreateRegexPatternSetRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<CreateRegexPatternSetRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("WAFDuplicateItemException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","WAFDuplicateItemException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = CreateRegexPatternSetResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void CreateRegexPatternSet_WAFInternalErrorExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("CreateRegexPatternSet");

            var request = InstantiateClassGenerator.Execute<CreateRegexPatternSetRequest>();
            var marshaller = new CreateRegexPatternSetRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<CreateRegexPatternSetRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("WAFInternalErrorException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","WAFInternalErrorException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = CreateRegexPatternSetResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void CreateRegexPatternSet_WAFInvalidOperationExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("CreateRegexPatternSet");

            var request = InstantiateClassGenerator.Execute<CreateRegexPatternSetRequest>();
            var marshaller = new CreateRegexPatternSetRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<CreateRegexPatternSetRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("WAFInvalidOperationException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","WAFInvalidOperationException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = CreateRegexPatternSetResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void CreateRegexPatternSet_WAFInvalidParameterExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("CreateRegexPatternSet");

            var request = InstantiateClassGenerator.Execute<CreateRegexPatternSetRequest>();
            var marshaller = new CreateRegexPatternSetRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<CreateRegexPatternSetRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("WAFInvalidParameterException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","WAFInvalidParameterException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = CreateRegexPatternSetResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void CreateRegexPatternSet_WAFLimitsExceededExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("CreateRegexPatternSet");

            var request = InstantiateClassGenerator.Execute<CreateRegexPatternSetRequest>();
            var marshaller = new CreateRegexPatternSetRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<CreateRegexPatternSetRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("WAFLimitsExceededException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","WAFLimitsExceededException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = CreateRegexPatternSetResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void CreateRegexPatternSet_WAFOptimisticLockExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("CreateRegexPatternSet");

            var request = InstantiateClassGenerator.Execute<CreateRegexPatternSetRequest>();
            var marshaller = new CreateRegexPatternSetRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<CreateRegexPatternSetRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("WAFOptimisticLockException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","WAFOptimisticLockException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = CreateRegexPatternSetResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void CreateRegexPatternSet_WAFTagOperationExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("CreateRegexPatternSet");

            var request = InstantiateClassGenerator.Execute<CreateRegexPatternSetRequest>();
            var marshaller = new CreateRegexPatternSetRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<CreateRegexPatternSetRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("WAFTagOperationException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","WAFTagOperationException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = CreateRegexPatternSetResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void CreateRegexPatternSet_WAFTagOperationInternalErrorExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("CreateRegexPatternSet");

            var request = InstantiateClassGenerator.Execute<CreateRegexPatternSetRequest>();
            var marshaller = new CreateRegexPatternSetRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<CreateRegexPatternSetRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("WAFTagOperationInternalErrorException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","WAFTagOperationInternalErrorException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = CreateRegexPatternSetResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void CreateRuleGroupMarshallTest()
        {
            var request = InstantiateClassGenerator.Execute<CreateRuleGroupRequest>();
            var marshaller = new CreateRuleGroupRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);
            Comparer.CompareObjectToJson<CreateRuleGroupRequest>(request,jsonRequest);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            var jsonResponse = new JsonSampleGenerator(service_model, service_model.FindOperation("CreateRuleGroup").ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString());
            UnmarshallerContext context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), false, webResponse);
            var response = CreateRuleGroupResponseUnmarshaller.Instance.Unmarshall(context) as CreateRuleGroupResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void CreateRuleGroup_WAFDuplicateItemExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("CreateRuleGroup");

            var request = InstantiateClassGenerator.Execute<CreateRuleGroupRequest>();
            var marshaller = new CreateRuleGroupRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<CreateRuleGroupRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("WAFDuplicateItemException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","WAFDuplicateItemException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = CreateRuleGroupResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void CreateRuleGroup_WAFInternalErrorExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("CreateRuleGroup");

            var request = InstantiateClassGenerator.Execute<CreateRuleGroupRequest>();
            var marshaller = new CreateRuleGroupRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<CreateRuleGroupRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("WAFInternalErrorException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","WAFInternalErrorException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = CreateRuleGroupResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void CreateRuleGroup_WAFInvalidOperationExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("CreateRuleGroup");

            var request = InstantiateClassGenerator.Execute<CreateRuleGroupRequest>();
            var marshaller = new CreateRuleGroupRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<CreateRuleGroupRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("WAFInvalidOperationException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","WAFInvalidOperationException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = CreateRuleGroupResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void CreateRuleGroup_WAFInvalidParameterExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("CreateRuleGroup");

            var request = InstantiateClassGenerator.Execute<CreateRuleGroupRequest>();
            var marshaller = new CreateRuleGroupRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<CreateRuleGroupRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("WAFInvalidParameterException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","WAFInvalidParameterException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = CreateRuleGroupResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void CreateRuleGroup_WAFLimitsExceededExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("CreateRuleGroup");

            var request = InstantiateClassGenerator.Execute<CreateRuleGroupRequest>();
            var marshaller = new CreateRuleGroupRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<CreateRuleGroupRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("WAFLimitsExceededException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","WAFLimitsExceededException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = CreateRuleGroupResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void CreateRuleGroup_WAFNonexistentItemExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("CreateRuleGroup");

            var request = InstantiateClassGenerator.Execute<CreateRuleGroupRequest>();
            var marshaller = new CreateRuleGroupRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<CreateRuleGroupRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("WAFNonexistentItemException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","WAFNonexistentItemException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = CreateRuleGroupResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void CreateRuleGroup_WAFOptimisticLockExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("CreateRuleGroup");

            var request = InstantiateClassGenerator.Execute<CreateRuleGroupRequest>();
            var marshaller = new CreateRuleGroupRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<CreateRuleGroupRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("WAFOptimisticLockException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","WAFOptimisticLockException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = CreateRuleGroupResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void CreateRuleGroup_WAFSubscriptionNotFoundExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("CreateRuleGroup");

            var request = InstantiateClassGenerator.Execute<CreateRuleGroupRequest>();
            var marshaller = new CreateRuleGroupRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<CreateRuleGroupRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("WAFSubscriptionNotFoundException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","WAFSubscriptionNotFoundException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = CreateRuleGroupResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void CreateRuleGroup_WAFTagOperationExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("CreateRuleGroup");

            var request = InstantiateClassGenerator.Execute<CreateRuleGroupRequest>();
            var marshaller = new CreateRuleGroupRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<CreateRuleGroupRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("WAFTagOperationException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","WAFTagOperationException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = CreateRuleGroupResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void CreateRuleGroup_WAFTagOperationInternalErrorExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("CreateRuleGroup");

            var request = InstantiateClassGenerator.Execute<CreateRuleGroupRequest>();
            var marshaller = new CreateRuleGroupRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<CreateRuleGroupRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("WAFTagOperationInternalErrorException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","WAFTagOperationInternalErrorException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = CreateRuleGroupResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void CreateRuleGroup_WAFUnavailableEntityExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("CreateRuleGroup");

            var request = InstantiateClassGenerator.Execute<CreateRuleGroupRequest>();
            var marshaller = new CreateRuleGroupRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<CreateRuleGroupRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("WAFUnavailableEntityException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","WAFUnavailableEntityException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = CreateRuleGroupResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void CreateWebACLMarshallTest()
        {
            var request = InstantiateClassGenerator.Execute<CreateWebACLRequest>();
            var marshaller = new CreateWebACLRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);
            Comparer.CompareObjectToJson<CreateWebACLRequest>(request,jsonRequest);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            var jsonResponse = new JsonSampleGenerator(service_model, service_model.FindOperation("CreateWebACL").ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString());
            UnmarshallerContext context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), false, webResponse);
            var response = CreateWebACLResponseUnmarshaller.Instance.Unmarshall(context) as CreateWebACLResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void CreateWebACL_WAFConfigurationWarningExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("CreateWebACL");

            var request = InstantiateClassGenerator.Execute<CreateWebACLRequest>();
            var marshaller = new CreateWebACLRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<CreateWebACLRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("WAFConfigurationWarningException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","WAFConfigurationWarningException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = CreateWebACLResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void CreateWebACL_WAFDuplicateItemExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("CreateWebACL");

            var request = InstantiateClassGenerator.Execute<CreateWebACLRequest>();
            var marshaller = new CreateWebACLRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<CreateWebACLRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("WAFDuplicateItemException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","WAFDuplicateItemException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = CreateWebACLResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void CreateWebACL_WAFExpiredManagedRuleGroupVersionExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("CreateWebACL");

            var request = InstantiateClassGenerator.Execute<CreateWebACLRequest>();
            var marshaller = new CreateWebACLRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<CreateWebACLRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("WAFExpiredManagedRuleGroupVersionException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","WAFExpiredManagedRuleGroupVersionException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = CreateWebACLResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void CreateWebACL_WAFInternalErrorExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("CreateWebACL");

            var request = InstantiateClassGenerator.Execute<CreateWebACLRequest>();
            var marshaller = new CreateWebACLRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<CreateWebACLRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("WAFInternalErrorException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","WAFInternalErrorException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = CreateWebACLResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void CreateWebACL_WAFInvalidOperationExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("CreateWebACL");

            var request = InstantiateClassGenerator.Execute<CreateWebACLRequest>();
            var marshaller = new CreateWebACLRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<CreateWebACLRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("WAFInvalidOperationException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","WAFInvalidOperationException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = CreateWebACLResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void CreateWebACL_WAFInvalidParameterExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("CreateWebACL");

            var request = InstantiateClassGenerator.Execute<CreateWebACLRequest>();
            var marshaller = new CreateWebACLRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<CreateWebACLRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("WAFInvalidParameterException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","WAFInvalidParameterException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = CreateWebACLResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void CreateWebACL_WAFInvalidResourceExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("CreateWebACL");

            var request = InstantiateClassGenerator.Execute<CreateWebACLRequest>();
            var marshaller = new CreateWebACLRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<CreateWebACLRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("WAFInvalidResourceException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","WAFInvalidResourceException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = CreateWebACLResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void CreateWebACL_WAFLimitsExceededExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("CreateWebACL");

            var request = InstantiateClassGenerator.Execute<CreateWebACLRequest>();
            var marshaller = new CreateWebACLRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<CreateWebACLRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("WAFLimitsExceededException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","WAFLimitsExceededException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = CreateWebACLResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void CreateWebACL_WAFNonexistentItemExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("CreateWebACL");

            var request = InstantiateClassGenerator.Execute<CreateWebACLRequest>();
            var marshaller = new CreateWebACLRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<CreateWebACLRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("WAFNonexistentItemException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","WAFNonexistentItemException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = CreateWebACLResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void CreateWebACL_WAFOptimisticLockExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("CreateWebACL");

            var request = InstantiateClassGenerator.Execute<CreateWebACLRequest>();
            var marshaller = new CreateWebACLRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<CreateWebACLRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("WAFOptimisticLockException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","WAFOptimisticLockException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = CreateWebACLResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void CreateWebACL_WAFSubscriptionNotFoundExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("CreateWebACL");

            var request = InstantiateClassGenerator.Execute<CreateWebACLRequest>();
            var marshaller = new CreateWebACLRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<CreateWebACLRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("WAFSubscriptionNotFoundException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","WAFSubscriptionNotFoundException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = CreateWebACLResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void CreateWebACL_WAFTagOperationExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("CreateWebACL");

            var request = InstantiateClassGenerator.Execute<CreateWebACLRequest>();
            var marshaller = new CreateWebACLRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<CreateWebACLRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("WAFTagOperationException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","WAFTagOperationException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = CreateWebACLResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void CreateWebACL_WAFTagOperationInternalErrorExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("CreateWebACL");

            var request = InstantiateClassGenerator.Execute<CreateWebACLRequest>();
            var marshaller = new CreateWebACLRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<CreateWebACLRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("WAFTagOperationInternalErrorException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","WAFTagOperationInternalErrorException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = CreateWebACLResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void CreateWebACL_WAFUnavailableEntityExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("CreateWebACL");

            var request = InstantiateClassGenerator.Execute<CreateWebACLRequest>();
            var marshaller = new CreateWebACLRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<CreateWebACLRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("WAFUnavailableEntityException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","WAFUnavailableEntityException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = CreateWebACLResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void DeleteFirewallManagerRuleGroupsMarshallTest()
        {
            var request = InstantiateClassGenerator.Execute<DeleteFirewallManagerRuleGroupsRequest>();
            var marshaller = new DeleteFirewallManagerRuleGroupsRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);
            Comparer.CompareObjectToJson<DeleteFirewallManagerRuleGroupsRequest>(request,jsonRequest);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            var jsonResponse = new JsonSampleGenerator(service_model, service_model.FindOperation("DeleteFirewallManagerRuleGroups").ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString());
            UnmarshallerContext context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), false, webResponse);
            var response = DeleteFirewallManagerRuleGroupsResponseUnmarshaller.Instance.Unmarshall(context) as DeleteFirewallManagerRuleGroupsResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void DeleteFirewallManagerRuleGroups_WAFInternalErrorExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("DeleteFirewallManagerRuleGroups");

            var request = InstantiateClassGenerator.Execute<DeleteFirewallManagerRuleGroupsRequest>();
            var marshaller = new DeleteFirewallManagerRuleGroupsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<DeleteFirewallManagerRuleGroupsRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("WAFInternalErrorException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","WAFInternalErrorException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = DeleteFirewallManagerRuleGroupsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void DeleteFirewallManagerRuleGroups_WAFInvalidOperationExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("DeleteFirewallManagerRuleGroups");

            var request = InstantiateClassGenerator.Execute<DeleteFirewallManagerRuleGroupsRequest>();
            var marshaller = new DeleteFirewallManagerRuleGroupsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<DeleteFirewallManagerRuleGroupsRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("WAFInvalidOperationException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","WAFInvalidOperationException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = DeleteFirewallManagerRuleGroupsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void DeleteFirewallManagerRuleGroups_WAFInvalidParameterExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("DeleteFirewallManagerRuleGroups");

            var request = InstantiateClassGenerator.Execute<DeleteFirewallManagerRuleGroupsRequest>();
            var marshaller = new DeleteFirewallManagerRuleGroupsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<DeleteFirewallManagerRuleGroupsRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("WAFInvalidParameterException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","WAFInvalidParameterException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = DeleteFirewallManagerRuleGroupsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void DeleteFirewallManagerRuleGroups_WAFNonexistentItemExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("DeleteFirewallManagerRuleGroups");

            var request = InstantiateClassGenerator.Execute<DeleteFirewallManagerRuleGroupsRequest>();
            var marshaller = new DeleteFirewallManagerRuleGroupsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<DeleteFirewallManagerRuleGroupsRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("WAFNonexistentItemException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","WAFNonexistentItemException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = DeleteFirewallManagerRuleGroupsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void DeleteFirewallManagerRuleGroups_WAFOptimisticLockExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("DeleteFirewallManagerRuleGroups");

            var request = InstantiateClassGenerator.Execute<DeleteFirewallManagerRuleGroupsRequest>();
            var marshaller = new DeleteFirewallManagerRuleGroupsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<DeleteFirewallManagerRuleGroupsRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("WAFOptimisticLockException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","WAFOptimisticLockException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = DeleteFirewallManagerRuleGroupsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void DeleteIPSetMarshallTest()
        {
            var request = InstantiateClassGenerator.Execute<DeleteIPSetRequest>();
            var marshaller = new DeleteIPSetRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);
            Comparer.CompareObjectToJson<DeleteIPSetRequest>(request,jsonRequest);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            var jsonResponse = new JsonSampleGenerator(service_model, service_model.FindOperation("DeleteIPSet").ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString());
            UnmarshallerContext context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), false, webResponse);
            var response = DeleteIPSetResponseUnmarshaller.Instance.Unmarshall(context) as DeleteIPSetResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void DeleteIPSet_WAFAssociatedItemExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("DeleteIPSet");

            var request = InstantiateClassGenerator.Execute<DeleteIPSetRequest>();
            var marshaller = new DeleteIPSetRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<DeleteIPSetRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("WAFAssociatedItemException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","WAFAssociatedItemException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = DeleteIPSetResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void DeleteIPSet_WAFInternalErrorExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("DeleteIPSet");

            var request = InstantiateClassGenerator.Execute<DeleteIPSetRequest>();
            var marshaller = new DeleteIPSetRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<DeleteIPSetRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("WAFInternalErrorException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","WAFInternalErrorException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = DeleteIPSetResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void DeleteIPSet_WAFInvalidOperationExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("DeleteIPSet");

            var request = InstantiateClassGenerator.Execute<DeleteIPSetRequest>();
            var marshaller = new DeleteIPSetRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<DeleteIPSetRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("WAFInvalidOperationException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","WAFInvalidOperationException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = DeleteIPSetResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void DeleteIPSet_WAFInvalidParameterExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("DeleteIPSet");

            var request = InstantiateClassGenerator.Execute<DeleteIPSetRequest>();
            var marshaller = new DeleteIPSetRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<DeleteIPSetRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("WAFInvalidParameterException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","WAFInvalidParameterException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = DeleteIPSetResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void DeleteIPSet_WAFNonexistentItemExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("DeleteIPSet");

            var request = InstantiateClassGenerator.Execute<DeleteIPSetRequest>();
            var marshaller = new DeleteIPSetRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<DeleteIPSetRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("WAFNonexistentItemException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","WAFNonexistentItemException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = DeleteIPSetResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void DeleteIPSet_WAFOptimisticLockExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("DeleteIPSet");

            var request = InstantiateClassGenerator.Execute<DeleteIPSetRequest>();
            var marshaller = new DeleteIPSetRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<DeleteIPSetRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("WAFOptimisticLockException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","WAFOptimisticLockException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = DeleteIPSetResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void DeleteIPSet_WAFTagOperationExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("DeleteIPSet");

            var request = InstantiateClassGenerator.Execute<DeleteIPSetRequest>();
            var marshaller = new DeleteIPSetRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<DeleteIPSetRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("WAFTagOperationException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","WAFTagOperationException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = DeleteIPSetResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void DeleteIPSet_WAFTagOperationInternalErrorExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("DeleteIPSet");

            var request = InstantiateClassGenerator.Execute<DeleteIPSetRequest>();
            var marshaller = new DeleteIPSetRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<DeleteIPSetRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("WAFTagOperationInternalErrorException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","WAFTagOperationInternalErrorException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = DeleteIPSetResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void DeleteLoggingConfigurationMarshallTest()
        {
            var request = InstantiateClassGenerator.Execute<DeleteLoggingConfigurationRequest>();
            var marshaller = new DeleteLoggingConfigurationRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);
            Comparer.CompareObjectToJson<DeleteLoggingConfigurationRequest>(request,jsonRequest);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            var jsonResponse = new JsonSampleGenerator(service_model, service_model.FindOperation("DeleteLoggingConfiguration").ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString());
            UnmarshallerContext context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), false, webResponse);
            var response = DeleteLoggingConfigurationResponseUnmarshaller.Instance.Unmarshall(context) as DeleteLoggingConfigurationResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void DeleteLoggingConfiguration_WAFInternalErrorExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("DeleteLoggingConfiguration");

            var request = InstantiateClassGenerator.Execute<DeleteLoggingConfigurationRequest>();
            var marshaller = new DeleteLoggingConfigurationRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<DeleteLoggingConfigurationRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("WAFInternalErrorException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","WAFInternalErrorException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = DeleteLoggingConfigurationResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void DeleteLoggingConfiguration_WAFInvalidOperationExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("DeleteLoggingConfiguration");

            var request = InstantiateClassGenerator.Execute<DeleteLoggingConfigurationRequest>();
            var marshaller = new DeleteLoggingConfigurationRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<DeleteLoggingConfigurationRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("WAFInvalidOperationException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","WAFInvalidOperationException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = DeleteLoggingConfigurationResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void DeleteLoggingConfiguration_WAFInvalidParameterExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("DeleteLoggingConfiguration");

            var request = InstantiateClassGenerator.Execute<DeleteLoggingConfigurationRequest>();
            var marshaller = new DeleteLoggingConfigurationRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<DeleteLoggingConfigurationRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("WAFInvalidParameterException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","WAFInvalidParameterException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = DeleteLoggingConfigurationResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void DeleteLoggingConfiguration_WAFNonexistentItemExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("DeleteLoggingConfiguration");

            var request = InstantiateClassGenerator.Execute<DeleteLoggingConfigurationRequest>();
            var marshaller = new DeleteLoggingConfigurationRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<DeleteLoggingConfigurationRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("WAFNonexistentItemException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","WAFNonexistentItemException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = DeleteLoggingConfigurationResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void DeleteLoggingConfiguration_WAFOptimisticLockExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("DeleteLoggingConfiguration");

            var request = InstantiateClassGenerator.Execute<DeleteLoggingConfigurationRequest>();
            var marshaller = new DeleteLoggingConfigurationRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<DeleteLoggingConfigurationRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("WAFOptimisticLockException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","WAFOptimisticLockException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = DeleteLoggingConfigurationResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void DeletePermissionPolicyMarshallTest()
        {
            var request = InstantiateClassGenerator.Execute<DeletePermissionPolicyRequest>();
            var marshaller = new DeletePermissionPolicyRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);
            Comparer.CompareObjectToJson<DeletePermissionPolicyRequest>(request,jsonRequest);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            var jsonResponse = new JsonSampleGenerator(service_model, service_model.FindOperation("DeletePermissionPolicy").ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString());
            UnmarshallerContext context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), false, webResponse);
            var response = DeletePermissionPolicyResponseUnmarshaller.Instance.Unmarshall(context) as DeletePermissionPolicyResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void DeletePermissionPolicy_WAFInternalErrorExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("DeletePermissionPolicy");

            var request = InstantiateClassGenerator.Execute<DeletePermissionPolicyRequest>();
            var marshaller = new DeletePermissionPolicyRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<DeletePermissionPolicyRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("WAFInternalErrorException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","WAFInternalErrorException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = DeletePermissionPolicyResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void DeletePermissionPolicy_WAFInvalidParameterExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("DeletePermissionPolicy");

            var request = InstantiateClassGenerator.Execute<DeletePermissionPolicyRequest>();
            var marshaller = new DeletePermissionPolicyRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<DeletePermissionPolicyRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("WAFInvalidParameterException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","WAFInvalidParameterException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = DeletePermissionPolicyResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void DeletePermissionPolicy_WAFNonexistentItemExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("DeletePermissionPolicy");

            var request = InstantiateClassGenerator.Execute<DeletePermissionPolicyRequest>();
            var marshaller = new DeletePermissionPolicyRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<DeletePermissionPolicyRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("WAFNonexistentItemException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","WAFNonexistentItemException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = DeletePermissionPolicyResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void DeleteRegexPatternSetMarshallTest()
        {
            var request = InstantiateClassGenerator.Execute<DeleteRegexPatternSetRequest>();
            var marshaller = new DeleteRegexPatternSetRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);
            Comparer.CompareObjectToJson<DeleteRegexPatternSetRequest>(request,jsonRequest);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            var jsonResponse = new JsonSampleGenerator(service_model, service_model.FindOperation("DeleteRegexPatternSet").ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString());
            UnmarshallerContext context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), false, webResponse);
            var response = DeleteRegexPatternSetResponseUnmarshaller.Instance.Unmarshall(context) as DeleteRegexPatternSetResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void DeleteRegexPatternSet_WAFAssociatedItemExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("DeleteRegexPatternSet");

            var request = InstantiateClassGenerator.Execute<DeleteRegexPatternSetRequest>();
            var marshaller = new DeleteRegexPatternSetRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<DeleteRegexPatternSetRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("WAFAssociatedItemException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","WAFAssociatedItemException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = DeleteRegexPatternSetResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void DeleteRegexPatternSet_WAFInternalErrorExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("DeleteRegexPatternSet");

            var request = InstantiateClassGenerator.Execute<DeleteRegexPatternSetRequest>();
            var marshaller = new DeleteRegexPatternSetRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<DeleteRegexPatternSetRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("WAFInternalErrorException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","WAFInternalErrorException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = DeleteRegexPatternSetResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void DeleteRegexPatternSet_WAFInvalidOperationExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("DeleteRegexPatternSet");

            var request = InstantiateClassGenerator.Execute<DeleteRegexPatternSetRequest>();
            var marshaller = new DeleteRegexPatternSetRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<DeleteRegexPatternSetRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("WAFInvalidOperationException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","WAFInvalidOperationException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = DeleteRegexPatternSetResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void DeleteRegexPatternSet_WAFInvalidParameterExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("DeleteRegexPatternSet");

            var request = InstantiateClassGenerator.Execute<DeleteRegexPatternSetRequest>();
            var marshaller = new DeleteRegexPatternSetRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<DeleteRegexPatternSetRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("WAFInvalidParameterException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","WAFInvalidParameterException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = DeleteRegexPatternSetResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void DeleteRegexPatternSet_WAFNonexistentItemExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("DeleteRegexPatternSet");

            var request = InstantiateClassGenerator.Execute<DeleteRegexPatternSetRequest>();
            var marshaller = new DeleteRegexPatternSetRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<DeleteRegexPatternSetRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("WAFNonexistentItemException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","WAFNonexistentItemException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = DeleteRegexPatternSetResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void DeleteRegexPatternSet_WAFOptimisticLockExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("DeleteRegexPatternSet");

            var request = InstantiateClassGenerator.Execute<DeleteRegexPatternSetRequest>();
            var marshaller = new DeleteRegexPatternSetRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<DeleteRegexPatternSetRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("WAFOptimisticLockException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","WAFOptimisticLockException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = DeleteRegexPatternSetResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void DeleteRegexPatternSet_WAFTagOperationExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("DeleteRegexPatternSet");

            var request = InstantiateClassGenerator.Execute<DeleteRegexPatternSetRequest>();
            var marshaller = new DeleteRegexPatternSetRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<DeleteRegexPatternSetRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("WAFTagOperationException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","WAFTagOperationException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = DeleteRegexPatternSetResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void DeleteRegexPatternSet_WAFTagOperationInternalErrorExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("DeleteRegexPatternSet");

            var request = InstantiateClassGenerator.Execute<DeleteRegexPatternSetRequest>();
            var marshaller = new DeleteRegexPatternSetRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<DeleteRegexPatternSetRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("WAFTagOperationInternalErrorException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","WAFTagOperationInternalErrorException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = DeleteRegexPatternSetResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void DeleteRuleGroupMarshallTest()
        {
            var request = InstantiateClassGenerator.Execute<DeleteRuleGroupRequest>();
            var marshaller = new DeleteRuleGroupRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);
            Comparer.CompareObjectToJson<DeleteRuleGroupRequest>(request,jsonRequest);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            var jsonResponse = new JsonSampleGenerator(service_model, service_model.FindOperation("DeleteRuleGroup").ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString());
            UnmarshallerContext context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), false, webResponse);
            var response = DeleteRuleGroupResponseUnmarshaller.Instance.Unmarshall(context) as DeleteRuleGroupResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void DeleteRuleGroup_WAFAssociatedItemExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("DeleteRuleGroup");

            var request = InstantiateClassGenerator.Execute<DeleteRuleGroupRequest>();
            var marshaller = new DeleteRuleGroupRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<DeleteRuleGroupRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("WAFAssociatedItemException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","WAFAssociatedItemException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = DeleteRuleGroupResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void DeleteRuleGroup_WAFInternalErrorExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("DeleteRuleGroup");

            var request = InstantiateClassGenerator.Execute<DeleteRuleGroupRequest>();
            var marshaller = new DeleteRuleGroupRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<DeleteRuleGroupRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("WAFInternalErrorException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","WAFInternalErrorException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = DeleteRuleGroupResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void DeleteRuleGroup_WAFInvalidOperationExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("DeleteRuleGroup");

            var request = InstantiateClassGenerator.Execute<DeleteRuleGroupRequest>();
            var marshaller = new DeleteRuleGroupRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<DeleteRuleGroupRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("WAFInvalidOperationException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","WAFInvalidOperationException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = DeleteRuleGroupResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void DeleteRuleGroup_WAFInvalidParameterExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("DeleteRuleGroup");

            var request = InstantiateClassGenerator.Execute<DeleteRuleGroupRequest>();
            var marshaller = new DeleteRuleGroupRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<DeleteRuleGroupRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("WAFInvalidParameterException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","WAFInvalidParameterException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = DeleteRuleGroupResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void DeleteRuleGroup_WAFNonexistentItemExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("DeleteRuleGroup");

            var request = InstantiateClassGenerator.Execute<DeleteRuleGroupRequest>();
            var marshaller = new DeleteRuleGroupRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<DeleteRuleGroupRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("WAFNonexistentItemException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","WAFNonexistentItemException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = DeleteRuleGroupResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void DeleteRuleGroup_WAFOptimisticLockExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("DeleteRuleGroup");

            var request = InstantiateClassGenerator.Execute<DeleteRuleGroupRequest>();
            var marshaller = new DeleteRuleGroupRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<DeleteRuleGroupRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("WAFOptimisticLockException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","WAFOptimisticLockException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = DeleteRuleGroupResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void DeleteRuleGroup_WAFTagOperationExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("DeleteRuleGroup");

            var request = InstantiateClassGenerator.Execute<DeleteRuleGroupRequest>();
            var marshaller = new DeleteRuleGroupRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<DeleteRuleGroupRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("WAFTagOperationException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","WAFTagOperationException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = DeleteRuleGroupResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void DeleteRuleGroup_WAFTagOperationInternalErrorExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("DeleteRuleGroup");

            var request = InstantiateClassGenerator.Execute<DeleteRuleGroupRequest>();
            var marshaller = new DeleteRuleGroupRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<DeleteRuleGroupRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("WAFTagOperationInternalErrorException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","WAFTagOperationInternalErrorException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = DeleteRuleGroupResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void DeleteWebACLMarshallTest()
        {
            var request = InstantiateClassGenerator.Execute<DeleteWebACLRequest>();
            var marshaller = new DeleteWebACLRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);
            Comparer.CompareObjectToJson<DeleteWebACLRequest>(request,jsonRequest);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            var jsonResponse = new JsonSampleGenerator(service_model, service_model.FindOperation("DeleteWebACL").ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString());
            UnmarshallerContext context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), false, webResponse);
            var response = DeleteWebACLResponseUnmarshaller.Instance.Unmarshall(context) as DeleteWebACLResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void DeleteWebACL_WAFAssociatedItemExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("DeleteWebACL");

            var request = InstantiateClassGenerator.Execute<DeleteWebACLRequest>();
            var marshaller = new DeleteWebACLRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<DeleteWebACLRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("WAFAssociatedItemException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","WAFAssociatedItemException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = DeleteWebACLResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void DeleteWebACL_WAFInternalErrorExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("DeleteWebACL");

            var request = InstantiateClassGenerator.Execute<DeleteWebACLRequest>();
            var marshaller = new DeleteWebACLRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<DeleteWebACLRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("WAFInternalErrorException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","WAFInternalErrorException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = DeleteWebACLResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void DeleteWebACL_WAFInvalidOperationExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("DeleteWebACL");

            var request = InstantiateClassGenerator.Execute<DeleteWebACLRequest>();
            var marshaller = new DeleteWebACLRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<DeleteWebACLRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("WAFInvalidOperationException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","WAFInvalidOperationException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = DeleteWebACLResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void DeleteWebACL_WAFInvalidParameterExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("DeleteWebACL");

            var request = InstantiateClassGenerator.Execute<DeleteWebACLRequest>();
            var marshaller = new DeleteWebACLRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<DeleteWebACLRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("WAFInvalidParameterException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","WAFInvalidParameterException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = DeleteWebACLResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void DeleteWebACL_WAFNonexistentItemExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("DeleteWebACL");

            var request = InstantiateClassGenerator.Execute<DeleteWebACLRequest>();
            var marshaller = new DeleteWebACLRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<DeleteWebACLRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("WAFNonexistentItemException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","WAFNonexistentItemException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = DeleteWebACLResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void DeleteWebACL_WAFOptimisticLockExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("DeleteWebACL");

            var request = InstantiateClassGenerator.Execute<DeleteWebACLRequest>();
            var marshaller = new DeleteWebACLRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<DeleteWebACLRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("WAFOptimisticLockException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","WAFOptimisticLockException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = DeleteWebACLResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void DeleteWebACL_WAFTagOperationExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("DeleteWebACL");

            var request = InstantiateClassGenerator.Execute<DeleteWebACLRequest>();
            var marshaller = new DeleteWebACLRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<DeleteWebACLRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("WAFTagOperationException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","WAFTagOperationException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = DeleteWebACLResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void DeleteWebACL_WAFTagOperationInternalErrorExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("DeleteWebACL");

            var request = InstantiateClassGenerator.Execute<DeleteWebACLRequest>();
            var marshaller = new DeleteWebACLRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<DeleteWebACLRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("WAFTagOperationInternalErrorException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","WAFTagOperationInternalErrorException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = DeleteWebACLResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void DescribeManagedRuleGroupMarshallTest()
        {
            var request = InstantiateClassGenerator.Execute<DescribeManagedRuleGroupRequest>();
            var marshaller = new DescribeManagedRuleGroupRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);
            Comparer.CompareObjectToJson<DescribeManagedRuleGroupRequest>(request,jsonRequest);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            var jsonResponse = new JsonSampleGenerator(service_model, service_model.FindOperation("DescribeManagedRuleGroup").ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString());
            UnmarshallerContext context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), false, webResponse);
            var response = DescribeManagedRuleGroupResponseUnmarshaller.Instance.Unmarshall(context) as DescribeManagedRuleGroupResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void DescribeManagedRuleGroup_WAFExpiredManagedRuleGroupVersionExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("DescribeManagedRuleGroup");

            var request = InstantiateClassGenerator.Execute<DescribeManagedRuleGroupRequest>();
            var marshaller = new DescribeManagedRuleGroupRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<DescribeManagedRuleGroupRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("WAFExpiredManagedRuleGroupVersionException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","WAFExpiredManagedRuleGroupVersionException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = DescribeManagedRuleGroupResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void DescribeManagedRuleGroup_WAFInternalErrorExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("DescribeManagedRuleGroup");

            var request = InstantiateClassGenerator.Execute<DescribeManagedRuleGroupRequest>();
            var marshaller = new DescribeManagedRuleGroupRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<DescribeManagedRuleGroupRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("WAFInternalErrorException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","WAFInternalErrorException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = DescribeManagedRuleGroupResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void DescribeManagedRuleGroup_WAFInvalidOperationExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("DescribeManagedRuleGroup");

            var request = InstantiateClassGenerator.Execute<DescribeManagedRuleGroupRequest>();
            var marshaller = new DescribeManagedRuleGroupRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<DescribeManagedRuleGroupRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("WAFInvalidOperationException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","WAFInvalidOperationException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = DescribeManagedRuleGroupResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void DescribeManagedRuleGroup_WAFInvalidParameterExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("DescribeManagedRuleGroup");

            var request = InstantiateClassGenerator.Execute<DescribeManagedRuleGroupRequest>();
            var marshaller = new DescribeManagedRuleGroupRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<DescribeManagedRuleGroupRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("WAFInvalidParameterException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","WAFInvalidParameterException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = DescribeManagedRuleGroupResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void DescribeManagedRuleGroup_WAFInvalidResourceExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("DescribeManagedRuleGroup");

            var request = InstantiateClassGenerator.Execute<DescribeManagedRuleGroupRequest>();
            var marshaller = new DescribeManagedRuleGroupRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<DescribeManagedRuleGroupRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("WAFInvalidResourceException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","WAFInvalidResourceException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = DescribeManagedRuleGroupResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void DescribeManagedRuleGroup_WAFNonexistentItemExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("DescribeManagedRuleGroup");

            var request = InstantiateClassGenerator.Execute<DescribeManagedRuleGroupRequest>();
            var marshaller = new DescribeManagedRuleGroupRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<DescribeManagedRuleGroupRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("WAFNonexistentItemException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","WAFNonexistentItemException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = DescribeManagedRuleGroupResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void DisassociateWebACLMarshallTest()
        {
            var request = InstantiateClassGenerator.Execute<DisassociateWebACLRequest>();
            var marshaller = new DisassociateWebACLRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);
            Comparer.CompareObjectToJson<DisassociateWebACLRequest>(request,jsonRequest);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            var jsonResponse = new JsonSampleGenerator(service_model, service_model.FindOperation("DisassociateWebACL").ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString());
            UnmarshallerContext context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), false, webResponse);
            var response = DisassociateWebACLResponseUnmarshaller.Instance.Unmarshall(context) as DisassociateWebACLResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void DisassociateWebACL_WAFInternalErrorExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("DisassociateWebACL");

            var request = InstantiateClassGenerator.Execute<DisassociateWebACLRequest>();
            var marshaller = new DisassociateWebACLRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<DisassociateWebACLRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("WAFInternalErrorException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","WAFInternalErrorException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = DisassociateWebACLResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void DisassociateWebACL_WAFInvalidOperationExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("DisassociateWebACL");

            var request = InstantiateClassGenerator.Execute<DisassociateWebACLRequest>();
            var marshaller = new DisassociateWebACLRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<DisassociateWebACLRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("WAFInvalidOperationException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","WAFInvalidOperationException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = DisassociateWebACLResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void DisassociateWebACL_WAFInvalidParameterExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("DisassociateWebACL");

            var request = InstantiateClassGenerator.Execute<DisassociateWebACLRequest>();
            var marshaller = new DisassociateWebACLRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<DisassociateWebACLRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("WAFInvalidParameterException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","WAFInvalidParameterException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = DisassociateWebACLResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void DisassociateWebACL_WAFNonexistentItemExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("DisassociateWebACL");

            var request = InstantiateClassGenerator.Execute<DisassociateWebACLRequest>();
            var marshaller = new DisassociateWebACLRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<DisassociateWebACLRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("WAFNonexistentItemException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","WAFNonexistentItemException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = DisassociateWebACLResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void GenerateMobileSdkReleaseUrlMarshallTest()
        {
            var request = InstantiateClassGenerator.Execute<GenerateMobileSdkReleaseUrlRequest>();
            var marshaller = new GenerateMobileSdkReleaseUrlRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);
            Comparer.CompareObjectToJson<GenerateMobileSdkReleaseUrlRequest>(request,jsonRequest);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            var jsonResponse = new JsonSampleGenerator(service_model, service_model.FindOperation("GenerateMobileSdkReleaseUrl").ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString());
            UnmarshallerContext context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), false, webResponse);
            var response = GenerateMobileSdkReleaseUrlResponseUnmarshaller.Instance.Unmarshall(context) as GenerateMobileSdkReleaseUrlResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void GenerateMobileSdkReleaseUrl_WAFInternalErrorExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("GenerateMobileSdkReleaseUrl");

            var request = InstantiateClassGenerator.Execute<GenerateMobileSdkReleaseUrlRequest>();
            var marshaller = new GenerateMobileSdkReleaseUrlRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<GenerateMobileSdkReleaseUrlRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("WAFInternalErrorException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","WAFInternalErrorException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = GenerateMobileSdkReleaseUrlResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void GenerateMobileSdkReleaseUrl_WAFInvalidOperationExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("GenerateMobileSdkReleaseUrl");

            var request = InstantiateClassGenerator.Execute<GenerateMobileSdkReleaseUrlRequest>();
            var marshaller = new GenerateMobileSdkReleaseUrlRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<GenerateMobileSdkReleaseUrlRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("WAFInvalidOperationException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","WAFInvalidOperationException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = GenerateMobileSdkReleaseUrlResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void GenerateMobileSdkReleaseUrl_WAFInvalidParameterExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("GenerateMobileSdkReleaseUrl");

            var request = InstantiateClassGenerator.Execute<GenerateMobileSdkReleaseUrlRequest>();
            var marshaller = new GenerateMobileSdkReleaseUrlRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<GenerateMobileSdkReleaseUrlRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("WAFInvalidParameterException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","WAFInvalidParameterException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = GenerateMobileSdkReleaseUrlResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void GenerateMobileSdkReleaseUrl_WAFNonexistentItemExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("GenerateMobileSdkReleaseUrl");

            var request = InstantiateClassGenerator.Execute<GenerateMobileSdkReleaseUrlRequest>();
            var marshaller = new GenerateMobileSdkReleaseUrlRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<GenerateMobileSdkReleaseUrlRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("WAFNonexistentItemException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","WAFNonexistentItemException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = GenerateMobileSdkReleaseUrlResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void GetIPSetMarshallTest()
        {
            var request = InstantiateClassGenerator.Execute<GetIPSetRequest>();
            var marshaller = new GetIPSetRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);
            Comparer.CompareObjectToJson<GetIPSetRequest>(request,jsonRequest);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            var jsonResponse = new JsonSampleGenerator(service_model, service_model.FindOperation("GetIPSet").ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString());
            UnmarshallerContext context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), false, webResponse);
            var response = GetIPSetResponseUnmarshaller.Instance.Unmarshall(context) as GetIPSetResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void GetIPSet_WAFInternalErrorExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("GetIPSet");

            var request = InstantiateClassGenerator.Execute<GetIPSetRequest>();
            var marshaller = new GetIPSetRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<GetIPSetRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("WAFInternalErrorException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","WAFInternalErrorException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = GetIPSetResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void GetIPSet_WAFInvalidOperationExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("GetIPSet");

            var request = InstantiateClassGenerator.Execute<GetIPSetRequest>();
            var marshaller = new GetIPSetRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<GetIPSetRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("WAFInvalidOperationException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","WAFInvalidOperationException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = GetIPSetResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void GetIPSet_WAFInvalidParameterExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("GetIPSet");

            var request = InstantiateClassGenerator.Execute<GetIPSetRequest>();
            var marshaller = new GetIPSetRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<GetIPSetRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("WAFInvalidParameterException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","WAFInvalidParameterException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = GetIPSetResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void GetIPSet_WAFNonexistentItemExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("GetIPSet");

            var request = InstantiateClassGenerator.Execute<GetIPSetRequest>();
            var marshaller = new GetIPSetRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<GetIPSetRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("WAFNonexistentItemException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","WAFNonexistentItemException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = GetIPSetResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void GetLoggingConfigurationMarshallTest()
        {
            var request = InstantiateClassGenerator.Execute<GetLoggingConfigurationRequest>();
            var marshaller = new GetLoggingConfigurationRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);
            Comparer.CompareObjectToJson<GetLoggingConfigurationRequest>(request,jsonRequest);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            var jsonResponse = new JsonSampleGenerator(service_model, service_model.FindOperation("GetLoggingConfiguration").ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString());
            UnmarshallerContext context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), false, webResponse);
            var response = GetLoggingConfigurationResponseUnmarshaller.Instance.Unmarshall(context) as GetLoggingConfigurationResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void GetLoggingConfiguration_WAFInternalErrorExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("GetLoggingConfiguration");

            var request = InstantiateClassGenerator.Execute<GetLoggingConfigurationRequest>();
            var marshaller = new GetLoggingConfigurationRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<GetLoggingConfigurationRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("WAFInternalErrorException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","WAFInternalErrorException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = GetLoggingConfigurationResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void GetLoggingConfiguration_WAFInvalidOperationExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("GetLoggingConfiguration");

            var request = InstantiateClassGenerator.Execute<GetLoggingConfigurationRequest>();
            var marshaller = new GetLoggingConfigurationRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<GetLoggingConfigurationRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("WAFInvalidOperationException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","WAFInvalidOperationException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = GetLoggingConfigurationResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void GetLoggingConfiguration_WAFInvalidParameterExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("GetLoggingConfiguration");

            var request = InstantiateClassGenerator.Execute<GetLoggingConfigurationRequest>();
            var marshaller = new GetLoggingConfigurationRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<GetLoggingConfigurationRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("WAFInvalidParameterException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","WAFInvalidParameterException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = GetLoggingConfigurationResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void GetLoggingConfiguration_WAFNonexistentItemExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("GetLoggingConfiguration");

            var request = InstantiateClassGenerator.Execute<GetLoggingConfigurationRequest>();
            var marshaller = new GetLoggingConfigurationRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<GetLoggingConfigurationRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("WAFNonexistentItemException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","WAFNonexistentItemException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = GetLoggingConfigurationResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void GetManagedRuleSetMarshallTest()
        {
            var request = InstantiateClassGenerator.Execute<GetManagedRuleSetRequest>();
            var marshaller = new GetManagedRuleSetRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);
            Comparer.CompareObjectToJson<GetManagedRuleSetRequest>(request,jsonRequest);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            var jsonResponse = new JsonSampleGenerator(service_model, service_model.FindOperation("GetManagedRuleSet").ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString());
            UnmarshallerContext context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), false, webResponse);
            var response = GetManagedRuleSetResponseUnmarshaller.Instance.Unmarshall(context) as GetManagedRuleSetResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void GetManagedRuleSet_WAFInternalErrorExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("GetManagedRuleSet");

            var request = InstantiateClassGenerator.Execute<GetManagedRuleSetRequest>();
            var marshaller = new GetManagedRuleSetRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<GetManagedRuleSetRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("WAFInternalErrorException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","WAFInternalErrorException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = GetManagedRuleSetResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void GetManagedRuleSet_WAFInvalidOperationExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("GetManagedRuleSet");

            var request = InstantiateClassGenerator.Execute<GetManagedRuleSetRequest>();
            var marshaller = new GetManagedRuleSetRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<GetManagedRuleSetRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("WAFInvalidOperationException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","WAFInvalidOperationException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = GetManagedRuleSetResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void GetManagedRuleSet_WAFInvalidParameterExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("GetManagedRuleSet");

            var request = InstantiateClassGenerator.Execute<GetManagedRuleSetRequest>();
            var marshaller = new GetManagedRuleSetRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<GetManagedRuleSetRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("WAFInvalidParameterException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","WAFInvalidParameterException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = GetManagedRuleSetResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void GetManagedRuleSet_WAFNonexistentItemExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("GetManagedRuleSet");

            var request = InstantiateClassGenerator.Execute<GetManagedRuleSetRequest>();
            var marshaller = new GetManagedRuleSetRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<GetManagedRuleSetRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("WAFNonexistentItemException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","WAFNonexistentItemException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = GetManagedRuleSetResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void GetMobileSdkReleaseMarshallTest()
        {
            var request = InstantiateClassGenerator.Execute<GetMobileSdkReleaseRequest>();
            var marshaller = new GetMobileSdkReleaseRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);
            Comparer.CompareObjectToJson<GetMobileSdkReleaseRequest>(request,jsonRequest);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            var jsonResponse = new JsonSampleGenerator(service_model, service_model.FindOperation("GetMobileSdkRelease").ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString());
            UnmarshallerContext context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), false, webResponse);
            var response = GetMobileSdkReleaseResponseUnmarshaller.Instance.Unmarshall(context) as GetMobileSdkReleaseResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void GetMobileSdkRelease_WAFInternalErrorExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("GetMobileSdkRelease");

            var request = InstantiateClassGenerator.Execute<GetMobileSdkReleaseRequest>();
            var marshaller = new GetMobileSdkReleaseRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<GetMobileSdkReleaseRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("WAFInternalErrorException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","WAFInternalErrorException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = GetMobileSdkReleaseResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void GetMobileSdkRelease_WAFInvalidOperationExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("GetMobileSdkRelease");

            var request = InstantiateClassGenerator.Execute<GetMobileSdkReleaseRequest>();
            var marshaller = new GetMobileSdkReleaseRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<GetMobileSdkReleaseRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("WAFInvalidOperationException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","WAFInvalidOperationException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = GetMobileSdkReleaseResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void GetMobileSdkRelease_WAFInvalidParameterExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("GetMobileSdkRelease");

            var request = InstantiateClassGenerator.Execute<GetMobileSdkReleaseRequest>();
            var marshaller = new GetMobileSdkReleaseRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<GetMobileSdkReleaseRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("WAFInvalidParameterException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","WAFInvalidParameterException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = GetMobileSdkReleaseResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void GetMobileSdkRelease_WAFNonexistentItemExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("GetMobileSdkRelease");

            var request = InstantiateClassGenerator.Execute<GetMobileSdkReleaseRequest>();
            var marshaller = new GetMobileSdkReleaseRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<GetMobileSdkReleaseRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("WAFNonexistentItemException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","WAFNonexistentItemException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = GetMobileSdkReleaseResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void GetPermissionPolicyMarshallTest()
        {
            var request = InstantiateClassGenerator.Execute<GetPermissionPolicyRequest>();
            var marshaller = new GetPermissionPolicyRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);
            Comparer.CompareObjectToJson<GetPermissionPolicyRequest>(request,jsonRequest);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            var jsonResponse = new JsonSampleGenerator(service_model, service_model.FindOperation("GetPermissionPolicy").ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString());
            UnmarshallerContext context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), false, webResponse);
            var response = GetPermissionPolicyResponseUnmarshaller.Instance.Unmarshall(context) as GetPermissionPolicyResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void GetPermissionPolicy_WAFInternalErrorExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("GetPermissionPolicy");

            var request = InstantiateClassGenerator.Execute<GetPermissionPolicyRequest>();
            var marshaller = new GetPermissionPolicyRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<GetPermissionPolicyRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("WAFInternalErrorException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","WAFInternalErrorException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = GetPermissionPolicyResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void GetPermissionPolicy_WAFInvalidParameterExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("GetPermissionPolicy");

            var request = InstantiateClassGenerator.Execute<GetPermissionPolicyRequest>();
            var marshaller = new GetPermissionPolicyRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<GetPermissionPolicyRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("WAFInvalidParameterException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","WAFInvalidParameterException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = GetPermissionPolicyResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void GetPermissionPolicy_WAFNonexistentItemExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("GetPermissionPolicy");

            var request = InstantiateClassGenerator.Execute<GetPermissionPolicyRequest>();
            var marshaller = new GetPermissionPolicyRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<GetPermissionPolicyRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("WAFNonexistentItemException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","WAFNonexistentItemException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = GetPermissionPolicyResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void GetRateBasedStatementManagedKeysMarshallTest()
        {
            var request = InstantiateClassGenerator.Execute<GetRateBasedStatementManagedKeysRequest>();
            var marshaller = new GetRateBasedStatementManagedKeysRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);
            Comparer.CompareObjectToJson<GetRateBasedStatementManagedKeysRequest>(request,jsonRequest);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            var jsonResponse = new JsonSampleGenerator(service_model, service_model.FindOperation("GetRateBasedStatementManagedKeys").ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString());
            UnmarshallerContext context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), false, webResponse);
            var response = GetRateBasedStatementManagedKeysResponseUnmarshaller.Instance.Unmarshall(context) as GetRateBasedStatementManagedKeysResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void GetRateBasedStatementManagedKeys_WAFInternalErrorExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("GetRateBasedStatementManagedKeys");

            var request = InstantiateClassGenerator.Execute<GetRateBasedStatementManagedKeysRequest>();
            var marshaller = new GetRateBasedStatementManagedKeysRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<GetRateBasedStatementManagedKeysRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("WAFInternalErrorException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","WAFInternalErrorException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = GetRateBasedStatementManagedKeysResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void GetRateBasedStatementManagedKeys_WAFInvalidOperationExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("GetRateBasedStatementManagedKeys");

            var request = InstantiateClassGenerator.Execute<GetRateBasedStatementManagedKeysRequest>();
            var marshaller = new GetRateBasedStatementManagedKeysRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<GetRateBasedStatementManagedKeysRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("WAFInvalidOperationException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","WAFInvalidOperationException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = GetRateBasedStatementManagedKeysResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void GetRateBasedStatementManagedKeys_WAFInvalidParameterExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("GetRateBasedStatementManagedKeys");

            var request = InstantiateClassGenerator.Execute<GetRateBasedStatementManagedKeysRequest>();
            var marshaller = new GetRateBasedStatementManagedKeysRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<GetRateBasedStatementManagedKeysRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("WAFInvalidParameterException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","WAFInvalidParameterException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = GetRateBasedStatementManagedKeysResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void GetRateBasedStatementManagedKeys_WAFNonexistentItemExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("GetRateBasedStatementManagedKeys");

            var request = InstantiateClassGenerator.Execute<GetRateBasedStatementManagedKeysRequest>();
            var marshaller = new GetRateBasedStatementManagedKeysRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<GetRateBasedStatementManagedKeysRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("WAFNonexistentItemException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","WAFNonexistentItemException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = GetRateBasedStatementManagedKeysResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void GetRegexPatternSetMarshallTest()
        {
            var request = InstantiateClassGenerator.Execute<GetRegexPatternSetRequest>();
            var marshaller = new GetRegexPatternSetRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);
            Comparer.CompareObjectToJson<GetRegexPatternSetRequest>(request,jsonRequest);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            var jsonResponse = new JsonSampleGenerator(service_model, service_model.FindOperation("GetRegexPatternSet").ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString());
            UnmarshallerContext context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), false, webResponse);
            var response = GetRegexPatternSetResponseUnmarshaller.Instance.Unmarshall(context) as GetRegexPatternSetResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void GetRegexPatternSet_WAFInternalErrorExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("GetRegexPatternSet");

            var request = InstantiateClassGenerator.Execute<GetRegexPatternSetRequest>();
            var marshaller = new GetRegexPatternSetRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<GetRegexPatternSetRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("WAFInternalErrorException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","WAFInternalErrorException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = GetRegexPatternSetResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void GetRegexPatternSet_WAFInvalidOperationExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("GetRegexPatternSet");

            var request = InstantiateClassGenerator.Execute<GetRegexPatternSetRequest>();
            var marshaller = new GetRegexPatternSetRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<GetRegexPatternSetRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("WAFInvalidOperationException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","WAFInvalidOperationException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = GetRegexPatternSetResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void GetRegexPatternSet_WAFInvalidParameterExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("GetRegexPatternSet");

            var request = InstantiateClassGenerator.Execute<GetRegexPatternSetRequest>();
            var marshaller = new GetRegexPatternSetRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<GetRegexPatternSetRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("WAFInvalidParameterException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","WAFInvalidParameterException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = GetRegexPatternSetResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void GetRegexPatternSet_WAFNonexistentItemExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("GetRegexPatternSet");

            var request = InstantiateClassGenerator.Execute<GetRegexPatternSetRequest>();
            var marshaller = new GetRegexPatternSetRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<GetRegexPatternSetRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("WAFNonexistentItemException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","WAFNonexistentItemException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = GetRegexPatternSetResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void GetRuleGroupMarshallTest()
        {
            var request = InstantiateClassGenerator.Execute<GetRuleGroupRequest>();
            var marshaller = new GetRuleGroupRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);
            Comparer.CompareObjectToJson<GetRuleGroupRequest>(request,jsonRequest);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            var jsonResponse = new JsonSampleGenerator(service_model, service_model.FindOperation("GetRuleGroup").ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString());
            UnmarshallerContext context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), false, webResponse);
            var response = GetRuleGroupResponseUnmarshaller.Instance.Unmarshall(context) as GetRuleGroupResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void GetRuleGroup_WAFInternalErrorExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("GetRuleGroup");

            var request = InstantiateClassGenerator.Execute<GetRuleGroupRequest>();
            var marshaller = new GetRuleGroupRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<GetRuleGroupRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("WAFInternalErrorException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","WAFInternalErrorException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = GetRuleGroupResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void GetRuleGroup_WAFInvalidOperationExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("GetRuleGroup");

            var request = InstantiateClassGenerator.Execute<GetRuleGroupRequest>();
            var marshaller = new GetRuleGroupRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<GetRuleGroupRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("WAFInvalidOperationException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","WAFInvalidOperationException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = GetRuleGroupResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void GetRuleGroup_WAFInvalidParameterExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("GetRuleGroup");

            var request = InstantiateClassGenerator.Execute<GetRuleGroupRequest>();
            var marshaller = new GetRuleGroupRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<GetRuleGroupRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("WAFInvalidParameterException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","WAFInvalidParameterException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = GetRuleGroupResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void GetRuleGroup_WAFNonexistentItemExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("GetRuleGroup");

            var request = InstantiateClassGenerator.Execute<GetRuleGroupRequest>();
            var marshaller = new GetRuleGroupRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<GetRuleGroupRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("WAFNonexistentItemException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","WAFNonexistentItemException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = GetRuleGroupResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void GetSampledRequestsMarshallTest()
        {
            var request = InstantiateClassGenerator.Execute<GetSampledRequestsRequest>();
            var marshaller = new GetSampledRequestsRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);
            Comparer.CompareObjectToJson<GetSampledRequestsRequest>(request,jsonRequest);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            var jsonResponse = new JsonSampleGenerator(service_model, service_model.FindOperation("GetSampledRequests").ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString());
            UnmarshallerContext context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), false, webResponse);
            var response = GetSampledRequestsResponseUnmarshaller.Instance.Unmarshall(context) as GetSampledRequestsResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void GetSampledRequests_WAFInternalErrorExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("GetSampledRequests");

            var request = InstantiateClassGenerator.Execute<GetSampledRequestsRequest>();
            var marshaller = new GetSampledRequestsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<GetSampledRequestsRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("WAFInternalErrorException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","WAFInternalErrorException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = GetSampledRequestsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void GetSampledRequests_WAFInvalidParameterExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("GetSampledRequests");

            var request = InstantiateClassGenerator.Execute<GetSampledRequestsRequest>();
            var marshaller = new GetSampledRequestsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<GetSampledRequestsRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("WAFInvalidParameterException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","WAFInvalidParameterException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = GetSampledRequestsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void GetSampledRequests_WAFNonexistentItemExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("GetSampledRequests");

            var request = InstantiateClassGenerator.Execute<GetSampledRequestsRequest>();
            var marshaller = new GetSampledRequestsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<GetSampledRequestsRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("WAFNonexistentItemException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","WAFNonexistentItemException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = GetSampledRequestsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void GetWebACLMarshallTest()
        {
            var request = InstantiateClassGenerator.Execute<GetWebACLRequest>();
            var marshaller = new GetWebACLRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);
            Comparer.CompareObjectToJson<GetWebACLRequest>(request,jsonRequest);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            var jsonResponse = new JsonSampleGenerator(service_model, service_model.FindOperation("GetWebACL").ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString());
            UnmarshallerContext context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), false, webResponse);
            var response = GetWebACLResponseUnmarshaller.Instance.Unmarshall(context) as GetWebACLResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void GetWebACL_WAFInternalErrorExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("GetWebACL");

            var request = InstantiateClassGenerator.Execute<GetWebACLRequest>();
            var marshaller = new GetWebACLRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<GetWebACLRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("WAFInternalErrorException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","WAFInternalErrorException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = GetWebACLResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void GetWebACL_WAFInvalidOperationExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("GetWebACL");

            var request = InstantiateClassGenerator.Execute<GetWebACLRequest>();
            var marshaller = new GetWebACLRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<GetWebACLRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("WAFInvalidOperationException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","WAFInvalidOperationException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = GetWebACLResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void GetWebACL_WAFInvalidParameterExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("GetWebACL");

            var request = InstantiateClassGenerator.Execute<GetWebACLRequest>();
            var marshaller = new GetWebACLRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<GetWebACLRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("WAFInvalidParameterException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","WAFInvalidParameterException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = GetWebACLResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void GetWebACL_WAFNonexistentItemExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("GetWebACL");

            var request = InstantiateClassGenerator.Execute<GetWebACLRequest>();
            var marshaller = new GetWebACLRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<GetWebACLRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("WAFNonexistentItemException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","WAFNonexistentItemException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = GetWebACLResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void GetWebACLForResourceMarshallTest()
        {
            var request = InstantiateClassGenerator.Execute<GetWebACLForResourceRequest>();
            var marshaller = new GetWebACLForResourceRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);
            Comparer.CompareObjectToJson<GetWebACLForResourceRequest>(request,jsonRequest);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            var jsonResponse = new JsonSampleGenerator(service_model, service_model.FindOperation("GetWebACLForResource").ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString());
            UnmarshallerContext context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), false, webResponse);
            var response = GetWebACLForResourceResponseUnmarshaller.Instance.Unmarshall(context) as GetWebACLForResourceResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void GetWebACLForResource_WAFInternalErrorExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("GetWebACLForResource");

            var request = InstantiateClassGenerator.Execute<GetWebACLForResourceRequest>();
            var marshaller = new GetWebACLForResourceRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<GetWebACLForResourceRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("WAFInternalErrorException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","WAFInternalErrorException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = GetWebACLForResourceResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void GetWebACLForResource_WAFInvalidOperationExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("GetWebACLForResource");

            var request = InstantiateClassGenerator.Execute<GetWebACLForResourceRequest>();
            var marshaller = new GetWebACLForResourceRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<GetWebACLForResourceRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("WAFInvalidOperationException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","WAFInvalidOperationException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = GetWebACLForResourceResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void GetWebACLForResource_WAFInvalidParameterExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("GetWebACLForResource");

            var request = InstantiateClassGenerator.Execute<GetWebACLForResourceRequest>();
            var marshaller = new GetWebACLForResourceRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<GetWebACLForResourceRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("WAFInvalidParameterException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","WAFInvalidParameterException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = GetWebACLForResourceResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void GetWebACLForResource_WAFNonexistentItemExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("GetWebACLForResource");

            var request = InstantiateClassGenerator.Execute<GetWebACLForResourceRequest>();
            var marshaller = new GetWebACLForResourceRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<GetWebACLForResourceRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("WAFNonexistentItemException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","WAFNonexistentItemException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = GetWebACLForResourceResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void GetWebACLForResource_WAFUnavailableEntityExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("GetWebACLForResource");

            var request = InstantiateClassGenerator.Execute<GetWebACLForResourceRequest>();
            var marshaller = new GetWebACLForResourceRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<GetWebACLForResourceRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("WAFUnavailableEntityException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","WAFUnavailableEntityException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = GetWebACLForResourceResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void ListAvailableManagedRuleGroupsMarshallTest()
        {
            var request = InstantiateClassGenerator.Execute<ListAvailableManagedRuleGroupsRequest>();
            var marshaller = new ListAvailableManagedRuleGroupsRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);
            Comparer.CompareObjectToJson<ListAvailableManagedRuleGroupsRequest>(request,jsonRequest);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            var jsonResponse = new JsonSampleGenerator(service_model, service_model.FindOperation("ListAvailableManagedRuleGroups").ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString());
            UnmarshallerContext context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), false, webResponse);
            var response = ListAvailableManagedRuleGroupsResponseUnmarshaller.Instance.Unmarshall(context) as ListAvailableManagedRuleGroupsResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void ListAvailableManagedRuleGroups_WAFInternalErrorExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("ListAvailableManagedRuleGroups");

            var request = InstantiateClassGenerator.Execute<ListAvailableManagedRuleGroupsRequest>();
            var marshaller = new ListAvailableManagedRuleGroupsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<ListAvailableManagedRuleGroupsRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("WAFInternalErrorException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","WAFInternalErrorException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = ListAvailableManagedRuleGroupsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void ListAvailableManagedRuleGroups_WAFInvalidOperationExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("ListAvailableManagedRuleGroups");

            var request = InstantiateClassGenerator.Execute<ListAvailableManagedRuleGroupsRequest>();
            var marshaller = new ListAvailableManagedRuleGroupsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<ListAvailableManagedRuleGroupsRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("WAFInvalidOperationException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","WAFInvalidOperationException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = ListAvailableManagedRuleGroupsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void ListAvailableManagedRuleGroups_WAFInvalidParameterExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("ListAvailableManagedRuleGroups");

            var request = InstantiateClassGenerator.Execute<ListAvailableManagedRuleGroupsRequest>();
            var marshaller = new ListAvailableManagedRuleGroupsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<ListAvailableManagedRuleGroupsRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("WAFInvalidParameterException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","WAFInvalidParameterException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = ListAvailableManagedRuleGroupsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void ListAvailableManagedRuleGroupVersionsMarshallTest()
        {
            var request = InstantiateClassGenerator.Execute<ListAvailableManagedRuleGroupVersionsRequest>();
            var marshaller = new ListAvailableManagedRuleGroupVersionsRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);
            Comparer.CompareObjectToJson<ListAvailableManagedRuleGroupVersionsRequest>(request,jsonRequest);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            var jsonResponse = new JsonSampleGenerator(service_model, service_model.FindOperation("ListAvailableManagedRuleGroupVersions").ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString());
            UnmarshallerContext context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), false, webResponse);
            var response = ListAvailableManagedRuleGroupVersionsResponseUnmarshaller.Instance.Unmarshall(context) as ListAvailableManagedRuleGroupVersionsResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void ListAvailableManagedRuleGroupVersions_WAFInternalErrorExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("ListAvailableManagedRuleGroupVersions");

            var request = InstantiateClassGenerator.Execute<ListAvailableManagedRuleGroupVersionsRequest>();
            var marshaller = new ListAvailableManagedRuleGroupVersionsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<ListAvailableManagedRuleGroupVersionsRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("WAFInternalErrorException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","WAFInternalErrorException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = ListAvailableManagedRuleGroupVersionsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void ListAvailableManagedRuleGroupVersions_WAFInvalidOperationExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("ListAvailableManagedRuleGroupVersions");

            var request = InstantiateClassGenerator.Execute<ListAvailableManagedRuleGroupVersionsRequest>();
            var marshaller = new ListAvailableManagedRuleGroupVersionsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<ListAvailableManagedRuleGroupVersionsRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("WAFInvalidOperationException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","WAFInvalidOperationException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = ListAvailableManagedRuleGroupVersionsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void ListAvailableManagedRuleGroupVersions_WAFInvalidParameterExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("ListAvailableManagedRuleGroupVersions");

            var request = InstantiateClassGenerator.Execute<ListAvailableManagedRuleGroupVersionsRequest>();
            var marshaller = new ListAvailableManagedRuleGroupVersionsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<ListAvailableManagedRuleGroupVersionsRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("WAFInvalidParameterException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","WAFInvalidParameterException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = ListAvailableManagedRuleGroupVersionsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void ListAvailableManagedRuleGroupVersions_WAFNonexistentItemExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("ListAvailableManagedRuleGroupVersions");

            var request = InstantiateClassGenerator.Execute<ListAvailableManagedRuleGroupVersionsRequest>();
            var marshaller = new ListAvailableManagedRuleGroupVersionsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<ListAvailableManagedRuleGroupVersionsRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("WAFNonexistentItemException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","WAFNonexistentItemException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = ListAvailableManagedRuleGroupVersionsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void ListIPSetsMarshallTest()
        {
            var request = InstantiateClassGenerator.Execute<ListIPSetsRequest>();
            var marshaller = new ListIPSetsRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);
            Comparer.CompareObjectToJson<ListIPSetsRequest>(request,jsonRequest);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            var jsonResponse = new JsonSampleGenerator(service_model, service_model.FindOperation("ListIPSets").ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString());
            UnmarshallerContext context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), false, webResponse);
            var response = ListIPSetsResponseUnmarshaller.Instance.Unmarshall(context) as ListIPSetsResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void ListIPSets_WAFInternalErrorExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("ListIPSets");

            var request = InstantiateClassGenerator.Execute<ListIPSetsRequest>();
            var marshaller = new ListIPSetsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<ListIPSetsRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("WAFInternalErrorException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","WAFInternalErrorException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = ListIPSetsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void ListIPSets_WAFInvalidOperationExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("ListIPSets");

            var request = InstantiateClassGenerator.Execute<ListIPSetsRequest>();
            var marshaller = new ListIPSetsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<ListIPSetsRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("WAFInvalidOperationException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","WAFInvalidOperationException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = ListIPSetsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void ListIPSets_WAFInvalidParameterExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("ListIPSets");

            var request = InstantiateClassGenerator.Execute<ListIPSetsRequest>();
            var marshaller = new ListIPSetsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<ListIPSetsRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("WAFInvalidParameterException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","WAFInvalidParameterException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = ListIPSetsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void ListLoggingConfigurationsMarshallTest()
        {
            var request = InstantiateClassGenerator.Execute<ListLoggingConfigurationsRequest>();
            var marshaller = new ListLoggingConfigurationsRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);
            Comparer.CompareObjectToJson<ListLoggingConfigurationsRequest>(request,jsonRequest);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            var jsonResponse = new JsonSampleGenerator(service_model, service_model.FindOperation("ListLoggingConfigurations").ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString());
            UnmarshallerContext context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), false, webResponse);
            var response = ListLoggingConfigurationsResponseUnmarshaller.Instance.Unmarshall(context) as ListLoggingConfigurationsResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void ListLoggingConfigurations_WAFInternalErrorExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("ListLoggingConfigurations");

            var request = InstantiateClassGenerator.Execute<ListLoggingConfigurationsRequest>();
            var marshaller = new ListLoggingConfigurationsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<ListLoggingConfigurationsRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("WAFInternalErrorException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","WAFInternalErrorException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = ListLoggingConfigurationsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void ListLoggingConfigurations_WAFInvalidOperationExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("ListLoggingConfigurations");

            var request = InstantiateClassGenerator.Execute<ListLoggingConfigurationsRequest>();
            var marshaller = new ListLoggingConfigurationsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<ListLoggingConfigurationsRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("WAFInvalidOperationException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","WAFInvalidOperationException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = ListLoggingConfigurationsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void ListLoggingConfigurations_WAFInvalidParameterExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("ListLoggingConfigurations");

            var request = InstantiateClassGenerator.Execute<ListLoggingConfigurationsRequest>();
            var marshaller = new ListLoggingConfigurationsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<ListLoggingConfigurationsRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("WAFInvalidParameterException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","WAFInvalidParameterException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = ListLoggingConfigurationsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void ListManagedRuleSetsMarshallTest()
        {
            var request = InstantiateClassGenerator.Execute<ListManagedRuleSetsRequest>();
            var marshaller = new ListManagedRuleSetsRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);
            Comparer.CompareObjectToJson<ListManagedRuleSetsRequest>(request,jsonRequest);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            var jsonResponse = new JsonSampleGenerator(service_model, service_model.FindOperation("ListManagedRuleSets").ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString());
            UnmarshallerContext context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), false, webResponse);
            var response = ListManagedRuleSetsResponseUnmarshaller.Instance.Unmarshall(context) as ListManagedRuleSetsResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void ListManagedRuleSets_WAFInternalErrorExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("ListManagedRuleSets");

            var request = InstantiateClassGenerator.Execute<ListManagedRuleSetsRequest>();
            var marshaller = new ListManagedRuleSetsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<ListManagedRuleSetsRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("WAFInternalErrorException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","WAFInternalErrorException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = ListManagedRuleSetsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void ListManagedRuleSets_WAFInvalidOperationExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("ListManagedRuleSets");

            var request = InstantiateClassGenerator.Execute<ListManagedRuleSetsRequest>();
            var marshaller = new ListManagedRuleSetsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<ListManagedRuleSetsRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("WAFInvalidOperationException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","WAFInvalidOperationException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = ListManagedRuleSetsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void ListManagedRuleSets_WAFInvalidParameterExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("ListManagedRuleSets");

            var request = InstantiateClassGenerator.Execute<ListManagedRuleSetsRequest>();
            var marshaller = new ListManagedRuleSetsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<ListManagedRuleSetsRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("WAFInvalidParameterException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","WAFInvalidParameterException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = ListManagedRuleSetsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void ListMobileSdkReleasesMarshallTest()
        {
            var request = InstantiateClassGenerator.Execute<ListMobileSdkReleasesRequest>();
            var marshaller = new ListMobileSdkReleasesRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);
            Comparer.CompareObjectToJson<ListMobileSdkReleasesRequest>(request,jsonRequest);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            var jsonResponse = new JsonSampleGenerator(service_model, service_model.FindOperation("ListMobileSdkReleases").ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString());
            UnmarshallerContext context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), false, webResponse);
            var response = ListMobileSdkReleasesResponseUnmarshaller.Instance.Unmarshall(context) as ListMobileSdkReleasesResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void ListMobileSdkReleases_WAFInternalErrorExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("ListMobileSdkReleases");

            var request = InstantiateClassGenerator.Execute<ListMobileSdkReleasesRequest>();
            var marshaller = new ListMobileSdkReleasesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<ListMobileSdkReleasesRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("WAFInternalErrorException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","WAFInternalErrorException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = ListMobileSdkReleasesResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void ListMobileSdkReleases_WAFInvalidOperationExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("ListMobileSdkReleases");

            var request = InstantiateClassGenerator.Execute<ListMobileSdkReleasesRequest>();
            var marshaller = new ListMobileSdkReleasesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<ListMobileSdkReleasesRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("WAFInvalidOperationException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","WAFInvalidOperationException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = ListMobileSdkReleasesResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void ListMobileSdkReleases_WAFInvalidParameterExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("ListMobileSdkReleases");

            var request = InstantiateClassGenerator.Execute<ListMobileSdkReleasesRequest>();
            var marshaller = new ListMobileSdkReleasesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<ListMobileSdkReleasesRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("WAFInvalidParameterException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","WAFInvalidParameterException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = ListMobileSdkReleasesResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void ListRegexPatternSetsMarshallTest()
        {
            var request = InstantiateClassGenerator.Execute<ListRegexPatternSetsRequest>();
            var marshaller = new ListRegexPatternSetsRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);
            Comparer.CompareObjectToJson<ListRegexPatternSetsRequest>(request,jsonRequest);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            var jsonResponse = new JsonSampleGenerator(service_model, service_model.FindOperation("ListRegexPatternSets").ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString());
            UnmarshallerContext context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), false, webResponse);
            var response = ListRegexPatternSetsResponseUnmarshaller.Instance.Unmarshall(context) as ListRegexPatternSetsResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void ListRegexPatternSets_WAFInternalErrorExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("ListRegexPatternSets");

            var request = InstantiateClassGenerator.Execute<ListRegexPatternSetsRequest>();
            var marshaller = new ListRegexPatternSetsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<ListRegexPatternSetsRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("WAFInternalErrorException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","WAFInternalErrorException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = ListRegexPatternSetsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void ListRegexPatternSets_WAFInvalidOperationExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("ListRegexPatternSets");

            var request = InstantiateClassGenerator.Execute<ListRegexPatternSetsRequest>();
            var marshaller = new ListRegexPatternSetsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<ListRegexPatternSetsRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("WAFInvalidOperationException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","WAFInvalidOperationException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = ListRegexPatternSetsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void ListRegexPatternSets_WAFInvalidParameterExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("ListRegexPatternSets");

            var request = InstantiateClassGenerator.Execute<ListRegexPatternSetsRequest>();
            var marshaller = new ListRegexPatternSetsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<ListRegexPatternSetsRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("WAFInvalidParameterException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","WAFInvalidParameterException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = ListRegexPatternSetsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void ListResourcesForWebACLMarshallTest()
        {
            var request = InstantiateClassGenerator.Execute<ListResourcesForWebACLRequest>();
            var marshaller = new ListResourcesForWebACLRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);
            Comparer.CompareObjectToJson<ListResourcesForWebACLRequest>(request,jsonRequest);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            var jsonResponse = new JsonSampleGenerator(service_model, service_model.FindOperation("ListResourcesForWebACL").ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString());
            UnmarshallerContext context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), false, webResponse);
            var response = ListResourcesForWebACLResponseUnmarshaller.Instance.Unmarshall(context) as ListResourcesForWebACLResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void ListResourcesForWebACL_WAFInternalErrorExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("ListResourcesForWebACL");

            var request = InstantiateClassGenerator.Execute<ListResourcesForWebACLRequest>();
            var marshaller = new ListResourcesForWebACLRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<ListResourcesForWebACLRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("WAFInternalErrorException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","WAFInternalErrorException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = ListResourcesForWebACLResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void ListResourcesForWebACL_WAFInvalidOperationExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("ListResourcesForWebACL");

            var request = InstantiateClassGenerator.Execute<ListResourcesForWebACLRequest>();
            var marshaller = new ListResourcesForWebACLRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<ListResourcesForWebACLRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("WAFInvalidOperationException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","WAFInvalidOperationException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = ListResourcesForWebACLResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void ListResourcesForWebACL_WAFInvalidParameterExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("ListResourcesForWebACL");

            var request = InstantiateClassGenerator.Execute<ListResourcesForWebACLRequest>();
            var marshaller = new ListResourcesForWebACLRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<ListResourcesForWebACLRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("WAFInvalidParameterException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","WAFInvalidParameterException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = ListResourcesForWebACLResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void ListResourcesForWebACL_WAFNonexistentItemExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("ListResourcesForWebACL");

            var request = InstantiateClassGenerator.Execute<ListResourcesForWebACLRequest>();
            var marshaller = new ListResourcesForWebACLRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<ListResourcesForWebACLRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("WAFNonexistentItemException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","WAFNonexistentItemException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = ListResourcesForWebACLResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void ListRuleGroupsMarshallTest()
        {
            var request = InstantiateClassGenerator.Execute<ListRuleGroupsRequest>();
            var marshaller = new ListRuleGroupsRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);
            Comparer.CompareObjectToJson<ListRuleGroupsRequest>(request,jsonRequest);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            var jsonResponse = new JsonSampleGenerator(service_model, service_model.FindOperation("ListRuleGroups").ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString());
            UnmarshallerContext context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), false, webResponse);
            var response = ListRuleGroupsResponseUnmarshaller.Instance.Unmarshall(context) as ListRuleGroupsResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void ListRuleGroups_WAFInternalErrorExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("ListRuleGroups");

            var request = InstantiateClassGenerator.Execute<ListRuleGroupsRequest>();
            var marshaller = new ListRuleGroupsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<ListRuleGroupsRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("WAFInternalErrorException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","WAFInternalErrorException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = ListRuleGroupsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void ListRuleGroups_WAFInvalidOperationExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("ListRuleGroups");

            var request = InstantiateClassGenerator.Execute<ListRuleGroupsRequest>();
            var marshaller = new ListRuleGroupsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<ListRuleGroupsRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("WAFInvalidOperationException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","WAFInvalidOperationException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = ListRuleGroupsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void ListRuleGroups_WAFInvalidParameterExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("ListRuleGroups");

            var request = InstantiateClassGenerator.Execute<ListRuleGroupsRequest>();
            var marshaller = new ListRuleGroupsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<ListRuleGroupsRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("WAFInvalidParameterException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","WAFInvalidParameterException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = ListRuleGroupsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void ListTagsForResourceMarshallTest()
        {
            var request = InstantiateClassGenerator.Execute<ListTagsForResourceRequest>();
            var marshaller = new ListTagsForResourceRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);
            Comparer.CompareObjectToJson<ListTagsForResourceRequest>(request,jsonRequest);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            var jsonResponse = new JsonSampleGenerator(service_model, service_model.FindOperation("ListTagsForResource").ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString());
            UnmarshallerContext context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), false, webResponse);
            var response = ListTagsForResourceResponseUnmarshaller.Instance.Unmarshall(context) as ListTagsForResourceResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void ListTagsForResource_WAFInternalErrorExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("ListTagsForResource");

            var request = InstantiateClassGenerator.Execute<ListTagsForResourceRequest>();
            var marshaller = new ListTagsForResourceRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<ListTagsForResourceRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("WAFInternalErrorException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","WAFInternalErrorException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = ListTagsForResourceResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void ListTagsForResource_WAFInvalidOperationExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("ListTagsForResource");

            var request = InstantiateClassGenerator.Execute<ListTagsForResourceRequest>();
            var marshaller = new ListTagsForResourceRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<ListTagsForResourceRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("WAFInvalidOperationException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","WAFInvalidOperationException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = ListTagsForResourceResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void ListTagsForResource_WAFInvalidParameterExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("ListTagsForResource");

            var request = InstantiateClassGenerator.Execute<ListTagsForResourceRequest>();
            var marshaller = new ListTagsForResourceRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<ListTagsForResourceRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("WAFInvalidParameterException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","WAFInvalidParameterException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = ListTagsForResourceResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void ListTagsForResource_WAFNonexistentItemExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("ListTagsForResource");

            var request = InstantiateClassGenerator.Execute<ListTagsForResourceRequest>();
            var marshaller = new ListTagsForResourceRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<ListTagsForResourceRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("WAFNonexistentItemException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","WAFNonexistentItemException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = ListTagsForResourceResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void ListTagsForResource_WAFTagOperationExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("ListTagsForResource");

            var request = InstantiateClassGenerator.Execute<ListTagsForResourceRequest>();
            var marshaller = new ListTagsForResourceRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<ListTagsForResourceRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("WAFTagOperationException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","WAFTagOperationException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = ListTagsForResourceResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void ListTagsForResource_WAFTagOperationInternalErrorExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("ListTagsForResource");

            var request = InstantiateClassGenerator.Execute<ListTagsForResourceRequest>();
            var marshaller = new ListTagsForResourceRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<ListTagsForResourceRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("WAFTagOperationInternalErrorException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","WAFTagOperationInternalErrorException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = ListTagsForResourceResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void ListWebACLsMarshallTest()
        {
            var request = InstantiateClassGenerator.Execute<ListWebACLsRequest>();
            var marshaller = new ListWebACLsRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);
            Comparer.CompareObjectToJson<ListWebACLsRequest>(request,jsonRequest);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            var jsonResponse = new JsonSampleGenerator(service_model, service_model.FindOperation("ListWebACLs").ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString());
            UnmarshallerContext context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), false, webResponse);
            var response = ListWebACLsResponseUnmarshaller.Instance.Unmarshall(context) as ListWebACLsResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void ListWebACLs_WAFInternalErrorExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("ListWebACLs");

            var request = InstantiateClassGenerator.Execute<ListWebACLsRequest>();
            var marshaller = new ListWebACLsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<ListWebACLsRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("WAFInternalErrorException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","WAFInternalErrorException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = ListWebACLsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void ListWebACLs_WAFInvalidOperationExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("ListWebACLs");

            var request = InstantiateClassGenerator.Execute<ListWebACLsRequest>();
            var marshaller = new ListWebACLsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<ListWebACLsRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("WAFInvalidOperationException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","WAFInvalidOperationException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = ListWebACLsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void ListWebACLs_WAFInvalidParameterExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("ListWebACLs");

            var request = InstantiateClassGenerator.Execute<ListWebACLsRequest>();
            var marshaller = new ListWebACLsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<ListWebACLsRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("WAFInvalidParameterException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","WAFInvalidParameterException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = ListWebACLsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void PutLoggingConfigurationMarshallTest()
        {
            var request = InstantiateClassGenerator.Execute<PutLoggingConfigurationRequest>();
            var marshaller = new PutLoggingConfigurationRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);
            Comparer.CompareObjectToJson<PutLoggingConfigurationRequest>(request,jsonRequest);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            var jsonResponse = new JsonSampleGenerator(service_model, service_model.FindOperation("PutLoggingConfiguration").ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString());
            UnmarshallerContext context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), false, webResponse);
            var response = PutLoggingConfigurationResponseUnmarshaller.Instance.Unmarshall(context) as PutLoggingConfigurationResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void PutLoggingConfiguration_WAFInternalErrorExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("PutLoggingConfiguration");

            var request = InstantiateClassGenerator.Execute<PutLoggingConfigurationRequest>();
            var marshaller = new PutLoggingConfigurationRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<PutLoggingConfigurationRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("WAFInternalErrorException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","WAFInternalErrorException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = PutLoggingConfigurationResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void PutLoggingConfiguration_WAFInvalidOperationExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("PutLoggingConfiguration");

            var request = InstantiateClassGenerator.Execute<PutLoggingConfigurationRequest>();
            var marshaller = new PutLoggingConfigurationRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<PutLoggingConfigurationRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("WAFInvalidOperationException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","WAFInvalidOperationException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = PutLoggingConfigurationResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void PutLoggingConfiguration_WAFInvalidParameterExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("PutLoggingConfiguration");

            var request = InstantiateClassGenerator.Execute<PutLoggingConfigurationRequest>();
            var marshaller = new PutLoggingConfigurationRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<PutLoggingConfigurationRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("WAFInvalidParameterException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","WAFInvalidParameterException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = PutLoggingConfigurationResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void PutLoggingConfiguration_WAFLimitsExceededExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("PutLoggingConfiguration");

            var request = InstantiateClassGenerator.Execute<PutLoggingConfigurationRequest>();
            var marshaller = new PutLoggingConfigurationRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<PutLoggingConfigurationRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("WAFLimitsExceededException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","WAFLimitsExceededException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = PutLoggingConfigurationResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void PutLoggingConfiguration_WAFLogDestinationPermissionIssueExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("PutLoggingConfiguration");

            var request = InstantiateClassGenerator.Execute<PutLoggingConfigurationRequest>();
            var marshaller = new PutLoggingConfigurationRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<PutLoggingConfigurationRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("WAFLogDestinationPermissionIssueException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","WAFLogDestinationPermissionIssueException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = PutLoggingConfigurationResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void PutLoggingConfiguration_WAFNonexistentItemExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("PutLoggingConfiguration");

            var request = InstantiateClassGenerator.Execute<PutLoggingConfigurationRequest>();
            var marshaller = new PutLoggingConfigurationRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<PutLoggingConfigurationRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("WAFNonexistentItemException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","WAFNonexistentItemException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = PutLoggingConfigurationResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void PutLoggingConfiguration_WAFOptimisticLockExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("PutLoggingConfiguration");

            var request = InstantiateClassGenerator.Execute<PutLoggingConfigurationRequest>();
            var marshaller = new PutLoggingConfigurationRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<PutLoggingConfigurationRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("WAFOptimisticLockException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","WAFOptimisticLockException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = PutLoggingConfigurationResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void PutLoggingConfiguration_WAFServiceLinkedRoleErrorExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("PutLoggingConfiguration");

            var request = InstantiateClassGenerator.Execute<PutLoggingConfigurationRequest>();
            var marshaller = new PutLoggingConfigurationRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<PutLoggingConfigurationRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("WAFServiceLinkedRoleErrorException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","WAFServiceLinkedRoleErrorException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = PutLoggingConfigurationResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void PutManagedRuleSetVersionsMarshallTest()
        {
            var request = InstantiateClassGenerator.Execute<PutManagedRuleSetVersionsRequest>();
            var marshaller = new PutManagedRuleSetVersionsRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);
            Comparer.CompareObjectToJson<PutManagedRuleSetVersionsRequest>(request,jsonRequest);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            var jsonResponse = new JsonSampleGenerator(service_model, service_model.FindOperation("PutManagedRuleSetVersions").ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString());
            UnmarshallerContext context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), false, webResponse);
            var response = PutManagedRuleSetVersionsResponseUnmarshaller.Instance.Unmarshall(context) as PutManagedRuleSetVersionsResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void PutManagedRuleSetVersions_WAFInternalErrorExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("PutManagedRuleSetVersions");

            var request = InstantiateClassGenerator.Execute<PutManagedRuleSetVersionsRequest>();
            var marshaller = new PutManagedRuleSetVersionsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<PutManagedRuleSetVersionsRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("WAFInternalErrorException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","WAFInternalErrorException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = PutManagedRuleSetVersionsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void PutManagedRuleSetVersions_WAFInvalidOperationExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("PutManagedRuleSetVersions");

            var request = InstantiateClassGenerator.Execute<PutManagedRuleSetVersionsRequest>();
            var marshaller = new PutManagedRuleSetVersionsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<PutManagedRuleSetVersionsRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("WAFInvalidOperationException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","WAFInvalidOperationException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = PutManagedRuleSetVersionsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void PutManagedRuleSetVersions_WAFInvalidParameterExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("PutManagedRuleSetVersions");

            var request = InstantiateClassGenerator.Execute<PutManagedRuleSetVersionsRequest>();
            var marshaller = new PutManagedRuleSetVersionsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<PutManagedRuleSetVersionsRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("WAFInvalidParameterException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","WAFInvalidParameterException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = PutManagedRuleSetVersionsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void PutManagedRuleSetVersions_WAFNonexistentItemExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("PutManagedRuleSetVersions");

            var request = InstantiateClassGenerator.Execute<PutManagedRuleSetVersionsRequest>();
            var marshaller = new PutManagedRuleSetVersionsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<PutManagedRuleSetVersionsRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("WAFNonexistentItemException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","WAFNonexistentItemException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = PutManagedRuleSetVersionsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void PutManagedRuleSetVersions_WAFOptimisticLockExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("PutManagedRuleSetVersions");

            var request = InstantiateClassGenerator.Execute<PutManagedRuleSetVersionsRequest>();
            var marshaller = new PutManagedRuleSetVersionsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<PutManagedRuleSetVersionsRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("WAFOptimisticLockException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","WAFOptimisticLockException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = PutManagedRuleSetVersionsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void PutPermissionPolicyMarshallTest()
        {
            var request = InstantiateClassGenerator.Execute<PutPermissionPolicyRequest>();
            var marshaller = new PutPermissionPolicyRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);
            Comparer.CompareObjectToJson<PutPermissionPolicyRequest>(request,jsonRequest);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            var jsonResponse = new JsonSampleGenerator(service_model, service_model.FindOperation("PutPermissionPolicy").ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString());
            UnmarshallerContext context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), false, webResponse);
            var response = PutPermissionPolicyResponseUnmarshaller.Instance.Unmarshall(context) as PutPermissionPolicyResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void PutPermissionPolicy_WAFInternalErrorExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("PutPermissionPolicy");

            var request = InstantiateClassGenerator.Execute<PutPermissionPolicyRequest>();
            var marshaller = new PutPermissionPolicyRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<PutPermissionPolicyRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("WAFInternalErrorException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","WAFInternalErrorException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = PutPermissionPolicyResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void PutPermissionPolicy_WAFInvalidParameterExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("PutPermissionPolicy");

            var request = InstantiateClassGenerator.Execute<PutPermissionPolicyRequest>();
            var marshaller = new PutPermissionPolicyRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<PutPermissionPolicyRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("WAFInvalidParameterException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","WAFInvalidParameterException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = PutPermissionPolicyResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void PutPermissionPolicy_WAFInvalidPermissionPolicyExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("PutPermissionPolicy");

            var request = InstantiateClassGenerator.Execute<PutPermissionPolicyRequest>();
            var marshaller = new PutPermissionPolicyRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<PutPermissionPolicyRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("WAFInvalidPermissionPolicyException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","WAFInvalidPermissionPolicyException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = PutPermissionPolicyResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void PutPermissionPolicy_WAFNonexistentItemExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("PutPermissionPolicy");

            var request = InstantiateClassGenerator.Execute<PutPermissionPolicyRequest>();
            var marshaller = new PutPermissionPolicyRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<PutPermissionPolicyRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("WAFNonexistentItemException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","WAFNonexistentItemException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = PutPermissionPolicyResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void TagResourceMarshallTest()
        {
            var request = InstantiateClassGenerator.Execute<TagResourceRequest>();
            var marshaller = new TagResourceRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);
            Comparer.CompareObjectToJson<TagResourceRequest>(request,jsonRequest);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            var jsonResponse = new JsonSampleGenerator(service_model, service_model.FindOperation("TagResource").ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString());
            UnmarshallerContext context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), false, webResponse);
            var response = TagResourceResponseUnmarshaller.Instance.Unmarshall(context) as TagResourceResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void TagResource_WAFInternalErrorExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("TagResource");

            var request = InstantiateClassGenerator.Execute<TagResourceRequest>();
            var marshaller = new TagResourceRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<TagResourceRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("WAFInternalErrorException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","WAFInternalErrorException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = TagResourceResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void TagResource_WAFInvalidOperationExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("TagResource");

            var request = InstantiateClassGenerator.Execute<TagResourceRequest>();
            var marshaller = new TagResourceRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<TagResourceRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("WAFInvalidOperationException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","WAFInvalidOperationException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = TagResourceResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void TagResource_WAFInvalidParameterExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("TagResource");

            var request = InstantiateClassGenerator.Execute<TagResourceRequest>();
            var marshaller = new TagResourceRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<TagResourceRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("WAFInvalidParameterException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","WAFInvalidParameterException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = TagResourceResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void TagResource_WAFLimitsExceededExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("TagResource");

            var request = InstantiateClassGenerator.Execute<TagResourceRequest>();
            var marshaller = new TagResourceRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<TagResourceRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("WAFLimitsExceededException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","WAFLimitsExceededException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = TagResourceResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void TagResource_WAFNonexistentItemExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("TagResource");

            var request = InstantiateClassGenerator.Execute<TagResourceRequest>();
            var marshaller = new TagResourceRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<TagResourceRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("WAFNonexistentItemException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","WAFNonexistentItemException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = TagResourceResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void TagResource_WAFTagOperationExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("TagResource");

            var request = InstantiateClassGenerator.Execute<TagResourceRequest>();
            var marshaller = new TagResourceRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<TagResourceRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("WAFTagOperationException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","WAFTagOperationException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = TagResourceResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void TagResource_WAFTagOperationInternalErrorExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("TagResource");

            var request = InstantiateClassGenerator.Execute<TagResourceRequest>();
            var marshaller = new TagResourceRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<TagResourceRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("WAFTagOperationInternalErrorException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","WAFTagOperationInternalErrorException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = TagResourceResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void UntagResourceMarshallTest()
        {
            var request = InstantiateClassGenerator.Execute<UntagResourceRequest>();
            var marshaller = new UntagResourceRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);
            Comparer.CompareObjectToJson<UntagResourceRequest>(request,jsonRequest);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            var jsonResponse = new JsonSampleGenerator(service_model, service_model.FindOperation("UntagResource").ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString());
            UnmarshallerContext context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), false, webResponse);
            var response = UntagResourceResponseUnmarshaller.Instance.Unmarshall(context) as UntagResourceResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void UntagResource_WAFInternalErrorExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("UntagResource");

            var request = InstantiateClassGenerator.Execute<UntagResourceRequest>();
            var marshaller = new UntagResourceRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<UntagResourceRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("WAFInternalErrorException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","WAFInternalErrorException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = UntagResourceResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void UntagResource_WAFInvalidOperationExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("UntagResource");

            var request = InstantiateClassGenerator.Execute<UntagResourceRequest>();
            var marshaller = new UntagResourceRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<UntagResourceRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("WAFInvalidOperationException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","WAFInvalidOperationException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = UntagResourceResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void UntagResource_WAFInvalidParameterExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("UntagResource");

            var request = InstantiateClassGenerator.Execute<UntagResourceRequest>();
            var marshaller = new UntagResourceRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<UntagResourceRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("WAFInvalidParameterException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","WAFInvalidParameterException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = UntagResourceResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void UntagResource_WAFNonexistentItemExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("UntagResource");

            var request = InstantiateClassGenerator.Execute<UntagResourceRequest>();
            var marshaller = new UntagResourceRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<UntagResourceRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("WAFNonexistentItemException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","WAFNonexistentItemException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = UntagResourceResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void UntagResource_WAFTagOperationExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("UntagResource");

            var request = InstantiateClassGenerator.Execute<UntagResourceRequest>();
            var marshaller = new UntagResourceRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<UntagResourceRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("WAFTagOperationException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","WAFTagOperationException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = UntagResourceResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void UntagResource_WAFTagOperationInternalErrorExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("UntagResource");

            var request = InstantiateClassGenerator.Execute<UntagResourceRequest>();
            var marshaller = new UntagResourceRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<UntagResourceRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("WAFTagOperationInternalErrorException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","WAFTagOperationInternalErrorException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = UntagResourceResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void UpdateIPSetMarshallTest()
        {
            var request = InstantiateClassGenerator.Execute<UpdateIPSetRequest>();
            var marshaller = new UpdateIPSetRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);
            Comparer.CompareObjectToJson<UpdateIPSetRequest>(request,jsonRequest);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            var jsonResponse = new JsonSampleGenerator(service_model, service_model.FindOperation("UpdateIPSet").ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString());
            UnmarshallerContext context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), false, webResponse);
            var response = UpdateIPSetResponseUnmarshaller.Instance.Unmarshall(context) as UpdateIPSetResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void UpdateIPSet_WAFDuplicateItemExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("UpdateIPSet");

            var request = InstantiateClassGenerator.Execute<UpdateIPSetRequest>();
            var marshaller = new UpdateIPSetRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<UpdateIPSetRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("WAFDuplicateItemException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","WAFDuplicateItemException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = UpdateIPSetResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void UpdateIPSet_WAFInternalErrorExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("UpdateIPSet");

            var request = InstantiateClassGenerator.Execute<UpdateIPSetRequest>();
            var marshaller = new UpdateIPSetRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<UpdateIPSetRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("WAFInternalErrorException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","WAFInternalErrorException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = UpdateIPSetResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void UpdateIPSet_WAFInvalidOperationExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("UpdateIPSet");

            var request = InstantiateClassGenerator.Execute<UpdateIPSetRequest>();
            var marshaller = new UpdateIPSetRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<UpdateIPSetRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("WAFInvalidOperationException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","WAFInvalidOperationException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = UpdateIPSetResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void UpdateIPSet_WAFInvalidParameterExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("UpdateIPSet");

            var request = InstantiateClassGenerator.Execute<UpdateIPSetRequest>();
            var marshaller = new UpdateIPSetRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<UpdateIPSetRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("WAFInvalidParameterException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","WAFInvalidParameterException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = UpdateIPSetResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void UpdateIPSet_WAFLimitsExceededExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("UpdateIPSet");

            var request = InstantiateClassGenerator.Execute<UpdateIPSetRequest>();
            var marshaller = new UpdateIPSetRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<UpdateIPSetRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("WAFLimitsExceededException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","WAFLimitsExceededException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = UpdateIPSetResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void UpdateIPSet_WAFNonexistentItemExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("UpdateIPSet");

            var request = InstantiateClassGenerator.Execute<UpdateIPSetRequest>();
            var marshaller = new UpdateIPSetRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<UpdateIPSetRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("WAFNonexistentItemException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","WAFNonexistentItemException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = UpdateIPSetResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void UpdateIPSet_WAFOptimisticLockExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("UpdateIPSet");

            var request = InstantiateClassGenerator.Execute<UpdateIPSetRequest>();
            var marshaller = new UpdateIPSetRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<UpdateIPSetRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("WAFOptimisticLockException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","WAFOptimisticLockException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = UpdateIPSetResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void UpdateManagedRuleSetVersionExpiryDateMarshallTest()
        {
            var request = InstantiateClassGenerator.Execute<UpdateManagedRuleSetVersionExpiryDateRequest>();
            var marshaller = new UpdateManagedRuleSetVersionExpiryDateRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);
            Comparer.CompareObjectToJson<UpdateManagedRuleSetVersionExpiryDateRequest>(request,jsonRequest);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            var jsonResponse = new JsonSampleGenerator(service_model, service_model.FindOperation("UpdateManagedRuleSetVersionExpiryDate").ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString());
            UnmarshallerContext context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), false, webResponse);
            var response = UpdateManagedRuleSetVersionExpiryDateResponseUnmarshaller.Instance.Unmarshall(context) as UpdateManagedRuleSetVersionExpiryDateResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void UpdateManagedRuleSetVersionExpiryDate_WAFInternalErrorExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("UpdateManagedRuleSetVersionExpiryDate");

            var request = InstantiateClassGenerator.Execute<UpdateManagedRuleSetVersionExpiryDateRequest>();
            var marshaller = new UpdateManagedRuleSetVersionExpiryDateRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<UpdateManagedRuleSetVersionExpiryDateRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("WAFInternalErrorException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","WAFInternalErrorException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = UpdateManagedRuleSetVersionExpiryDateResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void UpdateManagedRuleSetVersionExpiryDate_WAFInvalidOperationExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("UpdateManagedRuleSetVersionExpiryDate");

            var request = InstantiateClassGenerator.Execute<UpdateManagedRuleSetVersionExpiryDateRequest>();
            var marshaller = new UpdateManagedRuleSetVersionExpiryDateRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<UpdateManagedRuleSetVersionExpiryDateRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("WAFInvalidOperationException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","WAFInvalidOperationException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = UpdateManagedRuleSetVersionExpiryDateResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void UpdateManagedRuleSetVersionExpiryDate_WAFInvalidParameterExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("UpdateManagedRuleSetVersionExpiryDate");

            var request = InstantiateClassGenerator.Execute<UpdateManagedRuleSetVersionExpiryDateRequest>();
            var marshaller = new UpdateManagedRuleSetVersionExpiryDateRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<UpdateManagedRuleSetVersionExpiryDateRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("WAFInvalidParameterException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","WAFInvalidParameterException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = UpdateManagedRuleSetVersionExpiryDateResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void UpdateManagedRuleSetVersionExpiryDate_WAFNonexistentItemExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("UpdateManagedRuleSetVersionExpiryDate");

            var request = InstantiateClassGenerator.Execute<UpdateManagedRuleSetVersionExpiryDateRequest>();
            var marshaller = new UpdateManagedRuleSetVersionExpiryDateRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<UpdateManagedRuleSetVersionExpiryDateRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("WAFNonexistentItemException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","WAFNonexistentItemException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = UpdateManagedRuleSetVersionExpiryDateResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void UpdateManagedRuleSetVersionExpiryDate_WAFOptimisticLockExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("UpdateManagedRuleSetVersionExpiryDate");

            var request = InstantiateClassGenerator.Execute<UpdateManagedRuleSetVersionExpiryDateRequest>();
            var marshaller = new UpdateManagedRuleSetVersionExpiryDateRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<UpdateManagedRuleSetVersionExpiryDateRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("WAFOptimisticLockException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","WAFOptimisticLockException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = UpdateManagedRuleSetVersionExpiryDateResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void UpdateRegexPatternSetMarshallTest()
        {
            var request = InstantiateClassGenerator.Execute<UpdateRegexPatternSetRequest>();
            var marshaller = new UpdateRegexPatternSetRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);
            Comparer.CompareObjectToJson<UpdateRegexPatternSetRequest>(request,jsonRequest);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            var jsonResponse = new JsonSampleGenerator(service_model, service_model.FindOperation("UpdateRegexPatternSet").ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString());
            UnmarshallerContext context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), false, webResponse);
            var response = UpdateRegexPatternSetResponseUnmarshaller.Instance.Unmarshall(context) as UpdateRegexPatternSetResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void UpdateRegexPatternSet_WAFDuplicateItemExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("UpdateRegexPatternSet");

            var request = InstantiateClassGenerator.Execute<UpdateRegexPatternSetRequest>();
            var marshaller = new UpdateRegexPatternSetRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<UpdateRegexPatternSetRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("WAFDuplicateItemException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","WAFDuplicateItemException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = UpdateRegexPatternSetResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void UpdateRegexPatternSet_WAFInternalErrorExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("UpdateRegexPatternSet");

            var request = InstantiateClassGenerator.Execute<UpdateRegexPatternSetRequest>();
            var marshaller = new UpdateRegexPatternSetRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<UpdateRegexPatternSetRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("WAFInternalErrorException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","WAFInternalErrorException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = UpdateRegexPatternSetResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void UpdateRegexPatternSet_WAFInvalidOperationExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("UpdateRegexPatternSet");

            var request = InstantiateClassGenerator.Execute<UpdateRegexPatternSetRequest>();
            var marshaller = new UpdateRegexPatternSetRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<UpdateRegexPatternSetRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("WAFInvalidOperationException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","WAFInvalidOperationException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = UpdateRegexPatternSetResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void UpdateRegexPatternSet_WAFInvalidParameterExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("UpdateRegexPatternSet");

            var request = InstantiateClassGenerator.Execute<UpdateRegexPatternSetRequest>();
            var marshaller = new UpdateRegexPatternSetRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<UpdateRegexPatternSetRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("WAFInvalidParameterException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","WAFInvalidParameterException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = UpdateRegexPatternSetResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void UpdateRegexPatternSet_WAFLimitsExceededExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("UpdateRegexPatternSet");

            var request = InstantiateClassGenerator.Execute<UpdateRegexPatternSetRequest>();
            var marshaller = new UpdateRegexPatternSetRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<UpdateRegexPatternSetRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("WAFLimitsExceededException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","WAFLimitsExceededException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = UpdateRegexPatternSetResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void UpdateRegexPatternSet_WAFNonexistentItemExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("UpdateRegexPatternSet");

            var request = InstantiateClassGenerator.Execute<UpdateRegexPatternSetRequest>();
            var marshaller = new UpdateRegexPatternSetRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<UpdateRegexPatternSetRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("WAFNonexistentItemException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","WAFNonexistentItemException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = UpdateRegexPatternSetResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void UpdateRegexPatternSet_WAFOptimisticLockExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("UpdateRegexPatternSet");

            var request = InstantiateClassGenerator.Execute<UpdateRegexPatternSetRequest>();
            var marshaller = new UpdateRegexPatternSetRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<UpdateRegexPatternSetRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("WAFOptimisticLockException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","WAFOptimisticLockException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = UpdateRegexPatternSetResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void UpdateRuleGroupMarshallTest()
        {
            var request = InstantiateClassGenerator.Execute<UpdateRuleGroupRequest>();
            var marshaller = new UpdateRuleGroupRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);
            Comparer.CompareObjectToJson<UpdateRuleGroupRequest>(request,jsonRequest);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            var jsonResponse = new JsonSampleGenerator(service_model, service_model.FindOperation("UpdateRuleGroup").ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString());
            UnmarshallerContext context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), false, webResponse);
            var response = UpdateRuleGroupResponseUnmarshaller.Instance.Unmarshall(context) as UpdateRuleGroupResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void UpdateRuleGroup_WAFConfigurationWarningExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("UpdateRuleGroup");

            var request = InstantiateClassGenerator.Execute<UpdateRuleGroupRequest>();
            var marshaller = new UpdateRuleGroupRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<UpdateRuleGroupRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("WAFConfigurationWarningException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","WAFConfigurationWarningException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = UpdateRuleGroupResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void UpdateRuleGroup_WAFDuplicateItemExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("UpdateRuleGroup");

            var request = InstantiateClassGenerator.Execute<UpdateRuleGroupRequest>();
            var marshaller = new UpdateRuleGroupRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<UpdateRuleGroupRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("WAFDuplicateItemException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","WAFDuplicateItemException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = UpdateRuleGroupResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void UpdateRuleGroup_WAFInternalErrorExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("UpdateRuleGroup");

            var request = InstantiateClassGenerator.Execute<UpdateRuleGroupRequest>();
            var marshaller = new UpdateRuleGroupRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<UpdateRuleGroupRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("WAFInternalErrorException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","WAFInternalErrorException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = UpdateRuleGroupResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void UpdateRuleGroup_WAFInvalidOperationExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("UpdateRuleGroup");

            var request = InstantiateClassGenerator.Execute<UpdateRuleGroupRequest>();
            var marshaller = new UpdateRuleGroupRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<UpdateRuleGroupRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("WAFInvalidOperationException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","WAFInvalidOperationException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = UpdateRuleGroupResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void UpdateRuleGroup_WAFInvalidParameterExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("UpdateRuleGroup");

            var request = InstantiateClassGenerator.Execute<UpdateRuleGroupRequest>();
            var marshaller = new UpdateRuleGroupRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<UpdateRuleGroupRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("WAFInvalidParameterException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","WAFInvalidParameterException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = UpdateRuleGroupResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void UpdateRuleGroup_WAFLimitsExceededExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("UpdateRuleGroup");

            var request = InstantiateClassGenerator.Execute<UpdateRuleGroupRequest>();
            var marshaller = new UpdateRuleGroupRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<UpdateRuleGroupRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("WAFLimitsExceededException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","WAFLimitsExceededException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = UpdateRuleGroupResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void UpdateRuleGroup_WAFNonexistentItemExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("UpdateRuleGroup");

            var request = InstantiateClassGenerator.Execute<UpdateRuleGroupRequest>();
            var marshaller = new UpdateRuleGroupRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<UpdateRuleGroupRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("WAFNonexistentItemException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","WAFNonexistentItemException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = UpdateRuleGroupResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void UpdateRuleGroup_WAFOptimisticLockExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("UpdateRuleGroup");

            var request = InstantiateClassGenerator.Execute<UpdateRuleGroupRequest>();
            var marshaller = new UpdateRuleGroupRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<UpdateRuleGroupRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("WAFOptimisticLockException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","WAFOptimisticLockException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = UpdateRuleGroupResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void UpdateRuleGroup_WAFSubscriptionNotFoundExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("UpdateRuleGroup");

            var request = InstantiateClassGenerator.Execute<UpdateRuleGroupRequest>();
            var marshaller = new UpdateRuleGroupRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<UpdateRuleGroupRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("WAFSubscriptionNotFoundException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","WAFSubscriptionNotFoundException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = UpdateRuleGroupResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void UpdateRuleGroup_WAFUnavailableEntityExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("UpdateRuleGroup");

            var request = InstantiateClassGenerator.Execute<UpdateRuleGroupRequest>();
            var marshaller = new UpdateRuleGroupRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<UpdateRuleGroupRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("WAFUnavailableEntityException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","WAFUnavailableEntityException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = UpdateRuleGroupResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void UpdateWebACLMarshallTest()
        {
            var request = InstantiateClassGenerator.Execute<UpdateWebACLRequest>();
            var marshaller = new UpdateWebACLRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);
            Comparer.CompareObjectToJson<UpdateWebACLRequest>(request,jsonRequest);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            var jsonResponse = new JsonSampleGenerator(service_model, service_model.FindOperation("UpdateWebACL").ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString());
            UnmarshallerContext context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), false, webResponse);
            var response = UpdateWebACLResponseUnmarshaller.Instance.Unmarshall(context) as UpdateWebACLResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void UpdateWebACL_WAFConfigurationWarningExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("UpdateWebACL");

            var request = InstantiateClassGenerator.Execute<UpdateWebACLRequest>();
            var marshaller = new UpdateWebACLRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<UpdateWebACLRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("WAFConfigurationWarningException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","WAFConfigurationWarningException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = UpdateWebACLResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void UpdateWebACL_WAFDuplicateItemExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("UpdateWebACL");

            var request = InstantiateClassGenerator.Execute<UpdateWebACLRequest>();
            var marshaller = new UpdateWebACLRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<UpdateWebACLRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("WAFDuplicateItemException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","WAFDuplicateItemException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = UpdateWebACLResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void UpdateWebACL_WAFExpiredManagedRuleGroupVersionExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("UpdateWebACL");

            var request = InstantiateClassGenerator.Execute<UpdateWebACLRequest>();
            var marshaller = new UpdateWebACLRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<UpdateWebACLRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("WAFExpiredManagedRuleGroupVersionException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","WAFExpiredManagedRuleGroupVersionException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = UpdateWebACLResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void UpdateWebACL_WAFInternalErrorExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("UpdateWebACL");

            var request = InstantiateClassGenerator.Execute<UpdateWebACLRequest>();
            var marshaller = new UpdateWebACLRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<UpdateWebACLRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("WAFInternalErrorException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","WAFInternalErrorException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = UpdateWebACLResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void UpdateWebACL_WAFInvalidOperationExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("UpdateWebACL");

            var request = InstantiateClassGenerator.Execute<UpdateWebACLRequest>();
            var marshaller = new UpdateWebACLRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<UpdateWebACLRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("WAFInvalidOperationException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","WAFInvalidOperationException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = UpdateWebACLResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void UpdateWebACL_WAFInvalidParameterExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("UpdateWebACL");

            var request = InstantiateClassGenerator.Execute<UpdateWebACLRequest>();
            var marshaller = new UpdateWebACLRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<UpdateWebACLRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("WAFInvalidParameterException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","WAFInvalidParameterException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = UpdateWebACLResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void UpdateWebACL_WAFInvalidResourceExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("UpdateWebACL");

            var request = InstantiateClassGenerator.Execute<UpdateWebACLRequest>();
            var marshaller = new UpdateWebACLRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<UpdateWebACLRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("WAFInvalidResourceException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","WAFInvalidResourceException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = UpdateWebACLResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void UpdateWebACL_WAFLimitsExceededExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("UpdateWebACL");

            var request = InstantiateClassGenerator.Execute<UpdateWebACLRequest>();
            var marshaller = new UpdateWebACLRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<UpdateWebACLRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("WAFLimitsExceededException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","WAFLimitsExceededException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = UpdateWebACLResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void UpdateWebACL_WAFNonexistentItemExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("UpdateWebACL");

            var request = InstantiateClassGenerator.Execute<UpdateWebACLRequest>();
            var marshaller = new UpdateWebACLRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<UpdateWebACLRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("WAFNonexistentItemException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","WAFNonexistentItemException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = UpdateWebACLResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void UpdateWebACL_WAFOptimisticLockExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("UpdateWebACL");

            var request = InstantiateClassGenerator.Execute<UpdateWebACLRequest>();
            var marshaller = new UpdateWebACLRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<UpdateWebACLRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("WAFOptimisticLockException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","WAFOptimisticLockException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = UpdateWebACLResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void UpdateWebACL_WAFSubscriptionNotFoundExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("UpdateWebACL");

            var request = InstantiateClassGenerator.Execute<UpdateWebACLRequest>();
            var marshaller = new UpdateWebACLRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<UpdateWebACLRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("WAFSubscriptionNotFoundException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","WAFSubscriptionNotFoundException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = UpdateWebACLResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("WAFV2")]
        public void UpdateWebACL_WAFUnavailableEntityExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("UpdateWebACL");

            var request = InstantiateClassGenerator.Execute<UpdateWebACLRequest>();
            var marshaller = new UpdateWebACLRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<UpdateWebACLRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("WAFUnavailableEntityException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","WAFUnavailableEntityException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = UpdateWebACLResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }
    }
}