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


#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        INimbleStudioPaginatorFactory Paginators { get; }
#endif


        
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
        /// Initiates the asynchronous execution of the AcceptEulas operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AcceptEulas operation on AmazonNimbleStudioClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAcceptEulas
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nimble-2020-08-01/AcceptEulas">REST API Reference for AcceptEulas Operation</seealso>
        IAsyncResult BeginAcceptEulas(AcceptEulasRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  AcceptEulas operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAcceptEulas.</param>
        /// 
        /// <returns>Returns a  AcceptEulasResult from NimbleStudio.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nimble-2020-08-01/AcceptEulas">REST API Reference for AcceptEulas Operation</seealso>
        AcceptEulasResponse EndAcceptEulas(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the CreateLaunchProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateLaunchProfile operation on AmazonNimbleStudioClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateLaunchProfile
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nimble-2020-08-01/CreateLaunchProfile">REST API Reference for CreateLaunchProfile Operation</seealso>
        IAsyncResult BeginCreateLaunchProfile(CreateLaunchProfileRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateLaunchProfile operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateLaunchProfile.</param>
        /// 
        /// <returns>Returns a  CreateLaunchProfileResult from NimbleStudio.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nimble-2020-08-01/CreateLaunchProfile">REST API Reference for CreateLaunchProfile Operation</seealso>
        CreateLaunchProfileResponse EndCreateLaunchProfile(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the CreateStreamingImage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateStreamingImage operation on AmazonNimbleStudioClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateStreamingImage
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nimble-2020-08-01/CreateStreamingImage">REST API Reference for CreateStreamingImage Operation</seealso>
        IAsyncResult BeginCreateStreamingImage(CreateStreamingImageRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateStreamingImage operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateStreamingImage.</param>
        /// 
        /// <returns>Returns a  CreateStreamingImageResult from NimbleStudio.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nimble-2020-08-01/CreateStreamingImage">REST API Reference for CreateStreamingImage Operation</seealso>
        CreateStreamingImageResponse EndCreateStreamingImage(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the CreateStreamingSession operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateStreamingSession operation on AmazonNimbleStudioClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateStreamingSession
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nimble-2020-08-01/CreateStreamingSession">REST API Reference for CreateStreamingSession Operation</seealso>
        IAsyncResult BeginCreateStreamingSession(CreateStreamingSessionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateStreamingSession operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateStreamingSession.</param>
        /// 
        /// <returns>Returns a  CreateStreamingSessionResult from NimbleStudio.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nimble-2020-08-01/CreateStreamingSession">REST API Reference for CreateStreamingSession Operation</seealso>
        CreateStreamingSessionResponse EndCreateStreamingSession(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the CreateStreamingSessionStream operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateStreamingSessionStream operation on AmazonNimbleStudioClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateStreamingSessionStream
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nimble-2020-08-01/CreateStreamingSessionStream">REST API Reference for CreateStreamingSessionStream Operation</seealso>
        IAsyncResult BeginCreateStreamingSessionStream(CreateStreamingSessionStreamRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateStreamingSessionStream operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateStreamingSessionStream.</param>
        /// 
        /// <returns>Returns a  CreateStreamingSessionStreamResult from NimbleStudio.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nimble-2020-08-01/CreateStreamingSessionStream">REST API Reference for CreateStreamingSessionStream Operation</seealso>
        CreateStreamingSessionStreamResponse EndCreateStreamingSessionStream(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the CreateStudio operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateStudio operation on AmazonNimbleStudioClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateStudio
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nimble-2020-08-01/CreateStudio">REST API Reference for CreateStudio Operation</seealso>
        IAsyncResult BeginCreateStudio(CreateStudioRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateStudio operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateStudio.</param>
        /// 
        /// <returns>Returns a  CreateStudioResult from NimbleStudio.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nimble-2020-08-01/CreateStudio">REST API Reference for CreateStudio Operation</seealso>
        CreateStudioResponse EndCreateStudio(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the CreateStudioComponent operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateStudioComponent operation on AmazonNimbleStudioClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateStudioComponent
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nimble-2020-08-01/CreateStudioComponent">REST API Reference for CreateStudioComponent Operation</seealso>
        IAsyncResult BeginCreateStudioComponent(CreateStudioComponentRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateStudioComponent operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateStudioComponent.</param>
        /// 
        /// <returns>Returns a  CreateStudioComponentResult from NimbleStudio.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nimble-2020-08-01/CreateStudioComponent">REST API Reference for CreateStudioComponent Operation</seealso>
        CreateStudioComponentResponse EndCreateStudioComponent(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the DeleteLaunchProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteLaunchProfile operation on AmazonNimbleStudioClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteLaunchProfile
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nimble-2020-08-01/DeleteLaunchProfile">REST API Reference for DeleteLaunchProfile Operation</seealso>
        IAsyncResult BeginDeleteLaunchProfile(DeleteLaunchProfileRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteLaunchProfile operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteLaunchProfile.</param>
        /// 
        /// <returns>Returns a  DeleteLaunchProfileResult from NimbleStudio.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nimble-2020-08-01/DeleteLaunchProfile">REST API Reference for DeleteLaunchProfile Operation</seealso>
        DeleteLaunchProfileResponse EndDeleteLaunchProfile(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the DeleteLaunchProfileMember operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteLaunchProfileMember operation on AmazonNimbleStudioClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteLaunchProfileMember
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nimble-2020-08-01/DeleteLaunchProfileMember">REST API Reference for DeleteLaunchProfileMember Operation</seealso>
        IAsyncResult BeginDeleteLaunchProfileMember(DeleteLaunchProfileMemberRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteLaunchProfileMember operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteLaunchProfileMember.</param>
        /// 
        /// <returns>Returns a  DeleteLaunchProfileMemberResult from NimbleStudio.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nimble-2020-08-01/DeleteLaunchProfileMember">REST API Reference for DeleteLaunchProfileMember Operation</seealso>
        DeleteLaunchProfileMemberResponse EndDeleteLaunchProfileMember(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the DeleteStreamingImage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteStreamingImage operation on AmazonNimbleStudioClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteStreamingImage
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nimble-2020-08-01/DeleteStreamingImage">REST API Reference for DeleteStreamingImage Operation</seealso>
        IAsyncResult BeginDeleteStreamingImage(DeleteStreamingImageRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteStreamingImage operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteStreamingImage.</param>
        /// 
        /// <returns>Returns a  DeleteStreamingImageResult from NimbleStudio.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nimble-2020-08-01/DeleteStreamingImage">REST API Reference for DeleteStreamingImage Operation</seealso>
        DeleteStreamingImageResponse EndDeleteStreamingImage(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the DeleteStreamingSession operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteStreamingSession operation on AmazonNimbleStudioClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteStreamingSession
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nimble-2020-08-01/DeleteStreamingSession">REST API Reference for DeleteStreamingSession Operation</seealso>
        IAsyncResult BeginDeleteStreamingSession(DeleteStreamingSessionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteStreamingSession operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteStreamingSession.</param>
        /// 
        /// <returns>Returns a  DeleteStreamingSessionResult from NimbleStudio.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nimble-2020-08-01/DeleteStreamingSession">REST API Reference for DeleteStreamingSession Operation</seealso>
        DeleteStreamingSessionResponse EndDeleteStreamingSession(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the DeleteStudio operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteStudio operation on AmazonNimbleStudioClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteStudio
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nimble-2020-08-01/DeleteStudio">REST API Reference for DeleteStudio Operation</seealso>
        IAsyncResult BeginDeleteStudio(DeleteStudioRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteStudio operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteStudio.</param>
        /// 
        /// <returns>Returns a  DeleteStudioResult from NimbleStudio.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nimble-2020-08-01/DeleteStudio">REST API Reference for DeleteStudio Operation</seealso>
        DeleteStudioResponse EndDeleteStudio(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the DeleteStudioComponent operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteStudioComponent operation on AmazonNimbleStudioClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteStudioComponent
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nimble-2020-08-01/DeleteStudioComponent">REST API Reference for DeleteStudioComponent Operation</seealso>
        IAsyncResult BeginDeleteStudioComponent(DeleteStudioComponentRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteStudioComponent operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteStudioComponent.</param>
        /// 
        /// <returns>Returns a  DeleteStudioComponentResult from NimbleStudio.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nimble-2020-08-01/DeleteStudioComponent">REST API Reference for DeleteStudioComponent Operation</seealso>
        DeleteStudioComponentResponse EndDeleteStudioComponent(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the DeleteStudioMember operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteStudioMember operation on AmazonNimbleStudioClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteStudioMember
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nimble-2020-08-01/DeleteStudioMember">REST API Reference for DeleteStudioMember Operation</seealso>
        IAsyncResult BeginDeleteStudioMember(DeleteStudioMemberRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteStudioMember operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteStudioMember.</param>
        /// 
        /// <returns>Returns a  DeleteStudioMemberResult from NimbleStudio.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nimble-2020-08-01/DeleteStudioMember">REST API Reference for DeleteStudioMember Operation</seealso>
        DeleteStudioMemberResponse EndDeleteStudioMember(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the GetEula operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetEula operation on AmazonNimbleStudioClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetEula
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nimble-2020-08-01/GetEula">REST API Reference for GetEula Operation</seealso>
        IAsyncResult BeginGetEula(GetEulaRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetEula operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetEula.</param>
        /// 
        /// <returns>Returns a  GetEulaResult from NimbleStudio.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nimble-2020-08-01/GetEula">REST API Reference for GetEula Operation</seealso>
        GetEulaResponse EndGetEula(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the GetLaunchProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetLaunchProfile operation on AmazonNimbleStudioClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetLaunchProfile
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nimble-2020-08-01/GetLaunchProfile">REST API Reference for GetLaunchProfile Operation</seealso>
        IAsyncResult BeginGetLaunchProfile(GetLaunchProfileRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetLaunchProfile operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetLaunchProfile.</param>
        /// 
        /// <returns>Returns a  GetLaunchProfileResult from NimbleStudio.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nimble-2020-08-01/GetLaunchProfile">REST API Reference for GetLaunchProfile Operation</seealso>
        GetLaunchProfileResponse EndGetLaunchProfile(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the GetLaunchProfileDetails operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetLaunchProfileDetails operation on AmazonNimbleStudioClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetLaunchProfileDetails
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nimble-2020-08-01/GetLaunchProfileDetails">REST API Reference for GetLaunchProfileDetails Operation</seealso>
        IAsyncResult BeginGetLaunchProfileDetails(GetLaunchProfileDetailsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetLaunchProfileDetails operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetLaunchProfileDetails.</param>
        /// 
        /// <returns>Returns a  GetLaunchProfileDetailsResult from NimbleStudio.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nimble-2020-08-01/GetLaunchProfileDetails">REST API Reference for GetLaunchProfileDetails Operation</seealso>
        GetLaunchProfileDetailsResponse EndGetLaunchProfileDetails(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the GetLaunchProfileInitialization operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetLaunchProfileInitialization operation on AmazonNimbleStudioClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetLaunchProfileInitialization
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nimble-2020-08-01/GetLaunchProfileInitialization">REST API Reference for GetLaunchProfileInitialization Operation</seealso>
        IAsyncResult BeginGetLaunchProfileInitialization(GetLaunchProfileInitializationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetLaunchProfileInitialization operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetLaunchProfileInitialization.</param>
        /// 
        /// <returns>Returns a  GetLaunchProfileInitializationResult from NimbleStudio.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nimble-2020-08-01/GetLaunchProfileInitialization">REST API Reference for GetLaunchProfileInitialization Operation</seealso>
        GetLaunchProfileInitializationResponse EndGetLaunchProfileInitialization(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the GetLaunchProfileMember operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetLaunchProfileMember operation on AmazonNimbleStudioClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetLaunchProfileMember
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nimble-2020-08-01/GetLaunchProfileMember">REST API Reference for GetLaunchProfileMember Operation</seealso>
        IAsyncResult BeginGetLaunchProfileMember(GetLaunchProfileMemberRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetLaunchProfileMember operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetLaunchProfileMember.</param>
        /// 
        /// <returns>Returns a  GetLaunchProfileMemberResult from NimbleStudio.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nimble-2020-08-01/GetLaunchProfileMember">REST API Reference for GetLaunchProfileMember Operation</seealso>
        GetLaunchProfileMemberResponse EndGetLaunchProfileMember(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the GetStreamingImage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetStreamingImage operation on AmazonNimbleStudioClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetStreamingImage
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nimble-2020-08-01/GetStreamingImage">REST API Reference for GetStreamingImage Operation</seealso>
        IAsyncResult BeginGetStreamingImage(GetStreamingImageRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetStreamingImage operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetStreamingImage.</param>
        /// 
        /// <returns>Returns a  GetStreamingImageResult from NimbleStudio.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nimble-2020-08-01/GetStreamingImage">REST API Reference for GetStreamingImage Operation</seealso>
        GetStreamingImageResponse EndGetStreamingImage(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the GetStreamingSession operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetStreamingSession operation on AmazonNimbleStudioClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetStreamingSession
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nimble-2020-08-01/GetStreamingSession">REST API Reference for GetStreamingSession Operation</seealso>
        IAsyncResult BeginGetStreamingSession(GetStreamingSessionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetStreamingSession operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetStreamingSession.</param>
        /// 
        /// <returns>Returns a  GetStreamingSessionResult from NimbleStudio.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nimble-2020-08-01/GetStreamingSession">REST API Reference for GetStreamingSession Operation</seealso>
        GetStreamingSessionResponse EndGetStreamingSession(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the GetStreamingSessionBackup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetStreamingSessionBackup operation on AmazonNimbleStudioClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetStreamingSessionBackup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nimble-2020-08-01/GetStreamingSessionBackup">REST API Reference for GetStreamingSessionBackup Operation</seealso>
        IAsyncResult BeginGetStreamingSessionBackup(GetStreamingSessionBackupRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetStreamingSessionBackup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetStreamingSessionBackup.</param>
        /// 
        /// <returns>Returns a  GetStreamingSessionBackupResult from NimbleStudio.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nimble-2020-08-01/GetStreamingSessionBackup">REST API Reference for GetStreamingSessionBackup Operation</seealso>
        GetStreamingSessionBackupResponse EndGetStreamingSessionBackup(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the GetStreamingSessionStream operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetStreamingSessionStream operation on AmazonNimbleStudioClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetStreamingSessionStream
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nimble-2020-08-01/GetStreamingSessionStream">REST API Reference for GetStreamingSessionStream Operation</seealso>
        IAsyncResult BeginGetStreamingSessionStream(GetStreamingSessionStreamRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetStreamingSessionStream operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetStreamingSessionStream.</param>
        /// 
        /// <returns>Returns a  GetStreamingSessionStreamResult from NimbleStudio.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nimble-2020-08-01/GetStreamingSessionStream">REST API Reference for GetStreamingSessionStream Operation</seealso>
        GetStreamingSessionStreamResponse EndGetStreamingSessionStream(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the GetStudio operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetStudio operation on AmazonNimbleStudioClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetStudio
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nimble-2020-08-01/GetStudio">REST API Reference for GetStudio Operation</seealso>
        IAsyncResult BeginGetStudio(GetStudioRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetStudio operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetStudio.</param>
        /// 
        /// <returns>Returns a  GetStudioResult from NimbleStudio.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nimble-2020-08-01/GetStudio">REST API Reference for GetStudio Operation</seealso>
        GetStudioResponse EndGetStudio(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the GetStudioComponent operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetStudioComponent operation on AmazonNimbleStudioClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetStudioComponent
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nimble-2020-08-01/GetStudioComponent">REST API Reference for GetStudioComponent Operation</seealso>
        IAsyncResult BeginGetStudioComponent(GetStudioComponentRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetStudioComponent operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetStudioComponent.</param>
        /// 
        /// <returns>Returns a  GetStudioComponentResult from NimbleStudio.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nimble-2020-08-01/GetStudioComponent">REST API Reference for GetStudioComponent Operation</seealso>
        GetStudioComponentResponse EndGetStudioComponent(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the GetStudioMember operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetStudioMember operation on AmazonNimbleStudioClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetStudioMember
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nimble-2020-08-01/GetStudioMember">REST API Reference for GetStudioMember Operation</seealso>
        IAsyncResult BeginGetStudioMember(GetStudioMemberRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetStudioMember operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetStudioMember.</param>
        /// 
        /// <returns>Returns a  GetStudioMemberResult from NimbleStudio.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nimble-2020-08-01/GetStudioMember">REST API Reference for GetStudioMember Operation</seealso>
        GetStudioMemberResponse EndGetStudioMember(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the ListEulaAcceptances operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListEulaAcceptances operation on AmazonNimbleStudioClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListEulaAcceptances
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nimble-2020-08-01/ListEulaAcceptances">REST API Reference for ListEulaAcceptances Operation</seealso>
        IAsyncResult BeginListEulaAcceptances(ListEulaAcceptancesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListEulaAcceptances operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListEulaAcceptances.</param>
        /// 
        /// <returns>Returns a  ListEulaAcceptancesResult from NimbleStudio.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nimble-2020-08-01/ListEulaAcceptances">REST API Reference for ListEulaAcceptances Operation</seealso>
        ListEulaAcceptancesResponse EndListEulaAcceptances(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the ListEulas operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListEulas operation on AmazonNimbleStudioClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListEulas
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nimble-2020-08-01/ListEulas">REST API Reference for ListEulas Operation</seealso>
        IAsyncResult BeginListEulas(ListEulasRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListEulas operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListEulas.</param>
        /// 
        /// <returns>Returns a  ListEulasResult from NimbleStudio.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nimble-2020-08-01/ListEulas">REST API Reference for ListEulas Operation</seealso>
        ListEulasResponse EndListEulas(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the ListLaunchProfileMembers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListLaunchProfileMembers operation on AmazonNimbleStudioClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListLaunchProfileMembers
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nimble-2020-08-01/ListLaunchProfileMembers">REST API Reference for ListLaunchProfileMembers Operation</seealso>
        IAsyncResult BeginListLaunchProfileMembers(ListLaunchProfileMembersRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListLaunchProfileMembers operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListLaunchProfileMembers.</param>
        /// 
        /// <returns>Returns a  ListLaunchProfileMembersResult from NimbleStudio.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nimble-2020-08-01/ListLaunchProfileMembers">REST API Reference for ListLaunchProfileMembers Operation</seealso>
        ListLaunchProfileMembersResponse EndListLaunchProfileMembers(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the ListLaunchProfiles operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListLaunchProfiles operation on AmazonNimbleStudioClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListLaunchProfiles
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nimble-2020-08-01/ListLaunchProfiles">REST API Reference for ListLaunchProfiles Operation</seealso>
        IAsyncResult BeginListLaunchProfiles(ListLaunchProfilesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListLaunchProfiles operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListLaunchProfiles.</param>
        /// 
        /// <returns>Returns a  ListLaunchProfilesResult from NimbleStudio.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nimble-2020-08-01/ListLaunchProfiles">REST API Reference for ListLaunchProfiles Operation</seealso>
        ListLaunchProfilesResponse EndListLaunchProfiles(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the ListStreamingImages operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListStreamingImages operation on AmazonNimbleStudioClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListStreamingImages
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nimble-2020-08-01/ListStreamingImages">REST API Reference for ListStreamingImages Operation</seealso>
        IAsyncResult BeginListStreamingImages(ListStreamingImagesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListStreamingImages operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListStreamingImages.</param>
        /// 
        /// <returns>Returns a  ListStreamingImagesResult from NimbleStudio.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nimble-2020-08-01/ListStreamingImages">REST API Reference for ListStreamingImages Operation</seealso>
        ListStreamingImagesResponse EndListStreamingImages(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the ListStreamingSessionBackups operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListStreamingSessionBackups operation on AmazonNimbleStudioClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListStreamingSessionBackups
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nimble-2020-08-01/ListStreamingSessionBackups">REST API Reference for ListStreamingSessionBackups Operation</seealso>
        IAsyncResult BeginListStreamingSessionBackups(ListStreamingSessionBackupsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListStreamingSessionBackups operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListStreamingSessionBackups.</param>
        /// 
        /// <returns>Returns a  ListStreamingSessionBackupsResult from NimbleStudio.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nimble-2020-08-01/ListStreamingSessionBackups">REST API Reference for ListStreamingSessionBackups Operation</seealso>
        ListStreamingSessionBackupsResponse EndListStreamingSessionBackups(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the ListStreamingSessions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListStreamingSessions operation on AmazonNimbleStudioClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListStreamingSessions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nimble-2020-08-01/ListStreamingSessions">REST API Reference for ListStreamingSessions Operation</seealso>
        IAsyncResult BeginListStreamingSessions(ListStreamingSessionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListStreamingSessions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListStreamingSessions.</param>
        /// 
        /// <returns>Returns a  ListStreamingSessionsResult from NimbleStudio.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nimble-2020-08-01/ListStreamingSessions">REST API Reference for ListStreamingSessions Operation</seealso>
        ListStreamingSessionsResponse EndListStreamingSessions(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the ListStudioComponents operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListStudioComponents operation on AmazonNimbleStudioClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListStudioComponents
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nimble-2020-08-01/ListStudioComponents">REST API Reference for ListStudioComponents Operation</seealso>
        IAsyncResult BeginListStudioComponents(ListStudioComponentsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListStudioComponents operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListStudioComponents.</param>
        /// 
        /// <returns>Returns a  ListStudioComponentsResult from NimbleStudio.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nimble-2020-08-01/ListStudioComponents">REST API Reference for ListStudioComponents Operation</seealso>
        ListStudioComponentsResponse EndListStudioComponents(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the ListStudioMembers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListStudioMembers operation on AmazonNimbleStudioClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListStudioMembers
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nimble-2020-08-01/ListStudioMembers">REST API Reference for ListStudioMembers Operation</seealso>
        IAsyncResult BeginListStudioMembers(ListStudioMembersRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListStudioMembers operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListStudioMembers.</param>
        /// 
        /// <returns>Returns a  ListStudioMembersResult from NimbleStudio.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nimble-2020-08-01/ListStudioMembers">REST API Reference for ListStudioMembers Operation</seealso>
        ListStudioMembersResponse EndListStudioMembers(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the ListStudios operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListStudios operation on AmazonNimbleStudioClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListStudios
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nimble-2020-08-01/ListStudios">REST API Reference for ListStudios Operation</seealso>
        IAsyncResult BeginListStudios(ListStudiosRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListStudios operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListStudios.</param>
        /// 
        /// <returns>Returns a  ListStudiosResult from NimbleStudio.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nimble-2020-08-01/ListStudios">REST API Reference for ListStudios Operation</seealso>
        ListStudiosResponse EndListStudios(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonNimbleStudioClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nimble-2020-08-01/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        IAsyncResult BeginListTagsForResource(ListTagsForResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTagsForResource.</param>
        /// 
        /// <returns>Returns a  ListTagsForResourceResult from NimbleStudio.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nimble-2020-08-01/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the PutLaunchProfileMembers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutLaunchProfileMembers operation on AmazonNimbleStudioClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutLaunchProfileMembers
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nimble-2020-08-01/PutLaunchProfileMembers">REST API Reference for PutLaunchProfileMembers Operation</seealso>
        IAsyncResult BeginPutLaunchProfileMembers(PutLaunchProfileMembersRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  PutLaunchProfileMembers operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutLaunchProfileMembers.</param>
        /// 
        /// <returns>Returns a  PutLaunchProfileMembersResult from NimbleStudio.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nimble-2020-08-01/PutLaunchProfileMembers">REST API Reference for PutLaunchProfileMembers Operation</seealso>
        PutLaunchProfileMembersResponse EndPutLaunchProfileMembers(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the PutStudioMembers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutStudioMembers operation on AmazonNimbleStudioClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutStudioMembers
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nimble-2020-08-01/PutStudioMembers">REST API Reference for PutStudioMembers Operation</seealso>
        IAsyncResult BeginPutStudioMembers(PutStudioMembersRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  PutStudioMembers operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutStudioMembers.</param>
        /// 
        /// <returns>Returns a  PutStudioMembersResult from NimbleStudio.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nimble-2020-08-01/PutStudioMembers">REST API Reference for PutStudioMembers Operation</seealso>
        PutStudioMembersResponse EndPutStudioMembers(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the StartStreamingSession operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartStreamingSession operation on AmazonNimbleStudioClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartStreamingSession
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nimble-2020-08-01/StartStreamingSession">REST API Reference for StartStreamingSession Operation</seealso>
        IAsyncResult BeginStartStreamingSession(StartStreamingSessionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StartStreamingSession operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartStreamingSession.</param>
        /// 
        /// <returns>Returns a  StartStreamingSessionResult from NimbleStudio.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nimble-2020-08-01/StartStreamingSession">REST API Reference for StartStreamingSession Operation</seealso>
        StartStreamingSessionResponse EndStartStreamingSession(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the StartStudioSSOConfigurationRepair operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartStudioSSOConfigurationRepair operation on AmazonNimbleStudioClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartStudioSSOConfigurationRepair
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nimble-2020-08-01/StartStudioSSOConfigurationRepair">REST API Reference for StartStudioSSOConfigurationRepair Operation</seealso>
        IAsyncResult BeginStartStudioSSOConfigurationRepair(StartStudioSSOConfigurationRepairRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StartStudioSSOConfigurationRepair operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartStudioSSOConfigurationRepair.</param>
        /// 
        /// <returns>Returns a  StartStudioSSOConfigurationRepairResult from NimbleStudio.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nimble-2020-08-01/StartStudioSSOConfigurationRepair">REST API Reference for StartStudioSSOConfigurationRepair Operation</seealso>
        StartStudioSSOConfigurationRepairResponse EndStartStudioSSOConfigurationRepair(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the StopStreamingSession operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopStreamingSession operation on AmazonNimbleStudioClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStopStreamingSession
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nimble-2020-08-01/StopStreamingSession">REST API Reference for StopStreamingSession Operation</seealso>
        IAsyncResult BeginStopStreamingSession(StopStreamingSessionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StopStreamingSession operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStopStreamingSession.</param>
        /// 
        /// <returns>Returns a  StopStreamingSessionResult from NimbleStudio.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nimble-2020-08-01/StopStreamingSession">REST API Reference for StopStreamingSession Operation</seealso>
        StopStreamingSessionResponse EndStopStreamingSession(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the TagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonNimbleStudioClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nimble-2020-08-01/TagResource">REST API Reference for TagResource Operation</seealso>
        IAsyncResult BeginTagResource(TagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  TagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTagResource.</param>
        /// 
        /// <returns>Returns a  TagResourceResult from NimbleStudio.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nimble-2020-08-01/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse EndTagResource(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the UntagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonNimbleStudioClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nimble-2020-08-01/UntagResource">REST API Reference for UntagResource Operation</seealso>
        IAsyncResult BeginUntagResource(UntagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UntagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUntagResource.</param>
        /// 
        /// <returns>Returns a  UntagResourceResult from NimbleStudio.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nimble-2020-08-01/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse EndUntagResource(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the UpdateLaunchProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateLaunchProfile operation on AmazonNimbleStudioClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateLaunchProfile
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nimble-2020-08-01/UpdateLaunchProfile">REST API Reference for UpdateLaunchProfile Operation</seealso>
        IAsyncResult BeginUpdateLaunchProfile(UpdateLaunchProfileRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateLaunchProfile operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateLaunchProfile.</param>
        /// 
        /// <returns>Returns a  UpdateLaunchProfileResult from NimbleStudio.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nimble-2020-08-01/UpdateLaunchProfile">REST API Reference for UpdateLaunchProfile Operation</seealso>
        UpdateLaunchProfileResponse EndUpdateLaunchProfile(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the UpdateLaunchProfileMember operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateLaunchProfileMember operation on AmazonNimbleStudioClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateLaunchProfileMember
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nimble-2020-08-01/UpdateLaunchProfileMember">REST API Reference for UpdateLaunchProfileMember Operation</seealso>
        IAsyncResult BeginUpdateLaunchProfileMember(UpdateLaunchProfileMemberRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateLaunchProfileMember operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateLaunchProfileMember.</param>
        /// 
        /// <returns>Returns a  UpdateLaunchProfileMemberResult from NimbleStudio.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nimble-2020-08-01/UpdateLaunchProfileMember">REST API Reference for UpdateLaunchProfileMember Operation</seealso>
        UpdateLaunchProfileMemberResponse EndUpdateLaunchProfileMember(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the UpdateStreamingImage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateStreamingImage operation on AmazonNimbleStudioClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateStreamingImage
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nimble-2020-08-01/UpdateStreamingImage">REST API Reference for UpdateStreamingImage Operation</seealso>
        IAsyncResult BeginUpdateStreamingImage(UpdateStreamingImageRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateStreamingImage operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateStreamingImage.</param>
        /// 
        /// <returns>Returns a  UpdateStreamingImageResult from NimbleStudio.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nimble-2020-08-01/UpdateStreamingImage">REST API Reference for UpdateStreamingImage Operation</seealso>
        UpdateStreamingImageResponse EndUpdateStreamingImage(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the UpdateStudio operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateStudio operation on AmazonNimbleStudioClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateStudio
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nimble-2020-08-01/UpdateStudio">REST API Reference for UpdateStudio Operation</seealso>
        IAsyncResult BeginUpdateStudio(UpdateStudioRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateStudio operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateStudio.</param>
        /// 
        /// <returns>Returns a  UpdateStudioResult from NimbleStudio.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nimble-2020-08-01/UpdateStudio">REST API Reference for UpdateStudio Operation</seealso>
        UpdateStudioResponse EndUpdateStudio(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the UpdateStudioComponent operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateStudioComponent operation on AmazonNimbleStudioClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateStudioComponent
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nimble-2020-08-01/UpdateStudioComponent">REST API Reference for UpdateStudioComponent Operation</seealso>
        IAsyncResult BeginUpdateStudioComponent(UpdateStudioComponentRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateStudioComponent operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateStudioComponent.</param>
        /// 
        /// <returns>Returns a  UpdateStudioComponentResult from NimbleStudio.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nimble-2020-08-01/UpdateStudioComponent">REST API Reference for UpdateStudioComponent Operation</seealso>
        UpdateStudioComponentResponse EndUpdateStudioComponent(IAsyncResult asyncResult);

        #endregion
        
    }
}