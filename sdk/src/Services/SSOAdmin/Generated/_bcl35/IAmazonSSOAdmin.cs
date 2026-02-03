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
 * Do not modify this file. This file is generated from the sso-admin-2020-07-20.normal.json service model.
 */


using System;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.SSOAdmin.Model;

#pragma warning disable CS1570
namespace Amazon.SSOAdmin
{
    /// <summary>
    /// <para>Interface for accessing SSOAdmin</para>
    ///
    /// IAM Identity Center is the Amazon Web Services solution for connecting your workforce
    /// users to Amazon Web Services managed applications and other Amazon Web Services resources.
    /// You can connect your existing identity provider and synchronize users and groups from
    /// your directory, or create and manage your users directly in IAM Identity Center. You
    /// can then use IAM Identity Center for either or both of the following:
    /// 
    ///  <ul> <li> 
    /// <para>
    /// User access to applications
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// User access to Amazon Web Services accounts
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// This guide provides information about single sign-on operations that you can use for
    /// access to applications and Amazon Web Services accounts. For information about IAM
    /// Identity Center features, see the <a href="https://docs.aws.amazon.com/singlesignon/latest/userguide/what-is.html">IAM
    /// Identity Center User Guide</a>.
    /// </para>
    ///  <note> 
    /// <para>
    /// IAM Identity Center uses the <c>sso</c> and <c>identitystore</c> API namespaces.
    /// </para>
    ///  </note> 
    /// <para>
    /// Many API operations for IAM Identity Center rely on identifiers for users and groups,
    /// known as principals. For more information about how to work with principals and principal
    /// IDs in IAM Identity Center, see the <a href="https://docs.aws.amazon.com/singlesignon/latest/IdentityStoreAPIReference/welcome.html">Identity
    /// Store API Reference</a>.
    /// </para>
    ///  <note> 
    /// <para>
    /// Amazon Web Services provides SDKs that consist of libraries and sample code for various
    /// programming languages and platforms (Java, Ruby, .Net, iOS, Android, and more). The
    /// SDKs provide a convenient way to create programmatic access to IAM Identity Center
    /// and other Amazon Web Services services. For more information about the Amazon Web
    /// Services SDKs, including how to download and install them, see <a href="http://aws.amazon.com/tools/">Tools
    /// for Amazon Web Services</a>.
    /// </para>
    ///  </note>
    /// </summary>
    public partial interface IAmazonSSOAdmin : IAmazonService, IDisposable
    {


#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        ISSOAdminPaginatorFactory Paginators { get; }
#endif


        
        #region  AddRegion


        /// <summary>
        /// Adds a Region to an IAM Identity Center instance. This operation initiates an asynchronous
        /// workflow to replicate the IAM Identity Center instance to the target Region. The Region
        /// status is set to ADDING at first and changes to ACTIVE when the workflow completes.
        /// 
        ///  
        /// <para>
        /// To use this operation, your IAM Identity Center instance and the target Region must
        /// meet the requirements described in the <a href="https://docs.aws.amazon.com/singlesignon/latest/userguide/multi-region-iam-identity-center.html#multi-region-prerequisites">IAM
        /// Identity Center User Guide</a>. 
        /// </para>
        ///  
        /// <para>
        /// The following actions are related to <c>AddRegion</c>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/singlesignon/latest/APIReference/API_RemoveRegion.html">RemoveRegion</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/singlesignon/latest/APIReference/API_DescribeRegion.html">DescribeRegion</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/singlesignon/latest/APIReference/API_ListRegions.html">ListRegions</a>
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddRegion service method.</param>
        /// 
        /// <returns>The response from the AddRegion service method, as returned by SSOAdmin.</returns>
        /// <exception cref="Amazon.SSOAdmin.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ConflictException">
        /// Occurs when a conflict with a previous successful write is detected. This generally
        /// occurs when the previous write did not have time to propagate to the host serving
        /// the current request. A retry (with appropriate backoff logic) is the recommended response
        /// to this exception.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ServiceQuotaExceededException">
        /// Indicates that the principal has crossed the permitted number of resources that can
        /// be created.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ThrottlingException">
        /// Indicates that the principal has crossed the throttling limits of the API operations.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ValidationException">
        /// The request failed because it contains a syntax error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/AddRegion">REST API Reference for AddRegion Operation</seealso>
        AddRegionResponse AddRegion(AddRegionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the AddRegion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AddRegion operation on AmazonSSOAdminClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAddRegion
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/AddRegion">REST API Reference for AddRegion Operation</seealso>
        IAsyncResult BeginAddRegion(AddRegionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  AddRegion operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAddRegion.</param>
        /// 
        /// <returns>Returns a  AddRegionResult from SSOAdmin.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/AddRegion">REST API Reference for AddRegion Operation</seealso>
        AddRegionResponse EndAddRegion(IAsyncResult asyncResult);

        #endregion
        
        #region  AttachCustomerManagedPolicyReferenceToPermissionSet


        /// <summary>
        /// Attaches the specified customer managed policy to the specified <a>PermissionSet</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AttachCustomerManagedPolicyReferenceToPermissionSet service method.</param>
        /// 
        /// <returns>The response from the AttachCustomerManagedPolicyReferenceToPermissionSet service method, as returned by SSOAdmin.</returns>
        /// <exception cref="Amazon.SSOAdmin.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ConflictException">
        /// Occurs when a conflict with a previous successful write is detected. This generally
        /// occurs when the previous write did not have time to propagate to the host serving
        /// the current request. A retry (with appropriate backoff logic) is the recommended response
        /// to this exception.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ResourceNotFoundException">
        /// Indicates that a requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ServiceQuotaExceededException">
        /// Indicates that the principal has crossed the permitted number of resources that can
        /// be created.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ThrottlingException">
        /// Indicates that the principal has crossed the throttling limits of the API operations.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ValidationException">
        /// The request failed because it contains a syntax error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/AttachCustomerManagedPolicyReferenceToPermissionSet">REST API Reference for AttachCustomerManagedPolicyReferenceToPermissionSet Operation</seealso>
        AttachCustomerManagedPolicyReferenceToPermissionSetResponse AttachCustomerManagedPolicyReferenceToPermissionSet(AttachCustomerManagedPolicyReferenceToPermissionSetRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the AttachCustomerManagedPolicyReferenceToPermissionSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AttachCustomerManagedPolicyReferenceToPermissionSet operation on AmazonSSOAdminClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAttachCustomerManagedPolicyReferenceToPermissionSet
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/AttachCustomerManagedPolicyReferenceToPermissionSet">REST API Reference for AttachCustomerManagedPolicyReferenceToPermissionSet Operation</seealso>
        IAsyncResult BeginAttachCustomerManagedPolicyReferenceToPermissionSet(AttachCustomerManagedPolicyReferenceToPermissionSetRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  AttachCustomerManagedPolicyReferenceToPermissionSet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAttachCustomerManagedPolicyReferenceToPermissionSet.</param>
        /// 
        /// <returns>Returns a  AttachCustomerManagedPolicyReferenceToPermissionSetResult from SSOAdmin.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/AttachCustomerManagedPolicyReferenceToPermissionSet">REST API Reference for AttachCustomerManagedPolicyReferenceToPermissionSet Operation</seealso>
        AttachCustomerManagedPolicyReferenceToPermissionSetResponse EndAttachCustomerManagedPolicyReferenceToPermissionSet(IAsyncResult asyncResult);

        #endregion
        
        #region  AttachManagedPolicyToPermissionSet


        /// <summary>
        /// Attaches an Amazon Web Services managed policy ARN to a permission set.
        /// 
        ///  <note> 
        /// <para>
        /// If the permission set is already referenced by one or more account assignments, you
        /// will need to call <c> <a>ProvisionPermissionSet</a> </c> after this operation. Calling
        /// <c>ProvisionPermissionSet</c> applies the corresponding IAM policy updates to all
        /// assigned accounts.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AttachManagedPolicyToPermissionSet service method.</param>
        /// 
        /// <returns>The response from the AttachManagedPolicyToPermissionSet service method, as returned by SSOAdmin.</returns>
        /// <exception cref="Amazon.SSOAdmin.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ConflictException">
        /// Occurs when a conflict with a previous successful write is detected. This generally
        /// occurs when the previous write did not have time to propagate to the host serving
        /// the current request. A retry (with appropriate backoff logic) is the recommended response
        /// to this exception.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ResourceNotFoundException">
        /// Indicates that a requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ServiceQuotaExceededException">
        /// Indicates that the principal has crossed the permitted number of resources that can
        /// be created.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ThrottlingException">
        /// Indicates that the principal has crossed the throttling limits of the API operations.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ValidationException">
        /// The request failed because it contains a syntax error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/AttachManagedPolicyToPermissionSet">REST API Reference for AttachManagedPolicyToPermissionSet Operation</seealso>
        AttachManagedPolicyToPermissionSetResponse AttachManagedPolicyToPermissionSet(AttachManagedPolicyToPermissionSetRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the AttachManagedPolicyToPermissionSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AttachManagedPolicyToPermissionSet operation on AmazonSSOAdminClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAttachManagedPolicyToPermissionSet
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/AttachManagedPolicyToPermissionSet">REST API Reference for AttachManagedPolicyToPermissionSet Operation</seealso>
        IAsyncResult BeginAttachManagedPolicyToPermissionSet(AttachManagedPolicyToPermissionSetRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  AttachManagedPolicyToPermissionSet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAttachManagedPolicyToPermissionSet.</param>
        /// 
        /// <returns>Returns a  AttachManagedPolicyToPermissionSetResult from SSOAdmin.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/AttachManagedPolicyToPermissionSet">REST API Reference for AttachManagedPolicyToPermissionSet Operation</seealso>
        AttachManagedPolicyToPermissionSetResponse EndAttachManagedPolicyToPermissionSet(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateAccountAssignment


        /// <summary>
        /// Assigns access to a principal for a specified Amazon Web Services account using a
        /// specified permission set.
        /// 
        ///  <note> 
        /// <para>
        /// The term <i>principal</i> here refers to a user or group that is defined in IAM Identity
        /// Center.
        /// </para>
        ///  </note> <note> 
        /// <para>
        /// As part of a successful <c>CreateAccountAssignment</c> call, the specified permission
        /// set will automatically be provisioned to the account in the form of an IAM policy.
        /// That policy is attached to the IAM role created in IAM Identity Center. If the permission
        /// set is subsequently updated, the corresponding IAM policies attached to roles in your
        /// accounts will not be updated automatically. In this case, you must call <c> <a>ProvisionPermissionSet</a>
        /// </c> to make these updates.
        /// </para>
        ///  </note> <note> 
        /// <para>
        ///  After a successful response, call <c>DescribeAccountAssignmentCreationStatus</c>
        /// to describe the status of an assignment creation request. 
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAccountAssignment service method.</param>
        /// 
        /// <returns>The response from the CreateAccountAssignment service method, as returned by SSOAdmin.</returns>
        /// <exception cref="Amazon.SSOAdmin.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ConflictException">
        /// Occurs when a conflict with a previous successful write is detected. This generally
        /// occurs when the previous write did not have time to propagate to the host serving
        /// the current request. A retry (with appropriate backoff logic) is the recommended response
        /// to this exception.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ResourceNotFoundException">
        /// Indicates that a requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ServiceQuotaExceededException">
        /// Indicates that the principal has crossed the permitted number of resources that can
        /// be created.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ThrottlingException">
        /// Indicates that the principal has crossed the throttling limits of the API operations.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ValidationException">
        /// The request failed because it contains a syntax error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/CreateAccountAssignment">REST API Reference for CreateAccountAssignment Operation</seealso>
        CreateAccountAssignmentResponse CreateAccountAssignment(CreateAccountAssignmentRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateAccountAssignment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateAccountAssignment operation on AmazonSSOAdminClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateAccountAssignment
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/CreateAccountAssignment">REST API Reference for CreateAccountAssignment Operation</seealso>
        IAsyncResult BeginCreateAccountAssignment(CreateAccountAssignmentRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateAccountAssignment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateAccountAssignment.</param>
        /// 
        /// <returns>Returns a  CreateAccountAssignmentResult from SSOAdmin.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/CreateAccountAssignment">REST API Reference for CreateAccountAssignment Operation</seealso>
        CreateAccountAssignmentResponse EndCreateAccountAssignment(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateApplication


        /// <summary>
        /// Creates an OAuth 2.0 customer managed application in IAM Identity Center for the given
        /// application provider.
        /// 
        ///  <note> 
        /// <para>
        /// This API does not support creating SAML 2.0 customer managed applications or Amazon
        /// Web Services managed applications. To learn how to create an Amazon Web Services managed
        /// application, see the application user guide. You can create a SAML 2.0 customer managed
        /// application in the Amazon Web Services Management Console only. See <a href="https://docs.aws.amazon.com/singlesignon/latest/userguide/customermanagedapps-saml2-setup.html">Setting
        /// up customer managed SAML 2.0 applications</a>. For more information on these application
        /// types, see <a href="https://docs.aws.amazon.com/singlesignon/latest/userguide/awsapps.html">Amazon
        /// Web Services managed applications</a>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateApplication service method.</param>
        /// 
        /// <returns>The response from the CreateApplication service method, as returned by SSOAdmin.</returns>
        /// <exception cref="Amazon.SSOAdmin.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ConflictException">
        /// Occurs when a conflict with a previous successful write is detected. This generally
        /// occurs when the previous write did not have time to propagate to the host serving
        /// the current request. A retry (with appropriate backoff logic) is the recommended response
        /// to this exception.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ResourceNotFoundException">
        /// Indicates that a requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ServiceQuotaExceededException">
        /// Indicates that the principal has crossed the permitted number of resources that can
        /// be created.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ThrottlingException">
        /// Indicates that the principal has crossed the throttling limits of the API operations.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ValidationException">
        /// The request failed because it contains a syntax error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/CreateApplication">REST API Reference for CreateApplication Operation</seealso>
        CreateApplicationResponse CreateApplication(CreateApplicationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateApplication operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateApplication operation on AmazonSSOAdminClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateApplication
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/CreateApplication">REST API Reference for CreateApplication Operation</seealso>
        IAsyncResult BeginCreateApplication(CreateApplicationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateApplication operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateApplication.</param>
        /// 
        /// <returns>Returns a  CreateApplicationResult from SSOAdmin.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/CreateApplication">REST API Reference for CreateApplication Operation</seealso>
        CreateApplicationResponse EndCreateApplication(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateApplicationAssignment


        /// <summary>
        /// Grant application access to a user or group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateApplicationAssignment service method.</param>
        /// 
        /// <returns>The response from the CreateApplicationAssignment service method, as returned by SSOAdmin.</returns>
        /// <exception cref="Amazon.SSOAdmin.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ConflictException">
        /// Occurs when a conflict with a previous successful write is detected. This generally
        /// occurs when the previous write did not have time to propagate to the host serving
        /// the current request. A retry (with appropriate backoff logic) is the recommended response
        /// to this exception.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ResourceNotFoundException">
        /// Indicates that a requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ServiceQuotaExceededException">
        /// Indicates that the principal has crossed the permitted number of resources that can
        /// be created.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ThrottlingException">
        /// Indicates that the principal has crossed the throttling limits of the API operations.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ValidationException">
        /// The request failed because it contains a syntax error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/CreateApplicationAssignment">REST API Reference for CreateApplicationAssignment Operation</seealso>
        CreateApplicationAssignmentResponse CreateApplicationAssignment(CreateApplicationAssignmentRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateApplicationAssignment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateApplicationAssignment operation on AmazonSSOAdminClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateApplicationAssignment
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/CreateApplicationAssignment">REST API Reference for CreateApplicationAssignment Operation</seealso>
        IAsyncResult BeginCreateApplicationAssignment(CreateApplicationAssignmentRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateApplicationAssignment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateApplicationAssignment.</param>
        /// 
        /// <returns>Returns a  CreateApplicationAssignmentResult from SSOAdmin.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/CreateApplicationAssignment">REST API Reference for CreateApplicationAssignment Operation</seealso>
        CreateApplicationAssignmentResponse EndCreateApplicationAssignment(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateInstance


        /// <summary>
        /// Creates an instance of IAM Identity Center for a standalone Amazon Web Services account
        /// that is not managed by Organizations or a member Amazon Web Services account in an
        /// organization. You can create only one instance per account and across all Amazon Web
        /// Services Regions.
        /// 
        ///  
        /// <para>
        /// The CreateInstance request is rejected if the following apply: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The instance is created within the organization management account.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// An instance already exists in the same account.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateInstance service method.</param>
        /// 
        /// <returns>The response from the CreateInstance service method, as returned by SSOAdmin.</returns>
        /// <exception cref="Amazon.SSOAdmin.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ConflictException">
        /// Occurs when a conflict with a previous successful write is detected. This generally
        /// occurs when the previous write did not have time to propagate to the host serving
        /// the current request. A retry (with appropriate backoff logic) is the recommended response
        /// to this exception.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ServiceQuotaExceededException">
        /// Indicates that the principal has crossed the permitted number of resources that can
        /// be created.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ThrottlingException">
        /// Indicates that the principal has crossed the throttling limits of the API operations.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ValidationException">
        /// The request failed because it contains a syntax error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/CreateInstance">REST API Reference for CreateInstance Operation</seealso>
        CreateInstanceResponse CreateInstance(CreateInstanceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateInstance operation on AmazonSSOAdminClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateInstance
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/CreateInstance">REST API Reference for CreateInstance Operation</seealso>
        IAsyncResult BeginCreateInstance(CreateInstanceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateInstance operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateInstance.</param>
        /// 
        /// <returns>Returns a  CreateInstanceResult from SSOAdmin.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/CreateInstance">REST API Reference for CreateInstance Operation</seealso>
        CreateInstanceResponse EndCreateInstance(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateInstanceAccessControlAttributeConfiguration


        /// <summary>
        /// Enables the attributes-based access control (ABAC) feature for the specified IAM Identity
        /// Center instance. You can also specify new attributes to add to your ABAC configuration
        /// during the enabling process. For more information about ABAC, see <a href="/singlesignon/latest/userguide/abac.html">Attribute-Based
        /// Access Control</a> in the <i>IAM Identity Center User Guide</i>.
        /// 
        ///  <note> 
        /// <para>
        /// After a successful response, call <c>DescribeInstanceAccessControlAttributeConfiguration</c>
        /// to validate that <c>InstanceAccessControlAttributeConfiguration</c> was created.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateInstanceAccessControlAttributeConfiguration service method.</param>
        /// 
        /// <returns>The response from the CreateInstanceAccessControlAttributeConfiguration service method, as returned by SSOAdmin.</returns>
        /// <exception cref="Amazon.SSOAdmin.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ConflictException">
        /// Occurs when a conflict with a previous successful write is detected. This generally
        /// occurs when the previous write did not have time to propagate to the host serving
        /// the current request. A retry (with appropriate backoff logic) is the recommended response
        /// to this exception.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ResourceNotFoundException">
        /// Indicates that a requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ThrottlingException">
        /// Indicates that the principal has crossed the throttling limits of the API operations.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ValidationException">
        /// The request failed because it contains a syntax error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/CreateInstanceAccessControlAttributeConfiguration">REST API Reference for CreateInstanceAccessControlAttributeConfiguration Operation</seealso>
        CreateInstanceAccessControlAttributeConfigurationResponse CreateInstanceAccessControlAttributeConfiguration(CreateInstanceAccessControlAttributeConfigurationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateInstanceAccessControlAttributeConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateInstanceAccessControlAttributeConfiguration operation on AmazonSSOAdminClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateInstanceAccessControlAttributeConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/CreateInstanceAccessControlAttributeConfiguration">REST API Reference for CreateInstanceAccessControlAttributeConfiguration Operation</seealso>
        IAsyncResult BeginCreateInstanceAccessControlAttributeConfiguration(CreateInstanceAccessControlAttributeConfigurationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateInstanceAccessControlAttributeConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateInstanceAccessControlAttributeConfiguration.</param>
        /// 
        /// <returns>Returns a  CreateInstanceAccessControlAttributeConfigurationResult from SSOAdmin.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/CreateInstanceAccessControlAttributeConfiguration">REST API Reference for CreateInstanceAccessControlAttributeConfiguration Operation</seealso>
        CreateInstanceAccessControlAttributeConfigurationResponse EndCreateInstanceAccessControlAttributeConfiguration(IAsyncResult asyncResult);

        #endregion
        
        #region  CreatePermissionSet


        /// <summary>
        /// Creates a permission set within a specified IAM Identity Center instance.
        /// 
        ///  <note> 
        /// <para>
        /// To grant users and groups access to Amazon Web Services account resources, use <c>
        /// <a>CreateAccountAssignment</a> </c>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePermissionSet service method.</param>
        /// 
        /// <returns>The response from the CreatePermissionSet service method, as returned by SSOAdmin.</returns>
        /// <exception cref="Amazon.SSOAdmin.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ConflictException">
        /// Occurs when a conflict with a previous successful write is detected. This generally
        /// occurs when the previous write did not have time to propagate to the host serving
        /// the current request. A retry (with appropriate backoff logic) is the recommended response
        /// to this exception.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ResourceNotFoundException">
        /// Indicates that a requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ServiceQuotaExceededException">
        /// Indicates that the principal has crossed the permitted number of resources that can
        /// be created.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ThrottlingException">
        /// Indicates that the principal has crossed the throttling limits of the API operations.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ValidationException">
        /// The request failed because it contains a syntax error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/CreatePermissionSet">REST API Reference for CreatePermissionSet Operation</seealso>
        CreatePermissionSetResponse CreatePermissionSet(CreatePermissionSetRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreatePermissionSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreatePermissionSet operation on AmazonSSOAdminClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreatePermissionSet
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/CreatePermissionSet">REST API Reference for CreatePermissionSet Operation</seealso>
        IAsyncResult BeginCreatePermissionSet(CreatePermissionSetRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreatePermissionSet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreatePermissionSet.</param>
        /// 
        /// <returns>Returns a  CreatePermissionSetResult from SSOAdmin.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/CreatePermissionSet">REST API Reference for CreatePermissionSet Operation</seealso>
        CreatePermissionSetResponse EndCreatePermissionSet(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateTrustedTokenIssuer


        /// <summary>
        /// Creates a connection to a trusted token issuer in an instance of IAM Identity Center.
        /// A trusted token issuer enables trusted identity propagation to be used with applications
        /// that authenticate outside of Amazon Web Services.
        /// 
        ///  
        /// <para>
        /// This trusted token issuer describes an external identity provider (IdP) that can generate
        /// claims or assertions in the form of access tokens for a user. Applications enabled
        /// for IAM Identity Center can use these tokens for authentication. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTrustedTokenIssuer service method.</param>
        /// 
        /// <returns>The response from the CreateTrustedTokenIssuer service method, as returned by SSOAdmin.</returns>
        /// <exception cref="Amazon.SSOAdmin.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ConflictException">
        /// Occurs when a conflict with a previous successful write is detected. This generally
        /// occurs when the previous write did not have time to propagate to the host serving
        /// the current request. A retry (with appropriate backoff logic) is the recommended response
        /// to this exception.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ServiceQuotaExceededException">
        /// Indicates that the principal has crossed the permitted number of resources that can
        /// be created.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ThrottlingException">
        /// Indicates that the principal has crossed the throttling limits of the API operations.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ValidationException">
        /// The request failed because it contains a syntax error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/CreateTrustedTokenIssuer">REST API Reference for CreateTrustedTokenIssuer Operation</seealso>
        CreateTrustedTokenIssuerResponse CreateTrustedTokenIssuer(CreateTrustedTokenIssuerRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateTrustedTokenIssuer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateTrustedTokenIssuer operation on AmazonSSOAdminClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateTrustedTokenIssuer
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/CreateTrustedTokenIssuer">REST API Reference for CreateTrustedTokenIssuer Operation</seealso>
        IAsyncResult BeginCreateTrustedTokenIssuer(CreateTrustedTokenIssuerRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateTrustedTokenIssuer operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateTrustedTokenIssuer.</param>
        /// 
        /// <returns>Returns a  CreateTrustedTokenIssuerResult from SSOAdmin.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/CreateTrustedTokenIssuer">REST API Reference for CreateTrustedTokenIssuer Operation</seealso>
        CreateTrustedTokenIssuerResponse EndCreateTrustedTokenIssuer(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteAccountAssignment


        /// <summary>
        /// Deletes a principal's access from a specified Amazon Web Services account using a
        /// specified permission set.
        /// 
        ///  <note> 
        /// <para>
        /// After a successful response, call <c>DescribeAccountAssignmentDeletionStatus</c> to
        /// describe the status of an assignment deletion request.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAccountAssignment service method.</param>
        /// 
        /// <returns>The response from the DeleteAccountAssignment service method, as returned by SSOAdmin.</returns>
        /// <exception cref="Amazon.SSOAdmin.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ConflictException">
        /// Occurs when a conflict with a previous successful write is detected. This generally
        /// occurs when the previous write did not have time to propagate to the host serving
        /// the current request. A retry (with appropriate backoff logic) is the recommended response
        /// to this exception.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ResourceNotFoundException">
        /// Indicates that a requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ThrottlingException">
        /// Indicates that the principal has crossed the throttling limits of the API operations.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ValidationException">
        /// The request failed because it contains a syntax error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/DeleteAccountAssignment">REST API Reference for DeleteAccountAssignment Operation</seealso>
        DeleteAccountAssignmentResponse DeleteAccountAssignment(DeleteAccountAssignmentRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteAccountAssignment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteAccountAssignment operation on AmazonSSOAdminClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteAccountAssignment
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/DeleteAccountAssignment">REST API Reference for DeleteAccountAssignment Operation</seealso>
        IAsyncResult BeginDeleteAccountAssignment(DeleteAccountAssignmentRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteAccountAssignment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteAccountAssignment.</param>
        /// 
        /// <returns>Returns a  DeleteAccountAssignmentResult from SSOAdmin.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/DeleteAccountAssignment">REST API Reference for DeleteAccountAssignment Operation</seealso>
        DeleteAccountAssignmentResponse EndDeleteAccountAssignment(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteApplication


        /// <summary>
        /// Deletes the association with the application. The connected service resource still
        /// exists.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteApplication service method.</param>
        /// 
        /// <returns>The response from the DeleteApplication service method, as returned by SSOAdmin.</returns>
        /// <exception cref="Amazon.SSOAdmin.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ConflictException">
        /// Occurs when a conflict with a previous successful write is detected. This generally
        /// occurs when the previous write did not have time to propagate to the host serving
        /// the current request. A retry (with appropriate backoff logic) is the recommended response
        /// to this exception.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ResourceNotFoundException">
        /// Indicates that a requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ThrottlingException">
        /// Indicates that the principal has crossed the throttling limits of the API operations.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ValidationException">
        /// The request failed because it contains a syntax error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/DeleteApplication">REST API Reference for DeleteApplication Operation</seealso>
        DeleteApplicationResponse DeleteApplication(DeleteApplicationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteApplication operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteApplication operation on AmazonSSOAdminClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteApplication
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/DeleteApplication">REST API Reference for DeleteApplication Operation</seealso>
        IAsyncResult BeginDeleteApplication(DeleteApplicationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteApplication operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteApplication.</param>
        /// 
        /// <returns>Returns a  DeleteApplicationResult from SSOAdmin.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/DeleteApplication">REST API Reference for DeleteApplication Operation</seealso>
        DeleteApplicationResponse EndDeleteApplication(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteApplicationAccessScope


        /// <summary>
        /// Deletes an IAM Identity Center access scope from an application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteApplicationAccessScope service method.</param>
        /// 
        /// <returns>The response from the DeleteApplicationAccessScope service method, as returned by SSOAdmin.</returns>
        /// <exception cref="Amazon.SSOAdmin.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ConflictException">
        /// Occurs when a conflict with a previous successful write is detected. This generally
        /// occurs when the previous write did not have time to propagate to the host serving
        /// the current request. A retry (with appropriate backoff logic) is the recommended response
        /// to this exception.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ResourceNotFoundException">
        /// Indicates that a requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ThrottlingException">
        /// Indicates that the principal has crossed the throttling limits of the API operations.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ValidationException">
        /// The request failed because it contains a syntax error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/DeleteApplicationAccessScope">REST API Reference for DeleteApplicationAccessScope Operation</seealso>
        DeleteApplicationAccessScopeResponse DeleteApplicationAccessScope(DeleteApplicationAccessScopeRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteApplicationAccessScope operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteApplicationAccessScope operation on AmazonSSOAdminClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteApplicationAccessScope
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/DeleteApplicationAccessScope">REST API Reference for DeleteApplicationAccessScope Operation</seealso>
        IAsyncResult BeginDeleteApplicationAccessScope(DeleteApplicationAccessScopeRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteApplicationAccessScope operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteApplicationAccessScope.</param>
        /// 
        /// <returns>Returns a  DeleteApplicationAccessScopeResult from SSOAdmin.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/DeleteApplicationAccessScope">REST API Reference for DeleteApplicationAccessScope Operation</seealso>
        DeleteApplicationAccessScopeResponse EndDeleteApplicationAccessScope(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteApplicationAssignment


        /// <summary>
        /// Revoke application access to an application by deleting application assignments for
        /// a user or group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteApplicationAssignment service method.</param>
        /// 
        /// <returns>The response from the DeleteApplicationAssignment service method, as returned by SSOAdmin.</returns>
        /// <exception cref="Amazon.SSOAdmin.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ConflictException">
        /// Occurs when a conflict with a previous successful write is detected. This generally
        /// occurs when the previous write did not have time to propagate to the host serving
        /// the current request. A retry (with appropriate backoff logic) is the recommended response
        /// to this exception.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ResourceNotFoundException">
        /// Indicates that a requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ThrottlingException">
        /// Indicates that the principal has crossed the throttling limits of the API operations.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ValidationException">
        /// The request failed because it contains a syntax error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/DeleteApplicationAssignment">REST API Reference for DeleteApplicationAssignment Operation</seealso>
        DeleteApplicationAssignmentResponse DeleteApplicationAssignment(DeleteApplicationAssignmentRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteApplicationAssignment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteApplicationAssignment operation on AmazonSSOAdminClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteApplicationAssignment
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/DeleteApplicationAssignment">REST API Reference for DeleteApplicationAssignment Operation</seealso>
        IAsyncResult BeginDeleteApplicationAssignment(DeleteApplicationAssignmentRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteApplicationAssignment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteApplicationAssignment.</param>
        /// 
        /// <returns>Returns a  DeleteApplicationAssignmentResult from SSOAdmin.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/DeleteApplicationAssignment">REST API Reference for DeleteApplicationAssignment Operation</seealso>
        DeleteApplicationAssignmentResponse EndDeleteApplicationAssignment(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteApplicationAuthenticationMethod


        /// <summary>
        /// Deletes an authentication method from an application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteApplicationAuthenticationMethod service method.</param>
        /// 
        /// <returns>The response from the DeleteApplicationAuthenticationMethod service method, as returned by SSOAdmin.</returns>
        /// <exception cref="Amazon.SSOAdmin.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ConflictException">
        /// Occurs when a conflict with a previous successful write is detected. This generally
        /// occurs when the previous write did not have time to propagate to the host serving
        /// the current request. A retry (with appropriate backoff logic) is the recommended response
        /// to this exception.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ResourceNotFoundException">
        /// Indicates that a requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ThrottlingException">
        /// Indicates that the principal has crossed the throttling limits of the API operations.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ValidationException">
        /// The request failed because it contains a syntax error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/DeleteApplicationAuthenticationMethod">REST API Reference for DeleteApplicationAuthenticationMethod Operation</seealso>
        DeleteApplicationAuthenticationMethodResponse DeleteApplicationAuthenticationMethod(DeleteApplicationAuthenticationMethodRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteApplicationAuthenticationMethod operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteApplicationAuthenticationMethod operation on AmazonSSOAdminClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteApplicationAuthenticationMethod
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/DeleteApplicationAuthenticationMethod">REST API Reference for DeleteApplicationAuthenticationMethod Operation</seealso>
        IAsyncResult BeginDeleteApplicationAuthenticationMethod(DeleteApplicationAuthenticationMethodRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteApplicationAuthenticationMethod operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteApplicationAuthenticationMethod.</param>
        /// 
        /// <returns>Returns a  DeleteApplicationAuthenticationMethodResult from SSOAdmin.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/DeleteApplicationAuthenticationMethod">REST API Reference for DeleteApplicationAuthenticationMethod Operation</seealso>
        DeleteApplicationAuthenticationMethodResponse EndDeleteApplicationAuthenticationMethod(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteApplicationGrant


        /// <summary>
        /// Deletes a grant from an application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteApplicationGrant service method.</param>
        /// 
        /// <returns>The response from the DeleteApplicationGrant service method, as returned by SSOAdmin.</returns>
        /// <exception cref="Amazon.SSOAdmin.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ConflictException">
        /// Occurs when a conflict with a previous successful write is detected. This generally
        /// occurs when the previous write did not have time to propagate to the host serving
        /// the current request. A retry (with appropriate backoff logic) is the recommended response
        /// to this exception.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ResourceNotFoundException">
        /// Indicates that a requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ThrottlingException">
        /// Indicates that the principal has crossed the throttling limits of the API operations.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ValidationException">
        /// The request failed because it contains a syntax error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/DeleteApplicationGrant">REST API Reference for DeleteApplicationGrant Operation</seealso>
        DeleteApplicationGrantResponse DeleteApplicationGrant(DeleteApplicationGrantRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteApplicationGrant operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteApplicationGrant operation on AmazonSSOAdminClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteApplicationGrant
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/DeleteApplicationGrant">REST API Reference for DeleteApplicationGrant Operation</seealso>
        IAsyncResult BeginDeleteApplicationGrant(DeleteApplicationGrantRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteApplicationGrant operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteApplicationGrant.</param>
        /// 
        /// <returns>Returns a  DeleteApplicationGrantResult from SSOAdmin.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/DeleteApplicationGrant">REST API Reference for DeleteApplicationGrant Operation</seealso>
        DeleteApplicationGrantResponse EndDeleteApplicationGrant(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteInlinePolicyFromPermissionSet


        /// <summary>
        /// Deletes the inline policy from a specified permission set.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteInlinePolicyFromPermissionSet service method.</param>
        /// 
        /// <returns>The response from the DeleteInlinePolicyFromPermissionSet service method, as returned by SSOAdmin.</returns>
        /// <exception cref="Amazon.SSOAdmin.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ConflictException">
        /// Occurs when a conflict with a previous successful write is detected. This generally
        /// occurs when the previous write did not have time to propagate to the host serving
        /// the current request. A retry (with appropriate backoff logic) is the recommended response
        /// to this exception.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ResourceNotFoundException">
        /// Indicates that a requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ThrottlingException">
        /// Indicates that the principal has crossed the throttling limits of the API operations.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ValidationException">
        /// The request failed because it contains a syntax error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/DeleteInlinePolicyFromPermissionSet">REST API Reference for DeleteInlinePolicyFromPermissionSet Operation</seealso>
        DeleteInlinePolicyFromPermissionSetResponse DeleteInlinePolicyFromPermissionSet(DeleteInlinePolicyFromPermissionSetRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteInlinePolicyFromPermissionSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteInlinePolicyFromPermissionSet operation on AmazonSSOAdminClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteInlinePolicyFromPermissionSet
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/DeleteInlinePolicyFromPermissionSet">REST API Reference for DeleteInlinePolicyFromPermissionSet Operation</seealso>
        IAsyncResult BeginDeleteInlinePolicyFromPermissionSet(DeleteInlinePolicyFromPermissionSetRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteInlinePolicyFromPermissionSet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteInlinePolicyFromPermissionSet.</param>
        /// 
        /// <returns>Returns a  DeleteInlinePolicyFromPermissionSetResult from SSOAdmin.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/DeleteInlinePolicyFromPermissionSet">REST API Reference for DeleteInlinePolicyFromPermissionSet Operation</seealso>
        DeleteInlinePolicyFromPermissionSetResponse EndDeleteInlinePolicyFromPermissionSet(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteInstance


        /// <summary>
        /// Deletes the instance of IAM Identity Center. Only the account that owns the instance
        /// can call this API. Neither the delegated administrator nor member account can delete
        /// the organization instance, but those roles can delete their own instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteInstance service method.</param>
        /// 
        /// <returns>The response from the DeleteInstance service method, as returned by SSOAdmin.</returns>
        /// <exception cref="Amazon.SSOAdmin.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ConflictException">
        /// Occurs when a conflict with a previous successful write is detected. This generally
        /// occurs when the previous write did not have time to propagate to the host serving
        /// the current request. A retry (with appropriate backoff logic) is the recommended response
        /// to this exception.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ThrottlingException">
        /// Indicates that the principal has crossed the throttling limits of the API operations.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ValidationException">
        /// The request failed because it contains a syntax error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/DeleteInstance">REST API Reference for DeleteInstance Operation</seealso>
        DeleteInstanceResponse DeleteInstance(DeleteInstanceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteInstance operation on AmazonSSOAdminClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteInstance
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/DeleteInstance">REST API Reference for DeleteInstance Operation</seealso>
        IAsyncResult BeginDeleteInstance(DeleteInstanceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteInstance operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteInstance.</param>
        /// 
        /// <returns>Returns a  DeleteInstanceResult from SSOAdmin.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/DeleteInstance">REST API Reference for DeleteInstance Operation</seealso>
        DeleteInstanceResponse EndDeleteInstance(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteInstanceAccessControlAttributeConfiguration


        /// <summary>
        /// Disables the attributes-based access control (ABAC) feature for the specified IAM
        /// Identity Center instance and deletes all of the attribute mappings that have been
        /// configured. Once deleted, any attributes that are received from an identity source
        /// and any custom attributes you have previously configured will not be passed. For more
        /// information about ABAC, see <a href="/singlesignon/latest/userguide/abac.html">Attribute-Based
        /// Access Control</a> in the <i>IAM Identity Center User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteInstanceAccessControlAttributeConfiguration service method.</param>
        /// 
        /// <returns>The response from the DeleteInstanceAccessControlAttributeConfiguration service method, as returned by SSOAdmin.</returns>
        /// <exception cref="Amazon.SSOAdmin.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ConflictException">
        /// Occurs when a conflict with a previous successful write is detected. This generally
        /// occurs when the previous write did not have time to propagate to the host serving
        /// the current request. A retry (with appropriate backoff logic) is the recommended response
        /// to this exception.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ResourceNotFoundException">
        /// Indicates that a requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ThrottlingException">
        /// Indicates that the principal has crossed the throttling limits of the API operations.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ValidationException">
        /// The request failed because it contains a syntax error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/DeleteInstanceAccessControlAttributeConfiguration">REST API Reference for DeleteInstanceAccessControlAttributeConfiguration Operation</seealso>
        DeleteInstanceAccessControlAttributeConfigurationResponse DeleteInstanceAccessControlAttributeConfiguration(DeleteInstanceAccessControlAttributeConfigurationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteInstanceAccessControlAttributeConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteInstanceAccessControlAttributeConfiguration operation on AmazonSSOAdminClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteInstanceAccessControlAttributeConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/DeleteInstanceAccessControlAttributeConfiguration">REST API Reference for DeleteInstanceAccessControlAttributeConfiguration Operation</seealso>
        IAsyncResult BeginDeleteInstanceAccessControlAttributeConfiguration(DeleteInstanceAccessControlAttributeConfigurationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteInstanceAccessControlAttributeConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteInstanceAccessControlAttributeConfiguration.</param>
        /// 
        /// <returns>Returns a  DeleteInstanceAccessControlAttributeConfigurationResult from SSOAdmin.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/DeleteInstanceAccessControlAttributeConfiguration">REST API Reference for DeleteInstanceAccessControlAttributeConfiguration Operation</seealso>
        DeleteInstanceAccessControlAttributeConfigurationResponse EndDeleteInstanceAccessControlAttributeConfiguration(IAsyncResult asyncResult);

        #endregion
        
        #region  DeletePermissionsBoundaryFromPermissionSet


        /// <summary>
        /// Deletes the permissions boundary from a specified <a>PermissionSet</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePermissionsBoundaryFromPermissionSet service method.</param>
        /// 
        /// <returns>The response from the DeletePermissionsBoundaryFromPermissionSet service method, as returned by SSOAdmin.</returns>
        /// <exception cref="Amazon.SSOAdmin.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ConflictException">
        /// Occurs when a conflict with a previous successful write is detected. This generally
        /// occurs when the previous write did not have time to propagate to the host serving
        /// the current request. A retry (with appropriate backoff logic) is the recommended response
        /// to this exception.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ResourceNotFoundException">
        /// Indicates that a requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ThrottlingException">
        /// Indicates that the principal has crossed the throttling limits of the API operations.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ValidationException">
        /// The request failed because it contains a syntax error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/DeletePermissionsBoundaryFromPermissionSet">REST API Reference for DeletePermissionsBoundaryFromPermissionSet Operation</seealso>
        DeletePermissionsBoundaryFromPermissionSetResponse DeletePermissionsBoundaryFromPermissionSet(DeletePermissionsBoundaryFromPermissionSetRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeletePermissionsBoundaryFromPermissionSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeletePermissionsBoundaryFromPermissionSet operation on AmazonSSOAdminClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeletePermissionsBoundaryFromPermissionSet
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/DeletePermissionsBoundaryFromPermissionSet">REST API Reference for DeletePermissionsBoundaryFromPermissionSet Operation</seealso>
        IAsyncResult BeginDeletePermissionsBoundaryFromPermissionSet(DeletePermissionsBoundaryFromPermissionSetRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeletePermissionsBoundaryFromPermissionSet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeletePermissionsBoundaryFromPermissionSet.</param>
        /// 
        /// <returns>Returns a  DeletePermissionsBoundaryFromPermissionSetResult from SSOAdmin.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/DeletePermissionsBoundaryFromPermissionSet">REST API Reference for DeletePermissionsBoundaryFromPermissionSet Operation</seealso>
        DeletePermissionsBoundaryFromPermissionSetResponse EndDeletePermissionsBoundaryFromPermissionSet(IAsyncResult asyncResult);

        #endregion
        
        #region  DeletePermissionSet


        /// <summary>
        /// Deletes the specified permission set.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePermissionSet service method.</param>
        /// 
        /// <returns>The response from the DeletePermissionSet service method, as returned by SSOAdmin.</returns>
        /// <exception cref="Amazon.SSOAdmin.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ConflictException">
        /// Occurs when a conflict with a previous successful write is detected. This generally
        /// occurs when the previous write did not have time to propagate to the host serving
        /// the current request. A retry (with appropriate backoff logic) is the recommended response
        /// to this exception.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ResourceNotFoundException">
        /// Indicates that a requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ThrottlingException">
        /// Indicates that the principal has crossed the throttling limits of the API operations.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ValidationException">
        /// The request failed because it contains a syntax error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/DeletePermissionSet">REST API Reference for DeletePermissionSet Operation</seealso>
        DeletePermissionSetResponse DeletePermissionSet(DeletePermissionSetRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeletePermissionSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeletePermissionSet operation on AmazonSSOAdminClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeletePermissionSet
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/DeletePermissionSet">REST API Reference for DeletePermissionSet Operation</seealso>
        IAsyncResult BeginDeletePermissionSet(DeletePermissionSetRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeletePermissionSet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeletePermissionSet.</param>
        /// 
        /// <returns>Returns a  DeletePermissionSetResult from SSOAdmin.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/DeletePermissionSet">REST API Reference for DeletePermissionSet Operation</seealso>
        DeletePermissionSetResponse EndDeletePermissionSet(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteTrustedTokenIssuer


        /// <summary>
        /// Deletes a trusted token issuer configuration from an instance of IAM Identity Center.
        /// 
        ///  <note> 
        /// <para>
        /// Deleting this trusted token issuer configuration will cause users to lose access to
        /// any applications that are configured to use the trusted token issuer.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTrustedTokenIssuer service method.</param>
        /// 
        /// <returns>The response from the DeleteTrustedTokenIssuer service method, as returned by SSOAdmin.</returns>
        /// <exception cref="Amazon.SSOAdmin.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ConflictException">
        /// Occurs when a conflict with a previous successful write is detected. This generally
        /// occurs when the previous write did not have time to propagate to the host serving
        /// the current request. A retry (with appropriate backoff logic) is the recommended response
        /// to this exception.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ResourceNotFoundException">
        /// Indicates that a requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ThrottlingException">
        /// Indicates that the principal has crossed the throttling limits of the API operations.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ValidationException">
        /// The request failed because it contains a syntax error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/DeleteTrustedTokenIssuer">REST API Reference for DeleteTrustedTokenIssuer Operation</seealso>
        DeleteTrustedTokenIssuerResponse DeleteTrustedTokenIssuer(DeleteTrustedTokenIssuerRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteTrustedTokenIssuer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteTrustedTokenIssuer operation on AmazonSSOAdminClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteTrustedTokenIssuer
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/DeleteTrustedTokenIssuer">REST API Reference for DeleteTrustedTokenIssuer Operation</seealso>
        IAsyncResult BeginDeleteTrustedTokenIssuer(DeleteTrustedTokenIssuerRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteTrustedTokenIssuer operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteTrustedTokenIssuer.</param>
        /// 
        /// <returns>Returns a  DeleteTrustedTokenIssuerResult from SSOAdmin.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/DeleteTrustedTokenIssuer">REST API Reference for DeleteTrustedTokenIssuer Operation</seealso>
        DeleteTrustedTokenIssuerResponse EndDeleteTrustedTokenIssuer(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeAccountAssignmentCreationStatus


        /// <summary>
        /// Describes the status of the assignment creation request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAccountAssignmentCreationStatus service method.</param>
        /// 
        /// <returns>The response from the DescribeAccountAssignmentCreationStatus service method, as returned by SSOAdmin.</returns>
        /// <exception cref="Amazon.SSOAdmin.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ResourceNotFoundException">
        /// Indicates that a requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ThrottlingException">
        /// Indicates that the principal has crossed the throttling limits of the API operations.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ValidationException">
        /// The request failed because it contains a syntax error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/DescribeAccountAssignmentCreationStatus">REST API Reference for DescribeAccountAssignmentCreationStatus Operation</seealso>
        DescribeAccountAssignmentCreationStatusResponse DescribeAccountAssignmentCreationStatus(DescribeAccountAssignmentCreationStatusRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeAccountAssignmentCreationStatus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAccountAssignmentCreationStatus operation on AmazonSSOAdminClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeAccountAssignmentCreationStatus
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/DescribeAccountAssignmentCreationStatus">REST API Reference for DescribeAccountAssignmentCreationStatus Operation</seealso>
        IAsyncResult BeginDescribeAccountAssignmentCreationStatus(DescribeAccountAssignmentCreationStatusRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeAccountAssignmentCreationStatus operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeAccountAssignmentCreationStatus.</param>
        /// 
        /// <returns>Returns a  DescribeAccountAssignmentCreationStatusResult from SSOAdmin.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/DescribeAccountAssignmentCreationStatus">REST API Reference for DescribeAccountAssignmentCreationStatus Operation</seealso>
        DescribeAccountAssignmentCreationStatusResponse EndDescribeAccountAssignmentCreationStatus(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeAccountAssignmentDeletionStatus


        /// <summary>
        /// Describes the status of the assignment deletion request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAccountAssignmentDeletionStatus service method.</param>
        /// 
        /// <returns>The response from the DescribeAccountAssignmentDeletionStatus service method, as returned by SSOAdmin.</returns>
        /// <exception cref="Amazon.SSOAdmin.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ResourceNotFoundException">
        /// Indicates that a requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ThrottlingException">
        /// Indicates that the principal has crossed the throttling limits of the API operations.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ValidationException">
        /// The request failed because it contains a syntax error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/DescribeAccountAssignmentDeletionStatus">REST API Reference for DescribeAccountAssignmentDeletionStatus Operation</seealso>
        DescribeAccountAssignmentDeletionStatusResponse DescribeAccountAssignmentDeletionStatus(DescribeAccountAssignmentDeletionStatusRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeAccountAssignmentDeletionStatus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAccountAssignmentDeletionStatus operation on AmazonSSOAdminClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeAccountAssignmentDeletionStatus
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/DescribeAccountAssignmentDeletionStatus">REST API Reference for DescribeAccountAssignmentDeletionStatus Operation</seealso>
        IAsyncResult BeginDescribeAccountAssignmentDeletionStatus(DescribeAccountAssignmentDeletionStatusRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeAccountAssignmentDeletionStatus operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeAccountAssignmentDeletionStatus.</param>
        /// 
        /// <returns>Returns a  DescribeAccountAssignmentDeletionStatusResult from SSOAdmin.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/DescribeAccountAssignmentDeletionStatus">REST API Reference for DescribeAccountAssignmentDeletionStatus Operation</seealso>
        DescribeAccountAssignmentDeletionStatusResponse EndDescribeAccountAssignmentDeletionStatus(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeApplication


        /// <summary>
        /// Retrieves the details of an application associated with an instance of IAM Identity
        /// Center.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeApplication service method.</param>
        /// 
        /// <returns>The response from the DescribeApplication service method, as returned by SSOAdmin.</returns>
        /// <exception cref="Amazon.SSOAdmin.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ResourceNotFoundException">
        /// Indicates that a requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ThrottlingException">
        /// Indicates that the principal has crossed the throttling limits of the API operations.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ValidationException">
        /// The request failed because it contains a syntax error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/DescribeApplication">REST API Reference for DescribeApplication Operation</seealso>
        DescribeApplicationResponse DescribeApplication(DescribeApplicationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeApplication operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeApplication operation on AmazonSSOAdminClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeApplication
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/DescribeApplication">REST API Reference for DescribeApplication Operation</seealso>
        IAsyncResult BeginDescribeApplication(DescribeApplicationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeApplication operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeApplication.</param>
        /// 
        /// <returns>Returns a  DescribeApplicationResult from SSOAdmin.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/DescribeApplication">REST API Reference for DescribeApplication Operation</seealso>
        DescribeApplicationResponse EndDescribeApplication(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeApplicationAssignment


        /// <summary>
        /// Retrieves a direct assignment of a user or group to an application. If the user doesn’t
        /// have a direct assignment to the application, the user may still have access to the
        /// application through a group. Therefore, don’t use this API to test access to an application
        /// for a user. Instead use <a>ListApplicationAssignmentsForPrincipal</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeApplicationAssignment service method.</param>
        /// 
        /// <returns>The response from the DescribeApplicationAssignment service method, as returned by SSOAdmin.</returns>
        /// <exception cref="Amazon.SSOAdmin.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ResourceNotFoundException">
        /// Indicates that a requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ThrottlingException">
        /// Indicates that the principal has crossed the throttling limits of the API operations.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ValidationException">
        /// The request failed because it contains a syntax error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/DescribeApplicationAssignment">REST API Reference for DescribeApplicationAssignment Operation</seealso>
        DescribeApplicationAssignmentResponse DescribeApplicationAssignment(DescribeApplicationAssignmentRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeApplicationAssignment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeApplicationAssignment operation on AmazonSSOAdminClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeApplicationAssignment
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/DescribeApplicationAssignment">REST API Reference for DescribeApplicationAssignment Operation</seealso>
        IAsyncResult BeginDescribeApplicationAssignment(DescribeApplicationAssignmentRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeApplicationAssignment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeApplicationAssignment.</param>
        /// 
        /// <returns>Returns a  DescribeApplicationAssignmentResult from SSOAdmin.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/DescribeApplicationAssignment">REST API Reference for DescribeApplicationAssignment Operation</seealso>
        DescribeApplicationAssignmentResponse EndDescribeApplicationAssignment(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeApplicationProvider


        /// <summary>
        /// Retrieves details about a provider that can be used to connect an Amazon Web Services
        /// managed application or customer managed application to IAM Identity Center.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeApplicationProvider service method.</param>
        /// 
        /// <returns>The response from the DescribeApplicationProvider service method, as returned by SSOAdmin.</returns>
        /// <exception cref="Amazon.SSOAdmin.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ResourceNotFoundException">
        /// Indicates that a requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ThrottlingException">
        /// Indicates that the principal has crossed the throttling limits of the API operations.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ValidationException">
        /// The request failed because it contains a syntax error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/DescribeApplicationProvider">REST API Reference for DescribeApplicationProvider Operation</seealso>
        DescribeApplicationProviderResponse DescribeApplicationProvider(DescribeApplicationProviderRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeApplicationProvider operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeApplicationProvider operation on AmazonSSOAdminClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeApplicationProvider
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/DescribeApplicationProvider">REST API Reference for DescribeApplicationProvider Operation</seealso>
        IAsyncResult BeginDescribeApplicationProvider(DescribeApplicationProviderRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeApplicationProvider operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeApplicationProvider.</param>
        /// 
        /// <returns>Returns a  DescribeApplicationProviderResult from SSOAdmin.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/DescribeApplicationProvider">REST API Reference for DescribeApplicationProvider Operation</seealso>
        DescribeApplicationProviderResponse EndDescribeApplicationProvider(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeInstance


        /// <summary>
        /// Returns the details of an instance of IAM Identity Center. The status can be one of
        /// the following:
        /// 
        ///  <ul> <li> 
        /// <para>
        ///  <c>CREATE_IN_PROGRESS</c> - The instance is in the process of being created. When
        /// the instance is ready for use, DescribeInstance returns the status of <c>ACTIVE</c>.
        /// While the instance is in the <c>CREATE_IN_PROGRESS</c> state, you can call only DescribeInstance
        /// and DeleteInstance operations.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DELETE_IN_PROGRESS</c> - The instance is being deleted. Returns <c>AccessDeniedException</c>
        /// after the delete operation completes. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ACTIVE</c> - The instance is active.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeInstance service method.</param>
        /// 
        /// <returns>The response from the DescribeInstance service method, as returned by SSOAdmin.</returns>
        /// <exception cref="Amazon.SSOAdmin.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ThrottlingException">
        /// Indicates that the principal has crossed the throttling limits of the API operations.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ValidationException">
        /// The request failed because it contains a syntax error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/DescribeInstance">REST API Reference for DescribeInstance Operation</seealso>
        DescribeInstanceResponse DescribeInstance(DescribeInstanceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeInstance operation on AmazonSSOAdminClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeInstance
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/DescribeInstance">REST API Reference for DescribeInstance Operation</seealso>
        IAsyncResult BeginDescribeInstance(DescribeInstanceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeInstance operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeInstance.</param>
        /// 
        /// <returns>Returns a  DescribeInstanceResult from SSOAdmin.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/DescribeInstance">REST API Reference for DescribeInstance Operation</seealso>
        DescribeInstanceResponse EndDescribeInstance(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeInstanceAccessControlAttributeConfiguration


        /// <summary>
        /// Returns the list of IAM Identity Center identity store attributes that have been configured
        /// to work with attributes-based access control (ABAC) for the specified IAM Identity
        /// Center instance. This will not return attributes configured and sent by an external
        /// identity provider. For more information about ABAC, see <a href="/singlesignon/latest/userguide/abac.html">Attribute-Based
        /// Access Control</a> in the <i>IAM Identity Center User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeInstanceAccessControlAttributeConfiguration service method.</param>
        /// 
        /// <returns>The response from the DescribeInstanceAccessControlAttributeConfiguration service method, as returned by SSOAdmin.</returns>
        /// <exception cref="Amazon.SSOAdmin.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ResourceNotFoundException">
        /// Indicates that a requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ThrottlingException">
        /// Indicates that the principal has crossed the throttling limits of the API operations.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ValidationException">
        /// The request failed because it contains a syntax error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/DescribeInstanceAccessControlAttributeConfiguration">REST API Reference for DescribeInstanceAccessControlAttributeConfiguration Operation</seealso>
        DescribeInstanceAccessControlAttributeConfigurationResponse DescribeInstanceAccessControlAttributeConfiguration(DescribeInstanceAccessControlAttributeConfigurationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeInstanceAccessControlAttributeConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeInstanceAccessControlAttributeConfiguration operation on AmazonSSOAdminClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeInstanceAccessControlAttributeConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/DescribeInstanceAccessControlAttributeConfiguration">REST API Reference for DescribeInstanceAccessControlAttributeConfiguration Operation</seealso>
        IAsyncResult BeginDescribeInstanceAccessControlAttributeConfiguration(DescribeInstanceAccessControlAttributeConfigurationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeInstanceAccessControlAttributeConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeInstanceAccessControlAttributeConfiguration.</param>
        /// 
        /// <returns>Returns a  DescribeInstanceAccessControlAttributeConfigurationResult from SSOAdmin.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/DescribeInstanceAccessControlAttributeConfiguration">REST API Reference for DescribeInstanceAccessControlAttributeConfiguration Operation</seealso>
        DescribeInstanceAccessControlAttributeConfigurationResponse EndDescribeInstanceAccessControlAttributeConfiguration(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribePermissionSet


        /// <summary>
        /// Gets the details of the permission set.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribePermissionSet service method.</param>
        /// 
        /// <returns>The response from the DescribePermissionSet service method, as returned by SSOAdmin.</returns>
        /// <exception cref="Amazon.SSOAdmin.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ResourceNotFoundException">
        /// Indicates that a requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ThrottlingException">
        /// Indicates that the principal has crossed the throttling limits of the API operations.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ValidationException">
        /// The request failed because it contains a syntax error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/DescribePermissionSet">REST API Reference for DescribePermissionSet Operation</seealso>
        DescribePermissionSetResponse DescribePermissionSet(DescribePermissionSetRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribePermissionSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribePermissionSet operation on AmazonSSOAdminClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribePermissionSet
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/DescribePermissionSet">REST API Reference for DescribePermissionSet Operation</seealso>
        IAsyncResult BeginDescribePermissionSet(DescribePermissionSetRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribePermissionSet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribePermissionSet.</param>
        /// 
        /// <returns>Returns a  DescribePermissionSetResult from SSOAdmin.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/DescribePermissionSet">REST API Reference for DescribePermissionSet Operation</seealso>
        DescribePermissionSetResponse EndDescribePermissionSet(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribePermissionSetProvisioningStatus


        /// <summary>
        /// Describes the status for the given permission set provisioning request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribePermissionSetProvisioningStatus service method.</param>
        /// 
        /// <returns>The response from the DescribePermissionSetProvisioningStatus service method, as returned by SSOAdmin.</returns>
        /// <exception cref="Amazon.SSOAdmin.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ResourceNotFoundException">
        /// Indicates that a requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ThrottlingException">
        /// Indicates that the principal has crossed the throttling limits of the API operations.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ValidationException">
        /// The request failed because it contains a syntax error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/DescribePermissionSetProvisioningStatus">REST API Reference for DescribePermissionSetProvisioningStatus Operation</seealso>
        DescribePermissionSetProvisioningStatusResponse DescribePermissionSetProvisioningStatus(DescribePermissionSetProvisioningStatusRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribePermissionSetProvisioningStatus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribePermissionSetProvisioningStatus operation on AmazonSSOAdminClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribePermissionSetProvisioningStatus
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/DescribePermissionSetProvisioningStatus">REST API Reference for DescribePermissionSetProvisioningStatus Operation</seealso>
        IAsyncResult BeginDescribePermissionSetProvisioningStatus(DescribePermissionSetProvisioningStatusRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribePermissionSetProvisioningStatus operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribePermissionSetProvisioningStatus.</param>
        /// 
        /// <returns>Returns a  DescribePermissionSetProvisioningStatusResult from SSOAdmin.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/DescribePermissionSetProvisioningStatus">REST API Reference for DescribePermissionSetProvisioningStatus Operation</seealso>
        DescribePermissionSetProvisioningStatusResponse EndDescribePermissionSetProvisioningStatus(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeRegion


        /// <summary>
        /// Retrieves details about a specific Region enabled in an IAM Identity Center instance.
        /// Details include the Region name, current status (ACTIVE, ADDING, or REMOVING), the
        /// date when the Region was added, and whether it is the primary Region. The request
        /// must be made from one of the enabled Regions of the IAM Identity Center instance.
        /// 
        ///  
        /// <para>
        /// The following actions are related to <c>DescribeRegion</c>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/singlesignon/latest/APIReference/API_AddRegion.html">
        /// AddRegion</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/singlesignon/latest/APIReference/API_RemoveRegion.html">RemoveRegion</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/singlesignon/latest/APIReference/API_ListRegions.html">ListRegions</a>
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeRegion service method.</param>
        /// 
        /// <returns>The response from the DescribeRegion service method, as returned by SSOAdmin.</returns>
        /// <exception cref="Amazon.SSOAdmin.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ResourceNotFoundException">
        /// Indicates that a requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ThrottlingException">
        /// Indicates that the principal has crossed the throttling limits of the API operations.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ValidationException">
        /// The request failed because it contains a syntax error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/DescribeRegion">REST API Reference for DescribeRegion Operation</seealso>
        DescribeRegionResponse DescribeRegion(DescribeRegionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeRegion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeRegion operation on AmazonSSOAdminClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeRegion
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/DescribeRegion">REST API Reference for DescribeRegion Operation</seealso>
        IAsyncResult BeginDescribeRegion(DescribeRegionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeRegion operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeRegion.</param>
        /// 
        /// <returns>Returns a  DescribeRegionResult from SSOAdmin.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/DescribeRegion">REST API Reference for DescribeRegion Operation</seealso>
        DescribeRegionResponse EndDescribeRegion(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeTrustedTokenIssuer


        /// <summary>
        /// Retrieves details about a trusted token issuer configuration stored in an instance
        /// of IAM Identity Center. Details include the name of the trusted token issuer, the
        /// issuer URL, and the path of the source attribute and the destination attribute for
        /// a trusted token issuer configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeTrustedTokenIssuer service method.</param>
        /// 
        /// <returns>The response from the DescribeTrustedTokenIssuer service method, as returned by SSOAdmin.</returns>
        /// <exception cref="Amazon.SSOAdmin.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ResourceNotFoundException">
        /// Indicates that a requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ThrottlingException">
        /// Indicates that the principal has crossed the throttling limits of the API operations.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ValidationException">
        /// The request failed because it contains a syntax error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/DescribeTrustedTokenIssuer">REST API Reference for DescribeTrustedTokenIssuer Operation</seealso>
        DescribeTrustedTokenIssuerResponse DescribeTrustedTokenIssuer(DescribeTrustedTokenIssuerRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeTrustedTokenIssuer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeTrustedTokenIssuer operation on AmazonSSOAdminClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeTrustedTokenIssuer
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/DescribeTrustedTokenIssuer">REST API Reference for DescribeTrustedTokenIssuer Operation</seealso>
        IAsyncResult BeginDescribeTrustedTokenIssuer(DescribeTrustedTokenIssuerRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeTrustedTokenIssuer operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeTrustedTokenIssuer.</param>
        /// 
        /// <returns>Returns a  DescribeTrustedTokenIssuerResult from SSOAdmin.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/DescribeTrustedTokenIssuer">REST API Reference for DescribeTrustedTokenIssuer Operation</seealso>
        DescribeTrustedTokenIssuerResponse EndDescribeTrustedTokenIssuer(IAsyncResult asyncResult);

        #endregion
        
        #region  DetachCustomerManagedPolicyReferenceFromPermissionSet


        /// <summary>
        /// Detaches the specified customer managed policy from the specified <a>PermissionSet</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DetachCustomerManagedPolicyReferenceFromPermissionSet service method.</param>
        /// 
        /// <returns>The response from the DetachCustomerManagedPolicyReferenceFromPermissionSet service method, as returned by SSOAdmin.</returns>
        /// <exception cref="Amazon.SSOAdmin.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ConflictException">
        /// Occurs when a conflict with a previous successful write is detected. This generally
        /// occurs when the previous write did not have time to propagate to the host serving
        /// the current request. A retry (with appropriate backoff logic) is the recommended response
        /// to this exception.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ResourceNotFoundException">
        /// Indicates that a requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ThrottlingException">
        /// Indicates that the principal has crossed the throttling limits of the API operations.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ValidationException">
        /// The request failed because it contains a syntax error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/DetachCustomerManagedPolicyReferenceFromPermissionSet">REST API Reference for DetachCustomerManagedPolicyReferenceFromPermissionSet Operation</seealso>
        DetachCustomerManagedPolicyReferenceFromPermissionSetResponse DetachCustomerManagedPolicyReferenceFromPermissionSet(DetachCustomerManagedPolicyReferenceFromPermissionSetRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DetachCustomerManagedPolicyReferenceFromPermissionSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DetachCustomerManagedPolicyReferenceFromPermissionSet operation on AmazonSSOAdminClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDetachCustomerManagedPolicyReferenceFromPermissionSet
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/DetachCustomerManagedPolicyReferenceFromPermissionSet">REST API Reference for DetachCustomerManagedPolicyReferenceFromPermissionSet Operation</seealso>
        IAsyncResult BeginDetachCustomerManagedPolicyReferenceFromPermissionSet(DetachCustomerManagedPolicyReferenceFromPermissionSetRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DetachCustomerManagedPolicyReferenceFromPermissionSet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDetachCustomerManagedPolicyReferenceFromPermissionSet.</param>
        /// 
        /// <returns>Returns a  DetachCustomerManagedPolicyReferenceFromPermissionSetResult from SSOAdmin.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/DetachCustomerManagedPolicyReferenceFromPermissionSet">REST API Reference for DetachCustomerManagedPolicyReferenceFromPermissionSet Operation</seealso>
        DetachCustomerManagedPolicyReferenceFromPermissionSetResponse EndDetachCustomerManagedPolicyReferenceFromPermissionSet(IAsyncResult asyncResult);

        #endregion
        
        #region  DetachManagedPolicyFromPermissionSet


        /// <summary>
        /// Detaches the attached Amazon Web Services managed policy ARN from the specified permission
        /// set.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DetachManagedPolicyFromPermissionSet service method.</param>
        /// 
        /// <returns>The response from the DetachManagedPolicyFromPermissionSet service method, as returned by SSOAdmin.</returns>
        /// <exception cref="Amazon.SSOAdmin.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ConflictException">
        /// Occurs when a conflict with a previous successful write is detected. This generally
        /// occurs when the previous write did not have time to propagate to the host serving
        /// the current request. A retry (with appropriate backoff logic) is the recommended response
        /// to this exception.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ResourceNotFoundException">
        /// Indicates that a requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ThrottlingException">
        /// Indicates that the principal has crossed the throttling limits of the API operations.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ValidationException">
        /// The request failed because it contains a syntax error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/DetachManagedPolicyFromPermissionSet">REST API Reference for DetachManagedPolicyFromPermissionSet Operation</seealso>
        DetachManagedPolicyFromPermissionSetResponse DetachManagedPolicyFromPermissionSet(DetachManagedPolicyFromPermissionSetRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DetachManagedPolicyFromPermissionSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DetachManagedPolicyFromPermissionSet operation on AmazonSSOAdminClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDetachManagedPolicyFromPermissionSet
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/DetachManagedPolicyFromPermissionSet">REST API Reference for DetachManagedPolicyFromPermissionSet Operation</seealso>
        IAsyncResult BeginDetachManagedPolicyFromPermissionSet(DetachManagedPolicyFromPermissionSetRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DetachManagedPolicyFromPermissionSet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDetachManagedPolicyFromPermissionSet.</param>
        /// 
        /// <returns>Returns a  DetachManagedPolicyFromPermissionSetResult from SSOAdmin.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/DetachManagedPolicyFromPermissionSet">REST API Reference for DetachManagedPolicyFromPermissionSet Operation</seealso>
        DetachManagedPolicyFromPermissionSetResponse EndDetachManagedPolicyFromPermissionSet(IAsyncResult asyncResult);

        #endregion
        
        #region  GetApplicationAccessScope


        /// <summary>
        /// Retrieves the authorized targets for an IAM Identity Center access scope for an application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetApplicationAccessScope service method.</param>
        /// 
        /// <returns>The response from the GetApplicationAccessScope service method, as returned by SSOAdmin.</returns>
        /// <exception cref="Amazon.SSOAdmin.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ResourceNotFoundException">
        /// Indicates that a requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ThrottlingException">
        /// Indicates that the principal has crossed the throttling limits of the API operations.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ValidationException">
        /// The request failed because it contains a syntax error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/GetApplicationAccessScope">REST API Reference for GetApplicationAccessScope Operation</seealso>
        GetApplicationAccessScopeResponse GetApplicationAccessScope(GetApplicationAccessScopeRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetApplicationAccessScope operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetApplicationAccessScope operation on AmazonSSOAdminClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetApplicationAccessScope
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/GetApplicationAccessScope">REST API Reference for GetApplicationAccessScope Operation</seealso>
        IAsyncResult BeginGetApplicationAccessScope(GetApplicationAccessScopeRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetApplicationAccessScope operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetApplicationAccessScope.</param>
        /// 
        /// <returns>Returns a  GetApplicationAccessScopeResult from SSOAdmin.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/GetApplicationAccessScope">REST API Reference for GetApplicationAccessScope Operation</seealso>
        GetApplicationAccessScopeResponse EndGetApplicationAccessScope(IAsyncResult asyncResult);

        #endregion
        
        #region  GetApplicationAssignmentConfiguration


        /// <summary>
        /// Retrieves the configuration of <a>PutApplicationAssignmentConfiguration</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetApplicationAssignmentConfiguration service method.</param>
        /// 
        /// <returns>The response from the GetApplicationAssignmentConfiguration service method, as returned by SSOAdmin.</returns>
        /// <exception cref="Amazon.SSOAdmin.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ResourceNotFoundException">
        /// Indicates that a requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ThrottlingException">
        /// Indicates that the principal has crossed the throttling limits of the API operations.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ValidationException">
        /// The request failed because it contains a syntax error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/GetApplicationAssignmentConfiguration">REST API Reference for GetApplicationAssignmentConfiguration Operation</seealso>
        GetApplicationAssignmentConfigurationResponse GetApplicationAssignmentConfiguration(GetApplicationAssignmentConfigurationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetApplicationAssignmentConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetApplicationAssignmentConfiguration operation on AmazonSSOAdminClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetApplicationAssignmentConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/GetApplicationAssignmentConfiguration">REST API Reference for GetApplicationAssignmentConfiguration Operation</seealso>
        IAsyncResult BeginGetApplicationAssignmentConfiguration(GetApplicationAssignmentConfigurationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetApplicationAssignmentConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetApplicationAssignmentConfiguration.</param>
        /// 
        /// <returns>Returns a  GetApplicationAssignmentConfigurationResult from SSOAdmin.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/GetApplicationAssignmentConfiguration">REST API Reference for GetApplicationAssignmentConfiguration Operation</seealso>
        GetApplicationAssignmentConfigurationResponse EndGetApplicationAssignmentConfiguration(IAsyncResult asyncResult);

        #endregion
        
        #region  GetApplicationAuthenticationMethod


        /// <summary>
        /// Retrieves details about an authentication method used by an application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetApplicationAuthenticationMethod service method.</param>
        /// 
        /// <returns>The response from the GetApplicationAuthenticationMethod service method, as returned by SSOAdmin.</returns>
        /// <exception cref="Amazon.SSOAdmin.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ResourceNotFoundException">
        /// Indicates that a requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ThrottlingException">
        /// Indicates that the principal has crossed the throttling limits of the API operations.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ValidationException">
        /// The request failed because it contains a syntax error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/GetApplicationAuthenticationMethod">REST API Reference for GetApplicationAuthenticationMethod Operation</seealso>
        GetApplicationAuthenticationMethodResponse GetApplicationAuthenticationMethod(GetApplicationAuthenticationMethodRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetApplicationAuthenticationMethod operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetApplicationAuthenticationMethod operation on AmazonSSOAdminClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetApplicationAuthenticationMethod
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/GetApplicationAuthenticationMethod">REST API Reference for GetApplicationAuthenticationMethod Operation</seealso>
        IAsyncResult BeginGetApplicationAuthenticationMethod(GetApplicationAuthenticationMethodRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetApplicationAuthenticationMethod operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetApplicationAuthenticationMethod.</param>
        /// 
        /// <returns>Returns a  GetApplicationAuthenticationMethodResult from SSOAdmin.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/GetApplicationAuthenticationMethod">REST API Reference for GetApplicationAuthenticationMethod Operation</seealso>
        GetApplicationAuthenticationMethodResponse EndGetApplicationAuthenticationMethod(IAsyncResult asyncResult);

        #endregion
        
        #region  GetApplicationGrant


        /// <summary>
        /// Retrieves details about an application grant.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetApplicationGrant service method.</param>
        /// 
        /// <returns>The response from the GetApplicationGrant service method, as returned by SSOAdmin.</returns>
        /// <exception cref="Amazon.SSOAdmin.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ResourceNotFoundException">
        /// Indicates that a requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ThrottlingException">
        /// Indicates that the principal has crossed the throttling limits of the API operations.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ValidationException">
        /// The request failed because it contains a syntax error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/GetApplicationGrant">REST API Reference for GetApplicationGrant Operation</seealso>
        GetApplicationGrantResponse GetApplicationGrant(GetApplicationGrantRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetApplicationGrant operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetApplicationGrant operation on AmazonSSOAdminClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetApplicationGrant
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/GetApplicationGrant">REST API Reference for GetApplicationGrant Operation</seealso>
        IAsyncResult BeginGetApplicationGrant(GetApplicationGrantRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetApplicationGrant operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetApplicationGrant.</param>
        /// 
        /// <returns>Returns a  GetApplicationGrantResult from SSOAdmin.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/GetApplicationGrant">REST API Reference for GetApplicationGrant Operation</seealso>
        GetApplicationGrantResponse EndGetApplicationGrant(IAsyncResult asyncResult);

        #endregion
        
        #region  GetApplicationSessionConfiguration


        /// <summary>
        /// Retrieves the session configuration for an application in IAM Identity Center.
        /// 
        ///  
        /// <para>
        /// The session configuration determines how users can access an application. This includes
        /// whether user background sessions are enabled. User background sessions allow users
        /// to start a job on a supported Amazon Web Services managed application without having
        /// to remain signed in to an active session while the job runs.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetApplicationSessionConfiguration service method.</param>
        /// 
        /// <returns>The response from the GetApplicationSessionConfiguration service method, as returned by SSOAdmin.</returns>
        /// <exception cref="Amazon.SSOAdmin.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ResourceNotFoundException">
        /// Indicates that a requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ThrottlingException">
        /// Indicates that the principal has crossed the throttling limits of the API operations.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ValidationException">
        /// The request failed because it contains a syntax error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/GetApplicationSessionConfiguration">REST API Reference for GetApplicationSessionConfiguration Operation</seealso>
        GetApplicationSessionConfigurationResponse GetApplicationSessionConfiguration(GetApplicationSessionConfigurationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetApplicationSessionConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetApplicationSessionConfiguration operation on AmazonSSOAdminClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetApplicationSessionConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/GetApplicationSessionConfiguration">REST API Reference for GetApplicationSessionConfiguration Operation</seealso>
        IAsyncResult BeginGetApplicationSessionConfiguration(GetApplicationSessionConfigurationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetApplicationSessionConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetApplicationSessionConfiguration.</param>
        /// 
        /// <returns>Returns a  GetApplicationSessionConfigurationResult from SSOAdmin.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/GetApplicationSessionConfiguration">REST API Reference for GetApplicationSessionConfiguration Operation</seealso>
        GetApplicationSessionConfigurationResponse EndGetApplicationSessionConfiguration(IAsyncResult asyncResult);

        #endregion
        
        #region  GetInlinePolicyForPermissionSet


        /// <summary>
        /// Obtains the inline policy assigned to the permission set.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetInlinePolicyForPermissionSet service method.</param>
        /// 
        /// <returns>The response from the GetInlinePolicyForPermissionSet service method, as returned by SSOAdmin.</returns>
        /// <exception cref="Amazon.SSOAdmin.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ResourceNotFoundException">
        /// Indicates that a requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ThrottlingException">
        /// Indicates that the principal has crossed the throttling limits of the API operations.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ValidationException">
        /// The request failed because it contains a syntax error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/GetInlinePolicyForPermissionSet">REST API Reference for GetInlinePolicyForPermissionSet Operation</seealso>
        GetInlinePolicyForPermissionSetResponse GetInlinePolicyForPermissionSet(GetInlinePolicyForPermissionSetRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetInlinePolicyForPermissionSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetInlinePolicyForPermissionSet operation on AmazonSSOAdminClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetInlinePolicyForPermissionSet
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/GetInlinePolicyForPermissionSet">REST API Reference for GetInlinePolicyForPermissionSet Operation</seealso>
        IAsyncResult BeginGetInlinePolicyForPermissionSet(GetInlinePolicyForPermissionSetRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetInlinePolicyForPermissionSet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetInlinePolicyForPermissionSet.</param>
        /// 
        /// <returns>Returns a  GetInlinePolicyForPermissionSetResult from SSOAdmin.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/GetInlinePolicyForPermissionSet">REST API Reference for GetInlinePolicyForPermissionSet Operation</seealso>
        GetInlinePolicyForPermissionSetResponse EndGetInlinePolicyForPermissionSet(IAsyncResult asyncResult);

        #endregion
        
        #region  GetPermissionsBoundaryForPermissionSet


        /// <summary>
        /// Obtains the permissions boundary for a specified <a>PermissionSet</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPermissionsBoundaryForPermissionSet service method.</param>
        /// 
        /// <returns>The response from the GetPermissionsBoundaryForPermissionSet service method, as returned by SSOAdmin.</returns>
        /// <exception cref="Amazon.SSOAdmin.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ResourceNotFoundException">
        /// Indicates that a requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ThrottlingException">
        /// Indicates that the principal has crossed the throttling limits of the API operations.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ValidationException">
        /// The request failed because it contains a syntax error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/GetPermissionsBoundaryForPermissionSet">REST API Reference for GetPermissionsBoundaryForPermissionSet Operation</seealso>
        GetPermissionsBoundaryForPermissionSetResponse GetPermissionsBoundaryForPermissionSet(GetPermissionsBoundaryForPermissionSetRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetPermissionsBoundaryForPermissionSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetPermissionsBoundaryForPermissionSet operation on AmazonSSOAdminClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetPermissionsBoundaryForPermissionSet
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/GetPermissionsBoundaryForPermissionSet">REST API Reference for GetPermissionsBoundaryForPermissionSet Operation</seealso>
        IAsyncResult BeginGetPermissionsBoundaryForPermissionSet(GetPermissionsBoundaryForPermissionSetRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetPermissionsBoundaryForPermissionSet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetPermissionsBoundaryForPermissionSet.</param>
        /// 
        /// <returns>Returns a  GetPermissionsBoundaryForPermissionSetResult from SSOAdmin.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/GetPermissionsBoundaryForPermissionSet">REST API Reference for GetPermissionsBoundaryForPermissionSet Operation</seealso>
        GetPermissionsBoundaryForPermissionSetResponse EndGetPermissionsBoundaryForPermissionSet(IAsyncResult asyncResult);

        #endregion
        
        #region  ListAccountAssignmentCreationStatus


        /// <summary>
        /// Lists the status of the Amazon Web Services account assignment creation requests for
        /// a specified IAM Identity Center instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAccountAssignmentCreationStatus service method.</param>
        /// 
        /// <returns>The response from the ListAccountAssignmentCreationStatus service method, as returned by SSOAdmin.</returns>
        /// <exception cref="Amazon.SSOAdmin.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ResourceNotFoundException">
        /// Indicates that a requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ThrottlingException">
        /// Indicates that the principal has crossed the throttling limits of the API operations.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ValidationException">
        /// The request failed because it contains a syntax error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/ListAccountAssignmentCreationStatus">REST API Reference for ListAccountAssignmentCreationStatus Operation</seealso>
        ListAccountAssignmentCreationStatusResponse ListAccountAssignmentCreationStatus(ListAccountAssignmentCreationStatusRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListAccountAssignmentCreationStatus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAccountAssignmentCreationStatus operation on AmazonSSOAdminClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAccountAssignmentCreationStatus
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/ListAccountAssignmentCreationStatus">REST API Reference for ListAccountAssignmentCreationStatus Operation</seealso>
        IAsyncResult BeginListAccountAssignmentCreationStatus(ListAccountAssignmentCreationStatusRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListAccountAssignmentCreationStatus operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAccountAssignmentCreationStatus.</param>
        /// 
        /// <returns>Returns a  ListAccountAssignmentCreationStatusResult from SSOAdmin.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/ListAccountAssignmentCreationStatus">REST API Reference for ListAccountAssignmentCreationStatus Operation</seealso>
        ListAccountAssignmentCreationStatusResponse EndListAccountAssignmentCreationStatus(IAsyncResult asyncResult);

        #endregion
        
        #region  ListAccountAssignmentDeletionStatus


        /// <summary>
        /// Lists the status of the Amazon Web Services account assignment deletion requests for
        /// a specified IAM Identity Center instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAccountAssignmentDeletionStatus service method.</param>
        /// 
        /// <returns>The response from the ListAccountAssignmentDeletionStatus service method, as returned by SSOAdmin.</returns>
        /// <exception cref="Amazon.SSOAdmin.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ResourceNotFoundException">
        /// Indicates that a requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ThrottlingException">
        /// Indicates that the principal has crossed the throttling limits of the API operations.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ValidationException">
        /// The request failed because it contains a syntax error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/ListAccountAssignmentDeletionStatus">REST API Reference for ListAccountAssignmentDeletionStatus Operation</seealso>
        ListAccountAssignmentDeletionStatusResponse ListAccountAssignmentDeletionStatus(ListAccountAssignmentDeletionStatusRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListAccountAssignmentDeletionStatus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAccountAssignmentDeletionStatus operation on AmazonSSOAdminClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAccountAssignmentDeletionStatus
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/ListAccountAssignmentDeletionStatus">REST API Reference for ListAccountAssignmentDeletionStatus Operation</seealso>
        IAsyncResult BeginListAccountAssignmentDeletionStatus(ListAccountAssignmentDeletionStatusRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListAccountAssignmentDeletionStatus operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAccountAssignmentDeletionStatus.</param>
        /// 
        /// <returns>Returns a  ListAccountAssignmentDeletionStatusResult from SSOAdmin.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/ListAccountAssignmentDeletionStatus">REST API Reference for ListAccountAssignmentDeletionStatus Operation</seealso>
        ListAccountAssignmentDeletionStatusResponse EndListAccountAssignmentDeletionStatus(IAsyncResult asyncResult);

        #endregion
        
        #region  ListAccountAssignments


        /// <summary>
        /// Lists the assignee of the specified Amazon Web Services account with the specified
        /// permission set.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAccountAssignments service method.</param>
        /// 
        /// <returns>The response from the ListAccountAssignments service method, as returned by SSOAdmin.</returns>
        /// <exception cref="Amazon.SSOAdmin.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ResourceNotFoundException">
        /// Indicates that a requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ThrottlingException">
        /// Indicates that the principal has crossed the throttling limits of the API operations.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ValidationException">
        /// The request failed because it contains a syntax error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/ListAccountAssignments">REST API Reference for ListAccountAssignments Operation</seealso>
        ListAccountAssignmentsResponse ListAccountAssignments(ListAccountAssignmentsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListAccountAssignments operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAccountAssignments operation on AmazonSSOAdminClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAccountAssignments
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/ListAccountAssignments">REST API Reference for ListAccountAssignments Operation</seealso>
        IAsyncResult BeginListAccountAssignments(ListAccountAssignmentsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListAccountAssignments operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAccountAssignments.</param>
        /// 
        /// <returns>Returns a  ListAccountAssignmentsResult from SSOAdmin.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/ListAccountAssignments">REST API Reference for ListAccountAssignments Operation</seealso>
        ListAccountAssignmentsResponse EndListAccountAssignments(IAsyncResult asyncResult);

        #endregion
        
        #region  ListAccountAssignmentsForPrincipal


        /// <summary>
        /// Retrieves a list of the IAM Identity Center associated Amazon Web Services accounts
        /// that the principal has access to. This action must be called from the management account
        /// containing your organization instance of IAM Identity Center. This action is not valid
        /// for account instances of IAM Identity Center.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAccountAssignmentsForPrincipal service method.</param>
        /// 
        /// <returns>The response from the ListAccountAssignmentsForPrincipal service method, as returned by SSOAdmin.</returns>
        /// <exception cref="Amazon.SSOAdmin.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ResourceNotFoundException">
        /// Indicates that a requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ThrottlingException">
        /// Indicates that the principal has crossed the throttling limits of the API operations.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ValidationException">
        /// The request failed because it contains a syntax error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/ListAccountAssignmentsForPrincipal">REST API Reference for ListAccountAssignmentsForPrincipal Operation</seealso>
        ListAccountAssignmentsForPrincipalResponse ListAccountAssignmentsForPrincipal(ListAccountAssignmentsForPrincipalRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListAccountAssignmentsForPrincipal operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAccountAssignmentsForPrincipal operation on AmazonSSOAdminClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAccountAssignmentsForPrincipal
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/ListAccountAssignmentsForPrincipal">REST API Reference for ListAccountAssignmentsForPrincipal Operation</seealso>
        IAsyncResult BeginListAccountAssignmentsForPrincipal(ListAccountAssignmentsForPrincipalRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListAccountAssignmentsForPrincipal operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAccountAssignmentsForPrincipal.</param>
        /// 
        /// <returns>Returns a  ListAccountAssignmentsForPrincipalResult from SSOAdmin.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/ListAccountAssignmentsForPrincipal">REST API Reference for ListAccountAssignmentsForPrincipal Operation</seealso>
        ListAccountAssignmentsForPrincipalResponse EndListAccountAssignmentsForPrincipal(IAsyncResult asyncResult);

        #endregion
        
        #region  ListAccountsForProvisionedPermissionSet


        /// <summary>
        /// Lists all the Amazon Web Services accounts where the specified permission set is provisioned.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAccountsForProvisionedPermissionSet service method.</param>
        /// 
        /// <returns>The response from the ListAccountsForProvisionedPermissionSet service method, as returned by SSOAdmin.</returns>
        /// <exception cref="Amazon.SSOAdmin.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ResourceNotFoundException">
        /// Indicates that a requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ThrottlingException">
        /// Indicates that the principal has crossed the throttling limits of the API operations.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ValidationException">
        /// The request failed because it contains a syntax error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/ListAccountsForProvisionedPermissionSet">REST API Reference for ListAccountsForProvisionedPermissionSet Operation</seealso>
        ListAccountsForProvisionedPermissionSetResponse ListAccountsForProvisionedPermissionSet(ListAccountsForProvisionedPermissionSetRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListAccountsForProvisionedPermissionSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAccountsForProvisionedPermissionSet operation on AmazonSSOAdminClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAccountsForProvisionedPermissionSet
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/ListAccountsForProvisionedPermissionSet">REST API Reference for ListAccountsForProvisionedPermissionSet Operation</seealso>
        IAsyncResult BeginListAccountsForProvisionedPermissionSet(ListAccountsForProvisionedPermissionSetRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListAccountsForProvisionedPermissionSet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAccountsForProvisionedPermissionSet.</param>
        /// 
        /// <returns>Returns a  ListAccountsForProvisionedPermissionSetResult from SSOAdmin.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/ListAccountsForProvisionedPermissionSet">REST API Reference for ListAccountsForProvisionedPermissionSet Operation</seealso>
        ListAccountsForProvisionedPermissionSetResponse EndListAccountsForProvisionedPermissionSet(IAsyncResult asyncResult);

        #endregion
        
        #region  ListApplicationAccessScopes


        /// <summary>
        /// Lists the access scopes and authorized targets associated with an application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListApplicationAccessScopes service method.</param>
        /// 
        /// <returns>The response from the ListApplicationAccessScopes service method, as returned by SSOAdmin.</returns>
        /// <exception cref="Amazon.SSOAdmin.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ResourceNotFoundException">
        /// Indicates that a requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ThrottlingException">
        /// Indicates that the principal has crossed the throttling limits of the API operations.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ValidationException">
        /// The request failed because it contains a syntax error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/ListApplicationAccessScopes">REST API Reference for ListApplicationAccessScopes Operation</seealso>
        ListApplicationAccessScopesResponse ListApplicationAccessScopes(ListApplicationAccessScopesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListApplicationAccessScopes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListApplicationAccessScopes operation on AmazonSSOAdminClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListApplicationAccessScopes
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/ListApplicationAccessScopes">REST API Reference for ListApplicationAccessScopes Operation</seealso>
        IAsyncResult BeginListApplicationAccessScopes(ListApplicationAccessScopesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListApplicationAccessScopes operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListApplicationAccessScopes.</param>
        /// 
        /// <returns>Returns a  ListApplicationAccessScopesResult from SSOAdmin.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/ListApplicationAccessScopes">REST API Reference for ListApplicationAccessScopes Operation</seealso>
        ListApplicationAccessScopesResponse EndListApplicationAccessScopes(IAsyncResult asyncResult);

        #endregion
        
        #region  ListApplicationAssignments


        /// <summary>
        /// Lists Amazon Web Services account users that are assigned to an application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListApplicationAssignments service method.</param>
        /// 
        /// <returns>The response from the ListApplicationAssignments service method, as returned by SSOAdmin.</returns>
        /// <exception cref="Amazon.SSOAdmin.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ResourceNotFoundException">
        /// Indicates that a requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ThrottlingException">
        /// Indicates that the principal has crossed the throttling limits of the API operations.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ValidationException">
        /// The request failed because it contains a syntax error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/ListApplicationAssignments">REST API Reference for ListApplicationAssignments Operation</seealso>
        ListApplicationAssignmentsResponse ListApplicationAssignments(ListApplicationAssignmentsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListApplicationAssignments operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListApplicationAssignments operation on AmazonSSOAdminClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListApplicationAssignments
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/ListApplicationAssignments">REST API Reference for ListApplicationAssignments Operation</seealso>
        IAsyncResult BeginListApplicationAssignments(ListApplicationAssignmentsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListApplicationAssignments operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListApplicationAssignments.</param>
        /// 
        /// <returns>Returns a  ListApplicationAssignmentsResult from SSOAdmin.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/ListApplicationAssignments">REST API Reference for ListApplicationAssignments Operation</seealso>
        ListApplicationAssignmentsResponse EndListApplicationAssignments(IAsyncResult asyncResult);

        #endregion
        
        #region  ListApplicationAssignmentsForPrincipal


        /// <summary>
        /// Lists the applications to which a specified principal is assigned. You must provide
        /// a filter when calling this action from a member account against your organization
        /// instance of IAM Identity Center. A filter is not required when called from the management
        /// account against an organization instance of IAM Identity Center, or from a member
        /// account against an account instance of IAM Identity Center in the same account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListApplicationAssignmentsForPrincipal service method.</param>
        /// 
        /// <returns>The response from the ListApplicationAssignmentsForPrincipal service method, as returned by SSOAdmin.</returns>
        /// <exception cref="Amazon.SSOAdmin.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ResourceNotFoundException">
        /// Indicates that a requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ThrottlingException">
        /// Indicates that the principal has crossed the throttling limits of the API operations.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ValidationException">
        /// The request failed because it contains a syntax error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/ListApplicationAssignmentsForPrincipal">REST API Reference for ListApplicationAssignmentsForPrincipal Operation</seealso>
        ListApplicationAssignmentsForPrincipalResponse ListApplicationAssignmentsForPrincipal(ListApplicationAssignmentsForPrincipalRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListApplicationAssignmentsForPrincipal operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListApplicationAssignmentsForPrincipal operation on AmazonSSOAdminClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListApplicationAssignmentsForPrincipal
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/ListApplicationAssignmentsForPrincipal">REST API Reference for ListApplicationAssignmentsForPrincipal Operation</seealso>
        IAsyncResult BeginListApplicationAssignmentsForPrincipal(ListApplicationAssignmentsForPrincipalRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListApplicationAssignmentsForPrincipal operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListApplicationAssignmentsForPrincipal.</param>
        /// 
        /// <returns>Returns a  ListApplicationAssignmentsForPrincipalResult from SSOAdmin.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/ListApplicationAssignmentsForPrincipal">REST API Reference for ListApplicationAssignmentsForPrincipal Operation</seealso>
        ListApplicationAssignmentsForPrincipalResponse EndListApplicationAssignmentsForPrincipal(IAsyncResult asyncResult);

        #endregion
        
        #region  ListApplicationAuthenticationMethods


        /// <summary>
        /// Lists all of the authentication methods supported by the specified application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListApplicationAuthenticationMethods service method.</param>
        /// 
        /// <returns>The response from the ListApplicationAuthenticationMethods service method, as returned by SSOAdmin.</returns>
        /// <exception cref="Amazon.SSOAdmin.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ResourceNotFoundException">
        /// Indicates that a requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ThrottlingException">
        /// Indicates that the principal has crossed the throttling limits of the API operations.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ValidationException">
        /// The request failed because it contains a syntax error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/ListApplicationAuthenticationMethods">REST API Reference for ListApplicationAuthenticationMethods Operation</seealso>
        ListApplicationAuthenticationMethodsResponse ListApplicationAuthenticationMethods(ListApplicationAuthenticationMethodsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListApplicationAuthenticationMethods operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListApplicationAuthenticationMethods operation on AmazonSSOAdminClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListApplicationAuthenticationMethods
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/ListApplicationAuthenticationMethods">REST API Reference for ListApplicationAuthenticationMethods Operation</seealso>
        IAsyncResult BeginListApplicationAuthenticationMethods(ListApplicationAuthenticationMethodsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListApplicationAuthenticationMethods operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListApplicationAuthenticationMethods.</param>
        /// 
        /// <returns>Returns a  ListApplicationAuthenticationMethodsResult from SSOAdmin.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/ListApplicationAuthenticationMethods">REST API Reference for ListApplicationAuthenticationMethods Operation</seealso>
        ListApplicationAuthenticationMethodsResponse EndListApplicationAuthenticationMethods(IAsyncResult asyncResult);

        #endregion
        
        #region  ListApplicationGrants


        /// <summary>
        /// List the grants associated with an application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListApplicationGrants service method.</param>
        /// 
        /// <returns>The response from the ListApplicationGrants service method, as returned by SSOAdmin.</returns>
        /// <exception cref="Amazon.SSOAdmin.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ResourceNotFoundException">
        /// Indicates that a requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ThrottlingException">
        /// Indicates that the principal has crossed the throttling limits of the API operations.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ValidationException">
        /// The request failed because it contains a syntax error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/ListApplicationGrants">REST API Reference for ListApplicationGrants Operation</seealso>
        ListApplicationGrantsResponse ListApplicationGrants(ListApplicationGrantsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListApplicationGrants operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListApplicationGrants operation on AmazonSSOAdminClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListApplicationGrants
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/ListApplicationGrants">REST API Reference for ListApplicationGrants Operation</seealso>
        IAsyncResult BeginListApplicationGrants(ListApplicationGrantsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListApplicationGrants operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListApplicationGrants.</param>
        /// 
        /// <returns>Returns a  ListApplicationGrantsResult from SSOAdmin.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/ListApplicationGrants">REST API Reference for ListApplicationGrants Operation</seealso>
        ListApplicationGrantsResponse EndListApplicationGrants(IAsyncResult asyncResult);

        #endregion
        
        #region  ListApplicationProviders


        /// <summary>
        /// Lists the application providers configured in the IAM Identity Center identity store.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListApplicationProviders service method.</param>
        /// 
        /// <returns>The response from the ListApplicationProviders service method, as returned by SSOAdmin.</returns>
        /// <exception cref="Amazon.SSOAdmin.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ThrottlingException">
        /// Indicates that the principal has crossed the throttling limits of the API operations.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ValidationException">
        /// The request failed because it contains a syntax error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/ListApplicationProviders">REST API Reference for ListApplicationProviders Operation</seealso>
        ListApplicationProvidersResponse ListApplicationProviders(ListApplicationProvidersRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListApplicationProviders operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListApplicationProviders operation on AmazonSSOAdminClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListApplicationProviders
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/ListApplicationProviders">REST API Reference for ListApplicationProviders Operation</seealso>
        IAsyncResult BeginListApplicationProviders(ListApplicationProvidersRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListApplicationProviders operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListApplicationProviders.</param>
        /// 
        /// <returns>Returns a  ListApplicationProvidersResult from SSOAdmin.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/ListApplicationProviders">REST API Reference for ListApplicationProviders Operation</seealso>
        ListApplicationProvidersResponse EndListApplicationProviders(IAsyncResult asyncResult);

        #endregion
        
        #region  ListApplications


        /// <summary>
        /// Lists all applications associated with the instance of IAM Identity Center. When listing
        /// applications for an organization instance in the management account, member accounts
        /// must use the <c>applicationAccount</c> parameter to filter the list to only applications
        /// created from that account. When listing applications for an account instance in the
        /// same member account, a filter is not required.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListApplications service method.</param>
        /// 
        /// <returns>The response from the ListApplications service method, as returned by SSOAdmin.</returns>
        /// <exception cref="Amazon.SSOAdmin.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ThrottlingException">
        /// Indicates that the principal has crossed the throttling limits of the API operations.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ValidationException">
        /// The request failed because it contains a syntax error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/ListApplications">REST API Reference for ListApplications Operation</seealso>
        ListApplicationsResponse ListApplications(ListApplicationsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListApplications operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListApplications operation on AmazonSSOAdminClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListApplications
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/ListApplications">REST API Reference for ListApplications Operation</seealso>
        IAsyncResult BeginListApplications(ListApplicationsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListApplications operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListApplications.</param>
        /// 
        /// <returns>Returns a  ListApplicationsResult from SSOAdmin.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/ListApplications">REST API Reference for ListApplications Operation</seealso>
        ListApplicationsResponse EndListApplications(IAsyncResult asyncResult);

        #endregion
        
        #region  ListCustomerManagedPolicyReferencesInPermissionSet


        /// <summary>
        /// Lists all customer managed policies attached to a specified <a>PermissionSet</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCustomerManagedPolicyReferencesInPermissionSet service method.</param>
        /// 
        /// <returns>The response from the ListCustomerManagedPolicyReferencesInPermissionSet service method, as returned by SSOAdmin.</returns>
        /// <exception cref="Amazon.SSOAdmin.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ResourceNotFoundException">
        /// Indicates that a requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ThrottlingException">
        /// Indicates that the principal has crossed the throttling limits of the API operations.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ValidationException">
        /// The request failed because it contains a syntax error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/ListCustomerManagedPolicyReferencesInPermissionSet">REST API Reference for ListCustomerManagedPolicyReferencesInPermissionSet Operation</seealso>
        ListCustomerManagedPolicyReferencesInPermissionSetResponse ListCustomerManagedPolicyReferencesInPermissionSet(ListCustomerManagedPolicyReferencesInPermissionSetRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListCustomerManagedPolicyReferencesInPermissionSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListCustomerManagedPolicyReferencesInPermissionSet operation on AmazonSSOAdminClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListCustomerManagedPolicyReferencesInPermissionSet
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/ListCustomerManagedPolicyReferencesInPermissionSet">REST API Reference for ListCustomerManagedPolicyReferencesInPermissionSet Operation</seealso>
        IAsyncResult BeginListCustomerManagedPolicyReferencesInPermissionSet(ListCustomerManagedPolicyReferencesInPermissionSetRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListCustomerManagedPolicyReferencesInPermissionSet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListCustomerManagedPolicyReferencesInPermissionSet.</param>
        /// 
        /// <returns>Returns a  ListCustomerManagedPolicyReferencesInPermissionSetResult from SSOAdmin.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/ListCustomerManagedPolicyReferencesInPermissionSet">REST API Reference for ListCustomerManagedPolicyReferencesInPermissionSet Operation</seealso>
        ListCustomerManagedPolicyReferencesInPermissionSetResponse EndListCustomerManagedPolicyReferencesInPermissionSet(IAsyncResult asyncResult);

        #endregion
        
        #region  ListInstances


        /// <summary>
        /// Lists the details of the organization and account instances of IAM Identity Center
        /// that were created in or visible to the account calling this API.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListInstances service method.</param>
        /// 
        /// <returns>The response from the ListInstances service method, as returned by SSOAdmin.</returns>
        /// <exception cref="Amazon.SSOAdmin.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ThrottlingException">
        /// Indicates that the principal has crossed the throttling limits of the API operations.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ValidationException">
        /// The request failed because it contains a syntax error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/ListInstances">REST API Reference for ListInstances Operation</seealso>
        ListInstancesResponse ListInstances(ListInstancesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListInstances operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListInstances operation on AmazonSSOAdminClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListInstances
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/ListInstances">REST API Reference for ListInstances Operation</seealso>
        IAsyncResult BeginListInstances(ListInstancesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListInstances operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListInstances.</param>
        /// 
        /// <returns>Returns a  ListInstancesResult from SSOAdmin.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/ListInstances">REST API Reference for ListInstances Operation</seealso>
        ListInstancesResponse EndListInstances(IAsyncResult asyncResult);

        #endregion
        
        #region  ListManagedPoliciesInPermissionSet


        /// <summary>
        /// Lists the Amazon Web Services managed policy that is attached to a specified permission
        /// set.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListManagedPoliciesInPermissionSet service method.</param>
        /// 
        /// <returns>The response from the ListManagedPoliciesInPermissionSet service method, as returned by SSOAdmin.</returns>
        /// <exception cref="Amazon.SSOAdmin.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ResourceNotFoundException">
        /// Indicates that a requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ThrottlingException">
        /// Indicates that the principal has crossed the throttling limits of the API operations.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ValidationException">
        /// The request failed because it contains a syntax error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/ListManagedPoliciesInPermissionSet">REST API Reference for ListManagedPoliciesInPermissionSet Operation</seealso>
        ListManagedPoliciesInPermissionSetResponse ListManagedPoliciesInPermissionSet(ListManagedPoliciesInPermissionSetRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListManagedPoliciesInPermissionSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListManagedPoliciesInPermissionSet operation on AmazonSSOAdminClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListManagedPoliciesInPermissionSet
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/ListManagedPoliciesInPermissionSet">REST API Reference for ListManagedPoliciesInPermissionSet Operation</seealso>
        IAsyncResult BeginListManagedPoliciesInPermissionSet(ListManagedPoliciesInPermissionSetRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListManagedPoliciesInPermissionSet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListManagedPoliciesInPermissionSet.</param>
        /// 
        /// <returns>Returns a  ListManagedPoliciesInPermissionSetResult from SSOAdmin.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/ListManagedPoliciesInPermissionSet">REST API Reference for ListManagedPoliciesInPermissionSet Operation</seealso>
        ListManagedPoliciesInPermissionSetResponse EndListManagedPoliciesInPermissionSet(IAsyncResult asyncResult);

        #endregion
        
        #region  ListPermissionSetProvisioningStatus


        /// <summary>
        /// Lists the status of the permission set provisioning requests for a specified IAM Identity
        /// Center instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPermissionSetProvisioningStatus service method.</param>
        /// 
        /// <returns>The response from the ListPermissionSetProvisioningStatus service method, as returned by SSOAdmin.</returns>
        /// <exception cref="Amazon.SSOAdmin.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ResourceNotFoundException">
        /// Indicates that a requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ThrottlingException">
        /// Indicates that the principal has crossed the throttling limits of the API operations.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ValidationException">
        /// The request failed because it contains a syntax error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/ListPermissionSetProvisioningStatus">REST API Reference for ListPermissionSetProvisioningStatus Operation</seealso>
        ListPermissionSetProvisioningStatusResponse ListPermissionSetProvisioningStatus(ListPermissionSetProvisioningStatusRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListPermissionSetProvisioningStatus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListPermissionSetProvisioningStatus operation on AmazonSSOAdminClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListPermissionSetProvisioningStatus
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/ListPermissionSetProvisioningStatus">REST API Reference for ListPermissionSetProvisioningStatus Operation</seealso>
        IAsyncResult BeginListPermissionSetProvisioningStatus(ListPermissionSetProvisioningStatusRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListPermissionSetProvisioningStatus operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListPermissionSetProvisioningStatus.</param>
        /// 
        /// <returns>Returns a  ListPermissionSetProvisioningStatusResult from SSOAdmin.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/ListPermissionSetProvisioningStatus">REST API Reference for ListPermissionSetProvisioningStatus Operation</seealso>
        ListPermissionSetProvisioningStatusResponse EndListPermissionSetProvisioningStatus(IAsyncResult asyncResult);

        #endregion
        
        #region  ListPermissionSets


        /// <summary>
        /// Lists the <a>PermissionSet</a>s in an IAM Identity Center instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPermissionSets service method.</param>
        /// 
        /// <returns>The response from the ListPermissionSets service method, as returned by SSOAdmin.</returns>
        /// <exception cref="Amazon.SSOAdmin.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ResourceNotFoundException">
        /// Indicates that a requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ThrottlingException">
        /// Indicates that the principal has crossed the throttling limits of the API operations.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ValidationException">
        /// The request failed because it contains a syntax error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/ListPermissionSets">REST API Reference for ListPermissionSets Operation</seealso>
        ListPermissionSetsResponse ListPermissionSets(ListPermissionSetsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListPermissionSets operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListPermissionSets operation on AmazonSSOAdminClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListPermissionSets
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/ListPermissionSets">REST API Reference for ListPermissionSets Operation</seealso>
        IAsyncResult BeginListPermissionSets(ListPermissionSetsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListPermissionSets operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListPermissionSets.</param>
        /// 
        /// <returns>Returns a  ListPermissionSetsResult from SSOAdmin.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/ListPermissionSets">REST API Reference for ListPermissionSets Operation</seealso>
        ListPermissionSetsResponse EndListPermissionSets(IAsyncResult asyncResult);

        #endregion
        
        #region  ListPermissionSetsProvisionedToAccount


        /// <summary>
        /// Lists all the permission sets that are provisioned to a specified Amazon Web Services
        /// account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPermissionSetsProvisionedToAccount service method.</param>
        /// 
        /// <returns>The response from the ListPermissionSetsProvisionedToAccount service method, as returned by SSOAdmin.</returns>
        /// <exception cref="Amazon.SSOAdmin.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ResourceNotFoundException">
        /// Indicates that a requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ThrottlingException">
        /// Indicates that the principal has crossed the throttling limits of the API operations.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ValidationException">
        /// The request failed because it contains a syntax error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/ListPermissionSetsProvisionedToAccount">REST API Reference for ListPermissionSetsProvisionedToAccount Operation</seealso>
        ListPermissionSetsProvisionedToAccountResponse ListPermissionSetsProvisionedToAccount(ListPermissionSetsProvisionedToAccountRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListPermissionSetsProvisionedToAccount operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListPermissionSetsProvisionedToAccount operation on AmazonSSOAdminClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListPermissionSetsProvisionedToAccount
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/ListPermissionSetsProvisionedToAccount">REST API Reference for ListPermissionSetsProvisionedToAccount Operation</seealso>
        IAsyncResult BeginListPermissionSetsProvisionedToAccount(ListPermissionSetsProvisionedToAccountRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListPermissionSetsProvisionedToAccount operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListPermissionSetsProvisionedToAccount.</param>
        /// 
        /// <returns>Returns a  ListPermissionSetsProvisionedToAccountResult from SSOAdmin.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/ListPermissionSetsProvisionedToAccount">REST API Reference for ListPermissionSetsProvisionedToAccount Operation</seealso>
        ListPermissionSetsProvisionedToAccountResponse EndListPermissionSetsProvisionedToAccount(IAsyncResult asyncResult);

        #endregion
        
        #region  ListRegions


        /// <summary>
        /// Lists all enabled Regions of an IAM Identity Center instance, including those that
        /// are being added or removed. This operation returns Regions with ACTIVE, ADDING, or
        /// REMOVING status.
        /// 
        ///  
        /// <para>
        /// The following actions are related to <c>ListRegions</c>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/singlesignon/latest/APIReference/API_AddRegion.html">
        /// AddRegion</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/singlesignon/latest/APIReference/API_RemoveRegion.html">RemoveRegion</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/singlesignon/latest/APIReference/API_DescribeRegion.html">DescribeRegion</a>
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRegions service method.</param>
        /// 
        /// <returns>The response from the ListRegions service method, as returned by SSOAdmin.</returns>
        /// <exception cref="Amazon.SSOAdmin.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ThrottlingException">
        /// Indicates that the principal has crossed the throttling limits of the API operations.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ValidationException">
        /// The request failed because it contains a syntax error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/ListRegions">REST API Reference for ListRegions Operation</seealso>
        ListRegionsResponse ListRegions(ListRegionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListRegions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListRegions operation on AmazonSSOAdminClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListRegions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/ListRegions">REST API Reference for ListRegions Operation</seealso>
        IAsyncResult BeginListRegions(ListRegionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListRegions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListRegions.</param>
        /// 
        /// <returns>Returns a  ListRegionsResult from SSOAdmin.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/ListRegions">REST API Reference for ListRegions Operation</seealso>
        ListRegionsResponse EndListRegions(IAsyncResult asyncResult);

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// Lists the tags that are attached to a specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by SSOAdmin.</returns>
        /// <exception cref="Amazon.SSOAdmin.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ResourceNotFoundException">
        /// Indicates that a requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ThrottlingException">
        /// Indicates that the principal has crossed the throttling limits of the API operations.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ValidationException">
        /// The request failed because it contains a syntax error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonSSOAdminClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        IAsyncResult BeginListTagsForResource(ListTagsForResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTagsForResource.</param>
        /// 
        /// <returns>Returns a  ListTagsForResourceResult from SSOAdmin.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult);

        #endregion
        
        #region  ListTrustedTokenIssuers


        /// <summary>
        /// Lists all the trusted token issuers configured in an instance of IAM Identity Center.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTrustedTokenIssuers service method.</param>
        /// 
        /// <returns>The response from the ListTrustedTokenIssuers service method, as returned by SSOAdmin.</returns>
        /// <exception cref="Amazon.SSOAdmin.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ThrottlingException">
        /// Indicates that the principal has crossed the throttling limits of the API operations.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ValidationException">
        /// The request failed because it contains a syntax error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/ListTrustedTokenIssuers">REST API Reference for ListTrustedTokenIssuers Operation</seealso>
        ListTrustedTokenIssuersResponse ListTrustedTokenIssuers(ListTrustedTokenIssuersRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListTrustedTokenIssuers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTrustedTokenIssuers operation on AmazonSSOAdminClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTrustedTokenIssuers
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/ListTrustedTokenIssuers">REST API Reference for ListTrustedTokenIssuers Operation</seealso>
        IAsyncResult BeginListTrustedTokenIssuers(ListTrustedTokenIssuersRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTrustedTokenIssuers operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTrustedTokenIssuers.</param>
        /// 
        /// <returns>Returns a  ListTrustedTokenIssuersResult from SSOAdmin.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/ListTrustedTokenIssuers">REST API Reference for ListTrustedTokenIssuers Operation</seealso>
        ListTrustedTokenIssuersResponse EndListTrustedTokenIssuers(IAsyncResult asyncResult);

        #endregion
        
        #region  ProvisionPermissionSet


        /// <summary>
        /// The process by which a specified permission set is provisioned to the specified target.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ProvisionPermissionSet service method.</param>
        /// 
        /// <returns>The response from the ProvisionPermissionSet service method, as returned by SSOAdmin.</returns>
        /// <exception cref="Amazon.SSOAdmin.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ConflictException">
        /// Occurs when a conflict with a previous successful write is detected. This generally
        /// occurs when the previous write did not have time to propagate to the host serving
        /// the current request. A retry (with appropriate backoff logic) is the recommended response
        /// to this exception.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ResourceNotFoundException">
        /// Indicates that a requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ThrottlingException">
        /// Indicates that the principal has crossed the throttling limits of the API operations.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ValidationException">
        /// The request failed because it contains a syntax error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/ProvisionPermissionSet">REST API Reference for ProvisionPermissionSet Operation</seealso>
        ProvisionPermissionSetResponse ProvisionPermissionSet(ProvisionPermissionSetRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ProvisionPermissionSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ProvisionPermissionSet operation on AmazonSSOAdminClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndProvisionPermissionSet
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/ProvisionPermissionSet">REST API Reference for ProvisionPermissionSet Operation</seealso>
        IAsyncResult BeginProvisionPermissionSet(ProvisionPermissionSetRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ProvisionPermissionSet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginProvisionPermissionSet.</param>
        /// 
        /// <returns>Returns a  ProvisionPermissionSetResult from SSOAdmin.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/ProvisionPermissionSet">REST API Reference for ProvisionPermissionSet Operation</seealso>
        ProvisionPermissionSetResponse EndProvisionPermissionSet(IAsyncResult asyncResult);

        #endregion
        
        #region  PutApplicationAccessScope


        /// <summary>
        /// Adds or updates the list of authorized targets for an IAM Identity Center access scope
        /// for an application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutApplicationAccessScope service method.</param>
        /// 
        /// <returns>The response from the PutApplicationAccessScope service method, as returned by SSOAdmin.</returns>
        /// <exception cref="Amazon.SSOAdmin.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ConflictException">
        /// Occurs when a conflict with a previous successful write is detected. This generally
        /// occurs when the previous write did not have time to propagate to the host serving
        /// the current request. A retry (with appropriate backoff logic) is the recommended response
        /// to this exception.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ResourceNotFoundException">
        /// Indicates that a requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ThrottlingException">
        /// Indicates that the principal has crossed the throttling limits of the API operations.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ValidationException">
        /// The request failed because it contains a syntax error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/PutApplicationAccessScope">REST API Reference for PutApplicationAccessScope Operation</seealso>
        PutApplicationAccessScopeResponse PutApplicationAccessScope(PutApplicationAccessScopeRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the PutApplicationAccessScope operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutApplicationAccessScope operation on AmazonSSOAdminClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutApplicationAccessScope
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/PutApplicationAccessScope">REST API Reference for PutApplicationAccessScope Operation</seealso>
        IAsyncResult BeginPutApplicationAccessScope(PutApplicationAccessScopeRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  PutApplicationAccessScope operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutApplicationAccessScope.</param>
        /// 
        /// <returns>Returns a  PutApplicationAccessScopeResult from SSOAdmin.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/PutApplicationAccessScope">REST API Reference for PutApplicationAccessScope Operation</seealso>
        PutApplicationAccessScopeResponse EndPutApplicationAccessScope(IAsyncResult asyncResult);

        #endregion
        
        #region  PutApplicationAssignmentConfiguration


        /// <summary>
        /// Configure how users gain access to an application. If <c>AssignmentsRequired</c> is
        /// <c>true</c> (default value), users don’t have access to the application unless an
        /// assignment is created using the <a href="https://docs.aws.amazon.com/singlesignon/latest/APIReference/API_CreateApplicationAssignment.html">CreateApplicationAssignment
        /// API</a>. If <c>false</c>, all users have access to the application. If an assignment
        /// is created using <a href="https://docs.aws.amazon.com/singlesignon/latest/APIReference/API_CreateApplicationAssignment.html">CreateApplicationAssignment</a>.,
        /// the user retains access if <c>AssignmentsRequired</c> is set to <c>true</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutApplicationAssignmentConfiguration service method.</param>
        /// 
        /// <returns>The response from the PutApplicationAssignmentConfiguration service method, as returned by SSOAdmin.</returns>
        /// <exception cref="Amazon.SSOAdmin.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ConflictException">
        /// Occurs when a conflict with a previous successful write is detected. This generally
        /// occurs when the previous write did not have time to propagate to the host serving
        /// the current request. A retry (with appropriate backoff logic) is the recommended response
        /// to this exception.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ResourceNotFoundException">
        /// Indicates that a requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ThrottlingException">
        /// Indicates that the principal has crossed the throttling limits of the API operations.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ValidationException">
        /// The request failed because it contains a syntax error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/PutApplicationAssignmentConfiguration">REST API Reference for PutApplicationAssignmentConfiguration Operation</seealso>
        PutApplicationAssignmentConfigurationResponse PutApplicationAssignmentConfiguration(PutApplicationAssignmentConfigurationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the PutApplicationAssignmentConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutApplicationAssignmentConfiguration operation on AmazonSSOAdminClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutApplicationAssignmentConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/PutApplicationAssignmentConfiguration">REST API Reference for PutApplicationAssignmentConfiguration Operation</seealso>
        IAsyncResult BeginPutApplicationAssignmentConfiguration(PutApplicationAssignmentConfigurationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  PutApplicationAssignmentConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutApplicationAssignmentConfiguration.</param>
        /// 
        /// <returns>Returns a  PutApplicationAssignmentConfigurationResult from SSOAdmin.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/PutApplicationAssignmentConfiguration">REST API Reference for PutApplicationAssignmentConfiguration Operation</seealso>
        PutApplicationAssignmentConfigurationResponse EndPutApplicationAssignmentConfiguration(IAsyncResult asyncResult);

        #endregion
        
        #region  PutApplicationAuthenticationMethod


        /// <summary>
        /// Adds or updates an authentication method for an application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutApplicationAuthenticationMethod service method.</param>
        /// 
        /// <returns>The response from the PutApplicationAuthenticationMethod service method, as returned by SSOAdmin.</returns>
        /// <exception cref="Amazon.SSOAdmin.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ConflictException">
        /// Occurs when a conflict with a previous successful write is detected. This generally
        /// occurs when the previous write did not have time to propagate to the host serving
        /// the current request. A retry (with appropriate backoff logic) is the recommended response
        /// to this exception.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ResourceNotFoundException">
        /// Indicates that a requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ThrottlingException">
        /// Indicates that the principal has crossed the throttling limits of the API operations.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ValidationException">
        /// The request failed because it contains a syntax error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/PutApplicationAuthenticationMethod">REST API Reference for PutApplicationAuthenticationMethod Operation</seealso>
        PutApplicationAuthenticationMethodResponse PutApplicationAuthenticationMethod(PutApplicationAuthenticationMethodRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the PutApplicationAuthenticationMethod operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutApplicationAuthenticationMethod operation on AmazonSSOAdminClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutApplicationAuthenticationMethod
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/PutApplicationAuthenticationMethod">REST API Reference for PutApplicationAuthenticationMethod Operation</seealso>
        IAsyncResult BeginPutApplicationAuthenticationMethod(PutApplicationAuthenticationMethodRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  PutApplicationAuthenticationMethod operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutApplicationAuthenticationMethod.</param>
        /// 
        /// <returns>Returns a  PutApplicationAuthenticationMethodResult from SSOAdmin.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/PutApplicationAuthenticationMethod">REST API Reference for PutApplicationAuthenticationMethod Operation</seealso>
        PutApplicationAuthenticationMethodResponse EndPutApplicationAuthenticationMethod(IAsyncResult asyncResult);

        #endregion
        
        #region  PutApplicationGrant


        /// <summary>
        /// Creates a configuration for an application to use grants. Conceptually grants are
        /// authorization to request actions related to tokens. This configuration will be used
        /// when parties are requesting and receiving tokens during the trusted identity propagation
        /// process. For more information on the IAM Identity Center supported grant workflows,
        /// see <a href="https://docs.aws.amazon.com/singlesignon/latest/userguide/customermanagedapps-saml2-oauth2.html">SAML
        /// 2.0 and OAuth 2.0</a>.
        /// 
        ///  
        /// <para>
        /// A grant is created between your applications and Identity Center instance which enables
        /// an application to use specified mechanisms to obtain tokens. These tokens are used
        /// by your applications to gain access to Amazon Web Services resources on behalf of
        /// users. The following elements are within these exchanges:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>Requester</b> - The application requesting access to Amazon Web Services resources.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Subject</b> - Typically the user that is requesting access to Amazon Web Services
        /// resources.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Grant</b> - Conceptually, a grant is authorization to access Amazon Web Services
        /// resources. These grants authorize token generation for authenticating access to the
        /// requester and for the request to make requests on behalf of the subjects. There are
        /// four types of grants:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>AuthorizationCode</b> - Allows an application to request authorization through
        /// a series of user-agent redirects.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>JWT bearer </b> - Authorizes an application to exchange a JSON Web Token that
        /// came from an external identity provider. To learn more, see <a href="https://datatracker.ietf.org/doc/html/rfc6749">RFC
        /// 6479</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Refresh token</b> - Enables application to request new access tokens to replace
        /// expiring or expired access tokens.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Exchange token</b> - A grant that requests tokens from the authorization server
        /// by providing a ‘subject’ token with access scope authorizing trusted identity propagation
        /// to this application. To learn more, see <a href="https://datatracker.ietf.org/doc/html/rfc8693">RFC
        /// 8693</a>.
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        ///  <b>Authorization server</b> - IAM Identity Center requests tokens.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// User credentials are never shared directly within these exchanges. Instead, applications
        /// use grants to request access tokens from IAM Identity Center. For more information,
        /// see <a href="https://datatracker.ietf.org/doc/html/rfc6749">RFC 6479</a>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Use cases</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Connecting to custom applications.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Configuring an Amazon Web Services service to make calls to another Amazon Web Services
        /// services using JWT tokens.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutApplicationGrant service method.</param>
        /// 
        /// <returns>The response from the PutApplicationGrant service method, as returned by SSOAdmin.</returns>
        /// <exception cref="Amazon.SSOAdmin.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ConflictException">
        /// Occurs when a conflict with a previous successful write is detected. This generally
        /// occurs when the previous write did not have time to propagate to the host serving
        /// the current request. A retry (with appropriate backoff logic) is the recommended response
        /// to this exception.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ResourceNotFoundException">
        /// Indicates that a requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ThrottlingException">
        /// Indicates that the principal has crossed the throttling limits of the API operations.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ValidationException">
        /// The request failed because it contains a syntax error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/PutApplicationGrant">REST API Reference for PutApplicationGrant Operation</seealso>
        PutApplicationGrantResponse PutApplicationGrant(PutApplicationGrantRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the PutApplicationGrant operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutApplicationGrant operation on AmazonSSOAdminClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutApplicationGrant
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/PutApplicationGrant">REST API Reference for PutApplicationGrant Operation</seealso>
        IAsyncResult BeginPutApplicationGrant(PutApplicationGrantRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  PutApplicationGrant operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutApplicationGrant.</param>
        /// 
        /// <returns>Returns a  PutApplicationGrantResult from SSOAdmin.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/PutApplicationGrant">REST API Reference for PutApplicationGrant Operation</seealso>
        PutApplicationGrantResponse EndPutApplicationGrant(IAsyncResult asyncResult);

        #endregion
        
        #region  PutApplicationSessionConfiguration


        /// <summary>
        /// Updates the session configuration for an application in IAM Identity Center.
        /// 
        ///  
        /// <para>
        /// The session configuration determines how users can access an application. This includes
        /// whether user background sessions are enabled. User background sessions allow users
        /// to start a job on a supported Amazon Web Services managed application without having
        /// to remain signed in to an active session while the job runs.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutApplicationSessionConfiguration service method.</param>
        /// 
        /// <returns>The response from the PutApplicationSessionConfiguration service method, as returned by SSOAdmin.</returns>
        /// <exception cref="Amazon.SSOAdmin.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ConflictException">
        /// Occurs when a conflict with a previous successful write is detected. This generally
        /// occurs when the previous write did not have time to propagate to the host serving
        /// the current request. A retry (with appropriate backoff logic) is the recommended response
        /// to this exception.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ResourceNotFoundException">
        /// Indicates that a requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ThrottlingException">
        /// Indicates that the principal has crossed the throttling limits of the API operations.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ValidationException">
        /// The request failed because it contains a syntax error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/PutApplicationSessionConfiguration">REST API Reference for PutApplicationSessionConfiguration Operation</seealso>
        PutApplicationSessionConfigurationResponse PutApplicationSessionConfiguration(PutApplicationSessionConfigurationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the PutApplicationSessionConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutApplicationSessionConfiguration operation on AmazonSSOAdminClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutApplicationSessionConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/PutApplicationSessionConfiguration">REST API Reference for PutApplicationSessionConfiguration Operation</seealso>
        IAsyncResult BeginPutApplicationSessionConfiguration(PutApplicationSessionConfigurationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  PutApplicationSessionConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutApplicationSessionConfiguration.</param>
        /// 
        /// <returns>Returns a  PutApplicationSessionConfigurationResult from SSOAdmin.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/PutApplicationSessionConfiguration">REST API Reference for PutApplicationSessionConfiguration Operation</seealso>
        PutApplicationSessionConfigurationResponse EndPutApplicationSessionConfiguration(IAsyncResult asyncResult);

        #endregion
        
        #region  PutInlinePolicyToPermissionSet


        /// <summary>
        /// Attaches an inline policy to a permission set.
        /// 
        ///  <note> 
        /// <para>
        /// If the permission set is already referenced by one or more account assignments, you
        /// will need to call <c> <a>ProvisionPermissionSet</a> </c> after this action to apply
        /// the corresponding IAM policy updates to all assigned accounts.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutInlinePolicyToPermissionSet service method.</param>
        /// 
        /// <returns>The response from the PutInlinePolicyToPermissionSet service method, as returned by SSOAdmin.</returns>
        /// <exception cref="Amazon.SSOAdmin.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ConflictException">
        /// Occurs when a conflict with a previous successful write is detected. This generally
        /// occurs when the previous write did not have time to propagate to the host serving
        /// the current request. A retry (with appropriate backoff logic) is the recommended response
        /// to this exception.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ResourceNotFoundException">
        /// Indicates that a requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ServiceQuotaExceededException">
        /// Indicates that the principal has crossed the permitted number of resources that can
        /// be created.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ThrottlingException">
        /// Indicates that the principal has crossed the throttling limits of the API operations.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ValidationException">
        /// The request failed because it contains a syntax error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/PutInlinePolicyToPermissionSet">REST API Reference for PutInlinePolicyToPermissionSet Operation</seealso>
        PutInlinePolicyToPermissionSetResponse PutInlinePolicyToPermissionSet(PutInlinePolicyToPermissionSetRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the PutInlinePolicyToPermissionSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutInlinePolicyToPermissionSet operation on AmazonSSOAdminClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutInlinePolicyToPermissionSet
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/PutInlinePolicyToPermissionSet">REST API Reference for PutInlinePolicyToPermissionSet Operation</seealso>
        IAsyncResult BeginPutInlinePolicyToPermissionSet(PutInlinePolicyToPermissionSetRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  PutInlinePolicyToPermissionSet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutInlinePolicyToPermissionSet.</param>
        /// 
        /// <returns>Returns a  PutInlinePolicyToPermissionSetResult from SSOAdmin.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/PutInlinePolicyToPermissionSet">REST API Reference for PutInlinePolicyToPermissionSet Operation</seealso>
        PutInlinePolicyToPermissionSetResponse EndPutInlinePolicyToPermissionSet(IAsyncResult asyncResult);

        #endregion
        
        #region  PutPermissionsBoundaryToPermissionSet


        /// <summary>
        /// Attaches an Amazon Web Services managed or customer managed policy to the specified
        /// <a>PermissionSet</a> as a permissions boundary.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutPermissionsBoundaryToPermissionSet service method.</param>
        /// 
        /// <returns>The response from the PutPermissionsBoundaryToPermissionSet service method, as returned by SSOAdmin.</returns>
        /// <exception cref="Amazon.SSOAdmin.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ConflictException">
        /// Occurs when a conflict with a previous successful write is detected. This generally
        /// occurs when the previous write did not have time to propagate to the host serving
        /// the current request. A retry (with appropriate backoff logic) is the recommended response
        /// to this exception.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ResourceNotFoundException">
        /// Indicates that a requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ThrottlingException">
        /// Indicates that the principal has crossed the throttling limits of the API operations.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ValidationException">
        /// The request failed because it contains a syntax error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/PutPermissionsBoundaryToPermissionSet">REST API Reference for PutPermissionsBoundaryToPermissionSet Operation</seealso>
        PutPermissionsBoundaryToPermissionSetResponse PutPermissionsBoundaryToPermissionSet(PutPermissionsBoundaryToPermissionSetRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the PutPermissionsBoundaryToPermissionSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutPermissionsBoundaryToPermissionSet operation on AmazonSSOAdminClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutPermissionsBoundaryToPermissionSet
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/PutPermissionsBoundaryToPermissionSet">REST API Reference for PutPermissionsBoundaryToPermissionSet Operation</seealso>
        IAsyncResult BeginPutPermissionsBoundaryToPermissionSet(PutPermissionsBoundaryToPermissionSetRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  PutPermissionsBoundaryToPermissionSet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutPermissionsBoundaryToPermissionSet.</param>
        /// 
        /// <returns>Returns a  PutPermissionsBoundaryToPermissionSetResult from SSOAdmin.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/PutPermissionsBoundaryToPermissionSet">REST API Reference for PutPermissionsBoundaryToPermissionSet Operation</seealso>
        PutPermissionsBoundaryToPermissionSetResponse EndPutPermissionsBoundaryToPermissionSet(IAsyncResult asyncResult);

        #endregion
        
        #region  RemoveRegion


        /// <summary>
        /// Removes an additional Region from an IAM Identity Center instance. This operation
        /// initiates an asynchronous workflow to clean up IAM Identity Center resources in the
        /// specified additional Region. The Region status is set to REMOVING and the Region record
        /// is deleted when the workflow completes. The request must be made from the primary
        /// Region. The target Region cannot be the primary Region, and no other add or remove
        /// Region workflows can be in progress.
        /// 
        ///  
        /// <para>
        /// The following actions are related to <c>RemoveRegion</c>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/singlesignon/latest/APIReference/API_AddRegion.html">
        /// AddRegion</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/singlesignon/latest/APIReference/API_DescribeRegion.html">DescribeRegion</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/singlesignon/latest/APIReference/API_ListRegions.html">ListRegions</a>
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemoveRegion service method.</param>
        /// 
        /// <returns>The response from the RemoveRegion service method, as returned by SSOAdmin.</returns>
        /// <exception cref="Amazon.SSOAdmin.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ConflictException">
        /// Occurs when a conflict with a previous successful write is detected. This generally
        /// occurs when the previous write did not have time to propagate to the host serving
        /// the current request. A retry (with appropriate backoff logic) is the recommended response
        /// to this exception.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ResourceNotFoundException">
        /// Indicates that a requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ThrottlingException">
        /// Indicates that the principal has crossed the throttling limits of the API operations.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ValidationException">
        /// The request failed because it contains a syntax error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/RemoveRegion">REST API Reference for RemoveRegion Operation</seealso>
        RemoveRegionResponse RemoveRegion(RemoveRegionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the RemoveRegion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RemoveRegion operation on AmazonSSOAdminClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRemoveRegion
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/RemoveRegion">REST API Reference for RemoveRegion Operation</seealso>
        IAsyncResult BeginRemoveRegion(RemoveRegionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  RemoveRegion operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRemoveRegion.</param>
        /// 
        /// <returns>Returns a  RemoveRegionResult from SSOAdmin.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/RemoveRegion">REST API Reference for RemoveRegion Operation</seealso>
        RemoveRegionResponse EndRemoveRegion(IAsyncResult asyncResult);

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Associates a set of tags with a specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by SSOAdmin.</returns>
        /// <exception cref="Amazon.SSOAdmin.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ConflictException">
        /// Occurs when a conflict with a previous successful write is detected. This generally
        /// occurs when the previous write did not have time to propagate to the host serving
        /// the current request. A retry (with appropriate backoff logic) is the recommended response
        /// to this exception.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ResourceNotFoundException">
        /// Indicates that a requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ServiceQuotaExceededException">
        /// Indicates that the principal has crossed the permitted number of resources that can
        /// be created.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ThrottlingException">
        /// Indicates that the principal has crossed the throttling limits of the API operations.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ValidationException">
        /// The request failed because it contains a syntax error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse TagResource(TagResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the TagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonSSOAdminClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/TagResource">REST API Reference for TagResource Operation</seealso>
        IAsyncResult BeginTagResource(TagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  TagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTagResource.</param>
        /// 
        /// <returns>Returns a  TagResourceResult from SSOAdmin.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse EndTagResource(IAsyncResult asyncResult);

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// Disassociates a set of tags from a specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by SSOAdmin.</returns>
        /// <exception cref="Amazon.SSOAdmin.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ConflictException">
        /// Occurs when a conflict with a previous successful write is detected. This generally
        /// occurs when the previous write did not have time to propagate to the host serving
        /// the current request. A retry (with appropriate backoff logic) is the recommended response
        /// to this exception.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ResourceNotFoundException">
        /// Indicates that a requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ThrottlingException">
        /// Indicates that the principal has crossed the throttling limits of the API operations.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ValidationException">
        /// The request failed because it contains a syntax error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse UntagResource(UntagResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UntagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonSSOAdminClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/UntagResource">REST API Reference for UntagResource Operation</seealso>
        IAsyncResult BeginUntagResource(UntagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UntagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUntagResource.</param>
        /// 
        /// <returns>Returns a  UntagResourceResult from SSOAdmin.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse EndUntagResource(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateApplication


        /// <summary>
        /// Updates application properties.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateApplication service method.</param>
        /// 
        /// <returns>The response from the UpdateApplication service method, as returned by SSOAdmin.</returns>
        /// <exception cref="Amazon.SSOAdmin.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ConflictException">
        /// Occurs when a conflict with a previous successful write is detected. This generally
        /// occurs when the previous write did not have time to propagate to the host serving
        /// the current request. A retry (with appropriate backoff logic) is the recommended response
        /// to this exception.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ResourceNotFoundException">
        /// Indicates that a requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ThrottlingException">
        /// Indicates that the principal has crossed the throttling limits of the API operations.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ValidationException">
        /// The request failed because it contains a syntax error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/UpdateApplication">REST API Reference for UpdateApplication Operation</seealso>
        UpdateApplicationResponse UpdateApplication(UpdateApplicationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateApplication operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateApplication operation on AmazonSSOAdminClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateApplication
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/UpdateApplication">REST API Reference for UpdateApplication Operation</seealso>
        IAsyncResult BeginUpdateApplication(UpdateApplicationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateApplication operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateApplication.</param>
        /// 
        /// <returns>Returns a  UpdateApplicationResult from SSOAdmin.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/UpdateApplication">REST API Reference for UpdateApplication Operation</seealso>
        UpdateApplicationResponse EndUpdateApplication(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateInstance


        /// <summary>
        /// Update the details for the instance of IAM Identity Center that is owned by the Amazon
        /// Web Services account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateInstance service method.</param>
        /// 
        /// <returns>The response from the UpdateInstance service method, as returned by SSOAdmin.</returns>
        /// <exception cref="Amazon.SSOAdmin.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ConflictException">
        /// Occurs when a conflict with a previous successful write is detected. This generally
        /// occurs when the previous write did not have time to propagate to the host serving
        /// the current request. A retry (with appropriate backoff logic) is the recommended response
        /// to this exception.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ResourceNotFoundException">
        /// Indicates that a requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ThrottlingException">
        /// Indicates that the principal has crossed the throttling limits of the API operations.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ValidationException">
        /// The request failed because it contains a syntax error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/UpdateInstance">REST API Reference for UpdateInstance Operation</seealso>
        UpdateInstanceResponse UpdateInstance(UpdateInstanceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateInstance operation on AmazonSSOAdminClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateInstance
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/UpdateInstance">REST API Reference for UpdateInstance Operation</seealso>
        IAsyncResult BeginUpdateInstance(UpdateInstanceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateInstance operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateInstance.</param>
        /// 
        /// <returns>Returns a  UpdateInstanceResult from SSOAdmin.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/UpdateInstance">REST API Reference for UpdateInstance Operation</seealso>
        UpdateInstanceResponse EndUpdateInstance(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateInstanceAccessControlAttributeConfiguration


        /// <summary>
        /// Updates the IAM Identity Center identity store attributes that you can use with the
        /// IAM Identity Center instance for attributes-based access control (ABAC). When using
        /// an external identity provider as an identity source, you can pass attributes through
        /// the SAML assertion as an alternative to configuring attributes from the IAM Identity
        /// Center identity store. If a SAML assertion passes any of these attributes, IAM Identity
        /// Center replaces the attribute value with the value from the IAM Identity Center identity
        /// store. For more information about ABAC, see <a href="/singlesignon/latest/userguide/abac.html">Attribute-Based
        /// Access Control</a> in the <i>IAM Identity Center User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateInstanceAccessControlAttributeConfiguration service method.</param>
        /// 
        /// <returns>The response from the UpdateInstanceAccessControlAttributeConfiguration service method, as returned by SSOAdmin.</returns>
        /// <exception cref="Amazon.SSOAdmin.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ConflictException">
        /// Occurs when a conflict with a previous successful write is detected. This generally
        /// occurs when the previous write did not have time to propagate to the host serving
        /// the current request. A retry (with appropriate backoff logic) is the recommended response
        /// to this exception.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ResourceNotFoundException">
        /// Indicates that a requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ThrottlingException">
        /// Indicates that the principal has crossed the throttling limits of the API operations.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ValidationException">
        /// The request failed because it contains a syntax error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/UpdateInstanceAccessControlAttributeConfiguration">REST API Reference for UpdateInstanceAccessControlAttributeConfiguration Operation</seealso>
        UpdateInstanceAccessControlAttributeConfigurationResponse UpdateInstanceAccessControlAttributeConfiguration(UpdateInstanceAccessControlAttributeConfigurationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateInstanceAccessControlAttributeConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateInstanceAccessControlAttributeConfiguration operation on AmazonSSOAdminClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateInstanceAccessControlAttributeConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/UpdateInstanceAccessControlAttributeConfiguration">REST API Reference for UpdateInstanceAccessControlAttributeConfiguration Operation</seealso>
        IAsyncResult BeginUpdateInstanceAccessControlAttributeConfiguration(UpdateInstanceAccessControlAttributeConfigurationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateInstanceAccessControlAttributeConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateInstanceAccessControlAttributeConfiguration.</param>
        /// 
        /// <returns>Returns a  UpdateInstanceAccessControlAttributeConfigurationResult from SSOAdmin.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/UpdateInstanceAccessControlAttributeConfiguration">REST API Reference for UpdateInstanceAccessControlAttributeConfiguration Operation</seealso>
        UpdateInstanceAccessControlAttributeConfigurationResponse EndUpdateInstanceAccessControlAttributeConfiguration(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdatePermissionSet


        /// <summary>
        /// Updates an existing permission set.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdatePermissionSet service method.</param>
        /// 
        /// <returns>The response from the UpdatePermissionSet service method, as returned by SSOAdmin.</returns>
        /// <exception cref="Amazon.SSOAdmin.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ConflictException">
        /// Occurs when a conflict with a previous successful write is detected. This generally
        /// occurs when the previous write did not have time to propagate to the host serving
        /// the current request. A retry (with appropriate backoff logic) is the recommended response
        /// to this exception.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ResourceNotFoundException">
        /// Indicates that a requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ThrottlingException">
        /// Indicates that the principal has crossed the throttling limits of the API operations.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ValidationException">
        /// The request failed because it contains a syntax error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/UpdatePermissionSet">REST API Reference for UpdatePermissionSet Operation</seealso>
        UpdatePermissionSetResponse UpdatePermissionSet(UpdatePermissionSetRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdatePermissionSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdatePermissionSet operation on AmazonSSOAdminClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdatePermissionSet
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/UpdatePermissionSet">REST API Reference for UpdatePermissionSet Operation</seealso>
        IAsyncResult BeginUpdatePermissionSet(UpdatePermissionSetRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdatePermissionSet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdatePermissionSet.</param>
        /// 
        /// <returns>Returns a  UpdatePermissionSetResult from SSOAdmin.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/UpdatePermissionSet">REST API Reference for UpdatePermissionSet Operation</seealso>
        UpdatePermissionSetResponse EndUpdatePermissionSet(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateTrustedTokenIssuer


        /// <summary>
        /// Updates the name of the trusted token issuer, or the path of a source attribute or
        /// destination attribute for a trusted token issuer configuration.
        /// 
        ///  <note> 
        /// <para>
        /// Updating this trusted token issuer configuration might cause users to lose access
        /// to any applications that are configured to use the trusted token issuer.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateTrustedTokenIssuer service method.</param>
        /// 
        /// <returns>The response from the UpdateTrustedTokenIssuer service method, as returned by SSOAdmin.</returns>
        /// <exception cref="Amazon.SSOAdmin.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ConflictException">
        /// Occurs when a conflict with a previous successful write is detected. This generally
        /// occurs when the previous write did not have time to propagate to the host serving
        /// the current request. A retry (with appropriate backoff logic) is the recommended response
        /// to this exception.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ResourceNotFoundException">
        /// Indicates that a requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ThrottlingException">
        /// Indicates that the principal has crossed the throttling limits of the API operations.
        /// </exception>
        /// <exception cref="Amazon.SSOAdmin.Model.ValidationException">
        /// The request failed because it contains a syntax error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/UpdateTrustedTokenIssuer">REST API Reference for UpdateTrustedTokenIssuer Operation</seealso>
        UpdateTrustedTokenIssuerResponse UpdateTrustedTokenIssuer(UpdateTrustedTokenIssuerRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateTrustedTokenIssuer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateTrustedTokenIssuer operation on AmazonSSOAdminClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateTrustedTokenIssuer
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/UpdateTrustedTokenIssuer">REST API Reference for UpdateTrustedTokenIssuer Operation</seealso>
        IAsyncResult BeginUpdateTrustedTokenIssuer(UpdateTrustedTokenIssuerRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateTrustedTokenIssuer operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateTrustedTokenIssuer.</param>
        /// 
        /// <returns>Returns a  UpdateTrustedTokenIssuerResult from SSOAdmin.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sso-admin-2020-07-20/UpdateTrustedTokenIssuer">REST API Reference for UpdateTrustedTokenIssuer Operation</seealso>
        UpdateTrustedTokenIssuerResponse EndUpdateTrustedTokenIssuer(IAsyncResult asyncResult);

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