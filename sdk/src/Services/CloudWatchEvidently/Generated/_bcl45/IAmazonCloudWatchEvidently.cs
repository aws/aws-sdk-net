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
 * Do not modify this file. This file is generated from the evidently-2021-02-01.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.CloudWatchEvidently.Model;

namespace Amazon.CloudWatchEvidently
{
    /// <summary>
    /// Interface for accessing CloudWatchEvidently
    ///
    /// You can use Amazon CloudWatch Evidently to safely validate new features by serving
    /// them to a specified percentage of your users while you roll out the feature. You can
    /// monitor the performance of the new feature to help you decide when to ramp up traffic
    /// to your users. This helps you reduce risk and identify unintended consequences before
    /// you fully launch the feature.
    /// 
    ///  
    /// <para>
    /// You can also conduct A/B experiments to make feature design decisions based on evidence
    /// and data. An experiment can test as many as five variations at once. Evidently collects
    /// experiment data and analyzes it using statistical methods. It also provides clear
    /// recommendations about which variations perform better. You can test both user-facing
    /// features and backend features.
    /// </para>
    /// </summary>
    public partial interface IAmazonCloudWatchEvidently : IAmazonService, IDisposable
    {

        /// <summary>
        /// Paginators for the service
        /// </summary>
        ICloudWatchEvidentlyPaginatorFactory Paginators { get; }

        
        #region  BatchEvaluateFeature


        /// <summary>
        /// This operation assigns feature variation to user sessions. For each user session,
        /// you pass in an <code>entityID</code> that represents the user. Evidently then checks
        /// the evaluation rules and assigns the variation.
        /// 
        ///  
        /// <para>
        /// The first rules that are evaluated are the override rules. If the user's <code>entityID</code>
        /// matches an override rule, the user is served the variation specified by that rule.
        /// </para>
        ///  
        /// <para>
        /// Next, if there is a launch of the feature, the user might be assigned to a variation
        /// in the launch. The chance of this depends on the percentage of users that are allocated
        /// to that launch. If the user is enrolled in the launch, the variation they are served
        /// depends on the allocation of the various feature variations used for the launch.
        /// </para>
        ///  
        /// <para>
        /// If the user is not assigned to a launch, and there is an ongoing experiment for this
        /// feature, the user might be assigned to a variation in the experiment. The chance of
        /// this depends on the percentage of users that are allocated to that experiment. If
        /// the user is enrolled in the experiment, the variation they are served depends on the
        /// allocation of the various feature variations used for the experiment. 
        /// </para>
        ///  
        /// <para>
        /// If the user is not assigned to a launch or experiment, they are served the default
        /// variation.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchEvaluateFeature service method.</param>
        /// 
        /// <returns>The response from the BatchEvaluateFeature service method, as returned by CloudWatchEvidently.</returns>
        /// <exception cref="Amazon.CloudWatchEvidently.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvidently.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvidently.Model.ThrottlingException">
        /// The request was denied because of request throttling. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvidently.Model.ValidationException">
        /// The value of a parameter in the request caused an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/evidently-2021-02-01/BatchEvaluateFeature">REST API Reference for BatchEvaluateFeature Operation</seealso>
        BatchEvaluateFeatureResponse BatchEvaluateFeature(BatchEvaluateFeatureRequest request);



        /// <summary>
        /// This operation assigns feature variation to user sessions. For each user session,
        /// you pass in an <code>entityID</code> that represents the user. Evidently then checks
        /// the evaluation rules and assigns the variation.
        /// 
        ///  
        /// <para>
        /// The first rules that are evaluated are the override rules. If the user's <code>entityID</code>
        /// matches an override rule, the user is served the variation specified by that rule.
        /// </para>
        ///  
        /// <para>
        /// Next, if there is a launch of the feature, the user might be assigned to a variation
        /// in the launch. The chance of this depends on the percentage of users that are allocated
        /// to that launch. If the user is enrolled in the launch, the variation they are served
        /// depends on the allocation of the various feature variations used for the launch.
        /// </para>
        ///  
        /// <para>
        /// If the user is not assigned to a launch, and there is an ongoing experiment for this
        /// feature, the user might be assigned to a variation in the experiment. The chance of
        /// this depends on the percentage of users that are allocated to that experiment. If
        /// the user is enrolled in the experiment, the variation they are served depends on the
        /// allocation of the various feature variations used for the experiment. 
        /// </para>
        ///  
        /// <para>
        /// If the user is not assigned to a launch or experiment, they are served the default
        /// variation.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchEvaluateFeature service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchEvaluateFeature service method, as returned by CloudWatchEvidently.</returns>
        /// <exception cref="Amazon.CloudWatchEvidently.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvidently.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvidently.Model.ThrottlingException">
        /// The request was denied because of request throttling. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvidently.Model.ValidationException">
        /// The value of a parameter in the request caused an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/evidently-2021-02-01/BatchEvaluateFeature">REST API Reference for BatchEvaluateFeature Operation</seealso>
        Task<BatchEvaluateFeatureResponse> BatchEvaluateFeatureAsync(BatchEvaluateFeatureRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateExperiment


        /// <summary>
        /// Creates an Evidently <i>experiment</i>. Before you create an experiment, you must
        /// create the feature to use for the experiment.
        /// 
        ///  
        /// <para>
        /// An experiment helps you make feature design decisions based on evidence and data.
        /// An experiment can test as many as five variations at once. Evidently collects experiment
        /// data and analyzes it by statistical methods, and provides clear recommendations about
        /// which variations perform better.
        /// </para>
        ///  
        /// <para>
        /// Don't use this operation to update an existing experiment. Instead, use <a href="https://docs.aws.amazon.com/cloudwatchevidently/latest/APIReference/API_UpdateExperiment.html">UpdateExperiment</a>.
        /// 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateExperiment service method.</param>
        /// 
        /// <returns>The response from the CreateExperiment service method, as returned by CloudWatchEvidently.</returns>
        /// <exception cref="Amazon.CloudWatchEvidently.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvidently.Model.ConflictException">
        /// A resource was in an inconsistent state during an update or a deletion.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvidently.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvidently.Model.ServiceQuotaExceededException">
        /// The request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvidently.Model.ValidationException">
        /// The value of a parameter in the request caused an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/evidently-2021-02-01/CreateExperiment">REST API Reference for CreateExperiment Operation</seealso>
        CreateExperimentResponse CreateExperiment(CreateExperimentRequest request);



        /// <summary>
        /// Creates an Evidently <i>experiment</i>. Before you create an experiment, you must
        /// create the feature to use for the experiment.
        /// 
        ///  
        /// <para>
        /// An experiment helps you make feature design decisions based on evidence and data.
        /// An experiment can test as many as five variations at once. Evidently collects experiment
        /// data and analyzes it by statistical methods, and provides clear recommendations about
        /// which variations perform better.
        /// </para>
        ///  
        /// <para>
        /// Don't use this operation to update an existing experiment. Instead, use <a href="https://docs.aws.amazon.com/cloudwatchevidently/latest/APIReference/API_UpdateExperiment.html">UpdateExperiment</a>.
        /// 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateExperiment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateExperiment service method, as returned by CloudWatchEvidently.</returns>
        /// <exception cref="Amazon.CloudWatchEvidently.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvidently.Model.ConflictException">
        /// A resource was in an inconsistent state during an update or a deletion.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvidently.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvidently.Model.ServiceQuotaExceededException">
        /// The request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvidently.Model.ValidationException">
        /// The value of a parameter in the request caused an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/evidently-2021-02-01/CreateExperiment">REST API Reference for CreateExperiment Operation</seealso>
        Task<CreateExperimentResponse> CreateExperimentAsync(CreateExperimentRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateFeature


        /// <summary>
        /// Creates an Evidently <i>feature</i> that you want to launch or test. You can define
        /// up to five variations of a feature, and use these variations in your launches and
        /// experiments. A feature must be created in a project. For information about creating
        /// a project, see <a href="https://docs.aws.amazon.com/cloudwatchevidently/latest/APIReference/API_CreateProject.html">CreateProject</a>.
        /// 
        ///  
        /// <para>
        /// Don't use this operation to update an existing feature. Instead, use <a href="https://docs.aws.amazon.com/cloudwatchevidently/latest/APIReference/API_UpdateFeature.html">UpdateFeature</a>.
        /// 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateFeature service method.</param>
        /// 
        /// <returns>The response from the CreateFeature service method, as returned by CloudWatchEvidently.</returns>
        /// <exception cref="Amazon.CloudWatchEvidently.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvidently.Model.ConflictException">
        /// A resource was in an inconsistent state during an update or a deletion.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvidently.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvidently.Model.ServiceQuotaExceededException">
        /// The request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvidently.Model.ValidationException">
        /// The value of a parameter in the request caused an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/evidently-2021-02-01/CreateFeature">REST API Reference for CreateFeature Operation</seealso>
        CreateFeatureResponse CreateFeature(CreateFeatureRequest request);



        /// <summary>
        /// Creates an Evidently <i>feature</i> that you want to launch or test. You can define
        /// up to five variations of a feature, and use these variations in your launches and
        /// experiments. A feature must be created in a project. For information about creating
        /// a project, see <a href="https://docs.aws.amazon.com/cloudwatchevidently/latest/APIReference/API_CreateProject.html">CreateProject</a>.
        /// 
        ///  
        /// <para>
        /// Don't use this operation to update an existing feature. Instead, use <a href="https://docs.aws.amazon.com/cloudwatchevidently/latest/APIReference/API_UpdateFeature.html">UpdateFeature</a>.
        /// 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateFeature service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateFeature service method, as returned by CloudWatchEvidently.</returns>
        /// <exception cref="Amazon.CloudWatchEvidently.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvidently.Model.ConflictException">
        /// A resource was in an inconsistent state during an update or a deletion.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvidently.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvidently.Model.ServiceQuotaExceededException">
        /// The request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvidently.Model.ValidationException">
        /// The value of a parameter in the request caused an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/evidently-2021-02-01/CreateFeature">REST API Reference for CreateFeature Operation</seealso>
        Task<CreateFeatureResponse> CreateFeatureAsync(CreateFeatureRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateLaunch


        /// <summary>
        /// Creates a <i>launch</i> of a given feature. Before you create a launch, you must create
        /// the feature to use for the launch.
        /// 
        ///  
        /// <para>
        /// You can use a launch to safely validate new features by serving them to a specified
        /// percentage of your users while you roll out the feature. You can monitor the performance
        /// of the new feature to help you decide when to ramp up traffic to more users. This
        /// helps you reduce risk and identify unintended consequences before you fully launch
        /// the feature.
        /// </para>
        ///  
        /// <para>
        /// Don't use this operation to update an existing launch. Instead, use <a href="https://docs.aws.amazon.com/cloudwatchevidently/latest/APIReference/API_UpdateLaunch.html">UpdateLaunch</a>.
        /// 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateLaunch service method.</param>
        /// 
        /// <returns>The response from the CreateLaunch service method, as returned by CloudWatchEvidently.</returns>
        /// <exception cref="Amazon.CloudWatchEvidently.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvidently.Model.ConflictException">
        /// A resource was in an inconsistent state during an update or a deletion.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvidently.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvidently.Model.ServiceQuotaExceededException">
        /// The request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvidently.Model.ValidationException">
        /// The value of a parameter in the request caused an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/evidently-2021-02-01/CreateLaunch">REST API Reference for CreateLaunch Operation</seealso>
        CreateLaunchResponse CreateLaunch(CreateLaunchRequest request);



        /// <summary>
        /// Creates a <i>launch</i> of a given feature. Before you create a launch, you must create
        /// the feature to use for the launch.
        /// 
        ///  
        /// <para>
        /// You can use a launch to safely validate new features by serving them to a specified
        /// percentage of your users while you roll out the feature. You can monitor the performance
        /// of the new feature to help you decide when to ramp up traffic to more users. This
        /// helps you reduce risk and identify unintended consequences before you fully launch
        /// the feature.
        /// </para>
        ///  
        /// <para>
        /// Don't use this operation to update an existing launch. Instead, use <a href="https://docs.aws.amazon.com/cloudwatchevidently/latest/APIReference/API_UpdateLaunch.html">UpdateLaunch</a>.
        /// 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateLaunch service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateLaunch service method, as returned by CloudWatchEvidently.</returns>
        /// <exception cref="Amazon.CloudWatchEvidently.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvidently.Model.ConflictException">
        /// A resource was in an inconsistent state during an update or a deletion.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvidently.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvidently.Model.ServiceQuotaExceededException">
        /// The request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvidently.Model.ValidationException">
        /// The value of a parameter in the request caused an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/evidently-2021-02-01/CreateLaunch">REST API Reference for CreateLaunch Operation</seealso>
        Task<CreateLaunchResponse> CreateLaunchAsync(CreateLaunchRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateProject


        /// <summary>
        /// Creates a project, which is the logical object in Evidently that can contain features,
        /// launches, and experiments. Use projects to group similar features together.
        /// 
        ///  
        /// <para>
        /// To update an existing project, use <a href="https://docs.aws.amazon.com/cloudwatchevidently/latest/APIReference/API_UpdateProject.html">UpdateProject</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateProject service method.</param>
        /// 
        /// <returns>The response from the CreateProject service method, as returned by CloudWatchEvidently.</returns>
        /// <exception cref="Amazon.CloudWatchEvidently.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvidently.Model.ConflictException">
        /// A resource was in an inconsistent state during an update or a deletion.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvidently.Model.ServiceQuotaExceededException">
        /// The request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvidently.Model.ValidationException">
        /// The value of a parameter in the request caused an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/evidently-2021-02-01/CreateProject">REST API Reference for CreateProject Operation</seealso>
        CreateProjectResponse CreateProject(CreateProjectRequest request);



        /// <summary>
        /// Creates a project, which is the logical object in Evidently that can contain features,
        /// launches, and experiments. Use projects to group similar features together.
        /// 
        ///  
        /// <para>
        /// To update an existing project, use <a href="https://docs.aws.amazon.com/cloudwatchevidently/latest/APIReference/API_UpdateProject.html">UpdateProject</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateProject service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateProject service method, as returned by CloudWatchEvidently.</returns>
        /// <exception cref="Amazon.CloudWatchEvidently.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvidently.Model.ConflictException">
        /// A resource was in an inconsistent state during an update or a deletion.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvidently.Model.ServiceQuotaExceededException">
        /// The request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvidently.Model.ValidationException">
        /// The value of a parameter in the request caused an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/evidently-2021-02-01/CreateProject">REST API Reference for CreateProject Operation</seealso>
        Task<CreateProjectResponse> CreateProjectAsync(CreateProjectRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteExperiment


        /// <summary>
        /// Deletes an Evidently experiment. The feature used for the experiment is not deleted.
        /// 
        ///  
        /// <para>
        /// To stop an experiment without deleting it, use <a href="https://docs.aws.amazon.com/cloudwatchevidently/latest/APIReference/API_StopExperiment.html">StopExperiment</a>.
        /// 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteExperiment service method.</param>
        /// 
        /// <returns>The response from the DeleteExperiment service method, as returned by CloudWatchEvidently.</returns>
        /// <exception cref="Amazon.CloudWatchEvidently.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvidently.Model.ConflictException">
        /// A resource was in an inconsistent state during an update or a deletion.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvidently.Model.InternalServerException">
        /// Unexpected error while processing the request. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvidently.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvidently.Model.ServiceUnavailableException">
        /// The service was unavailable. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvidently.Model.ValidationException">
        /// The value of a parameter in the request caused an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/evidently-2021-02-01/DeleteExperiment">REST API Reference for DeleteExperiment Operation</seealso>
        DeleteExperimentResponse DeleteExperiment(DeleteExperimentRequest request);



        /// <summary>
        /// Deletes an Evidently experiment. The feature used for the experiment is not deleted.
        /// 
        ///  
        /// <para>
        /// To stop an experiment without deleting it, use <a href="https://docs.aws.amazon.com/cloudwatchevidently/latest/APIReference/API_StopExperiment.html">StopExperiment</a>.
        /// 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteExperiment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteExperiment service method, as returned by CloudWatchEvidently.</returns>
        /// <exception cref="Amazon.CloudWatchEvidently.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvidently.Model.ConflictException">
        /// A resource was in an inconsistent state during an update or a deletion.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvidently.Model.InternalServerException">
        /// Unexpected error while processing the request. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvidently.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvidently.Model.ServiceUnavailableException">
        /// The service was unavailable. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvidently.Model.ValidationException">
        /// The value of a parameter in the request caused an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/evidently-2021-02-01/DeleteExperiment">REST API Reference for DeleteExperiment Operation</seealso>
        Task<DeleteExperimentResponse> DeleteExperimentAsync(DeleteExperimentRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteFeature


        /// <summary>
        /// Deletes an Evidently feature.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteFeature service method.</param>
        /// 
        /// <returns>The response from the DeleteFeature service method, as returned by CloudWatchEvidently.</returns>
        /// <exception cref="Amazon.CloudWatchEvidently.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvidently.Model.ConflictException">
        /// A resource was in an inconsistent state during an update or a deletion.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvidently.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvidently.Model.ThrottlingException">
        /// The request was denied because of request throttling. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvidently.Model.ValidationException">
        /// The value of a parameter in the request caused an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/evidently-2021-02-01/DeleteFeature">REST API Reference for DeleteFeature Operation</seealso>
        DeleteFeatureResponse DeleteFeature(DeleteFeatureRequest request);



        /// <summary>
        /// Deletes an Evidently feature.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteFeature service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteFeature service method, as returned by CloudWatchEvidently.</returns>
        /// <exception cref="Amazon.CloudWatchEvidently.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvidently.Model.ConflictException">
        /// A resource was in an inconsistent state during an update or a deletion.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvidently.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvidently.Model.ThrottlingException">
        /// The request was denied because of request throttling. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvidently.Model.ValidationException">
        /// The value of a parameter in the request caused an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/evidently-2021-02-01/DeleteFeature">REST API Reference for DeleteFeature Operation</seealso>
        Task<DeleteFeatureResponse> DeleteFeatureAsync(DeleteFeatureRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteLaunch


        /// <summary>
        /// Deletes an Evidently launch. The feature used for the launch is not deleted.
        /// 
        ///  
        /// <para>
        /// To stop a launch without deleting it, use <a href="https://docs.aws.amazon.com/cloudwatchevidently/latest/APIReference/API_StopLaunch.html">StopLaunch</a>.
        /// 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteLaunch service method.</param>
        /// 
        /// <returns>The response from the DeleteLaunch service method, as returned by CloudWatchEvidently.</returns>
        /// <exception cref="Amazon.CloudWatchEvidently.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvidently.Model.ConflictException">
        /// A resource was in an inconsistent state during an update or a deletion.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvidently.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvidently.Model.ThrottlingException">
        /// The request was denied because of request throttling. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvidently.Model.ValidationException">
        /// The value of a parameter in the request caused an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/evidently-2021-02-01/DeleteLaunch">REST API Reference for DeleteLaunch Operation</seealso>
        DeleteLaunchResponse DeleteLaunch(DeleteLaunchRequest request);



        /// <summary>
        /// Deletes an Evidently launch. The feature used for the launch is not deleted.
        /// 
        ///  
        /// <para>
        /// To stop a launch without deleting it, use <a href="https://docs.aws.amazon.com/cloudwatchevidently/latest/APIReference/API_StopLaunch.html">StopLaunch</a>.
        /// 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteLaunch service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteLaunch service method, as returned by CloudWatchEvidently.</returns>
        /// <exception cref="Amazon.CloudWatchEvidently.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvidently.Model.ConflictException">
        /// A resource was in an inconsistent state during an update or a deletion.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvidently.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvidently.Model.ThrottlingException">
        /// The request was denied because of request throttling. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvidently.Model.ValidationException">
        /// The value of a parameter in the request caused an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/evidently-2021-02-01/DeleteLaunch">REST API Reference for DeleteLaunch Operation</seealso>
        Task<DeleteLaunchResponse> DeleteLaunchAsync(DeleteLaunchRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteProject


        /// <summary>
        /// Deletes an Evidently project. Before you can delete a project, you must delete all
        /// the features that the project contains. To delete a feature, use <a href="https://docs.aws.amazon.com/cloudwatchevidently/latest/APIReference/API_DeleteFeature.html">DeleteFeature</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteProject service method.</param>
        /// 
        /// <returns>The response from the DeleteProject service method, as returned by CloudWatchEvidently.</returns>
        /// <exception cref="Amazon.CloudWatchEvidently.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvidently.Model.ConflictException">
        /// A resource was in an inconsistent state during an update or a deletion.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvidently.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvidently.Model.ThrottlingException">
        /// The request was denied because of request throttling. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvidently.Model.ValidationException">
        /// The value of a parameter in the request caused an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/evidently-2021-02-01/DeleteProject">REST API Reference for DeleteProject Operation</seealso>
        DeleteProjectResponse DeleteProject(DeleteProjectRequest request);



        /// <summary>
        /// Deletes an Evidently project. Before you can delete a project, you must delete all
        /// the features that the project contains. To delete a feature, use <a href="https://docs.aws.amazon.com/cloudwatchevidently/latest/APIReference/API_DeleteFeature.html">DeleteFeature</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteProject service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteProject service method, as returned by CloudWatchEvidently.</returns>
        /// <exception cref="Amazon.CloudWatchEvidently.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvidently.Model.ConflictException">
        /// A resource was in an inconsistent state during an update or a deletion.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvidently.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvidently.Model.ThrottlingException">
        /// The request was denied because of request throttling. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvidently.Model.ValidationException">
        /// The value of a parameter in the request caused an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/evidently-2021-02-01/DeleteProject">REST API Reference for DeleteProject Operation</seealso>
        Task<DeleteProjectResponse> DeleteProjectAsync(DeleteProjectRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  EvaluateFeature


        /// <summary>
        /// This operation assigns a feature variation to one given user session. You pass in
        /// an <code>entityID</code> that represents the user. Evidently then checks the evaluation
        /// rules and assigns the variation.
        /// 
        ///  
        /// <para>
        /// The first rules that are evaluated are the override rules. If the user's <code>entityID</code>
        /// matches an override rule, the user is served the variation specified by that rule.
        /// </para>
        ///  
        /// <para>
        /// Next, if there is a launch of the feature, the user might be assigned to a variation
        /// in the launch. The chance of this depends on the percentage of users that are allocated
        /// to that launch. If the user is enrolled in the launch, the variation they are served
        /// depends on the allocation of the various feature variations used for the launch.
        /// </para>
        ///  
        /// <para>
        /// If the user is not assigned to a launch, and there is an ongoing experiment for this
        /// feature, the user might be assigned to a variation in the experiment. The chance of
        /// this depends on the percentage of users that are allocated to that experiment. If
        /// the user is enrolled in the experiment, the variation they are served depends on the
        /// allocation of the various feature variations used for the experiment. 
        /// </para>
        ///  
        /// <para>
        /// If the user is not assigned to a launch or experiment, they are served the default
        /// variation.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EvaluateFeature service method.</param>
        /// 
        /// <returns>The response from the EvaluateFeature service method, as returned by CloudWatchEvidently.</returns>
        /// <exception cref="Amazon.CloudWatchEvidently.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvidently.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvidently.Model.ThrottlingException">
        /// The request was denied because of request throttling. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvidently.Model.ValidationException">
        /// The value of a parameter in the request caused an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/evidently-2021-02-01/EvaluateFeature">REST API Reference for EvaluateFeature Operation</seealso>
        EvaluateFeatureResponse EvaluateFeature(EvaluateFeatureRequest request);



        /// <summary>
        /// This operation assigns a feature variation to one given user session. You pass in
        /// an <code>entityID</code> that represents the user. Evidently then checks the evaluation
        /// rules and assigns the variation.
        /// 
        ///  
        /// <para>
        /// The first rules that are evaluated are the override rules. If the user's <code>entityID</code>
        /// matches an override rule, the user is served the variation specified by that rule.
        /// </para>
        ///  
        /// <para>
        /// Next, if there is a launch of the feature, the user might be assigned to a variation
        /// in the launch. The chance of this depends on the percentage of users that are allocated
        /// to that launch. If the user is enrolled in the launch, the variation they are served
        /// depends on the allocation of the various feature variations used for the launch.
        /// </para>
        ///  
        /// <para>
        /// If the user is not assigned to a launch, and there is an ongoing experiment for this
        /// feature, the user might be assigned to a variation in the experiment. The chance of
        /// this depends on the percentage of users that are allocated to that experiment. If
        /// the user is enrolled in the experiment, the variation they are served depends on the
        /// allocation of the various feature variations used for the experiment. 
        /// </para>
        ///  
        /// <para>
        /// If the user is not assigned to a launch or experiment, they are served the default
        /// variation.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EvaluateFeature service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the EvaluateFeature service method, as returned by CloudWatchEvidently.</returns>
        /// <exception cref="Amazon.CloudWatchEvidently.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvidently.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvidently.Model.ThrottlingException">
        /// The request was denied because of request throttling. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvidently.Model.ValidationException">
        /// The value of a parameter in the request caused an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/evidently-2021-02-01/EvaluateFeature">REST API Reference for EvaluateFeature Operation</seealso>
        Task<EvaluateFeatureResponse> EvaluateFeatureAsync(EvaluateFeatureRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetExperiment


        /// <summary>
        /// Returns the details about one experiment. You must already know the experiment name.
        /// To retrieve a list of experiments in your account, use <a href="https://docs.aws.amazon.com/cloudwatchevidently/latest/APIReference/API_ListExperiments.html">ListExperiments</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetExperiment service method.</param>
        /// 
        /// <returns>The response from the GetExperiment service method, as returned by CloudWatchEvidently.</returns>
        /// <exception cref="Amazon.CloudWatchEvidently.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvidently.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvidently.Model.ThrottlingException">
        /// The request was denied because of request throttling. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvidently.Model.ValidationException">
        /// The value of a parameter in the request caused an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/evidently-2021-02-01/GetExperiment">REST API Reference for GetExperiment Operation</seealso>
        GetExperimentResponse GetExperiment(GetExperimentRequest request);



        /// <summary>
        /// Returns the details about one experiment. You must already know the experiment name.
        /// To retrieve a list of experiments in your account, use <a href="https://docs.aws.amazon.com/cloudwatchevidently/latest/APIReference/API_ListExperiments.html">ListExperiments</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetExperiment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetExperiment service method, as returned by CloudWatchEvidently.</returns>
        /// <exception cref="Amazon.CloudWatchEvidently.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvidently.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvidently.Model.ThrottlingException">
        /// The request was denied because of request throttling. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvidently.Model.ValidationException">
        /// The value of a parameter in the request caused an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/evidently-2021-02-01/GetExperiment">REST API Reference for GetExperiment Operation</seealso>
        Task<GetExperimentResponse> GetExperimentAsync(GetExperimentRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetExperimentResults


        /// <summary>
        /// Retrieves the results of a running or completed experiment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetExperimentResults service method.</param>
        /// 
        /// <returns>The response from the GetExperimentResults service method, as returned by CloudWatchEvidently.</returns>
        /// <exception cref="Amazon.CloudWatchEvidently.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvidently.Model.ConflictException">
        /// A resource was in an inconsistent state during an update or a deletion.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvidently.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvidently.Model.ThrottlingException">
        /// The request was denied because of request throttling. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvidently.Model.ValidationException">
        /// The value of a parameter in the request caused an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/evidently-2021-02-01/GetExperimentResults">REST API Reference for GetExperimentResults Operation</seealso>
        GetExperimentResultsResponse GetExperimentResults(GetExperimentResultsRequest request);



        /// <summary>
        /// Retrieves the results of a running or completed experiment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetExperimentResults service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetExperimentResults service method, as returned by CloudWatchEvidently.</returns>
        /// <exception cref="Amazon.CloudWatchEvidently.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvidently.Model.ConflictException">
        /// A resource was in an inconsistent state during an update or a deletion.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvidently.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvidently.Model.ThrottlingException">
        /// The request was denied because of request throttling. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvidently.Model.ValidationException">
        /// The value of a parameter in the request caused an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/evidently-2021-02-01/GetExperimentResults">REST API Reference for GetExperimentResults Operation</seealso>
        Task<GetExperimentResultsResponse> GetExperimentResultsAsync(GetExperimentResultsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetFeature


        /// <summary>
        /// Returns the details about one feature. You must already know the feature name. To
        /// retrieve a list of features in your account, use <a href="https://docs.aws.amazon.com/cloudwatchevidently/latest/APIReference/API_ListFeatures.html">ListFeatures</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetFeature service method.</param>
        /// 
        /// <returns>The response from the GetFeature service method, as returned by CloudWatchEvidently.</returns>
        /// <exception cref="Amazon.CloudWatchEvidently.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvidently.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvidently.Model.ThrottlingException">
        /// The request was denied because of request throttling. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvidently.Model.ValidationException">
        /// The value of a parameter in the request caused an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/evidently-2021-02-01/GetFeature">REST API Reference for GetFeature Operation</seealso>
        GetFeatureResponse GetFeature(GetFeatureRequest request);



        /// <summary>
        /// Returns the details about one feature. You must already know the feature name. To
        /// retrieve a list of features in your account, use <a href="https://docs.aws.amazon.com/cloudwatchevidently/latest/APIReference/API_ListFeatures.html">ListFeatures</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetFeature service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetFeature service method, as returned by CloudWatchEvidently.</returns>
        /// <exception cref="Amazon.CloudWatchEvidently.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvidently.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvidently.Model.ThrottlingException">
        /// The request was denied because of request throttling. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvidently.Model.ValidationException">
        /// The value of a parameter in the request caused an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/evidently-2021-02-01/GetFeature">REST API Reference for GetFeature Operation</seealso>
        Task<GetFeatureResponse> GetFeatureAsync(GetFeatureRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetLaunch


        /// <summary>
        /// Returns the details about one launch. You must already know the launch name. To retrieve
        /// a list of launches in your account, use <a href="https://docs.aws.amazon.com/cloudwatchevidently/latest/APIReference/API_ListLaunches.html">ListLaunches</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetLaunch service method.</param>
        /// 
        /// <returns>The response from the GetLaunch service method, as returned by CloudWatchEvidently.</returns>
        /// <exception cref="Amazon.CloudWatchEvidently.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvidently.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvidently.Model.ThrottlingException">
        /// The request was denied because of request throttling. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvidently.Model.ValidationException">
        /// The value of a parameter in the request caused an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/evidently-2021-02-01/GetLaunch">REST API Reference for GetLaunch Operation</seealso>
        GetLaunchResponse GetLaunch(GetLaunchRequest request);



        /// <summary>
        /// Returns the details about one launch. You must already know the launch name. To retrieve
        /// a list of launches in your account, use <a href="https://docs.aws.amazon.com/cloudwatchevidently/latest/APIReference/API_ListLaunches.html">ListLaunches</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetLaunch service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetLaunch service method, as returned by CloudWatchEvidently.</returns>
        /// <exception cref="Amazon.CloudWatchEvidently.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvidently.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvidently.Model.ThrottlingException">
        /// The request was denied because of request throttling. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvidently.Model.ValidationException">
        /// The value of a parameter in the request caused an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/evidently-2021-02-01/GetLaunch">REST API Reference for GetLaunch Operation</seealso>
        Task<GetLaunchResponse> GetLaunchAsync(GetLaunchRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetProject


        /// <summary>
        /// Returns the details about one launch. You must already know the project name. To retrieve
        /// a list of projects in your account, use <a href="https://docs.aws.amazon.com/cloudwatchevidently/latest/APIReference/API_ListProjects.html">ListProjects</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetProject service method.</param>
        /// 
        /// <returns>The response from the GetProject service method, as returned by CloudWatchEvidently.</returns>
        /// <exception cref="Amazon.CloudWatchEvidently.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvidently.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvidently.Model.ThrottlingException">
        /// The request was denied because of request throttling. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvidently.Model.ValidationException">
        /// The value of a parameter in the request caused an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/evidently-2021-02-01/GetProject">REST API Reference for GetProject Operation</seealso>
        GetProjectResponse GetProject(GetProjectRequest request);



        /// <summary>
        /// Returns the details about one launch. You must already know the project name. To retrieve
        /// a list of projects in your account, use <a href="https://docs.aws.amazon.com/cloudwatchevidently/latest/APIReference/API_ListProjects.html">ListProjects</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetProject service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetProject service method, as returned by CloudWatchEvidently.</returns>
        /// <exception cref="Amazon.CloudWatchEvidently.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvidently.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvidently.Model.ThrottlingException">
        /// The request was denied because of request throttling. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvidently.Model.ValidationException">
        /// The value of a parameter in the request caused an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/evidently-2021-02-01/GetProject">REST API Reference for GetProject Operation</seealso>
        Task<GetProjectResponse> GetProjectAsync(GetProjectRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListExperiments


        /// <summary>
        /// Returns configuration details about all the experiments in the specified project.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListExperiments service method.</param>
        /// 
        /// <returns>The response from the ListExperiments service method, as returned by CloudWatchEvidently.</returns>
        /// <exception cref="Amazon.CloudWatchEvidently.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvidently.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvidently.Model.ValidationException">
        /// The value of a parameter in the request caused an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/evidently-2021-02-01/ListExperiments">REST API Reference for ListExperiments Operation</seealso>
        ListExperimentsResponse ListExperiments(ListExperimentsRequest request);



        /// <summary>
        /// Returns configuration details about all the experiments in the specified project.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListExperiments service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListExperiments service method, as returned by CloudWatchEvidently.</returns>
        /// <exception cref="Amazon.CloudWatchEvidently.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvidently.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvidently.Model.ValidationException">
        /// The value of a parameter in the request caused an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/evidently-2021-02-01/ListExperiments">REST API Reference for ListExperiments Operation</seealso>
        Task<ListExperimentsResponse> ListExperimentsAsync(ListExperimentsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListFeatures


        /// <summary>
        /// Returns configuration details about all the features in the specified project.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFeatures service method.</param>
        /// 
        /// <returns>The response from the ListFeatures service method, as returned by CloudWatchEvidently.</returns>
        /// <exception cref="Amazon.CloudWatchEvidently.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvidently.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvidently.Model.ThrottlingException">
        /// The request was denied because of request throttling. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvidently.Model.ValidationException">
        /// The value of a parameter in the request caused an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/evidently-2021-02-01/ListFeatures">REST API Reference for ListFeatures Operation</seealso>
        ListFeaturesResponse ListFeatures(ListFeaturesRequest request);



        /// <summary>
        /// Returns configuration details about all the features in the specified project.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFeatures service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListFeatures service method, as returned by CloudWatchEvidently.</returns>
        /// <exception cref="Amazon.CloudWatchEvidently.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvidently.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvidently.Model.ThrottlingException">
        /// The request was denied because of request throttling. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvidently.Model.ValidationException">
        /// The value of a parameter in the request caused an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/evidently-2021-02-01/ListFeatures">REST API Reference for ListFeatures Operation</seealso>
        Task<ListFeaturesResponse> ListFeaturesAsync(ListFeaturesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListLaunches


        /// <summary>
        /// Returns configuration details about all the launches in the specified project.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListLaunches service method.</param>
        /// 
        /// <returns>The response from the ListLaunches service method, as returned by CloudWatchEvidently.</returns>
        /// <exception cref="Amazon.CloudWatchEvidently.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvidently.Model.ThrottlingException">
        /// The request was denied because of request throttling. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvidently.Model.ValidationException">
        /// The value of a parameter in the request caused an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/evidently-2021-02-01/ListLaunches">REST API Reference for ListLaunches Operation</seealso>
        ListLaunchesResponse ListLaunches(ListLaunchesRequest request);



        /// <summary>
        /// Returns configuration details about all the launches in the specified project.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListLaunches service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListLaunches service method, as returned by CloudWatchEvidently.</returns>
        /// <exception cref="Amazon.CloudWatchEvidently.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvidently.Model.ThrottlingException">
        /// The request was denied because of request throttling. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvidently.Model.ValidationException">
        /// The value of a parameter in the request caused an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/evidently-2021-02-01/ListLaunches">REST API Reference for ListLaunches Operation</seealso>
        Task<ListLaunchesResponse> ListLaunchesAsync(ListLaunchesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListProjects


        /// <summary>
        /// Returns configuration details about all the projects in the current Region in your
        /// account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListProjects service method.</param>
        /// 
        /// <returns>The response from the ListProjects service method, as returned by CloudWatchEvidently.</returns>
        /// <exception cref="Amazon.CloudWatchEvidently.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvidently.Model.ThrottlingException">
        /// The request was denied because of request throttling. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvidently.Model.ValidationException">
        /// The value of a parameter in the request caused an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/evidently-2021-02-01/ListProjects">REST API Reference for ListProjects Operation</seealso>
        ListProjectsResponse ListProjects(ListProjectsRequest request);



        /// <summary>
        /// Returns configuration details about all the projects in the current Region in your
        /// account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListProjects service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListProjects service method, as returned by CloudWatchEvidently.</returns>
        /// <exception cref="Amazon.CloudWatchEvidently.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvidently.Model.ThrottlingException">
        /// The request was denied because of request throttling. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvidently.Model.ValidationException">
        /// The value of a parameter in the request caused an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/evidently-2021-02-01/ListProjects">REST API Reference for ListProjects Operation</seealso>
        Task<ListProjectsResponse> ListProjectsAsync(ListProjectsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// Displays the tags associated with an Evidently resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by CloudWatchEvidently.</returns>
        /// <exception cref="Amazon.CloudWatchEvidently.Model.ConflictException">
        /// A resource was in an inconsistent state during an update or a deletion.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvidently.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvidently.Model.ValidationException">
        /// The value of a parameter in the request caused an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/evidently-2021-02-01/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request);



        /// <summary>
        /// Displays the tags associated with an Evidently resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by CloudWatchEvidently.</returns>
        /// <exception cref="Amazon.CloudWatchEvidently.Model.ConflictException">
        /// A resource was in an inconsistent state during an update or a deletion.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvidently.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvidently.Model.ValidationException">
        /// The value of a parameter in the request caused an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/evidently-2021-02-01/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  PutProjectEvents


        /// <summary>
        /// Sends performance events to Evidently. These events can be used to evaluate a launch
        /// or an experiment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutProjectEvents service method.</param>
        /// 
        /// <returns>The response from the PutProjectEvents service method, as returned by CloudWatchEvidently.</returns>
        /// <exception cref="Amazon.CloudWatchEvidently.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvidently.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvidently.Model.ThrottlingException">
        /// The request was denied because of request throttling. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvidently.Model.ValidationException">
        /// The value of a parameter in the request caused an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/evidently-2021-02-01/PutProjectEvents">REST API Reference for PutProjectEvents Operation</seealso>
        PutProjectEventsResponse PutProjectEvents(PutProjectEventsRequest request);



        /// <summary>
        /// Sends performance events to Evidently. These events can be used to evaluate a launch
        /// or an experiment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutProjectEvents service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutProjectEvents service method, as returned by CloudWatchEvidently.</returns>
        /// <exception cref="Amazon.CloudWatchEvidently.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvidently.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvidently.Model.ThrottlingException">
        /// The request was denied because of request throttling. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvidently.Model.ValidationException">
        /// The value of a parameter in the request caused an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/evidently-2021-02-01/PutProjectEvents">REST API Reference for PutProjectEvents Operation</seealso>
        Task<PutProjectEventsResponse> PutProjectEventsAsync(PutProjectEventsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  StartExperiment


        /// <summary>
        /// Starts an existing experiment. To create an experiment, use <a href="https://docs.aws.amazon.com/cloudwatchevidently/latest/APIReference/API_CreateExperiment.html">CreateExperiment</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartExperiment service method.</param>
        /// 
        /// <returns>The response from the StartExperiment service method, as returned by CloudWatchEvidently.</returns>
        /// <exception cref="Amazon.CloudWatchEvidently.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvidently.Model.ConflictException">
        /// A resource was in an inconsistent state during an update or a deletion.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvidently.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvidently.Model.ServiceQuotaExceededException">
        /// The request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvidently.Model.ThrottlingException">
        /// The request was denied because of request throttling. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvidently.Model.ValidationException">
        /// The value of a parameter in the request caused an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/evidently-2021-02-01/StartExperiment">REST API Reference for StartExperiment Operation</seealso>
        StartExperimentResponse StartExperiment(StartExperimentRequest request);



        /// <summary>
        /// Starts an existing experiment. To create an experiment, use <a href="https://docs.aws.amazon.com/cloudwatchevidently/latest/APIReference/API_CreateExperiment.html">CreateExperiment</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartExperiment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartExperiment service method, as returned by CloudWatchEvidently.</returns>
        /// <exception cref="Amazon.CloudWatchEvidently.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvidently.Model.ConflictException">
        /// A resource was in an inconsistent state during an update or a deletion.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvidently.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvidently.Model.ServiceQuotaExceededException">
        /// The request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvidently.Model.ThrottlingException">
        /// The request was denied because of request throttling. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvidently.Model.ValidationException">
        /// The value of a parameter in the request caused an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/evidently-2021-02-01/StartExperiment">REST API Reference for StartExperiment Operation</seealso>
        Task<StartExperimentResponse> StartExperimentAsync(StartExperimentRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  StartLaunch


        /// <summary>
        /// Starts an existing launch. To create a launch, use <a href="https://docs.aws.amazon.com/cloudwatchevidently/latest/APIReference/API_CreateLaunch.html">CreateLaunch</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartLaunch service method.</param>
        /// 
        /// <returns>The response from the StartLaunch service method, as returned by CloudWatchEvidently.</returns>
        /// <exception cref="Amazon.CloudWatchEvidently.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvidently.Model.ConflictException">
        /// A resource was in an inconsistent state during an update or a deletion.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvidently.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvidently.Model.ServiceQuotaExceededException">
        /// The request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvidently.Model.ThrottlingException">
        /// The request was denied because of request throttling. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvidently.Model.ValidationException">
        /// The value of a parameter in the request caused an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/evidently-2021-02-01/StartLaunch">REST API Reference for StartLaunch Operation</seealso>
        StartLaunchResponse StartLaunch(StartLaunchRequest request);



        /// <summary>
        /// Starts an existing launch. To create a launch, use <a href="https://docs.aws.amazon.com/cloudwatchevidently/latest/APIReference/API_CreateLaunch.html">CreateLaunch</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartLaunch service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartLaunch service method, as returned by CloudWatchEvidently.</returns>
        /// <exception cref="Amazon.CloudWatchEvidently.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvidently.Model.ConflictException">
        /// A resource was in an inconsistent state during an update or a deletion.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvidently.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvidently.Model.ServiceQuotaExceededException">
        /// The request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvidently.Model.ThrottlingException">
        /// The request was denied because of request throttling. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvidently.Model.ValidationException">
        /// The value of a parameter in the request caused an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/evidently-2021-02-01/StartLaunch">REST API Reference for StartLaunch Operation</seealso>
        Task<StartLaunchResponse> StartLaunchAsync(StartLaunchRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  StopExperiment


        /// <summary>
        /// Stops an experiment that is currently running. If you stop an experiment, you can't
        /// resume it or restart it.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopExperiment service method.</param>
        /// 
        /// <returns>The response from the StopExperiment service method, as returned by CloudWatchEvidently.</returns>
        /// <exception cref="Amazon.CloudWatchEvidently.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvidently.Model.ConflictException">
        /// A resource was in an inconsistent state during an update or a deletion.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvidently.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvidently.Model.ServiceQuotaExceededException">
        /// The request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvidently.Model.ThrottlingException">
        /// The request was denied because of request throttling. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvidently.Model.ValidationException">
        /// The value of a parameter in the request caused an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/evidently-2021-02-01/StopExperiment">REST API Reference for StopExperiment Operation</seealso>
        StopExperimentResponse StopExperiment(StopExperimentRequest request);



        /// <summary>
        /// Stops an experiment that is currently running. If you stop an experiment, you can't
        /// resume it or restart it.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopExperiment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StopExperiment service method, as returned by CloudWatchEvidently.</returns>
        /// <exception cref="Amazon.CloudWatchEvidently.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvidently.Model.ConflictException">
        /// A resource was in an inconsistent state during an update or a deletion.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvidently.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvidently.Model.ServiceQuotaExceededException">
        /// The request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvidently.Model.ThrottlingException">
        /// The request was denied because of request throttling. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvidently.Model.ValidationException">
        /// The value of a parameter in the request caused an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/evidently-2021-02-01/StopExperiment">REST API Reference for StopExperiment Operation</seealso>
        Task<StopExperimentResponse> StopExperimentAsync(StopExperimentRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  StopLaunch


        /// <summary>
        /// Stops a launch that is currently running. After you stop a launch, you will not be
        /// able to resume it or restart it. Also, it will not be evaluated as a rule for traffic
        /// allocation, and the traffic that was allocated to the launch will instead be available
        /// to the feature's experiment, if there is one. Otherwise, all traffic will be served
        /// the default variation after the launch is stopped.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopLaunch service method.</param>
        /// 
        /// <returns>The response from the StopLaunch service method, as returned by CloudWatchEvidently.</returns>
        /// <exception cref="Amazon.CloudWatchEvidently.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvidently.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvidently.Model.ThrottlingException">
        /// The request was denied because of request throttling. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvidently.Model.ValidationException">
        /// The value of a parameter in the request caused an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/evidently-2021-02-01/StopLaunch">REST API Reference for StopLaunch Operation</seealso>
        StopLaunchResponse StopLaunch(StopLaunchRequest request);



        /// <summary>
        /// Stops a launch that is currently running. After you stop a launch, you will not be
        /// able to resume it or restart it. Also, it will not be evaluated as a rule for traffic
        /// allocation, and the traffic that was allocated to the launch will instead be available
        /// to the feature's experiment, if there is one. Otherwise, all traffic will be served
        /// the default variation after the launch is stopped.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopLaunch service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StopLaunch service method, as returned by CloudWatchEvidently.</returns>
        /// <exception cref="Amazon.CloudWatchEvidently.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvidently.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvidently.Model.ThrottlingException">
        /// The request was denied because of request throttling. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvidently.Model.ValidationException">
        /// The value of a parameter in the request caused an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/evidently-2021-02-01/StopLaunch">REST API Reference for StopLaunch Operation</seealso>
        Task<StopLaunchResponse> StopLaunchAsync(StopLaunchRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Assigns one or more tags (key-value pairs) to the specified CloudWatch Evidently resource.
        /// Projects, features, launches, and experiments can be tagged.
        /// 
        ///  
        /// <para>
        /// Tags can help you organize and categorize your resources. You can also use them to
        /// scope user permissions by granting a user permission to access or change only resources
        /// with certain tag values.
        /// </para>
        ///  
        /// <para>
        /// Tags don't have any semantic meaning to Amazon Web Services and are interpreted strictly
        /// as strings of characters.
        /// </para>
        ///  
        /// <para>
        /// You can use the <code>TagResource</code> action with a resource that already has tags.
        /// If you specify a new tag key for the resource, this tag is appended to the list of
        /// tags associated with the alarm. If you specify a tag key that is already associated
        /// with the resource, the new tag value that you specify replaces the previous value
        /// for that tag.
        /// </para>
        ///  
        /// <para>
        /// You can associate as many as 50 tags with a resource.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/general/latest/gr/aws_tagging.html">Tagging
        /// Amazon Web Services resources</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by CloudWatchEvidently.</returns>
        /// <exception cref="Amazon.CloudWatchEvidently.Model.ConflictException">
        /// A resource was in an inconsistent state during an update or a deletion.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvidently.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvidently.Model.ValidationException">
        /// The value of a parameter in the request caused an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/evidently-2021-02-01/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse TagResource(TagResourceRequest request);



        /// <summary>
        /// Assigns one or more tags (key-value pairs) to the specified CloudWatch Evidently resource.
        /// Projects, features, launches, and experiments can be tagged.
        /// 
        ///  
        /// <para>
        /// Tags can help you organize and categorize your resources. You can also use them to
        /// scope user permissions by granting a user permission to access or change only resources
        /// with certain tag values.
        /// </para>
        ///  
        /// <para>
        /// Tags don't have any semantic meaning to Amazon Web Services and are interpreted strictly
        /// as strings of characters.
        /// </para>
        ///  
        /// <para>
        /// You can use the <code>TagResource</code> action with a resource that already has tags.
        /// If you specify a new tag key for the resource, this tag is appended to the list of
        /// tags associated with the alarm. If you specify a tag key that is already associated
        /// with the resource, the new tag value that you specify replaces the previous value
        /// for that tag.
        /// </para>
        ///  
        /// <para>
        /// You can associate as many as 50 tags with a resource.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/general/latest/gr/aws_tagging.html">Tagging
        /// Amazon Web Services resources</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by CloudWatchEvidently.</returns>
        /// <exception cref="Amazon.CloudWatchEvidently.Model.ConflictException">
        /// A resource was in an inconsistent state during an update or a deletion.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvidently.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvidently.Model.ValidationException">
        /// The value of a parameter in the request caused an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/evidently-2021-02-01/TagResource">REST API Reference for TagResource Operation</seealso>
        Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// Removes one or more tags from the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by CloudWatchEvidently.</returns>
        /// <exception cref="Amazon.CloudWatchEvidently.Model.ConflictException">
        /// A resource was in an inconsistent state during an update or a deletion.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvidently.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvidently.Model.ValidationException">
        /// The value of a parameter in the request caused an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/evidently-2021-02-01/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse UntagResource(UntagResourceRequest request);



        /// <summary>
        /// Removes one or more tags from the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by CloudWatchEvidently.</returns>
        /// <exception cref="Amazon.CloudWatchEvidently.Model.ConflictException">
        /// A resource was in an inconsistent state during an update or a deletion.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvidently.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvidently.Model.ValidationException">
        /// The value of a parameter in the request caused an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/evidently-2021-02-01/UntagResource">REST API Reference for UntagResource Operation</seealso>
        Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateExperiment


        /// <summary>
        /// Updates an Evidently experiment. 
        /// 
        ///  
        /// <para>
        /// Don't use this operation to update an experiment's tag. Instead, use <a href="https://docs.aws.amazon.com/cloudwatchevidently/latest/APIReference/API_TagResource.html">TagResource</a>.
        /// 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateExperiment service method.</param>
        /// 
        /// <returns>The response from the UpdateExperiment service method, as returned by CloudWatchEvidently.</returns>
        /// <exception cref="Amazon.CloudWatchEvidently.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvidently.Model.ConflictException">
        /// A resource was in an inconsistent state during an update or a deletion.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvidently.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvidently.Model.ValidationException">
        /// The value of a parameter in the request caused an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/evidently-2021-02-01/UpdateExperiment">REST API Reference for UpdateExperiment Operation</seealso>
        UpdateExperimentResponse UpdateExperiment(UpdateExperimentRequest request);



        /// <summary>
        /// Updates an Evidently experiment. 
        /// 
        ///  
        /// <para>
        /// Don't use this operation to update an experiment's tag. Instead, use <a href="https://docs.aws.amazon.com/cloudwatchevidently/latest/APIReference/API_TagResource.html">TagResource</a>.
        /// 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateExperiment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateExperiment service method, as returned by CloudWatchEvidently.</returns>
        /// <exception cref="Amazon.CloudWatchEvidently.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvidently.Model.ConflictException">
        /// A resource was in an inconsistent state during an update or a deletion.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvidently.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvidently.Model.ValidationException">
        /// The value of a parameter in the request caused an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/evidently-2021-02-01/UpdateExperiment">REST API Reference for UpdateExperiment Operation</seealso>
        Task<UpdateExperimentResponse> UpdateExperimentAsync(UpdateExperimentRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateFeature


        /// <summary>
        /// Updates an existing feature.
        /// 
        ///  
        /// <para>
        /// You can't use this operation to update the tags of an existing feature. Instead, use
        /// <a href="https://docs.aws.amazon.com/cloudwatchevidently/latest/APIReference/API_TagResource.html">TagResource</a>.
        /// 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateFeature service method.</param>
        /// 
        /// <returns>The response from the UpdateFeature service method, as returned by CloudWatchEvidently.</returns>
        /// <exception cref="Amazon.CloudWatchEvidently.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvidently.Model.ConflictException">
        /// A resource was in an inconsistent state during an update or a deletion.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvidently.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvidently.Model.ServiceQuotaExceededException">
        /// The request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvidently.Model.ValidationException">
        /// The value of a parameter in the request caused an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/evidently-2021-02-01/UpdateFeature">REST API Reference for UpdateFeature Operation</seealso>
        UpdateFeatureResponse UpdateFeature(UpdateFeatureRequest request);



        /// <summary>
        /// Updates an existing feature.
        /// 
        ///  
        /// <para>
        /// You can't use this operation to update the tags of an existing feature. Instead, use
        /// <a href="https://docs.aws.amazon.com/cloudwatchevidently/latest/APIReference/API_TagResource.html">TagResource</a>.
        /// 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateFeature service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateFeature service method, as returned by CloudWatchEvidently.</returns>
        /// <exception cref="Amazon.CloudWatchEvidently.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvidently.Model.ConflictException">
        /// A resource was in an inconsistent state during an update or a deletion.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvidently.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvidently.Model.ServiceQuotaExceededException">
        /// The request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvidently.Model.ValidationException">
        /// The value of a parameter in the request caused an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/evidently-2021-02-01/UpdateFeature">REST API Reference for UpdateFeature Operation</seealso>
        Task<UpdateFeatureResponse> UpdateFeatureAsync(UpdateFeatureRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateLaunch


        /// <summary>
        /// Updates a launch of a given feature. 
        /// 
        ///  
        /// <para>
        /// Don't use this operation to update the tags of an existing launch. Instead, use <a
        /// href="https://docs.aws.amazon.com/cloudwatchevidently/latest/APIReference/API_TagResource.html">TagResource</a>.
        /// 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateLaunch service method.</param>
        /// 
        /// <returns>The response from the UpdateLaunch service method, as returned by CloudWatchEvidently.</returns>
        /// <exception cref="Amazon.CloudWatchEvidently.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvidently.Model.ConflictException">
        /// A resource was in an inconsistent state during an update or a deletion.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvidently.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvidently.Model.ValidationException">
        /// The value of a parameter in the request caused an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/evidently-2021-02-01/UpdateLaunch">REST API Reference for UpdateLaunch Operation</seealso>
        UpdateLaunchResponse UpdateLaunch(UpdateLaunchRequest request);



        /// <summary>
        /// Updates a launch of a given feature. 
        /// 
        ///  
        /// <para>
        /// Don't use this operation to update the tags of an existing launch. Instead, use <a
        /// href="https://docs.aws.amazon.com/cloudwatchevidently/latest/APIReference/API_TagResource.html">TagResource</a>.
        /// 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateLaunch service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateLaunch service method, as returned by CloudWatchEvidently.</returns>
        /// <exception cref="Amazon.CloudWatchEvidently.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvidently.Model.ConflictException">
        /// A resource was in an inconsistent state during an update or a deletion.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvidently.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvidently.Model.ValidationException">
        /// The value of a parameter in the request caused an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/evidently-2021-02-01/UpdateLaunch">REST API Reference for UpdateLaunch Operation</seealso>
        Task<UpdateLaunchResponse> UpdateLaunchAsync(UpdateLaunchRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateProject


        /// <summary>
        /// Updates the description of an existing project.
        /// 
        ///  
        /// <para>
        /// To create a new project, use <a href="https://docs.aws.amazon.com/cloudwatchevidently/latest/APIReference/API_CreateProject.html">CreateProject</a>.
        /// </para>
        ///  
        /// <para>
        /// Don't use this operation to update the data storage options of a project. Instead,
        /// use <a href="https://docs.aws.amazon.com/cloudwatchevidently/latest/APIReference/API_UpdateProjectDataDelivery.html">UpdateProjectDataDelivery</a>.
        /// 
        /// </para>
        ///  
        /// <para>
        /// Don't use this operation to update the tags of a project. Instead, use <a href="https://docs.aws.amazon.com/cloudwatchevidently/latest/APIReference/API_TagResource.html">TagResource</a>.
        /// 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateProject service method.</param>
        /// 
        /// <returns>The response from the UpdateProject service method, as returned by CloudWatchEvidently.</returns>
        /// <exception cref="Amazon.CloudWatchEvidently.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvidently.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvidently.Model.ServiceQuotaExceededException">
        /// The request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvidently.Model.ValidationException">
        /// The value of a parameter in the request caused an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/evidently-2021-02-01/UpdateProject">REST API Reference for UpdateProject Operation</seealso>
        UpdateProjectResponse UpdateProject(UpdateProjectRequest request);



        /// <summary>
        /// Updates the description of an existing project.
        /// 
        ///  
        /// <para>
        /// To create a new project, use <a href="https://docs.aws.amazon.com/cloudwatchevidently/latest/APIReference/API_CreateProject.html">CreateProject</a>.
        /// </para>
        ///  
        /// <para>
        /// Don't use this operation to update the data storage options of a project. Instead,
        /// use <a href="https://docs.aws.amazon.com/cloudwatchevidently/latest/APIReference/API_UpdateProjectDataDelivery.html">UpdateProjectDataDelivery</a>.
        /// 
        /// </para>
        ///  
        /// <para>
        /// Don't use this operation to update the tags of a project. Instead, use <a href="https://docs.aws.amazon.com/cloudwatchevidently/latest/APIReference/API_TagResource.html">TagResource</a>.
        /// 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateProject service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateProject service method, as returned by CloudWatchEvidently.</returns>
        /// <exception cref="Amazon.CloudWatchEvidently.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvidently.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvidently.Model.ServiceQuotaExceededException">
        /// The request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvidently.Model.ValidationException">
        /// The value of a parameter in the request caused an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/evidently-2021-02-01/UpdateProject">REST API Reference for UpdateProject Operation</seealso>
        Task<UpdateProjectResponse> UpdateProjectAsync(UpdateProjectRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateProjectDataDelivery


        /// <summary>
        /// Updates the data storage options for this project. If you store evaluation events,
        /// you an keep them and analyze them on your own. If you choose not to store evaluation
        /// events, Evidently deletes them after using them to produce metrics and other experiment
        /// results that you can view.
        /// 
        ///  
        /// <para>
        /// You can't specify both <code>cloudWatchLogs</code> and <code>s3Destination</code>
        /// in the same operation.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateProjectDataDelivery service method.</param>
        /// 
        /// <returns>The response from the UpdateProjectDataDelivery service method, as returned by CloudWatchEvidently.</returns>
        /// <exception cref="Amazon.CloudWatchEvidently.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvidently.Model.ConflictException">
        /// A resource was in an inconsistent state during an update or a deletion.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvidently.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvidently.Model.ServiceQuotaExceededException">
        /// The request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvidently.Model.ValidationException">
        /// The value of a parameter in the request caused an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/evidently-2021-02-01/UpdateProjectDataDelivery">REST API Reference for UpdateProjectDataDelivery Operation</seealso>
        UpdateProjectDataDeliveryResponse UpdateProjectDataDelivery(UpdateProjectDataDeliveryRequest request);



        /// <summary>
        /// Updates the data storage options for this project. If you store evaluation events,
        /// you an keep them and analyze them on your own. If you choose not to store evaluation
        /// events, Evidently deletes them after using them to produce metrics and other experiment
        /// results that you can view.
        /// 
        ///  
        /// <para>
        /// You can't specify both <code>cloudWatchLogs</code> and <code>s3Destination</code>
        /// in the same operation.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateProjectDataDelivery service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateProjectDataDelivery service method, as returned by CloudWatchEvidently.</returns>
        /// <exception cref="Amazon.CloudWatchEvidently.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvidently.Model.ConflictException">
        /// A resource was in an inconsistent state during an update or a deletion.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvidently.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvidently.Model.ServiceQuotaExceededException">
        /// The request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvidently.Model.ValidationException">
        /// The value of a parameter in the request caused an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/evidently-2021-02-01/UpdateProjectDataDelivery">REST API Reference for UpdateProjectDataDelivery Operation</seealso>
        Task<UpdateProjectDataDeliveryResponse> UpdateProjectDataDeliveryAsync(UpdateProjectDataDeliveryRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}