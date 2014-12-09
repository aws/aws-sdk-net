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
 * Do not modify this file. This file is generated from the sqs-2012-11-05.normal.json service model.
 */


using System;
using System.IO;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Amazon.SQS;
using Amazon.SQS.Model;
using Amazon.SQS.Model.Internal.MarshallTransformations;
using Amazon.Runtime.Internal.Transform;

using ServiceClientGenerator;

using AWSSDK_DotNet35.UnitTests.TestTools;

namespace AWSSDK_DotNet35.UnitTests.Marshalling
{
    [TestClass]
    public class SQSMarshallingTests
    {
        static readonly ServiceModel service_model = Utils.LoadServiceModel("sqs-2012-11-05.normal.json", "sqs.customizations.json");
        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("SQS")]
        public void AddPermissionMarshallTest()
        {
            var operation = service_model.FindOperation("AddPermission");

            var request = InstantiateClassGenerator.Execute<AddPermissionRequest>();
            var marshaller = new AddPermissionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("SQS")]
        public void ChangeMessageVisibilityMarshallTest()
        {
            var operation = service_model.FindOperation("ChangeMessageVisibility");

            var request = InstantiateClassGenerator.Execute<ChangeMessageVisibilityRequest>();
            var marshaller = new ChangeMessageVisibilityRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("SQS")]
        public void ChangeMessageVisibilityBatchMarshallTest()
        {
            var operation = service_model.FindOperation("ChangeMessageVisibilityBatch");

            var request = InstantiateClassGenerator.Execute<ChangeMessageVisibilityBatchRequest>();
            var marshaller = new ChangeMessageVisibilityBatchRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = ChangeMessageVisibilityBatchResponseUnmarshaller.Instance.Unmarshall(context)
                as ChangeMessageVisibilityBatchResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("SQS")]
        public void CreateQueueMarshallTest()
        {
            var operation = service_model.FindOperation("CreateQueue");

            var request = InstantiateClassGenerator.Execute<CreateQueueRequest>();
            var marshaller = new CreateQueueRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = CreateQueueResponseUnmarshaller.Instance.Unmarshall(context)
                as CreateQueueResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("SQS")]
        public void DeleteMessageMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteMessage");

            var request = InstantiateClassGenerator.Execute<DeleteMessageRequest>();
            var marshaller = new DeleteMessageRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("SQS")]
        public void DeleteMessageBatchMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteMessageBatch");

            var request = InstantiateClassGenerator.Execute<DeleteMessageBatchRequest>();
            var marshaller = new DeleteMessageBatchRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = DeleteMessageBatchResponseUnmarshaller.Instance.Unmarshall(context)
                as DeleteMessageBatchResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("SQS")]
        public void DeleteQueueMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteQueue");

            var request = InstantiateClassGenerator.Execute<DeleteQueueRequest>();
            var marshaller = new DeleteQueueRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("SQS")]
        public void GetQueueAttributesMarshallTest()
        {
            var operation = service_model.FindOperation("GetQueueAttributes");

            var request = InstantiateClassGenerator.Execute<GetQueueAttributesRequest>();
            var marshaller = new GetQueueAttributesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = GetQueueAttributesResponseUnmarshaller.Instance.Unmarshall(context)
                as GetQueueAttributesResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("SQS")]
        public void GetQueueUrlMarshallTest()
        {
            var operation = service_model.FindOperation("GetQueueUrl");

            var request = InstantiateClassGenerator.Execute<GetQueueUrlRequest>();
            var marshaller = new GetQueueUrlRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = GetQueueUrlResponseUnmarshaller.Instance.Unmarshall(context)
                as GetQueueUrlResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("SQS")]
        public void ListDeadLetterSourceQueuesMarshallTest()
        {
            var operation = service_model.FindOperation("ListDeadLetterSourceQueues");

            var request = InstantiateClassGenerator.Execute<ListDeadLetterSourceQueuesRequest>();
            var marshaller = new ListDeadLetterSourceQueuesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = ListDeadLetterSourceQueuesResponseUnmarshaller.Instance.Unmarshall(context)
                as ListDeadLetterSourceQueuesResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("SQS")]
        public void ListQueuesMarshallTest()
        {
            var operation = service_model.FindOperation("ListQueues");

            var request = InstantiateClassGenerator.Execute<ListQueuesRequest>();
            var marshaller = new ListQueuesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = ListQueuesResponseUnmarshaller.Instance.Unmarshall(context)
                as ListQueuesResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("SQS")]
        public void PurgeQueueMarshallTest()
        {
            var operation = service_model.FindOperation("PurgeQueue");

            var request = InstantiateClassGenerator.Execute<PurgeQueueRequest>();
            var marshaller = new PurgeQueueRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("SQS")]
        public void ReceiveMessageMarshallTest()
        {
            var operation = service_model.FindOperation("ReceiveMessage");

            var request = InstantiateClassGenerator.Execute<ReceiveMessageRequest>();
            var marshaller = new ReceiveMessageRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = ReceiveMessageResponseUnmarshaller.Instance.Unmarshall(context)
                as ReceiveMessageResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("SQS")]
        public void RemovePermissionMarshallTest()
        {
            var operation = service_model.FindOperation("RemovePermission");

            var request = InstantiateClassGenerator.Execute<RemovePermissionRequest>();
            var marshaller = new RemovePermissionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("SQS")]
        public void SendMessageMarshallTest()
        {
            var operation = service_model.FindOperation("SendMessage");

            var request = InstantiateClassGenerator.Execute<SendMessageRequest>();
            var marshaller = new SendMessageRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = SendMessageResponseUnmarshaller.Instance.Unmarshall(context)
                as SendMessageResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("SQS")]
        public void SendMessageBatchMarshallTest()
        {
            var operation = service_model.FindOperation("SendMessageBatch");

            var request = InstantiateClassGenerator.Execute<SendMessageBatchRequest>();
            var marshaller = new SendMessageBatchRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = SendMessageBatchResponseUnmarshaller.Instance.Unmarshall(context)
                as SendMessageBatchResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("SQS")]
        public void SetQueueAttributesMarshallTest()
        {
            var operation = service_model.FindOperation("SetQueueAttributes");

            var request = InstantiateClassGenerator.Execute<SetQueueAttributesRequest>();
            var marshaller = new SetQueueAttributesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


        }

        
    }
}