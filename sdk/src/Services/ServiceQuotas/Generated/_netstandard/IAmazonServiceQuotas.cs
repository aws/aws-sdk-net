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
 * Do not modify this file. This file is generated from the service-quotas-2019-06-24.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.ServiceQuotas.Model;

namespace Amazon.ServiceQuotas
{
    /// <summary>
    /// Interface for accessing ServiceQuotas
    ///
    /// With Service Quotas, you can view and manage your quotas easily as your AWS workloads
    /// grow. Quotas, also referred to as limits, are the maximum number of resources that
    /// you can create in your AWS account. For more information, see the <a href="https://docs.aws.amazon.com/servicequotas/latest/userguide/">Service
    /// Quotas User Guide</a>.
    /// </summary>
#if NETSTANDARD13
    [Obsolete("Support for .NET Standard 1.3 is in maintenance mode and will only receive critical bug fixes and security patches. Visit https://docs.aws.amazon.com/sdk-for-net/v3/developer-guide/migration-from-net-standard-1-3.html for further details.")]
#endif
    public partial interface IAmazonServiceQuotas : IAmazonService, IDisposable
    {
#if AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        IServiceQuotasPaginatorFactory Paginators { get; }
#endif
                
        #region  AssociateServiceQuotaTemplate



        /// <summary>
        /// Associates your quota request template with your organization. When a new account
        /// is created in your organization, the quota increase requests in the template are automatically
        /// applied to the account. You can add a quota increase request for any adjustable quota
        /// to your template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateServiceQuotaTemplate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AssociateServiceQuotaTemplate service method, as returned by ServiceQuotas.</returns>
        /// <exception cref="Amazon.ServiceQuotas.Model.AccessDeniedException">
        /// You do not have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.AWSServiceAccessNotEnabledException">
        /// The action you attempted is not allowed unless Service Access with Service Quotas
        /// is enabled in your organization.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.DependencyAccessDeniedException">
        /// You can't perform this action because a dependency does not have access.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.NoAvailableOrganizationException">
        /// The account making this call is not a member of an organization.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.OrganizationNotInAllFeaturesModeException">
        /// The organization that your account belongs to is not in All Features mode.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.ServiceException">
        /// Something went wrong.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.TemplatesNotAvailableInRegionException">
        /// The Service Quotas template is not available in this AWS Region.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.TooManyRequestsException">
        /// Due to throttling, the request was denied. Slow down the rate of request calls, or
        /// request an increase for this quota.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/service-quotas-2019-06-24/AssociateServiceQuotaTemplate">REST API Reference for AssociateServiceQuotaTemplate Operation</seealso>
        Task<AssociateServiceQuotaTemplateResponse> AssociateServiceQuotaTemplateAsync(AssociateServiceQuotaTemplateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteServiceQuotaIncreaseRequestFromTemplate



        /// <summary>
        /// Deletes the quota increase request for the specified quota from your quota request
        /// template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteServiceQuotaIncreaseRequestFromTemplate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteServiceQuotaIncreaseRequestFromTemplate service method, as returned by ServiceQuotas.</returns>
        /// <exception cref="Amazon.ServiceQuotas.Model.AccessDeniedException">
        /// You do not have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.AWSServiceAccessNotEnabledException">
        /// The action you attempted is not allowed unless Service Access with Service Quotas
        /// is enabled in your organization.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.DependencyAccessDeniedException">
        /// You can't perform this action because a dependency does not have access.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.IllegalArgumentException">
        /// Invalid input was provided.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.NoAvailableOrganizationException">
        /// The account making this call is not a member of an organization.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.NoSuchResourceException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.ServiceException">
        /// Something went wrong.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.TemplatesNotAvailableInRegionException">
        /// The Service Quotas template is not available in this AWS Region.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.TooManyRequestsException">
        /// Due to throttling, the request was denied. Slow down the rate of request calls, or
        /// request an increase for this quota.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/service-quotas-2019-06-24/DeleteServiceQuotaIncreaseRequestFromTemplate">REST API Reference for DeleteServiceQuotaIncreaseRequestFromTemplate Operation</seealso>
        Task<DeleteServiceQuotaIncreaseRequestFromTemplateResponse> DeleteServiceQuotaIncreaseRequestFromTemplateAsync(DeleteServiceQuotaIncreaseRequestFromTemplateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DisassociateServiceQuotaTemplate



        /// <summary>
        /// Disables your quota request template. After a template is disabled, the quota increase
        /// requests in the template are not applied to new accounts in your organization. Disabling
        /// a quota request template does not apply its quota increase requests.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateServiceQuotaTemplate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisassociateServiceQuotaTemplate service method, as returned by ServiceQuotas.</returns>
        /// <exception cref="Amazon.ServiceQuotas.Model.AccessDeniedException">
        /// You do not have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.AWSServiceAccessNotEnabledException">
        /// The action you attempted is not allowed unless Service Access with Service Quotas
        /// is enabled in your organization.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.DependencyAccessDeniedException">
        /// You can't perform this action because a dependency does not have access.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.NoAvailableOrganizationException">
        /// The account making this call is not a member of an organization.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.ServiceException">
        /// Something went wrong.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.ServiceQuotaTemplateNotInUseException">
        /// The quota request template is not associated with your organization.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.TemplatesNotAvailableInRegionException">
        /// The Service Quotas template is not available in this AWS Region.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.TooManyRequestsException">
        /// Due to throttling, the request was denied. Slow down the rate of request calls, or
        /// request an increase for this quota.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/service-quotas-2019-06-24/DisassociateServiceQuotaTemplate">REST API Reference for DisassociateServiceQuotaTemplate Operation</seealso>
        Task<DisassociateServiceQuotaTemplateResponse> DisassociateServiceQuotaTemplateAsync(DisassociateServiceQuotaTemplateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetAssociationForServiceQuotaTemplate



        /// <summary>
        /// Retrieves the status of the association for the quota request template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAssociationForServiceQuotaTemplate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetAssociationForServiceQuotaTemplate service method, as returned by ServiceQuotas.</returns>
        /// <exception cref="Amazon.ServiceQuotas.Model.AccessDeniedException">
        /// You do not have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.AWSServiceAccessNotEnabledException">
        /// The action you attempted is not allowed unless Service Access with Service Quotas
        /// is enabled in your organization.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.DependencyAccessDeniedException">
        /// You can't perform this action because a dependency does not have access.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.NoAvailableOrganizationException">
        /// The account making this call is not a member of an organization.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.ServiceException">
        /// Something went wrong.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.ServiceQuotaTemplateNotInUseException">
        /// The quota request template is not associated with your organization.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.TemplatesNotAvailableInRegionException">
        /// The Service Quotas template is not available in this AWS Region.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.TooManyRequestsException">
        /// Due to throttling, the request was denied. Slow down the rate of request calls, or
        /// request an increase for this quota.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/service-quotas-2019-06-24/GetAssociationForServiceQuotaTemplate">REST API Reference for GetAssociationForServiceQuotaTemplate Operation</seealso>
        Task<GetAssociationForServiceQuotaTemplateResponse> GetAssociationForServiceQuotaTemplateAsync(GetAssociationForServiceQuotaTemplateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetAWSDefaultServiceQuota



        /// <summary>
        /// Retrieves the default value for the specified quota. The default value does not reflect
        /// any quota increases.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAWSDefaultServiceQuota service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetAWSDefaultServiceQuota service method, as returned by ServiceQuotas.</returns>
        /// <exception cref="Amazon.ServiceQuotas.Model.AccessDeniedException">
        /// You do not have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.IllegalArgumentException">
        /// Invalid input was provided.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.NoSuchResourceException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.ServiceException">
        /// Something went wrong.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.TooManyRequestsException">
        /// Due to throttling, the request was denied. Slow down the rate of request calls, or
        /// request an increase for this quota.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/service-quotas-2019-06-24/GetAWSDefaultServiceQuota">REST API Reference for GetAWSDefaultServiceQuota Operation</seealso>
        Task<GetAWSDefaultServiceQuotaResponse> GetAWSDefaultServiceQuotaAsync(GetAWSDefaultServiceQuotaRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetRequestedServiceQuotaChange



        /// <summary>
        /// Retrieves information about the specified quota increase request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRequestedServiceQuotaChange service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetRequestedServiceQuotaChange service method, as returned by ServiceQuotas.</returns>
        /// <exception cref="Amazon.ServiceQuotas.Model.AccessDeniedException">
        /// You do not have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.IllegalArgumentException">
        /// Invalid input was provided.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.NoSuchResourceException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.ServiceException">
        /// Something went wrong.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.TooManyRequestsException">
        /// Due to throttling, the request was denied. Slow down the rate of request calls, or
        /// request an increase for this quota.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/service-quotas-2019-06-24/GetRequestedServiceQuotaChange">REST API Reference for GetRequestedServiceQuotaChange Operation</seealso>
        Task<GetRequestedServiceQuotaChangeResponse> GetRequestedServiceQuotaChangeAsync(GetRequestedServiceQuotaChangeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetServiceQuota



        /// <summary>
        /// Retrieves the applied quota value for the specified quota. For some quotas, only the
        /// default values are available. If the applied quota value is not available for a quota,
        /// the quota is not retrieved.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetServiceQuota service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetServiceQuota service method, as returned by ServiceQuotas.</returns>
        /// <exception cref="Amazon.ServiceQuotas.Model.AccessDeniedException">
        /// You do not have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.IllegalArgumentException">
        /// Invalid input was provided.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.NoSuchResourceException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.ServiceException">
        /// Something went wrong.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.TooManyRequestsException">
        /// Due to throttling, the request was denied. Slow down the rate of request calls, or
        /// request an increase for this quota.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/service-quotas-2019-06-24/GetServiceQuota">REST API Reference for GetServiceQuota Operation</seealso>
        Task<GetServiceQuotaResponse> GetServiceQuotaAsync(GetServiceQuotaRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetServiceQuotaIncreaseRequestFromTemplate



        /// <summary>
        /// Retrieves information about the specified quota increase request in your quota request
        /// template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetServiceQuotaIncreaseRequestFromTemplate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetServiceQuotaIncreaseRequestFromTemplate service method, as returned by ServiceQuotas.</returns>
        /// <exception cref="Amazon.ServiceQuotas.Model.AccessDeniedException">
        /// You do not have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.AWSServiceAccessNotEnabledException">
        /// The action you attempted is not allowed unless Service Access with Service Quotas
        /// is enabled in your organization.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.DependencyAccessDeniedException">
        /// You can't perform this action because a dependency does not have access.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.IllegalArgumentException">
        /// Invalid input was provided.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.NoAvailableOrganizationException">
        /// The account making this call is not a member of an organization.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.NoSuchResourceException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.ServiceException">
        /// Something went wrong.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.TemplatesNotAvailableInRegionException">
        /// The Service Quotas template is not available in this AWS Region.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.TooManyRequestsException">
        /// Due to throttling, the request was denied. Slow down the rate of request calls, or
        /// request an increase for this quota.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/service-quotas-2019-06-24/GetServiceQuotaIncreaseRequestFromTemplate">REST API Reference for GetServiceQuotaIncreaseRequestFromTemplate Operation</seealso>
        Task<GetServiceQuotaIncreaseRequestFromTemplateResponse> GetServiceQuotaIncreaseRequestFromTemplateAsync(GetServiceQuotaIncreaseRequestFromTemplateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListAWSDefaultServiceQuotas



        /// <summary>
        /// Lists the default values for the quotas for the specified AWS service. A default value
        /// does not reflect any quota increases.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAWSDefaultServiceQuotas service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAWSDefaultServiceQuotas service method, as returned by ServiceQuotas.</returns>
        /// <exception cref="Amazon.ServiceQuotas.Model.AccessDeniedException">
        /// You do not have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.IllegalArgumentException">
        /// Invalid input was provided.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.InvalidPaginationTokenException">
        /// Invalid input was provided.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.NoSuchResourceException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.ServiceException">
        /// Something went wrong.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.TooManyRequestsException">
        /// Due to throttling, the request was denied. Slow down the rate of request calls, or
        /// request an increase for this quota.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/service-quotas-2019-06-24/ListAWSDefaultServiceQuotas">REST API Reference for ListAWSDefaultServiceQuotas Operation</seealso>
        Task<ListAWSDefaultServiceQuotasResponse> ListAWSDefaultServiceQuotasAsync(ListAWSDefaultServiceQuotasRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListRequestedServiceQuotaChangeHistory



        /// <summary>
        /// Retrieves the quota increase requests for the specified service.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRequestedServiceQuotaChangeHistory service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListRequestedServiceQuotaChangeHistory service method, as returned by ServiceQuotas.</returns>
        /// <exception cref="Amazon.ServiceQuotas.Model.AccessDeniedException">
        /// You do not have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.IllegalArgumentException">
        /// Invalid input was provided.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.InvalidPaginationTokenException">
        /// Invalid input was provided.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.NoSuchResourceException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.ServiceException">
        /// Something went wrong.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.TooManyRequestsException">
        /// Due to throttling, the request was denied. Slow down the rate of request calls, or
        /// request an increase for this quota.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/service-quotas-2019-06-24/ListRequestedServiceQuotaChangeHistory">REST API Reference for ListRequestedServiceQuotaChangeHistory Operation</seealso>
        Task<ListRequestedServiceQuotaChangeHistoryResponse> ListRequestedServiceQuotaChangeHistoryAsync(ListRequestedServiceQuotaChangeHistoryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListRequestedServiceQuotaChangeHistoryByQuota



        /// <summary>
        /// Retrieves the quota increase requests for the specified quota.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRequestedServiceQuotaChangeHistoryByQuota service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListRequestedServiceQuotaChangeHistoryByQuota service method, as returned by ServiceQuotas.</returns>
        /// <exception cref="Amazon.ServiceQuotas.Model.AccessDeniedException">
        /// You do not have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.IllegalArgumentException">
        /// Invalid input was provided.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.InvalidPaginationTokenException">
        /// Invalid input was provided.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.NoSuchResourceException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.ServiceException">
        /// Something went wrong.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.TooManyRequestsException">
        /// Due to throttling, the request was denied. Slow down the rate of request calls, or
        /// request an increase for this quota.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/service-quotas-2019-06-24/ListRequestedServiceQuotaChangeHistoryByQuota">REST API Reference for ListRequestedServiceQuotaChangeHistoryByQuota Operation</seealso>
        Task<ListRequestedServiceQuotaChangeHistoryByQuotaResponse> ListRequestedServiceQuotaChangeHistoryByQuotaAsync(ListRequestedServiceQuotaChangeHistoryByQuotaRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListServiceQuotaIncreaseRequestsInTemplate



        /// <summary>
        /// Lists the quota increase requests in the specified quota request template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListServiceQuotaIncreaseRequestsInTemplate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListServiceQuotaIncreaseRequestsInTemplate service method, as returned by ServiceQuotas.</returns>
        /// <exception cref="Amazon.ServiceQuotas.Model.AccessDeniedException">
        /// You do not have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.AWSServiceAccessNotEnabledException">
        /// The action you attempted is not allowed unless Service Access with Service Quotas
        /// is enabled in your organization.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.DependencyAccessDeniedException">
        /// You can't perform this action because a dependency does not have access.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.IllegalArgumentException">
        /// Invalid input was provided.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.NoAvailableOrganizationException">
        /// The account making this call is not a member of an organization.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.ServiceException">
        /// Something went wrong.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.TemplatesNotAvailableInRegionException">
        /// The Service Quotas template is not available in this AWS Region.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.TooManyRequestsException">
        /// Due to throttling, the request was denied. Slow down the rate of request calls, or
        /// request an increase for this quota.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/service-quotas-2019-06-24/ListServiceQuotaIncreaseRequestsInTemplate">REST API Reference for ListServiceQuotaIncreaseRequestsInTemplate Operation</seealso>
        Task<ListServiceQuotaIncreaseRequestsInTemplateResponse> ListServiceQuotaIncreaseRequestsInTemplateAsync(ListServiceQuotaIncreaseRequestsInTemplateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListServiceQuotas



        /// <summary>
        /// Lists the applied quota values for the specified AWS service. For some quotas, only
        /// the default values are available. If the applied quota value is not available for
        /// a quota, the quota is not retrieved.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListServiceQuotas service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListServiceQuotas service method, as returned by ServiceQuotas.</returns>
        /// <exception cref="Amazon.ServiceQuotas.Model.AccessDeniedException">
        /// You do not have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.IllegalArgumentException">
        /// Invalid input was provided.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.InvalidPaginationTokenException">
        /// Invalid input was provided.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.NoSuchResourceException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.ServiceException">
        /// Something went wrong.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.TooManyRequestsException">
        /// Due to throttling, the request was denied. Slow down the rate of request calls, or
        /// request an increase for this quota.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/service-quotas-2019-06-24/ListServiceQuotas">REST API Reference for ListServiceQuotas Operation</seealso>
        Task<ListServiceQuotasResponse> ListServiceQuotasAsync(ListServiceQuotasRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListServices



        /// <summary>
        /// Lists the names and codes for the services integrated with Service Quotas.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListServices service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListServices service method, as returned by ServiceQuotas.</returns>
        /// <exception cref="Amazon.ServiceQuotas.Model.AccessDeniedException">
        /// You do not have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.IllegalArgumentException">
        /// Invalid input was provided.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.InvalidPaginationTokenException">
        /// Invalid input was provided.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.ServiceException">
        /// Something went wrong.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.TooManyRequestsException">
        /// Due to throttling, the request was denied. Slow down the rate of request calls, or
        /// request an increase for this quota.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/service-quotas-2019-06-24/ListServices">REST API Reference for ListServices Operation</seealso>
        Task<ListServicesResponse> ListServicesAsync(ListServicesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListTagsForResource



        /// <summary>
        /// Returns a list of the tags assigned to the specified applied quota.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by ServiceQuotas.</returns>
        /// <exception cref="Amazon.ServiceQuotas.Model.AccessDeniedException">
        /// You do not have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.IllegalArgumentException">
        /// Invalid input was provided.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.NoSuchResourceException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.ServiceException">
        /// Something went wrong.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.TooManyRequestsException">
        /// Due to throttling, the request was denied. Slow down the rate of request calls, or
        /// request an increase for this quota.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/service-quotas-2019-06-24/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  PutServiceQuotaIncreaseRequestIntoTemplate



        /// <summary>
        /// Adds a quota increase request to your quota request template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutServiceQuotaIncreaseRequestIntoTemplate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutServiceQuotaIncreaseRequestIntoTemplate service method, as returned by ServiceQuotas.</returns>
        /// <exception cref="Amazon.ServiceQuotas.Model.AccessDeniedException">
        /// You do not have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.AWSServiceAccessNotEnabledException">
        /// The action you attempted is not allowed unless Service Access with Service Quotas
        /// is enabled in your organization.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.DependencyAccessDeniedException">
        /// You can't perform this action because a dependency does not have access.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.IllegalArgumentException">
        /// Invalid input was provided.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.NoAvailableOrganizationException">
        /// The account making this call is not a member of an organization.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.NoSuchResourceException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.QuotaExceededException">
        /// You have exceeded your service quota. To perform the requested action, remove some
        /// of the relevant resources, or use Service Quotas to request a service quota increase.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.ServiceException">
        /// Something went wrong.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.TemplatesNotAvailableInRegionException">
        /// The Service Quotas template is not available in this AWS Region.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.TooManyRequestsException">
        /// Due to throttling, the request was denied. Slow down the rate of request calls, or
        /// request an increase for this quota.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/service-quotas-2019-06-24/PutServiceQuotaIncreaseRequestIntoTemplate">REST API Reference for PutServiceQuotaIncreaseRequestIntoTemplate Operation</seealso>
        Task<PutServiceQuotaIncreaseRequestIntoTemplateResponse> PutServiceQuotaIncreaseRequestIntoTemplateAsync(PutServiceQuotaIncreaseRequestIntoTemplateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  RequestServiceQuotaIncrease



        /// <summary>
        /// Submits a quota increase request for the specified quota.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RequestServiceQuotaIncrease service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RequestServiceQuotaIncrease service method, as returned by ServiceQuotas.</returns>
        /// <exception cref="Amazon.ServiceQuotas.Model.AccessDeniedException">
        /// You do not have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.DependencyAccessDeniedException">
        /// You can't perform this action because a dependency does not have access.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.IllegalArgumentException">
        /// Invalid input was provided.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.InvalidResourceStateException">
        /// The resource is in an invalid state.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.NoSuchResourceException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.QuotaExceededException">
        /// You have exceeded your service quota. To perform the requested action, remove some
        /// of the relevant resources, or use Service Quotas to request a service quota increase.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.ResourceAlreadyExistsException">
        /// The specified resource already exists.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.ServiceException">
        /// Something went wrong.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.TooManyRequestsException">
        /// Due to throttling, the request was denied. Slow down the rate of request calls, or
        /// request an increase for this quota.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/service-quotas-2019-06-24/RequestServiceQuotaIncrease">REST API Reference for RequestServiceQuotaIncrease Operation</seealso>
        Task<RequestServiceQuotaIncreaseResponse> RequestServiceQuotaIncreaseAsync(RequestServiceQuotaIncreaseRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  TagResource



        /// <summary>
        /// Adds tags to the specified applied quota. You can include one or more tags to add
        /// to the quota.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by ServiceQuotas.</returns>
        /// <exception cref="Amazon.ServiceQuotas.Model.AccessDeniedException">
        /// You do not have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.IllegalArgumentException">
        /// Invalid input was provided.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.NoSuchResourceException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.ServiceException">
        /// Something went wrong.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.TagPolicyViolationException">
        /// The specified tag is a reserved word and cannot be used.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.TooManyRequestsException">
        /// Due to throttling, the request was denied. Slow down the rate of request calls, or
        /// request an increase for this quota.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.TooManyTagsException">
        /// You've exceeded the number of tags allowed for a resource. For more information, see
        /// <a href="https://docs.aws.amazon.com/servicequotas/latest/userguide/sq-tagging.html#sq-tagging-restrictions">Tag
        /// restrictions</a> in the <i>Service Quotas User Guide</i>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/service-quotas-2019-06-24/TagResource">REST API Reference for TagResource Operation</seealso>
        Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UntagResource



        /// <summary>
        /// Removes tags from the specified applied quota. You can specify one or more tags to
        /// remove.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by ServiceQuotas.</returns>
        /// <exception cref="Amazon.ServiceQuotas.Model.AccessDeniedException">
        /// You do not have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.IllegalArgumentException">
        /// Invalid input was provided.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.NoSuchResourceException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.ServiceException">
        /// Something went wrong.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.TooManyRequestsException">
        /// Due to throttling, the request was denied. Slow down the rate of request calls, or
        /// request an increase for this quota.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/service-quotas-2019-06-24/UntagResource">REST API Reference for UntagResource Operation</seealso>
        Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}