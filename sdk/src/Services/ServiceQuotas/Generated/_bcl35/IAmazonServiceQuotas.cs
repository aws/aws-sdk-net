/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

namespace Amazon.ServiceQuotas
{
    /// <summary>
    /// Interface for accessing ServiceQuotas
    ///
    /// Service Quotas is a web service that you can use to manage many of your AWS service
    /// quotas. Quotas, also referred to as limits, are the maximum values for a resource,
    /// item, or operation. This guide provide descriptions of the Service Quotas actions
    /// that you can call from an API. For the Service Quotas user guide, which explains how
    /// to use Service Quotas from the console, see <a href="https://docs.aws.amazon.com/servicequotas/latest/userguide/intro.html">What
    /// is Service Quotas</a>. 
    /// 
    ///  <note> 
    /// <para>
    /// AWS provides SDKs that consist of libraries and sample code for programming languages
    /// and platforms (Java, Ruby, .NET, iOS, Android, etc...,). The SDKs provide a convenient
    /// way to create programmatic access to Service Quotas and AWS. For information about
    /// the AWS SDKs, including how to download and install them, see the <a href="https://docs.aws.amazon.com/aws.amazon.com/tools">Tools
    /// for Amazon Web Services</a> page.
    /// </para>
    ///  </note>
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
        /// Associates the Service Quotas template with your organization so that when new accounts
        /// are created in your organization, the template submits increase requests for the specified
        /// service quotas. Use the Service Quotas template to request an increase for any adjustable
        /// quota value. After you define the Service Quotas template, use this operation to associate,
        /// or enable, the template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateServiceQuotaTemplate service method.</param>
        /// 
        /// <returns>The response from the AssociateServiceQuotaTemplate service method, as returned by ServiceQuotas.</returns>
        /// <exception cref="Amazon.ServiceQuotas.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.AWSServiceAccessNotEnabledException">
        /// The action you attempted is not allowed unless Service Access with Service Quotas
        /// is enabled in your organization. To enable, call <a>AssociateServiceQuotaTemplate</a>.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.DependencyAccessDeniedException">
        /// You can't perform this action because a dependency does not have access.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.NoAvailableOrganizationException">
        /// The account making this call is not a member of an organization.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.OrganizationNotInAllFeaturesModeException">
        /// The organization that your account belongs to, is not in All Features mode. To enable
        /// all features mode, see <a href="https://docs.aws.amazon.com/organizations/latest/APIReference/API_EnableAllFeatures.html">EnableAllFeatures</a>.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.ServiceException">
        /// Something went wrong.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.TemplatesNotAvailableInRegionException">
        /// The Service Quotas template is not available in the Region where you are making the
        /// request. Please make the request in us-east-1.
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
        
        #region  DeleteServiceQuotaIncreaseRequestFromTemplate


        /// <summary>
        /// Removes a service quota increase request from the Service Quotas template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteServiceQuotaIncreaseRequestFromTemplate service method.</param>
        /// 
        /// <returns>The response from the DeleteServiceQuotaIncreaseRequestFromTemplate service method, as returned by ServiceQuotas.</returns>
        /// <exception cref="Amazon.ServiceQuotas.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.AWSServiceAccessNotEnabledException">
        /// The action you attempted is not allowed unless Service Access with Service Quotas
        /// is enabled in your organization. To enable, call <a>AssociateServiceQuotaTemplate</a>.
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
        /// The Service Quotas template is not available in the Region where you are making the
        /// request. Please make the request in us-east-1.
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
        /// Disables the Service Quotas template. Once the template is disabled, it does not request
        /// quota increases for new accounts in your organization. Disabling the quota template
        /// does not apply the quota increase requests from the template. 
        /// 
        ///  
        /// <para>
        ///  <b>Related operations</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// To enable the quota template, call <a>AssociateServiceQuotaTemplate</a>. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To delete a specific service quota from the template, use <a>DeleteServiceQuotaIncreaseRequestFromTemplate</a>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateServiceQuotaTemplate service method.</param>
        /// 
        /// <returns>The response from the DisassociateServiceQuotaTemplate service method, as returned by ServiceQuotas.</returns>
        /// <exception cref="Amazon.ServiceQuotas.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.AWSServiceAccessNotEnabledException">
        /// The action you attempted is not allowed unless Service Access with Service Quotas
        /// is enabled in your organization. To enable, call <a>AssociateServiceQuotaTemplate</a>.
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
        /// 
        ///  
        /// <para>
        /// To use the template, call <a>AssociateServiceQuotaTemplate</a>. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.TemplatesNotAvailableInRegionException">
        /// The Service Quotas template is not available in the Region where you are making the
        /// request. Please make the request in us-east-1.
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
        /// Retrieves the <code>ServiceQuotaTemplateAssociationStatus</code> value from the service.
        /// Use this action to determine if the Service Quota template is associated, or enabled.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAssociationForServiceQuotaTemplate service method.</param>
        /// 
        /// <returns>The response from the GetAssociationForServiceQuotaTemplate service method, as returned by ServiceQuotas.</returns>
        /// <exception cref="Amazon.ServiceQuotas.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.AWSServiceAccessNotEnabledException">
        /// The action you attempted is not allowed unless Service Access with Service Quotas
        /// is enabled in your organization. To enable, call <a>AssociateServiceQuotaTemplate</a>.
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
        /// 
        ///  
        /// <para>
        /// To use the template, call <a>AssociateServiceQuotaTemplate</a>. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.TemplatesNotAvailableInRegionException">
        /// The Service Quotas template is not available in the Region where you are making the
        /// request. Please make the request in us-east-1.
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
        
        #region  GetAWSDefaultServiceQuota


        /// <summary>
        /// Retrieves the default service quotas values. The Value returned for each quota is
        /// the AWS default value, even if the quotas have been increased..
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAWSDefaultServiceQuota service method.</param>
        /// 
        /// <returns>The response from the GetAWSDefaultServiceQuota service method, as returned by ServiceQuotas.</returns>
        /// <exception cref="Amazon.ServiceQuotas.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
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
        /// Retrieves the details for a particular increase request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRequestedServiceQuotaChange service method.</param>
        /// 
        /// <returns>The response from the GetRequestedServiceQuotaChange service method, as returned by ServiceQuotas.</returns>
        /// <exception cref="Amazon.ServiceQuotas.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
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
        /// Returns the details for the specified service quota. This operation provides a different
        /// Value than the <code>GetAWSDefaultServiceQuota</code> operation. This operation returns
        /// the applied value for each quota. <code>GetAWSDefaultServiceQuota</code> returns the
        /// default AWS value for each quota.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetServiceQuota service method.</param>
        /// 
        /// <returns>The response from the GetServiceQuota service method, as returned by ServiceQuotas.</returns>
        /// <exception cref="Amazon.ServiceQuotas.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
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
        /// Returns the details of the service quota increase request in your template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetServiceQuotaIncreaseRequestFromTemplate service method.</param>
        /// 
        /// <returns>The response from the GetServiceQuotaIncreaseRequestFromTemplate service method, as returned by ServiceQuotas.</returns>
        /// <exception cref="Amazon.ServiceQuotas.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.AWSServiceAccessNotEnabledException">
        /// The action you attempted is not allowed unless Service Access with Service Quotas
        /// is enabled in your organization. To enable, call <a>AssociateServiceQuotaTemplate</a>.
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
        /// The Service Quotas template is not available in the Region where you are making the
        /// request. Please make the request in us-east-1.
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
        /// Lists all default service quotas for the specified AWS service or all AWS services.
        /// ListAWSDefaultServiceQuotas is similar to <a>ListServiceQuotas</a> except for the
        /// Value object. The Value object returned by <code>ListAWSDefaultServiceQuotas</code>
        /// is the default value assigned by AWS. This request returns a list of all service quotas
        /// for the specified service. The listing of each you'll see the default values are the
        /// values that AWS provides for the quotas. 
        /// 
        ///  <note> 
        /// <para>
        /// Always check the <code>NextToken</code> response parameter when calling any of the
        /// <code>List*</code> operations. These operations can return an unexpected list of results,
        /// even when there are more results available. When this happens, the <code>NextToken</code>
        /// response parameter contains a value to pass the next call to the same API to request
        /// the next part of the list.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAWSDefaultServiceQuotas service method.</param>
        /// 
        /// <returns>The response from the ListAWSDefaultServiceQuotas service method, as returned by ServiceQuotas.</returns>
        /// <exception cref="Amazon.ServiceQuotas.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
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
        /// Requests a list of the changes to quotas for a service.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRequestedServiceQuotaChangeHistory service method.</param>
        /// 
        /// <returns>The response from the ListRequestedServiceQuotaChangeHistory service method, as returned by ServiceQuotas.</returns>
        /// <exception cref="Amazon.ServiceQuotas.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
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
        /// Requests a list of the changes to specific service quotas. This command provides additional
        /// granularity over the <code>ListRequestedServiceQuotaChangeHistory</code> command.
        /// Once a quota change request has reached <code>CASE_CLOSED, APPROVED,</code> or <code>DENIED</code>,
        /// the history has been kept for 90 days.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRequestedServiceQuotaChangeHistoryByQuota service method.</param>
        /// 
        /// <returns>The response from the ListRequestedServiceQuotaChangeHistoryByQuota service method, as returned by ServiceQuotas.</returns>
        /// <exception cref="Amazon.ServiceQuotas.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
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
        /// Returns a list of the quota increase requests in the template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListServiceQuotaIncreaseRequestsInTemplate service method.</param>
        /// 
        /// <returns>The response from the ListServiceQuotaIncreaseRequestsInTemplate service method, as returned by ServiceQuotas.</returns>
        /// <exception cref="Amazon.ServiceQuotas.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.AWSServiceAccessNotEnabledException">
        /// The action you attempted is not allowed unless Service Access with Service Quotas
        /// is enabled in your organization. To enable, call <a>AssociateServiceQuotaTemplate</a>.
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
        /// The Service Quotas template is not available in the Region where you are making the
        /// request. Please make the request in us-east-1.
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
        /// Lists all service quotas for the specified AWS service. This request returns a list
        /// of the service quotas for the specified service. you'll see the default values are
        /// the values that AWS provides for the quotas. 
        /// 
        ///  <note> 
        /// <para>
        /// Always check the <code>NextToken</code> response parameter when calling any of the
        /// <code>List*</code> operations. These operations can return an unexpected list of results,
        /// even when there are more results available. When this happens, the <code>NextToken</code>
        /// response parameter contains a value to pass the next call to the same API to request
        /// the next part of the list.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListServiceQuotas service method.</param>
        /// 
        /// <returns>The response from the ListServiceQuotas service method, as returned by ServiceQuotas.</returns>
        /// <exception cref="Amazon.ServiceQuotas.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
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
        /// Lists the AWS services available in Service Quotas. Not all AWS services are available
        /// in Service Quotas. To list the see the list of the service quotas for a specific service,
        /// use <a>ListServiceQuotas</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListServices service method.</param>
        /// 
        /// <returns>The response from the ListServices service method, as returned by ServiceQuotas.</returns>
        /// <exception cref="Amazon.ServiceQuotas.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
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
        
        #region  PutServiceQuotaIncreaseRequestIntoTemplate


        /// <summary>
        /// Defines and adds a quota to the service quota template. To add a quota to the template,
        /// you must provide the <code>ServiceCode</code>, <code>QuotaCode</code>, <code>AwsRegion</code>,
        /// and <code>DesiredValue</code>. Once you add a quota to the template, use <a>ListServiceQuotaIncreaseRequestsInTemplate</a>
        /// to see the list of quotas in the template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutServiceQuotaIncreaseRequestIntoTemplate service method.</param>
        /// 
        /// <returns>The response from the PutServiceQuotaIncreaseRequestIntoTemplate service method, as returned by ServiceQuotas.</returns>
        /// <exception cref="Amazon.ServiceQuotas.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.AWSServiceAccessNotEnabledException">
        /// The action you attempted is not allowed unless Service Access with Service Quotas
        /// is enabled in your organization. To enable, call <a>AssociateServiceQuotaTemplate</a>.
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
        /// The Service Quotas template is not available in the Region where you are making the
        /// request. Please make the request in us-east-1.
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
        /// Retrieves the details of a service quota increase request. The response to this command
        /// provides the details in the <a>RequestedServiceQuotaChange</a> object.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RequestServiceQuotaIncrease service method.</param>
        /// 
        /// <returns>The response from the RequestServiceQuotaIncrease service method, as returned by ServiceQuotas.</returns>
        /// <exception cref="Amazon.ServiceQuotas.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.DependencyAccessDeniedException">
        /// You can't perform this action because a dependency does not have access.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.IllegalArgumentException">
        /// Invalid input was provided.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.InvalidResourceStateException">
        /// Invalid input was provided for the .
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
        
    }
}