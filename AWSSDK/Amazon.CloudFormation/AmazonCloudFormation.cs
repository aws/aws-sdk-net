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

using Amazon.CloudFormation;
using Amazon.CloudFormation.Model;

namespace Amazon.CloudFormation
{
    /// <summary>
    /// Interface for accessing AmazonCloudFormation.
    ///  
    ///  AWS CloudFormation <para>AWS CloudFormation enables you to create and manage AWS infrastructure deployments predictably and repeatedly. AWS
    /// CloudFormation helps you leverage AWS products such as Amazon EC2, EBS, Amazon SNS, ELB, and Auto Scaling to build highly-reliable, highly
    /// scalable, cost effective applications without worrying about creating and configuring the underlying the AWS infrastructure.</para>
    /// <para>With AWS CloudFormation, you declare all of your resources and dependencies in a template file. The template defines a collection of
    /// resources as a single unit called a stack. AWS CloudFormation creates and deletes all member resources of the stack together and manages all
    /// dependencies between the resources for you.</para> <para>For more information about this product, go to the CloudFormation Product
    /// Page.</para> <para>Amazon CloudFormation makes use of other AWS products. If you need additional technical information about a specific AWS
    /// product, you can find the product's technical documentation at http://aws.amazon.com/documentation/.</para>
    /// </summary>
    public interface AmazonCloudFormation : IDisposable
    {
        

        #region ValidateTemplate

        /// <summary>
        /// <para>Validates a specified template.</para>
        /// </summary>
        /// 
        /// <param name="validateTemplateRequest">Container for the necessary parameters to execute the ValidateTemplate service method on
        ///          AmazonCloudFormation.</param>
        /// 
        /// <returns>The response from the ValidateTemplate service method, as returned by AmazonCloudFormation.</returns>
        /// 
        ValidateTemplateResponse ValidateTemplate(ValidateTemplateRequest validateTemplateRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the ValidateTemplate operation.
        /// <seealso cref="Amazon.CloudFormation.AmazonCloudFormation.ValidateTemplate"/>
        /// </summary>
        /// 
        /// <param name="validateTemplateRequest">Container for the necessary parameters to execute the ValidateTemplate operation on
        ///          AmazonCloudFormation.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndValidateTemplate
        ///         operation.</returns>
        IAsyncResult BeginValidateTemplate(ValidateTemplateRequest validateTemplateRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the ValidateTemplate operation.
        /// <seealso cref="Amazon.CloudFormation.AmazonCloudFormation.ValidateTemplate"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginValidateTemplate.</param>
        /// 
        /// <returns>Returns a ValidateTemplateResult from AmazonCloudFormation.</returns>
        ValidateTemplateResponse EndValidateTemplate(IAsyncResult asyncResult);

        /// <summary>
        /// <para>Validates a specified template.</para>
        /// </summary>
        /// 
        /// <returns>The response from the ValidateTemplate service method, as returned by AmazonCloudFormation.</returns>
        /// 
        ValidateTemplateResponse ValidateTemplate();
        
        #endregion
        
    

        #region DescribeStacks

        /// <summary>
        /// <para>Returns the description for the specified stack; if no stack name was specified, then it returns the description for all the stacks
        /// created.</para>
        /// </summary>
        /// 
        /// <param name="describeStacksRequest">Container for the necessary parameters to execute the DescribeStacks service method on
        ///          AmazonCloudFormation.</param>
        /// 
        /// <returns>The response from the DescribeStacks service method, as returned by AmazonCloudFormation.</returns>
        /// 
        DescribeStacksResponse DescribeStacks(DescribeStacksRequest describeStacksRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeStacks operation.
        /// <seealso cref="Amazon.CloudFormation.AmazonCloudFormation.DescribeStacks"/>
        /// </summary>
        /// 
        /// <param name="describeStacksRequest">Container for the necessary parameters to execute the DescribeStacks operation on
        ///          AmazonCloudFormation.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeStacks
        ///         operation.</returns>
        IAsyncResult BeginDescribeStacks(DescribeStacksRequest describeStacksRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeStacks operation.
        /// <seealso cref="Amazon.CloudFormation.AmazonCloudFormation.DescribeStacks"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeStacks.</param>
        /// 
        /// <returns>Returns a DescribeStacksResult from AmazonCloudFormation.</returns>
        DescribeStacksResponse EndDescribeStacks(IAsyncResult asyncResult);

        /// <summary>
        /// <para>Returns the description for the specified stack; if no stack name was specified, then it returns the description for all the stacks
        /// created.</para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeStacks service method, as returned by AmazonCloudFormation.</returns>
        /// 
        DescribeStacksResponse DescribeStacks();
        
        #endregion
        
    

        #region GetTemplate

        /// <summary>
        /// <para>Returns the template body for a specified stack name. You can get the template for running or deleted stacks.</para> <para>For deleted
        /// stacks, GetTemplate returns the template for up to 90 days after the stack has been deleted.</para> <para><b>NOTE:</b> If the template does
        /// not exist, a ValidationError is returned. </para>
        /// </summary>
        /// 
        /// <param name="getTemplateRequest">Container for the necessary parameters to execute the GetTemplate service method on
        ///          AmazonCloudFormation.</param>
        /// 
        /// <returns>The response from the GetTemplate service method, as returned by AmazonCloudFormation.</returns>
        /// 
        GetTemplateResponse GetTemplate(GetTemplateRequest getTemplateRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the GetTemplate operation.
        /// <seealso cref="Amazon.CloudFormation.AmazonCloudFormation.GetTemplate"/>
        /// </summary>
        /// 
        /// <param name="getTemplateRequest">Container for the necessary parameters to execute the GetTemplate operation on
        ///          AmazonCloudFormation.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetTemplate
        ///         operation.</returns>
        IAsyncResult BeginGetTemplate(GetTemplateRequest getTemplateRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the GetTemplate operation.
        /// <seealso cref="Amazon.CloudFormation.AmazonCloudFormation.GetTemplate"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetTemplate.</param>
        /// 
        /// <returns>Returns a GetTemplateResult from AmazonCloudFormation.</returns>
        GetTemplateResponse EndGetTemplate(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region ListStacks

        /// <summary>
        /// <para>Returns the summary information for stacks whose status matches the specified StackStatusFilter. Summary information for stacks that
        /// have been deleted is kept for 90 days after the stack is deleted. If no StackStatusFilter is specified, summary information for all stacks
        /// is returned (including existing stacks and stacks that have been deleted).</para>
        /// </summary>
        /// 
        /// <param name="listStacksRequest">Container for the necessary parameters to execute the ListStacks service method on
        ///          AmazonCloudFormation.</param>
        /// 
        /// <returns>The response from the ListStacks service method, as returned by AmazonCloudFormation.</returns>
        /// 
        ListStacksResponse ListStacks(ListStacksRequest listStacksRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the ListStacks operation.
        /// <seealso cref="Amazon.CloudFormation.AmazonCloudFormation.ListStacks"/>
        /// </summary>
        /// 
        /// <param name="listStacksRequest">Container for the necessary parameters to execute the ListStacks operation on AmazonCloudFormation.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListStacks
        ///         operation.</returns>
        IAsyncResult BeginListStacks(ListStacksRequest listStacksRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the ListStacks operation.
        /// <seealso cref="Amazon.CloudFormation.AmazonCloudFormation.ListStacks"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListStacks.</param>
        /// 
        /// <returns>Returns a ListStacksResult from AmazonCloudFormation.</returns>
        ListStacksResponse EndListStacks(IAsyncResult asyncResult);

        /// <summary>
        /// <para>Returns the summary information for stacks whose status matches the specified StackStatusFilter. Summary information for stacks that
        /// have been deleted is kept for 90 days after the stack is deleted. If no StackStatusFilter is specified, summary information for all stacks
        /// is returned (including existing stacks and stacks that have been deleted).</para>
        /// </summary>
        /// 
        /// <returns>The response from the ListStacks service method, as returned by AmazonCloudFormation.</returns>
        /// 
        ListStacksResponse ListStacks();
        
        #endregion
        
    

        #region CreateStack

        /// <summary>
        /// <para>Creates a stack as specified in the template. After the call completes successfully, the stack creation starts. You can check the
        /// status of the stack via the DescribeStacks API.</para> <para><b>NOTE:</b> Currently, the limit for stacks is 20 stacks per account per
        /// region. </para>
        /// </summary>
        /// 
        /// <param name="createStackRequest">Container for the necessary parameters to execute the CreateStack service method on
        ///          AmazonCloudFormation.</param>
        /// 
        /// <returns>The response from the CreateStack service method, as returned by AmazonCloudFormation.</returns>
        /// 
        /// <exception cref="AlreadyExistsException"/>
        /// <exception cref="LimitExceededException"/>
        /// <exception cref="InsufficientCapabilitiesException"/>
        CreateStackResponse CreateStack(CreateStackRequest createStackRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateStack operation.
        /// <seealso cref="Amazon.CloudFormation.AmazonCloudFormation.CreateStack"/>
        /// </summary>
        /// 
        /// <param name="createStackRequest">Container for the necessary parameters to execute the CreateStack operation on
        ///          AmazonCloudFormation.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateStack
        ///         operation.</returns>
        IAsyncResult BeginCreateStack(CreateStackRequest createStackRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the CreateStack operation.
        /// <seealso cref="Amazon.CloudFormation.AmazonCloudFormation.CreateStack"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateStack.</param>
        /// 
        /// <returns>Returns a CreateStackResult from AmazonCloudFormation.</returns>
        CreateStackResponse EndCreateStack(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region EstimateTemplateCost

        /// <summary>
        /// <para>Returns the estimated monthly cost of a template. The return value is an AWS Simple Monthly Calculator URL with a query string that
        /// describes the resources required to run the template.</para>
        /// </summary>
        /// 
        /// <param name="estimateTemplateCostRequest">Container for the necessary parameters to execute the EstimateTemplateCost service method on
        ///          AmazonCloudFormation.</param>
        /// 
        /// <returns>The response from the EstimateTemplateCost service method, as returned by AmazonCloudFormation.</returns>
        /// 
        EstimateTemplateCostResponse EstimateTemplateCost(EstimateTemplateCostRequest estimateTemplateCostRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the EstimateTemplateCost operation.
        /// <seealso cref="Amazon.CloudFormation.AmazonCloudFormation.EstimateTemplateCost"/>
        /// </summary>
        /// 
        /// <param name="estimateTemplateCostRequest">Container for the necessary parameters to execute the EstimateTemplateCost operation on
        ///          AmazonCloudFormation.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndEstimateTemplateCost operation.</returns>
        IAsyncResult BeginEstimateTemplateCost(EstimateTemplateCostRequest estimateTemplateCostRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the EstimateTemplateCost operation.
        /// <seealso cref="Amazon.CloudFormation.AmazonCloudFormation.EstimateTemplateCost"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginEstimateTemplateCost.</param>
        /// 
        /// <returns>Returns a EstimateTemplateCostResult from AmazonCloudFormation.</returns>
        EstimateTemplateCostResponse EndEstimateTemplateCost(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region DescribeStackEvents

        /// <summary>
        /// <para>Returns all the stack related events for the AWS account. If <c>StackName</c> is specified, returns events related to all the stacks
        /// with the given name. If <c>StackName</c> is not specified, returns all the events for the account. For more information about a stack's
        /// event history, go to the AWS CloudFormation User Guide.</para> <para><b>NOTE:</b>Events are returned, even if the stack never existed or has
        /// been successfully deleted.</para>
        /// </summary>
        /// 
        /// <param name="describeStackEventsRequest">Container for the necessary parameters to execute the DescribeStackEvents service method on
        ///          AmazonCloudFormation.</param>
        /// 
        /// <returns>The response from the DescribeStackEvents service method, as returned by AmazonCloudFormation.</returns>
        /// 
        DescribeStackEventsResponse DescribeStackEvents(DescribeStackEventsRequest describeStackEventsRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeStackEvents operation.
        /// <seealso cref="Amazon.CloudFormation.AmazonCloudFormation.DescribeStackEvents"/>
        /// </summary>
        /// 
        /// <param name="describeStackEventsRequest">Container for the necessary parameters to execute the DescribeStackEvents operation on
        ///          AmazonCloudFormation.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndDescribeStackEvents operation.</returns>
        IAsyncResult BeginDescribeStackEvents(DescribeStackEventsRequest describeStackEventsRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeStackEvents operation.
        /// <seealso cref="Amazon.CloudFormation.AmazonCloudFormation.DescribeStackEvents"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeStackEvents.</param>
        /// 
        /// <returns>Returns a DescribeStackEventsResult from AmazonCloudFormation.</returns>
        DescribeStackEventsResponse EndDescribeStackEvents(IAsyncResult asyncResult);

        /// <summary>
        /// <para>Returns all the stack related events for the AWS account. If <c>StackName</c> is specified, returns events related to all the stacks
        /// with the given name. If <c>StackName</c> is not specified, returns all the events for the account. For more information about a stack's
        /// event history, go to the AWS CloudFormation User Guide.</para> <para><b>NOTE:</b>Events are returned, even if the stack never existed or has
        /// been successfully deleted.</para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeStackEvents service method, as returned by AmazonCloudFormation.</returns>
        /// 
        DescribeStackEventsResponse DescribeStackEvents();
        
        #endregion
        
    

        #region DescribeStackResource

        /// <summary>
        /// <para>Returns a description of the specified resource in the specified stack.</para> <para>For deleted stacks, DescribeStackResource returns
        /// resource information for up to 90 days after the stack has been deleted.</para>
        /// </summary>
        /// 
        /// <param name="describeStackResourceRequest">Container for the necessary parameters to execute the DescribeStackResource service method on
        ///          AmazonCloudFormation.</param>
        /// 
        /// <returns>The response from the DescribeStackResource service method, as returned by AmazonCloudFormation.</returns>
        /// 
        DescribeStackResourceResponse DescribeStackResource(DescribeStackResourceRequest describeStackResourceRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeStackResource operation.
        /// <seealso cref="Amazon.CloudFormation.AmazonCloudFormation.DescribeStackResource"/>
        /// </summary>
        /// 
        /// <param name="describeStackResourceRequest">Container for the necessary parameters to execute the DescribeStackResource operation on
        ///          AmazonCloudFormation.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndDescribeStackResource operation.</returns>
        IAsyncResult BeginDescribeStackResource(DescribeStackResourceRequest describeStackResourceRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeStackResource operation.
        /// <seealso cref="Amazon.CloudFormation.AmazonCloudFormation.DescribeStackResource"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeStackResource.</param>
        /// 
        /// <returns>Returns a DescribeStackResourceResult from AmazonCloudFormation.</returns>
        DescribeStackResourceResponse EndDescribeStackResource(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region CancelUpdateStack

        /// <summary>
        /// <para>Cancels an update on the specified stack. If the call completes successfully, the stack will roll back the update and revert to the
        /// previous stack configuration.</para> <para><b>NOTE:</b>Only stacks that are in the UPDATE_IN_PROGRESS state can be canceled.</para>
        /// </summary>
        /// 
        /// <param name="cancelUpdateStackRequest">Container for the necessary parameters to execute the CancelUpdateStack service method on
        ///          AmazonCloudFormation.</param>
        /// 
        CancelUpdateStackResponse CancelUpdateStack(CancelUpdateStackRequest cancelUpdateStackRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the CancelUpdateStack operation.
        /// <seealso cref="Amazon.CloudFormation.AmazonCloudFormation.CancelUpdateStack"/>
        /// </summary>
        /// 
        /// <param name="cancelUpdateStackRequest">Container for the necessary parameters to execute the CancelUpdateStack operation on
        ///          AmazonCloudFormation.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        IAsyncResult BeginCancelUpdateStack(CancelUpdateStackRequest cancelUpdateStackRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the CancelUpdateStack operation.
        /// <seealso cref="Amazon.CloudFormation.AmazonCloudFormation.CancelUpdateStack"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCancelUpdateStack.</param>
        CancelUpdateStackResponse EndCancelUpdateStack(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region DeleteStack

        /// <summary>
        /// <para>Deletes a specified stack. Once the call completes successfully, stack deletion starts. Deleted stacks do not show up in the
        /// DescribeStacks API if the deletion has been completed successfully.</para>
        /// </summary>
        /// 
        /// <param name="deleteStackRequest">Container for the necessary parameters to execute the DeleteStack service method on
        ///          AmazonCloudFormation.</param>
        /// 
        DeleteStackResponse DeleteStack(DeleteStackRequest deleteStackRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteStack operation.
        /// <seealso cref="Amazon.CloudFormation.AmazonCloudFormation.DeleteStack"/>
        /// </summary>
        /// 
        /// <param name="deleteStackRequest">Container for the necessary parameters to execute the DeleteStack operation on
        ///          AmazonCloudFormation.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        IAsyncResult BeginDeleteStack(DeleteStackRequest deleteStackRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the DeleteStack operation.
        /// <seealso cref="Amazon.CloudFormation.AmazonCloudFormation.DeleteStack"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteStack.</param>
        DeleteStackResponse EndDeleteStack(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region ListStackResources

        /// <summary>
        /// <para>Returns descriptions of all resources of the specified stack.</para> <para>For deleted stacks, ListStackResources returns resource
        /// information for up to 90 days after the stack has been deleted.</para>
        /// </summary>
        /// 
        /// <param name="listStackResourcesRequest">Container for the necessary parameters to execute the ListStackResources service method on
        ///          AmazonCloudFormation.</param>
        /// 
        /// <returns>The response from the ListStackResources service method, as returned by AmazonCloudFormation.</returns>
        /// 
        ListStackResourcesResponse ListStackResources(ListStackResourcesRequest listStackResourcesRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the ListStackResources operation.
        /// <seealso cref="Amazon.CloudFormation.AmazonCloudFormation.ListStackResources"/>
        /// </summary>
        /// 
        /// <param name="listStackResourcesRequest">Container for the necessary parameters to execute the ListStackResources operation on
        ///          AmazonCloudFormation.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndListStackResources operation.</returns>
        IAsyncResult BeginListStackResources(ListStackResourcesRequest listStackResourcesRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the ListStackResources operation.
        /// <seealso cref="Amazon.CloudFormation.AmazonCloudFormation.ListStackResources"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListStackResources.</param>
        /// 
        /// <returns>Returns a ListStackResourcesResult from AmazonCloudFormation.</returns>
        ListStackResourcesResponse EndListStackResources(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region DescribeStackResources

        /// <summary>
        /// <para>Returns AWS resource descriptions for running and deleted stacks. If <c>StackName</c> is specified, all the associated resources that
        /// are part of the stack are returned. If <c>PhysicalResourceId</c> is specified, the associated resources of the stack that the resource
        /// belongs to are returned.</para> <para><b>NOTE:</b>Only the first 100 resources will be returned. If your stack has more resources than this,
        /// you should use ListStackResources instead.</para> <para>For deleted stacks, <c>DescribeStackResources</c> returns resource information for
        /// up to 90 days after the stack has been deleted.</para> <para>You must specify either <c>StackName</c> or <c>PhysicalResourceId</c> , but not
        /// both. In addition, you can specify <c>LogicalResourceId</c> to filter the returned result. For more information about resources, the
        /// <c>LogicalResourceId</c> and <c>PhysicalResourceId</c> , go to the AWS CloudFormation User Guide.</para> <para><b>NOTE:</b>A ValidationError
        /// is returned if you specify both StackName and PhysicalResourceId in the same request.</para>
        /// </summary>
        /// 
        /// <param name="describeStackResourcesRequest">Container for the necessary parameters to execute the DescribeStackResources service method on
        ///          AmazonCloudFormation.</param>
        /// 
        /// <returns>The response from the DescribeStackResources service method, as returned by AmazonCloudFormation.</returns>
        /// 
        DescribeStackResourcesResponse DescribeStackResources(DescribeStackResourcesRequest describeStackResourcesRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeStackResources operation.
        /// <seealso cref="Amazon.CloudFormation.AmazonCloudFormation.DescribeStackResources"/>
        /// </summary>
        /// 
        /// <param name="describeStackResourcesRequest">Container for the necessary parameters to execute the DescribeStackResources operation on
        ///          AmazonCloudFormation.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndDescribeStackResources operation.</returns>
        IAsyncResult BeginDescribeStackResources(DescribeStackResourcesRequest describeStackResourcesRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeStackResources operation.
        /// <seealso cref="Amazon.CloudFormation.AmazonCloudFormation.DescribeStackResources"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeStackResources.</param>
        /// 
        /// <returns>Returns a DescribeStackResourcesResult from AmazonCloudFormation.</returns>
        DescribeStackResourcesResponse EndDescribeStackResources(IAsyncResult asyncResult);

        /// <summary>
        /// <para>Returns AWS resource descriptions for running and deleted stacks. If <c>StackName</c> is specified, all the associated resources that
        /// are part of the stack are returned. If <c>PhysicalResourceId</c> is specified, the associated resources of the stack that the resource
        /// belongs to are returned.</para> <para><b>NOTE:</b>Only the first 100 resources will be returned. If your stack has more resources than this,
        /// you should use ListStackResources instead.</para> <para>For deleted stacks, <c>DescribeStackResources</c> returns resource information for
        /// up to 90 days after the stack has been deleted.</para> <para>You must specify either <c>StackName</c> or <c>PhysicalResourceId</c> , but not
        /// both. In addition, you can specify <c>LogicalResourceId</c> to filter the returned result. For more information about resources, the
        /// <c>LogicalResourceId</c> and <c>PhysicalResourceId</c> , go to the AWS CloudFormation User Guide.</para> <para><b>NOTE:</b>A ValidationError
        /// is returned if you specify both StackName and PhysicalResourceId in the same request.</para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeStackResources service method, as returned by AmazonCloudFormation.</returns>
        /// 
        DescribeStackResourcesResponse DescribeStackResources();
        
        #endregion
        
    

        #region UpdateStack

        /// <summary>
        /// <para>Updates a stack as specified in the template. After the call completes successfully, the stack update starts. You can check the status
        /// of the stack via the DescribeStacks action.</para> <para>To get a copy of the template for an existing stack, you can use the GetTemplate
        /// action.</para> <para>Tags that were associated with this stack during creation time will still be associated with the stack after an
        /// <c>UpdateStack</c> operation.</para> <para>For more information about creating an update template, updating a stack, and monitoring the
        /// progress of the update, see Updating a Stack.</para>
        /// </summary>
        /// 
        /// <param name="updateStackRequest">Container for the necessary parameters to execute the UpdateStack service method on
        ///          AmazonCloudFormation.</param>
        /// 
        /// <returns>The response from the UpdateStack service method, as returned by AmazonCloudFormation.</returns>
        /// 
        /// <exception cref="InsufficientCapabilitiesException"/>
        UpdateStackResponse UpdateStack(UpdateStackRequest updateStackRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateStack operation.
        /// <seealso cref="Amazon.CloudFormation.AmazonCloudFormation.UpdateStack"/>
        /// </summary>
        /// 
        /// <param name="updateStackRequest">Container for the necessary parameters to execute the UpdateStack operation on
        ///          AmazonCloudFormation.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateStack
        ///         operation.</returns>
        IAsyncResult BeginUpdateStack(UpdateStackRequest updateStackRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the UpdateStack operation.
        /// <seealso cref="Amazon.CloudFormation.AmazonCloudFormation.UpdateStack"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateStack.</param>
        /// 
        /// <returns>Returns a UpdateStackResult from AmazonCloudFormation.</returns>
        UpdateStackResponse EndUpdateStack(IAsyncResult asyncResult);
        
        #endregion
        
    
    }
}
    
