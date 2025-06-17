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
 * Do not modify this file. This file is generated from the inspector2-2020-06-08.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.Inspector2.Model;

#pragma warning disable CS1570
namespace Amazon.Inspector2
{
    /// <summary>
    /// <para>Interface for accessing Inspector2</para>
    ///
    /// Amazon Inspector is a vulnerability discovery service that automates continuous scanning
    /// for security vulnerabilities within your Amazon EC2, Amazon ECR, and Amazon Web Services
    /// Lambda environments.
    /// </summary>
    public partial interface IAmazonInspector2 : IAmazonService, IDisposable
    {

        /// <summary>
        /// Paginators for the service
        /// </summary>
        IInspector2PaginatorFactory Paginators { get; }

        
        #region  AssociateMember


        /// <summary>
        /// Associates an Amazon Web Services account with an Amazon Inspector delegated administrator.
        /// An HTTP 200 response indicates the association was successfully started, but doesn’t
        /// indicate whether it was completed. You can check if the association completed by using
        /// <a href="https://docs.aws.amazon.com/inspector/v2/APIReference/API_ListMembers.html">ListMembers</a>
        /// for multiple accounts or <a href="https://docs.aws.amazon.com/inspector/v2/APIReference/API_GetMember.html">GetMembers</a>
        /// for a single account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateMember service method.</param>
        /// 
        /// <returns>The response from the AssociateMember service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ServiceQuotaExceededException">
        /// You have exceeded your service quota. To perform the requested action, remove some
        /// of the relevant resources, or use Service Quotas to request a service quota increase.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/AssociateMember">REST API Reference for AssociateMember Operation</seealso>
        AssociateMemberResponse AssociateMember(AssociateMemberRequest request);



        /// <summary>
        /// Associates an Amazon Web Services account with an Amazon Inspector delegated administrator.
        /// An HTTP 200 response indicates the association was successfully started, but doesn’t
        /// indicate whether it was completed. You can check if the association completed by using
        /// <a href="https://docs.aws.amazon.com/inspector/v2/APIReference/API_ListMembers.html">ListMembers</a>
        /// for multiple accounts or <a href="https://docs.aws.amazon.com/inspector/v2/APIReference/API_GetMember.html">GetMembers</a>
        /// for a single account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateMember service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AssociateMember service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ServiceQuotaExceededException">
        /// You have exceeded your service quota. To perform the requested action, remove some
        /// of the relevant resources, or use Service Quotas to request a service quota increase.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/AssociateMember">REST API Reference for AssociateMember Operation</seealso>
        Task<AssociateMemberResponse> AssociateMemberAsync(AssociateMemberRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  BatchAssociateCodeSecurityScanConfiguration


        /// <summary>
        /// Associates multiple code repositories with an Amazon Inspector code security scan
        /// configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchAssociateCodeSecurityScanConfiguration service method.</param>
        /// 
        /// <returns>The response from the BatchAssociateCodeSecurityScanConfiguration service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ConflictException">
        /// A conflict occurred. This exception occurs when the same resource is being modified
        /// by concurrent requests.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ResourceNotFoundException">
        /// The operation tried to access an invalid resource. Make sure the resource is specified
        /// correctly.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/BatchAssociateCodeSecurityScanConfiguration">REST API Reference for BatchAssociateCodeSecurityScanConfiguration Operation</seealso>
        BatchAssociateCodeSecurityScanConfigurationResponse BatchAssociateCodeSecurityScanConfiguration(BatchAssociateCodeSecurityScanConfigurationRequest request);



        /// <summary>
        /// Associates multiple code repositories with an Amazon Inspector code security scan
        /// configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchAssociateCodeSecurityScanConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchAssociateCodeSecurityScanConfiguration service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ConflictException">
        /// A conflict occurred. This exception occurs when the same resource is being modified
        /// by concurrent requests.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ResourceNotFoundException">
        /// The operation tried to access an invalid resource. Make sure the resource is specified
        /// correctly.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/BatchAssociateCodeSecurityScanConfiguration">REST API Reference for BatchAssociateCodeSecurityScanConfiguration Operation</seealso>
        Task<BatchAssociateCodeSecurityScanConfigurationResponse> BatchAssociateCodeSecurityScanConfigurationAsync(BatchAssociateCodeSecurityScanConfigurationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  BatchDisassociateCodeSecurityScanConfiguration


        /// <summary>
        /// Disassociates multiple code repositories from an Amazon Inspector code security scan
        /// configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchDisassociateCodeSecurityScanConfiguration service method.</param>
        /// 
        /// <returns>The response from the BatchDisassociateCodeSecurityScanConfiguration service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ConflictException">
        /// A conflict occurred. This exception occurs when the same resource is being modified
        /// by concurrent requests.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ResourceNotFoundException">
        /// The operation tried to access an invalid resource. Make sure the resource is specified
        /// correctly.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/BatchDisassociateCodeSecurityScanConfiguration">REST API Reference for BatchDisassociateCodeSecurityScanConfiguration Operation</seealso>
        BatchDisassociateCodeSecurityScanConfigurationResponse BatchDisassociateCodeSecurityScanConfiguration(BatchDisassociateCodeSecurityScanConfigurationRequest request);



        /// <summary>
        /// Disassociates multiple code repositories from an Amazon Inspector code security scan
        /// configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchDisassociateCodeSecurityScanConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchDisassociateCodeSecurityScanConfiguration service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ConflictException">
        /// A conflict occurred. This exception occurs when the same resource is being modified
        /// by concurrent requests.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ResourceNotFoundException">
        /// The operation tried to access an invalid resource. Make sure the resource is specified
        /// correctly.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/BatchDisassociateCodeSecurityScanConfiguration">REST API Reference for BatchDisassociateCodeSecurityScanConfiguration Operation</seealso>
        Task<BatchDisassociateCodeSecurityScanConfigurationResponse> BatchDisassociateCodeSecurityScanConfigurationAsync(BatchDisassociateCodeSecurityScanConfigurationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  BatchGetAccountStatus


        /// <summary>
        /// Retrieves the Amazon Inspector status of multiple Amazon Web Services accounts within
        /// your environment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetAccountStatus service method.</param>
        /// 
        /// <returns>The response from the BatchGetAccountStatus service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ResourceNotFoundException">
        /// The operation tried to access an invalid resource. Make sure the resource is specified
        /// correctly.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/BatchGetAccountStatus">REST API Reference for BatchGetAccountStatus Operation</seealso>
        BatchGetAccountStatusResponse BatchGetAccountStatus(BatchGetAccountStatusRequest request);



        /// <summary>
        /// Retrieves the Amazon Inspector status of multiple Amazon Web Services accounts within
        /// your environment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetAccountStatus service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchGetAccountStatus service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ResourceNotFoundException">
        /// The operation tried to access an invalid resource. Make sure the resource is specified
        /// correctly.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/BatchGetAccountStatus">REST API Reference for BatchGetAccountStatus Operation</seealso>
        Task<BatchGetAccountStatusResponse> BatchGetAccountStatusAsync(BatchGetAccountStatusRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  BatchGetCodeSnippet


        /// <summary>
        /// Retrieves code snippets from findings that Amazon Inspector detected code vulnerabilities
        /// in.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetCodeSnippet service method.</param>
        /// 
        /// <returns>The response from the BatchGetCodeSnippet service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/BatchGetCodeSnippet">REST API Reference for BatchGetCodeSnippet Operation</seealso>
        BatchGetCodeSnippetResponse BatchGetCodeSnippet(BatchGetCodeSnippetRequest request);



        /// <summary>
        /// Retrieves code snippets from findings that Amazon Inspector detected code vulnerabilities
        /// in.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetCodeSnippet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchGetCodeSnippet service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/BatchGetCodeSnippet">REST API Reference for BatchGetCodeSnippet Operation</seealso>
        Task<BatchGetCodeSnippetResponse> BatchGetCodeSnippetAsync(BatchGetCodeSnippetRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  BatchGetFindingDetails


        /// <summary>
        /// Gets vulnerability details for findings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetFindingDetails service method.</param>
        /// 
        /// <returns>The response from the BatchGetFindingDetails service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/BatchGetFindingDetails">REST API Reference for BatchGetFindingDetails Operation</seealso>
        BatchGetFindingDetailsResponse BatchGetFindingDetails(BatchGetFindingDetailsRequest request);



        /// <summary>
        /// Gets vulnerability details for findings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetFindingDetails service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchGetFindingDetails service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/BatchGetFindingDetails">REST API Reference for BatchGetFindingDetails Operation</seealso>
        Task<BatchGetFindingDetailsResponse> BatchGetFindingDetailsAsync(BatchGetFindingDetailsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  BatchGetFreeTrialInfo


        /// <summary>
        /// Gets free trial status for multiple Amazon Web Services accounts.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetFreeTrialInfo service method.</param>
        /// 
        /// <returns>The response from the BatchGetFreeTrialInfo service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/BatchGetFreeTrialInfo">REST API Reference for BatchGetFreeTrialInfo Operation</seealso>
        BatchGetFreeTrialInfoResponse BatchGetFreeTrialInfo(BatchGetFreeTrialInfoRequest request);



        /// <summary>
        /// Gets free trial status for multiple Amazon Web Services accounts.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetFreeTrialInfo service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchGetFreeTrialInfo service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/BatchGetFreeTrialInfo">REST API Reference for BatchGetFreeTrialInfo Operation</seealso>
        Task<BatchGetFreeTrialInfoResponse> BatchGetFreeTrialInfoAsync(BatchGetFreeTrialInfoRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  BatchGetMemberEc2DeepInspectionStatus


        /// <summary>
        /// Retrieves Amazon Inspector deep inspection activation status of multiple member accounts
        /// within your organization. You must be the delegated administrator of an organization
        /// in Amazon Inspector to use this API.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetMemberEc2DeepInspectionStatus service method.</param>
        /// 
        /// <returns>The response from the BatchGetMemberEc2DeepInspectionStatus service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/BatchGetMemberEc2DeepInspectionStatus">REST API Reference for BatchGetMemberEc2DeepInspectionStatus Operation</seealso>
        BatchGetMemberEc2DeepInspectionStatusResponse BatchGetMemberEc2DeepInspectionStatus(BatchGetMemberEc2DeepInspectionStatusRequest request);



        /// <summary>
        /// Retrieves Amazon Inspector deep inspection activation status of multiple member accounts
        /// within your organization. You must be the delegated administrator of an organization
        /// in Amazon Inspector to use this API.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetMemberEc2DeepInspectionStatus service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchGetMemberEc2DeepInspectionStatus service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/BatchGetMemberEc2DeepInspectionStatus">REST API Reference for BatchGetMemberEc2DeepInspectionStatus Operation</seealso>
        Task<BatchGetMemberEc2DeepInspectionStatusResponse> BatchGetMemberEc2DeepInspectionStatusAsync(BatchGetMemberEc2DeepInspectionStatusRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  BatchUpdateMemberEc2DeepInspectionStatus


        /// <summary>
        /// Activates or deactivates Amazon Inspector deep inspection for the provided member
        /// accounts in your organization. You must be the delegated administrator of an organization
        /// in Amazon Inspector to use this API.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchUpdateMemberEc2DeepInspectionStatus service method.</param>
        /// 
        /// <returns>The response from the BatchUpdateMemberEc2DeepInspectionStatus service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/BatchUpdateMemberEc2DeepInspectionStatus">REST API Reference for BatchUpdateMemberEc2DeepInspectionStatus Operation</seealso>
        BatchUpdateMemberEc2DeepInspectionStatusResponse BatchUpdateMemberEc2DeepInspectionStatus(BatchUpdateMemberEc2DeepInspectionStatusRequest request);



        /// <summary>
        /// Activates or deactivates Amazon Inspector deep inspection for the provided member
        /// accounts in your organization. You must be the delegated administrator of an organization
        /// in Amazon Inspector to use this API.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchUpdateMemberEc2DeepInspectionStatus service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchUpdateMemberEc2DeepInspectionStatus service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/BatchUpdateMemberEc2DeepInspectionStatus">REST API Reference for BatchUpdateMemberEc2DeepInspectionStatus Operation</seealso>
        Task<BatchUpdateMemberEc2DeepInspectionStatusResponse> BatchUpdateMemberEc2DeepInspectionStatusAsync(BatchUpdateMemberEc2DeepInspectionStatusRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CancelFindingsReport


        /// <summary>
        /// Cancels the given findings report.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelFindingsReport service method.</param>
        /// 
        /// <returns>The response from the CancelFindingsReport service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ResourceNotFoundException">
        /// The operation tried to access an invalid resource. Make sure the resource is specified
        /// correctly.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/CancelFindingsReport">REST API Reference for CancelFindingsReport Operation</seealso>
        CancelFindingsReportResponse CancelFindingsReport(CancelFindingsReportRequest request);



        /// <summary>
        /// Cancels the given findings report.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelFindingsReport service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CancelFindingsReport service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ResourceNotFoundException">
        /// The operation tried to access an invalid resource. Make sure the resource is specified
        /// correctly.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/CancelFindingsReport">REST API Reference for CancelFindingsReport Operation</seealso>
        Task<CancelFindingsReportResponse> CancelFindingsReportAsync(CancelFindingsReportRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CancelSbomExport


        /// <summary>
        /// Cancels a software bill of materials (SBOM) report.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelSbomExport service method.</param>
        /// 
        /// <returns>The response from the CancelSbomExport service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ResourceNotFoundException">
        /// The operation tried to access an invalid resource. Make sure the resource is specified
        /// correctly.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/CancelSbomExport">REST API Reference for CancelSbomExport Operation</seealso>
        CancelSbomExportResponse CancelSbomExport(CancelSbomExportRequest request);



        /// <summary>
        /// Cancels a software bill of materials (SBOM) report.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelSbomExport service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CancelSbomExport service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ResourceNotFoundException">
        /// The operation tried to access an invalid resource. Make sure the resource is specified
        /// correctly.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/CancelSbomExport">REST API Reference for CancelSbomExport Operation</seealso>
        Task<CancelSbomExportResponse> CancelSbomExportAsync(CancelSbomExportRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateCisScanConfiguration


        /// <summary>
        /// Creates a CIS scan configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCisScanConfiguration service method.</param>
        /// 
        /// <returns>The response from the CreateCisScanConfiguration service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/CreateCisScanConfiguration">REST API Reference for CreateCisScanConfiguration Operation</seealso>
        CreateCisScanConfigurationResponse CreateCisScanConfiguration(CreateCisScanConfigurationRequest request);



        /// <summary>
        /// Creates a CIS scan configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCisScanConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateCisScanConfiguration service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/CreateCisScanConfiguration">REST API Reference for CreateCisScanConfiguration Operation</seealso>
        Task<CreateCisScanConfigurationResponse> CreateCisScanConfigurationAsync(CreateCisScanConfigurationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateCodeSecurityIntegration


        /// <summary>
        /// Creates a code security integration with a source code repository provider.
        /// 
        ///  
        /// <para>
        /// After calling the <c>CreateCodeSecurityIntegration</c> operation, you complete authentication
        /// and authorization with your provider. Next you call the <c>UpdateCodeSecurityIntegration</c>
        /// operation to provide the <c>details</c> to complete the integration setup
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCodeSecurityIntegration service method.</param>
        /// 
        /// <returns>The response from the CreateCodeSecurityIntegration service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ConflictException">
        /// A conflict occurred. This exception occurs when the same resource is being modified
        /// by concurrent requests.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ServiceQuotaExceededException">
        /// You have exceeded your service quota. To perform the requested action, remove some
        /// of the relevant resources, or use Service Quotas to request a service quota increase.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/CreateCodeSecurityIntegration">REST API Reference for CreateCodeSecurityIntegration Operation</seealso>
        CreateCodeSecurityIntegrationResponse CreateCodeSecurityIntegration(CreateCodeSecurityIntegrationRequest request);



        /// <summary>
        /// Creates a code security integration with a source code repository provider.
        /// 
        ///  
        /// <para>
        /// After calling the <c>CreateCodeSecurityIntegration</c> operation, you complete authentication
        /// and authorization with your provider. Next you call the <c>UpdateCodeSecurityIntegration</c>
        /// operation to provide the <c>details</c> to complete the integration setup
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCodeSecurityIntegration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateCodeSecurityIntegration service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ConflictException">
        /// A conflict occurred. This exception occurs when the same resource is being modified
        /// by concurrent requests.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ServiceQuotaExceededException">
        /// You have exceeded your service quota. To perform the requested action, remove some
        /// of the relevant resources, or use Service Quotas to request a service quota increase.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/CreateCodeSecurityIntegration">REST API Reference for CreateCodeSecurityIntegration Operation</seealso>
        Task<CreateCodeSecurityIntegrationResponse> CreateCodeSecurityIntegrationAsync(CreateCodeSecurityIntegrationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateCodeSecurityScanConfiguration


        /// <summary>
        /// Creates a scan configuration for code security scanning.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCodeSecurityScanConfiguration service method.</param>
        /// 
        /// <returns>The response from the CreateCodeSecurityScanConfiguration service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ConflictException">
        /// A conflict occurred. This exception occurs when the same resource is being modified
        /// by concurrent requests.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ServiceQuotaExceededException">
        /// You have exceeded your service quota. To perform the requested action, remove some
        /// of the relevant resources, or use Service Quotas to request a service quota increase.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/CreateCodeSecurityScanConfiguration">REST API Reference for CreateCodeSecurityScanConfiguration Operation</seealso>
        CreateCodeSecurityScanConfigurationResponse CreateCodeSecurityScanConfiguration(CreateCodeSecurityScanConfigurationRequest request);



        /// <summary>
        /// Creates a scan configuration for code security scanning.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCodeSecurityScanConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateCodeSecurityScanConfiguration service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ConflictException">
        /// A conflict occurred. This exception occurs when the same resource is being modified
        /// by concurrent requests.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ServiceQuotaExceededException">
        /// You have exceeded your service quota. To perform the requested action, remove some
        /// of the relevant resources, or use Service Quotas to request a service quota increase.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/CreateCodeSecurityScanConfiguration">REST API Reference for CreateCodeSecurityScanConfiguration Operation</seealso>
        Task<CreateCodeSecurityScanConfigurationResponse> CreateCodeSecurityScanConfigurationAsync(CreateCodeSecurityScanConfigurationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateFilter


        /// <summary>
        /// Creates a filter resource using specified filter criteria. When the filter action
        /// is set to <c>SUPPRESS</c> this action creates a suppression rule.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateFilter service method.</param>
        /// 
        /// <returns>The response from the CreateFilter service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.BadRequestException">
        /// One or more tags submitted as part of the request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ServiceQuotaExceededException">
        /// You have exceeded your service quota. To perform the requested action, remove some
        /// of the relevant resources, or use Service Quotas to request a service quota increase.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/CreateFilter">REST API Reference for CreateFilter Operation</seealso>
        CreateFilterResponse CreateFilter(CreateFilterRequest request);



        /// <summary>
        /// Creates a filter resource using specified filter criteria. When the filter action
        /// is set to <c>SUPPRESS</c> this action creates a suppression rule.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateFilter service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateFilter service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.BadRequestException">
        /// One or more tags submitted as part of the request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ServiceQuotaExceededException">
        /// You have exceeded your service quota. To perform the requested action, remove some
        /// of the relevant resources, or use Service Quotas to request a service quota increase.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/CreateFilter">REST API Reference for CreateFilter Operation</seealso>
        Task<CreateFilterResponse> CreateFilterAsync(CreateFilterRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateFindingsReport


        /// <summary>
        /// Creates a finding report. By default only <c>ACTIVE</c> findings are returned in the
        /// report. To see <c>SUPRESSED</c> or <c>CLOSED</c> findings you must specify a value
        /// for the <c>findingStatus</c> filter criteria.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateFindingsReport service method.</param>
        /// 
        /// <returns>The response from the CreateFindingsReport service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ResourceNotFoundException">
        /// The operation tried to access an invalid resource. Make sure the resource is specified
        /// correctly.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/CreateFindingsReport">REST API Reference for CreateFindingsReport Operation</seealso>
        CreateFindingsReportResponse CreateFindingsReport(CreateFindingsReportRequest request);



        /// <summary>
        /// Creates a finding report. By default only <c>ACTIVE</c> findings are returned in the
        /// report. To see <c>SUPRESSED</c> or <c>CLOSED</c> findings you must specify a value
        /// for the <c>findingStatus</c> filter criteria.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateFindingsReport service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateFindingsReport service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ResourceNotFoundException">
        /// The operation tried to access an invalid resource. Make sure the resource is specified
        /// correctly.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/CreateFindingsReport">REST API Reference for CreateFindingsReport Operation</seealso>
        Task<CreateFindingsReportResponse> CreateFindingsReportAsync(CreateFindingsReportRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateSbomExport


        /// <summary>
        /// Creates a software bill of materials (SBOM) report.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSbomExport service method.</param>
        /// 
        /// <returns>The response from the CreateSbomExport service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ResourceNotFoundException">
        /// The operation tried to access an invalid resource. Make sure the resource is specified
        /// correctly.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/CreateSbomExport">REST API Reference for CreateSbomExport Operation</seealso>
        CreateSbomExportResponse CreateSbomExport(CreateSbomExportRequest request);



        /// <summary>
        /// Creates a software bill of materials (SBOM) report.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSbomExport service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateSbomExport service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ResourceNotFoundException">
        /// The operation tried to access an invalid resource. Make sure the resource is specified
        /// correctly.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/CreateSbomExport">REST API Reference for CreateSbomExport Operation</seealso>
        Task<CreateSbomExportResponse> CreateSbomExportAsync(CreateSbomExportRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteCisScanConfiguration


        /// <summary>
        /// Deletes a CIS scan configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCisScanConfiguration service method.</param>
        /// 
        /// <returns>The response from the DeleteCisScanConfiguration service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ResourceNotFoundException">
        /// The operation tried to access an invalid resource. Make sure the resource is specified
        /// correctly.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/DeleteCisScanConfiguration">REST API Reference for DeleteCisScanConfiguration Operation</seealso>
        DeleteCisScanConfigurationResponse DeleteCisScanConfiguration(DeleteCisScanConfigurationRequest request);



        /// <summary>
        /// Deletes a CIS scan configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCisScanConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteCisScanConfiguration service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ResourceNotFoundException">
        /// The operation tried to access an invalid resource. Make sure the resource is specified
        /// correctly.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/DeleteCisScanConfiguration">REST API Reference for DeleteCisScanConfiguration Operation</seealso>
        Task<DeleteCisScanConfigurationResponse> DeleteCisScanConfigurationAsync(DeleteCisScanConfigurationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteCodeSecurityIntegration


        /// <summary>
        /// Deletes a code security integration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCodeSecurityIntegration service method.</param>
        /// 
        /// <returns>The response from the DeleteCodeSecurityIntegration service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ResourceNotFoundException">
        /// The operation tried to access an invalid resource. Make sure the resource is specified
        /// correctly.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/DeleteCodeSecurityIntegration">REST API Reference for DeleteCodeSecurityIntegration Operation</seealso>
        DeleteCodeSecurityIntegrationResponse DeleteCodeSecurityIntegration(DeleteCodeSecurityIntegrationRequest request);



        /// <summary>
        /// Deletes a code security integration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCodeSecurityIntegration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteCodeSecurityIntegration service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ResourceNotFoundException">
        /// The operation tried to access an invalid resource. Make sure the resource is specified
        /// correctly.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/DeleteCodeSecurityIntegration">REST API Reference for DeleteCodeSecurityIntegration Operation</seealso>
        Task<DeleteCodeSecurityIntegrationResponse> DeleteCodeSecurityIntegrationAsync(DeleteCodeSecurityIntegrationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteCodeSecurityScanConfiguration


        /// <summary>
        /// Deletes a code security scan configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCodeSecurityScanConfiguration service method.</param>
        /// 
        /// <returns>The response from the DeleteCodeSecurityScanConfiguration service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ResourceNotFoundException">
        /// The operation tried to access an invalid resource. Make sure the resource is specified
        /// correctly.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/DeleteCodeSecurityScanConfiguration">REST API Reference for DeleteCodeSecurityScanConfiguration Operation</seealso>
        DeleteCodeSecurityScanConfigurationResponse DeleteCodeSecurityScanConfiguration(DeleteCodeSecurityScanConfigurationRequest request);



        /// <summary>
        /// Deletes a code security scan configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCodeSecurityScanConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteCodeSecurityScanConfiguration service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ResourceNotFoundException">
        /// The operation tried to access an invalid resource. Make sure the resource is specified
        /// correctly.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/DeleteCodeSecurityScanConfiguration">REST API Reference for DeleteCodeSecurityScanConfiguration Operation</seealso>
        Task<DeleteCodeSecurityScanConfigurationResponse> DeleteCodeSecurityScanConfigurationAsync(DeleteCodeSecurityScanConfigurationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteFilter


        /// <summary>
        /// Deletes a filter resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteFilter service method.</param>
        /// 
        /// <returns>The response from the DeleteFilter service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ResourceNotFoundException">
        /// The operation tried to access an invalid resource. Make sure the resource is specified
        /// correctly.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/DeleteFilter">REST API Reference for DeleteFilter Operation</seealso>
        DeleteFilterResponse DeleteFilter(DeleteFilterRequest request);



        /// <summary>
        /// Deletes a filter resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteFilter service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteFilter service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ResourceNotFoundException">
        /// The operation tried to access an invalid resource. Make sure the resource is specified
        /// correctly.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/DeleteFilter">REST API Reference for DeleteFilter Operation</seealso>
        Task<DeleteFilterResponse> DeleteFilterAsync(DeleteFilterRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeOrganizationConfiguration


        /// <summary>
        /// Describe Amazon Inspector configuration settings for an Amazon Web Services organization.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeOrganizationConfiguration service method.</param>
        /// 
        /// <returns>The response from the DescribeOrganizationConfiguration service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/DescribeOrganizationConfiguration">REST API Reference for DescribeOrganizationConfiguration Operation</seealso>
        DescribeOrganizationConfigurationResponse DescribeOrganizationConfiguration(DescribeOrganizationConfigurationRequest request);



        /// <summary>
        /// Describe Amazon Inspector configuration settings for an Amazon Web Services organization.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeOrganizationConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeOrganizationConfiguration service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/DescribeOrganizationConfiguration">REST API Reference for DescribeOrganizationConfiguration Operation</seealso>
        Task<DescribeOrganizationConfigurationResponse> DescribeOrganizationConfigurationAsync(DescribeOrganizationConfigurationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  Disable


        /// <summary>
        /// Disables Amazon Inspector scans for one or more Amazon Web Services accounts. Disabling
        /// all scan types in an account disables the Amazon Inspector service.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the Disable service method.</param>
        /// 
        /// <returns>The response from the Disable service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ResourceNotFoundException">
        /// The operation tried to access an invalid resource. Make sure the resource is specified
        /// correctly.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/Disable">REST API Reference for Disable Operation</seealso>
        DisableResponse Disable(DisableRequest request);



        /// <summary>
        /// Disables Amazon Inspector scans for one or more Amazon Web Services accounts. Disabling
        /// all scan types in an account disables the Amazon Inspector service.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the Disable service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the Disable service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ResourceNotFoundException">
        /// The operation tried to access an invalid resource. Make sure the resource is specified
        /// correctly.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/Disable">REST API Reference for Disable Operation</seealso>
        Task<DisableResponse> DisableAsync(DisableRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DisableDelegatedAdminAccount


        /// <summary>
        /// Disables the Amazon Inspector delegated administrator for your organization.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisableDelegatedAdminAccount service method.</param>
        /// 
        /// <returns>The response from the DisableDelegatedAdminAccount service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ConflictException">
        /// A conflict occurred. This exception occurs when the same resource is being modified
        /// by concurrent requests.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ResourceNotFoundException">
        /// The operation tried to access an invalid resource. Make sure the resource is specified
        /// correctly.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/DisableDelegatedAdminAccount">REST API Reference for DisableDelegatedAdminAccount Operation</seealso>
        DisableDelegatedAdminAccountResponse DisableDelegatedAdminAccount(DisableDelegatedAdminAccountRequest request);



        /// <summary>
        /// Disables the Amazon Inspector delegated administrator for your organization.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisableDelegatedAdminAccount service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisableDelegatedAdminAccount service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ConflictException">
        /// A conflict occurred. This exception occurs when the same resource is being modified
        /// by concurrent requests.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ResourceNotFoundException">
        /// The operation tried to access an invalid resource. Make sure the resource is specified
        /// correctly.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/DisableDelegatedAdminAccount">REST API Reference for DisableDelegatedAdminAccount Operation</seealso>
        Task<DisableDelegatedAdminAccountResponse> DisableDelegatedAdminAccountAsync(DisableDelegatedAdminAccountRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DisassociateMember


        /// <summary>
        /// Disassociates a member account from an Amazon Inspector delegated administrator.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateMember service method.</param>
        /// 
        /// <returns>The response from the DisassociateMember service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/DisassociateMember">REST API Reference for DisassociateMember Operation</seealso>
        DisassociateMemberResponse DisassociateMember(DisassociateMemberRequest request);



        /// <summary>
        /// Disassociates a member account from an Amazon Inspector delegated administrator.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateMember service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisassociateMember service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/DisassociateMember">REST API Reference for DisassociateMember Operation</seealso>
        Task<DisassociateMemberResponse> DisassociateMemberAsync(DisassociateMemberRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  Enable


        /// <summary>
        /// Enables Amazon Inspector scans for one or more Amazon Web Services accounts.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the Enable service method.</param>
        /// 
        /// <returns>The response from the Enable service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ResourceNotFoundException">
        /// The operation tried to access an invalid resource. Make sure the resource is specified
        /// correctly.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/Enable">REST API Reference for Enable Operation</seealso>
        EnableResponse Enable(EnableRequest request);



        /// <summary>
        /// Enables Amazon Inspector scans for one or more Amazon Web Services accounts.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the Enable service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the Enable service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ResourceNotFoundException">
        /// The operation tried to access an invalid resource. Make sure the resource is specified
        /// correctly.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/Enable">REST API Reference for Enable Operation</seealso>
        Task<EnableResponse> EnableAsync(EnableRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  EnableDelegatedAdminAccount


        /// <summary>
        /// Enables the Amazon Inspector delegated administrator for your Organizations organization.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EnableDelegatedAdminAccount service method.</param>
        /// 
        /// <returns>The response from the EnableDelegatedAdminAccount service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ConflictException">
        /// A conflict occurred. This exception occurs when the same resource is being modified
        /// by concurrent requests.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ResourceNotFoundException">
        /// The operation tried to access an invalid resource. Make sure the resource is specified
        /// correctly.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/EnableDelegatedAdminAccount">REST API Reference for EnableDelegatedAdminAccount Operation</seealso>
        EnableDelegatedAdminAccountResponse EnableDelegatedAdminAccount(EnableDelegatedAdminAccountRequest request);



        /// <summary>
        /// Enables the Amazon Inspector delegated administrator for your Organizations organization.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EnableDelegatedAdminAccount service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the EnableDelegatedAdminAccount service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ConflictException">
        /// A conflict occurred. This exception occurs when the same resource is being modified
        /// by concurrent requests.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ResourceNotFoundException">
        /// The operation tried to access an invalid resource. Make sure the resource is specified
        /// correctly.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/EnableDelegatedAdminAccount">REST API Reference for EnableDelegatedAdminAccount Operation</seealso>
        Task<EnableDelegatedAdminAccountResponse> EnableDelegatedAdminAccountAsync(EnableDelegatedAdminAccountRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetCisScanReport


        /// <summary>
        /// Retrieves a CIS scan report.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCisScanReport service method.</param>
        /// 
        /// <returns>The response from the GetCisScanReport service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ResourceNotFoundException">
        /// The operation tried to access an invalid resource. Make sure the resource is specified
        /// correctly.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/GetCisScanReport">REST API Reference for GetCisScanReport Operation</seealso>
        GetCisScanReportResponse GetCisScanReport(GetCisScanReportRequest request);



        /// <summary>
        /// Retrieves a CIS scan report.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCisScanReport service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetCisScanReport service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ResourceNotFoundException">
        /// The operation tried to access an invalid resource. Make sure the resource is specified
        /// correctly.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/GetCisScanReport">REST API Reference for GetCisScanReport Operation</seealso>
        Task<GetCisScanReportResponse> GetCisScanReportAsync(GetCisScanReportRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetCisScanResultDetails


        /// <summary>
        /// Retrieves CIS scan result details.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCisScanResultDetails service method.</param>
        /// 
        /// <returns>The response from the GetCisScanResultDetails service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/GetCisScanResultDetails">REST API Reference for GetCisScanResultDetails Operation</seealso>
        GetCisScanResultDetailsResponse GetCisScanResultDetails(GetCisScanResultDetailsRequest request);



        /// <summary>
        /// Retrieves CIS scan result details.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCisScanResultDetails service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetCisScanResultDetails service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/GetCisScanResultDetails">REST API Reference for GetCisScanResultDetails Operation</seealso>
        Task<GetCisScanResultDetailsResponse> GetCisScanResultDetailsAsync(GetCisScanResultDetailsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetClustersForImage


        /// <summary>
        /// Returns a list of clusters and metadata associated with an image.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetClustersForImage service method.</param>
        /// 
        /// <returns>The response from the GetClustersForImage service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/GetClustersForImage">REST API Reference for GetClustersForImage Operation</seealso>
        GetClustersForImageResponse GetClustersForImage(GetClustersForImageRequest request);



        /// <summary>
        /// Returns a list of clusters and metadata associated with an image.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetClustersForImage service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetClustersForImage service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/GetClustersForImage">REST API Reference for GetClustersForImage Operation</seealso>
        Task<GetClustersForImageResponse> GetClustersForImageAsync(GetClustersForImageRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetCodeSecurityIntegration


        /// <summary>
        /// Retrieves information about a code security integration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCodeSecurityIntegration service method.</param>
        /// 
        /// <returns>The response from the GetCodeSecurityIntegration service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ResourceNotFoundException">
        /// The operation tried to access an invalid resource. Make sure the resource is specified
        /// correctly.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/GetCodeSecurityIntegration">REST API Reference for GetCodeSecurityIntegration Operation</seealso>
        GetCodeSecurityIntegrationResponse GetCodeSecurityIntegration(GetCodeSecurityIntegrationRequest request);



        /// <summary>
        /// Retrieves information about a code security integration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCodeSecurityIntegration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetCodeSecurityIntegration service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ResourceNotFoundException">
        /// The operation tried to access an invalid resource. Make sure the resource is specified
        /// correctly.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/GetCodeSecurityIntegration">REST API Reference for GetCodeSecurityIntegration Operation</seealso>
        Task<GetCodeSecurityIntegrationResponse> GetCodeSecurityIntegrationAsync(GetCodeSecurityIntegrationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetCodeSecurityScan


        /// <summary>
        /// Retrieves information about a specific code security scan.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCodeSecurityScan service method.</param>
        /// 
        /// <returns>The response from the GetCodeSecurityScan service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ConflictException">
        /// A conflict occurred. This exception occurs when the same resource is being modified
        /// by concurrent requests.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ResourceNotFoundException">
        /// The operation tried to access an invalid resource. Make sure the resource is specified
        /// correctly.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/GetCodeSecurityScan">REST API Reference for GetCodeSecurityScan Operation</seealso>
        GetCodeSecurityScanResponse GetCodeSecurityScan(GetCodeSecurityScanRequest request);



        /// <summary>
        /// Retrieves information about a specific code security scan.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCodeSecurityScan service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetCodeSecurityScan service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ConflictException">
        /// A conflict occurred. This exception occurs when the same resource is being modified
        /// by concurrent requests.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ResourceNotFoundException">
        /// The operation tried to access an invalid resource. Make sure the resource is specified
        /// correctly.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/GetCodeSecurityScan">REST API Reference for GetCodeSecurityScan Operation</seealso>
        Task<GetCodeSecurityScanResponse> GetCodeSecurityScanAsync(GetCodeSecurityScanRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetCodeSecurityScanConfiguration


        /// <summary>
        /// Retrieves information about a code security scan configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCodeSecurityScanConfiguration service method.</param>
        /// 
        /// <returns>The response from the GetCodeSecurityScanConfiguration service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ResourceNotFoundException">
        /// The operation tried to access an invalid resource. Make sure the resource is specified
        /// correctly.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/GetCodeSecurityScanConfiguration">REST API Reference for GetCodeSecurityScanConfiguration Operation</seealso>
        GetCodeSecurityScanConfigurationResponse GetCodeSecurityScanConfiguration(GetCodeSecurityScanConfigurationRequest request);



        /// <summary>
        /// Retrieves information about a code security scan configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCodeSecurityScanConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetCodeSecurityScanConfiguration service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ResourceNotFoundException">
        /// The operation tried to access an invalid resource. Make sure the resource is specified
        /// correctly.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/GetCodeSecurityScanConfiguration">REST API Reference for GetCodeSecurityScanConfiguration Operation</seealso>
        Task<GetCodeSecurityScanConfigurationResponse> GetCodeSecurityScanConfigurationAsync(GetCodeSecurityScanConfigurationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetConfiguration


        /// <summary>
        /// Retrieves setting configurations for Inspector scans.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetConfiguration service method.</param>
        /// 
        /// <returns>The response from the GetConfiguration service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ResourceNotFoundException">
        /// The operation tried to access an invalid resource. Make sure the resource is specified
        /// correctly.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/GetConfiguration">REST API Reference for GetConfiguration Operation</seealso>
        GetConfigurationResponse GetConfiguration(GetConfigurationRequest request);



        /// <summary>
        /// Retrieves setting configurations for Inspector scans.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetConfiguration service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ResourceNotFoundException">
        /// The operation tried to access an invalid resource. Make sure the resource is specified
        /// correctly.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/GetConfiguration">REST API Reference for GetConfiguration Operation</seealso>
        Task<GetConfigurationResponse> GetConfigurationAsync(GetConfigurationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetDelegatedAdminAccount


        /// <summary>
        /// Retrieves information about the Amazon Inspector delegated administrator for your
        /// organization.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDelegatedAdminAccount service method.</param>
        /// 
        /// <returns>The response from the GetDelegatedAdminAccount service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ResourceNotFoundException">
        /// The operation tried to access an invalid resource. Make sure the resource is specified
        /// correctly.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/GetDelegatedAdminAccount">REST API Reference for GetDelegatedAdminAccount Operation</seealso>
        GetDelegatedAdminAccountResponse GetDelegatedAdminAccount(GetDelegatedAdminAccountRequest request);



        /// <summary>
        /// Retrieves information about the Amazon Inspector delegated administrator for your
        /// organization.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDelegatedAdminAccount service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetDelegatedAdminAccount service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ResourceNotFoundException">
        /// The operation tried to access an invalid resource. Make sure the resource is specified
        /// correctly.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/GetDelegatedAdminAccount">REST API Reference for GetDelegatedAdminAccount Operation</seealso>
        Task<GetDelegatedAdminAccountResponse> GetDelegatedAdminAccountAsync(GetDelegatedAdminAccountRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetEc2DeepInspectionConfiguration


        /// <summary>
        /// Retrieves the activation status of Amazon Inspector deep inspection and custom paths
        /// associated with your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEc2DeepInspectionConfiguration service method.</param>
        /// 
        /// <returns>The response from the GetEc2DeepInspectionConfiguration service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ResourceNotFoundException">
        /// The operation tried to access an invalid resource. Make sure the resource is specified
        /// correctly.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/GetEc2DeepInspectionConfiguration">REST API Reference for GetEc2DeepInspectionConfiguration Operation</seealso>
        GetEc2DeepInspectionConfigurationResponse GetEc2DeepInspectionConfiguration(GetEc2DeepInspectionConfigurationRequest request);



        /// <summary>
        /// Retrieves the activation status of Amazon Inspector deep inspection and custom paths
        /// associated with your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEc2DeepInspectionConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetEc2DeepInspectionConfiguration service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ResourceNotFoundException">
        /// The operation tried to access an invalid resource. Make sure the resource is specified
        /// correctly.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/GetEc2DeepInspectionConfiguration">REST API Reference for GetEc2DeepInspectionConfiguration Operation</seealso>
        Task<GetEc2DeepInspectionConfigurationResponse> GetEc2DeepInspectionConfigurationAsync(GetEc2DeepInspectionConfigurationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetEncryptionKey


        /// <summary>
        /// Gets an encryption key.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEncryptionKey service method.</param>
        /// 
        /// <returns>The response from the GetEncryptionKey service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ResourceNotFoundException">
        /// The operation tried to access an invalid resource. Make sure the resource is specified
        /// correctly.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/GetEncryptionKey">REST API Reference for GetEncryptionKey Operation</seealso>
        GetEncryptionKeyResponse GetEncryptionKey(GetEncryptionKeyRequest request);



        /// <summary>
        /// Gets an encryption key.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEncryptionKey service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetEncryptionKey service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ResourceNotFoundException">
        /// The operation tried to access an invalid resource. Make sure the resource is specified
        /// correctly.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/GetEncryptionKey">REST API Reference for GetEncryptionKey Operation</seealso>
        Task<GetEncryptionKeyResponse> GetEncryptionKeyAsync(GetEncryptionKeyRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetFindingsReportStatus


        /// <summary>
        /// Gets the status of a findings report.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetFindingsReportStatus service method.</param>
        /// 
        /// <returns>The response from the GetFindingsReportStatus service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ResourceNotFoundException">
        /// The operation tried to access an invalid resource. Make sure the resource is specified
        /// correctly.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/GetFindingsReportStatus">REST API Reference for GetFindingsReportStatus Operation</seealso>
        GetFindingsReportStatusResponse GetFindingsReportStatus(GetFindingsReportStatusRequest request);



        /// <summary>
        /// Gets the status of a findings report.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetFindingsReportStatus service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetFindingsReportStatus service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ResourceNotFoundException">
        /// The operation tried to access an invalid resource. Make sure the resource is specified
        /// correctly.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/GetFindingsReportStatus">REST API Reference for GetFindingsReportStatus Operation</seealso>
        Task<GetFindingsReportStatusResponse> GetFindingsReportStatusAsync(GetFindingsReportStatusRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetMember


        /// <summary>
        /// Gets member information for your organization.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMember service method.</param>
        /// 
        /// <returns>The response from the GetMember service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ResourceNotFoundException">
        /// The operation tried to access an invalid resource. Make sure the resource is specified
        /// correctly.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/GetMember">REST API Reference for GetMember Operation</seealso>
        GetMemberResponse GetMember(GetMemberRequest request);



        /// <summary>
        /// Gets member information for your organization.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMember service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetMember service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ResourceNotFoundException">
        /// The operation tried to access an invalid resource. Make sure the resource is specified
        /// correctly.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/GetMember">REST API Reference for GetMember Operation</seealso>
        Task<GetMemberResponse> GetMemberAsync(GetMemberRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetSbomExport


        /// <summary>
        /// Gets details of a software bill of materials (SBOM) report.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSbomExport service method.</param>
        /// 
        /// <returns>The response from the GetSbomExport service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ResourceNotFoundException">
        /// The operation tried to access an invalid resource. Make sure the resource is specified
        /// correctly.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/GetSbomExport">REST API Reference for GetSbomExport Operation</seealso>
        GetSbomExportResponse GetSbomExport(GetSbomExportRequest request);



        /// <summary>
        /// Gets details of a software bill of materials (SBOM) report.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSbomExport service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetSbomExport service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ResourceNotFoundException">
        /// The operation tried to access an invalid resource. Make sure the resource is specified
        /// correctly.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/GetSbomExport">REST API Reference for GetSbomExport Operation</seealso>
        Task<GetSbomExportResponse> GetSbomExportAsync(GetSbomExportRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListAccountPermissions


        /// <summary>
        /// Lists the permissions an account has to configure Amazon Inspector.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAccountPermissions service method.</param>
        /// 
        /// <returns>The response from the ListAccountPermissions service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/ListAccountPermissions">REST API Reference for ListAccountPermissions Operation</seealso>
        ListAccountPermissionsResponse ListAccountPermissions(ListAccountPermissionsRequest request);



        /// <summary>
        /// Lists the permissions an account has to configure Amazon Inspector.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAccountPermissions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAccountPermissions service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/ListAccountPermissions">REST API Reference for ListAccountPermissions Operation</seealso>
        Task<ListAccountPermissionsResponse> ListAccountPermissionsAsync(ListAccountPermissionsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListCisScanConfigurations


        /// <summary>
        /// Lists CIS scan configurations.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCisScanConfigurations service method.</param>
        /// 
        /// <returns>The response from the ListCisScanConfigurations service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/ListCisScanConfigurations">REST API Reference for ListCisScanConfigurations Operation</seealso>
        ListCisScanConfigurationsResponse ListCisScanConfigurations(ListCisScanConfigurationsRequest request);



        /// <summary>
        /// Lists CIS scan configurations.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCisScanConfigurations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListCisScanConfigurations service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/ListCisScanConfigurations">REST API Reference for ListCisScanConfigurations Operation</seealso>
        Task<ListCisScanConfigurationsResponse> ListCisScanConfigurationsAsync(ListCisScanConfigurationsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListCisScanResultsAggregatedByChecks


        /// <summary>
        /// Lists scan results aggregated by checks.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCisScanResultsAggregatedByChecks service method.</param>
        /// 
        /// <returns>The response from the ListCisScanResultsAggregatedByChecks service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/ListCisScanResultsAggregatedByChecks">REST API Reference for ListCisScanResultsAggregatedByChecks Operation</seealso>
        ListCisScanResultsAggregatedByChecksResponse ListCisScanResultsAggregatedByChecks(ListCisScanResultsAggregatedByChecksRequest request);



        /// <summary>
        /// Lists scan results aggregated by checks.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCisScanResultsAggregatedByChecks service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListCisScanResultsAggregatedByChecks service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/ListCisScanResultsAggregatedByChecks">REST API Reference for ListCisScanResultsAggregatedByChecks Operation</seealso>
        Task<ListCisScanResultsAggregatedByChecksResponse> ListCisScanResultsAggregatedByChecksAsync(ListCisScanResultsAggregatedByChecksRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListCisScanResultsAggregatedByTargetResource


        /// <summary>
        /// Lists scan results aggregated by a target resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCisScanResultsAggregatedByTargetResource service method.</param>
        /// 
        /// <returns>The response from the ListCisScanResultsAggregatedByTargetResource service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/ListCisScanResultsAggregatedByTargetResource">REST API Reference for ListCisScanResultsAggregatedByTargetResource Operation</seealso>
        ListCisScanResultsAggregatedByTargetResourceResponse ListCisScanResultsAggregatedByTargetResource(ListCisScanResultsAggregatedByTargetResourceRequest request);



        /// <summary>
        /// Lists scan results aggregated by a target resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCisScanResultsAggregatedByTargetResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListCisScanResultsAggregatedByTargetResource service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/ListCisScanResultsAggregatedByTargetResource">REST API Reference for ListCisScanResultsAggregatedByTargetResource Operation</seealso>
        Task<ListCisScanResultsAggregatedByTargetResourceResponse> ListCisScanResultsAggregatedByTargetResourceAsync(ListCisScanResultsAggregatedByTargetResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListCisScans


        /// <summary>
        /// Returns a CIS scan list.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCisScans service method.</param>
        /// 
        /// <returns>The response from the ListCisScans service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/ListCisScans">REST API Reference for ListCisScans Operation</seealso>
        ListCisScansResponse ListCisScans(ListCisScansRequest request);



        /// <summary>
        /// Returns a CIS scan list.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCisScans service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListCisScans service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/ListCisScans">REST API Reference for ListCisScans Operation</seealso>
        Task<ListCisScansResponse> ListCisScansAsync(ListCisScansRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListCodeSecurityIntegrations


        /// <summary>
        /// Lists all code security integrations in your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCodeSecurityIntegrations service method.</param>
        /// 
        /// <returns>The response from the ListCodeSecurityIntegrations service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/ListCodeSecurityIntegrations">REST API Reference for ListCodeSecurityIntegrations Operation</seealso>
        ListCodeSecurityIntegrationsResponse ListCodeSecurityIntegrations(ListCodeSecurityIntegrationsRequest request);



        /// <summary>
        /// Lists all code security integrations in your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCodeSecurityIntegrations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListCodeSecurityIntegrations service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/ListCodeSecurityIntegrations">REST API Reference for ListCodeSecurityIntegrations Operation</seealso>
        Task<ListCodeSecurityIntegrationsResponse> ListCodeSecurityIntegrationsAsync(ListCodeSecurityIntegrationsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListCodeSecurityScanConfigurationAssociations


        /// <summary>
        /// Lists the associations between code repositories and Amazon Inspector code security
        /// scan configurations.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCodeSecurityScanConfigurationAssociations service method.</param>
        /// 
        /// <returns>The response from the ListCodeSecurityScanConfigurationAssociations service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ResourceNotFoundException">
        /// The operation tried to access an invalid resource. Make sure the resource is specified
        /// correctly.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/ListCodeSecurityScanConfigurationAssociations">REST API Reference for ListCodeSecurityScanConfigurationAssociations Operation</seealso>
        ListCodeSecurityScanConfigurationAssociationsResponse ListCodeSecurityScanConfigurationAssociations(ListCodeSecurityScanConfigurationAssociationsRequest request);



        /// <summary>
        /// Lists the associations between code repositories and Amazon Inspector code security
        /// scan configurations.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCodeSecurityScanConfigurationAssociations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListCodeSecurityScanConfigurationAssociations service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ResourceNotFoundException">
        /// The operation tried to access an invalid resource. Make sure the resource is specified
        /// correctly.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/ListCodeSecurityScanConfigurationAssociations">REST API Reference for ListCodeSecurityScanConfigurationAssociations Operation</seealso>
        Task<ListCodeSecurityScanConfigurationAssociationsResponse> ListCodeSecurityScanConfigurationAssociationsAsync(ListCodeSecurityScanConfigurationAssociationsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListCodeSecurityScanConfigurations


        /// <summary>
        /// Lists all code security scan configurations in your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCodeSecurityScanConfigurations service method.</param>
        /// 
        /// <returns>The response from the ListCodeSecurityScanConfigurations service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ResourceNotFoundException">
        /// The operation tried to access an invalid resource. Make sure the resource is specified
        /// correctly.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/ListCodeSecurityScanConfigurations">REST API Reference for ListCodeSecurityScanConfigurations Operation</seealso>
        ListCodeSecurityScanConfigurationsResponse ListCodeSecurityScanConfigurations(ListCodeSecurityScanConfigurationsRequest request);



        /// <summary>
        /// Lists all code security scan configurations in your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCodeSecurityScanConfigurations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListCodeSecurityScanConfigurations service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ResourceNotFoundException">
        /// The operation tried to access an invalid resource. Make sure the resource is specified
        /// correctly.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/ListCodeSecurityScanConfigurations">REST API Reference for ListCodeSecurityScanConfigurations Operation</seealso>
        Task<ListCodeSecurityScanConfigurationsResponse> ListCodeSecurityScanConfigurationsAsync(ListCodeSecurityScanConfigurationsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListCoverage


        /// <summary>
        /// Lists coverage details for your environment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCoverage service method.</param>
        /// 
        /// <returns>The response from the ListCoverage service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/ListCoverage">REST API Reference for ListCoverage Operation</seealso>
        ListCoverageResponse ListCoverage(ListCoverageRequest request);



        /// <summary>
        /// Lists coverage details for your environment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCoverage service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListCoverage service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/ListCoverage">REST API Reference for ListCoverage Operation</seealso>
        Task<ListCoverageResponse> ListCoverageAsync(ListCoverageRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListCoverageStatistics


        /// <summary>
        /// Lists Amazon Inspector coverage statistics for your environment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCoverageStatistics service method.</param>
        /// 
        /// <returns>The response from the ListCoverageStatistics service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/ListCoverageStatistics">REST API Reference for ListCoverageStatistics Operation</seealso>
        ListCoverageStatisticsResponse ListCoverageStatistics(ListCoverageStatisticsRequest request);



        /// <summary>
        /// Lists Amazon Inspector coverage statistics for your environment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCoverageStatistics service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListCoverageStatistics service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/ListCoverageStatistics">REST API Reference for ListCoverageStatistics Operation</seealso>
        Task<ListCoverageStatisticsResponse> ListCoverageStatisticsAsync(ListCoverageStatisticsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListDelegatedAdminAccounts


        /// <summary>
        /// Lists information about the Amazon Inspector delegated administrator of your organization.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDelegatedAdminAccounts service method.</param>
        /// 
        /// <returns>The response from the ListDelegatedAdminAccounts service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/ListDelegatedAdminAccounts">REST API Reference for ListDelegatedAdminAccounts Operation</seealso>
        ListDelegatedAdminAccountsResponse ListDelegatedAdminAccounts(ListDelegatedAdminAccountsRequest request);



        /// <summary>
        /// Lists information about the Amazon Inspector delegated administrator of your organization.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDelegatedAdminAccounts service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListDelegatedAdminAccounts service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/ListDelegatedAdminAccounts">REST API Reference for ListDelegatedAdminAccounts Operation</seealso>
        Task<ListDelegatedAdminAccountsResponse> ListDelegatedAdminAccountsAsync(ListDelegatedAdminAccountsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListFilters


        /// <summary>
        /// Lists the filters associated with your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFilters service method.</param>
        /// 
        /// <returns>The response from the ListFilters service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/ListFilters">REST API Reference for ListFilters Operation</seealso>
        ListFiltersResponse ListFilters(ListFiltersRequest request);



        /// <summary>
        /// Lists the filters associated with your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFilters service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListFilters service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/ListFilters">REST API Reference for ListFilters Operation</seealso>
        Task<ListFiltersResponse> ListFiltersAsync(ListFiltersRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListFindingAggregations


        /// <summary>
        /// Lists aggregated finding data for your environment based on specific criteria.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFindingAggregations service method.</param>
        /// 
        /// <returns>The response from the ListFindingAggregations service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/ListFindingAggregations">REST API Reference for ListFindingAggregations Operation</seealso>
        ListFindingAggregationsResponse ListFindingAggregations(ListFindingAggregationsRequest request);



        /// <summary>
        /// Lists aggregated finding data for your environment based on specific criteria.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFindingAggregations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListFindingAggregations service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/ListFindingAggregations">REST API Reference for ListFindingAggregations Operation</seealso>
        Task<ListFindingAggregationsResponse> ListFindingAggregationsAsync(ListFindingAggregationsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListFindings


        /// <summary>
        /// Lists findings for your environment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFindings service method.</param>
        /// 
        /// <returns>The response from the ListFindings service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/ListFindings">REST API Reference for ListFindings Operation</seealso>
        ListFindingsResponse ListFindings(ListFindingsRequest request);



        /// <summary>
        /// Lists findings for your environment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFindings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListFindings service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/ListFindings">REST API Reference for ListFindings Operation</seealso>
        Task<ListFindingsResponse> ListFindingsAsync(ListFindingsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListMembers


        /// <summary>
        /// List members associated with the Amazon Inspector delegated administrator for your
        /// organization.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMembers service method.</param>
        /// 
        /// <returns>The response from the ListMembers service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/ListMembers">REST API Reference for ListMembers Operation</seealso>
        ListMembersResponse ListMembers(ListMembersRequest request);



        /// <summary>
        /// List members associated with the Amazon Inspector delegated administrator for your
        /// organization.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMembers service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListMembers service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/ListMembers">REST API Reference for ListMembers Operation</seealso>
        Task<ListMembersResponse> ListMembersAsync(ListMembersRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// Lists all tags attached to a given resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ResourceNotFoundException">
        /// The operation tried to access an invalid resource. Make sure the resource is specified
        /// correctly.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request);



        /// <summary>
        /// Lists all tags attached to a given resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ResourceNotFoundException">
        /// The operation tried to access an invalid resource. Make sure the resource is specified
        /// correctly.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListUsageTotals


        /// <summary>
        /// Lists the Amazon Inspector usage totals over the last 30 days.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListUsageTotals service method.</param>
        /// 
        /// <returns>The response from the ListUsageTotals service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/ListUsageTotals">REST API Reference for ListUsageTotals Operation</seealso>
        ListUsageTotalsResponse ListUsageTotals(ListUsageTotalsRequest request);



        /// <summary>
        /// Lists the Amazon Inspector usage totals over the last 30 days.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListUsageTotals service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListUsageTotals service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/ListUsageTotals">REST API Reference for ListUsageTotals Operation</seealso>
        Task<ListUsageTotalsResponse> ListUsageTotalsAsync(ListUsageTotalsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ResetEncryptionKey


        /// <summary>
        /// Resets an encryption key. After the key is reset your resources will be encrypted
        /// by an Amazon Web Services owned key.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ResetEncryptionKey service method.</param>
        /// 
        /// <returns>The response from the ResetEncryptionKey service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ResourceNotFoundException">
        /// The operation tried to access an invalid resource. Make sure the resource is specified
        /// correctly.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/ResetEncryptionKey">REST API Reference for ResetEncryptionKey Operation</seealso>
        ResetEncryptionKeyResponse ResetEncryptionKey(ResetEncryptionKeyRequest request);



        /// <summary>
        /// Resets an encryption key. After the key is reset your resources will be encrypted
        /// by an Amazon Web Services owned key.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ResetEncryptionKey service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ResetEncryptionKey service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ResourceNotFoundException">
        /// The operation tried to access an invalid resource. Make sure the resource is specified
        /// correctly.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/ResetEncryptionKey">REST API Reference for ResetEncryptionKey Operation</seealso>
        Task<ResetEncryptionKeyResponse> ResetEncryptionKeyAsync(ResetEncryptionKeyRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  SearchVulnerabilities


        /// <summary>
        /// Lists Amazon Inspector coverage details for a specific vulnerability.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchVulnerabilities service method.</param>
        /// 
        /// <returns>The response from the SearchVulnerabilities service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/SearchVulnerabilities">REST API Reference for SearchVulnerabilities Operation</seealso>
        SearchVulnerabilitiesResponse SearchVulnerabilities(SearchVulnerabilitiesRequest request);



        /// <summary>
        /// Lists Amazon Inspector coverage details for a specific vulnerability.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchVulnerabilities service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SearchVulnerabilities service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/SearchVulnerabilities">REST API Reference for SearchVulnerabilities Operation</seealso>
        Task<SearchVulnerabilitiesResponse> SearchVulnerabilitiesAsync(SearchVulnerabilitiesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  SendCisSessionHealth


        /// <summary>
        /// Sends a CIS session health. This API is used by the Amazon Inspector SSM plugin to
        /// communicate with the Amazon Inspector service. The Amazon Inspector SSM plugin calls
        /// this API to start a CIS scan session for the scan ID supplied by the service.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SendCisSessionHealth service method.</param>
        /// 
        /// <returns>The response from the SendCisSessionHealth service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ConflictException">
        /// A conflict occurred. This exception occurs when the same resource is being modified
        /// by concurrent requests.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/SendCisSessionHealth">REST API Reference for SendCisSessionHealth Operation</seealso>
        SendCisSessionHealthResponse SendCisSessionHealth(SendCisSessionHealthRequest request);



        /// <summary>
        /// Sends a CIS session health. This API is used by the Amazon Inspector SSM plugin to
        /// communicate with the Amazon Inspector service. The Amazon Inspector SSM plugin calls
        /// this API to start a CIS scan session for the scan ID supplied by the service.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SendCisSessionHealth service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SendCisSessionHealth service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ConflictException">
        /// A conflict occurred. This exception occurs when the same resource is being modified
        /// by concurrent requests.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/SendCisSessionHealth">REST API Reference for SendCisSessionHealth Operation</seealso>
        Task<SendCisSessionHealthResponse> SendCisSessionHealthAsync(SendCisSessionHealthRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  SendCisSessionTelemetry


        /// <summary>
        /// Sends a CIS session telemetry. This API is used by the Amazon Inspector SSM plugin
        /// to communicate with the Amazon Inspector service. The Amazon Inspector SSM plugin
        /// calls this API to start a CIS scan session for the scan ID supplied by the service.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SendCisSessionTelemetry service method.</param>
        /// 
        /// <returns>The response from the SendCisSessionTelemetry service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ConflictException">
        /// A conflict occurred. This exception occurs when the same resource is being modified
        /// by concurrent requests.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/SendCisSessionTelemetry">REST API Reference for SendCisSessionTelemetry Operation</seealso>
        SendCisSessionTelemetryResponse SendCisSessionTelemetry(SendCisSessionTelemetryRequest request);



        /// <summary>
        /// Sends a CIS session telemetry. This API is used by the Amazon Inspector SSM plugin
        /// to communicate with the Amazon Inspector service. The Amazon Inspector SSM plugin
        /// calls this API to start a CIS scan session for the scan ID supplied by the service.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SendCisSessionTelemetry service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SendCisSessionTelemetry service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ConflictException">
        /// A conflict occurred. This exception occurs when the same resource is being modified
        /// by concurrent requests.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/SendCisSessionTelemetry">REST API Reference for SendCisSessionTelemetry Operation</seealso>
        Task<SendCisSessionTelemetryResponse> SendCisSessionTelemetryAsync(SendCisSessionTelemetryRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  StartCisSession


        /// <summary>
        /// Starts a CIS session. This API is used by the Amazon Inspector SSM plugin to communicate
        /// with the Amazon Inspector service. The Amazon Inspector SSM plugin calls this API
        /// to start a CIS scan session for the scan ID supplied by the service.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartCisSession service method.</param>
        /// 
        /// <returns>The response from the StartCisSession service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ConflictException">
        /// A conflict occurred. This exception occurs when the same resource is being modified
        /// by concurrent requests.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/StartCisSession">REST API Reference for StartCisSession Operation</seealso>
        StartCisSessionResponse StartCisSession(StartCisSessionRequest request);



        /// <summary>
        /// Starts a CIS session. This API is used by the Amazon Inspector SSM plugin to communicate
        /// with the Amazon Inspector service. The Amazon Inspector SSM plugin calls this API
        /// to start a CIS scan session for the scan ID supplied by the service.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartCisSession service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartCisSession service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ConflictException">
        /// A conflict occurred. This exception occurs when the same resource is being modified
        /// by concurrent requests.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/StartCisSession">REST API Reference for StartCisSession Operation</seealso>
        Task<StartCisSessionResponse> StartCisSessionAsync(StartCisSessionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  StartCodeSecurityScan


        /// <summary>
        /// Initiates a code security scan on a specified repository.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartCodeSecurityScan service method.</param>
        /// 
        /// <returns>The response from the StartCodeSecurityScan service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ConflictException">
        /// A conflict occurred. This exception occurs when the same resource is being modified
        /// by concurrent requests.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ResourceNotFoundException">
        /// The operation tried to access an invalid resource. Make sure the resource is specified
        /// correctly.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/StartCodeSecurityScan">REST API Reference for StartCodeSecurityScan Operation</seealso>
        StartCodeSecurityScanResponse StartCodeSecurityScan(StartCodeSecurityScanRequest request);



        /// <summary>
        /// Initiates a code security scan on a specified repository.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartCodeSecurityScan service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartCodeSecurityScan service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ConflictException">
        /// A conflict occurred. This exception occurs when the same resource is being modified
        /// by concurrent requests.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ResourceNotFoundException">
        /// The operation tried to access an invalid resource. Make sure the resource is specified
        /// correctly.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/StartCodeSecurityScan">REST API Reference for StartCodeSecurityScan Operation</seealso>
        Task<StartCodeSecurityScanResponse> StartCodeSecurityScanAsync(StartCodeSecurityScanRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  StopCisSession


        /// <summary>
        /// Stops a CIS session. This API is used by the Amazon Inspector SSM plugin to communicate
        /// with the Amazon Inspector service. The Amazon Inspector SSM plugin calls this API
        /// to stop a CIS scan session for the scan ID supplied by the service.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopCisSession service method.</param>
        /// 
        /// <returns>The response from the StopCisSession service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ConflictException">
        /// A conflict occurred. This exception occurs when the same resource is being modified
        /// by concurrent requests.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/StopCisSession">REST API Reference for StopCisSession Operation</seealso>
        StopCisSessionResponse StopCisSession(StopCisSessionRequest request);



        /// <summary>
        /// Stops a CIS session. This API is used by the Amazon Inspector SSM plugin to communicate
        /// with the Amazon Inspector service. The Amazon Inspector SSM plugin calls this API
        /// to stop a CIS scan session for the scan ID supplied by the service.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopCisSession service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StopCisSession service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ConflictException">
        /// A conflict occurred. This exception occurs when the same resource is being modified
        /// by concurrent requests.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/StopCisSession">REST API Reference for StopCisSession Operation</seealso>
        Task<StopCisSessionResponse> StopCisSessionAsync(StopCisSessionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Adds tags to a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.BadRequestException">
        /// One or more tags submitted as part of the request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ResourceNotFoundException">
        /// The operation tried to access an invalid resource. Make sure the resource is specified
        /// correctly.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse TagResource(TagResourceRequest request);



        /// <summary>
        /// Adds tags to a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.BadRequestException">
        /// One or more tags submitted as part of the request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ResourceNotFoundException">
        /// The operation tried to access an invalid resource. Make sure the resource is specified
        /// correctly.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/TagResource">REST API Reference for TagResource Operation</seealso>
        Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// Removes tags from a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ResourceNotFoundException">
        /// The operation tried to access an invalid resource. Make sure the resource is specified
        /// correctly.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse UntagResource(UntagResourceRequest request);



        /// <summary>
        /// Removes tags from a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ResourceNotFoundException">
        /// The operation tried to access an invalid resource. Make sure the resource is specified
        /// correctly.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/UntagResource">REST API Reference for UntagResource Operation</seealso>
        Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateCisScanConfiguration


        /// <summary>
        /// Updates a CIS scan configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateCisScanConfiguration service method.</param>
        /// 
        /// <returns>The response from the UpdateCisScanConfiguration service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ResourceNotFoundException">
        /// The operation tried to access an invalid resource. Make sure the resource is specified
        /// correctly.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/UpdateCisScanConfiguration">REST API Reference for UpdateCisScanConfiguration Operation</seealso>
        UpdateCisScanConfigurationResponse UpdateCisScanConfiguration(UpdateCisScanConfigurationRequest request);



        /// <summary>
        /// Updates a CIS scan configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateCisScanConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateCisScanConfiguration service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ResourceNotFoundException">
        /// The operation tried to access an invalid resource. Make sure the resource is specified
        /// correctly.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/UpdateCisScanConfiguration">REST API Reference for UpdateCisScanConfiguration Operation</seealso>
        Task<UpdateCisScanConfigurationResponse> UpdateCisScanConfigurationAsync(UpdateCisScanConfigurationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateCodeSecurityIntegration


        /// <summary>
        /// Updates an existing code security integration.
        /// 
        ///  
        /// <para>
        /// After calling the <c>CreateCodeSecurityIntegration</c> operation, you complete authentication
        /// and authorization with your provider. Next you call the <c>UpdateCodeSecurityIntegration</c>
        /// operation to provide the <c>details</c> to complete the integration setup
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateCodeSecurityIntegration service method.</param>
        /// 
        /// <returns>The response from the UpdateCodeSecurityIntegration service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ConflictException">
        /// A conflict occurred. This exception occurs when the same resource is being modified
        /// by concurrent requests.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ResourceNotFoundException">
        /// The operation tried to access an invalid resource. Make sure the resource is specified
        /// correctly.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/UpdateCodeSecurityIntegration">REST API Reference for UpdateCodeSecurityIntegration Operation</seealso>
        UpdateCodeSecurityIntegrationResponse UpdateCodeSecurityIntegration(UpdateCodeSecurityIntegrationRequest request);



        /// <summary>
        /// Updates an existing code security integration.
        /// 
        ///  
        /// <para>
        /// After calling the <c>CreateCodeSecurityIntegration</c> operation, you complete authentication
        /// and authorization with your provider. Next you call the <c>UpdateCodeSecurityIntegration</c>
        /// operation to provide the <c>details</c> to complete the integration setup
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateCodeSecurityIntegration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateCodeSecurityIntegration service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ConflictException">
        /// A conflict occurred. This exception occurs when the same resource is being modified
        /// by concurrent requests.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ResourceNotFoundException">
        /// The operation tried to access an invalid resource. Make sure the resource is specified
        /// correctly.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/UpdateCodeSecurityIntegration">REST API Reference for UpdateCodeSecurityIntegration Operation</seealso>
        Task<UpdateCodeSecurityIntegrationResponse> UpdateCodeSecurityIntegrationAsync(UpdateCodeSecurityIntegrationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateCodeSecurityScanConfiguration


        /// <summary>
        /// Updates an existing code security scan configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateCodeSecurityScanConfiguration service method.</param>
        /// 
        /// <returns>The response from the UpdateCodeSecurityScanConfiguration service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ConflictException">
        /// A conflict occurred. This exception occurs when the same resource is being modified
        /// by concurrent requests.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ResourceNotFoundException">
        /// The operation tried to access an invalid resource. Make sure the resource is specified
        /// correctly.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/UpdateCodeSecurityScanConfiguration">REST API Reference for UpdateCodeSecurityScanConfiguration Operation</seealso>
        UpdateCodeSecurityScanConfigurationResponse UpdateCodeSecurityScanConfiguration(UpdateCodeSecurityScanConfigurationRequest request);



        /// <summary>
        /// Updates an existing code security scan configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateCodeSecurityScanConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateCodeSecurityScanConfiguration service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ConflictException">
        /// A conflict occurred. This exception occurs when the same resource is being modified
        /// by concurrent requests.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ResourceNotFoundException">
        /// The operation tried to access an invalid resource. Make sure the resource is specified
        /// correctly.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/UpdateCodeSecurityScanConfiguration">REST API Reference for UpdateCodeSecurityScanConfiguration Operation</seealso>
        Task<UpdateCodeSecurityScanConfigurationResponse> UpdateCodeSecurityScanConfigurationAsync(UpdateCodeSecurityScanConfigurationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateConfiguration


        /// <summary>
        /// Updates setting configurations for your Amazon Inspector account. When you use this
        /// API as an Amazon Inspector delegated administrator this updates the setting for all
        /// accounts you manage. Member accounts in an organization cannot update this setting.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateConfiguration service method.</param>
        /// 
        /// <returns>The response from the UpdateConfiguration service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/UpdateConfiguration">REST API Reference for UpdateConfiguration Operation</seealso>
        UpdateConfigurationResponse UpdateConfiguration(UpdateConfigurationRequest request);



        /// <summary>
        /// Updates setting configurations for your Amazon Inspector account. When you use this
        /// API as an Amazon Inspector delegated administrator this updates the setting for all
        /// accounts you manage. Member accounts in an organization cannot update this setting.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateConfiguration service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/UpdateConfiguration">REST API Reference for UpdateConfiguration Operation</seealso>
        Task<UpdateConfigurationResponse> UpdateConfigurationAsync(UpdateConfigurationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateEc2DeepInspectionConfiguration


        /// <summary>
        /// Activates, deactivates Amazon Inspector deep inspection, or updates custom paths for
        /// your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateEc2DeepInspectionConfiguration service method.</param>
        /// 
        /// <returns>The response from the UpdateEc2DeepInspectionConfiguration service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/UpdateEc2DeepInspectionConfiguration">REST API Reference for UpdateEc2DeepInspectionConfiguration Operation</seealso>
        UpdateEc2DeepInspectionConfigurationResponse UpdateEc2DeepInspectionConfiguration(UpdateEc2DeepInspectionConfigurationRequest request);



        /// <summary>
        /// Activates, deactivates Amazon Inspector deep inspection, or updates custom paths for
        /// your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateEc2DeepInspectionConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateEc2DeepInspectionConfiguration service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/UpdateEc2DeepInspectionConfiguration">REST API Reference for UpdateEc2DeepInspectionConfiguration Operation</seealso>
        Task<UpdateEc2DeepInspectionConfigurationResponse> UpdateEc2DeepInspectionConfigurationAsync(UpdateEc2DeepInspectionConfigurationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateEncryptionKey


        /// <summary>
        /// Updates an encryption key. A <c>ResourceNotFoundException</c> means that an Amazon
        /// Web Services owned key is being used for encryption.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateEncryptionKey service method.</param>
        /// 
        /// <returns>The response from the UpdateEncryptionKey service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ResourceNotFoundException">
        /// The operation tried to access an invalid resource. Make sure the resource is specified
        /// correctly.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/UpdateEncryptionKey">REST API Reference for UpdateEncryptionKey Operation</seealso>
        UpdateEncryptionKeyResponse UpdateEncryptionKey(UpdateEncryptionKeyRequest request);



        /// <summary>
        /// Updates an encryption key. A <c>ResourceNotFoundException</c> means that an Amazon
        /// Web Services owned key is being used for encryption.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateEncryptionKey service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateEncryptionKey service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ResourceNotFoundException">
        /// The operation tried to access an invalid resource. Make sure the resource is specified
        /// correctly.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/UpdateEncryptionKey">REST API Reference for UpdateEncryptionKey Operation</seealso>
        Task<UpdateEncryptionKeyResponse> UpdateEncryptionKeyAsync(UpdateEncryptionKeyRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateFilter


        /// <summary>
        /// Specifies the action that is to be applied to the findings that match the filter.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateFilter service method.</param>
        /// 
        /// <returns>The response from the UpdateFilter service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ResourceNotFoundException">
        /// The operation tried to access an invalid resource. Make sure the resource is specified
        /// correctly.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/UpdateFilter">REST API Reference for UpdateFilter Operation</seealso>
        UpdateFilterResponse UpdateFilter(UpdateFilterRequest request);



        /// <summary>
        /// Specifies the action that is to be applied to the findings that match the filter.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateFilter service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateFilter service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ResourceNotFoundException">
        /// The operation tried to access an invalid resource. Make sure the resource is specified
        /// correctly.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/UpdateFilter">REST API Reference for UpdateFilter Operation</seealso>
        Task<UpdateFilterResponse> UpdateFilterAsync(UpdateFilterRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateOrganizationConfiguration


        /// <summary>
        /// Updates the configurations for your Amazon Inspector organization.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateOrganizationConfiguration service method.</param>
        /// 
        /// <returns>The response from the UpdateOrganizationConfiguration service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/UpdateOrganizationConfiguration">REST API Reference for UpdateOrganizationConfiguration Operation</seealso>
        UpdateOrganizationConfigurationResponse UpdateOrganizationConfiguration(UpdateOrganizationConfigurationRequest request);



        /// <summary>
        /// Updates the configurations for your Amazon Inspector organization.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateOrganizationConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateOrganizationConfiguration service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/UpdateOrganizationConfiguration">REST API Reference for UpdateOrganizationConfiguration Operation</seealso>
        Task<UpdateOrganizationConfigurationResponse> UpdateOrganizationConfigurationAsync(UpdateOrganizationConfigurationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateOrgEc2DeepInspectionConfiguration


        /// <summary>
        /// Updates the Amazon Inspector deep inspection custom paths for your organization. You
        /// must be an Amazon Inspector delegated administrator to use this API.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateOrgEc2DeepInspectionConfiguration service method.</param>
        /// 
        /// <returns>The response from the UpdateOrgEc2DeepInspectionConfiguration service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/UpdateOrgEc2DeepInspectionConfiguration">REST API Reference for UpdateOrgEc2DeepInspectionConfiguration Operation</seealso>
        UpdateOrgEc2DeepInspectionConfigurationResponse UpdateOrgEc2DeepInspectionConfiguration(UpdateOrgEc2DeepInspectionConfigurationRequest request);



        /// <summary>
        /// Updates the Amazon Inspector deep inspection custom paths for your organization. You
        /// must be an Amazon Inspector delegated administrator to use this API.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateOrgEc2DeepInspectionConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateOrgEc2DeepInspectionConfiguration service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/UpdateOrgEc2DeepInspectionConfiguration">REST API Reference for UpdateOrgEc2DeepInspectionConfiguration Operation</seealso>
        Task<UpdateOrgEc2DeepInspectionConfigurationResponse> UpdateOrgEc2DeepInspectionConfigurationAsync(UpdateOrgEc2DeepInspectionConfigurationRequest request, CancellationToken cancellationToken = default(CancellationToken));

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