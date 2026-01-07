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


#if BCL45 || AWS_ASYNC_ENUMERABLES_API
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
        AcceptAccountLinkInvitationResponse AcceptAccountLinkInvitation(AcceptAccountLinkInvitationRequest request);

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
        IAsyncResult BeginAcceptAccountLinkInvitation(AcceptAccountLinkInvitationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  AcceptAccountLinkInvitation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAcceptAccountLinkInvitation.</param>
        /// 
        /// <returns>Returns a  AcceptAccountLinkInvitationResult from WorkSpaces.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/AcceptAccountLinkInvitation">REST API Reference for AcceptAccountLinkInvitation Operation</seealso>
        AcceptAccountLinkInvitationResponse EndAcceptAccountLinkInvitation(IAsyncResult asyncResult);

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
        AssociateConnectionAliasResponse AssociateConnectionAlias(AssociateConnectionAliasRequest request);

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
        IAsyncResult BeginAssociateConnectionAlias(AssociateConnectionAliasRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  AssociateConnectionAlias operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssociateConnectionAlias.</param>
        /// 
        /// <returns>Returns a  AssociateConnectionAliasResult from WorkSpaces.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/AssociateConnectionAlias">REST API Reference for AssociateConnectionAlias Operation</seealso>
        AssociateConnectionAliasResponse EndAssociateConnectionAlias(IAsyncResult asyncResult);

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
        AssociateIpGroupsResponse AssociateIpGroups(AssociateIpGroupsRequest request);

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
        IAsyncResult BeginAssociateIpGroups(AssociateIpGroupsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  AssociateIpGroups operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssociateIpGroups.</param>
        /// 
        /// <returns>Returns a  AssociateIpGroupsResult from WorkSpaces.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/AssociateIpGroups">REST API Reference for AssociateIpGroups Operation</seealso>
        AssociateIpGroupsResponse EndAssociateIpGroups(IAsyncResult asyncResult);

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
        AssociateWorkspaceApplicationResponse AssociateWorkspaceApplication(AssociateWorkspaceApplicationRequest request);

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
        IAsyncResult BeginAssociateWorkspaceApplication(AssociateWorkspaceApplicationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  AssociateWorkspaceApplication operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssociateWorkspaceApplication.</param>
        /// 
        /// <returns>Returns a  AssociateWorkspaceApplicationResult from WorkSpaces.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/AssociateWorkspaceApplication">REST API Reference for AssociateWorkspaceApplication Operation</seealso>
        AssociateWorkspaceApplicationResponse EndAssociateWorkspaceApplication(IAsyncResult asyncResult);

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
        AuthorizeIpRulesResponse AuthorizeIpRules(AuthorizeIpRulesRequest request);

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
        IAsyncResult BeginAuthorizeIpRules(AuthorizeIpRulesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  AuthorizeIpRules operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAuthorizeIpRules.</param>
        /// 
        /// <returns>Returns a  AuthorizeIpRulesResult from WorkSpaces.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/AuthorizeIpRules">REST API Reference for AuthorizeIpRules Operation</seealso>
        AuthorizeIpRulesResponse EndAuthorizeIpRules(IAsyncResult asyncResult);

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
        CopyWorkspaceImageResponse CopyWorkspaceImage(CopyWorkspaceImageRequest request);

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
        IAsyncResult BeginCopyWorkspaceImage(CopyWorkspaceImageRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CopyWorkspaceImage operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCopyWorkspaceImage.</param>
        /// 
        /// <returns>Returns a  CopyWorkspaceImageResult from WorkSpaces.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/CopyWorkspaceImage">REST API Reference for CopyWorkspaceImage Operation</seealso>
        CopyWorkspaceImageResponse EndCopyWorkspaceImage(IAsyncResult asyncResult);

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
        CreateAccountLinkInvitationResponse CreateAccountLinkInvitation(CreateAccountLinkInvitationRequest request);

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
        IAsyncResult BeginCreateAccountLinkInvitation(CreateAccountLinkInvitationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateAccountLinkInvitation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateAccountLinkInvitation.</param>
        /// 
        /// <returns>Returns a  CreateAccountLinkInvitationResult from WorkSpaces.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/CreateAccountLinkInvitation">REST API Reference for CreateAccountLinkInvitation Operation</seealso>
        CreateAccountLinkInvitationResponse EndCreateAccountLinkInvitation(IAsyncResult asyncResult);

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
        CreateConnectClientAddInResponse CreateConnectClientAddIn(CreateConnectClientAddInRequest request);

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
        IAsyncResult BeginCreateConnectClientAddIn(CreateConnectClientAddInRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateConnectClientAddIn operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateConnectClientAddIn.</param>
        /// 
        /// <returns>Returns a  CreateConnectClientAddInResult from WorkSpaces.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/CreateConnectClientAddIn">REST API Reference for CreateConnectClientAddIn Operation</seealso>
        CreateConnectClientAddInResponse EndCreateConnectClientAddIn(IAsyncResult asyncResult);

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
        CreateConnectionAliasResponse CreateConnectionAlias(CreateConnectionAliasRequest request);

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
        IAsyncResult BeginCreateConnectionAlias(CreateConnectionAliasRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateConnectionAlias operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateConnectionAlias.</param>
        /// 
        /// <returns>Returns a  CreateConnectionAliasResult from WorkSpaces.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/CreateConnectionAlias">REST API Reference for CreateConnectionAlias Operation</seealso>
        CreateConnectionAliasResponse EndCreateConnectionAlias(IAsyncResult asyncResult);

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
        CreateIpGroupResponse CreateIpGroup(CreateIpGroupRequest request);

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
        IAsyncResult BeginCreateIpGroup(CreateIpGroupRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateIpGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateIpGroup.</param>
        /// 
        /// <returns>Returns a  CreateIpGroupResult from WorkSpaces.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/CreateIpGroup">REST API Reference for CreateIpGroup Operation</seealso>
        CreateIpGroupResponse EndCreateIpGroup(IAsyncResult asyncResult);

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
        CreateStandbyWorkspacesResponse CreateStandbyWorkspaces(CreateStandbyWorkspacesRequest request);

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
        IAsyncResult BeginCreateStandbyWorkspaces(CreateStandbyWorkspacesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateStandbyWorkspaces operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateStandbyWorkspaces.</param>
        /// 
        /// <returns>Returns a  CreateStandbyWorkspacesResult from WorkSpaces.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/CreateStandbyWorkspaces">REST API Reference for CreateStandbyWorkspaces Operation</seealso>
        CreateStandbyWorkspacesResponse EndCreateStandbyWorkspaces(IAsyncResult asyncResult);

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
        CreateTagsResponse CreateTags(CreateTagsRequest request);

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
        IAsyncResult BeginCreateTags(CreateTagsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateTags operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateTags.</param>
        /// 
        /// <returns>Returns a  CreateTagsResult from WorkSpaces.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/CreateTags">REST API Reference for CreateTags Operation</seealso>
        CreateTagsResponse EndCreateTags(IAsyncResult asyncResult);

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
        CreateUpdatedWorkspaceImageResponse CreateUpdatedWorkspaceImage(CreateUpdatedWorkspaceImageRequest request);

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
        IAsyncResult BeginCreateUpdatedWorkspaceImage(CreateUpdatedWorkspaceImageRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateUpdatedWorkspaceImage operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateUpdatedWorkspaceImage.</param>
        /// 
        /// <returns>Returns a  CreateUpdatedWorkspaceImageResult from WorkSpaces.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/CreateUpdatedWorkspaceImage">REST API Reference for CreateUpdatedWorkspaceImage Operation</seealso>
        CreateUpdatedWorkspaceImageResponse EndCreateUpdatedWorkspaceImage(IAsyncResult asyncResult);

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
        CreateWorkspaceBundleResponse CreateWorkspaceBundle(CreateWorkspaceBundleRequest request);

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
        IAsyncResult BeginCreateWorkspaceBundle(CreateWorkspaceBundleRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateWorkspaceBundle operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateWorkspaceBundle.</param>
        /// 
        /// <returns>Returns a  CreateWorkspaceBundleResult from WorkSpaces.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/CreateWorkspaceBundle">REST API Reference for CreateWorkspaceBundle Operation</seealso>
        CreateWorkspaceBundleResponse EndCreateWorkspaceBundle(IAsyncResult asyncResult);

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
        CreateWorkspaceImageResponse CreateWorkspaceImage(CreateWorkspaceImageRequest request);

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
        IAsyncResult BeginCreateWorkspaceImage(CreateWorkspaceImageRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateWorkspaceImage operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateWorkspaceImage.</param>
        /// 
        /// <returns>Returns a  CreateWorkspaceImageResult from WorkSpaces.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/CreateWorkspaceImage">REST API Reference for CreateWorkspaceImage Operation</seealso>
        CreateWorkspaceImageResponse EndCreateWorkspaceImage(IAsyncResult asyncResult);

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
        CreateWorkspacesResponse CreateWorkspaces(CreateWorkspacesRequest request);

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
        IAsyncResult BeginCreateWorkspaces(CreateWorkspacesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateWorkspaces operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateWorkspaces.</param>
        /// 
        /// <returns>Returns a  CreateWorkspacesResult from WorkSpaces.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/CreateWorkspaces">REST API Reference for CreateWorkspaces Operation</seealso>
        CreateWorkspacesResponse EndCreateWorkspaces(IAsyncResult asyncResult);

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
        CreateWorkspacesPoolResponse CreateWorkspacesPool(CreateWorkspacesPoolRequest request);

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
        IAsyncResult BeginCreateWorkspacesPool(CreateWorkspacesPoolRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateWorkspacesPool operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateWorkspacesPool.</param>
        /// 
        /// <returns>Returns a  CreateWorkspacesPoolResult from WorkSpaces.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/CreateWorkspacesPool">REST API Reference for CreateWorkspacesPool Operation</seealso>
        CreateWorkspacesPoolResponse EndCreateWorkspacesPool(IAsyncResult asyncResult);

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
        DeleteAccountLinkInvitationResponse DeleteAccountLinkInvitation(DeleteAccountLinkInvitationRequest request);

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
        IAsyncResult BeginDeleteAccountLinkInvitation(DeleteAccountLinkInvitationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteAccountLinkInvitation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteAccountLinkInvitation.</param>
        /// 
        /// <returns>Returns a  DeleteAccountLinkInvitationResult from WorkSpaces.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/DeleteAccountLinkInvitation">REST API Reference for DeleteAccountLinkInvitation Operation</seealso>
        DeleteAccountLinkInvitationResponse EndDeleteAccountLinkInvitation(IAsyncResult asyncResult);

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
        DeleteClientBrandingResponse DeleteClientBranding(DeleteClientBrandingRequest request);

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
        IAsyncResult BeginDeleteClientBranding(DeleteClientBrandingRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteClientBranding operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteClientBranding.</param>
        /// 
        /// <returns>Returns a  DeleteClientBrandingResult from WorkSpaces.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/DeleteClientBranding">REST API Reference for DeleteClientBranding Operation</seealso>
        DeleteClientBrandingResponse EndDeleteClientBranding(IAsyncResult asyncResult);

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
        DeleteConnectClientAddInResponse DeleteConnectClientAddIn(DeleteConnectClientAddInRequest request);

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
        IAsyncResult BeginDeleteConnectClientAddIn(DeleteConnectClientAddInRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteConnectClientAddIn operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteConnectClientAddIn.</param>
        /// 
        /// <returns>Returns a  DeleteConnectClientAddInResult from WorkSpaces.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/DeleteConnectClientAddIn">REST API Reference for DeleteConnectClientAddIn Operation</seealso>
        DeleteConnectClientAddInResponse EndDeleteConnectClientAddIn(IAsyncResult asyncResult);

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
        DeleteConnectionAliasResponse DeleteConnectionAlias(DeleteConnectionAliasRequest request);

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
        IAsyncResult BeginDeleteConnectionAlias(DeleteConnectionAliasRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteConnectionAlias operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteConnectionAlias.</param>
        /// 
        /// <returns>Returns a  DeleteConnectionAliasResult from WorkSpaces.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/DeleteConnectionAlias">REST API Reference for DeleteConnectionAlias Operation</seealso>
        DeleteConnectionAliasResponse EndDeleteConnectionAlias(IAsyncResult asyncResult);

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
        DeleteIpGroupResponse DeleteIpGroup(DeleteIpGroupRequest request);

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
        IAsyncResult BeginDeleteIpGroup(DeleteIpGroupRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteIpGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteIpGroup.</param>
        /// 
        /// <returns>Returns a  DeleteIpGroupResult from WorkSpaces.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/DeleteIpGroup">REST API Reference for DeleteIpGroup Operation</seealso>
        DeleteIpGroupResponse EndDeleteIpGroup(IAsyncResult asyncResult);

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
        DeleteTagsResponse DeleteTags(DeleteTagsRequest request);

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
        IAsyncResult BeginDeleteTags(DeleteTagsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteTags operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteTags.</param>
        /// 
        /// <returns>Returns a  DeleteTagsResult from WorkSpaces.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/DeleteTags">REST API Reference for DeleteTags Operation</seealso>
        DeleteTagsResponse EndDeleteTags(IAsyncResult asyncResult);

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
        DeleteWorkspaceBundleResponse DeleteWorkspaceBundle(DeleteWorkspaceBundleRequest request);

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
        IAsyncResult BeginDeleteWorkspaceBundle(DeleteWorkspaceBundleRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteWorkspaceBundle operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteWorkspaceBundle.</param>
        /// 
        /// <returns>Returns a  DeleteWorkspaceBundleResult from WorkSpaces.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/DeleteWorkspaceBundle">REST API Reference for DeleteWorkspaceBundle Operation</seealso>
        DeleteWorkspaceBundleResponse EndDeleteWorkspaceBundle(IAsyncResult asyncResult);

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
        DeleteWorkspaceImageResponse DeleteWorkspaceImage(DeleteWorkspaceImageRequest request);

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
        IAsyncResult BeginDeleteWorkspaceImage(DeleteWorkspaceImageRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteWorkspaceImage operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteWorkspaceImage.</param>
        /// 
        /// <returns>Returns a  DeleteWorkspaceImageResult from WorkSpaces.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/DeleteWorkspaceImage">REST API Reference for DeleteWorkspaceImage Operation</seealso>
        DeleteWorkspaceImageResponse EndDeleteWorkspaceImage(IAsyncResult asyncResult);

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
        DeployWorkspaceApplicationsResponse DeployWorkspaceApplications(DeployWorkspaceApplicationsRequest request);

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
        IAsyncResult BeginDeployWorkspaceApplications(DeployWorkspaceApplicationsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeployWorkspaceApplications operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeployWorkspaceApplications.</param>
        /// 
        /// <returns>Returns a  DeployWorkspaceApplicationsResult from WorkSpaces.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/DeployWorkspaceApplications">REST API Reference for DeployWorkspaceApplications Operation</seealso>
        DeployWorkspaceApplicationsResponse EndDeployWorkspaceApplications(IAsyncResult asyncResult);

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
        DeregisterWorkspaceDirectoryResponse DeregisterWorkspaceDirectory(DeregisterWorkspaceDirectoryRequest request);

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
        IAsyncResult BeginDeregisterWorkspaceDirectory(DeregisterWorkspaceDirectoryRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeregisterWorkspaceDirectory operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeregisterWorkspaceDirectory.</param>
        /// 
        /// <returns>Returns a  DeregisterWorkspaceDirectoryResult from WorkSpaces.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/DeregisterWorkspaceDirectory">REST API Reference for DeregisterWorkspaceDirectory Operation</seealso>
        DeregisterWorkspaceDirectoryResponse EndDeregisterWorkspaceDirectory(IAsyncResult asyncResult);

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
        DescribeAccountResponse DescribeAccount(DescribeAccountRequest request);

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
        IAsyncResult BeginDescribeAccount(DescribeAccountRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeAccount operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeAccount.</param>
        /// 
        /// <returns>Returns a  DescribeAccountResult from WorkSpaces.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/DescribeAccount">REST API Reference for DescribeAccount Operation</seealso>
        DescribeAccountResponse EndDescribeAccount(IAsyncResult asyncResult);

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
        DescribeAccountModificationsResponse DescribeAccountModifications(DescribeAccountModificationsRequest request);

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
        IAsyncResult BeginDescribeAccountModifications(DescribeAccountModificationsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeAccountModifications operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeAccountModifications.</param>
        /// 
        /// <returns>Returns a  DescribeAccountModificationsResult from WorkSpaces.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/DescribeAccountModifications">REST API Reference for DescribeAccountModifications Operation</seealso>
        DescribeAccountModificationsResponse EndDescribeAccountModifications(IAsyncResult asyncResult);

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
        DescribeApplicationAssociationsResponse DescribeApplicationAssociations(DescribeApplicationAssociationsRequest request);

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
        IAsyncResult BeginDescribeApplicationAssociations(DescribeApplicationAssociationsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeApplicationAssociations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeApplicationAssociations.</param>
        /// 
        /// <returns>Returns a  DescribeApplicationAssociationsResult from WorkSpaces.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/DescribeApplicationAssociations">REST API Reference for DescribeApplicationAssociations Operation</seealso>
        DescribeApplicationAssociationsResponse EndDescribeApplicationAssociations(IAsyncResult asyncResult);

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
        DescribeApplicationsResponse DescribeApplications(DescribeApplicationsRequest request);

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
        IAsyncResult BeginDescribeApplications(DescribeApplicationsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeApplications operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeApplications.</param>
        /// 
        /// <returns>Returns a  DescribeApplicationsResult from WorkSpaces.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/DescribeApplications">REST API Reference for DescribeApplications Operation</seealso>
        DescribeApplicationsResponse EndDescribeApplications(IAsyncResult asyncResult);

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
        DescribeBundleAssociationsResponse DescribeBundleAssociations(DescribeBundleAssociationsRequest request);

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
        IAsyncResult BeginDescribeBundleAssociations(DescribeBundleAssociationsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeBundleAssociations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeBundleAssociations.</param>
        /// 
        /// <returns>Returns a  DescribeBundleAssociationsResult from WorkSpaces.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/DescribeBundleAssociations">REST API Reference for DescribeBundleAssociations Operation</seealso>
        DescribeBundleAssociationsResponse EndDescribeBundleAssociations(IAsyncResult asyncResult);

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
        DescribeClientBrandingResponse DescribeClientBranding(DescribeClientBrandingRequest request);

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
        IAsyncResult BeginDescribeClientBranding(DescribeClientBrandingRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeClientBranding operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeClientBranding.</param>
        /// 
        /// <returns>Returns a  DescribeClientBrandingResult from WorkSpaces.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/DescribeClientBranding">REST API Reference for DescribeClientBranding Operation</seealso>
        DescribeClientBrandingResponse EndDescribeClientBranding(IAsyncResult asyncResult);

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
        DescribeClientPropertiesResponse DescribeClientProperties(DescribeClientPropertiesRequest request);

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
        IAsyncResult BeginDescribeClientProperties(DescribeClientPropertiesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeClientProperties operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeClientProperties.</param>
        /// 
        /// <returns>Returns a  DescribeClientPropertiesResult from WorkSpaces.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/DescribeClientProperties">REST API Reference for DescribeClientProperties Operation</seealso>
        DescribeClientPropertiesResponse EndDescribeClientProperties(IAsyncResult asyncResult);

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
        DescribeConnectClientAddInsResponse DescribeConnectClientAddIns(DescribeConnectClientAddInsRequest request);

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
        IAsyncResult BeginDescribeConnectClientAddIns(DescribeConnectClientAddInsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeConnectClientAddIns operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeConnectClientAddIns.</param>
        /// 
        /// <returns>Returns a  DescribeConnectClientAddInsResult from WorkSpaces.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/DescribeConnectClientAddIns">REST API Reference for DescribeConnectClientAddIns Operation</seealso>
        DescribeConnectClientAddInsResponse EndDescribeConnectClientAddIns(IAsyncResult asyncResult);

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
        DescribeConnectionAliasesResponse DescribeConnectionAliases(DescribeConnectionAliasesRequest request);

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
        IAsyncResult BeginDescribeConnectionAliases(DescribeConnectionAliasesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeConnectionAliases operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeConnectionAliases.</param>
        /// 
        /// <returns>Returns a  DescribeConnectionAliasesResult from WorkSpaces.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/DescribeConnectionAliases">REST API Reference for DescribeConnectionAliases Operation</seealso>
        DescribeConnectionAliasesResponse EndDescribeConnectionAliases(IAsyncResult asyncResult);

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
        DescribeConnectionAliasPermissionsResponse DescribeConnectionAliasPermissions(DescribeConnectionAliasPermissionsRequest request);

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
        IAsyncResult BeginDescribeConnectionAliasPermissions(DescribeConnectionAliasPermissionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeConnectionAliasPermissions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeConnectionAliasPermissions.</param>
        /// 
        /// <returns>Returns a  DescribeConnectionAliasPermissionsResult from WorkSpaces.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/DescribeConnectionAliasPermissions">REST API Reference for DescribeConnectionAliasPermissions Operation</seealso>
        DescribeConnectionAliasPermissionsResponse EndDescribeConnectionAliasPermissions(IAsyncResult asyncResult);

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
        DescribeCustomWorkspaceImageImportResponse DescribeCustomWorkspaceImageImport(DescribeCustomWorkspaceImageImportRequest request);

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
        IAsyncResult BeginDescribeCustomWorkspaceImageImport(DescribeCustomWorkspaceImageImportRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeCustomWorkspaceImageImport operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeCustomWorkspaceImageImport.</param>
        /// 
        /// <returns>Returns a  DescribeCustomWorkspaceImageImportResult from WorkSpaces.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/DescribeCustomWorkspaceImageImport">REST API Reference for DescribeCustomWorkspaceImageImport Operation</seealso>
        DescribeCustomWorkspaceImageImportResponse EndDescribeCustomWorkspaceImageImport(IAsyncResult asyncResult);

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
        DescribeImageAssociationsResponse DescribeImageAssociations(DescribeImageAssociationsRequest request);

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
        IAsyncResult BeginDescribeImageAssociations(DescribeImageAssociationsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeImageAssociations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeImageAssociations.</param>
        /// 
        /// <returns>Returns a  DescribeImageAssociationsResult from WorkSpaces.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/DescribeImageAssociations">REST API Reference for DescribeImageAssociations Operation</seealso>
        DescribeImageAssociationsResponse EndDescribeImageAssociations(IAsyncResult asyncResult);

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
        DescribeIpGroupsResponse DescribeIpGroups(DescribeIpGroupsRequest request);

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
        IAsyncResult BeginDescribeIpGroups(DescribeIpGroupsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeIpGroups operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeIpGroups.</param>
        /// 
        /// <returns>Returns a  DescribeIpGroupsResult from WorkSpaces.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/DescribeIpGroups">REST API Reference for DescribeIpGroups Operation</seealso>
        DescribeIpGroupsResponse EndDescribeIpGroups(IAsyncResult asyncResult);

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
        DescribeTagsResponse DescribeTags(DescribeTagsRequest request);

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
        IAsyncResult BeginDescribeTags(DescribeTagsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeTags operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeTags.</param>
        /// 
        /// <returns>Returns a  DescribeTagsResult from WorkSpaces.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/DescribeTags">REST API Reference for DescribeTags Operation</seealso>
        DescribeTagsResponse EndDescribeTags(IAsyncResult asyncResult);

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
        DescribeWorkspaceAssociationsResponse DescribeWorkspaceAssociations(DescribeWorkspaceAssociationsRequest request);

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
        IAsyncResult BeginDescribeWorkspaceAssociations(DescribeWorkspaceAssociationsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeWorkspaceAssociations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeWorkspaceAssociations.</param>
        /// 
        /// <returns>Returns a  DescribeWorkspaceAssociationsResult from WorkSpaces.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/DescribeWorkspaceAssociations">REST API Reference for DescribeWorkspaceAssociations Operation</seealso>
        DescribeWorkspaceAssociationsResponse EndDescribeWorkspaceAssociations(IAsyncResult asyncResult);

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
        DescribeWorkspaceBundlesResponse DescribeWorkspaceBundles();

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
        DescribeWorkspaceBundlesResponse DescribeWorkspaceBundles(DescribeWorkspaceBundlesRequest request);

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
        IAsyncResult BeginDescribeWorkspaceBundles(DescribeWorkspaceBundlesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeWorkspaceBundles operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeWorkspaceBundles.</param>
        /// 
        /// <returns>Returns a  DescribeWorkspaceBundlesResult from WorkSpaces.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/DescribeWorkspaceBundles">REST API Reference for DescribeWorkspaceBundles Operation</seealso>
        DescribeWorkspaceBundlesResponse EndDescribeWorkspaceBundles(IAsyncResult asyncResult);

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
        DescribeWorkspaceDirectoriesResponse DescribeWorkspaceDirectories();

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
        DescribeWorkspaceDirectoriesResponse DescribeWorkspaceDirectories(DescribeWorkspaceDirectoriesRequest request);

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
        IAsyncResult BeginDescribeWorkspaceDirectories(DescribeWorkspaceDirectoriesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeWorkspaceDirectories operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeWorkspaceDirectories.</param>
        /// 
        /// <returns>Returns a  DescribeWorkspaceDirectoriesResult from WorkSpaces.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/DescribeWorkspaceDirectories">REST API Reference for DescribeWorkspaceDirectories Operation</seealso>
        DescribeWorkspaceDirectoriesResponse EndDescribeWorkspaceDirectories(IAsyncResult asyncResult);

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
        DescribeWorkspaceImagePermissionsResponse DescribeWorkspaceImagePermissions(DescribeWorkspaceImagePermissionsRequest request);

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
        IAsyncResult BeginDescribeWorkspaceImagePermissions(DescribeWorkspaceImagePermissionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeWorkspaceImagePermissions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeWorkspaceImagePermissions.</param>
        /// 
        /// <returns>Returns a  DescribeWorkspaceImagePermissionsResult from WorkSpaces.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/DescribeWorkspaceImagePermissions">REST API Reference for DescribeWorkspaceImagePermissions Operation</seealso>
        DescribeWorkspaceImagePermissionsResponse EndDescribeWorkspaceImagePermissions(IAsyncResult asyncResult);

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
        DescribeWorkspaceImagesResponse DescribeWorkspaceImages(DescribeWorkspaceImagesRequest request);

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
        IAsyncResult BeginDescribeWorkspaceImages(DescribeWorkspaceImagesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeWorkspaceImages operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeWorkspaceImages.</param>
        /// 
        /// <returns>Returns a  DescribeWorkspaceImagesResult from WorkSpaces.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/DescribeWorkspaceImages">REST API Reference for DescribeWorkspaceImages Operation</seealso>
        DescribeWorkspaceImagesResponse EndDescribeWorkspaceImages(IAsyncResult asyncResult);

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
        DescribeWorkspacesResponse DescribeWorkspaces();

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
        DescribeWorkspacesResponse DescribeWorkspaces(DescribeWorkspacesRequest request);

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
        IAsyncResult BeginDescribeWorkspaces(DescribeWorkspacesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeWorkspaces operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeWorkspaces.</param>
        /// 
        /// <returns>Returns a  DescribeWorkspacesResult from WorkSpaces.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/DescribeWorkspaces">REST API Reference for DescribeWorkspaces Operation</seealso>
        DescribeWorkspacesResponse EndDescribeWorkspaces(IAsyncResult asyncResult);

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
        DescribeWorkspacesConnectionStatusResponse DescribeWorkspacesConnectionStatus(DescribeWorkspacesConnectionStatusRequest request);

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
        IAsyncResult BeginDescribeWorkspacesConnectionStatus(DescribeWorkspacesConnectionStatusRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeWorkspacesConnectionStatus operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeWorkspacesConnectionStatus.</param>
        /// 
        /// <returns>Returns a  DescribeWorkspacesConnectionStatusResult from WorkSpaces.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/DescribeWorkspacesConnectionStatus">REST API Reference for DescribeWorkspacesConnectionStatus Operation</seealso>
        DescribeWorkspacesConnectionStatusResponse EndDescribeWorkspacesConnectionStatus(IAsyncResult asyncResult);

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
        DescribeWorkspaceSnapshotsResponse DescribeWorkspaceSnapshots(DescribeWorkspaceSnapshotsRequest request);

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
        IAsyncResult BeginDescribeWorkspaceSnapshots(DescribeWorkspaceSnapshotsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeWorkspaceSnapshots operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeWorkspaceSnapshots.</param>
        /// 
        /// <returns>Returns a  DescribeWorkspaceSnapshotsResult from WorkSpaces.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/DescribeWorkspaceSnapshots">REST API Reference for DescribeWorkspaceSnapshots Operation</seealso>
        DescribeWorkspaceSnapshotsResponse EndDescribeWorkspaceSnapshots(IAsyncResult asyncResult);

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
        DescribeWorkspacesPoolsResponse DescribeWorkspacesPools(DescribeWorkspacesPoolsRequest request);

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
        IAsyncResult BeginDescribeWorkspacesPools(DescribeWorkspacesPoolsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeWorkspacesPools operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeWorkspacesPools.</param>
        /// 
        /// <returns>Returns a  DescribeWorkspacesPoolsResult from WorkSpaces.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/DescribeWorkspacesPools">REST API Reference for DescribeWorkspacesPools Operation</seealso>
        DescribeWorkspacesPoolsResponse EndDescribeWorkspacesPools(IAsyncResult asyncResult);

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
        DescribeWorkspacesPoolSessionsResponse DescribeWorkspacesPoolSessions(DescribeWorkspacesPoolSessionsRequest request);

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
        IAsyncResult BeginDescribeWorkspacesPoolSessions(DescribeWorkspacesPoolSessionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeWorkspacesPoolSessions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeWorkspacesPoolSessions.</param>
        /// 
        /// <returns>Returns a  DescribeWorkspacesPoolSessionsResult from WorkSpaces.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/DescribeWorkspacesPoolSessions">REST API Reference for DescribeWorkspacesPoolSessions Operation</seealso>
        DescribeWorkspacesPoolSessionsResponse EndDescribeWorkspacesPoolSessions(IAsyncResult asyncResult);

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
        DisassociateConnectionAliasResponse DisassociateConnectionAlias(DisassociateConnectionAliasRequest request);

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
        IAsyncResult BeginDisassociateConnectionAlias(DisassociateConnectionAliasRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DisassociateConnectionAlias operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisassociateConnectionAlias.</param>
        /// 
        /// <returns>Returns a  DisassociateConnectionAliasResult from WorkSpaces.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/DisassociateConnectionAlias">REST API Reference for DisassociateConnectionAlias Operation</seealso>
        DisassociateConnectionAliasResponse EndDisassociateConnectionAlias(IAsyncResult asyncResult);

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
        DisassociateIpGroupsResponse DisassociateIpGroups(DisassociateIpGroupsRequest request);

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
        IAsyncResult BeginDisassociateIpGroups(DisassociateIpGroupsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DisassociateIpGroups operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisassociateIpGroups.</param>
        /// 
        /// <returns>Returns a  DisassociateIpGroupsResult from WorkSpaces.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/DisassociateIpGroups">REST API Reference for DisassociateIpGroups Operation</seealso>
        DisassociateIpGroupsResponse EndDisassociateIpGroups(IAsyncResult asyncResult);

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
        DisassociateWorkspaceApplicationResponse DisassociateWorkspaceApplication(DisassociateWorkspaceApplicationRequest request);

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
        IAsyncResult BeginDisassociateWorkspaceApplication(DisassociateWorkspaceApplicationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DisassociateWorkspaceApplication operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisassociateWorkspaceApplication.</param>
        /// 
        /// <returns>Returns a  DisassociateWorkspaceApplicationResult from WorkSpaces.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/DisassociateWorkspaceApplication">REST API Reference for DisassociateWorkspaceApplication Operation</seealso>
        DisassociateWorkspaceApplicationResponse EndDisassociateWorkspaceApplication(IAsyncResult asyncResult);

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
        GetAccountLinkResponse GetAccountLink(GetAccountLinkRequest request);

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
        IAsyncResult BeginGetAccountLink(GetAccountLinkRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetAccountLink operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetAccountLink.</param>
        /// 
        /// <returns>Returns a  GetAccountLinkResult from WorkSpaces.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/GetAccountLink">REST API Reference for GetAccountLink Operation</seealso>
        GetAccountLinkResponse EndGetAccountLink(IAsyncResult asyncResult);

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
        ImportClientBrandingResponse ImportClientBranding(ImportClientBrandingRequest request);

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
        IAsyncResult BeginImportClientBranding(ImportClientBrandingRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ImportClientBranding operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginImportClientBranding.</param>
        /// 
        /// <returns>Returns a  ImportClientBrandingResult from WorkSpaces.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/ImportClientBranding">REST API Reference for ImportClientBranding Operation</seealso>
        ImportClientBrandingResponse EndImportClientBranding(IAsyncResult asyncResult);

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
        ImportCustomWorkspaceImageResponse ImportCustomWorkspaceImage(ImportCustomWorkspaceImageRequest request);

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
        IAsyncResult BeginImportCustomWorkspaceImage(ImportCustomWorkspaceImageRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ImportCustomWorkspaceImage operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginImportCustomWorkspaceImage.</param>
        /// 
        /// <returns>Returns a  ImportCustomWorkspaceImageResult from WorkSpaces.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/ImportCustomWorkspaceImage">REST API Reference for ImportCustomWorkspaceImage Operation</seealso>
        ImportCustomWorkspaceImageResponse EndImportCustomWorkspaceImage(IAsyncResult asyncResult);

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
        ImportWorkspaceImageResponse ImportWorkspaceImage(ImportWorkspaceImageRequest request);

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
        IAsyncResult BeginImportWorkspaceImage(ImportWorkspaceImageRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ImportWorkspaceImage operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginImportWorkspaceImage.</param>
        /// 
        /// <returns>Returns a  ImportWorkspaceImageResult from WorkSpaces.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/ImportWorkspaceImage">REST API Reference for ImportWorkspaceImage Operation</seealso>
        ImportWorkspaceImageResponse EndImportWorkspaceImage(IAsyncResult asyncResult);

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
        ListAccountLinksResponse ListAccountLinks(ListAccountLinksRequest request);

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
        IAsyncResult BeginListAccountLinks(ListAccountLinksRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListAccountLinks operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAccountLinks.</param>
        /// 
        /// <returns>Returns a  ListAccountLinksResult from WorkSpaces.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/ListAccountLinks">REST API Reference for ListAccountLinks Operation</seealso>
        ListAccountLinksResponse EndListAccountLinks(IAsyncResult asyncResult);

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
        ListAvailableManagementCidrRangesResponse ListAvailableManagementCidrRanges(ListAvailableManagementCidrRangesRequest request);

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
        IAsyncResult BeginListAvailableManagementCidrRanges(ListAvailableManagementCidrRangesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListAvailableManagementCidrRanges operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAvailableManagementCidrRanges.</param>
        /// 
        /// <returns>Returns a  ListAvailableManagementCidrRangesResult from WorkSpaces.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/ListAvailableManagementCidrRanges">REST API Reference for ListAvailableManagementCidrRanges Operation</seealso>
        ListAvailableManagementCidrRangesResponse EndListAvailableManagementCidrRanges(IAsyncResult asyncResult);

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
        MigrateWorkspaceResponse MigrateWorkspace(MigrateWorkspaceRequest request);

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
        IAsyncResult BeginMigrateWorkspace(MigrateWorkspaceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  MigrateWorkspace operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginMigrateWorkspace.</param>
        /// 
        /// <returns>Returns a  MigrateWorkspaceResult from WorkSpaces.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/MigrateWorkspace">REST API Reference for MigrateWorkspace Operation</seealso>
        MigrateWorkspaceResponse EndMigrateWorkspace(IAsyncResult asyncResult);

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
        ModifyAccountResponse ModifyAccount(ModifyAccountRequest request);

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
        IAsyncResult BeginModifyAccount(ModifyAccountRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ModifyAccount operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginModifyAccount.</param>
        /// 
        /// <returns>Returns a  ModifyAccountResult from WorkSpaces.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/ModifyAccount">REST API Reference for ModifyAccount Operation</seealso>
        ModifyAccountResponse EndModifyAccount(IAsyncResult asyncResult);

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
        ModifyCertificateBasedAuthPropertiesResponse ModifyCertificateBasedAuthProperties(ModifyCertificateBasedAuthPropertiesRequest request);

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
        IAsyncResult BeginModifyCertificateBasedAuthProperties(ModifyCertificateBasedAuthPropertiesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ModifyCertificateBasedAuthProperties operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginModifyCertificateBasedAuthProperties.</param>
        /// 
        /// <returns>Returns a  ModifyCertificateBasedAuthPropertiesResult from WorkSpaces.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/ModifyCertificateBasedAuthProperties">REST API Reference for ModifyCertificateBasedAuthProperties Operation</seealso>
        ModifyCertificateBasedAuthPropertiesResponse EndModifyCertificateBasedAuthProperties(IAsyncResult asyncResult);

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
        ModifyClientPropertiesResponse ModifyClientProperties(ModifyClientPropertiesRequest request);

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
        IAsyncResult BeginModifyClientProperties(ModifyClientPropertiesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ModifyClientProperties operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginModifyClientProperties.</param>
        /// 
        /// <returns>Returns a  ModifyClientPropertiesResult from WorkSpaces.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/ModifyClientProperties">REST API Reference for ModifyClientProperties Operation</seealso>
        ModifyClientPropertiesResponse EndModifyClientProperties(IAsyncResult asyncResult);

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
        ModifyEndpointEncryptionModeResponse ModifyEndpointEncryptionMode(ModifyEndpointEncryptionModeRequest request);

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
        IAsyncResult BeginModifyEndpointEncryptionMode(ModifyEndpointEncryptionModeRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ModifyEndpointEncryptionMode operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginModifyEndpointEncryptionMode.</param>
        /// 
        /// <returns>Returns a  ModifyEndpointEncryptionModeResult from WorkSpaces.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/ModifyEndpointEncryptionMode">REST API Reference for ModifyEndpointEncryptionMode Operation</seealso>
        ModifyEndpointEncryptionModeResponse EndModifyEndpointEncryptionMode(IAsyncResult asyncResult);

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
        ModifySamlPropertiesResponse ModifySamlProperties(ModifySamlPropertiesRequest request);

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
        IAsyncResult BeginModifySamlProperties(ModifySamlPropertiesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ModifySamlProperties operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginModifySamlProperties.</param>
        /// 
        /// <returns>Returns a  ModifySamlPropertiesResult from WorkSpaces.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/ModifySamlProperties">REST API Reference for ModifySamlProperties Operation</seealso>
        ModifySamlPropertiesResponse EndModifySamlProperties(IAsyncResult asyncResult);

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
        ModifySelfservicePermissionsResponse ModifySelfservicePermissions(ModifySelfservicePermissionsRequest request);

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
        IAsyncResult BeginModifySelfservicePermissions(ModifySelfservicePermissionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ModifySelfservicePermissions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginModifySelfservicePermissions.</param>
        /// 
        /// <returns>Returns a  ModifySelfservicePermissionsResult from WorkSpaces.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/ModifySelfservicePermissions">REST API Reference for ModifySelfservicePermissions Operation</seealso>
        ModifySelfservicePermissionsResponse EndModifySelfservicePermissions(IAsyncResult asyncResult);

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
        ModifyStreamingPropertiesResponse ModifyStreamingProperties(ModifyStreamingPropertiesRequest request);

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
        IAsyncResult BeginModifyStreamingProperties(ModifyStreamingPropertiesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ModifyStreamingProperties operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginModifyStreamingProperties.</param>
        /// 
        /// <returns>Returns a  ModifyStreamingPropertiesResult from WorkSpaces.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/ModifyStreamingProperties">REST API Reference for ModifyStreamingProperties Operation</seealso>
        ModifyStreamingPropertiesResponse EndModifyStreamingProperties(IAsyncResult asyncResult);

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
        ModifyWorkspaceAccessPropertiesResponse ModifyWorkspaceAccessProperties(ModifyWorkspaceAccessPropertiesRequest request);

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
        IAsyncResult BeginModifyWorkspaceAccessProperties(ModifyWorkspaceAccessPropertiesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ModifyWorkspaceAccessProperties operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginModifyWorkspaceAccessProperties.</param>
        /// 
        /// <returns>Returns a  ModifyWorkspaceAccessPropertiesResult from WorkSpaces.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/ModifyWorkspaceAccessProperties">REST API Reference for ModifyWorkspaceAccessProperties Operation</seealso>
        ModifyWorkspaceAccessPropertiesResponse EndModifyWorkspaceAccessProperties(IAsyncResult asyncResult);

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
        ModifyWorkspaceCreationPropertiesResponse ModifyWorkspaceCreationProperties(ModifyWorkspaceCreationPropertiesRequest request);

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
        IAsyncResult BeginModifyWorkspaceCreationProperties(ModifyWorkspaceCreationPropertiesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ModifyWorkspaceCreationProperties operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginModifyWorkspaceCreationProperties.</param>
        /// 
        /// <returns>Returns a  ModifyWorkspaceCreationPropertiesResult from WorkSpaces.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/ModifyWorkspaceCreationProperties">REST API Reference for ModifyWorkspaceCreationProperties Operation</seealso>
        ModifyWorkspaceCreationPropertiesResponse EndModifyWorkspaceCreationProperties(IAsyncResult asyncResult);

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
        ModifyWorkspacePropertiesResponse ModifyWorkspaceProperties(ModifyWorkspacePropertiesRequest request);

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
        IAsyncResult BeginModifyWorkspaceProperties(ModifyWorkspacePropertiesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ModifyWorkspaceProperties operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginModifyWorkspaceProperties.</param>
        /// 
        /// <returns>Returns a  ModifyWorkspacePropertiesResult from WorkSpaces.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/ModifyWorkspaceProperties">REST API Reference for ModifyWorkspaceProperties Operation</seealso>
        ModifyWorkspacePropertiesResponse EndModifyWorkspaceProperties(IAsyncResult asyncResult);

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
        ModifyWorkspaceStateResponse ModifyWorkspaceState(ModifyWorkspaceStateRequest request);

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
        IAsyncResult BeginModifyWorkspaceState(ModifyWorkspaceStateRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ModifyWorkspaceState operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginModifyWorkspaceState.</param>
        /// 
        /// <returns>Returns a  ModifyWorkspaceStateResult from WorkSpaces.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/ModifyWorkspaceState">REST API Reference for ModifyWorkspaceState Operation</seealso>
        ModifyWorkspaceStateResponse EndModifyWorkspaceState(IAsyncResult asyncResult);

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
        RebootWorkspacesResponse RebootWorkspaces(RebootWorkspacesRequest request);

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
        IAsyncResult BeginRebootWorkspaces(RebootWorkspacesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  RebootWorkspaces operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRebootWorkspaces.</param>
        /// 
        /// <returns>Returns a  RebootWorkspacesResult from WorkSpaces.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/RebootWorkspaces">REST API Reference for RebootWorkspaces Operation</seealso>
        RebootWorkspacesResponse EndRebootWorkspaces(IAsyncResult asyncResult);

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
        RebuildWorkspacesResponse RebuildWorkspaces(RebuildWorkspacesRequest request);

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
        IAsyncResult BeginRebuildWorkspaces(RebuildWorkspacesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  RebuildWorkspaces operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRebuildWorkspaces.</param>
        /// 
        /// <returns>Returns a  RebuildWorkspacesResult from WorkSpaces.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/RebuildWorkspaces">REST API Reference for RebuildWorkspaces Operation</seealso>
        RebuildWorkspacesResponse EndRebuildWorkspaces(IAsyncResult asyncResult);

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
        RegisterWorkspaceDirectoryResponse RegisterWorkspaceDirectory(RegisterWorkspaceDirectoryRequest request);

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
        IAsyncResult BeginRegisterWorkspaceDirectory(RegisterWorkspaceDirectoryRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  RegisterWorkspaceDirectory operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRegisterWorkspaceDirectory.</param>
        /// 
        /// <returns>Returns a  RegisterWorkspaceDirectoryResult from WorkSpaces.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/RegisterWorkspaceDirectory">REST API Reference for RegisterWorkspaceDirectory Operation</seealso>
        RegisterWorkspaceDirectoryResponse EndRegisterWorkspaceDirectory(IAsyncResult asyncResult);

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
        RejectAccountLinkInvitationResponse RejectAccountLinkInvitation(RejectAccountLinkInvitationRequest request);

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
        IAsyncResult BeginRejectAccountLinkInvitation(RejectAccountLinkInvitationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  RejectAccountLinkInvitation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRejectAccountLinkInvitation.</param>
        /// 
        /// <returns>Returns a  RejectAccountLinkInvitationResult from WorkSpaces.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/RejectAccountLinkInvitation">REST API Reference for RejectAccountLinkInvitation Operation</seealso>
        RejectAccountLinkInvitationResponse EndRejectAccountLinkInvitation(IAsyncResult asyncResult);

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
        RestoreWorkspaceResponse RestoreWorkspace(RestoreWorkspaceRequest request);

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
        IAsyncResult BeginRestoreWorkspace(RestoreWorkspaceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  RestoreWorkspace operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRestoreWorkspace.</param>
        /// 
        /// <returns>Returns a  RestoreWorkspaceResult from WorkSpaces.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/RestoreWorkspace">REST API Reference for RestoreWorkspace Operation</seealso>
        RestoreWorkspaceResponse EndRestoreWorkspace(IAsyncResult asyncResult);

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
        RevokeIpRulesResponse RevokeIpRules(RevokeIpRulesRequest request);

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
        IAsyncResult BeginRevokeIpRules(RevokeIpRulesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  RevokeIpRules operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRevokeIpRules.</param>
        /// 
        /// <returns>Returns a  RevokeIpRulesResult from WorkSpaces.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/RevokeIpRules">REST API Reference for RevokeIpRules Operation</seealso>
        RevokeIpRulesResponse EndRevokeIpRules(IAsyncResult asyncResult);

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
        StartWorkspacesResponse StartWorkspaces(StartWorkspacesRequest request);

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
        IAsyncResult BeginStartWorkspaces(StartWorkspacesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StartWorkspaces operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartWorkspaces.</param>
        /// 
        /// <returns>Returns a  StartWorkspacesResult from WorkSpaces.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/StartWorkspaces">REST API Reference for StartWorkspaces Operation</seealso>
        StartWorkspacesResponse EndStartWorkspaces(IAsyncResult asyncResult);

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
        StartWorkspacesPoolResponse StartWorkspacesPool(StartWorkspacesPoolRequest request);

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
        IAsyncResult BeginStartWorkspacesPool(StartWorkspacesPoolRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StartWorkspacesPool operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartWorkspacesPool.</param>
        /// 
        /// <returns>Returns a  StartWorkspacesPoolResult from WorkSpaces.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/StartWorkspacesPool">REST API Reference for StartWorkspacesPool Operation</seealso>
        StartWorkspacesPoolResponse EndStartWorkspacesPool(IAsyncResult asyncResult);

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
        StopWorkspacesResponse StopWorkspaces(StopWorkspacesRequest request);

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
        IAsyncResult BeginStopWorkspaces(StopWorkspacesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StopWorkspaces operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStopWorkspaces.</param>
        /// 
        /// <returns>Returns a  StopWorkspacesResult from WorkSpaces.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/StopWorkspaces">REST API Reference for StopWorkspaces Operation</seealso>
        StopWorkspacesResponse EndStopWorkspaces(IAsyncResult asyncResult);

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
        StopWorkspacesPoolResponse StopWorkspacesPool(StopWorkspacesPoolRequest request);

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
        IAsyncResult BeginStopWorkspacesPool(StopWorkspacesPoolRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StopWorkspacesPool operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStopWorkspacesPool.</param>
        /// 
        /// <returns>Returns a  StopWorkspacesPoolResult from WorkSpaces.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/StopWorkspacesPool">REST API Reference for StopWorkspacesPool Operation</seealso>
        StopWorkspacesPoolResponse EndStopWorkspacesPool(IAsyncResult asyncResult);

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
        TerminateWorkspacesResponse TerminateWorkspaces(TerminateWorkspacesRequest request);

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
        IAsyncResult BeginTerminateWorkspaces(TerminateWorkspacesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  TerminateWorkspaces operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTerminateWorkspaces.</param>
        /// 
        /// <returns>Returns a  TerminateWorkspacesResult from WorkSpaces.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/TerminateWorkspaces">REST API Reference for TerminateWorkspaces Operation</seealso>
        TerminateWorkspacesResponse EndTerminateWorkspaces(IAsyncResult asyncResult);

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
        TerminateWorkspacesPoolResponse TerminateWorkspacesPool(TerminateWorkspacesPoolRequest request);

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
        IAsyncResult BeginTerminateWorkspacesPool(TerminateWorkspacesPoolRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  TerminateWorkspacesPool operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTerminateWorkspacesPool.</param>
        /// 
        /// <returns>Returns a  TerminateWorkspacesPoolResult from WorkSpaces.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/TerminateWorkspacesPool">REST API Reference for TerminateWorkspacesPool Operation</seealso>
        TerminateWorkspacesPoolResponse EndTerminateWorkspacesPool(IAsyncResult asyncResult);

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
        TerminateWorkspacesPoolSessionResponse TerminateWorkspacesPoolSession(TerminateWorkspacesPoolSessionRequest request);

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
        IAsyncResult BeginTerminateWorkspacesPoolSession(TerminateWorkspacesPoolSessionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  TerminateWorkspacesPoolSession operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTerminateWorkspacesPoolSession.</param>
        /// 
        /// <returns>Returns a  TerminateWorkspacesPoolSessionResult from WorkSpaces.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/TerminateWorkspacesPoolSession">REST API Reference for TerminateWorkspacesPoolSession Operation</seealso>
        TerminateWorkspacesPoolSessionResponse EndTerminateWorkspacesPoolSession(IAsyncResult asyncResult);

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
        UpdateConnectClientAddInResponse UpdateConnectClientAddIn(UpdateConnectClientAddInRequest request);

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
        IAsyncResult BeginUpdateConnectClientAddIn(UpdateConnectClientAddInRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateConnectClientAddIn operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateConnectClientAddIn.</param>
        /// 
        /// <returns>Returns a  UpdateConnectClientAddInResult from WorkSpaces.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/UpdateConnectClientAddIn">REST API Reference for UpdateConnectClientAddIn Operation</seealso>
        UpdateConnectClientAddInResponse EndUpdateConnectClientAddIn(IAsyncResult asyncResult);

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
        UpdateConnectionAliasPermissionResponse UpdateConnectionAliasPermission(UpdateConnectionAliasPermissionRequest request);

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
        IAsyncResult BeginUpdateConnectionAliasPermission(UpdateConnectionAliasPermissionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateConnectionAliasPermission operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateConnectionAliasPermission.</param>
        /// 
        /// <returns>Returns a  UpdateConnectionAliasPermissionResult from WorkSpaces.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/UpdateConnectionAliasPermission">REST API Reference for UpdateConnectionAliasPermission Operation</seealso>
        UpdateConnectionAliasPermissionResponse EndUpdateConnectionAliasPermission(IAsyncResult asyncResult);

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
        UpdateRulesOfIpGroupResponse UpdateRulesOfIpGroup(UpdateRulesOfIpGroupRequest request);

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
        IAsyncResult BeginUpdateRulesOfIpGroup(UpdateRulesOfIpGroupRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateRulesOfIpGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateRulesOfIpGroup.</param>
        /// 
        /// <returns>Returns a  UpdateRulesOfIpGroupResult from WorkSpaces.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/UpdateRulesOfIpGroup">REST API Reference for UpdateRulesOfIpGroup Operation</seealso>
        UpdateRulesOfIpGroupResponse EndUpdateRulesOfIpGroup(IAsyncResult asyncResult);

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
        UpdateWorkspaceBundleResponse UpdateWorkspaceBundle(UpdateWorkspaceBundleRequest request);

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
        IAsyncResult BeginUpdateWorkspaceBundle(UpdateWorkspaceBundleRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateWorkspaceBundle operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateWorkspaceBundle.</param>
        /// 
        /// <returns>Returns a  UpdateWorkspaceBundleResult from WorkSpaces.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/UpdateWorkspaceBundle">REST API Reference for UpdateWorkspaceBundle Operation</seealso>
        UpdateWorkspaceBundleResponse EndUpdateWorkspaceBundle(IAsyncResult asyncResult);

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
        UpdateWorkspaceImagePermissionResponse UpdateWorkspaceImagePermission(UpdateWorkspaceImagePermissionRequest request);

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
        IAsyncResult BeginUpdateWorkspaceImagePermission(UpdateWorkspaceImagePermissionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateWorkspaceImagePermission operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateWorkspaceImagePermission.</param>
        /// 
        /// <returns>Returns a  UpdateWorkspaceImagePermissionResult from WorkSpaces.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/UpdateWorkspaceImagePermission">REST API Reference for UpdateWorkspaceImagePermission Operation</seealso>
        UpdateWorkspaceImagePermissionResponse EndUpdateWorkspaceImagePermission(IAsyncResult asyncResult);

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
        UpdateWorkspacesPoolResponse UpdateWorkspacesPool(UpdateWorkspacesPoolRequest request);

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
        IAsyncResult BeginUpdateWorkspacesPool(UpdateWorkspacesPoolRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateWorkspacesPool operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateWorkspacesPool.</param>
        /// 
        /// <returns>Returns a  UpdateWorkspacesPoolResult from WorkSpaces.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/UpdateWorkspacesPool">REST API Reference for UpdateWorkspacesPool Operation</seealso>
        UpdateWorkspacesPoolResponse EndUpdateWorkspacesPool(IAsyncResult asyncResult);

        #endregion
                
        #region DetermineServiceOperationEndpoint

        /// <summary>
        /// Returns the endpoint that will be used for a particular request.
        /// </summary>
        /// <param name="request">Request for the desired service operation.</param>
        /// <returns>The resolved endpoint for the given request.</returns>
        Amazon.Runtime.Endpoints.Endpoint DetermineServiceOperationEndpoint(AmazonWebServiceRequest request);
        
        #endregion

    }
}