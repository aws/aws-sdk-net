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
 * Do not modify this file. This file is generated from the rolesanywhere-2018-05-10.normal.json service model.
 */


using System;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.IAMRolesAnywhere.Model;

namespace Amazon.IAMRolesAnywhere
{
    /// <summary>
    /// Interface for accessing IAMRolesAnywhere
    ///
    /// AWS Identity and Access Management Roles Anywhere provides a secure way for your workloads
    /// such as servers, containers, and applications running outside of AWS to obtain Temporary
    /// AWS credentials. Your workloads can use the same IAM policies and roles that you have
    /// configured with native AWS applications to access AWS resources. Using IAM Roles Anywhere
    /// will eliminate the need to manage long term credentials for workloads running outside
    /// of AWS.
    /// 
    ///  
    /// <para>
    /// To use IAM Roles Anywhere customer workloads will need to use X.509 certificates issued
    /// by their Certificate Authority (CA) . The Certificate Authority (CA) needs to be registered
    /// with IAM Roles Anywhere as a trust anchor to establish trust between customer PKI
    /// and IAM Roles Anywhere. Customers who do not manage their own PKI system can use AWS
    /// Certificate Manager Private Certificate Authority (ACM PCA) to create a Certificate
    /// Authority and use that to establish trust with IAM Roles Anywhere
    /// </para>
    ///  
    /// <para>
    /// This guide describes the IAM rolesanywhere operations that you can call programmatically.
    /// For general information about IAM Roles Anywhere see <a href="https://docs.aws.amazon.com/">https://docs.aws.amazon.com/</a>
    /// 
    /// </para>
    /// </summary>
    public partial interface IAmazonIAMRolesAnywhere : IAmazonService, IDisposable
    {


#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        IIAMRolesAnywherePaginatorFactory Paginators { get; }
#endif


        
        #region  CreateProfile


        /// <summary>
        /// Creates a profile. A profile is configuration resource to list the roles that RolesAnywhere
        /// service is trusted to assume. In addition, by applying a profile you can intersect
        /// permissions with IAM managed policies.
        /// 
        ///  
        /// <para>
        ///  <b>Required permissions: </b> <code>rolesanywhere:CreateProfile</code>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateProfile service method.</param>
        /// 
        /// <returns>The response from the CreateProfile service method, as returned by IAMRolesAnywhere.</returns>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.ValidationException">
        /// Validation exception error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rolesanywhere-2018-05-10/CreateProfile">REST API Reference for CreateProfile Operation</seealso>
        CreateProfileResponse CreateProfile(CreateProfileRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateProfile operation on AmazonIAMRolesAnywhereClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateProfile
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rolesanywhere-2018-05-10/CreateProfile">REST API Reference for CreateProfile Operation</seealso>
        IAsyncResult BeginCreateProfile(CreateProfileRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateProfile operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateProfile.</param>
        /// 
        /// <returns>Returns a  CreateProfileResult from IAMRolesAnywhere.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rolesanywhere-2018-05-10/CreateProfile">REST API Reference for CreateProfile Operation</seealso>
        CreateProfileResponse EndCreateProfile(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateTrustAnchor


        /// <summary>
        /// Creates a trust anchor. You establish trust between IAM Roles Anywhere and your certificate
        /// authority (CA) by configuring a trust anchor. A Trust Anchor is defined either as
        /// a reference to a AWS Certificate Manager Private Certificate Authority (ACM PCA),
        /// or by uploading a Certificate Authority (CA) certificate. Your AWS workloads can authenticate
        /// with the trust anchor using certificates issued by the trusted Certificate Authority
        /// (CA) in exchange for temporary AWS credentials.
        /// 
        ///  
        /// <para>
        ///  <b>Required permissions: </b> <code>rolesanywhere:CreateTrustAnchor</code>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTrustAnchor service method.</param>
        /// 
        /// <returns>The response from the CreateTrustAnchor service method, as returned by IAMRolesAnywhere.</returns>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.ValidationException">
        /// Validation exception error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rolesanywhere-2018-05-10/CreateTrustAnchor">REST API Reference for CreateTrustAnchor Operation</seealso>
        CreateTrustAnchorResponse CreateTrustAnchor(CreateTrustAnchorRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateTrustAnchor operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateTrustAnchor operation on AmazonIAMRolesAnywhereClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateTrustAnchor
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rolesanywhere-2018-05-10/CreateTrustAnchor">REST API Reference for CreateTrustAnchor Operation</seealso>
        IAsyncResult BeginCreateTrustAnchor(CreateTrustAnchorRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateTrustAnchor operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateTrustAnchor.</param>
        /// 
        /// <returns>Returns a  CreateTrustAnchorResult from IAMRolesAnywhere.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rolesanywhere-2018-05-10/CreateTrustAnchor">REST API Reference for CreateTrustAnchor Operation</seealso>
        CreateTrustAnchorResponse EndCreateTrustAnchor(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteCrl


        /// <summary>
        /// Deletes a certificate revocation list (CRL).
        /// 
        ///  
        /// <para>
        ///  <b>Required permissions: </b> <code>rolesanywhere:DeleteCrl</code>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCrl service method.</param>
        /// 
        /// <returns>The response from the DeleteCrl service method, as returned by IAMRolesAnywhere.</returns>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rolesanywhere-2018-05-10/DeleteCrl">REST API Reference for DeleteCrl Operation</seealso>
        DeleteCrlResponse DeleteCrl(DeleteCrlRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteCrl operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteCrl operation on AmazonIAMRolesAnywhereClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteCrl
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rolesanywhere-2018-05-10/DeleteCrl">REST API Reference for DeleteCrl Operation</seealso>
        IAsyncResult BeginDeleteCrl(DeleteCrlRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteCrl operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteCrl.</param>
        /// 
        /// <returns>Returns a  DeleteCrlResult from IAMRolesAnywhere.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rolesanywhere-2018-05-10/DeleteCrl">REST API Reference for DeleteCrl Operation</seealso>
        DeleteCrlResponse EndDeleteCrl(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteProfile


        /// <summary>
        /// Deletes a profile.
        /// 
        ///  
        /// <para>
        ///  <b>Required permissions: </b> <code>rolesanywhere:DeleteProfile</code>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteProfile service method.</param>
        /// 
        /// <returns>The response from the DeleteProfile service method, as returned by IAMRolesAnywhere.</returns>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rolesanywhere-2018-05-10/DeleteProfile">REST API Reference for DeleteProfile Operation</seealso>
        DeleteProfileResponse DeleteProfile(DeleteProfileRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteProfile operation on AmazonIAMRolesAnywhereClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteProfile
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rolesanywhere-2018-05-10/DeleteProfile">REST API Reference for DeleteProfile Operation</seealso>
        IAsyncResult BeginDeleteProfile(DeleteProfileRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteProfile operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteProfile.</param>
        /// 
        /// <returns>Returns a  DeleteProfileResult from IAMRolesAnywhere.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rolesanywhere-2018-05-10/DeleteProfile">REST API Reference for DeleteProfile Operation</seealso>
        DeleteProfileResponse EndDeleteProfile(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteTrustAnchor


        /// <summary>
        /// Deletes a trust anchor.
        /// 
        ///  
        /// <para>
        ///  <b>Required permissions: </b> <code>rolesanywhere:DeleteTrustAnchor</code>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTrustAnchor service method.</param>
        /// 
        /// <returns>The response from the DeleteTrustAnchor service method, as returned by IAMRolesAnywhere.</returns>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rolesanywhere-2018-05-10/DeleteTrustAnchor">REST API Reference for DeleteTrustAnchor Operation</seealso>
        DeleteTrustAnchorResponse DeleteTrustAnchor(DeleteTrustAnchorRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteTrustAnchor operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteTrustAnchor operation on AmazonIAMRolesAnywhereClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteTrustAnchor
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rolesanywhere-2018-05-10/DeleteTrustAnchor">REST API Reference for DeleteTrustAnchor Operation</seealso>
        IAsyncResult BeginDeleteTrustAnchor(DeleteTrustAnchorRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteTrustAnchor operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteTrustAnchor.</param>
        /// 
        /// <returns>Returns a  DeleteTrustAnchorResult from IAMRolesAnywhere.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rolesanywhere-2018-05-10/DeleteTrustAnchor">REST API Reference for DeleteTrustAnchor Operation</seealso>
        DeleteTrustAnchorResponse EndDeleteTrustAnchor(IAsyncResult asyncResult);

        #endregion
        
        #region  DisableCrl


        /// <summary>
        /// Disables a certificate revocation list (CRL).
        /// 
        ///  
        /// <para>
        ///  <b>Required permissions: </b> <code>rolesanywhere:DisableCrl</code>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisableCrl service method.</param>
        /// 
        /// <returns>The response from the DisableCrl service method, as returned by IAMRolesAnywhere.</returns>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rolesanywhere-2018-05-10/DisableCrl">REST API Reference for DisableCrl Operation</seealso>
        DisableCrlResponse DisableCrl(DisableCrlRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DisableCrl operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisableCrl operation on AmazonIAMRolesAnywhereClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisableCrl
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rolesanywhere-2018-05-10/DisableCrl">REST API Reference for DisableCrl Operation</seealso>
        IAsyncResult BeginDisableCrl(DisableCrlRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DisableCrl operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisableCrl.</param>
        /// 
        /// <returns>Returns a  DisableCrlResult from IAMRolesAnywhere.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rolesanywhere-2018-05-10/DisableCrl">REST API Reference for DisableCrl Operation</seealso>
        DisableCrlResponse EndDisableCrl(IAsyncResult asyncResult);

        #endregion
        
        #region  DisableProfile


        /// <summary>
        /// Disables a profile. When disabled, <a href="https://docs.aws.amazon.com/rolesanywhere/latest/APIReference/API_CreateSession.html">CreateSession</a>
        /// requests with this profile fail.
        /// 
        ///  
        /// <para>
        ///  <b>Required permissions: </b> <code>rolesanywhere:DisableProfile</code>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisableProfile service method.</param>
        /// 
        /// <returns>The response from the DisableProfile service method, as returned by IAMRolesAnywhere.</returns>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rolesanywhere-2018-05-10/DisableProfile">REST API Reference for DisableProfile Operation</seealso>
        DisableProfileResponse DisableProfile(DisableProfileRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DisableProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisableProfile operation on AmazonIAMRolesAnywhereClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisableProfile
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rolesanywhere-2018-05-10/DisableProfile">REST API Reference for DisableProfile Operation</seealso>
        IAsyncResult BeginDisableProfile(DisableProfileRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DisableProfile operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisableProfile.</param>
        /// 
        /// <returns>Returns a  DisableProfileResult from IAMRolesAnywhere.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rolesanywhere-2018-05-10/DisableProfile">REST API Reference for DisableProfile Operation</seealso>
        DisableProfileResponse EndDisableProfile(IAsyncResult asyncResult);

        #endregion
        
        #region  DisableTrustAnchor


        /// <summary>
        /// Disables a trust anchor. When disabled, <a href="https://docs.aws.amazon.com/rolesanywhere/latest/APIReference/API_CreateSession.html">CreateSession</a>
        /// requests specifying this trust anchor are unauthorized.
        /// 
        ///  
        /// <para>
        ///  <b>Required permissions: </b> <code>rolesanywhere:DisableTrustAnchor</code>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisableTrustAnchor service method.</param>
        /// 
        /// <returns>The response from the DisableTrustAnchor service method, as returned by IAMRolesAnywhere.</returns>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rolesanywhere-2018-05-10/DisableTrustAnchor">REST API Reference for DisableTrustAnchor Operation</seealso>
        DisableTrustAnchorResponse DisableTrustAnchor(DisableTrustAnchorRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DisableTrustAnchor operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisableTrustAnchor operation on AmazonIAMRolesAnywhereClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisableTrustAnchor
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rolesanywhere-2018-05-10/DisableTrustAnchor">REST API Reference for DisableTrustAnchor Operation</seealso>
        IAsyncResult BeginDisableTrustAnchor(DisableTrustAnchorRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DisableTrustAnchor operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisableTrustAnchor.</param>
        /// 
        /// <returns>Returns a  DisableTrustAnchorResult from IAMRolesAnywhere.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rolesanywhere-2018-05-10/DisableTrustAnchor">REST API Reference for DisableTrustAnchor Operation</seealso>
        DisableTrustAnchorResponse EndDisableTrustAnchor(IAsyncResult asyncResult);

        #endregion
        
        #region  EnableCrl


        /// <summary>
        /// Enables a certificate revocation list (CRL). When enabled, certificates stored in
        /// the CRL are unauthorized to receive session credentials.
        /// 
        ///  
        /// <para>
        ///  <b>Required permissions: </b> <code>rolesanywhere:EnableCrl</code>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EnableCrl service method.</param>
        /// 
        /// <returns>The response from the EnableCrl service method, as returned by IAMRolesAnywhere.</returns>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rolesanywhere-2018-05-10/EnableCrl">REST API Reference for EnableCrl Operation</seealso>
        EnableCrlResponse EnableCrl(EnableCrlRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the EnableCrl operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the EnableCrl operation on AmazonIAMRolesAnywhereClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndEnableCrl
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rolesanywhere-2018-05-10/EnableCrl">REST API Reference for EnableCrl Operation</seealso>
        IAsyncResult BeginEnableCrl(EnableCrlRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  EnableCrl operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginEnableCrl.</param>
        /// 
        /// <returns>Returns a  EnableCrlResult from IAMRolesAnywhere.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rolesanywhere-2018-05-10/EnableCrl">REST API Reference for EnableCrl Operation</seealso>
        EnableCrlResponse EndEnableCrl(IAsyncResult asyncResult);

        #endregion
        
        #region  EnableProfile


        /// <summary>
        /// Enables the roles in a profile to receive session credentials in <a href="https://docs.aws.amazon.com/rolesanywhere/latest/APIReference/API_CreateSession.html">CreateSession</a>.
        /// 
        /// 
        ///  
        /// <para>
        ///  <b>Required permissions: </b> <code>rolesanywhere:EnableProfile</code>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EnableProfile service method.</param>
        /// 
        /// <returns>The response from the EnableProfile service method, as returned by IAMRolesAnywhere.</returns>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rolesanywhere-2018-05-10/EnableProfile">REST API Reference for EnableProfile Operation</seealso>
        EnableProfileResponse EnableProfile(EnableProfileRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the EnableProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the EnableProfile operation on AmazonIAMRolesAnywhereClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndEnableProfile
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rolesanywhere-2018-05-10/EnableProfile">REST API Reference for EnableProfile Operation</seealso>
        IAsyncResult BeginEnableProfile(EnableProfileRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  EnableProfile operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginEnableProfile.</param>
        /// 
        /// <returns>Returns a  EnableProfileResult from IAMRolesAnywhere.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rolesanywhere-2018-05-10/EnableProfile">REST API Reference for EnableProfile Operation</seealso>
        EnableProfileResponse EndEnableProfile(IAsyncResult asyncResult);

        #endregion
        
        #region  EnableTrustAnchor


        /// <summary>
        /// Enables a trust anchor. When enabled, certificates in the trust anchor chain are authorized
        /// for trust validation. 
        /// 
        ///  
        /// <para>
        ///  <b>Required permissions: </b> <code>rolesanywhere:EnableTrustAnchor</code>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EnableTrustAnchor service method.</param>
        /// 
        /// <returns>The response from the EnableTrustAnchor service method, as returned by IAMRolesAnywhere.</returns>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rolesanywhere-2018-05-10/EnableTrustAnchor">REST API Reference for EnableTrustAnchor Operation</seealso>
        EnableTrustAnchorResponse EnableTrustAnchor(EnableTrustAnchorRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the EnableTrustAnchor operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the EnableTrustAnchor operation on AmazonIAMRolesAnywhereClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndEnableTrustAnchor
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rolesanywhere-2018-05-10/EnableTrustAnchor">REST API Reference for EnableTrustAnchor Operation</seealso>
        IAsyncResult BeginEnableTrustAnchor(EnableTrustAnchorRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  EnableTrustAnchor operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginEnableTrustAnchor.</param>
        /// 
        /// <returns>Returns a  EnableTrustAnchorResult from IAMRolesAnywhere.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rolesanywhere-2018-05-10/EnableTrustAnchor">REST API Reference for EnableTrustAnchor Operation</seealso>
        EnableTrustAnchorResponse EndEnableTrustAnchor(IAsyncResult asyncResult);

        #endregion
        
        #region  GetCrl


        /// <summary>
        /// Gets a certificate revocation list (CRL).
        /// 
        ///  
        /// <para>
        ///  <b>Required permissions: </b> <code>rolesanywhere:GetCrl</code>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCrl service method.</param>
        /// 
        /// <returns>The response from the GetCrl service method, as returned by IAMRolesAnywhere.</returns>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rolesanywhere-2018-05-10/GetCrl">REST API Reference for GetCrl Operation</seealso>
        GetCrlResponse GetCrl(GetCrlRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetCrl operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetCrl operation on AmazonIAMRolesAnywhereClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetCrl
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rolesanywhere-2018-05-10/GetCrl">REST API Reference for GetCrl Operation</seealso>
        IAsyncResult BeginGetCrl(GetCrlRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetCrl operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetCrl.</param>
        /// 
        /// <returns>Returns a  GetCrlResult from IAMRolesAnywhere.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rolesanywhere-2018-05-10/GetCrl">REST API Reference for GetCrl Operation</seealso>
        GetCrlResponse EndGetCrl(IAsyncResult asyncResult);

        #endregion
        
        #region  GetProfile


        /// <summary>
        /// Gets a profile.
        /// 
        ///  
        /// <para>
        ///  <b>Required permissions: </b> <code>rolesanywhere:GetProfile</code>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetProfile service method.</param>
        /// 
        /// <returns>The response from the GetProfile service method, as returned by IAMRolesAnywhere.</returns>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rolesanywhere-2018-05-10/GetProfile">REST API Reference for GetProfile Operation</seealso>
        GetProfileResponse GetProfile(GetProfileRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetProfile operation on AmazonIAMRolesAnywhereClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetProfile
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rolesanywhere-2018-05-10/GetProfile">REST API Reference for GetProfile Operation</seealso>
        IAsyncResult BeginGetProfile(GetProfileRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetProfile operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetProfile.</param>
        /// 
        /// <returns>Returns a  GetProfileResult from IAMRolesAnywhere.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rolesanywhere-2018-05-10/GetProfile">REST API Reference for GetProfile Operation</seealso>
        GetProfileResponse EndGetProfile(IAsyncResult asyncResult);

        #endregion
        
        #region  GetSubject


        /// <summary>
        /// Gets a Subject. A Subject associates a certificate identity with authentication attempts
        /// by CreateSession. The Subject resources stores audit information such as status of
        /// the last authentication attempt, the certificate data used in the attempt, and the
        /// last time the associated identity attempted authentication. 
        /// 
        ///  
        /// <para>
        ///  <b>Required permissions: </b> <code>rolesanywhere:GetSubject</code>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSubject service method.</param>
        /// 
        /// <returns>The response from the GetSubject service method, as returned by IAMRolesAnywhere.</returns>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rolesanywhere-2018-05-10/GetSubject">REST API Reference for GetSubject Operation</seealso>
        GetSubjectResponse GetSubject(GetSubjectRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetSubject operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSubject operation on AmazonIAMRolesAnywhereClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetSubject
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rolesanywhere-2018-05-10/GetSubject">REST API Reference for GetSubject Operation</seealso>
        IAsyncResult BeginGetSubject(GetSubjectRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetSubject operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetSubject.</param>
        /// 
        /// <returns>Returns a  GetSubjectResult from IAMRolesAnywhere.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rolesanywhere-2018-05-10/GetSubject">REST API Reference for GetSubject Operation</seealso>
        GetSubjectResponse EndGetSubject(IAsyncResult asyncResult);

        #endregion
        
        #region  GetTrustAnchor


        /// <summary>
        /// Gets a trust anchor.
        /// 
        ///  
        /// <para>
        ///  <b>Required permissions: </b> <code>rolesanywhere:GetTrustAnchor</code>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTrustAnchor service method.</param>
        /// 
        /// <returns>The response from the GetTrustAnchor service method, as returned by IAMRolesAnywhere.</returns>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.ValidationException">
        /// Validation exception error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rolesanywhere-2018-05-10/GetTrustAnchor">REST API Reference for GetTrustAnchor Operation</seealso>
        GetTrustAnchorResponse GetTrustAnchor(GetTrustAnchorRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetTrustAnchor operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetTrustAnchor operation on AmazonIAMRolesAnywhereClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetTrustAnchor
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rolesanywhere-2018-05-10/GetTrustAnchor">REST API Reference for GetTrustAnchor Operation</seealso>
        IAsyncResult BeginGetTrustAnchor(GetTrustAnchorRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetTrustAnchor operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetTrustAnchor.</param>
        /// 
        /// <returns>Returns a  GetTrustAnchorResult from IAMRolesAnywhere.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rolesanywhere-2018-05-10/GetTrustAnchor">REST API Reference for GetTrustAnchor Operation</seealso>
        GetTrustAnchorResponse EndGetTrustAnchor(IAsyncResult asyncResult);

        #endregion
        
        #region  ImportCrl


        /// <summary>
        /// Imports the certificate revocation list (CRL). CRl is a list of certificates that
        /// have been revoked by the issuing certificate Authority (CA). IAM Roles Anywhere validates
        /// against the crl list before issuing credentials. 
        /// 
        ///  
        /// <para>
        ///  <b>Required permissions: </b> <code>rolesanywhere:ImportCrl</code>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ImportCrl service method.</param>
        /// 
        /// <returns>The response from the ImportCrl service method, as returned by IAMRolesAnywhere.</returns>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.ValidationException">
        /// Validation exception error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rolesanywhere-2018-05-10/ImportCrl">REST API Reference for ImportCrl Operation</seealso>
        ImportCrlResponse ImportCrl(ImportCrlRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ImportCrl operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ImportCrl operation on AmazonIAMRolesAnywhereClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndImportCrl
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rolesanywhere-2018-05-10/ImportCrl">REST API Reference for ImportCrl Operation</seealso>
        IAsyncResult BeginImportCrl(ImportCrlRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ImportCrl operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginImportCrl.</param>
        /// 
        /// <returns>Returns a  ImportCrlResult from IAMRolesAnywhere.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rolesanywhere-2018-05-10/ImportCrl">REST API Reference for ImportCrl Operation</seealso>
        ImportCrlResponse EndImportCrl(IAsyncResult asyncResult);

        #endregion
        
        #region  ListCrls


        /// <summary>
        /// Lists all Crls in the authenticated account and Amazon Web Services Region.
        /// 
        ///  
        /// <para>
        ///  <b>Required permissions: </b> <code>rolesanywhere:ListCrls</code>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCrls service method.</param>
        /// 
        /// <returns>The response from the ListCrls service method, as returned by IAMRolesAnywhere.</returns>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.ValidationException">
        /// Validation exception error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rolesanywhere-2018-05-10/ListCrls">REST API Reference for ListCrls Operation</seealso>
        ListCrlsResponse ListCrls(ListCrlsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListCrls operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListCrls operation on AmazonIAMRolesAnywhereClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListCrls
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rolesanywhere-2018-05-10/ListCrls">REST API Reference for ListCrls Operation</seealso>
        IAsyncResult BeginListCrls(ListCrlsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListCrls operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListCrls.</param>
        /// 
        /// <returns>Returns a  ListCrlsResult from IAMRolesAnywhere.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rolesanywhere-2018-05-10/ListCrls">REST API Reference for ListCrls Operation</seealso>
        ListCrlsResponse EndListCrls(IAsyncResult asyncResult);

        #endregion
        
        #region  ListProfiles


        /// <summary>
        /// Lists all profiles in the authenticated account and Amazon Web Services Region.
        /// 
        ///  
        /// <para>
        ///  <b>Required permissions: </b> <code>rolesanywhere:ListProfiles</code>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListProfiles service method.</param>
        /// 
        /// <returns>The response from the ListProfiles service method, as returned by IAMRolesAnywhere.</returns>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.ValidationException">
        /// Validation exception error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rolesanywhere-2018-05-10/ListProfiles">REST API Reference for ListProfiles Operation</seealso>
        ListProfilesResponse ListProfiles(ListProfilesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListProfiles operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListProfiles operation on AmazonIAMRolesAnywhereClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListProfiles
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rolesanywhere-2018-05-10/ListProfiles">REST API Reference for ListProfiles Operation</seealso>
        IAsyncResult BeginListProfiles(ListProfilesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListProfiles operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListProfiles.</param>
        /// 
        /// <returns>Returns a  ListProfilesResult from IAMRolesAnywhere.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rolesanywhere-2018-05-10/ListProfiles">REST API Reference for ListProfiles Operation</seealso>
        ListProfilesResponse EndListProfiles(IAsyncResult asyncResult);

        #endregion
        
        #region  ListSubjects


        /// <summary>
        /// Lists the subjects in the authenticated account and Amazon Web Services Region.
        /// 
        ///  
        /// <para>
        ///  <b>Required permissions: </b> <code>rolesanywhere:ListSubjects</code>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSubjects service method.</param>
        /// 
        /// <returns>The response from the ListSubjects service method, as returned by IAMRolesAnywhere.</returns>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.ValidationException">
        /// Validation exception error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rolesanywhere-2018-05-10/ListSubjects">REST API Reference for ListSubjects Operation</seealso>
        ListSubjectsResponse ListSubjects(ListSubjectsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListSubjects operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListSubjects operation on AmazonIAMRolesAnywhereClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListSubjects
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rolesanywhere-2018-05-10/ListSubjects">REST API Reference for ListSubjects Operation</seealso>
        IAsyncResult BeginListSubjects(ListSubjectsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListSubjects operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListSubjects.</param>
        /// 
        /// <returns>Returns a  ListSubjectsResult from IAMRolesAnywhere.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rolesanywhere-2018-05-10/ListSubjects">REST API Reference for ListSubjects Operation</seealso>
        ListSubjectsResponse EndListSubjects(IAsyncResult asyncResult);

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// Lists the tags attached to the resource.
        /// 
        ///  
        /// <para>
        ///  <b>Required permissions: </b> <code>rolesanywhere:ListTagsForResource</code>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by IAMRolesAnywhere.</returns>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.ValidationException">
        /// Validation exception error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rolesanywhere-2018-05-10/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonIAMRolesAnywhereClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rolesanywhere-2018-05-10/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        IAsyncResult BeginListTagsForResource(ListTagsForResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTagsForResource.</param>
        /// 
        /// <returns>Returns a  ListTagsForResourceResult from IAMRolesAnywhere.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rolesanywhere-2018-05-10/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult);

        #endregion
        
        #region  ListTrustAnchors


        /// <summary>
        /// Lists the trust anchors in the authenticated account and Amazon Web Services Region.
        /// 
        ///  
        /// <para>
        ///  <b>Required permissions: </b> <code>rolesanywhere:ListTrustAnchors</code>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTrustAnchors service method.</param>
        /// 
        /// <returns>The response from the ListTrustAnchors service method, as returned by IAMRolesAnywhere.</returns>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.ValidationException">
        /// Validation exception error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rolesanywhere-2018-05-10/ListTrustAnchors">REST API Reference for ListTrustAnchors Operation</seealso>
        ListTrustAnchorsResponse ListTrustAnchors(ListTrustAnchorsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListTrustAnchors operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTrustAnchors operation on AmazonIAMRolesAnywhereClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTrustAnchors
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rolesanywhere-2018-05-10/ListTrustAnchors">REST API Reference for ListTrustAnchors Operation</seealso>
        IAsyncResult BeginListTrustAnchors(ListTrustAnchorsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTrustAnchors operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTrustAnchors.</param>
        /// 
        /// <returns>Returns a  ListTrustAnchorsResult from IAMRolesAnywhere.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rolesanywhere-2018-05-10/ListTrustAnchors">REST API Reference for ListTrustAnchors Operation</seealso>
        ListTrustAnchorsResponse EndListTrustAnchors(IAsyncResult asyncResult);

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Attaches tags to a resource.
        /// 
        ///  
        /// <para>
        ///  <b>Required permissions: </b> <code>rolesanywhere:TagResource</code>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by IAMRolesAnywhere.</returns>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.TooManyTagsException">
        /// Too many tags.
        /// </exception>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.ValidationException">
        /// Validation exception error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rolesanywhere-2018-05-10/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse TagResource(TagResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the TagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonIAMRolesAnywhereClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rolesanywhere-2018-05-10/TagResource">REST API Reference for TagResource Operation</seealso>
        IAsyncResult BeginTagResource(TagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  TagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTagResource.</param>
        /// 
        /// <returns>Returns a  TagResourceResult from IAMRolesAnywhere.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rolesanywhere-2018-05-10/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse EndTagResource(IAsyncResult asyncResult);

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// Removes tags from the resource.
        /// 
        ///  
        /// <para>
        ///  <b>Required permissions: </b> <code>rolesanywhere:UntagResource</code>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by IAMRolesAnywhere.</returns>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.ValidationException">
        /// Validation exception error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rolesanywhere-2018-05-10/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse UntagResource(UntagResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UntagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonIAMRolesAnywhereClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rolesanywhere-2018-05-10/UntagResource">REST API Reference for UntagResource Operation</seealso>
        IAsyncResult BeginUntagResource(UntagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UntagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUntagResource.</param>
        /// 
        /// <returns>Returns a  UntagResourceResult from IAMRolesAnywhere.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rolesanywhere-2018-05-10/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse EndUntagResource(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateCrl


        /// <summary>
        /// Updates the certificate revocation list (CRL). CRl is a list of certificates that
        /// have been revoked by the issuing certificate Authority (CA). IAM Roles Anywhere validates
        /// against the crl list before issuing credentials.
        /// 
        ///  
        /// <para>
        ///  <b>Required permissions: </b> <code>rolesanywhere:UpdateCrl</code>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateCrl service method.</param>
        /// 
        /// <returns>The response from the UpdateCrl service method, as returned by IAMRolesAnywhere.</returns>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.ValidationException">
        /// Validation exception error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rolesanywhere-2018-05-10/UpdateCrl">REST API Reference for UpdateCrl Operation</seealso>
        UpdateCrlResponse UpdateCrl(UpdateCrlRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateCrl operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateCrl operation on AmazonIAMRolesAnywhereClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateCrl
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rolesanywhere-2018-05-10/UpdateCrl">REST API Reference for UpdateCrl Operation</seealso>
        IAsyncResult BeginUpdateCrl(UpdateCrlRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateCrl operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateCrl.</param>
        /// 
        /// <returns>Returns a  UpdateCrlResult from IAMRolesAnywhere.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rolesanywhere-2018-05-10/UpdateCrl">REST API Reference for UpdateCrl Operation</seealso>
        UpdateCrlResponse EndUpdateCrl(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateProfile


        /// <summary>
        /// Updates the profile. A profile is configuration resource to list the roles that RolesAnywhere
        /// service is trusted to assume. In addition, by applying a profile you can scope-down
        /// permissions with IAM managed policies.
        /// 
        ///  
        /// <para>
        ///  <b>Required permissions: </b> <code>rolesanywhere:UpdateProfile</code>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateProfile service method.</param>
        /// 
        /// <returns>The response from the UpdateProfile service method, as returned by IAMRolesAnywhere.</returns>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.ValidationException">
        /// Validation exception error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rolesanywhere-2018-05-10/UpdateProfile">REST API Reference for UpdateProfile Operation</seealso>
        UpdateProfileResponse UpdateProfile(UpdateProfileRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateProfile operation on AmazonIAMRolesAnywhereClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateProfile
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rolesanywhere-2018-05-10/UpdateProfile">REST API Reference for UpdateProfile Operation</seealso>
        IAsyncResult BeginUpdateProfile(UpdateProfileRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateProfile operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateProfile.</param>
        /// 
        /// <returns>Returns a  UpdateProfileResult from IAMRolesAnywhere.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rolesanywhere-2018-05-10/UpdateProfile">REST API Reference for UpdateProfile Operation</seealso>
        UpdateProfileResponse EndUpdateProfile(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateTrustAnchor


        /// <summary>
        /// Updates the trust anchor.You establish trust between IAM Roles Anywhere and your certificate
        /// authority (CA) by configuring a trust anchor. A Trust Anchor is defined either as
        /// a reference to a AWS Certificate Manager Private Certificate Authority (ACM PCA),
        /// or by uploading a Certificate Authority (CA) certificate. Your AWS workloads can authenticate
        /// with the trust anchor using certificates issued by the trusted Certificate Authority
        /// (CA) in exchange for temporary AWS credentials.
        /// 
        ///  
        /// <para>
        ///  <b>Required permissions: </b> <code>rolesanywhere:UpdateTrustAnchor</code>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateTrustAnchor service method.</param>
        /// 
        /// <returns>The response from the UpdateTrustAnchor service method, as returned by IAMRolesAnywhere.</returns>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.ValidationException">
        /// Validation exception error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rolesanywhere-2018-05-10/UpdateTrustAnchor">REST API Reference for UpdateTrustAnchor Operation</seealso>
        UpdateTrustAnchorResponse UpdateTrustAnchor(UpdateTrustAnchorRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateTrustAnchor operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateTrustAnchor operation on AmazonIAMRolesAnywhereClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateTrustAnchor
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rolesanywhere-2018-05-10/UpdateTrustAnchor">REST API Reference for UpdateTrustAnchor Operation</seealso>
        IAsyncResult BeginUpdateTrustAnchor(UpdateTrustAnchorRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateTrustAnchor operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateTrustAnchor.</param>
        /// 
        /// <returns>Returns a  UpdateTrustAnchorResult from IAMRolesAnywhere.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rolesanywhere-2018-05-10/UpdateTrustAnchor">REST API Reference for UpdateTrustAnchor Operation</seealso>
        UpdateTrustAnchorResponse EndUpdateTrustAnchor(IAsyncResult asyncResult);

        #endregion
        
    }
}