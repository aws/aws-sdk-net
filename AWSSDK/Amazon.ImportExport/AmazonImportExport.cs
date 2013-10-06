/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;

using Amazon.ImportExport;
using Amazon.ImportExport.Model;

namespace Amazon.ImportExport
{
    /// <summary>
    /// Interface for accessing AmazonImportExport.
    ///  
    ///  AWS Import/Export Service <para> AWS Import/Export accelerates transferring large amounts of data between the AWS cloud and portable storage
    /// devices that you mail to us. AWS Import/Export transfers data directly onto and off of your storage devices using Amazon's high-speed
    /// internal network and bypassing the Internet. For large data sets, AWS Import/Export is often faster than Internet transfer and more cost
    /// effective than upgrading your connectivity. </para>
    /// </summary>
    public interface AmazonImportExport : IDisposable
    {
        

        #region CreateJob

        /// <summary>
        /// <para> This operation initiates the process of scheduling an upload or download of your data. You include in the request a manifest that
        /// describes the data transfer specifics. The response to the request includes a job ID, which you can use in other operations, a signature
        /// that you use to identify your storage device, and the address where you should ship your storage device. </para>
        /// </summary>
        /// 
        /// <param name="createJobRequest">Container for the necessary parameters to execute the CreateJob service method on AmazonImportExport.</param>
        /// 
        /// <returns>The response from the CreateJob service method, as returned by AmazonImportExport.</returns>
        /// 
        /// <exception cref="MalformedManifestException"/>
        /// <exception cref="InvalidAddressException"/>
        /// <exception cref="BucketPermissionException"/>
        /// <exception cref="InvalidParameterException"/>
        /// <exception cref="MultipleRegionsException"/>
        /// <exception cref="MissingParameterException"/>
        /// <exception cref="InvalidFileSystemException"/>
        /// <exception cref="MissingCustomsException"/>
        /// <exception cref="NoSuchBucketException"/>
        /// <exception cref="InvalidAccessKeyIdException"/>
        /// <exception cref="InvalidManifestFieldException"/>
        /// <exception cref="InvalidCustomsException"/>
        /// <exception cref="MissingManifestFieldException"/>
        /// <exception cref="CreateJobQuotaExceededException"/>
        /// <exception cref="InvalidJobIdException"/>
        CreateJobResponse CreateJob(CreateJobRequest createJobRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateJob operation.
        /// <seealso cref="Amazon.ImportExport.AmazonImportExport.CreateJob"/>
        /// </summary>
        /// 
        /// <param name="createJobRequest">Container for the necessary parameters to execute the CreateJob operation on AmazonImportExport.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateJob
        ///         operation.</returns>
        IAsyncResult BeginCreateJob(CreateJobRequest createJobRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the CreateJob operation.
        /// <seealso cref="Amazon.ImportExport.AmazonImportExport.CreateJob"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateJob.</param>
        /// 
        /// <returns>Returns a CreateJobResult from AmazonImportExport.</returns>
        CreateJobResponse EndCreateJob(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region CancelJob

        /// <summary>
        /// <para> This operation cancels a specified job. Only the job owner can cancel it. The operation fails if the job has already started or is
        /// complete. </para>
        /// </summary>
        /// 
        /// <param name="cancelJobRequest">Container for the necessary parameters to execute the CancelJob service method on AmazonImportExport.</param>
        /// 
        /// <returns>The response from the CancelJob service method, as returned by AmazonImportExport.</returns>
        /// 
        /// <exception cref="CanceledJobIdException"/>
        /// <exception cref="ExpiredJobIdException"/>
        /// <exception cref="InvalidAccessKeyIdException"/>
        /// <exception cref="InvalidJobIdException"/>
        /// <exception cref="UnableToCancelJobIdException"/>
        CancelJobResponse CancelJob(CancelJobRequest cancelJobRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the CancelJob operation.
        /// <seealso cref="Amazon.ImportExport.AmazonImportExport.CancelJob"/>
        /// </summary>
        /// 
        /// <param name="cancelJobRequest">Container for the necessary parameters to execute the CancelJob operation on AmazonImportExport.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCancelJob
        ///         operation.</returns>
        IAsyncResult BeginCancelJob(CancelJobRequest cancelJobRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the CancelJob operation.
        /// <seealso cref="Amazon.ImportExport.AmazonImportExport.CancelJob"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCancelJob.</param>
        /// 
        /// <returns>Returns a CancelJobResult from AmazonImportExport.</returns>
        CancelJobResponse EndCancelJob(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region GetStatus

        /// <summary>
        /// <para> This operation returns information about a job, including where the job is in the processing pipeline, the status of the results, and
        /// the signature value associated with the job. You can only return information about jobs you own. </para>
        /// </summary>
        /// 
        /// <param name="getStatusRequest">Container for the necessary parameters to execute the GetStatus service method on AmazonImportExport.</param>
        /// 
        /// <returns>The response from the GetStatus service method, as returned by AmazonImportExport.</returns>
        /// 
        /// <exception cref="CanceledJobIdException"/>
        /// <exception cref="ExpiredJobIdException"/>
        /// <exception cref="InvalidAccessKeyIdException"/>
        /// <exception cref="InvalidJobIdException"/>
        GetStatusResponse GetStatus(GetStatusRequest getStatusRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the GetStatus operation.
        /// <seealso cref="Amazon.ImportExport.AmazonImportExport.GetStatus"/>
        /// </summary>
        /// 
        /// <param name="getStatusRequest">Container for the necessary parameters to execute the GetStatus operation on AmazonImportExport.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetStatus
        ///         operation.</returns>
        IAsyncResult BeginGetStatus(GetStatusRequest getStatusRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the GetStatus operation.
        /// <seealso cref="Amazon.ImportExport.AmazonImportExport.GetStatus"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetStatus.</param>
        /// 
        /// <returns>Returns a GetStatusResult from AmazonImportExport.</returns>
        GetStatusResponse EndGetStatus(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region ListJobs

        /// <summary>
        /// <para> This operation returns the jobs associated with the requester. AWS Import/Export lists the jobs in reverse chronological order based
        /// on the date of creation. For example if Job Test1 was created 2009Dec30 and Test2 was created 2010Feb05, the ListJobs operation would return
        /// Test2 followed by Test1. </para>
        /// </summary>
        /// 
        /// <param name="listJobsRequest">Container for the necessary parameters to execute the ListJobs service method on AmazonImportExport.</param>
        /// 
        /// <returns>The response from the ListJobs service method, as returned by AmazonImportExport.</returns>
        /// 
        /// <exception cref="InvalidParameterException"/>
        /// <exception cref="InvalidAccessKeyIdException"/>
        ListJobsResponse ListJobs(ListJobsRequest listJobsRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the ListJobs operation.
        /// <seealso cref="Amazon.ImportExport.AmazonImportExport.ListJobs"/>
        /// </summary>
        /// 
        /// <param name="listJobsRequest">Container for the necessary parameters to execute the ListJobs operation on AmazonImportExport.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListJobs
        ///         operation.</returns>
        IAsyncResult BeginListJobs(ListJobsRequest listJobsRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the ListJobs operation.
        /// <seealso cref="Amazon.ImportExport.AmazonImportExport.ListJobs"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListJobs.</param>
        /// 
        /// <returns>Returns a ListJobsResult from AmazonImportExport.</returns>
        ListJobsResponse EndListJobs(IAsyncResult asyncResult);

        /// <summary>
        /// <para> This operation returns the jobs associated with the requester. AWS Import/Export lists the jobs in reverse chronological order based
        /// on the date of creation. For example if Job Test1 was created 2009Dec30 and Test2 was created 2010Feb05, the ListJobs operation would return
        /// Test2 followed by Test1. </para>
        /// </summary>
        /// 
        /// <returns>The response from the ListJobs service method, as returned by AmazonImportExport.</returns>
        /// 
        /// <exception cref="InvalidParameterException"/>
        /// <exception cref="InvalidAccessKeyIdException"/>
        ListJobsResponse ListJobs();
        
        #endregion
        
    

        #region UpdateJob

        /// <summary>
        /// <para> You use this operation to change the parameters specified in the original manifest file by supplying a new manifest file. The
        /// manifest file attached to this request replaces the original manifest file. You can only use the operation after a CreateJob request but
        /// before the data transfer starts and you can only use it on jobs you own. </para>
        /// </summary>
        /// 
        /// <param name="updateJobRequest">Container for the necessary parameters to execute the UpdateJob service method on AmazonImportExport.</param>
        /// 
        /// <returns>The response from the UpdateJob service method, as returned by AmazonImportExport.</returns>
        /// 
        /// <exception cref="MalformedManifestException"/>
        /// <exception cref="BucketPermissionException"/>
        /// <exception cref="InvalidAddressException"/>
        /// <exception cref="InvalidParameterException"/>
        /// <exception cref="UnableToUpdateJobIdException"/>
        /// <exception cref="MultipleRegionsException"/>
        /// <exception cref="MissingParameterException"/>
        /// <exception cref="InvalidFileSystemException"/>
        /// <exception cref="CanceledJobIdException"/>
        /// <exception cref="MissingCustomsException"/>
        /// <exception cref="NoSuchBucketException"/>
        /// <exception cref="ExpiredJobIdException"/>
        /// <exception cref="InvalidAccessKeyIdException"/>
        /// <exception cref="InvalidCustomsException"/>
        /// <exception cref="InvalidManifestFieldException"/>
        /// <exception cref="MissingManifestFieldException"/>
        /// <exception cref="InvalidJobIdException"/>
        UpdateJobResponse UpdateJob(UpdateJobRequest updateJobRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateJob operation.
        /// <seealso cref="Amazon.ImportExport.AmazonImportExport.UpdateJob"/>
        /// </summary>
        /// 
        /// <param name="updateJobRequest">Container for the necessary parameters to execute the UpdateJob operation on AmazonImportExport.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateJob
        ///         operation.</returns>
        IAsyncResult BeginUpdateJob(UpdateJobRequest updateJobRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the UpdateJob operation.
        /// <seealso cref="Amazon.ImportExport.AmazonImportExport.UpdateJob"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateJob.</param>
        /// 
        /// <returns>Returns a UpdateJobResult from AmazonImportExport.</returns>
        UpdateJobResponse EndUpdateJob(IAsyncResult asyncResult);
        
        #endregion
        
    
    }
}
    
