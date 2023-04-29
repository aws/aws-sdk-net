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
 * Do not modify this file. This file is generated from the privatenetworks-2021-12-03.normal.json service model.
 */


using System;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.Private5G.Model;

namespace Amazon.Private5G
{
    /// <summary>
    /// Interface for accessing Private5G
    ///
    /// Amazon Web Services Private 5G is a managed service that makes it easy to deploy,
    /// operate, and scale your own private mobile network at your on-premises location. Private
    /// 5G provides the pre-configured hardware and software for mobile networks, helps automate
    /// setup, and scales capacity on demand to support additional devices as needed.
    /// </summary>
    public partial interface IAmazonPrivate5G : IAmazonService, IDisposable
    {


#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        IPrivate5GPaginatorFactory Paginators { get; }
#endif


        
        #region  AcknowledgeOrderReceipt


        /// <summary>
        /// Acknowledges that the specified network order was received.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AcknowledgeOrderReceipt service method.</param>
        /// 
        /// <returns>The response from the AcknowledgeOrderReceipt service method, as returned by Private5G.</returns>
        /// <exception cref="Amazon.Private5G.Model.InternalServerException">
        /// Information about an internal error.
        /// </exception>
        /// <exception cref="Amazon.Private5G.Model.ResourceNotFoundException">
        /// The resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Private5G.Model.ValidationException">
        /// The request failed validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/privatenetworks-2021-12-03/AcknowledgeOrderReceipt">REST API Reference for AcknowledgeOrderReceipt Operation</seealso>
        AcknowledgeOrderReceiptResponse AcknowledgeOrderReceipt(AcknowledgeOrderReceiptRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the AcknowledgeOrderReceipt operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AcknowledgeOrderReceipt operation on AmazonPrivate5GClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAcknowledgeOrderReceipt
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/privatenetworks-2021-12-03/AcknowledgeOrderReceipt">REST API Reference for AcknowledgeOrderReceipt Operation</seealso>
        IAsyncResult BeginAcknowledgeOrderReceipt(AcknowledgeOrderReceiptRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  AcknowledgeOrderReceipt operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAcknowledgeOrderReceipt.</param>
        /// 
        /// <returns>Returns a  AcknowledgeOrderReceiptResult from Private5G.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/privatenetworks-2021-12-03/AcknowledgeOrderReceipt">REST API Reference for AcknowledgeOrderReceipt Operation</seealso>
        AcknowledgeOrderReceiptResponse EndAcknowledgeOrderReceipt(IAsyncResult asyncResult);

        #endregion
        
        #region  ActivateDeviceIdentifier


        /// <summary>
        /// Activates the specified device identifier.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ActivateDeviceIdentifier service method.</param>
        /// 
        /// <returns>The response from the ActivateDeviceIdentifier service method, as returned by Private5G.</returns>
        /// <exception cref="Amazon.Private5G.Model.InternalServerException">
        /// Information about an internal error.
        /// </exception>
        /// <exception cref="Amazon.Private5G.Model.ResourceNotFoundException">
        /// The resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Private5G.Model.ValidationException">
        /// The request failed validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/privatenetworks-2021-12-03/ActivateDeviceIdentifier">REST API Reference for ActivateDeviceIdentifier Operation</seealso>
        ActivateDeviceIdentifierResponse ActivateDeviceIdentifier(ActivateDeviceIdentifierRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ActivateDeviceIdentifier operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ActivateDeviceIdentifier operation on AmazonPrivate5GClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndActivateDeviceIdentifier
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/privatenetworks-2021-12-03/ActivateDeviceIdentifier">REST API Reference for ActivateDeviceIdentifier Operation</seealso>
        IAsyncResult BeginActivateDeviceIdentifier(ActivateDeviceIdentifierRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ActivateDeviceIdentifier operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginActivateDeviceIdentifier.</param>
        /// 
        /// <returns>Returns a  ActivateDeviceIdentifierResult from Private5G.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/privatenetworks-2021-12-03/ActivateDeviceIdentifier">REST API Reference for ActivateDeviceIdentifier Operation</seealso>
        ActivateDeviceIdentifierResponse EndActivateDeviceIdentifier(IAsyncResult asyncResult);

        #endregion
        
        #region  ActivateNetworkSite


        /// <summary>
        /// Activates the specified network site.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ActivateNetworkSite service method.</param>
        /// 
        /// <returns>The response from the ActivateNetworkSite service method, as returned by Private5G.</returns>
        /// <exception cref="Amazon.Private5G.Model.InternalServerException">
        /// Information about an internal error.
        /// </exception>
        /// <exception cref="Amazon.Private5G.Model.ResourceNotFoundException">
        /// The resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Private5G.Model.ValidationException">
        /// The request failed validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/privatenetworks-2021-12-03/ActivateNetworkSite">REST API Reference for ActivateNetworkSite Operation</seealso>
        ActivateNetworkSiteResponse ActivateNetworkSite(ActivateNetworkSiteRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ActivateNetworkSite operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ActivateNetworkSite operation on AmazonPrivate5GClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndActivateNetworkSite
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/privatenetworks-2021-12-03/ActivateNetworkSite">REST API Reference for ActivateNetworkSite Operation</seealso>
        IAsyncResult BeginActivateNetworkSite(ActivateNetworkSiteRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ActivateNetworkSite operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginActivateNetworkSite.</param>
        /// 
        /// <returns>Returns a  ActivateNetworkSiteResult from Private5G.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/privatenetworks-2021-12-03/ActivateNetworkSite">REST API Reference for ActivateNetworkSite Operation</seealso>
        ActivateNetworkSiteResponse EndActivateNetworkSite(IAsyncResult asyncResult);

        #endregion
        
        #region  ConfigureAccessPoint


        /// <summary>
        /// Configures the specified network resource. 
        /// 
        ///  
        /// <para>
        ///  Use this action to specify the geographic position of the hardware. You must provide
        /// Certified Professional Installer (CPI) credentials in the request so that we can obtain
        /// spectrum grants. For more information, see <a href="https://docs.aws.amazon.com/private-networks/latest/userguide/radio-units.html">Radio
        /// units</a> in the <i>Amazon Web Services Private 5G User Guide</i>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ConfigureAccessPoint service method.</param>
        /// 
        /// <returns>The response from the ConfigureAccessPoint service method, as returned by Private5G.</returns>
        /// <exception cref="Amazon.Private5G.Model.InternalServerException">
        /// Information about an internal error.
        /// </exception>
        /// <exception cref="Amazon.Private5G.Model.ResourceNotFoundException">
        /// The resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Private5G.Model.ValidationException">
        /// The request failed validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/privatenetworks-2021-12-03/ConfigureAccessPoint">REST API Reference for ConfigureAccessPoint Operation</seealso>
        ConfigureAccessPointResponse ConfigureAccessPoint(ConfigureAccessPointRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ConfigureAccessPoint operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ConfigureAccessPoint operation on AmazonPrivate5GClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndConfigureAccessPoint
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/privatenetworks-2021-12-03/ConfigureAccessPoint">REST API Reference for ConfigureAccessPoint Operation</seealso>
        IAsyncResult BeginConfigureAccessPoint(ConfigureAccessPointRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ConfigureAccessPoint operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginConfigureAccessPoint.</param>
        /// 
        /// <returns>Returns a  ConfigureAccessPointResult from Private5G.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/privatenetworks-2021-12-03/ConfigureAccessPoint">REST API Reference for ConfigureAccessPoint Operation</seealso>
        ConfigureAccessPointResponse EndConfigureAccessPoint(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateNetwork


        /// <summary>
        /// Creates a network.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateNetwork service method.</param>
        /// 
        /// <returns>The response from the CreateNetwork service method, as returned by Private5G.</returns>
        /// <exception cref="Amazon.Private5G.Model.InternalServerException">
        /// Information about an internal error.
        /// </exception>
        /// <exception cref="Amazon.Private5G.Model.LimitExceededException">
        /// The limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Private5G.Model.ValidationException">
        /// The request failed validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/privatenetworks-2021-12-03/CreateNetwork">REST API Reference for CreateNetwork Operation</seealso>
        CreateNetworkResponse CreateNetwork(CreateNetworkRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateNetwork operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateNetwork operation on AmazonPrivate5GClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateNetwork
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/privatenetworks-2021-12-03/CreateNetwork">REST API Reference for CreateNetwork Operation</seealso>
        IAsyncResult BeginCreateNetwork(CreateNetworkRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateNetwork operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateNetwork.</param>
        /// 
        /// <returns>Returns a  CreateNetworkResult from Private5G.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/privatenetworks-2021-12-03/CreateNetwork">REST API Reference for CreateNetwork Operation</seealso>
        CreateNetworkResponse EndCreateNetwork(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateNetworkSite


        /// <summary>
        /// Creates a network site.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateNetworkSite service method.</param>
        /// 
        /// <returns>The response from the CreateNetworkSite service method, as returned by Private5G.</returns>
        /// <exception cref="Amazon.Private5G.Model.InternalServerException">
        /// Information about an internal error.
        /// </exception>
        /// <exception cref="Amazon.Private5G.Model.ResourceNotFoundException">
        /// The resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Private5G.Model.ValidationException">
        /// The request failed validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/privatenetworks-2021-12-03/CreateNetworkSite">REST API Reference for CreateNetworkSite Operation</seealso>
        CreateNetworkSiteResponse CreateNetworkSite(CreateNetworkSiteRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateNetworkSite operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateNetworkSite operation on AmazonPrivate5GClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateNetworkSite
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/privatenetworks-2021-12-03/CreateNetworkSite">REST API Reference for CreateNetworkSite Operation</seealso>
        IAsyncResult BeginCreateNetworkSite(CreateNetworkSiteRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateNetworkSite operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateNetworkSite.</param>
        /// 
        /// <returns>Returns a  CreateNetworkSiteResult from Private5G.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/privatenetworks-2021-12-03/CreateNetworkSite">REST API Reference for CreateNetworkSite Operation</seealso>
        CreateNetworkSiteResponse EndCreateNetworkSite(IAsyncResult asyncResult);

        #endregion
        
        #region  DeactivateDeviceIdentifier


        /// <summary>
        /// Deactivates the specified device identifier.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeactivateDeviceIdentifier service method.</param>
        /// 
        /// <returns>The response from the DeactivateDeviceIdentifier service method, as returned by Private5G.</returns>
        /// <exception cref="Amazon.Private5G.Model.InternalServerException">
        /// Information about an internal error.
        /// </exception>
        /// <exception cref="Amazon.Private5G.Model.ResourceNotFoundException">
        /// The resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Private5G.Model.ValidationException">
        /// The request failed validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/privatenetworks-2021-12-03/DeactivateDeviceIdentifier">REST API Reference for DeactivateDeviceIdentifier Operation</seealso>
        DeactivateDeviceIdentifierResponse DeactivateDeviceIdentifier(DeactivateDeviceIdentifierRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeactivateDeviceIdentifier operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeactivateDeviceIdentifier operation on AmazonPrivate5GClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeactivateDeviceIdentifier
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/privatenetworks-2021-12-03/DeactivateDeviceIdentifier">REST API Reference for DeactivateDeviceIdentifier Operation</seealso>
        IAsyncResult BeginDeactivateDeviceIdentifier(DeactivateDeviceIdentifierRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeactivateDeviceIdentifier operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeactivateDeviceIdentifier.</param>
        /// 
        /// <returns>Returns a  DeactivateDeviceIdentifierResult from Private5G.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/privatenetworks-2021-12-03/DeactivateDeviceIdentifier">REST API Reference for DeactivateDeviceIdentifier Operation</seealso>
        DeactivateDeviceIdentifierResponse EndDeactivateDeviceIdentifier(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteNetwork


        /// <summary>
        /// Deletes the specified network. You must delete network sites before you delete the
        /// network. For more information, see <a href="https://docs.aws.amazon.com/private-networks/latest/APIReference/API_DeleteNetworkSite.html">DeleteNetworkSite</a>
        /// in the <i>API Reference for Amazon Web Services Private 5G</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteNetwork service method.</param>
        /// 
        /// <returns>The response from the DeleteNetwork service method, as returned by Private5G.</returns>
        /// <exception cref="Amazon.Private5G.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.Private5G.Model.InternalServerException">
        /// Information about an internal error.
        /// </exception>
        /// <exception cref="Amazon.Private5G.Model.ResourceNotFoundException">
        /// The resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Private5G.Model.ValidationException">
        /// The request failed validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/privatenetworks-2021-12-03/DeleteNetwork">REST API Reference for DeleteNetwork Operation</seealso>
        DeleteNetworkResponse DeleteNetwork(DeleteNetworkRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteNetwork operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteNetwork operation on AmazonPrivate5GClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteNetwork
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/privatenetworks-2021-12-03/DeleteNetwork">REST API Reference for DeleteNetwork Operation</seealso>
        IAsyncResult BeginDeleteNetwork(DeleteNetworkRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteNetwork operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteNetwork.</param>
        /// 
        /// <returns>Returns a  DeleteNetworkResult from Private5G.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/privatenetworks-2021-12-03/DeleteNetwork">REST API Reference for DeleteNetwork Operation</seealso>
        DeleteNetworkResponse EndDeleteNetwork(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteNetworkSite


        /// <summary>
        /// Deletes the specified network site. Return the hardware after you delete the network
        /// site. You are responsible for minimum charges. For more information, see <a href="https://docs.aws.amazon.com/private-networks/latest/userguide/hardware-maintenance.html">Hardware
        /// returns</a> in the <i>Amazon Web Services Private 5G User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteNetworkSite service method.</param>
        /// 
        /// <returns>The response from the DeleteNetworkSite service method, as returned by Private5G.</returns>
        /// <exception cref="Amazon.Private5G.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.Private5G.Model.InternalServerException">
        /// Information about an internal error.
        /// </exception>
        /// <exception cref="Amazon.Private5G.Model.ResourceNotFoundException">
        /// The resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Private5G.Model.ValidationException">
        /// The request failed validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/privatenetworks-2021-12-03/DeleteNetworkSite">REST API Reference for DeleteNetworkSite Operation</seealso>
        DeleteNetworkSiteResponse DeleteNetworkSite(DeleteNetworkSiteRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteNetworkSite operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteNetworkSite operation on AmazonPrivate5GClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteNetworkSite
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/privatenetworks-2021-12-03/DeleteNetworkSite">REST API Reference for DeleteNetworkSite Operation</seealso>
        IAsyncResult BeginDeleteNetworkSite(DeleteNetworkSiteRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteNetworkSite operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteNetworkSite.</param>
        /// 
        /// <returns>Returns a  DeleteNetworkSiteResult from Private5G.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/privatenetworks-2021-12-03/DeleteNetworkSite">REST API Reference for DeleteNetworkSite Operation</seealso>
        DeleteNetworkSiteResponse EndDeleteNetworkSite(IAsyncResult asyncResult);

        #endregion
        
        #region  GetDeviceIdentifier


        /// <summary>
        /// Gets the specified device identifier.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDeviceIdentifier service method.</param>
        /// 
        /// <returns>The response from the GetDeviceIdentifier service method, as returned by Private5G.</returns>
        /// <exception cref="Amazon.Private5G.Model.InternalServerException">
        /// Information about an internal error.
        /// </exception>
        /// <exception cref="Amazon.Private5G.Model.ResourceNotFoundException">
        /// The resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Private5G.Model.ValidationException">
        /// The request failed validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/privatenetworks-2021-12-03/GetDeviceIdentifier">REST API Reference for GetDeviceIdentifier Operation</seealso>
        GetDeviceIdentifierResponse GetDeviceIdentifier(GetDeviceIdentifierRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetDeviceIdentifier operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDeviceIdentifier operation on AmazonPrivate5GClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetDeviceIdentifier
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/privatenetworks-2021-12-03/GetDeviceIdentifier">REST API Reference for GetDeviceIdentifier Operation</seealso>
        IAsyncResult BeginGetDeviceIdentifier(GetDeviceIdentifierRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetDeviceIdentifier operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDeviceIdentifier.</param>
        /// 
        /// <returns>Returns a  GetDeviceIdentifierResult from Private5G.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/privatenetworks-2021-12-03/GetDeviceIdentifier">REST API Reference for GetDeviceIdentifier Operation</seealso>
        GetDeviceIdentifierResponse EndGetDeviceIdentifier(IAsyncResult asyncResult);

        #endregion
        
        #region  GetNetwork


        /// <summary>
        /// Gets the specified network.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetNetwork service method.</param>
        /// 
        /// <returns>The response from the GetNetwork service method, as returned by Private5G.</returns>
        /// <exception cref="Amazon.Private5G.Model.InternalServerException">
        /// Information about an internal error.
        /// </exception>
        /// <exception cref="Amazon.Private5G.Model.ResourceNotFoundException">
        /// The resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Private5G.Model.ValidationException">
        /// The request failed validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/privatenetworks-2021-12-03/GetNetwork">REST API Reference for GetNetwork Operation</seealso>
        GetNetworkResponse GetNetwork(GetNetworkRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetNetwork operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetNetwork operation on AmazonPrivate5GClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetNetwork
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/privatenetworks-2021-12-03/GetNetwork">REST API Reference for GetNetwork Operation</seealso>
        IAsyncResult BeginGetNetwork(GetNetworkRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetNetwork operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetNetwork.</param>
        /// 
        /// <returns>Returns a  GetNetworkResult from Private5G.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/privatenetworks-2021-12-03/GetNetwork">REST API Reference for GetNetwork Operation</seealso>
        GetNetworkResponse EndGetNetwork(IAsyncResult asyncResult);

        #endregion
        
        #region  GetNetworkResource


        /// <summary>
        /// Gets the specified network resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetNetworkResource service method.</param>
        /// 
        /// <returns>The response from the GetNetworkResource service method, as returned by Private5G.</returns>
        /// <exception cref="Amazon.Private5G.Model.InternalServerException">
        /// Information about an internal error.
        /// </exception>
        /// <exception cref="Amazon.Private5G.Model.ResourceNotFoundException">
        /// The resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Private5G.Model.ValidationException">
        /// The request failed validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/privatenetworks-2021-12-03/GetNetworkResource">REST API Reference for GetNetworkResource Operation</seealso>
        GetNetworkResourceResponse GetNetworkResource(GetNetworkResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetNetworkResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetNetworkResource operation on AmazonPrivate5GClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetNetworkResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/privatenetworks-2021-12-03/GetNetworkResource">REST API Reference for GetNetworkResource Operation</seealso>
        IAsyncResult BeginGetNetworkResource(GetNetworkResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetNetworkResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetNetworkResource.</param>
        /// 
        /// <returns>Returns a  GetNetworkResourceResult from Private5G.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/privatenetworks-2021-12-03/GetNetworkResource">REST API Reference for GetNetworkResource Operation</seealso>
        GetNetworkResourceResponse EndGetNetworkResource(IAsyncResult asyncResult);

        #endregion
        
        #region  GetNetworkSite


        /// <summary>
        /// Gets the specified network site.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetNetworkSite service method.</param>
        /// 
        /// <returns>The response from the GetNetworkSite service method, as returned by Private5G.</returns>
        /// <exception cref="Amazon.Private5G.Model.InternalServerException">
        /// Information about an internal error.
        /// </exception>
        /// <exception cref="Amazon.Private5G.Model.ResourceNotFoundException">
        /// The resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Private5G.Model.ValidationException">
        /// The request failed validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/privatenetworks-2021-12-03/GetNetworkSite">REST API Reference for GetNetworkSite Operation</seealso>
        GetNetworkSiteResponse GetNetworkSite(GetNetworkSiteRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetNetworkSite operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetNetworkSite operation on AmazonPrivate5GClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetNetworkSite
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/privatenetworks-2021-12-03/GetNetworkSite">REST API Reference for GetNetworkSite Operation</seealso>
        IAsyncResult BeginGetNetworkSite(GetNetworkSiteRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetNetworkSite operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetNetworkSite.</param>
        /// 
        /// <returns>Returns a  GetNetworkSiteResult from Private5G.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/privatenetworks-2021-12-03/GetNetworkSite">REST API Reference for GetNetworkSite Operation</seealso>
        GetNetworkSiteResponse EndGetNetworkSite(IAsyncResult asyncResult);

        #endregion
        
        #region  GetOrder


        /// <summary>
        /// Gets the specified order.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetOrder service method.</param>
        /// 
        /// <returns>The response from the GetOrder service method, as returned by Private5G.</returns>
        /// <exception cref="Amazon.Private5G.Model.InternalServerException">
        /// Information about an internal error.
        /// </exception>
        /// <exception cref="Amazon.Private5G.Model.ResourceNotFoundException">
        /// The resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Private5G.Model.ValidationException">
        /// The request failed validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/privatenetworks-2021-12-03/GetOrder">REST API Reference for GetOrder Operation</seealso>
        GetOrderResponse GetOrder(GetOrderRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetOrder operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetOrder operation on AmazonPrivate5GClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetOrder
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/privatenetworks-2021-12-03/GetOrder">REST API Reference for GetOrder Operation</seealso>
        IAsyncResult BeginGetOrder(GetOrderRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetOrder operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetOrder.</param>
        /// 
        /// <returns>Returns a  GetOrderResult from Private5G.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/privatenetworks-2021-12-03/GetOrder">REST API Reference for GetOrder Operation</seealso>
        GetOrderResponse EndGetOrder(IAsyncResult asyncResult);

        #endregion
        
        #region  ListDeviceIdentifiers


        /// <summary>
        /// Lists device identifiers. Add filters to your request to return a more specific list
        /// of results. Use filters to match the Amazon Resource Name (ARN) of an order, the status
        /// of device identifiers, or the ARN of the traffic group.
        /// 
        ///  
        /// <para>
        /// If you specify multiple filters, filters are joined with an OR, and the request returns
        /// results that match all of the specified filters.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDeviceIdentifiers service method.</param>
        /// 
        /// <returns>The response from the ListDeviceIdentifiers service method, as returned by Private5G.</returns>
        /// <exception cref="Amazon.Private5G.Model.InternalServerException">
        /// Information about an internal error.
        /// </exception>
        /// <exception cref="Amazon.Private5G.Model.ResourceNotFoundException">
        /// The resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Private5G.Model.ValidationException">
        /// The request failed validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/privatenetworks-2021-12-03/ListDeviceIdentifiers">REST API Reference for ListDeviceIdentifiers Operation</seealso>
        ListDeviceIdentifiersResponse ListDeviceIdentifiers(ListDeviceIdentifiersRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListDeviceIdentifiers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDeviceIdentifiers operation on AmazonPrivate5GClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListDeviceIdentifiers
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/privatenetworks-2021-12-03/ListDeviceIdentifiers">REST API Reference for ListDeviceIdentifiers Operation</seealso>
        IAsyncResult BeginListDeviceIdentifiers(ListDeviceIdentifiersRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListDeviceIdentifiers operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListDeviceIdentifiers.</param>
        /// 
        /// <returns>Returns a  ListDeviceIdentifiersResult from Private5G.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/privatenetworks-2021-12-03/ListDeviceIdentifiers">REST API Reference for ListDeviceIdentifiers Operation</seealso>
        ListDeviceIdentifiersResponse EndListDeviceIdentifiers(IAsyncResult asyncResult);

        #endregion
        
        #region  ListNetworkResources


        /// <summary>
        /// Lists network resources. Add filters to your request to return a more specific list
        /// of results. Use filters to match the Amazon Resource Name (ARN) of an order or the
        /// status of network resources.
        /// 
        ///  
        /// <para>
        /// If you specify multiple filters, filters are joined with an OR, and the request returns
        /// results that match all of the specified filters.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListNetworkResources service method.</param>
        /// 
        /// <returns>The response from the ListNetworkResources service method, as returned by Private5G.</returns>
        /// <exception cref="Amazon.Private5G.Model.InternalServerException">
        /// Information about an internal error.
        /// </exception>
        /// <exception cref="Amazon.Private5G.Model.ResourceNotFoundException">
        /// The resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Private5G.Model.ValidationException">
        /// The request failed validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/privatenetworks-2021-12-03/ListNetworkResources">REST API Reference for ListNetworkResources Operation</seealso>
        ListNetworkResourcesResponse ListNetworkResources(ListNetworkResourcesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListNetworkResources operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListNetworkResources operation on AmazonPrivate5GClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListNetworkResources
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/privatenetworks-2021-12-03/ListNetworkResources">REST API Reference for ListNetworkResources Operation</seealso>
        IAsyncResult BeginListNetworkResources(ListNetworkResourcesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListNetworkResources operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListNetworkResources.</param>
        /// 
        /// <returns>Returns a  ListNetworkResourcesResult from Private5G.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/privatenetworks-2021-12-03/ListNetworkResources">REST API Reference for ListNetworkResources Operation</seealso>
        ListNetworkResourcesResponse EndListNetworkResources(IAsyncResult asyncResult);

        #endregion
        
        #region  ListNetworks


        /// <summary>
        /// Lists networks. Add filters to your request to return a more specific list of results.
        /// Use filters to match the status of the network.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListNetworks service method.</param>
        /// 
        /// <returns>The response from the ListNetworks service method, as returned by Private5G.</returns>
        /// <exception cref="Amazon.Private5G.Model.InternalServerException">
        /// Information about an internal error.
        /// </exception>
        /// <exception cref="Amazon.Private5G.Model.ResourceNotFoundException">
        /// The resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Private5G.Model.ValidationException">
        /// The request failed validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/privatenetworks-2021-12-03/ListNetworks">REST API Reference for ListNetworks Operation</seealso>
        ListNetworksResponse ListNetworks(ListNetworksRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListNetworks operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListNetworks operation on AmazonPrivate5GClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListNetworks
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/privatenetworks-2021-12-03/ListNetworks">REST API Reference for ListNetworks Operation</seealso>
        IAsyncResult BeginListNetworks(ListNetworksRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListNetworks operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListNetworks.</param>
        /// 
        /// <returns>Returns a  ListNetworksResult from Private5G.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/privatenetworks-2021-12-03/ListNetworks">REST API Reference for ListNetworks Operation</seealso>
        ListNetworksResponse EndListNetworks(IAsyncResult asyncResult);

        #endregion
        
        #region  ListNetworkSites


        /// <summary>
        /// Lists network sites. Add filters to your request to return a more specific list of
        /// results. Use filters to match the status of the network site.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListNetworkSites service method.</param>
        /// 
        /// <returns>The response from the ListNetworkSites service method, as returned by Private5G.</returns>
        /// <exception cref="Amazon.Private5G.Model.InternalServerException">
        /// Information about an internal error.
        /// </exception>
        /// <exception cref="Amazon.Private5G.Model.ResourceNotFoundException">
        /// The resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Private5G.Model.ValidationException">
        /// The request failed validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/privatenetworks-2021-12-03/ListNetworkSites">REST API Reference for ListNetworkSites Operation</seealso>
        ListNetworkSitesResponse ListNetworkSites(ListNetworkSitesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListNetworkSites operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListNetworkSites operation on AmazonPrivate5GClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListNetworkSites
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/privatenetworks-2021-12-03/ListNetworkSites">REST API Reference for ListNetworkSites Operation</seealso>
        IAsyncResult BeginListNetworkSites(ListNetworkSitesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListNetworkSites operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListNetworkSites.</param>
        /// 
        /// <returns>Returns a  ListNetworkSitesResult from Private5G.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/privatenetworks-2021-12-03/ListNetworkSites">REST API Reference for ListNetworkSites Operation</seealso>
        ListNetworkSitesResponse EndListNetworkSites(IAsyncResult asyncResult);

        #endregion
        
        #region  ListOrders


        /// <summary>
        /// Lists orders. Add filters to your request to return a more specific list of results.
        /// Use filters to match the Amazon Resource Name (ARN) of the network site or the status
        /// of the order.
        /// 
        ///  
        /// <para>
        /// If you specify multiple filters, filters are joined with an OR, and the request returns
        /// results that match all of the specified filters.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListOrders service method.</param>
        /// 
        /// <returns>The response from the ListOrders service method, as returned by Private5G.</returns>
        /// <exception cref="Amazon.Private5G.Model.InternalServerException">
        /// Information about an internal error.
        /// </exception>
        /// <exception cref="Amazon.Private5G.Model.ResourceNotFoundException">
        /// The resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Private5G.Model.ValidationException">
        /// The request failed validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/privatenetworks-2021-12-03/ListOrders">REST API Reference for ListOrders Operation</seealso>
        ListOrdersResponse ListOrders(ListOrdersRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListOrders operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListOrders operation on AmazonPrivate5GClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListOrders
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/privatenetworks-2021-12-03/ListOrders">REST API Reference for ListOrders Operation</seealso>
        IAsyncResult BeginListOrders(ListOrdersRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListOrders operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListOrders.</param>
        /// 
        /// <returns>Returns a  ListOrdersResult from Private5G.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/privatenetworks-2021-12-03/ListOrders">REST API Reference for ListOrders Operation</seealso>
        ListOrdersResponse EndListOrders(IAsyncResult asyncResult);

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// Lists the tags for the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by Private5G.</returns>
        /// <exception cref="Amazon.Private5G.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.Private5G.Model.InternalServerException">
        /// Information about an internal error.
        /// </exception>
        /// <exception cref="Amazon.Private5G.Model.ResourceNotFoundException">
        /// The resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Private5G.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Private5G.Model.ValidationException">
        /// The request failed validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/privatenetworks-2021-12-03/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonPrivate5GClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/privatenetworks-2021-12-03/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        IAsyncResult BeginListTagsForResource(ListTagsForResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTagsForResource.</param>
        /// 
        /// <returns>Returns a  ListTagsForResourceResult from Private5G.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/privatenetworks-2021-12-03/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult);

        #endregion
        
        #region  Ping


        /// <summary>
        /// Checks the health of the service.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the Ping service method.</param>
        /// 
        /// <returns>The response from the Ping service method, as returned by Private5G.</returns>
        /// <exception cref="Amazon.Private5G.Model.InternalServerException">
        /// Information about an internal error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/privatenetworks-2021-12-03/Ping">REST API Reference for Ping Operation</seealso>
        PingResponse Ping(PingRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the Ping operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the Ping operation on AmazonPrivate5GClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPing
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/privatenetworks-2021-12-03/Ping">REST API Reference for Ping Operation</seealso>
        IAsyncResult BeginPing(PingRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  Ping operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPing.</param>
        /// 
        /// <returns>Returns a  PingResult from Private5G.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/privatenetworks-2021-12-03/Ping">REST API Reference for Ping Operation</seealso>
        PingResponse EndPing(IAsyncResult asyncResult);

        #endregion
        
        #region  StartNetworkResourceUpdate


        /// <summary>
        /// Starts an update of the specified network resource.
        /// 
        ///  
        /// <para>
        /// After you submit a request to replace or return a network resource, the status of
        /// the network resource is <code>CREATING_SHIPPING_LABEL</code>. The shipping label is
        /// available when the status of the network resource is <code>PENDING_RETURN</code>.
        /// After the network resource is successfully returned, its status is <code>DELETED</code>.
        /// For more information, see <a href="https://docs.aws.amazon.com/private-networks/latest/userguide/radio-units.html#return-radio-unit">Return
        /// a radio unit</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartNetworkResourceUpdate service method.</param>
        /// 
        /// <returns>The response from the StartNetworkResourceUpdate service method, as returned by Private5G.</returns>
        /// <exception cref="Amazon.Private5G.Model.InternalServerException">
        /// Information about an internal error.
        /// </exception>
        /// <exception cref="Amazon.Private5G.Model.ResourceNotFoundException">
        /// The resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Private5G.Model.ValidationException">
        /// The request failed validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/privatenetworks-2021-12-03/StartNetworkResourceUpdate">REST API Reference for StartNetworkResourceUpdate Operation</seealso>
        StartNetworkResourceUpdateResponse StartNetworkResourceUpdate(StartNetworkResourceUpdateRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the StartNetworkResourceUpdate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartNetworkResourceUpdate operation on AmazonPrivate5GClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartNetworkResourceUpdate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/privatenetworks-2021-12-03/StartNetworkResourceUpdate">REST API Reference for StartNetworkResourceUpdate Operation</seealso>
        IAsyncResult BeginStartNetworkResourceUpdate(StartNetworkResourceUpdateRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StartNetworkResourceUpdate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartNetworkResourceUpdate.</param>
        /// 
        /// <returns>Returns a  StartNetworkResourceUpdateResult from Private5G.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/privatenetworks-2021-12-03/StartNetworkResourceUpdate">REST API Reference for StartNetworkResourceUpdate Operation</seealso>
        StartNetworkResourceUpdateResponse EndStartNetworkResourceUpdate(IAsyncResult asyncResult);

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Adds tags to the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by Private5G.</returns>
        /// <exception cref="Amazon.Private5G.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.Private5G.Model.InternalServerException">
        /// Information about an internal error.
        /// </exception>
        /// <exception cref="Amazon.Private5G.Model.ResourceNotFoundException">
        /// The resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Private5G.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Private5G.Model.ValidationException">
        /// The request failed validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/privatenetworks-2021-12-03/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse TagResource(TagResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the TagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonPrivate5GClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/privatenetworks-2021-12-03/TagResource">REST API Reference for TagResource Operation</seealso>
        IAsyncResult BeginTagResource(TagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  TagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTagResource.</param>
        /// 
        /// <returns>Returns a  TagResourceResult from Private5G.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/privatenetworks-2021-12-03/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse EndTagResource(IAsyncResult asyncResult);

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// Removes tags from the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by Private5G.</returns>
        /// <exception cref="Amazon.Private5G.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.Private5G.Model.InternalServerException">
        /// Information about an internal error.
        /// </exception>
        /// <exception cref="Amazon.Private5G.Model.ResourceNotFoundException">
        /// The resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Private5G.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Private5G.Model.ValidationException">
        /// The request failed validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/privatenetworks-2021-12-03/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse UntagResource(UntagResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UntagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonPrivate5GClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/privatenetworks-2021-12-03/UntagResource">REST API Reference for UntagResource Operation</seealso>
        IAsyncResult BeginUntagResource(UntagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UntagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUntagResource.</param>
        /// 
        /// <returns>Returns a  UntagResourceResult from Private5G.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/privatenetworks-2021-12-03/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse EndUntagResource(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateNetworkSite


        /// <summary>
        /// Updates the specified network site.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateNetworkSite service method.</param>
        /// 
        /// <returns>The response from the UpdateNetworkSite service method, as returned by Private5G.</returns>
        /// <exception cref="Amazon.Private5G.Model.InternalServerException">
        /// Information about an internal error.
        /// </exception>
        /// <exception cref="Amazon.Private5G.Model.ResourceNotFoundException">
        /// The resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Private5G.Model.ValidationException">
        /// The request failed validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/privatenetworks-2021-12-03/UpdateNetworkSite">REST API Reference for UpdateNetworkSite Operation</seealso>
        UpdateNetworkSiteResponse UpdateNetworkSite(UpdateNetworkSiteRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateNetworkSite operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateNetworkSite operation on AmazonPrivate5GClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateNetworkSite
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/privatenetworks-2021-12-03/UpdateNetworkSite">REST API Reference for UpdateNetworkSite Operation</seealso>
        IAsyncResult BeginUpdateNetworkSite(UpdateNetworkSiteRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateNetworkSite operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateNetworkSite.</param>
        /// 
        /// <returns>Returns a  UpdateNetworkSiteResult from Private5G.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/privatenetworks-2021-12-03/UpdateNetworkSite">REST API Reference for UpdateNetworkSite Operation</seealso>
        UpdateNetworkSiteResponse EndUpdateNetworkSite(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateNetworkSitePlan


        /// <summary>
        /// Updates the specified network site plan.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateNetworkSitePlan service method.</param>
        /// 
        /// <returns>The response from the UpdateNetworkSitePlan service method, as returned by Private5G.</returns>
        /// <exception cref="Amazon.Private5G.Model.InternalServerException">
        /// Information about an internal error.
        /// </exception>
        /// <exception cref="Amazon.Private5G.Model.ResourceNotFoundException">
        /// The resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Private5G.Model.ValidationException">
        /// The request failed validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/privatenetworks-2021-12-03/UpdateNetworkSitePlan">REST API Reference for UpdateNetworkSitePlan Operation</seealso>
        UpdateNetworkSitePlanResponse UpdateNetworkSitePlan(UpdateNetworkSitePlanRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateNetworkSitePlan operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateNetworkSitePlan operation on AmazonPrivate5GClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateNetworkSitePlan
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/privatenetworks-2021-12-03/UpdateNetworkSitePlan">REST API Reference for UpdateNetworkSitePlan Operation</seealso>
        IAsyncResult BeginUpdateNetworkSitePlan(UpdateNetworkSitePlanRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateNetworkSitePlan operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateNetworkSitePlan.</param>
        /// 
        /// <returns>Returns a  UpdateNetworkSitePlanResult from Private5G.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/privatenetworks-2021-12-03/UpdateNetworkSitePlan">REST API Reference for UpdateNetworkSitePlan Operation</seealso>
        UpdateNetworkSitePlanResponse EndUpdateNetworkSitePlan(IAsyncResult asyncResult);

        #endregion
        
    }
}