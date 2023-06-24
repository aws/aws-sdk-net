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
 * Do not modify this file. This file is generated from the nimble-2020-08-01.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.NimbleStudio.Model;

namespace Amazon.NimbleStudio
{
    /// <summary>
    /// Interface for accessing NimbleStudio
    ///
    /// Welcome to the Amazon Nimble Studio API reference. This API reference provides methods,
    /// schema, resources, parameters, and more to help you get the most out of Nimble Studio.
    /// 
    ///  
    /// <para>
    /// Nimble Studio is a virtual studio that empowers visual effects, animation, and interactive
    /// content teams to create content securely within a scalable, private cloud service.
    /// </para>
    /// </summary>
    public partial interface IAmazonNimbleStudio : IAmazonService, IDisposable
    {

        /// <summary>
        /// Paginators for the service
        /// </summary>
        INimbleStudioPaginatorFactory Paginators { get; }

        
        #region  AcceptEulas


        /// <summary>
        /// Accept EULAs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AcceptEulas service method.</param>
        /// 
        /// <returns>The response from the AcceptEulas service method, as returned by NimbleStudio.</returns>
        /// <exception cref="Amazon.NimbleStudio.Model.AccessDeniedException">
        /// You are not authorized to perform this operation. Check your IAM policies, and ensure
        /// that you are using the correct access keys.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ConflictException">
        /// Another operation is in progress.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.InternalServerErrorException">
        /// An internal error has occurred. Please retry your request.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ServiceQuotaExceededException">
        /// Your current quota does not allow you to perform the request action. You can request
        /// increases for some quotas, and other quotas cannot be increased.
        /// 
        ///  
        /// <para>
        /// Please use Amazon Web Services Service Quotas to request an increase. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ThrottlingException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ValidationException">
        /// One of the parameters in the request is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nimble-2020-08-01/AcceptEulas">REST API Reference for AcceptEulas Operation</seealso>
        AcceptEulasResponse AcceptEulas(AcceptEulasRequest request);



        /// <summary>
        /// Accept EULAs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AcceptEulas service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AcceptEulas service method, as returned by NimbleStudio.</returns>
        /// <exception cref="Amazon.NimbleStudio.Model.AccessDeniedException">
        /// You are not authorized to perform this operation. Check your IAM policies, and ensure
        /// that you are using the correct access keys.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ConflictException">
        /// Another operation is in progress.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.InternalServerErrorException">
        /// An internal error has occurred. Please retry your request.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ServiceQuotaExceededException">
        /// Your current quota does not allow you to perform the request action. You can request
        /// increases for some quotas, and other quotas cannot be increased.
        /// 
        ///  
        /// <para>
        /// Please use Amazon Web Services Service Quotas to request an increase. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ThrottlingException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ValidationException">
        /// One of the parameters in the request is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nimble-2020-08-01/AcceptEulas">REST API Reference for AcceptEulas Operation</seealso>
        Task<AcceptEulasResponse> AcceptEulasAsync(AcceptEulasRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateLaunchProfile


        /// <summary>
        /// Create a launch profile.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateLaunchProfile service method.</param>
        /// 
        /// <returns>The response from the CreateLaunchProfile service method, as returned by NimbleStudio.</returns>
        /// <exception cref="Amazon.NimbleStudio.Model.AccessDeniedException">
        /// You are not authorized to perform this operation. Check your IAM policies, and ensure
        /// that you are using the correct access keys.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ConflictException">
        /// Another operation is in progress.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.InternalServerErrorException">
        /// An internal error has occurred. Please retry your request.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ServiceQuotaExceededException">
        /// Your current quota does not allow you to perform the request action. You can request
        /// increases for some quotas, and other quotas cannot be increased.
        /// 
        ///  
        /// <para>
        /// Please use Amazon Web Services Service Quotas to request an increase. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ThrottlingException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ValidationException">
        /// One of the parameters in the request is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nimble-2020-08-01/CreateLaunchProfile">REST API Reference for CreateLaunchProfile Operation</seealso>
        CreateLaunchProfileResponse CreateLaunchProfile(CreateLaunchProfileRequest request);



        /// <summary>
        /// Create a launch profile.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateLaunchProfile service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateLaunchProfile service method, as returned by NimbleStudio.</returns>
        /// <exception cref="Amazon.NimbleStudio.Model.AccessDeniedException">
        /// You are not authorized to perform this operation. Check your IAM policies, and ensure
        /// that you are using the correct access keys.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ConflictException">
        /// Another operation is in progress.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.InternalServerErrorException">
        /// An internal error has occurred. Please retry your request.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ServiceQuotaExceededException">
        /// Your current quota does not allow you to perform the request action. You can request
        /// increases for some quotas, and other quotas cannot be increased.
        /// 
        ///  
        /// <para>
        /// Please use Amazon Web Services Service Quotas to request an increase. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ThrottlingException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ValidationException">
        /// One of the parameters in the request is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nimble-2020-08-01/CreateLaunchProfile">REST API Reference for CreateLaunchProfile Operation</seealso>
        Task<CreateLaunchProfileResponse> CreateLaunchProfileAsync(CreateLaunchProfileRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateStreamingImage


        /// <summary>
        /// Creates a streaming image resource in a studio.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateStreamingImage service method.</param>
        /// 
        /// <returns>The response from the CreateStreamingImage service method, as returned by NimbleStudio.</returns>
        /// <exception cref="Amazon.NimbleStudio.Model.AccessDeniedException">
        /// You are not authorized to perform this operation. Check your IAM policies, and ensure
        /// that you are using the correct access keys.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ConflictException">
        /// Another operation is in progress.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.InternalServerErrorException">
        /// An internal error has occurred. Please retry your request.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ServiceQuotaExceededException">
        /// Your current quota does not allow you to perform the request action. You can request
        /// increases for some quotas, and other quotas cannot be increased.
        /// 
        ///  
        /// <para>
        /// Please use Amazon Web Services Service Quotas to request an increase. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ThrottlingException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ValidationException">
        /// One of the parameters in the request is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nimble-2020-08-01/CreateStreamingImage">REST API Reference for CreateStreamingImage Operation</seealso>
        CreateStreamingImageResponse CreateStreamingImage(CreateStreamingImageRequest request);



        /// <summary>
        /// Creates a streaming image resource in a studio.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateStreamingImage service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateStreamingImage service method, as returned by NimbleStudio.</returns>
        /// <exception cref="Amazon.NimbleStudio.Model.AccessDeniedException">
        /// You are not authorized to perform this operation. Check your IAM policies, and ensure
        /// that you are using the correct access keys.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ConflictException">
        /// Another operation is in progress.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.InternalServerErrorException">
        /// An internal error has occurred. Please retry your request.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ServiceQuotaExceededException">
        /// Your current quota does not allow you to perform the request action. You can request
        /// increases for some quotas, and other quotas cannot be increased.
        /// 
        ///  
        /// <para>
        /// Please use Amazon Web Services Service Quotas to request an increase. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ThrottlingException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ValidationException">
        /// One of the parameters in the request is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nimble-2020-08-01/CreateStreamingImage">REST API Reference for CreateStreamingImage Operation</seealso>
        Task<CreateStreamingImageResponse> CreateStreamingImageAsync(CreateStreamingImageRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateStreamingSession


        /// <summary>
        /// Creates a streaming session in a studio.
        /// 
        ///  
        /// <para>
        /// After invoking this operation, you must poll GetStreamingSession until the streaming
        /// session is in the <code>READY</code> state.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateStreamingSession service method.</param>
        /// 
        /// <returns>The response from the CreateStreamingSession service method, as returned by NimbleStudio.</returns>
        /// <exception cref="Amazon.NimbleStudio.Model.AccessDeniedException">
        /// You are not authorized to perform this operation. Check your IAM policies, and ensure
        /// that you are using the correct access keys.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ConflictException">
        /// Another operation is in progress.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.InternalServerErrorException">
        /// An internal error has occurred. Please retry your request.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ServiceQuotaExceededException">
        /// Your current quota does not allow you to perform the request action. You can request
        /// increases for some quotas, and other quotas cannot be increased.
        /// 
        ///  
        /// <para>
        /// Please use Amazon Web Services Service Quotas to request an increase. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ThrottlingException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ValidationException">
        /// One of the parameters in the request is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nimble-2020-08-01/CreateStreamingSession">REST API Reference for CreateStreamingSession Operation</seealso>
        CreateStreamingSessionResponse CreateStreamingSession(CreateStreamingSessionRequest request);



        /// <summary>
        /// Creates a streaming session in a studio.
        /// 
        ///  
        /// <para>
        /// After invoking this operation, you must poll GetStreamingSession until the streaming
        /// session is in the <code>READY</code> state.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateStreamingSession service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateStreamingSession service method, as returned by NimbleStudio.</returns>
        /// <exception cref="Amazon.NimbleStudio.Model.AccessDeniedException">
        /// You are not authorized to perform this operation. Check your IAM policies, and ensure
        /// that you are using the correct access keys.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ConflictException">
        /// Another operation is in progress.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.InternalServerErrorException">
        /// An internal error has occurred. Please retry your request.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ServiceQuotaExceededException">
        /// Your current quota does not allow you to perform the request action. You can request
        /// increases for some quotas, and other quotas cannot be increased.
        /// 
        ///  
        /// <para>
        /// Please use Amazon Web Services Service Quotas to request an increase. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ThrottlingException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ValidationException">
        /// One of the parameters in the request is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nimble-2020-08-01/CreateStreamingSession">REST API Reference for CreateStreamingSession Operation</seealso>
        Task<CreateStreamingSessionResponse> CreateStreamingSessionAsync(CreateStreamingSessionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateStreamingSessionStream


        /// <summary>
        /// Creates a streaming session stream for a streaming session.
        /// 
        ///  
        /// <para>
        /// After invoking this API, invoke GetStreamingSessionStream with the returned streamId
        /// to poll the resource until it is in the <code>READY</code> state.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateStreamingSessionStream service method.</param>
        /// 
        /// <returns>The response from the CreateStreamingSessionStream service method, as returned by NimbleStudio.</returns>
        /// <exception cref="Amazon.NimbleStudio.Model.AccessDeniedException">
        /// You are not authorized to perform this operation. Check your IAM policies, and ensure
        /// that you are using the correct access keys.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ConflictException">
        /// Another operation is in progress.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.InternalServerErrorException">
        /// An internal error has occurred. Please retry your request.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ServiceQuotaExceededException">
        /// Your current quota does not allow you to perform the request action. You can request
        /// increases for some quotas, and other quotas cannot be increased.
        /// 
        ///  
        /// <para>
        /// Please use Amazon Web Services Service Quotas to request an increase. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ThrottlingException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ValidationException">
        /// One of the parameters in the request is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nimble-2020-08-01/CreateStreamingSessionStream">REST API Reference for CreateStreamingSessionStream Operation</seealso>
        CreateStreamingSessionStreamResponse CreateStreamingSessionStream(CreateStreamingSessionStreamRequest request);



        /// <summary>
        /// Creates a streaming session stream for a streaming session.
        /// 
        ///  
        /// <para>
        /// After invoking this API, invoke GetStreamingSessionStream with the returned streamId
        /// to poll the resource until it is in the <code>READY</code> state.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateStreamingSessionStream service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateStreamingSessionStream service method, as returned by NimbleStudio.</returns>
        /// <exception cref="Amazon.NimbleStudio.Model.AccessDeniedException">
        /// You are not authorized to perform this operation. Check your IAM policies, and ensure
        /// that you are using the correct access keys.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ConflictException">
        /// Another operation is in progress.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.InternalServerErrorException">
        /// An internal error has occurred. Please retry your request.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ServiceQuotaExceededException">
        /// Your current quota does not allow you to perform the request action. You can request
        /// increases for some quotas, and other quotas cannot be increased.
        /// 
        ///  
        /// <para>
        /// Please use Amazon Web Services Service Quotas to request an increase. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ThrottlingException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ValidationException">
        /// One of the parameters in the request is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nimble-2020-08-01/CreateStreamingSessionStream">REST API Reference for CreateStreamingSessionStream Operation</seealso>
        Task<CreateStreamingSessionStreamResponse> CreateStreamingSessionStreamAsync(CreateStreamingSessionStreamRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateStudio


        /// <summary>
        /// Create a new studio.
        /// 
        ///  
        /// <para>
        /// When creating a studio, two IAM roles must be provided: the admin role and the user
        /// role. These roles are assumed by your users when they log in to the Nimble Studio
        /// portal.
        /// </para>
        ///  
        /// <para>
        /// The user role must have the <code>AmazonNimbleStudio-StudioUser</code> managed policy
        /// attached for the portal to function properly.
        /// </para>
        ///  
        /// <para>
        /// The admin role must have the <code>AmazonNimbleStudio-StudioAdmin</code> managed policy
        /// attached for the portal to function properly.
        /// </para>
        ///  
        /// <para>
        /// You may optionally specify a KMS key in the <code>StudioEncryptionConfiguration</code>.
        /// </para>
        ///  
        /// <para>
        /// In Nimble Studio, resource names, descriptions, initialization scripts, and other
        /// data you provide are always encrypted at rest using an KMS key. By default, this key
        /// is owned by Amazon Web Services and managed on your behalf. You may provide your own
        /// KMS key when calling <code>CreateStudio</code> to encrypt this data using a key you
        /// own and manage.
        /// </para>
        ///  
        /// <para>
        /// When providing an KMS key during studio creation, Nimble Studio creates KMS grants
        /// in your account to provide your studio user and admin roles access to these KMS keys.
        /// </para>
        ///  
        /// <para>
        /// If you delete this grant, the studio will no longer be accessible to your portal users.
        /// </para>
        ///  
        /// <para>
        /// If you delete the studio KMS key, your studio will no longer be accessible.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateStudio service method.</param>
        /// 
        /// <returns>The response from the CreateStudio service method, as returned by NimbleStudio.</returns>
        /// <exception cref="Amazon.NimbleStudio.Model.AccessDeniedException">
        /// You are not authorized to perform this operation. Check your IAM policies, and ensure
        /// that you are using the correct access keys.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ConflictException">
        /// Another operation is in progress.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.InternalServerErrorException">
        /// An internal error has occurred. Please retry your request.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ServiceQuotaExceededException">
        /// Your current quota does not allow you to perform the request action. You can request
        /// increases for some quotas, and other quotas cannot be increased.
        /// 
        ///  
        /// <para>
        /// Please use Amazon Web Services Service Quotas to request an increase. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ThrottlingException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ValidationException">
        /// One of the parameters in the request is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nimble-2020-08-01/CreateStudio">REST API Reference for CreateStudio Operation</seealso>
        CreateStudioResponse CreateStudio(CreateStudioRequest request);



        /// <summary>
        /// Create a new studio.
        /// 
        ///  
        /// <para>
        /// When creating a studio, two IAM roles must be provided: the admin role and the user
        /// role. These roles are assumed by your users when they log in to the Nimble Studio
        /// portal.
        /// </para>
        ///  
        /// <para>
        /// The user role must have the <code>AmazonNimbleStudio-StudioUser</code> managed policy
        /// attached for the portal to function properly.
        /// </para>
        ///  
        /// <para>
        /// The admin role must have the <code>AmazonNimbleStudio-StudioAdmin</code> managed policy
        /// attached for the portal to function properly.
        /// </para>
        ///  
        /// <para>
        /// You may optionally specify a KMS key in the <code>StudioEncryptionConfiguration</code>.
        /// </para>
        ///  
        /// <para>
        /// In Nimble Studio, resource names, descriptions, initialization scripts, and other
        /// data you provide are always encrypted at rest using an KMS key. By default, this key
        /// is owned by Amazon Web Services and managed on your behalf. You may provide your own
        /// KMS key when calling <code>CreateStudio</code> to encrypt this data using a key you
        /// own and manage.
        /// </para>
        ///  
        /// <para>
        /// When providing an KMS key during studio creation, Nimble Studio creates KMS grants
        /// in your account to provide your studio user and admin roles access to these KMS keys.
        /// </para>
        ///  
        /// <para>
        /// If you delete this grant, the studio will no longer be accessible to your portal users.
        /// </para>
        ///  
        /// <para>
        /// If you delete the studio KMS key, your studio will no longer be accessible.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateStudio service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateStudio service method, as returned by NimbleStudio.</returns>
        /// <exception cref="Amazon.NimbleStudio.Model.AccessDeniedException">
        /// You are not authorized to perform this operation. Check your IAM policies, and ensure
        /// that you are using the correct access keys.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ConflictException">
        /// Another operation is in progress.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.InternalServerErrorException">
        /// An internal error has occurred. Please retry your request.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ServiceQuotaExceededException">
        /// Your current quota does not allow you to perform the request action. You can request
        /// increases for some quotas, and other quotas cannot be increased.
        /// 
        ///  
        /// <para>
        /// Please use Amazon Web Services Service Quotas to request an increase. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ThrottlingException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ValidationException">
        /// One of the parameters in the request is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nimble-2020-08-01/CreateStudio">REST API Reference for CreateStudio Operation</seealso>
        Task<CreateStudioResponse> CreateStudioAsync(CreateStudioRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateStudioComponent


        /// <summary>
        /// Creates a studio component resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateStudioComponent service method.</param>
        /// 
        /// <returns>The response from the CreateStudioComponent service method, as returned by NimbleStudio.</returns>
        /// <exception cref="Amazon.NimbleStudio.Model.AccessDeniedException">
        /// You are not authorized to perform this operation. Check your IAM policies, and ensure
        /// that you are using the correct access keys.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ConflictException">
        /// Another operation is in progress.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.InternalServerErrorException">
        /// An internal error has occurred. Please retry your request.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ServiceQuotaExceededException">
        /// Your current quota does not allow you to perform the request action. You can request
        /// increases for some quotas, and other quotas cannot be increased.
        /// 
        ///  
        /// <para>
        /// Please use Amazon Web Services Service Quotas to request an increase. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ThrottlingException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ValidationException">
        /// One of the parameters in the request is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nimble-2020-08-01/CreateStudioComponent">REST API Reference for CreateStudioComponent Operation</seealso>
        CreateStudioComponentResponse CreateStudioComponent(CreateStudioComponentRequest request);



        /// <summary>
        /// Creates a studio component resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateStudioComponent service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateStudioComponent service method, as returned by NimbleStudio.</returns>
        /// <exception cref="Amazon.NimbleStudio.Model.AccessDeniedException">
        /// You are not authorized to perform this operation. Check your IAM policies, and ensure
        /// that you are using the correct access keys.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ConflictException">
        /// Another operation is in progress.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.InternalServerErrorException">
        /// An internal error has occurred. Please retry your request.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ServiceQuotaExceededException">
        /// Your current quota does not allow you to perform the request action. You can request
        /// increases for some quotas, and other quotas cannot be increased.
        /// 
        ///  
        /// <para>
        /// Please use Amazon Web Services Service Quotas to request an increase. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ThrottlingException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ValidationException">
        /// One of the parameters in the request is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nimble-2020-08-01/CreateStudioComponent">REST API Reference for CreateStudioComponent Operation</seealso>
        Task<CreateStudioComponentResponse> CreateStudioComponentAsync(CreateStudioComponentRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteLaunchProfile


        /// <summary>
        /// Permanently delete a launch profile.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteLaunchProfile service method.</param>
        /// 
        /// <returns>The response from the DeleteLaunchProfile service method, as returned by NimbleStudio.</returns>
        /// <exception cref="Amazon.NimbleStudio.Model.AccessDeniedException">
        /// You are not authorized to perform this operation. Check your IAM policies, and ensure
        /// that you are using the correct access keys.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ConflictException">
        /// Another operation is in progress.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.InternalServerErrorException">
        /// An internal error has occurred. Please retry your request.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ServiceQuotaExceededException">
        /// Your current quota does not allow you to perform the request action. You can request
        /// increases for some quotas, and other quotas cannot be increased.
        /// 
        ///  
        /// <para>
        /// Please use Amazon Web Services Service Quotas to request an increase. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ThrottlingException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ValidationException">
        /// One of the parameters in the request is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nimble-2020-08-01/DeleteLaunchProfile">REST API Reference for DeleteLaunchProfile Operation</seealso>
        DeleteLaunchProfileResponse DeleteLaunchProfile(DeleteLaunchProfileRequest request);



        /// <summary>
        /// Permanently delete a launch profile.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteLaunchProfile service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteLaunchProfile service method, as returned by NimbleStudio.</returns>
        /// <exception cref="Amazon.NimbleStudio.Model.AccessDeniedException">
        /// You are not authorized to perform this operation. Check your IAM policies, and ensure
        /// that you are using the correct access keys.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ConflictException">
        /// Another operation is in progress.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.InternalServerErrorException">
        /// An internal error has occurred. Please retry your request.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ServiceQuotaExceededException">
        /// Your current quota does not allow you to perform the request action. You can request
        /// increases for some quotas, and other quotas cannot be increased.
        /// 
        ///  
        /// <para>
        /// Please use Amazon Web Services Service Quotas to request an increase. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ThrottlingException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ValidationException">
        /// One of the parameters in the request is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nimble-2020-08-01/DeleteLaunchProfile">REST API Reference for DeleteLaunchProfile Operation</seealso>
        Task<DeleteLaunchProfileResponse> DeleteLaunchProfileAsync(DeleteLaunchProfileRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteLaunchProfileMember


        /// <summary>
        /// Delete a user from launch profile membership.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteLaunchProfileMember service method.</param>
        /// 
        /// <returns>The response from the DeleteLaunchProfileMember service method, as returned by NimbleStudio.</returns>
        /// <exception cref="Amazon.NimbleStudio.Model.AccessDeniedException">
        /// You are not authorized to perform this operation. Check your IAM policies, and ensure
        /// that you are using the correct access keys.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ConflictException">
        /// Another operation is in progress.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.InternalServerErrorException">
        /// An internal error has occurred. Please retry your request.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ServiceQuotaExceededException">
        /// Your current quota does not allow you to perform the request action. You can request
        /// increases for some quotas, and other quotas cannot be increased.
        /// 
        ///  
        /// <para>
        /// Please use Amazon Web Services Service Quotas to request an increase. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ThrottlingException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ValidationException">
        /// One of the parameters in the request is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nimble-2020-08-01/DeleteLaunchProfileMember">REST API Reference for DeleteLaunchProfileMember Operation</seealso>
        DeleteLaunchProfileMemberResponse DeleteLaunchProfileMember(DeleteLaunchProfileMemberRequest request);



        /// <summary>
        /// Delete a user from launch profile membership.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteLaunchProfileMember service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteLaunchProfileMember service method, as returned by NimbleStudio.</returns>
        /// <exception cref="Amazon.NimbleStudio.Model.AccessDeniedException">
        /// You are not authorized to perform this operation. Check your IAM policies, and ensure
        /// that you are using the correct access keys.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ConflictException">
        /// Another operation is in progress.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.InternalServerErrorException">
        /// An internal error has occurred. Please retry your request.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ServiceQuotaExceededException">
        /// Your current quota does not allow you to perform the request action. You can request
        /// increases for some quotas, and other quotas cannot be increased.
        /// 
        ///  
        /// <para>
        /// Please use Amazon Web Services Service Quotas to request an increase. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ThrottlingException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ValidationException">
        /// One of the parameters in the request is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nimble-2020-08-01/DeleteLaunchProfileMember">REST API Reference for DeleteLaunchProfileMember Operation</seealso>
        Task<DeleteLaunchProfileMemberResponse> DeleteLaunchProfileMemberAsync(DeleteLaunchProfileMemberRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteStreamingImage


        /// <summary>
        /// Delete streaming image.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteStreamingImage service method.</param>
        /// 
        /// <returns>The response from the DeleteStreamingImage service method, as returned by NimbleStudio.</returns>
        /// <exception cref="Amazon.NimbleStudio.Model.AccessDeniedException">
        /// You are not authorized to perform this operation. Check your IAM policies, and ensure
        /// that you are using the correct access keys.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ConflictException">
        /// Another operation is in progress.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.InternalServerErrorException">
        /// An internal error has occurred. Please retry your request.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ServiceQuotaExceededException">
        /// Your current quota does not allow you to perform the request action. You can request
        /// increases for some quotas, and other quotas cannot be increased.
        /// 
        ///  
        /// <para>
        /// Please use Amazon Web Services Service Quotas to request an increase. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ThrottlingException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ValidationException">
        /// One of the parameters in the request is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nimble-2020-08-01/DeleteStreamingImage">REST API Reference for DeleteStreamingImage Operation</seealso>
        DeleteStreamingImageResponse DeleteStreamingImage(DeleteStreamingImageRequest request);



        /// <summary>
        /// Delete streaming image.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteStreamingImage service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteStreamingImage service method, as returned by NimbleStudio.</returns>
        /// <exception cref="Amazon.NimbleStudio.Model.AccessDeniedException">
        /// You are not authorized to perform this operation. Check your IAM policies, and ensure
        /// that you are using the correct access keys.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ConflictException">
        /// Another operation is in progress.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.InternalServerErrorException">
        /// An internal error has occurred. Please retry your request.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ServiceQuotaExceededException">
        /// Your current quota does not allow you to perform the request action. You can request
        /// increases for some quotas, and other quotas cannot be increased.
        /// 
        ///  
        /// <para>
        /// Please use Amazon Web Services Service Quotas to request an increase. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ThrottlingException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ValidationException">
        /// One of the parameters in the request is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nimble-2020-08-01/DeleteStreamingImage">REST API Reference for DeleteStreamingImage Operation</seealso>
        Task<DeleteStreamingImageResponse> DeleteStreamingImageAsync(DeleteStreamingImageRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteStreamingSession


        /// <summary>
        /// Deletes streaming session resource.
        /// 
        ///  
        /// <para>
        /// After invoking this operation, use GetStreamingSession to poll the resource until
        /// it transitions to a <code>DELETED</code> state.
        /// </para>
        ///  
        /// <para>
        /// A streaming session will count against your streaming session quota until it is marked
        /// <code>DELETED</code>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteStreamingSession service method.</param>
        /// 
        /// <returns>The response from the DeleteStreamingSession service method, as returned by NimbleStudio.</returns>
        /// <exception cref="Amazon.NimbleStudio.Model.AccessDeniedException">
        /// You are not authorized to perform this operation. Check your IAM policies, and ensure
        /// that you are using the correct access keys.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ConflictException">
        /// Another operation is in progress.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.InternalServerErrorException">
        /// An internal error has occurred. Please retry your request.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ServiceQuotaExceededException">
        /// Your current quota does not allow you to perform the request action. You can request
        /// increases for some quotas, and other quotas cannot be increased.
        /// 
        ///  
        /// <para>
        /// Please use Amazon Web Services Service Quotas to request an increase. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ThrottlingException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ValidationException">
        /// One of the parameters in the request is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nimble-2020-08-01/DeleteStreamingSession">REST API Reference for DeleteStreamingSession Operation</seealso>
        DeleteStreamingSessionResponse DeleteStreamingSession(DeleteStreamingSessionRequest request);



        /// <summary>
        /// Deletes streaming session resource.
        /// 
        ///  
        /// <para>
        /// After invoking this operation, use GetStreamingSession to poll the resource until
        /// it transitions to a <code>DELETED</code> state.
        /// </para>
        ///  
        /// <para>
        /// A streaming session will count against your streaming session quota until it is marked
        /// <code>DELETED</code>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteStreamingSession service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteStreamingSession service method, as returned by NimbleStudio.</returns>
        /// <exception cref="Amazon.NimbleStudio.Model.AccessDeniedException">
        /// You are not authorized to perform this operation. Check your IAM policies, and ensure
        /// that you are using the correct access keys.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ConflictException">
        /// Another operation is in progress.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.InternalServerErrorException">
        /// An internal error has occurred. Please retry your request.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ServiceQuotaExceededException">
        /// Your current quota does not allow you to perform the request action. You can request
        /// increases for some quotas, and other quotas cannot be increased.
        /// 
        ///  
        /// <para>
        /// Please use Amazon Web Services Service Quotas to request an increase. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ThrottlingException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ValidationException">
        /// One of the parameters in the request is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nimble-2020-08-01/DeleteStreamingSession">REST API Reference for DeleteStreamingSession Operation</seealso>
        Task<DeleteStreamingSessionResponse> DeleteStreamingSessionAsync(DeleteStreamingSessionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteStudio


        /// <summary>
        /// Delete a studio resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteStudio service method.</param>
        /// 
        /// <returns>The response from the DeleteStudio service method, as returned by NimbleStudio.</returns>
        /// <exception cref="Amazon.NimbleStudio.Model.AccessDeniedException">
        /// You are not authorized to perform this operation. Check your IAM policies, and ensure
        /// that you are using the correct access keys.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ConflictException">
        /// Another operation is in progress.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.InternalServerErrorException">
        /// An internal error has occurred. Please retry your request.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ServiceQuotaExceededException">
        /// Your current quota does not allow you to perform the request action. You can request
        /// increases for some quotas, and other quotas cannot be increased.
        /// 
        ///  
        /// <para>
        /// Please use Amazon Web Services Service Quotas to request an increase. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ThrottlingException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ValidationException">
        /// One of the parameters in the request is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nimble-2020-08-01/DeleteStudio">REST API Reference for DeleteStudio Operation</seealso>
        DeleteStudioResponse DeleteStudio(DeleteStudioRequest request);



        /// <summary>
        /// Delete a studio resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteStudio service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteStudio service method, as returned by NimbleStudio.</returns>
        /// <exception cref="Amazon.NimbleStudio.Model.AccessDeniedException">
        /// You are not authorized to perform this operation. Check your IAM policies, and ensure
        /// that you are using the correct access keys.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ConflictException">
        /// Another operation is in progress.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.InternalServerErrorException">
        /// An internal error has occurred. Please retry your request.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ServiceQuotaExceededException">
        /// Your current quota does not allow you to perform the request action. You can request
        /// increases for some quotas, and other quotas cannot be increased.
        /// 
        ///  
        /// <para>
        /// Please use Amazon Web Services Service Quotas to request an increase. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ThrottlingException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ValidationException">
        /// One of the parameters in the request is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nimble-2020-08-01/DeleteStudio">REST API Reference for DeleteStudio Operation</seealso>
        Task<DeleteStudioResponse> DeleteStudioAsync(DeleteStudioRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteStudioComponent


        /// <summary>
        /// Deletes a studio component resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteStudioComponent service method.</param>
        /// 
        /// <returns>The response from the DeleteStudioComponent service method, as returned by NimbleStudio.</returns>
        /// <exception cref="Amazon.NimbleStudio.Model.AccessDeniedException">
        /// You are not authorized to perform this operation. Check your IAM policies, and ensure
        /// that you are using the correct access keys.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ConflictException">
        /// Another operation is in progress.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.InternalServerErrorException">
        /// An internal error has occurred. Please retry your request.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ServiceQuotaExceededException">
        /// Your current quota does not allow you to perform the request action. You can request
        /// increases for some quotas, and other quotas cannot be increased.
        /// 
        ///  
        /// <para>
        /// Please use Amazon Web Services Service Quotas to request an increase. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ThrottlingException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ValidationException">
        /// One of the parameters in the request is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nimble-2020-08-01/DeleteStudioComponent">REST API Reference for DeleteStudioComponent Operation</seealso>
        DeleteStudioComponentResponse DeleteStudioComponent(DeleteStudioComponentRequest request);



        /// <summary>
        /// Deletes a studio component resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteStudioComponent service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteStudioComponent service method, as returned by NimbleStudio.</returns>
        /// <exception cref="Amazon.NimbleStudio.Model.AccessDeniedException">
        /// You are not authorized to perform this operation. Check your IAM policies, and ensure
        /// that you are using the correct access keys.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ConflictException">
        /// Another operation is in progress.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.InternalServerErrorException">
        /// An internal error has occurred. Please retry your request.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ServiceQuotaExceededException">
        /// Your current quota does not allow you to perform the request action. You can request
        /// increases for some quotas, and other quotas cannot be increased.
        /// 
        ///  
        /// <para>
        /// Please use Amazon Web Services Service Quotas to request an increase. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ThrottlingException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ValidationException">
        /// One of the parameters in the request is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nimble-2020-08-01/DeleteStudioComponent">REST API Reference for DeleteStudioComponent Operation</seealso>
        Task<DeleteStudioComponentResponse> DeleteStudioComponentAsync(DeleteStudioComponentRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteStudioMember


        /// <summary>
        /// Delete a user from studio membership.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteStudioMember service method.</param>
        /// 
        /// <returns>The response from the DeleteStudioMember service method, as returned by NimbleStudio.</returns>
        /// <exception cref="Amazon.NimbleStudio.Model.AccessDeniedException">
        /// You are not authorized to perform this operation. Check your IAM policies, and ensure
        /// that you are using the correct access keys.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ConflictException">
        /// Another operation is in progress.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.InternalServerErrorException">
        /// An internal error has occurred. Please retry your request.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ServiceQuotaExceededException">
        /// Your current quota does not allow you to perform the request action. You can request
        /// increases for some quotas, and other quotas cannot be increased.
        /// 
        ///  
        /// <para>
        /// Please use Amazon Web Services Service Quotas to request an increase. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ThrottlingException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ValidationException">
        /// One of the parameters in the request is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nimble-2020-08-01/DeleteStudioMember">REST API Reference for DeleteStudioMember Operation</seealso>
        DeleteStudioMemberResponse DeleteStudioMember(DeleteStudioMemberRequest request);



        /// <summary>
        /// Delete a user from studio membership.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteStudioMember service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteStudioMember service method, as returned by NimbleStudio.</returns>
        /// <exception cref="Amazon.NimbleStudio.Model.AccessDeniedException">
        /// You are not authorized to perform this operation. Check your IAM policies, and ensure
        /// that you are using the correct access keys.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ConflictException">
        /// Another operation is in progress.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.InternalServerErrorException">
        /// An internal error has occurred. Please retry your request.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ServiceQuotaExceededException">
        /// Your current quota does not allow you to perform the request action. You can request
        /// increases for some quotas, and other quotas cannot be increased.
        /// 
        ///  
        /// <para>
        /// Please use Amazon Web Services Service Quotas to request an increase. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ThrottlingException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ValidationException">
        /// One of the parameters in the request is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nimble-2020-08-01/DeleteStudioMember">REST API Reference for DeleteStudioMember Operation</seealso>
        Task<DeleteStudioMemberResponse> DeleteStudioMemberAsync(DeleteStudioMemberRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetEula


        /// <summary>
        /// Get EULA.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEula service method.</param>
        /// 
        /// <returns>The response from the GetEula service method, as returned by NimbleStudio.</returns>
        /// <exception cref="Amazon.NimbleStudio.Model.AccessDeniedException">
        /// You are not authorized to perform this operation. Check your IAM policies, and ensure
        /// that you are using the correct access keys.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ConflictException">
        /// Another operation is in progress.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.InternalServerErrorException">
        /// An internal error has occurred. Please retry your request.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ServiceQuotaExceededException">
        /// Your current quota does not allow you to perform the request action. You can request
        /// increases for some quotas, and other quotas cannot be increased.
        /// 
        ///  
        /// <para>
        /// Please use Amazon Web Services Service Quotas to request an increase. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ThrottlingException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ValidationException">
        /// One of the parameters in the request is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nimble-2020-08-01/GetEula">REST API Reference for GetEula Operation</seealso>
        GetEulaResponse GetEula(GetEulaRequest request);



        /// <summary>
        /// Get EULA.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEula service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetEula service method, as returned by NimbleStudio.</returns>
        /// <exception cref="Amazon.NimbleStudio.Model.AccessDeniedException">
        /// You are not authorized to perform this operation. Check your IAM policies, and ensure
        /// that you are using the correct access keys.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ConflictException">
        /// Another operation is in progress.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.InternalServerErrorException">
        /// An internal error has occurred. Please retry your request.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ServiceQuotaExceededException">
        /// Your current quota does not allow you to perform the request action. You can request
        /// increases for some quotas, and other quotas cannot be increased.
        /// 
        ///  
        /// <para>
        /// Please use Amazon Web Services Service Quotas to request an increase. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ThrottlingException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ValidationException">
        /// One of the parameters in the request is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nimble-2020-08-01/GetEula">REST API Reference for GetEula Operation</seealso>
        Task<GetEulaResponse> GetEulaAsync(GetEulaRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetLaunchProfile


        /// <summary>
        /// Get a launch profile.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetLaunchProfile service method.</param>
        /// 
        /// <returns>The response from the GetLaunchProfile service method, as returned by NimbleStudio.</returns>
        /// <exception cref="Amazon.NimbleStudio.Model.AccessDeniedException">
        /// You are not authorized to perform this operation. Check your IAM policies, and ensure
        /// that you are using the correct access keys.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ConflictException">
        /// Another operation is in progress.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.InternalServerErrorException">
        /// An internal error has occurred. Please retry your request.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ServiceQuotaExceededException">
        /// Your current quota does not allow you to perform the request action. You can request
        /// increases for some quotas, and other quotas cannot be increased.
        /// 
        ///  
        /// <para>
        /// Please use Amazon Web Services Service Quotas to request an increase. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ThrottlingException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ValidationException">
        /// One of the parameters in the request is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nimble-2020-08-01/GetLaunchProfile">REST API Reference for GetLaunchProfile Operation</seealso>
        GetLaunchProfileResponse GetLaunchProfile(GetLaunchProfileRequest request);



        /// <summary>
        /// Get a launch profile.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetLaunchProfile service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetLaunchProfile service method, as returned by NimbleStudio.</returns>
        /// <exception cref="Amazon.NimbleStudio.Model.AccessDeniedException">
        /// You are not authorized to perform this operation. Check your IAM policies, and ensure
        /// that you are using the correct access keys.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ConflictException">
        /// Another operation is in progress.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.InternalServerErrorException">
        /// An internal error has occurred. Please retry your request.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ServiceQuotaExceededException">
        /// Your current quota does not allow you to perform the request action. You can request
        /// increases for some quotas, and other quotas cannot be increased.
        /// 
        ///  
        /// <para>
        /// Please use Amazon Web Services Service Quotas to request an increase. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ThrottlingException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ValidationException">
        /// One of the parameters in the request is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nimble-2020-08-01/GetLaunchProfile">REST API Reference for GetLaunchProfile Operation</seealso>
        Task<GetLaunchProfileResponse> GetLaunchProfileAsync(GetLaunchProfileRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetLaunchProfileDetails


        /// <summary>
        /// Launch profile details include the launch profile resource and summary information
        /// of resources that are used by, or available to, the launch profile. This includes
        /// the name and description of all studio components used by the launch profiles, and
        /// the name and description of streaming images that can be used with this launch profile.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetLaunchProfileDetails service method.</param>
        /// 
        /// <returns>The response from the GetLaunchProfileDetails service method, as returned by NimbleStudio.</returns>
        /// <exception cref="Amazon.NimbleStudio.Model.AccessDeniedException">
        /// You are not authorized to perform this operation. Check your IAM policies, and ensure
        /// that you are using the correct access keys.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ConflictException">
        /// Another operation is in progress.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.InternalServerErrorException">
        /// An internal error has occurred. Please retry your request.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ServiceQuotaExceededException">
        /// Your current quota does not allow you to perform the request action. You can request
        /// increases for some quotas, and other quotas cannot be increased.
        /// 
        ///  
        /// <para>
        /// Please use Amazon Web Services Service Quotas to request an increase. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ThrottlingException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ValidationException">
        /// One of the parameters in the request is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nimble-2020-08-01/GetLaunchProfileDetails">REST API Reference for GetLaunchProfileDetails Operation</seealso>
        GetLaunchProfileDetailsResponse GetLaunchProfileDetails(GetLaunchProfileDetailsRequest request);



        /// <summary>
        /// Launch profile details include the launch profile resource and summary information
        /// of resources that are used by, or available to, the launch profile. This includes
        /// the name and description of all studio components used by the launch profiles, and
        /// the name and description of streaming images that can be used with this launch profile.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetLaunchProfileDetails service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetLaunchProfileDetails service method, as returned by NimbleStudio.</returns>
        /// <exception cref="Amazon.NimbleStudio.Model.AccessDeniedException">
        /// You are not authorized to perform this operation. Check your IAM policies, and ensure
        /// that you are using the correct access keys.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ConflictException">
        /// Another operation is in progress.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.InternalServerErrorException">
        /// An internal error has occurred. Please retry your request.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ServiceQuotaExceededException">
        /// Your current quota does not allow you to perform the request action. You can request
        /// increases for some quotas, and other quotas cannot be increased.
        /// 
        ///  
        /// <para>
        /// Please use Amazon Web Services Service Quotas to request an increase. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ThrottlingException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ValidationException">
        /// One of the parameters in the request is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nimble-2020-08-01/GetLaunchProfileDetails">REST API Reference for GetLaunchProfileDetails Operation</seealso>
        Task<GetLaunchProfileDetailsResponse> GetLaunchProfileDetailsAsync(GetLaunchProfileDetailsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetLaunchProfileInitialization


        /// <summary>
        /// Get a launch profile initialization.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetLaunchProfileInitialization service method.</param>
        /// 
        /// <returns>The response from the GetLaunchProfileInitialization service method, as returned by NimbleStudio.</returns>
        /// <exception cref="Amazon.NimbleStudio.Model.AccessDeniedException">
        /// You are not authorized to perform this operation. Check your IAM policies, and ensure
        /// that you are using the correct access keys.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ConflictException">
        /// Another operation is in progress.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.InternalServerErrorException">
        /// An internal error has occurred. Please retry your request.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ServiceQuotaExceededException">
        /// Your current quota does not allow you to perform the request action. You can request
        /// increases for some quotas, and other quotas cannot be increased.
        /// 
        ///  
        /// <para>
        /// Please use Amazon Web Services Service Quotas to request an increase. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ThrottlingException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ValidationException">
        /// One of the parameters in the request is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nimble-2020-08-01/GetLaunchProfileInitialization">REST API Reference for GetLaunchProfileInitialization Operation</seealso>
        GetLaunchProfileInitializationResponse GetLaunchProfileInitialization(GetLaunchProfileInitializationRequest request);



        /// <summary>
        /// Get a launch profile initialization.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetLaunchProfileInitialization service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetLaunchProfileInitialization service method, as returned by NimbleStudio.</returns>
        /// <exception cref="Amazon.NimbleStudio.Model.AccessDeniedException">
        /// You are not authorized to perform this operation. Check your IAM policies, and ensure
        /// that you are using the correct access keys.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ConflictException">
        /// Another operation is in progress.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.InternalServerErrorException">
        /// An internal error has occurred. Please retry your request.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ServiceQuotaExceededException">
        /// Your current quota does not allow you to perform the request action. You can request
        /// increases for some quotas, and other quotas cannot be increased.
        /// 
        ///  
        /// <para>
        /// Please use Amazon Web Services Service Quotas to request an increase. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ThrottlingException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ValidationException">
        /// One of the parameters in the request is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nimble-2020-08-01/GetLaunchProfileInitialization">REST API Reference for GetLaunchProfileInitialization Operation</seealso>
        Task<GetLaunchProfileInitializationResponse> GetLaunchProfileInitializationAsync(GetLaunchProfileInitializationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetLaunchProfileMember


        /// <summary>
        /// Get a user persona in launch profile membership.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetLaunchProfileMember service method.</param>
        /// 
        /// <returns>The response from the GetLaunchProfileMember service method, as returned by NimbleStudio.</returns>
        /// <exception cref="Amazon.NimbleStudio.Model.AccessDeniedException">
        /// You are not authorized to perform this operation. Check your IAM policies, and ensure
        /// that you are using the correct access keys.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ConflictException">
        /// Another operation is in progress.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.InternalServerErrorException">
        /// An internal error has occurred. Please retry your request.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ServiceQuotaExceededException">
        /// Your current quota does not allow you to perform the request action. You can request
        /// increases for some quotas, and other quotas cannot be increased.
        /// 
        ///  
        /// <para>
        /// Please use Amazon Web Services Service Quotas to request an increase. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ThrottlingException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ValidationException">
        /// One of the parameters in the request is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nimble-2020-08-01/GetLaunchProfileMember">REST API Reference for GetLaunchProfileMember Operation</seealso>
        GetLaunchProfileMemberResponse GetLaunchProfileMember(GetLaunchProfileMemberRequest request);



        /// <summary>
        /// Get a user persona in launch profile membership.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetLaunchProfileMember service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetLaunchProfileMember service method, as returned by NimbleStudio.</returns>
        /// <exception cref="Amazon.NimbleStudio.Model.AccessDeniedException">
        /// You are not authorized to perform this operation. Check your IAM policies, and ensure
        /// that you are using the correct access keys.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ConflictException">
        /// Another operation is in progress.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.InternalServerErrorException">
        /// An internal error has occurred. Please retry your request.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ServiceQuotaExceededException">
        /// Your current quota does not allow you to perform the request action. You can request
        /// increases for some quotas, and other quotas cannot be increased.
        /// 
        ///  
        /// <para>
        /// Please use Amazon Web Services Service Quotas to request an increase. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ThrottlingException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ValidationException">
        /// One of the parameters in the request is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nimble-2020-08-01/GetLaunchProfileMember">REST API Reference for GetLaunchProfileMember Operation</seealso>
        Task<GetLaunchProfileMemberResponse> GetLaunchProfileMemberAsync(GetLaunchProfileMemberRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetStreamingImage


        /// <summary>
        /// Get streaming image.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetStreamingImage service method.</param>
        /// 
        /// <returns>The response from the GetStreamingImage service method, as returned by NimbleStudio.</returns>
        /// <exception cref="Amazon.NimbleStudio.Model.AccessDeniedException">
        /// You are not authorized to perform this operation. Check your IAM policies, and ensure
        /// that you are using the correct access keys.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ConflictException">
        /// Another operation is in progress.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.InternalServerErrorException">
        /// An internal error has occurred. Please retry your request.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ServiceQuotaExceededException">
        /// Your current quota does not allow you to perform the request action. You can request
        /// increases for some quotas, and other quotas cannot be increased.
        /// 
        ///  
        /// <para>
        /// Please use Amazon Web Services Service Quotas to request an increase. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ThrottlingException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ValidationException">
        /// One of the parameters in the request is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nimble-2020-08-01/GetStreamingImage">REST API Reference for GetStreamingImage Operation</seealso>
        GetStreamingImageResponse GetStreamingImage(GetStreamingImageRequest request);



        /// <summary>
        /// Get streaming image.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetStreamingImage service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetStreamingImage service method, as returned by NimbleStudio.</returns>
        /// <exception cref="Amazon.NimbleStudio.Model.AccessDeniedException">
        /// You are not authorized to perform this operation. Check your IAM policies, and ensure
        /// that you are using the correct access keys.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ConflictException">
        /// Another operation is in progress.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.InternalServerErrorException">
        /// An internal error has occurred. Please retry your request.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ServiceQuotaExceededException">
        /// Your current quota does not allow you to perform the request action. You can request
        /// increases for some quotas, and other quotas cannot be increased.
        /// 
        ///  
        /// <para>
        /// Please use Amazon Web Services Service Quotas to request an increase. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ThrottlingException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ValidationException">
        /// One of the parameters in the request is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nimble-2020-08-01/GetStreamingImage">REST API Reference for GetStreamingImage Operation</seealso>
        Task<GetStreamingImageResponse> GetStreamingImageAsync(GetStreamingImageRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetStreamingSession


        /// <summary>
        /// Gets StreamingSession resource.
        /// 
        ///  
        /// <para>
        /// Invoke this operation to poll for a streaming session state while creating or deleting
        /// a session.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetStreamingSession service method.</param>
        /// 
        /// <returns>The response from the GetStreamingSession service method, as returned by NimbleStudio.</returns>
        /// <exception cref="Amazon.NimbleStudio.Model.AccessDeniedException">
        /// You are not authorized to perform this operation. Check your IAM policies, and ensure
        /// that you are using the correct access keys.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ConflictException">
        /// Another operation is in progress.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.InternalServerErrorException">
        /// An internal error has occurred. Please retry your request.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ServiceQuotaExceededException">
        /// Your current quota does not allow you to perform the request action. You can request
        /// increases for some quotas, and other quotas cannot be increased.
        /// 
        ///  
        /// <para>
        /// Please use Amazon Web Services Service Quotas to request an increase. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ThrottlingException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ValidationException">
        /// One of the parameters in the request is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nimble-2020-08-01/GetStreamingSession">REST API Reference for GetStreamingSession Operation</seealso>
        GetStreamingSessionResponse GetStreamingSession(GetStreamingSessionRequest request);



        /// <summary>
        /// Gets StreamingSession resource.
        /// 
        ///  
        /// <para>
        /// Invoke this operation to poll for a streaming session state while creating or deleting
        /// a session.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetStreamingSession service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetStreamingSession service method, as returned by NimbleStudio.</returns>
        /// <exception cref="Amazon.NimbleStudio.Model.AccessDeniedException">
        /// You are not authorized to perform this operation. Check your IAM policies, and ensure
        /// that you are using the correct access keys.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ConflictException">
        /// Another operation is in progress.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.InternalServerErrorException">
        /// An internal error has occurred. Please retry your request.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ServiceQuotaExceededException">
        /// Your current quota does not allow you to perform the request action. You can request
        /// increases for some quotas, and other quotas cannot be increased.
        /// 
        ///  
        /// <para>
        /// Please use Amazon Web Services Service Quotas to request an increase. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ThrottlingException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ValidationException">
        /// One of the parameters in the request is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nimble-2020-08-01/GetStreamingSession">REST API Reference for GetStreamingSession Operation</seealso>
        Task<GetStreamingSessionResponse> GetStreamingSessionAsync(GetStreamingSessionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetStreamingSessionBackup


        /// <summary>
        /// Gets <code>StreamingSessionBackup</code> resource.
        /// 
        ///  
        /// <para>
        /// Invoke this operation to poll for a streaming session backup while stopping a streaming
        /// session.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetStreamingSessionBackup service method.</param>
        /// 
        /// <returns>The response from the GetStreamingSessionBackup service method, as returned by NimbleStudio.</returns>
        /// <exception cref="Amazon.NimbleStudio.Model.AccessDeniedException">
        /// You are not authorized to perform this operation. Check your IAM policies, and ensure
        /// that you are using the correct access keys.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ConflictException">
        /// Another operation is in progress.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.InternalServerErrorException">
        /// An internal error has occurred. Please retry your request.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ThrottlingException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ValidationException">
        /// One of the parameters in the request is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nimble-2020-08-01/GetStreamingSessionBackup">REST API Reference for GetStreamingSessionBackup Operation</seealso>
        GetStreamingSessionBackupResponse GetStreamingSessionBackup(GetStreamingSessionBackupRequest request);



        /// <summary>
        /// Gets <code>StreamingSessionBackup</code> resource.
        /// 
        ///  
        /// <para>
        /// Invoke this operation to poll for a streaming session backup while stopping a streaming
        /// session.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetStreamingSessionBackup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetStreamingSessionBackup service method, as returned by NimbleStudio.</returns>
        /// <exception cref="Amazon.NimbleStudio.Model.AccessDeniedException">
        /// You are not authorized to perform this operation. Check your IAM policies, and ensure
        /// that you are using the correct access keys.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ConflictException">
        /// Another operation is in progress.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.InternalServerErrorException">
        /// An internal error has occurred. Please retry your request.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ThrottlingException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ValidationException">
        /// One of the parameters in the request is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nimble-2020-08-01/GetStreamingSessionBackup">REST API Reference for GetStreamingSessionBackup Operation</seealso>
        Task<GetStreamingSessionBackupResponse> GetStreamingSessionBackupAsync(GetStreamingSessionBackupRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetStreamingSessionStream


        /// <summary>
        /// Gets a StreamingSessionStream for a streaming session.
        /// 
        ///  
        /// <para>
        /// Invoke this operation to poll the resource after invoking <code>CreateStreamingSessionStream</code>.
        /// </para>
        ///  
        /// <para>
        /// After the <code>StreamingSessionStream</code> changes to the <code>READY</code> state,
        /// the url property will contain a stream to be used with the DCV streaming client.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetStreamingSessionStream service method.</param>
        /// 
        /// <returns>The response from the GetStreamingSessionStream service method, as returned by NimbleStudio.</returns>
        /// <exception cref="Amazon.NimbleStudio.Model.AccessDeniedException">
        /// You are not authorized to perform this operation. Check your IAM policies, and ensure
        /// that you are using the correct access keys.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ConflictException">
        /// Another operation is in progress.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.InternalServerErrorException">
        /// An internal error has occurred. Please retry your request.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ServiceQuotaExceededException">
        /// Your current quota does not allow you to perform the request action. You can request
        /// increases for some quotas, and other quotas cannot be increased.
        /// 
        ///  
        /// <para>
        /// Please use Amazon Web Services Service Quotas to request an increase. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ThrottlingException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ValidationException">
        /// One of the parameters in the request is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nimble-2020-08-01/GetStreamingSessionStream">REST API Reference for GetStreamingSessionStream Operation</seealso>
        GetStreamingSessionStreamResponse GetStreamingSessionStream(GetStreamingSessionStreamRequest request);



        /// <summary>
        /// Gets a StreamingSessionStream for a streaming session.
        /// 
        ///  
        /// <para>
        /// Invoke this operation to poll the resource after invoking <code>CreateStreamingSessionStream</code>.
        /// </para>
        ///  
        /// <para>
        /// After the <code>StreamingSessionStream</code> changes to the <code>READY</code> state,
        /// the url property will contain a stream to be used with the DCV streaming client.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetStreamingSessionStream service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetStreamingSessionStream service method, as returned by NimbleStudio.</returns>
        /// <exception cref="Amazon.NimbleStudio.Model.AccessDeniedException">
        /// You are not authorized to perform this operation. Check your IAM policies, and ensure
        /// that you are using the correct access keys.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ConflictException">
        /// Another operation is in progress.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.InternalServerErrorException">
        /// An internal error has occurred. Please retry your request.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ServiceQuotaExceededException">
        /// Your current quota does not allow you to perform the request action. You can request
        /// increases for some quotas, and other quotas cannot be increased.
        /// 
        ///  
        /// <para>
        /// Please use Amazon Web Services Service Quotas to request an increase. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ThrottlingException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ValidationException">
        /// One of the parameters in the request is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nimble-2020-08-01/GetStreamingSessionStream">REST API Reference for GetStreamingSessionStream Operation</seealso>
        Task<GetStreamingSessionStreamResponse> GetStreamingSessionStreamAsync(GetStreamingSessionStreamRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetStudio


        /// <summary>
        /// Get a studio resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetStudio service method.</param>
        /// 
        /// <returns>The response from the GetStudio service method, as returned by NimbleStudio.</returns>
        /// <exception cref="Amazon.NimbleStudio.Model.AccessDeniedException">
        /// You are not authorized to perform this operation. Check your IAM policies, and ensure
        /// that you are using the correct access keys.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ConflictException">
        /// Another operation is in progress.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.InternalServerErrorException">
        /// An internal error has occurred. Please retry your request.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ServiceQuotaExceededException">
        /// Your current quota does not allow you to perform the request action. You can request
        /// increases for some quotas, and other quotas cannot be increased.
        /// 
        ///  
        /// <para>
        /// Please use Amazon Web Services Service Quotas to request an increase. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ThrottlingException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ValidationException">
        /// One of the parameters in the request is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nimble-2020-08-01/GetStudio">REST API Reference for GetStudio Operation</seealso>
        GetStudioResponse GetStudio(GetStudioRequest request);



        /// <summary>
        /// Get a studio resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetStudio service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetStudio service method, as returned by NimbleStudio.</returns>
        /// <exception cref="Amazon.NimbleStudio.Model.AccessDeniedException">
        /// You are not authorized to perform this operation. Check your IAM policies, and ensure
        /// that you are using the correct access keys.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ConflictException">
        /// Another operation is in progress.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.InternalServerErrorException">
        /// An internal error has occurred. Please retry your request.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ServiceQuotaExceededException">
        /// Your current quota does not allow you to perform the request action. You can request
        /// increases for some quotas, and other quotas cannot be increased.
        /// 
        ///  
        /// <para>
        /// Please use Amazon Web Services Service Quotas to request an increase. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ThrottlingException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ValidationException">
        /// One of the parameters in the request is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nimble-2020-08-01/GetStudio">REST API Reference for GetStudio Operation</seealso>
        Task<GetStudioResponse> GetStudioAsync(GetStudioRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetStudioComponent


        /// <summary>
        /// Gets a studio component resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetStudioComponent service method.</param>
        /// 
        /// <returns>The response from the GetStudioComponent service method, as returned by NimbleStudio.</returns>
        /// <exception cref="Amazon.NimbleStudio.Model.AccessDeniedException">
        /// You are not authorized to perform this operation. Check your IAM policies, and ensure
        /// that you are using the correct access keys.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ConflictException">
        /// Another operation is in progress.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.InternalServerErrorException">
        /// An internal error has occurred. Please retry your request.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ServiceQuotaExceededException">
        /// Your current quota does not allow you to perform the request action. You can request
        /// increases for some quotas, and other quotas cannot be increased.
        /// 
        ///  
        /// <para>
        /// Please use Amazon Web Services Service Quotas to request an increase. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ThrottlingException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ValidationException">
        /// One of the parameters in the request is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nimble-2020-08-01/GetStudioComponent">REST API Reference for GetStudioComponent Operation</seealso>
        GetStudioComponentResponse GetStudioComponent(GetStudioComponentRequest request);



        /// <summary>
        /// Gets a studio component resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetStudioComponent service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetStudioComponent service method, as returned by NimbleStudio.</returns>
        /// <exception cref="Amazon.NimbleStudio.Model.AccessDeniedException">
        /// You are not authorized to perform this operation. Check your IAM policies, and ensure
        /// that you are using the correct access keys.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ConflictException">
        /// Another operation is in progress.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.InternalServerErrorException">
        /// An internal error has occurred. Please retry your request.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ServiceQuotaExceededException">
        /// Your current quota does not allow you to perform the request action. You can request
        /// increases for some quotas, and other quotas cannot be increased.
        /// 
        ///  
        /// <para>
        /// Please use Amazon Web Services Service Quotas to request an increase. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ThrottlingException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ValidationException">
        /// One of the parameters in the request is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nimble-2020-08-01/GetStudioComponent">REST API Reference for GetStudioComponent Operation</seealso>
        Task<GetStudioComponentResponse> GetStudioComponentAsync(GetStudioComponentRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetStudioMember


        /// <summary>
        /// Get a user's membership in a studio.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetStudioMember service method.</param>
        /// 
        /// <returns>The response from the GetStudioMember service method, as returned by NimbleStudio.</returns>
        /// <exception cref="Amazon.NimbleStudio.Model.AccessDeniedException">
        /// You are not authorized to perform this operation. Check your IAM policies, and ensure
        /// that you are using the correct access keys.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ConflictException">
        /// Another operation is in progress.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.InternalServerErrorException">
        /// An internal error has occurred. Please retry your request.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ServiceQuotaExceededException">
        /// Your current quota does not allow you to perform the request action. You can request
        /// increases for some quotas, and other quotas cannot be increased.
        /// 
        ///  
        /// <para>
        /// Please use Amazon Web Services Service Quotas to request an increase. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ThrottlingException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ValidationException">
        /// One of the parameters in the request is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nimble-2020-08-01/GetStudioMember">REST API Reference for GetStudioMember Operation</seealso>
        GetStudioMemberResponse GetStudioMember(GetStudioMemberRequest request);



        /// <summary>
        /// Get a user's membership in a studio.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetStudioMember service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetStudioMember service method, as returned by NimbleStudio.</returns>
        /// <exception cref="Amazon.NimbleStudio.Model.AccessDeniedException">
        /// You are not authorized to perform this operation. Check your IAM policies, and ensure
        /// that you are using the correct access keys.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ConflictException">
        /// Another operation is in progress.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.InternalServerErrorException">
        /// An internal error has occurred. Please retry your request.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ServiceQuotaExceededException">
        /// Your current quota does not allow you to perform the request action. You can request
        /// increases for some quotas, and other quotas cannot be increased.
        /// 
        ///  
        /// <para>
        /// Please use Amazon Web Services Service Quotas to request an increase. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ThrottlingException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ValidationException">
        /// One of the parameters in the request is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nimble-2020-08-01/GetStudioMember">REST API Reference for GetStudioMember Operation</seealso>
        Task<GetStudioMemberResponse> GetStudioMemberAsync(GetStudioMemberRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListEulaAcceptances


        /// <summary>
        /// List EULA acceptances.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListEulaAcceptances service method.</param>
        /// 
        /// <returns>The response from the ListEulaAcceptances service method, as returned by NimbleStudio.</returns>
        /// <exception cref="Amazon.NimbleStudio.Model.AccessDeniedException">
        /// You are not authorized to perform this operation. Check your IAM policies, and ensure
        /// that you are using the correct access keys.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ConflictException">
        /// Another operation is in progress.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.InternalServerErrorException">
        /// An internal error has occurred. Please retry your request.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ServiceQuotaExceededException">
        /// Your current quota does not allow you to perform the request action. You can request
        /// increases for some quotas, and other quotas cannot be increased.
        /// 
        ///  
        /// <para>
        /// Please use Amazon Web Services Service Quotas to request an increase. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ThrottlingException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ValidationException">
        /// One of the parameters in the request is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nimble-2020-08-01/ListEulaAcceptances">REST API Reference for ListEulaAcceptances Operation</seealso>
        ListEulaAcceptancesResponse ListEulaAcceptances(ListEulaAcceptancesRequest request);



        /// <summary>
        /// List EULA acceptances.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListEulaAcceptances service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListEulaAcceptances service method, as returned by NimbleStudio.</returns>
        /// <exception cref="Amazon.NimbleStudio.Model.AccessDeniedException">
        /// You are not authorized to perform this operation. Check your IAM policies, and ensure
        /// that you are using the correct access keys.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ConflictException">
        /// Another operation is in progress.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.InternalServerErrorException">
        /// An internal error has occurred. Please retry your request.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ServiceQuotaExceededException">
        /// Your current quota does not allow you to perform the request action. You can request
        /// increases for some quotas, and other quotas cannot be increased.
        /// 
        ///  
        /// <para>
        /// Please use Amazon Web Services Service Quotas to request an increase. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ThrottlingException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ValidationException">
        /// One of the parameters in the request is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nimble-2020-08-01/ListEulaAcceptances">REST API Reference for ListEulaAcceptances Operation</seealso>
        Task<ListEulaAcceptancesResponse> ListEulaAcceptancesAsync(ListEulaAcceptancesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListEulas


        /// <summary>
        /// List EULAs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListEulas service method.</param>
        /// 
        /// <returns>The response from the ListEulas service method, as returned by NimbleStudio.</returns>
        /// <exception cref="Amazon.NimbleStudio.Model.AccessDeniedException">
        /// You are not authorized to perform this operation. Check your IAM policies, and ensure
        /// that you are using the correct access keys.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ConflictException">
        /// Another operation is in progress.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.InternalServerErrorException">
        /// An internal error has occurred. Please retry your request.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ServiceQuotaExceededException">
        /// Your current quota does not allow you to perform the request action. You can request
        /// increases for some quotas, and other quotas cannot be increased.
        /// 
        ///  
        /// <para>
        /// Please use Amazon Web Services Service Quotas to request an increase. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ThrottlingException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ValidationException">
        /// One of the parameters in the request is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nimble-2020-08-01/ListEulas">REST API Reference for ListEulas Operation</seealso>
        ListEulasResponse ListEulas(ListEulasRequest request);



        /// <summary>
        /// List EULAs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListEulas service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListEulas service method, as returned by NimbleStudio.</returns>
        /// <exception cref="Amazon.NimbleStudio.Model.AccessDeniedException">
        /// You are not authorized to perform this operation. Check your IAM policies, and ensure
        /// that you are using the correct access keys.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ConflictException">
        /// Another operation is in progress.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.InternalServerErrorException">
        /// An internal error has occurred. Please retry your request.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ServiceQuotaExceededException">
        /// Your current quota does not allow you to perform the request action. You can request
        /// increases for some quotas, and other quotas cannot be increased.
        /// 
        ///  
        /// <para>
        /// Please use Amazon Web Services Service Quotas to request an increase. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ThrottlingException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ValidationException">
        /// One of the parameters in the request is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nimble-2020-08-01/ListEulas">REST API Reference for ListEulas Operation</seealso>
        Task<ListEulasResponse> ListEulasAsync(ListEulasRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListLaunchProfileMembers


        /// <summary>
        /// Get all users in a given launch profile membership.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListLaunchProfileMembers service method.</param>
        /// 
        /// <returns>The response from the ListLaunchProfileMembers service method, as returned by NimbleStudio.</returns>
        /// <exception cref="Amazon.NimbleStudio.Model.AccessDeniedException">
        /// You are not authorized to perform this operation. Check your IAM policies, and ensure
        /// that you are using the correct access keys.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ConflictException">
        /// Another operation is in progress.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.InternalServerErrorException">
        /// An internal error has occurred. Please retry your request.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ServiceQuotaExceededException">
        /// Your current quota does not allow you to perform the request action. You can request
        /// increases for some quotas, and other quotas cannot be increased.
        /// 
        ///  
        /// <para>
        /// Please use Amazon Web Services Service Quotas to request an increase. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ThrottlingException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ValidationException">
        /// One of the parameters in the request is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nimble-2020-08-01/ListLaunchProfileMembers">REST API Reference for ListLaunchProfileMembers Operation</seealso>
        ListLaunchProfileMembersResponse ListLaunchProfileMembers(ListLaunchProfileMembersRequest request);



        /// <summary>
        /// Get all users in a given launch profile membership.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListLaunchProfileMembers service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListLaunchProfileMembers service method, as returned by NimbleStudio.</returns>
        /// <exception cref="Amazon.NimbleStudio.Model.AccessDeniedException">
        /// You are not authorized to perform this operation. Check your IAM policies, and ensure
        /// that you are using the correct access keys.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ConflictException">
        /// Another operation is in progress.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.InternalServerErrorException">
        /// An internal error has occurred. Please retry your request.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ServiceQuotaExceededException">
        /// Your current quota does not allow you to perform the request action. You can request
        /// increases for some quotas, and other quotas cannot be increased.
        /// 
        ///  
        /// <para>
        /// Please use Amazon Web Services Service Quotas to request an increase. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ThrottlingException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ValidationException">
        /// One of the parameters in the request is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nimble-2020-08-01/ListLaunchProfileMembers">REST API Reference for ListLaunchProfileMembers Operation</seealso>
        Task<ListLaunchProfileMembersResponse> ListLaunchProfileMembersAsync(ListLaunchProfileMembersRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListLaunchProfiles


        /// <summary>
        /// List all the launch profiles a studio.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListLaunchProfiles service method.</param>
        /// 
        /// <returns>The response from the ListLaunchProfiles service method, as returned by NimbleStudio.</returns>
        /// <exception cref="Amazon.NimbleStudio.Model.AccessDeniedException">
        /// You are not authorized to perform this operation. Check your IAM policies, and ensure
        /// that you are using the correct access keys.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ConflictException">
        /// Another operation is in progress.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.InternalServerErrorException">
        /// An internal error has occurred. Please retry your request.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ServiceQuotaExceededException">
        /// Your current quota does not allow you to perform the request action. You can request
        /// increases for some quotas, and other quotas cannot be increased.
        /// 
        ///  
        /// <para>
        /// Please use Amazon Web Services Service Quotas to request an increase. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ThrottlingException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ValidationException">
        /// One of the parameters in the request is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nimble-2020-08-01/ListLaunchProfiles">REST API Reference for ListLaunchProfiles Operation</seealso>
        ListLaunchProfilesResponse ListLaunchProfiles(ListLaunchProfilesRequest request);



        /// <summary>
        /// List all the launch profiles a studio.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListLaunchProfiles service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListLaunchProfiles service method, as returned by NimbleStudio.</returns>
        /// <exception cref="Amazon.NimbleStudio.Model.AccessDeniedException">
        /// You are not authorized to perform this operation. Check your IAM policies, and ensure
        /// that you are using the correct access keys.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ConflictException">
        /// Another operation is in progress.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.InternalServerErrorException">
        /// An internal error has occurred. Please retry your request.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ServiceQuotaExceededException">
        /// Your current quota does not allow you to perform the request action. You can request
        /// increases for some quotas, and other quotas cannot be increased.
        /// 
        ///  
        /// <para>
        /// Please use Amazon Web Services Service Quotas to request an increase. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ThrottlingException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ValidationException">
        /// One of the parameters in the request is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nimble-2020-08-01/ListLaunchProfiles">REST API Reference for ListLaunchProfiles Operation</seealso>
        Task<ListLaunchProfilesResponse> ListLaunchProfilesAsync(ListLaunchProfilesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListStreamingImages


        /// <summary>
        /// List the streaming image resources available to this studio.
        /// 
        ///  
        /// <para>
        /// This list will contain both images provided by Amazon Web Services, as well as streaming
        /// images that you have created in your studio.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListStreamingImages service method.</param>
        /// 
        /// <returns>The response from the ListStreamingImages service method, as returned by NimbleStudio.</returns>
        /// <exception cref="Amazon.NimbleStudio.Model.AccessDeniedException">
        /// You are not authorized to perform this operation. Check your IAM policies, and ensure
        /// that you are using the correct access keys.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ConflictException">
        /// Another operation is in progress.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.InternalServerErrorException">
        /// An internal error has occurred. Please retry your request.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ServiceQuotaExceededException">
        /// Your current quota does not allow you to perform the request action. You can request
        /// increases for some quotas, and other quotas cannot be increased.
        /// 
        ///  
        /// <para>
        /// Please use Amazon Web Services Service Quotas to request an increase. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ThrottlingException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ValidationException">
        /// One of the parameters in the request is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nimble-2020-08-01/ListStreamingImages">REST API Reference for ListStreamingImages Operation</seealso>
        ListStreamingImagesResponse ListStreamingImages(ListStreamingImagesRequest request);



        /// <summary>
        /// List the streaming image resources available to this studio.
        /// 
        ///  
        /// <para>
        /// This list will contain both images provided by Amazon Web Services, as well as streaming
        /// images that you have created in your studio.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListStreamingImages service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListStreamingImages service method, as returned by NimbleStudio.</returns>
        /// <exception cref="Amazon.NimbleStudio.Model.AccessDeniedException">
        /// You are not authorized to perform this operation. Check your IAM policies, and ensure
        /// that you are using the correct access keys.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ConflictException">
        /// Another operation is in progress.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.InternalServerErrorException">
        /// An internal error has occurred. Please retry your request.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ServiceQuotaExceededException">
        /// Your current quota does not allow you to perform the request action. You can request
        /// increases for some quotas, and other quotas cannot be increased.
        /// 
        ///  
        /// <para>
        /// Please use Amazon Web Services Service Quotas to request an increase. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ThrottlingException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ValidationException">
        /// One of the parameters in the request is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nimble-2020-08-01/ListStreamingImages">REST API Reference for ListStreamingImages Operation</seealso>
        Task<ListStreamingImagesResponse> ListStreamingImagesAsync(ListStreamingImagesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListStreamingSessionBackups


        /// <summary>
        /// Lists the backups of a streaming session in a studio.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListStreamingSessionBackups service method.</param>
        /// 
        /// <returns>The response from the ListStreamingSessionBackups service method, as returned by NimbleStudio.</returns>
        /// <exception cref="Amazon.NimbleStudio.Model.AccessDeniedException">
        /// You are not authorized to perform this operation. Check your IAM policies, and ensure
        /// that you are using the correct access keys.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ConflictException">
        /// Another operation is in progress.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.InternalServerErrorException">
        /// An internal error has occurred. Please retry your request.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ThrottlingException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ValidationException">
        /// One of the parameters in the request is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nimble-2020-08-01/ListStreamingSessionBackups">REST API Reference for ListStreamingSessionBackups Operation</seealso>
        ListStreamingSessionBackupsResponse ListStreamingSessionBackups(ListStreamingSessionBackupsRequest request);



        /// <summary>
        /// Lists the backups of a streaming session in a studio.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListStreamingSessionBackups service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListStreamingSessionBackups service method, as returned by NimbleStudio.</returns>
        /// <exception cref="Amazon.NimbleStudio.Model.AccessDeniedException">
        /// You are not authorized to perform this operation. Check your IAM policies, and ensure
        /// that you are using the correct access keys.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ConflictException">
        /// Another operation is in progress.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.InternalServerErrorException">
        /// An internal error has occurred. Please retry your request.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ThrottlingException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ValidationException">
        /// One of the parameters in the request is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nimble-2020-08-01/ListStreamingSessionBackups">REST API Reference for ListStreamingSessionBackups Operation</seealso>
        Task<ListStreamingSessionBackupsResponse> ListStreamingSessionBackupsAsync(ListStreamingSessionBackupsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListStreamingSessions


        /// <summary>
        /// Lists the streaming sessions in a studio.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListStreamingSessions service method.</param>
        /// 
        /// <returns>The response from the ListStreamingSessions service method, as returned by NimbleStudio.</returns>
        /// <exception cref="Amazon.NimbleStudio.Model.AccessDeniedException">
        /// You are not authorized to perform this operation. Check your IAM policies, and ensure
        /// that you are using the correct access keys.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ConflictException">
        /// Another operation is in progress.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.InternalServerErrorException">
        /// An internal error has occurred. Please retry your request.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ServiceQuotaExceededException">
        /// Your current quota does not allow you to perform the request action. You can request
        /// increases for some quotas, and other quotas cannot be increased.
        /// 
        ///  
        /// <para>
        /// Please use Amazon Web Services Service Quotas to request an increase. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ThrottlingException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ValidationException">
        /// One of the parameters in the request is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nimble-2020-08-01/ListStreamingSessions">REST API Reference for ListStreamingSessions Operation</seealso>
        ListStreamingSessionsResponse ListStreamingSessions(ListStreamingSessionsRequest request);



        /// <summary>
        /// Lists the streaming sessions in a studio.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListStreamingSessions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListStreamingSessions service method, as returned by NimbleStudio.</returns>
        /// <exception cref="Amazon.NimbleStudio.Model.AccessDeniedException">
        /// You are not authorized to perform this operation. Check your IAM policies, and ensure
        /// that you are using the correct access keys.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ConflictException">
        /// Another operation is in progress.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.InternalServerErrorException">
        /// An internal error has occurred. Please retry your request.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ServiceQuotaExceededException">
        /// Your current quota does not allow you to perform the request action. You can request
        /// increases for some quotas, and other quotas cannot be increased.
        /// 
        ///  
        /// <para>
        /// Please use Amazon Web Services Service Quotas to request an increase. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ThrottlingException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ValidationException">
        /// One of the parameters in the request is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nimble-2020-08-01/ListStreamingSessions">REST API Reference for ListStreamingSessions Operation</seealso>
        Task<ListStreamingSessionsResponse> ListStreamingSessionsAsync(ListStreamingSessionsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListStudioComponents


        /// <summary>
        /// Lists the <code>StudioComponents</code> in a studio.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListStudioComponents service method.</param>
        /// 
        /// <returns>The response from the ListStudioComponents service method, as returned by NimbleStudio.</returns>
        /// <exception cref="Amazon.NimbleStudio.Model.AccessDeniedException">
        /// You are not authorized to perform this operation. Check your IAM policies, and ensure
        /// that you are using the correct access keys.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ConflictException">
        /// Another operation is in progress.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.InternalServerErrorException">
        /// An internal error has occurred. Please retry your request.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ServiceQuotaExceededException">
        /// Your current quota does not allow you to perform the request action. You can request
        /// increases for some quotas, and other quotas cannot be increased.
        /// 
        ///  
        /// <para>
        /// Please use Amazon Web Services Service Quotas to request an increase. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ThrottlingException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ValidationException">
        /// One of the parameters in the request is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nimble-2020-08-01/ListStudioComponents">REST API Reference for ListStudioComponents Operation</seealso>
        ListStudioComponentsResponse ListStudioComponents(ListStudioComponentsRequest request);



        /// <summary>
        /// Lists the <code>StudioComponents</code> in a studio.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListStudioComponents service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListStudioComponents service method, as returned by NimbleStudio.</returns>
        /// <exception cref="Amazon.NimbleStudio.Model.AccessDeniedException">
        /// You are not authorized to perform this operation. Check your IAM policies, and ensure
        /// that you are using the correct access keys.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ConflictException">
        /// Another operation is in progress.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.InternalServerErrorException">
        /// An internal error has occurred. Please retry your request.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ServiceQuotaExceededException">
        /// Your current quota does not allow you to perform the request action. You can request
        /// increases for some quotas, and other quotas cannot be increased.
        /// 
        ///  
        /// <para>
        /// Please use Amazon Web Services Service Quotas to request an increase. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ThrottlingException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ValidationException">
        /// One of the parameters in the request is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nimble-2020-08-01/ListStudioComponents">REST API Reference for ListStudioComponents Operation</seealso>
        Task<ListStudioComponentsResponse> ListStudioComponentsAsync(ListStudioComponentsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListStudioMembers


        /// <summary>
        /// Get all users in a given studio membership.
        /// 
        ///  <note> 
        /// <para>
        ///  <code>ListStudioMembers</code> only returns admin members.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListStudioMembers service method.</param>
        /// 
        /// <returns>The response from the ListStudioMembers service method, as returned by NimbleStudio.</returns>
        /// <exception cref="Amazon.NimbleStudio.Model.AccessDeniedException">
        /// You are not authorized to perform this operation. Check your IAM policies, and ensure
        /// that you are using the correct access keys.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ConflictException">
        /// Another operation is in progress.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.InternalServerErrorException">
        /// An internal error has occurred. Please retry your request.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ServiceQuotaExceededException">
        /// Your current quota does not allow you to perform the request action. You can request
        /// increases for some quotas, and other quotas cannot be increased.
        /// 
        ///  
        /// <para>
        /// Please use Amazon Web Services Service Quotas to request an increase. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ThrottlingException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ValidationException">
        /// One of the parameters in the request is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nimble-2020-08-01/ListStudioMembers">REST API Reference for ListStudioMembers Operation</seealso>
        ListStudioMembersResponse ListStudioMembers(ListStudioMembersRequest request);



        /// <summary>
        /// Get all users in a given studio membership.
        /// 
        ///  <note> 
        /// <para>
        ///  <code>ListStudioMembers</code> only returns admin members.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListStudioMembers service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListStudioMembers service method, as returned by NimbleStudio.</returns>
        /// <exception cref="Amazon.NimbleStudio.Model.AccessDeniedException">
        /// You are not authorized to perform this operation. Check your IAM policies, and ensure
        /// that you are using the correct access keys.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ConflictException">
        /// Another operation is in progress.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.InternalServerErrorException">
        /// An internal error has occurred. Please retry your request.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ServiceQuotaExceededException">
        /// Your current quota does not allow you to perform the request action. You can request
        /// increases for some quotas, and other quotas cannot be increased.
        /// 
        ///  
        /// <para>
        /// Please use Amazon Web Services Service Quotas to request an increase. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ThrottlingException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ValidationException">
        /// One of the parameters in the request is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nimble-2020-08-01/ListStudioMembers">REST API Reference for ListStudioMembers Operation</seealso>
        Task<ListStudioMembersResponse> ListStudioMembersAsync(ListStudioMembersRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListStudios


        /// <summary>
        /// List studios in your Amazon Web Services accounts in the requested Amazon Web Services
        /// Region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListStudios service method.</param>
        /// 
        /// <returns>The response from the ListStudios service method, as returned by NimbleStudio.</returns>
        /// <exception cref="Amazon.NimbleStudio.Model.AccessDeniedException">
        /// You are not authorized to perform this operation. Check your IAM policies, and ensure
        /// that you are using the correct access keys.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ConflictException">
        /// Another operation is in progress.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.InternalServerErrorException">
        /// An internal error has occurred. Please retry your request.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ServiceQuotaExceededException">
        /// Your current quota does not allow you to perform the request action. You can request
        /// increases for some quotas, and other quotas cannot be increased.
        /// 
        ///  
        /// <para>
        /// Please use Amazon Web Services Service Quotas to request an increase. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ThrottlingException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ValidationException">
        /// One of the parameters in the request is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nimble-2020-08-01/ListStudios">REST API Reference for ListStudios Operation</seealso>
        ListStudiosResponse ListStudios(ListStudiosRequest request);



        /// <summary>
        /// List studios in your Amazon Web Services accounts in the requested Amazon Web Services
        /// Region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListStudios service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListStudios service method, as returned by NimbleStudio.</returns>
        /// <exception cref="Amazon.NimbleStudio.Model.AccessDeniedException">
        /// You are not authorized to perform this operation. Check your IAM policies, and ensure
        /// that you are using the correct access keys.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ConflictException">
        /// Another operation is in progress.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.InternalServerErrorException">
        /// An internal error has occurred. Please retry your request.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ServiceQuotaExceededException">
        /// Your current quota does not allow you to perform the request action. You can request
        /// increases for some quotas, and other quotas cannot be increased.
        /// 
        ///  
        /// <para>
        /// Please use Amazon Web Services Service Quotas to request an increase. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ThrottlingException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ValidationException">
        /// One of the parameters in the request is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nimble-2020-08-01/ListStudios">REST API Reference for ListStudios Operation</seealso>
        Task<ListStudiosResponse> ListStudiosAsync(ListStudiosRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// Gets the tags for a resource, given its Amazon Resource Names (ARN).
        /// 
        ///  
        /// <para>
        /// This operation supports ARNs for all resource types in Nimble Studio that support
        /// tags, including studio, studio component, launch profile, streaming image, and streaming
        /// session. All resources that can be tagged will contain an ARN property, so you do
        /// not have to create this ARN yourself.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by NimbleStudio.</returns>
        /// <exception cref="Amazon.NimbleStudio.Model.AccessDeniedException">
        /// You are not authorized to perform this operation. Check your IAM policies, and ensure
        /// that you are using the correct access keys.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ConflictException">
        /// Another operation is in progress.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.InternalServerErrorException">
        /// An internal error has occurred. Please retry your request.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ServiceQuotaExceededException">
        /// Your current quota does not allow you to perform the request action. You can request
        /// increases for some quotas, and other quotas cannot be increased.
        /// 
        ///  
        /// <para>
        /// Please use Amazon Web Services Service Quotas to request an increase. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ThrottlingException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ValidationException">
        /// One of the parameters in the request is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nimble-2020-08-01/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request);



        /// <summary>
        /// Gets the tags for a resource, given its Amazon Resource Names (ARN).
        /// 
        ///  
        /// <para>
        /// This operation supports ARNs for all resource types in Nimble Studio that support
        /// tags, including studio, studio component, launch profile, streaming image, and streaming
        /// session. All resources that can be tagged will contain an ARN property, so you do
        /// not have to create this ARN yourself.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by NimbleStudio.</returns>
        /// <exception cref="Amazon.NimbleStudio.Model.AccessDeniedException">
        /// You are not authorized to perform this operation. Check your IAM policies, and ensure
        /// that you are using the correct access keys.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ConflictException">
        /// Another operation is in progress.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.InternalServerErrorException">
        /// An internal error has occurred. Please retry your request.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ServiceQuotaExceededException">
        /// Your current quota does not allow you to perform the request action. You can request
        /// increases for some quotas, and other quotas cannot be increased.
        /// 
        ///  
        /// <para>
        /// Please use Amazon Web Services Service Quotas to request an increase. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ThrottlingException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ValidationException">
        /// One of the parameters in the request is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nimble-2020-08-01/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  PutLaunchProfileMembers


        /// <summary>
        /// Add/update users with given persona to launch profile membership.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutLaunchProfileMembers service method.</param>
        /// 
        /// <returns>The response from the PutLaunchProfileMembers service method, as returned by NimbleStudio.</returns>
        /// <exception cref="Amazon.NimbleStudio.Model.AccessDeniedException">
        /// You are not authorized to perform this operation. Check your IAM policies, and ensure
        /// that you are using the correct access keys.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ConflictException">
        /// Another operation is in progress.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.InternalServerErrorException">
        /// An internal error has occurred. Please retry your request.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ServiceQuotaExceededException">
        /// Your current quota does not allow you to perform the request action. You can request
        /// increases for some quotas, and other quotas cannot be increased.
        /// 
        ///  
        /// <para>
        /// Please use Amazon Web Services Service Quotas to request an increase. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ThrottlingException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ValidationException">
        /// One of the parameters in the request is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nimble-2020-08-01/PutLaunchProfileMembers">REST API Reference for PutLaunchProfileMembers Operation</seealso>
        PutLaunchProfileMembersResponse PutLaunchProfileMembers(PutLaunchProfileMembersRequest request);



        /// <summary>
        /// Add/update users with given persona to launch profile membership.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutLaunchProfileMembers service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutLaunchProfileMembers service method, as returned by NimbleStudio.</returns>
        /// <exception cref="Amazon.NimbleStudio.Model.AccessDeniedException">
        /// You are not authorized to perform this operation. Check your IAM policies, and ensure
        /// that you are using the correct access keys.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ConflictException">
        /// Another operation is in progress.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.InternalServerErrorException">
        /// An internal error has occurred. Please retry your request.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ServiceQuotaExceededException">
        /// Your current quota does not allow you to perform the request action. You can request
        /// increases for some quotas, and other quotas cannot be increased.
        /// 
        ///  
        /// <para>
        /// Please use Amazon Web Services Service Quotas to request an increase. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ThrottlingException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ValidationException">
        /// One of the parameters in the request is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nimble-2020-08-01/PutLaunchProfileMembers">REST API Reference for PutLaunchProfileMembers Operation</seealso>
        Task<PutLaunchProfileMembersResponse> PutLaunchProfileMembersAsync(PutLaunchProfileMembersRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  PutStudioMembers


        /// <summary>
        /// Add/update users with given persona to studio membership.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutStudioMembers service method.</param>
        /// 
        /// <returns>The response from the PutStudioMembers service method, as returned by NimbleStudio.</returns>
        /// <exception cref="Amazon.NimbleStudio.Model.AccessDeniedException">
        /// You are not authorized to perform this operation. Check your IAM policies, and ensure
        /// that you are using the correct access keys.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ConflictException">
        /// Another operation is in progress.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.InternalServerErrorException">
        /// An internal error has occurred. Please retry your request.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ServiceQuotaExceededException">
        /// Your current quota does not allow you to perform the request action. You can request
        /// increases for some quotas, and other quotas cannot be increased.
        /// 
        ///  
        /// <para>
        /// Please use Amazon Web Services Service Quotas to request an increase. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ThrottlingException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ValidationException">
        /// One of the parameters in the request is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nimble-2020-08-01/PutStudioMembers">REST API Reference for PutStudioMembers Operation</seealso>
        PutStudioMembersResponse PutStudioMembers(PutStudioMembersRequest request);



        /// <summary>
        /// Add/update users with given persona to studio membership.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutStudioMembers service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutStudioMembers service method, as returned by NimbleStudio.</returns>
        /// <exception cref="Amazon.NimbleStudio.Model.AccessDeniedException">
        /// You are not authorized to perform this operation. Check your IAM policies, and ensure
        /// that you are using the correct access keys.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ConflictException">
        /// Another operation is in progress.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.InternalServerErrorException">
        /// An internal error has occurred. Please retry your request.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ServiceQuotaExceededException">
        /// Your current quota does not allow you to perform the request action. You can request
        /// increases for some quotas, and other quotas cannot be increased.
        /// 
        ///  
        /// <para>
        /// Please use Amazon Web Services Service Quotas to request an increase. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ThrottlingException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ValidationException">
        /// One of the parameters in the request is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nimble-2020-08-01/PutStudioMembers">REST API Reference for PutStudioMembers Operation</seealso>
        Task<PutStudioMembersResponse> PutStudioMembersAsync(PutStudioMembersRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  StartStreamingSession


        /// <summary>
        /// Transitions sessions from the <code>STOPPED</code> state into the <code>READY</code>
        /// state. The <code>START_IN_PROGRESS</code> state is the intermediate state between
        /// the <code>STOPPED</code> and <code>READY</code> states.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartStreamingSession service method.</param>
        /// 
        /// <returns>The response from the StartStreamingSession service method, as returned by NimbleStudio.</returns>
        /// <exception cref="Amazon.NimbleStudio.Model.AccessDeniedException">
        /// You are not authorized to perform this operation. Check your IAM policies, and ensure
        /// that you are using the correct access keys.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ConflictException">
        /// Another operation is in progress.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.InternalServerErrorException">
        /// An internal error has occurred. Please retry your request.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ServiceQuotaExceededException">
        /// Your current quota does not allow you to perform the request action. You can request
        /// increases for some quotas, and other quotas cannot be increased.
        /// 
        ///  
        /// <para>
        /// Please use Amazon Web Services Service Quotas to request an increase. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ThrottlingException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ValidationException">
        /// One of the parameters in the request is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nimble-2020-08-01/StartStreamingSession">REST API Reference for StartStreamingSession Operation</seealso>
        StartStreamingSessionResponse StartStreamingSession(StartStreamingSessionRequest request);



        /// <summary>
        /// Transitions sessions from the <code>STOPPED</code> state into the <code>READY</code>
        /// state. The <code>START_IN_PROGRESS</code> state is the intermediate state between
        /// the <code>STOPPED</code> and <code>READY</code> states.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartStreamingSession service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartStreamingSession service method, as returned by NimbleStudio.</returns>
        /// <exception cref="Amazon.NimbleStudio.Model.AccessDeniedException">
        /// You are not authorized to perform this operation. Check your IAM policies, and ensure
        /// that you are using the correct access keys.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ConflictException">
        /// Another operation is in progress.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.InternalServerErrorException">
        /// An internal error has occurred. Please retry your request.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ServiceQuotaExceededException">
        /// Your current quota does not allow you to perform the request action. You can request
        /// increases for some quotas, and other quotas cannot be increased.
        /// 
        ///  
        /// <para>
        /// Please use Amazon Web Services Service Quotas to request an increase. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ThrottlingException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ValidationException">
        /// One of the parameters in the request is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nimble-2020-08-01/StartStreamingSession">REST API Reference for StartStreamingSession Operation</seealso>
        Task<StartStreamingSessionResponse> StartStreamingSessionAsync(StartStreamingSessionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  StartStudioSSOConfigurationRepair


        /// <summary>
        /// Repairs the IAM Identity Center configuration for a given studio.
        /// 
        ///  
        /// <para>
        /// If the studio has a valid IAM Identity Center configuration currently associated with
        /// it, this operation will fail with a validation error.
        /// </para>
        ///  
        /// <para>
        /// If the studio does not have a valid IAM Identity Center configuration currently associated
        /// with it, then a new IAM Identity Center application is created for the studio and
        /// the studio is changed to the <code>READY</code> state.
        /// </para>
        ///  
        /// <para>
        /// After the IAM Identity Center application is repaired, you must use the Amazon Nimble
        /// Studio console to add administrators and users to your studio.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartStudioSSOConfigurationRepair service method.</param>
        /// 
        /// <returns>The response from the StartStudioSSOConfigurationRepair service method, as returned by NimbleStudio.</returns>
        /// <exception cref="Amazon.NimbleStudio.Model.AccessDeniedException">
        /// You are not authorized to perform this operation. Check your IAM policies, and ensure
        /// that you are using the correct access keys.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ConflictException">
        /// Another operation is in progress.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.InternalServerErrorException">
        /// An internal error has occurred. Please retry your request.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ServiceQuotaExceededException">
        /// Your current quota does not allow you to perform the request action. You can request
        /// increases for some quotas, and other quotas cannot be increased.
        /// 
        ///  
        /// <para>
        /// Please use Amazon Web Services Service Quotas to request an increase. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ThrottlingException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ValidationException">
        /// One of the parameters in the request is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nimble-2020-08-01/StartStudioSSOConfigurationRepair">REST API Reference for StartStudioSSOConfigurationRepair Operation</seealso>
        StartStudioSSOConfigurationRepairResponse StartStudioSSOConfigurationRepair(StartStudioSSOConfigurationRepairRequest request);



        /// <summary>
        /// Repairs the IAM Identity Center configuration for a given studio.
        /// 
        ///  
        /// <para>
        /// If the studio has a valid IAM Identity Center configuration currently associated with
        /// it, this operation will fail with a validation error.
        /// </para>
        ///  
        /// <para>
        /// If the studio does not have a valid IAM Identity Center configuration currently associated
        /// with it, then a new IAM Identity Center application is created for the studio and
        /// the studio is changed to the <code>READY</code> state.
        /// </para>
        ///  
        /// <para>
        /// After the IAM Identity Center application is repaired, you must use the Amazon Nimble
        /// Studio console to add administrators and users to your studio.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartStudioSSOConfigurationRepair service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartStudioSSOConfigurationRepair service method, as returned by NimbleStudio.</returns>
        /// <exception cref="Amazon.NimbleStudio.Model.AccessDeniedException">
        /// You are not authorized to perform this operation. Check your IAM policies, and ensure
        /// that you are using the correct access keys.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ConflictException">
        /// Another operation is in progress.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.InternalServerErrorException">
        /// An internal error has occurred. Please retry your request.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ServiceQuotaExceededException">
        /// Your current quota does not allow you to perform the request action. You can request
        /// increases for some quotas, and other quotas cannot be increased.
        /// 
        ///  
        /// <para>
        /// Please use Amazon Web Services Service Quotas to request an increase. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ThrottlingException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ValidationException">
        /// One of the parameters in the request is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nimble-2020-08-01/StartStudioSSOConfigurationRepair">REST API Reference for StartStudioSSOConfigurationRepair Operation</seealso>
        Task<StartStudioSSOConfigurationRepairResponse> StartStudioSSOConfigurationRepairAsync(StartStudioSSOConfigurationRepairRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  StopStreamingSession


        /// <summary>
        /// Transitions sessions from the <code>READY</code> state into the <code>STOPPED</code>
        /// state. The <code>STOP_IN_PROGRESS</code> state is the intermediate state between the
        /// <code>READY</code> and <code>STOPPED</code> states.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopStreamingSession service method.</param>
        /// 
        /// <returns>The response from the StopStreamingSession service method, as returned by NimbleStudio.</returns>
        /// <exception cref="Amazon.NimbleStudio.Model.AccessDeniedException">
        /// You are not authorized to perform this operation. Check your IAM policies, and ensure
        /// that you are using the correct access keys.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ConflictException">
        /// Another operation is in progress.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.InternalServerErrorException">
        /// An internal error has occurred. Please retry your request.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ServiceQuotaExceededException">
        /// Your current quota does not allow you to perform the request action. You can request
        /// increases for some quotas, and other quotas cannot be increased.
        /// 
        ///  
        /// <para>
        /// Please use Amazon Web Services Service Quotas to request an increase. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ThrottlingException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ValidationException">
        /// One of the parameters in the request is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nimble-2020-08-01/StopStreamingSession">REST API Reference for StopStreamingSession Operation</seealso>
        StopStreamingSessionResponse StopStreamingSession(StopStreamingSessionRequest request);



        /// <summary>
        /// Transitions sessions from the <code>READY</code> state into the <code>STOPPED</code>
        /// state. The <code>STOP_IN_PROGRESS</code> state is the intermediate state between the
        /// <code>READY</code> and <code>STOPPED</code> states.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopStreamingSession service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StopStreamingSession service method, as returned by NimbleStudio.</returns>
        /// <exception cref="Amazon.NimbleStudio.Model.AccessDeniedException">
        /// You are not authorized to perform this operation. Check your IAM policies, and ensure
        /// that you are using the correct access keys.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ConflictException">
        /// Another operation is in progress.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.InternalServerErrorException">
        /// An internal error has occurred. Please retry your request.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ServiceQuotaExceededException">
        /// Your current quota does not allow you to perform the request action. You can request
        /// increases for some quotas, and other quotas cannot be increased.
        /// 
        ///  
        /// <para>
        /// Please use Amazon Web Services Service Quotas to request an increase. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ThrottlingException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ValidationException">
        /// One of the parameters in the request is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nimble-2020-08-01/StopStreamingSession">REST API Reference for StopStreamingSession Operation</seealso>
        Task<StopStreamingSessionResponse> StopStreamingSessionAsync(StopStreamingSessionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Creates tags for a resource, given its ARN.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by NimbleStudio.</returns>
        /// <exception cref="Amazon.NimbleStudio.Model.AccessDeniedException">
        /// You are not authorized to perform this operation. Check your IAM policies, and ensure
        /// that you are using the correct access keys.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ConflictException">
        /// Another operation is in progress.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.InternalServerErrorException">
        /// An internal error has occurred. Please retry your request.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ServiceQuotaExceededException">
        /// Your current quota does not allow you to perform the request action. You can request
        /// increases for some quotas, and other quotas cannot be increased.
        /// 
        ///  
        /// <para>
        /// Please use Amazon Web Services Service Quotas to request an increase. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ThrottlingException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ValidationException">
        /// One of the parameters in the request is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nimble-2020-08-01/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse TagResource(TagResourceRequest request);



        /// <summary>
        /// Creates tags for a resource, given its ARN.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by NimbleStudio.</returns>
        /// <exception cref="Amazon.NimbleStudio.Model.AccessDeniedException">
        /// You are not authorized to perform this operation. Check your IAM policies, and ensure
        /// that you are using the correct access keys.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ConflictException">
        /// Another operation is in progress.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.InternalServerErrorException">
        /// An internal error has occurred. Please retry your request.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ServiceQuotaExceededException">
        /// Your current quota does not allow you to perform the request action. You can request
        /// increases for some quotas, and other quotas cannot be increased.
        /// 
        ///  
        /// <para>
        /// Please use Amazon Web Services Service Quotas to request an increase. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ThrottlingException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ValidationException">
        /// One of the parameters in the request is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nimble-2020-08-01/TagResource">REST API Reference for TagResource Operation</seealso>
        Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// Deletes the tags for a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by NimbleStudio.</returns>
        /// <exception cref="Amazon.NimbleStudio.Model.AccessDeniedException">
        /// You are not authorized to perform this operation. Check your IAM policies, and ensure
        /// that you are using the correct access keys.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ConflictException">
        /// Another operation is in progress.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.InternalServerErrorException">
        /// An internal error has occurred. Please retry your request.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ServiceQuotaExceededException">
        /// Your current quota does not allow you to perform the request action. You can request
        /// increases for some quotas, and other quotas cannot be increased.
        /// 
        ///  
        /// <para>
        /// Please use Amazon Web Services Service Quotas to request an increase. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ThrottlingException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ValidationException">
        /// One of the parameters in the request is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nimble-2020-08-01/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse UntagResource(UntagResourceRequest request);



        /// <summary>
        /// Deletes the tags for a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by NimbleStudio.</returns>
        /// <exception cref="Amazon.NimbleStudio.Model.AccessDeniedException">
        /// You are not authorized to perform this operation. Check your IAM policies, and ensure
        /// that you are using the correct access keys.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ConflictException">
        /// Another operation is in progress.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.InternalServerErrorException">
        /// An internal error has occurred. Please retry your request.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ServiceQuotaExceededException">
        /// Your current quota does not allow you to perform the request action. You can request
        /// increases for some quotas, and other quotas cannot be increased.
        /// 
        ///  
        /// <para>
        /// Please use Amazon Web Services Service Quotas to request an increase. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ThrottlingException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ValidationException">
        /// One of the parameters in the request is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nimble-2020-08-01/UntagResource">REST API Reference for UntagResource Operation</seealso>
        Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateLaunchProfile


        /// <summary>
        /// Update a launch profile.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateLaunchProfile service method.</param>
        /// 
        /// <returns>The response from the UpdateLaunchProfile service method, as returned by NimbleStudio.</returns>
        /// <exception cref="Amazon.NimbleStudio.Model.AccessDeniedException">
        /// You are not authorized to perform this operation. Check your IAM policies, and ensure
        /// that you are using the correct access keys.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ConflictException">
        /// Another operation is in progress.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.InternalServerErrorException">
        /// An internal error has occurred. Please retry your request.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ServiceQuotaExceededException">
        /// Your current quota does not allow you to perform the request action. You can request
        /// increases for some quotas, and other quotas cannot be increased.
        /// 
        ///  
        /// <para>
        /// Please use Amazon Web Services Service Quotas to request an increase. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ThrottlingException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ValidationException">
        /// One of the parameters in the request is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nimble-2020-08-01/UpdateLaunchProfile">REST API Reference for UpdateLaunchProfile Operation</seealso>
        UpdateLaunchProfileResponse UpdateLaunchProfile(UpdateLaunchProfileRequest request);



        /// <summary>
        /// Update a launch profile.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateLaunchProfile service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateLaunchProfile service method, as returned by NimbleStudio.</returns>
        /// <exception cref="Amazon.NimbleStudio.Model.AccessDeniedException">
        /// You are not authorized to perform this operation. Check your IAM policies, and ensure
        /// that you are using the correct access keys.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ConflictException">
        /// Another operation is in progress.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.InternalServerErrorException">
        /// An internal error has occurred. Please retry your request.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ServiceQuotaExceededException">
        /// Your current quota does not allow you to perform the request action. You can request
        /// increases for some quotas, and other quotas cannot be increased.
        /// 
        ///  
        /// <para>
        /// Please use Amazon Web Services Service Quotas to request an increase. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ThrottlingException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ValidationException">
        /// One of the parameters in the request is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nimble-2020-08-01/UpdateLaunchProfile">REST API Reference for UpdateLaunchProfile Operation</seealso>
        Task<UpdateLaunchProfileResponse> UpdateLaunchProfileAsync(UpdateLaunchProfileRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateLaunchProfileMember


        /// <summary>
        /// Update a user persona in launch profile membership.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateLaunchProfileMember service method.</param>
        /// 
        /// <returns>The response from the UpdateLaunchProfileMember service method, as returned by NimbleStudio.</returns>
        /// <exception cref="Amazon.NimbleStudio.Model.AccessDeniedException">
        /// You are not authorized to perform this operation. Check your IAM policies, and ensure
        /// that you are using the correct access keys.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ConflictException">
        /// Another operation is in progress.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.InternalServerErrorException">
        /// An internal error has occurred. Please retry your request.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ServiceQuotaExceededException">
        /// Your current quota does not allow you to perform the request action. You can request
        /// increases for some quotas, and other quotas cannot be increased.
        /// 
        ///  
        /// <para>
        /// Please use Amazon Web Services Service Quotas to request an increase. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ThrottlingException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ValidationException">
        /// One of the parameters in the request is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nimble-2020-08-01/UpdateLaunchProfileMember">REST API Reference for UpdateLaunchProfileMember Operation</seealso>
        UpdateLaunchProfileMemberResponse UpdateLaunchProfileMember(UpdateLaunchProfileMemberRequest request);



        /// <summary>
        /// Update a user persona in launch profile membership.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateLaunchProfileMember service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateLaunchProfileMember service method, as returned by NimbleStudio.</returns>
        /// <exception cref="Amazon.NimbleStudio.Model.AccessDeniedException">
        /// You are not authorized to perform this operation. Check your IAM policies, and ensure
        /// that you are using the correct access keys.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ConflictException">
        /// Another operation is in progress.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.InternalServerErrorException">
        /// An internal error has occurred. Please retry your request.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ServiceQuotaExceededException">
        /// Your current quota does not allow you to perform the request action. You can request
        /// increases for some quotas, and other quotas cannot be increased.
        /// 
        ///  
        /// <para>
        /// Please use Amazon Web Services Service Quotas to request an increase. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ThrottlingException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ValidationException">
        /// One of the parameters in the request is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nimble-2020-08-01/UpdateLaunchProfileMember">REST API Reference for UpdateLaunchProfileMember Operation</seealso>
        Task<UpdateLaunchProfileMemberResponse> UpdateLaunchProfileMemberAsync(UpdateLaunchProfileMemberRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateStreamingImage


        /// <summary>
        /// Update streaming image.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateStreamingImage service method.</param>
        /// 
        /// <returns>The response from the UpdateStreamingImage service method, as returned by NimbleStudio.</returns>
        /// <exception cref="Amazon.NimbleStudio.Model.AccessDeniedException">
        /// You are not authorized to perform this operation. Check your IAM policies, and ensure
        /// that you are using the correct access keys.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ConflictException">
        /// Another operation is in progress.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.InternalServerErrorException">
        /// An internal error has occurred. Please retry your request.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ServiceQuotaExceededException">
        /// Your current quota does not allow you to perform the request action. You can request
        /// increases for some quotas, and other quotas cannot be increased.
        /// 
        ///  
        /// <para>
        /// Please use Amazon Web Services Service Quotas to request an increase. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ThrottlingException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ValidationException">
        /// One of the parameters in the request is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nimble-2020-08-01/UpdateStreamingImage">REST API Reference for UpdateStreamingImage Operation</seealso>
        UpdateStreamingImageResponse UpdateStreamingImage(UpdateStreamingImageRequest request);



        /// <summary>
        /// Update streaming image.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateStreamingImage service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateStreamingImage service method, as returned by NimbleStudio.</returns>
        /// <exception cref="Amazon.NimbleStudio.Model.AccessDeniedException">
        /// You are not authorized to perform this operation. Check your IAM policies, and ensure
        /// that you are using the correct access keys.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ConflictException">
        /// Another operation is in progress.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.InternalServerErrorException">
        /// An internal error has occurred. Please retry your request.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ServiceQuotaExceededException">
        /// Your current quota does not allow you to perform the request action. You can request
        /// increases for some quotas, and other quotas cannot be increased.
        /// 
        ///  
        /// <para>
        /// Please use Amazon Web Services Service Quotas to request an increase. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ThrottlingException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ValidationException">
        /// One of the parameters in the request is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nimble-2020-08-01/UpdateStreamingImage">REST API Reference for UpdateStreamingImage Operation</seealso>
        Task<UpdateStreamingImageResponse> UpdateStreamingImageAsync(UpdateStreamingImageRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateStudio


        /// <summary>
        /// Update a Studio resource.
        /// 
        ///  
        /// <para>
        /// Currently, this operation only supports updating the displayName of your studio.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateStudio service method.</param>
        /// 
        /// <returns>The response from the UpdateStudio service method, as returned by NimbleStudio.</returns>
        /// <exception cref="Amazon.NimbleStudio.Model.AccessDeniedException">
        /// You are not authorized to perform this operation. Check your IAM policies, and ensure
        /// that you are using the correct access keys.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ConflictException">
        /// Another operation is in progress.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.InternalServerErrorException">
        /// An internal error has occurred. Please retry your request.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ServiceQuotaExceededException">
        /// Your current quota does not allow you to perform the request action. You can request
        /// increases for some quotas, and other quotas cannot be increased.
        /// 
        ///  
        /// <para>
        /// Please use Amazon Web Services Service Quotas to request an increase. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ThrottlingException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ValidationException">
        /// One of the parameters in the request is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nimble-2020-08-01/UpdateStudio">REST API Reference for UpdateStudio Operation</seealso>
        UpdateStudioResponse UpdateStudio(UpdateStudioRequest request);



        /// <summary>
        /// Update a Studio resource.
        /// 
        ///  
        /// <para>
        /// Currently, this operation only supports updating the displayName of your studio.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateStudio service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateStudio service method, as returned by NimbleStudio.</returns>
        /// <exception cref="Amazon.NimbleStudio.Model.AccessDeniedException">
        /// You are not authorized to perform this operation. Check your IAM policies, and ensure
        /// that you are using the correct access keys.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ConflictException">
        /// Another operation is in progress.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.InternalServerErrorException">
        /// An internal error has occurred. Please retry your request.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ServiceQuotaExceededException">
        /// Your current quota does not allow you to perform the request action. You can request
        /// increases for some quotas, and other quotas cannot be increased.
        /// 
        ///  
        /// <para>
        /// Please use Amazon Web Services Service Quotas to request an increase. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ThrottlingException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ValidationException">
        /// One of the parameters in the request is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nimble-2020-08-01/UpdateStudio">REST API Reference for UpdateStudio Operation</seealso>
        Task<UpdateStudioResponse> UpdateStudioAsync(UpdateStudioRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateStudioComponent


        /// <summary>
        /// Updates a studio component resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateStudioComponent service method.</param>
        /// 
        /// <returns>The response from the UpdateStudioComponent service method, as returned by NimbleStudio.</returns>
        /// <exception cref="Amazon.NimbleStudio.Model.AccessDeniedException">
        /// You are not authorized to perform this operation. Check your IAM policies, and ensure
        /// that you are using the correct access keys.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ConflictException">
        /// Another operation is in progress.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.InternalServerErrorException">
        /// An internal error has occurred. Please retry your request.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ServiceQuotaExceededException">
        /// Your current quota does not allow you to perform the request action. You can request
        /// increases for some quotas, and other quotas cannot be increased.
        /// 
        ///  
        /// <para>
        /// Please use Amazon Web Services Service Quotas to request an increase. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ThrottlingException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ValidationException">
        /// One of the parameters in the request is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nimble-2020-08-01/UpdateStudioComponent">REST API Reference for UpdateStudioComponent Operation</seealso>
        UpdateStudioComponentResponse UpdateStudioComponent(UpdateStudioComponentRequest request);



        /// <summary>
        /// Updates a studio component resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateStudioComponent service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateStudioComponent service method, as returned by NimbleStudio.</returns>
        /// <exception cref="Amazon.NimbleStudio.Model.AccessDeniedException">
        /// You are not authorized to perform this operation. Check your IAM policies, and ensure
        /// that you are using the correct access keys.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ConflictException">
        /// Another operation is in progress.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.InternalServerErrorException">
        /// An internal error has occurred. Please retry your request.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ServiceQuotaExceededException">
        /// Your current quota does not allow you to perform the request action. You can request
        /// increases for some quotas, and other quotas cannot be increased.
        /// 
        ///  
        /// <para>
        /// Please use Amazon Web Services Service Quotas to request an increase. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ThrottlingException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.NimbleStudio.Model.ValidationException">
        /// One of the parameters in the request is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nimble-2020-08-01/UpdateStudioComponent">REST API Reference for UpdateStudioComponent Operation</seealso>
        Task<UpdateStudioComponentResponse> UpdateStudioComponentAsync(UpdateStudioComponentRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}