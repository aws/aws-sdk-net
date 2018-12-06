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
 * Do not modify this file. This file is generated from the elasticloadbalancingv2-2015-12-01.normal.json service model.
 */


using System;
using System.IO;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Amazon.ElasticLoadBalancingV2;
using Amazon.ElasticLoadBalancingV2.Model;
using Amazon.ElasticLoadBalancingV2.Model.Internal.MarshallTransformations;
using Amazon.Runtime.Internal.Transform;

using ServiceClientGenerator;

using AWSSDK_DotNet35.UnitTests.TestTools;

namespace AWSSDK_DotNet35.UnitTests.Marshalling
{
    [TestClass]
    public class ElasticLoadBalancingV2MarshallingTests
    {
        static readonly ServiceModel service_model = Utils.LoadServiceModel("elasticloadbalancingv2");
        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("ElasticLoadBalancingV2")]
        public void AddListenerCertificatesMarshallTest()
        {
            var operation = service_model.FindOperation("AddListenerCertificates");

            var request = InstantiateClassGenerator.Execute<AddListenerCertificatesRequest>();
            var marshaller = new AddListenerCertificatesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = AddListenerCertificatesResponseUnmarshaller.Instance.Unmarshall(context)
                as AddListenerCertificatesResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("ElasticLoadBalancingV2")]
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
        [TestCategory("ElasticLoadBalancingV2")]
        public void CreateListenerMarshallTest()
        {
            var operation = service_model.FindOperation("CreateListener");

            var request = InstantiateClassGenerator.Execute<CreateListenerRequest>();
            var marshaller = new CreateListenerRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = CreateListenerResponseUnmarshaller.Instance.Unmarshall(context)
                as CreateListenerResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("ElasticLoadBalancingV2")]
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
        [TestCategory("ElasticLoadBalancingV2")]
        public void CreateRuleMarshallTest()
        {
            var operation = service_model.FindOperation("CreateRule");

            var request = InstantiateClassGenerator.Execute<CreateRuleRequest>();
            var marshaller = new CreateRuleRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = CreateRuleResponseUnmarshaller.Instance.Unmarshall(context)
                as CreateRuleResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("ElasticLoadBalancingV2")]
        public void CreateTargetGroupMarshallTest()
        {
            var operation = service_model.FindOperation("CreateTargetGroup");

            var request = InstantiateClassGenerator.Execute<CreateTargetGroupRequest>();
            var marshaller = new CreateTargetGroupRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = CreateTargetGroupResponseUnmarshaller.Instance.Unmarshall(context)
                as CreateTargetGroupResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("ElasticLoadBalancingV2")]
        public void DeleteListenerMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteListener");

            var request = InstantiateClassGenerator.Execute<DeleteListenerRequest>();
            var marshaller = new DeleteListenerRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = DeleteListenerResponseUnmarshaller.Instance.Unmarshall(context)
                as DeleteListenerResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("ElasticLoadBalancingV2")]
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
        [TestCategory("ElasticLoadBalancingV2")]
        public void DeleteRuleMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteRule");

            var request = InstantiateClassGenerator.Execute<DeleteRuleRequest>();
            var marshaller = new DeleteRuleRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = DeleteRuleResponseUnmarshaller.Instance.Unmarshall(context)
                as DeleteRuleResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("ElasticLoadBalancingV2")]
        public void DeleteTargetGroupMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteTargetGroup");

            var request = InstantiateClassGenerator.Execute<DeleteTargetGroupRequest>();
            var marshaller = new DeleteTargetGroupRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = DeleteTargetGroupResponseUnmarshaller.Instance.Unmarshall(context)
                as DeleteTargetGroupResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("ElasticLoadBalancingV2")]
        public void DeregisterTargetsMarshallTest()
        {
            var operation = service_model.FindOperation("DeregisterTargets");

            var request = InstantiateClassGenerator.Execute<DeregisterTargetsRequest>();
            var marshaller = new DeregisterTargetsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = DeregisterTargetsResponseUnmarshaller.Instance.Unmarshall(context)
                as DeregisterTargetsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("ElasticLoadBalancingV2")]
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
        [TestCategory("ElasticLoadBalancingV2")]
        public void DescribeListenerCertificatesMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeListenerCertificates");

            var request = InstantiateClassGenerator.Execute<DescribeListenerCertificatesRequest>();
            var marshaller = new DescribeListenerCertificatesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = DescribeListenerCertificatesResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeListenerCertificatesResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("ElasticLoadBalancingV2")]
        public void DescribeListenersMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeListeners");

            var request = InstantiateClassGenerator.Execute<DescribeListenersRequest>();
            var marshaller = new DescribeListenersRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = DescribeListenersResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeListenersResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("ElasticLoadBalancingV2")]
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
        [TestCategory("ElasticLoadBalancingV2")]
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
        [TestCategory("ElasticLoadBalancingV2")]
        public void DescribeRulesMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeRules");

            var request = InstantiateClassGenerator.Execute<DescribeRulesRequest>();
            var marshaller = new DescribeRulesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = DescribeRulesResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeRulesResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("ElasticLoadBalancingV2")]
        public void DescribeSSLPoliciesMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeSSLPolicies");

            var request = InstantiateClassGenerator.Execute<DescribeSSLPoliciesRequest>();
            var marshaller = new DescribeSSLPoliciesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = DescribeSSLPoliciesResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeSSLPoliciesResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("ElasticLoadBalancingV2")]
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
        [TestCategory("ElasticLoadBalancingV2")]
        public void DescribeTargetGroupAttributesMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeTargetGroupAttributes");

            var request = InstantiateClassGenerator.Execute<DescribeTargetGroupAttributesRequest>();
            var marshaller = new DescribeTargetGroupAttributesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = DescribeTargetGroupAttributesResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeTargetGroupAttributesResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("ElasticLoadBalancingV2")]
        public void DescribeTargetGroupsMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeTargetGroups");

            var request = InstantiateClassGenerator.Execute<DescribeTargetGroupsRequest>();
            var marshaller = new DescribeTargetGroupsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = DescribeTargetGroupsResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeTargetGroupsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("ElasticLoadBalancingV2")]
        public void DescribeTargetHealthMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeTargetHealth");

            var request = InstantiateClassGenerator.Execute<DescribeTargetHealthRequest>();
            var marshaller = new DescribeTargetHealthRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = DescribeTargetHealthResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeTargetHealthResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("ElasticLoadBalancingV2")]
        public void ModifyListenerMarshallTest()
        {
            var operation = service_model.FindOperation("ModifyListener");

            var request = InstantiateClassGenerator.Execute<ModifyListenerRequest>();
            var marshaller = new ModifyListenerRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = ModifyListenerResponseUnmarshaller.Instance.Unmarshall(context)
                as ModifyListenerResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("ElasticLoadBalancingV2")]
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
        [TestCategory("ElasticLoadBalancingV2")]
        public void ModifyRuleMarshallTest()
        {
            var operation = service_model.FindOperation("ModifyRule");

            var request = InstantiateClassGenerator.Execute<ModifyRuleRequest>();
            var marshaller = new ModifyRuleRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = ModifyRuleResponseUnmarshaller.Instance.Unmarshall(context)
                as ModifyRuleResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("ElasticLoadBalancingV2")]
        public void ModifyTargetGroupMarshallTest()
        {
            var operation = service_model.FindOperation("ModifyTargetGroup");

            var request = InstantiateClassGenerator.Execute<ModifyTargetGroupRequest>();
            var marshaller = new ModifyTargetGroupRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = ModifyTargetGroupResponseUnmarshaller.Instance.Unmarshall(context)
                as ModifyTargetGroupResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("ElasticLoadBalancingV2")]
        public void ModifyTargetGroupAttributesMarshallTest()
        {
            var operation = service_model.FindOperation("ModifyTargetGroupAttributes");

            var request = InstantiateClassGenerator.Execute<ModifyTargetGroupAttributesRequest>();
            var marshaller = new ModifyTargetGroupAttributesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = ModifyTargetGroupAttributesResponseUnmarshaller.Instance.Unmarshall(context)
                as ModifyTargetGroupAttributesResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("ElasticLoadBalancingV2")]
        public void RegisterTargetsMarshallTest()
        {
            var operation = service_model.FindOperation("RegisterTargets");

            var request = InstantiateClassGenerator.Execute<RegisterTargetsRequest>();
            var marshaller = new RegisterTargetsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = RegisterTargetsResponseUnmarshaller.Instance.Unmarshall(context)
                as RegisterTargetsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("ElasticLoadBalancingV2")]
        public void RemoveListenerCertificatesMarshallTest()
        {
            var operation = service_model.FindOperation("RemoveListenerCertificates");

            var request = InstantiateClassGenerator.Execute<RemoveListenerCertificatesRequest>();
            var marshaller = new RemoveListenerCertificatesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = RemoveListenerCertificatesResponseUnmarshaller.Instance.Unmarshall(context)
                as RemoveListenerCertificatesResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("ElasticLoadBalancingV2")]
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
        [TestCategory("ElasticLoadBalancingV2")]
        public void SetIpAddressTypeMarshallTest()
        {
            var operation = service_model.FindOperation("SetIpAddressType");

            var request = InstantiateClassGenerator.Execute<SetIpAddressTypeRequest>();
            var marshaller = new SetIpAddressTypeRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = SetIpAddressTypeResponseUnmarshaller.Instance.Unmarshall(context)
                as SetIpAddressTypeResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("ElasticLoadBalancingV2")]
        public void SetRulePrioritiesMarshallTest()
        {
            var operation = service_model.FindOperation("SetRulePriorities");

            var request = InstantiateClassGenerator.Execute<SetRulePrioritiesRequest>();
            var marshaller = new SetRulePrioritiesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = SetRulePrioritiesResponseUnmarshaller.Instance.Unmarshall(context)
                as SetRulePrioritiesResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("ElasticLoadBalancingV2")]
        public void SetSecurityGroupsMarshallTest()
        {
            var operation = service_model.FindOperation("SetSecurityGroups");

            var request = InstantiateClassGenerator.Execute<SetSecurityGroupsRequest>();
            var marshaller = new SetSecurityGroupsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = SetSecurityGroupsResponseUnmarshaller.Instance.Unmarshall(context)
                as SetSecurityGroupsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("ElasticLoadBalancingV2")]
        public void SetSubnetsMarshallTest()
        {
            var operation = service_model.FindOperation("SetSubnets");

            var request = InstantiateClassGenerator.Execute<SetSubnetsRequest>();
            var marshaller = new SetSubnetsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = SetSubnetsResponseUnmarshaller.Instance.Unmarshall(context)
                as SetSubnetsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        
    }
}