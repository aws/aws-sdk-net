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
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.WorkSpaces.Model;
using Amazon.WorkSpaces.Model.Internal.MarshallTransformations;
using Amazon.WorkSpaces.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.WorkSpaces
{
    /// <summary>
    /// Implementation for accessing WorkSpaces
    ///
    /// Amazon WorkSpaces Service 
    /// <para>
    /// Amazon WorkSpaces enables you to provision virtual, cloud-based Microsoft Windows
    /// and Amazon Linux desktops for your users.
    /// </para>
    /// </summary>
#if NETSTANDARD13
    [Obsolete("Support for .NET Standard 1.3 is in maintenance mode and will only receive critical bug fixes and security patches. Visit https://docs.aws.amazon.com/sdk-for-net/v3/developer-guide/migration-from-net-standard-1-3.html for further details.")]
#endif
    public partial class AmazonWorkSpacesClient : AmazonServiceClient, IAmazonWorkSpaces
    {
        private static IServiceMetadata serviceMetadata = new AmazonWorkSpacesMetadata();
        
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
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }


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
#if AWS_ASYNC_ENUMERABLES_API
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


        #region  AssociateConnectionAlias

        internal virtual AssociateConnectionAliasResponse AssociateConnectionAlias(AssociateConnectionAliasRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateConnectionAliasRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateConnectionAliasResponseUnmarshaller.Instance;

            return Invoke<AssociateConnectionAliasResponse>(request, options);
        }



        /// <summary>
        /// Associates the specified connection alias with the specified directory to enable cross-Region
        /// redirection. For more information, see <a href="https://docs.aws.amazon.com/workspaces/latest/adminguide/cross-region-redirection.html">
        /// Cross-Region Redirection for Amazon WorkSpaces</a>.
        /// 
        ///  <note> 
        /// <para>
        /// Before performing this operation, call <a href="https://docs.aws.amazon.com/workspaces/latest/api/API_DescribeConnectionAliases.html">
        /// DescribeConnectionAliases</a> to make sure that the current state of the connection
        /// alias is <code>CREATED</code>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateConnectionAlias service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<AssociateConnectionAliasResponse> AssociateConnectionAliasAsync(AssociateConnectionAliasRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateConnectionAliasRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateConnectionAliasResponseUnmarshaller.Instance;

            return InvokeAsync<AssociateConnectionAliasResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  AssociateIpGroups

        internal virtual AssociateIpGroupsResponse AssociateIpGroups(AssociateIpGroupsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateIpGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateIpGroupsResponseUnmarshaller.Instance;

            return Invoke<AssociateIpGroupsResponse>(request, options);
        }



        /// <summary>
        /// Associates the specified IP access control group with the specified directory.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateIpGroups service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<AssociateIpGroupsResponse> AssociateIpGroupsAsync(AssociateIpGroupsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateIpGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateIpGroupsResponseUnmarshaller.Instance;

            return InvokeAsync<AssociateIpGroupsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  AuthorizeIpRules

        internal virtual AuthorizeIpRulesResponse AuthorizeIpRules(AuthorizeIpRulesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AuthorizeIpRulesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AuthorizeIpRulesResponseUnmarshaller.Instance;

            return Invoke<AuthorizeIpRulesResponse>(request, options);
        }



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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<AuthorizeIpRulesResponse> AuthorizeIpRulesAsync(AuthorizeIpRulesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AuthorizeIpRulesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AuthorizeIpRulesResponseUnmarshaller.Instance;

            return InvokeAsync<AuthorizeIpRulesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CopyWorkspaceImage

        internal virtual CopyWorkspaceImageResponse CopyWorkspaceImage(CopyWorkspaceImageRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CopyWorkspaceImageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CopyWorkspaceImageResponseUnmarshaller.Instance;

            return Invoke<CopyWorkspaceImageResponse>(request, options);
        }



        /// <summary>
        /// Copies the specified image from the specified Region to the current Region. For more
        /// information about copying images, see <a href="https://docs.aws.amazon.com/workspaces/latest/adminguide/copy-custom-image.html">
        /// Copy a Custom WorkSpaces Image</a>.
        /// 
        ///  <note> 
        /// <para>
        /// In the China (Ningxia) Region, you can copy images only within the same Region.
        /// </para>
        ///  
        /// <para>
        /// In the AWS GovCloud (US-West) Region, to copy images to and from other AWS Regions,
        /// contact AWS Support.
        /// </para>
        ///  </note> <important> 
        /// <para>
        /// Before copying a shared image, be sure to verify that it has been shared from the
        /// correct AWS account. To determine if an image has been shared and to see the AWS account
        /// ID that owns an image, use the <a href="https://docs.aws.amazon.com/workspaces/latest/api/API_DescribeWorkspaceImages.html">DescribeWorkSpaceImages</a>
        /// and <a href="https://docs.aws.amazon.com/workspaces/latest/api/API_DescribeWorkspaceImagePermissions.html">DescribeWorkspaceImagePermissions</a>
        /// API operations. 
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CopyWorkspaceImage service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<CopyWorkspaceImageResponse> CopyWorkspaceImageAsync(CopyWorkspaceImageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CopyWorkspaceImageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CopyWorkspaceImageResponseUnmarshaller.Instance;

            return InvokeAsync<CopyWorkspaceImageResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateConnectionAlias

        internal virtual CreateConnectionAliasResponse CreateConnectionAlias(CreateConnectionAliasRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateConnectionAliasRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateConnectionAliasResponseUnmarshaller.Instance;

            return Invoke<CreateConnectionAliasResponse>(request, options);
        }



        /// <summary>
        /// Creates the specified connection alias for use with cross-Region redirection. For
        /// more information, see <a href="https://docs.aws.amazon.com/workspaces/latest/adminguide/cross-region-redirection.html">
        /// Cross-Region Redirection for Amazon WorkSpaces</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateConnectionAlias service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<CreateConnectionAliasResponse> CreateConnectionAliasAsync(CreateConnectionAliasRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateConnectionAliasRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateConnectionAliasResponseUnmarshaller.Instance;

            return InvokeAsync<CreateConnectionAliasResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateIpGroup

        internal virtual CreateIpGroupResponse CreateIpGroup(CreateIpGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateIpGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateIpGroupResponseUnmarshaller.Instance;

            return Invoke<CreateIpGroupResponse>(request, options);
        }



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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<CreateIpGroupResponse> CreateIpGroupAsync(CreateIpGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateIpGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateIpGroupResponseUnmarshaller.Instance;

            return InvokeAsync<CreateIpGroupResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateTags

        internal virtual CreateTagsResponse CreateTags(CreateTagsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateTagsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateTagsResponseUnmarshaller.Instance;

            return Invoke<CreateTagsResponse>(request, options);
        }



        /// <summary>
        /// Creates the specified tags for the specified WorkSpaces resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTags service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<CreateTagsResponse> CreateTagsAsync(CreateTagsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateTagsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateTagsResponseUnmarshaller.Instance;

            return InvokeAsync<CreateTagsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateWorkspaces

        internal virtual CreateWorkspacesResponse CreateWorkspaces(CreateWorkspacesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateWorkspacesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateWorkspacesResponseUnmarshaller.Instance;

            return Invoke<CreateWorkspacesResponse>(request, options);
        }



        /// <summary>
        /// Creates one or more WorkSpaces.
        /// 
        ///  
        /// <para>
        /// This operation is asynchronous and returns before the WorkSpaces are created.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateWorkspaces service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateWorkspaces service method, as returned by WorkSpaces.</returns>
        /// <exception cref="Amazon.WorkSpaces.Model.InvalidParameterValuesException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.ResourceLimitExceededException">
        /// Your resource limits have been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/CreateWorkspaces">REST API Reference for CreateWorkspaces Operation</seealso>
        public virtual Task<CreateWorkspacesResponse> CreateWorkspacesAsync(CreateWorkspacesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateWorkspacesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateWorkspacesResponseUnmarshaller.Instance;

            return InvokeAsync<CreateWorkspacesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteConnectionAlias

        internal virtual DeleteConnectionAliasResponse DeleteConnectionAlias(DeleteConnectionAliasRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteConnectionAliasRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteConnectionAliasResponseUnmarshaller.Instance;

            return Invoke<DeleteConnectionAliasResponse>(request, options);
        }



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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<DeleteConnectionAliasResponse> DeleteConnectionAliasAsync(DeleteConnectionAliasRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteConnectionAliasRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteConnectionAliasResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteConnectionAliasResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteIpGroup

        internal virtual DeleteIpGroupResponse DeleteIpGroup(DeleteIpGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteIpGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteIpGroupResponseUnmarshaller.Instance;

            return Invoke<DeleteIpGroupResponse>(request, options);
        }



        /// <summary>
        /// Deletes the specified IP access control group.
        /// 
        ///  
        /// <para>
        /// You cannot delete an IP access control group that is associated with a directory.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteIpGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<DeleteIpGroupResponse> DeleteIpGroupAsync(DeleteIpGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteIpGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteIpGroupResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteIpGroupResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteTags

        internal virtual DeleteTagsResponse DeleteTags(DeleteTagsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteTagsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTagsResponseUnmarshaller.Instance;

            return Invoke<DeleteTagsResponse>(request, options);
        }



        /// <summary>
        /// Deletes the specified tags from the specified WorkSpaces resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTags service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteTags service method, as returned by WorkSpaces.</returns>
        /// <exception cref="Amazon.WorkSpaces.Model.InvalidParameterValuesException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/DeleteTags">REST API Reference for DeleteTags Operation</seealso>
        public virtual Task<DeleteTagsResponse> DeleteTagsAsync(DeleteTagsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteTagsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTagsResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteTagsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteWorkspaceImage

        internal virtual DeleteWorkspaceImageResponse DeleteWorkspaceImage(DeleteWorkspaceImageRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteWorkspaceImageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteWorkspaceImageResponseUnmarshaller.Instance;

            return Invoke<DeleteWorkspaceImageResponse>(request, options);
        }



        /// <summary>
        /// Deletes the specified image from your account. To delete an image, you must first
        /// delete any bundles that are associated with the image and unshare the image if it
        /// is shared with other accounts.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteWorkspaceImage service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<DeleteWorkspaceImageResponse> DeleteWorkspaceImageAsync(DeleteWorkspaceImageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteWorkspaceImageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteWorkspaceImageResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteWorkspaceImageResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeregisterWorkspaceDirectory

        internal virtual DeregisterWorkspaceDirectoryResponse DeregisterWorkspaceDirectory(DeregisterWorkspaceDirectoryRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeregisterWorkspaceDirectoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeregisterWorkspaceDirectoryResponseUnmarshaller.Instance;

            return Invoke<DeregisterWorkspaceDirectoryResponse>(request, options);
        }



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
        /// with Amazon WorkSpaces, and you will be charged for this directory as per the <a href="http://aws.amazon.com/directoryservice/pricing/">AWS
        /// Directory Services pricing terms</a>.
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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<DeregisterWorkspaceDirectoryResponse> DeregisterWorkspaceDirectoryAsync(DeregisterWorkspaceDirectoryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeregisterWorkspaceDirectoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeregisterWorkspaceDirectoryResponseUnmarshaller.Instance;

            return InvokeAsync<DeregisterWorkspaceDirectoryResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeAccount

        internal virtual DescribeAccountResponse DescribeAccount(DescribeAccountRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAccountRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAccountResponseUnmarshaller.Instance;

            return Invoke<DescribeAccountResponse>(request, options);
        }



        /// <summary>
        /// Retrieves a list that describes the configuration of Bring Your Own License (BYOL)
        /// for the specified account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAccount service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeAccount service method, as returned by WorkSpaces.</returns>
        /// <exception cref="Amazon.WorkSpaces.Model.AccessDeniedException">
        /// The user is not authorized to access a resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/DescribeAccount">REST API Reference for DescribeAccount Operation</seealso>
        public virtual Task<DescribeAccountResponse> DescribeAccountAsync(DescribeAccountRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAccountRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAccountResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeAccountResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeAccountModifications

        internal virtual DescribeAccountModificationsResponse DescribeAccountModifications(DescribeAccountModificationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAccountModificationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAccountModificationsResponseUnmarshaller.Instance;

            return Invoke<DescribeAccountModificationsResponse>(request, options);
        }



        /// <summary>
        /// Retrieves a list that describes modifications to the configuration of Bring Your Own
        /// License (BYOL) for the specified account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAccountModifications service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeAccountModifications service method, as returned by WorkSpaces.</returns>
        /// <exception cref="Amazon.WorkSpaces.Model.AccessDeniedException">
        /// The user is not authorized to access a resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/DescribeAccountModifications">REST API Reference for DescribeAccountModifications Operation</seealso>
        public virtual Task<DescribeAccountModificationsResponse> DescribeAccountModificationsAsync(DescribeAccountModificationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAccountModificationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAccountModificationsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeAccountModificationsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeClientProperties

        internal virtual DescribeClientPropertiesResponse DescribeClientProperties(DescribeClientPropertiesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeClientPropertiesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeClientPropertiesResponseUnmarshaller.Instance;

            return Invoke<DescribeClientPropertiesResponse>(request, options);
        }



        /// <summary>
        /// Retrieves a list that describes one or more specified Amazon WorkSpaces clients.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeClientProperties service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<DescribeClientPropertiesResponse> DescribeClientPropertiesAsync(DescribeClientPropertiesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeClientPropertiesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeClientPropertiesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeClientPropertiesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeConnectionAliases

        internal virtual DescribeConnectionAliasesResponse DescribeConnectionAliases(DescribeConnectionAliasesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeConnectionAliasesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeConnectionAliasesResponseUnmarshaller.Instance;

            return Invoke<DescribeConnectionAliasesResponse>(request, options);
        }



        /// <summary>
        /// Retrieves a list that describes the connection aliases used for cross-Region redirection.
        /// For more information, see <a href="https://docs.aws.amazon.com/workspaces/latest/adminguide/cross-region-redirection.html">
        /// Cross-Region Redirection for Amazon WorkSpaces</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeConnectionAliases service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<DescribeConnectionAliasesResponse> DescribeConnectionAliasesAsync(DescribeConnectionAliasesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeConnectionAliasesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeConnectionAliasesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeConnectionAliasesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeConnectionAliasPermissions

        internal virtual DescribeConnectionAliasPermissionsResponse DescribeConnectionAliasPermissions(DescribeConnectionAliasPermissionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeConnectionAliasPermissionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeConnectionAliasPermissionsResponseUnmarshaller.Instance;

            return Invoke<DescribeConnectionAliasPermissionsResponse>(request, options);
        }



        /// <summary>
        /// Describes the permissions that the owner of a connection alias has granted to another
        /// AWS account for the specified connection alias. For more information, see <a href="https://docs.aws.amazon.com/workspaces/latest/adminguide/cross-region-redirection.html">
        /// Cross-Region Redirection for Amazon WorkSpaces</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeConnectionAliasPermissions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<DescribeConnectionAliasPermissionsResponse> DescribeConnectionAliasPermissionsAsync(DescribeConnectionAliasPermissionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeConnectionAliasPermissionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeConnectionAliasPermissionsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeConnectionAliasPermissionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeIpGroups

        internal virtual DescribeIpGroupsResponse DescribeIpGroups(DescribeIpGroupsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeIpGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeIpGroupsResponseUnmarshaller.Instance;

            return Invoke<DescribeIpGroupsResponse>(request, options);
        }



        /// <summary>
        /// Describes one or more of your IP access control groups.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeIpGroups service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeIpGroups service method, as returned by WorkSpaces.</returns>
        /// <exception cref="Amazon.WorkSpaces.Model.AccessDeniedException">
        /// The user is not authorized to access a resource.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.InvalidParameterValuesException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/DescribeIpGroups">REST API Reference for DescribeIpGroups Operation</seealso>
        public virtual Task<DescribeIpGroupsResponse> DescribeIpGroupsAsync(DescribeIpGroupsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeIpGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeIpGroupsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeIpGroupsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeTags

        internal virtual DescribeTagsResponse DescribeTags(DescribeTagsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeTagsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeTagsResponseUnmarshaller.Instance;

            return Invoke<DescribeTagsResponse>(request, options);
        }



        /// <summary>
        /// Describes the specified tags for the specified WorkSpaces resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeTags service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeTags service method, as returned by WorkSpaces.</returns>
        /// <exception cref="Amazon.WorkSpaces.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/DescribeTags">REST API Reference for DescribeTags Operation</seealso>
        public virtual Task<DescribeTagsResponse> DescribeTagsAsync(DescribeTagsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeTagsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeTagsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeTagsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeWorkspaceBundles

        internal virtual DescribeWorkspaceBundlesResponse DescribeWorkspaceBundles(DescribeWorkspaceBundlesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeWorkspaceBundlesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeWorkspaceBundlesResponseUnmarshaller.Instance;

            return Invoke<DescribeWorkspaceBundlesResponse>(request, options);
        }


        /// <summary>
        /// Retrieves a list that describes the available WorkSpace bundles.
        /// 
        ///  
        /// <para>
        /// You can filter the results using either bundle ID or owner, but not both.
        /// </para>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeWorkspaceBundles service method, as returned by WorkSpaces.</returns>
        /// <exception cref="Amazon.WorkSpaces.Model.InvalidParameterValuesException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/DescribeWorkspaceBundles">REST API Reference for DescribeWorkspaceBundles Operation</seealso>
        public virtual Task<DescribeWorkspaceBundlesResponse> DescribeWorkspaceBundlesAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new DescribeWorkspaceBundlesRequest();
            return DescribeWorkspaceBundlesAsync(request, cancellationToken);
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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeWorkspaceBundles service method, as returned by WorkSpaces.</returns>
        /// <exception cref="Amazon.WorkSpaces.Model.InvalidParameterValuesException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/DescribeWorkspaceBundles">REST API Reference for DescribeWorkspaceBundles Operation</seealso>
        public virtual Task<DescribeWorkspaceBundlesResponse> DescribeWorkspaceBundlesAsync(DescribeWorkspaceBundlesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeWorkspaceBundlesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeWorkspaceBundlesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeWorkspaceBundlesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeWorkspaceDirectories

        internal virtual DescribeWorkspaceDirectoriesResponse DescribeWorkspaceDirectories(DescribeWorkspaceDirectoriesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeWorkspaceDirectoriesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeWorkspaceDirectoriesResponseUnmarshaller.Instance;

            return Invoke<DescribeWorkspaceDirectoriesResponse>(request, options);
        }


        /// <summary>
        /// Describes the available directories that are registered with Amazon WorkSpaces.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeWorkspaceDirectories service method, as returned by WorkSpaces.</returns>
        /// <exception cref="Amazon.WorkSpaces.Model.InvalidParameterValuesException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/DescribeWorkspaceDirectories">REST API Reference for DescribeWorkspaceDirectories Operation</seealso>
        public virtual Task<DescribeWorkspaceDirectoriesResponse> DescribeWorkspaceDirectoriesAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new DescribeWorkspaceDirectoriesRequest();
            return DescribeWorkspaceDirectoriesAsync(request, cancellationToken);
        }



        /// <summary>
        /// Describes the available directories that are registered with Amazon WorkSpaces.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeWorkspaceDirectories service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeWorkspaceDirectories service method, as returned by WorkSpaces.</returns>
        /// <exception cref="Amazon.WorkSpaces.Model.InvalidParameterValuesException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/DescribeWorkspaceDirectories">REST API Reference for DescribeWorkspaceDirectories Operation</seealso>
        public virtual Task<DescribeWorkspaceDirectoriesResponse> DescribeWorkspaceDirectoriesAsync(DescribeWorkspaceDirectoriesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeWorkspaceDirectoriesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeWorkspaceDirectoriesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeWorkspaceDirectoriesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeWorkspaceImagePermissions

        internal virtual DescribeWorkspaceImagePermissionsResponse DescribeWorkspaceImagePermissions(DescribeWorkspaceImagePermissionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeWorkspaceImagePermissionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeWorkspaceImagePermissionsResponseUnmarshaller.Instance;

            return Invoke<DescribeWorkspaceImagePermissionsResponse>(request, options);
        }



        /// <summary>
        /// Describes the permissions that the owner of an image has granted to other AWS accounts
        /// for an image.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeWorkspaceImagePermissions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<DescribeWorkspaceImagePermissionsResponse> DescribeWorkspaceImagePermissionsAsync(DescribeWorkspaceImagePermissionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeWorkspaceImagePermissionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeWorkspaceImagePermissionsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeWorkspaceImagePermissionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeWorkspaceImages

        internal virtual DescribeWorkspaceImagesResponse DescribeWorkspaceImages(DescribeWorkspaceImagesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeWorkspaceImagesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeWorkspaceImagesResponseUnmarshaller.Instance;

            return Invoke<DescribeWorkspaceImagesResponse>(request, options);
        }



        /// <summary>
        /// Retrieves a list that describes one or more specified images, if the image identifiers
        /// are provided. Otherwise, all images in the account are described.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeWorkspaceImages service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeWorkspaceImages service method, as returned by WorkSpaces.</returns>
        /// <exception cref="Amazon.WorkSpaces.Model.AccessDeniedException">
        /// The user is not authorized to access a resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/DescribeWorkspaceImages">REST API Reference for DescribeWorkspaceImages Operation</seealso>
        public virtual Task<DescribeWorkspaceImagesResponse> DescribeWorkspaceImagesAsync(DescribeWorkspaceImagesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeWorkspaceImagesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeWorkspaceImagesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeWorkspaceImagesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeWorkspaces

        internal virtual DescribeWorkspacesResponse DescribeWorkspaces(DescribeWorkspacesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeWorkspacesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeWorkspacesResponseUnmarshaller.Instance;

            return Invoke<DescribeWorkspacesResponse>(request, options);
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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeWorkspaces service method, as returned by WorkSpaces.</returns>
        /// <exception cref="Amazon.WorkSpaces.Model.InvalidParameterValuesException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.ResourceUnavailableException">
        /// The specified resource is not available.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/DescribeWorkspaces">REST API Reference for DescribeWorkspaces Operation</seealso>
        public virtual Task<DescribeWorkspacesResponse> DescribeWorkspacesAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new DescribeWorkspacesRequest();
            return DescribeWorkspacesAsync(request, cancellationToken);
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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeWorkspaces service method, as returned by WorkSpaces.</returns>
        /// <exception cref="Amazon.WorkSpaces.Model.InvalidParameterValuesException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.ResourceUnavailableException">
        /// The specified resource is not available.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/DescribeWorkspaces">REST API Reference for DescribeWorkspaces Operation</seealso>
        public virtual Task<DescribeWorkspacesResponse> DescribeWorkspacesAsync(DescribeWorkspacesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeWorkspacesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeWorkspacesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeWorkspacesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeWorkspacesConnectionStatus

        internal virtual DescribeWorkspacesConnectionStatusResponse DescribeWorkspacesConnectionStatus(DescribeWorkspacesConnectionStatusRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeWorkspacesConnectionStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeWorkspacesConnectionStatusResponseUnmarshaller.Instance;

            return Invoke<DescribeWorkspacesConnectionStatusResponse>(request, options);
        }



        /// <summary>
        /// Describes the connection status of the specified WorkSpaces.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeWorkspacesConnectionStatus service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeWorkspacesConnectionStatus service method, as returned by WorkSpaces.</returns>
        /// <exception cref="Amazon.WorkSpaces.Model.InvalidParameterValuesException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/DescribeWorkspacesConnectionStatus">REST API Reference for DescribeWorkspacesConnectionStatus Operation</seealso>
        public virtual Task<DescribeWorkspacesConnectionStatusResponse> DescribeWorkspacesConnectionStatusAsync(DescribeWorkspacesConnectionStatusRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeWorkspacesConnectionStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeWorkspacesConnectionStatusResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeWorkspacesConnectionStatusResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeWorkspaceSnapshots

        internal virtual DescribeWorkspaceSnapshotsResponse DescribeWorkspaceSnapshots(DescribeWorkspaceSnapshotsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeWorkspaceSnapshotsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeWorkspaceSnapshotsResponseUnmarshaller.Instance;

            return Invoke<DescribeWorkspaceSnapshotsResponse>(request, options);
        }



        /// <summary>
        /// Describes the snapshots for the specified WorkSpace.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeWorkspaceSnapshots service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<DescribeWorkspaceSnapshotsResponse> DescribeWorkspaceSnapshotsAsync(DescribeWorkspaceSnapshotsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeWorkspaceSnapshotsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeWorkspaceSnapshotsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeWorkspaceSnapshotsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DisassociateConnectionAlias

        internal virtual DisassociateConnectionAliasResponse DisassociateConnectionAlias(DisassociateConnectionAliasRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateConnectionAliasRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateConnectionAliasResponseUnmarshaller.Instance;

            return Invoke<DisassociateConnectionAliasResponse>(request, options);
        }



        /// <summary>
        /// Disassociates a connection alias from a directory. Disassociating a connection alias
        /// disables cross-Region redirection between two directories in different AWS Regions.
        /// For more information, see <a href="https://docs.aws.amazon.com/workspaces/latest/adminguide/cross-region-redirection.html">
        /// Cross-Region Redirection for Amazon WorkSpaces</a>.
        /// 
        ///  <note> 
        /// <para>
        /// Before performing this operation, call <a href="https://docs.aws.amazon.com/workspaces/latest/api/API_DescribeConnectionAliases.html">
        /// DescribeConnectionAliases</a> to make sure that the current state of the connection
        /// alias is <code>CREATED</code>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateConnectionAlias service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<DisassociateConnectionAliasResponse> DisassociateConnectionAliasAsync(DisassociateConnectionAliasRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateConnectionAliasRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateConnectionAliasResponseUnmarshaller.Instance;

            return InvokeAsync<DisassociateConnectionAliasResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DisassociateIpGroups

        internal virtual DisassociateIpGroupsResponse DisassociateIpGroups(DisassociateIpGroupsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateIpGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateIpGroupsResponseUnmarshaller.Instance;

            return Invoke<DisassociateIpGroupsResponse>(request, options);
        }



        /// <summary>
        /// Disassociates the specified IP access control group from the specified directory.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateIpGroups service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        /// <exception cref="Amazon.WorkSpaces.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/DisassociateIpGroups">REST API Reference for DisassociateIpGroups Operation</seealso>
        public virtual Task<DisassociateIpGroupsResponse> DisassociateIpGroupsAsync(DisassociateIpGroupsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateIpGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateIpGroupsResponseUnmarshaller.Instance;

            return InvokeAsync<DisassociateIpGroupsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ImportWorkspaceImage

        internal virtual ImportWorkspaceImageResponse ImportWorkspaceImage(ImportWorkspaceImageRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ImportWorkspaceImageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ImportWorkspaceImageResponseUnmarshaller.Instance;

            return Invoke<ImportWorkspaceImageResponse>(request, options);
        }



        /// <summary>
        /// Imports the specified Windows 10 Bring Your Own License (BYOL) image into Amazon WorkSpaces.
        /// The image must be an already licensed Amazon EC2 image that is in your AWS account,
        /// and you must own the image. For more information about creating BYOL images, see <a
        /// href="https://docs.aws.amazon.com/workspaces/latest/adminguide/byol-windows-images.html">
        /// Bring Your Own Windows Desktop Licenses</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ImportWorkspaceImage service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<ImportWorkspaceImageResponse> ImportWorkspaceImageAsync(ImportWorkspaceImageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ImportWorkspaceImageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ImportWorkspaceImageResponseUnmarshaller.Instance;

            return InvokeAsync<ImportWorkspaceImageResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListAvailableManagementCidrRanges

        internal virtual ListAvailableManagementCidrRangesResponse ListAvailableManagementCidrRanges(ListAvailableManagementCidrRangesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAvailableManagementCidrRangesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAvailableManagementCidrRangesResponseUnmarshaller.Instance;

            return Invoke<ListAvailableManagementCidrRangesResponse>(request, options);
        }



        /// <summary>
        /// Retrieves a list of IP address ranges, specified as IPv4 CIDR blocks, that you can
        /// use for the network management interface when you enable Bring Your Own License (BYOL).
        /// 
        /// 
        ///  
        /// <para>
        /// This operation can be run only by AWS accounts that are enabled for BYOL. If your
        /// account isn't enabled for BYOL, you'll receive an <code>AccessDeniedException</code>
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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAvailableManagementCidrRanges service method, as returned by WorkSpaces.</returns>
        /// <exception cref="Amazon.WorkSpaces.Model.AccessDeniedException">
        /// The user is not authorized to access a resource.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.InvalidParameterValuesException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/ListAvailableManagementCidrRanges">REST API Reference for ListAvailableManagementCidrRanges Operation</seealso>
        public virtual Task<ListAvailableManagementCidrRangesResponse> ListAvailableManagementCidrRangesAsync(ListAvailableManagementCidrRangesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAvailableManagementCidrRangesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAvailableManagementCidrRangesResponseUnmarshaller.Instance;

            return InvokeAsync<ListAvailableManagementCidrRangesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  MigrateWorkspace

        internal virtual MigrateWorkspaceResponse MigrateWorkspace(MigrateWorkspaceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = MigrateWorkspaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = MigrateWorkspaceResponseUnmarshaller.Instance;

            return Invoke<MigrateWorkspaceResponse>(request, options);
        }



        /// <summary>
        /// Migrates a WorkSpace from one operating system or bundle type to another, while retaining
        /// the data on the user volume.
        /// 
        ///  
        /// <para>
        /// The migration process recreates the WorkSpace by using a new root volume from the
        /// target bundle image and the user volume from the last available snapshot of the original
        /// WorkSpace. During migration, the original <code>D:\Users\%USERNAME%</code> user profile
        /// folder is renamed to <code>D:\Users\%USERNAME%MMddyyTHHmmss%.NotMigrated</code>. A
        /// new <code>D:\Users\%USERNAME%\</code> folder is generated by the new OS. Certain files
        /// in the old user profile are moved to the new user profile.
        /// </para>
        ///  
        /// <para>
        /// For available migration scenarios, details about what happens during migration, and
        /// best practices, see <a href="https://docs.aws.amazon.com/workspaces/latest/adminguide/migrate-workspaces.html">Migrate
        /// a WorkSpace</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the MigrateWorkspace service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<MigrateWorkspaceResponse> MigrateWorkspaceAsync(MigrateWorkspaceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = MigrateWorkspaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = MigrateWorkspaceResponseUnmarshaller.Instance;

            return InvokeAsync<MigrateWorkspaceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ModifyAccount

        internal virtual ModifyAccountResponse ModifyAccount(ModifyAccountRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyAccountRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyAccountResponseUnmarshaller.Instance;

            return Invoke<ModifyAccountResponse>(request, options);
        }



        /// <summary>
        /// Modifies the configuration of Bring Your Own License (BYOL) for the specified account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyAccount service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<ModifyAccountResponse> ModifyAccountAsync(ModifyAccountRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyAccountRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyAccountResponseUnmarshaller.Instance;

            return InvokeAsync<ModifyAccountResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ModifyClientProperties

        internal virtual ModifyClientPropertiesResponse ModifyClientProperties(ModifyClientPropertiesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyClientPropertiesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyClientPropertiesResponseUnmarshaller.Instance;

            return Invoke<ModifyClientPropertiesResponse>(request, options);
        }



        /// <summary>
        /// Modifies the properties of the specified Amazon WorkSpaces clients.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyClientProperties service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ModifyClientProperties service method, as returned by WorkSpaces.</returns>
        /// <exception cref="Amazon.WorkSpaces.Model.AccessDeniedException">
        /// The user is not authorized to access a resource.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.InvalidParameterValuesException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/ModifyClientProperties">REST API Reference for ModifyClientProperties Operation</seealso>
        public virtual Task<ModifyClientPropertiesResponse> ModifyClientPropertiesAsync(ModifyClientPropertiesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyClientPropertiesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyClientPropertiesResponseUnmarshaller.Instance;

            return InvokeAsync<ModifyClientPropertiesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ModifySelfservicePermissions

        internal virtual ModifySelfservicePermissionsResponse ModifySelfservicePermissions(ModifySelfservicePermissionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifySelfservicePermissionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifySelfservicePermissionsResponseUnmarshaller.Instance;

            return Invoke<ModifySelfservicePermissionsResponse>(request, options);
        }



        /// <summary>
        /// Modifies the self-service WorkSpace management capabilities for your users. For more
        /// information, see <a href="https://docs.aws.amazon.com/workspaces/latest/adminguide/enable-user-self-service-workspace-management.html">Enable
        /// Self-Service WorkSpace Management Capabilities for Your Users</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifySelfservicePermissions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ModifySelfservicePermissions service method, as returned by WorkSpaces.</returns>
        /// <exception cref="Amazon.WorkSpaces.Model.AccessDeniedException">
        /// The user is not authorized to access a resource.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.InvalidParameterValuesException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/ModifySelfservicePermissions">REST API Reference for ModifySelfservicePermissions Operation</seealso>
        public virtual Task<ModifySelfservicePermissionsResponse> ModifySelfservicePermissionsAsync(ModifySelfservicePermissionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifySelfservicePermissionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifySelfservicePermissionsResponseUnmarshaller.Instance;

            return InvokeAsync<ModifySelfservicePermissionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ModifyWorkspaceAccessProperties

        internal virtual ModifyWorkspaceAccessPropertiesResponse ModifyWorkspaceAccessProperties(ModifyWorkspaceAccessPropertiesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyWorkspaceAccessPropertiesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyWorkspaceAccessPropertiesResponseUnmarshaller.Instance;

            return Invoke<ModifyWorkspaceAccessPropertiesResponse>(request, options);
        }



        /// <summary>
        /// Specifies which devices and operating systems users can use to access their WorkSpaces.
        /// For more information, see <a href="https://docs.aws.amazon.com/workspaces/latest/adminguide/update-directory-details.html#control-device-access">
        /// Control Device Access</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyWorkspaceAccessProperties service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ModifyWorkspaceAccessProperties service method, as returned by WorkSpaces.</returns>
        /// <exception cref="Amazon.WorkSpaces.Model.AccessDeniedException">
        /// The user is not authorized to access a resource.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/ModifyWorkspaceAccessProperties">REST API Reference for ModifyWorkspaceAccessProperties Operation</seealso>
        public virtual Task<ModifyWorkspaceAccessPropertiesResponse> ModifyWorkspaceAccessPropertiesAsync(ModifyWorkspaceAccessPropertiesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyWorkspaceAccessPropertiesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyWorkspaceAccessPropertiesResponseUnmarshaller.Instance;

            return InvokeAsync<ModifyWorkspaceAccessPropertiesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ModifyWorkspaceCreationProperties

        internal virtual ModifyWorkspaceCreationPropertiesResponse ModifyWorkspaceCreationProperties(ModifyWorkspaceCreationPropertiesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyWorkspaceCreationPropertiesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyWorkspaceCreationPropertiesResponseUnmarshaller.Instance;

            return Invoke<ModifyWorkspaceCreationPropertiesResponse>(request, options);
        }



        /// <summary>
        /// Modify the default properties used to create WorkSpaces.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyWorkspaceCreationProperties service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<ModifyWorkspaceCreationPropertiesResponse> ModifyWorkspaceCreationPropertiesAsync(ModifyWorkspaceCreationPropertiesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyWorkspaceCreationPropertiesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyWorkspaceCreationPropertiesResponseUnmarshaller.Instance;

            return InvokeAsync<ModifyWorkspaceCreationPropertiesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ModifyWorkspaceProperties

        internal virtual ModifyWorkspacePropertiesResponse ModifyWorkspaceProperties(ModifyWorkspacePropertiesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyWorkspacePropertiesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyWorkspacePropertiesResponseUnmarshaller.Instance;

            return Invoke<ModifyWorkspacePropertiesResponse>(request, options);
        }



        /// <summary>
        /// Modifies the specified WorkSpace properties. For important information about how to
        /// modify the size of the root and user volumes, see <a href="https://docs.aws.amazon.com/workspaces/latest/adminguide/modify-workspaces.html">
        /// Modify a WorkSpace</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyWorkspaceProperties service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<ModifyWorkspacePropertiesResponse> ModifyWorkspacePropertiesAsync(ModifyWorkspacePropertiesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyWorkspacePropertiesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyWorkspacePropertiesResponseUnmarshaller.Instance;

            return InvokeAsync<ModifyWorkspacePropertiesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ModifyWorkspaceState

        internal virtual ModifyWorkspaceStateResponse ModifyWorkspaceState(ModifyWorkspaceStateRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyWorkspaceStateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyWorkspaceStateResponseUnmarshaller.Instance;

            return Invoke<ModifyWorkspaceStateResponse>(request, options);
        }



        /// <summary>
        /// Sets the state of the specified WorkSpace.
        /// 
        ///  
        /// <para>
        /// To maintain a WorkSpace without being interrupted, set the WorkSpace state to <code>ADMIN_MAINTENANCE</code>.
        /// WorkSpaces in this state do not respond to requests to reboot, stop, start, rebuild,
        /// or restore. An AutoStop WorkSpace in this state is not stopped. Users cannot log into
        /// a WorkSpace in the <code>ADMIN_MAINTENANCE</code> state.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyWorkspaceState service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ModifyWorkspaceState service method, as returned by WorkSpaces.</returns>
        /// <exception cref="Amazon.WorkSpaces.Model.InvalidParameterValuesException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.InvalidResourceStateException">
        /// The state of the resource is not valid for this operation.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/ModifyWorkspaceState">REST API Reference for ModifyWorkspaceState Operation</seealso>
        public virtual Task<ModifyWorkspaceStateResponse> ModifyWorkspaceStateAsync(ModifyWorkspaceStateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyWorkspaceStateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyWorkspaceStateResponseUnmarshaller.Instance;

            return InvokeAsync<ModifyWorkspaceStateResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RebootWorkspaces

        internal virtual RebootWorkspacesResponse RebootWorkspaces(RebootWorkspacesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RebootWorkspacesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RebootWorkspacesResponseUnmarshaller.Instance;

            return Invoke<RebootWorkspacesResponse>(request, options);
        }



        /// <summary>
        /// Reboots the specified WorkSpaces.
        /// 
        ///  
        /// <para>
        /// You cannot reboot a WorkSpace unless its state is <code>AVAILABLE</code> or <code>UNHEALTHY</code>.
        /// </para>
        ///  
        /// <para>
        /// This operation is asynchronous and returns before the WorkSpaces have rebooted.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RebootWorkspaces service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RebootWorkspaces service method, as returned by WorkSpaces.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/RebootWorkspaces">REST API Reference for RebootWorkspaces Operation</seealso>
        public virtual Task<RebootWorkspacesResponse> RebootWorkspacesAsync(RebootWorkspacesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RebootWorkspacesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RebootWorkspacesResponseUnmarshaller.Instance;

            return InvokeAsync<RebootWorkspacesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RebuildWorkspaces

        internal virtual RebuildWorkspacesResponse RebuildWorkspaces(RebuildWorkspacesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RebuildWorkspacesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RebuildWorkspacesResponseUnmarshaller.Instance;

            return Invoke<RebuildWorkspacesResponse>(request, options);
        }



        /// <summary>
        /// Rebuilds the specified WorkSpace.
        /// 
        ///  
        /// <para>
        /// You cannot rebuild a WorkSpace unless its state is <code>AVAILABLE</code>, <code>ERROR</code>,
        /// <code>UNHEALTHY</code>, <code>STOPPED</code>, or <code>REBOOTING</code>.
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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RebuildWorkspaces service method, as returned by WorkSpaces.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/RebuildWorkspaces">REST API Reference for RebuildWorkspaces Operation</seealso>
        public virtual Task<RebuildWorkspacesResponse> RebuildWorkspacesAsync(RebuildWorkspacesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RebuildWorkspacesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RebuildWorkspacesResponseUnmarshaller.Instance;

            return InvokeAsync<RebuildWorkspacesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RegisterWorkspaceDirectory

        internal virtual RegisterWorkspaceDirectoryResponse RegisterWorkspaceDirectory(RegisterWorkspaceDirectoryRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RegisterWorkspaceDirectoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RegisterWorkspaceDirectoryResponseUnmarshaller.Instance;

            return Invoke<RegisterWorkspaceDirectoryResponse>(request, options);
        }



        /// <summary>
        /// Registers the specified directory. This operation is asynchronous and returns before
        /// the WorkSpace directory is registered. If this is the first time you are registering
        /// a directory, you will need to create the workspaces_DefaultRole role before you can
        /// register a directory. For more information, see <a href="https://docs.aws.amazon.com/workspaces/latest/adminguide/workspaces-access-control.html#create-default-role">
        /// Creating the workspaces_DefaultRole Role</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RegisterWorkspaceDirectory service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<RegisterWorkspaceDirectoryResponse> RegisterWorkspaceDirectoryAsync(RegisterWorkspaceDirectoryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RegisterWorkspaceDirectoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RegisterWorkspaceDirectoryResponseUnmarshaller.Instance;

            return InvokeAsync<RegisterWorkspaceDirectoryResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RestoreWorkspace

        internal virtual RestoreWorkspaceResponse RestoreWorkspace(RestoreWorkspaceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RestoreWorkspaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RestoreWorkspaceResponseUnmarshaller.Instance;

            return Invoke<RestoreWorkspaceResponse>(request, options);
        }



        /// <summary>
        /// Restores the specified WorkSpace to its last known healthy state.
        /// 
        ///  
        /// <para>
        /// You cannot restore a WorkSpace unless its state is <code> AVAILABLE</code>, <code>ERROR</code>,
        /// <code>UNHEALTHY</code>, or <code>STOPPED</code>.
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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RestoreWorkspace service method, as returned by WorkSpaces.</returns>
        /// <exception cref="Amazon.WorkSpaces.Model.AccessDeniedException">
        /// The user is not authorized to access a resource.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.InvalidParameterValuesException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/RestoreWorkspace">REST API Reference for RestoreWorkspace Operation</seealso>
        public virtual Task<RestoreWorkspaceResponse> RestoreWorkspaceAsync(RestoreWorkspaceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RestoreWorkspaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RestoreWorkspaceResponseUnmarshaller.Instance;

            return InvokeAsync<RestoreWorkspaceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RevokeIpRules

        internal virtual RevokeIpRulesResponse RevokeIpRules(RevokeIpRulesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RevokeIpRulesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RevokeIpRulesResponseUnmarshaller.Instance;

            return Invoke<RevokeIpRulesResponse>(request, options);
        }



        /// <summary>
        /// Removes one or more rules from the specified IP access control group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RevokeIpRules service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<RevokeIpRulesResponse> RevokeIpRulesAsync(RevokeIpRulesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RevokeIpRulesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RevokeIpRulesResponseUnmarshaller.Instance;

            return InvokeAsync<RevokeIpRulesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StartWorkspaces

        internal virtual StartWorkspacesResponse StartWorkspaces(StartWorkspacesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartWorkspacesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartWorkspacesResponseUnmarshaller.Instance;

            return Invoke<StartWorkspacesResponse>(request, options);
        }



        /// <summary>
        /// Starts the specified WorkSpaces.
        /// 
        ///  
        /// <para>
        /// You cannot start a WorkSpace unless it has a running mode of <code>AutoStop</code>
        /// and a state of <code>STOPPED</code>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartWorkspaces service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartWorkspaces service method, as returned by WorkSpaces.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/StartWorkspaces">REST API Reference for StartWorkspaces Operation</seealso>
        public virtual Task<StartWorkspacesResponse> StartWorkspacesAsync(StartWorkspacesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartWorkspacesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartWorkspacesResponseUnmarshaller.Instance;

            return InvokeAsync<StartWorkspacesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StopWorkspaces

        internal virtual StopWorkspacesResponse StopWorkspaces(StopWorkspacesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopWorkspacesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopWorkspacesResponseUnmarshaller.Instance;

            return Invoke<StopWorkspacesResponse>(request, options);
        }



        /// <summary>
        /// Stops the specified WorkSpaces.
        /// 
        ///  
        /// <para>
        /// You cannot stop a WorkSpace unless it has a running mode of <code>AutoStop</code>
        /// and a state of <code>AVAILABLE</code>, <code>IMPAIRED</code>, <code>UNHEALTHY</code>,
        /// or <code>ERROR</code>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopWorkspaces service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StopWorkspaces service method, as returned by WorkSpaces.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/StopWorkspaces">REST API Reference for StopWorkspaces Operation</seealso>
        public virtual Task<StopWorkspacesResponse> StopWorkspacesAsync(StopWorkspacesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopWorkspacesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopWorkspacesResponseUnmarshaller.Instance;

            return InvokeAsync<StopWorkspacesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  TerminateWorkspaces

        internal virtual TerminateWorkspacesResponse TerminateWorkspaces(TerminateWorkspacesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TerminateWorkspacesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TerminateWorkspacesResponseUnmarshaller.Instance;

            return Invoke<TerminateWorkspacesResponse>(request, options);
        }



        /// <summary>
        /// Terminates the specified WorkSpaces.
        /// 
        ///  <important> 
        /// <para>
        /// Terminating a WorkSpace is a permanent action and cannot be undone. The user's data
        /// is destroyed. If you need to archive any user data, contact AWS Support before terminating
        /// the WorkSpace.
        /// </para>
        ///  </important> 
        /// <para>
        /// You can terminate a WorkSpace that is in any state except <code>SUSPENDED</code>.
        /// </para>
        ///  
        /// <para>
        /// This operation is asynchronous and returns before the WorkSpaces have been completely
        /// terminated. After a WorkSpace is terminated, the <code>TERMINATED</code> state is
        /// returned only briefly before the WorkSpace directory metadata is cleaned up, so this
        /// state is rarely returned. To confirm that a WorkSpace is terminated, check for the
        /// WorkSpace ID by using <a href="https://docs.aws.amazon.com/workspaces/latest/api/API_DescribeWorkspaces.html">
        /// DescribeWorkSpaces</a>. If the WorkSpace ID isn't returned, then the WorkSpace has
        /// been successfully terminated.
        /// </para>
        ///  <note> 
        /// <para>
        /// Simple AD and AD Connector are made available to you free of charge to use with WorkSpaces.
        /// If there are no WorkSpaces being used with your Simple AD or AD Connector directory
        /// for 30 consecutive days, this directory will be automatically deregistered for use
        /// with Amazon WorkSpaces, and you will be charged for this directory as per the <a href="http://aws.amazon.com/directoryservice/pricing/">AWS
        /// Directory Services pricing terms</a>.
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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TerminateWorkspaces service method, as returned by WorkSpaces.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/TerminateWorkspaces">REST API Reference for TerminateWorkspaces Operation</seealso>
        public virtual Task<TerminateWorkspacesResponse> TerminateWorkspacesAsync(TerminateWorkspacesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TerminateWorkspacesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TerminateWorkspacesResponseUnmarshaller.Instance;

            return InvokeAsync<TerminateWorkspacesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateConnectionAliasPermission

        internal virtual UpdateConnectionAliasPermissionResponse UpdateConnectionAliasPermission(UpdateConnectionAliasPermissionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateConnectionAliasPermissionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateConnectionAliasPermissionResponseUnmarshaller.Instance;

            return Invoke<UpdateConnectionAliasPermissionResponse>(request, options);
        }



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
        /// alias is <code>CREATED</code>.
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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<UpdateConnectionAliasPermissionResponse> UpdateConnectionAliasPermissionAsync(UpdateConnectionAliasPermissionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateConnectionAliasPermissionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateConnectionAliasPermissionResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateConnectionAliasPermissionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateRulesOfIpGroup

        internal virtual UpdateRulesOfIpGroupResponse UpdateRulesOfIpGroup(UpdateRulesOfIpGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateRulesOfIpGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateRulesOfIpGroupResponseUnmarshaller.Instance;

            return Invoke<UpdateRulesOfIpGroupResponse>(request, options);
        }



        /// <summary>
        /// Replaces the current rules of the specified IP access control group with the specified
        /// rules.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRulesOfIpGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<UpdateRulesOfIpGroupResponse> UpdateRulesOfIpGroupAsync(UpdateRulesOfIpGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateRulesOfIpGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateRulesOfIpGroupResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateRulesOfIpGroupResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateWorkspaceImagePermission

        internal virtual UpdateWorkspaceImagePermissionResponse UpdateWorkspaceImagePermission(UpdateWorkspaceImagePermissionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateWorkspaceImagePermissionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateWorkspaceImagePermissionResponseUnmarshaller.Instance;

            return Invoke<UpdateWorkspaceImagePermissionResponse>(request, options);
        }



        /// <summary>
        /// Shares or unshares an image with one account in the same AWS Region by specifying
        /// whether that account has permission to copy the image. If the copy image permission
        /// is granted, the image is shared with that account. If the copy image permission is
        /// revoked, the image is unshared with the account.
        /// 
        ///  
        /// <para>
        /// After an image has been shared, the recipient account can copy the image to other
        /// AWS Regions as needed.
        /// </para>
        ///  <note> 
        /// <para>
        /// In the China (Ningxia) Region, you can copy images only within the same Region.
        /// </para>
        ///  
        /// <para>
        /// In the AWS GovCloud (US-West) Region, to copy images to and from other AWS Regions,
        /// contact AWS Support.
        /// </para>
        ///  </note> 
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
        /// Sharing Bring Your Own License (BYOL) images across AWS accounts isn't supported at
        /// this time in the AWS GovCloud (US-West) Region. To share BYOL images across accounts
        /// in the AWS GovCloud (US-West) Region, contact AWS Support.
        /// </para>
        ///  </li> </ul> </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateWorkspaceImagePermission service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<UpdateWorkspaceImagePermissionResponse> UpdateWorkspaceImagePermissionAsync(UpdateWorkspaceImagePermissionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateWorkspaceImagePermissionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateWorkspaceImagePermissionResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateWorkspaceImagePermissionResponse>(request, options, cancellationToken);
        }

        #endregion
        
    }
}