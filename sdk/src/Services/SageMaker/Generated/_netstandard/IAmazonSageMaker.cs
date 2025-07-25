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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.SageMaker.Model;

#pragma warning disable CS1570
namespace Amazon.SageMaker
{
    /// <summary>
    /// <para>Interface for accessing SageMaker</para>
    ///
    /// Provides APIs for creating and managing SageMaker resources. 
    /// 
    ///  
    /// <para>
    /// Other Resources:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/whatis.html#first-time-user">SageMaker
    /// Developer Guide</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/augmented-ai/2019-11-07/APIReference/Welcome.html">Amazon
    /// Augmented AI Runtime API Reference</a> 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial interface IAmazonSageMaker : IAmazonService, IDisposable
    {
#if AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        ISageMakerPaginatorFactory Paginators { get; }
#endif
                
        #region  AddAssociation



        /// <summary>
        /// Creates an <i>association</i> between the source and the destination. A source can
        /// be associated with multiple destinations, and a destination can be associated with
        /// multiple sources. An association is a lineage tracking entity. For more information,
        /// see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/lineage-tracking.html">Amazon
        /// SageMaker ML Lineage Tracking</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddAssociation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AddAssociation service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceLimitExceededException">
        /// You have exceeded an SageMaker resource limit. For example, you might have too many
        /// training jobs created.
        /// </exception>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/AddAssociation">REST API Reference for AddAssociation Operation</seealso>
        Task<AddAssociationResponse> AddAssociationAsync(AddAssociationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  AddTags



        /// <summary>
        /// Adds or overwrites one or more tags for the specified SageMaker resource. You can
        /// add tags to notebook instances, training jobs, hyperparameter tuning jobs, batch transform
        /// jobs, models, labeling jobs, work teams, endpoint configurations, and endpoints.
        /// 
        ///  
        /// <para>
        /// Each tag consists of a key and an optional value. Tag keys must be unique per resource.
        /// For more information about tags, see For more information, see <a href="https://aws.amazon.com/answers/account-management/aws-tagging-strategies/">Amazon
        /// Web Services Tagging Strategies</a>.
        /// </para>
        ///  <note> 
        /// <para>
        /// Tags that you add to a hyperparameter tuning job by calling this API are also added
        /// to any training jobs that the hyperparameter tuning job launches after you call this
        /// API, but not to training jobs that the hyperparameter tuning job launched before you
        /// called this API. To make sure that the tags associated with a hyperparameter tuning
        /// job are also added to all training jobs that the hyperparameter tuning job launches,
        /// add the tags when you first create the tuning job by specifying them in the <c>Tags</c>
        /// parameter of <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_CreateHyperParameterTuningJob.html">CreateHyperParameterTuningJob</a>
        /// 
        /// </para>
        ///  </note> <note> 
        /// <para>
        /// Tags that you add to a SageMaker Domain or User Profile by calling this API are also
        /// added to any Apps that the Domain or User Profile launches after you call this API,
        /// but not to Apps that the Domain or User Profile launched before you called this API.
        /// To make sure that the tags associated with a Domain or User Profile are also added
        /// to all Apps that the Domain or User Profile launches, add the tags when you first
        /// create the Domain or User Profile by specifying them in the <c>Tags</c> parameter
        /// of <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_CreateDomain.html">CreateDomain</a>
        /// or <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_CreateUserProfile.html">CreateUserProfile</a>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddTags service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AddTags service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/AddTags">REST API Reference for AddTags Operation</seealso>
        Task<AddTagsResponse> AddTagsAsync(AddTagsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  AssociateTrialComponent



        /// <summary>
        /// Associates a trial component with a trial. A trial component can be associated with
        /// multiple trials. To disassociate a trial component from a trial, call the <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_DisassociateTrialComponent.html">DisassociateTrialComponent</a>
        /// API.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateTrialComponent service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AssociateTrialComponent service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceLimitExceededException">
        /// You have exceeded an SageMaker resource limit. For example, you might have too many
        /// training jobs created.
        /// </exception>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/AssociateTrialComponent">REST API Reference for AssociateTrialComponent Operation</seealso>
        Task<AssociateTrialComponentResponse> AssociateTrialComponentAsync(AssociateTrialComponentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  BatchDeleteClusterNodes



        /// <summary>
        /// Deletes specific nodes within a SageMaker HyperPod cluster. <c>BatchDeleteClusterNodes</c>
        /// accepts a cluster name and a list of node IDs.
        /// 
        ///  <important> <ul> <li> 
        /// <para>
        /// To safeguard your work, back up your data to Amazon S3 or an FSx for Lustre file system
        /// before invoking the API on a worker node group. This will help prevent any potential
        /// data loss from the instance root volume. For more information about backup, see <a
        /// href="https://docs.aws.amazon.com/sagemaker/latest/dg/sagemaker-hyperpod-operate-cli-command.html#sagemaker-hyperpod-operate-cli-command-update-cluster-software-backup">Use
        /// the backup script provided by SageMaker HyperPod</a>. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you want to invoke this API on an existing cluster, you'll first need to patch
        /// the cluster by running the <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_UpdateClusterSoftware.html">UpdateClusterSoftware
        /// API</a>. For more information about patching a cluster, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/sagemaker-hyperpod-operate-cli-command.html#sagemaker-hyperpod-operate-cli-command-update-cluster-software">Update
        /// the SageMaker HyperPod platform software of a cluster</a>.
        /// </para>
        ///  </li> </ul> </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchDeleteClusterNodes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchDeleteClusterNodes service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/BatchDeleteClusterNodes">REST API Reference for BatchDeleteClusterNodes Operation</seealso>
        Task<BatchDeleteClusterNodesResponse> BatchDeleteClusterNodesAsync(BatchDeleteClusterNodesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  BatchDescribeModelPackage



        /// <summary>
        /// This action batch describes a list of versioned model packages
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchDescribeModelPackage service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchDescribeModelPackage service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/BatchDescribeModelPackage">REST API Reference for BatchDescribeModelPackage Operation</seealso>
        Task<BatchDescribeModelPackageResponse> BatchDescribeModelPackageAsync(BatchDescribeModelPackageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateAction



        /// <summary>
        /// Creates an <i>action</i>. An action is a lineage tracking entity that represents an
        /// action or activity. For example, a model deployment or an HPO job. Generally, an action
        /// involves at least one input or output artifact. For more information, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/lineage-tracking.html">Amazon
        /// SageMaker ML Lineage Tracking</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAction service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateAction service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceLimitExceededException">
        /// You have exceeded an SageMaker resource limit. For example, you might have too many
        /// training jobs created.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateAction">REST API Reference for CreateAction Operation</seealso>
        Task<CreateActionResponse> CreateActionAsync(CreateActionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateAlgorithm



        /// <summary>
        /// Create a machine learning algorithm that you can use in SageMaker and list in the
        /// Amazon Web Services Marketplace.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAlgorithm service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateAlgorithm service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateAlgorithm">REST API Reference for CreateAlgorithm Operation</seealso>
        Task<CreateAlgorithmResponse> CreateAlgorithmAsync(CreateAlgorithmRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateApp



        /// <summary>
        /// Creates a running app for the specified UserProfile. This operation is automatically
        /// invoked by Amazon SageMaker AI upon access to the associated Domain, and when new
        /// kernel configurations are selected by the user. A user may have multiple Apps active
        /// simultaneously.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateApp service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateApp service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceInUseException">
        /// Resource being accessed is in use.
        /// </exception>
        /// <exception cref="Amazon.SageMaker.Model.ResourceLimitExceededException">
        /// You have exceeded an SageMaker resource limit. For example, you might have too many
        /// training jobs created.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateApp">REST API Reference for CreateApp Operation</seealso>
        Task<CreateAppResponse> CreateAppAsync(CreateAppRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateAppImageConfig



        /// <summary>
        /// Creates a configuration for running a SageMaker AI image as a KernelGateway app. The
        /// configuration specifies the Amazon Elastic File System storage volume on the image,
        /// and a list of the kernels in the image.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAppImageConfig service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateAppImageConfig service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceInUseException">
        /// Resource being accessed is in use.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateAppImageConfig">REST API Reference for CreateAppImageConfig Operation</seealso>
        Task<CreateAppImageConfigResponse> CreateAppImageConfigAsync(CreateAppImageConfigRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateArtifact



        /// <summary>
        /// Creates an <i>artifact</i>. An artifact is a lineage tracking entity that represents
        /// a URI addressable object or data. Some examples are the S3 URI of a dataset and the
        /// ECR registry path of an image. For more information, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/lineage-tracking.html">Amazon
        /// SageMaker ML Lineage Tracking</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateArtifact service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateArtifact service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceLimitExceededException">
        /// You have exceeded an SageMaker resource limit. For example, you might have too many
        /// training jobs created.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateArtifact">REST API Reference for CreateArtifact Operation</seealso>
        Task<CreateArtifactResponse> CreateArtifactAsync(CreateArtifactRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateAutoMLJob



        /// <summary>
        /// Creates an Autopilot job also referred to as Autopilot experiment or AutoML job.
        /// 
        ///  
        /// <para>
        /// An AutoML job in SageMaker AI is a fully automated process that allows you to build
        /// machine learning models with minimal effort and machine learning expertise. When initiating
        /// an AutoML job, you provide your data and optionally specify parameters tailored to
        /// your use case. SageMaker AI then automates the entire model development lifecycle,
        /// including data preprocessing, model training, tuning, and evaluation. AutoML jobs
        /// are designed to simplify and accelerate the model building process by automating various
        /// tasks and exploring different combinations of machine learning algorithms, data preprocessing
        /// techniques, and hyperparameter values. The output of an AutoML job comprises one or
        /// more trained models ready for deployment and inference. Additionally, SageMaker AI
        /// AutoML jobs generate a candidate model leaderboard, allowing you to select the best-performing
        /// model for deployment.
        /// </para>
        ///  
        /// <para>
        /// For more information about AutoML jobs, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/autopilot-automate-model-development.html">https://docs.aws.amazon.com/sagemaker/latest/dg/autopilot-automate-model-development.html</a>
        /// in the SageMaker AI developer guide.
        /// </para>
        ///  <note> 
        /// <para>
        /// We recommend using the new versions <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_CreateAutoMLJobV2.html">CreateAutoMLJobV2</a>
        /// and <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_DescribeAutoMLJobV2.html">DescribeAutoMLJobV2</a>,
        /// which offer backward compatibility.
        /// </para>
        ///  
        /// <para>
        ///  <c>CreateAutoMLJobV2</c> can manage tabular problem types identical to those of its
        /// previous version <c>CreateAutoMLJob</c>, as well as time-series forecasting, non-tabular
        /// problem types such as image or text classification, and text generation (LLMs fine-tuning).
        /// </para>
        ///  
        /// <para>
        /// Find guidelines about how to migrate a <c>CreateAutoMLJob</c> to <c>CreateAutoMLJobV2</c>
        /// in <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/autopilot-automate-model-development-create-experiment.html#autopilot-create-experiment-api-migrate-v1-v2">Migrate
        /// a CreateAutoMLJob to CreateAutoMLJobV2</a>.
        /// </para>
        ///  </note> 
        /// <para>
        /// You can find the best-performing model after you run an AutoML job by calling <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_DescribeAutoMLJobV2.html">DescribeAutoMLJobV2</a>
        /// (recommended) or <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_DescribeAutoMLJob.html">DescribeAutoMLJob</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAutoMLJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateAutoMLJob service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceInUseException">
        /// Resource being accessed is in use.
        /// </exception>
        /// <exception cref="Amazon.SageMaker.Model.ResourceLimitExceededException">
        /// You have exceeded an SageMaker resource limit. For example, you might have too many
        /// training jobs created.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateAutoMLJob">REST API Reference for CreateAutoMLJob Operation</seealso>
        Task<CreateAutoMLJobResponse> CreateAutoMLJobAsync(CreateAutoMLJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateAutoMLJobV2



        /// <summary>
        /// Creates an Autopilot job also referred to as Autopilot experiment or AutoML job V2.
        /// 
        ///  
        /// <para>
        /// An AutoML job in SageMaker AI is a fully automated process that allows you to build
        /// machine learning models with minimal effort and machine learning expertise. When initiating
        /// an AutoML job, you provide your data and optionally specify parameters tailored to
        /// your use case. SageMaker AI then automates the entire model development lifecycle,
        /// including data preprocessing, model training, tuning, and evaluation. AutoML jobs
        /// are designed to simplify and accelerate the model building process by automating various
        /// tasks and exploring different combinations of machine learning algorithms, data preprocessing
        /// techniques, and hyperparameter values. The output of an AutoML job comprises one or
        /// more trained models ready for deployment and inference. Additionally, SageMaker AI
        /// AutoML jobs generate a candidate model leaderboard, allowing you to select the best-performing
        /// model for deployment.
        /// </para>
        ///  
        /// <para>
        /// For more information about AutoML jobs, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/autopilot-automate-model-development.html">https://docs.aws.amazon.com/sagemaker/latest/dg/autopilot-automate-model-development.html</a>
        /// in the SageMaker AI developer guide.
        /// </para>
        ///  
        /// <para>
        /// AutoML jobs V2 support various problem types such as regression, binary, and multiclass
        /// classification with tabular data, text and image classification, time-series forecasting,
        /// and fine-tuning of large language models (LLMs) for text generation.
        /// </para>
        ///  <note> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_CreateAutoMLJobV2.html">CreateAutoMLJobV2</a>
        /// and <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_DescribeAutoMLJobV2.html">DescribeAutoMLJobV2</a>
        /// are new versions of <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_CreateAutoMLJob.html">CreateAutoMLJob</a>
        /// and <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_DescribeAutoMLJob.html">DescribeAutoMLJob</a>
        /// which offer backward compatibility.
        /// </para>
        ///  
        /// <para>
        ///  <c>CreateAutoMLJobV2</c> can manage tabular problem types identical to those of its
        /// previous version <c>CreateAutoMLJob</c>, as well as time-series forecasting, non-tabular
        /// problem types such as image or text classification, and text generation (LLMs fine-tuning).
        /// </para>
        ///  
        /// <para>
        /// Find guidelines about how to migrate a <c>CreateAutoMLJob</c> to <c>CreateAutoMLJobV2</c>
        /// in <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/autopilot-automate-model-development-create-experiment.html#autopilot-create-experiment-api-migrate-v1-v2">Migrate
        /// a CreateAutoMLJob to CreateAutoMLJobV2</a>.
        /// </para>
        ///  </note> 
        /// <para>
        /// For the list of available problem types supported by <c>CreateAutoMLJobV2</c>, see
        /// <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_AutoMLProblemTypeConfig.html">AutoMLProblemTypeConfig</a>.
        /// </para>
        ///  
        /// <para>
        /// You can find the best-performing model after you run an AutoML job V2 by calling <a
        /// href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_DescribeAutoMLJobV2.html">DescribeAutoMLJobV2</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAutoMLJobV2 service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateAutoMLJobV2 service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceInUseException">
        /// Resource being accessed is in use.
        /// </exception>
        /// <exception cref="Amazon.SageMaker.Model.ResourceLimitExceededException">
        /// You have exceeded an SageMaker resource limit. For example, you might have too many
        /// training jobs created.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateAutoMLJobV2">REST API Reference for CreateAutoMLJobV2 Operation</seealso>
        Task<CreateAutoMLJobV2Response> CreateAutoMLJobV2Async(CreateAutoMLJobV2Request request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateCluster



        /// <summary>
        /// Creates a SageMaker HyperPod cluster. SageMaker HyperPod is a capability of SageMaker
        /// for creating and managing persistent clusters for developing large machine learning
        /// models, such as large language models (LLMs) and diffusion models. To learn more,
        /// see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/sagemaker-hyperpod.html">Amazon
        /// SageMaker HyperPod</a> in the <i>Amazon SageMaker Developer Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCluster service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateCluster service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceInUseException">
        /// Resource being accessed is in use.
        /// </exception>
        /// <exception cref="Amazon.SageMaker.Model.ResourceLimitExceededException">
        /// You have exceeded an SageMaker resource limit. For example, you might have too many
        /// training jobs created.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateCluster">REST API Reference for CreateCluster Operation</seealso>
        Task<CreateClusterResponse> CreateClusterAsync(CreateClusterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateClusterSchedulerConfig



        /// <summary>
        /// Create cluster policy configuration. This policy is used for task prioritization and
        /// fair-share allocation of idle compute. This helps prioritize critical workloads and
        /// distributes idle compute across entities.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateClusterSchedulerConfig service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateClusterSchedulerConfig service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ConflictException">
        /// There was a conflict when you attempted to modify a SageMaker entity such as an <c>Experiment</c>
        /// or <c>Artifact</c>.
        /// </exception>
        /// <exception cref="Amazon.SageMaker.Model.ResourceLimitExceededException">
        /// You have exceeded an SageMaker resource limit. For example, you might have too many
        /// training jobs created.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateClusterSchedulerConfig">REST API Reference for CreateClusterSchedulerConfig Operation</seealso>
        Task<CreateClusterSchedulerConfigResponse> CreateClusterSchedulerConfigAsync(CreateClusterSchedulerConfigRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateCodeRepository



        /// <summary>
        /// Creates a Git repository as a resource in your SageMaker AI account. You can associate
        /// the repository with notebook instances so that you can use Git source control for
        /// the notebooks you create. The Git repository is a resource in your SageMaker AI account,
        /// so it can be associated with more than one notebook instance, and it persists independently
        /// from the lifecycle of any notebook instances it is associated with.
        /// 
        ///  
        /// <para>
        /// The repository can be hosted either in <a href="https://docs.aws.amazon.com/codecommit/latest/userguide/welcome.html">Amazon
        /// Web Services CodeCommit</a> or in any other Git repository.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCodeRepository service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateCodeRepository service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateCodeRepository">REST API Reference for CreateCodeRepository Operation</seealso>
        Task<CreateCodeRepositoryResponse> CreateCodeRepositoryAsync(CreateCodeRepositoryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateCompilationJob



        /// <summary>
        /// Starts a model compilation job. After the model has been compiled, Amazon SageMaker
        /// AI saves the resulting model artifacts to an Amazon Simple Storage Service (Amazon
        /// S3) bucket that you specify. 
        /// 
        ///  
        /// <para>
        /// If you choose to host your model using Amazon SageMaker AI hosting services, you can
        /// use the resulting model artifacts as part of the model. You can also use the artifacts
        /// with Amazon Web Services IoT Greengrass. In that case, deploy them as an ML resource.
        /// </para>
        ///  
        /// <para>
        /// In the request body, you provide the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// A name for the compilation job
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  Information about the input model artifacts 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The output location for the compiled model and the device (target) that the model
        /// runs on 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The Amazon Resource Name (ARN) of the IAM role that Amazon SageMaker AI assumes to
        /// perform the model compilation job. 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// You can also provide a <c>Tag</c> to track the model compilation job's resource use
        /// and costs. The response body contains the <c>CompilationJobArn</c> for the compiled
        /// job.
        /// </para>
        ///  
        /// <para>
        /// To stop a model compilation job, use <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_StopCompilationJob.html">StopCompilationJob</a>.
        /// To get information about a particular model compilation job, use <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_DescribeCompilationJob.html">DescribeCompilationJob</a>.
        /// To get information about multiple model compilation jobs, use <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_ListCompilationJobs.html">ListCompilationJobs</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCompilationJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateCompilationJob service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceInUseException">
        /// Resource being accessed is in use.
        /// </exception>
        /// <exception cref="Amazon.SageMaker.Model.ResourceLimitExceededException">
        /// You have exceeded an SageMaker resource limit. For example, you might have too many
        /// training jobs created.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateCompilationJob">REST API Reference for CreateCompilationJob Operation</seealso>
        Task<CreateCompilationJobResponse> CreateCompilationJobAsync(CreateCompilationJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateComputeQuota



        /// <summary>
        /// Create compute allocation definition. This defines how compute is allocated, shared,
        /// and borrowed for specified entities. Specifically, how to lend and borrow idle compute
        /// and assign a fair-share weight to the specified entities.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateComputeQuota service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateComputeQuota service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ConflictException">
        /// There was a conflict when you attempted to modify a SageMaker entity such as an <c>Experiment</c>
        /// or <c>Artifact</c>.
        /// </exception>
        /// <exception cref="Amazon.SageMaker.Model.ResourceLimitExceededException">
        /// You have exceeded an SageMaker resource limit. For example, you might have too many
        /// training jobs created.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateComputeQuota">REST API Reference for CreateComputeQuota Operation</seealso>
        Task<CreateComputeQuotaResponse> CreateComputeQuotaAsync(CreateComputeQuotaRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateContext



        /// <summary>
        /// Creates a <i>context</i>. A context is a lineage tracking entity that represents a
        /// logical grouping of other tracking or experiment entities. Some examples are an endpoint
        /// and a model package. For more information, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/lineage-tracking.html">Amazon
        /// SageMaker ML Lineage Tracking</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateContext service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateContext service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceLimitExceededException">
        /// You have exceeded an SageMaker resource limit. For example, you might have too many
        /// training jobs created.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateContext">REST API Reference for CreateContext Operation</seealso>
        Task<CreateContextResponse> CreateContextAsync(CreateContextRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateDataQualityJobDefinition



        /// <summary>
        /// Creates a definition for a job that monitors data quality and drift. For information
        /// about model monitor, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/model-monitor.html">Amazon
        /// SageMaker AI Model Monitor</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDataQualityJobDefinition service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateDataQualityJobDefinition service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceInUseException">
        /// Resource being accessed is in use.
        /// </exception>
        /// <exception cref="Amazon.SageMaker.Model.ResourceLimitExceededException">
        /// You have exceeded an SageMaker resource limit. For example, you might have too many
        /// training jobs created.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateDataQualityJobDefinition">REST API Reference for CreateDataQualityJobDefinition Operation</seealso>
        Task<CreateDataQualityJobDefinitionResponse> CreateDataQualityJobDefinitionAsync(CreateDataQualityJobDefinitionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateDeviceFleet



        /// <summary>
        /// Creates a device fleet.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDeviceFleet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateDeviceFleet service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceInUseException">
        /// Resource being accessed is in use.
        /// </exception>
        /// <exception cref="Amazon.SageMaker.Model.ResourceLimitExceededException">
        /// You have exceeded an SageMaker resource limit. For example, you might have too many
        /// training jobs created.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateDeviceFleet">REST API Reference for CreateDeviceFleet Operation</seealso>
        Task<CreateDeviceFleetResponse> CreateDeviceFleetAsync(CreateDeviceFleetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateDomain



        /// <summary>
        /// Creates a <c>Domain</c>. A domain consists of an associated Amazon Elastic File System
        /// volume, a list of authorized users, and a variety of security, application, policy,
        /// and Amazon Virtual Private Cloud (VPC) configurations. Users within a domain can share
        /// notebook files and other artifacts with each other.
        /// 
        ///  
        /// <para>
        ///  <b>EFS storage</b> 
        /// </para>
        ///  
        /// <para>
        /// When a domain is created, an EFS volume is created for use by all of the users within
        /// the domain. Each user receives a private home directory within the EFS volume for
        /// notebooks, Git repositories, and data files.
        /// </para>
        ///  
        /// <para>
        /// SageMaker AI uses the Amazon Web Services Key Management Service (Amazon Web Services
        /// KMS) to encrypt the EFS volume attached to the domain with an Amazon Web Services
        /// managed key by default. For more control, you can specify a customer managed key.
        /// For more information, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/encryption-at-rest.html">Protect
        /// Data at Rest Using Encryption</a>.
        /// </para>
        ///  
        /// <para>
        ///  <b>VPC configuration</b> 
        /// </para>
        ///  
        /// <para>
        /// All traffic between the domain and the Amazon EFS volume is through the specified
        /// VPC and subnets. For other traffic, you can specify the <c>AppNetworkAccessType</c>
        /// parameter. <c>AppNetworkAccessType</c> corresponds to the network access type that
        /// you choose when you onboard to the domain. The following options are available:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>PublicInternetOnly</c> - Non-EFS traffic goes through a VPC managed by Amazon
        /// SageMaker AI, which allows internet access. This is the default value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>VpcOnly</c> - All traffic is through the specified VPC and subnets. Internet access
        /// is disabled by default. To allow internet access, you must specify a NAT gateway.
        /// </para>
        ///  
        /// <para>
        /// When internet access is disabled, you won't be able to run a Amazon SageMaker AI Studio
        /// notebook or to train or host models unless your VPC has an interface endpoint to the
        /// SageMaker AI API and runtime or a NAT gateway and your security groups allow outbound
        /// connections.
        /// </para>
        ///  </li> </ul> <important> 
        /// <para>
        /// NFS traffic over TCP on port 2049 needs to be allowed in both inbound and outbound
        /// rules in order to launch a Amazon SageMaker AI Studio app successfully.
        /// </para>
        ///  </important> 
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/studio-notebooks-and-internet-access.html">Connect
        /// Amazon SageMaker AI Studio Notebooks to Resources in a VPC</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDomain service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateDomain service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceInUseException">
        /// Resource being accessed is in use.
        /// </exception>
        /// <exception cref="Amazon.SageMaker.Model.ResourceLimitExceededException">
        /// You have exceeded an SageMaker resource limit. For example, you might have too many
        /// training jobs created.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateDomain">REST API Reference for CreateDomain Operation</seealso>
        Task<CreateDomainResponse> CreateDomainAsync(CreateDomainRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateEdgeDeploymentPlan



        /// <summary>
        /// Creates an edge deployment plan, consisting of multiple stages. Each stage may have
        /// a different deployment configuration and devices.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateEdgeDeploymentPlan service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateEdgeDeploymentPlan service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceLimitExceededException">
        /// You have exceeded an SageMaker resource limit. For example, you might have too many
        /// training jobs created.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateEdgeDeploymentPlan">REST API Reference for CreateEdgeDeploymentPlan Operation</seealso>
        Task<CreateEdgeDeploymentPlanResponse> CreateEdgeDeploymentPlanAsync(CreateEdgeDeploymentPlanRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateEdgeDeploymentStage



        /// <summary>
        /// Creates a new stage in an existing edge deployment plan.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateEdgeDeploymentStage service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateEdgeDeploymentStage service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceLimitExceededException">
        /// You have exceeded an SageMaker resource limit. For example, you might have too many
        /// training jobs created.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateEdgeDeploymentStage">REST API Reference for CreateEdgeDeploymentStage Operation</seealso>
        Task<CreateEdgeDeploymentStageResponse> CreateEdgeDeploymentStageAsync(CreateEdgeDeploymentStageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateEdgePackagingJob



        /// <summary>
        /// Starts a SageMaker Edge Manager model packaging job. Edge Manager will use the model
        /// artifacts from the Amazon Simple Storage Service bucket that you specify. After the
        /// model has been packaged, Amazon SageMaker saves the resulting artifacts to an S3 bucket
        /// that you specify.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateEdgePackagingJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateEdgePackagingJob service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceLimitExceededException">
        /// You have exceeded an SageMaker resource limit. For example, you might have too many
        /// training jobs created.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateEdgePackagingJob">REST API Reference for CreateEdgePackagingJob Operation</seealso>
        Task<CreateEdgePackagingJobResponse> CreateEdgePackagingJobAsync(CreateEdgePackagingJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateEndpoint



        /// <summary>
        /// Creates an endpoint using the endpoint configuration specified in the request. SageMaker
        /// uses the endpoint to provision resources and deploy models. You create the endpoint
        /// configuration with the <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_CreateEndpointConfig.html">CreateEndpointConfig</a>
        /// API. 
        /// 
        ///  
        /// <para>
        ///  Use this API to deploy models using SageMaker hosting services. 
        /// </para>
        ///  <note> 
        /// <para>
        ///  You must not delete an <c>EndpointConfig</c> that is in use by an endpoint that is
        /// live or while the <c>UpdateEndpoint</c> or <c>CreateEndpoint</c> operations are being
        /// performed on the endpoint. To update an endpoint, you must create a new <c>EndpointConfig</c>.
        /// </para>
        ///  </note> 
        /// <para>
        /// The endpoint name must be unique within an Amazon Web Services Region in your Amazon
        /// Web Services account. 
        /// </para>
        ///  
        /// <para>
        /// When it receives the request, SageMaker creates the endpoint, launches the resources
        /// (ML compute instances), and deploys the model(s) on them. 
        /// </para>
        ///  <note> 
        /// <para>
        /// When you call <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_CreateEndpoint.html">CreateEndpoint</a>,
        /// a load call is made to DynamoDB to verify that your endpoint configuration exists.
        /// When you read data from a DynamoDB table supporting <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/HowItWorks.ReadConsistency.html">
        /// <c>Eventually Consistent Reads</c> </a>, the response might not reflect the results
        /// of a recently completed write operation. The response might include some stale data.
        /// If the dependent entities are not yet in DynamoDB, this causes a validation error.
        /// If you repeat your read request after a short time, the response should return the
        /// latest data. So retry logic is recommended to handle these possible issues. We also
        /// recommend that customers call <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_DescribeEndpointConfig.html">DescribeEndpointConfig</a>
        /// before calling <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_CreateEndpoint.html">CreateEndpoint</a>
        /// to minimize the potential impact of a DynamoDB eventually consistent read.
        /// </para>
        ///  </note> 
        /// <para>
        /// When SageMaker receives the request, it sets the endpoint status to <c>Creating</c>.
        /// After it creates the endpoint, it sets the status to <c>InService</c>. SageMaker can
        /// then process incoming requests for inferences. To check the status of an endpoint,
        /// use the <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_DescribeEndpoint.html">DescribeEndpoint</a>
        /// API.
        /// </para>
        ///  
        /// <para>
        /// If any of the models hosted at this endpoint get model data from an Amazon S3 location,
        /// SageMaker uses Amazon Web Services Security Token Service to download model artifacts
        /// from the S3 path you provided. Amazon Web Services STS is activated in your Amazon
        /// Web Services account by default. If you previously deactivated Amazon Web Services
        /// STS for a region, you need to reactivate Amazon Web Services STS for that region.
        /// For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_credentials_temp_enable-regions.html">Activating
        /// and Deactivating Amazon Web Services STS in an Amazon Web Services Region</a> in the
        /// <i>Amazon Web Services Identity and Access Management User Guide</i>.
        /// </para>
        ///  <note> 
        /// <para>
        ///  To add the IAM role policies for using this API operation, go to the <a href="https://console.aws.amazon.com/iam/">IAM
        /// console</a>, and choose Roles in the left navigation pane. Search the IAM role that
        /// you want to grant access to use the <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_CreateEndpoint.html">CreateEndpoint</a>
        /// and <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_CreateEndpointConfig.html">CreateEndpointConfig</a>
        /// API operations, add the following policies to the role. 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Option 1: For a full SageMaker access, search and attach the <c>AmazonSageMakerFullAccess</c>
        /// policy.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Option 2: For granting a limited access to an IAM role, paste the following Action
        /// elements manually into the JSON file of the IAM role: 
        /// </para>
        ///  
        /// <para>
        ///  <c>"Action": ["sagemaker:CreateEndpoint", "sagemaker:CreateEndpointConfig"]</c> 
        /// </para>
        ///  
        /// <para>
        ///  <c>"Resource": [</c> 
        /// </para>
        ///  
        /// <para>
        ///  <c>"arn:aws:sagemaker:region:account-id:endpoint/endpointName"</c> 
        /// </para>
        ///  
        /// <para>
        ///  <c>"arn:aws:sagemaker:region:account-id:endpoint-config/endpointConfigName"</c> 
        /// </para>
        ///  
        /// <para>
        ///  <c>]</c> 
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/api-permissions-reference.html">SageMaker
        /// API Permissions: Actions, Permissions, and Resources Reference</a>.
        /// </para>
        ///  </li> </ul> </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateEndpoint service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateEndpoint service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceLimitExceededException">
        /// You have exceeded an SageMaker resource limit. For example, you might have too many
        /// training jobs created.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateEndpoint">REST API Reference for CreateEndpoint Operation</seealso>
        Task<CreateEndpointResponse> CreateEndpointAsync(CreateEndpointRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateEndpointConfig



        /// <summary>
        /// Creates an endpoint configuration that SageMaker hosting services uses to deploy models.
        /// In the configuration, you identify one or more models, created using the <c>CreateModel</c>
        /// API, to deploy and the resources that you want SageMaker to provision. Then you call
        /// the <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_CreateEndpoint.html">CreateEndpoint</a>
        /// API.
        /// 
        ///  <note> 
        /// <para>
        ///  Use this API if you want to use SageMaker hosting services to deploy models into
        /// production. 
        /// </para>
        ///  </note> 
        /// <para>
        /// In the request, you define a <c>ProductionVariant</c>, for each model that you want
        /// to deploy. Each <c>ProductionVariant</c> parameter also describes the resources that
        /// you want SageMaker to provision. This includes the number and type of ML compute instances
        /// to deploy. 
        /// </para>
        ///  
        /// <para>
        /// If you are hosting multiple models, you also assign a <c>VariantWeight</c> to specify
        /// how much traffic you want to allocate to each model. For example, suppose that you
        /// want to host two models, A and B, and you assign traffic weight 2 for model A and
        /// 1 for model B. SageMaker distributes two-thirds of the traffic to Model A, and one-third
        /// to model B. 
        /// </para>
        ///  <note> 
        /// <para>
        /// When you call <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_CreateEndpoint.html">CreateEndpoint</a>,
        /// a load call is made to DynamoDB to verify that your endpoint configuration exists.
        /// When you read data from a DynamoDB table supporting <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/HowItWorks.ReadConsistency.html">
        /// <c>Eventually Consistent Reads</c> </a>, the response might not reflect the results
        /// of a recently completed write operation. The response might include some stale data.
        /// If the dependent entities are not yet in DynamoDB, this causes a validation error.
        /// If you repeat your read request after a short time, the response should return the
        /// latest data. So retry logic is recommended to handle these possible issues. We also
        /// recommend that customers call <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_DescribeEndpointConfig.html">DescribeEndpointConfig</a>
        /// before calling <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_CreateEndpoint.html">CreateEndpoint</a>
        /// to minimize the potential impact of a DynamoDB eventually consistent read.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateEndpointConfig service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateEndpointConfig service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceLimitExceededException">
        /// You have exceeded an SageMaker resource limit. For example, you might have too many
        /// training jobs created.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateEndpointConfig">REST API Reference for CreateEndpointConfig Operation</seealso>
        Task<CreateEndpointConfigResponse> CreateEndpointConfigAsync(CreateEndpointConfigRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateExperiment



        /// <summary>
        /// Creates a SageMaker <i>experiment</i>. An experiment is a collection of <i>trials</i>
        /// that are observed, compared and evaluated as a group. A trial is a set of steps, called
        /// <i>trial components</i>, that produce a machine learning model.
        /// 
        ///  <note> 
        /// <para>
        /// In the Studio UI, trials are referred to as <i>run groups</i> and trial components
        /// are referred to as <i>runs</i>.
        /// </para>
        ///  </note> 
        /// <para>
        /// The goal of an experiment is to determine the components that produce the best model.
        /// Multiple trials are performed, each one isolating and measuring the impact of a change
        /// to one or more inputs, while keeping the remaining inputs constant.
        /// </para>
        ///  
        /// <para>
        /// When you use SageMaker Studio or the SageMaker Python SDK, all experiments, trials,
        /// and trial components are automatically tracked, logged, and indexed. When you use
        /// the Amazon Web Services SDK for Python (Boto), you must use the logging APIs provided
        /// by the SDK.
        /// </para>
        ///  
        /// <para>
        /// You can add tags to experiments, trials, trial components and then use the <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_Search.html">Search</a>
        /// API to search for the tags.
        /// </para>
        ///  
        /// <para>
        /// To add a description to an experiment, specify the optional <c>Description</c> parameter.
        /// To add a description later, or to change the description, call the <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_UpdateExperiment.html">UpdateExperiment</a>
        /// API.
        /// </para>
        ///  
        /// <para>
        /// To get a list of all your experiments, call the <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_ListExperiments.html">ListExperiments</a>
        /// API. To view an experiment's properties, call the <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_DescribeExperiment.html">DescribeExperiment</a>
        /// API. To get a list of all the trials associated with an experiment, call the <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_ListTrials.html">ListTrials</a>
        /// API. To create a trial call the <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_CreateTrial.html">CreateTrial</a>
        /// API.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateExperiment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateExperiment service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceLimitExceededException">
        /// You have exceeded an SageMaker resource limit. For example, you might have too many
        /// training jobs created.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateExperiment">REST API Reference for CreateExperiment Operation</seealso>
        Task<CreateExperimentResponse> CreateExperimentAsync(CreateExperimentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateFeatureGroup



        /// <summary>
        /// Create a new <c>FeatureGroup</c>. A <c>FeatureGroup</c> is a group of <c>Features</c>
        /// defined in the <c>FeatureStore</c> to describe a <c>Record</c>. 
        /// 
        ///  
        /// <para>
        /// The <c>FeatureGroup</c> defines the schema and features contained in the <c>FeatureGroup</c>.
        /// A <c>FeatureGroup</c> definition is composed of a list of <c>Features</c>, a <c>RecordIdentifierFeatureName</c>,
        /// an <c>EventTimeFeatureName</c> and configurations for its <c>OnlineStore</c> and <c>OfflineStore</c>.
        /// Check <a href="https://docs.aws.amazon.com/general/latest/gr/aws_service_limits.html">Amazon
        /// Web Services service quotas</a> to see the <c>FeatureGroup</c>s quota for your Amazon
        /// Web Services account.
        /// </para>
        ///  
        /// <para>
        /// Note that it can take approximately 10-15 minutes to provision an <c>OnlineStore</c>
        /// <c>FeatureGroup</c> with the <c>InMemory</c> <c>StorageType</c>.
        /// </para>
        ///  <important> 
        /// <para>
        /// You must include at least one of <c>OnlineStoreConfig</c> and <c>OfflineStoreConfig</c>
        /// to create a <c>FeatureGroup</c>.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateFeatureGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateFeatureGroup service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceInUseException">
        /// Resource being accessed is in use.
        /// </exception>
        /// <exception cref="Amazon.SageMaker.Model.ResourceLimitExceededException">
        /// You have exceeded an SageMaker resource limit. For example, you might have too many
        /// training jobs created.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateFeatureGroup">REST API Reference for CreateFeatureGroup Operation</seealso>
        Task<CreateFeatureGroupResponse> CreateFeatureGroupAsync(CreateFeatureGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateFlowDefinition



        /// <summary>
        /// Creates a flow definition.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateFlowDefinition service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateFlowDefinition service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceInUseException">
        /// Resource being accessed is in use.
        /// </exception>
        /// <exception cref="Amazon.SageMaker.Model.ResourceLimitExceededException">
        /// You have exceeded an SageMaker resource limit. For example, you might have too many
        /// training jobs created.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateFlowDefinition">REST API Reference for CreateFlowDefinition Operation</seealso>
        Task<CreateFlowDefinitionResponse> CreateFlowDefinitionAsync(CreateFlowDefinitionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateHub



        /// <summary>
        /// Create a hub.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateHub service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateHub service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceInUseException">
        /// Resource being accessed is in use.
        /// </exception>
        /// <exception cref="Amazon.SageMaker.Model.ResourceLimitExceededException">
        /// You have exceeded an SageMaker resource limit. For example, you might have too many
        /// training jobs created.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateHub">REST API Reference for CreateHub Operation</seealso>
        Task<CreateHubResponse> CreateHubAsync(CreateHubRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateHubContentPresignedUrls



        /// <summary>
        /// Creates presigned URLs for accessing hub content artifacts. This operation generates
        /// time-limited, secure URLs that allow direct download of model artifacts and associated
        /// files from Amazon SageMaker hub content, including gated models that require end-user
        /// license agreement acceptance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateHubContentPresignedUrls service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateHubContentPresignedUrls service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateHubContentPresignedUrls">REST API Reference for CreateHubContentPresignedUrls Operation</seealso>
        Task<CreateHubContentPresignedUrlsResponse> CreateHubContentPresignedUrlsAsync(CreateHubContentPresignedUrlsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateHubContentReference



        /// <summary>
        /// Create a hub content reference in order to add a model in the JumpStart public hub
        /// to a private hub.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateHubContentReference service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateHubContentReference service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceInUseException">
        /// Resource being accessed is in use.
        /// </exception>
        /// <exception cref="Amazon.SageMaker.Model.ResourceLimitExceededException">
        /// You have exceeded an SageMaker resource limit. For example, you might have too many
        /// training jobs created.
        /// </exception>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateHubContentReference">REST API Reference for CreateHubContentReference Operation</seealso>
        Task<CreateHubContentReferenceResponse> CreateHubContentReferenceAsync(CreateHubContentReferenceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateHumanTaskUi



        /// <summary>
        /// Defines the settings you will use for the human review workflow user interface. Reviewers
        /// will see a three-panel interface with an instruction area, the item to review, and
        /// an input area.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateHumanTaskUi service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateHumanTaskUi service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceInUseException">
        /// Resource being accessed is in use.
        /// </exception>
        /// <exception cref="Amazon.SageMaker.Model.ResourceLimitExceededException">
        /// You have exceeded an SageMaker resource limit. For example, you might have too many
        /// training jobs created.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateHumanTaskUi">REST API Reference for CreateHumanTaskUi Operation</seealso>
        Task<CreateHumanTaskUiResponse> CreateHumanTaskUiAsync(CreateHumanTaskUiRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateHyperParameterTuningJob



        /// <summary>
        /// Starts a hyperparameter tuning job. A hyperparameter tuning job finds the best version
        /// of a model by running many training jobs on your dataset using the algorithm you choose
        /// and values for hyperparameters within ranges that you specify. It then chooses the
        /// hyperparameter values that result in a model that performs the best, as measured by
        /// an objective metric that you choose.
        /// 
        ///  
        /// <para>
        /// A hyperparameter tuning job automatically creates Amazon SageMaker experiments, trials,
        /// and trial components for each training job that it runs. You can view these entities
        /// in Amazon SageMaker Studio. For more information, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/experiments-view-compare.html#experiments-view">View
        /// Experiments, Trials, and Trial Components</a>.
        /// </para>
        ///  <important> 
        /// <para>
        /// Do not include any security-sensitive information including account access IDs, secrets,
        /// or tokens in any hyperparameter fields. As part of the shared responsibility model,
        /// you are responsible for any potential exposure, unauthorized access, or compromise
        /// of your sensitive data if caused by any security-sensitive information included in
        /// the request hyperparameter variable or plain text fields..
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateHyperParameterTuningJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateHyperParameterTuningJob service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceInUseException">
        /// Resource being accessed is in use.
        /// </exception>
        /// <exception cref="Amazon.SageMaker.Model.ResourceLimitExceededException">
        /// You have exceeded an SageMaker resource limit. For example, you might have too many
        /// training jobs created.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateHyperParameterTuningJob">REST API Reference for CreateHyperParameterTuningJob Operation</seealso>
        Task<CreateHyperParameterTuningJobResponse> CreateHyperParameterTuningJobAsync(CreateHyperParameterTuningJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateImage



        /// <summary>
        /// Creates a custom SageMaker AI image. A SageMaker AI image is a set of image versions.
        /// Each image version represents a container image stored in Amazon ECR. For more information,
        /// see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/studio-byoi.html">Bring
        /// your own SageMaker AI image</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateImage service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateImage service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceInUseException">
        /// Resource being accessed is in use.
        /// </exception>
        /// <exception cref="Amazon.SageMaker.Model.ResourceLimitExceededException">
        /// You have exceeded an SageMaker resource limit. For example, you might have too many
        /// training jobs created.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateImage">REST API Reference for CreateImage Operation</seealso>
        Task<CreateImageResponse> CreateImageAsync(CreateImageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateImageVersion



        /// <summary>
        /// Creates a version of the SageMaker AI image specified by <c>ImageName</c>. The version
        /// represents the Amazon ECR container image specified by <c>BaseImage</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateImageVersion service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateImageVersion service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceInUseException">
        /// Resource being accessed is in use.
        /// </exception>
        /// <exception cref="Amazon.SageMaker.Model.ResourceLimitExceededException">
        /// You have exceeded an SageMaker resource limit. For example, you might have too many
        /// training jobs created.
        /// </exception>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateImageVersion">REST API Reference for CreateImageVersion Operation</seealso>
        Task<CreateImageVersionResponse> CreateImageVersionAsync(CreateImageVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateInferenceComponent



        /// <summary>
        /// Creates an inference component, which is a SageMaker AI hosting object that you can
        /// use to deploy a model to an endpoint. In the inference component settings, you specify
        /// the model, the endpoint, and how the model utilizes the resources that the endpoint
        /// hosts. You can optimize resource utilization by tailoring how the required CPU cores,
        /// accelerators, and memory are allocated. You can deploy multiple inference components
        /// to an endpoint, where each inference component contains one model and the resource
        /// utilization needs for that individual model. After you deploy an inference component,
        /// you can directly invoke the associated model when you use the InvokeEndpoint API action.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateInferenceComponent service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateInferenceComponent service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceLimitExceededException">
        /// You have exceeded an SageMaker resource limit. For example, you might have too many
        /// training jobs created.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateInferenceComponent">REST API Reference for CreateInferenceComponent Operation</seealso>
        Task<CreateInferenceComponentResponse> CreateInferenceComponentAsync(CreateInferenceComponentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateInferenceExperiment



        /// <summary>
        /// Creates an inference experiment using the configurations specified in the request.
        /// 
        /// 
        ///  
        /// <para>
        ///  Use this API to setup and schedule an experiment to compare model variants on a Amazon
        /// SageMaker inference endpoint. For more information about inference experiments, see
        /// <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/shadow-tests.html">Shadow
        /// tests</a>. 
        /// </para>
        ///  
        /// <para>
        ///  Amazon SageMaker begins your experiment at the scheduled time and routes traffic
        /// to your endpoint's model variants based on your specified configuration. 
        /// </para>
        ///  
        /// <para>
        ///  While the experiment is in progress or after it has concluded, you can view metrics
        /// that compare your model variants. For more information, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/shadow-tests-view-monitor-edit.html">View,
        /// monitor, and edit shadow tests</a>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateInferenceExperiment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateInferenceExperiment service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceInUseException">
        /// Resource being accessed is in use.
        /// </exception>
        /// <exception cref="Amazon.SageMaker.Model.ResourceLimitExceededException">
        /// You have exceeded an SageMaker resource limit. For example, you might have too many
        /// training jobs created.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateInferenceExperiment">REST API Reference for CreateInferenceExperiment Operation</seealso>
        Task<CreateInferenceExperimentResponse> CreateInferenceExperimentAsync(CreateInferenceExperimentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateInferenceRecommendationsJob



        /// <summary>
        /// Starts a recommendation job. You can create either an instance recommendation or load
        /// test job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateInferenceRecommendationsJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateInferenceRecommendationsJob service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceInUseException">
        /// Resource being accessed is in use.
        /// </exception>
        /// <exception cref="Amazon.SageMaker.Model.ResourceLimitExceededException">
        /// You have exceeded an SageMaker resource limit. For example, you might have too many
        /// training jobs created.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateInferenceRecommendationsJob">REST API Reference for CreateInferenceRecommendationsJob Operation</seealso>
        Task<CreateInferenceRecommendationsJobResponse> CreateInferenceRecommendationsJobAsync(CreateInferenceRecommendationsJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateLabelingJob



        /// <summary>
        /// Creates a job that uses workers to label the data objects in your input dataset. You
        /// can use the labeled data to train machine learning models. 
        /// 
        ///  
        /// <para>
        /// You can select your workforce from one of three providers:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// A private workforce that you create. It can include employees, contractors, and outside
        /// experts. Use a private workforce when want the data to stay within your organization
        /// or when a specific set of skills is required.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// One or more vendors that you select from the Amazon Web Services Marketplace. Vendors
        /// provide expertise in specific areas. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The Amazon Mechanical Turk workforce. This is the largest workforce, but it should
        /// only be used for public data or data that has been stripped of any personally identifiable
        /// information.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// You can also use <i>automated data labeling</i> to reduce the number of data objects
        /// that need to be labeled by a human. Automated data labeling uses <i>active learning</i>
        /// to determine if a data object can be labeled by machine or if it needs to be sent
        /// to a human worker. For more information, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/sms-automated-labeling.html">Using
        /// Automated Data Labeling</a>.
        /// </para>
        ///  
        /// <para>
        /// The data objects to be labeled are contained in an Amazon S3 bucket. You create a
        /// <i>manifest file</i> that describes the location of each object. For more information,
        /// see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/sms-data.html">Using
        /// Input and Output Data</a>.
        /// </para>
        ///  
        /// <para>
        /// The output can be used as the manifest file for another labeling job or as training
        /// data for your machine learning models.
        /// </para>
        ///  
        /// <para>
        /// You can use this operation to create a static labeling job or a streaming labeling
        /// job. A static labeling job stops if all data objects in the input manifest file identified
        /// in <c>ManifestS3Uri</c> have been labeled. A streaming labeling job runs perpetually
        /// until it is manually stopped, or remains idle for 10 days. You can send new data objects
        /// to an active (<c>InProgress</c>) streaming labeling job in real time. To learn how
        /// to create a static labeling job, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/sms-create-labeling-job-api.html">Create
        /// a Labeling Job (API) </a> in the Amazon SageMaker Developer Guide. To learn how to
        /// create a streaming labeling job, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/sms-streaming-create-job.html">Create
        /// a Streaming Labeling Job</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateLabelingJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateLabelingJob service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceInUseException">
        /// Resource being accessed is in use.
        /// </exception>
        /// <exception cref="Amazon.SageMaker.Model.ResourceLimitExceededException">
        /// You have exceeded an SageMaker resource limit. For example, you might have too many
        /// training jobs created.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateLabelingJob">REST API Reference for CreateLabelingJob Operation</seealso>
        Task<CreateLabelingJobResponse> CreateLabelingJobAsync(CreateLabelingJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateMlflowTrackingServer



        /// <summary>
        /// Creates an MLflow Tracking Server using a general purpose Amazon S3 bucket as the
        /// artifact store. For more information, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/mlflow-create-tracking-server.html">Create
        /// an MLflow Tracking Server</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateMlflowTrackingServer service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateMlflowTrackingServer service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceLimitExceededException">
        /// You have exceeded an SageMaker resource limit. For example, you might have too many
        /// training jobs created.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateMlflowTrackingServer">REST API Reference for CreateMlflowTrackingServer Operation</seealso>
        Task<CreateMlflowTrackingServerResponse> CreateMlflowTrackingServerAsync(CreateMlflowTrackingServerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateModel



        /// <summary>
        /// Creates a model in SageMaker. In the request, you name the model and describe a primary
        /// container. For the primary container, you specify the Docker image that contains inference
        /// code, artifacts (from prior training), and a custom environment map that the inference
        /// code uses when you deploy the model for predictions.
        /// 
        ///  
        /// <para>
        /// Use this API to create a model if you want to use SageMaker hosting services or run
        /// a batch transform job.
        /// </para>
        ///  
        /// <para>
        /// To host your model, you create an endpoint configuration with the <c>CreateEndpointConfig</c>
        /// API, and then create an endpoint with the <c>CreateEndpoint</c> API. SageMaker then
        /// deploys all of the containers that you defined for the model in the hosting environment.
        /// 
        /// </para>
        ///  
        /// <para>
        /// To run a batch transform using your model, you start a job with the <c>CreateTransformJob</c>
        /// API. SageMaker uses your model and your dataset to get inferences which are then saved
        /// to a specified S3 location.
        /// </para>
        ///  
        /// <para>
        /// In the request, you also provide an IAM role that SageMaker can assume to access model
        /// artifacts and docker image for deployment on ML compute hosting instances or for batch
        /// transform jobs. In addition, you also use the IAM role to manage permissions the inference
        /// code needs. For example, if the inference code access any other Amazon Web Services
        /// resources, you grant necessary permissions via this role.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateModel service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateModel service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceLimitExceededException">
        /// You have exceeded an SageMaker resource limit. For example, you might have too many
        /// training jobs created.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateModel">REST API Reference for CreateModel Operation</seealso>
        Task<CreateModelResponse> CreateModelAsync(CreateModelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateModelBiasJobDefinition



        /// <summary>
        /// Creates the definition for a model bias job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateModelBiasJobDefinition service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateModelBiasJobDefinition service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceInUseException">
        /// Resource being accessed is in use.
        /// </exception>
        /// <exception cref="Amazon.SageMaker.Model.ResourceLimitExceededException">
        /// You have exceeded an SageMaker resource limit. For example, you might have too many
        /// training jobs created.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateModelBiasJobDefinition">REST API Reference for CreateModelBiasJobDefinition Operation</seealso>
        Task<CreateModelBiasJobDefinitionResponse> CreateModelBiasJobDefinitionAsync(CreateModelBiasJobDefinitionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateModelCard



        /// <summary>
        /// Creates an Amazon SageMaker Model Card.
        /// 
        ///  
        /// <para>
        /// For information about how to use model cards, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/model-cards.html">Amazon
        /// SageMaker Model Card</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateModelCard service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateModelCard service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ConflictException">
        /// There was a conflict when you attempted to modify a SageMaker entity such as an <c>Experiment</c>
        /// or <c>Artifact</c>.
        /// </exception>
        /// <exception cref="Amazon.SageMaker.Model.ResourceLimitExceededException">
        /// You have exceeded an SageMaker resource limit. For example, you might have too many
        /// training jobs created.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateModelCard">REST API Reference for CreateModelCard Operation</seealso>
        Task<CreateModelCardResponse> CreateModelCardAsync(CreateModelCardRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateModelCardExportJob



        /// <summary>
        /// Creates an Amazon SageMaker Model Card export job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateModelCardExportJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateModelCardExportJob service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ConflictException">
        /// There was a conflict when you attempted to modify a SageMaker entity such as an <c>Experiment</c>
        /// or <c>Artifact</c>.
        /// </exception>
        /// <exception cref="Amazon.SageMaker.Model.ResourceLimitExceededException">
        /// You have exceeded an SageMaker resource limit. For example, you might have too many
        /// training jobs created.
        /// </exception>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateModelCardExportJob">REST API Reference for CreateModelCardExportJob Operation</seealso>
        Task<CreateModelCardExportJobResponse> CreateModelCardExportJobAsync(CreateModelCardExportJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateModelExplainabilityJobDefinition



        /// <summary>
        /// Creates the definition for a model explainability job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateModelExplainabilityJobDefinition service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateModelExplainabilityJobDefinition service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceInUseException">
        /// Resource being accessed is in use.
        /// </exception>
        /// <exception cref="Amazon.SageMaker.Model.ResourceLimitExceededException">
        /// You have exceeded an SageMaker resource limit. For example, you might have too many
        /// training jobs created.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateModelExplainabilityJobDefinition">REST API Reference for CreateModelExplainabilityJobDefinition Operation</seealso>
        Task<CreateModelExplainabilityJobDefinitionResponse> CreateModelExplainabilityJobDefinitionAsync(CreateModelExplainabilityJobDefinitionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateModelPackage



        /// <summary>
        /// Creates a model package that you can use to create SageMaker models or list on Amazon
        /// Web Services Marketplace, or a versioned model that is part of a model group. Buyers
        /// can subscribe to model packages listed on Amazon Web Services Marketplace to create
        /// models in SageMaker.
        /// 
        ///  
        /// <para>
        /// To create a model package by specifying a Docker container that contains your inference
        /// code and the Amazon S3 location of your model artifacts, provide values for <c>InferenceSpecification</c>.
        /// To create a model from an algorithm resource that you created or subscribed to in
        /// Amazon Web Services Marketplace, provide a value for <c>SourceAlgorithmSpecification</c>.
        /// </para>
        ///  <note> 
        /// <para>
        /// There are two types of model packages:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Versioned - a model that is part of a model group in the model registry.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Unversioned - a model package that is not part of a model group.
        /// </para>
        ///  </li> </ul> </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateModelPackage service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateModelPackage service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ConflictException">
        /// There was a conflict when you attempted to modify a SageMaker entity such as an <c>Experiment</c>
        /// or <c>Artifact</c>.
        /// </exception>
        /// <exception cref="Amazon.SageMaker.Model.ResourceLimitExceededException">
        /// You have exceeded an SageMaker resource limit. For example, you might have too many
        /// training jobs created.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateModelPackage">REST API Reference for CreateModelPackage Operation</seealso>
        Task<CreateModelPackageResponse> CreateModelPackageAsync(CreateModelPackageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateModelPackageGroup



        /// <summary>
        /// Creates a model group. A model group contains a group of model versions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateModelPackageGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateModelPackageGroup service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceLimitExceededException">
        /// You have exceeded an SageMaker resource limit. For example, you might have too many
        /// training jobs created.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateModelPackageGroup">REST API Reference for CreateModelPackageGroup Operation</seealso>
        Task<CreateModelPackageGroupResponse> CreateModelPackageGroupAsync(CreateModelPackageGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateModelQualityJobDefinition



        /// <summary>
        /// Creates a definition for a job that monitors model quality and drift. For information
        /// about model monitor, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/model-monitor.html">Amazon
        /// SageMaker AI Model Monitor</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateModelQualityJobDefinition service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateModelQualityJobDefinition service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceInUseException">
        /// Resource being accessed is in use.
        /// </exception>
        /// <exception cref="Amazon.SageMaker.Model.ResourceLimitExceededException">
        /// You have exceeded an SageMaker resource limit. For example, you might have too many
        /// training jobs created.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateModelQualityJobDefinition">REST API Reference for CreateModelQualityJobDefinition Operation</seealso>
        Task<CreateModelQualityJobDefinitionResponse> CreateModelQualityJobDefinitionAsync(CreateModelQualityJobDefinitionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateMonitoringSchedule



        /// <summary>
        /// Creates a schedule that regularly starts Amazon SageMaker AI Processing Jobs to monitor
        /// the data captured for an Amazon SageMaker AI Endpoint.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateMonitoringSchedule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateMonitoringSchedule service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceInUseException">
        /// Resource being accessed is in use.
        /// </exception>
        /// <exception cref="Amazon.SageMaker.Model.ResourceLimitExceededException">
        /// You have exceeded an SageMaker resource limit. For example, you might have too many
        /// training jobs created.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateMonitoringSchedule">REST API Reference for CreateMonitoringSchedule Operation</seealso>
        Task<CreateMonitoringScheduleResponse> CreateMonitoringScheduleAsync(CreateMonitoringScheduleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateNotebookInstance



        /// <summary>
        /// Creates an SageMaker AI notebook instance. A notebook instance is a machine learning
        /// (ML) compute instance running on a Jupyter notebook. 
        /// 
        ///  
        /// <para>
        /// In a <c>CreateNotebookInstance</c> request, specify the type of ML compute instance
        /// that you want to run. SageMaker AI launches the instance, installs common libraries
        /// that you can use to explore datasets for model training, and attaches an ML storage
        /// volume to the notebook instance. 
        /// </para>
        ///  
        /// <para>
        /// SageMaker AI also provides a set of example notebooks. Each notebook demonstrates
        /// how to use SageMaker AI with a specific algorithm or with a machine learning framework.
        /// 
        /// </para>
        ///  
        /// <para>
        /// After receiving the request, SageMaker AI does the following:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Creates a network interface in the SageMaker AI VPC.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// (Option) If you specified <c>SubnetId</c>, SageMaker AI creates a network interface
        /// in your own VPC, which is inferred from the subnet ID that you provide in the input.
        /// When creating this network interface, SageMaker AI attaches the security group that
        /// you specified in the request to the network interface that it creates in your VPC.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Launches an EC2 instance of the type specified in the request in the SageMaker AI
        /// VPC. If you specified <c>SubnetId</c> of your VPC, SageMaker AI specifies both network
        /// interfaces when launching this instance. This enables inbound traffic from your own
        /// VPC to the notebook instance, assuming that the security groups allow it.
        /// </para>
        ///  </li> </ol> 
        /// <para>
        /// After creating the notebook instance, SageMaker AI returns its Amazon Resource Name
        /// (ARN). You can't change the name of a notebook instance after you create it.
        /// </para>
        ///  
        /// <para>
        /// After SageMaker AI creates the notebook instance, you can connect to the Jupyter server
        /// and work in Jupyter notebooks. For example, you can write code to explore a dataset
        /// that you can use for model training, train a model, host models by creating SageMaker
        /// AI endpoints, and validate hosted models. 
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/how-it-works.html">How
        /// It Works</a>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateNotebookInstance service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateNotebookInstance service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceLimitExceededException">
        /// You have exceeded an SageMaker resource limit. For example, you might have too many
        /// training jobs created.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateNotebookInstance">REST API Reference for CreateNotebookInstance Operation</seealso>
        Task<CreateNotebookInstanceResponse> CreateNotebookInstanceAsync(CreateNotebookInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateNotebookInstanceLifecycleConfig



        /// <summary>
        /// Creates a lifecycle configuration that you can associate with a notebook instance.
        /// A <i>lifecycle configuration</i> is a collection of shell scripts that run when you
        /// create or start a notebook instance.
        /// 
        ///  
        /// <para>
        /// Each lifecycle configuration script has a limit of 16384 characters.
        /// </para>
        ///  
        /// <para>
        /// The value of the <c>$PATH</c> environment variable that is available to both scripts
        /// is <c>/sbin:bin:/usr/sbin:/usr/bin</c>.
        /// </para>
        ///  
        /// <para>
        /// View Amazon CloudWatch Logs for notebook instance lifecycle configurations in log
        /// group <c>/aws/sagemaker/NotebookInstances</c> in log stream <c>[notebook-instance-name]/[LifecycleConfigHook]</c>.
        /// </para>
        ///  
        /// <para>
        /// Lifecycle configuration scripts cannot run for longer than 5 minutes. If a script
        /// runs for longer than 5 minutes, it fails and the notebook instance is not created
        /// or started.
        /// </para>
        ///  
        /// <para>
        /// For information about notebook instance lifestyle configurations, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/notebook-lifecycle-config.html">Step
        /// 2.1: (Optional) Customize a Notebook Instance</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateNotebookInstanceLifecycleConfig service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateNotebookInstanceLifecycleConfig service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceLimitExceededException">
        /// You have exceeded an SageMaker resource limit. For example, you might have too many
        /// training jobs created.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateNotebookInstanceLifecycleConfig">REST API Reference for CreateNotebookInstanceLifecycleConfig Operation</seealso>
        Task<CreateNotebookInstanceLifecycleConfigResponse> CreateNotebookInstanceLifecycleConfigAsync(CreateNotebookInstanceLifecycleConfigRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateOptimizationJob



        /// <summary>
        /// Creates a job that optimizes a model for inference performance. To create the job,
        /// you provide the location of a source model, and you provide the settings for the optimization
        /// techniques that you want the job to apply. When the job completes successfully, SageMaker
        /// uploads the new optimized model to the output destination that you specify.
        /// 
        ///  
        /// <para>
        /// For more information about how to use this action, and about the supported optimization
        /// techniques, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/model-optimize.html">Optimize
        /// model inference with Amazon SageMaker</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateOptimizationJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateOptimizationJob service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceInUseException">
        /// Resource being accessed is in use.
        /// </exception>
        /// <exception cref="Amazon.SageMaker.Model.ResourceLimitExceededException">
        /// You have exceeded an SageMaker resource limit. For example, you might have too many
        /// training jobs created.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateOptimizationJob">REST API Reference for CreateOptimizationJob Operation</seealso>
        Task<CreateOptimizationJobResponse> CreateOptimizationJobAsync(CreateOptimizationJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreatePartnerApp



        /// <summary>
        /// Creates an Amazon SageMaker Partner AI App.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePartnerApp service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreatePartnerApp service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ConflictException">
        /// There was a conflict when you attempted to modify a SageMaker entity such as an <c>Experiment</c>
        /// or <c>Artifact</c>.
        /// </exception>
        /// <exception cref="Amazon.SageMaker.Model.ResourceLimitExceededException">
        /// You have exceeded an SageMaker resource limit. For example, you might have too many
        /// training jobs created.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreatePartnerApp">REST API Reference for CreatePartnerApp Operation</seealso>
        Task<CreatePartnerAppResponse> CreatePartnerAppAsync(CreatePartnerAppRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreatePartnerAppPresignedUrl



        /// <summary>
        /// Creates a presigned URL to access an Amazon SageMaker Partner AI App.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePartnerAppPresignedUrl service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreatePartnerAppPresignedUrl service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreatePartnerAppPresignedUrl">REST API Reference for CreatePartnerAppPresignedUrl Operation</seealso>
        Task<CreatePartnerAppPresignedUrlResponse> CreatePartnerAppPresignedUrlAsync(CreatePartnerAppPresignedUrlRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreatePipeline



        /// <summary>
        /// Creates a pipeline using a JSON pipeline definition.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePipeline service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreatePipeline service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ConflictException">
        /// There was a conflict when you attempted to modify a SageMaker entity such as an <c>Experiment</c>
        /// or <c>Artifact</c>.
        /// </exception>
        /// <exception cref="Amazon.SageMaker.Model.ResourceLimitExceededException">
        /// You have exceeded an SageMaker resource limit. For example, you might have too many
        /// training jobs created.
        /// </exception>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreatePipeline">REST API Reference for CreatePipeline Operation</seealso>
        Task<CreatePipelineResponse> CreatePipelineAsync(CreatePipelineRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreatePresignedDomainUrl



        /// <summary>
        /// Creates a URL for a specified UserProfile in a Domain. When accessed in a web browser,
        /// the user will be automatically signed in to the domain, and granted access to all
        /// of the Apps and files associated with the Domain's Amazon Elastic File System volume.
        /// This operation can only be called when the authentication mode equals IAM. 
        /// 
        ///  
        /// <para>
        /// The IAM role or user passed to this API defines the permissions to access the app.
        /// Once the presigned URL is created, no additional permission is required to access
        /// this URL. IAM authorization policies for this API are also enforced for every HTTP
        /// request and WebSocket frame that attempts to connect to the app.
        /// </para>
        ///  
        /// <para>
        /// You can restrict access to this API and to the URL that it returns to a list of IP
        /// addresses, Amazon VPCs or Amazon VPC Endpoints that you specify. For more information,
        /// see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/studio-interface-endpoint.html">Connect
        /// to Amazon SageMaker AI Studio Through an Interface VPC Endpoint</a> .
        /// </para>
        ///  <note> <ul> <li> 
        /// <para>
        /// The URL that you get from a call to <c>CreatePresignedDomainUrl</c> has a default
        /// timeout of 5 minutes. You can configure this value using <c>ExpiresInSeconds</c>.
        /// If you try to use the URL after the timeout limit expires, you are directed to the
        /// Amazon Web Services console sign-in page.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The JupyterLab session default expiration time is 12 hours. You can configure this
        /// value using SessionExpirationDurationInSeconds.
        /// </para>
        ///  </li> </ul> </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePresignedDomainUrl service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreatePresignedDomainUrl service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreatePresignedDomainUrl">REST API Reference for CreatePresignedDomainUrl Operation</seealso>
        Task<CreatePresignedDomainUrlResponse> CreatePresignedDomainUrlAsync(CreatePresignedDomainUrlRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreatePresignedMlflowTrackingServerUrl



        /// <summary>
        /// Returns a presigned URL that you can use to connect to the MLflow UI attached to your
        /// tracking server. For more information, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/mlflow-launch-ui.html">Launch
        /// the MLflow UI using a presigned URL</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePresignedMlflowTrackingServerUrl service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreatePresignedMlflowTrackingServerUrl service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreatePresignedMlflowTrackingServerUrl">REST API Reference for CreatePresignedMlflowTrackingServerUrl Operation</seealso>
        Task<CreatePresignedMlflowTrackingServerUrlResponse> CreatePresignedMlflowTrackingServerUrlAsync(CreatePresignedMlflowTrackingServerUrlRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreatePresignedNotebookInstanceUrl



        /// <summary>
        /// Returns a URL that you can use to connect to the Jupyter server from a notebook instance.
        /// In the SageMaker AI console, when you choose <c>Open</c> next to a notebook instance,
        /// SageMaker AI opens a new tab showing the Jupyter server home page from the notebook
        /// instance. The console uses this API to get the URL and show the page.
        /// 
        ///  
        /// <para>
        ///  The IAM role or user used to call this API defines the permissions to access the
        /// notebook instance. Once the presigned URL is created, no additional permission is
        /// required to access this URL. IAM authorization policies for this API are also enforced
        /// for every HTTP request and WebSocket frame that attempts to connect to the notebook
        /// instance.
        /// </para>
        ///  
        /// <para>
        /// You can restrict access to this API and to the URL that it returns to a list of IP
        /// addresses that you specify. Use the <c>NotIpAddress</c> condition operator and the
        /// <c>aws:SourceIP</c> condition context key to specify the list of IP addresses that
        /// you want to have access to the notebook instance. For more information, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/security_iam_id-based-policy-examples.html#nbi-ip-filter">Limit
        /// Access to a Notebook Instance by IP Address</a>.
        /// </para>
        ///  <note> 
        /// <para>
        /// The URL that you get from a call to <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_CreatePresignedNotebookInstanceUrl.html">CreatePresignedNotebookInstanceUrl</a>
        /// is valid only for 5 minutes. If you try to use the URL after the 5-minute limit expires,
        /// you are directed to the Amazon Web Services console sign-in page.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePresignedNotebookInstanceUrl service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreatePresignedNotebookInstanceUrl service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreatePresignedNotebookInstanceUrl">REST API Reference for CreatePresignedNotebookInstanceUrl Operation</seealso>
        Task<CreatePresignedNotebookInstanceUrlResponse> CreatePresignedNotebookInstanceUrlAsync(CreatePresignedNotebookInstanceUrlRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateProcessingJob



        /// <summary>
        /// Creates a processing job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateProcessingJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateProcessingJob service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceInUseException">
        /// Resource being accessed is in use.
        /// </exception>
        /// <exception cref="Amazon.SageMaker.Model.ResourceLimitExceededException">
        /// You have exceeded an SageMaker resource limit. For example, you might have too many
        /// training jobs created.
        /// </exception>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateProcessingJob">REST API Reference for CreateProcessingJob Operation</seealso>
        Task<CreateProcessingJobResponse> CreateProcessingJobAsync(CreateProcessingJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateProject



        /// <summary>
        /// Creates a machine learning (ML) project that can contain one or more templates that
        /// set up an ML pipeline from training to deploying an approved model.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateProject service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateProject service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceLimitExceededException">
        /// You have exceeded an SageMaker resource limit. For example, you might have too many
        /// training jobs created.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateProject">REST API Reference for CreateProject Operation</seealso>
        Task<CreateProjectResponse> CreateProjectAsync(CreateProjectRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateSpace



        /// <summary>
        /// Creates a private space or a space used for real time collaboration in a domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSpace service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateSpace service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceInUseException">
        /// Resource being accessed is in use.
        /// </exception>
        /// <exception cref="Amazon.SageMaker.Model.ResourceLimitExceededException">
        /// You have exceeded an SageMaker resource limit. For example, you might have too many
        /// training jobs created.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateSpace">REST API Reference for CreateSpace Operation</seealso>
        Task<CreateSpaceResponse> CreateSpaceAsync(CreateSpaceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateStudioLifecycleConfig



        /// <summary>
        /// Creates a new Amazon SageMaker AI Studio Lifecycle Configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateStudioLifecycleConfig service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateStudioLifecycleConfig service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceInUseException">
        /// Resource being accessed is in use.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateStudioLifecycleConfig">REST API Reference for CreateStudioLifecycleConfig Operation</seealso>
        Task<CreateStudioLifecycleConfigResponse> CreateStudioLifecycleConfigAsync(CreateStudioLifecycleConfigRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateTrainingJob



        /// <summary>
        /// Starts a model training job. After training completes, SageMaker saves the resulting
        /// model artifacts to an Amazon S3 location that you specify. 
        /// 
        ///  
        /// <para>
        /// If you choose to host your model using SageMaker hosting services, you can use the
        /// resulting model artifacts as part of the model. You can also use the artifacts in
        /// a machine learning service other than SageMaker, provided that you know how to use
        /// them for inference. 
        /// </para>
        ///  
        /// <para>
        /// In the request body, you provide the following: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>AlgorithmSpecification</c> - Identifies the training algorithm to use. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>HyperParameters</c> - Specify these algorithm-specific parameters to enable the
        /// estimation of model parameters during training. Hyperparameters can be tuned to optimize
        /// this learning process. For a list of hyperparameters for each training algorithm provided
        /// by SageMaker, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/algos.html">Algorithms</a>.
        /// 
        /// </para>
        ///  <important> 
        /// <para>
        /// Do not include any security-sensitive information including account access IDs, secrets,
        /// or tokens in any hyperparameter fields. As part of the shared responsibility model,
        /// you are responsible for any potential exposure, unauthorized access, or compromise
        /// of your sensitive data if caused by security-sensitive information included in the
        /// request hyperparameter variable or plain text fields.
        /// </para>
        ///  </important> </li> <li> 
        /// <para>
        ///  <c>InputDataConfig</c> - Describes the input required by the training job and the
        /// Amazon S3, EFS, or FSx location where it is stored.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>OutputDataConfig</c> - Identifies the Amazon S3 bucket where you want SageMaker
        /// to save the results of model training. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ResourceConfig</c> - Identifies the resources, ML compute instances, and ML storage
        /// volumes to deploy for model training. In distributed training, you specify more than
        /// one instance. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>EnableManagedSpotTraining</c> - Optimize the cost of training machine learning
        /// models by up to 80% by using Amazon EC2 Spot instances. For more information, see
        /// <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/model-managed-spot-training.html">Managed
        /// Spot Training</a>. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>RoleArn</c> - The Amazon Resource Name (ARN) that SageMaker assumes to perform
        /// tasks on your behalf during model training. You must grant this role the necessary
        /// permissions so that SageMaker can successfully complete model training. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>StoppingCondition</c> - To help cap training costs, use <c>MaxRuntimeInSeconds</c>
        /// to set a time limit for training. Use <c>MaxWaitTimeInSeconds</c> to specify how long
        /// a managed spot training job has to complete. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Environment</c> - The environment variables to set in the Docker container.
        /// </para>
        ///  <important> 
        /// <para>
        /// Do not include any security-sensitive information including account access IDs, secrets,
        /// or tokens in any environment fields. As part of the shared responsibility model, you
        /// are responsible for any potential exposure, unauthorized access, or compromise of
        /// your sensitive data if caused by security-sensitive information included in the request
        /// environment variable or plain text fields.
        /// </para>
        ///  </important> </li> <li> 
        /// <para>
        ///  <c>RetryStrategy</c> - The number of times to retry the job when the job fails due
        /// to an <c>InternalServerError</c>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  For more information about SageMaker, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/how-it-works.html">How
        /// It Works</a>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTrainingJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateTrainingJob service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceInUseException">
        /// Resource being accessed is in use.
        /// </exception>
        /// <exception cref="Amazon.SageMaker.Model.ResourceLimitExceededException">
        /// You have exceeded an SageMaker resource limit. For example, you might have too many
        /// training jobs created.
        /// </exception>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateTrainingJob">REST API Reference for CreateTrainingJob Operation</seealso>
        Task<CreateTrainingJobResponse> CreateTrainingJobAsync(CreateTrainingJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateTrainingPlan



        /// <summary>
        /// Creates a new training plan in SageMaker to reserve compute capacity.
        /// 
        ///  
        /// <para>
        /// Amazon SageMaker Training Plan is a capability within SageMaker that allows customers
        /// to reserve and manage GPU capacity for large-scale AI model training. It provides
        /// a way to secure predictable access to computational resources within specific timelines
        /// and budgets, without the need to manage underlying infrastructure. 
        /// </para>
        ///  
        /// <para>
        ///  <b>How it works</b> 
        /// </para>
        ///  
        /// <para>
        /// Plans can be created for specific resources such as SageMaker Training Jobs or SageMaker
        /// HyperPod clusters, automatically provisioning resources, setting up infrastructure,
        /// executing workloads, and handling infrastructure failures.
        /// </para>
        ///  
        /// <para>
        ///  <b>Plan creation workflow</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Users search for available plan offerings based on their requirements (e.g., instance
        /// type, count, start time, duration) using the <c> <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_SearchTrainingPlanOfferings.html">SearchTrainingPlanOfferings</a>
        /// </c> API operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// They create a plan that best matches their needs using the ID of the plan offering
        /// they want to use. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// After successful upfront payment, the plan's status becomes <c>Scheduled</c>. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The plan can be used to:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Queue training jobs.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Allocate to an instance group of a SageMaker HyperPod cluster. 
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        /// When the plan start date arrives, it becomes <c>Active</c>. Based on available reserved
        /// capacity:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Training jobs are launched.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Instance groups are provisioned.
        /// </para>
        ///  </li> </ul> </li> </ul> 
        /// <para>
        ///  <b>Plan composition</b> 
        /// </para>
        ///  
        /// <para>
        /// A plan can consist of one or more Reserved Capacities, each defined by a specific
        /// instance type, quantity, Availability Zone, duration, and start and end times. For
        /// more information about Reserved Capacity, see <c> <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_ReservedCapacitySummary.html">ReservedCapacitySummary</a>
        /// </c>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTrainingPlan service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateTrainingPlan service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceInUseException">
        /// Resource being accessed is in use.
        /// </exception>
        /// <exception cref="Amazon.SageMaker.Model.ResourceLimitExceededException">
        /// You have exceeded an SageMaker resource limit. For example, you might have too many
        /// training jobs created.
        /// </exception>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateTrainingPlan">REST API Reference for CreateTrainingPlan Operation</seealso>
        Task<CreateTrainingPlanResponse> CreateTrainingPlanAsync(CreateTrainingPlanRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateTransformJob



        /// <summary>
        /// Starts a transform job. A transform job uses a trained model to get inferences on
        /// a dataset and saves these results to an Amazon S3 location that you specify.
        /// 
        ///  
        /// <para>
        /// To perform batch transformations, you create a transform job and use the data that
        /// you have readily available.
        /// </para>
        ///  
        /// <para>
        /// In the request body, you provide the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>TransformJobName</c> - Identifies the transform job. The name must be unique within
        /// an Amazon Web Services Region in an Amazon Web Services account.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ModelName</c> - Identifies the model to use. <c>ModelName</c> must be the name
        /// of an existing Amazon SageMaker model in the same Amazon Web Services Region and Amazon
        /// Web Services account. For information on creating a model, see <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_CreateModel.html">CreateModel</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>TransformInput</c> - Describes the dataset to be transformed and the Amazon S3
        /// location where it is stored.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>TransformOutput</c> - Identifies the Amazon S3 location where you want Amazon
        /// SageMaker to save the results from the transform job.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>TransformResources</c> - Identifies the ML compute instances and AMI image versions
        /// for the transform job.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information about how batch transformation works, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/batch-transform.html">Batch
        /// Transform</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTransformJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateTransformJob service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceInUseException">
        /// Resource being accessed is in use.
        /// </exception>
        /// <exception cref="Amazon.SageMaker.Model.ResourceLimitExceededException">
        /// You have exceeded an SageMaker resource limit. For example, you might have too many
        /// training jobs created.
        /// </exception>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateTransformJob">REST API Reference for CreateTransformJob Operation</seealso>
        Task<CreateTransformJobResponse> CreateTransformJobAsync(CreateTransformJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateTrial



        /// <summary>
        /// Creates an SageMaker <i>trial</i>. A trial is a set of steps called <i>trial components</i>
        /// that produce a machine learning model. A trial is part of a single SageMaker <i>experiment</i>.
        /// 
        ///  
        /// <para>
        /// When you use SageMaker Studio or the SageMaker Python SDK, all experiments, trials,
        /// and trial components are automatically tracked, logged, and indexed. When you use
        /// the Amazon Web Services SDK for Python (Boto), you must use the logging APIs provided
        /// by the SDK.
        /// </para>
        ///  
        /// <para>
        /// You can add tags to a trial and then use the <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_Search.html">Search</a>
        /// API to search for the tags.
        /// </para>
        ///  
        /// <para>
        /// To get a list of all your trials, call the <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_ListTrials.html">ListTrials</a>
        /// API. To view a trial's properties, call the <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_DescribeTrial.html">DescribeTrial</a>
        /// API. To create a trial component, call the <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_CreateTrialComponent.html">CreateTrialComponent</a>
        /// API.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTrial service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateTrial service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceLimitExceededException">
        /// You have exceeded an SageMaker resource limit. For example, you might have too many
        /// training jobs created.
        /// </exception>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateTrial">REST API Reference for CreateTrial Operation</seealso>
        Task<CreateTrialResponse> CreateTrialAsync(CreateTrialRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateTrialComponent



        /// <summary>
        /// Creates a <i>trial component</i>, which is a stage of a machine learning <i>trial</i>.
        /// A trial is composed of one or more trial components. A trial component can be used
        /// in multiple trials.
        /// 
        ///  
        /// <para>
        /// Trial components include pre-processing jobs, training jobs, and batch transform jobs.
        /// </para>
        ///  
        /// <para>
        /// When you use SageMaker Studio or the SageMaker Python SDK, all experiments, trials,
        /// and trial components are automatically tracked, logged, and indexed. When you use
        /// the Amazon Web Services SDK for Python (Boto), you must use the logging APIs provided
        /// by the SDK.
        /// </para>
        ///  
        /// <para>
        /// You can add tags to a trial component and then use the <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_Search.html">Search</a>
        /// API to search for the tags.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTrialComponent service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateTrialComponent service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceLimitExceededException">
        /// You have exceeded an SageMaker resource limit. For example, you might have too many
        /// training jobs created.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateTrialComponent">REST API Reference for CreateTrialComponent Operation</seealso>
        Task<CreateTrialComponentResponse> CreateTrialComponentAsync(CreateTrialComponentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateUserProfile



        /// <summary>
        /// Creates a user profile. A user profile represents a single user within a domain, and
        /// is the main way to reference a "person" for the purposes of sharing, reporting, and
        /// other user-oriented features. This entity is created when a user onboards to a domain.
        /// If an administrator invites a person by email or imports them from IAM Identity Center,
        /// a user profile is automatically created. A user profile is the primary holder of settings
        /// for an individual user and has a reference to the user's private Amazon Elastic File
        /// System home directory.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateUserProfile service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateUserProfile service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceInUseException">
        /// Resource being accessed is in use.
        /// </exception>
        /// <exception cref="Amazon.SageMaker.Model.ResourceLimitExceededException">
        /// You have exceeded an SageMaker resource limit. For example, you might have too many
        /// training jobs created.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateUserProfile">REST API Reference for CreateUserProfile Operation</seealso>
        Task<CreateUserProfileResponse> CreateUserProfileAsync(CreateUserProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateWorkforce



        /// <summary>
        /// Use this operation to create a workforce. This operation will return an error if a
        /// workforce already exists in the Amazon Web Services Region that you specify. You can
        /// only create one workforce in each Amazon Web Services Region per Amazon Web Services
        /// account.
        /// 
        ///  
        /// <para>
        /// If you want to create a new workforce in an Amazon Web Services Region where a workforce
        /// already exists, use the <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_DeleteWorkforce.html">DeleteWorkforce</a>
        /// API operation to delete the existing workforce and then use <c>CreateWorkforce</c>
        /// to create a new workforce.
        /// </para>
        ///  
        /// <para>
        /// To create a private workforce using Amazon Cognito, you must specify a Cognito user
        /// pool in <c>CognitoConfig</c>. You can also create an Amazon Cognito workforce using
        /// the Amazon SageMaker console. For more information, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/sms-workforce-create-private.html">
        /// Create a Private Workforce (Amazon Cognito)</a>.
        /// </para>
        ///  
        /// <para>
        /// To create a private workforce using your own OIDC Identity Provider (IdP), specify
        /// your IdP configuration in <c>OidcConfig</c>. Your OIDC IdP must support <i>groups</i>
        /// because groups are used by Ground Truth and Amazon A2I to create work teams. For more
        /// information, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/sms-workforce-create-private-oidc.html">
        /// Create a Private Workforce (OIDC IdP)</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateWorkforce service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateWorkforce service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateWorkforce">REST API Reference for CreateWorkforce Operation</seealso>
        Task<CreateWorkforceResponse> CreateWorkforceAsync(CreateWorkforceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateWorkteam



        /// <summary>
        /// Creates a new work team for labeling your data. A work team is defined by one or more
        /// Amazon Cognito user pools. You must first create the user pools before you can create
        /// a work team.
        /// 
        ///  
        /// <para>
        /// You cannot create more than 25 work teams in an account and region.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateWorkteam service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateWorkteam service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceInUseException">
        /// Resource being accessed is in use.
        /// </exception>
        /// <exception cref="Amazon.SageMaker.Model.ResourceLimitExceededException">
        /// You have exceeded an SageMaker resource limit. For example, you might have too many
        /// training jobs created.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateWorkteam">REST API Reference for CreateWorkteam Operation</seealso>
        Task<CreateWorkteamResponse> CreateWorkteamAsync(CreateWorkteamRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteAction



        /// <summary>
        /// Deletes an action.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAction service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteAction service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteAction">REST API Reference for DeleteAction Operation</seealso>
        Task<DeleteActionResponse> DeleteActionAsync(DeleteActionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteAlgorithm



        /// <summary>
        /// Removes the specified algorithm from your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAlgorithm service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteAlgorithm service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ConflictException">
        /// There was a conflict when you attempted to modify a SageMaker entity such as an <c>Experiment</c>
        /// or <c>Artifact</c>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteAlgorithm">REST API Reference for DeleteAlgorithm Operation</seealso>
        Task<DeleteAlgorithmResponse> DeleteAlgorithmAsync(DeleteAlgorithmRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteApp



        /// <summary>
        /// Used to stop and delete an app.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteApp service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteApp service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceInUseException">
        /// Resource being accessed is in use.
        /// </exception>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteApp">REST API Reference for DeleteApp Operation</seealso>
        Task<DeleteAppResponse> DeleteAppAsync(DeleteAppRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteAppImageConfig



        /// <summary>
        /// Deletes an AppImageConfig.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAppImageConfig service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteAppImageConfig service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteAppImageConfig">REST API Reference for DeleteAppImageConfig Operation</seealso>
        Task<DeleteAppImageConfigResponse> DeleteAppImageConfigAsync(DeleteAppImageConfigRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteArtifact



        /// <summary>
        /// Deletes an artifact. Either <c>ArtifactArn</c> or <c>Source</c> must be specified.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteArtifact service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteArtifact service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteArtifact">REST API Reference for DeleteArtifact Operation</seealso>
        Task<DeleteArtifactResponse> DeleteArtifactAsync(DeleteArtifactRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteAssociation



        /// <summary>
        /// Deletes an association.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAssociation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteAssociation service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteAssociation">REST API Reference for DeleteAssociation Operation</seealso>
        Task<DeleteAssociationResponse> DeleteAssociationAsync(DeleteAssociationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteCluster



        /// <summary>
        /// Delete a SageMaker HyperPod cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCluster service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteCluster service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ConflictException">
        /// There was a conflict when you attempted to modify a SageMaker entity such as an <c>Experiment</c>
        /// or <c>Artifact</c>.
        /// </exception>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteCluster">REST API Reference for DeleteCluster Operation</seealso>
        Task<DeleteClusterResponse> DeleteClusterAsync(DeleteClusterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteClusterSchedulerConfig



        /// <summary>
        /// Deletes the cluster policy of the cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteClusterSchedulerConfig service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteClusterSchedulerConfig service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteClusterSchedulerConfig">REST API Reference for DeleteClusterSchedulerConfig Operation</seealso>
        Task<DeleteClusterSchedulerConfigResponse> DeleteClusterSchedulerConfigAsync(DeleteClusterSchedulerConfigRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteCodeRepository



        /// <summary>
        /// Deletes the specified Git repository from your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCodeRepository service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteCodeRepository service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteCodeRepository">REST API Reference for DeleteCodeRepository Operation</seealso>
        Task<DeleteCodeRepositoryResponse> DeleteCodeRepositoryAsync(DeleteCodeRepositoryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteCompilationJob



        /// <summary>
        /// Deletes the specified compilation job. This action deletes only the compilation job
        /// resource in Amazon SageMaker AI. It doesn't delete other resources that are related
        /// to that job, such as the model artifacts that the job creates, the compilation logs
        /// in CloudWatch, the compiled model, or the IAM role.
        /// 
        ///  
        /// <para>
        /// You can delete a compilation job only if its current status is <c>COMPLETED</c>, <c>FAILED</c>,
        /// or <c>STOPPED</c>. If the job status is <c>STARTING</c> or <c>INPROGRESS</c>, stop
        /// the job, and then delete it after its status becomes <c>STOPPED</c>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCompilationJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteCompilationJob service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteCompilationJob">REST API Reference for DeleteCompilationJob Operation</seealso>
        Task<DeleteCompilationJobResponse> DeleteCompilationJobAsync(DeleteCompilationJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteComputeQuota



        /// <summary>
        /// Deletes the compute allocation from the cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteComputeQuota service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteComputeQuota service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteComputeQuota">REST API Reference for DeleteComputeQuota Operation</seealso>
        Task<DeleteComputeQuotaResponse> DeleteComputeQuotaAsync(DeleteComputeQuotaRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteContext



        /// <summary>
        /// Deletes an context.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteContext service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteContext service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteContext">REST API Reference for DeleteContext Operation</seealso>
        Task<DeleteContextResponse> DeleteContextAsync(DeleteContextRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteDataQualityJobDefinition



        /// <summary>
        /// Deletes a data quality monitoring job definition.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDataQualityJobDefinition service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteDataQualityJobDefinition service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteDataQualityJobDefinition">REST API Reference for DeleteDataQualityJobDefinition Operation</seealso>
        Task<DeleteDataQualityJobDefinitionResponse> DeleteDataQualityJobDefinitionAsync(DeleteDataQualityJobDefinitionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteDeviceFleet



        /// <summary>
        /// Deletes a fleet.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDeviceFleet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteDeviceFleet service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceInUseException">
        /// Resource being accessed is in use.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteDeviceFleet">REST API Reference for DeleteDeviceFleet Operation</seealso>
        Task<DeleteDeviceFleetResponse> DeleteDeviceFleetAsync(DeleteDeviceFleetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteDomain



        /// <summary>
        /// Used to delete a domain. If you onboarded with IAM mode, you will need to delete your
        /// domain to onboard again using IAM Identity Center. Use with caution. All of the members
        /// of the domain will lose access to their EFS volume, including data, notebooks, and
        /// other artifacts.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDomain service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteDomain service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceInUseException">
        /// Resource being accessed is in use.
        /// </exception>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteDomain">REST API Reference for DeleteDomain Operation</seealso>
        Task<DeleteDomainResponse> DeleteDomainAsync(DeleteDomainRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteEdgeDeploymentPlan



        /// <summary>
        /// Deletes an edge deployment plan if (and only if) all the stages in the plan are inactive
        /// or there are no stages in the plan.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteEdgeDeploymentPlan service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteEdgeDeploymentPlan service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceInUseException">
        /// Resource being accessed is in use.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteEdgeDeploymentPlan">REST API Reference for DeleteEdgeDeploymentPlan Operation</seealso>
        Task<DeleteEdgeDeploymentPlanResponse> DeleteEdgeDeploymentPlanAsync(DeleteEdgeDeploymentPlanRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteEdgeDeploymentStage



        /// <summary>
        /// Delete a stage in an edge deployment plan if (and only if) the stage is inactive.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteEdgeDeploymentStage service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteEdgeDeploymentStage service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceInUseException">
        /// Resource being accessed is in use.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteEdgeDeploymentStage">REST API Reference for DeleteEdgeDeploymentStage Operation</seealso>
        Task<DeleteEdgeDeploymentStageResponse> DeleteEdgeDeploymentStageAsync(DeleteEdgeDeploymentStageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteEndpoint



        /// <summary>
        /// Deletes an endpoint. SageMaker frees up all of the resources that were deployed when
        /// the endpoint was created. 
        /// 
        ///  
        /// <para>
        /// SageMaker retires any custom KMS key grants associated with the endpoint, meaning
        /// you don't need to use the <a href="http://docs.aws.amazon.com/kms/latest/APIReference/API_RevokeGrant.html">RevokeGrant</a>
        /// API call.
        /// </para>
        ///  
        /// <para>
        /// When you delete your endpoint, SageMaker asynchronously deletes associated endpoint
        /// resources such as KMS key grants. You might still see these resources in your account
        /// for a few minutes after deleting your endpoint. Do not delete or revoke the permissions
        /// for your <c> <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_CreateModel.html#sagemaker-CreateModel-request-ExecutionRoleArn">ExecutionRoleArn</a>
        /// </c>, otherwise SageMaker cannot delete these resources.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteEndpoint service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteEndpoint service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteEndpoint">REST API Reference for DeleteEndpoint Operation</seealso>
        Task<DeleteEndpointResponse> DeleteEndpointAsync(DeleteEndpointRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteEndpointConfig



        /// <summary>
        /// Deletes an endpoint configuration. The <c>DeleteEndpointConfig</c> API deletes only
        /// the specified configuration. It does not delete endpoints created using the configuration.
        /// 
        /// 
        ///  
        /// <para>
        /// You must not delete an <c>EndpointConfig</c> in use by an endpoint that is live or
        /// while the <c>UpdateEndpoint</c> or <c>CreateEndpoint</c> operations are being performed
        /// on the endpoint. If you delete the <c>EndpointConfig</c> of an endpoint that is active
        /// or being created or updated you may lose visibility into the instance type the endpoint
        /// is using. The endpoint must be deleted in order to stop incurring charges.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteEndpointConfig service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteEndpointConfig service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteEndpointConfig">REST API Reference for DeleteEndpointConfig Operation</seealso>
        Task<DeleteEndpointConfigResponse> DeleteEndpointConfigAsync(DeleteEndpointConfigRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteExperiment



        /// <summary>
        /// Deletes an SageMaker experiment. All trials associated with the experiment must be
        /// deleted first. Use the <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_ListTrials.html">ListTrials</a>
        /// API to get a list of the trials associated with the experiment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteExperiment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteExperiment service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteExperiment">REST API Reference for DeleteExperiment Operation</seealso>
        Task<DeleteExperimentResponse> DeleteExperimentAsync(DeleteExperimentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteFeatureGroup



        /// <summary>
        /// Delete the <c>FeatureGroup</c> and any data that was written to the <c>OnlineStore</c>
        /// of the <c>FeatureGroup</c>. Data cannot be accessed from the <c>OnlineStore</c> immediately
        /// after <c>DeleteFeatureGroup</c> is called. 
        /// 
        ///  
        /// <para>
        /// Data written into the <c>OfflineStore</c> will not be deleted. The Amazon Web Services
        /// Glue database and tables that are automatically created for your <c>OfflineStore</c>
        /// are not deleted. 
        /// </para>
        ///  
        /// <para>
        /// Note that it can take approximately 10-15 minutes to delete an <c>OnlineStore</c>
        /// <c>FeatureGroup</c> with the <c>InMemory</c> <c>StorageType</c>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteFeatureGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteFeatureGroup service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteFeatureGroup">REST API Reference for DeleteFeatureGroup Operation</seealso>
        Task<DeleteFeatureGroupResponse> DeleteFeatureGroupAsync(DeleteFeatureGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteFlowDefinition



        /// <summary>
        /// Deletes the specified flow definition.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteFlowDefinition service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteFlowDefinition service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceInUseException">
        /// Resource being accessed is in use.
        /// </exception>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteFlowDefinition">REST API Reference for DeleteFlowDefinition Operation</seealso>
        Task<DeleteFlowDefinitionResponse> DeleteFlowDefinitionAsync(DeleteFlowDefinitionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteHub



        /// <summary>
        /// Delete a hub.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteHub service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteHub service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceInUseException">
        /// Resource being accessed is in use.
        /// </exception>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteHub">REST API Reference for DeleteHub Operation</seealso>
        Task<DeleteHubResponse> DeleteHubAsync(DeleteHubRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteHubContent



        /// <summary>
        /// Delete the contents of a hub.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteHubContent service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteHubContent service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceInUseException">
        /// Resource being accessed is in use.
        /// </exception>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteHubContent">REST API Reference for DeleteHubContent Operation</seealso>
        Task<DeleteHubContentResponse> DeleteHubContentAsync(DeleteHubContentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteHubContentReference



        /// <summary>
        /// Delete a hub content reference in order to remove a model from a private hub.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteHubContentReference service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteHubContentReference service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteHubContentReference">REST API Reference for DeleteHubContentReference Operation</seealso>
        Task<DeleteHubContentReferenceResponse> DeleteHubContentReferenceAsync(DeleteHubContentReferenceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteHumanTaskUi



        /// <summary>
        /// Use this operation to delete a human task user interface (worker task template).
        /// 
        ///  
        /// <para>
        ///  To see a list of human task user interfaces (work task templates) in your account,
        /// use <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_ListHumanTaskUis.html">ListHumanTaskUis</a>.
        /// When you delete a worker task template, it no longer appears when you call <c>ListHumanTaskUis</c>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteHumanTaskUi service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteHumanTaskUi service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteHumanTaskUi">REST API Reference for DeleteHumanTaskUi Operation</seealso>
        Task<DeleteHumanTaskUiResponse> DeleteHumanTaskUiAsync(DeleteHumanTaskUiRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteHyperParameterTuningJob



        /// <summary>
        /// Deletes a hyperparameter tuning job. The <c>DeleteHyperParameterTuningJob</c> API
        /// deletes only the tuning job entry that was created in SageMaker when you called the
        /// <c>CreateHyperParameterTuningJob</c> API. It does not delete training jobs, artifacts,
        /// or the IAM role that you specified when creating the model.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteHyperParameterTuningJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteHyperParameterTuningJob service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteHyperParameterTuningJob">REST API Reference for DeleteHyperParameterTuningJob Operation</seealso>
        Task<DeleteHyperParameterTuningJobResponse> DeleteHyperParameterTuningJobAsync(DeleteHyperParameterTuningJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteImage



        /// <summary>
        /// Deletes a SageMaker AI image and all versions of the image. The container images aren't
        /// deleted.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteImage service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteImage service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceInUseException">
        /// Resource being accessed is in use.
        /// </exception>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteImage">REST API Reference for DeleteImage Operation</seealso>
        Task<DeleteImageResponse> DeleteImageAsync(DeleteImageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteImageVersion



        /// <summary>
        /// Deletes a version of a SageMaker AI image. The container image the version represents
        /// isn't deleted.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteImageVersion service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteImageVersion service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceInUseException">
        /// Resource being accessed is in use.
        /// </exception>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteImageVersion">REST API Reference for DeleteImageVersion Operation</seealso>
        Task<DeleteImageVersionResponse> DeleteImageVersionAsync(DeleteImageVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteInferenceComponent



        /// <summary>
        /// Deletes an inference component.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteInferenceComponent service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteInferenceComponent service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteInferenceComponent">REST API Reference for DeleteInferenceComponent Operation</seealso>
        Task<DeleteInferenceComponentResponse> DeleteInferenceComponentAsync(DeleteInferenceComponentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteInferenceExperiment



        /// <summary>
        /// Deletes an inference experiment.
        /// 
        ///  <note> 
        /// <para>
        ///  This operation does not delete your endpoint, variants, or any underlying resources.
        /// This operation only deletes the metadata of your experiment. 
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteInferenceExperiment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteInferenceExperiment service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ConflictException">
        /// There was a conflict when you attempted to modify a SageMaker entity such as an <c>Experiment</c>
        /// or <c>Artifact</c>.
        /// </exception>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteInferenceExperiment">REST API Reference for DeleteInferenceExperiment Operation</seealso>
        Task<DeleteInferenceExperimentResponse> DeleteInferenceExperimentAsync(DeleteInferenceExperimentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteMlflowTrackingServer



        /// <summary>
        /// Deletes an MLflow Tracking Server. For more information, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/mlflow-cleanup.html.html">Clean
        /// up MLflow resources</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteMlflowTrackingServer service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteMlflowTrackingServer service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteMlflowTrackingServer">REST API Reference for DeleteMlflowTrackingServer Operation</seealso>
        Task<DeleteMlflowTrackingServerResponse> DeleteMlflowTrackingServerAsync(DeleteMlflowTrackingServerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteModel



        /// <summary>
        /// Deletes a model. The <c>DeleteModel</c> API deletes only the model entry that was
        /// created in SageMaker when you called the <c>CreateModel</c> API. It does not delete
        /// model artifacts, inference code, or the IAM role that you specified when creating
        /// the model.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteModel service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteModel service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteModel">REST API Reference for DeleteModel Operation</seealso>
        Task<DeleteModelResponse> DeleteModelAsync(DeleteModelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteModelBiasJobDefinition



        /// <summary>
        /// Deletes an Amazon SageMaker AI model bias job definition.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteModelBiasJobDefinition service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteModelBiasJobDefinition service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteModelBiasJobDefinition">REST API Reference for DeleteModelBiasJobDefinition Operation</seealso>
        Task<DeleteModelBiasJobDefinitionResponse> DeleteModelBiasJobDefinitionAsync(DeleteModelBiasJobDefinitionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteModelCard



        /// <summary>
        /// Deletes an Amazon SageMaker Model Card.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteModelCard service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteModelCard service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ConflictException">
        /// There was a conflict when you attempted to modify a SageMaker entity such as an <c>Experiment</c>
        /// or <c>Artifact</c>.
        /// </exception>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteModelCard">REST API Reference for DeleteModelCard Operation</seealso>
        Task<DeleteModelCardResponse> DeleteModelCardAsync(DeleteModelCardRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteModelExplainabilityJobDefinition



        /// <summary>
        /// Deletes an Amazon SageMaker AI model explainability job definition.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteModelExplainabilityJobDefinition service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteModelExplainabilityJobDefinition service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteModelExplainabilityJobDefinition">REST API Reference for DeleteModelExplainabilityJobDefinition Operation</seealso>
        Task<DeleteModelExplainabilityJobDefinitionResponse> DeleteModelExplainabilityJobDefinitionAsync(DeleteModelExplainabilityJobDefinitionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteModelPackage



        /// <summary>
        /// Deletes a model package.
        /// 
        ///  
        /// <para>
        /// A model package is used to create SageMaker models or list on Amazon Web Services
        /// Marketplace. Buyers can subscribe to model packages listed on Amazon Web Services
        /// Marketplace to create models in SageMaker.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteModelPackage service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteModelPackage service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ConflictException">
        /// There was a conflict when you attempted to modify a SageMaker entity such as an <c>Experiment</c>
        /// or <c>Artifact</c>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteModelPackage">REST API Reference for DeleteModelPackage Operation</seealso>
        Task<DeleteModelPackageResponse> DeleteModelPackageAsync(DeleteModelPackageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteModelPackageGroup



        /// <summary>
        /// Deletes the specified model group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteModelPackageGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteModelPackageGroup service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ConflictException">
        /// There was a conflict when you attempted to modify a SageMaker entity such as an <c>Experiment</c>
        /// or <c>Artifact</c>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteModelPackageGroup">REST API Reference for DeleteModelPackageGroup Operation</seealso>
        Task<DeleteModelPackageGroupResponse> DeleteModelPackageGroupAsync(DeleteModelPackageGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteModelPackageGroupPolicy



        /// <summary>
        /// Deletes a model group resource policy.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteModelPackageGroupPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteModelPackageGroupPolicy service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteModelPackageGroupPolicy">REST API Reference for DeleteModelPackageGroupPolicy Operation</seealso>
        Task<DeleteModelPackageGroupPolicyResponse> DeleteModelPackageGroupPolicyAsync(DeleteModelPackageGroupPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteModelQualityJobDefinition



        /// <summary>
        /// Deletes the secified model quality monitoring job definition.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteModelQualityJobDefinition service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteModelQualityJobDefinition service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteModelQualityJobDefinition">REST API Reference for DeleteModelQualityJobDefinition Operation</seealso>
        Task<DeleteModelQualityJobDefinitionResponse> DeleteModelQualityJobDefinitionAsync(DeleteModelQualityJobDefinitionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteMonitoringSchedule



        /// <summary>
        /// Deletes a monitoring schedule. Also stops the schedule had not already been stopped.
        /// This does not delete the job execution history of the monitoring schedule.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteMonitoringSchedule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteMonitoringSchedule service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteMonitoringSchedule">REST API Reference for DeleteMonitoringSchedule Operation</seealso>
        Task<DeleteMonitoringScheduleResponse> DeleteMonitoringScheduleAsync(DeleteMonitoringScheduleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteNotebookInstance



        /// <summary>
        /// Deletes an SageMaker AI notebook instance. Before you can delete a notebook instance,
        /// you must call the <c>StopNotebookInstance</c> API. 
        /// 
        ///  <important> 
        /// <para>
        /// When you delete a notebook instance, you lose all of your data. SageMaker AI removes
        /// the ML compute instance, and deletes the ML storage volume and the network interface
        /// associated with the notebook instance. 
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteNotebookInstance service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteNotebookInstance service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteNotebookInstance">REST API Reference for DeleteNotebookInstance Operation</seealso>
        Task<DeleteNotebookInstanceResponse> DeleteNotebookInstanceAsync(DeleteNotebookInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteNotebookInstanceLifecycleConfig



        /// <summary>
        /// Deletes a notebook instance lifecycle configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteNotebookInstanceLifecycleConfig service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteNotebookInstanceLifecycleConfig service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteNotebookInstanceLifecycleConfig">REST API Reference for DeleteNotebookInstanceLifecycleConfig Operation</seealso>
        Task<DeleteNotebookInstanceLifecycleConfigResponse> DeleteNotebookInstanceLifecycleConfigAsync(DeleteNotebookInstanceLifecycleConfigRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteOptimizationJob



        /// <summary>
        /// Deletes an optimization job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteOptimizationJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteOptimizationJob service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteOptimizationJob">REST API Reference for DeleteOptimizationJob Operation</seealso>
        Task<DeleteOptimizationJobResponse> DeleteOptimizationJobAsync(DeleteOptimizationJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeletePartnerApp



        /// <summary>
        /// Deletes a SageMaker Partner AI App.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePartnerApp service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeletePartnerApp service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ConflictException">
        /// There was a conflict when you attempted to modify a SageMaker entity such as an <c>Experiment</c>
        /// or <c>Artifact</c>.
        /// </exception>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeletePartnerApp">REST API Reference for DeletePartnerApp Operation</seealso>
        Task<DeletePartnerAppResponse> DeletePartnerAppAsync(DeletePartnerAppRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeletePipeline



        /// <summary>
        /// Deletes a pipeline if there are no running instances of the pipeline. To delete a
        /// pipeline, you must stop all running instances of the pipeline using the <c>StopPipelineExecution</c>
        /// API. When you delete a pipeline, all instances of the pipeline are deleted.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePipeline service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeletePipeline service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ConflictException">
        /// There was a conflict when you attempted to modify a SageMaker entity such as an <c>Experiment</c>
        /// or <c>Artifact</c>.
        /// </exception>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeletePipeline">REST API Reference for DeletePipeline Operation</seealso>
        Task<DeletePipelineResponse> DeletePipelineAsync(DeletePipelineRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteProject



        /// <summary>
        /// Delete the specified project.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteProject service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteProject service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ConflictException">
        /// There was a conflict when you attempted to modify a SageMaker entity such as an <c>Experiment</c>
        /// or <c>Artifact</c>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteProject">REST API Reference for DeleteProject Operation</seealso>
        Task<DeleteProjectResponse> DeleteProjectAsync(DeleteProjectRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteSpace



        /// <summary>
        /// Used to delete a space.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSpace service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteSpace service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceInUseException">
        /// Resource being accessed is in use.
        /// </exception>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteSpace">REST API Reference for DeleteSpace Operation</seealso>
        Task<DeleteSpaceResponse> DeleteSpaceAsync(DeleteSpaceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteStudioLifecycleConfig



        /// <summary>
        /// Deletes the Amazon SageMaker AI Studio Lifecycle Configuration. In order to delete
        /// the Lifecycle Configuration, there must be no running apps using the Lifecycle Configuration.
        /// You must also remove the Lifecycle Configuration from UserSettings in all Domains
        /// and UserProfiles.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteStudioLifecycleConfig service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteStudioLifecycleConfig service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceInUseException">
        /// Resource being accessed is in use.
        /// </exception>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteStudioLifecycleConfig">REST API Reference for DeleteStudioLifecycleConfig Operation</seealso>
        Task<DeleteStudioLifecycleConfigResponse> DeleteStudioLifecycleConfigAsync(DeleteStudioLifecycleConfigRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteTags



        /// <summary>
        /// Deletes the specified tags from an SageMaker resource.
        /// 
        ///  
        /// <para>
        /// To list a resource's tags, use the <c>ListTags</c> API. 
        /// </para>
        ///  <note> 
        /// <para>
        /// When you call this API to delete tags from a hyperparameter tuning job, the deleted
        /// tags are not removed from training jobs that the hyperparameter tuning job launched
        /// before you called this API.
        /// </para>
        ///  </note> <note> 
        /// <para>
        /// When you call this API to delete tags from a SageMaker Domain or User Profile, the
        /// deleted tags are not removed from Apps that the SageMaker Domain or User Profile launched
        /// before you called this API.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTags service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteTags service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteTags">REST API Reference for DeleteTags Operation</seealso>
        Task<DeleteTagsResponse> DeleteTagsAsync(DeleteTagsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteTrial



        /// <summary>
        /// Deletes the specified trial. All trial components that make up the trial must be deleted
        /// first. Use the <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_DescribeTrialComponent.html">DescribeTrialComponent</a>
        /// API to get the list of trial components.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTrial service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteTrial service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteTrial">REST API Reference for DeleteTrial Operation</seealso>
        Task<DeleteTrialResponse> DeleteTrialAsync(DeleteTrialRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteTrialComponent



        /// <summary>
        /// Deletes the specified trial component. A trial component must be disassociated from
        /// all trials before the trial component can be deleted. To disassociate a trial component
        /// from a trial, call the <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_DisassociateTrialComponent.html">DisassociateTrialComponent</a>
        /// API.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTrialComponent service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteTrialComponent service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteTrialComponent">REST API Reference for DeleteTrialComponent Operation</seealso>
        Task<DeleteTrialComponentResponse> DeleteTrialComponentAsync(DeleteTrialComponentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteUserProfile



        /// <summary>
        /// Deletes a user profile. When a user profile is deleted, the user loses access to their
        /// EFS volume, including data, notebooks, and other artifacts.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteUserProfile service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteUserProfile service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceInUseException">
        /// Resource being accessed is in use.
        /// </exception>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteUserProfile">REST API Reference for DeleteUserProfile Operation</seealso>
        Task<DeleteUserProfileResponse> DeleteUserProfileAsync(DeleteUserProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteWorkforce



        /// <summary>
        /// Use this operation to delete a workforce.
        /// 
        ///  
        /// <para>
        /// If you want to create a new workforce in an Amazon Web Services Region where a workforce
        /// already exists, use this operation to delete the existing workforce and then use <a
        /// href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_CreateWorkforce.html">CreateWorkforce</a>
        /// to create a new workforce.
        /// </para>
        ///  <important> 
        /// <para>
        /// If a private workforce contains one or more work teams, you must use the <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_DeleteWorkteam.html">DeleteWorkteam</a>
        /// operation to delete all work teams before you delete the workforce. If you try to
        /// delete a workforce that contains one or more work teams, you will receive a <c>ResourceInUse</c>
        /// error.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteWorkforce service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteWorkforce service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteWorkforce">REST API Reference for DeleteWorkforce Operation</seealso>
        Task<DeleteWorkforceResponse> DeleteWorkforceAsync(DeleteWorkforceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteWorkteam



        /// <summary>
        /// Deletes an existing work team. This operation can't be undone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteWorkteam service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteWorkteam service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceLimitExceededException">
        /// You have exceeded an SageMaker resource limit. For example, you might have too many
        /// training jobs created.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteWorkteam">REST API Reference for DeleteWorkteam Operation</seealso>
        Task<DeleteWorkteamResponse> DeleteWorkteamAsync(DeleteWorkteamRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeregisterDevices



        /// <summary>
        /// Deregisters the specified devices. After you deregister a device, you will need to
        /// re-register the devices.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeregisterDevices service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeregisterDevices service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeregisterDevices">REST API Reference for DeregisterDevices Operation</seealso>
        Task<DeregisterDevicesResponse> DeregisterDevicesAsync(DeregisterDevicesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeAction



        /// <summary>
        /// Describes an action.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAction service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeAction service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeAction">REST API Reference for DescribeAction Operation</seealso>
        Task<DescribeActionResponse> DescribeActionAsync(DescribeActionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeAlgorithm



        /// <summary>
        /// Returns a description of the specified algorithm that is in your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAlgorithm service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeAlgorithm service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeAlgorithm">REST API Reference for DescribeAlgorithm Operation</seealso>
        Task<DescribeAlgorithmResponse> DescribeAlgorithmAsync(DescribeAlgorithmRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeApp



        /// <summary>
        /// Describes the app.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeApp service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeApp service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeApp">REST API Reference for DescribeApp Operation</seealso>
        Task<DescribeAppResponse> DescribeAppAsync(DescribeAppRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeAppImageConfig



        /// <summary>
        /// Describes an AppImageConfig.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAppImageConfig service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeAppImageConfig service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeAppImageConfig">REST API Reference for DescribeAppImageConfig Operation</seealso>
        Task<DescribeAppImageConfigResponse> DescribeAppImageConfigAsync(DescribeAppImageConfigRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeArtifact



        /// <summary>
        /// Describes an artifact.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeArtifact service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeArtifact service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeArtifact">REST API Reference for DescribeArtifact Operation</seealso>
        Task<DescribeArtifactResponse> DescribeArtifactAsync(DescribeArtifactRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeAutoMLJob



        /// <summary>
        /// Returns information about an AutoML job created by calling <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_CreateAutoMLJob.html">CreateAutoMLJob</a>.
        /// 
        ///  <note> 
        /// <para>
        /// AutoML jobs created by calling <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_CreateAutoMLJobV2.html">CreateAutoMLJobV2</a>
        /// cannot be described by <c>DescribeAutoMLJob</c>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAutoMLJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeAutoMLJob service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeAutoMLJob">REST API Reference for DescribeAutoMLJob Operation</seealso>
        Task<DescribeAutoMLJobResponse> DescribeAutoMLJobAsync(DescribeAutoMLJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeAutoMLJobV2



        /// <summary>
        /// Returns information about an AutoML job created by calling <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_CreateAutoMLJobV2.html">CreateAutoMLJobV2</a>
        /// or <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_CreateAutoMLJob.html">CreateAutoMLJob</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAutoMLJobV2 service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeAutoMLJobV2 service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeAutoMLJobV2">REST API Reference for DescribeAutoMLJobV2 Operation</seealso>
        Task<DescribeAutoMLJobV2Response> DescribeAutoMLJobV2Async(DescribeAutoMLJobV2Request request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeCluster



        /// <summary>
        /// Retrieves information of a SageMaker HyperPod cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeCluster service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeCluster service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeCluster">REST API Reference for DescribeCluster Operation</seealso>
        Task<DescribeClusterResponse> DescribeClusterAsync(DescribeClusterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeClusterNode



        /// <summary>
        /// Retrieves information of a node (also called a <i>instance</i> interchangeably) of
        /// a SageMaker HyperPod cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeClusterNode service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeClusterNode service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeClusterNode">REST API Reference for DescribeClusterNode Operation</seealso>
        Task<DescribeClusterNodeResponse> DescribeClusterNodeAsync(DescribeClusterNodeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeClusterSchedulerConfig



        /// <summary>
        /// Description of the cluster policy. This policy is used for task prioritization and
        /// fair-share allocation. This helps prioritize critical workloads and distributes idle
        /// compute across entities.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeClusterSchedulerConfig service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeClusterSchedulerConfig service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeClusterSchedulerConfig">REST API Reference for DescribeClusterSchedulerConfig Operation</seealso>
        Task<DescribeClusterSchedulerConfigResponse> DescribeClusterSchedulerConfigAsync(DescribeClusterSchedulerConfigRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeCodeRepository



        /// <summary>
        /// Gets details about the specified Git repository.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeCodeRepository service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeCodeRepository service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeCodeRepository">REST API Reference for DescribeCodeRepository Operation</seealso>
        Task<DescribeCodeRepositoryResponse> DescribeCodeRepositoryAsync(DescribeCodeRepositoryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeCompilationJob



        /// <summary>
        /// Returns information about a model compilation job.
        /// 
        ///  
        /// <para>
        /// To create a model compilation job, use <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_CreateCompilationJob.html">CreateCompilationJob</a>.
        /// To get information about multiple model compilation jobs, use <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_ListCompilationJobs.html">ListCompilationJobs</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeCompilationJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeCompilationJob service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeCompilationJob">REST API Reference for DescribeCompilationJob Operation</seealso>
        Task<DescribeCompilationJobResponse> DescribeCompilationJobAsync(DescribeCompilationJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeComputeQuota



        /// <summary>
        /// Description of the compute allocation definition.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeComputeQuota service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeComputeQuota service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeComputeQuota">REST API Reference for DescribeComputeQuota Operation</seealso>
        Task<DescribeComputeQuotaResponse> DescribeComputeQuotaAsync(DescribeComputeQuotaRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeContext



        /// <summary>
        /// Describes a context.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeContext service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeContext service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeContext">REST API Reference for DescribeContext Operation</seealso>
        Task<DescribeContextResponse> DescribeContextAsync(DescribeContextRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeDataQualityJobDefinition



        /// <summary>
        /// Gets the details of a data quality monitoring job definition.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDataQualityJobDefinition service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeDataQualityJobDefinition service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeDataQualityJobDefinition">REST API Reference for DescribeDataQualityJobDefinition Operation</seealso>
        Task<DescribeDataQualityJobDefinitionResponse> DescribeDataQualityJobDefinitionAsync(DescribeDataQualityJobDefinitionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeDevice



        /// <summary>
        /// Describes the device.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDevice service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeDevice service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeDevice">REST API Reference for DescribeDevice Operation</seealso>
        Task<DescribeDeviceResponse> DescribeDeviceAsync(DescribeDeviceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeDeviceFleet



        /// <summary>
        /// A description of the fleet the device belongs to.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDeviceFleet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeDeviceFleet service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeDeviceFleet">REST API Reference for DescribeDeviceFleet Operation</seealso>
        Task<DescribeDeviceFleetResponse> DescribeDeviceFleetAsync(DescribeDeviceFleetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeDomain



        /// <summary>
        /// The description of the domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDomain service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeDomain service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeDomain">REST API Reference for DescribeDomain Operation</seealso>
        Task<DescribeDomainResponse> DescribeDomainAsync(DescribeDomainRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeEdgeDeploymentPlan



        /// <summary>
        /// Describes an edge deployment plan with deployment status per stage.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEdgeDeploymentPlan service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeEdgeDeploymentPlan service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeEdgeDeploymentPlan">REST API Reference for DescribeEdgeDeploymentPlan Operation</seealso>
        Task<DescribeEdgeDeploymentPlanResponse> DescribeEdgeDeploymentPlanAsync(DescribeEdgeDeploymentPlanRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeEdgePackagingJob



        /// <summary>
        /// A description of edge packaging jobs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEdgePackagingJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeEdgePackagingJob service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeEdgePackagingJob">REST API Reference for DescribeEdgePackagingJob Operation</seealso>
        Task<DescribeEdgePackagingJobResponse> DescribeEdgePackagingJobAsync(DescribeEdgePackagingJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeEndpoint



        /// <summary>
        /// Returns the description of an endpoint.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEndpoint service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeEndpoint service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeEndpoint">REST API Reference for DescribeEndpoint Operation</seealso>
        Task<DescribeEndpointResponse> DescribeEndpointAsync(DescribeEndpointRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeEndpointConfig



        /// <summary>
        /// Returns the description of an endpoint configuration created using the <c>CreateEndpointConfig</c>
        /// API.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEndpointConfig service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeEndpointConfig service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeEndpointConfig">REST API Reference for DescribeEndpointConfig Operation</seealso>
        Task<DescribeEndpointConfigResponse> DescribeEndpointConfigAsync(DescribeEndpointConfigRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeExperiment



        /// <summary>
        /// Provides a list of an experiment's properties.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeExperiment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeExperiment service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeExperiment">REST API Reference for DescribeExperiment Operation</seealso>
        Task<DescribeExperimentResponse> DescribeExperimentAsync(DescribeExperimentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeFeatureGroup



        /// <summary>
        /// Use this operation to describe a <c>FeatureGroup</c>. The response includes information
        /// on the creation time, <c>FeatureGroup</c> name, the unique identifier for each <c>FeatureGroup</c>,
        /// and more.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeFeatureGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeFeatureGroup service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeFeatureGroup">REST API Reference for DescribeFeatureGroup Operation</seealso>
        Task<DescribeFeatureGroupResponse> DescribeFeatureGroupAsync(DescribeFeatureGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeFeatureMetadata



        /// <summary>
        /// Shows the metadata for a feature within a feature group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeFeatureMetadata service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeFeatureMetadata service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeFeatureMetadata">REST API Reference for DescribeFeatureMetadata Operation</seealso>
        Task<DescribeFeatureMetadataResponse> DescribeFeatureMetadataAsync(DescribeFeatureMetadataRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeFlowDefinition



        /// <summary>
        /// Returns information about the specified flow definition.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeFlowDefinition service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeFlowDefinition service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeFlowDefinition">REST API Reference for DescribeFlowDefinition Operation</seealso>
        Task<DescribeFlowDefinitionResponse> DescribeFlowDefinitionAsync(DescribeFlowDefinitionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeHub



        /// <summary>
        /// Describes a hub.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeHub service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeHub service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeHub">REST API Reference for DescribeHub Operation</seealso>
        Task<DescribeHubResponse> DescribeHubAsync(DescribeHubRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeHubContent



        /// <summary>
        /// Describe the content of a hub.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeHubContent service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeHubContent service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeHubContent">REST API Reference for DescribeHubContent Operation</seealso>
        Task<DescribeHubContentResponse> DescribeHubContentAsync(DescribeHubContentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeHumanTaskUi



        /// <summary>
        /// Returns information about the requested human task user interface (worker task template).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeHumanTaskUi service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeHumanTaskUi service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeHumanTaskUi">REST API Reference for DescribeHumanTaskUi Operation</seealso>
        Task<DescribeHumanTaskUiResponse> DescribeHumanTaskUiAsync(DescribeHumanTaskUiRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeHyperParameterTuningJob



        /// <summary>
        /// Returns a description of a hyperparameter tuning job, depending on the fields selected.
        /// These fields can include the name, Amazon Resource Name (ARN), job status of your
        /// tuning job and more.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeHyperParameterTuningJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeHyperParameterTuningJob service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeHyperParameterTuningJob">REST API Reference for DescribeHyperParameterTuningJob Operation</seealso>
        Task<DescribeHyperParameterTuningJobResponse> DescribeHyperParameterTuningJobAsync(DescribeHyperParameterTuningJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeImage



        /// <summary>
        /// Describes a SageMaker AI image.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeImage service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeImage service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeImage">REST API Reference for DescribeImage Operation</seealso>
        Task<DescribeImageResponse> DescribeImageAsync(DescribeImageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeImageVersion



        /// <summary>
        /// Describes a version of a SageMaker AI image.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeImageVersion service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeImageVersion service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeImageVersion">REST API Reference for DescribeImageVersion Operation</seealso>
        Task<DescribeImageVersionResponse> DescribeImageVersionAsync(DescribeImageVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeInferenceComponent



        /// <summary>
        /// Returns information about an inference component.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeInferenceComponent service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeInferenceComponent service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeInferenceComponent">REST API Reference for DescribeInferenceComponent Operation</seealso>
        Task<DescribeInferenceComponentResponse> DescribeInferenceComponentAsync(DescribeInferenceComponentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeInferenceExperiment



        /// <summary>
        /// Returns details about an inference experiment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeInferenceExperiment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeInferenceExperiment service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeInferenceExperiment">REST API Reference for DescribeInferenceExperiment Operation</seealso>
        Task<DescribeInferenceExperimentResponse> DescribeInferenceExperimentAsync(DescribeInferenceExperimentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeInferenceRecommendationsJob



        /// <summary>
        /// Provides the results of the Inference Recommender job. One or more recommendation
        /// jobs are returned.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeInferenceRecommendationsJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeInferenceRecommendationsJob service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeInferenceRecommendationsJob">REST API Reference for DescribeInferenceRecommendationsJob Operation</seealso>
        Task<DescribeInferenceRecommendationsJobResponse> DescribeInferenceRecommendationsJobAsync(DescribeInferenceRecommendationsJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeLabelingJob



        /// <summary>
        /// Gets information about a labeling job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeLabelingJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeLabelingJob service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeLabelingJob">REST API Reference for DescribeLabelingJob Operation</seealso>
        Task<DescribeLabelingJobResponse> DescribeLabelingJobAsync(DescribeLabelingJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeLineageGroup



        /// <summary>
        /// Provides a list of properties for the requested lineage group. For more information,
        /// see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/xaccount-lineage-tracking.html">
        /// Cross-Account Lineage Tracking </a> in the <i>Amazon SageMaker Developer Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeLineageGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeLineageGroup service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeLineageGroup">REST API Reference for DescribeLineageGroup Operation</seealso>
        Task<DescribeLineageGroupResponse> DescribeLineageGroupAsync(DescribeLineageGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeMlflowTrackingServer



        /// <summary>
        /// Returns information about an MLflow Tracking Server.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeMlflowTrackingServer service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeMlflowTrackingServer service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeMlflowTrackingServer">REST API Reference for DescribeMlflowTrackingServer Operation</seealso>
        Task<DescribeMlflowTrackingServerResponse> DescribeMlflowTrackingServerAsync(DescribeMlflowTrackingServerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeModel



        /// <summary>
        /// Describes a model that you created using the <c>CreateModel</c> API.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeModel service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeModel service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeModel">REST API Reference for DescribeModel Operation</seealso>
        Task<DescribeModelResponse> DescribeModelAsync(DescribeModelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeModelBiasJobDefinition



        /// <summary>
        /// Returns a description of a model bias job definition.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeModelBiasJobDefinition service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeModelBiasJobDefinition service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeModelBiasJobDefinition">REST API Reference for DescribeModelBiasJobDefinition Operation</seealso>
        Task<DescribeModelBiasJobDefinitionResponse> DescribeModelBiasJobDefinitionAsync(DescribeModelBiasJobDefinitionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeModelCard



        /// <summary>
        /// Describes the content, creation time, and security configuration of an Amazon SageMaker
        /// Model Card.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeModelCard service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeModelCard service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeModelCard">REST API Reference for DescribeModelCard Operation</seealso>
        Task<DescribeModelCardResponse> DescribeModelCardAsync(DescribeModelCardRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeModelCardExportJob



        /// <summary>
        /// Describes an Amazon SageMaker Model Card export job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeModelCardExportJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeModelCardExportJob service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeModelCardExportJob">REST API Reference for DescribeModelCardExportJob Operation</seealso>
        Task<DescribeModelCardExportJobResponse> DescribeModelCardExportJobAsync(DescribeModelCardExportJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeModelExplainabilityJobDefinition



        /// <summary>
        /// Returns a description of a model explainability job definition.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeModelExplainabilityJobDefinition service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeModelExplainabilityJobDefinition service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeModelExplainabilityJobDefinition">REST API Reference for DescribeModelExplainabilityJobDefinition Operation</seealso>
        Task<DescribeModelExplainabilityJobDefinitionResponse> DescribeModelExplainabilityJobDefinitionAsync(DescribeModelExplainabilityJobDefinitionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeModelPackage



        /// <summary>
        /// Returns a description of the specified model package, which is used to create SageMaker
        /// models or list them on Amazon Web Services Marketplace.
        /// 
        ///  <important> 
        /// <para>
        /// If you provided a KMS Key ID when you created your model package, you will see the
        /// <a href="https://docs.aws.amazon.com/kms/latest/APIReference/API_Decrypt.html">KMS
        /// Decrypt</a> API call in your CloudTrail logs when you use this API.
        /// </para>
        ///  </important> 
        /// <para>
        /// To create models in SageMaker, buyers can subscribe to model packages listed on Amazon
        /// Web Services Marketplace.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeModelPackage service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeModelPackage service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeModelPackage">REST API Reference for DescribeModelPackage Operation</seealso>
        Task<DescribeModelPackageResponse> DescribeModelPackageAsync(DescribeModelPackageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeModelPackageGroup



        /// <summary>
        /// Gets a description for the specified model group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeModelPackageGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeModelPackageGroup service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeModelPackageGroup">REST API Reference for DescribeModelPackageGroup Operation</seealso>
        Task<DescribeModelPackageGroupResponse> DescribeModelPackageGroupAsync(DescribeModelPackageGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeModelQualityJobDefinition



        /// <summary>
        /// Returns a description of a model quality job definition.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeModelQualityJobDefinition service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeModelQualityJobDefinition service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeModelQualityJobDefinition">REST API Reference for DescribeModelQualityJobDefinition Operation</seealso>
        Task<DescribeModelQualityJobDefinitionResponse> DescribeModelQualityJobDefinitionAsync(DescribeModelQualityJobDefinitionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeMonitoringSchedule



        /// <summary>
        /// Describes the schedule for a monitoring job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeMonitoringSchedule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeMonitoringSchedule service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeMonitoringSchedule">REST API Reference for DescribeMonitoringSchedule Operation</seealso>
        Task<DescribeMonitoringScheduleResponse> DescribeMonitoringScheduleAsync(DescribeMonitoringScheduleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeNotebookInstance



        /// <summary>
        /// Returns information about a notebook instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeNotebookInstance service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeNotebookInstance service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeNotebookInstance">REST API Reference for DescribeNotebookInstance Operation</seealso>
        Task<DescribeNotebookInstanceResponse> DescribeNotebookInstanceAsync(DescribeNotebookInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeNotebookInstanceLifecycleConfig



        /// <summary>
        /// Returns a description of a notebook instance lifecycle configuration.
        /// 
        ///  
        /// <para>
        /// For information about notebook instance lifestyle configurations, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/notebook-lifecycle-config.html">Step
        /// 2.1: (Optional) Customize a Notebook Instance</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeNotebookInstanceLifecycleConfig service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeNotebookInstanceLifecycleConfig service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeNotebookInstanceLifecycleConfig">REST API Reference for DescribeNotebookInstanceLifecycleConfig Operation</seealso>
        Task<DescribeNotebookInstanceLifecycleConfigResponse> DescribeNotebookInstanceLifecycleConfigAsync(DescribeNotebookInstanceLifecycleConfigRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeOptimizationJob



        /// <summary>
        /// Provides the properties of the specified optimization job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeOptimizationJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeOptimizationJob service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeOptimizationJob">REST API Reference for DescribeOptimizationJob Operation</seealso>
        Task<DescribeOptimizationJobResponse> DescribeOptimizationJobAsync(DescribeOptimizationJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribePartnerApp



        /// <summary>
        /// Gets information about a SageMaker Partner AI App.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribePartnerApp service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribePartnerApp service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribePartnerApp">REST API Reference for DescribePartnerApp Operation</seealso>
        Task<DescribePartnerAppResponse> DescribePartnerAppAsync(DescribePartnerAppRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribePipeline



        /// <summary>
        /// Describes the details of a pipeline.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribePipeline service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribePipeline service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribePipeline">REST API Reference for DescribePipeline Operation</seealso>
        Task<DescribePipelineResponse> DescribePipelineAsync(DescribePipelineRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribePipelineDefinitionForExecution



        /// <summary>
        /// Describes the details of an execution's pipeline definition.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribePipelineDefinitionForExecution service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribePipelineDefinitionForExecution service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribePipelineDefinitionForExecution">REST API Reference for DescribePipelineDefinitionForExecution Operation</seealso>
        Task<DescribePipelineDefinitionForExecutionResponse> DescribePipelineDefinitionForExecutionAsync(DescribePipelineDefinitionForExecutionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribePipelineExecution



        /// <summary>
        /// Describes the details of a pipeline execution.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribePipelineExecution service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribePipelineExecution service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribePipelineExecution">REST API Reference for DescribePipelineExecution Operation</seealso>
        Task<DescribePipelineExecutionResponse> DescribePipelineExecutionAsync(DescribePipelineExecutionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeProcessingJob



        /// <summary>
        /// Returns a description of a processing job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeProcessingJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeProcessingJob service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeProcessingJob">REST API Reference for DescribeProcessingJob Operation</seealso>
        Task<DescribeProcessingJobResponse> DescribeProcessingJobAsync(DescribeProcessingJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeProject



        /// <summary>
        /// Describes the details of a project.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeProject service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeProject service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeProject">REST API Reference for DescribeProject Operation</seealso>
        Task<DescribeProjectResponse> DescribeProjectAsync(DescribeProjectRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeSpace



        /// <summary>
        /// Describes the space.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSpace service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeSpace service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeSpace">REST API Reference for DescribeSpace Operation</seealso>
        Task<DescribeSpaceResponse> DescribeSpaceAsync(DescribeSpaceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeStudioLifecycleConfig



        /// <summary>
        /// Describes the Amazon SageMaker AI Studio Lifecycle Configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeStudioLifecycleConfig service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeStudioLifecycleConfig service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeStudioLifecycleConfig">REST API Reference for DescribeStudioLifecycleConfig Operation</seealso>
        Task<DescribeStudioLifecycleConfigResponse> DescribeStudioLifecycleConfigAsync(DescribeStudioLifecycleConfigRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeSubscribedWorkteam



        /// <summary>
        /// Gets information about a work team provided by a vendor. It returns details about
        /// the subscription with a vendor in the Amazon Web Services Marketplace.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSubscribedWorkteam service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeSubscribedWorkteam service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeSubscribedWorkteam">REST API Reference for DescribeSubscribedWorkteam Operation</seealso>
        Task<DescribeSubscribedWorkteamResponse> DescribeSubscribedWorkteamAsync(DescribeSubscribedWorkteamRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeTrainingJob



        /// <summary>
        /// Returns information about a training job. 
        /// 
        ///  
        /// <para>
        /// Some of the attributes below only appear if the training job successfully starts.
        /// If the training job fails, <c>TrainingJobStatus</c> is <c>Failed</c> and, depending
        /// on the <c>FailureReason</c>, attributes like <c>TrainingStartTime</c>, <c>TrainingTimeInSeconds</c>,
        /// <c>TrainingEndTime</c>, and <c>BillableTimeInSeconds</c> may not be present in the
        /// response.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeTrainingJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeTrainingJob service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeTrainingJob">REST API Reference for DescribeTrainingJob Operation</seealso>
        Task<DescribeTrainingJobResponse> DescribeTrainingJobAsync(DescribeTrainingJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeTrainingPlan



        /// <summary>
        /// Retrieves detailed information about a specific training plan.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeTrainingPlan service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeTrainingPlan service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeTrainingPlan">REST API Reference for DescribeTrainingPlan Operation</seealso>
        Task<DescribeTrainingPlanResponse> DescribeTrainingPlanAsync(DescribeTrainingPlanRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeTransformJob



        /// <summary>
        /// Returns information about a transform job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeTransformJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeTransformJob service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeTransformJob">REST API Reference for DescribeTransformJob Operation</seealso>
        Task<DescribeTransformJobResponse> DescribeTransformJobAsync(DescribeTransformJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeTrial



        /// <summary>
        /// Provides a list of a trial's properties.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeTrial service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeTrial service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeTrial">REST API Reference for DescribeTrial Operation</seealso>
        Task<DescribeTrialResponse> DescribeTrialAsync(DescribeTrialRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeTrialComponent



        /// <summary>
        /// Provides a list of a trials component's properties.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeTrialComponent service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeTrialComponent service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeTrialComponent">REST API Reference for DescribeTrialComponent Operation</seealso>
        Task<DescribeTrialComponentResponse> DescribeTrialComponentAsync(DescribeTrialComponentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeUserProfile



        /// <summary>
        /// Describes a user profile. For more information, see <c>CreateUserProfile</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeUserProfile service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeUserProfile service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceLimitExceededException">
        /// You have exceeded an SageMaker resource limit. For example, you might have too many
        /// training jobs created.
        /// </exception>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeUserProfile">REST API Reference for DescribeUserProfile Operation</seealso>
        Task<DescribeUserProfileResponse> DescribeUserProfileAsync(DescribeUserProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeWorkforce



        /// <summary>
        /// Lists private workforce information, including workforce name, Amazon Resource Name
        /// (ARN), and, if applicable, allowed IP address ranges (<a href="https://docs.aws.amazon.com/vpc/latest/userguide/VPC_Subnets.html">CIDRs</a>).
        /// Allowable IP address ranges are the IP addresses that workers can use to access tasks.
        /// 
        /// 
        ///  <important> 
        /// <para>
        /// This operation applies only to private workforces.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeWorkforce service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeWorkforce service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeWorkforce">REST API Reference for DescribeWorkforce Operation</seealso>
        Task<DescribeWorkforceResponse> DescribeWorkforceAsync(DescribeWorkforceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeWorkteam



        /// <summary>
        /// Gets information about a specific work team. You can see information such as the creation
        /// date, the last updated date, membership information, and the work team's Amazon Resource
        /// Name (ARN).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeWorkteam service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeWorkteam service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeWorkteam">REST API Reference for DescribeWorkteam Operation</seealso>
        Task<DescribeWorkteamResponse> DescribeWorkteamAsync(DescribeWorkteamRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DisableSagemakerServicecatalogPortfolio



        /// <summary>
        /// Disables using Service Catalog in SageMaker. Service Catalog is used to create SageMaker
        /// projects.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisableSagemakerServicecatalogPortfolio service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisableSagemakerServicecatalogPortfolio service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DisableSagemakerServicecatalogPortfolio">REST API Reference for DisableSagemakerServicecatalogPortfolio Operation</seealso>
        Task<DisableSagemakerServicecatalogPortfolioResponse> DisableSagemakerServicecatalogPortfolioAsync(DisableSagemakerServicecatalogPortfolioRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DisassociateTrialComponent



        /// <summary>
        /// Disassociates a trial component from a trial. This doesn't effect other trials the
        /// component is associated with. Before you can delete a component, you must disassociate
        /// the component from all trials it is associated with. To associate a trial component
        /// with a trial, call the <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_AssociateTrialComponent.html">AssociateTrialComponent</a>
        /// API.
        /// 
        ///  
        /// <para>
        /// To get a list of the trials a component is associated with, use the <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_Search.html">Search</a>
        /// API. Specify <c>ExperimentTrialComponent</c> for the <c>Resource</c> parameter. The
        /// list appears in the response under <c>Results.TrialComponent.Parents</c>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateTrialComponent service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisassociateTrialComponent service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DisassociateTrialComponent">REST API Reference for DisassociateTrialComponent Operation</seealso>
        Task<DisassociateTrialComponentResponse> DisassociateTrialComponentAsync(DisassociateTrialComponentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  EnableSagemakerServicecatalogPortfolio



        /// <summary>
        /// Enables using Service Catalog in SageMaker. Service Catalog is used to create SageMaker
        /// projects.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EnableSagemakerServicecatalogPortfolio service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the EnableSagemakerServicecatalogPortfolio service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/EnableSagemakerServicecatalogPortfolio">REST API Reference for EnableSagemakerServicecatalogPortfolio Operation</seealso>
        Task<EnableSagemakerServicecatalogPortfolioResponse> EnableSagemakerServicecatalogPortfolioAsync(EnableSagemakerServicecatalogPortfolioRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetDeviceFleetReport



        /// <summary>
        /// Describes a fleet.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDeviceFleetReport service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetDeviceFleetReport service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/GetDeviceFleetReport">REST API Reference for GetDeviceFleetReport Operation</seealso>
        Task<GetDeviceFleetReportResponse> GetDeviceFleetReportAsync(GetDeviceFleetReportRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetLineageGroupPolicy



        /// <summary>
        /// The resource policy for the lineage group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetLineageGroupPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetLineageGroupPolicy service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/GetLineageGroupPolicy">REST API Reference for GetLineageGroupPolicy Operation</seealso>
        Task<GetLineageGroupPolicyResponse> GetLineageGroupPolicyAsync(GetLineageGroupPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetModelPackageGroupPolicy



        /// <summary>
        /// Gets a resource policy that manages access for a model group. For information about
        /// resource policies, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access_policies_identity-vs-resource.html">Identity-based
        /// policies and resource-based policies</a> in the <i>Amazon Web Services Identity and
        /// Access Management User Guide.</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetModelPackageGroupPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetModelPackageGroupPolicy service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/GetModelPackageGroupPolicy">REST API Reference for GetModelPackageGroupPolicy Operation</seealso>
        Task<GetModelPackageGroupPolicyResponse> GetModelPackageGroupPolicyAsync(GetModelPackageGroupPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetSagemakerServicecatalogPortfolioStatus



        /// <summary>
        /// Gets the status of Service Catalog in SageMaker. Service Catalog is used to create
        /// SageMaker projects.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSagemakerServicecatalogPortfolioStatus service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetSagemakerServicecatalogPortfolioStatus service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/GetSagemakerServicecatalogPortfolioStatus">REST API Reference for GetSagemakerServicecatalogPortfolioStatus Operation</seealso>
        Task<GetSagemakerServicecatalogPortfolioStatusResponse> GetSagemakerServicecatalogPortfolioStatusAsync(GetSagemakerServicecatalogPortfolioStatusRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetScalingConfigurationRecommendation



        /// <summary>
        /// Starts an Amazon SageMaker Inference Recommender autoscaling recommendation job. Returns
        /// recommendations for autoscaling policies that you can apply to your SageMaker endpoint.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetScalingConfigurationRecommendation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetScalingConfigurationRecommendation service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/GetScalingConfigurationRecommendation">REST API Reference for GetScalingConfigurationRecommendation Operation</seealso>
        Task<GetScalingConfigurationRecommendationResponse> GetScalingConfigurationRecommendationAsync(GetScalingConfigurationRecommendationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetSearchSuggestions



        /// <summary>
        /// An auto-complete API for the search functionality in the SageMaker console. It returns
        /// suggestions of possible matches for the property name to use in <c>Search</c> queries.
        /// Provides suggestions for <c>HyperParameters</c>, <c>Tags</c>, and <c>Metrics</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSearchSuggestions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetSearchSuggestions service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/GetSearchSuggestions">REST API Reference for GetSearchSuggestions Operation</seealso>
        Task<GetSearchSuggestionsResponse> GetSearchSuggestionsAsync(GetSearchSuggestionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ImportHubContent



        /// <summary>
        /// Import hub content.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ImportHubContent service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ImportHubContent service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceInUseException">
        /// Resource being accessed is in use.
        /// </exception>
        /// <exception cref="Amazon.SageMaker.Model.ResourceLimitExceededException">
        /// You have exceeded an SageMaker resource limit. For example, you might have too many
        /// training jobs created.
        /// </exception>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ImportHubContent">REST API Reference for ImportHubContent Operation</seealso>
        Task<ImportHubContentResponse> ImportHubContentAsync(ImportHubContentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListActions



        /// <summary>
        /// Lists the actions in your account and their properties.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListActions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListActions service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListActions">REST API Reference for ListActions Operation</seealso>
        Task<ListActionsResponse> ListActionsAsync(ListActionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListAlgorithms



        /// <summary>
        /// Lists the machine learning algorithms that have been created.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAlgorithms service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAlgorithms service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListAlgorithms">REST API Reference for ListAlgorithms Operation</seealso>
        Task<ListAlgorithmsResponse> ListAlgorithmsAsync(ListAlgorithmsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListAliases



        /// <summary>
        /// Lists the aliases of a specified image or image version.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAliases service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAliases service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListAliases">REST API Reference for ListAliases Operation</seealso>
        Task<ListAliasesResponse> ListAliasesAsync(ListAliasesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListAppImageConfigs



        /// <summary>
        /// Lists the AppImageConfigs in your account and their properties. The list can be filtered
        /// by creation time or modified time, and whether the AppImageConfig name contains a
        /// specified string.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAppImageConfigs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAppImageConfigs service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListAppImageConfigs">REST API Reference for ListAppImageConfigs Operation</seealso>
        Task<ListAppImageConfigsResponse> ListAppImageConfigsAsync(ListAppImageConfigsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListApps



        /// <summary>
        /// Lists apps.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListApps service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListApps service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListApps">REST API Reference for ListApps Operation</seealso>
        Task<ListAppsResponse> ListAppsAsync(ListAppsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListArtifacts



        /// <summary>
        /// Lists the artifacts in your account and their properties.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListArtifacts service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListArtifacts service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListArtifacts">REST API Reference for ListArtifacts Operation</seealso>
        Task<ListArtifactsResponse> ListArtifactsAsync(ListArtifactsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListAssociations



        /// <summary>
        /// Lists the associations in your account and their properties.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAssociations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAssociations service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListAssociations">REST API Reference for ListAssociations Operation</seealso>
        Task<ListAssociationsResponse> ListAssociationsAsync(ListAssociationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListAutoMLJobs



        /// <summary>
        /// Request a list of jobs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAutoMLJobs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAutoMLJobs service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListAutoMLJobs">REST API Reference for ListAutoMLJobs Operation</seealso>
        Task<ListAutoMLJobsResponse> ListAutoMLJobsAsync(ListAutoMLJobsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListCandidatesForAutoMLJob



        /// <summary>
        /// List the candidates created for the job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCandidatesForAutoMLJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListCandidatesForAutoMLJob service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListCandidatesForAutoMLJob">REST API Reference for ListCandidatesForAutoMLJob Operation</seealso>
        Task<ListCandidatesForAutoMLJobResponse> ListCandidatesForAutoMLJobAsync(ListCandidatesForAutoMLJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListClusterNodes



        /// <summary>
        /// Retrieves the list of instances (also called <i>nodes</i> interchangeably) in a SageMaker
        /// HyperPod cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListClusterNodes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListClusterNodes service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListClusterNodes">REST API Reference for ListClusterNodes Operation</seealso>
        Task<ListClusterNodesResponse> ListClusterNodesAsync(ListClusterNodesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListClusters



        /// <summary>
        /// Retrieves the list of SageMaker HyperPod clusters.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListClusters service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListClusters service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListClusters">REST API Reference for ListClusters Operation</seealso>
        Task<ListClustersResponse> ListClustersAsync(ListClustersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListClusterSchedulerConfigs



        /// <summary>
        /// List the cluster policy configurations.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListClusterSchedulerConfigs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListClusterSchedulerConfigs service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListClusterSchedulerConfigs">REST API Reference for ListClusterSchedulerConfigs Operation</seealso>
        Task<ListClusterSchedulerConfigsResponse> ListClusterSchedulerConfigsAsync(ListClusterSchedulerConfigsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListCodeRepositories



        /// <summary>
        /// Gets a list of the Git repositories in your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCodeRepositories service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListCodeRepositories service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListCodeRepositories">REST API Reference for ListCodeRepositories Operation</seealso>
        Task<ListCodeRepositoriesResponse> ListCodeRepositoriesAsync(ListCodeRepositoriesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListCompilationJobs



        /// <summary>
        /// Lists model compilation jobs that satisfy various filters.
        /// 
        ///  
        /// <para>
        /// To create a model compilation job, use <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_CreateCompilationJob.html">CreateCompilationJob</a>.
        /// To get information about a particular model compilation job you have created, use
        /// <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_DescribeCompilationJob.html">DescribeCompilationJob</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCompilationJobs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListCompilationJobs service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListCompilationJobs">REST API Reference for ListCompilationJobs Operation</seealso>
        Task<ListCompilationJobsResponse> ListCompilationJobsAsync(ListCompilationJobsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListComputeQuotas



        /// <summary>
        /// List the resource allocation definitions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListComputeQuotas service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListComputeQuotas service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListComputeQuotas">REST API Reference for ListComputeQuotas Operation</seealso>
        Task<ListComputeQuotasResponse> ListComputeQuotasAsync(ListComputeQuotasRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListContexts



        /// <summary>
        /// Lists the contexts in your account and their properties.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListContexts service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListContexts service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListContexts">REST API Reference for ListContexts Operation</seealso>
        Task<ListContextsResponse> ListContextsAsync(ListContextsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListDataQualityJobDefinitions



        /// <summary>
        /// Lists the data quality job definitions in your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDataQualityJobDefinitions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListDataQualityJobDefinitions service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListDataQualityJobDefinitions">REST API Reference for ListDataQualityJobDefinitions Operation</seealso>
        Task<ListDataQualityJobDefinitionsResponse> ListDataQualityJobDefinitionsAsync(ListDataQualityJobDefinitionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListDeviceFleets



        /// <summary>
        /// Returns a list of devices in the fleet.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDeviceFleets service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListDeviceFleets service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListDeviceFleets">REST API Reference for ListDeviceFleets Operation</seealso>
        Task<ListDeviceFleetsResponse> ListDeviceFleetsAsync(ListDeviceFleetsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListDevices



        /// <summary>
        /// A list of devices.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDevices service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListDevices service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListDevices">REST API Reference for ListDevices Operation</seealso>
        Task<ListDevicesResponse> ListDevicesAsync(ListDevicesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListDomains



        /// <summary>
        /// Lists the domains.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDomains service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListDomains service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListDomains">REST API Reference for ListDomains Operation</seealso>
        Task<ListDomainsResponse> ListDomainsAsync(ListDomainsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListEdgeDeploymentPlans



        /// <summary>
        /// Lists all edge deployment plans.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListEdgeDeploymentPlans service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListEdgeDeploymentPlans service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListEdgeDeploymentPlans">REST API Reference for ListEdgeDeploymentPlans Operation</seealso>
        Task<ListEdgeDeploymentPlansResponse> ListEdgeDeploymentPlansAsync(ListEdgeDeploymentPlansRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListEdgePackagingJobs



        /// <summary>
        /// Returns a list of edge packaging jobs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListEdgePackagingJobs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListEdgePackagingJobs service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListEdgePackagingJobs">REST API Reference for ListEdgePackagingJobs Operation</seealso>
        Task<ListEdgePackagingJobsResponse> ListEdgePackagingJobsAsync(ListEdgePackagingJobsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListEndpointConfigs



        /// <summary>
        /// Lists endpoint configurations.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListEndpointConfigs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListEndpointConfigs service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListEndpointConfigs">REST API Reference for ListEndpointConfigs Operation</seealso>
        Task<ListEndpointConfigsResponse> ListEndpointConfigsAsync(ListEndpointConfigsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListEndpoints



        /// <summary>
        /// Lists endpoints.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListEndpoints service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListEndpoints service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListEndpoints">REST API Reference for ListEndpoints Operation</seealso>
        Task<ListEndpointsResponse> ListEndpointsAsync(ListEndpointsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListExperiments



        /// <summary>
        /// Lists all the experiments in your account. The list can be filtered to show only experiments
        /// that were created in a specific time range. The list can be sorted by experiment name
        /// or creation time.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListExperiments service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListExperiments service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListExperiments">REST API Reference for ListExperiments Operation</seealso>
        Task<ListExperimentsResponse> ListExperimentsAsync(ListExperimentsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListFeatureGroups



        /// <summary>
        /// List <c>FeatureGroup</c>s based on given filter and order.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFeatureGroups service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListFeatureGroups service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListFeatureGroups">REST API Reference for ListFeatureGroups Operation</seealso>
        Task<ListFeatureGroupsResponse> ListFeatureGroupsAsync(ListFeatureGroupsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListFlowDefinitions



        /// <summary>
        /// Returns information about the flow definitions in your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFlowDefinitions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListFlowDefinitions service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListFlowDefinitions">REST API Reference for ListFlowDefinitions Operation</seealso>
        Task<ListFlowDefinitionsResponse> ListFlowDefinitionsAsync(ListFlowDefinitionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListHubContents



        /// <summary>
        /// List the contents of a hub.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListHubContents service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListHubContents service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListHubContents">REST API Reference for ListHubContents Operation</seealso>
        Task<ListHubContentsResponse> ListHubContentsAsync(ListHubContentsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListHubContentVersions



        /// <summary>
        /// List hub content versions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListHubContentVersions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListHubContentVersions service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListHubContentVersions">REST API Reference for ListHubContentVersions Operation</seealso>
        Task<ListHubContentVersionsResponse> ListHubContentVersionsAsync(ListHubContentVersionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListHubs



        /// <summary>
        /// List all existing hubs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListHubs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListHubs service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListHubs">REST API Reference for ListHubs Operation</seealso>
        Task<ListHubsResponse> ListHubsAsync(ListHubsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListHumanTaskUis



        /// <summary>
        /// Returns information about the human task user interfaces in your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListHumanTaskUis service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListHumanTaskUis service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListHumanTaskUis">REST API Reference for ListHumanTaskUis Operation</seealso>
        Task<ListHumanTaskUisResponse> ListHumanTaskUisAsync(ListHumanTaskUisRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListHyperParameterTuningJobs



        /// <summary>
        /// Gets a list of <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_HyperParameterTuningJobSummary.html">HyperParameterTuningJobSummary</a>
        /// objects that describe the hyperparameter tuning jobs launched in your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListHyperParameterTuningJobs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListHyperParameterTuningJobs service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListHyperParameterTuningJobs">REST API Reference for ListHyperParameterTuningJobs Operation</seealso>
        Task<ListHyperParameterTuningJobsResponse> ListHyperParameterTuningJobsAsync(ListHyperParameterTuningJobsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListImages



        /// <summary>
        /// Lists the images in your account and their properties. The list can be filtered by
        /// creation time or modified time, and whether the image name contains a specified string.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListImages service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListImages service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListImages">REST API Reference for ListImages Operation</seealso>
        Task<ListImagesResponse> ListImagesAsync(ListImagesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListImageVersions



        /// <summary>
        /// Lists the versions of a specified image and their properties. The list can be filtered
        /// by creation time or modified time.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListImageVersions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListImageVersions service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListImageVersions">REST API Reference for ListImageVersions Operation</seealso>
        Task<ListImageVersionsResponse> ListImageVersionsAsync(ListImageVersionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListInferenceComponents



        /// <summary>
        /// Lists the inference components in your account and their properties.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListInferenceComponents service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListInferenceComponents service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListInferenceComponents">REST API Reference for ListInferenceComponents Operation</seealso>
        Task<ListInferenceComponentsResponse> ListInferenceComponentsAsync(ListInferenceComponentsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListInferenceExperiments



        /// <summary>
        /// Returns the list of all inference experiments.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListInferenceExperiments service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListInferenceExperiments service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListInferenceExperiments">REST API Reference for ListInferenceExperiments Operation</seealso>
        Task<ListInferenceExperimentsResponse> ListInferenceExperimentsAsync(ListInferenceExperimentsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListInferenceRecommendationsJobs



        /// <summary>
        /// Lists recommendation jobs that satisfy various filters.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListInferenceRecommendationsJobs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListInferenceRecommendationsJobs service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListInferenceRecommendationsJobs">REST API Reference for ListInferenceRecommendationsJobs Operation</seealso>
        Task<ListInferenceRecommendationsJobsResponse> ListInferenceRecommendationsJobsAsync(ListInferenceRecommendationsJobsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListInferenceRecommendationsJobSteps



        /// <summary>
        /// Returns a list of the subtasks for an Inference Recommender job.
        /// 
        ///  
        /// <para>
        /// The supported subtasks are benchmarks, which evaluate the performance of your model
        /// on different instance types.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListInferenceRecommendationsJobSteps service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListInferenceRecommendationsJobSteps service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListInferenceRecommendationsJobSteps">REST API Reference for ListInferenceRecommendationsJobSteps Operation</seealso>
        Task<ListInferenceRecommendationsJobStepsResponse> ListInferenceRecommendationsJobStepsAsync(ListInferenceRecommendationsJobStepsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListLabelingJobs



        /// <summary>
        /// Gets a list of labeling jobs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListLabelingJobs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListLabelingJobs service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListLabelingJobs">REST API Reference for ListLabelingJobs Operation</seealso>
        Task<ListLabelingJobsResponse> ListLabelingJobsAsync(ListLabelingJobsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListLabelingJobsForWorkteam



        /// <summary>
        /// Gets a list of labeling jobs assigned to a specified work team.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListLabelingJobsForWorkteam service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListLabelingJobsForWorkteam service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListLabelingJobsForWorkteam">REST API Reference for ListLabelingJobsForWorkteam Operation</seealso>
        Task<ListLabelingJobsForWorkteamResponse> ListLabelingJobsForWorkteamAsync(ListLabelingJobsForWorkteamRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListLineageGroups



        /// <summary>
        /// A list of lineage groups shared with your Amazon Web Services account. For more information,
        /// see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/xaccount-lineage-tracking.html">
        /// Cross-Account Lineage Tracking </a> in the <i>Amazon SageMaker Developer Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListLineageGroups service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListLineageGroups service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListLineageGroups">REST API Reference for ListLineageGroups Operation</seealso>
        Task<ListLineageGroupsResponse> ListLineageGroupsAsync(ListLineageGroupsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListMlflowTrackingServers



        /// <summary>
        /// Lists all MLflow Tracking Servers.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMlflowTrackingServers service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListMlflowTrackingServers service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListMlflowTrackingServers">REST API Reference for ListMlflowTrackingServers Operation</seealso>
        Task<ListMlflowTrackingServersResponse> ListMlflowTrackingServersAsync(ListMlflowTrackingServersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListModelBiasJobDefinitions



        /// <summary>
        /// Lists model bias jobs definitions that satisfy various filters.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListModelBiasJobDefinitions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListModelBiasJobDefinitions service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListModelBiasJobDefinitions">REST API Reference for ListModelBiasJobDefinitions Operation</seealso>
        Task<ListModelBiasJobDefinitionsResponse> ListModelBiasJobDefinitionsAsync(ListModelBiasJobDefinitionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListModelCardExportJobs



        /// <summary>
        /// List the export jobs for the Amazon SageMaker Model Card.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListModelCardExportJobs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListModelCardExportJobs service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListModelCardExportJobs">REST API Reference for ListModelCardExportJobs Operation</seealso>
        Task<ListModelCardExportJobsResponse> ListModelCardExportJobsAsync(ListModelCardExportJobsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListModelCards



        /// <summary>
        /// List existing model cards.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListModelCards service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListModelCards service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListModelCards">REST API Reference for ListModelCards Operation</seealso>
        Task<ListModelCardsResponse> ListModelCardsAsync(ListModelCardsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListModelCardVersions



        /// <summary>
        /// List existing versions of an Amazon SageMaker Model Card.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListModelCardVersions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListModelCardVersions service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListModelCardVersions">REST API Reference for ListModelCardVersions Operation</seealso>
        Task<ListModelCardVersionsResponse> ListModelCardVersionsAsync(ListModelCardVersionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListModelExplainabilityJobDefinitions



        /// <summary>
        /// Lists model explainability job definitions that satisfy various filters.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListModelExplainabilityJobDefinitions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListModelExplainabilityJobDefinitions service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListModelExplainabilityJobDefinitions">REST API Reference for ListModelExplainabilityJobDefinitions Operation</seealso>
        Task<ListModelExplainabilityJobDefinitionsResponse> ListModelExplainabilityJobDefinitionsAsync(ListModelExplainabilityJobDefinitionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListModelMetadata



        /// <summary>
        /// Lists the domain, framework, task, and model name of standard machine learning models
        /// found in common model zoos.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListModelMetadata service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListModelMetadata service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListModelMetadata">REST API Reference for ListModelMetadata Operation</seealso>
        Task<ListModelMetadataResponse> ListModelMetadataAsync(ListModelMetadataRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListModelPackageGroups



        /// <summary>
        /// Gets a list of the model groups in your Amazon Web Services account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListModelPackageGroups service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListModelPackageGroups service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListModelPackageGroups">REST API Reference for ListModelPackageGroups Operation</seealso>
        Task<ListModelPackageGroupsResponse> ListModelPackageGroupsAsync(ListModelPackageGroupsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListModelPackages



        /// <summary>
        /// Lists the model packages that have been created.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListModelPackages service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListModelPackages service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListModelPackages">REST API Reference for ListModelPackages Operation</seealso>
        Task<ListModelPackagesResponse> ListModelPackagesAsync(ListModelPackagesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListModelQualityJobDefinitions



        /// <summary>
        /// Gets a list of model quality monitoring job definitions in your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListModelQualityJobDefinitions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListModelQualityJobDefinitions service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListModelQualityJobDefinitions">REST API Reference for ListModelQualityJobDefinitions Operation</seealso>
        Task<ListModelQualityJobDefinitionsResponse> ListModelQualityJobDefinitionsAsync(ListModelQualityJobDefinitionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListModels



        /// <summary>
        /// Lists models created with the <c>CreateModel</c> API.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListModels service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListModels service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListModels">REST API Reference for ListModels Operation</seealso>
        Task<ListModelsResponse> ListModelsAsync(ListModelsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListMonitoringAlertHistory



        /// <summary>
        /// Gets a list of past alerts in a model monitoring schedule.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMonitoringAlertHistory service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListMonitoringAlertHistory service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListMonitoringAlertHistory">REST API Reference for ListMonitoringAlertHistory Operation</seealso>
        Task<ListMonitoringAlertHistoryResponse> ListMonitoringAlertHistoryAsync(ListMonitoringAlertHistoryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListMonitoringAlerts



        /// <summary>
        /// Gets the alerts for a single monitoring schedule.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMonitoringAlerts service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListMonitoringAlerts service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListMonitoringAlerts">REST API Reference for ListMonitoringAlerts Operation</seealso>
        Task<ListMonitoringAlertsResponse> ListMonitoringAlertsAsync(ListMonitoringAlertsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListMonitoringExecutions



        /// <summary>
        /// Returns list of all monitoring job executions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMonitoringExecutions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListMonitoringExecutions service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListMonitoringExecutions">REST API Reference for ListMonitoringExecutions Operation</seealso>
        Task<ListMonitoringExecutionsResponse> ListMonitoringExecutionsAsync(ListMonitoringExecutionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListMonitoringSchedules



        /// <summary>
        /// Returns list of all monitoring schedules.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMonitoringSchedules service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListMonitoringSchedules service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListMonitoringSchedules">REST API Reference for ListMonitoringSchedules Operation</seealso>
        Task<ListMonitoringSchedulesResponse> ListMonitoringSchedulesAsync(ListMonitoringSchedulesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListNotebookInstanceLifecycleConfigs



        /// <summary>
        /// Lists notebook instance lifestyle configurations created with the <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_CreateNotebookInstanceLifecycleConfig.html">CreateNotebookInstanceLifecycleConfig</a>
        /// API.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListNotebookInstanceLifecycleConfigs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListNotebookInstanceLifecycleConfigs service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListNotebookInstanceLifecycleConfigs">REST API Reference for ListNotebookInstanceLifecycleConfigs Operation</seealso>
        Task<ListNotebookInstanceLifecycleConfigsResponse> ListNotebookInstanceLifecycleConfigsAsync(ListNotebookInstanceLifecycleConfigsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListNotebookInstances



        /// <summary>
        /// Returns a list of the SageMaker AI notebook instances in the requester's account in
        /// an Amazon Web Services Region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListNotebookInstances service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListNotebookInstances service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListNotebookInstances">REST API Reference for ListNotebookInstances Operation</seealso>
        Task<ListNotebookInstancesResponse> ListNotebookInstancesAsync(ListNotebookInstancesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListOptimizationJobs



        /// <summary>
        /// Lists the optimization jobs in your account and their properties.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListOptimizationJobs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListOptimizationJobs service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListOptimizationJobs">REST API Reference for ListOptimizationJobs Operation</seealso>
        Task<ListOptimizationJobsResponse> ListOptimizationJobsAsync(ListOptimizationJobsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListPartnerApps



        /// <summary>
        /// Lists all of the SageMaker Partner AI Apps in an account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPartnerApps service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListPartnerApps service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListPartnerApps">REST API Reference for ListPartnerApps Operation</seealso>
        Task<ListPartnerAppsResponse> ListPartnerAppsAsync(ListPartnerAppsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListPipelineExecutions



        /// <summary>
        /// Gets a list of the pipeline executions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPipelineExecutions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListPipelineExecutions service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListPipelineExecutions">REST API Reference for ListPipelineExecutions Operation</seealso>
        Task<ListPipelineExecutionsResponse> ListPipelineExecutionsAsync(ListPipelineExecutionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListPipelineExecutionSteps



        /// <summary>
        /// Gets a list of <c>PipeLineExecutionStep</c> objects.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPipelineExecutionSteps service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListPipelineExecutionSteps service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListPipelineExecutionSteps">REST API Reference for ListPipelineExecutionSteps Operation</seealso>
        Task<ListPipelineExecutionStepsResponse> ListPipelineExecutionStepsAsync(ListPipelineExecutionStepsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListPipelineParametersForExecution



        /// <summary>
        /// Gets a list of parameters for a pipeline execution.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPipelineParametersForExecution service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListPipelineParametersForExecution service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListPipelineParametersForExecution">REST API Reference for ListPipelineParametersForExecution Operation</seealso>
        Task<ListPipelineParametersForExecutionResponse> ListPipelineParametersForExecutionAsync(ListPipelineParametersForExecutionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListPipelines



        /// <summary>
        /// Gets a list of pipelines.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPipelines service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListPipelines service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListPipelines">REST API Reference for ListPipelines Operation</seealso>
        Task<ListPipelinesResponse> ListPipelinesAsync(ListPipelinesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListPipelineVersions



        /// <summary>
        /// Gets a list of all versions of the pipeline.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPipelineVersions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListPipelineVersions service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListPipelineVersions">REST API Reference for ListPipelineVersions Operation</seealso>
        Task<ListPipelineVersionsResponse> ListPipelineVersionsAsync(ListPipelineVersionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListProcessingJobs



        /// <summary>
        /// Lists processing jobs that satisfy various filters.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListProcessingJobs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListProcessingJobs service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListProcessingJobs">REST API Reference for ListProcessingJobs Operation</seealso>
        Task<ListProcessingJobsResponse> ListProcessingJobsAsync(ListProcessingJobsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListProjects



        /// <summary>
        /// Gets a list of the projects in an Amazon Web Services account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListProjects service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListProjects service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListProjects">REST API Reference for ListProjects Operation</seealso>
        Task<ListProjectsResponse> ListProjectsAsync(ListProjectsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListResourceCatalogs



        /// <summary>
        /// Lists Amazon SageMaker Catalogs based on given filters and orders. The maximum number
        /// of <c>ResourceCatalog</c>s viewable is 1000.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListResourceCatalogs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListResourceCatalogs service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListResourceCatalogs">REST API Reference for ListResourceCatalogs Operation</seealso>
        Task<ListResourceCatalogsResponse> ListResourceCatalogsAsync(ListResourceCatalogsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListSpaces



        /// <summary>
        /// Lists spaces.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSpaces service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListSpaces service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListSpaces">REST API Reference for ListSpaces Operation</seealso>
        Task<ListSpacesResponse> ListSpacesAsync(ListSpacesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListStageDevices



        /// <summary>
        /// Lists devices allocated to the stage, containing detailed device information and deployment
        /// status.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListStageDevices service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListStageDevices service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListStageDevices">REST API Reference for ListStageDevices Operation</seealso>
        Task<ListStageDevicesResponse> ListStageDevicesAsync(ListStageDevicesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListStudioLifecycleConfigs



        /// <summary>
        /// Lists the Amazon SageMaker AI Studio Lifecycle Configurations in your Amazon Web Services
        /// Account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListStudioLifecycleConfigs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListStudioLifecycleConfigs service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceInUseException">
        /// Resource being accessed is in use.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListStudioLifecycleConfigs">REST API Reference for ListStudioLifecycleConfigs Operation</seealso>
        Task<ListStudioLifecycleConfigsResponse> ListStudioLifecycleConfigsAsync(ListStudioLifecycleConfigsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListSubscribedWorkteams



        /// <summary>
        /// Gets a list of the work teams that you are subscribed to in the Amazon Web Services
        /// Marketplace. The list may be empty if no work team satisfies the filter specified
        /// in the <c>NameContains</c> parameter.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSubscribedWorkteams service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListSubscribedWorkteams service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListSubscribedWorkteams">REST API Reference for ListSubscribedWorkteams Operation</seealso>
        Task<ListSubscribedWorkteamsResponse> ListSubscribedWorkteamsAsync(ListSubscribedWorkteamsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListTags



        /// <summary>
        /// Returns the tags for the specified SageMaker resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTags service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTags service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListTags">REST API Reference for ListTags Operation</seealso>
        Task<ListTagsResponse> ListTagsAsync(ListTagsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListTrainingJobs



        /// <summary>
        /// Lists training jobs.
        /// 
        ///  <note> 
        /// <para>
        /// When <c>StatusEquals</c> and <c>MaxResults</c> are set at the same time, the <c>MaxResults</c>
        /// number of training jobs are first retrieved ignoring the <c>StatusEquals</c> parameter
        /// and then they are filtered by the <c>StatusEquals</c> parameter, which is returned
        /// as a response.
        /// </para>
        ///  
        /// <para>
        /// For example, if <c>ListTrainingJobs</c> is invoked with the following parameters:
        /// </para>
        ///  
        /// <para>
        ///  <c>{ ... MaxResults: 100, StatusEquals: InProgress ... }</c> 
        /// </para>
        ///  
        /// <para>
        /// First, 100 trainings jobs with any status, including those other than <c>InProgress</c>,
        /// are selected (sorted according to the creation time, from the most current to the
        /// oldest). Next, those with a status of <c>InProgress</c> are returned.
        /// </para>
        ///  
        /// <para>
        /// You can quickly test the API using the following Amazon Web Services CLI code.
        /// </para>
        ///  
        /// <para>
        ///  <c>aws sagemaker list-training-jobs --max-results 100 --status-equals InProgress</c>
        /// 
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTrainingJobs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTrainingJobs service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListTrainingJobs">REST API Reference for ListTrainingJobs Operation</seealso>
        Task<ListTrainingJobsResponse> ListTrainingJobsAsync(ListTrainingJobsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListTrainingJobsForHyperParameterTuningJob



        /// <summary>
        /// Gets a list of <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_TrainingJobSummary.html">TrainingJobSummary</a>
        /// objects that describe the training jobs that a hyperparameter tuning job launched.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTrainingJobsForHyperParameterTuningJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTrainingJobsForHyperParameterTuningJob service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListTrainingJobsForHyperParameterTuningJob">REST API Reference for ListTrainingJobsForHyperParameterTuningJob Operation</seealso>
        Task<ListTrainingJobsForHyperParameterTuningJobResponse> ListTrainingJobsForHyperParameterTuningJobAsync(ListTrainingJobsForHyperParameterTuningJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListTrainingPlans



        /// <summary>
        /// Retrieves a list of training plans for the current account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTrainingPlans service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTrainingPlans service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListTrainingPlans">REST API Reference for ListTrainingPlans Operation</seealso>
        Task<ListTrainingPlansResponse> ListTrainingPlansAsync(ListTrainingPlansRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListTransformJobs



        /// <summary>
        /// Lists transform jobs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTransformJobs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTransformJobs service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListTransformJobs">REST API Reference for ListTransformJobs Operation</seealso>
        Task<ListTransformJobsResponse> ListTransformJobsAsync(ListTransformJobsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListTrialComponents



        /// <summary>
        /// Lists the trial components in your account. You can sort the list by trial component
        /// name or creation time. You can filter the list to show only components that were created
        /// in a specific time range. You can also filter on one of the following:
        /// 
        ///  <ul> <li> 
        /// <para>
        ///  <c>ExperimentName</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>SourceArn</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>TrialName</c> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTrialComponents service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTrialComponents service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListTrialComponents">REST API Reference for ListTrialComponents Operation</seealso>
        Task<ListTrialComponentsResponse> ListTrialComponentsAsync(ListTrialComponentsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListTrials



        /// <summary>
        /// Lists the trials in your account. Specify an experiment name to limit the list to
        /// the trials that are part of that experiment. Specify a trial component name to limit
        /// the list to the trials that associated with that trial component. The list can be
        /// filtered to show only trials that were created in a specific time range. The list
        /// can be sorted by trial name or creation time.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTrials service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTrials service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListTrials">REST API Reference for ListTrials Operation</seealso>
        Task<ListTrialsResponse> ListTrialsAsync(ListTrialsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListUserProfiles



        /// <summary>
        /// Lists user profiles.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListUserProfiles service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListUserProfiles service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListUserProfiles">REST API Reference for ListUserProfiles Operation</seealso>
        Task<ListUserProfilesResponse> ListUserProfilesAsync(ListUserProfilesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListWorkforces



        /// <summary>
        /// Use this operation to list all private and vendor workforces in an Amazon Web Services
        /// Region. Note that you can only have one private workforce per Amazon Web Services
        /// Region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListWorkforces service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListWorkforces service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListWorkforces">REST API Reference for ListWorkforces Operation</seealso>
        Task<ListWorkforcesResponse> ListWorkforcesAsync(ListWorkforcesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListWorkteams



        /// <summary>
        /// Gets a list of private work teams that you have defined in a region. The list may
        /// be empty if no work team satisfies the filter specified in the <c>NameContains</c>
        /// parameter.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListWorkteams service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListWorkteams service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListWorkteams">REST API Reference for ListWorkteams Operation</seealso>
        Task<ListWorkteamsResponse> ListWorkteamsAsync(ListWorkteamsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  PutModelPackageGroupPolicy



        /// <summary>
        /// Adds a resouce policy to control access to a model group. For information about resoure
        /// policies, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access_policies_identity-vs-resource.html">Identity-based
        /// policies and resource-based policies</a> in the <i>Amazon Web Services Identity and
        /// Access Management User Guide.</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutModelPackageGroupPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutModelPackageGroupPolicy service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ConflictException">
        /// There was a conflict when you attempted to modify a SageMaker entity such as an <c>Experiment</c>
        /// or <c>Artifact</c>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/PutModelPackageGroupPolicy">REST API Reference for PutModelPackageGroupPolicy Operation</seealso>
        Task<PutModelPackageGroupPolicyResponse> PutModelPackageGroupPolicyAsync(PutModelPackageGroupPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  QueryLineage



        /// <summary>
        /// Use this action to inspect your lineage and discover relationships between entities.
        /// For more information, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/querying-lineage-entities.html">
        /// Querying Lineage Entities</a> in the <i>Amazon SageMaker Developer Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the QueryLineage service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the QueryLineage service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/QueryLineage">REST API Reference for QueryLineage Operation</seealso>
        Task<QueryLineageResponse> QueryLineageAsync(QueryLineageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  RegisterDevices



        /// <summary>
        /// Register devices.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RegisterDevices service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RegisterDevices service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceLimitExceededException">
        /// You have exceeded an SageMaker resource limit. For example, you might have too many
        /// training jobs created.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/RegisterDevices">REST API Reference for RegisterDevices Operation</seealso>
        Task<RegisterDevicesResponse> RegisterDevicesAsync(RegisterDevicesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  RenderUiTemplate



        /// <summary>
        /// Renders the UI template so that you can preview the worker's experience.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RenderUiTemplate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RenderUiTemplate service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/RenderUiTemplate">REST API Reference for RenderUiTemplate Operation</seealso>
        Task<RenderUiTemplateResponse> RenderUiTemplateAsync(RenderUiTemplateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  RetryPipelineExecution



        /// <summary>
        /// Retry the execution of the pipeline.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RetryPipelineExecution service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RetryPipelineExecution service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ConflictException">
        /// There was a conflict when you attempted to modify a SageMaker entity such as an <c>Experiment</c>
        /// or <c>Artifact</c>.
        /// </exception>
        /// <exception cref="Amazon.SageMaker.Model.ResourceLimitExceededException">
        /// You have exceeded an SageMaker resource limit. For example, you might have too many
        /// training jobs created.
        /// </exception>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/RetryPipelineExecution">REST API Reference for RetryPipelineExecution Operation</seealso>
        Task<RetryPipelineExecutionResponse> RetryPipelineExecutionAsync(RetryPipelineExecutionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  Search



        /// <summary>
        /// Finds SageMaker resources that match a search query. Matching resources are returned
        /// as a list of <c>SearchRecord</c> objects in the response. You can sort the search
        /// results by any resource property in a ascending or descending order.
        /// 
        ///  
        /// <para>
        /// You can query against the following value types: numeric, text, Boolean, and timestamp.
        /// </para>
        ///  <note> 
        /// <para>
        /// The Search API may provide access to otherwise restricted data. See <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/api-permissions-reference.html">Amazon
        /// SageMaker API Permissions: Actions, Permissions, and Resources Reference</a> for more
        /// information.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the Search service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the Search service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/Search">REST API Reference for Search Operation</seealso>
        Task<SearchResponse> SearchAsync(SearchRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  SearchTrainingPlanOfferings



        /// <summary>
        /// Searches for available training plan offerings based on specified criteria. 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Users search for available plan offerings based on their requirements (e.g., instance
        /// type, count, start time, duration). 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// And then, they create a plan that best matches their needs using the ID of the plan
        /// offering they want to use. 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information about how to reserve GPU capacity for your SageMaker training
        /// jobs or SageMaker HyperPod clusters using Amazon SageMaker Training Plan , see <c>
        /// <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_CreateTrainingPlan.html">CreateTrainingPlan</a>
        /// </c>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchTrainingPlanOfferings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SearchTrainingPlanOfferings service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceLimitExceededException">
        /// You have exceeded an SageMaker resource limit. For example, you might have too many
        /// training jobs created.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/SearchTrainingPlanOfferings">REST API Reference for SearchTrainingPlanOfferings Operation</seealso>
        Task<SearchTrainingPlanOfferingsResponse> SearchTrainingPlanOfferingsAsync(SearchTrainingPlanOfferingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  SendPipelineExecutionStepFailure



        /// <summary>
        /// Notifies the pipeline that the execution of a callback step failed, along with a message
        /// describing why. When a callback step is run, the pipeline generates a callback token
        /// and includes the token in a message sent to Amazon Simple Queue Service (Amazon SQS).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SendPipelineExecutionStepFailure service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SendPipelineExecutionStepFailure service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ConflictException">
        /// There was a conflict when you attempted to modify a SageMaker entity such as an <c>Experiment</c>
        /// or <c>Artifact</c>.
        /// </exception>
        /// <exception cref="Amazon.SageMaker.Model.ResourceLimitExceededException">
        /// You have exceeded an SageMaker resource limit. For example, you might have too many
        /// training jobs created.
        /// </exception>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/SendPipelineExecutionStepFailure">REST API Reference for SendPipelineExecutionStepFailure Operation</seealso>
        Task<SendPipelineExecutionStepFailureResponse> SendPipelineExecutionStepFailureAsync(SendPipelineExecutionStepFailureRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  SendPipelineExecutionStepSuccess



        /// <summary>
        /// Notifies the pipeline that the execution of a callback step succeeded and provides
        /// a list of the step's output parameters. When a callback step is run, the pipeline
        /// generates a callback token and includes the token in a message sent to Amazon Simple
        /// Queue Service (Amazon SQS).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SendPipelineExecutionStepSuccess service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SendPipelineExecutionStepSuccess service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ConflictException">
        /// There was a conflict when you attempted to modify a SageMaker entity such as an <c>Experiment</c>
        /// or <c>Artifact</c>.
        /// </exception>
        /// <exception cref="Amazon.SageMaker.Model.ResourceLimitExceededException">
        /// You have exceeded an SageMaker resource limit. For example, you might have too many
        /// training jobs created.
        /// </exception>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/SendPipelineExecutionStepSuccess">REST API Reference for SendPipelineExecutionStepSuccess Operation</seealso>
        Task<SendPipelineExecutionStepSuccessResponse> SendPipelineExecutionStepSuccessAsync(SendPipelineExecutionStepSuccessRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  StartEdgeDeploymentStage



        /// <summary>
        /// Starts a stage in an edge deployment plan.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartEdgeDeploymentStage service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartEdgeDeploymentStage service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/StartEdgeDeploymentStage">REST API Reference for StartEdgeDeploymentStage Operation</seealso>
        Task<StartEdgeDeploymentStageResponse> StartEdgeDeploymentStageAsync(StartEdgeDeploymentStageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  StartInferenceExperiment



        /// <summary>
        /// Starts an inference experiment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartInferenceExperiment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartInferenceExperiment service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ConflictException">
        /// There was a conflict when you attempted to modify a SageMaker entity such as an <c>Experiment</c>
        /// or <c>Artifact</c>.
        /// </exception>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/StartInferenceExperiment">REST API Reference for StartInferenceExperiment Operation</seealso>
        Task<StartInferenceExperimentResponse> StartInferenceExperimentAsync(StartInferenceExperimentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  StartMlflowTrackingServer



        /// <summary>
        /// Programmatically start an MLflow Tracking Server.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartMlflowTrackingServer service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartMlflowTrackingServer service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ConflictException">
        /// There was a conflict when you attempted to modify a SageMaker entity such as an <c>Experiment</c>
        /// or <c>Artifact</c>.
        /// </exception>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/StartMlflowTrackingServer">REST API Reference for StartMlflowTrackingServer Operation</seealso>
        Task<StartMlflowTrackingServerResponse> StartMlflowTrackingServerAsync(StartMlflowTrackingServerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  StartMonitoringSchedule



        /// <summary>
        /// Starts a previously stopped monitoring schedule.
        /// 
        ///  <note> 
        /// <para>
        /// By default, when you successfully create a new schedule, the status of a monitoring
        /// schedule is <c>scheduled</c>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartMonitoringSchedule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartMonitoringSchedule service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/StartMonitoringSchedule">REST API Reference for StartMonitoringSchedule Operation</seealso>
        Task<StartMonitoringScheduleResponse> StartMonitoringScheduleAsync(StartMonitoringScheduleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  StartNotebookInstance



        /// <summary>
        /// Launches an ML compute instance with the latest version of the libraries and attaches
        /// your ML storage volume. After configuring the notebook instance, SageMaker AI sets
        /// the notebook instance status to <c>InService</c>. A notebook instance's status must
        /// be <c>InService</c> before you can connect to your Jupyter notebook.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartNotebookInstance service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartNotebookInstance service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceLimitExceededException">
        /// You have exceeded an SageMaker resource limit. For example, you might have too many
        /// training jobs created.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/StartNotebookInstance">REST API Reference for StartNotebookInstance Operation</seealso>
        Task<StartNotebookInstanceResponse> StartNotebookInstanceAsync(StartNotebookInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  StartPipelineExecution



        /// <summary>
        /// Starts a pipeline execution.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartPipelineExecution service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartPipelineExecution service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ConflictException">
        /// There was a conflict when you attempted to modify a SageMaker entity such as an <c>Experiment</c>
        /// or <c>Artifact</c>.
        /// </exception>
        /// <exception cref="Amazon.SageMaker.Model.ResourceLimitExceededException">
        /// You have exceeded an SageMaker resource limit. For example, you might have too many
        /// training jobs created.
        /// </exception>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/StartPipelineExecution">REST API Reference for StartPipelineExecution Operation</seealso>
        Task<StartPipelineExecutionResponse> StartPipelineExecutionAsync(StartPipelineExecutionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  StartSession



        /// <summary>
        /// Initiates a remote connection session between a local integrated development environments
        /// (IDEs) and a remote SageMaker space.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartSession service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartSession service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceLimitExceededException">
        /// You have exceeded an SageMaker resource limit. For example, you might have too many
        /// training jobs created.
        /// </exception>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/StartSession">REST API Reference for StartSession Operation</seealso>
        Task<StartSessionResponse> StartSessionAsync(StartSessionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  StopAutoMLJob



        /// <summary>
        /// A method for forcing a running job to shut down.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopAutoMLJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StopAutoMLJob service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/StopAutoMLJob">REST API Reference for StopAutoMLJob Operation</seealso>
        Task<StopAutoMLJobResponse> StopAutoMLJobAsync(StopAutoMLJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  StopCompilationJob



        /// <summary>
        /// Stops a model compilation job.
        /// 
        ///  
        /// <para>
        ///  To stop a job, Amazon SageMaker AI sends the algorithm the SIGTERM signal. This gracefully
        /// shuts the job down. If the job hasn't stopped, it sends the SIGKILL signal.
        /// </para>
        ///  
        /// <para>
        /// When it receives a <c>StopCompilationJob</c> request, Amazon SageMaker AI changes
        /// the <c>CompilationJobStatus</c> of the job to <c>Stopping</c>. After Amazon SageMaker
        /// stops the job, it sets the <c>CompilationJobStatus</c> to <c>Stopped</c>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopCompilationJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StopCompilationJob service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/StopCompilationJob">REST API Reference for StopCompilationJob Operation</seealso>
        Task<StopCompilationJobResponse> StopCompilationJobAsync(StopCompilationJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  StopEdgeDeploymentStage



        /// <summary>
        /// Stops a stage in an edge deployment plan.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopEdgeDeploymentStage service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StopEdgeDeploymentStage service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/StopEdgeDeploymentStage">REST API Reference for StopEdgeDeploymentStage Operation</seealso>
        Task<StopEdgeDeploymentStageResponse> StopEdgeDeploymentStageAsync(StopEdgeDeploymentStageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  StopEdgePackagingJob



        /// <summary>
        /// Request to stop an edge packaging job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopEdgePackagingJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StopEdgePackagingJob service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/StopEdgePackagingJob">REST API Reference for StopEdgePackagingJob Operation</seealso>
        Task<StopEdgePackagingJobResponse> StopEdgePackagingJobAsync(StopEdgePackagingJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  StopHyperParameterTuningJob



        /// <summary>
        /// Stops a running hyperparameter tuning job and all running training jobs that the tuning
        /// job launched.
        /// 
        ///  
        /// <para>
        /// All model artifacts output from the training jobs are stored in Amazon Simple Storage
        /// Service (Amazon S3). All data that the training jobs write to Amazon CloudWatch Logs
        /// are still available in CloudWatch. After the tuning job moves to the <c>Stopped</c>
        /// state, it releases all reserved resources for the tuning job.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopHyperParameterTuningJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StopHyperParameterTuningJob service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/StopHyperParameterTuningJob">REST API Reference for StopHyperParameterTuningJob Operation</seealso>
        Task<StopHyperParameterTuningJobResponse> StopHyperParameterTuningJobAsync(StopHyperParameterTuningJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  StopInferenceExperiment



        /// <summary>
        /// Stops an inference experiment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopInferenceExperiment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StopInferenceExperiment service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ConflictException">
        /// There was a conflict when you attempted to modify a SageMaker entity such as an <c>Experiment</c>
        /// or <c>Artifact</c>.
        /// </exception>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/StopInferenceExperiment">REST API Reference for StopInferenceExperiment Operation</seealso>
        Task<StopInferenceExperimentResponse> StopInferenceExperimentAsync(StopInferenceExperimentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  StopInferenceRecommendationsJob



        /// <summary>
        /// Stops an Inference Recommender job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopInferenceRecommendationsJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StopInferenceRecommendationsJob service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/StopInferenceRecommendationsJob">REST API Reference for StopInferenceRecommendationsJob Operation</seealso>
        Task<StopInferenceRecommendationsJobResponse> StopInferenceRecommendationsJobAsync(StopInferenceRecommendationsJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  StopLabelingJob



        /// <summary>
        /// Stops a running labeling job. A job that is stopped cannot be restarted. Any results
        /// obtained before the job is stopped are placed in the Amazon S3 output bucket.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopLabelingJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StopLabelingJob service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/StopLabelingJob">REST API Reference for StopLabelingJob Operation</seealso>
        Task<StopLabelingJobResponse> StopLabelingJobAsync(StopLabelingJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  StopMlflowTrackingServer



        /// <summary>
        /// Programmatically stop an MLflow Tracking Server.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopMlflowTrackingServer service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StopMlflowTrackingServer service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ConflictException">
        /// There was a conflict when you attempted to modify a SageMaker entity such as an <c>Experiment</c>
        /// or <c>Artifact</c>.
        /// </exception>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/StopMlflowTrackingServer">REST API Reference for StopMlflowTrackingServer Operation</seealso>
        Task<StopMlflowTrackingServerResponse> StopMlflowTrackingServerAsync(StopMlflowTrackingServerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  StopMonitoringSchedule



        /// <summary>
        /// Stops a previously started monitoring schedule.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopMonitoringSchedule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StopMonitoringSchedule service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/StopMonitoringSchedule">REST API Reference for StopMonitoringSchedule Operation</seealso>
        Task<StopMonitoringScheduleResponse> StopMonitoringScheduleAsync(StopMonitoringScheduleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  StopNotebookInstance



        /// <summary>
        /// Terminates the ML compute instance. Before terminating the instance, SageMaker AI
        /// disconnects the ML storage volume from it. SageMaker AI preserves the ML storage volume.
        /// SageMaker AI stops charging you for the ML compute instance when you call <c>StopNotebookInstance</c>.
        /// 
        ///  
        /// <para>
        /// To access data on the ML storage volume for a notebook instance that has been terminated,
        /// call the <c>StartNotebookInstance</c> API. <c>StartNotebookInstance</c> launches another
        /// ML compute instance, configures it, and attaches the preserved ML storage volume so
        /// you can continue your work. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopNotebookInstance service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StopNotebookInstance service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/StopNotebookInstance">REST API Reference for StopNotebookInstance Operation</seealso>
        Task<StopNotebookInstanceResponse> StopNotebookInstanceAsync(StopNotebookInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  StopOptimizationJob



        /// <summary>
        /// Ends a running inference optimization job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopOptimizationJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StopOptimizationJob service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/StopOptimizationJob">REST API Reference for StopOptimizationJob Operation</seealso>
        Task<StopOptimizationJobResponse> StopOptimizationJobAsync(StopOptimizationJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  StopPipelineExecution



        /// <summary>
        /// Stops a pipeline execution.
        /// 
        ///  
        /// <para>
        ///  <b>Callback Step</b> 
        /// </para>
        ///  
        /// <para>
        /// A pipeline execution won't stop while a callback step is running. When you call <c>StopPipelineExecution</c>
        /// on a pipeline execution with a running callback step, SageMaker Pipelines sends an
        /// additional Amazon SQS message to the specified SQS queue. The body of the SQS message
        /// contains a "Status" field which is set to "Stopping".
        /// </para>
        ///  
        /// <para>
        /// You should add logic to your Amazon SQS message consumer to take any needed action
        /// (for example, resource cleanup) upon receipt of the message followed by a call to
        /// <c>SendPipelineExecutionStepSuccess</c> or <c>SendPipelineExecutionStepFailure</c>.
        /// </para>
        ///  
        /// <para>
        /// Only when SageMaker Pipelines receives one of these calls will it stop the pipeline
        /// execution.
        /// </para>
        ///  
        /// <para>
        ///  <b>Lambda Step</b> 
        /// </para>
        ///  
        /// <para>
        /// A pipeline execution can't be stopped while a lambda step is running because the Lambda
        /// function invoked by the lambda step can't be stopped. If you attempt to stop the execution
        /// while the Lambda function is running, the pipeline waits for the Lambda function to
        /// finish or until the timeout is hit, whichever occurs first, and then stops. If the
        /// Lambda function finishes, the pipeline execution status is <c>Stopped</c>. If the
        /// timeout is hit the pipeline execution status is <c>Failed</c>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopPipelineExecution service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StopPipelineExecution service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ConflictException">
        /// There was a conflict when you attempted to modify a SageMaker entity such as an <c>Experiment</c>
        /// or <c>Artifact</c>.
        /// </exception>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/StopPipelineExecution">REST API Reference for StopPipelineExecution Operation</seealso>
        Task<StopPipelineExecutionResponse> StopPipelineExecutionAsync(StopPipelineExecutionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  StopProcessingJob



        /// <summary>
        /// Stops a processing job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopProcessingJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StopProcessingJob service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/StopProcessingJob">REST API Reference for StopProcessingJob Operation</seealso>
        Task<StopProcessingJobResponse> StopProcessingJobAsync(StopProcessingJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  StopTrainingJob



        /// <summary>
        /// Stops a training job. To stop a job, SageMaker sends the algorithm the <c>SIGTERM</c>
        /// signal, which delays job termination for 120 seconds. Algorithms might use this 120-second
        /// window to save the model artifacts, so the results of the training is not lost. 
        /// 
        ///  
        /// <para>
        /// When it receives a <c>StopTrainingJob</c> request, SageMaker changes the status of
        /// the job to <c>Stopping</c>. After SageMaker stops the job, it sets the status to <c>Stopped</c>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopTrainingJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StopTrainingJob service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/StopTrainingJob">REST API Reference for StopTrainingJob Operation</seealso>
        Task<StopTrainingJobResponse> StopTrainingJobAsync(StopTrainingJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  StopTransformJob



        /// <summary>
        /// Stops a batch transform job.
        /// 
        ///  
        /// <para>
        /// When Amazon SageMaker receives a <c>StopTransformJob</c> request, the status of the
        /// job changes to <c>Stopping</c>. After Amazon SageMaker stops the job, the status is
        /// set to <c>Stopped</c>. When you stop a batch transform job before it is completed,
        /// Amazon SageMaker doesn't store the job's output in Amazon S3.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopTransformJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StopTransformJob service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/StopTransformJob">REST API Reference for StopTransformJob Operation</seealso>
        Task<StopTransformJobResponse> StopTransformJobAsync(StopTransformJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateAction



        /// <summary>
        /// Updates an action.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAction service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateAction service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ConflictException">
        /// There was a conflict when you attempted to modify a SageMaker entity such as an <c>Experiment</c>
        /// or <c>Artifact</c>.
        /// </exception>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/UpdateAction">REST API Reference for UpdateAction Operation</seealso>
        Task<UpdateActionResponse> UpdateActionAsync(UpdateActionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateAppImageConfig



        /// <summary>
        /// Updates the properties of an AppImageConfig.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAppImageConfig service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateAppImageConfig service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/UpdateAppImageConfig">REST API Reference for UpdateAppImageConfig Operation</seealso>
        Task<UpdateAppImageConfigResponse> UpdateAppImageConfigAsync(UpdateAppImageConfigRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateArtifact



        /// <summary>
        /// Updates an artifact.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateArtifact service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateArtifact service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ConflictException">
        /// There was a conflict when you attempted to modify a SageMaker entity such as an <c>Experiment</c>
        /// or <c>Artifact</c>.
        /// </exception>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/UpdateArtifact">REST API Reference for UpdateArtifact Operation</seealso>
        Task<UpdateArtifactResponse> UpdateArtifactAsync(UpdateArtifactRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateCluster



        /// <summary>
        /// Updates a SageMaker HyperPod cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateCluster service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateCluster service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ConflictException">
        /// There was a conflict when you attempted to modify a SageMaker entity such as an <c>Experiment</c>
        /// or <c>Artifact</c>.
        /// </exception>
        /// <exception cref="Amazon.SageMaker.Model.ResourceLimitExceededException">
        /// You have exceeded an SageMaker resource limit. For example, you might have too many
        /// training jobs created.
        /// </exception>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/UpdateCluster">REST API Reference for UpdateCluster Operation</seealso>
        Task<UpdateClusterResponse> UpdateClusterAsync(UpdateClusterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateClusterSchedulerConfig



        /// <summary>
        /// Update the cluster policy configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateClusterSchedulerConfig service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateClusterSchedulerConfig service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ConflictException">
        /// There was a conflict when you attempted to modify a SageMaker entity such as an <c>Experiment</c>
        /// or <c>Artifact</c>.
        /// </exception>
        /// <exception cref="Amazon.SageMaker.Model.ResourceLimitExceededException">
        /// You have exceeded an SageMaker resource limit. For example, you might have too many
        /// training jobs created.
        /// </exception>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/UpdateClusterSchedulerConfig">REST API Reference for UpdateClusterSchedulerConfig Operation</seealso>
        Task<UpdateClusterSchedulerConfigResponse> UpdateClusterSchedulerConfigAsync(UpdateClusterSchedulerConfigRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateClusterSoftware



        /// <summary>
        /// Updates the platform software of a SageMaker HyperPod cluster for security patching.
        /// To learn how to use this API, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/sagemaker-hyperpod-operate.html#sagemaker-hyperpod-operate-cli-command-update-cluster-software">Update
        /// the SageMaker HyperPod platform software of a cluster</a>.
        /// 
        ///  <important> 
        /// <para>
        /// The <c>UpgradeClusterSoftware</c> API call may impact your SageMaker HyperPod cluster
        /// uptime and availability. Plan accordingly to mitigate potential disruptions to your
        /// workloads.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateClusterSoftware service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateClusterSoftware service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ConflictException">
        /// There was a conflict when you attempted to modify a SageMaker entity such as an <c>Experiment</c>
        /// or <c>Artifact</c>.
        /// </exception>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/UpdateClusterSoftware">REST API Reference for UpdateClusterSoftware Operation</seealso>
        Task<UpdateClusterSoftwareResponse> UpdateClusterSoftwareAsync(UpdateClusterSoftwareRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateCodeRepository



        /// <summary>
        /// Updates the specified Git repository with the specified values.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateCodeRepository service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateCodeRepository service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ConflictException">
        /// There was a conflict when you attempted to modify a SageMaker entity such as an <c>Experiment</c>
        /// or <c>Artifact</c>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/UpdateCodeRepository">REST API Reference for UpdateCodeRepository Operation</seealso>
        Task<UpdateCodeRepositoryResponse> UpdateCodeRepositoryAsync(UpdateCodeRepositoryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateComputeQuota



        /// <summary>
        /// Update the compute allocation definition.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateComputeQuota service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateComputeQuota service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ConflictException">
        /// There was a conflict when you attempted to modify a SageMaker entity such as an <c>Experiment</c>
        /// or <c>Artifact</c>.
        /// </exception>
        /// <exception cref="Amazon.SageMaker.Model.ResourceLimitExceededException">
        /// You have exceeded an SageMaker resource limit. For example, you might have too many
        /// training jobs created.
        /// </exception>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/UpdateComputeQuota">REST API Reference for UpdateComputeQuota Operation</seealso>
        Task<UpdateComputeQuotaResponse> UpdateComputeQuotaAsync(UpdateComputeQuotaRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateContext



        /// <summary>
        /// Updates a context.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateContext service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateContext service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ConflictException">
        /// There was a conflict when you attempted to modify a SageMaker entity such as an <c>Experiment</c>
        /// or <c>Artifact</c>.
        /// </exception>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/UpdateContext">REST API Reference for UpdateContext Operation</seealso>
        Task<UpdateContextResponse> UpdateContextAsync(UpdateContextRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateDeviceFleet



        /// <summary>
        /// Updates a fleet of devices.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDeviceFleet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateDeviceFleet service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceInUseException">
        /// Resource being accessed is in use.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/UpdateDeviceFleet">REST API Reference for UpdateDeviceFleet Operation</seealso>
        Task<UpdateDeviceFleetResponse> UpdateDeviceFleetAsync(UpdateDeviceFleetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateDevices



        /// <summary>
        /// Updates one or more devices in a fleet.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDevices service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateDevices service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/UpdateDevices">REST API Reference for UpdateDevices Operation</seealso>
        Task<UpdateDevicesResponse> UpdateDevicesAsync(UpdateDevicesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateDomain



        /// <summary>
        /// Updates the default settings for new user profiles in the domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDomain service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateDomain service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceInUseException">
        /// Resource being accessed is in use.
        /// </exception>
        /// <exception cref="Amazon.SageMaker.Model.ResourceLimitExceededException">
        /// You have exceeded an SageMaker resource limit. For example, you might have too many
        /// training jobs created.
        /// </exception>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/UpdateDomain">REST API Reference for UpdateDomain Operation</seealso>
        Task<UpdateDomainResponse> UpdateDomainAsync(UpdateDomainRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateEndpoint



        /// <summary>
        /// Deploys the <c>EndpointConfig</c> specified in the request to a new fleet of instances.
        /// SageMaker shifts endpoint traffic to the new instances with the updated endpoint configuration
        /// and then deletes the old instances using the previous <c>EndpointConfig</c> (there
        /// is no availability loss). For more information about how to control the update and
        /// traffic shifting process, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/deployment-guardrails.html">
        /// Update models in production</a>.
        /// 
        ///  
        /// <para>
        /// When SageMaker receives the request, it sets the endpoint status to <c>Updating</c>.
        /// After updating the endpoint, it sets the status to <c>InService</c>. To check the
        /// status of an endpoint, use the <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_DescribeEndpoint.html">DescribeEndpoint</a>
        /// API. 
        /// </para>
        ///  <note> 
        /// <para>
        /// You must not delete an <c>EndpointConfig</c> in use by an endpoint that is live or
        /// while the <c>UpdateEndpoint</c> or <c>CreateEndpoint</c> operations are being performed
        /// on the endpoint. To update an endpoint, you must create a new <c>EndpointConfig</c>.
        /// </para>
        ///  
        /// <para>
        /// If you delete the <c>EndpointConfig</c> of an endpoint that is active or being created
        /// or updated you may lose visibility into the instance type the endpoint is using. The
        /// endpoint must be deleted in order to stop incurring charges.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateEndpoint service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateEndpoint service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceLimitExceededException">
        /// You have exceeded an SageMaker resource limit. For example, you might have too many
        /// training jobs created.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/UpdateEndpoint">REST API Reference for UpdateEndpoint Operation</seealso>
        Task<UpdateEndpointResponse> UpdateEndpointAsync(UpdateEndpointRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateEndpointWeightsAndCapacities



        /// <summary>
        /// Updates variant weight of one or more variants associated with an existing endpoint,
        /// or capacity of one variant associated with an existing endpoint. When it receives
        /// the request, SageMaker sets the endpoint status to <c>Updating</c>. After updating
        /// the endpoint, it sets the status to <c>InService</c>. To check the status of an endpoint,
        /// use the <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_DescribeEndpoint.html">DescribeEndpoint</a>
        /// API.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateEndpointWeightsAndCapacities service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateEndpointWeightsAndCapacities service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceLimitExceededException">
        /// You have exceeded an SageMaker resource limit. For example, you might have too many
        /// training jobs created.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/UpdateEndpointWeightsAndCapacities">REST API Reference for UpdateEndpointWeightsAndCapacities Operation</seealso>
        Task<UpdateEndpointWeightsAndCapacitiesResponse> UpdateEndpointWeightsAndCapacitiesAsync(UpdateEndpointWeightsAndCapacitiesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateExperiment



        /// <summary>
        /// Adds, updates, or removes the description of an experiment. Updates the display name
        /// of an experiment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateExperiment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateExperiment service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ConflictException">
        /// There was a conflict when you attempted to modify a SageMaker entity such as an <c>Experiment</c>
        /// or <c>Artifact</c>.
        /// </exception>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/UpdateExperiment">REST API Reference for UpdateExperiment Operation</seealso>
        Task<UpdateExperimentResponse> UpdateExperimentAsync(UpdateExperimentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateFeatureGroup



        /// <summary>
        /// Updates the feature group by either adding features or updating the online store configuration.
        /// Use one of the following request parameters at a time while using the <c>UpdateFeatureGroup</c>
        /// API.
        /// 
        ///  
        /// <para>
        /// You can add features for your feature group using the <c>FeatureAdditions</c> request
        /// parameter. Features cannot be removed from a feature group.
        /// </para>
        ///  
        /// <para>
        /// You can update the online store configuration by using the <c>OnlineStoreConfig</c>
        /// request parameter. If a <c>TtlDuration</c> is specified, the default <c>TtlDuration</c>
        /// applies for all records added to the feature group <i>after the feature group is updated</i>.
        /// If a record level <c>TtlDuration</c> exists from using the <c>PutRecord</c> API, the
        /// record level <c>TtlDuration</c> applies to that record instead of the default <c>TtlDuration</c>.
        /// To remove the default <c>TtlDuration</c> from an existing feature group, use the <c>UpdateFeatureGroup</c>
        /// API and set the <c>TtlDuration</c> <c>Unit</c> and <c>Value</c> to <c>null</c>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateFeatureGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateFeatureGroup service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceLimitExceededException">
        /// You have exceeded an SageMaker resource limit. For example, you might have too many
        /// training jobs created.
        /// </exception>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/UpdateFeatureGroup">REST API Reference for UpdateFeatureGroup Operation</seealso>
        Task<UpdateFeatureGroupResponse> UpdateFeatureGroupAsync(UpdateFeatureGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateFeatureMetadata



        /// <summary>
        /// Updates the description and parameters of the feature group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateFeatureMetadata service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateFeatureMetadata service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/UpdateFeatureMetadata">REST API Reference for UpdateFeatureMetadata Operation</seealso>
        Task<UpdateFeatureMetadataResponse> UpdateFeatureMetadataAsync(UpdateFeatureMetadataRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateHub



        /// <summary>
        /// Update a hub.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateHub service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateHub service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/UpdateHub">REST API Reference for UpdateHub Operation</seealso>
        Task<UpdateHubResponse> UpdateHubAsync(UpdateHubRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateHubContent



        /// <summary>
        /// Updates SageMaker hub content (either a <c>Model</c> or <c>Notebook</c> resource).
        /// 
        ///  
        /// <para>
        /// You can update the metadata that describes the resource. In addition to the required
        /// request fields, specify at least one of the following fields to update:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>HubContentDescription</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>HubContentDisplayName</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>HubContentMarkdown</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>HubContentSearchKeywords</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>SupportStatus</c> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information about hubs, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/jumpstart-curated-hubs.html">Private
        /// curated hubs for foundation model access control in JumpStart</a>.
        /// </para>
        ///  <note> 
        /// <para>
        /// If you want to update a <c>ModelReference</c> resource in your hub, use the <c>UpdateHubContentResource</c>
        /// API instead.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateHubContent service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateHubContent service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceInUseException">
        /// Resource being accessed is in use.
        /// </exception>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/UpdateHubContent">REST API Reference for UpdateHubContent Operation</seealso>
        Task<UpdateHubContentResponse> UpdateHubContentAsync(UpdateHubContentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateHubContentReference



        /// <summary>
        /// Updates the contents of a SageMaker hub for a <c>ModelReference</c> resource. A <c>ModelReference</c>
        /// allows you to access public SageMaker JumpStart models from within your private hub.
        /// 
        ///  
        /// <para>
        /// When using this API, you can update the <c>MinVersion</c> field for additional flexibility
        /// in the model version. You shouldn't update any additional fields when using this API,
        /// because the metadata in your private hub should match the public JumpStart model's
        /// metadata.
        /// </para>
        ///  <note> 
        /// <para>
        /// If you want to update a <c>Model</c> or <c>Notebook</c> resource in your hub, use
        /// the <c>UpdateHubContent</c> API instead.
        /// </para>
        ///  </note> 
        /// <para>
        /// For more information about adding model references to your hub, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/jumpstart-curated-hubs-admin-guide-add-models.html">
        /// Add models to a private hub</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateHubContentReference service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateHubContentReference service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceInUseException">
        /// Resource being accessed is in use.
        /// </exception>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/UpdateHubContentReference">REST API Reference for UpdateHubContentReference Operation</seealso>
        Task<UpdateHubContentReferenceResponse> UpdateHubContentReferenceAsync(UpdateHubContentReferenceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateImage



        /// <summary>
        /// Updates the properties of a SageMaker AI image. To change the image's tags, use the
        /// <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_AddTags.html">AddTags</a>
        /// and <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_DeleteTags.html">DeleteTags</a>
        /// APIs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateImage service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateImage service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceInUseException">
        /// Resource being accessed is in use.
        /// </exception>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/UpdateImage">REST API Reference for UpdateImage Operation</seealso>
        Task<UpdateImageResponse> UpdateImageAsync(UpdateImageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateImageVersion



        /// <summary>
        /// Updates the properties of a SageMaker AI image version.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateImageVersion service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateImageVersion service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceInUseException">
        /// Resource being accessed is in use.
        /// </exception>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/UpdateImageVersion">REST API Reference for UpdateImageVersion Operation</seealso>
        Task<UpdateImageVersionResponse> UpdateImageVersionAsync(UpdateImageVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateInferenceComponent



        /// <summary>
        /// Updates an inference component.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateInferenceComponent service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateInferenceComponent service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceLimitExceededException">
        /// You have exceeded an SageMaker resource limit. For example, you might have too many
        /// training jobs created.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/UpdateInferenceComponent">REST API Reference for UpdateInferenceComponent Operation</seealso>
        Task<UpdateInferenceComponentResponse> UpdateInferenceComponentAsync(UpdateInferenceComponentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateInferenceComponentRuntimeConfig



        /// <summary>
        /// Runtime settings for a model that is deployed with an inference component.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateInferenceComponentRuntimeConfig service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateInferenceComponentRuntimeConfig service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceLimitExceededException">
        /// You have exceeded an SageMaker resource limit. For example, you might have too many
        /// training jobs created.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/UpdateInferenceComponentRuntimeConfig">REST API Reference for UpdateInferenceComponentRuntimeConfig Operation</seealso>
        Task<UpdateInferenceComponentRuntimeConfigResponse> UpdateInferenceComponentRuntimeConfigAsync(UpdateInferenceComponentRuntimeConfigRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateInferenceExperiment



        /// <summary>
        /// Updates an inference experiment that you created. The status of the inference experiment
        /// has to be either <c>Created</c>, <c>Running</c>. For more information on the status
        /// of an inference experiment, see <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_DescribeInferenceExperiment.html">DescribeInferenceExperiment</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateInferenceExperiment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateInferenceExperiment service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ConflictException">
        /// There was a conflict when you attempted to modify a SageMaker entity such as an <c>Experiment</c>
        /// or <c>Artifact</c>.
        /// </exception>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/UpdateInferenceExperiment">REST API Reference for UpdateInferenceExperiment Operation</seealso>
        Task<UpdateInferenceExperimentResponse> UpdateInferenceExperimentAsync(UpdateInferenceExperimentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateMlflowTrackingServer



        /// <summary>
        /// Updates properties of an existing MLflow Tracking Server.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateMlflowTrackingServer service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateMlflowTrackingServer service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ConflictException">
        /// There was a conflict when you attempted to modify a SageMaker entity such as an <c>Experiment</c>
        /// or <c>Artifact</c>.
        /// </exception>
        /// <exception cref="Amazon.SageMaker.Model.ResourceLimitExceededException">
        /// You have exceeded an SageMaker resource limit. For example, you might have too many
        /// training jobs created.
        /// </exception>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/UpdateMlflowTrackingServer">REST API Reference for UpdateMlflowTrackingServer Operation</seealso>
        Task<UpdateMlflowTrackingServerResponse> UpdateMlflowTrackingServerAsync(UpdateMlflowTrackingServerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateModelCard



        /// <summary>
        /// Update an Amazon SageMaker Model Card.
        /// 
        ///  <important> 
        /// <para>
        /// You cannot update both model card content and model card status in a single call.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateModelCard service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateModelCard service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ConflictException">
        /// There was a conflict when you attempted to modify a SageMaker entity such as an <c>Experiment</c>
        /// or <c>Artifact</c>.
        /// </exception>
        /// <exception cref="Amazon.SageMaker.Model.ResourceLimitExceededException">
        /// You have exceeded an SageMaker resource limit. For example, you might have too many
        /// training jobs created.
        /// </exception>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/UpdateModelCard">REST API Reference for UpdateModelCard Operation</seealso>
        Task<UpdateModelCardResponse> UpdateModelCardAsync(UpdateModelCardRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateModelPackage



        /// <summary>
        /// Updates a versioned model.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateModelPackage service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateModelPackage service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ConflictException">
        /// There was a conflict when you attempted to modify a SageMaker entity such as an <c>Experiment</c>
        /// or <c>Artifact</c>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/UpdateModelPackage">REST API Reference for UpdateModelPackage Operation</seealso>
        Task<UpdateModelPackageResponse> UpdateModelPackageAsync(UpdateModelPackageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateMonitoringAlert



        /// <summary>
        /// Update the parameters of a model monitor alert.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateMonitoringAlert service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateMonitoringAlert service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceLimitExceededException">
        /// You have exceeded an SageMaker resource limit. For example, you might have too many
        /// training jobs created.
        /// </exception>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/UpdateMonitoringAlert">REST API Reference for UpdateMonitoringAlert Operation</seealso>
        Task<UpdateMonitoringAlertResponse> UpdateMonitoringAlertAsync(UpdateMonitoringAlertRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateMonitoringSchedule



        /// <summary>
        /// Updates a previously created schedule.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateMonitoringSchedule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateMonitoringSchedule service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceLimitExceededException">
        /// You have exceeded an SageMaker resource limit. For example, you might have too many
        /// training jobs created.
        /// </exception>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/UpdateMonitoringSchedule">REST API Reference for UpdateMonitoringSchedule Operation</seealso>
        Task<UpdateMonitoringScheduleResponse> UpdateMonitoringScheduleAsync(UpdateMonitoringScheduleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateNotebookInstance



        /// <summary>
        /// Updates a notebook instance. NotebookInstance updates include upgrading or downgrading
        /// the ML compute instance used for your notebook instance to accommodate changes in
        /// your workload requirements.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateNotebookInstance service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateNotebookInstance service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceLimitExceededException">
        /// You have exceeded an SageMaker resource limit. For example, you might have too many
        /// training jobs created.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/UpdateNotebookInstance">REST API Reference for UpdateNotebookInstance Operation</seealso>
        Task<UpdateNotebookInstanceResponse> UpdateNotebookInstanceAsync(UpdateNotebookInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateNotebookInstanceLifecycleConfig



        /// <summary>
        /// Updates a notebook instance lifecycle configuration created with the <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_CreateNotebookInstanceLifecycleConfig.html">CreateNotebookInstanceLifecycleConfig</a>
        /// API.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateNotebookInstanceLifecycleConfig service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateNotebookInstanceLifecycleConfig service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceLimitExceededException">
        /// You have exceeded an SageMaker resource limit. For example, you might have too many
        /// training jobs created.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/UpdateNotebookInstanceLifecycleConfig">REST API Reference for UpdateNotebookInstanceLifecycleConfig Operation</seealso>
        Task<UpdateNotebookInstanceLifecycleConfigResponse> UpdateNotebookInstanceLifecycleConfigAsync(UpdateNotebookInstanceLifecycleConfigRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdatePartnerApp



        /// <summary>
        /// Updates all of the SageMaker Partner AI Apps in an account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdatePartnerApp service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdatePartnerApp service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ConflictException">
        /// There was a conflict when you attempted to modify a SageMaker entity such as an <c>Experiment</c>
        /// or <c>Artifact</c>.
        /// </exception>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/UpdatePartnerApp">REST API Reference for UpdatePartnerApp Operation</seealso>
        Task<UpdatePartnerAppResponse> UpdatePartnerAppAsync(UpdatePartnerAppRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdatePipeline



        /// <summary>
        /// Updates a pipeline.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdatePipeline service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdatePipeline service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ConflictException">
        /// There was a conflict when you attempted to modify a SageMaker entity such as an <c>Experiment</c>
        /// or <c>Artifact</c>.
        /// </exception>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/UpdatePipeline">REST API Reference for UpdatePipeline Operation</seealso>
        Task<UpdatePipelineResponse> UpdatePipelineAsync(UpdatePipelineRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdatePipelineExecution



        /// <summary>
        /// Updates a pipeline execution.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdatePipelineExecution service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdatePipelineExecution service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ConflictException">
        /// There was a conflict when you attempted to modify a SageMaker entity such as an <c>Experiment</c>
        /// or <c>Artifact</c>.
        /// </exception>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/UpdatePipelineExecution">REST API Reference for UpdatePipelineExecution Operation</seealso>
        Task<UpdatePipelineExecutionResponse> UpdatePipelineExecutionAsync(UpdatePipelineExecutionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdatePipelineVersion



        /// <summary>
        /// Updates a pipeline version.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdatePipelineVersion service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdatePipelineVersion service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ConflictException">
        /// There was a conflict when you attempted to modify a SageMaker entity such as an <c>Experiment</c>
        /// or <c>Artifact</c>.
        /// </exception>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/UpdatePipelineVersion">REST API Reference for UpdatePipelineVersion Operation</seealso>
        Task<UpdatePipelineVersionResponse> UpdatePipelineVersionAsync(UpdatePipelineVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateProject



        /// <summary>
        /// Updates a machine learning (ML) project that is created from a template that sets
        /// up an ML pipeline from training to deploying an approved model.
        /// 
        ///  <note> 
        /// <para>
        /// You must not update a project that is in use. If you update the <c>ServiceCatalogProvisioningUpdateDetails</c>
        /// of a project that is active or being created, or updated, you may lose resources already
        /// created by the project.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateProject service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateProject service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ConflictException">
        /// There was a conflict when you attempted to modify a SageMaker entity such as an <c>Experiment</c>
        /// or <c>Artifact</c>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/UpdateProject">REST API Reference for UpdateProject Operation</seealso>
        Task<UpdateProjectResponse> UpdateProjectAsync(UpdateProjectRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateSpace



        /// <summary>
        /// Updates the settings of a space.
        /// 
        ///  <note> 
        /// <para>
        /// You can't edit the app type of a space in the <c>SpaceSettings</c>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSpace service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateSpace service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceInUseException">
        /// Resource being accessed is in use.
        /// </exception>
        /// <exception cref="Amazon.SageMaker.Model.ResourceLimitExceededException">
        /// You have exceeded an SageMaker resource limit. For example, you might have too many
        /// training jobs created.
        /// </exception>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/UpdateSpace">REST API Reference for UpdateSpace Operation</seealso>
        Task<UpdateSpaceResponse> UpdateSpaceAsync(UpdateSpaceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateTrainingJob



        /// <summary>
        /// Update a model training job to request a new Debugger profiling configuration or to
        /// change warm pool retention length.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateTrainingJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateTrainingJob service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceLimitExceededException">
        /// You have exceeded an SageMaker resource limit. For example, you might have too many
        /// training jobs created.
        /// </exception>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/UpdateTrainingJob">REST API Reference for UpdateTrainingJob Operation</seealso>
        Task<UpdateTrainingJobResponse> UpdateTrainingJobAsync(UpdateTrainingJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateTrial



        /// <summary>
        /// Updates the display name of a trial.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateTrial service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateTrial service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ConflictException">
        /// There was a conflict when you attempted to modify a SageMaker entity such as an <c>Experiment</c>
        /// or <c>Artifact</c>.
        /// </exception>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/UpdateTrial">REST API Reference for UpdateTrial Operation</seealso>
        Task<UpdateTrialResponse> UpdateTrialAsync(UpdateTrialRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateTrialComponent



        /// <summary>
        /// Updates one or more properties of a trial component.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateTrialComponent service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateTrialComponent service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ConflictException">
        /// There was a conflict when you attempted to modify a SageMaker entity such as an <c>Experiment</c>
        /// or <c>Artifact</c>.
        /// </exception>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/UpdateTrialComponent">REST API Reference for UpdateTrialComponent Operation</seealso>
        Task<UpdateTrialComponentResponse> UpdateTrialComponentAsync(UpdateTrialComponentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateUserProfile



        /// <summary>
        /// Updates a user profile.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateUserProfile service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateUserProfile service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceInUseException">
        /// Resource being accessed is in use.
        /// </exception>
        /// <exception cref="Amazon.SageMaker.Model.ResourceLimitExceededException">
        /// You have exceeded an SageMaker resource limit. For example, you might have too many
        /// training jobs created.
        /// </exception>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/UpdateUserProfile">REST API Reference for UpdateUserProfile Operation</seealso>
        Task<UpdateUserProfileResponse> UpdateUserProfileAsync(UpdateUserProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateWorkforce



        /// <summary>
        /// Use this operation to update your workforce. You can use this operation to require
        /// that workers use specific IP addresses to work on tasks and to update your OpenID
        /// Connect (OIDC) Identity Provider (IdP) workforce configuration.
        /// 
        ///  
        /// <para>
        /// The worker portal is now supported in VPC and public internet.
        /// </para>
        ///  
        /// <para>
        ///  Use <c>SourceIpConfig</c> to restrict worker access to tasks to a specific range
        /// of IP addresses. You specify allowed IP addresses by creating a list of up to ten
        /// <a href="https://docs.aws.amazon.com/vpc/latest/userguide/VPC_Subnets.html">CIDRs</a>.
        /// By default, a workforce isn't restricted to specific IP addresses. If you specify
        /// a range of IP addresses, workers who attempt to access tasks using any IP address
        /// outside the specified range are denied and get a <c>Not Found</c> error message on
        /// the worker portal.
        /// </para>
        ///  
        /// <para>
        /// To restrict access to all the workers in public internet, add the <c>SourceIpConfig</c>
        /// CIDR value as "10.0.0.0/16".
        /// </para>
        ///  <important> 
        /// <para>
        /// Amazon SageMaker does not support Source Ip restriction for worker portals in VPC.
        /// </para>
        ///  </important> 
        /// <para>
        /// Use <c>OidcConfig</c> to update the configuration of a workforce created using your
        /// own OIDC IdP. 
        /// </para>
        ///  <important> 
        /// <para>
        /// You can only update your OIDC IdP configuration when there are no work teams associated
        /// with your workforce. You can delete work teams using the <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_DeleteWorkteam.html">DeleteWorkteam</a>
        /// operation.
        /// </para>
        ///  </important> 
        /// <para>
        /// After restricting access to a range of IP addresses or updating your OIDC IdP configuration
        /// with this operation, you can view details about your update workforce using the <a
        /// href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_DescribeWorkforce.html">DescribeWorkforce</a>
        /// operation.
        /// </para>
        ///  <important> 
        /// <para>
        /// This operation only applies to private workforces.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateWorkforce service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateWorkforce service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ConflictException">
        /// There was a conflict when you attempted to modify a SageMaker entity such as an <c>Experiment</c>
        /// or <c>Artifact</c>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/UpdateWorkforce">REST API Reference for UpdateWorkforce Operation</seealso>
        Task<UpdateWorkforceResponse> UpdateWorkforceAsync(UpdateWorkforceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateWorkteam



        /// <summary>
        /// Updates an existing work team with new member definitions or description.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateWorkteam service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateWorkteam service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceLimitExceededException">
        /// You have exceeded an SageMaker resource limit. For example, you might have too many
        /// training jobs created.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/UpdateWorkteam">REST API Reference for UpdateWorkteam Operation</seealso>
        Task<UpdateWorkteamResponse> UpdateWorkteamAsync(UpdateWorkteamRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

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
        [System.Diagnostics.CodeAnalysis.DynamicDependency(System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypes.PublicProperties, typeof(AmazonSageMakerConfig))]
        static ClientConfig IAmazonService.CreateDefaultClientConfig() => new AmazonSageMakerConfig();

        /// <inheritdoc/>
        [System.Diagnostics.CodeAnalysis.UnconditionalSuppressMessage("AssemblyLoadTrimming", "IL2026:RequiresUnreferencedCode",
    Justification = "This suppression is here to ignore the warnings caused by CognitoSync. See justification in IAmazonService.")]
        static IAmazonService IAmazonService.CreateDefaultServiceClient(AWSCredentials awsCredentials, ClientConfig clientConfig)
        {
            var serviceClientConfig = clientConfig as AmazonSageMakerConfig;
            if (serviceClientConfig == null)
            {
                throw new AmazonClientException("ClientConfig is not of type AmazonSageMakerConfig to create AmazonSageMakerClient");
            }

            return awsCredentials == null ? 
                    new AmazonSageMakerClient(serviceClientConfig) :
                    new AmazonSageMakerClient(awsCredentials, serviceClientConfig);
        }
#pragma warning restore CA1033
#endif
        #endregion
    }
}