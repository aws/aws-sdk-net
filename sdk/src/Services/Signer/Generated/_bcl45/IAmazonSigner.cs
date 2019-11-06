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
    /// With code signing for IoT, you can sign code that you create for any IoT device that
    /// is supported by Amazon Web Services (AWS). Code signing is available through <a href="http://docs.aws.amazon.com/freertos/latest/userguide/">Amazon
    /// FreeRTOS</a> and <a href="http://docs.aws.amazon.com/iot/latest/developerguide/">AWS
    /// IoT Device Management</a>, and integrated with <a href="http://docs.aws.amazon.com/acm/latest/userguide/">AWS
    /// Certificate Manager (ACM)</a>. In order to sign code, you import a third-party code
    /// signing certificate with ACM that is used to sign updates in Amazon FreeRTOS and AWS
    /// IoT Device Management. For general information about using code signing, see the <a
    /// href="http://docs.aws.amazon.com/signer/latest/developerguide/Welcome.html">Code Signing
    /// for IoT Developer Guide</a>.
    /// </summary>
    public partial interface IAmazonSigner : IAmazonService, IDisposable
    {

        
        #region  CancelSigningProfile


        /// <summary>
        /// Changes the state of an <code>ACTIVE</code> signing profile to <code>CANCELED</code>.
        /// A canceled profile is still viewable with the <code>ListSigningProfiles</code> operation,
        /// but it cannot perform new signing jobs, and is deleted two years after cancelation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelSigningProfile service method.</param>
        /// 
        /// <returns>The response from the CancelSigningProfile service method, as returned by Signer.</returns>
        /// <exception cref="Amazon.Signer.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Signer.Model.InternalServiceErrorException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.Signer.Model.ResourceNotFoundException">
        /// A specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.Signer.Model.ThrottlingException">
        /// The signing job has been throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/signer-2017-08-25/CancelSigningProfile">REST API Reference for CancelSigningProfile Operation</seealso>
        CancelSigningProfileResponse CancelSigningProfile(CancelSigningProfileRequest request);



        /// <summary>
        /// Changes the state of an <code>ACTIVE</code> signing profile to <code>CANCELED</code>.
        /// A canceled profile is still viewable with the <code>ListSigningProfiles</code> operation,
        /// but it cannot perform new signing jobs, and is deleted two years after cancelation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelSigningProfile service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CancelSigningProfile service method, as returned by Signer.</returns>
        /// <exception cref="Amazon.Signer.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Signer.Model.InternalServiceErrorException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.Signer.Model.ResourceNotFoundException">
        /// A specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.Signer.Model.ThrottlingException">
        /// The signing job has been throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/signer-2017-08-25/CancelSigningProfile">REST API Reference for CancelSigningProfile Operation</seealso>
        Task<CancelSigningProfileResponse> CancelSigningProfileAsync(CancelSigningProfileRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeSigningJob


        /// <summary>
        /// Returns information about a specific code signing job. You specify the job by using
        /// the <code>jobId</code> value that is returned by the <a>StartSigningJob</a> operation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSigningJob service method.</param>
        /// 
        /// <returns>The response from the DescribeSigningJob service method, as returned by Signer.</returns>
        /// <exception cref="Amazon.Signer.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Signer.Model.InternalServiceErrorException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.Signer.Model.ResourceNotFoundException">
        /// A specified resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/signer-2017-08-25/DescribeSigningJob">REST API Reference for DescribeSigningJob Operation</seealso>
        DescribeSigningJobResponse DescribeSigningJob(DescribeSigningJobRequest request);



        /// <summary>
        /// Returns information about a specific code signing job. You specify the job by using
        /// the <code>jobId</code> value that is returned by the <a>StartSigningJob</a> operation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSigningJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeSigningJob service method, as returned by Signer.</returns>
        /// <exception cref="Amazon.Signer.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Signer.Model.InternalServiceErrorException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.Signer.Model.ResourceNotFoundException">
        /// A specified resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/signer-2017-08-25/DescribeSigningJob">REST API Reference for DescribeSigningJob Operation</seealso>
        Task<DescribeSigningJobResponse> DescribeSigningJobAsync(DescribeSigningJobRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetSigningPlatform


        /// <summary>
        /// Returns information on a specific signing platform.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSigningPlatform service method.</param>
        /// 
        /// <returns>The response from the GetSigningPlatform service method, as returned by Signer.</returns>
        /// <exception cref="Amazon.Signer.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Signer.Model.InternalServiceErrorException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.Signer.Model.ResourceNotFoundException">
        /// A specified resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/signer-2017-08-25/GetSigningPlatform">REST API Reference for GetSigningPlatform Operation</seealso>
        GetSigningPlatformResponse GetSigningPlatform(GetSigningPlatformRequest request);



        /// <summary>
        /// Returns information on a specific signing platform.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSigningPlatform service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetSigningPlatform service method, as returned by Signer.</returns>
        /// <exception cref="Amazon.Signer.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Signer.Model.InternalServiceErrorException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.Signer.Model.ResourceNotFoundException">
        /// A specified resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/signer-2017-08-25/GetSigningPlatform">REST API Reference for GetSigningPlatform Operation</seealso>
        Task<GetSigningPlatformResponse> GetSigningPlatformAsync(GetSigningPlatformRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetSigningProfile


        /// <summary>
        /// Returns information on a specific signing profile.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSigningProfile service method.</param>
        /// 
        /// <returns>The response from the GetSigningProfile service method, as returned by Signer.</returns>
        /// <exception cref="Amazon.Signer.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Signer.Model.InternalServiceErrorException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.Signer.Model.ResourceNotFoundException">
        /// A specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.Signer.Model.ThrottlingException">
        /// The signing job has been throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/signer-2017-08-25/GetSigningProfile">REST API Reference for GetSigningProfile Operation</seealso>
        GetSigningProfileResponse GetSigningProfile(GetSigningProfileRequest request);



        /// <summary>
        /// Returns information on a specific signing profile.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSigningProfile service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetSigningProfile service method, as returned by Signer.</returns>
        /// <exception cref="Amazon.Signer.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Signer.Model.InternalServiceErrorException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.Signer.Model.ResourceNotFoundException">
        /// A specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.Signer.Model.ThrottlingException">
        /// The signing job has been throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/signer-2017-08-25/GetSigningProfile">REST API Reference for GetSigningProfile Operation</seealso>
        Task<GetSigningProfileResponse> GetSigningProfileAsync(GetSigningProfileRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListSigningJobs


        /// <summary>
        /// Lists all your signing jobs. You can use the <code>maxResults</code> parameter to
        /// limit the number of signing jobs that are returned in the response. If additional
        /// jobs remain to be listed, code signing returns a <code>nextToken</code> value. Use
        /// this value in subsequent calls to <code>ListSigningJobs</code> to fetch the remaining
        /// values. You can continue calling <code>ListSigningJobs</code> with your <code>maxResults</code>
        /// parameter and with new values that code signing returns in the <code>nextToken</code>
        /// parameter until all of your signing jobs have been returned.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSigningJobs service method.</param>
        /// 
        /// <returns>The response from the ListSigningJobs service method, as returned by Signer.</returns>
        /// <exception cref="Amazon.Signer.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Signer.Model.InternalServiceErrorException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.Signer.Model.ThrottlingException">
        /// The signing job has been throttled.
        /// </exception>
        /// <exception cref="Amazon.Signer.Model.ValidationException">
        /// You signing certificate could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/signer-2017-08-25/ListSigningJobs">REST API Reference for ListSigningJobs Operation</seealso>
        ListSigningJobsResponse ListSigningJobs(ListSigningJobsRequest request);



        /// <summary>
        /// Lists all your signing jobs. You can use the <code>maxResults</code> parameter to
        /// limit the number of signing jobs that are returned in the response. If additional
        /// jobs remain to be listed, code signing returns a <code>nextToken</code> value. Use
        /// this value in subsequent calls to <code>ListSigningJobs</code> to fetch the remaining
        /// values. You can continue calling <code>ListSigningJobs</code> with your <code>maxResults</code>
        /// parameter and with new values that code signing returns in the <code>nextToken</code>
        /// parameter until all of your signing jobs have been returned.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSigningJobs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListSigningJobs service method, as returned by Signer.</returns>
        /// <exception cref="Amazon.Signer.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Signer.Model.InternalServiceErrorException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.Signer.Model.ThrottlingException">
        /// The signing job has been throttled.
        /// </exception>
        /// <exception cref="Amazon.Signer.Model.ValidationException">
        /// You signing certificate could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/signer-2017-08-25/ListSigningJobs">REST API Reference for ListSigningJobs Operation</seealso>
        Task<ListSigningJobsResponse> ListSigningJobsAsync(ListSigningJobsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListSigningPlatforms


        /// <summary>
        /// Lists all signing platforms available in code signing that match the request parameters.
        /// If additional jobs remain to be listed, code signing returns a <code>nextToken</code>
        /// value. Use this value in subsequent calls to <code>ListSigningJobs</code> to fetch
        /// the remaining values. You can continue calling <code>ListSigningJobs</code> with your
        /// <code>maxResults</code> parameter and with new values that code signing returns in
        /// the <code>nextToken</code> parameter until all of your signing jobs have been returned.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSigningPlatforms service method.</param>
        /// 
        /// <returns>The response from the ListSigningPlatforms service method, as returned by Signer.</returns>
        /// <exception cref="Amazon.Signer.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Signer.Model.InternalServiceErrorException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.Signer.Model.ThrottlingException">
        /// The signing job has been throttled.
        /// </exception>
        /// <exception cref="Amazon.Signer.Model.ValidationException">
        /// You signing certificate could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/signer-2017-08-25/ListSigningPlatforms">REST API Reference for ListSigningPlatforms Operation</seealso>
        ListSigningPlatformsResponse ListSigningPlatforms(ListSigningPlatformsRequest request);



        /// <summary>
        /// Lists all signing platforms available in code signing that match the request parameters.
        /// If additional jobs remain to be listed, code signing returns a <code>nextToken</code>
        /// value. Use this value in subsequent calls to <code>ListSigningJobs</code> to fetch
        /// the remaining values. You can continue calling <code>ListSigningJobs</code> with your
        /// <code>maxResults</code> parameter and with new values that code signing returns in
        /// the <code>nextToken</code> parameter until all of your signing jobs have been returned.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSigningPlatforms service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListSigningPlatforms service method, as returned by Signer.</returns>
        /// <exception cref="Amazon.Signer.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Signer.Model.InternalServiceErrorException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.Signer.Model.ThrottlingException">
        /// The signing job has been throttled.
        /// </exception>
        /// <exception cref="Amazon.Signer.Model.ValidationException">
        /// You signing certificate could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/signer-2017-08-25/ListSigningPlatforms">REST API Reference for ListSigningPlatforms Operation</seealso>
        Task<ListSigningPlatformsResponse> ListSigningPlatformsAsync(ListSigningPlatformsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListSigningProfiles


        /// <summary>
        /// Lists all available signing profiles in your AWS account. Returns only profiles with
        /// an <code>ACTIVE</code> status unless the <code>includeCanceled</code> request field
        /// is set to <code>true</code>. If additional jobs remain to be listed, code signing
        /// returns a <code>nextToken</code> value. Use this value in subsequent calls to <code>ListSigningJobs</code>
        /// to fetch the remaining values. You can continue calling <code>ListSigningJobs</code>
        /// with your <code>maxResults</code> parameter and with new values that code signing
        /// returns in the <code>nextToken</code> parameter until all of your signing jobs have
        /// been returned.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSigningProfiles service method.</param>
        /// 
        /// <returns>The response from the ListSigningProfiles service method, as returned by Signer.</returns>
        /// <exception cref="Amazon.Signer.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Signer.Model.InternalServiceErrorException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.Signer.Model.ThrottlingException">
        /// The signing job has been throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/signer-2017-08-25/ListSigningProfiles">REST API Reference for ListSigningProfiles Operation</seealso>
        ListSigningProfilesResponse ListSigningProfiles(ListSigningProfilesRequest request);



        /// <summary>
        /// Lists all available signing profiles in your AWS account. Returns only profiles with
        /// an <code>ACTIVE</code> status unless the <code>includeCanceled</code> request field
        /// is set to <code>true</code>. If additional jobs remain to be listed, code signing
        /// returns a <code>nextToken</code> value. Use this value in subsequent calls to <code>ListSigningJobs</code>
        /// to fetch the remaining values. You can continue calling <code>ListSigningJobs</code>
        /// with your <code>maxResults</code> parameter and with new values that code signing
        /// returns in the <code>nextToken</code> parameter until all of your signing jobs have
        /// been returned.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSigningProfiles service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListSigningProfiles service method, as returned by Signer.</returns>
        /// <exception cref="Amazon.Signer.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Signer.Model.InternalServiceErrorException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.Signer.Model.ThrottlingException">
        /// The signing job has been throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/signer-2017-08-25/ListSigningProfiles">REST API Reference for ListSigningProfiles Operation</seealso>
        Task<ListSigningProfilesResponse> ListSigningProfilesAsync(ListSigningProfilesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// Returns a list of the tags associated with a signing profile resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by Signer.</returns>
        /// <exception cref="Amazon.Signer.Model.BadRequestException">
        /// The request contains invalid parameters for the ARN or tags. This exception also occurs
        /// when you call a tagging API on a cancelled signing profile.
        /// </exception>
        /// <exception cref="Amazon.Signer.Model.InternalServiceErrorException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.Signer.Model.NotFoundException">
        /// The signing profile was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/signer-2017-08-25/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request);



        /// <summary>
        /// Returns a list of the tags associated with a signing profile resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by Signer.</returns>
        /// <exception cref="Amazon.Signer.Model.BadRequestException">
        /// The request contains invalid parameters for the ARN or tags. This exception also occurs
        /// when you call a tagging API on a cancelled signing profile.
        /// </exception>
        /// <exception cref="Amazon.Signer.Model.InternalServiceErrorException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.Signer.Model.NotFoundException">
        /// The signing profile was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/signer-2017-08-25/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  PutSigningProfile


        /// <summary>
        /// Creates a signing profile. A signing profile is a code signing template that can be
        /// used to carry out a pre-defined signing job. For more information, see <a href="http://docs.aws.amazon.com/signer/latest/developerguide/gs-profile.html">http://docs.aws.amazon.com/signer/latest/developerguide/gs-profile.html</a>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutSigningProfile service method.</param>
        /// 
        /// <returns>The response from the PutSigningProfile service method, as returned by Signer.</returns>
        /// <exception cref="Amazon.Signer.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Signer.Model.InternalServiceErrorException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.Signer.Model.ResourceNotFoundException">
        /// A specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.Signer.Model.ThrottlingException">
        /// The signing job has been throttled.
        /// </exception>
        /// <exception cref="Amazon.Signer.Model.ValidationException">
        /// You signing certificate could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/signer-2017-08-25/PutSigningProfile">REST API Reference for PutSigningProfile Operation</seealso>
        PutSigningProfileResponse PutSigningProfile(PutSigningProfileRequest request);



        /// <summary>
        /// Creates a signing profile. A signing profile is a code signing template that can be
        /// used to carry out a pre-defined signing job. For more information, see <a href="http://docs.aws.amazon.com/signer/latest/developerguide/gs-profile.html">http://docs.aws.amazon.com/signer/latest/developerguide/gs-profile.html</a>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutSigningProfile service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutSigningProfile service method, as returned by Signer.</returns>
        /// <exception cref="Amazon.Signer.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Signer.Model.InternalServiceErrorException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.Signer.Model.ResourceNotFoundException">
        /// A specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.Signer.Model.ThrottlingException">
        /// The signing job has been throttled.
        /// </exception>
        /// <exception cref="Amazon.Signer.Model.ValidationException">
        /// You signing certificate could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/signer-2017-08-25/PutSigningProfile">REST API Reference for PutSigningProfile Operation</seealso>
        Task<PutSigningProfileResponse> PutSigningProfileAsync(PutSigningProfileRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  StartSigningJob


        /// <summary>
        /// Initiates a signing job to be performed on the code provided. Signing jobs are viewable
        /// by the <code>ListSigningJobs</code> operation for two years after they are performed.
        /// Note the following requirements: 
        /// 
        ///  <ul> <li> 
        /// <para>
        ///  You must create an Amazon S3 source bucket. For more information, see <a href="http://docs.aws.amazon.com/AmazonS3/latest/gsg/CreatingABucket.html">Create
        /// a Bucket</a> in the <i>Amazon S3 Getting Started Guide</i>. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your S3 source bucket must be version enabled.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You must create an S3 destination bucket. Code signing uses your S3 destination bucket
        /// to write your signed code.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You specify the name of the source and destination buckets when calling the <code>StartSigningJob</code>
        /// operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You must also specify a request token that identifies your request to code signing.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// You can call the <a>DescribeSigningJob</a> and the <a>ListSigningJobs</a> actions
        /// after you call <code>StartSigningJob</code>.
        /// </para>
        ///  
        /// <para>
        /// For a Java example that shows how to use this action, see <a href="http://docs.aws.amazon.com/acm/latest/userguide/">http://docs.aws.amazon.com/acm/latest/userguide/</a>
        /// 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartSigningJob service method.</param>
        /// 
        /// <returns>The response from the StartSigningJob service method, as returned by Signer.</returns>
        /// <exception cref="Amazon.Signer.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Signer.Model.InternalServiceErrorException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.Signer.Model.ResourceNotFoundException">
        /// A specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.Signer.Model.ThrottlingException">
        /// The signing job has been throttled.
        /// </exception>
        /// <exception cref="Amazon.Signer.Model.ValidationException">
        /// You signing certificate could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/signer-2017-08-25/StartSigningJob">REST API Reference for StartSigningJob Operation</seealso>
        StartSigningJobResponse StartSigningJob(StartSigningJobRequest request);



        /// <summary>
        /// Initiates a signing job to be performed on the code provided. Signing jobs are viewable
        /// by the <code>ListSigningJobs</code> operation for two years after they are performed.
        /// Note the following requirements: 
        /// 
        ///  <ul> <li> 
        /// <para>
        ///  You must create an Amazon S3 source bucket. For more information, see <a href="http://docs.aws.amazon.com/AmazonS3/latest/gsg/CreatingABucket.html">Create
        /// a Bucket</a> in the <i>Amazon S3 Getting Started Guide</i>. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your S3 source bucket must be version enabled.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You must create an S3 destination bucket. Code signing uses your S3 destination bucket
        /// to write your signed code.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You specify the name of the source and destination buckets when calling the <code>StartSigningJob</code>
        /// operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You must also specify a request token that identifies your request to code signing.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// You can call the <a>DescribeSigningJob</a> and the <a>ListSigningJobs</a> actions
        /// after you call <code>StartSigningJob</code>.
        /// </para>
        ///  
        /// <para>
        /// For a Java example that shows how to use this action, see <a href="http://docs.aws.amazon.com/acm/latest/userguide/">http://docs.aws.amazon.com/acm/latest/userguide/</a>
        /// 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartSigningJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartSigningJob service method, as returned by Signer.</returns>
        /// <exception cref="Amazon.Signer.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Signer.Model.InternalServiceErrorException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.Signer.Model.ResourceNotFoundException">
        /// A specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.Signer.Model.ThrottlingException">
        /// The signing job has been throttled.
        /// </exception>
        /// <exception cref="Amazon.Signer.Model.ValidationException">
        /// You signing certificate could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/signer-2017-08-25/StartSigningJob">REST API Reference for StartSigningJob Operation</seealso>
        Task<StartSigningJobResponse> StartSigningJobAsync(StartSigningJobRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Adds one or more tags to a signing profile. Tags are labels that you can use to identify
        /// and organize your AWS resources. Each tag consists of a key and an optional value.
        /// You specify the signing profile using its Amazon Resource Name (ARN). You specify
        /// the tag by using a key-value pair.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by Signer.</returns>
        /// <exception cref="Amazon.Signer.Model.BadRequestException">
        /// The request contains invalid parameters for the ARN or tags. This exception also occurs
        /// when you call a tagging API on a cancelled signing profile.
        /// </exception>
        /// <exception cref="Amazon.Signer.Model.InternalServiceErrorException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.Signer.Model.NotFoundException">
        /// The signing profile was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/signer-2017-08-25/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse TagResource(TagResourceRequest request);



        /// <summary>
        /// Adds one or more tags to a signing profile. Tags are labels that you can use to identify
        /// and organize your AWS resources. Each tag consists of a key and an optional value.
        /// You specify the signing profile using its Amazon Resource Name (ARN). You specify
        /// the tag by using a key-value pair.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by Signer.</returns>
        /// <exception cref="Amazon.Signer.Model.BadRequestException">
        /// The request contains invalid parameters for the ARN or tags. This exception also occurs
        /// when you call a tagging API on a cancelled signing profile.
        /// </exception>
        /// <exception cref="Amazon.Signer.Model.InternalServiceErrorException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.Signer.Model.NotFoundException">
        /// The signing profile was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/signer-2017-08-25/TagResource">REST API Reference for TagResource Operation</seealso>
        Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// Remove one or more tags from a signing profile. Specify a list of tag keys to remove
        /// the tags.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by Signer.</returns>
        /// <exception cref="Amazon.Signer.Model.BadRequestException">
        /// The request contains invalid parameters for the ARN or tags. This exception also occurs
        /// when you call a tagging API on a cancelled signing profile.
        /// </exception>
        /// <exception cref="Amazon.Signer.Model.InternalServiceErrorException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.Signer.Model.NotFoundException">
        /// The signing profile was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/signer-2017-08-25/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse UntagResource(UntagResourceRequest request);



        /// <summary>
        /// Remove one or more tags from a signing profile. Specify a list of tag keys to remove
        /// the tags.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by Signer.</returns>
        /// <exception cref="Amazon.Signer.Model.BadRequestException">
        /// The request contains invalid parameters for the ARN or tags. This exception also occurs
        /// when you call a tagging API on a cancelled signing profile.
        /// </exception>
        /// <exception cref="Amazon.Signer.Model.InternalServiceErrorException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.Signer.Model.NotFoundException">
        /// The signing profile was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/signer-2017-08-25/UntagResource">REST API Reference for UntagResource Operation</seealso>
        Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}