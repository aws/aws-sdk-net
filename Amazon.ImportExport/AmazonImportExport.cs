/*
 * Copyright 2010-2011 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
    ///  AWS Import/Export Service <para> AWS Import/Export accelerates
    /// transferring large amounts of data between the AWS cloud and portable
    /// storage devices that you mail to us. AWS Import/Export transfers data
    /// directly onto and off of your storage devices using Amazon's
    /// high-speed internal network and bypassing the Internet. For large data
    /// sets, AWS Import/Export is often faster than Internet transfer and
    /// more cost effective than upgrading your connectivity. </para>
    /// </summary>
    public interface AmazonImportExport : IDisposable
    {
        

         /// <summary>
         /// <para> This operation initiates the process of scheduling an upload or
         /// download of your data. You include in the request a manifest that
         /// describes the data transfer specifics. The response to the request
         /// includes a job ID, which you can use in other operations, a signature
         /// that you use to identify your storage device, and the address where
         /// you should ship your storage device. </para>
         /// </summary>
         /// 
         /// <param name="createJobRequest">Container for the necessary parameters
         ///           to execute the CreateJob service method on AmazonImportExport.</param>
         /// 
         /// <returns>The response from the CreateJob service method, as returned
         ///         by AmazonImportExport.</returns>
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
        CreateJobResponse CreateJob(CreateJobRequest createJobRequest); 

         /// <summary>
         /// <para> This operation cancels a specified job. Only the job owner can
         /// cancel it. The operation fails if the job has already started or is
         /// complete. </para>
         /// </summary>
         /// 
         /// <param name="cancelJobRequest">Container for the necessary parameters
         ///           to execute the CancelJob service method on AmazonImportExport.</param>
         /// 
         /// <returns>The response from the CancelJob service method, as returned
         ///         by AmazonImportExport.</returns>
         /// 
         /// <exception cref="CanceledJobIdException"/>
         /// <exception cref="ExpiredJobIdException"/>
         /// <exception cref="InvalidAccessKeyIdException"/>
         /// <exception cref="InvalidJobIdException"/>
         /// <exception cref="UnableToCancelJobIdException"/>
        CancelJobResponse CancelJob(CancelJobRequest cancelJobRequest); 

         /// <summary>
         /// <para> This operation returns information about a job, including where
         /// the job is in the processing pipeline, the status of the results, and
         /// the signature value associated with the job. You can only return
         /// information about jobs you own. </para>
         /// </summary>
         /// 
         /// <param name="getStatusRequest">Container for the necessary parameters
         ///           to execute the GetStatus service method on AmazonImportExport.</param>
         /// 
         /// <returns>The response from the GetStatus service method, as returned
         ///         by AmazonImportExport.</returns>
         /// 
         /// <exception cref="CanceledJobIdException"/>
         /// <exception cref="ExpiredJobIdException"/>
         /// <exception cref="InvalidAccessKeyIdException"/>
         /// <exception cref="InvalidJobIdException"/>
        GetStatusResponse GetStatus(GetStatusRequest getStatusRequest); 

         /// <summary>
         /// <para> This operation returns the jobs associated with the requester.
         /// AWS Import/Export lists the jobs in reverse chronological order based
         /// on the date of creation. For example if Job Test1 was created
         /// 2009Dec30 and Test2 was created 2010Feb05, the ListJobs operation
         /// would return Test2 followed by Test1. </para>
         /// </summary>
         /// 
         /// <param name="listJobsRequest">Container for the necessary parameters
         ///           to execute the ListJobs service method on AmazonImportExport.</param>
         /// 
         /// <returns>The response from the ListJobs service method, as returned by
         ///         AmazonImportExport.</returns>
         /// 
         /// <exception cref="InvalidParameterException"/>
         /// <exception cref="InvalidAccessKeyIdException"/>
        ListJobsResponse ListJobs(ListJobsRequest listJobsRequest); 

         /// <summary>
         /// <para> You use this operation to change the parameters specified in
         /// the original manifest file by supplying a new manifest file. The
         /// manifest file attached to this request replaces the original manifest
         /// file. You can only use the operation after a CreateJob request but
         /// before the data transfer starts and you can only use it on jobs you
         /// own. </para>
         /// </summary>
         /// 
         /// <param name="updateJobRequest">Container for the necessary parameters
         ///           to execute the UpdateJob service method on AmazonImportExport.</param>
         /// 
         /// <returns>The response from the UpdateJob service method, as returned
         ///         by AmazonImportExport.</returns>
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
    }
}
    
