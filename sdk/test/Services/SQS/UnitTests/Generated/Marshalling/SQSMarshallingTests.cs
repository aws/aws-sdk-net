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
 * Do not modify this file. This file is generated from the sqs-2012-11-05.normal.json service model.
 */


using System;
using System.IO;
using System.Linq;
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
        static readonly ServiceModel service_model = Utils.LoadServiceModel("sqs");
        
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
        public void AddPermission_OverLimitExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("AddPermission");

            var request = InstantiateClassGenerator.Execute<AddPermissionRequest>();
            var marshaller = new AddPermissionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("OverLimitException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = AddPermissionResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("SQS")]
        public void CancelMessageMoveTaskMarshallTest()
        {
            var operation = service_model.FindOperation("CancelMessageMoveTask");

            var request = InstantiateClassGenerator.Execute<CancelMessageMoveTaskRequest>();
            var marshaller = new CancelMessageMoveTaskRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = CancelMessageMoveTaskResponseUnmarshaller.Instance.Unmarshall(context)
                as CancelMessageMoveTaskResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("SQS")]
        public void CancelMessageMoveTask_ResourceNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CancelMessageMoveTask");

            var request = InstantiateClassGenerator.Execute<CancelMessageMoveTaskRequest>();
            var marshaller = new CancelMessageMoveTaskRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("ResourceNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CancelMessageMoveTaskResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("SQS")]
        public void CancelMessageMoveTask_UnsupportedOperationExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CancelMessageMoveTask");

            var request = InstantiateClassGenerator.Execute<CancelMessageMoveTaskRequest>();
            var marshaller = new CancelMessageMoveTaskRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("UnsupportedOperationException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CancelMessageMoveTaskResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
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
        public void ChangeMessageVisibility_MessageNotInflightExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ChangeMessageVisibility");

            var request = InstantiateClassGenerator.Execute<ChangeMessageVisibilityRequest>();
            var marshaller = new ChangeMessageVisibilityRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("MessageNotInflightException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = ChangeMessageVisibilityResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("SQS")]
        public void ChangeMessageVisibility_ReceiptHandleIsInvalidExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ChangeMessageVisibility");

            var request = InstantiateClassGenerator.Execute<ChangeMessageVisibilityRequest>();
            var marshaller = new ChangeMessageVisibilityRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("ReceiptHandleIsInvalidException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = ChangeMessageVisibilityResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
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
        public void ChangeMessageVisibilityBatch_BatchEntryIdsNotDistinctExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ChangeMessageVisibilityBatch");

            var request = InstantiateClassGenerator.Execute<ChangeMessageVisibilityBatchRequest>();
            var marshaller = new ChangeMessageVisibilityBatchRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("BatchEntryIdsNotDistinctException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = ChangeMessageVisibilityBatchResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("SQS")]
        public void ChangeMessageVisibilityBatch_EmptyBatchRequestExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ChangeMessageVisibilityBatch");

            var request = InstantiateClassGenerator.Execute<ChangeMessageVisibilityBatchRequest>();
            var marshaller = new ChangeMessageVisibilityBatchRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("EmptyBatchRequestException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = ChangeMessageVisibilityBatchResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("SQS")]
        public void ChangeMessageVisibilityBatch_InvalidBatchEntryIdExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ChangeMessageVisibilityBatch");

            var request = InstantiateClassGenerator.Execute<ChangeMessageVisibilityBatchRequest>();
            var marshaller = new ChangeMessageVisibilityBatchRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidBatchEntryIdException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = ChangeMessageVisibilityBatchResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("SQS")]
        public void ChangeMessageVisibilityBatch_TooManyEntriesInBatchRequestExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ChangeMessageVisibilityBatch");

            var request = InstantiateClassGenerator.Execute<ChangeMessageVisibilityBatchRequest>();
            var marshaller = new ChangeMessageVisibilityBatchRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("TooManyEntriesInBatchRequestException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = ChangeMessageVisibilityBatchResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

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
        public void CreateQueue_QueueDeletedRecentlyExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateQueue");

            var request = InstantiateClassGenerator.Execute<CreateQueueRequest>();
            var marshaller = new CreateQueueRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("QueueDeletedRecentlyException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateQueueResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("SQS")]
        public void CreateQueue_QueueNameExistsExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateQueue");

            var request = InstantiateClassGenerator.Execute<CreateQueueRequest>();
            var marshaller = new CreateQueueRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("QueueNameExistsException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateQueueResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

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
        public void DeleteMessage_InvalidIdFormatExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteMessage");

            var request = InstantiateClassGenerator.Execute<DeleteMessageRequest>();
            var marshaller = new DeleteMessageRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidIdFormatException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DeleteMessageResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("SQS")]
        public void DeleteMessage_ReceiptHandleIsInvalidExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteMessage");

            var request = InstantiateClassGenerator.Execute<DeleteMessageRequest>();
            var marshaller = new DeleteMessageRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("ReceiptHandleIsInvalidException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DeleteMessageResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
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
        public void DeleteMessageBatch_BatchEntryIdsNotDistinctExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteMessageBatch");

            var request = InstantiateClassGenerator.Execute<DeleteMessageBatchRequest>();
            var marshaller = new DeleteMessageBatchRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("BatchEntryIdsNotDistinctException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DeleteMessageBatchResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("SQS")]
        public void DeleteMessageBatch_EmptyBatchRequestExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteMessageBatch");

            var request = InstantiateClassGenerator.Execute<DeleteMessageBatchRequest>();
            var marshaller = new DeleteMessageBatchRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("EmptyBatchRequestException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DeleteMessageBatchResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("SQS")]
        public void DeleteMessageBatch_InvalidBatchEntryIdExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteMessageBatch");

            var request = InstantiateClassGenerator.Execute<DeleteMessageBatchRequest>();
            var marshaller = new DeleteMessageBatchRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidBatchEntryIdException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DeleteMessageBatchResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("SQS")]
        public void DeleteMessageBatch_TooManyEntriesInBatchRequestExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteMessageBatch");

            var request = InstantiateClassGenerator.Execute<DeleteMessageBatchRequest>();
            var marshaller = new DeleteMessageBatchRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("TooManyEntriesInBatchRequestException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DeleteMessageBatchResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

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
        public void GetQueueAttributes_InvalidAttributeNameExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("GetQueueAttributes");

            var request = InstantiateClassGenerator.Execute<GetQueueAttributesRequest>();
            var marshaller = new GetQueueAttributesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidAttributeNameException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = GetQueueAttributesResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

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
        public void GetQueueUrl_QueueDoesNotExistExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("GetQueueUrl");

            var request = InstantiateClassGenerator.Execute<GetQueueUrlRequest>();
            var marshaller = new GetQueueUrlRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("QueueDoesNotExistException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = GetQueueUrlResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

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
        public void ListDeadLetterSourceQueues_QueueDoesNotExistExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ListDeadLetterSourceQueues");

            var request = InstantiateClassGenerator.Execute<ListDeadLetterSourceQueuesRequest>();
            var marshaller = new ListDeadLetterSourceQueuesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("QueueDoesNotExistException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = ListDeadLetterSourceQueuesResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("SQS")]
        public void ListMessageMoveTasksMarshallTest()
        {
            var operation = service_model.FindOperation("ListMessageMoveTasks");

            var request = InstantiateClassGenerator.Execute<ListMessageMoveTasksRequest>();
            var marshaller = new ListMessageMoveTasksRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = ListMessageMoveTasksResponseUnmarshaller.Instance.Unmarshall(context)
                as ListMessageMoveTasksResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("SQS")]
        public void ListMessageMoveTasks_ResourceNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ListMessageMoveTasks");

            var request = InstantiateClassGenerator.Execute<ListMessageMoveTasksRequest>();
            var marshaller = new ListMessageMoveTasksRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("ResourceNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = ListMessageMoveTasksResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("SQS")]
        public void ListMessageMoveTasks_UnsupportedOperationExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ListMessageMoveTasks");

            var request = InstantiateClassGenerator.Execute<ListMessageMoveTasksRequest>();
            var marshaller = new ListMessageMoveTasksRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("UnsupportedOperationException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = ListMessageMoveTasksResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

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
        public void ListQueueTagsMarshallTest()
        {
            var operation = service_model.FindOperation("ListQueueTags");

            var request = InstantiateClassGenerator.Execute<ListQueueTagsRequest>();
            var marshaller = new ListQueueTagsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = ListQueueTagsResponseUnmarshaller.Instance.Unmarshall(context)
                as ListQueueTagsResponse;   
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
        public void PurgeQueue_PurgeQueueInProgressExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("PurgeQueue");

            var request = InstantiateClassGenerator.Execute<PurgeQueueRequest>();
            var marshaller = new PurgeQueueRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("PurgeQueueInProgressException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = PurgeQueueResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("SQS")]
        public void PurgeQueue_QueueDoesNotExistExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("PurgeQueue");

            var request = InstantiateClassGenerator.Execute<PurgeQueueRequest>();
            var marshaller = new PurgeQueueRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("QueueDoesNotExistException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = PurgeQueueResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
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
        public void ReceiveMessage_OverLimitExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ReceiveMessage");

            var request = InstantiateClassGenerator.Execute<ReceiveMessageRequest>();
            var marshaller = new ReceiveMessageRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("OverLimitException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = ReceiveMessageResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

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
        public void SendMessage_InvalidMessageContentsExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("SendMessage");

            var request = InstantiateClassGenerator.Execute<SendMessageRequest>();
            var marshaller = new SendMessageRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidMessageContentsException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = SendMessageResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("SQS")]
        public void SendMessage_UnsupportedOperationExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("SendMessage");

            var request = InstantiateClassGenerator.Execute<SendMessageRequest>();
            var marshaller = new SendMessageRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("UnsupportedOperationException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = SendMessageResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

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
        public void SendMessageBatch_BatchEntryIdsNotDistinctExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("SendMessageBatch");

            var request = InstantiateClassGenerator.Execute<SendMessageBatchRequest>();
            var marshaller = new SendMessageBatchRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("BatchEntryIdsNotDistinctException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = SendMessageBatchResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("SQS")]
        public void SendMessageBatch_BatchRequestTooLongExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("SendMessageBatch");

            var request = InstantiateClassGenerator.Execute<SendMessageBatchRequest>();
            var marshaller = new SendMessageBatchRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("BatchRequestTooLongException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = SendMessageBatchResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("SQS")]
        public void SendMessageBatch_EmptyBatchRequestExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("SendMessageBatch");

            var request = InstantiateClassGenerator.Execute<SendMessageBatchRequest>();
            var marshaller = new SendMessageBatchRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("EmptyBatchRequestException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = SendMessageBatchResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("SQS")]
        public void SendMessageBatch_InvalidBatchEntryIdExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("SendMessageBatch");

            var request = InstantiateClassGenerator.Execute<SendMessageBatchRequest>();
            var marshaller = new SendMessageBatchRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidBatchEntryIdException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = SendMessageBatchResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("SQS")]
        public void SendMessageBatch_TooManyEntriesInBatchRequestExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("SendMessageBatch");

            var request = InstantiateClassGenerator.Execute<SendMessageBatchRequest>();
            var marshaller = new SendMessageBatchRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("TooManyEntriesInBatchRequestException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = SendMessageBatchResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("SQS")]
        public void SendMessageBatch_UnsupportedOperationExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("SendMessageBatch");

            var request = InstantiateClassGenerator.Execute<SendMessageBatchRequest>();
            var marshaller = new SendMessageBatchRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("UnsupportedOperationException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = SendMessageBatchResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

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

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("SQS")]
        public void SetQueueAttributes_InvalidAttributeNameExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("SetQueueAttributes");

            var request = InstantiateClassGenerator.Execute<SetQueueAttributesRequest>();
            var marshaller = new SetQueueAttributesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidAttributeNameException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = SetQueueAttributesResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("SQS")]
        public void StartMessageMoveTaskMarshallTest()
        {
            var operation = service_model.FindOperation("StartMessageMoveTask");

            var request = InstantiateClassGenerator.Execute<StartMessageMoveTaskRequest>();
            var marshaller = new StartMessageMoveTaskRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = StartMessageMoveTaskResponseUnmarshaller.Instance.Unmarshall(context)
                as StartMessageMoveTaskResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("SQS")]
        public void StartMessageMoveTask_ResourceNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("StartMessageMoveTask");

            var request = InstantiateClassGenerator.Execute<StartMessageMoveTaskRequest>();
            var marshaller = new StartMessageMoveTaskRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("ResourceNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = StartMessageMoveTaskResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("SQS")]
        public void StartMessageMoveTask_UnsupportedOperationExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("StartMessageMoveTask");

            var request = InstantiateClassGenerator.Execute<StartMessageMoveTaskRequest>();
            var marshaller = new StartMessageMoveTaskRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("UnsupportedOperationException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = StartMessageMoveTaskResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("SQS")]
        public void TagQueueMarshallTest()
        {
            var operation = service_model.FindOperation("TagQueue");

            var request = InstantiateClassGenerator.Execute<TagQueueRequest>();
            var marshaller = new TagQueueRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("SQS")]
        public void UntagQueueMarshallTest()
        {
            var operation = service_model.FindOperation("UntagQueue");

            var request = InstantiateClassGenerator.Execute<UntagQueueRequest>();
            var marshaller = new UntagQueueRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


        }
    }
}