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

using Amazon.CloudFormation;
using Amazon.CloudFormation.Model;

namespace Amazon.CloudFormation
{
    /// <summary>
    /// Interface for accessing AmazonCloudFormation.
    ///  
    ///  AWS CloudFormation <para>This is the AWS CloudFormation API Reference. The major sections of this guide are described in the following
    /// table.</para>
    /// <ul>
    /// <li> Actions: Alphabetical list of CloudFormation actions</li>
    /// <li> Data Types: Alphabetical list of CloudFormation data types</li>
    /// <li> Common Parameters: Parameters that all Query actions can use</li>
    /// <li> Common Errors: Client and server errors that all actions can return</li>
    /// 
    /// </ul>
    /// <para>This guide is for programmers who need detailed information about the CloudFormation APIs. You use AWS CloudFormation to create and
    /// manage AWS infrastructure deployments predictably and repeatedly. CloudFormation helps you leverage AWS products such as Amazon EC2, EBS,
    /// Amazon SNS, ELB, and Auto Scaling to build highly-reliable, highly scalable, cost effective applications without worrying about creating and
    /// configuring the underlying the AWS infrastructure.</para> <para>Through the use of a template file you write, and a few AWS CloudFormation
    /// commands or API actions, AWS CloudFormation enables you to manage a collection of resources together as a single unit called a stack. AWS
    /// CloudFormation creates and deletes all member resources of the stack together and manages all dependencies between the resources for
    /// you.</para> <para>For more information about this product, go to the CloudFormation Product Page.</para> <para>Amazon CloudFormation makes
    /// use of other AWS products. If you need additional technical information about a specific AWS product, you can find the product's technical
    /// documentation at http://aws.amazon.com/documentation/.</para>
    /// </summary>
    public interface AmazonCloudFormation : IDisposable
    {
        

         /// <summary>
         /// <para> Returns the summary information for stacks whose status matches the specified StackStatusFilter. Summary information for stacks that
         /// have been deleted is kept for 90 days after the stack is deleted. If no StackStatusFilter is specified, summary information for all stacks
         /// is returned (including existing stacks and stacks that have been deleted). </para>
         /// </summary>
         /// 
         /// <param name="listStacksRequest">Container for the necessary parameters to execute the ListStacks service method on
         ///           AmazonCloudFormation.</param>
         /// 
         /// <returns>The response from the ListStacks service method, as returned by AmazonCloudFormation.</returns>
         /// 
        ListStacksResponse ListStacks(ListStacksRequest listStacksRequest); 

         /// <summary>
         /// <para> Creates a stack as specified in the template. After the call completes successfully, the stack creation starts. You can check the
         /// status of the stack via the DescribeStacks API. </para> <para><b>NOTE:</b> Currently, the limit for stacks is 20 stacks per account per
         /// region. </para>
         /// </summary>
         /// 
         /// <param name="createStackRequest">Container for the necessary parameters to execute the CreateStack service method on
         ///           AmazonCloudFormation.</param>
         /// 
         /// <returns>The response from the CreateStack service method, as returned by AmazonCloudFormation.</returns>
         /// 
         /// <exception cref="AlreadyExistsException"/>
         /// <exception cref="LimitExceededException"/>
        CreateStackResponse CreateStack(CreateStackRequest createStackRequest); 

         /// <summary>
         /// <para> Validates a specified template. </para>
         /// </summary>
         /// 
         /// <param name="validateTemplateRequest">Container for the necessary parameters to execute the ValidateTemplate service method on
         ///           AmazonCloudFormation.</param>
         /// 
         /// <returns>The response from the ValidateTemplate service method, as returned by AmazonCloudFormation.</returns>
         /// 
        ValidateTemplateResponse ValidateTemplate(ValidateTemplateRequest validateTemplateRequest); 

         /// <summary>
         /// <para> Returns the description for the specified stack; if no stack name was specified, then it returns the description for all the stacks
         /// created. </para>
         /// </summary>
         /// 
         /// <param name="describeStacksRequest">Container for the necessary parameters to execute the DescribeStacks service method on
         ///           AmazonCloudFormation.</param>
         /// 
         /// <returns>The response from the DescribeStacks service method, as returned by AmazonCloudFormation.</returns>
         /// 
        DescribeStacksResponse DescribeStacks(DescribeStacksRequest describeStacksRequest); 

         /// <summary>
         /// <para> Returns all the stack related events for the AWS account. If <c>StackName</c> is specified, returns events related to all the stacks
         /// with the given name. If <c>StackName</c> is not specified, returns all the events for the account. For more information about a stack's
         /// event history, go to the AWS CloudFormation User Guide. </para> <para><b>NOTE:</b>Events are returned, even if the stack never existed or
         /// has been successfully deleted.</para>
         /// </summary>
         /// 
         /// <param name="describeStackEventsRequest">Container for the necessary parameters to execute the DescribeStackEvents service method on
         ///           AmazonCloudFormation.</param>
         /// 
         /// <returns>The response from the DescribeStackEvents service method, as returned by AmazonCloudFormation.</returns>
         /// 
        DescribeStackEventsResponse DescribeStackEvents(DescribeStackEventsRequest describeStackEventsRequest); 

         /// <summary>
         /// <para>Returns the template body for a specified stack name. You can get the template for running or deleted stacks.</para> <para>For deleted
         /// stacks, GetTemplate returns the template for up to 90 days after the stack has been deleted. </para> <para><b>NOTE:</b> If the template does
         /// not exist, a ValidationError is returned. </para>
         /// </summary>
         /// 
         /// <param name="getTemplateRequest">Container for the necessary parameters to execute the GetTemplate service method on
         ///           AmazonCloudFormation.</param>
         /// 
         /// <returns>The response from the GetTemplate service method, as returned by AmazonCloudFormation.</returns>
         /// 
        GetTemplateResponse GetTemplate(GetTemplateRequest getTemplateRequest); 

         /// <summary>
         /// <para> Returns the description for the specified resource in the specified stack. </para> <para>For deleted stacks, DescribeStackResource
         /// returns resource information for up to 90 days after the stack has been deleted. </para> <para> You must specify <c>StackName</c> and
         /// <c>LogicalResourceId</c> .
         /// </para>
         /// </summary>
         /// 
         /// <param name="describeStackResourceRequest">Container for the necessary parameters to execute the DescribeStackResource service method on
         ///           AmazonCloudFormation.</param>
         /// 
         /// <returns>The response from the DescribeStackResource service method, as returned by AmazonCloudFormation.</returns>
         /// 
        DescribeStackResourceResponse DescribeStackResource(DescribeStackResourceRequest describeStackResourceRequest); 

         /// <summary>
         /// <para> Deletes a specified stack. Once the call completes successfully, stack deletion starts. Deleted stacks do not show up in the
         /// DescribeStacks API if the deletion has been completed successfully. </para>
         /// </summary>
         /// 
         /// <param name="deleteStackRequest">Container for the necessary parameters to execute the DeleteStack service method on
         ///           AmazonCloudFormation.</param>
         /// 
        DeleteStackResponse DeleteStack(DeleteStackRequest deleteStackRequest); 

         /// <summary>
         /// <para> Returns descriptions for all resources of the specified stack. </para> <para>For deleted stacks, ListStackResources returns resource
         /// information for up to 90 days after the stack has been deleted. </para>
         /// </summary>
         /// 
         /// <param name="listStackResourcesRequest">Container for the necessary parameters to execute the ListStackResources service method on
         ///           AmazonCloudFormation.</param>
         /// 
         /// <returns>The response from the ListStackResources service method, as returned by AmazonCloudFormation.</returns>
         /// 
        ListStackResourcesResponse ListStackResources(ListStackResourcesRequest listStackResourcesRequest); 

         /// <summary>
         /// <para> Returns AWS resource descriptions for running and deleted stacks. If <c>StackName</c> is specified, all the associated resources that
         /// are part of the stack are returned. If <c>PhysicalResourceId</c> is specified, all the associated resources of the stack the resource
         /// belongs to are returned. </para> <para>For deleted stacks, DescribeStackResources returns resource information for up to 90 days after the
         /// stack has been deleted. </para> <para> You must specify <c>StackName</c> or <c>PhysicalResourceId.</c> In addition, you can specify
         /// <c>LogicalResourceId</c> to filter the returned result. For more information about resources, the <c>LogicalResourceId</c> and
         /// <c>PhysicalResourceId</c> , go to the AWS CloudFormation User Guide. </para> <para><b>NOTE:</b> A ValidationError is returned if you specify
         /// both StackName and PhysicalResourceId in the same request. </para>
         /// </summary>
         /// 
         /// <param name="describeStackResourcesRequest">Container for the necessary parameters to execute the DescribeStackResources service method on
         ///           AmazonCloudFormation.</param>
         /// 
         /// <returns>The response from the DescribeStackResources service method, as returned by AmazonCloudFormation.</returns>
         /// 
        DescribeStackResourcesResponse DescribeStackResources(DescribeStackResourcesRequest describeStackResourcesRequest); 
    }
}
    
