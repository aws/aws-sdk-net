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
 * Do not modify this file. This file is generated from the signer-2017-08-25.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.Signer.Model;

namespace Amazon.Signer
{
    /// <summary>
    /// Interface for accessing Signer
    ///
    /// You can use Code Signing for Amazon FreeRTOS (AWS Signer) to sign code that you created
    /// for any of the IoT devices that Amazon Web Services supports. AWS Signer is integrated
    /// with Amazon FreeRTOS, AWS Certificate Manager, and AWS CloudTrail. Amazon FreeRTOS
    /// customers can use AWS Signer to sign code images before making them available for
    /// microcontrollers. You can use ACM to import third-party certificates to be used by
    /// AWS Signer. For general information about using AWS Signer, see the <a href="http://docs.aws.amazon.com/signer/latest/developerguide/Welcome.html">Code
    /// Signing for Amazon FreeRTOS Developer Guide</a>.
    /// </summary>
    public partial interface IAmazonSigner : IAmazonService, IDisposable
    {
                
        #region  CancelSigningProfile


        /// <summary>
        /// Initiates the asynchronous execution of the CancelSigningProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CancelSigningProfile operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/signer-2017-08-25/CancelSigningProfile">REST API Reference for CancelSigningProfile Operation</seealso>
        Task<CancelSigningProfileResponse> CancelSigningProfileAsync(CancelSigningProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeSigningJob


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeSigningJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeSigningJob operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/signer-2017-08-25/DescribeSigningJob">REST API Reference for DescribeSigningJob Operation</seealso>
        Task<DescribeSigningJobResponse> DescribeSigningJobAsync(DescribeSigningJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetSigningPlatform


        /// <summary>
        /// Initiates the asynchronous execution of the GetSigningPlatform operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSigningPlatform operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/signer-2017-08-25/GetSigningPlatform">REST API Reference for GetSigningPlatform Operation</seealso>
        Task<GetSigningPlatformResponse> GetSigningPlatformAsync(GetSigningPlatformRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetSigningProfile


        /// <summary>
        /// Initiates the asynchronous execution of the GetSigningProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSigningProfile operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/signer-2017-08-25/GetSigningProfile">REST API Reference for GetSigningProfile Operation</seealso>
        Task<GetSigningProfileResponse> GetSigningProfileAsync(GetSigningProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListSigningJobs


        /// <summary>
        /// Initiates the asynchronous execution of the ListSigningJobs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListSigningJobs operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/signer-2017-08-25/ListSigningJobs">REST API Reference for ListSigningJobs Operation</seealso>
        Task<ListSigningJobsResponse> ListSigningJobsAsync(ListSigningJobsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListSigningPlatforms


        /// <summary>
        /// Initiates the asynchronous execution of the ListSigningPlatforms operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListSigningPlatforms operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/signer-2017-08-25/ListSigningPlatforms">REST API Reference for ListSigningPlatforms Operation</seealso>
        Task<ListSigningPlatformsResponse> ListSigningPlatformsAsync(ListSigningPlatformsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListSigningProfiles


        /// <summary>
        /// Initiates the asynchronous execution of the ListSigningProfiles operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListSigningProfiles operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/signer-2017-08-25/ListSigningProfiles">REST API Reference for ListSigningProfiles Operation</seealso>
        Task<ListSigningProfilesResponse> ListSigningProfilesAsync(ListSigningProfilesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  PutSigningProfile


        /// <summary>
        /// Initiates the asynchronous execution of the PutSigningProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutSigningProfile operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/signer-2017-08-25/PutSigningProfile">REST API Reference for PutSigningProfile Operation</seealso>
        Task<PutSigningProfileResponse> PutSigningProfileAsync(PutSigningProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  StartSigningJob


        /// <summary>
        /// Initiates the asynchronous execution of the StartSigningJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartSigningJob operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/signer-2017-08-25/StartSigningJob">REST API Reference for StartSigningJob Operation</seealso>
        Task<StartSigningJobResponse> StartSigningJobAsync(StartSigningJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}