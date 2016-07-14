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
 * Do not modify this file. This file is generated from the sns-2010-03-31.normal.json service model.
 */


using System;
using System.IO;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Amazon.SimpleNotificationService;
using Amazon.SimpleNotificationService.Model;
using Amazon.SimpleNotificationService.Model.Internal.MarshallTransformations;
using Amazon.Runtime.Internal.Transform;

using ServiceClientGenerator;

using AWSSDK_DotNet35.UnitTests.TestTools;

namespace AWSSDK_DotNet35.UnitTests.Marshalling
{
    [TestClass]
    public class SimpleNotificationServiceMarshallingTests
    {
        static readonly ServiceModel service_model = Utils.LoadServiceModel("sns-2010-03-31.normal.json", "sns.customizations.json");
        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("SimpleNotificationService")]
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
        [TestCategory("SimpleNotificationService")]
        public void CheckIfPhoneNumberIsOptedOutMarshallTest()
        {
            var operation = service_model.FindOperation("CheckIfPhoneNumberIsOptedOut");

            var request = InstantiateClassGenerator.Execute<CheckIfPhoneNumberIsOptedOutRequest>();
            var marshaller = new CheckIfPhoneNumberIsOptedOutRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = CheckIfPhoneNumberIsOptedOutResponseUnmarshaller.Instance.Unmarshall(context)
                as CheckIfPhoneNumberIsOptedOutResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("SimpleNotificationService")]
        public void ConfirmSubscriptionMarshallTest()
        {
            var operation = service_model.FindOperation("ConfirmSubscription");

            var request = InstantiateClassGenerator.Execute<ConfirmSubscriptionRequest>();
            var marshaller = new ConfirmSubscriptionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = ConfirmSubscriptionResponseUnmarshaller.Instance.Unmarshall(context)
                as ConfirmSubscriptionResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("SimpleNotificationService")]
        public void CreatePlatformApplicationMarshallTest()
        {
            var operation = service_model.FindOperation("CreatePlatformApplication");

            var request = InstantiateClassGenerator.Execute<CreatePlatformApplicationRequest>();
            var marshaller = new CreatePlatformApplicationRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = CreatePlatformApplicationResponseUnmarshaller.Instance.Unmarshall(context)
                as CreatePlatformApplicationResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("SimpleNotificationService")]
        public void CreatePlatformEndpointMarshallTest()
        {
            var operation = service_model.FindOperation("CreatePlatformEndpoint");

            var request = InstantiateClassGenerator.Execute<CreatePlatformEndpointRequest>();
            var marshaller = new CreatePlatformEndpointRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = CreatePlatformEndpointResponseUnmarshaller.Instance.Unmarshall(context)
                as CreatePlatformEndpointResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("SimpleNotificationService")]
        public void CreateTopicMarshallTest()
        {
            var operation = service_model.FindOperation("CreateTopic");

            var request = InstantiateClassGenerator.Execute<CreateTopicRequest>();
            var marshaller = new CreateTopicRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = CreateTopicResponseUnmarshaller.Instance.Unmarshall(context)
                as CreateTopicResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("SimpleNotificationService")]
        public void DeleteEndpointMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteEndpoint");

            var request = InstantiateClassGenerator.Execute<DeleteEndpointRequest>();
            var marshaller = new DeleteEndpointRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("SimpleNotificationService")]
        public void DeletePlatformApplicationMarshallTest()
        {
            var operation = service_model.FindOperation("DeletePlatformApplication");

            var request = InstantiateClassGenerator.Execute<DeletePlatformApplicationRequest>();
            var marshaller = new DeletePlatformApplicationRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("SimpleNotificationService")]
        public void DeleteTopicMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteTopic");

            var request = InstantiateClassGenerator.Execute<DeleteTopicRequest>();
            var marshaller = new DeleteTopicRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("SimpleNotificationService")]
        public void GetEndpointAttributesMarshallTest()
        {
            var operation = service_model.FindOperation("GetEndpointAttributes");

            var request = InstantiateClassGenerator.Execute<GetEndpointAttributesRequest>();
            var marshaller = new GetEndpointAttributesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = GetEndpointAttributesResponseUnmarshaller.Instance.Unmarshall(context)
                as GetEndpointAttributesResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("SimpleNotificationService")]
        public void GetPlatformApplicationAttributesMarshallTest()
        {
            var operation = service_model.FindOperation("GetPlatformApplicationAttributes");

            var request = InstantiateClassGenerator.Execute<GetPlatformApplicationAttributesRequest>();
            var marshaller = new GetPlatformApplicationAttributesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = GetPlatformApplicationAttributesResponseUnmarshaller.Instance.Unmarshall(context)
                as GetPlatformApplicationAttributesResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("SimpleNotificationService")]
        public void GetSMSAttributesMarshallTest()
        {
            var operation = service_model.FindOperation("GetSMSAttributes");

            var request = InstantiateClassGenerator.Execute<GetSMSAttributesRequest>();
            var marshaller = new GetSMSAttributesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = GetSMSAttributesResponseUnmarshaller.Instance.Unmarshall(context)
                as GetSMSAttributesResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("SimpleNotificationService")]
        public void GetSubscriptionAttributesMarshallTest()
        {
            var operation = service_model.FindOperation("GetSubscriptionAttributes");

            var request = InstantiateClassGenerator.Execute<GetSubscriptionAttributesRequest>();
            var marshaller = new GetSubscriptionAttributesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = GetSubscriptionAttributesResponseUnmarshaller.Instance.Unmarshall(context)
                as GetSubscriptionAttributesResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("SimpleNotificationService")]
        public void GetTopicAttributesMarshallTest()
        {
            var operation = service_model.FindOperation("GetTopicAttributes");

            var request = InstantiateClassGenerator.Execute<GetTopicAttributesRequest>();
            var marshaller = new GetTopicAttributesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = GetTopicAttributesResponseUnmarshaller.Instance.Unmarshall(context)
                as GetTopicAttributesResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("SimpleNotificationService")]
        public void ListEndpointsByPlatformApplicationMarshallTest()
        {
            var operation = service_model.FindOperation("ListEndpointsByPlatformApplication");

            var request = InstantiateClassGenerator.Execute<ListEndpointsByPlatformApplicationRequest>();
            var marshaller = new ListEndpointsByPlatformApplicationRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = ListEndpointsByPlatformApplicationResponseUnmarshaller.Instance.Unmarshall(context)
                as ListEndpointsByPlatformApplicationResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("SimpleNotificationService")]
        public void ListPhoneNumbersOptedOutMarshallTest()
        {
            var operation = service_model.FindOperation("ListPhoneNumbersOptedOut");

            var request = InstantiateClassGenerator.Execute<ListPhoneNumbersOptedOutRequest>();
            var marshaller = new ListPhoneNumbersOptedOutRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = ListPhoneNumbersOptedOutResponseUnmarshaller.Instance.Unmarshall(context)
                as ListPhoneNumbersOptedOutResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("SimpleNotificationService")]
        public void ListPlatformApplicationsMarshallTest()
        {
            var operation = service_model.FindOperation("ListPlatformApplications");

            var request = InstantiateClassGenerator.Execute<ListPlatformApplicationsRequest>();
            var marshaller = new ListPlatformApplicationsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = ListPlatformApplicationsResponseUnmarshaller.Instance.Unmarshall(context)
                as ListPlatformApplicationsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("SimpleNotificationService")]
        public void ListSubscriptionsMarshallTest()
        {
            var operation = service_model.FindOperation("ListSubscriptions");

            var request = InstantiateClassGenerator.Execute<ListSubscriptionsRequest>();
            var marshaller = new ListSubscriptionsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = ListSubscriptionsResponseUnmarshaller.Instance.Unmarshall(context)
                as ListSubscriptionsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("SimpleNotificationService")]
        public void ListSubscriptionsByTopicMarshallTest()
        {
            var operation = service_model.FindOperation("ListSubscriptionsByTopic");

            var request = InstantiateClassGenerator.Execute<ListSubscriptionsByTopicRequest>();
            var marshaller = new ListSubscriptionsByTopicRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = ListSubscriptionsByTopicResponseUnmarshaller.Instance.Unmarshall(context)
                as ListSubscriptionsByTopicResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("SimpleNotificationService")]
        public void ListTopicsMarshallTest()
        {
            var operation = service_model.FindOperation("ListTopics");

            var request = InstantiateClassGenerator.Execute<ListTopicsRequest>();
            var marshaller = new ListTopicsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = ListTopicsResponseUnmarshaller.Instance.Unmarshall(context)
                as ListTopicsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("SimpleNotificationService")]
        public void OptInPhoneNumberMarshallTest()
        {
            var operation = service_model.FindOperation("OptInPhoneNumber");

            var request = InstantiateClassGenerator.Execute<OptInPhoneNumberRequest>();
            var marshaller = new OptInPhoneNumberRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = OptInPhoneNumberResponseUnmarshaller.Instance.Unmarshall(context)
                as OptInPhoneNumberResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("SimpleNotificationService")]
        public void PublishMarshallTest()
        {
            var operation = service_model.FindOperation("Publish");

            var request = InstantiateClassGenerator.Execute<PublishRequest>();
            var marshaller = new PublishRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = PublishResponseUnmarshaller.Instance.Unmarshall(context)
                as PublishResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("SimpleNotificationService")]
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
        [TestCategory("SimpleNotificationService")]
        public void SetEndpointAttributesMarshallTest()
        {
            var operation = service_model.FindOperation("SetEndpointAttributes");

            var request = InstantiateClassGenerator.Execute<SetEndpointAttributesRequest>();
            var marshaller = new SetEndpointAttributesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("SimpleNotificationService")]
        public void SetPlatformApplicationAttributesMarshallTest()
        {
            var operation = service_model.FindOperation("SetPlatformApplicationAttributes");

            var request = InstantiateClassGenerator.Execute<SetPlatformApplicationAttributesRequest>();
            var marshaller = new SetPlatformApplicationAttributesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("SimpleNotificationService")]
        public void SetSMSAttributesMarshallTest()
        {
            var operation = service_model.FindOperation("SetSMSAttributes");

            var request = InstantiateClassGenerator.Execute<SetSMSAttributesRequest>();
            var marshaller = new SetSMSAttributesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = SetSMSAttributesResponseUnmarshaller.Instance.Unmarshall(context)
                as SetSMSAttributesResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("SimpleNotificationService")]
        public void SetSubscriptionAttributesMarshallTest()
        {
            var operation = service_model.FindOperation("SetSubscriptionAttributes");

            var request = InstantiateClassGenerator.Execute<SetSubscriptionAttributesRequest>();
            var marshaller = new SetSubscriptionAttributesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("SimpleNotificationService")]
        public void SetTopicAttributesMarshallTest()
        {
            var operation = service_model.FindOperation("SetTopicAttributes");

            var request = InstantiateClassGenerator.Execute<SetTopicAttributesRequest>();
            var marshaller = new SetTopicAttributesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("SimpleNotificationService")]
        public void SubscribeMarshallTest()
        {
            var operation = service_model.FindOperation("Subscribe");

            var request = InstantiateClassGenerator.Execute<SubscribeRequest>();
            var marshaller = new SubscribeRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = SubscribeResponseUnmarshaller.Instance.Unmarshall(context)
                as SubscribeResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("SimpleNotificationService")]
        public void UnsubscribeMarshallTest()
        {
            var operation = service_model.FindOperation("Unsubscribe");

            var request = InstantiateClassGenerator.Execute<UnsubscribeRequest>();
            var marshaller = new UnsubscribeRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


        }

        
    }
}