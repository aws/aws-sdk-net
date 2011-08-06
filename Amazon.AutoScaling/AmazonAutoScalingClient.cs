/*
 * Copyright 2010-2011 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;

using Amazon.AutoScaling.Model;
using Amazon.AutoScaling.Model.Transform;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;


namespace Amazon.AutoScaling
{
    /// <summary>
    /// Implemenation for accessing AmazonAutoScaling.
    ///  
    /// Auto Scaling <para> Auto Scaling is a web service designed to automatically launch or terminate EC2 instances based on user-defined
    /// policies, schedules, and health checks. Auto Scaling responds automatically to changing conditions. All you need to do is specify how it
    /// should respond to those changes. </para> <para> Auto Scaling groups can work across multiple Availability Zones - distinct physical
    /// locations for the hosted Amazon EC2 instances - so that if an Availability Zone becomes unavailable, Auto Scaling will automatically
    /// redistribute applications to a different Availability Zone. </para> <para> Every API call returns a response meta data object that contains
    /// a request identifier. Successful requests return an HTTP 200 status code. Unsuccessful requests return an error object and an HTTP status
    /// code of 400 or 500. </para> <para>The current WSDL is available at:</para> <para>
    /// http://autoscaling.amazonaws.com/doc/2011-01-01/AutoScaling.wsdl </para> <para> <b>Endpoints</b> </para> <para>For information about this
    /// product's regions and endpoints, go to Regions and Endpoints in the Amazon Web Services General Reference. </para>
    /// </summary>
    public class AmazonAutoScalingClient : AmazonWebServiceClient, AmazonAutoScaling
    {
    
    
        AbstractAWSSigner signer = new QueryStringSigner();

        /// <summary>
        /// Constructs AmazonAutoScalingClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonAutoScalingClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonAutoScalingConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonAutoScalingClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonAutoScalingClient Configuration object. If the config object's
        /// UseSecureStringForAwsSecretKey is false, the AWS Secret Key
        /// is stored as a clear-text string. Please use this option only
        /// if the application environment doesn't allow the use of SecureStrings.
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonAutoScalingClient Configuration Object</param>
        public AmazonAutoScalingClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonAutoScalingConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }
        
   

         /// <summary>
         /// <para> Returns a full description of each Auto Scaling group in the given list. This includes all Amazon EC2 instances that are members of
         /// the group. If a list of names is not provided, the service returns the full details of all Auto Scaling groups. </para> <para> This action
         /// supports pagination by returning a token if there are more pages to retrieve. To get the next page, call this action again with the returned
         /// token as the NextToken parameter. </para>
         /// </summary>
         /// 
         /// <param name="describeAutoScalingGroupsRequest">Container for the necessary parameters to execute the DescribeAutoScalingGroups service
         ///           method on AmazonAutoScaling.</param>
         /// 
         /// <returns>The response from the DescribeAutoScalingGroups service method, as returned by AmazonAutoScaling.</returns>
         /// 
         /// <exception cref="InvalidNextTokenException"/>
        public DescribeAutoScalingGroupsResponse DescribeAutoScalingGroups(DescribeAutoScalingGroupsRequest describeAutoScalingGroupsRequest) 
        {           
            IRequest<DescribeAutoScalingGroupsRequest> request = new DescribeAutoScalingGroupsRequestMarshaller().Marshall(describeAutoScalingGroupsRequest);
            DescribeAutoScalingGroupsResponse response = Invoke<DescribeAutoScalingGroupsRequest, DescribeAutoScalingGroupsResponse> (request, this.signer, DescribeAutoScalingGroupsResponseUnmarshaller.GetInstance());
            return response;
        }
    

         /// <summary>
         /// <para> Enables monitoring of group metrics for the Auto Scaling group specified in AutoScalingGroupName. You can specify the list of enabled
         /// metrics with the Metrics parameter. </para> <para> Auto scaling metrics collection can be turned on only if the
         /// <c>InstanceMonitoring.Enabled</c> flag, in the Auto Scaling group's launch configuration, is set to <c>true</c> .
         /// </para>
         /// </summary>
         /// 
         /// <param name="enableMetricsCollectionRequest">Container for the necessary parameters to execute the EnableMetricsCollection service method on
         ///           AmazonAutoScaling.</param>
         /// 
        public EnableMetricsCollectionResponse EnableMetricsCollection(EnableMetricsCollectionRequest enableMetricsCollectionRequest) 
        {           
            IRequest<EnableMetricsCollectionRequest> request = new EnableMetricsCollectionRequestMarshaller().Marshall(enableMetricsCollectionRequest);
            EnableMetricsCollectionResponse response = Invoke<EnableMetricsCollectionRequest, EnableMetricsCollectionResponse> (request, this.signer, EnableMetricsCollectionResponseUnmarshaller.GetInstance());
            return response;
        }
    

         /// <summary>
         /// <para> Resumes Auto Scaling processes for an Auto Scaling group. For more information, see SuspendProcesses and ProcessType. </para>
         /// </summary>
         /// 
         /// <param name="resumeProcessesRequest">Container for the necessary parameters to execute the ResumeProcesses service method on
         ///           AmazonAutoScaling.</param>
         /// 
        public ResumeProcessesResponse ResumeProcesses(ResumeProcessesRequest resumeProcessesRequest) 
        {           
            IRequest<ResumeProcessesRequest> request = new ResumeProcessesRequestMarshaller().Marshall(resumeProcessesRequest);
            ResumeProcessesResponse response = Invoke<ResumeProcessesRequest, ResumeProcessesResponse> (request, this.signer, ResumeProcessesResponseUnmarshaller.GetInstance());
            return response;
        }
    

         /// <summary>
         /// <para> Deletes the specified LaunchConfiguration. </para> <para> The specified launch configuration must not be attached to an Auto Scaling
         /// group. Once this call completes, the launch configuration is no longer available for use. </para>
         /// </summary>
         /// 
         /// <param name="deleteLaunchConfigurationRequest">Container for the necessary parameters to execute the DeleteLaunchConfiguration service
         ///           method on AmazonAutoScaling.</param>
         /// 
         /// <exception cref="ResourceInUseException"/>
        public DeleteLaunchConfigurationResponse DeleteLaunchConfiguration(DeleteLaunchConfigurationRequest deleteLaunchConfigurationRequest) 
        {           
            IRequest<DeleteLaunchConfigurationRequest> request = new DeleteLaunchConfigurationRequestMarshaller().Marshall(deleteLaunchConfigurationRequest);
            DeleteLaunchConfigurationResponse response = Invoke<DeleteLaunchConfigurationRequest, DeleteLaunchConfigurationResponse> (request, this.signer, DeleteLaunchConfigurationResponseUnmarshaller.GetInstance());
            return response;
        }
    

         /// <summary>
         /// <para> Returns descriptions of what each policy does. This action supports pagination. If the response includes a token, there are more
         /// records available. To get the additional records, repeat the request with the response token as the NextToken parameter. </para>
         /// </summary>
         /// 
         /// <param name="describePoliciesRequest">Container for the necessary parameters to execute the DescribePolicies service method on
         ///           AmazonAutoScaling.</param>
         /// 
         /// <returns>The response from the DescribePolicies service method, as returned by AmazonAutoScaling.</returns>
         /// 
         /// <exception cref="InvalidNextTokenException"/>
        public DescribePoliciesResponse DescribePolicies(DescribePoliciesRequest describePoliciesRequest) 
        {           
            IRequest<DescribePoliciesRequest> request = new DescribePoliciesRequestMarshaller().Marshall(describePoliciesRequest);
            DescribePoliciesResponse response = Invoke<DescribePoliciesRequest, DescribePoliciesResponse> (request, this.signer, DescribePoliciesResponseUnmarshaller.GetInstance());
            return response;
        }
    

         /// <summary>
         /// <para>Returns scaling process types for use in the ResumeProcesses and SuspendProcesses actions.</para>
         /// </summary>
         /// 
         /// <param name="describeScalingProcessTypesRequest">Container for the necessary parameters to execute the DescribeScalingProcessTypes service
         ///           method on AmazonAutoScaling.</param>
         /// 
         /// <returns>The response from the DescribeScalingProcessTypes service method, as returned by AmazonAutoScaling.</returns>
         /// 
        public DescribeScalingProcessTypesResponse DescribeScalingProcessTypes(DescribeScalingProcessTypesRequest describeScalingProcessTypesRequest) 
        {           
            IRequest<DescribeScalingProcessTypesRequest> request = new DescribeScalingProcessTypesRequestMarshaller().Marshall(describeScalingProcessTypesRequest);
            DescribeScalingProcessTypesResponse response = Invoke<DescribeScalingProcessTypesRequest, DescribeScalingProcessTypesResponse> (request, this.signer, DescribeScalingProcessTypesResponseUnmarshaller.GetInstance());
            return response;
        }
    

         /// <summary>
         /// <para> Creates a new Auto Scaling group with the specified name. Once the creation request is completed, the AutoScalingGroup is ready to be
         /// used in other calls. </para> <para><b>NOTE:</b> The Auto Scaling group name must be unique within the scope of your AWS account, and under
         /// the quota of Auto Scaling groups allowed for your account. </para>
         /// </summary>
         /// 
         /// <param name="createAutoScalingGroupRequest">Container for the necessary parameters to execute the CreateAutoScalingGroup service method on
         ///           AmazonAutoScaling.</param>
         /// 
         /// <exception cref="LimitExceededException"/>
         /// <exception cref="AlreadyExistsException"/>
        public CreateAutoScalingGroupResponse CreateAutoScalingGroup(CreateAutoScalingGroupRequest createAutoScalingGroupRequest) 
        {           
            IRequest<CreateAutoScalingGroupRequest> request = new CreateAutoScalingGroupRequestMarshaller().Marshall(createAutoScalingGroupRequest);
            CreateAutoScalingGroupResponse response = Invoke<CreateAutoScalingGroupRequest, CreateAutoScalingGroupResponse> (request, this.signer, CreateAutoScalingGroupResponseUnmarshaller.GetInstance());
            return response;
        }
    

         /// <summary>
         /// <para> Returns the scaling activities for the specified Auto Scaling group. </para> <para> If the specified <i>ActivityIds</i> list is
         /// empty, all the activities from the past six weeks are returned. Activities are sorted by completion time. Activities still in progress
         /// appear first on the list. </para> <para> This action supports pagination. If the response includes a token, there are more records
         /// available. To get the additional records, repeat the request with the response token as the NextToken parameter. </para>
         /// </summary>
         /// 
         /// <param name="describeScalingActivitiesRequest">Container for the necessary parameters to execute the DescribeScalingActivities service
         ///           method on AmazonAutoScaling.</param>
         /// 
         /// <returns>The response from the DescribeScalingActivities service method, as returned by AmazonAutoScaling.</returns>
         /// 
         /// <exception cref="InvalidNextTokenException"/>
        public DescribeScalingActivitiesResponse DescribeScalingActivities(DescribeScalingActivitiesRequest describeScalingActivitiesRequest) 
        {           
            IRequest<DescribeScalingActivitiesRequest> request = new DescribeScalingActivitiesRequestMarshaller().Marshall(describeScalingActivitiesRequest);
            DescribeScalingActivitiesResponse response = Invoke<DescribeScalingActivitiesRequest, DescribeScalingActivitiesResponse> (request, this.signer, DescribeScalingActivitiesResponseUnmarshaller.GetInstance());
            return response;
        }
    

         /// <summary>
         /// <para> Returns a list of notification actions associated with Auto Scaling groups for specified events. </para>
         /// </summary>
         /// 
         /// <param name="describeNotificationConfigurationsRequest">Container for the necessary parameters to execute the
         ///           DescribeNotificationConfigurations service method on AmazonAutoScaling.</param>
         /// 
         /// <returns>The response from the DescribeNotificationConfigurations service method, as returned by AmazonAutoScaling.</returns>
         /// 
         /// <exception cref="InvalidNextTokenException"/>
        public DescribeNotificationConfigurationsResponse DescribeNotificationConfigurations(DescribeNotificationConfigurationsRequest describeNotificationConfigurationsRequest) 
        {           
            IRequest<DescribeNotificationConfigurationsRequest> request = new DescribeNotificationConfigurationsRequestMarshaller().Marshall(describeNotificationConfigurationsRequest);
            DescribeNotificationConfigurationsResponse response = Invoke<DescribeNotificationConfigurationsRequest, DescribeNotificationConfigurationsResponse> (request, this.signer, DescribeNotificationConfigurationsResponseUnmarshaller.GetInstance());
            return response;
        }
    

         /// <summary>
         /// <para>Runs the policy you create for your Auto Scaling group in PutScalingPolicy.</para>
         /// </summary>
         /// 
         /// <param name="executePolicyRequest">Container for the necessary parameters to execute the ExecutePolicy service method on
         ///           AmazonAutoScaling.</param>
         /// 
         /// <exception cref="ScalingActivityInProgressException"/>
        public ExecutePolicyResponse ExecutePolicy(ExecutePolicyRequest executePolicyRequest) 
        {           
            IRequest<ExecutePolicyRequest> request = new ExecutePolicyRequestMarshaller().Marshall(executePolicyRequest);
            ExecutePolicyResponse response = Invoke<ExecutePolicyRequest, ExecutePolicyResponse> (request, this.signer, ExecutePolicyResponseUnmarshaller.GetInstance());
            return response;
        }
    

         /// <summary>
         /// <para> Creates or updates a policy for an Auto Scaling group. To update an existing policy, use the existing policy name and set the
         /// parameter(s) you want to change. Any existing parameter not changed in an update to an existing policy is not changed in this update
         /// request. </para>
         /// </summary>
         /// 
         /// <param name="putScalingPolicyRequest">Container for the necessary parameters to execute the PutScalingPolicy service method on
         ///           AmazonAutoScaling.</param>
         /// 
         /// <returns>The response from the PutScalingPolicy service method, as returned by AmazonAutoScaling.</returns>
         /// 
         /// <exception cref="LimitExceededException"/>
        public PutScalingPolicyResponse PutScalingPolicy(PutScalingPolicyRequest putScalingPolicyRequest) 
        {           
            IRequest<PutScalingPolicyRequest> request = new PutScalingPolicyRequestMarshaller().Marshall(putScalingPolicyRequest);
            PutScalingPolicyResponse response = Invoke<PutScalingPolicyRequest, PutScalingPolicyResponse> (request, this.signer, PutScalingPolicyResponseUnmarshaller.GetInstance());
            return response;
        }
    

         /// <summary>
         /// <para> Creates a notification action for an Auto Scaling group when a specified event takes place. </para>
         /// </summary>
         /// 
         /// <param name="putNotificationConfigurationRequest">Container for the necessary parameters to execute the PutNotificationConfiguration service
         ///           method on AmazonAutoScaling.</param>
         /// 
         /// <exception cref="LimitExceededException"/>
        public PutNotificationConfigurationResponse PutNotificationConfiguration(PutNotificationConfigurationRequest putNotificationConfigurationRequest) 
        {           
            IRequest<PutNotificationConfigurationRequest> request = new PutNotificationConfigurationRequestMarshaller().Marshall(putNotificationConfigurationRequest);
            PutNotificationConfigurationResponse response = Invoke<PutNotificationConfigurationRequest, PutNotificationConfigurationResponse> (request, this.signer, PutNotificationConfigurationResponseUnmarshaller.GetInstance());
            return response;
        }
    

         /// <summary>
         /// <para>Deletes a policy created by PutScalingPolicy </para>
         /// </summary>
         /// 
         /// <param name="deletePolicyRequest">Container for the necessary parameters to execute the DeletePolicy service method on
         ///           AmazonAutoScaling.</param>
         /// 
        public DeletePolicyResponse DeletePolicy(DeletePolicyRequest deletePolicyRequest) 
        {           
            IRequest<DeletePolicyRequest> request = new DeletePolicyRequestMarshaller().Marshall(deletePolicyRequest);
            DeletePolicyResponse response = Invoke<DeletePolicyRequest, DeletePolicyResponse> (request, this.signer, DeletePolicyResponseUnmarshaller.GetInstance());
            return response;
        }
    

         /// <summary>
         /// <para>Deletes notifications created by PutNotificationConfiguration.</para>
         /// </summary>
         /// 
         /// <param name="deleteNotificationConfigurationRequest">Container for the necessary parameters to execute the DeleteNotificationConfiguration
         ///           service method on AmazonAutoScaling.</param>
         /// 
        public DeleteNotificationConfigurationResponse DeleteNotificationConfiguration(DeleteNotificationConfigurationRequest deleteNotificationConfigurationRequest) 
        {           
            IRequest<DeleteNotificationConfigurationRequest> request = new DeleteNotificationConfigurationRequestMarshaller().Marshall(deleteNotificationConfigurationRequest);
            DeleteNotificationConfigurationResponse response = Invoke<DeleteNotificationConfigurationRequest, DeleteNotificationConfigurationResponse> (request, this.signer, DeleteNotificationConfigurationResponseUnmarshaller.GetInstance());
            return response;
        }
    

         /// <summary>
         /// <para>Deletes a scheduled action previously created using the PutScheduledUpdateGroupAction.</para>
         /// </summary>
         /// 
         /// <param name="deleteScheduledActionRequest">Container for the necessary parameters to execute the DeleteScheduledAction service method on
         ///           AmazonAutoScaling.</param>
         /// 
        public DeleteScheduledActionResponse DeleteScheduledAction(DeleteScheduledActionRequest deleteScheduledActionRequest) 
        {           
            IRequest<DeleteScheduledActionRequest> request = new DeleteScheduledActionRequestMarshaller().Marshall(deleteScheduledActionRequest);
            DeleteScheduledActionResponse response = Invoke<DeleteScheduledActionRequest, DeleteScheduledActionResponse> (request, this.signer, DeleteScheduledActionResponseUnmarshaller.GetInstance());
            return response;
        }
    

         /// <summary>
         /// <para> Sets the health status of an instance. </para>
         /// </summary>
         /// 
         /// <param name="setInstanceHealthRequest">Container for the necessary parameters to execute the SetInstanceHealth service method on
         ///           AmazonAutoScaling.</param>
         /// 
        public SetInstanceHealthResponse SetInstanceHealth(SetInstanceHealthRequest setInstanceHealthRequest) 
        {           
            IRequest<SetInstanceHealthRequest> request = new SetInstanceHealthRequestMarshaller().Marshall(setInstanceHealthRequest);
            SetInstanceHealthResponse response = Invoke<SetInstanceHealthRequest, SetInstanceHealthResponse> (request, this.signer, SetInstanceHealthResponseUnmarshaller.GetInstance());
            return response;
        }
    

         /// <summary>
         /// <para> Returns a list of all notification types that are supported by Auto Scaling. </para> <para> <i>What if the input is empty?</i>
         /// </para>
         /// </summary>
         /// 
         /// <param name="describeAutoScalingNotificationTypesRequest">Container for the necessary parameters to execute the
         ///           DescribeAutoScalingNotificationTypes service method on AmazonAutoScaling.</param>
         /// 
         /// <returns>The response from the DescribeAutoScalingNotificationTypes service method, as returned by AmazonAutoScaling.</returns>
         /// 
        public DescribeAutoScalingNotificationTypesResponse DescribeAutoScalingNotificationTypes(DescribeAutoScalingNotificationTypesRequest describeAutoScalingNotificationTypesRequest) 
        {           
            IRequest<DescribeAutoScalingNotificationTypesRequest> request = new DescribeAutoScalingNotificationTypesRequestMarshaller().Marshall(describeAutoScalingNotificationTypesRequest);
            DescribeAutoScalingNotificationTypesResponse response = Invoke<DescribeAutoScalingNotificationTypesRequest, DescribeAutoScalingNotificationTypesResponse> (request, this.signer, DescribeAutoScalingNotificationTypesResponseUnmarshaller.GetInstance());
            return response;
        }
    

         /// <summary>
         /// <para> Suspends Auto Scaling processes for an Auto Scaling group. To suspend specific process types, specify them by name with the
         /// <c>ScalingProcesses.member.N</c> parameter. To suspend all process types, omit the <c>ScalingProcesses.member.N</c> parameter. </para>
         /// <para><b>IMPORTANT:</b> Suspending either of the two primary process types, Launch or Terminate, can prevent other process types from
         /// functioning properly. For more information about processes and their dependencies, see ProcessType. </para> <para> To resume processes that
         /// have been suspended, use ResumeProcesses. </para>
         /// </summary>
         /// 
         /// <param name="suspendProcessesRequest">Container for the necessary parameters to execute the SuspendProcesses service method on
         ///           AmazonAutoScaling.</param>
         /// 
        public SuspendProcessesResponse SuspendProcesses(SuspendProcessesRequest suspendProcessesRequest) 
        {           
            IRequest<SuspendProcessesRequest> request = new SuspendProcessesRequestMarshaller().Marshall(suspendProcessesRequest);
            SuspendProcessesResponse response = Invoke<SuspendProcessesRequest, SuspendProcessesResponse> (request, this.signer, SuspendProcessesResponseUnmarshaller.GetInstance());
            return response;
        }
    

         /// <summary>
         /// <para> Returns a description of each Auto Scaling instance in the InstanceIds list. If a list is not provided, the service returns the full
         /// details of all instances up to a maximum of fifty. </para> <para> This action supports pagination by returning a token if there are more
         /// pages to retrieve. To get the next page, call this action again with the returned token as the NextToken parameter. </para>
         /// </summary>
         /// 
         /// <param name="describeAutoScalingInstancesRequest">Container for the necessary parameters to execute the DescribeAutoScalingInstances service
         ///           method on AmazonAutoScaling.</param>
         /// 
         /// <returns>The response from the DescribeAutoScalingInstances service method, as returned by AmazonAutoScaling.</returns>
         /// 
         /// <exception cref="InvalidNextTokenException"/>
        public DescribeAutoScalingInstancesResponse DescribeAutoScalingInstances(DescribeAutoScalingInstancesRequest describeAutoScalingInstancesRequest) 
        {           
            IRequest<DescribeAutoScalingInstancesRequest> request = new DescribeAutoScalingInstancesRequestMarshaller().Marshall(describeAutoScalingInstancesRequest);
            DescribeAutoScalingInstancesResponse response = Invoke<DescribeAutoScalingInstancesRequest, DescribeAutoScalingInstancesResponse> (request, this.signer, DescribeAutoScalingInstancesResponseUnmarshaller.GetInstance());
            return response;
        }
    

         /// <summary>
         /// <para> Creates a new launch configuration. Once created, the new launch configuration is available for immediate use. </para>
         /// <para><b>NOTE:</b> The launch configuration name used must be unique, within the scope of the client's AWS account, and the maximum limit of
         /// launch configurations must not yet have been met, or else the call will fail. </para>
         /// </summary>
         /// 
         /// <param name="createLaunchConfigurationRequest">Container for the necessary parameters to execute the CreateLaunchConfiguration service
         ///           method on AmazonAutoScaling.</param>
         /// 
         /// <exception cref="LimitExceededException"/>
         /// <exception cref="AlreadyExistsException"/>
        public CreateLaunchConfigurationResponse CreateLaunchConfiguration(CreateLaunchConfigurationRequest createLaunchConfigurationRequest) 
        {           
            IRequest<CreateLaunchConfigurationRequest> request = new CreateLaunchConfigurationRequestMarshaller().Marshall(createLaunchConfigurationRequest);
            CreateLaunchConfigurationResponse response = Invoke<CreateLaunchConfigurationRequest, CreateLaunchConfigurationResponse> (request, this.signer, CreateLaunchConfigurationResponseUnmarshaller.GetInstance());
            return response;
        }
    

         /// <summary>
         /// <para> Deletes the specified auto scaling group if the group has no instances and no scaling activities in progress. </para>
         /// <para><b>NOTE:</b> To remove all instances before calling DeleteAutoScalingGroup, you can call UpdateAutoScalingGroup to set the minimum and
         /// maximum size of the AutoScalingGroup to zero. </para>
         /// </summary>
         /// 
         /// <param name="deleteAutoScalingGroupRequest">Container for the necessary parameters to execute the DeleteAutoScalingGroup service method on
         ///           AmazonAutoScaling.</param>
         /// 
         /// <exception cref="ResourceInUseException"/>
         /// <exception cref="ScalingActivityInProgressException"/>
        public DeleteAutoScalingGroupResponse DeleteAutoScalingGroup(DeleteAutoScalingGroupRequest deleteAutoScalingGroupRequest) 
        {           
            IRequest<DeleteAutoScalingGroupRequest> request = new DeleteAutoScalingGroupRequestMarshaller().Marshall(deleteAutoScalingGroupRequest);
            DeleteAutoScalingGroupResponse response = Invoke<DeleteAutoScalingGroupRequest, DeleteAutoScalingGroupResponse> (request, this.signer, DeleteAutoScalingGroupResponseUnmarshaller.GetInstance());
            return response;
        }
    

         /// <summary>
         /// <para> Disables monitoring of group metrics for the Auto Scaling group specified in AutoScalingGroupName. You can specify the list of
         /// affected metrics with the Metrics parameter. </para>
         /// </summary>
         /// 
         /// <param name="disableMetricsCollectionRequest">Container for the necessary parameters to execute the DisableMetricsCollection service method
         ///           on AmazonAutoScaling.</param>
         /// 
        public DisableMetricsCollectionResponse DisableMetricsCollection(DisableMetricsCollectionRequest disableMetricsCollectionRequest) 
        {           
            IRequest<DisableMetricsCollectionRequest> request = new DisableMetricsCollectionRequestMarshaller().Marshall(disableMetricsCollectionRequest);
            DisableMetricsCollectionResponse response = Invoke<DisableMetricsCollectionRequest, DisableMetricsCollectionResponse> (request, this.signer, DisableMetricsCollectionResponseUnmarshaller.GetInstance());
            return response;
        }
    

         /// <summary>
         /// <para> Updates the configuration for the specified AutoScalingGroup. </para> <para><b>NOTE:</b> To update an Auto Scaling group with a
         /// launch configuration that has the InstanceMonitoring.enabled flag set to false, you must first ensure that collection of group metrics is
         /// disabled. Otherwise, calls to UpdateAutoScalingGroup will fail. If you have previously enabled group metrics collection, you can disable
         /// collection of all group metrics by calling DisableMetricsCollection. </para> <para> The new settings are registered upon the completion of
         /// this call. Any launch configuration settings take effect on any triggers after this call returns. Triggers that are currently in progress
         /// aren't affected. </para> <para><b>NOTE:</b> If the new values are specified for the MinSize or MaxSize parameters, then there will be an
         /// implicit call to SetDesiredCapacity to set the group to the new MaxSize. All optional parameters are left unchanged if not passed in the
         /// request. </para>
         /// </summary>
         /// 
         /// <param name="updateAutoScalingGroupRequest">Container for the necessary parameters to execute the UpdateAutoScalingGroup service method on
         ///           AmazonAutoScaling.</param>
         /// 
         /// <exception cref="ScalingActivityInProgressException"/>
        public UpdateAutoScalingGroupResponse UpdateAutoScalingGroup(UpdateAutoScalingGroupRequest updateAutoScalingGroupRequest) 
        {           
            IRequest<UpdateAutoScalingGroupRequest> request = new UpdateAutoScalingGroupRequestMarshaller().Marshall(updateAutoScalingGroupRequest);
            UpdateAutoScalingGroupResponse response = Invoke<UpdateAutoScalingGroupRequest, UpdateAutoScalingGroupResponse> (request, this.signer, UpdateAutoScalingGroupResponseUnmarshaller.GetInstance());
            return response;
        }
    

         /// <summary>
         /// <para> Returns a full description of the launch configurations given the specified names. </para> <para> If no names are specified, then the
         /// full details of all launch configurations are returned. </para>
         /// </summary>
         /// 
         /// <param name="describeLaunchConfigurationsRequest">Container for the necessary parameters to execute the DescribeLaunchConfigurations service
         ///           method on AmazonAutoScaling.</param>
         /// 
         /// <returns>The response from the DescribeLaunchConfigurations service method, as returned by AmazonAutoScaling.</returns>
         /// 
         /// <exception cref="InvalidNextTokenException"/>
        public DescribeLaunchConfigurationsResponse DescribeLaunchConfigurations(DescribeLaunchConfigurationsRequest describeLaunchConfigurationsRequest) 
        {           
            IRequest<DescribeLaunchConfigurationsRequest> request = new DescribeLaunchConfigurationsRequestMarshaller().Marshall(describeLaunchConfigurationsRequest);
            DescribeLaunchConfigurationsResponse response = Invoke<DescribeLaunchConfigurationsRequest, DescribeLaunchConfigurationsResponse> (request, this.signer, DescribeLaunchConfigurationsResponseUnmarshaller.GetInstance());
            return response;
        }
    

         /// <summary>
         /// <para> Returns policy adjustment types for use in the PutScalingPolicy action. </para>
         /// </summary>
         /// 
         /// <param name="describeAdjustmentTypesRequest">Container for the necessary parameters to execute the DescribeAdjustmentTypes service method on
         ///           AmazonAutoScaling.</param>
         /// 
         /// <returns>The response from the DescribeAdjustmentTypes service method, as returned by AmazonAutoScaling.</returns>
         /// 
        public DescribeAdjustmentTypesResponse DescribeAdjustmentTypes(DescribeAdjustmentTypesRequest describeAdjustmentTypesRequest) 
        {           
            IRequest<DescribeAdjustmentTypesRequest> request = new DescribeAdjustmentTypesRequestMarshaller().Marshall(describeAdjustmentTypesRequest);
            DescribeAdjustmentTypesResponse response = Invoke<DescribeAdjustmentTypesRequest, DescribeAdjustmentTypesResponse> (request, this.signer, DescribeAdjustmentTypesResponseUnmarshaller.GetInstance());
            return response;
        }
    

         /// <summary>
         /// <para> Lists all the actions scheduled for your Auto Scaling group that haven't been executed. To see a list of action already executed, see
         /// the activity record returned in DescribeScalingActivities. </para>
         /// </summary>
         /// 
         /// <param name="describeScheduledActionsRequest">Container for the necessary parameters to execute the DescribeScheduledActions service method
         ///           on AmazonAutoScaling.</param>
         /// 
         /// <returns>The response from the DescribeScheduledActions service method, as returned by AmazonAutoScaling.</returns>
         /// 
         /// <exception cref="InvalidNextTokenException"/>
        public DescribeScheduledActionsResponse DescribeScheduledActions(DescribeScheduledActionsRequest describeScheduledActionsRequest) 
        {           
            IRequest<DescribeScheduledActionsRequest> request = new DescribeScheduledActionsRequestMarshaller().Marshall(describeScheduledActionsRequest);
            DescribeScheduledActionsResponse response = Invoke<DescribeScheduledActionsRequest, DescribeScheduledActionsResponse> (request, this.signer, DescribeScheduledActionsResponseUnmarshaller.GetInstance());
            return response;
        }
    

         /// <summary>
         /// <para> Creates a scheduled scaling action for a Auto Scaling group. If you leave a parameter unspecified, the corresponding value remains
         /// unchanged in the affected Auto Scaling group. </para>
         /// </summary>
         /// 
         /// <param name="putScheduledUpdateGroupActionRequest">Container for the necessary parameters to execute the PutScheduledUpdateGroupAction
         ///           service method on AmazonAutoScaling.</param>
         /// 
         /// <exception cref="LimitExceededException"/>
         /// <exception cref="AlreadyExistsException"/>
        public PutScheduledUpdateGroupActionResponse PutScheduledUpdateGroupAction(PutScheduledUpdateGroupActionRequest putScheduledUpdateGroupActionRequest) 
        {           
            IRequest<PutScheduledUpdateGroupActionRequest> request = new PutScheduledUpdateGroupActionRequestMarshaller().Marshall(putScheduledUpdateGroupActionRequest);
            PutScheduledUpdateGroupActionResponse response = Invoke<PutScheduledUpdateGroupActionRequest, PutScheduledUpdateGroupActionResponse> (request, this.signer, PutScheduledUpdateGroupActionResponseUnmarshaller.GetInstance());
            return response;
        }
    

         /// <summary>
         /// <para> Returns a list of metrics and a corresponding list of granularities for each metric. </para>
         /// </summary>
         /// 
         /// <param name="describeMetricCollectionTypesRequest">Container for the necessary parameters to execute the DescribeMetricCollectionTypes
         ///           service method on AmazonAutoScaling.</param>
         /// 
         /// <returns>The response from the DescribeMetricCollectionTypes service method, as returned by AmazonAutoScaling.</returns>
         /// 
        public DescribeMetricCollectionTypesResponse DescribeMetricCollectionTypes(DescribeMetricCollectionTypesRequest describeMetricCollectionTypesRequest) 
        {           
            IRequest<DescribeMetricCollectionTypesRequest> request = new DescribeMetricCollectionTypesRequestMarshaller().Marshall(describeMetricCollectionTypesRequest);
            DescribeMetricCollectionTypesResponse response = Invoke<DescribeMetricCollectionTypesRequest, DescribeMetricCollectionTypesResponse> (request, this.signer, DescribeMetricCollectionTypesResponseUnmarshaller.GetInstance());
            return response;
        }
    

         /// <summary>
         /// <para> Adjusts the desired size of the AutoScalingGroup by initiating scaling activities. When reducing the size of the group, it is not
         /// possible to define which EC2 instances will be terminated. This applies to any auto-scaling decisions that might result in terminating
         /// instances. </para> <para> There are two common use cases for <c>SetDesiredCapacity</c> :
         /// one for users of the Auto Scaling triggering system, and another for developers who write their own triggering systems. Both use
         /// cases relate to the concept of cooldown. </para> <para> In the first case, if you use the Auto Scaling triggering system,
         /// <c>SetDesiredCapacity</c> changes the size of your Auto Scaling group without regard to the cooldown period. This could be useful, for
         /// example, if Auto Scaling did something unexpected for some reason. If your cooldown period is 10 minutes, Auto Scaling would normally reject
         /// requests to change the size of the group for that entire 10 minute period. The <c>SetDesiredCapacity</c> command allows you to circumvent
         /// this restriction and change the size of the group before the end of the cooldown period. </para> <para> In the second case, if you write
         /// your own triggering system, you can use <c>SetDesiredCapacity</c> to control the size of your Auto Scaling group. If you want the same
         /// cooldown functionality that Auto Scaling offers, you can configure <c>SetDesiredCapacity</c> to honor cooldown by setting the
         /// <c>HonorCooldown</c> parameter to <c>true</c> .
         /// </para>
         /// </summary>
         /// 
         /// <param name="setDesiredCapacityRequest">Container for the necessary parameters to execute the SetDesiredCapacity service method on
         ///           AmazonAutoScaling.</param>
         /// 
         /// <exception cref="ScalingActivityInProgressException"/>
        public SetDesiredCapacityResponse SetDesiredCapacity(SetDesiredCapacityRequest setDesiredCapacityRequest) 
        {           
            IRequest<SetDesiredCapacityRequest> request = new SetDesiredCapacityRequestMarshaller().Marshall(setDesiredCapacityRequest);
            SetDesiredCapacityResponse response = Invoke<SetDesiredCapacityRequest, SetDesiredCapacityResponse> (request, this.signer, SetDesiredCapacityResponseUnmarshaller.GetInstance());
            return response;
        }
    

         /// <summary>
         /// <para> Terminates the specified instance. Optionally, the desired group size can be adjusted. </para> <para><b>NOTE:</b> This call simply
         /// registers a termination request. The termination of the instance cannot happen immediately. </para>
         /// </summary>
         /// 
         /// <param name="terminateInstanceInAutoScalingGroupRequest">Container for the necessary parameters to execute the
         ///           TerminateInstanceInAutoScalingGroup service method on AmazonAutoScaling.</param>
         /// 
         /// <returns>The response from the TerminateInstanceInAutoScalingGroup service method, as returned by AmazonAutoScaling.</returns>
         /// 
         /// <exception cref="ScalingActivityInProgressException"/>
        public TerminateInstanceInAutoScalingGroupResponse TerminateInstanceInAutoScalingGroup(TerminateInstanceInAutoScalingGroupRequest terminateInstanceInAutoScalingGroupRequest) 
        {           
            IRequest<TerminateInstanceInAutoScalingGroupRequest> request = new TerminateInstanceInAutoScalingGroupRequestMarshaller().Marshall(terminateInstanceInAutoScalingGroupRequest);
            TerminateInstanceInAutoScalingGroupResponse response = Invoke<TerminateInstanceInAutoScalingGroupRequest, TerminateInstanceInAutoScalingGroupResponse> (request, this.signer, TerminateInstanceInAutoScalingGroupResponseUnmarshaller.GetInstance());
            return response;
        }
    
    }
}   
    
