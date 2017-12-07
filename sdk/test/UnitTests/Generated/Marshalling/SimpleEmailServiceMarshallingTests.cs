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
        static readonly ServiceModel service_model = Utils.LoadServiceModel("email");
        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("SimpleEmail")]
        public void CloneReceiptRuleSetMarshallTest()
        {
            var operation = service_model.FindOperation("CloneReceiptRuleSet");

            var request = InstantiateClassGenerator.Execute<CloneReceiptRuleSetRequest>();
            var marshaller = new CloneReceiptRuleSetRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = CloneReceiptRuleSetResponseUnmarshaller.Instance.Unmarshall(context)
                as CloneReceiptRuleSetResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("SimpleEmail")]
        public void CreateConfigurationSetMarshallTest()
        {
            var operation = service_model.FindOperation("CreateConfigurationSet");

            var request = InstantiateClassGenerator.Execute<CreateConfigurationSetRequest>();
            var marshaller = new CreateConfigurationSetRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = CreateConfigurationSetResponseUnmarshaller.Instance.Unmarshall(context)
                as CreateConfigurationSetResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("SimpleEmail")]
        public void CreateConfigurationSetEventDestinationMarshallTest()
        {
            var operation = service_model.FindOperation("CreateConfigurationSetEventDestination");

            var request = InstantiateClassGenerator.Execute<CreateConfigurationSetEventDestinationRequest>();
            var marshaller = new CreateConfigurationSetEventDestinationRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = CreateConfigurationSetEventDestinationResponseUnmarshaller.Instance.Unmarshall(context)
                as CreateConfigurationSetEventDestinationResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("SimpleEmail")]
        public void CreateConfigurationSetTrackingOptionsMarshallTest()
        {
            var operation = service_model.FindOperation("CreateConfigurationSetTrackingOptions");

            var request = InstantiateClassGenerator.Execute<CreateConfigurationSetTrackingOptionsRequest>();
            var marshaller = new CreateConfigurationSetTrackingOptionsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = CreateConfigurationSetTrackingOptionsResponseUnmarshaller.Instance.Unmarshall(context)
                as CreateConfigurationSetTrackingOptionsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("SimpleEmail")]
        public void CreateCustomVerificationEmailTemplateMarshallTest()
        {
            var operation = service_model.FindOperation("CreateCustomVerificationEmailTemplate");

            var request = InstantiateClassGenerator.Execute<CreateCustomVerificationEmailTemplateRequest>();
            var marshaller = new CreateCustomVerificationEmailTemplateRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("SimpleEmail")]
        public void CreateReceiptFilterMarshallTest()
        {
            var operation = service_model.FindOperation("CreateReceiptFilter");

            var request = InstantiateClassGenerator.Execute<CreateReceiptFilterRequest>();
            var marshaller = new CreateReceiptFilterRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = CreateReceiptFilterResponseUnmarshaller.Instance.Unmarshall(context)
                as CreateReceiptFilterResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("SimpleEmail")]
        public void CreateReceiptRuleMarshallTest()
        {
            var operation = service_model.FindOperation("CreateReceiptRule");

            var request = InstantiateClassGenerator.Execute<CreateReceiptRuleRequest>();
            var marshaller = new CreateReceiptRuleRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = CreateReceiptRuleResponseUnmarshaller.Instance.Unmarshall(context)
                as CreateReceiptRuleResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("SimpleEmail")]
        public void CreateReceiptRuleSetMarshallTest()
        {
            var operation = service_model.FindOperation("CreateReceiptRuleSet");

            var request = InstantiateClassGenerator.Execute<CreateReceiptRuleSetRequest>();
            var marshaller = new CreateReceiptRuleSetRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = CreateReceiptRuleSetResponseUnmarshaller.Instance.Unmarshall(context)
                as CreateReceiptRuleSetResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("SimpleEmail")]
        public void CreateTemplateMarshallTest()
        {
            var operation = service_model.FindOperation("CreateTemplate");

            var request = InstantiateClassGenerator.Execute<CreateTemplateRequest>();
            var marshaller = new CreateTemplateRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = CreateTemplateResponseUnmarshaller.Instance.Unmarshall(context)
                as CreateTemplateResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("SimpleEmail")]
        public void DeleteConfigurationSetMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteConfigurationSet");

            var request = InstantiateClassGenerator.Execute<DeleteConfigurationSetRequest>();
            var marshaller = new DeleteConfigurationSetRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = DeleteConfigurationSetResponseUnmarshaller.Instance.Unmarshall(context)
                as DeleteConfigurationSetResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("SimpleEmail")]
        public void DeleteConfigurationSetEventDestinationMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteConfigurationSetEventDestination");

            var request = InstantiateClassGenerator.Execute<DeleteConfigurationSetEventDestinationRequest>();
            var marshaller = new DeleteConfigurationSetEventDestinationRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = DeleteConfigurationSetEventDestinationResponseUnmarshaller.Instance.Unmarshall(context)
                as DeleteConfigurationSetEventDestinationResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("SimpleEmail")]
        public void DeleteConfigurationSetTrackingOptionsMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteConfigurationSetTrackingOptions");

            var request = InstantiateClassGenerator.Execute<DeleteConfigurationSetTrackingOptionsRequest>();
            var marshaller = new DeleteConfigurationSetTrackingOptionsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = DeleteConfigurationSetTrackingOptionsResponseUnmarshaller.Instance.Unmarshall(context)
                as DeleteConfigurationSetTrackingOptionsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("SimpleEmail")]
        public void DeleteCustomVerificationEmailTemplateMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteCustomVerificationEmailTemplate");

            var request = InstantiateClassGenerator.Execute<DeleteCustomVerificationEmailTemplateRequest>();
            var marshaller = new DeleteCustomVerificationEmailTemplateRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("SimpleEmail")]
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
        [TestCategory("SimpleEmail")]
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
        [TestCategory("SimpleEmail")]
        public void DeleteReceiptFilterMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteReceiptFilter");

            var request = InstantiateClassGenerator.Execute<DeleteReceiptFilterRequest>();
            var marshaller = new DeleteReceiptFilterRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = DeleteReceiptFilterResponseUnmarshaller.Instance.Unmarshall(context)
                as DeleteReceiptFilterResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("SimpleEmail")]
        public void DeleteReceiptRuleMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteReceiptRule");

            var request = InstantiateClassGenerator.Execute<DeleteReceiptRuleRequest>();
            var marshaller = new DeleteReceiptRuleRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = DeleteReceiptRuleResponseUnmarshaller.Instance.Unmarshall(context)
                as DeleteReceiptRuleResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("SimpleEmail")]
        public void DeleteReceiptRuleSetMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteReceiptRuleSet");

            var request = InstantiateClassGenerator.Execute<DeleteReceiptRuleSetRequest>();
            var marshaller = new DeleteReceiptRuleSetRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = DeleteReceiptRuleSetResponseUnmarshaller.Instance.Unmarshall(context)
                as DeleteReceiptRuleSetResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("SimpleEmail")]
        public void DeleteTemplateMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteTemplate");

            var request = InstantiateClassGenerator.Execute<DeleteTemplateRequest>();
            var marshaller = new DeleteTemplateRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = DeleteTemplateResponseUnmarshaller.Instance.Unmarshall(context)
                as DeleteTemplateResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("SimpleEmail")]
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
        [TestCategory("SimpleEmail")]
        public void DescribeActiveReceiptRuleSetMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeActiveReceiptRuleSet");

            var request = InstantiateClassGenerator.Execute<DescribeActiveReceiptRuleSetRequest>();
            var marshaller = new DescribeActiveReceiptRuleSetRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = DescribeActiveReceiptRuleSetResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeActiveReceiptRuleSetResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("SimpleEmail")]
        public void DescribeConfigurationSetMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeConfigurationSet");

            var request = InstantiateClassGenerator.Execute<DescribeConfigurationSetRequest>();
            var marshaller = new DescribeConfigurationSetRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = DescribeConfigurationSetResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeConfigurationSetResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("SimpleEmail")]
        public void DescribeReceiptRuleMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeReceiptRule");

            var request = InstantiateClassGenerator.Execute<DescribeReceiptRuleRequest>();
            var marshaller = new DescribeReceiptRuleRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = DescribeReceiptRuleResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeReceiptRuleResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("SimpleEmail")]
        public void DescribeReceiptRuleSetMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeReceiptRuleSet");

            var request = InstantiateClassGenerator.Execute<DescribeReceiptRuleSetRequest>();
            var marshaller = new DescribeReceiptRuleSetRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = DescribeReceiptRuleSetResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeReceiptRuleSetResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("SimpleEmail")]
        public void GetAccountSendingEnabledMarshallTest()
        {
            var operation = service_model.FindOperation("GetAccountSendingEnabled");

            var request = InstantiateClassGenerator.Execute<GetAccountSendingEnabledRequest>();
            var marshaller = new GetAccountSendingEnabledRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = GetAccountSendingEnabledResponseUnmarshaller.Instance.Unmarshall(context)
                as GetAccountSendingEnabledResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("SimpleEmail")]
        public void GetCustomVerificationEmailTemplateMarshallTest()
        {
            var operation = service_model.FindOperation("GetCustomVerificationEmailTemplate");

            var request = InstantiateClassGenerator.Execute<GetCustomVerificationEmailTemplateRequest>();
            var marshaller = new GetCustomVerificationEmailTemplateRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = GetCustomVerificationEmailTemplateResponseUnmarshaller.Instance.Unmarshall(context)
                as GetCustomVerificationEmailTemplateResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("SimpleEmail")]
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
        [TestCategory("SimpleEmail")]
        public void GetIdentityMailFromDomainAttributesMarshallTest()
        {
            var operation = service_model.FindOperation("GetIdentityMailFromDomainAttributes");

            var request = InstantiateClassGenerator.Execute<GetIdentityMailFromDomainAttributesRequest>();
            var marshaller = new GetIdentityMailFromDomainAttributesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = GetIdentityMailFromDomainAttributesResponseUnmarshaller.Instance.Unmarshall(context)
                as GetIdentityMailFromDomainAttributesResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("SimpleEmail")]
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
        [TestCategory("SimpleEmail")]
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
        [TestCategory("SimpleEmail")]
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
        [TestCategory("SimpleEmail")]
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
        [TestCategory("SimpleEmail")]
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
        [TestCategory("SimpleEmail")]
        public void GetTemplateMarshallTest()
        {
            var operation = service_model.FindOperation("GetTemplate");

            var request = InstantiateClassGenerator.Execute<GetTemplateRequest>();
            var marshaller = new GetTemplateRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = GetTemplateResponseUnmarshaller.Instance.Unmarshall(context)
                as GetTemplateResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("SimpleEmail")]
        public void ListConfigurationSetsMarshallTest()
        {
            var operation = service_model.FindOperation("ListConfigurationSets");

            var request = InstantiateClassGenerator.Execute<ListConfigurationSetsRequest>();
            var marshaller = new ListConfigurationSetsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = ListConfigurationSetsResponseUnmarshaller.Instance.Unmarshall(context)
                as ListConfigurationSetsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("SimpleEmail")]
        public void ListCustomVerificationEmailTemplatesMarshallTest()
        {
            var operation = service_model.FindOperation("ListCustomVerificationEmailTemplates");

            var request = InstantiateClassGenerator.Execute<ListCustomVerificationEmailTemplatesRequest>();
            var marshaller = new ListCustomVerificationEmailTemplatesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = ListCustomVerificationEmailTemplatesResponseUnmarshaller.Instance.Unmarshall(context)
                as ListCustomVerificationEmailTemplatesResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("SimpleEmail")]
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
        [TestCategory("SimpleEmail")]
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
        [TestCategory("SimpleEmail")]
        public void ListReceiptFiltersMarshallTest()
        {
            var operation = service_model.FindOperation("ListReceiptFilters");

            var request = InstantiateClassGenerator.Execute<ListReceiptFiltersRequest>();
            var marshaller = new ListReceiptFiltersRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = ListReceiptFiltersResponseUnmarshaller.Instance.Unmarshall(context)
                as ListReceiptFiltersResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("SimpleEmail")]
        public void ListReceiptRuleSetsMarshallTest()
        {
            var operation = service_model.FindOperation("ListReceiptRuleSets");

            var request = InstantiateClassGenerator.Execute<ListReceiptRuleSetsRequest>();
            var marshaller = new ListReceiptRuleSetsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = ListReceiptRuleSetsResponseUnmarshaller.Instance.Unmarshall(context)
                as ListReceiptRuleSetsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("SimpleEmail")]
        public void ListTemplatesMarshallTest()
        {
            var operation = service_model.FindOperation("ListTemplates");

            var request = InstantiateClassGenerator.Execute<ListTemplatesRequest>();
            var marshaller = new ListTemplatesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = ListTemplatesResponseUnmarshaller.Instance.Unmarshall(context)
                as ListTemplatesResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("SimpleEmail")]
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
        [TestCategory("SimpleEmail")]
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
        [TestCategory("SimpleEmail")]
        public void ReorderReceiptRuleSetMarshallTest()
        {
            var operation = service_model.FindOperation("ReorderReceiptRuleSet");

            var request = InstantiateClassGenerator.Execute<ReorderReceiptRuleSetRequest>();
            var marshaller = new ReorderReceiptRuleSetRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = ReorderReceiptRuleSetResponseUnmarshaller.Instance.Unmarshall(context)
                as ReorderReceiptRuleSetResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("SimpleEmail")]
        public void SendBounceMarshallTest()
        {
            var operation = service_model.FindOperation("SendBounce");

            var request = InstantiateClassGenerator.Execute<SendBounceRequest>();
            var marshaller = new SendBounceRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = SendBounceResponseUnmarshaller.Instance.Unmarshall(context)
                as SendBounceResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("SimpleEmail")]
        public void SendBulkTemplatedEmailMarshallTest()
        {
            var operation = service_model.FindOperation("SendBulkTemplatedEmail");

            var request = InstantiateClassGenerator.Execute<SendBulkTemplatedEmailRequest>();
            var marshaller = new SendBulkTemplatedEmailRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = SendBulkTemplatedEmailResponseUnmarshaller.Instance.Unmarshall(context)
                as SendBulkTemplatedEmailResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("SimpleEmail")]
        public void SendCustomVerificationEmailMarshallTest()
        {
            var operation = service_model.FindOperation("SendCustomVerificationEmail");

            var request = InstantiateClassGenerator.Execute<SendCustomVerificationEmailRequest>();
            var marshaller = new SendCustomVerificationEmailRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = SendCustomVerificationEmailResponseUnmarshaller.Instance.Unmarshall(context)
                as SendCustomVerificationEmailResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("SimpleEmail")]
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
        [TestCategory("SimpleEmail")]
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
        [TestCategory("SimpleEmail")]
        public void SendTemplatedEmailMarshallTest()
        {
            var operation = service_model.FindOperation("SendTemplatedEmail");

            var request = InstantiateClassGenerator.Execute<SendTemplatedEmailRequest>();
            var marshaller = new SendTemplatedEmailRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = SendTemplatedEmailResponseUnmarshaller.Instance.Unmarshall(context)
                as SendTemplatedEmailResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("SimpleEmail")]
        public void SetActiveReceiptRuleSetMarshallTest()
        {
            var operation = service_model.FindOperation("SetActiveReceiptRuleSet");

            var request = InstantiateClassGenerator.Execute<SetActiveReceiptRuleSetRequest>();
            var marshaller = new SetActiveReceiptRuleSetRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = SetActiveReceiptRuleSetResponseUnmarshaller.Instance.Unmarshall(context)
                as SetActiveReceiptRuleSetResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("SimpleEmail")]
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
        [TestCategory("SimpleEmail")]
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
        [TestCategory("SimpleEmail")]
        public void SetIdentityHeadersInNotificationsEnabledMarshallTest()
        {
            var operation = service_model.FindOperation("SetIdentityHeadersInNotificationsEnabled");

            var request = InstantiateClassGenerator.Execute<SetIdentityHeadersInNotificationsEnabledRequest>();
            var marshaller = new SetIdentityHeadersInNotificationsEnabledRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = SetIdentityHeadersInNotificationsEnabledResponseUnmarshaller.Instance.Unmarshall(context)
                as SetIdentityHeadersInNotificationsEnabledResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("SimpleEmail")]
        public void SetIdentityMailFromDomainMarshallTest()
        {
            var operation = service_model.FindOperation("SetIdentityMailFromDomain");

            var request = InstantiateClassGenerator.Execute<SetIdentityMailFromDomainRequest>();
            var marshaller = new SetIdentityMailFromDomainRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = SetIdentityMailFromDomainResponseUnmarshaller.Instance.Unmarshall(context)
                as SetIdentityMailFromDomainResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("SimpleEmail")]
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
        [TestCategory("SimpleEmail")]
        public void SetReceiptRulePositionMarshallTest()
        {
            var operation = service_model.FindOperation("SetReceiptRulePosition");

            var request = InstantiateClassGenerator.Execute<SetReceiptRulePositionRequest>();
            var marshaller = new SetReceiptRulePositionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = SetReceiptRulePositionResponseUnmarshaller.Instance.Unmarshall(context)
                as SetReceiptRulePositionResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("SimpleEmail")]
        public void TestRenderTemplateMarshallTest()
        {
            var operation = service_model.FindOperation("TestRenderTemplate");

            var request = InstantiateClassGenerator.Execute<TestRenderTemplateRequest>();
            var marshaller = new TestRenderTemplateRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = TestRenderTemplateResponseUnmarshaller.Instance.Unmarshall(context)
                as TestRenderTemplateResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("SimpleEmail")]
        public void UpdateAccountSendingEnabledMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateAccountSendingEnabled");

            var request = InstantiateClassGenerator.Execute<UpdateAccountSendingEnabledRequest>();
            var marshaller = new UpdateAccountSendingEnabledRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("SimpleEmail")]
        public void UpdateConfigurationSetEventDestinationMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateConfigurationSetEventDestination");

            var request = InstantiateClassGenerator.Execute<UpdateConfigurationSetEventDestinationRequest>();
            var marshaller = new UpdateConfigurationSetEventDestinationRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = UpdateConfigurationSetEventDestinationResponseUnmarshaller.Instance.Unmarshall(context)
                as UpdateConfigurationSetEventDestinationResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("SimpleEmail")]
        public void UpdateConfigurationSetReputationMetricsEnabledMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateConfigurationSetReputationMetricsEnabled");

            var request = InstantiateClassGenerator.Execute<UpdateConfigurationSetReputationMetricsEnabledRequest>();
            var marshaller = new UpdateConfigurationSetReputationMetricsEnabledRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("SimpleEmail")]
        public void UpdateConfigurationSetSendingEnabledMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateConfigurationSetSendingEnabled");

            var request = InstantiateClassGenerator.Execute<UpdateConfigurationSetSendingEnabledRequest>();
            var marshaller = new UpdateConfigurationSetSendingEnabledRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("SimpleEmail")]
        public void UpdateConfigurationSetTrackingOptionsMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateConfigurationSetTrackingOptions");

            var request = InstantiateClassGenerator.Execute<UpdateConfigurationSetTrackingOptionsRequest>();
            var marshaller = new UpdateConfigurationSetTrackingOptionsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = UpdateConfigurationSetTrackingOptionsResponseUnmarshaller.Instance.Unmarshall(context)
                as UpdateConfigurationSetTrackingOptionsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("SimpleEmail")]
        public void UpdateCustomVerificationEmailTemplateMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateCustomVerificationEmailTemplate");

            var request = InstantiateClassGenerator.Execute<UpdateCustomVerificationEmailTemplateRequest>();
            var marshaller = new UpdateCustomVerificationEmailTemplateRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("SimpleEmail")]
        public void UpdateReceiptRuleMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateReceiptRule");

            var request = InstantiateClassGenerator.Execute<UpdateReceiptRuleRequest>();
            var marshaller = new UpdateReceiptRuleRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = UpdateReceiptRuleResponseUnmarshaller.Instance.Unmarshall(context)
                as UpdateReceiptRuleResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("SimpleEmail")]
        public void UpdateTemplateMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateTemplate");

            var request = InstantiateClassGenerator.Execute<UpdateTemplateRequest>();
            var marshaller = new UpdateTemplateRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = UpdateTemplateResponseUnmarshaller.Instance.Unmarshall(context)
                as UpdateTemplateResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("SimpleEmail")]
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
        [TestCategory("SimpleEmail")]
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
        [TestCategory("SimpleEmail")]
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
        [TestCategory("SimpleEmail")]
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