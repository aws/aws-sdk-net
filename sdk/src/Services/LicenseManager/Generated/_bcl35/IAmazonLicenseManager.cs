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
 * Do not modify this file. This file is generated from the license-manager-2018-08-01.normal.json service model.
 */


using System;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.LicenseManager.Model;

namespace Amazon.LicenseManager
{
    /// <summary>
    /// Interface for accessing LicenseManager
    ///
    /// License Manager makes it easier to manage licenses from software vendors across multiple
    /// Amazon Web Services accounts and on-premises servers.
    /// </summary>
    public partial interface IAmazonLicenseManager : IAmazonService, IDisposable
    {




        
        #region  AcceptGrant


        /// <summary>
        /// Accepts the specified grant.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AcceptGrant service method.</param>
        /// 
        /// <returns>The response from the AcceptGrant service method, as returned by LicenseManager.</returns>
        /// <exception cref="Amazon.LicenseManager.Model.AccessDeniedException">
        /// Access to resource denied.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.AuthorizationException">
        /// The Amazon Web Services user account does not have permission to perform the action.
        /// Check the IAM policy associated with this account.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.InvalidParameterValueException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.RateLimitExceededException">
        /// Too many requests have been submitted. Try again after a brief wait.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ResourceLimitExceededException">
        /// Your resource limits have been exceeded.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ServerInternalException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ValidationException">
        /// The provided input is not valid. Try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/AcceptGrant">REST API Reference for AcceptGrant Operation</seealso>
        AcceptGrantResponse AcceptGrant(AcceptGrantRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the AcceptGrant operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AcceptGrant operation on AmazonLicenseManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAcceptGrant
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/AcceptGrant">REST API Reference for AcceptGrant Operation</seealso>
        IAsyncResult BeginAcceptGrant(AcceptGrantRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  AcceptGrant operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAcceptGrant.</param>
        /// 
        /// <returns>Returns a  AcceptGrantResult from LicenseManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/AcceptGrant">REST API Reference for AcceptGrant Operation</seealso>
        AcceptGrantResponse EndAcceptGrant(IAsyncResult asyncResult);

        #endregion
        
        #region  CheckInLicense


        /// <summary>
        /// Checks in the specified license. Check in a license when it is no longer in use.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CheckInLicense service method.</param>
        /// 
        /// <returns>The response from the CheckInLicense service method, as returned by LicenseManager.</returns>
        /// <exception cref="Amazon.LicenseManager.Model.AccessDeniedException">
        /// Access to resource denied.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.AuthorizationException">
        /// The Amazon Web Services user account does not have permission to perform the action.
        /// Check the IAM policy associated with this account.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ConflictException">
        /// There was a conflict processing the request. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.InvalidParameterValueException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.RateLimitExceededException">
        /// Too many requests have been submitted. Try again after a brief wait.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ResourceNotFoundException">
        /// The resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ServerInternalException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ValidationException">
        /// The provided input is not valid. Try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/CheckInLicense">REST API Reference for CheckInLicense Operation</seealso>
        CheckInLicenseResponse CheckInLicense(CheckInLicenseRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CheckInLicense operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CheckInLicense operation on AmazonLicenseManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCheckInLicense
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/CheckInLicense">REST API Reference for CheckInLicense Operation</seealso>
        IAsyncResult BeginCheckInLicense(CheckInLicenseRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CheckInLicense operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCheckInLicense.</param>
        /// 
        /// <returns>Returns a  CheckInLicenseResult from LicenseManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/CheckInLicense">REST API Reference for CheckInLicense Operation</seealso>
        CheckInLicenseResponse EndCheckInLicense(IAsyncResult asyncResult);

        #endregion
        
        #region  CheckoutBorrowLicense


        /// <summary>
        /// Checks out the specified license for offline use.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CheckoutBorrowLicense service method.</param>
        /// 
        /// <returns>The response from the CheckoutBorrowLicense service method, as returned by LicenseManager.</returns>
        /// <exception cref="Amazon.LicenseManager.Model.AccessDeniedException">
        /// Access to resource denied.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.AuthorizationException">
        /// The Amazon Web Services user account does not have permission to perform the action.
        /// Check the IAM policy associated with this account.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.EntitlementNotAllowedException">
        /// The entitlement is not allowed.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.InvalidParameterValueException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.NoEntitlementsAllowedException">
        /// There are no entitlements found for this license, or the entitlement maximum count
        /// is reached.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.RateLimitExceededException">
        /// Too many requests have been submitted. Try again after a brief wait.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.RedirectException">
        /// This is not the correct Region for the resource. Try again.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ResourceNotFoundException">
        /// The resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ServerInternalException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.UnsupportedDigitalSignatureMethodException">
        /// The digital signature method is unsupported. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ValidationException">
        /// The provided input is not valid. Try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/CheckoutBorrowLicense">REST API Reference for CheckoutBorrowLicense Operation</seealso>
        CheckoutBorrowLicenseResponse CheckoutBorrowLicense(CheckoutBorrowLicenseRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CheckoutBorrowLicense operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CheckoutBorrowLicense operation on AmazonLicenseManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCheckoutBorrowLicense
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/CheckoutBorrowLicense">REST API Reference for CheckoutBorrowLicense Operation</seealso>
        IAsyncResult BeginCheckoutBorrowLicense(CheckoutBorrowLicenseRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CheckoutBorrowLicense operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCheckoutBorrowLicense.</param>
        /// 
        /// <returns>Returns a  CheckoutBorrowLicenseResult from LicenseManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/CheckoutBorrowLicense">REST API Reference for CheckoutBorrowLicense Operation</seealso>
        CheckoutBorrowLicenseResponse EndCheckoutBorrowLicense(IAsyncResult asyncResult);

        #endregion
        
        #region  CheckoutLicense


        /// <summary>
        /// Checks out the specified license.
        /// 
        ///  <note> 
        /// <para>
        /// If the account that created the license is the same that is performing the check out,
        /// you must specify the account as the beneficiary.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CheckoutLicense service method.</param>
        /// 
        /// <returns>The response from the CheckoutLicense service method, as returned by LicenseManager.</returns>
        /// <exception cref="Amazon.LicenseManager.Model.AccessDeniedException">
        /// Access to resource denied.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.AuthorizationException">
        /// The Amazon Web Services user account does not have permission to perform the action.
        /// Check the IAM policy associated with this account.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.InvalidParameterValueException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.NoEntitlementsAllowedException">
        /// There are no entitlements found for this license, or the entitlement maximum count
        /// is reached.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.RateLimitExceededException">
        /// Too many requests have been submitted. Try again after a brief wait.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.RedirectException">
        /// This is not the correct Region for the resource. Try again.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ResourceNotFoundException">
        /// The resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ServerInternalException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.UnsupportedDigitalSignatureMethodException">
        /// The digital signature method is unsupported. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ValidationException">
        /// The provided input is not valid. Try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/CheckoutLicense">REST API Reference for CheckoutLicense Operation</seealso>
        CheckoutLicenseResponse CheckoutLicense(CheckoutLicenseRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CheckoutLicense operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CheckoutLicense operation on AmazonLicenseManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCheckoutLicense
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/CheckoutLicense">REST API Reference for CheckoutLicense Operation</seealso>
        IAsyncResult BeginCheckoutLicense(CheckoutLicenseRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CheckoutLicense operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCheckoutLicense.</param>
        /// 
        /// <returns>Returns a  CheckoutLicenseResult from LicenseManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/CheckoutLicense">REST API Reference for CheckoutLicense Operation</seealso>
        CheckoutLicenseResponse EndCheckoutLicense(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateGrant


        /// <summary>
        /// Creates a grant for the specified license. A grant shares the use of license entitlements
        /// with a specific Amazon Web Services account, an organization, or an organizational
        /// unit (OU). For more information, see <a href="https://docs.aws.amazon.com/license-manager/latest/userguide/granted-licenses.html">Granted
        /// licenses in License Manager</a> in the <i>License Manager User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateGrant service method.</param>
        /// 
        /// <returns>The response from the CreateGrant service method, as returned by LicenseManager.</returns>
        /// <exception cref="Amazon.LicenseManager.Model.AccessDeniedException">
        /// Access to resource denied.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.AuthorizationException">
        /// The Amazon Web Services user account does not have permission to perform the action.
        /// Check the IAM policy associated with this account.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.InvalidParameterValueException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.RateLimitExceededException">
        /// Too many requests have been submitted. Try again after a brief wait.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ResourceLimitExceededException">
        /// Your resource limits have been exceeded.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ServerInternalException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ValidationException">
        /// The provided input is not valid. Try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/CreateGrant">REST API Reference for CreateGrant Operation</seealso>
        CreateGrantResponse CreateGrant(CreateGrantRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateGrant operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateGrant operation on AmazonLicenseManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateGrant
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/CreateGrant">REST API Reference for CreateGrant Operation</seealso>
        IAsyncResult BeginCreateGrant(CreateGrantRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateGrant operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateGrant.</param>
        /// 
        /// <returns>Returns a  CreateGrantResult from LicenseManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/CreateGrant">REST API Reference for CreateGrant Operation</seealso>
        CreateGrantResponse EndCreateGrant(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateGrantVersion


        /// <summary>
        /// Creates a new version of the specified grant. For more information, see <a href="https://docs.aws.amazon.com/license-manager/latest/userguide/granted-licenses.html">Granted
        /// licenses in License Manager</a> in the <i>License Manager User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateGrantVersion service method.</param>
        /// 
        /// <returns>The response from the CreateGrantVersion service method, as returned by LicenseManager.</returns>
        /// <exception cref="Amazon.LicenseManager.Model.AccessDeniedException">
        /// Access to resource denied.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.AuthorizationException">
        /// The Amazon Web Services user account does not have permission to perform the action.
        /// Check the IAM policy associated with this account.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.InvalidParameterValueException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.RateLimitExceededException">
        /// Too many requests have been submitted. Try again after a brief wait.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ResourceLimitExceededException">
        /// Your resource limits have been exceeded.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ServerInternalException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ValidationException">
        /// The provided input is not valid. Try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/CreateGrantVersion">REST API Reference for CreateGrantVersion Operation</seealso>
        CreateGrantVersionResponse CreateGrantVersion(CreateGrantVersionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateGrantVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateGrantVersion operation on AmazonLicenseManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateGrantVersion
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/CreateGrantVersion">REST API Reference for CreateGrantVersion Operation</seealso>
        IAsyncResult BeginCreateGrantVersion(CreateGrantVersionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateGrantVersion operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateGrantVersion.</param>
        /// 
        /// <returns>Returns a  CreateGrantVersionResult from LicenseManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/CreateGrantVersion">REST API Reference for CreateGrantVersion Operation</seealso>
        CreateGrantVersionResponse EndCreateGrantVersion(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateLicense


        /// <summary>
        /// Creates a license.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateLicense service method.</param>
        /// 
        /// <returns>The response from the CreateLicense service method, as returned by LicenseManager.</returns>
        /// <exception cref="Amazon.LicenseManager.Model.AccessDeniedException">
        /// Access to resource denied.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.AuthorizationException">
        /// The Amazon Web Services user account does not have permission to perform the action.
        /// Check the IAM policy associated with this account.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.InvalidParameterValueException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.RateLimitExceededException">
        /// Too many requests have been submitted. Try again after a brief wait.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.RedirectException">
        /// This is not the correct Region for the resource. Try again.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ServerInternalException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ValidationException">
        /// The provided input is not valid. Try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/CreateLicense">REST API Reference for CreateLicense Operation</seealso>
        CreateLicenseResponse CreateLicense(CreateLicenseRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateLicense operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateLicense operation on AmazonLicenseManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateLicense
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/CreateLicense">REST API Reference for CreateLicense Operation</seealso>
        IAsyncResult BeginCreateLicense(CreateLicenseRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateLicense operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateLicense.</param>
        /// 
        /// <returns>Returns a  CreateLicenseResult from LicenseManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/CreateLicense">REST API Reference for CreateLicense Operation</seealso>
        CreateLicenseResponse EndCreateLicense(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateLicenseConfiguration


        /// <summary>
        /// Creates a license configuration.
        /// 
        ///  
        /// <para>
        /// A license configuration is an abstraction of a customer license agreement that can
        /// be consumed and enforced by License Manager. Components include specifications for
        /// the license type (licensing by instance, socket, CPU, or vCPU), allowed tenancy (shared
        /// tenancy, Dedicated Instance, Dedicated Host, or all of these), license affinity to
        /// host (how long a license must be associated with a host), and the number of licenses
        /// purchased and used.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateLicenseConfiguration service method.</param>
        /// 
        /// <returns>The response from the CreateLicenseConfiguration service method, as returned by LicenseManager.</returns>
        /// <exception cref="Amazon.LicenseManager.Model.AccessDeniedException">
        /// Access to resource denied.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.AuthorizationException">
        /// The Amazon Web Services user account does not have permission to perform the action.
        /// Check the IAM policy associated with this account.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.InvalidParameterValueException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.RateLimitExceededException">
        /// Too many requests have been submitted. Try again after a brief wait.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ResourceLimitExceededException">
        /// Your resource limits have been exceeded.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ServerInternalException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/CreateLicenseConfiguration">REST API Reference for CreateLicenseConfiguration Operation</seealso>
        CreateLicenseConfigurationResponse CreateLicenseConfiguration(CreateLicenseConfigurationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateLicenseConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateLicenseConfiguration operation on AmazonLicenseManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateLicenseConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/CreateLicenseConfiguration">REST API Reference for CreateLicenseConfiguration Operation</seealso>
        IAsyncResult BeginCreateLicenseConfiguration(CreateLicenseConfigurationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateLicenseConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateLicenseConfiguration.</param>
        /// 
        /// <returns>Returns a  CreateLicenseConfigurationResult from LicenseManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/CreateLicenseConfiguration">REST API Reference for CreateLicenseConfiguration Operation</seealso>
        CreateLicenseConfigurationResponse EndCreateLicenseConfiguration(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateLicenseConversionTaskForResource


        /// <summary>
        /// Creates a new license conversion task.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateLicenseConversionTaskForResource service method.</param>
        /// 
        /// <returns>The response from the CreateLicenseConversionTaskForResource service method, as returned by LicenseManager.</returns>
        /// <exception cref="Amazon.LicenseManager.Model.AccessDeniedException">
        /// Access to resource denied.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.AuthorizationException">
        /// The Amazon Web Services user account does not have permission to perform the action.
        /// Check the IAM policy associated with this account.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.InvalidParameterValueException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.RateLimitExceededException">
        /// Too many requests have been submitted. Try again after a brief wait.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ServerInternalException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ValidationException">
        /// The provided input is not valid. Try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/CreateLicenseConversionTaskForResource">REST API Reference for CreateLicenseConversionTaskForResource Operation</seealso>
        CreateLicenseConversionTaskForResourceResponse CreateLicenseConversionTaskForResource(CreateLicenseConversionTaskForResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateLicenseConversionTaskForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateLicenseConversionTaskForResource operation on AmazonLicenseManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateLicenseConversionTaskForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/CreateLicenseConversionTaskForResource">REST API Reference for CreateLicenseConversionTaskForResource Operation</seealso>
        IAsyncResult BeginCreateLicenseConversionTaskForResource(CreateLicenseConversionTaskForResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateLicenseConversionTaskForResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateLicenseConversionTaskForResource.</param>
        /// 
        /// <returns>Returns a  CreateLicenseConversionTaskForResourceResult from LicenseManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/CreateLicenseConversionTaskForResource">REST API Reference for CreateLicenseConversionTaskForResource Operation</seealso>
        CreateLicenseConversionTaskForResourceResponse EndCreateLicenseConversionTaskForResource(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateLicenseManagerReportGenerator


        /// <summary>
        /// Creates a report generator.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateLicenseManagerReportGenerator service method.</param>
        /// 
        /// <returns>The response from the CreateLicenseManagerReportGenerator service method, as returned by LicenseManager.</returns>
        /// <exception cref="Amazon.LicenseManager.Model.AccessDeniedException">
        /// Access to resource denied.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.AuthorizationException">
        /// The Amazon Web Services user account does not have permission to perform the action.
        /// Check the IAM policy associated with this account.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.InvalidParameterValueException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.RateLimitExceededException">
        /// Too many requests have been submitted. Try again after a brief wait.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ResourceLimitExceededException">
        /// Your resource limits have been exceeded.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ResourceNotFoundException">
        /// The resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ServerInternalException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ValidationException">
        /// The provided input is not valid. Try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/CreateLicenseManagerReportGenerator">REST API Reference for CreateLicenseManagerReportGenerator Operation</seealso>
        CreateLicenseManagerReportGeneratorResponse CreateLicenseManagerReportGenerator(CreateLicenseManagerReportGeneratorRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateLicenseManagerReportGenerator operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateLicenseManagerReportGenerator operation on AmazonLicenseManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateLicenseManagerReportGenerator
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/CreateLicenseManagerReportGenerator">REST API Reference for CreateLicenseManagerReportGenerator Operation</seealso>
        IAsyncResult BeginCreateLicenseManagerReportGenerator(CreateLicenseManagerReportGeneratorRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateLicenseManagerReportGenerator operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateLicenseManagerReportGenerator.</param>
        /// 
        /// <returns>Returns a  CreateLicenseManagerReportGeneratorResult from LicenseManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/CreateLicenseManagerReportGenerator">REST API Reference for CreateLicenseManagerReportGenerator Operation</seealso>
        CreateLicenseManagerReportGeneratorResponse EndCreateLicenseManagerReportGenerator(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateLicenseVersion


        /// <summary>
        /// Creates a new version of the specified license.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateLicenseVersion service method.</param>
        /// 
        /// <returns>The response from the CreateLicenseVersion service method, as returned by LicenseManager.</returns>
        /// <exception cref="Amazon.LicenseManager.Model.AccessDeniedException">
        /// Access to resource denied.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.AuthorizationException">
        /// The Amazon Web Services user account does not have permission to perform the action.
        /// Check the IAM policy associated with this account.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ConflictException">
        /// There was a conflict processing the request. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.RateLimitExceededException">
        /// Too many requests have been submitted. Try again after a brief wait.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.RedirectException">
        /// This is not the correct Region for the resource. Try again.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ResourceNotFoundException">
        /// The resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ServerInternalException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ValidationException">
        /// The provided input is not valid. Try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/CreateLicenseVersion">REST API Reference for CreateLicenseVersion Operation</seealso>
        CreateLicenseVersionResponse CreateLicenseVersion(CreateLicenseVersionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateLicenseVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateLicenseVersion operation on AmazonLicenseManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateLicenseVersion
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/CreateLicenseVersion">REST API Reference for CreateLicenseVersion Operation</seealso>
        IAsyncResult BeginCreateLicenseVersion(CreateLicenseVersionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateLicenseVersion operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateLicenseVersion.</param>
        /// 
        /// <returns>Returns a  CreateLicenseVersionResult from LicenseManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/CreateLicenseVersion">REST API Reference for CreateLicenseVersion Operation</seealso>
        CreateLicenseVersionResponse EndCreateLicenseVersion(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateToken


        /// <summary>
        /// Creates a long-lived token.
        /// 
        ///  
        /// <para>
        /// A refresh token is a JWT token used to get an access token. With an access token,
        /// you can call AssumeRoleWithWebIdentity to get role credentials that you can use to
        /// call License Manager to manage the specified license.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateToken service method.</param>
        /// 
        /// <returns>The response from the CreateToken service method, as returned by LicenseManager.</returns>
        /// <exception cref="Amazon.LicenseManager.Model.AccessDeniedException">
        /// Access to resource denied.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.AuthorizationException">
        /// The Amazon Web Services user account does not have permission to perform the action.
        /// Check the IAM policy associated with this account.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.RateLimitExceededException">
        /// Too many requests have been submitted. Try again after a brief wait.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.RedirectException">
        /// This is not the correct Region for the resource. Try again.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ResourceLimitExceededException">
        /// Your resource limits have been exceeded.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ResourceNotFoundException">
        /// The resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ServerInternalException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ValidationException">
        /// The provided input is not valid. Try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/CreateToken">REST API Reference for CreateToken Operation</seealso>
        CreateTokenResponse CreateToken(CreateTokenRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateToken operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateToken operation on AmazonLicenseManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateToken
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/CreateToken">REST API Reference for CreateToken Operation</seealso>
        IAsyncResult BeginCreateToken(CreateTokenRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateToken operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateToken.</param>
        /// 
        /// <returns>Returns a  CreateTokenResult from LicenseManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/CreateToken">REST API Reference for CreateToken Operation</seealso>
        CreateTokenResponse EndCreateToken(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteGrant


        /// <summary>
        /// Deletes the specified grant.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteGrant service method.</param>
        /// 
        /// <returns>The response from the DeleteGrant service method, as returned by LicenseManager.</returns>
        /// <exception cref="Amazon.LicenseManager.Model.AccessDeniedException">
        /// Access to resource denied.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.AuthorizationException">
        /// The Amazon Web Services user account does not have permission to perform the action.
        /// Check the IAM policy associated with this account.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.InvalidParameterValueException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.RateLimitExceededException">
        /// Too many requests have been submitted. Try again after a brief wait.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ResourceLimitExceededException">
        /// Your resource limits have been exceeded.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ServerInternalException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ValidationException">
        /// The provided input is not valid. Try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/DeleteGrant">REST API Reference for DeleteGrant Operation</seealso>
        DeleteGrantResponse DeleteGrant(DeleteGrantRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteGrant operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteGrant operation on AmazonLicenseManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteGrant
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/DeleteGrant">REST API Reference for DeleteGrant Operation</seealso>
        IAsyncResult BeginDeleteGrant(DeleteGrantRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteGrant operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteGrant.</param>
        /// 
        /// <returns>Returns a  DeleteGrantResult from LicenseManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/DeleteGrant">REST API Reference for DeleteGrant Operation</seealso>
        DeleteGrantResponse EndDeleteGrant(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteLicense


        /// <summary>
        /// Deletes the specified license.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteLicense service method.</param>
        /// 
        /// <returns>The response from the DeleteLicense service method, as returned by LicenseManager.</returns>
        /// <exception cref="Amazon.LicenseManager.Model.AccessDeniedException">
        /// Access to resource denied.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.AuthorizationException">
        /// The Amazon Web Services user account does not have permission to perform the action.
        /// Check the IAM policy associated with this account.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ConflictException">
        /// There was a conflict processing the request. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.InvalidParameterValueException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.RateLimitExceededException">
        /// Too many requests have been submitted. Try again after a brief wait.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.RedirectException">
        /// This is not the correct Region for the resource. Try again.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ServerInternalException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ValidationException">
        /// The provided input is not valid. Try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/DeleteLicense">REST API Reference for DeleteLicense Operation</seealso>
        DeleteLicenseResponse DeleteLicense(DeleteLicenseRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteLicense operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteLicense operation on AmazonLicenseManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteLicense
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/DeleteLicense">REST API Reference for DeleteLicense Operation</seealso>
        IAsyncResult BeginDeleteLicense(DeleteLicenseRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteLicense operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteLicense.</param>
        /// 
        /// <returns>Returns a  DeleteLicenseResult from LicenseManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/DeleteLicense">REST API Reference for DeleteLicense Operation</seealso>
        DeleteLicenseResponse EndDeleteLicense(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteLicenseConfiguration


        /// <summary>
        /// Deletes the specified license configuration.
        /// 
        ///  
        /// <para>
        /// You cannot delete a license configuration that is in use.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteLicenseConfiguration service method.</param>
        /// 
        /// <returns>The response from the DeleteLicenseConfiguration service method, as returned by LicenseManager.</returns>
        /// <exception cref="Amazon.LicenseManager.Model.AccessDeniedException">
        /// Access to resource denied.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.AuthorizationException">
        /// The Amazon Web Services user account does not have permission to perform the action.
        /// Check the IAM policy associated with this account.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.InvalidParameterValueException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.RateLimitExceededException">
        /// Too many requests have been submitted. Try again after a brief wait.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ServerInternalException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/DeleteLicenseConfiguration">REST API Reference for DeleteLicenseConfiguration Operation</seealso>
        DeleteLicenseConfigurationResponse DeleteLicenseConfiguration(DeleteLicenseConfigurationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteLicenseConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteLicenseConfiguration operation on AmazonLicenseManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteLicenseConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/DeleteLicenseConfiguration">REST API Reference for DeleteLicenseConfiguration Operation</seealso>
        IAsyncResult BeginDeleteLicenseConfiguration(DeleteLicenseConfigurationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteLicenseConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteLicenseConfiguration.</param>
        /// 
        /// <returns>Returns a  DeleteLicenseConfigurationResult from LicenseManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/DeleteLicenseConfiguration">REST API Reference for DeleteLicenseConfiguration Operation</seealso>
        DeleteLicenseConfigurationResponse EndDeleteLicenseConfiguration(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteLicenseManagerReportGenerator


        /// <summary>
        /// Deletes the specified report generator.
        /// 
        ///  
        /// <para>
        /// This action deletes the report generator, which stops it from generating future reports.
        /// The action cannot be reversed. It has no effect on the previous reports from this
        /// generator.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteLicenseManagerReportGenerator service method.</param>
        /// 
        /// <returns>The response from the DeleteLicenseManagerReportGenerator service method, as returned by LicenseManager.</returns>
        /// <exception cref="Amazon.LicenseManager.Model.AccessDeniedException">
        /// Access to resource denied.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.AuthorizationException">
        /// The Amazon Web Services user account does not have permission to perform the action.
        /// Check the IAM policy associated with this account.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.InvalidParameterValueException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.RateLimitExceededException">
        /// Too many requests have been submitted. Try again after a brief wait.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ResourceLimitExceededException">
        /// Your resource limits have been exceeded.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ResourceNotFoundException">
        /// The resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ServerInternalException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ValidationException">
        /// The provided input is not valid. Try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/DeleteLicenseManagerReportGenerator">REST API Reference for DeleteLicenseManagerReportGenerator Operation</seealso>
        DeleteLicenseManagerReportGeneratorResponse DeleteLicenseManagerReportGenerator(DeleteLicenseManagerReportGeneratorRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteLicenseManagerReportGenerator operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteLicenseManagerReportGenerator operation on AmazonLicenseManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteLicenseManagerReportGenerator
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/DeleteLicenseManagerReportGenerator">REST API Reference for DeleteLicenseManagerReportGenerator Operation</seealso>
        IAsyncResult BeginDeleteLicenseManagerReportGenerator(DeleteLicenseManagerReportGeneratorRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteLicenseManagerReportGenerator operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteLicenseManagerReportGenerator.</param>
        /// 
        /// <returns>Returns a  DeleteLicenseManagerReportGeneratorResult from LicenseManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/DeleteLicenseManagerReportGenerator">REST API Reference for DeleteLicenseManagerReportGenerator Operation</seealso>
        DeleteLicenseManagerReportGeneratorResponse EndDeleteLicenseManagerReportGenerator(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteToken


        /// <summary>
        /// Deletes the specified token. Must be called in the license home Region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteToken service method.</param>
        /// 
        /// <returns>The response from the DeleteToken service method, as returned by LicenseManager.</returns>
        /// <exception cref="Amazon.LicenseManager.Model.AccessDeniedException">
        /// Access to resource denied.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.AuthorizationException">
        /// The Amazon Web Services user account does not have permission to perform the action.
        /// Check the IAM policy associated with this account.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.RateLimitExceededException">
        /// Too many requests have been submitted. Try again after a brief wait.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.RedirectException">
        /// This is not the correct Region for the resource. Try again.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ResourceNotFoundException">
        /// The resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ServerInternalException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ValidationException">
        /// The provided input is not valid. Try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/DeleteToken">REST API Reference for DeleteToken Operation</seealso>
        DeleteTokenResponse DeleteToken(DeleteTokenRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteToken operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteToken operation on AmazonLicenseManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteToken
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/DeleteToken">REST API Reference for DeleteToken Operation</seealso>
        IAsyncResult BeginDeleteToken(DeleteTokenRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteToken operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteToken.</param>
        /// 
        /// <returns>Returns a  DeleteTokenResult from LicenseManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/DeleteToken">REST API Reference for DeleteToken Operation</seealso>
        DeleteTokenResponse EndDeleteToken(IAsyncResult asyncResult);

        #endregion
        
        #region  ExtendLicenseConsumption


        /// <summary>
        /// Extends the expiration date for license consumption.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ExtendLicenseConsumption service method.</param>
        /// 
        /// <returns>The response from the ExtendLicenseConsumption service method, as returned by LicenseManager.</returns>
        /// <exception cref="Amazon.LicenseManager.Model.AccessDeniedException">
        /// Access to resource denied.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.AuthorizationException">
        /// The Amazon Web Services user account does not have permission to perform the action.
        /// Check the IAM policy associated with this account.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.InvalidParameterValueException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.RateLimitExceededException">
        /// Too many requests have been submitted. Try again after a brief wait.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ResourceNotFoundException">
        /// The resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ServerInternalException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ValidationException">
        /// The provided input is not valid. Try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/ExtendLicenseConsumption">REST API Reference for ExtendLicenseConsumption Operation</seealso>
        ExtendLicenseConsumptionResponse ExtendLicenseConsumption(ExtendLicenseConsumptionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ExtendLicenseConsumption operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ExtendLicenseConsumption operation on AmazonLicenseManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndExtendLicenseConsumption
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/ExtendLicenseConsumption">REST API Reference for ExtendLicenseConsumption Operation</seealso>
        IAsyncResult BeginExtendLicenseConsumption(ExtendLicenseConsumptionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ExtendLicenseConsumption operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginExtendLicenseConsumption.</param>
        /// 
        /// <returns>Returns a  ExtendLicenseConsumptionResult from LicenseManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/ExtendLicenseConsumption">REST API Reference for ExtendLicenseConsumption Operation</seealso>
        ExtendLicenseConsumptionResponse EndExtendLicenseConsumption(IAsyncResult asyncResult);

        #endregion
        
        #region  GetAccessToken


        /// <summary>
        /// Gets a temporary access token to use with AssumeRoleWithWebIdentity. Access tokens
        /// are valid for one hour.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAccessToken service method.</param>
        /// 
        /// <returns>The response from the GetAccessToken service method, as returned by LicenseManager.</returns>
        /// <exception cref="Amazon.LicenseManager.Model.AccessDeniedException">
        /// Access to resource denied.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.AuthorizationException">
        /// The Amazon Web Services user account does not have permission to perform the action.
        /// Check the IAM policy associated with this account.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.RateLimitExceededException">
        /// Too many requests have been submitted. Try again after a brief wait.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ServerInternalException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ValidationException">
        /// The provided input is not valid. Try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/GetAccessToken">REST API Reference for GetAccessToken Operation</seealso>
        GetAccessTokenResponse GetAccessToken(GetAccessTokenRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetAccessToken operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetAccessToken operation on AmazonLicenseManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetAccessToken
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/GetAccessToken">REST API Reference for GetAccessToken Operation</seealso>
        IAsyncResult BeginGetAccessToken(GetAccessTokenRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetAccessToken operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetAccessToken.</param>
        /// 
        /// <returns>Returns a  GetAccessTokenResult from LicenseManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/GetAccessToken">REST API Reference for GetAccessToken Operation</seealso>
        GetAccessTokenResponse EndGetAccessToken(IAsyncResult asyncResult);

        #endregion
        
        #region  GetGrant


        /// <summary>
        /// Gets detailed information about the specified grant.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetGrant service method.</param>
        /// 
        /// <returns>The response from the GetGrant service method, as returned by LicenseManager.</returns>
        /// <exception cref="Amazon.LicenseManager.Model.AccessDeniedException">
        /// Access to resource denied.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.AuthorizationException">
        /// The Amazon Web Services user account does not have permission to perform the action.
        /// Check the IAM policy associated with this account.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.InvalidParameterValueException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.RateLimitExceededException">
        /// Too many requests have been submitted. Try again after a brief wait.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ResourceLimitExceededException">
        /// Your resource limits have been exceeded.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ServerInternalException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ValidationException">
        /// The provided input is not valid. Try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/GetGrant">REST API Reference for GetGrant Operation</seealso>
        GetGrantResponse GetGrant(GetGrantRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetGrant operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetGrant operation on AmazonLicenseManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetGrant
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/GetGrant">REST API Reference for GetGrant Operation</seealso>
        IAsyncResult BeginGetGrant(GetGrantRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetGrant operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetGrant.</param>
        /// 
        /// <returns>Returns a  GetGrantResult from LicenseManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/GetGrant">REST API Reference for GetGrant Operation</seealso>
        GetGrantResponse EndGetGrant(IAsyncResult asyncResult);

        #endregion
        
        #region  GetLicense


        /// <summary>
        /// Gets detailed information about the specified license.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetLicense service method.</param>
        /// 
        /// <returns>The response from the GetLicense service method, as returned by LicenseManager.</returns>
        /// <exception cref="Amazon.LicenseManager.Model.AccessDeniedException">
        /// Access to resource denied.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.AuthorizationException">
        /// The Amazon Web Services user account does not have permission to perform the action.
        /// Check the IAM policy associated with this account.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.InvalidParameterValueException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.RateLimitExceededException">
        /// Too many requests have been submitted. Try again after a brief wait.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ServerInternalException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ValidationException">
        /// The provided input is not valid. Try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/GetLicense">REST API Reference for GetLicense Operation</seealso>
        GetLicenseResponse GetLicense(GetLicenseRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetLicense operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetLicense operation on AmazonLicenseManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetLicense
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/GetLicense">REST API Reference for GetLicense Operation</seealso>
        IAsyncResult BeginGetLicense(GetLicenseRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetLicense operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetLicense.</param>
        /// 
        /// <returns>Returns a  GetLicenseResult from LicenseManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/GetLicense">REST API Reference for GetLicense Operation</seealso>
        GetLicenseResponse EndGetLicense(IAsyncResult asyncResult);

        #endregion
        
        #region  GetLicenseConfiguration


        /// <summary>
        /// Gets detailed information about the specified license configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetLicenseConfiguration service method.</param>
        /// 
        /// <returns>The response from the GetLicenseConfiguration service method, as returned by LicenseManager.</returns>
        /// <exception cref="Amazon.LicenseManager.Model.AccessDeniedException">
        /// Access to resource denied.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.AuthorizationException">
        /// The Amazon Web Services user account does not have permission to perform the action.
        /// Check the IAM policy associated with this account.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.InvalidParameterValueException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.RateLimitExceededException">
        /// Too many requests have been submitted. Try again after a brief wait.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ServerInternalException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/GetLicenseConfiguration">REST API Reference for GetLicenseConfiguration Operation</seealso>
        GetLicenseConfigurationResponse GetLicenseConfiguration(GetLicenseConfigurationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetLicenseConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetLicenseConfiguration operation on AmazonLicenseManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetLicenseConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/GetLicenseConfiguration">REST API Reference for GetLicenseConfiguration Operation</seealso>
        IAsyncResult BeginGetLicenseConfiguration(GetLicenseConfigurationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetLicenseConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetLicenseConfiguration.</param>
        /// 
        /// <returns>Returns a  GetLicenseConfigurationResult from LicenseManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/GetLicenseConfiguration">REST API Reference for GetLicenseConfiguration Operation</seealso>
        GetLicenseConfigurationResponse EndGetLicenseConfiguration(IAsyncResult asyncResult);

        #endregion
        
        #region  GetLicenseConversionTask


        /// <summary>
        /// Gets information about the specified license type conversion task.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetLicenseConversionTask service method.</param>
        /// 
        /// <returns>The response from the GetLicenseConversionTask service method, as returned by LicenseManager.</returns>
        /// <exception cref="Amazon.LicenseManager.Model.AccessDeniedException">
        /// Access to resource denied.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.AuthorizationException">
        /// The Amazon Web Services user account does not have permission to perform the action.
        /// Check the IAM policy associated with this account.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.InvalidParameterValueException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.RateLimitExceededException">
        /// Too many requests have been submitted. Try again after a brief wait.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ServerInternalException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/GetLicenseConversionTask">REST API Reference for GetLicenseConversionTask Operation</seealso>
        GetLicenseConversionTaskResponse GetLicenseConversionTask(GetLicenseConversionTaskRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetLicenseConversionTask operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetLicenseConversionTask operation on AmazonLicenseManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetLicenseConversionTask
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/GetLicenseConversionTask">REST API Reference for GetLicenseConversionTask Operation</seealso>
        IAsyncResult BeginGetLicenseConversionTask(GetLicenseConversionTaskRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetLicenseConversionTask operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetLicenseConversionTask.</param>
        /// 
        /// <returns>Returns a  GetLicenseConversionTaskResult from LicenseManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/GetLicenseConversionTask">REST API Reference for GetLicenseConversionTask Operation</seealso>
        GetLicenseConversionTaskResponse EndGetLicenseConversionTask(IAsyncResult asyncResult);

        #endregion
        
        #region  GetLicenseManagerReportGenerator


        /// <summary>
        /// Gets information about the specified report generator.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetLicenseManagerReportGenerator service method.</param>
        /// 
        /// <returns>The response from the GetLicenseManagerReportGenerator service method, as returned by LicenseManager.</returns>
        /// <exception cref="Amazon.LicenseManager.Model.AccessDeniedException">
        /// Access to resource denied.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.AuthorizationException">
        /// The Amazon Web Services user account does not have permission to perform the action.
        /// Check the IAM policy associated with this account.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.InvalidParameterValueException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.RateLimitExceededException">
        /// Too many requests have been submitted. Try again after a brief wait.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ResourceLimitExceededException">
        /// Your resource limits have been exceeded.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ResourceNotFoundException">
        /// The resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ServerInternalException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ValidationException">
        /// The provided input is not valid. Try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/GetLicenseManagerReportGenerator">REST API Reference for GetLicenseManagerReportGenerator Operation</seealso>
        GetLicenseManagerReportGeneratorResponse GetLicenseManagerReportGenerator(GetLicenseManagerReportGeneratorRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetLicenseManagerReportGenerator operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetLicenseManagerReportGenerator operation on AmazonLicenseManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetLicenseManagerReportGenerator
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/GetLicenseManagerReportGenerator">REST API Reference for GetLicenseManagerReportGenerator Operation</seealso>
        IAsyncResult BeginGetLicenseManagerReportGenerator(GetLicenseManagerReportGeneratorRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetLicenseManagerReportGenerator operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetLicenseManagerReportGenerator.</param>
        /// 
        /// <returns>Returns a  GetLicenseManagerReportGeneratorResult from LicenseManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/GetLicenseManagerReportGenerator">REST API Reference for GetLicenseManagerReportGenerator Operation</seealso>
        GetLicenseManagerReportGeneratorResponse EndGetLicenseManagerReportGenerator(IAsyncResult asyncResult);

        #endregion
        
        #region  GetLicenseUsage


        /// <summary>
        /// Gets detailed information about the usage of the specified license.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetLicenseUsage service method.</param>
        /// 
        /// <returns>The response from the GetLicenseUsage service method, as returned by LicenseManager.</returns>
        /// <exception cref="Amazon.LicenseManager.Model.AccessDeniedException">
        /// Access to resource denied.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.AuthorizationException">
        /// The Amazon Web Services user account does not have permission to perform the action.
        /// Check the IAM policy associated with this account.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.InvalidParameterValueException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.RateLimitExceededException">
        /// Too many requests have been submitted. Try again after a brief wait.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ServerInternalException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ValidationException">
        /// The provided input is not valid. Try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/GetLicenseUsage">REST API Reference for GetLicenseUsage Operation</seealso>
        GetLicenseUsageResponse GetLicenseUsage(GetLicenseUsageRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetLicenseUsage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetLicenseUsage operation on AmazonLicenseManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetLicenseUsage
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/GetLicenseUsage">REST API Reference for GetLicenseUsage Operation</seealso>
        IAsyncResult BeginGetLicenseUsage(GetLicenseUsageRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetLicenseUsage operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetLicenseUsage.</param>
        /// 
        /// <returns>Returns a  GetLicenseUsageResult from LicenseManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/GetLicenseUsage">REST API Reference for GetLicenseUsage Operation</seealso>
        GetLicenseUsageResponse EndGetLicenseUsage(IAsyncResult asyncResult);

        #endregion
        
        #region  GetServiceSettings


        /// <summary>
        /// Gets the License Manager settings for the current Region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetServiceSettings service method.</param>
        /// 
        /// <returns>The response from the GetServiceSettings service method, as returned by LicenseManager.</returns>
        /// <exception cref="Amazon.LicenseManager.Model.AccessDeniedException">
        /// Access to resource denied.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.AuthorizationException">
        /// The Amazon Web Services user account does not have permission to perform the action.
        /// Check the IAM policy associated with this account.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.RateLimitExceededException">
        /// Too many requests have been submitted. Try again after a brief wait.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ServerInternalException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/GetServiceSettings">REST API Reference for GetServiceSettings Operation</seealso>
        GetServiceSettingsResponse GetServiceSettings(GetServiceSettingsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetServiceSettings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetServiceSettings operation on AmazonLicenseManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetServiceSettings
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/GetServiceSettings">REST API Reference for GetServiceSettings Operation</seealso>
        IAsyncResult BeginGetServiceSettings(GetServiceSettingsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetServiceSettings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetServiceSettings.</param>
        /// 
        /// <returns>Returns a  GetServiceSettingsResult from LicenseManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/GetServiceSettings">REST API Reference for GetServiceSettings Operation</seealso>
        GetServiceSettingsResponse EndGetServiceSettings(IAsyncResult asyncResult);

        #endregion
        
        #region  ListAssociationsForLicenseConfiguration


        /// <summary>
        /// Lists the resource associations for the specified license configuration.
        /// 
        ///  
        /// <para>
        /// Resource associations need not consume licenses from a license configuration. For
        /// example, an AMI or a stopped instance might not consume a license (depending on the
        /// license rules).
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAssociationsForLicenseConfiguration service method.</param>
        /// 
        /// <returns>The response from the ListAssociationsForLicenseConfiguration service method, as returned by LicenseManager.</returns>
        /// <exception cref="Amazon.LicenseManager.Model.AccessDeniedException">
        /// Access to resource denied.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.AuthorizationException">
        /// The Amazon Web Services user account does not have permission to perform the action.
        /// Check the IAM policy associated with this account.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.FilterLimitExceededException">
        /// The request uses too many filters or too many filter values.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.InvalidParameterValueException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.RateLimitExceededException">
        /// Too many requests have been submitted. Try again after a brief wait.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ServerInternalException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/ListAssociationsForLicenseConfiguration">REST API Reference for ListAssociationsForLicenseConfiguration Operation</seealso>
        ListAssociationsForLicenseConfigurationResponse ListAssociationsForLicenseConfiguration(ListAssociationsForLicenseConfigurationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListAssociationsForLicenseConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAssociationsForLicenseConfiguration operation on AmazonLicenseManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAssociationsForLicenseConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/ListAssociationsForLicenseConfiguration">REST API Reference for ListAssociationsForLicenseConfiguration Operation</seealso>
        IAsyncResult BeginListAssociationsForLicenseConfiguration(ListAssociationsForLicenseConfigurationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListAssociationsForLicenseConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAssociationsForLicenseConfiguration.</param>
        /// 
        /// <returns>Returns a  ListAssociationsForLicenseConfigurationResult from LicenseManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/ListAssociationsForLicenseConfiguration">REST API Reference for ListAssociationsForLicenseConfiguration Operation</seealso>
        ListAssociationsForLicenseConfigurationResponse EndListAssociationsForLicenseConfiguration(IAsyncResult asyncResult);

        #endregion
        
        #region  ListDistributedGrants


        /// <summary>
        /// Lists the grants distributed for the specified license.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDistributedGrants service method.</param>
        /// 
        /// <returns>The response from the ListDistributedGrants service method, as returned by LicenseManager.</returns>
        /// <exception cref="Amazon.LicenseManager.Model.AccessDeniedException">
        /// Access to resource denied.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.AuthorizationException">
        /// The Amazon Web Services user account does not have permission to perform the action.
        /// Check the IAM policy associated with this account.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.InvalidParameterValueException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.RateLimitExceededException">
        /// Too many requests have been submitted. Try again after a brief wait.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ResourceLimitExceededException">
        /// Your resource limits have been exceeded.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ServerInternalException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ValidationException">
        /// The provided input is not valid. Try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/ListDistributedGrants">REST API Reference for ListDistributedGrants Operation</seealso>
        ListDistributedGrantsResponse ListDistributedGrants(ListDistributedGrantsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListDistributedGrants operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDistributedGrants operation on AmazonLicenseManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListDistributedGrants
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/ListDistributedGrants">REST API Reference for ListDistributedGrants Operation</seealso>
        IAsyncResult BeginListDistributedGrants(ListDistributedGrantsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListDistributedGrants operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListDistributedGrants.</param>
        /// 
        /// <returns>Returns a  ListDistributedGrantsResult from LicenseManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/ListDistributedGrants">REST API Reference for ListDistributedGrants Operation</seealso>
        ListDistributedGrantsResponse EndListDistributedGrants(IAsyncResult asyncResult);

        #endregion
        
        #region  ListFailuresForLicenseConfigurationOperations


        /// <summary>
        /// Lists the license configuration operations that failed.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFailuresForLicenseConfigurationOperations service method.</param>
        /// 
        /// <returns>The response from the ListFailuresForLicenseConfigurationOperations service method, as returned by LicenseManager.</returns>
        /// <exception cref="Amazon.LicenseManager.Model.AccessDeniedException">
        /// Access to resource denied.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.AuthorizationException">
        /// The Amazon Web Services user account does not have permission to perform the action.
        /// Check the IAM policy associated with this account.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.InvalidParameterValueException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.RateLimitExceededException">
        /// Too many requests have been submitted. Try again after a brief wait.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ServerInternalException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/ListFailuresForLicenseConfigurationOperations">REST API Reference for ListFailuresForLicenseConfigurationOperations Operation</seealso>
        ListFailuresForLicenseConfigurationOperationsResponse ListFailuresForLicenseConfigurationOperations(ListFailuresForLicenseConfigurationOperationsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListFailuresForLicenseConfigurationOperations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListFailuresForLicenseConfigurationOperations operation on AmazonLicenseManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListFailuresForLicenseConfigurationOperations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/ListFailuresForLicenseConfigurationOperations">REST API Reference for ListFailuresForLicenseConfigurationOperations Operation</seealso>
        IAsyncResult BeginListFailuresForLicenseConfigurationOperations(ListFailuresForLicenseConfigurationOperationsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListFailuresForLicenseConfigurationOperations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListFailuresForLicenseConfigurationOperations.</param>
        /// 
        /// <returns>Returns a  ListFailuresForLicenseConfigurationOperationsResult from LicenseManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/ListFailuresForLicenseConfigurationOperations">REST API Reference for ListFailuresForLicenseConfigurationOperations Operation</seealso>
        ListFailuresForLicenseConfigurationOperationsResponse EndListFailuresForLicenseConfigurationOperations(IAsyncResult asyncResult);

        #endregion
        
        #region  ListLicenseConfigurations


        /// <summary>
        /// Lists the license configurations for your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListLicenseConfigurations service method.</param>
        /// 
        /// <returns>The response from the ListLicenseConfigurations service method, as returned by LicenseManager.</returns>
        /// <exception cref="Amazon.LicenseManager.Model.AccessDeniedException">
        /// Access to resource denied.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.AuthorizationException">
        /// The Amazon Web Services user account does not have permission to perform the action.
        /// Check the IAM policy associated with this account.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.FilterLimitExceededException">
        /// The request uses too many filters or too many filter values.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.InvalidParameterValueException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.RateLimitExceededException">
        /// Too many requests have been submitted. Try again after a brief wait.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ServerInternalException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/ListLicenseConfigurations">REST API Reference for ListLicenseConfigurations Operation</seealso>
        ListLicenseConfigurationsResponse ListLicenseConfigurations(ListLicenseConfigurationsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListLicenseConfigurations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListLicenseConfigurations operation on AmazonLicenseManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListLicenseConfigurations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/ListLicenseConfigurations">REST API Reference for ListLicenseConfigurations Operation</seealso>
        IAsyncResult BeginListLicenseConfigurations(ListLicenseConfigurationsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListLicenseConfigurations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListLicenseConfigurations.</param>
        /// 
        /// <returns>Returns a  ListLicenseConfigurationsResult from LicenseManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/ListLicenseConfigurations">REST API Reference for ListLicenseConfigurations Operation</seealso>
        ListLicenseConfigurationsResponse EndListLicenseConfigurations(IAsyncResult asyncResult);

        #endregion
        
        #region  ListLicenseConversionTasks


        /// <summary>
        /// Lists the license type conversion tasks for your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListLicenseConversionTasks service method.</param>
        /// 
        /// <returns>The response from the ListLicenseConversionTasks service method, as returned by LicenseManager.</returns>
        /// <exception cref="Amazon.LicenseManager.Model.AccessDeniedException">
        /// Access to resource denied.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.AuthorizationException">
        /// The Amazon Web Services user account does not have permission to perform the action.
        /// Check the IAM policy associated with this account.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.InvalidParameterValueException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.RateLimitExceededException">
        /// Too many requests have been submitted. Try again after a brief wait.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ServerInternalException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/ListLicenseConversionTasks">REST API Reference for ListLicenseConversionTasks Operation</seealso>
        ListLicenseConversionTasksResponse ListLicenseConversionTasks(ListLicenseConversionTasksRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListLicenseConversionTasks operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListLicenseConversionTasks operation on AmazonLicenseManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListLicenseConversionTasks
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/ListLicenseConversionTasks">REST API Reference for ListLicenseConversionTasks Operation</seealso>
        IAsyncResult BeginListLicenseConversionTasks(ListLicenseConversionTasksRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListLicenseConversionTasks operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListLicenseConversionTasks.</param>
        /// 
        /// <returns>Returns a  ListLicenseConversionTasksResult from LicenseManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/ListLicenseConversionTasks">REST API Reference for ListLicenseConversionTasks Operation</seealso>
        ListLicenseConversionTasksResponse EndListLicenseConversionTasks(IAsyncResult asyncResult);

        #endregion
        
        #region  ListLicenseManagerReportGenerators


        /// <summary>
        /// Lists the report generators for your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListLicenseManagerReportGenerators service method.</param>
        /// 
        /// <returns>The response from the ListLicenseManagerReportGenerators service method, as returned by LicenseManager.</returns>
        /// <exception cref="Amazon.LicenseManager.Model.AccessDeniedException">
        /// Access to resource denied.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.AuthorizationException">
        /// The Amazon Web Services user account does not have permission to perform the action.
        /// Check the IAM policy associated with this account.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.InvalidParameterValueException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.RateLimitExceededException">
        /// Too many requests have been submitted. Try again after a brief wait.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ResourceLimitExceededException">
        /// Your resource limits have been exceeded.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ResourceNotFoundException">
        /// The resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ServerInternalException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ValidationException">
        /// The provided input is not valid. Try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/ListLicenseManagerReportGenerators">REST API Reference for ListLicenseManagerReportGenerators Operation</seealso>
        ListLicenseManagerReportGeneratorsResponse ListLicenseManagerReportGenerators(ListLicenseManagerReportGeneratorsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListLicenseManagerReportGenerators operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListLicenseManagerReportGenerators operation on AmazonLicenseManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListLicenseManagerReportGenerators
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/ListLicenseManagerReportGenerators">REST API Reference for ListLicenseManagerReportGenerators Operation</seealso>
        IAsyncResult BeginListLicenseManagerReportGenerators(ListLicenseManagerReportGeneratorsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListLicenseManagerReportGenerators operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListLicenseManagerReportGenerators.</param>
        /// 
        /// <returns>Returns a  ListLicenseManagerReportGeneratorsResult from LicenseManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/ListLicenseManagerReportGenerators">REST API Reference for ListLicenseManagerReportGenerators Operation</seealso>
        ListLicenseManagerReportGeneratorsResponse EndListLicenseManagerReportGenerators(IAsyncResult asyncResult);

        #endregion
        
        #region  ListLicenses


        /// <summary>
        /// Lists the licenses for your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListLicenses service method.</param>
        /// 
        /// <returns>The response from the ListLicenses service method, as returned by LicenseManager.</returns>
        /// <exception cref="Amazon.LicenseManager.Model.AccessDeniedException">
        /// Access to resource denied.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.AuthorizationException">
        /// The Amazon Web Services user account does not have permission to perform the action.
        /// Check the IAM policy associated with this account.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.InvalidParameterValueException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.RateLimitExceededException">
        /// Too many requests have been submitted. Try again after a brief wait.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ServerInternalException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ValidationException">
        /// The provided input is not valid. Try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/ListLicenses">REST API Reference for ListLicenses Operation</seealso>
        ListLicensesResponse ListLicenses(ListLicensesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListLicenses operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListLicenses operation on AmazonLicenseManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListLicenses
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/ListLicenses">REST API Reference for ListLicenses Operation</seealso>
        IAsyncResult BeginListLicenses(ListLicensesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListLicenses operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListLicenses.</param>
        /// 
        /// <returns>Returns a  ListLicensesResult from LicenseManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/ListLicenses">REST API Reference for ListLicenses Operation</seealso>
        ListLicensesResponse EndListLicenses(IAsyncResult asyncResult);

        #endregion
        
        #region  ListLicenseSpecificationsForResource


        /// <summary>
        /// Describes the license configurations for the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListLicenseSpecificationsForResource service method.</param>
        /// 
        /// <returns>The response from the ListLicenseSpecificationsForResource service method, as returned by LicenseManager.</returns>
        /// <exception cref="Amazon.LicenseManager.Model.AccessDeniedException">
        /// Access to resource denied.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.AuthorizationException">
        /// The Amazon Web Services user account does not have permission to perform the action.
        /// Check the IAM policy associated with this account.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.InvalidParameterValueException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.RateLimitExceededException">
        /// Too many requests have been submitted. Try again after a brief wait.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ServerInternalException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/ListLicenseSpecificationsForResource">REST API Reference for ListLicenseSpecificationsForResource Operation</seealso>
        ListLicenseSpecificationsForResourceResponse ListLicenseSpecificationsForResource(ListLicenseSpecificationsForResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListLicenseSpecificationsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListLicenseSpecificationsForResource operation on AmazonLicenseManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListLicenseSpecificationsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/ListLicenseSpecificationsForResource">REST API Reference for ListLicenseSpecificationsForResource Operation</seealso>
        IAsyncResult BeginListLicenseSpecificationsForResource(ListLicenseSpecificationsForResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListLicenseSpecificationsForResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListLicenseSpecificationsForResource.</param>
        /// 
        /// <returns>Returns a  ListLicenseSpecificationsForResourceResult from LicenseManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/ListLicenseSpecificationsForResource">REST API Reference for ListLicenseSpecificationsForResource Operation</seealso>
        ListLicenseSpecificationsForResourceResponse EndListLicenseSpecificationsForResource(IAsyncResult asyncResult);

        #endregion
        
        #region  ListLicenseVersions


        /// <summary>
        /// Lists all versions of the specified license.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListLicenseVersions service method.</param>
        /// 
        /// <returns>The response from the ListLicenseVersions service method, as returned by LicenseManager.</returns>
        /// <exception cref="Amazon.LicenseManager.Model.AccessDeniedException">
        /// Access to resource denied.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.AuthorizationException">
        /// The Amazon Web Services user account does not have permission to perform the action.
        /// Check the IAM policy associated with this account.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.InvalidParameterValueException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.RateLimitExceededException">
        /// Too many requests have been submitted. Try again after a brief wait.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ServerInternalException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/ListLicenseVersions">REST API Reference for ListLicenseVersions Operation</seealso>
        ListLicenseVersionsResponse ListLicenseVersions(ListLicenseVersionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListLicenseVersions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListLicenseVersions operation on AmazonLicenseManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListLicenseVersions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/ListLicenseVersions">REST API Reference for ListLicenseVersions Operation</seealso>
        IAsyncResult BeginListLicenseVersions(ListLicenseVersionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListLicenseVersions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListLicenseVersions.</param>
        /// 
        /// <returns>Returns a  ListLicenseVersionsResult from LicenseManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/ListLicenseVersions">REST API Reference for ListLicenseVersions Operation</seealso>
        ListLicenseVersionsResponse EndListLicenseVersions(IAsyncResult asyncResult);

        #endregion
        
        #region  ListReceivedGrants


        /// <summary>
        /// Lists grants that are received. Received grants are grants created while specifying
        /// the recipient as this Amazon Web Services account, your organization, or an organizational
        /// unit (OU) to which this member account belongs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListReceivedGrants service method.</param>
        /// 
        /// <returns>The response from the ListReceivedGrants service method, as returned by LicenseManager.</returns>
        /// <exception cref="Amazon.LicenseManager.Model.AccessDeniedException">
        /// Access to resource denied.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.AuthorizationException">
        /// The Amazon Web Services user account does not have permission to perform the action.
        /// Check the IAM policy associated with this account.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.InvalidParameterValueException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.RateLimitExceededException">
        /// Too many requests have been submitted. Try again after a brief wait.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ResourceLimitExceededException">
        /// Your resource limits have been exceeded.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ServerInternalException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ValidationException">
        /// The provided input is not valid. Try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/ListReceivedGrants">REST API Reference for ListReceivedGrants Operation</seealso>
        ListReceivedGrantsResponse ListReceivedGrants(ListReceivedGrantsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListReceivedGrants operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListReceivedGrants operation on AmazonLicenseManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListReceivedGrants
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/ListReceivedGrants">REST API Reference for ListReceivedGrants Operation</seealso>
        IAsyncResult BeginListReceivedGrants(ListReceivedGrantsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListReceivedGrants operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListReceivedGrants.</param>
        /// 
        /// <returns>Returns a  ListReceivedGrantsResult from LicenseManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/ListReceivedGrants">REST API Reference for ListReceivedGrants Operation</seealso>
        ListReceivedGrantsResponse EndListReceivedGrants(IAsyncResult asyncResult);

        #endregion
        
        #region  ListReceivedGrantsForOrganization


        /// <summary>
        /// Lists the grants received for all accounts in the organization.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListReceivedGrantsForOrganization service method.</param>
        /// 
        /// <returns>The response from the ListReceivedGrantsForOrganization service method, as returned by LicenseManager.</returns>
        /// <exception cref="Amazon.LicenseManager.Model.AccessDeniedException">
        /// Access to resource denied.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.AuthorizationException">
        /// The Amazon Web Services user account does not have permission to perform the action.
        /// Check the IAM policy associated with this account.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.InvalidParameterValueException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.RateLimitExceededException">
        /// Too many requests have been submitted. Try again after a brief wait.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ResourceLimitExceededException">
        /// Your resource limits have been exceeded.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ServerInternalException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ValidationException">
        /// The provided input is not valid. Try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/ListReceivedGrantsForOrganization">REST API Reference for ListReceivedGrantsForOrganization Operation</seealso>
        ListReceivedGrantsForOrganizationResponse ListReceivedGrantsForOrganization(ListReceivedGrantsForOrganizationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListReceivedGrantsForOrganization operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListReceivedGrantsForOrganization operation on AmazonLicenseManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListReceivedGrantsForOrganization
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/ListReceivedGrantsForOrganization">REST API Reference for ListReceivedGrantsForOrganization Operation</seealso>
        IAsyncResult BeginListReceivedGrantsForOrganization(ListReceivedGrantsForOrganizationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListReceivedGrantsForOrganization operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListReceivedGrantsForOrganization.</param>
        /// 
        /// <returns>Returns a  ListReceivedGrantsForOrganizationResult from LicenseManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/ListReceivedGrantsForOrganization">REST API Reference for ListReceivedGrantsForOrganization Operation</seealso>
        ListReceivedGrantsForOrganizationResponse EndListReceivedGrantsForOrganization(IAsyncResult asyncResult);

        #endregion
        
        #region  ListReceivedLicenses


        /// <summary>
        /// Lists received licenses.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListReceivedLicenses service method.</param>
        /// 
        /// <returns>The response from the ListReceivedLicenses service method, as returned by LicenseManager.</returns>
        /// <exception cref="Amazon.LicenseManager.Model.AccessDeniedException">
        /// Access to resource denied.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.AuthorizationException">
        /// The Amazon Web Services user account does not have permission to perform the action.
        /// Check the IAM policy associated with this account.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.InvalidParameterValueException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.RateLimitExceededException">
        /// Too many requests have been submitted. Try again after a brief wait.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ResourceLimitExceededException">
        /// Your resource limits have been exceeded.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ServerInternalException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ValidationException">
        /// The provided input is not valid. Try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/ListReceivedLicenses">REST API Reference for ListReceivedLicenses Operation</seealso>
        ListReceivedLicensesResponse ListReceivedLicenses(ListReceivedLicensesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListReceivedLicenses operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListReceivedLicenses operation on AmazonLicenseManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListReceivedLicenses
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/ListReceivedLicenses">REST API Reference for ListReceivedLicenses Operation</seealso>
        IAsyncResult BeginListReceivedLicenses(ListReceivedLicensesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListReceivedLicenses operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListReceivedLicenses.</param>
        /// 
        /// <returns>Returns a  ListReceivedLicensesResult from LicenseManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/ListReceivedLicenses">REST API Reference for ListReceivedLicenses Operation</seealso>
        ListReceivedLicensesResponse EndListReceivedLicenses(IAsyncResult asyncResult);

        #endregion
        
        #region  ListReceivedLicensesForOrganization


        /// <summary>
        /// Lists the licenses received for all accounts in the organization.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListReceivedLicensesForOrganization service method.</param>
        /// 
        /// <returns>The response from the ListReceivedLicensesForOrganization service method, as returned by LicenseManager.</returns>
        /// <exception cref="Amazon.LicenseManager.Model.AccessDeniedException">
        /// Access to resource denied.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.AuthorizationException">
        /// The Amazon Web Services user account does not have permission to perform the action.
        /// Check the IAM policy associated with this account.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.InvalidParameterValueException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.RateLimitExceededException">
        /// Too many requests have been submitted. Try again after a brief wait.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ResourceLimitExceededException">
        /// Your resource limits have been exceeded.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ServerInternalException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ValidationException">
        /// The provided input is not valid. Try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/ListReceivedLicensesForOrganization">REST API Reference for ListReceivedLicensesForOrganization Operation</seealso>
        ListReceivedLicensesForOrganizationResponse ListReceivedLicensesForOrganization(ListReceivedLicensesForOrganizationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListReceivedLicensesForOrganization operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListReceivedLicensesForOrganization operation on AmazonLicenseManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListReceivedLicensesForOrganization
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/ListReceivedLicensesForOrganization">REST API Reference for ListReceivedLicensesForOrganization Operation</seealso>
        IAsyncResult BeginListReceivedLicensesForOrganization(ListReceivedLicensesForOrganizationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListReceivedLicensesForOrganization operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListReceivedLicensesForOrganization.</param>
        /// 
        /// <returns>Returns a  ListReceivedLicensesForOrganizationResult from LicenseManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/ListReceivedLicensesForOrganization">REST API Reference for ListReceivedLicensesForOrganization Operation</seealso>
        ListReceivedLicensesForOrganizationResponse EndListReceivedLicensesForOrganization(IAsyncResult asyncResult);

        #endregion
        
        #region  ListResourceInventory


        /// <summary>
        /// Lists resources managed using Systems Manager inventory.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListResourceInventory service method.</param>
        /// 
        /// <returns>The response from the ListResourceInventory service method, as returned by LicenseManager.</returns>
        /// <exception cref="Amazon.LicenseManager.Model.AccessDeniedException">
        /// Access to resource denied.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.AuthorizationException">
        /// The Amazon Web Services user account does not have permission to perform the action.
        /// Check the IAM policy associated with this account.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.FailedDependencyException">
        /// A dependency required to run the API is missing.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.FilterLimitExceededException">
        /// The request uses too many filters or too many filter values.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.InvalidParameterValueException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.RateLimitExceededException">
        /// Too many requests have been submitted. Try again after a brief wait.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ServerInternalException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/ListResourceInventory">REST API Reference for ListResourceInventory Operation</seealso>
        ListResourceInventoryResponse ListResourceInventory(ListResourceInventoryRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListResourceInventory operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListResourceInventory operation on AmazonLicenseManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListResourceInventory
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/ListResourceInventory">REST API Reference for ListResourceInventory Operation</seealso>
        IAsyncResult BeginListResourceInventory(ListResourceInventoryRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListResourceInventory operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListResourceInventory.</param>
        /// 
        /// <returns>Returns a  ListResourceInventoryResult from LicenseManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/ListResourceInventory">REST API Reference for ListResourceInventory Operation</seealso>
        ListResourceInventoryResponse EndListResourceInventory(IAsyncResult asyncResult);

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// Lists the tags for the specified license configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by LicenseManager.</returns>
        /// <exception cref="Amazon.LicenseManager.Model.AccessDeniedException">
        /// Access to resource denied.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.AuthorizationException">
        /// The Amazon Web Services user account does not have permission to perform the action.
        /// Check the IAM policy associated with this account.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.InvalidParameterValueException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.RateLimitExceededException">
        /// Too many requests have been submitted. Try again after a brief wait.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ServerInternalException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonLicenseManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        IAsyncResult BeginListTagsForResource(ListTagsForResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTagsForResource.</param>
        /// 
        /// <returns>Returns a  ListTagsForResourceResult from LicenseManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult);

        #endregion
        
        #region  ListTokens


        /// <summary>
        /// Lists your tokens.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTokens service method.</param>
        /// 
        /// <returns>The response from the ListTokens service method, as returned by LicenseManager.</returns>
        /// <exception cref="Amazon.LicenseManager.Model.AccessDeniedException">
        /// Access to resource denied.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.AuthorizationException">
        /// The Amazon Web Services user account does not have permission to perform the action.
        /// Check the IAM policy associated with this account.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.RateLimitExceededException">
        /// Too many requests have been submitted. Try again after a brief wait.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ServerInternalException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ValidationException">
        /// The provided input is not valid. Try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/ListTokens">REST API Reference for ListTokens Operation</seealso>
        ListTokensResponse ListTokens(ListTokensRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListTokens operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTokens operation on AmazonLicenseManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTokens
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/ListTokens">REST API Reference for ListTokens Operation</seealso>
        IAsyncResult BeginListTokens(ListTokensRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTokens operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTokens.</param>
        /// 
        /// <returns>Returns a  ListTokensResult from LicenseManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/ListTokens">REST API Reference for ListTokens Operation</seealso>
        ListTokensResponse EndListTokens(IAsyncResult asyncResult);

        #endregion
        
        #region  ListUsageForLicenseConfiguration


        /// <summary>
        /// Lists all license usage records for a license configuration, displaying license consumption
        /// details by resource at a selected point in time. Use this action to audit the current
        /// license consumption for any license inventory and configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListUsageForLicenseConfiguration service method.</param>
        /// 
        /// <returns>The response from the ListUsageForLicenseConfiguration service method, as returned by LicenseManager.</returns>
        /// <exception cref="Amazon.LicenseManager.Model.AccessDeniedException">
        /// Access to resource denied.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.AuthorizationException">
        /// The Amazon Web Services user account does not have permission to perform the action.
        /// Check the IAM policy associated with this account.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.FilterLimitExceededException">
        /// The request uses too many filters or too many filter values.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.InvalidParameterValueException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.RateLimitExceededException">
        /// Too many requests have been submitted. Try again after a brief wait.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ServerInternalException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/ListUsageForLicenseConfiguration">REST API Reference for ListUsageForLicenseConfiguration Operation</seealso>
        ListUsageForLicenseConfigurationResponse ListUsageForLicenseConfiguration(ListUsageForLicenseConfigurationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListUsageForLicenseConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListUsageForLicenseConfiguration operation on AmazonLicenseManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListUsageForLicenseConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/ListUsageForLicenseConfiguration">REST API Reference for ListUsageForLicenseConfiguration Operation</seealso>
        IAsyncResult BeginListUsageForLicenseConfiguration(ListUsageForLicenseConfigurationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListUsageForLicenseConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListUsageForLicenseConfiguration.</param>
        /// 
        /// <returns>Returns a  ListUsageForLicenseConfigurationResult from LicenseManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/ListUsageForLicenseConfiguration">REST API Reference for ListUsageForLicenseConfiguration Operation</seealso>
        ListUsageForLicenseConfigurationResponse EndListUsageForLicenseConfiguration(IAsyncResult asyncResult);

        #endregion
        
        #region  RejectGrant


        /// <summary>
        /// Rejects the specified grant.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RejectGrant service method.</param>
        /// 
        /// <returns>The response from the RejectGrant service method, as returned by LicenseManager.</returns>
        /// <exception cref="Amazon.LicenseManager.Model.AccessDeniedException">
        /// Access to resource denied.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.AuthorizationException">
        /// The Amazon Web Services user account does not have permission to perform the action.
        /// Check the IAM policy associated with this account.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.InvalidParameterValueException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.RateLimitExceededException">
        /// Too many requests have been submitted. Try again after a brief wait.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ResourceLimitExceededException">
        /// Your resource limits have been exceeded.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ServerInternalException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ValidationException">
        /// The provided input is not valid. Try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/RejectGrant">REST API Reference for RejectGrant Operation</seealso>
        RejectGrantResponse RejectGrant(RejectGrantRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the RejectGrant operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RejectGrant operation on AmazonLicenseManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRejectGrant
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/RejectGrant">REST API Reference for RejectGrant Operation</seealso>
        IAsyncResult BeginRejectGrant(RejectGrantRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  RejectGrant operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRejectGrant.</param>
        /// 
        /// <returns>Returns a  RejectGrantResult from LicenseManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/RejectGrant">REST API Reference for RejectGrant Operation</seealso>
        RejectGrantResponse EndRejectGrant(IAsyncResult asyncResult);

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Adds the specified tags to the specified license configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by LicenseManager.</returns>
        /// <exception cref="Amazon.LicenseManager.Model.AccessDeniedException">
        /// Access to resource denied.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.AuthorizationException">
        /// The Amazon Web Services user account does not have permission to perform the action.
        /// Check the IAM policy associated with this account.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.InvalidParameterValueException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.RateLimitExceededException">
        /// Too many requests have been submitted. Try again after a brief wait.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ServerInternalException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse TagResource(TagResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the TagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonLicenseManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/TagResource">REST API Reference for TagResource Operation</seealso>
        IAsyncResult BeginTagResource(TagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  TagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTagResource.</param>
        /// 
        /// <returns>Returns a  TagResourceResult from LicenseManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse EndTagResource(IAsyncResult asyncResult);

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// Removes the specified tags from the specified license configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by LicenseManager.</returns>
        /// <exception cref="Amazon.LicenseManager.Model.AccessDeniedException">
        /// Access to resource denied.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.AuthorizationException">
        /// The Amazon Web Services user account does not have permission to perform the action.
        /// Check the IAM policy associated with this account.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.InvalidParameterValueException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.RateLimitExceededException">
        /// Too many requests have been submitted. Try again after a brief wait.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ServerInternalException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse UntagResource(UntagResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UntagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonLicenseManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/UntagResource">REST API Reference for UntagResource Operation</seealso>
        IAsyncResult BeginUntagResource(UntagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UntagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUntagResource.</param>
        /// 
        /// <returns>Returns a  UntagResourceResult from LicenseManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse EndUntagResource(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateLicenseConfiguration


        /// <summary>
        /// Modifies the attributes of an existing license configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateLicenseConfiguration service method.</param>
        /// 
        /// <returns>The response from the UpdateLicenseConfiguration service method, as returned by LicenseManager.</returns>
        /// <exception cref="Amazon.LicenseManager.Model.AccessDeniedException">
        /// Access to resource denied.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.AuthorizationException">
        /// The Amazon Web Services user account does not have permission to perform the action.
        /// Check the IAM policy associated with this account.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.InvalidParameterValueException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.RateLimitExceededException">
        /// Too many requests have been submitted. Try again after a brief wait.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ResourceLimitExceededException">
        /// Your resource limits have been exceeded.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ServerInternalException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/UpdateLicenseConfiguration">REST API Reference for UpdateLicenseConfiguration Operation</seealso>
        UpdateLicenseConfigurationResponse UpdateLicenseConfiguration(UpdateLicenseConfigurationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateLicenseConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateLicenseConfiguration operation on AmazonLicenseManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateLicenseConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/UpdateLicenseConfiguration">REST API Reference for UpdateLicenseConfiguration Operation</seealso>
        IAsyncResult BeginUpdateLicenseConfiguration(UpdateLicenseConfigurationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateLicenseConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateLicenseConfiguration.</param>
        /// 
        /// <returns>Returns a  UpdateLicenseConfigurationResult from LicenseManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/UpdateLicenseConfiguration">REST API Reference for UpdateLicenseConfiguration Operation</seealso>
        UpdateLicenseConfigurationResponse EndUpdateLicenseConfiguration(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateLicenseManagerReportGenerator


        /// <summary>
        /// Updates a report generator.
        /// 
        ///  
        /// <para>
        /// After you make changes to a report generator, it starts generating new reports within
        /// 60 minutes of being updated.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateLicenseManagerReportGenerator service method.</param>
        /// 
        /// <returns>The response from the UpdateLicenseManagerReportGenerator service method, as returned by LicenseManager.</returns>
        /// <exception cref="Amazon.LicenseManager.Model.AccessDeniedException">
        /// Access to resource denied.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.AuthorizationException">
        /// The Amazon Web Services user account does not have permission to perform the action.
        /// Check the IAM policy associated with this account.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.InvalidParameterValueException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.RateLimitExceededException">
        /// Too many requests have been submitted. Try again after a brief wait.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ResourceLimitExceededException">
        /// Your resource limits have been exceeded.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ResourceNotFoundException">
        /// The resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ServerInternalException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ValidationException">
        /// The provided input is not valid. Try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/UpdateLicenseManagerReportGenerator">REST API Reference for UpdateLicenseManagerReportGenerator Operation</seealso>
        UpdateLicenseManagerReportGeneratorResponse UpdateLicenseManagerReportGenerator(UpdateLicenseManagerReportGeneratorRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateLicenseManagerReportGenerator operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateLicenseManagerReportGenerator operation on AmazonLicenseManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateLicenseManagerReportGenerator
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/UpdateLicenseManagerReportGenerator">REST API Reference for UpdateLicenseManagerReportGenerator Operation</seealso>
        IAsyncResult BeginUpdateLicenseManagerReportGenerator(UpdateLicenseManagerReportGeneratorRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateLicenseManagerReportGenerator operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateLicenseManagerReportGenerator.</param>
        /// 
        /// <returns>Returns a  UpdateLicenseManagerReportGeneratorResult from LicenseManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/UpdateLicenseManagerReportGenerator">REST API Reference for UpdateLicenseManagerReportGenerator Operation</seealso>
        UpdateLicenseManagerReportGeneratorResponse EndUpdateLicenseManagerReportGenerator(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateLicenseSpecificationsForResource


        /// <summary>
        /// Adds or removes the specified license configurations for the specified Amazon Web
        /// Services resource.
        /// 
        ///  
        /// <para>
        /// You can update the license specifications of AMIs, instances, and hosts. You cannot
        /// update the license specifications for launch templates and CloudFormation templates,
        /// as they send license configurations to the operation that creates the resource.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateLicenseSpecificationsForResource service method.</param>
        /// 
        /// <returns>The response from the UpdateLicenseSpecificationsForResource service method, as returned by LicenseManager.</returns>
        /// <exception cref="Amazon.LicenseManager.Model.AccessDeniedException">
        /// Access to resource denied.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.AuthorizationException">
        /// The Amazon Web Services user account does not have permission to perform the action.
        /// Check the IAM policy associated with this account.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.InvalidParameterValueException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.InvalidResourceStateException">
        /// License Manager cannot allocate a license to a resource because of its state. 
        /// 
        ///  
        /// <para>
        /// For example, you cannot allocate a license to an instance in the process of shutting
        /// down.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.LicenseUsageException">
        /// You do not have enough licenses available to support a new resource launch.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.RateLimitExceededException">
        /// Too many requests have been submitted. Try again after a brief wait.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ServerInternalException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/UpdateLicenseSpecificationsForResource">REST API Reference for UpdateLicenseSpecificationsForResource Operation</seealso>
        UpdateLicenseSpecificationsForResourceResponse UpdateLicenseSpecificationsForResource(UpdateLicenseSpecificationsForResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateLicenseSpecificationsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateLicenseSpecificationsForResource operation on AmazonLicenseManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateLicenseSpecificationsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/UpdateLicenseSpecificationsForResource">REST API Reference for UpdateLicenseSpecificationsForResource Operation</seealso>
        IAsyncResult BeginUpdateLicenseSpecificationsForResource(UpdateLicenseSpecificationsForResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateLicenseSpecificationsForResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateLicenseSpecificationsForResource.</param>
        /// 
        /// <returns>Returns a  UpdateLicenseSpecificationsForResourceResult from LicenseManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/UpdateLicenseSpecificationsForResource">REST API Reference for UpdateLicenseSpecificationsForResource Operation</seealso>
        UpdateLicenseSpecificationsForResourceResponse EndUpdateLicenseSpecificationsForResource(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateServiceSettings


        /// <summary>
        /// Updates License Manager settings for the current Region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateServiceSettings service method.</param>
        /// 
        /// <returns>The response from the UpdateServiceSettings service method, as returned by LicenseManager.</returns>
        /// <exception cref="Amazon.LicenseManager.Model.AccessDeniedException">
        /// Access to resource denied.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.AuthorizationException">
        /// The Amazon Web Services user account does not have permission to perform the action.
        /// Check the IAM policy associated with this account.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.InvalidParameterValueException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.RateLimitExceededException">
        /// Too many requests have been submitted. Try again after a brief wait.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ServerInternalException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/UpdateServiceSettings">REST API Reference for UpdateServiceSettings Operation</seealso>
        UpdateServiceSettingsResponse UpdateServiceSettings(UpdateServiceSettingsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateServiceSettings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateServiceSettings operation on AmazonLicenseManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateServiceSettings
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/UpdateServiceSettings">REST API Reference for UpdateServiceSettings Operation</seealso>
        IAsyncResult BeginUpdateServiceSettings(UpdateServiceSettingsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateServiceSettings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateServiceSettings.</param>
        /// 
        /// <returns>Returns a  UpdateServiceSettingsResult from LicenseManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/UpdateServiceSettings">REST API Reference for UpdateServiceSettings Operation</seealso>
        UpdateServiceSettingsResponse EndUpdateServiceSettings(IAsyncResult asyncResult);

        #endregion
        
    }
}