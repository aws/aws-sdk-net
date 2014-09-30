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
 * Do not modify this file. This file is generated from the cloudformation-2010-05-15.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.CloudFormation.Model;

namespace Amazon.CloudFormation
{
    /// <summary>
    /// Interface for accessing CloudFormation
    ///
    /// AWS CloudFormation 
    /// <para>
    /// AWS CloudFormation enables you to create and manage AWS infrastructure deployments
    /// predictably and repeatedly. AWS CloudFormation helps you leverage AWS products such
    /// as Amazon EC2, EBS, Amazon SNS, ELB, and Auto Scaling to build highly-reliable, highly
    /// scalable, cost effective applications without worrying about creating and configuring
    /// the underlying AWS infrastructure.
    /// </para>
    ///  
    /// <para>
    /// With AWS CloudFormation, you declare all of your resources and dependencies in a template
    /// file. The template defines a collection of resources as a single unit called a stack.
    /// AWS CloudFormation creates and deletes all member resources of the stack together
    /// and manages all dependencies between the resources for you.
    /// </para>
    ///  
    /// <para>
    /// For more information about this product, go to the <a href="http://aws.amazon.com/cloudformation/">CloudFormation
    /// Product Page</a>.
    /// </para>
    ///  
    /// <para>
    /// Amazon CloudFormation makes use of other AWS products. If you need additional technical
    /// information about a specific AWS product, you can find the product's technical documentation
    /// at <a href="http://aws.amazon.com/documentation/">http://aws.amazon.com/documentation/</a>.
    /// </para>
    /// </summary>
    public partial interface IAmazonCloudFormation : IDisposable
    {
                
        #region  CancelUpdateStack

        /// <summary>
        /// Initiates the asynchronous execution of the CancelUpdateStack operation.
        /// <seealso cref="Amazon.CloudFormation.IAmazonCloudFormation"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CancelUpdateStack operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<CancelUpdateStackResponse> CancelUpdateStackAsync(CancelUpdateStackRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateStack

        /// <summary>
        /// Initiates the asynchronous execution of the CreateStack operation.
        /// <seealso cref="Amazon.CloudFormation.IAmazonCloudFormation"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateStack operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<CreateStackResponse> CreateStackAsync(CreateStackRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteStack

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteStack operation.
        /// <seealso cref="Amazon.CloudFormation.IAmazonCloudFormation"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteStack operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DeleteStackResponse> DeleteStackAsync(DeleteStackRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeStackEvents

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeStackEvents operation.
        /// <seealso cref="Amazon.CloudFormation.IAmazonCloudFormation"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeStackEvents operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeStackEventsResponse> DescribeStackEventsAsync(DescribeStackEventsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeStackResource

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeStackResource operation.
        /// <seealso cref="Amazon.CloudFormation.IAmazonCloudFormation"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeStackResource operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeStackResourceResponse> DescribeStackResourceAsync(DescribeStackResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeStackResources

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeStackResources operation.
        /// <seealso cref="Amazon.CloudFormation.IAmazonCloudFormation"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeStackResources operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeStackResourcesResponse> DescribeStackResourcesAsync(DescribeStackResourcesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeStacks

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeStacks operation.
        /// <seealso cref="Amazon.CloudFormation.IAmazonCloudFormation"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeStacks operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeStacksResponse> DescribeStacksAsync(DescribeStacksRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  EstimateTemplateCost

        /// <summary>
        /// Initiates the asynchronous execution of the EstimateTemplateCost operation.
        /// <seealso cref="Amazon.CloudFormation.IAmazonCloudFormation"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the EstimateTemplateCost operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<EstimateTemplateCostResponse> EstimateTemplateCostAsync(EstimateTemplateCostRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetStackPolicy

        /// <summary>
        /// Initiates the asynchronous execution of the GetStackPolicy operation.
        /// <seealso cref="Amazon.CloudFormation.IAmazonCloudFormation"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetStackPolicy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<GetStackPolicyResponse> GetStackPolicyAsync(GetStackPolicyRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetTemplate

        /// <summary>
        /// Initiates the asynchronous execution of the GetTemplate operation.
        /// <seealso cref="Amazon.CloudFormation.IAmazonCloudFormation"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetTemplate operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<GetTemplateResponse> GetTemplateAsync(GetTemplateRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListStackResources

        /// <summary>
        /// Initiates the asynchronous execution of the ListStackResources operation.
        /// <seealso cref="Amazon.CloudFormation.IAmazonCloudFormation"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListStackResources operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<ListStackResourcesResponse> ListStackResourcesAsync(ListStackResourcesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListStacks

        /// <summary>
        /// Initiates the asynchronous execution of the ListStacks operation.
        /// <seealso cref="Amazon.CloudFormation.IAmazonCloudFormation"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListStacks operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<ListStacksResponse> ListStacksAsync(ListStacksRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  SetStackPolicy

        /// <summary>
        /// Initiates the asynchronous execution of the SetStackPolicy operation.
        /// <seealso cref="Amazon.CloudFormation.IAmazonCloudFormation"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SetStackPolicy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<SetStackPolicyResponse> SetStackPolicyAsync(SetStackPolicyRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateStack

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateStack operation.
        /// <seealso cref="Amazon.CloudFormation.IAmazonCloudFormation"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateStack operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<UpdateStackResponse> UpdateStackAsync(UpdateStackRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ValidateTemplate

        /// <summary>
        /// Initiates the asynchronous execution of the ValidateTemplate operation.
        /// <seealso cref="Amazon.CloudFormation.IAmazonCloudFormation"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ValidateTemplate operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<ValidateTemplateResponse> ValidateTemplateAsync(ValidateTemplateRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}