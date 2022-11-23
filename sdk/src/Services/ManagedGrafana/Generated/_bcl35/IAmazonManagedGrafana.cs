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
 * Do not modify this file. This file is generated from the grafana-2020-08-18.normal.json service model.
 */


using System;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.ManagedGrafana.Model;

namespace Amazon.ManagedGrafana
{
    /// <summary>
    /// Interface for accessing ManagedGrafana
    ///
    /// Amazon Managed Grafana is a fully managed and secure data visualization service that
    /// you can use to instantly query, correlate, and visualize operational metrics, logs,
    /// and traces from multiple sources. Amazon Managed Grafana makes it easy to deploy,
    /// operate, and scale Grafana, a widely deployed data visualization tool that is popular
    /// for its extensible data support.
    /// 
    ///  
    /// <para>
    /// With Amazon Managed Grafana, you create logically isolated Grafana servers called
    /// <i>workspaces</i>. In a workspace, you can create Grafana dashboards and visualizations
    /// to analyze your metrics, logs, and traces without having to build, package, or deploy
    /// any hardware to run Grafana servers. 
    /// </para>
    /// </summary>
    public partial interface IAmazonManagedGrafana : IAmazonService, IDisposable
    {


#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        IManagedGrafanaPaginatorFactory Paginators { get; }
#endif


        
        #region  AssociateLicense


        /// <summary>
        /// Assigns a Grafana Enterprise license to a workspace. Upgrading to Grafana Enterprise
        /// incurs additional fees. For more information, see <a href="https://docs.aws.amazon.com/grafana/latest/userguide/upgrade-to-Grafana-Enterprise.html">Upgrade
        /// a workspace to Grafana Enterprise</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateLicense service method.</param>
        /// 
        /// <returns>The response from the AssociateLicense service method, as returned by ManagedGrafana.</returns>
        /// <exception cref="Amazon.ManagedGrafana.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.InternalServerException">
        /// Unexpected error while processing the request. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ThrottlingException">
        /// The request was denied because of request throttling. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ValidationException">
        /// The value of a parameter in the request caused an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/grafana-2020-08-18/AssociateLicense">REST API Reference for AssociateLicense Operation</seealso>
        AssociateLicenseResponse AssociateLicense(AssociateLicenseRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the AssociateLicense operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateLicense operation on AmazonManagedGrafanaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAssociateLicense
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/grafana-2020-08-18/AssociateLicense">REST API Reference for AssociateLicense Operation</seealso>
        IAsyncResult BeginAssociateLicense(AssociateLicenseRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  AssociateLicense operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssociateLicense.</param>
        /// 
        /// <returns>Returns a  AssociateLicenseResult from ManagedGrafana.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/grafana-2020-08-18/AssociateLicense">REST API Reference for AssociateLicense Operation</seealso>
        AssociateLicenseResponse EndAssociateLicense(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateWorkspace


        /// <summary>
        /// Creates a <i>workspace</i>. In a workspace, you can create Grafana dashboards and
        /// visualizations to analyze your metrics, logs, and traces. You don't have to build,
        /// package, or deploy any hardware to run the Grafana server.
        /// 
        ///  
        /// <para>
        /// Don't use <code>CreateWorkspace</code> to modify an existing workspace. Instead, use
        /// <a href="https://docs.aws.amazon.com/grafana/latest/APIReference/API_UpdateWorkspace.html">UpdateWorkspace</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateWorkspace service method.</param>
        /// 
        /// <returns>The response from the CreateWorkspace service method, as returned by ManagedGrafana.</returns>
        /// <exception cref="Amazon.ManagedGrafana.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ConflictException">
        /// A resource was in an inconsistent state during an update or a deletion.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.InternalServerException">
        /// Unexpected error while processing the request. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ServiceQuotaExceededException">
        /// The request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ThrottlingException">
        /// The request was denied because of request throttling. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ValidationException">
        /// The value of a parameter in the request caused an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/grafana-2020-08-18/CreateWorkspace">REST API Reference for CreateWorkspace Operation</seealso>
        CreateWorkspaceResponse CreateWorkspace(CreateWorkspaceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateWorkspace operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateWorkspace operation on AmazonManagedGrafanaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateWorkspace
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/grafana-2020-08-18/CreateWorkspace">REST API Reference for CreateWorkspace Operation</seealso>
        IAsyncResult BeginCreateWorkspace(CreateWorkspaceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateWorkspace operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateWorkspace.</param>
        /// 
        /// <returns>Returns a  CreateWorkspaceResult from ManagedGrafana.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/grafana-2020-08-18/CreateWorkspace">REST API Reference for CreateWorkspace Operation</seealso>
        CreateWorkspaceResponse EndCreateWorkspace(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateWorkspaceApiKey


        /// <summary>
        /// Creates a Grafana API key for the workspace. This key can be used to authenticate
        /// requests sent to the workspace's HTTP API. See <a href="https://docs.aws.amazon.com/grafana/latest/userguide/Using-Grafana-APIs.html">https://docs.aws.amazon.com/grafana/latest/userguide/Using-Grafana-APIs.html</a>
        /// for available APIs and example requests.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateWorkspaceApiKey service method.</param>
        /// 
        /// <returns>The response from the CreateWorkspaceApiKey service method, as returned by ManagedGrafana.</returns>
        /// <exception cref="Amazon.ManagedGrafana.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ConflictException">
        /// A resource was in an inconsistent state during an update or a deletion.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.InternalServerException">
        /// Unexpected error while processing the request. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ServiceQuotaExceededException">
        /// The request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ThrottlingException">
        /// The request was denied because of request throttling. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ValidationException">
        /// The value of a parameter in the request caused an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/grafana-2020-08-18/CreateWorkspaceApiKey">REST API Reference for CreateWorkspaceApiKey Operation</seealso>
        CreateWorkspaceApiKeyResponse CreateWorkspaceApiKey(CreateWorkspaceApiKeyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateWorkspaceApiKey operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateWorkspaceApiKey operation on AmazonManagedGrafanaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateWorkspaceApiKey
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/grafana-2020-08-18/CreateWorkspaceApiKey">REST API Reference for CreateWorkspaceApiKey Operation</seealso>
        IAsyncResult BeginCreateWorkspaceApiKey(CreateWorkspaceApiKeyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateWorkspaceApiKey operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateWorkspaceApiKey.</param>
        /// 
        /// <returns>Returns a  CreateWorkspaceApiKeyResult from ManagedGrafana.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/grafana-2020-08-18/CreateWorkspaceApiKey">REST API Reference for CreateWorkspaceApiKey Operation</seealso>
        CreateWorkspaceApiKeyResponse EndCreateWorkspaceApiKey(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteWorkspace


        /// <summary>
        /// Deletes an Amazon Managed Grafana workspace.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteWorkspace service method.</param>
        /// 
        /// <returns>The response from the DeleteWorkspace service method, as returned by ManagedGrafana.</returns>
        /// <exception cref="Amazon.ManagedGrafana.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ConflictException">
        /// A resource was in an inconsistent state during an update or a deletion.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.InternalServerException">
        /// Unexpected error while processing the request. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ThrottlingException">
        /// The request was denied because of request throttling. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ValidationException">
        /// The value of a parameter in the request caused an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/grafana-2020-08-18/DeleteWorkspace">REST API Reference for DeleteWorkspace Operation</seealso>
        DeleteWorkspaceResponse DeleteWorkspace(DeleteWorkspaceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteWorkspace operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteWorkspace operation on AmazonManagedGrafanaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteWorkspace
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/grafana-2020-08-18/DeleteWorkspace">REST API Reference for DeleteWorkspace Operation</seealso>
        IAsyncResult BeginDeleteWorkspace(DeleteWorkspaceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteWorkspace operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteWorkspace.</param>
        /// 
        /// <returns>Returns a  DeleteWorkspaceResult from ManagedGrafana.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/grafana-2020-08-18/DeleteWorkspace">REST API Reference for DeleteWorkspace Operation</seealso>
        DeleteWorkspaceResponse EndDeleteWorkspace(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteWorkspaceApiKey


        /// <summary>
        /// Deletes a Grafana API key for the workspace.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteWorkspaceApiKey service method.</param>
        /// 
        /// <returns>The response from the DeleteWorkspaceApiKey service method, as returned by ManagedGrafana.</returns>
        /// <exception cref="Amazon.ManagedGrafana.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ConflictException">
        /// A resource was in an inconsistent state during an update or a deletion.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.InternalServerException">
        /// Unexpected error while processing the request. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ThrottlingException">
        /// The request was denied because of request throttling. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ValidationException">
        /// The value of a parameter in the request caused an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/grafana-2020-08-18/DeleteWorkspaceApiKey">REST API Reference for DeleteWorkspaceApiKey Operation</seealso>
        DeleteWorkspaceApiKeyResponse DeleteWorkspaceApiKey(DeleteWorkspaceApiKeyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteWorkspaceApiKey operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteWorkspaceApiKey operation on AmazonManagedGrafanaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteWorkspaceApiKey
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/grafana-2020-08-18/DeleteWorkspaceApiKey">REST API Reference for DeleteWorkspaceApiKey Operation</seealso>
        IAsyncResult BeginDeleteWorkspaceApiKey(DeleteWorkspaceApiKeyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteWorkspaceApiKey operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteWorkspaceApiKey.</param>
        /// 
        /// <returns>Returns a  DeleteWorkspaceApiKeyResult from ManagedGrafana.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/grafana-2020-08-18/DeleteWorkspaceApiKey">REST API Reference for DeleteWorkspaceApiKey Operation</seealso>
        DeleteWorkspaceApiKeyResponse EndDeleteWorkspaceApiKey(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeWorkspace


        /// <summary>
        /// Displays information about one Amazon Managed Grafana workspace.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeWorkspace service method.</param>
        /// 
        /// <returns>The response from the DescribeWorkspace service method, as returned by ManagedGrafana.</returns>
        /// <exception cref="Amazon.ManagedGrafana.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.InternalServerException">
        /// Unexpected error while processing the request. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ThrottlingException">
        /// The request was denied because of request throttling. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ValidationException">
        /// The value of a parameter in the request caused an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/grafana-2020-08-18/DescribeWorkspace">REST API Reference for DescribeWorkspace Operation</seealso>
        DescribeWorkspaceResponse DescribeWorkspace(DescribeWorkspaceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeWorkspace operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeWorkspace operation on AmazonManagedGrafanaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeWorkspace
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/grafana-2020-08-18/DescribeWorkspace">REST API Reference for DescribeWorkspace Operation</seealso>
        IAsyncResult BeginDescribeWorkspace(DescribeWorkspaceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeWorkspace operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeWorkspace.</param>
        /// 
        /// <returns>Returns a  DescribeWorkspaceResult from ManagedGrafana.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/grafana-2020-08-18/DescribeWorkspace">REST API Reference for DescribeWorkspace Operation</seealso>
        DescribeWorkspaceResponse EndDescribeWorkspace(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeWorkspaceAuthentication


        /// <summary>
        /// Displays information about the authentication methods used in one Amazon Managed Grafana
        /// workspace.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeWorkspaceAuthentication service method.</param>
        /// 
        /// <returns>The response from the DescribeWorkspaceAuthentication service method, as returned by ManagedGrafana.</returns>
        /// <exception cref="Amazon.ManagedGrafana.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.InternalServerException">
        /// Unexpected error while processing the request. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ThrottlingException">
        /// The request was denied because of request throttling. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ValidationException">
        /// The value of a parameter in the request caused an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/grafana-2020-08-18/DescribeWorkspaceAuthentication">REST API Reference for DescribeWorkspaceAuthentication Operation</seealso>
        DescribeWorkspaceAuthenticationResponse DescribeWorkspaceAuthentication(DescribeWorkspaceAuthenticationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeWorkspaceAuthentication operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeWorkspaceAuthentication operation on AmazonManagedGrafanaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeWorkspaceAuthentication
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/grafana-2020-08-18/DescribeWorkspaceAuthentication">REST API Reference for DescribeWorkspaceAuthentication Operation</seealso>
        IAsyncResult BeginDescribeWorkspaceAuthentication(DescribeWorkspaceAuthenticationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeWorkspaceAuthentication operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeWorkspaceAuthentication.</param>
        /// 
        /// <returns>Returns a  DescribeWorkspaceAuthenticationResult from ManagedGrafana.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/grafana-2020-08-18/DescribeWorkspaceAuthentication">REST API Reference for DescribeWorkspaceAuthentication Operation</seealso>
        DescribeWorkspaceAuthenticationResponse EndDescribeWorkspaceAuthentication(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeWorkspaceConfiguration


        /// <summary>
        /// Gets the current configuration string for the given workspace.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeWorkspaceConfiguration service method.</param>
        /// 
        /// <returns>The response from the DescribeWorkspaceConfiguration service method, as returned by ManagedGrafana.</returns>
        /// <exception cref="Amazon.ManagedGrafana.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.InternalServerException">
        /// Unexpected error while processing the request. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ThrottlingException">
        /// The request was denied because of request throttling. Retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/grafana-2020-08-18/DescribeWorkspaceConfiguration">REST API Reference for DescribeWorkspaceConfiguration Operation</seealso>
        DescribeWorkspaceConfigurationResponse DescribeWorkspaceConfiguration(DescribeWorkspaceConfigurationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeWorkspaceConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeWorkspaceConfiguration operation on AmazonManagedGrafanaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeWorkspaceConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/grafana-2020-08-18/DescribeWorkspaceConfiguration">REST API Reference for DescribeWorkspaceConfiguration Operation</seealso>
        IAsyncResult BeginDescribeWorkspaceConfiguration(DescribeWorkspaceConfigurationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeWorkspaceConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeWorkspaceConfiguration.</param>
        /// 
        /// <returns>Returns a  DescribeWorkspaceConfigurationResult from ManagedGrafana.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/grafana-2020-08-18/DescribeWorkspaceConfiguration">REST API Reference for DescribeWorkspaceConfiguration Operation</seealso>
        DescribeWorkspaceConfigurationResponse EndDescribeWorkspaceConfiguration(IAsyncResult asyncResult);

        #endregion
        
        #region  DisassociateLicense


        /// <summary>
        /// Removes the Grafana Enterprise license from a workspace.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateLicense service method.</param>
        /// 
        /// <returns>The response from the DisassociateLicense service method, as returned by ManagedGrafana.</returns>
        /// <exception cref="Amazon.ManagedGrafana.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.InternalServerException">
        /// Unexpected error while processing the request. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ThrottlingException">
        /// The request was denied because of request throttling. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ValidationException">
        /// The value of a parameter in the request caused an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/grafana-2020-08-18/DisassociateLicense">REST API Reference for DisassociateLicense Operation</seealso>
        DisassociateLicenseResponse DisassociateLicense(DisassociateLicenseRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateLicense operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateLicense operation on AmazonManagedGrafanaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisassociateLicense
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/grafana-2020-08-18/DisassociateLicense">REST API Reference for DisassociateLicense Operation</seealso>
        IAsyncResult BeginDisassociateLicense(DisassociateLicenseRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DisassociateLicense operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisassociateLicense.</param>
        /// 
        /// <returns>Returns a  DisassociateLicenseResult from ManagedGrafana.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/grafana-2020-08-18/DisassociateLicense">REST API Reference for DisassociateLicense Operation</seealso>
        DisassociateLicenseResponse EndDisassociateLicense(IAsyncResult asyncResult);

        #endregion
        
        #region  ListPermissions


        /// <summary>
        /// Lists the users and groups who have the Grafana <code>Admin</code> and <code>Editor</code>
        /// roles in this workspace. If you use this operation without specifying <code>userId</code>
        /// or <code>groupId</code>, the operation returns the roles of all users and groups.
        /// If you specify a <code>userId</code> or a <code>groupId</code>, only the roles for
        /// that user or group are returned. If you do this, you can specify only one <code>userId</code>
        /// or one <code>groupId</code>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPermissions service method.</param>
        /// 
        /// <returns>The response from the ListPermissions service method, as returned by ManagedGrafana.</returns>
        /// <exception cref="Amazon.ManagedGrafana.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.InternalServerException">
        /// Unexpected error while processing the request. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ThrottlingException">
        /// The request was denied because of request throttling. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ValidationException">
        /// The value of a parameter in the request caused an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/grafana-2020-08-18/ListPermissions">REST API Reference for ListPermissions Operation</seealso>
        ListPermissionsResponse ListPermissions(ListPermissionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListPermissions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListPermissions operation on AmazonManagedGrafanaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListPermissions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/grafana-2020-08-18/ListPermissions">REST API Reference for ListPermissions Operation</seealso>
        IAsyncResult BeginListPermissions(ListPermissionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListPermissions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListPermissions.</param>
        /// 
        /// <returns>Returns a  ListPermissionsResult from ManagedGrafana.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/grafana-2020-08-18/ListPermissions">REST API Reference for ListPermissions Operation</seealso>
        ListPermissionsResponse EndListPermissions(IAsyncResult asyncResult);

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// The <code>ListTagsForResource</code> operation returns the tags that are associated
        /// with the Amazon Managed Service for Grafana resource specified by the <code>resourceArn</code>.
        /// Currently, the only resource that can be tagged is a workspace.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by ManagedGrafana.</returns>
        /// <exception cref="Amazon.ManagedGrafana.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.InternalServerException">
        /// Unexpected error while processing the request. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ThrottlingException">
        /// The request was denied because of request throttling. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ValidationException">
        /// The value of a parameter in the request caused an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/grafana-2020-08-18/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonManagedGrafanaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/grafana-2020-08-18/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        IAsyncResult BeginListTagsForResource(ListTagsForResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTagsForResource.</param>
        /// 
        /// <returns>Returns a  ListTagsForResourceResult from ManagedGrafana.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/grafana-2020-08-18/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult);

        #endregion
        
        #region  ListWorkspaces


        /// <summary>
        /// Returns a list of Amazon Managed Grafana workspaces in the account, with some information
        /// about each workspace. For more complete information about one workspace, use <a href="https://docs.aws.amazon.com/AAMG/latest/APIReference/API_DescribeWorkspace.html">DescribeWorkspace</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListWorkspaces service method.</param>
        /// 
        /// <returns>The response from the ListWorkspaces service method, as returned by ManagedGrafana.</returns>
        /// <exception cref="Amazon.ManagedGrafana.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.InternalServerException">
        /// Unexpected error while processing the request. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ThrottlingException">
        /// The request was denied because of request throttling. Retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/grafana-2020-08-18/ListWorkspaces">REST API Reference for ListWorkspaces Operation</seealso>
        ListWorkspacesResponse ListWorkspaces(ListWorkspacesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListWorkspaces operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListWorkspaces operation on AmazonManagedGrafanaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListWorkspaces
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/grafana-2020-08-18/ListWorkspaces">REST API Reference for ListWorkspaces Operation</seealso>
        IAsyncResult BeginListWorkspaces(ListWorkspacesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListWorkspaces operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListWorkspaces.</param>
        /// 
        /// <returns>Returns a  ListWorkspacesResult from ManagedGrafana.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/grafana-2020-08-18/ListWorkspaces">REST API Reference for ListWorkspaces Operation</seealso>
        ListWorkspacesResponse EndListWorkspaces(IAsyncResult asyncResult);

        #endregion
        
        #region  TagResource


        /// <summary>
        /// The <code>TagResource</code> operation associates tags with an Amazon Managed Grafana
        /// resource. Currently, the only resource that can be tagged is workspaces. 
        /// 
        ///  
        /// <para>
        /// If you specify a new tag key for the resource, this tag is appended to the list of
        /// tags associated with the resource. If you specify a tag key that is already associated
        /// with the resource, the new tag value that you specify replaces the previous value
        /// for that tag.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by ManagedGrafana.</returns>
        /// <exception cref="Amazon.ManagedGrafana.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.InternalServerException">
        /// Unexpected error while processing the request. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ThrottlingException">
        /// The request was denied because of request throttling. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ValidationException">
        /// The value of a parameter in the request caused an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/grafana-2020-08-18/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse TagResource(TagResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the TagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonManagedGrafanaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/grafana-2020-08-18/TagResource">REST API Reference for TagResource Operation</seealso>
        IAsyncResult BeginTagResource(TagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  TagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTagResource.</param>
        /// 
        /// <returns>Returns a  TagResourceResult from ManagedGrafana.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/grafana-2020-08-18/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse EndTagResource(IAsyncResult asyncResult);

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// The <code>UntagResource</code> operation removes the association of the tag with the
        /// Amazon Managed Grafana resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by ManagedGrafana.</returns>
        /// <exception cref="Amazon.ManagedGrafana.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.InternalServerException">
        /// Unexpected error while processing the request. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ThrottlingException">
        /// The request was denied because of request throttling. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ValidationException">
        /// The value of a parameter in the request caused an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/grafana-2020-08-18/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse UntagResource(UntagResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UntagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonManagedGrafanaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/grafana-2020-08-18/UntagResource">REST API Reference for UntagResource Operation</seealso>
        IAsyncResult BeginUntagResource(UntagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UntagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUntagResource.</param>
        /// 
        /// <returns>Returns a  UntagResourceResult from ManagedGrafana.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/grafana-2020-08-18/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse EndUntagResource(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdatePermissions


        /// <summary>
        /// Updates which users in a workspace have the Grafana <code>Admin</code> or <code>Editor</code>
        /// roles.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdatePermissions service method.</param>
        /// 
        /// <returns>The response from the UpdatePermissions service method, as returned by ManagedGrafana.</returns>
        /// <exception cref="Amazon.ManagedGrafana.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.InternalServerException">
        /// Unexpected error while processing the request. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ThrottlingException">
        /// The request was denied because of request throttling. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ValidationException">
        /// The value of a parameter in the request caused an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/grafana-2020-08-18/UpdatePermissions">REST API Reference for UpdatePermissions Operation</seealso>
        UpdatePermissionsResponse UpdatePermissions(UpdatePermissionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdatePermissions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdatePermissions operation on AmazonManagedGrafanaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdatePermissions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/grafana-2020-08-18/UpdatePermissions">REST API Reference for UpdatePermissions Operation</seealso>
        IAsyncResult BeginUpdatePermissions(UpdatePermissionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdatePermissions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdatePermissions.</param>
        /// 
        /// <returns>Returns a  UpdatePermissionsResult from ManagedGrafana.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/grafana-2020-08-18/UpdatePermissions">REST API Reference for UpdatePermissions Operation</seealso>
        UpdatePermissionsResponse EndUpdatePermissions(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateWorkspace


        /// <summary>
        /// Modifies an existing Amazon Managed Grafana workspace. If you use this operation and
        /// omit any optional parameters, the existing values of those parameters are not changed.
        /// 
        ///  
        /// <para>
        /// To modify the user authentication methods that the workspace uses, such as SAML or
        /// IAM Identity Center, use <a href="https://docs.aws.amazon.com/grafana/latest/APIReference/API_UpdateWorkspaceAuthentication.html">UpdateWorkspaceAuthentication</a>.
        /// </para>
        ///  
        /// <para>
        /// To modify which users in the workspace have the <code>Admin</code> and <code>Editor</code>
        /// Grafana roles, use <a href="https://docs.aws.amazon.com/grafana/latest/APIReference/API_UpdatePermissions.html">UpdatePermissions</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateWorkspace service method.</param>
        /// 
        /// <returns>The response from the UpdateWorkspace service method, as returned by ManagedGrafana.</returns>
        /// <exception cref="Amazon.ManagedGrafana.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ConflictException">
        /// A resource was in an inconsistent state during an update or a deletion.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.InternalServerException">
        /// Unexpected error while processing the request. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ThrottlingException">
        /// The request was denied because of request throttling. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ValidationException">
        /// The value of a parameter in the request caused an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/grafana-2020-08-18/UpdateWorkspace">REST API Reference for UpdateWorkspace Operation</seealso>
        UpdateWorkspaceResponse UpdateWorkspace(UpdateWorkspaceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateWorkspace operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateWorkspace operation on AmazonManagedGrafanaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateWorkspace
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/grafana-2020-08-18/UpdateWorkspace">REST API Reference for UpdateWorkspace Operation</seealso>
        IAsyncResult BeginUpdateWorkspace(UpdateWorkspaceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateWorkspace operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateWorkspace.</param>
        /// 
        /// <returns>Returns a  UpdateWorkspaceResult from ManagedGrafana.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/grafana-2020-08-18/UpdateWorkspace">REST API Reference for UpdateWorkspace Operation</seealso>
        UpdateWorkspaceResponse EndUpdateWorkspace(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateWorkspaceAuthentication


        /// <summary>
        /// Use this operation to define the identity provider (IdP) that this workspace authenticates
        /// users from, using SAML. You can also map SAML assertion attributes to workspace user
        /// information and define which groups in the assertion attribute are to have the <code>Admin</code>
        /// and <code>Editor</code> roles in the workspace.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateWorkspaceAuthentication service method.</param>
        /// 
        /// <returns>The response from the UpdateWorkspaceAuthentication service method, as returned by ManagedGrafana.</returns>
        /// <exception cref="Amazon.ManagedGrafana.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ConflictException">
        /// A resource was in an inconsistent state during an update or a deletion.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.InternalServerException">
        /// Unexpected error while processing the request. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ThrottlingException">
        /// The request was denied because of request throttling. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ValidationException">
        /// The value of a parameter in the request caused an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/grafana-2020-08-18/UpdateWorkspaceAuthentication">REST API Reference for UpdateWorkspaceAuthentication Operation</seealso>
        UpdateWorkspaceAuthenticationResponse UpdateWorkspaceAuthentication(UpdateWorkspaceAuthenticationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateWorkspaceAuthentication operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateWorkspaceAuthentication operation on AmazonManagedGrafanaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateWorkspaceAuthentication
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/grafana-2020-08-18/UpdateWorkspaceAuthentication">REST API Reference for UpdateWorkspaceAuthentication Operation</seealso>
        IAsyncResult BeginUpdateWorkspaceAuthentication(UpdateWorkspaceAuthenticationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateWorkspaceAuthentication operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateWorkspaceAuthentication.</param>
        /// 
        /// <returns>Returns a  UpdateWorkspaceAuthenticationResult from ManagedGrafana.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/grafana-2020-08-18/UpdateWorkspaceAuthentication">REST API Reference for UpdateWorkspaceAuthentication Operation</seealso>
        UpdateWorkspaceAuthenticationResponse EndUpdateWorkspaceAuthentication(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateWorkspaceConfiguration


        /// <summary>
        /// Updates the configuration string for the given workspace
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateWorkspaceConfiguration service method.</param>
        /// 
        /// <returns>The response from the UpdateWorkspaceConfiguration service method, as returned by ManagedGrafana.</returns>
        /// <exception cref="Amazon.ManagedGrafana.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ConflictException">
        /// A resource was in an inconsistent state during an update or a deletion.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.InternalServerException">
        /// Unexpected error while processing the request. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ThrottlingException">
        /// The request was denied because of request throttling. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ValidationException">
        /// The value of a parameter in the request caused an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/grafana-2020-08-18/UpdateWorkspaceConfiguration">REST API Reference for UpdateWorkspaceConfiguration Operation</seealso>
        UpdateWorkspaceConfigurationResponse UpdateWorkspaceConfiguration(UpdateWorkspaceConfigurationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateWorkspaceConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateWorkspaceConfiguration operation on AmazonManagedGrafanaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateWorkspaceConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/grafana-2020-08-18/UpdateWorkspaceConfiguration">REST API Reference for UpdateWorkspaceConfiguration Operation</seealso>
        IAsyncResult BeginUpdateWorkspaceConfiguration(UpdateWorkspaceConfigurationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateWorkspaceConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateWorkspaceConfiguration.</param>
        /// 
        /// <returns>Returns a  UpdateWorkspaceConfigurationResult from ManagedGrafana.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/grafana-2020-08-18/UpdateWorkspaceConfiguration">REST API Reference for UpdateWorkspaceConfiguration Operation</seealso>
        UpdateWorkspaceConfigurationResponse EndUpdateWorkspaceConfiguration(IAsyncResult asyncResult);

        #endregion
        
    }
}