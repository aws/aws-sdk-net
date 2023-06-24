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
 * Do not modify this file. This file is generated from the ssm-sap-2018-05-10.normal.json service model.
 */


using System;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.SsmSap.Model;

namespace Amazon.SsmSap
{
    /// <summary>
    /// Interface for accessing SsmSap
    ///
    /// This API reference provides descriptions, syntax, and other details about each of
    /// the actions and data types for AWS Systems Manager for SAP. The topic for each action
    /// shows the API request parameters and responses.
    /// </summary>
    public partial interface IAmazonSsmSap : IAmazonService, IDisposable
    {


#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        ISsmSapPaginatorFactory Paginators { get; }
#endif


        
        #region  DeleteResourcePermission


        /// <summary>
        /// Removes permissions associated with the target database.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteResourcePermission service method.</param>
        /// 
        /// <returns>The response from the DeleteResourcePermission service method, as returned by SsmSap.</returns>
        /// <exception cref="Amazon.SsmSap.Model.InternalServerException">
        /// An internal error has occurred.
        /// </exception>
        /// <exception cref="Amazon.SsmSap.Model.ResourceNotFoundException">
        /// The resource is not available.
        /// </exception>
        /// <exception cref="Amazon.SsmSap.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-sap-2018-05-10/DeleteResourcePermission">REST API Reference for DeleteResourcePermission Operation</seealso>
        DeleteResourcePermissionResponse DeleteResourcePermission(DeleteResourcePermissionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteResourcePermission operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteResourcePermission operation on AmazonSsmSapClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteResourcePermission
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-sap-2018-05-10/DeleteResourcePermission">REST API Reference for DeleteResourcePermission Operation</seealso>
        IAsyncResult BeginDeleteResourcePermission(DeleteResourcePermissionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteResourcePermission operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteResourcePermission.</param>
        /// 
        /// <returns>Returns a  DeleteResourcePermissionResult from SsmSap.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-sap-2018-05-10/DeleteResourcePermission">REST API Reference for DeleteResourcePermission Operation</seealso>
        DeleteResourcePermissionResponse EndDeleteResourcePermission(IAsyncResult asyncResult);

        #endregion
        
        #region  DeregisterApplication


        /// <summary>
        /// Deregister an SAP application with AWS Systems Manager for SAP. This action does not
        /// aﬀect the existing setup of your SAP workloads on Amazon EC2.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeregisterApplication service method.</param>
        /// 
        /// <returns>The response from the DeregisterApplication service method, as returned by SsmSap.</returns>
        /// <exception cref="Amazon.SsmSap.Model.InternalServerException">
        /// An internal error has occurred.
        /// </exception>
        /// <exception cref="Amazon.SsmSap.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-sap-2018-05-10/DeregisterApplication">REST API Reference for DeregisterApplication Operation</seealso>
        DeregisterApplicationResponse DeregisterApplication(DeregisterApplicationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeregisterApplication operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeregisterApplication operation on AmazonSsmSapClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeregisterApplication
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-sap-2018-05-10/DeregisterApplication">REST API Reference for DeregisterApplication Operation</seealso>
        IAsyncResult BeginDeregisterApplication(DeregisterApplicationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeregisterApplication operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeregisterApplication.</param>
        /// 
        /// <returns>Returns a  DeregisterApplicationResult from SsmSap.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-sap-2018-05-10/DeregisterApplication">REST API Reference for DeregisterApplication Operation</seealso>
        DeregisterApplicationResponse EndDeregisterApplication(IAsyncResult asyncResult);

        #endregion
        
        #region  GetApplication


        /// <summary>
        /// Gets an application registered with AWS Systems Manager for SAP. It also returns the
        /// components of the application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetApplication service method.</param>
        /// 
        /// <returns>The response from the GetApplication service method, as returned by SsmSap.</returns>
        /// <exception cref="Amazon.SsmSap.Model.InternalServerException">
        /// An internal error has occurred.
        /// </exception>
        /// <exception cref="Amazon.SsmSap.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-sap-2018-05-10/GetApplication">REST API Reference for GetApplication Operation</seealso>
        GetApplicationResponse GetApplication(GetApplicationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetApplication operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetApplication operation on AmazonSsmSapClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetApplication
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-sap-2018-05-10/GetApplication">REST API Reference for GetApplication Operation</seealso>
        IAsyncResult BeginGetApplication(GetApplicationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetApplication operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetApplication.</param>
        /// 
        /// <returns>Returns a  GetApplicationResult from SsmSap.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-sap-2018-05-10/GetApplication">REST API Reference for GetApplication Operation</seealso>
        GetApplicationResponse EndGetApplication(IAsyncResult asyncResult);

        #endregion
        
        #region  GetComponent


        /// <summary>
        /// Gets the component of an application registered with AWS Systems Manager for SAP.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetComponent service method.</param>
        /// 
        /// <returns>The response from the GetComponent service method, as returned by SsmSap.</returns>
        /// <exception cref="Amazon.SsmSap.Model.InternalServerException">
        /// An internal error has occurred.
        /// </exception>
        /// <exception cref="Amazon.SsmSap.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-sap-2018-05-10/GetComponent">REST API Reference for GetComponent Operation</seealso>
        GetComponentResponse GetComponent(GetComponentRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetComponent operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetComponent operation on AmazonSsmSapClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetComponent
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-sap-2018-05-10/GetComponent">REST API Reference for GetComponent Operation</seealso>
        IAsyncResult BeginGetComponent(GetComponentRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetComponent operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetComponent.</param>
        /// 
        /// <returns>Returns a  GetComponentResult from SsmSap.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-sap-2018-05-10/GetComponent">REST API Reference for GetComponent Operation</seealso>
        GetComponentResponse EndGetComponent(IAsyncResult asyncResult);

        #endregion
        
        #region  GetDatabase


        /// <summary>
        /// Gets the SAP HANA database of an application registered with AWS Systems Manager for
        /// SAP.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDatabase service method.</param>
        /// 
        /// <returns>The response from the GetDatabase service method, as returned by SsmSap.</returns>
        /// <exception cref="Amazon.SsmSap.Model.InternalServerException">
        /// An internal error has occurred.
        /// </exception>
        /// <exception cref="Amazon.SsmSap.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-sap-2018-05-10/GetDatabase">REST API Reference for GetDatabase Operation</seealso>
        GetDatabaseResponse GetDatabase(GetDatabaseRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetDatabase operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDatabase operation on AmazonSsmSapClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetDatabase
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-sap-2018-05-10/GetDatabase">REST API Reference for GetDatabase Operation</seealso>
        IAsyncResult BeginGetDatabase(GetDatabaseRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetDatabase operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDatabase.</param>
        /// 
        /// <returns>Returns a  GetDatabaseResult from SsmSap.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-sap-2018-05-10/GetDatabase">REST API Reference for GetDatabase Operation</seealso>
        GetDatabaseResponse EndGetDatabase(IAsyncResult asyncResult);

        #endregion
        
        #region  GetOperation


        /// <summary>
        /// Gets the details of an operation by specifying the operation ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetOperation service method.</param>
        /// 
        /// <returns>The response from the GetOperation service method, as returned by SsmSap.</returns>
        /// <exception cref="Amazon.SsmSap.Model.InternalServerException">
        /// An internal error has occurred.
        /// </exception>
        /// <exception cref="Amazon.SsmSap.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-sap-2018-05-10/GetOperation">REST API Reference for GetOperation Operation</seealso>
        GetOperationResponse GetOperation(GetOperationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetOperation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetOperation operation on AmazonSsmSapClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetOperation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-sap-2018-05-10/GetOperation">REST API Reference for GetOperation Operation</seealso>
        IAsyncResult BeginGetOperation(GetOperationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetOperation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetOperation.</param>
        /// 
        /// <returns>Returns a  GetOperationResult from SsmSap.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-sap-2018-05-10/GetOperation">REST API Reference for GetOperation Operation</seealso>
        GetOperationResponse EndGetOperation(IAsyncResult asyncResult);

        #endregion
        
        #region  GetResourcePermission


        /// <summary>
        /// Gets permissions associated with the target database.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetResourcePermission service method.</param>
        /// 
        /// <returns>The response from the GetResourcePermission service method, as returned by SsmSap.</returns>
        /// <exception cref="Amazon.SsmSap.Model.InternalServerException">
        /// An internal error has occurred.
        /// </exception>
        /// <exception cref="Amazon.SsmSap.Model.ResourceNotFoundException">
        /// The resource is not available.
        /// </exception>
        /// <exception cref="Amazon.SsmSap.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-sap-2018-05-10/GetResourcePermission">REST API Reference for GetResourcePermission Operation</seealso>
        GetResourcePermissionResponse GetResourcePermission(GetResourcePermissionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetResourcePermission operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetResourcePermission operation on AmazonSsmSapClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetResourcePermission
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-sap-2018-05-10/GetResourcePermission">REST API Reference for GetResourcePermission Operation</seealso>
        IAsyncResult BeginGetResourcePermission(GetResourcePermissionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetResourcePermission operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetResourcePermission.</param>
        /// 
        /// <returns>Returns a  GetResourcePermissionResult from SsmSap.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-sap-2018-05-10/GetResourcePermission">REST API Reference for GetResourcePermission Operation</seealso>
        GetResourcePermissionResponse EndGetResourcePermission(IAsyncResult asyncResult);

        #endregion
        
        #region  ListApplications


        /// <summary>
        /// Lists all the applications registered with AWS Systems Manager for SAP.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListApplications service method.</param>
        /// 
        /// <returns>The response from the ListApplications service method, as returned by SsmSap.</returns>
        /// <exception cref="Amazon.SsmSap.Model.InternalServerException">
        /// An internal error has occurred.
        /// </exception>
        /// <exception cref="Amazon.SsmSap.Model.ResourceNotFoundException">
        /// The resource is not available.
        /// </exception>
        /// <exception cref="Amazon.SsmSap.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-sap-2018-05-10/ListApplications">REST API Reference for ListApplications Operation</seealso>
        ListApplicationsResponse ListApplications(ListApplicationsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListApplications operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListApplications operation on AmazonSsmSapClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListApplications
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-sap-2018-05-10/ListApplications">REST API Reference for ListApplications Operation</seealso>
        IAsyncResult BeginListApplications(ListApplicationsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListApplications operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListApplications.</param>
        /// 
        /// <returns>Returns a  ListApplicationsResult from SsmSap.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-sap-2018-05-10/ListApplications">REST API Reference for ListApplications Operation</seealso>
        ListApplicationsResponse EndListApplications(IAsyncResult asyncResult);

        #endregion
        
        #region  ListComponents


        /// <summary>
        /// Lists all the components registered with AWS Systems Manager for SAP.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListComponents service method.</param>
        /// 
        /// <returns>The response from the ListComponents service method, as returned by SsmSap.</returns>
        /// <exception cref="Amazon.SsmSap.Model.InternalServerException">
        /// An internal error has occurred.
        /// </exception>
        /// <exception cref="Amazon.SsmSap.Model.ResourceNotFoundException">
        /// The resource is not available.
        /// </exception>
        /// <exception cref="Amazon.SsmSap.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-sap-2018-05-10/ListComponents">REST API Reference for ListComponents Operation</seealso>
        ListComponentsResponse ListComponents(ListComponentsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListComponents operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListComponents operation on AmazonSsmSapClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListComponents
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-sap-2018-05-10/ListComponents">REST API Reference for ListComponents Operation</seealso>
        IAsyncResult BeginListComponents(ListComponentsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListComponents operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListComponents.</param>
        /// 
        /// <returns>Returns a  ListComponentsResult from SsmSap.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-sap-2018-05-10/ListComponents">REST API Reference for ListComponents Operation</seealso>
        ListComponentsResponse EndListComponents(IAsyncResult asyncResult);

        #endregion
        
        #region  ListDatabases


        /// <summary>
        /// Lists the SAP HANA databases of an application registered with AWS Systems Manager
        /// for SAP.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDatabases service method.</param>
        /// 
        /// <returns>The response from the ListDatabases service method, as returned by SsmSap.</returns>
        /// <exception cref="Amazon.SsmSap.Model.InternalServerException">
        /// An internal error has occurred.
        /// </exception>
        /// <exception cref="Amazon.SsmSap.Model.ResourceNotFoundException">
        /// The resource is not available.
        /// </exception>
        /// <exception cref="Amazon.SsmSap.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-sap-2018-05-10/ListDatabases">REST API Reference for ListDatabases Operation</seealso>
        ListDatabasesResponse ListDatabases(ListDatabasesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListDatabases operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDatabases operation on AmazonSsmSapClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListDatabases
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-sap-2018-05-10/ListDatabases">REST API Reference for ListDatabases Operation</seealso>
        IAsyncResult BeginListDatabases(ListDatabasesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListDatabases operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListDatabases.</param>
        /// 
        /// <returns>Returns a  ListDatabasesResult from SsmSap.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-sap-2018-05-10/ListDatabases">REST API Reference for ListDatabases Operation</seealso>
        ListDatabasesResponse EndListDatabases(IAsyncResult asyncResult);

        #endregion
        
        #region  ListOperations


        /// <summary>
        /// Lists the operations performed by AWS Systems Manager for SAP.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListOperations service method.</param>
        /// 
        /// <returns>The response from the ListOperations service method, as returned by SsmSap.</returns>
        /// <exception cref="Amazon.SsmSap.Model.InternalServerException">
        /// An internal error has occurred.
        /// </exception>
        /// <exception cref="Amazon.SsmSap.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-sap-2018-05-10/ListOperations">REST API Reference for ListOperations Operation</seealso>
        ListOperationsResponse ListOperations(ListOperationsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListOperations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListOperations operation on AmazonSsmSapClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListOperations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-sap-2018-05-10/ListOperations">REST API Reference for ListOperations Operation</seealso>
        IAsyncResult BeginListOperations(ListOperationsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListOperations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListOperations.</param>
        /// 
        /// <returns>Returns a  ListOperationsResult from SsmSap.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-sap-2018-05-10/ListOperations">REST API Reference for ListOperations Operation</seealso>
        ListOperationsResponse EndListOperations(IAsyncResult asyncResult);

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// Lists all tags on an SAP HANA application and/or database registered with AWS Systems
        /// Manager for SAP.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by SsmSap.</returns>
        /// <exception cref="Amazon.SsmSap.Model.ConflictException">
        /// A conflict has occurred.
        /// </exception>
        /// <exception cref="Amazon.SsmSap.Model.ResourceNotFoundException">
        /// The resource is not available.
        /// </exception>
        /// <exception cref="Amazon.SsmSap.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-sap-2018-05-10/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonSsmSapClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-sap-2018-05-10/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        IAsyncResult BeginListTagsForResource(ListTagsForResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTagsForResource.</param>
        /// 
        /// <returns>Returns a  ListTagsForResourceResult from SsmSap.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-sap-2018-05-10/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult);

        #endregion
        
        #region  PutResourcePermission


        /// <summary>
        /// Adds permissions to the target database.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutResourcePermission service method.</param>
        /// 
        /// <returns>The response from the PutResourcePermission service method, as returned by SsmSap.</returns>
        /// <exception cref="Amazon.SsmSap.Model.InternalServerException">
        /// An internal error has occurred.
        /// </exception>
        /// <exception cref="Amazon.SsmSap.Model.ResourceNotFoundException">
        /// The resource is not available.
        /// </exception>
        /// <exception cref="Amazon.SsmSap.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-sap-2018-05-10/PutResourcePermission">REST API Reference for PutResourcePermission Operation</seealso>
        PutResourcePermissionResponse PutResourcePermission(PutResourcePermissionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the PutResourcePermission operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutResourcePermission operation on AmazonSsmSapClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutResourcePermission
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-sap-2018-05-10/PutResourcePermission">REST API Reference for PutResourcePermission Operation</seealso>
        IAsyncResult BeginPutResourcePermission(PutResourcePermissionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  PutResourcePermission operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutResourcePermission.</param>
        /// 
        /// <returns>Returns a  PutResourcePermissionResult from SsmSap.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-sap-2018-05-10/PutResourcePermission">REST API Reference for PutResourcePermission Operation</seealso>
        PutResourcePermissionResponse EndPutResourcePermission(IAsyncResult asyncResult);

        #endregion
        
        #region  RegisterApplication


        /// <summary>
        /// Register an SAP application with AWS Systems Manager for SAP. You must meet the following
        /// requirements before registering. 
        /// 
        ///  
        /// <para>
        /// The SAP application you want to register with AWS Systems Manager for SAP is running
        /// on Amazon EC2.
        /// </para>
        ///  
        /// <para>
        /// AWS Systems Manager Agent must be setup on an Amazon EC2 instance along with the required
        /// IAM permissions.
        /// </para>
        ///  
        /// <para>
        /// Amazon EC2 instance(s) must have access to the secrets created in AWS Secrets Manager
        /// to manage SAP applications and components.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RegisterApplication service method.</param>
        /// 
        /// <returns>The response from the RegisterApplication service method, as returned by SsmSap.</returns>
        /// <exception cref="Amazon.SsmSap.Model.ConflictException">
        /// A conflict has occurred.
        /// </exception>
        /// <exception cref="Amazon.SsmSap.Model.InternalServerException">
        /// An internal error has occurred.
        /// </exception>
        /// <exception cref="Amazon.SsmSap.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-sap-2018-05-10/RegisterApplication">REST API Reference for RegisterApplication Operation</seealso>
        RegisterApplicationResponse RegisterApplication(RegisterApplicationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the RegisterApplication operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RegisterApplication operation on AmazonSsmSapClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRegisterApplication
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-sap-2018-05-10/RegisterApplication">REST API Reference for RegisterApplication Operation</seealso>
        IAsyncResult BeginRegisterApplication(RegisterApplicationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  RegisterApplication operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRegisterApplication.</param>
        /// 
        /// <returns>Returns a  RegisterApplicationResult from SsmSap.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-sap-2018-05-10/RegisterApplication">REST API Reference for RegisterApplication Operation</seealso>
        RegisterApplicationResponse EndRegisterApplication(IAsyncResult asyncResult);

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Creates tag for a resource by specifying the ARN.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by SsmSap.</returns>
        /// <exception cref="Amazon.SsmSap.Model.ConflictException">
        /// A conflict has occurred.
        /// </exception>
        /// <exception cref="Amazon.SsmSap.Model.ResourceNotFoundException">
        /// The resource is not available.
        /// </exception>
        /// <exception cref="Amazon.SsmSap.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-sap-2018-05-10/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse TagResource(TagResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the TagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonSsmSapClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-sap-2018-05-10/TagResource">REST API Reference for TagResource Operation</seealso>
        IAsyncResult BeginTagResource(TagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  TagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTagResource.</param>
        /// 
        /// <returns>Returns a  TagResourceResult from SsmSap.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-sap-2018-05-10/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse EndTagResource(IAsyncResult asyncResult);

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// Delete the tags for a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by SsmSap.</returns>
        /// <exception cref="Amazon.SsmSap.Model.ConflictException">
        /// A conflict has occurred.
        /// </exception>
        /// <exception cref="Amazon.SsmSap.Model.ResourceNotFoundException">
        /// The resource is not available.
        /// </exception>
        /// <exception cref="Amazon.SsmSap.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-sap-2018-05-10/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse UntagResource(UntagResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UntagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonSsmSapClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-sap-2018-05-10/UntagResource">REST API Reference for UntagResource Operation</seealso>
        IAsyncResult BeginUntagResource(UntagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UntagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUntagResource.</param>
        /// 
        /// <returns>Returns a  UntagResourceResult from SsmSap.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-sap-2018-05-10/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse EndUntagResource(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateApplicationSettings


        /// <summary>
        /// Updates the settings of an application registered with AWS Systems Manager for SAP.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateApplicationSettings service method.</param>
        /// 
        /// <returns>The response from the UpdateApplicationSettings service method, as returned by SsmSap.</returns>
        /// <exception cref="Amazon.SsmSap.Model.InternalServerException">
        /// An internal error has occurred.
        /// </exception>
        /// <exception cref="Amazon.SsmSap.Model.ResourceNotFoundException">
        /// The resource is not available.
        /// </exception>
        /// <exception cref="Amazon.SsmSap.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-sap-2018-05-10/UpdateApplicationSettings">REST API Reference for UpdateApplicationSettings Operation</seealso>
        UpdateApplicationSettingsResponse UpdateApplicationSettings(UpdateApplicationSettingsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateApplicationSettings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateApplicationSettings operation on AmazonSsmSapClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateApplicationSettings
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-sap-2018-05-10/UpdateApplicationSettings">REST API Reference for UpdateApplicationSettings Operation</seealso>
        IAsyncResult BeginUpdateApplicationSettings(UpdateApplicationSettingsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateApplicationSettings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateApplicationSettings.</param>
        /// 
        /// <returns>Returns a  UpdateApplicationSettingsResult from SsmSap.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-sap-2018-05-10/UpdateApplicationSettings">REST API Reference for UpdateApplicationSettings Operation</seealso>
        UpdateApplicationSettingsResponse EndUpdateApplicationSettings(IAsyncResult asyncResult);

        #endregion
        
    }
}