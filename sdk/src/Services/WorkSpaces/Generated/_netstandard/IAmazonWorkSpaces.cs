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
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.WorkSpaces.Model;

#pragma warning disable CS1570
namespace Amazon.WorkSpaces
{
    /// <summary>
    /// <para>Interface for accessing WorkSpaces</para>
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
    public partial interface IAmazonWorkSpaces : IAmazonService, IDisposable
    {
#if AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        IWorkSpacesPaginatorFactory Paginators { get; }
#endif
                
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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<AcceptAccountLinkInvitationResponse> AcceptAccountLinkInvitationAsync(AcceptAccountLinkInvitationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

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
        Task<AssociateConnectionAliasResponse> AssociateConnectionAliasAsync(AssociateConnectionAliasRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  AssociateIpGroups



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
        Task<AssociateIpGroupsResponse> AssociateIpGroupsAsync(AssociateIpGroupsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  AssociateWorkspaceApplication



        /// <summary>
        /// Associates the specified application to the specified WorkSpace.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateWorkspaceApplication service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<AssociateWorkspaceApplicationResponse> AssociateWorkspaceApplicationAsync(AssociateWorkspaceApplicationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

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
        Task<AuthorizeIpRulesResponse> AuthorizeIpRulesAsync(AuthorizeIpRulesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

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
        /// Amazon Web ServicesSupport.
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
        Task<CopyWorkspaceImageResponse> CopyWorkspaceImageAsync(CopyWorkspaceImageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateAccountLinkInvitation



        /// <summary>
        /// Creates the account link invitation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAccountLinkInvitation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<CreateAccountLinkInvitationResponse> CreateAccountLinkInvitationAsync(CreateAccountLinkInvitationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<CreateConnectClientAddInResponse> CreateConnectClientAddInAsync(CreateConnectClientAddInRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateConnectionAlias



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
        Task<CreateConnectionAliasResponse> CreateConnectionAliasAsync(CreateConnectionAliasRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

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
        Task<CreateIpGroupResponse> CreateIpGroupAsync(CreateIpGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateStandbyWorkspaces



        /// <summary>
        /// Creates a standby WorkSpace in a secondary Region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateStandbyWorkspaces service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<CreateStandbyWorkspacesResponse> CreateStandbyWorkspacesAsync(CreateStandbyWorkspacesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateTags



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
        Task<CreateTagsResponse> CreateTagsAsync(CreateTagsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<CreateUpdatedWorkspaceImageResponse> CreateUpdatedWorkspaceImageAsync(CreateUpdatedWorkspaceImageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateWorkspaceBundle



        /// <summary>
        /// Creates the specified WorkSpace bundle. For more information about creating WorkSpace
        /// bundles, see <a href="https://docs.aws.amazon.com/workspaces/latest/adminguide/create-custom-bundle.html">
        /// Create a Custom WorkSpaces Image and Bundle</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateWorkspaceBundle service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<CreateWorkspaceBundleResponse> CreateWorkspaceBundleAsync(CreateWorkspaceBundleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateWorkspaceImage



        /// <summary>
        /// Creates a new WorkSpace image from an existing WorkSpace.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateWorkspaceImage service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<CreateWorkspaceImageResponse> CreateWorkspaceImageAsync(CreateWorkspaceImageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

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
        Task<CreateWorkspacesResponse> CreateWorkspacesAsync(CreateWorkspacesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateWorkspacesPool



        /// <summary>
        /// Creates a pool of WorkSpaces.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateWorkspacesPool service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<CreateWorkspacesPoolResponse> CreateWorkspacesPoolAsync(CreateWorkspacesPoolRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteAccountLinkInvitation



        /// <summary>
        /// Deletes the account link invitation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAccountLinkInvitation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DeleteAccountLinkInvitationResponse> DeleteAccountLinkInvitationAsync(DeleteAccountLinkInvitationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DeleteClientBrandingResponse> DeleteClientBrandingAsync(DeleteClientBrandingRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteConnectClientAddIn



        /// <summary>
        /// Deletes a client-add-in for Amazon Connect that is configured within a directory.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteConnectClientAddIn service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DeleteConnectClientAddInResponse> DeleteConnectClientAddInAsync(DeleteConnectClientAddInRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

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
        Task<DeleteConnectionAliasResponse> DeleteConnectionAliasAsync(DeleteConnectionAliasRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

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
        Task<DeleteIpGroupResponse> DeleteIpGroupAsync(DeleteIpGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteTags



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
        Task<DeleteTagsResponse> DeleteTagsAsync(DeleteTagsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteWorkspaceBundle



        /// <summary>
        /// Deletes the specified WorkSpace bundle. For more information about deleting WorkSpace
        /// bundles, see <a href="https://docs.aws.amazon.com/workspaces/latest/adminguide/delete_bundle.html">
        /// Delete a Custom WorkSpaces Bundle or Image</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteWorkspaceBundle service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DeleteWorkspaceBundleResponse> DeleteWorkspaceBundleAsync(DeleteWorkspaceBundleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteWorkspaceImage



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
        Task<DeleteWorkspaceImageResponse> DeleteWorkspaceImageAsync(DeleteWorkspaceImageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeployWorkspaceApplications



        /// <summary>
        /// Deploys associated applications to the specified WorkSpace
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeployWorkspaceApplications service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DeployWorkspaceApplicationsResponse> DeployWorkspaceApplicationsAsync(DeployWorkspaceApplicationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

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
        Task<DeregisterWorkspaceDirectoryResponse> DeregisterWorkspaceDirectoryAsync(DeregisterWorkspaceDirectoryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeAccount



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
        Task<DescribeAccountResponse> DescribeAccountAsync(DescribeAccountRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeAccountModifications



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
        Task<DescribeAccountModificationsResponse> DescribeAccountModificationsAsync(DescribeAccountModificationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeApplicationAssociations



        /// <summary>
        /// Describes the associations between the application and the specified associated resources.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeApplicationAssociations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DescribeApplicationAssociationsResponse> DescribeApplicationAssociationsAsync(DescribeApplicationAssociationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeApplications



        /// <summary>
        /// Describes the specified applications by filtering based on their compute types, license
        /// availability, operating systems, and owners.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeApplications service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DescribeApplicationsResponse> DescribeApplicationsAsync(DescribeApplicationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeBundleAssociations



        /// <summary>
        /// Describes the associations between the applications and the specified bundle.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeBundleAssociations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DescribeBundleAssociationsResponse> DescribeBundleAssociationsAsync(DescribeBundleAssociationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DescribeClientBrandingResponse> DescribeClientBrandingAsync(DescribeClientBrandingRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeClientProperties



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
        Task<DescribeClientPropertiesResponse> DescribeClientPropertiesAsync(DescribeClientPropertiesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeConnectClientAddIns



        /// <summary>
        /// Retrieves a list of Amazon Connect client add-ins that have been created.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeConnectClientAddIns service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DescribeConnectClientAddInsResponse> DescribeConnectClientAddInsAsync(DescribeConnectClientAddInsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeConnectionAliases



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
        Task<DescribeConnectionAliasesResponse> DescribeConnectionAliasesAsync(DescribeConnectionAliasesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeConnectionAliasPermissions



        /// <summary>
        /// Describes the permissions that the owner of a connection alias has granted to another
        /// Amazon Web Services account for the specified connection alias. For more information,
        /// see <a href="https://docs.aws.amazon.com/workspaces/latest/adminguide/cross-region-redirection.html">
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
        Task<DescribeConnectionAliasPermissionsResponse> DescribeConnectionAliasPermissionsAsync(DescribeConnectionAliasPermissionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeImageAssociations



        /// <summary>
        /// Describes the associations between the applications and the specified image.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeImageAssociations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DescribeImageAssociationsResponse> DescribeImageAssociationsAsync(DescribeImageAssociationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeIpGroups



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
        Task<DescribeIpGroupsResponse> DescribeIpGroupsAsync(DescribeIpGroupsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeTags



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
        Task<DescribeTagsResponse> DescribeTagsAsync(DescribeTagsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeWorkspaceAssociations



        /// <summary>
        /// Describes the associations betweens applications and the specified WorkSpace.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeWorkspaceAssociations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DescribeWorkspaceAssociationsResponse> DescribeWorkspaceAssociationsAsync(DescribeWorkspaceAssociationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeWorkspaceBundles service method, as returned by WorkSpaces.</returns>
        /// <exception cref="Amazon.WorkSpaces.Model.InvalidParameterValuesException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/DescribeWorkspaceBundles">REST API Reference for DescribeWorkspaceBundles Operation</seealso>
        Task<DescribeWorkspaceBundlesResponse> DescribeWorkspaceBundlesAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));


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
        Task<DescribeWorkspaceBundlesResponse> DescribeWorkspaceBundlesAsync(DescribeWorkspaceBundlesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeWorkspaceDirectories


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
        Task<DescribeWorkspaceDirectoriesResponse> DescribeWorkspaceDirectoriesAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));


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
        Task<DescribeWorkspaceDirectoriesResponse> DescribeWorkspaceDirectoriesAsync(DescribeWorkspaceDirectoriesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeWorkspaceImagePermissions



        /// <summary>
        /// Describes the permissions that the owner of an image has granted to other Amazon Web
        /// Services accounts for an image.
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
        Task<DescribeWorkspaceImagePermissionsResponse> DescribeWorkspaceImagePermissionsAsync(DescribeWorkspaceImagePermissionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeWorkspaceImages



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
        Task<DescribeWorkspaceImagesResponse> DescribeWorkspaceImagesAsync(DescribeWorkspaceImagesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

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
        Task<DescribeWorkspacesResponse> DescribeWorkspacesAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));


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
        Task<DescribeWorkspacesResponse> DescribeWorkspacesAsync(DescribeWorkspacesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeWorkspacesConnectionStatus



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
        Task<DescribeWorkspacesConnectionStatusResponse> DescribeWorkspacesConnectionStatusAsync(DescribeWorkspacesConnectionStatusRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeWorkspaceSnapshots



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
        Task<DescribeWorkspaceSnapshotsResponse> DescribeWorkspaceSnapshotsAsync(DescribeWorkspaceSnapshotsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeWorkspacesPools



        /// <summary>
        /// Describes the specified WorkSpaces Pools.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeWorkspacesPools service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DescribeWorkspacesPoolsResponse> DescribeWorkspacesPoolsAsync(DescribeWorkspacesPoolsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeWorkspacesPoolSessions



        /// <summary>
        /// Retrieves a list that describes the streaming sessions for a specified pool.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeWorkspacesPoolSessions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DescribeWorkspacesPoolSessionsResponse> DescribeWorkspacesPoolSessionsAsync(DescribeWorkspacesPoolSessionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

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
        Task<DisassociateConnectionAliasResponse> DisassociateConnectionAliasAsync(DisassociateConnectionAliasRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DisassociateIpGroups



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
        /// <exception cref="Amazon.WorkSpaces.Model.OperationNotSupportedException">
        /// This operation is not supported.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/DisassociateIpGroups">REST API Reference for DisassociateIpGroups Operation</seealso>
        Task<DisassociateIpGroupsResponse> DisassociateIpGroupsAsync(DisassociateIpGroupsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DisassociateWorkspaceApplication



        /// <summary>
        /// Disassociates the specified application from a WorkSpace.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateWorkspaceApplication service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DisassociateWorkspaceApplicationResponse> DisassociateWorkspaceApplicationAsync(DisassociateWorkspaceApplicationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetAccountLink



        /// <summary>
        /// Retrieves account link information.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAccountLink service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<GetAccountLinkResponse> GetAccountLinkAsync(GetAccountLinkRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ImportClientBrandingResponse> ImportClientBrandingAsync(ImportClientBrandingRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

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
        Task<ImportWorkspaceImageResponse> ImportWorkspaceImageAsync(ImportWorkspaceImageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListAccountLinks



        /// <summary>
        /// Lists all account links.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAccountLinks service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListAccountLinksResponse> ListAccountLinksAsync(ListAccountLinksRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

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
        Task<ListAvailableManagementCidrRangesResponse> ListAvailableManagementCidrRangesAsync(ListAvailableManagementCidrRangesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

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
        Task<MigrateWorkspaceResponse> MigrateWorkspaceAsync(MigrateWorkspaceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ModifyAccount



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
        Task<ModifyAccountResponse> ModifyAccountAsync(ModifyAccountRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ModifyCertificateBasedAuthProperties



        /// <summary>
        /// Modifies the properties of the certificate-based authentication you want to use with
        /// your WorkSpaces.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyCertificateBasedAuthProperties service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ModifyCertificateBasedAuthPropertiesResponse> ModifyCertificateBasedAuthPropertiesAsync(ModifyCertificateBasedAuthPropertiesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ModifyClientProperties



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
        /// <exception cref="Amazon.WorkSpaces.Model.OperationNotSupportedException">
        /// This operation is not supported.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/ModifyClientProperties">REST API Reference for ModifyClientProperties Operation</seealso>
        Task<ModifyClientPropertiesResponse> ModifyClientPropertiesAsync(ModifyClientPropertiesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ModifyEndpointEncryptionMode



        /// <summary>
        /// Modifies the endpoint encryption mode that allows you to configure the specified directory
        /// between Standard TLS and FIPS 140-2 validated mode.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyEndpointEncryptionMode service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ModifyEndpointEncryptionModeResponse> ModifyEndpointEncryptionModeAsync(ModifyEndpointEncryptionModeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ModifySamlProperties



        /// <summary>
        /// Modifies multiple properties related to SAML 2.0 authentication, including the enablement
        /// status, user access URL, and relay state parameter name that are used for configuring
        /// federation with an SAML 2.0 identity provider.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifySamlProperties service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ModifySamlPropertiesResponse> ModifySamlPropertiesAsync(ModifySamlPropertiesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ModifySelfservicePermissions



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
        /// <exception cref="Amazon.WorkSpaces.Model.OperationNotSupportedException">
        /// This operation is not supported.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/ModifySelfservicePermissions">REST API Reference for ModifySelfservicePermissions Operation</seealso>
        Task<ModifySelfservicePermissionsResponse> ModifySelfservicePermissionsAsync(ModifySelfservicePermissionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ModifyStreamingProperties



        /// <summary>
        /// Modifies the specified streaming properties.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyStreamingProperties service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ModifyStreamingPropertiesResponse> ModifyStreamingPropertiesAsync(ModifyStreamingPropertiesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ModifyWorkspaceAccessProperties



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
        Task<ModifyWorkspaceAccessPropertiesResponse> ModifyWorkspaceAccessPropertiesAsync(ModifyWorkspaceAccessPropertiesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ModifyWorkspaceCreationProperties



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
        Task<ModifyWorkspaceCreationPropertiesResponse> ModifyWorkspaceCreationPropertiesAsync(ModifyWorkspaceCreationPropertiesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

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
        Task<ModifyWorkspacePropertiesResponse> ModifyWorkspacePropertiesAsync(ModifyWorkspacePropertiesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

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
        /// <exception cref="Amazon.WorkSpaces.Model.OperationNotSupportedException">
        /// This operation is not supported.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/ModifyWorkspaceState">REST API Reference for ModifyWorkspaceState Operation</seealso>
        Task<ModifyWorkspaceStateResponse> ModifyWorkspaceStateAsync(ModifyWorkspaceStateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RebootWorkspaces service method, as returned by WorkSpaces.</returns>
        /// <exception cref="Amazon.WorkSpaces.Model.OperationNotSupportedException">
        /// This operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/RebootWorkspaces">REST API Reference for RebootWorkspaces Operation</seealso>
        Task<RebootWorkspacesResponse> RebootWorkspacesAsync(RebootWorkspacesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RebuildWorkspaces service method, as returned by WorkSpaces.</returns>
        /// <exception cref="Amazon.WorkSpaces.Model.OperationNotSupportedException">
        /// This operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/RebuildWorkspaces">REST API Reference for RebuildWorkspaces Operation</seealso>
        Task<RebuildWorkspacesResponse> RebuildWorkspacesAsync(RebuildWorkspacesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

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
        Task<RegisterWorkspaceDirectoryResponse> RegisterWorkspaceDirectoryAsync(RegisterWorkspaceDirectoryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  RejectAccountLinkInvitation



        /// <summary>
        /// Rejects the account link invitation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RejectAccountLinkInvitation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<RejectAccountLinkInvitationResponse> RejectAccountLinkInvitationAsync(RejectAccountLinkInvitationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

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
        /// <exception cref="Amazon.WorkSpaces.Model.OperationNotSupportedException">
        /// This operation is not supported.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/RestoreWorkspace">REST API Reference for RestoreWorkspace Operation</seealso>
        Task<RestoreWorkspaceResponse> RestoreWorkspaceAsync(RestoreWorkspaceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  RevokeIpRules



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
        Task<RevokeIpRulesResponse> RevokeIpRulesAsync(RevokeIpRulesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartWorkspaces service method, as returned by WorkSpaces.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/StartWorkspaces">REST API Reference for StartWorkspaces Operation</seealso>
        Task<StartWorkspacesResponse> StartWorkspacesAsync(StartWorkspacesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<StartWorkspacesPoolResponse> StartWorkspacesPoolAsync(StartWorkspacesPoolRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StopWorkspaces service method, as returned by WorkSpaces.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/StopWorkspaces">REST API Reference for StopWorkspaces Operation</seealso>
        Task<StopWorkspacesResponse> StopWorkspacesAsync(StopWorkspacesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<StopWorkspacesPoolResponse> StopWorkspacesPoolAsync(StopWorkspacesPoolRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  TerminateWorkspaces



        /// <summary>
        /// Terminates the specified WorkSpaces.
        /// 
        ///  <important> 
        /// <para>
        /// Terminating a WorkSpace is a permanent action and cannot be undone. The user's data
        /// is destroyed. If you need to archive any user data, contact Amazon Web ServicesSupport
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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TerminateWorkspaces service method, as returned by WorkSpaces.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/TerminateWorkspaces">REST API Reference for TerminateWorkspaces Operation</seealso>
        Task<TerminateWorkspacesResponse> TerminateWorkspacesAsync(TerminateWorkspacesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  TerminateWorkspacesPool



        /// <summary>
        /// Terminates the specified pool.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TerminateWorkspacesPool service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<TerminateWorkspacesPoolResponse> TerminateWorkspacesPoolAsync(TerminateWorkspacesPoolRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  TerminateWorkspacesPoolSession



        /// <summary>
        /// Terminates the pool session.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TerminateWorkspacesPoolSession service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<TerminateWorkspacesPoolSessionResponse> TerminateWorkspacesPoolSessionAsync(TerminateWorkspacesPoolSessionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateConnectClientAddIn



        /// <summary>
        /// Updates a Amazon Connect client add-in. Use this action to update the name and endpoint
        /// URL of a Amazon Connect client add-in.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateConnectClientAddIn service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<UpdateConnectClientAddInResponse> UpdateConnectClientAddInAsync(UpdateConnectClientAddInRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

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
        Task<UpdateConnectionAliasPermissionResponse> UpdateConnectionAliasPermissionAsync(UpdateConnectionAliasPermissionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateRulesOfIpGroup



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
        Task<UpdateRulesOfIpGroupResponse> UpdateRulesOfIpGroupAsync(UpdateRulesOfIpGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<UpdateWorkspaceBundleResponse> UpdateWorkspaceBundleAsync(UpdateWorkspaceBundleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

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
        /// Amazon Web ServicesSupport.
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
        /// across accounts in Amazon Web Services GovCloud (US), contact Amazon Web ServicesSupport.
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
        Task<UpdateWorkspaceImagePermissionResponse> UpdateWorkspaceImagePermissionAsync(UpdateWorkspaceImagePermissionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateWorkspacesPool



        /// <summary>
        /// Updates the specified pool.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateWorkspacesPool service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<UpdateWorkspacesPoolResponse> UpdateWorkspacesPoolAsync(UpdateWorkspacesPoolRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region DetermineServiceOperationEndpoint

        /// <summary>
        /// Returns the endpoint that will be used for a particular request.
        /// </summary>
        /// <param name="request">Request for the desired service operation.</param>
        /// <returns>The resolved endpoint for the given request.</returns>
        Amazon.Runtime.Endpoints.Endpoint DetermineServiceOperationEndpoint(AmazonWebServiceRequest request);
        
        #endregion

        #region Static factory interface methods
#if NET8_0_OR_GREATER
// Warning CA1033 is issued when the child types can not call the method defined in parent types.
// In this use case the intended caller is only meant to be the interface as a factory
// method to create the child types. Given the SDK use case the warning can be ignored.
#pragma warning disable CA1033
        /// <inheritdoc/>
        [System.Diagnostics.CodeAnalysis.DynamicDependency(System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypes.PublicProperties, typeof(AmazonWorkSpacesConfig))]
        static ClientConfig IAmazonService.CreateDefaultClientConfig() => new AmazonWorkSpacesConfig();

        /// <inheritdoc/>
        [System.Diagnostics.CodeAnalysis.UnconditionalSuppressMessage("AssemblyLoadTrimming", "IL2026:RequiresUnreferencedCode",
    Justification = "This suppression is here to ignore the warnings caused by CognitoSync. See justification in IAmazonService.")]
        static IAmazonService IAmazonService.CreateDefaultServiceClient(AWSCredentials awsCredentials, ClientConfig clientConfig)
        {
            var serviceClientConfig = clientConfig as AmazonWorkSpacesConfig;
            if (serviceClientConfig == null)
            {
                throw new AmazonClientException("ClientConfig is not of type AmazonWorkSpacesConfig to create AmazonWorkSpacesClient");
            }

            return awsCredentials == null ? 
                    new AmazonWorkSpacesClient(serviceClientConfig) :
                    new AmazonWorkSpacesClient(awsCredentials, serviceClientConfig);
        }
#pragma warning restore CA1033
#endif
        #endregion
    }
}