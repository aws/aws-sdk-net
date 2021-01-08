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
 * Do not modify this file. This file is generated from the databrew-2017-07-25.normal.json service model.
 */


using System;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.GlueDataBrew.Model;

namespace Amazon.GlueDataBrew
{
    /// <summary>
    /// Interface for accessing GlueDataBrew
    ///
    /// AWS Glue DataBrew is a visual, cloud-scale data-preparation service. DataBrew simplifies
    /// data preparation tasks, targeting data issues that are hard to spot and time-consuming
    /// to fix. DataBrew empowers users of all technical levels to visualize the data and
    /// perform one-click data transformations, with no coding required.
    /// </summary>
    public partial interface IAmazonGlueDataBrew : IAmazonService, IDisposable
    {


#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        IGlueDataBrewPaginatorFactory Paginators { get; }
#endif


        
        #region  BatchDeleteRecipeVersion


        /// <summary>
        /// Deletes one or more versions of a recipe at a time.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchDeleteRecipeVersion service method.</param>
        /// 
        /// <returns>The response from the BatchDeleteRecipeVersion service method, as returned by GlueDataBrew.</returns>
        /// <exception cref="Amazon.GlueDataBrew.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.GlueDataBrew.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.GlueDataBrew.Model.ValidationException">
        /// The input parameters for this request failed validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/databrew-2017-07-25/BatchDeleteRecipeVersion">REST API Reference for BatchDeleteRecipeVersion Operation</seealso>
        BatchDeleteRecipeVersionResponse BatchDeleteRecipeVersion(BatchDeleteRecipeVersionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the BatchDeleteRecipeVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchDeleteRecipeVersion operation on AmazonGlueDataBrewClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchDeleteRecipeVersion
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/databrew-2017-07-25/BatchDeleteRecipeVersion">REST API Reference for BatchDeleteRecipeVersion Operation</seealso>
        IAsyncResult BeginBatchDeleteRecipeVersion(BatchDeleteRecipeVersionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  BatchDeleteRecipeVersion operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchDeleteRecipeVersion.</param>
        /// 
        /// <returns>Returns a  BatchDeleteRecipeVersionResult from GlueDataBrew.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/databrew-2017-07-25/BatchDeleteRecipeVersion">REST API Reference for BatchDeleteRecipeVersion Operation</seealso>
        BatchDeleteRecipeVersionResponse EndBatchDeleteRecipeVersion(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateDataset


        /// <summary>
        /// Creates a new AWS Glue DataBrew dataset for this AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDataset service method.</param>
        /// 
        /// <returns>The response from the CreateDataset service method, as returned by GlueDataBrew.</returns>
        /// <exception cref="Amazon.GlueDataBrew.Model.AccessDeniedException">
        /// Access to the specified resource was denied.
        /// </exception>
        /// <exception cref="Amazon.GlueDataBrew.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.GlueDataBrew.Model.ServiceQuotaExceededException">
        /// A service quota is exceeded.
        /// </exception>
        /// <exception cref="Amazon.GlueDataBrew.Model.ValidationException">
        /// The input parameters for this request failed validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/databrew-2017-07-25/CreateDataset">REST API Reference for CreateDataset Operation</seealso>
        CreateDatasetResponse CreateDataset(CreateDatasetRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateDataset operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDataset operation on AmazonGlueDataBrewClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateDataset
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/databrew-2017-07-25/CreateDataset">REST API Reference for CreateDataset Operation</seealso>
        IAsyncResult BeginCreateDataset(CreateDatasetRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateDataset operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateDataset.</param>
        /// 
        /// <returns>Returns a  CreateDatasetResult from GlueDataBrew.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/databrew-2017-07-25/CreateDataset">REST API Reference for CreateDataset Operation</seealso>
        CreateDatasetResponse EndCreateDataset(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateProfileJob


        /// <summary>
        /// Creates a new job to profile an AWS Glue DataBrew dataset that exists in the current
        /// AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateProfileJob service method.</param>
        /// 
        /// <returns>The response from the CreateProfileJob service method, as returned by GlueDataBrew.</returns>
        /// <exception cref="Amazon.GlueDataBrew.Model.ValidationException">
        /// The input parameters for this request failed validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/databrew-2017-07-25/CreateProfileJob">REST API Reference for CreateProfileJob Operation</seealso>
        CreateProfileJobResponse CreateProfileJob(CreateProfileJobRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateProfileJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateProfileJob operation on AmazonGlueDataBrewClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateProfileJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/databrew-2017-07-25/CreateProfileJob">REST API Reference for CreateProfileJob Operation</seealso>
        IAsyncResult BeginCreateProfileJob(CreateProfileJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateProfileJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateProfileJob.</param>
        /// 
        /// <returns>Returns a  CreateProfileJobResult from GlueDataBrew.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/databrew-2017-07-25/CreateProfileJob">REST API Reference for CreateProfileJob Operation</seealso>
        CreateProfileJobResponse EndCreateProfileJob(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateProject


        /// <summary>
        /// Creates a new AWS Glue DataBrew project in the current AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateProject service method.</param>
        /// 
        /// <returns>The response from the CreateProject service method, as returned by GlueDataBrew.</returns>
        /// <exception cref="Amazon.GlueDataBrew.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.GlueDataBrew.Model.InternalServerException">
        /// An internal service failure occurred.
        /// </exception>
        /// <exception cref="Amazon.GlueDataBrew.Model.ServiceQuotaExceededException">
        /// A service quota is exceeded.
        /// </exception>
        /// <exception cref="Amazon.GlueDataBrew.Model.ValidationException">
        /// The input parameters for this request failed validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/databrew-2017-07-25/CreateProject">REST API Reference for CreateProject Operation</seealso>
        CreateProjectResponse CreateProject(CreateProjectRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateProject operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateProject operation on AmazonGlueDataBrewClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateProject
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/databrew-2017-07-25/CreateProject">REST API Reference for CreateProject Operation</seealso>
        IAsyncResult BeginCreateProject(CreateProjectRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateProject operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateProject.</param>
        /// 
        /// <returns>Returns a  CreateProjectResult from GlueDataBrew.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/databrew-2017-07-25/CreateProject">REST API Reference for CreateProject Operation</seealso>
        CreateProjectResponse EndCreateProject(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateRecipe


        /// <summary>
        /// Creates a new AWS Glue DataBrew recipe for the current AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRecipe service method.</param>
        /// 
        /// <returns>The response from the CreateRecipe service method, as returned by GlueDataBrew.</returns>
        /// <exception cref="Amazon.GlueDataBrew.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.GlueDataBrew.Model.ServiceQuotaExceededException">
        /// A service quota is exceeded.
        /// </exception>
        /// <exception cref="Amazon.GlueDataBrew.Model.ValidationException">
        /// The input parameters for this request failed validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/databrew-2017-07-25/CreateRecipe">REST API Reference for CreateRecipe Operation</seealso>
        CreateRecipeResponse CreateRecipe(CreateRecipeRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateRecipe operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateRecipe operation on AmazonGlueDataBrewClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateRecipe
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/databrew-2017-07-25/CreateRecipe">REST API Reference for CreateRecipe Operation</seealso>
        IAsyncResult BeginCreateRecipe(CreateRecipeRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateRecipe operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateRecipe.</param>
        /// 
        /// <returns>Returns a  CreateRecipeResult from GlueDataBrew.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/databrew-2017-07-25/CreateRecipe">REST API Reference for CreateRecipe Operation</seealso>
        CreateRecipeResponse EndCreateRecipe(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateRecipeJob


        /// <summary>
        /// Creates a new job for an existing AWS Glue DataBrew recipe in the current AWS account.
        /// You can create a standalone job using either a project, or a combination of a recipe
        /// and a dataset.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRecipeJob service method.</param>
        /// 
        /// <returns>The response from the CreateRecipeJob service method, as returned by GlueDataBrew.</returns>
        /// <exception cref="Amazon.GlueDataBrew.Model.ValidationException">
        /// The input parameters for this request failed validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/databrew-2017-07-25/CreateRecipeJob">REST API Reference for CreateRecipeJob Operation</seealso>
        CreateRecipeJobResponse CreateRecipeJob(CreateRecipeJobRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateRecipeJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateRecipeJob operation on AmazonGlueDataBrewClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateRecipeJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/databrew-2017-07-25/CreateRecipeJob">REST API Reference for CreateRecipeJob Operation</seealso>
        IAsyncResult BeginCreateRecipeJob(CreateRecipeJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateRecipeJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateRecipeJob.</param>
        /// 
        /// <returns>Returns a  CreateRecipeJobResult from GlueDataBrew.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/databrew-2017-07-25/CreateRecipeJob">REST API Reference for CreateRecipeJob Operation</seealso>
        CreateRecipeJobResponse EndCreateRecipeJob(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateSchedule


        /// <summary>
        /// Creates a new schedule for one or more AWS Glue DataBrew jobs. Jobs can be run at
        /// a specific date and time, or at regular intervals.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSchedule service method.</param>
        /// 
        /// <returns>The response from the CreateSchedule service method, as returned by GlueDataBrew.</returns>
        /// <exception cref="Amazon.GlueDataBrew.Model.ValidationException">
        /// The input parameters for this request failed validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/databrew-2017-07-25/CreateSchedule">REST API Reference for CreateSchedule Operation</seealso>
        CreateScheduleResponse CreateSchedule(CreateScheduleRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateSchedule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateSchedule operation on AmazonGlueDataBrewClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateSchedule
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/databrew-2017-07-25/CreateSchedule">REST API Reference for CreateSchedule Operation</seealso>
        IAsyncResult BeginCreateSchedule(CreateScheduleRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateSchedule operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateSchedule.</param>
        /// 
        /// <returns>Returns a  CreateScheduleResult from GlueDataBrew.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/databrew-2017-07-25/CreateSchedule">REST API Reference for CreateSchedule Operation</seealso>
        CreateScheduleResponse EndCreateSchedule(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteDataset


        /// <summary>
        /// Deletes a dataset from AWS Glue DataBrew.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDataset service method.</param>
        /// 
        /// <returns>The response from the DeleteDataset service method, as returned by GlueDataBrew.</returns>
        /// <exception cref="Amazon.GlueDataBrew.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.GlueDataBrew.Model.ValidationException">
        /// The input parameters for this request failed validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/databrew-2017-07-25/DeleteDataset">REST API Reference for DeleteDataset Operation</seealso>
        DeleteDatasetResponse DeleteDataset(DeleteDatasetRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDataset operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDataset operation on AmazonGlueDataBrewClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteDataset
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/databrew-2017-07-25/DeleteDataset">REST API Reference for DeleteDataset Operation</seealso>
        IAsyncResult BeginDeleteDataset(DeleteDatasetRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteDataset operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteDataset.</param>
        /// 
        /// <returns>Returns a  DeleteDatasetResult from GlueDataBrew.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/databrew-2017-07-25/DeleteDataset">REST API Reference for DeleteDataset Operation</seealso>
        DeleteDatasetResponse EndDeleteDataset(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteJob


        /// <summary>
        /// Deletes the specified AWS Glue DataBrew job from the current AWS account. The job
        /// can be for a recipe or for a profile.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteJob service method.</param>
        /// 
        /// <returns>The response from the DeleteJob service method, as returned by GlueDataBrew.</returns>
        /// <exception cref="Amazon.GlueDataBrew.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.GlueDataBrew.Model.ValidationException">
        /// The input parameters for this request failed validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/databrew-2017-07-25/DeleteJob">REST API Reference for DeleteJob Operation</seealso>
        DeleteJobResponse DeleteJob(DeleteJobRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteJob operation on AmazonGlueDataBrewClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/databrew-2017-07-25/DeleteJob">REST API Reference for DeleteJob Operation</seealso>
        IAsyncResult BeginDeleteJob(DeleteJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteJob.</param>
        /// 
        /// <returns>Returns a  DeleteJobResult from GlueDataBrew.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/databrew-2017-07-25/DeleteJob">REST API Reference for DeleteJob Operation</seealso>
        DeleteJobResponse EndDeleteJob(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteProject


        /// <summary>
        /// Deletes an existing AWS Glue DataBrew project from the current AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteProject service method.</param>
        /// 
        /// <returns>The response from the DeleteProject service method, as returned by GlueDataBrew.</returns>
        /// <exception cref="Amazon.GlueDataBrew.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.GlueDataBrew.Model.ValidationException">
        /// The input parameters for this request failed validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/databrew-2017-07-25/DeleteProject">REST API Reference for DeleteProject Operation</seealso>
        DeleteProjectResponse DeleteProject(DeleteProjectRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteProject operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteProject operation on AmazonGlueDataBrewClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteProject
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/databrew-2017-07-25/DeleteProject">REST API Reference for DeleteProject Operation</seealso>
        IAsyncResult BeginDeleteProject(DeleteProjectRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteProject operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteProject.</param>
        /// 
        /// <returns>Returns a  DeleteProjectResult from GlueDataBrew.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/databrew-2017-07-25/DeleteProject">REST API Reference for DeleteProject Operation</seealso>
        DeleteProjectResponse EndDeleteProject(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteRecipeVersion


        /// <summary>
        /// Deletes a single version of an AWS Glue DataBrew recipe.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRecipeVersion service method.</param>
        /// 
        /// <returns>The response from the DeleteRecipeVersion service method, as returned by GlueDataBrew.</returns>
        /// <exception cref="Amazon.GlueDataBrew.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.GlueDataBrew.Model.ValidationException">
        /// The input parameters for this request failed validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/databrew-2017-07-25/DeleteRecipeVersion">REST API Reference for DeleteRecipeVersion Operation</seealso>
        DeleteRecipeVersionResponse DeleteRecipeVersion(DeleteRecipeVersionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteRecipeVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteRecipeVersion operation on AmazonGlueDataBrewClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteRecipeVersion
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/databrew-2017-07-25/DeleteRecipeVersion">REST API Reference for DeleteRecipeVersion Operation</seealso>
        IAsyncResult BeginDeleteRecipeVersion(DeleteRecipeVersionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteRecipeVersion operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteRecipeVersion.</param>
        /// 
        /// <returns>Returns a  DeleteRecipeVersionResult from GlueDataBrew.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/databrew-2017-07-25/DeleteRecipeVersion">REST API Reference for DeleteRecipeVersion Operation</seealso>
        DeleteRecipeVersionResponse EndDeleteRecipeVersion(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteSchedule


        /// <summary>
        /// Deletes the specified AWS Glue DataBrew schedule from the current AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSchedule service method.</param>
        /// 
        /// <returns>The response from the DeleteSchedule service method, as returned by GlueDataBrew.</returns>
        /// <exception cref="Amazon.GlueDataBrew.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.GlueDataBrew.Model.ValidationException">
        /// The input parameters for this request failed validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/databrew-2017-07-25/DeleteSchedule">REST API Reference for DeleteSchedule Operation</seealso>
        DeleteScheduleResponse DeleteSchedule(DeleteScheduleRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteSchedule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteSchedule operation on AmazonGlueDataBrewClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteSchedule
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/databrew-2017-07-25/DeleteSchedule">REST API Reference for DeleteSchedule Operation</seealso>
        IAsyncResult BeginDeleteSchedule(DeleteScheduleRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteSchedule operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteSchedule.</param>
        /// 
        /// <returns>Returns a  DeleteScheduleResult from GlueDataBrew.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/databrew-2017-07-25/DeleteSchedule">REST API Reference for DeleteSchedule Operation</seealso>
        DeleteScheduleResponse EndDeleteSchedule(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeDataset


        /// <summary>
        /// Returns the definition of a specific AWS Glue DataBrew dataset that is in the current
        /// AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDataset service method.</param>
        /// 
        /// <returns>The response from the DescribeDataset service method, as returned by GlueDataBrew.</returns>
        /// <exception cref="Amazon.GlueDataBrew.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.GlueDataBrew.Model.ValidationException">
        /// The input parameters for this request failed validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/databrew-2017-07-25/DescribeDataset">REST API Reference for DescribeDataset Operation</seealso>
        DescribeDatasetResponse DescribeDataset(DescribeDatasetRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDataset operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDataset operation on AmazonGlueDataBrewClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeDataset
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/databrew-2017-07-25/DescribeDataset">REST API Reference for DescribeDataset Operation</seealso>
        IAsyncResult BeginDescribeDataset(DescribeDatasetRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeDataset operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeDataset.</param>
        /// 
        /// <returns>Returns a  DescribeDatasetResult from GlueDataBrew.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/databrew-2017-07-25/DescribeDataset">REST API Reference for DescribeDataset Operation</seealso>
        DescribeDatasetResponse EndDescribeDataset(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeJob


        /// <summary>
        /// Returns the definition of a specific AWS Glue DataBrew job that is in the current
        /// AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeJob service method.</param>
        /// 
        /// <returns>The response from the DescribeJob service method, as returned by GlueDataBrew.</returns>
        /// <exception cref="Amazon.GlueDataBrew.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.GlueDataBrew.Model.ValidationException">
        /// The input parameters for this request failed validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/databrew-2017-07-25/DescribeJob">REST API Reference for DescribeJob Operation</seealso>
        DescribeJobResponse DescribeJob(DescribeJobRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeJob operation on AmazonGlueDataBrewClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/databrew-2017-07-25/DescribeJob">REST API Reference for DescribeJob Operation</seealso>
        IAsyncResult BeginDescribeJob(DescribeJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeJob.</param>
        /// 
        /// <returns>Returns a  DescribeJobResult from GlueDataBrew.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/databrew-2017-07-25/DescribeJob">REST API Reference for DescribeJob Operation</seealso>
        DescribeJobResponse EndDescribeJob(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeProject


        /// <summary>
        /// Returns the definition of a specific AWS Glue DataBrew project that is in the current
        /// AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeProject service method.</param>
        /// 
        /// <returns>The response from the DescribeProject service method, as returned by GlueDataBrew.</returns>
        /// <exception cref="Amazon.GlueDataBrew.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.GlueDataBrew.Model.ValidationException">
        /// The input parameters for this request failed validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/databrew-2017-07-25/DescribeProject">REST API Reference for DescribeProject Operation</seealso>
        DescribeProjectResponse DescribeProject(DescribeProjectRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeProject operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeProject operation on AmazonGlueDataBrewClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeProject
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/databrew-2017-07-25/DescribeProject">REST API Reference for DescribeProject Operation</seealso>
        IAsyncResult BeginDescribeProject(DescribeProjectRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeProject operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeProject.</param>
        /// 
        /// <returns>Returns a  DescribeProjectResult from GlueDataBrew.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/databrew-2017-07-25/DescribeProject">REST API Reference for DescribeProject Operation</seealso>
        DescribeProjectResponse EndDescribeProject(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeRecipe


        /// <summary>
        /// Returns the definition of a specific AWS Glue DataBrew recipe that is in the current
        /// AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeRecipe service method.</param>
        /// 
        /// <returns>The response from the DescribeRecipe service method, as returned by GlueDataBrew.</returns>
        /// <exception cref="Amazon.GlueDataBrew.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.GlueDataBrew.Model.ValidationException">
        /// The input parameters for this request failed validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/databrew-2017-07-25/DescribeRecipe">REST API Reference for DescribeRecipe Operation</seealso>
        DescribeRecipeResponse DescribeRecipe(DescribeRecipeRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeRecipe operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeRecipe operation on AmazonGlueDataBrewClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeRecipe
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/databrew-2017-07-25/DescribeRecipe">REST API Reference for DescribeRecipe Operation</seealso>
        IAsyncResult BeginDescribeRecipe(DescribeRecipeRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeRecipe operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeRecipe.</param>
        /// 
        /// <returns>Returns a  DescribeRecipeResult from GlueDataBrew.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/databrew-2017-07-25/DescribeRecipe">REST API Reference for DescribeRecipe Operation</seealso>
        DescribeRecipeResponse EndDescribeRecipe(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeSchedule


        /// <summary>
        /// Returns the definition of a specific AWS Glue DataBrew schedule that is in the current
        /// AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSchedule service method.</param>
        /// 
        /// <returns>The response from the DescribeSchedule service method, as returned by GlueDataBrew.</returns>
        /// <exception cref="Amazon.GlueDataBrew.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.GlueDataBrew.Model.ValidationException">
        /// The input parameters for this request failed validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/databrew-2017-07-25/DescribeSchedule">REST API Reference for DescribeSchedule Operation</seealso>
        DescribeScheduleResponse DescribeSchedule(DescribeScheduleRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeSchedule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeSchedule operation on AmazonGlueDataBrewClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeSchedule
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/databrew-2017-07-25/DescribeSchedule">REST API Reference for DescribeSchedule Operation</seealso>
        IAsyncResult BeginDescribeSchedule(DescribeScheduleRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeSchedule operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeSchedule.</param>
        /// 
        /// <returns>Returns a  DescribeScheduleResult from GlueDataBrew.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/databrew-2017-07-25/DescribeSchedule">REST API Reference for DescribeSchedule Operation</seealso>
        DescribeScheduleResponse EndDescribeSchedule(IAsyncResult asyncResult);

        #endregion
        
        #region  ListDatasets


        /// <summary>
        /// Lists all of the AWS Glue DataBrew datasets for the current AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDatasets service method.</param>
        /// 
        /// <returns>The response from the ListDatasets service method, as returned by GlueDataBrew.</returns>
        /// <exception cref="Amazon.GlueDataBrew.Model.ValidationException">
        /// The input parameters for this request failed validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/databrew-2017-07-25/ListDatasets">REST API Reference for ListDatasets Operation</seealso>
        ListDatasetsResponse ListDatasets(ListDatasetsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListDatasets operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDatasets operation on AmazonGlueDataBrewClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListDatasets
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/databrew-2017-07-25/ListDatasets">REST API Reference for ListDatasets Operation</seealso>
        IAsyncResult BeginListDatasets(ListDatasetsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListDatasets operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListDatasets.</param>
        /// 
        /// <returns>Returns a  ListDatasetsResult from GlueDataBrew.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/databrew-2017-07-25/ListDatasets">REST API Reference for ListDatasets Operation</seealso>
        ListDatasetsResponse EndListDatasets(IAsyncResult asyncResult);

        #endregion
        
        #region  ListJobRuns


        /// <summary>
        /// Lists all of the previous runs of a particular AWS Glue DataBrew job in the current
        /// AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListJobRuns service method.</param>
        /// 
        /// <returns>The response from the ListJobRuns service method, as returned by GlueDataBrew.</returns>
        /// <exception cref="Amazon.GlueDataBrew.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.GlueDataBrew.Model.ValidationException">
        /// The input parameters for this request failed validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/databrew-2017-07-25/ListJobRuns">REST API Reference for ListJobRuns Operation</seealso>
        ListJobRunsResponse ListJobRuns(ListJobRunsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListJobRuns operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListJobRuns operation on AmazonGlueDataBrewClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListJobRuns
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/databrew-2017-07-25/ListJobRuns">REST API Reference for ListJobRuns Operation</seealso>
        IAsyncResult BeginListJobRuns(ListJobRunsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListJobRuns operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListJobRuns.</param>
        /// 
        /// <returns>Returns a  ListJobRunsResult from GlueDataBrew.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/databrew-2017-07-25/ListJobRuns">REST API Reference for ListJobRuns Operation</seealso>
        ListJobRunsResponse EndListJobRuns(IAsyncResult asyncResult);

        #endregion
        
        #region  ListJobs


        /// <summary>
        /// Lists the AWS Glue DataBrew jobs in the current AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListJobs service method.</param>
        /// 
        /// <returns>The response from the ListJobs service method, as returned by GlueDataBrew.</returns>
        /// <exception cref="Amazon.GlueDataBrew.Model.ValidationException">
        /// The input parameters for this request failed validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/databrew-2017-07-25/ListJobs">REST API Reference for ListJobs Operation</seealso>
        ListJobsResponse ListJobs(ListJobsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListJobs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListJobs operation on AmazonGlueDataBrewClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListJobs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/databrew-2017-07-25/ListJobs">REST API Reference for ListJobs Operation</seealso>
        IAsyncResult BeginListJobs(ListJobsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListJobs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListJobs.</param>
        /// 
        /// <returns>Returns a  ListJobsResult from GlueDataBrew.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/databrew-2017-07-25/ListJobs">REST API Reference for ListJobs Operation</seealso>
        ListJobsResponse EndListJobs(IAsyncResult asyncResult);

        #endregion
        
        #region  ListProjects


        /// <summary>
        /// Lists all of the DataBrew projects in the current AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListProjects service method.</param>
        /// 
        /// <returns>The response from the ListProjects service method, as returned by GlueDataBrew.</returns>
        /// <exception cref="Amazon.GlueDataBrew.Model.ValidationException">
        /// The input parameters for this request failed validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/databrew-2017-07-25/ListProjects">REST API Reference for ListProjects Operation</seealso>
        ListProjectsResponse ListProjects(ListProjectsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListProjects operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListProjects operation on AmazonGlueDataBrewClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListProjects
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/databrew-2017-07-25/ListProjects">REST API Reference for ListProjects Operation</seealso>
        IAsyncResult BeginListProjects(ListProjectsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListProjects operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListProjects.</param>
        /// 
        /// <returns>Returns a  ListProjectsResult from GlueDataBrew.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/databrew-2017-07-25/ListProjects">REST API Reference for ListProjects Operation</seealso>
        ListProjectsResponse EndListProjects(IAsyncResult asyncResult);

        #endregion
        
        #region  ListRecipes


        /// <summary>
        /// Lists all of the AWS Glue DataBrew recipes in the current AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRecipes service method.</param>
        /// 
        /// <returns>The response from the ListRecipes service method, as returned by GlueDataBrew.</returns>
        /// <exception cref="Amazon.GlueDataBrew.Model.ValidationException">
        /// The input parameters for this request failed validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/databrew-2017-07-25/ListRecipes">REST API Reference for ListRecipes Operation</seealso>
        ListRecipesResponse ListRecipes(ListRecipesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListRecipes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListRecipes operation on AmazonGlueDataBrewClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListRecipes
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/databrew-2017-07-25/ListRecipes">REST API Reference for ListRecipes Operation</seealso>
        IAsyncResult BeginListRecipes(ListRecipesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListRecipes operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListRecipes.</param>
        /// 
        /// <returns>Returns a  ListRecipesResult from GlueDataBrew.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/databrew-2017-07-25/ListRecipes">REST API Reference for ListRecipes Operation</seealso>
        ListRecipesResponse EndListRecipes(IAsyncResult asyncResult);

        #endregion
        
        #region  ListRecipeVersions


        /// <summary>
        /// Lists all of the versions of a particular AWS Glue DataBrew recipe in the current
        /// AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRecipeVersions service method.</param>
        /// 
        /// <returns>The response from the ListRecipeVersions service method, as returned by GlueDataBrew.</returns>
        /// <exception cref="Amazon.GlueDataBrew.Model.ValidationException">
        /// The input parameters for this request failed validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/databrew-2017-07-25/ListRecipeVersions">REST API Reference for ListRecipeVersions Operation</seealso>
        ListRecipeVersionsResponse ListRecipeVersions(ListRecipeVersionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListRecipeVersions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListRecipeVersions operation on AmazonGlueDataBrewClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListRecipeVersions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/databrew-2017-07-25/ListRecipeVersions">REST API Reference for ListRecipeVersions Operation</seealso>
        IAsyncResult BeginListRecipeVersions(ListRecipeVersionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListRecipeVersions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListRecipeVersions.</param>
        /// 
        /// <returns>Returns a  ListRecipeVersionsResult from GlueDataBrew.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/databrew-2017-07-25/ListRecipeVersions">REST API Reference for ListRecipeVersions Operation</seealso>
        ListRecipeVersionsResponse EndListRecipeVersions(IAsyncResult asyncResult);

        #endregion
        
        #region  ListSchedules


        /// <summary>
        /// Lists the AWS Glue DataBrew schedules in the current AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSchedules service method.</param>
        /// 
        /// <returns>The response from the ListSchedules service method, as returned by GlueDataBrew.</returns>
        /// <exception cref="Amazon.GlueDataBrew.Model.ValidationException">
        /// The input parameters for this request failed validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/databrew-2017-07-25/ListSchedules">REST API Reference for ListSchedules Operation</seealso>
        ListSchedulesResponse ListSchedules(ListSchedulesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListSchedules operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListSchedules operation on AmazonGlueDataBrewClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListSchedules
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/databrew-2017-07-25/ListSchedules">REST API Reference for ListSchedules Operation</seealso>
        IAsyncResult BeginListSchedules(ListSchedulesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListSchedules operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListSchedules.</param>
        /// 
        /// <returns>Returns a  ListSchedulesResult from GlueDataBrew.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/databrew-2017-07-25/ListSchedules">REST API Reference for ListSchedules Operation</seealso>
        ListSchedulesResponse EndListSchedules(IAsyncResult asyncResult);

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// Lists all the tags for an AWS Glue DataBrew resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by GlueDataBrew.</returns>
        /// <exception cref="Amazon.GlueDataBrew.Model.InternalServerException">
        /// An internal service failure occurred.
        /// </exception>
        /// <exception cref="Amazon.GlueDataBrew.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.GlueDataBrew.Model.ValidationException">
        /// The input parameters for this request failed validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/databrew-2017-07-25/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonGlueDataBrewClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/databrew-2017-07-25/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        IAsyncResult BeginListTagsForResource(ListTagsForResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTagsForResource.</param>
        /// 
        /// <returns>Returns a  ListTagsForResourceResult from GlueDataBrew.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/databrew-2017-07-25/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult);

        #endregion
        
        #region  PublishRecipe


        /// <summary>
        /// Publishes a new major version of an AWS Glue DataBrew recipe that exists in the current
        /// AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PublishRecipe service method.</param>
        /// 
        /// <returns>The response from the PublishRecipe service method, as returned by GlueDataBrew.</returns>
        /// <exception cref="Amazon.GlueDataBrew.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.GlueDataBrew.Model.ValidationException">
        /// The input parameters for this request failed validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/databrew-2017-07-25/PublishRecipe">REST API Reference for PublishRecipe Operation</seealso>
        PublishRecipeResponse PublishRecipe(PublishRecipeRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the PublishRecipe operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PublishRecipe operation on AmazonGlueDataBrewClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPublishRecipe
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/databrew-2017-07-25/PublishRecipe">REST API Reference for PublishRecipe Operation</seealso>
        IAsyncResult BeginPublishRecipe(PublishRecipeRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  PublishRecipe operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPublishRecipe.</param>
        /// 
        /// <returns>Returns a  PublishRecipeResult from GlueDataBrew.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/databrew-2017-07-25/PublishRecipe">REST API Reference for PublishRecipe Operation</seealso>
        PublishRecipeResponse EndPublishRecipe(IAsyncResult asyncResult);

        #endregion
        
        #region  SendProjectSessionAction


        /// <summary>
        /// Performs a recipe step within an interactive AWS Glue DataBrew session that's currently
        /// open.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SendProjectSessionAction service method.</param>
        /// 
        /// <returns>The response from the SendProjectSessionAction service method, as returned by GlueDataBrew.</returns>
        /// <exception cref="Amazon.GlueDataBrew.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.GlueDataBrew.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.GlueDataBrew.Model.ValidationException">
        /// The input parameters for this request failed validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/databrew-2017-07-25/SendProjectSessionAction">REST API Reference for SendProjectSessionAction Operation</seealso>
        SendProjectSessionActionResponse SendProjectSessionAction(SendProjectSessionActionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the SendProjectSessionAction operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SendProjectSessionAction operation on AmazonGlueDataBrewClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSendProjectSessionAction
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/databrew-2017-07-25/SendProjectSessionAction">REST API Reference for SendProjectSessionAction Operation</seealso>
        IAsyncResult BeginSendProjectSessionAction(SendProjectSessionActionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  SendProjectSessionAction operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSendProjectSessionAction.</param>
        /// 
        /// <returns>Returns a  SendProjectSessionActionResult from GlueDataBrew.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/databrew-2017-07-25/SendProjectSessionAction">REST API Reference for SendProjectSessionAction Operation</seealso>
        SendProjectSessionActionResponse EndSendProjectSessionAction(IAsyncResult asyncResult);

        #endregion
        
        #region  StartJobRun


        /// <summary>
        /// Runs an AWS Glue DataBrew job that exists in the current AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartJobRun service method.</param>
        /// 
        /// <returns>The response from the StartJobRun service method, as returned by GlueDataBrew.</returns>
        /// <exception cref="Amazon.GlueDataBrew.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.GlueDataBrew.Model.ValidationException">
        /// The input parameters for this request failed validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/databrew-2017-07-25/StartJobRun">REST API Reference for StartJobRun Operation</seealso>
        StartJobRunResponse StartJobRun(StartJobRunRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the StartJobRun operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartJobRun operation on AmazonGlueDataBrewClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartJobRun
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/databrew-2017-07-25/StartJobRun">REST API Reference for StartJobRun Operation</seealso>
        IAsyncResult BeginStartJobRun(StartJobRunRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StartJobRun operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartJobRun.</param>
        /// 
        /// <returns>Returns a  StartJobRunResult from GlueDataBrew.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/databrew-2017-07-25/StartJobRun">REST API Reference for StartJobRun Operation</seealso>
        StartJobRunResponse EndStartJobRun(IAsyncResult asyncResult);

        #endregion
        
        #region  StartProjectSession


        /// <summary>
        /// Creates an interactive session, enabling you to manipulate an AWS Glue DataBrew project.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartProjectSession service method.</param>
        /// 
        /// <returns>The response from the StartProjectSession service method, as returned by GlueDataBrew.</returns>
        /// <exception cref="Amazon.GlueDataBrew.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.GlueDataBrew.Model.ValidationException">
        /// The input parameters for this request failed validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/databrew-2017-07-25/StartProjectSession">REST API Reference for StartProjectSession Operation</seealso>
        StartProjectSessionResponse StartProjectSession(StartProjectSessionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the StartProjectSession operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartProjectSession operation on AmazonGlueDataBrewClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartProjectSession
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/databrew-2017-07-25/StartProjectSession">REST API Reference for StartProjectSession Operation</seealso>
        IAsyncResult BeginStartProjectSession(StartProjectSessionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StartProjectSession operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartProjectSession.</param>
        /// 
        /// <returns>Returns a  StartProjectSessionResult from GlueDataBrew.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/databrew-2017-07-25/StartProjectSession">REST API Reference for StartProjectSession Operation</seealso>
        StartProjectSessionResponse EndStartProjectSession(IAsyncResult asyncResult);

        #endregion
        
        #region  StopJobRun


        /// <summary>
        /// Stops the specified job from running in the current AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopJobRun service method.</param>
        /// 
        /// <returns>The response from the StopJobRun service method, as returned by GlueDataBrew.</returns>
        /// <exception cref="Amazon.GlueDataBrew.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.GlueDataBrew.Model.ValidationException">
        /// The input parameters for this request failed validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/databrew-2017-07-25/StopJobRun">REST API Reference for StopJobRun Operation</seealso>
        StopJobRunResponse StopJobRun(StopJobRunRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the StopJobRun operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopJobRun operation on AmazonGlueDataBrewClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStopJobRun
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/databrew-2017-07-25/StopJobRun">REST API Reference for StopJobRun Operation</seealso>
        IAsyncResult BeginStopJobRun(StopJobRunRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StopJobRun operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStopJobRun.</param>
        /// 
        /// <returns>Returns a  StopJobRunResult from GlueDataBrew.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/databrew-2017-07-25/StopJobRun">REST API Reference for StopJobRun Operation</seealso>
        StopJobRunResponse EndStopJobRun(IAsyncResult asyncResult);

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Adds metadata tags to an AWS Glue DataBrew resource, such as a dataset, job, project,
        /// or recipe.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by GlueDataBrew.</returns>
        /// <exception cref="Amazon.GlueDataBrew.Model.InternalServerException">
        /// An internal service failure occurred.
        /// </exception>
        /// <exception cref="Amazon.GlueDataBrew.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.GlueDataBrew.Model.ValidationException">
        /// The input parameters for this request failed validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/databrew-2017-07-25/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse TagResource(TagResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the TagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonGlueDataBrewClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/databrew-2017-07-25/TagResource">REST API Reference for TagResource Operation</seealso>
        IAsyncResult BeginTagResource(TagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  TagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTagResource.</param>
        /// 
        /// <returns>Returns a  TagResourceResult from GlueDataBrew.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/databrew-2017-07-25/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse EndTagResource(IAsyncResult asyncResult);

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// Removes metadata tags from an AWS Glue DataBrew resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by GlueDataBrew.</returns>
        /// <exception cref="Amazon.GlueDataBrew.Model.InternalServerException">
        /// An internal service failure occurred.
        /// </exception>
        /// <exception cref="Amazon.GlueDataBrew.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.GlueDataBrew.Model.ValidationException">
        /// The input parameters for this request failed validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/databrew-2017-07-25/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse UntagResource(UntagResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UntagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonGlueDataBrewClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/databrew-2017-07-25/UntagResource">REST API Reference for UntagResource Operation</seealso>
        IAsyncResult BeginUntagResource(UntagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UntagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUntagResource.</param>
        /// 
        /// <returns>Returns a  UntagResourceResult from GlueDataBrew.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/databrew-2017-07-25/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse EndUntagResource(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateDataset


        /// <summary>
        /// Modifies the definition of an existing AWS Glue DataBrew dataset in the current AWS
        /// account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDataset service method.</param>
        /// 
        /// <returns>The response from the UpdateDataset service method, as returned by GlueDataBrew.</returns>
        /// <exception cref="Amazon.GlueDataBrew.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.GlueDataBrew.Model.ValidationException">
        /// The input parameters for this request failed validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/databrew-2017-07-25/UpdateDataset">REST API Reference for UpdateDataset Operation</seealso>
        UpdateDatasetResponse UpdateDataset(UpdateDatasetRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateDataset operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateDataset operation on AmazonGlueDataBrewClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateDataset
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/databrew-2017-07-25/UpdateDataset">REST API Reference for UpdateDataset Operation</seealso>
        IAsyncResult BeginUpdateDataset(UpdateDatasetRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateDataset operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateDataset.</param>
        /// 
        /// <returns>Returns a  UpdateDatasetResult from GlueDataBrew.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/databrew-2017-07-25/UpdateDataset">REST API Reference for UpdateDataset Operation</seealso>
        UpdateDatasetResponse EndUpdateDataset(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateProfileJob


        /// <summary>
        /// Modifies the definition of an existing AWS Glue DataBrew job in the current AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateProfileJob service method.</param>
        /// 
        /// <returns>The response from the UpdateProfileJob service method, as returned by GlueDataBrew.</returns>
        /// <exception cref="Amazon.GlueDataBrew.Model.ValidationException">
        /// The input parameters for this request failed validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/databrew-2017-07-25/UpdateProfileJob">REST API Reference for UpdateProfileJob Operation</seealso>
        UpdateProfileJobResponse UpdateProfileJob(UpdateProfileJobRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateProfileJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateProfileJob operation on AmazonGlueDataBrewClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateProfileJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/databrew-2017-07-25/UpdateProfileJob">REST API Reference for UpdateProfileJob Operation</seealso>
        IAsyncResult BeginUpdateProfileJob(UpdateProfileJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateProfileJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateProfileJob.</param>
        /// 
        /// <returns>Returns a  UpdateProfileJobResult from GlueDataBrew.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/databrew-2017-07-25/UpdateProfileJob">REST API Reference for UpdateProfileJob Operation</seealso>
        UpdateProfileJobResponse EndUpdateProfileJob(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateProject


        /// <summary>
        /// Modifies the definition of an existing AWS Glue DataBrew project in the current AWS
        /// account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateProject service method.</param>
        /// 
        /// <returns>The response from the UpdateProject service method, as returned by GlueDataBrew.</returns>
        /// <exception cref="Amazon.GlueDataBrew.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.GlueDataBrew.Model.ValidationException">
        /// The input parameters for this request failed validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/databrew-2017-07-25/UpdateProject">REST API Reference for UpdateProject Operation</seealso>
        UpdateProjectResponse UpdateProject(UpdateProjectRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateProject operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateProject operation on AmazonGlueDataBrewClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateProject
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/databrew-2017-07-25/UpdateProject">REST API Reference for UpdateProject Operation</seealso>
        IAsyncResult BeginUpdateProject(UpdateProjectRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateProject operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateProject.</param>
        /// 
        /// <returns>Returns a  UpdateProjectResult from GlueDataBrew.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/databrew-2017-07-25/UpdateProject">REST API Reference for UpdateProject Operation</seealso>
        UpdateProjectResponse EndUpdateProject(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateRecipe


        /// <summary>
        /// Modifies the definition of the latest working version of an AWS Glue DataBrew recipe
        /// in the current AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRecipe service method.</param>
        /// 
        /// <returns>The response from the UpdateRecipe service method, as returned by GlueDataBrew.</returns>
        /// <exception cref="Amazon.GlueDataBrew.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.GlueDataBrew.Model.ValidationException">
        /// The input parameters for this request failed validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/databrew-2017-07-25/UpdateRecipe">REST API Reference for UpdateRecipe Operation</seealso>
        UpdateRecipeResponse UpdateRecipe(UpdateRecipeRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateRecipe operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateRecipe operation on AmazonGlueDataBrewClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateRecipe
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/databrew-2017-07-25/UpdateRecipe">REST API Reference for UpdateRecipe Operation</seealso>
        IAsyncResult BeginUpdateRecipe(UpdateRecipeRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateRecipe operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateRecipe.</param>
        /// 
        /// <returns>Returns a  UpdateRecipeResult from GlueDataBrew.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/databrew-2017-07-25/UpdateRecipe">REST API Reference for UpdateRecipe Operation</seealso>
        UpdateRecipeResponse EndUpdateRecipe(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateRecipeJob


        /// <summary>
        /// Modifies the definition of an existing AWS Glue DataBrew recipe job in the current
        /// AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRecipeJob service method.</param>
        /// 
        /// <returns>The response from the UpdateRecipeJob service method, as returned by GlueDataBrew.</returns>
        /// <exception cref="Amazon.GlueDataBrew.Model.ValidationException">
        /// The input parameters for this request failed validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/databrew-2017-07-25/UpdateRecipeJob">REST API Reference for UpdateRecipeJob Operation</seealso>
        UpdateRecipeJobResponse UpdateRecipeJob(UpdateRecipeJobRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateRecipeJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateRecipeJob operation on AmazonGlueDataBrewClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateRecipeJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/databrew-2017-07-25/UpdateRecipeJob">REST API Reference for UpdateRecipeJob Operation</seealso>
        IAsyncResult BeginUpdateRecipeJob(UpdateRecipeJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateRecipeJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateRecipeJob.</param>
        /// 
        /// <returns>Returns a  UpdateRecipeJobResult from GlueDataBrew.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/databrew-2017-07-25/UpdateRecipeJob">REST API Reference for UpdateRecipeJob Operation</seealso>
        UpdateRecipeJobResponse EndUpdateRecipeJob(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateSchedule


        /// <summary>
        /// Modifies the definition of an existing AWS Glue DataBrew schedule in the current AWS
        /// account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSchedule service method.</param>
        /// 
        /// <returns>The response from the UpdateSchedule service method, as returned by GlueDataBrew.</returns>
        /// <exception cref="Amazon.GlueDataBrew.Model.ValidationException">
        /// The input parameters for this request failed validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/databrew-2017-07-25/UpdateSchedule">REST API Reference for UpdateSchedule Operation</seealso>
        UpdateScheduleResponse UpdateSchedule(UpdateScheduleRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateSchedule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateSchedule operation on AmazonGlueDataBrewClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateSchedule
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/databrew-2017-07-25/UpdateSchedule">REST API Reference for UpdateSchedule Operation</seealso>
        IAsyncResult BeginUpdateSchedule(UpdateScheduleRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateSchedule operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateSchedule.</param>
        /// 
        /// <returns>Returns a  UpdateScheduleResult from GlueDataBrew.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/databrew-2017-07-25/UpdateSchedule">REST API Reference for UpdateSchedule Operation</seealso>
        UpdateScheduleResponse EndUpdateSchedule(IAsyncResult asyncResult);

        #endregion
        
    }
}