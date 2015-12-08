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
 * Do not modify this file. This file is generated from the autoscaling-2011-01-01.normal.json service model.
 */


using System;
using System.IO;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Amazon.AutoScaling;
using Amazon.AutoScaling.Model;
using Amazon.AutoScaling.Model.Internal.MarshallTransformations;
using Amazon.Runtime.Internal.Transform;

using ServiceClientGenerator;

using AWSSDK_DotNet35.UnitTests.TestTools;

namespace AWSSDK_DotNet35.UnitTests.Marshalling
{
    [TestClass]
    public class AutoScalingMarshallingTests
    {
        static readonly ServiceModel service_model = Utils.LoadServiceModel("autoscaling-2011-01-01.normal.json", "autoscaling.customizations.json");
        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("AutoScaling")]
        public void AttachInstancesMarshallTest()
        {
            var operation = service_model.FindOperation("AttachInstances");

            var request = InstantiateClassGenerator.Execute<AttachInstancesRequest>();
            var marshaller = new AttachInstancesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("AutoScaling")]
        public void AttachLoadBalancersMarshallTest()
        {
            var operation = service_model.FindOperation("AttachLoadBalancers");

            var request = InstantiateClassGenerator.Execute<AttachLoadBalancersRequest>();
            var marshaller = new AttachLoadBalancersRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = AttachLoadBalancersResponseUnmarshaller.Instance.Unmarshall(context)
                as AttachLoadBalancersResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("AutoScaling")]
        public void CompleteLifecycleActionMarshallTest()
        {
            var operation = service_model.FindOperation("CompleteLifecycleAction");

            var request = InstantiateClassGenerator.Execute<CompleteLifecycleActionRequest>();
            var marshaller = new CompleteLifecycleActionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = CompleteLifecycleActionResponseUnmarshaller.Instance.Unmarshall(context)
                as CompleteLifecycleActionResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("AutoScaling")]
        public void CreateAutoScalingGroupMarshallTest()
        {
            var operation = service_model.FindOperation("CreateAutoScalingGroup");

            var request = InstantiateClassGenerator.Execute<CreateAutoScalingGroupRequest>();
            var marshaller = new CreateAutoScalingGroupRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("AutoScaling")]
        public void CreateLaunchConfigurationMarshallTest()
        {
            var operation = service_model.FindOperation("CreateLaunchConfiguration");

            var request = InstantiateClassGenerator.Execute<CreateLaunchConfigurationRequest>();
            var marshaller = new CreateLaunchConfigurationRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("AutoScaling")]
        public void CreateOrUpdateTagsMarshallTest()
        {
            var operation = service_model.FindOperation("CreateOrUpdateTags");

            var request = InstantiateClassGenerator.Execute<CreateOrUpdateTagsRequest>();
            var marshaller = new CreateOrUpdateTagsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("AutoScaling")]
        public void DeleteAutoScalingGroupMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteAutoScalingGroup");

            var request = InstantiateClassGenerator.Execute<DeleteAutoScalingGroupRequest>();
            var marshaller = new DeleteAutoScalingGroupRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("AutoScaling")]
        public void DeleteLaunchConfigurationMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteLaunchConfiguration");

            var request = InstantiateClassGenerator.Execute<DeleteLaunchConfigurationRequest>();
            var marshaller = new DeleteLaunchConfigurationRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("AutoScaling")]
        public void DeleteLifecycleHookMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteLifecycleHook");

            var request = InstantiateClassGenerator.Execute<DeleteLifecycleHookRequest>();
            var marshaller = new DeleteLifecycleHookRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = DeleteLifecycleHookResponseUnmarshaller.Instance.Unmarshall(context)
                as DeleteLifecycleHookResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("AutoScaling")]
        public void DeleteNotificationConfigurationMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteNotificationConfiguration");

            var request = InstantiateClassGenerator.Execute<DeleteNotificationConfigurationRequest>();
            var marshaller = new DeleteNotificationConfigurationRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("AutoScaling")]
        public void DeletePolicyMarshallTest()
        {
            var operation = service_model.FindOperation("DeletePolicy");

            var request = InstantiateClassGenerator.Execute<DeletePolicyRequest>();
            var marshaller = new DeletePolicyRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("AutoScaling")]
        public void DeleteScheduledActionMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteScheduledAction");

            var request = InstantiateClassGenerator.Execute<DeleteScheduledActionRequest>();
            var marshaller = new DeleteScheduledActionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("AutoScaling")]
        public void DeleteTagsMarshallTest()
        {
            var operation = service_model.FindOperation("DeleteTags");

            var request = InstantiateClassGenerator.Execute<DeleteTagsRequest>();
            var marshaller = new DeleteTagsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("AutoScaling")]
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
        [TestCategory("AutoScaling")]
        public void DescribeAdjustmentTypesMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeAdjustmentTypes");

            var request = InstantiateClassGenerator.Execute<DescribeAdjustmentTypesRequest>();
            var marshaller = new DescribeAdjustmentTypesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = DescribeAdjustmentTypesResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeAdjustmentTypesResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("AutoScaling")]
        public void DescribeAutoScalingGroupsMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeAutoScalingGroups");

            var request = InstantiateClassGenerator.Execute<DescribeAutoScalingGroupsRequest>();
            var marshaller = new DescribeAutoScalingGroupsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = DescribeAutoScalingGroupsResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeAutoScalingGroupsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("AutoScaling")]
        public void DescribeAutoScalingInstancesMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeAutoScalingInstances");

            var request = InstantiateClassGenerator.Execute<DescribeAutoScalingInstancesRequest>();
            var marshaller = new DescribeAutoScalingInstancesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = DescribeAutoScalingInstancesResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeAutoScalingInstancesResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("AutoScaling")]
        public void DescribeAutoScalingNotificationTypesMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeAutoScalingNotificationTypes");

            var request = InstantiateClassGenerator.Execute<DescribeAutoScalingNotificationTypesRequest>();
            var marshaller = new DescribeAutoScalingNotificationTypesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = DescribeAutoScalingNotificationTypesResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeAutoScalingNotificationTypesResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("AutoScaling")]
        public void DescribeLaunchConfigurationsMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeLaunchConfigurations");

            var request = InstantiateClassGenerator.Execute<DescribeLaunchConfigurationsRequest>();
            var marshaller = new DescribeLaunchConfigurationsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = DescribeLaunchConfigurationsResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeLaunchConfigurationsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("AutoScaling")]
        public void DescribeLifecycleHooksMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeLifecycleHooks");

            var request = InstantiateClassGenerator.Execute<DescribeLifecycleHooksRequest>();
            var marshaller = new DescribeLifecycleHooksRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = DescribeLifecycleHooksResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeLifecycleHooksResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("AutoScaling")]
        public void DescribeLifecycleHookTypesMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeLifecycleHookTypes");

            var request = InstantiateClassGenerator.Execute<DescribeLifecycleHookTypesRequest>();
            var marshaller = new DescribeLifecycleHookTypesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = DescribeLifecycleHookTypesResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeLifecycleHookTypesResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("AutoScaling")]
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
        [TestCategory("AutoScaling")]
        public void DescribeMetricCollectionTypesMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeMetricCollectionTypes");

            var request = InstantiateClassGenerator.Execute<DescribeMetricCollectionTypesRequest>();
            var marshaller = new DescribeMetricCollectionTypesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = DescribeMetricCollectionTypesResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeMetricCollectionTypesResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("AutoScaling")]
        public void DescribeNotificationConfigurationsMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeNotificationConfigurations");

            var request = InstantiateClassGenerator.Execute<DescribeNotificationConfigurationsRequest>();
            var marshaller = new DescribeNotificationConfigurationsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = DescribeNotificationConfigurationsResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeNotificationConfigurationsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("AutoScaling")]
        public void DescribePoliciesMarshallTest()
        {
            var operation = service_model.FindOperation("DescribePolicies");

            var request = InstantiateClassGenerator.Execute<DescribePoliciesRequest>();
            var marshaller = new DescribePoliciesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = DescribePoliciesResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribePoliciesResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("AutoScaling")]
        public void DescribeScalingActivitiesMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeScalingActivities");

            var request = InstantiateClassGenerator.Execute<DescribeScalingActivitiesRequest>();
            var marshaller = new DescribeScalingActivitiesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = DescribeScalingActivitiesResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeScalingActivitiesResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("AutoScaling")]
        public void DescribeScalingProcessTypesMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeScalingProcessTypes");

            var request = InstantiateClassGenerator.Execute<DescribeScalingProcessTypesRequest>();
            var marshaller = new DescribeScalingProcessTypesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = DescribeScalingProcessTypesResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeScalingProcessTypesResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("AutoScaling")]
        public void DescribeScheduledActionsMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeScheduledActions");

            var request = InstantiateClassGenerator.Execute<DescribeScheduledActionsRequest>();
            var marshaller = new DescribeScheduledActionsRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = DescribeScheduledActionsResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeScheduledActionsResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("AutoScaling")]
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
        [TestCategory("AutoScaling")]
        public void DescribeTerminationPolicyTypesMarshallTest()
        {
            var operation = service_model.FindOperation("DescribeTerminationPolicyTypes");

            var request = InstantiateClassGenerator.Execute<DescribeTerminationPolicyTypesRequest>();
            var marshaller = new DescribeTerminationPolicyTypesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = DescribeTerminationPolicyTypesResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeTerminationPolicyTypesResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("AutoScaling")]
        public void DetachInstancesMarshallTest()
        {
            var operation = service_model.FindOperation("DetachInstances");

            var request = InstantiateClassGenerator.Execute<DetachInstancesRequest>();
            var marshaller = new DetachInstancesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = DetachInstancesResponseUnmarshaller.Instance.Unmarshall(context)
                as DetachInstancesResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("AutoScaling")]
        public void DetachLoadBalancersMarshallTest()
        {
            var operation = service_model.FindOperation("DetachLoadBalancers");

            var request = InstantiateClassGenerator.Execute<DetachLoadBalancersRequest>();
            var marshaller = new DetachLoadBalancersRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = DetachLoadBalancersResponseUnmarshaller.Instance.Unmarshall(context)
                as DetachLoadBalancersResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("AutoScaling")]
        public void DisableMetricsCollectionMarshallTest()
        {
            var operation = service_model.FindOperation("DisableMetricsCollection");

            var request = InstantiateClassGenerator.Execute<DisableMetricsCollectionRequest>();
            var marshaller = new DisableMetricsCollectionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("AutoScaling")]
        public void EnableMetricsCollectionMarshallTest()
        {
            var operation = service_model.FindOperation("EnableMetricsCollection");

            var request = InstantiateClassGenerator.Execute<EnableMetricsCollectionRequest>();
            var marshaller = new EnableMetricsCollectionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("AutoScaling")]
        public void EnterStandbyMarshallTest()
        {
            var operation = service_model.FindOperation("EnterStandby");

            var request = InstantiateClassGenerator.Execute<EnterStandbyRequest>();
            var marshaller = new EnterStandbyRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = EnterStandbyResponseUnmarshaller.Instance.Unmarshall(context)
                as EnterStandbyResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("AutoScaling")]
        public void ExecutePolicyMarshallTest()
        {
            var operation = service_model.FindOperation("ExecutePolicy");

            var request = InstantiateClassGenerator.Execute<ExecutePolicyRequest>();
            var marshaller = new ExecutePolicyRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("AutoScaling")]
        public void ExitStandbyMarshallTest()
        {
            var operation = service_model.FindOperation("ExitStandby");

            var request = InstantiateClassGenerator.Execute<ExitStandbyRequest>();
            var marshaller = new ExitStandbyRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = ExitStandbyResponseUnmarshaller.Instance.Unmarshall(context)
                as ExitStandbyResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("AutoScaling")]
        public void PutLifecycleHookMarshallTest()
        {
            var operation = service_model.FindOperation("PutLifecycleHook");

            var request = InstantiateClassGenerator.Execute<PutLifecycleHookRequest>();
            var marshaller = new PutLifecycleHookRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = PutLifecycleHookResponseUnmarshaller.Instance.Unmarshall(context)
                as PutLifecycleHookResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("AutoScaling")]
        public void PutNotificationConfigurationMarshallTest()
        {
            var operation = service_model.FindOperation("PutNotificationConfiguration");

            var request = InstantiateClassGenerator.Execute<PutNotificationConfigurationRequest>();
            var marshaller = new PutNotificationConfigurationRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("AutoScaling")]
        public void PutScalingPolicyMarshallTest()
        {
            var operation = service_model.FindOperation("PutScalingPolicy");

            var request = InstantiateClassGenerator.Execute<PutScalingPolicyRequest>();
            var marshaller = new PutScalingPolicyRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = PutScalingPolicyResponseUnmarshaller.Instance.Unmarshall(context)
                as PutScalingPolicyResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("AutoScaling")]
        public void PutScheduledUpdateGroupActionMarshallTest()
        {
            var operation = service_model.FindOperation("PutScheduledUpdateGroupAction");

            var request = InstantiateClassGenerator.Execute<PutScheduledUpdateGroupActionRequest>();
            var marshaller = new PutScheduledUpdateGroupActionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("AutoScaling")]
        public void RecordLifecycleActionHeartbeatMarshallTest()
        {
            var operation = service_model.FindOperation("RecordLifecycleActionHeartbeat");

            var request = InstantiateClassGenerator.Execute<RecordLifecycleActionHeartbeatRequest>();
            var marshaller = new RecordLifecycleActionHeartbeatRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = RecordLifecycleActionHeartbeatResponseUnmarshaller.Instance.Unmarshall(context)
                as RecordLifecycleActionHeartbeatResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("AutoScaling")]
        public void ResumeProcessesMarshallTest()
        {
            var operation = service_model.FindOperation("ResumeProcesses");

            var request = InstantiateClassGenerator.Execute<ResumeProcessesRequest>();
            var marshaller = new ResumeProcessesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("AutoScaling")]
        public void SetDesiredCapacityMarshallTest()
        {
            var operation = service_model.FindOperation("SetDesiredCapacity");

            var request = InstantiateClassGenerator.Execute<SetDesiredCapacityRequest>();
            var marshaller = new SetDesiredCapacityRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("AutoScaling")]
        public void SetInstanceHealthMarshallTest()
        {
            var operation = service_model.FindOperation("SetInstanceHealth");

            var request = InstantiateClassGenerator.Execute<SetInstanceHealthRequest>();
            var marshaller = new SetInstanceHealthRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("AutoScaling")]
        public void SetInstanceProtectionMarshallTest()
        {
            var operation = service_model.FindOperation("SetInstanceProtection");

            var request = InstantiateClassGenerator.Execute<SetInstanceProtectionRequest>();
            var marshaller = new SetInstanceProtectionRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = SetInstanceProtectionResponseUnmarshaller.Instance.Unmarshall(context)
                as SetInstanceProtectionResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("AutoScaling")]
        public void SuspendProcessesMarshallTest()
        {
            var operation = service_model.FindOperation("SuspendProcesses");

            var request = InstantiateClassGenerator.Execute<SuspendProcessesRequest>();
            var marshaller = new SuspendProcessesRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("AutoScaling")]
        public void TerminateInstanceInAutoScalingGroupMarshallTest()
        {
            var operation = service_model.FindOperation("TerminateInstanceInAutoScalingGroup");

            var request = InstantiateClassGenerator.Execute<TerminateInstanceInAutoScalingGroupRequest>();
            var marshaller = new TerminateInstanceInAutoScalingGroupRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, null);
            var response = TerminateInstanceInAutoScalingGroupResponseUnmarshaller.Instance.Unmarshall(context)
                as TerminateInstanceInAutoScalingGroupResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Query")]
        [TestCategory("AutoScaling")]
        public void UpdateAutoScalingGroupMarshallTest()
        {
            var operation = service_model.FindOperation("UpdateAutoScalingGroup");

            var request = InstantiateClassGenerator.Execute<UpdateAutoScalingGroupRequest>();
            var marshaller = new UpdateAutoScalingGroupRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var validator = new AWSQueryValidator(internalRequest.Parameters, request, service_model, operation);
            validator.Validate();


        }

        
    }
}