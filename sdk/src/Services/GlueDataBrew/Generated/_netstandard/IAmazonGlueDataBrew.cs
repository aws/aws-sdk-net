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
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.GlueDataBrew.Model;

#pragma warning disable CS1570
namespace Amazon.GlueDataBrew
{
    /// <summary>
    /// <para>Interface for accessing GlueDataBrew</para>
    ///
    /// Glue DataBrew is a visual, cloud-scale data-preparation service. DataBrew simplifies
    /// data preparation tasks, targeting data issues that are hard to spot and time-consuming
    /// to fix. DataBrew empowers users of all technical levels to visualize the data and
    /// perform one-click data transformations, with no coding required.
    /// </summary>
    public partial interface IAmazonGlueDataBrew : IAmazonService, IDisposable
    {
#if AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        IGlueDataBrewPaginatorFactory Paginators { get; }
#endif
                
        #region  BatchDeleteRecipeVersion



        /// <summary>
        /// Deletes one or more versions of a recipe at a time.
        /// 
        ///  
        /// <para>
        /// The entire request will be rejected if:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The recipe does not exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// There is an invalid version identifier in the list of versions.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The version list is empty.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The version list size exceeds 50.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The version list contains duplicate entries.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// The request will complete successfully, but with partial failures, if:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// A version does not exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A version is being used by a job.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You specify <c>LATEST_WORKING</c>, but it's being used by a project.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The version fails to be deleted.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// The <c>LATEST_WORKING</c> version will only be deleted if the recipe has no other
        /// versions. If you try to delete <c>LATEST_WORKING</c> while other versions exist (or
        /// if they can't be deleted), then <c>LATEST_WORKING</c> will be listed as partial failure
        /// in the response.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchDeleteRecipeVersion service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<BatchDeleteRecipeVersionResponse> BatchDeleteRecipeVersionAsync(BatchDeleteRecipeVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateDataset



        /// <summary>
        /// Creates a new DataBrew dataset.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDataset service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<CreateDatasetResponse> CreateDatasetAsync(CreateDatasetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateProfileJob



        /// <summary>
        /// Creates a new job to analyze a dataset and create its data profile.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateProfileJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateProfileJob service method, as returned by GlueDataBrew.</returns>
        /// <exception cref="Amazon.GlueDataBrew.Model.AccessDeniedException">
        /// Access to the specified resource was denied.
        /// </exception>
        /// <exception cref="Amazon.GlueDataBrew.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.GlueDataBrew.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.GlueDataBrew.Model.ServiceQuotaExceededException">
        /// A service quota is exceeded.
        /// </exception>
        /// <exception cref="Amazon.GlueDataBrew.Model.ValidationException">
        /// The input parameters for this request failed validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/databrew-2017-07-25/CreateProfileJob">REST API Reference for CreateProfileJob Operation</seealso>
        Task<CreateProfileJobResponse> CreateProfileJobAsync(CreateProfileJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateProject



        /// <summary>
        /// Creates a new DataBrew project.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateProject service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<CreateProjectResponse> CreateProjectAsync(CreateProjectRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateRecipe



        /// <summary>
        /// Creates a new DataBrew recipe.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRecipe service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<CreateRecipeResponse> CreateRecipeAsync(CreateRecipeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateRecipeJob



        /// <summary>
        /// Creates a new job to transform input data, using steps defined in an existing Glue
        /// DataBrew recipe
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRecipeJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateRecipeJob service method, as returned by GlueDataBrew.</returns>
        /// <exception cref="Amazon.GlueDataBrew.Model.AccessDeniedException">
        /// Access to the specified resource was denied.
        /// </exception>
        /// <exception cref="Amazon.GlueDataBrew.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.GlueDataBrew.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.GlueDataBrew.Model.ServiceQuotaExceededException">
        /// A service quota is exceeded.
        /// </exception>
        /// <exception cref="Amazon.GlueDataBrew.Model.ValidationException">
        /// The input parameters for this request failed validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/databrew-2017-07-25/CreateRecipeJob">REST API Reference for CreateRecipeJob Operation</seealso>
        Task<CreateRecipeJobResponse> CreateRecipeJobAsync(CreateRecipeJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateRuleset



        /// <summary>
        /// Creates a new ruleset that can be used in a profile job to validate the data quality
        /// of a dataset.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRuleset service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateRuleset service method, as returned by GlueDataBrew.</returns>
        /// <exception cref="Amazon.GlueDataBrew.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.GlueDataBrew.Model.ServiceQuotaExceededException">
        /// A service quota is exceeded.
        /// </exception>
        /// <exception cref="Amazon.GlueDataBrew.Model.ValidationException">
        /// The input parameters for this request failed validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/databrew-2017-07-25/CreateRuleset">REST API Reference for CreateRuleset Operation</seealso>
        Task<CreateRulesetResponse> CreateRulesetAsync(CreateRulesetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateSchedule



        /// <summary>
        /// Creates a new schedule for one or more DataBrew jobs. Jobs can be run at a specific
        /// date and time, or at regular intervals.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSchedule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateSchedule service method, as returned by GlueDataBrew.</returns>
        /// <exception cref="Amazon.GlueDataBrew.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.GlueDataBrew.Model.ServiceQuotaExceededException">
        /// A service quota is exceeded.
        /// </exception>
        /// <exception cref="Amazon.GlueDataBrew.Model.ValidationException">
        /// The input parameters for this request failed validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/databrew-2017-07-25/CreateSchedule">REST API Reference for CreateSchedule Operation</seealso>
        Task<CreateScheduleResponse> CreateScheduleAsync(CreateScheduleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteDataset



        /// <summary>
        /// Deletes a dataset from DataBrew.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDataset service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteDataset service method, as returned by GlueDataBrew.</returns>
        /// <exception cref="Amazon.GlueDataBrew.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.GlueDataBrew.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.GlueDataBrew.Model.ValidationException">
        /// The input parameters for this request failed validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/databrew-2017-07-25/DeleteDataset">REST API Reference for DeleteDataset Operation</seealso>
        Task<DeleteDatasetResponse> DeleteDatasetAsync(DeleteDatasetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteJob



        /// <summary>
        /// Deletes the specified DataBrew job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteJob service method, as returned by GlueDataBrew.</returns>
        /// <exception cref="Amazon.GlueDataBrew.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.GlueDataBrew.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.GlueDataBrew.Model.ValidationException">
        /// The input parameters for this request failed validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/databrew-2017-07-25/DeleteJob">REST API Reference for DeleteJob Operation</seealso>
        Task<DeleteJobResponse> DeleteJobAsync(DeleteJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteProject



        /// <summary>
        /// Deletes an existing DataBrew project.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteProject service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteProject service method, as returned by GlueDataBrew.</returns>
        /// <exception cref="Amazon.GlueDataBrew.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.GlueDataBrew.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.GlueDataBrew.Model.ValidationException">
        /// The input parameters for this request failed validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/databrew-2017-07-25/DeleteProject">REST API Reference for DeleteProject Operation</seealso>
        Task<DeleteProjectResponse> DeleteProjectAsync(DeleteProjectRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteRecipeVersion



        /// <summary>
        /// Deletes a single version of a DataBrew recipe.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRecipeVersion service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteRecipeVersion service method, as returned by GlueDataBrew.</returns>
        /// <exception cref="Amazon.GlueDataBrew.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.GlueDataBrew.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.GlueDataBrew.Model.ValidationException">
        /// The input parameters for this request failed validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/databrew-2017-07-25/DeleteRecipeVersion">REST API Reference for DeleteRecipeVersion Operation</seealso>
        Task<DeleteRecipeVersionResponse> DeleteRecipeVersionAsync(DeleteRecipeVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteRuleset



        /// <summary>
        /// Deletes a ruleset.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRuleset service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteRuleset service method, as returned by GlueDataBrew.</returns>
        /// <exception cref="Amazon.GlueDataBrew.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.GlueDataBrew.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.GlueDataBrew.Model.ValidationException">
        /// The input parameters for this request failed validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/databrew-2017-07-25/DeleteRuleset">REST API Reference for DeleteRuleset Operation</seealso>
        Task<DeleteRulesetResponse> DeleteRulesetAsync(DeleteRulesetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteSchedule



        /// <summary>
        /// Deletes the specified DataBrew schedule.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSchedule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteSchedule service method, as returned by GlueDataBrew.</returns>
        /// <exception cref="Amazon.GlueDataBrew.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.GlueDataBrew.Model.ValidationException">
        /// The input parameters for this request failed validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/databrew-2017-07-25/DeleteSchedule">REST API Reference for DeleteSchedule Operation</seealso>
        Task<DeleteScheduleResponse> DeleteScheduleAsync(DeleteScheduleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeDataset



        /// <summary>
        /// Returns the definition of a specific DataBrew dataset.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDataset service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeDataset service method, as returned by GlueDataBrew.</returns>
        /// <exception cref="Amazon.GlueDataBrew.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.GlueDataBrew.Model.ValidationException">
        /// The input parameters for this request failed validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/databrew-2017-07-25/DescribeDataset">REST API Reference for DescribeDataset Operation</seealso>
        Task<DescribeDatasetResponse> DescribeDatasetAsync(DescribeDatasetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeJob



        /// <summary>
        /// Returns the definition of a specific DataBrew job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeJob service method, as returned by GlueDataBrew.</returns>
        /// <exception cref="Amazon.GlueDataBrew.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.GlueDataBrew.Model.ValidationException">
        /// The input parameters for this request failed validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/databrew-2017-07-25/DescribeJob">REST API Reference for DescribeJob Operation</seealso>
        Task<DescribeJobResponse> DescribeJobAsync(DescribeJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeJobRun



        /// <summary>
        /// Represents one run of a DataBrew job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeJobRun service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeJobRun service method, as returned by GlueDataBrew.</returns>
        /// <exception cref="Amazon.GlueDataBrew.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.GlueDataBrew.Model.ValidationException">
        /// The input parameters for this request failed validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/databrew-2017-07-25/DescribeJobRun">REST API Reference for DescribeJobRun Operation</seealso>
        Task<DescribeJobRunResponse> DescribeJobRunAsync(DescribeJobRunRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeProject



        /// <summary>
        /// Returns the definition of a specific DataBrew project.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeProject service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeProject service method, as returned by GlueDataBrew.</returns>
        /// <exception cref="Amazon.GlueDataBrew.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.GlueDataBrew.Model.ValidationException">
        /// The input parameters for this request failed validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/databrew-2017-07-25/DescribeProject">REST API Reference for DescribeProject Operation</seealso>
        Task<DescribeProjectResponse> DescribeProjectAsync(DescribeProjectRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeRecipe



        /// <summary>
        /// Returns the definition of a specific DataBrew recipe corresponding to a particular
        /// version.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeRecipe service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeRecipe service method, as returned by GlueDataBrew.</returns>
        /// <exception cref="Amazon.GlueDataBrew.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.GlueDataBrew.Model.ValidationException">
        /// The input parameters for this request failed validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/databrew-2017-07-25/DescribeRecipe">REST API Reference for DescribeRecipe Operation</seealso>
        Task<DescribeRecipeResponse> DescribeRecipeAsync(DescribeRecipeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeRuleset



        /// <summary>
        /// Retrieves detailed information about the ruleset.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeRuleset service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeRuleset service method, as returned by GlueDataBrew.</returns>
        /// <exception cref="Amazon.GlueDataBrew.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.GlueDataBrew.Model.ValidationException">
        /// The input parameters for this request failed validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/databrew-2017-07-25/DescribeRuleset">REST API Reference for DescribeRuleset Operation</seealso>
        Task<DescribeRulesetResponse> DescribeRulesetAsync(DescribeRulesetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeSchedule



        /// <summary>
        /// Returns the definition of a specific DataBrew schedule.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSchedule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeSchedule service method, as returned by GlueDataBrew.</returns>
        /// <exception cref="Amazon.GlueDataBrew.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.GlueDataBrew.Model.ValidationException">
        /// The input parameters for this request failed validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/databrew-2017-07-25/DescribeSchedule">REST API Reference for DescribeSchedule Operation</seealso>
        Task<DescribeScheduleResponse> DescribeScheduleAsync(DescribeScheduleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListDatasets



        /// <summary>
        /// Lists all of the DataBrew datasets.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDatasets service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListDatasets service method, as returned by GlueDataBrew.</returns>
        /// <exception cref="Amazon.GlueDataBrew.Model.ValidationException">
        /// The input parameters for this request failed validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/databrew-2017-07-25/ListDatasets">REST API Reference for ListDatasets Operation</seealso>
        Task<ListDatasetsResponse> ListDatasetsAsync(ListDatasetsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListJobRuns



        /// <summary>
        /// Lists all of the previous runs of a particular DataBrew job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListJobRuns service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListJobRuns service method, as returned by GlueDataBrew.</returns>
        /// <exception cref="Amazon.GlueDataBrew.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.GlueDataBrew.Model.ValidationException">
        /// The input parameters for this request failed validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/databrew-2017-07-25/ListJobRuns">REST API Reference for ListJobRuns Operation</seealso>
        Task<ListJobRunsResponse> ListJobRunsAsync(ListJobRunsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListJobs



        /// <summary>
        /// Lists all of the DataBrew jobs that are defined.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListJobs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListJobs service method, as returned by GlueDataBrew.</returns>
        /// <exception cref="Amazon.GlueDataBrew.Model.ValidationException">
        /// The input parameters for this request failed validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/databrew-2017-07-25/ListJobs">REST API Reference for ListJobs Operation</seealso>
        Task<ListJobsResponse> ListJobsAsync(ListJobsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListProjects



        /// <summary>
        /// Lists all of the DataBrew projects that are defined.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListProjects service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListProjects service method, as returned by GlueDataBrew.</returns>
        /// <exception cref="Amazon.GlueDataBrew.Model.ValidationException">
        /// The input parameters for this request failed validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/databrew-2017-07-25/ListProjects">REST API Reference for ListProjects Operation</seealso>
        Task<ListProjectsResponse> ListProjectsAsync(ListProjectsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListRecipes



        /// <summary>
        /// Lists all of the DataBrew recipes that are defined.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRecipes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListRecipes service method, as returned by GlueDataBrew.</returns>
        /// <exception cref="Amazon.GlueDataBrew.Model.ValidationException">
        /// The input parameters for this request failed validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/databrew-2017-07-25/ListRecipes">REST API Reference for ListRecipes Operation</seealso>
        Task<ListRecipesResponse> ListRecipesAsync(ListRecipesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListRecipeVersions



        /// <summary>
        /// Lists the versions of a particular DataBrew recipe, except for <c>LATEST_WORKING</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRecipeVersions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListRecipeVersions service method, as returned by GlueDataBrew.</returns>
        /// <exception cref="Amazon.GlueDataBrew.Model.ValidationException">
        /// The input parameters for this request failed validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/databrew-2017-07-25/ListRecipeVersions">REST API Reference for ListRecipeVersions Operation</seealso>
        Task<ListRecipeVersionsResponse> ListRecipeVersionsAsync(ListRecipeVersionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListRulesets



        /// <summary>
        /// List all rulesets available in the current account or rulesets associated with a specific
        /// resource (dataset).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRulesets service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListRulesets service method, as returned by GlueDataBrew.</returns>
        /// <exception cref="Amazon.GlueDataBrew.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.GlueDataBrew.Model.ValidationException">
        /// The input parameters for this request failed validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/databrew-2017-07-25/ListRulesets">REST API Reference for ListRulesets Operation</seealso>
        Task<ListRulesetsResponse> ListRulesetsAsync(ListRulesetsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListSchedules



        /// <summary>
        /// Lists the DataBrew schedules that are defined.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSchedules service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListSchedules service method, as returned by GlueDataBrew.</returns>
        /// <exception cref="Amazon.GlueDataBrew.Model.ValidationException">
        /// The input parameters for this request failed validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/databrew-2017-07-25/ListSchedules">REST API Reference for ListSchedules Operation</seealso>
        Task<ListSchedulesResponse> ListSchedulesAsync(ListSchedulesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListTagsForResource



        /// <summary>
        /// Lists all the tags for a DataBrew resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  PublishRecipe



        /// <summary>
        /// Publishes a new version of a DataBrew recipe.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PublishRecipe service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PublishRecipe service method, as returned by GlueDataBrew.</returns>
        /// <exception cref="Amazon.GlueDataBrew.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.GlueDataBrew.Model.ServiceQuotaExceededException">
        /// A service quota is exceeded.
        /// </exception>
        /// <exception cref="Amazon.GlueDataBrew.Model.ValidationException">
        /// The input parameters for this request failed validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/databrew-2017-07-25/PublishRecipe">REST API Reference for PublishRecipe Operation</seealso>
        Task<PublishRecipeResponse> PublishRecipeAsync(PublishRecipeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  SendProjectSessionAction



        /// <summary>
        /// Performs a recipe step within an interactive DataBrew session that's currently open.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SendProjectSessionAction service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<SendProjectSessionActionResponse> SendProjectSessionActionAsync(SendProjectSessionActionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  StartJobRun



        /// <summary>
        /// Runs a DataBrew job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartJobRun service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartJobRun service method, as returned by GlueDataBrew.</returns>
        /// <exception cref="Amazon.GlueDataBrew.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.GlueDataBrew.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.GlueDataBrew.Model.ServiceQuotaExceededException">
        /// A service quota is exceeded.
        /// </exception>
        /// <exception cref="Amazon.GlueDataBrew.Model.ValidationException">
        /// The input parameters for this request failed validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/databrew-2017-07-25/StartJobRun">REST API Reference for StartJobRun Operation</seealso>
        Task<StartJobRunResponse> StartJobRunAsync(StartJobRunRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  StartProjectSession



        /// <summary>
        /// Creates an interactive session, enabling you to manipulate data in a DataBrew project.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartProjectSession service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartProjectSession service method, as returned by GlueDataBrew.</returns>
        /// <exception cref="Amazon.GlueDataBrew.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.GlueDataBrew.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.GlueDataBrew.Model.ServiceQuotaExceededException">
        /// A service quota is exceeded.
        /// </exception>
        /// <exception cref="Amazon.GlueDataBrew.Model.ValidationException">
        /// The input parameters for this request failed validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/databrew-2017-07-25/StartProjectSession">REST API Reference for StartProjectSession Operation</seealso>
        Task<StartProjectSessionResponse> StartProjectSessionAsync(StartProjectSessionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  StopJobRun



        /// <summary>
        /// Stops a particular run of a job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopJobRun service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StopJobRun service method, as returned by GlueDataBrew.</returns>
        /// <exception cref="Amazon.GlueDataBrew.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.GlueDataBrew.Model.ValidationException">
        /// The input parameters for this request failed validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/databrew-2017-07-25/StopJobRun">REST API Reference for StopJobRun Operation</seealso>
        Task<StopJobRunResponse> StopJobRunAsync(StopJobRunRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  TagResource



        /// <summary>
        /// Adds metadata tags to a DataBrew resource, such as a dataset, project, recipe, job,
        /// or schedule.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UntagResource



        /// <summary>
        /// Removes metadata tags from a DataBrew resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateDataset



        /// <summary>
        /// Modifies the definition of an existing DataBrew dataset.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDataset service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateDataset service method, as returned by GlueDataBrew.</returns>
        /// <exception cref="Amazon.GlueDataBrew.Model.AccessDeniedException">
        /// Access to the specified resource was denied.
        /// </exception>
        /// <exception cref="Amazon.GlueDataBrew.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.GlueDataBrew.Model.ValidationException">
        /// The input parameters for this request failed validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/databrew-2017-07-25/UpdateDataset">REST API Reference for UpdateDataset Operation</seealso>
        Task<UpdateDatasetResponse> UpdateDatasetAsync(UpdateDatasetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateProfileJob



        /// <summary>
        /// Modifies the definition of an existing profile job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateProfileJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateProfileJob service method, as returned by GlueDataBrew.</returns>
        /// <exception cref="Amazon.GlueDataBrew.Model.AccessDeniedException">
        /// Access to the specified resource was denied.
        /// </exception>
        /// <exception cref="Amazon.GlueDataBrew.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.GlueDataBrew.Model.ValidationException">
        /// The input parameters for this request failed validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/databrew-2017-07-25/UpdateProfileJob">REST API Reference for UpdateProfileJob Operation</seealso>
        Task<UpdateProfileJobResponse> UpdateProfileJobAsync(UpdateProfileJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateProject



        /// <summary>
        /// Modifies the definition of an existing DataBrew project.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateProject service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateProject service method, as returned by GlueDataBrew.</returns>
        /// <exception cref="Amazon.GlueDataBrew.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.GlueDataBrew.Model.ValidationException">
        /// The input parameters for this request failed validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/databrew-2017-07-25/UpdateProject">REST API Reference for UpdateProject Operation</seealso>
        Task<UpdateProjectResponse> UpdateProjectAsync(UpdateProjectRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateRecipe



        /// <summary>
        /// Modifies the definition of the <c>LATEST_WORKING</c> version of a DataBrew recipe.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRecipe service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateRecipe service method, as returned by GlueDataBrew.</returns>
        /// <exception cref="Amazon.GlueDataBrew.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.GlueDataBrew.Model.ValidationException">
        /// The input parameters for this request failed validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/databrew-2017-07-25/UpdateRecipe">REST API Reference for UpdateRecipe Operation</seealso>
        Task<UpdateRecipeResponse> UpdateRecipeAsync(UpdateRecipeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateRecipeJob



        /// <summary>
        /// Modifies the definition of an existing DataBrew recipe job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRecipeJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateRecipeJob service method, as returned by GlueDataBrew.</returns>
        /// <exception cref="Amazon.GlueDataBrew.Model.AccessDeniedException">
        /// Access to the specified resource was denied.
        /// </exception>
        /// <exception cref="Amazon.GlueDataBrew.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.GlueDataBrew.Model.ValidationException">
        /// The input parameters for this request failed validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/databrew-2017-07-25/UpdateRecipeJob">REST API Reference for UpdateRecipeJob Operation</seealso>
        Task<UpdateRecipeJobResponse> UpdateRecipeJobAsync(UpdateRecipeJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateRuleset



        /// <summary>
        /// Updates specified ruleset.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRuleset service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateRuleset service method, as returned by GlueDataBrew.</returns>
        /// <exception cref="Amazon.GlueDataBrew.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.GlueDataBrew.Model.ValidationException">
        /// The input parameters for this request failed validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/databrew-2017-07-25/UpdateRuleset">REST API Reference for UpdateRuleset Operation</seealso>
        Task<UpdateRulesetResponse> UpdateRulesetAsync(UpdateRulesetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateSchedule



        /// <summary>
        /// Modifies the definition of an existing DataBrew schedule.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSchedule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateSchedule service method, as returned by GlueDataBrew.</returns>
        /// <exception cref="Amazon.GlueDataBrew.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.GlueDataBrew.Model.ServiceQuotaExceededException">
        /// A service quota is exceeded.
        /// </exception>
        /// <exception cref="Amazon.GlueDataBrew.Model.ValidationException">
        /// The input parameters for this request failed validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/databrew-2017-07-25/UpdateSchedule">REST API Reference for UpdateSchedule Operation</seealso>
        Task<UpdateScheduleResponse> UpdateScheduleAsync(UpdateScheduleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

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
        [System.Diagnostics.CodeAnalysis.DynamicDependency(System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypes.PublicProperties, typeof(AmazonGlueDataBrewConfig))]
        static ClientConfig IAmazonService.CreateDefaultClientConfig() => new AmazonGlueDataBrewConfig();

        /// <inheritdoc/>
        [System.Diagnostics.CodeAnalysis.UnconditionalSuppressMessage("AssemblyLoadTrimming", "IL2026:RequiresUnreferencedCode",
    Justification = "This suppression is here to ignore the warnings caused by CognitoSync. See justification in IAmazonService.")]
        static IAmazonService IAmazonService.CreateDefaultServiceClient(AWSCredentials awsCredentials, ClientConfig clientConfig)
        {
            var serviceClientConfig = clientConfig as AmazonGlueDataBrewConfig;
            if (serviceClientConfig == null)
            {
                throw new AmazonClientException("ClientConfig is not of type AmazonGlueDataBrewConfig to create AmazonGlueDataBrewClient");
            }

            return awsCredentials == null ? 
                    new AmazonGlueDataBrewClient(serviceClientConfig) :
                    new AmazonGlueDataBrewClient(awsCredentials, serviceClientConfig);
        }
#pragma warning restore CA1033
#endif
        #endregion
    }
}