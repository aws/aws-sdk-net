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
 * Do not modify this file. This file is generated from the workspaces-2015-04-08.normal.json service model.
 */


using System;
using System.Collections.Generic;
using System.Net;

using Amazon.WorkSpaces.Model;
using Amazon.WorkSpaces.Model.Internal.MarshallTransformations;
using Amazon.WorkSpaces.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

#pragma warning disable CS1570
namespace Amazon.WorkSpaces
{
    /// <summary>
    /// <para>Implementation for accessing WorkSpaces</para>
    ///
    /// Amazon WorkSpaces Service 
    /// <para>
    /// Amazon WorkSpaces enables you to provision virtual, cloud-based Microsoft Windows
    /// or Amazon Linux desktops for your users, known as <i>WorkSpaces</i>. WorkSpaces eliminates
    /// the need to procure and deploy hardware or install complex software. You can quickly
    /// add or remove users as your needs change. Users can access their virtual desktops
    /// from multiple devices or web browsers.
    /// </para>
    ///  
    /// <para>
    /// This API Reference provides detailed information about the actions, data types, parameters,
    /// and errors of the WorkSpaces service. For more information about the supported Amazon
    /// Web Services Regions, endpoints, and service quotas of the Amazon WorkSpaces service,
    /// see <a href="https://docs.aws.amazon.com/general/latest/gr/wsp.html">WorkSpaces endpoints
    /// and quotas</a> in the <i>Amazon Web Services General Reference</i>.
    /// </para>
    ///  
    /// <para>
    /// You can also manage your WorkSpaces resources using the WorkSpaces console, Command
    /// Line Interface (CLI), and SDKs. For more information about administering WorkSpaces,
    /// see the <a href="https://docs.aws.amazon.com/workspaces/latest/adminguide/">Amazon
    /// WorkSpaces Administration Guide</a>. For more information about using the Amazon WorkSpaces
    /// client application or web browser to access provisioned WorkSpaces, see the <a href="https://docs.aws.amazon.com/workspaces/latest/userguide/">Amazon
    /// WorkSpaces User Guide</a>. For more information about using the CLI to manage your
    /// WorkSpaces resources, see the <a href="https://docs.aws.amazon.com/cli/latest/reference/workspaces/index.html">WorkSpaces
    /// section of the CLI Reference</a>.
    /// </para>
    /// </summary>
    public partial class AmazonWorkSpacesClient : AmazonServiceClient, IAmazonWorkSpaces
    {
        private static IServiceMetadata serviceMetadata = new AmazonWorkSpacesMetadata();

#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        private IWorkSpacesPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IWorkSpacesPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new WorkSpacesPaginatorFactory(this);
                }
                return this._paginators;
            }
        }
#endif
        #region Constructors

        /// <summary>
        /// Constructs AmazonWorkSpacesClient with the credentials loaded from the application's
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
        public AmazonWorkSpacesClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonWorkSpacesConfig()) { }

        /// <summary>
        /// Constructs AmazonWorkSpacesClient with the credentials loaded from the application's
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
        public AmazonWorkSpacesClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonWorkSpacesConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonWorkSpacesClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonWorkSpacesClient Configuration Object</param>
        public AmazonWorkSpacesClient(AmazonWorkSpacesConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(config), config){}
        /// <summary>
        /// Constructs AmazonWorkSpacesClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonWorkSpacesClient(AWSCredentials credentials)
            : this(credentials, new AmazonWorkSpacesConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonWorkSpacesClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonWorkSpacesClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonWorkSpacesConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonWorkSpacesClient with AWS Credentials and an
        /// AmazonWorkSpacesClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonWorkSpacesClient Configuration Object</param>
        public AmazonWorkSpacesClient(AWSCredentials credentials, AmazonWorkSpacesConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonWorkSpacesClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonWorkSpacesClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonWorkSpacesConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonWorkSpacesClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonWorkSpacesClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonWorkSpacesConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonWorkSpacesClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonWorkSpacesClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonWorkSpacesClient Configuration Object</param>
        public AmazonWorkSpacesClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonWorkSpacesConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonWorkSpacesClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonWorkSpacesClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonWorkSpacesConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonWorkSpacesClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonWorkSpacesClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonWorkSpacesConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonWorkSpacesClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonWorkSpacesClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonWorkSpacesClient Configuration Object</param>
        public AmazonWorkSpacesClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonWorkSpacesConfig clientConfig)
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
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonWorkSpacesEndpointResolver());
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


        #region  AcceptAccountLinkInvitation

        /// <summary>
        /// Accepts the account link invitation.
        /// 
        ///  <important> 
        /// <para>
        /// There's currently no unlinking capability after you accept the account linking invitation.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AcceptAccountLinkInvitation service method.</param>
        /// 
        /// <returns>The response from the AcceptAccountLinkInvitation service method, as returned by WorkSpaces.</returns>
        /// <exception cref="Amazon.WorkSpaces.Model.AccessDeniedException">
        /// The user is not authorized to access a resource.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.ConflictException">
        /// The <c>TargetAccountId</c> is already linked or invited.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.InternalServerException">
        /// Unexpected server error occured.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.ValidationException">
        /// You either haven't provided a <c>TargetAccountId</c> or are using the same value for
        /// <c>TargetAccountId</c> and <c>SourceAccountId</c>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/AcceptAccountLinkInvitation">REST API Reference for AcceptAccountLinkInvitation Operation</seealso>
        public virtual AcceptAccountLinkInvitationResponse AcceptAccountLinkInvitation(AcceptAccountLinkInvitationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AcceptAccountLinkInvitationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AcceptAccountLinkInvitationResponseUnmarshaller.Instance;

            return Invoke<AcceptAccountLinkInvitationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AcceptAccountLinkInvitation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AcceptAccountLinkInvitation operation on AmazonWorkSpacesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAcceptAccountLinkInvitation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/AcceptAccountLinkInvitation">REST API Reference for AcceptAccountLinkInvitation Operation</seealso>
        public virtual IAsyncResult BeginAcceptAccountLinkInvitation(AcceptAccountLinkInvitationRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AcceptAccountLinkInvitationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AcceptAccountLinkInvitationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AcceptAccountLinkInvitation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAcceptAccountLinkInvitation.</param>
        /// 
        /// <returns>Returns a  AcceptAccountLinkInvitationResult from WorkSpaces.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/AcceptAccountLinkInvitation">REST API Reference for AcceptAccountLinkInvitation Operation</seealso>
        public virtual AcceptAccountLinkInvitationResponse EndAcceptAccountLinkInvitation(IAsyncResult asyncResult)
        {
            return EndInvoke<AcceptAccountLinkInvitationResponse>(asyncResult);
        }

        #endregion
        
        #region  AssociateConnectionAlias

        /// <summary>
        /// Associates the specified connection alias with the specified directory to enable cross-Region
        /// redirection. For more information, see <a href="https://docs.aws.amazon.com/workspaces/latest/adminguide/cross-region-redirection.html">
        /// Cross-Region Redirection for Amazon WorkSpaces</a>.
        /// 
        ///  <note> 
        /// <para>
        /// Before performing this operation, call <a href="https://docs.aws.amazon.com/workspaces/latest/api/API_DescribeConnectionAliases.html">
        /// DescribeConnectionAliases</a> to make sure that the current state of the connection
        /// alias is <c>CREATED</c>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateConnectionAlias service method.</param>
        /// 
        /// <returns>The response from the AssociateConnectionAlias service method, as returned by WorkSpaces.</returns>
        /// <exception cref="Amazon.WorkSpaces.Model.AccessDeniedException">
        /// The user is not authorized to access a resource.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.InvalidParameterValuesException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.InvalidResourceStateException">
        /// The state of the resource is not valid for this operation.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.OperationNotSupportedException">
        /// This operation is not supported.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.ResourceAssociatedException">
        /// The resource is associated with a directory.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/AssociateConnectionAlias">REST API Reference for AssociateConnectionAlias Operation</seealso>
        public virtual AssociateConnectionAliasResponse AssociateConnectionAlias(AssociateConnectionAliasRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AssociateConnectionAliasRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateConnectionAliasResponseUnmarshaller.Instance;

            return Invoke<AssociateConnectionAliasResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AssociateConnectionAlias operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateConnectionAlias operation on AmazonWorkSpacesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAssociateConnectionAlias
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/AssociateConnectionAlias">REST API Reference for AssociateConnectionAlias Operation</seealso>
        public virtual IAsyncResult BeginAssociateConnectionAlias(AssociateConnectionAliasRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AssociateConnectionAliasRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateConnectionAliasResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AssociateConnectionAlias operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssociateConnectionAlias.</param>
        /// 
        /// <returns>Returns a  AssociateConnectionAliasResult from WorkSpaces.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/AssociateConnectionAlias">REST API Reference for AssociateConnectionAlias Operation</seealso>
        public virtual AssociateConnectionAliasResponse EndAssociateConnectionAlias(IAsyncResult asyncResult)
        {
            return EndInvoke<AssociateConnectionAliasResponse>(asyncResult);
        }

        #endregion
        
        #region  AssociateIpGroups

        /// <summary>
        /// Associates the specified IP access control group with the specified directory.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateIpGroups service method.</param>
        /// 
        /// <returns>The response from the AssociateIpGroups service method, as returned by WorkSpaces.</returns>
        /// <exception cref="Amazon.WorkSpaces.Model.AccessDeniedException">
        /// The user is not authorized to access a resource.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.InvalidParameterValuesException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.InvalidResourceStateException">
        /// The state of the resource is not valid for this operation.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.OperationNotSupportedException">
        /// This operation is not supported.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.ResourceLimitExceededException">
        /// Your resource limits have been exceeded.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/AssociateIpGroups">REST API Reference for AssociateIpGroups Operation</seealso>
        public virtual AssociateIpGroupsResponse AssociateIpGroups(AssociateIpGroupsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AssociateIpGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateIpGroupsResponseUnmarshaller.Instance;

            return Invoke<AssociateIpGroupsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AssociateIpGroups operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateIpGroups operation on AmazonWorkSpacesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAssociateIpGroups
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/AssociateIpGroups">REST API Reference for AssociateIpGroups Operation</seealso>
        public virtual IAsyncResult BeginAssociateIpGroups(AssociateIpGroupsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AssociateIpGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateIpGroupsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AssociateIpGroups operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssociateIpGroups.</param>
        /// 
        /// <returns>Returns a  AssociateIpGroupsResult from WorkSpaces.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/AssociateIpGroups">REST API Reference for AssociateIpGroups Operation</seealso>
        public virtual AssociateIpGroupsResponse EndAssociateIpGroups(IAsyncResult asyncResult)
        {
            return EndInvoke<AssociateIpGroupsResponse>(asyncResult);
        }

        #endregion
        
        #region  AssociateWorkspaceApplication

        /// <summary>
        /// Associates the specified application to the specified WorkSpace.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateWorkspaceApplication service method.</param>
        /// 
        /// <returns>The response from the AssociateWorkspaceApplication service method, as returned by WorkSpaces.</returns>
        /// <exception cref="Amazon.WorkSpaces.Model.AccessDeniedException">
        /// The user is not authorized to access a resource.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.ApplicationNotSupportedException">
        /// The specified application is not supported.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.ComputeNotCompatibleException">
        /// The compute type of the WorkSpace is not compatible with the application.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.IncompatibleApplicationsException">
        /// The specified application is not compatible with the resource.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.InvalidParameterValuesException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.OperatingSystemNotCompatibleException">
        /// The operating system of the WorkSpace is not compatible with the application.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.OperationNotSupportedException">
        /// This operation is not supported.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.ResourceAlreadyExistsException">
        /// The specified resource already exists.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.ResourceInUseException">
        /// The specified resource is currently in use.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/AssociateWorkspaceApplication">REST API Reference for AssociateWorkspaceApplication Operation</seealso>
        public virtual AssociateWorkspaceApplicationResponse AssociateWorkspaceApplication(AssociateWorkspaceApplicationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AssociateWorkspaceApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateWorkspaceApplicationResponseUnmarshaller.Instance;

            return Invoke<AssociateWorkspaceApplicationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AssociateWorkspaceApplication operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateWorkspaceApplication operation on AmazonWorkSpacesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAssociateWorkspaceApplication
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/AssociateWorkspaceApplication">REST API Reference for AssociateWorkspaceApplication Operation</seealso>
        public virtual IAsyncResult BeginAssociateWorkspaceApplication(AssociateWorkspaceApplicationRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AssociateWorkspaceApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateWorkspaceApplicationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AssociateWorkspaceApplication operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssociateWorkspaceApplication.</param>
        /// 
        /// <returns>Returns a  AssociateWorkspaceApplicationResult from WorkSpaces.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/AssociateWorkspaceApplication">REST API Reference for AssociateWorkspaceApplication Operation</seealso>
        public virtual AssociateWorkspaceApplicationResponse EndAssociateWorkspaceApplication(IAsyncResult asyncResult)
        {
            return EndInvoke<AssociateWorkspaceApplicationResponse>(asyncResult);
        }

        #endregion
        
        #region  AuthorizeIpRules

        /// <summary>
        /// Adds one or more rules to the specified IP access control group.
        /// 
        ///  
        /// <para>
        /// This action gives users permission to access their WorkSpaces from the CIDR address
        /// ranges specified in the rules.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AuthorizeIpRules service method.</param>
        /// 
        /// <returns>The response from the AuthorizeIpRules service method, as returned by WorkSpaces.</returns>
        /// <exception cref="Amazon.WorkSpaces.Model.AccessDeniedException">
        /// The user is not authorized to access a resource.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.InvalidParameterValuesException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.InvalidResourceStateException">
        /// The state of the resource is not valid for this operation.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.ResourceLimitExceededException">
        /// Your resource limits have been exceeded.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/AuthorizeIpRules">REST API Reference for AuthorizeIpRules Operation</seealso>
        public virtual AuthorizeIpRulesResponse AuthorizeIpRules(AuthorizeIpRulesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AuthorizeIpRulesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AuthorizeIpRulesResponseUnmarshaller.Instance;

            return Invoke<AuthorizeIpRulesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AuthorizeIpRules operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AuthorizeIpRules operation on AmazonWorkSpacesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAuthorizeIpRules
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/AuthorizeIpRules">REST API Reference for AuthorizeIpRules Operation</seealso>
        public virtual IAsyncResult BeginAuthorizeIpRules(AuthorizeIpRulesRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AuthorizeIpRulesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AuthorizeIpRulesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AuthorizeIpRules operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAuthorizeIpRules.</param>
        /// 
        /// <returns>Returns a  AuthorizeIpRulesResult from WorkSpaces.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/AuthorizeIpRules">REST API Reference for AuthorizeIpRules Operation</seealso>
        public virtual AuthorizeIpRulesResponse EndAuthorizeIpRules(IAsyncResult asyncResult)
        {
            return EndInvoke<AuthorizeIpRulesResponse>(asyncResult);
        }

        #endregion
        
        #region  CopyWorkspaceImage

        /// <summary>
        /// Copies the specified image from the specified Region to the current Region. For more
        /// information about copying images, see <a href="https://docs.aws.amazon.com/workspaces/latest/adminguide/copy-custom-image.html">
        /// Copy a Custom WorkSpaces Image</a>.
        /// 
        ///  
        /// <para>
        /// In the China (Ningxia) Region, you can copy images only within the same Region.
        /// </para>
        ///  
        /// <para>
        /// In Amazon Web Services GovCloud (US), to copy images to and from other Regions, contact
        /// Amazon Web Services Support.
        /// </para>
        ///  <important> 
        /// <para>
        /// Before copying a shared image, be sure to verify that it has been shared from the
        /// correct Amazon Web Services account. To determine if an image has been shared and
        /// to see the ID of the Amazon Web Services account that owns an image, use the <a href="https://docs.aws.amazon.com/workspaces/latest/api/API_DescribeWorkspaceImages.html">DescribeWorkSpaceImages</a>
        /// and <a href="https://docs.aws.amazon.com/workspaces/latest/api/API_DescribeWorkspaceImagePermissions.html">DescribeWorkspaceImagePermissions</a>
        /// API operations. 
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CopyWorkspaceImage service method.</param>
        /// 
        /// <returns>The response from the CopyWorkspaceImage service method, as returned by WorkSpaces.</returns>
        /// <exception cref="Amazon.WorkSpaces.Model.AccessDeniedException">
        /// The user is not authorized to access a resource.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.InvalidParameterValuesException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.OperationNotSupportedException">
        /// This operation is not supported.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.ResourceAlreadyExistsException">
        /// The specified resource already exists.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.ResourceLimitExceededException">
        /// Your resource limits have been exceeded.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.ResourceUnavailableException">
        /// The specified resource is not available.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/CopyWorkspaceImage">REST API Reference for CopyWorkspaceImage Operation</seealso>
        public virtual CopyWorkspaceImageResponse CopyWorkspaceImage(CopyWorkspaceImageRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CopyWorkspaceImageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CopyWorkspaceImageResponseUnmarshaller.Instance;

            return Invoke<CopyWorkspaceImageResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CopyWorkspaceImage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CopyWorkspaceImage operation on AmazonWorkSpacesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCopyWorkspaceImage
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/CopyWorkspaceImage">REST API Reference for CopyWorkspaceImage Operation</seealso>
        public virtual IAsyncResult BeginCopyWorkspaceImage(CopyWorkspaceImageRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CopyWorkspaceImageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CopyWorkspaceImageResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CopyWorkspaceImage operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCopyWorkspaceImage.</param>
        /// 
        /// <returns>Returns a  CopyWorkspaceImageResult from WorkSpaces.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/CopyWorkspaceImage">REST API Reference for CopyWorkspaceImage Operation</seealso>
        public virtual CopyWorkspaceImageResponse EndCopyWorkspaceImage(IAsyncResult asyncResult)
        {
            return EndInvoke<CopyWorkspaceImageResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateAccountLinkInvitation

        /// <summary>
        /// Creates the account link invitation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAccountLinkInvitation service method.</param>
        /// 
        /// <returns>The response from the CreateAccountLinkInvitation service method, as returned by WorkSpaces.</returns>
        /// <exception cref="Amazon.WorkSpaces.Model.AccessDeniedException">
        /// The user is not authorized to access a resource.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.ConflictException">
        /// The <c>TargetAccountId</c> is already linked or invited.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.InternalServerException">
        /// Unexpected server error occured.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.ValidationException">
        /// You either haven't provided a <c>TargetAccountId</c> or are using the same value for
        /// <c>TargetAccountId</c> and <c>SourceAccountId</c>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/CreateAccountLinkInvitation">REST API Reference for CreateAccountLinkInvitation Operation</seealso>
        public virtual CreateAccountLinkInvitationResponse CreateAccountLinkInvitation(CreateAccountLinkInvitationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateAccountLinkInvitationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAccountLinkInvitationResponseUnmarshaller.Instance;

            return Invoke<CreateAccountLinkInvitationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateAccountLinkInvitation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateAccountLinkInvitation operation on AmazonWorkSpacesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateAccountLinkInvitation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/CreateAccountLinkInvitation">REST API Reference for CreateAccountLinkInvitation Operation</seealso>
        public virtual IAsyncResult BeginCreateAccountLinkInvitation(CreateAccountLinkInvitationRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateAccountLinkInvitationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAccountLinkInvitationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateAccountLinkInvitation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateAccountLinkInvitation.</param>
        /// 
        /// <returns>Returns a  CreateAccountLinkInvitationResult from WorkSpaces.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/CreateAccountLinkInvitation">REST API Reference for CreateAccountLinkInvitation Operation</seealso>
        public virtual CreateAccountLinkInvitationResponse EndCreateAccountLinkInvitation(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateAccountLinkInvitationResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateConnectClientAddIn

        /// <summary>
        /// Creates a client-add-in for Amazon Connect within a directory. You can create only
        /// one Amazon Connect client add-in within a directory.
        /// 
        ///  
        /// <para>
        /// This client add-in allows WorkSpaces users to seamlessly connect to Amazon Connect.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateConnectClientAddIn service method.</param>
        /// 
        /// <returns>The response from the CreateConnectClientAddIn service method, as returned by WorkSpaces.</returns>
        /// <exception cref="Amazon.WorkSpaces.Model.AccessDeniedException">
        /// The user is not authorized to access a resource.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.InvalidParameterValuesException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.ResourceAlreadyExistsException">
        /// The specified resource already exists.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.ResourceCreationFailedException">
        /// The resource could not be created.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/CreateConnectClientAddIn">REST API Reference for CreateConnectClientAddIn Operation</seealso>
        public virtual CreateConnectClientAddInResponse CreateConnectClientAddIn(CreateConnectClientAddInRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateConnectClientAddInRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateConnectClientAddInResponseUnmarshaller.Instance;

            return Invoke<CreateConnectClientAddInResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateConnectClientAddIn operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateConnectClientAddIn operation on AmazonWorkSpacesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateConnectClientAddIn
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/CreateConnectClientAddIn">REST API Reference for CreateConnectClientAddIn Operation</seealso>
        public virtual IAsyncResult BeginCreateConnectClientAddIn(CreateConnectClientAddInRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateConnectClientAddInRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateConnectClientAddInResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateConnectClientAddIn operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateConnectClientAddIn.</param>
        /// 
        /// <returns>Returns a  CreateConnectClientAddInResult from WorkSpaces.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/CreateConnectClientAddIn">REST API Reference for CreateConnectClientAddIn Operation</seealso>
        public virtual CreateConnectClientAddInResponse EndCreateConnectClientAddIn(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateConnectClientAddInResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateConnectionAlias

        /// <summary>
        /// Creates the specified connection alias for use with cross-Region redirection. For
        /// more information, see <a href="https://docs.aws.amazon.com/workspaces/latest/adminguide/cross-region-redirection.html">
        /// Cross-Region Redirection for Amazon WorkSpaces</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateConnectionAlias service method.</param>
        /// 
        /// <returns>The response from the CreateConnectionAlias service method, as returned by WorkSpaces.</returns>
        /// <exception cref="Amazon.WorkSpaces.Model.AccessDeniedException">
        /// The user is not authorized to access a resource.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.InvalidParameterValuesException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.InvalidResourceStateException">
        /// The state of the resource is not valid for this operation.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.OperationNotSupportedException">
        /// This operation is not supported.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.ResourceAlreadyExistsException">
        /// The specified resource already exists.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.ResourceLimitExceededException">
        /// Your resource limits have been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/CreateConnectionAlias">REST API Reference for CreateConnectionAlias Operation</seealso>
        public virtual CreateConnectionAliasResponse CreateConnectionAlias(CreateConnectionAliasRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateConnectionAliasRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateConnectionAliasResponseUnmarshaller.Instance;

            return Invoke<CreateConnectionAliasResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateConnectionAlias operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateConnectionAlias operation on AmazonWorkSpacesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateConnectionAlias
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/CreateConnectionAlias">REST API Reference for CreateConnectionAlias Operation</seealso>
        public virtual IAsyncResult BeginCreateConnectionAlias(CreateConnectionAliasRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateConnectionAliasRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateConnectionAliasResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateConnectionAlias operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateConnectionAlias.</param>
        /// 
        /// <returns>Returns a  CreateConnectionAliasResult from WorkSpaces.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/CreateConnectionAlias">REST API Reference for CreateConnectionAlias Operation</seealso>
        public virtual CreateConnectionAliasResponse EndCreateConnectionAlias(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateConnectionAliasResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateIpGroup

        /// <summary>
        /// Creates an IP access control group.
        /// 
        ///  
        /// <para>
        /// An IP access control group provides you with the ability to control the IP addresses
        /// from which users are allowed to access their WorkSpaces. To specify the CIDR address
        /// ranges, add rules to your IP access control group and then associate the group with
        /// your directory. You can add rules when you create the group or at any time using <a>AuthorizeIpRules</a>.
        /// </para>
        ///  
        /// <para>
        /// There is a default IP access control group associated with your directory. If you
        /// don't associate an IP access control group with your directory, the default group
        /// is used. The default group includes a default rule that allows users to access their
        /// WorkSpaces from anywhere. You cannot modify the default IP access control group for
        /// your directory.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateIpGroup service method.</param>
        /// 
        /// <returns>The response from the CreateIpGroup service method, as returned by WorkSpaces.</returns>
        /// <exception cref="Amazon.WorkSpaces.Model.AccessDeniedException">
        /// The user is not authorized to access a resource.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.InvalidParameterValuesException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.ResourceAlreadyExistsException">
        /// The specified resource already exists.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.ResourceCreationFailedException">
        /// The resource could not be created.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.ResourceLimitExceededException">
        /// Your resource limits have been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/CreateIpGroup">REST API Reference for CreateIpGroup Operation</seealso>
        public virtual CreateIpGroupResponse CreateIpGroup(CreateIpGroupRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateIpGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateIpGroupResponseUnmarshaller.Instance;

            return Invoke<CreateIpGroupResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateIpGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateIpGroup operation on AmazonWorkSpacesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateIpGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/CreateIpGroup">REST API Reference for CreateIpGroup Operation</seealso>
        public virtual IAsyncResult BeginCreateIpGroup(CreateIpGroupRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateIpGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateIpGroupResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateIpGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateIpGroup.</param>
        /// 
        /// <returns>Returns a  CreateIpGroupResult from WorkSpaces.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/CreateIpGroup">REST API Reference for CreateIpGroup Operation</seealso>
        public virtual CreateIpGroupResponse EndCreateIpGroup(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateIpGroupResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateStandbyWorkspaces

        /// <summary>
        /// Creates a standby WorkSpace in a secondary Region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateStandbyWorkspaces service method.</param>
        /// 
        /// <returns>The response from the CreateStandbyWorkspaces service method, as returned by WorkSpaces.</returns>
        /// <exception cref="Amazon.WorkSpaces.Model.AccessDeniedException">
        /// The user is not authorized to access a resource.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.InvalidParameterValuesException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.OperationNotSupportedException">
        /// This operation is not supported.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.ResourceLimitExceededException">
        /// Your resource limits have been exceeded.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/CreateStandbyWorkspaces">REST API Reference for CreateStandbyWorkspaces Operation</seealso>
        public virtual CreateStandbyWorkspacesResponse CreateStandbyWorkspaces(CreateStandbyWorkspacesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateStandbyWorkspacesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateStandbyWorkspacesResponseUnmarshaller.Instance;

            return Invoke<CreateStandbyWorkspacesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateStandbyWorkspaces operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateStandbyWorkspaces operation on AmazonWorkSpacesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateStandbyWorkspaces
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/CreateStandbyWorkspaces">REST API Reference for CreateStandbyWorkspaces Operation</seealso>
        public virtual IAsyncResult BeginCreateStandbyWorkspaces(CreateStandbyWorkspacesRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateStandbyWorkspacesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateStandbyWorkspacesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateStandbyWorkspaces operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateStandbyWorkspaces.</param>
        /// 
        /// <returns>Returns a  CreateStandbyWorkspacesResult from WorkSpaces.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/CreateStandbyWorkspaces">REST API Reference for CreateStandbyWorkspaces Operation</seealso>
        public virtual CreateStandbyWorkspacesResponse EndCreateStandbyWorkspaces(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateStandbyWorkspacesResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateTags

        /// <summary>
        /// Creates the specified tags for the specified WorkSpaces resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTags service method.</param>
        /// 
        /// <returns>The response from the CreateTags service method, as returned by WorkSpaces.</returns>
        /// <exception cref="Amazon.WorkSpaces.Model.InvalidParameterValuesException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.ResourceLimitExceededException">
        /// Your resource limits have been exceeded.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/CreateTags">REST API Reference for CreateTags Operation</seealso>
        public virtual CreateTagsResponse CreateTags(CreateTagsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateTagsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateTagsResponseUnmarshaller.Instance;

            return Invoke<CreateTagsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateTags operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateTags operation on AmazonWorkSpacesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateTags
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/CreateTags">REST API Reference for CreateTags Operation</seealso>
        public virtual IAsyncResult BeginCreateTags(CreateTagsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateTagsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateTagsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateTags operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateTags.</param>
        /// 
        /// <returns>Returns a  CreateTagsResult from WorkSpaces.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/CreateTags">REST API Reference for CreateTags Operation</seealso>
        public virtual CreateTagsResponse EndCreateTags(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateTagsResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateUpdatedWorkspaceImage

        /// <summary>
        /// Creates a new updated WorkSpace image based on the specified source image. The new
        /// updated WorkSpace image has the latest drivers and other updates required by the Amazon
        /// WorkSpaces components.
        /// 
        ///  
        /// <para>
        /// To determine which WorkSpace images need to be updated with the latest Amazon WorkSpaces
        /// requirements, use <a href="https://docs.aws.amazon.com/workspaces/latest/api/API_DescribeWorkspaceImages.html">
        /// DescribeWorkspaceImages</a>.
        /// </para>
        ///  <note> <ul> <li> 
        /// <para>
        /// Only Windows 10, Windows Server 2016, and Windows Server 2019 WorkSpace images can
        /// be programmatically updated at this time.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Microsoft Windows updates and other application updates are not included in the update
        /// process.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The source WorkSpace image is not deleted. You can delete the source image after you've
        /// verified your new updated image and created a new bundle. 
        /// </para>
        ///  </li> </ul> </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateUpdatedWorkspaceImage service method.</param>
        /// 
        /// <returns>The response from the CreateUpdatedWorkspaceImage service method, as returned by WorkSpaces.</returns>
        /// <exception cref="Amazon.WorkSpaces.Model.AccessDeniedException">
        /// The user is not authorized to access a resource.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.InvalidParameterValuesException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.InvalidResourceStateException">
        /// The state of the resource is not valid for this operation.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.OperationNotSupportedException">
        /// This operation is not supported.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.ResourceAlreadyExistsException">
        /// The specified resource already exists.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.ResourceLimitExceededException">
        /// Your resource limits have been exceeded.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/CreateUpdatedWorkspaceImage">REST API Reference for CreateUpdatedWorkspaceImage Operation</seealso>
        public virtual CreateUpdatedWorkspaceImageResponse CreateUpdatedWorkspaceImage(CreateUpdatedWorkspaceImageRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateUpdatedWorkspaceImageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateUpdatedWorkspaceImageResponseUnmarshaller.Instance;

            return Invoke<CreateUpdatedWorkspaceImageResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateUpdatedWorkspaceImage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateUpdatedWorkspaceImage operation on AmazonWorkSpacesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateUpdatedWorkspaceImage
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/CreateUpdatedWorkspaceImage">REST API Reference for CreateUpdatedWorkspaceImage Operation</seealso>
        public virtual IAsyncResult BeginCreateUpdatedWorkspaceImage(CreateUpdatedWorkspaceImageRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateUpdatedWorkspaceImageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateUpdatedWorkspaceImageResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateUpdatedWorkspaceImage operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateUpdatedWorkspaceImage.</param>
        /// 
        /// <returns>Returns a  CreateUpdatedWorkspaceImageResult from WorkSpaces.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/CreateUpdatedWorkspaceImage">REST API Reference for CreateUpdatedWorkspaceImage Operation</seealso>
        public virtual CreateUpdatedWorkspaceImageResponse EndCreateUpdatedWorkspaceImage(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateUpdatedWorkspaceImageResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateWorkspaceBundle

        /// <summary>
        /// Creates the specified WorkSpace bundle. For more information about creating WorkSpace
        /// bundles, see <a href="https://docs.aws.amazon.com/workspaces/latest/adminguide/create-custom-bundle.html">
        /// Create a Custom WorkSpaces Image and Bundle</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateWorkspaceBundle service method.</param>
        /// 
        /// <returns>The response from the CreateWorkspaceBundle service method, as returned by WorkSpaces.</returns>
        /// <exception cref="Amazon.WorkSpaces.Model.AccessDeniedException">
        /// The user is not authorized to access a resource.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.InvalidParameterValuesException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.ResourceAlreadyExistsException">
        /// The specified resource already exists.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.ResourceLimitExceededException">
        /// Your resource limits have been exceeded.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.ResourceUnavailableException">
        /// The specified resource is not available.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/CreateWorkspaceBundle">REST API Reference for CreateWorkspaceBundle Operation</seealso>
        public virtual CreateWorkspaceBundleResponse CreateWorkspaceBundle(CreateWorkspaceBundleRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateWorkspaceBundleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateWorkspaceBundleResponseUnmarshaller.Instance;

            return Invoke<CreateWorkspaceBundleResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateWorkspaceBundle operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateWorkspaceBundle operation on AmazonWorkSpacesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateWorkspaceBundle
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/CreateWorkspaceBundle">REST API Reference for CreateWorkspaceBundle Operation</seealso>
        public virtual IAsyncResult BeginCreateWorkspaceBundle(CreateWorkspaceBundleRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateWorkspaceBundleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateWorkspaceBundleResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateWorkspaceBundle operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateWorkspaceBundle.</param>
        /// 
        /// <returns>Returns a  CreateWorkspaceBundleResult from WorkSpaces.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/CreateWorkspaceBundle">REST API Reference for CreateWorkspaceBundle Operation</seealso>
        public virtual CreateWorkspaceBundleResponse EndCreateWorkspaceBundle(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateWorkspaceBundleResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateWorkspaceImage

        /// <summary>
        /// Creates a new WorkSpace image from an existing WorkSpace.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateWorkspaceImage service method.</param>
        /// 
        /// <returns>The response from the CreateWorkspaceImage service method, as returned by WorkSpaces.</returns>
        /// <exception cref="Amazon.WorkSpaces.Model.AccessDeniedException">
        /// The user is not authorized to access a resource.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.InvalidParameterValuesException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.InvalidResourceStateException">
        /// The state of the resource is not valid for this operation.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.OperationNotSupportedException">
        /// This operation is not supported.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.ResourceAlreadyExistsException">
        /// The specified resource already exists.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.ResourceLimitExceededException">
        /// Your resource limits have been exceeded.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/CreateWorkspaceImage">REST API Reference for CreateWorkspaceImage Operation</seealso>
        public virtual CreateWorkspaceImageResponse CreateWorkspaceImage(CreateWorkspaceImageRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateWorkspaceImageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateWorkspaceImageResponseUnmarshaller.Instance;

            return Invoke<CreateWorkspaceImageResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateWorkspaceImage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateWorkspaceImage operation on AmazonWorkSpacesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateWorkspaceImage
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/CreateWorkspaceImage">REST API Reference for CreateWorkspaceImage Operation</seealso>
        public virtual IAsyncResult BeginCreateWorkspaceImage(CreateWorkspaceImageRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateWorkspaceImageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateWorkspaceImageResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateWorkspaceImage operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateWorkspaceImage.</param>
        /// 
        /// <returns>Returns a  CreateWorkspaceImageResult from WorkSpaces.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/CreateWorkspaceImage">REST API Reference for CreateWorkspaceImage Operation</seealso>
        public virtual CreateWorkspaceImageResponse EndCreateWorkspaceImage(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateWorkspaceImageResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateWorkspaces

        /// <summary>
        /// Creates one or more WorkSpaces.
        /// 
        ///  
        /// <para>
        /// This operation is asynchronous and returns before the WorkSpaces are created.
        /// </para>
        ///  <note> <ul> <li> 
        /// <para>
        /// The <c>MANUAL</c> running mode value is only supported by Amazon WorkSpaces Core.
        /// Contact your account team to be allow-listed to use this value. For more information,
        /// see <a href="http://aws.amazon.com/workspaces/core/">Amazon WorkSpaces Core</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You don't need to specify the <c>PCOIP</c> protocol for Linux bundles because <c>DCV</c>
        /// (formerly WSP) is the default protocol for those bundles.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// User-decoupled WorkSpaces are only supported by Amazon WorkSpaces Core.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Review your running mode to ensure you are using one that is optimal for your needs
        /// and budget. For more information on switching running modes, see <a href="http://aws.amazon.com/workspaces-family/workspaces/faqs/#:~:text=Can%20I%20switch%20between%20hourly%20and%20monthly%20billing%20on%20WorkSpaces%20Personal%3F">
        /// Can I switch between hourly and monthly billing?</a> 
        /// </para>
        ///  </li> </ul> </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateWorkspaces service method.</param>
        /// 
        /// <returns>The response from the CreateWorkspaces service method, as returned by WorkSpaces.</returns>
        /// <exception cref="Amazon.WorkSpaces.Model.InvalidParameterValuesException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.ResourceLimitExceededException">
        /// Your resource limits have been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/CreateWorkspaces">REST API Reference for CreateWorkspaces Operation</seealso>
        public virtual CreateWorkspacesResponse CreateWorkspaces(CreateWorkspacesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateWorkspacesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateWorkspacesResponseUnmarshaller.Instance;

            return Invoke<CreateWorkspacesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateWorkspaces operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateWorkspaces operation on AmazonWorkSpacesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateWorkspaces
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/CreateWorkspaces">REST API Reference for CreateWorkspaces Operation</seealso>
        public virtual IAsyncResult BeginCreateWorkspaces(CreateWorkspacesRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateWorkspacesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateWorkspacesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateWorkspaces operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateWorkspaces.</param>
        /// 
        /// <returns>Returns a  CreateWorkspacesResult from WorkSpaces.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/CreateWorkspaces">REST API Reference for CreateWorkspaces Operation</seealso>
        public virtual CreateWorkspacesResponse EndCreateWorkspaces(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateWorkspacesResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateWorkspacesPool

        /// <summary>
        /// Creates a pool of WorkSpaces.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateWorkspacesPool service method.</param>
        /// 
        /// <returns>The response from the CreateWorkspacesPool service method, as returned by WorkSpaces.</returns>
        /// <exception cref="Amazon.WorkSpaces.Model.AccessDeniedException">
        /// The user is not authorized to access a resource.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.InvalidParameterValuesException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.OperationNotSupportedException">
        /// This operation is not supported.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.ResourceAlreadyExistsException">
        /// The specified resource already exists.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.ResourceLimitExceededException">
        /// Your resource limits have been exceeded.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/CreateWorkspacesPool">REST API Reference for CreateWorkspacesPool Operation</seealso>
        public virtual CreateWorkspacesPoolResponse CreateWorkspacesPool(CreateWorkspacesPoolRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateWorkspacesPoolRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateWorkspacesPoolResponseUnmarshaller.Instance;

            return Invoke<CreateWorkspacesPoolResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateWorkspacesPool operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateWorkspacesPool operation on AmazonWorkSpacesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateWorkspacesPool
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/CreateWorkspacesPool">REST API Reference for CreateWorkspacesPool Operation</seealso>
        public virtual IAsyncResult BeginCreateWorkspacesPool(CreateWorkspacesPoolRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateWorkspacesPoolRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateWorkspacesPoolResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateWorkspacesPool operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateWorkspacesPool.</param>
        /// 
        /// <returns>Returns a  CreateWorkspacesPoolResult from WorkSpaces.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/CreateWorkspacesPool">REST API Reference for CreateWorkspacesPool Operation</seealso>
        public virtual CreateWorkspacesPoolResponse EndCreateWorkspacesPool(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateWorkspacesPoolResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteAccountLinkInvitation

        /// <summary>
        /// Deletes the account link invitation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAccountLinkInvitation service method.</param>
        /// 
        /// <returns>The response from the DeleteAccountLinkInvitation service method, as returned by WorkSpaces.</returns>
        /// <exception cref="Amazon.WorkSpaces.Model.AccessDeniedException">
        /// The user is not authorized to access a resource.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.ConflictException">
        /// The <c>TargetAccountId</c> is already linked or invited.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.InternalServerException">
        /// Unexpected server error occured.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.ValidationException">
        /// You either haven't provided a <c>TargetAccountId</c> or are using the same value for
        /// <c>TargetAccountId</c> and <c>SourceAccountId</c>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/DeleteAccountLinkInvitation">REST API Reference for DeleteAccountLinkInvitation Operation</seealso>
        public virtual DeleteAccountLinkInvitationResponse DeleteAccountLinkInvitation(DeleteAccountLinkInvitationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteAccountLinkInvitationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAccountLinkInvitationResponseUnmarshaller.Instance;

            return Invoke<DeleteAccountLinkInvitationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteAccountLinkInvitation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteAccountLinkInvitation operation on AmazonWorkSpacesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteAccountLinkInvitation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/DeleteAccountLinkInvitation">REST API Reference for DeleteAccountLinkInvitation Operation</seealso>
        public virtual IAsyncResult BeginDeleteAccountLinkInvitation(DeleteAccountLinkInvitationRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteAccountLinkInvitationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAccountLinkInvitationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteAccountLinkInvitation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteAccountLinkInvitation.</param>
        /// 
        /// <returns>Returns a  DeleteAccountLinkInvitationResult from WorkSpaces.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/DeleteAccountLinkInvitation">REST API Reference for DeleteAccountLinkInvitation Operation</seealso>
        public virtual DeleteAccountLinkInvitationResponse EndDeleteAccountLinkInvitation(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteAccountLinkInvitationResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteClientBranding

        /// <summary>
        /// Deletes customized client branding. Client branding allows you to customize your WorkSpace's
        /// client login portal. You can tailor your login portal company logo, the support email
        /// address, support link, link to reset password, and a custom message for users trying
        /// to sign in.
        /// 
        ///  
        /// <para>
        /// After you delete your customized client branding, your login portal reverts to the
        /// default client branding.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteClientBranding service method.</param>
        /// 
        /// <returns>The response from the DeleteClientBranding service method, as returned by WorkSpaces.</returns>
        /// <exception cref="Amazon.WorkSpaces.Model.AccessDeniedException">
        /// The user is not authorized to access a resource.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.InvalidParameterValuesException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/DeleteClientBranding">REST API Reference for DeleteClientBranding Operation</seealso>
        public virtual DeleteClientBrandingResponse DeleteClientBranding(DeleteClientBrandingRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteClientBrandingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteClientBrandingResponseUnmarshaller.Instance;

            return Invoke<DeleteClientBrandingResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteClientBranding operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteClientBranding operation on AmazonWorkSpacesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteClientBranding
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/DeleteClientBranding">REST API Reference for DeleteClientBranding Operation</seealso>
        public virtual IAsyncResult BeginDeleteClientBranding(DeleteClientBrandingRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteClientBrandingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteClientBrandingResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteClientBranding operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteClientBranding.</param>
        /// 
        /// <returns>Returns a  DeleteClientBrandingResult from WorkSpaces.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/DeleteClientBranding">REST API Reference for DeleteClientBranding Operation</seealso>
        public virtual DeleteClientBrandingResponse EndDeleteClientBranding(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteClientBrandingResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteConnectClientAddIn

        /// <summary>
        /// Deletes a client-add-in for Amazon Connect that is configured within a directory.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteConnectClientAddIn service method.</param>
        /// 
        /// <returns>The response from the DeleteConnectClientAddIn service method, as returned by WorkSpaces.</returns>
        /// <exception cref="Amazon.WorkSpaces.Model.AccessDeniedException">
        /// The user is not authorized to access a resource.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.InvalidParameterValuesException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/DeleteConnectClientAddIn">REST API Reference for DeleteConnectClientAddIn Operation</seealso>
        public virtual DeleteConnectClientAddInResponse DeleteConnectClientAddIn(DeleteConnectClientAddInRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteConnectClientAddInRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteConnectClientAddInResponseUnmarshaller.Instance;

            return Invoke<DeleteConnectClientAddInResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteConnectClientAddIn operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteConnectClientAddIn operation on AmazonWorkSpacesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteConnectClientAddIn
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/DeleteConnectClientAddIn">REST API Reference for DeleteConnectClientAddIn Operation</seealso>
        public virtual IAsyncResult BeginDeleteConnectClientAddIn(DeleteConnectClientAddInRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteConnectClientAddInRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteConnectClientAddInResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteConnectClientAddIn operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteConnectClientAddIn.</param>
        /// 
        /// <returns>Returns a  DeleteConnectClientAddInResult from WorkSpaces.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/DeleteConnectClientAddIn">REST API Reference for DeleteConnectClientAddIn Operation</seealso>
        public virtual DeleteConnectClientAddInResponse EndDeleteConnectClientAddIn(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteConnectClientAddInResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteConnectionAlias

        /// <summary>
        /// Deletes the specified connection alias. For more information, see <a href="https://docs.aws.amazon.com/workspaces/latest/adminguide/cross-region-redirection.html">
        /// Cross-Region Redirection for Amazon WorkSpaces</a>.
        /// 
        ///  <important> 
        /// <para>
        ///  <b>If you will no longer be using a fully qualified domain name (FQDN) as the registration
        /// code for your WorkSpaces users, you must take certain precautions to prevent potential
        /// security issues.</b> For more information, see <a href="https://docs.aws.amazon.com/workspaces/latest/adminguide/cross-region-redirection.html#cross-region-redirection-security-considerations">
        /// Security Considerations if You Stop Using Cross-Region Redirection</a>.
        /// </para>
        ///  </important> <note> 
        /// <para>
        /// To delete a connection alias that has been shared, the shared account must first disassociate
        /// the connection alias from any directories it has been associated with. Then you must
        /// unshare the connection alias from the account it has been shared with. You can delete
        /// a connection alias only after it is no longer shared with any accounts or associated
        /// with any directories.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteConnectionAlias service method.</param>
        /// 
        /// <returns>The response from the DeleteConnectionAlias service method, as returned by WorkSpaces.</returns>
        /// <exception cref="Amazon.WorkSpaces.Model.AccessDeniedException">
        /// The user is not authorized to access a resource.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.InvalidParameterValuesException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.InvalidResourceStateException">
        /// The state of the resource is not valid for this operation.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.OperationNotSupportedException">
        /// This operation is not supported.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.ResourceAssociatedException">
        /// The resource is associated with a directory.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/DeleteConnectionAlias">REST API Reference for DeleteConnectionAlias Operation</seealso>
        public virtual DeleteConnectionAliasResponse DeleteConnectionAlias(DeleteConnectionAliasRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteConnectionAliasRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteConnectionAliasResponseUnmarshaller.Instance;

            return Invoke<DeleteConnectionAliasResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteConnectionAlias operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteConnectionAlias operation on AmazonWorkSpacesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteConnectionAlias
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/DeleteConnectionAlias">REST API Reference for DeleteConnectionAlias Operation</seealso>
        public virtual IAsyncResult BeginDeleteConnectionAlias(DeleteConnectionAliasRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteConnectionAliasRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteConnectionAliasResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteConnectionAlias operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteConnectionAlias.</param>
        /// 
        /// <returns>Returns a  DeleteConnectionAliasResult from WorkSpaces.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/DeleteConnectionAlias">REST API Reference for DeleteConnectionAlias Operation</seealso>
        public virtual DeleteConnectionAliasResponse EndDeleteConnectionAlias(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteConnectionAliasResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteIpGroup

        /// <summary>
        /// Deletes the specified IP access control group.
        /// 
        ///  
        /// <para>
        /// You cannot delete an IP access control group that is associated with a directory.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteIpGroup service method.</param>
        /// 
        /// <returns>The response from the DeleteIpGroup service method, as returned by WorkSpaces.</returns>
        /// <exception cref="Amazon.WorkSpaces.Model.AccessDeniedException">
        /// The user is not authorized to access a resource.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.InvalidParameterValuesException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.ResourceAssociatedException">
        /// The resource is associated with a directory.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/DeleteIpGroup">REST API Reference for DeleteIpGroup Operation</seealso>
        public virtual DeleteIpGroupResponse DeleteIpGroup(DeleteIpGroupRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteIpGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteIpGroupResponseUnmarshaller.Instance;

            return Invoke<DeleteIpGroupResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteIpGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteIpGroup operation on AmazonWorkSpacesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteIpGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/DeleteIpGroup">REST API Reference for DeleteIpGroup Operation</seealso>
        public virtual IAsyncResult BeginDeleteIpGroup(DeleteIpGroupRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteIpGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteIpGroupResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteIpGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteIpGroup.</param>
        /// 
        /// <returns>Returns a  DeleteIpGroupResult from WorkSpaces.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/DeleteIpGroup">REST API Reference for DeleteIpGroup Operation</seealso>
        public virtual DeleteIpGroupResponse EndDeleteIpGroup(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteIpGroupResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteTags

        /// <summary>
        /// Deletes the specified tags from the specified WorkSpaces resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTags service method.</param>
        /// 
        /// <returns>The response from the DeleteTags service method, as returned by WorkSpaces.</returns>
        /// <exception cref="Amazon.WorkSpaces.Model.InvalidParameterValuesException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/DeleteTags">REST API Reference for DeleteTags Operation</seealso>
        public virtual DeleteTagsResponse DeleteTags(DeleteTagsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteTagsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTagsResponseUnmarshaller.Instance;

            return Invoke<DeleteTagsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteTags operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteTags operation on AmazonWorkSpacesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteTags
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/DeleteTags">REST API Reference for DeleteTags Operation</seealso>
        public virtual IAsyncResult BeginDeleteTags(DeleteTagsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteTagsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTagsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteTags operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteTags.</param>
        /// 
        /// <returns>Returns a  DeleteTagsResult from WorkSpaces.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/DeleteTags">REST API Reference for DeleteTags Operation</seealso>
        public virtual DeleteTagsResponse EndDeleteTags(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteTagsResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteWorkspaceBundle

        /// <summary>
        /// Deletes the specified WorkSpace bundle. For more information about deleting WorkSpace
        /// bundles, see <a href="https://docs.aws.amazon.com/workspaces/latest/adminguide/delete_bundle.html">
        /// Delete a Custom WorkSpaces Bundle or Image</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteWorkspaceBundle service method.</param>
        /// 
        /// <returns>The response from the DeleteWorkspaceBundle service method, as returned by WorkSpaces.</returns>
        /// <exception cref="Amazon.WorkSpaces.Model.AccessDeniedException">
        /// The user is not authorized to access a resource.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.InvalidParameterValuesException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.ResourceAssociatedException">
        /// The resource is associated with a directory.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/DeleteWorkspaceBundle">REST API Reference for DeleteWorkspaceBundle Operation</seealso>
        public virtual DeleteWorkspaceBundleResponse DeleteWorkspaceBundle(DeleteWorkspaceBundleRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteWorkspaceBundleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteWorkspaceBundleResponseUnmarshaller.Instance;

            return Invoke<DeleteWorkspaceBundleResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteWorkspaceBundle operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteWorkspaceBundle operation on AmazonWorkSpacesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteWorkspaceBundle
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/DeleteWorkspaceBundle">REST API Reference for DeleteWorkspaceBundle Operation</seealso>
        public virtual IAsyncResult BeginDeleteWorkspaceBundle(DeleteWorkspaceBundleRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteWorkspaceBundleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteWorkspaceBundleResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteWorkspaceBundle operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteWorkspaceBundle.</param>
        /// 
        /// <returns>Returns a  DeleteWorkspaceBundleResult from WorkSpaces.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/DeleteWorkspaceBundle">REST API Reference for DeleteWorkspaceBundle Operation</seealso>
        public virtual DeleteWorkspaceBundleResponse EndDeleteWorkspaceBundle(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteWorkspaceBundleResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteWorkspaceImage

        /// <summary>
        /// Deletes the specified image from your account. To delete an image, you must first
        /// delete any bundles that are associated with the image and unshare the image if it
        /// is shared with other accounts.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteWorkspaceImage service method.</param>
        /// 
        /// <returns>The response from the DeleteWorkspaceImage service method, as returned by WorkSpaces.</returns>
        /// <exception cref="Amazon.WorkSpaces.Model.AccessDeniedException">
        /// The user is not authorized to access a resource.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.InvalidResourceStateException">
        /// The state of the resource is not valid for this operation.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.ResourceAssociatedException">
        /// The resource is associated with a directory.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/DeleteWorkspaceImage">REST API Reference for DeleteWorkspaceImage Operation</seealso>
        public virtual DeleteWorkspaceImageResponse DeleteWorkspaceImage(DeleteWorkspaceImageRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteWorkspaceImageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteWorkspaceImageResponseUnmarshaller.Instance;

            return Invoke<DeleteWorkspaceImageResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteWorkspaceImage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteWorkspaceImage operation on AmazonWorkSpacesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteWorkspaceImage
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/DeleteWorkspaceImage">REST API Reference for DeleteWorkspaceImage Operation</seealso>
        public virtual IAsyncResult BeginDeleteWorkspaceImage(DeleteWorkspaceImageRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteWorkspaceImageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteWorkspaceImageResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteWorkspaceImage operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteWorkspaceImage.</param>
        /// 
        /// <returns>Returns a  DeleteWorkspaceImageResult from WorkSpaces.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/DeleteWorkspaceImage">REST API Reference for DeleteWorkspaceImage Operation</seealso>
        public virtual DeleteWorkspaceImageResponse EndDeleteWorkspaceImage(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteWorkspaceImageResponse>(asyncResult);
        }

        #endregion
        
        #region  DeployWorkspaceApplications

        /// <summary>
        /// Deploys associated applications to the specified WorkSpace
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeployWorkspaceApplications service method.</param>
        /// 
        /// <returns>The response from the DeployWorkspaceApplications service method, as returned by WorkSpaces.</returns>
        /// <exception cref="Amazon.WorkSpaces.Model.AccessDeniedException">
        /// The user is not authorized to access a resource.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.IncompatibleApplicationsException">
        /// The specified application is not compatible with the resource.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.InvalidParameterValuesException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.OperationNotSupportedException">
        /// This operation is not supported.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.ResourceInUseException">
        /// The specified resource is currently in use.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/DeployWorkspaceApplications">REST API Reference for DeployWorkspaceApplications Operation</seealso>
        public virtual DeployWorkspaceApplicationsResponse DeployWorkspaceApplications(DeployWorkspaceApplicationsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeployWorkspaceApplicationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeployWorkspaceApplicationsResponseUnmarshaller.Instance;

            return Invoke<DeployWorkspaceApplicationsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeployWorkspaceApplications operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeployWorkspaceApplications operation on AmazonWorkSpacesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeployWorkspaceApplications
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/DeployWorkspaceApplications">REST API Reference for DeployWorkspaceApplications Operation</seealso>
        public virtual IAsyncResult BeginDeployWorkspaceApplications(DeployWorkspaceApplicationsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeployWorkspaceApplicationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeployWorkspaceApplicationsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeployWorkspaceApplications operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeployWorkspaceApplications.</param>
        /// 
        /// <returns>Returns a  DeployWorkspaceApplicationsResult from WorkSpaces.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/DeployWorkspaceApplications">REST API Reference for DeployWorkspaceApplications Operation</seealso>
        public virtual DeployWorkspaceApplicationsResponse EndDeployWorkspaceApplications(IAsyncResult asyncResult)
        {
            return EndInvoke<DeployWorkspaceApplicationsResponse>(asyncResult);
        }

        #endregion
        
        #region  DeregisterWorkspaceDirectory

        /// <summary>
        /// Deregisters the specified directory. This operation is asynchronous and returns before
        /// the WorkSpace directory is deregistered. If any WorkSpaces are registered to this
        /// directory, you must remove them before you can deregister the directory.
        /// 
        ///  <note> 
        /// <para>
        /// Simple AD and AD Connector are made available to you free of charge to use with WorkSpaces.
        /// If there are no WorkSpaces being used with your Simple AD or AD Connector directory
        /// for 30 consecutive days, this directory will be automatically deregistered for use
        /// with Amazon WorkSpaces, and you will be charged for this directory as per the <a href="http://aws.amazon.com/directoryservice/pricing/">Directory
        /// Service pricing terms</a>.
        /// </para>
        ///  
        /// <para>
        /// To delete empty directories, see <a href="https://docs.aws.amazon.com/workspaces/latest/adminguide/delete-workspaces-directory.html">
        /// Delete the Directory for Your WorkSpaces</a>. If you delete your Simple AD or AD Connector
        /// directory, you can always create a new one when you want to start using WorkSpaces
        /// again.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeregisterWorkspaceDirectory service method.</param>
        /// 
        /// <returns>The response from the DeregisterWorkspaceDirectory service method, as returned by WorkSpaces.</returns>
        /// <exception cref="Amazon.WorkSpaces.Model.AccessDeniedException">
        /// The user is not authorized to access a resource.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.InvalidParameterValuesException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.InvalidResourceStateException">
        /// The state of the resource is not valid for this operation.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.OperationNotSupportedException">
        /// This operation is not supported.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/DeregisterWorkspaceDirectory">REST API Reference for DeregisterWorkspaceDirectory Operation</seealso>
        public virtual DeregisterWorkspaceDirectoryResponse DeregisterWorkspaceDirectory(DeregisterWorkspaceDirectoryRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeregisterWorkspaceDirectoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeregisterWorkspaceDirectoryResponseUnmarshaller.Instance;

            return Invoke<DeregisterWorkspaceDirectoryResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeregisterWorkspaceDirectory operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeregisterWorkspaceDirectory operation on AmazonWorkSpacesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeregisterWorkspaceDirectory
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/DeregisterWorkspaceDirectory">REST API Reference for DeregisterWorkspaceDirectory Operation</seealso>
        public virtual IAsyncResult BeginDeregisterWorkspaceDirectory(DeregisterWorkspaceDirectoryRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeregisterWorkspaceDirectoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeregisterWorkspaceDirectoryResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeregisterWorkspaceDirectory operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeregisterWorkspaceDirectory.</param>
        /// 
        /// <returns>Returns a  DeregisterWorkspaceDirectoryResult from WorkSpaces.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/DeregisterWorkspaceDirectory">REST API Reference for DeregisterWorkspaceDirectory Operation</seealso>
        public virtual DeregisterWorkspaceDirectoryResponse EndDeregisterWorkspaceDirectory(IAsyncResult asyncResult)
        {
            return EndInvoke<DeregisterWorkspaceDirectoryResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeAccount

        /// <summary>
        /// Retrieves a list that describes the configuration of Bring Your Own License (BYOL)
        /// for the specified account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAccount service method.</param>
        /// 
        /// <returns>The response from the DescribeAccount service method, as returned by WorkSpaces.</returns>
        /// <exception cref="Amazon.WorkSpaces.Model.AccessDeniedException">
        /// The user is not authorized to access a resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/DescribeAccount">REST API Reference for DescribeAccount Operation</seealso>
        public virtual DescribeAccountResponse DescribeAccount(DescribeAccountRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeAccountRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAccountResponseUnmarshaller.Instance;

            return Invoke<DescribeAccountResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeAccount operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAccount operation on AmazonWorkSpacesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeAccount
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/DescribeAccount">REST API Reference for DescribeAccount Operation</seealso>
        public virtual IAsyncResult BeginDescribeAccount(DescribeAccountRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeAccountRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAccountResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeAccount operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeAccount.</param>
        /// 
        /// <returns>Returns a  DescribeAccountResult from WorkSpaces.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/DescribeAccount">REST API Reference for DescribeAccount Operation</seealso>
        public virtual DescribeAccountResponse EndDescribeAccount(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeAccountResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeAccountModifications

        /// <summary>
        /// Retrieves a list that describes modifications to the configuration of Bring Your Own
        /// License (BYOL) for the specified account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAccountModifications service method.</param>
        /// 
        /// <returns>The response from the DescribeAccountModifications service method, as returned by WorkSpaces.</returns>
        /// <exception cref="Amazon.WorkSpaces.Model.AccessDeniedException">
        /// The user is not authorized to access a resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/DescribeAccountModifications">REST API Reference for DescribeAccountModifications Operation</seealso>
        public virtual DescribeAccountModificationsResponse DescribeAccountModifications(DescribeAccountModificationsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeAccountModificationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAccountModificationsResponseUnmarshaller.Instance;

            return Invoke<DescribeAccountModificationsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeAccountModifications operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAccountModifications operation on AmazonWorkSpacesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeAccountModifications
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/DescribeAccountModifications">REST API Reference for DescribeAccountModifications Operation</seealso>
        public virtual IAsyncResult BeginDescribeAccountModifications(DescribeAccountModificationsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeAccountModificationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAccountModificationsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeAccountModifications operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeAccountModifications.</param>
        /// 
        /// <returns>Returns a  DescribeAccountModificationsResult from WorkSpaces.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/DescribeAccountModifications">REST API Reference for DescribeAccountModifications Operation</seealso>
        public virtual DescribeAccountModificationsResponse EndDescribeAccountModifications(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeAccountModificationsResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeApplicationAssociations

        /// <summary>
        /// Describes the associations between the application and the specified associated resources.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeApplicationAssociations service method.</param>
        /// 
        /// <returns>The response from the DescribeApplicationAssociations service method, as returned by WorkSpaces.</returns>
        /// <exception cref="Amazon.WorkSpaces.Model.AccessDeniedException">
        /// The user is not authorized to access a resource.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.InvalidParameterValuesException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.OperationNotSupportedException">
        /// This operation is not supported.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/DescribeApplicationAssociations">REST API Reference for DescribeApplicationAssociations Operation</seealso>
        public virtual DescribeApplicationAssociationsResponse DescribeApplicationAssociations(DescribeApplicationAssociationsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeApplicationAssociationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeApplicationAssociationsResponseUnmarshaller.Instance;

            return Invoke<DescribeApplicationAssociationsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeApplicationAssociations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeApplicationAssociations operation on AmazonWorkSpacesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeApplicationAssociations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/DescribeApplicationAssociations">REST API Reference for DescribeApplicationAssociations Operation</seealso>
        public virtual IAsyncResult BeginDescribeApplicationAssociations(DescribeApplicationAssociationsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeApplicationAssociationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeApplicationAssociationsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeApplicationAssociations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeApplicationAssociations.</param>
        /// 
        /// <returns>Returns a  DescribeApplicationAssociationsResult from WorkSpaces.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/DescribeApplicationAssociations">REST API Reference for DescribeApplicationAssociations Operation</seealso>
        public virtual DescribeApplicationAssociationsResponse EndDescribeApplicationAssociations(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeApplicationAssociationsResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeApplications

        /// <summary>
        /// Describes the specified applications by filtering based on their compute types, license
        /// availability, operating systems, and owners.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeApplications service method.</param>
        /// 
        /// <returns>The response from the DescribeApplications service method, as returned by WorkSpaces.</returns>
        /// <exception cref="Amazon.WorkSpaces.Model.AccessDeniedException">
        /// The user is not authorized to access a resource.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.InvalidParameterValuesException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.OperationNotSupportedException">
        /// This operation is not supported.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/DescribeApplications">REST API Reference for DescribeApplications Operation</seealso>
        public virtual DescribeApplicationsResponse DescribeApplications(DescribeApplicationsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeApplicationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeApplicationsResponseUnmarshaller.Instance;

            return Invoke<DescribeApplicationsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeApplications operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeApplications operation on AmazonWorkSpacesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeApplications
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/DescribeApplications">REST API Reference for DescribeApplications Operation</seealso>
        public virtual IAsyncResult BeginDescribeApplications(DescribeApplicationsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeApplicationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeApplicationsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeApplications operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeApplications.</param>
        /// 
        /// <returns>Returns a  DescribeApplicationsResult from WorkSpaces.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/DescribeApplications">REST API Reference for DescribeApplications Operation</seealso>
        public virtual DescribeApplicationsResponse EndDescribeApplications(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeApplicationsResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeBundleAssociations

        /// <summary>
        /// Describes the associations between the applications and the specified bundle.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeBundleAssociations service method.</param>
        /// 
        /// <returns>The response from the DescribeBundleAssociations service method, as returned by WorkSpaces.</returns>
        /// <exception cref="Amazon.WorkSpaces.Model.AccessDeniedException">
        /// The user is not authorized to access a resource.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.InvalidParameterValuesException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.OperationNotSupportedException">
        /// This operation is not supported.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/DescribeBundleAssociations">REST API Reference for DescribeBundleAssociations Operation</seealso>
        public virtual DescribeBundleAssociationsResponse DescribeBundleAssociations(DescribeBundleAssociationsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeBundleAssociationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeBundleAssociationsResponseUnmarshaller.Instance;

            return Invoke<DescribeBundleAssociationsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeBundleAssociations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeBundleAssociations operation on AmazonWorkSpacesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeBundleAssociations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/DescribeBundleAssociations">REST API Reference for DescribeBundleAssociations Operation</seealso>
        public virtual IAsyncResult BeginDescribeBundleAssociations(DescribeBundleAssociationsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeBundleAssociationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeBundleAssociationsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeBundleAssociations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeBundleAssociations.</param>
        /// 
        /// <returns>Returns a  DescribeBundleAssociationsResult from WorkSpaces.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/DescribeBundleAssociations">REST API Reference for DescribeBundleAssociations Operation</seealso>
        public virtual DescribeBundleAssociationsResponse EndDescribeBundleAssociations(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeBundleAssociationsResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeClientBranding

        /// <summary>
        /// Describes the specified client branding. Client branding allows you to customize the
        /// log in page of various device types for your users. You can add your company logo,
        /// the support email address, support link, link to reset password, and a custom message
        /// for users trying to sign in.
        /// 
        ///  <note> 
        /// <para>
        /// Only device types that have branding information configured will be shown in the response.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeClientBranding service method.</param>
        /// 
        /// <returns>The response from the DescribeClientBranding service method, as returned by WorkSpaces.</returns>
        /// <exception cref="Amazon.WorkSpaces.Model.AccessDeniedException">
        /// The user is not authorized to access a resource.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.InvalidParameterValuesException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/DescribeClientBranding">REST API Reference for DescribeClientBranding Operation</seealso>
        public virtual DescribeClientBrandingResponse DescribeClientBranding(DescribeClientBrandingRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeClientBrandingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeClientBrandingResponseUnmarshaller.Instance;

            return Invoke<DescribeClientBrandingResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeClientBranding operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeClientBranding operation on AmazonWorkSpacesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeClientBranding
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/DescribeClientBranding">REST API Reference for DescribeClientBranding Operation</seealso>
        public virtual IAsyncResult BeginDescribeClientBranding(DescribeClientBrandingRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeClientBrandingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeClientBrandingResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeClientBranding operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeClientBranding.</param>
        /// 
        /// <returns>Returns a  DescribeClientBrandingResult from WorkSpaces.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/DescribeClientBranding">REST API Reference for DescribeClientBranding Operation</seealso>
        public virtual DescribeClientBrandingResponse EndDescribeClientBranding(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeClientBrandingResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeClientProperties

        /// <summary>
        /// Retrieves a list that describes one or more specified Amazon WorkSpaces clients.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeClientProperties service method.</param>
        /// 
        /// <returns>The response from the DescribeClientProperties service method, as returned by WorkSpaces.</returns>
        /// <exception cref="Amazon.WorkSpaces.Model.AccessDeniedException">
        /// The user is not authorized to access a resource.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.InvalidParameterValuesException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/DescribeClientProperties">REST API Reference for DescribeClientProperties Operation</seealso>
        public virtual DescribeClientPropertiesResponse DescribeClientProperties(DescribeClientPropertiesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeClientPropertiesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeClientPropertiesResponseUnmarshaller.Instance;

            return Invoke<DescribeClientPropertiesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeClientProperties operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeClientProperties operation on AmazonWorkSpacesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeClientProperties
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/DescribeClientProperties">REST API Reference for DescribeClientProperties Operation</seealso>
        public virtual IAsyncResult BeginDescribeClientProperties(DescribeClientPropertiesRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeClientPropertiesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeClientPropertiesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeClientProperties operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeClientProperties.</param>
        /// 
        /// <returns>Returns a  DescribeClientPropertiesResult from WorkSpaces.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/DescribeClientProperties">REST API Reference for DescribeClientProperties Operation</seealso>
        public virtual DescribeClientPropertiesResponse EndDescribeClientProperties(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeClientPropertiesResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeConnectClientAddIns

        /// <summary>
        /// Retrieves a list of Amazon Connect client add-ins that have been created.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeConnectClientAddIns service method.</param>
        /// 
        /// <returns>The response from the DescribeConnectClientAddIns service method, as returned by WorkSpaces.</returns>
        /// <exception cref="Amazon.WorkSpaces.Model.AccessDeniedException">
        /// The user is not authorized to access a resource.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.InvalidParameterValuesException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/DescribeConnectClientAddIns">REST API Reference for DescribeConnectClientAddIns Operation</seealso>
        public virtual DescribeConnectClientAddInsResponse DescribeConnectClientAddIns(DescribeConnectClientAddInsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeConnectClientAddInsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeConnectClientAddInsResponseUnmarshaller.Instance;

            return Invoke<DescribeConnectClientAddInsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeConnectClientAddIns operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeConnectClientAddIns operation on AmazonWorkSpacesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeConnectClientAddIns
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/DescribeConnectClientAddIns">REST API Reference for DescribeConnectClientAddIns Operation</seealso>
        public virtual IAsyncResult BeginDescribeConnectClientAddIns(DescribeConnectClientAddInsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeConnectClientAddInsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeConnectClientAddInsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeConnectClientAddIns operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeConnectClientAddIns.</param>
        /// 
        /// <returns>Returns a  DescribeConnectClientAddInsResult from WorkSpaces.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/DescribeConnectClientAddIns">REST API Reference for DescribeConnectClientAddIns Operation</seealso>
        public virtual DescribeConnectClientAddInsResponse EndDescribeConnectClientAddIns(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeConnectClientAddInsResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeConnectionAliases

        /// <summary>
        /// Retrieves a list that describes the connection aliases used for cross-Region redirection.
        /// For more information, see <a href="https://docs.aws.amazon.com/workspaces/latest/adminguide/cross-region-redirection.html">
        /// Cross-Region Redirection for Amazon WorkSpaces</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeConnectionAliases service method.</param>
        /// 
        /// <returns>The response from the DescribeConnectionAliases service method, as returned by WorkSpaces.</returns>
        /// <exception cref="Amazon.WorkSpaces.Model.AccessDeniedException">
        /// The user is not authorized to access a resource.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.InvalidParameterValuesException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.OperationNotSupportedException">
        /// This operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/DescribeConnectionAliases">REST API Reference for DescribeConnectionAliases Operation</seealso>
        public virtual DescribeConnectionAliasesResponse DescribeConnectionAliases(DescribeConnectionAliasesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeConnectionAliasesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeConnectionAliasesResponseUnmarshaller.Instance;

            return Invoke<DescribeConnectionAliasesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeConnectionAliases operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeConnectionAliases operation on AmazonWorkSpacesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeConnectionAliases
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/DescribeConnectionAliases">REST API Reference for DescribeConnectionAliases Operation</seealso>
        public virtual IAsyncResult BeginDescribeConnectionAliases(DescribeConnectionAliasesRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeConnectionAliasesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeConnectionAliasesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeConnectionAliases operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeConnectionAliases.</param>
        /// 
        /// <returns>Returns a  DescribeConnectionAliasesResult from WorkSpaces.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/DescribeConnectionAliases">REST API Reference for DescribeConnectionAliases Operation</seealso>
        public virtual DescribeConnectionAliasesResponse EndDescribeConnectionAliases(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeConnectionAliasesResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeConnectionAliasPermissions

        /// <summary>
        /// Describes the permissions that the owner of a connection alias has granted to another
        /// Amazon Web Services account for the specified connection alias. For more information,
        /// see <a href="https://docs.aws.amazon.com/workspaces/latest/adminguide/cross-region-redirection.html">
        /// Cross-Region Redirection for Amazon WorkSpaces</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeConnectionAliasPermissions service method.</param>
        /// 
        /// <returns>The response from the DescribeConnectionAliasPermissions service method, as returned by WorkSpaces.</returns>
        /// <exception cref="Amazon.WorkSpaces.Model.AccessDeniedException">
        /// The user is not authorized to access a resource.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.InvalidParameterValuesException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.OperationNotSupportedException">
        /// This operation is not supported.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/DescribeConnectionAliasPermissions">REST API Reference for DescribeConnectionAliasPermissions Operation</seealso>
        public virtual DescribeConnectionAliasPermissionsResponse DescribeConnectionAliasPermissions(DescribeConnectionAliasPermissionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeConnectionAliasPermissionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeConnectionAliasPermissionsResponseUnmarshaller.Instance;

            return Invoke<DescribeConnectionAliasPermissionsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeConnectionAliasPermissions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeConnectionAliasPermissions operation on AmazonWorkSpacesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeConnectionAliasPermissions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/DescribeConnectionAliasPermissions">REST API Reference for DescribeConnectionAliasPermissions Operation</seealso>
        public virtual IAsyncResult BeginDescribeConnectionAliasPermissions(DescribeConnectionAliasPermissionsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeConnectionAliasPermissionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeConnectionAliasPermissionsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeConnectionAliasPermissions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeConnectionAliasPermissions.</param>
        /// 
        /// <returns>Returns a  DescribeConnectionAliasPermissionsResult from WorkSpaces.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/DescribeConnectionAliasPermissions">REST API Reference for DescribeConnectionAliasPermissions Operation</seealso>
        public virtual DescribeConnectionAliasPermissionsResponse EndDescribeConnectionAliasPermissions(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeConnectionAliasPermissionsResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeCustomWorkspaceImageImport

        /// <summary>
        /// Retrieves information about a WorkSpace BYOL image being imported via ImportCustomWorkspaceImage.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeCustomWorkspaceImageImport service method.</param>
        /// 
        /// <returns>The response from the DescribeCustomWorkspaceImageImport service method, as returned by WorkSpaces.</returns>
        /// <exception cref="Amazon.WorkSpaces.Model.AccessDeniedException">
        /// The user is not authorized to access a resource.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/DescribeCustomWorkspaceImageImport">REST API Reference for DescribeCustomWorkspaceImageImport Operation</seealso>
        public virtual DescribeCustomWorkspaceImageImportResponse DescribeCustomWorkspaceImageImport(DescribeCustomWorkspaceImageImportRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeCustomWorkspaceImageImportRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeCustomWorkspaceImageImportResponseUnmarshaller.Instance;

            return Invoke<DescribeCustomWorkspaceImageImportResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeCustomWorkspaceImageImport operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeCustomWorkspaceImageImport operation on AmazonWorkSpacesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeCustomWorkspaceImageImport
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/DescribeCustomWorkspaceImageImport">REST API Reference for DescribeCustomWorkspaceImageImport Operation</seealso>
        public virtual IAsyncResult BeginDescribeCustomWorkspaceImageImport(DescribeCustomWorkspaceImageImportRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeCustomWorkspaceImageImportRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeCustomWorkspaceImageImportResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeCustomWorkspaceImageImport operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeCustomWorkspaceImageImport.</param>
        /// 
        /// <returns>Returns a  DescribeCustomWorkspaceImageImportResult from WorkSpaces.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/DescribeCustomWorkspaceImageImport">REST API Reference for DescribeCustomWorkspaceImageImport Operation</seealso>
        public virtual DescribeCustomWorkspaceImageImportResponse EndDescribeCustomWorkspaceImageImport(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeCustomWorkspaceImageImportResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeImageAssociations

        /// <summary>
        /// Describes the associations between the applications and the specified image.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeImageAssociations service method.</param>
        /// 
        /// <returns>The response from the DescribeImageAssociations service method, as returned by WorkSpaces.</returns>
        /// <exception cref="Amazon.WorkSpaces.Model.AccessDeniedException">
        /// The user is not authorized to access a resource.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.InvalidParameterValuesException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.OperationNotSupportedException">
        /// This operation is not supported.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/DescribeImageAssociations">REST API Reference for DescribeImageAssociations Operation</seealso>
        public virtual DescribeImageAssociationsResponse DescribeImageAssociations(DescribeImageAssociationsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeImageAssociationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeImageAssociationsResponseUnmarshaller.Instance;

            return Invoke<DescribeImageAssociationsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeImageAssociations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeImageAssociations operation on AmazonWorkSpacesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeImageAssociations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/DescribeImageAssociations">REST API Reference for DescribeImageAssociations Operation</seealso>
        public virtual IAsyncResult BeginDescribeImageAssociations(DescribeImageAssociationsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeImageAssociationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeImageAssociationsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeImageAssociations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeImageAssociations.</param>
        /// 
        /// <returns>Returns a  DescribeImageAssociationsResult from WorkSpaces.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/DescribeImageAssociations">REST API Reference for DescribeImageAssociations Operation</seealso>
        public virtual DescribeImageAssociationsResponse EndDescribeImageAssociations(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeImageAssociationsResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeIpGroups

        /// <summary>
        /// Describes one or more of your IP access control groups.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeIpGroups service method.</param>
        /// 
        /// <returns>The response from the DescribeIpGroups service method, as returned by WorkSpaces.</returns>
        /// <exception cref="Amazon.WorkSpaces.Model.AccessDeniedException">
        /// The user is not authorized to access a resource.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.InvalidParameterValuesException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/DescribeIpGroups">REST API Reference for DescribeIpGroups Operation</seealso>
        public virtual DescribeIpGroupsResponse DescribeIpGroups(DescribeIpGroupsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeIpGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeIpGroupsResponseUnmarshaller.Instance;

            return Invoke<DescribeIpGroupsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeIpGroups operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeIpGroups operation on AmazonWorkSpacesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeIpGroups
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/DescribeIpGroups">REST API Reference for DescribeIpGroups Operation</seealso>
        public virtual IAsyncResult BeginDescribeIpGroups(DescribeIpGroupsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeIpGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeIpGroupsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeIpGroups operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeIpGroups.</param>
        /// 
        /// <returns>Returns a  DescribeIpGroupsResult from WorkSpaces.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/DescribeIpGroups">REST API Reference for DescribeIpGroups Operation</seealso>
        public virtual DescribeIpGroupsResponse EndDescribeIpGroups(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeIpGroupsResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeTags

        /// <summary>
        /// Describes the specified tags for the specified WorkSpaces resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeTags service method.</param>
        /// 
        /// <returns>The response from the DescribeTags service method, as returned by WorkSpaces.</returns>
        /// <exception cref="Amazon.WorkSpaces.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/DescribeTags">REST API Reference for DescribeTags Operation</seealso>
        public virtual DescribeTagsResponse DescribeTags(DescribeTagsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeTagsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeTagsResponseUnmarshaller.Instance;

            return Invoke<DescribeTagsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeTags operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeTags operation on AmazonWorkSpacesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeTags
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/DescribeTags">REST API Reference for DescribeTags Operation</seealso>
        public virtual IAsyncResult BeginDescribeTags(DescribeTagsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeTagsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeTagsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeTags operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeTags.</param>
        /// 
        /// <returns>Returns a  DescribeTagsResult from WorkSpaces.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/DescribeTags">REST API Reference for DescribeTags Operation</seealso>
        public virtual DescribeTagsResponse EndDescribeTags(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeTagsResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeWorkspaceAssociations

        /// <summary>
        /// Describes the associations betweens applications and the specified WorkSpace.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeWorkspaceAssociations service method.</param>
        /// 
        /// <returns>The response from the DescribeWorkspaceAssociations service method, as returned by WorkSpaces.</returns>
        /// <exception cref="Amazon.WorkSpaces.Model.AccessDeniedException">
        /// The user is not authorized to access a resource.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.InvalidParameterValuesException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.OperationNotSupportedException">
        /// This operation is not supported.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/DescribeWorkspaceAssociations">REST API Reference for DescribeWorkspaceAssociations Operation</seealso>
        public virtual DescribeWorkspaceAssociationsResponse DescribeWorkspaceAssociations(DescribeWorkspaceAssociationsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeWorkspaceAssociationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeWorkspaceAssociationsResponseUnmarshaller.Instance;

            return Invoke<DescribeWorkspaceAssociationsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeWorkspaceAssociations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeWorkspaceAssociations operation on AmazonWorkSpacesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeWorkspaceAssociations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/DescribeWorkspaceAssociations">REST API Reference for DescribeWorkspaceAssociations Operation</seealso>
        public virtual IAsyncResult BeginDescribeWorkspaceAssociations(DescribeWorkspaceAssociationsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeWorkspaceAssociationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeWorkspaceAssociationsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeWorkspaceAssociations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeWorkspaceAssociations.</param>
        /// 
        /// <returns>Returns a  DescribeWorkspaceAssociationsResult from WorkSpaces.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/DescribeWorkspaceAssociations">REST API Reference for DescribeWorkspaceAssociations Operation</seealso>
        public virtual DescribeWorkspaceAssociationsResponse EndDescribeWorkspaceAssociations(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeWorkspaceAssociationsResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeWorkspaceBundles

        /// <summary>
        /// Retrieves a list that describes the available WorkSpace bundles.
        /// 
        ///  
        /// <para>
        /// You can filter the results using either bundle ID or owner, but not both.
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeWorkspaceBundles service method, as returned by WorkSpaces.</returns>
        /// <exception cref="Amazon.WorkSpaces.Model.InvalidParameterValuesException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/DescribeWorkspaceBundles">REST API Reference for DescribeWorkspaceBundles Operation</seealso>
        public virtual DescribeWorkspaceBundlesResponse DescribeWorkspaceBundles()
        {
            var request = new DescribeWorkspaceBundlesRequest();
            return DescribeWorkspaceBundles(request);
        }


        /// <summary>
        /// Retrieves a list that describes the available WorkSpace bundles.
        /// 
        ///  
        /// <para>
        /// You can filter the results using either bundle ID or owner, but not both.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeWorkspaceBundles service method.</param>
        /// 
        /// <returns>The response from the DescribeWorkspaceBundles service method, as returned by WorkSpaces.</returns>
        /// <exception cref="Amazon.WorkSpaces.Model.InvalidParameterValuesException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/DescribeWorkspaceBundles">REST API Reference for DescribeWorkspaceBundles Operation</seealso>
        public virtual DescribeWorkspaceBundlesResponse DescribeWorkspaceBundles(DescribeWorkspaceBundlesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeWorkspaceBundlesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeWorkspaceBundlesResponseUnmarshaller.Instance;

            return Invoke<DescribeWorkspaceBundlesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeWorkspaceBundles operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeWorkspaceBundles operation on AmazonWorkSpacesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeWorkspaceBundles
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/DescribeWorkspaceBundles">REST API Reference for DescribeWorkspaceBundles Operation</seealso>
        public virtual IAsyncResult BeginDescribeWorkspaceBundles(DescribeWorkspaceBundlesRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeWorkspaceBundlesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeWorkspaceBundlesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeWorkspaceBundles operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeWorkspaceBundles.</param>
        /// 
        /// <returns>Returns a  DescribeWorkspaceBundlesResult from WorkSpaces.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/DescribeWorkspaceBundles">REST API Reference for DescribeWorkspaceBundles Operation</seealso>
        public virtual DescribeWorkspaceBundlesResponse EndDescribeWorkspaceBundles(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeWorkspaceBundlesResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeWorkspaceDirectories

        /// <summary>
        /// Describes the available directories that are registered with Amazon WorkSpaces.
        /// </summary>
        /// 
        /// <returns>The response from the DescribeWorkspaceDirectories service method, as returned by WorkSpaces.</returns>
        /// <exception cref="Amazon.WorkSpaces.Model.InvalidParameterValuesException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/DescribeWorkspaceDirectories">REST API Reference for DescribeWorkspaceDirectories Operation</seealso>
        public virtual DescribeWorkspaceDirectoriesResponse DescribeWorkspaceDirectories()
        {
            var request = new DescribeWorkspaceDirectoriesRequest();
            return DescribeWorkspaceDirectories(request);
        }


        /// <summary>
        /// Describes the available directories that are registered with Amazon WorkSpaces.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeWorkspaceDirectories service method.</param>
        /// 
        /// <returns>The response from the DescribeWorkspaceDirectories service method, as returned by WorkSpaces.</returns>
        /// <exception cref="Amazon.WorkSpaces.Model.InvalidParameterValuesException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/DescribeWorkspaceDirectories">REST API Reference for DescribeWorkspaceDirectories Operation</seealso>
        public virtual DescribeWorkspaceDirectoriesResponse DescribeWorkspaceDirectories(DescribeWorkspaceDirectoriesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeWorkspaceDirectoriesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeWorkspaceDirectoriesResponseUnmarshaller.Instance;

            return Invoke<DescribeWorkspaceDirectoriesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeWorkspaceDirectories operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeWorkspaceDirectories operation on AmazonWorkSpacesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeWorkspaceDirectories
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/DescribeWorkspaceDirectories">REST API Reference for DescribeWorkspaceDirectories Operation</seealso>
        public virtual IAsyncResult BeginDescribeWorkspaceDirectories(DescribeWorkspaceDirectoriesRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeWorkspaceDirectoriesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeWorkspaceDirectoriesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeWorkspaceDirectories operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeWorkspaceDirectories.</param>
        /// 
        /// <returns>Returns a  DescribeWorkspaceDirectoriesResult from WorkSpaces.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/DescribeWorkspaceDirectories">REST API Reference for DescribeWorkspaceDirectories Operation</seealso>
        public virtual DescribeWorkspaceDirectoriesResponse EndDescribeWorkspaceDirectories(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeWorkspaceDirectoriesResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeWorkspaceImagePermissions

        /// <summary>
        /// Describes the permissions that the owner of an image has granted to other Amazon Web
        /// Services accounts for an image.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeWorkspaceImagePermissions service method.</param>
        /// 
        /// <returns>The response from the DescribeWorkspaceImagePermissions service method, as returned by WorkSpaces.</returns>
        /// <exception cref="Amazon.WorkSpaces.Model.AccessDeniedException">
        /// The user is not authorized to access a resource.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.InvalidParameterValuesException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/DescribeWorkspaceImagePermissions">REST API Reference for DescribeWorkspaceImagePermissions Operation</seealso>
        public virtual DescribeWorkspaceImagePermissionsResponse DescribeWorkspaceImagePermissions(DescribeWorkspaceImagePermissionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeWorkspaceImagePermissionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeWorkspaceImagePermissionsResponseUnmarshaller.Instance;

            return Invoke<DescribeWorkspaceImagePermissionsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeWorkspaceImagePermissions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeWorkspaceImagePermissions operation on AmazonWorkSpacesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeWorkspaceImagePermissions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/DescribeWorkspaceImagePermissions">REST API Reference for DescribeWorkspaceImagePermissions Operation</seealso>
        public virtual IAsyncResult BeginDescribeWorkspaceImagePermissions(DescribeWorkspaceImagePermissionsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeWorkspaceImagePermissionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeWorkspaceImagePermissionsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeWorkspaceImagePermissions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeWorkspaceImagePermissions.</param>
        /// 
        /// <returns>Returns a  DescribeWorkspaceImagePermissionsResult from WorkSpaces.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/DescribeWorkspaceImagePermissions">REST API Reference for DescribeWorkspaceImagePermissions Operation</seealso>
        public virtual DescribeWorkspaceImagePermissionsResponse EndDescribeWorkspaceImagePermissions(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeWorkspaceImagePermissionsResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeWorkspaceImages

        /// <summary>
        /// Retrieves a list that describes one or more specified images, if the image identifiers
        /// are provided. Otherwise, all images in the account are described.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeWorkspaceImages service method.</param>
        /// 
        /// <returns>The response from the DescribeWorkspaceImages service method, as returned by WorkSpaces.</returns>
        /// <exception cref="Amazon.WorkSpaces.Model.AccessDeniedException">
        /// The user is not authorized to access a resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/DescribeWorkspaceImages">REST API Reference for DescribeWorkspaceImages Operation</seealso>
        public virtual DescribeWorkspaceImagesResponse DescribeWorkspaceImages(DescribeWorkspaceImagesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeWorkspaceImagesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeWorkspaceImagesResponseUnmarshaller.Instance;

            return Invoke<DescribeWorkspaceImagesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeWorkspaceImages operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeWorkspaceImages operation on AmazonWorkSpacesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeWorkspaceImages
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/DescribeWorkspaceImages">REST API Reference for DescribeWorkspaceImages Operation</seealso>
        public virtual IAsyncResult BeginDescribeWorkspaceImages(DescribeWorkspaceImagesRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeWorkspaceImagesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeWorkspaceImagesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeWorkspaceImages operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeWorkspaceImages.</param>
        /// 
        /// <returns>Returns a  DescribeWorkspaceImagesResult from WorkSpaces.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/DescribeWorkspaceImages">REST API Reference for DescribeWorkspaceImages Operation</seealso>
        public virtual DescribeWorkspaceImagesResponse EndDescribeWorkspaceImages(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeWorkspaceImagesResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeWorkspaces

        /// <summary>
        /// Describes the specified WorkSpaces.
        /// 
        ///  
        /// <para>
        /// You can filter the results by using the bundle identifier, directory identifier, or
        /// owner, but you can specify only one filter at a time.
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeWorkspaces service method, as returned by WorkSpaces.</returns>
        /// <exception cref="Amazon.WorkSpaces.Model.InvalidParameterValuesException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.ResourceUnavailableException">
        /// The specified resource is not available.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/DescribeWorkspaces">REST API Reference for DescribeWorkspaces Operation</seealso>
        public virtual DescribeWorkspacesResponse DescribeWorkspaces()
        {
            var request = new DescribeWorkspacesRequest();
            return DescribeWorkspaces(request);
        }


        /// <summary>
        /// Describes the specified WorkSpaces.
        /// 
        ///  
        /// <para>
        /// You can filter the results by using the bundle identifier, directory identifier, or
        /// owner, but you can specify only one filter at a time.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeWorkspaces service method.</param>
        /// 
        /// <returns>The response from the DescribeWorkspaces service method, as returned by WorkSpaces.</returns>
        /// <exception cref="Amazon.WorkSpaces.Model.InvalidParameterValuesException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.ResourceUnavailableException">
        /// The specified resource is not available.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/DescribeWorkspaces">REST API Reference for DescribeWorkspaces Operation</seealso>
        public virtual DescribeWorkspacesResponse DescribeWorkspaces(DescribeWorkspacesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeWorkspacesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeWorkspacesResponseUnmarshaller.Instance;

            return Invoke<DescribeWorkspacesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeWorkspaces operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeWorkspaces operation on AmazonWorkSpacesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeWorkspaces
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/DescribeWorkspaces">REST API Reference for DescribeWorkspaces Operation</seealso>
        public virtual IAsyncResult BeginDescribeWorkspaces(DescribeWorkspacesRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeWorkspacesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeWorkspacesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeWorkspaces operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeWorkspaces.</param>
        /// 
        /// <returns>Returns a  DescribeWorkspacesResult from WorkSpaces.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/DescribeWorkspaces">REST API Reference for DescribeWorkspaces Operation</seealso>
        public virtual DescribeWorkspacesResponse EndDescribeWorkspaces(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeWorkspacesResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeWorkspacesConnectionStatus

        /// <summary>
        /// Describes the connection status of the specified WorkSpaces.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeWorkspacesConnectionStatus service method.</param>
        /// 
        /// <returns>The response from the DescribeWorkspacesConnectionStatus service method, as returned by WorkSpaces.</returns>
        /// <exception cref="Amazon.WorkSpaces.Model.InvalidParameterValuesException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/DescribeWorkspacesConnectionStatus">REST API Reference for DescribeWorkspacesConnectionStatus Operation</seealso>
        public virtual DescribeWorkspacesConnectionStatusResponse DescribeWorkspacesConnectionStatus(DescribeWorkspacesConnectionStatusRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeWorkspacesConnectionStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeWorkspacesConnectionStatusResponseUnmarshaller.Instance;

            return Invoke<DescribeWorkspacesConnectionStatusResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeWorkspacesConnectionStatus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeWorkspacesConnectionStatus operation on AmazonWorkSpacesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeWorkspacesConnectionStatus
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/DescribeWorkspacesConnectionStatus">REST API Reference for DescribeWorkspacesConnectionStatus Operation</seealso>
        public virtual IAsyncResult BeginDescribeWorkspacesConnectionStatus(DescribeWorkspacesConnectionStatusRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeWorkspacesConnectionStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeWorkspacesConnectionStatusResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeWorkspacesConnectionStatus operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeWorkspacesConnectionStatus.</param>
        /// 
        /// <returns>Returns a  DescribeWorkspacesConnectionStatusResult from WorkSpaces.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/DescribeWorkspacesConnectionStatus">REST API Reference for DescribeWorkspacesConnectionStatus Operation</seealso>
        public virtual DescribeWorkspacesConnectionStatusResponse EndDescribeWorkspacesConnectionStatus(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeWorkspacesConnectionStatusResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeWorkspaceSnapshots

        /// <summary>
        /// Describes the snapshots for the specified WorkSpace.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeWorkspaceSnapshots service method.</param>
        /// 
        /// <returns>The response from the DescribeWorkspaceSnapshots service method, as returned by WorkSpaces.</returns>
        /// <exception cref="Amazon.WorkSpaces.Model.AccessDeniedException">
        /// The user is not authorized to access a resource.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.InvalidParameterValuesException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/DescribeWorkspaceSnapshots">REST API Reference for DescribeWorkspaceSnapshots Operation</seealso>
        public virtual DescribeWorkspaceSnapshotsResponse DescribeWorkspaceSnapshots(DescribeWorkspaceSnapshotsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeWorkspaceSnapshotsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeWorkspaceSnapshotsResponseUnmarshaller.Instance;

            return Invoke<DescribeWorkspaceSnapshotsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeWorkspaceSnapshots operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeWorkspaceSnapshots operation on AmazonWorkSpacesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeWorkspaceSnapshots
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/DescribeWorkspaceSnapshots">REST API Reference for DescribeWorkspaceSnapshots Operation</seealso>
        public virtual IAsyncResult BeginDescribeWorkspaceSnapshots(DescribeWorkspaceSnapshotsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeWorkspaceSnapshotsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeWorkspaceSnapshotsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeWorkspaceSnapshots operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeWorkspaceSnapshots.</param>
        /// 
        /// <returns>Returns a  DescribeWorkspaceSnapshotsResult from WorkSpaces.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/DescribeWorkspaceSnapshots">REST API Reference for DescribeWorkspaceSnapshots Operation</seealso>
        public virtual DescribeWorkspaceSnapshotsResponse EndDescribeWorkspaceSnapshots(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeWorkspaceSnapshotsResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeWorkspacesPools

        /// <summary>
        /// Describes the specified WorkSpaces Pools.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeWorkspacesPools service method.</param>
        /// 
        /// <returns>The response from the DescribeWorkspacesPools service method, as returned by WorkSpaces.</returns>
        /// <exception cref="Amazon.WorkSpaces.Model.AccessDeniedException">
        /// The user is not authorized to access a resource.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.InvalidParameterValuesException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/DescribeWorkspacesPools">REST API Reference for DescribeWorkspacesPools Operation</seealso>
        public virtual DescribeWorkspacesPoolsResponse DescribeWorkspacesPools(DescribeWorkspacesPoolsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeWorkspacesPoolsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeWorkspacesPoolsResponseUnmarshaller.Instance;

            return Invoke<DescribeWorkspacesPoolsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeWorkspacesPools operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeWorkspacesPools operation on AmazonWorkSpacesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeWorkspacesPools
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/DescribeWorkspacesPools">REST API Reference for DescribeWorkspacesPools Operation</seealso>
        public virtual IAsyncResult BeginDescribeWorkspacesPools(DescribeWorkspacesPoolsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeWorkspacesPoolsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeWorkspacesPoolsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeWorkspacesPools operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeWorkspacesPools.</param>
        /// 
        /// <returns>Returns a  DescribeWorkspacesPoolsResult from WorkSpaces.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/DescribeWorkspacesPools">REST API Reference for DescribeWorkspacesPools Operation</seealso>
        public virtual DescribeWorkspacesPoolsResponse EndDescribeWorkspacesPools(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeWorkspacesPoolsResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeWorkspacesPoolSessions

        /// <summary>
        /// Retrieves a list that describes the streaming sessions for a specified pool.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeWorkspacesPoolSessions service method.</param>
        /// 
        /// <returns>The response from the DescribeWorkspacesPoolSessions service method, as returned by WorkSpaces.</returns>
        /// <exception cref="Amazon.WorkSpaces.Model.AccessDeniedException">
        /// The user is not authorized to access a resource.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.InvalidParameterValuesException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/DescribeWorkspacesPoolSessions">REST API Reference for DescribeWorkspacesPoolSessions Operation</seealso>
        public virtual DescribeWorkspacesPoolSessionsResponse DescribeWorkspacesPoolSessions(DescribeWorkspacesPoolSessionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeWorkspacesPoolSessionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeWorkspacesPoolSessionsResponseUnmarshaller.Instance;

            return Invoke<DescribeWorkspacesPoolSessionsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeWorkspacesPoolSessions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeWorkspacesPoolSessions operation on AmazonWorkSpacesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeWorkspacesPoolSessions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/DescribeWorkspacesPoolSessions">REST API Reference for DescribeWorkspacesPoolSessions Operation</seealso>
        public virtual IAsyncResult BeginDescribeWorkspacesPoolSessions(DescribeWorkspacesPoolSessionsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeWorkspacesPoolSessionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeWorkspacesPoolSessionsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeWorkspacesPoolSessions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeWorkspacesPoolSessions.</param>
        /// 
        /// <returns>Returns a  DescribeWorkspacesPoolSessionsResult from WorkSpaces.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/DescribeWorkspacesPoolSessions">REST API Reference for DescribeWorkspacesPoolSessions Operation</seealso>
        public virtual DescribeWorkspacesPoolSessionsResponse EndDescribeWorkspacesPoolSessions(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeWorkspacesPoolSessionsResponse>(asyncResult);
        }

        #endregion
        
        #region  DisassociateConnectionAlias

        /// <summary>
        /// Disassociates a connection alias from a directory. Disassociating a connection alias
        /// disables cross-Region redirection between two directories in different Regions. For
        /// more information, see <a href="https://docs.aws.amazon.com/workspaces/latest/adminguide/cross-region-redirection.html">
        /// Cross-Region Redirection for Amazon WorkSpaces</a>.
        /// 
        ///  <note> 
        /// <para>
        /// Before performing this operation, call <a href="https://docs.aws.amazon.com/workspaces/latest/api/API_DescribeConnectionAliases.html">
        /// DescribeConnectionAliases</a> to make sure that the current state of the connection
        /// alias is <c>CREATED</c>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateConnectionAlias service method.</param>
        /// 
        /// <returns>The response from the DisassociateConnectionAlias service method, as returned by WorkSpaces.</returns>
        /// <exception cref="Amazon.WorkSpaces.Model.AccessDeniedException">
        /// The user is not authorized to access a resource.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.InvalidParameterValuesException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.InvalidResourceStateException">
        /// The state of the resource is not valid for this operation.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.OperationNotSupportedException">
        /// This operation is not supported.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/DisassociateConnectionAlias">REST API Reference for DisassociateConnectionAlias Operation</seealso>
        public virtual DisassociateConnectionAliasResponse DisassociateConnectionAlias(DisassociateConnectionAliasRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DisassociateConnectionAliasRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateConnectionAliasResponseUnmarshaller.Instance;

            return Invoke<DisassociateConnectionAliasResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateConnectionAlias operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateConnectionAlias operation on AmazonWorkSpacesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisassociateConnectionAlias
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/DisassociateConnectionAlias">REST API Reference for DisassociateConnectionAlias Operation</seealso>
        public virtual IAsyncResult BeginDisassociateConnectionAlias(DisassociateConnectionAliasRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DisassociateConnectionAliasRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateConnectionAliasResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DisassociateConnectionAlias operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisassociateConnectionAlias.</param>
        /// 
        /// <returns>Returns a  DisassociateConnectionAliasResult from WorkSpaces.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/DisassociateConnectionAlias">REST API Reference for DisassociateConnectionAlias Operation</seealso>
        public virtual DisassociateConnectionAliasResponse EndDisassociateConnectionAlias(IAsyncResult asyncResult)
        {
            return EndInvoke<DisassociateConnectionAliasResponse>(asyncResult);
        }

        #endregion
        
        #region  DisassociateIpGroups

        /// <summary>
        /// Disassociates the specified IP access control group from the specified directory.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateIpGroups service method.</param>
        /// 
        /// <returns>The response from the DisassociateIpGroups service method, as returned by WorkSpaces.</returns>
        /// <exception cref="Amazon.WorkSpaces.Model.AccessDeniedException">
        /// The user is not authorized to access a resource.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.InvalidParameterValuesException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.InvalidResourceStateException">
        /// The state of the resource is not valid for this operation.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.OperationNotSupportedException">
        /// This operation is not supported.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/DisassociateIpGroups">REST API Reference for DisassociateIpGroups Operation</seealso>
        public virtual DisassociateIpGroupsResponse DisassociateIpGroups(DisassociateIpGroupsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DisassociateIpGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateIpGroupsResponseUnmarshaller.Instance;

            return Invoke<DisassociateIpGroupsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateIpGroups operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateIpGroups operation on AmazonWorkSpacesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisassociateIpGroups
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/DisassociateIpGroups">REST API Reference for DisassociateIpGroups Operation</seealso>
        public virtual IAsyncResult BeginDisassociateIpGroups(DisassociateIpGroupsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DisassociateIpGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateIpGroupsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DisassociateIpGroups operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisassociateIpGroups.</param>
        /// 
        /// <returns>Returns a  DisassociateIpGroupsResult from WorkSpaces.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/DisassociateIpGroups">REST API Reference for DisassociateIpGroups Operation</seealso>
        public virtual DisassociateIpGroupsResponse EndDisassociateIpGroups(IAsyncResult asyncResult)
        {
            return EndInvoke<DisassociateIpGroupsResponse>(asyncResult);
        }

        #endregion
        
        #region  DisassociateWorkspaceApplication

        /// <summary>
        /// Disassociates the specified application from a WorkSpace.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateWorkspaceApplication service method.</param>
        /// 
        /// <returns>The response from the DisassociateWorkspaceApplication service method, as returned by WorkSpaces.</returns>
        /// <exception cref="Amazon.WorkSpaces.Model.AccessDeniedException">
        /// The user is not authorized to access a resource.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.InvalidParameterValuesException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.OperationNotSupportedException">
        /// This operation is not supported.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.ResourceInUseException">
        /// The specified resource is currently in use.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/DisassociateWorkspaceApplication">REST API Reference for DisassociateWorkspaceApplication Operation</seealso>
        public virtual DisassociateWorkspaceApplicationResponse DisassociateWorkspaceApplication(DisassociateWorkspaceApplicationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DisassociateWorkspaceApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateWorkspaceApplicationResponseUnmarshaller.Instance;

            return Invoke<DisassociateWorkspaceApplicationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateWorkspaceApplication operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateWorkspaceApplication operation on AmazonWorkSpacesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisassociateWorkspaceApplication
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/DisassociateWorkspaceApplication">REST API Reference for DisassociateWorkspaceApplication Operation</seealso>
        public virtual IAsyncResult BeginDisassociateWorkspaceApplication(DisassociateWorkspaceApplicationRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DisassociateWorkspaceApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateWorkspaceApplicationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DisassociateWorkspaceApplication operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisassociateWorkspaceApplication.</param>
        /// 
        /// <returns>Returns a  DisassociateWorkspaceApplicationResult from WorkSpaces.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/DisassociateWorkspaceApplication">REST API Reference for DisassociateWorkspaceApplication Operation</seealso>
        public virtual DisassociateWorkspaceApplicationResponse EndDisassociateWorkspaceApplication(IAsyncResult asyncResult)
        {
            return EndInvoke<DisassociateWorkspaceApplicationResponse>(asyncResult);
        }

        #endregion
        
        #region  GetAccountLink

        /// <summary>
        /// Retrieves account link information.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAccountLink service method.</param>
        /// 
        /// <returns>The response from the GetAccountLink service method, as returned by WorkSpaces.</returns>
        /// <exception cref="Amazon.WorkSpaces.Model.AccessDeniedException">
        /// The user is not authorized to access a resource.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.InternalServerException">
        /// Unexpected server error occured.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.ValidationException">
        /// You either haven't provided a <c>TargetAccountId</c> or are using the same value for
        /// <c>TargetAccountId</c> and <c>SourceAccountId</c>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/GetAccountLink">REST API Reference for GetAccountLink Operation</seealso>
        public virtual GetAccountLinkResponse GetAccountLink(GetAccountLinkRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetAccountLinkRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAccountLinkResponseUnmarshaller.Instance;

            return Invoke<GetAccountLinkResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetAccountLink operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetAccountLink operation on AmazonWorkSpacesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetAccountLink
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/GetAccountLink">REST API Reference for GetAccountLink Operation</seealso>
        public virtual IAsyncResult BeginGetAccountLink(GetAccountLinkRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetAccountLinkRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAccountLinkResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetAccountLink operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetAccountLink.</param>
        /// 
        /// <returns>Returns a  GetAccountLinkResult from WorkSpaces.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/GetAccountLink">REST API Reference for GetAccountLink Operation</seealso>
        public virtual GetAccountLinkResponse EndGetAccountLink(IAsyncResult asyncResult)
        {
            return EndInvoke<GetAccountLinkResponse>(asyncResult);
        }

        #endregion
        
        #region  ImportClientBranding

        /// <summary>
        /// Imports client branding. Client branding allows you to customize your WorkSpace's
        /// client login portal. You can tailor your login portal company logo, the support email
        /// address, support link, link to reset password, and a custom message for users trying
        /// to sign in.
        /// 
        ///  
        /// <para>
        /// After you import client branding, the default branding experience for the specified
        /// platform type is replaced with the imported experience
        /// </para>
        ///  <note> <ul> <li> 
        /// <para>
        /// You must specify at least one platform type when importing client branding.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You can import up to 6 MB of data with each request. If your request exceeds this
        /// limit, you can import client branding for different platform types using separate
        /// requests.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// In each platform type, the <c>SupportEmail</c> and <c>SupportLink</c> parameters are
        /// mutually exclusive. You can specify only one parameter for each platform type, but
        /// not both.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Imported data can take up to a minute to appear in the WorkSpaces client.
        /// </para>
        ///  </li> </ul> </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ImportClientBranding service method.</param>
        /// 
        /// <returns>The response from the ImportClientBranding service method, as returned by WorkSpaces.</returns>
        /// <exception cref="Amazon.WorkSpaces.Model.AccessDeniedException">
        /// The user is not authorized to access a resource.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.InvalidParameterValuesException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.ResourceLimitExceededException">
        /// Your resource limits have been exceeded.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/ImportClientBranding">REST API Reference for ImportClientBranding Operation</seealso>
        public virtual ImportClientBrandingResponse ImportClientBranding(ImportClientBrandingRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ImportClientBrandingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ImportClientBrandingResponseUnmarshaller.Instance;

            return Invoke<ImportClientBrandingResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ImportClientBranding operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ImportClientBranding operation on AmazonWorkSpacesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndImportClientBranding
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/ImportClientBranding">REST API Reference for ImportClientBranding Operation</seealso>
        public virtual IAsyncResult BeginImportClientBranding(ImportClientBrandingRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ImportClientBrandingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ImportClientBrandingResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ImportClientBranding operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginImportClientBranding.</param>
        /// 
        /// <returns>Returns a  ImportClientBrandingResult from WorkSpaces.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/ImportClientBranding">REST API Reference for ImportClientBranding Operation</seealso>
        public virtual ImportClientBrandingResponse EndImportClientBranding(IAsyncResult asyncResult)
        {
            return EndInvoke<ImportClientBrandingResponse>(asyncResult);
        }

        #endregion
        
        #region  ImportCustomWorkspaceImage

        /// <summary>
        /// Imports the specified Windows 10 or 11 Bring Your Own License (BYOL) image into Amazon
        /// WorkSpaces using EC2 Image Builder. The image must be an already licensed image that
        /// is in your Amazon Web Services account, and you must own the image. For more information
        /// about creating BYOL images, see <a href="https://docs.aws.amazon.com/workspaces/latest/adminguide/byol-windows-images.html">
        /// Bring Your Own Windows Desktop Licenses</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ImportCustomWorkspaceImage service method.</param>
        /// 
        /// <returns>The response from the ImportCustomWorkspaceImage service method, as returned by WorkSpaces.</returns>
        /// <exception cref="Amazon.WorkSpaces.Model.AccessDeniedException">
        /// The user is not authorized to access a resource.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.InvalidParameterValuesException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.OperationNotSupportedException">
        /// This operation is not supported.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.ResourceAlreadyExistsException">
        /// The specified resource already exists.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.ResourceLimitExceededException">
        /// Your resource limits have been exceeded.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/ImportCustomWorkspaceImage">REST API Reference for ImportCustomWorkspaceImage Operation</seealso>
        public virtual ImportCustomWorkspaceImageResponse ImportCustomWorkspaceImage(ImportCustomWorkspaceImageRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ImportCustomWorkspaceImageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ImportCustomWorkspaceImageResponseUnmarshaller.Instance;

            return Invoke<ImportCustomWorkspaceImageResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ImportCustomWorkspaceImage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ImportCustomWorkspaceImage operation on AmazonWorkSpacesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndImportCustomWorkspaceImage
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/ImportCustomWorkspaceImage">REST API Reference for ImportCustomWorkspaceImage Operation</seealso>
        public virtual IAsyncResult BeginImportCustomWorkspaceImage(ImportCustomWorkspaceImageRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ImportCustomWorkspaceImageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ImportCustomWorkspaceImageResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ImportCustomWorkspaceImage operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginImportCustomWorkspaceImage.</param>
        /// 
        /// <returns>Returns a  ImportCustomWorkspaceImageResult from WorkSpaces.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/ImportCustomWorkspaceImage">REST API Reference for ImportCustomWorkspaceImage Operation</seealso>
        public virtual ImportCustomWorkspaceImageResponse EndImportCustomWorkspaceImage(IAsyncResult asyncResult)
        {
            return EndInvoke<ImportCustomWorkspaceImageResponse>(asyncResult);
        }

        #endregion
        
        #region  ImportWorkspaceImage

        /// <summary>
        /// Imports the specified Windows 10 or 11 Bring Your Own License (BYOL) image into Amazon
        /// WorkSpaces. The image must be an already licensed Amazon EC2 image that is in your
        /// Amazon Web Services account, and you must own the image. For more information about
        /// creating BYOL images, see <a href="https://docs.aws.amazon.com/workspaces/latest/adminguide/byol-windows-images.html">
        /// Bring Your Own Windows Desktop Licenses</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ImportWorkspaceImage service method.</param>
        /// 
        /// <returns>The response from the ImportWorkspaceImage service method, as returned by WorkSpaces.</returns>
        /// <exception cref="Amazon.WorkSpaces.Model.AccessDeniedException">
        /// The user is not authorized to access a resource.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.InvalidParameterValuesException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.OperationNotSupportedException">
        /// This operation is not supported.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.ResourceAlreadyExistsException">
        /// The specified resource already exists.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.ResourceLimitExceededException">
        /// Your resource limits have been exceeded.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/ImportWorkspaceImage">REST API Reference for ImportWorkspaceImage Operation</seealso>
        public virtual ImportWorkspaceImageResponse ImportWorkspaceImage(ImportWorkspaceImageRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ImportWorkspaceImageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ImportWorkspaceImageResponseUnmarshaller.Instance;

            return Invoke<ImportWorkspaceImageResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ImportWorkspaceImage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ImportWorkspaceImage operation on AmazonWorkSpacesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndImportWorkspaceImage
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/ImportWorkspaceImage">REST API Reference for ImportWorkspaceImage Operation</seealso>
        public virtual IAsyncResult BeginImportWorkspaceImage(ImportWorkspaceImageRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ImportWorkspaceImageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ImportWorkspaceImageResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ImportWorkspaceImage operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginImportWorkspaceImage.</param>
        /// 
        /// <returns>Returns a  ImportWorkspaceImageResult from WorkSpaces.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/ImportWorkspaceImage">REST API Reference for ImportWorkspaceImage Operation</seealso>
        public virtual ImportWorkspaceImageResponse EndImportWorkspaceImage(IAsyncResult asyncResult)
        {
            return EndInvoke<ImportWorkspaceImageResponse>(asyncResult);
        }

        #endregion
        
        #region  ListAccountLinks

        /// <summary>
        /// Lists all account links.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAccountLinks service method.</param>
        /// 
        /// <returns>The response from the ListAccountLinks service method, as returned by WorkSpaces.</returns>
        /// <exception cref="Amazon.WorkSpaces.Model.AccessDeniedException">
        /// The user is not authorized to access a resource.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.InternalServerException">
        /// Unexpected server error occured.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.ValidationException">
        /// You either haven't provided a <c>TargetAccountId</c> or are using the same value for
        /// <c>TargetAccountId</c> and <c>SourceAccountId</c>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/ListAccountLinks">REST API Reference for ListAccountLinks Operation</seealso>
        public virtual ListAccountLinksResponse ListAccountLinks(ListAccountLinksRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAccountLinksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAccountLinksResponseUnmarshaller.Instance;

            return Invoke<ListAccountLinksResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListAccountLinks operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAccountLinks operation on AmazonWorkSpacesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAccountLinks
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/ListAccountLinks">REST API Reference for ListAccountLinks Operation</seealso>
        public virtual IAsyncResult BeginListAccountLinks(ListAccountLinksRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAccountLinksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAccountLinksResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListAccountLinks operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAccountLinks.</param>
        /// 
        /// <returns>Returns a  ListAccountLinksResult from WorkSpaces.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/ListAccountLinks">REST API Reference for ListAccountLinks Operation</seealso>
        public virtual ListAccountLinksResponse EndListAccountLinks(IAsyncResult asyncResult)
        {
            return EndInvoke<ListAccountLinksResponse>(asyncResult);
        }

        #endregion
        
        #region  ListAvailableManagementCidrRanges

        /// <summary>
        /// Retrieves a list of IP address ranges, specified as IPv4 CIDR blocks, that you can
        /// use for the network management interface when you enable Bring Your Own License (BYOL).
        /// 
        /// 
        ///  
        /// <para>
        /// This operation can be run only by Amazon Web Services accounts that are enabled for
        /// BYOL. If your account isn't enabled for BYOL, you'll receive an <c>AccessDeniedException</c>
        /// error.
        /// </para>
        ///  
        /// <para>
        /// The management network interface is connected to a secure Amazon WorkSpaces management
        /// network. It is used for interactive streaming of the WorkSpace desktop to Amazon WorkSpaces
        /// clients, and to allow Amazon WorkSpaces to manage the WorkSpace.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAvailableManagementCidrRanges service method.</param>
        /// 
        /// <returns>The response from the ListAvailableManagementCidrRanges service method, as returned by WorkSpaces.</returns>
        /// <exception cref="Amazon.WorkSpaces.Model.AccessDeniedException">
        /// The user is not authorized to access a resource.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.InvalidParameterValuesException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/ListAvailableManagementCidrRanges">REST API Reference for ListAvailableManagementCidrRanges Operation</seealso>
        public virtual ListAvailableManagementCidrRangesResponse ListAvailableManagementCidrRanges(ListAvailableManagementCidrRangesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAvailableManagementCidrRangesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAvailableManagementCidrRangesResponseUnmarshaller.Instance;

            return Invoke<ListAvailableManagementCidrRangesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListAvailableManagementCidrRanges operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAvailableManagementCidrRanges operation on AmazonWorkSpacesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAvailableManagementCidrRanges
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/ListAvailableManagementCidrRanges">REST API Reference for ListAvailableManagementCidrRanges Operation</seealso>
        public virtual IAsyncResult BeginListAvailableManagementCidrRanges(ListAvailableManagementCidrRangesRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAvailableManagementCidrRangesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAvailableManagementCidrRangesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListAvailableManagementCidrRanges operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAvailableManagementCidrRanges.</param>
        /// 
        /// <returns>Returns a  ListAvailableManagementCidrRangesResult from WorkSpaces.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/ListAvailableManagementCidrRanges">REST API Reference for ListAvailableManagementCidrRanges Operation</seealso>
        public virtual ListAvailableManagementCidrRangesResponse EndListAvailableManagementCidrRanges(IAsyncResult asyncResult)
        {
            return EndInvoke<ListAvailableManagementCidrRangesResponse>(asyncResult);
        }

        #endregion
        
        #region  MigrateWorkspace

        /// <summary>
        /// Migrates a WorkSpace from one operating system or bundle type to another, while retaining
        /// the data on the user volume.
        /// 
        ///  
        /// <para>
        /// The migration process recreates the WorkSpace by using a new root volume from the
        /// target bundle image and the user volume from the last available snapshot of the original
        /// WorkSpace. During migration, the original <c>D:\Users\%USERNAME%</c> user profile
        /// folder is renamed to <c>D:\Users\%USERNAME%MMddyyTHHmmss%.NotMigrated</c>. A new <c>D:\Users\%USERNAME%\</c>
        /// folder is generated by the new OS. Certain files in the old user profile are moved
        /// to the new user profile.
        /// </para>
        ///  
        /// <para>
        /// For available migration scenarios, details about what happens during migration, and
        /// best practices, see <a href="https://docs.aws.amazon.com/workspaces/latest/adminguide/migrate-workspaces.html">Migrate
        /// a WorkSpace</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the MigrateWorkspace service method.</param>
        /// 
        /// <returns>The response from the MigrateWorkspace service method, as returned by WorkSpaces.</returns>
        /// <exception cref="Amazon.WorkSpaces.Model.AccessDeniedException">
        /// The user is not authorized to access a resource.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.InvalidParameterValuesException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.OperationInProgressException">
        /// The properties of this WorkSpace are currently being modified. Try again in a moment.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.OperationNotSupportedException">
        /// This operation is not supported.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.ResourceUnavailableException">
        /// The specified resource is not available.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/MigrateWorkspace">REST API Reference for MigrateWorkspace Operation</seealso>
        public virtual MigrateWorkspaceResponse MigrateWorkspace(MigrateWorkspaceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = MigrateWorkspaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = MigrateWorkspaceResponseUnmarshaller.Instance;

            return Invoke<MigrateWorkspaceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the MigrateWorkspace operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the MigrateWorkspace operation on AmazonWorkSpacesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndMigrateWorkspace
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/MigrateWorkspace">REST API Reference for MigrateWorkspace Operation</seealso>
        public virtual IAsyncResult BeginMigrateWorkspace(MigrateWorkspaceRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = MigrateWorkspaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = MigrateWorkspaceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  MigrateWorkspace operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginMigrateWorkspace.</param>
        /// 
        /// <returns>Returns a  MigrateWorkspaceResult from WorkSpaces.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/MigrateWorkspace">REST API Reference for MigrateWorkspace Operation</seealso>
        public virtual MigrateWorkspaceResponse EndMigrateWorkspace(IAsyncResult asyncResult)
        {
            return EndInvoke<MigrateWorkspaceResponse>(asyncResult);
        }

        #endregion
        
        #region  ModifyAccount

        /// <summary>
        /// Modifies the configuration of Bring Your Own License (BYOL) for the specified account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyAccount service method.</param>
        /// 
        /// <returns>The response from the ModifyAccount service method, as returned by WorkSpaces.</returns>
        /// <exception cref="Amazon.WorkSpaces.Model.AccessDeniedException">
        /// The user is not authorized to access a resource.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.InvalidParameterValuesException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.InvalidResourceStateException">
        /// The state of the resource is not valid for this operation.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.ResourceUnavailableException">
        /// The specified resource is not available.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/ModifyAccount">REST API Reference for ModifyAccount Operation</seealso>
        public virtual ModifyAccountResponse ModifyAccount(ModifyAccountRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ModifyAccountRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyAccountResponseUnmarshaller.Instance;

            return Invoke<ModifyAccountResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ModifyAccount operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyAccount operation on AmazonWorkSpacesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndModifyAccount
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/ModifyAccount">REST API Reference for ModifyAccount Operation</seealso>
        public virtual IAsyncResult BeginModifyAccount(ModifyAccountRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ModifyAccountRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyAccountResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ModifyAccount operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginModifyAccount.</param>
        /// 
        /// <returns>Returns a  ModifyAccountResult from WorkSpaces.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/ModifyAccount">REST API Reference for ModifyAccount Operation</seealso>
        public virtual ModifyAccountResponse EndModifyAccount(IAsyncResult asyncResult)
        {
            return EndInvoke<ModifyAccountResponse>(asyncResult);
        }

        #endregion
        
        #region  ModifyCertificateBasedAuthProperties

        /// <summary>
        /// Modifies the properties of the certificate-based authentication you want to use with
        /// your WorkSpaces.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyCertificateBasedAuthProperties service method.</param>
        /// 
        /// <returns>The response from the ModifyCertificateBasedAuthProperties service method, as returned by WorkSpaces.</returns>
        /// <exception cref="Amazon.WorkSpaces.Model.AccessDeniedException">
        /// The user is not authorized to access a resource.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.InvalidParameterValuesException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.OperationNotSupportedException">
        /// This operation is not supported.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/ModifyCertificateBasedAuthProperties">REST API Reference for ModifyCertificateBasedAuthProperties Operation</seealso>
        public virtual ModifyCertificateBasedAuthPropertiesResponse ModifyCertificateBasedAuthProperties(ModifyCertificateBasedAuthPropertiesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ModifyCertificateBasedAuthPropertiesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyCertificateBasedAuthPropertiesResponseUnmarshaller.Instance;

            return Invoke<ModifyCertificateBasedAuthPropertiesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ModifyCertificateBasedAuthProperties operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyCertificateBasedAuthProperties operation on AmazonWorkSpacesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndModifyCertificateBasedAuthProperties
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/ModifyCertificateBasedAuthProperties">REST API Reference for ModifyCertificateBasedAuthProperties Operation</seealso>
        public virtual IAsyncResult BeginModifyCertificateBasedAuthProperties(ModifyCertificateBasedAuthPropertiesRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ModifyCertificateBasedAuthPropertiesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyCertificateBasedAuthPropertiesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ModifyCertificateBasedAuthProperties operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginModifyCertificateBasedAuthProperties.</param>
        /// 
        /// <returns>Returns a  ModifyCertificateBasedAuthPropertiesResult from WorkSpaces.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/ModifyCertificateBasedAuthProperties">REST API Reference for ModifyCertificateBasedAuthProperties Operation</seealso>
        public virtual ModifyCertificateBasedAuthPropertiesResponse EndModifyCertificateBasedAuthProperties(IAsyncResult asyncResult)
        {
            return EndInvoke<ModifyCertificateBasedAuthPropertiesResponse>(asyncResult);
        }

        #endregion
        
        #region  ModifyClientProperties

        /// <summary>
        /// Modifies the properties of the specified Amazon WorkSpaces clients.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyClientProperties service method.</param>
        /// 
        /// <returns>The response from the ModifyClientProperties service method, as returned by WorkSpaces.</returns>
        /// <exception cref="Amazon.WorkSpaces.Model.AccessDeniedException">
        /// The user is not authorized to access a resource.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.InvalidParameterValuesException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.OperationNotSupportedException">
        /// This operation is not supported.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/ModifyClientProperties">REST API Reference for ModifyClientProperties Operation</seealso>
        public virtual ModifyClientPropertiesResponse ModifyClientProperties(ModifyClientPropertiesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ModifyClientPropertiesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyClientPropertiesResponseUnmarshaller.Instance;

            return Invoke<ModifyClientPropertiesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ModifyClientProperties operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyClientProperties operation on AmazonWorkSpacesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndModifyClientProperties
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/ModifyClientProperties">REST API Reference for ModifyClientProperties Operation</seealso>
        public virtual IAsyncResult BeginModifyClientProperties(ModifyClientPropertiesRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ModifyClientPropertiesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyClientPropertiesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ModifyClientProperties operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginModifyClientProperties.</param>
        /// 
        /// <returns>Returns a  ModifyClientPropertiesResult from WorkSpaces.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/ModifyClientProperties">REST API Reference for ModifyClientProperties Operation</seealso>
        public virtual ModifyClientPropertiesResponse EndModifyClientProperties(IAsyncResult asyncResult)
        {
            return EndInvoke<ModifyClientPropertiesResponse>(asyncResult);
        }

        #endregion
        
        #region  ModifyEndpointEncryptionMode

        /// <summary>
        /// Modifies the endpoint encryption mode that allows you to configure the specified directory
        /// between Standard TLS and FIPS 140-2 validated mode.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyEndpointEncryptionMode service method.</param>
        /// 
        /// <returns>The response from the ModifyEndpointEncryptionMode service method, as returned by WorkSpaces.</returns>
        /// <exception cref="Amazon.WorkSpaces.Model.AccessDeniedException">
        /// The user is not authorized to access a resource.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.OperationNotSupportedException">
        /// This operation is not supported.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/ModifyEndpointEncryptionMode">REST API Reference for ModifyEndpointEncryptionMode Operation</seealso>
        public virtual ModifyEndpointEncryptionModeResponse ModifyEndpointEncryptionMode(ModifyEndpointEncryptionModeRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ModifyEndpointEncryptionModeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyEndpointEncryptionModeResponseUnmarshaller.Instance;

            return Invoke<ModifyEndpointEncryptionModeResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ModifyEndpointEncryptionMode operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyEndpointEncryptionMode operation on AmazonWorkSpacesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndModifyEndpointEncryptionMode
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/ModifyEndpointEncryptionMode">REST API Reference for ModifyEndpointEncryptionMode Operation</seealso>
        public virtual IAsyncResult BeginModifyEndpointEncryptionMode(ModifyEndpointEncryptionModeRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ModifyEndpointEncryptionModeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyEndpointEncryptionModeResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ModifyEndpointEncryptionMode operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginModifyEndpointEncryptionMode.</param>
        /// 
        /// <returns>Returns a  ModifyEndpointEncryptionModeResult from WorkSpaces.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/ModifyEndpointEncryptionMode">REST API Reference for ModifyEndpointEncryptionMode Operation</seealso>
        public virtual ModifyEndpointEncryptionModeResponse EndModifyEndpointEncryptionMode(IAsyncResult asyncResult)
        {
            return EndInvoke<ModifyEndpointEncryptionModeResponse>(asyncResult);
        }

        #endregion
        
        #region  ModifySamlProperties

        /// <summary>
        /// Modifies multiple properties related to SAML 2.0 authentication, including the enablement
        /// status, user access URL, and relay state parameter name that are used for configuring
        /// federation with an SAML 2.0 identity provider.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifySamlProperties service method.</param>
        /// 
        /// <returns>The response from the ModifySamlProperties service method, as returned by WorkSpaces.</returns>
        /// <exception cref="Amazon.WorkSpaces.Model.AccessDeniedException">
        /// The user is not authorized to access a resource.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.InvalidParameterValuesException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.OperationNotSupportedException">
        /// This operation is not supported.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/ModifySamlProperties">REST API Reference for ModifySamlProperties Operation</seealso>
        public virtual ModifySamlPropertiesResponse ModifySamlProperties(ModifySamlPropertiesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ModifySamlPropertiesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifySamlPropertiesResponseUnmarshaller.Instance;

            return Invoke<ModifySamlPropertiesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ModifySamlProperties operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifySamlProperties operation on AmazonWorkSpacesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndModifySamlProperties
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/ModifySamlProperties">REST API Reference for ModifySamlProperties Operation</seealso>
        public virtual IAsyncResult BeginModifySamlProperties(ModifySamlPropertiesRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ModifySamlPropertiesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifySamlPropertiesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ModifySamlProperties operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginModifySamlProperties.</param>
        /// 
        /// <returns>Returns a  ModifySamlPropertiesResult from WorkSpaces.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/ModifySamlProperties">REST API Reference for ModifySamlProperties Operation</seealso>
        public virtual ModifySamlPropertiesResponse EndModifySamlProperties(IAsyncResult asyncResult)
        {
            return EndInvoke<ModifySamlPropertiesResponse>(asyncResult);
        }

        #endregion
        
        #region  ModifySelfservicePermissions

        /// <summary>
        /// Modifies the self-service WorkSpace management capabilities for your users. For more
        /// information, see <a href="https://docs.aws.amazon.com/workspaces/latest/adminguide/enable-user-self-service-workspace-management.html">Enable
        /// Self-Service WorkSpace Management Capabilities for Your Users</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifySelfservicePermissions service method.</param>
        /// 
        /// <returns>The response from the ModifySelfservicePermissions service method, as returned by WorkSpaces.</returns>
        /// <exception cref="Amazon.WorkSpaces.Model.AccessDeniedException">
        /// The user is not authorized to access a resource.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.InvalidParameterValuesException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.OperationNotSupportedException">
        /// This operation is not supported.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/ModifySelfservicePermissions">REST API Reference for ModifySelfservicePermissions Operation</seealso>
        public virtual ModifySelfservicePermissionsResponse ModifySelfservicePermissions(ModifySelfservicePermissionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ModifySelfservicePermissionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifySelfservicePermissionsResponseUnmarshaller.Instance;

            return Invoke<ModifySelfservicePermissionsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ModifySelfservicePermissions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifySelfservicePermissions operation on AmazonWorkSpacesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndModifySelfservicePermissions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/ModifySelfservicePermissions">REST API Reference for ModifySelfservicePermissions Operation</seealso>
        public virtual IAsyncResult BeginModifySelfservicePermissions(ModifySelfservicePermissionsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ModifySelfservicePermissionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifySelfservicePermissionsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ModifySelfservicePermissions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginModifySelfservicePermissions.</param>
        /// 
        /// <returns>Returns a  ModifySelfservicePermissionsResult from WorkSpaces.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/ModifySelfservicePermissions">REST API Reference for ModifySelfservicePermissions Operation</seealso>
        public virtual ModifySelfservicePermissionsResponse EndModifySelfservicePermissions(IAsyncResult asyncResult)
        {
            return EndInvoke<ModifySelfservicePermissionsResponse>(asyncResult);
        }

        #endregion
        
        #region  ModifyStreamingProperties

        /// <summary>
        /// Modifies the specified streaming properties.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyStreamingProperties service method.</param>
        /// 
        /// <returns>The response from the ModifyStreamingProperties service method, as returned by WorkSpaces.</returns>
        /// <exception cref="Amazon.WorkSpaces.Model.AccessDeniedException">
        /// The user is not authorized to access a resource.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.InvalidParameterValuesException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.OperationNotSupportedException">
        /// This operation is not supported.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/ModifyStreamingProperties">REST API Reference for ModifyStreamingProperties Operation</seealso>
        public virtual ModifyStreamingPropertiesResponse ModifyStreamingProperties(ModifyStreamingPropertiesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ModifyStreamingPropertiesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyStreamingPropertiesResponseUnmarshaller.Instance;

            return Invoke<ModifyStreamingPropertiesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ModifyStreamingProperties operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyStreamingProperties operation on AmazonWorkSpacesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndModifyStreamingProperties
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/ModifyStreamingProperties">REST API Reference for ModifyStreamingProperties Operation</seealso>
        public virtual IAsyncResult BeginModifyStreamingProperties(ModifyStreamingPropertiesRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ModifyStreamingPropertiesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyStreamingPropertiesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ModifyStreamingProperties operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginModifyStreamingProperties.</param>
        /// 
        /// <returns>Returns a  ModifyStreamingPropertiesResult from WorkSpaces.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/ModifyStreamingProperties">REST API Reference for ModifyStreamingProperties Operation</seealso>
        public virtual ModifyStreamingPropertiesResponse EndModifyStreamingProperties(IAsyncResult asyncResult)
        {
            return EndInvoke<ModifyStreamingPropertiesResponse>(asyncResult);
        }

        #endregion
        
        #region  ModifyWorkspaceAccessProperties

        /// <summary>
        /// Specifies which devices and operating systems users can use to access their WorkSpaces.
        /// For more information, see <a href="https://docs.aws.amazon.com/workspaces/latest/adminguide/update-directory-details.html#control-device-access">
        /// Control Device Access</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyWorkspaceAccessProperties service method.</param>
        /// 
        /// <returns>The response from the ModifyWorkspaceAccessProperties service method, as returned by WorkSpaces.</returns>
        /// <exception cref="Amazon.WorkSpaces.Model.AccessDeniedException">
        /// The user is not authorized to access a resource.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.InvalidParameterCombinationException">
        /// Two or more of the selected parameter values cannot be used together.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.InvalidParameterValuesException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.OperationNotSupportedException">
        /// This operation is not supported.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/ModifyWorkspaceAccessProperties">REST API Reference for ModifyWorkspaceAccessProperties Operation</seealso>
        public virtual ModifyWorkspaceAccessPropertiesResponse ModifyWorkspaceAccessProperties(ModifyWorkspaceAccessPropertiesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ModifyWorkspaceAccessPropertiesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyWorkspaceAccessPropertiesResponseUnmarshaller.Instance;

            return Invoke<ModifyWorkspaceAccessPropertiesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ModifyWorkspaceAccessProperties operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyWorkspaceAccessProperties operation on AmazonWorkSpacesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndModifyWorkspaceAccessProperties
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/ModifyWorkspaceAccessProperties">REST API Reference for ModifyWorkspaceAccessProperties Operation</seealso>
        public virtual IAsyncResult BeginModifyWorkspaceAccessProperties(ModifyWorkspaceAccessPropertiesRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ModifyWorkspaceAccessPropertiesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyWorkspaceAccessPropertiesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ModifyWorkspaceAccessProperties operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginModifyWorkspaceAccessProperties.</param>
        /// 
        /// <returns>Returns a  ModifyWorkspaceAccessPropertiesResult from WorkSpaces.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/ModifyWorkspaceAccessProperties">REST API Reference for ModifyWorkspaceAccessProperties Operation</seealso>
        public virtual ModifyWorkspaceAccessPropertiesResponse EndModifyWorkspaceAccessProperties(IAsyncResult asyncResult)
        {
            return EndInvoke<ModifyWorkspaceAccessPropertiesResponse>(asyncResult);
        }

        #endregion
        
        #region  ModifyWorkspaceCreationProperties

        /// <summary>
        /// Modify the default properties used to create WorkSpaces.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyWorkspaceCreationProperties service method.</param>
        /// 
        /// <returns>The response from the ModifyWorkspaceCreationProperties service method, as returned by WorkSpaces.</returns>
        /// <exception cref="Amazon.WorkSpaces.Model.AccessDeniedException">
        /// The user is not authorized to access a resource.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.InvalidParameterValuesException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.OperationNotSupportedException">
        /// This operation is not supported.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/ModifyWorkspaceCreationProperties">REST API Reference for ModifyWorkspaceCreationProperties Operation</seealso>
        public virtual ModifyWorkspaceCreationPropertiesResponse ModifyWorkspaceCreationProperties(ModifyWorkspaceCreationPropertiesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ModifyWorkspaceCreationPropertiesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyWorkspaceCreationPropertiesResponseUnmarshaller.Instance;

            return Invoke<ModifyWorkspaceCreationPropertiesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ModifyWorkspaceCreationProperties operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyWorkspaceCreationProperties operation on AmazonWorkSpacesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndModifyWorkspaceCreationProperties
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/ModifyWorkspaceCreationProperties">REST API Reference for ModifyWorkspaceCreationProperties Operation</seealso>
        public virtual IAsyncResult BeginModifyWorkspaceCreationProperties(ModifyWorkspaceCreationPropertiesRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ModifyWorkspaceCreationPropertiesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyWorkspaceCreationPropertiesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ModifyWorkspaceCreationProperties operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginModifyWorkspaceCreationProperties.</param>
        /// 
        /// <returns>Returns a  ModifyWorkspaceCreationPropertiesResult from WorkSpaces.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/ModifyWorkspaceCreationProperties">REST API Reference for ModifyWorkspaceCreationProperties Operation</seealso>
        public virtual ModifyWorkspaceCreationPropertiesResponse EndModifyWorkspaceCreationProperties(IAsyncResult asyncResult)
        {
            return EndInvoke<ModifyWorkspaceCreationPropertiesResponse>(asyncResult);
        }

        #endregion
        
        #region  ModifyWorkspaceProperties

        /// <summary>
        /// Modifies the specified WorkSpace properties. For important information about how to
        /// modify the size of the root and user volumes, see <a href="https://docs.aws.amazon.com/workspaces/latest/adminguide/modify-workspaces.html">
        /// Modify a WorkSpace</a>. 
        /// 
        ///  <note> 
        /// <para>
        /// The <c>MANUAL</c> running mode value is only supported by Amazon WorkSpaces Core.
        /// Contact your account team to be allow-listed to use this value. For more information,
        /// see <a href="http://aws.amazon.com/workspaces/core/">Amazon WorkSpaces Core</a>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyWorkspaceProperties service method.</param>
        /// 
        /// <returns>The response from the ModifyWorkspaceProperties service method, as returned by WorkSpaces.</returns>
        /// <exception cref="Amazon.WorkSpaces.Model.AccessDeniedException">
        /// The user is not authorized to access a resource.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.InvalidParameterValuesException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.InvalidResourceStateException">
        /// The state of the resource is not valid for this operation.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.OperationInProgressException">
        /// The properties of this WorkSpace are currently being modified. Try again in a moment.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.ResourceUnavailableException">
        /// The specified resource is not available.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.UnsupportedWorkspaceConfigurationException">
        /// The configuration of this WorkSpace is not supported for this operation. For more
        /// information, see <a href="https://docs.aws.amazon.com/workspaces/latest/adminguide/required-service-components.html">Required
        /// Configuration and Service Components for WorkSpaces </a>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/ModifyWorkspaceProperties">REST API Reference for ModifyWorkspaceProperties Operation</seealso>
        public virtual ModifyWorkspacePropertiesResponse ModifyWorkspaceProperties(ModifyWorkspacePropertiesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ModifyWorkspacePropertiesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyWorkspacePropertiesResponseUnmarshaller.Instance;

            return Invoke<ModifyWorkspacePropertiesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ModifyWorkspaceProperties operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyWorkspaceProperties operation on AmazonWorkSpacesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndModifyWorkspaceProperties
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/ModifyWorkspaceProperties">REST API Reference for ModifyWorkspaceProperties Operation</seealso>
        public virtual IAsyncResult BeginModifyWorkspaceProperties(ModifyWorkspacePropertiesRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ModifyWorkspacePropertiesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyWorkspacePropertiesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ModifyWorkspaceProperties operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginModifyWorkspaceProperties.</param>
        /// 
        /// <returns>Returns a  ModifyWorkspacePropertiesResult from WorkSpaces.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/ModifyWorkspaceProperties">REST API Reference for ModifyWorkspaceProperties Operation</seealso>
        public virtual ModifyWorkspacePropertiesResponse EndModifyWorkspaceProperties(IAsyncResult asyncResult)
        {
            return EndInvoke<ModifyWorkspacePropertiesResponse>(asyncResult);
        }

        #endregion
        
        #region  ModifyWorkspaceState

        /// <summary>
        /// Sets the state of the specified WorkSpace.
        /// 
        ///  
        /// <para>
        /// To maintain a WorkSpace without being interrupted, set the WorkSpace state to <c>ADMIN_MAINTENANCE</c>.
        /// WorkSpaces in this state do not respond to requests to reboot, stop, start, rebuild,
        /// or restore. An AutoStop WorkSpace in this state is not stopped. Users cannot log into
        /// a WorkSpace in the <c>ADMIN_MAINTENANCE</c> state.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyWorkspaceState service method.</param>
        /// 
        /// <returns>The response from the ModifyWorkspaceState service method, as returned by WorkSpaces.</returns>
        /// <exception cref="Amazon.WorkSpaces.Model.InvalidParameterValuesException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.InvalidResourceStateException">
        /// The state of the resource is not valid for this operation.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.OperationNotSupportedException">
        /// This operation is not supported.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/ModifyWorkspaceState">REST API Reference for ModifyWorkspaceState Operation</seealso>
        public virtual ModifyWorkspaceStateResponse ModifyWorkspaceState(ModifyWorkspaceStateRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ModifyWorkspaceStateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyWorkspaceStateResponseUnmarshaller.Instance;

            return Invoke<ModifyWorkspaceStateResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ModifyWorkspaceState operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyWorkspaceState operation on AmazonWorkSpacesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndModifyWorkspaceState
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/ModifyWorkspaceState">REST API Reference for ModifyWorkspaceState Operation</seealso>
        public virtual IAsyncResult BeginModifyWorkspaceState(ModifyWorkspaceStateRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ModifyWorkspaceStateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyWorkspaceStateResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ModifyWorkspaceState operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginModifyWorkspaceState.</param>
        /// 
        /// <returns>Returns a  ModifyWorkspaceStateResult from WorkSpaces.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/ModifyWorkspaceState">REST API Reference for ModifyWorkspaceState Operation</seealso>
        public virtual ModifyWorkspaceStateResponse EndModifyWorkspaceState(IAsyncResult asyncResult)
        {
            return EndInvoke<ModifyWorkspaceStateResponse>(asyncResult);
        }

        #endregion
        
        #region  RebootWorkspaces

        /// <summary>
        /// Reboots the specified WorkSpaces.
        /// 
        ///  
        /// <para>
        /// You cannot reboot a WorkSpace unless its state is <c>AVAILABLE</c>, <c>UNHEALTHY</c>,
        /// or <c>REBOOTING</c>. Reboot a WorkSpace in the <c>REBOOTING</c> state only if your
        /// WorkSpace has been stuck in the <c>REBOOTING</c> state for over 20 minutes.
        /// </para>
        ///  
        /// <para>
        /// This operation is asynchronous and returns before the WorkSpaces have rebooted.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RebootWorkspaces service method.</param>
        /// 
        /// <returns>The response from the RebootWorkspaces service method, as returned by WorkSpaces.</returns>
        /// <exception cref="Amazon.WorkSpaces.Model.OperationNotSupportedException">
        /// This operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/RebootWorkspaces">REST API Reference for RebootWorkspaces Operation</seealso>
        public virtual RebootWorkspacesResponse RebootWorkspaces(RebootWorkspacesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RebootWorkspacesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RebootWorkspacesResponseUnmarshaller.Instance;

            return Invoke<RebootWorkspacesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RebootWorkspaces operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RebootWorkspaces operation on AmazonWorkSpacesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRebootWorkspaces
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/RebootWorkspaces">REST API Reference for RebootWorkspaces Operation</seealso>
        public virtual IAsyncResult BeginRebootWorkspaces(RebootWorkspacesRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RebootWorkspacesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RebootWorkspacesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  RebootWorkspaces operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRebootWorkspaces.</param>
        /// 
        /// <returns>Returns a  RebootWorkspacesResult from WorkSpaces.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/RebootWorkspaces">REST API Reference for RebootWorkspaces Operation</seealso>
        public virtual RebootWorkspacesResponse EndRebootWorkspaces(IAsyncResult asyncResult)
        {
            return EndInvoke<RebootWorkspacesResponse>(asyncResult);
        }

        #endregion
        
        #region  RebuildWorkspaces

        /// <summary>
        /// Rebuilds the specified WorkSpace.
        /// 
        ///  
        /// <para>
        /// You cannot rebuild a WorkSpace unless its state is <c>AVAILABLE</c>, <c>ERROR</c>,
        /// <c>UNHEALTHY</c>, <c>STOPPED</c>, or <c>REBOOTING</c>.
        /// </para>
        ///  
        /// <para>
        /// Rebuilding a WorkSpace is a potentially destructive action that can result in the
        /// loss of data. For more information, see <a href="https://docs.aws.amazon.com/workspaces/latest/adminguide/reset-workspace.html">Rebuild
        /// a WorkSpace</a>.
        /// </para>
        ///  
        /// <para>
        /// This operation is asynchronous and returns before the WorkSpaces have been completely
        /// rebuilt.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RebuildWorkspaces service method.</param>
        /// 
        /// <returns>The response from the RebuildWorkspaces service method, as returned by WorkSpaces.</returns>
        /// <exception cref="Amazon.WorkSpaces.Model.OperationNotSupportedException">
        /// This operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/RebuildWorkspaces">REST API Reference for RebuildWorkspaces Operation</seealso>
        public virtual RebuildWorkspacesResponse RebuildWorkspaces(RebuildWorkspacesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RebuildWorkspacesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RebuildWorkspacesResponseUnmarshaller.Instance;

            return Invoke<RebuildWorkspacesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RebuildWorkspaces operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RebuildWorkspaces operation on AmazonWorkSpacesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRebuildWorkspaces
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/RebuildWorkspaces">REST API Reference for RebuildWorkspaces Operation</seealso>
        public virtual IAsyncResult BeginRebuildWorkspaces(RebuildWorkspacesRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RebuildWorkspacesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RebuildWorkspacesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  RebuildWorkspaces operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRebuildWorkspaces.</param>
        /// 
        /// <returns>Returns a  RebuildWorkspacesResult from WorkSpaces.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/RebuildWorkspaces">REST API Reference for RebuildWorkspaces Operation</seealso>
        public virtual RebuildWorkspacesResponse EndRebuildWorkspaces(IAsyncResult asyncResult)
        {
            return EndInvoke<RebuildWorkspacesResponse>(asyncResult);
        }

        #endregion
        
        #region  RegisterWorkspaceDirectory

        /// <summary>
        /// Registers the specified directory. This operation is asynchronous and returns before
        /// the WorkSpace directory is registered. If this is the first time you are registering
        /// a directory, you will need to create the workspaces_DefaultRole role before you can
        /// register a directory. For more information, see <a href="https://docs.aws.amazon.com/workspaces/latest/adminguide/workspaces-access-control.html#create-default-role">
        /// Creating the workspaces_DefaultRole Role</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RegisterWorkspaceDirectory service method.</param>
        /// 
        /// <returns>The response from the RegisterWorkspaceDirectory service method, as returned by WorkSpaces.</returns>
        /// <exception cref="Amazon.WorkSpaces.Model.AccessDeniedException">
        /// The user is not authorized to access a resource.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.InvalidParameterValuesException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.InvalidResourceStateException">
        /// The state of the resource is not valid for this operation.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.OperationNotSupportedException">
        /// This operation is not supported.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.ResourceAlreadyExistsException">
        /// The specified resource already exists.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.ResourceLimitExceededException">
        /// Your resource limits have been exceeded.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.UnsupportedNetworkConfigurationException">
        /// The configuration of this network is not supported for this operation, or your network
        /// configuration conflicts with the Amazon WorkSpaces management network IP range. For
        /// more information, see <a href="https://docs.aws.amazon.com/workspaces/latest/adminguide/amazon-workspaces-vpc.html">
        /// Configure a VPC for Amazon WorkSpaces</a>.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.WorkspacesDefaultRoleNotFoundException">
        /// The workspaces_DefaultRole role could not be found. If this is the first time you
        /// are registering a directory, you will need to create the workspaces_DefaultRole role
        /// before you can register a directory. For more information, see <a href="https://docs.aws.amazon.com/workspaces/latest/adminguide/workspaces-access-control.html#create-default-role">Creating
        /// the workspaces_DefaultRole Role</a>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/RegisterWorkspaceDirectory">REST API Reference for RegisterWorkspaceDirectory Operation</seealso>
        public virtual RegisterWorkspaceDirectoryResponse RegisterWorkspaceDirectory(RegisterWorkspaceDirectoryRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RegisterWorkspaceDirectoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RegisterWorkspaceDirectoryResponseUnmarshaller.Instance;

            return Invoke<RegisterWorkspaceDirectoryResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RegisterWorkspaceDirectory operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RegisterWorkspaceDirectory operation on AmazonWorkSpacesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRegisterWorkspaceDirectory
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/RegisterWorkspaceDirectory">REST API Reference for RegisterWorkspaceDirectory Operation</seealso>
        public virtual IAsyncResult BeginRegisterWorkspaceDirectory(RegisterWorkspaceDirectoryRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RegisterWorkspaceDirectoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RegisterWorkspaceDirectoryResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  RegisterWorkspaceDirectory operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRegisterWorkspaceDirectory.</param>
        /// 
        /// <returns>Returns a  RegisterWorkspaceDirectoryResult from WorkSpaces.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/RegisterWorkspaceDirectory">REST API Reference for RegisterWorkspaceDirectory Operation</seealso>
        public virtual RegisterWorkspaceDirectoryResponse EndRegisterWorkspaceDirectory(IAsyncResult asyncResult)
        {
            return EndInvoke<RegisterWorkspaceDirectoryResponse>(asyncResult);
        }

        #endregion
        
        #region  RejectAccountLinkInvitation

        /// <summary>
        /// Rejects the account link invitation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RejectAccountLinkInvitation service method.</param>
        /// 
        /// <returns>The response from the RejectAccountLinkInvitation service method, as returned by WorkSpaces.</returns>
        /// <exception cref="Amazon.WorkSpaces.Model.AccessDeniedException">
        /// The user is not authorized to access a resource.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.ConflictException">
        /// The <c>TargetAccountId</c> is already linked or invited.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.InternalServerException">
        /// Unexpected server error occured.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.ValidationException">
        /// You either haven't provided a <c>TargetAccountId</c> or are using the same value for
        /// <c>TargetAccountId</c> and <c>SourceAccountId</c>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/RejectAccountLinkInvitation">REST API Reference for RejectAccountLinkInvitation Operation</seealso>
        public virtual RejectAccountLinkInvitationResponse RejectAccountLinkInvitation(RejectAccountLinkInvitationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RejectAccountLinkInvitationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RejectAccountLinkInvitationResponseUnmarshaller.Instance;

            return Invoke<RejectAccountLinkInvitationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RejectAccountLinkInvitation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RejectAccountLinkInvitation operation on AmazonWorkSpacesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRejectAccountLinkInvitation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/RejectAccountLinkInvitation">REST API Reference for RejectAccountLinkInvitation Operation</seealso>
        public virtual IAsyncResult BeginRejectAccountLinkInvitation(RejectAccountLinkInvitationRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RejectAccountLinkInvitationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RejectAccountLinkInvitationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  RejectAccountLinkInvitation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRejectAccountLinkInvitation.</param>
        /// 
        /// <returns>Returns a  RejectAccountLinkInvitationResult from WorkSpaces.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/RejectAccountLinkInvitation">REST API Reference for RejectAccountLinkInvitation Operation</seealso>
        public virtual RejectAccountLinkInvitationResponse EndRejectAccountLinkInvitation(IAsyncResult asyncResult)
        {
            return EndInvoke<RejectAccountLinkInvitationResponse>(asyncResult);
        }

        #endregion
        
        #region  RestoreWorkspace

        /// <summary>
        /// Restores the specified WorkSpace to its last known healthy state.
        /// 
        ///  
        /// <para>
        /// You cannot restore a WorkSpace unless its state is <c> AVAILABLE</c>, <c>ERROR</c>,
        /// <c>UNHEALTHY</c>, or <c>STOPPED</c>.
        /// </para>
        ///  
        /// <para>
        /// Restoring a WorkSpace is a potentially destructive action that can result in the loss
        /// of data. For more information, see <a href="https://docs.aws.amazon.com/workspaces/latest/adminguide/restore-workspace.html">Restore
        /// a WorkSpace</a>.
        /// </para>
        ///  
        /// <para>
        /// This operation is asynchronous and returns before the WorkSpace is completely restored.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RestoreWorkspace service method.</param>
        /// 
        /// <returns>The response from the RestoreWorkspace service method, as returned by WorkSpaces.</returns>
        /// <exception cref="Amazon.WorkSpaces.Model.AccessDeniedException">
        /// The user is not authorized to access a resource.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.InvalidParameterValuesException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.OperationNotSupportedException">
        /// This operation is not supported.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/RestoreWorkspace">REST API Reference for RestoreWorkspace Operation</seealso>
        public virtual RestoreWorkspaceResponse RestoreWorkspace(RestoreWorkspaceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RestoreWorkspaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RestoreWorkspaceResponseUnmarshaller.Instance;

            return Invoke<RestoreWorkspaceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RestoreWorkspace operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RestoreWorkspace operation on AmazonWorkSpacesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRestoreWorkspace
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/RestoreWorkspace">REST API Reference for RestoreWorkspace Operation</seealso>
        public virtual IAsyncResult BeginRestoreWorkspace(RestoreWorkspaceRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RestoreWorkspaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RestoreWorkspaceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  RestoreWorkspace operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRestoreWorkspace.</param>
        /// 
        /// <returns>Returns a  RestoreWorkspaceResult from WorkSpaces.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/RestoreWorkspace">REST API Reference for RestoreWorkspace Operation</seealso>
        public virtual RestoreWorkspaceResponse EndRestoreWorkspace(IAsyncResult asyncResult)
        {
            return EndInvoke<RestoreWorkspaceResponse>(asyncResult);
        }

        #endregion
        
        #region  RevokeIpRules

        /// <summary>
        /// Removes one or more rules from the specified IP access control group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RevokeIpRules service method.</param>
        /// 
        /// <returns>The response from the RevokeIpRules service method, as returned by WorkSpaces.</returns>
        /// <exception cref="Amazon.WorkSpaces.Model.AccessDeniedException">
        /// The user is not authorized to access a resource.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.InvalidParameterValuesException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.InvalidResourceStateException">
        /// The state of the resource is not valid for this operation.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/RevokeIpRules">REST API Reference for RevokeIpRules Operation</seealso>
        public virtual RevokeIpRulesResponse RevokeIpRules(RevokeIpRulesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RevokeIpRulesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RevokeIpRulesResponseUnmarshaller.Instance;

            return Invoke<RevokeIpRulesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RevokeIpRules operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RevokeIpRules operation on AmazonWorkSpacesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRevokeIpRules
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/RevokeIpRules">REST API Reference for RevokeIpRules Operation</seealso>
        public virtual IAsyncResult BeginRevokeIpRules(RevokeIpRulesRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RevokeIpRulesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RevokeIpRulesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  RevokeIpRules operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRevokeIpRules.</param>
        /// 
        /// <returns>Returns a  RevokeIpRulesResult from WorkSpaces.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/RevokeIpRules">REST API Reference for RevokeIpRules Operation</seealso>
        public virtual RevokeIpRulesResponse EndRevokeIpRules(IAsyncResult asyncResult)
        {
            return EndInvoke<RevokeIpRulesResponse>(asyncResult);
        }

        #endregion
        
        #region  StartWorkspaces

        /// <summary>
        /// Starts the specified WorkSpaces.
        /// 
        ///  
        /// <para>
        /// You cannot start a WorkSpace unless it has a running mode of <c>AutoStop</c> or <c>Manual</c>
        /// and a state of <c>STOPPED</c>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartWorkspaces service method.</param>
        /// 
        /// <returns>The response from the StartWorkspaces service method, as returned by WorkSpaces.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/StartWorkspaces">REST API Reference for StartWorkspaces Operation</seealso>
        public virtual StartWorkspacesResponse StartWorkspaces(StartWorkspacesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartWorkspacesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartWorkspacesResponseUnmarshaller.Instance;

            return Invoke<StartWorkspacesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StartWorkspaces operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartWorkspaces operation on AmazonWorkSpacesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartWorkspaces
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/StartWorkspaces">REST API Reference for StartWorkspaces Operation</seealso>
        public virtual IAsyncResult BeginStartWorkspaces(StartWorkspacesRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartWorkspacesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartWorkspacesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StartWorkspaces operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartWorkspaces.</param>
        /// 
        /// <returns>Returns a  StartWorkspacesResult from WorkSpaces.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/StartWorkspaces">REST API Reference for StartWorkspaces Operation</seealso>
        public virtual StartWorkspacesResponse EndStartWorkspaces(IAsyncResult asyncResult)
        {
            return EndInvoke<StartWorkspacesResponse>(asyncResult);
        }

        #endregion
        
        #region  StartWorkspacesPool

        /// <summary>
        /// Starts the specified pool.
        /// 
        ///  
        /// <para>
        /// You cannot start a pool unless it has a running mode of <c>AutoStop</c> and a state
        /// of <c>STOPPED</c>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartWorkspacesPool service method.</param>
        /// 
        /// <returns>The response from the StartWorkspacesPool service method, as returned by WorkSpaces.</returns>
        /// <exception cref="Amazon.WorkSpaces.Model.AccessDeniedException">
        /// The user is not authorized to access a resource.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.InvalidParameterValuesException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.InvalidResourceStateException">
        /// The state of the resource is not valid for this operation.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.OperationInProgressException">
        /// The properties of this WorkSpace are currently being modified. Try again in a moment.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.OperationNotSupportedException">
        /// This operation is not supported.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.ResourceLimitExceededException">
        /// Your resource limits have been exceeded.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/StartWorkspacesPool">REST API Reference for StartWorkspacesPool Operation</seealso>
        public virtual StartWorkspacesPoolResponse StartWorkspacesPool(StartWorkspacesPoolRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartWorkspacesPoolRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartWorkspacesPoolResponseUnmarshaller.Instance;

            return Invoke<StartWorkspacesPoolResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StartWorkspacesPool operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartWorkspacesPool operation on AmazonWorkSpacesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartWorkspacesPool
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/StartWorkspacesPool">REST API Reference for StartWorkspacesPool Operation</seealso>
        public virtual IAsyncResult BeginStartWorkspacesPool(StartWorkspacesPoolRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartWorkspacesPoolRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartWorkspacesPoolResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StartWorkspacesPool operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartWorkspacesPool.</param>
        /// 
        /// <returns>Returns a  StartWorkspacesPoolResult from WorkSpaces.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/StartWorkspacesPool">REST API Reference for StartWorkspacesPool Operation</seealso>
        public virtual StartWorkspacesPoolResponse EndStartWorkspacesPool(IAsyncResult asyncResult)
        {
            return EndInvoke<StartWorkspacesPoolResponse>(asyncResult);
        }

        #endregion
        
        #region  StopWorkspaces

        /// <summary>
        /// Stops the specified WorkSpaces.
        /// 
        ///  
        /// <para>
        /// You cannot stop a WorkSpace unless it has a running mode of <c>AutoStop</c> or <c>Manual</c>
        /// and a state of <c>AVAILABLE</c>, <c>IMPAIRED</c>, <c>UNHEALTHY</c>, or <c>ERROR</c>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopWorkspaces service method.</param>
        /// 
        /// <returns>The response from the StopWorkspaces service method, as returned by WorkSpaces.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/StopWorkspaces">REST API Reference for StopWorkspaces Operation</seealso>
        public virtual StopWorkspacesResponse StopWorkspaces(StopWorkspacesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StopWorkspacesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopWorkspacesResponseUnmarshaller.Instance;

            return Invoke<StopWorkspacesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StopWorkspaces operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopWorkspaces operation on AmazonWorkSpacesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStopWorkspaces
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/StopWorkspaces">REST API Reference for StopWorkspaces Operation</seealso>
        public virtual IAsyncResult BeginStopWorkspaces(StopWorkspacesRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StopWorkspacesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopWorkspacesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StopWorkspaces operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStopWorkspaces.</param>
        /// 
        /// <returns>Returns a  StopWorkspacesResult from WorkSpaces.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/StopWorkspaces">REST API Reference for StopWorkspaces Operation</seealso>
        public virtual StopWorkspacesResponse EndStopWorkspaces(IAsyncResult asyncResult)
        {
            return EndInvoke<StopWorkspacesResponse>(asyncResult);
        }

        #endregion
        
        #region  StopWorkspacesPool

        /// <summary>
        /// Stops the specified pool.
        /// 
        ///  
        /// <para>
        /// You cannot stop a WorkSpace pool unless it has a running mode of <c>AutoStop</c> and
        /// a state of <c>AVAILABLE</c>, <c>IMPAIRED</c>, <c>UNHEALTHY</c>, or <c>ERROR</c>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopWorkspacesPool service method.</param>
        /// 
        /// <returns>The response from the StopWorkspacesPool service method, as returned by WorkSpaces.</returns>
        /// <exception cref="Amazon.WorkSpaces.Model.AccessDeniedException">
        /// The user is not authorized to access a resource.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.InvalidParameterValuesException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.InvalidResourceStateException">
        /// The state of the resource is not valid for this operation.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.OperationInProgressException">
        /// The properties of this WorkSpace are currently being modified. Try again in a moment.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/StopWorkspacesPool">REST API Reference for StopWorkspacesPool Operation</seealso>
        public virtual StopWorkspacesPoolResponse StopWorkspacesPool(StopWorkspacesPoolRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StopWorkspacesPoolRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopWorkspacesPoolResponseUnmarshaller.Instance;

            return Invoke<StopWorkspacesPoolResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StopWorkspacesPool operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopWorkspacesPool operation on AmazonWorkSpacesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStopWorkspacesPool
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/StopWorkspacesPool">REST API Reference for StopWorkspacesPool Operation</seealso>
        public virtual IAsyncResult BeginStopWorkspacesPool(StopWorkspacesPoolRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StopWorkspacesPoolRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopWorkspacesPoolResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StopWorkspacesPool operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStopWorkspacesPool.</param>
        /// 
        /// <returns>Returns a  StopWorkspacesPoolResult from WorkSpaces.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/StopWorkspacesPool">REST API Reference for StopWorkspacesPool Operation</seealso>
        public virtual StopWorkspacesPoolResponse EndStopWorkspacesPool(IAsyncResult asyncResult)
        {
            return EndInvoke<StopWorkspacesPoolResponse>(asyncResult);
        }

        #endregion
        
        #region  TerminateWorkspaces

        /// <summary>
        /// Terminates the specified WorkSpaces.
        /// 
        ///  <important> 
        /// <para>
        /// Terminating a WorkSpace is a permanent action and cannot be undone. The user's data
        /// is destroyed. If you need to archive any user data, contact Amazon Web Services Support
        /// before terminating the WorkSpace.
        /// </para>
        ///  </important> 
        /// <para>
        /// You can terminate a WorkSpace that is in any state except <c>SUSPENDED</c>.
        /// </para>
        ///  
        /// <para>
        /// This operation is asynchronous and returns before the WorkSpaces have been completely
        /// terminated. After a WorkSpace is terminated, the <c>TERMINATED</c> state is returned
        /// only briefly before the WorkSpace directory metadata is cleaned up, so this state
        /// is rarely returned. To confirm that a WorkSpace is terminated, check for the WorkSpace
        /// ID by using <a href="https://docs.aws.amazon.com/workspaces/latest/api/API_DescribeWorkspaces.html">
        /// DescribeWorkSpaces</a>. If the WorkSpace ID isn't returned, then the WorkSpace has
        /// been successfully terminated.
        /// </para>
        ///  <note> 
        /// <para>
        /// Simple AD and AD Connector are made available to you free of charge to use with WorkSpaces.
        /// If there are no WorkSpaces being used with your Simple AD or AD Connector directory
        /// for 30 consecutive days, this directory will be automatically deregistered for use
        /// with Amazon WorkSpaces, and you will be charged for this directory as per the <a href="http://aws.amazon.com/directoryservice/pricing/">Directory
        /// Service pricing terms</a>.
        /// </para>
        ///  
        /// <para>
        /// To delete empty directories, see <a href="https://docs.aws.amazon.com/workspaces/latest/adminguide/delete-workspaces-directory.html">
        /// Delete the Directory for Your WorkSpaces</a>. If you delete your Simple AD or AD Connector
        /// directory, you can always create a new one when you want to start using WorkSpaces
        /// again.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TerminateWorkspaces service method.</param>
        /// 
        /// <returns>The response from the TerminateWorkspaces service method, as returned by WorkSpaces.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/TerminateWorkspaces">REST API Reference for TerminateWorkspaces Operation</seealso>
        public virtual TerminateWorkspacesResponse TerminateWorkspaces(TerminateWorkspacesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TerminateWorkspacesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TerminateWorkspacesResponseUnmarshaller.Instance;

            return Invoke<TerminateWorkspacesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the TerminateWorkspaces operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TerminateWorkspaces operation on AmazonWorkSpacesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTerminateWorkspaces
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/TerminateWorkspaces">REST API Reference for TerminateWorkspaces Operation</seealso>
        public virtual IAsyncResult BeginTerminateWorkspaces(TerminateWorkspacesRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TerminateWorkspacesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TerminateWorkspacesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  TerminateWorkspaces operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTerminateWorkspaces.</param>
        /// 
        /// <returns>Returns a  TerminateWorkspacesResult from WorkSpaces.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/TerminateWorkspaces">REST API Reference for TerminateWorkspaces Operation</seealso>
        public virtual TerminateWorkspacesResponse EndTerminateWorkspaces(IAsyncResult asyncResult)
        {
            return EndInvoke<TerminateWorkspacesResponse>(asyncResult);
        }

        #endregion
        
        #region  TerminateWorkspacesPool

        /// <summary>
        /// Terminates the specified pool.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TerminateWorkspacesPool service method.</param>
        /// 
        /// <returns>The response from the TerminateWorkspacesPool service method, as returned by WorkSpaces.</returns>
        /// <exception cref="Amazon.WorkSpaces.Model.AccessDeniedException">
        /// The user is not authorized to access a resource.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.InvalidParameterValuesException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.InvalidResourceStateException">
        /// The state of the resource is not valid for this operation.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.OperationInProgressException">
        /// The properties of this WorkSpace are currently being modified. Try again in a moment.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/TerminateWorkspacesPool">REST API Reference for TerminateWorkspacesPool Operation</seealso>
        public virtual TerminateWorkspacesPoolResponse TerminateWorkspacesPool(TerminateWorkspacesPoolRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TerminateWorkspacesPoolRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TerminateWorkspacesPoolResponseUnmarshaller.Instance;

            return Invoke<TerminateWorkspacesPoolResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the TerminateWorkspacesPool operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TerminateWorkspacesPool operation on AmazonWorkSpacesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTerminateWorkspacesPool
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/TerminateWorkspacesPool">REST API Reference for TerminateWorkspacesPool Operation</seealso>
        public virtual IAsyncResult BeginTerminateWorkspacesPool(TerminateWorkspacesPoolRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TerminateWorkspacesPoolRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TerminateWorkspacesPoolResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  TerminateWorkspacesPool operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTerminateWorkspacesPool.</param>
        /// 
        /// <returns>Returns a  TerminateWorkspacesPoolResult from WorkSpaces.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/TerminateWorkspacesPool">REST API Reference for TerminateWorkspacesPool Operation</seealso>
        public virtual TerminateWorkspacesPoolResponse EndTerminateWorkspacesPool(IAsyncResult asyncResult)
        {
            return EndInvoke<TerminateWorkspacesPoolResponse>(asyncResult);
        }

        #endregion
        
        #region  TerminateWorkspacesPoolSession

        /// <summary>
        /// Terminates the pool session.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TerminateWorkspacesPoolSession service method.</param>
        /// 
        /// <returns>The response from the TerminateWorkspacesPoolSession service method, as returned by WorkSpaces.</returns>
        /// <exception cref="Amazon.WorkSpaces.Model.AccessDeniedException">
        /// The user is not authorized to access a resource.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.InvalidParameterValuesException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.OperationInProgressException">
        /// The properties of this WorkSpace are currently being modified. Try again in a moment.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.OperationNotSupportedException">
        /// This operation is not supported.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/TerminateWorkspacesPoolSession">REST API Reference for TerminateWorkspacesPoolSession Operation</seealso>
        public virtual TerminateWorkspacesPoolSessionResponse TerminateWorkspacesPoolSession(TerminateWorkspacesPoolSessionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TerminateWorkspacesPoolSessionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TerminateWorkspacesPoolSessionResponseUnmarshaller.Instance;

            return Invoke<TerminateWorkspacesPoolSessionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the TerminateWorkspacesPoolSession operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TerminateWorkspacesPoolSession operation on AmazonWorkSpacesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTerminateWorkspacesPoolSession
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/TerminateWorkspacesPoolSession">REST API Reference for TerminateWorkspacesPoolSession Operation</seealso>
        public virtual IAsyncResult BeginTerminateWorkspacesPoolSession(TerminateWorkspacesPoolSessionRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TerminateWorkspacesPoolSessionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TerminateWorkspacesPoolSessionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  TerminateWorkspacesPoolSession operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTerminateWorkspacesPoolSession.</param>
        /// 
        /// <returns>Returns a  TerminateWorkspacesPoolSessionResult from WorkSpaces.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/TerminateWorkspacesPoolSession">REST API Reference for TerminateWorkspacesPoolSession Operation</seealso>
        public virtual TerminateWorkspacesPoolSessionResponse EndTerminateWorkspacesPoolSession(IAsyncResult asyncResult)
        {
            return EndInvoke<TerminateWorkspacesPoolSessionResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateConnectClientAddIn

        /// <summary>
        /// Updates a Amazon Connect client add-in. Use this action to update the name and endpoint
        /// URL of a Amazon Connect client add-in.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateConnectClientAddIn service method.</param>
        /// 
        /// <returns>The response from the UpdateConnectClientAddIn service method, as returned by WorkSpaces.</returns>
        /// <exception cref="Amazon.WorkSpaces.Model.AccessDeniedException">
        /// The user is not authorized to access a resource.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.InvalidParameterValuesException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/UpdateConnectClientAddIn">REST API Reference for UpdateConnectClientAddIn Operation</seealso>
        public virtual UpdateConnectClientAddInResponse UpdateConnectClientAddIn(UpdateConnectClientAddInRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateConnectClientAddInRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateConnectClientAddInResponseUnmarshaller.Instance;

            return Invoke<UpdateConnectClientAddInResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateConnectClientAddIn operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateConnectClientAddIn operation on AmazonWorkSpacesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateConnectClientAddIn
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/UpdateConnectClientAddIn">REST API Reference for UpdateConnectClientAddIn Operation</seealso>
        public virtual IAsyncResult BeginUpdateConnectClientAddIn(UpdateConnectClientAddInRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateConnectClientAddInRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateConnectClientAddInResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateConnectClientAddIn operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateConnectClientAddIn.</param>
        /// 
        /// <returns>Returns a  UpdateConnectClientAddInResult from WorkSpaces.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/UpdateConnectClientAddIn">REST API Reference for UpdateConnectClientAddIn Operation</seealso>
        public virtual UpdateConnectClientAddInResponse EndUpdateConnectClientAddIn(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateConnectClientAddInResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateConnectionAliasPermission

        /// <summary>
        /// Shares or unshares a connection alias with one account by specifying whether that
        /// account has permission to associate the connection alias with a directory. If the
        /// association permission is granted, the connection alias is shared with that account.
        /// If the association permission is revoked, the connection alias is unshared with the
        /// account. For more information, see <a href="https://docs.aws.amazon.com/workspaces/latest/adminguide/cross-region-redirection.html">
        /// Cross-Region Redirection for Amazon WorkSpaces</a>.
        /// 
        ///  <note> <ul> <li> 
        /// <para>
        /// Before performing this operation, call <a href="https://docs.aws.amazon.com/workspaces/latest/api/API_DescribeConnectionAliases.html">
        /// DescribeConnectionAliases</a> to make sure that the current state of the connection
        /// alias is <c>CREATED</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To delete a connection alias that has been shared, the shared account must first disassociate
        /// the connection alias from any directories it has been associated with. Then you must
        /// unshare the connection alias from the account it has been shared with. You can delete
        /// a connection alias only after it is no longer shared with any accounts or associated
        /// with any directories.
        /// </para>
        ///  </li> </ul> </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateConnectionAliasPermission service method.</param>
        /// 
        /// <returns>The response from the UpdateConnectionAliasPermission service method, as returned by WorkSpaces.</returns>
        /// <exception cref="Amazon.WorkSpaces.Model.AccessDeniedException">
        /// The user is not authorized to access a resource.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.InvalidParameterValuesException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.InvalidResourceStateException">
        /// The state of the resource is not valid for this operation.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.OperationNotSupportedException">
        /// This operation is not supported.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.ResourceAssociatedException">
        /// The resource is associated with a directory.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.ResourceLimitExceededException">
        /// Your resource limits have been exceeded.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/UpdateConnectionAliasPermission">REST API Reference for UpdateConnectionAliasPermission Operation</seealso>
        public virtual UpdateConnectionAliasPermissionResponse UpdateConnectionAliasPermission(UpdateConnectionAliasPermissionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateConnectionAliasPermissionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateConnectionAliasPermissionResponseUnmarshaller.Instance;

            return Invoke<UpdateConnectionAliasPermissionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateConnectionAliasPermission operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateConnectionAliasPermission operation on AmazonWorkSpacesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateConnectionAliasPermission
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/UpdateConnectionAliasPermission">REST API Reference for UpdateConnectionAliasPermission Operation</seealso>
        public virtual IAsyncResult BeginUpdateConnectionAliasPermission(UpdateConnectionAliasPermissionRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateConnectionAliasPermissionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateConnectionAliasPermissionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateConnectionAliasPermission operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateConnectionAliasPermission.</param>
        /// 
        /// <returns>Returns a  UpdateConnectionAliasPermissionResult from WorkSpaces.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/UpdateConnectionAliasPermission">REST API Reference for UpdateConnectionAliasPermission Operation</seealso>
        public virtual UpdateConnectionAliasPermissionResponse EndUpdateConnectionAliasPermission(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateConnectionAliasPermissionResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateRulesOfIpGroup

        /// <summary>
        /// Replaces the current rules of the specified IP access control group with the specified
        /// rules.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRulesOfIpGroup service method.</param>
        /// 
        /// <returns>The response from the UpdateRulesOfIpGroup service method, as returned by WorkSpaces.</returns>
        /// <exception cref="Amazon.WorkSpaces.Model.AccessDeniedException">
        /// The user is not authorized to access a resource.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.InvalidParameterValuesException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.InvalidResourceStateException">
        /// The state of the resource is not valid for this operation.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.ResourceLimitExceededException">
        /// Your resource limits have been exceeded.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/UpdateRulesOfIpGroup">REST API Reference for UpdateRulesOfIpGroup Operation</seealso>
        public virtual UpdateRulesOfIpGroupResponse UpdateRulesOfIpGroup(UpdateRulesOfIpGroupRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateRulesOfIpGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateRulesOfIpGroupResponseUnmarshaller.Instance;

            return Invoke<UpdateRulesOfIpGroupResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateRulesOfIpGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateRulesOfIpGroup operation on AmazonWorkSpacesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateRulesOfIpGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/UpdateRulesOfIpGroup">REST API Reference for UpdateRulesOfIpGroup Operation</seealso>
        public virtual IAsyncResult BeginUpdateRulesOfIpGroup(UpdateRulesOfIpGroupRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateRulesOfIpGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateRulesOfIpGroupResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateRulesOfIpGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateRulesOfIpGroup.</param>
        /// 
        /// <returns>Returns a  UpdateRulesOfIpGroupResult from WorkSpaces.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/UpdateRulesOfIpGroup">REST API Reference for UpdateRulesOfIpGroup Operation</seealso>
        public virtual UpdateRulesOfIpGroupResponse EndUpdateRulesOfIpGroup(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateRulesOfIpGroupResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateWorkspaceBundle

        /// <summary>
        /// Updates a WorkSpace bundle with a new image. For more information about updating WorkSpace
        /// bundles, see <a href="https://docs.aws.amazon.com/workspaces/latest/adminguide/update-custom-bundle.html">
        /// Update a Custom WorkSpaces Bundle</a>.
        /// 
        ///  <important> 
        /// <para>
        /// Existing WorkSpaces aren't automatically updated when you update the bundle that they're
        /// based on. To update existing WorkSpaces that are based on a bundle that you've updated,
        /// you must either rebuild the WorkSpaces or delete and recreate them.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateWorkspaceBundle service method.</param>
        /// 
        /// <returns>The response from the UpdateWorkspaceBundle service method, as returned by WorkSpaces.</returns>
        /// <exception cref="Amazon.WorkSpaces.Model.AccessDeniedException">
        /// The user is not authorized to access a resource.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.InvalidParameterValuesException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.OperationNotSupportedException">
        /// This operation is not supported.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.ResourceUnavailableException">
        /// The specified resource is not available.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/UpdateWorkspaceBundle">REST API Reference for UpdateWorkspaceBundle Operation</seealso>
        public virtual UpdateWorkspaceBundleResponse UpdateWorkspaceBundle(UpdateWorkspaceBundleRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateWorkspaceBundleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateWorkspaceBundleResponseUnmarshaller.Instance;

            return Invoke<UpdateWorkspaceBundleResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateWorkspaceBundle operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateWorkspaceBundle operation on AmazonWorkSpacesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateWorkspaceBundle
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/UpdateWorkspaceBundle">REST API Reference for UpdateWorkspaceBundle Operation</seealso>
        public virtual IAsyncResult BeginUpdateWorkspaceBundle(UpdateWorkspaceBundleRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateWorkspaceBundleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateWorkspaceBundleResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateWorkspaceBundle operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateWorkspaceBundle.</param>
        /// 
        /// <returns>Returns a  UpdateWorkspaceBundleResult from WorkSpaces.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/UpdateWorkspaceBundle">REST API Reference for UpdateWorkspaceBundle Operation</seealso>
        public virtual UpdateWorkspaceBundleResponse EndUpdateWorkspaceBundle(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateWorkspaceBundleResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateWorkspaceImagePermission

        /// <summary>
        /// Shares or unshares an image with one account in the same Amazon Web Services Region
        /// by specifying whether that account has permission to copy the image. If the copy image
        /// permission is granted, the image is shared with that account. If the copy image permission
        /// is revoked, the image is unshared with the account.
        /// 
        ///  
        /// <para>
        /// After an image has been shared, the recipient account can copy the image to other
        /// Regions as needed.
        /// </para>
        ///  
        /// <para>
        /// In the China (Ningxia) Region, you can copy images only within the same Region.
        /// </para>
        ///  
        /// <para>
        /// In Amazon Web Services GovCloud (US), to copy images to and from other Regions, contact
        /// Amazon Web Services Support.
        /// </para>
        ///  
        /// <para>
        /// For more information about sharing images, see <a href="https://docs.aws.amazon.com/workspaces/latest/adminguide/share-custom-image.html">
        /// Share or Unshare a Custom WorkSpaces Image</a>.
        /// </para>
        ///  <note> <ul> <li> 
        /// <para>
        /// To delete an image that has been shared, you must unshare the image before you delete
        /// it.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Sharing Bring Your Own License (BYOL) images across Amazon Web Services accounts isn't
        /// supported at this time in Amazon Web Services GovCloud (US). To share BYOL images
        /// across accounts in Amazon Web Services GovCloud (US), contact Amazon Web Services
        /// Support.
        /// </para>
        ///  </li> </ul> </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateWorkspaceImagePermission service method.</param>
        /// 
        /// <returns>The response from the UpdateWorkspaceImagePermission service method, as returned by WorkSpaces.</returns>
        /// <exception cref="Amazon.WorkSpaces.Model.AccessDeniedException">
        /// The user is not authorized to access a resource.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.InvalidParameterValuesException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.OperationNotSupportedException">
        /// This operation is not supported.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.ResourceUnavailableException">
        /// The specified resource is not available.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/UpdateWorkspaceImagePermission">REST API Reference for UpdateWorkspaceImagePermission Operation</seealso>
        public virtual UpdateWorkspaceImagePermissionResponse UpdateWorkspaceImagePermission(UpdateWorkspaceImagePermissionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateWorkspaceImagePermissionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateWorkspaceImagePermissionResponseUnmarshaller.Instance;

            return Invoke<UpdateWorkspaceImagePermissionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateWorkspaceImagePermission operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateWorkspaceImagePermission operation on AmazonWorkSpacesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateWorkspaceImagePermission
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/UpdateWorkspaceImagePermission">REST API Reference for UpdateWorkspaceImagePermission Operation</seealso>
        public virtual IAsyncResult BeginUpdateWorkspaceImagePermission(UpdateWorkspaceImagePermissionRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateWorkspaceImagePermissionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateWorkspaceImagePermissionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateWorkspaceImagePermission operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateWorkspaceImagePermission.</param>
        /// 
        /// <returns>Returns a  UpdateWorkspaceImagePermissionResult from WorkSpaces.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/UpdateWorkspaceImagePermission">REST API Reference for UpdateWorkspaceImagePermission Operation</seealso>
        public virtual UpdateWorkspaceImagePermissionResponse EndUpdateWorkspaceImagePermission(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateWorkspaceImagePermissionResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateWorkspacesPool

        /// <summary>
        /// Updates the specified pool.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateWorkspacesPool service method.</param>
        /// 
        /// <returns>The response from the UpdateWorkspacesPool service method, as returned by WorkSpaces.</returns>
        /// <exception cref="Amazon.WorkSpaces.Model.AccessDeniedException">
        /// The user is not authorized to access a resource.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.InvalidParameterValuesException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.InvalidResourceStateException">
        /// The state of the resource is not valid for this operation.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.OperationInProgressException">
        /// The properties of this WorkSpace are currently being modified. Try again in a moment.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.OperationNotSupportedException">
        /// This operation is not supported.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.ResourceLimitExceededException">
        /// Your resource limits have been exceeded.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/UpdateWorkspacesPool">REST API Reference for UpdateWorkspacesPool Operation</seealso>
        public virtual UpdateWorkspacesPoolResponse UpdateWorkspacesPool(UpdateWorkspacesPoolRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateWorkspacesPoolRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateWorkspacesPoolResponseUnmarshaller.Instance;

            return Invoke<UpdateWorkspacesPoolResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateWorkspacesPool operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateWorkspacesPool operation on AmazonWorkSpacesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateWorkspacesPool
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/UpdateWorkspacesPool">REST API Reference for UpdateWorkspacesPool Operation</seealso>
        public virtual IAsyncResult BeginUpdateWorkspacesPool(UpdateWorkspacesPoolRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateWorkspacesPoolRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateWorkspacesPoolResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateWorkspacesPool operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateWorkspacesPool.</param>
        /// 
        /// <returns>Returns a  UpdateWorkspacesPoolResult from WorkSpaces.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/UpdateWorkspacesPool">REST API Reference for UpdateWorkspacesPool Operation</seealso>
        public virtual UpdateWorkspacesPoolResponse EndUpdateWorkspacesPool(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateWorkspacesPoolResponse>(asyncResult);
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
            var requestContext = new Amazon.Runtime.Internal.RequestContext(false, CreateSigner())
            {
                ClientConfig = Config,
                OriginalRequest = request,
                Request = new Amazon.Runtime.Internal.DefaultRequest(request, ServiceMetadata.ServiceId)
            };

            var executionContext = new Amazon.Runtime.Internal.ExecutionContext(requestContext, null);
            var resolver = new AmazonWorkSpacesEndpointResolver();
            return resolver.GetEndpoint(executionContext);
        }

        #endregion

    }
}