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
    /// This is the Amazon Simple Systems Manager (SSM) API Reference. SSM enables you to
    /// remotely manage the configuration of your Amazon EC2 instance using scripts or commands
    /// with either an on-demand solution called <i>SSM Run Command</i> or a lightweight instance
    /// configuration solution called <i>SSM Config</i>. 
    /// 
    ///  
    /// <para>
    /// This references is intended to be used with the SSM User Guide for <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/execute-remote-commands.html">Linux</a>
    /// or <a href="http://docs.aws.amazon.com/AWSEC2/latest/WindowsGuide/execute-remote-commands.html">Windows</a>.
    /// </para>
    ///  
    /// <para>
    ///  <b>Run Command</b> 
    /// </para>
    ///  
    /// <para>
    /// Run Command provides an on-demand experience for executing commands. You can use pre-defined
    /// Amazon SSM documents to perform the actions listed later in this section, or you can
    /// create your own documents. With these documents, you can remotely configure your instances
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
    /// SSM Config and SSM Run Command include the following pre-defined documents.
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
    /// user also has administrator access to the instance. Delegate access to SSM and Run
    /// Command judiciously. This becomes extremely important if you create your own SSM documents.
    /// Amazon Web Services does not provide guidance about how to create secure SSM documents.
    /// You create SSM documents and delegate access to Run Command at your own risk. As a
    /// security best practice, we recommend that you assign access to "AWS-*" documents,
    /// especially the AWS-RunShellScript document on Linux and the AWS-RunPowerShellScript
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

        
        #region  CancelCommand

        /// <summary>
        /// Attempts to cancel the command specified by the Command ID. There is no guarantee
        /// that the command will be terminated and the underlying process stopped.
        /// </summary>
        /// <param name="commandId">The ID of the command you want to cancel.</param>
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
        public CancelCommandResponse CancelCommand(string commandId)
        {
            var request = new CancelCommandRequest();
            request.CommandId = commandId;
            return CancelCommand(request);
        }


        /// <summary>
        /// Attempts to cancel the command specified by the Command ID. There is no guarantee
        /// that the command will be terminated and the underlying process stopped.
        /// </summary>
        /// <param name="commandId">The ID of the command you want to cancel.</param>
        /// <param name="instanceIds">(Optional) A list of instance IDs on which you want to cancel the command. If not provided, the command is canceled on every instance on which it was requested.</param>
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
        public CancelCommandResponse CancelCommand(string commandId, List<string> instanceIds)
        {
            var request = new CancelCommandRequest();
            request.CommandId = commandId;
            request.InstanceIds = instanceIds;
            return CancelCommand(request);
        }


        /// <summary>
        /// Attempts to cancel the command specified by the Command ID. There is no guarantee
        /// that the command will be terminated and the underlying process stopped.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelCommand service method.</param>
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
        public CancelCommandResponse CancelCommand(CancelCommandRequest request)
        {
            var marshaller = new CancelCommandRequestMarshaller();
            var unmarshaller = CancelCommandResponseUnmarshaller.Instance;

            return Invoke<CancelCommandRequest,CancelCommandResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CancelCommand operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CancelCommand operation on AmazonSimpleSystemsManagementClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCancelCommand
        ///         operation.</returns>
        public IAsyncResult BeginCancelCommand(CancelCommandRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new CancelCommandRequestMarshaller();
            var unmarshaller = CancelCommandResponseUnmarshaller.Instance;

            return BeginInvoke<CancelCommandRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CancelCommand operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCancelCommand.</param>
        /// 
        /// <returns>Returns a  CancelCommandResult from SimpleSystemsManagement.</returns>
        public  CancelCommandResponse EndCancelCommand(IAsyncResult asyncResult)
        {
            return EndInvoke<CancelCommandResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateAssociation

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
        public CreateAssociationResponse CreateAssociation(string instanceId, string name)
        {
            var request = new CreateAssociationRequest();
            request.InstanceId = instanceId;
            request.Name = name;
            return CreateAssociation(request);
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
        /// <param name="request">Container for the necessary parameters to execute the CreateAssociation service method.</param>
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
        public CreateAssociationResponse CreateAssociation(CreateAssociationRequest request)
        {
            var marshaller = new CreateAssociationRequestMarshaller();
            var unmarshaller = CreateAssociationResponseUnmarshaller.Instance;

            return Invoke<CreateAssociationRequest,CreateAssociationResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateAssociation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateAssociation operation on AmazonSimpleSystemsManagementClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateAssociation
        ///         operation.</returns>
        public IAsyncResult BeginCreateAssociation(CreateAssociationRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new CreateAssociationRequestMarshaller();
            var unmarshaller = CreateAssociationResponseUnmarshaller.Instance;

            return BeginInvoke<CreateAssociationRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateAssociation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateAssociation.</param>
        /// 
        /// <returns>Returns a  CreateAssociationResult from SimpleSystemsManagement.</returns>
        public  CreateAssociationResponse EndCreateAssociation(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateAssociationResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateAssociationBatch

        /// <summary>
        /// Associates the specified SSM document with the specified instances.
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
        /// <param name="request">Container for the necessary parameters to execute the CreateAssociationBatch service method.</param>
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
        public CreateAssociationBatchResponse CreateAssociationBatch(CreateAssociationBatchRequest request)
        {
            var marshaller = new CreateAssociationBatchRequestMarshaller();
            var unmarshaller = CreateAssociationBatchResponseUnmarshaller.Instance;

            return Invoke<CreateAssociationBatchRequest,CreateAssociationBatchResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateAssociationBatch operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateAssociationBatch operation on AmazonSimpleSystemsManagementClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateAssociationBatch
        ///         operation.</returns>
        public IAsyncResult BeginCreateAssociationBatch(CreateAssociationBatchRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new CreateAssociationBatchRequestMarshaller();
            var unmarshaller = CreateAssociationBatchResponseUnmarshaller.Instance;

            return BeginInvoke<CreateAssociationBatchRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateAssociationBatch operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateAssociationBatch.</param>
        /// 
        /// <returns>Returns a  CreateAssociationBatchResult from SimpleSystemsManagement.</returns>
        public  CreateAssociationBatchResponse EndCreateAssociationBatch(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateAssociationBatchResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateDocument

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
        public CreateDocumentResponse CreateDocument(string content, string name)
        {
            var request = new CreateDocumentRequest();
            request.Content = content;
            request.Name = name;
            return CreateDocument(request);
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
        /// <param name="request">Container for the necessary parameters to execute the CreateDocument service method.</param>
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
        public CreateDocumentResponse CreateDocument(CreateDocumentRequest request)
        {
            var marshaller = new CreateDocumentRequestMarshaller();
            var unmarshaller = CreateDocumentResponseUnmarshaller.Instance;

            return Invoke<CreateDocumentRequest,CreateDocumentResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateDocument operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDocument operation on AmazonSimpleSystemsManagementClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateDocument
        ///         operation.</returns>
        public IAsyncResult BeginCreateDocument(CreateDocumentRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new CreateDocumentRequestMarshaller();
            var unmarshaller = CreateDocumentResponseUnmarshaller.Instance;

            return BeginInvoke<CreateDocumentRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateDocument operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateDocument.</param>
        /// 
        /// <returns>Returns a  CreateDocumentResult from SimpleSystemsManagement.</returns>
        public  CreateDocumentResponse EndCreateDocument(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateDocumentResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteAssociation

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
        public DeleteAssociationResponse DeleteAssociation(string instanceId, string name)
        {
            var request = new DeleteAssociationRequest();
            request.InstanceId = instanceId;
            request.Name = name;
            return DeleteAssociation(request);
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
        /// <param name="request">Container for the necessary parameters to execute the DeleteAssociation service method.</param>
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
        public DeleteAssociationResponse DeleteAssociation(DeleteAssociationRequest request)
        {
            var marshaller = new DeleteAssociationRequestMarshaller();
            var unmarshaller = DeleteAssociationResponseUnmarshaller.Instance;

            return Invoke<DeleteAssociationRequest,DeleteAssociationResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteAssociation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteAssociation operation on AmazonSimpleSystemsManagementClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteAssociation
        ///         operation.</returns>
        public IAsyncResult BeginDeleteAssociation(DeleteAssociationRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DeleteAssociationRequestMarshaller();
            var unmarshaller = DeleteAssociationResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteAssociationRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteAssociation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteAssociation.</param>
        /// 
        /// <returns>Returns a  DeleteAssociationResult from SimpleSystemsManagement.</returns>
        public  DeleteAssociationResponse EndDeleteAssociation(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteAssociationResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteDocument

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
        public DeleteDocumentResponse DeleteDocument(string name)
        {
            var request = new DeleteDocumentRequest();
            request.Name = name;
            return DeleteDocument(request);
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
        /// <param name="request">Container for the necessary parameters to execute the DeleteDocument service method.</param>
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
        public DeleteDocumentResponse DeleteDocument(DeleteDocumentRequest request)
        {
            var marshaller = new DeleteDocumentRequestMarshaller();
            var unmarshaller = DeleteDocumentResponseUnmarshaller.Instance;

            return Invoke<DeleteDocumentRequest,DeleteDocumentResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDocument operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDocument operation on AmazonSimpleSystemsManagementClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteDocument
        ///         operation.</returns>
        public IAsyncResult BeginDeleteDocument(DeleteDocumentRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DeleteDocumentRequestMarshaller();
            var unmarshaller = DeleteDocumentResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteDocumentRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteDocument operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteDocument.</param>
        /// 
        /// <returns>Returns a  DeleteDocumentResult from SimpleSystemsManagement.</returns>
        public  DeleteDocumentResponse EndDeleteDocument(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteDocumentResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeAssociation

        /// <summary>
        /// Describes the associations for the specified SSM document or instance.
        /// </summary>
        /// <param name="instanceId">The instance ID.</param>
        /// <param name="name">The name of the SSM document.</param>
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
        public DescribeAssociationResponse DescribeAssociation(string instanceId, string name)
        {
            var request = new DescribeAssociationRequest();
            request.InstanceId = instanceId;
            request.Name = name;
            return DescribeAssociation(request);
        }


        /// <summary>
        /// Describes the associations for the specified SSM document or instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAssociation service method.</param>
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
        public DescribeAssociationResponse DescribeAssociation(DescribeAssociationRequest request)
        {
            var marshaller = new DescribeAssociationRequestMarshaller();
            var unmarshaller = DescribeAssociationResponseUnmarshaller.Instance;

            return Invoke<DescribeAssociationRequest,DescribeAssociationResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeAssociation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAssociation operation on AmazonSimpleSystemsManagementClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeAssociation
        ///         operation.</returns>
        public IAsyncResult BeginDescribeAssociation(DescribeAssociationRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DescribeAssociationRequestMarshaller();
            var unmarshaller = DescribeAssociationResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeAssociationRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeAssociation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeAssociation.</param>
        /// 
        /// <returns>Returns a  DescribeAssociationResult from SimpleSystemsManagement.</returns>
        public  DescribeAssociationResponse EndDescribeAssociation(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeAssociationResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeDocument

        /// <summary>
        /// Describes the specified SSM document.
        /// </summary>
        /// <param name="name">The name of the SSM document.</param>
        /// 
        /// <returns>The response from the DescribeDocument service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidDocumentException">
        /// The specified document does not exist.
        /// </exception>
        public DescribeDocumentResponse DescribeDocument(string name)
        {
            var request = new DescribeDocumentRequest();
            request.Name = name;
            return DescribeDocument(request);
        }


        /// <summary>
        /// Describes the specified SSM document.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDocument service method.</param>
        /// 
        /// <returns>The response from the DescribeDocument service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidDocumentException">
        /// The specified document does not exist.
        /// </exception>
        public DescribeDocumentResponse DescribeDocument(DescribeDocumentRequest request)
        {
            var marshaller = new DescribeDocumentRequestMarshaller();
            var unmarshaller = DescribeDocumentResponseUnmarshaller.Instance;

            return Invoke<DescribeDocumentRequest,DescribeDocumentResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDocument operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDocument operation on AmazonSimpleSystemsManagementClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeDocument
        ///         operation.</returns>
        public IAsyncResult BeginDescribeDocument(DescribeDocumentRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DescribeDocumentRequestMarshaller();
            var unmarshaller = DescribeDocumentResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeDocumentRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeDocument operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeDocument.</param>
        /// 
        /// <returns>Returns a  DescribeDocumentResult from SimpleSystemsManagement.</returns>
        public  DescribeDocumentResponse EndDescribeDocument(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeDocumentResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeDocumentPermission

        /// <summary>
        /// Describes the permissions for an SSM document. If you created the document, you are
        /// the owner. If a document is shared, it can either be shared privately (by specifying
        /// a user’s AWS account ID) or publicly (<i>All</i>).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDocumentPermission service method.</param>
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
        public DescribeDocumentPermissionResponse DescribeDocumentPermission(DescribeDocumentPermissionRequest request)
        {
            var marshaller = new DescribeDocumentPermissionRequestMarshaller();
            var unmarshaller = DescribeDocumentPermissionResponseUnmarshaller.Instance;

            return Invoke<DescribeDocumentPermissionRequest,DescribeDocumentPermissionResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDocumentPermission operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDocumentPermission operation on AmazonSimpleSystemsManagementClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeDocumentPermission
        ///         operation.</returns>
        public IAsyncResult BeginDescribeDocumentPermission(DescribeDocumentPermissionRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DescribeDocumentPermissionRequestMarshaller();
            var unmarshaller = DescribeDocumentPermissionResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeDocumentPermissionRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeDocumentPermission operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeDocumentPermission.</param>
        /// 
        /// <returns>Returns a  DescribeDocumentPermissionResult from SimpleSystemsManagement.</returns>
        public  DescribeDocumentPermissionResponse EndDescribeDocumentPermission(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeDocumentPermissionResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeInstanceInformation

        /// <summary>
        /// Describes one or more of your instances. You can use this to get information about
        /// instances like the operating system platform, the SSM agent version, status etc. If
        /// you specify one or more instance IDs, it returns information for those instances.
        /// If you do not specify instance IDs, it returns information for all your instances.
        /// If you specify an instance ID that is not valid or an instance that you do not own,
        /// you receive an error.
        /// </summary>
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
        public DescribeInstanceInformationResponse DescribeInstanceInformation()
        {
            return DescribeInstanceInformation(new DescribeInstanceInformationRequest());
        }

        /// <summary>
        /// Describes one or more of your instances. You can use this to get information about
        /// instances like the operating system platform, the SSM agent version, status etc. If
        /// you specify one or more instance IDs, it returns information for those instances.
        /// If you do not specify instance IDs, it returns information for all your instances.
        /// If you specify an instance ID that is not valid or an instance that you do not own,
        /// you receive an error.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeInstanceInformation service method.</param>
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
        public DescribeInstanceInformationResponse DescribeInstanceInformation(DescribeInstanceInformationRequest request)
        {
            var marshaller = new DescribeInstanceInformationRequestMarshaller();
            var unmarshaller = DescribeInstanceInformationResponseUnmarshaller.Instance;

            return Invoke<DescribeInstanceInformationRequest,DescribeInstanceInformationResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeInstanceInformation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeInstanceInformation operation on AmazonSimpleSystemsManagementClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeInstanceInformation
        ///         operation.</returns>
        public IAsyncResult BeginDescribeInstanceInformation(DescribeInstanceInformationRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DescribeInstanceInformationRequestMarshaller();
            var unmarshaller = DescribeInstanceInformationResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeInstanceInformationRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeInstanceInformation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeInstanceInformation.</param>
        /// 
        /// <returns>Returns a  DescribeInstanceInformationResult from SimpleSystemsManagement.</returns>
        public  DescribeInstanceInformationResponse EndDescribeInstanceInformation(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeInstanceInformationResponse>(asyncResult);
        }

        #endregion
        
        #region  GetDocument

        /// <summary>
        /// Gets the contents of the specified SSM document.
        /// </summary>
        /// <param name="name">The name of the SSM document.</param>
        /// 
        /// <returns>The response from the GetDocument service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidDocumentException">
        /// The specified document does not exist.
        /// </exception>
        public GetDocumentResponse GetDocument(string name)
        {
            var request = new GetDocumentRequest();
            request.Name = name;
            return GetDocument(request);
        }


        /// <summary>
        /// Gets the contents of the specified SSM document.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDocument service method.</param>
        /// 
        /// <returns>The response from the GetDocument service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidDocumentException">
        /// The specified document does not exist.
        /// </exception>
        public GetDocumentResponse GetDocument(GetDocumentRequest request)
        {
            var marshaller = new GetDocumentRequestMarshaller();
            var unmarshaller = GetDocumentResponseUnmarshaller.Instance;

            return Invoke<GetDocumentRequest,GetDocumentResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetDocument operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDocument operation on AmazonSimpleSystemsManagementClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetDocument
        ///         operation.</returns>
        public IAsyncResult BeginGetDocument(GetDocumentRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new GetDocumentRequestMarshaller();
            var unmarshaller = GetDocumentResponseUnmarshaller.Instance;

            return BeginInvoke<GetDocumentRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetDocument operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDocument.</param>
        /// 
        /// <returns>Returns a  GetDocumentResult from SimpleSystemsManagement.</returns>
        public  GetDocumentResponse EndGetDocument(IAsyncResult asyncResult)
        {
            return EndInvoke<GetDocumentResponse>(asyncResult);
        }

        #endregion
        
        #region  ListAssociations

        /// <summary>
        /// Lists the associations for the specified SSM document or instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAssociations service method.</param>
        /// 
        /// <returns>The response from the ListAssociations service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidNextTokenException">
        /// The specified token is not valid.
        /// </exception>
        public ListAssociationsResponse ListAssociations(ListAssociationsRequest request)
        {
            var marshaller = new ListAssociationsRequestMarshaller();
            var unmarshaller = ListAssociationsResponseUnmarshaller.Instance;

            return Invoke<ListAssociationsRequest,ListAssociationsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListAssociations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAssociations operation on AmazonSimpleSystemsManagementClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAssociations
        ///         operation.</returns>
        public IAsyncResult BeginListAssociations(ListAssociationsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new ListAssociationsRequestMarshaller();
            var unmarshaller = ListAssociationsResponseUnmarshaller.Instance;

            return BeginInvoke<ListAssociationsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListAssociations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAssociations.</param>
        /// 
        /// <returns>Returns a  ListAssociationsResult from SimpleSystemsManagement.</returns>
        public  ListAssociationsResponse EndListAssociations(IAsyncResult asyncResult)
        {
            return EndInvoke<ListAssociationsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListCommandInvocations

        /// <summary>
        /// An invocation is copy of a command sent to a specific instance. A command can apply
        /// to one or more instances. A command invocation applies to one instance. For example,
        /// if a user executes SendCommand against three instances, then a command invocation
        /// is created for each requested instance ID. ListCommandInvocations provide status about
        /// command execution.
        /// </summary>
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
        public ListCommandInvocationsResponse ListCommandInvocations()
        {
            return ListCommandInvocations(new ListCommandInvocationsRequest());
        }

        /// <summary>
        /// An invocation is copy of a command sent to a specific instance. A command can apply
        /// to one or more instances. A command invocation applies to one instance. For example,
        /// if a user executes SendCommand against three instances, then a command invocation
        /// is created for each requested instance ID. ListCommandInvocations provide status about
        /// command execution.
        /// </summary>
        /// <param name="commandId">(Optional) The invocations for a specific command ID.</param>
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
        public ListCommandInvocationsResponse ListCommandInvocations(string commandId)
        {
            var request = new ListCommandInvocationsRequest();
            request.CommandId = commandId;
            return ListCommandInvocations(request);
        }


        /// <summary>
        /// An invocation is copy of a command sent to a specific instance. A command can apply
        /// to one or more instances. A command invocation applies to one instance. For example,
        /// if a user executes SendCommand against three instances, then a command invocation
        /// is created for each requested instance ID. ListCommandInvocations provide status about
        /// command execution.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCommandInvocations service method.</param>
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
        public ListCommandInvocationsResponse ListCommandInvocations(ListCommandInvocationsRequest request)
        {
            var marshaller = new ListCommandInvocationsRequestMarshaller();
            var unmarshaller = ListCommandInvocationsResponseUnmarshaller.Instance;

            return Invoke<ListCommandInvocationsRequest,ListCommandInvocationsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListCommandInvocations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListCommandInvocations operation on AmazonSimpleSystemsManagementClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListCommandInvocations
        ///         operation.</returns>
        public IAsyncResult BeginListCommandInvocations(ListCommandInvocationsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new ListCommandInvocationsRequestMarshaller();
            var unmarshaller = ListCommandInvocationsResponseUnmarshaller.Instance;

            return BeginInvoke<ListCommandInvocationsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListCommandInvocations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListCommandInvocations.</param>
        /// 
        /// <returns>Returns a  ListCommandInvocationsResult from SimpleSystemsManagement.</returns>
        public  ListCommandInvocationsResponse EndListCommandInvocations(IAsyncResult asyncResult)
        {
            return EndInvoke<ListCommandInvocationsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListCommands

        /// <summary>
        /// Lists the commands requested by users of the AWS account.
        /// </summary>
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
        public ListCommandsResponse ListCommands()
        {
            return ListCommands(new ListCommandsRequest());
        }

        /// <summary>
        /// Lists the commands requested by users of the AWS account.
        /// </summary>
        /// <param name="commandId">(Optional) If provided, lists only the specified command.</param>
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
        public ListCommandsResponse ListCommands(string commandId)
        {
            var request = new ListCommandsRequest();
            request.CommandId = commandId;
            return ListCommands(request);
        }


        /// <summary>
        /// Lists the commands requested by users of the AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCommands service method.</param>
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
        public ListCommandsResponse ListCommands(ListCommandsRequest request)
        {
            var marshaller = new ListCommandsRequestMarshaller();
            var unmarshaller = ListCommandsResponseUnmarshaller.Instance;

            return Invoke<ListCommandsRequest,ListCommandsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListCommands operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListCommands operation on AmazonSimpleSystemsManagementClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListCommands
        ///         operation.</returns>
        public IAsyncResult BeginListCommands(ListCommandsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new ListCommandsRequestMarshaller();
            var unmarshaller = ListCommandsResponseUnmarshaller.Instance;

            return BeginInvoke<ListCommandsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListCommands operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListCommands.</param>
        /// 
        /// <returns>Returns a  ListCommandsResult from SimpleSystemsManagement.</returns>
        public  ListCommandsResponse EndListCommands(IAsyncResult asyncResult)
        {
            return EndInvoke<ListCommandsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListDocuments

        /// <summary>
        /// Describes one or more of your SSM documents.
        /// </summary>
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
        public ListDocumentsResponse ListDocuments()
        {
            return ListDocuments(new ListDocumentsRequest());
        }

        /// <summary>
        /// Describes one or more of your SSM documents.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDocuments service method.</param>
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
        public ListDocumentsResponse ListDocuments(ListDocumentsRequest request)
        {
            var marshaller = new ListDocumentsRequestMarshaller();
            var unmarshaller = ListDocumentsResponseUnmarshaller.Instance;

            return Invoke<ListDocumentsRequest,ListDocumentsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListDocuments operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDocuments operation on AmazonSimpleSystemsManagementClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListDocuments
        ///         operation.</returns>
        public IAsyncResult BeginListDocuments(ListDocumentsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new ListDocumentsRequestMarshaller();
            var unmarshaller = ListDocumentsResponseUnmarshaller.Instance;

            return BeginInvoke<ListDocumentsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListDocuments operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListDocuments.</param>
        /// 
        /// <returns>Returns a  ListDocumentsResult from SimpleSystemsManagement.</returns>
        public  ListDocumentsResponse EndListDocuments(IAsyncResult asyncResult)
        {
            return EndInvoke<ListDocumentsResponse>(asyncResult);
        }

        #endregion
        
        #region  ModifyDocumentPermission

        /// <summary>
        /// Share a document publicly or privately. If you share a document privately, you must
        /// specify the AWS user account IDs for those people who can use the document. If you
        /// share a document publicly, you must specify <i>All</i> as the account ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyDocumentPermission service method.</param>
        /// 
        /// <returns>The response from the ModifyDocumentPermission service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.DocumentLimitExceededException">
        /// You can have at most 100 active SSM documents.
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
        public ModifyDocumentPermissionResponse ModifyDocumentPermission(ModifyDocumentPermissionRequest request)
        {
            var marshaller = new ModifyDocumentPermissionRequestMarshaller();
            var unmarshaller = ModifyDocumentPermissionResponseUnmarshaller.Instance;

            return Invoke<ModifyDocumentPermissionRequest,ModifyDocumentPermissionResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ModifyDocumentPermission operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyDocumentPermission operation on AmazonSimpleSystemsManagementClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndModifyDocumentPermission
        ///         operation.</returns>
        public IAsyncResult BeginModifyDocumentPermission(ModifyDocumentPermissionRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new ModifyDocumentPermissionRequestMarshaller();
            var unmarshaller = ModifyDocumentPermissionResponseUnmarshaller.Instance;

            return BeginInvoke<ModifyDocumentPermissionRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ModifyDocumentPermission operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginModifyDocumentPermission.</param>
        /// 
        /// <returns>Returns a  ModifyDocumentPermissionResult from SimpleSystemsManagement.</returns>
        public  ModifyDocumentPermissionResponse EndModifyDocumentPermission(IAsyncResult asyncResult)
        {
            return EndInvoke<ModifyDocumentPermissionResponse>(asyncResult);
        }

        #endregion
        
        #region  SendCommand

        /// <summary>
        /// Executes commands on one or more remote instances.
        /// </summary>
        /// <param name="documentName">Required. The name of the SSM document to execute. This can be an SSM public document or a custom document.</param>
        /// <param name="instanceIds">Required. The instance IDs where the command should execute.</param>
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
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidOutputFolderException">
        /// The S3 bucket does not exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidParametersException">
        /// You must specify values for all required parameters in the SSM document. You can only
        /// supply values to parameters defined in the SSM document.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.MaxDocumentSizeExceededException">
        /// The size limit of an SSM document is 64 KB.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.UnsupportedPlatformTypeException">
        /// The document does not support the platform type of the given instance ID(s). For example,
        /// you sent an SSM document for a Windows instance to a Linux instance.
        /// </exception>
        public SendCommandResponse SendCommand(string documentName, List<string> instanceIds)
        {
            var request = new SendCommandRequest();
            request.DocumentName = documentName;
            request.InstanceIds = instanceIds;
            return SendCommand(request);
        }


        /// <summary>
        /// Executes commands on one or more remote instances.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SendCommand service method.</param>
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
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidOutputFolderException">
        /// The S3 bucket does not exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidParametersException">
        /// You must specify values for all required parameters in the SSM document. You can only
        /// supply values to parameters defined in the SSM document.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.MaxDocumentSizeExceededException">
        /// The size limit of an SSM document is 64 KB.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.UnsupportedPlatformTypeException">
        /// The document does not support the platform type of the given instance ID(s). For example,
        /// you sent an SSM document for a Windows instance to a Linux instance.
        /// </exception>
        public SendCommandResponse SendCommand(SendCommandRequest request)
        {
            var marshaller = new SendCommandRequestMarshaller();
            var unmarshaller = SendCommandResponseUnmarshaller.Instance;

            return Invoke<SendCommandRequest,SendCommandResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the SendCommand operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SendCommand operation on AmazonSimpleSystemsManagementClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSendCommand
        ///         operation.</returns>
        public IAsyncResult BeginSendCommand(SendCommandRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new SendCommandRequestMarshaller();
            var unmarshaller = SendCommandResponseUnmarshaller.Instance;

            return BeginInvoke<SendCommandRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  SendCommand operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSendCommand.</param>
        /// 
        /// <returns>Returns a  SendCommandResult from SimpleSystemsManagement.</returns>
        public  SendCommandResponse EndSendCommand(IAsyncResult asyncResult)
        {
            return EndInvoke<SendCommandResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateAssociationStatus

        /// <summary>
        /// Updates the status of the SSM document associated with the specified instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAssociationStatus service method.</param>
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
        /// The instance is not in valid state. Valid states are: Running, Pending, Stopped, Stopping.
        /// Invalid states are: Shutting-down and Terminated.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.StatusUnchangedException">
        /// The updated status is the same as the current status.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.TooManyUpdatesException">
        /// There are concurrent updates for a resource that supports one update at a time.
        /// </exception>
        public UpdateAssociationStatusResponse UpdateAssociationStatus(UpdateAssociationStatusRequest request)
        {
            var marshaller = new UpdateAssociationStatusRequestMarshaller();
            var unmarshaller = UpdateAssociationStatusResponseUnmarshaller.Instance;

            return Invoke<UpdateAssociationStatusRequest,UpdateAssociationStatusResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateAssociationStatus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateAssociationStatus operation on AmazonSimpleSystemsManagementClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateAssociationStatus
        ///         operation.</returns>
        public IAsyncResult BeginUpdateAssociationStatus(UpdateAssociationStatusRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new UpdateAssociationStatusRequestMarshaller();
            var unmarshaller = UpdateAssociationStatusResponseUnmarshaller.Instance;

            return BeginInvoke<UpdateAssociationStatusRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateAssociationStatus operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateAssociationStatus.</param>
        /// 
        /// <returns>Returns a  UpdateAssociationStatusResult from SimpleSystemsManagement.</returns>
        public  UpdateAssociationStatusResponse EndUpdateAssociationStatus(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateAssociationStatusResponse>(asyncResult);
        }

        #endregion
        
    }
}