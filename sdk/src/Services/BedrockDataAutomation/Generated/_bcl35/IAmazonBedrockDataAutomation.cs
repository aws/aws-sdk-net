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
 * Do not modify this file. This file is generated from the bedrock-data-automation-2023-07-26.normal.json service model.
 */


using System;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.BedrockDataAutomation.Model;

#pragma warning disable CS1570
namespace Amazon.BedrockDataAutomation
{
    /// <summary>
    /// <para>Interface for accessing BedrockDataAutomation</para>
    ///
    /// Amazon Bedrock Data Automation BuildTime
    /// </summary>
    public partial interface IAmazonBedrockDataAutomation : IAmazonService, IDisposable
    {


#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        IBedrockDataAutomationPaginatorFactory Paginators { get; }
#endif


        
        #region  CopyBlueprintStage


        /// <summary>
        /// Copies a Blueprint from one stage to another
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CopyBlueprintStage service method.</param>
        /// 
        /// <returns>The response from the CopyBlueprintStage service method, as returned by BedrockDataAutomation.</returns>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.ValidationException">
        /// This exception is thrown when the request's input validation fails
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-data-automation-2023-07-26/CopyBlueprintStage">REST API Reference for CopyBlueprintStage Operation</seealso>
        CopyBlueprintStageResponse CopyBlueprintStage(CopyBlueprintStageRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CopyBlueprintStage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CopyBlueprintStage operation on AmazonBedrockDataAutomationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCopyBlueprintStage
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-data-automation-2023-07-26/CopyBlueprintStage">REST API Reference for CopyBlueprintStage Operation</seealso>
        IAsyncResult BeginCopyBlueprintStage(CopyBlueprintStageRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CopyBlueprintStage operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCopyBlueprintStage.</param>
        /// 
        /// <returns>Returns a  CopyBlueprintStageResult from BedrockDataAutomation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-data-automation-2023-07-26/CopyBlueprintStage">REST API Reference for CopyBlueprintStage Operation</seealso>
        CopyBlueprintStageResponse EndCopyBlueprintStage(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateBlueprint


        /// <summary>
        /// Creates an Amazon Bedrock Data Automation Blueprint
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateBlueprint service method.</param>
        /// 
        /// <returns>The response from the CreateBlueprint service method, as returned by BedrockDataAutomation.</returns>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.ConflictException">
        /// This exception is thrown when there is a conflict performing an operation
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.ServiceQuotaExceededException">
        /// This exception is thrown when a request is made beyond the service quota
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.ValidationException">
        /// This exception is thrown when the request's input validation fails
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-data-automation-2023-07-26/CreateBlueprint">REST API Reference for CreateBlueprint Operation</seealso>
        CreateBlueprintResponse CreateBlueprint(CreateBlueprintRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateBlueprint operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateBlueprint operation on AmazonBedrockDataAutomationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateBlueprint
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-data-automation-2023-07-26/CreateBlueprint">REST API Reference for CreateBlueprint Operation</seealso>
        IAsyncResult BeginCreateBlueprint(CreateBlueprintRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateBlueprint operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateBlueprint.</param>
        /// 
        /// <returns>Returns a  CreateBlueprintResult from BedrockDataAutomation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-data-automation-2023-07-26/CreateBlueprint">REST API Reference for CreateBlueprint Operation</seealso>
        CreateBlueprintResponse EndCreateBlueprint(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateBlueprintVersion


        /// <summary>
        /// Creates a new version of an existing Amazon Bedrock Data Automation Blueprint
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateBlueprintVersion service method.</param>
        /// 
        /// <returns>The response from the CreateBlueprintVersion service method, as returned by BedrockDataAutomation.</returns>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.ServiceQuotaExceededException">
        /// This exception is thrown when a request is made beyond the service quota
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.ValidationException">
        /// This exception is thrown when the request's input validation fails
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-data-automation-2023-07-26/CreateBlueprintVersion">REST API Reference for CreateBlueprintVersion Operation</seealso>
        CreateBlueprintVersionResponse CreateBlueprintVersion(CreateBlueprintVersionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateBlueprintVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateBlueprintVersion operation on AmazonBedrockDataAutomationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateBlueprintVersion
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-data-automation-2023-07-26/CreateBlueprintVersion">REST API Reference for CreateBlueprintVersion Operation</seealso>
        IAsyncResult BeginCreateBlueprintVersion(CreateBlueprintVersionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateBlueprintVersion operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateBlueprintVersion.</param>
        /// 
        /// <returns>Returns a  CreateBlueprintVersionResult from BedrockDataAutomation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-data-automation-2023-07-26/CreateBlueprintVersion">REST API Reference for CreateBlueprintVersion Operation</seealso>
        CreateBlueprintVersionResponse EndCreateBlueprintVersion(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateDataAutomationProject


        /// <summary>
        /// Creates an Amazon Bedrock Data Automation Project
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDataAutomationProject service method.</param>
        /// 
        /// <returns>The response from the CreateDataAutomationProject service method, as returned by BedrockDataAutomation.</returns>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.ConflictException">
        /// This exception is thrown when there is a conflict performing an operation
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.ServiceQuotaExceededException">
        /// This exception is thrown when a request is made beyond the service quota
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.ValidationException">
        /// This exception is thrown when the request's input validation fails
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-data-automation-2023-07-26/CreateDataAutomationProject">REST API Reference for CreateDataAutomationProject Operation</seealso>
        CreateDataAutomationProjectResponse CreateDataAutomationProject(CreateDataAutomationProjectRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateDataAutomationProject operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDataAutomationProject operation on AmazonBedrockDataAutomationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateDataAutomationProject
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-data-automation-2023-07-26/CreateDataAutomationProject">REST API Reference for CreateDataAutomationProject Operation</seealso>
        IAsyncResult BeginCreateDataAutomationProject(CreateDataAutomationProjectRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateDataAutomationProject operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateDataAutomationProject.</param>
        /// 
        /// <returns>Returns a  CreateDataAutomationProjectResult from BedrockDataAutomation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-data-automation-2023-07-26/CreateDataAutomationProject">REST API Reference for CreateDataAutomationProject Operation</seealso>
        CreateDataAutomationProjectResponse EndCreateDataAutomationProject(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteBlueprint


        /// <summary>
        /// Deletes an existing Amazon Bedrock Data Automation Blueprint
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteBlueprint service method.</param>
        /// 
        /// <returns>The response from the DeleteBlueprint service method, as returned by BedrockDataAutomation.</returns>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.ValidationException">
        /// This exception is thrown when the request's input validation fails
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-data-automation-2023-07-26/DeleteBlueprint">REST API Reference for DeleteBlueprint Operation</seealso>
        DeleteBlueprintResponse DeleteBlueprint(DeleteBlueprintRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteBlueprint operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteBlueprint operation on AmazonBedrockDataAutomationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteBlueprint
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-data-automation-2023-07-26/DeleteBlueprint">REST API Reference for DeleteBlueprint Operation</seealso>
        IAsyncResult BeginDeleteBlueprint(DeleteBlueprintRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteBlueprint operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteBlueprint.</param>
        /// 
        /// <returns>Returns a  DeleteBlueprintResult from BedrockDataAutomation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-data-automation-2023-07-26/DeleteBlueprint">REST API Reference for DeleteBlueprint Operation</seealso>
        DeleteBlueprintResponse EndDeleteBlueprint(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteDataAutomationProject


        /// <summary>
        /// Deletes an existing Amazon Bedrock Data Automation Project
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDataAutomationProject service method.</param>
        /// 
        /// <returns>The response from the DeleteDataAutomationProject service method, as returned by BedrockDataAutomation.</returns>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.ValidationException">
        /// This exception is thrown when the request's input validation fails
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-data-automation-2023-07-26/DeleteDataAutomationProject">REST API Reference for DeleteDataAutomationProject Operation</seealso>
        DeleteDataAutomationProjectResponse DeleteDataAutomationProject(DeleteDataAutomationProjectRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDataAutomationProject operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDataAutomationProject operation on AmazonBedrockDataAutomationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteDataAutomationProject
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-data-automation-2023-07-26/DeleteDataAutomationProject">REST API Reference for DeleteDataAutomationProject Operation</seealso>
        IAsyncResult BeginDeleteDataAutomationProject(DeleteDataAutomationProjectRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteDataAutomationProject operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteDataAutomationProject.</param>
        /// 
        /// <returns>Returns a  DeleteDataAutomationProjectResult from BedrockDataAutomation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-data-automation-2023-07-26/DeleteDataAutomationProject">REST API Reference for DeleteDataAutomationProject Operation</seealso>
        DeleteDataAutomationProjectResponse EndDeleteDataAutomationProject(IAsyncResult asyncResult);

        #endregion
        
        #region  GetBlueprint


        /// <summary>
        /// Gets an existing Amazon Bedrock Data Automation Blueprint
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetBlueprint service method.</param>
        /// 
        /// <returns>The response from the GetBlueprint service method, as returned by BedrockDataAutomation.</returns>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.ValidationException">
        /// This exception is thrown when the request's input validation fails
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-data-automation-2023-07-26/GetBlueprint">REST API Reference for GetBlueprint Operation</seealso>
        GetBlueprintResponse GetBlueprint(GetBlueprintRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetBlueprint operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetBlueprint operation on AmazonBedrockDataAutomationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetBlueprint
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-data-automation-2023-07-26/GetBlueprint">REST API Reference for GetBlueprint Operation</seealso>
        IAsyncResult BeginGetBlueprint(GetBlueprintRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetBlueprint operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetBlueprint.</param>
        /// 
        /// <returns>Returns a  GetBlueprintResult from BedrockDataAutomation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-data-automation-2023-07-26/GetBlueprint">REST API Reference for GetBlueprint Operation</seealso>
        GetBlueprintResponse EndGetBlueprint(IAsyncResult asyncResult);

        #endregion
        
        #region  GetBlueprintOptimizationStatus


        /// <summary>
        /// API used to get blueprint optimization status.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetBlueprintOptimizationStatus service method.</param>
        /// 
        /// <returns>The response from the GetBlueprintOptimizationStatus service method, as returned by BedrockDataAutomation.</returns>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.ValidationException">
        /// This exception is thrown when the request's input validation fails
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-data-automation-2023-07-26/GetBlueprintOptimizationStatus">REST API Reference for GetBlueprintOptimizationStatus Operation</seealso>
        GetBlueprintOptimizationStatusResponse GetBlueprintOptimizationStatus(GetBlueprintOptimizationStatusRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetBlueprintOptimizationStatus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetBlueprintOptimizationStatus operation on AmazonBedrockDataAutomationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetBlueprintOptimizationStatus
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-data-automation-2023-07-26/GetBlueprintOptimizationStatus">REST API Reference for GetBlueprintOptimizationStatus Operation</seealso>
        IAsyncResult BeginGetBlueprintOptimizationStatus(GetBlueprintOptimizationStatusRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetBlueprintOptimizationStatus operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetBlueprintOptimizationStatus.</param>
        /// 
        /// <returns>Returns a  GetBlueprintOptimizationStatusResult from BedrockDataAutomation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-data-automation-2023-07-26/GetBlueprintOptimizationStatus">REST API Reference for GetBlueprintOptimizationStatus Operation</seealso>
        GetBlueprintOptimizationStatusResponse EndGetBlueprintOptimizationStatus(IAsyncResult asyncResult);

        #endregion
        
        #region  GetDataAutomationProject


        /// <summary>
        /// Gets an existing Amazon Bedrock Data Automation Project
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDataAutomationProject service method.</param>
        /// 
        /// <returns>The response from the GetDataAutomationProject service method, as returned by BedrockDataAutomation.</returns>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.ValidationException">
        /// This exception is thrown when the request's input validation fails
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-data-automation-2023-07-26/GetDataAutomationProject">REST API Reference for GetDataAutomationProject Operation</seealso>
        GetDataAutomationProjectResponse GetDataAutomationProject(GetDataAutomationProjectRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetDataAutomationProject operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDataAutomationProject operation on AmazonBedrockDataAutomationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetDataAutomationProject
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-data-automation-2023-07-26/GetDataAutomationProject">REST API Reference for GetDataAutomationProject Operation</seealso>
        IAsyncResult BeginGetDataAutomationProject(GetDataAutomationProjectRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetDataAutomationProject operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDataAutomationProject.</param>
        /// 
        /// <returns>Returns a  GetDataAutomationProjectResult from BedrockDataAutomation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-data-automation-2023-07-26/GetDataAutomationProject">REST API Reference for GetDataAutomationProject Operation</seealso>
        GetDataAutomationProjectResponse EndGetDataAutomationProject(IAsyncResult asyncResult);

        #endregion
        
        #region  InvokeBlueprintOptimizationAsync


        /// <summary>
        /// Invoke an async job to perform Blueprint Optimization
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the InvokeBlueprintOptimizationAsync service method.</param>
        /// 
        /// <returns>The response from the InvokeBlueprintOptimizationAsync service method, as returned by BedrockDataAutomation.</returns>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.ServiceQuotaExceededException">
        /// This exception is thrown when a request is made beyond the service quota
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.ValidationException">
        /// This exception is thrown when the request's input validation fails
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-data-automation-2023-07-26/InvokeBlueprintOptimizationAsync">REST API Reference for InvokeBlueprintOptimizationAsync Operation</seealso>
        InvokeBlueprintOptimizationAsyncResponse InvokeBlueprintOptimizationAsync(InvokeBlueprintOptimizationAsyncRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the InvokeBlueprintOptimizationAsync operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the InvokeBlueprintOptimizationAsync operation on AmazonBedrockDataAutomationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndInvokeBlueprintOptimizationAsync
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-data-automation-2023-07-26/InvokeBlueprintOptimizationAsync">REST API Reference for InvokeBlueprintOptimizationAsync Operation</seealso>
        IAsyncResult BeginInvokeBlueprintOptimizationAsync(InvokeBlueprintOptimizationAsyncRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  InvokeBlueprintOptimizationAsync operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginInvokeBlueprintOptimizationAsync.</param>
        /// 
        /// <returns>Returns a  InvokeBlueprintOptimizationAsyncResult from BedrockDataAutomation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-data-automation-2023-07-26/InvokeBlueprintOptimizationAsync">REST API Reference for InvokeBlueprintOptimizationAsync Operation</seealso>
        InvokeBlueprintOptimizationAsyncResponse EndInvokeBlueprintOptimizationAsync(IAsyncResult asyncResult);

        #endregion
        
        #region  ListBlueprints


        /// <summary>
        /// Lists all existing Amazon Bedrock Data Automation Blueprints
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListBlueprints service method.</param>
        /// 
        /// <returns>The response from the ListBlueprints service method, as returned by BedrockDataAutomation.</returns>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.ValidationException">
        /// This exception is thrown when the request's input validation fails
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-data-automation-2023-07-26/ListBlueprints">REST API Reference for ListBlueprints Operation</seealso>
        ListBlueprintsResponse ListBlueprints(ListBlueprintsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListBlueprints operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListBlueprints operation on AmazonBedrockDataAutomationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListBlueprints
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-data-automation-2023-07-26/ListBlueprints">REST API Reference for ListBlueprints Operation</seealso>
        IAsyncResult BeginListBlueprints(ListBlueprintsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListBlueprints operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListBlueprints.</param>
        /// 
        /// <returns>Returns a  ListBlueprintsResult from BedrockDataAutomation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-data-automation-2023-07-26/ListBlueprints">REST API Reference for ListBlueprints Operation</seealso>
        ListBlueprintsResponse EndListBlueprints(IAsyncResult asyncResult);

        #endregion
        
        #region  ListDataAutomationProjects


        /// <summary>
        /// Lists all existing Amazon Bedrock Data Automation Projects
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDataAutomationProjects service method.</param>
        /// 
        /// <returns>The response from the ListDataAutomationProjects service method, as returned by BedrockDataAutomation.</returns>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.ValidationException">
        /// This exception is thrown when the request's input validation fails
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-data-automation-2023-07-26/ListDataAutomationProjects">REST API Reference for ListDataAutomationProjects Operation</seealso>
        ListDataAutomationProjectsResponse ListDataAutomationProjects(ListDataAutomationProjectsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListDataAutomationProjects operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDataAutomationProjects operation on AmazonBedrockDataAutomationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListDataAutomationProjects
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-data-automation-2023-07-26/ListDataAutomationProjects">REST API Reference for ListDataAutomationProjects Operation</seealso>
        IAsyncResult BeginListDataAutomationProjects(ListDataAutomationProjectsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListDataAutomationProjects operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListDataAutomationProjects.</param>
        /// 
        /// <returns>Returns a  ListDataAutomationProjectsResult from BedrockDataAutomation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-data-automation-2023-07-26/ListDataAutomationProjects">REST API Reference for ListDataAutomationProjects Operation</seealso>
        ListDataAutomationProjectsResponse EndListDataAutomationProjects(IAsyncResult asyncResult);

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// List tags for an Amazon Bedrock Data Automation resource
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by BedrockDataAutomation.</returns>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.ValidationException">
        /// This exception is thrown when the request's input validation fails
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-data-automation-2023-07-26/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonBedrockDataAutomationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-data-automation-2023-07-26/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        IAsyncResult BeginListTagsForResource(ListTagsForResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTagsForResource.</param>
        /// 
        /// <returns>Returns a  ListTagsForResourceResult from BedrockDataAutomation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-data-automation-2023-07-26/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult);

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Tag an Amazon Bedrock Data Automation resource
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by BedrockDataAutomation.</returns>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.ServiceQuotaExceededException">
        /// This exception is thrown when a request is made beyond the service quota
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.ValidationException">
        /// This exception is thrown when the request's input validation fails
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-data-automation-2023-07-26/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse TagResource(TagResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the TagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonBedrockDataAutomationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-data-automation-2023-07-26/TagResource">REST API Reference for TagResource Operation</seealso>
        IAsyncResult BeginTagResource(TagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  TagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTagResource.</param>
        /// 
        /// <returns>Returns a  TagResourceResult from BedrockDataAutomation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-data-automation-2023-07-26/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse EndTagResource(IAsyncResult asyncResult);

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// Untag an Amazon Bedrock Data Automation resource
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by BedrockDataAutomation.</returns>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.ValidationException">
        /// This exception is thrown when the request's input validation fails
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-data-automation-2023-07-26/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse UntagResource(UntagResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UntagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonBedrockDataAutomationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-data-automation-2023-07-26/UntagResource">REST API Reference for UntagResource Operation</seealso>
        IAsyncResult BeginUntagResource(UntagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UntagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUntagResource.</param>
        /// 
        /// <returns>Returns a  UntagResourceResult from BedrockDataAutomation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-data-automation-2023-07-26/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse EndUntagResource(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateBlueprint


        /// <summary>
        /// Updates an existing Amazon Bedrock Data Automation Blueprint
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateBlueprint service method.</param>
        /// 
        /// <returns>The response from the UpdateBlueprint service method, as returned by BedrockDataAutomation.</returns>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.ConflictException">
        /// This exception is thrown when there is a conflict performing an operation
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.ValidationException">
        /// This exception is thrown when the request's input validation fails
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-data-automation-2023-07-26/UpdateBlueprint">REST API Reference for UpdateBlueprint Operation</seealso>
        UpdateBlueprintResponse UpdateBlueprint(UpdateBlueprintRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateBlueprint operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateBlueprint operation on AmazonBedrockDataAutomationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateBlueprint
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-data-automation-2023-07-26/UpdateBlueprint">REST API Reference for UpdateBlueprint Operation</seealso>
        IAsyncResult BeginUpdateBlueprint(UpdateBlueprintRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateBlueprint operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateBlueprint.</param>
        /// 
        /// <returns>Returns a  UpdateBlueprintResult from BedrockDataAutomation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-data-automation-2023-07-26/UpdateBlueprint">REST API Reference for UpdateBlueprint Operation</seealso>
        UpdateBlueprintResponse EndUpdateBlueprint(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateDataAutomationProject


        /// <summary>
        /// Updates an existing Amazon Bedrock Data Automation Project
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDataAutomationProject service method.</param>
        /// 
        /// <returns>The response from the UpdateDataAutomationProject service method, as returned by BedrockDataAutomation.</returns>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.AccessDeniedException">
        /// This exception is thrown when a request is denied per access permissions
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.ConflictException">
        /// This exception is thrown when there is a conflict performing an operation
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.InternalServerException">
        /// This exception is thrown if there was an unexpected error during processing of request
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource referenced by the operation does not exist
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.ServiceQuotaExceededException">
        /// This exception is thrown when a request is made beyond the service quota
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.ThrottlingException">
        /// This exception is thrown when the number of requests exceeds the limit
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomation.Model.ValidationException">
        /// This exception is thrown when the request's input validation fails
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-data-automation-2023-07-26/UpdateDataAutomationProject">REST API Reference for UpdateDataAutomationProject Operation</seealso>
        UpdateDataAutomationProjectResponse UpdateDataAutomationProject(UpdateDataAutomationProjectRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateDataAutomationProject operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateDataAutomationProject operation on AmazonBedrockDataAutomationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateDataAutomationProject
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-data-automation-2023-07-26/UpdateDataAutomationProject">REST API Reference for UpdateDataAutomationProject Operation</seealso>
        IAsyncResult BeginUpdateDataAutomationProject(UpdateDataAutomationProjectRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateDataAutomationProject operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateDataAutomationProject.</param>
        /// 
        /// <returns>Returns a  UpdateDataAutomationProjectResult from BedrockDataAutomation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-data-automation-2023-07-26/UpdateDataAutomationProject">REST API Reference for UpdateDataAutomationProject Operation</seealso>
        UpdateDataAutomationProjectResponse EndUpdateDataAutomationProject(IAsyncResult asyncResult);

        #endregion
                
        #region DetermineServiceOperationEndpoint

        /// <summary>
        /// Returns the endpoint that will be used for a particular request.
        /// </summary>
        /// <param name="request">Request for the desired service operation.</param>
        /// <returns>The resolved endpoint for the given request.</returns>
        Amazon.Runtime.Endpoints.Endpoint DetermineServiceOperationEndpoint(AmazonWebServiceRequest request);
        
        #endregion

    }
}