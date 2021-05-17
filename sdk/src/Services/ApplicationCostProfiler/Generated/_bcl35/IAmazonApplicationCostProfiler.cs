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
 * Do not modify this file. This file is generated from the applicationcostprofiler-2020-09-10.normal.json service model.
 */


using System;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.ApplicationCostProfiler.Model;

namespace Amazon.ApplicationCostProfiler
{
    /// <summary>
    /// Interface for accessing ApplicationCostProfiler
    ///
    /// This reference provides descriptions of the AWS Application Cost Profiler API.
    /// 
    ///  
    /// <para>
    /// The AWS Application Cost Profiler API provides programmatic access to view, create,
    /// update, and delete application cost report definitions, as well as to import your
    /// usage data into the Application Cost Profiler service.
    /// </para>
    ///  
    /// <para>
    /// For more information about using this service, see the <a href="https://docs.aws.amazon.com/application-cost-profiler/latest/userguide/introduction.html">AWS
    /// Application Cost Profiler User Guide</a>.
    /// </para>
    /// </summary>
    public partial interface IAmazonApplicationCostProfiler : IAmazonService, IDisposable
    {


#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        IApplicationCostProfilerPaginatorFactory Paginators { get; }
#endif


        
        #region  DeleteReportDefinition


        /// <summary>
        /// Deletes the specified report definition in AWS Application Cost Profiler. This stops
        /// the report from being generated.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteReportDefinition service method.</param>
        /// 
        /// <returns>The response from the DeleteReportDefinition service method, as returned by ApplicationCostProfiler.</returns>
        /// <exception cref="Amazon.ApplicationCostProfiler.Model.AccessDeniedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ApplicationCostProfiler.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.ApplicationCostProfiler.Model.ThrottlingException">
        /// The calls to AWS Application Cost Profiler API are throttled. The request was denied.
        /// </exception>
        /// <exception cref="Amazon.ApplicationCostProfiler.Model.ValidationException">
        /// The input fails to satisfy the constraints for the API.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWSApplicationCostProfiler-2020-09-10/DeleteReportDefinition">REST API Reference for DeleteReportDefinition Operation</seealso>
        DeleteReportDefinitionResponse DeleteReportDefinition(DeleteReportDefinitionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteReportDefinition operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteReportDefinition operation on AmazonApplicationCostProfilerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteReportDefinition
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWSApplicationCostProfiler-2020-09-10/DeleteReportDefinition">REST API Reference for DeleteReportDefinition Operation</seealso>
        IAsyncResult BeginDeleteReportDefinition(DeleteReportDefinitionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteReportDefinition operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteReportDefinition.</param>
        /// 
        /// <returns>Returns a  DeleteReportDefinitionResult from ApplicationCostProfiler.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWSApplicationCostProfiler-2020-09-10/DeleteReportDefinition">REST API Reference for DeleteReportDefinition Operation</seealso>
        DeleteReportDefinitionResponse EndDeleteReportDefinition(IAsyncResult asyncResult);

        #endregion
        
        #region  GetReportDefinition


        /// <summary>
        /// Retrieves the definition of a report already configured in AWS Application Cost Profiler.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetReportDefinition service method.</param>
        /// 
        /// <returns>The response from the GetReportDefinition service method, as returned by ApplicationCostProfiler.</returns>
        /// <exception cref="Amazon.ApplicationCostProfiler.Model.AccessDeniedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ApplicationCostProfiler.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.ApplicationCostProfiler.Model.ThrottlingException">
        /// The calls to AWS Application Cost Profiler API are throttled. The request was denied.
        /// </exception>
        /// <exception cref="Amazon.ApplicationCostProfiler.Model.ValidationException">
        /// The input fails to satisfy the constraints for the API.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWSApplicationCostProfiler-2020-09-10/GetReportDefinition">REST API Reference for GetReportDefinition Operation</seealso>
        GetReportDefinitionResponse GetReportDefinition(GetReportDefinitionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetReportDefinition operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetReportDefinition operation on AmazonApplicationCostProfilerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetReportDefinition
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWSApplicationCostProfiler-2020-09-10/GetReportDefinition">REST API Reference for GetReportDefinition Operation</seealso>
        IAsyncResult BeginGetReportDefinition(GetReportDefinitionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetReportDefinition operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetReportDefinition.</param>
        /// 
        /// <returns>Returns a  GetReportDefinitionResult from ApplicationCostProfiler.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWSApplicationCostProfiler-2020-09-10/GetReportDefinition">REST API Reference for GetReportDefinition Operation</seealso>
        GetReportDefinitionResponse EndGetReportDefinition(IAsyncResult asyncResult);

        #endregion
        
        #region  ImportApplicationUsage


        /// <summary>
        /// Ingests application usage data from Amazon Simple Storage Service (Amazon S3).
        /// 
        ///  
        /// <para>
        /// The data must already exist in the S3 location. As part of the action, AWS Application
        /// Cost Profiler copies the object from your S3 bucket to an S3 bucket owned by Amazon
        /// for processing asynchronously.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ImportApplicationUsage service method.</param>
        /// 
        /// <returns>The response from the ImportApplicationUsage service method, as returned by ApplicationCostProfiler.</returns>
        /// <exception cref="Amazon.ApplicationCostProfiler.Model.AccessDeniedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ApplicationCostProfiler.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.ApplicationCostProfiler.Model.ThrottlingException">
        /// The calls to AWS Application Cost Profiler API are throttled. The request was denied.
        /// </exception>
        /// <exception cref="Amazon.ApplicationCostProfiler.Model.ValidationException">
        /// The input fails to satisfy the constraints for the API.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWSApplicationCostProfiler-2020-09-10/ImportApplicationUsage">REST API Reference for ImportApplicationUsage Operation</seealso>
        ImportApplicationUsageResponse ImportApplicationUsage(ImportApplicationUsageRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ImportApplicationUsage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ImportApplicationUsage operation on AmazonApplicationCostProfilerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndImportApplicationUsage
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWSApplicationCostProfiler-2020-09-10/ImportApplicationUsage">REST API Reference for ImportApplicationUsage Operation</seealso>
        IAsyncResult BeginImportApplicationUsage(ImportApplicationUsageRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ImportApplicationUsage operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginImportApplicationUsage.</param>
        /// 
        /// <returns>Returns a  ImportApplicationUsageResult from ApplicationCostProfiler.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWSApplicationCostProfiler-2020-09-10/ImportApplicationUsage">REST API Reference for ImportApplicationUsage Operation</seealso>
        ImportApplicationUsageResponse EndImportApplicationUsage(IAsyncResult asyncResult);

        #endregion
        
        #region  ListReportDefinitions


        /// <summary>
        /// Retrieves a list of all reports and their configurations for your AWS account.
        /// 
        ///  
        /// <para>
        /// The maximum number of reports is one.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListReportDefinitions service method.</param>
        /// 
        /// <returns>The response from the ListReportDefinitions service method, as returned by ApplicationCostProfiler.</returns>
        /// <exception cref="Amazon.ApplicationCostProfiler.Model.AccessDeniedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ApplicationCostProfiler.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.ApplicationCostProfiler.Model.ThrottlingException">
        /// The calls to AWS Application Cost Profiler API are throttled. The request was denied.
        /// </exception>
        /// <exception cref="Amazon.ApplicationCostProfiler.Model.ValidationException">
        /// The input fails to satisfy the constraints for the API.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWSApplicationCostProfiler-2020-09-10/ListReportDefinitions">REST API Reference for ListReportDefinitions Operation</seealso>
        ListReportDefinitionsResponse ListReportDefinitions(ListReportDefinitionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListReportDefinitions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListReportDefinitions operation on AmazonApplicationCostProfilerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListReportDefinitions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWSApplicationCostProfiler-2020-09-10/ListReportDefinitions">REST API Reference for ListReportDefinitions Operation</seealso>
        IAsyncResult BeginListReportDefinitions(ListReportDefinitionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListReportDefinitions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListReportDefinitions.</param>
        /// 
        /// <returns>Returns a  ListReportDefinitionsResult from ApplicationCostProfiler.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWSApplicationCostProfiler-2020-09-10/ListReportDefinitions">REST API Reference for ListReportDefinitions Operation</seealso>
        ListReportDefinitionsResponse EndListReportDefinitions(IAsyncResult asyncResult);

        #endregion
        
        #region  PutReportDefinition


        /// <summary>
        /// Creates the report definition for a report in Application Cost Profiler.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutReportDefinition service method.</param>
        /// 
        /// <returns>The response from the PutReportDefinition service method, as returned by ApplicationCostProfiler.</returns>
        /// <exception cref="Amazon.ApplicationCostProfiler.Model.AccessDeniedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ApplicationCostProfiler.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.ApplicationCostProfiler.Model.ServiceQuotaExceededException">
        /// Your request exceeds one or more of the service quotas.
        /// </exception>
        /// <exception cref="Amazon.ApplicationCostProfiler.Model.ThrottlingException">
        /// The calls to AWS Application Cost Profiler API are throttled. The request was denied.
        /// </exception>
        /// <exception cref="Amazon.ApplicationCostProfiler.Model.ValidationException">
        /// The input fails to satisfy the constraints for the API.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWSApplicationCostProfiler-2020-09-10/PutReportDefinition">REST API Reference for PutReportDefinition Operation</seealso>
        PutReportDefinitionResponse PutReportDefinition(PutReportDefinitionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the PutReportDefinition operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutReportDefinition operation on AmazonApplicationCostProfilerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutReportDefinition
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWSApplicationCostProfiler-2020-09-10/PutReportDefinition">REST API Reference for PutReportDefinition Operation</seealso>
        IAsyncResult BeginPutReportDefinition(PutReportDefinitionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  PutReportDefinition operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutReportDefinition.</param>
        /// 
        /// <returns>Returns a  PutReportDefinitionResult from ApplicationCostProfiler.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWSApplicationCostProfiler-2020-09-10/PutReportDefinition">REST API Reference for PutReportDefinition Operation</seealso>
        PutReportDefinitionResponse EndPutReportDefinition(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateReportDefinition


        /// <summary>
        /// Updates existing report in AWS Application Cost Profiler.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateReportDefinition service method.</param>
        /// 
        /// <returns>The response from the UpdateReportDefinition service method, as returned by ApplicationCostProfiler.</returns>
        /// <exception cref="Amazon.ApplicationCostProfiler.Model.AccessDeniedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ApplicationCostProfiler.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.ApplicationCostProfiler.Model.ThrottlingException">
        /// The calls to AWS Application Cost Profiler API are throttled. The request was denied.
        /// </exception>
        /// <exception cref="Amazon.ApplicationCostProfiler.Model.ValidationException">
        /// The input fails to satisfy the constraints for the API.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWSApplicationCostProfiler-2020-09-10/UpdateReportDefinition">REST API Reference for UpdateReportDefinition Operation</seealso>
        UpdateReportDefinitionResponse UpdateReportDefinition(UpdateReportDefinitionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateReportDefinition operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateReportDefinition operation on AmazonApplicationCostProfilerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateReportDefinition
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWSApplicationCostProfiler-2020-09-10/UpdateReportDefinition">REST API Reference for UpdateReportDefinition Operation</seealso>
        IAsyncResult BeginUpdateReportDefinition(UpdateReportDefinitionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateReportDefinition operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateReportDefinition.</param>
        /// 
        /// <returns>Returns a  UpdateReportDefinitionResult from ApplicationCostProfiler.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWSApplicationCostProfiler-2020-09-10/UpdateReportDefinition">REST API Reference for UpdateReportDefinition Operation</seealso>
        UpdateReportDefinitionResponse EndUpdateReportDefinition(IAsyncResult asyncResult);

        #endregion
        
    }
}