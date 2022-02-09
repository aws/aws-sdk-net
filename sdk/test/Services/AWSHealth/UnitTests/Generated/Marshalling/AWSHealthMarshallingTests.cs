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
 * Do not modify this file. This file is generated from the health-2016-08-04.normal.json service model.
 */


using System;
using System.IO;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Amazon.AWSHealth;
using Amazon.AWSHealth.Model;
using Amazon.AWSHealth.Model.Internal.MarshallTransformations;
using Amazon.Runtime.Internal.Transform;

using ServiceClientGenerator;

using AWSSDK_DotNet35.UnitTests.TestTools;

namespace AWSSDK_DotNet35.UnitTests.Marshalling
{
    [TestClass]
    public class AWSHealthMarshallingTests
    {
        static readonly ServiceModel service_model = Utils.LoadServiceModel("health");
        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("AWSHealth")]
        public void DescribeAffectedAccountsForOrganizationMarshallTest()
        {
            var request = InstantiateClassGenerator.Execute<DescribeAffectedAccountsForOrganizationRequest>();
            var marshaller = new DescribeAffectedAccountsForOrganizationRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);
            Comparer.CompareObjectToJson<DescribeAffectedAccountsForOrganizationRequest>(request,jsonRequest);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            var jsonResponse = new JsonSampleGenerator(service_model, service_model.FindOperation("DescribeAffectedAccountsForOrganization").ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString());
            UnmarshallerContext context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), false, webResponse);
            var response = DescribeAffectedAccountsForOrganizationResponseUnmarshaller.Instance.Unmarshall(context) as DescribeAffectedAccountsForOrganizationResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("AWSHealth")]
        public void DescribeAffectedAccountsForOrganization_InvalidPaginationTokenExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("DescribeAffectedAccountsForOrganization");

            var request = InstantiateClassGenerator.Execute<DescribeAffectedAccountsForOrganizationRequest>();
            var marshaller = new DescribeAffectedAccountsForOrganizationRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<DescribeAffectedAccountsForOrganizationRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidPaginationTokenException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","InvalidPaginationTokenException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = DescribeAffectedAccountsForOrganizationResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("AWSHealth")]
        public void DescribeAffectedEntitiesMarshallTest()
        {
            var request = InstantiateClassGenerator.Execute<DescribeAffectedEntitiesRequest>();
            var marshaller = new DescribeAffectedEntitiesRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);
            Comparer.CompareObjectToJson<DescribeAffectedEntitiesRequest>(request,jsonRequest);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            var jsonResponse = new JsonSampleGenerator(service_model, service_model.FindOperation("DescribeAffectedEntities").ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString());
            UnmarshallerContext context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), false, webResponse);
            var response = DescribeAffectedEntitiesResponseUnmarshaller.Instance.Unmarshall(context) as DescribeAffectedEntitiesResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("AWSHealth")]
        public void DescribeAffectedEntities_InvalidPaginationTokenExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("DescribeAffectedEntities");

            var request = InstantiateClassGenerator.Execute<DescribeAffectedEntitiesRequest>();
            var marshaller = new DescribeAffectedEntitiesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<DescribeAffectedEntitiesRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidPaginationTokenException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","InvalidPaginationTokenException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = DescribeAffectedEntitiesResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("AWSHealth")]
        public void DescribeAffectedEntities_UnsupportedLocaleExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("DescribeAffectedEntities");

            var request = InstantiateClassGenerator.Execute<DescribeAffectedEntitiesRequest>();
            var marshaller = new DescribeAffectedEntitiesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<DescribeAffectedEntitiesRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("UnsupportedLocaleException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","UnsupportedLocaleException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = DescribeAffectedEntitiesResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("AWSHealth")]
        public void DescribeAffectedEntitiesForOrganizationMarshallTest()
        {
            var request = InstantiateClassGenerator.Execute<DescribeAffectedEntitiesForOrganizationRequest>();
            var marshaller = new DescribeAffectedEntitiesForOrganizationRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);
            Comparer.CompareObjectToJson<DescribeAffectedEntitiesForOrganizationRequest>(request,jsonRequest);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            var jsonResponse = new JsonSampleGenerator(service_model, service_model.FindOperation("DescribeAffectedEntitiesForOrganization").ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString());
            UnmarshallerContext context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), false, webResponse);
            var response = DescribeAffectedEntitiesForOrganizationResponseUnmarshaller.Instance.Unmarshall(context) as DescribeAffectedEntitiesForOrganizationResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("AWSHealth")]
        public void DescribeAffectedEntitiesForOrganization_InvalidPaginationTokenExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("DescribeAffectedEntitiesForOrganization");

            var request = InstantiateClassGenerator.Execute<DescribeAffectedEntitiesForOrganizationRequest>();
            var marshaller = new DescribeAffectedEntitiesForOrganizationRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<DescribeAffectedEntitiesForOrganizationRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidPaginationTokenException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","InvalidPaginationTokenException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = DescribeAffectedEntitiesForOrganizationResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("AWSHealth")]
        public void DescribeAffectedEntitiesForOrganization_UnsupportedLocaleExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("DescribeAffectedEntitiesForOrganization");

            var request = InstantiateClassGenerator.Execute<DescribeAffectedEntitiesForOrganizationRequest>();
            var marshaller = new DescribeAffectedEntitiesForOrganizationRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<DescribeAffectedEntitiesForOrganizationRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("UnsupportedLocaleException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","UnsupportedLocaleException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = DescribeAffectedEntitiesForOrganizationResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("AWSHealth")]
        public void DescribeEntityAggregatesMarshallTest()
        {
            var request = InstantiateClassGenerator.Execute<DescribeEntityAggregatesRequest>();
            var marshaller = new DescribeEntityAggregatesRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);
            Comparer.CompareObjectToJson<DescribeEntityAggregatesRequest>(request,jsonRequest);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            var jsonResponse = new JsonSampleGenerator(service_model, service_model.FindOperation("DescribeEntityAggregates").ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString());
            UnmarshallerContext context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), false, webResponse);
            var response = DescribeEntityAggregatesResponseUnmarshaller.Instance.Unmarshall(context) as DescribeEntityAggregatesResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("AWSHealth")]
        public void DescribeEventAggregatesMarshallTest()
        {
            var request = InstantiateClassGenerator.Execute<DescribeEventAggregatesRequest>();
            var marshaller = new DescribeEventAggregatesRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);
            Comparer.CompareObjectToJson<DescribeEventAggregatesRequest>(request,jsonRequest);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            var jsonResponse = new JsonSampleGenerator(service_model, service_model.FindOperation("DescribeEventAggregates").ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString());
            UnmarshallerContext context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), false, webResponse);
            var response = DescribeEventAggregatesResponseUnmarshaller.Instance.Unmarshall(context) as DescribeEventAggregatesResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("AWSHealth")]
        public void DescribeEventAggregates_InvalidPaginationTokenExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("DescribeEventAggregates");

            var request = InstantiateClassGenerator.Execute<DescribeEventAggregatesRequest>();
            var marshaller = new DescribeEventAggregatesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<DescribeEventAggregatesRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidPaginationTokenException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","InvalidPaginationTokenException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = DescribeEventAggregatesResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("AWSHealth")]
        public void DescribeEventDetailsMarshallTest()
        {
            var request = InstantiateClassGenerator.Execute<DescribeEventDetailsRequest>();
            var marshaller = new DescribeEventDetailsRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);
            Comparer.CompareObjectToJson<DescribeEventDetailsRequest>(request,jsonRequest);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            var jsonResponse = new JsonSampleGenerator(service_model, service_model.FindOperation("DescribeEventDetails").ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString());
            UnmarshallerContext context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), false, webResponse);
            var response = DescribeEventDetailsResponseUnmarshaller.Instance.Unmarshall(context) as DescribeEventDetailsResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("AWSHealth")]
        public void DescribeEventDetails_UnsupportedLocaleExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("DescribeEventDetails");

            var request = InstantiateClassGenerator.Execute<DescribeEventDetailsRequest>();
            var marshaller = new DescribeEventDetailsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<DescribeEventDetailsRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("UnsupportedLocaleException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","UnsupportedLocaleException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = DescribeEventDetailsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("AWSHealth")]
        public void DescribeEventDetailsForOrganizationMarshallTest()
        {
            var request = InstantiateClassGenerator.Execute<DescribeEventDetailsForOrganizationRequest>();
            var marshaller = new DescribeEventDetailsForOrganizationRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);
            Comparer.CompareObjectToJson<DescribeEventDetailsForOrganizationRequest>(request,jsonRequest);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            var jsonResponse = new JsonSampleGenerator(service_model, service_model.FindOperation("DescribeEventDetailsForOrganization").ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString());
            UnmarshallerContext context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), false, webResponse);
            var response = DescribeEventDetailsForOrganizationResponseUnmarshaller.Instance.Unmarshall(context) as DescribeEventDetailsForOrganizationResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("AWSHealth")]
        public void DescribeEventDetailsForOrganization_UnsupportedLocaleExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("DescribeEventDetailsForOrganization");

            var request = InstantiateClassGenerator.Execute<DescribeEventDetailsForOrganizationRequest>();
            var marshaller = new DescribeEventDetailsForOrganizationRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<DescribeEventDetailsForOrganizationRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("UnsupportedLocaleException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","UnsupportedLocaleException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = DescribeEventDetailsForOrganizationResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("AWSHealth")]
        public void DescribeEventsMarshallTest()
        {
            var request = InstantiateClassGenerator.Execute<DescribeEventsRequest>();
            var marshaller = new DescribeEventsRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);
            Comparer.CompareObjectToJson<DescribeEventsRequest>(request,jsonRequest);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            var jsonResponse = new JsonSampleGenerator(service_model, service_model.FindOperation("DescribeEvents").ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString());
            UnmarshallerContext context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), false, webResponse);
            var response = DescribeEventsResponseUnmarshaller.Instance.Unmarshall(context) as DescribeEventsResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("AWSHealth")]
        public void DescribeEvents_InvalidPaginationTokenExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("DescribeEvents");

            var request = InstantiateClassGenerator.Execute<DescribeEventsRequest>();
            var marshaller = new DescribeEventsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<DescribeEventsRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidPaginationTokenException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","InvalidPaginationTokenException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = DescribeEventsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("AWSHealth")]
        public void DescribeEvents_UnsupportedLocaleExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("DescribeEvents");

            var request = InstantiateClassGenerator.Execute<DescribeEventsRequest>();
            var marshaller = new DescribeEventsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<DescribeEventsRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("UnsupportedLocaleException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","UnsupportedLocaleException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = DescribeEventsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("AWSHealth")]
        public void DescribeEventsForOrganizationMarshallTest()
        {
            var request = InstantiateClassGenerator.Execute<DescribeEventsForOrganizationRequest>();
            var marshaller = new DescribeEventsForOrganizationRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);
            Comparer.CompareObjectToJson<DescribeEventsForOrganizationRequest>(request,jsonRequest);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            var jsonResponse = new JsonSampleGenerator(service_model, service_model.FindOperation("DescribeEventsForOrganization").ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString());
            UnmarshallerContext context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), false, webResponse);
            var response = DescribeEventsForOrganizationResponseUnmarshaller.Instance.Unmarshall(context) as DescribeEventsForOrganizationResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("AWSHealth")]
        public void DescribeEventsForOrganization_InvalidPaginationTokenExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("DescribeEventsForOrganization");

            var request = InstantiateClassGenerator.Execute<DescribeEventsForOrganizationRequest>();
            var marshaller = new DescribeEventsForOrganizationRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<DescribeEventsForOrganizationRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidPaginationTokenException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","InvalidPaginationTokenException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = DescribeEventsForOrganizationResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("AWSHealth")]
        public void DescribeEventsForOrganization_UnsupportedLocaleExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("DescribeEventsForOrganization");

            var request = InstantiateClassGenerator.Execute<DescribeEventsForOrganizationRequest>();
            var marshaller = new DescribeEventsForOrganizationRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<DescribeEventsForOrganizationRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("UnsupportedLocaleException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","UnsupportedLocaleException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = DescribeEventsForOrganizationResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("AWSHealth")]
        public void DescribeEventTypesMarshallTest()
        {
            var request = InstantiateClassGenerator.Execute<DescribeEventTypesRequest>();
            var marshaller = new DescribeEventTypesRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);
            Comparer.CompareObjectToJson<DescribeEventTypesRequest>(request,jsonRequest);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            var jsonResponse = new JsonSampleGenerator(service_model, service_model.FindOperation("DescribeEventTypes").ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString());
            UnmarshallerContext context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), false, webResponse);
            var response = DescribeEventTypesResponseUnmarshaller.Instance.Unmarshall(context) as DescribeEventTypesResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("AWSHealth")]
        public void DescribeEventTypes_InvalidPaginationTokenExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("DescribeEventTypes");

            var request = InstantiateClassGenerator.Execute<DescribeEventTypesRequest>();
            var marshaller = new DescribeEventTypesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<DescribeEventTypesRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidPaginationTokenException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","InvalidPaginationTokenException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = DescribeEventTypesResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("AWSHealth")]
        public void DescribeEventTypes_UnsupportedLocaleExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("DescribeEventTypes");

            var request = InstantiateClassGenerator.Execute<DescribeEventTypesRequest>();
            var marshaller = new DescribeEventTypesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<DescribeEventTypesRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("UnsupportedLocaleException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","UnsupportedLocaleException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = DescribeEventTypesResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("AWSHealth")]
        public void DescribeHealthServiceStatusForOrganizationMarshallTest()
        {
            var request = InstantiateClassGenerator.Execute<DescribeHealthServiceStatusForOrganizationRequest>();
            var marshaller = new DescribeHealthServiceStatusForOrganizationRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            var jsonResponse = new JsonSampleGenerator(service_model, service_model.FindOperation("DescribeHealthServiceStatusForOrganization").ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString());
            UnmarshallerContext context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), false, webResponse);
            var response = DescribeHealthServiceStatusForOrganizationResponseUnmarshaller.Instance.Unmarshall(context) as DescribeHealthServiceStatusForOrganizationResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("AWSHealth")]
        public void DisableHealthServiceAccessForOrganizationMarshallTest()
        {
            var request = InstantiateClassGenerator.Execute<DisableHealthServiceAccessForOrganizationRequest>();
            var marshaller = new DisableHealthServiceAccessForOrganizationRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("AWSHealth")]
        public void DisableHealthServiceAccessForOrganization_ConcurrentModificationExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("DisableHealthServiceAccessForOrganization");

            var request = InstantiateClassGenerator.Execute<DisableHealthServiceAccessForOrganizationRequest>();
            var marshaller = new DisableHealthServiceAccessForOrganizationRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<DisableHealthServiceAccessForOrganizationRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("ConcurrentModificationException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","ConcurrentModificationException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = DisableHealthServiceAccessForOrganizationResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("AWSHealth")]
        public void EnableHealthServiceAccessForOrganizationMarshallTest()
        {
            var request = InstantiateClassGenerator.Execute<EnableHealthServiceAccessForOrganizationRequest>();
            var marshaller = new EnableHealthServiceAccessForOrganizationRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("AWSHealth")]
        public void EnableHealthServiceAccessForOrganization_ConcurrentModificationExceptionMarshallTest()
        {
            var operation =  service_model.FindOperation("EnableHealthServiceAccessForOrganization");

            var request = InstantiateClassGenerator.Execute<EnableHealthServiceAccessForOrganizationRequest>();
            var marshaller = new EnableHealthServiceAccessForOrganizationRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);

            Comparer.CompareObjectToJson<EnableHealthServiceAccessForOrganizationRequest>(request,jsonRequest);

            var exception = operation.Exceptions.First(e => e.Name.Equals("ConcurrentModificationException"));
            var jsonResponse = new JsonSampleGenerator(service_model, exception).Execute();
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"x-amzn-ErrorType","ConcurrentModificationException"},
                    {"Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString()}
                }
            };
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), true, webResponse, true);
            var response = EnableHealthServiceAccessForOrganizationResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }
    }
}