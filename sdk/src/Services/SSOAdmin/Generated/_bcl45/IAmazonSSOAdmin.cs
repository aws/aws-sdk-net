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
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.SSOAdmin.Model;

namespace Amazon.SSOAdmin
{
    /// <summary>
    /// Interface for accessing SSOAdmin
    ///
    /// 
    /// </summary>
    public partial interface IAmazonSSOAdmin : IAmazonService, IDisposable
    {

        /// <summary>
        /// Paginators for the service
        /// </summary>
        ISSOAdminPaginatorFactory Paginators { get; }

        
        #region  AttachManagedPolicyToPermissionSet


        /// <summary>
        /// Attaches an IAM managed policy ARN to a permission set.
        /// 
        ///  <note> 
        /// <para>
        /// If the permission set is already referenced by one or more account assignments, you
        /// will need to call <code> <a>ProvisionPermissionSet</a> </code> after this action to
        /// apply the corresponding IAM policy updates to all assigned accounts.
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
        /// Attaches an IAM managed policy ARN to a permission set.
        /// 
        ///  <note> 
        /// <para>
        /// If the permission set is already referenced by one or more account assignments, you
        /// will need to call <code> <a>ProvisionPermissionSet</a> </code> after this action to
        /// apply the corresponding IAM policy updates to all assigned accounts.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AttachManagedPolicyToPermissionSet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<AttachManagedPolicyToPermissionSetResponse> AttachManagedPolicyToPermissionSetAsync(AttachManagedPolicyToPermissionSetRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateAccountAssignment


        /// <summary>
        /// Assigns access to a principal for a specified AWS account using a specified permission
        /// set.
        /// 
        ///  <note> 
        /// <para>
        /// The term <i>principal</i> here refers to a user or group that is defined in AWS SSO.
        /// </para>
        ///  </note> <note> 
        /// <para>
        /// As part of a successful <code>CreateAccountAssignment</code> call, the specified permission
        /// set will automatically be provisioned to the account in the form of an IAM policy
        /// attached to the SSO-created IAM role. If the permission set is subsequently updated,
        /// the corresponding IAM policies attached to roles in your accounts will not be updated
        /// automatically. In this case, you will need to call <code> <a>ProvisionPermissionSet</a>
        /// </code> to make these updates.
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
        /// Assigns access to a principal for a specified AWS account using a specified permission
        /// set.
        /// 
        ///  <note> 
        /// <para>
        /// The term <i>principal</i> here refers to a user or group that is defined in AWS SSO.
        /// </para>
        ///  </note> <note> 
        /// <para>
        /// As part of a successful <code>CreateAccountAssignment</code> call, the specified permission
        /// set will automatically be provisioned to the account in the form of an IAM policy
        /// attached to the SSO-created IAM role. If the permission set is subsequently updated,
        /// the corresponding IAM policies attached to roles in your accounts will not be updated
        /// automatically. In this case, you will need to call <code> <a>ProvisionPermissionSet</a>
        /// </code> to make these updates.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAccountAssignment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<CreateAccountAssignmentResponse> CreateAccountAssignmentAsync(CreateAccountAssignmentRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateInstanceAccessControlAttributeConfiguration


        /// <summary>
        /// Enables the attributes-based access control (ABAC) feature for the specified AWS SSO
        /// instance. You can also specify new attributes to add to your ABAC configuration during
        /// the enabling process. For more information about ABAC, see <a href="/singlesignon/latest/userguide/abac.html">Attribute-Based
        /// Access Control</a> in the <i>AWS SSO User Guide</i>.
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
        /// Enables the attributes-based access control (ABAC) feature for the specified AWS SSO
        /// instance. You can also specify new attributes to add to your ABAC configuration during
        /// the enabling process. For more information about ABAC, see <a href="/singlesignon/latest/userguide/abac.html">Attribute-Based
        /// Access Control</a> in the <i>AWS SSO User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateInstanceAccessControlAttributeConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<CreateInstanceAccessControlAttributeConfigurationResponse> CreateInstanceAccessControlAttributeConfigurationAsync(CreateInstanceAccessControlAttributeConfigurationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreatePermissionSet


        /// <summary>
        /// Creates a permission set within a specified SSO instance.
        /// 
        ///  <note> 
        /// <para>
        /// To grant users and groups access to AWS account resources, use <code> <a>CreateAccountAssignment</a>
        /// </code>.
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
        /// Creates a permission set within a specified SSO instance.
        /// 
        ///  <note> 
        /// <para>
        /// To grant users and groups access to AWS account resources, use <code> <a>CreateAccountAssignment</a>
        /// </code>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePermissionSet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<CreatePermissionSetResponse> CreatePermissionSetAsync(CreatePermissionSetRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteAccountAssignment


        /// <summary>
        /// Deletes a principal's access from a specified AWS account using a specified permission
        /// set.
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
        /// Deletes a principal's access from a specified AWS account using a specified permission
        /// set.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAccountAssignment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DeleteAccountAssignmentResponse> DeleteAccountAssignmentAsync(DeleteAccountAssignmentRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Deletes the inline policy from a specified permission set.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteInlinePolicyFromPermissionSet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DeleteInlinePolicyFromPermissionSetResponse> DeleteInlinePolicyFromPermissionSetAsync(DeleteInlinePolicyFromPermissionSetRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteInstanceAccessControlAttributeConfiguration


        /// <summary>
        /// Disables the attributes-based access control (ABAC) feature for the specified AWS
        /// SSO instance and deletes all of the attribute mappings that have been configured.
        /// Once deleted, any attributes that are received from an identity source and any custom
        /// attributes you have previously configured will not be passed. For more information
        /// about ABAC, see <a href="/singlesignon/latest/userguide/abac.html">Attribute-Based
        /// Access Control</a> in the <i>AWS SSO User Guide</i>.
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
        /// Disables the attributes-based access control (ABAC) feature for the specified AWS
        /// SSO instance and deletes all of the attribute mappings that have been configured.
        /// Once deleted, any attributes that are received from an identity source and any custom
        /// attributes you have previously configured will not be passed. For more information
        /// about ABAC, see <a href="/singlesignon/latest/userguide/abac.html">Attribute-Based
        /// Access Control</a> in the <i>AWS SSO User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteInstanceAccessControlAttributeConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DeleteInstanceAccessControlAttributeConfigurationResponse> DeleteInstanceAccessControlAttributeConfigurationAsync(DeleteInstanceAccessControlAttributeConfigurationRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Deletes the specified permission set.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePermissionSet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DeletePermissionSetResponse> DeletePermissionSetAsync(DeletePermissionSetRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Describes the status of the assignment creation request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAccountAssignmentCreationStatus service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DescribeAccountAssignmentCreationStatusResponse> DescribeAccountAssignmentCreationStatusAsync(DescribeAccountAssignmentCreationStatusRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Describes the status of the assignment deletion request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAccountAssignmentDeletionStatus service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DescribeAccountAssignmentDeletionStatusResponse> DescribeAccountAssignmentDeletionStatusAsync(DescribeAccountAssignmentDeletionStatusRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeInstanceAccessControlAttributeConfiguration


        /// <summary>
        /// Returns the list of AWS SSO identity store attributes that have been configured to
        /// work with attributes-based access control (ABAC) for the specified AWS SSO instance.
        /// This will not return attributes configured and sent by an external identity provider.
        /// For more information about ABAC, see <a href="/singlesignon/latest/userguide/abac.html">Attribute-Based
        /// Access Control</a> in the <i>AWS SSO User Guide</i>.
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
        /// Returns the list of AWS SSO identity store attributes that have been configured to
        /// work with attributes-based access control (ABAC) for the specified AWS SSO instance.
        /// This will not return attributes configured and sent by an external identity provider.
        /// For more information about ABAC, see <a href="/singlesignon/latest/userguide/abac.html">Attribute-Based
        /// Access Control</a> in the <i>AWS SSO User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeInstanceAccessControlAttributeConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DescribeInstanceAccessControlAttributeConfigurationResponse> DescribeInstanceAccessControlAttributeConfigurationAsync(DescribeInstanceAccessControlAttributeConfigurationRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Gets the details of the permission set.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribePermissionSet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DescribePermissionSetResponse> DescribePermissionSetAsync(DescribePermissionSetRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Describes the status for the given permission set provisioning request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribePermissionSetProvisioningStatus service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DescribePermissionSetProvisioningStatusResponse> DescribePermissionSetProvisioningStatusAsync(DescribePermissionSetProvisioningStatusRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DetachManagedPolicyFromPermissionSet


        /// <summary>
        /// Detaches the attached IAM managed policy ARN from the specified permission set.
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
        /// Detaches the attached IAM managed policy ARN from the specified permission set.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DetachManagedPolicyFromPermissionSet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DetachManagedPolicyFromPermissionSetResponse> DetachManagedPolicyFromPermissionSetAsync(DetachManagedPolicyFromPermissionSetRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Obtains the inline policy assigned to the permission set.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetInlinePolicyForPermissionSet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<GetInlinePolicyForPermissionSetResponse> GetInlinePolicyForPermissionSetAsync(GetInlinePolicyForPermissionSetRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListAccountAssignmentCreationStatus


        /// <summary>
        /// Lists the status of the AWS account assignment creation requests for a specified SSO
        /// instance.
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
        /// Lists the status of the AWS account assignment creation requests for a specified SSO
        /// instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAccountAssignmentCreationStatus service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListAccountAssignmentCreationStatusResponse> ListAccountAssignmentCreationStatusAsync(ListAccountAssignmentCreationStatusRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListAccountAssignmentDeletionStatus


        /// <summary>
        /// Lists the status of the AWS account assignment deletion requests for a specified SSO
        /// instance.
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
        /// Lists the status of the AWS account assignment deletion requests for a specified SSO
        /// instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAccountAssignmentDeletionStatus service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListAccountAssignmentDeletionStatusResponse> ListAccountAssignmentDeletionStatusAsync(ListAccountAssignmentDeletionStatusRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListAccountAssignments


        /// <summary>
        /// Lists the assignee of the specified AWS account with the specified permission set.
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
        /// Lists the assignee of the specified AWS account with the specified permission set.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAccountAssignments service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListAccountAssignmentsResponse> ListAccountAssignmentsAsync(ListAccountAssignmentsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListAccountsForProvisionedPermissionSet


        /// <summary>
        /// Lists all the AWS accounts where the specified permission set is provisioned.
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
        /// Lists all the AWS accounts where the specified permission set is provisioned.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAccountsForProvisionedPermissionSet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListAccountsForProvisionedPermissionSetResponse> ListAccountsForProvisionedPermissionSetAsync(ListAccountsForProvisionedPermissionSetRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListInstances


        /// <summary>
        /// Lists the SSO instances that the caller has access to.
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
        /// Lists the SSO instances that the caller has access to.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListInstances service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListInstancesResponse> ListInstancesAsync(ListInstancesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListManagedPoliciesInPermissionSet


        /// <summary>
        /// Lists the IAM managed policy that is attached to a specified permission set.
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
        /// Lists the IAM managed policy that is attached to a specified permission set.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListManagedPoliciesInPermissionSet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListManagedPoliciesInPermissionSetResponse> ListManagedPoliciesInPermissionSetAsync(ListManagedPoliciesInPermissionSetRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListPermissionSetProvisioningStatus


        /// <summary>
        /// Lists the status of the permission set provisioning requests for a specified SSO instance.
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
        /// Lists the status of the permission set provisioning requests for a specified SSO instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPermissionSetProvisioningStatus service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListPermissionSetProvisioningStatusResponse> ListPermissionSetProvisioningStatusAsync(ListPermissionSetProvisioningStatusRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListPermissionSets


        /// <summary>
        /// Lists the <a>PermissionSet</a>s in an SSO instance.
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
        /// Lists the <a>PermissionSet</a>s in an SSO instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPermissionSets service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListPermissionSetsResponse> ListPermissionSetsAsync(ListPermissionSetsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListPermissionSetsProvisionedToAccount


        /// <summary>
        /// Lists all the permission sets that are provisioned to a specified AWS account.
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
        /// Lists all the permission sets that are provisioned to a specified AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPermissionSetsProvisionedToAccount service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListPermissionSetsProvisionedToAccountResponse> ListPermissionSetsProvisionedToAccountAsync(ListPermissionSetsProvisionedToAccountRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Lists the tags that are attached to a specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// The process by which a specified permission set is provisioned to the specified target.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ProvisionPermissionSet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ProvisionPermissionSetResponse> ProvisionPermissionSetAsync(ProvisionPermissionSetRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  PutInlinePolicyToPermissionSet


        /// <summary>
        /// Attaches an IAM inline policy to a permission set.
        /// 
        ///  <note> 
        /// <para>
        /// If the permission set is already referenced by one or more account assignments, you
        /// will need to call <code> <a>ProvisionPermissionSet</a> </code> after this action to
        /// apply the corresponding IAM policy updates to all assigned accounts.
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
        /// Attaches an IAM inline policy to a permission set.
        /// 
        ///  <note> 
        /// <para>
        /// If the permission set is already referenced by one or more account assignments, you
        /// will need to call <code> <a>ProvisionPermissionSet</a> </code> after this action to
        /// apply the corresponding IAM policy updates to all assigned accounts.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutInlinePolicyToPermissionSet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<PutInlinePolicyToPermissionSetResponse> PutInlinePolicyToPermissionSetAsync(PutInlinePolicyToPermissionSetRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Associates a set of tags with a specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Disassociates a set of tags from a specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateInstanceAccessControlAttributeConfiguration


        /// <summary>
        /// Updates the AWS SSO identity store attributes to use with the AWS SSO instance for
        /// attributes-based access control (ABAC). When using an external identity provider as
        /// an identity source, you can pass attributes through the SAML assertion as an alternative
        /// to configuring attributes from the AWS SSO identity store. If a SAML assertion passes
        /// any of these attributes, AWS SSO will replace the attribute value with the value from
        /// the AWS SSO identity store. For more information about ABAC, see <a href="/singlesignon/latest/userguide/abac.html">Attribute-Based
        /// Access Control</a> in the <i>AWS SSO User Guide</i>.
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
        /// Updates the AWS SSO identity store attributes to use with the AWS SSO instance for
        /// attributes-based access control (ABAC). When using an external identity provider as
        /// an identity source, you can pass attributes through the SAML assertion as an alternative
        /// to configuring attributes from the AWS SSO identity store. If a SAML assertion passes
        /// any of these attributes, AWS SSO will replace the attribute value with the value from
        /// the AWS SSO identity store. For more information about ABAC, see <a href="/singlesignon/latest/userguide/abac.html">Attribute-Based
        /// Access Control</a> in the <i>AWS SSO User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateInstanceAccessControlAttributeConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<UpdateInstanceAccessControlAttributeConfigurationResponse> UpdateInstanceAccessControlAttributeConfigurationAsync(UpdateInstanceAccessControlAttributeConfigurationRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Updates an existing permission set.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdatePermissionSet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<UpdatePermissionSetResponse> UpdatePermissionSetAsync(UpdatePermissionSetRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}