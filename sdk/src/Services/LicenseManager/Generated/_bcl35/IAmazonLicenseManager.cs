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
    /// AWS License Manager  
    /// <para>
    ///  <i>This is the AWS License Manager API Reference.</i> It provides descriptions, syntax,
    /// and usage examples for each of the actions and data types for License Manager. The
    /// topic for each action shows the Query API request parameters and the XML response.
    /// You can also view the XML request elements in the WSDL. 
    /// </para>
    ///  
    /// <para>
    ///  Alternatively, you can use one of the AWS SDKs to access an API that's tailored to
    /// the programming language or platform that you're using. For more information, see
    /// <a href="http://aws.amazon.com/tools/#SDKs">AWS SDKs</a>. 
    /// </para>
    /// </summary>
    public partial interface IAmazonLicenseManager : IAmazonService, IDisposable
    {

        
        #region  CreateLicenseConfiguration


        /// <summary>
        /// Creates a new license configuration object. A license configuration is an abstraction
        /// of a customer license agreement that can be consumed and enforced by License Manager.
        /// Components include specifications for the license type (licensing by instance, socket,
        /// CPU, or VCPU), tenancy (shared tenancy, Amazon EC2 Dedicated Instance, Amazon EC2
        /// Dedicated Host, or any of these), host affinity (how long a VM must be associated
        /// with a host), the number of licenses purchased and used.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateLicenseConfiguration service method.</param>
        /// 
        /// <returns>The response from the CreateLicenseConfiguration service method, as returned by LicenseManager.</returns>
        /// <exception cref="Amazon.LicenseManager.Model.AccessDeniedException">
        /// Access to resource denied.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.AuthorizationException">
        /// The AWS user account does not have permission to perform the action. Check the IAM
        /// policy associated with this account.
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
        
        #region  DeleteLicenseConfiguration


        /// <summary>
        /// Deletes an existing license configuration. This action fails if the configuration
        /// is in use.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteLicenseConfiguration service method.</param>
        /// 
        /// <returns>The response from the DeleteLicenseConfiguration service method, as returned by LicenseManager.</returns>
        /// <exception cref="Amazon.LicenseManager.Model.AccessDeniedException">
        /// Access to resource denied.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.AuthorizationException">
        /// The AWS user account does not have permission to perform the action. Check the IAM
        /// policy associated with this account.
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
        
        #region  GetLicenseConfiguration


        /// <summary>
        /// Returns a detailed description of a license configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetLicenseConfiguration service method.</param>
        /// 
        /// <returns>The response from the GetLicenseConfiguration service method, as returned by LicenseManager.</returns>
        /// <exception cref="Amazon.LicenseManager.Model.AccessDeniedException">
        /// Access to resource denied.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.AuthorizationException">
        /// The AWS user account does not have permission to perform the action. Check the IAM
        /// policy associated with this account.
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
        
        #region  GetServiceSettings


        /// <summary>
        /// Gets License Manager settings for a region. Exposes the configured S3 bucket, SNS
        /// topic, etc., for inspection.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetServiceSettings service method.</param>
        /// 
        /// <returns>The response from the GetServiceSettings service method, as returned by LicenseManager.</returns>
        /// <exception cref="Amazon.LicenseManager.Model.AccessDeniedException">
        /// Access to resource denied.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.AuthorizationException">
        /// The AWS user account does not have permission to perform the action. Check the IAM
        /// policy associated with this account.
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
        /// Lists the resource associations for a license configuration. Resource associations
        /// need not consume licenses from a license configuration. For example, an AMI or a stopped
        /// instance may not consume a license (depending on the license rules). Use this operation
        /// to find all resources associated with a license configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAssociationsForLicenseConfiguration service method.</param>
        /// 
        /// <returns>The response from the ListAssociationsForLicenseConfiguration service method, as returned by LicenseManager.</returns>
        /// <exception cref="Amazon.LicenseManager.Model.AccessDeniedException">
        /// Access to resource denied.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.AuthorizationException">
        /// The AWS user account does not have permission to perform the action. Check the IAM
        /// policy associated with this account.
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
        
        #region  ListLicenseConfigurations


        /// <summary>
        /// Lists license configuration objects for an account, each containing the name, description,
        /// license type, and other license terms modeled from a license agreement.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListLicenseConfigurations service method.</param>
        /// 
        /// <returns>The response from the ListLicenseConfigurations service method, as returned by LicenseManager.</returns>
        /// <exception cref="Amazon.LicenseManager.Model.AccessDeniedException">
        /// Access to resource denied.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.AuthorizationException">
        /// The AWS user account does not have permission to perform the action. Check the IAM
        /// policy associated with this account.
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
        
        #region  ListLicenseSpecificationsForResource


        /// <summary>
        /// Returns the license configuration for a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListLicenseSpecificationsForResource service method.</param>
        /// 
        /// <returns>The response from the ListLicenseSpecificationsForResource service method, as returned by LicenseManager.</returns>
        /// <exception cref="Amazon.LicenseManager.Model.AccessDeniedException">
        /// Access to resource denied.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.AuthorizationException">
        /// The AWS user account does not have permission to perform the action. Check the IAM
        /// policy associated with this account.
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
        
        #region  ListResourceInventory


        /// <summary>
        /// Returns a detailed list of resources.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListResourceInventory service method.</param>
        /// 
        /// <returns>The response from the ListResourceInventory service method, as returned by LicenseManager.</returns>
        /// <exception cref="Amazon.LicenseManager.Model.AccessDeniedException">
        /// Access to resource denied.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.AuthorizationException">
        /// The AWS user account does not have permission to perform the action. Check the IAM
        /// policy associated with this account.
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
        /// Lists tags attached to a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by LicenseManager.</returns>
        /// <exception cref="Amazon.LicenseManager.Model.AccessDeniedException">
        /// Access to resource denied.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.AuthorizationException">
        /// The AWS user account does not have permission to perform the action. Check the IAM
        /// policy associated with this account.
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
        /// The AWS user account does not have permission to perform the action. Check the IAM
        /// policy associated with this account.
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
        
        #region  TagResource


        /// <summary>
        /// Attach one of more tags to any resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by LicenseManager.</returns>
        /// <exception cref="Amazon.LicenseManager.Model.AccessDeniedException">
        /// Access to resource denied.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.AuthorizationException">
        /// The AWS user account does not have permission to perform the action. Check the IAM
        /// policy associated with this account.
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
        /// Remove tags from a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by LicenseManager.</returns>
        /// <exception cref="Amazon.LicenseManager.Model.AccessDeniedException">
        /// Access to resource denied.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.AuthorizationException">
        /// The AWS user account does not have permission to perform the action. Check the IAM
        /// policy associated with this account.
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
        /// Modifies the attributes of an existing license configuration object. A license configuration
        /// is an abstraction of a customer license agreement that can be consumed and enforced
        /// by License Manager. Components include specifications for the license type (Instances,
        /// cores, sockets, VCPUs), tenancy (shared or Dedicated Host), host affinity (how long
        /// a VM is associated with a host), the number of licenses purchased and used.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateLicenseConfiguration service method.</param>
        /// 
        /// <returns>The response from the UpdateLicenseConfiguration service method, as returned by LicenseManager.</returns>
        /// <exception cref="Amazon.LicenseManager.Model.AccessDeniedException">
        /// Access to resource denied.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.AuthorizationException">
        /// The AWS user account does not have permission to perform the action. Check the IAM
        /// policy associated with this account.
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
        
        #region  UpdateLicenseSpecificationsForResource


        /// <summary>
        /// Adds or removes license configurations for a specified AWS resource. This operation
        /// currently supports updating the license specifications of AMIs, instances, and hosts.
        /// Launch templates and AWS CloudFormation templates are not managed from this operation
        /// as those resources send the license configurations directly to a resource creation
        /// operation, such as <code>RunInstances</code>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateLicenseSpecificationsForResource service method.</param>
        /// 
        /// <returns>The response from the UpdateLicenseSpecificationsForResource service method, as returned by LicenseManager.</returns>
        /// <exception cref="Amazon.LicenseManager.Model.AccessDeniedException">
        /// Access to resource denied.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.AuthorizationException">
        /// The AWS user account does not have permission to perform the action. Check the IAM
        /// policy associated with this account.
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
        /// Updates License Manager service settings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateServiceSettings service method.</param>
        /// 
        /// <returns>The response from the UpdateServiceSettings service method, as returned by LicenseManager.</returns>
        /// <exception cref="Amazon.LicenseManager.Model.AccessDeniedException">
        /// Access to resource denied.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.AuthorizationException">
        /// The AWS user account does not have permission to perform the action. Check the IAM
        /// policy associated with this account.
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