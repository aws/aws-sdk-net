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
 * Do not modify this file. This file is generated from the ssm-quicksetup-2018-05-10.normal.json service model.
 */


using System;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.SSMQuickSetup.Model;

#pragma warning disable CS1570
namespace Amazon.SSMQuickSetup
{
    /// <summary>
    /// <para>Interface for accessing SSMQuickSetup</para>
    ///
    /// Quick Setup helps you quickly configure frequently used services and features with
    /// recommended best practices. Quick Setup simplifies setting up services, including
    /// Systems Manager, by automating common or recommended tasks.
    /// </summary>
    public partial interface IAmazonSSMQuickSetup : IAmazonService, IDisposable
    {


#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        ISSMQuickSetupPaginatorFactory Paginators { get; }
#endif


        
        #region  CreateConfigurationManager


        /// <summary>
        /// Creates a Quick Setup configuration manager resource. This object is a collection
        /// of desired state configurations for multiple configuration definitions and summaries
        /// describing the deployments of those definitions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateConfigurationManager service method.</param>
        /// 
        /// <returns>The response from the CreateConfigurationManager service method, as returned by SSMQuickSetup.</returns>
        /// <exception cref="Amazon.SSMQuickSetup.Model.AccessDeniedException">
        /// The requester has insufficient permissions to perform the operation.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.ConflictException">
        /// Another request is being processed. Wait a few minutes and try again.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.InternalServerException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.ThrottlingException">
        /// The request or operation exceeds the maximum allowed request rate per Amazon Web Services
        /// account and Amazon Web Services Region.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.ValidationException">
        /// The request is invalid. Verify the values provided for the request parameters are
        /// accurate.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-quicksetup-2018-05-10/CreateConfigurationManager">REST API Reference for CreateConfigurationManager Operation</seealso>
        CreateConfigurationManagerResponse CreateConfigurationManager(CreateConfigurationManagerRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateConfigurationManager operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateConfigurationManager operation on AmazonSSMQuickSetupClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateConfigurationManager
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-quicksetup-2018-05-10/CreateConfigurationManager">REST API Reference for CreateConfigurationManager Operation</seealso>
        IAsyncResult BeginCreateConfigurationManager(CreateConfigurationManagerRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateConfigurationManager operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateConfigurationManager.</param>
        /// 
        /// <returns>Returns a  CreateConfigurationManagerResult from SSMQuickSetup.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-quicksetup-2018-05-10/CreateConfigurationManager">REST API Reference for CreateConfigurationManager Operation</seealso>
        CreateConfigurationManagerResponse EndCreateConfigurationManager(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteConfigurationManager


        /// <summary>
        /// Deletes a configuration manager.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteConfigurationManager service method.</param>
        /// 
        /// <returns>The response from the DeleteConfigurationManager service method, as returned by SSMQuickSetup.</returns>
        /// <exception cref="Amazon.SSMQuickSetup.Model.AccessDeniedException">
        /// The requester has insufficient permissions to perform the operation.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.ConflictException">
        /// Another request is being processed. Wait a few minutes and try again.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.InternalServerException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.ResourceNotFoundException">
        /// The resource couldn't be found. Check the ID or name and try again.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.ThrottlingException">
        /// The request or operation exceeds the maximum allowed request rate per Amazon Web Services
        /// account and Amazon Web Services Region.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.ValidationException">
        /// The request is invalid. Verify the values provided for the request parameters are
        /// accurate.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-quicksetup-2018-05-10/DeleteConfigurationManager">REST API Reference for DeleteConfigurationManager Operation</seealso>
        DeleteConfigurationManagerResponse DeleteConfigurationManager(DeleteConfigurationManagerRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteConfigurationManager operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteConfigurationManager operation on AmazonSSMQuickSetupClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteConfigurationManager
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-quicksetup-2018-05-10/DeleteConfigurationManager">REST API Reference for DeleteConfigurationManager Operation</seealso>
        IAsyncResult BeginDeleteConfigurationManager(DeleteConfigurationManagerRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteConfigurationManager operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteConfigurationManager.</param>
        /// 
        /// <returns>Returns a  DeleteConfigurationManagerResult from SSMQuickSetup.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-quicksetup-2018-05-10/DeleteConfigurationManager">REST API Reference for DeleteConfigurationManager Operation</seealso>
        DeleteConfigurationManagerResponse EndDeleteConfigurationManager(IAsyncResult asyncResult);

        #endregion
        
        #region  GetConfiguration


        /// <summary>
        /// Returns details about the specified configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetConfiguration service method.</param>
        /// 
        /// <returns>The response from the GetConfiguration service method, as returned by SSMQuickSetup.</returns>
        /// <exception cref="Amazon.SSMQuickSetup.Model.AccessDeniedException">
        /// The requester has insufficient permissions to perform the operation.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.ConflictException">
        /// Another request is being processed. Wait a few minutes and try again.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.InternalServerException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.ResourceNotFoundException">
        /// The resource couldn't be found. Check the ID or name and try again.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.ThrottlingException">
        /// The request or operation exceeds the maximum allowed request rate per Amazon Web Services
        /// account and Amazon Web Services Region.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.ValidationException">
        /// The request is invalid. Verify the values provided for the request parameters are
        /// accurate.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-quicksetup-2018-05-10/GetConfiguration">REST API Reference for GetConfiguration Operation</seealso>
        GetConfigurationResponse GetConfiguration(GetConfigurationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetConfiguration operation on AmazonSSMQuickSetupClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-quicksetup-2018-05-10/GetConfiguration">REST API Reference for GetConfiguration Operation</seealso>
        IAsyncResult BeginGetConfiguration(GetConfigurationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetConfiguration.</param>
        /// 
        /// <returns>Returns a  GetConfigurationResult from SSMQuickSetup.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-quicksetup-2018-05-10/GetConfiguration">REST API Reference for GetConfiguration Operation</seealso>
        GetConfigurationResponse EndGetConfiguration(IAsyncResult asyncResult);

        #endregion
        
        #region  GetConfigurationManager


        /// <summary>
        /// Returns a configuration manager.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetConfigurationManager service method.</param>
        /// 
        /// <returns>The response from the GetConfigurationManager service method, as returned by SSMQuickSetup.</returns>
        /// <exception cref="Amazon.SSMQuickSetup.Model.AccessDeniedException">
        /// The requester has insufficient permissions to perform the operation.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.ConflictException">
        /// Another request is being processed. Wait a few minutes and try again.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.InternalServerException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.ResourceNotFoundException">
        /// The resource couldn't be found. Check the ID or name and try again.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.ThrottlingException">
        /// The request or operation exceeds the maximum allowed request rate per Amazon Web Services
        /// account and Amazon Web Services Region.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.ValidationException">
        /// The request is invalid. Verify the values provided for the request parameters are
        /// accurate.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-quicksetup-2018-05-10/GetConfigurationManager">REST API Reference for GetConfigurationManager Operation</seealso>
        GetConfigurationManagerResponse GetConfigurationManager(GetConfigurationManagerRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetConfigurationManager operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetConfigurationManager operation on AmazonSSMQuickSetupClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetConfigurationManager
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-quicksetup-2018-05-10/GetConfigurationManager">REST API Reference for GetConfigurationManager Operation</seealso>
        IAsyncResult BeginGetConfigurationManager(GetConfigurationManagerRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetConfigurationManager operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetConfigurationManager.</param>
        /// 
        /// <returns>Returns a  GetConfigurationManagerResult from SSMQuickSetup.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-quicksetup-2018-05-10/GetConfigurationManager">REST API Reference for GetConfigurationManager Operation</seealso>
        GetConfigurationManagerResponse EndGetConfigurationManager(IAsyncResult asyncResult);

        #endregion
        
        #region  GetServiceSettings


        /// <summary>
        /// Returns settings configured for Quick Setup in the requesting Amazon Web Services
        /// account and Amazon Web Services Region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetServiceSettings service method.</param>
        /// 
        /// <returns>The response from the GetServiceSettings service method, as returned by SSMQuickSetup.</returns>
        /// <exception cref="Amazon.SSMQuickSetup.Model.AccessDeniedException">
        /// The requester has insufficient permissions to perform the operation.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.ConflictException">
        /// Another request is being processed. Wait a few minutes and try again.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.InternalServerException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.ThrottlingException">
        /// The request or operation exceeds the maximum allowed request rate per Amazon Web Services
        /// account and Amazon Web Services Region.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-quicksetup-2018-05-10/GetServiceSettings">REST API Reference for GetServiceSettings Operation</seealso>
        GetServiceSettingsResponse GetServiceSettings(GetServiceSettingsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetServiceSettings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetServiceSettings operation on AmazonSSMQuickSetupClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetServiceSettings
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-quicksetup-2018-05-10/GetServiceSettings">REST API Reference for GetServiceSettings Operation</seealso>
        IAsyncResult BeginGetServiceSettings(GetServiceSettingsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetServiceSettings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetServiceSettings.</param>
        /// 
        /// <returns>Returns a  GetServiceSettingsResult from SSMQuickSetup.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-quicksetup-2018-05-10/GetServiceSettings">REST API Reference for GetServiceSettings Operation</seealso>
        GetServiceSettingsResponse EndGetServiceSettings(IAsyncResult asyncResult);

        #endregion
        
        #region  ListConfigurationManagers


        /// <summary>
        /// Returns Quick Setup configuration managers.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListConfigurationManagers service method.</param>
        /// 
        /// <returns>The response from the ListConfigurationManagers service method, as returned by SSMQuickSetup.</returns>
        /// <exception cref="Amazon.SSMQuickSetup.Model.AccessDeniedException">
        /// The requester has insufficient permissions to perform the operation.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.ConflictException">
        /// Another request is being processed. Wait a few minutes and try again.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.InternalServerException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.ThrottlingException">
        /// The request or operation exceeds the maximum allowed request rate per Amazon Web Services
        /// account and Amazon Web Services Region.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.ValidationException">
        /// The request is invalid. Verify the values provided for the request parameters are
        /// accurate.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-quicksetup-2018-05-10/ListConfigurationManagers">REST API Reference for ListConfigurationManagers Operation</seealso>
        ListConfigurationManagersResponse ListConfigurationManagers(ListConfigurationManagersRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListConfigurationManagers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListConfigurationManagers operation on AmazonSSMQuickSetupClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListConfigurationManagers
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-quicksetup-2018-05-10/ListConfigurationManagers">REST API Reference for ListConfigurationManagers Operation</seealso>
        IAsyncResult BeginListConfigurationManagers(ListConfigurationManagersRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListConfigurationManagers operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListConfigurationManagers.</param>
        /// 
        /// <returns>Returns a  ListConfigurationManagersResult from SSMQuickSetup.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-quicksetup-2018-05-10/ListConfigurationManagers">REST API Reference for ListConfigurationManagers Operation</seealso>
        ListConfigurationManagersResponse EndListConfigurationManagers(IAsyncResult asyncResult);

        #endregion
        
        #region  ListConfigurations


        /// <summary>
        /// Returns configurations deployed by Quick Setup in the requesting Amazon Web Services
        /// account and Amazon Web Services Region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListConfigurations service method.</param>
        /// 
        /// <returns>The response from the ListConfigurations service method, as returned by SSMQuickSetup.</returns>
        /// <exception cref="Amazon.SSMQuickSetup.Model.AccessDeniedException">
        /// The requester has insufficient permissions to perform the operation.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.InternalServerException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.ResourceNotFoundException">
        /// The resource couldn't be found. Check the ID or name and try again.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.ThrottlingException">
        /// The request or operation exceeds the maximum allowed request rate per Amazon Web Services
        /// account and Amazon Web Services Region.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.ValidationException">
        /// The request is invalid. Verify the values provided for the request parameters are
        /// accurate.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-quicksetup-2018-05-10/ListConfigurations">REST API Reference for ListConfigurations Operation</seealso>
        ListConfigurationsResponse ListConfigurations(ListConfigurationsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListConfigurations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListConfigurations operation on AmazonSSMQuickSetupClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListConfigurations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-quicksetup-2018-05-10/ListConfigurations">REST API Reference for ListConfigurations Operation</seealso>
        IAsyncResult BeginListConfigurations(ListConfigurationsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListConfigurations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListConfigurations.</param>
        /// 
        /// <returns>Returns a  ListConfigurationsResult from SSMQuickSetup.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-quicksetup-2018-05-10/ListConfigurations">REST API Reference for ListConfigurations Operation</seealso>
        ListConfigurationsResponse EndListConfigurations(IAsyncResult asyncResult);

        #endregion
        
        #region  ListQuickSetupTypes


        /// <summary>
        /// Returns the available Quick Setup types.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListQuickSetupTypes service method.</param>
        /// 
        /// <returns>The response from the ListQuickSetupTypes service method, as returned by SSMQuickSetup.</returns>
        /// <exception cref="Amazon.SSMQuickSetup.Model.AccessDeniedException">
        /// The requester has insufficient permissions to perform the operation.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.ConflictException">
        /// Another request is being processed. Wait a few minutes and try again.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.InternalServerException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.ThrottlingException">
        /// The request or operation exceeds the maximum allowed request rate per Amazon Web Services
        /// account and Amazon Web Services Region.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-quicksetup-2018-05-10/ListQuickSetupTypes">REST API Reference for ListQuickSetupTypes Operation</seealso>
        ListQuickSetupTypesResponse ListQuickSetupTypes(ListQuickSetupTypesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListQuickSetupTypes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListQuickSetupTypes operation on AmazonSSMQuickSetupClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListQuickSetupTypes
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-quicksetup-2018-05-10/ListQuickSetupTypes">REST API Reference for ListQuickSetupTypes Operation</seealso>
        IAsyncResult BeginListQuickSetupTypes(ListQuickSetupTypesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListQuickSetupTypes operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListQuickSetupTypes.</param>
        /// 
        /// <returns>Returns a  ListQuickSetupTypesResult from SSMQuickSetup.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-quicksetup-2018-05-10/ListQuickSetupTypes">REST API Reference for ListQuickSetupTypes Operation</seealso>
        ListQuickSetupTypesResponse EndListQuickSetupTypes(IAsyncResult asyncResult);

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// Returns tags assigned to the resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by SSMQuickSetup.</returns>
        /// <exception cref="Amazon.SSMQuickSetup.Model.AccessDeniedException">
        /// The requester has insufficient permissions to perform the operation.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.ConflictException">
        /// Another request is being processed. Wait a few minutes and try again.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.InternalServerException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.ResourceNotFoundException">
        /// The resource couldn't be found. Check the ID or name and try again.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.ThrottlingException">
        /// The request or operation exceeds the maximum allowed request rate per Amazon Web Services
        /// account and Amazon Web Services Region.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.ValidationException">
        /// The request is invalid. Verify the values provided for the request parameters are
        /// accurate.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-quicksetup-2018-05-10/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonSSMQuickSetupClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-quicksetup-2018-05-10/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        IAsyncResult BeginListTagsForResource(ListTagsForResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTagsForResource.</param>
        /// 
        /// <returns>Returns a  ListTagsForResourceResult from SSMQuickSetup.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-quicksetup-2018-05-10/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult);

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Assigns key-value pairs of metadata to Amazon Web Services resources.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by SSMQuickSetup.</returns>
        /// <exception cref="Amazon.SSMQuickSetup.Model.AccessDeniedException">
        /// The requester has insufficient permissions to perform the operation.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.ConflictException">
        /// Another request is being processed. Wait a few minutes and try again.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.InternalServerException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.ResourceNotFoundException">
        /// The resource couldn't be found. Check the ID or name and try again.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.ThrottlingException">
        /// The request or operation exceeds the maximum allowed request rate per Amazon Web Services
        /// account and Amazon Web Services Region.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.ValidationException">
        /// The request is invalid. Verify the values provided for the request parameters are
        /// accurate.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-quicksetup-2018-05-10/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse TagResource(TagResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the TagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonSSMQuickSetupClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-quicksetup-2018-05-10/TagResource">REST API Reference for TagResource Operation</seealso>
        IAsyncResult BeginTagResource(TagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  TagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTagResource.</param>
        /// 
        /// <returns>Returns a  TagResourceResult from SSMQuickSetup.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-quicksetup-2018-05-10/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse EndTagResource(IAsyncResult asyncResult);

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// Removes tags from the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by SSMQuickSetup.</returns>
        /// <exception cref="Amazon.SSMQuickSetup.Model.AccessDeniedException">
        /// The requester has insufficient permissions to perform the operation.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.ConflictException">
        /// Another request is being processed. Wait a few minutes and try again.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.InternalServerException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.ResourceNotFoundException">
        /// The resource couldn't be found. Check the ID or name and try again.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.ThrottlingException">
        /// The request or operation exceeds the maximum allowed request rate per Amazon Web Services
        /// account and Amazon Web Services Region.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.ValidationException">
        /// The request is invalid. Verify the values provided for the request parameters are
        /// accurate.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-quicksetup-2018-05-10/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse UntagResource(UntagResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UntagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonSSMQuickSetupClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-quicksetup-2018-05-10/UntagResource">REST API Reference for UntagResource Operation</seealso>
        IAsyncResult BeginUntagResource(UntagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UntagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUntagResource.</param>
        /// 
        /// <returns>Returns a  UntagResourceResult from SSMQuickSetup.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-quicksetup-2018-05-10/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse EndUntagResource(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateConfigurationDefinition


        /// <summary>
        /// Updates a Quick Setup configuration definition.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateConfigurationDefinition service method.</param>
        /// 
        /// <returns>The response from the UpdateConfigurationDefinition service method, as returned by SSMQuickSetup.</returns>
        /// <exception cref="Amazon.SSMQuickSetup.Model.AccessDeniedException">
        /// The requester has insufficient permissions to perform the operation.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.ConflictException">
        /// Another request is being processed. Wait a few minutes and try again.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.InternalServerException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.ResourceNotFoundException">
        /// The resource couldn't be found. Check the ID or name and try again.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.ThrottlingException">
        /// The request or operation exceeds the maximum allowed request rate per Amazon Web Services
        /// account and Amazon Web Services Region.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.ValidationException">
        /// The request is invalid. Verify the values provided for the request parameters are
        /// accurate.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-quicksetup-2018-05-10/UpdateConfigurationDefinition">REST API Reference for UpdateConfigurationDefinition Operation</seealso>
        UpdateConfigurationDefinitionResponse UpdateConfigurationDefinition(UpdateConfigurationDefinitionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateConfigurationDefinition operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateConfigurationDefinition operation on AmazonSSMQuickSetupClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateConfigurationDefinition
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-quicksetup-2018-05-10/UpdateConfigurationDefinition">REST API Reference for UpdateConfigurationDefinition Operation</seealso>
        IAsyncResult BeginUpdateConfigurationDefinition(UpdateConfigurationDefinitionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateConfigurationDefinition operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateConfigurationDefinition.</param>
        /// 
        /// <returns>Returns a  UpdateConfigurationDefinitionResult from SSMQuickSetup.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-quicksetup-2018-05-10/UpdateConfigurationDefinition">REST API Reference for UpdateConfigurationDefinition Operation</seealso>
        UpdateConfigurationDefinitionResponse EndUpdateConfigurationDefinition(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateConfigurationManager


        /// <summary>
        /// Updates a Quick Setup configuration manager.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateConfigurationManager service method.</param>
        /// 
        /// <returns>The response from the UpdateConfigurationManager service method, as returned by SSMQuickSetup.</returns>
        /// <exception cref="Amazon.SSMQuickSetup.Model.AccessDeniedException">
        /// The requester has insufficient permissions to perform the operation.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.ConflictException">
        /// Another request is being processed. Wait a few minutes and try again.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.InternalServerException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.ResourceNotFoundException">
        /// The resource couldn't be found. Check the ID or name and try again.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.ThrottlingException">
        /// The request or operation exceeds the maximum allowed request rate per Amazon Web Services
        /// account and Amazon Web Services Region.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.ValidationException">
        /// The request is invalid. Verify the values provided for the request parameters are
        /// accurate.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-quicksetup-2018-05-10/UpdateConfigurationManager">REST API Reference for UpdateConfigurationManager Operation</seealso>
        UpdateConfigurationManagerResponse UpdateConfigurationManager(UpdateConfigurationManagerRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateConfigurationManager operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateConfigurationManager operation on AmazonSSMQuickSetupClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateConfigurationManager
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-quicksetup-2018-05-10/UpdateConfigurationManager">REST API Reference for UpdateConfigurationManager Operation</seealso>
        IAsyncResult BeginUpdateConfigurationManager(UpdateConfigurationManagerRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateConfigurationManager operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateConfigurationManager.</param>
        /// 
        /// <returns>Returns a  UpdateConfigurationManagerResult from SSMQuickSetup.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-quicksetup-2018-05-10/UpdateConfigurationManager">REST API Reference for UpdateConfigurationManager Operation</seealso>
        UpdateConfigurationManagerResponse EndUpdateConfigurationManager(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateServiceSettings


        /// <summary>
        /// Updates settings configured for Quick Setup.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateServiceSettings service method.</param>
        /// 
        /// <returns>The response from the UpdateServiceSettings service method, as returned by SSMQuickSetup.</returns>
        /// <exception cref="Amazon.SSMQuickSetup.Model.AccessDeniedException">
        /// The requester has insufficient permissions to perform the operation.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.ConflictException">
        /// Another request is being processed. Wait a few minutes and try again.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.InternalServerException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.ThrottlingException">
        /// The request or operation exceeds the maximum allowed request rate per Amazon Web Services
        /// account and Amazon Web Services Region.
        /// </exception>
        /// <exception cref="Amazon.SSMQuickSetup.Model.ValidationException">
        /// The request is invalid. Verify the values provided for the request parameters are
        /// accurate.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-quicksetup-2018-05-10/UpdateServiceSettings">REST API Reference for UpdateServiceSettings Operation</seealso>
        UpdateServiceSettingsResponse UpdateServiceSettings(UpdateServiceSettingsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateServiceSettings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateServiceSettings operation on AmazonSSMQuickSetupClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateServiceSettings
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-quicksetup-2018-05-10/UpdateServiceSettings">REST API Reference for UpdateServiceSettings Operation</seealso>
        IAsyncResult BeginUpdateServiceSettings(UpdateServiceSettingsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateServiceSettings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateServiceSettings.</param>
        /// 
        /// <returns>Returns a  UpdateServiceSettingsResult from SSMQuickSetup.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-quicksetup-2018-05-10/UpdateServiceSettings">REST API Reference for UpdateServiceSettings Operation</seealso>
        UpdateServiceSettingsResponse EndUpdateServiceSettings(IAsyncResult asyncResult);

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