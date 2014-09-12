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
 * Do not modify this file. This file is generated from the importexport-2010-06-01.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.ImportExport.Model;

namespace Amazon.ImportExport
{
    /// <summary>
    /// Interface for accessing ImportExport
    ///
    /// AWS Import/Export Service AWS Import/Export accelerates transferring large amounts
    /// of data between the AWS cloud and portable storage devices that you mail to us. AWS
    /// Import/Export transfers data directly onto and off of your storage devices using Amazon's
    /// high-speed internal network and bypassing the Internet. For large data sets, AWS Import/Export
    /// is often faster than Internet transfer and more cost effective than upgrading your
    /// connectivity.
    /// </summary>
    public partial interface IAmazonImportExport : IDisposable
    {
                
        #region  CancelJob


        /// <summary>
        /// Initiates the asynchronous execution of the CancelJob operation.
        /// <seealso cref="Amazon.ImportExport.IAmazonImportExport"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CancelJob operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<CancelJobResponse> CancelJobAsync(CancelJobRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateJob


        /// <summary>
        /// Initiates the asynchronous execution of the CreateJob operation.
        /// <seealso cref="Amazon.ImportExport.IAmazonImportExport"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateJob operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<CreateJobResponse> CreateJobAsync(CreateJobRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetStatus


        /// <summary>
        /// Initiates the asynchronous execution of the GetStatus operation.
        /// <seealso cref="Amazon.ImportExport.IAmazonImportExport"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetStatus operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<GetStatusResponse> GetStatusAsync(GetStatusRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListJobs


        /// <summary>
        /// Initiates the asynchronous execution of the ListJobs operation.
        /// <seealso cref="Amazon.ImportExport.IAmazonImportExport"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListJobs operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<ListJobsResponse> ListJobsAsync(ListJobsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateJob


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateJob operation.
        /// <seealso cref="Amazon.ImportExport.IAmazonImportExport"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateJob operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<UpdateJobResponse> UpdateJobAsync(UpdateJobRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}