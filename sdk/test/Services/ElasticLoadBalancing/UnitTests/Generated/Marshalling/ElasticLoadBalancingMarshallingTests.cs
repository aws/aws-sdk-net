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
 * Do not modify this file. This file is generated from the elasticloadbalancing-2012-06-01.normal.json service model.
 */


using System;
using System.IO;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Amazon.ElasticLoadBalancing;
using Amazon.ElasticLoadBalancing.Model;
using Amazon.ElasticLoadBalancing.Model.Internal.MarshallTransformations;
using Amazon.Runtime.Internal.Transform;

using ServiceClientGenerator;

using AWSSDK_DotNet35.UnitTests.TestTools;

namespace AWSSDK_DotNet35.UnitTests.Marshalling
{
    [TestClass]
    public class ElasticLoadBalancingMarshallingTests
    {
        static readonly ServiceModel service_model = Utils.LoadServiceModel("elasticloadbalancing");
        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("ElasticLoadBalancing")]
        public void AddTagsMarshallTest()
        {
            var operation = service_model.FindOperation("AddTags");

            var request = InstantiateClassGenerator.Execute<AddTagsRequest>();
            var marshaller = new AddTagsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = AddTagsResponseUnmarshaller.Instance.Unmarshall(context)
                as AddTagsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("ElasticLoadBalancing")]
        public void AddTags_AccessPointNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("AddTags");

            var request = InstantiateClassGenerator.Execute<AddTagsRequest>();
            var marshaller = new AddTagsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("AccessPointNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = AddTagsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("ElasticLoadBalancing")]
        public void AddTags_DuplicateTagKeysExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("AddTags");

            var request = InstantiateClassGenerator.Execute<AddTagsRequest>();
            var marshaller = new AddTagsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("DuplicateTagKeysException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = AddTagsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("ElasticLoadBalancing")]
        public void AddTags_TooManyTagsExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("AddTags");

            var request = InstantiateClassGenerator.Execute<AddTagsRequest>();
            var marshaller = new AddTagsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("TooManyTagsException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = AddTagsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("ElasticLoadBalancing")]
        public void ApplySecurityGroupsToLoadBalancerMarshallTest()
        {
            var operation = service_model.FindOperation("ApplySecurityGroupsToLoadBalancer");

            var request = InstantiateClassGenerator.Execute<ApplySecurityGroupsToLoadBalancerRequest>();
            var marshaller = new ApplySecurityGroupsToLoadBalancerRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = ApplySecurityGroupsToLoadBalancerResponseUnmarshaller.Instance.Unmarshall(context)
                as ApplySecurityGroupsToLoadBalancerResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("ElasticLoadBalancing")]
        public void ApplySecurityGroupsToLoadBalancer_AccessPointNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ApplySecurityGroupsToLoadBalancer");

            var request = InstantiateClassGenerator.Execute<ApplySecurityGroupsToLoadBalancerRequest>();
            var marshaller = new ApplySecurityGroupsToLoadBalancerRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("AccessPointNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = ApplySecurityGroupsToLoadBalancerResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("ElasticLoadBalancing")]
        public void ApplySecurityGroupsToLoadBalancer_InvalidConfigurationRequestExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ApplySecurityGroupsToLoadBalancer");

            var request = InstantiateClassGenerator.Execute<ApplySecurityGroupsToLoadBalancerRequest>();
            var marshaller = new ApplySecurityGroupsToLoadBalancerRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidConfigurationRequestException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = ApplySecurityGroupsToLoadBalancerResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("ElasticLoadBalancing")]
        public void ApplySecurityGroupsToLoadBalancer_InvalidSecurityGroupExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ApplySecurityGroupsToLoadBalancer");

            var request = InstantiateClassGenerator.Execute<ApplySecurityGroupsToLoadBalancerRequest>();
            var marshaller = new ApplySecurityGroupsToLoadBalancerRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidSecurityGroupException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = ApplySecurityGroupsToLoadBalancerResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("ElasticLoadBalancing")]
        public void AttachLoadBalancerToSubnetsMarshallTest()
        {
            var operation = service_model.FindOperation("AttachLoadBalancerToSubnets");

            var request = InstantiateClassGenerator.Execute<AttachLoadBalancerToSubnetsRequest>();
            var marshaller = new AttachLoadBalancerToSubnetsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = AttachLoadBalancerToSubnetsResponseUnmarshaller.Instance.Unmarshall(context)
                as AttachLoadBalancerToSubnetsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("ElasticLoadBalancing")]
        public void AttachLoadBalancerToSubnets_AccessPointNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("AttachLoadBalancerToSubnets");

            var request = InstantiateClassGenerator.Execute<AttachLoadBalancerToSubnetsRequest>();
            var marshaller = new AttachLoadBalancerToSubnetsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("AccessPointNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = AttachLoadBalancerToSubnetsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("ElasticLoadBalancing")]
        public void AttachLoadBalancerToSubnets_InvalidConfigurationRequestExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("AttachLoadBalancerToSubnets");

            var request = InstantiateClassGenerator.Execute<AttachLoadBalancerToSubnetsRequest>();
            var marshaller = new AttachLoadBalancerToSubnetsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidConfigurationRequestException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = AttachLoadBalancerToSubnetsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("ElasticLoadBalancing")]
        public void AttachLoadBalancerToSubnets_InvalidSubnetExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("AttachLoadBalancerToSubnets");

            var request = InstantiateClassGenerator.Execute<AttachLoadBalancerToSubnetsRequest>();
            var marshaller = new AttachLoadBalancerToSubnetsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidSubnetException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = AttachLoadBalancerToSubnetsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("ElasticLoadBalancing")]
        public void AttachLoadBalancerToSubnets_SubnetNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("AttachLoadBalancerToSubnets");

            var request = InstantiateClassGenerator.Execute<AttachLoadBalancerToSubnetsRequest>();
            var marshaller = new AttachLoadBalancerToSubnetsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("SubnetNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = AttachLoadBalancerToSubnetsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("ElasticLoadBalancing")]
        public void ConfigureHealthCheckMarshallTest()
        {
            var operation = service_model.FindOperation("ConfigureHealthCheck");

            var request = InstantiateClassGenerator.Execute<ConfigureHealthCheckRequest>();
            var marshaller = new ConfigureHealthCheckRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = ConfigureHealthCheckResponseUnmarshaller.Instance.Unmarshall(context)
                as ConfigureHealthCheckResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("ElasticLoadBalancing")]
        public void ConfigureHealthCheck_AccessPointNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ConfigureHealthCheck");

            var request = InstantiateClassGenerator.Execute<ConfigureHealthCheckRequest>();
            var marshaller = new ConfigureHealthCheckRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("AccessPointNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = ConfigureHealthCheckResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("ElasticLoadBalancing")]
        public void CreateAppCookieStickinessPolicyMarshallTest()
        {
            var operation = service_model.FindOperation("CreateAppCookieStickinessPolicy");

            var request = InstantiateClassGenerator.Execute<CreateAppCookieStickinessPolicyRequest>();
            var marshaller = new CreateAppCookieStickinessPolicyRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = CreateAppCookieStickinessPolicyResponseUnmarshaller.Instance.Unmarshall(context)
                as CreateAppCookieStickinessPolicyResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("ElasticLoadBalancing")]
        public void CreateAppCookieStickinessPolicy_AccessPointNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateAppCookieStickinessPolicy");

            var request = InstantiateClassGenerator.Execute<CreateAppCookieStickinessPolicyRequest>();
            var marshaller = new CreateAppCookieStickinessPolicyRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("AccessPointNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateAppCookieStickinessPolicyResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("ElasticLoadBalancing")]
        public void CreateAppCookieStickinessPolicy_DuplicatePolicyNameExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateAppCookieStickinessPolicy");

            var request = InstantiateClassGenerator.Execute<CreateAppCookieStickinessPolicyRequest>();
            var marshaller = new CreateAppCookieStickinessPolicyRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("DuplicatePolicyNameException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateAppCookieStickinessPolicyResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("ElasticLoadBalancing")]
        public void CreateAppCookieStickinessPolicy_InvalidConfigurationRequestExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateAppCookieStickinessPolicy");

            var request = InstantiateClassGenerator.Execute<CreateAppCookieStickinessPolicyRequest>();
            var marshaller = new CreateAppCookieStickinessPolicyRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidConfigurationRequestException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateAppCookieStickinessPolicyResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("ElasticLoadBalancing")]
        public void CreateAppCookieStickinessPolicy_TooManyPoliciesExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateAppCookieStickinessPolicy");

            var request = InstantiateClassGenerator.Execute<CreateAppCookieStickinessPolicyRequest>();
            var marshaller = new CreateAppCookieStickinessPolicyRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("TooManyPoliciesException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateAppCookieStickinessPolicyResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("ElasticLoadBalancing")]
        public void CreateLBCookieStickinessPolicyMarshallTest()
        {
            var operation = service_model.FindOperation("CreateLBCookieStickinessPolicy");

            var request = InstantiateClassGenerator.Execute<CreateLBCookieStickinessPolicyRequest>();
            var marshaller = new CreateLBCookieStickinessPolicyRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = CreateLBCookieStickinessPolicyResponseUnmarshaller.Instance.Unmarshall(context)
                as CreateLBCookieStickinessPolicyResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("ElasticLoadBalancing")]
        public void CreateLBCookieStickinessPolicy_AccessPointNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateLBCookieStickinessPolicy");

            var request = InstantiateClassGenerator.Execute<CreateLBCookieStickinessPolicyRequest>();
            var marshaller = new CreateLBCookieStickinessPolicyRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("AccessPointNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateLBCookieStickinessPolicyResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("ElasticLoadBalancing")]
        public void CreateLBCookieStickinessPolicy_DuplicatePolicyNameExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateLBCookieStickinessPolicy");

            var request = InstantiateClassGenerator.Execute<CreateLBCookieStickinessPolicyRequest>();
            var marshaller = new CreateLBCookieStickinessPolicyRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("DuplicatePolicyNameException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateLBCookieStickinessPolicyResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("ElasticLoadBalancing")]
        public void CreateLBCookieStickinessPolicy_InvalidConfigurationRequestExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateLBCookieStickinessPolicy");

            var request = InstantiateClassGenerator.Execute<CreateLBCookieStickinessPolicyRequest>();
            var marshaller = new CreateLBCookieStickinessPolicyRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidConfigurationRequestException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateLBCookieStickinessPolicyResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("ElasticLoadBalancing")]
        public void CreateLBCookieStickinessPolicy_TooManyPoliciesExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateLBCookieStickinessPolicy");

            var request = InstantiateClassGenerator.Execute<CreateLBCookieStickinessPolicyRequest>();
            var marshaller = new CreateLBCookieStickinessPolicyRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("TooManyPoliciesException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateLBCookieStickinessPolicyResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("ElasticLoadBalancing")]
        public void CreateLoadBalancerMarshallTest()
        {
            var operation = service_model.FindOperation("CreateLoadBalancer");

            var request = InstantiateClassGenerator.Execute<CreateLoadBalancerRequest>();
            var marshaller = new CreateLoadBalancerRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = CreateLoadBalancerResponseUnmarshaller.Instance.Unmarshall(context)
                as CreateLoadBalancerResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("ElasticLoadBalancing")]
        public void CreateLoadBalancer_CertificateNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateLoadBalancer");

            var request = InstantiateClassGenerator.Execute<CreateLoadBalancerRequest>();
            var marshaller = new CreateLoadBalancerRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("CertificateNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateLoadBalancerResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("ElasticLoadBalancing")]
        public void CreateLoadBalancer_DuplicateAccessPointNameExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateLoadBalancer");

            var request = InstantiateClassGenerator.Execute<CreateLoadBalancerRequest>();
            var marshaller = new CreateLoadBalancerRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("DuplicateAccessPointNameException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateLoadBalancerResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("ElasticLoadBalancing")]
        public void CreateLoadBalancer_DuplicateTagKeysExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateLoadBalancer");

            var request = InstantiateClassGenerator.Execute<CreateLoadBalancerRequest>();
            var marshaller = new CreateLoadBalancerRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("DuplicateTagKeysException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateLoadBalancerResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("ElasticLoadBalancing")]
        public void CreateLoadBalancer_InvalidConfigurationRequestExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateLoadBalancer");

            var request = InstantiateClassGenerator.Execute<CreateLoadBalancerRequest>();
            var marshaller = new CreateLoadBalancerRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidConfigurationRequestException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateLoadBalancerResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("ElasticLoadBalancing")]
        public void CreateLoadBalancer_InvalidSchemeExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateLoadBalancer");

            var request = InstantiateClassGenerator.Execute<CreateLoadBalancerRequest>();
            var marshaller = new CreateLoadBalancerRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidSchemeException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateLoadBalancerResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("ElasticLoadBalancing")]
        public void CreateLoadBalancer_InvalidSecurityGroupExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateLoadBalancer");

            var request = InstantiateClassGenerator.Execute<CreateLoadBalancerRequest>();
            var marshaller = new CreateLoadBalancerRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidSecurityGroupException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateLoadBalancerResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("ElasticLoadBalancing")]
        public void CreateLoadBalancer_InvalidSubnetExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateLoadBalancer");

            var request = InstantiateClassGenerator.Execute<CreateLoadBalancerRequest>();
            var marshaller = new CreateLoadBalancerRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidSubnetException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateLoadBalancerResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("ElasticLoadBalancing")]
        public void CreateLoadBalancer_OperationNotPermittedExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateLoadBalancer");

            var request = InstantiateClassGenerator.Execute<CreateLoadBalancerRequest>();
            var marshaller = new CreateLoadBalancerRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("OperationNotPermittedException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateLoadBalancerResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("ElasticLoadBalancing")]
        public void CreateLoadBalancer_SubnetNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateLoadBalancer");

            var request = InstantiateClassGenerator.Execute<CreateLoadBalancerRequest>();
            var marshaller = new CreateLoadBalancerRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("SubnetNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateLoadBalancerResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("ElasticLoadBalancing")]
        public void CreateLoadBalancer_TooManyAccessPointsExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateLoadBalancer");

            var request = InstantiateClassGenerator.Execute<CreateLoadBalancerRequest>();
            var marshaller = new CreateLoadBalancerRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("TooManyAccessPointsException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateLoadBalancerResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("ElasticLoadBalancing")]
        public void CreateLoadBalancer_TooManyTagsExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateLoadBalancer");

            var request = InstantiateClassGenerator.Execute<CreateLoadBalancerRequest>();
            var marshaller = new CreateLoadBalancerRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("TooManyTagsException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateLoadBalancerResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("ElasticLoadBalancing")]
        public void CreateLoadBalancer_UnsupportedProtocolExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateLoadBalancer");

            var request = InstantiateClassGenerator.Execute<CreateLoadBalancerRequest>();
            var marshaller = new CreateLoadBalancerRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("UnsupportedProtocolException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateLoadBalancerResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("ElasticLoadBalancing")]
        public void CreateLoadBalancerListenersMarshallTest()
        {
            var operation = service_model.FindOperation("CreateLoadBalancerListeners");

            var request = InstantiateClassGenerator.Execute<CreateLoadBalancerListenersRequest>();
            var marshaller = new CreateLoadBalancerListenersRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = CreateLoadBalancerListenersResponseUnmarshaller.Instance.Unmarshall(context)
                as CreateLoadBalancerListenersResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("ElasticLoadBalancing")]
        public void CreateLoadBalancerListeners_AccessPointNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateLoadBalancerListeners");

            var request = InstantiateClassGenerator.Execute<CreateLoadBalancerListenersRequest>();
            var marshaller = new CreateLoadBalancerListenersRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("AccessPointNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateLoadBalancerListenersResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("ElasticLoadBalancing")]
        public void CreateLoadBalancerListeners_CertificateNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateLoadBalancerListeners");

            var request = InstantiateClassGenerator.Execute<CreateLoadBalancerListenersRequest>();
            var marshaller = new CreateLoadBalancerListenersRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("CertificateNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateLoadBalancerListenersResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("ElasticLoadBalancing")]
        public void CreateLoadBalancerListeners_DuplicateListenerExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateLoadBalancerListeners");

            var request = InstantiateClassGenerator.Execute<CreateLoadBalancerListenersRequest>();
            var marshaller = new CreateLoadBalancerListenersRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("DuplicateListenerException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateLoadBalancerListenersResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("ElasticLoadBalancing")]
        public void CreateLoadBalancerListeners_InvalidConfigurationRequestExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateLoadBalancerListeners");

            var request = InstantiateClassGenerator.Execute<CreateLoadBalancerListenersRequest>();
            var marshaller = new CreateLoadBalancerListenersRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidConfigurationRequestException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateLoadBalancerListenersResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("ElasticLoadBalancing")]
        public void CreateLoadBalancerListeners_UnsupportedProtocolExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateLoadBalancerListeners");

            var request = InstantiateClassGenerator.Execute<CreateLoadBalancerListenersRequest>();
            var marshaller = new CreateLoadBalancerListenersRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("UnsupportedProtocolException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateLoadBalancerListenersResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("ElasticLoadBalancing")]
        public void CreateLoadBalancerPolicyMarshallTest()
        {
            var operation = service_model.FindOperation("CreateLoadBalancerPolicy");

            var request = InstantiateClassGenerator.Execute<CreateLoadBalancerPolicyRequest>();
            var marshaller = new CreateLoadBalancerPolicyRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = CreateLoadBalancerPolicyResponseUnmarshaller.Instance.Unmarshall(context)
                as CreateLoadBalancerPolicyResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("ElasticLoadBalancing")]
        public void CreateLoadBalancerPolicy_AccessPointNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateLoadBalancerPolicy");

            var request = InstantiateClassGenerator.Execute<CreateLoadBalancerPolicyRequest>();
            var marshaller = new CreateLoadBalancerPolicyRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("AccessPointNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateLoadBalancerPolicyResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("ElasticLoadBalancing")]
        public void CreateLoadBalancerPolicy_DuplicatePolicyNameExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateLoadBalancerPolicy");

            var request = InstantiateClassGenerator.Execute<CreateLoadBalancerPolicyRequest>();
            var marshaller = new CreateLoadBalancerPolicyRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("DuplicatePolicyNameException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateLoadBalancerPolicyResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("ElasticLoadBalancing")]
        public void CreateLoadBalancerPolicy_InvalidConfigurationRequestExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateLoadBalancerPolicy");

            var request = InstantiateClassGenerator.Execute<CreateLoadBalancerPolicyRequest>();
            var marshaller = new CreateLoadBalancerPolicyRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidConfigurationRequestException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateLoadBalancerPolicyResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("ElasticLoadBalancing")]
        public void CreateLoadBalancerPolicy_PolicyTypeNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateLoadBalancerPolicy");

            var request = InstantiateClassGenerator.Execute<CreateLoadBalancerPolicyRequest>();
            var marshaller = new CreateLoadBalancerPolicyRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("PolicyTypeNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateLoadBalancerPolicyResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("ElasticLoadBalancing")]
        public void CreateLoadBalancerPolicy_TooManyPoliciesExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("CreateLoadBalancerPolicy");

            var request = InstantiateClassGenerator.Execute<CreateLoadBalancerPolicyRequest>();
            var marshaller = new CreateLoadBalancerPolicyRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("TooManyPoliciesException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = CreateLoadBalancerPolicyResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("ElasticLoadBalancing")]
        public void DeleteLoadBalancerMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteLoadBalancer");

            var request = InstantiateClassGenerator.Execute<DeleteLoadBalancerRequest>();
            var marshaller = new DeleteLoadBalancerRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = DeleteLoadBalancerResponseUnmarshaller.Instance.Unmarshall(context)
                as DeleteLoadBalancerResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("ElasticLoadBalancing")]
        public void DeleteLoadBalancerListenersMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteLoadBalancerListeners");

            var request = InstantiateClassGenerator.Execute<DeleteLoadBalancerListenersRequest>();
            var marshaller = new DeleteLoadBalancerListenersRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = DeleteLoadBalancerListenersResponseUnmarshaller.Instance.Unmarshall(context)
                as DeleteLoadBalancerListenersResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("ElasticLoadBalancing")]
        public void DeleteLoadBalancerListeners_AccessPointNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteLoadBalancerListeners");

            var request = InstantiateClassGenerator.Execute<DeleteLoadBalancerListenersRequest>();
            var marshaller = new DeleteLoadBalancerListenersRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("AccessPointNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DeleteLoadBalancerListenersResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("ElasticLoadBalancing")]
        public void DeleteLoadBalancerPolicyMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteLoadBalancerPolicy");

            var request = InstantiateClassGenerator.Execute<DeleteLoadBalancerPolicyRequest>();
            var marshaller = new DeleteLoadBalancerPolicyRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = DeleteLoadBalancerPolicyResponseUnmarshaller.Instance.Unmarshall(context)
                as DeleteLoadBalancerPolicyResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("ElasticLoadBalancing")]
        public void DeleteLoadBalancerPolicy_AccessPointNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteLoadBalancerPolicy");

            var request = InstantiateClassGenerator.Execute<DeleteLoadBalancerPolicyRequest>();
            var marshaller = new DeleteLoadBalancerPolicyRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("AccessPointNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DeleteLoadBalancerPolicyResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("ElasticLoadBalancing")]
        public void DeleteLoadBalancerPolicy_InvalidConfigurationRequestExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteLoadBalancerPolicy");

            var request = InstantiateClassGenerator.Execute<DeleteLoadBalancerPolicyRequest>();
            var marshaller = new DeleteLoadBalancerPolicyRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidConfigurationRequestException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DeleteLoadBalancerPolicyResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("ElasticLoadBalancing")]
        public void DeregisterInstancesFromLoadBalancerMarshallTest()
        {
            var operation = service_model.FindOperation("DeregisterInstancesFromLoadBalancer");

            var request = InstantiateClassGenerator.Execute<DeregisterInstancesFromLoadBalancerRequest>();
            var marshaller = new DeregisterInstancesFromLoadBalancerRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = DeregisterInstancesFromLoadBalancerResponseUnmarshaller.Instance.Unmarshall(context)
                as DeregisterInstancesFromLoadBalancerResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("ElasticLoadBalancing")]
        public void DeregisterInstancesFromLoadBalancer_AccessPointNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DeregisterInstancesFromLoadBalancer");

            var request = InstantiateClassGenerator.Execute<DeregisterInstancesFromLoadBalancerRequest>();
            var marshaller = new DeregisterInstancesFromLoadBalancerRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("AccessPointNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DeregisterInstancesFromLoadBalancerResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("ElasticLoadBalancing")]
        public void DeregisterInstancesFromLoadBalancer_InvalidEndPointExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DeregisterInstancesFromLoadBalancer");

            var request = InstantiateClassGenerator.Execute<DeregisterInstancesFromLoadBalancerRequest>();
            var marshaller = new DeregisterInstancesFromLoadBalancerRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidEndPointException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DeregisterInstancesFromLoadBalancerResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("ElasticLoadBalancing")]
        public void DescribeAccountLimitsMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeAccountLimits");

            var request = InstantiateClassGenerator.Execute<DescribeAccountLimitsRequest>();
            var marshaller = new DescribeAccountLimitsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = DescribeAccountLimitsResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeAccountLimitsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("ElasticLoadBalancing")]
        public void DescribeInstanceHealthMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeInstanceHealth");

            var request = InstantiateClassGenerator.Execute<DescribeInstanceHealthRequest>();
            var marshaller = new DescribeInstanceHealthRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = DescribeInstanceHealthResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeInstanceHealthResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("ElasticLoadBalancing")]
        public void DescribeInstanceHealth_AccessPointNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeInstanceHealth");

            var request = InstantiateClassGenerator.Execute<DescribeInstanceHealthRequest>();
            var marshaller = new DescribeInstanceHealthRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("AccessPointNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DescribeInstanceHealthResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("ElasticLoadBalancing")]
        public void DescribeInstanceHealth_InvalidEndPointExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeInstanceHealth");

            var request = InstantiateClassGenerator.Execute<DescribeInstanceHealthRequest>();
            var marshaller = new DescribeInstanceHealthRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidEndPointException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DescribeInstanceHealthResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("ElasticLoadBalancing")]
        public void DescribeLoadBalancerAttributesMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeLoadBalancerAttributes");

            var request = InstantiateClassGenerator.Execute<DescribeLoadBalancerAttributesRequest>();
            var marshaller = new DescribeLoadBalancerAttributesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = DescribeLoadBalancerAttributesResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeLoadBalancerAttributesResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("ElasticLoadBalancing")]
        public void DescribeLoadBalancerAttributes_AccessPointNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeLoadBalancerAttributes");

            var request = InstantiateClassGenerator.Execute<DescribeLoadBalancerAttributesRequest>();
            var marshaller = new DescribeLoadBalancerAttributesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("AccessPointNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DescribeLoadBalancerAttributesResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("ElasticLoadBalancing")]
        public void DescribeLoadBalancerAttributes_LoadBalancerAttributeNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeLoadBalancerAttributes");

            var request = InstantiateClassGenerator.Execute<DescribeLoadBalancerAttributesRequest>();
            var marshaller = new DescribeLoadBalancerAttributesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("LoadBalancerAttributeNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DescribeLoadBalancerAttributesResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("ElasticLoadBalancing")]
        public void DescribeLoadBalancerPoliciesMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeLoadBalancerPolicies");

            var request = InstantiateClassGenerator.Execute<DescribeLoadBalancerPoliciesRequest>();
            var marshaller = new DescribeLoadBalancerPoliciesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = DescribeLoadBalancerPoliciesResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeLoadBalancerPoliciesResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("ElasticLoadBalancing")]
        public void DescribeLoadBalancerPolicies_AccessPointNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeLoadBalancerPolicies");

            var request = InstantiateClassGenerator.Execute<DescribeLoadBalancerPoliciesRequest>();
            var marshaller = new DescribeLoadBalancerPoliciesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("AccessPointNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DescribeLoadBalancerPoliciesResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("ElasticLoadBalancing")]
        public void DescribeLoadBalancerPolicies_PolicyNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeLoadBalancerPolicies");

            var request = InstantiateClassGenerator.Execute<DescribeLoadBalancerPoliciesRequest>();
            var marshaller = new DescribeLoadBalancerPoliciesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("PolicyNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DescribeLoadBalancerPoliciesResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("ElasticLoadBalancing")]
        public void DescribeLoadBalancerPolicyTypesMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeLoadBalancerPolicyTypes");

            var request = InstantiateClassGenerator.Execute<DescribeLoadBalancerPolicyTypesRequest>();
            var marshaller = new DescribeLoadBalancerPolicyTypesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = DescribeLoadBalancerPolicyTypesResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeLoadBalancerPolicyTypesResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("ElasticLoadBalancing")]
        public void DescribeLoadBalancerPolicyTypes_PolicyTypeNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeLoadBalancerPolicyTypes");

            var request = InstantiateClassGenerator.Execute<DescribeLoadBalancerPolicyTypesRequest>();
            var marshaller = new DescribeLoadBalancerPolicyTypesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("PolicyTypeNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DescribeLoadBalancerPolicyTypesResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("ElasticLoadBalancing")]
        public void DescribeLoadBalancersMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeLoadBalancers");

            var request = InstantiateClassGenerator.Execute<DescribeLoadBalancersRequest>();
            var marshaller = new DescribeLoadBalancersRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = DescribeLoadBalancersResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeLoadBalancersResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("ElasticLoadBalancing")]
        public void DescribeLoadBalancers_AccessPointNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeLoadBalancers");

            var request = InstantiateClassGenerator.Execute<DescribeLoadBalancersRequest>();
            var marshaller = new DescribeLoadBalancersRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("AccessPointNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DescribeLoadBalancersResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("ElasticLoadBalancing")]
        public void DescribeLoadBalancers_DependencyThrottleExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeLoadBalancers");

            var request = InstantiateClassGenerator.Execute<DescribeLoadBalancersRequest>();
            var marshaller = new DescribeLoadBalancersRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("DependencyThrottleException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DescribeLoadBalancersResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("ElasticLoadBalancing")]
        public void DescribeTagsMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeTags");

            var request = InstantiateClassGenerator.Execute<DescribeTagsRequest>();
            var marshaller = new DescribeTagsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = DescribeTagsResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeTagsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("ElasticLoadBalancing")]
        public void DescribeTags_AccessPointNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeTags");

            var request = InstantiateClassGenerator.Execute<DescribeTagsRequest>();
            var marshaller = new DescribeTagsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("AccessPointNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DescribeTagsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("ElasticLoadBalancing")]
        public void DetachLoadBalancerFromSubnetsMarshallTest()
        {
            var operation = service_model.FindOperation("DetachLoadBalancerFromSubnets");

            var request = InstantiateClassGenerator.Execute<DetachLoadBalancerFromSubnetsRequest>();
            var marshaller = new DetachLoadBalancerFromSubnetsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = DetachLoadBalancerFromSubnetsResponseUnmarshaller.Instance.Unmarshall(context)
                as DetachLoadBalancerFromSubnetsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("ElasticLoadBalancing")]
        public void DetachLoadBalancerFromSubnets_AccessPointNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DetachLoadBalancerFromSubnets");

            var request = InstantiateClassGenerator.Execute<DetachLoadBalancerFromSubnetsRequest>();
            var marshaller = new DetachLoadBalancerFromSubnetsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("AccessPointNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DetachLoadBalancerFromSubnetsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("ElasticLoadBalancing")]
        public void DetachLoadBalancerFromSubnets_InvalidConfigurationRequestExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DetachLoadBalancerFromSubnets");

            var request = InstantiateClassGenerator.Execute<DetachLoadBalancerFromSubnetsRequest>();
            var marshaller = new DetachLoadBalancerFromSubnetsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidConfigurationRequestException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DetachLoadBalancerFromSubnetsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("ElasticLoadBalancing")]
        public void DisableAvailabilityZonesForLoadBalancerMarshallTest()
        {
            var operation = service_model.FindOperation("DisableAvailabilityZonesForLoadBalancer");

            var request = InstantiateClassGenerator.Execute<DisableAvailabilityZonesForLoadBalancerRequest>();
            var marshaller = new DisableAvailabilityZonesForLoadBalancerRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = DisableAvailabilityZonesForLoadBalancerResponseUnmarshaller.Instance.Unmarshall(context)
                as DisableAvailabilityZonesForLoadBalancerResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("ElasticLoadBalancing")]
        public void DisableAvailabilityZonesForLoadBalancer_AccessPointNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DisableAvailabilityZonesForLoadBalancer");

            var request = InstantiateClassGenerator.Execute<DisableAvailabilityZonesForLoadBalancerRequest>();
            var marshaller = new DisableAvailabilityZonesForLoadBalancerRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("AccessPointNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DisableAvailabilityZonesForLoadBalancerResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("ElasticLoadBalancing")]
        public void DisableAvailabilityZonesForLoadBalancer_InvalidConfigurationRequestExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("DisableAvailabilityZonesForLoadBalancer");

            var request = InstantiateClassGenerator.Execute<DisableAvailabilityZonesForLoadBalancerRequest>();
            var marshaller = new DisableAvailabilityZonesForLoadBalancerRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidConfigurationRequestException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = DisableAvailabilityZonesForLoadBalancerResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("ElasticLoadBalancing")]
        public void EnableAvailabilityZonesForLoadBalancerMarshallTest()
        {
            var operation = service_model.FindOperation("EnableAvailabilityZonesForLoadBalancer");

            var request = InstantiateClassGenerator.Execute<EnableAvailabilityZonesForLoadBalancerRequest>();
            var marshaller = new EnableAvailabilityZonesForLoadBalancerRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = EnableAvailabilityZonesForLoadBalancerResponseUnmarshaller.Instance.Unmarshall(context)
                as EnableAvailabilityZonesForLoadBalancerResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("ElasticLoadBalancing")]
        public void EnableAvailabilityZonesForLoadBalancer_AccessPointNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("EnableAvailabilityZonesForLoadBalancer");

            var request = InstantiateClassGenerator.Execute<EnableAvailabilityZonesForLoadBalancerRequest>();
            var marshaller = new EnableAvailabilityZonesForLoadBalancerRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("AccessPointNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = EnableAvailabilityZonesForLoadBalancerResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("ElasticLoadBalancing")]
        public void ModifyLoadBalancerAttributesMarshallTest()
        {
            var operation = service_model.FindOperation("ModifyLoadBalancerAttributes");

            var request = InstantiateClassGenerator.Execute<ModifyLoadBalancerAttributesRequest>();
            var marshaller = new ModifyLoadBalancerAttributesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = ModifyLoadBalancerAttributesResponseUnmarshaller.Instance.Unmarshall(context)
                as ModifyLoadBalancerAttributesResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("ElasticLoadBalancing")]
        public void ModifyLoadBalancerAttributes_AccessPointNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ModifyLoadBalancerAttributes");

            var request = InstantiateClassGenerator.Execute<ModifyLoadBalancerAttributesRequest>();
            var marshaller = new ModifyLoadBalancerAttributesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("AccessPointNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = ModifyLoadBalancerAttributesResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("ElasticLoadBalancing")]
        public void ModifyLoadBalancerAttributes_InvalidConfigurationRequestExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ModifyLoadBalancerAttributes");

            var request = InstantiateClassGenerator.Execute<ModifyLoadBalancerAttributesRequest>();
            var marshaller = new ModifyLoadBalancerAttributesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidConfigurationRequestException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = ModifyLoadBalancerAttributesResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("ElasticLoadBalancing")]
        public void ModifyLoadBalancerAttributes_LoadBalancerAttributeNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("ModifyLoadBalancerAttributes");

            var request = InstantiateClassGenerator.Execute<ModifyLoadBalancerAttributesRequest>();
            var marshaller = new ModifyLoadBalancerAttributesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("LoadBalancerAttributeNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = ModifyLoadBalancerAttributesResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("ElasticLoadBalancing")]
        public void RegisterInstancesWithLoadBalancerMarshallTest()
        {
            var operation = service_model.FindOperation("RegisterInstancesWithLoadBalancer");

            var request = InstantiateClassGenerator.Execute<RegisterInstancesWithLoadBalancerRequest>();
            var marshaller = new RegisterInstancesWithLoadBalancerRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = RegisterInstancesWithLoadBalancerResponseUnmarshaller.Instance.Unmarshall(context)
                as RegisterInstancesWithLoadBalancerResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("ElasticLoadBalancing")]
        public void RegisterInstancesWithLoadBalancer_AccessPointNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("RegisterInstancesWithLoadBalancer");

            var request = InstantiateClassGenerator.Execute<RegisterInstancesWithLoadBalancerRequest>();
            var marshaller = new RegisterInstancesWithLoadBalancerRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("AccessPointNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = RegisterInstancesWithLoadBalancerResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("ElasticLoadBalancing")]
        public void RegisterInstancesWithLoadBalancer_InvalidEndPointExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("RegisterInstancesWithLoadBalancer");

            var request = InstantiateClassGenerator.Execute<RegisterInstancesWithLoadBalancerRequest>();
            var marshaller = new RegisterInstancesWithLoadBalancerRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidEndPointException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = RegisterInstancesWithLoadBalancerResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("ElasticLoadBalancing")]
        public void RemoveTagsMarshallTest()
        {
            var operation = service_model.FindOperation("RemoveTags");

            var request = InstantiateClassGenerator.Execute<RemoveTagsRequest>();
            var marshaller = new RemoveTagsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = RemoveTagsResponseUnmarshaller.Instance.Unmarshall(context)
                as RemoveTagsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("ElasticLoadBalancing")]
        public void RemoveTags_AccessPointNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("RemoveTags");

            var request = InstantiateClassGenerator.Execute<RemoveTagsRequest>();
            var marshaller = new RemoveTagsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("AccessPointNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = RemoveTagsResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("ElasticLoadBalancing")]
        public void SetLoadBalancerListenerSSLCertificateMarshallTest()
        {
            var operation = service_model.FindOperation("SetLoadBalancerListenerSSLCertificate");

            var request = InstantiateClassGenerator.Execute<SetLoadBalancerListenerSSLCertificateRequest>();
            var marshaller = new SetLoadBalancerListenerSSLCertificateRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = SetLoadBalancerListenerSSLCertificateResponseUnmarshaller.Instance.Unmarshall(context)
                as SetLoadBalancerListenerSSLCertificateResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("ElasticLoadBalancing")]
        public void SetLoadBalancerListenerSSLCertificate_AccessPointNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("SetLoadBalancerListenerSSLCertificate");

            var request = InstantiateClassGenerator.Execute<SetLoadBalancerListenerSSLCertificateRequest>();
            var marshaller = new SetLoadBalancerListenerSSLCertificateRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("AccessPointNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = SetLoadBalancerListenerSSLCertificateResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("ElasticLoadBalancing")]
        public void SetLoadBalancerListenerSSLCertificate_CertificateNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("SetLoadBalancerListenerSSLCertificate");

            var request = InstantiateClassGenerator.Execute<SetLoadBalancerListenerSSLCertificateRequest>();
            var marshaller = new SetLoadBalancerListenerSSLCertificateRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("CertificateNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = SetLoadBalancerListenerSSLCertificateResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("ElasticLoadBalancing")]
        public void SetLoadBalancerListenerSSLCertificate_InvalidConfigurationRequestExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("SetLoadBalancerListenerSSLCertificate");

            var request = InstantiateClassGenerator.Execute<SetLoadBalancerListenerSSLCertificateRequest>();
            var marshaller = new SetLoadBalancerListenerSSLCertificateRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidConfigurationRequestException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = SetLoadBalancerListenerSSLCertificateResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("ElasticLoadBalancing")]
        public void SetLoadBalancerListenerSSLCertificate_ListenerNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("SetLoadBalancerListenerSSLCertificate");

            var request = InstantiateClassGenerator.Execute<SetLoadBalancerListenerSSLCertificateRequest>();
            var marshaller = new SetLoadBalancerListenerSSLCertificateRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("ListenerNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = SetLoadBalancerListenerSSLCertificateResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("ElasticLoadBalancing")]
        public void SetLoadBalancerListenerSSLCertificate_UnsupportedProtocolExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("SetLoadBalancerListenerSSLCertificate");

            var request = InstantiateClassGenerator.Execute<SetLoadBalancerListenerSSLCertificateRequest>();
            var marshaller = new SetLoadBalancerListenerSSLCertificateRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("UnsupportedProtocolException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = SetLoadBalancerListenerSSLCertificateResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("ElasticLoadBalancing")]
        public void SetLoadBalancerPoliciesForBackendServerMarshallTest()
        {
            var operation = service_model.FindOperation("SetLoadBalancerPoliciesForBackendServer");

            var request = InstantiateClassGenerator.Execute<SetLoadBalancerPoliciesForBackendServerRequest>();
            var marshaller = new SetLoadBalancerPoliciesForBackendServerRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = SetLoadBalancerPoliciesForBackendServerResponseUnmarshaller.Instance.Unmarshall(context)
                as SetLoadBalancerPoliciesForBackendServerResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("ElasticLoadBalancing")]
        public void SetLoadBalancerPoliciesForBackendServer_AccessPointNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("SetLoadBalancerPoliciesForBackendServer");

            var request = InstantiateClassGenerator.Execute<SetLoadBalancerPoliciesForBackendServerRequest>();
            var marshaller = new SetLoadBalancerPoliciesForBackendServerRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("AccessPointNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = SetLoadBalancerPoliciesForBackendServerResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("ElasticLoadBalancing")]
        public void SetLoadBalancerPoliciesForBackendServer_InvalidConfigurationRequestExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("SetLoadBalancerPoliciesForBackendServer");

            var request = InstantiateClassGenerator.Execute<SetLoadBalancerPoliciesForBackendServerRequest>();
            var marshaller = new SetLoadBalancerPoliciesForBackendServerRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidConfigurationRequestException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = SetLoadBalancerPoliciesForBackendServerResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("ElasticLoadBalancing")]
        public void SetLoadBalancerPoliciesForBackendServer_PolicyNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("SetLoadBalancerPoliciesForBackendServer");

            var request = InstantiateClassGenerator.Execute<SetLoadBalancerPoliciesForBackendServerRequest>();
            var marshaller = new SetLoadBalancerPoliciesForBackendServerRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("PolicyNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = SetLoadBalancerPoliciesForBackendServerResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("ElasticLoadBalancing")]
        public void SetLoadBalancerPoliciesOfListenerMarshallTest()
        {
            var operation = service_model.FindOperation("SetLoadBalancerPoliciesOfListener");

            var request = InstantiateClassGenerator.Execute<SetLoadBalancerPoliciesOfListenerRequest>();
            var marshaller = new SetLoadBalancerPoliciesOfListenerRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = SetLoadBalancerPoliciesOfListenerResponseUnmarshaller.Instance.Unmarshall(context)
                as SetLoadBalancerPoliciesOfListenerResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("ElasticLoadBalancing")]
        public void SetLoadBalancerPoliciesOfListener_AccessPointNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("SetLoadBalancerPoliciesOfListener");

            var request = InstantiateClassGenerator.Execute<SetLoadBalancerPoliciesOfListenerRequest>();
            var marshaller = new SetLoadBalancerPoliciesOfListenerRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("AccessPointNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = SetLoadBalancerPoliciesOfListenerResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("ElasticLoadBalancing")]
        public void SetLoadBalancerPoliciesOfListener_InvalidConfigurationRequestExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("SetLoadBalancerPoliciesOfListener");

            var request = InstantiateClassGenerator.Execute<SetLoadBalancerPoliciesOfListenerRequest>();
            var marshaller = new SetLoadBalancerPoliciesOfListenerRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("InvalidConfigurationRequestException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = SetLoadBalancerPoliciesOfListenerResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("ElasticLoadBalancing")]
        public void SetLoadBalancerPoliciesOfListener_ListenerNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("SetLoadBalancerPoliciesOfListener");

            var request = InstantiateClassGenerator.Execute<SetLoadBalancerPoliciesOfListenerRequest>();
            var marshaller = new SetLoadBalancerPoliciesOfListenerRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("ListenerNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = SetLoadBalancerPoliciesOfListenerResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("ElasticLoadBalancing")]
        public void SetLoadBalancerPoliciesOfListener_PolicyNotFoundExceptionMarshallTest()
        {
            var operation = service_model.FindOperation("SetLoadBalancerPoliciesOfListener");

            var request = InstantiateClassGenerator.Execute<SetLoadBalancerPoliciesOfListenerRequest>();
            var marshaller = new SetLoadBalancerPoliciesOfListenerRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);

            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();

            var exception = operation.Exceptions.First(e => e.Name.Equals("PolicyNotFoundException"));
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute(exception);
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), true, null, true);
            var response = SetLoadBalancerPoliciesOfListenerResponseUnmarshaller.Instance.UnmarshallException(context, null, System.Net.HttpStatusCode.OK);

            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);
        }
    }
}