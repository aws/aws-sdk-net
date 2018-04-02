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
 * Do not modify this file. This file is generated from the cloudfront-2017-10-30.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.CloudFront.Model;

namespace Amazon.CloudFront
{
    /// <summary>
    /// Interface for accessing CloudFront
    ///
    /// Amazon CloudFront 
    /// <para>
    /// This is the <i>Amazon CloudFront API Reference</i>. This guide is for developers who
    /// need detailed information about CloudFront API actions, data types, and errors. For
    /// detailed information about CloudFront features, see the <i>Amazon CloudFront Developer
    /// Guide</i>.
    /// </para>
    /// </summary>
    public partial interface IAmazonCloudFront : IAmazonService, IDisposable
    {
                
        #region  CreateCloudFrontOriginAccessIdentity


        /// <summary>
        /// Initiates the asynchronous execution of the CreateCloudFrontOriginAccessIdentity operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateCloudFrontOriginAccessIdentity operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/CreateCloudFrontOriginAccessIdentity">REST API Reference for CreateCloudFrontOriginAccessIdentity Operation</seealso>
        Task<CreateCloudFrontOriginAccessIdentityResponse> CreateCloudFrontOriginAccessIdentityAsync(CreateCloudFrontOriginAccessIdentityRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateDistribution


        /// <summary>
        /// Initiates the asynchronous execution of the CreateDistribution operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDistribution operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/CreateDistribution">REST API Reference for CreateDistribution Operation</seealso>
        Task<CreateDistributionResponse> CreateDistributionAsync(CreateDistributionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateDistributionWithTags


        /// <summary>
        /// Initiates the asynchronous execution of the CreateDistributionWithTags operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDistributionWithTags operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/CreateDistributionWithTags">REST API Reference for CreateDistributionWithTags Operation</seealso>
        Task<CreateDistributionWithTagsResponse> CreateDistributionWithTagsAsync(CreateDistributionWithTagsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateFieldLevelEncryptionConfig


        /// <summary>
        /// Initiates the asynchronous execution of the CreateFieldLevelEncryptionConfig operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateFieldLevelEncryptionConfig operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/CreateFieldLevelEncryptionConfig">REST API Reference for CreateFieldLevelEncryptionConfig Operation</seealso>
        Task<CreateFieldLevelEncryptionConfigResponse> CreateFieldLevelEncryptionConfigAsync(CreateFieldLevelEncryptionConfigRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateFieldLevelEncryptionProfile


        /// <summary>
        /// Initiates the asynchronous execution of the CreateFieldLevelEncryptionProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateFieldLevelEncryptionProfile operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/CreateFieldLevelEncryptionProfile">REST API Reference for CreateFieldLevelEncryptionProfile Operation</seealso>
        Task<CreateFieldLevelEncryptionProfileResponse> CreateFieldLevelEncryptionProfileAsync(CreateFieldLevelEncryptionProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateInvalidation


        /// <summary>
        /// Initiates the asynchronous execution of the CreateInvalidation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateInvalidation operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/CreateInvalidation">REST API Reference for CreateInvalidation Operation</seealso>
        Task<CreateInvalidationResponse> CreateInvalidationAsync(CreateInvalidationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreatePublicKey


        /// <summary>
        /// Initiates the asynchronous execution of the CreatePublicKey operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreatePublicKey operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/CreatePublicKey">REST API Reference for CreatePublicKey Operation</seealso>
        Task<CreatePublicKeyResponse> CreatePublicKeyAsync(CreatePublicKeyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateStreamingDistribution


        /// <summary>
        /// Initiates the asynchronous execution of the CreateStreamingDistribution operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateStreamingDistribution operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/CreateStreamingDistribution">REST API Reference for CreateStreamingDistribution Operation</seealso>
        Task<CreateStreamingDistributionResponse> CreateStreamingDistributionAsync(CreateStreamingDistributionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateStreamingDistributionWithTags


        /// <summary>
        /// Initiates the asynchronous execution of the CreateStreamingDistributionWithTags operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateStreamingDistributionWithTags operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/CreateStreamingDistributionWithTags">REST API Reference for CreateStreamingDistributionWithTags Operation</seealso>
        Task<CreateStreamingDistributionWithTagsResponse> CreateStreamingDistributionWithTagsAsync(CreateStreamingDistributionWithTagsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteCloudFrontOriginAccessIdentity


        /// <summary>
        /// Delete an origin access identity.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteCloudFrontOriginAccessIdentity service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.CloudFrontOriginAccessIdentityInUseException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidIfMatchVersionException">
        /// The <code>If-Match</code> version is missing or not valid for the distribution.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchCloudFrontOriginAccessIdentityException">
        /// The specified origin access identity does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.PreconditionFailedException">
        /// The precondition given in one or more of the request-header fields evaluated to <code>false</code>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/DeleteCloudFrontOriginAccessIdentity">REST API Reference for DeleteCloudFrontOriginAccessIdentity Operation</seealso>
        Task<DeleteCloudFrontOriginAccessIdentityResponse> DeleteCloudFrontOriginAccessIdentityAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteCloudFrontOriginAccessIdentity operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteCloudFrontOriginAccessIdentity operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/DeleteCloudFrontOriginAccessIdentity">REST API Reference for DeleteCloudFrontOriginAccessIdentity Operation</seealso>
        Task<DeleteCloudFrontOriginAccessIdentityResponse> DeleteCloudFrontOriginAccessIdentityAsync(DeleteCloudFrontOriginAccessIdentityRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteDistribution


        /// <summary>
        /// Delete a distribution.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteDistribution service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.DistributionNotDisabledException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidIfMatchVersionException">
        /// The <code>If-Match</code> version is missing or not valid for the distribution.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchDistributionException">
        /// The specified distribution does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.PreconditionFailedException">
        /// The precondition given in one or more of the request-header fields evaluated to <code>false</code>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/DeleteDistribution">REST API Reference for DeleteDistribution Operation</seealso>
        Task<DeleteDistributionResponse> DeleteDistributionAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDistribution operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDistribution operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/DeleteDistribution">REST API Reference for DeleteDistribution Operation</seealso>
        Task<DeleteDistributionResponse> DeleteDistributionAsync(DeleteDistributionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteFieldLevelEncryptionConfig


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteFieldLevelEncryptionConfig operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteFieldLevelEncryptionConfig operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/DeleteFieldLevelEncryptionConfig">REST API Reference for DeleteFieldLevelEncryptionConfig Operation</seealso>
        Task<DeleteFieldLevelEncryptionConfigResponse> DeleteFieldLevelEncryptionConfigAsync(DeleteFieldLevelEncryptionConfigRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteFieldLevelEncryptionProfile


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteFieldLevelEncryptionProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteFieldLevelEncryptionProfile operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/DeleteFieldLevelEncryptionProfile">REST API Reference for DeleteFieldLevelEncryptionProfile Operation</seealso>
        Task<DeleteFieldLevelEncryptionProfileResponse> DeleteFieldLevelEncryptionProfileAsync(DeleteFieldLevelEncryptionProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeletePublicKey


        /// <summary>
        /// Initiates the asynchronous execution of the DeletePublicKey operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeletePublicKey operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/DeletePublicKey">REST API Reference for DeletePublicKey Operation</seealso>
        Task<DeletePublicKeyResponse> DeletePublicKeyAsync(DeletePublicKeyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteServiceLinkedRole


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteServiceLinkedRole operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteServiceLinkedRole operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/DeleteServiceLinkedRole">REST API Reference for DeleteServiceLinkedRole Operation</seealso>
        Task<DeleteServiceLinkedRoleResponse> DeleteServiceLinkedRoleAsync(DeleteServiceLinkedRoleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteStreamingDistribution


        /// <summary>
        /// Delete a streaming distribution. To delete an RTMP distribution using the CloudFront
        /// API, perform the following steps.
        /// 
        ///  
        /// <para>
        ///  <b>To delete an RTMP distribution using the CloudFront API</b>:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Disable the RTMP distribution.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit a <code>GET Streaming Distribution Config</code> request to get the current
        /// configuration and the <code>Etag</code> header for the distribution. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Update the XML document that was returned in the response to your <code>GET Streaming
        /// Distribution Config</code> request to change the value of <code>Enabled</code> to
        /// <code>false</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit a <code>PUT Streaming Distribution Config</code> request to update the configuration
        /// for your distribution. In the request body, include the XML document that you updated
        /// in Step 3. Then set the value of the HTTP <code>If-Match</code> header to the value
        /// of the <code>ETag</code> header that CloudFront returned when you submitted the <code>GET
        /// Streaming Distribution Config</code> request in Step 2.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Review the response to the <code>PUT Streaming Distribution Config</code> request
        /// to confirm that the distribution was successfully disabled.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit a <code>GET Streaming Distribution Config</code> request to confirm that your
        /// changes have propagated. When propagation is complete, the value of <code>Status</code>
        /// is <code>Deployed</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit a <code>DELETE Streaming Distribution</code> request. Set the value of the
        /// HTTP <code>If-Match</code> header to the value of the <code>ETag</code> header that
        /// CloudFront returned when you submitted the <code>GET Streaming Distribution Config</code>
        /// request in Step 2.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Review the response to your <code>DELETE Streaming Distribution</code> request to
        /// confirm that the distribution was successfully deleted.
        /// </para>
        ///  </li> </ol> 
        /// <para>
        /// For information about deleting a distribution using the CloudFront console, see <a
        /// href="http://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/HowToDeleteDistribution.html">Deleting
        /// a Distribution</a> in the <i>Amazon CloudFront Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteStreamingDistribution service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.InvalidIfMatchVersionException">
        /// The <code>If-Match</code> version is missing or not valid for the distribution.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchStreamingDistributionException">
        /// The specified streaming distribution does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.PreconditionFailedException">
        /// The precondition given in one or more of the request-header fields evaluated to <code>false</code>.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.StreamingDistributionNotDisabledException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/DeleteStreamingDistribution">REST API Reference for DeleteStreamingDistribution Operation</seealso>
        Task<DeleteStreamingDistributionResponse> DeleteStreamingDistributionAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteStreamingDistribution operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteStreamingDistribution operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/DeleteStreamingDistribution">REST API Reference for DeleteStreamingDistribution Operation</seealso>
        Task<DeleteStreamingDistributionResponse> DeleteStreamingDistributionAsync(DeleteStreamingDistributionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetCloudFrontOriginAccessIdentity


        /// <summary>
        /// Get the information about an origin access identity.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetCloudFrontOriginAccessIdentity service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchCloudFrontOriginAccessIdentityException">
        /// The specified origin access identity does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/GetCloudFrontOriginAccessIdentity">REST API Reference for GetCloudFrontOriginAccessIdentity Operation</seealso>
        Task<GetCloudFrontOriginAccessIdentityResponse> GetCloudFrontOriginAccessIdentityAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));


        /// <summary>
        /// Initiates the asynchronous execution of the GetCloudFrontOriginAccessIdentity operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetCloudFrontOriginAccessIdentity operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/GetCloudFrontOriginAccessIdentity">REST API Reference for GetCloudFrontOriginAccessIdentity Operation</seealso>
        Task<GetCloudFrontOriginAccessIdentityResponse> GetCloudFrontOriginAccessIdentityAsync(GetCloudFrontOriginAccessIdentityRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetCloudFrontOriginAccessIdentityConfig


        /// <summary>
        /// Get the configuration information about an origin access identity.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetCloudFrontOriginAccessIdentityConfig service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchCloudFrontOriginAccessIdentityException">
        /// The specified origin access identity does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/GetCloudFrontOriginAccessIdentityConfig">REST API Reference for GetCloudFrontOriginAccessIdentityConfig Operation</seealso>
        Task<GetCloudFrontOriginAccessIdentityConfigResponse> GetCloudFrontOriginAccessIdentityConfigAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));


        /// <summary>
        /// Initiates the asynchronous execution of the GetCloudFrontOriginAccessIdentityConfig operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetCloudFrontOriginAccessIdentityConfig operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/GetCloudFrontOriginAccessIdentityConfig">REST API Reference for GetCloudFrontOriginAccessIdentityConfig Operation</seealso>
        Task<GetCloudFrontOriginAccessIdentityConfigResponse> GetCloudFrontOriginAccessIdentityConfigAsync(GetCloudFrontOriginAccessIdentityConfigRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetDistribution


        /// <summary>
        /// Get the information about a distribution.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetDistribution service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchDistributionException">
        /// The specified distribution does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/GetDistribution">REST API Reference for GetDistribution Operation</seealso>
        Task<GetDistributionResponse> GetDistributionAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));


        /// <summary>
        /// Initiates the asynchronous execution of the GetDistribution operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDistribution operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/GetDistribution">REST API Reference for GetDistribution Operation</seealso>
        Task<GetDistributionResponse> GetDistributionAsync(GetDistributionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetDistributionConfig


        /// <summary>
        /// Get the configuration information about a distribution.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetDistributionConfig service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchDistributionException">
        /// The specified distribution does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/GetDistributionConfig">REST API Reference for GetDistributionConfig Operation</seealso>
        Task<GetDistributionConfigResponse> GetDistributionConfigAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));


        /// <summary>
        /// Initiates the asynchronous execution of the GetDistributionConfig operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDistributionConfig operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/GetDistributionConfig">REST API Reference for GetDistributionConfig Operation</seealso>
        Task<GetDistributionConfigResponse> GetDistributionConfigAsync(GetDistributionConfigRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetFieldLevelEncryption


        /// <summary>
        /// Initiates the asynchronous execution of the GetFieldLevelEncryption operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetFieldLevelEncryption operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/GetFieldLevelEncryption">REST API Reference for GetFieldLevelEncryption Operation</seealso>
        Task<GetFieldLevelEncryptionResponse> GetFieldLevelEncryptionAsync(GetFieldLevelEncryptionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetFieldLevelEncryptionConfig


        /// <summary>
        /// Initiates the asynchronous execution of the GetFieldLevelEncryptionConfig operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetFieldLevelEncryptionConfig operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/GetFieldLevelEncryptionConfig">REST API Reference for GetFieldLevelEncryptionConfig Operation</seealso>
        Task<GetFieldLevelEncryptionConfigResponse> GetFieldLevelEncryptionConfigAsync(GetFieldLevelEncryptionConfigRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetFieldLevelEncryptionProfile


        /// <summary>
        /// Initiates the asynchronous execution of the GetFieldLevelEncryptionProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetFieldLevelEncryptionProfile operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/GetFieldLevelEncryptionProfile">REST API Reference for GetFieldLevelEncryptionProfile Operation</seealso>
        Task<GetFieldLevelEncryptionProfileResponse> GetFieldLevelEncryptionProfileAsync(GetFieldLevelEncryptionProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetFieldLevelEncryptionProfileConfig


        /// <summary>
        /// Initiates the asynchronous execution of the GetFieldLevelEncryptionProfileConfig operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetFieldLevelEncryptionProfileConfig operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/GetFieldLevelEncryptionProfileConfig">REST API Reference for GetFieldLevelEncryptionProfileConfig Operation</seealso>
        Task<GetFieldLevelEncryptionProfileConfigResponse> GetFieldLevelEncryptionProfileConfigAsync(GetFieldLevelEncryptionProfileConfigRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetInvalidation


        /// <summary>
        /// Initiates the asynchronous execution of the GetInvalidation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetInvalidation operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/GetInvalidation">REST API Reference for GetInvalidation Operation</seealso>
        Task<GetInvalidationResponse> GetInvalidationAsync(GetInvalidationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetPublicKey


        /// <summary>
        /// Initiates the asynchronous execution of the GetPublicKey operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetPublicKey operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/GetPublicKey">REST API Reference for GetPublicKey Operation</seealso>
        Task<GetPublicKeyResponse> GetPublicKeyAsync(GetPublicKeyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetPublicKeyConfig


        /// <summary>
        /// Initiates the asynchronous execution of the GetPublicKeyConfig operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetPublicKeyConfig operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/GetPublicKeyConfig">REST API Reference for GetPublicKeyConfig Operation</seealso>
        Task<GetPublicKeyConfigResponse> GetPublicKeyConfigAsync(GetPublicKeyConfigRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetStreamingDistribution


        /// <summary>
        /// Gets information about a specified RTMP distribution, including the distribution configuration.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetStreamingDistribution service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchStreamingDistributionException">
        /// The specified streaming distribution does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/GetStreamingDistribution">REST API Reference for GetStreamingDistribution Operation</seealso>
        Task<GetStreamingDistributionResponse> GetStreamingDistributionAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));


        /// <summary>
        /// Initiates the asynchronous execution of the GetStreamingDistribution operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetStreamingDistribution operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/GetStreamingDistribution">REST API Reference for GetStreamingDistribution Operation</seealso>
        Task<GetStreamingDistributionResponse> GetStreamingDistributionAsync(GetStreamingDistributionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetStreamingDistributionConfig


        /// <summary>
        /// Get the configuration information about a streaming distribution.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetStreamingDistributionConfig service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.CloudFront.Model.NoSuchStreamingDistributionException">
        /// The specified streaming distribution does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/GetStreamingDistributionConfig">REST API Reference for GetStreamingDistributionConfig Operation</seealso>
        Task<GetStreamingDistributionConfigResponse> GetStreamingDistributionConfigAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));


        /// <summary>
        /// Initiates the asynchronous execution of the GetStreamingDistributionConfig operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetStreamingDistributionConfig operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/GetStreamingDistributionConfig">REST API Reference for GetStreamingDistributionConfig Operation</seealso>
        Task<GetStreamingDistributionConfigResponse> GetStreamingDistributionConfigAsync(GetStreamingDistributionConfigRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListCloudFrontOriginAccessIdentities


        /// <summary>
        /// Lists origin access identities.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListCloudFrontOriginAccessIdentities service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.InvalidArgumentException">
        /// The argument is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/ListCloudFrontOriginAccessIdentities">REST API Reference for ListCloudFrontOriginAccessIdentities Operation</seealso>
        Task<ListCloudFrontOriginAccessIdentitiesResponse> ListCloudFrontOriginAccessIdentitiesAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));


        /// <summary>
        /// Initiates the asynchronous execution of the ListCloudFrontOriginAccessIdentities operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListCloudFrontOriginAccessIdentities operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/ListCloudFrontOriginAccessIdentities">REST API Reference for ListCloudFrontOriginAccessIdentities Operation</seealso>
        Task<ListCloudFrontOriginAccessIdentitiesResponse> ListCloudFrontOriginAccessIdentitiesAsync(ListCloudFrontOriginAccessIdentitiesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListDistributions


        /// <summary>
        /// List distributions.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListDistributions service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.InvalidArgumentException">
        /// The argument is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/ListDistributions">REST API Reference for ListDistributions Operation</seealso>
        Task<ListDistributionsResponse> ListDistributionsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));


        /// <summary>
        /// Initiates the asynchronous execution of the ListDistributions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDistributions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/ListDistributions">REST API Reference for ListDistributions Operation</seealso>
        Task<ListDistributionsResponse> ListDistributionsAsync(ListDistributionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListDistributionsByWebACLId


        /// <summary>
        /// Initiates the asynchronous execution of the ListDistributionsByWebACLId operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDistributionsByWebACLId operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/ListDistributionsByWebACLId">REST API Reference for ListDistributionsByWebACLId Operation</seealso>
        Task<ListDistributionsByWebACLIdResponse> ListDistributionsByWebACLIdAsync(ListDistributionsByWebACLIdRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListFieldLevelEncryptionConfigs


        /// <summary>
        /// Initiates the asynchronous execution of the ListFieldLevelEncryptionConfigs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListFieldLevelEncryptionConfigs operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/ListFieldLevelEncryptionConfigs">REST API Reference for ListFieldLevelEncryptionConfigs Operation</seealso>
        Task<ListFieldLevelEncryptionConfigsResponse> ListFieldLevelEncryptionConfigsAsync(ListFieldLevelEncryptionConfigsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListFieldLevelEncryptionProfiles


        /// <summary>
        /// Initiates the asynchronous execution of the ListFieldLevelEncryptionProfiles operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListFieldLevelEncryptionProfiles operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/ListFieldLevelEncryptionProfiles">REST API Reference for ListFieldLevelEncryptionProfiles Operation</seealso>
        Task<ListFieldLevelEncryptionProfilesResponse> ListFieldLevelEncryptionProfilesAsync(ListFieldLevelEncryptionProfilesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListInvalidations


        /// <summary>
        /// Initiates the asynchronous execution of the ListInvalidations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListInvalidations operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/ListInvalidations">REST API Reference for ListInvalidations Operation</seealso>
        Task<ListInvalidationsResponse> ListInvalidationsAsync(ListInvalidationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListPublicKeys


        /// <summary>
        /// Initiates the asynchronous execution of the ListPublicKeys operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListPublicKeys operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/ListPublicKeys">REST API Reference for ListPublicKeys Operation</seealso>
        Task<ListPublicKeysResponse> ListPublicKeysAsync(ListPublicKeysRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListStreamingDistributions


        /// <summary>
        /// List streaming distributions.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListStreamingDistributions service method, as returned by CloudFront.</returns>
        /// <exception cref="Amazon.CloudFront.Model.InvalidArgumentException">
        /// The argument is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/ListStreamingDistributions">REST API Reference for ListStreamingDistributions Operation</seealso>
        Task<ListStreamingDistributionsResponse> ListStreamingDistributionsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));


        /// <summary>
        /// Initiates the asynchronous execution of the ListStreamingDistributions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListStreamingDistributions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/ListStreamingDistributions">REST API Reference for ListStreamingDistributions Operation</seealso>
        Task<ListStreamingDistributionsResponse> ListStreamingDistributionsAsync(ListStreamingDistributionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListTagsForResource


        /// <summary>
        /// Initiates the asynchronous execution of the ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  TagResource


        /// <summary>
        /// Initiates the asynchronous execution of the TagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/TagResource">REST API Reference for TagResource Operation</seealso>
        Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UntagResource


        /// <summary>
        /// Initiates the asynchronous execution of the UntagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/UntagResource">REST API Reference for UntagResource Operation</seealso>
        Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateCloudFrontOriginAccessIdentity


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateCloudFrontOriginAccessIdentity operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateCloudFrontOriginAccessIdentity operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/UpdateCloudFrontOriginAccessIdentity">REST API Reference for UpdateCloudFrontOriginAccessIdentity Operation</seealso>
        Task<UpdateCloudFrontOriginAccessIdentityResponse> UpdateCloudFrontOriginAccessIdentityAsync(UpdateCloudFrontOriginAccessIdentityRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateDistribution


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateDistribution operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateDistribution operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/UpdateDistribution">REST API Reference for UpdateDistribution Operation</seealso>
        Task<UpdateDistributionResponse> UpdateDistributionAsync(UpdateDistributionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateFieldLevelEncryptionConfig


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateFieldLevelEncryptionConfig operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateFieldLevelEncryptionConfig operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/UpdateFieldLevelEncryptionConfig">REST API Reference for UpdateFieldLevelEncryptionConfig Operation</seealso>
        Task<UpdateFieldLevelEncryptionConfigResponse> UpdateFieldLevelEncryptionConfigAsync(UpdateFieldLevelEncryptionConfigRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateFieldLevelEncryptionProfile


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateFieldLevelEncryptionProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateFieldLevelEncryptionProfile operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/UpdateFieldLevelEncryptionProfile">REST API Reference for UpdateFieldLevelEncryptionProfile Operation</seealso>
        Task<UpdateFieldLevelEncryptionProfileResponse> UpdateFieldLevelEncryptionProfileAsync(UpdateFieldLevelEncryptionProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdatePublicKey


        /// <summary>
        /// Initiates the asynchronous execution of the UpdatePublicKey operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdatePublicKey operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/UpdatePublicKey">REST API Reference for UpdatePublicKey Operation</seealso>
        Task<UpdatePublicKeyResponse> UpdatePublicKeyAsync(UpdatePublicKeyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateStreamingDistribution


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateStreamingDistribution operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateStreamingDistribution operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudfront-2017-10-30/UpdateStreamingDistribution">REST API Reference for UpdateStreamingDistribution Operation</seealso>
        Task<UpdateStreamingDistributionResponse> UpdateStreamingDistributionAsync(UpdateStreamingDistributionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}