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

        #region Dispose

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Constructs AmazonCloudFormationClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSAccessKey" value="********************"/&gt;
        ///         &lt;add key="AWSSecretKey" value="****************************************"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        public AmazonCloudFormationClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonCloudFormationConfig(), AuthenticationTypes.User | AuthenticationTypes.Session) { }

        /// <summary>
        /// Constructs AmazonCloudFormationClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSAccessKey" value="********************"/&gt;
        ///         &lt;add key="AWSSecretKey" value="****************************************"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        /// <param name="region">The region to connect.</param>
        public AmazonCloudFormationClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonCloudFormationConfig(){RegionEndpoint = region}, AuthenticationTypes.User | AuthenticationTypes.Session) { }

        /// <summary>
        /// Constructs AmazonCloudFormationClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSAccessKey" value="********************"/&gt;
        ///         &lt;add key="AWSSecretKey" value="****************************************"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        /// <param name="config">The AmazonCloudFormation Configuration Object</param>
        public AmazonCloudFormationClient(AmazonCloudFormationConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config, AuthenticationTypes.User | AuthenticationTypes.Session) { }

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

 
        /// <summary>
        /// <para>Cancels an update on the specified stack. If the call completes successfully, the stack will roll back the update and revert to the
        /// previous stack configuration.</para> <para><b>NOTE:</b>Only stacks that are in the UPDATE_IN_PROGRESS state can be canceled.</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CancelUpdateStack service method on
        /// AmazonCloudFormation.</param>
		public CancelUpdateStackResponse CancelUpdateStack(CancelUpdateStackRequest request)
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
        /// Initiates the asynchronous execution of the CancelUpdateStack operation.
        /// <seealso cref="Amazon.CloudFormation.IAmazonCloudFormation.CancelUpdateStack"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CancelUpdateStack operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public async Task<CancelUpdateStackResponse> CancelUpdateStackAsync(CancelUpdateStackRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CancelUpdateStackRequestMarshaller();
            var unmarshaller = CancelUpdateStackResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, CancelUpdateStackRequest, CancelUpdateStackResponse>(request, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
        /// <summary>
        /// <para>Creates a stack as specified in the template. After the call completes successfully, the stack creation starts. You can check the
        /// status of the stack via the DescribeStacks API.</para> <para><b>NOTE:</b> Currently, the limit for stacks is 20 stacks per account per
        /// region. </para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateStack service method on
        /// AmazonCloudFormation.</param>
        /// 
        /// <returns>The response from the CreateStack service method, as returned by AmazonCloudFormation.</returns>
        /// 
        /// <exception cref="T:Amazon.CloudFormation.Model.AlreadyExistsException" />
        /// <exception cref="T:Amazon.CloudFormation.Model.LimitExceededException" />
        /// <exception cref="T:Amazon.CloudFormation.Model.InsufficientCapabilitiesException" />
		public CreateStackResponse CreateStack(CreateStackRequest request)
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
        /// Initiates the asynchronous execution of the CreateStack operation.
        /// <seealso cref="Amazon.CloudFormation.IAmazonCloudFormation.CreateStack"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateStack operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public async Task<CreateStackResponse> CreateStackAsync(CreateStackRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateStackRequestMarshaller();
            var unmarshaller = CreateStackResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, CreateStackRequest, CreateStackResponse>(request, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
        /// <summary>
        /// <para>Deletes a specified stack. Once the call completes successfully, stack deletion starts. Deleted stacks do not show up in the
        /// DescribeStacks API if the deletion has been completed successfully.</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteStack service method on
        /// AmazonCloudFormation.</param>
		public DeleteStackResponse DeleteStack(DeleteStackRequest request)
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
        /// Initiates the asynchronous execution of the DeleteStack operation.
        /// <seealso cref="Amazon.CloudFormation.IAmazonCloudFormation.DeleteStack"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteStack operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public async Task<DeleteStackResponse> DeleteStackAsync(DeleteStackRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteStackRequestMarshaller();
            var unmarshaller = DeleteStackResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, DeleteStackRequest, DeleteStackResponse>(request, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
        /// <summary>
        /// <para>Returns all stack related events for a specified stack. For more information about a stack's event history, go to the <a href="http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide">AWS CloudFormation User Guide</a> .</para> <para><b>NOTE:</b>Events
        /// are returned, even if the stack never existed or has been successfully deleted.</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeStackEvents service method on
        /// AmazonCloudFormation.</param>
        /// 
        /// <returns>The response from the DescribeStackEvents service method, as returned by AmazonCloudFormation.</returns>
		public DescribeStackEventsResponse DescribeStackEvents(DescribeStackEventsRequest request)
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
        /// Initiates the asynchronous execution of the DescribeStackEvents operation.
        /// <seealso cref="Amazon.CloudFormation.IAmazonCloudFormation.DescribeStackEvents"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeStackEvents operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public async Task<DescribeStackEventsResponse> DescribeStackEventsAsync(DescribeStackEventsRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeStackEventsRequestMarshaller();
            var unmarshaller = DescribeStackEventsResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, DescribeStackEventsRequest, DescribeStackEventsResponse>(request, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
        /// <summary>
        /// <para>Returns a description of the specified resource in the specified stack.</para> <para>For deleted stacks, DescribeStackResource returns
        /// resource information for up to 90 days after the stack has been deleted.</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeStackResource service method on
        /// AmazonCloudFormation.</param>
        /// 
        /// <returns>The response from the DescribeStackResource service method, as returned by AmazonCloudFormation.</returns>
		public DescribeStackResourceResponse DescribeStackResource(DescribeStackResourceRequest request)
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
        /// Initiates the asynchronous execution of the DescribeStackResource operation.
        /// <seealso cref="Amazon.CloudFormation.IAmazonCloudFormation.DescribeStackResource"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeStackResource operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public async Task<DescribeStackResourceResponse> DescribeStackResourceAsync(DescribeStackResourceRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeStackResourceRequestMarshaller();
            var unmarshaller = DescribeStackResourceResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, DescribeStackResourceRequest, DescribeStackResourceResponse>(request, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
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
        /// <param name="request">Container for the necessary parameters to execute the DescribeStackResources service method on
        /// AmazonCloudFormation.</param>
        /// 
        /// <returns>The response from the DescribeStackResources service method, as returned by AmazonCloudFormation.</returns>
		public DescribeStackResourcesResponse DescribeStackResources(DescribeStackResourcesRequest request)
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
        /// Initiates the asynchronous execution of the DescribeStackResources operation.
        /// <seealso cref="Amazon.CloudFormation.IAmazonCloudFormation.DescribeStackResources"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeStackResources operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public async Task<DescribeStackResourcesResponse> DescribeStackResourcesAsync(DescribeStackResourcesRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeStackResourcesRequestMarshaller();
            var unmarshaller = DescribeStackResourcesResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, DescribeStackResourcesRequest, DescribeStackResourcesResponse>(request, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
        /// <summary>
        /// <para>Returns the description for the specified stack; if no stack name was specified, then it returns the description for all the stacks
        /// created.</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeStacks service method on
        /// AmazonCloudFormation.</param>
        /// 
        /// <returns>The response from the DescribeStacks service method, as returned by AmazonCloudFormation.</returns>
		public DescribeStacksResponse DescribeStacks(DescribeStacksRequest request)
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
        /// Initiates the asynchronous execution of the DescribeStacks operation.
        /// <seealso cref="Amazon.CloudFormation.IAmazonCloudFormation.DescribeStacks"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeStacks operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public async Task<DescribeStacksResponse> DescribeStacksAsync(DescribeStacksRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeStacksRequestMarshaller();
            var unmarshaller = DescribeStacksResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, DescribeStacksRequest, DescribeStacksResponse>(request, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
        /// <summary>
        /// <para>Returns the description for the specified stack; if no stack name was specified, then it returns the description for all the stacks
        /// created.</para>
        /// </summary>
        /// 
        /// 
        /// <returns>The response from the DescribeStacks service method, as returned by AmazonCloudFormation.</returns>
		public DescribeStacksResponse DescribeStacks()
        {
            return this.DescribeStacks(new DescribeStacksRequest());
        }
 
        /// <summary>
        /// <para>Returns the estimated monthly cost of a template. The return value is an AWS Simple Monthly Calculator URL with a query string that
        /// describes the resources required to run the template.</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the EstimateTemplateCost service method on
        /// AmazonCloudFormation.</param>
        /// 
        /// <returns>The response from the EstimateTemplateCost service method, as returned by AmazonCloudFormation.</returns>
		public EstimateTemplateCostResponse EstimateTemplateCost(EstimateTemplateCostRequest request)
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
        /// Initiates the asynchronous execution of the EstimateTemplateCost operation.
        /// <seealso cref="Amazon.CloudFormation.IAmazonCloudFormation.EstimateTemplateCost"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the EstimateTemplateCost operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public async Task<EstimateTemplateCostResponse> EstimateTemplateCostAsync(EstimateTemplateCostRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new EstimateTemplateCostRequestMarshaller();
            var unmarshaller = EstimateTemplateCostResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, EstimateTemplateCostRequest, EstimateTemplateCostResponse>(request, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
        /// <summary>
        /// <para>Returns the stack policy for a specified stack. If a stack doesn't have a policy, a null value is returned.</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetStackPolicy service method on
        /// AmazonCloudFormation.</param>
        /// 
        /// <returns>The response from the GetStackPolicy service method, as returned by AmazonCloudFormation.</returns>
		public GetStackPolicyResponse GetStackPolicy(GetStackPolicyRequest request)
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
        /// Initiates the asynchronous execution of the GetStackPolicy operation.
        /// <seealso cref="Amazon.CloudFormation.IAmazonCloudFormation.GetStackPolicy"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetStackPolicy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public async Task<GetStackPolicyResponse> GetStackPolicyAsync(GetStackPolicyRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetStackPolicyRequestMarshaller();
            var unmarshaller = GetStackPolicyResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, GetStackPolicyRequest, GetStackPolicyResponse>(request, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
        /// <summary>
        /// <para>Returns the template body for a specified stack. You can get the template for running or deleted stacks.</para> <para>For deleted
        /// stacks, GetTemplate returns the template for up to 90 days after the stack has been deleted.</para> <para><b>NOTE:</b> If the template does
        /// not exist, a ValidationError is returned. </para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetTemplate service method on
        /// AmazonCloudFormation.</param>
        /// 
        /// <returns>The response from the GetTemplate service method, as returned by AmazonCloudFormation.</returns>
		public GetTemplateResponse GetTemplate(GetTemplateRequest request)
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
        /// Initiates the asynchronous execution of the GetTemplate operation.
        /// <seealso cref="Amazon.CloudFormation.IAmazonCloudFormation.GetTemplate"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetTemplate operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public async Task<GetTemplateResponse> GetTemplateAsync(GetTemplateRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetTemplateRequestMarshaller();
            var unmarshaller = GetTemplateResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, GetTemplateRequest, GetTemplateResponse>(request, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
        /// <summary>
        /// <para>Returns descriptions of all resources of the specified stack.</para> <para>For deleted stacks, ListStackResources returns resource
        /// information for up to 90 days after the stack has been deleted.</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListStackResources service method on
        /// AmazonCloudFormation.</param>
        /// 
        /// <returns>The response from the ListStackResources service method, as returned by AmazonCloudFormation.</returns>
		public ListStackResourcesResponse ListStackResources(ListStackResourcesRequest request)
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
        /// Initiates the asynchronous execution of the ListStackResources operation.
        /// <seealso cref="Amazon.CloudFormation.IAmazonCloudFormation.ListStackResources"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListStackResources operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public async Task<ListStackResourcesResponse> ListStackResourcesAsync(ListStackResourcesRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListStackResourcesRequestMarshaller();
            var unmarshaller = ListStackResourcesResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, ListStackResourcesRequest, ListStackResourcesResponse>(request, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
        /// <summary>
        /// <para>Returns the summary information for stacks whose status matches the specified StackStatusFilter. Summary information for stacks that
        /// have been deleted is kept for 90 days after the stack is deleted. If no StackStatusFilter is specified, summary information for all stacks
        /// is returned (including existing stacks and stacks that have been deleted).</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListStacks service method on
        /// AmazonCloudFormation.</param>
        /// 
        /// <returns>The response from the ListStacks service method, as returned by AmazonCloudFormation.</returns>
		public ListStacksResponse ListStacks(ListStacksRequest request)
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
        /// Initiates the asynchronous execution of the ListStacks operation.
        /// <seealso cref="Amazon.CloudFormation.IAmazonCloudFormation.ListStacks"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListStacks operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public async Task<ListStacksResponse> ListStacksAsync(ListStacksRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListStacksRequestMarshaller();
            var unmarshaller = ListStacksResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, ListStacksRequest, ListStacksResponse>(request, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
        /// <summary>
        /// <para>Returns the summary information for stacks whose status matches the specified StackStatusFilter. Summary information for stacks that
        /// have been deleted is kept for 90 days after the stack is deleted. If no StackStatusFilter is specified, summary information for all stacks
        /// is returned (including existing stacks and stacks that have been deleted).</para>
        /// </summary>
        /// 
        /// 
        /// <returns>The response from the ListStacks service method, as returned by AmazonCloudFormation.</returns>
		public ListStacksResponse ListStacks()
        {
            return this.ListStacks(new ListStacksRequest());
        }
 
        /// <summary>
        /// <para>Sets a stack policy for a specified stack.</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SetStackPolicy service method on
        /// AmazonCloudFormation.</param>
		public SetStackPolicyResponse SetStackPolicy(SetStackPolicyRequest request)
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
        /// Initiates the asynchronous execution of the SetStackPolicy operation.
        /// <seealso cref="Amazon.CloudFormation.IAmazonCloudFormation.SetStackPolicy"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SetStackPolicy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public async Task<SetStackPolicyResponse> SetStackPolicyAsync(SetStackPolicyRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new SetStackPolicyRequestMarshaller();
            var unmarshaller = SetStackPolicyResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, SetStackPolicyRequest, SetStackPolicyResponse>(request, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
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
        /// <param name="request">Container for the necessary parameters to execute the UpdateStack service method on
        /// AmazonCloudFormation.</param>
        /// 
        /// <returns>The response from the UpdateStack service method, as returned by AmazonCloudFormation.</returns>
        /// 
        /// <exception cref="T:Amazon.CloudFormation.Model.InsufficientCapabilitiesException" />
		public UpdateStackResponse UpdateStack(UpdateStackRequest request)
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
        /// Initiates the asynchronous execution of the UpdateStack operation.
        /// <seealso cref="Amazon.CloudFormation.IAmazonCloudFormation.UpdateStack"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateStack operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public async Task<UpdateStackResponse> UpdateStackAsync(UpdateStackRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new UpdateStackRequestMarshaller();
            var unmarshaller = UpdateStackResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, UpdateStackRequest, UpdateStackResponse>(request, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
        /// <summary>
        /// <para>Validates a specified template.</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ValidateTemplate service method on
        /// AmazonCloudFormation.</param>
        /// 
        /// <returns>The response from the ValidateTemplate service method, as returned by AmazonCloudFormation.</returns>
		public ValidateTemplateResponse ValidateTemplate(ValidateTemplateRequest request)
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
        /// Initiates the asynchronous execution of the ValidateTemplate operation.
        /// <seealso cref="Amazon.CloudFormation.IAmazonCloudFormation.ValidateTemplate"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ValidateTemplate operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public async Task<ValidateTemplateResponse> ValidateTemplateAsync(ValidateTemplateRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ValidateTemplateRequestMarshaller();
            var unmarshaller = ValidateTemplateResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, ValidateTemplateRequest, ValidateTemplateResponse>(request, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
        /// <summary>
        /// <para>Validates a specified template.</para>
        /// </summary>
        /// 
        /// 
        /// <returns>The response from the ValidateTemplate service method, as returned by AmazonCloudFormation.</returns>
		public ValidateTemplateResponse ValidateTemplate()
        {
            return this.ValidateTemplate(new ValidateTemplateRequest());
        }
    }
}
