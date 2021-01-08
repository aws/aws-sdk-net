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
 * Do not modify this file. This file is generated from the ssm-2014-11-06.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.SimpleSystemsManagement.Model;
using Amazon.SimpleSystemsManagement.Model.Internal.MarshallTransformations;
using Amazon.SimpleSystemsManagement.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.SimpleSystemsManagement
{
    /// <summary>
    /// Implementation for accessing SimpleSystemsManagement
    ///
    /// AWS Systems Manager 
    /// <para>
    /// AWS Systems Manager is a collection of capabilities that helps you automate management
    /// tasks such as collecting system inventory, applying operating system (OS) patches,
    /// automating the creation of Amazon Machine Images (AMIs), and configuring operating
    /// systems (OSs) and applications at scale. Systems Manager lets you remotely and securely
    /// manage the configuration of your managed instances. A <i>managed instance</i> is any
    /// Amazon Elastic Compute Cloud instance (EC2 instance), or any on-premises server or
    /// virtual machine (VM) in your hybrid environment that has been configured for Systems
    /// Manager.
    /// </para>
    ///  
    /// <para>
    /// This reference is intended to be used with the <a href="https://docs.aws.amazon.com/systems-manager/latest/userguide/">AWS
    /// Systems Manager User Guide</a>.
    /// </para>
    ///  
    /// <para>
    /// To get started, verify prerequisites and configure managed instances. For more information,
    /// see <a href="https://docs.aws.amazon.com/systems-manager/latest/userguide/systems-manager-setting-up.html">Setting
    /// up AWS Systems Manager</a> in the <i>AWS Systems Manager User Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// For information about other API actions you can perform on EC2 instances, see the
    /// <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/">Amazon EC2 API Reference</a>.
    /// For information about how to use a Query API, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/making-api-requests.html">Making
    /// API requests</a>. 
    /// </para>
    /// </summary>
#if NETSTANDARD13
    [Obsolete("Support for .NET Standard 1.3 is in maintenance mode and will only receive critical bug fixes and security patches. Visit https://docs.aws.amazon.com/sdk-for-net/v3/developer-guide/migration-from-net-standard-1-3.html for further details.")]
#endif
    public partial class AmazonSimpleSystemsManagementClient : AmazonServiceClient, IAmazonSimpleSystemsManagement
    {
        private static IServiceMetadata serviceMetadata = new AmazonSimpleSystemsManagementMetadata();
        
        #region Constructors

        /// <summary>
        /// Constructs AmazonSimpleSystemsManagementClient with the credentials loaded from the application's
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
        public AmazonSimpleSystemsManagementClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonSimpleSystemsManagementConfig()) { }

        /// <summary>
        /// Constructs AmazonSimpleSystemsManagementClient with the credentials loaded from the application's
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
        public AmazonSimpleSystemsManagementClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonSimpleSystemsManagementConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonSimpleSystemsManagementClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonSimpleSystemsManagementClient Configuration Object</param>
        public AmazonSimpleSystemsManagementClient(AmazonSimpleSystemsManagementConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }


        /// <summary>
        /// Constructs AmazonSimpleSystemsManagementClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonSimpleSystemsManagementClient(AWSCredentials credentials)
            : this(credentials, new AmazonSimpleSystemsManagementConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonSimpleSystemsManagementClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonSimpleSystemsManagementClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonSimpleSystemsManagementConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonSimpleSystemsManagementClient with AWS Credentials and an
        /// AmazonSimpleSystemsManagementClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonSimpleSystemsManagementClient Configuration Object</param>
        public AmazonSimpleSystemsManagementClient(AWSCredentials credentials, AmazonSimpleSystemsManagementConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonSimpleSystemsManagementClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonSimpleSystemsManagementClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonSimpleSystemsManagementConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonSimpleSystemsManagementClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonSimpleSystemsManagementClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonSimpleSystemsManagementConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonSimpleSystemsManagementClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonSimpleSystemsManagementClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonSimpleSystemsManagementClient Configuration Object</param>
        public AmazonSimpleSystemsManagementClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonSimpleSystemsManagementConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonSimpleSystemsManagementClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonSimpleSystemsManagementClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonSimpleSystemsManagementConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonSimpleSystemsManagementClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonSimpleSystemsManagementClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonSimpleSystemsManagementConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonSimpleSystemsManagementClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonSimpleSystemsManagementClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonSimpleSystemsManagementClient Configuration Object</param>
        public AmazonSimpleSystemsManagementClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonSimpleSystemsManagementConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion
#if AWS_ASYNC_ENUMERABLES_API
        private ISimpleSystemsManagementPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public ISimpleSystemsManagementPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new SimpleSystemsManagementPaginatorFactory(this);
                }
                return this._paginators;
            }
        }
#endif

        #region Overrides

        /// <summary>
        /// Creates the signer for the service.
        /// </summary>
        protected override AbstractAWSSigner CreateSigner()
        {
            return new AWS4Signer();
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


        #region  AddTagsToResource

        internal virtual AddTagsToResourceResponse AddTagsToResource(AddTagsToResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AddTagsToResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddTagsToResourceResponseUnmarshaller.Instance;

            return Invoke<AddTagsToResourceResponse>(request, options);
        }



        /// <summary>
        /// Adds or overwrites one or more tags for the specified resource. Tags are metadata
        /// that you can assign to your documents, managed instances, maintenance windows, Parameter
        /// Store parameters, and patch baselines. Tags enable you to categorize your resources
        /// in different ways, for example, by purpose, owner, or environment. Each tag consists
        /// of a key and an optional value, both of which you define. For example, you could define
        /// a set of tags for your account's managed instances that helps you track each instance's
        /// owner and stack level. For example: Key=Owner and Value=DbAdmin, SysAdmin, or Dev.
        /// Or Key=Stack and Value=Production, Pre-Production, or Test.
        /// 
        ///  
        /// <para>
        /// Each resource can have a maximum of 50 tags. 
        /// </para>
        ///  
        /// <para>
        /// We recommend that you devise a set of tag keys that meets your needs for each resource
        /// type. Using a consistent set of tag keys makes it easier for you to manage your resources.
        /// You can search and filter the resources based on the tags you add. Tags don't have
        /// any semantic meaning to and are interpreted strictly as a string of characters. 
        /// </para>
        ///  
        /// <para>
        /// For more information about using tags with EC2 instances, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/Using_Tags.html">Tagging
        /// your Amazon EC2 resources</a> in the <i>Amazon EC2 User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddTagsToResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AddTagsToResource service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidResourceIdException">
        /// The resource ID is not valid. Verify that you entered the correct ID and try again.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidResourceTypeException">
        /// The resource type is not valid. For example, if you are attempting to tag an instance,
        /// the instance must be a registered, managed instance.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.TooManyTagsErrorException">
        /// The <code>Targets</code> parameter includes too many tags. Remove one or more tags
        /// and try the command again.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.TooManyUpdatesException">
        /// There are concurrent updates for a resource that supports one update at a time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/AddTagsToResource">REST API Reference for AddTagsToResource Operation</seealso>
        public virtual Task<AddTagsToResourceResponse> AddTagsToResourceAsync(AddTagsToResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AddTagsToResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddTagsToResourceResponseUnmarshaller.Instance;

            return InvokeAsync<AddTagsToResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CancelCommand

        internal virtual CancelCommandResponse CancelCommand(CancelCommandRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CancelCommandRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelCommandResponseUnmarshaller.Instance;

            return Invoke<CancelCommandResponse>(request, options);
        }


        /// <summary>
        /// Attempts to cancel the command specified by the Command ID. There is no guarantee
        /// that the command will be terminated and the underlying process stopped.
        /// </summary>
        /// <param name="commandId">The ID of the command you want to cancel.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CancelCommand service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.DuplicateInstanceIdException">
        /// You cannot specify an instance ID in more than one association.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidCommandIdException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidInstanceIdException">
        /// The following problems can cause this exception:
        /// 
        ///  
        /// <para>
        /// You do not have permission to access the instance.
        /// </para>
        ///  
        /// <para>
        /// SSM Agent is not running. Verify that SSM Agent is running.
        /// </para>
        ///  
        /// <para>
        /// SSM Agent is not registered with the SSM endpoint. Try reinstalling SSM Agent.
        /// </para>
        ///  
        /// <para>
        /// The instance is not in valid state. Valid states are: Running, Pending, Stopped, Stopping.
        /// Invalid states are: Shutting-down and Terminated.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/CancelCommand">REST API Reference for CancelCommand Operation</seealso>
        public virtual Task<CancelCommandResponse> CancelCommandAsync(string commandId, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new CancelCommandRequest();
            request.CommandId = commandId;
            return CancelCommandAsync(request, cancellationToken);
        }


        /// <summary>
        /// Attempts to cancel the command specified by the Command ID. There is no guarantee
        /// that the command will be terminated and the underlying process stopped.
        /// </summary>
        /// <param name="commandId">The ID of the command you want to cancel.</param>
        /// <param name="instanceIds">(Optional) A list of instance IDs on which you want to cancel the command. If not provided, the command is canceled on every instance on which it was requested.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CancelCommand service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.DuplicateInstanceIdException">
        /// You cannot specify an instance ID in more than one association.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidCommandIdException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidInstanceIdException">
        /// The following problems can cause this exception:
        /// 
        ///  
        /// <para>
        /// You do not have permission to access the instance.
        /// </para>
        ///  
        /// <para>
        /// SSM Agent is not running. Verify that SSM Agent is running.
        /// </para>
        ///  
        /// <para>
        /// SSM Agent is not registered with the SSM endpoint. Try reinstalling SSM Agent.
        /// </para>
        ///  
        /// <para>
        /// The instance is not in valid state. Valid states are: Running, Pending, Stopped, Stopping.
        /// Invalid states are: Shutting-down and Terminated.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/CancelCommand">REST API Reference for CancelCommand Operation</seealso>
        public virtual Task<CancelCommandResponse> CancelCommandAsync(string commandId, List<string> instanceIds, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new CancelCommandRequest();
            request.CommandId = commandId;
            request.InstanceIds = instanceIds;
            return CancelCommandAsync(request, cancellationToken);
        }



        /// <summary>
        /// Attempts to cancel the command specified by the Command ID. There is no guarantee
        /// that the command will be terminated and the underlying process stopped.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelCommand service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CancelCommand service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.DuplicateInstanceIdException">
        /// You cannot specify an instance ID in more than one association.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidCommandIdException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidInstanceIdException">
        /// The following problems can cause this exception:
        /// 
        ///  
        /// <para>
        /// You do not have permission to access the instance.
        /// </para>
        ///  
        /// <para>
        /// SSM Agent is not running. Verify that SSM Agent is running.
        /// </para>
        ///  
        /// <para>
        /// SSM Agent is not registered with the SSM endpoint. Try reinstalling SSM Agent.
        /// </para>
        ///  
        /// <para>
        /// The instance is not in valid state. Valid states are: Running, Pending, Stopped, Stopping.
        /// Invalid states are: Shutting-down and Terminated.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/CancelCommand">REST API Reference for CancelCommand Operation</seealso>
        public virtual Task<CancelCommandResponse> CancelCommandAsync(CancelCommandRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CancelCommandRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelCommandResponseUnmarshaller.Instance;

            return InvokeAsync<CancelCommandResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CancelMaintenanceWindowExecution

        internal virtual CancelMaintenanceWindowExecutionResponse CancelMaintenanceWindowExecution(CancelMaintenanceWindowExecutionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CancelMaintenanceWindowExecutionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelMaintenanceWindowExecutionResponseUnmarshaller.Instance;

            return Invoke<CancelMaintenanceWindowExecutionResponse>(request, options);
        }



        /// <summary>
        /// Stops a maintenance window execution that is already in progress and cancels any tasks
        /// in the window that have not already starting running. (Tasks already in progress will
        /// continue to completion.)
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelMaintenanceWindowExecution service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CancelMaintenanceWindowExecution service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.DoesNotExistException">
        /// Error returned when the ID specified for a resource, such as a maintenance window
        /// or Patch baseline, doesn't exist.
        /// 
        ///  
        /// <para>
        /// For information about resource quotas in Systems Manager, see <a href="http://docs.aws.amazon.com/general/latest/gr/ssm.html#limits_ssm">Systems
        /// Manager service quotas</a> in the <i>AWS General Reference</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/CancelMaintenanceWindowExecution">REST API Reference for CancelMaintenanceWindowExecution Operation</seealso>
        public virtual Task<CancelMaintenanceWindowExecutionResponse> CancelMaintenanceWindowExecutionAsync(CancelMaintenanceWindowExecutionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CancelMaintenanceWindowExecutionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelMaintenanceWindowExecutionResponseUnmarshaller.Instance;

            return InvokeAsync<CancelMaintenanceWindowExecutionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateActivation

        internal virtual CreateActivationResponse CreateActivation(CreateActivationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateActivationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateActivationResponseUnmarshaller.Instance;

            return Invoke<CreateActivationResponse>(request, options);
        }



        /// <summary>
        /// Generates an activation code and activation ID you can use to register your on-premises
        /// server or virtual machine (VM) with Systems Manager. Registering these machines with
        /// Systems Manager makes it possible to manage them using Systems Manager capabilities.
        /// You use the activation code and ID when installing SSM Agent on machines in your hybrid
        /// environment. For more information about requirements for managing on-premises instances
        /// and VMs using Systems Manager, see <a href="https://docs.aws.amazon.com/systems-manager/latest/userguide/systems-manager-managedinstances.html">Setting
        /// up AWS Systems Manager for hybrid environments</a> in the <i>AWS Systems Manager User
        /// Guide</i>. 
        /// 
        ///  <note> 
        /// <para>
        /// On-premises servers or VMs that are registered with Systems Manager and EC2 instances
        /// that you manage with Systems Manager are all called <i>managed instances</i>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateActivation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateActivation service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/CreateActivation">REST API Reference for CreateActivation Operation</seealso>
        public virtual Task<CreateActivationResponse> CreateActivationAsync(CreateActivationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateActivationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateActivationResponseUnmarshaller.Instance;

            return InvokeAsync<CreateActivationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateAssociation

        internal virtual CreateAssociationResponse CreateAssociation(CreateAssociationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAssociationResponseUnmarshaller.Instance;

            return Invoke<CreateAssociationResponse>(request, options);
        }


        /// <summary>
        /// A State Manager association defines the state that you want to maintain on your instances.
        /// For example, an association can specify that anti-virus software must be installed
        /// and running on your instances, or that certain ports must be closed. For static targets,
        /// the association specifies a schedule for when the configuration is reapplied. For
        /// dynamic targets, such as an AWS Resource Group or an AWS Autoscaling Group, State
        /// Manager applies the configuration when new instances are added to the group. The association
        /// also specifies actions to take when applying the configuration. For example, an association
        /// for anti-virus software might run once a day. If the software is not installed, then
        /// State Manager installs it. If the software is installed, but the service is not running,
        /// then the association might instruct State Manager to start the service.
        /// </summary>
        /// <param name="instanceId">The instance ID. <note>  <code>InstanceId</code> has been deprecated. To specify an instance ID for an association, use the <code>Targets</code> parameter. Requests that include the parameter <code>InstanceID</code> with SSM documents that use schema version 2.0 or later will fail. In addition, if you use the parameter <code>InstanceId</code>, you cannot use the parameters <code>AssociationName</code>, <code>DocumentVersion</code>, <code>MaxErrors</code>, <code>MaxConcurrency</code>, <code>OutputLocation</code>, or <code>ScheduleExpression</code>. To use these parameters, you must use the <code>Targets</code> parameter. </note></param>
        /// <param name="name">The name of the SSM document that contains the configuration information for the instance. You can specify Command or Automation documents. You can specify AWS-predefined documents, documents you created, or a document that is shared with you from another account. For SSM documents that are shared with you from other AWS accounts, you must specify the complete SSM document ARN, in the following format:  <code>arn:<i>partition</i>:ssm:<i>region</i>:<i>account-id</i>:document/<i>document-name</i> </code>  For example:  <code>arn:aws:ssm:us-east-2:12345678912:document/My-Shared-Document</code>  For AWS-predefined documents and SSM documents you created in your account, you only need to specify the document name. For example, <code>AWS-ApplyPatchBaseline</code> or <code>My-Document</code>.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateAssociation service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.AssociationAlreadyExistsException">
        /// The specified association already exists.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.AssociationLimitExceededException">
        /// You can have at most 2,000 active associations.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidDocumentException">
        /// The specified document does not exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidDocumentVersionException">
        /// The document version is not valid or does not exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidInstanceIdException">
        /// The following problems can cause this exception:
        /// 
        ///  
        /// <para>
        /// You do not have permission to access the instance.
        /// </para>
        ///  
        /// <para>
        /// SSM Agent is not running. Verify that SSM Agent is running.
        /// </para>
        ///  
        /// <para>
        /// SSM Agent is not registered with the SSM endpoint. Try reinstalling SSM Agent.
        /// </para>
        ///  
        /// <para>
        /// The instance is not in valid state. Valid states are: Running, Pending, Stopped, Stopping.
        /// Invalid states are: Shutting-down and Terminated.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidOutputLocationException">
        /// The output location is not valid or does not exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidParametersException">
        /// You must specify values for all required parameters in the Systems Manager document.
        /// You can only supply values to parameters defined in the Systems Manager document.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidScheduleException">
        /// The schedule is invalid. Verify your cron or rate expression and try again.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidTargetException">
        /// The target is not valid or does not exist. It might not be configured for Systems
        /// Manager or you might not have permission to perform the operation.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.UnsupportedPlatformTypeException">
        /// The document does not support the platform type of the given instance ID(s). For example,
        /// you sent an document for a Windows instance to a Linux instance.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/CreateAssociation">REST API Reference for CreateAssociation Operation</seealso>
        public virtual Task<CreateAssociationResponse> CreateAssociationAsync(string instanceId, string name, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new CreateAssociationRequest();
            request.InstanceId = instanceId;
            request.Name = name;
            return CreateAssociationAsync(request, cancellationToken);
        }



        /// <summary>
        /// A State Manager association defines the state that you want to maintain on your instances.
        /// For example, an association can specify that anti-virus software must be installed
        /// and running on your instances, or that certain ports must be closed. For static targets,
        /// the association specifies a schedule for when the configuration is reapplied. For
        /// dynamic targets, such as an AWS Resource Group or an AWS Autoscaling Group, State
        /// Manager applies the configuration when new instances are added to the group. The association
        /// also specifies actions to take when applying the configuration. For example, an association
        /// for anti-virus software might run once a day. If the software is not installed, then
        /// State Manager installs it. If the software is installed, but the service is not running,
        /// then the association might instruct State Manager to start the service.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAssociation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateAssociation service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.AssociationAlreadyExistsException">
        /// The specified association already exists.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.AssociationLimitExceededException">
        /// You can have at most 2,000 active associations.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidDocumentException">
        /// The specified document does not exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidDocumentVersionException">
        /// The document version is not valid or does not exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidInstanceIdException">
        /// The following problems can cause this exception:
        /// 
        ///  
        /// <para>
        /// You do not have permission to access the instance.
        /// </para>
        ///  
        /// <para>
        /// SSM Agent is not running. Verify that SSM Agent is running.
        /// </para>
        ///  
        /// <para>
        /// SSM Agent is not registered with the SSM endpoint. Try reinstalling SSM Agent.
        /// </para>
        ///  
        /// <para>
        /// The instance is not in valid state. Valid states are: Running, Pending, Stopped, Stopping.
        /// Invalid states are: Shutting-down and Terminated.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidOutputLocationException">
        /// The output location is not valid or does not exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidParametersException">
        /// You must specify values for all required parameters in the Systems Manager document.
        /// You can only supply values to parameters defined in the Systems Manager document.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidScheduleException">
        /// The schedule is invalid. Verify your cron or rate expression and try again.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidTargetException">
        /// The target is not valid or does not exist. It might not be configured for Systems
        /// Manager or you might not have permission to perform the operation.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.UnsupportedPlatformTypeException">
        /// The document does not support the platform type of the given instance ID(s). For example,
        /// you sent an document for a Windows instance to a Linux instance.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/CreateAssociation">REST API Reference for CreateAssociation Operation</seealso>
        public virtual Task<CreateAssociationResponse> CreateAssociationAsync(CreateAssociationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAssociationResponseUnmarshaller.Instance;

            return InvokeAsync<CreateAssociationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateAssociationBatch

        internal virtual CreateAssociationBatchResponse CreateAssociationBatch(CreateAssociationBatchRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateAssociationBatchRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAssociationBatchResponseUnmarshaller.Instance;

            return Invoke<CreateAssociationBatchResponse>(request, options);
        }



        /// <summary>
        /// Associates the specified Systems Manager document with the specified instances or
        /// targets.
        /// 
        ///  
        /// <para>
        /// When you associate a document with one or more instances using instance IDs or tags,
        /// SSM Agent running on the instance processes the document and configures the instance
        /// as specified.
        /// </para>
        ///  
        /// <para>
        /// If you associate a document with an instance that already has an associated document,
        /// the system returns the AssociationAlreadyExists exception.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAssociationBatch service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateAssociationBatch service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.AssociationLimitExceededException">
        /// You can have at most 2,000 active associations.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.DuplicateInstanceIdException">
        /// You cannot specify an instance ID in more than one association.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidDocumentException">
        /// The specified document does not exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidDocumentVersionException">
        /// The document version is not valid or does not exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidInstanceIdException">
        /// The following problems can cause this exception:
        /// 
        ///  
        /// <para>
        /// You do not have permission to access the instance.
        /// </para>
        ///  
        /// <para>
        /// SSM Agent is not running. Verify that SSM Agent is running.
        /// </para>
        ///  
        /// <para>
        /// SSM Agent is not registered with the SSM endpoint. Try reinstalling SSM Agent.
        /// </para>
        ///  
        /// <para>
        /// The instance is not in valid state. Valid states are: Running, Pending, Stopped, Stopping.
        /// Invalid states are: Shutting-down and Terminated.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidOutputLocationException">
        /// The output location is not valid or does not exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidParametersException">
        /// You must specify values for all required parameters in the Systems Manager document.
        /// You can only supply values to parameters defined in the Systems Manager document.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidScheduleException">
        /// The schedule is invalid. Verify your cron or rate expression and try again.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidTargetException">
        /// The target is not valid or does not exist. It might not be configured for Systems
        /// Manager or you might not have permission to perform the operation.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.UnsupportedPlatformTypeException">
        /// The document does not support the platform type of the given instance ID(s). For example,
        /// you sent an document for a Windows instance to a Linux instance.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/CreateAssociationBatch">REST API Reference for CreateAssociationBatch Operation</seealso>
        public virtual Task<CreateAssociationBatchResponse> CreateAssociationBatchAsync(CreateAssociationBatchRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateAssociationBatchRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAssociationBatchResponseUnmarshaller.Instance;

            return InvokeAsync<CreateAssociationBatchResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateDocument

        internal virtual CreateDocumentResponse CreateDocument(CreateDocumentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDocumentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDocumentResponseUnmarshaller.Instance;

            return Invoke<CreateDocumentResponse>(request, options);
        }


        /// <summary>
        /// Creates a Systems Manager (SSM) document. An SSM document defines the actions that
        /// Systems Manager performs on your managed instances. For more information about SSM
        /// documents, including information about supported schemas, features, and syntax, see
        /// <a href="https://docs.aws.amazon.com/systems-manager/latest/userguide/sysman-ssm-docs.html">AWS
        /// Systems Manager Documents</a> in the <i>AWS Systems Manager User Guide</i>.
        /// </summary>
        /// <param name="content">The content for the new SSM document in JSON or YAML format. We recommend storing the contents for your new document in an external JSON or YAML file and referencing the file in a command. For examples, see the following topics in the <i>AWS Systems Manager User Guide</i>. <ul> <li>  <a href="https://docs.aws.amazon.com/systems-manager/latest/userguide/create-ssm-document-api.html">Create an SSM document (AWS API)</a>  </li> <li>  <a href="https://docs.aws.amazon.com/systems-manager/latest/userguide/create-ssm-document-cli.html">Create an SSM document (AWS CLI)</a>  </li> <li>  <a href="https://docs.aws.amazon.com/systems-manager/latest/userguide/create-ssm-document-api.html">Create an SSM document (API)</a>  </li> </ul></param>
        /// <param name="name">A name for the Systems Manager document. <important> You can't use the following strings as document name prefixes. These are reserved by AWS for use as document name prefixes: <ul> <li>  <code>aws-</code>  </li> <li>  <code>amazon</code>  </li> <li>  <code>amzn</code>  </li> </ul> </important></param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateDocument service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.DocumentAlreadyExistsException">
        /// The specified document already exists.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.DocumentLimitExceededException">
        /// You can have at most 500 active Systems Manager documents.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidDocumentContentException">
        /// The content for the document is not valid.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidDocumentSchemaVersionException">
        /// The version of the document schema is not supported.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.MaxDocumentSizeExceededException">
        /// The size limit of a document is 64 KB.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/CreateDocument">REST API Reference for CreateDocument Operation</seealso>
        public virtual Task<CreateDocumentResponse> CreateDocumentAsync(string content, string name, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new CreateDocumentRequest();
            request.Content = content;
            request.Name = name;
            return CreateDocumentAsync(request, cancellationToken);
        }



        /// <summary>
        /// Creates a Systems Manager (SSM) document. An SSM document defines the actions that
        /// Systems Manager performs on your managed instances. For more information about SSM
        /// documents, including information about supported schemas, features, and syntax, see
        /// <a href="https://docs.aws.amazon.com/systems-manager/latest/userguide/sysman-ssm-docs.html">AWS
        /// Systems Manager Documents</a> in the <i>AWS Systems Manager User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDocument service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateDocument service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.DocumentAlreadyExistsException">
        /// The specified document already exists.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.DocumentLimitExceededException">
        /// You can have at most 500 active Systems Manager documents.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidDocumentContentException">
        /// The content for the document is not valid.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidDocumentSchemaVersionException">
        /// The version of the document schema is not supported.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.MaxDocumentSizeExceededException">
        /// The size limit of a document is 64 KB.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/CreateDocument">REST API Reference for CreateDocument Operation</seealso>
        public virtual Task<CreateDocumentResponse> CreateDocumentAsync(CreateDocumentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDocumentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDocumentResponseUnmarshaller.Instance;

            return InvokeAsync<CreateDocumentResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateMaintenanceWindow

        internal virtual CreateMaintenanceWindowResponse CreateMaintenanceWindow(CreateMaintenanceWindowRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateMaintenanceWindowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateMaintenanceWindowResponseUnmarshaller.Instance;

            return Invoke<CreateMaintenanceWindowResponse>(request, options);
        }



        /// <summary>
        /// Creates a new maintenance window.
        /// 
        ///  <note> 
        /// <para>
        /// The value you specify for <code>Duration</code> determines the specific end time for
        /// the maintenance window based on the time it begins. No maintenance window tasks are
        /// permitted to start after the resulting endtime minus the number of hours you specify
        /// for <code>Cutoff</code>. For example, if the maintenance window starts at 3 PM, the
        /// duration is three hours, and the value you specify for <code>Cutoff</code> is one
        /// hour, no maintenance window tasks can start after 5 PM.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateMaintenanceWindow service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateMaintenanceWindow service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.IdempotentParameterMismatchException">
        /// Error returned when an idempotent operation is retried and the parameters don't match
        /// the original call to the API with the same idempotency token.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.ResourceLimitExceededException">
        /// Error returned when the caller has exceeded the default resource quotas. For example,
        /// too many maintenance windows or patch baselines have been created.
        /// 
        ///  
        /// <para>
        /// For information about resource quotas in Systems Manager, see <a href="http://docs.aws.amazon.com/general/latest/gr/ssm.html#limits_ssm">Systems
        /// Manager service quotas</a> in the <i>AWS General Reference</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/CreateMaintenanceWindow">REST API Reference for CreateMaintenanceWindow Operation</seealso>
        public virtual Task<CreateMaintenanceWindowResponse> CreateMaintenanceWindowAsync(CreateMaintenanceWindowRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateMaintenanceWindowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateMaintenanceWindowResponseUnmarshaller.Instance;

            return InvokeAsync<CreateMaintenanceWindowResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateOpsItem

        internal virtual CreateOpsItemResponse CreateOpsItem(CreateOpsItemRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateOpsItemRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateOpsItemResponseUnmarshaller.Instance;

            return Invoke<CreateOpsItemResponse>(request, options);
        }



        /// <summary>
        /// Creates a new OpsItem. You must have permission in AWS Identity and Access Management
        /// (IAM) to create a new OpsItem. For more information, see <a href="https://docs.aws.amazon.com/systems-manager/latest/userguide/OpsCenter-getting-started.html">Getting
        /// started with OpsCenter</a> in the <i>AWS Systems Manager User Guide</i>.
        /// 
        ///  
        /// <para>
        /// Operations engineers and IT professionals use OpsCenter to view, investigate, and
        /// remediate operational issues impacting the performance and health of their AWS resources.
        /// For more information, see <a href="https://docs.aws.amazon.com/systems-manager/latest/userguide/OpsCenter.html">AWS
        /// Systems Manager OpsCenter</a> in the <i>AWS Systems Manager User Guide</i>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateOpsItem service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateOpsItem service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.OpsItemAlreadyExistsException">
        /// The OpsItem already exists.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.OpsItemInvalidParameterException">
        /// A specified parameter argument isn't valid. Verify the available arguments and try
        /// again.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.OpsItemLimitExceededException">
        /// The request caused OpsItems to exceed one or more quotas. For information about OpsItem
        /// quotas, see <a href="https://docs.aws.amazon.com/systems-manager/latest/userguide/OpsCenter-learn-more.html#OpsCenter-learn-more-limits">What
        /// are the resource limits for OpsCenter?</a>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/CreateOpsItem">REST API Reference for CreateOpsItem Operation</seealso>
        public virtual Task<CreateOpsItemResponse> CreateOpsItemAsync(CreateOpsItemRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateOpsItemRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateOpsItemResponseUnmarshaller.Instance;

            return InvokeAsync<CreateOpsItemResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateOpsMetadata

        internal virtual CreateOpsMetadataResponse CreateOpsMetadata(CreateOpsMetadataRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateOpsMetadataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateOpsMetadataResponseUnmarshaller.Instance;

            return Invoke<CreateOpsMetadataResponse>(request, options);
        }



        /// <summary>
        /// If you create a new application in Application Manager, Systems Manager calls this
        /// API action to specify information about the new application, including the application
        /// type.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateOpsMetadata service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateOpsMetadata service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.OpsMetadataAlreadyExistsException">
        /// An OpsMetadata object already exists for the selected resource.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.OpsMetadataInvalidArgumentException">
        /// One of the arguments passed is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.OpsMetadataLimitExceededException">
        /// Your account reached the maximum number of OpsMetadata objects allowed by Application
        /// Manager. The maximum is 200 OpsMetadata objects. Delete one or more OpsMetadata object
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.OpsMetadataTooManyUpdatesException">
        /// The system is processing too many concurrent updates. Wait a few moments and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/CreateOpsMetadata">REST API Reference for CreateOpsMetadata Operation</seealso>
        public virtual Task<CreateOpsMetadataResponse> CreateOpsMetadataAsync(CreateOpsMetadataRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateOpsMetadataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateOpsMetadataResponseUnmarshaller.Instance;

            return InvokeAsync<CreateOpsMetadataResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreatePatchBaseline

        internal virtual CreatePatchBaselineResponse CreatePatchBaseline(CreatePatchBaselineRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreatePatchBaselineRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePatchBaselineResponseUnmarshaller.Instance;

            return Invoke<CreatePatchBaselineResponse>(request, options);
        }



        /// <summary>
        /// Creates a patch baseline.
        /// 
        ///  <note> 
        /// <para>
        /// For information about valid key and value pairs in <code>PatchFilters</code> for each
        /// supported operating system type, see <a href="http://docs.aws.amazon.com/systems-manager/latest/APIReference/API_PatchFilter.html">PatchFilter</a>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePatchBaseline service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreatePatchBaseline service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.IdempotentParameterMismatchException">
        /// Error returned when an idempotent operation is retried and the parameters don't match
        /// the original call to the API with the same idempotency token.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.ResourceLimitExceededException">
        /// Error returned when the caller has exceeded the default resource quotas. For example,
        /// too many maintenance windows or patch baselines have been created.
        /// 
        ///  
        /// <para>
        /// For information about resource quotas in Systems Manager, see <a href="http://docs.aws.amazon.com/general/latest/gr/ssm.html#limits_ssm">Systems
        /// Manager service quotas</a> in the <i>AWS General Reference</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/CreatePatchBaseline">REST API Reference for CreatePatchBaseline Operation</seealso>
        public virtual Task<CreatePatchBaselineResponse> CreatePatchBaselineAsync(CreatePatchBaselineRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreatePatchBaselineRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePatchBaselineResponseUnmarshaller.Instance;

            return InvokeAsync<CreatePatchBaselineResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateResourceDataSync

        internal virtual CreateResourceDataSyncResponse CreateResourceDataSync(CreateResourceDataSyncRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateResourceDataSyncRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateResourceDataSyncResponseUnmarshaller.Instance;

            return Invoke<CreateResourceDataSyncResponse>(request, options);
        }



        /// <summary>
        /// A resource data sync helps you view data from multiple sources in a single location.
        /// Systems Manager offers two types of resource data sync: <code>SyncToDestination</code>
        /// and <code>SyncFromSource</code>.
        /// 
        ///  
        /// <para>
        /// You can configure Systems Manager Inventory to use the <code>SyncToDestination</code>
        /// type to synchronize Inventory data from multiple AWS Regions to a single S3 bucket.
        /// For more information, see <a href="https://docs.aws.amazon.com/systems-manager/latest/userguide/sysman-inventory-datasync.html">Configuring
        /// Resource Data Sync for Inventory</a> in the <i>AWS Systems Manager User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// You can configure Systems Manager Explorer to use the <code>SyncFromSource</code>
        /// type to synchronize operational work items (OpsItems) and operational data (OpsData)
        /// from multiple AWS Regions to a single S3 bucket. This type can synchronize OpsItems
        /// and OpsData from multiple AWS accounts and Regions or <code>EntireOrganization</code>
        /// by using AWS Organizations. For more information, see <a href="https://docs.aws.amazon.com/systems-manager/latest/userguide/Explorer-resource-data-sync.html">Setting
        /// up Systems Manager Explorer to display data from multiple accounts and Regions</a>
        /// in the <i>AWS Systems Manager User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// A resource data sync is an asynchronous operation that returns immediately. After
        /// a successful initial sync is completed, the system continuously syncs data. To check
        /// the status of a sync, use the <a>ListResourceDataSync</a>.
        /// </para>
        ///  <note> 
        /// <para>
        /// By default, data is not encrypted in Amazon S3. We strongly recommend that you enable
        /// encryption in Amazon S3 to ensure secure data storage. We also recommend that you
        /// secure access to the Amazon S3 bucket by creating a restrictive bucket policy. 
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateResourceDataSync service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateResourceDataSync service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.ResourceDataSyncAlreadyExistsException">
        /// A sync configuration with the same name already exists.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.ResourceDataSyncCountExceededException">
        /// You have exceeded the allowed maximum sync configurations.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.ResourceDataSyncInvalidConfigurationException">
        /// The specified sync configuration is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/CreateResourceDataSync">REST API Reference for CreateResourceDataSync Operation</seealso>
        public virtual Task<CreateResourceDataSyncResponse> CreateResourceDataSyncAsync(CreateResourceDataSyncRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateResourceDataSyncRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateResourceDataSyncResponseUnmarshaller.Instance;

            return InvokeAsync<CreateResourceDataSyncResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteActivation

        internal virtual DeleteActivationResponse DeleteActivation(DeleteActivationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteActivationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteActivationResponseUnmarshaller.Instance;

            return Invoke<DeleteActivationResponse>(request, options);
        }



        /// <summary>
        /// Deletes an activation. You are not required to delete an activation. If you delete
        /// an activation, you can no longer use it to register additional managed instances.
        /// Deleting an activation does not de-register managed instances. You must manually de-register
        /// managed instances.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteActivation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteActivation service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidActivationException">
        /// The activation is not valid. The activation might have been deleted, or the ActivationId
        /// and the ActivationCode do not match.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidActivationIdException">
        /// The activation ID is not valid. Verify the you entered the correct ActivationId or
        /// ActivationCode and try again.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.TooManyUpdatesException">
        /// There are concurrent updates for a resource that supports one update at a time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DeleteActivation">REST API Reference for DeleteActivation Operation</seealso>
        public virtual Task<DeleteActivationResponse> DeleteActivationAsync(DeleteActivationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteActivationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteActivationResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteActivationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteAssociation

        internal virtual DeleteAssociationResponse DeleteAssociation(DeleteAssociationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAssociationResponseUnmarshaller.Instance;

            return Invoke<DeleteAssociationResponse>(request, options);
        }


        /// <summary>
        /// Disassociates the specified Systems Manager document from the specified instance.
        /// 
        ///  
        /// <para>
        /// When you disassociate a document from an instance, it does not change the configuration
        /// of the instance. To change the configuration state of an instance after you disassociate
        /// a document, you must create a new document with the desired configuration and associate
        /// it with the instance.
        /// </para>
        /// </summary>
        /// <param name="instanceId">The ID of the instance.</param>
        /// <param name="name">The name of the Systems Manager document.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteAssociation service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.AssociationDoesNotExistException">
        /// The specified association does not exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidDocumentException">
        /// The specified document does not exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidInstanceIdException">
        /// The following problems can cause this exception:
        /// 
        ///  
        /// <para>
        /// You do not have permission to access the instance.
        /// </para>
        ///  
        /// <para>
        /// SSM Agent is not running. Verify that SSM Agent is running.
        /// </para>
        ///  
        /// <para>
        /// SSM Agent is not registered with the SSM endpoint. Try reinstalling SSM Agent.
        /// </para>
        ///  
        /// <para>
        /// The instance is not in valid state. Valid states are: Running, Pending, Stopped, Stopping.
        /// Invalid states are: Shutting-down and Terminated.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.TooManyUpdatesException">
        /// There are concurrent updates for a resource that supports one update at a time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DeleteAssociation">REST API Reference for DeleteAssociation Operation</seealso>
        public virtual Task<DeleteAssociationResponse> DeleteAssociationAsync(string instanceId, string name, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new DeleteAssociationRequest();
            request.InstanceId = instanceId;
            request.Name = name;
            return DeleteAssociationAsync(request, cancellationToken);
        }



        /// <summary>
        /// Disassociates the specified Systems Manager document from the specified instance.
        /// 
        ///  
        /// <para>
        /// When you disassociate a document from an instance, it does not change the configuration
        /// of the instance. To change the configuration state of an instance after you disassociate
        /// a document, you must create a new document with the desired configuration and associate
        /// it with the instance.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAssociation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteAssociation service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.AssociationDoesNotExistException">
        /// The specified association does not exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidDocumentException">
        /// The specified document does not exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidInstanceIdException">
        /// The following problems can cause this exception:
        /// 
        ///  
        /// <para>
        /// You do not have permission to access the instance.
        /// </para>
        ///  
        /// <para>
        /// SSM Agent is not running. Verify that SSM Agent is running.
        /// </para>
        ///  
        /// <para>
        /// SSM Agent is not registered with the SSM endpoint. Try reinstalling SSM Agent.
        /// </para>
        ///  
        /// <para>
        /// The instance is not in valid state. Valid states are: Running, Pending, Stopped, Stopping.
        /// Invalid states are: Shutting-down and Terminated.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.TooManyUpdatesException">
        /// There are concurrent updates for a resource that supports one update at a time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DeleteAssociation">REST API Reference for DeleteAssociation Operation</seealso>
        public virtual Task<DeleteAssociationResponse> DeleteAssociationAsync(DeleteAssociationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAssociationResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteAssociationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteDocument

        internal virtual DeleteDocumentResponse DeleteDocument(DeleteDocumentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDocumentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDocumentResponseUnmarshaller.Instance;

            return Invoke<DeleteDocumentResponse>(request, options);
        }


        /// <summary>
        /// Deletes the Systems Manager document and all instance associations to the document.
        /// 
        ///  
        /// <para>
        /// Before you delete the document, we recommend that you use <a>DeleteAssociation</a>
        /// to disassociate all instances that are associated with the document.
        /// </para>
        /// </summary>
        /// <param name="name">The name of the document.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteDocument service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.AssociatedInstancesException">
        /// You must disassociate a document from all instances before you can delete it.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidDocumentException">
        /// The specified document does not exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidDocumentOperationException">
        /// You attempted to delete a document while it is still shared. You must stop sharing
        /// the document before you can delete it.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DeleteDocument">REST API Reference for DeleteDocument Operation</seealso>
        public virtual Task<DeleteDocumentResponse> DeleteDocumentAsync(string name, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new DeleteDocumentRequest();
            request.Name = name;
            return DeleteDocumentAsync(request, cancellationToken);
        }



        /// <summary>
        /// Deletes the Systems Manager document and all instance associations to the document.
        /// 
        ///  
        /// <para>
        /// Before you delete the document, we recommend that you use <a>DeleteAssociation</a>
        /// to disassociate all instances that are associated with the document.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDocument service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteDocument service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.AssociatedInstancesException">
        /// You must disassociate a document from all instances before you can delete it.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidDocumentException">
        /// The specified document does not exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidDocumentOperationException">
        /// You attempted to delete a document while it is still shared. You must stop sharing
        /// the document before you can delete it.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DeleteDocument">REST API Reference for DeleteDocument Operation</seealso>
        public virtual Task<DeleteDocumentResponse> DeleteDocumentAsync(DeleteDocumentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDocumentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDocumentResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteDocumentResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteInventory

        internal virtual DeleteInventoryResponse DeleteInventory(DeleteInventoryRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteInventoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteInventoryResponseUnmarshaller.Instance;

            return Invoke<DeleteInventoryResponse>(request, options);
        }



        /// <summary>
        /// Delete a custom inventory type or the data associated with a custom Inventory type.
        /// Deleting a custom inventory type is also referred to as deleting a custom inventory
        /// schema.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteInventory service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteInventory service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidDeleteInventoryParametersException">
        /// One or more of the parameters specified for the delete operation is not valid. Verify
        /// all parameters and try again.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidInventoryRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidOptionException">
        /// The delete inventory option specified is not valid. Verify the option and try again.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidTypeNameException">
        /// The parameter type name is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DeleteInventory">REST API Reference for DeleteInventory Operation</seealso>
        public virtual Task<DeleteInventoryResponse> DeleteInventoryAsync(DeleteInventoryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteInventoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteInventoryResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteInventoryResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteMaintenanceWindow

        internal virtual DeleteMaintenanceWindowResponse DeleteMaintenanceWindow(DeleteMaintenanceWindowRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteMaintenanceWindowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteMaintenanceWindowResponseUnmarshaller.Instance;

            return Invoke<DeleteMaintenanceWindowResponse>(request, options);
        }



        /// <summary>
        /// Deletes a maintenance window.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteMaintenanceWindow service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteMaintenanceWindow service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DeleteMaintenanceWindow">REST API Reference for DeleteMaintenanceWindow Operation</seealso>
        public virtual Task<DeleteMaintenanceWindowResponse> DeleteMaintenanceWindowAsync(DeleteMaintenanceWindowRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteMaintenanceWindowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteMaintenanceWindowResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteMaintenanceWindowResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteOpsMetadata

        internal virtual DeleteOpsMetadataResponse DeleteOpsMetadata(DeleteOpsMetadataRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteOpsMetadataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteOpsMetadataResponseUnmarshaller.Instance;

            return Invoke<DeleteOpsMetadataResponse>(request, options);
        }



        /// <summary>
        /// Delete OpsMetadata related to an application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteOpsMetadata service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteOpsMetadata service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.OpsMetadataInvalidArgumentException">
        /// One of the arguments passed is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.OpsMetadataNotFoundException">
        /// The OpsMetadata object does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DeleteOpsMetadata">REST API Reference for DeleteOpsMetadata Operation</seealso>
        public virtual Task<DeleteOpsMetadataResponse> DeleteOpsMetadataAsync(DeleteOpsMetadataRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteOpsMetadataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteOpsMetadataResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteOpsMetadataResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteParameter

        internal virtual DeleteParameterResponse DeleteParameter(DeleteParameterRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteParameterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteParameterResponseUnmarshaller.Instance;

            return Invoke<DeleteParameterResponse>(request, options);
        }



        /// <summary>
        /// Delete a parameter from the system.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteParameter service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteParameter service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.ParameterNotFoundException">
        /// The parameter could not be found. Verify the name and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DeleteParameter">REST API Reference for DeleteParameter Operation</seealso>
        public virtual Task<DeleteParameterResponse> DeleteParameterAsync(DeleteParameterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteParameterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteParameterResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteParameterResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteParameters

        internal virtual DeleteParametersResponse DeleteParameters(DeleteParametersRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteParametersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteParametersResponseUnmarshaller.Instance;

            return Invoke<DeleteParametersResponse>(request, options);
        }



        /// <summary>
        /// Delete a list of parameters.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteParameters service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteParameters service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DeleteParameters">REST API Reference for DeleteParameters Operation</seealso>
        public virtual Task<DeleteParametersResponse> DeleteParametersAsync(DeleteParametersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteParametersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteParametersResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteParametersResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeletePatchBaseline

        internal virtual DeletePatchBaselineResponse DeletePatchBaseline(DeletePatchBaselineRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeletePatchBaselineRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeletePatchBaselineResponseUnmarshaller.Instance;

            return Invoke<DeletePatchBaselineResponse>(request, options);
        }



        /// <summary>
        /// Deletes a patch baseline.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePatchBaseline service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeletePatchBaseline service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.ResourceInUseException">
        /// Error returned if an attempt is made to delete a patch baseline that is registered
        /// for a patch group.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DeletePatchBaseline">REST API Reference for DeletePatchBaseline Operation</seealso>
        public virtual Task<DeletePatchBaselineResponse> DeletePatchBaselineAsync(DeletePatchBaselineRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeletePatchBaselineRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeletePatchBaselineResponseUnmarshaller.Instance;

            return InvokeAsync<DeletePatchBaselineResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteResourceDataSync

        internal virtual DeleteResourceDataSyncResponse DeleteResourceDataSync(DeleteResourceDataSyncRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteResourceDataSyncRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteResourceDataSyncResponseUnmarshaller.Instance;

            return Invoke<DeleteResourceDataSyncResponse>(request, options);
        }



        /// <summary>
        /// Deletes a Resource Data Sync configuration. After the configuration is deleted, changes
        /// to data on managed instances are no longer synced to or from the target. Deleting
        /// a sync configuration does not delete data.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteResourceDataSync service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteResourceDataSync service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.ResourceDataSyncInvalidConfigurationException">
        /// The specified sync configuration is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.ResourceDataSyncNotFoundException">
        /// The specified sync name was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DeleteResourceDataSync">REST API Reference for DeleteResourceDataSync Operation</seealso>
        public virtual Task<DeleteResourceDataSyncResponse> DeleteResourceDataSyncAsync(DeleteResourceDataSyncRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteResourceDataSyncRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteResourceDataSyncResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteResourceDataSyncResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeregisterManagedInstance

        internal virtual DeregisterManagedInstanceResponse DeregisterManagedInstance(DeregisterManagedInstanceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeregisterManagedInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeregisterManagedInstanceResponseUnmarshaller.Instance;

            return Invoke<DeregisterManagedInstanceResponse>(request, options);
        }



        /// <summary>
        /// Removes the server or virtual machine from the list of registered servers. You can
        /// reregister the instance again at any time. If you don't plan to use Run Command on
        /// the server, we suggest uninstalling SSM Agent first.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeregisterManagedInstance service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeregisterManagedInstance service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidInstanceIdException">
        /// The following problems can cause this exception:
        /// 
        ///  
        /// <para>
        /// You do not have permission to access the instance.
        /// </para>
        ///  
        /// <para>
        /// SSM Agent is not running. Verify that SSM Agent is running.
        /// </para>
        ///  
        /// <para>
        /// SSM Agent is not registered with the SSM endpoint. Try reinstalling SSM Agent.
        /// </para>
        ///  
        /// <para>
        /// The instance is not in valid state. Valid states are: Running, Pending, Stopped, Stopping.
        /// Invalid states are: Shutting-down and Terminated.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DeregisterManagedInstance">REST API Reference for DeregisterManagedInstance Operation</seealso>
        public virtual Task<DeregisterManagedInstanceResponse> DeregisterManagedInstanceAsync(DeregisterManagedInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeregisterManagedInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeregisterManagedInstanceResponseUnmarshaller.Instance;

            return InvokeAsync<DeregisterManagedInstanceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeregisterPatchBaselineForPatchGroup

        internal virtual DeregisterPatchBaselineForPatchGroupResponse DeregisterPatchBaselineForPatchGroup(DeregisterPatchBaselineForPatchGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeregisterPatchBaselineForPatchGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeregisterPatchBaselineForPatchGroupResponseUnmarshaller.Instance;

            return Invoke<DeregisterPatchBaselineForPatchGroupResponse>(request, options);
        }



        /// <summary>
        /// Removes a patch group from a patch baseline.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeregisterPatchBaselineForPatchGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeregisterPatchBaselineForPatchGroup service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidResourceIdException">
        /// The resource ID is not valid. Verify that you entered the correct ID and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DeregisterPatchBaselineForPatchGroup">REST API Reference for DeregisterPatchBaselineForPatchGroup Operation</seealso>
        public virtual Task<DeregisterPatchBaselineForPatchGroupResponse> DeregisterPatchBaselineForPatchGroupAsync(DeregisterPatchBaselineForPatchGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeregisterPatchBaselineForPatchGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeregisterPatchBaselineForPatchGroupResponseUnmarshaller.Instance;

            return InvokeAsync<DeregisterPatchBaselineForPatchGroupResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeregisterTargetFromMaintenanceWindow

        internal virtual DeregisterTargetFromMaintenanceWindowResponse DeregisterTargetFromMaintenanceWindow(DeregisterTargetFromMaintenanceWindowRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeregisterTargetFromMaintenanceWindowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeregisterTargetFromMaintenanceWindowResponseUnmarshaller.Instance;

            return Invoke<DeregisterTargetFromMaintenanceWindowResponse>(request, options);
        }



        /// <summary>
        /// Removes a target from a maintenance window.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeregisterTargetFromMaintenanceWindow service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeregisterTargetFromMaintenanceWindow service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.DoesNotExistException">
        /// Error returned when the ID specified for a resource, such as a maintenance window
        /// or Patch baseline, doesn't exist.
        /// 
        ///  
        /// <para>
        /// For information about resource quotas in Systems Manager, see <a href="http://docs.aws.amazon.com/general/latest/gr/ssm.html#limits_ssm">Systems
        /// Manager service quotas</a> in the <i>AWS General Reference</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.TargetInUseException">
        /// You specified the <code>Safe</code> option for the DeregisterTargetFromMaintenanceWindow
        /// operation, but the target is still referenced in a task.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DeregisterTargetFromMaintenanceWindow">REST API Reference for DeregisterTargetFromMaintenanceWindow Operation</seealso>
        public virtual Task<DeregisterTargetFromMaintenanceWindowResponse> DeregisterTargetFromMaintenanceWindowAsync(DeregisterTargetFromMaintenanceWindowRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeregisterTargetFromMaintenanceWindowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeregisterTargetFromMaintenanceWindowResponseUnmarshaller.Instance;

            return InvokeAsync<DeregisterTargetFromMaintenanceWindowResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeregisterTaskFromMaintenanceWindow

        internal virtual DeregisterTaskFromMaintenanceWindowResponse DeregisterTaskFromMaintenanceWindow(DeregisterTaskFromMaintenanceWindowRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeregisterTaskFromMaintenanceWindowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeregisterTaskFromMaintenanceWindowResponseUnmarshaller.Instance;

            return Invoke<DeregisterTaskFromMaintenanceWindowResponse>(request, options);
        }



        /// <summary>
        /// Removes a task from a maintenance window.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeregisterTaskFromMaintenanceWindow service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeregisterTaskFromMaintenanceWindow service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.DoesNotExistException">
        /// Error returned when the ID specified for a resource, such as a maintenance window
        /// or Patch baseline, doesn't exist.
        /// 
        ///  
        /// <para>
        /// For information about resource quotas in Systems Manager, see <a href="http://docs.aws.amazon.com/general/latest/gr/ssm.html#limits_ssm">Systems
        /// Manager service quotas</a> in the <i>AWS General Reference</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DeregisterTaskFromMaintenanceWindow">REST API Reference for DeregisterTaskFromMaintenanceWindow Operation</seealso>
        public virtual Task<DeregisterTaskFromMaintenanceWindowResponse> DeregisterTaskFromMaintenanceWindowAsync(DeregisterTaskFromMaintenanceWindowRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeregisterTaskFromMaintenanceWindowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeregisterTaskFromMaintenanceWindowResponseUnmarshaller.Instance;

            return InvokeAsync<DeregisterTaskFromMaintenanceWindowResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeActivations

        internal virtual DescribeActivationsResponse DescribeActivations(DescribeActivationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeActivationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeActivationsResponseUnmarshaller.Instance;

            return Invoke<DescribeActivationsResponse>(request, options);
        }



        /// <summary>
        /// Describes details about the activation, such as the date and time the activation was
        /// created, its expiration date, the IAM role assigned to the instances in the activation,
        /// and the number of instances registered by using this activation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeActivations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeActivations service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidFilterException">
        /// The filter name is not valid. Verify the you entered the correct name and try again.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidNextTokenException">
        /// The specified token is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribeActivations">REST API Reference for DescribeActivations Operation</seealso>
        public virtual Task<DescribeActivationsResponse> DescribeActivationsAsync(DescribeActivationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeActivationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeActivationsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeActivationsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeAssociation

        internal virtual DescribeAssociationResponse DescribeAssociation(DescribeAssociationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAssociationResponseUnmarshaller.Instance;

            return Invoke<DescribeAssociationResponse>(request, options);
        }


        /// <summary>
        /// Describes the association for the specified target or instance. If you created the
        /// association by using the <code>Targets</code> parameter, then you must retrieve the
        /// association by using the association ID. If you created the association by specifying
        /// an instance ID and a Systems Manager document, then you retrieve the association by
        /// specifying the document name and the instance ID.
        /// </summary>
        /// <param name="instanceId">The instance ID.</param>
        /// <param name="name">The name of the Systems Manager document.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeAssociation service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.AssociationDoesNotExistException">
        /// The specified association does not exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidAssociationVersionException">
        /// The version you specified is not valid. Use ListAssociationVersions to view all versions
        /// of an association according to the association ID. Or, use the <code>$LATEST</code>
        /// parameter to view the latest version of the association.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidDocumentException">
        /// The specified document does not exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidInstanceIdException">
        /// The following problems can cause this exception:
        /// 
        ///  
        /// <para>
        /// You do not have permission to access the instance.
        /// </para>
        ///  
        /// <para>
        /// SSM Agent is not running. Verify that SSM Agent is running.
        /// </para>
        ///  
        /// <para>
        /// SSM Agent is not registered with the SSM endpoint. Try reinstalling SSM Agent.
        /// </para>
        ///  
        /// <para>
        /// The instance is not in valid state. Valid states are: Running, Pending, Stopped, Stopping.
        /// Invalid states are: Shutting-down and Terminated.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribeAssociation">REST API Reference for DescribeAssociation Operation</seealso>
        public virtual Task<DescribeAssociationResponse> DescribeAssociationAsync(string instanceId, string name, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new DescribeAssociationRequest();
            request.InstanceId = instanceId;
            request.Name = name;
            return DescribeAssociationAsync(request, cancellationToken);
        }



        /// <summary>
        /// Describes the association for the specified target or instance. If you created the
        /// association by using the <code>Targets</code> parameter, then you must retrieve the
        /// association by using the association ID. If you created the association by specifying
        /// an instance ID and a Systems Manager document, then you retrieve the association by
        /// specifying the document name and the instance ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAssociation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeAssociation service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.AssociationDoesNotExistException">
        /// The specified association does not exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidAssociationVersionException">
        /// The version you specified is not valid. Use ListAssociationVersions to view all versions
        /// of an association according to the association ID. Or, use the <code>$LATEST</code>
        /// parameter to view the latest version of the association.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidDocumentException">
        /// The specified document does not exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidInstanceIdException">
        /// The following problems can cause this exception:
        /// 
        ///  
        /// <para>
        /// You do not have permission to access the instance.
        /// </para>
        ///  
        /// <para>
        /// SSM Agent is not running. Verify that SSM Agent is running.
        /// </para>
        ///  
        /// <para>
        /// SSM Agent is not registered with the SSM endpoint. Try reinstalling SSM Agent.
        /// </para>
        ///  
        /// <para>
        /// The instance is not in valid state. Valid states are: Running, Pending, Stopped, Stopping.
        /// Invalid states are: Shutting-down and Terminated.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribeAssociation">REST API Reference for DescribeAssociation Operation</seealso>
        public virtual Task<DescribeAssociationResponse> DescribeAssociationAsync(DescribeAssociationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAssociationResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeAssociationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeAssociationExecutions

        internal virtual DescribeAssociationExecutionsResponse DescribeAssociationExecutions(DescribeAssociationExecutionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAssociationExecutionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAssociationExecutionsResponseUnmarshaller.Instance;

            return Invoke<DescribeAssociationExecutionsResponse>(request, options);
        }



        /// <summary>
        /// Use this API action to view all executions for a specific association ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAssociationExecutions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeAssociationExecutions service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.AssociationDoesNotExistException">
        /// The specified association does not exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidNextTokenException">
        /// The specified token is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribeAssociationExecutions">REST API Reference for DescribeAssociationExecutions Operation</seealso>
        public virtual Task<DescribeAssociationExecutionsResponse> DescribeAssociationExecutionsAsync(DescribeAssociationExecutionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAssociationExecutionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAssociationExecutionsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeAssociationExecutionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeAssociationExecutionTargets

        internal virtual DescribeAssociationExecutionTargetsResponse DescribeAssociationExecutionTargets(DescribeAssociationExecutionTargetsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAssociationExecutionTargetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAssociationExecutionTargetsResponseUnmarshaller.Instance;

            return Invoke<DescribeAssociationExecutionTargetsResponse>(request, options);
        }



        /// <summary>
        /// Use this API action to view information about a specific execution of a specific association.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAssociationExecutionTargets service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeAssociationExecutionTargets service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.AssociationDoesNotExistException">
        /// The specified association does not exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.AssociationExecutionDoesNotExistException">
        /// The specified execution ID does not exist. Verify the ID number and try again.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidNextTokenException">
        /// The specified token is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribeAssociationExecutionTargets">REST API Reference for DescribeAssociationExecutionTargets Operation</seealso>
        public virtual Task<DescribeAssociationExecutionTargetsResponse> DescribeAssociationExecutionTargetsAsync(DescribeAssociationExecutionTargetsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAssociationExecutionTargetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAssociationExecutionTargetsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeAssociationExecutionTargetsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeAutomationExecutions

        internal virtual DescribeAutomationExecutionsResponse DescribeAutomationExecutions(DescribeAutomationExecutionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAutomationExecutionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAutomationExecutionsResponseUnmarshaller.Instance;

            return Invoke<DescribeAutomationExecutionsResponse>(request, options);
        }



        /// <summary>
        /// Provides details about all active and terminated Automation executions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAutomationExecutions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeAutomationExecutions service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidFilterKeyException">
        /// The specified key is not valid.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidFilterValueException">
        /// The filter value is not valid. Verify the value and try again.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidNextTokenException">
        /// The specified token is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribeAutomationExecutions">REST API Reference for DescribeAutomationExecutions Operation</seealso>
        public virtual Task<DescribeAutomationExecutionsResponse> DescribeAutomationExecutionsAsync(DescribeAutomationExecutionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAutomationExecutionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAutomationExecutionsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeAutomationExecutionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeAutomationStepExecutions

        internal virtual DescribeAutomationStepExecutionsResponse DescribeAutomationStepExecutions(DescribeAutomationStepExecutionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAutomationStepExecutionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAutomationStepExecutionsResponseUnmarshaller.Instance;

            return Invoke<DescribeAutomationStepExecutionsResponse>(request, options);
        }



        /// <summary>
        /// Information about all active and terminated step executions in an Automation workflow.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAutomationStepExecutions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeAutomationStepExecutions service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.AutomationExecutionNotFoundException">
        /// There is no automation execution information for the requested automation execution
        /// ID.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidFilterKeyException">
        /// The specified key is not valid.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidFilterValueException">
        /// The filter value is not valid. Verify the value and try again.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidNextTokenException">
        /// The specified token is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribeAutomationStepExecutions">REST API Reference for DescribeAutomationStepExecutions Operation</seealso>
        public virtual Task<DescribeAutomationStepExecutionsResponse> DescribeAutomationStepExecutionsAsync(DescribeAutomationStepExecutionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAutomationStepExecutionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAutomationStepExecutionsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeAutomationStepExecutionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeAvailablePatches

        internal virtual DescribeAvailablePatchesResponse DescribeAvailablePatches(DescribeAvailablePatchesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAvailablePatchesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAvailablePatchesResponseUnmarshaller.Instance;

            return Invoke<DescribeAvailablePatchesResponse>(request, options);
        }



        /// <summary>
        /// Lists all patches eligible to be included in a patch baseline.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAvailablePatches service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeAvailablePatches service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribeAvailablePatches">REST API Reference for DescribeAvailablePatches Operation</seealso>
        public virtual Task<DescribeAvailablePatchesResponse> DescribeAvailablePatchesAsync(DescribeAvailablePatchesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAvailablePatchesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAvailablePatchesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeAvailablePatchesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeDocument

        internal virtual DescribeDocumentResponse DescribeDocument(DescribeDocumentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDocumentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDocumentResponseUnmarshaller.Instance;

            return Invoke<DescribeDocumentResponse>(request, options);
        }


        /// <summary>
        /// Describes the specified Systems Manager document.
        /// </summary>
        /// <param name="name">The name of the Systems Manager document.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeDocument service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidDocumentException">
        /// The specified document does not exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidDocumentVersionException">
        /// The document version is not valid or does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribeDocument">REST API Reference for DescribeDocument Operation</seealso>
        public virtual Task<DescribeDocumentResponse> DescribeDocumentAsync(string name, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new DescribeDocumentRequest();
            request.Name = name;
            return DescribeDocumentAsync(request, cancellationToken);
        }



        /// <summary>
        /// Describes the specified Systems Manager document.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDocument service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeDocument service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidDocumentException">
        /// The specified document does not exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidDocumentVersionException">
        /// The document version is not valid or does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribeDocument">REST API Reference for DescribeDocument Operation</seealso>
        public virtual Task<DescribeDocumentResponse> DescribeDocumentAsync(DescribeDocumentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDocumentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDocumentResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeDocumentResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeDocumentPermission

        internal virtual DescribeDocumentPermissionResponse DescribeDocumentPermission(DescribeDocumentPermissionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDocumentPermissionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDocumentPermissionResponseUnmarshaller.Instance;

            return Invoke<DescribeDocumentPermissionResponse>(request, options);
        }



        /// <summary>
        /// Describes the permissions for a Systems Manager document. If you created the document,
        /// you are the owner. If a document is shared, it can either be shared privately (by
        /// specifying a user's AWS account ID) or publicly (<i>All</i>).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDocumentPermission service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeDocumentPermission service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidDocumentException">
        /// The specified document does not exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidPermissionTypeException">
        /// The permission type is not supported. <i>Share</i> is the only supported permission
        /// type.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribeDocumentPermission">REST API Reference for DescribeDocumentPermission Operation</seealso>
        public virtual Task<DescribeDocumentPermissionResponse> DescribeDocumentPermissionAsync(DescribeDocumentPermissionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDocumentPermissionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDocumentPermissionResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeDocumentPermissionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeEffectiveInstanceAssociations

        internal virtual DescribeEffectiveInstanceAssociationsResponse DescribeEffectiveInstanceAssociations(DescribeEffectiveInstanceAssociationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeEffectiveInstanceAssociationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEffectiveInstanceAssociationsResponseUnmarshaller.Instance;

            return Invoke<DescribeEffectiveInstanceAssociationsResponse>(request, options);
        }



        /// <summary>
        /// All associations for the instance(s).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEffectiveInstanceAssociations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeEffectiveInstanceAssociations service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidInstanceIdException">
        /// The following problems can cause this exception:
        /// 
        ///  
        /// <para>
        /// You do not have permission to access the instance.
        /// </para>
        ///  
        /// <para>
        /// SSM Agent is not running. Verify that SSM Agent is running.
        /// </para>
        ///  
        /// <para>
        /// SSM Agent is not registered with the SSM endpoint. Try reinstalling SSM Agent.
        /// </para>
        ///  
        /// <para>
        /// The instance is not in valid state. Valid states are: Running, Pending, Stopped, Stopping.
        /// Invalid states are: Shutting-down and Terminated.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidNextTokenException">
        /// The specified token is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribeEffectiveInstanceAssociations">REST API Reference for DescribeEffectiveInstanceAssociations Operation</seealso>
        public virtual Task<DescribeEffectiveInstanceAssociationsResponse> DescribeEffectiveInstanceAssociationsAsync(DescribeEffectiveInstanceAssociationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeEffectiveInstanceAssociationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEffectiveInstanceAssociationsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeEffectiveInstanceAssociationsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeEffectivePatchesForPatchBaseline

        internal virtual DescribeEffectivePatchesForPatchBaselineResponse DescribeEffectivePatchesForPatchBaseline(DescribeEffectivePatchesForPatchBaselineRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeEffectivePatchesForPatchBaselineRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEffectivePatchesForPatchBaselineResponseUnmarshaller.Instance;

            return Invoke<DescribeEffectivePatchesForPatchBaselineResponse>(request, options);
        }



        /// <summary>
        /// Retrieves the current effective patches (the patch and the approval state) for the
        /// specified patch baseline. Note that this API applies only to Windows patch baselines.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEffectivePatchesForPatchBaseline service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeEffectivePatchesForPatchBaseline service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.DoesNotExistException">
        /// Error returned when the ID specified for a resource, such as a maintenance window
        /// or Patch baseline, doesn't exist.
        /// 
        ///  
        /// <para>
        /// For information about resource quotas in Systems Manager, see <a href="http://docs.aws.amazon.com/general/latest/gr/ssm.html#limits_ssm">Systems
        /// Manager service quotas</a> in the <i>AWS General Reference</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidResourceIdException">
        /// The resource ID is not valid. Verify that you entered the correct ID and try again.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.UnsupportedOperatingSystemException">
        /// The operating systems you specified is not supported, or the operation is not supported
        /// for the operating system.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribeEffectivePatchesForPatchBaseline">REST API Reference for DescribeEffectivePatchesForPatchBaseline Operation</seealso>
        public virtual Task<DescribeEffectivePatchesForPatchBaselineResponse> DescribeEffectivePatchesForPatchBaselineAsync(DescribeEffectivePatchesForPatchBaselineRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeEffectivePatchesForPatchBaselineRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEffectivePatchesForPatchBaselineResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeEffectivePatchesForPatchBaselineResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeInstanceAssociationsStatus

        internal virtual DescribeInstanceAssociationsStatusResponse DescribeInstanceAssociationsStatus(DescribeInstanceAssociationsStatusRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeInstanceAssociationsStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeInstanceAssociationsStatusResponseUnmarshaller.Instance;

            return Invoke<DescribeInstanceAssociationsStatusResponse>(request, options);
        }



        /// <summary>
        /// The status of the associations for the instance(s).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeInstanceAssociationsStatus service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeInstanceAssociationsStatus service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidInstanceIdException">
        /// The following problems can cause this exception:
        /// 
        ///  
        /// <para>
        /// You do not have permission to access the instance.
        /// </para>
        ///  
        /// <para>
        /// SSM Agent is not running. Verify that SSM Agent is running.
        /// </para>
        ///  
        /// <para>
        /// SSM Agent is not registered with the SSM endpoint. Try reinstalling SSM Agent.
        /// </para>
        ///  
        /// <para>
        /// The instance is not in valid state. Valid states are: Running, Pending, Stopped, Stopping.
        /// Invalid states are: Shutting-down and Terminated.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidNextTokenException">
        /// The specified token is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribeInstanceAssociationsStatus">REST API Reference for DescribeInstanceAssociationsStatus Operation</seealso>
        public virtual Task<DescribeInstanceAssociationsStatusResponse> DescribeInstanceAssociationsStatusAsync(DescribeInstanceAssociationsStatusRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeInstanceAssociationsStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeInstanceAssociationsStatusResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeInstanceAssociationsStatusResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeInstanceInformation

        internal virtual DescribeInstanceInformationResponse DescribeInstanceInformation()
        {
            return DescribeInstanceInformation(new DescribeInstanceInformationRequest());
        }
        internal virtual DescribeInstanceInformationResponse DescribeInstanceInformation(DescribeInstanceInformationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeInstanceInformationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeInstanceInformationResponseUnmarshaller.Instance;

            return Invoke<DescribeInstanceInformationResponse>(request, options);
        }


        /// <summary>
        /// Describes one or more of your instances, including information about the operating
        /// system platform, the version of SSM Agent installed on the instance, instance status,
        /// and so on.
        /// 
        ///  
        /// <para>
        /// If you specify one or more instance IDs, it returns information for those instances.
        /// If you do not specify instance IDs, it returns information for all your instances.
        /// If you specify an instance ID that is not valid or an instance that you do not own,
        /// you receive an error.
        /// </para>
        ///  <note> 
        /// <para>
        /// The IamRole field for this API action is the Amazon Identity and Access Management
        /// (IAM) role assigned to on-premises instances. This call does not return the IAM role
        /// for EC2 instances.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeInstanceInformation service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidFilterKeyException">
        /// The specified key is not valid.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidInstanceIdException">
        /// The following problems can cause this exception:
        /// 
        ///  
        /// <para>
        /// You do not have permission to access the instance.
        /// </para>
        ///  
        /// <para>
        /// SSM Agent is not running. Verify that SSM Agent is running.
        /// </para>
        ///  
        /// <para>
        /// SSM Agent is not registered with the SSM endpoint. Try reinstalling SSM Agent.
        /// </para>
        ///  
        /// <para>
        /// The instance is not in valid state. Valid states are: Running, Pending, Stopped, Stopping.
        /// Invalid states are: Shutting-down and Terminated.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidInstanceInformationFilterValueException">
        /// The specified filter value is not valid.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidNextTokenException">
        /// The specified token is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribeInstanceInformation">REST API Reference for DescribeInstanceInformation Operation</seealso>
        public virtual Task<DescribeInstanceInformationResponse> DescribeInstanceInformationAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return DescribeInstanceInformationAsync(new DescribeInstanceInformationRequest(), cancellationToken);
        }



        /// <summary>
        /// Describes one or more of your instances, including information about the operating
        /// system platform, the version of SSM Agent installed on the instance, instance status,
        /// and so on.
        /// 
        ///  
        /// <para>
        /// If you specify one or more instance IDs, it returns information for those instances.
        /// If you do not specify instance IDs, it returns information for all your instances.
        /// If you specify an instance ID that is not valid or an instance that you do not own,
        /// you receive an error.
        /// </para>
        ///  <note> 
        /// <para>
        /// The IamRole field for this API action is the Amazon Identity and Access Management
        /// (IAM) role assigned to on-premises instances. This call does not return the IAM role
        /// for EC2 instances.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeInstanceInformation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeInstanceInformation service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidFilterKeyException">
        /// The specified key is not valid.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidInstanceIdException">
        /// The following problems can cause this exception:
        /// 
        ///  
        /// <para>
        /// You do not have permission to access the instance.
        /// </para>
        ///  
        /// <para>
        /// SSM Agent is not running. Verify that SSM Agent is running.
        /// </para>
        ///  
        /// <para>
        /// SSM Agent is not registered with the SSM endpoint. Try reinstalling SSM Agent.
        /// </para>
        ///  
        /// <para>
        /// The instance is not in valid state. Valid states are: Running, Pending, Stopped, Stopping.
        /// Invalid states are: Shutting-down and Terminated.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidInstanceInformationFilterValueException">
        /// The specified filter value is not valid.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidNextTokenException">
        /// The specified token is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribeInstanceInformation">REST API Reference for DescribeInstanceInformation Operation</seealso>
        public virtual Task<DescribeInstanceInformationResponse> DescribeInstanceInformationAsync(DescribeInstanceInformationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeInstanceInformationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeInstanceInformationResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeInstanceInformationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeInstancePatches

        internal virtual DescribeInstancePatchesResponse DescribeInstancePatches(DescribeInstancePatchesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeInstancePatchesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeInstancePatchesResponseUnmarshaller.Instance;

            return Invoke<DescribeInstancePatchesResponse>(request, options);
        }



        /// <summary>
        /// Retrieves information about the patches on the specified instance and their state
        /// relative to the patch baseline being used for the instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeInstancePatches service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeInstancePatches service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidFilterException">
        /// The filter name is not valid. Verify the you entered the correct name and try again.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidInstanceIdException">
        /// The following problems can cause this exception:
        /// 
        ///  
        /// <para>
        /// You do not have permission to access the instance.
        /// </para>
        ///  
        /// <para>
        /// SSM Agent is not running. Verify that SSM Agent is running.
        /// </para>
        ///  
        /// <para>
        /// SSM Agent is not registered with the SSM endpoint. Try reinstalling SSM Agent.
        /// </para>
        ///  
        /// <para>
        /// The instance is not in valid state. Valid states are: Running, Pending, Stopped, Stopping.
        /// Invalid states are: Shutting-down and Terminated.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidNextTokenException">
        /// The specified token is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribeInstancePatches">REST API Reference for DescribeInstancePatches Operation</seealso>
        public virtual Task<DescribeInstancePatchesResponse> DescribeInstancePatchesAsync(DescribeInstancePatchesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeInstancePatchesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeInstancePatchesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeInstancePatchesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeInstancePatchStates

        internal virtual DescribeInstancePatchStatesResponse DescribeInstancePatchStates(DescribeInstancePatchStatesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeInstancePatchStatesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeInstancePatchStatesResponseUnmarshaller.Instance;

            return Invoke<DescribeInstancePatchStatesResponse>(request, options);
        }



        /// <summary>
        /// Retrieves the high-level patch state of one or more instances.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeInstancePatchStates service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeInstancePatchStates service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidNextTokenException">
        /// The specified token is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribeInstancePatchStates">REST API Reference for DescribeInstancePatchStates Operation</seealso>
        public virtual Task<DescribeInstancePatchStatesResponse> DescribeInstancePatchStatesAsync(DescribeInstancePatchStatesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeInstancePatchStatesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeInstancePatchStatesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeInstancePatchStatesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeInstancePatchStatesForPatchGroup

        internal virtual DescribeInstancePatchStatesForPatchGroupResponse DescribeInstancePatchStatesForPatchGroup(DescribeInstancePatchStatesForPatchGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeInstancePatchStatesForPatchGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeInstancePatchStatesForPatchGroupResponseUnmarshaller.Instance;

            return Invoke<DescribeInstancePatchStatesForPatchGroupResponse>(request, options);
        }



        /// <summary>
        /// Retrieves the high-level patch state for the instances in the specified patch group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeInstancePatchStatesForPatchGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeInstancePatchStatesForPatchGroup service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidFilterException">
        /// The filter name is not valid. Verify the you entered the correct name and try again.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidNextTokenException">
        /// The specified token is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribeInstancePatchStatesForPatchGroup">REST API Reference for DescribeInstancePatchStatesForPatchGroup Operation</seealso>
        public virtual Task<DescribeInstancePatchStatesForPatchGroupResponse> DescribeInstancePatchStatesForPatchGroupAsync(DescribeInstancePatchStatesForPatchGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeInstancePatchStatesForPatchGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeInstancePatchStatesForPatchGroupResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeInstancePatchStatesForPatchGroupResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeInventoryDeletions

        internal virtual DescribeInventoryDeletionsResponse DescribeInventoryDeletions(DescribeInventoryDeletionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeInventoryDeletionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeInventoryDeletionsResponseUnmarshaller.Instance;

            return Invoke<DescribeInventoryDeletionsResponse>(request, options);
        }



        /// <summary>
        /// Describes a specific delete inventory operation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeInventoryDeletions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeInventoryDeletions service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidDeletionIdException">
        /// The ID specified for the delete operation does not exist or is not valid. Verify the
        /// ID and try again.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidNextTokenException">
        /// The specified token is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribeInventoryDeletions">REST API Reference for DescribeInventoryDeletions Operation</seealso>
        public virtual Task<DescribeInventoryDeletionsResponse> DescribeInventoryDeletionsAsync(DescribeInventoryDeletionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeInventoryDeletionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeInventoryDeletionsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeInventoryDeletionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeMaintenanceWindowExecutions

        internal virtual DescribeMaintenanceWindowExecutionsResponse DescribeMaintenanceWindowExecutions(DescribeMaintenanceWindowExecutionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeMaintenanceWindowExecutionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeMaintenanceWindowExecutionsResponseUnmarshaller.Instance;

            return Invoke<DescribeMaintenanceWindowExecutionsResponse>(request, options);
        }



        /// <summary>
        /// Lists the executions of a maintenance window. This includes information about when
        /// the maintenance window was scheduled to be active, and information about tasks registered
        /// and run with the maintenance window.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeMaintenanceWindowExecutions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeMaintenanceWindowExecutions service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribeMaintenanceWindowExecutions">REST API Reference for DescribeMaintenanceWindowExecutions Operation</seealso>
        public virtual Task<DescribeMaintenanceWindowExecutionsResponse> DescribeMaintenanceWindowExecutionsAsync(DescribeMaintenanceWindowExecutionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeMaintenanceWindowExecutionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeMaintenanceWindowExecutionsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeMaintenanceWindowExecutionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeMaintenanceWindowExecutionTaskInvocations

        internal virtual DescribeMaintenanceWindowExecutionTaskInvocationsResponse DescribeMaintenanceWindowExecutionTaskInvocations(DescribeMaintenanceWindowExecutionTaskInvocationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeMaintenanceWindowExecutionTaskInvocationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeMaintenanceWindowExecutionTaskInvocationsResponseUnmarshaller.Instance;

            return Invoke<DescribeMaintenanceWindowExecutionTaskInvocationsResponse>(request, options);
        }



        /// <summary>
        /// Retrieves the individual task executions (one per target) for a particular task run
        /// as part of a maintenance window execution.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeMaintenanceWindowExecutionTaskInvocations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeMaintenanceWindowExecutionTaskInvocations service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.DoesNotExistException">
        /// Error returned when the ID specified for a resource, such as a maintenance window
        /// or Patch baseline, doesn't exist.
        /// 
        ///  
        /// <para>
        /// For information about resource quotas in Systems Manager, see <a href="http://docs.aws.amazon.com/general/latest/gr/ssm.html#limits_ssm">Systems
        /// Manager service quotas</a> in the <i>AWS General Reference</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribeMaintenanceWindowExecutionTaskInvocations">REST API Reference for DescribeMaintenanceWindowExecutionTaskInvocations Operation</seealso>
        public virtual Task<DescribeMaintenanceWindowExecutionTaskInvocationsResponse> DescribeMaintenanceWindowExecutionTaskInvocationsAsync(DescribeMaintenanceWindowExecutionTaskInvocationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeMaintenanceWindowExecutionTaskInvocationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeMaintenanceWindowExecutionTaskInvocationsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeMaintenanceWindowExecutionTaskInvocationsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeMaintenanceWindowExecutionTasks

        internal virtual DescribeMaintenanceWindowExecutionTasksResponse DescribeMaintenanceWindowExecutionTasks(DescribeMaintenanceWindowExecutionTasksRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeMaintenanceWindowExecutionTasksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeMaintenanceWindowExecutionTasksResponseUnmarshaller.Instance;

            return Invoke<DescribeMaintenanceWindowExecutionTasksResponse>(request, options);
        }



        /// <summary>
        /// For a given maintenance window execution, lists the tasks that were run.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeMaintenanceWindowExecutionTasks service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeMaintenanceWindowExecutionTasks service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.DoesNotExistException">
        /// Error returned when the ID specified for a resource, such as a maintenance window
        /// or Patch baseline, doesn't exist.
        /// 
        ///  
        /// <para>
        /// For information about resource quotas in Systems Manager, see <a href="http://docs.aws.amazon.com/general/latest/gr/ssm.html#limits_ssm">Systems
        /// Manager service quotas</a> in the <i>AWS General Reference</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribeMaintenanceWindowExecutionTasks">REST API Reference for DescribeMaintenanceWindowExecutionTasks Operation</seealso>
        public virtual Task<DescribeMaintenanceWindowExecutionTasksResponse> DescribeMaintenanceWindowExecutionTasksAsync(DescribeMaintenanceWindowExecutionTasksRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeMaintenanceWindowExecutionTasksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeMaintenanceWindowExecutionTasksResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeMaintenanceWindowExecutionTasksResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeMaintenanceWindows

        internal virtual DescribeMaintenanceWindowsResponse DescribeMaintenanceWindows(DescribeMaintenanceWindowsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeMaintenanceWindowsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeMaintenanceWindowsResponseUnmarshaller.Instance;

            return Invoke<DescribeMaintenanceWindowsResponse>(request, options);
        }



        /// <summary>
        /// Retrieves the maintenance windows in an AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeMaintenanceWindows service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeMaintenanceWindows service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribeMaintenanceWindows">REST API Reference for DescribeMaintenanceWindows Operation</seealso>
        public virtual Task<DescribeMaintenanceWindowsResponse> DescribeMaintenanceWindowsAsync(DescribeMaintenanceWindowsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeMaintenanceWindowsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeMaintenanceWindowsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeMaintenanceWindowsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeMaintenanceWindowSchedule

        internal virtual DescribeMaintenanceWindowScheduleResponse DescribeMaintenanceWindowSchedule(DescribeMaintenanceWindowScheduleRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeMaintenanceWindowScheduleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeMaintenanceWindowScheduleResponseUnmarshaller.Instance;

            return Invoke<DescribeMaintenanceWindowScheduleResponse>(request, options);
        }



        /// <summary>
        /// Retrieves information about upcoming executions of a maintenance window.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeMaintenanceWindowSchedule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeMaintenanceWindowSchedule service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.DoesNotExistException">
        /// Error returned when the ID specified for a resource, such as a maintenance window
        /// or Patch baseline, doesn't exist.
        /// 
        ///  
        /// <para>
        /// For information about resource quotas in Systems Manager, see <a href="http://docs.aws.amazon.com/general/latest/gr/ssm.html#limits_ssm">Systems
        /// Manager service quotas</a> in the <i>AWS General Reference</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribeMaintenanceWindowSchedule">REST API Reference for DescribeMaintenanceWindowSchedule Operation</seealso>
        public virtual Task<DescribeMaintenanceWindowScheduleResponse> DescribeMaintenanceWindowScheduleAsync(DescribeMaintenanceWindowScheduleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeMaintenanceWindowScheduleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeMaintenanceWindowScheduleResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeMaintenanceWindowScheduleResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeMaintenanceWindowsForTarget

        internal virtual DescribeMaintenanceWindowsForTargetResponse DescribeMaintenanceWindowsForTarget(DescribeMaintenanceWindowsForTargetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeMaintenanceWindowsForTargetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeMaintenanceWindowsForTargetResponseUnmarshaller.Instance;

            return Invoke<DescribeMaintenanceWindowsForTargetResponse>(request, options);
        }



        /// <summary>
        /// Retrieves information about the maintenance window targets or tasks that an instance
        /// is associated with.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeMaintenanceWindowsForTarget service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeMaintenanceWindowsForTarget service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribeMaintenanceWindowsForTarget">REST API Reference for DescribeMaintenanceWindowsForTarget Operation</seealso>
        public virtual Task<DescribeMaintenanceWindowsForTargetResponse> DescribeMaintenanceWindowsForTargetAsync(DescribeMaintenanceWindowsForTargetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeMaintenanceWindowsForTargetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeMaintenanceWindowsForTargetResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeMaintenanceWindowsForTargetResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeMaintenanceWindowTargets

        internal virtual DescribeMaintenanceWindowTargetsResponse DescribeMaintenanceWindowTargets(DescribeMaintenanceWindowTargetsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeMaintenanceWindowTargetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeMaintenanceWindowTargetsResponseUnmarshaller.Instance;

            return Invoke<DescribeMaintenanceWindowTargetsResponse>(request, options);
        }



        /// <summary>
        /// Lists the targets registered with the maintenance window.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeMaintenanceWindowTargets service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeMaintenanceWindowTargets service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.DoesNotExistException">
        /// Error returned when the ID specified for a resource, such as a maintenance window
        /// or Patch baseline, doesn't exist.
        /// 
        ///  
        /// <para>
        /// For information about resource quotas in Systems Manager, see <a href="http://docs.aws.amazon.com/general/latest/gr/ssm.html#limits_ssm">Systems
        /// Manager service quotas</a> in the <i>AWS General Reference</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribeMaintenanceWindowTargets">REST API Reference for DescribeMaintenanceWindowTargets Operation</seealso>
        public virtual Task<DescribeMaintenanceWindowTargetsResponse> DescribeMaintenanceWindowTargetsAsync(DescribeMaintenanceWindowTargetsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeMaintenanceWindowTargetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeMaintenanceWindowTargetsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeMaintenanceWindowTargetsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeMaintenanceWindowTasks

        internal virtual DescribeMaintenanceWindowTasksResponse DescribeMaintenanceWindowTasks(DescribeMaintenanceWindowTasksRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeMaintenanceWindowTasksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeMaintenanceWindowTasksResponseUnmarshaller.Instance;

            return Invoke<DescribeMaintenanceWindowTasksResponse>(request, options);
        }



        /// <summary>
        /// Lists the tasks in a maintenance window.
        /// 
        ///  <note> 
        /// <para>
        /// For maintenance window tasks without a specified target, you cannot supply values
        /// for <code>--max-errors</code> and <code>--max-concurrency</code>. Instead, the system
        /// inserts a placeholder value of <code>1</code>, which may be reported in the response
        /// to this command. These values do not affect the running of your task and can be ignored.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeMaintenanceWindowTasks service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeMaintenanceWindowTasks service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.DoesNotExistException">
        /// Error returned when the ID specified for a resource, such as a maintenance window
        /// or Patch baseline, doesn't exist.
        /// 
        ///  
        /// <para>
        /// For information about resource quotas in Systems Manager, see <a href="http://docs.aws.amazon.com/general/latest/gr/ssm.html#limits_ssm">Systems
        /// Manager service quotas</a> in the <i>AWS General Reference</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribeMaintenanceWindowTasks">REST API Reference for DescribeMaintenanceWindowTasks Operation</seealso>
        public virtual Task<DescribeMaintenanceWindowTasksResponse> DescribeMaintenanceWindowTasksAsync(DescribeMaintenanceWindowTasksRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeMaintenanceWindowTasksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeMaintenanceWindowTasksResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeMaintenanceWindowTasksResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeOpsItems

        internal virtual DescribeOpsItemsResponse DescribeOpsItems(DescribeOpsItemsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeOpsItemsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeOpsItemsResponseUnmarshaller.Instance;

            return Invoke<DescribeOpsItemsResponse>(request, options);
        }



        /// <summary>
        /// Query a set of OpsItems. You must have permission in AWS Identity and Access Management
        /// (IAM) to query a list of OpsItems. For more information, see <a href="https://docs.aws.amazon.com/systems-manager/latest/userguide/OpsCenter-getting-started.html">Getting
        /// started with OpsCenter</a> in the <i>AWS Systems Manager User Guide</i>.
        /// 
        ///  
        /// <para>
        /// Operations engineers and IT professionals use OpsCenter to view, investigate, and
        /// remediate operational issues impacting the performance and health of their AWS resources.
        /// For more information, see <a href="https://docs.aws.amazon.com/systems-manager/latest/userguide/OpsCenter.html">AWS
        /// Systems Manager OpsCenter</a> in the <i>AWS Systems Manager User Guide</i>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeOpsItems service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeOpsItems service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribeOpsItems">REST API Reference for DescribeOpsItems Operation</seealso>
        public virtual Task<DescribeOpsItemsResponse> DescribeOpsItemsAsync(DescribeOpsItemsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeOpsItemsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeOpsItemsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeOpsItemsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeParameters

        internal virtual DescribeParametersResponse DescribeParameters(DescribeParametersRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeParametersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeParametersResponseUnmarshaller.Instance;

            return Invoke<DescribeParametersResponse>(request, options);
        }



        /// <summary>
        /// Get information about a parameter.
        /// 
        ///  <note> 
        /// <para>
        /// Request results are returned on a best-effort basis. If you specify <code>MaxResults</code>
        /// in the request, the response includes information up to the limit specified. The number
        /// of items returned, however, can be between zero and the value of <code>MaxResults</code>.
        /// If the service reaches an internal limit while processing the results, it stops the
        /// operation and returns the matching values up to that point and a <code>NextToken</code>.
        /// You can specify the <code>NextToken</code> in a subsequent call to get the next set
        /// of results.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeParameters service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeParameters service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidFilterKeyException">
        /// The specified key is not valid.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidFilterOptionException">
        /// The specified filter option is not valid. Valid options are Equals and BeginsWith.
        /// For Path filter, valid options are Recursive and OneLevel.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidFilterValueException">
        /// The filter value is not valid. Verify the value and try again.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidNextTokenException">
        /// The specified token is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribeParameters">REST API Reference for DescribeParameters Operation</seealso>
        public virtual Task<DescribeParametersResponse> DescribeParametersAsync(DescribeParametersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeParametersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeParametersResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeParametersResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribePatchBaselines

        internal virtual DescribePatchBaselinesResponse DescribePatchBaselines(DescribePatchBaselinesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribePatchBaselinesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribePatchBaselinesResponseUnmarshaller.Instance;

            return Invoke<DescribePatchBaselinesResponse>(request, options);
        }



        /// <summary>
        /// Lists the patch baselines in your AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribePatchBaselines service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribePatchBaselines service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribePatchBaselines">REST API Reference for DescribePatchBaselines Operation</seealso>
        public virtual Task<DescribePatchBaselinesResponse> DescribePatchBaselinesAsync(DescribePatchBaselinesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribePatchBaselinesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribePatchBaselinesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribePatchBaselinesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribePatchGroups

        internal virtual DescribePatchGroupsResponse DescribePatchGroups(DescribePatchGroupsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribePatchGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribePatchGroupsResponseUnmarshaller.Instance;

            return Invoke<DescribePatchGroupsResponse>(request, options);
        }



        /// <summary>
        /// Lists all patch groups that have been registered with patch baselines.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribePatchGroups service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribePatchGroups service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribePatchGroups">REST API Reference for DescribePatchGroups Operation</seealso>
        public virtual Task<DescribePatchGroupsResponse> DescribePatchGroupsAsync(DescribePatchGroupsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribePatchGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribePatchGroupsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribePatchGroupsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribePatchGroupState

        internal virtual DescribePatchGroupStateResponse DescribePatchGroupState(DescribePatchGroupStateRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribePatchGroupStateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribePatchGroupStateResponseUnmarshaller.Instance;

            return Invoke<DescribePatchGroupStateResponse>(request, options);
        }



        /// <summary>
        /// Returns high-level aggregated patch compliance state for a patch group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribePatchGroupState service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribePatchGroupState service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidNextTokenException">
        /// The specified token is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribePatchGroupState">REST API Reference for DescribePatchGroupState Operation</seealso>
        public virtual Task<DescribePatchGroupStateResponse> DescribePatchGroupStateAsync(DescribePatchGroupStateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribePatchGroupStateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribePatchGroupStateResponseUnmarshaller.Instance;

            return InvokeAsync<DescribePatchGroupStateResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribePatchProperties

        internal virtual DescribePatchPropertiesResponse DescribePatchProperties(DescribePatchPropertiesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribePatchPropertiesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribePatchPropertiesResponseUnmarshaller.Instance;

            return Invoke<DescribePatchPropertiesResponse>(request, options);
        }



        /// <summary>
        /// Lists the properties of available patches organized by product, product family, classification,
        /// severity, and other properties of available patches. You can use the reported properties
        /// in the filters you specify in requests for actions such as <a>CreatePatchBaseline</a>,
        /// <a>UpdatePatchBaseline</a>, <a>DescribeAvailablePatches</a>, and <a>DescribePatchBaselines</a>.
        /// 
        ///  
        /// <para>
        /// The following section lists the properties that can be used in filters for each major
        /// operating system type:
        /// </para>
        ///  <dl> <dt>AMAZON_LINUX</dt> <dd> 
        /// <para>
        /// Valid properties: PRODUCT, CLASSIFICATION, SEVERITY
        /// </para>
        ///  </dd> <dt>AMAZON_LINUX_2</dt> <dd> 
        /// <para>
        /// Valid properties: PRODUCT, CLASSIFICATION, SEVERITY
        /// </para>
        ///  </dd> <dt>CENTOS</dt> <dd> 
        /// <para>
        /// Valid properties: PRODUCT, CLASSIFICATION, SEVERITY
        /// </para>
        ///  </dd> <dt>DEBIAN</dt> <dd> 
        /// <para>
        /// Valid properties: PRODUCT, PRIORITY
        /// </para>
        ///  </dd> <dt>MACOS</dt> <dd> 
        /// <para>
        /// Valid properties: PRODUCT, CLASSIFICATION
        /// </para>
        ///  </dd> <dt>ORACLE_LINUX</dt> <dd> 
        /// <para>
        /// Valid properties: PRODUCT, CLASSIFICATION, SEVERITY
        /// </para>
        ///  </dd> <dt>REDHAT_ENTERPRISE_LINUX</dt> <dd> 
        /// <para>
        /// Valid properties: PRODUCT, CLASSIFICATION, SEVERITY
        /// </para>
        ///  </dd> <dt>SUSE</dt> <dd> 
        /// <para>
        /// Valid properties: PRODUCT, CLASSIFICATION, SEVERITY
        /// </para>
        ///  </dd> <dt>UBUNTU</dt> <dd> 
        /// <para>
        /// Valid properties: PRODUCT, PRIORITY
        /// </para>
        ///  </dd> <dt>WINDOWS</dt> <dd> 
        /// <para>
        /// Valid properties: PRODUCT, PRODUCT_FAMILY, CLASSIFICATION, MSRC_SEVERITY
        /// </para>
        ///  </dd> </dl>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribePatchProperties service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribePatchProperties service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribePatchProperties">REST API Reference for DescribePatchProperties Operation</seealso>
        public virtual Task<DescribePatchPropertiesResponse> DescribePatchPropertiesAsync(DescribePatchPropertiesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribePatchPropertiesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribePatchPropertiesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribePatchPropertiesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeSessions

        internal virtual DescribeSessionsResponse DescribeSessions(DescribeSessionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeSessionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeSessionsResponseUnmarshaller.Instance;

            return Invoke<DescribeSessionsResponse>(request, options);
        }



        /// <summary>
        /// Retrieves a list of all active sessions (both connected and disconnected) or terminated
        /// sessions from the past 30 days.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSessions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeSessions service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidFilterKeyException">
        /// The specified key is not valid.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidNextTokenException">
        /// The specified token is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribeSessions">REST API Reference for DescribeSessions Operation</seealso>
        public virtual Task<DescribeSessionsResponse> DescribeSessionsAsync(DescribeSessionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeSessionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeSessionsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeSessionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetAutomationExecution

        internal virtual GetAutomationExecutionResponse GetAutomationExecution(GetAutomationExecutionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAutomationExecutionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAutomationExecutionResponseUnmarshaller.Instance;

            return Invoke<GetAutomationExecutionResponse>(request, options);
        }



        /// <summary>
        /// Get detailed information about a particular Automation execution.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAutomationExecution service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetAutomationExecution service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.AutomationExecutionNotFoundException">
        /// There is no automation execution information for the requested automation execution
        /// ID.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/GetAutomationExecution">REST API Reference for GetAutomationExecution Operation</seealso>
        public virtual Task<GetAutomationExecutionResponse> GetAutomationExecutionAsync(GetAutomationExecutionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAutomationExecutionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAutomationExecutionResponseUnmarshaller.Instance;

            return InvokeAsync<GetAutomationExecutionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetCalendarState

        internal virtual GetCalendarStateResponse GetCalendarState(GetCalendarStateRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetCalendarStateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCalendarStateResponseUnmarshaller.Instance;

            return Invoke<GetCalendarStateResponse>(request, options);
        }



        /// <summary>
        /// Gets the state of the AWS Systems Manager Change Calendar at an optional, specified
        /// time. If you specify a time, <code>GetCalendarState</code> returns the state of the
        /// calendar at a specific time, and returns the next time that the Change Calendar state
        /// will transition. If you do not specify a time, <code>GetCalendarState</code> assumes
        /// the current time. Change Calendar entries have two possible states: <code>OPEN</code>
        /// or <code>CLOSED</code>.
        /// 
        ///  
        /// <para>
        /// If you specify more than one calendar in a request, the command returns the status
        /// of <code>OPEN</code> only if all calendars in the request are open. If one or more
        /// calendars in the request are closed, the status returned is <code>CLOSED</code>.
        /// </para>
        ///  
        /// <para>
        /// For more information about Systems Manager Change Calendar, see <a href="https://docs.aws.amazon.com/systems-manager/latest/userguide/systems-manager-change-calendar.html">AWS
        /// Systems Manager Change Calendar</a> in the <i>AWS Systems Manager User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCalendarState service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetCalendarState service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidDocumentException">
        /// The specified document does not exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidDocumentTypeException">
        /// The document type is not valid. Valid document types are described in the <code>DocumentType</code>
        /// property.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.UnsupportedCalendarException">
        /// The calendar entry contained in the specified Systems Manager document is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/GetCalendarState">REST API Reference for GetCalendarState Operation</seealso>
        public virtual Task<GetCalendarStateResponse> GetCalendarStateAsync(GetCalendarStateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetCalendarStateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCalendarStateResponseUnmarshaller.Instance;

            return InvokeAsync<GetCalendarStateResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetCommandInvocation

        internal virtual GetCommandInvocationResponse GetCommandInvocation(GetCommandInvocationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetCommandInvocationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCommandInvocationResponseUnmarshaller.Instance;

            return Invoke<GetCommandInvocationResponse>(request, options);
        }



        /// <summary>
        /// Returns detailed information about command execution for an invocation or plugin.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCommandInvocation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetCommandInvocation service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidCommandIdException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidInstanceIdException">
        /// The following problems can cause this exception:
        /// 
        ///  
        /// <para>
        /// You do not have permission to access the instance.
        /// </para>
        ///  
        /// <para>
        /// SSM Agent is not running. Verify that SSM Agent is running.
        /// </para>
        ///  
        /// <para>
        /// SSM Agent is not registered with the SSM endpoint. Try reinstalling SSM Agent.
        /// </para>
        ///  
        /// <para>
        /// The instance is not in valid state. Valid states are: Running, Pending, Stopped, Stopping.
        /// Invalid states are: Shutting-down and Terminated.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidPluginNameException">
        /// The plugin name is not valid.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvocationDoesNotExistException">
        /// The command ID and instance ID you specified did not match any invocations. Verify
        /// the command ID and the instance ID and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/GetCommandInvocation">REST API Reference for GetCommandInvocation Operation</seealso>
        public virtual Task<GetCommandInvocationResponse> GetCommandInvocationAsync(GetCommandInvocationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetCommandInvocationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCommandInvocationResponseUnmarshaller.Instance;

            return InvokeAsync<GetCommandInvocationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetConnectionStatus

        internal virtual GetConnectionStatusResponse GetConnectionStatus(GetConnectionStatusRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetConnectionStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetConnectionStatusResponseUnmarshaller.Instance;

            return Invoke<GetConnectionStatusResponse>(request, options);
        }



        /// <summary>
        /// Retrieves the Session Manager connection status for an instance to determine whether
        /// it is running and ready to receive Session Manager connections.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetConnectionStatus service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetConnectionStatus service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/GetConnectionStatus">REST API Reference for GetConnectionStatus Operation</seealso>
        public virtual Task<GetConnectionStatusResponse> GetConnectionStatusAsync(GetConnectionStatusRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetConnectionStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetConnectionStatusResponseUnmarshaller.Instance;

            return InvokeAsync<GetConnectionStatusResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetDefaultPatchBaseline

        internal virtual GetDefaultPatchBaselineResponse GetDefaultPatchBaseline(GetDefaultPatchBaselineRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDefaultPatchBaselineRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDefaultPatchBaselineResponseUnmarshaller.Instance;

            return Invoke<GetDefaultPatchBaselineResponse>(request, options);
        }



        /// <summary>
        /// Retrieves the default patch baseline. Note that Systems Manager supports creating
        /// multiple default patch baselines. For example, you can create a default patch baseline
        /// for each operating system.
        /// 
        ///  
        /// <para>
        /// If you do not specify an operating system value, the default patch baseline for Windows
        /// is returned.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDefaultPatchBaseline service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetDefaultPatchBaseline service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/GetDefaultPatchBaseline">REST API Reference for GetDefaultPatchBaseline Operation</seealso>
        public virtual Task<GetDefaultPatchBaselineResponse> GetDefaultPatchBaselineAsync(GetDefaultPatchBaselineRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDefaultPatchBaselineRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDefaultPatchBaselineResponseUnmarshaller.Instance;

            return InvokeAsync<GetDefaultPatchBaselineResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetDeployablePatchSnapshotForInstance

        internal virtual GetDeployablePatchSnapshotForInstanceResponse GetDeployablePatchSnapshotForInstance(GetDeployablePatchSnapshotForInstanceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDeployablePatchSnapshotForInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDeployablePatchSnapshotForInstanceResponseUnmarshaller.Instance;

            return Invoke<GetDeployablePatchSnapshotForInstanceResponse>(request, options);
        }



        /// <summary>
        /// Retrieves the current snapshot for the patch baseline the instance uses. This API
        /// is primarily used by the AWS-RunPatchBaseline Systems Manager document.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDeployablePatchSnapshotForInstance service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetDeployablePatchSnapshotForInstance service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.UnsupportedFeatureRequiredException">
        /// Microsoft application patching is only available on EC2 instances and advanced instances.
        /// To patch Microsoft applications on on-premises servers and VMs, you must enable advanced
        /// instances. For more information, see <a href="https://docs.aws.amazon.com/systems-manager/latest/userguide/systems-manager-managedinstances-advanced.html">Using
        /// the advanced-instances tier</a> in the <i>AWS Systems Manager User Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.UnsupportedOperatingSystemException">
        /// The operating systems you specified is not supported, or the operation is not supported
        /// for the operating system.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/GetDeployablePatchSnapshotForInstance">REST API Reference for GetDeployablePatchSnapshotForInstance Operation</seealso>
        public virtual Task<GetDeployablePatchSnapshotForInstanceResponse> GetDeployablePatchSnapshotForInstanceAsync(GetDeployablePatchSnapshotForInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDeployablePatchSnapshotForInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDeployablePatchSnapshotForInstanceResponseUnmarshaller.Instance;

            return InvokeAsync<GetDeployablePatchSnapshotForInstanceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetDocument

        internal virtual GetDocumentResponse GetDocument(GetDocumentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDocumentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDocumentResponseUnmarshaller.Instance;

            return Invoke<GetDocumentResponse>(request, options);
        }


        /// <summary>
        /// Gets the contents of the specified Systems Manager document.
        /// </summary>
        /// <param name="name">The name of the Systems Manager document.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetDocument service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidDocumentException">
        /// The specified document does not exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidDocumentVersionException">
        /// The document version is not valid or does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/GetDocument">REST API Reference for GetDocument Operation</seealso>
        public virtual Task<GetDocumentResponse> GetDocumentAsync(string name, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new GetDocumentRequest();
            request.Name = name;
            return GetDocumentAsync(request, cancellationToken);
        }



        /// <summary>
        /// Gets the contents of the specified Systems Manager document.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDocument service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetDocument service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidDocumentException">
        /// The specified document does not exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidDocumentVersionException">
        /// The document version is not valid or does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/GetDocument">REST API Reference for GetDocument Operation</seealso>
        public virtual Task<GetDocumentResponse> GetDocumentAsync(GetDocumentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDocumentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDocumentResponseUnmarshaller.Instance;

            return InvokeAsync<GetDocumentResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetInventory

        internal virtual GetInventoryResponse GetInventory(GetInventoryRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetInventoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetInventoryResponseUnmarshaller.Instance;

            return Invoke<GetInventoryResponse>(request, options);
        }



        /// <summary>
        /// Query inventory information.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetInventory service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetInventory service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidAggregatorException">
        /// The specified aggregator is not valid for inventory groups. Verify that the aggregator
        /// uses a valid inventory type such as <code>AWS:Application</code> or <code>AWS:InstanceInformation</code>.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidFilterException">
        /// The filter name is not valid. Verify the you entered the correct name and try again.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidInventoryGroupException">
        /// The specified inventory group is not valid.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidNextTokenException">
        /// The specified token is not valid.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidResultAttributeException">
        /// The specified inventory item result attribute is not valid.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidTypeNameException">
        /// The parameter type name is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/GetInventory">REST API Reference for GetInventory Operation</seealso>
        public virtual Task<GetInventoryResponse> GetInventoryAsync(GetInventoryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetInventoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetInventoryResponseUnmarshaller.Instance;

            return InvokeAsync<GetInventoryResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetInventorySchema

        internal virtual GetInventorySchemaResponse GetInventorySchema(GetInventorySchemaRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetInventorySchemaRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetInventorySchemaResponseUnmarshaller.Instance;

            return Invoke<GetInventorySchemaResponse>(request, options);
        }



        /// <summary>
        /// Return a list of inventory type names for the account, or return a list of attribute
        /// names for a specific Inventory item type.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetInventorySchema service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetInventorySchema service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidNextTokenException">
        /// The specified token is not valid.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidTypeNameException">
        /// The parameter type name is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/GetInventorySchema">REST API Reference for GetInventorySchema Operation</seealso>
        public virtual Task<GetInventorySchemaResponse> GetInventorySchemaAsync(GetInventorySchemaRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetInventorySchemaRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetInventorySchemaResponseUnmarshaller.Instance;

            return InvokeAsync<GetInventorySchemaResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetMaintenanceWindow

        internal virtual GetMaintenanceWindowResponse GetMaintenanceWindow(GetMaintenanceWindowRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetMaintenanceWindowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMaintenanceWindowResponseUnmarshaller.Instance;

            return Invoke<GetMaintenanceWindowResponse>(request, options);
        }



        /// <summary>
        /// Retrieves a maintenance window.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMaintenanceWindow service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetMaintenanceWindow service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.DoesNotExistException">
        /// Error returned when the ID specified for a resource, such as a maintenance window
        /// or Patch baseline, doesn't exist.
        /// 
        ///  
        /// <para>
        /// For information about resource quotas in Systems Manager, see <a href="http://docs.aws.amazon.com/general/latest/gr/ssm.html#limits_ssm">Systems
        /// Manager service quotas</a> in the <i>AWS General Reference</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/GetMaintenanceWindow">REST API Reference for GetMaintenanceWindow Operation</seealso>
        public virtual Task<GetMaintenanceWindowResponse> GetMaintenanceWindowAsync(GetMaintenanceWindowRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetMaintenanceWindowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMaintenanceWindowResponseUnmarshaller.Instance;

            return InvokeAsync<GetMaintenanceWindowResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetMaintenanceWindowExecution

        internal virtual GetMaintenanceWindowExecutionResponse GetMaintenanceWindowExecution(GetMaintenanceWindowExecutionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetMaintenanceWindowExecutionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMaintenanceWindowExecutionResponseUnmarshaller.Instance;

            return Invoke<GetMaintenanceWindowExecutionResponse>(request, options);
        }



        /// <summary>
        /// Retrieves details about a specific a maintenance window execution.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMaintenanceWindowExecution service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetMaintenanceWindowExecution service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.DoesNotExistException">
        /// Error returned when the ID specified for a resource, such as a maintenance window
        /// or Patch baseline, doesn't exist.
        /// 
        ///  
        /// <para>
        /// For information about resource quotas in Systems Manager, see <a href="http://docs.aws.amazon.com/general/latest/gr/ssm.html#limits_ssm">Systems
        /// Manager service quotas</a> in the <i>AWS General Reference</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/GetMaintenanceWindowExecution">REST API Reference for GetMaintenanceWindowExecution Operation</seealso>
        public virtual Task<GetMaintenanceWindowExecutionResponse> GetMaintenanceWindowExecutionAsync(GetMaintenanceWindowExecutionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetMaintenanceWindowExecutionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMaintenanceWindowExecutionResponseUnmarshaller.Instance;

            return InvokeAsync<GetMaintenanceWindowExecutionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetMaintenanceWindowExecutionTask

        internal virtual GetMaintenanceWindowExecutionTaskResponse GetMaintenanceWindowExecutionTask(GetMaintenanceWindowExecutionTaskRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetMaintenanceWindowExecutionTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMaintenanceWindowExecutionTaskResponseUnmarshaller.Instance;

            return Invoke<GetMaintenanceWindowExecutionTaskResponse>(request, options);
        }



        /// <summary>
        /// Retrieves the details about a specific task run as part of a maintenance window execution.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMaintenanceWindowExecutionTask service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetMaintenanceWindowExecutionTask service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.DoesNotExistException">
        /// Error returned when the ID specified for a resource, such as a maintenance window
        /// or Patch baseline, doesn't exist.
        /// 
        ///  
        /// <para>
        /// For information about resource quotas in Systems Manager, see <a href="http://docs.aws.amazon.com/general/latest/gr/ssm.html#limits_ssm">Systems
        /// Manager service quotas</a> in the <i>AWS General Reference</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/GetMaintenanceWindowExecutionTask">REST API Reference for GetMaintenanceWindowExecutionTask Operation</seealso>
        public virtual Task<GetMaintenanceWindowExecutionTaskResponse> GetMaintenanceWindowExecutionTaskAsync(GetMaintenanceWindowExecutionTaskRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetMaintenanceWindowExecutionTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMaintenanceWindowExecutionTaskResponseUnmarshaller.Instance;

            return InvokeAsync<GetMaintenanceWindowExecutionTaskResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetMaintenanceWindowExecutionTaskInvocation

        internal virtual GetMaintenanceWindowExecutionTaskInvocationResponse GetMaintenanceWindowExecutionTaskInvocation(GetMaintenanceWindowExecutionTaskInvocationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetMaintenanceWindowExecutionTaskInvocationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMaintenanceWindowExecutionTaskInvocationResponseUnmarshaller.Instance;

            return Invoke<GetMaintenanceWindowExecutionTaskInvocationResponse>(request, options);
        }



        /// <summary>
        /// Retrieves information about a specific task running on a specific target.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMaintenanceWindowExecutionTaskInvocation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetMaintenanceWindowExecutionTaskInvocation service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.DoesNotExistException">
        /// Error returned when the ID specified for a resource, such as a maintenance window
        /// or Patch baseline, doesn't exist.
        /// 
        ///  
        /// <para>
        /// For information about resource quotas in Systems Manager, see <a href="http://docs.aws.amazon.com/general/latest/gr/ssm.html#limits_ssm">Systems
        /// Manager service quotas</a> in the <i>AWS General Reference</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/GetMaintenanceWindowExecutionTaskInvocation">REST API Reference for GetMaintenanceWindowExecutionTaskInvocation Operation</seealso>
        public virtual Task<GetMaintenanceWindowExecutionTaskInvocationResponse> GetMaintenanceWindowExecutionTaskInvocationAsync(GetMaintenanceWindowExecutionTaskInvocationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetMaintenanceWindowExecutionTaskInvocationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMaintenanceWindowExecutionTaskInvocationResponseUnmarshaller.Instance;

            return InvokeAsync<GetMaintenanceWindowExecutionTaskInvocationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetMaintenanceWindowTask

        internal virtual GetMaintenanceWindowTaskResponse GetMaintenanceWindowTask(GetMaintenanceWindowTaskRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetMaintenanceWindowTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMaintenanceWindowTaskResponseUnmarshaller.Instance;

            return Invoke<GetMaintenanceWindowTaskResponse>(request, options);
        }



        /// <summary>
        /// Lists the tasks in a maintenance window.
        /// 
        ///  <note> 
        /// <para>
        /// For maintenance window tasks without a specified target, you cannot supply values
        /// for <code>--max-errors</code> and <code>--max-concurrency</code>. Instead, the system
        /// inserts a placeholder value of <code>1</code>, which may be reported in the response
        /// to this command. These values do not affect the running of your task and can be ignored.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMaintenanceWindowTask service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetMaintenanceWindowTask service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.DoesNotExistException">
        /// Error returned when the ID specified for a resource, such as a maintenance window
        /// or Patch baseline, doesn't exist.
        /// 
        ///  
        /// <para>
        /// For information about resource quotas in Systems Manager, see <a href="http://docs.aws.amazon.com/general/latest/gr/ssm.html#limits_ssm">Systems
        /// Manager service quotas</a> in the <i>AWS General Reference</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/GetMaintenanceWindowTask">REST API Reference for GetMaintenanceWindowTask Operation</seealso>
        public virtual Task<GetMaintenanceWindowTaskResponse> GetMaintenanceWindowTaskAsync(GetMaintenanceWindowTaskRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetMaintenanceWindowTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMaintenanceWindowTaskResponseUnmarshaller.Instance;

            return InvokeAsync<GetMaintenanceWindowTaskResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetOpsItem

        internal virtual GetOpsItemResponse GetOpsItem(GetOpsItemRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetOpsItemRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetOpsItemResponseUnmarshaller.Instance;

            return Invoke<GetOpsItemResponse>(request, options);
        }



        /// <summary>
        /// Get information about an OpsItem by using the ID. You must have permission in AWS
        /// Identity and Access Management (IAM) to view information about an OpsItem. For more
        /// information, see <a href="https://docs.aws.amazon.com/systems-manager/latest/userguide/OpsCenter-getting-started.html">Getting
        /// started with OpsCenter</a> in the <i>AWS Systems Manager User Guide</i>.
        /// 
        ///  
        /// <para>
        /// Operations engineers and IT professionals use OpsCenter to view, investigate, and
        /// remediate operational issues impacting the performance and health of their AWS resources.
        /// For more information, see <a href="https://docs.aws.amazon.com/systems-manager/latest/userguide/OpsCenter.html">AWS
        /// Systems Manager OpsCenter</a> in the <i>AWS Systems Manager User Guide</i>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetOpsItem service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetOpsItem service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.OpsItemNotFoundException">
        /// The specified OpsItem ID doesn't exist. Verify the ID and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/GetOpsItem">REST API Reference for GetOpsItem Operation</seealso>
        public virtual Task<GetOpsItemResponse> GetOpsItemAsync(GetOpsItemRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetOpsItemRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetOpsItemResponseUnmarshaller.Instance;

            return InvokeAsync<GetOpsItemResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetOpsMetadata

        internal virtual GetOpsMetadataResponse GetOpsMetadata(GetOpsMetadataRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetOpsMetadataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetOpsMetadataResponseUnmarshaller.Instance;

            return Invoke<GetOpsMetadataResponse>(request, options);
        }



        /// <summary>
        /// View operational metadata related to an application in Application Manager.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetOpsMetadata service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetOpsMetadata service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.OpsMetadataInvalidArgumentException">
        /// One of the arguments passed is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.OpsMetadataNotFoundException">
        /// The OpsMetadata object does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/GetOpsMetadata">REST API Reference for GetOpsMetadata Operation</seealso>
        public virtual Task<GetOpsMetadataResponse> GetOpsMetadataAsync(GetOpsMetadataRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetOpsMetadataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetOpsMetadataResponseUnmarshaller.Instance;

            return InvokeAsync<GetOpsMetadataResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetOpsSummary

        internal virtual GetOpsSummaryResponse GetOpsSummary(GetOpsSummaryRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetOpsSummaryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetOpsSummaryResponseUnmarshaller.Instance;

            return Invoke<GetOpsSummaryResponse>(request, options);
        }



        /// <summary>
        /// View a summary of OpsItems based on specified filters and aggregators.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetOpsSummary service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetOpsSummary service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidAggregatorException">
        /// The specified aggregator is not valid for inventory groups. Verify that the aggregator
        /// uses a valid inventory type such as <code>AWS:Application</code> or <code>AWS:InstanceInformation</code>.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidFilterException">
        /// The filter name is not valid. Verify the you entered the correct name and try again.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidNextTokenException">
        /// The specified token is not valid.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidTypeNameException">
        /// The parameter type name is not valid.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.ResourceDataSyncNotFoundException">
        /// The specified sync name was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/GetOpsSummary">REST API Reference for GetOpsSummary Operation</seealso>
        public virtual Task<GetOpsSummaryResponse> GetOpsSummaryAsync(GetOpsSummaryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetOpsSummaryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetOpsSummaryResponseUnmarshaller.Instance;

            return InvokeAsync<GetOpsSummaryResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetParameter

        internal virtual GetParameterResponse GetParameter(GetParameterRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetParameterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetParameterResponseUnmarshaller.Instance;

            return Invoke<GetParameterResponse>(request, options);
        }



        /// <summary>
        /// Get information about a parameter by using the parameter name. Don't confuse this
        /// API action with the <a>GetParameters</a> API action.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetParameter service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetParameter service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidKeyIdException">
        /// The query key ID is not valid.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.ParameterNotFoundException">
        /// The parameter could not be found. Verify the name and try again.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.ParameterVersionNotFoundException">
        /// The specified parameter version was not found. Verify the parameter name and version,
        /// and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/GetParameter">REST API Reference for GetParameter Operation</seealso>
        public virtual Task<GetParameterResponse> GetParameterAsync(GetParameterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetParameterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetParameterResponseUnmarshaller.Instance;

            return InvokeAsync<GetParameterResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetParameterHistory

        internal virtual GetParameterHistoryResponse GetParameterHistory(GetParameterHistoryRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetParameterHistoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetParameterHistoryResponseUnmarshaller.Instance;

            return Invoke<GetParameterHistoryResponse>(request, options);
        }



        /// <summary>
        /// Retrieves the history of all changes to a parameter.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetParameterHistory service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetParameterHistory service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidKeyIdException">
        /// The query key ID is not valid.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidNextTokenException">
        /// The specified token is not valid.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.ParameterNotFoundException">
        /// The parameter could not be found. Verify the name and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/GetParameterHistory">REST API Reference for GetParameterHistory Operation</seealso>
        public virtual Task<GetParameterHistoryResponse> GetParameterHistoryAsync(GetParameterHistoryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetParameterHistoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetParameterHistoryResponseUnmarshaller.Instance;

            return InvokeAsync<GetParameterHistoryResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetParameters

        internal virtual GetParametersResponse GetParameters(GetParametersRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetParametersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetParametersResponseUnmarshaller.Instance;

            return Invoke<GetParametersResponse>(request, options);
        }



        /// <summary>
        /// Get details of a parameter. Don't confuse this API action with the <a>GetParameter</a>
        /// API action.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetParameters service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetParameters service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidKeyIdException">
        /// The query key ID is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/GetParameters">REST API Reference for GetParameters Operation</seealso>
        public virtual Task<GetParametersResponse> GetParametersAsync(GetParametersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetParametersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetParametersResponseUnmarshaller.Instance;

            return InvokeAsync<GetParametersResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetParametersByPath

        internal virtual GetParametersByPathResponse GetParametersByPath(GetParametersByPathRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetParametersByPathRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetParametersByPathResponseUnmarshaller.Instance;

            return Invoke<GetParametersByPathResponse>(request, options);
        }



        /// <summary>
        /// Retrieve information about one or more parameters in a specific hierarchy. 
        /// 
        ///  <note> 
        /// <para>
        /// Request results are returned on a best-effort basis. If you specify <code>MaxResults</code>
        /// in the request, the response includes information up to the limit specified. The number
        /// of items returned, however, can be between zero and the value of <code>MaxResults</code>.
        /// If the service reaches an internal limit while processing the results, it stops the
        /// operation and returns the matching values up to that point and a <code>NextToken</code>.
        /// You can specify the <code>NextToken</code> in a subsequent call to get the next set
        /// of results.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetParametersByPath service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetParametersByPath service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidFilterKeyException">
        /// The specified key is not valid.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidFilterOptionException">
        /// The specified filter option is not valid. Valid options are Equals and BeginsWith.
        /// For Path filter, valid options are Recursive and OneLevel.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidFilterValueException">
        /// The filter value is not valid. Verify the value and try again.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidKeyIdException">
        /// The query key ID is not valid.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidNextTokenException">
        /// The specified token is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/GetParametersByPath">REST API Reference for GetParametersByPath Operation</seealso>
        public virtual Task<GetParametersByPathResponse> GetParametersByPathAsync(GetParametersByPathRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetParametersByPathRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetParametersByPathResponseUnmarshaller.Instance;

            return InvokeAsync<GetParametersByPathResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetPatchBaseline

        internal virtual GetPatchBaselineResponse GetPatchBaseline(GetPatchBaselineRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetPatchBaselineRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPatchBaselineResponseUnmarshaller.Instance;

            return Invoke<GetPatchBaselineResponse>(request, options);
        }



        /// <summary>
        /// Retrieves information about a patch baseline.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPatchBaseline service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetPatchBaseline service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.DoesNotExistException">
        /// Error returned when the ID specified for a resource, such as a maintenance window
        /// or Patch baseline, doesn't exist.
        /// 
        ///  
        /// <para>
        /// For information about resource quotas in Systems Manager, see <a href="http://docs.aws.amazon.com/general/latest/gr/ssm.html#limits_ssm">Systems
        /// Manager service quotas</a> in the <i>AWS General Reference</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidResourceIdException">
        /// The resource ID is not valid. Verify that you entered the correct ID and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/GetPatchBaseline">REST API Reference for GetPatchBaseline Operation</seealso>
        public virtual Task<GetPatchBaselineResponse> GetPatchBaselineAsync(GetPatchBaselineRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetPatchBaselineRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPatchBaselineResponseUnmarshaller.Instance;

            return InvokeAsync<GetPatchBaselineResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetPatchBaselineForPatchGroup

        internal virtual GetPatchBaselineForPatchGroupResponse GetPatchBaselineForPatchGroup(GetPatchBaselineForPatchGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetPatchBaselineForPatchGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPatchBaselineForPatchGroupResponseUnmarshaller.Instance;

            return Invoke<GetPatchBaselineForPatchGroupResponse>(request, options);
        }



        /// <summary>
        /// Retrieves the patch baseline that should be used for the specified patch group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPatchBaselineForPatchGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetPatchBaselineForPatchGroup service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/GetPatchBaselineForPatchGroup">REST API Reference for GetPatchBaselineForPatchGroup Operation</seealso>
        public virtual Task<GetPatchBaselineForPatchGroupResponse> GetPatchBaselineForPatchGroupAsync(GetPatchBaselineForPatchGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetPatchBaselineForPatchGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPatchBaselineForPatchGroupResponseUnmarshaller.Instance;

            return InvokeAsync<GetPatchBaselineForPatchGroupResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetServiceSetting

        internal virtual GetServiceSettingResponse GetServiceSetting(GetServiceSettingRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetServiceSettingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetServiceSettingResponseUnmarshaller.Instance;

            return Invoke<GetServiceSettingResponse>(request, options);
        }



        /// <summary>
        /// <code>ServiceSetting</code> is an account-level setting for an AWS service. This
        /// setting defines how a user interacts with or uses a service or a feature of a service.
        /// For example, if an AWS service charges money to the account based on feature or service
        /// usage, then the AWS service team might create a default setting of "false". This means
        /// the user can't use this feature unless they change the setting to "true" and intentionally
        /// opt in for a paid feature.
        /// 
        ///  
        /// <para>
        /// Services map a <code>SettingId</code> object to a setting value. AWS services teams
        /// define the default value for a <code>SettingId</code>. You can't create a new <code>SettingId</code>,
        /// but you can overwrite the default value if you have the <code>ssm:UpdateServiceSetting</code>
        /// permission for the setting. Use the <a>UpdateServiceSetting</a> API action to change
        /// the default setting. Or use the <a>ResetServiceSetting</a> to change the value back
        /// to the original value defined by the AWS service team.
        /// </para>
        ///  
        /// <para>
        /// Query the current service setting for the account. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetServiceSetting service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetServiceSetting service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.ServiceSettingNotFoundException">
        /// The specified service setting was not found. Either the service name or the setting
        /// has not been provisioned by the AWS service team.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/GetServiceSetting">REST API Reference for GetServiceSetting Operation</seealso>
        public virtual Task<GetServiceSettingResponse> GetServiceSettingAsync(GetServiceSettingRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetServiceSettingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetServiceSettingResponseUnmarshaller.Instance;

            return InvokeAsync<GetServiceSettingResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  LabelParameterVersion

        internal virtual LabelParameterVersionResponse LabelParameterVersion(LabelParameterVersionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = LabelParameterVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = LabelParameterVersionResponseUnmarshaller.Instance;

            return Invoke<LabelParameterVersionResponse>(request, options);
        }



        /// <summary>
        /// A parameter label is a user-defined alias to help you manage different versions of
        /// a parameter. When you modify a parameter, Systems Manager automatically saves a new
        /// version and increments the version number by one. A label can help you remember the
        /// purpose of a parameter when there are multiple versions. 
        /// 
        ///  
        /// <para>
        /// Parameter labels have the following requirements and restrictions.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// A version of a parameter can have a maximum of 10 labels.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You can't attach the same label to different versions of the same parameter. For example,
        /// if version 1 has the label Production, then you can't attach Production to version
        /// 2.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You can move a label from one version of a parameter to another.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You can't create a label when you create a new parameter. You must attach a label
        /// to a specific version of a parameter.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You can't delete a parameter label. If you no longer want to use a parameter label,
        /// then you must move it to a different version of a parameter.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A label can have a maximum of 100 characters.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Labels can contain letters (case sensitive), numbers, periods (.), hyphens (-), or
        /// underscores (_).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Labels can't begin with a number, "aws," or "ssm" (not case sensitive). If a label
        /// fails to meet these requirements, then the label is not associated with a parameter
        /// and the system displays it in the list of InvalidLabels.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the LabelParameterVersion service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the LabelParameterVersion service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.ParameterNotFoundException">
        /// The parameter could not be found. Verify the name and try again.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.ParameterVersionLabelLimitExceededException">
        /// A parameter version can have a maximum of ten labels.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.ParameterVersionNotFoundException">
        /// The specified parameter version was not found. Verify the parameter name and version,
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.TooManyUpdatesException">
        /// There are concurrent updates for a resource that supports one update at a time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/LabelParameterVersion">REST API Reference for LabelParameterVersion Operation</seealso>
        public virtual Task<LabelParameterVersionResponse> LabelParameterVersionAsync(LabelParameterVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = LabelParameterVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = LabelParameterVersionResponseUnmarshaller.Instance;

            return InvokeAsync<LabelParameterVersionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListAssociations

        internal virtual ListAssociationsResponse ListAssociations(ListAssociationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAssociationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAssociationsResponseUnmarshaller.Instance;

            return Invoke<ListAssociationsResponse>(request, options);
        }



        /// <summary>
        /// Returns all State Manager associations in the current AWS account and Region. You
        /// can limit the results to a specific State Manager association document or instance
        /// by specifying a filter.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAssociations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAssociations service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidNextTokenException">
        /// The specified token is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/ListAssociations">REST API Reference for ListAssociations Operation</seealso>
        public virtual Task<ListAssociationsResponse> ListAssociationsAsync(ListAssociationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAssociationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAssociationsResponseUnmarshaller.Instance;

            return InvokeAsync<ListAssociationsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListAssociationVersions

        internal virtual ListAssociationVersionsResponse ListAssociationVersions(ListAssociationVersionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAssociationVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAssociationVersionsResponseUnmarshaller.Instance;

            return Invoke<ListAssociationVersionsResponse>(request, options);
        }



        /// <summary>
        /// Retrieves all versions of an association for a specific association ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAssociationVersions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAssociationVersions service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.AssociationDoesNotExistException">
        /// The specified association does not exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidNextTokenException">
        /// The specified token is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/ListAssociationVersions">REST API Reference for ListAssociationVersions Operation</seealso>
        public virtual Task<ListAssociationVersionsResponse> ListAssociationVersionsAsync(ListAssociationVersionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAssociationVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAssociationVersionsResponseUnmarshaller.Instance;

            return InvokeAsync<ListAssociationVersionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListCommandInvocations

        internal virtual ListCommandInvocationsResponse ListCommandInvocations()
        {
            return ListCommandInvocations(new ListCommandInvocationsRequest());
        }
        internal virtual ListCommandInvocationsResponse ListCommandInvocations(ListCommandInvocationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListCommandInvocationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCommandInvocationsResponseUnmarshaller.Instance;

            return Invoke<ListCommandInvocationsResponse>(request, options);
        }


        /// <summary>
        /// An invocation is copy of a command sent to a specific instance. A command can apply
        /// to one or more instances. A command invocation applies to one instance. For example,
        /// if a user runs SendCommand against three instances, then a command invocation is created
        /// for each requested instance ID. ListCommandInvocations provide status about command
        /// execution.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListCommandInvocations service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidCommandIdException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidFilterKeyException">
        /// The specified key is not valid.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidInstanceIdException">
        /// The following problems can cause this exception:
        /// 
        ///  
        /// <para>
        /// You do not have permission to access the instance.
        /// </para>
        ///  
        /// <para>
        /// SSM Agent is not running. Verify that SSM Agent is running.
        /// </para>
        ///  
        /// <para>
        /// SSM Agent is not registered with the SSM endpoint. Try reinstalling SSM Agent.
        /// </para>
        ///  
        /// <para>
        /// The instance is not in valid state. Valid states are: Running, Pending, Stopped, Stopping.
        /// Invalid states are: Shutting-down and Terminated.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidNextTokenException">
        /// The specified token is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/ListCommandInvocations">REST API Reference for ListCommandInvocations Operation</seealso>
        public virtual Task<ListCommandInvocationsResponse> ListCommandInvocationsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return ListCommandInvocationsAsync(new ListCommandInvocationsRequest(), cancellationToken);
        }


        /// <summary>
        /// An invocation is copy of a command sent to a specific instance. A command can apply
        /// to one or more instances. A command invocation applies to one instance. For example,
        /// if a user runs SendCommand against three instances, then a command invocation is created
        /// for each requested instance ID. ListCommandInvocations provide status about command
        /// execution.
        /// </summary>
        /// <param name="commandId">(Optional) The invocations for a specific command ID.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListCommandInvocations service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidCommandIdException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidFilterKeyException">
        /// The specified key is not valid.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidInstanceIdException">
        /// The following problems can cause this exception:
        /// 
        ///  
        /// <para>
        /// You do not have permission to access the instance.
        /// </para>
        ///  
        /// <para>
        /// SSM Agent is not running. Verify that SSM Agent is running.
        /// </para>
        ///  
        /// <para>
        /// SSM Agent is not registered with the SSM endpoint. Try reinstalling SSM Agent.
        /// </para>
        ///  
        /// <para>
        /// The instance is not in valid state. Valid states are: Running, Pending, Stopped, Stopping.
        /// Invalid states are: Shutting-down and Terminated.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidNextTokenException">
        /// The specified token is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/ListCommandInvocations">REST API Reference for ListCommandInvocations Operation</seealso>
        public virtual Task<ListCommandInvocationsResponse> ListCommandInvocationsAsync(string commandId, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new ListCommandInvocationsRequest();
            request.CommandId = commandId;
            return ListCommandInvocationsAsync(request, cancellationToken);
        }



        /// <summary>
        /// An invocation is copy of a command sent to a specific instance. A command can apply
        /// to one or more instances. A command invocation applies to one instance. For example,
        /// if a user runs SendCommand against three instances, then a command invocation is created
        /// for each requested instance ID. ListCommandInvocations provide status about command
        /// execution.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCommandInvocations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListCommandInvocations service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidCommandIdException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidFilterKeyException">
        /// The specified key is not valid.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidInstanceIdException">
        /// The following problems can cause this exception:
        /// 
        ///  
        /// <para>
        /// You do not have permission to access the instance.
        /// </para>
        ///  
        /// <para>
        /// SSM Agent is not running. Verify that SSM Agent is running.
        /// </para>
        ///  
        /// <para>
        /// SSM Agent is not registered with the SSM endpoint. Try reinstalling SSM Agent.
        /// </para>
        ///  
        /// <para>
        /// The instance is not in valid state. Valid states are: Running, Pending, Stopped, Stopping.
        /// Invalid states are: Shutting-down and Terminated.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidNextTokenException">
        /// The specified token is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/ListCommandInvocations">REST API Reference for ListCommandInvocations Operation</seealso>
        public virtual Task<ListCommandInvocationsResponse> ListCommandInvocationsAsync(ListCommandInvocationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListCommandInvocationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCommandInvocationsResponseUnmarshaller.Instance;

            return InvokeAsync<ListCommandInvocationsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListCommands

        internal virtual ListCommandsResponse ListCommands()
        {
            return ListCommands(new ListCommandsRequest());
        }
        internal virtual ListCommandsResponse ListCommands(ListCommandsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListCommandsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCommandsResponseUnmarshaller.Instance;

            return Invoke<ListCommandsResponse>(request, options);
        }


        /// <summary>
        /// Lists the commands requested by users of the AWS account.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListCommands service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidCommandIdException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidFilterKeyException">
        /// The specified key is not valid.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidInstanceIdException">
        /// The following problems can cause this exception:
        /// 
        ///  
        /// <para>
        /// You do not have permission to access the instance.
        /// </para>
        ///  
        /// <para>
        /// SSM Agent is not running. Verify that SSM Agent is running.
        /// </para>
        ///  
        /// <para>
        /// SSM Agent is not registered with the SSM endpoint. Try reinstalling SSM Agent.
        /// </para>
        ///  
        /// <para>
        /// The instance is not in valid state. Valid states are: Running, Pending, Stopped, Stopping.
        /// Invalid states are: Shutting-down and Terminated.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidNextTokenException">
        /// The specified token is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/ListCommands">REST API Reference for ListCommands Operation</seealso>
        public virtual Task<ListCommandsResponse> ListCommandsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return ListCommandsAsync(new ListCommandsRequest(), cancellationToken);
        }


        /// <summary>
        /// Lists the commands requested by users of the AWS account.
        /// </summary>
        /// <param name="commandId">(Optional) If provided, lists only the specified command.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListCommands service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidCommandIdException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidFilterKeyException">
        /// The specified key is not valid.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidInstanceIdException">
        /// The following problems can cause this exception:
        /// 
        ///  
        /// <para>
        /// You do not have permission to access the instance.
        /// </para>
        ///  
        /// <para>
        /// SSM Agent is not running. Verify that SSM Agent is running.
        /// </para>
        ///  
        /// <para>
        /// SSM Agent is not registered with the SSM endpoint. Try reinstalling SSM Agent.
        /// </para>
        ///  
        /// <para>
        /// The instance is not in valid state. Valid states are: Running, Pending, Stopped, Stopping.
        /// Invalid states are: Shutting-down and Terminated.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidNextTokenException">
        /// The specified token is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/ListCommands">REST API Reference for ListCommands Operation</seealso>
        public virtual Task<ListCommandsResponse> ListCommandsAsync(string commandId, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new ListCommandsRequest();
            request.CommandId = commandId;
            return ListCommandsAsync(request, cancellationToken);
        }



        /// <summary>
        /// Lists the commands requested by users of the AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCommands service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListCommands service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidCommandIdException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidFilterKeyException">
        /// The specified key is not valid.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidInstanceIdException">
        /// The following problems can cause this exception:
        /// 
        ///  
        /// <para>
        /// You do not have permission to access the instance.
        /// </para>
        ///  
        /// <para>
        /// SSM Agent is not running. Verify that SSM Agent is running.
        /// </para>
        ///  
        /// <para>
        /// SSM Agent is not registered with the SSM endpoint. Try reinstalling SSM Agent.
        /// </para>
        ///  
        /// <para>
        /// The instance is not in valid state. Valid states are: Running, Pending, Stopped, Stopping.
        /// Invalid states are: Shutting-down and Terminated.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidNextTokenException">
        /// The specified token is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/ListCommands">REST API Reference for ListCommands Operation</seealso>
        public virtual Task<ListCommandsResponse> ListCommandsAsync(ListCommandsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListCommandsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCommandsResponseUnmarshaller.Instance;

            return InvokeAsync<ListCommandsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListComplianceItems

        internal virtual ListComplianceItemsResponse ListComplianceItems(ListComplianceItemsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListComplianceItemsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListComplianceItemsResponseUnmarshaller.Instance;

            return Invoke<ListComplianceItemsResponse>(request, options);
        }



        /// <summary>
        /// For a specified resource ID, this API action returns a list of compliance statuses
        /// for different resource types. Currently, you can only specify one resource ID per
        /// call. List results depend on the criteria specified in the filter.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListComplianceItems service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListComplianceItems service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidFilterException">
        /// The filter name is not valid. Verify the you entered the correct name and try again.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidNextTokenException">
        /// The specified token is not valid.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidResourceIdException">
        /// The resource ID is not valid. Verify that you entered the correct ID and try again.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidResourceTypeException">
        /// The resource type is not valid. For example, if you are attempting to tag an instance,
        /// the instance must be a registered, managed instance.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/ListComplianceItems">REST API Reference for ListComplianceItems Operation</seealso>
        public virtual Task<ListComplianceItemsResponse> ListComplianceItemsAsync(ListComplianceItemsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListComplianceItemsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListComplianceItemsResponseUnmarshaller.Instance;

            return InvokeAsync<ListComplianceItemsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListComplianceSummaries

        internal virtual ListComplianceSummariesResponse ListComplianceSummaries(ListComplianceSummariesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListComplianceSummariesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListComplianceSummariesResponseUnmarshaller.Instance;

            return Invoke<ListComplianceSummariesResponse>(request, options);
        }



        /// <summary>
        /// Returns a summary count of compliant and non-compliant resources for a compliance
        /// type. For example, this call can return State Manager associations, patches, or custom
        /// compliance types according to the filter criteria that you specify.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListComplianceSummaries service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListComplianceSummaries service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidFilterException">
        /// The filter name is not valid. Verify the you entered the correct name and try again.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidNextTokenException">
        /// The specified token is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/ListComplianceSummaries">REST API Reference for ListComplianceSummaries Operation</seealso>
        public virtual Task<ListComplianceSummariesResponse> ListComplianceSummariesAsync(ListComplianceSummariesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListComplianceSummariesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListComplianceSummariesResponseUnmarshaller.Instance;

            return InvokeAsync<ListComplianceSummariesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListDocumentMetadataHistory

        internal virtual ListDocumentMetadataHistoryResponse ListDocumentMetadataHistory(ListDocumentMetadataHistoryRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDocumentMetadataHistoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDocumentMetadataHistoryResponseUnmarshaller.Instance;

            return Invoke<ListDocumentMetadataHistoryResponse>(request, options);
        }



        /// <summary>
        /// Information about approval reviews for a version of an SSM document.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDocumentMetadataHistory service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListDocumentMetadataHistory service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidDocumentException">
        /// The specified document does not exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidDocumentVersionException">
        /// The document version is not valid or does not exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidNextTokenException">
        /// The specified token is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/ListDocumentMetadataHistory">REST API Reference for ListDocumentMetadataHistory Operation</seealso>
        public virtual Task<ListDocumentMetadataHistoryResponse> ListDocumentMetadataHistoryAsync(ListDocumentMetadataHistoryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDocumentMetadataHistoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDocumentMetadataHistoryResponseUnmarshaller.Instance;

            return InvokeAsync<ListDocumentMetadataHistoryResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListDocuments

        internal virtual ListDocumentsResponse ListDocuments()
        {
            return ListDocuments(new ListDocumentsRequest());
        }
        internal virtual ListDocumentsResponse ListDocuments(ListDocumentsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDocumentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDocumentsResponseUnmarshaller.Instance;

            return Invoke<ListDocumentsResponse>(request, options);
        }


        /// <summary>
        /// Returns all Systems Manager (SSM) documents in the current AWS account and Region.
        /// You can limit the results of this request by using a filter.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListDocuments service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidFilterKeyException">
        /// The specified key is not valid.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidNextTokenException">
        /// The specified token is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/ListDocuments">REST API Reference for ListDocuments Operation</seealso>
        public virtual Task<ListDocumentsResponse> ListDocumentsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return ListDocumentsAsync(new ListDocumentsRequest(), cancellationToken);
        }



        /// <summary>
        /// Returns all Systems Manager (SSM) documents in the current AWS account and Region.
        /// You can limit the results of this request by using a filter.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDocuments service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListDocuments service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidFilterKeyException">
        /// The specified key is not valid.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidNextTokenException">
        /// The specified token is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/ListDocuments">REST API Reference for ListDocuments Operation</seealso>
        public virtual Task<ListDocumentsResponse> ListDocumentsAsync(ListDocumentsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDocumentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDocumentsResponseUnmarshaller.Instance;

            return InvokeAsync<ListDocumentsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListDocumentVersions

        internal virtual ListDocumentVersionsResponse ListDocumentVersions(ListDocumentVersionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDocumentVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDocumentVersionsResponseUnmarshaller.Instance;

            return Invoke<ListDocumentVersionsResponse>(request, options);
        }



        /// <summary>
        /// List all versions for a document.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDocumentVersions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListDocumentVersions service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidDocumentException">
        /// The specified document does not exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidNextTokenException">
        /// The specified token is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/ListDocumentVersions">REST API Reference for ListDocumentVersions Operation</seealso>
        public virtual Task<ListDocumentVersionsResponse> ListDocumentVersionsAsync(ListDocumentVersionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDocumentVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDocumentVersionsResponseUnmarshaller.Instance;

            return InvokeAsync<ListDocumentVersionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListInventoryEntries

        internal virtual ListInventoryEntriesResponse ListInventoryEntries(ListInventoryEntriesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListInventoryEntriesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListInventoryEntriesResponseUnmarshaller.Instance;

            return Invoke<ListInventoryEntriesResponse>(request, options);
        }



        /// <summary>
        /// A list of inventory items returned by the request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListInventoryEntries service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListInventoryEntries service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidFilterException">
        /// The filter name is not valid. Verify the you entered the correct name and try again.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidInstanceIdException">
        /// The following problems can cause this exception:
        /// 
        ///  
        /// <para>
        /// You do not have permission to access the instance.
        /// </para>
        ///  
        /// <para>
        /// SSM Agent is not running. Verify that SSM Agent is running.
        /// </para>
        ///  
        /// <para>
        /// SSM Agent is not registered with the SSM endpoint. Try reinstalling SSM Agent.
        /// </para>
        ///  
        /// <para>
        /// The instance is not in valid state. Valid states are: Running, Pending, Stopped, Stopping.
        /// Invalid states are: Shutting-down and Terminated.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidNextTokenException">
        /// The specified token is not valid.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidTypeNameException">
        /// The parameter type name is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/ListInventoryEntries">REST API Reference for ListInventoryEntries Operation</seealso>
        public virtual Task<ListInventoryEntriesResponse> ListInventoryEntriesAsync(ListInventoryEntriesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListInventoryEntriesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListInventoryEntriesResponseUnmarshaller.Instance;

            return InvokeAsync<ListInventoryEntriesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListOpsItemEvents

        internal virtual ListOpsItemEventsResponse ListOpsItemEvents(ListOpsItemEventsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListOpsItemEventsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListOpsItemEventsResponseUnmarshaller.Instance;

            return Invoke<ListOpsItemEventsResponse>(request, options);
        }



        /// <summary>
        /// Returns a list of all OpsItem events in the current AWS account and Region. You can
        /// limit the results to events associated with specific OpsItems by specifying a filter.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListOpsItemEvents service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListOpsItemEvents service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.OpsItemInvalidParameterException">
        /// A specified parameter argument isn't valid. Verify the available arguments and try
        /// again.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.OpsItemLimitExceededException">
        /// The request caused OpsItems to exceed one or more quotas. For information about OpsItem
        /// quotas, see <a href="https://docs.aws.amazon.com/systems-manager/latest/userguide/OpsCenter-learn-more.html#OpsCenter-learn-more-limits">What
        /// are the resource limits for OpsCenter?</a>.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.OpsItemNotFoundException">
        /// The specified OpsItem ID doesn't exist. Verify the ID and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/ListOpsItemEvents">REST API Reference for ListOpsItemEvents Operation</seealso>
        public virtual Task<ListOpsItemEventsResponse> ListOpsItemEventsAsync(ListOpsItemEventsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListOpsItemEventsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListOpsItemEventsResponseUnmarshaller.Instance;

            return InvokeAsync<ListOpsItemEventsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListOpsMetadata

        internal virtual ListOpsMetadataResponse ListOpsMetadata(ListOpsMetadataRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListOpsMetadataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListOpsMetadataResponseUnmarshaller.Instance;

            return Invoke<ListOpsMetadataResponse>(request, options);
        }



        /// <summary>
        /// Systems Manager calls this API action when displaying all Application Manager OpsMetadata
        /// objects or blobs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListOpsMetadata service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListOpsMetadata service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.OpsMetadataInvalidArgumentException">
        /// One of the arguments passed is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/ListOpsMetadata">REST API Reference for ListOpsMetadata Operation</seealso>
        public virtual Task<ListOpsMetadataResponse> ListOpsMetadataAsync(ListOpsMetadataRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListOpsMetadataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListOpsMetadataResponseUnmarshaller.Instance;

            return InvokeAsync<ListOpsMetadataResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListResourceComplianceSummaries

        internal virtual ListResourceComplianceSummariesResponse ListResourceComplianceSummaries(ListResourceComplianceSummariesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListResourceComplianceSummariesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListResourceComplianceSummariesResponseUnmarshaller.Instance;

            return Invoke<ListResourceComplianceSummariesResponse>(request, options);
        }



        /// <summary>
        /// Returns a resource-level summary count. The summary includes information about compliant
        /// and non-compliant statuses and detailed compliance-item severity counts, according
        /// to the filter criteria you specify.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListResourceComplianceSummaries service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListResourceComplianceSummaries service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidFilterException">
        /// The filter name is not valid. Verify the you entered the correct name and try again.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidNextTokenException">
        /// The specified token is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/ListResourceComplianceSummaries">REST API Reference for ListResourceComplianceSummaries Operation</seealso>
        public virtual Task<ListResourceComplianceSummariesResponse> ListResourceComplianceSummariesAsync(ListResourceComplianceSummariesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListResourceComplianceSummariesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListResourceComplianceSummariesResponseUnmarshaller.Instance;

            return InvokeAsync<ListResourceComplianceSummariesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListResourceDataSync

        internal virtual ListResourceDataSyncResponse ListResourceDataSync(ListResourceDataSyncRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListResourceDataSyncRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListResourceDataSyncResponseUnmarshaller.Instance;

            return Invoke<ListResourceDataSyncResponse>(request, options);
        }



        /// <summary>
        /// Lists your resource data sync configurations. Includes information about the last
        /// time a sync attempted to start, the last sync status, and the last time a sync successfully
        /// completed.
        /// 
        ///  
        /// <para>
        /// The number of sync configurations might be too large to return using a single call
        /// to <code>ListResourceDataSync</code>. You can limit the number of sync configurations
        /// returned by using the <code>MaxResults</code> parameter. To determine whether there
        /// are more sync configurations to list, check the value of <code>NextToken</code> in
        /// the output. If there are more sync configurations to list, you can request them by
        /// specifying the <code>NextToken</code> returned in the call to the parameter of a subsequent
        /// call. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListResourceDataSync service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListResourceDataSync service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidNextTokenException">
        /// The specified token is not valid.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.ResourceDataSyncInvalidConfigurationException">
        /// The specified sync configuration is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/ListResourceDataSync">REST API Reference for ListResourceDataSync Operation</seealso>
        public virtual Task<ListResourceDataSyncResponse> ListResourceDataSyncAsync(ListResourceDataSyncRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListResourceDataSyncRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListResourceDataSyncResponseUnmarshaller.Instance;

            return InvokeAsync<ListResourceDataSyncResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListTagsForResource

        internal virtual ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<ListTagsForResourceResponse>(request, options);
        }



        /// <summary>
        /// Returns a list of the tags assigned to the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidResourceIdException">
        /// The resource ID is not valid. Verify that you entered the correct ID and try again.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidResourceTypeException">
        /// The resource type is not valid. For example, if you are attempting to tag an instance,
        /// the instance must be a registered, managed instance.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return InvokeAsync<ListTagsForResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ModifyDocumentPermission

        internal virtual ModifyDocumentPermissionResponse ModifyDocumentPermission(ModifyDocumentPermissionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyDocumentPermissionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyDocumentPermissionResponseUnmarshaller.Instance;

            return Invoke<ModifyDocumentPermissionResponse>(request, options);
        }



        /// <summary>
        /// Shares a Systems Manager document publicly or privately. If you share a document privately,
        /// you must specify the AWS user account IDs for those people who can use the document.
        /// If you share a document publicly, you must specify <i>All</i> as the account ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyDocumentPermission service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ModifyDocumentPermission service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.DocumentLimitExceededException">
        /// You can have at most 500 active Systems Manager documents.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.DocumentPermissionLimitException">
        /// The document cannot be shared with more AWS user accounts. You can share a document
        /// with a maximum of 20 accounts. You can publicly share up to five documents. If you
        /// need to increase this limit, contact AWS Support.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidDocumentException">
        /// The specified document does not exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidPermissionTypeException">
        /// The permission type is not supported. <i>Share</i> is the only supported permission
        /// type.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/ModifyDocumentPermission">REST API Reference for ModifyDocumentPermission Operation</seealso>
        public virtual Task<ModifyDocumentPermissionResponse> ModifyDocumentPermissionAsync(ModifyDocumentPermissionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyDocumentPermissionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyDocumentPermissionResponseUnmarshaller.Instance;

            return InvokeAsync<ModifyDocumentPermissionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutComplianceItems

        internal virtual PutComplianceItemsResponse PutComplianceItems(PutComplianceItemsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutComplianceItemsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutComplianceItemsResponseUnmarshaller.Instance;

            return Invoke<PutComplianceItemsResponse>(request, options);
        }



        /// <summary>
        /// Registers a compliance type and other compliance details on a designated resource.
        /// This action lets you register custom compliance details with a resource. This call
        /// overwrites existing compliance information on the resource, so you must provide a
        /// full list of compliance items each time that you send the request.
        /// 
        ///  
        /// <para>
        /// ComplianceType can be one of the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// ExecutionId: The execution ID when the patch, association, or custom compliance item
        /// was applied.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ExecutionType: Specify patch, association, or Custom:<code>string</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ExecutionTime. The time the patch, association, or custom compliance item was applied
        /// to the instance.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Id: The patch, association, or custom compliance ID.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Title: A title.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Status: The status of the compliance item. For example, <code>approved</code> for
        /// patches, or <code>Failed</code> for associations.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Severity: A patch severity. For example, <code>critical</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// DocumentName: A SSM document name. For example, AWS-RunPatchBaseline.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// DocumentVersion: An SSM document version number. For example, 4.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Classification: A patch classification. For example, <code>security updates</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// PatchBaselineId: A patch baseline ID.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// PatchSeverity: A patch severity. For example, <code>Critical</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// PatchState: A patch state. For example, <code>InstancesWithFailedPatches</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// PatchGroup: The name of a patch group.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// InstalledTime: The time the association, patch, or custom compliance item was applied
        /// to the resource. Specify the time by using the following format: yyyy-MM-dd'T'HH:mm:ss'Z'
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutComplianceItems service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutComplianceItems service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.ComplianceTypeCountLimitExceededException">
        /// You specified too many custom compliance types. You can specify a maximum of 10 different
        /// types.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidItemContentException">
        /// One or more content items is not valid.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidResourceIdException">
        /// The resource ID is not valid. Verify that you entered the correct ID and try again.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidResourceTypeException">
        /// The resource type is not valid. For example, if you are attempting to tag an instance,
        /// the instance must be a registered, managed instance.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.ItemSizeLimitExceededException">
        /// The inventory item size has exceeded the size limit.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.TotalSizeLimitExceededException">
        /// The size of inventory data has exceeded the total size limit for the resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/PutComplianceItems">REST API Reference for PutComplianceItems Operation</seealso>
        public virtual Task<PutComplianceItemsResponse> PutComplianceItemsAsync(PutComplianceItemsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutComplianceItemsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutComplianceItemsResponseUnmarshaller.Instance;

            return InvokeAsync<PutComplianceItemsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutInventory

        internal virtual PutInventoryResponse PutInventory(PutInventoryRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutInventoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutInventoryResponseUnmarshaller.Instance;

            return Invoke<PutInventoryResponse>(request, options);
        }



        /// <summary>
        /// Bulk update custom inventory items on one more instance. The request adds an inventory
        /// item, if it doesn't already exist, or updates an inventory item, if it does exist.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutInventory service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutInventory service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.CustomSchemaCountLimitExceededException">
        /// You have exceeded the limit for custom schemas. Delete one or more custom schemas
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidInstanceIdException">
        /// The following problems can cause this exception:
        /// 
        ///  
        /// <para>
        /// You do not have permission to access the instance.
        /// </para>
        ///  
        /// <para>
        /// SSM Agent is not running. Verify that SSM Agent is running.
        /// </para>
        ///  
        /// <para>
        /// SSM Agent is not registered with the SSM endpoint. Try reinstalling SSM Agent.
        /// </para>
        ///  
        /// <para>
        /// The instance is not in valid state. Valid states are: Running, Pending, Stopped, Stopping.
        /// Invalid states are: Shutting-down and Terminated.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidInventoryItemContextException">
        /// You specified invalid keys or values in the <code>Context</code> attribute for <code>InventoryItem</code>.
        /// Verify the keys and values, and try again.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidItemContentException">
        /// One or more content items is not valid.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidTypeNameException">
        /// The parameter type name is not valid.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.ItemContentMismatchException">
        /// The inventory item has invalid content.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.ItemSizeLimitExceededException">
        /// The inventory item size has exceeded the size limit.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.SubTypeCountLimitExceededException">
        /// The sub-type count exceeded the limit for the inventory type.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.TotalSizeLimitExceededException">
        /// The size of inventory data has exceeded the total size limit for the resource.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.UnsupportedInventoryItemContextException">
        /// The <code>Context</code> attribute that you specified for the <code>InventoryItem</code>
        /// is not allowed for this inventory type. You can only use the <code>Context</code>
        /// attribute with inventory types like <code>AWS:ComplianceItem</code>.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.UnsupportedInventorySchemaVersionException">
        /// Inventory item type schema version has to match supported versions in the service.
        /// Check output of GetInventorySchema to see the available schema version for each type.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/PutInventory">REST API Reference for PutInventory Operation</seealso>
        public virtual Task<PutInventoryResponse> PutInventoryAsync(PutInventoryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutInventoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutInventoryResponseUnmarshaller.Instance;

            return InvokeAsync<PutInventoryResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutParameter

        internal virtual PutParameterResponse PutParameter(PutParameterRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutParameterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutParameterResponseUnmarshaller.Instance;

            return Invoke<PutParameterResponse>(request, options);
        }



        /// <summary>
        /// Add a parameter to the system.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutParameter service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutParameter service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.HierarchyLevelLimitExceededException">
        /// A hierarchy can have a maximum of 15 levels. For more information, see <a href="https://docs.aws.amazon.com/systems-manager/latest/userguide/sysman-parameter-name-constraints.html">Requirements
        /// and constraints for parameter names</a> in the <i>AWS Systems Manager User Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.HierarchyTypeMismatchException">
        /// Parameter Store does not support changing a parameter type in a hierarchy. For example,
        /// you can't change a parameter from a <code>String</code> type to a <code>SecureString</code>
        /// type. You must create a new, unique parameter.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.IncompatiblePolicyException">
        /// There is a conflict in the policies specified for this parameter. You can't, for example,
        /// specify two Expiration policies for a parameter. Review your policies, and try again.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidAllowedPatternException">
        /// The request does not meet the regular expression requirement.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidKeyIdException">
        /// The query key ID is not valid.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidPolicyAttributeException">
        /// A policy attribute or its value is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidPolicyTypeException">
        /// The policy type is not supported. Parameter Store supports the following policy types:
        /// Expiration, ExpirationNotification, and NoChangeNotification.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.ParameterAlreadyExistsException">
        /// The parameter already exists. You can't create duplicate parameters.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.ParameterLimitExceededException">
        /// You have exceeded the number of parameters for this AWS account. Delete one or more
        /// parameters and try again.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.ParameterMaxVersionLimitExceededException">
        /// Parameter Store retains the 100 most recently created versions of a parameter. After
        /// this number of versions has been created, Parameter Store deletes the oldest version
        /// when a new one is created. However, if the oldest version has a <i>label</i> attached
        /// to it, Parameter Store will not delete the version and instead presents this error
        /// message:
        /// 
        ///  
        /// <para>
        ///  <code>An error occurred (ParameterMaxVersionLimitExceeded) when calling the PutParameter
        /// operation: You attempted to create a new version of <i>parameter-name</i> by calling
        /// the PutParameter API with the overwrite flag. Version <i>version-number</i>, the oldest
        /// version, can't be deleted because it has a label associated with it. Move the label
        /// to another version of the parameter, and try again.</code> 
        /// </para>
        ///  
        /// <para>
        /// This safeguard is to prevent parameter versions with mission critical labels assigned
        /// to them from being deleted. To continue creating new parameters, first move the label
        /// from the oldest version of the parameter to a newer one for use in your operations.
        /// For information about moving parameter labels, see <a href="http://docs.aws.amazon.com/systems-manager/latest/userguide/sysman-paramstore-labels.html#sysman-paramstore-labels-console-move">Move
        /// a parameter label (console)</a> or <a href="http://docs.aws.amazon.com/systems-manager/latest/userguide/sysman-paramstore-labels.html#sysman-paramstore-labels-cli-move">Move
        /// a parameter label (CLI) </a> in the <i>AWS Systems Manager User Guide</i>. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.ParameterPatternMismatchException">
        /// The parameter name is not valid.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.PoliciesLimitExceededException">
        /// You specified more than the maximum number of allowed policies for the parameter.
        /// The maximum is 10.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.TooManyUpdatesException">
        /// There are concurrent updates for a resource that supports one update at a time.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.UnsupportedParameterTypeException">
        /// The parameter type is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/PutParameter">REST API Reference for PutParameter Operation</seealso>
        public virtual Task<PutParameterResponse> PutParameterAsync(PutParameterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutParameterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutParameterResponseUnmarshaller.Instance;

            return InvokeAsync<PutParameterResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RegisterDefaultPatchBaseline

        internal virtual RegisterDefaultPatchBaselineResponse RegisterDefaultPatchBaseline(RegisterDefaultPatchBaselineRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RegisterDefaultPatchBaselineRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RegisterDefaultPatchBaselineResponseUnmarshaller.Instance;

            return Invoke<RegisterDefaultPatchBaselineResponse>(request, options);
        }



        /// <summary>
        /// Defines the default patch baseline for the relevant operating system.
        /// 
        ///  
        /// <para>
        /// To reset the AWS predefined patch baseline as the default, specify the full patch
        /// baseline ARN as the baseline ID value. For example, for CentOS, specify <code>arn:aws:ssm:us-east-2:733109147000:patchbaseline/pb-0574b43a65ea646ed</code>
        /// instead of <code>pb-0574b43a65ea646ed</code>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RegisterDefaultPatchBaseline service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RegisterDefaultPatchBaseline service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.DoesNotExistException">
        /// Error returned when the ID specified for a resource, such as a maintenance window
        /// or Patch baseline, doesn't exist.
        /// 
        ///  
        /// <para>
        /// For information about resource quotas in Systems Manager, see <a href="http://docs.aws.amazon.com/general/latest/gr/ssm.html#limits_ssm">Systems
        /// Manager service quotas</a> in the <i>AWS General Reference</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidResourceIdException">
        /// The resource ID is not valid. Verify that you entered the correct ID and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/RegisterDefaultPatchBaseline">REST API Reference for RegisterDefaultPatchBaseline Operation</seealso>
        public virtual Task<RegisterDefaultPatchBaselineResponse> RegisterDefaultPatchBaselineAsync(RegisterDefaultPatchBaselineRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RegisterDefaultPatchBaselineRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RegisterDefaultPatchBaselineResponseUnmarshaller.Instance;

            return InvokeAsync<RegisterDefaultPatchBaselineResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RegisterPatchBaselineForPatchGroup

        internal virtual RegisterPatchBaselineForPatchGroupResponse RegisterPatchBaselineForPatchGroup(RegisterPatchBaselineForPatchGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RegisterPatchBaselineForPatchGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RegisterPatchBaselineForPatchGroupResponseUnmarshaller.Instance;

            return Invoke<RegisterPatchBaselineForPatchGroupResponse>(request, options);
        }



        /// <summary>
        /// Registers a patch baseline for a patch group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RegisterPatchBaselineForPatchGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RegisterPatchBaselineForPatchGroup service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.AlreadyExistsException">
        /// Error returned if an attempt is made to register a patch group with a patch baseline
        /// that is already registered with a different patch baseline.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.DoesNotExistException">
        /// Error returned when the ID specified for a resource, such as a maintenance window
        /// or Patch baseline, doesn't exist.
        /// 
        ///  
        /// <para>
        /// For information about resource quotas in Systems Manager, see <a href="http://docs.aws.amazon.com/general/latest/gr/ssm.html#limits_ssm">Systems
        /// Manager service quotas</a> in the <i>AWS General Reference</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidResourceIdException">
        /// The resource ID is not valid. Verify that you entered the correct ID and try again.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.ResourceLimitExceededException">
        /// Error returned when the caller has exceeded the default resource quotas. For example,
        /// too many maintenance windows or patch baselines have been created.
        /// 
        ///  
        /// <para>
        /// For information about resource quotas in Systems Manager, see <a href="http://docs.aws.amazon.com/general/latest/gr/ssm.html#limits_ssm">Systems
        /// Manager service quotas</a> in the <i>AWS General Reference</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/RegisterPatchBaselineForPatchGroup">REST API Reference for RegisterPatchBaselineForPatchGroup Operation</seealso>
        public virtual Task<RegisterPatchBaselineForPatchGroupResponse> RegisterPatchBaselineForPatchGroupAsync(RegisterPatchBaselineForPatchGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RegisterPatchBaselineForPatchGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RegisterPatchBaselineForPatchGroupResponseUnmarshaller.Instance;

            return InvokeAsync<RegisterPatchBaselineForPatchGroupResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RegisterTargetWithMaintenanceWindow

        internal virtual RegisterTargetWithMaintenanceWindowResponse RegisterTargetWithMaintenanceWindow(RegisterTargetWithMaintenanceWindowRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RegisterTargetWithMaintenanceWindowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RegisterTargetWithMaintenanceWindowResponseUnmarshaller.Instance;

            return Invoke<RegisterTargetWithMaintenanceWindowResponse>(request, options);
        }



        /// <summary>
        /// Registers a target with a maintenance window.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RegisterTargetWithMaintenanceWindow service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RegisterTargetWithMaintenanceWindow service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.DoesNotExistException">
        /// Error returned when the ID specified for a resource, such as a maintenance window
        /// or Patch baseline, doesn't exist.
        /// 
        ///  
        /// <para>
        /// For information about resource quotas in Systems Manager, see <a href="http://docs.aws.amazon.com/general/latest/gr/ssm.html#limits_ssm">Systems
        /// Manager service quotas</a> in the <i>AWS General Reference</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.IdempotentParameterMismatchException">
        /// Error returned when an idempotent operation is retried and the parameters don't match
        /// the original call to the API with the same idempotency token.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.ResourceLimitExceededException">
        /// Error returned when the caller has exceeded the default resource quotas. For example,
        /// too many maintenance windows or patch baselines have been created.
        /// 
        ///  
        /// <para>
        /// For information about resource quotas in Systems Manager, see <a href="http://docs.aws.amazon.com/general/latest/gr/ssm.html#limits_ssm">Systems
        /// Manager service quotas</a> in the <i>AWS General Reference</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/RegisterTargetWithMaintenanceWindow">REST API Reference for RegisterTargetWithMaintenanceWindow Operation</seealso>
        public virtual Task<RegisterTargetWithMaintenanceWindowResponse> RegisterTargetWithMaintenanceWindowAsync(RegisterTargetWithMaintenanceWindowRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RegisterTargetWithMaintenanceWindowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RegisterTargetWithMaintenanceWindowResponseUnmarshaller.Instance;

            return InvokeAsync<RegisterTargetWithMaintenanceWindowResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RegisterTaskWithMaintenanceWindow

        internal virtual RegisterTaskWithMaintenanceWindowResponse RegisterTaskWithMaintenanceWindow(RegisterTaskWithMaintenanceWindowRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RegisterTaskWithMaintenanceWindowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RegisterTaskWithMaintenanceWindowResponseUnmarshaller.Instance;

            return Invoke<RegisterTaskWithMaintenanceWindowResponse>(request, options);
        }



        /// <summary>
        /// Adds a new task to a maintenance window.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RegisterTaskWithMaintenanceWindow service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RegisterTaskWithMaintenanceWindow service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.DoesNotExistException">
        /// Error returned when the ID specified for a resource, such as a maintenance window
        /// or Patch baseline, doesn't exist.
        /// 
        ///  
        /// <para>
        /// For information about resource quotas in Systems Manager, see <a href="http://docs.aws.amazon.com/general/latest/gr/ssm.html#limits_ssm">Systems
        /// Manager service quotas</a> in the <i>AWS General Reference</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.FeatureNotAvailableException">
        /// You attempted to register a LAMBDA or STEP_FUNCTIONS task in a region where the corresponding
        /// service is not available.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.IdempotentParameterMismatchException">
        /// Error returned when an idempotent operation is retried and the parameters don't match
        /// the original call to the API with the same idempotency token.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.ResourceLimitExceededException">
        /// Error returned when the caller has exceeded the default resource quotas. For example,
        /// too many maintenance windows or patch baselines have been created.
        /// 
        ///  
        /// <para>
        /// For information about resource quotas in Systems Manager, see <a href="http://docs.aws.amazon.com/general/latest/gr/ssm.html#limits_ssm">Systems
        /// Manager service quotas</a> in the <i>AWS General Reference</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/RegisterTaskWithMaintenanceWindow">REST API Reference for RegisterTaskWithMaintenanceWindow Operation</seealso>
        public virtual Task<RegisterTaskWithMaintenanceWindowResponse> RegisterTaskWithMaintenanceWindowAsync(RegisterTaskWithMaintenanceWindowRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RegisterTaskWithMaintenanceWindowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RegisterTaskWithMaintenanceWindowResponseUnmarshaller.Instance;

            return InvokeAsync<RegisterTaskWithMaintenanceWindowResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RemoveTagsFromResource

        internal virtual RemoveTagsFromResourceResponse RemoveTagsFromResource(RemoveTagsFromResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RemoveTagsFromResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RemoveTagsFromResourceResponseUnmarshaller.Instance;

            return Invoke<RemoveTagsFromResourceResponse>(request, options);
        }



        /// <summary>
        /// Removes tag keys from the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemoveTagsFromResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RemoveTagsFromResource service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidResourceIdException">
        /// The resource ID is not valid. Verify that you entered the correct ID and try again.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidResourceTypeException">
        /// The resource type is not valid. For example, if you are attempting to tag an instance,
        /// the instance must be a registered, managed instance.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.TooManyUpdatesException">
        /// There are concurrent updates for a resource that supports one update at a time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/RemoveTagsFromResource">REST API Reference for RemoveTagsFromResource Operation</seealso>
        public virtual Task<RemoveTagsFromResourceResponse> RemoveTagsFromResourceAsync(RemoveTagsFromResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RemoveTagsFromResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RemoveTagsFromResourceResponseUnmarshaller.Instance;

            return InvokeAsync<RemoveTagsFromResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ResetServiceSetting

        internal virtual ResetServiceSettingResponse ResetServiceSetting(ResetServiceSettingRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ResetServiceSettingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ResetServiceSettingResponseUnmarshaller.Instance;

            return Invoke<ResetServiceSettingResponse>(request, options);
        }



        /// <summary>
        /// <code>ServiceSetting</code> is an account-level setting for an AWS service. This
        /// setting defines how a user interacts with or uses a service or a feature of a service.
        /// For example, if an AWS service charges money to the account based on feature or service
        /// usage, then the AWS service team might create a default setting of "false". This means
        /// the user can't use this feature unless they change the setting to "true" and intentionally
        /// opt in for a paid feature.
        /// 
        ///  
        /// <para>
        /// Services map a <code>SettingId</code> object to a setting value. AWS services teams
        /// define the default value for a <code>SettingId</code>. You can't create a new <code>SettingId</code>,
        /// but you can overwrite the default value if you have the <code>ssm:UpdateServiceSetting</code>
        /// permission for the setting. Use the <a>GetServiceSetting</a> API action to view the
        /// current value. Use the <a>UpdateServiceSetting</a> API action to change the default
        /// setting. 
        /// </para>
        ///  
        /// <para>
        /// Reset the service setting for the account to the default value as provisioned by the
        /// AWS service team. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ResetServiceSetting service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ResetServiceSetting service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.ServiceSettingNotFoundException">
        /// The specified service setting was not found. Either the service name or the setting
        /// has not been provisioned by the AWS service team.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.TooManyUpdatesException">
        /// There are concurrent updates for a resource that supports one update at a time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/ResetServiceSetting">REST API Reference for ResetServiceSetting Operation</seealso>
        public virtual Task<ResetServiceSettingResponse> ResetServiceSettingAsync(ResetServiceSettingRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ResetServiceSettingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ResetServiceSettingResponseUnmarshaller.Instance;

            return InvokeAsync<ResetServiceSettingResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ResumeSession

        internal virtual ResumeSessionResponse ResumeSession(ResumeSessionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ResumeSessionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ResumeSessionResponseUnmarshaller.Instance;

            return Invoke<ResumeSessionResponse>(request, options);
        }



        /// <summary>
        /// Reconnects a session to an instance after it has been disconnected. Connections can
        /// be resumed for disconnected sessions, but not terminated sessions.
        /// 
        ///  <note> 
        /// <para>
        /// This command is primarily for use by client machines to automatically reconnect during
        /// intermittent network issues. It is not intended for any other use.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ResumeSession service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ResumeSession service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.DoesNotExistException">
        /// Error returned when the ID specified for a resource, such as a maintenance window
        /// or Patch baseline, doesn't exist.
        /// 
        ///  
        /// <para>
        /// For information about resource quotas in Systems Manager, see <a href="http://docs.aws.amazon.com/general/latest/gr/ssm.html#limits_ssm">Systems
        /// Manager service quotas</a> in the <i>AWS General Reference</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/ResumeSession">REST API Reference for ResumeSession Operation</seealso>
        public virtual Task<ResumeSessionResponse> ResumeSessionAsync(ResumeSessionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ResumeSessionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ResumeSessionResponseUnmarshaller.Instance;

            return InvokeAsync<ResumeSessionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  SendAutomationSignal

        internal virtual SendAutomationSignalResponse SendAutomationSignal(SendAutomationSignalRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SendAutomationSignalRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SendAutomationSignalResponseUnmarshaller.Instance;

            return Invoke<SendAutomationSignalResponse>(request, options);
        }



        /// <summary>
        /// Sends a signal to an Automation execution to change the current behavior or status
        /// of the execution.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SendAutomationSignal service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SendAutomationSignal service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.AutomationExecutionNotFoundException">
        /// There is no automation execution information for the requested automation execution
        /// ID.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.AutomationStepNotFoundException">
        /// The specified step name and execution ID don't exist. Verify the information and try
        /// again.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidAutomationSignalException">
        /// The signal is not valid for the current Automation execution.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/SendAutomationSignal">REST API Reference for SendAutomationSignal Operation</seealso>
        public virtual Task<SendAutomationSignalResponse> SendAutomationSignalAsync(SendAutomationSignalRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SendAutomationSignalRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SendAutomationSignalResponseUnmarshaller.Instance;

            return InvokeAsync<SendAutomationSignalResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  SendCommand

        internal virtual SendCommandResponse SendCommand(SendCommandRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SendCommandRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SendCommandResponseUnmarshaller.Instance;

            return Invoke<SendCommandResponse>(request, options);
        }


        /// <summary>
        /// Runs commands on one or more managed instances.
        /// </summary>
        /// <param name="documentName">Required. The name of the Systems Manager document to run. This can be a public document or a custom document.</param>
        /// <param name="instanceIds">The IDs of the instances where the command should run. Specifying instance IDs is most useful when you are targeting a limited number of instances, though you can specify up to 50 IDs. To target a larger number of instances, or if you prefer not to list individual instance IDs, we recommend using the <code>Targets</code> option instead. Using <code>Targets</code>, which accepts tag key-value pairs to identify the instances to send commands to, you can a send command to tens, hundreds, or thousands of instances at once. For more information about how to use targets, see <a href="https://docs.aws.amazon.com/systems-manager/latest/userguide/send-commands-multiple.html">Using targets and rate controls to send commands to a fleet</a> in the <i>AWS Systems Manager User Guide</i>.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SendCommand service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.DuplicateInstanceIdException">
        /// You cannot specify an instance ID in more than one association.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidDocumentException">
        /// The specified document does not exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidDocumentVersionException">
        /// The document version is not valid or does not exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidInstanceIdException">
        /// The following problems can cause this exception:
        /// 
        ///  
        /// <para>
        /// You do not have permission to access the instance.
        /// </para>
        ///  
        /// <para>
        /// SSM Agent is not running. Verify that SSM Agent is running.
        /// </para>
        ///  
        /// <para>
        /// SSM Agent is not registered with the SSM endpoint. Try reinstalling SSM Agent.
        /// </para>
        ///  
        /// <para>
        /// The instance is not in valid state. Valid states are: Running, Pending, Stopped, Stopping.
        /// Invalid states are: Shutting-down and Terminated.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidNotificationConfigException">
        /// One or more configuration items is not valid. Verify that a valid Amazon Resource
        /// Name (ARN) was provided for an Amazon SNS topic.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidOutputFolderException">
        /// The S3 bucket does not exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidParametersException">
        /// You must specify values for all required parameters in the Systems Manager document.
        /// You can only supply values to parameters defined in the Systems Manager document.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidRoleException">
        /// The role name can't contain invalid characters. Also verify that you specified an
        /// IAM role for notifications that includes the required trust policy. For information
        /// about configuring the IAM role for Run Command notifications, see <a href="https://docs.aws.amazon.com/systems-manager/latest/userguide/rc-sns-notifications.html">Configuring
        /// Amazon SNS Notifications for Run Command</a> in the <i>AWS Systems Manager User Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.MaxDocumentSizeExceededException">
        /// The size limit of a document is 64 KB.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.UnsupportedPlatformTypeException">
        /// The document does not support the platform type of the given instance ID(s). For example,
        /// you sent an document for a Windows instance to a Linux instance.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/SendCommand">REST API Reference for SendCommand Operation</seealso>
        public virtual Task<SendCommandResponse> SendCommandAsync(string documentName, List<string> instanceIds, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new SendCommandRequest();
            request.DocumentName = documentName;
            request.InstanceIds = instanceIds;
            return SendCommandAsync(request, cancellationToken);
        }



        /// <summary>
        /// Runs commands on one or more managed instances.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SendCommand service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SendCommand service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.DuplicateInstanceIdException">
        /// You cannot specify an instance ID in more than one association.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidDocumentException">
        /// The specified document does not exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidDocumentVersionException">
        /// The document version is not valid or does not exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidInstanceIdException">
        /// The following problems can cause this exception:
        /// 
        ///  
        /// <para>
        /// You do not have permission to access the instance.
        /// </para>
        ///  
        /// <para>
        /// SSM Agent is not running. Verify that SSM Agent is running.
        /// </para>
        ///  
        /// <para>
        /// SSM Agent is not registered with the SSM endpoint. Try reinstalling SSM Agent.
        /// </para>
        ///  
        /// <para>
        /// The instance is not in valid state. Valid states are: Running, Pending, Stopped, Stopping.
        /// Invalid states are: Shutting-down and Terminated.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidNotificationConfigException">
        /// One or more configuration items is not valid. Verify that a valid Amazon Resource
        /// Name (ARN) was provided for an Amazon SNS topic.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidOutputFolderException">
        /// The S3 bucket does not exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidParametersException">
        /// You must specify values for all required parameters in the Systems Manager document.
        /// You can only supply values to parameters defined in the Systems Manager document.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidRoleException">
        /// The role name can't contain invalid characters. Also verify that you specified an
        /// IAM role for notifications that includes the required trust policy. For information
        /// about configuring the IAM role for Run Command notifications, see <a href="https://docs.aws.amazon.com/systems-manager/latest/userguide/rc-sns-notifications.html">Configuring
        /// Amazon SNS Notifications for Run Command</a> in the <i>AWS Systems Manager User Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.MaxDocumentSizeExceededException">
        /// The size limit of a document is 64 KB.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.UnsupportedPlatformTypeException">
        /// The document does not support the platform type of the given instance ID(s). For example,
        /// you sent an document for a Windows instance to a Linux instance.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/SendCommand">REST API Reference for SendCommand Operation</seealso>
        public virtual Task<SendCommandResponse> SendCommandAsync(SendCommandRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SendCommandRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SendCommandResponseUnmarshaller.Instance;

            return InvokeAsync<SendCommandResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StartAssociationsOnce

        internal virtual StartAssociationsOnceResponse StartAssociationsOnce(StartAssociationsOnceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartAssociationsOnceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartAssociationsOnceResponseUnmarshaller.Instance;

            return Invoke<StartAssociationsOnceResponse>(request, options);
        }



        /// <summary>
        /// Use this API action to run an association immediately and only one time. This action
        /// can be helpful when troubleshooting associations.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartAssociationsOnce service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartAssociationsOnce service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.AssociationDoesNotExistException">
        /// The specified association does not exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidAssociationException">
        /// The association is not valid or does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/StartAssociationsOnce">REST API Reference for StartAssociationsOnce Operation</seealso>
        public virtual Task<StartAssociationsOnceResponse> StartAssociationsOnceAsync(StartAssociationsOnceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartAssociationsOnceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartAssociationsOnceResponseUnmarshaller.Instance;

            return InvokeAsync<StartAssociationsOnceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StartAutomationExecution

        internal virtual StartAutomationExecutionResponse StartAutomationExecution(StartAutomationExecutionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartAutomationExecutionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartAutomationExecutionResponseUnmarshaller.Instance;

            return Invoke<StartAutomationExecutionResponse>(request, options);
        }



        /// <summary>
        /// Initiates execution of an Automation document.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartAutomationExecution service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartAutomationExecution service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.AutomationDefinitionNotFoundException">
        /// An Automation document with the specified name could not be found.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.AutomationDefinitionVersionNotFoundException">
        /// An Automation document with the specified name and version could not be found.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.AutomationExecutionLimitExceededException">
        /// The number of simultaneously running Automation executions exceeded the allowable
        /// limit.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.IdempotentParameterMismatchException">
        /// Error returned when an idempotent operation is retried and the parameters don't match
        /// the original call to the API with the same idempotency token.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidAutomationExecutionParametersException">
        /// The supplied parameters for invoking the specified Automation document are incorrect.
        /// For example, they may not match the set of parameters permitted for the specified
        /// Automation document.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidTargetException">
        /// The target is not valid or does not exist. It might not be configured for Systems
        /// Manager or you might not have permission to perform the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/StartAutomationExecution">REST API Reference for StartAutomationExecution Operation</seealso>
        public virtual Task<StartAutomationExecutionResponse> StartAutomationExecutionAsync(StartAutomationExecutionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartAutomationExecutionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartAutomationExecutionResponseUnmarshaller.Instance;

            return InvokeAsync<StartAutomationExecutionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StartChangeRequestExecution

        internal virtual StartChangeRequestExecutionResponse StartChangeRequestExecution(StartChangeRequestExecutionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartChangeRequestExecutionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartChangeRequestExecutionResponseUnmarshaller.Instance;

            return Invoke<StartChangeRequestExecutionResponse>(request, options);
        }



        /// <summary>
        /// Creates a change request for Change Manager. The runbooks (Automation documents) specified
        /// in the change request run only after all required approvals for the change request
        /// have been received.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartChangeRequestExecution service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartChangeRequestExecution service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.AutomationDefinitionNotApprovedException">
        /// Indicates that the Change Manager change template used in the change request was rejected
        /// or is still in a pending state.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.AutomationDefinitionNotFoundException">
        /// An Automation document with the specified name could not be found.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.AutomationDefinitionVersionNotFoundException">
        /// An Automation document with the specified name and version could not be found.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.AutomationExecutionLimitExceededException">
        /// The number of simultaneously running Automation executions exceeded the allowable
        /// limit.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.IdempotentParameterMismatchException">
        /// Error returned when an idempotent operation is retried and the parameters don't match
        /// the original call to the API with the same idempotency token.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidAutomationExecutionParametersException">
        /// The supplied parameters for invoking the specified Automation document are incorrect.
        /// For example, they may not match the set of parameters permitted for the specified
        /// Automation document.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/StartChangeRequestExecution">REST API Reference for StartChangeRequestExecution Operation</seealso>
        public virtual Task<StartChangeRequestExecutionResponse> StartChangeRequestExecutionAsync(StartChangeRequestExecutionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartChangeRequestExecutionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartChangeRequestExecutionResponseUnmarshaller.Instance;

            return InvokeAsync<StartChangeRequestExecutionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StartSession

        internal virtual StartSessionResponse StartSession(StartSessionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartSessionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartSessionResponseUnmarshaller.Instance;

            return Invoke<StartSessionResponse>(request, options);
        }



        /// <summary>
        /// Initiates a connection to a target (for example, an instance) for a Session Manager
        /// session. Returns a URL and token that can be used to open a WebSocket connection for
        /// sending input and receiving outputs.
        /// 
        ///  <note> 
        /// <para>
        /// AWS CLI usage: <code>start-session</code> is an interactive command that requires
        /// the Session Manager plugin to be installed on the client machine making the call.
        /// For information, see <a href="https://docs.aws.amazon.com/systems-manager/latest/userguide/session-manager-working-with-install-plugin.html">Install
        /// the Session Manager plugin for the AWS CLI</a> in the <i>AWS Systems Manager User
        /// Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// AWS Tools for PowerShell usage: Start-SSMSession is not currently supported by AWS
        /// Tools for PowerShell on Windows local machines.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartSession service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartSession service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidDocumentException">
        /// The specified document does not exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.TargetNotConnectedException">
        /// The specified target instance for the session is not fully configured for use with
        /// Session Manager. For more information, see <a href="https://docs.aws.amazon.com/systems-manager/latest/userguide/session-manager-getting-started.html">Getting
        /// started with Session Manager</a> in the <i>AWS Systems Manager User Guide</i>. This
        /// error is also returned if you attempt to start a session on an instance that is located
        /// in a different account or Region
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/StartSession">REST API Reference for StartSession Operation</seealso>
        public virtual Task<StartSessionResponse> StartSessionAsync(StartSessionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartSessionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartSessionResponseUnmarshaller.Instance;

            return InvokeAsync<StartSessionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StopAutomationExecution

        internal virtual StopAutomationExecutionResponse StopAutomationExecution(StopAutomationExecutionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopAutomationExecutionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopAutomationExecutionResponseUnmarshaller.Instance;

            return Invoke<StopAutomationExecutionResponse>(request, options);
        }



        /// <summary>
        /// Stop an Automation that is currently running.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopAutomationExecution service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StopAutomationExecution service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.AutomationExecutionNotFoundException">
        /// There is no automation execution information for the requested automation execution
        /// ID.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidAutomationStatusUpdateException">
        /// The specified update status operation is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/StopAutomationExecution">REST API Reference for StopAutomationExecution Operation</seealso>
        public virtual Task<StopAutomationExecutionResponse> StopAutomationExecutionAsync(StopAutomationExecutionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopAutomationExecutionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopAutomationExecutionResponseUnmarshaller.Instance;

            return InvokeAsync<StopAutomationExecutionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  TerminateSession

        internal virtual TerminateSessionResponse TerminateSession(TerminateSessionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TerminateSessionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TerminateSessionResponseUnmarshaller.Instance;

            return Invoke<TerminateSessionResponse>(request, options);
        }



        /// <summary>
        /// Permanently ends a session and closes the data connection between the Session Manager
        /// client and SSM Agent on the instance. A terminated session cannot be resumed.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TerminateSession service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TerminateSession service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.DoesNotExistException">
        /// Error returned when the ID specified for a resource, such as a maintenance window
        /// or Patch baseline, doesn't exist.
        /// 
        ///  
        /// <para>
        /// For information about resource quotas in Systems Manager, see <a href="http://docs.aws.amazon.com/general/latest/gr/ssm.html#limits_ssm">Systems
        /// Manager service quotas</a> in the <i>AWS General Reference</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/TerminateSession">REST API Reference for TerminateSession Operation</seealso>
        public virtual Task<TerminateSessionResponse> TerminateSessionAsync(TerminateSessionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TerminateSessionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TerminateSessionResponseUnmarshaller.Instance;

            return InvokeAsync<TerminateSessionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateAssociation

        internal virtual UpdateAssociationResponse UpdateAssociation(UpdateAssociationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAssociationResponseUnmarshaller.Instance;

            return Invoke<UpdateAssociationResponse>(request, options);
        }



        /// <summary>
        /// Updates an association. You can update the association name and version, the document
        /// version, schedule, parameters, and Amazon S3 output. 
        /// 
        ///  
        /// <para>
        /// In order to call this API action, your IAM user account, group, or role must be configured
        /// with permission to call the <a>DescribeAssociation</a> API action. If you don't have
        /// permission to call DescribeAssociation, then you receive the following error: <code>An
        /// error occurred (AccessDeniedException) when calling the UpdateAssociation operation:
        /// User: &lt;user_arn&gt; is not authorized to perform: ssm:DescribeAssociation on resource:
        /// &lt;resource_arn&gt;</code> 
        /// </para>
        ///  <important> 
        /// <para>
        /// When you update an association, the association immediately runs against the specified
        /// targets.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAssociation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateAssociation service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.AssociationDoesNotExistException">
        /// The specified association does not exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.AssociationVersionLimitExceededException">
        /// You have reached the maximum number versions allowed for an association. Each association
        /// has a limit of 1,000 versions.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidAssociationVersionException">
        /// The version you specified is not valid. Use ListAssociationVersions to view all versions
        /// of an association according to the association ID. Or, use the <code>$LATEST</code>
        /// parameter to view the latest version of the association.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidDocumentException">
        /// The specified document does not exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidDocumentVersionException">
        /// The document version is not valid or does not exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidOutputLocationException">
        /// The output location is not valid or does not exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidParametersException">
        /// You must specify values for all required parameters in the Systems Manager document.
        /// You can only supply values to parameters defined in the Systems Manager document.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidScheduleException">
        /// The schedule is invalid. Verify your cron or rate expression and try again.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidTargetException">
        /// The target is not valid or does not exist. It might not be configured for Systems
        /// Manager or you might not have permission to perform the operation.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidUpdateException">
        /// The update is not valid.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.TooManyUpdatesException">
        /// There are concurrent updates for a resource that supports one update at a time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/UpdateAssociation">REST API Reference for UpdateAssociation Operation</seealso>
        public virtual Task<UpdateAssociationResponse> UpdateAssociationAsync(UpdateAssociationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAssociationResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateAssociationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateAssociationStatus

        internal virtual UpdateAssociationStatusResponse UpdateAssociationStatus(UpdateAssociationStatusRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateAssociationStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAssociationStatusResponseUnmarshaller.Instance;

            return Invoke<UpdateAssociationStatusResponse>(request, options);
        }



        /// <summary>
        /// Updates the status of the Systems Manager document associated with the specified instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAssociationStatus service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateAssociationStatus service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.AssociationDoesNotExistException">
        /// The specified association does not exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidDocumentException">
        /// The specified document does not exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidInstanceIdException">
        /// The following problems can cause this exception:
        /// 
        ///  
        /// <para>
        /// You do not have permission to access the instance.
        /// </para>
        ///  
        /// <para>
        /// SSM Agent is not running. Verify that SSM Agent is running.
        /// </para>
        ///  
        /// <para>
        /// SSM Agent is not registered with the SSM endpoint. Try reinstalling SSM Agent.
        /// </para>
        ///  
        /// <para>
        /// The instance is not in valid state. Valid states are: Running, Pending, Stopped, Stopping.
        /// Invalid states are: Shutting-down and Terminated.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.StatusUnchangedException">
        /// The updated status is the same as the current status.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.TooManyUpdatesException">
        /// There are concurrent updates for a resource that supports one update at a time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/UpdateAssociationStatus">REST API Reference for UpdateAssociationStatus Operation</seealso>
        public virtual Task<UpdateAssociationStatusResponse> UpdateAssociationStatusAsync(UpdateAssociationStatusRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateAssociationStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAssociationStatusResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateAssociationStatusResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateDocument

        internal virtual UpdateDocumentResponse UpdateDocument(UpdateDocumentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateDocumentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDocumentResponseUnmarshaller.Instance;

            return Invoke<UpdateDocumentResponse>(request, options);
        }



        /// <summary>
        /// Updates one or more values for an SSM document.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDocument service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateDocument service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.DocumentVersionLimitExceededException">
        /// The document has too many versions. Delete one or more document versions and try again.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.DuplicateDocumentContentException">
        /// The content of the association document matches another document. Change the content
        /// of the document and try again.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.DuplicateDocumentVersionNameException">
        /// The version name has already been used in this document. Specify a different version
        /// name, and then try again.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidDocumentContentException">
        /// The content for the document is not valid.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidDocumentException">
        /// The specified document does not exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidDocumentOperationException">
        /// You attempted to delete a document while it is still shared. You must stop sharing
        /// the document before you can delete it.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidDocumentSchemaVersionException">
        /// The version of the document schema is not supported.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidDocumentVersionException">
        /// The document version is not valid or does not exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.MaxDocumentSizeExceededException">
        /// The size limit of a document is 64 KB.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/UpdateDocument">REST API Reference for UpdateDocument Operation</seealso>
        public virtual Task<UpdateDocumentResponse> UpdateDocumentAsync(UpdateDocumentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateDocumentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDocumentResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateDocumentResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateDocumentDefaultVersion

        internal virtual UpdateDocumentDefaultVersionResponse UpdateDocumentDefaultVersion(UpdateDocumentDefaultVersionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateDocumentDefaultVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDocumentDefaultVersionResponseUnmarshaller.Instance;

            return Invoke<UpdateDocumentDefaultVersionResponse>(request, options);
        }



        /// <summary>
        /// Set the default version of a document.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDocumentDefaultVersion service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateDocumentDefaultVersion service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidDocumentException">
        /// The specified document does not exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidDocumentSchemaVersionException">
        /// The version of the document schema is not supported.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidDocumentVersionException">
        /// The document version is not valid or does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/UpdateDocumentDefaultVersion">REST API Reference for UpdateDocumentDefaultVersion Operation</seealso>
        public virtual Task<UpdateDocumentDefaultVersionResponse> UpdateDocumentDefaultVersionAsync(UpdateDocumentDefaultVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateDocumentDefaultVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDocumentDefaultVersionResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateDocumentDefaultVersionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateDocumentMetadata

        internal virtual UpdateDocumentMetadataResponse UpdateDocumentMetadata(UpdateDocumentMetadataRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateDocumentMetadataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDocumentMetadataResponseUnmarshaller.Instance;

            return Invoke<UpdateDocumentMetadataResponse>(request, options);
        }



        /// <summary>
        /// Updates information related to approval reviews for a specific version of a document.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDocumentMetadata service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateDocumentMetadata service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidDocumentException">
        /// The specified document does not exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidDocumentOperationException">
        /// You attempted to delete a document while it is still shared. You must stop sharing
        /// the document before you can delete it.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidDocumentVersionException">
        /// The document version is not valid or does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/UpdateDocumentMetadata">REST API Reference for UpdateDocumentMetadata Operation</seealso>
        public virtual Task<UpdateDocumentMetadataResponse> UpdateDocumentMetadataAsync(UpdateDocumentMetadataRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateDocumentMetadataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDocumentMetadataResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateDocumentMetadataResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateMaintenanceWindow

        internal virtual UpdateMaintenanceWindowResponse UpdateMaintenanceWindow(UpdateMaintenanceWindowRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateMaintenanceWindowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateMaintenanceWindowResponseUnmarshaller.Instance;

            return Invoke<UpdateMaintenanceWindowResponse>(request, options);
        }



        /// <summary>
        /// Updates an existing maintenance window. Only specified parameters are modified.
        /// 
        ///  <note> 
        /// <para>
        /// The value you specify for <code>Duration</code> determines the specific end time for
        /// the maintenance window based on the time it begins. No maintenance window tasks are
        /// permitted to start after the resulting endtime minus the number of hours you specify
        /// for <code>Cutoff</code>. For example, if the maintenance window starts at 3 PM, the
        /// duration is three hours, and the value you specify for <code>Cutoff</code> is one
        /// hour, no maintenance window tasks can start after 5 PM.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateMaintenanceWindow service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateMaintenanceWindow service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.DoesNotExistException">
        /// Error returned when the ID specified for a resource, such as a maintenance window
        /// or Patch baseline, doesn't exist.
        /// 
        ///  
        /// <para>
        /// For information about resource quotas in Systems Manager, see <a href="http://docs.aws.amazon.com/general/latest/gr/ssm.html#limits_ssm">Systems
        /// Manager service quotas</a> in the <i>AWS General Reference</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/UpdateMaintenanceWindow">REST API Reference for UpdateMaintenanceWindow Operation</seealso>
        public virtual Task<UpdateMaintenanceWindowResponse> UpdateMaintenanceWindowAsync(UpdateMaintenanceWindowRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateMaintenanceWindowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateMaintenanceWindowResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateMaintenanceWindowResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateMaintenanceWindowTarget

        internal virtual UpdateMaintenanceWindowTargetResponse UpdateMaintenanceWindowTarget(UpdateMaintenanceWindowTargetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateMaintenanceWindowTargetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateMaintenanceWindowTargetResponseUnmarshaller.Instance;

            return Invoke<UpdateMaintenanceWindowTargetResponse>(request, options);
        }



        /// <summary>
        /// Modifies the target of an existing maintenance window. You can change the following:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Name
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Description
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Owner
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// IDs for an ID target
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Tags for a Tag target
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// From any supported tag type to another. The three supported tag types are ID target,
        /// Tag target, and resource group. For more information, see <a>Target</a>.
        /// </para>
        ///  </li> </ul> <note> 
        /// <para>
        /// If a parameter is null, then the corresponding field is not modified.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateMaintenanceWindowTarget service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateMaintenanceWindowTarget service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.DoesNotExistException">
        /// Error returned when the ID specified for a resource, such as a maintenance window
        /// or Patch baseline, doesn't exist.
        /// 
        ///  
        /// <para>
        /// For information about resource quotas in Systems Manager, see <a href="http://docs.aws.amazon.com/general/latest/gr/ssm.html#limits_ssm">Systems
        /// Manager service quotas</a> in the <i>AWS General Reference</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/UpdateMaintenanceWindowTarget">REST API Reference for UpdateMaintenanceWindowTarget Operation</seealso>
        public virtual Task<UpdateMaintenanceWindowTargetResponse> UpdateMaintenanceWindowTargetAsync(UpdateMaintenanceWindowTargetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateMaintenanceWindowTargetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateMaintenanceWindowTargetResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateMaintenanceWindowTargetResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateMaintenanceWindowTask

        internal virtual UpdateMaintenanceWindowTaskResponse UpdateMaintenanceWindowTask(UpdateMaintenanceWindowTaskRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateMaintenanceWindowTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateMaintenanceWindowTaskResponseUnmarshaller.Instance;

            return Invoke<UpdateMaintenanceWindowTaskResponse>(request, options);
        }



        /// <summary>
        /// Modifies a task assigned to a maintenance window. You can't change the task type,
        /// but you can change the following values:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// TaskARN. For example, you can change a RUN_COMMAND task from AWS-RunPowerShellScript
        /// to AWS-RunShellScript.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ServiceRoleArn
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// TaskInvocationParameters
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Priority
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MaxConcurrency
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MaxErrors
        /// </para>
        ///  </li> </ul> <note> 
        /// <para>
        /// One or more targets must be specified for maintenance window Run Command-type tasks.
        /// Depending on the task, targets are optional for other maintenance window task types
        /// (Automation, AWS Lambda, and AWS Step Functions). For more information about running
        /// tasks that do not specify targets, see see <a href="https://docs.aws.amazon.com/systems-manager/latest/userguide/maintenance-windows-targetless-tasks.html">Registering
        /// maintenance window tasks without targets</a> in the <i>AWS Systems Manager User Guide</i>.
        /// </para>
        ///  </note> 
        /// <para>
        /// If the value for a parameter in <code>UpdateMaintenanceWindowTask</code> is null,
        /// then the corresponding field is not modified. If you set <code>Replace</code> to true,
        /// then all fields required by the <a>RegisterTaskWithMaintenanceWindow</a> action are
        /// required for this request. Optional fields that aren't specified are set to null.
        /// </para>
        ///  <important> 
        /// <para>
        /// When you update a maintenance window task that has options specified in <code>TaskInvocationParameters</code>,
        /// you must provide again all the <code>TaskInvocationParameters</code> values that you
        /// want to retain. The values you do not specify again are removed. For example, suppose
        /// that when you registered a Run Command task, you specified <code>TaskInvocationParameters</code>
        /// values for <code>Comment</code>, <code>NotificationConfig</code>, and <code>OutputS3BucketName</code>.
        /// If you update the maintenance window task and specify only a different <code>OutputS3BucketName</code>
        /// value, the values for <code>Comment</code> and <code>NotificationConfig</code> are
        /// removed.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateMaintenanceWindowTask service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateMaintenanceWindowTask service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.DoesNotExistException">
        /// Error returned when the ID specified for a resource, such as a maintenance window
        /// or Patch baseline, doesn't exist.
        /// 
        ///  
        /// <para>
        /// For information about resource quotas in Systems Manager, see <a href="http://docs.aws.amazon.com/general/latest/gr/ssm.html#limits_ssm">Systems
        /// Manager service quotas</a> in the <i>AWS General Reference</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/UpdateMaintenanceWindowTask">REST API Reference for UpdateMaintenanceWindowTask Operation</seealso>
        public virtual Task<UpdateMaintenanceWindowTaskResponse> UpdateMaintenanceWindowTaskAsync(UpdateMaintenanceWindowTaskRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateMaintenanceWindowTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateMaintenanceWindowTaskResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateMaintenanceWindowTaskResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateManagedInstanceRole

        internal virtual UpdateManagedInstanceRoleResponse UpdateManagedInstanceRole(UpdateManagedInstanceRoleRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateManagedInstanceRoleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateManagedInstanceRoleResponseUnmarshaller.Instance;

            return Invoke<UpdateManagedInstanceRoleResponse>(request, options);
        }



        /// <summary>
        /// Changes the Amazon Identity and Access Management (IAM) role that is assigned to the
        /// on-premises instance or virtual machines (VM). IAM roles are first assigned to these
        /// hybrid instances during the activation process. For more information, see <a>CreateActivation</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateManagedInstanceRole service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateManagedInstanceRole service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidInstanceIdException">
        /// The following problems can cause this exception:
        /// 
        ///  
        /// <para>
        /// You do not have permission to access the instance.
        /// </para>
        ///  
        /// <para>
        /// SSM Agent is not running. Verify that SSM Agent is running.
        /// </para>
        ///  
        /// <para>
        /// SSM Agent is not registered with the SSM endpoint. Try reinstalling SSM Agent.
        /// </para>
        ///  
        /// <para>
        /// The instance is not in valid state. Valid states are: Running, Pending, Stopped, Stopping.
        /// Invalid states are: Shutting-down and Terminated.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/UpdateManagedInstanceRole">REST API Reference for UpdateManagedInstanceRole Operation</seealso>
        public virtual Task<UpdateManagedInstanceRoleResponse> UpdateManagedInstanceRoleAsync(UpdateManagedInstanceRoleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateManagedInstanceRoleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateManagedInstanceRoleResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateManagedInstanceRoleResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateOpsItem

        internal virtual UpdateOpsItemResponse UpdateOpsItem(UpdateOpsItemRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateOpsItemRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateOpsItemResponseUnmarshaller.Instance;

            return Invoke<UpdateOpsItemResponse>(request, options);
        }



        /// <summary>
        /// Edit or change an OpsItem. You must have permission in AWS Identity and Access Management
        /// (IAM) to update an OpsItem. For more information, see <a href="https://docs.aws.amazon.com/systems-manager/latest/userguide/OpsCenter-getting-started.html">Getting
        /// started with OpsCenter</a> in the <i>AWS Systems Manager User Guide</i>.
        /// 
        ///  
        /// <para>
        /// Operations engineers and IT professionals use OpsCenter to view, investigate, and
        /// remediate operational issues impacting the performance and health of their AWS resources.
        /// For more information, see <a href="https://docs.aws.amazon.com/systems-manager/latest/userguide/OpsCenter.html">AWS
        /// Systems Manager OpsCenter</a> in the <i>AWS Systems Manager User Guide</i>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateOpsItem service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateOpsItem service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.OpsItemAlreadyExistsException">
        /// The OpsItem already exists.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.OpsItemInvalidParameterException">
        /// A specified parameter argument isn't valid. Verify the available arguments and try
        /// again.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.OpsItemLimitExceededException">
        /// The request caused OpsItems to exceed one or more quotas. For information about OpsItem
        /// quotas, see <a href="https://docs.aws.amazon.com/systems-manager/latest/userguide/OpsCenter-learn-more.html#OpsCenter-learn-more-limits">What
        /// are the resource limits for OpsCenter?</a>.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.OpsItemNotFoundException">
        /// The specified OpsItem ID doesn't exist. Verify the ID and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/UpdateOpsItem">REST API Reference for UpdateOpsItem Operation</seealso>
        public virtual Task<UpdateOpsItemResponse> UpdateOpsItemAsync(UpdateOpsItemRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateOpsItemRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateOpsItemResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateOpsItemResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateOpsMetadata

        internal virtual UpdateOpsMetadataResponse UpdateOpsMetadata(UpdateOpsMetadataRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateOpsMetadataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateOpsMetadataResponseUnmarshaller.Instance;

            return Invoke<UpdateOpsMetadataResponse>(request, options);
        }



        /// <summary>
        /// Systems Manager calls this API action when you edit OpsMetadata in Application Manager.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateOpsMetadata service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateOpsMetadata service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.OpsMetadataInvalidArgumentException">
        /// One of the arguments passed is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.OpsMetadataKeyLimitExceededException">
        /// The OpsMetadata object exceeds the maximum number of OpsMetadata keys that you can
        /// assign to an application in Application Manager.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.OpsMetadataNotFoundException">
        /// The OpsMetadata object does not exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.OpsMetadataTooManyUpdatesException">
        /// The system is processing too many concurrent updates. Wait a few moments and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/UpdateOpsMetadata">REST API Reference for UpdateOpsMetadata Operation</seealso>
        public virtual Task<UpdateOpsMetadataResponse> UpdateOpsMetadataAsync(UpdateOpsMetadataRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateOpsMetadataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateOpsMetadataResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateOpsMetadataResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdatePatchBaseline

        internal virtual UpdatePatchBaselineResponse UpdatePatchBaseline(UpdatePatchBaselineRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdatePatchBaselineRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdatePatchBaselineResponseUnmarshaller.Instance;

            return Invoke<UpdatePatchBaselineResponse>(request, options);
        }



        /// <summary>
        /// Modifies an existing patch baseline. Fields not specified in the request are left
        /// unchanged.
        /// 
        ///  <note> 
        /// <para>
        /// For information about valid key and value pairs in <code>PatchFilters</code> for each
        /// supported operating system type, see <a href="http://docs.aws.amazon.com/systems-manager/latest/APIReference/API_PatchFilter.html">PatchFilter</a>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdatePatchBaseline service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdatePatchBaseline service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.DoesNotExistException">
        /// Error returned when the ID specified for a resource, such as a maintenance window
        /// or Patch baseline, doesn't exist.
        /// 
        ///  
        /// <para>
        /// For information about resource quotas in Systems Manager, see <a href="http://docs.aws.amazon.com/general/latest/gr/ssm.html#limits_ssm">Systems
        /// Manager service quotas</a> in the <i>AWS General Reference</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/UpdatePatchBaseline">REST API Reference for UpdatePatchBaseline Operation</seealso>
        public virtual Task<UpdatePatchBaselineResponse> UpdatePatchBaselineAsync(UpdatePatchBaselineRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdatePatchBaselineRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdatePatchBaselineResponseUnmarshaller.Instance;

            return InvokeAsync<UpdatePatchBaselineResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateResourceDataSync

        internal virtual UpdateResourceDataSyncResponse UpdateResourceDataSync(UpdateResourceDataSyncRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateResourceDataSyncRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateResourceDataSyncResponseUnmarshaller.Instance;

            return Invoke<UpdateResourceDataSyncResponse>(request, options);
        }



        /// <summary>
        /// Update a resource data sync. After you create a resource data sync for a Region, you
        /// can't change the account options for that sync. For example, if you create a sync
        /// in the us-east-2 (Ohio) Region and you choose the Include only the current account
        /// option, you can't edit that sync later and choose the Include all accounts from my
        /// AWS Organizations configuration option. Instead, you must delete the first resource
        /// data sync, and create a new one.
        /// 
        ///  <note> 
        /// <para>
        /// This API action only supports a resource data sync that was created with a SyncFromSource
        /// <code>SyncType</code>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateResourceDataSync service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateResourceDataSync service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.ResourceDataSyncConflictException">
        /// Another <code>UpdateResourceDataSync</code> request is being processed. Wait a few
        /// minutes and try again.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.ResourceDataSyncInvalidConfigurationException">
        /// The specified sync configuration is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.ResourceDataSyncNotFoundException">
        /// The specified sync name was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/UpdateResourceDataSync">REST API Reference for UpdateResourceDataSync Operation</seealso>
        public virtual Task<UpdateResourceDataSyncResponse> UpdateResourceDataSyncAsync(UpdateResourceDataSyncRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateResourceDataSyncRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateResourceDataSyncResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateResourceDataSyncResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateServiceSetting

        internal virtual UpdateServiceSettingResponse UpdateServiceSetting(UpdateServiceSettingRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateServiceSettingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateServiceSettingResponseUnmarshaller.Instance;

            return Invoke<UpdateServiceSettingResponse>(request, options);
        }



        /// <summary>
        /// <code>ServiceSetting</code> is an account-level setting for an AWS service. This
        /// setting defines how a user interacts with or uses a service or a feature of a service.
        /// For example, if an AWS service charges money to the account based on feature or service
        /// usage, then the AWS service team might create a default setting of "false". This means
        /// the user can't use this feature unless they change the setting to "true" and intentionally
        /// opt in for a paid feature.
        /// 
        ///  
        /// <para>
        /// Services map a <code>SettingId</code> object to a setting value. AWS services teams
        /// define the default value for a <code>SettingId</code>. You can't create a new <code>SettingId</code>,
        /// but you can overwrite the default value if you have the <code>ssm:UpdateServiceSetting</code>
        /// permission for the setting. Use the <a>GetServiceSetting</a> API action to view the
        /// current value. Or, use the <a>ResetServiceSetting</a> to change the value back to
        /// the original value defined by the AWS service team.
        /// </para>
        ///  
        /// <para>
        /// Update the service setting for the account. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateServiceSetting service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateServiceSetting service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.ServiceSettingNotFoundException">
        /// The specified service setting was not found. Either the service name or the setting
        /// has not been provisioned by the AWS service team.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.TooManyUpdatesException">
        /// There are concurrent updates for a resource that supports one update at a time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/UpdateServiceSetting">REST API Reference for UpdateServiceSetting Operation</seealso>
        public virtual Task<UpdateServiceSettingResponse> UpdateServiceSettingAsync(UpdateServiceSettingRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateServiceSettingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateServiceSettingResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateServiceSettingResponse>(request, options, cancellationToken);
        }

        #endregion
        
    }
}