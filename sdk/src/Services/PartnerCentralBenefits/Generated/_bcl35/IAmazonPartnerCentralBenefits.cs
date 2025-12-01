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
 * Do not modify this file. This file is generated from the partnercentral-benefits-2018-05-10.normal.json service model.
 */


using System;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.PartnerCentralBenefits.Model;

#pragma warning disable CS1570
namespace Amazon.PartnerCentralBenefits
{
    /// <summary>
    /// <para>Interface for accessing PartnerCentralBenefits</para>
    ///
    /// AWS Partner Central Benefits Service provides APIs for managing partner benefits,
    /// applications, and allocations within the AWS Partner Network ecosystem.
    /// </summary>
    public partial interface IAmazonPartnerCentralBenefits : IAmazonService, IDisposable
    {


#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        IPartnerCentralBenefitsPaginatorFactory Paginators { get; }
#endif


        
        #region  AmendBenefitApplication


        /// <summary>
        /// Modifies an existing benefit application by applying amendments to specific fields
        /// while maintaining revision control.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AmendBenefitApplication service method.</param>
        /// 
        /// <returns>The response from the AmendBenefitApplication service method, as returned by PartnerCentralBenefits.</returns>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.AccessDeniedException">
        /// Thrown when the caller does not have sufficient permissions to perform the requested
        /// operation.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.ConflictException">
        /// Thrown when the request conflicts with the current state of the resource, such as
        /// attempting to modify a resource that has been changed by another process.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.InternalServerException">
        /// Thrown when an unexpected error occurs on the server side during request processing.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.ResourceNotFoundException">
        /// Thrown when the requested resource cannot be found or does not exist.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.ThrottlingException">
        /// Thrown when the request rate exceeds the allowed limits and the request is being throttled.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.ValidationException">
        /// Thrown when the request contains invalid parameters or fails input validation requirements.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-benefits-2018-05-10/AmendBenefitApplication">REST API Reference for AmendBenefitApplication Operation</seealso>
        AmendBenefitApplicationResponse AmendBenefitApplication(AmendBenefitApplicationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the AmendBenefitApplication operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AmendBenefitApplication operation on AmazonPartnerCentralBenefitsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAmendBenefitApplication
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-benefits-2018-05-10/AmendBenefitApplication">REST API Reference for AmendBenefitApplication Operation</seealso>
        IAsyncResult BeginAmendBenefitApplication(AmendBenefitApplicationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  AmendBenefitApplication operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAmendBenefitApplication.</param>
        /// 
        /// <returns>Returns a  AmendBenefitApplicationResult from PartnerCentralBenefits.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-benefits-2018-05-10/AmendBenefitApplication">REST API Reference for AmendBenefitApplication Operation</seealso>
        AmendBenefitApplicationResponse EndAmendBenefitApplication(IAsyncResult asyncResult);

        #endregion
        
        #region  AssociateBenefitApplicationResource


        /// <summary>
        /// Links an AWS resource to an existing benefit application for tracking and management
        /// purposes.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateBenefitApplicationResource service method.</param>
        /// 
        /// <returns>The response from the AssociateBenefitApplicationResource service method, as returned by PartnerCentralBenefits.</returns>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.AccessDeniedException">
        /// Thrown when the caller does not have sufficient permissions to perform the requested
        /// operation.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.ConflictException">
        /// Thrown when the request conflicts with the current state of the resource, such as
        /// attempting to modify a resource that has been changed by another process.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.InternalServerException">
        /// Thrown when an unexpected error occurs on the server side during request processing.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.ResourceNotFoundException">
        /// Thrown when the requested resource cannot be found or does not exist.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.ThrottlingException">
        /// Thrown when the request rate exceeds the allowed limits and the request is being throttled.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.ValidationException">
        /// Thrown when the request contains invalid parameters or fails input validation requirements.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-benefits-2018-05-10/AssociateBenefitApplicationResource">REST API Reference for AssociateBenefitApplicationResource Operation</seealso>
        AssociateBenefitApplicationResourceResponse AssociateBenefitApplicationResource(AssociateBenefitApplicationResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the AssociateBenefitApplicationResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateBenefitApplicationResource operation on AmazonPartnerCentralBenefitsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAssociateBenefitApplicationResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-benefits-2018-05-10/AssociateBenefitApplicationResource">REST API Reference for AssociateBenefitApplicationResource Operation</seealso>
        IAsyncResult BeginAssociateBenefitApplicationResource(AssociateBenefitApplicationResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  AssociateBenefitApplicationResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssociateBenefitApplicationResource.</param>
        /// 
        /// <returns>Returns a  AssociateBenefitApplicationResourceResult from PartnerCentralBenefits.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-benefits-2018-05-10/AssociateBenefitApplicationResource">REST API Reference for AssociateBenefitApplicationResource Operation</seealso>
        AssociateBenefitApplicationResourceResponse EndAssociateBenefitApplicationResource(IAsyncResult asyncResult);

        #endregion
        
        #region  CancelBenefitApplication


        /// <summary>
        /// Cancels a benefit application that is currently in progress, preventing further processing.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelBenefitApplication service method.</param>
        /// 
        /// <returns>The response from the CancelBenefitApplication service method, as returned by PartnerCentralBenefits.</returns>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.AccessDeniedException">
        /// Thrown when the caller does not have sufficient permissions to perform the requested
        /// operation.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.ConflictException">
        /// Thrown when the request conflicts with the current state of the resource, such as
        /// attempting to modify a resource that has been changed by another process.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.InternalServerException">
        /// Thrown when an unexpected error occurs on the server side during request processing.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.ResourceNotFoundException">
        /// Thrown when the requested resource cannot be found or does not exist.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.ThrottlingException">
        /// Thrown when the request rate exceeds the allowed limits and the request is being throttled.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.ValidationException">
        /// Thrown when the request contains invalid parameters or fails input validation requirements.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-benefits-2018-05-10/CancelBenefitApplication">REST API Reference for CancelBenefitApplication Operation</seealso>
        CancelBenefitApplicationResponse CancelBenefitApplication(CancelBenefitApplicationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CancelBenefitApplication operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CancelBenefitApplication operation on AmazonPartnerCentralBenefitsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCancelBenefitApplication
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-benefits-2018-05-10/CancelBenefitApplication">REST API Reference for CancelBenefitApplication Operation</seealso>
        IAsyncResult BeginCancelBenefitApplication(CancelBenefitApplicationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CancelBenefitApplication operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCancelBenefitApplication.</param>
        /// 
        /// <returns>Returns a  CancelBenefitApplicationResult from PartnerCentralBenefits.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-benefits-2018-05-10/CancelBenefitApplication">REST API Reference for CancelBenefitApplication Operation</seealso>
        CancelBenefitApplicationResponse EndCancelBenefitApplication(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateBenefitApplication


        /// <summary>
        /// Creates a new benefit application for a partner to request access to AWS benefits
        /// and programs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateBenefitApplication service method.</param>
        /// 
        /// <returns>The response from the CreateBenefitApplication service method, as returned by PartnerCentralBenefits.</returns>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.AccessDeniedException">
        /// Thrown when the caller does not have sufficient permissions to perform the requested
        /// operation.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.ConflictException">
        /// Thrown when the request conflicts with the current state of the resource, such as
        /// attempting to modify a resource that has been changed by another process.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.InternalServerException">
        /// Thrown when an unexpected error occurs on the server side during request processing.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.ResourceNotFoundException">
        /// Thrown when the requested resource cannot be found or does not exist.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.ThrottlingException">
        /// Thrown when the request rate exceeds the allowed limits and the request is being throttled.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.ValidationException">
        /// Thrown when the request contains invalid parameters or fails input validation requirements.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-benefits-2018-05-10/CreateBenefitApplication">REST API Reference for CreateBenefitApplication Operation</seealso>
        CreateBenefitApplicationResponse CreateBenefitApplication(CreateBenefitApplicationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateBenefitApplication operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateBenefitApplication operation on AmazonPartnerCentralBenefitsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateBenefitApplication
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-benefits-2018-05-10/CreateBenefitApplication">REST API Reference for CreateBenefitApplication Operation</seealso>
        IAsyncResult BeginCreateBenefitApplication(CreateBenefitApplicationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateBenefitApplication operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateBenefitApplication.</param>
        /// 
        /// <returns>Returns a  CreateBenefitApplicationResult from PartnerCentralBenefits.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-benefits-2018-05-10/CreateBenefitApplication">REST API Reference for CreateBenefitApplication Operation</seealso>
        CreateBenefitApplicationResponse EndCreateBenefitApplication(IAsyncResult asyncResult);

        #endregion
        
        #region  DisassociateBenefitApplicationResource


        /// <summary>
        /// Removes the association between an AWS resource and a benefit application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateBenefitApplicationResource service method.</param>
        /// 
        /// <returns>The response from the DisassociateBenefitApplicationResource service method, as returned by PartnerCentralBenefits.</returns>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.AccessDeniedException">
        /// Thrown when the caller does not have sufficient permissions to perform the requested
        /// operation.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.ConflictException">
        /// Thrown when the request conflicts with the current state of the resource, such as
        /// attempting to modify a resource that has been changed by another process.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.InternalServerException">
        /// Thrown when an unexpected error occurs on the server side during request processing.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.ResourceNotFoundException">
        /// Thrown when the requested resource cannot be found or does not exist.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.ThrottlingException">
        /// Thrown when the request rate exceeds the allowed limits and the request is being throttled.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.ValidationException">
        /// Thrown when the request contains invalid parameters or fails input validation requirements.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-benefits-2018-05-10/DisassociateBenefitApplicationResource">REST API Reference for DisassociateBenefitApplicationResource Operation</seealso>
        DisassociateBenefitApplicationResourceResponse DisassociateBenefitApplicationResource(DisassociateBenefitApplicationResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateBenefitApplicationResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateBenefitApplicationResource operation on AmazonPartnerCentralBenefitsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisassociateBenefitApplicationResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-benefits-2018-05-10/DisassociateBenefitApplicationResource">REST API Reference for DisassociateBenefitApplicationResource Operation</seealso>
        IAsyncResult BeginDisassociateBenefitApplicationResource(DisassociateBenefitApplicationResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DisassociateBenefitApplicationResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisassociateBenefitApplicationResource.</param>
        /// 
        /// <returns>Returns a  DisassociateBenefitApplicationResourceResult from PartnerCentralBenefits.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-benefits-2018-05-10/DisassociateBenefitApplicationResource">REST API Reference for DisassociateBenefitApplicationResource Operation</seealso>
        DisassociateBenefitApplicationResourceResponse EndDisassociateBenefitApplicationResource(IAsyncResult asyncResult);

        #endregion
        
        #region  GetBenefit


        /// <summary>
        /// Retrieves detailed information about a specific benefit available in the partner catalog.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetBenefit service method.</param>
        /// 
        /// <returns>The response from the GetBenefit service method, as returned by PartnerCentralBenefits.</returns>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.AccessDeniedException">
        /// Thrown when the caller does not have sufficient permissions to perform the requested
        /// operation.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.InternalServerException">
        /// Thrown when an unexpected error occurs on the server side during request processing.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.ResourceNotFoundException">
        /// Thrown when the requested resource cannot be found or does not exist.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.ThrottlingException">
        /// Thrown when the request rate exceeds the allowed limits and the request is being throttled.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.ValidationException">
        /// Thrown when the request contains invalid parameters or fails input validation requirements.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-benefits-2018-05-10/GetBenefit">REST API Reference for GetBenefit Operation</seealso>
        GetBenefitResponse GetBenefit(GetBenefitRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetBenefit operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetBenefit operation on AmazonPartnerCentralBenefitsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetBenefit
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-benefits-2018-05-10/GetBenefit">REST API Reference for GetBenefit Operation</seealso>
        IAsyncResult BeginGetBenefit(GetBenefitRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetBenefit operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetBenefit.</param>
        /// 
        /// <returns>Returns a  GetBenefitResult from PartnerCentralBenefits.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-benefits-2018-05-10/GetBenefit">REST API Reference for GetBenefit Operation</seealso>
        GetBenefitResponse EndGetBenefit(IAsyncResult asyncResult);

        #endregion
        
        #region  GetBenefitAllocation


        /// <summary>
        /// Retrieves detailed information about a specific benefit allocation that has been granted
        /// to a partner.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetBenefitAllocation service method.</param>
        /// 
        /// <returns>The response from the GetBenefitAllocation service method, as returned by PartnerCentralBenefits.</returns>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.AccessDeniedException">
        /// Thrown when the caller does not have sufficient permissions to perform the requested
        /// operation.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.InternalServerException">
        /// Thrown when an unexpected error occurs on the server side during request processing.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.ResourceNotFoundException">
        /// Thrown when the requested resource cannot be found or does not exist.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.ThrottlingException">
        /// Thrown when the request rate exceeds the allowed limits and the request is being throttled.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.ValidationException">
        /// Thrown when the request contains invalid parameters or fails input validation requirements.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-benefits-2018-05-10/GetBenefitAllocation">REST API Reference for GetBenefitAllocation Operation</seealso>
        GetBenefitAllocationResponse GetBenefitAllocation(GetBenefitAllocationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetBenefitAllocation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetBenefitAllocation operation on AmazonPartnerCentralBenefitsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetBenefitAllocation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-benefits-2018-05-10/GetBenefitAllocation">REST API Reference for GetBenefitAllocation Operation</seealso>
        IAsyncResult BeginGetBenefitAllocation(GetBenefitAllocationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetBenefitAllocation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetBenefitAllocation.</param>
        /// 
        /// <returns>Returns a  GetBenefitAllocationResult from PartnerCentralBenefits.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-benefits-2018-05-10/GetBenefitAllocation">REST API Reference for GetBenefitAllocation Operation</seealso>
        GetBenefitAllocationResponse EndGetBenefitAllocation(IAsyncResult asyncResult);

        #endregion
        
        #region  GetBenefitApplication


        /// <summary>
        /// Retrieves detailed information about a specific benefit application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetBenefitApplication service method.</param>
        /// 
        /// <returns>The response from the GetBenefitApplication service method, as returned by PartnerCentralBenefits.</returns>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.AccessDeniedException">
        /// Thrown when the caller does not have sufficient permissions to perform the requested
        /// operation.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.ConflictException">
        /// Thrown when the request conflicts with the current state of the resource, such as
        /// attempting to modify a resource that has been changed by another process.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.InternalServerException">
        /// Thrown when an unexpected error occurs on the server side during request processing.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.ResourceNotFoundException">
        /// Thrown when the requested resource cannot be found or does not exist.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.ThrottlingException">
        /// Thrown when the request rate exceeds the allowed limits and the request is being throttled.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.ValidationException">
        /// Thrown when the request contains invalid parameters or fails input validation requirements.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-benefits-2018-05-10/GetBenefitApplication">REST API Reference for GetBenefitApplication Operation</seealso>
        GetBenefitApplicationResponse GetBenefitApplication(GetBenefitApplicationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetBenefitApplication operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetBenefitApplication operation on AmazonPartnerCentralBenefitsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetBenefitApplication
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-benefits-2018-05-10/GetBenefitApplication">REST API Reference for GetBenefitApplication Operation</seealso>
        IAsyncResult BeginGetBenefitApplication(GetBenefitApplicationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetBenefitApplication operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetBenefitApplication.</param>
        /// 
        /// <returns>Returns a  GetBenefitApplicationResult from PartnerCentralBenefits.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-benefits-2018-05-10/GetBenefitApplication">REST API Reference for GetBenefitApplication Operation</seealso>
        GetBenefitApplicationResponse EndGetBenefitApplication(IAsyncResult asyncResult);

        #endregion
        
        #region  ListBenefitAllocations


        /// <summary>
        /// Retrieves a paginated list of benefit allocations based on specified filter criteria.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListBenefitAllocations service method.</param>
        /// 
        /// <returns>The response from the ListBenefitAllocations service method, as returned by PartnerCentralBenefits.</returns>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.AccessDeniedException">
        /// Thrown when the caller does not have sufficient permissions to perform the requested
        /// operation.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.InternalServerException">
        /// Thrown when an unexpected error occurs on the server side during request processing.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.ResourceNotFoundException">
        /// Thrown when the requested resource cannot be found or does not exist.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.ThrottlingException">
        /// Thrown when the request rate exceeds the allowed limits and the request is being throttled.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.ValidationException">
        /// Thrown when the request contains invalid parameters or fails input validation requirements.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-benefits-2018-05-10/ListBenefitAllocations">REST API Reference for ListBenefitAllocations Operation</seealso>
        ListBenefitAllocationsResponse ListBenefitAllocations(ListBenefitAllocationsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListBenefitAllocations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListBenefitAllocations operation on AmazonPartnerCentralBenefitsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListBenefitAllocations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-benefits-2018-05-10/ListBenefitAllocations">REST API Reference for ListBenefitAllocations Operation</seealso>
        IAsyncResult BeginListBenefitAllocations(ListBenefitAllocationsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListBenefitAllocations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListBenefitAllocations.</param>
        /// 
        /// <returns>Returns a  ListBenefitAllocationsResult from PartnerCentralBenefits.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-benefits-2018-05-10/ListBenefitAllocations">REST API Reference for ListBenefitAllocations Operation</seealso>
        ListBenefitAllocationsResponse EndListBenefitAllocations(IAsyncResult asyncResult);

        #endregion
        
        #region  ListBenefitApplications


        /// <summary>
        /// Retrieves a paginated list of benefit applications based on specified filter criteria.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListBenefitApplications service method.</param>
        /// 
        /// <returns>The response from the ListBenefitApplications service method, as returned by PartnerCentralBenefits.</returns>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.AccessDeniedException">
        /// Thrown when the caller does not have sufficient permissions to perform the requested
        /// operation.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.InternalServerException">
        /// Thrown when an unexpected error occurs on the server side during request processing.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.ResourceNotFoundException">
        /// Thrown when the requested resource cannot be found or does not exist.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.ThrottlingException">
        /// Thrown when the request rate exceeds the allowed limits and the request is being throttled.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.ValidationException">
        /// Thrown when the request contains invalid parameters or fails input validation requirements.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-benefits-2018-05-10/ListBenefitApplications">REST API Reference for ListBenefitApplications Operation</seealso>
        ListBenefitApplicationsResponse ListBenefitApplications(ListBenefitApplicationsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListBenefitApplications operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListBenefitApplications operation on AmazonPartnerCentralBenefitsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListBenefitApplications
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-benefits-2018-05-10/ListBenefitApplications">REST API Reference for ListBenefitApplications Operation</seealso>
        IAsyncResult BeginListBenefitApplications(ListBenefitApplicationsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListBenefitApplications operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListBenefitApplications.</param>
        /// 
        /// <returns>Returns a  ListBenefitApplicationsResult from PartnerCentralBenefits.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-benefits-2018-05-10/ListBenefitApplications">REST API Reference for ListBenefitApplications Operation</seealso>
        ListBenefitApplicationsResponse EndListBenefitApplications(IAsyncResult asyncResult);

        #endregion
        
        #region  ListBenefits


        /// <summary>
        /// Retrieves a paginated list of available benefits based on specified filter criteria.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListBenefits service method.</param>
        /// 
        /// <returns>The response from the ListBenefits service method, as returned by PartnerCentralBenefits.</returns>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.AccessDeniedException">
        /// Thrown when the caller does not have sufficient permissions to perform the requested
        /// operation.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.InternalServerException">
        /// Thrown when an unexpected error occurs on the server side during request processing.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.ResourceNotFoundException">
        /// Thrown when the requested resource cannot be found or does not exist.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.ThrottlingException">
        /// Thrown when the request rate exceeds the allowed limits and the request is being throttled.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.ValidationException">
        /// Thrown when the request contains invalid parameters or fails input validation requirements.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-benefits-2018-05-10/ListBenefits">REST API Reference for ListBenefits Operation</seealso>
        ListBenefitsResponse ListBenefits(ListBenefitsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListBenefits operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListBenefits operation on AmazonPartnerCentralBenefitsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListBenefits
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-benefits-2018-05-10/ListBenefits">REST API Reference for ListBenefits Operation</seealso>
        IAsyncResult BeginListBenefits(ListBenefitsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListBenefits operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListBenefits.</param>
        /// 
        /// <returns>Returns a  ListBenefitsResult from PartnerCentralBenefits.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-benefits-2018-05-10/ListBenefits">REST API Reference for ListBenefits Operation</seealso>
        ListBenefitsResponse EndListBenefits(IAsyncResult asyncResult);

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// Retrieves all tags associated with a specific resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by PartnerCentralBenefits.</returns>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.AccessDeniedException">
        /// Thrown when the caller does not have sufficient permissions to perform the requested
        /// operation.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.InternalServerException">
        /// Thrown when an unexpected error occurs on the server side during request processing.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.ResourceNotFoundException">
        /// Thrown when the requested resource cannot be found or does not exist.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.ThrottlingException">
        /// Thrown when the request rate exceeds the allowed limits and the request is being throttled.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.ValidationException">
        /// Thrown when the request contains invalid parameters or fails input validation requirements.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-benefits-2018-05-10/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonPartnerCentralBenefitsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-benefits-2018-05-10/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        IAsyncResult BeginListTagsForResource(ListTagsForResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTagsForResource.</param>
        /// 
        /// <returns>Returns a  ListTagsForResourceResult from PartnerCentralBenefits.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-benefits-2018-05-10/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult);

        #endregion
        
        #region  RecallBenefitApplication


        /// <summary>
        /// Recalls a submitted benefit application, returning it to draft status for further
        /// modifications.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RecallBenefitApplication service method.</param>
        /// 
        /// <returns>The response from the RecallBenefitApplication service method, as returned by PartnerCentralBenefits.</returns>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.AccessDeniedException">
        /// Thrown when the caller does not have sufficient permissions to perform the requested
        /// operation.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.ConflictException">
        /// Thrown when the request conflicts with the current state of the resource, such as
        /// attempting to modify a resource that has been changed by another process.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.InternalServerException">
        /// Thrown when an unexpected error occurs on the server side during request processing.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.ResourceNotFoundException">
        /// Thrown when the requested resource cannot be found or does not exist.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.ThrottlingException">
        /// Thrown when the request rate exceeds the allowed limits and the request is being throttled.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.ValidationException">
        /// Thrown when the request contains invalid parameters or fails input validation requirements.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-benefits-2018-05-10/RecallBenefitApplication">REST API Reference for RecallBenefitApplication Operation</seealso>
        RecallBenefitApplicationResponse RecallBenefitApplication(RecallBenefitApplicationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the RecallBenefitApplication operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RecallBenefitApplication operation on AmazonPartnerCentralBenefitsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRecallBenefitApplication
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-benefits-2018-05-10/RecallBenefitApplication">REST API Reference for RecallBenefitApplication Operation</seealso>
        IAsyncResult BeginRecallBenefitApplication(RecallBenefitApplicationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  RecallBenefitApplication operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRecallBenefitApplication.</param>
        /// 
        /// <returns>Returns a  RecallBenefitApplicationResult from PartnerCentralBenefits.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-benefits-2018-05-10/RecallBenefitApplication">REST API Reference for RecallBenefitApplication Operation</seealso>
        RecallBenefitApplicationResponse EndRecallBenefitApplication(IAsyncResult asyncResult);

        #endregion
        
        #region  SubmitBenefitApplication


        /// <summary>
        /// Submits a benefit application for review and processing by AWS.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SubmitBenefitApplication service method.</param>
        /// 
        /// <returns>The response from the SubmitBenefitApplication service method, as returned by PartnerCentralBenefits.</returns>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.AccessDeniedException">
        /// Thrown when the caller does not have sufficient permissions to perform the requested
        /// operation.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.ConflictException">
        /// Thrown when the request conflicts with the current state of the resource, such as
        /// attempting to modify a resource that has been changed by another process.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.InternalServerException">
        /// Thrown when an unexpected error occurs on the server side during request processing.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.ResourceNotFoundException">
        /// Thrown when the requested resource cannot be found or does not exist.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.ThrottlingException">
        /// Thrown when the request rate exceeds the allowed limits and the request is being throttled.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.ValidationException">
        /// Thrown when the request contains invalid parameters or fails input validation requirements.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-benefits-2018-05-10/SubmitBenefitApplication">REST API Reference for SubmitBenefitApplication Operation</seealso>
        SubmitBenefitApplicationResponse SubmitBenefitApplication(SubmitBenefitApplicationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the SubmitBenefitApplication operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SubmitBenefitApplication operation on AmazonPartnerCentralBenefitsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSubmitBenefitApplication
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-benefits-2018-05-10/SubmitBenefitApplication">REST API Reference for SubmitBenefitApplication Operation</seealso>
        IAsyncResult BeginSubmitBenefitApplication(SubmitBenefitApplicationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  SubmitBenefitApplication operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSubmitBenefitApplication.</param>
        /// 
        /// <returns>Returns a  SubmitBenefitApplicationResult from PartnerCentralBenefits.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-benefits-2018-05-10/SubmitBenefitApplication">REST API Reference for SubmitBenefitApplication Operation</seealso>
        SubmitBenefitApplicationResponse EndSubmitBenefitApplication(IAsyncResult asyncResult);

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Adds or updates tags for a specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by PartnerCentralBenefits.</returns>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.AccessDeniedException">
        /// Thrown when the caller does not have sufficient permissions to perform the requested
        /// operation.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.ConflictException">
        /// Thrown when the request conflicts with the current state of the resource, such as
        /// attempting to modify a resource that has been changed by another process.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.InternalServerException">
        /// Thrown when an unexpected error occurs on the server side during request processing.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.ResourceNotFoundException">
        /// Thrown when the requested resource cannot be found or does not exist.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.ServiceQuotaExceededException">
        /// Thrown when the request would exceed the service quotas or limits for the account.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.ThrottlingException">
        /// Thrown when the request rate exceeds the allowed limits and the request is being throttled.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.ValidationException">
        /// Thrown when the request contains invalid parameters or fails input validation requirements.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-benefits-2018-05-10/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse TagResource(TagResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the TagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonPartnerCentralBenefitsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-benefits-2018-05-10/TagResource">REST API Reference for TagResource Operation</seealso>
        IAsyncResult BeginTagResource(TagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  TagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTagResource.</param>
        /// 
        /// <returns>Returns a  TagResourceResult from PartnerCentralBenefits.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-benefits-2018-05-10/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse EndTagResource(IAsyncResult asyncResult);

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// Removes specified tags from a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by PartnerCentralBenefits.</returns>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.AccessDeniedException">
        /// Thrown when the caller does not have sufficient permissions to perform the requested
        /// operation.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.ConflictException">
        /// Thrown when the request conflicts with the current state of the resource, such as
        /// attempting to modify a resource that has been changed by another process.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.InternalServerException">
        /// Thrown when an unexpected error occurs on the server side during request processing.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.ResourceNotFoundException">
        /// Thrown when the requested resource cannot be found or does not exist.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.ServiceQuotaExceededException">
        /// Thrown when the request would exceed the service quotas or limits for the account.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.ThrottlingException">
        /// Thrown when the request rate exceeds the allowed limits and the request is being throttled.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.ValidationException">
        /// Thrown when the request contains invalid parameters or fails input validation requirements.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-benefits-2018-05-10/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse UntagResource(UntagResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UntagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonPartnerCentralBenefitsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-benefits-2018-05-10/UntagResource">REST API Reference for UntagResource Operation</seealso>
        IAsyncResult BeginUntagResource(UntagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UntagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUntagResource.</param>
        /// 
        /// <returns>Returns a  UntagResourceResult from PartnerCentralBenefits.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-benefits-2018-05-10/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse EndUntagResource(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateBenefitApplication


        /// <summary>
        /// Updates an existing benefit application with new information while maintaining revision
        /// control.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateBenefitApplication service method.</param>
        /// 
        /// <returns>The response from the UpdateBenefitApplication service method, as returned by PartnerCentralBenefits.</returns>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.AccessDeniedException">
        /// Thrown when the caller does not have sufficient permissions to perform the requested
        /// operation.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.ConflictException">
        /// Thrown when the request conflicts with the current state of the resource, such as
        /// attempting to modify a resource that has been changed by another process.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.InternalServerException">
        /// Thrown when an unexpected error occurs on the server side during request processing.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.ResourceNotFoundException">
        /// Thrown when the requested resource cannot be found or does not exist.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.ThrottlingException">
        /// Thrown when the request rate exceeds the allowed limits and the request is being throttled.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.ValidationException">
        /// Thrown when the request contains invalid parameters or fails input validation requirements.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-benefits-2018-05-10/UpdateBenefitApplication">REST API Reference for UpdateBenefitApplication Operation</seealso>
        UpdateBenefitApplicationResponse UpdateBenefitApplication(UpdateBenefitApplicationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateBenefitApplication operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateBenefitApplication operation on AmazonPartnerCentralBenefitsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateBenefitApplication
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-benefits-2018-05-10/UpdateBenefitApplication">REST API Reference for UpdateBenefitApplication Operation</seealso>
        IAsyncResult BeginUpdateBenefitApplication(UpdateBenefitApplicationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateBenefitApplication operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateBenefitApplication.</param>
        /// 
        /// <returns>Returns a  UpdateBenefitApplicationResult from PartnerCentralBenefits.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-benefits-2018-05-10/UpdateBenefitApplication">REST API Reference for UpdateBenefitApplication Operation</seealso>
        UpdateBenefitApplicationResponse EndUpdateBenefitApplication(IAsyncResult asyncResult);

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