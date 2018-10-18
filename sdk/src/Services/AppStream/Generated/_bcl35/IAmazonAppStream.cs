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
 * Do not modify this file. This file is generated from the appstream-2016-12-01.normal.json service model.
 */


using System;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.AppStream.Model;

namespace Amazon.AppStream
{
    /// <summary>
    /// Interface for accessing AppStream
    ///
    /// Amazon AppStream 2.0 
    /// <para>
    /// You can use Amazon AppStream 2.0 to stream desktop applications to any device running
    /// a web browser, without rewriting them.
    /// </para>
    /// </summary>
    public partial interface IAmazonAppStream : IAmazonService, IDisposable
    {

        
        #region  AssociateFleet


        /// <summary>
        /// Associates the specified fleet with the specified stack.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateFleet service method.</param>
        /// 
        /// <returns>The response from the AssociateFleet service method, as returned by AppStream.</returns>
        /// <exception cref="Amazon.AppStream.Model.ConcurrentModificationException">
        /// An API error occurred. Wait a few minutes and try again.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.IncompatibleImageException">
        /// The image does not support storage connectors.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.InvalidAccountStatusException">
        /// The resource cannot be created because your AWS account is suspended. For assistance,
        /// contact AWS Support.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.LimitExceededException">
        /// The requested limit exceeds the permitted limit for an account.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.OperationNotPermittedException">
        /// The attempted operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/AssociateFleet">REST API Reference for AssociateFleet Operation</seealso>
        AssociateFleetResponse AssociateFleet(AssociateFleetRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the AssociateFleet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateFleet operation on AmazonAppStreamClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAssociateFleet
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/AssociateFleet">REST API Reference for AssociateFleet Operation</seealso>
        IAsyncResult BeginAssociateFleet(AssociateFleetRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  AssociateFleet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssociateFleet.</param>
        /// 
        /// <returns>Returns a  AssociateFleetResult from AppStream.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/AssociateFleet">REST API Reference for AssociateFleet Operation</seealso>
        AssociateFleetResponse EndAssociateFleet(IAsyncResult asyncResult);

        #endregion
        
        #region  BatchAssociateUserStack


        /// <summary>
        /// Associates the specified users with the specified stacks. Users in a user pool cannot
        /// be assigned to stacks with fleets that are joined to an Active Directory domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchAssociateUserStack service method.</param>
        /// 
        /// <returns>The response from the BatchAssociateUserStack service method, as returned by AppStream.</returns>
        /// <exception cref="Amazon.AppStream.Model.OperationNotPermittedException">
        /// The attempted operation is not permitted.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/BatchAssociateUserStack">REST API Reference for BatchAssociateUserStack Operation</seealso>
        BatchAssociateUserStackResponse BatchAssociateUserStack(BatchAssociateUserStackRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the BatchAssociateUserStack operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchAssociateUserStack operation on AmazonAppStreamClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchAssociateUserStack
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/BatchAssociateUserStack">REST API Reference for BatchAssociateUserStack Operation</seealso>
        IAsyncResult BeginBatchAssociateUserStack(BatchAssociateUserStackRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  BatchAssociateUserStack operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchAssociateUserStack.</param>
        /// 
        /// <returns>Returns a  BatchAssociateUserStackResult from AppStream.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/BatchAssociateUserStack">REST API Reference for BatchAssociateUserStack Operation</seealso>
        BatchAssociateUserStackResponse EndBatchAssociateUserStack(IAsyncResult asyncResult);

        #endregion
        
        #region  BatchDisassociateUserStack


        /// <summary>
        /// Disassociates the specified users from the specified stacks.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchDisassociateUserStack service method.</param>
        /// 
        /// <returns>The response from the BatchDisassociateUserStack service method, as returned by AppStream.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/BatchDisassociateUserStack">REST API Reference for BatchDisassociateUserStack Operation</seealso>
        BatchDisassociateUserStackResponse BatchDisassociateUserStack(BatchDisassociateUserStackRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the BatchDisassociateUserStack operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchDisassociateUserStack operation on AmazonAppStreamClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchDisassociateUserStack
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/BatchDisassociateUserStack">REST API Reference for BatchDisassociateUserStack Operation</seealso>
        IAsyncResult BeginBatchDisassociateUserStack(BatchDisassociateUserStackRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  BatchDisassociateUserStack operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchDisassociateUserStack.</param>
        /// 
        /// <returns>Returns a  BatchDisassociateUserStackResult from AppStream.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/BatchDisassociateUserStack">REST API Reference for BatchDisassociateUserStack Operation</seealso>
        BatchDisassociateUserStackResponse EndBatchDisassociateUserStack(IAsyncResult asyncResult);

        #endregion
        
        #region  CopyImage


        /// <summary>
        /// Copies the image within the same region or to a new region within the same AWS account.
        /// Note that any tags you added to the image will not be copied.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CopyImage service method.</param>
        /// 
        /// <returns>The response from the CopyImage service method, as returned by AppStream.</returns>
        /// <exception cref="Amazon.AppStream.Model.IncompatibleImageException">
        /// The image does not support storage connectors.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.InvalidAccountStatusException">
        /// The resource cannot be created because your AWS account is suspended. For assistance,
        /// contact AWS Support.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.LimitExceededException">
        /// The requested limit exceeds the permitted limit for an account.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.ResourceAlreadyExistsException">
        /// The specified resource already exists.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.ResourceNotAvailableException">
        /// The specified resource exists and is not in use, but isn't available.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/CopyImage">REST API Reference for CopyImage Operation</seealso>
        CopyImageResponse CopyImage(CopyImageRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CopyImage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CopyImage operation on AmazonAppStreamClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCopyImage
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/CopyImage">REST API Reference for CopyImage Operation</seealso>
        IAsyncResult BeginCopyImage(CopyImageRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CopyImage operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCopyImage.</param>
        /// 
        /// <returns>Returns a  CopyImageResult from AppStream.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/CopyImage">REST API Reference for CopyImage Operation</seealso>
        CopyImageResponse EndCopyImage(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateDirectoryConfig


        /// <summary>
        /// Creates a Directory Config object in AppStream 2.0. This object includes the information
        /// required to join streaming instances to an Active Directory domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDirectoryConfig service method.</param>
        /// 
        /// <returns>The response from the CreateDirectoryConfig service method, as returned by AppStream.</returns>
        /// <exception cref="Amazon.AppStream.Model.InvalidAccountStatusException">
        /// The resource cannot be created because your AWS account is suspended. For assistance,
        /// contact AWS Support.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.LimitExceededException">
        /// The requested limit exceeds the permitted limit for an account.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.ResourceAlreadyExistsException">
        /// The specified resource already exists.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/CreateDirectoryConfig">REST API Reference for CreateDirectoryConfig Operation</seealso>
        CreateDirectoryConfigResponse CreateDirectoryConfig(CreateDirectoryConfigRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateDirectoryConfig operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDirectoryConfig operation on AmazonAppStreamClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateDirectoryConfig
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/CreateDirectoryConfig">REST API Reference for CreateDirectoryConfig Operation</seealso>
        IAsyncResult BeginCreateDirectoryConfig(CreateDirectoryConfigRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateDirectoryConfig operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateDirectoryConfig.</param>
        /// 
        /// <returns>Returns a  CreateDirectoryConfigResult from AppStream.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/CreateDirectoryConfig">REST API Reference for CreateDirectoryConfig Operation</seealso>
        CreateDirectoryConfigResponse EndCreateDirectoryConfig(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateFleet


        /// <summary>
        /// Creates a fleet. A fleet consists of streaming instances that run a specified image.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateFleet service method.</param>
        /// 
        /// <returns>The response from the CreateFleet service method, as returned by AppStream.</returns>
        /// <exception cref="Amazon.AppStream.Model.ConcurrentModificationException">
        /// An API error occurred. Wait a few minutes and try again.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.IncompatibleImageException">
        /// The image does not support storage connectors.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.InvalidAccountStatusException">
        /// The resource cannot be created because your AWS account is suspended. For assistance,
        /// contact AWS Support.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.InvalidParameterCombinationException">
        /// Indicates an incorrect combination of parameters, or a missing parameter.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.InvalidRoleException">
        /// The specified role is invalid.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.LimitExceededException">
        /// The requested limit exceeds the permitted limit for an account.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.OperationNotPermittedException">
        /// The attempted operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.ResourceAlreadyExistsException">
        /// The specified resource already exists.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.ResourceNotAvailableException">
        /// The specified resource exists and is not in use, but isn't available.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/CreateFleet">REST API Reference for CreateFleet Operation</seealso>
        CreateFleetResponse CreateFleet(CreateFleetRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateFleet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateFleet operation on AmazonAppStreamClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateFleet
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/CreateFleet">REST API Reference for CreateFleet Operation</seealso>
        IAsyncResult BeginCreateFleet(CreateFleetRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateFleet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateFleet.</param>
        /// 
        /// <returns>Returns a  CreateFleetResult from AppStream.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/CreateFleet">REST API Reference for CreateFleet Operation</seealso>
        CreateFleetResponse EndCreateFleet(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateImageBuilder


        /// <summary>
        /// Creates an image builder. An image builder is a virtual machine that is used to create
        /// an image.
        /// 
        ///  
        /// <para>
        /// The initial state of the builder is <code>PENDING</code>. When it is ready, the state
        /// is <code>RUNNING</code>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateImageBuilder service method.</param>
        /// 
        /// <returns>The response from the CreateImageBuilder service method, as returned by AppStream.</returns>
        /// <exception cref="Amazon.AppStream.Model.ConcurrentModificationException">
        /// An API error occurred. Wait a few minutes and try again.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.IncompatibleImageException">
        /// The image does not support storage connectors.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.InvalidAccountStatusException">
        /// The resource cannot be created because your AWS account is suspended. For assistance,
        /// contact AWS Support.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.InvalidParameterCombinationException">
        /// Indicates an incorrect combination of parameters, or a missing parameter.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.InvalidRoleException">
        /// The specified role is invalid.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.LimitExceededException">
        /// The requested limit exceeds the permitted limit for an account.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.OperationNotPermittedException">
        /// The attempted operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.ResourceAlreadyExistsException">
        /// The specified resource already exists.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.ResourceNotAvailableException">
        /// The specified resource exists and is not in use, but isn't available.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/CreateImageBuilder">REST API Reference for CreateImageBuilder Operation</seealso>
        CreateImageBuilderResponse CreateImageBuilder(CreateImageBuilderRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateImageBuilder operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateImageBuilder operation on AmazonAppStreamClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateImageBuilder
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/CreateImageBuilder">REST API Reference for CreateImageBuilder Operation</seealso>
        IAsyncResult BeginCreateImageBuilder(CreateImageBuilderRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateImageBuilder operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateImageBuilder.</param>
        /// 
        /// <returns>Returns a  CreateImageBuilderResult from AppStream.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/CreateImageBuilder">REST API Reference for CreateImageBuilder Operation</seealso>
        CreateImageBuilderResponse EndCreateImageBuilder(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateImageBuilderStreamingURL


        /// <summary>
        /// Creates a URL to start an image builder streaming session.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateImageBuilderStreamingURL service method.</param>
        /// 
        /// <returns>The response from the CreateImageBuilderStreamingURL service method, as returned by AppStream.</returns>
        /// <exception cref="Amazon.AppStream.Model.OperationNotPermittedException">
        /// The attempted operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/CreateImageBuilderStreamingURL">REST API Reference for CreateImageBuilderStreamingURL Operation</seealso>
        CreateImageBuilderStreamingURLResponse CreateImageBuilderStreamingURL(CreateImageBuilderStreamingURLRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateImageBuilderStreamingURL operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateImageBuilderStreamingURL operation on AmazonAppStreamClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateImageBuilderStreamingURL
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/CreateImageBuilderStreamingURL">REST API Reference for CreateImageBuilderStreamingURL Operation</seealso>
        IAsyncResult BeginCreateImageBuilderStreamingURL(CreateImageBuilderStreamingURLRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateImageBuilderStreamingURL operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateImageBuilderStreamingURL.</param>
        /// 
        /// <returns>Returns a  CreateImageBuilderStreamingURLResult from AppStream.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/CreateImageBuilderStreamingURL">REST API Reference for CreateImageBuilderStreamingURL Operation</seealso>
        CreateImageBuilderStreamingURLResponse EndCreateImageBuilderStreamingURL(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateStack


        /// <summary>
        /// Creates a stack to start streaming applications to users. A stack consists of an associated
        /// fleet, user access policies, and storage configurations.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateStack service method.</param>
        /// 
        /// <returns>The response from the CreateStack service method, as returned by AppStream.</returns>
        /// <exception cref="Amazon.AppStream.Model.ConcurrentModificationException">
        /// An API error occurred. Wait a few minutes and try again.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.InvalidAccountStatusException">
        /// The resource cannot be created because your AWS account is suspended. For assistance,
        /// contact AWS Support.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.InvalidParameterCombinationException">
        /// Indicates an incorrect combination of parameters, or a missing parameter.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.InvalidRoleException">
        /// The specified role is invalid.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.LimitExceededException">
        /// The requested limit exceeds the permitted limit for an account.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.ResourceAlreadyExistsException">
        /// The specified resource already exists.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/CreateStack">REST API Reference for CreateStack Operation</seealso>
        CreateStackResponse CreateStack(CreateStackRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateStack operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateStack operation on AmazonAppStreamClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateStack
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/CreateStack">REST API Reference for CreateStack Operation</seealso>
        IAsyncResult BeginCreateStack(CreateStackRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateStack operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateStack.</param>
        /// 
        /// <returns>Returns a  CreateStackResult from AppStream.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/CreateStack">REST API Reference for CreateStack Operation</seealso>
        CreateStackResponse EndCreateStack(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateStreamingURL


        /// <summary>
        /// Creates a temporary URL to start an AppStream 2.0 streaming session for the specified
        /// user. A streaming URL enables application streaming to be tested without user setup.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateStreamingURL service method.</param>
        /// 
        /// <returns>The response from the CreateStreamingURL service method, as returned by AppStream.</returns>
        /// <exception cref="Amazon.AppStream.Model.InvalidParameterCombinationException">
        /// Indicates an incorrect combination of parameters, or a missing parameter.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.OperationNotPermittedException">
        /// The attempted operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.ResourceNotAvailableException">
        /// The specified resource exists and is not in use, but isn't available.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/CreateStreamingURL">REST API Reference for CreateStreamingURL Operation</seealso>
        CreateStreamingURLResponse CreateStreamingURL(CreateStreamingURLRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateStreamingURL operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateStreamingURL operation on AmazonAppStreamClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateStreamingURL
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/CreateStreamingURL">REST API Reference for CreateStreamingURL Operation</seealso>
        IAsyncResult BeginCreateStreamingURL(CreateStreamingURLRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateStreamingURL operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateStreamingURL.</param>
        /// 
        /// <returns>Returns a  CreateStreamingURLResult from AppStream.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/CreateStreamingURL">REST API Reference for CreateStreamingURL Operation</seealso>
        CreateStreamingURLResponse EndCreateStreamingURL(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateUser


        /// <summary>
        /// Creates a new user in the user pool.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateUser service method.</param>
        /// 
        /// <returns>The response from the CreateUser service method, as returned by AppStream.</returns>
        /// <exception cref="Amazon.AppStream.Model.InvalidAccountStatusException">
        /// The resource cannot be created because your AWS account is suspended. For assistance,
        /// contact AWS Support.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.InvalidParameterCombinationException">
        /// Indicates an incorrect combination of parameters, or a missing parameter.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.LimitExceededException">
        /// The requested limit exceeds the permitted limit for an account.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.OperationNotPermittedException">
        /// The attempted operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.ResourceAlreadyExistsException">
        /// The specified resource already exists.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/CreateUser">REST API Reference for CreateUser Operation</seealso>
        CreateUserResponse CreateUser(CreateUserRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateUser operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateUser operation on AmazonAppStreamClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateUser
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/CreateUser">REST API Reference for CreateUser Operation</seealso>
        IAsyncResult BeginCreateUser(CreateUserRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateUser operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateUser.</param>
        /// 
        /// <returns>Returns a  CreateUserResult from AppStream.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/CreateUser">REST API Reference for CreateUser Operation</seealso>
        CreateUserResponse EndCreateUser(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteDirectoryConfig


        /// <summary>
        /// Deletes the specified Directory Config object from AppStream 2.0. This object includes
        /// the information required to join streaming instances to an Active Directory domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDirectoryConfig service method.</param>
        /// 
        /// <returns>The response from the DeleteDirectoryConfig service method, as returned by AppStream.</returns>
        /// <exception cref="Amazon.AppStream.Model.ResourceInUseException">
        /// The specified resource is in use.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/DeleteDirectoryConfig">REST API Reference for DeleteDirectoryConfig Operation</seealso>
        DeleteDirectoryConfigResponse DeleteDirectoryConfig(DeleteDirectoryConfigRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDirectoryConfig operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDirectoryConfig operation on AmazonAppStreamClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteDirectoryConfig
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/DeleteDirectoryConfig">REST API Reference for DeleteDirectoryConfig Operation</seealso>
        IAsyncResult BeginDeleteDirectoryConfig(DeleteDirectoryConfigRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteDirectoryConfig operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteDirectoryConfig.</param>
        /// 
        /// <returns>Returns a  DeleteDirectoryConfigResult from AppStream.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/DeleteDirectoryConfig">REST API Reference for DeleteDirectoryConfig Operation</seealso>
        DeleteDirectoryConfigResponse EndDeleteDirectoryConfig(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteFleet


        /// <summary>
        /// Deletes the specified fleet.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteFleet service method.</param>
        /// 
        /// <returns>The response from the DeleteFleet service method, as returned by AppStream.</returns>
        /// <exception cref="Amazon.AppStream.Model.ConcurrentModificationException">
        /// An API error occurred. Wait a few minutes and try again.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.ResourceInUseException">
        /// The specified resource is in use.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/DeleteFleet">REST API Reference for DeleteFleet Operation</seealso>
        DeleteFleetResponse DeleteFleet(DeleteFleetRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteFleet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteFleet operation on AmazonAppStreamClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteFleet
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/DeleteFleet">REST API Reference for DeleteFleet Operation</seealso>
        IAsyncResult BeginDeleteFleet(DeleteFleetRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteFleet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteFleet.</param>
        /// 
        /// <returns>Returns a  DeleteFleetResult from AppStream.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/DeleteFleet">REST API Reference for DeleteFleet Operation</seealso>
        DeleteFleetResponse EndDeleteFleet(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteImage


        /// <summary>
        /// Deletes the specified image. You cannot delete an image when it is in use. After you
        /// delete an image, you cannot provision new capacity using the image.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteImage service method.</param>
        /// 
        /// <returns>The response from the DeleteImage service method, as returned by AppStream.</returns>
        /// <exception cref="Amazon.AppStream.Model.ConcurrentModificationException">
        /// An API error occurred. Wait a few minutes and try again.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.OperationNotPermittedException">
        /// The attempted operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.ResourceInUseException">
        /// The specified resource is in use.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/DeleteImage">REST API Reference for DeleteImage Operation</seealso>
        DeleteImageResponse DeleteImage(DeleteImageRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteImage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteImage operation on AmazonAppStreamClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteImage
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/DeleteImage">REST API Reference for DeleteImage Operation</seealso>
        IAsyncResult BeginDeleteImage(DeleteImageRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteImage operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteImage.</param>
        /// 
        /// <returns>Returns a  DeleteImageResult from AppStream.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/DeleteImage">REST API Reference for DeleteImage Operation</seealso>
        DeleteImageResponse EndDeleteImage(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteImageBuilder


        /// <summary>
        /// Deletes the specified image builder and releases the capacity.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteImageBuilder service method.</param>
        /// 
        /// <returns>The response from the DeleteImageBuilder service method, as returned by AppStream.</returns>
        /// <exception cref="Amazon.AppStream.Model.ConcurrentModificationException">
        /// An API error occurred. Wait a few minutes and try again.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.OperationNotPermittedException">
        /// The attempted operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/DeleteImageBuilder">REST API Reference for DeleteImageBuilder Operation</seealso>
        DeleteImageBuilderResponse DeleteImageBuilder(DeleteImageBuilderRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteImageBuilder operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteImageBuilder operation on AmazonAppStreamClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteImageBuilder
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/DeleteImageBuilder">REST API Reference for DeleteImageBuilder Operation</seealso>
        IAsyncResult BeginDeleteImageBuilder(DeleteImageBuilderRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteImageBuilder operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteImageBuilder.</param>
        /// 
        /// <returns>Returns a  DeleteImageBuilderResult from AppStream.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/DeleteImageBuilder">REST API Reference for DeleteImageBuilder Operation</seealso>
        DeleteImageBuilderResponse EndDeleteImageBuilder(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteImagePermissions


        /// <summary>
        /// Deletes permissions for the specified private image. After you delete permissions
        /// for an image, AWS accounts to which you previously granted these permissions can no
        /// longer use the image.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteImagePermissions service method.</param>
        /// 
        /// <returns>The response from the DeleteImagePermissions service method, as returned by AppStream.</returns>
        /// <exception cref="Amazon.AppStream.Model.ResourceNotAvailableException">
        /// The specified resource exists and is not in use, but isn't available.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/DeleteImagePermissions">REST API Reference for DeleteImagePermissions Operation</seealso>
        DeleteImagePermissionsResponse DeleteImagePermissions(DeleteImagePermissionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteImagePermissions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteImagePermissions operation on AmazonAppStreamClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteImagePermissions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/DeleteImagePermissions">REST API Reference for DeleteImagePermissions Operation</seealso>
        IAsyncResult BeginDeleteImagePermissions(DeleteImagePermissionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteImagePermissions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteImagePermissions.</param>
        /// 
        /// <returns>Returns a  DeleteImagePermissionsResult from AppStream.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/DeleteImagePermissions">REST API Reference for DeleteImagePermissions Operation</seealso>
        DeleteImagePermissionsResponse EndDeleteImagePermissions(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteStack


        /// <summary>
        /// Deletes the specified stack. After the stack is deleted, the application streaming
        /// environment provided by the stack is no longer available to users. Also, any reservations
        /// made for application streaming sessions for the stack are released.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteStack service method.</param>
        /// 
        /// <returns>The response from the DeleteStack service method, as returned by AppStream.</returns>
        /// <exception cref="Amazon.AppStream.Model.ConcurrentModificationException">
        /// An API error occurred. Wait a few minutes and try again.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.ResourceInUseException">
        /// The specified resource is in use.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/DeleteStack">REST API Reference for DeleteStack Operation</seealso>
        DeleteStackResponse DeleteStack(DeleteStackRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteStack operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteStack operation on AmazonAppStreamClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteStack
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/DeleteStack">REST API Reference for DeleteStack Operation</seealso>
        IAsyncResult BeginDeleteStack(DeleteStackRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteStack operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteStack.</param>
        /// 
        /// <returns>Returns a  DeleteStackResult from AppStream.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/DeleteStack">REST API Reference for DeleteStack Operation</seealso>
        DeleteStackResponse EndDeleteStack(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteUser


        /// <summary>
        /// Deletes a user from the user pool.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteUser service method.</param>
        /// 
        /// <returns>The response from the DeleteUser service method, as returned by AppStream.</returns>
        /// <exception cref="Amazon.AppStream.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/DeleteUser">REST API Reference for DeleteUser Operation</seealso>
        DeleteUserResponse DeleteUser(DeleteUserRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteUser operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteUser operation on AmazonAppStreamClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteUser
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/DeleteUser">REST API Reference for DeleteUser Operation</seealso>
        IAsyncResult BeginDeleteUser(DeleteUserRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteUser operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteUser.</param>
        /// 
        /// <returns>Returns a  DeleteUserResult from AppStream.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/DeleteUser">REST API Reference for DeleteUser Operation</seealso>
        DeleteUserResponse EndDeleteUser(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeDirectoryConfigs


        /// <summary>
        /// Retrieves a list that describes one or more specified Directory Config objects for
        /// AppStream 2.0, if the names for these objects are provided. Otherwise, all Directory
        /// Config objects in the account are described. These objects include the information
        /// required to join streaming instances to an Active Directory domain. 
        /// 
        ///  
        /// <para>
        /// Although the response syntax in this topic includes the account password, this password
        /// is not returned in the actual response.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDirectoryConfigs service method.</param>
        /// 
        /// <returns>The response from the DescribeDirectoryConfigs service method, as returned by AppStream.</returns>
        /// <exception cref="Amazon.AppStream.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/DescribeDirectoryConfigs">REST API Reference for DescribeDirectoryConfigs Operation</seealso>
        DescribeDirectoryConfigsResponse DescribeDirectoryConfigs(DescribeDirectoryConfigsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDirectoryConfigs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDirectoryConfigs operation on AmazonAppStreamClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeDirectoryConfigs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/DescribeDirectoryConfigs">REST API Reference for DescribeDirectoryConfigs Operation</seealso>
        IAsyncResult BeginDescribeDirectoryConfigs(DescribeDirectoryConfigsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeDirectoryConfigs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeDirectoryConfigs.</param>
        /// 
        /// <returns>Returns a  DescribeDirectoryConfigsResult from AppStream.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/DescribeDirectoryConfigs">REST API Reference for DescribeDirectoryConfigs Operation</seealso>
        DescribeDirectoryConfigsResponse EndDescribeDirectoryConfigs(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeFleets


        /// <summary>
        /// Retrieves a list that describes one or more specified fleets, if the fleet names are
        /// provided. Otherwise, all fleets in the account are described.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeFleets service method.</param>
        /// 
        /// <returns>The response from the DescribeFleets service method, as returned by AppStream.</returns>
        /// <exception cref="Amazon.AppStream.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/DescribeFleets">REST API Reference for DescribeFleets Operation</seealso>
        DescribeFleetsResponse DescribeFleets(DescribeFleetsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeFleets operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeFleets operation on AmazonAppStreamClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeFleets
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/DescribeFleets">REST API Reference for DescribeFleets Operation</seealso>
        IAsyncResult BeginDescribeFleets(DescribeFleetsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeFleets operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeFleets.</param>
        /// 
        /// <returns>Returns a  DescribeFleetsResult from AppStream.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/DescribeFleets">REST API Reference for DescribeFleets Operation</seealso>
        DescribeFleetsResponse EndDescribeFleets(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeImageBuilders


        /// <summary>
        /// Retrieves a list that describes one or more specified image builders, if the image
        /// builder names are provided. Otherwise, all image builders in the account are described.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeImageBuilders service method.</param>
        /// 
        /// <returns>The response from the DescribeImageBuilders service method, as returned by AppStream.</returns>
        /// <exception cref="Amazon.AppStream.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/DescribeImageBuilders">REST API Reference for DescribeImageBuilders Operation</seealso>
        DescribeImageBuildersResponse DescribeImageBuilders(DescribeImageBuildersRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeImageBuilders operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeImageBuilders operation on AmazonAppStreamClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeImageBuilders
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/DescribeImageBuilders">REST API Reference for DescribeImageBuilders Operation</seealso>
        IAsyncResult BeginDescribeImageBuilders(DescribeImageBuildersRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeImageBuilders operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeImageBuilders.</param>
        /// 
        /// <returns>Returns a  DescribeImageBuildersResult from AppStream.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/DescribeImageBuilders">REST API Reference for DescribeImageBuilders Operation</seealso>
        DescribeImageBuildersResponse EndDescribeImageBuilders(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeImagePermissions


        /// <summary>
        /// Retrieves a list that describes the permissions for shared AWS account IDs on a private
        /// image that you own.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeImagePermissions service method.</param>
        /// 
        /// <returns>The response from the DescribeImagePermissions service method, as returned by AppStream.</returns>
        /// <exception cref="Amazon.AppStream.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/DescribeImagePermissions">REST API Reference for DescribeImagePermissions Operation</seealso>
        DescribeImagePermissionsResponse DescribeImagePermissions(DescribeImagePermissionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeImagePermissions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeImagePermissions operation on AmazonAppStreamClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeImagePermissions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/DescribeImagePermissions">REST API Reference for DescribeImagePermissions Operation</seealso>
        IAsyncResult BeginDescribeImagePermissions(DescribeImagePermissionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeImagePermissions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeImagePermissions.</param>
        /// 
        /// <returns>Returns a  DescribeImagePermissionsResult from AppStream.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/DescribeImagePermissions">REST API Reference for DescribeImagePermissions Operation</seealso>
        DescribeImagePermissionsResponse EndDescribeImagePermissions(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeImages


        /// <summary>
        /// Retrieves a list that describes one or more specified images, if the image names or
        /// image ARNs are provided. Otherwise, all images in the account are described.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeImages service method.</param>
        /// 
        /// <returns>The response from the DescribeImages service method, as returned by AppStream.</returns>
        /// <exception cref="Amazon.AppStream.Model.InvalidParameterCombinationException">
        /// Indicates an incorrect combination of parameters, or a missing parameter.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/DescribeImages">REST API Reference for DescribeImages Operation</seealso>
        DescribeImagesResponse DescribeImages(DescribeImagesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeImages operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeImages operation on AmazonAppStreamClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeImages
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/DescribeImages">REST API Reference for DescribeImages Operation</seealso>
        IAsyncResult BeginDescribeImages(DescribeImagesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeImages operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeImages.</param>
        /// 
        /// <returns>Returns a  DescribeImagesResult from AppStream.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/DescribeImages">REST API Reference for DescribeImages Operation</seealso>
        DescribeImagesResponse EndDescribeImages(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeSessions


        /// <summary>
        /// Retrieves a list that describes the streaming sessions for a specified stack and fleet.
        /// If a user ID is provided for the stack and fleet, only streaming sessions for that
        /// user are described. If an authentication type is not provided, the default is to authenticate
        /// users using a streaming URL.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSessions service method.</param>
        /// 
        /// <returns>The response from the DescribeSessions service method, as returned by AppStream.</returns>
        /// <exception cref="Amazon.AppStream.Model.InvalidParameterCombinationException">
        /// Indicates an incorrect combination of parameters, or a missing parameter.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/DescribeSessions">REST API Reference for DescribeSessions Operation</seealso>
        DescribeSessionsResponse DescribeSessions(DescribeSessionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeSessions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeSessions operation on AmazonAppStreamClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeSessions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/DescribeSessions">REST API Reference for DescribeSessions Operation</seealso>
        IAsyncResult BeginDescribeSessions(DescribeSessionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeSessions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeSessions.</param>
        /// 
        /// <returns>Returns a  DescribeSessionsResult from AppStream.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/DescribeSessions">REST API Reference for DescribeSessions Operation</seealso>
        DescribeSessionsResponse EndDescribeSessions(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeStacks


        /// <summary>
        /// Retrieves a list that describes one or more specified stacks, if the stack names are
        /// provided. Otherwise, all stacks in the account are described.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeStacks service method.</param>
        /// 
        /// <returns>The response from the DescribeStacks service method, as returned by AppStream.</returns>
        /// <exception cref="Amazon.AppStream.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/DescribeStacks">REST API Reference for DescribeStacks Operation</seealso>
        DescribeStacksResponse DescribeStacks(DescribeStacksRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeStacks operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeStacks operation on AmazonAppStreamClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeStacks
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/DescribeStacks">REST API Reference for DescribeStacks Operation</seealso>
        IAsyncResult BeginDescribeStacks(DescribeStacksRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeStacks operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeStacks.</param>
        /// 
        /// <returns>Returns a  DescribeStacksResult from AppStream.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/DescribeStacks">REST API Reference for DescribeStacks Operation</seealso>
        DescribeStacksResponse EndDescribeStacks(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeUsers


        /// <summary>
        /// Retrieves a list that describes one or more specified users in the user pool, if user
        /// names are provided. Otherwise, all users in the user pool are described.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeUsers service method.</param>
        /// 
        /// <returns>The response from the DescribeUsers service method, as returned by AppStream.</returns>
        /// <exception cref="Amazon.AppStream.Model.InvalidParameterCombinationException">
        /// Indicates an incorrect combination of parameters, or a missing parameter.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/DescribeUsers">REST API Reference for DescribeUsers Operation</seealso>
        DescribeUsersResponse DescribeUsers(DescribeUsersRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeUsers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeUsers operation on AmazonAppStreamClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeUsers
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/DescribeUsers">REST API Reference for DescribeUsers Operation</seealso>
        IAsyncResult BeginDescribeUsers(DescribeUsersRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeUsers operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeUsers.</param>
        /// 
        /// <returns>Returns a  DescribeUsersResult from AppStream.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/DescribeUsers">REST API Reference for DescribeUsers Operation</seealso>
        DescribeUsersResponse EndDescribeUsers(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeUserStackAssociations


        /// <summary>
        /// Retrieves a list that describes the UserStackAssociation objects. You must specify
        /// either or both of the following:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// The stack name
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The user name (email address of the user associated with the stack) and the authentication
        /// type for the user
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeUserStackAssociations service method.</param>
        /// 
        /// <returns>The response from the DescribeUserStackAssociations service method, as returned by AppStream.</returns>
        /// <exception cref="Amazon.AppStream.Model.InvalidParameterCombinationException">
        /// Indicates an incorrect combination of parameters, or a missing parameter.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/DescribeUserStackAssociations">REST API Reference for DescribeUserStackAssociations Operation</seealso>
        DescribeUserStackAssociationsResponse DescribeUserStackAssociations(DescribeUserStackAssociationsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeUserStackAssociations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeUserStackAssociations operation on AmazonAppStreamClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeUserStackAssociations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/DescribeUserStackAssociations">REST API Reference for DescribeUserStackAssociations Operation</seealso>
        IAsyncResult BeginDescribeUserStackAssociations(DescribeUserStackAssociationsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeUserStackAssociations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeUserStackAssociations.</param>
        /// 
        /// <returns>Returns a  DescribeUserStackAssociationsResult from AppStream.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/DescribeUserStackAssociations">REST API Reference for DescribeUserStackAssociations Operation</seealso>
        DescribeUserStackAssociationsResponse EndDescribeUserStackAssociations(IAsyncResult asyncResult);

        #endregion
        
        #region  DisableUser


        /// <summary>
        /// Disables the specified user in the user pool. Users can't sign in to AppStream 2.0
        /// until they are re-enabled. This action does not delete the user.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisableUser service method.</param>
        /// 
        /// <returns>The response from the DisableUser service method, as returned by AppStream.</returns>
        /// <exception cref="Amazon.AppStream.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/DisableUser">REST API Reference for DisableUser Operation</seealso>
        DisableUserResponse DisableUser(DisableUserRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DisableUser operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisableUser operation on AmazonAppStreamClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisableUser
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/DisableUser">REST API Reference for DisableUser Operation</seealso>
        IAsyncResult BeginDisableUser(DisableUserRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DisableUser operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisableUser.</param>
        /// 
        /// <returns>Returns a  DisableUserResult from AppStream.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/DisableUser">REST API Reference for DisableUser Operation</seealso>
        DisableUserResponse EndDisableUser(IAsyncResult asyncResult);

        #endregion
        
        #region  DisassociateFleet


        /// <summary>
        /// Disassociates the specified fleet from the specified stack.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateFleet service method.</param>
        /// 
        /// <returns>The response from the DisassociateFleet service method, as returned by AppStream.</returns>
        /// <exception cref="Amazon.AppStream.Model.ConcurrentModificationException">
        /// An API error occurred. Wait a few minutes and try again.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.ResourceInUseException">
        /// The specified resource is in use.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/DisassociateFleet">REST API Reference for DisassociateFleet Operation</seealso>
        DisassociateFleetResponse DisassociateFleet(DisassociateFleetRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateFleet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateFleet operation on AmazonAppStreamClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisassociateFleet
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/DisassociateFleet">REST API Reference for DisassociateFleet Operation</seealso>
        IAsyncResult BeginDisassociateFleet(DisassociateFleetRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DisassociateFleet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisassociateFleet.</param>
        /// 
        /// <returns>Returns a  DisassociateFleetResult from AppStream.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/DisassociateFleet">REST API Reference for DisassociateFleet Operation</seealso>
        DisassociateFleetResponse EndDisassociateFleet(IAsyncResult asyncResult);

        #endregion
        
        #region  EnableUser


        /// <summary>
        /// Enables a user in the user pool. After being enabled, users can sign in to AppStream
        /// 2.0 and open applications from the stacks to which they are assigned.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EnableUser service method.</param>
        /// 
        /// <returns>The response from the EnableUser service method, as returned by AppStream.</returns>
        /// <exception cref="Amazon.AppStream.Model.InvalidAccountStatusException">
        /// The resource cannot be created because your AWS account is suspended. For assistance,
        /// contact AWS Support.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/EnableUser">REST API Reference for EnableUser Operation</seealso>
        EnableUserResponse EnableUser(EnableUserRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the EnableUser operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the EnableUser operation on AmazonAppStreamClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndEnableUser
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/EnableUser">REST API Reference for EnableUser Operation</seealso>
        IAsyncResult BeginEnableUser(EnableUserRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  EnableUser operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginEnableUser.</param>
        /// 
        /// <returns>Returns a  EnableUserResult from AppStream.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/EnableUser">REST API Reference for EnableUser Operation</seealso>
        EnableUserResponse EndEnableUser(IAsyncResult asyncResult);

        #endregion
        
        #region  ExpireSession


        /// <summary>
        /// Immediately stops the specified streaming session.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ExpireSession service method.</param>
        /// 
        /// <returns>The response from the ExpireSession service method, as returned by AppStream.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/ExpireSession">REST API Reference for ExpireSession Operation</seealso>
        ExpireSessionResponse ExpireSession(ExpireSessionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ExpireSession operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ExpireSession operation on AmazonAppStreamClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndExpireSession
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/ExpireSession">REST API Reference for ExpireSession Operation</seealso>
        IAsyncResult BeginExpireSession(ExpireSessionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ExpireSession operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginExpireSession.</param>
        /// 
        /// <returns>Returns a  ExpireSessionResult from AppStream.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/ExpireSession">REST API Reference for ExpireSession Operation</seealso>
        ExpireSessionResponse EndExpireSession(IAsyncResult asyncResult);

        #endregion
        
        #region  ListAssociatedFleets


        /// <summary>
        /// Retrieves the name of the fleet that is associated with the specified stack.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAssociatedFleets service method.</param>
        /// 
        /// <returns>The response from the ListAssociatedFleets service method, as returned by AppStream.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/ListAssociatedFleets">REST API Reference for ListAssociatedFleets Operation</seealso>
        ListAssociatedFleetsResponse ListAssociatedFleets(ListAssociatedFleetsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListAssociatedFleets operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAssociatedFleets operation on AmazonAppStreamClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAssociatedFleets
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/ListAssociatedFleets">REST API Reference for ListAssociatedFleets Operation</seealso>
        IAsyncResult BeginListAssociatedFleets(ListAssociatedFleetsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListAssociatedFleets operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAssociatedFleets.</param>
        /// 
        /// <returns>Returns a  ListAssociatedFleetsResult from AppStream.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/ListAssociatedFleets">REST API Reference for ListAssociatedFleets Operation</seealso>
        ListAssociatedFleetsResponse EndListAssociatedFleets(IAsyncResult asyncResult);

        #endregion
        
        #region  ListAssociatedStacks


        /// <summary>
        /// Retrieves the name of the stack with which the specified fleet is associated.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAssociatedStacks service method.</param>
        /// 
        /// <returns>The response from the ListAssociatedStacks service method, as returned by AppStream.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/ListAssociatedStacks">REST API Reference for ListAssociatedStacks Operation</seealso>
        ListAssociatedStacksResponse ListAssociatedStacks(ListAssociatedStacksRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListAssociatedStacks operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAssociatedStacks operation on AmazonAppStreamClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAssociatedStacks
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/ListAssociatedStacks">REST API Reference for ListAssociatedStacks Operation</seealso>
        IAsyncResult BeginListAssociatedStacks(ListAssociatedStacksRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListAssociatedStacks operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAssociatedStacks.</param>
        /// 
        /// <returns>Returns a  ListAssociatedStacksResult from AppStream.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/ListAssociatedStacks">REST API Reference for ListAssociatedStacks Operation</seealso>
        ListAssociatedStacksResponse EndListAssociatedStacks(IAsyncResult asyncResult);

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// Retrieves a list of all tags for the specified AppStream 2.0 resource. You can tag
        /// AppStream 2.0 image builders, images, fleets, and stacks.
        /// 
        ///  
        /// <para>
        /// For more information about tags, see <a href="http://docs.aws.amazon.com/appstream2/latest/developerguide/tagging-basic.html">Tagging
        /// Your Resources</a> in the <i>Amazon AppStream 2.0 Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by AppStream.</returns>
        /// <exception cref="Amazon.AppStream.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonAppStreamClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        IAsyncResult BeginListTagsForResource(ListTagsForResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTagsForResource.</param>
        /// 
        /// <returns>Returns a  ListTagsForResourceResult from AppStream.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult);

        #endregion
        
        #region  StartFleet


        /// <summary>
        /// Starts the specified fleet.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartFleet service method.</param>
        /// 
        /// <returns>The response from the StartFleet service method, as returned by AppStream.</returns>
        /// <exception cref="Amazon.AppStream.Model.ConcurrentModificationException">
        /// An API error occurred. Wait a few minutes and try again.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.InvalidAccountStatusException">
        /// The resource cannot be created because your AWS account is suspended. For assistance,
        /// contact AWS Support.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.LimitExceededException">
        /// The requested limit exceeds the permitted limit for an account.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.OperationNotPermittedException">
        /// The attempted operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/StartFleet">REST API Reference for StartFleet Operation</seealso>
        StartFleetResponse StartFleet(StartFleetRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the StartFleet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartFleet operation on AmazonAppStreamClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartFleet
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/StartFleet">REST API Reference for StartFleet Operation</seealso>
        IAsyncResult BeginStartFleet(StartFleetRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StartFleet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartFleet.</param>
        /// 
        /// <returns>Returns a  StartFleetResult from AppStream.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/StartFleet">REST API Reference for StartFleet Operation</seealso>
        StartFleetResponse EndStartFleet(IAsyncResult asyncResult);

        #endregion
        
        #region  StartImageBuilder


        /// <summary>
        /// Starts the specified image builder.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartImageBuilder service method.</param>
        /// 
        /// <returns>The response from the StartImageBuilder service method, as returned by AppStream.</returns>
        /// <exception cref="Amazon.AppStream.Model.ConcurrentModificationException">
        /// An API error occurred. Wait a few minutes and try again.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.IncompatibleImageException">
        /// The image does not support storage connectors.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.InvalidAccountStatusException">
        /// The resource cannot be created because your AWS account is suspended. For assistance,
        /// contact AWS Support.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.ResourceNotAvailableException">
        /// The specified resource exists and is not in use, but isn't available.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/StartImageBuilder">REST API Reference for StartImageBuilder Operation</seealso>
        StartImageBuilderResponse StartImageBuilder(StartImageBuilderRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the StartImageBuilder operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartImageBuilder operation on AmazonAppStreamClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartImageBuilder
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/StartImageBuilder">REST API Reference for StartImageBuilder Operation</seealso>
        IAsyncResult BeginStartImageBuilder(StartImageBuilderRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StartImageBuilder operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartImageBuilder.</param>
        /// 
        /// <returns>Returns a  StartImageBuilderResult from AppStream.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/StartImageBuilder">REST API Reference for StartImageBuilder Operation</seealso>
        StartImageBuilderResponse EndStartImageBuilder(IAsyncResult asyncResult);

        #endregion
        
        #region  StopFleet


        /// <summary>
        /// Stops the specified fleet.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopFleet service method.</param>
        /// 
        /// <returns>The response from the StopFleet service method, as returned by AppStream.</returns>
        /// <exception cref="Amazon.AppStream.Model.ConcurrentModificationException">
        /// An API error occurred. Wait a few minutes and try again.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/StopFleet">REST API Reference for StopFleet Operation</seealso>
        StopFleetResponse StopFleet(StopFleetRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the StopFleet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopFleet operation on AmazonAppStreamClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStopFleet
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/StopFleet">REST API Reference for StopFleet Operation</seealso>
        IAsyncResult BeginStopFleet(StopFleetRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StopFleet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStopFleet.</param>
        /// 
        /// <returns>Returns a  StopFleetResult from AppStream.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/StopFleet">REST API Reference for StopFleet Operation</seealso>
        StopFleetResponse EndStopFleet(IAsyncResult asyncResult);

        #endregion
        
        #region  StopImageBuilder


        /// <summary>
        /// Stops the specified image builder.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopImageBuilder service method.</param>
        /// 
        /// <returns>The response from the StopImageBuilder service method, as returned by AppStream.</returns>
        /// <exception cref="Amazon.AppStream.Model.ConcurrentModificationException">
        /// An API error occurred. Wait a few minutes and try again.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.OperationNotPermittedException">
        /// The attempted operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/StopImageBuilder">REST API Reference for StopImageBuilder Operation</seealso>
        StopImageBuilderResponse StopImageBuilder(StopImageBuilderRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the StopImageBuilder operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopImageBuilder operation on AmazonAppStreamClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStopImageBuilder
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/StopImageBuilder">REST API Reference for StopImageBuilder Operation</seealso>
        IAsyncResult BeginStopImageBuilder(StopImageBuilderRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StopImageBuilder operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStopImageBuilder.</param>
        /// 
        /// <returns>Returns a  StopImageBuilderResult from AppStream.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/StopImageBuilder">REST API Reference for StopImageBuilder Operation</seealso>
        StopImageBuilderResponse EndStopImageBuilder(IAsyncResult asyncResult);

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Adds or overwrites one or more tags for the specified AppStream 2.0 resource. You
        /// can tag AppStream 2.0 image builders, images, fleets, and stacks.
        /// 
        ///  
        /// <para>
        /// Each tag consists of a key and an optional value. If a resource already has a tag
        /// with the same key, this operation updates its value.
        /// </para>
        ///  
        /// <para>
        /// To list the current tags for your resources, use <a>ListTagsForResource</a>. To disassociate
        /// tags from your resources, use <a>UntagResource</a>.
        /// </para>
        ///  
        /// <para>
        /// For more information about tags, see <a href="http://docs.aws.amazon.com/appstream2/latest/developerguide/tagging-basic.html">Tagging
        /// Your Resources</a> in the <i>Amazon AppStream 2.0 Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by AppStream.</returns>
        /// <exception cref="Amazon.AppStream.Model.InvalidAccountStatusException">
        /// The resource cannot be created because your AWS account is suspended. For assistance,
        /// contact AWS Support.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.LimitExceededException">
        /// The requested limit exceeds the permitted limit for an account.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse TagResource(TagResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the TagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonAppStreamClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/TagResource">REST API Reference for TagResource Operation</seealso>
        IAsyncResult BeginTagResource(TagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  TagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTagResource.</param>
        /// 
        /// <returns>Returns a  TagResourceResult from AppStream.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse EndTagResource(IAsyncResult asyncResult);

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// Disassociates one or more specified tags from the specified AppStream 2.0 resource.
        /// 
        ///  
        /// <para>
        /// To list the current tags for your resources, use <a>ListTagsForResource</a>.
        /// </para>
        ///  
        /// <para>
        /// For more information about tags, see <a href="http://docs.aws.amazon.com/appstream2/latest/developerguide/tagging-basic.html">Tagging
        /// Your Resources</a> in the <i>Amazon AppStream 2.0 Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by AppStream.</returns>
        /// <exception cref="Amazon.AppStream.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse UntagResource(UntagResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UntagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonAppStreamClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/UntagResource">REST API Reference for UntagResource Operation</seealso>
        IAsyncResult BeginUntagResource(UntagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UntagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUntagResource.</param>
        /// 
        /// <returns>Returns a  UntagResourceResult from AppStream.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse EndUntagResource(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateDirectoryConfig


        /// <summary>
        /// Updates the specified Directory Config object in AppStream 2.0. This object includes
        /// the information required to join streaming instances to an Active Directory domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDirectoryConfig service method.</param>
        /// 
        /// <returns>The response from the UpdateDirectoryConfig service method, as returned by AppStream.</returns>
        /// <exception cref="Amazon.AppStream.Model.ConcurrentModificationException">
        /// An API error occurred. Wait a few minutes and try again.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.ResourceInUseException">
        /// The specified resource is in use.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/UpdateDirectoryConfig">REST API Reference for UpdateDirectoryConfig Operation</seealso>
        UpdateDirectoryConfigResponse UpdateDirectoryConfig(UpdateDirectoryConfigRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateDirectoryConfig operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateDirectoryConfig operation on AmazonAppStreamClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateDirectoryConfig
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/UpdateDirectoryConfig">REST API Reference for UpdateDirectoryConfig Operation</seealso>
        IAsyncResult BeginUpdateDirectoryConfig(UpdateDirectoryConfigRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateDirectoryConfig operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateDirectoryConfig.</param>
        /// 
        /// <returns>Returns a  UpdateDirectoryConfigResult from AppStream.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/UpdateDirectoryConfig">REST API Reference for UpdateDirectoryConfig Operation</seealso>
        UpdateDirectoryConfigResponse EndUpdateDirectoryConfig(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateFleet


        /// <summary>
        /// Updates the specified fleet.
        /// 
        ///  
        /// <para>
        /// If the fleet is in the <code>STOPPED</code> state, you can update any attribute except
        /// the fleet name. If the fleet is in the <code>RUNNING</code> state, you can update
        /// the <code>DisplayName</code> and <code>ComputeCapacity</code> attributes. If the fleet
        /// is in the <code>STARTING</code> or <code>STOPPING</code> state, you can't update it.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateFleet service method.</param>
        /// 
        /// <returns>The response from the UpdateFleet service method, as returned by AppStream.</returns>
        /// <exception cref="Amazon.AppStream.Model.ConcurrentModificationException">
        /// An API error occurred. Wait a few minutes and try again.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.IncompatibleImageException">
        /// The image does not support storage connectors.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.InvalidAccountStatusException">
        /// The resource cannot be created because your AWS account is suspended. For assistance,
        /// contact AWS Support.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.InvalidParameterCombinationException">
        /// Indicates an incorrect combination of parameters, or a missing parameter.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.InvalidRoleException">
        /// The specified role is invalid.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.LimitExceededException">
        /// The requested limit exceeds the permitted limit for an account.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.OperationNotPermittedException">
        /// The attempted operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.ResourceInUseException">
        /// The specified resource is in use.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.ResourceNotAvailableException">
        /// The specified resource exists and is not in use, but isn't available.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/UpdateFleet">REST API Reference for UpdateFleet Operation</seealso>
        UpdateFleetResponse UpdateFleet(UpdateFleetRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateFleet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateFleet operation on AmazonAppStreamClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateFleet
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/UpdateFleet">REST API Reference for UpdateFleet Operation</seealso>
        IAsyncResult BeginUpdateFleet(UpdateFleetRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateFleet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateFleet.</param>
        /// 
        /// <returns>Returns a  UpdateFleetResult from AppStream.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/UpdateFleet">REST API Reference for UpdateFleet Operation</seealso>
        UpdateFleetResponse EndUpdateFleet(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateImagePermissions


        /// <summary>
        /// Adds or updates permissions for the specified private image.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateImagePermissions service method.</param>
        /// 
        /// <returns>The response from the UpdateImagePermissions service method, as returned by AppStream.</returns>
        /// <exception cref="Amazon.AppStream.Model.LimitExceededException">
        /// The requested limit exceeds the permitted limit for an account.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.ResourceNotAvailableException">
        /// The specified resource exists and is not in use, but isn't available.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/UpdateImagePermissions">REST API Reference for UpdateImagePermissions Operation</seealso>
        UpdateImagePermissionsResponse UpdateImagePermissions(UpdateImagePermissionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateImagePermissions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateImagePermissions operation on AmazonAppStreamClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateImagePermissions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/UpdateImagePermissions">REST API Reference for UpdateImagePermissions Operation</seealso>
        IAsyncResult BeginUpdateImagePermissions(UpdateImagePermissionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateImagePermissions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateImagePermissions.</param>
        /// 
        /// <returns>Returns a  UpdateImagePermissionsResult from AppStream.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/UpdateImagePermissions">REST API Reference for UpdateImagePermissions Operation</seealso>
        UpdateImagePermissionsResponse EndUpdateImagePermissions(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateStack


        /// <summary>
        /// Updates the specified fields for the specified stack.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateStack service method.</param>
        /// 
        /// <returns>The response from the UpdateStack service method, as returned by AppStream.</returns>
        /// <exception cref="Amazon.AppStream.Model.IncompatibleImageException">
        /// The image does not support storage connectors.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.InvalidAccountStatusException">
        /// The resource cannot be created because your AWS account is suspended. For assistance,
        /// contact AWS Support.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.InvalidParameterCombinationException">
        /// Indicates an incorrect combination of parameters, or a missing parameter.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.InvalidRoleException">
        /// The specified role is invalid.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.LimitExceededException">
        /// The requested limit exceeds the permitted limit for an account.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.OperationNotPermittedException">
        /// The attempted operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.ResourceInUseException">
        /// The specified resource is in use.
        /// </exception>
        /// <exception cref="Amazon.AppStream.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/UpdateStack">REST API Reference for UpdateStack Operation</seealso>
        UpdateStackResponse UpdateStack(UpdateStackRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateStack operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateStack operation on AmazonAppStreamClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateStack
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/UpdateStack">REST API Reference for UpdateStack Operation</seealso>
        IAsyncResult BeginUpdateStack(UpdateStackRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateStack operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateStack.</param>
        /// 
        /// <returns>Returns a  UpdateStackResult from AppStream.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appstream-2016-12-01/UpdateStack">REST API Reference for UpdateStack Operation</seealso>
        UpdateStackResponse EndUpdateStack(IAsyncResult asyncResult);

        #endregion
        
    }
}