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
 * Do not modify this file. This file is generated from the connectcases-2022-10-03.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.ConnectCases.Model;

#pragma warning disable CS1570
namespace Amazon.ConnectCases
{
    /// <summary>
    /// <para>Interface for accessing ConnectCases</para>
    ///
    /// <ul> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/connect/latest/APIReference/API_Operations_Amazon_Connect_Cases.html">Cases
    /// actions</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/connect/latest/APIReference/API_Types_Amazon_Connect_Cases.html">Cases
    /// data types</a> 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// With Amazon Connect Cases, your agents can track and manage customer issues that require
    /// multiple interactions, follow-up tasks, and teams in your contact center. A case represents
    /// a customer issue. It records the issue, the steps and interactions taken to resolve
    /// the issue, and the outcome. For more information, see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/cases.html">Amazon
    /// Connect Cases</a> in the <i>Amazon Connect Administrator Guide</i>.
    /// </para>
    /// </summary>
    public partial interface IAmazonConnectCases : IAmazonService, IDisposable
    {
#if AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        IConnectCasesPaginatorFactory Paginators { get; }
#endif
                
        #region  BatchGetCaseRule



        /// <summary>
        /// Gets a batch of case rules. In the Amazon Connect admin website, case rules are known
        /// as <i>case field conditions</i>. For more information about case field conditions,
        /// see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/case-field-conditions.html">Add
        /// case field conditions to a case template</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetCaseRule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchGetCaseRule service method, as returned by ConnectCases.</returns>
        /// <exception cref="Amazon.ConnectCases.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.InternalServerException">
        /// We couldn't process your request because of an issue with the server. Try again later.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ResourceNotFoundException">
        /// We couldn't find the requested resource. Check that your resources exists and were
        /// created in the same Amazon Web Services Region as your request, and try your request
        /// again.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ThrottlingException">
        /// The rate has been exceeded for this API. Please try again after a few minutes.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ValidationException">
        /// The request isn't valid. Check the syntax and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcases-2022-10-03/BatchGetCaseRule">REST API Reference for BatchGetCaseRule Operation</seealso>
        Task<BatchGetCaseRuleResponse> BatchGetCaseRuleAsync(BatchGetCaseRuleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  BatchGetField



        /// <summary>
        /// Returns the description for the list of fields in the request parameters.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetField service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchGetField service method, as returned by ConnectCases.</returns>
        /// <exception cref="Amazon.ConnectCases.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.InternalServerException">
        /// We couldn't process your request because of an issue with the server. Try again later.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ResourceNotFoundException">
        /// We couldn't find the requested resource. Check that your resources exists and were
        /// created in the same Amazon Web Services Region as your request, and try your request
        /// again.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ThrottlingException">
        /// The rate has been exceeded for this API. Please try again after a few minutes.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ValidationException">
        /// The request isn't valid. Check the syntax and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcases-2022-10-03/BatchGetField">REST API Reference for BatchGetField Operation</seealso>
        Task<BatchGetFieldResponse> BatchGetFieldAsync(BatchGetFieldRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  BatchPutFieldOptions



        /// <summary>
        /// Creates and updates a set of field options for a single select field in a Cases domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchPutFieldOptions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchPutFieldOptions service method, as returned by ConnectCases.</returns>
        /// <exception cref="Amazon.ConnectCases.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.InternalServerException">
        /// We couldn't process your request because of an issue with the server. Try again later.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ResourceNotFoundException">
        /// We couldn't find the requested resource. Check that your resources exists and were
        /// created in the same Amazon Web Services Region as your request, and try your request
        /// again.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ServiceQuotaExceededException">
        /// The service quota has been exceeded. For a list of service quotas, see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/amazon-connect-service-limits.html">Amazon
        /// Connect Service Quotas</a> in the <i>Amazon Connect Administrator Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ThrottlingException">
        /// The rate has been exceeded for this API. Please try again after a few minutes.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ValidationException">
        /// The request isn't valid. Check the syntax and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcases-2022-10-03/BatchPutFieldOptions">REST API Reference for BatchPutFieldOptions Operation</seealso>
        Task<BatchPutFieldOptionsResponse> BatchPutFieldOptionsAsync(BatchPutFieldOptionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateCase



        /// <summary>
        /// <note> 
        /// <para>
        /// If you provide a value for <c>PerformedBy.UserArn</c> you must also have <a href="https://docs.aws.amazon.com/connect/latest/APIReference/API_DescribeUser.html">connect:DescribeUser</a>
        /// permission on the User ARN resource that you provide
        /// 
        ///  </note> 
        /// <para>
        /// Creates a case in the specified Cases domain. Case system and custom fields are taken
        /// as an array id/value pairs with a declared data types.
        /// </para>
        ///  
        /// <para>
        /// The following fields are required when creating a case:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>customer_id</c> - You must provide the full customer profile ARN in this format:
        /// <c>arn:aws:profile:your_AWS_Region:your_AWS_account ID:domains/your_profiles_domain_name/profiles/profile_ID</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>title</c> 
        /// </para>
        ///  </li> </ul>
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCase service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateCase service method, as returned by ConnectCases.</returns>
        /// <exception cref="Amazon.ConnectCases.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.InternalServerException">
        /// We couldn't process your request because of an issue with the server. Try again later.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ResourceNotFoundException">
        /// We couldn't find the requested resource. Check that your resources exists and were
        /// created in the same Amazon Web Services Region as your request, and try your request
        /// again.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ThrottlingException">
        /// The rate has been exceeded for this API. Please try again after a few minutes.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ValidationException">
        /// The request isn't valid. Check the syntax and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcases-2022-10-03/CreateCase">REST API Reference for CreateCase Operation</seealso>
        Task<CreateCaseResponse> CreateCaseAsync(CreateCaseRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateCaseRule



        /// <summary>
        /// Creates a new case rule. In the Amazon Connect admin website, case rules are known
        /// as <i>case field conditions</i>. For more information about case field conditions,
        /// see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/case-field-conditions.html">Add
        /// case field conditions to a case template</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCaseRule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateCaseRule service method, as returned by ConnectCases.</returns>
        /// <exception cref="Amazon.ConnectCases.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.InternalServerException">
        /// We couldn't process your request because of an issue with the server. Try again later.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ResourceNotFoundException">
        /// We couldn't find the requested resource. Check that your resources exists and were
        /// created in the same Amazon Web Services Region as your request, and try your request
        /// again.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ServiceQuotaExceededException">
        /// The service quota has been exceeded. For a list of service quotas, see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/amazon-connect-service-limits.html">Amazon
        /// Connect Service Quotas</a> in the <i>Amazon Connect Administrator Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ThrottlingException">
        /// The rate has been exceeded for this API. Please try again after a few minutes.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ValidationException">
        /// The request isn't valid. Check the syntax and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcases-2022-10-03/CreateCaseRule">REST API Reference for CreateCaseRule Operation</seealso>
        Task<CreateCaseRuleResponse> CreateCaseRuleAsync(CreateCaseRuleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateDomain



        /// <summary>
        /// Creates a domain, which is a container for all case data, such as cases, fields, templates
        /// and layouts. Each Amazon Connect instance can be associated with only one Cases domain.
        /// 
        ///  <important> 
        /// <para>
        /// This will not associate your connect instance to Cases domain. Instead, use the Amazon
        /// Connect <a href="https://docs.aws.amazon.com/connect/latest/APIReference/API_CreateIntegrationAssociation.html">CreateIntegrationAssociation</a>
        /// API. You need specific IAM permissions to successfully associate the Cases domain.
        /// For more information, see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/required-permissions-iam-cases.html#onboard-cases-iam">Onboard
        /// to Cases</a>.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDomain service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateDomain service method, as returned by ConnectCases.</returns>
        /// <exception cref="Amazon.ConnectCases.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.InternalServerException">
        /// We couldn't process your request because of an issue with the server. Try again later.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ServiceQuotaExceededException">
        /// The service quota has been exceeded. For a list of service quotas, see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/amazon-connect-service-limits.html">Amazon
        /// Connect Service Quotas</a> in the <i>Amazon Connect Administrator Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ThrottlingException">
        /// The rate has been exceeded for this API. Please try again after a few minutes.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ValidationException">
        /// The request isn't valid. Check the syntax and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcases-2022-10-03/CreateDomain">REST API Reference for CreateDomain Operation</seealso>
        Task<CreateDomainResponse> CreateDomainAsync(CreateDomainRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateField



        /// <summary>
        /// Creates a field in the Cases domain. This field is used to define the case object
        /// model (that is, defines what data can be captured on cases) in a Cases domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateField service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateField service method, as returned by ConnectCases.</returns>
        /// <exception cref="Amazon.ConnectCases.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.InternalServerException">
        /// We couldn't process your request because of an issue with the server. Try again later.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ResourceNotFoundException">
        /// We couldn't find the requested resource. Check that your resources exists and were
        /// created in the same Amazon Web Services Region as your request, and try your request
        /// again.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ServiceQuotaExceededException">
        /// The service quota has been exceeded. For a list of service quotas, see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/amazon-connect-service-limits.html">Amazon
        /// Connect Service Quotas</a> in the <i>Amazon Connect Administrator Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ThrottlingException">
        /// The rate has been exceeded for this API. Please try again after a few minutes.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ValidationException">
        /// The request isn't valid. Check the syntax and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcases-2022-10-03/CreateField">REST API Reference for CreateField Operation</seealso>
        Task<CreateFieldResponse> CreateFieldAsync(CreateFieldRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateLayout



        /// <summary>
        /// Creates a layout in the Cases domain. Layouts define the following configuration in
        /// the top section and More Info tab of the Cases user interface:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Fields to display to the users
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Field ordering
        /// </para>
        ///  </li> </ul> <note> 
        /// <para>
        /// Title and Status fields cannot be part of layouts since they are not configurable.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateLayout service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateLayout service method, as returned by ConnectCases.</returns>
        /// <exception cref="Amazon.ConnectCases.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.InternalServerException">
        /// We couldn't process your request because of an issue with the server. Try again later.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ResourceNotFoundException">
        /// We couldn't find the requested resource. Check that your resources exists and were
        /// created in the same Amazon Web Services Region as your request, and try your request
        /// again.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ServiceQuotaExceededException">
        /// The service quota has been exceeded. For a list of service quotas, see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/amazon-connect-service-limits.html">Amazon
        /// Connect Service Quotas</a> in the <i>Amazon Connect Administrator Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ThrottlingException">
        /// The rate has been exceeded for this API. Please try again after a few minutes.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ValidationException">
        /// The request isn't valid. Check the syntax and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcases-2022-10-03/CreateLayout">REST API Reference for CreateLayout Operation</seealso>
        Task<CreateLayoutResponse> CreateLayoutAsync(CreateLayoutRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateRelatedItem



        /// <summary>
        /// Creates a related item (comments, tasks, and contacts) and associates it with a case.
        /// 
        ///  <note> <ul> <li> 
        /// <para>
        /// A Related Item is a resource that is associated with a case. It may or may not have
        /// an external identifier linking it to an external resource (for example, a <c>contactArn</c>).
        /// All Related Items have their own internal identifier, the <c>relatedItemArn</c>. Examples
        /// of related items include <c>comments</c> and <c>contacts</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you provide a value for <c>performedBy.userArn</c> you must also have <a href="https://docs.aws.amazon.com/connect/latest/APIReference/API_DescribeUser.html">DescribeUser</a>
        /// permission on the ARN of the user that you provide.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The <c>type</c> field is reserved for internal use only.
        /// </para>
        ///  </li> </ul> </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRelatedItem service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateRelatedItem service method, as returned by ConnectCases.</returns>
        /// <exception cref="Amazon.ConnectCases.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.InternalServerException">
        /// We couldn't process your request because of an issue with the server. Try again later.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ResourceNotFoundException">
        /// We couldn't find the requested resource. Check that your resources exists and were
        /// created in the same Amazon Web Services Region as your request, and try your request
        /// again.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ServiceQuotaExceededException">
        /// The service quota has been exceeded. For a list of service quotas, see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/amazon-connect-service-limits.html">Amazon
        /// Connect Service Quotas</a> in the <i>Amazon Connect Administrator Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ThrottlingException">
        /// The rate has been exceeded for this API. Please try again after a few minutes.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ValidationException">
        /// The request isn't valid. Check the syntax and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcases-2022-10-03/CreateRelatedItem">REST API Reference for CreateRelatedItem Operation</seealso>
        Task<CreateRelatedItemResponse> CreateRelatedItemAsync(CreateRelatedItemRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateTemplate



        /// <summary>
        /// Creates a template in the Cases domain. This template is used to define the case object
        /// model (that is, to define what data can be captured on cases) in a Cases domain. A
        /// template must have a unique name within a domain, and it must reference existing field
        /// IDs and layout IDs. Additionally, multiple fields with same IDs are not allowed within
        /// the same Template. A template can be either Active or Inactive, as indicated by its
        /// status. Inactive templates cannot be used to create cases.
        /// 
        ///  
        /// <para>
        ///  Other template APIs are: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/connect/latest/APIReference/API_connect-cases_DeleteTemplate.html">DeleteTemplate</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/connect/latest/APIReference/API_connect-cases_GetTemplate.html">GetTemplate</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/connect/latest/APIReference/API_connect-cases_ListTemplates.html">ListTemplates</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/connect/latest/APIReference/API_connect-cases_UpdateTemplate.html">UpdateTemplate</a>
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTemplate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateTemplate service method, as returned by ConnectCases.</returns>
        /// <exception cref="Amazon.ConnectCases.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.InternalServerException">
        /// We couldn't process your request because of an issue with the server. Try again later.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ResourceNotFoundException">
        /// We couldn't find the requested resource. Check that your resources exists and were
        /// created in the same Amazon Web Services Region as your request, and try your request
        /// again.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ServiceQuotaExceededException">
        /// The service quota has been exceeded. For a list of service quotas, see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/amazon-connect-service-limits.html">Amazon
        /// Connect Service Quotas</a> in the <i>Amazon Connect Administrator Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ThrottlingException">
        /// The rate has been exceeded for this API. Please try again after a few minutes.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ValidationException">
        /// The request isn't valid. Check the syntax and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcases-2022-10-03/CreateTemplate">REST API Reference for CreateTemplate Operation</seealso>
        Task<CreateTemplateResponse> CreateTemplateAsync(CreateTemplateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteCase



        /// <summary>
        /// The DeleteCase API permanently deletes a case and all its associated resources from
        /// the cases data store. After a successful deletion, you cannot:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Retrieve related items
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Access audit history
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Perform any operations that require the CaseID
        /// </para>
        ///  </li> </ul> <important> 
        /// <para>
        /// This action is irreversible. After you delete a case, you cannot recover its data.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCase service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteCase service method, as returned by ConnectCases.</returns>
        /// <exception cref="Amazon.ConnectCases.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.InternalServerException">
        /// We couldn't process your request because of an issue with the server. Try again later.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ResourceNotFoundException">
        /// We couldn't find the requested resource. Check that your resources exists and were
        /// created in the same Amazon Web Services Region as your request, and try your request
        /// again.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ThrottlingException">
        /// The rate has been exceeded for this API. Please try again after a few minutes.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ValidationException">
        /// The request isn't valid. Check the syntax and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcases-2022-10-03/DeleteCase">REST API Reference for DeleteCase Operation</seealso>
        Task<DeleteCaseResponse> DeleteCaseAsync(DeleteCaseRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteCaseRule



        /// <summary>
        /// Deletes a case rule. In the Amazon Connect admin website, case rules are known as
        /// <i>case field conditions</i>. For more information about case field conditions, see
        /// <a href="https://docs.aws.amazon.com/connect/latest/adminguide/case-field-conditions.html">Add
        /// case field conditions to a case template</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCaseRule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteCaseRule service method, as returned by ConnectCases.</returns>
        /// <exception cref="Amazon.ConnectCases.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.InternalServerException">
        /// We couldn't process your request because of an issue with the server. Try again later.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ResourceNotFoundException">
        /// We couldn't find the requested resource. Check that your resources exists and were
        /// created in the same Amazon Web Services Region as your request, and try your request
        /// again.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ThrottlingException">
        /// The rate has been exceeded for this API. Please try again after a few minutes.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcases-2022-10-03/DeleteCaseRule">REST API Reference for DeleteCaseRule Operation</seealso>
        Task<DeleteCaseRuleResponse> DeleteCaseRuleAsync(DeleteCaseRuleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteDomain



        /// <summary>
        /// Deletes a Cases domain.
        /// 
        ///  <note> 
        /// <para>
        /// After deleting your domain you must disassociate the deleted domain from your Amazon
        /// Connect instance with another API call before being able to use Cases again with this
        /// Amazon Connect instance. See <a href="https://docs.aws.amazon.com/connect/latest/APIReference/API_DeleteIntegrationAssociation.html">DeleteIntegrationAssociation</a>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDomain service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteDomain service method, as returned by ConnectCases.</returns>
        /// <exception cref="Amazon.ConnectCases.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.InternalServerException">
        /// We couldn't process your request because of an issue with the server. Try again later.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ResourceNotFoundException">
        /// We couldn't find the requested resource. Check that your resources exists and were
        /// created in the same Amazon Web Services Region as your request, and try your request
        /// again.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ThrottlingException">
        /// The rate has been exceeded for this API. Please try again after a few minutes.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ValidationException">
        /// The request isn't valid. Check the syntax and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcases-2022-10-03/DeleteDomain">REST API Reference for DeleteDomain Operation</seealso>
        Task<DeleteDomainResponse> DeleteDomainAsync(DeleteDomainRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteField



        /// <summary>
        /// Deletes a field from a cases template. You can delete up to 100 fields per domain.
        /// 
        ///  
        /// <para>
        /// After a field is deleted:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// You can still retrieve the field by calling <c>BatchGetField</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You cannot update a deleted field by calling <c>UpdateField</c>; it throws a <c>ValidationException</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Deleted fields are not included in the <c>ListFields</c> response.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Calling <c>CreateCase</c> with a deleted field throws a <c>ValidationException</c>
        /// denoting which field IDs in the request have been deleted.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Calling <c>GetCase</c> with a deleted field ID returns the deleted field's value if
        /// one exists.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Calling <c>UpdateCase</c> with a deleted field ID throws a <c>ValidationException</c>
        /// if the case does not already contain a value for the deleted field. Otherwise it succeeds,
        /// allowing you to update or remove (using <c>emptyValue: {}</c>) the field's value from
        /// the case.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>GetTemplate</c> does not return field IDs for deleted fields.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>GetLayout</c> does not return field IDs for deleted fields.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Calling <c>SearchCases</c> with the deleted field ID as a filter returns any cases
        /// that have a value for the deleted field that matches the filter criteria.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Calling <c>SearchCases</c> with a <c>searchTerm</c> value that matches a deleted field's
        /// value on a case returns the case in the response.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Calling <c>BatchPutFieldOptions</c> with a deleted field ID throw a <c>ValidationException</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Calling <c>GetCaseEventConfiguration</c> does not return field IDs for deleted fields.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteField service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteField service method, as returned by ConnectCases.</returns>
        /// <exception cref="Amazon.ConnectCases.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.InternalServerException">
        /// We couldn't process your request because of an issue with the server. Try again later.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ResourceNotFoundException">
        /// We couldn't find the requested resource. Check that your resources exists and were
        /// created in the same Amazon Web Services Region as your request, and try your request
        /// again.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ServiceQuotaExceededException">
        /// The service quota has been exceeded. For a list of service quotas, see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/amazon-connect-service-limits.html">Amazon
        /// Connect Service Quotas</a> in the <i>Amazon Connect Administrator Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ThrottlingException">
        /// The rate has been exceeded for this API. Please try again after a few minutes.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ValidationException">
        /// The request isn't valid. Check the syntax and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcases-2022-10-03/DeleteField">REST API Reference for DeleteField Operation</seealso>
        Task<DeleteFieldResponse> DeleteFieldAsync(DeleteFieldRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteLayout



        /// <summary>
        /// Deletes a layout from a cases template. You can delete up to 100 layouts per domain.
        /// 
        ///  
        /// <para>
        /// After a layout is deleted:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// You can still retrieve the layout by calling <c>GetLayout</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You cannot update a deleted layout by calling <c>UpdateLayout</c>; it throws a <c>ValidationException</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Deleted layouts are not included in the <c>ListLayouts</c> response.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteLayout service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteLayout service method, as returned by ConnectCases.</returns>
        /// <exception cref="Amazon.ConnectCases.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.InternalServerException">
        /// We couldn't process your request because of an issue with the server. Try again later.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ResourceNotFoundException">
        /// We couldn't find the requested resource. Check that your resources exists and were
        /// created in the same Amazon Web Services Region as your request, and try your request
        /// again.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ThrottlingException">
        /// The rate has been exceeded for this API. Please try again after a few minutes.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ValidationException">
        /// The request isn't valid. Check the syntax and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcases-2022-10-03/DeleteLayout">REST API Reference for DeleteLayout Operation</seealso>
        Task<DeleteLayoutResponse> DeleteLayoutAsync(DeleteLayoutRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteRelatedItem



        /// <summary>
        /// Deletes the related item resource under a case.
        /// 
        ///  <note> 
        /// <para>
        /// This API cannot be used on a FILE type related attachment. To delete this type of
        /// file, use the <a href="https://docs.aws.amazon.com/connect/latest/APIReference/API_DeleteAttachedFile.html">DeleteAttachedFile</a>
        /// API
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRelatedItem service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteRelatedItem service method, as returned by ConnectCases.</returns>
        /// <exception cref="Amazon.ConnectCases.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.InternalServerException">
        /// We couldn't process your request because of an issue with the server. Try again later.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ResourceNotFoundException">
        /// We couldn't find the requested resource. Check that your resources exists and were
        /// created in the same Amazon Web Services Region as your request, and try your request
        /// again.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ThrottlingException">
        /// The rate has been exceeded for this API. Please try again after a few minutes.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ValidationException">
        /// The request isn't valid. Check the syntax and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcases-2022-10-03/DeleteRelatedItem">REST API Reference for DeleteRelatedItem Operation</seealso>
        Task<DeleteRelatedItemResponse> DeleteRelatedItemAsync(DeleteRelatedItemRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteTemplate



        /// <summary>
        /// Deletes a cases template. You can delete up to 100 templates per domain.
        /// 
        ///  
        /// <para>
        /// After a cases template is deleted:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// You can still retrieve the template by calling <c>GetTemplate</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You cannot update the template. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You cannot create a case by using the deleted template.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Deleted templates are not included in the <c>ListTemplates</c> response.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTemplate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteTemplate service method, as returned by ConnectCases.</returns>
        /// <exception cref="Amazon.ConnectCases.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.InternalServerException">
        /// We couldn't process your request because of an issue with the server. Try again later.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ResourceNotFoundException">
        /// We couldn't find the requested resource. Check that your resources exists and were
        /// created in the same Amazon Web Services Region as your request, and try your request
        /// again.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ThrottlingException">
        /// The rate has been exceeded for this API. Please try again after a few minutes.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ValidationException">
        /// The request isn't valid. Check the syntax and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcases-2022-10-03/DeleteTemplate">REST API Reference for DeleteTemplate Operation</seealso>
        Task<DeleteTemplateResponse> DeleteTemplateAsync(DeleteTemplateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetCase



        /// <summary>
        /// Returns information about a specific case if it exists.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCase service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetCase service method, as returned by ConnectCases.</returns>
        /// <exception cref="Amazon.ConnectCases.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.InternalServerException">
        /// We couldn't process your request because of an issue with the server. Try again later.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ResourceNotFoundException">
        /// We couldn't find the requested resource. Check that your resources exists and were
        /// created in the same Amazon Web Services Region as your request, and try your request
        /// again.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ThrottlingException">
        /// The rate has been exceeded for this API. Please try again after a few minutes.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ValidationException">
        /// The request isn't valid. Check the syntax and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcases-2022-10-03/GetCase">REST API Reference for GetCase Operation</seealso>
        Task<GetCaseResponse> GetCaseAsync(GetCaseRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetCaseAuditEvents



        /// <summary>
        /// Returns the audit history about a specific case if it exists.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCaseAuditEvents service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetCaseAuditEvents service method, as returned by ConnectCases.</returns>
        /// <exception cref="Amazon.ConnectCases.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.InternalServerException">
        /// We couldn't process your request because of an issue with the server. Try again later.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ResourceNotFoundException">
        /// We couldn't find the requested resource. Check that your resources exists and were
        /// created in the same Amazon Web Services Region as your request, and try your request
        /// again.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ThrottlingException">
        /// The rate has been exceeded for this API. Please try again after a few minutes.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ValidationException">
        /// The request isn't valid. Check the syntax and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcases-2022-10-03/GetCaseAuditEvents">REST API Reference for GetCaseAuditEvents Operation</seealso>
        Task<GetCaseAuditEventsResponse> GetCaseAuditEventsAsync(GetCaseAuditEventsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetCaseEventConfiguration



        /// <summary>
        /// Returns the case event publishing configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCaseEventConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetCaseEventConfiguration service method, as returned by ConnectCases.</returns>
        /// <exception cref="Amazon.ConnectCases.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.InternalServerException">
        /// We couldn't process your request because of an issue with the server. Try again later.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ResourceNotFoundException">
        /// We couldn't find the requested resource. Check that your resources exists and were
        /// created in the same Amazon Web Services Region as your request, and try your request
        /// again.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ThrottlingException">
        /// The rate has been exceeded for this API. Please try again after a few minutes.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ValidationException">
        /// The request isn't valid. Check the syntax and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcases-2022-10-03/GetCaseEventConfiguration">REST API Reference for GetCaseEventConfiguration Operation</seealso>
        Task<GetCaseEventConfigurationResponse> GetCaseEventConfigurationAsync(GetCaseEventConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetDomain



        /// <summary>
        /// Returns information about a specific domain if it exists.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDomain service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetDomain service method, as returned by ConnectCases.</returns>
        /// <exception cref="Amazon.ConnectCases.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.InternalServerException">
        /// We couldn't process your request because of an issue with the server. Try again later.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ResourceNotFoundException">
        /// We couldn't find the requested resource. Check that your resources exists and were
        /// created in the same Amazon Web Services Region as your request, and try your request
        /// again.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ThrottlingException">
        /// The rate has been exceeded for this API. Please try again after a few minutes.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ValidationException">
        /// The request isn't valid. Check the syntax and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcases-2022-10-03/GetDomain">REST API Reference for GetDomain Operation</seealso>
        Task<GetDomainResponse> GetDomainAsync(GetDomainRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetLayout



        /// <summary>
        /// Returns the details for the requested layout.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetLayout service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetLayout service method, as returned by ConnectCases.</returns>
        /// <exception cref="Amazon.ConnectCases.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.InternalServerException">
        /// We couldn't process your request because of an issue with the server. Try again later.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ResourceNotFoundException">
        /// We couldn't find the requested resource. Check that your resources exists and were
        /// created in the same Amazon Web Services Region as your request, and try your request
        /// again.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ThrottlingException">
        /// The rate has been exceeded for this API. Please try again after a few minutes.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ValidationException">
        /// The request isn't valid. Check the syntax and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcases-2022-10-03/GetLayout">REST API Reference for GetLayout Operation</seealso>
        Task<GetLayoutResponse> GetLayoutAsync(GetLayoutRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetTemplate



        /// <summary>
        /// Returns the details for the requested template. Other template APIs are: 
        /// 
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/connect/latest/APIReference/API_connect-cases_CreateTemplate.html">CreateTemplate</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/connect/latest/APIReference/API_connect-cases_DeleteTemplate.html">DeleteTemplate</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/connect/latest/APIReference/API_connect-cases_ListTemplates.html">ListTemplates</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/connect/latest/APIReference/API_connect-cases_UpdateTemplate.html">UpdateTemplate</a>
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTemplate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetTemplate service method, as returned by ConnectCases.</returns>
        /// <exception cref="Amazon.ConnectCases.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.InternalServerException">
        /// We couldn't process your request because of an issue with the server. Try again later.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ResourceNotFoundException">
        /// We couldn't find the requested resource. Check that your resources exists and were
        /// created in the same Amazon Web Services Region as your request, and try your request
        /// again.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ThrottlingException">
        /// The rate has been exceeded for this API. Please try again after a few minutes.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ValidationException">
        /// The request isn't valid. Check the syntax and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcases-2022-10-03/GetTemplate">REST API Reference for GetTemplate Operation</seealso>
        Task<GetTemplateResponse> GetTemplateAsync(GetTemplateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListCaseRules



        /// <summary>
        /// Lists all case rules in a Cases domain. In the Amazon Connect admin website, case
        /// rules are known as <i>case field conditions</i>. For more information about case field
        /// conditions, see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/case-field-conditions.html">Add
        /// case field conditions to a case template</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCaseRules service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListCaseRules service method, as returned by ConnectCases.</returns>
        /// <exception cref="Amazon.ConnectCases.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.InternalServerException">
        /// We couldn't process your request because of an issue with the server. Try again later.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ResourceNotFoundException">
        /// We couldn't find the requested resource. Check that your resources exists and were
        /// created in the same Amazon Web Services Region as your request, and try your request
        /// again.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ThrottlingException">
        /// The rate has been exceeded for this API. Please try again after a few minutes.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ValidationException">
        /// The request isn't valid. Check the syntax and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcases-2022-10-03/ListCaseRules">REST API Reference for ListCaseRules Operation</seealso>
        Task<ListCaseRulesResponse> ListCaseRulesAsync(ListCaseRulesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListCasesForContact



        /// <summary>
        /// Lists cases for a given contact.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCasesForContact service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListCasesForContact service method, as returned by ConnectCases.</returns>
        /// <exception cref="Amazon.ConnectCases.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.InternalServerException">
        /// We couldn't process your request because of an issue with the server. Try again later.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ResourceNotFoundException">
        /// We couldn't find the requested resource. Check that your resources exists and were
        /// created in the same Amazon Web Services Region as your request, and try your request
        /// again.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ThrottlingException">
        /// The rate has been exceeded for this API. Please try again after a few minutes.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ValidationException">
        /// The request isn't valid. Check the syntax and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcases-2022-10-03/ListCasesForContact">REST API Reference for ListCasesForContact Operation</seealso>
        Task<ListCasesForContactResponse> ListCasesForContactAsync(ListCasesForContactRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListDomains



        /// <summary>
        /// Lists all cases domains in the Amazon Web Services account. Each list item is a condensed
        /// summary object of the domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDomains service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListDomains service method, as returned by ConnectCases.</returns>
        /// <exception cref="Amazon.ConnectCases.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.InternalServerException">
        /// We couldn't process your request because of an issue with the server. Try again later.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ThrottlingException">
        /// The rate has been exceeded for this API. Please try again after a few minutes.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ValidationException">
        /// The request isn't valid. Check the syntax and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcases-2022-10-03/ListDomains">REST API Reference for ListDomains Operation</seealso>
        Task<ListDomainsResponse> ListDomainsAsync(ListDomainsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListFieldOptions



        /// <summary>
        /// Lists all of the field options for a field identifier in the domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFieldOptions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListFieldOptions service method, as returned by ConnectCases.</returns>
        /// <exception cref="Amazon.ConnectCases.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.InternalServerException">
        /// We couldn't process your request because of an issue with the server. Try again later.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ResourceNotFoundException">
        /// We couldn't find the requested resource. Check that your resources exists and were
        /// created in the same Amazon Web Services Region as your request, and try your request
        /// again.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ThrottlingException">
        /// The rate has been exceeded for this API. Please try again after a few minutes.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ValidationException">
        /// The request isn't valid. Check the syntax and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcases-2022-10-03/ListFieldOptions">REST API Reference for ListFieldOptions Operation</seealso>
        Task<ListFieldOptionsResponse> ListFieldOptionsAsync(ListFieldOptionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListFields



        /// <summary>
        /// Lists all fields in a Cases domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFields service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListFields service method, as returned by ConnectCases.</returns>
        /// <exception cref="Amazon.ConnectCases.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.InternalServerException">
        /// We couldn't process your request because of an issue with the server. Try again later.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ResourceNotFoundException">
        /// We couldn't find the requested resource. Check that your resources exists and were
        /// created in the same Amazon Web Services Region as your request, and try your request
        /// again.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ThrottlingException">
        /// The rate has been exceeded for this API. Please try again after a few minutes.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ValidationException">
        /// The request isn't valid. Check the syntax and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcases-2022-10-03/ListFields">REST API Reference for ListFields Operation</seealso>
        Task<ListFieldsResponse> ListFieldsAsync(ListFieldsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListLayouts



        /// <summary>
        /// Lists all layouts in the given cases domain. Each list item is a condensed summary
        /// object of the layout.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListLayouts service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListLayouts service method, as returned by ConnectCases.</returns>
        /// <exception cref="Amazon.ConnectCases.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.InternalServerException">
        /// We couldn't process your request because of an issue with the server. Try again later.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ResourceNotFoundException">
        /// We couldn't find the requested resource. Check that your resources exists and were
        /// created in the same Amazon Web Services Region as your request, and try your request
        /// again.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ThrottlingException">
        /// The rate has been exceeded for this API. Please try again after a few minutes.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ValidationException">
        /// The request isn't valid. Check the syntax and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcases-2022-10-03/ListLayouts">REST API Reference for ListLayouts Operation</seealso>
        Task<ListLayoutsResponse> ListLayoutsAsync(ListLayoutsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListTagsForResource



        /// <summary>
        /// Lists tags for a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by ConnectCases.</returns>
        /// <exception cref="Amazon.ConnectCases.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.InternalServerException">
        /// We couldn't process your request because of an issue with the server. Try again later.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ResourceNotFoundException">
        /// We couldn't find the requested resource. Check that your resources exists and were
        /// created in the same Amazon Web Services Region as your request, and try your request
        /// again.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ThrottlingException">
        /// The rate has been exceeded for this API. Please try again after a few minutes.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ValidationException">
        /// The request isn't valid. Check the syntax and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcases-2022-10-03/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListTemplates



        /// <summary>
        /// Lists all of the templates in a Cases domain. Each list item is a condensed summary
        /// object of the template. 
        /// 
        ///  
        /// <para>
        ///  Other template APIs are: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/connect/latest/APIReference/API_connect-cases_CreateTemplate.html">CreateTemplate</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/connect/latest/APIReference/API_connect-cases_DeleteTemplate.html">DeleteTemplate</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/connect/latest/APIReference/API_connect-cases_GetTemplate.html">GetTemplate</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/connect/latest/APIReference/API_connect-cases_UpdateTemplate.html">UpdateTemplate</a>
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTemplates service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTemplates service method, as returned by ConnectCases.</returns>
        /// <exception cref="Amazon.ConnectCases.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.InternalServerException">
        /// We couldn't process your request because of an issue with the server. Try again later.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ResourceNotFoundException">
        /// We couldn't find the requested resource. Check that your resources exists and were
        /// created in the same Amazon Web Services Region as your request, and try your request
        /// again.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ThrottlingException">
        /// The rate has been exceeded for this API. Please try again after a few minutes.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ValidationException">
        /// The request isn't valid. Check the syntax and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcases-2022-10-03/ListTemplates">REST API Reference for ListTemplates Operation</seealso>
        Task<ListTemplatesResponse> ListTemplatesAsync(ListTemplatesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  PutCaseEventConfiguration



        /// <summary>
        /// Adds case event publishing configuration. For a complete list of fields you can add
        /// to the event message, see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/case-fields.html">Create
        /// case fields</a> in the <i>Amazon Connect Administrator Guide</i>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutCaseEventConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutCaseEventConfiguration service method, as returned by ConnectCases.</returns>
        /// <exception cref="Amazon.ConnectCases.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.InternalServerException">
        /// We couldn't process your request because of an issue with the server. Try again later.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ResourceNotFoundException">
        /// We couldn't find the requested resource. Check that your resources exists and were
        /// created in the same Amazon Web Services Region as your request, and try your request
        /// again.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ThrottlingException">
        /// The rate has been exceeded for this API. Please try again after a few minutes.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ValidationException">
        /// The request isn't valid. Check the syntax and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcases-2022-10-03/PutCaseEventConfiguration">REST API Reference for PutCaseEventConfiguration Operation</seealso>
        Task<PutCaseEventConfigurationResponse> PutCaseEventConfigurationAsync(PutCaseEventConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  SearchCases



        /// <summary>
        /// Searches for cases within their associated Cases domain. Search results are returned
        /// as a paginated list of abridged case documents.
        /// 
        ///  <note> 
        /// <para>
        /// For <c>customer_id</c> you must provide the full customer profile ARN in this format:
        /// <c> arn:aws:profile:your AWS Region:your AWS account ID:domains/profiles domain name/profiles/profile
        /// ID</c>. 
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchCases service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SearchCases service method, as returned by ConnectCases.</returns>
        /// <exception cref="Amazon.ConnectCases.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.InternalServerException">
        /// We couldn't process your request because of an issue with the server. Try again later.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ResourceNotFoundException">
        /// We couldn't find the requested resource. Check that your resources exists and were
        /// created in the same Amazon Web Services Region as your request, and try your request
        /// again.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ThrottlingException">
        /// The rate has been exceeded for this API. Please try again after a few minutes.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ValidationException">
        /// The request isn't valid. Check the syntax and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcases-2022-10-03/SearchCases">REST API Reference for SearchCases Operation</seealso>
        Task<SearchCasesResponse> SearchCasesAsync(SearchCasesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  SearchRelatedItems



        /// <summary>
        /// Searches for related items that are associated with a case.
        /// 
        ///  <note> 
        /// <para>
        /// If no filters are provided, this returns all related items associated with a case.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchRelatedItems service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SearchRelatedItems service method, as returned by ConnectCases.</returns>
        /// <exception cref="Amazon.ConnectCases.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.InternalServerException">
        /// We couldn't process your request because of an issue with the server. Try again later.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ResourceNotFoundException">
        /// We couldn't find the requested resource. Check that your resources exists and were
        /// created in the same Amazon Web Services Region as your request, and try your request
        /// again.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ThrottlingException">
        /// The rate has been exceeded for this API. Please try again after a few minutes.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ValidationException">
        /// The request isn't valid. Check the syntax and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcases-2022-10-03/SearchRelatedItems">REST API Reference for SearchRelatedItems Operation</seealso>
        Task<SearchRelatedItemsResponse> SearchRelatedItemsAsync(SearchRelatedItemsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  TagResource



        /// <summary>
        /// Adds tags to a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by ConnectCases.</returns>
        /// <exception cref="Amazon.ConnectCases.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.InternalServerException">
        /// We couldn't process your request because of an issue with the server. Try again later.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ResourceNotFoundException">
        /// We couldn't find the requested resource. Check that your resources exists and were
        /// created in the same Amazon Web Services Region as your request, and try your request
        /// again.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ThrottlingException">
        /// The rate has been exceeded for this API. Please try again after a few minutes.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ValidationException">
        /// The request isn't valid. Check the syntax and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcases-2022-10-03/TagResource">REST API Reference for TagResource Operation</seealso>
        Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UntagResource



        /// <summary>
        /// Untags a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by ConnectCases.</returns>
        /// <exception cref="Amazon.ConnectCases.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.InternalServerException">
        /// We couldn't process your request because of an issue with the server. Try again later.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ResourceNotFoundException">
        /// We couldn't find the requested resource. Check that your resources exists and were
        /// created in the same Amazon Web Services Region as your request, and try your request
        /// again.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ThrottlingException">
        /// The rate has been exceeded for this API. Please try again after a few minutes.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ValidationException">
        /// The request isn't valid. Check the syntax and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcases-2022-10-03/UntagResource">REST API Reference for UntagResource Operation</seealso>
        Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateCase



        /// <summary>
        /// <note> 
        /// <para>
        /// If you provide a value for <c>PerformedBy.UserArn</c> you must also have <a href="https://docs.aws.amazon.com/connect/latest/APIReference/API_DescribeUser.html">connect:DescribeUser</a>
        /// permission on the User ARN resource that you provide
        /// 
        ///  </note> 
        /// <para>
        /// Updates the values of fields on a case. Fields to be updated are received as an array
        /// of id/value pairs identical to the <c>CreateCase</c> input .
        /// </para>
        ///  
        /// <para>
        /// If the action is successful, the service sends back an HTTP 200 response with an empty
        /// HTTP body.
        /// </para>
        /// 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateCase service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateCase service method, as returned by ConnectCases.</returns>
        /// <exception cref="Amazon.ConnectCases.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.InternalServerException">
        /// We couldn't process your request because of an issue with the server. Try again later.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ResourceNotFoundException">
        /// We couldn't find the requested resource. Check that your resources exists and were
        /// created in the same Amazon Web Services Region as your request, and try your request
        /// again.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ThrottlingException">
        /// The rate has been exceeded for this API. Please try again after a few minutes.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ValidationException">
        /// The request isn't valid. Check the syntax and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcases-2022-10-03/UpdateCase">REST API Reference for UpdateCase Operation</seealso>
        Task<UpdateCaseResponse> UpdateCaseAsync(UpdateCaseRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateCaseRule



        /// <summary>
        /// Updates a case rule. In the Amazon Connect admin website, case rules are known as
        /// <i>case field conditions</i>. For more information about case field conditions, see
        /// <a href="https://docs.aws.amazon.com/connect/latest/adminguide/case-field-conditions.html">Add
        /// case field conditions to a case template</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateCaseRule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateCaseRule service method, as returned by ConnectCases.</returns>
        /// <exception cref="Amazon.ConnectCases.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.InternalServerException">
        /// We couldn't process your request because of an issue with the server. Try again later.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ResourceNotFoundException">
        /// We couldn't find the requested resource. Check that your resources exists and were
        /// created in the same Amazon Web Services Region as your request, and try your request
        /// again.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ThrottlingException">
        /// The rate has been exceeded for this API. Please try again after a few minutes.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ValidationException">
        /// The request isn't valid. Check the syntax and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcases-2022-10-03/UpdateCaseRule">REST API Reference for UpdateCaseRule Operation</seealso>
        Task<UpdateCaseRuleResponse> UpdateCaseRuleAsync(UpdateCaseRuleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateField



        /// <summary>
        /// Updates the properties of an existing field.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateField service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateField service method, as returned by ConnectCases.</returns>
        /// <exception cref="Amazon.ConnectCases.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.InternalServerException">
        /// We couldn't process your request because of an issue with the server. Try again later.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ResourceNotFoundException">
        /// We couldn't find the requested resource. Check that your resources exists and were
        /// created in the same Amazon Web Services Region as your request, and try your request
        /// again.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ThrottlingException">
        /// The rate has been exceeded for this API. Please try again after a few minutes.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ValidationException">
        /// The request isn't valid. Check the syntax and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcases-2022-10-03/UpdateField">REST API Reference for UpdateField Operation</seealso>
        Task<UpdateFieldResponse> UpdateFieldAsync(UpdateFieldRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateLayout



        /// <summary>
        /// Updates the attributes of an existing layout.
        /// 
        ///  
        /// <para>
        /// If the action is successful, the service sends back an HTTP 200 response with an empty
        /// HTTP body.
        /// </para>
        ///  
        /// <para>
        /// A <c>ValidationException</c> is returned when you add non-existent <c>fieldIds</c>
        /// to a layout.
        /// </para>
        ///  <note> 
        /// <para>
        /// Title and Status fields cannot be part of layouts because they are not configurable.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateLayout service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateLayout service method, as returned by ConnectCases.</returns>
        /// <exception cref="Amazon.ConnectCases.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.InternalServerException">
        /// We couldn't process your request because of an issue with the server. Try again later.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ResourceNotFoundException">
        /// We couldn't find the requested resource. Check that your resources exists and were
        /// created in the same Amazon Web Services Region as your request, and try your request
        /// again.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ServiceQuotaExceededException">
        /// The service quota has been exceeded. For a list of service quotas, see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/amazon-connect-service-limits.html">Amazon
        /// Connect Service Quotas</a> in the <i>Amazon Connect Administrator Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ThrottlingException">
        /// The rate has been exceeded for this API. Please try again after a few minutes.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ValidationException">
        /// The request isn't valid. Check the syntax and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcases-2022-10-03/UpdateLayout">REST API Reference for UpdateLayout Operation</seealso>
        Task<UpdateLayoutResponse> UpdateLayoutAsync(UpdateLayoutRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateTemplate



        /// <summary>
        /// Updates the attributes of an existing template. The template attributes that can be
        /// modified include <c>name</c>, <c>description</c>, <c>layoutConfiguration</c>, <c>requiredFields</c>,
        /// and <c>status</c>. At least one of these attributes must not be null. If a null value
        /// is provided for a given attribute, that attribute is ignored and its current value
        /// is preserved.
        /// 
        ///  
        /// <para>
        /// Other template APIs are:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/connect/latest/APIReference/API_connect-cases_CreateTemplate.html">CreateTemplate</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/connect/latest/APIReference/API_connect-cases_DeleteTemplate.html">DeleteTemplate</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/connect/latest/APIReference/API_connect-cases_GetTemplate.html">GetTemplate</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/connect/latest/APIReference/API_connect-cases_ListTemplates.html">ListTemplates</a>
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateTemplate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateTemplate service method, as returned by ConnectCases.</returns>
        /// <exception cref="Amazon.ConnectCases.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.InternalServerException">
        /// We couldn't process your request because of an issue with the server. Try again later.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ResourceNotFoundException">
        /// We couldn't find the requested resource. Check that your resources exists and were
        /// created in the same Amazon Web Services Region as your request, and try your request
        /// again.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ThrottlingException">
        /// The rate has been exceeded for this API. Please try again after a few minutes.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ValidationException">
        /// The request isn't valid. Check the syntax and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcases-2022-10-03/UpdateTemplate">REST API Reference for UpdateTemplate Operation</seealso>
        Task<UpdateTemplateResponse> UpdateTemplateAsync(UpdateTemplateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

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
        [System.Diagnostics.CodeAnalysis.DynamicDependency(System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypes.PublicProperties, typeof(AmazonConnectCasesConfig))]
        static ClientConfig IAmazonService.CreateDefaultClientConfig() => new AmazonConnectCasesConfig();

        /// <inheritdoc/>
        [System.Diagnostics.CodeAnalysis.UnconditionalSuppressMessage("AssemblyLoadTrimming", "IL2026:RequiresUnreferencedCode",
    Justification = "This suppression is here to ignore the warnings caused by CognitoSync. See justification in IAmazonService.")]
        static IAmazonService IAmazonService.CreateDefaultServiceClient(AWSCredentials awsCredentials, ClientConfig clientConfig)
        {
            var serviceClientConfig = clientConfig as AmazonConnectCasesConfig;
            if (serviceClientConfig == null)
            {
                throw new AmazonClientException("ClientConfig is not of type AmazonConnectCasesConfig to create AmazonConnectCasesClient");
            }

            return awsCredentials == null ? 
                    new AmazonConnectCasesClient(serviceClientConfig) :
                    new AmazonConnectCasesClient(awsCredentials, serviceClientConfig);
        }
#pragma warning restore CA1033
#endif
        #endregion
    }
}