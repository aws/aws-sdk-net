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
 * Do not modify this file. This file is generated from the finspace-data-2020-07-13.normal.json service model.
 */


using System;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.FinSpaceData.Model;

namespace Amazon.FinSpaceData
{
    /// <summary>
    /// Interface for accessing FinSpaceData
    ///
    /// The FinSpace APIs let you take actions inside the FinSpace.
    /// </summary>
    public partial interface IAmazonFinSpaceData : IAmazonService, IDisposable
    {


#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        IFinSpaceDataPaginatorFactory Paginators { get; }
#endif


        
        #region  CreateChangeset


        /// <summary>
        /// Creates a new Changeset in a FinSpace Dataset.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateChangeset service method.</param>
        /// 
        /// <returns>The response from the CreateChangeset service method, as returned by FinSpaceData.</returns>
        /// <exception cref="Amazon.FinSpaceData.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.FinSpaceData.Model.ConflictException">
        /// The request conflicts with an existing resource.
        /// </exception>
        /// <exception cref="Amazon.FinSpaceData.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.FinSpaceData.Model.LimitExceededException">
        /// A limit has exceeded.
        /// </exception>
        /// <exception cref="Amazon.FinSpaceData.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.FinSpaceData.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.FinSpaceData.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2020-07-13/CreateChangeset">REST API Reference for CreateChangeset Operation</seealso>
        CreateChangesetResponse CreateChangeset(CreateChangesetRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateChangeset operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateChangeset operation on AmazonFinSpaceDataClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateChangeset
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2020-07-13/CreateChangeset">REST API Reference for CreateChangeset Operation</seealso>
        IAsyncResult BeginCreateChangeset(CreateChangesetRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateChangeset operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateChangeset.</param>
        /// 
        /// <returns>Returns a  CreateChangesetResult from FinSpaceData.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2020-07-13/CreateChangeset">REST API Reference for CreateChangeset Operation</seealso>
        CreateChangesetResponse EndCreateChangeset(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateDataset


        /// <summary>
        /// Creates a new FinSpace Dataset.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDataset service method.</param>
        /// 
        /// <returns>The response from the CreateDataset service method, as returned by FinSpaceData.</returns>
        /// <exception cref="Amazon.FinSpaceData.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.FinSpaceData.Model.ConflictException">
        /// The request conflicts with an existing resource.
        /// </exception>
        /// <exception cref="Amazon.FinSpaceData.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.FinSpaceData.Model.LimitExceededException">
        /// A limit has exceeded.
        /// </exception>
        /// <exception cref="Amazon.FinSpaceData.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.FinSpaceData.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.FinSpaceData.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2020-07-13/CreateDataset">REST API Reference for CreateDataset Operation</seealso>
        CreateDatasetResponse CreateDataset(CreateDatasetRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateDataset operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDataset operation on AmazonFinSpaceDataClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateDataset
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2020-07-13/CreateDataset">REST API Reference for CreateDataset Operation</seealso>
        IAsyncResult BeginCreateDataset(CreateDatasetRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateDataset operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateDataset.</param>
        /// 
        /// <returns>Returns a  CreateDatasetResult from FinSpaceData.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2020-07-13/CreateDataset">REST API Reference for CreateDataset Operation</seealso>
        CreateDatasetResponse EndCreateDataset(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateDataView


        /// <summary>
        /// Creates a Dataview for a Dataset.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDataView service method.</param>
        /// 
        /// <returns>The response from the CreateDataView service method, as returned by FinSpaceData.</returns>
        /// <exception cref="Amazon.FinSpaceData.Model.ConflictException">
        /// The request conflicts with an existing resource.
        /// </exception>
        /// <exception cref="Amazon.FinSpaceData.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.FinSpaceData.Model.LimitExceededException">
        /// A limit has exceeded.
        /// </exception>
        /// <exception cref="Amazon.FinSpaceData.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.FinSpaceData.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.FinSpaceData.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2020-07-13/CreateDataView">REST API Reference for CreateDataView Operation</seealso>
        CreateDataViewResponse CreateDataView(CreateDataViewRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateDataView operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDataView operation on AmazonFinSpaceDataClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateDataView
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2020-07-13/CreateDataView">REST API Reference for CreateDataView Operation</seealso>
        IAsyncResult BeginCreateDataView(CreateDataViewRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateDataView operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateDataView.</param>
        /// 
        /// <returns>Returns a  CreateDataViewResult from FinSpaceData.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2020-07-13/CreateDataView">REST API Reference for CreateDataView Operation</seealso>
        CreateDataViewResponse EndCreateDataView(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteDataset


        /// <summary>
        /// Deletes a FinSpace Dataset.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDataset service method.</param>
        /// 
        /// <returns>The response from the DeleteDataset service method, as returned by FinSpaceData.</returns>
        /// <exception cref="Amazon.FinSpaceData.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.FinSpaceData.Model.ConflictException">
        /// The request conflicts with an existing resource.
        /// </exception>
        /// <exception cref="Amazon.FinSpaceData.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.FinSpaceData.Model.LimitExceededException">
        /// A limit has exceeded.
        /// </exception>
        /// <exception cref="Amazon.FinSpaceData.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.FinSpaceData.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.FinSpaceData.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2020-07-13/DeleteDataset">REST API Reference for DeleteDataset Operation</seealso>
        DeleteDatasetResponse DeleteDataset(DeleteDatasetRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDataset operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDataset operation on AmazonFinSpaceDataClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteDataset
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2020-07-13/DeleteDataset">REST API Reference for DeleteDataset Operation</seealso>
        IAsyncResult BeginDeleteDataset(DeleteDatasetRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteDataset operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteDataset.</param>
        /// 
        /// <returns>Returns a  DeleteDatasetResult from FinSpaceData.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2020-07-13/DeleteDataset">REST API Reference for DeleteDataset Operation</seealso>
        DeleteDatasetResponse EndDeleteDataset(IAsyncResult asyncResult);

        #endregion
        
        #region  GetChangeset


        /// <summary>
        /// Get information about a Changeset.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetChangeset service method.</param>
        /// 
        /// <returns>The response from the GetChangeset service method, as returned by FinSpaceData.</returns>
        /// <exception cref="Amazon.FinSpaceData.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.FinSpaceData.Model.ConflictException">
        /// The request conflicts with an existing resource.
        /// </exception>
        /// <exception cref="Amazon.FinSpaceData.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.FinSpaceData.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.FinSpaceData.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.FinSpaceData.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2020-07-13/GetChangeset">REST API Reference for GetChangeset Operation</seealso>
        GetChangesetResponse GetChangeset(GetChangesetRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetChangeset operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetChangeset operation on AmazonFinSpaceDataClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetChangeset
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2020-07-13/GetChangeset">REST API Reference for GetChangeset Operation</seealso>
        IAsyncResult BeginGetChangeset(GetChangesetRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetChangeset operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetChangeset.</param>
        /// 
        /// <returns>Returns a  GetChangesetResult from FinSpaceData.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2020-07-13/GetChangeset">REST API Reference for GetChangeset Operation</seealso>
        GetChangesetResponse EndGetChangeset(IAsyncResult asyncResult);

        #endregion
        
        #region  GetDataset


        /// <summary>
        /// Returns information about a Dataset.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDataset service method.</param>
        /// 
        /// <returns>The response from the GetDataset service method, as returned by FinSpaceData.</returns>
        /// <exception cref="Amazon.FinSpaceData.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.FinSpaceData.Model.ConflictException">
        /// The request conflicts with an existing resource.
        /// </exception>
        /// <exception cref="Amazon.FinSpaceData.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.FinSpaceData.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.FinSpaceData.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.FinSpaceData.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2020-07-13/GetDataset">REST API Reference for GetDataset Operation</seealso>
        GetDatasetResponse GetDataset(GetDatasetRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetDataset operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDataset operation on AmazonFinSpaceDataClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetDataset
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2020-07-13/GetDataset">REST API Reference for GetDataset Operation</seealso>
        IAsyncResult BeginGetDataset(GetDatasetRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetDataset operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDataset.</param>
        /// 
        /// <returns>Returns a  GetDatasetResult from FinSpaceData.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2020-07-13/GetDataset">REST API Reference for GetDataset Operation</seealso>
        GetDatasetResponse EndGetDataset(IAsyncResult asyncResult);

        #endregion
        
        #region  GetDataView


        /// <summary>
        /// Gets information about a Dataview.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDataView service method.</param>
        /// 
        /// <returns>The response from the GetDataView service method, as returned by FinSpaceData.</returns>
        /// <exception cref="Amazon.FinSpaceData.Model.ConflictException">
        /// The request conflicts with an existing resource.
        /// </exception>
        /// <exception cref="Amazon.FinSpaceData.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.FinSpaceData.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.FinSpaceData.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.FinSpaceData.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2020-07-13/GetDataView">REST API Reference for GetDataView Operation</seealso>
        GetDataViewResponse GetDataView(GetDataViewRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetDataView operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDataView operation on AmazonFinSpaceDataClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetDataView
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2020-07-13/GetDataView">REST API Reference for GetDataView Operation</seealso>
        IAsyncResult BeginGetDataView(GetDataViewRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetDataView operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDataView.</param>
        /// 
        /// <returns>Returns a  GetDataViewResult from FinSpaceData.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2020-07-13/GetDataView">REST API Reference for GetDataView Operation</seealso>
        GetDataViewResponse EndGetDataView(IAsyncResult asyncResult);

        #endregion
        
        #region  GetProgrammaticAccessCredentials


        /// <summary>
        /// Request programmatic credentials to use with FinSpace SDK.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetProgrammaticAccessCredentials service method.</param>
        /// 
        /// <returns>The response from the GetProgrammaticAccessCredentials service method, as returned by FinSpaceData.</returns>
        /// <exception cref="Amazon.FinSpaceData.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.FinSpaceData.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.FinSpaceData.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.FinSpaceData.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2020-07-13/GetProgrammaticAccessCredentials">REST API Reference for GetProgrammaticAccessCredentials Operation</seealso>
        GetProgrammaticAccessCredentialsResponse GetProgrammaticAccessCredentials(GetProgrammaticAccessCredentialsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetProgrammaticAccessCredentials operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetProgrammaticAccessCredentials operation on AmazonFinSpaceDataClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetProgrammaticAccessCredentials
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2020-07-13/GetProgrammaticAccessCredentials">REST API Reference for GetProgrammaticAccessCredentials Operation</seealso>
        IAsyncResult BeginGetProgrammaticAccessCredentials(GetProgrammaticAccessCredentialsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetProgrammaticAccessCredentials operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetProgrammaticAccessCredentials.</param>
        /// 
        /// <returns>Returns a  GetProgrammaticAccessCredentialsResult from FinSpaceData.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2020-07-13/GetProgrammaticAccessCredentials">REST API Reference for GetProgrammaticAccessCredentials Operation</seealso>
        GetProgrammaticAccessCredentialsResponse EndGetProgrammaticAccessCredentials(IAsyncResult asyncResult);

        #endregion
        
        #region  GetWorkingLocation


        /// <summary>
        /// A temporary Amazon S3 location, where you can copy your files from a source location
        /// to stage or use as a scratch space in FinSpace notebook.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetWorkingLocation service method.</param>
        /// 
        /// <returns>The response from the GetWorkingLocation service method, as returned by FinSpaceData.</returns>
        /// <exception cref="Amazon.FinSpaceData.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.FinSpaceData.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.FinSpaceData.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.FinSpaceData.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2020-07-13/GetWorkingLocation">REST API Reference for GetWorkingLocation Operation</seealso>
        GetWorkingLocationResponse GetWorkingLocation(GetWorkingLocationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetWorkingLocation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetWorkingLocation operation on AmazonFinSpaceDataClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetWorkingLocation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2020-07-13/GetWorkingLocation">REST API Reference for GetWorkingLocation Operation</seealso>
        IAsyncResult BeginGetWorkingLocation(GetWorkingLocationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetWorkingLocation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetWorkingLocation.</param>
        /// 
        /// <returns>Returns a  GetWorkingLocationResult from FinSpaceData.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2020-07-13/GetWorkingLocation">REST API Reference for GetWorkingLocation Operation</seealso>
        GetWorkingLocationResponse EndGetWorkingLocation(IAsyncResult asyncResult);

        #endregion
        
        #region  ListChangesets


        /// <summary>
        /// Lists the FinSpace Changesets for a Dataset.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListChangesets service method.</param>
        /// 
        /// <returns>The response from the ListChangesets service method, as returned by FinSpaceData.</returns>
        /// <exception cref="Amazon.FinSpaceData.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.FinSpaceData.Model.ConflictException">
        /// The request conflicts with an existing resource.
        /// </exception>
        /// <exception cref="Amazon.FinSpaceData.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.FinSpaceData.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.FinSpaceData.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.FinSpaceData.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2020-07-13/ListChangesets">REST API Reference for ListChangesets Operation</seealso>
        ListChangesetsResponse ListChangesets(ListChangesetsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListChangesets operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListChangesets operation on AmazonFinSpaceDataClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListChangesets
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2020-07-13/ListChangesets">REST API Reference for ListChangesets Operation</seealso>
        IAsyncResult BeginListChangesets(ListChangesetsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListChangesets operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListChangesets.</param>
        /// 
        /// <returns>Returns a  ListChangesetsResult from FinSpaceData.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2020-07-13/ListChangesets">REST API Reference for ListChangesets Operation</seealso>
        ListChangesetsResponse EndListChangesets(IAsyncResult asyncResult);

        #endregion
        
        #region  ListDatasets


        /// <summary>
        /// Lists all of the active Datasets that a user has access to.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDatasets service method.</param>
        /// 
        /// <returns>The response from the ListDatasets service method, as returned by FinSpaceData.</returns>
        /// <exception cref="Amazon.FinSpaceData.Model.ConflictException">
        /// The request conflicts with an existing resource.
        /// </exception>
        /// <exception cref="Amazon.FinSpaceData.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.FinSpaceData.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.FinSpaceData.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.FinSpaceData.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2020-07-13/ListDatasets">REST API Reference for ListDatasets Operation</seealso>
        ListDatasetsResponse ListDatasets(ListDatasetsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListDatasets operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDatasets operation on AmazonFinSpaceDataClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListDatasets
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2020-07-13/ListDatasets">REST API Reference for ListDatasets Operation</seealso>
        IAsyncResult BeginListDatasets(ListDatasetsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListDatasets operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListDatasets.</param>
        /// 
        /// <returns>Returns a  ListDatasetsResult from FinSpaceData.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2020-07-13/ListDatasets">REST API Reference for ListDatasets Operation</seealso>
        ListDatasetsResponse EndListDatasets(IAsyncResult asyncResult);

        #endregion
        
        #region  ListDataViews


        /// <summary>
        /// Lists all available Dataviews for a Dataset.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDataViews service method.</param>
        /// 
        /// <returns>The response from the ListDataViews service method, as returned by FinSpaceData.</returns>
        /// <exception cref="Amazon.FinSpaceData.Model.ConflictException">
        /// The request conflicts with an existing resource.
        /// </exception>
        /// <exception cref="Amazon.FinSpaceData.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.FinSpaceData.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.FinSpaceData.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.FinSpaceData.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2020-07-13/ListDataViews">REST API Reference for ListDataViews Operation</seealso>
        ListDataViewsResponse ListDataViews(ListDataViewsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListDataViews operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDataViews operation on AmazonFinSpaceDataClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListDataViews
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2020-07-13/ListDataViews">REST API Reference for ListDataViews Operation</seealso>
        IAsyncResult BeginListDataViews(ListDataViewsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListDataViews operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListDataViews.</param>
        /// 
        /// <returns>Returns a  ListDataViewsResult from FinSpaceData.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2020-07-13/ListDataViews">REST API Reference for ListDataViews Operation</seealso>
        ListDataViewsResponse EndListDataViews(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateChangeset


        /// <summary>
        /// Updates a FinSpace Changeset.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateChangeset service method.</param>
        /// 
        /// <returns>The response from the UpdateChangeset service method, as returned by FinSpaceData.</returns>
        /// <exception cref="Amazon.FinSpaceData.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.FinSpaceData.Model.ConflictException">
        /// The request conflicts with an existing resource.
        /// </exception>
        /// <exception cref="Amazon.FinSpaceData.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.FinSpaceData.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.FinSpaceData.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.FinSpaceData.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2020-07-13/UpdateChangeset">REST API Reference for UpdateChangeset Operation</seealso>
        UpdateChangesetResponse UpdateChangeset(UpdateChangesetRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateChangeset operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateChangeset operation on AmazonFinSpaceDataClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateChangeset
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2020-07-13/UpdateChangeset">REST API Reference for UpdateChangeset Operation</seealso>
        IAsyncResult BeginUpdateChangeset(UpdateChangesetRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateChangeset operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateChangeset.</param>
        /// 
        /// <returns>Returns a  UpdateChangesetResult from FinSpaceData.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2020-07-13/UpdateChangeset">REST API Reference for UpdateChangeset Operation</seealso>
        UpdateChangesetResponse EndUpdateChangeset(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateDataset


        /// <summary>
        /// Updates a FinSpace Dataset.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDataset service method.</param>
        /// 
        /// <returns>The response from the UpdateDataset service method, as returned by FinSpaceData.</returns>
        /// <exception cref="Amazon.FinSpaceData.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.FinSpaceData.Model.ConflictException">
        /// The request conflicts with an existing resource.
        /// </exception>
        /// <exception cref="Amazon.FinSpaceData.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.FinSpaceData.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.FinSpaceData.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.FinSpaceData.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2020-07-13/UpdateDataset">REST API Reference for UpdateDataset Operation</seealso>
        UpdateDatasetResponse UpdateDataset(UpdateDatasetRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateDataset operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateDataset operation on AmazonFinSpaceDataClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateDataset
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2020-07-13/UpdateDataset">REST API Reference for UpdateDataset Operation</seealso>
        IAsyncResult BeginUpdateDataset(UpdateDatasetRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateDataset operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateDataset.</param>
        /// 
        /// <returns>Returns a  UpdateDatasetResult from FinSpaceData.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2020-07-13/UpdateDataset">REST API Reference for UpdateDataset Operation</seealso>
        UpdateDatasetResponse EndUpdateDataset(IAsyncResult asyncResult);

        #endregion
        
    }
}