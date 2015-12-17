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

namespace Amazon.SimpleSystemsManagement
{
    /// <summary>
    /// Interface for accessing SimpleSystemsManagement
    ///
    /// Simple Systems Manager (SSM) enables you to remotely manage the configuration of your
    /// Amazon EC2 instance. Using SSM, you can run scripts or commands using either EC2 Run
    /// Command or SSM Config. (SSM Config is currently available only for Windows instances.)
    /// 
    /// 
    ///   <b>Run Command</b> 
    /// <para>
    /// Run Command provides an on-demand experience for executing commands. You can use pre-defined
    /// Amazon SSM documents to perform the actions listed later in this section, or you can
    /// create your own documents. With these documents, you can remotely configure your instances
    /// by sending commands using the <b>Commands</b> page in the <a href="http://console.aws.amazon.com/ec2/">Amazon
    /// EC2 console</a>, <a href="http://docs.aws.amazon.com/powershell/latest/reference/items/Amazon_Simple_Systems_Management_cmdlets.html">AWS
    /// Tools for Windows PowerShell</a>, or the <a href="http://docs.aws.amazon.com/cli/latest/reference/ssm/index.html">AWS
    /// CLI</a>.
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
    ///   <b>SSM Config</b> 
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
    ///  <para>SSM Config and Run Command include the following pre-defined documents.</para>
    /// <table> <title>Amazon Pre-defined SSM Documents</title> <tgroup cols="3"> <colspec
    /// colname="col1" colnum="1" colwidth="1*"/> <colspec colname="col2" colnum="2" colwidth="1*"/>
    /// <colspec colname="col3" colnum="3" colwidth="1*"/> <thead> <row> <entry>Name</entry>
    /// <entry>Description</entry> <entry>Platform</entry> </row> </thead> <tbody> <row> <entry>
    /// <para>AWS-RunShellScript</para> </entry> <entry> <para>Run shell scripts</para> </entry>
    /// <entry> <para>Linux</para> </entry> </row> <row> <entry> <para>AWS-UpdateSSMAgent</para>
    /// </entry> <entry> <para>Update the Amazon SSM agent</para> </entry> <entry> <para>Linux</para>
    /// </entry> </row> <row> <entry> <para>AWS-JoinDirectoryServiceDomain </para> </entry>
    /// <entry> <para>Join an AWS Directory </para> </entry> <entry> <para>Windows</para>
    /// </entry> </row> <row> <entry> <para>AWS-RunPowerShellScript</para> </entry> <entry>
    /// <para>Run PowerShell commands or scripts</para> </entry> <entry> <para>Windows</para>
    /// </entry> </row> <row> <entry> <para>AWS-UpdateEC2Config</para> </entry> <entry> <para>Update
    /// the EC2Config service </para> </entry> <entry> <para>Windows</para> </entry> </row>
    /// <row> <entry> <para>AWS-ConfigureWindowsUpdate</para> </entry> <entry> <para>Configure
    /// Windows Update settings</para> </entry> <entry> <para>Windows</para> </entry> </row>
    /// <row> <entry> <para>AWS-InstallApplication</para> </entry> <entry> <para>Install,
    /// repair, or uninstall software using an MSI package</para> </entry> <entry> <para>Windows</para>
    /// </entry> </row> <row> <entry> <para>AWS-InstallPowerShellModule</para> </entry> <entry>
    /// <para>Install PowerShell modules </para> </entry> <entry> <para>Windows</para> </entry>
    /// </row> <row> <entry> <para>AWS-ConfigureCloudWatch</para> </entry> <entry> <para>Configure
    /// Amazon CloudWatch Logs to monitor applications and systems</para> </entry> <entry>
    /// <para>Windows</para> </entry> </row> </tbody> </tgroup> </table> <important> <simpara>The
    /// commands or scripts specified in SSM documents run with administrative privilege on
    /// your instances because the Amazon SSM agent runs as root on Linux and the EC2Config
    /// service runs in the Local System account on Windows. If a user has permission to execute
    /// any of the pre-defined SSM documents (any document that begins with AWS-*) then that
    /// user also has administrator access to the instance. Delegate access to SSM and Run
    /// Command judiciously. This becomes extremely important if you create your own SSM documents.
    /// Amazon Web Services does not provide guidance about how to create secure SSM documents.
    /// You create SSM documents and delegate access to Run Command at your own risk. As a
    /// security best practice, we recommend that you assign access to "AWS-*" documents,
    /// especially the AWS-RunShellScript document on Linux and the AWS-RunPowerShellScript
    /// document on Windows, to trusted administrators only. You can create SSM documents
    /// for specific tasks and delegate access to non-administrators.</simpara> </important>
    /// </summary>
    public partial interface IAmazonSimpleSystemsManagement : IDisposable
    {

        
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
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidCommandIdException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidInstanceIdException">
        /// The instance is not in valid state. Valid states are: Running, Pending, Stopped, Stopping.
        /// Invalid states are: Shutting-down and Terminated.
        /// </exception>
        CancelCommandResponse CancelCommand(string commandId);

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
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidCommandIdException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidInstanceIdException">
        /// The instance is not in valid state. Valid states are: Running, Pending, Stopped, Stopping.
        /// Invalid states are: Shutting-down and Terminated.
        /// </exception>
        CancelCommandResponse CancelCommand(string commandId, List<string> instanceIds);

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
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidCommandIdException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidInstanceIdException">
        /// The instance is not in valid state. Valid states are: Running, Pending, Stopped, Stopping.
        /// Invalid states are: Shutting-down and Terminated.
        /// </exception>
        CancelCommandResponse CancelCommand(CancelCommandRequest request);

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
        IAsyncResult BeginCancelCommand(CancelCommandRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CancelCommand operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCancelCommand.</param>
        /// 
        /// <returns>Returns a  CancelCommandResult from SimpleSystemsManagement.</returns>
        CancelCommandResponse EndCancelCommand(IAsyncResult asyncResult);

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
        /// <param name="instanceId">The Windows Server instance ID.</param>
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
        /// The document does not support the platform type of the given instance ID(s).
        /// </exception>
        CreateAssociationResponse CreateAssociation(string instanceId, string name);

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
        /// The document does not support the platform type of the given instance ID(s).
        /// </exception>
        CreateAssociationResponse CreateAssociation(CreateAssociationRequest request);

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
        IAsyncResult BeginCreateAssociation(CreateAssociationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateAssociation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateAssociation.</param>
        /// 
        /// <returns>Returns a  CreateAssociationResult from SimpleSystemsManagement.</returns>
        CreateAssociationResponse EndCreateAssociation(IAsyncResult asyncResult);

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
        /// The document does not support the platform type of the given instance ID(s).
        /// </exception>
        CreateAssociationBatchResponse CreateAssociationBatch(CreateAssociationBatchRequest request);

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
        IAsyncResult BeginCreateAssociationBatch(CreateAssociationBatchRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateAssociationBatch operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateAssociationBatch.</param>
        /// 
        /// <returns>Returns a  CreateAssociationBatchResult from SimpleSystemsManagement.</returns>
        CreateAssociationBatchResponse EndCreateAssociationBatch(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateDocument


        /// <summary>
        /// Creates an SSM document.
        /// 
        ///  
        /// <para>
        /// After you create an SSM document, you can use <a>CreateAssociation</a> to associate
        /// it with one or more running instances.
        /// </para>
        /// </summary>
        /// <param name="content">A valid JSON string. For more information about the contents of this string, see <a href="http://docs.aws.amazon.com/ssm/latest/APIReference/aws-ssm-document.html">SSM Document</a>.</param>
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
        CreateDocumentResponse CreateDocument(string content, string name);

        /// <summary>
        /// Creates an SSM document.
        /// 
        ///  
        /// <para>
        /// After you create an SSM document, you can use <a>CreateAssociation</a> to associate
        /// it with one or more running instances.
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
        CreateDocumentResponse CreateDocument(CreateDocumentRequest request);

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
        IAsyncResult BeginCreateDocument(CreateDocumentRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateDocument operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateDocument.</param>
        /// 
        /// <returns>Returns a  CreateDocumentResult from SimpleSystemsManagement.</returns>
        CreateDocumentResponse EndCreateDocument(IAsyncResult asyncResult);

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
        DeleteAssociationResponse DeleteAssociation(string instanceId, string name);

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
        DeleteAssociationResponse DeleteAssociation(DeleteAssociationRequest request);

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
        IAsyncResult BeginDeleteAssociation(DeleteAssociationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteAssociation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteAssociation.</param>
        /// 
        /// <returns>Returns a  DeleteAssociationResult from SimpleSystemsManagement.</returns>
        DeleteAssociationResponse EndDeleteAssociation(IAsyncResult asyncResult);

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
        DeleteDocumentResponse DeleteDocument(string name);

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
        DeleteDocumentResponse DeleteDocument(DeleteDocumentRequest request);

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
        IAsyncResult BeginDeleteDocument(DeleteDocumentRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteDocument operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteDocument.</param>
        /// 
        /// <returns>Returns a  DeleteDocumentResult from SimpleSystemsManagement.</returns>
        DeleteDocumentResponse EndDeleteDocument(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeAssociation


        /// <summary>
        /// Describes the associations for the specified SSM document or instance.
        /// </summary>
        /// <param name="instanceId">The Windows Server instance ID.</param>
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
        DescribeAssociationResponse DescribeAssociation(string instanceId, string name);

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
        DescribeAssociationResponse DescribeAssociation(DescribeAssociationRequest request);

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
        IAsyncResult BeginDescribeAssociation(DescribeAssociationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeAssociation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeAssociation.</param>
        /// 
        /// <returns>Returns a  DescribeAssociationResult from SimpleSystemsManagement.</returns>
        DescribeAssociationResponse EndDescribeAssociation(IAsyncResult asyncResult);

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
        DescribeDocumentResponse DescribeDocument(string name);

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
        DescribeDocumentResponse DescribeDocument(DescribeDocumentRequest request);

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
        IAsyncResult BeginDescribeDocument(DescribeDocumentRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeDocument operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeDocument.</param>
        /// 
        /// <returns>Returns a  DescribeDocumentResult from SimpleSystemsManagement.</returns>
        DescribeDocumentResponse EndDescribeDocument(IAsyncResult asyncResult);

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
        DescribeInstanceInformationResponse DescribeInstanceInformation();

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
        DescribeInstanceInformationResponse DescribeInstanceInformation(DescribeInstanceInformationRequest request);

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
        IAsyncResult BeginDescribeInstanceInformation(DescribeInstanceInformationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeInstanceInformation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeInstanceInformation.</param>
        /// 
        /// <returns>Returns a  DescribeInstanceInformationResult from SimpleSystemsManagement.</returns>
        DescribeInstanceInformationResponse EndDescribeInstanceInformation(IAsyncResult asyncResult);

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
        GetDocumentResponse GetDocument(string name);

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
        GetDocumentResponse GetDocument(GetDocumentRequest request);

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
        IAsyncResult BeginGetDocument(GetDocumentRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetDocument operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDocument.</param>
        /// 
        /// <returns>Returns a  GetDocumentResult from SimpleSystemsManagement.</returns>
        GetDocumentResponse EndGetDocument(IAsyncResult asyncResult);

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
        ListAssociationsResponse ListAssociations(ListAssociationsRequest request);

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
        IAsyncResult BeginListAssociations(ListAssociationsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListAssociations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAssociations.</param>
        /// 
        /// <returns>Returns a  ListAssociationsResult from SimpleSystemsManagement.</returns>
        ListAssociationsResponse EndListAssociations(IAsyncResult asyncResult);

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
        ListCommandInvocationsResponse ListCommandInvocations();

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
        ListCommandInvocationsResponse ListCommandInvocations(string commandId);

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
        ListCommandInvocationsResponse ListCommandInvocations(ListCommandInvocationsRequest request);

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
        IAsyncResult BeginListCommandInvocations(ListCommandInvocationsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListCommandInvocations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListCommandInvocations.</param>
        /// 
        /// <returns>Returns a  ListCommandInvocationsResult from SimpleSystemsManagement.</returns>
        ListCommandInvocationsResponse EndListCommandInvocations(IAsyncResult asyncResult);

        #endregion
        
        #region  ListCommands


        /// <summary>
        /// Lists the commands requested by users of the AWS account.
        /// </summary>
        /// 
        /// <returns>The response from the ListCommands service method, as returned by SimpleSystemsManagement.</returns>
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
        ListCommandsResponse ListCommands();

        /// <summary>
        /// Lists the commands requested by users of the AWS account.
        /// </summary>
        /// <param name="commandId">(Optional) If provided, lists only the specified command.</param>
        /// 
        /// <returns>The response from the ListCommands service method, as returned by SimpleSystemsManagement.</returns>
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
        ListCommandsResponse ListCommands(string commandId);

        /// <summary>
        /// Lists the commands requested by users of the AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCommands service method.</param>
        /// 
        /// <returns>The response from the ListCommands service method, as returned by SimpleSystemsManagement.</returns>
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
        ListCommandsResponse ListCommands(ListCommandsRequest request);

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
        IAsyncResult BeginListCommands(ListCommandsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListCommands operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListCommands.</param>
        /// 
        /// <returns>Returns a  ListCommandsResult from SimpleSystemsManagement.</returns>
        ListCommandsResponse EndListCommands(IAsyncResult asyncResult);

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
        ListDocumentsResponse ListDocuments();

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
        ListDocumentsResponse ListDocuments(ListDocumentsRequest request);

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
        IAsyncResult BeginListDocuments(ListDocumentsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListDocuments operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListDocuments.</param>
        /// 
        /// <returns>Returns a  ListDocumentsResult from SimpleSystemsManagement.</returns>
        ListDocumentsResponse EndListDocuments(IAsyncResult asyncResult);

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
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.UnsupportedPlatformTypeException">
        /// The document does not support the platform type of the given instance ID(s).
        /// </exception>
        SendCommandResponse SendCommand(string documentName, List<string> instanceIds);

        /// <summary>
        /// Executes commands on one or more remote instances.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SendCommand service method.</param>
        /// 
        /// <returns>The response from the SendCommand service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.DuplicateInstanceIdException">
        /// You cannot specify an instance ID in more than one association.
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
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.UnsupportedPlatformTypeException">
        /// The document does not support the platform type of the given instance ID(s).
        /// </exception>
        SendCommandResponse SendCommand(SendCommandRequest request);

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
        IAsyncResult BeginSendCommand(SendCommandRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  SendCommand operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSendCommand.</param>
        /// 
        /// <returns>Returns a  SendCommandResult from SimpleSystemsManagement.</returns>
        SendCommandResponse EndSendCommand(IAsyncResult asyncResult);

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
        UpdateAssociationStatusResponse UpdateAssociationStatus(UpdateAssociationStatusRequest request);

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
        IAsyncResult BeginUpdateAssociationStatus(UpdateAssociationStatusRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateAssociationStatus operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateAssociationStatus.</param>
        /// 
        /// <returns>Returns a  UpdateAssociationStatusResult from SimpleSystemsManagement.</returns>
        UpdateAssociationStatusResponse EndUpdateAssociationStatus(IAsyncResult asyncResult);

        #endregion
        
    }
}