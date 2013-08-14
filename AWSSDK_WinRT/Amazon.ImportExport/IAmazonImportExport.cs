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
using System.Threading;
using System.Threading.Tasks;

using Amazon.ImportExport.Model;

namespace Amazon.ImportExport
{
    /// <summary>
    /// Interface for accessing AmazonImportExport.
    /// 
    /// AWS Import/Export Service <para> AWS Import/Export accelerates transferring large amounts of data between the AWS cloud and portable storage
    /// devices that you mail to us. AWS Import/Export transfers data directly onto and off of your storage devices using Amazon's high-speed
    /// internal network and bypassing the Internet. For large data sets, AWS Import/Export is often faster than Internet transfer and more cost
    /// effective than upgrading your connectivity. </para>
    /// </summary>
	public partial interface IAmazonImportExport : IDisposable
    {
 
        /// <summary>
        /// <para> This operation cancels a specified job. Only the job owner can cancel it. The operation fails if the job has already started or is
        /// complete. </para>
        /// </summary>
        /// 
        /// <param name="cancelJobRequest">Container for the necessary parameters to execute the CancelJob service method on AmazonImportExport.</param>
        /// 
        /// <returns>The response from the CancelJob service method, as returned by AmazonImportExport.</returns>
        /// 
        /// <exception cref="T:Amazon.ImportExport.Model.CanceledJobIdException" />
        /// <exception cref="T:Amazon.ImportExport.Model.ExpiredJobIdException" />
        /// <exception cref="T:Amazon.ImportExport.Model.InvalidAccessKeyIdException" />
        /// <exception cref="T:Amazon.ImportExport.Model.InvalidJobIdException" />
        /// <exception cref="T:Amazon.ImportExport.Model.UnableToCancelJobIdException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<CancelJobResponse> CancelJobAsync(CancelJobRequest cancelJobRequest, CancellationToken cancellationToken = default(CancellationToken));
 
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
        /// <exception cref="T:Amazon.ImportExport.Model.MalformedManifestException" />
        /// <exception cref="T:Amazon.ImportExport.Model.InvalidAddressException" />
        /// <exception cref="T:Amazon.ImportExport.Model.BucketPermissionException" />
        /// <exception cref="T:Amazon.ImportExport.Model.InvalidParameterException" />
        /// <exception cref="T:Amazon.ImportExport.Model.MultipleRegionsException" />
        /// <exception cref="T:Amazon.ImportExport.Model.MissingParameterException" />
        /// <exception cref="T:Amazon.ImportExport.Model.InvalidFileSystemException" />
        /// <exception cref="T:Amazon.ImportExport.Model.MissingCustomsException" />
        /// <exception cref="T:Amazon.ImportExport.Model.NoSuchBucketException" />
        /// <exception cref="T:Amazon.ImportExport.Model.InvalidAccessKeyIdException" />
        /// <exception cref="T:Amazon.ImportExport.Model.InvalidManifestFieldException" />
        /// <exception cref="T:Amazon.ImportExport.Model.InvalidCustomsException" />
        /// <exception cref="T:Amazon.ImportExport.Model.MissingManifestFieldException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<CreateJobResponse> CreateJobAsync(CreateJobRequest createJobRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para> This operation returns information about a job, including where the job is in the processing pipeline, the status of the results, and
        /// the signature value associated with the job. You can only return information about jobs you own. </para>
        /// </summary>
        /// 
        /// <param name="getStatusRequest">Container for the necessary parameters to execute the GetStatus service method on AmazonImportExport.</param>
        /// 
        /// <returns>The response from the GetStatus service method, as returned by AmazonImportExport.</returns>
        /// 
        /// <exception cref="T:Amazon.ImportExport.Model.CanceledJobIdException" />
        /// <exception cref="T:Amazon.ImportExport.Model.ExpiredJobIdException" />
        /// <exception cref="T:Amazon.ImportExport.Model.InvalidAccessKeyIdException" />
        /// <exception cref="T:Amazon.ImportExport.Model.InvalidJobIdException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<GetStatusResponse> GetStatusAsync(GetStatusRequest getStatusRequest, CancellationToken cancellationToken = default(CancellationToken));
 
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
        /// <exception cref="T:Amazon.ImportExport.Model.InvalidParameterException" />
        /// <exception cref="T:Amazon.ImportExport.Model.InvalidAccessKeyIdException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<ListJobsResponse> ListJobsAsync(ListJobsRequest listJobsRequest, CancellationToken cancellationToken = default(CancellationToken));
 
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
        /// <exception cref="T:Amazon.ImportExport.Model.MalformedManifestException" />
        /// <exception cref="T:Amazon.ImportExport.Model.BucketPermissionException" />
        /// <exception cref="T:Amazon.ImportExport.Model.InvalidAddressException" />
        /// <exception cref="T:Amazon.ImportExport.Model.InvalidParameterException" />
        /// <exception cref="T:Amazon.ImportExport.Model.MultipleRegionsException" />
        /// <exception cref="T:Amazon.ImportExport.Model.MissingParameterException" />
        /// <exception cref="T:Amazon.ImportExport.Model.InvalidFileSystemException" />
        /// <exception cref="T:Amazon.ImportExport.Model.CanceledJobIdException" />
        /// <exception cref="T:Amazon.ImportExport.Model.MissingCustomsException" />
        /// <exception cref="T:Amazon.ImportExport.Model.NoSuchBucketException" />
        /// <exception cref="T:Amazon.ImportExport.Model.ExpiredJobIdException" />
        /// <exception cref="T:Amazon.ImportExport.Model.InvalidAccessKeyIdException" />
        /// <exception cref="T:Amazon.ImportExport.Model.InvalidCustomsException" />
        /// <exception cref="T:Amazon.ImportExport.Model.InvalidManifestFieldException" />
        /// <exception cref="T:Amazon.ImportExport.Model.MissingManifestFieldException" />
        /// <exception cref="T:Amazon.ImportExport.Model.InvalidJobIdException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<UpdateJobResponse> UpdateJobAsync(UpdateJobRequest updateJobRequest, CancellationToken cancellationToken = default(CancellationToken));
    }
}
