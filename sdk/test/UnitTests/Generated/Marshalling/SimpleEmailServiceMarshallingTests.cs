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
 * Do not modify this file. This file is generated from the email-2010-12-01.normal.json service model.
 */


using System;
using System.IO;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Amazon.SimpleEmail;
using Amazon.SimpleEmail.Model;
using Amazon.SimpleEmail.Model.Internal.MarshallTransformations;
using Amazon.Runtime.Internal.Transform;

using ServiceClientGenerator;

using AWSSDK_DotNet35.UnitTests.TestTools;

namespace AWSSDK_DotNet35.UnitTests.Marshalling
{
    [TestClass]
    public class SimpleEmailServiceMarshallingTests
    {
        static readonly ServiceModel service_model = Utils.LoadServiceModel("email-2010-12-01.normal.json", "email.customizations.json");
        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("SimpleEmailService")]
        public void DeleteIdentityMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteIdentity");

            var request = InstantiateClassGenerator.Execute<DeleteIdentityRequest>();
            var marshaller = new DeleteIdentityRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = DeleteIdentityResponseUnmarshaller.Instance.Unmarshall(context)
                as DeleteIdentityResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("SimpleEmailService")]
        public void DeleteIdentityPolicyMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteIdentityPolicy");

            var request = InstantiateClassGenerator.Execute<DeleteIdentityPolicyRequest>();
            var marshaller = new DeleteIdentityPolicyRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = DeleteIdentityPolicyResponseUnmarshaller.Instance.Unmarshall(context)
                as DeleteIdentityPolicyResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("SimpleEmailService")]
        public void DeleteVerifiedEmailAddressMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteVerifiedEmailAddress");

            var request = InstantiateClassGenerator.Execute<DeleteVerifiedEmailAddressRequest>();
            var marshaller = new DeleteVerifiedEmailAddressRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("SimpleEmailService")]
        public void GetIdentityDkimAttributesMarshallTest()
        {
            var operation = service_model.FindOperation("GetIdentityDkimAttributes");

            var request = InstantiateClassGenerator.Execute<GetIdentityDkimAttributesRequest>();
            var marshaller = new GetIdentityDkimAttributesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = GetIdentityDkimAttributesResponseUnmarshaller.Instance.Unmarshall(context)
                as GetIdentityDkimAttributesResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("SimpleEmailService")]
        public void GetIdentityNotificationAttributesMarshallTest()
        {
            var operation = service_model.FindOperation("GetIdentityNotificationAttributes");

            var request = InstantiateClassGenerator.Execute<GetIdentityNotificationAttributesRequest>();
            var marshaller = new GetIdentityNotificationAttributesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = GetIdentityNotificationAttributesResponseUnmarshaller.Instance.Unmarshall(context)
                as GetIdentityNotificationAttributesResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("SimpleEmailService")]
        public void GetIdentityPoliciesMarshallTest()
        {
            var operation = service_model.FindOperation("GetIdentityPolicies");

            var request = InstantiateClassGenerator.Execute<GetIdentityPoliciesRequest>();
            var marshaller = new GetIdentityPoliciesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = GetIdentityPoliciesResponseUnmarshaller.Instance.Unmarshall(context)
                as GetIdentityPoliciesResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("SimpleEmailService")]
        public void GetIdentityVerificationAttributesMarshallTest()
        {
            var operation = service_model.FindOperation("GetIdentityVerificationAttributes");

            var request = InstantiateClassGenerator.Execute<GetIdentityVerificationAttributesRequest>();
            var marshaller = new GetIdentityVerificationAttributesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = GetIdentityVerificationAttributesResponseUnmarshaller.Instance.Unmarshall(context)
                as GetIdentityVerificationAttributesResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("SimpleEmailService")]
        public void GetSendQuotaMarshallTest()
        {
            var operation = service_model.FindOperation("GetSendQuota");

            var request = InstantiateClassGenerator.Execute<GetSendQuotaRequest>();
            var marshaller = new GetSendQuotaRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = GetSendQuotaResponseUnmarshaller.Instance.Unmarshall(context)
                as GetSendQuotaResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("SimpleEmailService")]
        public void GetSendStatisticsMarshallTest()
        {
            var operation = service_model.FindOperation("GetSendStatistics");

            var request = InstantiateClassGenerator.Execute<GetSendStatisticsRequest>();
            var marshaller = new GetSendStatisticsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = GetSendStatisticsResponseUnmarshaller.Instance.Unmarshall(context)
                as GetSendStatisticsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("SimpleEmailService")]
        public void ListIdentitiesMarshallTest()
        {
            var operation = service_model.FindOperation("ListIdentities");

            var request = InstantiateClassGenerator.Execute<ListIdentitiesRequest>();
            var marshaller = new ListIdentitiesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = ListIdentitiesResponseUnmarshaller.Instance.Unmarshall(context)
                as ListIdentitiesResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("SimpleEmailService")]
        public void ListIdentityPoliciesMarshallTest()
        {
            var operation = service_model.FindOperation("ListIdentityPolicies");

            var request = InstantiateClassGenerator.Execute<ListIdentityPoliciesRequest>();
            var marshaller = new ListIdentityPoliciesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = ListIdentityPoliciesResponseUnmarshaller.Instance.Unmarshall(context)
                as ListIdentityPoliciesResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("SimpleEmailService")]
        public void ListVerifiedEmailAddressesMarshallTest()
        {
            var operation = service_model.FindOperation("ListVerifiedEmailAddresses");

            var request = InstantiateClassGenerator.Execute<ListVerifiedEmailAddressesRequest>();
            var marshaller = new ListVerifiedEmailAddressesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = ListVerifiedEmailAddressesResponseUnmarshaller.Instance.Unmarshall(context)
                as ListVerifiedEmailAddressesResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("SimpleEmailService")]
        public void PutIdentityPolicyMarshallTest()
        {
            var operation = service_model.FindOperation("PutIdentityPolicy");

            var request = InstantiateClassGenerator.Execute<PutIdentityPolicyRequest>();
            var marshaller = new PutIdentityPolicyRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = PutIdentityPolicyResponseUnmarshaller.Instance.Unmarshall(context)
                as PutIdentityPolicyResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("SimpleEmailService")]
        public void SendEmailMarshallTest()
        {
            var operation = service_model.FindOperation("SendEmail");

            var request = InstantiateClassGenerator.Execute<SendEmailRequest>();
            var marshaller = new SendEmailRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = SendEmailResponseUnmarshaller.Instance.Unmarshall(context)
                as SendEmailResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("SimpleEmailService")]
        public void SendRawEmailMarshallTest()
        {
            var operation = service_model.FindOperation("SendRawEmail");

            var request = InstantiateClassGenerator.Execute<SendRawEmailRequest>();
            var marshaller = new SendRawEmailRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = SendRawEmailResponseUnmarshaller.Instance.Unmarshall(context)
                as SendRawEmailResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("SimpleEmailService")]
        public void SetIdentityDkimEnabledMarshallTest()
        {
            var operation = service_model.FindOperation("SetIdentityDkimEnabled");

            var request = InstantiateClassGenerator.Execute<SetIdentityDkimEnabledRequest>();
            var marshaller = new SetIdentityDkimEnabledRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = SetIdentityDkimEnabledResponseUnmarshaller.Instance.Unmarshall(context)
                as SetIdentityDkimEnabledResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("SimpleEmailService")]
        public void SetIdentityFeedbackForwardingEnabledMarshallTest()
        {
            var operation = service_model.FindOperation("SetIdentityFeedbackForwardingEnabled");

            var request = InstantiateClassGenerator.Execute<SetIdentityFeedbackForwardingEnabledRequest>();
            var marshaller = new SetIdentityFeedbackForwardingEnabledRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = SetIdentityFeedbackForwardingEnabledResponseUnmarshaller.Instance.Unmarshall(context)
                as SetIdentityFeedbackForwardingEnabledResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("SimpleEmailService")]
        public void SetIdentityNotificationTopicMarshallTest()
        {
            var operation = service_model.FindOperation("SetIdentityNotificationTopic");

            var request = InstantiateClassGenerator.Execute<SetIdentityNotificationTopicRequest>();
            var marshaller = new SetIdentityNotificationTopicRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = SetIdentityNotificationTopicResponseUnmarshaller.Instance.Unmarshall(context)
                as SetIdentityNotificationTopicResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("SimpleEmailService")]
        public void VerifyDomainDkimMarshallTest()
        {
            var operation = service_model.FindOperation("VerifyDomainDkim");

            var request = InstantiateClassGenerator.Execute<VerifyDomainDkimRequest>();
            var marshaller = new VerifyDomainDkimRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = VerifyDomainDkimResponseUnmarshaller.Instance.Unmarshall(context)
                as VerifyDomainDkimResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("SimpleEmailService")]
        public void VerifyDomainIdentityMarshallTest()
        {
            var operation = service_model.FindOperation("VerifyDomainIdentity");

            var request = InstantiateClassGenerator.Execute<VerifyDomainIdentityRequest>();
            var marshaller = new VerifyDomainIdentityRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = VerifyDomainIdentityResponseUnmarshaller.Instance.Unmarshall(context)
                as VerifyDomainIdentityResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("SimpleEmailService")]
        public void VerifyEmailAddressMarshallTest()
        {
            var operation = service_model.FindOperation("VerifyEmailAddress");

            var request = InstantiateClassGenerator.Execute<VerifyEmailAddressRequest>();
            var marshaller = new VerifyEmailAddressRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("SimpleEmailService")]
        public void VerifyEmailIdentityMarshallTest()
        {
            var operation = service_model.FindOperation("VerifyEmailIdentity");

            var request = InstantiateClassGenerator.Execute<VerifyEmailIdentityRequest>();
            var marshaller = new VerifyEmailIdentityRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = VerifyEmailIdentityResponseUnmarshaller.Instance.Unmarshall(context)
                as VerifyEmailIdentityResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        
    }
}