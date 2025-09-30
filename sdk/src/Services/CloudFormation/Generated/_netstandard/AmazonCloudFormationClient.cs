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
using Amazon.Runtime.Endpoints;

#pragma warning disable CS1570
namespace Amazon.CloudFormation
{
    /// <summary>
    /// <para>Implementation for accessing CloudFormation</para>
    ///
    /// CloudFormation 
    /// <para>
    /// CloudFormation allows you to create and manage Amazon Web Services infrastructure
    /// deployments predictably and repeatedly. You can use CloudFormation to leverage Amazon
    /// Web Services products, such as Amazon Elastic Compute Cloud, Amazon Elastic Block
    /// Store, Amazon Simple Notification Service, Elastic Load Balancing, and Amazon EC2
    /// Auto Scaling to build highly reliable, highly scalable, cost-effective applications
    /// without creating or configuring the underlying Amazon Web Services infrastructure.
    /// </para>
    ///  
    /// <para>
    /// With CloudFormation, you declare all your resources and dependencies in a template
    /// file. The template defines a collection of resources as a single unit called a stack.
    /// CloudFormation creates and deletes all member resources of the stack together and
    /// manages all dependencies between the resources for you.
    /// </para>
    ///  
    /// <para>
    /// For more information about CloudFormation, see the <a href="http://aws.amazon.com/cloudformation/">CloudFormation
    /// product page</a>.
    /// </para>
    ///  
    /// <para>
    /// CloudFormation makes use of other Amazon Web Services products. If you need additional
    /// technical information about a specific Amazon Web Services product, you can find the
    /// product's technical documentation at <a href="https://docs.aws.amazon.com/">docs.aws.amazon.com</a>.
    /// </para>
    /// </summary>
    public partial class AmazonCloudFormationClient : AmazonServiceClient, IAmazonCloudFormation
    {
        private static IServiceMetadata serviceMetadata = new AmazonCloudFormationMetadata();
        
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
            : base(new AmazonCloudFormationConfig()) { }

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
            : base(new AmazonCloudFormationConfig{RegionEndpoint = region}) { }

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
            : base(config) { }


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
#if AWS_ASYNC_ENUMERABLES_API
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
#endif

        #region Overrides

        /// <summary>
        /// Customizes the runtime pipeline.
        /// </summary>
        /// <param name="pipeline">Runtime pipeline for the current client.</param>
        protected override void CustomizeRuntimePipeline(RuntimePipeline pipeline)
        {
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new Amazon.CloudFormation.Internal.ProcessRequestHandler());
            pipeline.RemoveHandler<Amazon.Runtime.Internal.EndpointResolver>();
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonCloudFormationEndpointResolver());
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonCloudFormationAuthSchemeHandler());
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


        #region  ActivateOrganizationsAccess

        internal virtual ActivateOrganizationsAccessResponse ActivateOrganizationsAccess(ActivateOrganizationsAccessRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ActivateOrganizationsAccessRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ActivateOrganizationsAccessResponseUnmarshaller.Instance;

            return Invoke<ActivateOrganizationsAccessResponse>(request, options);
        }



        /// <summary>
        /// Activate trusted access with Organizations. With trusted access between StackSets
        /// and Organizations activated, the management account has permissions to create and
        /// manage StackSets for your organization.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ActivateOrganizationsAccess service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ActivateOrganizationsAccess service method, as returned by CloudFormation.</returns>
        /// <exception cref="Amazon.CloudFormation.Model.InvalidOperationException">
        /// The specified operation isn't valid.
        /// </exception>
        /// <exception cref="Amazon.CloudFormation.Model.OperationNotFoundException">
        /// The specified ID refers to an operation that doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/ActivateOrganizationsAccess">REST API Reference for ActivateOrganizationsAccess Operation</seealso>
        public virtual Task<ActivateOrganizationsAccessResponse> ActivateOrganizationsAccessAsync(ActivateOrganizationsAccessRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ActivateOrganizationsAccessRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ActivateOrganizationsAccessResponseUnmarshaller.Instance;

            return InvokeAsync<ActivateOrganizationsAccessResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ActivateType

        internal virtual ActivateTypeResponse ActivateType(ActivateTypeRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ActivateTypeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ActivateTypeResponseUnmarshaller.Instance;

            return Invoke<ActivateTypeResponse>(request, options);
        }



        /// <summary>
        /// Activates a public third-party extension, such as a resource or module, to make it
        /// available for use in stack templates in your current account and Region. It can also
        /// create CloudFormation Hooks, which allow you to evaluate resource configurations before
        /// CloudFormation provisions them. Hooks integrate with both CloudFormation and Cloud
        /// Control API operations.
        /// 
        ///  
        /// <para>
        /// After you activate an extension, you can use <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/APIReference/API_SetTypeConfiguration.html">SetTypeConfiguration</a>
        /// to set specific properties for the extension.
        /// </para>
        ///  
        /// <para>
        /// To see which extensions have been activated, use <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/APIReference/API_ListTypes.html">ListTypes</a>.
        /// To see configuration details for an extension, use <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/APIReference/API_DescribeType.html">DescribeType</a>.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/registry-public-activate-extension.html">Activate
        /// a third-party public extension in your account</a> in the <i>CloudFormation User Guide</i>.
        /// For information about creating Hooks, see the <a href="https://docs.aws.amazon.com/cloudformation-cli/latest/hooks-userguide/what-is-cloudformation-hooks.html">CloudFormation
        /// Hooks User Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ActivateType service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ActivateType service method, as returned by CloudFormation.</returns>
        /// <exception cref="Amazon.CloudFormation.Model.CFNRegistryException">
        /// An error occurred during a CloudFormation registry operation.
        /// </exception>
        /// <exception cref="Amazon.CloudFormation.Model.TypeNotFoundException">
        /// The specified extension doesn't exist in the CloudFormation registry.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/ActivateType">REST API Reference for ActivateType Operation</seealso>
        public virtual Task<ActivateTypeResponse> ActivateTypeAsync(ActivateTypeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ActivateTypeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ActivateTypeResponseUnmarshaller.Instance;

            return InvokeAsync<ActivateTypeResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  BatchDescribeTypeConfigurations

        internal virtual BatchDescribeTypeConfigurationsResponse BatchDescribeTypeConfigurations(BatchDescribeTypeConfigurationsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchDescribeTypeConfigurationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchDescribeTypeConfigurationsResponseUnmarshaller.Instance;

            return Invoke<BatchDescribeTypeConfigurationsResponse>(request, options);
        }



        /// <summary>
        /// Returns configuration data for the specified CloudFormation extensions, from the CloudFormation
        /// registry in your current account and Region.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/registry-set-configuration.html">Edit
        /// configuration data for extensions in your account</a> in the <i>CloudFormation User
        /// Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchDescribeTypeConfigurations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchDescribeTypeConfigurations service method, as returned by CloudFormation.</returns>
        /// <exception cref="Amazon.CloudFormation.Model.CFNRegistryException">
        /// An error occurred during a CloudFormation registry operation.
        /// </exception>
        /// <exception cref="Amazon.CloudFormation.Model.TypeConfigurationNotFoundException">
        /// The specified extension configuration can't be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/BatchDescribeTypeConfigurations">REST API Reference for BatchDescribeTypeConfigurations Operation</seealso>
        public virtual Task<BatchDescribeTypeConfigurationsResponse> BatchDescribeTypeConfigurationsAsync(BatchDescribeTypeConfigurationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchDescribeTypeConfigurationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchDescribeTypeConfigurationsResponseUnmarshaller.Instance;

            return InvokeAsync<BatchDescribeTypeConfigurationsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CancelUpdateStack

        internal virtual CancelUpdateStackResponse CancelUpdateStack(CancelUpdateStackRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
        /// You can cancel only stacks that are in the <c>UPDATE_IN_PROGRESS</c> state.
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CancelUpdateStackRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelUpdateStackResponseUnmarshaller.Instance;

            return InvokeAsync<CancelUpdateStackResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ContinueUpdateRollback

        internal virtual ContinueUpdateRollbackResponse ContinueUpdateRollback(ContinueUpdateRollbackRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ContinueUpdateRollbackRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ContinueUpdateRollbackResponseUnmarshaller.Instance;

            return Invoke<ContinueUpdateRollbackResponse>(request, options);
        }



        /// <summary>
        /// Continues rolling back a stack from <c>UPDATE_ROLLBACK_FAILED</c> to <c>UPDATE_ROLLBACK_COMPLETE</c>
        /// state. Depending on the cause of the failure, you can manually fix the error and continue
        /// the rollback. By continuing the rollback, you can return your stack to a working state
        /// (the <c>UPDATE_ROLLBACK_COMPLETE</c> state) and then try to update the stack again.
        /// 
        ///  
        /// <para>
        /// A stack enters the <c>UPDATE_ROLLBACK_FAILED</c> state when CloudFormation can't roll
        /// back all changes after a failed stack update. For example, this might occur when a
        /// stack attempts to roll back to an old database that was deleted outside of CloudFormation.
        /// Because CloudFormation doesn't know the instance was deleted, it assumes the instance
        /// still exists and attempts to roll back to it, causing the update rollback to fail.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/using-cfn-updating-stacks-continueupdaterollback.html">Continue
        /// rolling back an update</a> in the <i>CloudFormation User Guide</i>. For information
        /// for troubleshooting a failed update rollback, see <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/troubleshooting.html#troubleshooting-errors-update-rollback-failed">Update
        /// rollback failed</a>.
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ContinueUpdateRollbackRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ContinueUpdateRollbackResponseUnmarshaller.Instance;

            return InvokeAsync<ContinueUpdateRollbackResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateChangeSet

        internal virtual CreateChangeSetResponse CreateChangeSet(CreateChangeSetRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateChangeSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateChangeSetResponseUnmarshaller.Instance;

            return Invoke<CreateChangeSetResponse>(request, options);
        }



        /// <summary>
        /// Creates a list of changes that will be applied to a stack so that you can review the
        /// changes before executing them. You can create a change set for a stack that doesn't
        /// exist or an existing stack. If you create a change set for a stack that doesn't exist,
        /// the change set shows all of the resources that CloudFormation will create. If you
        /// create a change set for an existing stack, CloudFormation compares the stack's information
        /// with the information that you submit in the change set and lists the differences.
        /// Use change sets to understand which resources CloudFormation will create or change,
        /// and how it will change resources in an existing stack, before you create or update
        /// a stack.
        /// 
        ///  
        /// <para>
        /// To create a change set for a stack that doesn't exist, for the <c>ChangeSetType</c>
        /// parameter, specify <c>CREATE</c>. To create a change set for an existing stack, specify
        /// <c>UPDATE</c> for the <c>ChangeSetType</c> parameter. To create a change set for an
        /// import operation, specify <c>IMPORT</c> for the <c>ChangeSetType</c> parameter. After
        /// the <c>CreateChangeSet</c> call successfully completes, CloudFormation starts creating
        /// the change set. To check the status of the change set or to review it, use the <a>DescribeChangeSet</a>
        /// action.
        /// </para>
        ///  
        /// <para>
        /// When you are satisfied with the changes the change set will make, execute the change
        /// set by using the <a>ExecuteChangeSet</a> action. CloudFormation doesn't make changes
        /// until you execute the change set.
        /// </para>
        ///  
        /// <para>
        /// To create a change set for the entire stack hierarchy, set <c>IncludeNestedStacks</c>
        /// to <c>True</c>.
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
        /// For information about resource and stack limitations, see <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/cloudformation-limits.html">CloudFormation
        /// quotas</a> in the <i>CloudFormation User Guide</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/CreateChangeSet">REST API Reference for CreateChangeSet Operation</seealso>
        public virtual Task<CreateChangeSetResponse> CreateChangeSetAsync(CreateChangeSetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateChangeSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateChangeSetResponseUnmarshaller.Instance;

            return InvokeAsync<CreateChangeSetResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateGeneratedTemplate

        internal virtual CreateGeneratedTemplateResponse CreateGeneratedTemplate(CreateGeneratedTemplateRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateGeneratedTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateGeneratedTemplateResponseUnmarshaller.Instance;

            return Invoke<CreateGeneratedTemplateResponse>(request, options);
        }



        /// <summary>
        /// Creates a template from existing resources that are not already managed with CloudFormation.
        /// You can check the status of the template generation using the <c>DescribeGeneratedTemplate</c>
        /// API action.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateGeneratedTemplate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateGeneratedTemplate service method, as returned by CloudFormation.</returns>
        /// <exception cref="Amazon.CloudFormation.Model.AlreadyExistsException">
        /// The resource with the name requested already exists.
        /// </exception>
        /// <exception cref="Amazon.CloudFormation.Model.ConcurrentResourcesLimitExceededException">
        /// No more than 5 generated templates can be in an <c>InProgress</c> or <c>Pending</c>
        /// status at one time. This error is also returned if a generated template that is in
        /// an <c>InProgress</c> or <c>Pending</c> status is attempted to be updated or deleted.
        /// </exception>
        /// <exception cref="Amazon.CloudFormation.Model.LimitExceededException">
        /// The quota for the resource has already been reached.
        /// 
        ///  
        /// <para>
        /// For information about resource and stack limitations, see <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/cloudformation-limits.html">CloudFormation
        /// quotas</a> in the <i>CloudFormation User Guide</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/CreateGeneratedTemplate">REST API Reference for CreateGeneratedTemplate Operation</seealso>
        public virtual Task<CreateGeneratedTemplateResponse> CreateGeneratedTemplateAsync(CreateGeneratedTemplateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateGeneratedTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateGeneratedTemplateResponseUnmarshaller.Instance;

            return InvokeAsync<CreateGeneratedTemplateResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateStack

        internal virtual CreateStackResponse CreateStack(CreateStackRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateStackRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateStackResponseUnmarshaller.Instance;

            return Invoke<CreateStackResponse>(request, options);
        }



        /// <summary>
        /// Creates a stack as specified in the template. After the call completes successfully,
        /// the stack creation starts. You can check the status of the stack through the <a>DescribeStacks</a>
        /// operation.
        /// 
        ///  
        /// <para>
        /// For more information about creating a stack and monitoring stack progress, see <a
        /// href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/stacks.html">Managing
        /// Amazon Web Services resources as a single unit with CloudFormation stacks</a> in the
        /// <i>CloudFormation User Guide</i>.
        /// </para>
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
        /// For information about resource and stack limitations, see <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/cloudformation-limits.html">CloudFormation
        /// quotas</a> in the <i>CloudFormation User Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.CloudFormation.Model.TokenAlreadyExistsException">
        /// A client request token already exists.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/CreateStack">REST API Reference for CreateStack Operation</seealso>
        public virtual Task<CreateStackResponse> CreateStackAsync(CreateStackRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateStackRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateStackResponseUnmarshaller.Instance;

            return InvokeAsync<CreateStackResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateStackInstances

        internal virtual CreateStackInstancesResponse CreateStackInstances(CreateStackInstancesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateStackInstancesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateStackInstancesResponseUnmarshaller.Instance;

            return Invoke<CreateStackInstancesResponse>(request, options);
        }



        /// <summary>
        /// Creates stack instances for the specified accounts, within the specified Amazon Web
        /// Services Regions. A stack instance refers to a stack in a specific account and Region.
        /// You must specify at least one value for either <c>Accounts</c> or <c>DeploymentTargets</c>,
        /// and you must specify at least one value for <c>Regions</c>.
        /// 
        ///  <note> 
        /// <para>
        /// The maximum number of organizational unit (OUs) supported by a <c>CreateStackInstances</c>
        /// operation is 50.
        /// </para>
        ///  
        /// <para>
        /// If you need more than 50, consider the following options:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <i>Batch processing:</i> If you don't want to expose your OU hierarchy, split up
        /// the operations into multiple calls with less than 50 OUs each.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>Parent OU strategy:</i> If you don't mind exposing the OU hierarchy, target a
        /// parent OU that contains all desired child OUs.
        /// </para>
        ///  </li> </ul> </note>
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
        /// For information about resource and stack limitations, see <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/cloudformation-limits.html">CloudFormation
        /// quotas</a> in the <i>CloudFormation User Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.CloudFormation.Model.OperationIdAlreadyExistsException">
        /// The specified operation ID already exists.
        /// </exception>
        /// <exception cref="Amazon.CloudFormation.Model.OperationInProgressException">
        /// Another operation is currently in progress for this StackSet. Only one operation can
        /// be performed for a stack set at a given time.
        /// </exception>
        /// <exception cref="Amazon.CloudFormation.Model.StackSetNotFoundException">
        /// The specified StackSet doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFormation.Model.StaleRequestException">
        /// Another operation has been performed on this StackSet since the specified operation
        /// was performed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/CreateStackInstances">REST API Reference for CreateStackInstances Operation</seealso>
        public virtual Task<CreateStackInstancesResponse> CreateStackInstancesAsync(CreateStackInstancesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateStackInstancesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateStackInstancesResponseUnmarshaller.Instance;

            return InvokeAsync<CreateStackInstancesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateStackRefactor

        internal virtual CreateStackRefactorResponse CreateStackRefactor(CreateStackRefactorRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateStackRefactorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateStackRefactorResponseUnmarshaller.Instance;

            return Invoke<CreateStackRefactorResponse>(request, options);
        }



        /// <summary>
        /// Creates a refactor across multiple stacks, with the list of stacks and resources that
        /// are affected.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateStackRefactor service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateStackRefactor service method, as returned by CloudFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/CreateStackRefactor">REST API Reference for CreateStackRefactor Operation</seealso>
        public virtual Task<CreateStackRefactorResponse> CreateStackRefactorAsync(CreateStackRefactorRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateStackRefactorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateStackRefactorResponseUnmarshaller.Instance;

            return InvokeAsync<CreateStackRefactorResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateStackSet

        internal virtual CreateStackSetResponse CreateStackSet(CreateStackSetRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateStackSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateStackSetResponseUnmarshaller.Instance;

            return Invoke<CreateStackSetResponse>(request, options);
        }



        /// <summary>
        /// Creates a StackSet.
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
        /// For information about resource and stack limitations, see <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/cloudformation-limits.html">CloudFormation
        /// quotas</a> in the <i>CloudFormation User Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.CloudFormation.Model.NameAlreadyExistsException">
        /// The specified name is already in use.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/CreateStackSet">REST API Reference for CreateStackSet Operation</seealso>
        public virtual Task<CreateStackSetResponse> CreateStackSetAsync(CreateStackSetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateStackSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateStackSetResponseUnmarshaller.Instance;

            return InvokeAsync<CreateStackSetResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeactivateOrganizationsAccess

        internal virtual DeactivateOrganizationsAccessResponse DeactivateOrganizationsAccess(DeactivateOrganizationsAccessRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeactivateOrganizationsAccessRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeactivateOrganizationsAccessResponseUnmarshaller.Instance;

            return Invoke<DeactivateOrganizationsAccessResponse>(request, options);
        }



        /// <summary>
        /// Deactivates trusted access with Organizations. If trusted access is deactivated, the
        /// management account does not have permissions to create and manage service-managed
        /// StackSets for your organization.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeactivateOrganizationsAccess service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeactivateOrganizationsAccess service method, as returned by CloudFormation.</returns>
        /// <exception cref="Amazon.CloudFormation.Model.InvalidOperationException">
        /// The specified operation isn't valid.
        /// </exception>
        /// <exception cref="Amazon.CloudFormation.Model.OperationNotFoundException">
        /// The specified ID refers to an operation that doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/DeactivateOrganizationsAccess">REST API Reference for DeactivateOrganizationsAccess Operation</seealso>
        public virtual Task<DeactivateOrganizationsAccessResponse> DeactivateOrganizationsAccessAsync(DeactivateOrganizationsAccessRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeactivateOrganizationsAccessRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeactivateOrganizationsAccessResponseUnmarshaller.Instance;

            return InvokeAsync<DeactivateOrganizationsAccessResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeactivateType

        internal virtual DeactivateTypeResponse DeactivateType(DeactivateTypeRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeactivateTypeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeactivateTypeResponseUnmarshaller.Instance;

            return Invoke<DeactivateTypeResponse>(request, options);
        }



        /// <summary>
        /// Deactivates a public third-party extension, such as a resource or module, or a CloudFormation
        /// Hook when you no longer use it.
        /// 
        ///  
        /// <para>
        /// Deactivating an extension deletes the configuration details that are associated with
        /// it. To temporary disable a CloudFormation Hook instead, you can use <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/APIReference/API_SetTypeConfiguration.html">SetTypeConfiguration</a>.
        /// </para>
        ///  
        /// <para>
        /// Once deactivated, an extension can't be used in any CloudFormation operation. This
        /// includes stack update operations where the stack template includes the extension,
        /// even if no updates are being made to the extension. In addition, deactivated extensions
        /// aren't automatically updated if a new version of the extension is released.
        /// </para>
        ///  
        /// <para>
        /// To see which extensions are currently activated, use <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/APIReference/API_ListTypes.html">ListTypes</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeactivateType service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeactivateType service method, as returned by CloudFormation.</returns>
        /// <exception cref="Amazon.CloudFormation.Model.CFNRegistryException">
        /// An error occurred during a CloudFormation registry operation.
        /// </exception>
        /// <exception cref="Amazon.CloudFormation.Model.TypeNotFoundException">
        /// The specified extension doesn't exist in the CloudFormation registry.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/DeactivateType">REST API Reference for DeactivateType Operation</seealso>
        public virtual Task<DeactivateTypeResponse> DeactivateTypeAsync(DeactivateTypeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeactivateTypeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeactivateTypeResponseUnmarshaller.Instance;

            return InvokeAsync<DeactivateTypeResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteChangeSet

        internal virtual DeleteChangeSetResponse DeleteChangeSet(DeleteChangeSetRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
        /// If the call successfully completes, CloudFormation successfully deleted the change
        /// set.
        /// </para>
        ///  
        /// <para>
        /// If <c>IncludeNestedStacks</c> specifies <c>True</c> during the creation of the nested
        /// change set, then <c>DeleteChangeSet</c> will delete all change sets that belong to
        /// the stacks hierarchy and will also delete all change sets for nested stacks with the
        /// status of <c>REVIEW_IN_PROGRESS</c>.
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
        /// set status might be <c>CREATE_IN_PROGRESS</c>, or the stack status might be <c>UPDATE_IN_PROGRESS</c>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/DeleteChangeSet">REST API Reference for DeleteChangeSet Operation</seealso>
        public virtual Task<DeleteChangeSetResponse> DeleteChangeSetAsync(DeleteChangeSetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteChangeSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteChangeSetResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteChangeSetResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteGeneratedTemplate

        internal virtual DeleteGeneratedTemplateResponse DeleteGeneratedTemplate(DeleteGeneratedTemplateRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteGeneratedTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteGeneratedTemplateResponseUnmarshaller.Instance;

            return Invoke<DeleteGeneratedTemplateResponse>(request, options);
        }



        /// <summary>
        /// Deleted a generated template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteGeneratedTemplate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteGeneratedTemplate service method, as returned by CloudFormation.</returns>
        /// <exception cref="Amazon.CloudFormation.Model.ConcurrentResourcesLimitExceededException">
        /// No more than 5 generated templates can be in an <c>InProgress</c> or <c>Pending</c>
        /// status at one time. This error is also returned if a generated template that is in
        /// an <c>InProgress</c> or <c>Pending</c> status is attempted to be updated or deleted.
        /// </exception>
        /// <exception cref="Amazon.CloudFormation.Model.GeneratedTemplateNotFoundException">
        /// The generated template was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/DeleteGeneratedTemplate">REST API Reference for DeleteGeneratedTemplate Operation</seealso>
        public virtual Task<DeleteGeneratedTemplateResponse> DeleteGeneratedTemplateAsync(DeleteGeneratedTemplateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteGeneratedTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteGeneratedTemplateResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteGeneratedTemplateResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteStack

        internal virtual DeleteStackResponse DeleteStack(DeleteStackRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteStackRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteStackResponseUnmarshaller.Instance;

            return Invoke<DeleteStackResponse>(request, options);
        }



        /// <summary>
        /// Deletes a specified stack. Once the call completes successfully, stack deletion starts.
        /// Deleted stacks don't show up in the <a>DescribeStacks</a> operation if the deletion
        /// has been completed successfully.
        /// 
        ///  
        /// <para>
        /// For more information about deleting a stack, see <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/cfn-console-delete-stack.html">Delete
        /// a stack from the CloudFormation console</a> in the <i>CloudFormation User Guide</i>.
        /// </para>
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteStackRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteStackResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteStackResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteStackInstances

        internal virtual DeleteStackInstancesResponse DeleteStackInstances(DeleteStackInstancesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteStackInstancesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteStackInstancesResponseUnmarshaller.Instance;

            return Invoke<DeleteStackInstancesResponse>(request, options);
        }



        /// <summary>
        /// Deletes stack instances for the specified accounts, in the specified Amazon Web Services
        /// Regions.
        /// 
        ///  <note> 
        /// <para>
        /// The maximum number of organizational unit (OUs) supported by a <c>DeleteStackInstances</c>
        /// operation is 50.
        /// </para>
        ///  
        /// <para>
        /// If you need more than 50, consider the following options:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <i>Batch processing:</i> If you don't want to expose your OU hierarchy, split up
        /// the operations into multiple calls with less than 50 OUs each.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>Parent OU strategy:</i> If you don't mind exposing the OU hierarchy, target a
        /// parent OU that contains all desired child OUs.
        /// </para>
        ///  </li> </ul> </note>
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
        /// Another operation is currently in progress for this StackSet. Only one operation can
        /// be performed for a stack set at a given time.
        /// </exception>
        /// <exception cref="Amazon.CloudFormation.Model.StackSetNotFoundException">
        /// The specified StackSet doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFormation.Model.StaleRequestException">
        /// Another operation has been performed on this StackSet since the specified operation
        /// was performed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/DeleteStackInstances">REST API Reference for DeleteStackInstances Operation</seealso>
        public virtual Task<DeleteStackInstancesResponse> DeleteStackInstancesAsync(DeleteStackInstancesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteStackInstancesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteStackInstancesResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteStackInstancesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteStackSet

        internal virtual DeleteStackSetResponse DeleteStackSet(DeleteStackSetRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteStackSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteStackSetResponseUnmarshaller.Instance;

            return Invoke<DeleteStackSetResponse>(request, options);
        }



        /// <summary>
        /// Deletes a StackSet. Before you can delete a StackSet, all its member stack instances
        /// must be deleted. For more information about how to complete this, see <a>DeleteStackInstances</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteStackSet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteStackSet service method, as returned by CloudFormation.</returns>
        /// <exception cref="Amazon.CloudFormation.Model.OperationInProgressException">
        /// Another operation is currently in progress for this StackSet. Only one operation can
        /// be performed for a stack set at a given time.
        /// </exception>
        /// <exception cref="Amazon.CloudFormation.Model.StackSetNotEmptyException">
        /// You can't yet delete this StackSet, because it still contains one or more stack instances.
        /// Delete all stack instances from the StackSet before deleting the StackSet.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/DeleteStackSet">REST API Reference for DeleteStackSet Operation</seealso>
        public virtual Task<DeleteStackSetResponse> DeleteStackSetAsync(DeleteStackSetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteStackSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteStackSetResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteStackSetResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeregisterType

        internal virtual DeregisterTypeResponse DeregisterType(DeregisterTypeRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeregisterTypeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeregisterTypeResponseUnmarshaller.Instance;

            return Invoke<DeregisterTypeResponse>(request, options);
        }



        /// <summary>
        /// Marks an extension or extension version as <c>DEPRECATED</c> in the CloudFormation
        /// registry, removing it from active use. Deprecated extensions or extension versions
        /// cannot be used in CloudFormation operations.
        /// 
        ///  
        /// <para>
        /// To deregister an entire extension, you must individually deregister all active versions
        /// of that extension. If an extension has only a single active version, deregistering
        /// that version results in the extension itself being deregistered and marked as deprecated
        /// in the registry.
        /// </para>
        ///  
        /// <para>
        /// You can't deregister the default version of an extension if there are other active
        /// version of that extension. If you do deregister the default version of an extension,
        /// the extension type itself is deregistered as well and marked as deprecated.
        /// </para>
        ///  
        /// <para>
        /// To view the deprecation status of an extension or extension version, use <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/APIReference/API_DescribeType.html">DescribeType</a>.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/registry-private-deregister-extension.html">Remove
        /// third-party private extensions from your account</a> in the <i>CloudFormation User
        /// Guide</i>.
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
        /// The specified extension doesn't exist in the CloudFormation registry.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/DeregisterType">REST API Reference for DeregisterType Operation</seealso>
        public virtual Task<DeregisterTypeResponse> DeregisterTypeAsync(DeregisterTypeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeregisterTypeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeregisterTypeResponseUnmarshaller.Instance;

            return InvokeAsync<DeregisterTypeResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeAccountLimits

        internal virtual DescribeAccountLimitsResponse DescribeAccountLimits(DescribeAccountLimitsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeAccountLimitsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAccountLimitsResponseUnmarshaller.Instance;

            return Invoke<DescribeAccountLimitsResponse>(request, options);
        }



        /// <summary>
        /// Retrieves your account's CloudFormation limits, such as the maximum number of stacks
        /// that you can create in your account. For more information about account limits, see
        /// <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/cloudformation-limits.html">Understand
        /// CloudFormation quotas</a> in the <i>CloudFormation User Guide</i>.
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeAccountLimitsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAccountLimitsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeAccountLimitsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeChangeSet

        internal virtual DescribeChangeSetResponse DescribeChangeSet(DescribeChangeSetRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeChangeSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeChangeSetResponseUnmarshaller.Instance;

            return Invoke<DescribeChangeSetResponse>(request, options);
        }



        /// <summary>
        /// Returns the inputs for the change set and a list of changes that CloudFormation will
        /// make if you execute the change set. For more information, see <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/using-cfn-updating-stacks-changesets.html">Update
        /// CloudFormation stacks using change sets</a> in the <i>CloudFormation User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeChangeSet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeChangeSet service method, as returned by CloudFormation.</returns>
        /// <exception cref="Amazon.CloudFormation.Model.ChangeSetNotFoundException">
        /// The specified change set name or ID doesn't exit. To view valid change sets for a
        /// stack, use the <c>ListChangeSets</c> operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/DescribeChangeSet">REST API Reference for DescribeChangeSet Operation</seealso>
        public virtual Task<DescribeChangeSetResponse> DescribeChangeSetAsync(DescribeChangeSetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeChangeSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeChangeSetResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeChangeSetResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeChangeSetHooks

        internal virtual DescribeChangeSetHooksResponse DescribeChangeSetHooks(DescribeChangeSetHooksRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeChangeSetHooksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeChangeSetHooksResponseUnmarshaller.Instance;

            return Invoke<DescribeChangeSetHooksResponse>(request, options);
        }



        /// <summary>
        /// Returns hook-related information for the change set and a list of changes that CloudFormation
        /// makes when you run the change set.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeChangeSetHooks service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeChangeSetHooks service method, as returned by CloudFormation.</returns>
        /// <exception cref="Amazon.CloudFormation.Model.ChangeSetNotFoundException">
        /// The specified change set name or ID doesn't exit. To view valid change sets for a
        /// stack, use the <c>ListChangeSets</c> operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/DescribeChangeSetHooks">REST API Reference for DescribeChangeSetHooks Operation</seealso>
        public virtual Task<DescribeChangeSetHooksResponse> DescribeChangeSetHooksAsync(DescribeChangeSetHooksRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeChangeSetHooksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeChangeSetHooksResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeChangeSetHooksResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeGeneratedTemplate

        internal virtual DescribeGeneratedTemplateResponse DescribeGeneratedTemplate(DescribeGeneratedTemplateRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeGeneratedTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeGeneratedTemplateResponseUnmarshaller.Instance;

            return Invoke<DescribeGeneratedTemplateResponse>(request, options);
        }



        /// <summary>
        /// Describes a generated template. The output includes details about the progress of
        /// the creation of a generated template started by a <c>CreateGeneratedTemplate</c> API
        /// action or the update of a generated template started with an <c>UpdateGeneratedTemplate</c>
        /// API action.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeGeneratedTemplate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeGeneratedTemplate service method, as returned by CloudFormation.</returns>
        /// <exception cref="Amazon.CloudFormation.Model.GeneratedTemplateNotFoundException">
        /// The generated template was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/DescribeGeneratedTemplate">REST API Reference for DescribeGeneratedTemplate Operation</seealso>
        public virtual Task<DescribeGeneratedTemplateResponse> DescribeGeneratedTemplateAsync(DescribeGeneratedTemplateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeGeneratedTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeGeneratedTemplateResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeGeneratedTemplateResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeOrganizationsAccess

        internal virtual DescribeOrganizationsAccessResponse DescribeOrganizationsAccess(DescribeOrganizationsAccessRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeOrganizationsAccessRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeOrganizationsAccessResponseUnmarshaller.Instance;

            return Invoke<DescribeOrganizationsAccessResponse>(request, options);
        }



        /// <summary>
        /// Retrieves information about the account's <c>OrganizationAccess</c> status. This API
        /// can be called either by the management account or the delegated administrator by using
        /// the <c>CallAs</c> parameter. This API can also be called without the <c>CallAs</c>
        /// parameter by the management account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeOrganizationsAccess service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeOrganizationsAccess service method, as returned by CloudFormation.</returns>
        /// <exception cref="Amazon.CloudFormation.Model.InvalidOperationException">
        /// The specified operation isn't valid.
        /// </exception>
        /// <exception cref="Amazon.CloudFormation.Model.OperationNotFoundException">
        /// The specified ID refers to an operation that doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/DescribeOrganizationsAccess">REST API Reference for DescribeOrganizationsAccess Operation</seealso>
        public virtual Task<DescribeOrganizationsAccessResponse> DescribeOrganizationsAccessAsync(DescribeOrganizationsAccessRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeOrganizationsAccessRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeOrganizationsAccessResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeOrganizationsAccessResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribePublisher

        internal virtual DescribePublisherResponse DescribePublisher(DescribePublisherRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribePublisherRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribePublisherResponseUnmarshaller.Instance;

            return Invoke<DescribePublisherResponse>(request, options);
        }



        /// <summary>
        /// Returns information about a CloudFormation extension publisher.
        /// 
        ///  
        /// <para>
        /// If you don't supply a <c>PublisherId</c>, and you have registered as an extension
        /// publisher, <c>DescribePublisher</c> returns information about your own publisher account.
        /// </para>
        ///  
        /// <para>
        /// For more information about registering as a publisher, see:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/APIReference/API_RegisterPublisher.html">RegisterPublisher</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/cloudformation-cli/latest/userguide/publish-extension.html">Publishing
        /// extensions to make them available for public use</a> in the <i>CloudFormation Command
        /// Line Interface (CLI) User Guide</i> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribePublisher service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribePublisher service method, as returned by CloudFormation.</returns>
        /// <exception cref="Amazon.CloudFormation.Model.CFNRegistryException">
        /// An error occurred during a CloudFormation registry operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/DescribePublisher">REST API Reference for DescribePublisher Operation</seealso>
        public virtual Task<DescribePublisherResponse> DescribePublisherAsync(DescribePublisherRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribePublisherRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribePublisherResponseUnmarshaller.Instance;

            return InvokeAsync<DescribePublisherResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeResourceScan

        internal virtual DescribeResourceScanResponse DescribeResourceScan(DescribeResourceScanRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeResourceScanRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeResourceScanResponseUnmarshaller.Instance;

            return Invoke<DescribeResourceScanResponse>(request, options);
        }



        /// <summary>
        /// Describes details of a resource scan.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeResourceScan service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeResourceScan service method, as returned by CloudFormation.</returns>
        /// <exception cref="Amazon.CloudFormation.Model.ResourceScanNotFoundException">
        /// The resource scan was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/DescribeResourceScan">REST API Reference for DescribeResourceScan Operation</seealso>
        public virtual Task<DescribeResourceScanResponse> DescribeResourceScanAsync(DescribeResourceScanRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeResourceScanRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeResourceScanResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeResourceScanResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeStackDriftDetectionStatus

        internal virtual DescribeStackDriftDetectionStatusResponse DescribeStackDriftDetectionStatus(DescribeStackDriftDetectionStatusRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeStackDriftDetectionStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeStackDriftDetectionStatusResponseUnmarshaller.Instance;

            return Invoke<DescribeStackDriftDetectionStatusResponse>(request, options);
        }



        /// <summary>
        /// Returns information about a stack drift detection operation. A stack drift detection
        /// operation detects whether a stack's actual configuration differs, or has <i>drifted</i>,
        /// from its expected configuration, as defined in the stack template and any values specified
        /// as template parameters. A stack is considered to have drifted if one or more of its
        /// resources have drifted. For more information about stack and resource drift, see <a
        /// href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/using-cfn-stack-drift.html">Detect
        /// unmanaged configuration changes to stacks and resources with drift detection</a>.
        /// 
        ///  
        /// <para>
        /// Use <a>DetectStackDrift</a> to initiate a stack drift detection operation. <c>DetectStackDrift</c>
        /// returns a <c>StackDriftDetectionId</c> you can use to monitor the progress of the
        /// operation using <c>DescribeStackDriftDetectionStatus</c>. Once the drift detection
        /// operation has completed, use <a>DescribeStackResourceDrifts</a> to return drift information
        /// about the stack and its resources.
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeStackDriftDetectionStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeStackDriftDetectionStatusResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeStackDriftDetectionStatusResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeStackEvents

        internal virtual DescribeStackEventsResponse DescribeStackEvents(DescribeStackEventsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeStackEventsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeStackEventsResponseUnmarshaller.Instance;

            return Invoke<DescribeStackEventsResponse>(request, options);
        }



        /// <summary>
        /// Returns all stack related events for a specified stack in reverse chronological order.
        /// For more information about a stack's event history, see <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/stack-resource-configuration-complete.html">Understand
        /// CloudFormation stack creation events</a> in the <i>CloudFormation User Guide</i>.
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeStackEventsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeStackEventsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeStackEventsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeStackInstance

        internal virtual DescribeStackInstanceResponse DescribeStackInstance(DescribeStackInstanceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeStackInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeStackInstanceResponseUnmarshaller.Instance;

            return Invoke<DescribeStackInstanceResponse>(request, options);
        }



        /// <summary>
        /// Returns the stack instance that's associated with the specified StackSet, Amazon Web
        /// Services account, and Amazon Web Services Region.
        /// 
        ///  
        /// <para>
        /// For a list of stack instances that are associated with a specific StackSet, use <a>ListStackInstances</a>.
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
        /// The specified StackSet doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/DescribeStackInstance">REST API Reference for DescribeStackInstance Operation</seealso>
        public virtual Task<DescribeStackInstanceResponse> DescribeStackInstanceAsync(DescribeStackInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeStackInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeStackInstanceResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeStackInstanceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeStackRefactor

        internal virtual DescribeStackRefactorResponse DescribeStackRefactor(DescribeStackRefactorRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeStackRefactorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeStackRefactorResponseUnmarshaller.Instance;

            return Invoke<DescribeStackRefactorResponse>(request, options);
        }



        /// <summary>
        /// Describes the stack refactor status.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeStackRefactor service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeStackRefactor service method, as returned by CloudFormation.</returns>
        /// <exception cref="Amazon.CloudFormation.Model.StackRefactorNotFoundException">
        /// The specified stack refactor can't be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/DescribeStackRefactor">REST API Reference for DescribeStackRefactor Operation</seealso>
        public virtual Task<DescribeStackRefactorResponse> DescribeStackRefactorAsync(DescribeStackRefactorRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeStackRefactorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeStackRefactorResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeStackRefactorResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeStackResource

        internal virtual DescribeStackResourceResponse DescribeStackResource(DescribeStackResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeStackResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeStackResourceResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeStackResourceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeStackResourceDrifts

        internal virtual DescribeStackResourceDriftsResponse DescribeStackResourceDrifts(DescribeStackResourceDriftsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeStackResourceDriftsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeStackResourceDriftsResponseUnmarshaller.Instance;

            return Invoke<DescribeStackResourceDriftsResponse>(request, options);
        }



        /// <summary>
        /// Returns drift information for the resources that have been checked for drift in the
        /// specified stack. This includes actual and expected configuration values for resources
        /// where CloudFormation detects configuration drift.
        /// 
        ///  
        /// <para>
        /// For a given stack, there will be one <c>StackResourceDrift</c> for each stack resource
        /// that has been checked for drift. Resources that haven't yet been checked for drift
        /// aren't included. Resources that don't currently support drift detection aren't checked,
        /// and so not included. For a list of resources that support drift detection, see <a
        /// href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/resource-import-supported-resources.html">Resource
        /// type support for imports and drift detection</a>.
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeStackResourceDriftsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeStackResourceDriftsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeStackResourceDriftsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeStackResources

        internal virtual DescribeStackResourcesResponse DescribeStackResources(DescribeStackResourcesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeStackResourcesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeStackResourcesResponseUnmarshaller.Instance;

            return Invoke<DescribeStackResourcesResponse>(request, options);
        }



        /// <summary>
        /// Returns Amazon Web Services resource descriptions for running and deleted stacks.
        /// If <c>StackName</c> is specified, all the associated resources that are part of the
        /// stack are returned. If <c>PhysicalResourceId</c> is specified, the associated resources
        /// of the stack that the resource belongs to are returned.
        /// 
        ///  <note> 
        /// <para>
        /// Only the first 100 resources will be returned. If your stack has more resources than
        /// this, you should use <c>ListStackResources</c> instead.
        /// </para>
        ///  </note> 
        /// <para>
        /// For deleted stacks, <c>DescribeStackResources</c> returns resource information for
        /// up to 90 days after the stack has been deleted.
        /// </para>
        ///  
        /// <para>
        /// You must specify either <c>StackName</c> or <c>PhysicalResourceId</c>, but not both.
        /// In addition, you can specify <c>LogicalResourceId</c> to filter the returned result.
        /// For more information about resources, the <c>LogicalResourceId</c> and <c>PhysicalResourceId</c>,
        /// see the <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/">CloudFormation
        /// User Guide</a>.
        /// </para>
        ///  <note> 
        /// <para>
        /// A <c>ValidationError</c> is returned if you specify both <c>StackName</c> and <c>PhysicalResourceId</c>
        /// in the same request.
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeStackResourcesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeStackResourcesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeStackResourcesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeStacks

        internal virtual DescribeStacksResponse DescribeStacks()
        {
            return DescribeStacks(new DescribeStacksRequest());
        }
        internal virtual DescribeStacksResponse DescribeStacks(DescribeStacksRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeStacksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeStacksResponseUnmarshaller.Instance;

            return Invoke<DescribeStacksResponse>(request, options);
        }


        /// <summary>
        /// Returns the description for the specified stack; if no stack name was specified, then
        /// it returns the description for all the stacks created. For more information about
        /// a stack's event history, see <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/stack-resource-configuration-complete.html">Understand
        /// CloudFormation stack creation events</a> in the <i>CloudFormation User Guide</i>.
        /// 
        ///  <note> 
        /// <para>
        /// If the stack doesn't exist, a <c>ValidationError</c> is returned.
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
        /// it returns the description for all the stacks created. For more information about
        /// a stack's event history, see <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/stack-resource-configuration-complete.html">Understand
        /// CloudFormation stack creation events</a> in the <i>CloudFormation User Guide</i>.
        /// 
        ///  <note> 
        /// <para>
        /// If the stack doesn't exist, a <c>ValidationError</c> is returned.
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeStacksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeStacksResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeStacksResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeStackSet

        internal virtual DescribeStackSetResponse DescribeStackSet(DescribeStackSetRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeStackSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeStackSetResponseUnmarshaller.Instance;

            return Invoke<DescribeStackSetResponse>(request, options);
        }



        /// <summary>
        /// Returns the description of the specified StackSet.
        /// 
        ///  <note> 
        /// <para>
        /// This API provides <i>strongly consistent</i> reads meaning it will always return the
        /// most up-to-date data.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeStackSet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeStackSet service method, as returned by CloudFormation.</returns>
        /// <exception cref="Amazon.CloudFormation.Model.StackSetNotFoundException">
        /// The specified StackSet doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/DescribeStackSet">REST API Reference for DescribeStackSet Operation</seealso>
        public virtual Task<DescribeStackSetResponse> DescribeStackSetAsync(DescribeStackSetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeStackSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeStackSetResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeStackSetResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeStackSetOperation

        internal virtual DescribeStackSetOperationResponse DescribeStackSetOperation(DescribeStackSetOperationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeStackSetOperationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeStackSetOperationResponseUnmarshaller.Instance;

            return Invoke<DescribeStackSetOperationResponse>(request, options);
        }



        /// <summary>
        /// Returns the description of the specified StackSet operation.
        /// 
        ///  <note> 
        /// <para>
        /// This API provides <i>strongly consistent</i> reads meaning it will always return the
        /// most up-to-date data.
        /// </para>
        ///  </note>
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
        /// The specified StackSet doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/DescribeStackSetOperation">REST API Reference for DescribeStackSetOperation Operation</seealso>
        public virtual Task<DescribeStackSetOperationResponse> DescribeStackSetOperationAsync(DescribeStackSetOperationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeStackSetOperationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeStackSetOperationResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeStackSetOperationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeType

        internal virtual DescribeTypeResponse DescribeType(DescribeTypeRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeTypeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeTypeResponseUnmarshaller.Instance;

            return Invoke<DescribeTypeResponse>(request, options);
        }



        /// <summary>
        /// Returns detailed information about an extension from the CloudFormation registry in
        /// your current account and Region.
        /// 
        ///  
        /// <para>
        /// If you specify a <c>VersionId</c>, <c>DescribeType</c> returns information about that
        /// specific extension version. Otherwise, it returns information about the default extension
        /// version.
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
        /// The specified extension doesn't exist in the CloudFormation registry.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/DescribeType">REST API Reference for DescribeType Operation</seealso>
        public virtual Task<DescribeTypeResponse> DescribeTypeAsync(DescribeTypeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeTypeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeTypeResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeTypeResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeTypeRegistration

        internal virtual DescribeTypeRegistrationResponse DescribeTypeRegistration(DescribeTypeRegistrationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeTypeRegistrationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeTypeRegistrationResponseUnmarshaller.Instance;

            return Invoke<DescribeTypeRegistrationResponse>(request, options);
        }



        /// <summary>
        /// Returns information about an extension's registration, including its current status
        /// and type and version identifiers.
        /// 
        ///  
        /// <para>
        /// When you initiate a registration request using <a>RegisterType</a>, you can then use
        /// <a>DescribeTypeRegistration</a> to monitor the progress of that registration request.
        /// </para>
        ///  
        /// <para>
        /// Once the registration request has completed, use <a>DescribeType</a> to return detailed
        /// information about an extension.
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeTypeRegistrationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeTypeRegistrationResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeTypeRegistrationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DetectStackDrift

        internal virtual DetectStackDriftResponse DetectStackDrift(DetectStackDriftRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DetectStackDriftRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DetectStackDriftResponseUnmarshaller.Instance;

            return Invoke<DetectStackDriftResponse>(request, options);
        }



        /// <summary>
        /// Detects whether a stack's actual configuration differs, or has <i>drifted</i>, from
        /// its expected configuration, as defined in the stack template and any values specified
        /// as template parameters. For each resource in the stack that supports drift detection,
        /// CloudFormation compares the actual configuration of the resource with its expected
        /// template configuration. Only resource properties explicitly defined in the stack template
        /// are checked for drift. A stack is considered to have drifted if one or more of its
        /// resources differ from their expected template configurations. For more information,
        /// see <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/using-cfn-stack-drift.html">Detect
        /// unmanaged configuration changes to stacks and resources with drift detection</a>.
        /// 
        ///  
        /// <para>
        /// Use <c>DetectStackDrift</c> to detect drift on all supported resources for a given
        /// stack, or <a>DetectStackResourceDrift</a> to detect drift on individual resources.
        /// </para>
        ///  
        /// <para>
        /// For a list of stack resources that currently support drift detection, see <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/resource-import-supported-resources.html">Resource
        /// type support for imports and drift detection</a>.
        /// </para>
        ///  
        /// <para>
        ///  <c>DetectStackDrift</c> can take up to several minutes, depending on the number of
        /// resources contained within the stack. Use <a>DescribeStackDriftDetectionStatus</a>
        /// to monitor the progress of a detect stack drift operation. Once the drift detection
        /// operation has completed, use <a>DescribeStackResourceDrifts</a> to return drift information
        /// about the stack and its resources.
        /// </para>
        ///  
        /// <para>
        /// When detecting drift on a stack, CloudFormation doesn't detect drift on any nested
        /// stacks belonging to that stack. Perform <c>DetectStackDrift</c> directly on the nested
        /// stack itself.
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DetectStackDriftRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DetectStackDriftResponseUnmarshaller.Instance;

            return InvokeAsync<DetectStackDriftResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DetectStackResourceDrift

        internal virtual DetectStackResourceDriftResponse DetectStackResourceDrift(DetectStackResourceDriftRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DetectStackResourceDriftRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DetectStackResourceDriftResponseUnmarshaller.Instance;

            return Invoke<DetectStackResourceDriftResponse>(request, options);
        }



        /// <summary>
        /// Returns information about whether a resource's actual configuration differs, or has
        /// <i>drifted</i>, from its expected configuration, as defined in the stack template
        /// and any values specified as template parameters. This information includes actual
        /// and expected property values for resources in which CloudFormation detects drift.
        /// Only resource properties explicitly defined in the stack template are checked for
        /// drift. For more information about stack and resource drift, see <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/using-cfn-stack-drift.html">Detect
        /// unmanaged configuration changes to stacks and resources with drift detection</a>.
        /// 
        ///  
        /// <para>
        /// Use <c>DetectStackResourceDrift</c> to detect drift on individual resources, or <a>DetectStackDrift</a>
        /// to detect drift on all resources in a given stack that support drift detection.
        /// </para>
        ///  
        /// <para>
        /// Resources that don't currently support drift detection can't be checked. For a list
        /// of resources that support drift detection, see <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/resource-import-supported-resources.html">Resource
        /// type support for imports and drift detection</a>.
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DetectStackResourceDriftRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DetectStackResourceDriftResponseUnmarshaller.Instance;

            return InvokeAsync<DetectStackResourceDriftResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DetectStackSetDrift

        internal virtual DetectStackSetDriftResponse DetectStackSetDrift(DetectStackSetDriftRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DetectStackSetDriftRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DetectStackSetDriftResponseUnmarshaller.Instance;

            return Invoke<DetectStackSetDriftResponse>(request, options);
        }



        /// <summary>
        /// Detect drift on a StackSet. When CloudFormation performs drift detection on a StackSet,
        /// it performs drift detection on the stack associated with each stack instance in the
        /// StackSet. For more information, see <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/stacksets-drift.html">Performing
        /// drift detection on CloudFormation StackSets</a>.
        /// 
        ///  
        /// <para>
        ///  <c>DetectStackSetDrift</c> returns the <c>OperationId</c> of the StackSet drift detection
        /// operation. Use this operation id with <a>DescribeStackSetOperation</a> to monitor
        /// the progress of the drift detection operation. The drift detection operation may take
        /// some time, depending on the number of stack instances included in the StackSet, in
        /// addition to the number of resources included in each stack.
        /// </para>
        ///  
        /// <para>
        /// Once the operation has completed, use the following actions to return drift information:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Use <a>DescribeStackSet</a> to return detailed information about the stack set, including
        /// detailed information about the last <i>completed</i> drift operation performed on
        /// the StackSet. (Information about drift operations that are in progress isn't included.)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <a>ListStackInstances</a> to return a list of stack instances belonging to the
        /// StackSet, including the drift status and last drift time checked of each instance.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <a>DescribeStackInstance</a> to return detailed information about a specific stack
        /// instance, including its drift status and last drift time checked.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// You can only run a single drift detection operation on a given StackSet at one time.
        /// </para>
        ///  
        /// <para>
        /// To stop a drift detection StackSet operation, use <a>StopStackSetOperation</a>.
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
        /// Another operation is currently in progress for this StackSet. Only one operation can
        /// be performed for a stack set at a given time.
        /// </exception>
        /// <exception cref="Amazon.CloudFormation.Model.StackSetNotFoundException">
        /// The specified StackSet doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/DetectStackSetDrift">REST API Reference for DetectStackSetDrift Operation</seealso>
        public virtual Task<DetectStackSetDriftResponse> DetectStackSetDriftAsync(DetectStackSetDriftRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DetectStackSetDriftRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DetectStackSetDriftResponseUnmarshaller.Instance;

            return InvokeAsync<DetectStackSetDriftResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  EstimateTemplateCost

        internal virtual EstimateTemplateCostResponse EstimateTemplateCost(EstimateTemplateCostRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = EstimateTemplateCostRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EstimateTemplateCostResponseUnmarshaller.Instance;

            return Invoke<EstimateTemplateCostResponse>(request, options);
        }



        /// <summary>
        /// Returns the estimated monthly cost of a template. The return value is an Amazon Web
        /// Services Simple Monthly Calculator URL with a query string that describes the resources
        /// required to run the template.
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = EstimateTemplateCostRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EstimateTemplateCostResponseUnmarshaller.Instance;

            return InvokeAsync<EstimateTemplateCostResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ExecuteChangeSet

        internal virtual ExecuteChangeSetResponse ExecuteChangeSet(ExecuteChangeSetRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ExecuteChangeSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ExecuteChangeSetResponseUnmarshaller.Instance;

            return Invoke<ExecuteChangeSetResponse>(request, options);
        }



        /// <summary>
        /// Updates a stack using the input information that was provided when the specified change
        /// set was created. After the call successfully completes, CloudFormation starts updating
        /// the stack. Use the <a>DescribeStacks</a> action to view the status of the update.
        /// 
        ///  
        /// <para>
        /// When you execute a change set, CloudFormation deletes all other change sets associated
        /// with the stack because they aren't valid for the updated stack.
        /// </para>
        ///  
        /// <para>
        /// If a stack policy is associated with the stack, CloudFormation enforces the policy
        /// during the update. You can't specify a temporary stack policy that overrides the current
        /// policy.
        /// </para>
        ///  
        /// <para>
        /// To create a change set for the entire stack hierarchy, <c>IncludeNestedStacks</c>
        /// must have been set to <c>True</c>.
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
        /// stack, use the <c>ListChangeSets</c> operation.
        /// </exception>
        /// <exception cref="Amazon.CloudFormation.Model.InsufficientCapabilitiesException">
        /// The template contains resources with capabilities that weren't specified in the Capabilities
        /// parameter.
        /// </exception>
        /// <exception cref="Amazon.CloudFormation.Model.InvalidChangeSetStatusException">
        /// The specified change set can't be used to update the stack. For example, the change
        /// set status might be <c>CREATE_IN_PROGRESS</c>, or the stack status might be <c>UPDATE_IN_PROGRESS</c>.
        /// </exception>
        /// <exception cref="Amazon.CloudFormation.Model.TokenAlreadyExistsException">
        /// A client request token already exists.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/ExecuteChangeSet">REST API Reference for ExecuteChangeSet Operation</seealso>
        public virtual Task<ExecuteChangeSetResponse> ExecuteChangeSetAsync(ExecuteChangeSetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ExecuteChangeSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ExecuteChangeSetResponseUnmarshaller.Instance;

            return InvokeAsync<ExecuteChangeSetResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ExecuteStackRefactor

        internal virtual ExecuteStackRefactorResponse ExecuteStackRefactor(ExecuteStackRefactorRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ExecuteStackRefactorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ExecuteStackRefactorResponseUnmarshaller.Instance;

            return Invoke<ExecuteStackRefactorResponse>(request, options);
        }



        /// <summary>
        /// Executes the stack refactor operation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ExecuteStackRefactor service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ExecuteStackRefactor service method, as returned by CloudFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/ExecuteStackRefactor">REST API Reference for ExecuteStackRefactor Operation</seealso>
        public virtual Task<ExecuteStackRefactorResponse> ExecuteStackRefactorAsync(ExecuteStackRefactorRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ExecuteStackRefactorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ExecuteStackRefactorResponseUnmarshaller.Instance;

            return InvokeAsync<ExecuteStackRefactorResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetGeneratedTemplate

        internal virtual GetGeneratedTemplateResponse GetGeneratedTemplate(GetGeneratedTemplateRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetGeneratedTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetGeneratedTemplateResponseUnmarshaller.Instance;

            return Invoke<GetGeneratedTemplateResponse>(request, options);
        }



        /// <summary>
        /// Retrieves a generated template. If the template is in an <c>InProgress</c> or <c>Pending</c>
        /// status then the template returned will be the template when the template was last
        /// in a <c>Complete</c> status. If the template has not yet been in a <c>Complete</c>
        /// status then an empty template will be returned.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetGeneratedTemplate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetGeneratedTemplate service method, as returned by CloudFormation.</returns>
        /// <exception cref="Amazon.CloudFormation.Model.GeneratedTemplateNotFoundException">
        /// The generated template was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/GetGeneratedTemplate">REST API Reference for GetGeneratedTemplate Operation</seealso>
        public virtual Task<GetGeneratedTemplateResponse> GetGeneratedTemplateAsync(GetGeneratedTemplateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetGeneratedTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetGeneratedTemplateResponseUnmarshaller.Instance;

            return InvokeAsync<GetGeneratedTemplateResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetStackPolicy

        internal virtual GetStackPolicyResponse GetStackPolicy(GetStackPolicyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetStackPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetStackPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<GetStackPolicyResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetTemplate

        internal virtual GetTemplateResponse GetTemplate(GetTemplateRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
        /// For deleted stacks, <c>GetTemplate</c> returns the template for up to 90 days after
        /// the stack has been deleted.
        /// </para>
        ///  <note> 
        /// <para>
        /// If the template doesn't exist, a <c>ValidationError</c> is returned.
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
        /// stack, use the <c>ListChangeSets</c> operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/GetTemplate">REST API Reference for GetTemplate Operation</seealso>
        public virtual Task<GetTemplateResponse> GetTemplateAsync(GetTemplateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTemplateResponseUnmarshaller.Instance;

            return InvokeAsync<GetTemplateResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetTemplateSummary

        internal virtual GetTemplateSummaryResponse GetTemplateSummary(GetTemplateSummaryRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetTemplateSummaryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTemplateSummaryResponseUnmarshaller.Instance;

            return Invoke<GetTemplateSummaryResponse>(request, options);
        }



        /// <summary>
        /// Returns information about a new or existing template. The <c>GetTemplateSummary</c>
        /// action is useful for viewing parameter information, such as default parameter values
        /// and parameter types, before you create or update a stack or StackSet.
        /// 
        ///  
        /// <para>
        /// You can use the <c>GetTemplateSummary</c> action when you submit a template, or you
        /// can get template information for a StackSet, or a running or deleted stack.
        /// </para>
        ///  
        /// <para>
        /// For deleted stacks, <c>GetTemplateSummary</c> returns the template information for
        /// up to 90 days after the stack has been deleted. If the template doesn't exist, a <c>ValidationError</c>
        /// is returned.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTemplateSummary service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetTemplateSummary service method, as returned by CloudFormation.</returns>
        /// <exception cref="Amazon.CloudFormation.Model.StackSetNotFoundException">
        /// The specified StackSet doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/GetTemplateSummary">REST API Reference for GetTemplateSummary Operation</seealso>
        public virtual Task<GetTemplateSummaryResponse> GetTemplateSummaryAsync(GetTemplateSummaryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetTemplateSummaryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTemplateSummaryResponseUnmarshaller.Instance;

            return InvokeAsync<GetTemplateSummaryResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ImportStacksToStackSet

        internal virtual ImportStacksToStackSetResponse ImportStacksToStackSet(ImportStacksToStackSetRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ImportStacksToStackSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ImportStacksToStackSetResponseUnmarshaller.Instance;

            return Invoke<ImportStacksToStackSetResponse>(request, options);
        }



        /// <summary>
        /// Import existing stacks into a new StackSets. Use the stack import operation to import
        /// up to 10 stacks into a new StackSet in the same account as the source stack or in
        /// a different administrator account and Region, by specifying the stack ID of the stack
        /// you intend to import.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ImportStacksToStackSet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ImportStacksToStackSet service method, as returned by CloudFormation.</returns>
        /// <exception cref="Amazon.CloudFormation.Model.InvalidOperationException">
        /// The specified operation isn't valid.
        /// </exception>
        /// <exception cref="Amazon.CloudFormation.Model.LimitExceededException">
        /// The quota for the resource has already been reached.
        /// 
        ///  
        /// <para>
        /// For information about resource and stack limitations, see <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/cloudformation-limits.html">CloudFormation
        /// quotas</a> in the <i>CloudFormation User Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.CloudFormation.Model.OperationIdAlreadyExistsException">
        /// The specified operation ID already exists.
        /// </exception>
        /// <exception cref="Amazon.CloudFormation.Model.OperationInProgressException">
        /// Another operation is currently in progress for this StackSet. Only one operation can
        /// be performed for a stack set at a given time.
        /// </exception>
        /// <exception cref="Amazon.CloudFormation.Model.StackNotFoundException">
        /// The specified stack ARN doesn't exist or stack doesn't exist corresponding to the
        /// ARN in input.
        /// </exception>
        /// <exception cref="Amazon.CloudFormation.Model.StackSetNotFoundException">
        /// The specified StackSet doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFormation.Model.StaleRequestException">
        /// Another operation has been performed on this StackSet since the specified operation
        /// was performed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/ImportStacksToStackSet">REST API Reference for ImportStacksToStackSet Operation</seealso>
        public virtual Task<ImportStacksToStackSetResponse> ImportStacksToStackSetAsync(ImportStacksToStackSetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ImportStacksToStackSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ImportStacksToStackSetResponseUnmarshaller.Instance;

            return InvokeAsync<ImportStacksToStackSetResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListChangeSets

        internal virtual ListChangeSetsResponse ListChangeSets(ListChangeSetsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListChangeSetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListChangeSetsResponseUnmarshaller.Instance;

            return Invoke<ListChangeSetsResponse>(request, options);
        }



        /// <summary>
        /// Returns the ID and status of each active change set for a stack. For example, CloudFormation
        /// lists change sets that are in the <c>CREATE_IN_PROGRESS</c> or <c>CREATE_PENDING</c>
        /// state.
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListChangeSetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListChangeSetsResponseUnmarshaller.Instance;

            return InvokeAsync<ListChangeSetsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListExports

        internal virtual ListExportsResponse ListExports(ListExportsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListExportsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListExportsResponseUnmarshaller.Instance;

            return Invoke<ListExportsResponse>(request, options);
        }



        /// <summary>
        /// Lists all exported output values in the account and Region in which you call this
        /// action. Use this action to see the exported output values that you can import into
        /// other stacks. To import values, use the <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/TemplateReference/intrinsic-function-reference-importvalue.html">
        /// Fn::ImportValue</a> function.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/using-cfn-stack-exports.html">Get
        /// exported outputs from a deployed CloudFormation stack</a>.
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListExportsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListExportsResponseUnmarshaller.Instance;

            return InvokeAsync<ListExportsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListGeneratedTemplates

        internal virtual ListGeneratedTemplatesResponse ListGeneratedTemplates(ListGeneratedTemplatesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListGeneratedTemplatesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListGeneratedTemplatesResponseUnmarshaller.Instance;

            return Invoke<ListGeneratedTemplatesResponse>(request, options);
        }



        /// <summary>
        /// Lists your generated templates in this Region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListGeneratedTemplates service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListGeneratedTemplates service method, as returned by CloudFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/ListGeneratedTemplates">REST API Reference for ListGeneratedTemplates Operation</seealso>
        public virtual Task<ListGeneratedTemplatesResponse> ListGeneratedTemplatesAsync(ListGeneratedTemplatesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListGeneratedTemplatesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListGeneratedTemplatesResponseUnmarshaller.Instance;

            return InvokeAsync<ListGeneratedTemplatesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListHookResults

        internal virtual ListHookResultsResponse ListHookResults(ListHookResultsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListHookResultsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListHookResultsResponseUnmarshaller.Instance;

            return Invoke<ListHookResultsResponse>(request, options);
        }



        /// <summary>
        /// Returns summaries of invoked Hooks. For more information, see <a href="https://docs.aws.amazon.com/cloudformation-cli/latest/hooks-userguide/hooks-view-invocations.html">View
        /// CloudFormation Hooks invocations</a> in the <i>CloudFormation Hooks User Guide</i>.
        /// 
        ///  
        /// <para>
        /// This operation supports the following parameter combinations:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// No parameters: Returns all Hook invocation summaries.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>TypeArn</c> only: Returns summaries for a specific Hook.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>TypeArn</c> and <c>Status</c>: Returns summaries for a specific Hook filtered
        /// by status.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>TargetId</c> and <c>TargetType</c>: Returns summaries for a specific Hook invocation
        /// target.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListHookResults service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListHookResults service method, as returned by CloudFormation.</returns>
        /// <exception cref="Amazon.CloudFormation.Model.HookResultNotFoundException">
        /// The specified target doesn't have any requested Hook invocations.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/ListHookResults">REST API Reference for ListHookResults Operation</seealso>
        public virtual Task<ListHookResultsResponse> ListHookResultsAsync(ListHookResultsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListHookResultsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListHookResultsResponseUnmarshaller.Instance;

            return InvokeAsync<ListHookResultsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListImports

        internal virtual ListImportsResponse ListImports(ListImportsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
        /// For more information about importing an exported output value, see the <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/TemplateReference/intrinsic-function-reference-importvalue.html">Fn::ImportValue</a>
        /// function.
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListImportsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListImportsResponseUnmarshaller.Instance;

            return InvokeAsync<ListImportsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListResourceScanRelatedResources

        internal virtual ListResourceScanRelatedResourcesResponse ListResourceScanRelatedResources(ListResourceScanRelatedResourcesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListResourceScanRelatedResourcesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListResourceScanRelatedResourcesResponseUnmarshaller.Instance;

            return Invoke<ListResourceScanRelatedResourcesResponse>(request, options);
        }



        /// <summary>
        /// Lists the related resources for a list of resources from a resource scan. The response
        /// indicates whether each returned resource is already managed by CloudFormation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListResourceScanRelatedResources service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListResourceScanRelatedResources service method, as returned by CloudFormation.</returns>
        /// <exception cref="Amazon.CloudFormation.Model.ResourceScanInProgressException">
        /// A resource scan is currently in progress. Only one can be run at a time for an account
        /// in a Region.
        /// </exception>
        /// <exception cref="Amazon.CloudFormation.Model.ResourceScanNotFoundException">
        /// The resource scan was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/ListResourceScanRelatedResources">REST API Reference for ListResourceScanRelatedResources Operation</seealso>
        public virtual Task<ListResourceScanRelatedResourcesResponse> ListResourceScanRelatedResourcesAsync(ListResourceScanRelatedResourcesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListResourceScanRelatedResourcesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListResourceScanRelatedResourcesResponseUnmarshaller.Instance;

            return InvokeAsync<ListResourceScanRelatedResourcesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListResourceScanResources

        internal virtual ListResourceScanResourcesResponse ListResourceScanResources(ListResourceScanResourcesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListResourceScanResourcesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListResourceScanResourcesResponseUnmarshaller.Instance;

            return Invoke<ListResourceScanResourcesResponse>(request, options);
        }



        /// <summary>
        /// Lists the resources from a resource scan. The results can be filtered by resource
        /// identifier, resource type prefix, tag key, and tag value. Only resources that match
        /// all specified filters are returned. The response indicates whether each returned resource
        /// is already managed by CloudFormation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListResourceScanResources service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListResourceScanResources service method, as returned by CloudFormation.</returns>
        /// <exception cref="Amazon.CloudFormation.Model.ResourceScanInProgressException">
        /// A resource scan is currently in progress. Only one can be run at a time for an account
        /// in a Region.
        /// </exception>
        /// <exception cref="Amazon.CloudFormation.Model.ResourceScanNotFoundException">
        /// The resource scan was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/ListResourceScanResources">REST API Reference for ListResourceScanResources Operation</seealso>
        public virtual Task<ListResourceScanResourcesResponse> ListResourceScanResourcesAsync(ListResourceScanResourcesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListResourceScanResourcesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListResourceScanResourcesResponseUnmarshaller.Instance;

            return InvokeAsync<ListResourceScanResourcesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListResourceScans

        internal virtual ListResourceScansResponse ListResourceScans(ListResourceScansRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListResourceScansRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListResourceScansResponseUnmarshaller.Instance;

            return Invoke<ListResourceScansResponse>(request, options);
        }



        /// <summary>
        /// List the resource scans from newest to oldest. By default it will return up to 10
        /// resource scans.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListResourceScans service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListResourceScans service method, as returned by CloudFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/ListResourceScans">REST API Reference for ListResourceScans Operation</seealso>
        public virtual Task<ListResourceScansResponse> ListResourceScansAsync(ListResourceScansRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListResourceScansRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListResourceScansResponseUnmarshaller.Instance;

            return InvokeAsync<ListResourceScansResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListStackInstanceResourceDrifts

        internal virtual ListStackInstanceResourceDriftsResponse ListStackInstanceResourceDrifts(ListStackInstanceResourceDriftsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListStackInstanceResourceDriftsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListStackInstanceResourceDriftsResponseUnmarshaller.Instance;

            return Invoke<ListStackInstanceResourceDriftsResponse>(request, options);
        }



        /// <summary>
        /// Returns drift information for resources in a stack instance.
        /// 
        ///  <note> 
        /// <para>
        ///  <c>ListStackInstanceResourceDrifts</c> returns drift information for the most recent
        /// drift detection operation. If an operation is in progress, it may only return partial
        /// results.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListStackInstanceResourceDrifts service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListStackInstanceResourceDrifts service method, as returned by CloudFormation.</returns>
        /// <exception cref="Amazon.CloudFormation.Model.OperationNotFoundException">
        /// The specified ID refers to an operation that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFormation.Model.StackInstanceNotFoundException">
        /// The specified stack instance doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFormation.Model.StackSetNotFoundException">
        /// The specified StackSet doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/ListStackInstanceResourceDrifts">REST API Reference for ListStackInstanceResourceDrifts Operation</seealso>
        public virtual Task<ListStackInstanceResourceDriftsResponse> ListStackInstanceResourceDriftsAsync(ListStackInstanceResourceDriftsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListStackInstanceResourceDriftsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListStackInstanceResourceDriftsResponseUnmarshaller.Instance;

            return InvokeAsync<ListStackInstanceResourceDriftsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListStackInstances

        internal virtual ListStackInstancesResponse ListStackInstances(ListStackInstancesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListStackInstancesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListStackInstancesResponseUnmarshaller.Instance;

            return Invoke<ListStackInstancesResponse>(request, options);
        }



        /// <summary>
        /// Returns summary information about stack instances that are associated with the specified
        /// StackSet. You can filter for stack instances that are associated with a specific Amazon
        /// Web Services account name or Region, or that have a specific status.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListStackInstances service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListStackInstances service method, as returned by CloudFormation.</returns>
        /// <exception cref="Amazon.CloudFormation.Model.StackSetNotFoundException">
        /// The specified StackSet doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/ListStackInstances">REST API Reference for ListStackInstances Operation</seealso>
        public virtual Task<ListStackInstancesResponse> ListStackInstancesAsync(ListStackInstancesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListStackInstancesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListStackInstancesResponseUnmarshaller.Instance;

            return InvokeAsync<ListStackInstancesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListStackRefactorActions

        internal virtual ListStackRefactorActionsResponse ListStackRefactorActions(ListStackRefactorActionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListStackRefactorActionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListStackRefactorActionsResponseUnmarshaller.Instance;

            return Invoke<ListStackRefactorActionsResponse>(request, options);
        }



        /// <summary>
        /// Lists the stack refactor actions that will be taken after calling the <a>ExecuteStackRefactor</a>
        /// action.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListStackRefactorActions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListStackRefactorActions service method, as returned by CloudFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/ListStackRefactorActions">REST API Reference for ListStackRefactorActions Operation</seealso>
        public virtual Task<ListStackRefactorActionsResponse> ListStackRefactorActionsAsync(ListStackRefactorActionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListStackRefactorActionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListStackRefactorActionsResponseUnmarshaller.Instance;

            return InvokeAsync<ListStackRefactorActionsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListStackRefactors

        internal virtual ListStackRefactorsResponse ListStackRefactors(ListStackRefactorsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListStackRefactorsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListStackRefactorsResponseUnmarshaller.Instance;

            return Invoke<ListStackRefactorsResponse>(request, options);
        }



        /// <summary>
        /// Lists all account stack refactor operations and their statuses.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListStackRefactors service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListStackRefactors service method, as returned by CloudFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/ListStackRefactors">REST API Reference for ListStackRefactors Operation</seealso>
        public virtual Task<ListStackRefactorsResponse> ListStackRefactorsAsync(ListStackRefactorsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListStackRefactorsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListStackRefactorsResponseUnmarshaller.Instance;

            return InvokeAsync<ListStackRefactorsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListStackResources

        internal virtual ListStackResourcesResponse ListStackResources(ListStackResourcesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListStackResourcesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListStackResourcesResponseUnmarshaller.Instance;

            return InvokeAsync<ListStackResourcesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListStacks

        internal virtual ListStacksResponse ListStacks()
        {
            return ListStacks(new ListStacksRequest());
        }
        internal virtual ListStacksResponse ListStacks(ListStacksRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListStacksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListStacksResponseUnmarshaller.Instance;

            return Invoke<ListStacksResponse>(request, options);
        }


        /// <summary>
        /// Returns the summary information for stacks whose status matches the specified <c>StackStatusFilter</c>.
        /// Summary information for stacks that have been deleted is kept for 90 days after the
        /// stack is deleted. If no <c>StackStatusFilter</c> is specified, summary information
        /// for all stacks is returned (including existing stacks and stacks that have been deleted).
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
        /// Returns the summary information for stacks whose status matches the specified <c>StackStatusFilter</c>.
        /// Summary information for stacks that have been deleted is kept for 90 days after the
        /// stack is deleted. If no <c>StackStatusFilter</c> is specified, summary information
        /// for all stacks is returned (including existing stacks and stacks that have been deleted).
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListStacksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListStacksResponseUnmarshaller.Instance;

            return InvokeAsync<ListStacksResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListStackSetAutoDeploymentTargets

        internal virtual ListStackSetAutoDeploymentTargetsResponse ListStackSetAutoDeploymentTargets(ListStackSetAutoDeploymentTargetsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListStackSetAutoDeploymentTargetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListStackSetAutoDeploymentTargetsResponseUnmarshaller.Instance;

            return Invoke<ListStackSetAutoDeploymentTargetsResponse>(request, options);
        }



        /// <summary>
        /// Returns summary information about deployment targets for a StackSet.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListStackSetAutoDeploymentTargets service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListStackSetAutoDeploymentTargets service method, as returned by CloudFormation.</returns>
        /// <exception cref="Amazon.CloudFormation.Model.StackSetNotFoundException">
        /// The specified StackSet doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/ListStackSetAutoDeploymentTargets">REST API Reference for ListStackSetAutoDeploymentTargets Operation</seealso>
        public virtual Task<ListStackSetAutoDeploymentTargetsResponse> ListStackSetAutoDeploymentTargetsAsync(ListStackSetAutoDeploymentTargetsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListStackSetAutoDeploymentTargetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListStackSetAutoDeploymentTargetsResponseUnmarshaller.Instance;

            return InvokeAsync<ListStackSetAutoDeploymentTargetsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListStackSetOperationResults

        internal virtual ListStackSetOperationResultsResponse ListStackSetOperationResults(ListStackSetOperationResultsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListStackSetOperationResultsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListStackSetOperationResultsResponseUnmarshaller.Instance;

            return Invoke<ListStackSetOperationResultsResponse>(request, options);
        }



        /// <summary>
        /// Returns summary information about the results of a StackSet operation.
        /// 
        ///  <note> 
        /// <para>
        /// This API provides <i>eventually consistent</i> reads meaning it may take some time
        /// but will eventually return the most up-to-date data.
        /// </para>
        ///  </note>
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
        /// The specified StackSet doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/ListStackSetOperationResults">REST API Reference for ListStackSetOperationResults Operation</seealso>
        public virtual Task<ListStackSetOperationResultsResponse> ListStackSetOperationResultsAsync(ListStackSetOperationResultsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListStackSetOperationResultsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListStackSetOperationResultsResponseUnmarshaller.Instance;

            return InvokeAsync<ListStackSetOperationResultsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListStackSetOperations

        internal virtual ListStackSetOperationsResponse ListStackSetOperations(ListStackSetOperationsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListStackSetOperationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListStackSetOperationsResponseUnmarshaller.Instance;

            return Invoke<ListStackSetOperationsResponse>(request, options);
        }



        /// <summary>
        /// Returns summary information about operations performed on a StackSet.
        /// 
        ///  <note> 
        /// <para>
        /// This API provides <i>eventually consistent</i> reads meaning it may take some time
        /// but will eventually return the most up-to-date data.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListStackSetOperations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListStackSetOperations service method, as returned by CloudFormation.</returns>
        /// <exception cref="Amazon.CloudFormation.Model.StackSetNotFoundException">
        /// The specified StackSet doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/ListStackSetOperations">REST API Reference for ListStackSetOperations Operation</seealso>
        public virtual Task<ListStackSetOperationsResponse> ListStackSetOperationsAsync(ListStackSetOperationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListStackSetOperationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListStackSetOperationsResponseUnmarshaller.Instance;

            return InvokeAsync<ListStackSetOperationsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListStackSets

        internal virtual ListStackSetsResponse ListStackSets(ListStackSetsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListStackSetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListStackSetsResponseUnmarshaller.Instance;

            return Invoke<ListStackSetsResponse>(request, options);
        }



        /// <summary>
        /// Returns summary information about StackSets that are associated with the user.
        /// 
        ///  <note> 
        /// <para>
        /// This API provides <i>strongly consistent</i> reads meaning it will always return the
        /// most up-to-date data.
        /// </para>
        ///  </note> <ul> <li> 
        /// <para>
        /// [Self-managed permissions] If you set the <c>CallAs</c> parameter to <c>SELF</c> while
        /// signed in to your Amazon Web Services account, <c>ListStackSets</c> returns all self-managed
        /// StackSets in your Amazon Web Services account.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// [Service-managed permissions] If you set the <c>CallAs</c> parameter to <c>SELF</c>
        /// while signed in to the organization's management account, <c>ListStackSets</c> returns
        /// all StackSets in the management account.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// [Service-managed permissions] If you set the <c>CallAs</c> parameter to <c>DELEGATED_ADMIN</c>
        /// while signed in to your member account, <c>ListStackSets</c> returns all StackSets
        /// with service-managed permissions in the management account.
        /// </para>
        ///  </li> </ul>
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListStackSetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListStackSetsResponseUnmarshaller.Instance;

            return InvokeAsync<ListStackSetsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListTypeRegistrations

        internal virtual ListTypeRegistrationsResponse ListTypeRegistrations(ListTypeRegistrationsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTypeRegistrationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTypeRegistrationsResponseUnmarshaller.Instance;

            return Invoke<ListTypeRegistrationsResponse>(request, options);
        }



        /// <summary>
        /// Returns a list of registration tokens for the specified extension(s).
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTypeRegistrationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTypeRegistrationsResponseUnmarshaller.Instance;

            return InvokeAsync<ListTypeRegistrationsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListTypes

        internal virtual ListTypesResponse ListTypes(ListTypesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTypesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTypesResponseUnmarshaller.Instance;

            return Invoke<ListTypesResponse>(request, options);
        }



        /// <summary>
        /// Returns summary information about all extensions, including your private resource
        /// types, modules, and Hooks as well as all public extensions from Amazon Web Services
        /// and third-party publishers.
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTypesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTypesResponseUnmarshaller.Instance;

            return InvokeAsync<ListTypesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListTypeVersions

        internal virtual ListTypeVersionsResponse ListTypeVersions(ListTypeVersionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTypeVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTypeVersionsResponseUnmarshaller.Instance;

            return Invoke<ListTypeVersionsResponse>(request, options);
        }



        /// <summary>
        /// Returns summary information about the versions of an extension.
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTypeVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTypeVersionsResponseUnmarshaller.Instance;

            return InvokeAsync<ListTypeVersionsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  PublishType

        internal virtual PublishTypeResponse PublishType(PublishTypeRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PublishTypeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PublishTypeResponseUnmarshaller.Instance;

            return Invoke<PublishTypeResponse>(request, options);
        }



        /// <summary>
        /// Publishes the specified extension to the CloudFormation registry as a public extension
        /// in this Region. Public extensions are available for use by all CloudFormation users.
        /// For more information about publishing extensions, see <a href="https://docs.aws.amazon.com/cloudformation-cli/latest/userguide/publish-extension.html">Publishing
        /// extensions to make them available for public use</a> in the <i>CloudFormation Command
        /// Line Interface (CLI) User Guide</i>.
        /// 
        ///  
        /// <para>
        /// To publish an extension, you must be registered as a publisher with CloudFormation.
        /// For more information, see <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/APIReference/API_RegisterPublisher.html">RegisterPublisher</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PublishType service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PublishType service method, as returned by CloudFormation.</returns>
        /// <exception cref="Amazon.CloudFormation.Model.CFNRegistryException">
        /// An error occurred during a CloudFormation registry operation.
        /// </exception>
        /// <exception cref="Amazon.CloudFormation.Model.TypeNotFoundException">
        /// The specified extension doesn't exist in the CloudFormation registry.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/PublishType">REST API Reference for PublishType Operation</seealso>
        public virtual Task<PublishTypeResponse> PublishTypeAsync(PublishTypeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PublishTypeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PublishTypeResponseUnmarshaller.Instance;

            return InvokeAsync<PublishTypeResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  RecordHandlerProgress

        internal virtual RecordHandlerProgressResponse RecordHandlerProgress(RecordHandlerProgressRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
        /// CLI</a>. Don't use this API in your code.
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
        /// CLI</a>. CloudFormation doesn't return this error to users.
        /// </exception>
        /// <exception cref="Amazon.CloudFormation.Model.OperationStatusCheckFailedException">
        /// Error reserved for use by the <a href="https://docs.aws.amazon.com/cloudformation-cli/latest/userguide/what-is-cloudformation-cli.html">CloudFormation
        /// CLI</a>. CloudFormation doesn't return this error to users.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/RecordHandlerProgress">REST API Reference for RecordHandlerProgress Operation</seealso>
        public virtual Task<RecordHandlerProgressResponse> RecordHandlerProgressAsync(RecordHandlerProgressRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RecordHandlerProgressRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RecordHandlerProgressResponseUnmarshaller.Instance;

            return InvokeAsync<RecordHandlerProgressResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  RegisterPublisher

        internal virtual RegisterPublisherResponse RegisterPublisher(RegisterPublisherRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RegisterPublisherRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RegisterPublisherResponseUnmarshaller.Instance;

            return Invoke<RegisterPublisherResponse>(request, options);
        }



        /// <summary>
        /// Registers your account as a publisher of public extensions in the CloudFormation registry.
        /// Public extensions are available for use by all CloudFormation users. This publisher
        /// ID applies to your account in all Amazon Web Services Regions.
        /// 
        ///  
        /// <para>
        /// For information about requirements for registering as a public extension publisher,
        /// see <a href="https://docs.aws.amazon.com/cloudformation-cli/latest/userguide/publish-extension.html#publish-extension-prereqs">Prerequisite:
        /// Registering your account to publish CloudFormation extensions</a> in the <i>CloudFormation
        /// Command Line Interface (CLI) User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RegisterPublisher service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RegisterPublisher service method, as returned by CloudFormation.</returns>
        /// <exception cref="Amazon.CloudFormation.Model.CFNRegistryException">
        /// An error occurred during a CloudFormation registry operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/RegisterPublisher">REST API Reference for RegisterPublisher Operation</seealso>
        public virtual Task<RegisterPublisherResponse> RegisterPublisherAsync(RegisterPublisherRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RegisterPublisherRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RegisterPublisherResponseUnmarshaller.Instance;

            return InvokeAsync<RegisterPublisherResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  RegisterType

        internal virtual RegisterTypeResponse RegisterType(RegisterTypeRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RegisterTypeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RegisterTypeResponseUnmarshaller.Instance;

            return Invoke<RegisterTypeResponse>(request, options);
        }



        /// <summary>
        /// Registers an extension with the CloudFormation service. Registering an extension makes
        /// it available for use in CloudFormation templates in your Amazon Web Services account,
        /// and includes:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Validating the extension schema.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Determining which handlers, if any, have been specified for the extension.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Making the extension available for use in your account.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information about how to develop extensions and ready them for registration,
        /// see <a href="https://docs.aws.amazon.com/cloudformation-cli/latest/userguide/resource-types.html">Creating
        /// resource types using the CloudFormation CLI</a> in the <i>CloudFormation Command Line
        /// Interface (CLI) User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// You can have a maximum of 50 resource extension versions registered at a time. This
        /// maximum is per account and per Region. Use <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/APIReference/API_DeregisterType.html">DeregisterType</a>
        /// to deregister specific extension versions if necessary.
        /// </para>
        ///  
        /// <para>
        /// Once you have initiated a registration request using <a>RegisterType</a>, you can
        /// use <a>DescribeTypeRegistration</a> to monitor the progress of the registration request.
        /// </para>
        ///  
        /// <para>
        /// Once you have registered a private extension in your account and Region, use <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/APIReference/API_SetTypeConfiguration.html">SetTypeConfiguration</a>
        /// to specify configuration properties for the extension. For more information, see <a
        /// href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/registry-set-configuration.html">Edit
        /// configuration data for extensions in your account</a> in the <i>CloudFormation User
        /// Guide</i>.
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RegisterTypeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RegisterTypeResponseUnmarshaller.Instance;

            return InvokeAsync<RegisterTypeResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  RollbackStack

        internal virtual RollbackStackResponse RollbackStack(RollbackStackRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RollbackStackRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RollbackStackResponseUnmarshaller.Instance;

            return Invoke<RollbackStackResponse>(request, options);
        }



        /// <summary>
        /// When specifying <c>RollbackStack</c>, you preserve the state of previously provisioned
        /// resources when an operation fails. You can check the status of the stack through the
        /// <a>DescribeStacks</a> operation.
        /// 
        ///  
        /// <para>
        /// Rolls back the specified stack to the last known stable state from <c>CREATE_FAILED</c>
        /// or <c>UPDATE_FAILED</c> stack statuses.
        /// </para>
        ///  
        /// <para>
        /// This operation will delete a stack if it doesn't contain a last known stable state.
        /// A last known stable state includes any status in a <c>*_COMPLETE</c>. This includes
        /// the following stack statuses.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>CREATE_COMPLETE</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>UPDATE_COMPLETE</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>UPDATE_ROLLBACK_COMPLETE</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>IMPORT_COMPLETE</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>IMPORT_ROLLBACK_COMPLETE</c> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RollbackStack service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RollbackStack service method, as returned by CloudFormation.</returns>
        /// <exception cref="Amazon.CloudFormation.Model.TokenAlreadyExistsException">
        /// A client request token already exists.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/RollbackStack">REST API Reference for RollbackStack Operation</seealso>
        public virtual Task<RollbackStackResponse> RollbackStackAsync(RollbackStackRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RollbackStackRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RollbackStackResponseUnmarshaller.Instance;

            return InvokeAsync<RollbackStackResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  SetStackPolicy

        internal virtual SetStackPolicyResponse SetStackPolicy(SetStackPolicyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SetStackPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SetStackPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<SetStackPolicyResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  SetTypeConfiguration

        internal virtual SetTypeConfigurationResponse SetTypeConfiguration(SetTypeConfigurationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SetTypeConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SetTypeConfigurationResponseUnmarshaller.Instance;

            return Invoke<SetTypeConfigurationResponse>(request, options);
        }



        /// <summary>
        /// Specifies the configuration data for a registered CloudFormation extension, in the
        /// given account and Region.
        /// 
        ///  
        /// <para>
        /// To view the current configuration data for an extension, refer to the <c>ConfigurationSchema</c>
        /// element of <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/APIReference/API_DescribeType.html">DescribeType</a>.
        /// For more information, see <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/registry-set-configuration.html">Edit
        /// configuration data for extensions in your account</a> in the <i>CloudFormation User
        /// Guide</i>.
        /// </para>
        ///  <important> 
        /// <para>
        /// It's strongly recommended that you use dynamic references to restrict sensitive configuration
        /// definitions, such as third-party credentials. For more details on dynamic references,
        /// see <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/dynamic-references.html">Specify
        /// values stored in other services using dynamic references</a> in the <i>CloudFormation
        /// User Guide</i>.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SetTypeConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SetTypeConfiguration service method, as returned by CloudFormation.</returns>
        /// <exception cref="Amazon.CloudFormation.Model.CFNRegistryException">
        /// An error occurred during a CloudFormation registry operation.
        /// </exception>
        /// <exception cref="Amazon.CloudFormation.Model.TypeNotFoundException">
        /// The specified extension doesn't exist in the CloudFormation registry.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/SetTypeConfiguration">REST API Reference for SetTypeConfiguration Operation</seealso>
        public virtual Task<SetTypeConfigurationResponse> SetTypeConfigurationAsync(SetTypeConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SetTypeConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SetTypeConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<SetTypeConfigurationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  SetTypeDefaultVersion

        internal virtual SetTypeDefaultVersionResponse SetTypeDefaultVersion(SetTypeDefaultVersionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SetTypeDefaultVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SetTypeDefaultVersionResponseUnmarshaller.Instance;

            return Invoke<SetTypeDefaultVersionResponse>(request, options);
        }



        /// <summary>
        /// Specify the default version of an extension. The default version of an extension will
        /// be used in CloudFormation operations.
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
        /// The specified extension doesn't exist in the CloudFormation registry.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/SetTypeDefaultVersion">REST API Reference for SetTypeDefaultVersion Operation</seealso>
        public virtual Task<SetTypeDefaultVersionResponse> SetTypeDefaultVersionAsync(SetTypeDefaultVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SetTypeDefaultVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SetTypeDefaultVersionResponseUnmarshaller.Instance;

            return InvokeAsync<SetTypeDefaultVersionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  SignalResource

        internal virtual SignalResourceResponse SignalResource(SignalResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SignalResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SignalResourceResponseUnmarshaller.Instance;

            return Invoke<SignalResourceResponse>(request, options);
        }



        /// <summary>
        /// Sends a signal to the specified resource with a success or failure status. You can
        /// use the <c>SignalResource</c> operation in conjunction with a creation policy or update
        /// policy. CloudFormation doesn't proceed with a stack creation or update until resources
        /// receive the required number of signals or the timeout period is exceeded. The <c>SignalResource</c>
        /// operation is useful in cases where you want to send signals from anywhere other than
        /// an Amazon EC2 instance.
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SignalResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SignalResourceResponseUnmarshaller.Instance;

            return InvokeAsync<SignalResourceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  StartResourceScan

        internal virtual StartResourceScanResponse StartResourceScan(StartResourceScanRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartResourceScanRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartResourceScanResponseUnmarshaller.Instance;

            return Invoke<StartResourceScanResponse>(request, options);
        }



        /// <summary>
        /// Starts a scan of the resources in this account in this Region. You can the status
        /// of a scan using the <c>ListResourceScans</c> API action.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartResourceScan service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartResourceScan service method, as returned by CloudFormation.</returns>
        /// <exception cref="Amazon.CloudFormation.Model.ResourceScanInProgressException">
        /// A resource scan is currently in progress. Only one can be run at a time for an account
        /// in a Region.
        /// </exception>
        /// <exception cref="Amazon.CloudFormation.Model.ResourceScanLimitExceededException">
        /// The limit on resource scans has been exceeded. Reasons include:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Exceeded the daily quota for resource scans.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A resource scan recently failed. You must wait 10 minutes before starting a new resource
        /// scan.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The last resource scan failed after exceeding 100,000 resources. When this happens,
        /// you must wait 24 hours before starting a new resource scan.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/StartResourceScan">REST API Reference for StartResourceScan Operation</seealso>
        public virtual Task<StartResourceScanResponse> StartResourceScanAsync(StartResourceScanRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartResourceScanRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartResourceScanResponseUnmarshaller.Instance;

            return InvokeAsync<StartResourceScanResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  StopStackSetOperation

        internal virtual StopStackSetOperationResponse StopStackSetOperation(StopStackSetOperationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StopStackSetOperationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopStackSetOperationResponseUnmarshaller.Instance;

            return Invoke<StopStackSetOperationResponse>(request, options);
        }



        /// <summary>
        /// Stops an in-progress operation on a StackSet and its associated stack instances. StackSets
        /// will cancel all the unstarted stack instance deployments and wait for those are in-progress
        /// to complete.
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
        /// The specified StackSet doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/StopStackSetOperation">REST API Reference for StopStackSetOperation Operation</seealso>
        public virtual Task<StopStackSetOperationResponse> StopStackSetOperationAsync(StopStackSetOperationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StopStackSetOperationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopStackSetOperationResponseUnmarshaller.Instance;

            return InvokeAsync<StopStackSetOperationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  TestType

        internal virtual TestTypeResponse TestType(TestTypeRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TestTypeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TestTypeResponseUnmarshaller.Instance;

            return Invoke<TestTypeResponse>(request, options);
        }



        /// <summary>
        /// Tests a registered extension to make sure it meets all necessary requirements for
        /// being published in the CloudFormation registry.
        /// 
        ///  <ul> <li> 
        /// <para>
        /// For resource types, this includes passing all contracts tests defined for the type.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For modules, this includes determining if the module's model meets all necessary requirements.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/cloudformation-cli/latest/userguide/publish-extension.html#publish-extension-testing">Testing
        /// your public extension before publishing</a> in the <i>CloudFormation Command Line
        /// Interface (CLI) User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// If you don't specify a version, CloudFormation uses the default version of the extension
        /// in your account and Region for testing.
        /// </para>
        ///  
        /// <para>
        /// To perform testing, CloudFormation assumes the execution role specified when the type
        /// was registered. For more information, see <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/APIReference/API_RegisterType.html">RegisterType</a>.
        /// </para>
        ///  
        /// <para>
        /// Once you've initiated testing on an extension using <c>TestType</c>, you can pass
        /// the returned <c>TypeVersionArn</c> into <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/APIReference/API_DescribeType.html">DescribeType</a>
        /// to monitor the current test status and test status description for the extension.
        /// </para>
        ///  
        /// <para>
        /// An extension must have a test status of <c>PASSED</c> before it can be published.
        /// For more information, see <a href="https://docs.aws.amazon.com/cloudformation-cli/latest/userguide/resource-type-publish.html">Publishing
        /// extensions to make them available for public use</a> in the <i>CloudFormation Command
        /// Line Interface (CLI) User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TestType service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TestType service method, as returned by CloudFormation.</returns>
        /// <exception cref="Amazon.CloudFormation.Model.CFNRegistryException">
        /// An error occurred during a CloudFormation registry operation.
        /// </exception>
        /// <exception cref="Amazon.CloudFormation.Model.TypeNotFoundException">
        /// The specified extension doesn't exist in the CloudFormation registry.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/TestType">REST API Reference for TestType Operation</seealso>
        public virtual Task<TestTypeResponse> TestTypeAsync(TestTypeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TestTypeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TestTypeResponseUnmarshaller.Instance;

            return InvokeAsync<TestTypeResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateGeneratedTemplate

        internal virtual UpdateGeneratedTemplateResponse UpdateGeneratedTemplate(UpdateGeneratedTemplateRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateGeneratedTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateGeneratedTemplateResponseUnmarshaller.Instance;

            return Invoke<UpdateGeneratedTemplateResponse>(request, options);
        }



        /// <summary>
        /// Updates a generated template. This can be used to change the name, add and remove
        /// resources, refresh resources, and change the <c>DeletionPolicy</c> and <c>UpdateReplacePolicy</c>
        /// settings. You can check the status of the update to the generated template using the
        /// <c>DescribeGeneratedTemplate</c> API action.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateGeneratedTemplate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateGeneratedTemplate service method, as returned by CloudFormation.</returns>
        /// <exception cref="Amazon.CloudFormation.Model.AlreadyExistsException">
        /// The resource with the name requested already exists.
        /// </exception>
        /// <exception cref="Amazon.CloudFormation.Model.GeneratedTemplateNotFoundException">
        /// The generated template was not found.
        /// </exception>
        /// <exception cref="Amazon.CloudFormation.Model.LimitExceededException">
        /// The quota for the resource has already been reached.
        /// 
        ///  
        /// <para>
        /// For information about resource and stack limitations, see <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/cloudformation-limits.html">CloudFormation
        /// quotas</a> in the <i>CloudFormation User Guide</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/UpdateGeneratedTemplate">REST API Reference for UpdateGeneratedTemplate Operation</seealso>
        public virtual Task<UpdateGeneratedTemplateResponse> UpdateGeneratedTemplateAsync(UpdateGeneratedTemplateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateGeneratedTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateGeneratedTemplateResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateGeneratedTemplateResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateStack

        internal virtual UpdateStackResponse UpdateStack(UpdateStackRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateStackRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateStackResponseUnmarshaller.Instance;

            return Invoke<UpdateStackResponse>(request, options);
        }



        /// <summary>
        /// Updates a stack as specified in the template. After the call completes successfully,
        /// the stack update starts. You can check the status of the stack through the <a>DescribeStacks</a>
        /// action.
        /// 
        ///  
        /// <para>
        /// To get a copy of the template for an existing stack, you can use the <a>GetTemplate</a>
        /// action.
        /// </para>
        ///  
        /// <para>
        /// For more information about updating a stack and monitoring the progress of the update,
        /// see <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/stacks.html">Managing
        /// Amazon Web Services resources as a single unit with CloudFormation stacks</a> in the
        /// <i>CloudFormation User Guide</i>.
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateStackRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateStackResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateStackResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateStackInstances

        internal virtual UpdateStackInstancesResponse UpdateStackInstances(UpdateStackInstancesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateStackInstancesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateStackInstancesResponseUnmarshaller.Instance;

            return Invoke<UpdateStackInstancesResponse>(request, options);
        }



        /// <summary>
        /// Updates the parameter values for stack instances for the specified accounts, within
        /// the specified Amazon Web Services Regions. A stack instance refers to a stack in a
        /// specific account and Region.
        /// 
        ///  
        /// <para>
        /// You can only update stack instances in Amazon Web Services Regions and accounts where
        /// they already exist; to create additional stack instances, use <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/APIReference/API_CreateStackInstances.html">CreateStackInstances</a>.
        /// </para>
        ///  
        /// <para>
        /// During StackSet updates, any parameters overridden for a stack instance aren't updated,
        /// but retain their overridden value.
        /// </para>
        ///  
        /// <para>
        /// You can only update the parameter <i>values</i> that are specified in the StackSet.
        /// To add or delete a parameter itself, use <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/APIReference/API_UpdateStackSet.html">UpdateStackSet</a>
        /// to update the StackSet template. If you add a parameter to a template, before you
        /// can override the parameter value specified in the StackSet you must first use <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/APIReference/API_UpdateStackSet.html">UpdateStackSet</a>
        /// to update all stack instances with the updated template and parameter value specified
        /// in the StackSet. Once a stack instance has been updated with the new parameter, you
        /// can then override the parameter value using <c>UpdateStackInstances</c>.
        /// </para>
        ///  <note> 
        /// <para>
        /// The maximum number of organizational unit (OUs) supported by a <c>UpdateStackInstances</c>
        /// operation is 50.
        /// </para>
        ///  
        /// <para>
        /// If you need more than 50, consider the following options:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <i>Batch processing:</i> If you don't want to expose your OU hierarchy, split up
        /// the operations into multiple calls with less than 50 OUs each.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>Parent OU strategy:</i> If you don't mind exposing the OU hierarchy, target a
        /// parent OU that contains all desired child OUs.
        /// </para>
        ///  </li> </ul> </note>
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
        /// Another operation is currently in progress for this StackSet. Only one operation can
        /// be performed for a stack set at a given time.
        /// </exception>
        /// <exception cref="Amazon.CloudFormation.Model.StackInstanceNotFoundException">
        /// The specified stack instance doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFormation.Model.StackSetNotFoundException">
        /// The specified StackSet doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFormation.Model.StaleRequestException">
        /// Another operation has been performed on this StackSet since the specified operation
        /// was performed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/UpdateStackInstances">REST API Reference for UpdateStackInstances Operation</seealso>
        public virtual Task<UpdateStackInstancesResponse> UpdateStackInstancesAsync(UpdateStackInstancesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateStackInstancesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateStackInstancesResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateStackInstancesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateStackSet

        internal virtual UpdateStackSetResponse UpdateStackSet(UpdateStackSetRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateStackSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateStackSetResponseUnmarshaller.Instance;

            return Invoke<UpdateStackSetResponse>(request, options);
        }



        /// <summary>
        /// Updates the StackSet and associated stack instances in the specified accounts and
        /// Amazon Web Services Regions.
        /// 
        ///  
        /// <para>
        /// Even if the StackSet operation created by updating the StackSet fails (completely
        /// or partially, below or above a specified failure tolerance), the StackSet is updated
        /// with your changes. Subsequent <a>CreateStackInstances</a> calls on the specified StackSet
        /// use the updated StackSet.
        /// </para>
        ///  <note> 
        /// <para>
        /// The maximum number of organizational unit (OUs) supported by a <c>UpdateStackSet</c>
        /// operation is 50.
        /// </para>
        ///  
        /// <para>
        /// If you need more than 50, consider the following options:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <i>Batch processing:</i> If you don't want to expose your OU hierarchy, split up
        /// the operations into multiple calls with less than 50 OUs each.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>Parent OU strategy:</i> If you don't mind exposing the OU hierarchy, target a
        /// parent OU that contains all desired child OUs.
        /// </para>
        ///  </li> </ul> </note>
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
        /// Another operation is currently in progress for this StackSet. Only one operation can
        /// be performed for a stack set at a given time.
        /// </exception>
        /// <exception cref="Amazon.CloudFormation.Model.StackInstanceNotFoundException">
        /// The specified stack instance doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFormation.Model.StackSetNotFoundException">
        /// The specified StackSet doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFormation.Model.StaleRequestException">
        /// Another operation has been performed on this StackSet since the specified operation
        /// was performed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/UpdateStackSet">REST API Reference for UpdateStackSet Operation</seealso>
        public virtual Task<UpdateStackSetResponse> UpdateStackSetAsync(UpdateStackSetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateStackSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateStackSetResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateStackSetResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateTerminationProtection

        internal virtual UpdateTerminationProtectionResponse UpdateTerminationProtection(UpdateTerminationProtectionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateTerminationProtectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateTerminationProtectionResponseUnmarshaller.Instance;

            return Invoke<UpdateTerminationProtectionResponse>(request, options);
        }



        /// <summary>
        /// Updates termination protection for the specified stack. If a user attempts to delete
        /// a stack with termination protection enabled, the operation fails and the stack remains
        /// unchanged. For more information, see <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/using-cfn-protect-stacks.html">Protect
        /// a CloudFormation stack from being deleted</a> in the <i>CloudFormation User Guide</i>.
        /// 
        ///  
        /// <para>
        /// For <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/using-cfn-nested-stacks.html">nested
        /// stacks</a>, termination protection is set on the root stack and can't be changed directly
        /// on the nested stack.
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateTerminationProtectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateTerminationProtectionResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateTerminationProtectionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ValidateTemplate

        internal virtual ValidateTemplateResponse ValidateTemplate()
        {
            return ValidateTemplate(new ValidateTemplateRequest());
        }
        internal virtual ValidateTemplateResponse ValidateTemplate(ValidateTemplateRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ValidateTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ValidateTemplateResponseUnmarshaller.Instance;

            return Invoke<ValidateTemplateResponse>(request, options);
        }


        /// <summary>
        /// Validates a specified template. CloudFormation first checks if the template is valid
        /// JSON. If it isn't, CloudFormation checks if the template is valid YAML. If both these
        /// checks fail, CloudFormation returns a template validation error.
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
        /// Validates a specified template. CloudFormation first checks if the template is valid
        /// JSON. If it isn't, CloudFormation checks if the template is valid YAML. If both these
        /// checks fail, CloudFormation returns a template validation error.
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ValidateTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ValidateTemplateResponseUnmarshaller.Instance;

            return InvokeAsync<ValidateTemplateResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region DetermineServiceOperationEndpoint

        /// <summary>
        /// Returns the endpoint that will be used for a particular request.
        /// </summary>
        /// <param name="request">Request for the desired service operation.</param>
        /// <returns>The resolved endpoint for the given request.</returns>
        public Amazon.Runtime.Endpoints.Endpoint DetermineServiceOperationEndpoint(AmazonWebServiceRequest request)
        {
            var parameters = new ServiceOperationEndpointParameters(request);
            return Config.DetermineServiceOperationEndpoint(parameters);
        }

        #endregion

    }
}