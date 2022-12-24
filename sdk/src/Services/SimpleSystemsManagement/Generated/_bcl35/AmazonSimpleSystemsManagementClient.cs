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
    /// Amazon Web Services Systems Manager is the operations hub for your Amazon Web Services
    /// applications and resources and a secure end-to-end management solution for hybrid
    /// cloud environments that enables safe and secure operations at scale.
    /// 
    ///  
    /// <para>
    /// This reference is intended to be used with the <a href="https://docs.aws.amazon.com/systems-manager/latest/userguide/">Amazon
    /// Web Services Systems Manager User Guide</a>. To get started, see <a href="https://docs.aws.amazon.com/systems-manager/latest/userguide/systems-manager-setting-up.html">Setting
    /// up Amazon Web Services Systems Manager</a>.
    /// </para>
    ///  <p class="title"> <b>Related resources</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// For information about each of the capabilities that comprise Systems Manager, see
    /// <a href="https://docs.aws.amazon.com/systems-manager-automation-runbooks/latest/userguide/what-is-systems-manager.html#systems-manager-capabilities">Systems
    /// Manager capabilities</a> in the <i>Amazon Web Services Systems Manager User Guide</i>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// For details about predefined runbooks for Automation, a capability of Amazon Web Services
    /// Systems Manager, see the <i> <a href="https://docs.aws.amazon.com/systems-manager-automation-runbooks/latest/userguide/automation-runbook-reference.html">Systems
    /// Manager Automation runbook reference</a> </i>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// For information about AppConfig, a capability of Systems Manager, see the <i> <a href="https://docs.aws.amazon.com/appconfig/latest/userguide/">AppConfig
    /// User Guide</a> </i> and the <i> <a href="https://docs.aws.amazon.com/appconfig/2019-10-09/APIReference/">AppConfig
    /// API Reference</a> </i>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// For information about Incident Manager, a capability of Systems Manager, see the <i>
    /// <a href="https://docs.aws.amazon.com/incident-manager/latest/userguide/">Systems Manager
    /// Incident Manager User Guide</a> </i> and the <i> <a href="https://docs.aws.amazon.com/incident-manager/latest/APIReference/">Systems
    /// Manager Incident Manager API Reference</a> </i>.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class AmazonSimpleSystemsManagementClient : AmazonServiceClient, IAmazonSimpleSystemsManagement
    {
        private static IServiceMetadata serviceMetadata = new AmazonSimpleSystemsManagementMetadata();

#if BCL45 || AWS_ASYNC_ENUMERABLES_API
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

        /// <summary>
        /// Customize the pipeline
        /// </summary>
        /// <param name="pipeline"></param>
        protected override void CustomizeRuntimePipeline(RuntimePipeline pipeline)
        {
            pipeline.RemoveHandler<Amazon.Runtime.Internal.EndpointResolver>();
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonSimpleSystemsManagementEndpointResolver());
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

        /// <summary>
        /// Adds or overwrites one or more tags for the specified resource. <i>Tags</i> are metadata
        /// that you can assign to your automations, documents, managed nodes, maintenance windows,
        /// Parameter Store parameters, and patch baselines. Tags enable you to categorize your
        /// resources in different ways, for example, by purpose, owner, or environment. Each
        /// tag consists of a key and an optional value, both of which you define. For example,
        /// you could define a set of tags for your account's managed nodes that helps you track
        /// each node's owner and stack level. For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        ///  <code>Key=Owner,Value=DbAdmin</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Key=Owner,Value=SysAdmin</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Key=Owner,Value=Dev</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Key=Stack,Value=Production</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Key=Stack,Value=Pre-Production</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Key=Stack,Value=Test</code> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Most resources can have a maximum of 50 tags. Automations can have a maximum of 5
        /// tags.
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
        /// For more information about using tags with Amazon Elastic Compute Cloud (Amazon EC2)
        /// instances, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/Using_Tags.html">Tagging
        /// your Amazon EC2 resources</a> in the <i>Amazon EC2 User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddTagsToResource service method.</param>
        /// 
        /// <returns>The response from the AddTagsToResource service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidResourceIdException">
        /// The resource ID isn't valid. Verify that you entered the correct ID and try again.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidResourceTypeException">
        /// The resource type isn't valid. For example, if you are attempting to tag an EC2 instance,
        /// the instance must be a registered managed node.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.TooManyTagsErrorException">
        /// The <code>Targets</code> parameter includes too many tags. Remove one or more tags
        /// and try the command again.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.TooManyUpdatesException">
        /// There are concurrent updates for a resource that supports one update at a time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/AddTagsToResource">REST API Reference for AddTagsToResource Operation</seealso>
        public virtual AddTagsToResourceResponse AddTagsToResource(AddTagsToResourceRequest request)
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
        /// <param name="request">Container for the necessary parameters to execute the AddTagsToResource operation on AmazonSimpleSystemsManagementClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAddTagsToResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/AddTagsToResource">REST API Reference for AddTagsToResource Operation</seealso>
        public virtual IAsyncResult BeginAddTagsToResource(AddTagsToResourceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AddTagsToResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddTagsToResourceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AddTagsToResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAddTagsToResource.</param>
        /// 
        /// <returns>Returns a  AddTagsToResourceResult from SimpleSystemsManagement.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/AddTagsToResource">REST API Reference for AddTagsToResource Operation</seealso>
        public virtual AddTagsToResourceResponse EndAddTagsToResource(IAsyncResult asyncResult)
        {
            return EndInvoke<AddTagsToResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  AssociateOpsItemRelatedItem

        /// <summary>
        /// Associates a related item to a Systems Manager OpsCenter OpsItem. For example, you
        /// can associate an Incident Manager incident or analysis with an OpsItem. Incident Manager
        /// and OpsCenter are capabilities of Amazon Web Services Systems Manager.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateOpsItemRelatedItem service method.</param>
        /// 
        /// <returns>The response from the AssociateOpsItemRelatedItem service method, as returned by SimpleSystemsManagement.</returns>
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
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.OpsItemRelatedItemAlreadyExistsException">
        /// The Amazon Resource Name (ARN) is already associated with the OpsItem.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/AssociateOpsItemRelatedItem">REST API Reference for AssociateOpsItemRelatedItem Operation</seealso>
        public virtual AssociateOpsItemRelatedItemResponse AssociateOpsItemRelatedItem(AssociateOpsItemRelatedItemRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateOpsItemRelatedItemRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateOpsItemRelatedItemResponseUnmarshaller.Instance;

            return Invoke<AssociateOpsItemRelatedItemResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AssociateOpsItemRelatedItem operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateOpsItemRelatedItem operation on AmazonSimpleSystemsManagementClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAssociateOpsItemRelatedItem
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/AssociateOpsItemRelatedItem">REST API Reference for AssociateOpsItemRelatedItem Operation</seealso>
        public virtual IAsyncResult BeginAssociateOpsItemRelatedItem(AssociateOpsItemRelatedItemRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateOpsItemRelatedItemRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateOpsItemRelatedItemResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AssociateOpsItemRelatedItem operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssociateOpsItemRelatedItem.</param>
        /// 
        /// <returns>Returns a  AssociateOpsItemRelatedItemResult from SimpleSystemsManagement.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/AssociateOpsItemRelatedItem">REST API Reference for AssociateOpsItemRelatedItem Operation</seealso>
        public virtual AssociateOpsItemRelatedItemResponse EndAssociateOpsItemRelatedItem(IAsyncResult asyncResult)
        {
            return EndInvoke<AssociateOpsItemRelatedItemResponse>(asyncResult);
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
        /// You can't specify a managed node ID in more than one association.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidCommandIdException">
        /// The specified command ID isn't valid. Verify the ID and try again.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidInstanceIdException">
        /// The following problems can cause this exception:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You don't have permission to access the managed node.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Amazon Web Services Systems Manager Agent(SSM Agent) isn't running. Verify that SSM
        /// Agent is running.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// SSM Agent isn't registered with the SSM endpoint. Try reinstalling SSM Agent.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The managed node isn't in valid state. Valid states are: <code>Running</code>, <code>Pending</code>,
        /// <code>Stopped</code>, and <code>Stopping</code>. Invalid states are: <code>Shutting-down</code>
        /// and <code>Terminated</code>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/CancelCommand">REST API Reference for CancelCommand Operation</seealso>
        public virtual CancelCommandResponse CancelCommand(string commandId)
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
        /// <param name="instanceIds">(Optional) A list of managed node IDs on which you want to cancel the command. If not provided, the command is canceled on every node on which it was requested.</param>
        /// 
        /// <returns>The response from the CancelCommand service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.DuplicateInstanceIdException">
        /// You can't specify a managed node ID in more than one association.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidCommandIdException">
        /// The specified command ID isn't valid. Verify the ID and try again.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidInstanceIdException">
        /// The following problems can cause this exception:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You don't have permission to access the managed node.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Amazon Web Services Systems Manager Agent(SSM Agent) isn't running. Verify that SSM
        /// Agent is running.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// SSM Agent isn't registered with the SSM endpoint. Try reinstalling SSM Agent.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The managed node isn't in valid state. Valid states are: <code>Running</code>, <code>Pending</code>,
        /// <code>Stopped</code>, and <code>Stopping</code>. Invalid states are: <code>Shutting-down</code>
        /// and <code>Terminated</code>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/CancelCommand">REST API Reference for CancelCommand Operation</seealso>
        public virtual CancelCommandResponse CancelCommand(string commandId, List<string> instanceIds)
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
        /// You can't specify a managed node ID in more than one association.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidCommandIdException">
        /// The specified command ID isn't valid. Verify the ID and try again.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidInstanceIdException">
        /// The following problems can cause this exception:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You don't have permission to access the managed node.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Amazon Web Services Systems Manager Agent(SSM Agent) isn't running. Verify that SSM
        /// Agent is running.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// SSM Agent isn't registered with the SSM endpoint. Try reinstalling SSM Agent.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The managed node isn't in valid state. Valid states are: <code>Running</code>, <code>Pending</code>,
        /// <code>Stopped</code>, and <code>Stopping</code>. Invalid states are: <code>Shutting-down</code>
        /// and <code>Terminated</code>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/CancelCommand">REST API Reference for CancelCommand Operation</seealso>
        public virtual CancelCommandResponse CancelCommand(CancelCommandRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CancelCommandRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelCommandResponseUnmarshaller.Instance;

            return Invoke<CancelCommandResponse>(request, options);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/CancelCommand">REST API Reference for CancelCommand Operation</seealso>
        public virtual IAsyncResult BeginCancelCommand(CancelCommandRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CancelCommandRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelCommandResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CancelCommand operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCancelCommand.</param>
        /// 
        /// <returns>Returns a  CancelCommandResult from SimpleSystemsManagement.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/CancelCommand">REST API Reference for CancelCommand Operation</seealso>
        public virtual CancelCommandResponse EndCancelCommand(IAsyncResult asyncResult)
        {
            return EndInvoke<CancelCommandResponse>(asyncResult);
        }

        #endregion
        
        #region  CancelMaintenanceWindowExecution

        /// <summary>
        /// Stops a maintenance window execution that is already in progress and cancels any tasks
        /// in the window that haven't already starting running. Tasks already in progress will
        /// continue to completion.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelMaintenanceWindowExecution service method.</param>
        /// 
        /// <returns>The response from the CancelMaintenanceWindowExecution service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.DoesNotExistException">
        /// Error returned when the ID specified for a resource, such as a maintenance window
        /// or patch baseline, doesn't exist.
        /// 
        ///  
        /// <para>
        /// For information about resource quotas in Amazon Web Services Systems Manager, see
        /// <a href="https://docs.aws.amazon.com/general/latest/gr/ssm.html#limits_ssm">Systems
        /// Manager service quotas</a> in the <i>Amazon Web Services General Reference</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/CancelMaintenanceWindowExecution">REST API Reference for CancelMaintenanceWindowExecution Operation</seealso>
        public virtual CancelMaintenanceWindowExecutionResponse CancelMaintenanceWindowExecution(CancelMaintenanceWindowExecutionRequest request)
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
        /// <param name="request">Container for the necessary parameters to execute the CancelMaintenanceWindowExecution operation on AmazonSimpleSystemsManagementClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCancelMaintenanceWindowExecution
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/CancelMaintenanceWindowExecution">REST API Reference for CancelMaintenanceWindowExecution Operation</seealso>
        public virtual IAsyncResult BeginCancelMaintenanceWindowExecution(CancelMaintenanceWindowExecutionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CancelMaintenanceWindowExecutionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelMaintenanceWindowExecutionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CancelMaintenanceWindowExecution operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCancelMaintenanceWindowExecution.</param>
        /// 
        /// <returns>Returns a  CancelMaintenanceWindowExecutionResult from SimpleSystemsManagement.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/CancelMaintenanceWindowExecution">REST API Reference for CancelMaintenanceWindowExecution Operation</seealso>
        public virtual CancelMaintenanceWindowExecutionResponse EndCancelMaintenanceWindowExecution(IAsyncResult asyncResult)
        {
            return EndInvoke<CancelMaintenanceWindowExecutionResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateActivation

        /// <summary>
        /// Generates an activation code and activation ID you can use to register your on-premises
        /// servers, edge devices, or virtual machine (VM) with Amazon Web Services Systems Manager.
        /// Registering these machines with Systems Manager makes it possible to manage them using
        /// Systems Manager capabilities. You use the activation code and ID when installing SSM
        /// Agent on machines in your hybrid environment. For more information about requirements
        /// for managing on-premises machines using Systems Manager, see <a href="https://docs.aws.amazon.com/systems-manager/latest/userguide/systems-manager-managedinstances.html">Setting
        /// up Amazon Web Services Systems Manager for hybrid environments</a> in the <i>Amazon
        /// Web Services Systems Manager User Guide</i>. 
        /// 
        ///  <note> 
        /// <para>
        /// Amazon Elastic Compute Cloud (Amazon EC2) instances, edge devices, and on-premises
        /// servers and VMs that are configured for Systems Manager are all called <i>managed
        /// nodes</i>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateActivation service method.</param>
        /// 
        /// <returns>The response from the CreateActivation service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidParametersException">
        /// You must specify values for all required parameters in the Amazon Web Services Systems
        /// Manager document (SSM document). You can only supply values to parameters defined
        /// in the SSM document.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/CreateActivation">REST API Reference for CreateActivation Operation</seealso>
        public virtual CreateActivationResponse CreateActivation(CreateActivationRequest request)
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
        /// <param name="request">Container for the necessary parameters to execute the CreateActivation operation on AmazonSimpleSystemsManagementClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateActivation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/CreateActivation">REST API Reference for CreateActivation Operation</seealso>
        public virtual IAsyncResult BeginCreateActivation(CreateActivationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateActivationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateActivationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateActivation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateActivation.</param>
        /// 
        /// <returns>Returns a  CreateActivationResult from SimpleSystemsManagement.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/CreateActivation">REST API Reference for CreateActivation Operation</seealso>
        public virtual CreateActivationResponse EndCreateActivation(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateActivationResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateAssociation

        /// <summary>
        /// A State Manager association defines the state that you want to maintain on your managed
        /// nodes. For example, an association can specify that anti-virus software must be installed
        /// and running on your managed nodes, or that certain ports must be closed. For static
        /// targets, the association specifies a schedule for when the configuration is reapplied.
        /// For dynamic targets, such as an Amazon Web Services resource group or an Amazon Web
        /// Services autoscaling group, State Manager, a capability of Amazon Web Services Systems
        /// Manager applies the configuration when new managed nodes are added to the group. The
        /// association also specifies actions to take when applying the configuration. For example,
        /// an association for anti-virus software might run once a day. If the software isn't
        /// installed, then State Manager installs it. If the software is installed, but the service
        /// isn't running, then the association might instruct State Manager to start the service.
        /// </summary>
        /// <param name="instanceId">The managed node ID. <note>  <code>InstanceId</code> has been deprecated. To specify a managed node ID for an association, use the <code>Targets</code> parameter. Requests that include the parameter <code>InstanceID</code> with Systems Manager documents (SSM documents) that use schema version 2.0 or later will fail. In addition, if you use the parameter <code>InstanceId</code>, you can't use the parameters <code>AssociationName</code>, <code>DocumentVersion</code>, <code>MaxErrors</code>, <code>MaxConcurrency</code>, <code>OutputLocation</code>, or <code>ScheduleExpression</code>. To use these parameters, you must use the <code>Targets</code> parameter. </note></param>
        /// <param name="name">The name of the SSM Command document or Automation runbook that contains the configuration information for the managed node. You can specify Amazon Web Services-predefined documents, documents you created, or a document that is shared with you from another account. For Systems Manager documents (SSM documents) that are shared with you from other Amazon Web Services accounts, you must specify the complete SSM document ARN, in the following format:  <code>arn:<i>partition</i>:ssm:<i>region</i>:<i>account-id</i>:document/<i>document-name</i> </code>  For example:  <code>arn:aws:ssm:us-east-2:12345678912:document/My-Shared-Document</code>  For Amazon Web Services-predefined documents and SSM documents you created in your account, you only need to specify the document name. For example, <code>AWS-ApplyPatchBaseline</code> or <code>My-Document</code>.</param>
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
        /// The specified SSM document doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidDocumentVersionException">
        /// The document version isn't valid or doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidInstanceIdException">
        /// The following problems can cause this exception:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You don't have permission to access the managed node.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Amazon Web Services Systems Manager Agent(SSM Agent) isn't running. Verify that SSM
        /// Agent is running.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// SSM Agent isn't registered with the SSM endpoint. Try reinstalling SSM Agent.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The managed node isn't in valid state. Valid states are: <code>Running</code>, <code>Pending</code>,
        /// <code>Stopped</code>, and <code>Stopping</code>. Invalid states are: <code>Shutting-down</code>
        /// and <code>Terminated</code>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidOutputLocationException">
        /// The output location isn't valid or doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidParametersException">
        /// You must specify values for all required parameters in the Amazon Web Services Systems
        /// Manager document (SSM document). You can only supply values to parameters defined
        /// in the SSM document.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidScheduleException">
        /// The schedule is invalid. Verify your cron or rate expression and try again.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidTagException">
        /// The specified tag key or value isn't valid.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidTargetException">
        /// The target isn't valid or doesn't exist. It might not be configured for Systems Manager
        /// or you might not have permission to perform the operation.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidTargetMapsException">
        /// TargetMap parameter isn't valid.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.UnsupportedPlatformTypeException">
        /// The document doesn't support the platform type of the given managed node ID(s). For
        /// example, you sent an document for a Windows managed node to a Linux node.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/CreateAssociation">REST API Reference for CreateAssociation Operation</seealso>
        public virtual CreateAssociationResponse CreateAssociation(string instanceId, string name)
        {
            var request = new CreateAssociationRequest();
            request.InstanceId = instanceId;
            request.Name = name;
            return CreateAssociation(request);
        }


        /// <summary>
        /// A State Manager association defines the state that you want to maintain on your managed
        /// nodes. For example, an association can specify that anti-virus software must be installed
        /// and running on your managed nodes, or that certain ports must be closed. For static
        /// targets, the association specifies a schedule for when the configuration is reapplied.
        /// For dynamic targets, such as an Amazon Web Services resource group or an Amazon Web
        /// Services autoscaling group, State Manager, a capability of Amazon Web Services Systems
        /// Manager applies the configuration when new managed nodes are added to the group. The
        /// association also specifies actions to take when applying the configuration. For example,
        /// an association for anti-virus software might run once a day. If the software isn't
        /// installed, then State Manager installs it. If the software is installed, but the service
        /// isn't running, then the association might instruct State Manager to start the service.
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
        /// The specified SSM document doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidDocumentVersionException">
        /// The document version isn't valid or doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidInstanceIdException">
        /// The following problems can cause this exception:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You don't have permission to access the managed node.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Amazon Web Services Systems Manager Agent(SSM Agent) isn't running. Verify that SSM
        /// Agent is running.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// SSM Agent isn't registered with the SSM endpoint. Try reinstalling SSM Agent.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The managed node isn't in valid state. Valid states are: <code>Running</code>, <code>Pending</code>,
        /// <code>Stopped</code>, and <code>Stopping</code>. Invalid states are: <code>Shutting-down</code>
        /// and <code>Terminated</code>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidOutputLocationException">
        /// The output location isn't valid or doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidParametersException">
        /// You must specify values for all required parameters in the Amazon Web Services Systems
        /// Manager document (SSM document). You can only supply values to parameters defined
        /// in the SSM document.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidScheduleException">
        /// The schedule is invalid. Verify your cron or rate expression and try again.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidTagException">
        /// The specified tag key or value isn't valid.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidTargetException">
        /// The target isn't valid or doesn't exist. It might not be configured for Systems Manager
        /// or you might not have permission to perform the operation.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidTargetMapsException">
        /// TargetMap parameter isn't valid.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.UnsupportedPlatformTypeException">
        /// The document doesn't support the platform type of the given managed node ID(s). For
        /// example, you sent an document for a Windows managed node to a Linux node.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/CreateAssociation">REST API Reference for CreateAssociation Operation</seealso>
        public virtual CreateAssociationResponse CreateAssociation(CreateAssociationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAssociationResponseUnmarshaller.Instance;

            return Invoke<CreateAssociationResponse>(request, options);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/CreateAssociation">REST API Reference for CreateAssociation Operation</seealso>
        public virtual IAsyncResult BeginCreateAssociation(CreateAssociationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAssociationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateAssociation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateAssociation.</param>
        /// 
        /// <returns>Returns a  CreateAssociationResult from SimpleSystemsManagement.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/CreateAssociation">REST API Reference for CreateAssociation Operation</seealso>
        public virtual CreateAssociationResponse EndCreateAssociation(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateAssociationResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateAssociationBatch

        /// <summary>
        /// Associates the specified Amazon Web Services Systems Manager document (SSM document)
        /// with the specified managed nodes or targets.
        /// 
        ///  
        /// <para>
        /// When you associate a document with one or more managed nodes using IDs or tags, Amazon
        /// Web Services Systems Manager Agent (SSM Agent) running on the managed node processes
        /// the document and configures the node as specified.
        /// </para>
        ///  
        /// <para>
        /// If you associate a document with a managed node that already has an associated document,
        /// the system returns the AssociationAlreadyExists exception.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAssociationBatch service method.</param>
        /// 
        /// <returns>The response from the CreateAssociationBatch service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.AssociationLimitExceededException">
        /// You can have at most 2,000 active associations.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.DuplicateInstanceIdException">
        /// You can't specify a managed node ID in more than one association.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidDocumentException">
        /// The specified SSM document doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidDocumentVersionException">
        /// The document version isn't valid or doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidInstanceIdException">
        /// The following problems can cause this exception:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You don't have permission to access the managed node.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Amazon Web Services Systems Manager Agent(SSM Agent) isn't running. Verify that SSM
        /// Agent is running.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// SSM Agent isn't registered with the SSM endpoint. Try reinstalling SSM Agent.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The managed node isn't in valid state. Valid states are: <code>Running</code>, <code>Pending</code>,
        /// <code>Stopped</code>, and <code>Stopping</code>. Invalid states are: <code>Shutting-down</code>
        /// and <code>Terminated</code>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidOutputLocationException">
        /// The output location isn't valid or doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidParametersException">
        /// You must specify values for all required parameters in the Amazon Web Services Systems
        /// Manager document (SSM document). You can only supply values to parameters defined
        /// in the SSM document.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidScheduleException">
        /// The schedule is invalid. Verify your cron or rate expression and try again.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidTargetException">
        /// The target isn't valid or doesn't exist. It might not be configured for Systems Manager
        /// or you might not have permission to perform the operation.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidTargetMapsException">
        /// TargetMap parameter isn't valid.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.UnsupportedPlatformTypeException">
        /// The document doesn't support the platform type of the given managed node ID(s). For
        /// example, you sent an document for a Windows managed node to a Linux node.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/CreateAssociationBatch">REST API Reference for CreateAssociationBatch Operation</seealso>
        public virtual CreateAssociationBatchResponse CreateAssociationBatch(CreateAssociationBatchRequest request)
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
        /// <param name="request">Container for the necessary parameters to execute the CreateAssociationBatch operation on AmazonSimpleSystemsManagementClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateAssociationBatch
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/CreateAssociationBatch">REST API Reference for CreateAssociationBatch Operation</seealso>
        public virtual IAsyncResult BeginCreateAssociationBatch(CreateAssociationBatchRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateAssociationBatchRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAssociationBatchResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateAssociationBatch operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateAssociationBatch.</param>
        /// 
        /// <returns>Returns a  CreateAssociationBatchResult from SimpleSystemsManagement.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/CreateAssociationBatch">REST API Reference for CreateAssociationBatch Operation</seealso>
        public virtual CreateAssociationBatchResponse EndCreateAssociationBatch(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateAssociationBatchResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateDocument

        /// <summary>
        /// Creates a Amazon Web Services Systems Manager (SSM document). An SSM document defines
        /// the actions that Systems Manager performs on your managed nodes. For more information
        /// about SSM documents, including information about supported schemas, features, and
        /// syntax, see <a href="https://docs.aws.amazon.com/systems-manager/latest/userguide/sysman-ssm-docs.html">Amazon
        /// Web Services Systems Manager Documents</a> in the <i>Amazon Web Services Systems Manager
        /// User Guide</i>.
        /// </summary>
        /// <param name="content">The content for the new SSM document in JSON or YAML format. We recommend storing the contents for your new document in an external JSON or YAML file and referencing the file in a command. For examples, see the following topics in the <i>Amazon Web Services Systems Manager User Guide</i>. <ul> <li>  <a href="https://docs.aws.amazon.com/systems-manager/latest/userguide/create-ssm-document-api.html">Create an SSM document (Amazon Web Services API)</a>  </li> <li>  <a href="https://docs.aws.amazon.com/systems-manager/latest/userguide/create-ssm-document-cli.html">Create an SSM document (Amazon Web Services CLI)</a>  </li> <li>  <a href="https://docs.aws.amazon.com/systems-manager/latest/userguide/create-ssm-document-api.html">Create an SSM document (API)</a>  </li> </ul></param>
        /// <param name="name">A name for the SSM document. <important> You can't use the following strings as document name prefixes. These are reserved by Amazon Web Services for use as document name prefixes: <ul> <li>  <code>aws</code>  </li> <li>  <code>amazon</code>  </li> <li>  <code>amzn</code>  </li> </ul> </important></param>
        /// 
        /// <returns>The response from the CreateDocument service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.DocumentAlreadyExistsException">
        /// The specified document already exists.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.DocumentLimitExceededException">
        /// You can have at most 500 active SSM documents.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidDocumentContentException">
        /// The content for the document isn't valid.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidDocumentSchemaVersionException">
        /// The version of the document schema isn't supported.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.MaxDocumentSizeExceededException">
        /// The size limit of a document is 64 KB.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/CreateDocument">REST API Reference for CreateDocument Operation</seealso>
        public virtual CreateDocumentResponse CreateDocument(string content, string name)
        {
            var request = new CreateDocumentRequest();
            request.Content = content;
            request.Name = name;
            return CreateDocument(request);
        }


        /// <summary>
        /// Creates a Amazon Web Services Systems Manager (SSM document). An SSM document defines
        /// the actions that Systems Manager performs on your managed nodes. For more information
        /// about SSM documents, including information about supported schemas, features, and
        /// syntax, see <a href="https://docs.aws.amazon.com/systems-manager/latest/userguide/sysman-ssm-docs.html">Amazon
        /// Web Services Systems Manager Documents</a> in the <i>Amazon Web Services Systems Manager
        /// User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDocument service method.</param>
        /// 
        /// <returns>The response from the CreateDocument service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.DocumentAlreadyExistsException">
        /// The specified document already exists.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.DocumentLimitExceededException">
        /// You can have at most 500 active SSM documents.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidDocumentContentException">
        /// The content for the document isn't valid.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidDocumentSchemaVersionException">
        /// The version of the document schema isn't supported.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.MaxDocumentSizeExceededException">
        /// The size limit of a document is 64 KB.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/CreateDocument">REST API Reference for CreateDocument Operation</seealso>
        public virtual CreateDocumentResponse CreateDocument(CreateDocumentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDocumentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDocumentResponseUnmarshaller.Instance;

            return Invoke<CreateDocumentResponse>(request, options);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/CreateDocument">REST API Reference for CreateDocument Operation</seealso>
        public virtual IAsyncResult BeginCreateDocument(CreateDocumentRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDocumentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDocumentResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateDocument operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateDocument.</param>
        /// 
        /// <returns>Returns a  CreateDocumentResult from SimpleSystemsManagement.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/CreateDocument">REST API Reference for CreateDocument Operation</seealso>
        public virtual CreateDocumentResponse EndCreateDocument(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateDocumentResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateMaintenanceWindow

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
        /// For information about resource quotas in Systems Manager, see <a href="https://docs.aws.amazon.com/general/latest/gr/ssm.html#limits_ssm">Systems
        /// Manager service quotas</a> in the <i>Amazon Web Services General Reference</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/CreateMaintenanceWindow">REST API Reference for CreateMaintenanceWindow Operation</seealso>
        public virtual CreateMaintenanceWindowResponse CreateMaintenanceWindow(CreateMaintenanceWindowRequest request)
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
        /// <param name="request">Container for the necessary parameters to execute the CreateMaintenanceWindow operation on AmazonSimpleSystemsManagementClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateMaintenanceWindow
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/CreateMaintenanceWindow">REST API Reference for CreateMaintenanceWindow Operation</seealso>
        public virtual IAsyncResult BeginCreateMaintenanceWindow(CreateMaintenanceWindowRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateMaintenanceWindowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateMaintenanceWindowResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateMaintenanceWindow operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateMaintenanceWindow.</param>
        /// 
        /// <returns>Returns a  CreateMaintenanceWindowResult from SimpleSystemsManagement.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/CreateMaintenanceWindow">REST API Reference for CreateMaintenanceWindow Operation</seealso>
        public virtual CreateMaintenanceWindowResponse EndCreateMaintenanceWindow(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateMaintenanceWindowResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateOpsItem

        /// <summary>
        /// Creates a new OpsItem. You must have permission in Identity and Access Management
        /// (IAM) to create a new OpsItem. For more information, see <a href="https://docs.aws.amazon.com/systems-manager/latest/userguide/OpsCenter-getting-started.html">Getting
        /// started with OpsCenter</a> in the <i>Amazon Web Services Systems Manager User Guide</i>.
        /// 
        ///  
        /// <para>
        /// Operations engineers and IT professionals use Amazon Web Services Systems Manager
        /// OpsCenter to view, investigate, and remediate operational issues impacting the performance
        /// and health of their Amazon Web Services resources. For more information, see <a href="https://docs.aws.amazon.com/systems-manager/latest/userguide/OpsCenter.html">Amazon
        /// Web Services Systems Manager OpsCenter</a> in the <i>Amazon Web Services Systems Manager
        /// User Guide</i>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateOpsItem service method.</param>
        /// 
        /// <returns>The response from the CreateOpsItem service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.OpsItemAccessDeniedException">
        /// You don't have permission to view OpsItems in the specified account. Verify that your
        /// account is configured either as a Systems Manager delegated administrator or that
        /// you are logged into the Organizations management account.
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
        public virtual CreateOpsItemResponse CreateOpsItem(CreateOpsItemRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateOpsItemRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateOpsItemResponseUnmarshaller.Instance;

            return Invoke<CreateOpsItemResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateOpsItem operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateOpsItem operation on AmazonSimpleSystemsManagementClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateOpsItem
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/CreateOpsItem">REST API Reference for CreateOpsItem Operation</seealso>
        public virtual IAsyncResult BeginCreateOpsItem(CreateOpsItemRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateOpsItemRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateOpsItemResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateOpsItem operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateOpsItem.</param>
        /// 
        /// <returns>Returns a  CreateOpsItemResult from SimpleSystemsManagement.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/CreateOpsItem">REST API Reference for CreateOpsItem Operation</seealso>
        public virtual CreateOpsItemResponse EndCreateOpsItem(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateOpsItemResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateOpsMetadata

        /// <summary>
        /// If you create a new application in Application Manager, Amazon Web Services Systems
        /// Manager calls this API operation to specify information about the new application,
        /// including the application type.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateOpsMetadata service method.</param>
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
        public virtual CreateOpsMetadataResponse CreateOpsMetadata(CreateOpsMetadataRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateOpsMetadataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateOpsMetadataResponseUnmarshaller.Instance;

            return Invoke<CreateOpsMetadataResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateOpsMetadata operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateOpsMetadata operation on AmazonSimpleSystemsManagementClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateOpsMetadata
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/CreateOpsMetadata">REST API Reference for CreateOpsMetadata Operation</seealso>
        public virtual IAsyncResult BeginCreateOpsMetadata(CreateOpsMetadataRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateOpsMetadataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateOpsMetadataResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateOpsMetadata operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateOpsMetadata.</param>
        /// 
        /// <returns>Returns a  CreateOpsMetadataResult from SimpleSystemsManagement.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/CreateOpsMetadata">REST API Reference for CreateOpsMetadata Operation</seealso>
        public virtual CreateOpsMetadataResponse EndCreateOpsMetadata(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateOpsMetadataResponse>(asyncResult);
        }

        #endregion
        
        #region  CreatePatchBaseline

        /// <summary>
        /// Creates a patch baseline.
        /// 
        ///  <note> 
        /// <para>
        /// For information about valid key-value pairs in <code>PatchFilters</code> for each
        /// supported operating system type, see <a>PatchFilter</a>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePatchBaseline service method.</param>
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
        /// For information about resource quotas in Systems Manager, see <a href="https://docs.aws.amazon.com/general/latest/gr/ssm.html#limits_ssm">Systems
        /// Manager service quotas</a> in the <i>Amazon Web Services General Reference</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/CreatePatchBaseline">REST API Reference for CreatePatchBaseline Operation</seealso>
        public virtual CreatePatchBaselineResponse CreatePatchBaseline(CreatePatchBaselineRequest request)
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
        /// <param name="request">Container for the necessary parameters to execute the CreatePatchBaseline operation on AmazonSimpleSystemsManagementClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreatePatchBaseline
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/CreatePatchBaseline">REST API Reference for CreatePatchBaseline Operation</seealso>
        public virtual IAsyncResult BeginCreatePatchBaseline(CreatePatchBaselineRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreatePatchBaselineRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePatchBaselineResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreatePatchBaseline operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreatePatchBaseline.</param>
        /// 
        /// <returns>Returns a  CreatePatchBaselineResult from SimpleSystemsManagement.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/CreatePatchBaseline">REST API Reference for CreatePatchBaseline Operation</seealso>
        public virtual CreatePatchBaselineResponse EndCreatePatchBaseline(IAsyncResult asyncResult)
        {
            return EndInvoke<CreatePatchBaselineResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateResourceDataSync

        /// <summary>
        /// A resource data sync helps you view data from multiple sources in a single location.
        /// Amazon Web Services Systems Manager offers two types of resource data sync: <code>SyncToDestination</code>
        /// and <code>SyncFromSource</code>.
        /// 
        ///  
        /// <para>
        /// You can configure Systems Manager Inventory to use the <code>SyncToDestination</code>
        /// type to synchronize Inventory data from multiple Amazon Web Services Regions to a
        /// single Amazon Simple Storage Service (Amazon S3) bucket. For more information, see
        /// <a href="https://docs.aws.amazon.com/systems-manager/latest/userguide/sysman-inventory-datasync.html">Configuring
        /// resource data sync for Inventory</a> in the <i>Amazon Web Services Systems Manager
        /// User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// You can configure Systems Manager Explorer to use the <code>SyncFromSource</code>
        /// type to synchronize operational work items (OpsItems) and operational data (OpsData)
        /// from multiple Amazon Web Services Regions to a single Amazon S3 bucket. This type
        /// can synchronize OpsItems and OpsData from multiple Amazon Web Services accounts and
        /// Amazon Web Services Regions or <code>EntireOrganization</code> by using Organizations.
        /// For more information, see <a href="https://docs.aws.amazon.com/systems-manager/latest/userguide/Explorer-resource-data-sync.html">Setting
        /// up Systems Manager Explorer to display data from multiple accounts and Regions</a>
        /// in the <i>Amazon Web Services Systems Manager User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// A resource data sync is an asynchronous operation that returns immediately. After
        /// a successful initial sync is completed, the system continuously syncs data. To check
        /// the status of a sync, use the <a>ListResourceDataSync</a>.
        /// </para>
        ///  <note> 
        /// <para>
        /// By default, data isn't encrypted in Amazon S3. We strongly recommend that you enable
        /// encryption in Amazon S3 to ensure secure data storage. We also recommend that you
        /// secure access to the Amazon S3 bucket by creating a restrictive bucket policy. 
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateResourceDataSync service method.</param>
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
        public virtual CreateResourceDataSyncResponse CreateResourceDataSync(CreateResourceDataSyncRequest request)
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
        /// <param name="request">Container for the necessary parameters to execute the CreateResourceDataSync operation on AmazonSimpleSystemsManagementClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateResourceDataSync
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/CreateResourceDataSync">REST API Reference for CreateResourceDataSync Operation</seealso>
        public virtual IAsyncResult BeginCreateResourceDataSync(CreateResourceDataSyncRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateResourceDataSyncRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateResourceDataSyncResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateResourceDataSync operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateResourceDataSync.</param>
        /// 
        /// <returns>Returns a  CreateResourceDataSyncResult from SimpleSystemsManagement.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/CreateResourceDataSync">REST API Reference for CreateResourceDataSync Operation</seealso>
        public virtual CreateResourceDataSyncResponse EndCreateResourceDataSync(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateResourceDataSyncResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteActivation

        /// <summary>
        /// Deletes an activation. You aren't required to delete an activation. If you delete
        /// an activation, you can no longer use it to register additional managed nodes. Deleting
        /// an activation doesn't de-register managed nodes. You must manually de-register managed
        /// nodes.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteActivation service method.</param>
        /// 
        /// <returns>The response from the DeleteActivation service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidActivationException">
        /// The activation isn't valid. The activation might have been deleted, or the ActivationId
        /// and the ActivationCode don't match.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidActivationIdException">
        /// The activation ID isn't valid. Verify the you entered the correct ActivationId or
        /// ActivationCode and try again.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.TooManyUpdatesException">
        /// There are concurrent updates for a resource that supports one update at a time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DeleteActivation">REST API Reference for DeleteActivation Operation</seealso>
        public virtual DeleteActivationResponse DeleteActivation(DeleteActivationRequest request)
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
        /// <param name="request">Container for the necessary parameters to execute the DeleteActivation operation on AmazonSimpleSystemsManagementClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteActivation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DeleteActivation">REST API Reference for DeleteActivation Operation</seealso>
        public virtual IAsyncResult BeginDeleteActivation(DeleteActivationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteActivationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteActivationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteActivation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteActivation.</param>
        /// 
        /// <returns>Returns a  DeleteActivationResult from SimpleSystemsManagement.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DeleteActivation">REST API Reference for DeleteActivation Operation</seealso>
        public virtual DeleteActivationResponse EndDeleteActivation(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteActivationResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteAssociation

        /// <summary>
        /// Disassociates the specified Amazon Web Services Systems Manager document (SSM document)
        /// from the specified managed node. If you created the association by using the <code>Targets</code>
        /// parameter, then you must delete the association by using the association ID.
        /// 
        ///  
        /// <para>
        /// When you disassociate a document from a managed node, it doesn't change the configuration
        /// of the node. To change the configuration state of a managed node after you disassociate
        /// a document, you must create a new document with the desired configuration and associate
        /// it with the node.
        /// </para>
        /// </summary>
        /// <param name="instanceId">The managed node ID. <note>  <code>InstanceId</code> has been deprecated. To specify a managed node ID for an association, use the <code>Targets</code> parameter. Requests that include the parameter <code>InstanceID</code> with Systems Manager documents (SSM documents) that use schema version 2.0 or later will fail. In addition, if you use the parameter <code>InstanceId</code>, you can't use the parameters <code>AssociationName</code>, <code>DocumentVersion</code>, <code>MaxErrors</code>, <code>MaxConcurrency</code>, <code>OutputLocation</code>, or <code>ScheduleExpression</code>. To use these parameters, you must use the <code>Targets</code> parameter. </note></param>
        /// <param name="name">The name of the SSM document.</param>
        /// 
        /// <returns>The response from the DeleteAssociation service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.AssociationDoesNotExistException">
        /// The specified association doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidDocumentException">
        /// The specified SSM document doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidInstanceIdException">
        /// The following problems can cause this exception:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You don't have permission to access the managed node.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Amazon Web Services Systems Manager Agent(SSM Agent) isn't running. Verify that SSM
        /// Agent is running.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// SSM Agent isn't registered with the SSM endpoint. Try reinstalling SSM Agent.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The managed node isn't in valid state. Valid states are: <code>Running</code>, <code>Pending</code>,
        /// <code>Stopped</code>, and <code>Stopping</code>. Invalid states are: <code>Shutting-down</code>
        /// and <code>Terminated</code>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.TooManyUpdatesException">
        /// There are concurrent updates for a resource that supports one update at a time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DeleteAssociation">REST API Reference for DeleteAssociation Operation</seealso>
        public virtual DeleteAssociationResponse DeleteAssociation(string instanceId, string name)
        {
            var request = new DeleteAssociationRequest();
            request.InstanceId = instanceId;
            request.Name = name;
            return DeleteAssociation(request);
        }


        /// <summary>
        /// Disassociates the specified Amazon Web Services Systems Manager document (SSM document)
        /// from the specified managed node. If you created the association by using the <code>Targets</code>
        /// parameter, then you must delete the association by using the association ID.
        /// 
        ///  
        /// <para>
        /// When you disassociate a document from a managed node, it doesn't change the configuration
        /// of the node. To change the configuration state of a managed node after you disassociate
        /// a document, you must create a new document with the desired configuration and associate
        /// it with the node.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAssociation service method.</param>
        /// 
        /// <returns>The response from the DeleteAssociation service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.AssociationDoesNotExistException">
        /// The specified association doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidDocumentException">
        /// The specified SSM document doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidInstanceIdException">
        /// The following problems can cause this exception:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You don't have permission to access the managed node.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Amazon Web Services Systems Manager Agent(SSM Agent) isn't running. Verify that SSM
        /// Agent is running.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// SSM Agent isn't registered with the SSM endpoint. Try reinstalling SSM Agent.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The managed node isn't in valid state. Valid states are: <code>Running</code>, <code>Pending</code>,
        /// <code>Stopped</code>, and <code>Stopping</code>. Invalid states are: <code>Shutting-down</code>
        /// and <code>Terminated</code>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.TooManyUpdatesException">
        /// There are concurrent updates for a resource that supports one update at a time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DeleteAssociation">REST API Reference for DeleteAssociation Operation</seealso>
        public virtual DeleteAssociationResponse DeleteAssociation(DeleteAssociationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAssociationResponseUnmarshaller.Instance;

            return Invoke<DeleteAssociationResponse>(request, options);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DeleteAssociation">REST API Reference for DeleteAssociation Operation</seealso>
        public virtual IAsyncResult BeginDeleteAssociation(DeleteAssociationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAssociationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteAssociation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteAssociation.</param>
        /// 
        /// <returns>Returns a  DeleteAssociationResult from SimpleSystemsManagement.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DeleteAssociation">REST API Reference for DeleteAssociation Operation</seealso>
        public virtual DeleteAssociationResponse EndDeleteAssociation(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteAssociationResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteDocument

        /// <summary>
        /// Deletes the Amazon Web Services Systems Manager document (SSM document) and all managed
        /// node associations to the document.
        /// 
        ///  
        /// <para>
        /// Before you delete the document, we recommend that you use <a>DeleteAssociation</a>
        /// to disassociate all managed nodes that are associated with the document.
        /// </para>
        /// </summary>
        /// <param name="name">The name of the document.</param>
        /// 
        /// <returns>The response from the DeleteDocument service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.AssociatedInstancesException">
        /// You must disassociate a document from all managed nodes before you can delete it.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidDocumentException">
        /// The specified SSM document doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidDocumentOperationException">
        /// You attempted to delete a document while it is still shared. You must stop sharing
        /// the document before you can delete it.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DeleteDocument">REST API Reference for DeleteDocument Operation</seealso>
        public virtual DeleteDocumentResponse DeleteDocument(string name)
        {
            var request = new DeleteDocumentRequest();
            request.Name = name;
            return DeleteDocument(request);
        }


        /// <summary>
        /// Deletes the Amazon Web Services Systems Manager document (SSM document) and all managed
        /// node associations to the document.
        /// 
        ///  
        /// <para>
        /// Before you delete the document, we recommend that you use <a>DeleteAssociation</a>
        /// to disassociate all managed nodes that are associated with the document.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDocument service method.</param>
        /// 
        /// <returns>The response from the DeleteDocument service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.AssociatedInstancesException">
        /// You must disassociate a document from all managed nodes before you can delete it.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidDocumentException">
        /// The specified SSM document doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidDocumentOperationException">
        /// You attempted to delete a document while it is still shared. You must stop sharing
        /// the document before you can delete it.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DeleteDocument">REST API Reference for DeleteDocument Operation</seealso>
        public virtual DeleteDocumentResponse DeleteDocument(DeleteDocumentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDocumentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDocumentResponseUnmarshaller.Instance;

            return Invoke<DeleteDocumentResponse>(request, options);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DeleteDocument">REST API Reference for DeleteDocument Operation</seealso>
        public virtual IAsyncResult BeginDeleteDocument(DeleteDocumentRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDocumentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDocumentResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteDocument operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteDocument.</param>
        /// 
        /// <returns>Returns a  DeleteDocumentResult from SimpleSystemsManagement.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DeleteDocument">REST API Reference for DeleteDocument Operation</seealso>
        public virtual DeleteDocumentResponse EndDeleteDocument(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteDocumentResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteInventory

        /// <summary>
        /// Delete a custom inventory type or the data associated with a custom Inventory type.
        /// Deleting a custom inventory type is also referred to as deleting a custom inventory
        /// schema.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteInventory service method.</param>
        /// 
        /// <returns>The response from the DeleteInventory service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidDeleteInventoryParametersException">
        /// One or more of the parameters specified for the delete operation isn't valid. Verify
        /// all parameters and try again.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidInventoryRequestException">
        /// The request isn't valid.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidOptionException">
        /// The delete inventory option specified isn't valid. Verify the option and try again.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidTypeNameException">
        /// The parameter type name isn't valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DeleteInventory">REST API Reference for DeleteInventory Operation</seealso>
        public virtual DeleteInventoryResponse DeleteInventory(DeleteInventoryRequest request)
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
        /// <param name="request">Container for the necessary parameters to execute the DeleteInventory operation on AmazonSimpleSystemsManagementClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteInventory
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DeleteInventory">REST API Reference for DeleteInventory Operation</seealso>
        public virtual IAsyncResult BeginDeleteInventory(DeleteInventoryRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteInventoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteInventoryResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteInventory operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteInventory.</param>
        /// 
        /// <returns>Returns a  DeleteInventoryResult from SimpleSystemsManagement.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DeleteInventory">REST API Reference for DeleteInventory Operation</seealso>
        public virtual DeleteInventoryResponse EndDeleteInventory(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteInventoryResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteMaintenanceWindow

        /// <summary>
        /// Deletes a maintenance window.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteMaintenanceWindow service method.</param>
        /// 
        /// <returns>The response from the DeleteMaintenanceWindow service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DeleteMaintenanceWindow">REST API Reference for DeleteMaintenanceWindow Operation</seealso>
        public virtual DeleteMaintenanceWindowResponse DeleteMaintenanceWindow(DeleteMaintenanceWindowRequest request)
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
        /// <param name="request">Container for the necessary parameters to execute the DeleteMaintenanceWindow operation on AmazonSimpleSystemsManagementClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteMaintenanceWindow
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DeleteMaintenanceWindow">REST API Reference for DeleteMaintenanceWindow Operation</seealso>
        public virtual IAsyncResult BeginDeleteMaintenanceWindow(DeleteMaintenanceWindowRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteMaintenanceWindowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteMaintenanceWindowResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteMaintenanceWindow operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteMaintenanceWindow.</param>
        /// 
        /// <returns>Returns a  DeleteMaintenanceWindowResult from SimpleSystemsManagement.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DeleteMaintenanceWindow">REST API Reference for DeleteMaintenanceWindow Operation</seealso>
        public virtual DeleteMaintenanceWindowResponse EndDeleteMaintenanceWindow(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteMaintenanceWindowResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteOpsMetadata

        /// <summary>
        /// Delete OpsMetadata related to an application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteOpsMetadata service method.</param>
        /// 
        /// <returns>The response from the DeleteOpsMetadata service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.OpsMetadataInvalidArgumentException">
        /// One of the arguments passed is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.OpsMetadataNotFoundException">
        /// The OpsMetadata object doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DeleteOpsMetadata">REST API Reference for DeleteOpsMetadata Operation</seealso>
        public virtual DeleteOpsMetadataResponse DeleteOpsMetadata(DeleteOpsMetadataRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteOpsMetadataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteOpsMetadataResponseUnmarshaller.Instance;

            return Invoke<DeleteOpsMetadataResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteOpsMetadata operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteOpsMetadata operation on AmazonSimpleSystemsManagementClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteOpsMetadata
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DeleteOpsMetadata">REST API Reference for DeleteOpsMetadata Operation</seealso>
        public virtual IAsyncResult BeginDeleteOpsMetadata(DeleteOpsMetadataRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteOpsMetadataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteOpsMetadataResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteOpsMetadata operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteOpsMetadata.</param>
        /// 
        /// <returns>Returns a  DeleteOpsMetadataResult from SimpleSystemsManagement.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DeleteOpsMetadata">REST API Reference for DeleteOpsMetadata Operation</seealso>
        public virtual DeleteOpsMetadataResponse EndDeleteOpsMetadata(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteOpsMetadataResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteParameter

        /// <summary>
        /// Delete a parameter from the system. After deleting a parameter, wait for at least
        /// 30 seconds to create a parameter with the same name.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteParameter service method.</param>
        /// 
        /// <returns>The response from the DeleteParameter service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.ParameterNotFoundException">
        /// The parameter couldn't be found. Verify the name and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DeleteParameter">REST API Reference for DeleteParameter Operation</seealso>
        public virtual DeleteParameterResponse DeleteParameter(DeleteParameterRequest request)
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
        /// <param name="request">Container for the necessary parameters to execute the DeleteParameter operation on AmazonSimpleSystemsManagementClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteParameter
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DeleteParameter">REST API Reference for DeleteParameter Operation</seealso>
        public virtual IAsyncResult BeginDeleteParameter(DeleteParameterRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteParameterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteParameterResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteParameter operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteParameter.</param>
        /// 
        /// <returns>Returns a  DeleteParameterResult from SimpleSystemsManagement.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DeleteParameter">REST API Reference for DeleteParameter Operation</seealso>
        public virtual DeleteParameterResponse EndDeleteParameter(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteParameterResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteParameters

        /// <summary>
        /// Delete a list of parameters. After deleting a parameter, wait for at least 30 seconds
        /// to create a parameter with the same name.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteParameters service method.</param>
        /// 
        /// <returns>The response from the DeleteParameters service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DeleteParameters">REST API Reference for DeleteParameters Operation</seealso>
        public virtual DeleteParametersResponse DeleteParameters(DeleteParametersRequest request)
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
        /// <param name="request">Container for the necessary parameters to execute the DeleteParameters operation on AmazonSimpleSystemsManagementClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteParameters
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DeleteParameters">REST API Reference for DeleteParameters Operation</seealso>
        public virtual IAsyncResult BeginDeleteParameters(DeleteParametersRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteParametersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteParametersResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteParameters operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteParameters.</param>
        /// 
        /// <returns>Returns a  DeleteParametersResult from SimpleSystemsManagement.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DeleteParameters">REST API Reference for DeleteParameters Operation</seealso>
        public virtual DeleteParametersResponse EndDeleteParameters(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteParametersResponse>(asyncResult);
        }

        #endregion
        
        #region  DeletePatchBaseline

        /// <summary>
        /// Deletes a patch baseline.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePatchBaseline service method.</param>
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
        public virtual DeletePatchBaselineResponse DeletePatchBaseline(DeletePatchBaselineRequest request)
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
        /// <param name="request">Container for the necessary parameters to execute the DeletePatchBaseline operation on AmazonSimpleSystemsManagementClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeletePatchBaseline
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DeletePatchBaseline">REST API Reference for DeletePatchBaseline Operation</seealso>
        public virtual IAsyncResult BeginDeletePatchBaseline(DeletePatchBaselineRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeletePatchBaselineRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeletePatchBaselineResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeletePatchBaseline operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeletePatchBaseline.</param>
        /// 
        /// <returns>Returns a  DeletePatchBaselineResult from SimpleSystemsManagement.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DeletePatchBaseline">REST API Reference for DeletePatchBaseline Operation</seealso>
        public virtual DeletePatchBaselineResponse EndDeletePatchBaseline(IAsyncResult asyncResult)
        {
            return EndInvoke<DeletePatchBaselineResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteResourceDataSync

        /// <summary>
        /// Deletes a resource data sync configuration. After the configuration is deleted, changes
        /// to data on managed nodes are no longer synced to or from the target. Deleting a sync
        /// configuration doesn't delete data.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteResourceDataSync service method.</param>
        /// 
        /// <returns>The response from the DeleteResourceDataSync service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.ResourceDataSyncInvalidConfigurationException">
        /// The specified sync configuration is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.ResourceDataSyncNotFoundException">
        /// The specified sync name wasn't found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DeleteResourceDataSync">REST API Reference for DeleteResourceDataSync Operation</seealso>
        public virtual DeleteResourceDataSyncResponse DeleteResourceDataSync(DeleteResourceDataSyncRequest request)
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
        /// <param name="request">Container for the necessary parameters to execute the DeleteResourceDataSync operation on AmazonSimpleSystemsManagementClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteResourceDataSync
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DeleteResourceDataSync">REST API Reference for DeleteResourceDataSync Operation</seealso>
        public virtual IAsyncResult BeginDeleteResourceDataSync(DeleteResourceDataSyncRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteResourceDataSyncRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteResourceDataSyncResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteResourceDataSync operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteResourceDataSync.</param>
        /// 
        /// <returns>Returns a  DeleteResourceDataSyncResult from SimpleSystemsManagement.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DeleteResourceDataSync">REST API Reference for DeleteResourceDataSync Operation</seealso>
        public virtual DeleteResourceDataSyncResponse EndDeleteResourceDataSync(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteResourceDataSyncResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteResourcePolicy

        /// <summary>
        /// Deletes a Systems Manager resource policy. A resource policy helps you to define the
        /// IAM entity (for example, an Amazon Web Services account) that can manage your Systems
        /// Manager resources. Currently, <code>OpsItemGroup</code> is the only resource that
        /// supports Systems Manager resource policies. The resource policy for <code>OpsItemGroup</code>
        /// enables Amazon Web Services accounts to view and interact with OpsCenter operational
        /// work items (OpsItems).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteResourcePolicy service method.</param>
        /// 
        /// <returns>The response from the DeleteResourcePolicy service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.ResourcePolicyConflictException">
        /// The hash provided in the call doesn't match the stored hash. This exception is thrown
        /// when trying to update an obsolete policy version or when multiple requests to update
        /// a policy are sent.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.ResourcePolicyInvalidParameterException">
        /// One or more parameters specified for the call aren't valid. Verify the parameters
        /// and their values and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DeleteResourcePolicy">REST API Reference for DeleteResourcePolicy Operation</seealso>
        public virtual DeleteResourcePolicyResponse DeleteResourcePolicy(DeleteResourcePolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteResourcePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteResourcePolicyResponseUnmarshaller.Instance;

            return Invoke<DeleteResourcePolicyResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteResourcePolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteResourcePolicy operation on AmazonSimpleSystemsManagementClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteResourcePolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DeleteResourcePolicy">REST API Reference for DeleteResourcePolicy Operation</seealso>
        public virtual IAsyncResult BeginDeleteResourcePolicy(DeleteResourcePolicyRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteResourcePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteResourcePolicyResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteResourcePolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteResourcePolicy.</param>
        /// 
        /// <returns>Returns a  DeleteResourcePolicyResult from SimpleSystemsManagement.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DeleteResourcePolicy">REST API Reference for DeleteResourcePolicy Operation</seealso>
        public virtual DeleteResourcePolicyResponse EndDeleteResourcePolicy(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteResourcePolicyResponse>(asyncResult);
        }

        #endregion
        
        #region  DeregisterManagedInstance

        /// <summary>
        /// Removes the server or virtual machine from the list of registered servers. You can
        /// reregister the node again at any time. If you don't plan to use Run Command on the
        /// server, we suggest uninstalling SSM Agent first.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeregisterManagedInstance service method.</param>
        /// 
        /// <returns>The response from the DeregisterManagedInstance service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidInstanceIdException">
        /// The following problems can cause this exception:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You don't have permission to access the managed node.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Amazon Web Services Systems Manager Agent(SSM Agent) isn't running. Verify that SSM
        /// Agent is running.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// SSM Agent isn't registered with the SSM endpoint. Try reinstalling SSM Agent.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The managed node isn't in valid state. Valid states are: <code>Running</code>, <code>Pending</code>,
        /// <code>Stopped</code>, and <code>Stopping</code>. Invalid states are: <code>Shutting-down</code>
        /// and <code>Terminated</code>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DeregisterManagedInstance">REST API Reference for DeregisterManagedInstance Operation</seealso>
        public virtual DeregisterManagedInstanceResponse DeregisterManagedInstance(DeregisterManagedInstanceRequest request)
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
        /// <param name="request">Container for the necessary parameters to execute the DeregisterManagedInstance operation on AmazonSimpleSystemsManagementClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeregisterManagedInstance
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DeregisterManagedInstance">REST API Reference for DeregisterManagedInstance Operation</seealso>
        public virtual IAsyncResult BeginDeregisterManagedInstance(DeregisterManagedInstanceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeregisterManagedInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeregisterManagedInstanceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeregisterManagedInstance operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeregisterManagedInstance.</param>
        /// 
        /// <returns>Returns a  DeregisterManagedInstanceResult from SimpleSystemsManagement.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DeregisterManagedInstance">REST API Reference for DeregisterManagedInstance Operation</seealso>
        public virtual DeregisterManagedInstanceResponse EndDeregisterManagedInstance(IAsyncResult asyncResult)
        {
            return EndInvoke<DeregisterManagedInstanceResponse>(asyncResult);
        }

        #endregion
        
        #region  DeregisterPatchBaselineForPatchGroup

        /// <summary>
        /// Removes a patch group from a patch baseline.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeregisterPatchBaselineForPatchGroup service method.</param>
        /// 
        /// <returns>The response from the DeregisterPatchBaselineForPatchGroup service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidResourceIdException">
        /// The resource ID isn't valid. Verify that you entered the correct ID and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DeregisterPatchBaselineForPatchGroup">REST API Reference for DeregisterPatchBaselineForPatchGroup Operation</seealso>
        public virtual DeregisterPatchBaselineForPatchGroupResponse DeregisterPatchBaselineForPatchGroup(DeregisterPatchBaselineForPatchGroupRequest request)
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
        /// <param name="request">Container for the necessary parameters to execute the DeregisterPatchBaselineForPatchGroup operation on AmazonSimpleSystemsManagementClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeregisterPatchBaselineForPatchGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DeregisterPatchBaselineForPatchGroup">REST API Reference for DeregisterPatchBaselineForPatchGroup Operation</seealso>
        public virtual IAsyncResult BeginDeregisterPatchBaselineForPatchGroup(DeregisterPatchBaselineForPatchGroupRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeregisterPatchBaselineForPatchGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeregisterPatchBaselineForPatchGroupResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeregisterPatchBaselineForPatchGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeregisterPatchBaselineForPatchGroup.</param>
        /// 
        /// <returns>Returns a  DeregisterPatchBaselineForPatchGroupResult from SimpleSystemsManagement.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DeregisterPatchBaselineForPatchGroup">REST API Reference for DeregisterPatchBaselineForPatchGroup Operation</seealso>
        public virtual DeregisterPatchBaselineForPatchGroupResponse EndDeregisterPatchBaselineForPatchGroup(IAsyncResult asyncResult)
        {
            return EndInvoke<DeregisterPatchBaselineForPatchGroupResponse>(asyncResult);
        }

        #endregion
        
        #region  DeregisterTargetFromMaintenanceWindow

        /// <summary>
        /// Removes a target from a maintenance window.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeregisterTargetFromMaintenanceWindow service method.</param>
        /// 
        /// <returns>The response from the DeregisterTargetFromMaintenanceWindow service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.DoesNotExistException">
        /// Error returned when the ID specified for a resource, such as a maintenance window
        /// or patch baseline, doesn't exist.
        /// 
        ///  
        /// <para>
        /// For information about resource quotas in Amazon Web Services Systems Manager, see
        /// <a href="https://docs.aws.amazon.com/general/latest/gr/ssm.html#limits_ssm">Systems
        /// Manager service quotas</a> in the <i>Amazon Web Services General Reference</i>.
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
        public virtual DeregisterTargetFromMaintenanceWindowResponse DeregisterTargetFromMaintenanceWindow(DeregisterTargetFromMaintenanceWindowRequest request)
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
        /// <param name="request">Container for the necessary parameters to execute the DeregisterTargetFromMaintenanceWindow operation on AmazonSimpleSystemsManagementClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeregisterTargetFromMaintenanceWindow
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DeregisterTargetFromMaintenanceWindow">REST API Reference for DeregisterTargetFromMaintenanceWindow Operation</seealso>
        public virtual IAsyncResult BeginDeregisterTargetFromMaintenanceWindow(DeregisterTargetFromMaintenanceWindowRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeregisterTargetFromMaintenanceWindowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeregisterTargetFromMaintenanceWindowResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeregisterTargetFromMaintenanceWindow operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeregisterTargetFromMaintenanceWindow.</param>
        /// 
        /// <returns>Returns a  DeregisterTargetFromMaintenanceWindowResult from SimpleSystemsManagement.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DeregisterTargetFromMaintenanceWindow">REST API Reference for DeregisterTargetFromMaintenanceWindow Operation</seealso>
        public virtual DeregisterTargetFromMaintenanceWindowResponse EndDeregisterTargetFromMaintenanceWindow(IAsyncResult asyncResult)
        {
            return EndInvoke<DeregisterTargetFromMaintenanceWindowResponse>(asyncResult);
        }

        #endregion
        
        #region  DeregisterTaskFromMaintenanceWindow

        /// <summary>
        /// Removes a task from a maintenance window.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeregisterTaskFromMaintenanceWindow service method.</param>
        /// 
        /// <returns>The response from the DeregisterTaskFromMaintenanceWindow service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.DoesNotExistException">
        /// Error returned when the ID specified for a resource, such as a maintenance window
        /// or patch baseline, doesn't exist.
        /// 
        ///  
        /// <para>
        /// For information about resource quotas in Amazon Web Services Systems Manager, see
        /// <a href="https://docs.aws.amazon.com/general/latest/gr/ssm.html#limits_ssm">Systems
        /// Manager service quotas</a> in the <i>Amazon Web Services General Reference</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DeregisterTaskFromMaintenanceWindow">REST API Reference for DeregisterTaskFromMaintenanceWindow Operation</seealso>
        public virtual DeregisterTaskFromMaintenanceWindowResponse DeregisterTaskFromMaintenanceWindow(DeregisterTaskFromMaintenanceWindowRequest request)
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
        /// <param name="request">Container for the necessary parameters to execute the DeregisterTaskFromMaintenanceWindow operation on AmazonSimpleSystemsManagementClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeregisterTaskFromMaintenanceWindow
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DeregisterTaskFromMaintenanceWindow">REST API Reference for DeregisterTaskFromMaintenanceWindow Operation</seealso>
        public virtual IAsyncResult BeginDeregisterTaskFromMaintenanceWindow(DeregisterTaskFromMaintenanceWindowRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeregisterTaskFromMaintenanceWindowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeregisterTaskFromMaintenanceWindowResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeregisterTaskFromMaintenanceWindow operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeregisterTaskFromMaintenanceWindow.</param>
        /// 
        /// <returns>Returns a  DeregisterTaskFromMaintenanceWindowResult from SimpleSystemsManagement.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DeregisterTaskFromMaintenanceWindow">REST API Reference for DeregisterTaskFromMaintenanceWindow Operation</seealso>
        public virtual DeregisterTaskFromMaintenanceWindowResponse EndDeregisterTaskFromMaintenanceWindow(IAsyncResult asyncResult)
        {
            return EndInvoke<DeregisterTaskFromMaintenanceWindowResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeActivations

        /// <summary>
        /// Describes details about the activation, such as the date and time the activation was
        /// created, its expiration date, the Identity and Access Management (IAM) role assigned
        /// to the managed nodes in the activation, and the number of nodes registered by using
        /// this activation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeActivations service method.</param>
        /// 
        /// <returns>The response from the DescribeActivations service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidFilterException">
        /// The filter name isn't valid. Verify the you entered the correct name and try again.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidNextTokenException">
        /// The specified token isn't valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribeActivations">REST API Reference for DescribeActivations Operation</seealso>
        public virtual DescribeActivationsResponse DescribeActivations(DescribeActivationsRequest request)
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
        /// <param name="request">Container for the necessary parameters to execute the DescribeActivations operation on AmazonSimpleSystemsManagementClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeActivations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribeActivations">REST API Reference for DescribeActivations Operation</seealso>
        public virtual IAsyncResult BeginDescribeActivations(DescribeActivationsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeActivationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeActivationsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeActivations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeActivations.</param>
        /// 
        /// <returns>Returns a  DescribeActivationsResult from SimpleSystemsManagement.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribeActivations">REST API Reference for DescribeActivations Operation</seealso>
        public virtual DescribeActivationsResponse EndDescribeActivations(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeActivationsResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeAssociation

        /// <summary>
        /// Describes the association for the specified target or managed node. If you created
        /// the association by using the <code>Targets</code> parameter, then you must retrieve
        /// the association by using the association ID.
        /// </summary>
        /// <param name="instanceId">The managed node ID.</param>
        /// <param name="name">The name of the SSM document.</param>
        /// 
        /// <returns>The response from the DescribeAssociation service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.AssociationDoesNotExistException">
        /// The specified association doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidAssociationVersionException">
        /// The version you specified isn't valid. Use ListAssociationVersions to view all versions
        /// of an association according to the association ID. Or, use the <code>$LATEST</code>
        /// parameter to view the latest version of the association.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidDocumentException">
        /// The specified SSM document doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidInstanceIdException">
        /// The following problems can cause this exception:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You don't have permission to access the managed node.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Amazon Web Services Systems Manager Agent(SSM Agent) isn't running. Verify that SSM
        /// Agent is running.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// SSM Agent isn't registered with the SSM endpoint. Try reinstalling SSM Agent.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The managed node isn't in valid state. Valid states are: <code>Running</code>, <code>Pending</code>,
        /// <code>Stopped</code>, and <code>Stopping</code>. Invalid states are: <code>Shutting-down</code>
        /// and <code>Terminated</code>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribeAssociation">REST API Reference for DescribeAssociation Operation</seealso>
        public virtual DescribeAssociationResponse DescribeAssociation(string instanceId, string name)
        {
            var request = new DescribeAssociationRequest();
            request.InstanceId = instanceId;
            request.Name = name;
            return DescribeAssociation(request);
        }


        /// <summary>
        /// Describes the association for the specified target or managed node. If you created
        /// the association by using the <code>Targets</code> parameter, then you must retrieve
        /// the association by using the association ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAssociation service method.</param>
        /// 
        /// <returns>The response from the DescribeAssociation service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.AssociationDoesNotExistException">
        /// The specified association doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidAssociationVersionException">
        /// The version you specified isn't valid. Use ListAssociationVersions to view all versions
        /// of an association according to the association ID. Or, use the <code>$LATEST</code>
        /// parameter to view the latest version of the association.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidDocumentException">
        /// The specified SSM document doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidInstanceIdException">
        /// The following problems can cause this exception:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You don't have permission to access the managed node.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Amazon Web Services Systems Manager Agent(SSM Agent) isn't running. Verify that SSM
        /// Agent is running.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// SSM Agent isn't registered with the SSM endpoint. Try reinstalling SSM Agent.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The managed node isn't in valid state. Valid states are: <code>Running</code>, <code>Pending</code>,
        /// <code>Stopped</code>, and <code>Stopping</code>. Invalid states are: <code>Shutting-down</code>
        /// and <code>Terminated</code>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribeAssociation">REST API Reference for DescribeAssociation Operation</seealso>
        public virtual DescribeAssociationResponse DescribeAssociation(DescribeAssociationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAssociationResponseUnmarshaller.Instance;

            return Invoke<DescribeAssociationResponse>(request, options);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribeAssociation">REST API Reference for DescribeAssociation Operation</seealso>
        public virtual IAsyncResult BeginDescribeAssociation(DescribeAssociationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAssociationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeAssociation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeAssociation.</param>
        /// 
        /// <returns>Returns a  DescribeAssociationResult from SimpleSystemsManagement.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribeAssociation">REST API Reference for DescribeAssociation Operation</seealso>
        public virtual DescribeAssociationResponse EndDescribeAssociation(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeAssociationResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeAssociationExecutions

        /// <summary>
        /// Views all executions for a specific association ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAssociationExecutions service method.</param>
        /// 
        /// <returns>The response from the DescribeAssociationExecutions service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.AssociationDoesNotExistException">
        /// The specified association doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidNextTokenException">
        /// The specified token isn't valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribeAssociationExecutions">REST API Reference for DescribeAssociationExecutions Operation</seealso>
        public virtual DescribeAssociationExecutionsResponse DescribeAssociationExecutions(DescribeAssociationExecutionsRequest request)
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
        /// <param name="request">Container for the necessary parameters to execute the DescribeAssociationExecutions operation on AmazonSimpleSystemsManagementClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeAssociationExecutions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribeAssociationExecutions">REST API Reference for DescribeAssociationExecutions Operation</seealso>
        public virtual IAsyncResult BeginDescribeAssociationExecutions(DescribeAssociationExecutionsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAssociationExecutionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAssociationExecutionsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeAssociationExecutions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeAssociationExecutions.</param>
        /// 
        /// <returns>Returns a  DescribeAssociationExecutionsResult from SimpleSystemsManagement.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribeAssociationExecutions">REST API Reference for DescribeAssociationExecutions Operation</seealso>
        public virtual DescribeAssociationExecutionsResponse EndDescribeAssociationExecutions(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeAssociationExecutionsResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeAssociationExecutionTargets

        /// <summary>
        /// Views information about a specific execution of a specific association.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAssociationExecutionTargets service method.</param>
        /// 
        /// <returns>The response from the DescribeAssociationExecutionTargets service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.AssociationDoesNotExistException">
        /// The specified association doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.AssociationExecutionDoesNotExistException">
        /// The specified execution ID doesn't exist. Verify the ID number and try again.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidNextTokenException">
        /// The specified token isn't valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribeAssociationExecutionTargets">REST API Reference for DescribeAssociationExecutionTargets Operation</seealso>
        public virtual DescribeAssociationExecutionTargetsResponse DescribeAssociationExecutionTargets(DescribeAssociationExecutionTargetsRequest request)
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
        /// <param name="request">Container for the necessary parameters to execute the DescribeAssociationExecutionTargets operation on AmazonSimpleSystemsManagementClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeAssociationExecutionTargets
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribeAssociationExecutionTargets">REST API Reference for DescribeAssociationExecutionTargets Operation</seealso>
        public virtual IAsyncResult BeginDescribeAssociationExecutionTargets(DescribeAssociationExecutionTargetsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAssociationExecutionTargetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAssociationExecutionTargetsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeAssociationExecutionTargets operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeAssociationExecutionTargets.</param>
        /// 
        /// <returns>Returns a  DescribeAssociationExecutionTargetsResult from SimpleSystemsManagement.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribeAssociationExecutionTargets">REST API Reference for DescribeAssociationExecutionTargets Operation</seealso>
        public virtual DescribeAssociationExecutionTargetsResponse EndDescribeAssociationExecutionTargets(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeAssociationExecutionTargetsResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeAutomationExecutions

        /// <summary>
        /// Provides details about all active and terminated Automation executions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAutomationExecutions service method.</param>
        /// 
        /// <returns>The response from the DescribeAutomationExecutions service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidFilterKeyException">
        /// The specified key isn't valid.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidFilterValueException">
        /// The filter value isn't valid. Verify the value and try again.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidNextTokenException">
        /// The specified token isn't valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribeAutomationExecutions">REST API Reference for DescribeAutomationExecutions Operation</seealso>
        public virtual DescribeAutomationExecutionsResponse DescribeAutomationExecutions(DescribeAutomationExecutionsRequest request)
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
        /// <param name="request">Container for the necessary parameters to execute the DescribeAutomationExecutions operation on AmazonSimpleSystemsManagementClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeAutomationExecutions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribeAutomationExecutions">REST API Reference for DescribeAutomationExecutions Operation</seealso>
        public virtual IAsyncResult BeginDescribeAutomationExecutions(DescribeAutomationExecutionsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAutomationExecutionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAutomationExecutionsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeAutomationExecutions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeAutomationExecutions.</param>
        /// 
        /// <returns>Returns a  DescribeAutomationExecutionsResult from SimpleSystemsManagement.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribeAutomationExecutions">REST API Reference for DescribeAutomationExecutions Operation</seealso>
        public virtual DescribeAutomationExecutionsResponse EndDescribeAutomationExecutions(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeAutomationExecutionsResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeAutomationStepExecutions

        /// <summary>
        /// Information about all active and terminated step executions in an Automation workflow.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAutomationStepExecutions service method.</param>
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
        /// The specified key isn't valid.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidFilterValueException">
        /// The filter value isn't valid. Verify the value and try again.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidNextTokenException">
        /// The specified token isn't valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribeAutomationStepExecutions">REST API Reference for DescribeAutomationStepExecutions Operation</seealso>
        public virtual DescribeAutomationStepExecutionsResponse DescribeAutomationStepExecutions(DescribeAutomationStepExecutionsRequest request)
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
        /// <param name="request">Container for the necessary parameters to execute the DescribeAutomationStepExecutions operation on AmazonSimpleSystemsManagementClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeAutomationStepExecutions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribeAutomationStepExecutions">REST API Reference for DescribeAutomationStepExecutions Operation</seealso>
        public virtual IAsyncResult BeginDescribeAutomationStepExecutions(DescribeAutomationStepExecutionsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAutomationStepExecutionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAutomationStepExecutionsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeAutomationStepExecutions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeAutomationStepExecutions.</param>
        /// 
        /// <returns>Returns a  DescribeAutomationStepExecutionsResult from SimpleSystemsManagement.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribeAutomationStepExecutions">REST API Reference for DescribeAutomationStepExecutions Operation</seealso>
        public virtual DescribeAutomationStepExecutionsResponse EndDescribeAutomationStepExecutions(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeAutomationStepExecutionsResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeAvailablePatches

        /// <summary>
        /// Lists all patches eligible to be included in a patch baseline.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAvailablePatches service method.</param>
        /// 
        /// <returns>The response from the DescribeAvailablePatches service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribeAvailablePatches">REST API Reference for DescribeAvailablePatches Operation</seealso>
        public virtual DescribeAvailablePatchesResponse DescribeAvailablePatches(DescribeAvailablePatchesRequest request)
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
        /// <param name="request">Container for the necessary parameters to execute the DescribeAvailablePatches operation on AmazonSimpleSystemsManagementClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeAvailablePatches
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribeAvailablePatches">REST API Reference for DescribeAvailablePatches Operation</seealso>
        public virtual IAsyncResult BeginDescribeAvailablePatches(DescribeAvailablePatchesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAvailablePatchesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAvailablePatchesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeAvailablePatches operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeAvailablePatches.</param>
        /// 
        /// <returns>Returns a  DescribeAvailablePatchesResult from SimpleSystemsManagement.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribeAvailablePatches">REST API Reference for DescribeAvailablePatches Operation</seealso>
        public virtual DescribeAvailablePatchesResponse EndDescribeAvailablePatches(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeAvailablePatchesResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeDocument

        /// <summary>
        /// Describes the specified Amazon Web Services Systems Manager document (SSM document).
        /// </summary>
        /// <param name="name">The name of the SSM document.</param>
        /// 
        /// <returns>The response from the DescribeDocument service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidDocumentException">
        /// The specified SSM document doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidDocumentVersionException">
        /// The document version isn't valid or doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribeDocument">REST API Reference for DescribeDocument Operation</seealso>
        public virtual DescribeDocumentResponse DescribeDocument(string name)
        {
            var request = new DescribeDocumentRequest();
            request.Name = name;
            return DescribeDocument(request);
        }


        /// <summary>
        /// Describes the specified Amazon Web Services Systems Manager document (SSM document).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDocument service method.</param>
        /// 
        /// <returns>The response from the DescribeDocument service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidDocumentException">
        /// The specified SSM document doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidDocumentVersionException">
        /// The document version isn't valid or doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribeDocument">REST API Reference for DescribeDocument Operation</seealso>
        public virtual DescribeDocumentResponse DescribeDocument(DescribeDocumentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDocumentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDocumentResponseUnmarshaller.Instance;

            return Invoke<DescribeDocumentResponse>(request, options);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribeDocument">REST API Reference for DescribeDocument Operation</seealso>
        public virtual IAsyncResult BeginDescribeDocument(DescribeDocumentRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDocumentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDocumentResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeDocument operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeDocument.</param>
        /// 
        /// <returns>Returns a  DescribeDocumentResult from SimpleSystemsManagement.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribeDocument">REST API Reference for DescribeDocument Operation</seealso>
        public virtual DescribeDocumentResponse EndDescribeDocument(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeDocumentResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeDocumentPermission

        /// <summary>
        /// Describes the permissions for a Amazon Web Services Systems Manager document (SSM
        /// document). If you created the document, you are the owner. If a document is shared,
        /// it can either be shared privately (by specifying a user's Amazon Web Services account
        /// ID) or publicly (<i>All</i>).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDocumentPermission service method.</param>
        /// 
        /// <returns>The response from the DescribeDocumentPermission service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidDocumentException">
        /// The specified SSM document doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidDocumentOperationException">
        /// You attempted to delete a document while it is still shared. You must stop sharing
        /// the document before you can delete it.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidNextTokenException">
        /// The specified token isn't valid.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidPermissionTypeException">
        /// The permission type isn't supported. <i>Share</i> is the only supported permission
        /// type.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribeDocumentPermission">REST API Reference for DescribeDocumentPermission Operation</seealso>
        public virtual DescribeDocumentPermissionResponse DescribeDocumentPermission(DescribeDocumentPermissionRequest request)
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
        /// <param name="request">Container for the necessary parameters to execute the DescribeDocumentPermission operation on AmazonSimpleSystemsManagementClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeDocumentPermission
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribeDocumentPermission">REST API Reference for DescribeDocumentPermission Operation</seealso>
        public virtual IAsyncResult BeginDescribeDocumentPermission(DescribeDocumentPermissionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDocumentPermissionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDocumentPermissionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeDocumentPermission operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeDocumentPermission.</param>
        /// 
        /// <returns>Returns a  DescribeDocumentPermissionResult from SimpleSystemsManagement.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribeDocumentPermission">REST API Reference for DescribeDocumentPermission Operation</seealso>
        public virtual DescribeDocumentPermissionResponse EndDescribeDocumentPermission(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeDocumentPermissionResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeEffectiveInstanceAssociations

        /// <summary>
        /// All associations for the managed node(s).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEffectiveInstanceAssociations service method.</param>
        /// 
        /// <returns>The response from the DescribeEffectiveInstanceAssociations service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidInstanceIdException">
        /// The following problems can cause this exception:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You don't have permission to access the managed node.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Amazon Web Services Systems Manager Agent(SSM Agent) isn't running. Verify that SSM
        /// Agent is running.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// SSM Agent isn't registered with the SSM endpoint. Try reinstalling SSM Agent.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The managed node isn't in valid state. Valid states are: <code>Running</code>, <code>Pending</code>,
        /// <code>Stopped</code>, and <code>Stopping</code>. Invalid states are: <code>Shutting-down</code>
        /// and <code>Terminated</code>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidNextTokenException">
        /// The specified token isn't valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribeEffectiveInstanceAssociations">REST API Reference for DescribeEffectiveInstanceAssociations Operation</seealso>
        public virtual DescribeEffectiveInstanceAssociationsResponse DescribeEffectiveInstanceAssociations(DescribeEffectiveInstanceAssociationsRequest request)
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
        /// <param name="request">Container for the necessary parameters to execute the DescribeEffectiveInstanceAssociations operation on AmazonSimpleSystemsManagementClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeEffectiveInstanceAssociations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribeEffectiveInstanceAssociations">REST API Reference for DescribeEffectiveInstanceAssociations Operation</seealso>
        public virtual IAsyncResult BeginDescribeEffectiveInstanceAssociations(DescribeEffectiveInstanceAssociationsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeEffectiveInstanceAssociationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEffectiveInstanceAssociationsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeEffectiveInstanceAssociations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeEffectiveInstanceAssociations.</param>
        /// 
        /// <returns>Returns a  DescribeEffectiveInstanceAssociationsResult from SimpleSystemsManagement.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribeEffectiveInstanceAssociations">REST API Reference for DescribeEffectiveInstanceAssociations Operation</seealso>
        public virtual DescribeEffectiveInstanceAssociationsResponse EndDescribeEffectiveInstanceAssociations(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeEffectiveInstanceAssociationsResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeEffectivePatchesForPatchBaseline

        /// <summary>
        /// Retrieves the current effective patches (the patch and the approval state) for the
        /// specified patch baseline. Applies to patch baselines for Windows only.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEffectivePatchesForPatchBaseline service method.</param>
        /// 
        /// <returns>The response from the DescribeEffectivePatchesForPatchBaseline service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.DoesNotExistException">
        /// Error returned when the ID specified for a resource, such as a maintenance window
        /// or patch baseline, doesn't exist.
        /// 
        ///  
        /// <para>
        /// For information about resource quotas in Amazon Web Services Systems Manager, see
        /// <a href="https://docs.aws.amazon.com/general/latest/gr/ssm.html#limits_ssm">Systems
        /// Manager service quotas</a> in the <i>Amazon Web Services General Reference</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidResourceIdException">
        /// The resource ID isn't valid. Verify that you entered the correct ID and try again.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.UnsupportedOperatingSystemException">
        /// The operating systems you specified isn't supported, or the operation isn't supported
        /// for the operating system.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribeEffectivePatchesForPatchBaseline">REST API Reference for DescribeEffectivePatchesForPatchBaseline Operation</seealso>
        public virtual DescribeEffectivePatchesForPatchBaselineResponse DescribeEffectivePatchesForPatchBaseline(DescribeEffectivePatchesForPatchBaselineRequest request)
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
        /// <param name="request">Container for the necessary parameters to execute the DescribeEffectivePatchesForPatchBaseline operation on AmazonSimpleSystemsManagementClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeEffectivePatchesForPatchBaseline
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribeEffectivePatchesForPatchBaseline">REST API Reference for DescribeEffectivePatchesForPatchBaseline Operation</seealso>
        public virtual IAsyncResult BeginDescribeEffectivePatchesForPatchBaseline(DescribeEffectivePatchesForPatchBaselineRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeEffectivePatchesForPatchBaselineRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEffectivePatchesForPatchBaselineResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeEffectivePatchesForPatchBaseline operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeEffectivePatchesForPatchBaseline.</param>
        /// 
        /// <returns>Returns a  DescribeEffectivePatchesForPatchBaselineResult from SimpleSystemsManagement.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribeEffectivePatchesForPatchBaseline">REST API Reference for DescribeEffectivePatchesForPatchBaseline Operation</seealso>
        public virtual DescribeEffectivePatchesForPatchBaselineResponse EndDescribeEffectivePatchesForPatchBaseline(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeEffectivePatchesForPatchBaselineResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeInstanceAssociationsStatus

        /// <summary>
        /// The status of the associations for the managed node(s).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeInstanceAssociationsStatus service method.</param>
        /// 
        /// <returns>The response from the DescribeInstanceAssociationsStatus service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidInstanceIdException">
        /// The following problems can cause this exception:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You don't have permission to access the managed node.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Amazon Web Services Systems Manager Agent(SSM Agent) isn't running. Verify that SSM
        /// Agent is running.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// SSM Agent isn't registered with the SSM endpoint. Try reinstalling SSM Agent.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The managed node isn't in valid state. Valid states are: <code>Running</code>, <code>Pending</code>,
        /// <code>Stopped</code>, and <code>Stopping</code>. Invalid states are: <code>Shutting-down</code>
        /// and <code>Terminated</code>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidNextTokenException">
        /// The specified token isn't valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribeInstanceAssociationsStatus">REST API Reference for DescribeInstanceAssociationsStatus Operation</seealso>
        public virtual DescribeInstanceAssociationsStatusResponse DescribeInstanceAssociationsStatus(DescribeInstanceAssociationsStatusRequest request)
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
        /// <param name="request">Container for the necessary parameters to execute the DescribeInstanceAssociationsStatus operation on AmazonSimpleSystemsManagementClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeInstanceAssociationsStatus
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribeInstanceAssociationsStatus">REST API Reference for DescribeInstanceAssociationsStatus Operation</seealso>
        public virtual IAsyncResult BeginDescribeInstanceAssociationsStatus(DescribeInstanceAssociationsStatusRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeInstanceAssociationsStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeInstanceAssociationsStatusResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeInstanceAssociationsStatus operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeInstanceAssociationsStatus.</param>
        /// 
        /// <returns>Returns a  DescribeInstanceAssociationsStatusResult from SimpleSystemsManagement.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribeInstanceAssociationsStatus">REST API Reference for DescribeInstanceAssociationsStatus Operation</seealso>
        public virtual DescribeInstanceAssociationsStatusResponse EndDescribeInstanceAssociationsStatus(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeInstanceAssociationsStatusResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeInstanceInformation

        /// <summary>
        /// Describes one or more of your managed nodes, including information about the operating
        /// system platform, the version of SSM Agent installed on the managed node, node status,
        /// and so on.
        /// 
        ///  
        /// <para>
        /// If you specify one or more managed node IDs, it returns information for those managed
        /// nodes. If you don't specify node IDs, it returns information for all your managed
        /// nodes. If you specify a node ID that isn't valid or a node that you don't own, you
        /// receive an error.
        /// </para>
        ///  <note> 
        /// <para>
        /// The <code>IamRole</code> field for this API operation is the Identity and Access Management
        /// (IAM) role assigned to on-premises managed nodes. This call doesn't return the IAM
        /// role for EC2 instances.
        /// </para>
        ///  </note>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeInstanceInformation service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidFilterKeyException">
        /// The specified key isn't valid.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidInstanceIdException">
        /// The following problems can cause this exception:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You don't have permission to access the managed node.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Amazon Web Services Systems Manager Agent(SSM Agent) isn't running. Verify that SSM
        /// Agent is running.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// SSM Agent isn't registered with the SSM endpoint. Try reinstalling SSM Agent.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The managed node isn't in valid state. Valid states are: <code>Running</code>, <code>Pending</code>,
        /// <code>Stopped</code>, and <code>Stopping</code>. Invalid states are: <code>Shutting-down</code>
        /// and <code>Terminated</code>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidInstanceInformationFilterValueException">
        /// The specified filter value isn't valid.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidNextTokenException">
        /// The specified token isn't valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribeInstanceInformation">REST API Reference for DescribeInstanceInformation Operation</seealso>
        public virtual DescribeInstanceInformationResponse DescribeInstanceInformation()
        {
            return DescribeInstanceInformation(new DescribeInstanceInformationRequest());
        }

        /// <summary>
        /// Describes one or more of your managed nodes, including information about the operating
        /// system platform, the version of SSM Agent installed on the managed node, node status,
        /// and so on.
        /// 
        ///  
        /// <para>
        /// If you specify one or more managed node IDs, it returns information for those managed
        /// nodes. If you don't specify node IDs, it returns information for all your managed
        /// nodes. If you specify a node ID that isn't valid or a node that you don't own, you
        /// receive an error.
        /// </para>
        ///  <note> 
        /// <para>
        /// The <code>IamRole</code> field for this API operation is the Identity and Access Management
        /// (IAM) role assigned to on-premises managed nodes. This call doesn't return the IAM
        /// role for EC2 instances.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeInstanceInformation service method.</param>
        /// 
        /// <returns>The response from the DescribeInstanceInformation service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidFilterKeyException">
        /// The specified key isn't valid.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidInstanceIdException">
        /// The following problems can cause this exception:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You don't have permission to access the managed node.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Amazon Web Services Systems Manager Agent(SSM Agent) isn't running. Verify that SSM
        /// Agent is running.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// SSM Agent isn't registered with the SSM endpoint. Try reinstalling SSM Agent.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The managed node isn't in valid state. Valid states are: <code>Running</code>, <code>Pending</code>,
        /// <code>Stopped</code>, and <code>Stopping</code>. Invalid states are: <code>Shutting-down</code>
        /// and <code>Terminated</code>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidInstanceInformationFilterValueException">
        /// The specified filter value isn't valid.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidNextTokenException">
        /// The specified token isn't valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribeInstanceInformation">REST API Reference for DescribeInstanceInformation Operation</seealso>
        public virtual DescribeInstanceInformationResponse DescribeInstanceInformation(DescribeInstanceInformationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeInstanceInformationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeInstanceInformationResponseUnmarshaller.Instance;

            return Invoke<DescribeInstanceInformationResponse>(request, options);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribeInstanceInformation">REST API Reference for DescribeInstanceInformation Operation</seealso>
        public virtual IAsyncResult BeginDescribeInstanceInformation(DescribeInstanceInformationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeInstanceInformationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeInstanceInformationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeInstanceInformation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeInstanceInformation.</param>
        /// 
        /// <returns>Returns a  DescribeInstanceInformationResult from SimpleSystemsManagement.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribeInstanceInformation">REST API Reference for DescribeInstanceInformation Operation</seealso>
        public virtual DescribeInstanceInformationResponse EndDescribeInstanceInformation(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeInstanceInformationResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeInstancePatches

        /// <summary>
        /// Retrieves information about the patches on the specified managed node and their state
        /// relative to the patch baseline being used for the node.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeInstancePatches service method.</param>
        /// 
        /// <returns>The response from the DescribeInstancePatches service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidFilterException">
        /// The filter name isn't valid. Verify the you entered the correct name and try again.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidInstanceIdException">
        /// The following problems can cause this exception:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You don't have permission to access the managed node.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Amazon Web Services Systems Manager Agent(SSM Agent) isn't running. Verify that SSM
        /// Agent is running.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// SSM Agent isn't registered with the SSM endpoint. Try reinstalling SSM Agent.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The managed node isn't in valid state. Valid states are: <code>Running</code>, <code>Pending</code>,
        /// <code>Stopped</code>, and <code>Stopping</code>. Invalid states are: <code>Shutting-down</code>
        /// and <code>Terminated</code>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidNextTokenException">
        /// The specified token isn't valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribeInstancePatches">REST API Reference for DescribeInstancePatches Operation</seealso>
        public virtual DescribeInstancePatchesResponse DescribeInstancePatches(DescribeInstancePatchesRequest request)
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
        /// <param name="request">Container for the necessary parameters to execute the DescribeInstancePatches operation on AmazonSimpleSystemsManagementClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeInstancePatches
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribeInstancePatches">REST API Reference for DescribeInstancePatches Operation</seealso>
        public virtual IAsyncResult BeginDescribeInstancePatches(DescribeInstancePatchesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeInstancePatchesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeInstancePatchesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeInstancePatches operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeInstancePatches.</param>
        /// 
        /// <returns>Returns a  DescribeInstancePatchesResult from SimpleSystemsManagement.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribeInstancePatches">REST API Reference for DescribeInstancePatches Operation</seealso>
        public virtual DescribeInstancePatchesResponse EndDescribeInstancePatches(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeInstancePatchesResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeInstancePatchStates

        /// <summary>
        /// Retrieves the high-level patch state of one or more managed nodes.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeInstancePatchStates service method.</param>
        /// 
        /// <returns>The response from the DescribeInstancePatchStates service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidNextTokenException">
        /// The specified token isn't valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribeInstancePatchStates">REST API Reference for DescribeInstancePatchStates Operation</seealso>
        public virtual DescribeInstancePatchStatesResponse DescribeInstancePatchStates(DescribeInstancePatchStatesRequest request)
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
        /// <param name="request">Container for the necessary parameters to execute the DescribeInstancePatchStates operation on AmazonSimpleSystemsManagementClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeInstancePatchStates
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribeInstancePatchStates">REST API Reference for DescribeInstancePatchStates Operation</seealso>
        public virtual IAsyncResult BeginDescribeInstancePatchStates(DescribeInstancePatchStatesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeInstancePatchStatesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeInstancePatchStatesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeInstancePatchStates operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeInstancePatchStates.</param>
        /// 
        /// <returns>Returns a  DescribeInstancePatchStatesResult from SimpleSystemsManagement.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribeInstancePatchStates">REST API Reference for DescribeInstancePatchStates Operation</seealso>
        public virtual DescribeInstancePatchStatesResponse EndDescribeInstancePatchStates(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeInstancePatchStatesResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeInstancePatchStatesForPatchGroup

        /// <summary>
        /// Retrieves the high-level patch state for the managed nodes in the specified patch
        /// group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeInstancePatchStatesForPatchGroup service method.</param>
        /// 
        /// <returns>The response from the DescribeInstancePatchStatesForPatchGroup service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidFilterException">
        /// The filter name isn't valid. Verify the you entered the correct name and try again.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidNextTokenException">
        /// The specified token isn't valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribeInstancePatchStatesForPatchGroup">REST API Reference for DescribeInstancePatchStatesForPatchGroup Operation</seealso>
        public virtual DescribeInstancePatchStatesForPatchGroupResponse DescribeInstancePatchStatesForPatchGroup(DescribeInstancePatchStatesForPatchGroupRequest request)
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
        /// <param name="request">Container for the necessary parameters to execute the DescribeInstancePatchStatesForPatchGroup operation on AmazonSimpleSystemsManagementClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeInstancePatchStatesForPatchGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribeInstancePatchStatesForPatchGroup">REST API Reference for DescribeInstancePatchStatesForPatchGroup Operation</seealso>
        public virtual IAsyncResult BeginDescribeInstancePatchStatesForPatchGroup(DescribeInstancePatchStatesForPatchGroupRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeInstancePatchStatesForPatchGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeInstancePatchStatesForPatchGroupResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeInstancePatchStatesForPatchGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeInstancePatchStatesForPatchGroup.</param>
        /// 
        /// <returns>Returns a  DescribeInstancePatchStatesForPatchGroupResult from SimpleSystemsManagement.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribeInstancePatchStatesForPatchGroup">REST API Reference for DescribeInstancePatchStatesForPatchGroup Operation</seealso>
        public virtual DescribeInstancePatchStatesForPatchGroupResponse EndDescribeInstancePatchStatesForPatchGroup(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeInstancePatchStatesForPatchGroupResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeInventoryDeletions

        /// <summary>
        /// Describes a specific delete inventory operation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeInventoryDeletions service method.</param>
        /// 
        /// <returns>The response from the DescribeInventoryDeletions service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidDeletionIdException">
        /// The ID specified for the delete operation doesn't exist or isn't valid. Verify the
        /// ID and try again.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidNextTokenException">
        /// The specified token isn't valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribeInventoryDeletions">REST API Reference for DescribeInventoryDeletions Operation</seealso>
        public virtual DescribeInventoryDeletionsResponse DescribeInventoryDeletions(DescribeInventoryDeletionsRequest request)
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
        /// <param name="request">Container for the necessary parameters to execute the DescribeInventoryDeletions operation on AmazonSimpleSystemsManagementClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeInventoryDeletions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribeInventoryDeletions">REST API Reference for DescribeInventoryDeletions Operation</seealso>
        public virtual IAsyncResult BeginDescribeInventoryDeletions(DescribeInventoryDeletionsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeInventoryDeletionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeInventoryDeletionsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeInventoryDeletions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeInventoryDeletions.</param>
        /// 
        /// <returns>Returns a  DescribeInventoryDeletionsResult from SimpleSystemsManagement.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribeInventoryDeletions">REST API Reference for DescribeInventoryDeletions Operation</seealso>
        public virtual DescribeInventoryDeletionsResponse EndDescribeInventoryDeletions(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeInventoryDeletionsResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeMaintenanceWindowExecutions

        /// <summary>
        /// Lists the executions of a maintenance window. This includes information about when
        /// the maintenance window was scheduled to be active, and information about tasks registered
        /// and run with the maintenance window.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeMaintenanceWindowExecutions service method.</param>
        /// 
        /// <returns>The response from the DescribeMaintenanceWindowExecutions service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribeMaintenanceWindowExecutions">REST API Reference for DescribeMaintenanceWindowExecutions Operation</seealso>
        public virtual DescribeMaintenanceWindowExecutionsResponse DescribeMaintenanceWindowExecutions(DescribeMaintenanceWindowExecutionsRequest request)
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
        /// <param name="request">Container for the necessary parameters to execute the DescribeMaintenanceWindowExecutions operation on AmazonSimpleSystemsManagementClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeMaintenanceWindowExecutions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribeMaintenanceWindowExecutions">REST API Reference for DescribeMaintenanceWindowExecutions Operation</seealso>
        public virtual IAsyncResult BeginDescribeMaintenanceWindowExecutions(DescribeMaintenanceWindowExecutionsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeMaintenanceWindowExecutionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeMaintenanceWindowExecutionsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeMaintenanceWindowExecutions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeMaintenanceWindowExecutions.</param>
        /// 
        /// <returns>Returns a  DescribeMaintenanceWindowExecutionsResult from SimpleSystemsManagement.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribeMaintenanceWindowExecutions">REST API Reference for DescribeMaintenanceWindowExecutions Operation</seealso>
        public virtual DescribeMaintenanceWindowExecutionsResponse EndDescribeMaintenanceWindowExecutions(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeMaintenanceWindowExecutionsResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeMaintenanceWindowExecutionTaskInvocations

        /// <summary>
        /// Retrieves the individual task executions (one per target) for a particular task run
        /// as part of a maintenance window execution.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeMaintenanceWindowExecutionTaskInvocations service method.</param>
        /// 
        /// <returns>The response from the DescribeMaintenanceWindowExecutionTaskInvocations service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.DoesNotExistException">
        /// Error returned when the ID specified for a resource, such as a maintenance window
        /// or patch baseline, doesn't exist.
        /// 
        ///  
        /// <para>
        /// For information about resource quotas in Amazon Web Services Systems Manager, see
        /// <a href="https://docs.aws.amazon.com/general/latest/gr/ssm.html#limits_ssm">Systems
        /// Manager service quotas</a> in the <i>Amazon Web Services General Reference</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribeMaintenanceWindowExecutionTaskInvocations">REST API Reference for DescribeMaintenanceWindowExecutionTaskInvocations Operation</seealso>
        public virtual DescribeMaintenanceWindowExecutionTaskInvocationsResponse DescribeMaintenanceWindowExecutionTaskInvocations(DescribeMaintenanceWindowExecutionTaskInvocationsRequest request)
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
        /// <param name="request">Container for the necessary parameters to execute the DescribeMaintenanceWindowExecutionTaskInvocations operation on AmazonSimpleSystemsManagementClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeMaintenanceWindowExecutionTaskInvocations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribeMaintenanceWindowExecutionTaskInvocations">REST API Reference for DescribeMaintenanceWindowExecutionTaskInvocations Operation</seealso>
        public virtual IAsyncResult BeginDescribeMaintenanceWindowExecutionTaskInvocations(DescribeMaintenanceWindowExecutionTaskInvocationsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeMaintenanceWindowExecutionTaskInvocationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeMaintenanceWindowExecutionTaskInvocationsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeMaintenanceWindowExecutionTaskInvocations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeMaintenanceWindowExecutionTaskInvocations.</param>
        /// 
        /// <returns>Returns a  DescribeMaintenanceWindowExecutionTaskInvocationsResult from SimpleSystemsManagement.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribeMaintenanceWindowExecutionTaskInvocations">REST API Reference for DescribeMaintenanceWindowExecutionTaskInvocations Operation</seealso>
        public virtual DescribeMaintenanceWindowExecutionTaskInvocationsResponse EndDescribeMaintenanceWindowExecutionTaskInvocations(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeMaintenanceWindowExecutionTaskInvocationsResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeMaintenanceWindowExecutionTasks

        /// <summary>
        /// For a given maintenance window execution, lists the tasks that were run.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeMaintenanceWindowExecutionTasks service method.</param>
        /// 
        /// <returns>The response from the DescribeMaintenanceWindowExecutionTasks service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.DoesNotExistException">
        /// Error returned when the ID specified for a resource, such as a maintenance window
        /// or patch baseline, doesn't exist.
        /// 
        ///  
        /// <para>
        /// For information about resource quotas in Amazon Web Services Systems Manager, see
        /// <a href="https://docs.aws.amazon.com/general/latest/gr/ssm.html#limits_ssm">Systems
        /// Manager service quotas</a> in the <i>Amazon Web Services General Reference</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribeMaintenanceWindowExecutionTasks">REST API Reference for DescribeMaintenanceWindowExecutionTasks Operation</seealso>
        public virtual DescribeMaintenanceWindowExecutionTasksResponse DescribeMaintenanceWindowExecutionTasks(DescribeMaintenanceWindowExecutionTasksRequest request)
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
        /// <param name="request">Container for the necessary parameters to execute the DescribeMaintenanceWindowExecutionTasks operation on AmazonSimpleSystemsManagementClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeMaintenanceWindowExecutionTasks
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribeMaintenanceWindowExecutionTasks">REST API Reference for DescribeMaintenanceWindowExecutionTasks Operation</seealso>
        public virtual IAsyncResult BeginDescribeMaintenanceWindowExecutionTasks(DescribeMaintenanceWindowExecutionTasksRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeMaintenanceWindowExecutionTasksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeMaintenanceWindowExecutionTasksResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeMaintenanceWindowExecutionTasks operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeMaintenanceWindowExecutionTasks.</param>
        /// 
        /// <returns>Returns a  DescribeMaintenanceWindowExecutionTasksResult from SimpleSystemsManagement.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribeMaintenanceWindowExecutionTasks">REST API Reference for DescribeMaintenanceWindowExecutionTasks Operation</seealso>
        public virtual DescribeMaintenanceWindowExecutionTasksResponse EndDescribeMaintenanceWindowExecutionTasks(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeMaintenanceWindowExecutionTasksResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeMaintenanceWindows

        /// <summary>
        /// Retrieves the maintenance windows in an Amazon Web Services account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeMaintenanceWindows service method.</param>
        /// 
        /// <returns>The response from the DescribeMaintenanceWindows service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribeMaintenanceWindows">REST API Reference for DescribeMaintenanceWindows Operation</seealso>
        public virtual DescribeMaintenanceWindowsResponse DescribeMaintenanceWindows(DescribeMaintenanceWindowsRequest request)
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
        /// <param name="request">Container for the necessary parameters to execute the DescribeMaintenanceWindows operation on AmazonSimpleSystemsManagementClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeMaintenanceWindows
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribeMaintenanceWindows">REST API Reference for DescribeMaintenanceWindows Operation</seealso>
        public virtual IAsyncResult BeginDescribeMaintenanceWindows(DescribeMaintenanceWindowsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeMaintenanceWindowsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeMaintenanceWindowsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeMaintenanceWindows operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeMaintenanceWindows.</param>
        /// 
        /// <returns>Returns a  DescribeMaintenanceWindowsResult from SimpleSystemsManagement.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribeMaintenanceWindows">REST API Reference for DescribeMaintenanceWindows Operation</seealso>
        public virtual DescribeMaintenanceWindowsResponse EndDescribeMaintenanceWindows(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeMaintenanceWindowsResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeMaintenanceWindowSchedule

        /// <summary>
        /// Retrieves information about upcoming executions of a maintenance window.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeMaintenanceWindowSchedule service method.</param>
        /// 
        /// <returns>The response from the DescribeMaintenanceWindowSchedule service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.DoesNotExistException">
        /// Error returned when the ID specified for a resource, such as a maintenance window
        /// or patch baseline, doesn't exist.
        /// 
        ///  
        /// <para>
        /// For information about resource quotas in Amazon Web Services Systems Manager, see
        /// <a href="https://docs.aws.amazon.com/general/latest/gr/ssm.html#limits_ssm">Systems
        /// Manager service quotas</a> in the <i>Amazon Web Services General Reference</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribeMaintenanceWindowSchedule">REST API Reference for DescribeMaintenanceWindowSchedule Operation</seealso>
        public virtual DescribeMaintenanceWindowScheduleResponse DescribeMaintenanceWindowSchedule(DescribeMaintenanceWindowScheduleRequest request)
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
        /// <param name="request">Container for the necessary parameters to execute the DescribeMaintenanceWindowSchedule operation on AmazonSimpleSystemsManagementClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeMaintenanceWindowSchedule
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribeMaintenanceWindowSchedule">REST API Reference for DescribeMaintenanceWindowSchedule Operation</seealso>
        public virtual IAsyncResult BeginDescribeMaintenanceWindowSchedule(DescribeMaintenanceWindowScheduleRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeMaintenanceWindowScheduleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeMaintenanceWindowScheduleResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeMaintenanceWindowSchedule operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeMaintenanceWindowSchedule.</param>
        /// 
        /// <returns>Returns a  DescribeMaintenanceWindowScheduleResult from SimpleSystemsManagement.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribeMaintenanceWindowSchedule">REST API Reference for DescribeMaintenanceWindowSchedule Operation</seealso>
        public virtual DescribeMaintenanceWindowScheduleResponse EndDescribeMaintenanceWindowSchedule(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeMaintenanceWindowScheduleResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeMaintenanceWindowsForTarget

        /// <summary>
        /// Retrieves information about the maintenance window targets or tasks that a managed
        /// node is associated with.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeMaintenanceWindowsForTarget service method.</param>
        /// 
        /// <returns>The response from the DescribeMaintenanceWindowsForTarget service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribeMaintenanceWindowsForTarget">REST API Reference for DescribeMaintenanceWindowsForTarget Operation</seealso>
        public virtual DescribeMaintenanceWindowsForTargetResponse DescribeMaintenanceWindowsForTarget(DescribeMaintenanceWindowsForTargetRequest request)
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
        /// <param name="request">Container for the necessary parameters to execute the DescribeMaintenanceWindowsForTarget operation on AmazonSimpleSystemsManagementClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeMaintenanceWindowsForTarget
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribeMaintenanceWindowsForTarget">REST API Reference for DescribeMaintenanceWindowsForTarget Operation</seealso>
        public virtual IAsyncResult BeginDescribeMaintenanceWindowsForTarget(DescribeMaintenanceWindowsForTargetRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeMaintenanceWindowsForTargetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeMaintenanceWindowsForTargetResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeMaintenanceWindowsForTarget operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeMaintenanceWindowsForTarget.</param>
        /// 
        /// <returns>Returns a  DescribeMaintenanceWindowsForTargetResult from SimpleSystemsManagement.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribeMaintenanceWindowsForTarget">REST API Reference for DescribeMaintenanceWindowsForTarget Operation</seealso>
        public virtual DescribeMaintenanceWindowsForTargetResponse EndDescribeMaintenanceWindowsForTarget(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeMaintenanceWindowsForTargetResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeMaintenanceWindowTargets

        /// <summary>
        /// Lists the targets registered with the maintenance window.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeMaintenanceWindowTargets service method.</param>
        /// 
        /// <returns>The response from the DescribeMaintenanceWindowTargets service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.DoesNotExistException">
        /// Error returned when the ID specified for a resource, such as a maintenance window
        /// or patch baseline, doesn't exist.
        /// 
        ///  
        /// <para>
        /// For information about resource quotas in Amazon Web Services Systems Manager, see
        /// <a href="https://docs.aws.amazon.com/general/latest/gr/ssm.html#limits_ssm">Systems
        /// Manager service quotas</a> in the <i>Amazon Web Services General Reference</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribeMaintenanceWindowTargets">REST API Reference for DescribeMaintenanceWindowTargets Operation</seealso>
        public virtual DescribeMaintenanceWindowTargetsResponse DescribeMaintenanceWindowTargets(DescribeMaintenanceWindowTargetsRequest request)
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
        /// <param name="request">Container for the necessary parameters to execute the DescribeMaintenanceWindowTargets operation on AmazonSimpleSystemsManagementClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeMaintenanceWindowTargets
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribeMaintenanceWindowTargets">REST API Reference for DescribeMaintenanceWindowTargets Operation</seealso>
        public virtual IAsyncResult BeginDescribeMaintenanceWindowTargets(DescribeMaintenanceWindowTargetsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeMaintenanceWindowTargetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeMaintenanceWindowTargetsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeMaintenanceWindowTargets operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeMaintenanceWindowTargets.</param>
        /// 
        /// <returns>Returns a  DescribeMaintenanceWindowTargetsResult from SimpleSystemsManagement.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribeMaintenanceWindowTargets">REST API Reference for DescribeMaintenanceWindowTargets Operation</seealso>
        public virtual DescribeMaintenanceWindowTargetsResponse EndDescribeMaintenanceWindowTargets(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeMaintenanceWindowTargetsResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeMaintenanceWindowTasks

        /// <summary>
        /// Lists the tasks in a maintenance window.
        /// 
        ///  <note> 
        /// <para>
        /// For maintenance window tasks without a specified target, you can't supply values for
        /// <code>--max-errors</code> and <code>--max-concurrency</code>. Instead, the system
        /// inserts a placeholder value of <code>1</code>, which may be reported in the response
        /// to this command. These values don't affect the running of your task and can be ignored.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeMaintenanceWindowTasks service method.</param>
        /// 
        /// <returns>The response from the DescribeMaintenanceWindowTasks service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.DoesNotExistException">
        /// Error returned when the ID specified for a resource, such as a maintenance window
        /// or patch baseline, doesn't exist.
        /// 
        ///  
        /// <para>
        /// For information about resource quotas in Amazon Web Services Systems Manager, see
        /// <a href="https://docs.aws.amazon.com/general/latest/gr/ssm.html#limits_ssm">Systems
        /// Manager service quotas</a> in the <i>Amazon Web Services General Reference</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribeMaintenanceWindowTasks">REST API Reference for DescribeMaintenanceWindowTasks Operation</seealso>
        public virtual DescribeMaintenanceWindowTasksResponse DescribeMaintenanceWindowTasks(DescribeMaintenanceWindowTasksRequest request)
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
        /// <param name="request">Container for the necessary parameters to execute the DescribeMaintenanceWindowTasks operation on AmazonSimpleSystemsManagementClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeMaintenanceWindowTasks
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribeMaintenanceWindowTasks">REST API Reference for DescribeMaintenanceWindowTasks Operation</seealso>
        public virtual IAsyncResult BeginDescribeMaintenanceWindowTasks(DescribeMaintenanceWindowTasksRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeMaintenanceWindowTasksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeMaintenanceWindowTasksResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeMaintenanceWindowTasks operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeMaintenanceWindowTasks.</param>
        /// 
        /// <returns>Returns a  DescribeMaintenanceWindowTasksResult from SimpleSystemsManagement.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribeMaintenanceWindowTasks">REST API Reference for DescribeMaintenanceWindowTasks Operation</seealso>
        public virtual DescribeMaintenanceWindowTasksResponse EndDescribeMaintenanceWindowTasks(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeMaintenanceWindowTasksResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeOpsItems

        /// <summary>
        /// Query a set of OpsItems. You must have permission in Identity and Access Management
        /// (IAM) to query a list of OpsItems. For more information, see <a href="https://docs.aws.amazon.com/systems-manager/latest/userguide/OpsCenter-getting-started.html">Getting
        /// started with OpsCenter</a> in the <i>Amazon Web Services Systems Manager User Guide</i>.
        /// 
        ///  
        /// <para>
        /// Operations engineers and IT professionals use Amazon Web Services Systems Manager
        /// OpsCenter to view, investigate, and remediate operational issues impacting the performance
        /// and health of their Amazon Web Services resources. For more information, see <a href="https://docs.aws.amazon.com/systems-manager/latest/userguide/OpsCenter.html">OpsCenter</a>
        /// in the <i>Amazon Web Services Systems Manager User Guide</i>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeOpsItems service method.</param>
        /// 
        /// <returns>The response from the DescribeOpsItems service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribeOpsItems">REST API Reference for DescribeOpsItems Operation</seealso>
        public virtual DescribeOpsItemsResponse DescribeOpsItems(DescribeOpsItemsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeOpsItemsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeOpsItemsResponseUnmarshaller.Instance;

            return Invoke<DescribeOpsItemsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeOpsItems operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeOpsItems operation on AmazonSimpleSystemsManagementClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeOpsItems
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribeOpsItems">REST API Reference for DescribeOpsItems Operation</seealso>
        public virtual IAsyncResult BeginDescribeOpsItems(DescribeOpsItemsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeOpsItemsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeOpsItemsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeOpsItems operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeOpsItems.</param>
        /// 
        /// <returns>Returns a  DescribeOpsItemsResult from SimpleSystemsManagement.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribeOpsItems">REST API Reference for DescribeOpsItems Operation</seealso>
        public virtual DescribeOpsItemsResponse EndDescribeOpsItems(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeOpsItemsResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeParameters

        /// <summary>
        /// Get information about a parameter.
        /// 
        ///  
        /// <para>
        /// Request results are returned on a best-effort basis. If you specify <code>MaxResults</code>
        /// in the request, the response includes information up to the limit specified. The number
        /// of items returned, however, can be between zero and the value of <code>MaxResults</code>.
        /// If the service reaches an internal limit while processing the results, it stops the
        /// operation and returns the matching values up to that point and a <code>NextToken</code>.
        /// You can specify the <code>NextToken</code> in a subsequent call to get the next set
        /// of results.
        /// </para>
        ///  <important> 
        /// <para>
        /// If you change the KMS key alias for the KMS key used to encrypt a parameter, then
        /// you must also update the key alias the parameter uses to reference KMS. Otherwise,
        /// <code>DescribeParameters</code> retrieves whatever the original key alias was referencing.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeParameters service method.</param>
        /// 
        /// <returns>The response from the DescribeParameters service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidFilterKeyException">
        /// The specified key isn't valid.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidFilterOptionException">
        /// The specified filter option isn't valid. Valid options are Equals and BeginsWith.
        /// For Path filter, valid options are Recursive and OneLevel.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidFilterValueException">
        /// The filter value isn't valid. Verify the value and try again.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidNextTokenException">
        /// The specified token isn't valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribeParameters">REST API Reference for DescribeParameters Operation</seealso>
        public virtual DescribeParametersResponse DescribeParameters(DescribeParametersRequest request)
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
        /// <param name="request">Container for the necessary parameters to execute the DescribeParameters operation on AmazonSimpleSystemsManagementClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeParameters
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribeParameters">REST API Reference for DescribeParameters Operation</seealso>
        public virtual IAsyncResult BeginDescribeParameters(DescribeParametersRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeParametersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeParametersResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeParameters operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeParameters.</param>
        /// 
        /// <returns>Returns a  DescribeParametersResult from SimpleSystemsManagement.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribeParameters">REST API Reference for DescribeParameters Operation</seealso>
        public virtual DescribeParametersResponse EndDescribeParameters(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeParametersResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribePatchBaselines

        /// <summary>
        /// Lists the patch baselines in your Amazon Web Services account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribePatchBaselines service method.</param>
        /// 
        /// <returns>The response from the DescribePatchBaselines service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribePatchBaselines">REST API Reference for DescribePatchBaselines Operation</seealso>
        public virtual DescribePatchBaselinesResponse DescribePatchBaselines(DescribePatchBaselinesRequest request)
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
        /// <param name="request">Container for the necessary parameters to execute the DescribePatchBaselines operation on AmazonSimpleSystemsManagementClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribePatchBaselines
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribePatchBaselines">REST API Reference for DescribePatchBaselines Operation</seealso>
        public virtual IAsyncResult BeginDescribePatchBaselines(DescribePatchBaselinesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribePatchBaselinesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribePatchBaselinesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribePatchBaselines operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribePatchBaselines.</param>
        /// 
        /// <returns>Returns a  DescribePatchBaselinesResult from SimpleSystemsManagement.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribePatchBaselines">REST API Reference for DescribePatchBaselines Operation</seealso>
        public virtual DescribePatchBaselinesResponse EndDescribePatchBaselines(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribePatchBaselinesResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribePatchGroups

        /// <summary>
        /// Lists all patch groups that have been registered with patch baselines.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribePatchGroups service method.</param>
        /// 
        /// <returns>The response from the DescribePatchGroups service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribePatchGroups">REST API Reference for DescribePatchGroups Operation</seealso>
        public virtual DescribePatchGroupsResponse DescribePatchGroups(DescribePatchGroupsRequest request)
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
        /// <param name="request">Container for the necessary parameters to execute the DescribePatchGroups operation on AmazonSimpleSystemsManagementClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribePatchGroups
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribePatchGroups">REST API Reference for DescribePatchGroups Operation</seealso>
        public virtual IAsyncResult BeginDescribePatchGroups(DescribePatchGroupsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribePatchGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribePatchGroupsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribePatchGroups operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribePatchGroups.</param>
        /// 
        /// <returns>Returns a  DescribePatchGroupsResult from SimpleSystemsManagement.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribePatchGroups">REST API Reference for DescribePatchGroups Operation</seealso>
        public virtual DescribePatchGroupsResponse EndDescribePatchGroups(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribePatchGroupsResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribePatchGroupState

        /// <summary>
        /// Returns high-level aggregated patch compliance state information for a patch group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribePatchGroupState service method.</param>
        /// 
        /// <returns>The response from the DescribePatchGroupState service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidNextTokenException">
        /// The specified token isn't valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribePatchGroupState">REST API Reference for DescribePatchGroupState Operation</seealso>
        public virtual DescribePatchGroupStateResponse DescribePatchGroupState(DescribePatchGroupStateRequest request)
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
        /// <param name="request">Container for the necessary parameters to execute the DescribePatchGroupState operation on AmazonSimpleSystemsManagementClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribePatchGroupState
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribePatchGroupState">REST API Reference for DescribePatchGroupState Operation</seealso>
        public virtual IAsyncResult BeginDescribePatchGroupState(DescribePatchGroupStateRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribePatchGroupStateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribePatchGroupStateResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribePatchGroupState operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribePatchGroupState.</param>
        /// 
        /// <returns>Returns a  DescribePatchGroupStateResult from SimpleSystemsManagement.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribePatchGroupState">REST API Reference for DescribePatchGroupState Operation</seealso>
        public virtual DescribePatchGroupStateResponse EndDescribePatchGroupState(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribePatchGroupStateResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribePatchProperties

        /// <summary>
        /// Lists the properties of available patches organized by product, product family, classification,
        /// severity, and other properties of available patches. You can use the reported properties
        /// in the filters you specify in requests for operations such as <a>CreatePatchBaseline</a>,
        /// <a>UpdatePatchBaseline</a>, <a>DescribeAvailablePatches</a>, and <a>DescribePatchBaselines</a>.
        /// 
        ///  
        /// <para>
        /// The following section lists the properties that can be used in filters for each major
        /// operating system type:
        /// </para>
        ///  <dl> <dt>AMAZON_LINUX</dt> <dd> 
        /// <para>
        /// Valid properties: <code>PRODUCT</code> | <code>CLASSIFICATION</code> | <code>SEVERITY</code>
        /// 
        /// </para>
        ///  </dd> <dt>AMAZON_LINUX_2</dt> <dd> 
        /// <para>
        /// Valid properties: <code>PRODUCT</code> | <code>CLASSIFICATION</code> | <code>SEVERITY</code>
        /// 
        /// </para>
        ///  </dd> <dt>CENTOS</dt> <dd> 
        /// <para>
        /// Valid properties: <code>PRODUCT</code> | <code>CLASSIFICATION</code> | <code>SEVERITY</code>
        /// 
        /// </para>
        ///  </dd> <dt>DEBIAN</dt> <dd> 
        /// <para>
        /// Valid properties: <code>PRODUCT</code> | <code>PRIORITY</code> 
        /// </para>
        ///  </dd> <dt>MACOS</dt> <dd> 
        /// <para>
        /// Valid properties: <code>PRODUCT</code> | <code>CLASSIFICATION</code> 
        /// </para>
        ///  </dd> <dt>ORACLE_LINUX</dt> <dd> 
        /// <para>
        /// Valid properties: <code>PRODUCT</code> | <code>CLASSIFICATION</code> | <code>SEVERITY</code>
        /// 
        /// </para>
        ///  </dd> <dt>REDHAT_ENTERPRISE_LINUX</dt> <dd> 
        /// <para>
        /// Valid properties: <code>PRODUCT</code> | <code>CLASSIFICATION</code> | <code>SEVERITY</code>
        /// 
        /// </para>
        ///  </dd> <dt>SUSE</dt> <dd> 
        /// <para>
        /// Valid properties: <code>PRODUCT</code> | <code>CLASSIFICATION</code> | <code>SEVERITY</code>
        /// 
        /// </para>
        ///  </dd> <dt>UBUNTU</dt> <dd> 
        /// <para>
        /// Valid properties: <code>PRODUCT</code> | <code>PRIORITY</code> 
        /// </para>
        ///  </dd> <dt>WINDOWS</dt> <dd> 
        /// <para>
        /// Valid properties: <code>PRODUCT</code> | <code>PRODUCT_FAMILY</code> | <code>CLASSIFICATION</code>
        /// | <code>MSRC_SEVERITY</code> 
        /// </para>
        ///  </dd> </dl>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribePatchProperties service method.</param>
        /// 
        /// <returns>The response from the DescribePatchProperties service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribePatchProperties">REST API Reference for DescribePatchProperties Operation</seealso>
        public virtual DescribePatchPropertiesResponse DescribePatchProperties(DescribePatchPropertiesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribePatchPropertiesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribePatchPropertiesResponseUnmarshaller.Instance;

            return Invoke<DescribePatchPropertiesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribePatchProperties operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribePatchProperties operation on AmazonSimpleSystemsManagementClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribePatchProperties
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribePatchProperties">REST API Reference for DescribePatchProperties Operation</seealso>
        public virtual IAsyncResult BeginDescribePatchProperties(DescribePatchPropertiesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribePatchPropertiesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribePatchPropertiesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribePatchProperties operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribePatchProperties.</param>
        /// 
        /// <returns>Returns a  DescribePatchPropertiesResult from SimpleSystemsManagement.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribePatchProperties">REST API Reference for DescribePatchProperties Operation</seealso>
        public virtual DescribePatchPropertiesResponse EndDescribePatchProperties(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribePatchPropertiesResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeSessions

        /// <summary>
        /// Retrieves a list of all active sessions (both connected and disconnected) or terminated
        /// sessions from the past 30 days.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSessions service method.</param>
        /// 
        /// <returns>The response from the DescribeSessions service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidFilterKeyException">
        /// The specified key isn't valid.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidNextTokenException">
        /// The specified token isn't valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribeSessions">REST API Reference for DescribeSessions Operation</seealso>
        public virtual DescribeSessionsResponse DescribeSessions(DescribeSessionsRequest request)
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
        /// <param name="request">Container for the necessary parameters to execute the DescribeSessions operation on AmazonSimpleSystemsManagementClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeSessions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribeSessions">REST API Reference for DescribeSessions Operation</seealso>
        public virtual IAsyncResult BeginDescribeSessions(DescribeSessionsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeSessionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeSessionsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeSessions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeSessions.</param>
        /// 
        /// <returns>Returns a  DescribeSessionsResult from SimpleSystemsManagement.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribeSessions">REST API Reference for DescribeSessions Operation</seealso>
        public virtual DescribeSessionsResponse EndDescribeSessions(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeSessionsResponse>(asyncResult);
        }

        #endregion
        
        #region  DisassociateOpsItemRelatedItem

        /// <summary>
        /// Deletes the association between an OpsItem and a related item. For example, this API
        /// operation can delete an Incident Manager incident from an OpsItem. Incident Manager
        /// is a capability of Amazon Web Services Systems Manager.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateOpsItemRelatedItem service method.</param>
        /// 
        /// <returns>The response from the DisassociateOpsItemRelatedItem service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.OpsItemInvalidParameterException">
        /// A specified parameter argument isn't valid. Verify the available arguments and try
        /// again.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.OpsItemNotFoundException">
        /// The specified OpsItem ID doesn't exist. Verify the ID and try again.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.OpsItemRelatedItemAssociationNotFoundException">
        /// The association wasn't found using the parameters you specified in the call. Verify
        /// the information and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DisassociateOpsItemRelatedItem">REST API Reference for DisassociateOpsItemRelatedItem Operation</seealso>
        public virtual DisassociateOpsItemRelatedItemResponse DisassociateOpsItemRelatedItem(DisassociateOpsItemRelatedItemRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateOpsItemRelatedItemRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateOpsItemRelatedItemResponseUnmarshaller.Instance;

            return Invoke<DisassociateOpsItemRelatedItemResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateOpsItemRelatedItem operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateOpsItemRelatedItem operation on AmazonSimpleSystemsManagementClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisassociateOpsItemRelatedItem
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DisassociateOpsItemRelatedItem">REST API Reference for DisassociateOpsItemRelatedItem Operation</seealso>
        public virtual IAsyncResult BeginDisassociateOpsItemRelatedItem(DisassociateOpsItemRelatedItemRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateOpsItemRelatedItemRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateOpsItemRelatedItemResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DisassociateOpsItemRelatedItem operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisassociateOpsItemRelatedItem.</param>
        /// 
        /// <returns>Returns a  DisassociateOpsItemRelatedItemResult from SimpleSystemsManagement.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DisassociateOpsItemRelatedItem">REST API Reference for DisassociateOpsItemRelatedItem Operation</seealso>
        public virtual DisassociateOpsItemRelatedItemResponse EndDisassociateOpsItemRelatedItem(IAsyncResult asyncResult)
        {
            return EndInvoke<DisassociateOpsItemRelatedItemResponse>(asyncResult);
        }

        #endregion
        
        #region  GetAutomationExecution

        /// <summary>
        /// Get detailed information about a particular Automation execution.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAutomationExecution service method.</param>
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
        public virtual GetAutomationExecutionResponse GetAutomationExecution(GetAutomationExecutionRequest request)
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
        /// <param name="request">Container for the necessary parameters to execute the GetAutomationExecution operation on AmazonSimpleSystemsManagementClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetAutomationExecution
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/GetAutomationExecution">REST API Reference for GetAutomationExecution Operation</seealso>
        public virtual IAsyncResult BeginGetAutomationExecution(GetAutomationExecutionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAutomationExecutionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAutomationExecutionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetAutomationExecution operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetAutomationExecution.</param>
        /// 
        /// <returns>Returns a  GetAutomationExecutionResult from SimpleSystemsManagement.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/GetAutomationExecution">REST API Reference for GetAutomationExecution Operation</seealso>
        public virtual GetAutomationExecutionResponse EndGetAutomationExecution(IAsyncResult asyncResult)
        {
            return EndInvoke<GetAutomationExecutionResponse>(asyncResult);
        }

        #endregion
        
        #region  GetCalendarState

        /// <summary>
        /// Gets the state of a Amazon Web Services Systems Manager change calendar at the current
        /// time or a specified time. If you specify a time, <code>GetCalendarState</code> returns
        /// the state of the calendar at that specific time, and returns the next time that the
        /// change calendar state will transition. If you don't specify a time, <code>GetCalendarState</code>
        /// uses the current time. Change Calendar entries have two possible states: <code>OPEN</code>
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
        /// For more information about Change Calendar, a capability of Amazon Web Services Systems
        /// Manager, see <a href="https://docs.aws.amazon.com/systems-manager/latest/userguide/systems-manager-change-calendar.html">Amazon
        /// Web Services Systems Manager Change Calendar</a> in the <i>Amazon Web Services Systems
        /// Manager User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCalendarState service method.</param>
        /// 
        /// <returns>The response from the GetCalendarState service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidDocumentException">
        /// The specified SSM document doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidDocumentTypeException">
        /// The SSM document type isn't valid. Valid document types are described in the <code>DocumentType</code>
        /// property.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.UnsupportedCalendarException">
        /// The calendar entry contained in the specified SSM document isn't supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/GetCalendarState">REST API Reference for GetCalendarState Operation</seealso>
        public virtual GetCalendarStateResponse GetCalendarState(GetCalendarStateRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetCalendarStateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCalendarStateResponseUnmarshaller.Instance;

            return Invoke<GetCalendarStateResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetCalendarState operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetCalendarState operation on AmazonSimpleSystemsManagementClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetCalendarState
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/GetCalendarState">REST API Reference for GetCalendarState Operation</seealso>
        public virtual IAsyncResult BeginGetCalendarState(GetCalendarStateRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetCalendarStateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCalendarStateResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetCalendarState operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetCalendarState.</param>
        /// 
        /// <returns>Returns a  GetCalendarStateResult from SimpleSystemsManagement.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/GetCalendarState">REST API Reference for GetCalendarState Operation</seealso>
        public virtual GetCalendarStateResponse EndGetCalendarState(IAsyncResult asyncResult)
        {
            return EndInvoke<GetCalendarStateResponse>(asyncResult);
        }

        #endregion
        
        #region  GetCommandInvocation

        /// <summary>
        /// Returns detailed information about command execution for an invocation or plugin.
        /// 
        ///  
        /// <para>
        ///  <code>GetCommandInvocation</code> only gives the execution status of a plugin in
        /// a document. To get the command execution status on a specific managed node, use <a>ListCommandInvocations</a>.
        /// To get the command execution status across managed nodes, use <a>ListCommands</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCommandInvocation service method.</param>
        /// 
        /// <returns>The response from the GetCommandInvocation service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidCommandIdException">
        /// The specified command ID isn't valid. Verify the ID and try again.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidInstanceIdException">
        /// The following problems can cause this exception:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You don't have permission to access the managed node.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Amazon Web Services Systems Manager Agent(SSM Agent) isn't running. Verify that SSM
        /// Agent is running.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// SSM Agent isn't registered with the SSM endpoint. Try reinstalling SSM Agent.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The managed node isn't in valid state. Valid states are: <code>Running</code>, <code>Pending</code>,
        /// <code>Stopped</code>, and <code>Stopping</code>. Invalid states are: <code>Shutting-down</code>
        /// and <code>Terminated</code>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidPluginNameException">
        /// The plugin name isn't valid.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvocationDoesNotExistException">
        /// The command ID and managed node ID you specified didn't match any invocations. Verify
        /// the command ID and the managed node ID and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/GetCommandInvocation">REST API Reference for GetCommandInvocation Operation</seealso>
        public virtual GetCommandInvocationResponse GetCommandInvocation(GetCommandInvocationRequest request)
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
        /// <param name="request">Container for the necessary parameters to execute the GetCommandInvocation operation on AmazonSimpleSystemsManagementClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetCommandInvocation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/GetCommandInvocation">REST API Reference for GetCommandInvocation Operation</seealso>
        public virtual IAsyncResult BeginGetCommandInvocation(GetCommandInvocationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetCommandInvocationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCommandInvocationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetCommandInvocation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetCommandInvocation.</param>
        /// 
        /// <returns>Returns a  GetCommandInvocationResult from SimpleSystemsManagement.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/GetCommandInvocation">REST API Reference for GetCommandInvocation Operation</seealso>
        public virtual GetCommandInvocationResponse EndGetCommandInvocation(IAsyncResult asyncResult)
        {
            return EndInvoke<GetCommandInvocationResponse>(asyncResult);
        }

        #endregion
        
        #region  GetConnectionStatus

        /// <summary>
        /// Retrieves the Session Manager connection status for a managed node to determine whether
        /// it is running and ready to receive Session Manager connections.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetConnectionStatus service method.</param>
        /// 
        /// <returns>The response from the GetConnectionStatus service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/GetConnectionStatus">REST API Reference for GetConnectionStatus Operation</seealso>
        public virtual GetConnectionStatusResponse GetConnectionStatus(GetConnectionStatusRequest request)
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
        /// <param name="request">Container for the necessary parameters to execute the GetConnectionStatus operation on AmazonSimpleSystemsManagementClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetConnectionStatus
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/GetConnectionStatus">REST API Reference for GetConnectionStatus Operation</seealso>
        public virtual IAsyncResult BeginGetConnectionStatus(GetConnectionStatusRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetConnectionStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetConnectionStatusResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetConnectionStatus operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetConnectionStatus.</param>
        /// 
        /// <returns>Returns a  GetConnectionStatusResult from SimpleSystemsManagement.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/GetConnectionStatus">REST API Reference for GetConnectionStatus Operation</seealso>
        public virtual GetConnectionStatusResponse EndGetConnectionStatus(IAsyncResult asyncResult)
        {
            return EndInvoke<GetConnectionStatusResponse>(asyncResult);
        }

        #endregion
        
        #region  GetDefaultPatchBaseline

        /// <summary>
        /// Retrieves the default patch baseline. Amazon Web Services Systems Manager supports
        /// creating multiple default patch baselines. For example, you can create a default patch
        /// baseline for each operating system.
        /// 
        ///  
        /// <para>
        /// If you don't specify an operating system value, the default patch baseline for Windows
        /// is returned.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDefaultPatchBaseline service method.</param>
        /// 
        /// <returns>The response from the GetDefaultPatchBaseline service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/GetDefaultPatchBaseline">REST API Reference for GetDefaultPatchBaseline Operation</seealso>
        public virtual GetDefaultPatchBaselineResponse GetDefaultPatchBaseline(GetDefaultPatchBaselineRequest request)
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
        /// <param name="request">Container for the necessary parameters to execute the GetDefaultPatchBaseline operation on AmazonSimpleSystemsManagementClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetDefaultPatchBaseline
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/GetDefaultPatchBaseline">REST API Reference for GetDefaultPatchBaseline Operation</seealso>
        public virtual IAsyncResult BeginGetDefaultPatchBaseline(GetDefaultPatchBaselineRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDefaultPatchBaselineRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDefaultPatchBaselineResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetDefaultPatchBaseline operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDefaultPatchBaseline.</param>
        /// 
        /// <returns>Returns a  GetDefaultPatchBaselineResult from SimpleSystemsManagement.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/GetDefaultPatchBaseline">REST API Reference for GetDefaultPatchBaseline Operation</seealso>
        public virtual GetDefaultPatchBaselineResponse EndGetDefaultPatchBaseline(IAsyncResult asyncResult)
        {
            return EndInvoke<GetDefaultPatchBaselineResponse>(asyncResult);
        }

        #endregion
        
        #region  GetDeployablePatchSnapshotForInstance

        /// <summary>
        /// Retrieves the current snapshot for the patch baseline the managed node uses. This
        /// API is primarily used by the <code>AWS-RunPatchBaseline</code> Systems Manager document
        /// (SSM document).
        /// 
        ///  <note> 
        /// <para>
        /// If you run the command locally, such as with the Command Line Interface (CLI), the
        /// system attempts to use your local Amazon Web Services credentials and the operation
        /// fails. To avoid this, you can run the command in the Amazon Web Services Systems Manager
        /// console. Use Run Command, a capability of Amazon Web Services Systems Manager, with
        /// an SSM document that enables you to target a managed node with a script or command.
        /// For example, run the command using the <code>AWS-RunShellScript</code> document or
        /// the <code>AWS-RunPowerShellScript</code> document.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDeployablePatchSnapshotForInstance service method.</param>
        /// 
        /// <returns>The response from the GetDeployablePatchSnapshotForInstance service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.UnsupportedFeatureRequiredException">
        /// Patching for applications released by Microsoft is only available on EC2 instances
        /// and advanced instances. To patch applications released by Microsoft on on-premises
        /// servers and VMs, you must enable advanced instances. For more information, see <a
        /// href="https://docs.aws.amazon.com/systems-manager/latest/userguide/systems-manager-managedinstances-advanced.html">Enabling
        /// the advanced-instances tier</a> in the <i>Amazon Web Services Systems Manager User
        /// Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.UnsupportedOperatingSystemException">
        /// The operating systems you specified isn't supported, or the operation isn't supported
        /// for the operating system.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/GetDeployablePatchSnapshotForInstance">REST API Reference for GetDeployablePatchSnapshotForInstance Operation</seealso>
        public virtual GetDeployablePatchSnapshotForInstanceResponse GetDeployablePatchSnapshotForInstance(GetDeployablePatchSnapshotForInstanceRequest request)
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
        /// <param name="request">Container for the necessary parameters to execute the GetDeployablePatchSnapshotForInstance operation on AmazonSimpleSystemsManagementClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetDeployablePatchSnapshotForInstance
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/GetDeployablePatchSnapshotForInstance">REST API Reference for GetDeployablePatchSnapshotForInstance Operation</seealso>
        public virtual IAsyncResult BeginGetDeployablePatchSnapshotForInstance(GetDeployablePatchSnapshotForInstanceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDeployablePatchSnapshotForInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDeployablePatchSnapshotForInstanceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetDeployablePatchSnapshotForInstance operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDeployablePatchSnapshotForInstance.</param>
        /// 
        /// <returns>Returns a  GetDeployablePatchSnapshotForInstanceResult from SimpleSystemsManagement.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/GetDeployablePatchSnapshotForInstance">REST API Reference for GetDeployablePatchSnapshotForInstance Operation</seealso>
        public virtual GetDeployablePatchSnapshotForInstanceResponse EndGetDeployablePatchSnapshotForInstance(IAsyncResult asyncResult)
        {
            return EndInvoke<GetDeployablePatchSnapshotForInstanceResponse>(asyncResult);
        }

        #endregion
        
        #region  GetDocument

        /// <summary>
        /// Gets the contents of the specified Amazon Web Services Systems Manager document (SSM
        /// document).
        /// </summary>
        /// <param name="name">The name of the SSM document.</param>
        /// 
        /// <returns>The response from the GetDocument service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidDocumentException">
        /// The specified SSM document doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidDocumentVersionException">
        /// The document version isn't valid or doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/GetDocument">REST API Reference for GetDocument Operation</seealso>
        public virtual GetDocumentResponse GetDocument(string name)
        {
            var request = new GetDocumentRequest();
            request.Name = name;
            return GetDocument(request);
        }


        /// <summary>
        /// Gets the contents of the specified Amazon Web Services Systems Manager document (SSM
        /// document).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDocument service method.</param>
        /// 
        /// <returns>The response from the GetDocument service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidDocumentException">
        /// The specified SSM document doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidDocumentVersionException">
        /// The document version isn't valid or doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/GetDocument">REST API Reference for GetDocument Operation</seealso>
        public virtual GetDocumentResponse GetDocument(GetDocumentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDocumentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDocumentResponseUnmarshaller.Instance;

            return Invoke<GetDocumentResponse>(request, options);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/GetDocument">REST API Reference for GetDocument Operation</seealso>
        public virtual IAsyncResult BeginGetDocument(GetDocumentRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDocumentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDocumentResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetDocument operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDocument.</param>
        /// 
        /// <returns>Returns a  GetDocumentResult from SimpleSystemsManagement.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/GetDocument">REST API Reference for GetDocument Operation</seealso>
        public virtual GetDocumentResponse EndGetDocument(IAsyncResult asyncResult)
        {
            return EndInvoke<GetDocumentResponse>(asyncResult);
        }

        #endregion
        
        #region  GetInventory

        /// <summary>
        /// Query inventory information. This includes managed node status, such as <code>Stopped</code>
        /// or <code>Terminated</code>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetInventory service method.</param>
        /// 
        /// <returns>The response from the GetInventory service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidAggregatorException">
        /// The specified aggregator isn't valid for inventory groups. Verify that the aggregator
        /// uses a valid inventory type such as <code>AWS:Application</code> or <code>AWS:InstanceInformation</code>.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidFilterException">
        /// The filter name isn't valid. Verify the you entered the correct name and try again.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidInventoryGroupException">
        /// The specified inventory group isn't valid.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidNextTokenException">
        /// The specified token isn't valid.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidResultAttributeException">
        /// The specified inventory item result attribute isn't valid.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidTypeNameException">
        /// The parameter type name isn't valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/GetInventory">REST API Reference for GetInventory Operation</seealso>
        public virtual GetInventoryResponse GetInventory(GetInventoryRequest request)
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
        /// <param name="request">Container for the necessary parameters to execute the GetInventory operation on AmazonSimpleSystemsManagementClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetInventory
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/GetInventory">REST API Reference for GetInventory Operation</seealso>
        public virtual IAsyncResult BeginGetInventory(GetInventoryRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetInventoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetInventoryResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetInventory operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetInventory.</param>
        /// 
        /// <returns>Returns a  GetInventoryResult from SimpleSystemsManagement.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/GetInventory">REST API Reference for GetInventory Operation</seealso>
        public virtual GetInventoryResponse EndGetInventory(IAsyncResult asyncResult)
        {
            return EndInvoke<GetInventoryResponse>(asyncResult);
        }

        #endregion
        
        #region  GetInventorySchema

        /// <summary>
        /// Return a list of inventory type names for the account, or return a list of attribute
        /// names for a specific Inventory item type.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetInventorySchema service method.</param>
        /// 
        /// <returns>The response from the GetInventorySchema service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidNextTokenException">
        /// The specified token isn't valid.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidTypeNameException">
        /// The parameter type name isn't valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/GetInventorySchema">REST API Reference for GetInventorySchema Operation</seealso>
        public virtual GetInventorySchemaResponse GetInventorySchema(GetInventorySchemaRequest request)
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
        /// <param name="request">Container for the necessary parameters to execute the GetInventorySchema operation on AmazonSimpleSystemsManagementClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetInventorySchema
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/GetInventorySchema">REST API Reference for GetInventorySchema Operation</seealso>
        public virtual IAsyncResult BeginGetInventorySchema(GetInventorySchemaRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetInventorySchemaRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetInventorySchemaResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetInventorySchema operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetInventorySchema.</param>
        /// 
        /// <returns>Returns a  GetInventorySchemaResult from SimpleSystemsManagement.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/GetInventorySchema">REST API Reference for GetInventorySchema Operation</seealso>
        public virtual GetInventorySchemaResponse EndGetInventorySchema(IAsyncResult asyncResult)
        {
            return EndInvoke<GetInventorySchemaResponse>(asyncResult);
        }

        #endregion
        
        #region  GetMaintenanceWindow

        /// <summary>
        /// Retrieves a maintenance window.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMaintenanceWindow service method.</param>
        /// 
        /// <returns>The response from the GetMaintenanceWindow service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.DoesNotExistException">
        /// Error returned when the ID specified for a resource, such as a maintenance window
        /// or patch baseline, doesn't exist.
        /// 
        ///  
        /// <para>
        /// For information about resource quotas in Amazon Web Services Systems Manager, see
        /// <a href="https://docs.aws.amazon.com/general/latest/gr/ssm.html#limits_ssm">Systems
        /// Manager service quotas</a> in the <i>Amazon Web Services General Reference</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/GetMaintenanceWindow">REST API Reference for GetMaintenanceWindow Operation</seealso>
        public virtual GetMaintenanceWindowResponse GetMaintenanceWindow(GetMaintenanceWindowRequest request)
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
        /// <param name="request">Container for the necessary parameters to execute the GetMaintenanceWindow operation on AmazonSimpleSystemsManagementClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetMaintenanceWindow
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/GetMaintenanceWindow">REST API Reference for GetMaintenanceWindow Operation</seealso>
        public virtual IAsyncResult BeginGetMaintenanceWindow(GetMaintenanceWindowRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetMaintenanceWindowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMaintenanceWindowResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetMaintenanceWindow operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetMaintenanceWindow.</param>
        /// 
        /// <returns>Returns a  GetMaintenanceWindowResult from SimpleSystemsManagement.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/GetMaintenanceWindow">REST API Reference for GetMaintenanceWindow Operation</seealso>
        public virtual GetMaintenanceWindowResponse EndGetMaintenanceWindow(IAsyncResult asyncResult)
        {
            return EndInvoke<GetMaintenanceWindowResponse>(asyncResult);
        }

        #endregion
        
        #region  GetMaintenanceWindowExecution

        /// <summary>
        /// Retrieves details about a specific a maintenance window execution.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMaintenanceWindowExecution service method.</param>
        /// 
        /// <returns>The response from the GetMaintenanceWindowExecution service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.DoesNotExistException">
        /// Error returned when the ID specified for a resource, such as a maintenance window
        /// or patch baseline, doesn't exist.
        /// 
        ///  
        /// <para>
        /// For information about resource quotas in Amazon Web Services Systems Manager, see
        /// <a href="https://docs.aws.amazon.com/general/latest/gr/ssm.html#limits_ssm">Systems
        /// Manager service quotas</a> in the <i>Amazon Web Services General Reference</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/GetMaintenanceWindowExecution">REST API Reference for GetMaintenanceWindowExecution Operation</seealso>
        public virtual GetMaintenanceWindowExecutionResponse GetMaintenanceWindowExecution(GetMaintenanceWindowExecutionRequest request)
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
        /// <param name="request">Container for the necessary parameters to execute the GetMaintenanceWindowExecution operation on AmazonSimpleSystemsManagementClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetMaintenanceWindowExecution
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/GetMaintenanceWindowExecution">REST API Reference for GetMaintenanceWindowExecution Operation</seealso>
        public virtual IAsyncResult BeginGetMaintenanceWindowExecution(GetMaintenanceWindowExecutionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetMaintenanceWindowExecutionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMaintenanceWindowExecutionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetMaintenanceWindowExecution operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetMaintenanceWindowExecution.</param>
        /// 
        /// <returns>Returns a  GetMaintenanceWindowExecutionResult from SimpleSystemsManagement.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/GetMaintenanceWindowExecution">REST API Reference for GetMaintenanceWindowExecution Operation</seealso>
        public virtual GetMaintenanceWindowExecutionResponse EndGetMaintenanceWindowExecution(IAsyncResult asyncResult)
        {
            return EndInvoke<GetMaintenanceWindowExecutionResponse>(asyncResult);
        }

        #endregion
        
        #region  GetMaintenanceWindowExecutionTask

        /// <summary>
        /// Retrieves the details about a specific task run as part of a maintenance window execution.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMaintenanceWindowExecutionTask service method.</param>
        /// 
        /// <returns>The response from the GetMaintenanceWindowExecutionTask service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.DoesNotExistException">
        /// Error returned when the ID specified for a resource, such as a maintenance window
        /// or patch baseline, doesn't exist.
        /// 
        ///  
        /// <para>
        /// For information about resource quotas in Amazon Web Services Systems Manager, see
        /// <a href="https://docs.aws.amazon.com/general/latest/gr/ssm.html#limits_ssm">Systems
        /// Manager service quotas</a> in the <i>Amazon Web Services General Reference</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/GetMaintenanceWindowExecutionTask">REST API Reference for GetMaintenanceWindowExecutionTask Operation</seealso>
        public virtual GetMaintenanceWindowExecutionTaskResponse GetMaintenanceWindowExecutionTask(GetMaintenanceWindowExecutionTaskRequest request)
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
        /// <param name="request">Container for the necessary parameters to execute the GetMaintenanceWindowExecutionTask operation on AmazonSimpleSystemsManagementClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetMaintenanceWindowExecutionTask
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/GetMaintenanceWindowExecutionTask">REST API Reference for GetMaintenanceWindowExecutionTask Operation</seealso>
        public virtual IAsyncResult BeginGetMaintenanceWindowExecutionTask(GetMaintenanceWindowExecutionTaskRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetMaintenanceWindowExecutionTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMaintenanceWindowExecutionTaskResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetMaintenanceWindowExecutionTask operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetMaintenanceWindowExecutionTask.</param>
        /// 
        /// <returns>Returns a  GetMaintenanceWindowExecutionTaskResult from SimpleSystemsManagement.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/GetMaintenanceWindowExecutionTask">REST API Reference for GetMaintenanceWindowExecutionTask Operation</seealso>
        public virtual GetMaintenanceWindowExecutionTaskResponse EndGetMaintenanceWindowExecutionTask(IAsyncResult asyncResult)
        {
            return EndInvoke<GetMaintenanceWindowExecutionTaskResponse>(asyncResult);
        }

        #endregion
        
        #region  GetMaintenanceWindowExecutionTaskInvocation

        /// <summary>
        /// Retrieves information about a specific task running on a specific target.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMaintenanceWindowExecutionTaskInvocation service method.</param>
        /// 
        /// <returns>The response from the GetMaintenanceWindowExecutionTaskInvocation service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.DoesNotExistException">
        /// Error returned when the ID specified for a resource, such as a maintenance window
        /// or patch baseline, doesn't exist.
        /// 
        ///  
        /// <para>
        /// For information about resource quotas in Amazon Web Services Systems Manager, see
        /// <a href="https://docs.aws.amazon.com/general/latest/gr/ssm.html#limits_ssm">Systems
        /// Manager service quotas</a> in the <i>Amazon Web Services General Reference</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/GetMaintenanceWindowExecutionTaskInvocation">REST API Reference for GetMaintenanceWindowExecutionTaskInvocation Operation</seealso>
        public virtual GetMaintenanceWindowExecutionTaskInvocationResponse GetMaintenanceWindowExecutionTaskInvocation(GetMaintenanceWindowExecutionTaskInvocationRequest request)
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
        /// <param name="request">Container for the necessary parameters to execute the GetMaintenanceWindowExecutionTaskInvocation operation on AmazonSimpleSystemsManagementClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetMaintenanceWindowExecutionTaskInvocation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/GetMaintenanceWindowExecutionTaskInvocation">REST API Reference for GetMaintenanceWindowExecutionTaskInvocation Operation</seealso>
        public virtual IAsyncResult BeginGetMaintenanceWindowExecutionTaskInvocation(GetMaintenanceWindowExecutionTaskInvocationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetMaintenanceWindowExecutionTaskInvocationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMaintenanceWindowExecutionTaskInvocationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetMaintenanceWindowExecutionTaskInvocation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetMaintenanceWindowExecutionTaskInvocation.</param>
        /// 
        /// <returns>Returns a  GetMaintenanceWindowExecutionTaskInvocationResult from SimpleSystemsManagement.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/GetMaintenanceWindowExecutionTaskInvocation">REST API Reference for GetMaintenanceWindowExecutionTaskInvocation Operation</seealso>
        public virtual GetMaintenanceWindowExecutionTaskInvocationResponse EndGetMaintenanceWindowExecutionTaskInvocation(IAsyncResult asyncResult)
        {
            return EndInvoke<GetMaintenanceWindowExecutionTaskInvocationResponse>(asyncResult);
        }

        #endregion
        
        #region  GetMaintenanceWindowTask

        /// <summary>
        /// Retrieves the details of a maintenance window task.
        /// 
        ///  <note> 
        /// <para>
        /// For maintenance window tasks without a specified target, you can't supply values for
        /// <code>--max-errors</code> and <code>--max-concurrency</code>. Instead, the system
        /// inserts a placeholder value of <code>1</code>, which may be reported in the response
        /// to this command. These values don't affect the running of your task and can be ignored.
        /// </para>
        ///  </note> 
        /// <para>
        /// To retrieve a list of tasks in a maintenance window, instead use the <a>DescribeMaintenanceWindowTasks</a>
        /// command.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMaintenanceWindowTask service method.</param>
        /// 
        /// <returns>The response from the GetMaintenanceWindowTask service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.DoesNotExistException">
        /// Error returned when the ID specified for a resource, such as a maintenance window
        /// or patch baseline, doesn't exist.
        /// 
        ///  
        /// <para>
        /// For information about resource quotas in Amazon Web Services Systems Manager, see
        /// <a href="https://docs.aws.amazon.com/general/latest/gr/ssm.html#limits_ssm">Systems
        /// Manager service quotas</a> in the <i>Amazon Web Services General Reference</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/GetMaintenanceWindowTask">REST API Reference for GetMaintenanceWindowTask Operation</seealso>
        public virtual GetMaintenanceWindowTaskResponse GetMaintenanceWindowTask(GetMaintenanceWindowTaskRequest request)
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
        /// <param name="request">Container for the necessary parameters to execute the GetMaintenanceWindowTask operation on AmazonSimpleSystemsManagementClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetMaintenanceWindowTask
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/GetMaintenanceWindowTask">REST API Reference for GetMaintenanceWindowTask Operation</seealso>
        public virtual IAsyncResult BeginGetMaintenanceWindowTask(GetMaintenanceWindowTaskRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetMaintenanceWindowTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMaintenanceWindowTaskResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetMaintenanceWindowTask operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetMaintenanceWindowTask.</param>
        /// 
        /// <returns>Returns a  GetMaintenanceWindowTaskResult from SimpleSystemsManagement.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/GetMaintenanceWindowTask">REST API Reference for GetMaintenanceWindowTask Operation</seealso>
        public virtual GetMaintenanceWindowTaskResponse EndGetMaintenanceWindowTask(IAsyncResult asyncResult)
        {
            return EndInvoke<GetMaintenanceWindowTaskResponse>(asyncResult);
        }

        #endregion
        
        #region  GetOpsItem

        /// <summary>
        /// Get information about an OpsItem by using the ID. You must have permission in Identity
        /// and Access Management (IAM) to view information about an OpsItem. For more information,
        /// see <a href="https://docs.aws.amazon.com/systems-manager/latest/userguide/OpsCenter-getting-started.html">Getting
        /// started with OpsCenter</a> in the <i>Amazon Web Services Systems Manager User Guide</i>.
        /// 
        ///  
        /// <para>
        /// Operations engineers and IT professionals use Amazon Web Services Systems Manager
        /// OpsCenter to view, investigate, and remediate operational issues impacting the performance
        /// and health of their Amazon Web Services resources. For more information, see <a href="https://docs.aws.amazon.com/systems-manager/latest/userguide/OpsCenter.html">OpsCenter</a>
        /// in the <i>Amazon Web Services Systems Manager User Guide</i>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetOpsItem service method.</param>
        /// 
        /// <returns>The response from the GetOpsItem service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.OpsItemAccessDeniedException">
        /// You don't have permission to view OpsItems in the specified account. Verify that your
        /// account is configured either as a Systems Manager delegated administrator or that
        /// you are logged into the Organizations management account.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.OpsItemNotFoundException">
        /// The specified OpsItem ID doesn't exist. Verify the ID and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/GetOpsItem">REST API Reference for GetOpsItem Operation</seealso>
        public virtual GetOpsItemResponse GetOpsItem(GetOpsItemRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetOpsItemRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetOpsItemResponseUnmarshaller.Instance;

            return Invoke<GetOpsItemResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetOpsItem operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetOpsItem operation on AmazonSimpleSystemsManagementClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetOpsItem
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/GetOpsItem">REST API Reference for GetOpsItem Operation</seealso>
        public virtual IAsyncResult BeginGetOpsItem(GetOpsItemRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetOpsItemRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetOpsItemResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetOpsItem operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetOpsItem.</param>
        /// 
        /// <returns>Returns a  GetOpsItemResult from SimpleSystemsManagement.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/GetOpsItem">REST API Reference for GetOpsItem Operation</seealso>
        public virtual GetOpsItemResponse EndGetOpsItem(IAsyncResult asyncResult)
        {
            return EndInvoke<GetOpsItemResponse>(asyncResult);
        }

        #endregion
        
        #region  GetOpsMetadata

        /// <summary>
        /// View operational metadata related to an application in Application Manager.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetOpsMetadata service method.</param>
        /// 
        /// <returns>The response from the GetOpsMetadata service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.OpsMetadataInvalidArgumentException">
        /// One of the arguments passed is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.OpsMetadataNotFoundException">
        /// The OpsMetadata object doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/GetOpsMetadata">REST API Reference for GetOpsMetadata Operation</seealso>
        public virtual GetOpsMetadataResponse GetOpsMetadata(GetOpsMetadataRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetOpsMetadataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetOpsMetadataResponseUnmarshaller.Instance;

            return Invoke<GetOpsMetadataResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetOpsMetadata operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetOpsMetadata operation on AmazonSimpleSystemsManagementClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetOpsMetadata
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/GetOpsMetadata">REST API Reference for GetOpsMetadata Operation</seealso>
        public virtual IAsyncResult BeginGetOpsMetadata(GetOpsMetadataRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetOpsMetadataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetOpsMetadataResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetOpsMetadata operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetOpsMetadata.</param>
        /// 
        /// <returns>Returns a  GetOpsMetadataResult from SimpleSystemsManagement.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/GetOpsMetadata">REST API Reference for GetOpsMetadata Operation</seealso>
        public virtual GetOpsMetadataResponse EndGetOpsMetadata(IAsyncResult asyncResult)
        {
            return EndInvoke<GetOpsMetadataResponse>(asyncResult);
        }

        #endregion
        
        #region  GetOpsSummary

        /// <summary>
        /// View a summary of operations metadata (OpsData) based on specified filters and aggregators.
        /// OpsData can include information about Amazon Web Services Systems Manager OpsCenter
        /// operational workitems (OpsItems) as well as information about any Amazon Web Services
        /// resource or service configured to report OpsData to Amazon Web Services Systems Manager
        /// Explorer.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetOpsSummary service method.</param>
        /// 
        /// <returns>The response from the GetOpsSummary service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidAggregatorException">
        /// The specified aggregator isn't valid for inventory groups. Verify that the aggregator
        /// uses a valid inventory type such as <code>AWS:Application</code> or <code>AWS:InstanceInformation</code>.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidFilterException">
        /// The filter name isn't valid. Verify the you entered the correct name and try again.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidNextTokenException">
        /// The specified token isn't valid.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidTypeNameException">
        /// The parameter type name isn't valid.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.ResourceDataSyncNotFoundException">
        /// The specified sync name wasn't found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/GetOpsSummary">REST API Reference for GetOpsSummary Operation</seealso>
        public virtual GetOpsSummaryResponse GetOpsSummary(GetOpsSummaryRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetOpsSummaryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetOpsSummaryResponseUnmarshaller.Instance;

            return Invoke<GetOpsSummaryResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetOpsSummary operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetOpsSummary operation on AmazonSimpleSystemsManagementClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetOpsSummary
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/GetOpsSummary">REST API Reference for GetOpsSummary Operation</seealso>
        public virtual IAsyncResult BeginGetOpsSummary(GetOpsSummaryRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetOpsSummaryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetOpsSummaryResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetOpsSummary operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetOpsSummary.</param>
        /// 
        /// <returns>Returns a  GetOpsSummaryResult from SimpleSystemsManagement.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/GetOpsSummary">REST API Reference for GetOpsSummary Operation</seealso>
        public virtual GetOpsSummaryResponse EndGetOpsSummary(IAsyncResult asyncResult)
        {
            return EndInvoke<GetOpsSummaryResponse>(asyncResult);
        }

        #endregion
        
        #region  GetParameter

        /// <summary>
        /// Get information about a single parameter by specifying the parameter name.
        /// 
        ///  <note> 
        /// <para>
        /// To get information about more than one parameter at a time, use the <a>GetParameters</a>
        /// operation.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetParameter service method.</param>
        /// 
        /// <returns>The response from the GetParameter service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidKeyIdException">
        /// The query key ID isn't valid.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.ParameterNotFoundException">
        /// The parameter couldn't be found. Verify the name and try again.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.ParameterVersionNotFoundException">
        /// The specified parameter version wasn't found. Verify the parameter name and version,
        /// and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/GetParameter">REST API Reference for GetParameter Operation</seealso>
        public virtual GetParameterResponse GetParameter(GetParameterRequest request)
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
        /// <param name="request">Container for the necessary parameters to execute the GetParameter operation on AmazonSimpleSystemsManagementClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetParameter
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/GetParameter">REST API Reference for GetParameter Operation</seealso>
        public virtual IAsyncResult BeginGetParameter(GetParameterRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetParameterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetParameterResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetParameter operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetParameter.</param>
        /// 
        /// <returns>Returns a  GetParameterResult from SimpleSystemsManagement.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/GetParameter">REST API Reference for GetParameter Operation</seealso>
        public virtual GetParameterResponse EndGetParameter(IAsyncResult asyncResult)
        {
            return EndInvoke<GetParameterResponse>(asyncResult);
        }

        #endregion
        
        #region  GetParameterHistory

        /// <summary>
        /// Retrieves the history of all changes to a parameter.
        /// 
        ///  <important> 
        /// <para>
        /// If you change the KMS key alias for the KMS key used to encrypt a parameter, then
        /// you must also update the key alias the parameter uses to reference KMS. Otherwise,
        /// <code>GetParameterHistory</code> retrieves whatever the original key alias was referencing.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetParameterHistory service method.</param>
        /// 
        /// <returns>The response from the GetParameterHistory service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidKeyIdException">
        /// The query key ID isn't valid.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidNextTokenException">
        /// The specified token isn't valid.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.ParameterNotFoundException">
        /// The parameter couldn't be found. Verify the name and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/GetParameterHistory">REST API Reference for GetParameterHistory Operation</seealso>
        public virtual GetParameterHistoryResponse GetParameterHistory(GetParameterHistoryRequest request)
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
        /// <param name="request">Container for the necessary parameters to execute the GetParameterHistory operation on AmazonSimpleSystemsManagementClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetParameterHistory
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/GetParameterHistory">REST API Reference for GetParameterHistory Operation</seealso>
        public virtual IAsyncResult BeginGetParameterHistory(GetParameterHistoryRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetParameterHistoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetParameterHistoryResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetParameterHistory operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetParameterHistory.</param>
        /// 
        /// <returns>Returns a  GetParameterHistoryResult from SimpleSystemsManagement.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/GetParameterHistory">REST API Reference for GetParameterHistory Operation</seealso>
        public virtual GetParameterHistoryResponse EndGetParameterHistory(IAsyncResult asyncResult)
        {
            return EndInvoke<GetParameterHistoryResponse>(asyncResult);
        }

        #endregion
        
        #region  GetParameters

        /// <summary>
        /// Get information about one or more parameters by specifying multiple parameter names.
        /// 
        ///  <note> 
        /// <para>
        /// To get information about a single parameter, you can use the <a>GetParameter</a> operation
        /// instead.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetParameters service method.</param>
        /// 
        /// <returns>The response from the GetParameters service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidKeyIdException">
        /// The query key ID isn't valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/GetParameters">REST API Reference for GetParameters Operation</seealso>
        public virtual GetParametersResponse GetParameters(GetParametersRequest request)
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
        /// <param name="request">Container for the necessary parameters to execute the GetParameters operation on AmazonSimpleSystemsManagementClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetParameters
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/GetParameters">REST API Reference for GetParameters Operation</seealso>
        public virtual IAsyncResult BeginGetParameters(GetParametersRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetParametersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetParametersResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetParameters operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetParameters.</param>
        /// 
        /// <returns>Returns a  GetParametersResult from SimpleSystemsManagement.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/GetParameters">REST API Reference for GetParameters Operation</seealso>
        public virtual GetParametersResponse EndGetParameters(IAsyncResult asyncResult)
        {
            return EndInvoke<GetParametersResponse>(asyncResult);
        }

        #endregion
        
        #region  GetParametersByPath

        /// <summary>
        /// Retrieve information about one or more parameters in a specific hierarchy. 
        /// 
        ///  
        /// <para>
        /// Request results are returned on a best-effort basis. If you specify <code>MaxResults</code>
        /// in the request, the response includes information up to the limit specified. The number
        /// of items returned, however, can be between zero and the value of <code>MaxResults</code>.
        /// If the service reaches an internal limit while processing the results, it stops the
        /// operation and returns the matching values up to that point and a <code>NextToken</code>.
        /// You can specify the <code>NextToken</code> in a subsequent call to get the next set
        /// of results.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetParametersByPath service method.</param>
        /// 
        /// <returns>The response from the GetParametersByPath service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidFilterKeyException">
        /// The specified key isn't valid.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidFilterOptionException">
        /// The specified filter option isn't valid. Valid options are Equals and BeginsWith.
        /// For Path filter, valid options are Recursive and OneLevel.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidFilterValueException">
        /// The filter value isn't valid. Verify the value and try again.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidKeyIdException">
        /// The query key ID isn't valid.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidNextTokenException">
        /// The specified token isn't valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/GetParametersByPath">REST API Reference for GetParametersByPath Operation</seealso>
        public virtual GetParametersByPathResponse GetParametersByPath(GetParametersByPathRequest request)
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
        /// <param name="request">Container for the necessary parameters to execute the GetParametersByPath operation on AmazonSimpleSystemsManagementClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetParametersByPath
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/GetParametersByPath">REST API Reference for GetParametersByPath Operation</seealso>
        public virtual IAsyncResult BeginGetParametersByPath(GetParametersByPathRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetParametersByPathRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetParametersByPathResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetParametersByPath operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetParametersByPath.</param>
        /// 
        /// <returns>Returns a  GetParametersByPathResult from SimpleSystemsManagement.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/GetParametersByPath">REST API Reference for GetParametersByPath Operation</seealso>
        public virtual GetParametersByPathResponse EndGetParametersByPath(IAsyncResult asyncResult)
        {
            return EndInvoke<GetParametersByPathResponse>(asyncResult);
        }

        #endregion
        
        #region  GetPatchBaseline

        /// <summary>
        /// Retrieves information about a patch baseline.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPatchBaseline service method.</param>
        /// 
        /// <returns>The response from the GetPatchBaseline service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.DoesNotExistException">
        /// Error returned when the ID specified for a resource, such as a maintenance window
        /// or patch baseline, doesn't exist.
        /// 
        ///  
        /// <para>
        /// For information about resource quotas in Amazon Web Services Systems Manager, see
        /// <a href="https://docs.aws.amazon.com/general/latest/gr/ssm.html#limits_ssm">Systems
        /// Manager service quotas</a> in the <i>Amazon Web Services General Reference</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidResourceIdException">
        /// The resource ID isn't valid. Verify that you entered the correct ID and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/GetPatchBaseline">REST API Reference for GetPatchBaseline Operation</seealso>
        public virtual GetPatchBaselineResponse GetPatchBaseline(GetPatchBaselineRequest request)
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
        /// <param name="request">Container for the necessary parameters to execute the GetPatchBaseline operation on AmazonSimpleSystemsManagementClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetPatchBaseline
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/GetPatchBaseline">REST API Reference for GetPatchBaseline Operation</seealso>
        public virtual IAsyncResult BeginGetPatchBaseline(GetPatchBaselineRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetPatchBaselineRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPatchBaselineResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetPatchBaseline operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetPatchBaseline.</param>
        /// 
        /// <returns>Returns a  GetPatchBaselineResult from SimpleSystemsManagement.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/GetPatchBaseline">REST API Reference for GetPatchBaseline Operation</seealso>
        public virtual GetPatchBaselineResponse EndGetPatchBaseline(IAsyncResult asyncResult)
        {
            return EndInvoke<GetPatchBaselineResponse>(asyncResult);
        }

        #endregion
        
        #region  GetPatchBaselineForPatchGroup

        /// <summary>
        /// Retrieves the patch baseline that should be used for the specified patch group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPatchBaselineForPatchGroup service method.</param>
        /// 
        /// <returns>The response from the GetPatchBaselineForPatchGroup service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/GetPatchBaselineForPatchGroup">REST API Reference for GetPatchBaselineForPatchGroup Operation</seealso>
        public virtual GetPatchBaselineForPatchGroupResponse GetPatchBaselineForPatchGroup(GetPatchBaselineForPatchGroupRequest request)
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
        /// <param name="request">Container for the necessary parameters to execute the GetPatchBaselineForPatchGroup operation on AmazonSimpleSystemsManagementClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetPatchBaselineForPatchGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/GetPatchBaselineForPatchGroup">REST API Reference for GetPatchBaselineForPatchGroup Operation</seealso>
        public virtual IAsyncResult BeginGetPatchBaselineForPatchGroup(GetPatchBaselineForPatchGroupRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetPatchBaselineForPatchGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPatchBaselineForPatchGroupResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetPatchBaselineForPatchGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetPatchBaselineForPatchGroup.</param>
        /// 
        /// <returns>Returns a  GetPatchBaselineForPatchGroupResult from SimpleSystemsManagement.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/GetPatchBaselineForPatchGroup">REST API Reference for GetPatchBaselineForPatchGroup Operation</seealso>
        public virtual GetPatchBaselineForPatchGroupResponse EndGetPatchBaselineForPatchGroup(IAsyncResult asyncResult)
        {
            return EndInvoke<GetPatchBaselineForPatchGroupResponse>(asyncResult);
        }

        #endregion
        
        #region  GetResourcePolicies

        /// <summary>
        /// Returns an array of the <code>Policy</code> object.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetResourcePolicies service method.</param>
        /// 
        /// <returns>The response from the GetResourcePolicies service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.ResourcePolicyInvalidParameterException">
        /// One or more parameters specified for the call aren't valid. Verify the parameters
        /// and their values and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/GetResourcePolicies">REST API Reference for GetResourcePolicies Operation</seealso>
        public virtual GetResourcePoliciesResponse GetResourcePolicies(GetResourcePoliciesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetResourcePoliciesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetResourcePoliciesResponseUnmarshaller.Instance;

            return Invoke<GetResourcePoliciesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetResourcePolicies operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetResourcePolicies operation on AmazonSimpleSystemsManagementClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetResourcePolicies
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/GetResourcePolicies">REST API Reference for GetResourcePolicies Operation</seealso>
        public virtual IAsyncResult BeginGetResourcePolicies(GetResourcePoliciesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetResourcePoliciesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetResourcePoliciesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetResourcePolicies operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetResourcePolicies.</param>
        /// 
        /// <returns>Returns a  GetResourcePoliciesResult from SimpleSystemsManagement.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/GetResourcePolicies">REST API Reference for GetResourcePolicies Operation</seealso>
        public virtual GetResourcePoliciesResponse EndGetResourcePolicies(IAsyncResult asyncResult)
        {
            return EndInvoke<GetResourcePoliciesResponse>(asyncResult);
        }

        #endregion
        
        #region  GetServiceSetting

        /// <summary>
        /// <code>ServiceSetting</code> is an account-level setting for an Amazon Web Services
        /// service. This setting defines how a user interacts with or uses a service or a feature
        /// of a service. For example, if an Amazon Web Services service charges money to the
        /// account based on feature or service usage, then the Amazon Web Services service team
        /// might create a default setting of <code>false</code>. This means the user can't use
        /// this feature unless they change the setting to <code>true</code> and intentionally
        /// opt in for a paid feature.
        /// 
        ///  
        /// <para>
        /// Services map a <code>SettingId</code> object to a setting value. Amazon Web Services
        /// services teams define the default value for a <code>SettingId</code>. You can't create
        /// a new <code>SettingId</code>, but you can overwrite the default value if you have
        /// the <code>ssm:UpdateServiceSetting</code> permission for the setting. Use the <a>UpdateServiceSetting</a>
        /// API operation to change the default setting. Or use the <a>ResetServiceSetting</a>
        /// to change the value back to the original value defined by the Amazon Web Services
        /// service team.
        /// </para>
        ///  
        /// <para>
        /// Query the current service setting for the Amazon Web Services account. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetServiceSetting service method.</param>
        /// 
        /// <returns>The response from the GetServiceSetting service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.ServiceSettingNotFoundException">
        /// The specified service setting wasn't found. Either the service name or the setting
        /// hasn't been provisioned by the Amazon Web Services service team.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/GetServiceSetting">REST API Reference for GetServiceSetting Operation</seealso>
        public virtual GetServiceSettingResponse GetServiceSetting(GetServiceSettingRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetServiceSettingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetServiceSettingResponseUnmarshaller.Instance;

            return Invoke<GetServiceSettingResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetServiceSetting operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetServiceSetting operation on AmazonSimpleSystemsManagementClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetServiceSetting
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/GetServiceSetting">REST API Reference for GetServiceSetting Operation</seealso>
        public virtual IAsyncResult BeginGetServiceSetting(GetServiceSettingRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetServiceSettingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetServiceSettingResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetServiceSetting operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetServiceSetting.</param>
        /// 
        /// <returns>Returns a  GetServiceSettingResult from SimpleSystemsManagement.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/GetServiceSetting">REST API Reference for GetServiceSetting Operation</seealso>
        public virtual GetServiceSettingResponse EndGetServiceSetting(IAsyncResult asyncResult)
        {
            return EndInvoke<GetServiceSettingResponse>(asyncResult);
        }

        #endregion
        
        #region  LabelParameterVersion

        /// <summary>
        /// A parameter label is a user-defined alias to help you manage different versions of
        /// a parameter. When you modify a parameter, Amazon Web Services Systems Manager automatically
        /// saves a new version and increments the version number by one. A label can help you
        /// remember the purpose of a parameter when there are multiple versions. 
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
        /// If you no longer want to use a parameter label, then you can either delete it or move
        /// it to a different version of a parameter.
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
        /// Labels can't begin with a number, "<code>aws</code>" or "<code>ssm</code>" (not case
        /// sensitive). If a label fails to meet these requirements, then the label isn't associated
        /// with a parameter and the system displays it in the list of InvalidLabels.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the LabelParameterVersion service method.</param>
        /// 
        /// <returns>The response from the LabelParameterVersion service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.ParameterNotFoundException">
        /// The parameter couldn't be found. Verify the name and try again.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.ParameterVersionLabelLimitExceededException">
        /// A parameter version can have a maximum of ten labels.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.ParameterVersionNotFoundException">
        /// The specified parameter version wasn't found. Verify the parameter name and version,
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.TooManyUpdatesException">
        /// There are concurrent updates for a resource that supports one update at a time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/LabelParameterVersion">REST API Reference for LabelParameterVersion Operation</seealso>
        public virtual LabelParameterVersionResponse LabelParameterVersion(LabelParameterVersionRequest request)
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
        /// <param name="request">Container for the necessary parameters to execute the LabelParameterVersion operation on AmazonSimpleSystemsManagementClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndLabelParameterVersion
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/LabelParameterVersion">REST API Reference for LabelParameterVersion Operation</seealso>
        public virtual IAsyncResult BeginLabelParameterVersion(LabelParameterVersionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = LabelParameterVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = LabelParameterVersionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  LabelParameterVersion operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginLabelParameterVersion.</param>
        /// 
        /// <returns>Returns a  LabelParameterVersionResult from SimpleSystemsManagement.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/LabelParameterVersion">REST API Reference for LabelParameterVersion Operation</seealso>
        public virtual LabelParameterVersionResponse EndLabelParameterVersion(IAsyncResult asyncResult)
        {
            return EndInvoke<LabelParameterVersionResponse>(asyncResult);
        }

        #endregion
        
        #region  ListAssociations

        /// <summary>
        /// Returns all State Manager associations in the current Amazon Web Services account
        /// and Amazon Web Services Region. You can limit the results to a specific State Manager
        /// association document or managed node by specifying a filter. State Manager is a capability
        /// of Amazon Web Services Systems Manager.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAssociations service method.</param>
        /// 
        /// <returns>The response from the ListAssociations service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidNextTokenException">
        /// The specified token isn't valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/ListAssociations">REST API Reference for ListAssociations Operation</seealso>
        public virtual ListAssociationsResponse ListAssociations(ListAssociationsRequest request)
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
        /// <param name="request">Container for the necessary parameters to execute the ListAssociations operation on AmazonSimpleSystemsManagementClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAssociations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/ListAssociations">REST API Reference for ListAssociations Operation</seealso>
        public virtual IAsyncResult BeginListAssociations(ListAssociationsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAssociationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAssociationsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListAssociations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAssociations.</param>
        /// 
        /// <returns>Returns a  ListAssociationsResult from SimpleSystemsManagement.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/ListAssociations">REST API Reference for ListAssociations Operation</seealso>
        public virtual ListAssociationsResponse EndListAssociations(IAsyncResult asyncResult)
        {
            return EndInvoke<ListAssociationsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListAssociationVersions

        /// <summary>
        /// Retrieves all versions of an association for a specific association ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAssociationVersions service method.</param>
        /// 
        /// <returns>The response from the ListAssociationVersions service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.AssociationDoesNotExistException">
        /// The specified association doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidNextTokenException">
        /// The specified token isn't valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/ListAssociationVersions">REST API Reference for ListAssociationVersions Operation</seealso>
        public virtual ListAssociationVersionsResponse ListAssociationVersions(ListAssociationVersionsRequest request)
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
        /// <param name="request">Container for the necessary parameters to execute the ListAssociationVersions operation on AmazonSimpleSystemsManagementClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAssociationVersions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/ListAssociationVersions">REST API Reference for ListAssociationVersions Operation</seealso>
        public virtual IAsyncResult BeginListAssociationVersions(ListAssociationVersionsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAssociationVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAssociationVersionsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListAssociationVersions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAssociationVersions.</param>
        /// 
        /// <returns>Returns a  ListAssociationVersionsResult from SimpleSystemsManagement.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/ListAssociationVersions">REST API Reference for ListAssociationVersions Operation</seealso>
        public virtual ListAssociationVersionsResponse EndListAssociationVersions(IAsyncResult asyncResult)
        {
            return EndInvoke<ListAssociationVersionsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListCommandInvocations

        /// <summary>
        /// An invocation is copy of a command sent to a specific managed node. A command can
        /// apply to one or more managed nodes. A command invocation applies to one managed node.
        /// For example, if a user runs <code>SendCommand</code> against three managed nodes,
        /// then a command invocation is created for each requested managed node ID. <code>ListCommandInvocations</code>
        /// provide status about command execution.
        /// </summary>
        /// 
        /// <returns>The response from the ListCommandInvocations service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidCommandIdException">
        /// The specified command ID isn't valid. Verify the ID and try again.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidFilterKeyException">
        /// The specified key isn't valid.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidInstanceIdException">
        /// The following problems can cause this exception:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You don't have permission to access the managed node.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Amazon Web Services Systems Manager Agent(SSM Agent) isn't running. Verify that SSM
        /// Agent is running.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// SSM Agent isn't registered with the SSM endpoint. Try reinstalling SSM Agent.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The managed node isn't in valid state. Valid states are: <code>Running</code>, <code>Pending</code>,
        /// <code>Stopped</code>, and <code>Stopping</code>. Invalid states are: <code>Shutting-down</code>
        /// and <code>Terminated</code>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidNextTokenException">
        /// The specified token isn't valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/ListCommandInvocations">REST API Reference for ListCommandInvocations Operation</seealso>
        public virtual ListCommandInvocationsResponse ListCommandInvocations()
        {
            return ListCommandInvocations(new ListCommandInvocationsRequest());
        }

        /// <summary>
        /// An invocation is copy of a command sent to a specific managed node. A command can
        /// apply to one or more managed nodes. A command invocation applies to one managed node.
        /// For example, if a user runs <code>SendCommand</code> against three managed nodes,
        /// then a command invocation is created for each requested managed node ID. <code>ListCommandInvocations</code>
        /// provide status about command execution.
        /// </summary>
        /// <param name="commandId">(Optional) The invocations for a specific command ID.</param>
        /// 
        /// <returns>The response from the ListCommandInvocations service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidCommandIdException">
        /// The specified command ID isn't valid. Verify the ID and try again.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidFilterKeyException">
        /// The specified key isn't valid.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidInstanceIdException">
        /// The following problems can cause this exception:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You don't have permission to access the managed node.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Amazon Web Services Systems Manager Agent(SSM Agent) isn't running. Verify that SSM
        /// Agent is running.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// SSM Agent isn't registered with the SSM endpoint. Try reinstalling SSM Agent.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The managed node isn't in valid state. Valid states are: <code>Running</code>, <code>Pending</code>,
        /// <code>Stopped</code>, and <code>Stopping</code>. Invalid states are: <code>Shutting-down</code>
        /// and <code>Terminated</code>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidNextTokenException">
        /// The specified token isn't valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/ListCommandInvocations">REST API Reference for ListCommandInvocations Operation</seealso>
        public virtual ListCommandInvocationsResponse ListCommandInvocations(string commandId)
        {
            var request = new ListCommandInvocationsRequest();
            request.CommandId = commandId;
            return ListCommandInvocations(request);
        }


        /// <summary>
        /// An invocation is copy of a command sent to a specific managed node. A command can
        /// apply to one or more managed nodes. A command invocation applies to one managed node.
        /// For example, if a user runs <code>SendCommand</code> against three managed nodes,
        /// then a command invocation is created for each requested managed node ID. <code>ListCommandInvocations</code>
        /// provide status about command execution.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCommandInvocations service method.</param>
        /// 
        /// <returns>The response from the ListCommandInvocations service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidCommandIdException">
        /// The specified command ID isn't valid. Verify the ID and try again.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidFilterKeyException">
        /// The specified key isn't valid.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidInstanceIdException">
        /// The following problems can cause this exception:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You don't have permission to access the managed node.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Amazon Web Services Systems Manager Agent(SSM Agent) isn't running. Verify that SSM
        /// Agent is running.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// SSM Agent isn't registered with the SSM endpoint. Try reinstalling SSM Agent.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The managed node isn't in valid state. Valid states are: <code>Running</code>, <code>Pending</code>,
        /// <code>Stopped</code>, and <code>Stopping</code>. Invalid states are: <code>Shutting-down</code>
        /// and <code>Terminated</code>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidNextTokenException">
        /// The specified token isn't valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/ListCommandInvocations">REST API Reference for ListCommandInvocations Operation</seealso>
        public virtual ListCommandInvocationsResponse ListCommandInvocations(ListCommandInvocationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListCommandInvocationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCommandInvocationsResponseUnmarshaller.Instance;

            return Invoke<ListCommandInvocationsResponse>(request, options);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/ListCommandInvocations">REST API Reference for ListCommandInvocations Operation</seealso>
        public virtual IAsyncResult BeginListCommandInvocations(ListCommandInvocationsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListCommandInvocationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCommandInvocationsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListCommandInvocations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListCommandInvocations.</param>
        /// 
        /// <returns>Returns a  ListCommandInvocationsResult from SimpleSystemsManagement.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/ListCommandInvocations">REST API Reference for ListCommandInvocations Operation</seealso>
        public virtual ListCommandInvocationsResponse EndListCommandInvocations(IAsyncResult asyncResult)
        {
            return EndInvoke<ListCommandInvocationsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListCommands

        /// <summary>
        /// Lists the commands requested by users of the Amazon Web Services account.
        /// </summary>
        /// 
        /// <returns>The response from the ListCommands service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidCommandIdException">
        /// The specified command ID isn't valid. Verify the ID and try again.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidFilterKeyException">
        /// The specified key isn't valid.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidInstanceIdException">
        /// The following problems can cause this exception:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You don't have permission to access the managed node.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Amazon Web Services Systems Manager Agent(SSM Agent) isn't running. Verify that SSM
        /// Agent is running.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// SSM Agent isn't registered with the SSM endpoint. Try reinstalling SSM Agent.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The managed node isn't in valid state. Valid states are: <code>Running</code>, <code>Pending</code>,
        /// <code>Stopped</code>, and <code>Stopping</code>. Invalid states are: <code>Shutting-down</code>
        /// and <code>Terminated</code>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidNextTokenException">
        /// The specified token isn't valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/ListCommands">REST API Reference for ListCommands Operation</seealso>
        public virtual ListCommandsResponse ListCommands()
        {
            return ListCommands(new ListCommandsRequest());
        }

        /// <summary>
        /// Lists the commands requested by users of the Amazon Web Services account.
        /// </summary>
        /// <param name="commandId">(Optional) If provided, lists only the specified command.</param>
        /// 
        /// <returns>The response from the ListCommands service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidCommandIdException">
        /// The specified command ID isn't valid. Verify the ID and try again.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidFilterKeyException">
        /// The specified key isn't valid.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidInstanceIdException">
        /// The following problems can cause this exception:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You don't have permission to access the managed node.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Amazon Web Services Systems Manager Agent(SSM Agent) isn't running. Verify that SSM
        /// Agent is running.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// SSM Agent isn't registered with the SSM endpoint. Try reinstalling SSM Agent.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The managed node isn't in valid state. Valid states are: <code>Running</code>, <code>Pending</code>,
        /// <code>Stopped</code>, and <code>Stopping</code>. Invalid states are: <code>Shutting-down</code>
        /// and <code>Terminated</code>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidNextTokenException">
        /// The specified token isn't valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/ListCommands">REST API Reference for ListCommands Operation</seealso>
        public virtual ListCommandsResponse ListCommands(string commandId)
        {
            var request = new ListCommandsRequest();
            request.CommandId = commandId;
            return ListCommands(request);
        }


        /// <summary>
        /// Lists the commands requested by users of the Amazon Web Services account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCommands service method.</param>
        /// 
        /// <returns>The response from the ListCommands service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidCommandIdException">
        /// The specified command ID isn't valid. Verify the ID and try again.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidFilterKeyException">
        /// The specified key isn't valid.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidInstanceIdException">
        /// The following problems can cause this exception:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You don't have permission to access the managed node.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Amazon Web Services Systems Manager Agent(SSM Agent) isn't running. Verify that SSM
        /// Agent is running.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// SSM Agent isn't registered with the SSM endpoint. Try reinstalling SSM Agent.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The managed node isn't in valid state. Valid states are: <code>Running</code>, <code>Pending</code>,
        /// <code>Stopped</code>, and <code>Stopping</code>. Invalid states are: <code>Shutting-down</code>
        /// and <code>Terminated</code>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidNextTokenException">
        /// The specified token isn't valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/ListCommands">REST API Reference for ListCommands Operation</seealso>
        public virtual ListCommandsResponse ListCommands(ListCommandsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListCommandsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCommandsResponseUnmarshaller.Instance;

            return Invoke<ListCommandsResponse>(request, options);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/ListCommands">REST API Reference for ListCommands Operation</seealso>
        public virtual IAsyncResult BeginListCommands(ListCommandsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListCommandsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCommandsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListCommands operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListCommands.</param>
        /// 
        /// <returns>Returns a  ListCommandsResult from SimpleSystemsManagement.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/ListCommands">REST API Reference for ListCommands Operation</seealso>
        public virtual ListCommandsResponse EndListCommands(IAsyncResult asyncResult)
        {
            return EndInvoke<ListCommandsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListComplianceItems

        /// <summary>
        /// For a specified resource ID, this API operation returns a list of compliance statuses
        /// for different resource types. Currently, you can only specify one resource ID per
        /// call. List results depend on the criteria specified in the filter.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListComplianceItems service method.</param>
        /// 
        /// <returns>The response from the ListComplianceItems service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidFilterException">
        /// The filter name isn't valid. Verify the you entered the correct name and try again.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidNextTokenException">
        /// The specified token isn't valid.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidResourceIdException">
        /// The resource ID isn't valid. Verify that you entered the correct ID and try again.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidResourceTypeException">
        /// The resource type isn't valid. For example, if you are attempting to tag an EC2 instance,
        /// the instance must be a registered managed node.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/ListComplianceItems">REST API Reference for ListComplianceItems Operation</seealso>
        public virtual ListComplianceItemsResponse ListComplianceItems(ListComplianceItemsRequest request)
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
        /// <param name="request">Container for the necessary parameters to execute the ListComplianceItems operation on AmazonSimpleSystemsManagementClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListComplianceItems
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/ListComplianceItems">REST API Reference for ListComplianceItems Operation</seealso>
        public virtual IAsyncResult BeginListComplianceItems(ListComplianceItemsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListComplianceItemsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListComplianceItemsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListComplianceItems operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListComplianceItems.</param>
        /// 
        /// <returns>Returns a  ListComplianceItemsResult from SimpleSystemsManagement.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/ListComplianceItems">REST API Reference for ListComplianceItems Operation</seealso>
        public virtual ListComplianceItemsResponse EndListComplianceItems(IAsyncResult asyncResult)
        {
            return EndInvoke<ListComplianceItemsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListComplianceSummaries

        /// <summary>
        /// Returns a summary count of compliant and non-compliant resources for a compliance
        /// type. For example, this call can return State Manager associations, patches, or custom
        /// compliance types according to the filter criteria that you specify.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListComplianceSummaries service method.</param>
        /// 
        /// <returns>The response from the ListComplianceSummaries service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidFilterException">
        /// The filter name isn't valid. Verify the you entered the correct name and try again.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidNextTokenException">
        /// The specified token isn't valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/ListComplianceSummaries">REST API Reference for ListComplianceSummaries Operation</seealso>
        public virtual ListComplianceSummariesResponse ListComplianceSummaries(ListComplianceSummariesRequest request)
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
        /// <param name="request">Container for the necessary parameters to execute the ListComplianceSummaries operation on AmazonSimpleSystemsManagementClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListComplianceSummaries
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/ListComplianceSummaries">REST API Reference for ListComplianceSummaries Operation</seealso>
        public virtual IAsyncResult BeginListComplianceSummaries(ListComplianceSummariesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListComplianceSummariesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListComplianceSummariesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListComplianceSummaries operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListComplianceSummaries.</param>
        /// 
        /// <returns>Returns a  ListComplianceSummariesResult from SimpleSystemsManagement.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/ListComplianceSummaries">REST API Reference for ListComplianceSummaries Operation</seealso>
        public virtual ListComplianceSummariesResponse EndListComplianceSummaries(IAsyncResult asyncResult)
        {
            return EndInvoke<ListComplianceSummariesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListDocumentMetadataHistory

        /// <summary>
        /// Information about approval reviews for a version of a change template in Change Manager.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDocumentMetadataHistory service method.</param>
        /// 
        /// <returns>The response from the ListDocumentMetadataHistory service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidDocumentException">
        /// The specified SSM document doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidDocumentVersionException">
        /// The document version isn't valid or doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidNextTokenException">
        /// The specified token isn't valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/ListDocumentMetadataHistory">REST API Reference for ListDocumentMetadataHistory Operation</seealso>
        public virtual ListDocumentMetadataHistoryResponse ListDocumentMetadataHistory(ListDocumentMetadataHistoryRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDocumentMetadataHistoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDocumentMetadataHistoryResponseUnmarshaller.Instance;

            return Invoke<ListDocumentMetadataHistoryResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListDocumentMetadataHistory operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDocumentMetadataHistory operation on AmazonSimpleSystemsManagementClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListDocumentMetadataHistory
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/ListDocumentMetadataHistory">REST API Reference for ListDocumentMetadataHistory Operation</seealso>
        public virtual IAsyncResult BeginListDocumentMetadataHistory(ListDocumentMetadataHistoryRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDocumentMetadataHistoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDocumentMetadataHistoryResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListDocumentMetadataHistory operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListDocumentMetadataHistory.</param>
        /// 
        /// <returns>Returns a  ListDocumentMetadataHistoryResult from SimpleSystemsManagement.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/ListDocumentMetadataHistory">REST API Reference for ListDocumentMetadataHistory Operation</seealso>
        public virtual ListDocumentMetadataHistoryResponse EndListDocumentMetadataHistory(IAsyncResult asyncResult)
        {
            return EndInvoke<ListDocumentMetadataHistoryResponse>(asyncResult);
        }

        #endregion
        
        #region  ListDocuments

        /// <summary>
        /// Returns all Systems Manager (SSM) documents in the current Amazon Web Services account
        /// and Amazon Web Services Region. You can limit the results of this request by using
        /// a filter.
        /// </summary>
        /// 
        /// <returns>The response from the ListDocuments service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidFilterKeyException">
        /// The specified key isn't valid.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidNextTokenException">
        /// The specified token isn't valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/ListDocuments">REST API Reference for ListDocuments Operation</seealso>
        public virtual ListDocumentsResponse ListDocuments()
        {
            return ListDocuments(new ListDocumentsRequest());
        }

        /// <summary>
        /// Returns all Systems Manager (SSM) documents in the current Amazon Web Services account
        /// and Amazon Web Services Region. You can limit the results of this request by using
        /// a filter.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDocuments service method.</param>
        /// 
        /// <returns>The response from the ListDocuments service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidFilterKeyException">
        /// The specified key isn't valid.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidNextTokenException">
        /// The specified token isn't valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/ListDocuments">REST API Reference for ListDocuments Operation</seealso>
        public virtual ListDocumentsResponse ListDocuments(ListDocumentsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDocumentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDocumentsResponseUnmarshaller.Instance;

            return Invoke<ListDocumentsResponse>(request, options);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/ListDocuments">REST API Reference for ListDocuments Operation</seealso>
        public virtual IAsyncResult BeginListDocuments(ListDocumentsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDocumentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDocumentsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListDocuments operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListDocuments.</param>
        /// 
        /// <returns>Returns a  ListDocumentsResult from SimpleSystemsManagement.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/ListDocuments">REST API Reference for ListDocuments Operation</seealso>
        public virtual ListDocumentsResponse EndListDocuments(IAsyncResult asyncResult)
        {
            return EndInvoke<ListDocumentsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListDocumentVersions

        /// <summary>
        /// List all versions for a document.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDocumentVersions service method.</param>
        /// 
        /// <returns>The response from the ListDocumentVersions service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidDocumentException">
        /// The specified SSM document doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidNextTokenException">
        /// The specified token isn't valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/ListDocumentVersions">REST API Reference for ListDocumentVersions Operation</seealso>
        public virtual ListDocumentVersionsResponse ListDocumentVersions(ListDocumentVersionsRequest request)
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
        /// <param name="request">Container for the necessary parameters to execute the ListDocumentVersions operation on AmazonSimpleSystemsManagementClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListDocumentVersions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/ListDocumentVersions">REST API Reference for ListDocumentVersions Operation</seealso>
        public virtual IAsyncResult BeginListDocumentVersions(ListDocumentVersionsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDocumentVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDocumentVersionsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListDocumentVersions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListDocumentVersions.</param>
        /// 
        /// <returns>Returns a  ListDocumentVersionsResult from SimpleSystemsManagement.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/ListDocumentVersions">REST API Reference for ListDocumentVersions Operation</seealso>
        public virtual ListDocumentVersionsResponse EndListDocumentVersions(IAsyncResult asyncResult)
        {
            return EndInvoke<ListDocumentVersionsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListInventoryEntries

        /// <summary>
        /// A list of inventory items returned by the request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListInventoryEntries service method.</param>
        /// 
        /// <returns>The response from the ListInventoryEntries service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidFilterException">
        /// The filter name isn't valid. Verify the you entered the correct name and try again.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidInstanceIdException">
        /// The following problems can cause this exception:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You don't have permission to access the managed node.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Amazon Web Services Systems Manager Agent(SSM Agent) isn't running. Verify that SSM
        /// Agent is running.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// SSM Agent isn't registered with the SSM endpoint. Try reinstalling SSM Agent.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The managed node isn't in valid state. Valid states are: <code>Running</code>, <code>Pending</code>,
        /// <code>Stopped</code>, and <code>Stopping</code>. Invalid states are: <code>Shutting-down</code>
        /// and <code>Terminated</code>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidNextTokenException">
        /// The specified token isn't valid.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidTypeNameException">
        /// The parameter type name isn't valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/ListInventoryEntries">REST API Reference for ListInventoryEntries Operation</seealso>
        public virtual ListInventoryEntriesResponse ListInventoryEntries(ListInventoryEntriesRequest request)
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
        /// <param name="request">Container for the necessary parameters to execute the ListInventoryEntries operation on AmazonSimpleSystemsManagementClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListInventoryEntries
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/ListInventoryEntries">REST API Reference for ListInventoryEntries Operation</seealso>
        public virtual IAsyncResult BeginListInventoryEntries(ListInventoryEntriesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListInventoryEntriesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListInventoryEntriesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListInventoryEntries operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListInventoryEntries.</param>
        /// 
        /// <returns>Returns a  ListInventoryEntriesResult from SimpleSystemsManagement.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/ListInventoryEntries">REST API Reference for ListInventoryEntries Operation</seealso>
        public virtual ListInventoryEntriesResponse EndListInventoryEntries(IAsyncResult asyncResult)
        {
            return EndInvoke<ListInventoryEntriesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListOpsItemEvents

        /// <summary>
        /// Returns a list of all OpsItem events in the current Amazon Web Services Region and
        /// Amazon Web Services account. You can limit the results to events associated with specific
        /// OpsItems by specifying a filter.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListOpsItemEvents service method.</param>
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
        public virtual ListOpsItemEventsResponse ListOpsItemEvents(ListOpsItemEventsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListOpsItemEventsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListOpsItemEventsResponseUnmarshaller.Instance;

            return Invoke<ListOpsItemEventsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListOpsItemEvents operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListOpsItemEvents operation on AmazonSimpleSystemsManagementClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListOpsItemEvents
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/ListOpsItemEvents">REST API Reference for ListOpsItemEvents Operation</seealso>
        public virtual IAsyncResult BeginListOpsItemEvents(ListOpsItemEventsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListOpsItemEventsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListOpsItemEventsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListOpsItemEvents operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListOpsItemEvents.</param>
        /// 
        /// <returns>Returns a  ListOpsItemEventsResult from SimpleSystemsManagement.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/ListOpsItemEvents">REST API Reference for ListOpsItemEvents Operation</seealso>
        public virtual ListOpsItemEventsResponse EndListOpsItemEvents(IAsyncResult asyncResult)
        {
            return EndInvoke<ListOpsItemEventsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListOpsItemRelatedItems

        /// <summary>
        /// Lists all related-item resources associated with a Systems Manager OpsCenter OpsItem.
        /// OpsCenter is a capability of Amazon Web Services Systems Manager.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListOpsItemRelatedItems service method.</param>
        /// 
        /// <returns>The response from the ListOpsItemRelatedItems service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.OpsItemInvalidParameterException">
        /// A specified parameter argument isn't valid. Verify the available arguments and try
        /// again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/ListOpsItemRelatedItems">REST API Reference for ListOpsItemRelatedItems Operation</seealso>
        public virtual ListOpsItemRelatedItemsResponse ListOpsItemRelatedItems(ListOpsItemRelatedItemsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListOpsItemRelatedItemsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListOpsItemRelatedItemsResponseUnmarshaller.Instance;

            return Invoke<ListOpsItemRelatedItemsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListOpsItemRelatedItems operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListOpsItemRelatedItems operation on AmazonSimpleSystemsManagementClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListOpsItemRelatedItems
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/ListOpsItemRelatedItems">REST API Reference for ListOpsItemRelatedItems Operation</seealso>
        public virtual IAsyncResult BeginListOpsItemRelatedItems(ListOpsItemRelatedItemsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListOpsItemRelatedItemsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListOpsItemRelatedItemsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListOpsItemRelatedItems operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListOpsItemRelatedItems.</param>
        /// 
        /// <returns>Returns a  ListOpsItemRelatedItemsResult from SimpleSystemsManagement.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/ListOpsItemRelatedItems">REST API Reference for ListOpsItemRelatedItems Operation</seealso>
        public virtual ListOpsItemRelatedItemsResponse EndListOpsItemRelatedItems(IAsyncResult asyncResult)
        {
            return EndInvoke<ListOpsItemRelatedItemsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListOpsMetadata

        /// <summary>
        /// Amazon Web Services Systems Manager calls this API operation when displaying all Application
        /// Manager OpsMetadata objects or blobs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListOpsMetadata service method.</param>
        /// 
        /// <returns>The response from the ListOpsMetadata service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.OpsMetadataInvalidArgumentException">
        /// One of the arguments passed is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/ListOpsMetadata">REST API Reference for ListOpsMetadata Operation</seealso>
        public virtual ListOpsMetadataResponse ListOpsMetadata(ListOpsMetadataRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListOpsMetadataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListOpsMetadataResponseUnmarshaller.Instance;

            return Invoke<ListOpsMetadataResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListOpsMetadata operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListOpsMetadata operation on AmazonSimpleSystemsManagementClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListOpsMetadata
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/ListOpsMetadata">REST API Reference for ListOpsMetadata Operation</seealso>
        public virtual IAsyncResult BeginListOpsMetadata(ListOpsMetadataRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListOpsMetadataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListOpsMetadataResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListOpsMetadata operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListOpsMetadata.</param>
        /// 
        /// <returns>Returns a  ListOpsMetadataResult from SimpleSystemsManagement.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/ListOpsMetadata">REST API Reference for ListOpsMetadata Operation</seealso>
        public virtual ListOpsMetadataResponse EndListOpsMetadata(IAsyncResult asyncResult)
        {
            return EndInvoke<ListOpsMetadataResponse>(asyncResult);
        }

        #endregion
        
        #region  ListResourceComplianceSummaries

        /// <summary>
        /// Returns a resource-level summary count. The summary includes information about compliant
        /// and non-compliant statuses and detailed compliance-item severity counts, according
        /// to the filter criteria you specify.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListResourceComplianceSummaries service method.</param>
        /// 
        /// <returns>The response from the ListResourceComplianceSummaries service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidFilterException">
        /// The filter name isn't valid. Verify the you entered the correct name and try again.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidNextTokenException">
        /// The specified token isn't valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/ListResourceComplianceSummaries">REST API Reference for ListResourceComplianceSummaries Operation</seealso>
        public virtual ListResourceComplianceSummariesResponse ListResourceComplianceSummaries(ListResourceComplianceSummariesRequest request)
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
        /// <param name="request">Container for the necessary parameters to execute the ListResourceComplianceSummaries operation on AmazonSimpleSystemsManagementClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListResourceComplianceSummaries
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/ListResourceComplianceSummaries">REST API Reference for ListResourceComplianceSummaries Operation</seealso>
        public virtual IAsyncResult BeginListResourceComplianceSummaries(ListResourceComplianceSummariesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListResourceComplianceSummariesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListResourceComplianceSummariesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListResourceComplianceSummaries operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListResourceComplianceSummaries.</param>
        /// 
        /// <returns>Returns a  ListResourceComplianceSummariesResult from SimpleSystemsManagement.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/ListResourceComplianceSummaries">REST API Reference for ListResourceComplianceSummaries Operation</seealso>
        public virtual ListResourceComplianceSummariesResponse EndListResourceComplianceSummaries(IAsyncResult asyncResult)
        {
            return EndInvoke<ListResourceComplianceSummariesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListResourceDataSync

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
        /// 
        /// <returns>The response from the ListResourceDataSync service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidNextTokenException">
        /// The specified token isn't valid.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.ResourceDataSyncInvalidConfigurationException">
        /// The specified sync configuration is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/ListResourceDataSync">REST API Reference for ListResourceDataSync Operation</seealso>
        public virtual ListResourceDataSyncResponse ListResourceDataSync(ListResourceDataSyncRequest request)
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
        /// <param name="request">Container for the necessary parameters to execute the ListResourceDataSync operation on AmazonSimpleSystemsManagementClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListResourceDataSync
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/ListResourceDataSync">REST API Reference for ListResourceDataSync Operation</seealso>
        public virtual IAsyncResult BeginListResourceDataSync(ListResourceDataSyncRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListResourceDataSyncRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListResourceDataSyncResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListResourceDataSync operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListResourceDataSync.</param>
        /// 
        /// <returns>Returns a  ListResourceDataSyncResult from SimpleSystemsManagement.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/ListResourceDataSync">REST API Reference for ListResourceDataSync Operation</seealso>
        public virtual ListResourceDataSyncResponse EndListResourceDataSync(IAsyncResult asyncResult)
        {
            return EndInvoke<ListResourceDataSyncResponse>(asyncResult);
        }

        #endregion
        
        #region  ListTagsForResource

        /// <summary>
        /// Returns a list of the tags assigned to the specified resource.
        /// 
        ///  
        /// <para>
        /// For information about the ID format for each supported resource type, see <a>AddTagsToResource</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidResourceIdException">
        /// The resource ID isn't valid. Verify that you entered the correct ID and try again.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidResourceTypeException">
        /// The resource type isn't valid. For example, if you are attempting to tag an EC2 instance,
        /// the instance must be a registered managed node.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
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
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonSimpleSystemsManagementClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual IAsyncResult BeginListTagsForResource(ListTagsForResourceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTagsForResource.</param>
        /// 
        /// <returns>Returns a  ListTagsForResourceResult from SimpleSystemsManagement.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult)
        {
            return EndInvoke<ListTagsForResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  ModifyDocumentPermission

        /// <summary>
        /// Shares a Amazon Web Services Systems Manager document (SSM document)publicly or privately.
        /// If you share a document privately, you must specify the Amazon Web Services user account
        /// IDs for those people who can use the document. If you share a document publicly, you
        /// must specify <i>All</i> as the account ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyDocumentPermission service method.</param>
        /// 
        /// <returns>The response from the ModifyDocumentPermission service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.DocumentLimitExceededException">
        /// You can have at most 500 active SSM documents.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.DocumentPermissionLimitException">
        /// The document can't be shared with more Amazon Web Services user accounts. You can
        /// specify a maximum of 20 accounts per API operation to share a private document.
        /// 
        ///  
        /// <para>
        /// By default, you can share a private document with a maximum of 1,000 accounts and
        /// publicly share up to five documents.
        /// </para>
        ///  
        /// <para>
        /// If you need to increase the quota for privately or publicly shared Systems Manager
        /// documents, contact Amazon Web Services Support.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidDocumentException">
        /// The specified SSM document doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidPermissionTypeException">
        /// The permission type isn't supported. <i>Share</i> is the only supported permission
        /// type.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/ModifyDocumentPermission">REST API Reference for ModifyDocumentPermission Operation</seealso>
        public virtual ModifyDocumentPermissionResponse ModifyDocumentPermission(ModifyDocumentPermissionRequest request)
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
        /// <param name="request">Container for the necessary parameters to execute the ModifyDocumentPermission operation on AmazonSimpleSystemsManagementClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndModifyDocumentPermission
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/ModifyDocumentPermission">REST API Reference for ModifyDocumentPermission Operation</seealso>
        public virtual IAsyncResult BeginModifyDocumentPermission(ModifyDocumentPermissionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyDocumentPermissionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyDocumentPermissionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ModifyDocumentPermission operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginModifyDocumentPermission.</param>
        /// 
        /// <returns>Returns a  ModifyDocumentPermissionResult from SimpleSystemsManagement.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/ModifyDocumentPermission">REST API Reference for ModifyDocumentPermission Operation</seealso>
        public virtual ModifyDocumentPermissionResponse EndModifyDocumentPermission(IAsyncResult asyncResult)
        {
            return EndInvoke<ModifyDocumentPermissionResponse>(asyncResult);
        }

        #endregion
        
        #region  PutComplianceItems

        /// <summary>
        /// Registers a compliance type and other compliance details on a designated resource.
        /// This operation lets you register custom compliance details with a resource. This call
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
        /// to the managed node.
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
        /// Severity: A patch severity. For example, <code>Critical</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// DocumentName: An SSM document name. For example, <code>AWS-RunPatchBaseline</code>.
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
        /// One or more content items isn't valid.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidResourceIdException">
        /// The resource ID isn't valid. Verify that you entered the correct ID and try again.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidResourceTypeException">
        /// The resource type isn't valid. For example, if you are attempting to tag an EC2 instance,
        /// the instance must be a registered managed node.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.ItemSizeLimitExceededException">
        /// The inventory item size has exceeded the size limit.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.TotalSizeLimitExceededException">
        /// The size of inventory data has exceeded the total size limit for the resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/PutComplianceItems">REST API Reference for PutComplianceItems Operation</seealso>
        public virtual PutComplianceItemsResponse PutComplianceItems(PutComplianceItemsRequest request)
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
        /// <param name="request">Container for the necessary parameters to execute the PutComplianceItems operation on AmazonSimpleSystemsManagementClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutComplianceItems
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/PutComplianceItems">REST API Reference for PutComplianceItems Operation</seealso>
        public virtual IAsyncResult BeginPutComplianceItems(PutComplianceItemsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutComplianceItemsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutComplianceItemsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutComplianceItems operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutComplianceItems.</param>
        /// 
        /// <returns>Returns a  PutComplianceItemsResult from SimpleSystemsManagement.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/PutComplianceItems">REST API Reference for PutComplianceItems Operation</seealso>
        public virtual PutComplianceItemsResponse EndPutComplianceItems(IAsyncResult asyncResult)
        {
            return EndInvoke<PutComplianceItemsResponse>(asyncResult);
        }

        #endregion
        
        #region  PutInventory

        /// <summary>
        /// Bulk update custom inventory items on one or more managed nodes. The request adds
        /// an inventory item, if it doesn't already exist, or updates an inventory item, if it
        /// does exist.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutInventory service method.</param>
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
        ///  <ul> <li> 
        /// <para>
        /// You don't have permission to access the managed node.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Amazon Web Services Systems Manager Agent(SSM Agent) isn't running. Verify that SSM
        /// Agent is running.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// SSM Agent isn't registered with the SSM endpoint. Try reinstalling SSM Agent.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The managed node isn't in valid state. Valid states are: <code>Running</code>, <code>Pending</code>,
        /// <code>Stopped</code>, and <code>Stopping</code>. Invalid states are: <code>Shutting-down</code>
        /// and <code>Terminated</code>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidInventoryItemContextException">
        /// You specified invalid keys or values in the <code>Context</code> attribute for <code>InventoryItem</code>.
        /// Verify the keys and values, and try again.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidItemContentException">
        /// One or more content items isn't valid.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidTypeNameException">
        /// The parameter type name isn't valid.
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
        /// isn't allowed for this inventory type. You can only use the <code>Context</code> attribute
        /// with inventory types like <code>AWS:ComplianceItem</code>.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.UnsupportedInventorySchemaVersionException">
        /// Inventory item type schema version has to match supported versions in the service.
        /// Check output of GetInventorySchema to see the available schema version for each type.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/PutInventory">REST API Reference for PutInventory Operation</seealso>
        public virtual PutInventoryResponse PutInventory(PutInventoryRequest request)
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
        /// <param name="request">Container for the necessary parameters to execute the PutInventory operation on AmazonSimpleSystemsManagementClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutInventory
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/PutInventory">REST API Reference for PutInventory Operation</seealso>
        public virtual IAsyncResult BeginPutInventory(PutInventoryRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutInventoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutInventoryResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutInventory operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutInventory.</param>
        /// 
        /// <returns>Returns a  PutInventoryResult from SimpleSystemsManagement.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/PutInventory">REST API Reference for PutInventory Operation</seealso>
        public virtual PutInventoryResponse EndPutInventory(IAsyncResult asyncResult)
        {
            return EndInvoke<PutInventoryResponse>(asyncResult);
        }

        #endregion
        
        #region  PutParameter

        /// <summary>
        /// Add a parameter to the system.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutParameter service method.</param>
        /// 
        /// <returns>The response from the PutParameter service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.HierarchyLevelLimitExceededException">
        /// A hierarchy can have a maximum of 15 levels. For more information, see <a href="https://docs.aws.amazon.com/systems-manager/latest/userguide/sysman-parameter-name-constraints.html">Requirements
        /// and constraints for parameter names</a> in the <i>Amazon Web Services Systems Manager
        /// User Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.HierarchyTypeMismatchException">
        /// Parameter Store doesn't support changing a parameter type in a hierarchy. For example,
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
        /// The request doesn't meet the regular expression requirement.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidKeyIdException">
        /// The query key ID isn't valid.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidPolicyAttributeException">
        /// A policy attribute or its value is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidPolicyTypeException">
        /// The policy type isn't supported. Parameter Store supports the following policy types:
        /// Expiration, ExpirationNotification, and NoChangeNotification.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.ParameterAlreadyExistsException">
        /// The parameter already exists. You can't create duplicate parameters.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.ParameterLimitExceededException">
        /// You have exceeded the number of parameters for this Amazon Web Services account. Delete
        /// one or more parameters and try again.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.ParameterMaxVersionLimitExceededException">
        /// Parameter Store retains the 100 most recently created versions of a parameter. After
        /// this number of versions has been created, Parameter Store deletes the oldest version
        /// when a new one is created. However, if the oldest version has a <i>label</i> attached
        /// to it, Parameter Store won't delete the version and instead presents this error message:
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
        /// For information about moving parameter labels, see <a href="https://docs.aws.amazon.com/systems-manager/latest/userguide/sysman-paramstore-labels.html#sysman-paramstore-labels-console-move">Move
        /// a parameter label (console)</a> or <a href="https://docs.aws.amazon.com/systems-manager/latest/userguide/sysman-paramstore-labels.html#sysman-paramstore-labels-cli-move">Move
        /// a parameter label (CLI)</a> in the <i>Amazon Web Services Systems Manager User Guide</i>.
        /// 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.ParameterPatternMismatchException">
        /// The parameter name isn't valid.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.PoliciesLimitExceededException">
        /// You specified more than the maximum number of allowed policies for the parameter.
        /// The maximum is 10.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.TooManyUpdatesException">
        /// There are concurrent updates for a resource that supports one update at a time.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.UnsupportedParameterTypeException">
        /// The parameter type isn't supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/PutParameter">REST API Reference for PutParameter Operation</seealso>
        public virtual PutParameterResponse PutParameter(PutParameterRequest request)
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
        /// <param name="request">Container for the necessary parameters to execute the PutParameter operation on AmazonSimpleSystemsManagementClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutParameter
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/PutParameter">REST API Reference for PutParameter Operation</seealso>
        public virtual IAsyncResult BeginPutParameter(PutParameterRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutParameterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutParameterResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutParameter operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutParameter.</param>
        /// 
        /// <returns>Returns a  PutParameterResult from SimpleSystemsManagement.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/PutParameter">REST API Reference for PutParameter Operation</seealso>
        public virtual PutParameterResponse EndPutParameter(IAsyncResult asyncResult)
        {
            return EndInvoke<PutParameterResponse>(asyncResult);
        }

        #endregion
        
        #region  PutResourcePolicy

        /// <summary>
        /// Creates or updates a Systems Manager resource policy. A resource policy helps you
        /// to define the IAM entity (for example, an Amazon Web Services account) that can manage
        /// your Systems Manager resources. Currently, <code>OpsItemGroup</code> is the only resource
        /// that supports Systems Manager resource policies. The resource policy for <code>OpsItemGroup</code>
        /// enables Amazon Web Services accounts to view and interact with OpsCenter operational
        /// work items (OpsItems).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutResourcePolicy service method.</param>
        /// 
        /// <returns>The response from the PutResourcePolicy service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.ResourcePolicyConflictException">
        /// The hash provided in the call doesn't match the stored hash. This exception is thrown
        /// when trying to update an obsolete policy version or when multiple requests to update
        /// a policy are sent.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.ResourcePolicyInvalidParameterException">
        /// One or more parameters specified for the call aren't valid. Verify the parameters
        /// and their values and try again.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.ResourcePolicyLimitExceededException">
        /// The <a>PutResourcePolicy</a> API action enforces two limits. A policy can't be greater
        /// than 1024 bytes in size. And only one policy can be attached to <code>OpsItemGroup</code>.
        /// Verify these limits and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/PutResourcePolicy">REST API Reference for PutResourcePolicy Operation</seealso>
        public virtual PutResourcePolicyResponse PutResourcePolicy(PutResourcePolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutResourcePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutResourcePolicyResponseUnmarshaller.Instance;

            return Invoke<PutResourcePolicyResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutResourcePolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutResourcePolicy operation on AmazonSimpleSystemsManagementClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutResourcePolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/PutResourcePolicy">REST API Reference for PutResourcePolicy Operation</seealso>
        public virtual IAsyncResult BeginPutResourcePolicy(PutResourcePolicyRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutResourcePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutResourcePolicyResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutResourcePolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutResourcePolicy.</param>
        /// 
        /// <returns>Returns a  PutResourcePolicyResult from SimpleSystemsManagement.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/PutResourcePolicy">REST API Reference for PutResourcePolicy Operation</seealso>
        public virtual PutResourcePolicyResponse EndPutResourcePolicy(IAsyncResult asyncResult)
        {
            return EndInvoke<PutResourcePolicyResponse>(asyncResult);
        }

        #endregion
        
        #region  RegisterDefaultPatchBaseline

        /// <summary>
        /// Defines the default patch baseline for the relevant operating system.
        /// 
        ///  
        /// <para>
        /// To reset the Amazon Web Services-predefined patch baseline as the default, specify
        /// the full patch baseline Amazon Resource Name (ARN) as the baseline ID value. For example,
        /// for CentOS, specify <code>arn:aws:ssm:us-east-2:733109147000:patchbaseline/pb-0574b43a65ea646ed</code>
        /// instead of <code>pb-0574b43a65ea646ed</code>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RegisterDefaultPatchBaseline service method.</param>
        /// 
        /// <returns>The response from the RegisterDefaultPatchBaseline service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.DoesNotExistException">
        /// Error returned when the ID specified for a resource, such as a maintenance window
        /// or patch baseline, doesn't exist.
        /// 
        ///  
        /// <para>
        /// For information about resource quotas in Amazon Web Services Systems Manager, see
        /// <a href="https://docs.aws.amazon.com/general/latest/gr/ssm.html#limits_ssm">Systems
        /// Manager service quotas</a> in the <i>Amazon Web Services General Reference</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidResourceIdException">
        /// The resource ID isn't valid. Verify that you entered the correct ID and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/RegisterDefaultPatchBaseline">REST API Reference for RegisterDefaultPatchBaseline Operation</seealso>
        public virtual RegisterDefaultPatchBaselineResponse RegisterDefaultPatchBaseline(RegisterDefaultPatchBaselineRequest request)
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
        /// <param name="request">Container for the necessary parameters to execute the RegisterDefaultPatchBaseline operation on AmazonSimpleSystemsManagementClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRegisterDefaultPatchBaseline
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/RegisterDefaultPatchBaseline">REST API Reference for RegisterDefaultPatchBaseline Operation</seealso>
        public virtual IAsyncResult BeginRegisterDefaultPatchBaseline(RegisterDefaultPatchBaselineRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RegisterDefaultPatchBaselineRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RegisterDefaultPatchBaselineResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  RegisterDefaultPatchBaseline operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRegisterDefaultPatchBaseline.</param>
        /// 
        /// <returns>Returns a  RegisterDefaultPatchBaselineResult from SimpleSystemsManagement.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/RegisterDefaultPatchBaseline">REST API Reference for RegisterDefaultPatchBaseline Operation</seealso>
        public virtual RegisterDefaultPatchBaselineResponse EndRegisterDefaultPatchBaseline(IAsyncResult asyncResult)
        {
            return EndInvoke<RegisterDefaultPatchBaselineResponse>(asyncResult);
        }

        #endregion
        
        #region  RegisterPatchBaselineForPatchGroup

        /// <summary>
        /// Registers a patch baseline for a patch group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RegisterPatchBaselineForPatchGroup service method.</param>
        /// 
        /// <returns>The response from the RegisterPatchBaselineForPatchGroup service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.AlreadyExistsException">
        /// Error returned if an attempt is made to register a patch group with a patch baseline
        /// that is already registered with a different patch baseline.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.DoesNotExistException">
        /// Error returned when the ID specified for a resource, such as a maintenance window
        /// or patch baseline, doesn't exist.
        /// 
        ///  
        /// <para>
        /// For information about resource quotas in Amazon Web Services Systems Manager, see
        /// <a href="https://docs.aws.amazon.com/general/latest/gr/ssm.html#limits_ssm">Systems
        /// Manager service quotas</a> in the <i>Amazon Web Services General Reference</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidResourceIdException">
        /// The resource ID isn't valid. Verify that you entered the correct ID and try again.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.ResourceLimitExceededException">
        /// Error returned when the caller has exceeded the default resource quotas. For example,
        /// too many maintenance windows or patch baselines have been created.
        /// 
        ///  
        /// <para>
        /// For information about resource quotas in Systems Manager, see <a href="https://docs.aws.amazon.com/general/latest/gr/ssm.html#limits_ssm">Systems
        /// Manager service quotas</a> in the <i>Amazon Web Services General Reference</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/RegisterPatchBaselineForPatchGroup">REST API Reference for RegisterPatchBaselineForPatchGroup Operation</seealso>
        public virtual RegisterPatchBaselineForPatchGroupResponse RegisterPatchBaselineForPatchGroup(RegisterPatchBaselineForPatchGroupRequest request)
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
        /// <param name="request">Container for the necessary parameters to execute the RegisterPatchBaselineForPatchGroup operation on AmazonSimpleSystemsManagementClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRegisterPatchBaselineForPatchGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/RegisterPatchBaselineForPatchGroup">REST API Reference for RegisterPatchBaselineForPatchGroup Operation</seealso>
        public virtual IAsyncResult BeginRegisterPatchBaselineForPatchGroup(RegisterPatchBaselineForPatchGroupRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RegisterPatchBaselineForPatchGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RegisterPatchBaselineForPatchGroupResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  RegisterPatchBaselineForPatchGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRegisterPatchBaselineForPatchGroup.</param>
        /// 
        /// <returns>Returns a  RegisterPatchBaselineForPatchGroupResult from SimpleSystemsManagement.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/RegisterPatchBaselineForPatchGroup">REST API Reference for RegisterPatchBaselineForPatchGroup Operation</seealso>
        public virtual RegisterPatchBaselineForPatchGroupResponse EndRegisterPatchBaselineForPatchGroup(IAsyncResult asyncResult)
        {
            return EndInvoke<RegisterPatchBaselineForPatchGroupResponse>(asyncResult);
        }

        #endregion
        
        #region  RegisterTargetWithMaintenanceWindow

        /// <summary>
        /// Registers a target with a maintenance window.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RegisterTargetWithMaintenanceWindow service method.</param>
        /// 
        /// <returns>The response from the RegisterTargetWithMaintenanceWindow service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.DoesNotExistException">
        /// Error returned when the ID specified for a resource, such as a maintenance window
        /// or patch baseline, doesn't exist.
        /// 
        ///  
        /// <para>
        /// For information about resource quotas in Amazon Web Services Systems Manager, see
        /// <a href="https://docs.aws.amazon.com/general/latest/gr/ssm.html#limits_ssm">Systems
        /// Manager service quotas</a> in the <i>Amazon Web Services General Reference</i>.
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
        /// For information about resource quotas in Systems Manager, see <a href="https://docs.aws.amazon.com/general/latest/gr/ssm.html#limits_ssm">Systems
        /// Manager service quotas</a> in the <i>Amazon Web Services General Reference</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/RegisterTargetWithMaintenanceWindow">REST API Reference for RegisterTargetWithMaintenanceWindow Operation</seealso>
        public virtual RegisterTargetWithMaintenanceWindowResponse RegisterTargetWithMaintenanceWindow(RegisterTargetWithMaintenanceWindowRequest request)
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
        /// <param name="request">Container for the necessary parameters to execute the RegisterTargetWithMaintenanceWindow operation on AmazonSimpleSystemsManagementClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRegisterTargetWithMaintenanceWindow
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/RegisterTargetWithMaintenanceWindow">REST API Reference for RegisterTargetWithMaintenanceWindow Operation</seealso>
        public virtual IAsyncResult BeginRegisterTargetWithMaintenanceWindow(RegisterTargetWithMaintenanceWindowRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RegisterTargetWithMaintenanceWindowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RegisterTargetWithMaintenanceWindowResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  RegisterTargetWithMaintenanceWindow operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRegisterTargetWithMaintenanceWindow.</param>
        /// 
        /// <returns>Returns a  RegisterTargetWithMaintenanceWindowResult from SimpleSystemsManagement.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/RegisterTargetWithMaintenanceWindow">REST API Reference for RegisterTargetWithMaintenanceWindow Operation</seealso>
        public virtual RegisterTargetWithMaintenanceWindowResponse EndRegisterTargetWithMaintenanceWindow(IAsyncResult asyncResult)
        {
            return EndInvoke<RegisterTargetWithMaintenanceWindowResponse>(asyncResult);
        }

        #endregion
        
        #region  RegisterTaskWithMaintenanceWindow

        /// <summary>
        /// Adds a new task to a maintenance window.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RegisterTaskWithMaintenanceWindow service method.</param>
        /// 
        /// <returns>The response from the RegisterTaskWithMaintenanceWindow service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.DoesNotExistException">
        /// Error returned when the ID specified for a resource, such as a maintenance window
        /// or patch baseline, doesn't exist.
        /// 
        ///  
        /// <para>
        /// For information about resource quotas in Amazon Web Services Systems Manager, see
        /// <a href="https://docs.aws.amazon.com/general/latest/gr/ssm.html#limits_ssm">Systems
        /// Manager service quotas</a> in the <i>Amazon Web Services General Reference</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.FeatureNotAvailableException">
        /// You attempted to register a <code>LAMBDA</code> or <code>STEP_FUNCTIONS</code> task
        /// in a region where the corresponding service isn't available.
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
        /// For information about resource quotas in Systems Manager, see <a href="https://docs.aws.amazon.com/general/latest/gr/ssm.html#limits_ssm">Systems
        /// Manager service quotas</a> in the <i>Amazon Web Services General Reference</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/RegisterTaskWithMaintenanceWindow">REST API Reference for RegisterTaskWithMaintenanceWindow Operation</seealso>
        public virtual RegisterTaskWithMaintenanceWindowResponse RegisterTaskWithMaintenanceWindow(RegisterTaskWithMaintenanceWindowRequest request)
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
        /// <param name="request">Container for the necessary parameters to execute the RegisterTaskWithMaintenanceWindow operation on AmazonSimpleSystemsManagementClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRegisterTaskWithMaintenanceWindow
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/RegisterTaskWithMaintenanceWindow">REST API Reference for RegisterTaskWithMaintenanceWindow Operation</seealso>
        public virtual IAsyncResult BeginRegisterTaskWithMaintenanceWindow(RegisterTaskWithMaintenanceWindowRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RegisterTaskWithMaintenanceWindowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RegisterTaskWithMaintenanceWindowResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  RegisterTaskWithMaintenanceWindow operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRegisterTaskWithMaintenanceWindow.</param>
        /// 
        /// <returns>Returns a  RegisterTaskWithMaintenanceWindowResult from SimpleSystemsManagement.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/RegisterTaskWithMaintenanceWindow">REST API Reference for RegisterTaskWithMaintenanceWindow Operation</seealso>
        public virtual RegisterTaskWithMaintenanceWindowResponse EndRegisterTaskWithMaintenanceWindow(IAsyncResult asyncResult)
        {
            return EndInvoke<RegisterTaskWithMaintenanceWindowResponse>(asyncResult);
        }

        #endregion
        
        #region  RemoveTagsFromResource

        /// <summary>
        /// Removes tag keys from the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemoveTagsFromResource service method.</param>
        /// 
        /// <returns>The response from the RemoveTagsFromResource service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidResourceIdException">
        /// The resource ID isn't valid. Verify that you entered the correct ID and try again.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidResourceTypeException">
        /// The resource type isn't valid. For example, if you are attempting to tag an EC2 instance,
        /// the instance must be a registered managed node.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.TooManyUpdatesException">
        /// There are concurrent updates for a resource that supports one update at a time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/RemoveTagsFromResource">REST API Reference for RemoveTagsFromResource Operation</seealso>
        public virtual RemoveTagsFromResourceResponse RemoveTagsFromResource(RemoveTagsFromResourceRequest request)
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
        /// <param name="request">Container for the necessary parameters to execute the RemoveTagsFromResource operation on AmazonSimpleSystemsManagementClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRemoveTagsFromResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/RemoveTagsFromResource">REST API Reference for RemoveTagsFromResource Operation</seealso>
        public virtual IAsyncResult BeginRemoveTagsFromResource(RemoveTagsFromResourceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RemoveTagsFromResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RemoveTagsFromResourceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  RemoveTagsFromResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRemoveTagsFromResource.</param>
        /// 
        /// <returns>Returns a  RemoveTagsFromResourceResult from SimpleSystemsManagement.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/RemoveTagsFromResource">REST API Reference for RemoveTagsFromResource Operation</seealso>
        public virtual RemoveTagsFromResourceResponse EndRemoveTagsFromResource(IAsyncResult asyncResult)
        {
            return EndInvoke<RemoveTagsFromResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  ResetServiceSetting

        /// <summary>
        /// <code>ServiceSetting</code> is an account-level setting for an Amazon Web Services
        /// service. This setting defines how a user interacts with or uses a service or a feature
        /// of a service. For example, if an Amazon Web Services service charges money to the
        /// account based on feature or service usage, then the Amazon Web Services service team
        /// might create a default setting of "false". This means the user can't use this feature
        /// unless they change the setting to "true" and intentionally opt in for a paid feature.
        /// 
        ///  
        /// <para>
        /// Services map a <code>SettingId</code> object to a setting value. Amazon Web Services
        /// services teams define the default value for a <code>SettingId</code>. You can't create
        /// a new <code>SettingId</code>, but you can overwrite the default value if you have
        /// the <code>ssm:UpdateServiceSetting</code> permission for the setting. Use the <a>GetServiceSetting</a>
        /// API operation to view the current value. Use the <a>UpdateServiceSetting</a> API operation
        /// to change the default setting. 
        /// </para>
        ///  
        /// <para>
        /// Reset the service setting for the account to the default value as provisioned by the
        /// Amazon Web Services service team. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ResetServiceSetting service method.</param>
        /// 
        /// <returns>The response from the ResetServiceSetting service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.ServiceSettingNotFoundException">
        /// The specified service setting wasn't found. Either the service name or the setting
        /// hasn't been provisioned by the Amazon Web Services service team.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.TooManyUpdatesException">
        /// There are concurrent updates for a resource that supports one update at a time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/ResetServiceSetting">REST API Reference for ResetServiceSetting Operation</seealso>
        public virtual ResetServiceSettingResponse ResetServiceSetting(ResetServiceSettingRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ResetServiceSettingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ResetServiceSettingResponseUnmarshaller.Instance;

            return Invoke<ResetServiceSettingResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ResetServiceSetting operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ResetServiceSetting operation on AmazonSimpleSystemsManagementClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndResetServiceSetting
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/ResetServiceSetting">REST API Reference for ResetServiceSetting Operation</seealso>
        public virtual IAsyncResult BeginResetServiceSetting(ResetServiceSettingRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ResetServiceSettingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ResetServiceSettingResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ResetServiceSetting operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginResetServiceSetting.</param>
        /// 
        /// <returns>Returns a  ResetServiceSettingResult from SimpleSystemsManagement.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/ResetServiceSetting">REST API Reference for ResetServiceSetting Operation</seealso>
        public virtual ResetServiceSettingResponse EndResetServiceSetting(IAsyncResult asyncResult)
        {
            return EndInvoke<ResetServiceSettingResponse>(asyncResult);
        }

        #endregion
        
        #region  ResumeSession

        /// <summary>
        /// Reconnects a session to a managed node after it has been disconnected. Connections
        /// can be resumed for disconnected sessions, but not terminated sessions.
        /// 
        ///  <note> 
        /// <para>
        /// This command is primarily for use by client machines to automatically reconnect during
        /// intermittent network issues. It isn't intended for any other use.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ResumeSession service method.</param>
        /// 
        /// <returns>The response from the ResumeSession service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.DoesNotExistException">
        /// Error returned when the ID specified for a resource, such as a maintenance window
        /// or patch baseline, doesn't exist.
        /// 
        ///  
        /// <para>
        /// For information about resource quotas in Amazon Web Services Systems Manager, see
        /// <a href="https://docs.aws.amazon.com/general/latest/gr/ssm.html#limits_ssm">Systems
        /// Manager service quotas</a> in the <i>Amazon Web Services General Reference</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/ResumeSession">REST API Reference for ResumeSession Operation</seealso>
        public virtual ResumeSessionResponse ResumeSession(ResumeSessionRequest request)
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
        /// <param name="request">Container for the necessary parameters to execute the ResumeSession operation on AmazonSimpleSystemsManagementClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndResumeSession
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/ResumeSession">REST API Reference for ResumeSession Operation</seealso>
        public virtual IAsyncResult BeginResumeSession(ResumeSessionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ResumeSessionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ResumeSessionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ResumeSession operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginResumeSession.</param>
        /// 
        /// <returns>Returns a  ResumeSessionResult from SimpleSystemsManagement.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/ResumeSession">REST API Reference for ResumeSession Operation</seealso>
        public virtual ResumeSessionResponse EndResumeSession(IAsyncResult asyncResult)
        {
            return EndInvoke<ResumeSessionResponse>(asyncResult);
        }

        #endregion
        
        #region  SendAutomationSignal

        /// <summary>
        /// Sends a signal to an Automation execution to change the current behavior or status
        /// of the execution.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SendAutomationSignal service method.</param>
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
        /// The signal isn't valid for the current Automation execution.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/SendAutomationSignal">REST API Reference for SendAutomationSignal Operation</seealso>
        public virtual SendAutomationSignalResponse SendAutomationSignal(SendAutomationSignalRequest request)
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
        /// <param name="request">Container for the necessary parameters to execute the SendAutomationSignal operation on AmazonSimpleSystemsManagementClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSendAutomationSignal
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/SendAutomationSignal">REST API Reference for SendAutomationSignal Operation</seealso>
        public virtual IAsyncResult BeginSendAutomationSignal(SendAutomationSignalRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SendAutomationSignalRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SendAutomationSignalResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  SendAutomationSignal operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSendAutomationSignal.</param>
        /// 
        /// <returns>Returns a  SendAutomationSignalResult from SimpleSystemsManagement.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/SendAutomationSignal">REST API Reference for SendAutomationSignal Operation</seealso>
        public virtual SendAutomationSignalResponse EndSendAutomationSignal(IAsyncResult asyncResult)
        {
            return EndInvoke<SendAutomationSignalResponse>(asyncResult);
        }

        #endregion
        
        #region  SendCommand

        /// <summary>
        /// Runs commands on one or more managed nodes.
        /// </summary>
        /// <param name="documentName">The name of the Amazon Web Services Systems Manager document (SSM document) to run. This can be a public document or a custom document. To run a shared document belonging to another account, specify the document Amazon Resource Name (ARN). For more information about how to use shared documents, see <a href="https://docs.aws.amazon.com/systems-manager/latest/userguide/ssm-using-shared.html">Using shared SSM documents</a> in the <i>Amazon Web Services Systems Manager User Guide</i>. <note> If you specify a document name or ARN that hasn't been shared with your account, you receive an <code>InvalidDocument</code> error.  </note></param>
        /// <param name="instanceIds">The IDs of the managed nodes where the command should run. Specifying managed node IDs is most useful when you are targeting a limited number of managed nodes, though you can specify up to 50 IDs. To target a larger number of managed nodes, or if you prefer not to list individual node IDs, we recommend using the <code>Targets</code> option instead. Using <code>Targets</code>, which accepts tag key-value pairs to identify the managed nodes to send commands to, you can a send command to tens, hundreds, or thousands of nodes at once. For more information about how to use targets, see <a href="https://docs.aws.amazon.com/systems-manager/latest/userguide/send-commands-multiple.html">Using targets and rate controls to send commands to a fleet</a> in the <i>Amazon Web Services Systems Manager User Guide</i>.</param>
        /// 
        /// <returns>The response from the SendCommand service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.DuplicateInstanceIdException">
        /// You can't specify a managed node ID in more than one association.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidDocumentException">
        /// The specified SSM document doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidDocumentVersionException">
        /// The document version isn't valid or doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidInstanceIdException">
        /// The following problems can cause this exception:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You don't have permission to access the managed node.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Amazon Web Services Systems Manager Agent(SSM Agent) isn't running. Verify that SSM
        /// Agent is running.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// SSM Agent isn't registered with the SSM endpoint. Try reinstalling SSM Agent.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The managed node isn't in valid state. Valid states are: <code>Running</code>, <code>Pending</code>,
        /// <code>Stopped</code>, and <code>Stopping</code>. Invalid states are: <code>Shutting-down</code>
        /// and <code>Terminated</code>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidNotificationConfigException">
        /// One or more configuration items isn't valid. Verify that a valid Amazon Resource Name
        /// (ARN) was provided for an Amazon Simple Notification Service topic.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidOutputFolderException">
        /// The S3 bucket doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidParametersException">
        /// You must specify values for all required parameters in the Amazon Web Services Systems
        /// Manager document (SSM document). You can only supply values to parameters defined
        /// in the SSM document.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidRoleException">
        /// The role name can't contain invalid characters. Also verify that you specified an
        /// IAM role for notifications that includes the required trust policy. For information
        /// about configuring the IAM role for Run Command notifications, see <a href="https://docs.aws.amazon.com/systems-manager/latest/userguide/rc-sns-notifications.html">Configuring
        /// Amazon SNS Notifications for Run Command</a> in the <i>Amazon Web Services Systems
        /// Manager User Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.MaxDocumentSizeExceededException">
        /// The size limit of a document is 64 KB.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.UnsupportedPlatformTypeException">
        /// The document doesn't support the platform type of the given managed node ID(s). For
        /// example, you sent an document for a Windows managed node to a Linux node.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/SendCommand">REST API Reference for SendCommand Operation</seealso>
        public virtual SendCommandResponse SendCommand(string documentName, List<string> instanceIds)
        {
            var request = new SendCommandRequest();
            request.DocumentName = documentName;
            request.InstanceIds = instanceIds;
            return SendCommand(request);
        }


        /// <summary>
        /// Runs commands on one or more managed nodes.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SendCommand service method.</param>
        /// 
        /// <returns>The response from the SendCommand service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.DuplicateInstanceIdException">
        /// You can't specify a managed node ID in more than one association.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidDocumentException">
        /// The specified SSM document doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidDocumentVersionException">
        /// The document version isn't valid or doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidInstanceIdException">
        /// The following problems can cause this exception:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You don't have permission to access the managed node.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Amazon Web Services Systems Manager Agent(SSM Agent) isn't running. Verify that SSM
        /// Agent is running.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// SSM Agent isn't registered with the SSM endpoint. Try reinstalling SSM Agent.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The managed node isn't in valid state. Valid states are: <code>Running</code>, <code>Pending</code>,
        /// <code>Stopped</code>, and <code>Stopping</code>. Invalid states are: <code>Shutting-down</code>
        /// and <code>Terminated</code>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidNotificationConfigException">
        /// One or more configuration items isn't valid. Verify that a valid Amazon Resource Name
        /// (ARN) was provided for an Amazon Simple Notification Service topic.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidOutputFolderException">
        /// The S3 bucket doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidParametersException">
        /// You must specify values for all required parameters in the Amazon Web Services Systems
        /// Manager document (SSM document). You can only supply values to parameters defined
        /// in the SSM document.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidRoleException">
        /// The role name can't contain invalid characters. Also verify that you specified an
        /// IAM role for notifications that includes the required trust policy. For information
        /// about configuring the IAM role for Run Command notifications, see <a href="https://docs.aws.amazon.com/systems-manager/latest/userguide/rc-sns-notifications.html">Configuring
        /// Amazon SNS Notifications for Run Command</a> in the <i>Amazon Web Services Systems
        /// Manager User Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.MaxDocumentSizeExceededException">
        /// The size limit of a document is 64 KB.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.UnsupportedPlatformTypeException">
        /// The document doesn't support the platform type of the given managed node ID(s). For
        /// example, you sent an document for a Windows managed node to a Linux node.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/SendCommand">REST API Reference for SendCommand Operation</seealso>
        public virtual SendCommandResponse SendCommand(SendCommandRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SendCommandRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SendCommandResponseUnmarshaller.Instance;

            return Invoke<SendCommandResponse>(request, options);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/SendCommand">REST API Reference for SendCommand Operation</seealso>
        public virtual IAsyncResult BeginSendCommand(SendCommandRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SendCommandRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SendCommandResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  SendCommand operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSendCommand.</param>
        /// 
        /// <returns>Returns a  SendCommandResult from SimpleSystemsManagement.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/SendCommand">REST API Reference for SendCommand Operation</seealso>
        public virtual SendCommandResponse EndSendCommand(IAsyncResult asyncResult)
        {
            return EndInvoke<SendCommandResponse>(asyncResult);
        }

        #endregion
        
        #region  StartAssociationsOnce

        /// <summary>
        /// Runs an association immediately and only one time. This operation can be helpful when
        /// troubleshooting associations.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartAssociationsOnce service method.</param>
        /// 
        /// <returns>The response from the StartAssociationsOnce service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.AssociationDoesNotExistException">
        /// The specified association doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidAssociationException">
        /// The association isn't valid or doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/StartAssociationsOnce">REST API Reference for StartAssociationsOnce Operation</seealso>
        public virtual StartAssociationsOnceResponse StartAssociationsOnce(StartAssociationsOnceRequest request)
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
        /// <param name="request">Container for the necessary parameters to execute the StartAssociationsOnce operation on AmazonSimpleSystemsManagementClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartAssociationsOnce
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/StartAssociationsOnce">REST API Reference for StartAssociationsOnce Operation</seealso>
        public virtual IAsyncResult BeginStartAssociationsOnce(StartAssociationsOnceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartAssociationsOnceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartAssociationsOnceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StartAssociationsOnce operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartAssociationsOnce.</param>
        /// 
        /// <returns>Returns a  StartAssociationsOnceResult from SimpleSystemsManagement.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/StartAssociationsOnce">REST API Reference for StartAssociationsOnce Operation</seealso>
        public virtual StartAssociationsOnceResponse EndStartAssociationsOnce(IAsyncResult asyncResult)
        {
            return EndInvoke<StartAssociationsOnceResponse>(asyncResult);
        }

        #endregion
        
        #region  StartAutomationExecution

        /// <summary>
        /// Initiates execution of an Automation runbook.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartAutomationExecution service method.</param>
        /// 
        /// <returns>The response from the StartAutomationExecution service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.AutomationDefinitionNotFoundException">
        /// An Automation runbook with the specified name couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.AutomationDefinitionVersionNotFoundException">
        /// An Automation runbook with the specified name and version couldn't be found.
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
        /// The supplied parameters for invoking the specified Automation runbook are incorrect.
        /// For example, they may not match the set of parameters permitted for the specified
        /// Automation document.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidTargetException">
        /// The target isn't valid or doesn't exist. It might not be configured for Systems Manager
        /// or you might not have permission to perform the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/StartAutomationExecution">REST API Reference for StartAutomationExecution Operation</seealso>
        public virtual StartAutomationExecutionResponse StartAutomationExecution(StartAutomationExecutionRequest request)
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
        /// <param name="request">Container for the necessary parameters to execute the StartAutomationExecution operation on AmazonSimpleSystemsManagementClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartAutomationExecution
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/StartAutomationExecution">REST API Reference for StartAutomationExecution Operation</seealso>
        public virtual IAsyncResult BeginStartAutomationExecution(StartAutomationExecutionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartAutomationExecutionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartAutomationExecutionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StartAutomationExecution operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartAutomationExecution.</param>
        /// 
        /// <returns>Returns a  StartAutomationExecutionResult from SimpleSystemsManagement.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/StartAutomationExecution">REST API Reference for StartAutomationExecution Operation</seealso>
        public virtual StartAutomationExecutionResponse EndStartAutomationExecution(IAsyncResult asyncResult)
        {
            return EndInvoke<StartAutomationExecutionResponse>(asyncResult);
        }

        #endregion
        
        #region  StartChangeRequestExecution

        /// <summary>
        /// Creates a change request for Change Manager. The Automation runbooks specified in
        /// the change request run only after all required approvals for the change request have
        /// been received.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartChangeRequestExecution service method.</param>
        /// 
        /// <returns>The response from the StartChangeRequestExecution service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.AutomationDefinitionNotApprovedException">
        /// Indicates that the Change Manager change template used in the change request was rejected
        /// or is still in a pending state.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.AutomationDefinitionNotFoundException">
        /// An Automation runbook with the specified name couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.AutomationDefinitionVersionNotFoundException">
        /// An Automation runbook with the specified name and version couldn't be found.
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
        /// The supplied parameters for invoking the specified Automation runbook are incorrect.
        /// For example, they may not match the set of parameters permitted for the specified
        /// Automation document.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/StartChangeRequestExecution">REST API Reference for StartChangeRequestExecution Operation</seealso>
        public virtual StartChangeRequestExecutionResponse StartChangeRequestExecution(StartChangeRequestExecutionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartChangeRequestExecutionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartChangeRequestExecutionResponseUnmarshaller.Instance;

            return Invoke<StartChangeRequestExecutionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StartChangeRequestExecution operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartChangeRequestExecution operation on AmazonSimpleSystemsManagementClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartChangeRequestExecution
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/StartChangeRequestExecution">REST API Reference for StartChangeRequestExecution Operation</seealso>
        public virtual IAsyncResult BeginStartChangeRequestExecution(StartChangeRequestExecutionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartChangeRequestExecutionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartChangeRequestExecutionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StartChangeRequestExecution operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartChangeRequestExecution.</param>
        /// 
        /// <returns>Returns a  StartChangeRequestExecutionResult from SimpleSystemsManagement.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/StartChangeRequestExecution">REST API Reference for StartChangeRequestExecution Operation</seealso>
        public virtual StartChangeRequestExecutionResponse EndStartChangeRequestExecution(IAsyncResult asyncResult)
        {
            return EndInvoke<StartChangeRequestExecutionResponse>(asyncResult);
        }

        #endregion
        
        #region  StartSession

        /// <summary>
        /// Initiates a connection to a target (for example, a managed node) for a Session Manager
        /// session. Returns a URL and token that can be used to open a WebSocket connection for
        /// sending input and receiving outputs.
        /// 
        ///  <note> 
        /// <para>
        /// Amazon Web Services CLI usage: <code>start-session</code> is an interactive command
        /// that requires the Session Manager plugin to be installed on the client machine making
        /// the call. For information, see <a href="https://docs.aws.amazon.com/systems-manager/latest/userguide/session-manager-working-with-install-plugin.html">Install
        /// the Session Manager plugin for the Amazon Web Services CLI</a> in the <i>Amazon Web
        /// Services Systems Manager User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// Amazon Web Services Tools for PowerShell usage: Start-SSMSession isn't currently supported
        /// by Amazon Web Services Tools for PowerShell on Windows local machines.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartSession service method.</param>
        /// 
        /// <returns>The response from the StartSession service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidDocumentException">
        /// The specified SSM document doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.TargetNotConnectedException">
        /// The specified target managed node for the session isn't fully configured for use with
        /// Session Manager. For more information, see <a href="https://docs.aws.amazon.com/systems-manager/latest/userguide/session-manager-getting-started.html">Getting
        /// started with Session Manager</a> in the <i>Amazon Web Services Systems Manager User
        /// Guide</i>. This error is also returned if you attempt to start a session on a managed
        /// node that is located in a different account or Region
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/StartSession">REST API Reference for StartSession Operation</seealso>
        public virtual StartSessionResponse StartSession(StartSessionRequest request)
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
        /// <param name="request">Container for the necessary parameters to execute the StartSession operation on AmazonSimpleSystemsManagementClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartSession
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/StartSession">REST API Reference for StartSession Operation</seealso>
        public virtual IAsyncResult BeginStartSession(StartSessionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartSessionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartSessionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StartSession operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartSession.</param>
        /// 
        /// <returns>Returns a  StartSessionResult from SimpleSystemsManagement.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/StartSession">REST API Reference for StartSession Operation</seealso>
        public virtual StartSessionResponse EndStartSession(IAsyncResult asyncResult)
        {
            return EndInvoke<StartSessionResponse>(asyncResult);
        }

        #endregion
        
        #region  StopAutomationExecution

        /// <summary>
        /// Stop an Automation that is currently running.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopAutomationExecution service method.</param>
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
        /// The specified update status operation isn't valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/StopAutomationExecution">REST API Reference for StopAutomationExecution Operation</seealso>
        public virtual StopAutomationExecutionResponse StopAutomationExecution(StopAutomationExecutionRequest request)
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
        /// <param name="request">Container for the necessary parameters to execute the StopAutomationExecution operation on AmazonSimpleSystemsManagementClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStopAutomationExecution
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/StopAutomationExecution">REST API Reference for StopAutomationExecution Operation</seealso>
        public virtual IAsyncResult BeginStopAutomationExecution(StopAutomationExecutionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopAutomationExecutionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopAutomationExecutionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StopAutomationExecution operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStopAutomationExecution.</param>
        /// 
        /// <returns>Returns a  StopAutomationExecutionResult from SimpleSystemsManagement.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/StopAutomationExecution">REST API Reference for StopAutomationExecution Operation</seealso>
        public virtual StopAutomationExecutionResponse EndStopAutomationExecution(IAsyncResult asyncResult)
        {
            return EndInvoke<StopAutomationExecutionResponse>(asyncResult);
        }

        #endregion
        
        #region  TerminateSession

        /// <summary>
        /// Permanently ends a session and closes the data connection between the Session Manager
        /// client and SSM Agent on the managed node. A terminated session can't be resumed.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TerminateSession service method.</param>
        /// 
        /// <returns>The response from the TerminateSession service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/TerminateSession">REST API Reference for TerminateSession Operation</seealso>
        public virtual TerminateSessionResponse TerminateSession(TerminateSessionRequest request)
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
        /// <param name="request">Container for the necessary parameters to execute the TerminateSession operation on AmazonSimpleSystemsManagementClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTerminateSession
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/TerminateSession">REST API Reference for TerminateSession Operation</seealso>
        public virtual IAsyncResult BeginTerminateSession(TerminateSessionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TerminateSessionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TerminateSessionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  TerminateSession operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTerminateSession.</param>
        /// 
        /// <returns>Returns a  TerminateSessionResult from SimpleSystemsManagement.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/TerminateSession">REST API Reference for TerminateSession Operation</seealso>
        public virtual TerminateSessionResponse EndTerminateSession(IAsyncResult asyncResult)
        {
            return EndInvoke<TerminateSessionResponse>(asyncResult);
        }

        #endregion
        
        #region  UnlabelParameterVersion

        /// <summary>
        /// Remove a label or labels from a parameter.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UnlabelParameterVersion service method.</param>
        /// 
        /// <returns>The response from the UnlabelParameterVersion service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.ParameterNotFoundException">
        /// The parameter couldn't be found. Verify the name and try again.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.ParameterVersionNotFoundException">
        /// The specified parameter version wasn't found. Verify the parameter name and version,
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.TooManyUpdatesException">
        /// There are concurrent updates for a resource that supports one update at a time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/UnlabelParameterVersion">REST API Reference for UnlabelParameterVersion Operation</seealso>
        public virtual UnlabelParameterVersionResponse UnlabelParameterVersion(UnlabelParameterVersionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UnlabelParameterVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UnlabelParameterVersionResponseUnmarshaller.Instance;

            return Invoke<UnlabelParameterVersionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UnlabelParameterVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UnlabelParameterVersion operation on AmazonSimpleSystemsManagementClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUnlabelParameterVersion
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/UnlabelParameterVersion">REST API Reference for UnlabelParameterVersion Operation</seealso>
        public virtual IAsyncResult BeginUnlabelParameterVersion(UnlabelParameterVersionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UnlabelParameterVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UnlabelParameterVersionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UnlabelParameterVersion operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUnlabelParameterVersion.</param>
        /// 
        /// <returns>Returns a  UnlabelParameterVersionResult from SimpleSystemsManagement.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/UnlabelParameterVersion">REST API Reference for UnlabelParameterVersion Operation</seealso>
        public virtual UnlabelParameterVersionResponse EndUnlabelParameterVersion(IAsyncResult asyncResult)
        {
            return EndInvoke<UnlabelParameterVersionResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateAssociation

        /// <summary>
        /// Updates an association. You can update the association name and version, the document
        /// version, schedule, parameters, and Amazon Simple Storage Service (Amazon S3) output.
        /// When you call <code>UpdateAssociation</code>, the system removes all optional parameters
        /// from the request and overwrites the association with null values for those parameters.
        /// This is by design. You must specify all optional parameters in the call, even if you
        /// are not changing the parameters. This includes the <code>Name</code> parameter. Before
        /// calling this API action, we recommend that you call the <a>DescribeAssociation</a>
        /// API operation and make a note of all optional parameters required for your <code>UpdateAssociation</code>
        /// call.
        /// 
        ///  
        /// <para>
        /// In order to call this API operation, your Identity and Access Management (IAM) user
        /// account, group, or role must be configured with permission to call the <a>DescribeAssociation</a>
        /// API operation. If you don't have permission to call <code>DescribeAssociation</code>,
        /// then you receive the following error: <code>An error occurred (AccessDeniedException)
        /// when calling the UpdateAssociation operation: User: &lt;user_arn&gt; isn't authorized
        /// to perform: ssm:DescribeAssociation on resource: &lt;resource_arn&gt;</code> 
        /// </para>
        ///  <important> 
        /// <para>
        /// When you update an association, the association immediately runs against the specified
        /// targets. You can add the <code>ApplyOnlyAtCronInterval</code> parameter to run the
        /// association during the next schedule run.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAssociation service method.</param>
        /// 
        /// <returns>The response from the UpdateAssociation service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.AssociationDoesNotExistException">
        /// The specified association doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.AssociationVersionLimitExceededException">
        /// You have reached the maximum number versions allowed for an association. Each association
        /// has a limit of 1,000 versions.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidAssociationVersionException">
        /// The version you specified isn't valid. Use ListAssociationVersions to view all versions
        /// of an association according to the association ID. Or, use the <code>$LATEST</code>
        /// parameter to view the latest version of the association.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidDocumentException">
        /// The specified SSM document doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidDocumentVersionException">
        /// The document version isn't valid or doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidOutputLocationException">
        /// The output location isn't valid or doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidParametersException">
        /// You must specify values for all required parameters in the Amazon Web Services Systems
        /// Manager document (SSM document). You can only supply values to parameters defined
        /// in the SSM document.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidScheduleException">
        /// The schedule is invalid. Verify your cron or rate expression and try again.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidTargetException">
        /// The target isn't valid or doesn't exist. It might not be configured for Systems Manager
        /// or you might not have permission to perform the operation.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidTargetMapsException">
        /// TargetMap parameter isn't valid.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidUpdateException">
        /// The update isn't valid.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.TooManyUpdatesException">
        /// There are concurrent updates for a resource that supports one update at a time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/UpdateAssociation">REST API Reference for UpdateAssociation Operation</seealso>
        public virtual UpdateAssociationResponse UpdateAssociation(UpdateAssociationRequest request)
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
        /// <param name="request">Container for the necessary parameters to execute the UpdateAssociation operation on AmazonSimpleSystemsManagementClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateAssociation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/UpdateAssociation">REST API Reference for UpdateAssociation Operation</seealso>
        public virtual IAsyncResult BeginUpdateAssociation(UpdateAssociationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAssociationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateAssociation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateAssociation.</param>
        /// 
        /// <returns>Returns a  UpdateAssociationResult from SimpleSystemsManagement.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/UpdateAssociation">REST API Reference for UpdateAssociation Operation</seealso>
        public virtual UpdateAssociationResponse EndUpdateAssociation(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateAssociationResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateAssociationStatus

        /// <summary>
        /// Updates the status of the Amazon Web Services Systems Manager document (SSM document)
        /// associated with the specified managed node.
        /// 
        ///  
        /// <para>
        ///  <code>UpdateAssociationStatus</code> is primarily used by the Amazon Web Services
        /// Systems Manager Agent (SSM Agent) to report status updates about your associations
        /// and is only used for associations created with the <code>InstanceId</code> legacy
        /// parameter.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAssociationStatus service method.</param>
        /// 
        /// <returns>The response from the UpdateAssociationStatus service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.AssociationDoesNotExistException">
        /// The specified association doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidDocumentException">
        /// The specified SSM document doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidInstanceIdException">
        /// The following problems can cause this exception:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You don't have permission to access the managed node.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Amazon Web Services Systems Manager Agent(SSM Agent) isn't running. Verify that SSM
        /// Agent is running.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// SSM Agent isn't registered with the SSM endpoint. Try reinstalling SSM Agent.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The managed node isn't in valid state. Valid states are: <code>Running</code>, <code>Pending</code>,
        /// <code>Stopped</code>, and <code>Stopping</code>. Invalid states are: <code>Shutting-down</code>
        /// and <code>Terminated</code>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.StatusUnchangedException">
        /// The updated status is the same as the current status.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.TooManyUpdatesException">
        /// There are concurrent updates for a resource that supports one update at a time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/UpdateAssociationStatus">REST API Reference for UpdateAssociationStatus Operation</seealso>
        public virtual UpdateAssociationStatusResponse UpdateAssociationStatus(UpdateAssociationStatusRequest request)
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
        /// <param name="request">Container for the necessary parameters to execute the UpdateAssociationStatus operation on AmazonSimpleSystemsManagementClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateAssociationStatus
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/UpdateAssociationStatus">REST API Reference for UpdateAssociationStatus Operation</seealso>
        public virtual IAsyncResult BeginUpdateAssociationStatus(UpdateAssociationStatusRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateAssociationStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAssociationStatusResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateAssociationStatus operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateAssociationStatus.</param>
        /// 
        /// <returns>Returns a  UpdateAssociationStatusResult from SimpleSystemsManagement.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/UpdateAssociationStatus">REST API Reference for UpdateAssociationStatus Operation</seealso>
        public virtual UpdateAssociationStatusResponse EndUpdateAssociationStatus(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateAssociationStatusResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateDocument

        /// <summary>
        /// Updates one or more values for an SSM document.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDocument service method.</param>
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
        /// The content for the document isn't valid.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidDocumentException">
        /// The specified SSM document doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidDocumentOperationException">
        /// You attempted to delete a document while it is still shared. You must stop sharing
        /// the document before you can delete it.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidDocumentSchemaVersionException">
        /// The version of the document schema isn't supported.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidDocumentVersionException">
        /// The document version isn't valid or doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.MaxDocumentSizeExceededException">
        /// The size limit of a document is 64 KB.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/UpdateDocument">REST API Reference for UpdateDocument Operation</seealso>
        public virtual UpdateDocumentResponse UpdateDocument(UpdateDocumentRequest request)
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
        /// <param name="request">Container for the necessary parameters to execute the UpdateDocument operation on AmazonSimpleSystemsManagementClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateDocument
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/UpdateDocument">REST API Reference for UpdateDocument Operation</seealso>
        public virtual IAsyncResult BeginUpdateDocument(UpdateDocumentRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateDocumentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDocumentResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateDocument operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateDocument.</param>
        /// 
        /// <returns>Returns a  UpdateDocumentResult from SimpleSystemsManagement.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/UpdateDocument">REST API Reference for UpdateDocument Operation</seealso>
        public virtual UpdateDocumentResponse EndUpdateDocument(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateDocumentResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateDocumentDefaultVersion

        /// <summary>
        /// Set the default version of a document. 
        /// 
        ///  <note> 
        /// <para>
        /// If you change a document version for a State Manager association, Systems Manager
        /// immediately runs the association unless you previously specifed the <code>apply-only-at-cron-interval</code>
        /// parameter.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDocumentDefaultVersion service method.</param>
        /// 
        /// <returns>The response from the UpdateDocumentDefaultVersion service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidDocumentException">
        /// The specified SSM document doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidDocumentSchemaVersionException">
        /// The version of the document schema isn't supported.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidDocumentVersionException">
        /// The document version isn't valid or doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/UpdateDocumentDefaultVersion">REST API Reference for UpdateDocumentDefaultVersion Operation</seealso>
        public virtual UpdateDocumentDefaultVersionResponse UpdateDocumentDefaultVersion(UpdateDocumentDefaultVersionRequest request)
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
        /// <param name="request">Container for the necessary parameters to execute the UpdateDocumentDefaultVersion operation on AmazonSimpleSystemsManagementClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateDocumentDefaultVersion
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/UpdateDocumentDefaultVersion">REST API Reference for UpdateDocumentDefaultVersion Operation</seealso>
        public virtual IAsyncResult BeginUpdateDocumentDefaultVersion(UpdateDocumentDefaultVersionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateDocumentDefaultVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDocumentDefaultVersionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateDocumentDefaultVersion operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateDocumentDefaultVersion.</param>
        /// 
        /// <returns>Returns a  UpdateDocumentDefaultVersionResult from SimpleSystemsManagement.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/UpdateDocumentDefaultVersion">REST API Reference for UpdateDocumentDefaultVersion Operation</seealso>
        public virtual UpdateDocumentDefaultVersionResponse EndUpdateDocumentDefaultVersion(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateDocumentDefaultVersionResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateDocumentMetadata

        /// <summary>
        /// Updates information related to approval reviews for a specific version of a change
        /// template in Change Manager.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDocumentMetadata service method.</param>
        /// 
        /// <returns>The response from the UpdateDocumentMetadata service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidDocumentException">
        /// The specified SSM document doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidDocumentOperationException">
        /// You attempted to delete a document while it is still shared. You must stop sharing
        /// the document before you can delete it.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidDocumentVersionException">
        /// The document version isn't valid or doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/UpdateDocumentMetadata">REST API Reference for UpdateDocumentMetadata Operation</seealso>
        public virtual UpdateDocumentMetadataResponse UpdateDocumentMetadata(UpdateDocumentMetadataRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateDocumentMetadataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDocumentMetadataResponseUnmarshaller.Instance;

            return Invoke<UpdateDocumentMetadataResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateDocumentMetadata operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateDocumentMetadata operation on AmazonSimpleSystemsManagementClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateDocumentMetadata
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/UpdateDocumentMetadata">REST API Reference for UpdateDocumentMetadata Operation</seealso>
        public virtual IAsyncResult BeginUpdateDocumentMetadata(UpdateDocumentMetadataRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateDocumentMetadataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDocumentMetadataResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateDocumentMetadata operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateDocumentMetadata.</param>
        /// 
        /// <returns>Returns a  UpdateDocumentMetadataResult from SimpleSystemsManagement.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/UpdateDocumentMetadata">REST API Reference for UpdateDocumentMetadata Operation</seealso>
        public virtual UpdateDocumentMetadataResponse EndUpdateDocumentMetadata(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateDocumentMetadataResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateMaintenanceWindow

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
        /// 
        /// <returns>The response from the UpdateMaintenanceWindow service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.DoesNotExistException">
        /// Error returned when the ID specified for a resource, such as a maintenance window
        /// or patch baseline, doesn't exist.
        /// 
        ///  
        /// <para>
        /// For information about resource quotas in Amazon Web Services Systems Manager, see
        /// <a href="https://docs.aws.amazon.com/general/latest/gr/ssm.html#limits_ssm">Systems
        /// Manager service quotas</a> in the <i>Amazon Web Services General Reference</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/UpdateMaintenanceWindow">REST API Reference for UpdateMaintenanceWindow Operation</seealso>
        public virtual UpdateMaintenanceWindowResponse UpdateMaintenanceWindow(UpdateMaintenanceWindowRequest request)
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
        /// <param name="request">Container for the necessary parameters to execute the UpdateMaintenanceWindow operation on AmazonSimpleSystemsManagementClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateMaintenanceWindow
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/UpdateMaintenanceWindow">REST API Reference for UpdateMaintenanceWindow Operation</seealso>
        public virtual IAsyncResult BeginUpdateMaintenanceWindow(UpdateMaintenanceWindowRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateMaintenanceWindowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateMaintenanceWindowResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateMaintenanceWindow operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateMaintenanceWindow.</param>
        /// 
        /// <returns>Returns a  UpdateMaintenanceWindowResult from SimpleSystemsManagement.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/UpdateMaintenanceWindow">REST API Reference for UpdateMaintenanceWindow Operation</seealso>
        public virtual UpdateMaintenanceWindowResponse EndUpdateMaintenanceWindow(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateMaintenanceWindowResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateMaintenanceWindowTarget

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
        /// If a parameter is null, then the corresponding field isn't modified.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateMaintenanceWindowTarget service method.</param>
        /// 
        /// <returns>The response from the UpdateMaintenanceWindowTarget service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.DoesNotExistException">
        /// Error returned when the ID specified for a resource, such as a maintenance window
        /// or patch baseline, doesn't exist.
        /// 
        ///  
        /// <para>
        /// For information about resource quotas in Amazon Web Services Systems Manager, see
        /// <a href="https://docs.aws.amazon.com/general/latest/gr/ssm.html#limits_ssm">Systems
        /// Manager service quotas</a> in the <i>Amazon Web Services General Reference</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/UpdateMaintenanceWindowTarget">REST API Reference for UpdateMaintenanceWindowTarget Operation</seealso>
        public virtual UpdateMaintenanceWindowTargetResponse UpdateMaintenanceWindowTarget(UpdateMaintenanceWindowTargetRequest request)
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
        /// <param name="request">Container for the necessary parameters to execute the UpdateMaintenanceWindowTarget operation on AmazonSimpleSystemsManagementClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateMaintenanceWindowTarget
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/UpdateMaintenanceWindowTarget">REST API Reference for UpdateMaintenanceWindowTarget Operation</seealso>
        public virtual IAsyncResult BeginUpdateMaintenanceWindowTarget(UpdateMaintenanceWindowTargetRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateMaintenanceWindowTargetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateMaintenanceWindowTargetResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateMaintenanceWindowTarget operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateMaintenanceWindowTarget.</param>
        /// 
        /// <returns>Returns a  UpdateMaintenanceWindowTargetResult from SimpleSystemsManagement.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/UpdateMaintenanceWindowTarget">REST API Reference for UpdateMaintenanceWindowTarget Operation</seealso>
        public virtual UpdateMaintenanceWindowTargetResponse EndUpdateMaintenanceWindowTarget(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateMaintenanceWindowTargetResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateMaintenanceWindowTask

        /// <summary>
        /// Modifies a task assigned to a maintenance window. You can't change the task type,
        /// but you can change the following values:
        /// 
        ///  <ul> <li> 
        /// <para>
        ///  <code>TaskARN</code>. For example, you can change a <code>RUN_COMMAND</code> task
        /// from <code>AWS-RunPowerShellScript</code> to <code>AWS-RunShellScript</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>ServiceRoleArn</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>TaskInvocationParameters</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Priority</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>MaxConcurrency</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>MaxErrors</code> 
        /// </para>
        ///  </li> </ul> <note> 
        /// <para>
        /// One or more targets must be specified for maintenance window Run Command-type tasks.
        /// Depending on the task, targets are optional for other maintenance window task types
        /// (Automation, Lambda, and Step Functions). For more information about running tasks
        /// that don't specify targets, see <a href="https://docs.aws.amazon.com/systems-manager/latest/userguide/maintenance-windows-targetless-tasks.html">Registering
        /// maintenance window tasks without targets</a> in the <i>Amazon Web Services Systems
        /// Manager User Guide</i>.
        /// </para>
        ///  </note> 
        /// <para>
        /// If the value for a parameter in <code>UpdateMaintenanceWindowTask</code> is null,
        /// then the corresponding field isn't modified. If you set <code>Replace</code> to true,
        /// then all fields required by the <a>RegisterTaskWithMaintenanceWindow</a> operation
        /// are required for this request. Optional fields that aren't specified are set to null.
        /// </para>
        ///  <important> 
        /// <para>
        /// When you update a maintenance window task that has options specified in <code>TaskInvocationParameters</code>,
        /// you must provide again all the <code>TaskInvocationParameters</code> values that you
        /// want to retain. The values you don't specify again are removed. For example, suppose
        /// that when you registered a Run Command task, you specified <code>TaskInvocationParameters</code>
        /// values for <code>Comment</code>, <code>NotificationConfig</code>, and <code>OutputS3BucketName</code>.
        /// If you update the maintenance window task and specify only a different <code>OutputS3BucketName</code>
        /// value, the values for <code>Comment</code> and <code>NotificationConfig</code> are
        /// removed.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateMaintenanceWindowTask service method.</param>
        /// 
        /// <returns>The response from the UpdateMaintenanceWindowTask service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.DoesNotExistException">
        /// Error returned when the ID specified for a resource, such as a maintenance window
        /// or patch baseline, doesn't exist.
        /// 
        ///  
        /// <para>
        /// For information about resource quotas in Amazon Web Services Systems Manager, see
        /// <a href="https://docs.aws.amazon.com/general/latest/gr/ssm.html#limits_ssm">Systems
        /// Manager service quotas</a> in the <i>Amazon Web Services General Reference</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/UpdateMaintenanceWindowTask">REST API Reference for UpdateMaintenanceWindowTask Operation</seealso>
        public virtual UpdateMaintenanceWindowTaskResponse UpdateMaintenanceWindowTask(UpdateMaintenanceWindowTaskRequest request)
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
        /// <param name="request">Container for the necessary parameters to execute the UpdateMaintenanceWindowTask operation on AmazonSimpleSystemsManagementClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateMaintenanceWindowTask
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/UpdateMaintenanceWindowTask">REST API Reference for UpdateMaintenanceWindowTask Operation</seealso>
        public virtual IAsyncResult BeginUpdateMaintenanceWindowTask(UpdateMaintenanceWindowTaskRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateMaintenanceWindowTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateMaintenanceWindowTaskResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateMaintenanceWindowTask operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateMaintenanceWindowTask.</param>
        /// 
        /// <returns>Returns a  UpdateMaintenanceWindowTaskResult from SimpleSystemsManagement.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/UpdateMaintenanceWindowTask">REST API Reference for UpdateMaintenanceWindowTask Operation</seealso>
        public virtual UpdateMaintenanceWindowTaskResponse EndUpdateMaintenanceWindowTask(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateMaintenanceWindowTaskResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateManagedInstanceRole

        /// <summary>
        /// Changes the Identity and Access Management (IAM) role that is assigned to the on-premises
        /// server, edge device, or virtual machines (VM). IAM roles are first assigned to these
        /// hybrid nodes during the activation process. For more information, see <a>CreateActivation</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateManagedInstanceRole service method.</param>
        /// 
        /// <returns>The response from the UpdateManagedInstanceRole service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidInstanceIdException">
        /// The following problems can cause this exception:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You don't have permission to access the managed node.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Amazon Web Services Systems Manager Agent(SSM Agent) isn't running. Verify that SSM
        /// Agent is running.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// SSM Agent isn't registered with the SSM endpoint. Try reinstalling SSM Agent.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The managed node isn't in valid state. Valid states are: <code>Running</code>, <code>Pending</code>,
        /// <code>Stopped</code>, and <code>Stopping</code>. Invalid states are: <code>Shutting-down</code>
        /// and <code>Terminated</code>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/UpdateManagedInstanceRole">REST API Reference for UpdateManagedInstanceRole Operation</seealso>
        public virtual UpdateManagedInstanceRoleResponse UpdateManagedInstanceRole(UpdateManagedInstanceRoleRequest request)
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
        /// <param name="request">Container for the necessary parameters to execute the UpdateManagedInstanceRole operation on AmazonSimpleSystemsManagementClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateManagedInstanceRole
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/UpdateManagedInstanceRole">REST API Reference for UpdateManagedInstanceRole Operation</seealso>
        public virtual IAsyncResult BeginUpdateManagedInstanceRole(UpdateManagedInstanceRoleRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateManagedInstanceRoleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateManagedInstanceRoleResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateManagedInstanceRole operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateManagedInstanceRole.</param>
        /// 
        /// <returns>Returns a  UpdateManagedInstanceRoleResult from SimpleSystemsManagement.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/UpdateManagedInstanceRole">REST API Reference for UpdateManagedInstanceRole Operation</seealso>
        public virtual UpdateManagedInstanceRoleResponse EndUpdateManagedInstanceRole(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateManagedInstanceRoleResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateOpsItem

        /// <summary>
        /// Edit or change an OpsItem. You must have permission in Identity and Access Management
        /// (IAM) to update an OpsItem. For more information, see <a href="https://docs.aws.amazon.com/systems-manager/latest/userguide/OpsCenter-getting-started.html">Getting
        /// started with OpsCenter</a> in the <i>Amazon Web Services Systems Manager User Guide</i>.
        /// 
        ///  
        /// <para>
        /// Operations engineers and IT professionals use Amazon Web Services Systems Manager
        /// OpsCenter to view, investigate, and remediate operational issues impacting the performance
        /// and health of their Amazon Web Services resources. For more information, see <a href="https://docs.aws.amazon.com/systems-manager/latest/userguide/OpsCenter.html">OpsCenter</a>
        /// in the <i>Amazon Web Services Systems Manager User Guide</i>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateOpsItem service method.</param>
        /// 
        /// <returns>The response from the UpdateOpsItem service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.OpsItemAccessDeniedException">
        /// You don't have permission to view OpsItems in the specified account. Verify that your
        /// account is configured either as a Systems Manager delegated administrator or that
        /// you are logged into the Organizations management account.
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
        public virtual UpdateOpsItemResponse UpdateOpsItem(UpdateOpsItemRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateOpsItemRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateOpsItemResponseUnmarshaller.Instance;

            return Invoke<UpdateOpsItemResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateOpsItem operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateOpsItem operation on AmazonSimpleSystemsManagementClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateOpsItem
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/UpdateOpsItem">REST API Reference for UpdateOpsItem Operation</seealso>
        public virtual IAsyncResult BeginUpdateOpsItem(UpdateOpsItemRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateOpsItemRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateOpsItemResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateOpsItem operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateOpsItem.</param>
        /// 
        /// <returns>Returns a  UpdateOpsItemResult from SimpleSystemsManagement.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/UpdateOpsItem">REST API Reference for UpdateOpsItem Operation</seealso>
        public virtual UpdateOpsItemResponse EndUpdateOpsItem(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateOpsItemResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateOpsMetadata

        /// <summary>
        /// Amazon Web Services Systems Manager calls this API operation when you edit OpsMetadata
        /// in Application Manager.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateOpsMetadata service method.</param>
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
        /// The OpsMetadata object doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.OpsMetadataTooManyUpdatesException">
        /// The system is processing too many concurrent updates. Wait a few moments and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/UpdateOpsMetadata">REST API Reference for UpdateOpsMetadata Operation</seealso>
        public virtual UpdateOpsMetadataResponse UpdateOpsMetadata(UpdateOpsMetadataRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateOpsMetadataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateOpsMetadataResponseUnmarshaller.Instance;

            return Invoke<UpdateOpsMetadataResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateOpsMetadata operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateOpsMetadata operation on AmazonSimpleSystemsManagementClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateOpsMetadata
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/UpdateOpsMetadata">REST API Reference for UpdateOpsMetadata Operation</seealso>
        public virtual IAsyncResult BeginUpdateOpsMetadata(UpdateOpsMetadataRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateOpsMetadataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateOpsMetadataResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateOpsMetadata operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateOpsMetadata.</param>
        /// 
        /// <returns>Returns a  UpdateOpsMetadataResult from SimpleSystemsManagement.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/UpdateOpsMetadata">REST API Reference for UpdateOpsMetadata Operation</seealso>
        public virtual UpdateOpsMetadataResponse EndUpdateOpsMetadata(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateOpsMetadataResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdatePatchBaseline

        /// <summary>
        /// Modifies an existing patch baseline. Fields not specified in the request are left
        /// unchanged.
        /// 
        ///  <note> 
        /// <para>
        /// For information about valid key-value pairs in <code>PatchFilters</code> for each
        /// supported operating system type, see <a>PatchFilter</a>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdatePatchBaseline service method.</param>
        /// 
        /// <returns>The response from the UpdatePatchBaseline service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.DoesNotExistException">
        /// Error returned when the ID specified for a resource, such as a maintenance window
        /// or patch baseline, doesn't exist.
        /// 
        ///  
        /// <para>
        /// For information about resource quotas in Amazon Web Services Systems Manager, see
        /// <a href="https://docs.aws.amazon.com/general/latest/gr/ssm.html#limits_ssm">Systems
        /// Manager service quotas</a> in the <i>Amazon Web Services General Reference</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/UpdatePatchBaseline">REST API Reference for UpdatePatchBaseline Operation</seealso>
        public virtual UpdatePatchBaselineResponse UpdatePatchBaseline(UpdatePatchBaselineRequest request)
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
        /// <param name="request">Container for the necessary parameters to execute the UpdatePatchBaseline operation on AmazonSimpleSystemsManagementClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdatePatchBaseline
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/UpdatePatchBaseline">REST API Reference for UpdatePatchBaseline Operation</seealso>
        public virtual IAsyncResult BeginUpdatePatchBaseline(UpdatePatchBaselineRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdatePatchBaselineRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdatePatchBaselineResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdatePatchBaseline operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdatePatchBaseline.</param>
        /// 
        /// <returns>Returns a  UpdatePatchBaselineResult from SimpleSystemsManagement.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/UpdatePatchBaseline">REST API Reference for UpdatePatchBaseline Operation</seealso>
        public virtual UpdatePatchBaselineResponse EndUpdatePatchBaseline(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdatePatchBaselineResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateResourceDataSync

        /// <summary>
        /// Update a resource data sync. After you create a resource data sync for a Region, you
        /// can't change the account options for that sync. For example, if you create a sync
        /// in the us-east-2 (Ohio) Region and you choose the <code>Include only the current account</code>
        /// option, you can't edit that sync later and choose the <code>Include all accounts from
        /// my Organizations configuration</code> option. Instead, you must delete the first resource
        /// data sync, and create a new one.
        /// 
        ///  <note> 
        /// <para>
        /// This API operation only supports a resource data sync that was created with a SyncFromSource
        /// <code>SyncType</code>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateResourceDataSync service method.</param>
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
        /// The specified sync name wasn't found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/UpdateResourceDataSync">REST API Reference for UpdateResourceDataSync Operation</seealso>
        public virtual UpdateResourceDataSyncResponse UpdateResourceDataSync(UpdateResourceDataSyncRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateResourceDataSyncRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateResourceDataSyncResponseUnmarshaller.Instance;

            return Invoke<UpdateResourceDataSyncResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateResourceDataSync operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateResourceDataSync operation on AmazonSimpleSystemsManagementClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateResourceDataSync
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/UpdateResourceDataSync">REST API Reference for UpdateResourceDataSync Operation</seealso>
        public virtual IAsyncResult BeginUpdateResourceDataSync(UpdateResourceDataSyncRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateResourceDataSyncRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateResourceDataSyncResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateResourceDataSync operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateResourceDataSync.</param>
        /// 
        /// <returns>Returns a  UpdateResourceDataSyncResult from SimpleSystemsManagement.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/UpdateResourceDataSync">REST API Reference for UpdateResourceDataSync Operation</seealso>
        public virtual UpdateResourceDataSyncResponse EndUpdateResourceDataSync(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateResourceDataSyncResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateServiceSetting

        /// <summary>
        /// <code>ServiceSetting</code> is an account-level setting for an Amazon Web Services
        /// service. This setting defines how a user interacts with or uses a service or a feature
        /// of a service. For example, if an Amazon Web Services service charges money to the
        /// account based on feature or service usage, then the Amazon Web Services service team
        /// might create a default setting of "false". This means the user can't use this feature
        /// unless they change the setting to "true" and intentionally opt in for a paid feature.
        /// 
        ///  
        /// <para>
        /// Services map a <code>SettingId</code> object to a setting value. Amazon Web Services
        /// services teams define the default value for a <code>SettingId</code>. You can't create
        /// a new <code>SettingId</code>, but you can overwrite the default value if you have
        /// the <code>ssm:UpdateServiceSetting</code> permission for the setting. Use the <a>GetServiceSetting</a>
        /// API operation to view the current value. Or, use the <a>ResetServiceSetting</a> to
        /// change the value back to the original value defined by the Amazon Web Services service
        /// team.
        /// </para>
        ///  
        /// <para>
        /// Update the service setting for the account. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateServiceSetting service method.</param>
        /// 
        /// <returns>The response from the UpdateServiceSetting service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.ServiceSettingNotFoundException">
        /// The specified service setting wasn't found. Either the service name or the setting
        /// hasn't been provisioned by the Amazon Web Services service team.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.TooManyUpdatesException">
        /// There are concurrent updates for a resource that supports one update at a time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/UpdateServiceSetting">REST API Reference for UpdateServiceSetting Operation</seealso>
        public virtual UpdateServiceSettingResponse UpdateServiceSetting(UpdateServiceSettingRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateServiceSettingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateServiceSettingResponseUnmarshaller.Instance;

            return Invoke<UpdateServiceSettingResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateServiceSetting operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateServiceSetting operation on AmazonSimpleSystemsManagementClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateServiceSetting
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/UpdateServiceSetting">REST API Reference for UpdateServiceSetting Operation</seealso>
        public virtual IAsyncResult BeginUpdateServiceSetting(UpdateServiceSettingRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateServiceSettingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateServiceSettingResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateServiceSetting operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateServiceSetting.</param>
        /// 
        /// <returns>Returns a  UpdateServiceSettingResult from SimpleSystemsManagement.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/UpdateServiceSetting">REST API Reference for UpdateServiceSetting Operation</seealso>
        public virtual UpdateServiceSettingResponse EndUpdateServiceSetting(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateServiceSettingResponse>(asyncResult);
        }

        #endregion
        
    }
}