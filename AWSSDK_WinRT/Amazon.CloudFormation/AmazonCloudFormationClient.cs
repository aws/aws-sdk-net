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

using Amazon.CloudFormation.Model;
using Amazon.CloudFormation.Model.Internal.MarshallTransformations;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.CloudFormation
{
    /// <summary>
    /// Implementation for accessing AmazonCloudFormation.
    /// 
    /// AWS CloudFormation <para>AWS CloudFormation enables you to create and manage AWS infrastructure deployments predictably and repeatedly. AWS
    /// CloudFormation helps you leverage AWS products such as Amazon EC2, EBS, Amazon SNS, ELB, and Auto Scaling to build highly-reliable, highly
    /// scalable, cost effective applications without worrying about creating and configuring the underlying the AWS infrastructure.</para>
    /// <para>With AWS CloudFormation, you declare all of your resources and dependencies in a template file. The template defines a collection of
    /// resources as a single unit called a stack. AWS CloudFormation creates and deletes all member resources of the stack together and manages all
    /// dependencies between the resources for you.</para> <para>For more information about this product, go to the <a href="http://aws.amazon.com/cloudformation/">CloudFormation Product Page</a> .</para> <para>Amazon CloudFormation makes use of other AWS
    /// products. If you need additional technical information about a specific AWS product, you can find the product's technical documentation at
    /// <a href="http://aws.amazon.com/documentation/">http://aws.amazon.com/documentation/</a> .</para> <para><b>NOTE:</b>You must call the AWS
    /// CloudFormation API as a regular IAM user. AWS CloudFormation does not support calling the API with an IAM role </para>
    /// </summary>
	public partial class AmazonCloudFormationClient : AmazonWebServiceClient, Amazon.CloudFormation.IAmazonCloudFormation
    {

        AWS4Signer signer = new AWS4Signer();
        #region Constructors

        /// <summary>
        /// Constructs AmazonCloudFormationClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonCloudFormationClient(AWSCredentials credentials)
            : this(credentials, new AmazonCloudFormationConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonCloudFormationClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonCloudFormationClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonCloudFormationConfig(){RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonCloudFormationClient with AWS Credentials and an
        /// AmazonCloudFormationClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonCloudFormationClient Configuration Object</param>
        public AmazonCloudFormationClient(AWSCredentials credentials, AmazonCloudFormationConfig clientConfig)
            : base(credentials, clientConfig, AuthenticationTypes.User | AuthenticationTypes.Session)
        {
        }

        /// <summary>
        /// Constructs AmazonCloudFormationClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonCloudFormationClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonCloudFormationConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonCloudFormationClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonCloudFormationClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonCloudFormationConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonCloudFormationClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonCloudFormationClient Configuration object. If the config object's
        /// UseSecureStringForAwsSecretKey is false, the AWS Secret Key
        /// is stored as a clear-text string. Please use this option only
        /// if the application environment doesn't allow the use of SecureStrings.
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonCloudFormationClient Configuration Object</param>
        public AmazonCloudFormationClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonCloudFormationConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig, AuthenticationTypes.User | AuthenticationTypes.Session)
        {
        }

        /// <summary>
        /// Constructs AmazonCloudFormationClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonCloudFormationClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonCloudFormationConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonCloudFormationClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonCloudFormationClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonCloudFormationConfig(){RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonCloudFormationClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonCloudFormationClient Configuration object. If the config object's
        /// UseSecureStringForAwsSecretKey is false, the AWS Secret Key
        /// is stored as a clear-text string. Please use this option only
        /// if the application environment doesn't allow the use of SecureStrings.
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonCloudFormationClient Configuration Object</param>
        public AmazonCloudFormationClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonCloudFormationConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig, AuthenticationTypes.User | AuthenticationTypes.Session)
        {
        }

        #endregion

 
		internal CancelUpdateStackResponse CancelUpdateStack(CancelUpdateStackRequest request)
        {
            var task = CancelUpdateStackAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

        /// <summary>
        /// <para>Cancels an update on the specified stack. If the call completes successfully, the stack will roll back the update and revert to the
        /// previous stack configuration.</para> <para><b>NOTE:</b>Only stacks that are in the UPDATE_IN_PROGRESS state can be canceled.</para>
        /// </summary>
        /// 
        /// <param name="cancelUpdateStackRequest">Container for the necessary parameters to execute the CancelUpdateStack service method on
        /// AmazonCloudFormation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<CancelUpdateStackResponse> CancelUpdateStackAsync(CancelUpdateStackRequest cancelUpdateStackRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CancelUpdateStackRequestMarshaller();
            var unmarshaller = CancelUpdateStackResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, CancelUpdateStackRequest, CancelUpdateStackResponse>(cancelUpdateStackRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal CreateStackResponse CreateStack(CreateStackRequest request)
        {
            var task = CreateStackAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

        /// <summary>
        /// <para>Creates a stack as specified in the template. After the call completes successfully, the stack creation starts. You can check the
        /// status of the stack via the DescribeStacks API.</para> <para><b>NOTE:</b> Currently, the limit for stacks is 20 stacks per account per
        /// region. </para>
        /// </summary>
        /// 
        /// <param name="createStackRequest">Container for the necessary parameters to execute the CreateStack service method on
        /// AmazonCloudFormation.</param>
        /// 
        /// <returns>The response from the CreateStack service method, as returned by AmazonCloudFormation.</returns>
        /// 
        /// <exception cref="T:Amazon.CloudFormation.Model.AlreadyExistsException" />
        /// <exception cref="T:Amazon.CloudFormation.Model.LimitExceededException" />
        /// <exception cref="T:Amazon.CloudFormation.Model.InsufficientCapabilitiesException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<CreateStackResponse> CreateStackAsync(CreateStackRequest createStackRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateStackRequestMarshaller();
            var unmarshaller = CreateStackResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, CreateStackRequest, CreateStackResponse>(createStackRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal DeleteStackResponse DeleteStack(DeleteStackRequest request)
        {
            var task = DeleteStackAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

        /// <summary>
        /// <para>Deletes a specified stack. Once the call completes successfully, stack deletion starts. Deleted stacks do not show up in the
        /// DescribeStacks API if the deletion has been completed successfully.</para>
        /// </summary>
        /// 
        /// <param name="deleteStackRequest">Container for the necessary parameters to execute the DeleteStack service method on
        /// AmazonCloudFormation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<DeleteStackResponse> DeleteStackAsync(DeleteStackRequest deleteStackRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteStackRequestMarshaller();
            var unmarshaller = DeleteStackResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, DeleteStackRequest, DeleteStackResponse>(deleteStackRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal DescribeStackEventsResponse DescribeStackEvents(DescribeStackEventsRequest request)
        {
            var task = DescribeStackEventsAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

        /// <summary>
        /// <para>Returns all stack related events for a specified stack. For more information about a stack's event history, go to the <a href="http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide">AWS CloudFormation User Guide</a> .</para> <para><b>NOTE:</b>Events
        /// are returned, even if the stack never existed or has been successfully deleted.</para>
        /// </summary>
        /// 
        /// <param name="describeStackEventsRequest">Container for the necessary parameters to execute the DescribeStackEvents service method on
        /// AmazonCloudFormation.</param>
        /// 
        /// <returns>The response from the DescribeStackEvents service method, as returned by AmazonCloudFormation.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<DescribeStackEventsResponse> DescribeStackEventsAsync(DescribeStackEventsRequest describeStackEventsRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeStackEventsRequestMarshaller();
            var unmarshaller = DescribeStackEventsResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, DescribeStackEventsRequest, DescribeStackEventsResponse>(describeStackEventsRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal DescribeStackResourceResponse DescribeStackResource(DescribeStackResourceRequest request)
        {
            var task = DescribeStackResourceAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

        /// <summary>
        /// <para>Returns a description of the specified resource in the specified stack.</para> <para>For deleted stacks, DescribeStackResource returns
        /// resource information for up to 90 days after the stack has been deleted.</para>
        /// </summary>
        /// 
        /// <param name="describeStackResourceRequest">Container for the necessary parameters to execute the DescribeStackResource service method on
        /// AmazonCloudFormation.</param>
        /// 
        /// <returns>The response from the DescribeStackResource service method, as returned by AmazonCloudFormation.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<DescribeStackResourceResponse> DescribeStackResourceAsync(DescribeStackResourceRequest describeStackResourceRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeStackResourceRequestMarshaller();
            var unmarshaller = DescribeStackResourceResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, DescribeStackResourceRequest, DescribeStackResourceResponse>(describeStackResourceRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal DescribeStackResourcesResponse DescribeStackResources(DescribeStackResourcesRequest request)
        {
            var task = DescribeStackResourcesAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

        /// <summary>
        /// <para>Returns AWS resource descriptions for running and deleted stacks. If <c>StackName</c> is specified, all the associated resources that
        /// are part of the stack are returned. If <c>PhysicalResourceId</c> is specified, the associated resources of the stack that the resource
        /// belongs to are returned.</para> <para><b>NOTE:</b>Only the first 100 resources will be returned. If your stack has more resources than this,
        /// you should use ListStackResources instead.</para> <para>For deleted stacks, <c>DescribeStackResources</c> returns resource information for
        /// up to 90 days after the stack has been deleted.</para> <para>You must specify either <c>StackName</c> or <c>PhysicalResourceId</c> , but not
        /// both. In addition, you can specify <c>LogicalResourceId</c> to filter the returned result. For more information about resources, the
        /// <c>LogicalResourceId</c> and <c>PhysicalResourceId</c> , go to the <a href="http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide">AWS CloudFormation User Guide</a> .</para> <para><b>NOTE:</b>A ValidationError is returned if you specify both StackName and
        /// PhysicalResourceId in the same request.</para>
        /// </summary>
        /// 
        /// <param name="describeStackResourcesRequest">Container for the necessary parameters to execute the DescribeStackResources service method on
        /// AmazonCloudFormation.</param>
        /// 
        /// <returns>The response from the DescribeStackResources service method, as returned by AmazonCloudFormation.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<DescribeStackResourcesResponse> DescribeStackResourcesAsync(DescribeStackResourcesRequest describeStackResourcesRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeStackResourcesRequestMarshaller();
            var unmarshaller = DescribeStackResourcesResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, DescribeStackResourcesRequest, DescribeStackResourcesResponse>(describeStackResourcesRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal DescribeStacksResponse DescribeStacks(DescribeStacksRequest request)
        {
            var task = DescribeStacksAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

        /// <summary>
        /// <para>Returns the description for the specified stack; if no stack name was specified, then it returns the description for all the stacks
        /// created.</para>
        /// </summary>
        /// 
        /// <param name="describeStacksRequest">Container for the necessary parameters to execute the DescribeStacks service method on
        /// AmazonCloudFormation.</param>
        /// 
        /// <returns>The response from the DescribeStacks service method, as returned by AmazonCloudFormation.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<DescribeStacksResponse> DescribeStacksAsync(DescribeStacksRequest describeStacksRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeStacksRequestMarshaller();
            var unmarshaller = DescribeStacksResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, DescribeStacksRequest, DescribeStacksResponse>(describeStacksRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal EstimateTemplateCostResponse EstimateTemplateCost(EstimateTemplateCostRequest request)
        {
            var task = EstimateTemplateCostAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

        /// <summary>
        /// <para>Returns the estimated monthly cost of a template. The return value is an AWS Simple Monthly Calculator URL with a query string that
        /// describes the resources required to run the template.</para>
        /// </summary>
        /// 
        /// <param name="estimateTemplateCostRequest">Container for the necessary parameters to execute the EstimateTemplateCost service method on
        /// AmazonCloudFormation.</param>
        /// 
        /// <returns>The response from the EstimateTemplateCost service method, as returned by AmazonCloudFormation.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<EstimateTemplateCostResponse> EstimateTemplateCostAsync(EstimateTemplateCostRequest estimateTemplateCostRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new EstimateTemplateCostRequestMarshaller();
            var unmarshaller = EstimateTemplateCostResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, EstimateTemplateCostRequest, EstimateTemplateCostResponse>(estimateTemplateCostRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal GetStackPolicyResponse GetStackPolicy(GetStackPolicyRequest request)
        {
            var task = GetStackPolicyAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

        /// <summary>
        /// <para>Returns the stack policy for a specified stack. If a stack doesn't have a policy, a null value is returned.</para>
        /// </summary>
        /// 
        /// <param name="getStackPolicyRequest">Container for the necessary parameters to execute the GetStackPolicy service method on
        /// AmazonCloudFormation.</param>
        /// 
        /// <returns>The response from the GetStackPolicy service method, as returned by AmazonCloudFormation.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<GetStackPolicyResponse> GetStackPolicyAsync(GetStackPolicyRequest getStackPolicyRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetStackPolicyRequestMarshaller();
            var unmarshaller = GetStackPolicyResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, GetStackPolicyRequest, GetStackPolicyResponse>(getStackPolicyRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal GetTemplateResponse GetTemplate(GetTemplateRequest request)
        {
            var task = GetTemplateAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

        /// <summary>
        /// <para>Returns the template body for a specified stack. You can get the template for running or deleted stacks.</para> <para>For deleted
        /// stacks, GetTemplate returns the template for up to 90 days after the stack has been deleted.</para> <para><b>NOTE:</b> If the template does
        /// not exist, a ValidationError is returned. </para>
        /// </summary>
        /// 
        /// <param name="getTemplateRequest">Container for the necessary parameters to execute the GetTemplate service method on
        /// AmazonCloudFormation.</param>
        /// 
        /// <returns>The response from the GetTemplate service method, as returned by AmazonCloudFormation.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<GetTemplateResponse> GetTemplateAsync(GetTemplateRequest getTemplateRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetTemplateRequestMarshaller();
            var unmarshaller = GetTemplateResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, GetTemplateRequest, GetTemplateResponse>(getTemplateRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal ListStackResourcesResponse ListStackResources(ListStackResourcesRequest request)
        {
            var task = ListStackResourcesAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

        /// <summary>
        /// <para>Returns descriptions of all resources of the specified stack.</para> <para>For deleted stacks, ListStackResources returns resource
        /// information for up to 90 days after the stack has been deleted.</para>
        /// </summary>
        /// 
        /// <param name="listStackResourcesRequest">Container for the necessary parameters to execute the ListStackResources service method on
        /// AmazonCloudFormation.</param>
        /// 
        /// <returns>The response from the ListStackResources service method, as returned by AmazonCloudFormation.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<ListStackResourcesResponse> ListStackResourcesAsync(ListStackResourcesRequest listStackResourcesRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListStackResourcesRequestMarshaller();
            var unmarshaller = ListStackResourcesResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, ListStackResourcesRequest, ListStackResourcesResponse>(listStackResourcesRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal ListStacksResponse ListStacks(ListStacksRequest request)
        {
            var task = ListStacksAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

        /// <summary>
        /// <para>Returns the summary information for stacks whose status matches the specified StackStatusFilter. Summary information for stacks that
        /// have been deleted is kept for 90 days after the stack is deleted. If no StackStatusFilter is specified, summary information for all stacks
        /// is returned (including existing stacks and stacks that have been deleted).</para>
        /// </summary>
        /// 
        /// <param name="listStacksRequest">Container for the necessary parameters to execute the ListStacks service method on
        /// AmazonCloudFormation.</param>
        /// 
        /// <returns>The response from the ListStacks service method, as returned by AmazonCloudFormation.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<ListStacksResponse> ListStacksAsync(ListStacksRequest listStacksRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListStacksRequestMarshaller();
            var unmarshaller = ListStacksResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, ListStacksRequest, ListStacksResponse>(listStacksRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal SetStackPolicyResponse SetStackPolicy(SetStackPolicyRequest request)
        {
            var task = SetStackPolicyAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

        /// <summary>
        /// <para>Sets a stack policy for a specified stack.</para>
        /// </summary>
        /// 
        /// <param name="setStackPolicyRequest">Container for the necessary parameters to execute the SetStackPolicy service method on
        /// AmazonCloudFormation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<SetStackPolicyResponse> SetStackPolicyAsync(SetStackPolicyRequest setStackPolicyRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new SetStackPolicyRequestMarshaller();
            var unmarshaller = SetStackPolicyResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, SetStackPolicyRequest, SetStackPolicyResponse>(setStackPolicyRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal UpdateStackResponse UpdateStack(UpdateStackRequest request)
        {
            var task = UpdateStackAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

        /// <summary>
        /// <para>Updates a stack as specified in the template. After the call completes successfully, the stack update starts. You can check the status
        /// of the stack via the DescribeStacks action.</para> <para> <b>Note: </b> You cannot update <a href="http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket.html">AWS::S3::Bucket</a> resources, for
        /// example, to add or modify tags.</para> <para>To get a copy of the template for an existing stack, you can use the GetTemplate
        /// action.</para> <para>Tags that were associated with this stack during creation time will still be associated with the stack after an
        /// <c>UpdateStack</c> operation.</para> <para>For more information about creating an update template, updating a stack, and monitoring the
        /// progress of the update, see <a href="http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/using-cfn-updating-stacks.html">Updating
        /// a Stack</a> .</para>
        /// </summary>
        /// 
        /// <param name="updateStackRequest">Container for the necessary parameters to execute the UpdateStack service method on
        /// AmazonCloudFormation.</param>
        /// 
        /// <returns>The response from the UpdateStack service method, as returned by AmazonCloudFormation.</returns>
        /// 
        /// <exception cref="T:Amazon.CloudFormation.Model.InsufficientCapabilitiesException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<UpdateStackResponse> UpdateStackAsync(UpdateStackRequest updateStackRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new UpdateStackRequestMarshaller();
            var unmarshaller = UpdateStackResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, UpdateStackRequest, UpdateStackResponse>(updateStackRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal ValidateTemplateResponse ValidateTemplate(ValidateTemplateRequest request)
        {
            var task = ValidateTemplateAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

        /// <summary>
        /// <para>Validates a specified template.</para>
        /// </summary>
        /// 
        /// <param name="validateTemplateRequest">Container for the necessary parameters to execute the ValidateTemplate service method on
        /// AmazonCloudFormation.</param>
        /// 
        /// <returns>The response from the ValidateTemplate service method, as returned by AmazonCloudFormation.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<ValidateTemplateResponse> ValidateTemplateAsync(ValidateTemplateRequest validateTemplateRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ValidateTemplateRequestMarshaller();
            var unmarshaller = ValidateTemplateResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, ValidateTemplateRequest, ValidateTemplateResponse>(validateTemplateRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
    }
}
