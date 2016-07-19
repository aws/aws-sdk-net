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

using Amazon.SimpleSystemsManagement.Model;
using Amazon.SimpleSystemsManagement.Model.Internal.MarshallTransformations;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.SimpleSystemsManagement
{
    /// <summary>
    /// Implementation for accessing SimpleSystemsManagement
    ///
    /// This is the Amazon EC2 Simple Systems Manager (SSM) API Reference. SSM enables you
    /// to remotely manage the configuration of your Amazon EC2 instances, virtual machines
    /// (VMs), or servers in your on-premises environment or in an environment provided by
    /// other cloud providers using scripts, commands, or the Amazon EC2 console. SSM includes
    /// an on-demand solution called <i>Amazon EC2 Run Command</i> and a lightweight instance
    /// configuration solution called <i>SSM Config</i>. 
    /// 
    ///  
    /// <para>
    /// This references is intended to be used with the EC2 Run Command User Guide for <a
    /// href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/execute-remote-commands.html">Linux</a>
    /// or <a href="http://docs.aws.amazon.com/AWSEC2/latest/WindowsGuide/execute-remote-commands.html">Windows</a>.
    /// </para>
    ///  <note> 
    /// <para>
    /// You must register your on-premises servers and VMs through an activation process before
    /// you can configure them using Run Command. Registered servers and VMs are called <i>managed
    /// instances</i>. For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/managed-instances.html">Setting
    /// Up Run Command On Managed Instances (On-Premises Servers and VMs) on Linux</a> or
    /// <a href="http://docs.aws.amazon.com/AWSEC2/latest/WindowsGuide/managed-instances.html">Setting
    /// Up Run Command On Managed Instances (On-Premises Servers and VMs) on Windows</a>.
    /// </para>
    ///  </note> 
    /// <para>
    ///  <b>Run Command</b> 
    /// </para>
    ///  
    /// <para>
    /// Run Command provides an on-demand experience for executing commands. You can use pre-defined
    /// SSM documents to perform the actions listed later in this section, or you can create
    /// your own documents. With these documents, you can remotely configure your instances
    /// by sending commands using the <b>Commands</b> page in the <a href="http://console.aws.amazon.com/ec2/">Amazon
    /// EC2 console</a>, <a href="http://docs.aws.amazon.com/powershell/latest/reference/items/Amazon_Simple_Systems_Management_cmdlets.html">AWS
    /// Tools for Windows PowerShell</a>, the <a href="http://docs.aws.amazon.com/cli/latest/reference/ssm/index.html">AWS
    /// CLI</a>, or AWS SDKs.
    /// </para>
    ///  
    /// <para>
    /// Run Command reports the status of the command execution for each instance targeted
    /// by a command. You can also audit the command execution to understand who executed
    /// commands, when, and what changes were made. By switching between different SSM documents,
    /// you can quickly configure your instances with different types of commands. To get
    /// started with Run Command, verify that your environment meets the prerequisites for
    /// remotely running commands on EC2 instances (<a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/remote-commands-prereq.html">Linux</a>
    /// or <a href="http://docs.aws.amazon.com/AWSEC2/latest/WindowsGuide/remote-commands-prereq.html">Windows</a>).
    /// 
    /// </para>
    ///   
    /// <para>
    ///  <b>SSM Config</b> 
    /// </para>
    ///  
    /// <para>
    /// SSM Config is a lightweight instance configuration solution. SSM Config is currently
    /// only available for Windows instances. With SSM Config, you can specify a setup configuration
    /// for your instances. SSM Config is similar to EC2 User Data, which is another way of
    /// running one-time scripts or applying settings during instance launch. SSM Config is
    /// an extension of this capability. Using SSM documents, you can specify which actions
    /// the system should perform on your instances, including which applications to install,
    /// which AWS Directory Service directory to join, which Microsoft PowerShell modules
    /// to install, etc. If an instance is missing one or more of these configurations, the
    /// system makes those changes. By default, the system checks every five minutes to see
    /// if there is a new configuration to apply as defined in a new SSM document. If so,
    /// the system updates the instances accordingly. In this way, you can remotely maintain
    /// a consistent configuration baseline on your instances. SSM Config is available using
    /// the AWS CLI or the AWS Tools for Windows PowerShell. For more information, see <a
    /// href="http://docs.aws.amazon.com/AWSEC2/latest/WindowsGuide/ec2-configuration-manage.html">Managing
    /// Windows Instance Configuration</a>.
    /// </para>
    ///  
    /// <para>
    /// SSM Config and Run Command include the following pre-defined documents.
    /// </para>
    ///  
    /// <para>
    ///  <b>Linux</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <b>AWS-RunShellScript</b> to run shell scripts
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>AWS-UpdateSSMAgent</b> to update the Amazon SSM agent
    /// </para>
    ///  </li> </ul>  
    /// <para>
    ///  <b>Windows</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <b>AWS-JoinDirectoryServiceDomain</b> to join an AWS Directory
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>AWS-RunPowerShellScript</b> to run PowerShell commands or scripts
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>AWS-UpdateEC2Config</b> to update the EC2Config service
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>AWS-ConfigureWindowsUpdate</b> to configure Windows Update settings
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>AWS-InstallApplication</b> to install, repair, or uninstall software using an
    /// MSI package
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>AWS-InstallPowerShellModule</b> to install PowerShell modules 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>AWS-ConfigureCloudWatch</b> to configure Amazon CloudWatch Logs to monitor applications
    /// and systems
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>AWS-ListWindowsInventory</b> to collect information about an EC2 instance running
    /// in Windows.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>AWS-FindWindowsUpdates</b> to scan an instance and determines which updates are
    /// missing.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>AWS-InstallMissingWindowsUpdates</b> to install missing updates on your EC2 instance.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>AWS-InstallSpecificWindowsUpdates</b> to install one or more specific updates.
    /// </para>
    ///  </li> </ul> <important> 
    /// <para>
    /// The commands or scripts specified in SSM documents run with administrative privilege
    /// on your instances because the Amazon SSM agent runs as root on Linux and the EC2Config
    /// service runs in the Local System account on Windows. If a user has permission to execute
    /// any of the pre-defined SSM documents (any document that begins with AWS-*) then that
    /// user also has administrator access to the instance. Delegate access to Run Command
    /// and SSM Config judiciously. This becomes extremely important if you create your own
    /// SSM documents. Amazon Web Services does not provide guidance about how to create secure
    /// SSM documents. You create SSM documents and delegate access to Run Command at your
    /// own risk. As a security best practice, we recommend that you assign access to "AWS-*"
    /// documents, especially the AWS-RunShellScript document on Linux and the AWS-RunPowerShellScript
    /// document on Windows, to trusted administrators only. You can create SSM documents
    /// for specific tasks and delegate access to non-administrators.
    /// </para>
    ///  </important> 
    /// <para>
    /// For information about creating and sharing SSM documents, see the following topics
    /// in the SSM User Guide: 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/create-ssm-doc.html">Creating
    /// SSM Documents</a> and <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ssm-sharing.html">Sharing
    /// SSM Documents</a> (Linux)
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="http://docs.aws.amazon.com/AWSEC2/latest/WindowsGuide/create-ssm-doc.html">Creating
    /// SSM Documents</a> and <a href="http://docs.aws.amazon.com/AWSEC2/latest/WindowsGuide/ssm-sharing.html">Sharing
    /// SSM Documents</a> (Windows)
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class AmazonSimpleSystemsManagementClient : AmazonServiceClient, IAmazonSimpleSystemsManagement
    {
        
        #region Constructors

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

        internal AddTagsToResourceResponse AddTagsToResource(AddTagsToResourceRequest request)
        {
            var marshaller = new AddTagsToResourceRequestMarshaller();
            var unmarshaller = AddTagsToResourceResponseUnmarshaller.Instance;

            return Invoke<AddTagsToResourceRequest,AddTagsToResourceResponse>(request, marshaller, unmarshaller);
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
        public Task<AddTagsToResourceResponse> AddTagsToResourceAsync(AddTagsToResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new AddTagsToResourceRequestMarshaller();
            var unmarshaller = AddTagsToResourceResponseUnmarshaller.Instance;

            return InvokeAsync<AddTagsToResourceRequest,AddTagsToResourceResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CancelCommand

        internal CancelCommandResponse CancelCommand(CancelCommandRequest request)
        {
            var marshaller = new CancelCommandRequestMarshaller();
            var unmarshaller = CancelCommandResponseUnmarshaller.Instance;

            return Invoke<CancelCommandRequest,CancelCommandResponse>(request, marshaller, unmarshaller);
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
        /// The instance is not in valid state. Valid states are: Running, Pending, Stopped, Stopping.
        /// Invalid states are: Shutting-down and Terminated.
        /// </exception>
        public Task<CancelCommandResponse> CancelCommandAsync(string commandId, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
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
        /// The instance is not in valid state. Valid states are: Running, Pending, Stopped, Stopping.
        /// Invalid states are: Shutting-down and Terminated.
        /// </exception>
        public Task<CancelCommandResponse> CancelCommandAsync(string commandId, List<string> instanceIds, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
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
        public Task<CancelCommandResponse> CancelCommandAsync(CancelCommandRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CancelCommandRequestMarshaller();
            var unmarshaller = CancelCommandResponseUnmarshaller.Instance;

            return InvokeAsync<CancelCommandRequest,CancelCommandResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateActivation

        internal CreateActivationResponse CreateActivation(CreateActivationRequest request)
        {
            var marshaller = new CreateActivationRequestMarshaller();
            var unmarshaller = CreateActivationResponseUnmarshaller.Instance;

            return Invoke<CreateActivationRequest,CreateActivationResponse>(request, marshaller, unmarshaller);
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
        public Task<CreateActivationResponse> CreateActivationAsync(CreateActivationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateActivationRequestMarshaller();
            var unmarshaller = CreateActivationResponseUnmarshaller.Instance;

            return InvokeAsync<CreateActivationRequest,CreateActivationResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateAssociation

        internal CreateAssociationResponse CreateAssociation(CreateAssociationRequest request)
        {
            var marshaller = new CreateAssociationRequestMarshaller();
            var unmarshaller = CreateAssociationResponseUnmarshaller.Instance;

            return Invoke<CreateAssociationRequest,CreateAssociationResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Associates the specified SSM document with the specified instance.
        /// 
        ///  
        /// <para>
        /// When you associate an SSM document with an instance, the configuration agent on the
        /// instance processes the document and configures the instance as specified.
        /// </para>
        ///  
        /// <para>
        /// If you associate a document with an instance that already has an associated document,
        /// the system throws the AssociationAlreadyExists exception.
        /// </para>
        /// </summary>
        /// <param name="instanceId">The instance ID.</param>
        /// <param name="name">The name of the SSM document.</param>
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
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidInstanceIdException">
        /// The instance is not in valid state. Valid states are: Running, Pending, Stopped, Stopping.
        /// Invalid states are: Shutting-down and Terminated.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidParametersException">
        /// You must specify values for all required parameters in the SSM document. You can only
        /// supply values to parameters defined in the SSM document.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.UnsupportedPlatformTypeException">
        /// The document does not support the platform type of the given instance ID(s). For example,
        /// you sent an SSM document for a Windows instance to a Linux instance.
        /// </exception>
        public Task<CreateAssociationResponse> CreateAssociationAsync(string instanceId, string name, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
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
        public Task<CreateAssociationResponse> CreateAssociationAsync(CreateAssociationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateAssociationRequestMarshaller();
            var unmarshaller = CreateAssociationResponseUnmarshaller.Instance;

            return InvokeAsync<CreateAssociationRequest,CreateAssociationResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateAssociationBatch

        internal CreateAssociationBatchResponse CreateAssociationBatch(CreateAssociationBatchRequest request)
        {
            var marshaller = new CreateAssociationBatchRequestMarshaller();
            var unmarshaller = CreateAssociationBatchResponseUnmarshaller.Instance;

            return Invoke<CreateAssociationBatchRequest,CreateAssociationBatchResponse>(request, marshaller, unmarshaller);
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
        public Task<CreateAssociationBatchResponse> CreateAssociationBatchAsync(CreateAssociationBatchRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateAssociationBatchRequestMarshaller();
            var unmarshaller = CreateAssociationBatchResponseUnmarshaller.Instance;

            return InvokeAsync<CreateAssociationBatchRequest,CreateAssociationBatchResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateDocument

        internal CreateDocumentResponse CreateDocument(CreateDocumentRequest request)
        {
            var marshaller = new CreateDocumentRequestMarshaller();
            var unmarshaller = CreateDocumentResponseUnmarshaller.Instance;

            return Invoke<CreateDocumentRequest,CreateDocumentResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Creates an SSM document.
        /// 
        ///  
        /// <para>
        /// After you create an SSM document, you can use CreateAssociation to associate it with
        /// one or more running instances.
        /// </para>
        /// </summary>
        /// <param name="content">A valid JSON string.</param>
        /// <param name="name">A name for the SSM document.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateDocument service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.DocumentAlreadyExistsException">
        /// The specified SSM document already exists.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.DocumentLimitExceededException">
        /// You can have at most 100 active SSM documents.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidDocumentContentException">
        /// The content for the SSM document is not valid.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.MaxDocumentSizeExceededException">
        /// The size limit of an SSM document is 64 KB.
        /// </exception>
        public Task<CreateDocumentResponse> CreateDocumentAsync(string content, string name, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
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
        public Task<CreateDocumentResponse> CreateDocumentAsync(CreateDocumentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateDocumentRequestMarshaller();
            var unmarshaller = CreateDocumentResponseUnmarshaller.Instance;

            return InvokeAsync<CreateDocumentRequest,CreateDocumentResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteActivation

        internal DeleteActivationResponse DeleteActivation(DeleteActivationRequest request)
        {
            var marshaller = new DeleteActivationRequestMarshaller();
            var unmarshaller = DeleteActivationResponseUnmarshaller.Instance;

            return Invoke<DeleteActivationRequest,DeleteActivationResponse>(request, marshaller, unmarshaller);
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
        public Task<DeleteActivationResponse> DeleteActivationAsync(DeleteActivationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteActivationRequestMarshaller();
            var unmarshaller = DeleteActivationResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteActivationRequest,DeleteActivationResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteAssociation

        internal DeleteAssociationResponse DeleteAssociation(DeleteAssociationRequest request)
        {
            var marshaller = new DeleteAssociationRequestMarshaller();
            var unmarshaller = DeleteAssociationResponseUnmarshaller.Instance;

            return Invoke<DeleteAssociationRequest,DeleteAssociationResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Disassociates the specified SSM document from the specified instance.
        /// 
        ///  
        /// <para>
        /// When you disassociate an SSM document from an instance, it does not change the configuration
        /// of the instance. To change the configuration state of an instance after you disassociate
        /// a document, you must create a new document with the desired configuration and associate
        /// it with the instance.
        /// </para>
        /// </summary>
        /// <param name="instanceId">The ID of the instance.</param>
        /// <param name="name">The name of the SSM document.</param>
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
        /// The instance is not in valid state. Valid states are: Running, Pending, Stopped, Stopping.
        /// Invalid states are: Shutting-down and Terminated.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.TooManyUpdatesException">
        /// There are concurrent updates for a resource that supports one update at a time.
        /// </exception>
        public Task<DeleteAssociationResponse> DeleteAssociationAsync(string instanceId, string name, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
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
        public Task<DeleteAssociationResponse> DeleteAssociationAsync(DeleteAssociationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteAssociationRequestMarshaller();
            var unmarshaller = DeleteAssociationResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteAssociationRequest,DeleteAssociationResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteDocument

        internal DeleteDocumentResponse DeleteDocument(DeleteDocumentRequest request)
        {
            var marshaller = new DeleteDocumentRequestMarshaller();
            var unmarshaller = DeleteDocumentResponseUnmarshaller.Instance;

            return Invoke<DeleteDocumentRequest,DeleteDocumentResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Deletes the SSM document and all instance associations to the document.
        /// 
        ///  
        /// <para>
        /// Before you delete the SSM document, we recommend that you use DeleteAssociation to
        /// disassociate all instances that are associated with the document.
        /// </para>
        /// </summary>
        /// <param name="name">The name of the SSM document.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteDocument service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.AssociatedInstancesException">
        /// You must disassociate an SSM document from all instances before you can delete it.
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
        public Task<DeleteDocumentResponse> DeleteDocumentAsync(string name, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
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
        public Task<DeleteDocumentResponse> DeleteDocumentAsync(DeleteDocumentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteDocumentRequestMarshaller();
            var unmarshaller = DeleteDocumentResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteDocumentRequest,DeleteDocumentResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeregisterManagedInstance

        internal DeregisterManagedInstanceResponse DeregisterManagedInstance(DeregisterManagedInstanceRequest request)
        {
            var marshaller = new DeregisterManagedInstanceRequestMarshaller();
            var unmarshaller = DeregisterManagedInstanceResponseUnmarshaller.Instance;

            return Invoke<DeregisterManagedInstanceRequest,DeregisterManagedInstanceResponse>(request, marshaller, unmarshaller);
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
        public Task<DeregisterManagedInstanceResponse> DeregisterManagedInstanceAsync(DeregisterManagedInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeregisterManagedInstanceRequestMarshaller();
            var unmarshaller = DeregisterManagedInstanceResponseUnmarshaller.Instance;

            return InvokeAsync<DeregisterManagedInstanceRequest,DeregisterManagedInstanceResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeActivations

        internal DescribeActivationsResponse DescribeActivations(DescribeActivationsRequest request)
        {
            var marshaller = new DescribeActivationsRequestMarshaller();
            var unmarshaller = DescribeActivationsResponseUnmarshaller.Instance;

            return Invoke<DescribeActivationsRequest,DescribeActivationsResponse>(request, marshaller, unmarshaller);
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
        public Task<DescribeActivationsResponse> DescribeActivationsAsync(DescribeActivationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeActivationsRequestMarshaller();
            var unmarshaller = DescribeActivationsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeActivationsRequest,DescribeActivationsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeAssociation

        internal DescribeAssociationResponse DescribeAssociation(DescribeAssociationRequest request)
        {
            var marshaller = new DescribeAssociationRequestMarshaller();
            var unmarshaller = DescribeAssociationResponseUnmarshaller.Instance;

            return Invoke<DescribeAssociationRequest,DescribeAssociationResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Describes the associations for the specified SSM document or instance.
        /// </summary>
        /// <param name="instanceId">The instance ID.</param>
        /// <param name="name">The name of the SSM document.</param>
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
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidDocumentException">
        /// The specified document does not exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidInstanceIdException">
        /// The instance is not in valid state. Valid states are: Running, Pending, Stopped, Stopping.
        /// Invalid states are: Shutting-down and Terminated.
        /// </exception>
        public Task<DescribeAssociationResponse> DescribeAssociationAsync(string instanceId, string name, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
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
        public Task<DescribeAssociationResponse> DescribeAssociationAsync(DescribeAssociationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeAssociationRequestMarshaller();
            var unmarshaller = DescribeAssociationResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeAssociationRequest,DescribeAssociationResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeDocument

        internal DescribeDocumentResponse DescribeDocument(DescribeDocumentRequest request)
        {
            var marshaller = new DescribeDocumentRequestMarshaller();
            var unmarshaller = DescribeDocumentResponseUnmarshaller.Instance;

            return Invoke<DescribeDocumentRequest,DescribeDocumentResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Describes the specified SSM document.
        /// </summary>
        /// <param name="name">The name of the SSM document.</param>
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
        public Task<DescribeDocumentResponse> DescribeDocumentAsync(string name, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
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
        public Task<DescribeDocumentResponse> DescribeDocumentAsync(DescribeDocumentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeDocumentRequestMarshaller();
            var unmarshaller = DescribeDocumentResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeDocumentRequest,DescribeDocumentResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeDocumentPermission

        internal DescribeDocumentPermissionResponse DescribeDocumentPermission(DescribeDocumentPermissionRequest request)
        {
            var marshaller = new DescribeDocumentPermissionRequestMarshaller();
            var unmarshaller = DescribeDocumentPermissionResponseUnmarshaller.Instance;

            return Invoke<DescribeDocumentPermissionRequest,DescribeDocumentPermissionResponse>(request, marshaller, unmarshaller);
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
        public Task<DescribeDocumentPermissionResponse> DescribeDocumentPermissionAsync(DescribeDocumentPermissionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeDocumentPermissionRequestMarshaller();
            var unmarshaller = DescribeDocumentPermissionResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeDocumentPermissionRequest,DescribeDocumentPermissionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeInstanceInformation

        internal DescribeInstanceInformationResponse DescribeInstanceInformation()
        {
            return DescribeInstanceInformation(new DescribeInstanceInformationRequest());
        }
        internal DescribeInstanceInformationResponse DescribeInstanceInformation(DescribeInstanceInformationRequest request)
        {
            var marshaller = new DescribeInstanceInformationRequestMarshaller();
            var unmarshaller = DescribeInstanceInformationResponseUnmarshaller.Instance;

            return Invoke<DescribeInstanceInformationRequest,DescribeInstanceInformationResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Describes one or more of your instances. You can use this to get information about
        /// instances like the operating system platform, the SSM agent version, status etc. If
        /// you specify one or more instance IDs, it returns information for those instances.
        /// If you do not specify instance IDs, it returns information for all your instances.
        /// If you specify an instance ID that is not valid or an instance that you do not own,
        /// you receive an error.
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
        /// The instance is not in valid state. Valid states are: Running, Pending, Stopped, Stopping.
        /// Invalid states are: Shutting-down and Terminated.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidInstanceInformationFilterValueException">
        /// The specified filter value is not valid.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidNextTokenException">
        /// The specified token is not valid.
        /// </exception>
        public Task<DescribeInstanceInformationResponse> DescribeInstanceInformationAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
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
        public Task<DescribeInstanceInformationResponse> DescribeInstanceInformationAsync(DescribeInstanceInformationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeInstanceInformationRequestMarshaller();
            var unmarshaller = DescribeInstanceInformationResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeInstanceInformationRequest,DescribeInstanceInformationResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetDocument

        internal GetDocumentResponse GetDocument(GetDocumentRequest request)
        {
            var marshaller = new GetDocumentRequestMarshaller();
            var unmarshaller = GetDocumentResponseUnmarshaller.Instance;

            return Invoke<GetDocumentRequest,GetDocumentResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Gets the contents of the specified SSM document.
        /// </summary>
        /// <param name="name">The name of the SSM document.</param>
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
        public Task<GetDocumentResponse> GetDocumentAsync(string name, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
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
        public Task<GetDocumentResponse> GetDocumentAsync(GetDocumentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetDocumentRequestMarshaller();
            var unmarshaller = GetDocumentResponseUnmarshaller.Instance;

            return InvokeAsync<GetDocumentRequest,GetDocumentResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListAssociations

        internal ListAssociationsResponse ListAssociations(ListAssociationsRequest request)
        {
            var marshaller = new ListAssociationsRequestMarshaller();
            var unmarshaller = ListAssociationsResponseUnmarshaller.Instance;

            return Invoke<ListAssociationsRequest,ListAssociationsResponse>(request, marshaller, unmarshaller);
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
        public Task<ListAssociationsResponse> ListAssociationsAsync(ListAssociationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListAssociationsRequestMarshaller();
            var unmarshaller = ListAssociationsResponseUnmarshaller.Instance;

            return InvokeAsync<ListAssociationsRequest,ListAssociationsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListCommandInvocations

        internal ListCommandInvocationsResponse ListCommandInvocations()
        {
            return ListCommandInvocations(new ListCommandInvocationsRequest());
        }
        internal ListCommandInvocationsResponse ListCommandInvocations(ListCommandInvocationsRequest request)
        {
            var marshaller = new ListCommandInvocationsRequestMarshaller();
            var unmarshaller = ListCommandInvocationsResponseUnmarshaller.Instance;

            return Invoke<ListCommandInvocationsRequest,ListCommandInvocationsResponse>(request, marshaller, unmarshaller);
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
        /// The instance is not in valid state. Valid states are: Running, Pending, Stopped, Stopping.
        /// Invalid states are: Shutting-down and Terminated.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidNextTokenException">
        /// The specified token is not valid.
        /// </exception>
        public Task<ListCommandInvocationsResponse> ListCommandInvocationsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
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
        /// The instance is not in valid state. Valid states are: Running, Pending, Stopped, Stopping.
        /// Invalid states are: Shutting-down and Terminated.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidNextTokenException">
        /// The specified token is not valid.
        /// </exception>
        public Task<ListCommandInvocationsResponse> ListCommandInvocationsAsync(string commandId, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
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
        public Task<ListCommandInvocationsResponse> ListCommandInvocationsAsync(ListCommandInvocationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListCommandInvocationsRequestMarshaller();
            var unmarshaller = ListCommandInvocationsResponseUnmarshaller.Instance;

            return InvokeAsync<ListCommandInvocationsRequest,ListCommandInvocationsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListCommands

        internal ListCommandsResponse ListCommands()
        {
            return ListCommands(new ListCommandsRequest());
        }
        internal ListCommandsResponse ListCommands(ListCommandsRequest request)
        {
            var marshaller = new ListCommandsRequestMarshaller();
            var unmarshaller = ListCommandsResponseUnmarshaller.Instance;

            return Invoke<ListCommandsRequest,ListCommandsResponse>(request, marshaller, unmarshaller);
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
        /// The instance is not in valid state. Valid states are: Running, Pending, Stopped, Stopping.
        /// Invalid states are: Shutting-down and Terminated.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidNextTokenException">
        /// The specified token is not valid.
        /// </exception>
        public Task<ListCommandsResponse> ListCommandsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
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
        /// The instance is not in valid state. Valid states are: Running, Pending, Stopped, Stopping.
        /// Invalid states are: Shutting-down and Terminated.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidNextTokenException">
        /// The specified token is not valid.
        /// </exception>
        public Task<ListCommandsResponse> ListCommandsAsync(string commandId, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
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
        public Task<ListCommandsResponse> ListCommandsAsync(ListCommandsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListCommandsRequestMarshaller();
            var unmarshaller = ListCommandsResponseUnmarshaller.Instance;

            return InvokeAsync<ListCommandsRequest,ListCommandsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListDocuments

        internal ListDocumentsResponse ListDocuments()
        {
            return ListDocuments(new ListDocumentsRequest());
        }
        internal ListDocumentsResponse ListDocuments(ListDocumentsRequest request)
        {
            var marshaller = new ListDocumentsRequestMarshaller();
            var unmarshaller = ListDocumentsResponseUnmarshaller.Instance;

            return Invoke<ListDocumentsRequest,ListDocumentsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Describes one or more of your SSM documents.
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
        public Task<ListDocumentsResponse> ListDocumentsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
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
        public Task<ListDocumentsResponse> ListDocumentsAsync(ListDocumentsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListDocumentsRequestMarshaller();
            var unmarshaller = ListDocumentsResponseUnmarshaller.Instance;

            return InvokeAsync<ListDocumentsRequest,ListDocumentsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListTagsForResource

        internal ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
        {
            var marshaller = new ListTagsForResourceRequestMarshaller();
            var unmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<ListTagsForResourceRequest,ListTagsForResourceResponse>(request, marshaller, unmarshaller);
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
        public Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListTagsForResourceRequestMarshaller();
            var unmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return InvokeAsync<ListTagsForResourceRequest,ListTagsForResourceResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ModifyDocumentPermission

        internal ModifyDocumentPermissionResponse ModifyDocumentPermission(ModifyDocumentPermissionRequest request)
        {
            var marshaller = new ModifyDocumentPermissionRequestMarshaller();
            var unmarshaller = ModifyDocumentPermissionResponseUnmarshaller.Instance;

            return Invoke<ModifyDocumentPermissionRequest,ModifyDocumentPermissionResponse>(request, marshaller, unmarshaller);
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
        public Task<ModifyDocumentPermissionResponse> ModifyDocumentPermissionAsync(ModifyDocumentPermissionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ModifyDocumentPermissionRequestMarshaller();
            var unmarshaller = ModifyDocumentPermissionResponseUnmarshaller.Instance;

            return InvokeAsync<ModifyDocumentPermissionRequest,ModifyDocumentPermissionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  RemoveTagsFromResource

        internal RemoveTagsFromResourceResponse RemoveTagsFromResource(RemoveTagsFromResourceRequest request)
        {
            var marshaller = new RemoveTagsFromResourceRequestMarshaller();
            var unmarshaller = RemoveTagsFromResourceResponseUnmarshaller.Instance;

            return Invoke<RemoveTagsFromResourceRequest,RemoveTagsFromResourceResponse>(request, marshaller, unmarshaller);
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
        public Task<RemoveTagsFromResourceResponse> RemoveTagsFromResourceAsync(RemoveTagsFromResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new RemoveTagsFromResourceRequestMarshaller();
            var unmarshaller = RemoveTagsFromResourceResponseUnmarshaller.Instance;

            return InvokeAsync<RemoveTagsFromResourceRequest,RemoveTagsFromResourceResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  SendCommand

        internal SendCommandResponse SendCommand(SendCommandRequest request)
        {
            var marshaller = new SendCommandRequestMarshaller();
            var unmarshaller = SendCommandResponseUnmarshaller.Instance;

            return Invoke<SendCommandRequest,SendCommandResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Executes commands on one or more remote instances.
        /// </summary>
        /// <param name="documentName">Required. The name of the SSM document to execute. This can be an SSM public document or a custom document.</param>
        /// <param name="instanceIds">Required. The instance IDs where the command should execute. You can specify a maximum of 50 IDs.</param>
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
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidInstanceIdException">
        /// The instance is not in valid state. Valid states are: Running, Pending, Stopped, Stopping.
        /// Invalid states are: Shutting-down and Terminated.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidNotificationConfigException">
        /// One or more configuration items is not valid. Verify that a valid Amazon Resource
        /// Name (ARN) was provided for an Amazon SNS topic.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidOutputFolderException">
        /// The S3 bucket does not exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidParametersException">
        /// You must specify values for all required parameters in the SSM document. You can only
        /// supply values to parameters defined in the SSM document.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidRoleException">
        /// The role name can't contain invalid characters. Also verify that you specified an
        /// IAM role for notifications that includes the required trust policy. For information
        /// about configuring the IAM role for SSM notifications, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/rc-sns.html">Configuring
        /// SNS Notifications SSM</a> in the <i>Amazon Elastic Compute Cloud User Guide </i>.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.MaxDocumentSizeExceededException">
        /// The size limit of an SSM document is 64 KB.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.UnsupportedPlatformTypeException">
        /// The document does not support the platform type of the given instance ID(s). For example,
        /// you sent an SSM document for a Windows instance to a Linux instance.
        /// </exception>
        public Task<SendCommandResponse> SendCommandAsync(string documentName, List<string> instanceIds, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
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
        public Task<SendCommandResponse> SendCommandAsync(SendCommandRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new SendCommandRequestMarshaller();
            var unmarshaller = SendCommandResponseUnmarshaller.Instance;

            return InvokeAsync<SendCommandRequest,SendCommandResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateAssociationStatus

        internal UpdateAssociationStatusResponse UpdateAssociationStatus(UpdateAssociationStatusRequest request)
        {
            var marshaller = new UpdateAssociationStatusRequestMarshaller();
            var unmarshaller = UpdateAssociationStatusResponseUnmarshaller.Instance;

            return Invoke<UpdateAssociationStatusRequest,UpdateAssociationStatusResponse>(request, marshaller, unmarshaller);
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
        public Task<UpdateAssociationStatusResponse> UpdateAssociationStatusAsync(UpdateAssociationStatusRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new UpdateAssociationStatusRequestMarshaller();
            var unmarshaller = UpdateAssociationStatusResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateAssociationStatusRequest,UpdateAssociationStatusResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateManagedInstanceRole

        internal UpdateManagedInstanceRoleResponse UpdateManagedInstanceRole(UpdateManagedInstanceRoleRequest request)
        {
            var marshaller = new UpdateManagedInstanceRoleRequestMarshaller();
            var unmarshaller = UpdateManagedInstanceRoleResponseUnmarshaller.Instance;

            return Invoke<UpdateManagedInstanceRoleRequest,UpdateManagedInstanceRoleResponse>(request, marshaller, unmarshaller);
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
        public Task<UpdateManagedInstanceRoleResponse> UpdateManagedInstanceRoleAsync(UpdateManagedInstanceRoleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new UpdateManagedInstanceRoleRequestMarshaller();
            var unmarshaller = UpdateManagedInstanceRoleResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateManagedInstanceRoleRequest,UpdateManagedInstanceRoleResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
    }
}