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
 * Do not modify this file. This file is generated from the cleanroomsml-2023-09-06.normal.json service model.
 */


using System;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.CleanRoomsML.Model;

#pragma warning disable CS1570
namespace Amazon.CleanRoomsML
{
    /// <summary>
    /// <para>Interface for accessing CleanRoomsML</para>
    ///
    /// Welcome to the <i>Amazon Web Services Clean Rooms ML API Reference</i>.
    /// 
    ///  
    /// <para>
    /// Amazon Web Services Clean Rooms ML provides a privacy-enhancing method for two parties
    /// to identify similar users in their data without the need to share their data with
    /// each other. The first party brings the training data to Clean Rooms so that they can
    /// create and configure an audience model (lookalike model) and associate it with a collaboration.
    /// The second party then brings their seed data to Clean Rooms and generates an audience
    /// (lookalike segment) that resembles the training data.
    /// </para>
    ///  
    /// <para>
    /// To learn more about Amazon Web Services Clean Rooms ML concepts, procedures, and best
    /// practices, see the <a href="https://docs.aws.amazon.com/clean-rooms/latest/userguide/machine-learning.html">Clean
    /// Rooms User Guide</a>.
    /// </para>
    ///  
    /// <para>
    /// To learn more about SQL commands, functions, and conditions supported in Clean Rooms,
    /// see the <a href="https://docs.aws.amazon.com/clean-rooms/latest/sql-reference/sql-reference.html">Clean
    /// Rooms SQL Reference</a>.
    /// </para>
    /// </summary>
    public partial interface IAmazonCleanRoomsML : IAmazonService, IDisposable
    {


#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        ICleanRoomsMLPaginatorFactory Paginators { get; }
#endif


        
        #region  CreateAudienceModel


        /// <summary>
        /// Defines the information necessary to create an audience model. An audience model is
        /// a machine learning model that Clean Rooms ML trains to measure similarity between
        /// users. Clean Rooms ML manages training and storing the audience model. The audience
        /// model can be used in multiple calls to the <a>StartAudienceGenerationJob</a> API.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAudienceModel service method.</param>
        /// 
        /// <returns>The response from the CreateAudienceModel service method, as returned by CleanRoomsML.</returns>
        /// <exception cref="Amazon.CleanRoomsML.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRoomsML.Model.ConflictException">
        /// You can't complete this action because another resource depends on this resource.
        /// </exception>
        /// <exception cref="Amazon.CleanRoomsML.Model.ResourceNotFoundException">
        /// The resource you are requesting does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRoomsML.Model.ServiceQuotaExceededException">
        /// You have exceeded your service quota.
        /// </exception>
        /// <exception cref="Amazon.CleanRoomsML.Model.ValidationException">
        /// The request parameters for this request are incorrect.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanroomsml-2023-09-06/CreateAudienceModel">REST API Reference for CreateAudienceModel Operation</seealso>
        CreateAudienceModelResponse CreateAudienceModel(CreateAudienceModelRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateAudienceModel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateAudienceModel operation on AmazonCleanRoomsMLClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateAudienceModel
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanroomsml-2023-09-06/CreateAudienceModel">REST API Reference for CreateAudienceModel Operation</seealso>
        IAsyncResult BeginCreateAudienceModel(CreateAudienceModelRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateAudienceModel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateAudienceModel.</param>
        /// 
        /// <returns>Returns a  CreateAudienceModelResult from CleanRoomsML.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanroomsml-2023-09-06/CreateAudienceModel">REST API Reference for CreateAudienceModel Operation</seealso>
        CreateAudienceModelResponse EndCreateAudienceModel(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateConfiguredAudienceModel


        /// <summary>
        /// Defines the information necessary to create a configured audience model.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateConfiguredAudienceModel service method.</param>
        /// 
        /// <returns>The response from the CreateConfiguredAudienceModel service method, as returned by CleanRoomsML.</returns>
        /// <exception cref="Amazon.CleanRoomsML.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRoomsML.Model.ConflictException">
        /// You can't complete this action because another resource depends on this resource.
        /// </exception>
        /// <exception cref="Amazon.CleanRoomsML.Model.ResourceNotFoundException">
        /// The resource you are requesting does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRoomsML.Model.ServiceQuotaExceededException">
        /// You have exceeded your service quota.
        /// </exception>
        /// <exception cref="Amazon.CleanRoomsML.Model.ValidationException">
        /// The request parameters for this request are incorrect.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanroomsml-2023-09-06/CreateConfiguredAudienceModel">REST API Reference for CreateConfiguredAudienceModel Operation</seealso>
        CreateConfiguredAudienceModelResponse CreateConfiguredAudienceModel(CreateConfiguredAudienceModelRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateConfiguredAudienceModel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateConfiguredAudienceModel operation on AmazonCleanRoomsMLClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateConfiguredAudienceModel
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanroomsml-2023-09-06/CreateConfiguredAudienceModel">REST API Reference for CreateConfiguredAudienceModel Operation</seealso>
        IAsyncResult BeginCreateConfiguredAudienceModel(CreateConfiguredAudienceModelRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateConfiguredAudienceModel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateConfiguredAudienceModel.</param>
        /// 
        /// <returns>Returns a  CreateConfiguredAudienceModelResult from CleanRoomsML.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanroomsml-2023-09-06/CreateConfiguredAudienceModel">REST API Reference for CreateConfiguredAudienceModel Operation</seealso>
        CreateConfiguredAudienceModelResponse EndCreateConfiguredAudienceModel(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateTrainingDataset


        /// <summary>
        /// Defines the information necessary to create a training dataset. In Clean Rooms ML,
        /// the <c>TrainingDataset</c> is metadata that points to a Glue table, which is read
        /// only during <c>AudienceModel</c> creation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTrainingDataset service method.</param>
        /// 
        /// <returns>The response from the CreateTrainingDataset service method, as returned by CleanRoomsML.</returns>
        /// <exception cref="Amazon.CleanRoomsML.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRoomsML.Model.ConflictException">
        /// You can't complete this action because another resource depends on this resource.
        /// </exception>
        /// <exception cref="Amazon.CleanRoomsML.Model.ValidationException">
        /// The request parameters for this request are incorrect.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanroomsml-2023-09-06/CreateTrainingDataset">REST API Reference for CreateTrainingDataset Operation</seealso>
        CreateTrainingDatasetResponse CreateTrainingDataset(CreateTrainingDatasetRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateTrainingDataset operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateTrainingDataset operation on AmazonCleanRoomsMLClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateTrainingDataset
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanroomsml-2023-09-06/CreateTrainingDataset">REST API Reference for CreateTrainingDataset Operation</seealso>
        IAsyncResult BeginCreateTrainingDataset(CreateTrainingDatasetRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateTrainingDataset operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateTrainingDataset.</param>
        /// 
        /// <returns>Returns a  CreateTrainingDatasetResult from CleanRoomsML.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanroomsml-2023-09-06/CreateTrainingDataset">REST API Reference for CreateTrainingDataset Operation</seealso>
        CreateTrainingDatasetResponse EndCreateTrainingDataset(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteAudienceGenerationJob


        /// <summary>
        /// Deletes the specified audience generation job, and removes all data associated with
        /// the job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAudienceGenerationJob service method.</param>
        /// 
        /// <returns>The response from the DeleteAudienceGenerationJob service method, as returned by CleanRoomsML.</returns>
        /// <exception cref="Amazon.CleanRoomsML.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRoomsML.Model.ConflictException">
        /// You can't complete this action because another resource depends on this resource.
        /// </exception>
        /// <exception cref="Amazon.CleanRoomsML.Model.ResourceNotFoundException">
        /// The resource you are requesting does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRoomsML.Model.ValidationException">
        /// The request parameters for this request are incorrect.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanroomsml-2023-09-06/DeleteAudienceGenerationJob">REST API Reference for DeleteAudienceGenerationJob Operation</seealso>
        DeleteAudienceGenerationJobResponse DeleteAudienceGenerationJob(DeleteAudienceGenerationJobRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteAudienceGenerationJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteAudienceGenerationJob operation on AmazonCleanRoomsMLClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteAudienceGenerationJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanroomsml-2023-09-06/DeleteAudienceGenerationJob">REST API Reference for DeleteAudienceGenerationJob Operation</seealso>
        IAsyncResult BeginDeleteAudienceGenerationJob(DeleteAudienceGenerationJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteAudienceGenerationJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteAudienceGenerationJob.</param>
        /// 
        /// <returns>Returns a  DeleteAudienceGenerationJobResult from CleanRoomsML.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanroomsml-2023-09-06/DeleteAudienceGenerationJob">REST API Reference for DeleteAudienceGenerationJob Operation</seealso>
        DeleteAudienceGenerationJobResponse EndDeleteAudienceGenerationJob(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteAudienceModel


        /// <summary>
        /// Specifies an audience model that you want to delete. You can't delete an audience
        /// model if there are any configured audience models that depend on the audience model.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAudienceModel service method.</param>
        /// 
        /// <returns>The response from the DeleteAudienceModel service method, as returned by CleanRoomsML.</returns>
        /// <exception cref="Amazon.CleanRoomsML.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRoomsML.Model.ConflictException">
        /// You can't complete this action because another resource depends on this resource.
        /// </exception>
        /// <exception cref="Amazon.CleanRoomsML.Model.ResourceNotFoundException">
        /// The resource you are requesting does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRoomsML.Model.ValidationException">
        /// The request parameters for this request are incorrect.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanroomsml-2023-09-06/DeleteAudienceModel">REST API Reference for DeleteAudienceModel Operation</seealso>
        DeleteAudienceModelResponse DeleteAudienceModel(DeleteAudienceModelRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteAudienceModel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteAudienceModel operation on AmazonCleanRoomsMLClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteAudienceModel
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanroomsml-2023-09-06/DeleteAudienceModel">REST API Reference for DeleteAudienceModel Operation</seealso>
        IAsyncResult BeginDeleteAudienceModel(DeleteAudienceModelRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteAudienceModel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteAudienceModel.</param>
        /// 
        /// <returns>Returns a  DeleteAudienceModelResult from CleanRoomsML.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanroomsml-2023-09-06/DeleteAudienceModel">REST API Reference for DeleteAudienceModel Operation</seealso>
        DeleteAudienceModelResponse EndDeleteAudienceModel(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteConfiguredAudienceModel


        /// <summary>
        /// Deletes the specified configured audience model. You can't delete a configured audience
        /// model if there are any lookalike models that use the configured audience model. If
        /// you delete a configured audience model, it will be removed from any collaborations
        /// that it is associated to.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteConfiguredAudienceModel service method.</param>
        /// 
        /// <returns>The response from the DeleteConfiguredAudienceModel service method, as returned by CleanRoomsML.</returns>
        /// <exception cref="Amazon.CleanRoomsML.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRoomsML.Model.ConflictException">
        /// You can't complete this action because another resource depends on this resource.
        /// </exception>
        /// <exception cref="Amazon.CleanRoomsML.Model.ResourceNotFoundException">
        /// The resource you are requesting does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRoomsML.Model.ValidationException">
        /// The request parameters for this request are incorrect.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanroomsml-2023-09-06/DeleteConfiguredAudienceModel">REST API Reference for DeleteConfiguredAudienceModel Operation</seealso>
        DeleteConfiguredAudienceModelResponse DeleteConfiguredAudienceModel(DeleteConfiguredAudienceModelRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteConfiguredAudienceModel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteConfiguredAudienceModel operation on AmazonCleanRoomsMLClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteConfiguredAudienceModel
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanroomsml-2023-09-06/DeleteConfiguredAudienceModel">REST API Reference for DeleteConfiguredAudienceModel Operation</seealso>
        IAsyncResult BeginDeleteConfiguredAudienceModel(DeleteConfiguredAudienceModelRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteConfiguredAudienceModel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteConfiguredAudienceModel.</param>
        /// 
        /// <returns>Returns a  DeleteConfiguredAudienceModelResult from CleanRoomsML.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanroomsml-2023-09-06/DeleteConfiguredAudienceModel">REST API Reference for DeleteConfiguredAudienceModel Operation</seealso>
        DeleteConfiguredAudienceModelResponse EndDeleteConfiguredAudienceModel(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteConfiguredAudienceModelPolicy


        /// <summary>
        /// Deletes the specified configured audience model policy.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteConfiguredAudienceModelPolicy service method.</param>
        /// 
        /// <returns>The response from the DeleteConfiguredAudienceModelPolicy service method, as returned by CleanRoomsML.</returns>
        /// <exception cref="Amazon.CleanRoomsML.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRoomsML.Model.ResourceNotFoundException">
        /// The resource you are requesting does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRoomsML.Model.ValidationException">
        /// The request parameters for this request are incorrect.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanroomsml-2023-09-06/DeleteConfiguredAudienceModelPolicy">REST API Reference for DeleteConfiguredAudienceModelPolicy Operation</seealso>
        DeleteConfiguredAudienceModelPolicyResponse DeleteConfiguredAudienceModelPolicy(DeleteConfiguredAudienceModelPolicyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteConfiguredAudienceModelPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteConfiguredAudienceModelPolicy operation on AmazonCleanRoomsMLClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteConfiguredAudienceModelPolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanroomsml-2023-09-06/DeleteConfiguredAudienceModelPolicy">REST API Reference for DeleteConfiguredAudienceModelPolicy Operation</seealso>
        IAsyncResult BeginDeleteConfiguredAudienceModelPolicy(DeleteConfiguredAudienceModelPolicyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteConfiguredAudienceModelPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteConfiguredAudienceModelPolicy.</param>
        /// 
        /// <returns>Returns a  DeleteConfiguredAudienceModelPolicyResult from CleanRoomsML.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanroomsml-2023-09-06/DeleteConfiguredAudienceModelPolicy">REST API Reference for DeleteConfiguredAudienceModelPolicy Operation</seealso>
        DeleteConfiguredAudienceModelPolicyResponse EndDeleteConfiguredAudienceModelPolicy(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteTrainingDataset


        /// <summary>
        /// Specifies a training dataset that you want to delete. You can't delete a training
        /// dataset if there are any audience models that depend on the training dataset. In Clean
        /// Rooms ML, the <c>TrainingDataset</c> is metadata that points to a Glue table, which
        /// is read only during <c>AudienceModel</c> creation. This action deletes the metadata.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTrainingDataset service method.</param>
        /// 
        /// <returns>The response from the DeleteTrainingDataset service method, as returned by CleanRoomsML.</returns>
        /// <exception cref="Amazon.CleanRoomsML.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRoomsML.Model.ConflictException">
        /// You can't complete this action because another resource depends on this resource.
        /// </exception>
        /// <exception cref="Amazon.CleanRoomsML.Model.ResourceNotFoundException">
        /// The resource you are requesting does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRoomsML.Model.ValidationException">
        /// The request parameters for this request are incorrect.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanroomsml-2023-09-06/DeleteTrainingDataset">REST API Reference for DeleteTrainingDataset Operation</seealso>
        DeleteTrainingDatasetResponse DeleteTrainingDataset(DeleteTrainingDatasetRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteTrainingDataset operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteTrainingDataset operation on AmazonCleanRoomsMLClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteTrainingDataset
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanroomsml-2023-09-06/DeleteTrainingDataset">REST API Reference for DeleteTrainingDataset Operation</seealso>
        IAsyncResult BeginDeleteTrainingDataset(DeleteTrainingDatasetRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteTrainingDataset operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteTrainingDataset.</param>
        /// 
        /// <returns>Returns a  DeleteTrainingDatasetResult from CleanRoomsML.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanroomsml-2023-09-06/DeleteTrainingDataset">REST API Reference for DeleteTrainingDataset Operation</seealso>
        DeleteTrainingDatasetResponse EndDeleteTrainingDataset(IAsyncResult asyncResult);

        #endregion
        
        #region  GetAudienceGenerationJob


        /// <summary>
        /// Returns information about an audience generation job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAudienceGenerationJob service method.</param>
        /// 
        /// <returns>The response from the GetAudienceGenerationJob service method, as returned by CleanRoomsML.</returns>
        /// <exception cref="Amazon.CleanRoomsML.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRoomsML.Model.ResourceNotFoundException">
        /// The resource you are requesting does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRoomsML.Model.ValidationException">
        /// The request parameters for this request are incorrect.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanroomsml-2023-09-06/GetAudienceGenerationJob">REST API Reference for GetAudienceGenerationJob Operation</seealso>
        GetAudienceGenerationJobResponse GetAudienceGenerationJob(GetAudienceGenerationJobRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetAudienceGenerationJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetAudienceGenerationJob operation on AmazonCleanRoomsMLClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetAudienceGenerationJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanroomsml-2023-09-06/GetAudienceGenerationJob">REST API Reference for GetAudienceGenerationJob Operation</seealso>
        IAsyncResult BeginGetAudienceGenerationJob(GetAudienceGenerationJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetAudienceGenerationJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetAudienceGenerationJob.</param>
        /// 
        /// <returns>Returns a  GetAudienceGenerationJobResult from CleanRoomsML.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanroomsml-2023-09-06/GetAudienceGenerationJob">REST API Reference for GetAudienceGenerationJob Operation</seealso>
        GetAudienceGenerationJobResponse EndGetAudienceGenerationJob(IAsyncResult asyncResult);

        #endregion
        
        #region  GetAudienceModel


        /// <summary>
        /// Returns information about an audience model
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAudienceModel service method.</param>
        /// 
        /// <returns>The response from the GetAudienceModel service method, as returned by CleanRoomsML.</returns>
        /// <exception cref="Amazon.CleanRoomsML.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRoomsML.Model.ResourceNotFoundException">
        /// The resource you are requesting does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRoomsML.Model.ValidationException">
        /// The request parameters for this request are incorrect.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanroomsml-2023-09-06/GetAudienceModel">REST API Reference for GetAudienceModel Operation</seealso>
        GetAudienceModelResponse GetAudienceModel(GetAudienceModelRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetAudienceModel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetAudienceModel operation on AmazonCleanRoomsMLClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetAudienceModel
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanroomsml-2023-09-06/GetAudienceModel">REST API Reference for GetAudienceModel Operation</seealso>
        IAsyncResult BeginGetAudienceModel(GetAudienceModelRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetAudienceModel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetAudienceModel.</param>
        /// 
        /// <returns>Returns a  GetAudienceModelResult from CleanRoomsML.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanroomsml-2023-09-06/GetAudienceModel">REST API Reference for GetAudienceModel Operation</seealso>
        GetAudienceModelResponse EndGetAudienceModel(IAsyncResult asyncResult);

        #endregion
        
        #region  GetConfiguredAudienceModel


        /// <summary>
        /// Returns information about a specified configured audience model.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetConfiguredAudienceModel service method.</param>
        /// 
        /// <returns>The response from the GetConfiguredAudienceModel service method, as returned by CleanRoomsML.</returns>
        /// <exception cref="Amazon.CleanRoomsML.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRoomsML.Model.ResourceNotFoundException">
        /// The resource you are requesting does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRoomsML.Model.ValidationException">
        /// The request parameters for this request are incorrect.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanroomsml-2023-09-06/GetConfiguredAudienceModel">REST API Reference for GetConfiguredAudienceModel Operation</seealso>
        GetConfiguredAudienceModelResponse GetConfiguredAudienceModel(GetConfiguredAudienceModelRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetConfiguredAudienceModel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetConfiguredAudienceModel operation on AmazonCleanRoomsMLClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetConfiguredAudienceModel
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanroomsml-2023-09-06/GetConfiguredAudienceModel">REST API Reference for GetConfiguredAudienceModel Operation</seealso>
        IAsyncResult BeginGetConfiguredAudienceModel(GetConfiguredAudienceModelRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetConfiguredAudienceModel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetConfiguredAudienceModel.</param>
        /// 
        /// <returns>Returns a  GetConfiguredAudienceModelResult from CleanRoomsML.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanroomsml-2023-09-06/GetConfiguredAudienceModel">REST API Reference for GetConfiguredAudienceModel Operation</seealso>
        GetConfiguredAudienceModelResponse EndGetConfiguredAudienceModel(IAsyncResult asyncResult);

        #endregion
        
        #region  GetConfiguredAudienceModelPolicy


        /// <summary>
        /// Returns information about a configured audience model policy.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetConfiguredAudienceModelPolicy service method.</param>
        /// 
        /// <returns>The response from the GetConfiguredAudienceModelPolicy service method, as returned by CleanRoomsML.</returns>
        /// <exception cref="Amazon.CleanRoomsML.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRoomsML.Model.ResourceNotFoundException">
        /// The resource you are requesting does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRoomsML.Model.ValidationException">
        /// The request parameters for this request are incorrect.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanroomsml-2023-09-06/GetConfiguredAudienceModelPolicy">REST API Reference for GetConfiguredAudienceModelPolicy Operation</seealso>
        GetConfiguredAudienceModelPolicyResponse GetConfiguredAudienceModelPolicy(GetConfiguredAudienceModelPolicyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetConfiguredAudienceModelPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetConfiguredAudienceModelPolicy operation on AmazonCleanRoomsMLClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetConfiguredAudienceModelPolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanroomsml-2023-09-06/GetConfiguredAudienceModelPolicy">REST API Reference for GetConfiguredAudienceModelPolicy Operation</seealso>
        IAsyncResult BeginGetConfiguredAudienceModelPolicy(GetConfiguredAudienceModelPolicyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetConfiguredAudienceModelPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetConfiguredAudienceModelPolicy.</param>
        /// 
        /// <returns>Returns a  GetConfiguredAudienceModelPolicyResult from CleanRoomsML.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanroomsml-2023-09-06/GetConfiguredAudienceModelPolicy">REST API Reference for GetConfiguredAudienceModelPolicy Operation</seealso>
        GetConfiguredAudienceModelPolicyResponse EndGetConfiguredAudienceModelPolicy(IAsyncResult asyncResult);

        #endregion
        
        #region  GetTrainingDataset


        /// <summary>
        /// Returns information about a training dataset.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTrainingDataset service method.</param>
        /// 
        /// <returns>The response from the GetTrainingDataset service method, as returned by CleanRoomsML.</returns>
        /// <exception cref="Amazon.CleanRoomsML.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRoomsML.Model.ResourceNotFoundException">
        /// The resource you are requesting does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRoomsML.Model.ValidationException">
        /// The request parameters for this request are incorrect.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanroomsml-2023-09-06/GetTrainingDataset">REST API Reference for GetTrainingDataset Operation</seealso>
        GetTrainingDatasetResponse GetTrainingDataset(GetTrainingDatasetRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetTrainingDataset operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetTrainingDataset operation on AmazonCleanRoomsMLClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetTrainingDataset
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanroomsml-2023-09-06/GetTrainingDataset">REST API Reference for GetTrainingDataset Operation</seealso>
        IAsyncResult BeginGetTrainingDataset(GetTrainingDatasetRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetTrainingDataset operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetTrainingDataset.</param>
        /// 
        /// <returns>Returns a  GetTrainingDatasetResult from CleanRoomsML.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanroomsml-2023-09-06/GetTrainingDataset">REST API Reference for GetTrainingDataset Operation</seealso>
        GetTrainingDatasetResponse EndGetTrainingDataset(IAsyncResult asyncResult);

        #endregion
        
        #region  ListAudienceExportJobs


        /// <summary>
        /// Returns a list of the audience export jobs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAudienceExportJobs service method.</param>
        /// 
        /// <returns>The response from the ListAudienceExportJobs service method, as returned by CleanRoomsML.</returns>
        /// <exception cref="Amazon.CleanRoomsML.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRoomsML.Model.ValidationException">
        /// The request parameters for this request are incorrect.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanroomsml-2023-09-06/ListAudienceExportJobs">REST API Reference for ListAudienceExportJobs Operation</seealso>
        ListAudienceExportJobsResponse ListAudienceExportJobs(ListAudienceExportJobsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListAudienceExportJobs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAudienceExportJobs operation on AmazonCleanRoomsMLClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAudienceExportJobs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanroomsml-2023-09-06/ListAudienceExportJobs">REST API Reference for ListAudienceExportJobs Operation</seealso>
        IAsyncResult BeginListAudienceExportJobs(ListAudienceExportJobsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListAudienceExportJobs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAudienceExportJobs.</param>
        /// 
        /// <returns>Returns a  ListAudienceExportJobsResult from CleanRoomsML.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanroomsml-2023-09-06/ListAudienceExportJobs">REST API Reference for ListAudienceExportJobs Operation</seealso>
        ListAudienceExportJobsResponse EndListAudienceExportJobs(IAsyncResult asyncResult);

        #endregion
        
        #region  ListAudienceGenerationJobs


        /// <summary>
        /// Returns a list of audience generation jobs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAudienceGenerationJobs service method.</param>
        /// 
        /// <returns>The response from the ListAudienceGenerationJobs service method, as returned by CleanRoomsML.</returns>
        /// <exception cref="Amazon.CleanRoomsML.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRoomsML.Model.ValidationException">
        /// The request parameters for this request are incorrect.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanroomsml-2023-09-06/ListAudienceGenerationJobs">REST API Reference for ListAudienceGenerationJobs Operation</seealso>
        ListAudienceGenerationJobsResponse ListAudienceGenerationJobs(ListAudienceGenerationJobsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListAudienceGenerationJobs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAudienceGenerationJobs operation on AmazonCleanRoomsMLClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAudienceGenerationJobs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanroomsml-2023-09-06/ListAudienceGenerationJobs">REST API Reference for ListAudienceGenerationJobs Operation</seealso>
        IAsyncResult BeginListAudienceGenerationJobs(ListAudienceGenerationJobsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListAudienceGenerationJobs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAudienceGenerationJobs.</param>
        /// 
        /// <returns>Returns a  ListAudienceGenerationJobsResult from CleanRoomsML.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanroomsml-2023-09-06/ListAudienceGenerationJobs">REST API Reference for ListAudienceGenerationJobs Operation</seealso>
        ListAudienceGenerationJobsResponse EndListAudienceGenerationJobs(IAsyncResult asyncResult);

        #endregion
        
        #region  ListAudienceModels


        /// <summary>
        /// Returns a list of audience models.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAudienceModels service method.</param>
        /// 
        /// <returns>The response from the ListAudienceModels service method, as returned by CleanRoomsML.</returns>
        /// <exception cref="Amazon.CleanRoomsML.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRoomsML.Model.ValidationException">
        /// The request parameters for this request are incorrect.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanroomsml-2023-09-06/ListAudienceModels">REST API Reference for ListAudienceModels Operation</seealso>
        ListAudienceModelsResponse ListAudienceModels(ListAudienceModelsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListAudienceModels operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAudienceModels operation on AmazonCleanRoomsMLClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAudienceModels
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanroomsml-2023-09-06/ListAudienceModels">REST API Reference for ListAudienceModels Operation</seealso>
        IAsyncResult BeginListAudienceModels(ListAudienceModelsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListAudienceModels operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAudienceModels.</param>
        /// 
        /// <returns>Returns a  ListAudienceModelsResult from CleanRoomsML.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanroomsml-2023-09-06/ListAudienceModels">REST API Reference for ListAudienceModels Operation</seealso>
        ListAudienceModelsResponse EndListAudienceModels(IAsyncResult asyncResult);

        #endregion
        
        #region  ListConfiguredAudienceModels


        /// <summary>
        /// Returns a list of the configured audience models.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListConfiguredAudienceModels service method.</param>
        /// 
        /// <returns>The response from the ListConfiguredAudienceModels service method, as returned by CleanRoomsML.</returns>
        /// <exception cref="Amazon.CleanRoomsML.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRoomsML.Model.ValidationException">
        /// The request parameters for this request are incorrect.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanroomsml-2023-09-06/ListConfiguredAudienceModels">REST API Reference for ListConfiguredAudienceModels Operation</seealso>
        ListConfiguredAudienceModelsResponse ListConfiguredAudienceModels(ListConfiguredAudienceModelsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListConfiguredAudienceModels operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListConfiguredAudienceModels operation on AmazonCleanRoomsMLClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListConfiguredAudienceModels
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanroomsml-2023-09-06/ListConfiguredAudienceModels">REST API Reference for ListConfiguredAudienceModels Operation</seealso>
        IAsyncResult BeginListConfiguredAudienceModels(ListConfiguredAudienceModelsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListConfiguredAudienceModels operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListConfiguredAudienceModels.</param>
        /// 
        /// <returns>Returns a  ListConfiguredAudienceModelsResult from CleanRoomsML.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanroomsml-2023-09-06/ListConfiguredAudienceModels">REST API Reference for ListConfiguredAudienceModels Operation</seealso>
        ListConfiguredAudienceModelsResponse EndListConfiguredAudienceModels(IAsyncResult asyncResult);

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// Returns a list of tags for a provided resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by CleanRoomsML.</returns>
        /// <exception cref="Amazon.CleanRoomsML.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRoomsML.Model.ResourceNotFoundException">
        /// The resource you are requesting does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRoomsML.Model.ValidationException">
        /// The request parameters for this request are incorrect.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanroomsml-2023-09-06/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonCleanRoomsMLClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanroomsml-2023-09-06/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        IAsyncResult BeginListTagsForResource(ListTagsForResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTagsForResource.</param>
        /// 
        /// <returns>Returns a  ListTagsForResourceResult from CleanRoomsML.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanroomsml-2023-09-06/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult);

        #endregion
        
        #region  ListTrainingDatasets


        /// <summary>
        /// Returns a list of training datasets.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTrainingDatasets service method.</param>
        /// 
        /// <returns>The response from the ListTrainingDatasets service method, as returned by CleanRoomsML.</returns>
        /// <exception cref="Amazon.CleanRoomsML.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRoomsML.Model.ValidationException">
        /// The request parameters for this request are incorrect.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanroomsml-2023-09-06/ListTrainingDatasets">REST API Reference for ListTrainingDatasets Operation</seealso>
        ListTrainingDatasetsResponse ListTrainingDatasets(ListTrainingDatasetsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListTrainingDatasets operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTrainingDatasets operation on AmazonCleanRoomsMLClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTrainingDatasets
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanroomsml-2023-09-06/ListTrainingDatasets">REST API Reference for ListTrainingDatasets Operation</seealso>
        IAsyncResult BeginListTrainingDatasets(ListTrainingDatasetsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTrainingDatasets operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTrainingDatasets.</param>
        /// 
        /// <returns>Returns a  ListTrainingDatasetsResult from CleanRoomsML.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanroomsml-2023-09-06/ListTrainingDatasets">REST API Reference for ListTrainingDatasets Operation</seealso>
        ListTrainingDatasetsResponse EndListTrainingDatasets(IAsyncResult asyncResult);

        #endregion
        
        #region  PutConfiguredAudienceModelPolicy


        /// <summary>
        /// Create or update the resource policy for a configured audience model.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutConfiguredAudienceModelPolicy service method.</param>
        /// 
        /// <returns>The response from the PutConfiguredAudienceModelPolicy service method, as returned by CleanRoomsML.</returns>
        /// <exception cref="Amazon.CleanRoomsML.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRoomsML.Model.ResourceNotFoundException">
        /// The resource you are requesting does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRoomsML.Model.ValidationException">
        /// The request parameters for this request are incorrect.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanroomsml-2023-09-06/PutConfiguredAudienceModelPolicy">REST API Reference for PutConfiguredAudienceModelPolicy Operation</seealso>
        PutConfiguredAudienceModelPolicyResponse PutConfiguredAudienceModelPolicy(PutConfiguredAudienceModelPolicyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the PutConfiguredAudienceModelPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutConfiguredAudienceModelPolicy operation on AmazonCleanRoomsMLClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutConfiguredAudienceModelPolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanroomsml-2023-09-06/PutConfiguredAudienceModelPolicy">REST API Reference for PutConfiguredAudienceModelPolicy Operation</seealso>
        IAsyncResult BeginPutConfiguredAudienceModelPolicy(PutConfiguredAudienceModelPolicyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  PutConfiguredAudienceModelPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutConfiguredAudienceModelPolicy.</param>
        /// 
        /// <returns>Returns a  PutConfiguredAudienceModelPolicyResult from CleanRoomsML.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanroomsml-2023-09-06/PutConfiguredAudienceModelPolicy">REST API Reference for PutConfiguredAudienceModelPolicy Operation</seealso>
        PutConfiguredAudienceModelPolicyResponse EndPutConfiguredAudienceModelPolicy(IAsyncResult asyncResult);

        #endregion
        
        #region  StartAudienceExportJob


        /// <summary>
        /// Export an audience of a specified size after you have generated an audience.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartAudienceExportJob service method.</param>
        /// 
        /// <returns>The response from the StartAudienceExportJob service method, as returned by CleanRoomsML.</returns>
        /// <exception cref="Amazon.CleanRoomsML.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRoomsML.Model.ConflictException">
        /// You can't complete this action because another resource depends on this resource.
        /// </exception>
        /// <exception cref="Amazon.CleanRoomsML.Model.ResourceNotFoundException">
        /// The resource you are requesting does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRoomsML.Model.ServiceQuotaExceededException">
        /// You have exceeded your service quota.
        /// </exception>
        /// <exception cref="Amazon.CleanRoomsML.Model.ValidationException">
        /// The request parameters for this request are incorrect.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanroomsml-2023-09-06/StartAudienceExportJob">REST API Reference for StartAudienceExportJob Operation</seealso>
        StartAudienceExportJobResponse StartAudienceExportJob(StartAudienceExportJobRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the StartAudienceExportJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartAudienceExportJob operation on AmazonCleanRoomsMLClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartAudienceExportJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanroomsml-2023-09-06/StartAudienceExportJob">REST API Reference for StartAudienceExportJob Operation</seealso>
        IAsyncResult BeginStartAudienceExportJob(StartAudienceExportJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StartAudienceExportJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartAudienceExportJob.</param>
        /// 
        /// <returns>Returns a  StartAudienceExportJobResult from CleanRoomsML.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanroomsml-2023-09-06/StartAudienceExportJob">REST API Reference for StartAudienceExportJob Operation</seealso>
        StartAudienceExportJobResponse EndStartAudienceExportJob(IAsyncResult asyncResult);

        #endregion
        
        #region  StartAudienceGenerationJob


        /// <summary>
        /// Information necessary to start the audience generation job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartAudienceGenerationJob service method.</param>
        /// 
        /// <returns>The response from the StartAudienceGenerationJob service method, as returned by CleanRoomsML.</returns>
        /// <exception cref="Amazon.CleanRoomsML.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRoomsML.Model.ConflictException">
        /// You can't complete this action because another resource depends on this resource.
        /// </exception>
        /// <exception cref="Amazon.CleanRoomsML.Model.ResourceNotFoundException">
        /// The resource you are requesting does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRoomsML.Model.ServiceQuotaExceededException">
        /// You have exceeded your service quota.
        /// </exception>
        /// <exception cref="Amazon.CleanRoomsML.Model.ValidationException">
        /// The request parameters for this request are incorrect.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanroomsml-2023-09-06/StartAudienceGenerationJob">REST API Reference for StartAudienceGenerationJob Operation</seealso>
        StartAudienceGenerationJobResponse StartAudienceGenerationJob(StartAudienceGenerationJobRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the StartAudienceGenerationJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartAudienceGenerationJob operation on AmazonCleanRoomsMLClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartAudienceGenerationJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanroomsml-2023-09-06/StartAudienceGenerationJob">REST API Reference for StartAudienceGenerationJob Operation</seealso>
        IAsyncResult BeginStartAudienceGenerationJob(StartAudienceGenerationJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StartAudienceGenerationJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartAudienceGenerationJob.</param>
        /// 
        /// <returns>Returns a  StartAudienceGenerationJobResult from CleanRoomsML.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanroomsml-2023-09-06/StartAudienceGenerationJob">REST API Reference for StartAudienceGenerationJob Operation</seealso>
        StartAudienceGenerationJobResponse EndStartAudienceGenerationJob(IAsyncResult asyncResult);

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Adds metadata tags to a specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by CleanRoomsML.</returns>
        /// <exception cref="Amazon.CleanRoomsML.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRoomsML.Model.ResourceNotFoundException">
        /// The resource you are requesting does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRoomsML.Model.ValidationException">
        /// The request parameters for this request are incorrect.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanroomsml-2023-09-06/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse TagResource(TagResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the TagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonCleanRoomsMLClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanroomsml-2023-09-06/TagResource">REST API Reference for TagResource Operation</seealso>
        IAsyncResult BeginTagResource(TagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  TagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTagResource.</param>
        /// 
        /// <returns>Returns a  TagResourceResult from CleanRoomsML.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanroomsml-2023-09-06/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse EndTagResource(IAsyncResult asyncResult);

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// Removes metadata tags from a specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by CleanRoomsML.</returns>
        /// <exception cref="Amazon.CleanRoomsML.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRoomsML.Model.ResourceNotFoundException">
        /// The resource you are requesting does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRoomsML.Model.ValidationException">
        /// The request parameters for this request are incorrect.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanroomsml-2023-09-06/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse UntagResource(UntagResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UntagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonCleanRoomsMLClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanroomsml-2023-09-06/UntagResource">REST API Reference for UntagResource Operation</seealso>
        IAsyncResult BeginUntagResource(UntagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UntagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUntagResource.</param>
        /// 
        /// <returns>Returns a  UntagResourceResult from CleanRoomsML.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanroomsml-2023-09-06/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse EndUntagResource(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateConfiguredAudienceModel


        /// <summary>
        /// Provides the information necessary to update a configured audience model. Updates
        /// that impact audience generation jobs take effect when a new job starts, but do not
        /// impact currently running jobs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateConfiguredAudienceModel service method.</param>
        /// 
        /// <returns>The response from the UpdateConfiguredAudienceModel service method, as returned by CleanRoomsML.</returns>
        /// <exception cref="Amazon.CleanRoomsML.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRoomsML.Model.ConflictException">
        /// You can't complete this action because another resource depends on this resource.
        /// </exception>
        /// <exception cref="Amazon.CleanRoomsML.Model.ResourceNotFoundException">
        /// The resource you are requesting does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRoomsML.Model.ValidationException">
        /// The request parameters for this request are incorrect.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanroomsml-2023-09-06/UpdateConfiguredAudienceModel">REST API Reference for UpdateConfiguredAudienceModel Operation</seealso>
        UpdateConfiguredAudienceModelResponse UpdateConfiguredAudienceModel(UpdateConfiguredAudienceModelRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateConfiguredAudienceModel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateConfiguredAudienceModel operation on AmazonCleanRoomsMLClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateConfiguredAudienceModel
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanroomsml-2023-09-06/UpdateConfiguredAudienceModel">REST API Reference for UpdateConfiguredAudienceModel Operation</seealso>
        IAsyncResult BeginUpdateConfiguredAudienceModel(UpdateConfiguredAudienceModelRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateConfiguredAudienceModel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateConfiguredAudienceModel.</param>
        /// 
        /// <returns>Returns a  UpdateConfiguredAudienceModelResult from CleanRoomsML.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanroomsml-2023-09-06/UpdateConfiguredAudienceModel">REST API Reference for UpdateConfiguredAudienceModel Operation</seealso>
        UpdateConfiguredAudienceModelResponse EndUpdateConfiguredAudienceModel(IAsyncResult asyncResult);

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