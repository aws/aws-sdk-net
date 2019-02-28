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
    /// Amazon EC2 instance or on-premises machine in your hybrid environment that has been
    /// configured for Systems Manager.
    /// </para>
    ///  
    /// <para>
    /// This reference is intended to be used with the <a href="http://docs.aws.amazon.com/systems-manager/latest/userguide/">AWS
    /// Systems Manager User Guide</a>.
    /// </para>
    ///  
    /// <para>
    /// To get started, verify prerequisites and configure managed instances. For more information,
    /// see <a href="http://docs.aws.amazon.com/systems-manager/latest/userguide/systems-manager-setting-up.html">Systems
    /// Manager Prerequisites</a> in the <i>AWS Systems Manager User Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// For information about other API actions you can perform on Amazon EC2 instances, see
    /// the <a href="http://docs.aws.amazon.com/AWSEC2/latest/APIReference/">Amazon EC2 API
    /// Reference</a>. For information about how to use a Query API, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/APIReference/making-api-requests.html">Making
    /// API Requests</a>. 
    /// </para>
    /// </summary>
    public partial class AmazonSimpleSystemsManagementClient : AmazonServiceClient, IAmazonSimpleSystemsManagement
    {
        private static IServiceMetadata serviceMetadata = new AmazonSimpleSystemsManagementMetadata();
        
        #region Constructors

#if CORECLR
    
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

#endif

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
        /// Initiates the asynchronous execution of the AddTagsToResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AddTagsToResource operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
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
        /// SSM Agent is not running. On managed instances and Linux instances, verify that the
        /// SSM Agent is running. On EC2 Windows instances, verify that the EC2Config service
        /// is running.
        /// </para>
        ///  
        /// <para>
        /// SSM Agent or EC2Config service is not registered to the SSM endpoint. Try reinstalling
        /// SSM Agent or EC2Config service.
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
        /// SSM Agent is not running. On managed instances and Linux instances, verify that the
        /// SSM Agent is running. On EC2 Windows instances, verify that the EC2Config service
        /// is running.
        /// </para>
        ///  
        /// <para>
        /// SSM Agent or EC2Config service is not registered to the SSM endpoint. Try reinstalling
        /// SSM Agent or EC2Config service.
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
        /// Initiates the asynchronous execution of the CancelCommand operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CancelCommand operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
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
        /// Initiates the asynchronous execution of the CancelMaintenanceWindowExecution operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CancelMaintenanceWindowExecution operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
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
        /// Initiates the asynchronous execution of the CreateActivation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateActivation operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
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
        /// <param name="instanceId">The instance ID.</param>
        /// <param name="name">The name of the SSM document that contains the configuration information for the instance. You can specify Command, Policy, or Automation documents. You can specify AWS-predefined documents, documents you created, or a document that is shared with you from another account. For SSM documents that are shared with you from other AWS accounts, you must specify the complete SSM document ARN, in the following format:  <code>arn:<i>partition</i>:ssm:<i>region</i>:<i>account-id</i>:document/<i>document-name</i> </code>  For example:  <code>arn:aws:ssm:us-east-2:12345678912:document/My-Shared-Document</code>  For AWS-predefined documents and SSM documents you created in your account, you only need to specify the document name. For example, <code>AWS-ApplyPatchBaseline</code> or <code>My-Document</code>.</param>
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
        /// SSM Agent is not running. On managed instances and Linux instances, verify that the
        /// SSM Agent is running. On EC2 Windows instances, verify that the EC2Config service
        /// is running.
        /// </para>
        ///  
        /// <para>
        /// SSM Agent or EC2Config service is not registered to the SSM endpoint. Try reinstalling
        /// SSM Agent or EC2Config service.
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
        /// The target is not valid or does not exist. It might not be configured for EC2 Systems
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
        /// Initiates the asynchronous execution of the CreateAssociation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateAssociation operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
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
        /// Initiates the asynchronous execution of the CreateAssociationBatch operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateAssociationBatch operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
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
        /// Creates a Systems Manager document.
        /// 
        ///  
        /// <para>
        /// After you create a document, you can use CreateAssociation to associate it with one
        /// or more running instances.
        /// </para>
        /// </summary>
        /// <param name="content">A valid JSON or YAML string.</param>
        /// <param name="name">A name for the Systems Manager document. <important> Do not use the following to begin the names of documents you create. They are reserved by AWS for use as document prefixes: <ul> <li>  <code>aws</code>  </li> <li>  <code>amazon</code>  </li> <li>  <code>amzn</code>  </li> </ul> </important></param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateDocument service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.DocumentAlreadyExistsException">
        /// The specified document already exists.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.DocumentLimitExceededException">
        /// You can have at most 200 active Systems Manager documents.
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
        /// Initiates the asynchronous execution of the CreateDocument operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDocument operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
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
        /// Initiates the asynchronous execution of the CreateMaintenanceWindow operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateMaintenanceWindow operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/CreateMaintenanceWindow">REST API Reference for CreateMaintenanceWindow Operation</seealso>
        public virtual Task<CreateMaintenanceWindowResponse> CreateMaintenanceWindowAsync(CreateMaintenanceWindowRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateMaintenanceWindowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateMaintenanceWindowResponseUnmarshaller.Instance;

            return InvokeAsync<CreateMaintenanceWindowResponse>(request, options, cancellationToken);
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
        /// Initiates the asynchronous execution of the CreatePatchBaseline operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreatePatchBaseline operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
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
        /// Initiates the asynchronous execution of the CreateResourceDataSync operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateResourceDataSync operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
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
        /// Initiates the asynchronous execution of the DeleteActivation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteActivation operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
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
        /// SSM Agent is not running. On managed instances and Linux instances, verify that the
        /// SSM Agent is running. On EC2 Windows instances, verify that the EC2Config service
        /// is running.
        /// </para>
        ///  
        /// <para>
        /// SSM Agent or EC2Config service is not registered to the SSM endpoint. Try reinstalling
        /// SSM Agent or EC2Config service.
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
        /// Initiates the asynchronous execution of the DeleteAssociation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteAssociation operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
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
        /// Initiates the asynchronous execution of the DeleteDocument operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDocument operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
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
        /// Initiates the asynchronous execution of the DeleteInventory operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteInventory operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
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
        /// Initiates the asynchronous execution of the DeleteMaintenanceWindow operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteMaintenanceWindow operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DeleteMaintenanceWindow">REST API Reference for DeleteMaintenanceWindow Operation</seealso>
        public virtual Task<DeleteMaintenanceWindowResponse> DeleteMaintenanceWindowAsync(DeleteMaintenanceWindowRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteMaintenanceWindowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteMaintenanceWindowResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteMaintenanceWindowResponse>(request, options, cancellationToken);
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
        /// Initiates the asynchronous execution of the DeleteParameter operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteParameter operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
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
        /// Initiates the asynchronous execution of the DeleteParameters operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteParameters operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
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
        /// Initiates the asynchronous execution of the DeletePatchBaseline operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeletePatchBaseline operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
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
        /// Initiates the asynchronous execution of the DeleteResourceDataSync operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteResourceDataSync operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
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
        /// Initiates the asynchronous execution of the DeregisterManagedInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeregisterManagedInstance operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
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
        /// Initiates the asynchronous execution of the DeregisterPatchBaselineForPatchGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeregisterPatchBaselineForPatchGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
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
        /// Initiates the asynchronous execution of the DeregisterTargetFromMaintenanceWindow operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeregisterTargetFromMaintenanceWindow operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
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
        /// Initiates the asynchronous execution of the DeregisterTaskFromMaintenanceWindow operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeregisterTaskFromMaintenanceWindow operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
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
        /// Initiates the asynchronous execution of the DescribeActivations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeActivations operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
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
        /// SSM Agent is not running. On managed instances and Linux instances, verify that the
        /// SSM Agent is running. On EC2 Windows instances, verify that the EC2Config service
        /// is running.
        /// </para>
        ///  
        /// <para>
        /// SSM Agent or EC2Config service is not registered to the SSM endpoint. Try reinstalling
        /// SSM Agent or EC2Config service.
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
        /// Initiates the asynchronous execution of the DescribeAssociation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAssociation operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
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
        /// Initiates the asynchronous execution of the DescribeAssociationExecutions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAssociationExecutions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
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
        /// Initiates the asynchronous execution of the DescribeAssociationExecutionTargets operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAssociationExecutionTargets operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
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
        /// Initiates the asynchronous execution of the DescribeAutomationExecutions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAutomationExecutions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
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
        /// Initiates the asynchronous execution of the DescribeAutomationStepExecutions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAutomationStepExecutions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
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
        /// Initiates the asynchronous execution of the DescribeAvailablePatches operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAvailablePatches operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
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
        /// Initiates the asynchronous execution of the DescribeDocument operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDocument operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
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
        /// Initiates the asynchronous execution of the DescribeDocumentPermission operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDocumentPermission operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
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
        /// Initiates the asynchronous execution of the DescribeEffectiveInstanceAssociations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeEffectiveInstanceAssociations operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
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
        /// Initiates the asynchronous execution of the DescribeEffectivePatchesForPatchBaseline operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeEffectivePatchesForPatchBaseline operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
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
        /// Initiates the asynchronous execution of the DescribeInstanceAssociationsStatus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeInstanceAssociationsStatus operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
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
        /// Describes one or more of your instances. You can use this to get information about
        /// instances like the operating system platform, the SSM Agent version (Linux), status
        /// etc. If you specify one or more instance IDs, it returns information for those instances.
        /// If you do not specify instance IDs, it returns information for all your instances.
        /// If you specify an instance ID that is not valid or an instance that you do not own,
        /// you receive an error. 
        /// 
        ///  <note> 
        /// <para>
        /// The IamRole field for this API action is the Amazon Identity and Access Management
        /// (IAM) role assigned to on-premises instances. This call does not return the IAM role
        /// for Amazon EC2 instances.
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
        /// SSM Agent is not running. On managed instances and Linux instances, verify that the
        /// SSM Agent is running. On EC2 Windows instances, verify that the EC2Config service
        /// is running.
        /// </para>
        ///  
        /// <para>
        /// SSM Agent or EC2Config service is not registered to the SSM endpoint. Try reinstalling
        /// SSM Agent or EC2Config service.
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
        /// Initiates the asynchronous execution of the DescribeInstanceInformation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeInstanceInformation operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
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
        /// Initiates the asynchronous execution of the DescribeInstancePatches operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeInstancePatches operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
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
        /// Initiates the asynchronous execution of the DescribeInstancePatchStates operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeInstancePatchStates operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
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
        /// Initiates the asynchronous execution of the DescribeInstancePatchStatesForPatchGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeInstancePatchStatesForPatchGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
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
        /// Initiates the asynchronous execution of the DescribeInventoryDeletions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeInventoryDeletions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
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
        /// Initiates the asynchronous execution of the DescribeMaintenanceWindowExecutions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeMaintenanceWindowExecutions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
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
        /// Initiates the asynchronous execution of the DescribeMaintenanceWindowExecutionTaskInvocations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeMaintenanceWindowExecutionTaskInvocations operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
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
        /// Initiates the asynchronous execution of the DescribeMaintenanceWindowExecutionTasks operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeMaintenanceWindowExecutionTasks operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
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
        /// Initiates the asynchronous execution of the DescribeMaintenanceWindows operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeMaintenanceWindows operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
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
        /// Initiates the asynchronous execution of the DescribeMaintenanceWindowSchedule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeMaintenanceWindowSchedule operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
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
        /// Initiates the asynchronous execution of the DescribeMaintenanceWindowsForTarget operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeMaintenanceWindowsForTarget operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
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
        /// Initiates the asynchronous execution of the DescribeMaintenanceWindowTargets operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeMaintenanceWindowTargets operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
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
        /// Initiates the asynchronous execution of the DescribeMaintenanceWindowTasks operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeMaintenanceWindowTasks operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribeMaintenanceWindowTasks">REST API Reference for DescribeMaintenanceWindowTasks Operation</seealso>
        public virtual Task<DescribeMaintenanceWindowTasksResponse> DescribeMaintenanceWindowTasksAsync(DescribeMaintenanceWindowTasksRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeMaintenanceWindowTasksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeMaintenanceWindowTasksResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeMaintenanceWindowTasksResponse>(request, options, cancellationToken);
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
        /// Initiates the asynchronous execution of the DescribeParameters operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeParameters operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
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
        /// Initiates the asynchronous execution of the DescribePatchBaselines operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribePatchBaselines operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
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
        /// Initiates the asynchronous execution of the DescribePatchGroups operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribePatchGroups operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
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
        /// Initiates the asynchronous execution of the DescribePatchGroupState operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribePatchGroupState operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribePatchGroupState">REST API Reference for DescribePatchGroupState Operation</seealso>
        public virtual Task<DescribePatchGroupStateResponse> DescribePatchGroupStateAsync(DescribePatchGroupStateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribePatchGroupStateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribePatchGroupStateResponseUnmarshaller.Instance;

            return InvokeAsync<DescribePatchGroupStateResponse>(request, options, cancellationToken);
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
        /// Initiates the asynchronous execution of the DescribeSessions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeSessions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
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
        /// Initiates the asynchronous execution of the GetAutomationExecution operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetAutomationExecution operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/GetAutomationExecution">REST API Reference for GetAutomationExecution Operation</seealso>
        public virtual Task<GetAutomationExecutionResponse> GetAutomationExecutionAsync(GetAutomationExecutionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAutomationExecutionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAutomationExecutionResponseUnmarshaller.Instance;

            return InvokeAsync<GetAutomationExecutionResponse>(request, options, cancellationToken);
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
        /// Initiates the asynchronous execution of the GetCommandInvocation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetCommandInvocation operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
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
        /// Initiates the asynchronous execution of the GetConnectionStatus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetConnectionStatus operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
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
        /// Initiates the asynchronous execution of the GetDefaultPatchBaseline operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDefaultPatchBaseline operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
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
        /// Initiates the asynchronous execution of the GetDeployablePatchSnapshotForInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDeployablePatchSnapshotForInstance operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
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
        /// Initiates the asynchronous execution of the GetDocument operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDocument operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
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
        /// Initiates the asynchronous execution of the GetInventory operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetInventory operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
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
        /// Initiates the asynchronous execution of the GetInventorySchema operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetInventorySchema operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
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
        /// Initiates the asynchronous execution of the GetMaintenanceWindow operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetMaintenanceWindow operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
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
        /// Initiates the asynchronous execution of the GetMaintenanceWindowExecution operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetMaintenanceWindowExecution operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
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
        /// Initiates the asynchronous execution of the GetMaintenanceWindowExecutionTask operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetMaintenanceWindowExecutionTask operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
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
        /// Initiates the asynchronous execution of the GetMaintenanceWindowExecutionTaskInvocation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetMaintenanceWindowExecutionTaskInvocation operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
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
        /// Initiates the asynchronous execution of the GetMaintenanceWindowTask operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetMaintenanceWindowTask operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/GetMaintenanceWindowTask">REST API Reference for GetMaintenanceWindowTask Operation</seealso>
        public virtual Task<GetMaintenanceWindowTaskResponse> GetMaintenanceWindowTaskAsync(GetMaintenanceWindowTaskRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetMaintenanceWindowTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMaintenanceWindowTaskResponseUnmarshaller.Instance;

            return InvokeAsync<GetMaintenanceWindowTaskResponse>(request, options, cancellationToken);
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
        /// Initiates the asynchronous execution of the GetParameter operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetParameter operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
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
        /// Initiates the asynchronous execution of the GetParameterHistory operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetParameterHistory operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
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
        /// Initiates the asynchronous execution of the GetParameters operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetParameters operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
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
        /// Initiates the asynchronous execution of the GetParametersByPath operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetParametersByPath operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
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
        /// Initiates the asynchronous execution of the GetPatchBaseline operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetPatchBaseline operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
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
        /// Initiates the asynchronous execution of the GetPatchBaselineForPatchGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetPatchBaselineForPatchGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/GetPatchBaselineForPatchGroup">REST API Reference for GetPatchBaselineForPatchGroup Operation</seealso>
        public virtual Task<GetPatchBaselineForPatchGroupResponse> GetPatchBaselineForPatchGroupAsync(GetPatchBaselineForPatchGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetPatchBaselineForPatchGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPatchBaselineForPatchGroupResponseUnmarshaller.Instance;

            return InvokeAsync<GetPatchBaselineForPatchGroupResponse>(request, options, cancellationToken);
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
        /// Initiates the asynchronous execution of the LabelParameterVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the LabelParameterVersion operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
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
        /// Initiates the asynchronous execution of the ListAssociations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAssociations operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
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
        /// Initiates the asynchronous execution of the ListAssociationVersions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAssociationVersions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
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
        /// if a user executes SendCommand against three instances, then a command invocation
        /// is created for each requested instance ID. ListCommandInvocations provide status about
        /// command execution.
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
        /// SSM Agent is not running. On managed instances and Linux instances, verify that the
        /// SSM Agent is running. On EC2 Windows instances, verify that the EC2Config service
        /// is running.
        /// </para>
        ///  
        /// <para>
        /// SSM Agent or EC2Config service is not registered to the SSM endpoint. Try reinstalling
        /// SSM Agent or EC2Config service.
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
        /// if a user executes SendCommand against three instances, then a command invocation
        /// is created for each requested instance ID. ListCommandInvocations provide status about
        /// command execution.
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
        /// SSM Agent is not running. On managed instances and Linux instances, verify that the
        /// SSM Agent is running. On EC2 Windows instances, verify that the EC2Config service
        /// is running.
        /// </para>
        ///  
        /// <para>
        /// SSM Agent or EC2Config service is not registered to the SSM endpoint. Try reinstalling
        /// SSM Agent or EC2Config service.
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
        /// Initiates the asynchronous execution of the ListCommandInvocations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListCommandInvocations operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
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
        /// SSM Agent is not running. On managed instances and Linux instances, verify that the
        /// SSM Agent is running. On EC2 Windows instances, verify that the EC2Config service
        /// is running.
        /// </para>
        ///  
        /// <para>
        /// SSM Agent or EC2Config service is not registered to the SSM endpoint. Try reinstalling
        /// SSM Agent or EC2Config service.
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
        /// SSM Agent is not running. On managed instances and Linux instances, verify that the
        /// SSM Agent is running. On EC2 Windows instances, verify that the EC2Config service
        /// is running.
        /// </para>
        ///  
        /// <para>
        /// SSM Agent or EC2Config service is not registered to the SSM endpoint. Try reinstalling
        /// SSM Agent or EC2Config service.
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
        /// Initiates the asynchronous execution of the ListCommands operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListCommands operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
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
        /// Initiates the asynchronous execution of the ListComplianceItems operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListComplianceItems operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
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
        /// Initiates the asynchronous execution of the ListComplianceSummaries operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListComplianceSummaries operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/ListComplianceSummaries">REST API Reference for ListComplianceSummaries Operation</seealso>
        public virtual Task<ListComplianceSummariesResponse> ListComplianceSummariesAsync(ListComplianceSummariesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListComplianceSummariesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListComplianceSummariesResponseUnmarshaller.Instance;

            return InvokeAsync<ListComplianceSummariesResponse>(request, options, cancellationToken);
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
        /// Describes one or more of your Systems Manager documents.
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
        /// Initiates the asynchronous execution of the ListDocuments operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDocuments operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
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
        /// Initiates the asynchronous execution of the ListDocumentVersions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDocumentVersions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
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
        /// Initiates the asynchronous execution of the ListInventoryEntries operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListInventoryEntries operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/ListInventoryEntries">REST API Reference for ListInventoryEntries Operation</seealso>
        public virtual Task<ListInventoryEntriesResponse> ListInventoryEntriesAsync(ListInventoryEntriesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListInventoryEntriesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListInventoryEntriesResponseUnmarshaller.Instance;

            return InvokeAsync<ListInventoryEntriesResponse>(request, options, cancellationToken);
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
        /// Initiates the asynchronous execution of the ListResourceComplianceSummaries operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListResourceComplianceSummaries operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
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
        /// Initiates the asynchronous execution of the ListResourceDataSync operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListResourceDataSync operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
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
        /// Initiates the asynchronous execution of the ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
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
        /// Initiates the asynchronous execution of the ModifyDocumentPermission operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyDocumentPermission operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
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
        /// Initiates the asynchronous execution of the PutComplianceItems operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutComplianceItems operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
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
        /// Initiates the asynchronous execution of the PutInventory operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutInventory operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
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
        /// Initiates the asynchronous execution of the PutParameter operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutParameter operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
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
        /// Initiates the asynchronous execution of the RegisterDefaultPatchBaseline operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RegisterDefaultPatchBaseline operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
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
        /// Initiates the asynchronous execution of the RegisterPatchBaselineForPatchGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RegisterPatchBaselineForPatchGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
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
        /// Initiates the asynchronous execution of the RegisterTargetWithMaintenanceWindow operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RegisterTargetWithMaintenanceWindow operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
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
        /// Initiates the asynchronous execution of the RegisterTaskWithMaintenanceWindow operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RegisterTaskWithMaintenanceWindow operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
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
        /// Initiates the asynchronous execution of the RemoveTagsFromResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RemoveTagsFromResource operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/RemoveTagsFromResource">REST API Reference for RemoveTagsFromResource Operation</seealso>
        public virtual Task<RemoveTagsFromResourceResponse> RemoveTagsFromResourceAsync(RemoveTagsFromResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RemoveTagsFromResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RemoveTagsFromResourceResponseUnmarshaller.Instance;

            return InvokeAsync<RemoveTagsFromResourceResponse>(request, options, cancellationToken);
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
        /// Initiates the asynchronous execution of the ResumeSession operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ResumeSession operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
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
        /// Initiates the asynchronous execution of the SendAutomationSignal operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SendAutomationSignal operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
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
        /// Executes commands on one or more managed instances.
        /// </summary>
        /// <param name="documentName">Required. The name of the Systems Manager document to execute. This can be a public document or a custom document.</param>
        /// <param name="instanceIds">The instance IDs where the command should execute. You can specify a maximum of 50 IDs. If you prefer not to list individual instance IDs, you can instead send commands to a fleet of instances using the Targets parameter, which accepts EC2 tags. For more information about how to use targets, see <a href="http://docs.aws.amazon.com/systems-manager/latest/userguide/send-commands-multiple.html">Sending Commands to a Fleet</a> in the <i>AWS Systems Manager User Guide</i>.</param>
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
        /// SSM Agent is not running. On managed instances and Linux instances, verify that the
        /// SSM Agent is running. On EC2 Windows instances, verify that the EC2Config service
        /// is running.
        /// </para>
        ///  
        /// <para>
        /// SSM Agent or EC2Config service is not registered to the SSM endpoint. Try reinstalling
        /// SSM Agent or EC2Config service.
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
        /// about configuring the IAM role for Run Command notifications, see <a href="http://docs.aws.amazon.com/systems-manager/latest/userguide/rc-sns-notifications.html">Configuring
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
        /// Initiates the asynchronous execution of the SendCommand operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SendCommand operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
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
        /// Initiates the asynchronous execution of the StartAssociationsOnce operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartAssociationsOnce operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
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
        /// Initiates the asynchronous execution of the StartAutomationExecution operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartAutomationExecution operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/StartAutomationExecution">REST API Reference for StartAutomationExecution Operation</seealso>
        public virtual Task<StartAutomationExecutionResponse> StartAutomationExecutionAsync(StartAutomationExecutionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartAutomationExecutionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartAutomationExecutionResponseUnmarshaller.Instance;

            return InvokeAsync<StartAutomationExecutionResponse>(request, options, cancellationToken);
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
        /// Initiates the asynchronous execution of the StartSession operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartSession operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
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
        /// Initiates the asynchronous execution of the StopAutomationExecution operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopAutomationExecution operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
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
        /// Initiates the asynchronous execution of the TerminateSession operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TerminateSession operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
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
        /// Initiates the asynchronous execution of the UpdateAssociation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateAssociation operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
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
        /// Initiates the asynchronous execution of the UpdateAssociationStatus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateAssociationStatus operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
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
        /// Initiates the asynchronous execution of the UpdateDocument operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateDocument operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
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
        /// Initiates the asynchronous execution of the UpdateDocumentDefaultVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateDocumentDefaultVersion operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/UpdateDocumentDefaultVersion">REST API Reference for UpdateDocumentDefaultVersion Operation</seealso>
        public virtual Task<UpdateDocumentDefaultVersionResponse> UpdateDocumentDefaultVersionAsync(UpdateDocumentDefaultVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateDocumentDefaultVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDocumentDefaultVersionResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateDocumentDefaultVersionResponse>(request, options, cancellationToken);
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
        /// Initiates the asynchronous execution of the UpdateMaintenanceWindow operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateMaintenanceWindow operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
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
        /// Initiates the asynchronous execution of the UpdateMaintenanceWindowTarget operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateMaintenanceWindowTarget operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
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
        /// Initiates the asynchronous execution of the UpdateMaintenanceWindowTask operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateMaintenanceWindowTask operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
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
        /// Initiates the asynchronous execution of the UpdateManagedInstanceRole operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateManagedInstanceRole operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/UpdateManagedInstanceRole">REST API Reference for UpdateManagedInstanceRole Operation</seealso>
        public virtual Task<UpdateManagedInstanceRoleResponse> UpdateManagedInstanceRoleAsync(UpdateManagedInstanceRoleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateManagedInstanceRoleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateManagedInstanceRoleResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateManagedInstanceRoleResponse>(request, options, cancellationToken);
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
        /// Initiates the asynchronous execution of the UpdatePatchBaseline operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdatePatchBaseline operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/UpdatePatchBaseline">REST API Reference for UpdatePatchBaseline Operation</seealso>
        public virtual Task<UpdatePatchBaselineResponse> UpdatePatchBaselineAsync(UpdatePatchBaselineRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdatePatchBaselineRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdatePatchBaselineResponseUnmarshaller.Instance;

            return InvokeAsync<UpdatePatchBaselineResponse>(request, options, cancellationToken);
        }

        #endregion
        
    }
}