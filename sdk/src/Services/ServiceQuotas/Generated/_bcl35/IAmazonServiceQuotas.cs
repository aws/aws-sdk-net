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
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.ServiceQuotas.Model;

#pragma warning disable CS1570
namespace Amazon.ServiceQuotas
{
    /// <summary>
    /// <para>Interface for accessing ServiceQuotas</para>
    ///
    /// With Service Quotas, you can view and manage your quotas easily as your Amazon Web
    /// Services workloads grow. Quotas, also referred to as limits, are the maximum number
    /// of resources that you can create in your Amazon Web Services account. For more information,
    /// see the <a href="https://docs.aws.amazon.com/servicequotas/latest/userguide/">Service
    /// Quotas User Guide</a>.
    /// 
    ///  
    /// <para>
    /// You need Amazon Web Services CLI version 2.13.20 or higher to view and manage resource-level
    /// quotas such as <c>Instances per domain</c> for Amazon OpenSearch Service.
    /// </para>
    /// </summary>
    public partial interface IAmazonServiceQuotas : IAmazonService, IDisposable
    {


#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        IServiceQuotasPaginatorFactory Paginators { get; }
#endif


        
        #region  AssociateServiceQuotaTemplate


        /// <summary>
        /// Associates your quota request template with your organization. When a new Amazon Web
        /// Services account is created in your organization, the quota increase requests in the
        /// template are automatically applied to the account. You can add a quota increase request
        /// for any adjustable quota to your template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateServiceQuotaTemplate service method.</param>
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
        /// The Amazon Web Services account making this call is not a member of an organization.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.OrganizationNotInAllFeaturesModeException">
        /// The organization that your Amazon Web Services account belongs to is not in All Features
        /// mode.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.ServiceException">
        /// Something went wrong.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.TemplatesNotAvailableInRegionException">
        /// The Service Quotas template is not available in this Amazon Web Services Region.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.TooManyRequestsException">
        /// Due to throttling, the request was denied. Slow down the rate of request calls, or
        /// request an increase for this quota.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/service-quotas-2019-06-24/AssociateServiceQuotaTemplate">REST API Reference for AssociateServiceQuotaTemplate Operation</seealso>
        AssociateServiceQuotaTemplateResponse AssociateServiceQuotaTemplate(AssociateServiceQuotaTemplateRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the AssociateServiceQuotaTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateServiceQuotaTemplate operation on AmazonServiceQuotasClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAssociateServiceQuotaTemplate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/service-quotas-2019-06-24/AssociateServiceQuotaTemplate">REST API Reference for AssociateServiceQuotaTemplate Operation</seealso>
        IAsyncResult BeginAssociateServiceQuotaTemplate(AssociateServiceQuotaTemplateRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  AssociateServiceQuotaTemplate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssociateServiceQuotaTemplate.</param>
        /// 
        /// <returns>Returns a  AssociateServiceQuotaTemplateResult from ServiceQuotas.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/service-quotas-2019-06-24/AssociateServiceQuotaTemplate">REST API Reference for AssociateServiceQuotaTemplate Operation</seealso>
        AssociateServiceQuotaTemplateResponse EndAssociateServiceQuotaTemplate(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateSupportCase


        /// <summary>
        /// Creates a Support case for an existing quota increase request. This call only creates
        /// a Support case if the request has a <c>Pending</c> status.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSupportCase service method.</param>
        /// 
        /// <returns>The response from the CreateSupportCase service method, as returned by ServiceQuotas.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/service-quotas-2019-06-24/CreateSupportCase">REST API Reference for CreateSupportCase Operation</seealso>
        CreateSupportCaseResponse CreateSupportCase(CreateSupportCaseRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateSupportCase operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateSupportCase operation on AmazonServiceQuotasClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateSupportCase
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/service-quotas-2019-06-24/CreateSupportCase">REST API Reference for CreateSupportCase Operation</seealso>
        IAsyncResult BeginCreateSupportCase(CreateSupportCaseRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateSupportCase operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateSupportCase.</param>
        /// 
        /// <returns>Returns a  CreateSupportCaseResult from ServiceQuotas.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/service-quotas-2019-06-24/CreateSupportCase">REST API Reference for CreateSupportCase Operation</seealso>
        CreateSupportCaseResponse EndCreateSupportCase(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteServiceQuotaIncreaseRequestFromTemplate


        /// <summary>
        /// Deletes the quota increase request for the specified quota from your quota request
        /// template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteServiceQuotaIncreaseRequestFromTemplate service method.</param>
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
        /// The Amazon Web Services account making this call is not a member of an organization.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.NoSuchResourceException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.ServiceException">
        /// Something went wrong.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.TemplatesNotAvailableInRegionException">
        /// The Service Quotas template is not available in this Amazon Web Services Region.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.TooManyRequestsException">
        /// Due to throttling, the request was denied. Slow down the rate of request calls, or
        /// request an increase for this quota.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/service-quotas-2019-06-24/DeleteServiceQuotaIncreaseRequestFromTemplate">REST API Reference for DeleteServiceQuotaIncreaseRequestFromTemplate Operation</seealso>
        DeleteServiceQuotaIncreaseRequestFromTemplateResponse DeleteServiceQuotaIncreaseRequestFromTemplate(DeleteServiceQuotaIncreaseRequestFromTemplateRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteServiceQuotaIncreaseRequestFromTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteServiceQuotaIncreaseRequestFromTemplate operation on AmazonServiceQuotasClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteServiceQuotaIncreaseRequestFromTemplate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/service-quotas-2019-06-24/DeleteServiceQuotaIncreaseRequestFromTemplate">REST API Reference for DeleteServiceQuotaIncreaseRequestFromTemplate Operation</seealso>
        IAsyncResult BeginDeleteServiceQuotaIncreaseRequestFromTemplate(DeleteServiceQuotaIncreaseRequestFromTemplateRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteServiceQuotaIncreaseRequestFromTemplate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteServiceQuotaIncreaseRequestFromTemplate.</param>
        /// 
        /// <returns>Returns a  DeleteServiceQuotaIncreaseRequestFromTemplateResult from ServiceQuotas.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/service-quotas-2019-06-24/DeleteServiceQuotaIncreaseRequestFromTemplate">REST API Reference for DeleteServiceQuotaIncreaseRequestFromTemplate Operation</seealso>
        DeleteServiceQuotaIncreaseRequestFromTemplateResponse EndDeleteServiceQuotaIncreaseRequestFromTemplate(IAsyncResult asyncResult);

        #endregion
        
        #region  DisassociateServiceQuotaTemplate


        /// <summary>
        /// Disables your quota request template. After a template is disabled, the quota increase
        /// requests in the template are not applied to new Amazon Web Services accounts in your
        /// organization. Disabling a quota request template does not apply its quota increase
        /// requests.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateServiceQuotaTemplate service method.</param>
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
        /// The Amazon Web Services account making this call is not a member of an organization.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.ServiceException">
        /// Something went wrong.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.ServiceQuotaTemplateNotInUseException">
        /// The quota request template is not associated with your organization.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.TemplatesNotAvailableInRegionException">
        /// The Service Quotas template is not available in this Amazon Web Services Region.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.TooManyRequestsException">
        /// Due to throttling, the request was denied. Slow down the rate of request calls, or
        /// request an increase for this quota.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/service-quotas-2019-06-24/DisassociateServiceQuotaTemplate">REST API Reference for DisassociateServiceQuotaTemplate Operation</seealso>
        DisassociateServiceQuotaTemplateResponse DisassociateServiceQuotaTemplate(DisassociateServiceQuotaTemplateRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateServiceQuotaTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateServiceQuotaTemplate operation on AmazonServiceQuotasClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisassociateServiceQuotaTemplate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/service-quotas-2019-06-24/DisassociateServiceQuotaTemplate">REST API Reference for DisassociateServiceQuotaTemplate Operation</seealso>
        IAsyncResult BeginDisassociateServiceQuotaTemplate(DisassociateServiceQuotaTemplateRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DisassociateServiceQuotaTemplate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisassociateServiceQuotaTemplate.</param>
        /// 
        /// <returns>Returns a  DisassociateServiceQuotaTemplateResult from ServiceQuotas.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/service-quotas-2019-06-24/DisassociateServiceQuotaTemplate">REST API Reference for DisassociateServiceQuotaTemplate Operation</seealso>
        DisassociateServiceQuotaTemplateResponse EndDisassociateServiceQuotaTemplate(IAsyncResult asyncResult);

        #endregion
        
        #region  GetAssociationForServiceQuotaTemplate


        /// <summary>
        /// Retrieves the status of the association for the quota request template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAssociationForServiceQuotaTemplate service method.</param>
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
        /// The Amazon Web Services account making this call is not a member of an organization.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.ServiceException">
        /// Something went wrong.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.ServiceQuotaTemplateNotInUseException">
        /// The quota request template is not associated with your organization.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.TemplatesNotAvailableInRegionException">
        /// The Service Quotas template is not available in this Amazon Web Services Region.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.TooManyRequestsException">
        /// Due to throttling, the request was denied. Slow down the rate of request calls, or
        /// request an increase for this quota.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/service-quotas-2019-06-24/GetAssociationForServiceQuotaTemplate">REST API Reference for GetAssociationForServiceQuotaTemplate Operation</seealso>
        GetAssociationForServiceQuotaTemplateResponse GetAssociationForServiceQuotaTemplate(GetAssociationForServiceQuotaTemplateRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetAssociationForServiceQuotaTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetAssociationForServiceQuotaTemplate operation on AmazonServiceQuotasClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetAssociationForServiceQuotaTemplate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/service-quotas-2019-06-24/GetAssociationForServiceQuotaTemplate">REST API Reference for GetAssociationForServiceQuotaTemplate Operation</seealso>
        IAsyncResult BeginGetAssociationForServiceQuotaTemplate(GetAssociationForServiceQuotaTemplateRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetAssociationForServiceQuotaTemplate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetAssociationForServiceQuotaTemplate.</param>
        /// 
        /// <returns>Returns a  GetAssociationForServiceQuotaTemplateResult from ServiceQuotas.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/service-quotas-2019-06-24/GetAssociationForServiceQuotaTemplate">REST API Reference for GetAssociationForServiceQuotaTemplate Operation</seealso>
        GetAssociationForServiceQuotaTemplateResponse EndGetAssociationForServiceQuotaTemplate(IAsyncResult asyncResult);

        #endregion
        
        #region  GetAutoManagementConfiguration


        /// <summary>
        /// Retrieves information about your <a href="https://docs.aws.amazon.com/servicequotas/latest/userguide/automatic-management.html">Service
        /// Quotas Automatic Management</a> configuration. Automatic Management monitors your
        /// Service Quotas utilization and notifies you before you run out of your allocated quotas.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAutoManagementConfiguration service method.</param>
        /// 
        /// <returns>The response from the GetAutoManagementConfiguration service method, as returned by ServiceQuotas.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/service-quotas-2019-06-24/GetAutoManagementConfiguration">REST API Reference for GetAutoManagementConfiguration Operation</seealso>
        GetAutoManagementConfigurationResponse GetAutoManagementConfiguration(GetAutoManagementConfigurationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetAutoManagementConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetAutoManagementConfiguration operation on AmazonServiceQuotasClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetAutoManagementConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/service-quotas-2019-06-24/GetAutoManagementConfiguration">REST API Reference for GetAutoManagementConfiguration Operation</seealso>
        IAsyncResult BeginGetAutoManagementConfiguration(GetAutoManagementConfigurationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetAutoManagementConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetAutoManagementConfiguration.</param>
        /// 
        /// <returns>Returns a  GetAutoManagementConfigurationResult from ServiceQuotas.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/service-quotas-2019-06-24/GetAutoManagementConfiguration">REST API Reference for GetAutoManagementConfiguration Operation</seealso>
        GetAutoManagementConfigurationResponse EndGetAutoManagementConfiguration(IAsyncResult asyncResult);

        #endregion
        
        #region  GetAWSDefaultServiceQuota


        /// <summary>
        /// Retrieves the default value for the specified quota. The default value does not reflect
        /// any quota increases.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAWSDefaultServiceQuota service method.</param>
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
        GetAWSDefaultServiceQuotaResponse GetAWSDefaultServiceQuota(GetAWSDefaultServiceQuotaRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetAWSDefaultServiceQuota operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetAWSDefaultServiceQuota operation on AmazonServiceQuotasClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetAWSDefaultServiceQuota
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/service-quotas-2019-06-24/GetAWSDefaultServiceQuota">REST API Reference for GetAWSDefaultServiceQuota Operation</seealso>
        IAsyncResult BeginGetAWSDefaultServiceQuota(GetAWSDefaultServiceQuotaRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetAWSDefaultServiceQuota operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetAWSDefaultServiceQuota.</param>
        /// 
        /// <returns>Returns a  GetAWSDefaultServiceQuotaResult from ServiceQuotas.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/service-quotas-2019-06-24/GetAWSDefaultServiceQuota">REST API Reference for GetAWSDefaultServiceQuota Operation</seealso>
        GetAWSDefaultServiceQuotaResponse EndGetAWSDefaultServiceQuota(IAsyncResult asyncResult);

        #endregion
        
        #region  GetRequestedServiceQuotaChange


        /// <summary>
        /// Retrieves information about the specified quota increase request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRequestedServiceQuotaChange service method.</param>
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
        GetRequestedServiceQuotaChangeResponse GetRequestedServiceQuotaChange(GetRequestedServiceQuotaChangeRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetRequestedServiceQuotaChange operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetRequestedServiceQuotaChange operation on AmazonServiceQuotasClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetRequestedServiceQuotaChange
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/service-quotas-2019-06-24/GetRequestedServiceQuotaChange">REST API Reference for GetRequestedServiceQuotaChange Operation</seealso>
        IAsyncResult BeginGetRequestedServiceQuotaChange(GetRequestedServiceQuotaChangeRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetRequestedServiceQuotaChange operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetRequestedServiceQuotaChange.</param>
        /// 
        /// <returns>Returns a  GetRequestedServiceQuotaChangeResult from ServiceQuotas.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/service-quotas-2019-06-24/GetRequestedServiceQuotaChange">REST API Reference for GetRequestedServiceQuotaChange Operation</seealso>
        GetRequestedServiceQuotaChangeResponse EndGetRequestedServiceQuotaChange(IAsyncResult asyncResult);

        #endregion
        
        #region  GetServiceQuota


        /// <summary>
        /// Retrieves the applied quota value for the specified account-level or resource-level
        /// quota. For some quotas, only the default values are available. If the applied quota
        /// value is not available for a quota, the quota is not retrieved.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetServiceQuota service method.</param>
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
        GetServiceQuotaResponse GetServiceQuota(GetServiceQuotaRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetServiceQuota operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetServiceQuota operation on AmazonServiceQuotasClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetServiceQuota
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/service-quotas-2019-06-24/GetServiceQuota">REST API Reference for GetServiceQuota Operation</seealso>
        IAsyncResult BeginGetServiceQuota(GetServiceQuotaRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetServiceQuota operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetServiceQuota.</param>
        /// 
        /// <returns>Returns a  GetServiceQuotaResult from ServiceQuotas.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/service-quotas-2019-06-24/GetServiceQuota">REST API Reference for GetServiceQuota Operation</seealso>
        GetServiceQuotaResponse EndGetServiceQuota(IAsyncResult asyncResult);

        #endregion
        
        #region  GetServiceQuotaIncreaseRequestFromTemplate


        /// <summary>
        /// Retrieves information about the specified quota increase request in your quota request
        /// template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetServiceQuotaIncreaseRequestFromTemplate service method.</param>
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
        /// The Amazon Web Services account making this call is not a member of an organization.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.NoSuchResourceException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.ServiceException">
        /// Something went wrong.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.TemplatesNotAvailableInRegionException">
        /// The Service Quotas template is not available in this Amazon Web Services Region.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.TooManyRequestsException">
        /// Due to throttling, the request was denied. Slow down the rate of request calls, or
        /// request an increase for this quota.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/service-quotas-2019-06-24/GetServiceQuotaIncreaseRequestFromTemplate">REST API Reference for GetServiceQuotaIncreaseRequestFromTemplate Operation</seealso>
        GetServiceQuotaIncreaseRequestFromTemplateResponse GetServiceQuotaIncreaseRequestFromTemplate(GetServiceQuotaIncreaseRequestFromTemplateRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetServiceQuotaIncreaseRequestFromTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetServiceQuotaIncreaseRequestFromTemplate operation on AmazonServiceQuotasClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetServiceQuotaIncreaseRequestFromTemplate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/service-quotas-2019-06-24/GetServiceQuotaIncreaseRequestFromTemplate">REST API Reference for GetServiceQuotaIncreaseRequestFromTemplate Operation</seealso>
        IAsyncResult BeginGetServiceQuotaIncreaseRequestFromTemplate(GetServiceQuotaIncreaseRequestFromTemplateRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetServiceQuotaIncreaseRequestFromTemplate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetServiceQuotaIncreaseRequestFromTemplate.</param>
        /// 
        /// <returns>Returns a  GetServiceQuotaIncreaseRequestFromTemplateResult from ServiceQuotas.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/service-quotas-2019-06-24/GetServiceQuotaIncreaseRequestFromTemplate">REST API Reference for GetServiceQuotaIncreaseRequestFromTemplate Operation</seealso>
        GetServiceQuotaIncreaseRequestFromTemplateResponse EndGetServiceQuotaIncreaseRequestFromTemplate(IAsyncResult asyncResult);

        #endregion
        
        #region  ListAWSDefaultServiceQuotas


        /// <summary>
        /// Lists the default values for the quotas for the specified Amazon Web Services service.
        /// A default value does not reflect any quota increases.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAWSDefaultServiceQuotas service method.</param>
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
        ListAWSDefaultServiceQuotasResponse ListAWSDefaultServiceQuotas(ListAWSDefaultServiceQuotasRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListAWSDefaultServiceQuotas operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAWSDefaultServiceQuotas operation on AmazonServiceQuotasClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAWSDefaultServiceQuotas
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/service-quotas-2019-06-24/ListAWSDefaultServiceQuotas">REST API Reference for ListAWSDefaultServiceQuotas Operation</seealso>
        IAsyncResult BeginListAWSDefaultServiceQuotas(ListAWSDefaultServiceQuotasRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListAWSDefaultServiceQuotas operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAWSDefaultServiceQuotas.</param>
        /// 
        /// <returns>Returns a  ListAWSDefaultServiceQuotasResult from ServiceQuotas.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/service-quotas-2019-06-24/ListAWSDefaultServiceQuotas">REST API Reference for ListAWSDefaultServiceQuotas Operation</seealso>
        ListAWSDefaultServiceQuotasResponse EndListAWSDefaultServiceQuotas(IAsyncResult asyncResult);

        #endregion
        
        #region  ListRequestedServiceQuotaChangeHistory


        /// <summary>
        /// Retrieves the quota increase requests for the specified Amazon Web Services service.
        /// Filter responses to return quota requests at either the account level, resource level,
        /// or all levels. Responses include any open or closed requests within 90 days.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRequestedServiceQuotaChangeHistory service method.</param>
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
        ListRequestedServiceQuotaChangeHistoryResponse ListRequestedServiceQuotaChangeHistory(ListRequestedServiceQuotaChangeHistoryRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListRequestedServiceQuotaChangeHistory operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListRequestedServiceQuotaChangeHistory operation on AmazonServiceQuotasClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListRequestedServiceQuotaChangeHistory
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/service-quotas-2019-06-24/ListRequestedServiceQuotaChangeHistory">REST API Reference for ListRequestedServiceQuotaChangeHistory Operation</seealso>
        IAsyncResult BeginListRequestedServiceQuotaChangeHistory(ListRequestedServiceQuotaChangeHistoryRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListRequestedServiceQuotaChangeHistory operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListRequestedServiceQuotaChangeHistory.</param>
        /// 
        /// <returns>Returns a  ListRequestedServiceQuotaChangeHistoryResult from ServiceQuotas.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/service-quotas-2019-06-24/ListRequestedServiceQuotaChangeHistory">REST API Reference for ListRequestedServiceQuotaChangeHistory Operation</seealso>
        ListRequestedServiceQuotaChangeHistoryResponse EndListRequestedServiceQuotaChangeHistory(IAsyncResult asyncResult);

        #endregion
        
        #region  ListRequestedServiceQuotaChangeHistoryByQuota


        /// <summary>
        /// Retrieves the quota increase requests for the specified quota. Filter responses to
        /// return quota requests at either the account level, resource level, or all levels.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRequestedServiceQuotaChangeHistoryByQuota service method.</param>
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
        ListRequestedServiceQuotaChangeHistoryByQuotaResponse ListRequestedServiceQuotaChangeHistoryByQuota(ListRequestedServiceQuotaChangeHistoryByQuotaRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListRequestedServiceQuotaChangeHistoryByQuota operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListRequestedServiceQuotaChangeHistoryByQuota operation on AmazonServiceQuotasClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListRequestedServiceQuotaChangeHistoryByQuota
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/service-quotas-2019-06-24/ListRequestedServiceQuotaChangeHistoryByQuota">REST API Reference for ListRequestedServiceQuotaChangeHistoryByQuota Operation</seealso>
        IAsyncResult BeginListRequestedServiceQuotaChangeHistoryByQuota(ListRequestedServiceQuotaChangeHistoryByQuotaRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListRequestedServiceQuotaChangeHistoryByQuota operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListRequestedServiceQuotaChangeHistoryByQuota.</param>
        /// 
        /// <returns>Returns a  ListRequestedServiceQuotaChangeHistoryByQuotaResult from ServiceQuotas.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/service-quotas-2019-06-24/ListRequestedServiceQuotaChangeHistoryByQuota">REST API Reference for ListRequestedServiceQuotaChangeHistoryByQuota Operation</seealso>
        ListRequestedServiceQuotaChangeHistoryByQuotaResponse EndListRequestedServiceQuotaChangeHistoryByQuota(IAsyncResult asyncResult);

        #endregion
        
        #region  ListServiceQuotaIncreaseRequestsInTemplate


        /// <summary>
        /// Lists the quota increase requests in the specified quota request template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListServiceQuotaIncreaseRequestsInTemplate service method.</param>
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
        /// The Amazon Web Services account making this call is not a member of an organization.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.ServiceException">
        /// Something went wrong.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.TemplatesNotAvailableInRegionException">
        /// The Service Quotas template is not available in this Amazon Web Services Region.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.TooManyRequestsException">
        /// Due to throttling, the request was denied. Slow down the rate of request calls, or
        /// request an increase for this quota.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/service-quotas-2019-06-24/ListServiceQuotaIncreaseRequestsInTemplate">REST API Reference for ListServiceQuotaIncreaseRequestsInTemplate Operation</seealso>
        ListServiceQuotaIncreaseRequestsInTemplateResponse ListServiceQuotaIncreaseRequestsInTemplate(ListServiceQuotaIncreaseRequestsInTemplateRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListServiceQuotaIncreaseRequestsInTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListServiceQuotaIncreaseRequestsInTemplate operation on AmazonServiceQuotasClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListServiceQuotaIncreaseRequestsInTemplate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/service-quotas-2019-06-24/ListServiceQuotaIncreaseRequestsInTemplate">REST API Reference for ListServiceQuotaIncreaseRequestsInTemplate Operation</seealso>
        IAsyncResult BeginListServiceQuotaIncreaseRequestsInTemplate(ListServiceQuotaIncreaseRequestsInTemplateRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListServiceQuotaIncreaseRequestsInTemplate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListServiceQuotaIncreaseRequestsInTemplate.</param>
        /// 
        /// <returns>Returns a  ListServiceQuotaIncreaseRequestsInTemplateResult from ServiceQuotas.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/service-quotas-2019-06-24/ListServiceQuotaIncreaseRequestsInTemplate">REST API Reference for ListServiceQuotaIncreaseRequestsInTemplate Operation</seealso>
        ListServiceQuotaIncreaseRequestsInTemplateResponse EndListServiceQuotaIncreaseRequestsInTemplate(IAsyncResult asyncResult);

        #endregion
        
        #region  ListServiceQuotas


        /// <summary>
        /// Lists the applied quota values for the specified Amazon Web Services service. For
        /// some quotas, only the default values are available. If the applied quota value is
        /// not available for a quota, the quota is not retrieved. Filter responses to return
        /// applied quota values at either the account level, resource level, or all levels.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListServiceQuotas service method.</param>
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
        ListServiceQuotasResponse ListServiceQuotas(ListServiceQuotasRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListServiceQuotas operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListServiceQuotas operation on AmazonServiceQuotasClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListServiceQuotas
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/service-quotas-2019-06-24/ListServiceQuotas">REST API Reference for ListServiceQuotas Operation</seealso>
        IAsyncResult BeginListServiceQuotas(ListServiceQuotasRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListServiceQuotas operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListServiceQuotas.</param>
        /// 
        /// <returns>Returns a  ListServiceQuotasResult from ServiceQuotas.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/service-quotas-2019-06-24/ListServiceQuotas">REST API Reference for ListServiceQuotas Operation</seealso>
        ListServiceQuotasResponse EndListServiceQuotas(IAsyncResult asyncResult);

        #endregion
        
        #region  ListServices


        /// <summary>
        /// Lists the names and codes for the Amazon Web Services services integrated with Service
        /// Quotas.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListServices service method.</param>
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
        ListServicesResponse ListServices(ListServicesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListServices operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListServices operation on AmazonServiceQuotasClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListServices
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/service-quotas-2019-06-24/ListServices">REST API Reference for ListServices Operation</seealso>
        IAsyncResult BeginListServices(ListServicesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListServices operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListServices.</param>
        /// 
        /// <returns>Returns a  ListServicesResult from ServiceQuotas.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/service-quotas-2019-06-24/ListServices">REST API Reference for ListServices Operation</seealso>
        ListServicesResponse EndListServices(IAsyncResult asyncResult);

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// Returns a list of the tags assigned to the specified applied quota.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
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
        ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonServiceQuotasClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/service-quotas-2019-06-24/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        IAsyncResult BeginListTagsForResource(ListTagsForResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTagsForResource.</param>
        /// 
        /// <returns>Returns a  ListTagsForResourceResult from ServiceQuotas.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/service-quotas-2019-06-24/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult);

        #endregion
        
        #region  PutServiceQuotaIncreaseRequestIntoTemplate


        /// <summary>
        /// Adds a quota increase request to your quota request template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutServiceQuotaIncreaseRequestIntoTemplate service method.</param>
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
        /// The Amazon Web Services account making this call is not a member of an organization.
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
        /// The Service Quotas template is not available in this Amazon Web Services Region.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.TooManyRequestsException">
        /// Due to throttling, the request was denied. Slow down the rate of request calls, or
        /// request an increase for this quota.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/service-quotas-2019-06-24/PutServiceQuotaIncreaseRequestIntoTemplate">REST API Reference for PutServiceQuotaIncreaseRequestIntoTemplate Operation</seealso>
        PutServiceQuotaIncreaseRequestIntoTemplateResponse PutServiceQuotaIncreaseRequestIntoTemplate(PutServiceQuotaIncreaseRequestIntoTemplateRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the PutServiceQuotaIncreaseRequestIntoTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutServiceQuotaIncreaseRequestIntoTemplate operation on AmazonServiceQuotasClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutServiceQuotaIncreaseRequestIntoTemplate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/service-quotas-2019-06-24/PutServiceQuotaIncreaseRequestIntoTemplate">REST API Reference for PutServiceQuotaIncreaseRequestIntoTemplate Operation</seealso>
        IAsyncResult BeginPutServiceQuotaIncreaseRequestIntoTemplate(PutServiceQuotaIncreaseRequestIntoTemplateRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  PutServiceQuotaIncreaseRequestIntoTemplate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutServiceQuotaIncreaseRequestIntoTemplate.</param>
        /// 
        /// <returns>Returns a  PutServiceQuotaIncreaseRequestIntoTemplateResult from ServiceQuotas.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/service-quotas-2019-06-24/PutServiceQuotaIncreaseRequestIntoTemplate">REST API Reference for PutServiceQuotaIncreaseRequestIntoTemplate Operation</seealso>
        PutServiceQuotaIncreaseRequestIntoTemplateResponse EndPutServiceQuotaIncreaseRequestIntoTemplate(IAsyncResult asyncResult);

        #endregion
        
        #region  RequestServiceQuotaIncrease


        /// <summary>
        /// Submits a quota increase request for the specified quota at the account or resource
        /// level.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RequestServiceQuotaIncrease service method.</param>
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
        RequestServiceQuotaIncreaseResponse RequestServiceQuotaIncrease(RequestServiceQuotaIncreaseRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the RequestServiceQuotaIncrease operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RequestServiceQuotaIncrease operation on AmazonServiceQuotasClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRequestServiceQuotaIncrease
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/service-quotas-2019-06-24/RequestServiceQuotaIncrease">REST API Reference for RequestServiceQuotaIncrease Operation</seealso>
        IAsyncResult BeginRequestServiceQuotaIncrease(RequestServiceQuotaIncreaseRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  RequestServiceQuotaIncrease operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRequestServiceQuotaIncrease.</param>
        /// 
        /// <returns>Returns a  RequestServiceQuotaIncreaseResult from ServiceQuotas.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/service-quotas-2019-06-24/RequestServiceQuotaIncrease">REST API Reference for RequestServiceQuotaIncrease Operation</seealso>
        RequestServiceQuotaIncreaseResponse EndRequestServiceQuotaIncrease(IAsyncResult asyncResult);

        #endregion
        
        #region  StartAutoManagement


        /// <summary>
        /// Starts <a href="https://docs.aws.amazon.com/servicequotas/latest/userguide/automatic-management.html">Service
        /// Quotas Automatic Management</a> for an Amazon Web Services account, including notification
        /// preferences and excluded quotas configurations. Automatic Management monitors your
        /// Service Quotas utilization and notifies you before you run out of your allocated quotas.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartAutoManagement service method.</param>
        /// 
        /// <returns>The response from the StartAutoManagement service method, as returned by ServiceQuotas.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/service-quotas-2019-06-24/StartAutoManagement">REST API Reference for StartAutoManagement Operation</seealso>
        StartAutoManagementResponse StartAutoManagement(StartAutoManagementRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the StartAutoManagement operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartAutoManagement operation on AmazonServiceQuotasClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartAutoManagement
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/service-quotas-2019-06-24/StartAutoManagement">REST API Reference for StartAutoManagement Operation</seealso>
        IAsyncResult BeginStartAutoManagement(StartAutoManagementRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StartAutoManagement operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartAutoManagement.</param>
        /// 
        /// <returns>Returns a  StartAutoManagementResult from ServiceQuotas.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/service-quotas-2019-06-24/StartAutoManagement">REST API Reference for StartAutoManagement Operation</seealso>
        StartAutoManagementResponse EndStartAutoManagement(IAsyncResult asyncResult);

        #endregion
        
        #region  StopAutoManagement


        /// <summary>
        /// Stops <a href="https://docs.aws.amazon.com/servicequotas/latest/userguide/automatic-management.html">Service
        /// Quotas Automatic Management</a> for an Amazon Web Services account and removes all
        /// associated configurations. Automatic Management monitors your Service Quotas utilization
        /// and notifies you before you run out of your allocated quotas.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopAutoManagement service method.</param>
        /// 
        /// <returns>The response from the StopAutoManagement service method, as returned by ServiceQuotas.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/service-quotas-2019-06-24/StopAutoManagement">REST API Reference for StopAutoManagement Operation</seealso>
        StopAutoManagementResponse StopAutoManagement(StopAutoManagementRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the StopAutoManagement operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopAutoManagement operation on AmazonServiceQuotasClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStopAutoManagement
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/service-quotas-2019-06-24/StopAutoManagement">REST API Reference for StopAutoManagement Operation</seealso>
        IAsyncResult BeginStopAutoManagement(StopAutoManagementRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StopAutoManagement operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStopAutoManagement.</param>
        /// 
        /// <returns>Returns a  StopAutoManagementResult from ServiceQuotas.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/service-quotas-2019-06-24/StopAutoManagement">REST API Reference for StopAutoManagement Operation</seealso>
        StopAutoManagementResponse EndStopAutoManagement(IAsyncResult asyncResult);

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Adds tags to the specified applied quota. You can include one or more tags to add
        /// to the quota.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
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
        TagResourceResponse TagResource(TagResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the TagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonServiceQuotasClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/service-quotas-2019-06-24/TagResource">REST API Reference for TagResource Operation</seealso>
        IAsyncResult BeginTagResource(TagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  TagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTagResource.</param>
        /// 
        /// <returns>Returns a  TagResourceResult from ServiceQuotas.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/service-quotas-2019-06-24/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse EndTagResource(IAsyncResult asyncResult);

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// Removes tags from the specified applied quota. You can specify one or more tags to
        /// remove.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
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
        UntagResourceResponse UntagResource(UntagResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UntagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonServiceQuotasClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/service-quotas-2019-06-24/UntagResource">REST API Reference for UntagResource Operation</seealso>
        IAsyncResult BeginUntagResource(UntagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UntagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUntagResource.</param>
        /// 
        /// <returns>Returns a  UntagResourceResult from ServiceQuotas.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/service-quotas-2019-06-24/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse EndUntagResource(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateAutoManagement


        /// <summary>
        /// Updates your <a href="https://docs.aws.amazon.com/servicequotas/latest/userguide/automatic-management.html">Service
        /// Quotas Automatic Management</a> configuration, including notification preferences
        /// and excluded quotas. Automatic Management monitors your Service Quotas utilization
        /// and notifies you before you run out of your allocated quotas.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAutoManagement service method.</param>
        /// 
        /// <returns>The response from the UpdateAutoManagement service method, as returned by ServiceQuotas.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/service-quotas-2019-06-24/UpdateAutoManagement">REST API Reference for UpdateAutoManagement Operation</seealso>
        UpdateAutoManagementResponse UpdateAutoManagement(UpdateAutoManagementRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateAutoManagement operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateAutoManagement operation on AmazonServiceQuotasClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateAutoManagement
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/service-quotas-2019-06-24/UpdateAutoManagement">REST API Reference for UpdateAutoManagement Operation</seealso>
        IAsyncResult BeginUpdateAutoManagement(UpdateAutoManagementRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateAutoManagement operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateAutoManagement.</param>
        /// 
        /// <returns>Returns a  UpdateAutoManagementResult from ServiceQuotas.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/service-quotas-2019-06-24/UpdateAutoManagement">REST API Reference for UpdateAutoManagement Operation</seealso>
        UpdateAutoManagementResponse EndUpdateAutoManagement(IAsyncResult asyncResult);

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