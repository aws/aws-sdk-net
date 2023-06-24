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


#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        ICloudWatchEvidentlyPaginatorFactory Paginators { get; }
#endif


        
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
        /// Initiates the asynchronous execution of the BatchEvaluateFeature operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchEvaluateFeature operation on AmazonCloudWatchEvidentlyClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchEvaluateFeature
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/evidently-2021-02-01/BatchEvaluateFeature">REST API Reference for BatchEvaluateFeature Operation</seealso>
        IAsyncResult BeginBatchEvaluateFeature(BatchEvaluateFeatureRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  BatchEvaluateFeature operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchEvaluateFeature.</param>
        /// 
        /// <returns>Returns a  BatchEvaluateFeatureResult from CloudWatchEvidently.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/evidently-2021-02-01/BatchEvaluateFeature">REST API Reference for BatchEvaluateFeature Operation</seealso>
        BatchEvaluateFeatureResponse EndBatchEvaluateFeature(IAsyncResult asyncResult);

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
        /// You can optionally specify a <code>segment</code> to have the experiment consider
        /// only certain audience types in the experiment, such as using only user sessions from
        /// a certain location or who use a certain internet browser.
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
        /// Initiates the asynchronous execution of the CreateExperiment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateExperiment operation on AmazonCloudWatchEvidentlyClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateExperiment
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/evidently-2021-02-01/CreateExperiment">REST API Reference for CreateExperiment Operation</seealso>
        IAsyncResult BeginCreateExperiment(CreateExperimentRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateExperiment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateExperiment.</param>
        /// 
        /// <returns>Returns a  CreateExperimentResult from CloudWatchEvidently.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/evidently-2021-02-01/CreateExperiment">REST API Reference for CreateExperiment Operation</seealso>
        CreateExperimentResponse EndCreateExperiment(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the CreateFeature operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateFeature operation on AmazonCloudWatchEvidentlyClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateFeature
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/evidently-2021-02-01/CreateFeature">REST API Reference for CreateFeature Operation</seealso>
        IAsyncResult BeginCreateFeature(CreateFeatureRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateFeature operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateFeature.</param>
        /// 
        /// <returns>Returns a  CreateFeatureResult from CloudWatchEvidently.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/evidently-2021-02-01/CreateFeature">REST API Reference for CreateFeature Operation</seealso>
        CreateFeatureResponse EndCreateFeature(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the CreateLaunch operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateLaunch operation on AmazonCloudWatchEvidentlyClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateLaunch
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/evidently-2021-02-01/CreateLaunch">REST API Reference for CreateLaunch Operation</seealso>
        IAsyncResult BeginCreateLaunch(CreateLaunchRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateLaunch operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateLaunch.</param>
        /// 
        /// <returns>Returns a  CreateLaunchResult from CloudWatchEvidently.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/evidently-2021-02-01/CreateLaunch">REST API Reference for CreateLaunch Operation</seealso>
        CreateLaunchResponse EndCreateLaunch(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the CreateProject operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateProject operation on AmazonCloudWatchEvidentlyClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateProject
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/evidently-2021-02-01/CreateProject">REST API Reference for CreateProject Operation</seealso>
        IAsyncResult BeginCreateProject(CreateProjectRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateProject operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateProject.</param>
        /// 
        /// <returns>Returns a  CreateProjectResult from CloudWatchEvidently.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/evidently-2021-02-01/CreateProject">REST API Reference for CreateProject Operation</seealso>
        CreateProjectResponse EndCreateProject(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateSegment


        /// <summary>
        /// Use this operation to define a <i>segment</i> of your audience. A segment is a portion
        /// of your audience that share one or more characteristics. Examples could be Chrome
        /// browser users, users in Europe, or Firefox browser users in Europe who also fit other
        /// criteria that your application collects, such as age.
        /// 
        ///  
        /// <para>
        /// Using a segment in an experiment limits that experiment to evaluate only the users
        /// who match the segment criteria. Using one or more segments in a launch allows you
        /// to define different traffic splits for the different audience segments.
        /// </para>
        ///  
        /// <para>
        /// For more information about segment pattern syntax, see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/CloudWatch-Evidently-segments.html#CloudWatch-Evidently-segments-syntax.html">
        /// Segment rule pattern syntax</a>.
        /// </para>
        ///  
        /// <para>
        /// The pattern that you define for a segment is matched against the value of <code>evaluationContext</code>,
        /// which is passed into Evidently in the <a href="https://docs.aws.amazon.com/cloudwatchevidently/latest/APIReference/API_EvaluateFeature.html">EvaluateFeature</a>
        /// operation, when Evidently assigns a feature variation to a user.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSegment service method.</param>
        /// 
        /// <returns>The response from the CreateSegment service method, as returned by CloudWatchEvidently.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/evidently-2021-02-01/CreateSegment">REST API Reference for CreateSegment Operation</seealso>
        CreateSegmentResponse CreateSegment(CreateSegmentRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateSegment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateSegment operation on AmazonCloudWatchEvidentlyClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateSegment
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/evidently-2021-02-01/CreateSegment">REST API Reference for CreateSegment Operation</seealso>
        IAsyncResult BeginCreateSegment(CreateSegmentRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateSegment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateSegment.</param>
        /// 
        /// <returns>Returns a  CreateSegmentResult from CloudWatchEvidently.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/evidently-2021-02-01/CreateSegment">REST API Reference for CreateSegment Operation</seealso>
        CreateSegmentResponse EndCreateSegment(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the DeleteExperiment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteExperiment operation on AmazonCloudWatchEvidentlyClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteExperiment
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/evidently-2021-02-01/DeleteExperiment">REST API Reference for DeleteExperiment Operation</seealso>
        IAsyncResult BeginDeleteExperiment(DeleteExperimentRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteExperiment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteExperiment.</param>
        /// 
        /// <returns>Returns a  DeleteExperimentResult from CloudWatchEvidently.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/evidently-2021-02-01/DeleteExperiment">REST API Reference for DeleteExperiment Operation</seealso>
        DeleteExperimentResponse EndDeleteExperiment(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the DeleteFeature operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteFeature operation on AmazonCloudWatchEvidentlyClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteFeature
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/evidently-2021-02-01/DeleteFeature">REST API Reference for DeleteFeature Operation</seealso>
        IAsyncResult BeginDeleteFeature(DeleteFeatureRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteFeature operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteFeature.</param>
        /// 
        /// <returns>Returns a  DeleteFeatureResult from CloudWatchEvidently.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/evidently-2021-02-01/DeleteFeature">REST API Reference for DeleteFeature Operation</seealso>
        DeleteFeatureResponse EndDeleteFeature(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the DeleteLaunch operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteLaunch operation on AmazonCloudWatchEvidentlyClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteLaunch
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/evidently-2021-02-01/DeleteLaunch">REST API Reference for DeleteLaunch Operation</seealso>
        IAsyncResult BeginDeleteLaunch(DeleteLaunchRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteLaunch operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteLaunch.</param>
        /// 
        /// <returns>Returns a  DeleteLaunchResult from CloudWatchEvidently.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/evidently-2021-02-01/DeleteLaunch">REST API Reference for DeleteLaunch Operation</seealso>
        DeleteLaunchResponse EndDeleteLaunch(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the DeleteProject operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteProject operation on AmazonCloudWatchEvidentlyClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteProject
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/evidently-2021-02-01/DeleteProject">REST API Reference for DeleteProject Operation</seealso>
        IAsyncResult BeginDeleteProject(DeleteProjectRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteProject operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteProject.</param>
        /// 
        /// <returns>Returns a  DeleteProjectResult from CloudWatchEvidently.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/evidently-2021-02-01/DeleteProject">REST API Reference for DeleteProject Operation</seealso>
        DeleteProjectResponse EndDeleteProject(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteSegment


        /// <summary>
        /// Deletes a segment. You can't delete a segment that is being used in a launch or experiment,
        /// even if that launch or experiment is not currently running.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSegment service method.</param>
        /// 
        /// <returns>The response from the DeleteSegment service method, as returned by CloudWatchEvidently.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/evidently-2021-02-01/DeleteSegment">REST API Reference for DeleteSegment Operation</seealso>
        DeleteSegmentResponse DeleteSegment(DeleteSegmentRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteSegment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteSegment operation on AmazonCloudWatchEvidentlyClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteSegment
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/evidently-2021-02-01/DeleteSegment">REST API Reference for DeleteSegment Operation</seealso>
        IAsyncResult BeginDeleteSegment(DeleteSegmentRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteSegment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteSegment.</param>
        /// 
        /// <returns>Returns a  DeleteSegmentResult from CloudWatchEvidently.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/evidently-2021-02-01/DeleteSegment">REST API Reference for DeleteSegment Operation</seealso>
        DeleteSegmentResponse EndDeleteSegment(IAsyncResult asyncResult);

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
        /// If there is a current launch with this feature that uses segment overrides, and if
        /// the user session's <code>evaluationContext</code> matches a segment rule defined in
        /// a segment override, the configuration in the segment overrides is used. For more information
        /// about segments, see <a href="https://docs.aws.amazon.com/cloudwatchevidently/latest/APIReference/API_CreateSegment.html">CreateSegment</a>
        /// and <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/CloudWatch-Evidently-segments.html">Use
        /// segments to focus your audience</a>.
        /// </para>
        ///  
        /// <para>
        /// If there is a launch with no segment overrides, the user might be assigned to a variation
        /// in the launch. The chance of this depends on the percentage of users that are allocated
        /// to that launch. If the user is enrolled in the launch, the variation they are served
        /// depends on the allocation of the various feature variations used for the launch.
        /// </para>
        ///  
        /// <para>
        /// If the user is not assigned to a launch, and there is an ongoing experiment for this
        /// feature, the user might be assigned to a variation in the experiment. The chance of
        /// this depends on the percentage of users that are allocated to that experiment.
        /// </para>
        ///  
        /// <para>
        /// If the experiment uses a segment, then only user sessions with <code>evaluationContext</code>
        /// values that match the segment rule are used in the experiment.
        /// </para>
        ///  
        /// <para>
        /// If the user is enrolled in the experiment, the variation they are served depends on
        /// the allocation of the various feature variations used for the experiment. 
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
        /// Initiates the asynchronous execution of the EvaluateFeature operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the EvaluateFeature operation on AmazonCloudWatchEvidentlyClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndEvaluateFeature
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/evidently-2021-02-01/EvaluateFeature">REST API Reference for EvaluateFeature Operation</seealso>
        IAsyncResult BeginEvaluateFeature(EvaluateFeatureRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  EvaluateFeature operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginEvaluateFeature.</param>
        /// 
        /// <returns>Returns a  EvaluateFeatureResult from CloudWatchEvidently.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/evidently-2021-02-01/EvaluateFeature">REST API Reference for EvaluateFeature Operation</seealso>
        EvaluateFeatureResponse EndEvaluateFeature(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the GetExperiment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetExperiment operation on AmazonCloudWatchEvidentlyClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetExperiment
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/evidently-2021-02-01/GetExperiment">REST API Reference for GetExperiment Operation</seealso>
        IAsyncResult BeginGetExperiment(GetExperimentRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetExperiment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetExperiment.</param>
        /// 
        /// <returns>Returns a  GetExperimentResult from CloudWatchEvidently.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/evidently-2021-02-01/GetExperiment">REST API Reference for GetExperiment Operation</seealso>
        GetExperimentResponse EndGetExperiment(IAsyncResult asyncResult);

        #endregion
        
        #region  GetExperimentResults


        /// <summary>
        /// Retrieves the results of a running or completed experiment. No results are available
        /// until there have been 100 events for each variation and at least 10 minutes have passed
        /// since the start of the experiment. To increase the statistical power, Evidently performs
        /// an additional offline p-value analysis at the end of the experiment. Offline p-value
        /// analysis can detect statistical significance in some cases where the anytime p-values
        /// used during the experiment do not find statistical significance.
        /// 
        ///  
        /// <para>
        /// Experiment results are available up to 63 days after the start of the experiment.
        /// They are not available after that because of CloudWatch data retention policies.
        /// </para>
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
        /// Initiates the asynchronous execution of the GetExperimentResults operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetExperimentResults operation on AmazonCloudWatchEvidentlyClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetExperimentResults
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/evidently-2021-02-01/GetExperimentResults">REST API Reference for GetExperimentResults Operation</seealso>
        IAsyncResult BeginGetExperimentResults(GetExperimentResultsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetExperimentResults operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetExperimentResults.</param>
        /// 
        /// <returns>Returns a  GetExperimentResultsResult from CloudWatchEvidently.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/evidently-2021-02-01/GetExperimentResults">REST API Reference for GetExperimentResults Operation</seealso>
        GetExperimentResultsResponse EndGetExperimentResults(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the GetFeature operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetFeature operation on AmazonCloudWatchEvidentlyClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetFeature
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/evidently-2021-02-01/GetFeature">REST API Reference for GetFeature Operation</seealso>
        IAsyncResult BeginGetFeature(GetFeatureRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetFeature operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetFeature.</param>
        /// 
        /// <returns>Returns a  GetFeatureResult from CloudWatchEvidently.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/evidently-2021-02-01/GetFeature">REST API Reference for GetFeature Operation</seealso>
        GetFeatureResponse EndGetFeature(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the GetLaunch operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetLaunch operation on AmazonCloudWatchEvidentlyClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetLaunch
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/evidently-2021-02-01/GetLaunch">REST API Reference for GetLaunch Operation</seealso>
        IAsyncResult BeginGetLaunch(GetLaunchRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetLaunch operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetLaunch.</param>
        /// 
        /// <returns>Returns a  GetLaunchResult from CloudWatchEvidently.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/evidently-2021-02-01/GetLaunch">REST API Reference for GetLaunch Operation</seealso>
        GetLaunchResponse EndGetLaunch(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the GetProject operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetProject operation on AmazonCloudWatchEvidentlyClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetProject
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/evidently-2021-02-01/GetProject">REST API Reference for GetProject Operation</seealso>
        IAsyncResult BeginGetProject(GetProjectRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetProject operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetProject.</param>
        /// 
        /// <returns>Returns a  GetProjectResult from CloudWatchEvidently.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/evidently-2021-02-01/GetProject">REST API Reference for GetProject Operation</seealso>
        GetProjectResponse EndGetProject(IAsyncResult asyncResult);

        #endregion
        
        #region  GetSegment


        /// <summary>
        /// Returns information about the specified segment. Specify the segment you want to view
        /// by specifying its ARN.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSegment service method.</param>
        /// 
        /// <returns>The response from the GetSegment service method, as returned by CloudWatchEvidently.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/evidently-2021-02-01/GetSegment">REST API Reference for GetSegment Operation</seealso>
        GetSegmentResponse GetSegment(GetSegmentRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetSegment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSegment operation on AmazonCloudWatchEvidentlyClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetSegment
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/evidently-2021-02-01/GetSegment">REST API Reference for GetSegment Operation</seealso>
        IAsyncResult BeginGetSegment(GetSegmentRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetSegment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetSegment.</param>
        /// 
        /// <returns>Returns a  GetSegmentResult from CloudWatchEvidently.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/evidently-2021-02-01/GetSegment">REST API Reference for GetSegment Operation</seealso>
        GetSegmentResponse EndGetSegment(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the ListExperiments operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListExperiments operation on AmazonCloudWatchEvidentlyClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListExperiments
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/evidently-2021-02-01/ListExperiments">REST API Reference for ListExperiments Operation</seealso>
        IAsyncResult BeginListExperiments(ListExperimentsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListExperiments operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListExperiments.</param>
        /// 
        /// <returns>Returns a  ListExperimentsResult from CloudWatchEvidently.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/evidently-2021-02-01/ListExperiments">REST API Reference for ListExperiments Operation</seealso>
        ListExperimentsResponse EndListExperiments(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the ListFeatures operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListFeatures operation on AmazonCloudWatchEvidentlyClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListFeatures
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/evidently-2021-02-01/ListFeatures">REST API Reference for ListFeatures Operation</seealso>
        IAsyncResult BeginListFeatures(ListFeaturesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListFeatures operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListFeatures.</param>
        /// 
        /// <returns>Returns a  ListFeaturesResult from CloudWatchEvidently.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/evidently-2021-02-01/ListFeatures">REST API Reference for ListFeatures Operation</seealso>
        ListFeaturesResponse EndListFeatures(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the ListLaunches operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListLaunches operation on AmazonCloudWatchEvidentlyClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListLaunches
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/evidently-2021-02-01/ListLaunches">REST API Reference for ListLaunches Operation</seealso>
        IAsyncResult BeginListLaunches(ListLaunchesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListLaunches operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListLaunches.</param>
        /// 
        /// <returns>Returns a  ListLaunchesResult from CloudWatchEvidently.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/evidently-2021-02-01/ListLaunches">REST API Reference for ListLaunches Operation</seealso>
        ListLaunchesResponse EndListLaunches(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the ListProjects operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListProjects operation on AmazonCloudWatchEvidentlyClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListProjects
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/evidently-2021-02-01/ListProjects">REST API Reference for ListProjects Operation</seealso>
        IAsyncResult BeginListProjects(ListProjectsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListProjects operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListProjects.</param>
        /// 
        /// <returns>Returns a  ListProjectsResult from CloudWatchEvidently.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/evidently-2021-02-01/ListProjects">REST API Reference for ListProjects Operation</seealso>
        ListProjectsResponse EndListProjects(IAsyncResult asyncResult);

        #endregion
        
        #region  ListSegmentReferences


        /// <summary>
        /// Use this operation to find which experiments or launches are using a specified segment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSegmentReferences service method.</param>
        /// 
        /// <returns>The response from the ListSegmentReferences service method, as returned by CloudWatchEvidently.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/evidently-2021-02-01/ListSegmentReferences">REST API Reference for ListSegmentReferences Operation</seealso>
        ListSegmentReferencesResponse ListSegmentReferences(ListSegmentReferencesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListSegmentReferences operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListSegmentReferences operation on AmazonCloudWatchEvidentlyClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListSegmentReferences
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/evidently-2021-02-01/ListSegmentReferences">REST API Reference for ListSegmentReferences Operation</seealso>
        IAsyncResult BeginListSegmentReferences(ListSegmentReferencesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListSegmentReferences operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListSegmentReferences.</param>
        /// 
        /// <returns>Returns a  ListSegmentReferencesResult from CloudWatchEvidently.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/evidently-2021-02-01/ListSegmentReferences">REST API Reference for ListSegmentReferences Operation</seealso>
        ListSegmentReferencesResponse EndListSegmentReferences(IAsyncResult asyncResult);

        #endregion
        
        #region  ListSegments


        /// <summary>
        /// Returns a list of audience segments that you have created in your account in this
        /// Region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSegments service method.</param>
        /// 
        /// <returns>The response from the ListSegments service method, as returned by CloudWatchEvidently.</returns>
        /// <exception cref="Amazon.CloudWatchEvidently.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvidently.Model.ThrottlingException">
        /// The request was denied because of request throttling. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvidently.Model.ValidationException">
        /// The value of a parameter in the request caused an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/evidently-2021-02-01/ListSegments">REST API Reference for ListSegments Operation</seealso>
        ListSegmentsResponse ListSegments(ListSegmentsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListSegments operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListSegments operation on AmazonCloudWatchEvidentlyClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListSegments
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/evidently-2021-02-01/ListSegments">REST API Reference for ListSegments Operation</seealso>
        IAsyncResult BeginListSegments(ListSegmentsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListSegments operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListSegments.</param>
        /// 
        /// <returns>Returns a  ListSegmentsResult from CloudWatchEvidently.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/evidently-2021-02-01/ListSegments">REST API Reference for ListSegments Operation</seealso>
        ListSegmentsResponse EndListSegments(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonCloudWatchEvidentlyClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/evidently-2021-02-01/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        IAsyncResult BeginListTagsForResource(ListTagsForResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTagsForResource.</param>
        /// 
        /// <returns>Returns a  ListTagsForResourceResult from CloudWatchEvidently.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/evidently-2021-02-01/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the PutProjectEvents operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutProjectEvents operation on AmazonCloudWatchEvidentlyClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutProjectEvents
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/evidently-2021-02-01/PutProjectEvents">REST API Reference for PutProjectEvents Operation</seealso>
        IAsyncResult BeginPutProjectEvents(PutProjectEventsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  PutProjectEvents operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutProjectEvents.</param>
        /// 
        /// <returns>Returns a  PutProjectEventsResult from CloudWatchEvidently.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/evidently-2021-02-01/PutProjectEvents">REST API Reference for PutProjectEvents Operation</seealso>
        PutProjectEventsResponse EndPutProjectEvents(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the StartExperiment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartExperiment operation on AmazonCloudWatchEvidentlyClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartExperiment
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/evidently-2021-02-01/StartExperiment">REST API Reference for StartExperiment Operation</seealso>
        IAsyncResult BeginStartExperiment(StartExperimentRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StartExperiment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartExperiment.</param>
        /// 
        /// <returns>Returns a  StartExperimentResult from CloudWatchEvidently.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/evidently-2021-02-01/StartExperiment">REST API Reference for StartExperiment Operation</seealso>
        StartExperimentResponse EndStartExperiment(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the StartLaunch operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartLaunch operation on AmazonCloudWatchEvidentlyClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartLaunch
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/evidently-2021-02-01/StartLaunch">REST API Reference for StartLaunch Operation</seealso>
        IAsyncResult BeginStartLaunch(StartLaunchRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StartLaunch operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartLaunch.</param>
        /// 
        /// <returns>Returns a  StartLaunchResult from CloudWatchEvidently.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/evidently-2021-02-01/StartLaunch">REST API Reference for StartLaunch Operation</seealso>
        StartLaunchResponse EndStartLaunch(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the StopExperiment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopExperiment operation on AmazonCloudWatchEvidentlyClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStopExperiment
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/evidently-2021-02-01/StopExperiment">REST API Reference for StopExperiment Operation</seealso>
        IAsyncResult BeginStopExperiment(StopExperimentRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StopExperiment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStopExperiment.</param>
        /// 
        /// <returns>Returns a  StopExperimentResult from CloudWatchEvidently.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/evidently-2021-02-01/StopExperiment">REST API Reference for StopExperiment Operation</seealso>
        StopExperimentResponse EndStopExperiment(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the StopLaunch operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopLaunch operation on AmazonCloudWatchEvidentlyClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStopLaunch
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/evidently-2021-02-01/StopLaunch">REST API Reference for StopLaunch Operation</seealso>
        IAsyncResult BeginStopLaunch(StopLaunchRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StopLaunch operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStopLaunch.</param>
        /// 
        /// <returns>Returns a  StopLaunchResult from CloudWatchEvidently.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/evidently-2021-02-01/StopLaunch">REST API Reference for StopLaunch Operation</seealso>
        StopLaunchResponse EndStopLaunch(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the TagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonCloudWatchEvidentlyClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/evidently-2021-02-01/TagResource">REST API Reference for TagResource Operation</seealso>
        IAsyncResult BeginTagResource(TagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  TagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTagResource.</param>
        /// 
        /// <returns>Returns a  TagResourceResult from CloudWatchEvidently.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/evidently-2021-02-01/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse EndTagResource(IAsyncResult asyncResult);

        #endregion
        
        #region  TestSegmentPattern


        /// <summary>
        /// Use this operation to test a rules pattern that you plan to use to create an audience
        /// segment. For more information about segments, see <a href="https://docs.aws.amazon.com/cloudwatchevidently/latest/APIReference/API_CreateSegment.html">CreateSegment</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TestSegmentPattern service method.</param>
        /// 
        /// <returns>The response from the TestSegmentPattern service method, as returned by CloudWatchEvidently.</returns>
        /// <exception cref="Amazon.CloudWatchEvidently.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvidently.Model.ThrottlingException">
        /// The request was denied because of request throttling. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvidently.Model.ValidationException">
        /// The value of a parameter in the request caused an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/evidently-2021-02-01/TestSegmentPattern">REST API Reference for TestSegmentPattern Operation</seealso>
        TestSegmentPatternResponse TestSegmentPattern(TestSegmentPatternRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the TestSegmentPattern operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TestSegmentPattern operation on AmazonCloudWatchEvidentlyClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTestSegmentPattern
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/evidently-2021-02-01/TestSegmentPattern">REST API Reference for TestSegmentPattern Operation</seealso>
        IAsyncResult BeginTestSegmentPattern(TestSegmentPatternRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  TestSegmentPattern operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTestSegmentPattern.</param>
        /// 
        /// <returns>Returns a  TestSegmentPatternResult from CloudWatchEvidently.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/evidently-2021-02-01/TestSegmentPattern">REST API Reference for TestSegmentPattern Operation</seealso>
        TestSegmentPatternResponse EndTestSegmentPattern(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the UntagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonCloudWatchEvidentlyClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/evidently-2021-02-01/UntagResource">REST API Reference for UntagResource Operation</seealso>
        IAsyncResult BeginUntagResource(UntagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UntagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUntagResource.</param>
        /// 
        /// <returns>Returns a  UntagResourceResult from CloudWatchEvidently.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/evidently-2021-02-01/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse EndUntagResource(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the UpdateExperiment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateExperiment operation on AmazonCloudWatchEvidentlyClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateExperiment
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/evidently-2021-02-01/UpdateExperiment">REST API Reference for UpdateExperiment Operation</seealso>
        IAsyncResult BeginUpdateExperiment(UpdateExperimentRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateExperiment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateExperiment.</param>
        /// 
        /// <returns>Returns a  UpdateExperimentResult from CloudWatchEvidently.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/evidently-2021-02-01/UpdateExperiment">REST API Reference for UpdateExperiment Operation</seealso>
        UpdateExperimentResponse EndUpdateExperiment(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the UpdateFeature operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateFeature operation on AmazonCloudWatchEvidentlyClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateFeature
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/evidently-2021-02-01/UpdateFeature">REST API Reference for UpdateFeature Operation</seealso>
        IAsyncResult BeginUpdateFeature(UpdateFeatureRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateFeature operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateFeature.</param>
        /// 
        /// <returns>Returns a  UpdateFeatureResult from CloudWatchEvidently.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/evidently-2021-02-01/UpdateFeature">REST API Reference for UpdateFeature Operation</seealso>
        UpdateFeatureResponse EndUpdateFeature(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the UpdateLaunch operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateLaunch operation on AmazonCloudWatchEvidentlyClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateLaunch
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/evidently-2021-02-01/UpdateLaunch">REST API Reference for UpdateLaunch Operation</seealso>
        IAsyncResult BeginUpdateLaunch(UpdateLaunchRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateLaunch operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateLaunch.</param>
        /// 
        /// <returns>Returns a  UpdateLaunchResult from CloudWatchEvidently.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/evidently-2021-02-01/UpdateLaunch">REST API Reference for UpdateLaunch Operation</seealso>
        UpdateLaunchResponse EndUpdateLaunch(IAsyncResult asyncResult);

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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/evidently-2021-02-01/UpdateProject">REST API Reference for UpdateProject Operation</seealso>
        UpdateProjectResponse UpdateProject(UpdateProjectRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateProject operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateProject operation on AmazonCloudWatchEvidentlyClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateProject
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/evidently-2021-02-01/UpdateProject">REST API Reference for UpdateProject Operation</seealso>
        IAsyncResult BeginUpdateProject(UpdateProjectRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateProject operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateProject.</param>
        /// 
        /// <returns>Returns a  UpdateProjectResult from CloudWatchEvidently.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/evidently-2021-02-01/UpdateProject">REST API Reference for UpdateProject Operation</seealso>
        UpdateProjectResponse EndUpdateProject(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the UpdateProjectDataDelivery operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateProjectDataDelivery operation on AmazonCloudWatchEvidentlyClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateProjectDataDelivery
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/evidently-2021-02-01/UpdateProjectDataDelivery">REST API Reference for UpdateProjectDataDelivery Operation</seealso>
        IAsyncResult BeginUpdateProjectDataDelivery(UpdateProjectDataDeliveryRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateProjectDataDelivery operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateProjectDataDelivery.</param>
        /// 
        /// <returns>Returns a  UpdateProjectDataDeliveryResult from CloudWatchEvidently.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/evidently-2021-02-01/UpdateProjectDataDelivery">REST API Reference for UpdateProjectDataDelivery Operation</seealso>
        UpdateProjectDataDeliveryResponse EndUpdateProjectDataDelivery(IAsyncResult asyncResult);

        #endregion
        
    }
}