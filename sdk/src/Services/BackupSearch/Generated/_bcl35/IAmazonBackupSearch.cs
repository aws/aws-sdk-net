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
 * Do not modify this file. This file is generated from the backupsearch-2018-05-10.normal.json service model.
 */


using System;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.BackupSearch.Model;

#pragma warning disable CS1570
namespace Amazon.BackupSearch
{
    /// <summary>
    /// <para>Interface for accessing BackupSearch</para>
    ///
    /// Backup Search 
    /// <para>
    /// Backup Search is the recovery point and item level search for Backup.
    /// 
    ///  
    /// <para>
    /// For additional information, see:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/aws-backup/latest/devguide/api-reference.html">Backup
    /// API Reference</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/aws-backup/latest/devguide/whatisbackup.html">Backup
    /// Developer Guide</a> 
    /// </para>
    ///  </li> </ul>
    /// </para>
    /// </summary>
    public partial interface IAmazonBackupSearch : IAmazonService, IDisposable
    {


#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        IBackupSearchPaginatorFactory Paginators { get; }
#endif


        
        #region  GetSearchJob


        /// <summary>
        /// This operation retrieves metadata of a search job, including its progress.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSearchJob service method.</param>
        /// 
        /// <returns>The response from the GetSearchJob service method, as returned by BackupSearch.</returns>
        /// <exception cref="Amazon.BackupSearch.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.BackupSearch.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.BackupSearch.Model.ResourceNotFoundException">
        /// The resource was not found for this request.
        /// 
        ///  
        /// <para>
        /// Confirm the resource information, such as the ARN or type is correct and exists, then
        /// retry the request.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.BackupSearch.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.BackupSearch.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by a service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backupsearch-2018-05-10/GetSearchJob">REST API Reference for GetSearchJob Operation</seealso>
        GetSearchJobResponse GetSearchJob(GetSearchJobRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetSearchJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSearchJob operation on AmazonBackupSearchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetSearchJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backupsearch-2018-05-10/GetSearchJob">REST API Reference for GetSearchJob Operation</seealso>
        IAsyncResult BeginGetSearchJob(GetSearchJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetSearchJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetSearchJob.</param>
        /// 
        /// <returns>Returns a  GetSearchJobResult from BackupSearch.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backupsearch-2018-05-10/GetSearchJob">REST API Reference for GetSearchJob Operation</seealso>
        GetSearchJobResponse EndGetSearchJob(IAsyncResult asyncResult);

        #endregion
        
        #region  GetSearchResultExportJob


        /// <summary>
        /// This operation retrieves the metadata of an export job.
        /// 
        ///  
        /// <para>
        /// An export job is an operation that transmits the results of a search job to a specified
        /// S3 bucket in a .csv file.
        /// </para>
        ///  
        /// <para>
        /// An export job allows you to retain results of a search beyond the search job's scheduled
        /// retention of 7 days.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSearchResultExportJob service method.</param>
        /// 
        /// <returns>The response from the GetSearchResultExportJob service method, as returned by BackupSearch.</returns>
        /// <exception cref="Amazon.BackupSearch.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.BackupSearch.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.BackupSearch.Model.ResourceNotFoundException">
        /// The resource was not found for this request.
        /// 
        ///  
        /// <para>
        /// Confirm the resource information, such as the ARN or type is correct and exists, then
        /// retry the request.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.BackupSearch.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.BackupSearch.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by a service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backupsearch-2018-05-10/GetSearchResultExportJob">REST API Reference for GetSearchResultExportJob Operation</seealso>
        GetSearchResultExportJobResponse GetSearchResultExportJob(GetSearchResultExportJobRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetSearchResultExportJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSearchResultExportJob operation on AmazonBackupSearchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetSearchResultExportJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backupsearch-2018-05-10/GetSearchResultExportJob">REST API Reference for GetSearchResultExportJob Operation</seealso>
        IAsyncResult BeginGetSearchResultExportJob(GetSearchResultExportJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetSearchResultExportJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetSearchResultExportJob.</param>
        /// 
        /// <returns>Returns a  GetSearchResultExportJobResult from BackupSearch.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backupsearch-2018-05-10/GetSearchResultExportJob">REST API Reference for GetSearchResultExportJob Operation</seealso>
        GetSearchResultExportJobResponse EndGetSearchResultExportJob(IAsyncResult asyncResult);

        #endregion
        
        #region  ListSearchJobBackups


        /// <summary>
        /// This operation returns a list of all backups (recovery points) in a paginated format
        /// that were included in the search job.
        /// 
        ///  
        /// <para>
        /// If a search does not display an expected backup in the results, you can call this
        /// operation to display each backup included in the search. Any backups that were not
        /// included because they have a <c>FAILED</c> status from a permissions issue will be
        /// displayed, along with a status message.
        /// </para>
        ///  
        /// <para>
        /// Only recovery points with a backup index that has a status of <c>ACTIVE</c> will be
        /// included in search results. If the index has any other status, its status will be
        /// displayed along with a status message.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSearchJobBackups service method.</param>
        /// 
        /// <returns>The response from the ListSearchJobBackups service method, as returned by BackupSearch.</returns>
        /// <exception cref="Amazon.BackupSearch.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.BackupSearch.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.BackupSearch.Model.ResourceNotFoundException">
        /// The resource was not found for this request.
        /// 
        ///  
        /// <para>
        /// Confirm the resource information, such as the ARN or type is correct and exists, then
        /// retry the request.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.BackupSearch.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.BackupSearch.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by a service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backupsearch-2018-05-10/ListSearchJobBackups">REST API Reference for ListSearchJobBackups Operation</seealso>
        ListSearchJobBackupsResponse ListSearchJobBackups(ListSearchJobBackupsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListSearchJobBackups operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListSearchJobBackups operation on AmazonBackupSearchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListSearchJobBackups
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backupsearch-2018-05-10/ListSearchJobBackups">REST API Reference for ListSearchJobBackups Operation</seealso>
        IAsyncResult BeginListSearchJobBackups(ListSearchJobBackupsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListSearchJobBackups operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListSearchJobBackups.</param>
        /// 
        /// <returns>Returns a  ListSearchJobBackupsResult from BackupSearch.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backupsearch-2018-05-10/ListSearchJobBackups">REST API Reference for ListSearchJobBackups Operation</seealso>
        ListSearchJobBackupsResponse EndListSearchJobBackups(IAsyncResult asyncResult);

        #endregion
        
        #region  ListSearchJobResults


        /// <summary>
        /// This operation returns a list of a specified search job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSearchJobResults service method.</param>
        /// 
        /// <returns>The response from the ListSearchJobResults service method, as returned by BackupSearch.</returns>
        /// <exception cref="Amazon.BackupSearch.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.BackupSearch.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.BackupSearch.Model.ResourceNotFoundException">
        /// The resource was not found for this request.
        /// 
        ///  
        /// <para>
        /// Confirm the resource information, such as the ARN or type is correct and exists, then
        /// retry the request.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.BackupSearch.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.BackupSearch.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by a service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backupsearch-2018-05-10/ListSearchJobResults">REST API Reference for ListSearchJobResults Operation</seealso>
        ListSearchJobResultsResponse ListSearchJobResults(ListSearchJobResultsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListSearchJobResults operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListSearchJobResults operation on AmazonBackupSearchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListSearchJobResults
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backupsearch-2018-05-10/ListSearchJobResults">REST API Reference for ListSearchJobResults Operation</seealso>
        IAsyncResult BeginListSearchJobResults(ListSearchJobResultsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListSearchJobResults operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListSearchJobResults.</param>
        /// 
        /// <returns>Returns a  ListSearchJobResultsResult from BackupSearch.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backupsearch-2018-05-10/ListSearchJobResults">REST API Reference for ListSearchJobResults Operation</seealso>
        ListSearchJobResultsResponse EndListSearchJobResults(IAsyncResult asyncResult);

        #endregion
        
        #region  ListSearchJobs


        /// <summary>
        /// This operation returns a list of search jobs belonging to an account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSearchJobs service method.</param>
        /// 
        /// <returns>The response from the ListSearchJobs service method, as returned by BackupSearch.</returns>
        /// <exception cref="Amazon.BackupSearch.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.BackupSearch.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.BackupSearch.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.BackupSearch.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by a service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backupsearch-2018-05-10/ListSearchJobs">REST API Reference for ListSearchJobs Operation</seealso>
        ListSearchJobsResponse ListSearchJobs(ListSearchJobsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListSearchJobs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListSearchJobs operation on AmazonBackupSearchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListSearchJobs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backupsearch-2018-05-10/ListSearchJobs">REST API Reference for ListSearchJobs Operation</seealso>
        IAsyncResult BeginListSearchJobs(ListSearchJobsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListSearchJobs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListSearchJobs.</param>
        /// 
        /// <returns>Returns a  ListSearchJobsResult from BackupSearch.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backupsearch-2018-05-10/ListSearchJobs">REST API Reference for ListSearchJobs Operation</seealso>
        ListSearchJobsResponse EndListSearchJobs(IAsyncResult asyncResult);

        #endregion
        
        #region  ListSearchResultExportJobs


        /// <summary>
        /// This operation exports search results of a search job to a specified destination S3
        /// bucket.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSearchResultExportJobs service method.</param>
        /// 
        /// <returns>The response from the ListSearchResultExportJobs service method, as returned by BackupSearch.</returns>
        /// <exception cref="Amazon.BackupSearch.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.BackupSearch.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.BackupSearch.Model.ResourceNotFoundException">
        /// The resource was not found for this request.
        /// 
        ///  
        /// <para>
        /// Confirm the resource information, such as the ARN or type is correct and exists, then
        /// retry the request.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.BackupSearch.Model.ServiceQuotaExceededException">
        /// The request denied due to exceeding the quota limits permitted.
        /// </exception>
        /// <exception cref="Amazon.BackupSearch.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.BackupSearch.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by a service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backupsearch-2018-05-10/ListSearchResultExportJobs">REST API Reference for ListSearchResultExportJobs Operation</seealso>
        ListSearchResultExportJobsResponse ListSearchResultExportJobs(ListSearchResultExportJobsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListSearchResultExportJobs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListSearchResultExportJobs operation on AmazonBackupSearchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListSearchResultExportJobs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backupsearch-2018-05-10/ListSearchResultExportJobs">REST API Reference for ListSearchResultExportJobs Operation</seealso>
        IAsyncResult BeginListSearchResultExportJobs(ListSearchResultExportJobsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListSearchResultExportJobs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListSearchResultExportJobs.</param>
        /// 
        /// <returns>Returns a  ListSearchResultExportJobsResult from BackupSearch.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backupsearch-2018-05-10/ListSearchResultExportJobs">REST API Reference for ListSearchResultExportJobs Operation</seealso>
        ListSearchResultExportJobsResponse EndListSearchResultExportJobs(IAsyncResult asyncResult);

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// This operation returns the tags for a resource type.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by BackupSearch.</returns>
        /// <exception cref="Amazon.BackupSearch.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.BackupSearch.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.BackupSearch.Model.ResourceNotFoundException">
        /// The resource was not found for this request.
        /// 
        ///  
        /// <para>
        /// Confirm the resource information, such as the ARN or type is correct and exists, then
        /// retry the request.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.BackupSearch.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.BackupSearch.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by a service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backupsearch-2018-05-10/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonBackupSearchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backupsearch-2018-05-10/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        IAsyncResult BeginListTagsForResource(ListTagsForResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTagsForResource.</param>
        /// 
        /// <returns>Returns a  ListTagsForResourceResult from BackupSearch.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backupsearch-2018-05-10/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult);

        #endregion
        
        #region  StartSearchJob


        /// <summary>
        /// This operation creates a search job which returns recovery points filtered by SearchScope
        /// and items filtered by ItemFilters.
        /// 
        ///  
        /// <para>
        /// You can optionally include ClientToken, EncryptionKeyArn, Name, and/or Tags.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartSearchJob service method.</param>
        /// 
        /// <returns>The response from the StartSearchJob service method, as returned by BackupSearch.</returns>
        /// <exception cref="Amazon.BackupSearch.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.BackupSearch.Model.ConflictException">
        /// This exception occurs when a conflict with a previous successful operation is detected.
        /// This generally occurs when the previous operation did not have time to propagate to
        /// the host serving the current request.
        /// 
        ///  
        /// <para>
        /// A retry (with appropriate backoff logic) is the recommended response to this exception.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.BackupSearch.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.BackupSearch.Model.ResourceNotFoundException">
        /// The resource was not found for this request.
        /// 
        ///  
        /// <para>
        /// Confirm the resource information, such as the ARN or type is correct and exists, then
        /// retry the request.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.BackupSearch.Model.ServiceQuotaExceededException">
        /// The request denied due to exceeding the quota limits permitted.
        /// </exception>
        /// <exception cref="Amazon.BackupSearch.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.BackupSearch.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by a service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backupsearch-2018-05-10/StartSearchJob">REST API Reference for StartSearchJob Operation</seealso>
        StartSearchJobResponse StartSearchJob(StartSearchJobRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the StartSearchJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartSearchJob operation on AmazonBackupSearchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartSearchJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backupsearch-2018-05-10/StartSearchJob">REST API Reference for StartSearchJob Operation</seealso>
        IAsyncResult BeginStartSearchJob(StartSearchJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StartSearchJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartSearchJob.</param>
        /// 
        /// <returns>Returns a  StartSearchJobResult from BackupSearch.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backupsearch-2018-05-10/StartSearchJob">REST API Reference for StartSearchJob Operation</seealso>
        StartSearchJobResponse EndStartSearchJob(IAsyncResult asyncResult);

        #endregion
        
        #region  StartSearchResultExportJob


        /// <summary>
        /// This operations starts a job to export the results of search job to a designated S3
        /// bucket.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartSearchResultExportJob service method.</param>
        /// 
        /// <returns>The response from the StartSearchResultExportJob service method, as returned by BackupSearch.</returns>
        /// <exception cref="Amazon.BackupSearch.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.BackupSearch.Model.ConflictException">
        /// This exception occurs when a conflict with a previous successful operation is detected.
        /// This generally occurs when the previous operation did not have time to propagate to
        /// the host serving the current request.
        /// 
        ///  
        /// <para>
        /// A retry (with appropriate backoff logic) is the recommended response to this exception.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.BackupSearch.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.BackupSearch.Model.ResourceNotFoundException">
        /// The resource was not found for this request.
        /// 
        ///  
        /// <para>
        /// Confirm the resource information, such as the ARN or type is correct and exists, then
        /// retry the request.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.BackupSearch.Model.ServiceQuotaExceededException">
        /// The request denied due to exceeding the quota limits permitted.
        /// </exception>
        /// <exception cref="Amazon.BackupSearch.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.BackupSearch.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by a service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backupsearch-2018-05-10/StartSearchResultExportJob">REST API Reference for StartSearchResultExportJob Operation</seealso>
        StartSearchResultExportJobResponse StartSearchResultExportJob(StartSearchResultExportJobRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the StartSearchResultExportJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartSearchResultExportJob operation on AmazonBackupSearchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartSearchResultExportJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backupsearch-2018-05-10/StartSearchResultExportJob">REST API Reference for StartSearchResultExportJob Operation</seealso>
        IAsyncResult BeginStartSearchResultExportJob(StartSearchResultExportJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StartSearchResultExportJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartSearchResultExportJob.</param>
        /// 
        /// <returns>Returns a  StartSearchResultExportJobResult from BackupSearch.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backupsearch-2018-05-10/StartSearchResultExportJob">REST API Reference for StartSearchResultExportJob Operation</seealso>
        StartSearchResultExportJobResponse EndStartSearchResultExportJob(IAsyncResult asyncResult);

        #endregion
        
        #region  StopSearchJob


        /// <summary>
        /// This operations ends a search job.
        /// 
        ///  
        /// <para>
        /// Only a search job with a status of <c>RUNNING</c> can be stopped.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopSearchJob service method.</param>
        /// 
        /// <returns>The response from the StopSearchJob service method, as returned by BackupSearch.</returns>
        /// <exception cref="Amazon.BackupSearch.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.BackupSearch.Model.ConflictException">
        /// This exception occurs when a conflict with a previous successful operation is detected.
        /// This generally occurs when the previous operation did not have time to propagate to
        /// the host serving the current request.
        /// 
        ///  
        /// <para>
        /// A retry (with appropriate backoff logic) is the recommended response to this exception.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.BackupSearch.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.BackupSearch.Model.ResourceNotFoundException">
        /// The resource was not found for this request.
        /// 
        ///  
        /// <para>
        /// Confirm the resource information, such as the ARN or type is correct and exists, then
        /// retry the request.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.BackupSearch.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.BackupSearch.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by a service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backupsearch-2018-05-10/StopSearchJob">REST API Reference for StopSearchJob Operation</seealso>
        StopSearchJobResponse StopSearchJob(StopSearchJobRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the StopSearchJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopSearchJob operation on AmazonBackupSearchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStopSearchJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backupsearch-2018-05-10/StopSearchJob">REST API Reference for StopSearchJob Operation</seealso>
        IAsyncResult BeginStopSearchJob(StopSearchJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StopSearchJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStopSearchJob.</param>
        /// 
        /// <returns>Returns a  StopSearchJobResult from BackupSearch.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backupsearch-2018-05-10/StopSearchJob">REST API Reference for StopSearchJob Operation</seealso>
        StopSearchJobResponse EndStopSearchJob(IAsyncResult asyncResult);

        #endregion
        
        #region  TagResource


        /// <summary>
        /// This operation puts tags on the resource you indicate.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by BackupSearch.</returns>
        /// <exception cref="Amazon.BackupSearch.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.BackupSearch.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.BackupSearch.Model.ResourceNotFoundException">
        /// The resource was not found for this request.
        /// 
        ///  
        /// <para>
        /// Confirm the resource information, such as the ARN or type is correct and exists, then
        /// retry the request.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.BackupSearch.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.BackupSearch.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by a service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backupsearch-2018-05-10/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse TagResource(TagResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the TagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonBackupSearchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backupsearch-2018-05-10/TagResource">REST API Reference for TagResource Operation</seealso>
        IAsyncResult BeginTagResource(TagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  TagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTagResource.</param>
        /// 
        /// <returns>Returns a  TagResourceResult from BackupSearch.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backupsearch-2018-05-10/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse EndTagResource(IAsyncResult asyncResult);

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// This operation removes tags from the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by BackupSearch.</returns>
        /// <exception cref="Amazon.BackupSearch.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.BackupSearch.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.BackupSearch.Model.ResourceNotFoundException">
        /// The resource was not found for this request.
        /// 
        ///  
        /// <para>
        /// Confirm the resource information, such as the ARN or type is correct and exists, then
        /// retry the request.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.BackupSearch.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.BackupSearch.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by a service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backupsearch-2018-05-10/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse UntagResource(UntagResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UntagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonBackupSearchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backupsearch-2018-05-10/UntagResource">REST API Reference for UntagResource Operation</seealso>
        IAsyncResult BeginUntagResource(UntagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UntagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUntagResource.</param>
        /// 
        /// <returns>Returns a  UntagResourceResult from BackupSearch.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backupsearch-2018-05-10/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse EndUntagResource(IAsyncResult asyncResult);

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