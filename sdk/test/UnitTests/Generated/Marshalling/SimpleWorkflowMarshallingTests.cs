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
 * Do not modify this file. This file is generated from the swf-2012-01-25.normal.json service model.
 */


using System;
using System.IO;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Amazon.SimpleWorkflow;
using Amazon.SimpleWorkflow.Model;
using Amazon.SimpleWorkflow.Model.Internal.MarshallTransformations;
using Amazon.Runtime.Internal.Transform;

using ServiceClientGenerator;

using AWSSDK_DotNet35.UnitTests.TestTools;

namespace AWSSDK_DotNet35.UnitTests.Marshalling
{
    [TestClass]
    public class SimpleWorkflowMarshallingTests
    {
        static readonly ServiceModel service_model = Utils.LoadServiceModel("swf-2012-01-25.normal.json", "swf.customizations.json");
        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("SimpleWorkflow")]
        public void CountClosedWorkflowExecutionsMarshallTest()
        {
            var request = InstantiateClassGenerator.Execute<CountClosedWorkflowExecutionsRequest>();
            var marshaller = new CountClosedWorkflowExecutionsRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);                        
            Comparer.CompareObjectToJson<CountClosedWorkflowExecutionsRequest>(request,jsonRequest);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            var jsonResponse = new JsonSampleGenerator(service_model, service_model.FindOperation("CountClosedWorkflowExecutions").ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString());
            UnmarshallerContext context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), false, webResponse);
            var response = CountClosedWorkflowExecutionsResponseUnmarshaller.Instance.Unmarshall(context)
                as CountClosedWorkflowExecutionsResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("SimpleWorkflow")]
        public void CountOpenWorkflowExecutionsMarshallTest()
        {
            var request = InstantiateClassGenerator.Execute<CountOpenWorkflowExecutionsRequest>();
            var marshaller = new CountOpenWorkflowExecutionsRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);                        
            Comparer.CompareObjectToJson<CountOpenWorkflowExecutionsRequest>(request,jsonRequest);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            var jsonResponse = new JsonSampleGenerator(service_model, service_model.FindOperation("CountOpenWorkflowExecutions").ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString());
            UnmarshallerContext context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), false, webResponse);
            var response = CountOpenWorkflowExecutionsResponseUnmarshaller.Instance.Unmarshall(context)
                as CountOpenWorkflowExecutionsResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("SimpleWorkflow")]
        public void CountPendingActivityTasksMarshallTest()
        {
            var request = InstantiateClassGenerator.Execute<CountPendingActivityTasksRequest>();
            var marshaller = new CountPendingActivityTasksRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);                        
            Comparer.CompareObjectToJson<CountPendingActivityTasksRequest>(request,jsonRequest);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            var jsonResponse = new JsonSampleGenerator(service_model, service_model.FindOperation("CountPendingActivityTasks").ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString());
            UnmarshallerContext context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), false, webResponse);
            var response = CountPendingActivityTasksResponseUnmarshaller.Instance.Unmarshall(context)
                as CountPendingActivityTasksResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("SimpleWorkflow")]
        public void CountPendingDecisionTasksMarshallTest()
        {
            var request = InstantiateClassGenerator.Execute<CountPendingDecisionTasksRequest>();
            var marshaller = new CountPendingDecisionTasksRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);                        
            Comparer.CompareObjectToJson<CountPendingDecisionTasksRequest>(request,jsonRequest);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            var jsonResponse = new JsonSampleGenerator(service_model, service_model.FindOperation("CountPendingDecisionTasks").ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString());
            UnmarshallerContext context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), false, webResponse);
            var response = CountPendingDecisionTasksResponseUnmarshaller.Instance.Unmarshall(context)
                as CountPendingDecisionTasksResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("SimpleWorkflow")]
        public void DeprecateActivityTypeMarshallTest()
        {
            var request = InstantiateClassGenerator.Execute<DeprecateActivityTypeRequest>();
            var marshaller = new DeprecateActivityTypeRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);                        
            Comparer.CompareObjectToJson<DeprecateActivityTypeRequest>(request,jsonRequest);

        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("SimpleWorkflow")]
        public void DeprecateDomainMarshallTest()
        {
            var request = InstantiateClassGenerator.Execute<DeprecateDomainRequest>();
            var marshaller = new DeprecateDomainRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);                        
            Comparer.CompareObjectToJson<DeprecateDomainRequest>(request,jsonRequest);

        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("SimpleWorkflow")]
        public void DeprecateWorkflowTypeMarshallTest()
        {
            var request = InstantiateClassGenerator.Execute<DeprecateWorkflowTypeRequest>();
            var marshaller = new DeprecateWorkflowTypeRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);                        
            Comparer.CompareObjectToJson<DeprecateWorkflowTypeRequest>(request,jsonRequest);

        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("SimpleWorkflow")]
        public void DescribeActivityTypeMarshallTest()
        {
            var request = InstantiateClassGenerator.Execute<DescribeActivityTypeRequest>();
            var marshaller = new DescribeActivityTypeRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);                        
            Comparer.CompareObjectToJson<DescribeActivityTypeRequest>(request,jsonRequest);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            var jsonResponse = new JsonSampleGenerator(service_model, service_model.FindOperation("DescribeActivityType").ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString());
            UnmarshallerContext context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), false, webResponse);
            var response = DescribeActivityTypeResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeActivityTypeResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("SimpleWorkflow")]
        public void DescribeDomainMarshallTest()
        {
            var request = InstantiateClassGenerator.Execute<DescribeDomainRequest>();
            var marshaller = new DescribeDomainRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);                        
            Comparer.CompareObjectToJson<DescribeDomainRequest>(request,jsonRequest);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            var jsonResponse = new JsonSampleGenerator(service_model, service_model.FindOperation("DescribeDomain").ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString());
            UnmarshallerContext context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), false, webResponse);
            var response = DescribeDomainResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeDomainResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("SimpleWorkflow")]
        public void DescribeWorkflowExecutionMarshallTest()
        {
            var request = InstantiateClassGenerator.Execute<DescribeWorkflowExecutionRequest>();
            var marshaller = new DescribeWorkflowExecutionRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);                        
            Comparer.CompareObjectToJson<DescribeWorkflowExecutionRequest>(request,jsonRequest);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            var jsonResponse = new JsonSampleGenerator(service_model, service_model.FindOperation("DescribeWorkflowExecution").ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString());
            UnmarshallerContext context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), false, webResponse);
            var response = DescribeWorkflowExecutionResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeWorkflowExecutionResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("SimpleWorkflow")]
        public void DescribeWorkflowTypeMarshallTest()
        {
            var request = InstantiateClassGenerator.Execute<DescribeWorkflowTypeRequest>();
            var marshaller = new DescribeWorkflowTypeRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);                        
            Comparer.CompareObjectToJson<DescribeWorkflowTypeRequest>(request,jsonRequest);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            var jsonResponse = new JsonSampleGenerator(service_model, service_model.FindOperation("DescribeWorkflowType").ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString());
            UnmarshallerContext context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), false, webResponse);
            var response = DescribeWorkflowTypeResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeWorkflowTypeResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("SimpleWorkflow")]
        public void GetWorkflowExecutionHistoryMarshallTest()
        {
            var request = InstantiateClassGenerator.Execute<GetWorkflowExecutionHistoryRequest>();
            var marshaller = new GetWorkflowExecutionHistoryRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);                        
            Comparer.CompareObjectToJson<GetWorkflowExecutionHistoryRequest>(request,jsonRequest);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            var jsonResponse = new JsonSampleGenerator(service_model, service_model.FindOperation("GetWorkflowExecutionHistory").ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString());
            UnmarshallerContext context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), false, webResponse);
            var response = GetWorkflowExecutionHistoryResponseUnmarshaller.Instance.Unmarshall(context)
                as GetWorkflowExecutionHistoryResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("SimpleWorkflow")]
        public void ListActivityTypesMarshallTest()
        {
            var request = InstantiateClassGenerator.Execute<ListActivityTypesRequest>();
            var marshaller = new ListActivityTypesRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);                        
            Comparer.CompareObjectToJson<ListActivityTypesRequest>(request,jsonRequest);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            var jsonResponse = new JsonSampleGenerator(service_model, service_model.FindOperation("ListActivityTypes").ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString());
            UnmarshallerContext context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), false, webResponse);
            var response = ListActivityTypesResponseUnmarshaller.Instance.Unmarshall(context)
                as ListActivityTypesResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("SimpleWorkflow")]
        public void ListClosedWorkflowExecutionsMarshallTest()
        {
            var request = InstantiateClassGenerator.Execute<ListClosedWorkflowExecutionsRequest>();
            var marshaller = new ListClosedWorkflowExecutionsRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);                        
            Comparer.CompareObjectToJson<ListClosedWorkflowExecutionsRequest>(request,jsonRequest);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            var jsonResponse = new JsonSampleGenerator(service_model, service_model.FindOperation("ListClosedWorkflowExecutions").ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString());
            UnmarshallerContext context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), false, webResponse);
            var response = ListClosedWorkflowExecutionsResponseUnmarshaller.Instance.Unmarshall(context)
                as ListClosedWorkflowExecutionsResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("SimpleWorkflow")]
        public void ListDomainsMarshallTest()
        {
            var request = InstantiateClassGenerator.Execute<ListDomainsRequest>();
            var marshaller = new ListDomainsRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);                        
            Comparer.CompareObjectToJson<ListDomainsRequest>(request,jsonRequest);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            var jsonResponse = new JsonSampleGenerator(service_model, service_model.FindOperation("ListDomains").ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString());
            UnmarshallerContext context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), false, webResponse);
            var response = ListDomainsResponseUnmarshaller.Instance.Unmarshall(context)
                as ListDomainsResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("SimpleWorkflow")]
        public void ListOpenWorkflowExecutionsMarshallTest()
        {
            var request = InstantiateClassGenerator.Execute<ListOpenWorkflowExecutionsRequest>();
            var marshaller = new ListOpenWorkflowExecutionsRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);                        
            Comparer.CompareObjectToJson<ListOpenWorkflowExecutionsRequest>(request,jsonRequest);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            var jsonResponse = new JsonSampleGenerator(service_model, service_model.FindOperation("ListOpenWorkflowExecutions").ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString());
            UnmarshallerContext context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), false, webResponse);
            var response = ListOpenWorkflowExecutionsResponseUnmarshaller.Instance.Unmarshall(context)
                as ListOpenWorkflowExecutionsResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("SimpleWorkflow")]
        public void ListWorkflowTypesMarshallTest()
        {
            var request = InstantiateClassGenerator.Execute<ListWorkflowTypesRequest>();
            var marshaller = new ListWorkflowTypesRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);                        
            Comparer.CompareObjectToJson<ListWorkflowTypesRequest>(request,jsonRequest);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            var jsonResponse = new JsonSampleGenerator(service_model, service_model.FindOperation("ListWorkflowTypes").ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString());
            UnmarshallerContext context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), false, webResponse);
            var response = ListWorkflowTypesResponseUnmarshaller.Instance.Unmarshall(context)
                as ListWorkflowTypesResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("SimpleWorkflow")]
        public void PollForActivityTaskMarshallTest()
        {
            var request = InstantiateClassGenerator.Execute<PollForActivityTaskRequest>();
            var marshaller = new PollForActivityTaskRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);                        
            Comparer.CompareObjectToJson<PollForActivityTaskRequest>(request,jsonRequest);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            var jsonResponse = new JsonSampleGenerator(service_model, service_model.FindOperation("PollForActivityTask").ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString());
            UnmarshallerContext context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), false, webResponse);
            var response = PollForActivityTaskResponseUnmarshaller.Instance.Unmarshall(context)
                as PollForActivityTaskResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("SimpleWorkflow")]
        public void PollForDecisionTaskMarshallTest()
        {
            var request = InstantiateClassGenerator.Execute<PollForDecisionTaskRequest>();
            var marshaller = new PollForDecisionTaskRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);                        
            Comparer.CompareObjectToJson<PollForDecisionTaskRequest>(request,jsonRequest);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            var jsonResponse = new JsonSampleGenerator(service_model, service_model.FindOperation("PollForDecisionTask").ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString());
            UnmarshallerContext context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), false, webResponse);
            var response = PollForDecisionTaskResponseUnmarshaller.Instance.Unmarshall(context)
                as PollForDecisionTaskResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("SimpleWorkflow")]
        public void RecordActivityTaskHeartbeatMarshallTest()
        {
            var request = InstantiateClassGenerator.Execute<RecordActivityTaskHeartbeatRequest>();
            var marshaller = new RecordActivityTaskHeartbeatRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);                        
            Comparer.CompareObjectToJson<RecordActivityTaskHeartbeatRequest>(request,jsonRequest);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            var jsonResponse = new JsonSampleGenerator(service_model, service_model.FindOperation("RecordActivityTaskHeartbeat").ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString());
            UnmarshallerContext context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), false, webResponse);
            var response = RecordActivityTaskHeartbeatResponseUnmarshaller.Instance.Unmarshall(context)
                as RecordActivityTaskHeartbeatResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("SimpleWorkflow")]
        public void RegisterActivityTypeMarshallTest()
        {
            var request = InstantiateClassGenerator.Execute<RegisterActivityTypeRequest>();
            var marshaller = new RegisterActivityTypeRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);                        
            Comparer.CompareObjectToJson<RegisterActivityTypeRequest>(request,jsonRequest);

        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("SimpleWorkflow")]
        public void RegisterDomainMarshallTest()
        {
            var request = InstantiateClassGenerator.Execute<RegisterDomainRequest>();
            var marshaller = new RegisterDomainRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);                        
            Comparer.CompareObjectToJson<RegisterDomainRequest>(request,jsonRequest);

        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("SimpleWorkflow")]
        public void RegisterWorkflowTypeMarshallTest()
        {
            var request = InstantiateClassGenerator.Execute<RegisterWorkflowTypeRequest>();
            var marshaller = new RegisterWorkflowTypeRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);                        
            Comparer.CompareObjectToJson<RegisterWorkflowTypeRequest>(request,jsonRequest);

        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("SimpleWorkflow")]
        public void RequestCancelWorkflowExecutionMarshallTest()
        {
            var request = InstantiateClassGenerator.Execute<RequestCancelWorkflowExecutionRequest>();
            var marshaller = new RequestCancelWorkflowExecutionRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);                        
            Comparer.CompareObjectToJson<RequestCancelWorkflowExecutionRequest>(request,jsonRequest);

        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("SimpleWorkflow")]
        public void RespondActivityTaskCanceledMarshallTest()
        {
            var request = InstantiateClassGenerator.Execute<RespondActivityTaskCanceledRequest>();
            var marshaller = new RespondActivityTaskCanceledRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);                        
            Comparer.CompareObjectToJson<RespondActivityTaskCanceledRequest>(request,jsonRequest);

        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("SimpleWorkflow")]
        public void RespondActivityTaskCompletedMarshallTest()
        {
            var request = InstantiateClassGenerator.Execute<RespondActivityTaskCompletedRequest>();
            var marshaller = new RespondActivityTaskCompletedRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);                        
            Comparer.CompareObjectToJson<RespondActivityTaskCompletedRequest>(request,jsonRequest);

        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("SimpleWorkflow")]
        public void RespondActivityTaskFailedMarshallTest()
        {
            var request = InstantiateClassGenerator.Execute<RespondActivityTaskFailedRequest>();
            var marshaller = new RespondActivityTaskFailedRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);                        
            Comparer.CompareObjectToJson<RespondActivityTaskFailedRequest>(request,jsonRequest);

        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("SimpleWorkflow")]
        public void RespondDecisionTaskCompletedMarshallTest()
        {
            var request = InstantiateClassGenerator.Execute<RespondDecisionTaskCompletedRequest>();
            var marshaller = new RespondDecisionTaskCompletedRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);                        
            Comparer.CompareObjectToJson<RespondDecisionTaskCompletedRequest>(request,jsonRequest);

        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("SimpleWorkflow")]
        public void SignalWorkflowExecutionMarshallTest()
        {
            var request = InstantiateClassGenerator.Execute<SignalWorkflowExecutionRequest>();
            var marshaller = new SignalWorkflowExecutionRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);                        
            Comparer.CompareObjectToJson<SignalWorkflowExecutionRequest>(request,jsonRequest);

        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("SimpleWorkflow")]
        public void StartWorkflowExecutionMarshallTest()
        {
            var request = InstantiateClassGenerator.Execute<StartWorkflowExecutionRequest>();
            var marshaller = new StartWorkflowExecutionRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);                        
            Comparer.CompareObjectToJson<StartWorkflowExecutionRequest>(request,jsonRequest);

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            var jsonResponse = new JsonSampleGenerator(service_model, service_model.FindOperation("StartWorkflowExecution").ResponseStructure).Execute();
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString());
            UnmarshallerContext context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), false, webResponse);
            var response = StartWorkflowExecutionResponseUnmarshaller.Instance.Unmarshall(context)
                as StartWorkflowExecutionResponse;
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Json")]
        [TestCategory("SimpleWorkflow")]
        public void TerminateWorkflowExecutionMarshallTest()
        {
            var request = InstantiateClassGenerator.Execute<TerminateWorkflowExecutionRequest>();
            var marshaller = new TerminateWorkflowExecutionRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content);                        
            Comparer.CompareObjectToJson<TerminateWorkflowExecutionRequest>(request,jsonRequest);

        }

            }
}