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
 * Do not modify this file. This file is generated from the mailmanager-2023-10-17.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.MailManager.Model;

#pragma warning disable CS1570
namespace Amazon.MailManager
{
    /// <summary>
    /// <para>Interface for accessing MailManager</para>
    ///
    /// Amazon SES Mail Manager API 
    /// <para>
    /// The Amazon SES Mail Manager API contains operations and data types that comprise the
    /// Mail Manager feature of <a href="http://aws.amazon.com/ses">Amazon Simple Email Service
    /// (SES)</a>.
    /// 
    ///  
    /// <para>
    /// Mail Manager is a set of Amazon SES email gateway features designed to help you strengthen
    /// your organization's email infrastructure, simplify email workflow management, and
    /// streamline email compliance control. To learn more, see the <a href="https://docs.aws.amazon.com/ses/latest/dg/eb.html">Mail
    /// Manager chapter</a> in the <i>Amazon SES Developer Guide</i>.
    /// </para>
    /// 
    /// </para>
    /// </summary>
    public partial interface IAmazonMailManager : IAmazonService, IDisposable
    {
#if AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        IMailManagerPaginatorFactory Paginators { get; }
#endif
                
        #region  CreateAddonInstance



        /// <summary>
        /// Creates an Add On instance for the subscription indicated in the request. The resulting
        /// Amazon Resource Name (ARN) can be used in a conditional statement for a rule set or
        /// traffic policy.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAddonInstance service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateAddonInstance service method, as returned by MailManager.</returns>
        /// <exception cref="Amazon.MailManager.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ResourceNotFoundException">
        /// Occurs when a requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ServiceQuotaExceededException">
        /// Occurs when an operation exceeds a predefined service quota or limit.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ValidationException">
        /// The request validation has failed. For details, see the accompanying error message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/CreateAddonInstance">REST API Reference for CreateAddonInstance Operation</seealso>
        Task<CreateAddonInstanceResponse> CreateAddonInstanceAsync(CreateAddonInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateAddonSubscription



        /// <summary>
        /// Creates a subscription for an Add On representing the acceptance of its terms of use
        /// and additional pricing. The subscription can then be used to create an instance for
        /// use in rule sets or traffic policies.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAddonSubscription service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateAddonSubscription service method, as returned by MailManager.</returns>
        /// <exception cref="Amazon.MailManager.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ServiceQuotaExceededException">
        /// Occurs when an operation exceeds a predefined service quota or limit.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ValidationException">
        /// The request validation has failed. For details, see the accompanying error message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/CreateAddonSubscription">REST API Reference for CreateAddonSubscription Operation</seealso>
        Task<CreateAddonSubscriptionResponse> CreateAddonSubscriptionAsync(CreateAddonSubscriptionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateArchive



        /// <summary>
        /// Creates a new email archive resource for storing and retaining emails.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateArchive service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateArchive service method, as returned by MailManager.</returns>
        /// <exception cref="Amazon.MailManager.Model.AccessDeniedException">
        /// Occurs when a user is denied access to a specific resource or action.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ServiceQuotaExceededException">
        /// Occurs when an operation exceeds a predefined service quota or limit.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ThrottlingException">
        /// Occurs when a service's request rate limit is exceeded, resulting in throttling of
        /// further requests.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ValidationException">
        /// The request validation has failed. For details, see the accompanying error message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/CreateArchive">REST API Reference for CreateArchive Operation</seealso>
        Task<CreateArchiveResponse> CreateArchiveAsync(CreateArchiveRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateIngressPoint



        /// <summary>
        /// Provision a new ingress endpoint resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateIngressPoint service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateIngressPoint service method, as returned by MailManager.</returns>
        /// <exception cref="Amazon.MailManager.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ServiceQuotaExceededException">
        /// Occurs when an operation exceeds a predefined service quota or limit.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ValidationException">
        /// The request validation has failed. For details, see the accompanying error message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/CreateIngressPoint">REST API Reference for CreateIngressPoint Operation</seealso>
        Task<CreateIngressPointResponse> CreateIngressPointAsync(CreateIngressPointRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateRelay



        /// <summary>
        /// Creates a relay resource which can be used in rules to relay incoming emails to defined
        /// relay destinations.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRelay service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateRelay service method, as returned by MailManager.</returns>
        /// <exception cref="Amazon.MailManager.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ServiceQuotaExceededException">
        /// Occurs when an operation exceeds a predefined service quota or limit.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ValidationException">
        /// The request validation has failed. For details, see the accompanying error message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/CreateRelay">REST API Reference for CreateRelay Operation</seealso>
        Task<CreateRelayResponse> CreateRelayAsync(CreateRelayRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateRuleSet



        /// <summary>
        /// Provision a new rule set.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRuleSet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateRuleSet service method, as returned by MailManager.</returns>
        /// <exception cref="Amazon.MailManager.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ServiceQuotaExceededException">
        /// Occurs when an operation exceeds a predefined service quota or limit.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ValidationException">
        /// The request validation has failed. For details, see the accompanying error message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/CreateRuleSet">REST API Reference for CreateRuleSet Operation</seealso>
        Task<CreateRuleSetResponse> CreateRuleSetAsync(CreateRuleSetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateTrafficPolicy



        /// <summary>
        /// Provision a new traffic policy resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTrafficPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateTrafficPolicy service method, as returned by MailManager.</returns>
        /// <exception cref="Amazon.MailManager.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ServiceQuotaExceededException">
        /// Occurs when an operation exceeds a predefined service quota or limit.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ValidationException">
        /// The request validation has failed. For details, see the accompanying error message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/CreateTrafficPolicy">REST API Reference for CreateTrafficPolicy Operation</seealso>
        Task<CreateTrafficPolicyResponse> CreateTrafficPolicyAsync(CreateTrafficPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteAddonInstance



        /// <summary>
        /// Deletes an Add On instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAddonInstance service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteAddonInstance service method, as returned by MailManager.</returns>
        /// <exception cref="Amazon.MailManager.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ValidationException">
        /// The request validation has failed. For details, see the accompanying error message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/DeleteAddonInstance">REST API Reference for DeleteAddonInstance Operation</seealso>
        Task<DeleteAddonInstanceResponse> DeleteAddonInstanceAsync(DeleteAddonInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteAddonSubscription



        /// <summary>
        /// Deletes an Add On subscription.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAddonSubscription service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteAddonSubscription service method, as returned by MailManager.</returns>
        /// <exception cref="Amazon.MailManager.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ValidationException">
        /// The request validation has failed. For details, see the accompanying error message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/DeleteAddonSubscription">REST API Reference for DeleteAddonSubscription Operation</seealso>
        Task<DeleteAddonSubscriptionResponse> DeleteAddonSubscriptionAsync(DeleteAddonSubscriptionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteArchive



        /// <summary>
        /// Initiates deletion of an email archive. This changes the archive state to pending
        /// deletion. In this state, no new emails can be added, and existing archived emails
        /// become inaccessible (search, export, download). The archive and all of its contents
        /// will be permanently deleted 30 days after entering the pending deletion state, regardless
        /// of the configured retention period.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteArchive service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteArchive service method, as returned by MailManager.</returns>
        /// <exception cref="Amazon.MailManager.Model.AccessDeniedException">
        /// Occurs when a user is denied access to a specific resource or action.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ThrottlingException">
        /// Occurs when a service's request rate limit is exceeded, resulting in throttling of
        /// further requests.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ValidationException">
        /// The request validation has failed. For details, see the accompanying error message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/DeleteArchive">REST API Reference for DeleteArchive Operation</seealso>
        Task<DeleteArchiveResponse> DeleteArchiveAsync(DeleteArchiveRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteIngressPoint



        /// <summary>
        /// Delete an ingress endpoint resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteIngressPoint service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteIngressPoint service method, as returned by MailManager.</returns>
        /// <exception cref="Amazon.MailManager.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ResourceNotFoundException">
        /// Occurs when a requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ValidationException">
        /// The request validation has failed. For details, see the accompanying error message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/DeleteIngressPoint">REST API Reference for DeleteIngressPoint Operation</seealso>
        Task<DeleteIngressPointResponse> DeleteIngressPointAsync(DeleteIngressPointRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteRelay



        /// <summary>
        /// Deletes an existing relay resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRelay service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteRelay service method, as returned by MailManager.</returns>
        /// <exception cref="Amazon.MailManager.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ResourceNotFoundException">
        /// Occurs when a requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ValidationException">
        /// The request validation has failed. For details, see the accompanying error message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/DeleteRelay">REST API Reference for DeleteRelay Operation</seealso>
        Task<DeleteRelayResponse> DeleteRelayAsync(DeleteRelayRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteRuleSet



        /// <summary>
        /// Delete a rule set.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRuleSet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteRuleSet service method, as returned by MailManager.</returns>
        /// <exception cref="Amazon.MailManager.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ValidationException">
        /// The request validation has failed. For details, see the accompanying error message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/DeleteRuleSet">REST API Reference for DeleteRuleSet Operation</seealso>
        Task<DeleteRuleSetResponse> DeleteRuleSetAsync(DeleteRuleSetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteTrafficPolicy



        /// <summary>
        /// Delete a traffic policy resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTrafficPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteTrafficPolicy service method, as returned by MailManager.</returns>
        /// <exception cref="Amazon.MailManager.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ResourceNotFoundException">
        /// Occurs when a requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ValidationException">
        /// The request validation has failed. For details, see the accompanying error message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/DeleteTrafficPolicy">REST API Reference for DeleteTrafficPolicy Operation</seealso>
        Task<DeleteTrafficPolicyResponse> DeleteTrafficPolicyAsync(DeleteTrafficPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetAddonInstance



        /// <summary>
        /// Gets detailed information about an Add On instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAddonInstance service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetAddonInstance service method, as returned by MailManager.</returns>
        /// <exception cref="Amazon.MailManager.Model.ResourceNotFoundException">
        /// Occurs when a requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ValidationException">
        /// The request validation has failed. For details, see the accompanying error message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/GetAddonInstance">REST API Reference for GetAddonInstance Operation</seealso>
        Task<GetAddonInstanceResponse> GetAddonInstanceAsync(GetAddonInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetAddonSubscription



        /// <summary>
        /// Gets detailed information about an Add On subscription.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAddonSubscription service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetAddonSubscription service method, as returned by MailManager.</returns>
        /// <exception cref="Amazon.MailManager.Model.ResourceNotFoundException">
        /// Occurs when a requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ValidationException">
        /// The request validation has failed. For details, see the accompanying error message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/GetAddonSubscription">REST API Reference for GetAddonSubscription Operation</seealso>
        Task<GetAddonSubscriptionResponse> GetAddonSubscriptionAsync(GetAddonSubscriptionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetArchive



        /// <summary>
        /// Retrieves the full details and current state of a specified email archive.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetArchive service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetArchive service method, as returned by MailManager.</returns>
        /// <exception cref="Amazon.MailManager.Model.AccessDeniedException">
        /// Occurs when a user is denied access to a specific resource or action.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ResourceNotFoundException">
        /// Occurs when a requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ThrottlingException">
        /// Occurs when a service's request rate limit is exceeded, resulting in throttling of
        /// further requests.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ValidationException">
        /// The request validation has failed. For details, see the accompanying error message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/GetArchive">REST API Reference for GetArchive Operation</seealso>
        Task<GetArchiveResponse> GetArchiveAsync(GetArchiveRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetArchiveExport



        /// <summary>
        /// Retrieves the details and current status of a specific email archive export job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetArchiveExport service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetArchiveExport service method, as returned by MailManager.</returns>
        /// <exception cref="Amazon.MailManager.Model.AccessDeniedException">
        /// Occurs when a user is denied access to a specific resource or action.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ThrottlingException">
        /// Occurs when a service's request rate limit is exceeded, resulting in throttling of
        /// further requests.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ValidationException">
        /// The request validation has failed. For details, see the accompanying error message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/GetArchiveExport">REST API Reference for GetArchiveExport Operation</seealso>
        Task<GetArchiveExportResponse> GetArchiveExportAsync(GetArchiveExportRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetArchiveMessage



        /// <summary>
        /// Returns a pre-signed URL that provides temporary download access to the specific email
        /// message stored in the archive.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetArchiveMessage service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetArchiveMessage service method, as returned by MailManager.</returns>
        /// <exception cref="Amazon.MailManager.Model.AccessDeniedException">
        /// Occurs when a user is denied access to a specific resource or action.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ThrottlingException">
        /// Occurs when a service's request rate limit is exceeded, resulting in throttling of
        /// further requests.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ValidationException">
        /// The request validation has failed. For details, see the accompanying error message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/GetArchiveMessage">REST API Reference for GetArchiveMessage Operation</seealso>
        Task<GetArchiveMessageResponse> GetArchiveMessageAsync(GetArchiveMessageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetArchiveMessageContent



        /// <summary>
        /// Returns the textual content of a specific email message stored in the archive. Attachments
        /// are not included.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetArchiveMessageContent service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetArchiveMessageContent service method, as returned by MailManager.</returns>
        /// <exception cref="Amazon.MailManager.Model.AccessDeniedException">
        /// Occurs when a user is denied access to a specific resource or action.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ThrottlingException">
        /// Occurs when a service's request rate limit is exceeded, resulting in throttling of
        /// further requests.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ValidationException">
        /// The request validation has failed. For details, see the accompanying error message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/GetArchiveMessageContent">REST API Reference for GetArchiveMessageContent Operation</seealso>
        Task<GetArchiveMessageContentResponse> GetArchiveMessageContentAsync(GetArchiveMessageContentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetArchiveSearch



        /// <summary>
        /// Retrieves the details and current status of a specific email archive search job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetArchiveSearch service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetArchiveSearch service method, as returned by MailManager.</returns>
        /// <exception cref="Amazon.MailManager.Model.AccessDeniedException">
        /// Occurs when a user is denied access to a specific resource or action.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ThrottlingException">
        /// Occurs when a service's request rate limit is exceeded, resulting in throttling of
        /// further requests.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ValidationException">
        /// The request validation has failed. For details, see the accompanying error message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/GetArchiveSearch">REST API Reference for GetArchiveSearch Operation</seealso>
        Task<GetArchiveSearchResponse> GetArchiveSearchAsync(GetArchiveSearchRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetArchiveSearchResults



        /// <summary>
        /// Returns the results of a completed email archive search job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetArchiveSearchResults service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetArchiveSearchResults service method, as returned by MailManager.</returns>
        /// <exception cref="Amazon.MailManager.Model.AccessDeniedException">
        /// Occurs when a user is denied access to a specific resource or action.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ThrottlingException">
        /// Occurs when a service's request rate limit is exceeded, resulting in throttling of
        /// further requests.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ValidationException">
        /// The request validation has failed. For details, see the accompanying error message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/GetArchiveSearchResults">REST API Reference for GetArchiveSearchResults Operation</seealso>
        Task<GetArchiveSearchResultsResponse> GetArchiveSearchResultsAsync(GetArchiveSearchResultsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetIngressPoint



        /// <summary>
        /// Fetch ingress endpoint resource attributes.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetIngressPoint service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetIngressPoint service method, as returned by MailManager.</returns>
        /// <exception cref="Amazon.MailManager.Model.ResourceNotFoundException">
        /// Occurs when a requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ValidationException">
        /// The request validation has failed. For details, see the accompanying error message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/GetIngressPoint">REST API Reference for GetIngressPoint Operation</seealso>
        Task<GetIngressPointResponse> GetIngressPointAsync(GetIngressPointRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetRelay



        /// <summary>
        /// Fetch the relay resource and it's attributes.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRelay service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetRelay service method, as returned by MailManager.</returns>
        /// <exception cref="Amazon.MailManager.Model.ResourceNotFoundException">
        /// Occurs when a requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ValidationException">
        /// The request validation has failed. For details, see the accompanying error message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/GetRelay">REST API Reference for GetRelay Operation</seealso>
        Task<GetRelayResponse> GetRelayAsync(GetRelayRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetRuleSet



        /// <summary>
        /// Fetch attributes of a rule set.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRuleSet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetRuleSet service method, as returned by MailManager.</returns>
        /// <exception cref="Amazon.MailManager.Model.ResourceNotFoundException">
        /// Occurs when a requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ValidationException">
        /// The request validation has failed. For details, see the accompanying error message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/GetRuleSet">REST API Reference for GetRuleSet Operation</seealso>
        Task<GetRuleSetResponse> GetRuleSetAsync(GetRuleSetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetTrafficPolicy



        /// <summary>
        /// Fetch attributes of a traffic policy resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTrafficPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetTrafficPolicy service method, as returned by MailManager.</returns>
        /// <exception cref="Amazon.MailManager.Model.ResourceNotFoundException">
        /// Occurs when a requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ValidationException">
        /// The request validation has failed. For details, see the accompanying error message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/GetTrafficPolicy">REST API Reference for GetTrafficPolicy Operation</seealso>
        Task<GetTrafficPolicyResponse> GetTrafficPolicyAsync(GetTrafficPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListAddonInstances



        /// <summary>
        /// Lists all Add On instances in your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAddonInstances service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAddonInstances service method, as returned by MailManager.</returns>
        /// <exception cref="Amazon.MailManager.Model.ValidationException">
        /// The request validation has failed. For details, see the accompanying error message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/ListAddonInstances">REST API Reference for ListAddonInstances Operation</seealso>
        Task<ListAddonInstancesResponse> ListAddonInstancesAsync(ListAddonInstancesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListAddonSubscriptions



        /// <summary>
        /// Lists all Add On subscriptions in your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAddonSubscriptions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAddonSubscriptions service method, as returned by MailManager.</returns>
        /// <exception cref="Amazon.MailManager.Model.ValidationException">
        /// The request validation has failed. For details, see the accompanying error message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/ListAddonSubscriptions">REST API Reference for ListAddonSubscriptions Operation</seealso>
        Task<ListAddonSubscriptionsResponse> ListAddonSubscriptionsAsync(ListAddonSubscriptionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListArchiveExports



        /// <summary>
        /// Returns a list of email archive export jobs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListArchiveExports service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListArchiveExports service method, as returned by MailManager.</returns>
        /// <exception cref="Amazon.MailManager.Model.AccessDeniedException">
        /// Occurs when a user is denied access to a specific resource or action.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ResourceNotFoundException">
        /// Occurs when a requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ThrottlingException">
        /// Occurs when a service's request rate limit is exceeded, resulting in throttling of
        /// further requests.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ValidationException">
        /// The request validation has failed. For details, see the accompanying error message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/ListArchiveExports">REST API Reference for ListArchiveExports Operation</seealso>
        Task<ListArchiveExportsResponse> ListArchiveExportsAsync(ListArchiveExportsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListArchives



        /// <summary>
        /// Returns a list of all email archives in your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListArchives service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListArchives service method, as returned by MailManager.</returns>
        /// <exception cref="Amazon.MailManager.Model.AccessDeniedException">
        /// Occurs when a user is denied access to a specific resource or action.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ThrottlingException">
        /// Occurs when a service's request rate limit is exceeded, resulting in throttling of
        /// further requests.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ValidationException">
        /// The request validation has failed. For details, see the accompanying error message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/ListArchives">REST API Reference for ListArchives Operation</seealso>
        Task<ListArchivesResponse> ListArchivesAsync(ListArchivesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListArchiveSearches



        /// <summary>
        /// Returns a list of email archive search jobs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListArchiveSearches service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListArchiveSearches service method, as returned by MailManager.</returns>
        /// <exception cref="Amazon.MailManager.Model.AccessDeniedException">
        /// Occurs when a user is denied access to a specific resource or action.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ResourceNotFoundException">
        /// Occurs when a requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ThrottlingException">
        /// Occurs when a service's request rate limit is exceeded, resulting in throttling of
        /// further requests.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ValidationException">
        /// The request validation has failed. For details, see the accompanying error message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/ListArchiveSearches">REST API Reference for ListArchiveSearches Operation</seealso>
        Task<ListArchiveSearchesResponse> ListArchiveSearchesAsync(ListArchiveSearchesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListIngressPoints



        /// <summary>
        /// List all ingress endpoint resources.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListIngressPoints service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListIngressPoints service method, as returned by MailManager.</returns>
        /// <exception cref="Amazon.MailManager.Model.ValidationException">
        /// The request validation has failed. For details, see the accompanying error message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/ListIngressPoints">REST API Reference for ListIngressPoints Operation</seealso>
        Task<ListIngressPointsResponse> ListIngressPointsAsync(ListIngressPointsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListRelays



        /// <summary>
        /// Lists all the existing relay resources.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRelays service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListRelays service method, as returned by MailManager.</returns>
        /// <exception cref="Amazon.MailManager.Model.ValidationException">
        /// The request validation has failed. For details, see the accompanying error message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/ListRelays">REST API Reference for ListRelays Operation</seealso>
        Task<ListRelaysResponse> ListRelaysAsync(ListRelaysRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListRuleSets



        /// <summary>
        /// List rule sets for this account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRuleSets service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListRuleSets service method, as returned by MailManager.</returns>
        /// <exception cref="Amazon.MailManager.Model.ValidationException">
        /// The request validation has failed. For details, see the accompanying error message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/ListRuleSets">REST API Reference for ListRuleSets Operation</seealso>
        Task<ListRuleSetsResponse> ListRuleSetsAsync(ListRuleSetsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListTagsForResource



        /// <summary>
        /// Retrieves the list of tags (keys and values) assigned to the resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by MailManager.</returns>
        /// <exception cref="Amazon.MailManager.Model.ResourceNotFoundException">
        /// Occurs when a requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ValidationException">
        /// The request validation has failed. For details, see the accompanying error message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListTrafficPolicies



        /// <summary>
        /// List traffic policy resources.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTrafficPolicies service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTrafficPolicies service method, as returned by MailManager.</returns>
        /// <exception cref="Amazon.MailManager.Model.ValidationException">
        /// The request validation has failed. For details, see the accompanying error message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/ListTrafficPolicies">REST API Reference for ListTrafficPolicies Operation</seealso>
        Task<ListTrafficPoliciesResponse> ListTrafficPoliciesAsync(ListTrafficPoliciesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  StartArchiveExport



        /// <summary>
        /// Initiates an export of emails from the specified archive.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartArchiveExport service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartArchiveExport service method, as returned by MailManager.</returns>
        /// <exception cref="Amazon.MailManager.Model.AccessDeniedException">
        /// Occurs when a user is denied access to a specific resource or action.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ResourceNotFoundException">
        /// Occurs when a requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ServiceQuotaExceededException">
        /// Occurs when an operation exceeds a predefined service quota or limit.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ThrottlingException">
        /// Occurs when a service's request rate limit is exceeded, resulting in throttling of
        /// further requests.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ValidationException">
        /// The request validation has failed. For details, see the accompanying error message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/StartArchiveExport">REST API Reference for StartArchiveExport Operation</seealso>
        Task<StartArchiveExportResponse> StartArchiveExportAsync(StartArchiveExportRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  StartArchiveSearch



        /// <summary>
        /// Initiates a search across emails in the specified archive.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartArchiveSearch service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartArchiveSearch service method, as returned by MailManager.</returns>
        /// <exception cref="Amazon.MailManager.Model.AccessDeniedException">
        /// Occurs when a user is denied access to a specific resource or action.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ResourceNotFoundException">
        /// Occurs when a requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ServiceQuotaExceededException">
        /// Occurs when an operation exceeds a predefined service quota or limit.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ThrottlingException">
        /// Occurs when a service's request rate limit is exceeded, resulting in throttling of
        /// further requests.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ValidationException">
        /// The request validation has failed. For details, see the accompanying error message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/StartArchiveSearch">REST API Reference for StartArchiveSearch Operation</seealso>
        Task<StartArchiveSearchResponse> StartArchiveSearchAsync(StartArchiveSearchRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  StopArchiveExport



        /// <summary>
        /// Stops an in-progress export of emails from an archive.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopArchiveExport service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StopArchiveExport service method, as returned by MailManager.</returns>
        /// <exception cref="Amazon.MailManager.Model.AccessDeniedException">
        /// Occurs when a user is denied access to a specific resource or action.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ThrottlingException">
        /// Occurs when a service's request rate limit is exceeded, resulting in throttling of
        /// further requests.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ValidationException">
        /// The request validation has failed. For details, see the accompanying error message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/StopArchiveExport">REST API Reference for StopArchiveExport Operation</seealso>
        Task<StopArchiveExportResponse> StopArchiveExportAsync(StopArchiveExportRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  StopArchiveSearch



        /// <summary>
        /// Stops an in-progress archive search job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopArchiveSearch service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StopArchiveSearch service method, as returned by MailManager.</returns>
        /// <exception cref="Amazon.MailManager.Model.AccessDeniedException">
        /// Occurs when a user is denied access to a specific resource or action.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ThrottlingException">
        /// Occurs when a service's request rate limit is exceeded, resulting in throttling of
        /// further requests.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ValidationException">
        /// The request validation has failed. For details, see the accompanying error message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/StopArchiveSearch">REST API Reference for StopArchiveSearch Operation</seealso>
        Task<StopArchiveSearchResponse> StopArchiveSearchAsync(StopArchiveSearchRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  TagResource



        /// <summary>
        /// Adds one or more tags (keys and values) to a specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by MailManager.</returns>
        /// <exception cref="Amazon.MailManager.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ResourceNotFoundException">
        /// Occurs when a requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ServiceQuotaExceededException">
        /// Occurs when an operation exceeds a predefined service quota or limit.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ValidationException">
        /// The request validation has failed. For details, see the accompanying error message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/TagResource">REST API Reference for TagResource Operation</seealso>
        Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UntagResource



        /// <summary>
        /// Remove one or more tags (keys and values) from a specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by MailManager.</returns>
        /// <exception cref="Amazon.MailManager.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ResourceNotFoundException">
        /// Occurs when a requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ValidationException">
        /// The request validation has failed. For details, see the accompanying error message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/UntagResource">REST API Reference for UntagResource Operation</seealso>
        Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateArchive



        /// <summary>
        /// Updates the attributes of an existing email archive.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateArchive service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateArchive service method, as returned by MailManager.</returns>
        /// <exception cref="Amazon.MailManager.Model.AccessDeniedException">
        /// Occurs when a user is denied access to a specific resource or action.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ResourceNotFoundException">
        /// Occurs when a requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ServiceQuotaExceededException">
        /// Occurs when an operation exceeds a predefined service quota or limit.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ThrottlingException">
        /// Occurs when a service's request rate limit is exceeded, resulting in throttling of
        /// further requests.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ValidationException">
        /// The request validation has failed. For details, see the accompanying error message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/UpdateArchive">REST API Reference for UpdateArchive Operation</seealso>
        Task<UpdateArchiveResponse> UpdateArchiveAsync(UpdateArchiveRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateIngressPoint



        /// <summary>
        /// Update attributes of a provisioned ingress endpoint resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateIngressPoint service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateIngressPoint service method, as returned by MailManager.</returns>
        /// <exception cref="Amazon.MailManager.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ResourceNotFoundException">
        /// Occurs when a requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ValidationException">
        /// The request validation has failed. For details, see the accompanying error message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/UpdateIngressPoint">REST API Reference for UpdateIngressPoint Operation</seealso>
        Task<UpdateIngressPointResponse> UpdateIngressPointAsync(UpdateIngressPointRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateRelay



        /// <summary>
        /// Updates the attributes of an existing relay resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRelay service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateRelay service method, as returned by MailManager.</returns>
        /// <exception cref="Amazon.MailManager.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ResourceNotFoundException">
        /// Occurs when a requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ValidationException">
        /// The request validation has failed. For details, see the accompanying error message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/UpdateRelay">REST API Reference for UpdateRelay Operation</seealso>
        Task<UpdateRelayResponse> UpdateRelayAsync(UpdateRelayRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateRuleSet



        /// <summary>
        /// Update attributes of an already provisioned rule set.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRuleSet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateRuleSet service method, as returned by MailManager.</returns>
        /// <exception cref="Amazon.MailManager.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ResourceNotFoundException">
        /// Occurs when a requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ValidationException">
        /// The request validation has failed. For details, see the accompanying error message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/UpdateRuleSet">REST API Reference for UpdateRuleSet Operation</seealso>
        Task<UpdateRuleSetResponse> UpdateRuleSetAsync(UpdateRuleSetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateTrafficPolicy



        /// <summary>
        /// Update attributes of an already provisioned traffic policy resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateTrafficPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateTrafficPolicy service method, as returned by MailManager.</returns>
        /// <exception cref="Amazon.MailManager.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ResourceNotFoundException">
        /// Occurs when a requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ValidationException">
        /// The request validation has failed. For details, see the accompanying error message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/UpdateTrafficPolicy">REST API Reference for UpdateTrafficPolicy Operation</seealso>
        Task<UpdateTrafficPolicyResponse> UpdateTrafficPolicyAsync(UpdateTrafficPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

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