/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.CloudFormation.Model;
using Amazon.CloudFormation.Model.Internal.MarshallTransformations;
using Amazon.CloudFormation.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.CloudFormation
{
    /// <summary>
    /// Implementation for accessing CloudFormation
    ///
    /// AWS CloudFormation 
    /// <para>
    /// AWS CloudFormation allows you to create and manage AWS infrastructure deployments
    /// predictably and repeatedly. You can use AWS CloudFormation to leverage AWS products,
    /// such as Amazon Elastic Compute Cloud, Amazon Elastic Block Store, Amazon Simple Notification
    /// Service, Elastic Load Balancing, and Auto Scaling to build highly-reliable, highly
    /// scalable, cost-effective applications without creating or configuring the underlying
    /// AWS infrastructure.
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
    /// For more information about AWS CloudFormation, see the <a href="http://aws.amazon.com/cloudformation/">AWS
    /// CloudFormation Product Page</a>.
    /// </para>
    ///  
    /// <para>
    /// Amazon CloudFormation makes use of other AWS products. If you need additional technical
    /// information about a specific AWS product, you can find the product's technical documentation
    /// at <a href="https://docs.aws.amazon.com/">docs.aws.amazon.com</a>.
    /// </para>
    /// </summary>
    public partial class AmazonCloudFormationClient : AmazonServiceClient, IAmazonCloudFormation
    {
        private static IServiceMetadata serviceMetadata = new AmazonCloudFormationMetadata();
        private ICloudFormationPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public ICloudFormationPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new CloudFormationPaginatorFactory(this);
                }
                return this._paginators;
            }
        }
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
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        public AmazonCloudFormationClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonCloudFormationConfig()) { }

        /// <summary>
        /// Constructs AmazonCloudFormationClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        /// <param name="region">The region to connect.</param>
        public AmazonCloudFormationClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonCloudFormationConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonCloudFormationClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        /// <param name="config">The AmazonCloudFormationClient Configuration Object</param>
        public AmazonCloudFormationClient(AmazonCloudFormationConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

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
            : this(credentials, new AmazonCloudFormationConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonCloudFormationClient with AWS Credentials and an
        /// AmazonCloudFormationClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonCloudFormationClient Configuration Object</param>
        public AmazonCloudFormationClient(AWSCredentials credentials, AmazonCloudFormationConfig clientConfig)
            : base(credentials, clientConfig)
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
        /// AmazonCloudFormationClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonCloudFormationClient Configuration Object</param>
        public AmazonCloudFormationClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonCloudFormationConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
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
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonCloudFormationConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonCloudFormationClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonCloudFormationClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonCloudFormationClient Configuration Object</param>
        public AmazonCloudFormationClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonCloudFormationConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion

        #region Overrides

        /// <summary>
        /// Creates the signer for the service.
        /// </summary>
        protected override AbstractAWSSigner CreateSigner()
        {
            return new AWS4Signer();
        }    

        /// <summary>
        /// Customize the pipeline
        /// </summary>
        /// <param name="pipeline"></param>
        protected override void CustomizeRuntimePipeline(RuntimePipeline pipeline)
        {
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new Amazon.CloudFormation.Internal.ProcessRequestHandler());
        }    
        /// <summary>
        /// Capture metadata for the service.
        /// </summary>
        protected override IServiceMetadata ServiceMetadata
        {
            get
            {
                return serviceMetadata;
            }
        }

        #endregion

        #region Dispose

        /// <summary>
        /// Disposes the service client.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        #endregion


        #region  CancelUpdateStack


        /// <summary>
        /// Cancels an update on the specified stack. If the call completes successfully, the
        /// stack rolls back the update and reverts to the previous stack configuration.
        /// 
        ///  <note> 
        /// <para>
        /// You can cancel only stacks that are in the UPDATE_IN_PROGRESS state.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelUpdateStack service method.</param>
        /// 
        /// <returns>The response from the CancelUpdateStack service method, as returned by CloudFormation.</returns>
        /// <exception cref="Amazon.CloudFormation.Model.TokenAlreadyExistsException">
        /// A client request token already exists.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/CancelUpdateStack">REST API Reference for CancelUpdateStack Operation</seealso>
        public virtual CancelUpdateStackResponse CancelUpdateStack(CancelUpdateStackRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CancelUpdateStackRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelUpdateStackResponseUnmarshaller.Instance;

            return Invoke<CancelUpdateStackResponse>(request, options);
        }


        /// <summary>
        /// Cancels an update on the specified stack. If the call completes successfully, the
        /// stack rolls back the update and reverts to the previous stack configuration.
        /// 
        ///  <note> 
        /// <para>
        /// You can cancel only stacks that are in the UPDATE_IN_PROGRESS state.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelUpdateStack service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CancelUpdateStack service method, as returned by CloudFormation.</returns>
        /// <exception cref="Amazon.CloudFormation.Model.TokenAlreadyExistsException">
        /// A client request token already exists.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/CancelUpdateStack">REST API Reference for CancelUpdateStack Operation</seealso>
        public virtual Task<CancelUpdateStackResponse> CancelUpdateStackAsync(CancelUpdateStackRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CancelUpdateStackRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelUpdateStackResponseUnmarshaller.Instance;
            
            return InvokeAsync<CancelUpdateStackResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ContinueUpdateRollback


        /// <summary>
        /// For a specified stack that is in the <code>UPDATE_ROLLBACK_FAILED</code> state, continues
        /// rolling it back to the <code>UPDATE_ROLLBACK_COMPLETE</code> state. Depending on the
        /// cause of the failure, you can manually <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/troubleshooting.html#troubleshooting-errors-update-rollback-failed">
        /// fix the error</a> and continue the rollback. By continuing the rollback, you can return
        /// your stack to a working state (the <code>UPDATE_ROLLBACK_COMPLETE</code> state), and
        /// then try to update the stack again.
        /// 
        ///  
        /// <para>
        /// A stack goes into the <code>UPDATE_ROLLBACK_FAILED</code> state when AWS CloudFormation
        /// cannot roll back all changes after a failed stack update. For example, you might have
        /// a stack that is rolling back to an old database instance that was deleted outside
        /// of AWS CloudFormation. Because AWS CloudFormation doesn't know the database was deleted,
        /// it assumes that the database instance still exists and attempts to roll back to it,
        /// causing the update rollback to fail.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ContinueUpdateRollback service method.</param>
        /// 
        /// <returns>The response from the ContinueUpdateRollback service method, as returned by CloudFormation.</returns>
        /// <exception cref="Amazon.CloudFormation.Model.TokenAlreadyExistsException">
        /// A client request token already exists.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/ContinueUpdateRollback">REST API Reference for ContinueUpdateRollback Operation</seealso>
        public virtual ContinueUpdateRollbackResponse ContinueUpdateRollback(ContinueUpdateRollbackRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ContinueUpdateRollbackRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ContinueUpdateRollbackResponseUnmarshaller.Instance;

            return Invoke<ContinueUpdateRollbackResponse>(request, options);
        }


        /// <summary>
        /// For a specified stack that is in the <code>UPDATE_ROLLBACK_FAILED</code> state, continues
        /// rolling it back to the <code>UPDATE_ROLLBACK_COMPLETE</code> state. Depending on the
        /// cause of the failure, you can manually <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/troubleshooting.html#troubleshooting-errors-update-rollback-failed">
        /// fix the error</a> and continue the rollback. By continuing the rollback, you can return
        /// your stack to a working state (the <code>UPDATE_ROLLBACK_COMPLETE</code> state), and
        /// then try to update the stack again.
        /// 
        ///  
        /// <para>
        /// A stack goes into the <code>UPDATE_ROLLBACK_FAILED</code> state when AWS CloudFormation
        /// cannot roll back all changes after a failed stack update. For example, you might have
        /// a stack that is rolling back to an old database instance that was deleted outside
        /// of AWS CloudFormation. Because AWS CloudFormation doesn't know the database was deleted,
        /// it assumes that the database instance still exists and attempts to roll back to it,
        /// causing the update rollback to fail.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ContinueUpdateRollback service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ContinueUpdateRollback service method, as returned by CloudFormation.</returns>
        /// <exception cref="Amazon.CloudFormation.Model.TokenAlreadyExistsException">
        /// A client request token already exists.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/ContinueUpdateRollback">REST API Reference for ContinueUpdateRollback Operation</seealso>
        public virtual Task<ContinueUpdateRollbackResponse> ContinueUpdateRollbackAsync(ContinueUpdateRollbackRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ContinueUpdateRollbackRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ContinueUpdateRollbackResponseUnmarshaller.Instance;
            
            return InvokeAsync<ContinueUpdateRollbackResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateChangeSet


        /// <summary>
        /// Creates a list of changes that will be applied to a stack so that you can review the
        /// changes before executing them. You can create a change set for a stack that doesn't
        /// exist or an existing stack. If you create a change set for a stack that doesn't exist,
        /// the change set shows all of the resources that AWS CloudFormation will create. If
        /// you create a change set for an existing stack, AWS CloudFormation compares the stack's
        /// information with the information that you submit in the change set and lists the differences.
        /// Use change sets to understand which resources AWS CloudFormation will create or change,
        /// and how it will change resources in an existing stack, before you create or update
        /// a stack.
        /// 
        ///  
        /// <para>
        /// To create a change set for a stack that doesn't exist, for the <code>ChangeSetType</code>
        /// parameter, specify <code>CREATE</code>. To create a change set for an existing stack,
        /// specify <code>UPDATE</code> for the <code>ChangeSetType</code> parameter. To create
        /// a change set for an import operation, specify <code>IMPORT</code> for the <code>ChangeSetType</code>
        /// parameter. After the <code>CreateChangeSet</code> call successfully completes, AWS
        /// CloudFormation starts creating the change set. To check the status of the change set
        /// or to review it, use the <a>DescribeChangeSet</a> action.
        /// </para>
        ///  
        /// <para>
        /// When you are satisfied with the changes the change set will make, execute the change
        /// set by using the <a>ExecuteChangeSet</a> action. AWS CloudFormation doesn't make changes
        /// until you execute the change set.
        /// </para>
        ///  
        /// <para>
        /// To create a change set for the entire stack hierachy, set <code>IncludeNestedStacks</code>
        /// to <code>True</code>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateChangeSet service method.</param>
        /// 
        /// <returns>The response from the CreateChangeSet service method, as returned by CloudFormation.</returns>
        /// <exception cref="Amazon.CloudFormation.Model.AlreadyExistsException">
        /// The resource with the name requested already exists.
        /// </exception>
        /// <exception cref="Amazon.CloudFormation.Model.InsufficientCapabilitiesException">
        /// The template contains resources with capabilities that weren't specified in the Capabilities
        /// parameter.
        /// </exception>
        /// <exception cref="Amazon.CloudFormation.Model.LimitExceededException">
        /// The quota for the resource has already been reached.
        /// 
        ///  
        /// <para>
        /// For information on resource and stack limitations, see <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/cloudformation-limits.html">Limits</a>
        /// in the <i>AWS CloudFormation User Guide</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/CreateChangeSet">REST API Reference for CreateChangeSet Operation</seealso>
        public virtual CreateChangeSetResponse CreateChangeSet(CreateChangeSetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateChangeSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateChangeSetResponseUnmarshaller.Instance;

            return Invoke<CreateChangeSetResponse>(request, options);
        }


        /// <summary>
        /// Creates a list of changes that will be applied to a stack so that you can review the
        /// changes before executing them. You can create a change set for a stack that doesn't
        /// exist or an existing stack. If you create a change set for a stack that doesn't exist,
        /// the change set shows all of the resources that AWS CloudFormation will create. If
        /// you create a change set for an existing stack, AWS CloudFormation compares the stack's
        /// information with the information that you submit in the change set and lists the differences.
        /// Use change sets to understand which resources AWS CloudFormation will create or change,
        /// and how it will change resources in an existing stack, before you create or update
        /// a stack.
        /// 
        ///  
        /// <para>
        /// To create a change set for a stack that doesn't exist, for the <code>ChangeSetType</code>
        /// parameter, specify <code>CREATE</code>. To create a change set for an existing stack,
        /// specify <code>UPDATE</code> for the <code>ChangeSetType</code> parameter. To create
        /// a change set for an import operation, specify <code>IMPORT</code> for the <code>ChangeSetType</code>
        /// parameter. After the <code>CreateChangeSet</code> call successfully completes, AWS
        /// CloudFormation starts creating the change set. To check the status of the change set
        /// or to review it, use the <a>DescribeChangeSet</a> action.
        /// </para>
        ///  
        /// <para>
        /// When you are satisfied with the changes the change set will make, execute the change
        /// set by using the <a>ExecuteChangeSet</a> action. AWS CloudFormation doesn't make changes
        /// until you execute the change set.
        /// </para>
        ///  
        /// <para>
        /// To create a change set for the entire stack hierachy, set <code>IncludeNestedStacks</code>
        /// to <code>True</code>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateChangeSet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateChangeSet service method, as returned by CloudFormation.</returns>
        /// <exception cref="Amazon.CloudFormation.Model.AlreadyExistsException">
        /// The resource with the name requested already exists.
        /// </exception>
        /// <exception cref="Amazon.CloudFormation.Model.InsufficientCapabilitiesException">
        /// The template contains resources with capabilities that weren't specified in the Capabilities
        /// parameter.
        /// </exception>
        /// <exception cref="Amazon.CloudFormation.Model.LimitExceededException">
        /// The quota for the resource has already been reached.
        /// 
        ///  
        /// <para>
        /// For information on resource and stack limitations, see <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/cloudformation-limits.html">Limits</a>
        /// in the <i>AWS CloudFormation User Guide</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/CreateChangeSet">REST API Reference for CreateChangeSet Operation</seealso>
        public virtual Task<CreateChangeSetResponse> CreateChangeSetAsync(CreateChangeSetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateChangeSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateChangeSetResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateChangeSetResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateStack


        /// <summary>
        /// Creates a stack as specified in the template. After the call completes successfully,
        /// the stack creation starts. You can check the status of the stack via the <a>DescribeStacks</a>
        /// API.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateStack service method.</param>
        /// 
        /// <returns>The response from the CreateStack service method, as returned by CloudFormation.</returns>
        /// <exception cref="Amazon.CloudFormation.Model.AlreadyExistsException">
        /// The resource with the name requested already exists.
        /// </exception>
        /// <exception cref="Amazon.CloudFormation.Model.InsufficientCapabilitiesException">
        /// The template contains resources with capabilities that weren't specified in the Capabilities
        /// parameter.
        /// </exception>
        /// <exception cref="Amazon.CloudFormation.Model.LimitExceededException">
        /// The quota for the resource has already been reached.
        /// 
        ///  
        /// <para>
        /// For information on resource and stack limitations, see <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/cloudformation-limits.html">Limits</a>
        /// in the <i>AWS CloudFormation User Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.CloudFormation.Model.TokenAlreadyExistsException">
        /// A client request token already exists.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/CreateStack">REST API Reference for CreateStack Operation</seealso>
        public virtual CreateStackResponse CreateStack(CreateStackRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateStackRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateStackResponseUnmarshaller.Instance;

            return Invoke<CreateStackResponse>(request, options);
        }


        /// <summary>
        /// Creates a stack as specified in the template. After the call completes successfully,
        /// the stack creation starts. You can check the status of the stack via the <a>DescribeStacks</a>
        /// API.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateStack service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateStack service method, as returned by CloudFormation.</returns>
        /// <exception cref="Amazon.CloudFormation.Model.AlreadyExistsException">
        /// The resource with the name requested already exists.
        /// </exception>
        /// <exception cref="Amazon.CloudFormation.Model.InsufficientCapabilitiesException">
        /// The template contains resources with capabilities that weren't specified in the Capabilities
        /// parameter.
        /// </exception>
        /// <exception cref="Amazon.CloudFormation.Model.LimitExceededException">
        /// The quota for the resource has already been reached.
        /// 
        ///  
        /// <para>
        /// For information on resource and stack limitations, see <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/cloudformation-limits.html">Limits</a>
        /// in the <i>AWS CloudFormation User Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.CloudFormation.Model.TokenAlreadyExistsException">
        /// A client request token already exists.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/CreateStack">REST API Reference for CreateStack Operation</seealso>
        public virtual Task<CreateStackResponse> CreateStackAsync(CreateStackRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateStackRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateStackResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateStackResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateStackInstances


        /// <summary>
        /// Creates stack instances for the specified accounts, within the specified Regions.
        /// A stack instance refers to a stack in a specific account and Region. You must specify
        /// at least one value for either <code>Accounts</code> or <code>DeploymentTargets</code>,
        /// and you must specify at least one value for <code>Regions</code>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateStackInstances service method.</param>
        /// 
        /// <returns>The response from the CreateStackInstances service method, as returned by CloudFormation.</returns>
        /// <exception cref="Amazon.CloudFormation.Model.InvalidOperationException">
        /// The specified operation isn't valid.
        /// </exception>
        /// <exception cref="Amazon.CloudFormation.Model.LimitExceededException">
        /// The quota for the resource has already been reached.
        /// 
        ///  
        /// <para>
        /// For information on resource and stack limitations, see <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/cloudformation-limits.html">Limits</a>
        /// in the <i>AWS CloudFormation User Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.CloudFormation.Model.OperationIdAlreadyExistsException">
        /// The specified operation ID already exists.
        /// </exception>
        /// <exception cref="Amazon.CloudFormation.Model.OperationInProgressException">
        /// Another operation is currently in progress for this stack set. Only one operation
        /// can be performed for a stack set at a given time.
        /// </exception>
        /// <exception cref="Amazon.CloudFormation.Model.StackSetNotFoundException">
        /// The specified stack set doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFormation.Model.StaleRequestException">
        /// Another operation has been performed on this stack set since the specified operation
        /// was performed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/CreateStackInstances">REST API Reference for CreateStackInstances Operation</seealso>
        public virtual CreateStackInstancesResponse CreateStackInstances(CreateStackInstancesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateStackInstancesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateStackInstancesResponseUnmarshaller.Instance;

            return Invoke<CreateStackInstancesResponse>(request, options);
        }


        /// <summary>
        /// Creates stack instances for the specified accounts, within the specified Regions.
        /// A stack instance refers to a stack in a specific account and Region. You must specify
        /// at least one value for either <code>Accounts</code> or <code>DeploymentTargets</code>,
        /// and you must specify at least one value for <code>Regions</code>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateStackInstances service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateStackInstances service method, as returned by CloudFormation.</returns>
        /// <exception cref="Amazon.CloudFormation.Model.InvalidOperationException">
        /// The specified operation isn't valid.
        /// </exception>
        /// <exception cref="Amazon.CloudFormation.Model.LimitExceededException">
        /// The quota for the resource has already been reached.
        /// 
        ///  
        /// <para>
        /// For information on resource and stack limitations, see <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/cloudformation-limits.html">Limits</a>
        /// in the <i>AWS CloudFormation User Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.CloudFormation.Model.OperationIdAlreadyExistsException">
        /// The specified operation ID already exists.
        /// </exception>
        /// <exception cref="Amazon.CloudFormation.Model.OperationInProgressException">
        /// Another operation is currently in progress for this stack set. Only one operation
        /// can be performed for a stack set at a given time.
        /// </exception>
        /// <exception cref="Amazon.CloudFormation.Model.StackSetNotFoundException">
        /// The specified stack set doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFormation.Model.StaleRequestException">
        /// Another operation has been performed on this stack set since the specified operation
        /// was performed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/CreateStackInstances">REST API Reference for CreateStackInstances Operation</seealso>
        public virtual Task<CreateStackInstancesResponse> CreateStackInstancesAsync(CreateStackInstancesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateStackInstancesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateStackInstancesResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateStackInstancesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateStackSet


        /// <summary>
        /// Creates a stack set.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateStackSet service method.</param>
        /// 
        /// <returns>The response from the CreateStackSet service method, as returned by CloudFormation.</returns>
        /// <exception cref="Amazon.CloudFormation.Model.CreatedButModifiedException">
        /// The specified resource exists, but has been changed.
        /// </exception>
        /// <exception cref="Amazon.CloudFormation.Model.LimitExceededException">
        /// The quota for the resource has already been reached.
        /// 
        ///  
        /// <para>
        /// For information on resource and stack limitations, see <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/cloudformation-limits.html">Limits</a>
        /// in the <i>AWS CloudFormation User Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.CloudFormation.Model.NameAlreadyExistsException">
        /// The specified name is already in use.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/CreateStackSet">REST API Reference for CreateStackSet Operation</seealso>
        public virtual CreateStackSetResponse CreateStackSet(CreateStackSetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateStackSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateStackSetResponseUnmarshaller.Instance;

            return Invoke<CreateStackSetResponse>(request, options);
        }


        /// <summary>
        /// Creates a stack set.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateStackSet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateStackSet service method, as returned by CloudFormation.</returns>
        /// <exception cref="Amazon.CloudFormation.Model.CreatedButModifiedException">
        /// The specified resource exists, but has been changed.
        /// </exception>
        /// <exception cref="Amazon.CloudFormation.Model.LimitExceededException">
        /// The quota for the resource has already been reached.
        /// 
        ///  
        /// <para>
        /// For information on resource and stack limitations, see <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/cloudformation-limits.html">Limits</a>
        /// in the <i>AWS CloudFormation User Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.CloudFormation.Model.NameAlreadyExistsException">
        /// The specified name is already in use.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/CreateStackSet">REST API Reference for CreateStackSet Operation</seealso>
        public virtual Task<CreateStackSetResponse> CreateStackSetAsync(CreateStackSetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateStackSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateStackSetResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateStackSetResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteChangeSet


        /// <summary>
        /// Deletes the specified change set. Deleting change sets ensures that no one executes
        /// the wrong change set.
        /// 
        ///  
        /// <para>
        /// If the call successfully completes, AWS CloudFormation successfully deleted the change
        /// set.
        /// </para>
        ///  
        /// <para>
        /// If <code>IncludeNestedStacks</code> specifies <code>True</code> during the creation
        /// of the nested change set, then <code>DeleteChangeSet</code> will delete all change
        /// sets that belong to the stacks hierarchy and will also delete all change sets for
        /// nested stacks with the status of <code>REVIEW_IN_PROGRESS</code>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteChangeSet service method.</param>
        /// 
        /// <returns>The response from the DeleteChangeSet service method, as returned by CloudFormation.</returns>
        /// <exception cref="Amazon.CloudFormation.Model.InvalidChangeSetStatusException">
        /// The specified change set can't be used to update the stack. For example, the change
        /// set status might be <code>CREATE_IN_PROGRESS</code>, or the stack status might be
        /// <code>UPDATE_IN_PROGRESS</code>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/DeleteChangeSet">REST API Reference for DeleteChangeSet Operation</seealso>
        public virtual DeleteChangeSetResponse DeleteChangeSet(DeleteChangeSetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteChangeSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteChangeSetResponseUnmarshaller.Instance;

            return Invoke<DeleteChangeSetResponse>(request, options);
        }


        /// <summary>
        /// Deletes the specified change set. Deleting change sets ensures that no one executes
        /// the wrong change set.
        /// 
        ///  
        /// <para>
        /// If the call successfully completes, AWS CloudFormation successfully deleted the change
        /// set.
        /// </para>
        ///  
        /// <para>
        /// If <code>IncludeNestedStacks</code> specifies <code>True</code> during the creation
        /// of the nested change set, then <code>DeleteChangeSet</code> will delete all change
        /// sets that belong to the stacks hierarchy and will also delete all change sets for
        /// nested stacks with the status of <code>REVIEW_IN_PROGRESS</code>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteChangeSet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteChangeSet service method, as returned by CloudFormation.</returns>
        /// <exception cref="Amazon.CloudFormation.Model.InvalidChangeSetStatusException">
        /// The specified change set can't be used to update the stack. For example, the change
        /// set status might be <code>CREATE_IN_PROGRESS</code>, or the stack status might be
        /// <code>UPDATE_IN_PROGRESS</code>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/DeleteChangeSet">REST API Reference for DeleteChangeSet Operation</seealso>
        public virtual Task<DeleteChangeSetResponse> DeleteChangeSetAsync(DeleteChangeSetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteChangeSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteChangeSetResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteChangeSetResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteStack


        /// <summary>
        /// Deletes a specified stack. Once the call completes successfully, stack deletion starts.
        /// Deleted stacks do not show up in the <a>DescribeStacks</a> API if the deletion has
        /// been completed successfully.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteStack service method.</param>
        /// 
        /// <returns>The response from the DeleteStack service method, as returned by CloudFormation.</returns>
        /// <exception cref="Amazon.CloudFormation.Model.TokenAlreadyExistsException">
        /// A client request token already exists.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/DeleteStack">REST API Reference for DeleteStack Operation</seealso>
        public virtual DeleteStackResponse DeleteStack(DeleteStackRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteStackRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteStackResponseUnmarshaller.Instance;

            return Invoke<DeleteStackResponse>(request, options);
        }


        /// <summary>
        /// Deletes a specified stack. Once the call completes successfully, stack deletion starts.
        /// Deleted stacks do not show up in the <a>DescribeStacks</a> API if the deletion has
        /// been completed successfully.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteStack service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteStack service method, as returned by CloudFormation.</returns>
        /// <exception cref="Amazon.CloudFormation.Model.TokenAlreadyExistsException">
        /// A client request token already exists.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/DeleteStack">REST API Reference for DeleteStack Operation</seealso>
        public virtual Task<DeleteStackResponse> DeleteStackAsync(DeleteStackRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteStackRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteStackResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteStackResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteStackInstances


        /// <summary>
        /// Deletes stack instances for the specified accounts, in the specified Regions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteStackInstances service method.</param>
        /// 
        /// <returns>The response from the DeleteStackInstances service method, as returned by CloudFormation.</returns>
        /// <exception cref="Amazon.CloudFormation.Model.InvalidOperationException">
        /// The specified operation isn't valid.
        /// </exception>
        /// <exception cref="Amazon.CloudFormation.Model.OperationIdAlreadyExistsException">
        /// The specified operation ID already exists.
        /// </exception>
        /// <exception cref="Amazon.CloudFormation.Model.OperationInProgressException">
        /// Another operation is currently in progress for this stack set. Only one operation
        /// can be performed for a stack set at a given time.
        /// </exception>
        /// <exception cref="Amazon.CloudFormation.Model.StackSetNotFoundException">
        /// The specified stack set doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFormation.Model.StaleRequestException">
        /// Another operation has been performed on this stack set since the specified operation
        /// was performed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/DeleteStackInstances">REST API Reference for DeleteStackInstances Operation</seealso>
        public virtual DeleteStackInstancesResponse DeleteStackInstances(DeleteStackInstancesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteStackInstancesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteStackInstancesResponseUnmarshaller.Instance;

            return Invoke<DeleteStackInstancesResponse>(request, options);
        }


        /// <summary>
        /// Deletes stack instances for the specified accounts, in the specified Regions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteStackInstances service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteStackInstances service method, as returned by CloudFormation.</returns>
        /// <exception cref="Amazon.CloudFormation.Model.InvalidOperationException">
        /// The specified operation isn't valid.
        /// </exception>
        /// <exception cref="Amazon.CloudFormation.Model.OperationIdAlreadyExistsException">
        /// The specified operation ID already exists.
        /// </exception>
        /// <exception cref="Amazon.CloudFormation.Model.OperationInProgressException">
        /// Another operation is currently in progress for this stack set. Only one operation
        /// can be performed for a stack set at a given time.
        /// </exception>
        /// <exception cref="Amazon.CloudFormation.Model.StackSetNotFoundException">
        /// The specified stack set doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFormation.Model.StaleRequestException">
        /// Another operation has been performed on this stack set since the specified operation
        /// was performed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/DeleteStackInstances">REST API Reference for DeleteStackInstances Operation</seealso>
        public virtual Task<DeleteStackInstancesResponse> DeleteStackInstancesAsync(DeleteStackInstancesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteStackInstancesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteStackInstancesResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteStackInstancesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteStackSet


        /// <summary>
        /// Deletes a stack set. Before you can delete a stack set, all of its member stack instances
        /// must be deleted. For more information about how to do this, see <a>DeleteStackInstances</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteStackSet service method.</param>
        /// 
        /// <returns>The response from the DeleteStackSet service method, as returned by CloudFormation.</returns>
        /// <exception cref="Amazon.CloudFormation.Model.OperationInProgressException">
        /// Another operation is currently in progress for this stack set. Only one operation
        /// can be performed for a stack set at a given time.
        /// </exception>
        /// <exception cref="Amazon.CloudFormation.Model.StackSetNotEmptyException">
        /// You can't yet delete this stack set, because it still contains one or more stack instances.
        /// Delete all stack instances from the stack set before deleting the stack set.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/DeleteStackSet">REST API Reference for DeleteStackSet Operation</seealso>
        public virtual DeleteStackSetResponse DeleteStackSet(DeleteStackSetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteStackSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteStackSetResponseUnmarshaller.Instance;

            return Invoke<DeleteStackSetResponse>(request, options);
        }


        /// <summary>
        /// Deletes a stack set. Before you can delete a stack set, all of its member stack instances
        /// must be deleted. For more information about how to do this, see <a>DeleteStackInstances</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteStackSet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteStackSet service method, as returned by CloudFormation.</returns>
        /// <exception cref="Amazon.CloudFormation.Model.OperationInProgressException">
        /// Another operation is currently in progress for this stack set. Only one operation
        /// can be performed for a stack set at a given time.
        /// </exception>
        /// <exception cref="Amazon.CloudFormation.Model.StackSetNotEmptyException">
        /// You can't yet delete this stack set, because it still contains one or more stack instances.
        /// Delete all stack instances from the stack set before deleting the stack set.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/DeleteStackSet">REST API Reference for DeleteStackSet Operation</seealso>
        public virtual Task<DeleteStackSetResponse> DeleteStackSetAsync(DeleteStackSetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteStackSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteStackSetResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteStackSetResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeregisterType


        /// <summary>
        /// Removes a type or type version from active use in the CloudFormation registry. If
        /// a type or type version is deregistered, it cannot be used in CloudFormation operations.
        /// 
        ///  
        /// <para>
        /// To deregister a type, you must individually deregister all registered versions of
        /// that type. If a type has only a single registered version, deregistering that version
        /// results in the type itself being deregistered. 
        /// </para>
        ///  
        /// <para>
        /// You cannot deregister the default version of a type, unless it is the only registered
        /// version of that type, in which case the type itself is deregistered as well. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeregisterType service method.</param>
        /// 
        /// <returns>The response from the DeregisterType service method, as returned by CloudFormation.</returns>
        /// <exception cref="Amazon.CloudFormation.Model.CFNRegistryException">
        /// An error occurred during a CloudFormation registry operation.
        /// </exception>
        /// <exception cref="Amazon.CloudFormation.Model.TypeNotFoundException">
        /// The specified type does not exist in the CloudFormation registry.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/DeregisterType">REST API Reference for DeregisterType Operation</seealso>
        public virtual DeregisterTypeResponse DeregisterType(DeregisterTypeRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeregisterTypeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeregisterTypeResponseUnmarshaller.Instance;

            return Invoke<DeregisterTypeResponse>(request, options);
        }


        /// <summary>
        /// Removes a type or type version from active use in the CloudFormation registry. If
        /// a type or type version is deregistered, it cannot be used in CloudFormation operations.
        /// 
        ///  
        /// <para>
        /// To deregister a type, you must individually deregister all registered versions of
        /// that type. If a type has only a single registered version, deregistering that version
        /// results in the type itself being deregistered. 
        /// </para>
        ///  
        /// <para>
        /// You cannot deregister the default version of a type, unless it is the only registered
        /// version of that type, in which case the type itself is deregistered as well. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeregisterType service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeregisterType service method, as returned by CloudFormation.</returns>
        /// <exception cref="Amazon.CloudFormation.Model.CFNRegistryException">
        /// An error occurred during a CloudFormation registry operation.
        /// </exception>
        /// <exception cref="Amazon.CloudFormation.Model.TypeNotFoundException">
        /// The specified type does not exist in the CloudFormation registry.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/DeregisterType">REST API Reference for DeregisterType Operation</seealso>
        public virtual Task<DeregisterTypeResponse> DeregisterTypeAsync(DeregisterTypeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeregisterTypeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeregisterTypeResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeregisterTypeResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeAccountLimits


        /// <summary>
        /// Retrieves your account's AWS CloudFormation limits, such as the maximum number of
        /// stacks that you can create in your account. For more information about account limits,
        /// see <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/cloudformation-limits.html">AWS
        /// CloudFormation Limits</a> in the <i>AWS CloudFormation User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAccountLimits service method.</param>
        /// 
        /// <returns>The response from the DescribeAccountLimits service method, as returned by CloudFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/DescribeAccountLimits">REST API Reference for DescribeAccountLimits Operation</seealso>
        public virtual DescribeAccountLimitsResponse DescribeAccountLimits(DescribeAccountLimitsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAccountLimitsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAccountLimitsResponseUnmarshaller.Instance;

            return Invoke<DescribeAccountLimitsResponse>(request, options);
        }


        /// <summary>
        /// Retrieves your account's AWS CloudFormation limits, such as the maximum number of
        /// stacks that you can create in your account. For more information about account limits,
        /// see <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/cloudformation-limits.html">AWS
        /// CloudFormation Limits</a> in the <i>AWS CloudFormation User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAccountLimits service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeAccountLimits service method, as returned by CloudFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/DescribeAccountLimits">REST API Reference for DescribeAccountLimits Operation</seealso>
        public virtual Task<DescribeAccountLimitsResponse> DescribeAccountLimitsAsync(DescribeAccountLimitsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAccountLimitsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAccountLimitsResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeAccountLimitsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeChangeSet


        /// <summary>
        /// Returns the inputs for the change set and a list of changes that AWS CloudFormation
        /// will make if you execute the change set. For more information, see <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/using-cfn-updating-stacks-changesets.html">Updating
        /// Stacks Using Change Sets</a> in the AWS CloudFormation User Guide.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeChangeSet service method.</param>
        /// 
        /// <returns>The response from the DescribeChangeSet service method, as returned by CloudFormation.</returns>
        /// <exception cref="Amazon.CloudFormation.Model.ChangeSetNotFoundException">
        /// The specified change set name or ID doesn't exit. To view valid change sets for a
        /// stack, use the <code>ListChangeSets</code> action.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/DescribeChangeSet">REST API Reference for DescribeChangeSet Operation</seealso>
        public virtual DescribeChangeSetResponse DescribeChangeSet(DescribeChangeSetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeChangeSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeChangeSetResponseUnmarshaller.Instance;

            return Invoke<DescribeChangeSetResponse>(request, options);
        }


        /// <summary>
        /// Returns the inputs for the change set and a list of changes that AWS CloudFormation
        /// will make if you execute the change set. For more information, see <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/using-cfn-updating-stacks-changesets.html">Updating
        /// Stacks Using Change Sets</a> in the AWS CloudFormation User Guide.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeChangeSet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeChangeSet service method, as returned by CloudFormation.</returns>
        /// <exception cref="Amazon.CloudFormation.Model.ChangeSetNotFoundException">
        /// The specified change set name or ID doesn't exit. To view valid change sets for a
        /// stack, use the <code>ListChangeSets</code> action.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/DescribeChangeSet">REST API Reference for DescribeChangeSet Operation</seealso>
        public virtual Task<DescribeChangeSetResponse> DescribeChangeSetAsync(DescribeChangeSetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeChangeSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeChangeSetResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeChangeSetResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeStackDriftDetectionStatus


        /// <summary>
        /// Returns information about a stack drift detection operation. A stack drift detection
        /// operation detects whether a stack's actual configuration differs, or has <i>drifted</i>,
        /// from it's expected configuration, as defined in the stack template and any values
        /// specified as template parameters. A stack is considered to have drifted if one or
        /// more of its resources have drifted. For more information on stack and resource drift,
        /// see <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/using-cfn-stack-drift.html">Detecting
        /// Unregulated Configuration Changes to Stacks and Resources</a>.
        /// 
        ///  
        /// <para>
        /// Use <a>DetectStackDrift</a> to initiate a stack drift detection operation. <code>DetectStackDrift</code>
        /// returns a <code>StackDriftDetectionId</code> you can use to monitor the progress of
        /// the operation using <code>DescribeStackDriftDetectionStatus</code>. Once the drift
        /// detection operation has completed, use <a>DescribeStackResourceDrifts</a> to return
        /// drift information about the stack and its resources.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeStackDriftDetectionStatus service method.</param>
        /// 
        /// <returns>The response from the DescribeStackDriftDetectionStatus service method, as returned by CloudFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/DescribeStackDriftDetectionStatus">REST API Reference for DescribeStackDriftDetectionStatus Operation</seealso>
        public virtual DescribeStackDriftDetectionStatusResponse DescribeStackDriftDetectionStatus(DescribeStackDriftDetectionStatusRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeStackDriftDetectionStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeStackDriftDetectionStatusResponseUnmarshaller.Instance;

            return Invoke<DescribeStackDriftDetectionStatusResponse>(request, options);
        }


        /// <summary>
        /// Returns information about a stack drift detection operation. A stack drift detection
        /// operation detects whether a stack's actual configuration differs, or has <i>drifted</i>,
        /// from it's expected configuration, as defined in the stack template and any values
        /// specified as template parameters. A stack is considered to have drifted if one or
        /// more of its resources have drifted. For more information on stack and resource drift,
        /// see <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/using-cfn-stack-drift.html">Detecting
        /// Unregulated Configuration Changes to Stacks and Resources</a>.
        /// 
        ///  
        /// <para>
        /// Use <a>DetectStackDrift</a> to initiate a stack drift detection operation. <code>DetectStackDrift</code>
        /// returns a <code>StackDriftDetectionId</code> you can use to monitor the progress of
        /// the operation using <code>DescribeStackDriftDetectionStatus</code>. Once the drift
        /// detection operation has completed, use <a>DescribeStackResourceDrifts</a> to return
        /// drift information about the stack and its resources.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeStackDriftDetectionStatus service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeStackDriftDetectionStatus service method, as returned by CloudFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/DescribeStackDriftDetectionStatus">REST API Reference for DescribeStackDriftDetectionStatus Operation</seealso>
        public virtual Task<DescribeStackDriftDetectionStatusResponse> DescribeStackDriftDetectionStatusAsync(DescribeStackDriftDetectionStatusRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeStackDriftDetectionStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeStackDriftDetectionStatusResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeStackDriftDetectionStatusResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeStackEvents


        /// <summary>
        /// Returns all stack related events for a specified stack in reverse chronological order.
        /// For more information about a stack's event history, go to <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/concept-stack.html">Stacks</a>
        /// in the AWS CloudFormation User Guide.
        /// 
        ///  <note> 
        /// <para>
        /// You can list events for stacks that have failed to create or have been deleted by
        /// specifying the unique stack identifier (stack ID).
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeStackEvents service method.</param>
        /// 
        /// <returns>The response from the DescribeStackEvents service method, as returned by CloudFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/DescribeStackEvents">REST API Reference for DescribeStackEvents Operation</seealso>
        public virtual DescribeStackEventsResponse DescribeStackEvents(DescribeStackEventsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeStackEventsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeStackEventsResponseUnmarshaller.Instance;

            return Invoke<DescribeStackEventsResponse>(request, options);
        }


        /// <summary>
        /// Returns all stack related events for a specified stack in reverse chronological order.
        /// For more information about a stack's event history, go to <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/concept-stack.html">Stacks</a>
        /// in the AWS CloudFormation User Guide.
        /// 
        ///  <note> 
        /// <para>
        /// You can list events for stacks that have failed to create or have been deleted by
        /// specifying the unique stack identifier (stack ID).
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeStackEvents service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeStackEvents service method, as returned by CloudFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/DescribeStackEvents">REST API Reference for DescribeStackEvents Operation</seealso>
        public virtual Task<DescribeStackEventsResponse> DescribeStackEventsAsync(DescribeStackEventsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeStackEventsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeStackEventsResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeStackEventsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeStackInstance


        /// <summary>
        /// Returns the stack instance that's associated with the specified stack set, AWS account,
        /// and Region.
        /// 
        ///  
        /// <para>
        /// For a list of stack instances that are associated with a specific stack set, use <a>ListStackInstances</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeStackInstance service method.</param>
        /// 
        /// <returns>The response from the DescribeStackInstance service method, as returned by CloudFormation.</returns>
        /// <exception cref="Amazon.CloudFormation.Model.StackInstanceNotFoundException">
        /// The specified stack instance doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFormation.Model.StackSetNotFoundException">
        /// The specified stack set doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/DescribeStackInstance">REST API Reference for DescribeStackInstance Operation</seealso>
        public virtual DescribeStackInstanceResponse DescribeStackInstance(DescribeStackInstanceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeStackInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeStackInstanceResponseUnmarshaller.Instance;

            return Invoke<DescribeStackInstanceResponse>(request, options);
        }


        /// <summary>
        /// Returns the stack instance that's associated with the specified stack set, AWS account,
        /// and Region.
        /// 
        ///  
        /// <para>
        /// For a list of stack instances that are associated with a specific stack set, use <a>ListStackInstances</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeStackInstance service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeStackInstance service method, as returned by CloudFormation.</returns>
        /// <exception cref="Amazon.CloudFormation.Model.StackInstanceNotFoundException">
        /// The specified stack instance doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFormation.Model.StackSetNotFoundException">
        /// The specified stack set doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/DescribeStackInstance">REST API Reference for DescribeStackInstance Operation</seealso>
        public virtual Task<DescribeStackInstanceResponse> DescribeStackInstanceAsync(DescribeStackInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeStackInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeStackInstanceResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeStackInstanceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeStackResource


        /// <summary>
        /// Returns a description of the specified resource in the specified stack.
        /// 
        ///  
        /// <para>
        /// For deleted stacks, DescribeStackResource returns resource information for up to 90
        /// days after the stack has been deleted.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeStackResource service method.</param>
        /// 
        /// <returns>The response from the DescribeStackResource service method, as returned by CloudFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/DescribeStackResource">REST API Reference for DescribeStackResource Operation</seealso>
        public virtual DescribeStackResourceResponse DescribeStackResource(DescribeStackResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeStackResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeStackResourceResponseUnmarshaller.Instance;

            return Invoke<DescribeStackResourceResponse>(request, options);
        }


        /// <summary>
        /// Returns a description of the specified resource in the specified stack.
        /// 
        ///  
        /// <para>
        /// For deleted stacks, DescribeStackResource returns resource information for up to 90
        /// days after the stack has been deleted.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeStackResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeStackResource service method, as returned by CloudFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/DescribeStackResource">REST API Reference for DescribeStackResource Operation</seealso>
        public virtual Task<DescribeStackResourceResponse> DescribeStackResourceAsync(DescribeStackResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeStackResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeStackResourceResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeStackResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeStackResourceDrifts


        /// <summary>
        /// Returns drift information for the resources that have been checked for drift in the
        /// specified stack. This includes actual and expected configuration values for resources
        /// where AWS CloudFormation detects configuration drift.
        /// 
        ///  
        /// <para>
        /// For a given stack, there will be one <code>StackResourceDrift</code> for each stack
        /// resource that has been checked for drift. Resources that have not yet been checked
        /// for drift are not included. Resources that do not currently support drift detection
        /// are not checked, and so not included. For a list of resources that support drift detection,
        /// see <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/using-cfn-stack-drift-resource-list.html">Resources
        /// that Support Drift Detection</a>.
        /// </para>
        ///  
        /// <para>
        /// Use <a>DetectStackResourceDrift</a> to detect drift on individual resources, or <a>DetectStackDrift</a>
        /// to detect drift on all supported resources for a given stack.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeStackResourceDrifts service method.</param>
        /// 
        /// <returns>The response from the DescribeStackResourceDrifts service method, as returned by CloudFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/DescribeStackResourceDrifts">REST API Reference for DescribeStackResourceDrifts Operation</seealso>
        public virtual DescribeStackResourceDriftsResponse DescribeStackResourceDrifts(DescribeStackResourceDriftsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeStackResourceDriftsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeStackResourceDriftsResponseUnmarshaller.Instance;

            return Invoke<DescribeStackResourceDriftsResponse>(request, options);
        }


        /// <summary>
        /// Returns drift information for the resources that have been checked for drift in the
        /// specified stack. This includes actual and expected configuration values for resources
        /// where AWS CloudFormation detects configuration drift.
        /// 
        ///  
        /// <para>
        /// For a given stack, there will be one <code>StackResourceDrift</code> for each stack
        /// resource that has been checked for drift. Resources that have not yet been checked
        /// for drift are not included. Resources that do not currently support drift detection
        /// are not checked, and so not included. For a list of resources that support drift detection,
        /// see <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/using-cfn-stack-drift-resource-list.html">Resources
        /// that Support Drift Detection</a>.
        /// </para>
        ///  
        /// <para>
        /// Use <a>DetectStackResourceDrift</a> to detect drift on individual resources, or <a>DetectStackDrift</a>
        /// to detect drift on all supported resources for a given stack.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeStackResourceDrifts service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeStackResourceDrifts service method, as returned by CloudFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/DescribeStackResourceDrifts">REST API Reference for DescribeStackResourceDrifts Operation</seealso>
        public virtual Task<DescribeStackResourceDriftsResponse> DescribeStackResourceDriftsAsync(DescribeStackResourceDriftsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeStackResourceDriftsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeStackResourceDriftsResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeStackResourceDriftsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeStackResources


        /// <summary>
        /// Returns AWS resource descriptions for running and deleted stacks. If <code>StackName</code>
        /// is specified, all the associated resources that are part of the stack are returned.
        /// If <code>PhysicalResourceId</code> is specified, the associated resources of the stack
        /// that the resource belongs to are returned.
        /// 
        ///  <note> 
        /// <para>
        /// Only the first 100 resources will be returned. If your stack has more resources than
        /// this, you should use <code>ListStackResources</code> instead.
        /// </para>
        ///  </note> 
        /// <para>
        /// For deleted stacks, <code>DescribeStackResources</code> returns resource information
        /// for up to 90 days after the stack has been deleted.
        /// </para>
        ///  
        /// <para>
        /// You must specify either <code>StackName</code> or <code>PhysicalResourceId</code>,
        /// but not both. In addition, you can specify <code>LogicalResourceId</code> to filter
        /// the returned result. For more information about resources, the <code>LogicalResourceId</code>
        /// and <code>PhysicalResourceId</code>, go to the <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/">AWS
        /// CloudFormation User Guide</a>.
        /// </para>
        ///  <note> 
        /// <para>
        /// A <code>ValidationError</code> is returned if you specify both <code>StackName</code>
        /// and <code>PhysicalResourceId</code> in the same request.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeStackResources service method.</param>
        /// 
        /// <returns>The response from the DescribeStackResources service method, as returned by CloudFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/DescribeStackResources">REST API Reference for DescribeStackResources Operation</seealso>
        public virtual DescribeStackResourcesResponse DescribeStackResources(DescribeStackResourcesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeStackResourcesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeStackResourcesResponseUnmarshaller.Instance;

            return Invoke<DescribeStackResourcesResponse>(request, options);
        }


        /// <summary>
        /// Returns AWS resource descriptions for running and deleted stacks. If <code>StackName</code>
        /// is specified, all the associated resources that are part of the stack are returned.
        /// If <code>PhysicalResourceId</code> is specified, the associated resources of the stack
        /// that the resource belongs to are returned.
        /// 
        ///  <note> 
        /// <para>
        /// Only the first 100 resources will be returned. If your stack has more resources than
        /// this, you should use <code>ListStackResources</code> instead.
        /// </para>
        ///  </note> 
        /// <para>
        /// For deleted stacks, <code>DescribeStackResources</code> returns resource information
        /// for up to 90 days after the stack has been deleted.
        /// </para>
        ///  
        /// <para>
        /// You must specify either <code>StackName</code> or <code>PhysicalResourceId</code>,
        /// but not both. In addition, you can specify <code>LogicalResourceId</code> to filter
        /// the returned result. For more information about resources, the <code>LogicalResourceId</code>
        /// and <code>PhysicalResourceId</code>, go to the <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/">AWS
        /// CloudFormation User Guide</a>.
        /// </para>
        ///  <note> 
        /// <para>
        /// A <code>ValidationError</code> is returned if you specify both <code>StackName</code>
        /// and <code>PhysicalResourceId</code> in the same request.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeStackResources service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeStackResources service method, as returned by CloudFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/DescribeStackResources">REST API Reference for DescribeStackResources Operation</seealso>
        public virtual Task<DescribeStackResourcesResponse> DescribeStackResourcesAsync(DescribeStackResourcesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeStackResourcesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeStackResourcesResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeStackResourcesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeStacks


        /// <summary>
        /// Returns the description for the specified stack; if no stack name was specified, then
        /// it returns the description for all the stacks created.
        /// 
        ///  <note> 
        /// <para>
        /// If the stack does not exist, an <code>AmazonCloudFormationException</code> is returned.
        /// </para>
        ///  </note>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeStacks service method, as returned by CloudFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/DescribeStacks">REST API Reference for DescribeStacks Operation</seealso>
        public virtual DescribeStacksResponse DescribeStacks()
        {
            return DescribeStacks(new DescribeStacksRequest());
        }


        /// <summary>
        /// Returns the description for the specified stack; if no stack name was specified, then
        /// it returns the description for all the stacks created.
        /// 
        ///  <note> 
        /// <para>
        /// If the stack does not exist, an <code>AmazonCloudFormationException</code> is returned.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeStacks service method.</param>
        /// 
        /// <returns>The response from the DescribeStacks service method, as returned by CloudFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/DescribeStacks">REST API Reference for DescribeStacks Operation</seealso>
        public virtual DescribeStacksResponse DescribeStacks(DescribeStacksRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeStacksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeStacksResponseUnmarshaller.Instance;

            return Invoke<DescribeStacksResponse>(request, options);
        }


        /// <summary>
        /// Returns the description for the specified stack; if no stack name was specified, then
        /// it returns the description for all the stacks created.
        /// 
        ///  <note> 
        /// <para>
        /// If the stack does not exist, an <code>AmazonCloudFormationException</code> is returned.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeStacks service method, as returned by CloudFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/DescribeStacks">REST API Reference for DescribeStacks Operation</seealso>
        public virtual Task<DescribeStacksResponse> DescribeStacksAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return DescribeStacksAsync(new DescribeStacksRequest(), cancellationToken);
        }

        /// <summary>
        /// Returns the description for the specified stack; if no stack name was specified, then
        /// it returns the description for all the stacks created.
        /// 
        ///  <note> 
        /// <para>
        /// If the stack does not exist, an <code>AmazonCloudFormationException</code> is returned.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeStacks service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeStacks service method, as returned by CloudFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/DescribeStacks">REST API Reference for DescribeStacks Operation</seealso>
        public virtual Task<DescribeStacksResponse> DescribeStacksAsync(DescribeStacksRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeStacksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeStacksResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeStacksResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeStackSet


        /// <summary>
        /// Returns the description of the specified stack set.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeStackSet service method.</param>
        /// 
        /// <returns>The response from the DescribeStackSet service method, as returned by CloudFormation.</returns>
        /// <exception cref="Amazon.CloudFormation.Model.StackSetNotFoundException">
        /// The specified stack set doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/DescribeStackSet">REST API Reference for DescribeStackSet Operation</seealso>
        public virtual DescribeStackSetResponse DescribeStackSet(DescribeStackSetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeStackSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeStackSetResponseUnmarshaller.Instance;

            return Invoke<DescribeStackSetResponse>(request, options);
        }


        /// <summary>
        /// Returns the description of the specified stack set.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeStackSet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeStackSet service method, as returned by CloudFormation.</returns>
        /// <exception cref="Amazon.CloudFormation.Model.StackSetNotFoundException">
        /// The specified stack set doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/DescribeStackSet">REST API Reference for DescribeStackSet Operation</seealso>
        public virtual Task<DescribeStackSetResponse> DescribeStackSetAsync(DescribeStackSetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeStackSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeStackSetResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeStackSetResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeStackSetOperation


        /// <summary>
        /// Returns the description of the specified stack set operation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeStackSetOperation service method.</param>
        /// 
        /// <returns>The response from the DescribeStackSetOperation service method, as returned by CloudFormation.</returns>
        /// <exception cref="Amazon.CloudFormation.Model.OperationNotFoundException">
        /// The specified ID refers to an operation that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFormation.Model.StackSetNotFoundException">
        /// The specified stack set doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/DescribeStackSetOperation">REST API Reference for DescribeStackSetOperation Operation</seealso>
        public virtual DescribeStackSetOperationResponse DescribeStackSetOperation(DescribeStackSetOperationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeStackSetOperationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeStackSetOperationResponseUnmarshaller.Instance;

            return Invoke<DescribeStackSetOperationResponse>(request, options);
        }


        /// <summary>
        /// Returns the description of the specified stack set operation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeStackSetOperation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeStackSetOperation service method, as returned by CloudFormation.</returns>
        /// <exception cref="Amazon.CloudFormation.Model.OperationNotFoundException">
        /// The specified ID refers to an operation that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFormation.Model.StackSetNotFoundException">
        /// The specified stack set doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/DescribeStackSetOperation">REST API Reference for DescribeStackSetOperation Operation</seealso>
        public virtual Task<DescribeStackSetOperationResponse> DescribeStackSetOperationAsync(DescribeStackSetOperationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeStackSetOperationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeStackSetOperationResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeStackSetOperationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeType


        /// <summary>
        /// Returns detailed information about a type that has been registered.
        /// 
        ///  
        /// <para>
        /// If you specify a <code>VersionId</code>, <code>DescribeType</code> returns information
        /// about that specific type version. Otherwise, it returns information about the default
        /// type version.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeType service method.</param>
        /// 
        /// <returns>The response from the DescribeType service method, as returned by CloudFormation.</returns>
        /// <exception cref="Amazon.CloudFormation.Model.CFNRegistryException">
        /// An error occurred during a CloudFormation registry operation.
        /// </exception>
        /// <exception cref="Amazon.CloudFormation.Model.TypeNotFoundException">
        /// The specified type does not exist in the CloudFormation registry.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/DescribeType">REST API Reference for DescribeType Operation</seealso>
        public virtual DescribeTypeResponse DescribeType(DescribeTypeRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeTypeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeTypeResponseUnmarshaller.Instance;

            return Invoke<DescribeTypeResponse>(request, options);
        }


        /// <summary>
        /// Returns detailed information about a type that has been registered.
        /// 
        ///  
        /// <para>
        /// If you specify a <code>VersionId</code>, <code>DescribeType</code> returns information
        /// about that specific type version. Otherwise, it returns information about the default
        /// type version.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeType service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeType service method, as returned by CloudFormation.</returns>
        /// <exception cref="Amazon.CloudFormation.Model.CFNRegistryException">
        /// An error occurred during a CloudFormation registry operation.
        /// </exception>
        /// <exception cref="Amazon.CloudFormation.Model.TypeNotFoundException">
        /// The specified type does not exist in the CloudFormation registry.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/DescribeType">REST API Reference for DescribeType Operation</seealso>
        public virtual Task<DescribeTypeResponse> DescribeTypeAsync(DescribeTypeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeTypeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeTypeResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeTypeResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeTypeRegistration


        /// <summary>
        /// Returns information about a type's registration, including its current status and
        /// type and version identifiers.
        /// 
        ///  
        /// <para>
        /// When you initiate a registration request using <code> <a>RegisterType</a> </code>,
        /// you can then use <code> <a>DescribeTypeRegistration</a> </code> to monitor the progress
        /// of that registration request.
        /// </para>
        ///  
        /// <para>
        /// Once the registration request has completed, use <code> <a>DescribeType</a> </code>
        /// to return detailed informaiton about a type.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeTypeRegistration service method.</param>
        /// 
        /// <returns>The response from the DescribeTypeRegistration service method, as returned by CloudFormation.</returns>
        /// <exception cref="Amazon.CloudFormation.Model.CFNRegistryException">
        /// An error occurred during a CloudFormation registry operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/DescribeTypeRegistration">REST API Reference for DescribeTypeRegistration Operation</seealso>
        public virtual DescribeTypeRegistrationResponse DescribeTypeRegistration(DescribeTypeRegistrationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeTypeRegistrationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeTypeRegistrationResponseUnmarshaller.Instance;

            return Invoke<DescribeTypeRegistrationResponse>(request, options);
        }


        /// <summary>
        /// Returns information about a type's registration, including its current status and
        /// type and version identifiers.
        /// 
        ///  
        /// <para>
        /// When you initiate a registration request using <code> <a>RegisterType</a> </code>,
        /// you can then use <code> <a>DescribeTypeRegistration</a> </code> to monitor the progress
        /// of that registration request.
        /// </para>
        ///  
        /// <para>
        /// Once the registration request has completed, use <code> <a>DescribeType</a> </code>
        /// to return detailed informaiton about a type.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeTypeRegistration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeTypeRegistration service method, as returned by CloudFormation.</returns>
        /// <exception cref="Amazon.CloudFormation.Model.CFNRegistryException">
        /// An error occurred during a CloudFormation registry operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/DescribeTypeRegistration">REST API Reference for DescribeTypeRegistration Operation</seealso>
        public virtual Task<DescribeTypeRegistrationResponse> DescribeTypeRegistrationAsync(DescribeTypeRegistrationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeTypeRegistrationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeTypeRegistrationResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeTypeRegistrationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DetectStackDrift


        /// <summary>
        /// Detects whether a stack's actual configuration differs, or has <i>drifted</i>, from
        /// it's expected configuration, as defined in the stack template and any values specified
        /// as template parameters. For each resource in the stack that supports drift detection,
        /// AWS CloudFormation compares the actual configuration of the resource with its expected
        /// template configuration. Only resource properties explicitly defined in the stack template
        /// are checked for drift. A stack is considered to have drifted if one or more of its
        /// resources differ from their expected template configurations. For more information,
        /// see <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/using-cfn-stack-drift.html">Detecting
        /// Unregulated Configuration Changes to Stacks and Resources</a>.
        /// 
        ///  
        /// <para>
        /// Use <code>DetectStackDrift</code> to detect drift on all supported resources for a
        /// given stack, or <a>DetectStackResourceDrift</a> to detect drift on individual resources.
        /// </para>
        ///  
        /// <para>
        /// For a list of stack resources that currently support drift detection, see <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/using-cfn-stack-drift-resource-list.html">Resources
        /// that Support Drift Detection</a>.
        /// </para>
        ///  
        /// <para>
        ///  <code>DetectStackDrift</code> can take up to several minutes, depending on the number
        /// of resources contained within the stack. Use <a>DescribeStackDriftDetectionStatus</a>
        /// to monitor the progress of a detect stack drift operation. Once the drift detection
        /// operation has completed, use <a>DescribeStackResourceDrifts</a> to return drift information
        /// about the stack and its resources.
        /// </para>
        ///  
        /// <para>
        /// When detecting drift on a stack, AWS CloudFormation does not detect drift on any nested
        /// stacks belonging to that stack. Perform <code>DetectStackDrift</code> directly on
        /// the nested stack itself.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DetectStackDrift service method.</param>
        /// 
        /// <returns>The response from the DetectStackDrift service method, as returned by CloudFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/DetectStackDrift">REST API Reference for DetectStackDrift Operation</seealso>
        public virtual DetectStackDriftResponse DetectStackDrift(DetectStackDriftRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DetectStackDriftRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DetectStackDriftResponseUnmarshaller.Instance;

            return Invoke<DetectStackDriftResponse>(request, options);
        }


        /// <summary>
        /// Detects whether a stack's actual configuration differs, or has <i>drifted</i>, from
        /// it's expected configuration, as defined in the stack template and any values specified
        /// as template parameters. For each resource in the stack that supports drift detection,
        /// AWS CloudFormation compares the actual configuration of the resource with its expected
        /// template configuration. Only resource properties explicitly defined in the stack template
        /// are checked for drift. A stack is considered to have drifted if one or more of its
        /// resources differ from their expected template configurations. For more information,
        /// see <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/using-cfn-stack-drift.html">Detecting
        /// Unregulated Configuration Changes to Stacks and Resources</a>.
        /// 
        ///  
        /// <para>
        /// Use <code>DetectStackDrift</code> to detect drift on all supported resources for a
        /// given stack, or <a>DetectStackResourceDrift</a> to detect drift on individual resources.
        /// </para>
        ///  
        /// <para>
        /// For a list of stack resources that currently support drift detection, see <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/using-cfn-stack-drift-resource-list.html">Resources
        /// that Support Drift Detection</a>.
        /// </para>
        ///  
        /// <para>
        ///  <code>DetectStackDrift</code> can take up to several minutes, depending on the number
        /// of resources contained within the stack. Use <a>DescribeStackDriftDetectionStatus</a>
        /// to monitor the progress of a detect stack drift operation. Once the drift detection
        /// operation has completed, use <a>DescribeStackResourceDrifts</a> to return drift information
        /// about the stack and its resources.
        /// </para>
        ///  
        /// <para>
        /// When detecting drift on a stack, AWS CloudFormation does not detect drift on any nested
        /// stacks belonging to that stack. Perform <code>DetectStackDrift</code> directly on
        /// the nested stack itself.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DetectStackDrift service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DetectStackDrift service method, as returned by CloudFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/DetectStackDrift">REST API Reference for DetectStackDrift Operation</seealso>
        public virtual Task<DetectStackDriftResponse> DetectStackDriftAsync(DetectStackDriftRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DetectStackDriftRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DetectStackDriftResponseUnmarshaller.Instance;
            
            return InvokeAsync<DetectStackDriftResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DetectStackResourceDrift


        /// <summary>
        /// Returns information about whether a resource's actual configuration differs, or has
        /// <i>drifted</i>, from it's expected configuration, as defined in the stack template
        /// and any values specified as template parameters. This information includes actual
        /// and expected property values for resources in which AWS CloudFormation detects drift.
        /// Only resource properties explicitly defined in the stack template are checked for
        /// drift. For more information about stack and resource drift, see <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/using-cfn-stack-drift.html">Detecting
        /// Unregulated Configuration Changes to Stacks and Resources</a>.
        /// 
        ///  
        /// <para>
        /// Use <code>DetectStackResourceDrift</code> to detect drift on individual resources,
        /// or <a>DetectStackDrift</a> to detect drift on all resources in a given stack that
        /// support drift detection.
        /// </para>
        ///  
        /// <para>
        /// Resources that do not currently support drift detection cannot be checked. For a list
        /// of resources that support drift detection, see <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/using-cfn-stack-drift-resource-list.html">Resources
        /// that Support Drift Detection</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DetectStackResourceDrift service method.</param>
        /// 
        /// <returns>The response from the DetectStackResourceDrift service method, as returned by CloudFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/DetectStackResourceDrift">REST API Reference for DetectStackResourceDrift Operation</seealso>
        public virtual DetectStackResourceDriftResponse DetectStackResourceDrift(DetectStackResourceDriftRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DetectStackResourceDriftRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DetectStackResourceDriftResponseUnmarshaller.Instance;

            return Invoke<DetectStackResourceDriftResponse>(request, options);
        }


        /// <summary>
        /// Returns information about whether a resource's actual configuration differs, or has
        /// <i>drifted</i>, from it's expected configuration, as defined in the stack template
        /// and any values specified as template parameters. This information includes actual
        /// and expected property values for resources in which AWS CloudFormation detects drift.
        /// Only resource properties explicitly defined in the stack template are checked for
        /// drift. For more information about stack and resource drift, see <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/using-cfn-stack-drift.html">Detecting
        /// Unregulated Configuration Changes to Stacks and Resources</a>.
        /// 
        ///  
        /// <para>
        /// Use <code>DetectStackResourceDrift</code> to detect drift on individual resources,
        /// or <a>DetectStackDrift</a> to detect drift on all resources in a given stack that
        /// support drift detection.
        /// </para>
        ///  
        /// <para>
        /// Resources that do not currently support drift detection cannot be checked. For a list
        /// of resources that support drift detection, see <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/using-cfn-stack-drift-resource-list.html">Resources
        /// that Support Drift Detection</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DetectStackResourceDrift service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DetectStackResourceDrift service method, as returned by CloudFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/DetectStackResourceDrift">REST API Reference for DetectStackResourceDrift Operation</seealso>
        public virtual Task<DetectStackResourceDriftResponse> DetectStackResourceDriftAsync(DetectStackResourceDriftRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DetectStackResourceDriftRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DetectStackResourceDriftResponseUnmarshaller.Instance;
            
            return InvokeAsync<DetectStackResourceDriftResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DetectStackSetDrift


        /// <summary>
        /// Detect drift on a stack set. When CloudFormation performs drift detection on a stack
        /// set, it performs drift detection on the stack associated with each stack instance
        /// in the stack set. For more information, see <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/stacksets-drift.html">How
        /// CloudFormation Performs Drift Detection on a Stack Set</a>.
        /// 
        ///  
        /// <para>
        ///  <code>DetectStackSetDrift</code> returns the <code>OperationId</code> of the stack
        /// set drift detection operation. Use this operation id with <code> <a>DescribeStackSetOperation</a>
        /// </code> to monitor the progress of the drift detection operation. The drift detection
        /// operation may take some time, depending on the number of stack instances included
        /// in the stack set, as well as the number of resources included in each stack.
        /// </para>
        ///  
        /// <para>
        /// Once the operation has completed, use the following actions to return drift information:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Use <code> <a>DescribeStackSet</a> </code> to return detailed informaiton about the
        /// stack set, including detailed information about the last <i>completed</i> drift operation
        /// performed on the stack set. (Information about drift operations that are in progress
        /// is not included.)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <code> <a>ListStackInstances</a> </code> to return a list of stack instances belonging
        /// to the stack set, including the drift status and last drift time checked of each instance.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <code> <a>DescribeStackInstance</a> </code> to return detailed information about
        /// a specific stack instance, including its drift status and last drift time checked.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information on performing a drift detection operation on a stack set, see
        /// <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/stacksets-drift.html">Detecting
        /// Unmanaged Changes in Stack Sets</a>. 
        /// </para>
        ///  
        /// <para>
        /// You can only run a single drift detection operation on a given stack set at one time.
        /// 
        /// </para>
        ///  
        /// <para>
        /// To stop a drift detection stack set operation, use <code> <a>StopStackSetOperation</a>
        /// </code>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DetectStackSetDrift service method.</param>
        /// 
        /// <returns>The response from the DetectStackSetDrift service method, as returned by CloudFormation.</returns>
        /// <exception cref="Amazon.CloudFormation.Model.InvalidOperationException">
        /// The specified operation isn't valid.
        /// </exception>
        /// <exception cref="Amazon.CloudFormation.Model.OperationInProgressException">
        /// Another operation is currently in progress for this stack set. Only one operation
        /// can be performed for a stack set at a given time.
        /// </exception>
        /// <exception cref="Amazon.CloudFormation.Model.StackSetNotFoundException">
        /// The specified stack set doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/DetectStackSetDrift">REST API Reference for DetectStackSetDrift Operation</seealso>
        public virtual DetectStackSetDriftResponse DetectStackSetDrift(DetectStackSetDriftRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DetectStackSetDriftRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DetectStackSetDriftResponseUnmarshaller.Instance;

            return Invoke<DetectStackSetDriftResponse>(request, options);
        }


        /// <summary>
        /// Detect drift on a stack set. When CloudFormation performs drift detection on a stack
        /// set, it performs drift detection on the stack associated with each stack instance
        /// in the stack set. For more information, see <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/stacksets-drift.html">How
        /// CloudFormation Performs Drift Detection on a Stack Set</a>.
        /// 
        ///  
        /// <para>
        ///  <code>DetectStackSetDrift</code> returns the <code>OperationId</code> of the stack
        /// set drift detection operation. Use this operation id with <code> <a>DescribeStackSetOperation</a>
        /// </code> to monitor the progress of the drift detection operation. The drift detection
        /// operation may take some time, depending on the number of stack instances included
        /// in the stack set, as well as the number of resources included in each stack.
        /// </para>
        ///  
        /// <para>
        /// Once the operation has completed, use the following actions to return drift information:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Use <code> <a>DescribeStackSet</a> </code> to return detailed informaiton about the
        /// stack set, including detailed information about the last <i>completed</i> drift operation
        /// performed on the stack set. (Information about drift operations that are in progress
        /// is not included.)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <code> <a>ListStackInstances</a> </code> to return a list of stack instances belonging
        /// to the stack set, including the drift status and last drift time checked of each instance.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <code> <a>DescribeStackInstance</a> </code> to return detailed information about
        /// a specific stack instance, including its drift status and last drift time checked.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information on performing a drift detection operation on a stack set, see
        /// <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/stacksets-drift.html">Detecting
        /// Unmanaged Changes in Stack Sets</a>. 
        /// </para>
        ///  
        /// <para>
        /// You can only run a single drift detection operation on a given stack set at one time.
        /// 
        /// </para>
        ///  
        /// <para>
        /// To stop a drift detection stack set operation, use <code> <a>StopStackSetOperation</a>
        /// </code>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DetectStackSetDrift service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DetectStackSetDrift service method, as returned by CloudFormation.</returns>
        /// <exception cref="Amazon.CloudFormation.Model.InvalidOperationException">
        /// The specified operation isn't valid.
        /// </exception>
        /// <exception cref="Amazon.CloudFormation.Model.OperationInProgressException">
        /// Another operation is currently in progress for this stack set. Only one operation
        /// can be performed for a stack set at a given time.
        /// </exception>
        /// <exception cref="Amazon.CloudFormation.Model.StackSetNotFoundException">
        /// The specified stack set doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/DetectStackSetDrift">REST API Reference for DetectStackSetDrift Operation</seealso>
        public virtual Task<DetectStackSetDriftResponse> DetectStackSetDriftAsync(DetectStackSetDriftRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DetectStackSetDriftRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DetectStackSetDriftResponseUnmarshaller.Instance;
            
            return InvokeAsync<DetectStackSetDriftResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  EstimateTemplateCost


        /// <summary>
        /// Returns the estimated monthly cost of a template. The return value is an AWS Simple
        /// Monthly Calculator URL with a query string that describes the resources required to
        /// run the template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EstimateTemplateCost service method.</param>
        /// 
        /// <returns>The response from the EstimateTemplateCost service method, as returned by CloudFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/EstimateTemplateCost">REST API Reference for EstimateTemplateCost Operation</seealso>
        public virtual EstimateTemplateCostResponse EstimateTemplateCost(EstimateTemplateCostRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = EstimateTemplateCostRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EstimateTemplateCostResponseUnmarshaller.Instance;

            return Invoke<EstimateTemplateCostResponse>(request, options);
        }


        /// <summary>
        /// Returns the estimated monthly cost of a template. The return value is an AWS Simple
        /// Monthly Calculator URL with a query string that describes the resources required to
        /// run the template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EstimateTemplateCost service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the EstimateTemplateCost service method, as returned by CloudFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/EstimateTemplateCost">REST API Reference for EstimateTemplateCost Operation</seealso>
        public virtual Task<EstimateTemplateCostResponse> EstimateTemplateCostAsync(EstimateTemplateCostRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = EstimateTemplateCostRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EstimateTemplateCostResponseUnmarshaller.Instance;
            
            return InvokeAsync<EstimateTemplateCostResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ExecuteChangeSet


        /// <summary>
        /// Updates a stack using the input information that was provided when the specified change
        /// set was created. After the call successfully completes, AWS CloudFormation starts
        /// updating the stack. Use the <a>DescribeStacks</a> action to view the status of the
        /// update.
        /// 
        ///  
        /// <para>
        /// When you execute a change set, AWS CloudFormation deletes all other change sets associated
        /// with the stack because they aren't valid for the updated stack.
        /// </para>
        ///  
        /// <para>
        /// If a stack policy is associated with the stack, AWS CloudFormation enforces the policy
        /// during the update. You can't specify a temporary stack policy that overrides the current
        /// policy.
        /// </para>
        ///  
        /// <para>
        /// To create a change set for the entire stack hierachy, <code>IncludeNestedStacks</code>
        /// must have been set to <code>True</code>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ExecuteChangeSet service method.</param>
        /// 
        /// <returns>The response from the ExecuteChangeSet service method, as returned by CloudFormation.</returns>
        /// <exception cref="Amazon.CloudFormation.Model.ChangeSetNotFoundException">
        /// The specified change set name or ID doesn't exit. To view valid change sets for a
        /// stack, use the <code>ListChangeSets</code> action.
        /// </exception>
        /// <exception cref="Amazon.CloudFormation.Model.InsufficientCapabilitiesException">
        /// The template contains resources with capabilities that weren't specified in the Capabilities
        /// parameter.
        /// </exception>
        /// <exception cref="Amazon.CloudFormation.Model.InvalidChangeSetStatusException">
        /// The specified change set can't be used to update the stack. For example, the change
        /// set status might be <code>CREATE_IN_PROGRESS</code>, or the stack status might be
        /// <code>UPDATE_IN_PROGRESS</code>.
        /// </exception>
        /// <exception cref="Amazon.CloudFormation.Model.TokenAlreadyExistsException">
        /// A client request token already exists.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/ExecuteChangeSet">REST API Reference for ExecuteChangeSet Operation</seealso>
        public virtual ExecuteChangeSetResponse ExecuteChangeSet(ExecuteChangeSetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ExecuteChangeSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ExecuteChangeSetResponseUnmarshaller.Instance;

            return Invoke<ExecuteChangeSetResponse>(request, options);
        }


        /// <summary>
        /// Updates a stack using the input information that was provided when the specified change
        /// set was created. After the call successfully completes, AWS CloudFormation starts
        /// updating the stack. Use the <a>DescribeStacks</a> action to view the status of the
        /// update.
        /// 
        ///  
        /// <para>
        /// When you execute a change set, AWS CloudFormation deletes all other change sets associated
        /// with the stack because they aren't valid for the updated stack.
        /// </para>
        ///  
        /// <para>
        /// If a stack policy is associated with the stack, AWS CloudFormation enforces the policy
        /// during the update. You can't specify a temporary stack policy that overrides the current
        /// policy.
        /// </para>
        ///  
        /// <para>
        /// To create a change set for the entire stack hierachy, <code>IncludeNestedStacks</code>
        /// must have been set to <code>True</code>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ExecuteChangeSet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ExecuteChangeSet service method, as returned by CloudFormation.</returns>
        /// <exception cref="Amazon.CloudFormation.Model.ChangeSetNotFoundException">
        /// The specified change set name or ID doesn't exit. To view valid change sets for a
        /// stack, use the <code>ListChangeSets</code> action.
        /// </exception>
        /// <exception cref="Amazon.CloudFormation.Model.InsufficientCapabilitiesException">
        /// The template contains resources with capabilities that weren't specified in the Capabilities
        /// parameter.
        /// </exception>
        /// <exception cref="Amazon.CloudFormation.Model.InvalidChangeSetStatusException">
        /// The specified change set can't be used to update the stack. For example, the change
        /// set status might be <code>CREATE_IN_PROGRESS</code>, or the stack status might be
        /// <code>UPDATE_IN_PROGRESS</code>.
        /// </exception>
        /// <exception cref="Amazon.CloudFormation.Model.TokenAlreadyExistsException">
        /// A client request token already exists.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/ExecuteChangeSet">REST API Reference for ExecuteChangeSet Operation</seealso>
        public virtual Task<ExecuteChangeSetResponse> ExecuteChangeSetAsync(ExecuteChangeSetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ExecuteChangeSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ExecuteChangeSetResponseUnmarshaller.Instance;
            
            return InvokeAsync<ExecuteChangeSetResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetStackPolicy


        /// <summary>
        /// Returns the stack policy for a specified stack. If a stack doesn't have a policy,
        /// a null value is returned.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetStackPolicy service method.</param>
        /// 
        /// <returns>The response from the GetStackPolicy service method, as returned by CloudFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/GetStackPolicy">REST API Reference for GetStackPolicy Operation</seealso>
        public virtual GetStackPolicyResponse GetStackPolicy(GetStackPolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetStackPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetStackPolicyResponseUnmarshaller.Instance;

            return Invoke<GetStackPolicyResponse>(request, options);
        }


        /// <summary>
        /// Returns the stack policy for a specified stack. If a stack doesn't have a policy,
        /// a null value is returned.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetStackPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetStackPolicy service method, as returned by CloudFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/GetStackPolicy">REST API Reference for GetStackPolicy Operation</seealso>
        public virtual Task<GetStackPolicyResponse> GetStackPolicyAsync(GetStackPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetStackPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetStackPolicyResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetStackPolicyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetTemplate


        /// <summary>
        /// Returns the template body for a specified stack. You can get the template for running
        /// or deleted stacks.
        /// 
        ///  
        /// <para>
        /// For deleted stacks, GetTemplate returns the template for up to 90 days after the stack
        /// has been deleted.
        /// </para>
        ///  <note> 
        /// <para>
        ///  If the template does not exist, a <code>ValidationError</code> is returned. 
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTemplate service method.</param>
        /// 
        /// <returns>The response from the GetTemplate service method, as returned by CloudFormation.</returns>
        /// <exception cref="Amazon.CloudFormation.Model.ChangeSetNotFoundException">
        /// The specified change set name or ID doesn't exit. To view valid change sets for a
        /// stack, use the <code>ListChangeSets</code> action.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/GetTemplate">REST API Reference for GetTemplate Operation</seealso>
        public virtual GetTemplateResponse GetTemplate(GetTemplateRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTemplateResponseUnmarshaller.Instance;

            return Invoke<GetTemplateResponse>(request, options);
        }


        /// <summary>
        /// Returns the template body for a specified stack. You can get the template for running
        /// or deleted stacks.
        /// 
        ///  
        /// <para>
        /// For deleted stacks, GetTemplate returns the template for up to 90 days after the stack
        /// has been deleted.
        /// </para>
        ///  <note> 
        /// <para>
        ///  If the template does not exist, a <code>ValidationError</code> is returned. 
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTemplate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetTemplate service method, as returned by CloudFormation.</returns>
        /// <exception cref="Amazon.CloudFormation.Model.ChangeSetNotFoundException">
        /// The specified change set name or ID doesn't exit. To view valid change sets for a
        /// stack, use the <code>ListChangeSets</code> action.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/GetTemplate">REST API Reference for GetTemplate Operation</seealso>
        public virtual Task<GetTemplateResponse> GetTemplateAsync(GetTemplateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTemplateResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetTemplateResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetTemplateSummary


        /// <summary>
        /// Returns information about a new or existing template. The <code>GetTemplateSummary</code>
        /// action is useful for viewing parameter information, such as default parameter values
        /// and parameter types, before you create or update a stack or stack set.
        /// 
        ///  
        /// <para>
        /// You can use the <code>GetTemplateSummary</code> action when you submit a template,
        /// or you can get template information for a stack set, or a running or deleted stack.
        /// </para>
        ///  
        /// <para>
        /// For deleted stacks, <code>GetTemplateSummary</code> returns the template information
        /// for up to 90 days after the stack has been deleted. If the template does not exist,
        /// a <code>ValidationError</code> is returned.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTemplateSummary service method.</param>
        /// 
        /// <returns>The response from the GetTemplateSummary service method, as returned by CloudFormation.</returns>
        /// <exception cref="Amazon.CloudFormation.Model.StackSetNotFoundException">
        /// The specified stack set doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/GetTemplateSummary">REST API Reference for GetTemplateSummary Operation</seealso>
        public virtual GetTemplateSummaryResponse GetTemplateSummary(GetTemplateSummaryRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetTemplateSummaryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTemplateSummaryResponseUnmarshaller.Instance;

            return Invoke<GetTemplateSummaryResponse>(request, options);
        }


        /// <summary>
        /// Returns information about a new or existing template. The <code>GetTemplateSummary</code>
        /// action is useful for viewing parameter information, such as default parameter values
        /// and parameter types, before you create or update a stack or stack set.
        /// 
        ///  
        /// <para>
        /// You can use the <code>GetTemplateSummary</code> action when you submit a template,
        /// or you can get template information for a stack set, or a running or deleted stack.
        /// </para>
        ///  
        /// <para>
        /// For deleted stacks, <code>GetTemplateSummary</code> returns the template information
        /// for up to 90 days after the stack has been deleted. If the template does not exist,
        /// a <code>ValidationError</code> is returned.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTemplateSummary service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetTemplateSummary service method, as returned by CloudFormation.</returns>
        /// <exception cref="Amazon.CloudFormation.Model.StackSetNotFoundException">
        /// The specified stack set doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/GetTemplateSummary">REST API Reference for GetTemplateSummary Operation</seealso>
        public virtual Task<GetTemplateSummaryResponse> GetTemplateSummaryAsync(GetTemplateSummaryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetTemplateSummaryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTemplateSummaryResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetTemplateSummaryResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListChangeSets


        /// <summary>
        /// Returns the ID and status of each active change set for a stack. For example, AWS
        /// CloudFormation lists change sets that are in the <code>CREATE_IN_PROGRESS</code> or
        /// <code>CREATE_PENDING</code> state.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListChangeSets service method.</param>
        /// 
        /// <returns>The response from the ListChangeSets service method, as returned by CloudFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/ListChangeSets">REST API Reference for ListChangeSets Operation</seealso>
        public virtual ListChangeSetsResponse ListChangeSets(ListChangeSetsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListChangeSetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListChangeSetsResponseUnmarshaller.Instance;

            return Invoke<ListChangeSetsResponse>(request, options);
        }


        /// <summary>
        /// Returns the ID and status of each active change set for a stack. For example, AWS
        /// CloudFormation lists change sets that are in the <code>CREATE_IN_PROGRESS</code> or
        /// <code>CREATE_PENDING</code> state.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListChangeSets service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListChangeSets service method, as returned by CloudFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/ListChangeSets">REST API Reference for ListChangeSets Operation</seealso>
        public virtual Task<ListChangeSetsResponse> ListChangeSetsAsync(ListChangeSetsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListChangeSetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListChangeSetsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListChangeSetsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListExports


        /// <summary>
        /// Lists all exported output values in the account and Region in which you call this
        /// action. Use this action to see the exported output values that you can import into
        /// other stacks. To import values, use the <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/intrinsic-function-reference-importvalue.html">
        /// <code>Fn::ImportValue</code> </a> function. 
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/using-cfn-stack-exports.html">
        /// AWS CloudFormation Export Stack Output Values</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListExports service method.</param>
        /// 
        /// <returns>The response from the ListExports service method, as returned by CloudFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/ListExports">REST API Reference for ListExports Operation</seealso>
        public virtual ListExportsResponse ListExports(ListExportsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListExportsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListExportsResponseUnmarshaller.Instance;

            return Invoke<ListExportsResponse>(request, options);
        }


        /// <summary>
        /// Lists all exported output values in the account and Region in which you call this
        /// action. Use this action to see the exported output values that you can import into
        /// other stacks. To import values, use the <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/intrinsic-function-reference-importvalue.html">
        /// <code>Fn::ImportValue</code> </a> function. 
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/using-cfn-stack-exports.html">
        /// AWS CloudFormation Export Stack Output Values</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListExports service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListExports service method, as returned by CloudFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/ListExports">REST API Reference for ListExports Operation</seealso>
        public virtual Task<ListExportsResponse> ListExportsAsync(ListExportsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListExportsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListExportsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListExportsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListImports


        /// <summary>
        /// Lists all stacks that are importing an exported output value. To modify or remove
        /// an exported output value, first use this action to see which stacks are using it.
        /// To see the exported output values in your account, see <a>ListExports</a>. 
        /// 
        ///  
        /// <para>
        /// For more information about importing an exported output value, see the <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/intrinsic-function-reference-importvalue.html">
        /// <code>Fn::ImportValue</code> </a> function. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListImports service method.</param>
        /// 
        /// <returns>The response from the ListImports service method, as returned by CloudFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/ListImports">REST API Reference for ListImports Operation</seealso>
        public virtual ListImportsResponse ListImports(ListImportsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListImportsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListImportsResponseUnmarshaller.Instance;

            return Invoke<ListImportsResponse>(request, options);
        }


        /// <summary>
        /// Lists all stacks that are importing an exported output value. To modify or remove
        /// an exported output value, first use this action to see which stacks are using it.
        /// To see the exported output values in your account, see <a>ListExports</a>. 
        /// 
        ///  
        /// <para>
        /// For more information about importing an exported output value, see the <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/intrinsic-function-reference-importvalue.html">
        /// <code>Fn::ImportValue</code> </a> function. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListImports service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListImports service method, as returned by CloudFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/ListImports">REST API Reference for ListImports Operation</seealso>
        public virtual Task<ListImportsResponse> ListImportsAsync(ListImportsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListImportsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListImportsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListImportsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListStackInstances


        /// <summary>
        /// Returns summary information about stack instances that are associated with the specified
        /// stack set. You can filter for stack instances that are associated with a specific
        /// AWS account name or Region, or that have a specific status.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListStackInstances service method.</param>
        /// 
        /// <returns>The response from the ListStackInstances service method, as returned by CloudFormation.</returns>
        /// <exception cref="Amazon.CloudFormation.Model.StackSetNotFoundException">
        /// The specified stack set doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/ListStackInstances">REST API Reference for ListStackInstances Operation</seealso>
        public virtual ListStackInstancesResponse ListStackInstances(ListStackInstancesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListStackInstancesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListStackInstancesResponseUnmarshaller.Instance;

            return Invoke<ListStackInstancesResponse>(request, options);
        }


        /// <summary>
        /// Returns summary information about stack instances that are associated with the specified
        /// stack set. You can filter for stack instances that are associated with a specific
        /// AWS account name or Region, or that have a specific status.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListStackInstances service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListStackInstances service method, as returned by CloudFormation.</returns>
        /// <exception cref="Amazon.CloudFormation.Model.StackSetNotFoundException">
        /// The specified stack set doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/ListStackInstances">REST API Reference for ListStackInstances Operation</seealso>
        public virtual Task<ListStackInstancesResponse> ListStackInstancesAsync(ListStackInstancesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListStackInstancesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListStackInstancesResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListStackInstancesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListStackResources


        /// <summary>
        /// Returns descriptions of all resources of the specified stack.
        /// 
        ///  
        /// <para>
        /// For deleted stacks, ListStackResources returns resource information for up to 90 days
        /// after the stack has been deleted.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListStackResources service method.</param>
        /// 
        /// <returns>The response from the ListStackResources service method, as returned by CloudFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/ListStackResources">REST API Reference for ListStackResources Operation</seealso>
        public virtual ListStackResourcesResponse ListStackResources(ListStackResourcesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListStackResourcesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListStackResourcesResponseUnmarshaller.Instance;

            return Invoke<ListStackResourcesResponse>(request, options);
        }


        /// <summary>
        /// Returns descriptions of all resources of the specified stack.
        /// 
        ///  
        /// <para>
        /// For deleted stacks, ListStackResources returns resource information for up to 90 days
        /// after the stack has been deleted.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListStackResources service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListStackResources service method, as returned by CloudFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/ListStackResources">REST API Reference for ListStackResources Operation</seealso>
        public virtual Task<ListStackResourcesResponse> ListStackResourcesAsync(ListStackResourcesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListStackResourcesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListStackResourcesResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListStackResourcesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListStacks


        /// <summary>
        /// Returns the summary information for stacks whose status matches the specified StackStatusFilter.
        /// Summary information for stacks that have been deleted is kept for 90 days after the
        /// stack is deleted. If no StackStatusFilter is specified, summary information for all
        /// stacks is returned (including existing stacks and stacks that have been deleted).
        /// </summary>
        /// 
        /// <returns>The response from the ListStacks service method, as returned by CloudFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/ListStacks">REST API Reference for ListStacks Operation</seealso>
        public virtual ListStacksResponse ListStacks()
        {
            return ListStacks(new ListStacksRequest());
        }


        /// <summary>
        /// Returns the summary information for stacks whose status matches the specified StackStatusFilter.
        /// Summary information for stacks that have been deleted is kept for 90 days after the
        /// stack is deleted. If no StackStatusFilter is specified, summary information for all
        /// stacks is returned (including existing stacks and stacks that have been deleted).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListStacks service method.</param>
        /// 
        /// <returns>The response from the ListStacks service method, as returned by CloudFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/ListStacks">REST API Reference for ListStacks Operation</seealso>
        public virtual ListStacksResponse ListStacks(ListStacksRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListStacksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListStacksResponseUnmarshaller.Instance;

            return Invoke<ListStacksResponse>(request, options);
        }


        /// <summary>
        /// Returns the summary information for stacks whose status matches the specified StackStatusFilter.
        /// Summary information for stacks that have been deleted is kept for 90 days after the
        /// stack is deleted. If no StackStatusFilter is specified, summary information for all
        /// stacks is returned (including existing stacks and stacks that have been deleted).
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListStacks service method, as returned by CloudFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/ListStacks">REST API Reference for ListStacks Operation</seealso>
        public virtual Task<ListStacksResponse> ListStacksAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return ListStacksAsync(new ListStacksRequest(), cancellationToken);
        }

        /// <summary>
        /// Returns the summary information for stacks whose status matches the specified StackStatusFilter.
        /// Summary information for stacks that have been deleted is kept for 90 days after the
        /// stack is deleted. If no StackStatusFilter is specified, summary information for all
        /// stacks is returned (including existing stacks and stacks that have been deleted).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListStacks service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListStacks service method, as returned by CloudFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/ListStacks">REST API Reference for ListStacks Operation</seealso>
        public virtual Task<ListStacksResponse> ListStacksAsync(ListStacksRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListStacksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListStacksResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListStacksResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListStackSetOperationResults


        /// <summary>
        /// Returns summary information about the results of a stack set operation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListStackSetOperationResults service method.</param>
        /// 
        /// <returns>The response from the ListStackSetOperationResults service method, as returned by CloudFormation.</returns>
        /// <exception cref="Amazon.CloudFormation.Model.OperationNotFoundException">
        /// The specified ID refers to an operation that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFormation.Model.StackSetNotFoundException">
        /// The specified stack set doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/ListStackSetOperationResults">REST API Reference for ListStackSetOperationResults Operation</seealso>
        public virtual ListStackSetOperationResultsResponse ListStackSetOperationResults(ListStackSetOperationResultsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListStackSetOperationResultsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListStackSetOperationResultsResponseUnmarshaller.Instance;

            return Invoke<ListStackSetOperationResultsResponse>(request, options);
        }


        /// <summary>
        /// Returns summary information about the results of a stack set operation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListStackSetOperationResults service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListStackSetOperationResults service method, as returned by CloudFormation.</returns>
        /// <exception cref="Amazon.CloudFormation.Model.OperationNotFoundException">
        /// The specified ID refers to an operation that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFormation.Model.StackSetNotFoundException">
        /// The specified stack set doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/ListStackSetOperationResults">REST API Reference for ListStackSetOperationResults Operation</seealso>
        public virtual Task<ListStackSetOperationResultsResponse> ListStackSetOperationResultsAsync(ListStackSetOperationResultsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListStackSetOperationResultsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListStackSetOperationResultsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListStackSetOperationResultsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListStackSetOperations


        /// <summary>
        /// Returns summary information about operations performed on a stack set.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListStackSetOperations service method.</param>
        /// 
        /// <returns>The response from the ListStackSetOperations service method, as returned by CloudFormation.</returns>
        /// <exception cref="Amazon.CloudFormation.Model.StackSetNotFoundException">
        /// The specified stack set doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/ListStackSetOperations">REST API Reference for ListStackSetOperations Operation</seealso>
        public virtual ListStackSetOperationsResponse ListStackSetOperations(ListStackSetOperationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListStackSetOperationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListStackSetOperationsResponseUnmarshaller.Instance;

            return Invoke<ListStackSetOperationsResponse>(request, options);
        }


        /// <summary>
        /// Returns summary information about operations performed on a stack set.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListStackSetOperations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListStackSetOperations service method, as returned by CloudFormation.</returns>
        /// <exception cref="Amazon.CloudFormation.Model.StackSetNotFoundException">
        /// The specified stack set doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/ListStackSetOperations">REST API Reference for ListStackSetOperations Operation</seealso>
        public virtual Task<ListStackSetOperationsResponse> ListStackSetOperationsAsync(ListStackSetOperationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListStackSetOperationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListStackSetOperationsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListStackSetOperationsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListStackSets


        /// <summary>
        /// Returns summary information about stack sets that are associated with the user.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListStackSets service method.</param>
        /// 
        /// <returns>The response from the ListStackSets service method, as returned by CloudFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/ListStackSets">REST API Reference for ListStackSets Operation</seealso>
        public virtual ListStackSetsResponse ListStackSets(ListStackSetsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListStackSetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListStackSetsResponseUnmarshaller.Instance;

            return Invoke<ListStackSetsResponse>(request, options);
        }


        /// <summary>
        /// Returns summary information about stack sets that are associated with the user.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListStackSets service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListStackSets service method, as returned by CloudFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/ListStackSets">REST API Reference for ListStackSets Operation</seealso>
        public virtual Task<ListStackSetsResponse> ListStackSetsAsync(ListStackSetsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListStackSetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListStackSetsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListStackSetsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListTypeRegistrations


        /// <summary>
        /// Returns a list of registration tokens for the specified type(s).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTypeRegistrations service method.</param>
        /// 
        /// <returns>The response from the ListTypeRegistrations service method, as returned by CloudFormation.</returns>
        /// <exception cref="Amazon.CloudFormation.Model.CFNRegistryException">
        /// An error occurred during a CloudFormation registry operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/ListTypeRegistrations">REST API Reference for ListTypeRegistrations Operation</seealso>
        public virtual ListTypeRegistrationsResponse ListTypeRegistrations(ListTypeRegistrationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTypeRegistrationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTypeRegistrationsResponseUnmarshaller.Instance;

            return Invoke<ListTypeRegistrationsResponse>(request, options);
        }


        /// <summary>
        /// Returns a list of registration tokens for the specified type(s).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTypeRegistrations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTypeRegistrations service method, as returned by CloudFormation.</returns>
        /// <exception cref="Amazon.CloudFormation.Model.CFNRegistryException">
        /// An error occurred during a CloudFormation registry operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/ListTypeRegistrations">REST API Reference for ListTypeRegistrations Operation</seealso>
        public virtual Task<ListTypeRegistrationsResponse> ListTypeRegistrationsAsync(ListTypeRegistrationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTypeRegistrationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTypeRegistrationsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListTypeRegistrationsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListTypes


        /// <summary>
        /// Returns summary information about types that have been registered with CloudFormation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTypes service method.</param>
        /// 
        /// <returns>The response from the ListTypes service method, as returned by CloudFormation.</returns>
        /// <exception cref="Amazon.CloudFormation.Model.CFNRegistryException">
        /// An error occurred during a CloudFormation registry operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/ListTypes">REST API Reference for ListTypes Operation</seealso>
        public virtual ListTypesResponse ListTypes(ListTypesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTypesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTypesResponseUnmarshaller.Instance;

            return Invoke<ListTypesResponse>(request, options);
        }


        /// <summary>
        /// Returns summary information about types that have been registered with CloudFormation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTypes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTypes service method, as returned by CloudFormation.</returns>
        /// <exception cref="Amazon.CloudFormation.Model.CFNRegistryException">
        /// An error occurred during a CloudFormation registry operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/ListTypes">REST API Reference for ListTypes Operation</seealso>
        public virtual Task<ListTypesResponse> ListTypesAsync(ListTypesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTypesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTypesResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListTypesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListTypeVersions


        /// <summary>
        /// Returns summary information about the versions of a type.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTypeVersions service method.</param>
        /// 
        /// <returns>The response from the ListTypeVersions service method, as returned by CloudFormation.</returns>
        /// <exception cref="Amazon.CloudFormation.Model.CFNRegistryException">
        /// An error occurred during a CloudFormation registry operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/ListTypeVersions">REST API Reference for ListTypeVersions Operation</seealso>
        public virtual ListTypeVersionsResponse ListTypeVersions(ListTypeVersionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTypeVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTypeVersionsResponseUnmarshaller.Instance;

            return Invoke<ListTypeVersionsResponse>(request, options);
        }


        /// <summary>
        /// Returns summary information about the versions of a type.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTypeVersions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTypeVersions service method, as returned by CloudFormation.</returns>
        /// <exception cref="Amazon.CloudFormation.Model.CFNRegistryException">
        /// An error occurred during a CloudFormation registry operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/ListTypeVersions">REST API Reference for ListTypeVersions Operation</seealso>
        public virtual Task<ListTypeVersionsResponse> ListTypeVersionsAsync(ListTypeVersionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTypeVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTypeVersionsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListTypeVersionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RecordHandlerProgress


        /// <summary>
        /// Reports progress of a resource handler to CloudFormation.
        /// 
        ///  
        /// <para>
        /// Reserved for use by the <a href="https://docs.aws.amazon.com/cloudformation-cli/latest/userguide/what-is-cloudformation-cli.html">CloudFormation
        /// CLI</a>. Do not use this API in your code.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RecordHandlerProgress service method.</param>
        /// 
        /// <returns>The response from the RecordHandlerProgress service method, as returned by CloudFormation.</returns>
        /// <exception cref="Amazon.CloudFormation.Model.InvalidStateTransitionException">
        /// Error reserved for use by the <a href="https://docs.aws.amazon.com/cloudformation-cli/latest/userguide/what-is-cloudformation-cli.html">CloudFormation
        /// CLI</a>. CloudFormation does not return this error to users.
        /// </exception>
        /// <exception cref="Amazon.CloudFormation.Model.OperationStatusCheckFailedException">
        /// Error reserved for use by the <a href="https://docs.aws.amazon.com/cloudformation-cli/latest/userguide/what-is-cloudformation-cli.html">CloudFormation
        /// CLI</a>. CloudFormation does not return this error to users.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/RecordHandlerProgress">REST API Reference for RecordHandlerProgress Operation</seealso>
        public virtual RecordHandlerProgressResponse RecordHandlerProgress(RecordHandlerProgressRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RecordHandlerProgressRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RecordHandlerProgressResponseUnmarshaller.Instance;

            return Invoke<RecordHandlerProgressResponse>(request, options);
        }


        /// <summary>
        /// Reports progress of a resource handler to CloudFormation.
        /// 
        ///  
        /// <para>
        /// Reserved for use by the <a href="https://docs.aws.amazon.com/cloudformation-cli/latest/userguide/what-is-cloudformation-cli.html">CloudFormation
        /// CLI</a>. Do not use this API in your code.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RecordHandlerProgress service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RecordHandlerProgress service method, as returned by CloudFormation.</returns>
        /// <exception cref="Amazon.CloudFormation.Model.InvalidStateTransitionException">
        /// Error reserved for use by the <a href="https://docs.aws.amazon.com/cloudformation-cli/latest/userguide/what-is-cloudformation-cli.html">CloudFormation
        /// CLI</a>. CloudFormation does not return this error to users.
        /// </exception>
        /// <exception cref="Amazon.CloudFormation.Model.OperationStatusCheckFailedException">
        /// Error reserved for use by the <a href="https://docs.aws.amazon.com/cloudformation-cli/latest/userguide/what-is-cloudformation-cli.html">CloudFormation
        /// CLI</a>. CloudFormation does not return this error to users.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/RecordHandlerProgress">REST API Reference for RecordHandlerProgress Operation</seealso>
        public virtual Task<RecordHandlerProgressResponse> RecordHandlerProgressAsync(RecordHandlerProgressRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RecordHandlerProgressRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RecordHandlerProgressResponseUnmarshaller.Instance;
            
            return InvokeAsync<RecordHandlerProgressResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RegisterType


        /// <summary>
        /// Registers a type with the CloudFormation service. Registering a type makes it available
        /// for use in CloudFormation templates in your AWS account, and includes:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Validating the resource schema
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Determining which handlers have been specified for the resource
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Making the resource type available for use in your account
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information on how to develop types and ready them for registeration, see
        /// <a href="https://docs.aws.amazon.com/cloudformation-cli/latest/userguide/resource-types.html">Creating
        /// Resource Providers</a> in the <i>CloudFormation CLI User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// You can have a maximum of 50 resource type versions registered at a time. This maximum
        /// is per account and per region. Use <a href="AWSCloudFormation/latest/APIReference/API_DeregisterType.html">DeregisterType</a>
        /// to deregister specific resource type versions if necessary.
        /// </para>
        ///  
        /// <para>
        /// Once you have initiated a registration request using <code> <a>RegisterType</a> </code>,
        /// you can use <code> <a>DescribeTypeRegistration</a> </code> to monitor the progress
        /// of the registration request.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RegisterType service method.</param>
        /// 
        /// <returns>The response from the RegisterType service method, as returned by CloudFormation.</returns>
        /// <exception cref="Amazon.CloudFormation.Model.CFNRegistryException">
        /// An error occurred during a CloudFormation registry operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/RegisterType">REST API Reference for RegisterType Operation</seealso>
        public virtual RegisterTypeResponse RegisterType(RegisterTypeRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RegisterTypeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RegisterTypeResponseUnmarshaller.Instance;

            return Invoke<RegisterTypeResponse>(request, options);
        }


        /// <summary>
        /// Registers a type with the CloudFormation service. Registering a type makes it available
        /// for use in CloudFormation templates in your AWS account, and includes:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Validating the resource schema
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Determining which handlers have been specified for the resource
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Making the resource type available for use in your account
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information on how to develop types and ready them for registeration, see
        /// <a href="https://docs.aws.amazon.com/cloudformation-cli/latest/userguide/resource-types.html">Creating
        /// Resource Providers</a> in the <i>CloudFormation CLI User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// You can have a maximum of 50 resource type versions registered at a time. This maximum
        /// is per account and per region. Use <a href="AWSCloudFormation/latest/APIReference/API_DeregisterType.html">DeregisterType</a>
        /// to deregister specific resource type versions if necessary.
        /// </para>
        ///  
        /// <para>
        /// Once you have initiated a registration request using <code> <a>RegisterType</a> </code>,
        /// you can use <code> <a>DescribeTypeRegistration</a> </code> to monitor the progress
        /// of the registration request.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RegisterType service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RegisterType service method, as returned by CloudFormation.</returns>
        /// <exception cref="Amazon.CloudFormation.Model.CFNRegistryException">
        /// An error occurred during a CloudFormation registry operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/RegisterType">REST API Reference for RegisterType Operation</seealso>
        public virtual Task<RegisterTypeResponse> RegisterTypeAsync(RegisterTypeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RegisterTypeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RegisterTypeResponseUnmarshaller.Instance;
            
            return InvokeAsync<RegisterTypeResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  SetStackPolicy


        /// <summary>
        /// Sets a stack policy for a specified stack.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SetStackPolicy service method.</param>
        /// 
        /// <returns>The response from the SetStackPolicy service method, as returned by CloudFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/SetStackPolicy">REST API Reference for SetStackPolicy Operation</seealso>
        public virtual SetStackPolicyResponse SetStackPolicy(SetStackPolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SetStackPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SetStackPolicyResponseUnmarshaller.Instance;

            return Invoke<SetStackPolicyResponse>(request, options);
        }


        /// <summary>
        /// Sets a stack policy for a specified stack.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SetStackPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SetStackPolicy service method, as returned by CloudFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/SetStackPolicy">REST API Reference for SetStackPolicy Operation</seealso>
        public virtual Task<SetStackPolicyResponse> SetStackPolicyAsync(SetStackPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SetStackPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SetStackPolicyResponseUnmarshaller.Instance;
            
            return InvokeAsync<SetStackPolicyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  SetTypeDefaultVersion


        /// <summary>
        /// Specify the default version of a type. The default version of a type will be used
        /// in CloudFormation operations.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SetTypeDefaultVersion service method.</param>
        /// 
        /// <returns>The response from the SetTypeDefaultVersion service method, as returned by CloudFormation.</returns>
        /// <exception cref="Amazon.CloudFormation.Model.CFNRegistryException">
        /// An error occurred during a CloudFormation registry operation.
        /// </exception>
        /// <exception cref="Amazon.CloudFormation.Model.TypeNotFoundException">
        /// The specified type does not exist in the CloudFormation registry.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/SetTypeDefaultVersion">REST API Reference for SetTypeDefaultVersion Operation</seealso>
        public virtual SetTypeDefaultVersionResponse SetTypeDefaultVersion(SetTypeDefaultVersionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SetTypeDefaultVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SetTypeDefaultVersionResponseUnmarshaller.Instance;

            return Invoke<SetTypeDefaultVersionResponse>(request, options);
        }


        /// <summary>
        /// Specify the default version of a type. The default version of a type will be used
        /// in CloudFormation operations.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SetTypeDefaultVersion service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SetTypeDefaultVersion service method, as returned by CloudFormation.</returns>
        /// <exception cref="Amazon.CloudFormation.Model.CFNRegistryException">
        /// An error occurred during a CloudFormation registry operation.
        /// </exception>
        /// <exception cref="Amazon.CloudFormation.Model.TypeNotFoundException">
        /// The specified type does not exist in the CloudFormation registry.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/SetTypeDefaultVersion">REST API Reference for SetTypeDefaultVersion Operation</seealso>
        public virtual Task<SetTypeDefaultVersionResponse> SetTypeDefaultVersionAsync(SetTypeDefaultVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SetTypeDefaultVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SetTypeDefaultVersionResponseUnmarshaller.Instance;
            
            return InvokeAsync<SetTypeDefaultVersionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  SignalResource


        /// <summary>
        /// Sends a signal to the specified resource with a success or failure status. You can
        /// use the SignalResource API in conjunction with a creation policy or update policy.
        /// AWS CloudFormation doesn't proceed with a stack creation or update until resources
        /// receive the required number of signals or the timeout period is exceeded. The SignalResource
        /// API is useful in cases where you want to send signals from anywhere other than an
        /// Amazon EC2 instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SignalResource service method.</param>
        /// 
        /// <returns>The response from the SignalResource service method, as returned by CloudFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/SignalResource">REST API Reference for SignalResource Operation</seealso>
        public virtual SignalResourceResponse SignalResource(SignalResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SignalResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SignalResourceResponseUnmarshaller.Instance;

            return Invoke<SignalResourceResponse>(request, options);
        }


        /// <summary>
        /// Sends a signal to the specified resource with a success or failure status. You can
        /// use the SignalResource API in conjunction with a creation policy or update policy.
        /// AWS CloudFormation doesn't proceed with a stack creation or update until resources
        /// receive the required number of signals or the timeout period is exceeded. The SignalResource
        /// API is useful in cases where you want to send signals from anywhere other than an
        /// Amazon EC2 instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SignalResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SignalResource service method, as returned by CloudFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/SignalResource">REST API Reference for SignalResource Operation</seealso>
        public virtual Task<SignalResourceResponse> SignalResourceAsync(SignalResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SignalResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SignalResourceResponseUnmarshaller.Instance;
            
            return InvokeAsync<SignalResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StopStackSetOperation


        /// <summary>
        /// Stops an in-progress operation on a stack set and its associated stack instances.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopStackSetOperation service method.</param>
        /// 
        /// <returns>The response from the StopStackSetOperation service method, as returned by CloudFormation.</returns>
        /// <exception cref="Amazon.CloudFormation.Model.InvalidOperationException">
        /// The specified operation isn't valid.
        /// </exception>
        /// <exception cref="Amazon.CloudFormation.Model.OperationNotFoundException">
        /// The specified ID refers to an operation that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFormation.Model.StackSetNotFoundException">
        /// The specified stack set doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/StopStackSetOperation">REST API Reference for StopStackSetOperation Operation</seealso>
        public virtual StopStackSetOperationResponse StopStackSetOperation(StopStackSetOperationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopStackSetOperationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopStackSetOperationResponseUnmarshaller.Instance;

            return Invoke<StopStackSetOperationResponse>(request, options);
        }


        /// <summary>
        /// Stops an in-progress operation on a stack set and its associated stack instances.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopStackSetOperation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StopStackSetOperation service method, as returned by CloudFormation.</returns>
        /// <exception cref="Amazon.CloudFormation.Model.InvalidOperationException">
        /// The specified operation isn't valid.
        /// </exception>
        /// <exception cref="Amazon.CloudFormation.Model.OperationNotFoundException">
        /// The specified ID refers to an operation that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFormation.Model.StackSetNotFoundException">
        /// The specified stack set doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/StopStackSetOperation">REST API Reference for StopStackSetOperation Operation</seealso>
        public virtual Task<StopStackSetOperationResponse> StopStackSetOperationAsync(StopStackSetOperationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopStackSetOperationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopStackSetOperationResponseUnmarshaller.Instance;
            
            return InvokeAsync<StopStackSetOperationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateStack


        /// <summary>
        /// Updates a stack as specified in the template. After the call completes successfully,
        /// the stack update starts. You can check the status of the stack via the <a>DescribeStacks</a>
        /// action.
        /// 
        ///  
        /// <para>
        /// To get a copy of the template for an existing stack, you can use the <a>GetTemplate</a>
        /// action.
        /// </para>
        ///  
        /// <para>
        /// For more information about creating an update template, updating a stack, and monitoring
        /// the progress of the update, see <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/using-cfn-updating-stacks.html">Updating
        /// a Stack</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateStack service method.</param>
        /// 
        /// <returns>The response from the UpdateStack service method, as returned by CloudFormation.</returns>
        /// <exception cref="Amazon.CloudFormation.Model.InsufficientCapabilitiesException">
        /// The template contains resources with capabilities that weren't specified in the Capabilities
        /// parameter.
        /// </exception>
        /// <exception cref="Amazon.CloudFormation.Model.TokenAlreadyExistsException">
        /// A client request token already exists.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/UpdateStack">REST API Reference for UpdateStack Operation</seealso>
        public virtual UpdateStackResponse UpdateStack(UpdateStackRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateStackRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateStackResponseUnmarshaller.Instance;

            return Invoke<UpdateStackResponse>(request, options);
        }


        /// <summary>
        /// Updates a stack as specified in the template. After the call completes successfully,
        /// the stack update starts. You can check the status of the stack via the <a>DescribeStacks</a>
        /// action.
        /// 
        ///  
        /// <para>
        /// To get a copy of the template for an existing stack, you can use the <a>GetTemplate</a>
        /// action.
        /// </para>
        ///  
        /// <para>
        /// For more information about creating an update template, updating a stack, and monitoring
        /// the progress of the update, see <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/using-cfn-updating-stacks.html">Updating
        /// a Stack</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateStack service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateStack service method, as returned by CloudFormation.</returns>
        /// <exception cref="Amazon.CloudFormation.Model.InsufficientCapabilitiesException">
        /// The template contains resources with capabilities that weren't specified in the Capabilities
        /// parameter.
        /// </exception>
        /// <exception cref="Amazon.CloudFormation.Model.TokenAlreadyExistsException">
        /// A client request token already exists.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/UpdateStack">REST API Reference for UpdateStack Operation</seealso>
        public virtual Task<UpdateStackResponse> UpdateStackAsync(UpdateStackRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateStackRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateStackResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateStackResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateStackInstances


        /// <summary>
        /// Updates the parameter values for stack instances for the specified accounts, within
        /// the specified Regions. A stack instance refers to a stack in a specific account and
        /// Region. 
        /// 
        ///  
        /// <para>
        /// You can only update stack instances in Regions and accounts where they already exist;
        /// to create additional stack instances, use <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/APIReference/API_CreateStackInstances.html">CreateStackInstances</a>.
        /// 
        /// </para>
        ///  
        /// <para>
        /// During stack set updates, any parameters overridden for a stack instance are not updated,
        /// but retain their overridden value.
        /// </para>
        ///  
        /// <para>
        /// You can only update the parameter <i>values</i> that are specified in the stack set;
        /// to add or delete a parameter itself, use <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/APIReference/API_UpdateStackSet.html">UpdateStackSet</a>
        /// to update the stack set template. If you add a parameter to a template, before you
        /// can override the parameter value specified in the stack set you must first use <a
        /// href="https://docs.aws.amazon.com/AWSCloudFormation/latest/APIReference/API_UpdateStackSet.html">UpdateStackSet</a>
        /// to update all stack instances with the updated template and parameter value specified
        /// in the stack set. Once a stack instance has been updated with the new parameter, you
        /// can then override the parameter value using <code>UpdateStackInstances</code>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateStackInstances service method.</param>
        /// 
        /// <returns>The response from the UpdateStackInstances service method, as returned by CloudFormation.</returns>
        /// <exception cref="Amazon.CloudFormation.Model.InvalidOperationException">
        /// The specified operation isn't valid.
        /// </exception>
        /// <exception cref="Amazon.CloudFormation.Model.OperationIdAlreadyExistsException">
        /// The specified operation ID already exists.
        /// </exception>
        /// <exception cref="Amazon.CloudFormation.Model.OperationInProgressException">
        /// Another operation is currently in progress for this stack set. Only one operation
        /// can be performed for a stack set at a given time.
        /// </exception>
        /// <exception cref="Amazon.CloudFormation.Model.StackInstanceNotFoundException">
        /// The specified stack instance doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFormation.Model.StackSetNotFoundException">
        /// The specified stack set doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFormation.Model.StaleRequestException">
        /// Another operation has been performed on this stack set since the specified operation
        /// was performed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/UpdateStackInstances">REST API Reference for UpdateStackInstances Operation</seealso>
        public virtual UpdateStackInstancesResponse UpdateStackInstances(UpdateStackInstancesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateStackInstancesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateStackInstancesResponseUnmarshaller.Instance;

            return Invoke<UpdateStackInstancesResponse>(request, options);
        }


        /// <summary>
        /// Updates the parameter values for stack instances for the specified accounts, within
        /// the specified Regions. A stack instance refers to a stack in a specific account and
        /// Region. 
        /// 
        ///  
        /// <para>
        /// You can only update stack instances in Regions and accounts where they already exist;
        /// to create additional stack instances, use <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/APIReference/API_CreateStackInstances.html">CreateStackInstances</a>.
        /// 
        /// </para>
        ///  
        /// <para>
        /// During stack set updates, any parameters overridden for a stack instance are not updated,
        /// but retain their overridden value.
        /// </para>
        ///  
        /// <para>
        /// You can only update the parameter <i>values</i> that are specified in the stack set;
        /// to add or delete a parameter itself, use <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/APIReference/API_UpdateStackSet.html">UpdateStackSet</a>
        /// to update the stack set template. If you add a parameter to a template, before you
        /// can override the parameter value specified in the stack set you must first use <a
        /// href="https://docs.aws.amazon.com/AWSCloudFormation/latest/APIReference/API_UpdateStackSet.html">UpdateStackSet</a>
        /// to update all stack instances with the updated template and parameter value specified
        /// in the stack set. Once a stack instance has been updated with the new parameter, you
        /// can then override the parameter value using <code>UpdateStackInstances</code>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateStackInstances service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateStackInstances service method, as returned by CloudFormation.</returns>
        /// <exception cref="Amazon.CloudFormation.Model.InvalidOperationException">
        /// The specified operation isn't valid.
        /// </exception>
        /// <exception cref="Amazon.CloudFormation.Model.OperationIdAlreadyExistsException">
        /// The specified operation ID already exists.
        /// </exception>
        /// <exception cref="Amazon.CloudFormation.Model.OperationInProgressException">
        /// Another operation is currently in progress for this stack set. Only one operation
        /// can be performed for a stack set at a given time.
        /// </exception>
        /// <exception cref="Amazon.CloudFormation.Model.StackInstanceNotFoundException">
        /// The specified stack instance doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFormation.Model.StackSetNotFoundException">
        /// The specified stack set doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFormation.Model.StaleRequestException">
        /// Another operation has been performed on this stack set since the specified operation
        /// was performed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/UpdateStackInstances">REST API Reference for UpdateStackInstances Operation</seealso>
        public virtual Task<UpdateStackInstancesResponse> UpdateStackInstancesAsync(UpdateStackInstancesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateStackInstancesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateStackInstancesResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateStackInstancesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateStackSet


        /// <summary>
        /// Updates the stack set, and associated stack instances in the specified accounts and
        /// Regions.
        /// 
        ///  
        /// <para>
        /// Even if the stack set operation created by updating the stack set fails (completely
        /// or partially, below or above a specified failure tolerance), the stack set is updated
        /// with your changes. Subsequent <a>CreateStackInstances</a> calls on the specified stack
        /// set use the updated stack set.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateStackSet service method.</param>
        /// 
        /// <returns>The response from the UpdateStackSet service method, as returned by CloudFormation.</returns>
        /// <exception cref="Amazon.CloudFormation.Model.InvalidOperationException">
        /// The specified operation isn't valid.
        /// </exception>
        /// <exception cref="Amazon.CloudFormation.Model.OperationIdAlreadyExistsException">
        /// The specified operation ID already exists.
        /// </exception>
        /// <exception cref="Amazon.CloudFormation.Model.OperationInProgressException">
        /// Another operation is currently in progress for this stack set. Only one operation
        /// can be performed for a stack set at a given time.
        /// </exception>
        /// <exception cref="Amazon.CloudFormation.Model.StackInstanceNotFoundException">
        /// The specified stack instance doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFormation.Model.StackSetNotFoundException">
        /// The specified stack set doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFormation.Model.StaleRequestException">
        /// Another operation has been performed on this stack set since the specified operation
        /// was performed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/UpdateStackSet">REST API Reference for UpdateStackSet Operation</seealso>
        public virtual UpdateStackSetResponse UpdateStackSet(UpdateStackSetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateStackSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateStackSetResponseUnmarshaller.Instance;

            return Invoke<UpdateStackSetResponse>(request, options);
        }


        /// <summary>
        /// Updates the stack set, and associated stack instances in the specified accounts and
        /// Regions.
        /// 
        ///  
        /// <para>
        /// Even if the stack set operation created by updating the stack set fails (completely
        /// or partially, below or above a specified failure tolerance), the stack set is updated
        /// with your changes. Subsequent <a>CreateStackInstances</a> calls on the specified stack
        /// set use the updated stack set.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateStackSet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateStackSet service method, as returned by CloudFormation.</returns>
        /// <exception cref="Amazon.CloudFormation.Model.InvalidOperationException">
        /// The specified operation isn't valid.
        /// </exception>
        /// <exception cref="Amazon.CloudFormation.Model.OperationIdAlreadyExistsException">
        /// The specified operation ID already exists.
        /// </exception>
        /// <exception cref="Amazon.CloudFormation.Model.OperationInProgressException">
        /// Another operation is currently in progress for this stack set. Only one operation
        /// can be performed for a stack set at a given time.
        /// </exception>
        /// <exception cref="Amazon.CloudFormation.Model.StackInstanceNotFoundException">
        /// The specified stack instance doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFormation.Model.StackSetNotFoundException">
        /// The specified stack set doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFormation.Model.StaleRequestException">
        /// Another operation has been performed on this stack set since the specified operation
        /// was performed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/UpdateStackSet">REST API Reference for UpdateStackSet Operation</seealso>
        public virtual Task<UpdateStackSetResponse> UpdateStackSetAsync(UpdateStackSetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateStackSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateStackSetResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateStackSetResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateTerminationProtection


        /// <summary>
        /// Updates termination protection for the specified stack. If a user attempts to delete
        /// a stack with termination protection enabled, the operation fails and the stack remains
        /// unchanged. For more information, see <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/using-cfn-protect-stacks.html">Protecting
        /// a Stack From Being Deleted</a> in the <i>AWS CloudFormation User Guide</i>.
        /// 
        ///  
        /// <para>
        ///  For <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/using-cfn-nested-stacks.html">nested
        /// stacks</a>, termination protection is set on the root stack and cannot be changed
        /// directly on the nested stack.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateTerminationProtection service method.</param>
        /// 
        /// <returns>The response from the UpdateTerminationProtection service method, as returned by CloudFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/UpdateTerminationProtection">REST API Reference for UpdateTerminationProtection Operation</seealso>
        public virtual UpdateTerminationProtectionResponse UpdateTerminationProtection(UpdateTerminationProtectionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateTerminationProtectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateTerminationProtectionResponseUnmarshaller.Instance;

            return Invoke<UpdateTerminationProtectionResponse>(request, options);
        }


        /// <summary>
        /// Updates termination protection for the specified stack. If a user attempts to delete
        /// a stack with termination protection enabled, the operation fails and the stack remains
        /// unchanged. For more information, see <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/using-cfn-protect-stacks.html">Protecting
        /// a Stack From Being Deleted</a> in the <i>AWS CloudFormation User Guide</i>.
        /// 
        ///  
        /// <para>
        ///  For <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/using-cfn-nested-stacks.html">nested
        /// stacks</a>, termination protection is set on the root stack and cannot be changed
        /// directly on the nested stack.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateTerminationProtection service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateTerminationProtection service method, as returned by CloudFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/UpdateTerminationProtection">REST API Reference for UpdateTerminationProtection Operation</seealso>
        public virtual Task<UpdateTerminationProtectionResponse> UpdateTerminationProtectionAsync(UpdateTerminationProtectionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateTerminationProtectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateTerminationProtectionResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateTerminationProtectionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ValidateTemplate


        /// <summary>
        /// Validates a specified template. AWS CloudFormation first checks if the template is
        /// valid JSON. If it isn't, AWS CloudFormation checks if the template is valid YAML.
        /// If both these checks fail, AWS CloudFormation returns a template validation error.
        /// </summary>
        /// 
        /// <returns>The response from the ValidateTemplate service method, as returned by CloudFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/ValidateTemplate">REST API Reference for ValidateTemplate Operation</seealso>
        public virtual ValidateTemplateResponse ValidateTemplate()
        {
            return ValidateTemplate(new ValidateTemplateRequest());
        }


        /// <summary>
        /// Validates a specified template. AWS CloudFormation first checks if the template is
        /// valid JSON. If it isn't, AWS CloudFormation checks if the template is valid YAML.
        /// If both these checks fail, AWS CloudFormation returns a template validation error.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ValidateTemplate service method.</param>
        /// 
        /// <returns>The response from the ValidateTemplate service method, as returned by CloudFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/ValidateTemplate">REST API Reference for ValidateTemplate Operation</seealso>
        public virtual ValidateTemplateResponse ValidateTemplate(ValidateTemplateRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ValidateTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ValidateTemplateResponseUnmarshaller.Instance;

            return Invoke<ValidateTemplateResponse>(request, options);
        }


        /// <summary>
        /// Validates a specified template. AWS CloudFormation first checks if the template is
        /// valid JSON. If it isn't, AWS CloudFormation checks if the template is valid YAML.
        /// If both these checks fail, AWS CloudFormation returns a template validation error.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ValidateTemplate service method, as returned by CloudFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/ValidateTemplate">REST API Reference for ValidateTemplate Operation</seealso>
        public virtual Task<ValidateTemplateResponse> ValidateTemplateAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return ValidateTemplateAsync(new ValidateTemplateRequest(), cancellationToken);
        }

        /// <summary>
        /// Validates a specified template. AWS CloudFormation first checks if the template is
        /// valid JSON. If it isn't, AWS CloudFormation checks if the template is valid YAML.
        /// If both these checks fail, AWS CloudFormation returns a template validation error.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ValidateTemplate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ValidateTemplate service method, as returned by CloudFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/ValidateTemplate">REST API Reference for ValidateTemplate Operation</seealso>
        public virtual Task<ValidateTemplateResponse> ValidateTemplateAsync(ValidateTemplateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ValidateTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ValidateTemplateResponseUnmarshaller.Instance;
            
            return InvokeAsync<ValidateTemplateResponse>(request, options, cancellationToken);
        }

        #endregion
        
    }
}