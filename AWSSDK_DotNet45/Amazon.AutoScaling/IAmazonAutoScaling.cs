/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System.Threading;
using System.Threading.Tasks;

using Amazon.AutoScaling.Model;

namespace Amazon.AutoScaling
{
    /// <summary>
    /// Interface for accessing AmazonAutoScaling.
    /// 
    /// Auto Scaling <para> Auto Scaling is a web service designed to automatically launch or terminate Amazon Elastic Compute Cloud (Amazon EC2)
    /// instances based on user-defined policies, schedules, and health checks. This service is used in conjunction with Amazon CloudWatch and
    /// Elastic Load Balancing services. </para> <para>Auto Scaling provides APIs that you can call by submitting a Query Request. Query requests
    /// are HTTP or HTTPS requests that use the HTTP verbs GET or POST and a Query parameter named <i>Action</i> or <i>Operation</i> that specifies
    /// the API you are calling. Action is used throughout this documentation, although Operation is also supported for backward compatibility with
    /// other Amazon Web Services (AWS) Query APIs. </para> <para>Calling the API using a Query request is the most direct way to access the web
    /// service, but requires that your application handle low-level details such as generating the hash to sign the request and error handling. The
    /// benefit of calling the service using a Query request is that you are assured of having access to the complete functionality of the API. For
    /// information about signing a a query request, see <a href="http://docs.aws.amazon.com/AutoScaling/latest/DeveloperGuide/api_requests.html">Use Query Requests to Call Auto Scaling APIs</a> </para> <para> This guide provides detailed information about Auto Scaling actions, data
    /// types, parameters, and errors. For detailed information about Auto Scaling features and their associated API actions, go to the <a href="http://docs.aws.amazon.com/AutoScaling/latest/DeveloperGuide/">Auto Scaling Developer Guide</a> .
    /// </para> <para>This reference is based on the current WSDL, which is available at:</para> <para> <a href="http://autoscaling.amazonaws.com/doc/2011-01-01/AutoScaling.wsdl">http://autoscaling.amazonaws.com/doc/2011-01-01/AutoScaling.wsdl</a> </para> <para> <b>Endpoints</b> </para> <para>For information about
    /// this product's regions and endpoints, go to <a href="http://docs.aws.amazon.com/general/latest/gr/index.html?rande.html">Regions and
    /// Endpoints</a> in the Amazon Web Services General Reference. </para>
    /// </summary>
	public partial interface IAmazonAutoScaling : IDisposable
    {
 

        /// <summary>
        /// <para> Creates a new Auto Scaling group with the specified name and other attributes. When the creation request is completed, the Auto
        /// Scaling group is ready to be used in other calls. </para> <para><b>NOTE:</b> The Auto Scaling group name must be unique within the scope of
        /// your AWS account. </para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateAutoScalingGroup service method on
        /// AmazonAutoScaling.</param>
        /// 
        /// <exception cref="T:Amazon.AutoScaling.Model.LimitExceededException" />
        /// <exception cref="T:Amazon.AutoScaling.Model.AlreadyExistsException" />
		CreateAutoScalingGroupResponse CreateAutoScalingGroup(CreateAutoScalingGroupRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateAutoScalingGroup operation.
        /// <seealso cref="Amazon.AutoScaling.IAmazonAutoScaling.CreateAutoScalingGroup"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateAutoScalingGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<CreateAutoScalingGroupResponse> CreateAutoScalingGroupAsync(CreateAutoScalingGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para> Creates a new launch configuration. The launch configuration name must be unique within the scope of the client's AWS account. The
        /// maximum limit of launch configurations, which by default is 100, must not yet have been met; otherwise, the call will fail. When created,
        /// the new launch configuration is available for immediate use. </para> <para>You can create a launch configuration with Amazon EC2 security
        /// groups or with Amazon VPC security groups. However, you can't use Amazon EC2 security groups together with Amazon VPC security groups, or
        /// vice versa.</para> <para><b>NOTE:</b> At this time, Auto Scaling launch configurations don't support compressed (e.g. zipped) user data
        /// files. </para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateLaunchConfiguration service
        /// method on AmazonAutoScaling.</param>
        /// 
        /// <exception cref="T:Amazon.AutoScaling.Model.LimitExceededException" />
        /// <exception cref="T:Amazon.AutoScaling.Model.AlreadyExistsException" />
		CreateLaunchConfigurationResponse CreateLaunchConfiguration(CreateLaunchConfigurationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateLaunchConfiguration operation.
        /// <seealso cref="Amazon.AutoScaling.IAmazonAutoScaling.CreateLaunchConfiguration"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateLaunchConfiguration operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<CreateLaunchConfigurationResponse> CreateLaunchConfigurationAsync(CreateLaunchConfigurationRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para> Creates new tags or updates existing tags for an Auto Scaling group. </para> <para><b>NOTE:</b> A tag's definition is composed of a
        /// resource ID, resource type, key and value, and the propagate flag. Value and the propagate flag are optional parameters. See the Request
        /// Parameters for more information. </para> <para>For information on creating tags for your Auto Scaling group, see <a href="http://docs.aws.amazon.com/AutoScaling/latest/DeveloperGuide/ASTagging.html">Tag Your Auto Scaling Groups and Amazon EC2
        /// Instances</a> .</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateOrUpdateTags service method on
        /// AmazonAutoScaling.</param>
        /// 
        /// <exception cref="T:Amazon.AutoScaling.Model.LimitExceededException" />
        /// <exception cref="T:Amazon.AutoScaling.Model.AlreadyExistsException" />
		CreateOrUpdateTagsResponse CreateOrUpdateTags(CreateOrUpdateTagsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateOrUpdateTags operation.
        /// <seealso cref="Amazon.AutoScaling.IAmazonAutoScaling.CreateOrUpdateTags"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateOrUpdateTags operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<CreateOrUpdateTagsResponse> CreateOrUpdateTagsAsync(CreateOrUpdateTagsRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para> Deletes the specified Auto Scaling group if the group has no instances and no scaling activities in progress. </para>
        /// <para><b>NOTE:</b> To remove all instances before calling DeleteAutoScalingGroup, you can call UpdateAutoScalingGroup to set the minimum and
        /// maximum size of the AutoScalingGroup to zero. </para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteAutoScalingGroup service method on
        /// AmazonAutoScaling.</param>
        /// 
        /// <exception cref="T:Amazon.AutoScaling.Model.ResourceInUseException" />
        /// <exception cref="T:Amazon.AutoScaling.Model.ScalingActivityInProgressException" />
		DeleteAutoScalingGroupResponse DeleteAutoScalingGroup(DeleteAutoScalingGroupRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteAutoScalingGroup operation.
        /// <seealso cref="Amazon.AutoScaling.IAmazonAutoScaling.DeleteAutoScalingGroup"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteAutoScalingGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<DeleteAutoScalingGroupResponse> DeleteAutoScalingGroupAsync(DeleteAutoScalingGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para> Deletes the specified LaunchConfiguration. </para> <para> The specified launch configuration must not be attached to an Auto Scaling
        /// group. When this call completes, the launch configuration is no longer available for use. </para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteLaunchConfiguration service
        /// method on AmazonAutoScaling.</param>
        /// 
        /// <exception cref="T:Amazon.AutoScaling.Model.ResourceInUseException" />
		DeleteLaunchConfigurationResponse DeleteLaunchConfiguration(DeleteLaunchConfigurationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteLaunchConfiguration operation.
        /// <seealso cref="Amazon.AutoScaling.IAmazonAutoScaling.DeleteLaunchConfiguration"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteLaunchConfiguration operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<DeleteLaunchConfigurationResponse> DeleteLaunchConfigurationAsync(DeleteLaunchConfigurationRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para>Deletes notifications created by PutNotificationConfiguration.</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteNotificationConfiguration
        /// service method on AmazonAutoScaling.</param>
		DeleteNotificationConfigurationResponse DeleteNotificationConfiguration(DeleteNotificationConfigurationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteNotificationConfiguration operation.
        /// <seealso cref="Amazon.AutoScaling.IAmazonAutoScaling.DeleteNotificationConfiguration"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteNotificationConfiguration operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<DeleteNotificationConfigurationResponse> DeleteNotificationConfigurationAsync(DeleteNotificationConfigurationRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para>Deletes a policy created by PutScalingPolicy.</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeletePolicy service method on
        /// AmazonAutoScaling.</param>
		DeletePolicyResponse DeletePolicy(DeletePolicyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeletePolicy operation.
        /// <seealso cref="Amazon.AutoScaling.IAmazonAutoScaling.DeletePolicy"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeletePolicy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<DeletePolicyResponse> DeletePolicyAsync(DeletePolicyRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para>Deletes a scheduled action previously created using the PutScheduledUpdateGroupAction.</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteScheduledAction service method on
        /// AmazonAutoScaling.</param>
		DeleteScheduledActionResponse DeleteScheduledAction(DeleteScheduledActionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteScheduledAction operation.
        /// <seealso cref="Amazon.AutoScaling.IAmazonAutoScaling.DeleteScheduledAction"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteScheduledAction operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<DeleteScheduledActionResponse> DeleteScheduledActionAsync(DeleteScheduledActionRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para>Removes the specified tags or a set of tags from a set of resources.</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteTags service method on
        /// AmazonAutoScaling.</param>
		DeleteTagsResponse DeleteTags(DeleteTagsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteTags operation.
        /// <seealso cref="Amazon.AutoScaling.IAmazonAutoScaling.DeleteTags"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteTags operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<DeleteTagsResponse> DeleteTagsAsync(DeleteTagsRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para> Returns policy adjustment types for use in the PutScalingPolicy action. </para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAdjustmentTypes service method on
        /// AmazonAutoScaling.</param>
        /// 
        /// <returns>The response from the DescribeAdjustmentTypes service method, as returned by AmazonAutoScaling.</returns>
		DescribeAdjustmentTypesResponse DescribeAdjustmentTypes(DescribeAdjustmentTypesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeAdjustmentTypes operation.
        /// <seealso cref="Amazon.AutoScaling.IAmazonAutoScaling.DescribeAdjustmentTypes"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAdjustmentTypes operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<DescribeAdjustmentTypesResponse> DescribeAdjustmentTypesAsync(DescribeAdjustmentTypesRequest request, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para> Returns policy adjustment types for use in the PutScalingPolicy action. </para>
        /// </summary>
        /// 
        /// 
        /// <returns>The response from the DescribeAdjustmentTypes service method, as returned by AmazonAutoScaling.</returns>
		DescribeAdjustmentTypesResponse DescribeAdjustmentTypes();
 

        /// <summary>
        /// <para> Returns a full description of each Auto Scaling group in the given list. This includes all Amazon EC2 instances that are members of
        /// the group. If a list of names is not provided, the service returns the full details of all Auto Scaling groups. </para> <para> This action
        /// supports pagination by returning a token if there are more pages to retrieve. To get the next page, call this action again with the returned
        /// token as the <c>NextToken</c> parameter. </para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAutoScalingGroups service
        /// method on AmazonAutoScaling.</param>
        /// 
        /// <returns>The response from the DescribeAutoScalingGroups service method, as returned by AmazonAutoScaling.</returns>
        /// 
        /// <exception cref="T:Amazon.AutoScaling.Model.InvalidNextTokenException" />
		DescribeAutoScalingGroupsResponse DescribeAutoScalingGroups(DescribeAutoScalingGroupsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeAutoScalingGroups operation.
        /// <seealso cref="Amazon.AutoScaling.IAmazonAutoScaling.DescribeAutoScalingGroups"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAutoScalingGroups operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<DescribeAutoScalingGroupsResponse> DescribeAutoScalingGroupsAsync(DescribeAutoScalingGroupsRequest request, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para> Returns a full description of each Auto Scaling group in the given list. This includes all Amazon EC2 instances that are members of
        /// the group. If a list of names is not provided, the service returns the full details of all Auto Scaling groups. </para> <para> This action
        /// supports pagination by returning a token if there are more pages to retrieve. To get the next page, call this action again with the returned
        /// token as the <c>NextToken</c> parameter. </para>
        /// </summary>
        /// 
        /// 
        /// <returns>The response from the DescribeAutoScalingGroups service method, as returned by AmazonAutoScaling.</returns>
        /// 
        /// <exception cref="T:Amazon.AutoScaling.Model.InvalidNextTokenException" />
		DescribeAutoScalingGroupsResponse DescribeAutoScalingGroups();
 

        /// <summary>
        /// <para> Returns a description of each Auto Scaling instance in the <c>InstanceIds</c> list. If a list is not provided, the service returns
        /// the full details of all instances up to a maximum of 50. By default, the service returns a list of 20 items. </para> <para> This action
        /// supports pagination by returning a token if there are more pages to retrieve. To get the next page, call this action again with the returned
        /// token as the <c>NextToken</c> parameter. </para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAutoScalingInstances service
        /// method on AmazonAutoScaling.</param>
        /// 
        /// <returns>The response from the DescribeAutoScalingInstances service method, as returned by AmazonAutoScaling.</returns>
        /// 
        /// <exception cref="T:Amazon.AutoScaling.Model.InvalidNextTokenException" />
		DescribeAutoScalingInstancesResponse DescribeAutoScalingInstances(DescribeAutoScalingInstancesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeAutoScalingInstances operation.
        /// <seealso cref="Amazon.AutoScaling.IAmazonAutoScaling.DescribeAutoScalingInstances"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAutoScalingInstances operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<DescribeAutoScalingInstancesResponse> DescribeAutoScalingInstancesAsync(DescribeAutoScalingInstancesRequest request, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para> Returns a description of each Auto Scaling instance in the <c>InstanceIds</c> list. If a list is not provided, the service returns
        /// the full details of all instances up to a maximum of 50. By default, the service returns a list of 20 items. </para> <para> This action
        /// supports pagination by returning a token if there are more pages to retrieve. To get the next page, call this action again with the returned
        /// token as the <c>NextToken</c> parameter. </para>
        /// </summary>
        /// 
        /// 
        /// <returns>The response from the DescribeAutoScalingInstances service method, as returned by AmazonAutoScaling.</returns>
        /// 
        /// <exception cref="T:Amazon.AutoScaling.Model.InvalidNextTokenException" />
		DescribeAutoScalingInstancesResponse DescribeAutoScalingInstances();
 

        /// <summary>
        /// <para> Returns a list of all notification types that are supported by Auto Scaling. </para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the
        /// DescribeAutoScalingNotificationTypes service method on AmazonAutoScaling.</param>
        /// 
        /// <returns>The response from the DescribeAutoScalingNotificationTypes service method, as returned by AmazonAutoScaling.</returns>
		DescribeAutoScalingNotificationTypesResponse DescribeAutoScalingNotificationTypes(DescribeAutoScalingNotificationTypesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeAutoScalingNotificationTypes operation.
        /// <seealso cref="Amazon.AutoScaling.IAmazonAutoScaling.DescribeAutoScalingNotificationTypes"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAutoScalingNotificationTypes operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<DescribeAutoScalingNotificationTypesResponse> DescribeAutoScalingNotificationTypesAsync(DescribeAutoScalingNotificationTypesRequest request, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para> Returns a list of all notification types that are supported by Auto Scaling. </para>
        /// </summary>
        /// 
        /// 
        /// <returns>The response from the DescribeAutoScalingNotificationTypes service method, as returned by AmazonAutoScaling.</returns>
		DescribeAutoScalingNotificationTypesResponse DescribeAutoScalingNotificationTypes();
 

        /// <summary>
        /// <para> Returns a full description of the launch configurations, or the specified launch configurations, if they exist. </para> <para> If no
        /// name is specified, then the full details of all launch configurations are returned. </para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeLaunchConfigurations service
        /// method on AmazonAutoScaling.</param>
        /// 
        /// <returns>The response from the DescribeLaunchConfigurations service method, as returned by AmazonAutoScaling.</returns>
        /// 
        /// <exception cref="T:Amazon.AutoScaling.Model.InvalidNextTokenException" />
		DescribeLaunchConfigurationsResponse DescribeLaunchConfigurations(DescribeLaunchConfigurationsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeLaunchConfigurations operation.
        /// <seealso cref="Amazon.AutoScaling.IAmazonAutoScaling.DescribeLaunchConfigurations"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeLaunchConfigurations operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<DescribeLaunchConfigurationsResponse> DescribeLaunchConfigurationsAsync(DescribeLaunchConfigurationsRequest request, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para> Returns a full description of the launch configurations, or the specified launch configurations, if they exist. </para> <para> If no
        /// name is specified, then the full details of all launch configurations are returned. </para>
        /// </summary>
        /// 
        /// 
        /// <returns>The response from the DescribeLaunchConfigurations service method, as returned by AmazonAutoScaling.</returns>
        /// 
        /// <exception cref="T:Amazon.AutoScaling.Model.InvalidNextTokenException" />
		DescribeLaunchConfigurationsResponse DescribeLaunchConfigurations();
 

        /// <summary>
        /// <para> Returns a list of metrics and a corresponding list of granularities for each metric. </para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeMetricCollectionTypes
        /// service method on AmazonAutoScaling.</param>
        /// 
        /// <returns>The response from the DescribeMetricCollectionTypes service method, as returned by AmazonAutoScaling.</returns>
		DescribeMetricCollectionTypesResponse DescribeMetricCollectionTypes(DescribeMetricCollectionTypesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeMetricCollectionTypes operation.
        /// <seealso cref="Amazon.AutoScaling.IAmazonAutoScaling.DescribeMetricCollectionTypes"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeMetricCollectionTypes operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<DescribeMetricCollectionTypesResponse> DescribeMetricCollectionTypesAsync(DescribeMetricCollectionTypesRequest request, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para> Returns a list of metrics and a corresponding list of granularities for each metric. </para>
        /// </summary>
        /// 
        /// 
        /// <returns>The response from the DescribeMetricCollectionTypes service method, as returned by AmazonAutoScaling.</returns>
		DescribeMetricCollectionTypesResponse DescribeMetricCollectionTypes();
 

        /// <summary>
        /// <para> Returns a list of notification actions associated with Auto Scaling groups for specified events. </para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the
        /// DescribeNotificationConfigurations service method on AmazonAutoScaling.</param>
        /// 
        /// <returns>The response from the DescribeNotificationConfigurations service method, as returned by AmazonAutoScaling.</returns>
        /// 
        /// <exception cref="T:Amazon.AutoScaling.Model.InvalidNextTokenException" />
		DescribeNotificationConfigurationsResponse DescribeNotificationConfigurations(DescribeNotificationConfigurationsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeNotificationConfigurations operation.
        /// <seealso cref="Amazon.AutoScaling.IAmazonAutoScaling.DescribeNotificationConfigurations"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeNotificationConfigurations operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<DescribeNotificationConfigurationsResponse> DescribeNotificationConfigurationsAsync(DescribeNotificationConfigurationsRequest request, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para> Returns a list of notification actions associated with Auto Scaling groups for specified events. </para>
        /// </summary>
        /// 
        /// 
        /// <returns>The response from the DescribeNotificationConfigurations service method, as returned by AmazonAutoScaling.</returns>
        /// 
        /// <exception cref="T:Amazon.AutoScaling.Model.InvalidNextTokenException" />
		DescribeNotificationConfigurationsResponse DescribeNotificationConfigurations();
 

        /// <summary>
        /// <para> Returns descriptions of what each policy does. This action supports pagination. If the response includes a token, there are more
        /// records available. To get the additional records, repeat the request with the response token as the <c>NextToken</c> parameter. </para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribePolicies service method on
        /// AmazonAutoScaling.</param>
        /// 
        /// <returns>The response from the DescribePolicies service method, as returned by AmazonAutoScaling.</returns>
        /// 
        /// <exception cref="T:Amazon.AutoScaling.Model.InvalidNextTokenException" />
		DescribePoliciesResponse DescribePolicies(DescribePoliciesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribePolicies operation.
        /// <seealso cref="Amazon.AutoScaling.IAmazonAutoScaling.DescribePolicies"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribePolicies operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<DescribePoliciesResponse> DescribePoliciesAsync(DescribePoliciesRequest request, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para> Returns descriptions of what each policy does. This action supports pagination. If the response includes a token, there are more
        /// records available. To get the additional records, repeat the request with the response token as the <c>NextToken</c> parameter. </para>
        /// </summary>
        /// 
        /// 
        /// <returns>The response from the DescribePolicies service method, as returned by AmazonAutoScaling.</returns>
        /// 
        /// <exception cref="T:Amazon.AutoScaling.Model.InvalidNextTokenException" />
		DescribePoliciesResponse DescribePolicies();
 

        /// <summary>
        /// <para> Returns the scaling activities for the specified Auto Scaling group. </para> <para> If the specified <c>ActivityIds</c> list is
        /// empty, all the activities from the past six weeks are returned. Activities are sorted by completion time. Activities still in progress
        /// appear first on the list. </para> <para> This action supports pagination. If the response includes a token, there are more records
        /// available. To get the additional records, repeat the request with the response token as the <c>NextToken</c> parameter. </para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeScalingActivities service
        /// method on AmazonAutoScaling.</param>
        /// 
        /// <returns>The response from the DescribeScalingActivities service method, as returned by AmazonAutoScaling.</returns>
        /// 
        /// <exception cref="T:Amazon.AutoScaling.Model.InvalidNextTokenException" />
		DescribeScalingActivitiesResponse DescribeScalingActivities(DescribeScalingActivitiesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeScalingActivities operation.
        /// <seealso cref="Amazon.AutoScaling.IAmazonAutoScaling.DescribeScalingActivities"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeScalingActivities operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<DescribeScalingActivitiesResponse> DescribeScalingActivitiesAsync(DescribeScalingActivitiesRequest request, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para> Returns the scaling activities for the specified Auto Scaling group. </para> <para> If the specified <c>ActivityIds</c> list is
        /// empty, all the activities from the past six weeks are returned. Activities are sorted by completion time. Activities still in progress
        /// appear first on the list. </para> <para> This action supports pagination. If the response includes a token, there are more records
        /// available. To get the additional records, repeat the request with the response token as the <c>NextToken</c> parameter. </para>
        /// </summary>
        /// 
        /// 
        /// <returns>The response from the DescribeScalingActivities service method, as returned by AmazonAutoScaling.</returns>
        /// 
        /// <exception cref="T:Amazon.AutoScaling.Model.InvalidNextTokenException" />
		DescribeScalingActivitiesResponse DescribeScalingActivities();
 

        /// <summary>
        /// <para>Returns scaling process types for use in the ResumeProcesses and SuspendProcesses actions.</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeScalingProcessTypes service
        /// method on AmazonAutoScaling.</param>
        /// 
        /// <returns>The response from the DescribeScalingProcessTypes service method, as returned by AmazonAutoScaling.</returns>
		DescribeScalingProcessTypesResponse DescribeScalingProcessTypes(DescribeScalingProcessTypesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeScalingProcessTypes operation.
        /// <seealso cref="Amazon.AutoScaling.IAmazonAutoScaling.DescribeScalingProcessTypes"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeScalingProcessTypes operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<DescribeScalingProcessTypesResponse> DescribeScalingProcessTypesAsync(DescribeScalingProcessTypesRequest request, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para>Returns scaling process types for use in the ResumeProcesses and SuspendProcesses actions.</para>
        /// </summary>
        /// 
        /// 
        /// <returns>The response from the DescribeScalingProcessTypes service method, as returned by AmazonAutoScaling.</returns>
		DescribeScalingProcessTypesResponse DescribeScalingProcessTypes();
 

        /// <summary>
        /// <para> Lists all the actions scheduled for your Auto Scaling group that haven't been executed. To see a list of actions already executed,
        /// see the activity record returned in DescribeScalingActivities. </para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeScheduledActions service method
        /// on AmazonAutoScaling.</param>
        /// 
        /// <returns>The response from the DescribeScheduledActions service method, as returned by AmazonAutoScaling.</returns>
        /// 
        /// <exception cref="T:Amazon.AutoScaling.Model.InvalidNextTokenException" />
		DescribeScheduledActionsResponse DescribeScheduledActions(DescribeScheduledActionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeScheduledActions operation.
        /// <seealso cref="Amazon.AutoScaling.IAmazonAutoScaling.DescribeScheduledActions"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeScheduledActions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<DescribeScheduledActionsResponse> DescribeScheduledActionsAsync(DescribeScheduledActionsRequest request, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para> Lists all the actions scheduled for your Auto Scaling group that haven't been executed. To see a list of actions already executed,
        /// see the activity record returned in DescribeScalingActivities. </para>
        /// </summary>
        /// 
        /// 
        /// <returns>The response from the DescribeScheduledActions service method, as returned by AmazonAutoScaling.</returns>
        /// 
        /// <exception cref="T:Amazon.AutoScaling.Model.InvalidNextTokenException" />
		DescribeScheduledActionsResponse DescribeScheduledActions();
 

        /// <summary>
        /// <para> Lists the Auto Scaling group tags. </para> <para> You can use filters to limit results when describing tags. For example, you can
        /// query for tags of a particular Auto Scaling group. You can specify multiple values for a filter. A tag must match at least one of the
        /// specified values for it to be included in the results. </para> <para> You can also specify multiple filters. The result includes information
        /// for a particular tag only if it matches all your filters. If there's no match, no special message is returned. </para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeTags service method on
        /// AmazonAutoScaling.</param>
        /// 
        /// <returns>The response from the DescribeTags service method, as returned by AmazonAutoScaling.</returns>
        /// 
        /// <exception cref="T:Amazon.AutoScaling.Model.InvalidNextTokenException" />
		DescribeTagsResponse DescribeTags(DescribeTagsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeTags operation.
        /// <seealso cref="Amazon.AutoScaling.IAmazonAutoScaling.DescribeTags"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeTags operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<DescribeTagsResponse> DescribeTagsAsync(DescribeTagsRequest request, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para> Lists the Auto Scaling group tags. </para> <para> You can use filters to limit results when describing tags. For example, you can
        /// query for tags of a particular Auto Scaling group. You can specify multiple values for a filter. A tag must match at least one of the
        /// specified values for it to be included in the results. </para> <para> You can also specify multiple filters. The result includes information
        /// for a particular tag only if it matches all your filters. If there's no match, no special message is returned. </para>
        /// </summary>
        /// 
        /// 
        /// <returns>The response from the DescribeTags service method, as returned by AmazonAutoScaling.</returns>
        /// 
        /// <exception cref="T:Amazon.AutoScaling.Model.InvalidNextTokenException" />
		DescribeTagsResponse DescribeTags();
 

        /// <summary>
        /// <para> Returns a list of all termination policies supported by Auto Scaling. </para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeTerminationPolicyTypes
        /// service method on AmazonAutoScaling.</param>
        /// 
        /// <returns>The response from the DescribeTerminationPolicyTypes service method, as returned by AmazonAutoScaling.</returns>
		DescribeTerminationPolicyTypesResponse DescribeTerminationPolicyTypes(DescribeTerminationPolicyTypesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeTerminationPolicyTypes operation.
        /// <seealso cref="Amazon.AutoScaling.IAmazonAutoScaling.DescribeTerminationPolicyTypes"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeTerminationPolicyTypes operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<DescribeTerminationPolicyTypesResponse> DescribeTerminationPolicyTypesAsync(DescribeTerminationPolicyTypesRequest request, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para> Returns a list of all termination policies supported by Auto Scaling. </para>
        /// </summary>
        /// 
        /// 
        /// <returns>The response from the DescribeTerminationPolicyTypes service method, as returned by AmazonAutoScaling.</returns>
		DescribeTerminationPolicyTypesResponse DescribeTerminationPolicyTypes();
 

        /// <summary>
        /// <para> Disables monitoring of group metrics for the Auto Scaling group specified in <c>AutoScalingGroupName</c> .
        /// You can specify the list of affected metrics with the <c>Metrics</c> parameter. </para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisableMetricsCollection service method
        /// on AmazonAutoScaling.</param>
		DisableMetricsCollectionResponse DisableMetricsCollection(DisableMetricsCollectionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DisableMetricsCollection operation.
        /// <seealso cref="Amazon.AutoScaling.IAmazonAutoScaling.DisableMetricsCollection"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisableMetricsCollection operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<DisableMetricsCollectionResponse> DisableMetricsCollectionAsync(DisableMetricsCollectionRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para> Enables monitoring of group metrics for the Auto Scaling group specified in <c>AutoScalingGroupName</c> .
        /// You can specify the list of enabled metrics with the <c>Metrics</c> parameter. </para> <para> Auto Scaling metrics collection
        /// can be turned on only if the <c>InstanceMonitoring</c> flag, in the Auto Scaling group's launch configuration, is set to <c>True</c> .
        /// </para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the EnableMetricsCollection service method on
        /// AmazonAutoScaling.</param>
		EnableMetricsCollectionResponse EnableMetricsCollection(EnableMetricsCollectionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the EnableMetricsCollection operation.
        /// <seealso cref="Amazon.AutoScaling.IAmazonAutoScaling.EnableMetricsCollection"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the EnableMetricsCollection operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<EnableMetricsCollectionResponse> EnableMetricsCollectionAsync(EnableMetricsCollectionRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para>Executes the specified policy. </para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ExecutePolicy service method on
        /// AmazonAutoScaling.</param>
        /// 
        /// <exception cref="T:Amazon.AutoScaling.Model.ScalingActivityInProgressException" />
		ExecutePolicyResponse ExecutePolicy(ExecutePolicyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ExecutePolicy operation.
        /// <seealso cref="Amazon.AutoScaling.IAmazonAutoScaling.ExecutePolicy"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ExecutePolicy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<ExecutePolicyResponse> ExecutePolicyAsync(ExecutePolicyRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para> Configures an Auto Scaling group to send notifications when specified events take place. Subscribers to this topic can have messages
        /// for events delivered to an endpoint such as a web server or email address. </para> <para>For more information see <a href="http://docs.aws.amazon.com/AutoScaling/latest/DeveloperGuide/ASGettingNotifications.html">Get Email Notifications When Your Auto
        /// Scaling Group Changes</a> </para> <para>A new <c>PutNotificationConfiguration</c> overwrites an existing configuration. </para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutNotificationConfiguration service
        /// method on AmazonAutoScaling.</param>
        /// 
        /// <exception cref="T:Amazon.AutoScaling.Model.LimitExceededException" />
		PutNotificationConfigurationResponse PutNotificationConfiguration(PutNotificationConfigurationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the PutNotificationConfiguration operation.
        /// <seealso cref="Amazon.AutoScaling.IAmazonAutoScaling.PutNotificationConfiguration"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutNotificationConfiguration operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<PutNotificationConfigurationResponse> PutNotificationConfigurationAsync(PutNotificationConfigurationRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para> Creates or updates a policy for an Auto Scaling group. To update an existing policy, use the existing policy name and set the
        /// parameter(s) you want to change. Any existing parameter not changed in an update to an existing policy is not changed in this update
        /// request. </para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutScalingPolicy service method on
        /// AmazonAutoScaling.</param>
        /// 
        /// <returns>The response from the PutScalingPolicy service method, as returned by AmazonAutoScaling.</returns>
        /// 
        /// <exception cref="T:Amazon.AutoScaling.Model.LimitExceededException" />
		PutScalingPolicyResponse PutScalingPolicy(PutScalingPolicyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the PutScalingPolicy operation.
        /// <seealso cref="Amazon.AutoScaling.IAmazonAutoScaling.PutScalingPolicy"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutScalingPolicy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<PutScalingPolicyResponse> PutScalingPolicyAsync(PutScalingPolicyRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para> Creates or updates a scheduled scaling action for an Auto Scaling group. When updating a scheduled scaling action, if you leave a
        /// parameter unspecified, the corresponding value remains unchanged in the affected Auto Scaling group. </para> <para>For information on
        /// creating or updating a scheduled action for your Auto Scaling group, see <a href="http://docs.aws.amazon.com/AutoScaling/latest/DeveloperGuide/schedule_time.html">Scale Based on a Schedule</a> .</para>
        /// <para><b>NOTE:</b> Auto Scaling supports the date and time expressed in "YYYY-MM-DDThh:mm:ssZ" format in UTC/GMT only. </para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutScheduledUpdateGroupAction
        /// service method on AmazonAutoScaling.</param>
        /// 
        /// <exception cref="T:Amazon.AutoScaling.Model.LimitExceededException" />
        /// <exception cref="T:Amazon.AutoScaling.Model.AlreadyExistsException" />
		PutScheduledUpdateGroupActionResponse PutScheduledUpdateGroupAction(PutScheduledUpdateGroupActionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the PutScheduledUpdateGroupAction operation.
        /// <seealso cref="Amazon.AutoScaling.IAmazonAutoScaling.PutScheduledUpdateGroupAction"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutScheduledUpdateGroupAction operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<PutScheduledUpdateGroupActionResponse> PutScheduledUpdateGroupActionAsync(PutScheduledUpdateGroupActionRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para> Resumes all suspended Auto Scaling processes for an Auto Scaling group. For information on suspending and resuming Auto Scaling
        /// process, see <a href="http://docs.aws.amazon.com/AutoScaling/latest/DeveloperGuide/US_SuspendResume.html">Suspend and Resume Auto Scaling
        /// Process</a> .
        /// </para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ResumeProcesses service method on
        /// AmazonAutoScaling.</param>
		ResumeProcessesResponse ResumeProcesses(ResumeProcessesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ResumeProcesses operation.
        /// <seealso cref="Amazon.AutoScaling.IAmazonAutoScaling.ResumeProcesses"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ResumeProcesses operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<ResumeProcessesResponse> ResumeProcessesAsync(ResumeProcessesRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para> Sets the desired size of the specified AutoScalingGroup. </para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SetDesiredCapacity service method on
        /// AmazonAutoScaling.</param>
        /// 
        /// <exception cref="T:Amazon.AutoScaling.Model.ScalingActivityInProgressException" />
		SetDesiredCapacityResponse SetDesiredCapacity(SetDesiredCapacityRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the SetDesiredCapacity operation.
        /// <seealso cref="Amazon.AutoScaling.IAmazonAutoScaling.SetDesiredCapacity"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SetDesiredCapacity operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<SetDesiredCapacityResponse> SetDesiredCapacityAsync(SetDesiredCapacityRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para> Sets the health status of a specified instance that belongs to any of your Auto Scaling groups. </para> <para>For more information,
        /// see <a href="http://docs.aws.amazon.com/AutoScaling/latest/DeveloperGuide/as-configure-healthcheck.html">Configure Health Checks for Your
        /// Auto Scaling group</a> .</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SetInstanceHealth service method on
        /// AmazonAutoScaling.</param>
		SetInstanceHealthResponse SetInstanceHealth(SetInstanceHealthRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the SetInstanceHealth operation.
        /// <seealso cref="Amazon.AutoScaling.IAmazonAutoScaling.SetInstanceHealth"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SetInstanceHealth operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<SetInstanceHealthResponse> SetInstanceHealthAsync(SetInstanceHealthRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para> Suspends Auto Scaling processes for an Auto Scaling group. To suspend specific process types, specify them by name with the
        /// <c>ScalingProcesses.member.N</c> parameter. To suspend all process types, omit the <c>ScalingProcesses.member.N</c> parameter. </para>
        /// <para><b>IMPORTANT:</b> Suspending either of the two primary process types, Launch or Terminate, can prevent other process types from
        /// functioning properly. </para> <para> To resume processes that have been suspended, use ResumeProcesses For more information on suspending
        /// and resuming Auto Scaling process, see <a href="http://docs.aws.amazon.com/AutoScaling/latest/DeveloperGuide/US_SuspendResume.html">Suspend
        /// and Resume Auto Scaling Process</a> .
        /// </para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SuspendProcesses service method on
        /// AmazonAutoScaling.</param>
		SuspendProcessesResponse SuspendProcesses(SuspendProcessesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the SuspendProcesses operation.
        /// <seealso cref="Amazon.AutoScaling.IAmazonAutoScaling.SuspendProcesses"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SuspendProcesses operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<SuspendProcessesResponse> SuspendProcessesAsync(SuspendProcessesRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para> Terminates the specified instance. Optionally, the desired group size can be adjusted. </para> <para><b>NOTE:</b> This call simply
        /// registers a termination request. The termination of the instance cannot happen immediately. </para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the
        /// TerminateInstanceInAutoScalingGroup service method on AmazonAutoScaling.</param>
        /// 
        /// <returns>The response from the TerminateInstanceInAutoScalingGroup service method, as returned by AmazonAutoScaling.</returns>
        /// 
        /// <exception cref="T:Amazon.AutoScaling.Model.ScalingActivityInProgressException" />
		TerminateInstanceInAutoScalingGroupResponse TerminateInstanceInAutoScalingGroup(TerminateInstanceInAutoScalingGroupRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the TerminateInstanceInAutoScalingGroup operation.
        /// <seealso cref="Amazon.AutoScaling.IAmazonAutoScaling.TerminateInstanceInAutoScalingGroup"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TerminateInstanceInAutoScalingGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<TerminateInstanceInAutoScalingGroupResponse> TerminateInstanceInAutoScalingGroupAsync(TerminateInstanceInAutoScalingGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para> Updates the configuration for the specified AutoScalingGroup. </para> <para><b>NOTE:</b> To update an Auto Scaling group with a
        /// launch configuration that has the InstanceMonitoring flag set to False, you must first ensure that collection of group metrics is disabled.
        /// Otherwise, calls to UpdateAutoScalingGroup will fail. If you have previously enabled group metrics collection, you can disable collection of
        /// all group metrics by calling DisableMetricsCollection. </para> <para> The new settings are registered upon the completion of this call. Any
        /// launch configuration settings take effect on any triggers after this call returns. Scaling activities that are currently in progress aren't
        /// affected. </para> <para><b>NOTE:</b> If a new value is specified for MinSize without specifying the value for DesiredCapacity, and if the
        /// new MinSize is larger than the current size of the Auto Scaling Group, there will be an implicit call to SetDesiredCapacity to set the group
        /// to the new MinSize. If a new value is specified for MaxSize without specifying the value for DesiredCapacity, and the new MaxSize is smaller
        /// than the current size of the Auto Scaling Group, there will be an implicit call to SetDesiredCapacity to set the group to the new MaxSize.
        /// All other optional parameters are left unchanged if not passed in the request. </para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateAutoScalingGroup service method on
        /// AmazonAutoScaling.</param>
        /// 
        /// <exception cref="T:Amazon.AutoScaling.Model.ScalingActivityInProgressException" />
		UpdateAutoScalingGroupResponse UpdateAutoScalingGroup(UpdateAutoScalingGroupRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateAutoScalingGroup operation.
        /// <seealso cref="Amazon.AutoScaling.IAmazonAutoScaling.UpdateAutoScalingGroup"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateAutoScalingGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<UpdateAutoScalingGroupResponse> UpdateAutoScalingGroupAsync(UpdateAutoScalingGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));
    }
}
