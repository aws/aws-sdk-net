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

using Amazon.AutoScaling;
using Amazon.AutoScaling.Model;

namespace Amazon.AutoScaling
{
    /// <summary>
    /// Interface for accessing AmazonAutoScaling.
    ///  
    ///  Auto Scaling <para> Auto Scaling is a web service designed to automatically launch or terminate Amazon Elastic Compute Cloud (Amazon EC2)
    /// instances based on user-defined policies, schedules, and health checks. This service is used in conjunction with Amazon CloudWatch and
    /// Elastic Load Balancing services. </para> <para>Auto Scaling provides APIs that you can call by submitting a Query Request. Query requests
    /// are HTTP or HTTPS requests that use the HTTP verbs GET or POST and a Query parameter named <i>Action</i> or <i>Operation</i> that specifies
    /// the API you are calling. Action is used throughout this documentation, although Operation is also supported for backward compatibility with
    /// other Amazon Web Services (AWS) Query APIs. </para> <para>Calling the API using a Query request is the most direct way to access the web
    /// service, but requires that your application handle low-level details such as generating the hash to sign the request and error handling. The
    /// benefit of calling the service using a Query request is that you are assured of having access to the complete functionality of the API. For
    /// information about signing a a query request, see <a href="http://docs.aws.amazon.com/AutoScaling/latest/DeveloperGuide/api_requests.html"
    /// >Use Query Requests to Call Auto Scaling APIs</a> </para> <para> This guide provides detailed information about Auto Scaling actions, data
    /// types, parameters, and errors. For detailed information about Auto Scaling features and their associated API actions, go to the <a
    /// href="http://docs.aws.amazon.com/AutoScaling/latest/DeveloperGuide/" >Auto Scaling Developer Guide</a> .
    /// </para> <para>This reference is based on the current WSDL, which is available at:</para> <para> <a
    /// href="http://autoscaling.amazonaws.com/doc/2011-01-01/AutoScaling.wsdl"
    /// >http://autoscaling.amazonaws.com/doc/2011-01-01/AutoScaling.wsdl</a> </para> <para> <b>Endpoints</b> </para> <para>The examples in this
    /// guide assume that your instances are launched in the US East (Northern Virginia) region and use us-east-1 as the endpoint.</para> <para>You
    /// can set up your Auto Scaling infrastructure in other AWS regions. For information about this product's regions and endpoints, see <a
    /// href="http://docs.aws.amazon.com/general/latest/gr/index.html?rande.html" >Regions and Endpoints</a> in the Amazon Web Services General
    /// Reference. </para>
    /// </summary>
    public partial interface IAmazonAutoScaling : IDisposable
    {


        #region AttachInstances

        /// <summary>
        /// <para> Attaches one or more Amazon EC2 instances to an existing Auto Scaling group. </para>
        /// </summary>
        /// 
        /// <param name="attachInstancesRequest">Container for the necessary parameters to execute the AttachInstances service method on
        ///          AmazonAutoScaling.</param>
        /// 
        AttachInstancesResponse AttachInstances(AttachInstancesRequest attachInstancesRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the AttachInstances operation.
        /// <seealso cref="Amazon.AutoScaling.IAmazonAutoScaling.AttachInstances"/>
        /// </summary>
        /// 
        /// <param name="attachInstancesRequest">Container for the necessary parameters to execute the AttachInstances operation on
        ///          AmazonAutoScaling.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        IAsyncResult BeginAttachInstances(AttachInstancesRequest attachInstancesRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the AttachInstances operation.
        /// <seealso cref="Amazon.AutoScaling.IAmazonAutoScaling.AttachInstances"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAttachInstances.</param>
        AttachInstancesResponse EndAttachInstances(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region CreateAutoScalingGroup

        /// <summary>
        /// <para> Creates a new Auto Scaling group with the specified name and other attributes. When the creation request is completed, the Auto
        /// Scaling group is ready to be used in other calls. </para> <para><b>NOTE:</b> The Auto Scaling group name must be unique within the scope of
        /// your AWS account. </para>
        /// </summary>
        /// 
        /// <param name="createAutoScalingGroupRequest">Container for the necessary parameters to execute the CreateAutoScalingGroup service method on
        ///          AmazonAutoScaling.</param>
        /// 
        /// <exception cref="LimitExceededException"/>
        /// <exception cref="AlreadyExistsException"/>
        CreateAutoScalingGroupResponse CreateAutoScalingGroup(CreateAutoScalingGroupRequest createAutoScalingGroupRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateAutoScalingGroup operation.
        /// <seealso cref="Amazon.AutoScaling.IAmazonAutoScaling.CreateAutoScalingGroup"/>
        /// </summary>
        /// 
        /// <param name="createAutoScalingGroupRequest">Container for the necessary parameters to execute the CreateAutoScalingGroup operation on
        ///          AmazonAutoScaling.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        IAsyncResult BeginCreateAutoScalingGroup(CreateAutoScalingGroupRequest createAutoScalingGroupRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the CreateAutoScalingGroup operation.
        /// <seealso cref="Amazon.AutoScaling.IAmazonAutoScaling.CreateAutoScalingGroup"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateAutoScalingGroup.</param>
        CreateAutoScalingGroupResponse EndCreateAutoScalingGroup(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region CreateLaunchConfiguration

        /// <summary>
        /// <para> Creates a new launch configuration. The launch configuration name must be unique within the scope of the client's AWS account. The
        /// maximum limit of launch configurations, which by default is 100, must not yet have been met; otherwise, the call will fail. When created,
        /// the new launch configuration is available for immediate use. </para> <para>You can create a launch configuration with Amazon EC2 security
        /// groups or with Amazon VPC security groups. However, you can't use Amazon EC2 security groups together with Amazon VPC security groups, or
        /// vice versa.</para> <para><b>NOTE:</b> At this time, Auto Scaling launch configurations don't support compressed (e.g. zipped) user data
        /// files. </para>
        /// </summary>
        /// 
        /// <param name="createLaunchConfigurationRequest">Container for the necessary parameters to execute the CreateLaunchConfiguration service
        ///          method on AmazonAutoScaling.</param>
        /// 
        /// <exception cref="LimitExceededException"/>
        /// <exception cref="AlreadyExistsException"/>
        CreateLaunchConfigurationResponse CreateLaunchConfiguration(CreateLaunchConfigurationRequest createLaunchConfigurationRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateLaunchConfiguration operation.
        /// <seealso cref="Amazon.AutoScaling.IAmazonAutoScaling.CreateLaunchConfiguration"/>
        /// </summary>
        /// 
        /// <param name="createLaunchConfigurationRequest">Container for the necessary parameters to execute the CreateLaunchConfiguration operation on
        ///          AmazonAutoScaling.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        IAsyncResult BeginCreateLaunchConfiguration(CreateLaunchConfigurationRequest createLaunchConfigurationRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the CreateLaunchConfiguration operation.
        /// <seealso cref="Amazon.AutoScaling.IAmazonAutoScaling.CreateLaunchConfiguration"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateLaunchConfiguration.</param>
        CreateLaunchConfigurationResponse EndCreateLaunchConfiguration(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region CreateOrUpdateTags

        /// <summary>
        /// <para> Creates new tags or updates existing tags for an Auto Scaling group. </para> <para><b>NOTE:</b> A tag's definition is composed of a
        /// resource ID, resource type, key and value, and the propagate flag. Value and the propagate flag are optional parameters. See the Request
        /// Parameters for more information. </para> <para>For information on creating tags for your Auto Scaling group, see <a
        /// href="http://docs.aws.amazon.com/AutoScaling/latest/DeveloperGuide/ASTagging.html" >Tag Your Auto Scaling Groups and Amazon EC2
        /// Instances</a> .</para>
        /// </summary>
        /// 
        /// <param name="createOrUpdateTagsRequest">Container for the necessary parameters to execute the CreateOrUpdateTags service method on
        ///          AmazonAutoScaling.</param>
        /// 
        /// <exception cref="LimitExceededException"/>
        /// <exception cref="AlreadyExistsException"/>
        CreateOrUpdateTagsResponse CreateOrUpdateTags(CreateOrUpdateTagsRequest createOrUpdateTagsRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateOrUpdateTags operation.
        /// <seealso cref="Amazon.AutoScaling.IAmazonAutoScaling.CreateOrUpdateTags"/>
        /// </summary>
        /// 
        /// <param name="createOrUpdateTagsRequest">Container for the necessary parameters to execute the CreateOrUpdateTags operation on
        ///          AmazonAutoScaling.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        IAsyncResult BeginCreateOrUpdateTags(CreateOrUpdateTagsRequest createOrUpdateTagsRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the CreateOrUpdateTags operation.
        /// <seealso cref="Amazon.AutoScaling.IAmazonAutoScaling.CreateOrUpdateTags"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateOrUpdateTags.</param>
        CreateOrUpdateTagsResponse EndCreateOrUpdateTags(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region DeleteAutoScalingGroup

        /// <summary>
        /// <para> Deletes the specified Auto Scaling group if the group has no instances and no scaling activities in progress. </para>
        /// <para><b>NOTE:</b> To remove all instances before calling DeleteAutoScalingGroup, you can call UpdateAutoScalingGroup to set the minimum and
        /// maximum size of the AutoScalingGroup to zero. </para>
        /// </summary>
        /// 
        /// <param name="deleteAutoScalingGroupRequest">Container for the necessary parameters to execute the DeleteAutoScalingGroup service method on
        ///          AmazonAutoScaling.</param>
        /// 
        /// <exception cref="ResourceInUseException"/>
        /// <exception cref="ScalingActivityInProgressException"/>
        DeleteAutoScalingGroupResponse DeleteAutoScalingGroup(DeleteAutoScalingGroupRequest deleteAutoScalingGroupRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteAutoScalingGroup operation.
        /// <seealso cref="Amazon.AutoScaling.IAmazonAutoScaling.DeleteAutoScalingGroup"/>
        /// </summary>
        /// 
        /// <param name="deleteAutoScalingGroupRequest">Container for the necessary parameters to execute the DeleteAutoScalingGroup operation on
        ///          AmazonAutoScaling.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        IAsyncResult BeginDeleteAutoScalingGroup(DeleteAutoScalingGroupRequest deleteAutoScalingGroupRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the DeleteAutoScalingGroup operation.
        /// <seealso cref="Amazon.AutoScaling.IAmazonAutoScaling.DeleteAutoScalingGroup"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteAutoScalingGroup.</param>
        DeleteAutoScalingGroupResponse EndDeleteAutoScalingGroup(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region DeleteLaunchConfiguration

        /// <summary>
        /// <para> Deletes the specified LaunchConfiguration. </para> <para> The specified launch configuration must not be attached to an Auto Scaling
        /// group. When this call completes, the launch configuration is no longer available for use. </para>
        /// </summary>
        /// 
        /// <param name="deleteLaunchConfigurationRequest">Container for the necessary parameters to execute the DeleteLaunchConfiguration service
        ///          method on AmazonAutoScaling.</param>
        /// 
        /// <exception cref="ResourceInUseException"/>
        DeleteLaunchConfigurationResponse DeleteLaunchConfiguration(DeleteLaunchConfigurationRequest deleteLaunchConfigurationRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteLaunchConfiguration operation.
        /// <seealso cref="Amazon.AutoScaling.IAmazonAutoScaling.DeleteLaunchConfiguration"/>
        /// </summary>
        /// 
        /// <param name="deleteLaunchConfigurationRequest">Container for the necessary parameters to execute the DeleteLaunchConfiguration operation on
        ///          AmazonAutoScaling.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        IAsyncResult BeginDeleteLaunchConfiguration(DeleteLaunchConfigurationRequest deleteLaunchConfigurationRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the DeleteLaunchConfiguration operation.
        /// <seealso cref="Amazon.AutoScaling.IAmazonAutoScaling.DeleteLaunchConfiguration"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteLaunchConfiguration.</param>
        DeleteLaunchConfigurationResponse EndDeleteLaunchConfiguration(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region DeleteNotificationConfiguration

        /// <summary>
        /// <para>Deletes notifications created by PutNotificationConfiguration.</para>
        /// </summary>
        /// 
        /// <param name="deleteNotificationConfigurationRequest">Container for the necessary parameters to execute the DeleteNotificationConfiguration
        ///          service method on AmazonAutoScaling.</param>
        /// 
        DeleteNotificationConfigurationResponse DeleteNotificationConfiguration(DeleteNotificationConfigurationRequest deleteNotificationConfigurationRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteNotificationConfiguration operation.
        /// <seealso cref="Amazon.AutoScaling.IAmazonAutoScaling.DeleteNotificationConfiguration"/>
        /// </summary>
        /// 
        /// <param name="deleteNotificationConfigurationRequest">Container for the necessary parameters to execute the DeleteNotificationConfiguration
        ///          operation on AmazonAutoScaling.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        IAsyncResult BeginDeleteNotificationConfiguration(DeleteNotificationConfigurationRequest deleteNotificationConfigurationRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the DeleteNotificationConfiguration operation.
        /// <seealso cref="Amazon.AutoScaling.IAmazonAutoScaling.DeleteNotificationConfiguration"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteNotificationConfiguration.</param>
        DeleteNotificationConfigurationResponse EndDeleteNotificationConfiguration(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region DeletePolicy

        /// <summary>
        /// <para>Deletes a policy created by PutScalingPolicy.</para>
        /// </summary>
        /// 
        /// <param name="deletePolicyRequest">Container for the necessary parameters to execute the DeletePolicy service method on
        ///          AmazonAutoScaling.</param>
        /// 
        DeletePolicyResponse DeletePolicy(DeletePolicyRequest deletePolicyRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the DeletePolicy operation.
        /// <seealso cref="Amazon.AutoScaling.IAmazonAutoScaling.DeletePolicy"/>
        /// </summary>
        /// 
        /// <param name="deletePolicyRequest">Container for the necessary parameters to execute the DeletePolicy operation on AmazonAutoScaling.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        IAsyncResult BeginDeletePolicy(DeletePolicyRequest deletePolicyRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the DeletePolicy operation.
        /// <seealso cref="Amazon.AutoScaling.IAmazonAutoScaling.DeletePolicy"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeletePolicy.</param>
        DeletePolicyResponse EndDeletePolicy(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region DeleteScheduledAction

        /// <summary>
        /// <para>Deletes a scheduled action previously created using the PutScheduledUpdateGroupAction.</para>
        /// </summary>
        /// 
        /// <param name="deleteScheduledActionRequest">Container for the necessary parameters to execute the DeleteScheduledAction service method on
        ///          AmazonAutoScaling.</param>
        /// 
        DeleteScheduledActionResponse DeleteScheduledAction(DeleteScheduledActionRequest deleteScheduledActionRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteScheduledAction operation.
        /// <seealso cref="Amazon.AutoScaling.IAmazonAutoScaling.DeleteScheduledAction"/>
        /// </summary>
        /// 
        /// <param name="deleteScheduledActionRequest">Container for the necessary parameters to execute the DeleteScheduledAction operation on
        ///          AmazonAutoScaling.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        IAsyncResult BeginDeleteScheduledAction(DeleteScheduledActionRequest deleteScheduledActionRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the DeleteScheduledAction operation.
        /// <seealso cref="Amazon.AutoScaling.IAmazonAutoScaling.DeleteScheduledAction"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteScheduledAction.</param>
        DeleteScheduledActionResponse EndDeleteScheduledAction(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region DeleteTags

        /// <summary>
        /// <para>Removes the specified tags or a set of tags from a set of resources.</para>
        /// </summary>
        /// 
        /// <param name="deleteTagsRequest">Container for the necessary parameters to execute the DeleteTags service method on
        ///          AmazonAutoScaling.</param>
        /// 
        DeleteTagsResponse DeleteTags(DeleteTagsRequest deleteTagsRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteTags operation.
        /// <seealso cref="Amazon.AutoScaling.IAmazonAutoScaling.DeleteTags"/>
        /// </summary>
        /// 
        /// <param name="deleteTagsRequest">Container for the necessary parameters to execute the DeleteTags operation on AmazonAutoScaling.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        IAsyncResult BeginDeleteTags(DeleteTagsRequest deleteTagsRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the DeleteTags operation.
        /// <seealso cref="Amazon.AutoScaling.IAmazonAutoScaling.DeleteTags"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteTags.</param>
        DeleteTagsResponse EndDeleteTags(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region DescribeAccountLimits

        /// <summary>
        /// <para> Returns the limits for the Auto Scaling resources set for your AWS account. </para>
        /// </summary>
        /// 
        /// <param name="describeAccountLimitsRequest">Container for the necessary parameters to execute the DescribeAccountLimits service method on
        ///          AmazonAutoScaling.</param>
        /// 
        /// <returns>The response from the DescribeAccountLimits service method, as returned by AmazonAutoScaling.</returns>
        /// 
        DescribeAccountLimitsResponse DescribeAccountLimits(DescribeAccountLimitsRequest describeAccountLimitsRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeAccountLimits operation.
        /// <seealso cref="Amazon.AutoScaling.IAmazonAutoScaling.DescribeAccountLimits"/>
        /// </summary>
        /// 
        /// <param name="describeAccountLimitsRequest">Container for the necessary parameters to execute the DescribeAccountLimits operation on
        ///          AmazonAutoScaling.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndDescribeAccountLimits operation.</returns>
        IAsyncResult BeginDescribeAccountLimits(DescribeAccountLimitsRequest describeAccountLimitsRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeAccountLimits operation.
        /// <seealso cref="Amazon.AutoScaling.IAmazonAutoScaling.DescribeAccountLimits"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeAccountLimits.</param>
        /// 
        /// <returns>Returns a DescribeAccountLimitsResult from AmazonAutoScaling.</returns>
        DescribeAccountLimitsResponse EndDescribeAccountLimits(IAsyncResult asyncResult);

        /// <summary>
        /// <para> Returns the limits for the Auto Scaling resources set for your AWS account. </para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeAccountLimits service method, as returned by AmazonAutoScaling.</returns>
        /// 
        DescribeAccountLimitsResponse DescribeAccountLimits();
        
        #endregion
        
    

        #region DescribeAdjustmentTypes

        /// <summary>
        /// <para> Returns policy adjustment types for use in the PutScalingPolicy action. </para>
        /// </summary>
        /// 
        /// <param name="describeAdjustmentTypesRequest">Container for the necessary parameters to execute the DescribeAdjustmentTypes service method on
        ///          AmazonAutoScaling.</param>
        /// 
        /// <returns>The response from the DescribeAdjustmentTypes service method, as returned by AmazonAutoScaling.</returns>
        /// 
        DescribeAdjustmentTypesResponse DescribeAdjustmentTypes(DescribeAdjustmentTypesRequest describeAdjustmentTypesRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeAdjustmentTypes operation.
        /// <seealso cref="Amazon.AutoScaling.IAmazonAutoScaling.DescribeAdjustmentTypes"/>
        /// </summary>
        /// 
        /// <param name="describeAdjustmentTypesRequest">Container for the necessary parameters to execute the DescribeAdjustmentTypes operation on
        ///          AmazonAutoScaling.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndDescribeAdjustmentTypes operation.</returns>
        IAsyncResult BeginDescribeAdjustmentTypes(DescribeAdjustmentTypesRequest describeAdjustmentTypesRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeAdjustmentTypes operation.
        /// <seealso cref="Amazon.AutoScaling.IAmazonAutoScaling.DescribeAdjustmentTypes"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeAdjustmentTypes.</param>
        /// 
        /// <returns>Returns a DescribeAdjustmentTypesResult from AmazonAutoScaling.</returns>
        DescribeAdjustmentTypesResponse EndDescribeAdjustmentTypes(IAsyncResult asyncResult);

        /// <summary>
        /// <para> Returns policy adjustment types for use in the PutScalingPolicy action. </para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeAdjustmentTypes service method, as returned by AmazonAutoScaling.</returns>
        /// 
        DescribeAdjustmentTypesResponse DescribeAdjustmentTypes();
        
        #endregion
        
    

        #region DescribeAutoScalingGroups

        /// <summary>
        /// <para> Returns a full description of each Auto Scaling group in the given list. This includes all Amazon EC2 instances that are members of
        /// the group. If a list of names is not provided, the service returns the full details of all Auto Scaling groups. </para> <para> This action
        /// supports pagination by returning a token if there are more pages to retrieve. To get the next page, call this action again with the returned
        /// token as the <c>NextToken</c> parameter. </para>
        /// </summary>
        /// 
        /// <param name="describeAutoScalingGroupsRequest">Container for the necessary parameters to execute the DescribeAutoScalingGroups service
        ///          method on AmazonAutoScaling.</param>
        /// 
        /// <returns>The response from the DescribeAutoScalingGroups service method, as returned by AmazonAutoScaling.</returns>
        /// 
        /// <exception cref="InvalidNextTokenException"/>
        DescribeAutoScalingGroupsResponse DescribeAutoScalingGroups(DescribeAutoScalingGroupsRequest describeAutoScalingGroupsRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeAutoScalingGroups operation.
        /// <seealso cref="Amazon.AutoScaling.IAmazonAutoScaling.DescribeAutoScalingGroups"/>
        /// </summary>
        /// 
        /// <param name="describeAutoScalingGroupsRequest">Container for the necessary parameters to execute the DescribeAutoScalingGroups operation on
        ///          AmazonAutoScaling.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndDescribeAutoScalingGroups operation.</returns>
        IAsyncResult BeginDescribeAutoScalingGroups(DescribeAutoScalingGroupsRequest describeAutoScalingGroupsRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeAutoScalingGroups operation.
        /// <seealso cref="Amazon.AutoScaling.IAmazonAutoScaling.DescribeAutoScalingGroups"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeAutoScalingGroups.</param>
        /// 
        /// <returns>Returns a DescribeAutoScalingGroupsResult from AmazonAutoScaling.</returns>
        DescribeAutoScalingGroupsResponse EndDescribeAutoScalingGroups(IAsyncResult asyncResult);

        /// <summary>
        /// <para> Returns a full description of each Auto Scaling group in the given list. This includes all Amazon EC2 instances that are members of
        /// the group. If a list of names is not provided, the service returns the full details of all Auto Scaling groups. </para> <para> This action
        /// supports pagination by returning a token if there are more pages to retrieve. To get the next page, call this action again with the returned
        /// token as the <c>NextToken</c> parameter. </para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeAutoScalingGroups service method, as returned by AmazonAutoScaling.</returns>
        /// 
        /// <exception cref="InvalidNextTokenException"/>
        DescribeAutoScalingGroupsResponse DescribeAutoScalingGroups();
        
        #endregion
        
    

        #region DescribeAutoScalingInstances

        /// <summary>
        /// <para> Returns a description of each Auto Scaling instance in the <c>InstanceIds</c> list. If a list is not provided, the service returns
        /// the full details of all instances up to a maximum of 50. By default, the service returns a list of 20 items. </para> <para> This action
        /// supports pagination by returning a token if there are more pages to retrieve. To get the next page, call this action again with the returned
        /// token as the <c>NextToken</c> parameter. </para>
        /// </summary>
        /// 
        /// <param name="describeAutoScalingInstancesRequest">Container for the necessary parameters to execute the DescribeAutoScalingInstances service
        ///          method on AmazonAutoScaling.</param>
        /// 
        /// <returns>The response from the DescribeAutoScalingInstances service method, as returned by AmazonAutoScaling.</returns>
        /// 
        /// <exception cref="InvalidNextTokenException"/>
        DescribeAutoScalingInstancesResponse DescribeAutoScalingInstances(DescribeAutoScalingInstancesRequest describeAutoScalingInstancesRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeAutoScalingInstances operation.
        /// <seealso cref="Amazon.AutoScaling.IAmazonAutoScaling.DescribeAutoScalingInstances"/>
        /// </summary>
        /// 
        /// <param name="describeAutoScalingInstancesRequest">Container for the necessary parameters to execute the DescribeAutoScalingInstances
        ///          operation on AmazonAutoScaling.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndDescribeAutoScalingInstances operation.</returns>
        IAsyncResult BeginDescribeAutoScalingInstances(DescribeAutoScalingInstancesRequest describeAutoScalingInstancesRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeAutoScalingInstances operation.
        /// <seealso cref="Amazon.AutoScaling.IAmazonAutoScaling.DescribeAutoScalingInstances"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeAutoScalingInstances.</param>
        /// 
        /// <returns>Returns a DescribeAutoScalingInstancesResult from AmazonAutoScaling.</returns>
        DescribeAutoScalingInstancesResponse EndDescribeAutoScalingInstances(IAsyncResult asyncResult);

        /// <summary>
        /// <para> Returns a description of each Auto Scaling instance in the <c>InstanceIds</c> list. If a list is not provided, the service returns
        /// the full details of all instances up to a maximum of 50. By default, the service returns a list of 20 items. </para> <para> This action
        /// supports pagination by returning a token if there are more pages to retrieve. To get the next page, call this action again with the returned
        /// token as the <c>NextToken</c> parameter. </para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeAutoScalingInstances service method, as returned by AmazonAutoScaling.</returns>
        /// 
        /// <exception cref="InvalidNextTokenException"/>
        DescribeAutoScalingInstancesResponse DescribeAutoScalingInstances();
        
        #endregion
        
    

        #region DescribeAutoScalingNotificationTypes

        /// <summary>
        /// <para> Returns a list of all notification types that are supported by Auto Scaling. </para>
        /// </summary>
        /// 
        /// <param name="describeAutoScalingNotificationTypesRequest">Container for the necessary parameters to execute the
        ///          DescribeAutoScalingNotificationTypes service method on AmazonAutoScaling.</param>
        /// 
        /// <returns>The response from the DescribeAutoScalingNotificationTypes service method, as returned by AmazonAutoScaling.</returns>
        /// 
        DescribeAutoScalingNotificationTypesResponse DescribeAutoScalingNotificationTypes(DescribeAutoScalingNotificationTypesRequest describeAutoScalingNotificationTypesRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeAutoScalingNotificationTypes operation.
        /// <seealso cref="Amazon.AutoScaling.IAmazonAutoScaling.DescribeAutoScalingNotificationTypes"/>
        /// </summary>
        /// 
        /// <param name="describeAutoScalingNotificationTypesRequest">Container for the necessary parameters to execute the
        ///          DescribeAutoScalingNotificationTypes operation on AmazonAutoScaling.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndDescribeAutoScalingNotificationTypes operation.</returns>
        IAsyncResult BeginDescribeAutoScalingNotificationTypes(DescribeAutoScalingNotificationTypesRequest describeAutoScalingNotificationTypesRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeAutoScalingNotificationTypes operation.
        /// <seealso cref="Amazon.AutoScaling.IAmazonAutoScaling.DescribeAutoScalingNotificationTypes"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeAutoScalingNotificationTypes.</param>
        /// 
        /// <returns>Returns a DescribeAutoScalingNotificationTypesResult from AmazonAutoScaling.</returns>
        DescribeAutoScalingNotificationTypesResponse EndDescribeAutoScalingNotificationTypes(IAsyncResult asyncResult);

        /// <summary>
        /// <para> Returns a list of all notification types that are supported by Auto Scaling. </para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeAutoScalingNotificationTypes service method, as returned by AmazonAutoScaling.</returns>
        /// 
        DescribeAutoScalingNotificationTypesResponse DescribeAutoScalingNotificationTypes();
        
        #endregion
        
    

        #region DescribeLaunchConfigurations

        /// <summary>
        /// <para> Returns a full description of the launch configurations, or the specified launch configurations, if they exist. </para> <para> If no
        /// name is specified, then the full details of all launch configurations are returned. </para>
        /// </summary>
        /// 
        /// <param name="describeLaunchConfigurationsRequest">Container for the necessary parameters to execute the DescribeLaunchConfigurations service
        ///          method on AmazonAutoScaling.</param>
        /// 
        /// <returns>The response from the DescribeLaunchConfigurations service method, as returned by AmazonAutoScaling.</returns>
        /// 
        /// <exception cref="InvalidNextTokenException"/>
        DescribeLaunchConfigurationsResponse DescribeLaunchConfigurations(DescribeLaunchConfigurationsRequest describeLaunchConfigurationsRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeLaunchConfigurations operation.
        /// <seealso cref="Amazon.AutoScaling.IAmazonAutoScaling.DescribeLaunchConfigurations"/>
        /// </summary>
        /// 
        /// <param name="describeLaunchConfigurationsRequest">Container for the necessary parameters to execute the DescribeLaunchConfigurations
        ///          operation on AmazonAutoScaling.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndDescribeLaunchConfigurations operation.</returns>
        IAsyncResult BeginDescribeLaunchConfigurations(DescribeLaunchConfigurationsRequest describeLaunchConfigurationsRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeLaunchConfigurations operation.
        /// <seealso cref="Amazon.AutoScaling.IAmazonAutoScaling.DescribeLaunchConfigurations"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeLaunchConfigurations.</param>
        /// 
        /// <returns>Returns a DescribeLaunchConfigurationsResult from AmazonAutoScaling.</returns>
        DescribeLaunchConfigurationsResponse EndDescribeLaunchConfigurations(IAsyncResult asyncResult);

        /// <summary>
        /// <para> Returns a full description of the launch configurations, or the specified launch configurations, if they exist. </para> <para> If no
        /// name is specified, then the full details of all launch configurations are returned. </para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeLaunchConfigurations service method, as returned by AmazonAutoScaling.</returns>
        /// 
        /// <exception cref="InvalidNextTokenException"/>
        DescribeLaunchConfigurationsResponse DescribeLaunchConfigurations();
        
        #endregion
        
    

        #region DescribeMetricCollectionTypes

        /// <summary>
        /// <para> Returns a list of metrics and a corresponding list of granularities for each metric. </para>
        /// </summary>
        /// 
        /// <param name="describeMetricCollectionTypesRequest">Container for the necessary parameters to execute the DescribeMetricCollectionTypes
        ///          service method on AmazonAutoScaling.</param>
        /// 
        /// <returns>The response from the DescribeMetricCollectionTypes service method, as returned by AmazonAutoScaling.</returns>
        /// 
        DescribeMetricCollectionTypesResponse DescribeMetricCollectionTypes(DescribeMetricCollectionTypesRequest describeMetricCollectionTypesRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeMetricCollectionTypes operation.
        /// <seealso cref="Amazon.AutoScaling.IAmazonAutoScaling.DescribeMetricCollectionTypes"/>
        /// </summary>
        /// 
        /// <param name="describeMetricCollectionTypesRequest">Container for the necessary parameters to execute the DescribeMetricCollectionTypes
        ///          operation on AmazonAutoScaling.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndDescribeMetricCollectionTypes operation.</returns>
        IAsyncResult BeginDescribeMetricCollectionTypes(DescribeMetricCollectionTypesRequest describeMetricCollectionTypesRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeMetricCollectionTypes operation.
        /// <seealso cref="Amazon.AutoScaling.IAmazonAutoScaling.DescribeMetricCollectionTypes"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeMetricCollectionTypes.</param>
        /// 
        /// <returns>Returns a DescribeMetricCollectionTypesResult from AmazonAutoScaling.</returns>
        DescribeMetricCollectionTypesResponse EndDescribeMetricCollectionTypes(IAsyncResult asyncResult);

        /// <summary>
        /// <para> Returns a list of metrics and a corresponding list of granularities for each metric. </para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeMetricCollectionTypes service method, as returned by AmazonAutoScaling.</returns>
        /// 
        DescribeMetricCollectionTypesResponse DescribeMetricCollectionTypes();
        
        #endregion
        
    

        #region DescribeNotificationConfigurations

        /// <summary>
        /// <para> Returns a list of notification actions associated with Auto Scaling groups for specified events. </para>
        /// </summary>
        /// 
        /// <param name="describeNotificationConfigurationsRequest">Container for the necessary parameters to execute the
        ///          DescribeNotificationConfigurations service method on AmazonAutoScaling.</param>
        /// 
        /// <returns>The response from the DescribeNotificationConfigurations service method, as returned by AmazonAutoScaling.</returns>
        /// 
        /// <exception cref="InvalidNextTokenException"/>
        DescribeNotificationConfigurationsResponse DescribeNotificationConfigurations(DescribeNotificationConfigurationsRequest describeNotificationConfigurationsRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeNotificationConfigurations operation.
        /// <seealso cref="Amazon.AutoScaling.IAmazonAutoScaling.DescribeNotificationConfigurations"/>
        /// </summary>
        /// 
        /// <param name="describeNotificationConfigurationsRequest">Container for the necessary parameters to execute the
        ///          DescribeNotificationConfigurations operation on AmazonAutoScaling.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndDescribeNotificationConfigurations operation.</returns>
        IAsyncResult BeginDescribeNotificationConfigurations(DescribeNotificationConfigurationsRequest describeNotificationConfigurationsRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeNotificationConfigurations operation.
        /// <seealso cref="Amazon.AutoScaling.IAmazonAutoScaling.DescribeNotificationConfigurations"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeNotificationConfigurations.</param>
        /// 
        /// <returns>Returns a DescribeNotificationConfigurationsResult from AmazonAutoScaling.</returns>
        DescribeNotificationConfigurationsResponse EndDescribeNotificationConfigurations(IAsyncResult asyncResult);

        /// <summary>
        /// <para> Returns a list of notification actions associated with Auto Scaling groups for specified events. </para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeNotificationConfigurations service method, as returned by AmazonAutoScaling.</returns>
        /// 
        /// <exception cref="InvalidNextTokenException"/>
        DescribeNotificationConfigurationsResponse DescribeNotificationConfigurations();
        
        #endregion
        
    

        #region DescribePolicies

        /// <summary>
        /// <para> Returns descriptions of what each policy does. This action supports pagination. If the response includes a token, there are more
        /// records available. To get the additional records, repeat the request with the response token as the <c>NextToken</c> parameter. </para>
        /// </summary>
        /// 
        /// <param name="describePoliciesRequest">Container for the necessary parameters to execute the DescribePolicies service method on
        ///          AmazonAutoScaling.</param>
        /// 
        /// <returns>The response from the DescribePolicies service method, as returned by AmazonAutoScaling.</returns>
        /// 
        /// <exception cref="InvalidNextTokenException"/>
        DescribePoliciesResponse DescribePolicies(DescribePoliciesRequest describePoliciesRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribePolicies operation.
        /// <seealso cref="Amazon.AutoScaling.IAmazonAutoScaling.DescribePolicies"/>
        /// </summary>
        /// 
        /// <param name="describePoliciesRequest">Container for the necessary parameters to execute the DescribePolicies operation on
        ///          AmazonAutoScaling.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribePolicies
        ///         operation.</returns>
        IAsyncResult BeginDescribePolicies(DescribePoliciesRequest describePoliciesRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the DescribePolicies operation.
        /// <seealso cref="Amazon.AutoScaling.IAmazonAutoScaling.DescribePolicies"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribePolicies.</param>
        /// 
        /// <returns>Returns a DescribePoliciesResult from AmazonAutoScaling.</returns>
        DescribePoliciesResponse EndDescribePolicies(IAsyncResult asyncResult);

        /// <summary>
        /// <para> Returns descriptions of what each policy does. This action supports pagination. If the response includes a token, there are more
        /// records available. To get the additional records, repeat the request with the response token as the <c>NextToken</c> parameter. </para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribePolicies service method, as returned by AmazonAutoScaling.</returns>
        /// 
        /// <exception cref="InvalidNextTokenException"/>
        DescribePoliciesResponse DescribePolicies();
        
        #endregion
        
    

        #region DescribeScalingActivities

        /// <summary>
        /// <para> Returns the scaling activities for the specified Auto Scaling group. </para> <para> If the specified <c>ActivityIds</c> list is
        /// empty, all the activities from the past six weeks are returned. Activities are sorted by completion time. Activities still in progress
        /// appear first on the list. </para> <para> This action supports pagination. If the response includes a token, there are more records
        /// available. To get the additional records, repeat the request with the response token as the <c>NextToken</c> parameter. </para>
        /// </summary>
        /// 
        /// <param name="describeScalingActivitiesRequest">Container for the necessary parameters to execute the DescribeScalingActivities service
        ///          method on AmazonAutoScaling.</param>
        /// 
        /// <returns>The response from the DescribeScalingActivities service method, as returned by AmazonAutoScaling.</returns>
        /// 
        /// <exception cref="InvalidNextTokenException"/>
        DescribeScalingActivitiesResponse DescribeScalingActivities(DescribeScalingActivitiesRequest describeScalingActivitiesRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeScalingActivities operation.
        /// <seealso cref="Amazon.AutoScaling.IAmazonAutoScaling.DescribeScalingActivities"/>
        /// </summary>
        /// 
        /// <param name="describeScalingActivitiesRequest">Container for the necessary parameters to execute the DescribeScalingActivities operation on
        ///          AmazonAutoScaling.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndDescribeScalingActivities operation.</returns>
        IAsyncResult BeginDescribeScalingActivities(DescribeScalingActivitiesRequest describeScalingActivitiesRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeScalingActivities operation.
        /// <seealso cref="Amazon.AutoScaling.IAmazonAutoScaling.DescribeScalingActivities"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeScalingActivities.</param>
        /// 
        /// <returns>Returns a DescribeScalingActivitiesResult from AmazonAutoScaling.</returns>
        DescribeScalingActivitiesResponse EndDescribeScalingActivities(IAsyncResult asyncResult);

        /// <summary>
        /// <para> Returns the scaling activities for the specified Auto Scaling group. </para> <para> If the specified <c>ActivityIds</c> list is
        /// empty, all the activities from the past six weeks are returned. Activities are sorted by completion time. Activities still in progress
        /// appear first on the list. </para> <para> This action supports pagination. If the response includes a token, there are more records
        /// available. To get the additional records, repeat the request with the response token as the <c>NextToken</c> parameter. </para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeScalingActivities service method, as returned by AmazonAutoScaling.</returns>
        /// 
        /// <exception cref="InvalidNextTokenException"/>
        DescribeScalingActivitiesResponse DescribeScalingActivities();
        
        #endregion
        
    

        #region DescribeScalingProcessTypes

        /// <summary>
        /// <para>Returns scaling process types for use in the ResumeProcesses and SuspendProcesses actions.</para>
        /// </summary>
        /// 
        /// <param name="describeScalingProcessTypesRequest">Container for the necessary parameters to execute the DescribeScalingProcessTypes service
        ///          method on AmazonAutoScaling.</param>
        /// 
        /// <returns>The response from the DescribeScalingProcessTypes service method, as returned by AmazonAutoScaling.</returns>
        /// 
        DescribeScalingProcessTypesResponse DescribeScalingProcessTypes(DescribeScalingProcessTypesRequest describeScalingProcessTypesRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeScalingProcessTypes operation.
        /// <seealso cref="Amazon.AutoScaling.IAmazonAutoScaling.DescribeScalingProcessTypes"/>
        /// </summary>
        /// 
        /// <param name="describeScalingProcessTypesRequest">Container for the necessary parameters to execute the DescribeScalingProcessTypes operation
        ///          on AmazonAutoScaling.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndDescribeScalingProcessTypes operation.</returns>
        IAsyncResult BeginDescribeScalingProcessTypes(DescribeScalingProcessTypesRequest describeScalingProcessTypesRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeScalingProcessTypes operation.
        /// <seealso cref="Amazon.AutoScaling.IAmazonAutoScaling.DescribeScalingProcessTypes"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeScalingProcessTypes.</param>
        /// 
        /// <returns>Returns a DescribeScalingProcessTypesResult from AmazonAutoScaling.</returns>
        DescribeScalingProcessTypesResponse EndDescribeScalingProcessTypes(IAsyncResult asyncResult);

        /// <summary>
        /// <para>Returns scaling process types for use in the ResumeProcesses and SuspendProcesses actions.</para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeScalingProcessTypes service method, as returned by AmazonAutoScaling.</returns>
        /// 
        DescribeScalingProcessTypesResponse DescribeScalingProcessTypes();
        
        #endregion
        
    

        #region DescribeScheduledActions

        /// <summary>
        /// <para> Lists all the actions scheduled for your Auto Scaling group that haven't been executed. To see a list of actions already executed,
        /// see the activity record returned in DescribeScalingActivities. </para>
        /// </summary>
        /// 
        /// <param name="describeScheduledActionsRequest">Container for the necessary parameters to execute the DescribeScheduledActions service method
        ///          on AmazonAutoScaling.</param>
        /// 
        /// <returns>The response from the DescribeScheduledActions service method, as returned by AmazonAutoScaling.</returns>
        /// 
        /// <exception cref="InvalidNextTokenException"/>
        DescribeScheduledActionsResponse DescribeScheduledActions(DescribeScheduledActionsRequest describeScheduledActionsRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeScheduledActions operation.
        /// <seealso cref="Amazon.AutoScaling.IAmazonAutoScaling.DescribeScheduledActions"/>
        /// </summary>
        /// 
        /// <param name="describeScheduledActionsRequest">Container for the necessary parameters to execute the DescribeScheduledActions operation on
        ///          AmazonAutoScaling.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndDescribeScheduledActions operation.</returns>
        IAsyncResult BeginDescribeScheduledActions(DescribeScheduledActionsRequest describeScheduledActionsRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeScheduledActions operation.
        /// <seealso cref="Amazon.AutoScaling.IAmazonAutoScaling.DescribeScheduledActions"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeScheduledActions.</param>
        /// 
        /// <returns>Returns a DescribeScheduledActionsResult from AmazonAutoScaling.</returns>
        DescribeScheduledActionsResponse EndDescribeScheduledActions(IAsyncResult asyncResult);

        /// <summary>
        /// <para> Lists all the actions scheduled for your Auto Scaling group that haven't been executed. To see a list of actions already executed,
        /// see the activity record returned in DescribeScalingActivities. </para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeScheduledActions service method, as returned by AmazonAutoScaling.</returns>
        /// 
        /// <exception cref="InvalidNextTokenException"/>
        DescribeScheduledActionsResponse DescribeScheduledActions();
        
        #endregion
        
    

        #region DescribeTags

        /// <summary>
        /// <para> Lists the Auto Scaling group tags. </para> <para> You can use filters to limit results when describing tags. For example, you can
        /// query for tags of a particular Auto Scaling group. You can specify multiple values for a filter. A tag must match at least one of the
        /// specified values for it to be included in the results. </para> <para> You can also specify multiple filters. The result includes information
        /// for a particular tag only if it matches all your filters. If there's no match, no special message is returned. </para>
        /// </summary>
        /// 
        /// <param name="describeTagsRequest">Container for the necessary parameters to execute the DescribeTags service method on
        ///          AmazonAutoScaling.</param>
        /// 
        /// <returns>The response from the DescribeTags service method, as returned by AmazonAutoScaling.</returns>
        /// 
        /// <exception cref="InvalidNextTokenException"/>
        DescribeTagsResponse DescribeTags(DescribeTagsRequest describeTagsRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeTags operation.
        /// <seealso cref="Amazon.AutoScaling.IAmazonAutoScaling.DescribeTags"/>
        /// </summary>
        /// 
        /// <param name="describeTagsRequest">Container for the necessary parameters to execute the DescribeTags operation on AmazonAutoScaling.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeTags
        ///         operation.</returns>
        IAsyncResult BeginDescribeTags(DescribeTagsRequest describeTagsRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeTags operation.
        /// <seealso cref="Amazon.AutoScaling.IAmazonAutoScaling.DescribeTags"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeTags.</param>
        /// 
        /// <returns>Returns a DescribeTagsResult from AmazonAutoScaling.</returns>
        DescribeTagsResponse EndDescribeTags(IAsyncResult asyncResult);

        /// <summary>
        /// <para> Lists the Auto Scaling group tags. </para> <para> You can use filters to limit results when describing tags. For example, you can
        /// query for tags of a particular Auto Scaling group. You can specify multiple values for a filter. A tag must match at least one of the
        /// specified values for it to be included in the results. </para> <para> You can also specify multiple filters. The result includes information
        /// for a particular tag only if it matches all your filters. If there's no match, no special message is returned. </para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeTags service method, as returned by AmazonAutoScaling.</returns>
        /// 
        /// <exception cref="InvalidNextTokenException"/>
        DescribeTagsResponse DescribeTags();
        
        #endregion
        
    

        #region DescribeTerminationPolicyTypes

        /// <summary>
        /// <para> Returns a list of all termination policies supported by Auto Scaling. </para>
        /// </summary>
        /// 
        /// <param name="describeTerminationPolicyTypesRequest">Container for the necessary parameters to execute the DescribeTerminationPolicyTypes
        ///          service method on AmazonAutoScaling.</param>
        /// 
        /// <returns>The response from the DescribeTerminationPolicyTypes service method, as returned by AmazonAutoScaling.</returns>
        /// 
        DescribeTerminationPolicyTypesResponse DescribeTerminationPolicyTypes(DescribeTerminationPolicyTypesRequest describeTerminationPolicyTypesRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeTerminationPolicyTypes operation.
        /// <seealso cref="Amazon.AutoScaling.IAmazonAutoScaling.DescribeTerminationPolicyTypes"/>
        /// </summary>
        /// 
        /// <param name="describeTerminationPolicyTypesRequest">Container for the necessary parameters to execute the DescribeTerminationPolicyTypes
        ///          operation on AmazonAutoScaling.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndDescribeTerminationPolicyTypes operation.</returns>
        IAsyncResult BeginDescribeTerminationPolicyTypes(DescribeTerminationPolicyTypesRequest describeTerminationPolicyTypesRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeTerminationPolicyTypes operation.
        /// <seealso cref="Amazon.AutoScaling.IAmazonAutoScaling.DescribeTerminationPolicyTypes"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeTerminationPolicyTypes.</param>
        /// 
        /// <returns>Returns a DescribeTerminationPolicyTypesResult from AmazonAutoScaling.</returns>
        DescribeTerminationPolicyTypesResponse EndDescribeTerminationPolicyTypes(IAsyncResult asyncResult);

        /// <summary>
        /// <para> Returns a list of all termination policies supported by Auto Scaling. </para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeTerminationPolicyTypes service method, as returned by AmazonAutoScaling.</returns>
        /// 
        DescribeTerminationPolicyTypesResponse DescribeTerminationPolicyTypes();
        
        #endregion
        
    

        #region DisableMetricsCollection

        /// <summary>
        /// <para> Disables monitoring of group metrics for the Auto Scaling group specified in <c>AutoScalingGroupName</c> .
        /// You can specify the list of affected metrics with the <c>Metrics</c> parameter. </para>
        /// </summary>
        /// 
        /// <param name="disableMetricsCollectionRequest">Container for the necessary parameters to execute the DisableMetricsCollection service method
        ///          on AmazonAutoScaling.</param>
        /// 
        DisableMetricsCollectionResponse DisableMetricsCollection(DisableMetricsCollectionRequest disableMetricsCollectionRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the DisableMetricsCollection operation.
        /// <seealso cref="Amazon.AutoScaling.IAmazonAutoScaling.DisableMetricsCollection"/>
        /// </summary>
        /// 
        /// <param name="disableMetricsCollectionRequest">Container for the necessary parameters to execute the DisableMetricsCollection operation on
        ///          AmazonAutoScaling.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        IAsyncResult BeginDisableMetricsCollection(DisableMetricsCollectionRequest disableMetricsCollectionRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the DisableMetricsCollection operation.
        /// <seealso cref="Amazon.AutoScaling.IAmazonAutoScaling.DisableMetricsCollection"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisableMetricsCollection.</param>
        DisableMetricsCollectionResponse EndDisableMetricsCollection(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region EnableMetricsCollection

        /// <summary>
        /// <para> Enables monitoring of group metrics for the Auto Scaling group specified in <c>AutoScalingGroupName</c> .
        /// You can specify the list of enabled metrics with the <c>Metrics</c> parameter. </para> <para> Auto Scaling metrics collection
        /// can be turned on only if the <c>InstanceMonitoring</c> flag, in the Auto Scaling group's launch configuration, is set to <c>True</c> .
        /// </para>
        /// </summary>
        /// 
        /// <param name="enableMetricsCollectionRequest">Container for the necessary parameters to execute the EnableMetricsCollection service method on
        ///          AmazonAutoScaling.</param>
        /// 
        EnableMetricsCollectionResponse EnableMetricsCollection(EnableMetricsCollectionRequest enableMetricsCollectionRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the EnableMetricsCollection operation.
        /// <seealso cref="Amazon.AutoScaling.IAmazonAutoScaling.EnableMetricsCollection"/>
        /// </summary>
        /// 
        /// <param name="enableMetricsCollectionRequest">Container for the necessary parameters to execute the EnableMetricsCollection operation on
        ///          AmazonAutoScaling.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        IAsyncResult BeginEnableMetricsCollection(EnableMetricsCollectionRequest enableMetricsCollectionRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the EnableMetricsCollection operation.
        /// <seealso cref="Amazon.AutoScaling.IAmazonAutoScaling.EnableMetricsCollection"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginEnableMetricsCollection.</param>
        EnableMetricsCollectionResponse EndEnableMetricsCollection(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region ExecutePolicy

        /// <summary>
        /// <para>Executes the specified policy. </para>
        /// </summary>
        /// 
        /// <param name="executePolicyRequest">Container for the necessary parameters to execute the ExecutePolicy service method on
        ///          AmazonAutoScaling.</param>
        /// 
        /// <exception cref="ScalingActivityInProgressException"/>
        ExecutePolicyResponse ExecutePolicy(ExecutePolicyRequest executePolicyRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the ExecutePolicy operation.
        /// <seealso cref="Amazon.AutoScaling.IAmazonAutoScaling.ExecutePolicy"/>
        /// </summary>
        /// 
        /// <param name="executePolicyRequest">Container for the necessary parameters to execute the ExecutePolicy operation on
        ///          AmazonAutoScaling.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        IAsyncResult BeginExecutePolicy(ExecutePolicyRequest executePolicyRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the ExecutePolicy operation.
        /// <seealso cref="Amazon.AutoScaling.IAmazonAutoScaling.ExecutePolicy"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginExecutePolicy.</param>
        ExecutePolicyResponse EndExecutePolicy(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region PutNotificationConfiguration

        /// <summary>
        /// <para> Configures an Auto Scaling group to send notifications when specified events take place. Subscribers to this topic can have messages
        /// for events delivered to an endpoint such as a web server or email address. </para> <para>For more information see <a
        /// href="http://docs.aws.amazon.com/AutoScaling/latest/DeveloperGuide/ASGettingNotifications.html" >Get Email Notifications When Your Auto
        /// Scaling Group Changes</a> </para> <para>A new <c>PutNotificationConfiguration</c> overwrites an existing configuration. </para>
        /// </summary>
        /// 
        /// <param name="putNotificationConfigurationRequest">Container for the necessary parameters to execute the PutNotificationConfiguration service
        ///          method on AmazonAutoScaling.</param>
        /// 
        /// <exception cref="LimitExceededException"/>
        PutNotificationConfigurationResponse PutNotificationConfiguration(PutNotificationConfigurationRequest putNotificationConfigurationRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the PutNotificationConfiguration operation.
        /// <seealso cref="Amazon.AutoScaling.IAmazonAutoScaling.PutNotificationConfiguration"/>
        /// </summary>
        /// 
        /// <param name="putNotificationConfigurationRequest">Container for the necessary parameters to execute the PutNotificationConfiguration
        ///          operation on AmazonAutoScaling.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        IAsyncResult BeginPutNotificationConfiguration(PutNotificationConfigurationRequest putNotificationConfigurationRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the PutNotificationConfiguration operation.
        /// <seealso cref="Amazon.AutoScaling.IAmazonAutoScaling.PutNotificationConfiguration"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutNotificationConfiguration.</param>
        PutNotificationConfigurationResponse EndPutNotificationConfiguration(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region PutScalingPolicy

        /// <summary>
        /// <para> Creates or updates a policy for an Auto Scaling group. To update an existing policy, use the existing policy name and set the
        /// parameter(s) you want to change. Any existing parameter not changed in an update to an existing policy is not changed in this update
        /// request. </para>
        /// </summary>
        /// 
        /// <param name="putScalingPolicyRequest">Container for the necessary parameters to execute the PutScalingPolicy service method on
        ///          AmazonAutoScaling.</param>
        /// 
        /// <returns>The response from the PutScalingPolicy service method, as returned by AmazonAutoScaling.</returns>
        /// 
        /// <exception cref="LimitExceededException"/>
        PutScalingPolicyResponse PutScalingPolicy(PutScalingPolicyRequest putScalingPolicyRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the PutScalingPolicy operation.
        /// <seealso cref="Amazon.AutoScaling.IAmazonAutoScaling.PutScalingPolicy"/>
        /// </summary>
        /// 
        /// <param name="putScalingPolicyRequest">Container for the necessary parameters to execute the PutScalingPolicy operation on
        ///          AmazonAutoScaling.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutScalingPolicy
        ///         operation.</returns>
        IAsyncResult BeginPutScalingPolicy(PutScalingPolicyRequest putScalingPolicyRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the PutScalingPolicy operation.
        /// <seealso cref="Amazon.AutoScaling.IAmazonAutoScaling.PutScalingPolicy"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutScalingPolicy.</param>
        /// 
        /// <returns>Returns a PutScalingPolicyResult from AmazonAutoScaling.</returns>
        PutScalingPolicyResponse EndPutScalingPolicy(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region PutScheduledUpdateGroupAction

        /// <summary>
        /// <para> Creates or updates a scheduled scaling action for an Auto Scaling group. When updating a scheduled scaling action, if you leave a
        /// parameter unspecified, the corresponding value remains unchanged in the affected Auto Scaling group. </para> <para>For information on
        /// creating or updating a scheduled action for your Auto Scaling group, see <a
        /// href="http://docs.aws.amazon.com/AutoScaling/latest/DeveloperGuide/schedule_time.html" >Scale Based on a Schedule</a> .</para>
        /// <para><b>NOTE:</b> Auto Scaling supports the date and time expressed in "YYYY-MM-DDThh:mm:ssZ" format in UTC/GMT only. </para>
        /// </summary>
        /// 
        /// <param name="putScheduledUpdateGroupActionRequest">Container for the necessary parameters to execute the PutScheduledUpdateGroupAction
        ///          service method on AmazonAutoScaling.</param>
        /// 
        /// <exception cref="LimitExceededException"/>
        /// <exception cref="AlreadyExistsException"/>
        PutScheduledUpdateGroupActionResponse PutScheduledUpdateGroupAction(PutScheduledUpdateGroupActionRequest putScheduledUpdateGroupActionRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the PutScheduledUpdateGroupAction operation.
        /// <seealso cref="Amazon.AutoScaling.IAmazonAutoScaling.PutScheduledUpdateGroupAction"/>
        /// </summary>
        /// 
        /// <param name="putScheduledUpdateGroupActionRequest">Container for the necessary parameters to execute the PutScheduledUpdateGroupAction
        ///          operation on AmazonAutoScaling.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        IAsyncResult BeginPutScheduledUpdateGroupAction(PutScheduledUpdateGroupActionRequest putScheduledUpdateGroupActionRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the PutScheduledUpdateGroupAction operation.
        /// <seealso cref="Amazon.AutoScaling.IAmazonAutoScaling.PutScheduledUpdateGroupAction"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutScheduledUpdateGroupAction.</param>
        PutScheduledUpdateGroupActionResponse EndPutScheduledUpdateGroupAction(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region ResumeProcesses

        /// <summary>
        /// <para> Resumes all suspended Auto Scaling processes for an Auto Scaling group. For information on suspending and resuming Auto Scaling
        /// process, see <a href="http://docs.aws.amazon.com/AutoScaling/latest/DeveloperGuide/US_SuspendResume.html" >Suspend and Resume Auto Scaling
        /// Process</a> .
        /// </para>
        /// </summary>
        /// 
        /// <param name="resumeProcessesRequest">Container for the necessary parameters to execute the ResumeProcesses service method on
        ///          AmazonAutoScaling.</param>
        /// 
        ResumeProcessesResponse ResumeProcesses(ResumeProcessesRequest resumeProcessesRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the ResumeProcesses operation.
        /// <seealso cref="Amazon.AutoScaling.IAmazonAutoScaling.ResumeProcesses"/>
        /// </summary>
        /// 
        /// <param name="resumeProcessesRequest">Container for the necessary parameters to execute the ResumeProcesses operation on
        ///          AmazonAutoScaling.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        IAsyncResult BeginResumeProcesses(ResumeProcessesRequest resumeProcessesRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the ResumeProcesses operation.
        /// <seealso cref="Amazon.AutoScaling.IAmazonAutoScaling.ResumeProcesses"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginResumeProcesses.</param>
        ResumeProcessesResponse EndResumeProcesses(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region SetDesiredCapacity

        /// <summary>
        /// <para> Sets the desired size of the specified AutoScalingGroup. </para>
        /// </summary>
        /// 
        /// <param name="setDesiredCapacityRequest">Container for the necessary parameters to execute the SetDesiredCapacity service method on
        ///          AmazonAutoScaling.</param>
        /// 
        /// <exception cref="ScalingActivityInProgressException"/>
        SetDesiredCapacityResponse SetDesiredCapacity(SetDesiredCapacityRequest setDesiredCapacityRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the SetDesiredCapacity operation.
        /// <seealso cref="Amazon.AutoScaling.IAmazonAutoScaling.SetDesiredCapacity"/>
        /// </summary>
        /// 
        /// <param name="setDesiredCapacityRequest">Container for the necessary parameters to execute the SetDesiredCapacity operation on
        ///          AmazonAutoScaling.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        IAsyncResult BeginSetDesiredCapacity(SetDesiredCapacityRequest setDesiredCapacityRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the SetDesiredCapacity operation.
        /// <seealso cref="Amazon.AutoScaling.IAmazonAutoScaling.SetDesiredCapacity"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSetDesiredCapacity.</param>
        SetDesiredCapacityResponse EndSetDesiredCapacity(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region SetInstanceHealth

        /// <summary>
        /// <para> Sets the health status of a specified instance that belongs to any of your Auto Scaling groups. </para> <para>For more information,
        /// see <a href="http://docs.aws.amazon.com/AutoScaling/latest/DeveloperGuide/as-configure-healthcheck.html" >Configure Health Checks for Your
        /// Auto Scaling group</a> .</para>
        /// </summary>
        /// 
        /// <param name="setInstanceHealthRequest">Container for the necessary parameters to execute the SetInstanceHealth service method on
        ///          AmazonAutoScaling.</param>
        /// 
        SetInstanceHealthResponse SetInstanceHealth(SetInstanceHealthRequest setInstanceHealthRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the SetInstanceHealth operation.
        /// <seealso cref="Amazon.AutoScaling.IAmazonAutoScaling.SetInstanceHealth"/>
        /// </summary>
        /// 
        /// <param name="setInstanceHealthRequest">Container for the necessary parameters to execute the SetInstanceHealth operation on
        ///          AmazonAutoScaling.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        IAsyncResult BeginSetInstanceHealth(SetInstanceHealthRequest setInstanceHealthRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the SetInstanceHealth operation.
        /// <seealso cref="Amazon.AutoScaling.IAmazonAutoScaling.SetInstanceHealth"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSetInstanceHealth.</param>
        SetInstanceHealthResponse EndSetInstanceHealth(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region SuspendProcesses

        /// <summary>
        /// <para> Suspends Auto Scaling processes for an Auto Scaling group. To suspend specific process types, specify them by name with the
        /// <c>ScalingProcesses.member.N</c> parameter. To suspend all process types, omit the <c>ScalingProcesses.member.N</c> parameter. </para>
        /// <para><b>IMPORTANT:</b> Suspending either of the two primary process types, Launch or Terminate, can prevent other process types from
        /// functioning properly. </para> <para> To resume processes that have been suspended, use ResumeProcesses For more information on suspending
        /// and resuming Auto Scaling process, see <a href="http://docs.aws.amazon.com/AutoScaling/latest/DeveloperGuide/US_SuspendResume.html" >Suspend
        /// and Resume Auto Scaling Process</a> .
        /// </para>
        /// </summary>
        /// 
        /// <param name="suspendProcessesRequest">Container for the necessary parameters to execute the SuspendProcesses service method on
        ///          AmazonAutoScaling.</param>
        /// 
        SuspendProcessesResponse SuspendProcesses(SuspendProcessesRequest suspendProcessesRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the SuspendProcesses operation.
        /// <seealso cref="Amazon.AutoScaling.IAmazonAutoScaling.SuspendProcesses"/>
        /// </summary>
        /// 
        /// <param name="suspendProcessesRequest">Container for the necessary parameters to execute the SuspendProcesses operation on
        ///          AmazonAutoScaling.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        IAsyncResult BeginSuspendProcesses(SuspendProcessesRequest suspendProcessesRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the SuspendProcesses operation.
        /// <seealso cref="Amazon.AutoScaling.IAmazonAutoScaling.SuspendProcesses"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSuspendProcesses.</param>
        SuspendProcessesResponse EndSuspendProcesses(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region TerminateInstanceInAutoScalingGroup

        /// <summary>
        /// <para> Terminates the specified instance. Optionally, the desired group size can be adjusted. </para> <para><b>NOTE:</b> This call simply
        /// registers a termination request. The termination of the instance cannot happen immediately. </para>
        /// </summary>
        /// 
        /// <param name="terminateInstanceInAutoScalingGroupRequest">Container for the necessary parameters to execute the
        ///          TerminateInstanceInAutoScalingGroup service method on AmazonAutoScaling.</param>
        /// 
        /// <returns>The response from the TerminateInstanceInAutoScalingGroup service method, as returned by AmazonAutoScaling.</returns>
        /// 
        /// <exception cref="ScalingActivityInProgressException"/>
        TerminateInstanceInAutoScalingGroupResponse TerminateInstanceInAutoScalingGroup(TerminateInstanceInAutoScalingGroupRequest terminateInstanceInAutoScalingGroupRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the TerminateInstanceInAutoScalingGroup operation.
        /// <seealso cref="Amazon.AutoScaling.IAmazonAutoScaling.TerminateInstanceInAutoScalingGroup"/>
        /// </summary>
        /// 
        /// <param name="terminateInstanceInAutoScalingGroupRequest">Container for the necessary parameters to execute the
        ///          TerminateInstanceInAutoScalingGroup operation on AmazonAutoScaling.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndTerminateInstanceInAutoScalingGroup operation.</returns>
        IAsyncResult BeginTerminateInstanceInAutoScalingGroup(TerminateInstanceInAutoScalingGroupRequest terminateInstanceInAutoScalingGroupRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the TerminateInstanceInAutoScalingGroup operation.
        /// <seealso cref="Amazon.AutoScaling.IAmazonAutoScaling.TerminateInstanceInAutoScalingGroup"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTerminateInstanceInAutoScalingGroup.</param>
        /// 
        /// <returns>Returns a TerminateInstanceInAutoScalingGroupResult from AmazonAutoScaling.</returns>
        TerminateInstanceInAutoScalingGroupResponse EndTerminateInstanceInAutoScalingGroup(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region UpdateAutoScalingGroup

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
        /// <param name="updateAutoScalingGroupRequest">Container for the necessary parameters to execute the UpdateAutoScalingGroup service method on
        ///          AmazonAutoScaling.</param>
        /// 
        /// <exception cref="ScalingActivityInProgressException"/>
        UpdateAutoScalingGroupResponse UpdateAutoScalingGroup(UpdateAutoScalingGroupRequest updateAutoScalingGroupRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateAutoScalingGroup operation.
        /// <seealso cref="Amazon.AutoScaling.IAmazonAutoScaling.UpdateAutoScalingGroup"/>
        /// </summary>
        /// 
        /// <param name="updateAutoScalingGroupRequest">Container for the necessary parameters to execute the UpdateAutoScalingGroup operation on
        ///          AmazonAutoScaling.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        IAsyncResult BeginUpdateAutoScalingGroup(UpdateAutoScalingGroupRequest updateAutoScalingGroupRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the UpdateAutoScalingGroup operation.
        /// <seealso cref="Amazon.AutoScaling.IAmazonAutoScaling.UpdateAutoScalingGroup"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateAutoScalingGroup.</param>
        UpdateAutoScalingGroupResponse EndUpdateAutoScalingGroup(IAsyncResult asyncResult);
        
        #endregion
        
    
    }
}
    
