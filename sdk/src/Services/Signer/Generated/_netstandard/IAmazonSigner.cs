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
 * Do not modify this file. This file is generated from the signer-2017-08-25.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.Signer.Model;

#pragma warning disable CS1570
namespace Amazon.Signer
{
    /// <summary>
    /// <para>Interface for accessing Signer</para>
    ///
    /// AWS Signer is a fully managed code-signing service to help you ensure the trust and
    /// integrity of your code. 
    /// 
    ///  
    /// <para>
    /// Signer supports the following applications:
    /// </para>
    ///  
    /// <para>
    /// With code signing for AWS Lambda, you can sign <a href="http://docs.aws.amazon.com/lambda/latest/dg/">AWS
    /// Lambda</a> deployment packages. Integrated support is provided for <a href="http://docs.aws.amazon.com/AmazonS3/latest/gsg/">Amazon
    /// S3</a>, <a href="http://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/">Amazon
    /// CloudWatch</a>, and <a href="http://docs.aws.amazon.com/awscloudtrail/latest/userguide/">AWS
    /// CloudTrail</a>. In order to sign code, you create a signing profile and then use Signer
    /// to sign Lambda zip files in S3. 
    /// </para>
    ///  
    /// <para>
    /// With code signing for IoT, you can sign code for any IoT device that is supported
    /// by AWS. IoT code signing is available for <a href="http://docs.aws.amazon.com/freertos/latest/userguide/">Amazon
    /// FreeRTOS</a> and <a href="http://docs.aws.amazon.com/iot/latest/developerguide/">AWS
    /// IoT Device Management</a>, and is integrated with <a href="http://docs.aws.amazon.com/acm/latest/userguide/">AWS
    /// Certificate Manager (ACM)</a>. In order to sign code, you import a third-party code-signing
    /// certificate using ACM, and use that to sign updates in Amazon FreeRTOS and AWS IoT
    /// Device Management. 
    /// </para>
    ///  
    /// <para>
    /// With Signer and the Notation CLI from the <a href="https://notaryproject.dev/">Notary&#x2028;
    /// Project</a>, you can sign container images stored in a container registry such as
    /// Amazon Elastic Container Registry (ECR). The signatures are stored in the registry
    /// alongside the images, where they are available for verifying image authenticity and
    /// integrity.
    /// </para>
    ///  
    /// <para>
    /// For more information about Signer, see the <a href="https://docs.aws.amazon.com/signer/latest/developerguide/Welcome.html">AWS
    /// Signer Developer Guide</a>.
    /// </para>
    /// </summary>
    public partial interface IAmazonSigner : IAmazonService, IDisposable
    {
#if AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        ISignerPaginatorFactory Paginators { get; }
#endif
                
        #region  AddProfilePermission



        /// <summary>
        /// Adds cross-account permissions to a signing profile.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddProfilePermission service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AddProfilePermission service method, as returned by Signer.</returns>
        /// <exception cref="Amazon.Signer.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Signer.Model.ConflictException">
        /// The resource encountered a conflicting state.
        /// </exception>
        /// <exception cref="Amazon.Signer.Model.InternalServiceErrorException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.Signer.Model.ResourceNotFoundException">
        /// A specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.Signer.Model.ServiceLimitExceededException">
        /// The client is making a request that exceeds service limits.
        /// </exception>
        /// <exception cref="Amazon.Signer.Model.TooManyRequestsException">
        /// The allowed number of job-signing requests has been exceeded.
        /// 
        ///  
        /// <para>
        /// This error supersedes the error <c>ThrottlingException</c>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Signer.Model.ValidationException">
        /// You signing certificate could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/signer-2017-08-25/AddProfilePermission">REST API Reference for AddProfilePermission Operation</seealso>
        Task<AddProfilePermissionResponse> AddProfilePermissionAsync(AddProfilePermissionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CancelSigningProfile



        /// <summary>
        /// Changes the state of an <c>ACTIVE</c> signing profile to <c>CANCELED</c>. A canceled
        /// profile is still viewable with the <c>ListSigningProfiles</c> operation, but it cannot
        /// perform new signing jobs, and is deleted two years after cancelation.
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
        /// <exception cref="Amazon.Signer.Model.TooManyRequestsException">
        /// The allowed number of job-signing requests has been exceeded.
        /// 
        ///  
        /// <para>
        /// This error supersedes the error <c>ThrottlingException</c>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/signer-2017-08-25/CancelSigningProfile">REST API Reference for CancelSigningProfile Operation</seealso>
        Task<CancelSigningProfileResponse> CancelSigningProfileAsync(CancelSigningProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeSigningJob



        /// <summary>
        /// Returns information about a specific code signing job. You specify the job by using
        /// the <c>jobId</c> value that is returned by the <a>StartSigningJob</a> operation.
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
        /// <exception cref="Amazon.Signer.Model.TooManyRequestsException">
        /// The allowed number of job-signing requests has been exceeded.
        /// 
        ///  
        /// <para>
        /// This error supersedes the error <c>ThrottlingException</c>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/signer-2017-08-25/DescribeSigningJob">REST API Reference for DescribeSigningJob Operation</seealso>
        Task<DescribeSigningJobResponse> DescribeSigningJobAsync(DescribeSigningJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetRevocationStatus



        /// <summary>
        /// Retrieves the revocation status of one or more of the signing profile, signing job,
        /// and signing certificate.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRevocationStatus service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetRevocationStatus service method, as returned by Signer.</returns>
        /// <exception cref="Amazon.Signer.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Signer.Model.InternalServiceErrorException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.Signer.Model.TooManyRequestsException">
        /// The allowed number of job-signing requests has been exceeded.
        /// 
        ///  
        /// <para>
        /// This error supersedes the error <c>ThrottlingException</c>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Signer.Model.ValidationException">
        /// You signing certificate could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/signer-2017-08-25/GetRevocationStatus">REST API Reference for GetRevocationStatus Operation</seealso>
        Task<GetRevocationStatusResponse> GetRevocationStatusAsync(GetRevocationStatusRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetSigningPlatform



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
        /// <exception cref="Amazon.Signer.Model.TooManyRequestsException">
        /// The allowed number of job-signing requests has been exceeded.
        /// 
        ///  
        /// <para>
        /// This error supersedes the error <c>ThrottlingException</c>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/signer-2017-08-25/GetSigningPlatform">REST API Reference for GetSigningPlatform Operation</seealso>
        Task<GetSigningPlatformResponse> GetSigningPlatformAsync(GetSigningPlatformRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetSigningProfile



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
        /// <exception cref="Amazon.Signer.Model.TooManyRequestsException">
        /// The allowed number of job-signing requests has been exceeded.
        /// 
        ///  
        /// <para>
        /// This error supersedes the error <c>ThrottlingException</c>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/signer-2017-08-25/GetSigningProfile">REST API Reference for GetSigningProfile Operation</seealso>
        Task<GetSigningProfileResponse> GetSigningProfileAsync(GetSigningProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListProfilePermissions



        /// <summary>
        /// Lists the cross-account permissions associated with a signing profile.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListProfilePermissions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListProfilePermissions service method, as returned by Signer.</returns>
        /// <exception cref="Amazon.Signer.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Signer.Model.InternalServiceErrorException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.Signer.Model.ResourceNotFoundException">
        /// A specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.Signer.Model.TooManyRequestsException">
        /// The allowed number of job-signing requests has been exceeded.
        /// 
        ///  
        /// <para>
        /// This error supersedes the error <c>ThrottlingException</c>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Signer.Model.ValidationException">
        /// You signing certificate could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/signer-2017-08-25/ListProfilePermissions">REST API Reference for ListProfilePermissions Operation</seealso>
        Task<ListProfilePermissionsResponse> ListProfilePermissionsAsync(ListProfilePermissionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListSigningJobs



        /// <summary>
        /// Lists all your signing jobs. You can use the <c>maxResults</c> parameter to limit
        /// the number of signing jobs that are returned in the response. If additional jobs remain
        /// to be listed, AWS Signer returns a <c>nextToken</c> value. Use this value in subsequent
        /// calls to <c>ListSigningJobs</c> to fetch the remaining values. You can continue calling
        /// <c>ListSigningJobs</c> with your <c>maxResults</c> parameter and with new values that
        /// Signer returns in the <c>nextToken</c> parameter until all of your signing jobs have
        /// been returned.
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
        /// <exception cref="Amazon.Signer.Model.TooManyRequestsException">
        /// The allowed number of job-signing requests has been exceeded.
        /// 
        ///  
        /// <para>
        /// This error supersedes the error <c>ThrottlingException</c>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Signer.Model.ValidationException">
        /// You signing certificate could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/signer-2017-08-25/ListSigningJobs">REST API Reference for ListSigningJobs Operation</seealso>
        Task<ListSigningJobsResponse> ListSigningJobsAsync(ListSigningJobsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListSigningPlatforms



        /// <summary>
        /// Lists all signing platforms available in AWS Signer that match the request parameters.
        /// If additional jobs remain to be listed, Signer returns a <c>nextToken</c> value. Use
        /// this value in subsequent calls to <c>ListSigningJobs</c> to fetch the remaining values.
        /// You can continue calling <c>ListSigningJobs</c> with your <c>maxResults</c> parameter
        /// and with new values that Signer returns in the <c>nextToken</c> parameter until all
        /// of your signing jobs have been returned.
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
        /// <exception cref="Amazon.Signer.Model.TooManyRequestsException">
        /// The allowed number of job-signing requests has been exceeded.
        /// 
        ///  
        /// <para>
        /// This error supersedes the error <c>ThrottlingException</c>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Signer.Model.ValidationException">
        /// You signing certificate could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/signer-2017-08-25/ListSigningPlatforms">REST API Reference for ListSigningPlatforms Operation</seealso>
        Task<ListSigningPlatformsResponse> ListSigningPlatformsAsync(ListSigningPlatformsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListSigningProfiles



        /// <summary>
        /// Lists all available signing profiles in your AWS account. Returns only profiles with
        /// an <c>ACTIVE</c> status unless the <c>includeCanceled</c> request field is set to
        /// <c>true</c>. If additional jobs remain to be listed, AWS Signer returns a <c>nextToken</c>
        /// value. Use this value in subsequent calls to <c>ListSigningJobs</c> to fetch the remaining
        /// values. You can continue calling <c>ListSigningJobs</c> with your <c>maxResults</c>
        /// parameter and with new values that Signer returns in the <c>nextToken</c> parameter
        /// until all of your signing jobs have been returned.
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
        /// <exception cref="Amazon.Signer.Model.TooManyRequestsException">
        /// The allowed number of job-signing requests has been exceeded.
        /// 
        ///  
        /// <para>
        /// This error supersedes the error <c>ThrottlingException</c>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/signer-2017-08-25/ListSigningProfiles">REST API Reference for ListSigningProfiles Operation</seealso>
        Task<ListSigningProfilesResponse> ListSigningProfilesAsync(ListSigningProfilesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListTagsForResource



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
        /// <exception cref="Amazon.Signer.Model.TooManyRequestsException">
        /// The allowed number of job-signing requests has been exceeded.
        /// 
        ///  
        /// <para>
        /// This error supersedes the error <c>ThrottlingException</c>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/signer-2017-08-25/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  PutSigningProfile



        /// <summary>
        /// Creates a signing profile. A signing profile is a code-signing template that can be
        /// used to carry out a pre-defined signing job.
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
        /// <exception cref="Amazon.Signer.Model.TooManyRequestsException">
        /// The allowed number of job-signing requests has been exceeded.
        /// 
        ///  
        /// <para>
        /// This error supersedes the error <c>ThrottlingException</c>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Signer.Model.ValidationException">
        /// You signing certificate could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/signer-2017-08-25/PutSigningProfile">REST API Reference for PutSigningProfile Operation</seealso>
        Task<PutSigningProfileResponse> PutSigningProfileAsync(PutSigningProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  RemoveProfilePermission



        /// <summary>
        /// Removes cross-account permissions from a signing profile.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemoveProfilePermission service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RemoveProfilePermission service method, as returned by Signer.</returns>
        /// <exception cref="Amazon.Signer.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Signer.Model.ConflictException">
        /// The resource encountered a conflicting state.
        /// </exception>
        /// <exception cref="Amazon.Signer.Model.InternalServiceErrorException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.Signer.Model.ResourceNotFoundException">
        /// A specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.Signer.Model.TooManyRequestsException">
        /// The allowed number of job-signing requests has been exceeded.
        /// 
        ///  
        /// <para>
        /// This error supersedes the error <c>ThrottlingException</c>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Signer.Model.ValidationException">
        /// You signing certificate could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/signer-2017-08-25/RemoveProfilePermission">REST API Reference for RemoveProfilePermission Operation</seealso>
        Task<RemoveProfilePermissionResponse> RemoveProfilePermissionAsync(RemoveProfilePermissionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  RevokeSignature



        /// <summary>
        /// Changes the state of a signing job to REVOKED. This indicates that the signature is
        /// no longer valid.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RevokeSignature service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RevokeSignature service method, as returned by Signer.</returns>
        /// <exception cref="Amazon.Signer.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Signer.Model.InternalServiceErrorException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.Signer.Model.ResourceNotFoundException">
        /// A specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.Signer.Model.TooManyRequestsException">
        /// The allowed number of job-signing requests has been exceeded.
        /// 
        ///  
        /// <para>
        /// This error supersedes the error <c>ThrottlingException</c>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Signer.Model.ValidationException">
        /// You signing certificate could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/signer-2017-08-25/RevokeSignature">REST API Reference for RevokeSignature Operation</seealso>
        Task<RevokeSignatureResponse> RevokeSignatureAsync(RevokeSignatureRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  RevokeSigningProfile



        /// <summary>
        /// Changes the state of a signing profile to REVOKED. This indicates that signatures
        /// generated using the signing profile after an effective start date are no longer valid.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RevokeSigningProfile service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RevokeSigningProfile service method, as returned by Signer.</returns>
        /// <exception cref="Amazon.Signer.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Signer.Model.InternalServiceErrorException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.Signer.Model.ResourceNotFoundException">
        /// A specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.Signer.Model.TooManyRequestsException">
        /// The allowed number of job-signing requests has been exceeded.
        /// 
        ///  
        /// <para>
        /// This error supersedes the error <c>ThrottlingException</c>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Signer.Model.ValidationException">
        /// You signing certificate could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/signer-2017-08-25/RevokeSigningProfile">REST API Reference for RevokeSigningProfile Operation</seealso>
        Task<RevokeSigningProfileResponse> RevokeSigningProfileAsync(RevokeSigningProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  SignPayload



        /// <summary>
        /// Signs a binary payload and returns a signature envelope.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SignPayload service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SignPayload service method, as returned by Signer.</returns>
        /// <exception cref="Amazon.Signer.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Signer.Model.InternalServiceErrorException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.Signer.Model.ResourceNotFoundException">
        /// A specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.Signer.Model.TooManyRequestsException">
        /// The allowed number of job-signing requests has been exceeded.
        /// 
        ///  
        /// <para>
        /// This error supersedes the error <c>ThrottlingException</c>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Signer.Model.ValidationException">
        /// You signing certificate could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/signer-2017-08-25/SignPayload">REST API Reference for SignPayload Operation</seealso>
        Task<SignPayloadResponse> SignPayloadAsync(SignPayloadRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  StartSigningJob



        /// <summary>
        /// Initiates a signing job to be performed on the code provided. Signing jobs are viewable
        /// by the <c>ListSigningJobs</c> operation for two years after they are performed. Note
        /// the following requirements: 
        /// 
        ///  <ul> <li> 
        /// <para>
        ///  You must create an Amazon S3 source bucket. For more information, see <a href="http://docs.aws.amazon.com/AmazonS3/latest/gsg/CreatingABucket.html">Creating
        /// a Bucket</a> in the <i>Amazon S3 Getting Started Guide</i>. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your S3 source bucket must be version enabled.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You must create an S3 destination bucket. AWS Signer uses your S3 destination bucket
        /// to write your signed code.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You specify the name of the source and destination buckets when calling the <c>StartSigningJob</c>
        /// operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You must ensure the S3 buckets are from the same Region as the signing profile. Cross-Region
        /// signing isn't supported.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You must also specify a request token that identifies your request to Signer.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// You can call the <a>DescribeSigningJob</a> and the <a>ListSigningJobs</a> actions
        /// after you call <c>StartSigningJob</c>.
        /// </para>
        ///  
        /// <para>
        /// For a Java example that shows how to use this action, see <a href="https://docs.aws.amazon.com/signer/latest/developerguide/api-startsigningjob.html">StartSigningJob</a>.
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
        /// The request was denied due to request throttling.
        /// 
        ///  
        /// <para>
        /// Instead of this error, <c>TooManyRequestsException</c> should be used.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Signer.Model.TooManyRequestsException">
        /// The allowed number of job-signing requests has been exceeded.
        /// 
        ///  
        /// <para>
        /// This error supersedes the error <c>ThrottlingException</c>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Signer.Model.ValidationException">
        /// You signing certificate could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/signer-2017-08-25/StartSigningJob">REST API Reference for StartSigningJob Operation</seealso>
        Task<StartSigningJobResponse> StartSigningJobAsync(StartSigningJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  TagResource



        /// <summary>
        /// Adds one or more tags to a signing profile. Tags are labels that you can use to identify
        /// and organize your AWS resources. Each tag consists of a key and an optional value.
        /// To specify the signing profile, use its Amazon Resource Name (ARN). To specify the
        /// tag, use a key-value pair.
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
        /// <exception cref="Amazon.Signer.Model.TooManyRequestsException">
        /// The allowed number of job-signing requests has been exceeded.
        /// 
        ///  
        /// <para>
        /// This error supersedes the error <c>ThrottlingException</c>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/signer-2017-08-25/TagResource">REST API Reference for TagResource Operation</seealso>
        Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UntagResource



        /// <summary>
        /// Removes one or more tags from a signing profile. To remove the tags, specify a list
        /// of tag keys.
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
        /// <exception cref="Amazon.Signer.Model.TooManyRequestsException">
        /// The allowed number of job-signing requests has been exceeded.
        /// 
        ///  
        /// <para>
        /// This error supersedes the error <c>ThrottlingException</c>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/signer-2017-08-25/UntagResource">REST API Reference for UntagResource Operation</seealso>
        Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region DetermineServiceOperationEndpoint

        /// <summary>
        /// Returns the endpoint that will be used for a particular request.
        /// </summary>
        /// <param name="request">Request for the desired service operation.</param>
        /// <returns>The resolved endpoint for the given request.</returns>
        Amazon.Runtime.Endpoints.Endpoint DetermineServiceOperationEndpoint(AmazonWebServiceRequest request);
        
        #endregion

        #region Static factory interface methods
#if NET8_0_OR_GREATER
// Warning CA1033 is issued when the child types can not call the method defined in parent types.
// In this use case the intended caller is only meant to be the interface as a factory
// method to create the child types. Given the SDK use case the warning can be ignored.
#pragma warning disable CA1033
        /// <inheritdoc/>
        [System.Diagnostics.CodeAnalysis.DynamicDependency(System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypes.PublicProperties, typeof(AmazonSignerConfig))]
        static ClientConfig IAmazonService.CreateDefaultClientConfig() => new AmazonSignerConfig();

        /// <inheritdoc/>
        [System.Diagnostics.CodeAnalysis.UnconditionalSuppressMessage("AssemblyLoadTrimming", "IL2026:RequiresUnreferencedCode",
    Justification = "This suppression is here to ignore the warnings caused by CognitoSync. See justification in IAmazonService.")]
        static IAmazonService IAmazonService.CreateDefaultServiceClient(AWSCredentials awsCredentials, ClientConfig clientConfig)
        {
            var serviceClientConfig = clientConfig as AmazonSignerConfig;
            if (serviceClientConfig == null)
            {
                throw new AmazonClientException("ClientConfig is not of type AmazonSignerConfig to create AmazonSignerClient");
            }

            return awsCredentials == null ? 
                    new AmazonSignerClient(serviceClientConfig) :
                    new AmazonSignerClient(awsCredentials, serviceClientConfig);
        }
#pragma warning restore CA1033
#endif
        #endregion
    }
}